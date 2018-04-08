// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\propidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ unsafe struct CAI
    {
        #region Fields
        [ComAliasName("ULONG")]
        public uint cElems;

        [ComAliasName("SHORT[]")]
        public short* pElems;
        #endregion
    }
}
