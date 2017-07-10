// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Describes the pixel format and dpi of a bitmap.</summary>
    public /* blittable */ struct D2D1_BITMAP_PROPERTIES
    {
        #region Fields
        public D2D1_PIXEL_FORMAT pixelFormat;

        public FLOAT dpiX;

        public FLOAT dpiY;
        #endregion
    }
}
