using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().</para>
	/// <para>This is essentially a tightly packed of vector of 64k booleans = 8KB storage.</para>
	/// </summary>
	public unsafe partial struct ImFontGlyphRangesBuilder
	{
		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)
		/// </summary>
		public ImVector UsedChars;
	}

	/// <summary>
	/// <para>Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().</para>
	/// <para>This is essentially a tightly packed of vector of 64k booleans = 8KB storage.</para>
	/// </summary>
	public unsafe partial struct ImFontGlyphRangesBuilderPtr
	{
		public ImFontGlyphRangesBuilder* NativePtr { get; }
		public ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyphRangesBuilder*)nativePtr;
		public static implicit operator ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => new ImFontGlyphRangesBuilderPtr(nativePtr);
		public static implicit operator ImFontGlyphRangesBuilder* (ImFontGlyphRangesBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => new ImFontGlyphRangesBuilderPtr(nativePtr);

		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)
		/// </summary>
		public ImVector<uint> UsedChars => new ImVector<uint>(NativePtr->UsedChars);

		public void Clear()
		{
			ImGuiNative.ImFontGlyphRangesBuilder_Clear(NativePtr);
		}

		/// <summary>
		/// Get bit n in the array
		/// </summary>
		public bool GetBit(uint n)
		{
			var ret = ImGuiNative.ImFontGlyphRangesBuilder_GetBit(NativePtr, n);
			return ret != 0;
		}

		/// <summary>
		/// Set bit n in the array
		/// </summary>
		public void SetBit(uint n)
		{
			ImGuiNative.ImFontGlyphRangesBuilder_SetBit(NativePtr, n);
		}

		/// <summary>
		/// Add character
		/// </summary>
		public void AddChar(ushort c)
		{
			ImGuiNative.ImFontGlyphRangesBuilder_AddChar(NativePtr, c);
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)
		/// </summary>
		public void AddText(ReadOnlySpan<char> text)
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

			byte* text_end = null;

			ImGuiNative.ImFontGlyphRangesBuilder_AddText(NativePtr, native_text, text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}
		/// <summary>
		/// Add string (each character of the UTF-8 string are added)
		/// </summary>
		public void AddText(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
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

			ImGuiNative.ImFontGlyphRangesBuilder_AddText(NativePtr, native_text, native_text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext
		/// </summary>
		public void AddRanges(IntPtr ranges)
		{
			// Marshaling 'ranges' to native ushort pointer
			ushort* native_ranges = (ushort*)ranges.ToPointer();

			ImGuiNative.ImFontGlyphRangesBuilder_AddRanges(NativePtr, native_ranges);
		}

		/// <summary>
		/// Output new ranges (ImVector_Construct()/ImVector_Destruct() can be used to safely construct out_ranges)
		/// </summary>
		public void BuildRanges(ImVector* out_ranges)
		{
			ImGuiNative.ImFontGlyphRangesBuilder_BuildRanges(NativePtr, out_ranges);
		}
	}
}
