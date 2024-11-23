using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Font runtime data and rendering</para>
	/// <para>ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().</para>
	/// </summary>
	public unsafe partial struct ImFont
	{
		/// <summary>
		/// <para>Members: Hot ~20/24 bytes (for CalcTextSize)</para>
		/// </summary>
		/// <summary>
		/// 12-16 // out //            // Sparse. Glyphs-&gt;AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).
		/// </summary>
		public ImVector IndexAdvanceX;
		/// <summary>
		/// 4     // out // = FallbackGlyph-&gt;AdvanceX
		/// </summary>
		public float FallbackAdvanceX;
		/// <summary>
		/// 4     // in  //            // Height of characters/line, set during loading (don't change after loading)
		/// </summary>
		public float FontSize;
		/// <summary>
		/// <para>Members: Hot ~28/40 bytes (for CalcTextSize + render loop)</para>
		/// </summary>
		/// <summary>
		/// 12-16 // out //            // Sparse. Index glyphs by Unicode code-point.
		/// </summary>
		public ImVector IndexLookup;
		/// <summary>
		/// 12-16 // out //            // All glyphs.
		/// </summary>
		public ImVector Glyphs;
		/// <summary>
		/// 4-8   // out // = FindGlyph(FontFallbackChar)
		/// </summary>
		public ImFontGlyph* FallbackGlyph;
		/// <summary>
		/// <para>Members: Cold ~32/40 bytes</para>
		/// <para>Conceptually ConfigData[] is the list of font sources merged to create this font.</para>
		/// </summary>
		/// <summary>
		/// 4-8   // out //            // What we has been loaded into
		/// </summary>
		public ImFontAtlas* ContainerAtlas;
		/// <summary>
		/// 4-8   // in  //            // Pointer within ContainerAtlas-&gt;ConfigData to ConfigDataCount instances
		/// </summary>
		public ImFontConfig* ConfigData;
		/// <summary>
		/// 2     // in  // ~ 1        // Number of ImFontConfig involved in creating this font. Bigger than 1 when merging multiple font sources into one ImFont.
		/// </summary>
		public short ConfigDataCount;
		/// <summary>
		/// 2     // out // = FFFD/'?' // Character used if a glyph isn't found.
		/// </summary>
		public ushort FallbackChar;
		/// <summary>
		/// 2     // out // = '...'/'.'// Character used for ellipsis rendering.
		/// </summary>
		public ushort EllipsisChar;
		/// <summary>
		/// 1     // out // 1 or 3
		/// </summary>
		public short EllipsisCharCount;
		/// <summary>
		/// 4     // out               // Width
		/// </summary>
		public float EllipsisWidth;
		/// <summary>
		/// 4     // out               // Step between characters when EllipsisCount &gt; 0
		/// </summary>
		public float EllipsisCharStep;
		/// <summary>
		/// 1     // out //
		/// </summary>
		public byte DirtyLookupTables;
		/// <summary>
		/// 4     // in  // = 1.f      // Base font scale, multiplied by the per-window font scale which you can adjust with SetWindowFontScale()
		/// </summary>
		public float Scale;
		/// <summary>
		/// 4+4   // out //            // Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)
		/// </summary>
		public float Ascent;
		/// <summary>
		/// 4+4   // out //            // Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)
		/// </summary>
		public float Descent;
		/// <summary>
		/// 4     // out //            // Total surface in pixels to get an idea of the font rasterization/texture cost (not exact, we approximate the cost of padding between glyphs)
		/// </summary>
		public int MetricsTotalSurface;
		/// <summary>
		/// 2 bytes if ImWchar=ImWchar16, 34 bytes if ImWchar==ImWchar32. Store 1-bit for each block of 4K codepoints that has one active glyph. This is mainly used to facilitate iterations across all used codepoints.
		/// </summary>
		public fixed byte Used4kPagesMap[2];
	}

	/// <summary>
	/// <para>Font runtime data and rendering</para>
	/// <para>ImFontAtlas automatically loads a default embedded font for you when you call GetTexDataAsAlpha8() or GetTexDataAsRGBA32().</para>
	/// </summary>
	public unsafe partial struct ImFontPtr
	{
		public ImFont* NativePtr { get; }
		public ImFontPtr(ImFont* nativePtr) => NativePtr = nativePtr;
		public ImFontPtr(IntPtr nativePtr) => NativePtr = (ImFont*)nativePtr;
		public static implicit operator ImFontPtr(ImFont* nativePtr) => new ImFontPtr(nativePtr);
		public static implicit operator ImFont* (ImFontPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontPtr(IntPtr nativePtr) => new ImFontPtr(nativePtr);

		/// <summary>
		/// <para>Members: Hot ~20/24 bytes (for CalcTextSize)</para>
		/// </summary>
		/// <summary>
		/// 12-16 // out //            // Sparse. Glyphs-&gt;AdvanceX in a directly indexable way (cache-friendly for CalcTextSize functions which only this info, and are often bottleneck in large UI).
		/// </summary>
		public ImVector<float> IndexAdvanceX => new ImVector<float>(NativePtr->IndexAdvanceX);

		/// <summary>
		/// 4     // out // = FallbackGlyph-&gt;AdvanceX
		/// </summary>
		public ref float FallbackAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->FallbackAdvanceX);

		/// <summary>
		/// 4     // in  //            // Height of characters/line, set during loading (don't change after loading)
		/// </summary>
		public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);

		/// <summary>
		/// <para>Members: Hot ~28/40 bytes (for CalcTextSize + render loop)</para>
		/// </summary>
		/// <summary>
		/// 12-16 // out //            // Sparse. Index glyphs by Unicode code-point.
		/// </summary>
		public ImVector<ushort> IndexLookup => new ImVector<ushort>(NativePtr->IndexLookup);

		/// <summary>
		/// 12-16 // out //            // All glyphs.
		/// </summary>
		public ImPtrVector<ImFontGlyphPtr> Glyphs => new ImPtrVector<ImFontGlyphPtr>(NativePtr->Glyphs, Unsafe.SizeOf<ImFontGlyph>());

		/// <summary>
		/// 4-8   // out // = FindGlyph(FontFallbackChar)
		/// </summary>
		public ImFontGlyphPtr FallbackGlyph => new ImFontGlyphPtr(NativePtr->FallbackGlyph);

		/// <summary>
		/// <para>Members: Cold ~32/40 bytes</para>
		/// <para>Conceptually ConfigData[] is the list of font sources merged to create this font.</para>
		/// </summary>
		/// <summary>
		/// 4-8   // out //            // What we has been loaded into
		/// </summary>
		public ImFontAtlasPtr ContainerAtlas => new ImFontAtlasPtr(NativePtr->ContainerAtlas);

		/// <summary>
		/// 4-8   // in  //            // Pointer within ContainerAtlas-&gt;ConfigData to ConfigDataCount instances
		/// </summary>
		public ImFontConfigPtr ConfigData => new ImFontConfigPtr(NativePtr->ConfigData);

		/// <summary>
		/// 2     // in  // ~ 1        // Number of ImFontConfig involved in creating this font. Bigger than 1 when merging multiple font sources into one ImFont.
		/// </summary>
		public ref short ConfigDataCount => ref Unsafe.AsRef<short>(&NativePtr->ConfigDataCount);

		/// <summary>
		/// 2     // out // = FFFD/'?' // Character used if a glyph isn't found.
		/// </summary>
		public ref ushort FallbackChar => ref Unsafe.AsRef<ushort>(&NativePtr->FallbackChar);

		/// <summary>
		/// 2     // out // = '...'/'.'// Character used for ellipsis rendering.
		/// </summary>
		public ref ushort EllipsisChar => ref Unsafe.AsRef<ushort>(&NativePtr->EllipsisChar);

		/// <summary>
		/// 1     // out // 1 or 3
		/// </summary>
		public ref short EllipsisCharCount => ref Unsafe.AsRef<short>(&NativePtr->EllipsisCharCount);

		/// <summary>
		/// 4     // out               // Width
		/// </summary>
		public ref float EllipsisWidth => ref Unsafe.AsRef<float>(&NativePtr->EllipsisWidth);

		/// <summary>
		/// 4     // out               // Step between characters when EllipsisCount &gt; 0
		/// </summary>
		public ref float EllipsisCharStep => ref Unsafe.AsRef<float>(&NativePtr->EllipsisCharStep);

		/// <summary>
		/// 1     // out //
		/// </summary>
		public ref bool DirtyLookupTables => ref Unsafe.AsRef<bool>(&NativePtr->DirtyLookupTables);

		/// <summary>
		/// 4     // in  // = 1.f      // Base font scale, multiplied by the per-window font scale which you can adjust with SetWindowFontScale()
		/// </summary>
		public ref float Scale => ref Unsafe.AsRef<float>(&NativePtr->Scale);

		/// <summary>
		/// 4+4   // out //            // Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)
		/// </summary>
		public ref float Ascent => ref Unsafe.AsRef<float>(&NativePtr->Ascent);

		/// <summary>
		/// 4+4   // out //            // Ascent: distance from top to bottom of e.g. 'A' [0..FontSize] (unscaled)
		/// </summary>
		public ref float Descent => ref Unsafe.AsRef<float>(&NativePtr->Descent);

		/// <summary>
		/// 4     // out //            // Total surface in pixels to get an idea of the font rasterization/texture cost (not exact, we approximate the cost of padding between glyphs)
		/// </summary>
		public ref int MetricsTotalSurface => ref Unsafe.AsRef<int>(&NativePtr->MetricsTotalSurface);

		/// <summary>
		/// 2 bytes if ImWchar=ImWchar16, 34 bytes if ImWchar==ImWchar32. Store 1-bit for each block of 4K codepoints that has one active glyph. This is mainly used to facilitate iterations across all used codepoints.
		/// </summary>
		public RangeAccessor<byte> Used4kPagesMap => new RangeAccessor<byte>(NativePtr->Used4kPagesMap, 2);

		public ImFontGlyphPtr FindGlyph(ushort c)
		{
			var ret = ImGuiNative.ImFont_FindGlyph(NativePtr, c);
			return ret;
		}

		public ImFontGlyphPtr FindGlyphNoFallback(ushort c)
		{
			var ret = ImGuiNative.ImFont_FindGlyphNoFallback(NativePtr, c);
			return ret;
		}

		public float GetCharAdvance(ushort c)
		{
			var ret = ImGuiNative.ImFont_GetCharAdvance(NativePtr, c);
			return ret;
		}

		public bool IsLoaded()
		{
			var ret = ImGuiNative.ImFont_IsLoaded(NativePtr);
			return ret != 0;
		}

		public string GetDebugName()
		{
			var ret = ImGuiNative.ImFont_GetDebugName(NativePtr);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// <para>'max_width' stops rendering after a certain width (could be turned into a 2d size). FLT_MAX to disable.</para>
		/// <para>'wrap_width' enable automatic word-wrapping across multiple lines to fit into given width. 0.0f to disable.</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, remaining = NULL
		/// </summary>
		public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, ReadOnlySpan<char> text_begin)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			var ret = ImGuiNative.ImFont_CalcTextSizeA(NativePtr, size, max_width, wrap_width, native_text_begin);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			return ret;
		}

		/// <summary>
		/// <para>'max_width' stops rendering after a certain width (could be turned into a 2d size). FLT_MAX to disable.</para>
		/// <para>'wrap_width' enable automatic word-wrapping across multiple lines to fit into given width. 0.0f to disable.</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, remaining = NULL
		/// </summary>
		public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			byte** remaining = null;

			var ret = ImGuiNative.ImFont_CalcTextSizeAEx(NativePtr, size, max_width, wrap_width, native_text_begin, native_text_end, remaining);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return ret;
		}
		/// <summary>
		/// <para>'max_width' stops rendering after a certain width (could be turned into a 2d size). FLT_MAX to disable.</para>
		/// <para>'wrap_width' enable automatic word-wrapping across multiple lines to fit into given width. 0.0f to disable.</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, remaining = NULL
		/// </summary>
		public Vector2 CalcTextSizeA(float size, float max_width, float wrap_width, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end, ref byte* remaining)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (byte** native_remaining = &remaining)
			{
				var ret = ImGuiNative.ImFont_CalcTextSizeAEx(NativePtr, size, max_width, wrap_width, native_text_begin, native_text_end, native_remaining);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_begin);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
				return ret;
			}
		}

		public string CalcWordWrapPositionA(float scale, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, float wrap_width)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			var ret = ImGuiNative.ImFont_CalcWordWrapPositionA(NativePtr, scale, native_text, native_text_end, wrap_width);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return Util.StringFromPtr(ret);
		}

		public void RenderChar(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, ushort c)
		{
			ImGuiNative.ImFont_RenderChar(NativePtr, draw_list, size, pos, col, c);
		}

		public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			float wrap_width = 0.0f;

			byte cpu_fine_clip = 0;

			ImGuiNative.ImFont_RenderText(NativePtr, draw_list, size, pos, col, clip_rect, native_text_begin, native_text_end, wrap_width, cpu_fine_clip);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}
		public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end, float wrap_width)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			byte cpu_fine_clip = 0;

			ImGuiNative.ImFont_RenderText(NativePtr, draw_list, size, pos, col, clip_rect, native_text_begin, native_text_end, wrap_width, cpu_fine_clip);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}
		public void RenderText(ImDrawListPtr draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end, float wrap_width, bool cpu_fine_clip)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			// Marshaling 'cpu_fine_clip' to native bool
			var native_cpu_fine_clip = cpu_fine_clip ? (byte)1 : (byte)0;

			ImGuiNative.ImFont_RenderText(NativePtr, draw_list, size, pos, col, clip_rect, native_text_begin, native_text_end, wrap_width, native_cpu_fine_clip);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		/// <summary>
		/// <para>[Internal] Don't use!</para>
		/// </summary>
		public void BuildLookupTable()
		{
			ImGuiNative.ImFont_BuildLookupTable(NativePtr);
		}

		public void ClearOutputData()
		{
			ImGuiNative.ImFont_ClearOutputData(NativePtr);
		}

		public void GrowIndex(int new_size)
		{
			ImGuiNative.ImFont_GrowIndex(NativePtr, new_size);
		}

		public void AddGlyph(ImFontConfigPtr src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x)
		{
			ImGuiNative.ImFont_AddGlyph(NativePtr, src_cfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advance_x);
		}

		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.
		/// </summary>
		public void AddRemapChar(ushort dst, ushort src)
		{
			byte overwrite_dst = 1;

			ImGuiNative.ImFont_AddRemapChar(NativePtr, dst, src, overwrite_dst);
		}
		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.
		/// </summary>
		public void AddRemapChar(ushort dst, ushort src, bool overwrite_dst)
		{
			// Marshaling 'overwrite_dst' to native bool
			var native_overwrite_dst = overwrite_dst ? (byte)1 : (byte)0;

			ImGuiNative.ImFont_AddRemapChar(NativePtr, dst, src, native_overwrite_dst);
		}

		public void SetGlyphVisible(ushort c, bool visible)
		{
			// Marshaling 'visible' to native bool
			var native_visible = visible ? (byte)1 : (byte)0;

			ImGuiNative.ImFont_SetGlyphVisible(NativePtr, c, native_visible);
		}

		public bool IsGlyphRangeUnused(uint c_begin, uint c_last)
		{
			var ret = ImGuiNative.ImFont_IsGlyphRangeUnused(NativePtr, c_begin, c_last);
			return ret != 0;
		}
	}
}
