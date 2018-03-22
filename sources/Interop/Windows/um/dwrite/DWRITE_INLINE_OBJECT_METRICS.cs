// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Properties describing the geometric measurement of an application-defined inline object.</summary>
    public /* blittable */ struct DWRITE_INLINE_OBJECT_METRICS
    {
        #region Fields
        /// <summary>Width of the inline object.</summary>
        [ComAliasName("FLOAT")]
        public float width;

        /// <summary>Height of the inline object as measured from top to bottom.</summary>
        [ComAliasName("FLOAT")]
        public float height;

        /// <summary>Distance from the top of the object to the baseline where it is lined up with the adjacent text. If the baseline is at the bottom, baseline simply equals height.</summary>
        [ComAliasName("FLOAT")]
        public float baseline;

        /// <summary>Flag indicating whether the object is to be placed upright or alongside the text baseline for vertical text.</summary>
        [ComAliasName("BOOL")]
        public int  supportsSideways;
        #endregion
    }
}