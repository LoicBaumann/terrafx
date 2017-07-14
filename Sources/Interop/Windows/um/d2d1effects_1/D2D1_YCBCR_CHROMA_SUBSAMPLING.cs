// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_YCBCR_CHROMA_SUBSAMPLING : uint
    {
        D2D1_YCBCR_CHROMA_SUBSAMPLING_AUTO = 0,

        D2D1_YCBCR_CHROMA_SUBSAMPLING_420 = 1,

        D2D1_YCBCR_CHROMA_SUBSAMPLING_422 = 2,

        D2D1_YCBCR_CHROMA_SUBSAMPLING_444 = 3,

        D2D1_YCBCR_CHROMA_SUBSAMPLING_440 = 4,

        D2D1_YCBCR_CHROMA_SUBSAMPLING_FORCE_DWORD = 0xFFFFFFFF
    }
}