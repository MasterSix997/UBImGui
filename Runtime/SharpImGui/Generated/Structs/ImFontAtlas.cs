using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Load and rasterize multiple TTF/OTF fonts into a same texture. The font atlas will build a single texture holding:<br/> - One or more fonts.<br/> - Custom graphics data needed to render the shapes needed by Dear ImGui.<br/> - Mouse cursor shapes for software cursor rendering (unless setting 'Flags |= ImFontAtlasFlags_NoMouseCursors' in the font atlas).<br/>It is the user-code responsibility to setup/build the atlas, then upload the pixel data into a texture accessible by your graphics api.<br/> - Optionally, call any of the AddFont*** functions. If you don't call any, the default font embedded in the code will be loaded for you.<br/> - Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.<br/> - Upload the pixels data into a texture within your graphics system (see imgui_impl_xxxx.cpp examples)<br/> - Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture in a format natural to your graphics API.<br/>   This value will be passed back to you during rendering to identify the texture. Read FAQ entry about ImTextureID for more details.<br/>Common pitfalls:<br/>- If you pass a 'glyph_ranges' array to AddFont*** functions, you need to make sure that your array persist up until the<br/>  atlas is build (when calling GetTexData*** or Build()). We only copy the pointer, not the data.<br/>- Important: By default, AddFontFromMemoryTTF() takes ownership of the data. Even though we are not writing to it, we will free the pointer on destruction.<br/>  You can set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed,<br/>- Even though many functions are suffixed with "TTF", OTF data is supported just as well.<br/>- This is an old API and it is currently awkward for those and various other reasons! We will address them in the future!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlas
	{
		/// <summary>
		///     Input<br/>
		/// Build flags (see ImFontAtlasFlags_)<br/>
		/// </summary>
		public ImFontAtlasFlags Flags;
		/// <summary>
		/// User data to refer to the texture once it has been uploaded to user's graphic systems. It is passed back to you during rendering via the ImDrawCmd structure.<br/>
		/// </summary>
		public ulong TexID;
		/// <summary>
		/// Texture width desired by user before Build(). Must be a power-of-two. If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.<br/>
		/// </summary>
		public int TexDesiredWidth;
		/// <summary>
		/// FIXME: Should be called "TexPackPadding". Padding between glyphs within texture in pixels. Defaults to 1. If your rendering method doesn't rely on bilinear filtering you may set this to 0 (will also need to set AntiAliasedLinesUseTex = false).<br/>
		/// </summary>
		public int TexGlyphPadding;
		/// <summary>
		/// Store your own atlas related user-data (if e.g. you have multiple font atlas).<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		///     [Internal]<br/>    NB: Access texture data via GetTexData*() calls! Which will setup a default font for you.<br/>
		/// Marked as Locked by ImGui::NewFrame() so attempt to modify the atlas will assert.<br/>
		/// </summary>
		public byte Locked;
		/// <summary>
		/// Set when texture was built matching current font input<br/>
		/// </summary>
		public byte TexReady;
		/// <summary>
		/// Tell whether our texture data is known to use colors (rather than just alpha channel), in order to help backend select a format.<br/>
		/// </summary>
		public byte TexPixelsUseColors;
		/// <summary>
		/// 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight<br/>
		/// </summary>
		public unsafe byte* TexPixelsAlpha8;
		/// <summary>
		/// 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4<br/>
		/// </summary>
		public unsafe uint* TexPixelsRgba32;
		/// <summary>
		/// Texture width calculated during Build().<br/>
		/// </summary>
		public int TexWidth;
		/// <summary>
		/// Texture height calculated during Build().<br/>
		/// </summary>
		public int TexHeight;
		/// <summary>
		/// = (1.0f/TexWidth, 1.0f/TexHeight)<br/>
		/// </summary>
		public Vector2 TexUvScale;
		/// <summary>
		/// Texture coordinates to a white pixel<br/>
		/// </summary>
		public Vector2 TexUvWhitePixel;
		/// <summary>
		/// Hold all the fonts returned by AddFont*. Fonts[0] is the default font upon calling ImGui::NewFrame(), use ImGui::PushFont()/PopFont() to change the current font.<br/>
		/// </summary>
		public ImVector<ImFontPtr> Fonts;
		/// <summary>
		/// Rectangles for packing custom texture data into the atlas.<br/>
		/// </summary>
		public ImVector<ImFontAtlasCustomRect> CustomRects;
		/// <summary>
		/// Source/configuration data<br/>
		/// </summary>
		public ImVector<ImFontConfig> Sources;
		/// <summary>
		/// UVs for baked anti-aliased lines<br/>
		/// </summary>
		public Vector4 TexUvLines_0;
		public Vector4 TexUvLines_1;
		public Vector4 TexUvLines_2;
		public Vector4 TexUvLines_3;
		public Vector4 TexUvLines_4;
		public Vector4 TexUvLines_5;
		public Vector4 TexUvLines_6;
		public Vector4 TexUvLines_7;
		public Vector4 TexUvLines_8;
		public Vector4 TexUvLines_9;
		public Vector4 TexUvLines_10;
		public Vector4 TexUvLines_11;
		public Vector4 TexUvLines_12;
		public Vector4 TexUvLines_13;
		public Vector4 TexUvLines_14;
		public Vector4 TexUvLines_15;
		public Vector4 TexUvLines_16;
		public Vector4 TexUvLines_17;
		public Vector4 TexUvLines_18;
		public Vector4 TexUvLines_19;
		public Vector4 TexUvLines_20;
		public Vector4 TexUvLines_21;
		public Vector4 TexUvLines_22;
		public Vector4 TexUvLines_23;
		public Vector4 TexUvLines_24;
		public Vector4 TexUvLines_25;
		public Vector4 TexUvLines_26;
		public Vector4 TexUvLines_27;
		public Vector4 TexUvLines_28;
		public Vector4 TexUvLines_29;
		public Vector4 TexUvLines_30;
		public Vector4 TexUvLines_31;
		public Vector4 TexUvLines_32;
		/// <summary>
		///     [Internal] Font builder<br/>
		/// Opaque interface to a font builder (default to stb_truetype, can be changed to use FreeType by defining IMGUI_ENABLE_FREETYPE).<br/>
		/// </summary>
		public unsafe ImFontBuilderIO* FontBuilderIO;
		/// <summary>
		/// Shared flags (for all fonts) for custom font builder. THIS IS BUILD IMPLEMENTATION DEPENDENT. Per-font override is also available in ImFontConfig.<br/>
		/// </summary>
		public uint FontBuilderFlags;
		/// <summary>
		///     [Internal] Packing data<br/>
		/// Custom texture rectangle ID for white pixel and mouse cursors<br/>
		/// </summary>
		public int PackIdMouseCursors;
		/// <summary>
		/// Custom texture rectangle ID for baked anti-aliased lines<br/>
		/// </summary>
		public int PackIdLines;
	}

	/// <summary>
	/// Load and rasterize multiple TTF/OTF fonts into a same texture. The font atlas will build a single texture holding:<br/> - One or more fonts.<br/> - Custom graphics data needed to render the shapes needed by Dear ImGui.<br/> - Mouse cursor shapes for software cursor rendering (unless setting 'Flags |= ImFontAtlasFlags_NoMouseCursors' in the font atlas).<br/>It is the user-code responsibility to setup/build the atlas, then upload the pixel data into a texture accessible by your graphics api.<br/> - Optionally, call any of the AddFont*** functions. If you don't call any, the default font embedded in the code will be loaded for you.<br/> - Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.<br/> - Upload the pixels data into a texture within your graphics system (see imgui_impl_xxxx.cpp examples)<br/> - Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture in a format natural to your graphics API.<br/>   This value will be passed back to you during rendering to identify the texture. Read FAQ entry about ImTextureID for more details.<br/>Common pitfalls:<br/>- If you pass a 'glyph_ranges' array to AddFont*** functions, you need to make sure that your array persist up until the<br/>  atlas is build (when calling GetTexData*** or Build()). We only copy the pointer, not the data.<br/>- Important: By default, AddFontFromMemoryTTF() takes ownership of the data. Even though we are not writing to it, we will free the pointer on destruction.<br/>  You can set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed,<br/>- Even though many functions are suffixed with "TTF", OTF data is supported just as well.<br/>- This is an old API and it is currently awkward for those and various other reasons! We will address them in the future!<br/>
	/// </summary>
	public unsafe partial struct ImFontAtlasPtr
	{
		public ImFontAtlas* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontAtlas this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		///     Input<br/>
		/// Build flags (see ImFontAtlasFlags_)<br/>
		/// </summary>
		public ref ImFontAtlasFlags Flags => ref Unsafe.AsRef<ImFontAtlasFlags>(&NativePtr->Flags);
		/// <summary>
		/// User data to refer to the texture once it has been uploaded to user's graphic systems. It is passed back to you during rendering via the ImDrawCmd structure.<br/>
		/// </summary>
		public ref ulong TexID => ref Unsafe.AsRef<ulong>(&NativePtr->TexID);
		/// <summary>
		/// Texture width desired by user before Build(). Must be a power-of-two. If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.<br/>
		/// </summary>
		public ref int TexDesiredWidth => ref Unsafe.AsRef<int>(&NativePtr->TexDesiredWidth);
		/// <summary>
		/// FIXME: Should be called "TexPackPadding". Padding between glyphs within texture in pixels. Defaults to 1. If your rendering method doesn't rely on bilinear filtering you may set this to 0 (will also need to set AntiAliasedLinesUseTex = false).<br/>
		/// </summary>
		public ref int TexGlyphPadding => ref Unsafe.AsRef<int>(&NativePtr->TexGlyphPadding);
		/// <summary>
		/// Store your own atlas related user-data (if e.g. you have multiple font atlas).<br/>
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
		/// <summary>
		///     [Internal]<br/>    NB: Access texture data via GetTexData*() calls! Which will setup a default font for you.<br/>
		/// Marked as Locked by ImGui::NewFrame() so attempt to modify the atlas will assert.<br/>
		/// </summary>
		public ref bool Locked => ref Unsafe.AsRef<bool>(&NativePtr->Locked);
		/// <summary>
		/// Set when texture was built matching current font input<br/>
		/// </summary>
		public ref bool TexReady => ref Unsafe.AsRef<bool>(&NativePtr->TexReady);
		/// <summary>
		/// Tell whether our texture data is known to use colors (rather than just alpha channel), in order to help backend select a format.<br/>
		/// </summary>
		public ref bool TexPixelsUseColors => ref Unsafe.AsRef<bool>(&NativePtr->TexPixelsUseColors);
		/// <summary>
		/// 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight<br/>
		/// </summary>
		public IntPtr TexPixelsAlpha8 { get => (IntPtr)NativePtr->TexPixelsAlpha8; set => NativePtr->TexPixelsAlpha8 = (byte*)value; }
		/// <summary>
		/// 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4<br/>
		/// </summary>
		public IntPtr TexPixelsRgba32 { get => (IntPtr)NativePtr->TexPixelsRgba32; set => NativePtr->TexPixelsRgba32 = (uint*)value; }
		/// <summary>
		/// Texture width calculated during Build().<br/>
		/// </summary>
		public ref int TexWidth => ref Unsafe.AsRef<int>(&NativePtr->TexWidth);
		/// <summary>
		/// Texture height calculated during Build().<br/>
		/// </summary>
		public ref int TexHeight => ref Unsafe.AsRef<int>(&NativePtr->TexHeight);
		/// <summary>
		/// = (1.0f/TexWidth, 1.0f/TexHeight)<br/>
		/// </summary>
		public ref Vector2 TexUvScale => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvScale);
		/// <summary>
		/// Texture coordinates to a white pixel<br/>
		/// </summary>
		public ref Vector2 TexUvWhitePixel => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvWhitePixel);
		/// <summary>
		/// Hold all the fonts returned by AddFont*. Fonts[0] is the default font upon calling ImGui::NewFrame(), use ImGui::PushFont()/PopFont() to change the current font.<br/>
		/// </summary>
		public ref ImVector<ImFontPtr> Fonts => ref Unsafe.AsRef<ImVector<ImFontPtr>>(&NativePtr->Fonts);
		/// <summary>
		/// Rectangles for packing custom texture data into the atlas.<br/>
		/// </summary>
		public ref ImVector<ImFontAtlasCustomRect> CustomRects => ref Unsafe.AsRef<ImVector<ImFontAtlasCustomRect>>(&NativePtr->CustomRects);
		/// <summary>
		/// Source/configuration data<br/>
		/// </summary>
		public ref ImVector<ImFontConfig> Sources => ref Unsafe.AsRef<ImVector<ImFontConfig>>(&NativePtr->Sources);
		/// <summary>
		/// UVs for baked anti-aliased lines<br/>
		/// </summary>
		public Span<Vector4> TexUvLines => new Span<Vector4>(&NativePtr->TexUvLines_0, 33);
		/// <summary>
		///     [Internal] Font builder<br/>
		/// Opaque interface to a font builder (default to stb_truetype, can be changed to use FreeType by defining IMGUI_ENABLE_FREETYPE).<br/>
		/// </summary>
		public ref ImFontBuilderIOPtr FontBuilderIO => ref Unsafe.AsRef<ImFontBuilderIOPtr>(&NativePtr->FontBuilderIO);
		/// <summary>
		/// Shared flags (for all fonts) for custom font builder. THIS IS BUILD IMPLEMENTATION DEPENDENT. Per-font override is also available in ImFontConfig.<br/>
		/// </summary>
		public ref uint FontBuilderFlags => ref Unsafe.AsRef<uint>(&NativePtr->FontBuilderFlags);
		/// <summary>
		///     [Internal] Packing data<br/>
		/// Custom texture rectangle ID for white pixel and mouse cursors<br/>
		/// </summary>
		public ref int PackIdMouseCursors => ref Unsafe.AsRef<int>(&NativePtr->PackIdMouseCursors);
		/// <summary>
		/// Custom texture rectangle ID for baked anti-aliased lines<br/>
		/// </summary>
		public ref int PackIdLines => ref Unsafe.AsRef<int>(&NativePtr->PackIdLines);
		public ImFontAtlasPtr(ImFontAtlas* nativePtr) => NativePtr = nativePtr;
		public ImFontAtlasPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlas*)nativePtr;
		public static implicit operator ImFontAtlasPtr(ImFontAtlas* ptr) => new ImFontAtlasPtr(ptr);
		public static implicit operator ImFontAtlasPtr(IntPtr ptr) => new ImFontAtlasPtr(ptr);
		public static implicit operator ImFontAtlas*(ImFontAtlasPtr nativePtr) => nativePtr.NativePtr;
		public void CalcCustomRectUV(ImFontAtlasCustomRectPtr rect, out Vector2 outUvMin, out Vector2 outUvMax)
		{
			fixed (Vector2* nativeOutUvMin = &outUvMin)
			fixed (Vector2* nativeOutUvMax = &outUvMax)
			{
				ImGuiNative.ImFontAtlasCalcCustomRectUV(NativePtr, rect, nativeOutUvMin, nativeOutUvMax);
			}
		}

		public ImFontAtlasCustomRectPtr GetCustomRectByIndex(int index)
		{
			return ImGuiNative.ImFontAtlasGetCustomRectByIndex(NativePtr, index);
		}

		public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advanceX, Vector2 offset)
		{
			return ImGuiNative.ImFontAtlasAddCustomRectFontGlyph(NativePtr, font, id, width, height, advanceX, offset);
		}

		public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advanceX)
		{
			// defining omitted parameters
			Vector2 offset = new Vector2(0,0);
			return ImGuiNative.ImFontAtlasAddCustomRectFontGlyph(NativePtr, font, id, width, height, advanceX, offset);
		}

		public int AddCustomRectRegular(int width, int height)
		{
			return ImGuiNative.ImFontAtlasAddCustomRectRegular(NativePtr, width, height);
		}

		/// <summary>
		/// Default + Vietnamese characters<br/>
		/// </summary>
		public ref ushort GetGlyphRangesVietnamese()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesVietnamese(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + Thai characters<br/>
		/// </summary>
		public ref ushort GetGlyphRangesThai()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesThai(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + about 400 Cyrillic characters<br/>
		/// </summary>
		public ref ushort GetGlyphRangesCyrillic()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesCyrillic(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese<br/>
		/// </summary>
		public ref ushort GetGlyphRangesChineseSimplifiedCommon()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesChineseSimplifiedCommon(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs<br/>
		/// </summary>
		public ref ushort GetGlyphRangesChineseFull()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesChineseFull(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs<br/>
		/// </summary>
		public ref ushort GetGlyphRangesJapanese()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesJapanese(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + Korean characters<br/>
		/// </summary>
		public ref ushort GetGlyphRangesKorean()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesKorean(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Default + Greek and Coptic<br/>
		/// </summary>
		public ref ushort GetGlyphRangesGreek()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesGreek(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		/// <summary>
		/// Basic Latin, Extended Latin<br/>
		/// </summary>
		public ref ushort GetGlyphRangesDefault()
		{
			var nativeResult = ImGuiNative.ImFontAtlasGetGlyphRangesDefault(NativePtr);
			return ref *(ushort*)&nativeResult;
		}

		public void SetTexID(ulong id)
		{
			ImGuiNative.ImFontAtlasSetTexID(NativePtr, id);
		}

		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...<br/>
		/// </summary>
		public bool IsBuilt()
		{
			var result = ImGuiNative.ImFontAtlasIsBuilt(NativePtr);
			return result != 0;
		}

		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		public void GetTexDataAsRgba32(out byte* outPixels, out int outWidth, out int outHeight, out int outBytesPerPixel)
		{
			fixed (byte** nativeOutPixels = &outPixels)
			fixed (int* nativeOutWidth = &outWidth)
			fixed (int* nativeOutHeight = &outHeight)
			fixed (int* nativeOutBytesPerPixel = &outBytesPerPixel)
			{
				ImGuiNative.ImFontAtlasGetTexDataAsRgba32(NativePtr, nativeOutPixels, nativeOutWidth, nativeOutHeight, nativeOutBytesPerPixel);
			}
		}

		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		public void GetTexDataAsRgba32(out byte* outPixels, out int outWidth, out int outHeight)
		{
			// defining omitted parameters
			int* outBytesPerPixel = null;
			fixed (byte** nativeOutPixels = &outPixels)
			fixed (int* nativeOutWidth = &outWidth)
			fixed (int* nativeOutHeight = &outHeight)
			{
				ImGuiNative.ImFontAtlasGetTexDataAsRgba32(NativePtr, nativeOutPixels, nativeOutWidth, nativeOutHeight, outBytesPerPixel);
			}
		}

		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		public void GetTexDataAsAlpha8(out byte* outPixels, out int outWidth, out int outHeight, out int outBytesPerPixel)
		{
			fixed (byte** nativeOutPixels = &outPixels)
			fixed (int* nativeOutWidth = &outWidth)
			fixed (int* nativeOutHeight = &outHeight)
			fixed (int* nativeOutBytesPerPixel = &outBytesPerPixel)
			{
				ImGuiNative.ImFontAtlasGetTexDataAsAlpha8(NativePtr, nativeOutPixels, nativeOutWidth, nativeOutHeight, nativeOutBytesPerPixel);
			}
		}

		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		public void GetTexDataAsAlpha8(out byte* outPixels, out int outWidth, out int outHeight)
		{
			// defining omitted parameters
			int* outBytesPerPixel = null;
			fixed (byte** nativeOutPixels = &outPixels)
			fixed (int* nativeOutWidth = &outWidth)
			fixed (int* nativeOutHeight = &outHeight)
			{
				ImGuiNative.ImFontAtlasGetTexDataAsAlpha8(NativePtr, nativeOutPixels, nativeOutWidth, nativeOutHeight, outBytesPerPixel);
			}
		}

		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.<br/>
		/// </summary>
		public bool Build()
		{
			var result = ImGuiNative.ImFontAtlasBuild(NativePtr);
			return result != 0;
		}

		/// <summary>
		/// Clear all input and output.<br/>
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImFontAtlasClear(NativePtr);
		}

		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.<br/>
		/// </summary>
		public void ClearTexData()
		{
			ImGuiNative.ImFontAtlasClearTexData(NativePtr);
		}

		/// <summary>
		/// Clear input+output font data (same as ClearInputData() + glyphs storage, UV coordinates).<br/>
		/// </summary>
		public void ClearFonts()
		{
			ImGuiNative.ImFontAtlasClearFonts(NativePtr);
		}

		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.<br/>
		/// </summary>
		public void ClearInputData()
		{
			ImGuiNative.ImFontAtlasClearInputData(NativePtr);
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<byte> compressedFontDataBase85, float sizePixels, ImFontConfigPtr fontCfg, ushort[] glyphRanges)
		{
			fixed (byte* nativeCompressedFontDataBase85 = compressedFontDataBase85)
			fixed (ushort* nativeGlyphRanges = glyphRanges)
			{
				return ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedBase85TTF(NativePtr, nativeCompressedFontDataBase85, sizePixels, fontCfg, nativeGlyphRanges);
			}
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<char> compressedFontDataBase85, float sizePixels, ImFontConfigPtr fontCfg, ushort[] glyphRanges)
		{
			// Marshaling compressedFontDataBase85 to native string
			byte* nativeCompressedFontDataBase85;
			var byteCountCompressedFontDataBase85 = 0;
			if (compressedFontDataBase85 != null && !compressedFontDataBase85.IsEmpty)
			{
				byteCountCompressedFontDataBase85 = Encoding.UTF8.GetByteCount(compressedFontDataBase85);
				if(byteCountCompressedFontDataBase85 > Utils.MaxStackallocSize)
				{
					nativeCompressedFontDataBase85 = Utils.Alloc<byte>(byteCountCompressedFontDataBase85 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountCompressedFontDataBase85 + 1];
					nativeCompressedFontDataBase85 = stackallocBytes;
				}
				var offsetCompressedFontDataBase85 = Utils.EncodeStringUTF8(compressedFontDataBase85, nativeCompressedFontDataBase85, byteCountCompressedFontDataBase85);
				nativeCompressedFontDataBase85[offsetCompressedFontDataBase85] = 0;
			}
			else nativeCompressedFontDataBase85 = null;

			fixed (ushort* nativeGlyphRanges = glyphRanges)
			{
				var result = ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedBase85TTF(NativePtr, nativeCompressedFontDataBase85, sizePixels, fontCfg, nativeGlyphRanges);
				// Freeing compressedFontDataBase85 native string
				if (byteCountCompressedFontDataBase85 > Utils.MaxStackallocSize)
					Utils.Free(nativeCompressedFontDataBase85);
				return result;
			}
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<byte> compressedFontDataBase85, float sizePixels, ImFontConfigPtr fontCfg)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			fixed (byte* nativeCompressedFontDataBase85 = compressedFontDataBase85)
			{
				return ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedBase85TTF(NativePtr, nativeCompressedFontDataBase85, sizePixels, fontCfg, glyphRanges);
			}
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<char> compressedFontDataBase85, float sizePixels, ImFontConfigPtr fontCfg)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			// Marshaling compressedFontDataBase85 to native string
			byte* nativeCompressedFontDataBase85;
			var byteCountCompressedFontDataBase85 = 0;
			if (compressedFontDataBase85 != null && !compressedFontDataBase85.IsEmpty)
			{
				byteCountCompressedFontDataBase85 = Encoding.UTF8.GetByteCount(compressedFontDataBase85);
				if(byteCountCompressedFontDataBase85 > Utils.MaxStackallocSize)
				{
					nativeCompressedFontDataBase85 = Utils.Alloc<byte>(byteCountCompressedFontDataBase85 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountCompressedFontDataBase85 + 1];
					nativeCompressedFontDataBase85 = stackallocBytes;
				}
				var offsetCompressedFontDataBase85 = Utils.EncodeStringUTF8(compressedFontDataBase85, nativeCompressedFontDataBase85, byteCountCompressedFontDataBase85);
				nativeCompressedFontDataBase85[offsetCompressedFontDataBase85] = 0;
			}
			else nativeCompressedFontDataBase85 = null;

			var result = ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedBase85TTF(NativePtr, nativeCompressedFontDataBase85, sizePixels, fontCfg, glyphRanges);
			// Freeing compressedFontDataBase85 native string
			if (byteCountCompressedFontDataBase85 > Utils.MaxStackallocSize)
				Utils.Free(nativeCompressedFontDataBase85);
			return result;
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<byte> compressedFontDataBase85, float sizePixels)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			ImFontConfig* fontCfg = null;
			fixed (byte* nativeCompressedFontDataBase85 = compressedFontDataBase85)
			{
				return ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedBase85TTF(NativePtr, nativeCompressedFontDataBase85, sizePixels, fontCfg, glyphRanges);
			}
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<char> compressedFontDataBase85, float sizePixels)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			ImFontConfig* fontCfg = null;
			// Marshaling compressedFontDataBase85 to native string
			byte* nativeCompressedFontDataBase85;
			var byteCountCompressedFontDataBase85 = 0;
			if (compressedFontDataBase85 != null && !compressedFontDataBase85.IsEmpty)
			{
				byteCountCompressedFontDataBase85 = Encoding.UTF8.GetByteCount(compressedFontDataBase85);
				if(byteCountCompressedFontDataBase85 > Utils.MaxStackallocSize)
				{
					nativeCompressedFontDataBase85 = Utils.Alloc<byte>(byteCountCompressedFontDataBase85 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountCompressedFontDataBase85 + 1];
					nativeCompressedFontDataBase85 = stackallocBytes;
				}
				var offsetCompressedFontDataBase85 = Utils.EncodeStringUTF8(compressedFontDataBase85, nativeCompressedFontDataBase85, byteCountCompressedFontDataBase85);
				nativeCompressedFontDataBase85[offsetCompressedFontDataBase85] = 0;
			}
			else nativeCompressedFontDataBase85 = null;

			var result = ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedBase85TTF(NativePtr, nativeCompressedFontDataBase85, sizePixels, fontCfg, glyphRanges);
			// Freeing compressedFontDataBase85 native string
			if (byteCountCompressedFontDataBase85 > Utils.MaxStackallocSize)
				Utils.Free(nativeCompressedFontDataBase85);
			return result;
		}

		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressedFontData, int compressedFontDataSize, float sizePixels, ImFontConfigPtr fontCfg, ushort[] glyphRanges)
		{
			fixed (ushort* nativeGlyphRanges = glyphRanges)
			{
				return ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedTTF(NativePtr, (void*)compressedFontData, compressedFontDataSize, sizePixels, fontCfg, nativeGlyphRanges);
			}
		}

		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressedFontData, int compressedFontDataSize, float sizePixels, ImFontConfigPtr fontCfg)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			return ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedTTF(NativePtr, (void*)compressedFontData, compressedFontDataSize, sizePixels, fontCfg, glyphRanges);
		}

		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressedFontData, int compressedFontDataSize, float sizePixels)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			ImFontConfig* fontCfg = null;
			return ImGuiNative.ImFontAtlasAddFontFromMemoryCompressedTTF(NativePtr, (void*)compressedFontData, compressedFontDataSize, sizePixels, fontCfg, glyphRanges);
		}

		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryTTF(IntPtr fontData, int fontDataSize, float sizePixels, ImFontConfigPtr fontCfg, ushort[] glyphRanges)
		{
			fixed (ushort* nativeGlyphRanges = glyphRanges)
			{
				return ImGuiNative.ImFontAtlasAddFontFromMemoryTTF(NativePtr, (void*)fontData, fontDataSize, sizePixels, fontCfg, nativeGlyphRanges);
			}
		}

		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryTTF(IntPtr fontData, int fontDataSize, float sizePixels, ImFontConfigPtr fontCfg)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			return ImGuiNative.ImFontAtlasAddFontFromMemoryTTF(NativePtr, (void*)fontData, fontDataSize, sizePixels, fontCfg, glyphRanges);
		}

		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		public ImFontPtr AddFontFromMemoryTTF(IntPtr fontData, int fontDataSize, float sizePixels)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			ImFontConfig* fontCfg = null;
			return ImGuiNative.ImFontAtlasAddFontFromMemoryTTF(NativePtr, (void*)fontData, fontDataSize, sizePixels, fontCfg, glyphRanges);
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<byte> filename, float sizePixels, ImFontConfigPtr fontCfg, ushort[] glyphRanges)
		{
			fixed (byte* nativeFilename = filename)
			fixed (ushort* nativeGlyphRanges = glyphRanges)
			{
				return ImGuiNative.ImFontAtlasAddFontFromFileTTF(NativePtr, nativeFilename, sizePixels, fontCfg, nativeGlyphRanges);
			}
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<char> filename, float sizePixels, ImFontConfigPtr fontCfg, ushort[] glyphRanges)
		{
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			fixed (ushort* nativeGlyphRanges = glyphRanges)
			{
				var result = ImGuiNative.ImFontAtlasAddFontFromFileTTF(NativePtr, nativeFilename, sizePixels, fontCfg, nativeGlyphRanges);
				// Freeing filename native string
				if (byteCountFilename > Utils.MaxStackallocSize)
					Utils.Free(nativeFilename);
				return result;
			}
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<byte> filename, float sizePixels, ImFontConfigPtr fontCfg)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			fixed (byte* nativeFilename = filename)
			{
				return ImGuiNative.ImFontAtlasAddFontFromFileTTF(NativePtr, nativeFilename, sizePixels, fontCfg, glyphRanges);
			}
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<char> filename, float sizePixels, ImFontConfigPtr fontCfg)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			var result = ImGuiNative.ImFontAtlasAddFontFromFileTTF(NativePtr, nativeFilename, sizePixels, fontCfg, glyphRanges);
			// Freeing filename native string
			if (byteCountFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeFilename);
			return result;
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<byte> filename, float sizePixels)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			ImFontConfig* fontCfg = null;
			fixed (byte* nativeFilename = filename)
			{
				return ImGuiNative.ImFontAtlasAddFontFromFileTTF(NativePtr, nativeFilename, sizePixels, fontCfg, glyphRanges);
			}
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<char> filename, float sizePixels)
		{
			// defining omitted parameters
			ushort* glyphRanges = null;
			ImFontConfig* fontCfg = null;
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			var result = ImGuiNative.ImFontAtlasAddFontFromFileTTF(NativePtr, nativeFilename, sizePixels, fontCfg, glyphRanges);
			// Freeing filename native string
			if (byteCountFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeFilename);
			return result;
		}

		public ImFontPtr AddFontDefault(ImFontConfigPtr fontCfg)
		{
			return ImGuiNative.ImFontAtlasAddFontDefault(NativePtr, fontCfg);
		}

		public ImFontPtr AddFontDefault()
		{
			// defining omitted parameters
			ImFontConfig* fontCfg = null;
			return ImGuiNative.ImFontAtlasAddFontDefault(NativePtr, fontCfg);
		}

		public ImFontPtr AddFont(ImFontConfigPtr fontCfg)
		{
			return ImGuiNative.ImFontAtlasAddFont(NativePtr, fontCfg);
		}

		public void Destroy()
		{
			ImGuiNative.ImFontAtlasDestroy(NativePtr);
		}

		public void ImFontAtlasConstruct()
		{
			ImGuiNative.ImFontAtlasImFontAtlasConstruct(NativePtr);
		}

		public ImFontAtlasPtr ImFontAtlas()
		{
			return ImGuiNative.ImFontAtlasImFontAtlas();
		}

	}
}
