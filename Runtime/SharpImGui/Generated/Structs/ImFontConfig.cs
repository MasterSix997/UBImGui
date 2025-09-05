using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// A font input/source (we may rename this to ImFontSource in the future)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontConfig
	{
		/// <summary>
		///          TTF/OTF data<br/>
		/// </summary>
		public unsafe void* FontData;
		/// <summary>
		///          TTF/OTF data size<br/>
		/// </summary>
		public int FontDataSize;
		/// <summary>
		/// true     TTF/OTF data ownership taken by the container ImFontAtlas (will delete memory itself).<br/>
		/// </summary>
		public byte FontDataOwnedByAtlas;
		/// <summary>
		/// false    Merge into previous ImFont, so you can combine multiple inputs font into one ImFont (e.g. ASCII font + icons + Japanese glyphs). You may want to use GlyphOffset.y when merge font of different heights.<br/>
		/// </summary>
		public byte MergeMode;
		/// <summary>
		/// false    Align every glyph AdvanceX to pixel boundaries. Useful e.g. if you are merging a non-pixel aligned font with the default font. If enabled, you can set OversampleH/V to 1.<br/>
		/// </summary>
		public byte PixelSnapH;
		/// <summary>
		/// 0        Index of font within TTF/OTF file<br/>
		/// </summary>
		public int FontNo;
		/// <summary>
		/// 0 (2)    Rasterize at higher quality for sub-pixel positioning. 0 == auto == 1 or 2 depending on size. Note the difference between 2 and 3 is minimal. You can reduce this to 1 for large glyphs save memory. Read https://github.com/nothings/stb/blob/master/tests/oversample/README.md for details.<br/>
		/// </summary>
		public int OversampleH;
		/// <summary>
		/// 0 (1)    Rasterize at higher quality for sub-pixel positioning. 0 == auto == 1. This is not really useful as we don't use sub-pixel positions on the Y axis.<br/>
		/// </summary>
		public int OversampleV;
		/// <summary>
		///          Size in pixels for rasterizer (more or less maps to the resulting font height).<br/>
		/// </summary>
		public float SizePixels;
		/// <summary>
		/// <br/>    //ImVec2        GlyphExtraSpacing;      0, 0     (REMOVED IN 1.91.9: use GlyphExtraAdvanceX)<br/>
		/// 0, 0     Offset all glyphs from this font input.<br/>
		/// </summary>
		public Vector2 GlyphOffset;
		/// <summary>
		/// NULL     THE ARRAY DATA NEEDS TO PERSIST AS LONG AS THE FONT IS ALIVE. Pointer to a user-provided list of Unicode range (2 value per range, values are inclusive, zero-terminated list).<br/>
		/// </summary>
		public unsafe ushort* GlyphRanges;
		/// <summary>
		/// 0        Minimum AdvanceX for glyphs, set Min to align font icons, set both Min/Max to enforce mono-space font<br/>
		/// </summary>
		public float GlyphMinAdvanceX;
		/// <summary>
		/// FLT_MAX  Maximum AdvanceX for glyphs<br/>
		/// </summary>
		public float GlyphMaxAdvanceX;
		/// <summary>
		/// 0        Extra spacing (in pixels) between glyphs. Please contact us if you are using this.<br/>
		/// </summary>
		public float GlyphExtraAdvanceX;
		/// <summary>
		/// 0        Settings for custom font builder. THIS IS BUILDER IMPLEMENTATION DEPENDENT. Leave as zero if unsure.<br/>
		/// </summary>
		public uint FontBuilderFlags;
		/// <summary>
		/// 1.0f     Linearly brighten (&gt;1.0f) or darken (&lt;1.0f) font output. Brightening small fonts may be a good workaround to make them more readable. This is a silly thing we may remove in the future.<br/>
		/// </summary>
		public float RasterizerMultiply;
		/// <summary>
		/// 1.0f     DPI scale for rasterization, not altering other font metrics: make it easy to swap between e.g. a 100% and a 400% fonts for a zooming display. IMPORTANT: If you increase this it is expected that you increase font scale accordingly, otherwise quality may look lowered.<br/>
		/// </summary>
		public float RasterizerDensity;
		/// <summary>
		/// 0        Explicitly specify Unicode codepoint of ellipsis character. When fonts are being merged first specified ellipsis will be used.<br/>
		/// </summary>
		public ushort EllipsisChar;
		/// <summary>
		///     [Internal]<br/>
		/// Name (strictly to ease debugging)<br/>
		/// </summary>
		public byte Name_0;
		public byte Name_1;
		public byte Name_2;
		public byte Name_3;
		public byte Name_4;
		public byte Name_5;
		public byte Name_6;
		public byte Name_7;
		public byte Name_8;
		public byte Name_9;
		public byte Name_10;
		public byte Name_11;
		public byte Name_12;
		public byte Name_13;
		public byte Name_14;
		public byte Name_15;
		public byte Name_16;
		public byte Name_17;
		public byte Name_18;
		public byte Name_19;
		public byte Name_20;
		public byte Name_21;
		public byte Name_22;
		public byte Name_23;
		public byte Name_24;
		public byte Name_25;
		public byte Name_26;
		public byte Name_27;
		public byte Name_28;
		public byte Name_29;
		public byte Name_30;
		public byte Name_31;
		public byte Name_32;
		public byte Name_33;
		public byte Name_34;
		public byte Name_35;
		public byte Name_36;
		public byte Name_37;
		public byte Name_38;
		public byte Name_39;
		public unsafe ImFont* DstFont;
	}

	/// <summary>
	/// A font input/source (we may rename this to ImFontSource in the future)<br/>
	/// </summary>
	public unsafe partial struct ImFontConfigPtr
	{
		public ImFontConfig* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontConfig this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		///          TTF/OTF data<br/>
		/// </summary>
		public IntPtr FontData { get => (IntPtr)NativePtr->FontData; set => NativePtr->FontData = (void*)value; }
		/// <summary>
		///          TTF/OTF data size<br/>
		/// </summary>
		public ref int FontDataSize => ref Unsafe.AsRef<int>(&NativePtr->FontDataSize);
		/// <summary>
		/// true     TTF/OTF data ownership taken by the container ImFontAtlas (will delete memory itself).<br/>
		/// </summary>
		public ref bool FontDataOwnedByAtlas => ref Unsafe.AsRef<bool>(&NativePtr->FontDataOwnedByAtlas);
		/// <summary>
		/// false    Merge into previous ImFont, so you can combine multiple inputs font into one ImFont (e.g. ASCII font + icons + Japanese glyphs). You may want to use GlyphOffset.y when merge font of different heights.<br/>
		/// </summary>
		public ref bool MergeMode => ref Unsafe.AsRef<bool>(&NativePtr->MergeMode);
		/// <summary>
		/// false    Align every glyph AdvanceX to pixel boundaries. Useful e.g. if you are merging a non-pixel aligned font with the default font. If enabled, you can set OversampleH/V to 1.<br/>
		/// </summary>
		public ref bool PixelSnapH => ref Unsafe.AsRef<bool>(&NativePtr->PixelSnapH);
		/// <summary>
		/// 0        Index of font within TTF/OTF file<br/>
		/// </summary>
		public ref int FontNo => ref Unsafe.AsRef<int>(&NativePtr->FontNo);
		/// <summary>
		/// 0 (2)    Rasterize at higher quality for sub-pixel positioning. 0 == auto == 1 or 2 depending on size. Note the difference between 2 and 3 is minimal. You can reduce this to 1 for large glyphs save memory. Read https://github.com/nothings/stb/blob/master/tests/oversample/README.md for details.<br/>
		/// </summary>
		public ref int OversampleH => ref Unsafe.AsRef<int>(&NativePtr->OversampleH);
		/// <summary>
		/// 0 (1)    Rasterize at higher quality for sub-pixel positioning. 0 == auto == 1. This is not really useful as we don't use sub-pixel positions on the Y axis.<br/>
		/// </summary>
		public ref int OversampleV => ref Unsafe.AsRef<int>(&NativePtr->OversampleV);
		/// <summary>
		///          Size in pixels for rasterizer (more or less maps to the resulting font height).<br/>
		/// </summary>
		public ref float SizePixels => ref Unsafe.AsRef<float>(&NativePtr->SizePixels);
		/// <summary>
		/// <br/>    //ImVec2        GlyphExtraSpacing;      0, 0     (REMOVED IN 1.91.9: use GlyphExtraAdvanceX)<br/>
		/// 0, 0     Offset all glyphs from this font input.<br/>
		/// </summary>
		public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);
		/// <summary>
		/// NULL     THE ARRAY DATA NEEDS TO PERSIST AS LONG AS THE FONT IS ALIVE. Pointer to a user-provided list of Unicode range (2 value per range, values are inclusive, zero-terminated list).<br/>
		/// </summary>
		public IntPtr GlyphRanges { get => (IntPtr)NativePtr->GlyphRanges; set => NativePtr->GlyphRanges = (ushort*)value; }
		/// <summary>
		/// 0        Minimum AdvanceX for glyphs, set Min to align font icons, set both Min/Max to enforce mono-space font<br/>
		/// </summary>
		public ref float GlyphMinAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMinAdvanceX);
		/// <summary>
		/// FLT_MAX  Maximum AdvanceX for glyphs<br/>
		/// </summary>
		public ref float GlyphMaxAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphMaxAdvanceX);
		/// <summary>
		/// 0        Extra spacing (in pixels) between glyphs. Please contact us if you are using this.<br/>
		/// </summary>
		public ref float GlyphExtraAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphExtraAdvanceX);
		/// <summary>
		/// 0        Settings for custom font builder. THIS IS BUILDER IMPLEMENTATION DEPENDENT. Leave as zero if unsure.<br/>
		/// </summary>
		public ref uint FontBuilderFlags => ref Unsafe.AsRef<uint>(&NativePtr->FontBuilderFlags);
		/// <summary>
		/// 1.0f     Linearly brighten (&gt;1.0f) or darken (&lt;1.0f) font output. Brightening small fonts may be a good workaround to make them more readable. This is a silly thing we may remove in the future.<br/>
		/// </summary>
		public ref float RasterizerMultiply => ref Unsafe.AsRef<float>(&NativePtr->RasterizerMultiply);
		/// <summary>
		/// 1.0f     DPI scale for rasterization, not altering other font metrics: make it easy to swap between e.g. a 100% and a 400% fonts for a zooming display. IMPORTANT: If you increase this it is expected that you increase font scale accordingly, otherwise quality may look lowered.<br/>
		/// </summary>
		public ref float RasterizerDensity => ref Unsafe.AsRef<float>(&NativePtr->RasterizerDensity);
		/// <summary>
		/// 0        Explicitly specify Unicode codepoint of ellipsis character. When fonts are being merged first specified ellipsis will be used.<br/>
		/// </summary>
		public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
		/// <summary>
		///     [Internal]<br/>
		/// Name (strictly to ease debugging)<br/>
		/// </summary>
		public Span<byte> Name => new Span<byte>(&NativePtr->Name_0, 40);
		public ref ImFontPtr DstFont => ref Unsafe.AsRef<ImFontPtr>(&NativePtr->DstFont);
		public ImFontConfigPtr(ImFontConfig* nativePtr) => NativePtr = nativePtr;
		public ImFontConfigPtr(IntPtr nativePtr) => NativePtr = (ImFontConfig*)nativePtr;
		public static implicit operator ImFontConfigPtr(ImFontConfig* ptr) => new ImFontConfigPtr(ptr);
		public static implicit operator ImFontConfigPtr(IntPtr ptr) => new ImFontConfigPtr(ptr);
		public static implicit operator ImFontConfig*(ImFontConfigPtr nativePtr) => nativePtr.NativePtr;
		public void ImFontConfDestroy()
		{
			ImGuiNative.ImFontConfDestroy(NativePtr);
		}

		public void ImFontConfImFontConfConstruct()
		{
			ImGuiNative.ImFontConfImFontConfConstruct(NativePtr);
		}

		public ImFontConfigPtr ImFontConfImFontConf()
		{
			return ImGuiNative.ImFontConfImFontConf();
		}

	}
}
