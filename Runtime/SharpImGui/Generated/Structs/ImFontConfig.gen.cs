using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	public unsafe partial struct ImFontConfig
	{
		/// <summary>
		///          // TTF/OTF data
		/// </summary>
		public void* FontData;
		/// <summary>
		///          // TTF/OTF data size
		/// </summary>
		public int FontDataSize;
		/// <summary>
		/// true     // TTF/OTF data ownership taken by the container ImFontAtlas (will delete memory itself).
		/// </summary>
		public byte FontDataOwnedByAtlas;
		/// <summary>
		/// 0        // Index of font within TTF/OTF file
		/// </summary>
		public int FontNo;
		/// <summary>
		///          // Size in pixels for rasterizer (more or less maps to the resulting font height).
		/// </summary>
		public float SizePixels;
		/// <summary>
		/// 2        // Rasterize at higher quality for sub-pixel positioning. Note the difference between 2 and 3 is minimal. You can reduce this to 1 for large glyphs save memory. Read https://github.com/nothings/stb/blob/master/tests/oversample/README.md for details.
		/// </summary>
		public int OversampleH;
		/// <summary>
		/// 1        // Rasterize at higher quality for sub-pixel positioning. This is not really useful as we don't use sub-pixel positions on the Y axis.
		/// </summary>
		public int OversampleV;
		/// <summary>
		/// false    // Align every glyph to pixel boundary. Useful e.g. if you are merging a non-pixel aligned font with the default font. If enabled, you can set OversampleH/V to 1.
		/// </summary>
		public byte PixelSnapH;
		/// <summary>
		/// 0, 0     // Extra spacing (in pixels) between glyphs. Only X axis is supported for now.
		/// </summary>
		public Vector2 GlyphExtraSpacing;
		/// <summary>
		/// 0, 0     // Offset all glyphs from this font input.
		/// </summary>
		public Vector2 GlyphOffset;
		/// <summary>
		/// NULL     // THE ARRAY DATA NEEDS TO PERSIST AS LONG AS THE FONT IS ALIVE. Pointer to a user-provided list of Unicode range (2 value per range, values are inclusive, zero-terminated list).
		/// </summary>
		public ushort* GlyphRanges;
		/// <summary>
		/// 0        // Minimum AdvanceX for glyphs, set Min to align font icons, set both Min/Max to enforce mono-space font
		/// </summary>
		public float GlyphMinAdvanceX;
		/// <summary>
		/// FLT_MAX  // Maximum AdvanceX for glyphs
		/// </summary>
		public float GlyphMaxAdvanceX;
		/// <summary>
		/// false    // Merge into previous ImFont, so you can combine multiple inputs font into one ImFont (e.g. ASCII font + icons + Japanese glyphs). You may want to use GlyphOffset.y when merge font of different heights.
		/// </summary>
		public byte MergeMode;
		/// <summary>
		/// 0        // Settings for custom font builder. THIS IS BUILDER IMPLEMENTATION DEPENDENT. Leave as zero if unsure.
		/// </summary>
		public uint FontBuilderFlags;
		/// <summary>
		/// 1.0f     // Linearly brighten (&gt;1.0f) or darken (&lt;1.0f) font output. Brightening small fonts may be a good workaround to make them more readable. This is a silly thing we may remove in the future.
		/// </summary>
		public float RasterizerMultiply;
		/// <summary>
		/// 1.0f     // DPI scale for rasterization, not altering other font metrics: make it easy to swap between e.g. a 100% and a 400% fonts for a zooming display. IMPORTANT: If you increase this it is expected that you increase font scale accordingly, otherwise quality may look lowered.
		/// </summary>
		public float RasterizerDensity;
		/// <summary>
		/// -1       // Explicitly specify unicode codepoint of ellipsis character. When fonts are being merged first specified ellipsis will be used.
		/// </summary>
		public ushort EllipsisChar;
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Name (strictly to ease debugging)
		/// </summary>
		public fixed byte Name[40];
		public ImFont* DstFont;
	}

	public unsafe partial struct ImFontConfigPtr
	{
		public ImFontConfig* NativePtr { get; }
		public ImFontConfigPtr(ImFontConfig* nativePtr) => NativePtr = nativePtr;
		public ImFontConfigPtr(IntPtr nativePtr) => NativePtr = (ImFontConfig*)nativePtr;
		public static implicit operator ImFontConfigPtr(ImFontConfig* nativePtr) => new ImFontConfigPtr(nativePtr);
		public static implicit operator ImFontConfig* (ImFontConfigPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontConfigPtr(IntPtr nativePtr) => new ImFontConfigPtr(nativePtr);

		/// <summary>
		///          // TTF/OTF data
		/// </summary>
		public IntPtr FontData { get => (IntPtr)NativePtr->FontData; set => NativePtr->FontData = (void*)value; }

		/// <summary>
		///          // TTF/OTF data size
		/// </summary>
		public ref int FontDataSize => ref Unsafe.AsRef<int>(&NativePtr->FontDataSize);

		/// <summary>
		/// true     // TTF/OTF data ownership taken by the container ImFontAtlas (will delete memory itself).
		/// </summary>
		public ref bool FontDataOwnedByAtlas => ref Unsafe.AsRef<bool>(&NativePtr->FontDataOwnedByAtlas);

		/// <summary>
		/// 0        // Index of font within TTF/OTF file
		/// </summary>
		public ref int FontNo => ref Unsafe.AsRef<int>(&NativePtr->FontNo);

		/// <summary>
		///          // Size in pixels for rasterizer (more or less maps to the resulting font height).
		/// </summary>
		public ref float SizePixels => ref Unsafe.AsRef<float>(&NativePtr->SizePixels);

		/// <summary>
		/// 2        // Rasterize at higher quality for sub-pixel positioning. Note the difference between 2 and 3 is minimal. You can reduce this to 1 for large glyphs save memory. Read https://github.com/nothings/stb/blob/master/tests/oversample/README.md for details.
		/// </summary>
		public ref int OversampleH => ref Unsafe.AsRef<int>(&NativePtr->OversampleH);

		/// <summary>
		/// 1        // Rasterize at higher quality for sub-pixel positioning. This is not really useful as we don't use sub-pixel positions on the Y axis.
		/// </summary>
		public ref int OversampleV => ref Unsafe.AsRef<int>(&NativePtr->OversampleV);

		/// <summary>
		/// false    // Align every glyph to pixel boundary. Useful e.g. if you are merging a non-pixel aligned font with the default font. If enabled, you can set OversampleH/V to 1.
		/// </summary>
		public ref bool PixelSnapH => ref Unsafe.AsRef<bool>(&NativePtr->PixelSnapH);

		/// <summary>
		/// 0, 0     // Extra spacing (in pixels) between glyphs. Only X axis is supported for now.
		/// </summary>
		public ref Vector2 GlyphExtraSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphExtraSpacing);

		/// <summary>
		/// 0, 0     // Offset all glyphs from this font input.
		/// </summary>
		public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);

		/// <summary>
		/// NULL     // THE ARRAY DATA NEEDS TO PERSIST AS LONG AS THE FONT IS ALIVE. Pointer to a user-provided list of Unicode range (2 value per range, values are inclusive, zero-terminated list).
		/// </summary>
		public IntPtr GlyphRanges { get => (IntPtr)NativePtr->GlyphRanges; set => NativePtr->GlyphRanges = (ushort*)value; }

		/// <summary>
		/// 0        // Minimum AdvanceX for glyphs, set Min to align font icons, set both Min/Max to enforce mono-space font
		/// </summary>
		public ref float GlyphMinAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMinAdvanceX);

		/// <summary>
		/// FLT_MAX  // Maximum AdvanceX for glyphs
		/// </summary>
		public ref float GlyphMaxAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMaxAdvanceX);

		/// <summary>
		/// false    // Merge into previous ImFont, so you can combine multiple inputs font into one ImFont (e.g. ASCII font + icons + Japanese glyphs). You may want to use GlyphOffset.y when merge font of different heights.
		/// </summary>
		public ref bool MergeMode => ref Unsafe.AsRef<bool>(&NativePtr->MergeMode);

		/// <summary>
		/// 0        // Settings for custom font builder. THIS IS BUILDER IMPLEMENTATION DEPENDENT. Leave as zero if unsure.
		/// </summary>
		public ref uint FontBuilderFlags => ref Unsafe.AsRef<uint>(&NativePtr->FontBuilderFlags);

		/// <summary>
		/// 1.0f     // Linearly brighten (&gt;1.0f) or darken (&lt;1.0f) font output. Brightening small fonts may be a good workaround to make them more readable. This is a silly thing we may remove in the future.
		/// </summary>
		public ref float RasterizerMultiply => ref Unsafe.AsRef<float>(&NativePtr->RasterizerMultiply);

		/// <summary>
		/// 1.0f     // DPI scale for rasterization, not altering other font metrics: make it easy to swap between e.g. a 100% and a 400% fonts for a zooming display. IMPORTANT: If you increase this it is expected that you increase font scale accordingly, otherwise quality may look lowered.
		/// </summary>
		public ref float RasterizerDensity => ref Unsafe.AsRef<float>(&NativePtr->RasterizerDensity);

		/// <summary>
		/// -1       // Explicitly specify unicode codepoint of ellipsis character. When fonts are being merged first specified ellipsis will be used.
		/// </summary>
		public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Name (strictly to ease debugging)
		/// </summary>
		public RangeAccessor<byte> Name => new RangeAccessor<byte>(NativePtr->Name, 40);

		public ImFontPtr DstFont => new ImFontPtr(NativePtr->DstFont);
	}
}
