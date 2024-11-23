using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Load and rasterize multiple TTF/OTF fonts into a same texture. The font atlas will build a single texture holding:</para>
	/// <para> - One or more fonts.</para>
	/// <para> - Custom graphics data needed to render the shapes needed by Dear ImGui.</para>
	/// <para> - Mouse cursor shapes for software cursor rendering (unless setting 'Flags |= ImFontAtlasFlags_NoMouseCursors' in the font atlas).</para>
	/// <para>It is the user-code responsibility to setup/build the atlas, then upload the pixel data into a texture accessible by your graphics api.</para>
	/// <para> - Optionally, call any of the AddFont*** functions. If you don't call any, the default font embedded in the code will be loaded for you.</para>
	/// <para> - Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.</para>
	/// <para> - Upload the pixels data into a texture within your graphics system (see imgui_impl_xxxx.cpp examples)</para>
	/// <para> - Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture in a format natural to your graphics API.</para>
	/// <para>   This value will be passed back to you during rendering to identify the texture. Read FAQ entry about ImTextureID for more details.</para>
	/// <para>Common pitfalls:</para>
	/// <para>- If you pass a 'glyph_ranges' array to AddFont*** functions, you need to make sure that your array persist up until the</para>
	/// <para>  atlas is build (when calling GetTexData*** or Build()). We only copy the pointer, not the data.</para>
	/// <para>- Important: By default, AddFontFromMemoryTTF() takes ownership of the data. Even though we are not writing to it, we will free the pointer on destruction.</para>
	/// <para>  You can set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed,</para>
	/// <para>- Even though many functions are suffixed with "TTF", OTF data is supported just as well.</para>
	/// <para>- This is an old API and it is currently awkward for those and various other reasons! We will address them in the future!</para>
	/// </summary>
	public unsafe partial struct ImFontAtlas
	{
		/// <summary>
		/// Build flags (see ImFontAtlasFlags_)
		/// </summary>
		public ImFontAtlasFlags Flags;
		/// <summary>
		/// User data to refer to the texture once it has been uploaded to user's graphic systems. It is passed back to you during rendering via the ImDrawCmd structure.
		/// </summary>
		public IntPtr TexID;
		/// <summary>
		/// Texture width desired by user before Build(). Must be a power-of-two. If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.
		/// </summary>
		public int TexDesiredWidth;
		/// <summary>
		/// Padding between glyphs within texture in pixels. Defaults to 1. If your rendering method doesn't rely on bilinear filtering you may set this to 0 (will also need to set AntiAliasedLinesUseTex = false).
		/// </summary>
		public int TexGlyphPadding;
		/// <summary>
		/// Marked as Locked by ImGui::NewFrame() so attempt to modify the atlas will assert.
		/// </summary>
		public byte Locked;
		/// <summary>
		/// Store your own atlas related user-data (if e.g. you have multiple font atlas).
		/// </summary>
		public void* UserData;
		/// <summary>
		/// <para>[Internal]</para>
		/// <para>NB: Access texture data via GetTexData*() calls! Which will setup a default font for you.</para>
		/// </summary>
		/// <summary>
		/// Set when texture was built matching current font input
		/// </summary>
		public byte TexReady;
		/// <summary>
		/// Tell whether our texture data is known to use colors (rather than just alpha channel), in order to help backend select a format.
		/// </summary>
		public byte TexPixelsUseColors;
		/// <summary>
		/// 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight
		/// </summary>
		public byte* TexPixelsAlpha8;
		/// <summary>
		/// 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4
		/// </summary>
		public uint* TexPixelsRGBA32;
		/// <summary>
		/// Texture width calculated during Build().
		/// </summary>
		public int TexWidth;
		/// <summary>
		/// Texture height calculated during Build().
		/// </summary>
		public int TexHeight;
		/// <summary>
		/// = (1.0f/TexWidth, 1.0f/TexHeight)
		/// </summary>
		public Vector2 TexUvScale;
		/// <summary>
		/// Texture coordinates to a white pixel
		/// </summary>
		public Vector2 TexUvWhitePixel;
		/// <summary>
		/// Hold all the fonts returned by AddFont*. Fonts[0] is the default font upon calling ImGui::NewFrame(), use ImGui::PushFont()/PopFont() to change the current font.
		/// </summary>
		public ImVector Fonts;
		/// <summary>
		/// Rectangles for packing custom texture data into the atlas.
		/// </summary>
		public ImVector CustomRects;
		/// <summary>
		/// Configuration data
		/// </summary>
		public ImVector ConfigData;
		/// <summary>
		/// UVs for baked anti-aliased lines
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
		public Vector4 TexUvLines_33;
		public Vector4 TexUvLines_34;
		public Vector4 TexUvLines_35;
		public Vector4 TexUvLines_36;
		public Vector4 TexUvLines_37;
		public Vector4 TexUvLines_38;
		public Vector4 TexUvLines_39;
		public Vector4 TexUvLines_40;
		public Vector4 TexUvLines_41;
		public Vector4 TexUvLines_42;
		public Vector4 TexUvLines_43;
		public Vector4 TexUvLines_44;
		public Vector4 TexUvLines_45;
		public Vector4 TexUvLines_46;
		public Vector4 TexUvLines_47;
		public Vector4 TexUvLines_48;
		public Vector4 TexUvLines_49;
		public Vector4 TexUvLines_50;
		public Vector4 TexUvLines_51;
		public Vector4 TexUvLines_52;
		public Vector4 TexUvLines_53;
		public Vector4 TexUvLines_54;
		public Vector4 TexUvLines_55;
		public Vector4 TexUvLines_56;
		public Vector4 TexUvLines_57;
		public Vector4 TexUvLines_58;
		public Vector4 TexUvLines_59;
		public Vector4 TexUvLines_60;
		public Vector4 TexUvLines_61;
		public Vector4 TexUvLines_62;
		public Vector4 TexUvLines_63;
		/// <summary>
		/// <para>[Internal] Font builder</para>
		/// </summary>
		/// <summary>
		/// Opaque interface to a font builder (default to stb_truetype, can be changed to use FreeType by defining IMGUI_ENABLE_FREETYPE).
		/// </summary>
		public IntPtr FontBuilderIO;
		/// <summary>
		/// Shared flags (for all fonts) for custom font builder. THIS IS BUILD IMPLEMENTATION DEPENDENT. Per-font override is also available in ImFontConfig.
		/// </summary>
		public uint FontBuilderFlags;
		/// <summary>
		/// <para>[Internal] Packing data</para>
		/// </summary>
		/// <summary>
		/// Custom texture rectangle ID for white pixel and mouse cursors
		/// </summary>
		public int PackIdMouseCursors;
		/// <summary>
		/// Custom texture rectangle ID for baked anti-aliased lines
		/// </summary>
		public int PackIdLines;
	}

	/// <summary>
	/// <para>Load and rasterize multiple TTF/OTF fonts into a same texture. The font atlas will build a single texture holding:</para>
	/// <para> - One or more fonts.</para>
	/// <para> - Custom graphics data needed to render the shapes needed by Dear ImGui.</para>
	/// <para> - Mouse cursor shapes for software cursor rendering (unless setting 'Flags |= ImFontAtlasFlags_NoMouseCursors' in the font atlas).</para>
	/// <para>It is the user-code responsibility to setup/build the atlas, then upload the pixel data into a texture accessible by your graphics api.</para>
	/// <para> - Optionally, call any of the AddFont*** functions. If you don't call any, the default font embedded in the code will be loaded for you.</para>
	/// <para> - Call GetTexDataAsAlpha8() or GetTexDataAsRGBA32() to build and retrieve pixels data.</para>
	/// <para> - Upload the pixels data into a texture within your graphics system (see imgui_impl_xxxx.cpp examples)</para>
	/// <para> - Call SetTexID(my_tex_id); and pass the pointer/identifier to your texture in a format natural to your graphics API.</para>
	/// <para>   This value will be passed back to you during rendering to identify the texture. Read FAQ entry about ImTextureID for more details.</para>
	/// <para>Common pitfalls:</para>
	/// <para>- If you pass a 'glyph_ranges' array to AddFont*** functions, you need to make sure that your array persist up until the</para>
	/// <para>  atlas is build (when calling GetTexData*** or Build()). We only copy the pointer, not the data.</para>
	/// <para>- Important: By default, AddFontFromMemoryTTF() takes ownership of the data. Even though we are not writing to it, we will free the pointer on destruction.</para>
	/// <para>  You can set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed,</para>
	/// <para>- Even though many functions are suffixed with "TTF", OTF data is supported just as well.</para>
	/// <para>- This is an old API and it is currently awkward for those and various other reasons! We will address them in the future!</para>
	/// </summary>
	public unsafe partial struct ImFontAtlasPtr
	{
		public ImFontAtlas* NativePtr { get; }
		public ImFontAtlasPtr(ImFontAtlas* nativePtr) => NativePtr = nativePtr;
		public ImFontAtlasPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlas*)nativePtr;
		public static implicit operator ImFontAtlasPtr(ImFontAtlas* nativePtr) => new ImFontAtlasPtr(nativePtr);
		public static implicit operator ImFontAtlas* (ImFontAtlasPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontAtlasPtr(IntPtr nativePtr) => new ImFontAtlasPtr(nativePtr);

		/// <summary>
		/// Build flags (see ImFontAtlasFlags_)
		/// </summary>
		public ref ImFontAtlasFlags Flags => ref Unsafe.AsRef<ImFontAtlasFlags>(&NativePtr->Flags);

		/// <summary>
		/// User data to refer to the texture once it has been uploaded to user's graphic systems. It is passed back to you during rendering via the ImDrawCmd structure.
		/// </summary>
		public ref IntPtr TexID => ref Unsafe.AsRef<IntPtr>(&NativePtr->TexID);

		/// <summary>
		/// Texture width desired by user before Build(). Must be a power-of-two. If have many glyphs your graphics API have texture size restrictions you may want to increase texture width to decrease height.
		/// </summary>
		public ref int TexDesiredWidth => ref Unsafe.AsRef<int>(&NativePtr->TexDesiredWidth);

		/// <summary>
		/// Padding between glyphs within texture in pixels. Defaults to 1. If your rendering method doesn't rely on bilinear filtering you may set this to 0 (will also need to set AntiAliasedLinesUseTex = false).
		/// </summary>
		public ref int TexGlyphPadding => ref Unsafe.AsRef<int>(&NativePtr->TexGlyphPadding);

		/// <summary>
		/// Marked as Locked by ImGui::NewFrame() so attempt to modify the atlas will assert.
		/// </summary>
		public ref bool Locked => ref Unsafe.AsRef<bool>(&NativePtr->Locked);

		/// <summary>
		/// Store your own atlas related user-data (if e.g. you have multiple font atlas).
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }

		/// <summary>
		/// <para>[Internal]</para>
		/// <para>NB: Access texture data via GetTexData*() calls! Which will setup a default font for you.</para>
		/// </summary>
		/// <summary>
		/// Set when texture was built matching current font input
		/// </summary>
		public ref bool TexReady => ref Unsafe.AsRef<bool>(&NativePtr->TexReady);

		/// <summary>
		/// Tell whether our texture data is known to use colors (rather than just alpha channel), in order to help backend select a format.
		/// </summary>
		public ref bool TexPixelsUseColors => ref Unsafe.AsRef<bool>(&NativePtr->TexPixelsUseColors);

		/// <summary>
		/// 1 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight
		/// </summary>
		public IntPtr TexPixelsAlpha8 { get => (IntPtr)NativePtr->TexPixelsAlpha8; set => NativePtr->TexPixelsAlpha8 = (byte*)value; }

		/// <summary>
		/// 4 component per pixel, each component is unsigned 8-bit. Total size = TexWidth * TexHeight * 4
		/// </summary>
		public IntPtr TexPixelsRGBA32 { get => (IntPtr)NativePtr->TexPixelsRGBA32; set => NativePtr->TexPixelsRGBA32 = (uint*)value; }

		/// <summary>
		/// Texture width calculated during Build().
		/// </summary>
		public ref int TexWidth => ref Unsafe.AsRef<int>(&NativePtr->TexWidth);

		/// <summary>
		/// Texture height calculated during Build().
		/// </summary>
		public ref int TexHeight => ref Unsafe.AsRef<int>(&NativePtr->TexHeight);

		/// <summary>
		/// = (1.0f/TexWidth, 1.0f/TexHeight)
		/// </summary>
		public ref Vector2 TexUvScale => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvScale);

		/// <summary>
		/// Texture coordinates to a white pixel
		/// </summary>
		public ref Vector2 TexUvWhitePixel => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvWhitePixel);

		/// <summary>
		/// Hold all the fonts returned by AddFont*. Fonts[0] is the default font upon calling ImGui::NewFrame(), use ImGui::PushFont()/PopFont() to change the current font.
		/// </summary>
		public ImVector<ImFontPtr> Fonts => new ImVector<ImFontPtr>(NativePtr->Fonts);

		/// <summary>
		/// Rectangles for packing custom texture data into the atlas.
		/// </summary>
		public ImPtrVector<ImFontAtlasCustomRectPtr> CustomRects => new ImPtrVector<ImFontAtlasCustomRectPtr>(NativePtr->CustomRects, Unsafe.SizeOf<ImFontAtlasCustomRect>());

		/// <summary>
		/// Configuration data
		/// </summary>
		public ImPtrVector<ImFontConfigPtr> ConfigData => new ImPtrVector<ImFontConfigPtr>(NativePtr->ConfigData, Unsafe.SizeOf<ImFontConfig>());

		/// <summary>
		/// UVs for baked anti-aliased lines
		/// </summary>
		public RangeAccessor<Vector4> TexUvLines => new RangeAccessor<Vector4>(&NativePtr->TexUvLines_0, 64);

		/// <summary>
		/// <para>[Internal] Font builder</para>
		/// </summary>
		/// <summary>
		/// Opaque interface to a font builder (default to stb_truetype, can be changed to use FreeType by defining IMGUI_ENABLE_FREETYPE).
		/// </summary>
		public ref IntPtr FontBuilderIO => ref Unsafe.AsRef<IntPtr>(&NativePtr->FontBuilderIO);

		/// <summary>
		/// Shared flags (for all fonts) for custom font builder. THIS IS BUILD IMPLEMENTATION DEPENDENT. Per-font override is also available in ImFontConfig.
		/// </summary>
		public ref uint FontBuilderFlags => ref Unsafe.AsRef<uint>(&NativePtr->FontBuilderFlags);

		/// <summary>
		/// <para>[Internal] Packing data</para>
		/// </summary>
		/// <summary>
		/// Custom texture rectangle ID for white pixel and mouse cursors
		/// </summary>
		public ref int PackIdMouseCursors => ref Unsafe.AsRef<int>(&NativePtr->PackIdMouseCursors);

		/// <summary>
		/// Custom texture rectangle ID for baked anti-aliased lines
		/// </summary>
		public ref int PackIdLines => ref Unsafe.AsRef<int>(&NativePtr->PackIdLines);

		public ImFontPtr AddFont(ImFontConfigPtr font_cfg)
		{
			var ret = ImGuiNative.ImFontAtlas_AddFont(NativePtr, font_cfg);
			return ret;
		}

		public ImFontPtr AddFontDefault()
		{
			ImFontConfig* font_cfg = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontDefault(NativePtr, font_cfg);
			return ret;
		}
		public ImFontPtr AddFontDefault(ImFontConfigPtr font_cfg)
		{
			var ret = ImGuiNative.ImFontAtlas_AddFontDefault(NativePtr, font_cfg);
			return ret;
		}

		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<char> filename, float size_pixels)
		{
			// Marshaling 'filename' to native string
			byte* native_filename;
			var filename_byteCount = 0;
			if (filename != null)
			{
				filename_byteCount = Encoding.UTF8.GetByteCount(filename);
				if (filename_byteCount > Util.StackAllocationSizeLimit)
				{
					native_filename = Util.Allocate(filename_byteCount + 1);
				}
				else
				{
					var native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
					native_filename = native_filename_stackBytes;
				}
				var filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			ImFontConfig* font_cfg = null;

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, font_cfg, glyph_ranges);
			if (filename_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_filename);
			}
			return ret;
		}
		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<char> filename, float size_pixels, ImFontConfigPtr font_cfg)
		{
			// Marshaling 'filename' to native string
			byte* native_filename;
			var filename_byteCount = 0;
			if (filename != null)
			{
				filename_byteCount = Encoding.UTF8.GetByteCount(filename);
				if (filename_byteCount > Util.StackAllocationSizeLimit)
				{
					native_filename = Util.Allocate(filename_byteCount + 1);
				}
				else
				{
					var native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
					native_filename = native_filename_stackBytes;
				}
				var filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, font_cfg, glyph_ranges);
			if (filename_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_filename);
			}
			return ret;
		}
		public ImFontPtr AddFontFromFileTTF(ReadOnlySpan<char> filename, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
		{
			// Marshaling 'filename' to native string
			byte* native_filename;
			var filename_byteCount = 0;
			if (filename != null)
			{
				filename_byteCount = Encoding.UTF8.GetByteCount(filename);
				if (filename_byteCount > Util.StackAllocationSizeLimit)
				{
					native_filename = Util.Allocate(filename_byteCount + 1);
				}
				else
				{
					var native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
					native_filename = native_filename_stackBytes;
				}
				var filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			// Marshaling 'glyph_ranges' to native ushort pointer
			ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();

			var ret = ImGuiNative.ImFontAtlas_AddFontFromFileTTF(NativePtr, native_filename, size_pixels, font_cfg, native_glyph_ranges);
			if (filename_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_filename);
			}
			return ret;
		}

		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.
		/// </summary>
		public ImFontPtr AddFontFromMemoryTTF(IntPtr font_data, int font_data_size, float size_pixels)
		{
			// Marshaling 'font_data' to native void pointer
			var native_font_data = font_data.ToPointer();

			ImFontConfig* font_cfg = null;

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, native_font_data, font_data_size, size_pixels, font_cfg, glyph_ranges);
			return ret;
		}
		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.
		/// </summary>
		public ImFontPtr AddFontFromMemoryTTF(IntPtr font_data, int font_data_size, float size_pixels, ImFontConfigPtr font_cfg)
		{
			// Marshaling 'font_data' to native void pointer
			var native_font_data = font_data.ToPointer();

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, native_font_data, font_data_size, size_pixels, font_cfg, glyph_ranges);
			return ret;
		}
		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.
		/// </summary>
		public ImFontPtr AddFontFromMemoryTTF(IntPtr font_data, int font_data_size, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
		{
			// Marshaling 'font_data' to native void pointer
			var native_font_data = font_data.ToPointer();

			// Marshaling 'glyph_ranges' to native ushort pointer
			ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryTTF(NativePtr, native_font_data, font_data_size, size_pixels, font_cfg, native_glyph_ranges);
			return ret;
		}

		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressed_font_data, int compressed_font_data_size, float size_pixels)
		{
			// Marshaling 'compressed_font_data' to native void pointer
			var native_compressed_font_data = compressed_font_data.ToPointer();

			ImFontConfig* font_cfg = null;

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, native_compressed_font_data, compressed_font_data_size, size_pixels, font_cfg, glyph_ranges);
			return ret;
		}
		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfigPtr font_cfg)
		{
			// Marshaling 'compressed_font_data' to native void pointer
			var native_compressed_font_data = compressed_font_data.ToPointer();

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, native_compressed_font_data, compressed_font_data_size, size_pixels, font_cfg, glyph_ranges);
			return ret;
		}
		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedTTF(IntPtr compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
		{
			// Marshaling 'compressed_font_data' to native void pointer
			var native_compressed_font_data = compressed_font_data.ToPointer();

			// Marshaling 'glyph_ranges' to native ushort pointer
			ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedTTF(NativePtr, native_compressed_font_data, compressed_font_data_size, size_pixels, font_cfg, native_glyph_ranges);
			return ret;
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<char> compressed_font_data_base85, float size_pixels)
		{
			// Marshaling 'compressed_font_data_base85' to native string
			byte* native_compressed_font_data_base85;
			var compressed_font_data_base85_byteCount = 0;
			if (compressed_font_data_base85 != null)
			{
				compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
				if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
				{
					native_compressed_font_data_base85 = Util.Allocate(compressed_font_data_base85_byteCount + 1);
				}
				else
				{
					var native_compressed_font_data_base85_stackBytes = stackalloc byte[compressed_font_data_base85_byteCount + 1];
					native_compressed_font_data_base85 = native_compressed_font_data_base85_stackBytes;
				}
				var compressed_font_data_base85_offset = Util.GetUtf8(compressed_font_data_base85, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
				native_compressed_font_data_base85[compressed_font_data_base85_offset] = 0;
			}
			else native_compressed_font_data_base85 = null;

			ImFontConfig* font_cfg = null;

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, font_cfg, glyph_ranges);
			if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_compressed_font_data_base85);
			}
			return ret;
		}
		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<char> compressed_font_data_base85, float size_pixels, ImFontConfigPtr font_cfg)
		{
			// Marshaling 'compressed_font_data_base85' to native string
			byte* native_compressed_font_data_base85;
			var compressed_font_data_base85_byteCount = 0;
			if (compressed_font_data_base85 != null)
			{
				compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
				if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
				{
					native_compressed_font_data_base85 = Util.Allocate(compressed_font_data_base85_byteCount + 1);
				}
				else
				{
					var native_compressed_font_data_base85_stackBytes = stackalloc byte[compressed_font_data_base85_byteCount + 1];
					native_compressed_font_data_base85 = native_compressed_font_data_base85_stackBytes;
				}
				var compressed_font_data_base85_offset = Util.GetUtf8(compressed_font_data_base85, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
				native_compressed_font_data_base85[compressed_font_data_base85_offset] = 0;
			}
			else native_compressed_font_data_base85 = null;

			ushort* glyph_ranges = null;

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, font_cfg, glyph_ranges);
			if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_compressed_font_data_base85);
			}
			return ret;
		}
		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.
		/// </summary>
		public ImFontPtr AddFontFromMemoryCompressedBase85TTF(ReadOnlySpan<char> compressed_font_data_base85, float size_pixels, ImFontConfigPtr font_cfg, IntPtr glyph_ranges)
		{
			// Marshaling 'compressed_font_data_base85' to native string
			byte* native_compressed_font_data_base85;
			var compressed_font_data_base85_byteCount = 0;
			if (compressed_font_data_base85 != null)
			{
				compressed_font_data_base85_byteCount = Encoding.UTF8.GetByteCount(compressed_font_data_base85);
				if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
				{
					native_compressed_font_data_base85 = Util.Allocate(compressed_font_data_base85_byteCount + 1);
				}
				else
				{
					var native_compressed_font_data_base85_stackBytes = stackalloc byte[compressed_font_data_base85_byteCount + 1];
					native_compressed_font_data_base85 = native_compressed_font_data_base85_stackBytes;
				}
				var compressed_font_data_base85_offset = Util.GetUtf8(compressed_font_data_base85, native_compressed_font_data_base85, compressed_font_data_base85_byteCount);
				native_compressed_font_data_base85[compressed_font_data_base85_offset] = 0;
			}
			else native_compressed_font_data_base85 = null;

			// Marshaling 'glyph_ranges' to native ushort pointer
			ushort* native_glyph_ranges = (ushort*)glyph_ranges.ToPointer();

			var ret = ImGuiNative.ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(NativePtr, native_compressed_font_data_base85, size_pixels, font_cfg, native_glyph_ranges);
			if (compressed_font_data_base85_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_compressed_font_data_base85);
			}
			return ret;
		}

		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.
		/// </summary>
		public void ClearInputData()
		{
			ImGuiNative.ImFontAtlas_ClearInputData(NativePtr);
		}

		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.
		/// </summary>
		public void ClearTexData()
		{
			ImGuiNative.ImFontAtlas_ClearTexData(NativePtr);
		}

		/// <summary>
		/// Clear output font data (glyphs storage, UV coordinates).
		/// </summary>
		public void ClearFonts()
		{
			ImGuiNative.ImFontAtlas_ClearFonts(NativePtr);
		}

		/// <summary>
		/// Clear all input and output.
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImFontAtlas_Clear(NativePtr);
		}

		/// <summary>
		/// <para>Build atlas, retrieve pixel data.</para>
		/// <para>User is in charge of copying the pixels into graphics memory (e.g. create a texture with your engine). Then store your texture handle with SetTexID().</para>
		/// <para>The pitch is always = Width * BytesPerPixels (1 or 4)</para>
		/// <para>Building in RGBA32 format is provided for convenience and compatibility, but note that unless you manually manipulate or copy color data into</para>
		/// <para>the texture (e.g. when using the AddCustomRect*** api), then the RGB pixels emitted will always be white (~75% of memory/bandwidth waste.</para>
		/// </summary>
		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.
		/// </summary>
		public bool Build()
		{
			var ret = ImGuiNative.ImFontAtlas_Build(NativePtr);
			return ret != 0;
		}

		/// <summary>
		/// 1 byte per-pixel
		/// </summary>
		public void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height)
		{
			int* out_bytes_per_pixel = null;

			fixed (byte** native_out_pixels = &out_pixels)
			fixed (int* native_out_width = &out_width)
			fixed (int* native_out_height = &out_height)
			{
				ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
			}
		}
		/// <summary>
		/// 1 byte per-pixel
		/// </summary>
		public void GetTexDataAsAlpha8(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
		{
			fixed (byte** native_out_pixels = &out_pixels)
			fixed (int* native_out_width = &out_width)
			fixed (int* native_out_height = &out_height)
			fixed (int* native_out_bytes_per_pixel = &out_bytes_per_pixel)
			{
				ImGuiNative.ImFontAtlas_GetTexDataAsAlpha8(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
			}
		}

		/// <summary>
		/// 4 bytes-per-pixel
		/// </summary>
		public void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height)
		{
			int* out_bytes_per_pixel = null;

			fixed (byte** native_out_pixels = &out_pixels)
			fixed (int* native_out_width = &out_width)
			fixed (int* native_out_height = &out_height)
			{
				ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, out_bytes_per_pixel);
			}
		}
		/// <summary>
		/// 4 bytes-per-pixel
		/// </summary>
		public void GetTexDataAsRGBA32(out byte* out_pixels, out int out_width, out int out_height, out int out_bytes_per_pixel)
		{
			fixed (byte** native_out_pixels = &out_pixels)
			fixed (int* native_out_width = &out_width)
			fixed (int* native_out_height = &out_height)
			fixed (int* native_out_bytes_per_pixel = &out_bytes_per_pixel)
			{
				ImGuiNative.ImFontAtlas_GetTexDataAsRGBA32(NativePtr, native_out_pixels, native_out_width, native_out_height, native_out_bytes_per_pixel);
			}
		}

		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...
		/// </summary>
		public bool IsBuilt()
		{
			var ret = ImGuiNative.ImFontAtlas_IsBuilt(NativePtr);
			return ret != 0;
		}

		public void SetTexID(IntPtr id)
		{
			ImGuiNative.ImFontAtlas_SetTexID(NativePtr, id);
		}

		/// <summary>
		/// <para>Helpers to retrieve list of common Unicode ranges (2 value per range, values are inclusive, zero-terminated list)</para>
		/// <para>NB: Make sure that your string are UTF-8 and NOT in your local code page.</para>
		/// <para>Read https://github.com/ocornut/imgui/blob/master/docs/FONTS.md/#about-utf-8-encoding for details.</para>
		/// <para>NB: Consider using ImFontGlyphRangesBuilder to build glyph ranges from textual data.</para>
		/// </summary>
		/// <summary>
		/// Basic Latin, Extended Latin
		/// </summary>
		public ushort* GetGlyphRangesDefault()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesDefault(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Greek and Coptic
		/// </summary>
		public ushort* GetGlyphRangesGreek()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesGreek(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Korean characters
		/// </summary>
		public ushort* GetGlyphRangesKorean()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesKorean(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs
		/// </summary>
		public ushort* GetGlyphRangesJapanese()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesJapanese(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs
		/// </summary>
		public ushort* GetGlyphRangesChineseFull()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesChineseFull(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese
		/// </summary>
		public ushort* GetGlyphRangesChineseSimplifiedCommon()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + about 400 Cyrillic characters
		/// </summary>
		public ushort* GetGlyphRangesCyrillic()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesCyrillic(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Thai characters
		/// </summary>
		public ushort* GetGlyphRangesThai()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesThai(NativePtr);
			return ret;
		}

		/// <summary>
		/// Default + Vietnamese characters
		/// </summary>
		public ushort* GetGlyphRangesVietnamese()
		{
			var ret = ImGuiNative.ImFontAtlas_GetGlyphRangesVietnamese(NativePtr);
			return ret;
		}

		/// <summary>
		/// <para>You can request arbitrary rectangles to be packed into the atlas, for your own purposes.</para>
		/// <para>- After calling Build(), you can query the rectangle position and render your pixels.</para>
		/// <para>- If you render colored output, set 'atlas-&gt;TexPixelsUseColors = true' as this may help some backends decide of preferred texture format.</para>
		/// <para>- You can also request your rectangles to be mapped as font glyph (given a font + Unicode point),</para>
		/// <para>  so you can render e.g. custom colorful icons and use them as regular glyphs.</para>
		/// <para>- Read docs/FONTS.md for more details about using colorful icons.</para>
		/// <para>- Note: this API may be redesigned later in order to support multi-monitor varying DPI settings.</para>
		/// </summary>
		public int AddCustomRectRegular(int width, int height)
		{
			var ret = ImGuiNative.ImFontAtlas_AddCustomRectRegular(NativePtr, width, height);
			return ret;
		}

		public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advance_x)
		{
			Vector2 offset = new Vector2();

			var ret = ImGuiNative.ImFontAtlas_AddCustomRectFontGlyph(NativePtr, font, id, width, height, advance_x, offset);
			return ret;
		}
		public int AddCustomRectFontGlyph(ImFontPtr font, ushort id, int width, int height, float advance_x, Vector2 offset)
		{
			var ret = ImGuiNative.ImFontAtlas_AddCustomRectFontGlyph(NativePtr, font, id, width, height, advance_x, offset);
			return ret;
		}

		public ImFontAtlasCustomRectPtr GetCustomRectByIndex(int index)
		{
			var ret = ImGuiNative.ImFontAtlas_GetCustomRectByIndex(NativePtr, index);
			return ret;
		}

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		public void CalcCustomRectUV(ImFontAtlasCustomRectPtr rect, out Vector2 out_uv_min, out Vector2 out_uv_max)
		{
			fixed (Vector2* native_out_uv_min = &out_uv_min)
			fixed (Vector2* native_out_uv_max = &out_uv_max)
			{
				ImGuiNative.ImFontAtlas_CalcCustomRectUV(NativePtr, rect, native_out_uv_min, native_out_uv_max);
			}
		}

		public bool GetMouseCursorTexData(ImGuiMouseCursor cursor, out Vector2 out_offset, out Vector2 out_size, Vector2[] out_uv_border, Vector2[] out_uv_fill)
		{
			// Marshaling 'out_uv_border' to native Vector2 array
			var native_out_uv_border = stackalloc Vector2[out_uv_border.Length];
			for (var i = 0; i < out_uv_border.Length; i++)
			{
				native_out_uv_border[i] = out_uv_border[i];
			}

			// Marshaling 'out_uv_fill' to native Vector2 array
			var native_out_uv_fill = stackalloc Vector2[out_uv_fill.Length];
			for (var i = 0; i < out_uv_fill.Length; i++)
			{
				native_out_uv_fill[i] = out_uv_fill[i];
			}

			fixed (Vector2* native_out_offset = &out_offset)
			fixed (Vector2* native_out_size = &out_size)
			{
				var ret = ImGuiNative.ImFontAtlas_GetMouseCursorTexData(NativePtr, cursor, native_out_offset, native_out_size, native_out_uv_border, native_out_uv_fill);
				return ret != 0;
			}
		}
	}
}
