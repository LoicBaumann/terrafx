// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Relationship between thin and thick stems. Present for families: 2-text</summary>
    public enum DWRITE_PANOSE_STROKE_VARIATION
    {
        DWRITE_PANOSE_STROKE_VARIATION_ANY = 0,

        DWRITE_PANOSE_STROKE_VARIATION_NO_FIT = 1,

        DWRITE_PANOSE_STROKE_VARIATION_NO_VARIATION = 2,

        DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_DIAGONAL = 3,

        DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_TRANSITIONAL = 4,

        DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_VERTICAL = 5,

        DWRITE_PANOSE_STROKE_VARIATION_GRADUAL_HORIZONTAL = 6,

        DWRITE_PANOSE_STROKE_VARIATION_RAPID_VERTICAL = 7,

        DWRITE_PANOSE_STROKE_VARIATION_RAPID_HORIZONTAL = 8,

        DWRITE_PANOSE_STROKE_VARIATION_INSTANT_VERTICAL = 9,

        DWRITE_PANOSE_STROKE_VARIATION_INSTANT_HORIZONTAL = 10
    }
}
