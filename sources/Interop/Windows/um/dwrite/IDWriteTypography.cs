// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Font typography setting.</summary>
    [Guid("55F1112B-1DC2-4B3C-9541-F46894ED85B6")]
    public /* unmanaged */ unsafe struct IDWriteTypography
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDWriteTypography* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDWriteTypography* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDWriteTypography* This
        );
        #endregion

        #region Delegates
        /// <summary>Add font feature.</summary>
        /// <param name="fontFeature">The font feature to add.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _AddFontFeature(
            [In] IDWriteTypography* This,
            [In] DWRITE_FONT_FEATURE fontFeature
        );

        /// <summary>Get the number of font features.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("UINT32")]
        public /* static */ delegate uint _GetFontFeatureCount(
            [In] IDWriteTypography* This
        );

        /// <summary>Get the font feature at the specified index.</summary>
        /// <param name="fontFeatureIndex">The zero-based index of the font feature to get.</param>
        /// <param name="fontFeature">The font feature.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetFontFeature(
            [In] IDWriteTypography* This,
            [In, ComAliasName("UINT32")] uint fontFeatureIndex,
            [Out] DWRITE_FONT_FEATURE* fontFeature
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteTypography* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int AddFontFeature(
            [In] DWRITE_FONT_FEATURE fontFeature
        )
        {
            fixed (IDWriteTypography* This = &this)
            {
                return MarshalFunction<_AddFontFeature>(lpVtbl->AddFontFeature)(
                    This,
                    fontFeature
                );
            }
        }

        [return: ComAliasName("UINT32")]
        public uint GetFontFeatureCount()
        {
            fixed (IDWriteTypography* This = &this)
            {
                return MarshalFunction<_GetFontFeatureCount>(lpVtbl->GetFontFeatureCount)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetFontFeature(
            [In, ComAliasName("UINT32")] uint fontFeatureIndex,
            [Out] DWRITE_FONT_FEATURE* fontFeature
        )
        {
            fixed (IDWriteTypography* This = &this)
            {
                return MarshalFunction<_GetFontFeature>(lpVtbl->GetFontFeature)(
                    This,
                    fontFeatureIndex,
                    fontFeature
                );
            }
        }
        #endregion

        #region Structs
        public /* unmanaged */ struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr AddFontFeature;

            public IntPtr GetFontFeatureCount;

            public IntPtr GetFontFeature;
            #endregion
        }
        #endregion
    }
}

