// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Composition;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using TerraFX.UI;
using TerraFX.Utilities;
using static TerraFX.Interop.Kernel32;
using static TerraFX.Interop.User32;
using static TerraFX.Interop.Windows;
using static TerraFX.Utilities.AssertionUtilities;
using static TerraFX.Utilities.ExceptionUtilities;
using static TerraFX.Utilities.InteropUtilities;
using static TerraFX.Utilities.State;

namespace TerraFX.Provider.Win32.UI
{
    /// <summary>Provides access to a Win32 based window subsystem.</summary>
    [Export(typeof(IWindowProvider))]
    [Export(typeof(WindowProvider))]
    [Shared]
    public sealed unsafe class WindowProvider : IDisposable, IWindowProvider
    {
        /// <summary>A <c>HMODULE</c> to the entry point module.</summary>
        public static readonly IntPtr EntryPointModule = GetModuleHandle();

        private static readonly NativeDelegate<WNDPROC> ForwardWndProc = new NativeDelegate<WNDPROC>(ForwardWindowMessage);

        private readonly Lazy<ushort> _classAtom;
        private readonly Lazy<DispatchProvider> _dispatchProvider;
        private readonly Lazy<GCHandle> _nativeHandle;
        private readonly ConcurrentDictionary<IntPtr, Window> _windows;

        private State _state;

        /// <summary>Initializes a new instance of the <see cref="WindowProvider" /> class.</summary>
        [ImportingConstructor]
        public WindowProvider(
            [Import] Lazy<DispatchProvider> dispatchProvider
        )
        {
            _classAtom = new Lazy<ushort>(CreateClassAtom, isThreadSafe: true);
            _dispatchProvider = dispatchProvider;
            _nativeHandle = new Lazy<GCHandle>(() => GCHandle.Alloc(this, GCHandleType.Normal), isThreadSafe: true);

            _windows = new ConcurrentDictionary<IntPtr, Window>();
            _ = _state.Transition(to: Initialized);
        }

        /// <summary>Finalizes an instance of the <see cref="WindowProvider" /> class.</summary>
        ~WindowProvider()
        {
            Dispose(isDisposing: false);
        }

        /// <summary>Gets the <c>ATOM</c> of the <see cref="WNDCLASSEX" /> registered for the instance.</summary>
        public ushort ClassAtom => _state.IsNotDisposedOrDisposing ? _classAtom.Value : (ushort)0;

        /// <summary>Gets the <see cref="DispatchProvider" /> for the instance.</summary>
        /// <exception cref="ObjectDisposedException">The instance has already been disposed.</exception>
        public DispatchProvider DispatchProvider
        {
            get
            {
                _state.ThrowIfDisposedOrDisposing();
                return _dispatchProvider.Value;
            }
        }

        /// <summary>Gets the <see cref="GCHandle" /> containing the native handle for the instance.</summary>
        /// <exception cref="ObjectDisposedException">The instance has already been disposed.</exception>
        public GCHandle NativeHandle
        {
            get
            {
                _state.AssertNotDisposedOrDisposing();
                return _nativeHandle.Value;
            }
        }

        /// <summary>Gets the <see cref="IWindow" /> objects created by the instance.</summary>
        /// <exception cref="ObjectDisposedException">The instance has already been disposed.</exception>
        public IEnumerable<IWindow> Windows
        {
            get
            {
                _state.ThrowIfDisposedOrDisposing();
                return _windows.Values;
            }
        }

        /// <summary>Disposes of any unmanaged resources tracked by the instance.</summary>
        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }

        /// <summary>Create a new <see cref="IWindow" /> instance.</summary>
        /// <returns>A new <see cref="IWindow" /> instance</returns>
        /// <exception cref="ObjectDisposedException">The instance has already been disposed.</exception>
        public IWindow CreateWindow()
        {
            _state.ThrowIfDisposedOrDisposing();

            var window = new Window(this);
            _ = _windows.TryAdd(window.Handle, window);

            return window;
        }

