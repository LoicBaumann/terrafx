// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\dwrite_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The IDWriteFontList interface represents a list of fonts.</summary>
    [Guid("DA20D8EF-812A-4C43-9802-62EC4ABD7ADE")]
    unsafe public /* blittable */ struct IDWriteFontList1
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        /// <summary>Gets the current locality of a font given its zero-based index.</summary>>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <remarks> The locality enumeration. For fully local files, the result will always be DWRITE_LOCALITY_LOCAL. For downloadable files, the result depends on how much of the file has been downloaded, and GetFont() fails if the locality is REMOTE and potentially fails if PARTIAL. The application can explicitly ask for the font to be enqueued for download via EnqueueFontDownloadRequest followed by BeginDownload().</remarks>
        /// <returns> The locality enumeration.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate DWRITE_LOCALITY GetFontLocality(
            [In] IDWriteFontList1* This,
            [In] UINT32 listIndex
        );

        /// <summary>Gets a font given its zero-based index.</summary>>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="font">Receives a pointer to the newly created font object.</param>
        /// <returns> Standard HRESULT error code. The function returns DWRITE_E_REMOTEFONT if it could not conpublic /* blittable */ struct a remote font.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetFont(
            [In] IDWriteFontList1* This,
            [In] UINT32 listIndex,
            [Out] IDWriteFont3** font
        );

        /// <summary>Gets a font face reference given its zero-based index.</summary>>
        /// <param name="listIndex">Zero-based index of the font in the font list.</param>
        /// <param name="fontFaceReference">Receives a pointer to the newly created font face reference object.</param>
        /// <returns> Standard HRESULT error code.</returns>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetFontFaceReference(
            [In] IDWriteFontList1* This,
            [In] UINT32 listIndex,
            [Out] IDWriteFontFaceReference** fontFaceReference
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IDWriteFontList.Vtbl BaseVtbl;

            public GetFontLocality GetFontLocality;

            public GetFont GetFont;

            public GetFontFaceReference GetFontFaceReference;
            #endregion
        }
        #endregion
    }
}
