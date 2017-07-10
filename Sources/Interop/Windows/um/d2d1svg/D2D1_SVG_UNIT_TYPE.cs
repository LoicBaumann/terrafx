// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1svg.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Defines the coordinate system used for SVG gradient or clipPath elements.</summary>
    public enum D2D1_SVG_UNIT_TYPE : uint
    {
        /// <summary>The property is set to SVG's 'userSpaceOnUse' value.</summary>
        D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE = 0,

        /// <summary>The property is set to SVG's 'objectBoundingBox' value.</summary>
        D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX = 1,

        D2D1_SVG_UNIT_TYPE_FORCE_DWORD = 0xFFFFFFFF
    }
}
