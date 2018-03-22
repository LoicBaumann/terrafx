// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop.Desktop
{
    [SuppressUnmanagedCodeSecurity]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
    [return: ComAliasName("LRESULT")]
    public /* static */ unsafe delegate nint WNDPROC(
        [In, ComAliasName("HWND")] IntPtr hWnd,
        [In, ComAliasName("UINT")] uint Msg,
        [In, ComAliasName("WPARAM")] nuint wParam,
        [In, ComAliasName("LPARAM")] nint lParam
    );
}