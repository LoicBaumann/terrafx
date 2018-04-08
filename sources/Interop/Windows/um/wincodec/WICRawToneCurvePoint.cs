// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public /* unmanaged */ struct WICRawToneCurvePoint
    {
        #region Fields
        public double Input;

        public double Output;
        #endregion
    }
}