        private static IntPtr ForwardWindowMessage(IntPtr hWnd, uint msg, UIntPtr wParam, IntPtr lParam)
        {
            IntPtr result, userData;

            if (msg == WM_CREATE)
            {
                // We allow the WM_CREATE message to be forwarded to the Window instance
                // for hWnd. This allows some delayed initialization to occur since most
                // of the fields in Window are lazy.

                ref var pCreateStruct = ref AsRef<CREATESTRUCT>(lParam);
                userData = (IntPtr)pCreateStruct.lpCreateParams;
                _ = SetWindowLongPtr(hWnd, GWLP_USERDATA, userData);
            }
            else
            {
                userData = GetWindowLongPtr(hWnd, GWLP_USERDATA);
            }

            WindowProvider windowProvider = null!;
            var forwardMessage = false;
            Window? window = null;

            if (userData != IntPtr.Zero)
            {
                windowProvider = (WindowProvider)GCHandle.FromIntPtr(userData).Target!;
                forwardMessage = windowProvider._windows.TryGetValue(hWnd, out window);
            }

            if (forwardMessage)
            {
                if (msg == WM_DESTROY)
                {
                    // We forward the WM_DESTROY message to the corresponding Window instance
                    // so that it can still be properly disposed of in the scenario that the
                    // hWnd was destroyed externally.

                    _ = windowProvider._windows.TryRemove(hWnd, out window);
                }

                result = window!.ProcessWindowMessage(msg, wParam, lParam);
            }
            else
            {
                result = DefWindowProc(hWnd, msg, wParam, lParam);
            }

            return result;
        }

        private static IntPtr GetDesktopCursor()
        {
            var desktopWindowHandle = GetDesktopWindow();

            var desktopClassName = stackalloc char[256]; // 256 is the maximum length of WNDCLASSEX.lpszClassName
            var desktopClassNameLength = GetClassName(desktopWindowHandle, desktopClassName, 256);

            if (desktopClassNameLength == 0)
            {
                ThrowExternalExceptionForLastError(nameof(GetClassName));
            }

            WNDCLASSEX desktopWindowClass;
            var succeeded = GetClassInfoEx(
                lpszClass: desktopClassName,
                lpwcx: &desktopWindowClass
            );

            if (succeeded == FALSE)
            {
                ThrowExternalExceptionForLastError(nameof(GetClassInfoEx));
            }

            return desktopWindowClass.hCursor;
        }

        private ushort CreateClassAtom()
        {
            _state.AssertNotDisposedOrDisposing();

            ushort classAtom;
            {
                // lpszClassName should be less than 256 characters (this includes the null terminator)
                // Currently, we are well below this limit and should be hitting 74 characters + the null terminator

                var className = $"{GetType().FullName}.{EntryPointModule:X16}.{GetHashCode():X8}";
                Assert(className.Length < byte.MaxValue, Resources.ArgumentOutOfRangeExceptionMessage, nameof(className), className);

                fixed (char* lpszClassName = className)
                {
                    var wndClassEx = new WNDCLASSEX {
                        cbSize = SizeOf<WNDCLASSEX>(),
                        style = CS_VREDRAW | CS_HREDRAW | CS_DBLCLKS,
                        lpfnWndProc = ForwardWndProc,
                        /* cbClsExtra = 0, */
                        /* cbWndExtra = 0, */
                        hInstance = EntryPointModule,
                        /* hIcon = IntPtr.Zero, */
                        hCursor = GetDesktopCursor(),
                        hbrBackground = (IntPtr)(COLOR_WINDOW + 1),
                        /* lpszMenuName = null, */
                        lpszClassName = lpszClassName,
                        /* hIconSm = IntPtr.Zero */
                    };

                    classAtom = RegisterClassEx(&wndClassEx);
                }

                if (classAtom == 0)
                {
                    ThrowExternalExceptionForLastError(nameof(RegisterClassEx));
                }
            }
            return classAtom;
        }

        private void Dispose(bool isDisposing)
        {
            var priorState = _state.BeginDispose();

            if (priorState < Disposing) // (previousState != Disposing) && (previousState != Disposed)
            {
                DisposeWindows(isDisposing);
                DisposeClassAtom();
                DisposeNativeHandle();
            }

            _state.EndDispose();
        }

        private void DisposeClassAtom()
        {
            _state.AssertDisposing();

            if (_classAtom.IsValueCreated)
            {
                var result = UnregisterClass((char*)_classAtom.Value, EntryPointModule);

                if (result == FALSE)
                {
                    ThrowExternalExceptionForLastError(nameof(UnregisterClass));
                }
            }
        }

        private void DisposeNativeHandle()
        {
            _state.AssertDisposing();

            if (_nativeHandle.IsValueCreated)
            {
                _nativeHandle.Value.Free();
            }
        }

        private void DisposeWindows(bool isDisposing)
        {
            _state.AssertDisposing();

            if (isDisposing)
            {
                foreach (var windowHandle in _windows.Keys)
                {
                    if (_windows.TryRemove(windowHandle, out var createdWindow))
                    {
                        createdWindow.Dispose();
                    }
                }
            }
            else
            {
                _windows.Clear();
            }

            Assert(_windows.IsEmpty, Resources.ArgumentOutOfRangeExceptionMessage, nameof(_windows.IsEmpty), _windows.IsEmpty);
        }
    }
}
