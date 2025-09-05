using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// See ImFontAtlas::AddCustomRectXXX functions.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontAtlasCustomRect
	{
		/// <summary>
		/// Output   Packed position in Atlas<br/>
		/// </summary>
		public ushort X;
		/// <summary>
		/// Output   Packed position in Atlas<br/>
		/// </summary>
		public ushort Y;
		/// <summary>
		///     [Internal]<br/>
		/// Input    Desired rectangle dimension<br/>
		/// </summary>
		public ushort Width;
		/// <summary>
		///     [Internal]<br/>
		/// Input    Desired rectangle dimension<br/>
		/// </summary>
		public ushort Height;
		/// <summary>
		/// Input    For custom font glyphs only (ID &lt; 0x110000)<br/>
		/// </summary>
		public uint GlyphID;
		/// <summary>
		/// Input  For custom font glyphs only: glyph is colored, removed tinting.<br/>
		/// </summary>
		public uint GlyphColored;
		/// <summary>
		/// Input    For custom font glyphs only: glyph xadvance<br/>
		/// </summary>
		public float GlyphAdvanceX;
		/// <summary>
		/// Input    For custom font glyphs only: glyph display offset<br/>
		/// </summary>
		public Vector2 GlyphOffset;
		/// <summary>
		/// Input    For custom font glyphs only: target font<br/>
		/// </summary>
		public unsafe ImFont* Font;
	}

	/// <summary>
	/// See ImFontAtlas::AddCustomRectXXX functions.<br/>
	/// </summary>
	public unsafe partial struct ImFontAtlasCustomRectPtr
	{
		public ImFontAtlasCustomRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontAtlasCustomRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Output   Packed position in Atlas<br/>
		/// </summary>
		public ref ushort X => ref Unsafe.AsRef<ushort>(&NativePtr->X);
		/// <summary>
		/// Output   Packed position in Atlas<br/>
		/// </summary>
		public ref ushort Y => ref Unsafe.AsRef<ushort>(&NativePtr->Y);
		/// <summary>
		///     [Internal]<br/>
		/// Input    Desired rectangle dimension<br/>
		/// </summary>
		public ref ushort Width => ref Unsafe.AsRef<ushort>(&NativePtr->Width);
		/// <summary>
		///     [Internal]<br/>
		/// Input    Desired rectangle dimension<br/>
		/// </summary>
		public ref ushort Height => ref Unsafe.AsRef<ushort>(&NativePtr->Height);
		/// <summary>
		/// Input    For custom font glyphs only (ID &lt; 0x110000)<br/>
		/// </summary>
		public ref uint GlyphID => ref Unsafe.AsRef<uint>(&NativePtr->GlyphID);
		/// <summary>
		/// Input  For custom font glyphs only: glyph is colored, removed tinting.<br/>
		/// </summary>
		public ref uint GlyphColored => ref Unsafe.AsRef<uint>(&NativePtr->GlyphColored);
		/// <summary>
		/// Input    For custom font glyphs only: glyph xadvance<br/>
		/// </summary>
		public ref float GlyphAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphAdvanceX);
		/// <summary>
		/// Input    For custom font glyphs only: glyph display offset<br/>
		/// </summary>
		public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);
		/// <summary>
		/// Input    For custom font glyphs only: target font<br/>
		/// </summary>
		public ref ImFontPtr Font => ref Unsafe.AsRef<ImFontPtr>(&NativePtr->Font);
		public ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => NativePtr = nativePtr;
		public ImFontAtlasCustomRectPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasCustomRect*)nativePtr;
		public static implicit operator ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* ptr) => new ImFontAtlasCustomRectPtr(ptr);
		public static implicit operator ImFontAtlasCustomRectPtr(IntPtr ptr) => new ImFontAtlasCustomRectPtr(ptr);
		public static implicit operator ImFontAtlasCustomRect*(ImFontAtlasCustomRectPtr nativePtr) => nativePtr.NativePtr;
		public bool IsPacked()
		{
			var result = ImGuiNative.ImFontAtlasCustomRectIsPacked(NativePtr);
			return result != 0;
		}

		public void Destroy()
		{
			ImGuiNative.ImFontAtlasCustomRectDestroy(NativePtr);
		}

		public void ImFontAtlasCustomRectConstruct()
		{
			ImGuiNative.ImFontAtlasCustomRectImFontAtlasCustomRectConstruct(NativePtr);
		}

		public ImFontAtlasCustomRectPtr ImFontAtlasCustomRect()
		{
			return ImGuiNative.ImFontAtlasCustomRectImFontAtlasCustomRect();
		}

	}
}
