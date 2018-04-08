// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Contains the dimensions and corner radii of a rounded rectangle.</summary>
    public /* unmanaged */ struct D2D1_ROUNDED_RECT
    {
        #region Fields
        [ComAliasName("D2D1_RECT_F")]
        public D2D_RECT_F rect;

        [ComAliasName("FLOAT")]
        public float radiusX;

        [ComAliasName("FLOAT")]
        public float radiusY;
        #endregion
    }
}
