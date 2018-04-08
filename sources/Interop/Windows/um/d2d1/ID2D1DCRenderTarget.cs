// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Interop.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.DWRITE_MEASURING_MODE;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Issues drawing commands to a GDI device context.</summary>
    [Guid("1C51BC64-DE61-46FD-9899-63A5D8F03950")]
    public /* unmanaged */ unsafe struct ID2D1DCRenderTarget
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1DCRenderTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1DCRenderTarget* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1DCRenderTarget* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1RenderTarget Delegates
        /// <summary>Create a D2D bitmap by copying from memory, or create uninitialized.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateBitmap(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_SIZE_U")] D2D_SIZE_U size,
            [In, Optional] void* srcData,
            [In, ComAliasName("UINT32")] uint pitch,
            [In] D2D1_BITMAP_PROPERTIES* bitmapProperties,
            [Out] ID2D1Bitmap** bitmap
        );

        /// <summary>Create a D2D bitmap by copying a WIC bitmap.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateBitmapFromWicBitmap(
            [In] ID2D1DCRenderTarget* This,
            [In] IWICBitmapSource* wicBitmapSource,
            [In, Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties,
            [Out] ID2D1Bitmap** bitmap
        );

        /// <summary>Create a D2D bitmap by sharing bits from another resource. The bitmap must be compatible with the render target for the call to succeed. For example, an IWICBitmap can be shared with a software target, or a DXGI surface can be shared with a DXGI render target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateSharedBitmap(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [In, Out] void* data,
            [In, Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties,
            [Out] ID2D1Bitmap** bitmap
        );

        /// <summary>Creates a bitmap brush. The bitmap is scaled, rotated, skewed or tiled to fill or pen a geometry.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateBitmapBrush(
            [In] ID2D1DCRenderTarget* This,
            [In, Optional] ID2D1Bitmap* bitmap,
            [In, Optional] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [Out] ID2D1BitmapBrush** bitmapBrush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateSolidColorBrush(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [Out] ID2D1SolidColorBrush** solidColorBrush
        );

        /// <summary>A gradient stop collection represents a set of stops in an ideal unit length. This is the source resource for a linear gradient and radial gradient brush.</summary>
        /// <param name="colorInterpolationGamma">Specifies which space the color interpolation occurs in.</param>
        /// <param name="extendMode">Specifies how the gradient will be extended outside of the unit length.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateGradientStopCollection(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops,
            [In, ComAliasName("UINT32")] uint gradientStopsCount,
            [In] D2D1_GAMMA colorInterpolationGamma,
            [In] D2D1_EXTEND_MODE extendMode,
            [Out] ID2D1GradientStopCollection** gradientStopCollection
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateLinearGradientBrush(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [In] ID2D1GradientStopCollection* gradientStopCollection,
            [Out] ID2D1LinearGradientBrush** linearGradientBrush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateRadialGradientBrush(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [In] ID2D1GradientStopCollection* gradientStopCollection,
            [Out] ID2D1RadialGradientBrush** radialGradientBrush
        );

        /// <summary>Creates a bitmap render target whose bitmap can be used as a source for rendering in the API.</summary>
        /// <param name="desiredSize">The requested size of the target in DIPs. If the pixel size is not specified, the DPI is inherited from the parent target. However, the render target will never contain a fractional number of pixels.</param>
        /// <param name="desiredPixelSize">The requested size of the render target in pixels. If the DIP size is also specified, the DPI is calculated from these two values. If the desired size is not specified, the DPI is inherited from the parent render target. If neither value is specified, the compatible render target will be the same size and have the same DPI as the parent target.</param>
        /// <param name="desiredFormat">The desired pixel format. The format must be compatible with the parent render target type. If the format is not specified, it will be inherited from the parent render target.</param>
        /// <param name="options">Allows the caller to retrieve a GDI compatible render target.</param>
        /// <param name="bitmapRenderTarget">The returned bitmap render target.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateCompatibleRenderTarget(
            [In] ID2D1DCRenderTarget* This,
            [In, Optional, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* desiredSize,
            [In, Optional, ComAliasName("D2D1_SIZE_U")] D2D_SIZE_U* desiredPixelSize,
            [In, Optional] D2D1_PIXEL_FORMAT* desiredFormat,
            [In] D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options,
            [Out] ID2D1BitmapRenderTarget** bitmapRenderTarget
        );

        /// <summary>Creates a layer resource that can be used on any target and which will resize under the covers if necessary.</summary>
        /// <param name="size">The resolution independent minimum size hint for the layer resource. Specify this to prevent unwanted reallocation of the layer backing store. The size is in DIPs, but, it is unaffected by the current world transform. If the size is unspecified, the returned resource is a placeholder and the backing store will be allocated to be the minimum size that can hold the content when the layer is pushed.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateLayer(
            [In] ID2D1DCRenderTarget* This,
            [In, Optional, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* size,
            [Out] ID2D1Layer** layer
        );

        /// <summary>Create a D2D mesh.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _CreateMesh(
            [In] ID2D1DCRenderTarget* This,
            [Out] ID2D1Mesh** mesh
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawLine(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point0,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point1,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawRectangle(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FillRectangle(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawRoundedRectangle(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_ROUNDED_RECT* roundedRect,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FillRoundedRectangle(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_ROUNDED_RECT* roundedRect,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawEllipse(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_ELLIPSE* ellipse,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FillEllipse(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_ELLIPSE* ellipse,
            [In] ID2D1Brush* brush
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawGeometry(
            [In] ID2D1DCRenderTarget* This,
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        );

        /// <param name="opacityBrush">An optionally specified opacity brush. Only the alpha channel of the corresponding brush will be sampled and will be applied to the entire fill of the geometry. If this brush is specified, the fill brush must be a bitmap brush with an extend mode of D2D1_EXTEND_MODE_CLAMP.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FillGeometry(
            [In] ID2D1DCRenderTarget* This,
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In] ID2D1Brush* opacityBrush = null
        );

        /// <summary>Fill a mesh. Since meshes can only render aliased content, the render target antialiasing mode must be set to aliased.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FillMesh(
            [In] ID2D1DCRenderTarget* This,
            [In] ID2D1Mesh* mesh,
            [In] ID2D1Brush* brush
        );

        /// <summary>Fill using the alpha channel of the supplied opacity mask bitmap. The brush opacity will be modulated by the mask. The render target antialiasing mode must be set to aliased.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _FillOpacityMask(
            [In] ID2D1DCRenderTarget* This,
            [In] ID2D1Bitmap* opacityMask,
            [In] ID2D1Brush* brush,
            [In] D2D1_OPACITY_MASK_CONTENT content,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawBitmap(
            [In] ID2D1DCRenderTarget* This,
            [In] ID2D1Bitmap* bitmap,
            [In, Optional, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle,
            [In, ComAliasName("FLOAT")] float opacity = 1.0f,
            [In] D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        );

        /// <summary>Draws the text within the given layout rectangle and by default also performs baseline snapping.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawText(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("WCHAR[]")] char* @string,
            [In, ComAliasName("UINT32")] uint stringLength,
            [In] IDWriteTextFormat* textFormat,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* layoutRect,
            [In] ID2D1Brush* defaultFillBrush,
            [In] D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE,
            [In] DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
        );

        /// <summary>Draw a text layout object. If the layout is not subsequently changed, this can be more efficient than DrawText when drawing the same layout repeatedly.</summary>
        /// <param name="options">The specified text options. If D2D1_DRAW_TEXT_OPTIONS_CLIP is used, the text is clipped to the layout bounds. These bounds are derived from the origin and the layout bounds of the corresponding IDWriteTextLayout object.</param>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawTextLayout(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F origin,
            [In] IDWriteTextLayout* textLayout,
            [In] ID2D1Brush* defaultFillBrush,
            [In] D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _DrawGlyphRun(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In] ID2D1Brush* foregroundBrush,
            [In] DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetAntialiasMode(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_ANTIALIAS_MODE _GetAntialiasMode(
            [In] ID2D1DCRenderTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTextAntialiasMode(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_TEXT_ANTIALIAS_MODE _GetTextAntialiasMode(
            [In] ID2D1DCRenderTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTextRenderingParams(
            [In] ID2D1DCRenderTarget* This,
            [In] IDWriteRenderingParams* textRenderingParams = null
        );

        /// <summary>Retrieve the text render parameters. NOTE: If NULL is specified to SetTextRenderingParameters, NULL will be returned.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTextRenderingParams(
            [In] ID2D1DCRenderTarget* This,
            [Out] IDWriteRenderingParams** textRenderingParams
        );

        /// <summary>Set a tag to correspond to the succeeding primitives. If an error occurs rendering a primitive, the tags can be returned from the Flush or EndDraw call.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTags(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_TAG")] ulong tag1,
            [In, ComAliasName("D2D1_TAG")] ulong tag2
        );

        /// <summary>Retrieves the currently set tags. This does not retrieve the tags corresponding to any primitive that is in error.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTags(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag1 = null,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag2 = null
        );

        /// <summary>Start a layer of drawing calls. The way in which the layer must be resolved is specified first as well as the logical resource that stores the layer parameters. The supplied layer resource might grow if the specified content cannot fit inside it. The layer will grow monotonically on each axis.  If a NULL ID2D1Layer is provided, then a layer resource will be allocated automatically.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _PushLayer(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_LAYER_PARAMETERS* layerParameters,
            [In] ID2D1Layer* layer = null
        );

        /// <summary>Ends a layer that was defined with particular layer resources.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _PopLayer(
            [In] ID2D1DCRenderTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Flush(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag1 = null,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag2 = null
        );

        /// <summary>Gets the current drawing state and saves it into the supplied IDrawingStatckBlock.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SaveDrawingState(
            [In] ID2D1DCRenderTarget* This,
            [In, Out] ID2D1DrawingStateBlock* drawingStateBlock
        );

        /// <summary>Copies the state stored in the block interface.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _RestoreDrawingState(
            [In] ID2D1DCRenderTarget* This,
            [In] ID2D1DrawingStateBlock* drawingStateBlock
        );

        /// <summary>Pushes a clip. The clip can be antialiased. The clip must be axis aligned. If the current world transform is not axis preserving, then the bounding box of the transformed clip rect will be used. The clip will remain in effect until a PopAxisAligned clip call is made.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _PushAxisAlignedClip(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* clipRect,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _PopAxisAlignedClip(
            [In] ID2D1DCRenderTarget* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _Clear(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* clearColor = null
        );

        /// <summary>Start drawing on this render target. Draw calls can only be issued between a BeginDraw and EndDraw call.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _BeginDraw(
            [In] ID2D1DCRenderTarget* This
        );

        /// <summary>Ends drawing on the render target, error results can be retrieved at this time, or when calling flush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _EndDraw(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag1 = null,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag2 = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetPixelFormat(
            [In] ID2D1DCRenderTarget* This,
            [Out] D2D1_PIXEL_FORMAT* pPixelFormat
        );

        /// <summary>Sets the DPI on the render target. This results in the render target being interpreted to a different scale. Neither DPI can be negative. If zero is specified for both, the system DPI is chosen. If one is zero and the other unspecified, the DPI is not changed.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetDpi(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("FLOAT")] float dpiX,
            [In, ComAliasName("FLOAT")] float dpiY
        );

        /// <summary>Return the current DPI from the target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetDpi(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("FLOAT")] float* dpiX,
            [Out, ComAliasName("FLOAT")] float* dpiY
        );

        /// <summary>Returns the size of the render target in DIPs.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetSize(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* pSize
        );

        /// <summary>Returns the size of the render target in pixels.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetPixelSize(
            [In] ID2D1DCRenderTarget* This,
            [Out, ComAliasName("D2D1_SIZE_U")] D2D_SIZE_U* pPixelSize
        );

        /// <summary>Returns the maximum bitmap and render target size that is guaranteed to be supported by the render target.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("UINT32")]
        public /* static */ delegate uint _GetMaximumBitmapSize(
            [In] ID2D1DCRenderTarget* This
        );

        /// <summary>Returns true if the given properties are supported by this render target. The DPI is ignored. NOTE: If the render target type is software, then neither D2D1_FEATURE_LEVEL_9 nor D2D1_FEATURE_LEVEL_10 will be considered to be supported.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("BOOL")]
        public /* static */ delegate int _IsSupported(
            [In] ID2D1DCRenderTarget* This,
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _BindDC(
            [In] ID2D1DCRenderTarget* This,
            [In, ComAliasName("HDC")] IntPtr hDC,
            [In] RECT* pSubRect
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1RenderTarget Methods
        [return: ComAliasName("HRESULT")]
        public int CreateBitmap(
            [In, ComAliasName("D2D1_SIZE_U")] D2D_SIZE_U size,
            [In, Optional] void* srcData,
            [In, ComAliasName("UINT32")] uint pitch,
            [In] D2D1_BITMAP_PROPERTIES* bitmapProperties,
            [Out] ID2D1Bitmap** bitmap
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateBitmap>(lpVtbl->CreateBitmap)(
                    This,
                    size,
                    srcData,
                    pitch,
                    bitmapProperties,
                    bitmap
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateBitmapFromWicBitmap(
            [In] IWICBitmapSource* wicBitmapSource,
            [In, Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties,
            [Out] ID2D1Bitmap** bitmap
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateBitmapFromWicBitmap>(lpVtbl->CreateBitmapFromWicBitmap)(
                    This,
                    wicBitmapSource,
                    bitmapProperties,
                    bitmap
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateSharedBitmap(
            [In, ComAliasName("REFIID")] Guid* riid,
            [In, Out] void* data,
            [In, Optional] D2D1_BITMAP_PROPERTIES* bitmapProperties,
            [Out] ID2D1Bitmap** bitmap
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateSharedBitmap>(lpVtbl->CreateSharedBitmap)(
                    This,
                    riid,
                    data,
                    bitmapProperties,
                    bitmap
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateBitmapBrush(
            [In, Optional] ID2D1Bitmap* bitmap,
            [In, Optional] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [Out] ID2D1BitmapBrush** bitmapBrush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateBitmapBrush>(lpVtbl->CreateBitmapBrush)(
                    This,
                    bitmap,
                    bitmapBrushProperties,
                    brushProperties,
                    bitmapBrush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateSolidColorBrush(
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* color,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [Out] ID2D1SolidColorBrush** solidColorBrush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateSolidColorBrush>(lpVtbl->CreateSolidColorBrush)(
                    This,
                    color,
                    brushProperties,
                    solidColorBrush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateGradientStopCollection(
            [In, ComAliasName("D2D1_GRADIENT_STOP[]")] D2D1_GRADIENT_STOP* gradientStops,
            [In, ComAliasName("UINT32")] uint gradientStopsCount,
            [In] D2D1_GAMMA colorInterpolationGamma,
            [In] D2D1_EXTEND_MODE extendMode,
            [Out] ID2D1GradientStopCollection** gradientStopCollection
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateGradientStopCollection>(lpVtbl->CreateGradientStopCollection)(
                    This,
                    gradientStops,
                    gradientStopsCount,
                    colorInterpolationGamma,
                    extendMode,
                    gradientStopCollection
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateLinearGradientBrush(
            [In] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [In] ID2D1GradientStopCollection* gradientStopCollection,
            [Out] ID2D1LinearGradientBrush** linearGradientBrush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateLinearGradientBrush>(lpVtbl->CreateLinearGradientBrush)(
                    This,
                    linearGradientBrushProperties,
                    brushProperties,
                    gradientStopCollection,
                    linearGradientBrush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateRadialGradientBrush(
            [In] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties,
            [In, Optional] D2D1_BRUSH_PROPERTIES* brushProperties,
            [In] ID2D1GradientStopCollection* gradientStopCollection,
            [Out] ID2D1RadialGradientBrush** radialGradientBrush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateRadialGradientBrush>(lpVtbl->CreateRadialGradientBrush)(
                    This,
                    radialGradientBrushProperties,
                    brushProperties,
                    gradientStopCollection,
                    radialGradientBrush
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateCompatibleRenderTarget(
            [In, Optional, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* desiredSize,
            [In, Optional, ComAliasName("D2D1_SIZE_U")] D2D_SIZE_U* desiredPixelSize,
            [In, Optional] D2D1_PIXEL_FORMAT* desiredFormat,
            [In] D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options,
            [Out] ID2D1BitmapRenderTarget** bitmapRenderTarget
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateCompatibleRenderTarget>(lpVtbl->CreateCompatibleRenderTarget)(
                    This,
                    desiredSize,
                    desiredPixelSize,
                    desiredFormat,
                    options,
                    bitmapRenderTarget
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateLayer(
            [In, Optional, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* size,
            [Out] ID2D1Layer** layer
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateLayer>(lpVtbl->CreateLayer)(
                    This,
                    size,
                    layer
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int CreateMesh(
            [Out] ID2D1Mesh** mesh
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_CreateMesh>(lpVtbl->CreateMesh)(
                    This,
                    mesh
                );
            }
        }

        public void DrawLine(
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point0,
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F point1,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawLine>(lpVtbl->DrawLine)(
                    This,
                    point0,
                    point1,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        public void DrawRectangle(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawRectangle>(lpVtbl->DrawRectangle)(
                    This,
                    rect,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        public void FillRectangle(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* rect,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_FillRectangle>(lpVtbl->FillRectangle)(
                    This,
                    rect,
                    brush
                );
            }
        }

        public void DrawRoundedRectangle(
            [In] D2D1_ROUNDED_RECT* roundedRect,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawRoundedRectangle>(lpVtbl->DrawRoundedRectangle)(
                    This,
                    roundedRect,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        public void FillRoundedRectangle(
            [In] D2D1_ROUNDED_RECT* roundedRect,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_FillRoundedRectangle>(lpVtbl->FillRoundedRectangle)(
                    This,
                    roundedRect,
                    brush
                );
            }
        }

        public void DrawEllipse(
            [In] D2D1_ELLIPSE* ellipse,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawEllipse>(lpVtbl->DrawEllipse)(
                    This,
                    ellipse,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        public void FillEllipse(
            [In] D2D1_ELLIPSE* ellipse,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_FillEllipse>(lpVtbl->FillEllipse)(
                    This,
                    ellipse,
                    brush
                );
            }
        }

        public void DrawGeometry(
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In, ComAliasName("FLOAT")] float strokeWidth = 1.0f,
            [In] ID2D1StrokeStyle* strokeStyle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawGeometry>(lpVtbl->DrawGeometry)(
                    This,
                    geometry,
                    brush,
                    strokeWidth,
                    strokeStyle
                );
            }
        }

        public void FillGeometry(
            [In] ID2D1Geometry* geometry,
            [In] ID2D1Brush* brush,
            [In] ID2D1Brush* opacityBrush = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_FillGeometry>(lpVtbl->FillGeometry)(
                    This,
                    geometry,
                    brush,
                    opacityBrush
                );
            }
        }

        public void FillMesh(
            [In] ID2D1Mesh* mesh,
            [In] ID2D1Brush* brush
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_FillMesh>(lpVtbl->FillMesh)(
                    This,
                    mesh,
                    brush
                );
            }
        }

        public void FillOpacityMask(
            [In] ID2D1Bitmap* opacityMask,
            [In] ID2D1Brush* brush,
            [In] D2D1_OPACITY_MASK_CONTENT content,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle = null,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_FillOpacityMask>(lpVtbl->FillOpacityMask)(
                    This,
                    opacityMask,
                    brush,
                    content,
                    destinationRectangle,
                    sourceRectangle
                );
            }
        }

        public void DrawBitmap(
            [In] ID2D1Bitmap* bitmap,
            [In, Optional, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* destinationRectangle,
            [In, ComAliasName("FLOAT")] float opacity = 1.0f,
            [In] D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawBitmap>(lpVtbl->DrawBitmap)(
                    This,
                    bitmap,
                    destinationRectangle,
                    opacity,
                    interpolationMode,
                    sourceRectangle
                );
            }
        }

        public void DrawText(
            [In, ComAliasName("WCHAR[]")] char* @string,
            [In, ComAliasName("UINT32")] uint stringLength,
            [In] IDWriteTextFormat* textFormat,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* layoutRect,
            [In] ID2D1Brush* defaultFillBrush,
            [In] D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE,
            [In] DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawText>(lpVtbl->DrawText)(
                    This,
                    @string,
                    stringLength,
                    textFormat,
                    layoutRect,
                    defaultFillBrush,
                    options,
                    measuringMode
                );
            }
        }

        public void DrawTextLayout(
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F origin,
            [In] IDWriteTextLayout* textLayout,
            [In] ID2D1Brush* defaultFillBrush,
            [In] D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawTextLayout>(lpVtbl->DrawTextLayout)(
                    This,
                    origin,
                    textLayout,
                    defaultFillBrush,
                    options
                );
            }
        }

        public void DrawGlyphRun(
            [In, ComAliasName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin,
            [In] DWRITE_GLYPH_RUN* glyphRun,
            [In] ID2D1Brush* foregroundBrush,
            [In] DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_DrawGlyphRun>(lpVtbl->DrawGlyphRun)(
                    This,
                    baselineOrigin,
                    glyphRun,
                    foregroundBrush,
                    measuringMode
                );
            }
        }

        public void SetTransform(
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        public void GetTransform(
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }

        public void SetAntialiasMode(
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SetAntialiasMode>(lpVtbl->SetAntialiasMode)(
                    This,
                    antialiasMode
                );
            }
        }

        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_GetAntialiasMode>(lpVtbl->GetAntialiasMode)(
                    This
                );
            }
        }

        public void SetTextAntialiasMode(
            [In] D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SetTextAntialiasMode>(lpVtbl->SetTextAntialiasMode)(
                    This,
                    textAntialiasMode
                );
            }
        }

        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_GetTextAntialiasMode>(lpVtbl->GetTextAntialiasMode)(
                    This
                );
            }
        }

        public void SetTextRenderingParams(
            [In] IDWriteRenderingParams* textRenderingParams = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SetTextRenderingParams>(lpVtbl->SetTextRenderingParams)(
                    This,
                    textRenderingParams
                );
            }
        }

        public void GetTextRenderingParams(
            [Out] IDWriteRenderingParams** textRenderingParams
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetTextRenderingParams>(lpVtbl->GetTextRenderingParams)(
                    This,
                    textRenderingParams
                );
            }
        }

        public void SetTags(
            [In, ComAliasName("D2D1_TAG")] ulong tag1,
            [In, ComAliasName("D2D1_TAG")] ulong tag2
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SetTags>(lpVtbl->SetTags)(
                    This,
                    tag1,
                    tag2
                );
            }
        }

        public void GetTags(
            [Out, ComAliasName("D2D1_TAG")] ulong* tag1 = null,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag2 = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetTags>(lpVtbl->GetTags)(
                    This,
                    tag1,
                    tag2
                );
            }
        }

        public void PushLayer(
            [In] D2D1_LAYER_PARAMETERS* layerParameters,
            [In] ID2D1Layer* layer = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_PushLayer>(lpVtbl->PushLayer)(
                    This,
                    layerParameters,
                    layer
                );
            }
        }

        public void PopLayer()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_PopLayer>(lpVtbl->PopLayer)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Flush(
            [Out, ComAliasName("D2D1_TAG")] ulong* tag1 = null,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag2 = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_Flush>(lpVtbl->Flush)(
                    This,
                    tag1,
                    tag2
                );
            }
        }

        public void SaveDrawingState(
            [In, Out] ID2D1DrawingStateBlock* drawingStateBlock
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SaveDrawingState>(lpVtbl->SaveDrawingState)(
                    This,
                    drawingStateBlock
                );
            }
        }

        public void RestoreDrawingState(
            [In] ID2D1DrawingStateBlock* drawingStateBlock
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_RestoreDrawingState>(lpVtbl->RestoreDrawingState)(
                    This,
                    drawingStateBlock
                );
            }
        }

        public void PushAxisAlignedClip(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* clipRect,
            [In] D2D1_ANTIALIAS_MODE antialiasMode
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_PushAxisAlignedClip>(lpVtbl->PushAxisAlignedClip)(
                    This,
                    clipRect,
                    antialiasMode
                );
            }
        }

        public void PopAxisAlignedClip()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_PopAxisAlignedClip>(lpVtbl->PopAxisAlignedClip)(
                    This
                );
            }
        }

        public void Clear(
            [In, ComAliasName("D2D1_COLOR_F")] DXGI_RGBA* clearColor = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_Clear>(lpVtbl->Clear)(
                    This,
                    clearColor
                );
            }
        }

        public void BeginDraw()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_BeginDraw>(lpVtbl->BeginDraw)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int EndDraw(
            [Out, ComAliasName("D2D1_TAG")] ulong* tag1 = null,
            [Out, ComAliasName("D2D1_TAG")] ulong* tag2 = null
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_EndDraw>(lpVtbl->EndDraw)(
                    This,
                    tag1,
                    tag2
                );
            }
        }

        public void GetPixelFormat(
            [Out] D2D1_PIXEL_FORMAT* pPixelFormat
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    pPixelFormat
                );
            }
        }

        public void SetDpi(
            [In, ComAliasName("FLOAT")] float dpiX,
            [In, ComAliasName("FLOAT")] float dpiY
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_SetDpi>(lpVtbl->SetDpi)(
                    This,
                    dpiX,
                    dpiY
                );
            }
        }

        public void GetDpi(
            [Out, ComAliasName("FLOAT")] float* dpiX,
            [Out, ComAliasName("FLOAT")] float* dpiY
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetDpi>(lpVtbl->GetDpi)(
                    This,
                    dpiX,
                    dpiY
                );
            }
        }

        public void GetSize(
            [Out, ComAliasName("D2D1_SIZE_F")] D2D_SIZE_F* pSize
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetSize>(lpVtbl->GetSize)(
                    This,
                    pSize
                );
            }
        }

        public void GetPixelSize(
            [Out, ComAliasName("D2D1_SIZE_U")] D2D_SIZE_U* pPixelSize
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                MarshalFunction<_GetPixelSize>(lpVtbl->GetPixelSize)(
                    This,
                    pPixelSize
                );
            }
        }

        [return: ComAliasName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_GetMaximumBitmapSize>(lpVtbl->GetMaximumBitmapSize)(
                    This
                );
            }
        }

        [return: ComAliasName("BOOL")]
        public int IsSupported(
            [In] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_IsSupported>(lpVtbl->IsSupported)(
                    This,
                    renderTargetProperties
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int BindDC(
            [In, ComAliasName("HDC")] IntPtr hDC,
            [In] RECT* pSubRect
        )
        {
            fixed (ID2D1DCRenderTarget* This = &this)
            {
                return MarshalFunction<_BindDC>(lpVtbl->BindDC)(
                    This,
                    hDC,
                    pSubRect
                );
            }
        }
        #endregion

        #region Structs
        public /* unmanaged */ struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1RenderTarget Fields
            public IntPtr CreateBitmap;

            public IntPtr CreateBitmapFromWicBitmap;

            public IntPtr CreateSharedBitmap;

            public IntPtr CreateBitmapBrush;

            public IntPtr CreateSolidColorBrush;

            public IntPtr CreateGradientStopCollection;

            public IntPtr CreateLinearGradientBrush;

            public IntPtr CreateRadialGradientBrush;

            public IntPtr CreateCompatibleRenderTarget;

            public IntPtr CreateLayer;

            public IntPtr CreateMesh;

            public IntPtr DrawLine;

            public IntPtr DrawRectangle;

            public IntPtr FillRectangle;

            public IntPtr DrawRoundedRectangle;

            public IntPtr FillRoundedRectangle;

            public IntPtr DrawEllipse;

            public IntPtr FillEllipse;

            public IntPtr DrawGeometry;

            public IntPtr FillGeometry;

            public IntPtr FillMesh;

            public IntPtr FillOpacityMask;

            public IntPtr DrawBitmap;

            public IntPtr DrawText;

            public IntPtr DrawTextLayout;

            public IntPtr DrawGlyphRun;

            public IntPtr SetTransform;

            public IntPtr GetTransform;

            public IntPtr SetAntialiasMode;

            public IntPtr GetAntialiasMode;

            public IntPtr SetTextAntialiasMode;

            public IntPtr GetTextAntialiasMode;

            public IntPtr SetTextRenderingParams;

            public IntPtr GetTextRenderingParams;

            public IntPtr SetTags;

            public IntPtr GetTags;

            public IntPtr PushLayer;

            public IntPtr PopLayer;

            public IntPtr Flush;

            public IntPtr SaveDrawingState;

            public IntPtr RestoreDrawingState;

            public IntPtr PushAxisAlignedClip;

            public IntPtr PopAxisAlignedClip;

            public IntPtr Clear;

            public IntPtr BeginDraw;

            public IntPtr EndDraw;

            public IntPtr GetPixelFormat;

            public IntPtr SetDpi;

            public IntPtr GetDpi;

            public IntPtr GetSize;

            public IntPtr GetPixelSize;

            public IntPtr GetMaximumBitmapSize;

            public IntPtr IsSupported;
            #endregion

            #region Fields
            public IntPtr BindDC;
            #endregion
        }
        #endregion
    }
}

