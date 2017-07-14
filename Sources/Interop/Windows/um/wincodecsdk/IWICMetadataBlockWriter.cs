// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\wincodecsdk.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("08FB9676-B444-41E8-8DBE-6A53A542BFF1")]
    unsafe public /* blittable */ struct IWICMetadataBlockWriter
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT InitializeFromBlockReader(
            [In] IWICMetadataBlockWriter* This,
            [In, Optional] IWICMetadataBlockReader* pIMDBlockReader
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetWriterByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In] UINT nIndex,
            [Out, Optional] IWICMetadataWriter** ppIMetadataWriter
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT AddWriter(
            [In] IWICMetadataBlockWriter* This,
            [In, Optional] IWICMetadataWriter* pIMetadataWriter
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetWriterByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In] UINT nIndex,
            [In, Optional] IWICMetadataWriter* pIMetadataWriter
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT RemoveWriterByIndex(
            [In] IWICMetadataBlockWriter* This,
            [In] UINT nIndex
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IWICMetadataBlockReader.Vtbl BaseVtbl;

            public InitializeFromBlockReader InitializeFromBlockReader;

            public GetWriterByIndex GetWriterByIndex;

            public AddWriter AddWriter;

            public SetWriterByIndex SetWriterByIndex;

            public RemoveWriterByIndex RemoveWriterByIndex;
            #endregion
        }
        #endregion
    }
}