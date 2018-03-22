// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>User-implementable interface for introspecting on a metafile.</summary>
    [Guid("FD0ECB6B-91E6-411E-8655-395E760F91B4")]
    public /* blittable */ unsafe struct ID2D1GdiMetafileSink1
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1GdiMetafileSink1* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1GdiMetafileSink1* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1GdiMetafileSink1* This
        );
        #endregion

        #region ID2D1GdiMetafileSink Delegates
        /// <summary>Callback for examining a metafile record.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ProcessRecord(
            [In] ID2D1GdiMetafileSink1* This,
            [In, ComAliasName("DWORD")] uint recordType,
            [In, Optional] void* recordData,
            [In, ComAliasName("DWORD")] uint recordDataSize
        );
        #endregion

        #region Delegates
        /// <summary>Callback for examining a metafile record.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ProcessRecord1(
            [In] ID2D1GdiMetafileSink1* This,
            [In, ComAliasName("DWORD")] uint recordType,
            [In, Optional] void* recordData,
            [In, ComAliasName("DWORD")] uint recordDataSize,
            [In, ComAliasName("UINT32")] uint flags
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
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
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1GdiMetafileSink Methods
        [return: ComAliasName("HRESULT")]
        public int ProcessRecord(
            [In, ComAliasName("DWORD")] uint recordType,
            [In, Optional] void* recordData,
            [In, ComAliasName("DWORD")] uint recordDataSize
        )
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return MarshalFunction<_ProcessRecord>(lpVtbl->ProcessRecord)(
                    This,
                    recordType,
                    recordData,
                    recordDataSize
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int ProcessRecord1(
            [In, ComAliasName("DWORD")] uint recordType,
            [In, Optional] void* recordData,
            [In, ComAliasName("DWORD")] uint recordDataSize,
            [In, ComAliasName("UINT32")] uint flags
        )
        {
            fixed (ID2D1GdiMetafileSink1* This = &this)
            {
                return MarshalFunction<_ProcessRecord1>(lpVtbl->ProcessRecord1)(
                    This,
                    recordType,
                    recordData,
                    recordDataSize,
                    flags
                );
            }
        }
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1GdiMetafileSink Fields
            public IntPtr ProcessRecord;
            #endregion

            #region Fields
            public IntPtr ProcessRecord1;
            #endregion
        }
        #endregion
    }
}
