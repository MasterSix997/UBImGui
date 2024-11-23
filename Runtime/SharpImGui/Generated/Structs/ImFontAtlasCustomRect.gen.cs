using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>See ImFontAtlas::AddCustomRectXXX functions.</para>
	/// </summary>
	public unsafe partial struct ImFontAtlasCustomRect
	{
		/// <summary>
		/// Output   // Packed position in Atlas
		/// </summary>
		public ushort X;
		/// <summary>
		/// Output   // Packed position in Atlas
		/// </summary>
		public ushort Y;
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Input    // Desired rectangle dimension
		/// </summary>
		public ushort Width;
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Input    // Desired rectangle dimension
		/// </summary>
		public ushort Height;
		/// <summary>
		/// Input    // For custom font glyphs only (ID &lt; 0x110000)
		/// </summary>
		public uint GlyphID;
		/// <summary>
		/// Input  // For custom font glyphs only: glyph is colored, removed tinting.
		/// </summary>
		public uint GlyphColored;
		/// <summary>
		/// Input    // For custom font glyphs only: glyph xadvance
		/// </summary>
		public float GlyphAdvanceX;
		/// <summary>
		/// Input    // For custom font glyphs only: glyph display offset
		/// </summary>
		public Vector2 GlyphOffset;
		/// <summary>
		/// Input    // For custom font glyphs only: target font
		/// </summary>
		public ImFont* Font;
	}

	/// <summary>
	/// <para>See ImFontAtlas::AddCustomRectXXX functions.</para>
	/// </summary>
	public unsafe partial struct ImFontAtlasCustomRectPtr
	{
		public ImFontAtlasCustomRect* NativePtr { get; }
		public ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => NativePtr = nativePtr;
		public ImFontAtlasCustomRectPtr(IntPtr nativePtr) => NativePtr = (ImFontAtlasCustomRect*)nativePtr;
		public static implicit operator ImFontAtlasCustomRectPtr(ImFontAtlasCustomRect* nativePtr) => new ImFontAtlasCustomRectPtr(nativePtr);
		public static implicit operator ImFontAtlasCustomRect* (ImFontAtlasCustomRectPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontAtlasCustomRectPtr(IntPtr nativePtr) => new ImFontAtlasCustomRectPtr(nativePtr);

		/// <summary>
		/// Output   // Packed position in Atlas
		/// </summary>
		public ref ushort X => ref Unsafe.AsRef<ushort>(&NativePtr->X);

		/// <summary>
		/// Output   // Packed position in Atlas
		/// </summary>
		public ref ushort Y => ref Unsafe.AsRef<ushort>(&NativePtr->Y);

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Input    // Desired rectangle dimension
		/// </summary>
		public ref ushort Width => ref Unsafe.AsRef<ushort>(&NativePtr->Width);

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Input    // Desired rectangle dimension
		/// </summary>
		public ref ushort Height => ref Unsafe.AsRef<ushort>(&NativePtr->Height);

		/// <summary>
		/// Input    // For custom font glyphs only (ID &lt; 0x110000)
		/// </summary>
		public ref uint GlyphID => ref Unsafe.AsRef<uint>(&NativePtr->GlyphID);

		/// <summary>
		/// Input  // For custom font glyphs only: glyph is colored, removed tinting.
		/// </summary>
		public ref uint GlyphColored => ref Unsafe.AsRef<uint>(&NativePtr->GlyphColored);

		/// <summary>
		/// Input    // For custom font glyphs only: glyph xadvance
		/// </summary>
		public ref float GlyphAdvanceX => ref Unsafe.AsRef<float>(&NativePtr->GlyphAdvanceX);

		/// <summary>
		/// Input    // For custom font glyphs only: glyph display offset
		/// </summary>
		public ref Vector2 GlyphOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->GlyphOffset);

		/// <summary>
		/// Input    // For custom font glyphs only: target font
		/// </summary>
		public ImFontPtr Font => new ImFontPtr(NativePtr->Font);

		public bool IsPacked()
		{
			var ret = ImGuiNative.ImFontAtlasCustomRect_IsPacked(NativePtr);
			return ret != 0;
		}
	}
}
