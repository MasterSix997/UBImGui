using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().<br/>This is essentially a tightly packed of vector of 64k booleans = 8KB storage.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyphRangesBuilder
	{
		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)<br/>
		/// </summary>
		public ImVector<uint> UsedChars;
	}

	/// <summary>
	/// Helper to build glyph ranges from text/string data. Feed your application strings/characters to it then call BuildRanges().<br/>This is essentially a tightly packed of vector of 64k booleans = 8KB storage.<br/>
	/// </summary>
	public unsafe partial struct ImFontGlyphRangesBuilderPtr
	{
		public ImFontGlyphRangesBuilder* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontGlyphRangesBuilder this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Store 1-bit per Unicode code point (0=unused, 1=used)<br/>
		/// </summary>
		public ref ImVector<uint> UsedChars => ref Unsafe.AsRef<ImVector<uint>>(&NativePtr->UsedChars);
		public ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphRangesBuilderPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyphRangesBuilder*)nativePtr;
		public static implicit operator ImFontGlyphRangesBuilderPtr(ImFontGlyphRangesBuilder* ptr) => new ImFontGlyphRangesBuilderPtr(ptr);
		public static implicit operator ImFontGlyphRangesBuilderPtr(IntPtr ptr) => new ImFontGlyphRangesBuilderPtr(ptr);
		public static implicit operator ImFontGlyphRangesBuilder*(ImFontGlyphRangesBuilderPtr nativePtr) => nativePtr.NativePtr;
		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		public void BuildRanges(out ImVector<ushort> outRanges)
		{
			fixed (ImVector<ushort>* nativeOutRanges = &outRanges)
			{
				ImGuiNative.ImFontGlyphRangesBuilderBuildRanges(NativePtr, nativeOutRanges);
			}
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		public void AddRanges(ushort[] ranges)
		{
			fixed (ushort* nativeRanges = ranges)
			{
				ImGuiNative.ImFontGlyphRangesBuilderAddRanges(NativePtr, nativeRanges);
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public void AddText(ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImFontGlyphRangesBuilderAddText(NativePtr, nativeText, nativeTextEnd);
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public void AddText(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
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

			ImGuiNative.ImFontGlyphRangesBuilderAddText(NativePtr, nativeText, nativeTextEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public void AddText(ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				ImGuiNative.ImFontGlyphRangesBuilderAddText(NativePtr, nativeText, textEnd);
			}
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		public void AddText(ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
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

			ImGuiNative.ImFontGlyphRangesBuilderAddText(NativePtr, nativeText, textEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		/// <summary>
		/// Add character<br/>
		/// </summary>
		public void AddChar(ushort c)
		{
			ImGuiNative.ImFontGlyphRangesBuilderAddChar(NativePtr, c);
		}

		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		public void SetBit(uint n)
		{
			ImGuiNative.ImFontGlyphRangesBuilderSetBit(NativePtr, n);
		}

		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		public bool GetBit(uint n)
		{
			var result = ImGuiNative.ImFontGlyphRangesBuilderGetBit(NativePtr, n);
			return result != 0;
		}

		public void Clear()
		{
			ImGuiNative.ImFontGlyphRangesBuilderClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImFontGlyphRangesBuilderDestroy(NativePtr);
		}

		public void ImFontGlyphRangesBuilderConstruct()
		{
			ImGuiNative.ImFontGlyphRangesBuilderImFontGlyphRangesBuilderConstruct(NativePtr);
		}

		public ImFontGlyphRangesBuilderPtr ImFontGlyphRangesBuilder()
		{
			return ImGuiNative.ImFontGlyphRangesBuilderImFontGlyphRangesBuilder();
		}

	}
}
