// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The interface implemented by a transform author to provide a CPU based source effect.</summary>
    [Guid("DB1800DD-0C34-4CF9-BE90-31CC0A5653E1")]
    unsafe public /* blittable */ struct ID2D1SourceTransform
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetRenderInfo(
            [In] ID2D1SourceTransform* This,
            [In] ID2D1RenderInfo* renderInfo
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT Draw(
            [In] ID2D1SourceTransform* This,
            [In] ID2D1Bitmap1* target,
            [In] /* readonly */ D2D1_RECT_L* drawRect,
            [In] D2D1_POINT_2U targetOrigin
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public ID2D1Transform.Vtbl BaseVtbl;

            public SetRenderInfo SetRenderInfo;

            public Draw Draw;
            #endregion
        }
        #endregion
    }
}
