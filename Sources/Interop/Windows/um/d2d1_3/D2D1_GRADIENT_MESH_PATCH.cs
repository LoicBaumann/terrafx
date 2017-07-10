// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Represents a tensor patch with 16 control points, 4 corner colors, and boundary flags. An ID2D1GradientMesh is made up of 1 or more gradient mesh patches. Use the GradientMeshPatch function or the GradientMeshPatchFromCoonsPatch function to create one.</summary>
    public /* blittable */ struct D2D1_GRADIENT_MESH_PATCH
    {
        #region Fields
        /// <summary>The gradient mesh patch control point at position 00.</summary>
        public D2D1_POINT_2F point00;

        /// <summary>The gradient mesh patch control point at position 01.</summary>
        public D2D1_POINT_2F point01;

        /// <summary>The gradient mesh patch control point at position 02.</summary>
        public D2D1_POINT_2F point02;

        /// <summary>The gradient mesh patch control point at position 03.</summary>
        public D2D1_POINT_2F point03;

        /// <summary>The gradient mesh patch control point at position 10.</summary>
        public D2D1_POINT_2F point10;

        /// <summary>The gradient mesh patch control point at position 11.</summary>
        public D2D1_POINT_2F point11;

        /// <summary>The gradient mesh patch control point at position 12.</summary>
        public D2D1_POINT_2F point12;

        /// <summary>The gradient mesh patch control point at position 13.</summary>
        public D2D1_POINT_2F point13;

        /// <summary>The gradient mesh patch control point at position 20.</summary>
        public D2D1_POINT_2F point20;

        /// <summary>The gradient mesh patch control point at position 21.</summary>
        public D2D1_POINT_2F point21;

        /// <summary>The gradient mesh patch control point at position 22.</summary>
        public D2D1_POINT_2F point22;

        /// <summary>The gradient mesh patch control point at position 23.</summary>
        public D2D1_POINT_2F point23;

        /// <summary>The gradient mesh patch control point at position 30.</summary>
        public D2D1_POINT_2F point30;

        /// <summary>The gradient mesh patch control point at position 31.</summary>
        public D2D1_POINT_2F point31;

        /// <summary>The gradient mesh patch control point at position 32.</summary>
        public D2D1_POINT_2F point32;

        /// <summary>The gradient mesh patch control point at position 33.</summary>
        public D2D1_POINT_2F point33;

        /// <summary>The color associated with control point at position 00.</summary>
        public D2D1_COLOR_F color00;

        /// <summary>The color associated with control point at position 03.</summary>
        public D2D1_COLOR_F color03;

        /// <summary>The color associated with control point at position 30.</summary>
        public D2D1_COLOR_F color30;

        /// <summary>The color associated with control point at position 33.</summary>
        public D2D1_COLOR_F color33;

        /// <summary>The edge mode for the top edge of the patch.</summary>
        public D2D1_PATCH_EDGE_MODE topEdgeMode;

        /// <summary>The edge mode for the left edge of the patch.</summary>
        public D2D1_PATCH_EDGE_MODE leftEdgeMode;

        /// <summary>The edge mode for the bottom edge of the patch.</summary>
        public D2D1_PATCH_EDGE_MODE bottomEdgeMode;

        /// <summary>The edge mode for the right edge of the patch.</summary>
        public D2D1_PATCH_EDGE_MODE rightEdgeMode;
        #endregion
    }
}
