// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_5.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10")]
    public /* unmanaged */ unsafe struct IDXGIDevice4
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IDXGIDevice4* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IDXGIDevice4* This
        );
        #endregion

        #region IDXGIObject Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetPrivateData(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("REFGUID")] Guid* Name,
            [In, ComAliasName("UINT")] uint DataSize,
            [In] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetPrivateDataInterface(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetPrivateData(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("REFGUID")] Guid* Name,
            [In, Out, ComAliasName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetParent(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );
        #endregion

        #region IDXGIDevice Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetAdapter(
            [In] IDXGIDevice4* This,
            [Out] IDXGIAdapter** pAdapter
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateSurface(
            [In] IDXGIDevice4* This,
            [In] DXGI_SURFACE_DESC* pDesc,
            [In, ComAliasName("UINT")] uint NumSurfaces,
            [In, ComAliasName("DXGI_USAGE")] uint Usage,
            [In, Optional] DXGI_SHARED_RESOURCE* pSharedResource,
            [Out, ComAliasName("IDXGISurface*[]")] IDXGISurface** ppSurface
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryResourceResidency(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("IUnknown*[]")] IUnknown** ppResources,
            [Out, ComAliasName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus,
            [In, ComAliasName("UINT")] uint NumResources
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetGPUThreadPriority(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("INT")] int Priority
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetGPUThreadPriority(
            [In] IDXGIDevice4* This,
            [Out, ComAliasName("INT")] int* pPriority
        );
        #endregion

        #region IDXGIDevice1 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetMaximumFrameLatency(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("UINT")] uint MaxLatency
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetMaximumFrameLatency(
            [In] IDXGIDevice4* This,
            [Out, ComAliasName("UINT")] uint* pMaxLatency
        );
        #endregion

        #region IDXGIDevice2 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _OfferResources(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ReclaimResources(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out, ComAliasName("BOOL")] int* pDiscarded = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _EnqueueSetEvent(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("HANDLE")] IntPtr hEvent
        );
        #endregion

        #region IDXGIDevice3 Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Trim(
            [In] IDXGIDevice4* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _OfferResources1(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority,
            [In, ComAliasName("UINT")] uint Flags
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _ReclaimResources1(
            [In] IDXGIDevice4* This,
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out] DXGI_RECLAIM_RESOURCE_RESULTS* pResults
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIDevice4* This = &this)
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
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region IDXGIObject Methods
        [return: ComAliasName("HRESULT")]
        public int SetPrivateData(
            [In, ComAliasName("REFGUID")] Guid* Name,
            [In, ComAliasName("UINT")] uint DataSize,
            [In] void* pData
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_SetPrivateData>(lpVtbl->SetPrivateData)(
                    This,
                    Name,
                    DataSize,
                    pData
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetPrivateDataInterface(
            [In, ComAliasName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
                    This,
                    Name,
                    pUnknown
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetPrivateData(
            [In, ComAliasName("REFGUID")] Guid* Name,
            [In, Out, ComAliasName("UINT")] uint* pDataSize,
            [Out] void* pData
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_GetPrivateData>(lpVtbl->GetPrivateData)(
                    This,
                    Name,
                    pDataSize,
                    pData
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetParent(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppParent
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }
        #endregion

        #region IDXGIDevice Methods
        [return: ComAliasName("HRESULT")]
        public int GetAdapter(
            [Out] IDXGIAdapter** pAdapter
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_GetAdapter>(lpVtbl->GetAdapter)(
                    This,
                    pAdapter
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateSurface(
            [In] DXGI_SURFACE_DESC* pDesc,
            [In, ComAliasName("UINT")] uint NumSurfaces,
            [In, ComAliasName("DXGI_USAGE")] uint Usage,
            [In, Optional] DXGI_SHARED_RESOURCE* pSharedResource,
            [Out, ComAliasName("IDXGISurface*[]")] IDXGISurface** ppSurface
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_CreateSurface>(lpVtbl->CreateSurface)(
                    This,
                    pDesc,
                    NumSurfaces,
                    Usage,
                    pSharedResource,
                    ppSurface
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int QueryResourceResidency(
            [In, ComAliasName("IUnknown*[]")] IUnknown** ppResources,
            [Out, ComAliasName("DXGI_RESIDENCY[]")] DXGI_RESIDENCY* pResidencyStatus,
            [In, ComAliasName("UINT")] uint NumResources
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_QueryResourceResidency>(lpVtbl->QueryResourceResidency)(
                    This,
                    ppResources,
                    pResidencyStatus,
                    NumResources
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetGPUThreadPriority(
            [In, ComAliasName("INT")] int Priority
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_SetGPUThreadPriority>(lpVtbl->SetGPUThreadPriority)(
                    This,
                    Priority
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetGPUThreadPriority(
            [Out, ComAliasName("INT")] int* pPriority
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_GetGPUThreadPriority>(lpVtbl->GetGPUThreadPriority)(
                    This,
                    pPriority
                );
            }
        }
        #endregion

        #region IDXGIDevice1 Methods
        [return: ComAliasName("HRESULT")]
        public int SetMaximumFrameLatency(
            [In, ComAliasName("UINT")] uint MaxLatency
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_SetMaximumFrameLatency>(lpVtbl->SetMaximumFrameLatency)(
                    This,
                    MaxLatency
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetMaximumFrameLatency(
            [Out, ComAliasName("UINT")] uint* pMaxLatency
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_GetMaximumFrameLatency>(lpVtbl->GetMaximumFrameLatency)(
                    This,
                    pMaxLatency
                );
            }
        }
        #endregion

        #region IDXGIDevice2 Methods
        [return: ComAliasName("HRESULT")]
        public int OfferResources(
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_OfferResources>(lpVtbl->OfferResources)(
                    This,
                    NumResources,
                    ppResources,
                    Priority
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int ReclaimResources(
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out, ComAliasName("BOOL")] int* pDiscarded = null
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_ReclaimResources>(lpVtbl->ReclaimResources)(
                    This,
                    NumResources,
                    ppResources,
                    pDiscarded
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int EnqueueSetEvent(
            [In, ComAliasName("HANDLE")] IntPtr hEvent
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_EnqueueSetEvent>(lpVtbl->EnqueueSetEvent)(
                    This,
                    hEvent
                );
            }
        }
        #endregion

        #region IDXGIDevice3 Methods
        public void Trim()
        {
            fixed (IDXGIDevice4* This = &this)
            {
                MarshalFunction<_Trim>(lpVtbl->Trim)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int OfferResources1(
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [In] DXGI_OFFER_RESOURCE_PRIORITY Priority,
            [In, ComAliasName("UINT")] uint Flags
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_OfferResources1>(lpVtbl->OfferResources1)(
                    This,
                    NumResources,
                    ppResources,
                    Priority,
                    Flags
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int ReclaimResources1(
            [In, ComAliasName("UINT")] uint NumResources,
            [In, ComAliasName("IDXGIResource*[]")] IDXGIResource** ppResources,
            [Out] DXGI_RECLAIM_RESOURCE_RESULTS* pResults
        )
        {
            fixed (IDXGIDevice4* This = &this)
            {
                return MarshalFunction<_ReclaimResources1>(lpVtbl->ReclaimResources1)(
                    This,
                    NumResources,
                    ppResources,
                    pResults
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

            #region IDXGIObject Fields
            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;
            #endregion

            #region IDXGIDevice Fields
            public IntPtr GetAdapter;

            public IntPtr CreateSurface;

            public IntPtr QueryResourceResidency;

            public IntPtr SetGPUThreadPriority;

            public IntPtr GetGPUThreadPriority;
            #endregion

            #region IDXGIDevice1 Fields
            public IntPtr SetMaximumFrameLatency;

            public IntPtr GetMaximumFrameLatency;
            #endregion

            #region IDXGIDevice2 Fields
            public IntPtr OfferResources;

            public IntPtr ReclaimResources;

            public IntPtr EnqueueSetEvent;
            #endregion

            #region IDXGIDevice3 Fields
            public IntPtr Trim;
            #endregion

            #region Fields
            public IntPtr OfferResources1;

            public IntPtr ReclaimResources1;
            #endregion
        }
        #endregion
    }
}

