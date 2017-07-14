// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the RgbToHue effect's top level properties.</summary>
    public enum D2D1_RGBTOHUE_PROP : uint
    {
        /// <summary>Property Name: "OutputColorSpace" Property Type: D2D1_RGBTOHUE_OUTPUT_COLOR_SPACE</summary>
        D2D1_RGBTOHUE_PROP_OUTPUT_COLOR_SPACE = 0,

        D2D1_RGBTOHUE_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}