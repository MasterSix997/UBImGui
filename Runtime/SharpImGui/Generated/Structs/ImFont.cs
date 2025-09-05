using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Font runtime data and rendering<br/>ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFont
	{
		/// <summary>
		/// <br/>    [Internal] Members: Hot ~20/24 bytes (for CalcTextSize)<br/>
		/// 12-16 out Sparse. Glyphs-&gt;AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).<br/>
		/// </summary>
		public ImVector<float> IndexAdvanceX;
		/// <summary>
		/// 4     out = FallbackGlyph-&gt;AdvanceX<br/>
		/// </summary>
		public float FallbackAdvanceX;
		/// <summary>
		/// 4     in  Height of characters/line, set during loading (don't change after loading)<br/>
		/// </summary>
		public float FontSize;
		/// <summary>
		///     [Internal] Members: Hot ~28/40 bytes (for RenderText loop)<br/>
		/// 12-16 out Sparse. Index glyphs by Unicode code-point.<br/>
		/// </summary>
		public ImVector<ushort> IndexLookup;
		/// <summary>
		/// 12-16 out All glyphs.<br/>
		/// </summary>
		public ImVector<ImFontGlyph> Glyphs;
		/// <summary>
		/// 4-8   out = FindGlyph(FontFallbackChar)<br/>
		/// </summary>
		public unsafe ImFontGlyph* FallbackGlyph;
		/// <summary>
		///     [Internal] Members: Cold ~32/40 bytes<br/>    Conceptually Sources[] is the list of font sources merged to create this font.<br/>
		/// 4-8   out What we has been loaded into<br/>
		/// </summary>
		public unsafe ImFontAtlas* ContainerAtlas;
		/// <summary>
		/// 4-8   in  Pointer within ContainerAtlas-&gt;Sources[], to SourcesCount instances<br/>
		/// </summary>
		public unsafe ImFontConfig* Sources;
		/// <summary>
		/// 2     in  Number of ImFontConfig involved in creating this font. Usually 1, or &gt;1 when merging multiple font sources into one ImFont.<br/>
		/// </summary>
		public short SourcesCount;
		/// <summary>
		/// 1     out 1 or 3<br/>
		/// </summary>
		public short EllipsisCharCount;
		/// <summary>
		/// 2-4   out Character used for ellipsis rendering ('...').<br/>
		/// </summary>
		public ushort EllipsisChar;
		/// <summary>
		/// 2-4   out Character used if a glyph isn't found (U+FFFD, '?')<br/>
		/// </summary>
		public ushort FallbackChar;
		/// <summary>
		/// 4     out Total ellipsis Width<br/>
		/// </summary>
		public float EllipsisWidth;
		/// <summary>
		/// 4     out Step between characters when EllipsisCount &gt; 0<br/>
		/// </summary>
		public float EllipsisCharStep;
		/// <summary>
		/// 4     in  Base font scale (1.0f), multiplied by the per-window font scale which you can adjust with SetWindowFontScale()<br/>
		/// </summary>
		public float Scale;
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public float Ascent;
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public float Descent;
		/// <summary>
		/// 4     out Total surface in pixels to get an idea of the font rasterization/texture cost (not exact, we approximate the cost of padding between glyphs)<br/>
		/// </summary>
		public int MetricsTotalSurface;
		/// <summary>
		/// 1     out //<br/>
		/// </summary>
		public byte DirtyLookupTables;
		/// <summary>
		/// 1 bytes if ImWchar=ImWchar16, 16 bytes if ImWchar==ImWchar32. Store 1-bit for each block of 4K codepoints that has one active glyph. This is mainly used to facilitate iterations across all used codepoints.<br/>
		/// </summary>
		public byte Used8KPagesMap_0;
	}

	/// <summary>
	/// Font runtime data and rendering<br/>ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().<br/>
	/// </summary>
	public unsafe partial struct ImFontPtr
	{
		public ImFont* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFont this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    [Internal] Members: Hot ~20/24 bytes (for CalcTextSize)<br/>
		/// 12-16 out Sparse. Glyphs-&gt;AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).<br/>
		/// </summary>
		public ref ImVector<float> IndexAdvanceX => ref Unsafe.AsRef<ImVector<float>>(&NativePtr->IndexAdvanceX);
		/// <summary>
		/// 4     out = FallbackGlyph-&gt;AdvanceX<br/>
		/// </summary>
		public ref float FallbackAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->FallbackAdvanceX);
		/// <summary>
		/// 4     in  Height of characters/line, set during loading (don't change after loading)<br/>
		/// </summary>
		public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);
		/// <summary>
		///     [Internal] Members: Hot ~28/40 bytes (for RenderText loop)<br/>
		/// 12-16 out Sparse. Index glyphs by Unicode code-point.<br/>
		/// </summary>
		public ref ImVector<ushort> IndexLookup => ref Unsafe.AsRef<ImVector<ushort>>(&NativePtr->IndexLookup);
		/// <summary>
		/// 12-16 out All glyphs.<br/>
		/// </summary>
		public ref ImVector<ImFontGlyph> Glyphs => ref Unsafe.AsRef<ImVector<ImFontGlyph>>(&NativePtr->Glyphs);
		/// <summary>
		/// 4-8   out = FindGlyph(FontFallbackChar)<br/>
		/// </summary>
		public ref ImFontGlyphPtr FallbackGlyph => ref Unsafe.AsRef<ImFontGlyphPtr>(&NativePtr->FallbackGlyph);
		/// <summary>
		///     [Internal] Members: Cold ~32/40 bytes<br/>    Conceptually Sources[] is the list of font sources merged to create this font.<br/>
		/// 4-8   out What we has been loaded into<br/>
		/// </summary>
		public ref ImFontAtlasPtr ContainerAtlas => ref Unsafe.AsRef<ImFontAtlasPtr>(&NativePtr->ContainerAtlas);
		/// <summary>
		/// 4-8   in  Pointer within ContainerAtlas-&gt;Sources[], to SourcesCount instances<br/>
		/// </summary>
		public ref ImFontConfigPtr Sources => ref Unsafe.AsRef<ImFontConfigPtr>(&NativePtr->Sources);
		/// <summary>
		/// 2     in  Number of ImFontConfig involved in creating this font. Usually 1, or &gt;1 when merging multiple font sources into one ImFont.<br/>
		/// </summary>
		public ref short SourcesCount => ref Unsafe.AsRef<short>(&NativePtr->SourcesCount);
		/// <summary>
		/// 1     out 1 or 3<br/>
		/// </summary>
		public ref short EllipsisCharCount => ref Unsafe.AsRef<short>(&NativePtr->EllipsisCharCount);
		/// <summary>
		/// 2-4   out Character used for ellipsis rendering ('...').<br/>
		/// </summary>
		public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);
		/// <summary>
		/// 2-4   out Character used if a glyph isn't found (U+FFFD, '?')<br/>
		/// </summary>
		public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);
		/// <summary>
		/// 4     out Total ellipsis Width<br/>
		/// </summary>
		public ref float EllipsisWidth => ref Unsafe.AsRef<float>(&NativePtr->EllipsisWidth);
		/// <summary>
		/// 4     out Step between characters when EllipsisCount &gt; 0<br/>
		/// </summary>
		public ref float EllipsisCharStep => ref Unsafe.AsRef<float>(&NativePtr->EllipsisCharStep);
		/// <summary>
		/// 4     in  Base font scale (1.0f), multiplied by the per-window font scale which you can adjust with SetWindowFontScale()<br/>
		/// </summary>
		public ref float Scale => ref Unsafe.AsRef<float>(&NativePtr->Scale);
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public ref float Ascent => ref Unsafe.AsRef<float>(&NativePtr->Ascent);
		/// <summary>
		/// 4+4   out Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)<br/>
		/// </summary>
		public ref float Descent => ref Unsafe.AsRef<float>(&NativePtr->Descent);
		/// <summary>
		/// 4     out Total surface in pixels to get an idea of the font rasterization/texture cost (not exact, we approximate the cost of padding between glyphs)<br/>
		/// </summary>
		public ref int MetricsTotalSurface => ref Unsafe.AsRef<int>(&NativePtr->MetricsTotalSurface);
		/// <summary>
		/// 1     out //<br/>
		/// </summary>
		public ref bool DirtyLookupTables => ref Unsafe.AsRef<bool>(&NativePtr->DirtyLookupTables);
		/// <summary>
		/// 1 bytes if ImWchar=ImWchar16, 16 bytes if ImWchar==ImWchar32. Store 1-bit for each block of 4K codepoints that has one active glyph. This is mainly used to facilitate iterations across all used codepoints.<br/>
		/// </summary>
		public Span<byte> Used8KPagesMap => new Span<byte>(&NativePtr->Used8KPagesMap_0, 1);
		public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
		public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
		public static implicit operator ImFontPtr(ImFont* ptr) => new ImFontPtr(ptr);
		public static implicit operator ImFontPtr(IntPtr ptr) => new ImFontPtr(ptr);
		public static implicit operator ImFont*(ImFontPtr nativePtr) => nativePtr.NativePtr;
		public bool IsGlyphRangeUnused(uint cBegin, uint cLast)
		{
			var result = ImGuiNative.ImFontIsGlyphRangeUnused(NativePtr, cBegin, cLast);
			return result != 0;
		}

		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public void AddRemapChar(ushort dst, ushort src, bool overwriteDst)
		{
			var native_overwriteDst = overwriteDst ? (byte)1 : (byte)0;
			ImGuiNative.ImFontAddRemapChar(NativePtr, dst, src, native_overwriteDst);
		}

		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		public void AddRemapChar(ushort dst, ushort src)
		{
			// defining omitted parameters
			byte overwriteDst = 1;
			ImGuiNative.ImFontAddRemapChar(NativePtr, dst, src, overwriteDst);
		}

		public void AddGlyph(ImFontConfigPtr srcCfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			ImGuiNative.ImFontAddGlyph(NativePtr, srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
		}

		public void GrowIndex(int newSize)
		{
			ImGuiNative.ImFontGrowIndex(NativePtr, newSize);
		}

		public void ClearOutputData()
		{
			ImGuiNative.ImFontClearOutputData(NativePtr);
		}

		public void BuildLookupTable()
		{
			ImGuiNative.ImFontBuildLookupTable(NativePtr);
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd, float wrapWidth, bool cpuFineClip)
		{
			var native_cpuFineClip = cpuFineClip ? (byte)1 : (byte)0;
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, nativeTextBegin, nativeTextEnd, wrapWidth, native_cpuFineClip);
			}
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd, float wrapWidth, bool cpuFineClip)
		{
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			var native_cpuFineClip = cpuFineClip ? (byte)1 : (byte)0;
			ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, nativeTextBegin, nativeTextEnd, wrapWidth, native_cpuFineClip);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd, float wrapWidth)
		{
			// defining omitted parameters
			byte cpuFineClip = 0;
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, nativeTextBegin, nativeTextEnd, wrapWidth, cpuFineClip);
			}
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd, float wrapWidth)
		{
			// defining omitted parameters
			byte cpuFineClip = 0;
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, nativeTextBegin, nativeTextEnd, wrapWidth, cpuFineClip);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			float wrapWidth = 0.0f;
			byte cpuFineClip = 0;
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, nativeTextBegin, nativeTextEnd, wrapWidth, cpuFineClip);
			}
		}

		public void RenderText(ImDrawListPtr drawList, float size, Vector2 pos, uint col, Vector4 clipRect, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// defining omitted parameters
			float wrapWidth = 0.0f;
			byte cpuFineClip = 0;
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.ImFontRenderText(NativePtr, drawList, size, pos, col, clipRect, nativeTextBegin, nativeTextEnd, wrapWidth, cpuFineClip);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public void RenderChar(ImDrawListPtr drawList, float size, Vector2 pos, uint col, ushort c)
		{
			ImGuiNative.ImFontRenderChar(NativePtr, drawList, size, pos, col, c);
		}

		public string CalcWordWrapPositionA(float scale, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, float wrapWidth)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				var result = ImGuiNative.ImFontCalcWordWrapPositionA(NativePtr, scale, nativeText, nativeTextEnd, wrapWidth);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public string CalcWordWrapPositionA(float scale, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, float wrapWidth)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			var result = ImGuiNative.ImFontCalcWordWrapPositionA(NativePtr, scale, nativeText, nativeTextEnd, wrapWidth);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(out Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd, ref byte* remaining)
		{
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (byte** nativeRemaining = &remaining)
			{
				ImGuiNative.ImFontCalcTextSizeA(nativePOut, NativePtr, size, maxWidth, wrapWidth, nativeTextBegin, nativeTextEnd, nativeRemaining);
			}
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(out Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd, ref byte* remaining)
		{
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativePOut = &pOut)
			fixed (byte** nativeRemaining = &remaining)
			{
				ImGuiNative.ImFontCalcTextSizeA(nativePOut, NativePtr, size, maxWidth, wrapWidth, nativeTextBegin, nativeTextEnd, nativeRemaining);
				// Freeing textBegin native string
				if (byteCountTextBegin > Utils.MaxStackallocSize)
					Utils.Free(nativeTextBegin);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(out Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			byte** remaining = null;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImFontCalcTextSizeA(nativePOut, NativePtr, size, maxWidth, wrapWidth, nativeTextBegin, nativeTextEnd, remaining);
			}
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(out Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// defining omitted parameters
			byte** remaining = null;
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImFontCalcTextSizeA(nativePOut, NativePtr, size, maxWidth, wrapWidth, nativeTextBegin, nativeTextEnd, remaining);
				// Freeing textBegin native string
				if (byteCountTextBegin > Utils.MaxStackallocSize)
					Utils.Free(nativeTextBegin);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(out Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<byte> textBegin)
		{
			// defining omitted parameters
			byte** remaining = null;
			byte* textEnd = null;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeTextBegin = textBegin)
			{
				ImGuiNative.ImFontCalcTextSizeA(nativePOut, NativePtr, size, maxWidth, wrapWidth, nativeTextBegin, textEnd, remaining);
			}
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		public void CalcTextSizeA(out Vector2 pOut, float size, float maxWidth, float wrapWidth, ReadOnlySpan<char> textBegin)
		{
			// defining omitted parameters
			byte** remaining = null;
			byte* textEnd = null;
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImFontCalcTextSizeA(nativePOut, NativePtr, size, maxWidth, wrapWidth, nativeTextBegin, textEnd, remaining);
				// Freeing textBegin native string
				if (byteCountTextBegin > Utils.MaxStackallocSize)
					Utils.Free(nativeTextBegin);
			}
		}

		public string GetDebugName()
		{
			var result = ImGuiNative.ImFontGetDebugName(NativePtr);
			return Utils.DecodeStringUTF8(result);
		}

		public bool IsLoaded()
		{
			var result = ImGuiNative.ImFontIsLoaded(NativePtr);
			return result != 0;
		}

		public float GetCharAdvance(ushort c)
		{
			return ImGuiNative.ImFontGetCharAdvance(NativePtr, c);
		}

		public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
		{
			return ImGuiNative.ImFontFindGlyphNoFallback(NativePtr, c);
		}

		public ImFontGlyphPtr FindGlyph(ushort c)
		{
			return ImGuiNative.ImFontFindGlyph(NativePtr, c);
		}

		public void Destroy()
		{
			ImGuiNative.ImFontDestroy(NativePtr);
		}

		public void ImFontConstruct()
		{
			ImGuiNative.ImFontImFontConstruct(NativePtr);
		}

		public ImFontPtr ImFont()
		{
			return ImGuiNative.ImFontImFont();
		}

	}
}
