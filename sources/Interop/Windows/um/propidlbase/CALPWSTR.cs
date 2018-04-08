// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\propidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public /* unmanaged */ unsafe struct CALPWSTR
    {
        #region Fields
        [ComAliasName("ULONG")]
        public uint cElems;

        [ComAliasName("LPWSTR[]")]
        public char** pElems;
        #endregion
    }
}
