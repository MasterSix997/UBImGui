using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Hold rendering data for one glyph.</para>
	/// <para>(Note: some language parsers may fail to convert the 31+1 bitfield members, in this case maybe drop store a single u32 or we can rework this)</para>
	/// </summary>
	public unsafe partial struct ImFontGlyph
	{
		/// <summary>
		/// Flag to indicate glyph is colored and should generally ignore tinting (make it usable with no shift on little-endian as this is used in loops)
		/// </summary>
		public uint Colored;
		/// <summary>
		/// Flag to indicate glyph has no visible pixels (e.g. space). Allow early out when rendering.
		/// </summary>
		public uint Visible;
		/// <summary>
		/// 0x0000..0x10FFFF
		/// </summary>
		public uint Codepoint;
		/// <summary>
		/// Distance to next character (= data from font + ImFontConfig::GlyphExtraSpacing.x baked in)
		/// </summary>
		public float AdvanceX;
		/// <summary>
		/// Glyph corners
		/// </summary>
		public float X0;
		/// <summary>
		/// Glyph corners
		/// </summary>
		public float Y0;
		/// <summary>
		/// Glyph corners
		/// </summary>
		public float X1;
		/// <summary>
		/// Glyph corners
		/// </summary>
		public float Y1;
		/// <summary>
		/// Texture coordinates
		/// </summary>
		public float U0;
		/// <summary>
		/// Texture coordinates
		/// </summary>
		public float V0;
		/// <summary>
		/// Texture coordinates
		/// </summary>
		public float U1;
		/// <summary>
		/// Texture coordinates
		/// </summary>
		public float V1;
	}

	/// <summary>
	/// <para>Hold rendering data for one glyph.</para>
	/// <para>(Note: some language parsers may fail to convert the 31+1 bitfield members, in this case maybe drop store a single u32 or we can rework this)</para>
	/// </summary>
	public unsafe partial struct ImFontGlyphPtr
	{
		public ImFontGlyph* NativePtr { get; }
		public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
		public static implicit operator ImFontGlyphPtr(ImFontGlyph* nativePtr) => new ImFontGlyphPtr(nativePtr);
		public static implicit operator ImFontGlyph* (ImFontGlyphPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontGlyphPtr(IntPtr nativePtr) => new ImFontGlyphPtr(nativePtr);

		/// <summary>
		/// Flag to indicate glyph is colored and should generally ignore tinting (make it usable with no shift on little-endian as this is used in loops)
		/// </summary>
		public ref uint Colored => ref Unsafe.AsRef<uint>(&NativePtr->Colored);

		/// <summary>
		/// Flag to indicate glyph has no visible pixels (e.g. space). Allow early out when rendering.
		/// </summary>
		public ref uint Visible => ref Unsafe.AsRef<uint>(&NativePtr->Visible);

		/// <summary>
		/// 0x0000..0x10FFFF
		/// </summary>
		public ref uint Codepoint => ref Unsafe.AsRef<uint>(&NativePtr->Codepoint);

		/// <summary>
		/// Distance to next character (= data from font + ImFontConfig::GlyphExtraSpacing.x baked in)
		/// </summary>
		public ref float AdvanceX => ref Unsafe.AsRef<float>(&NativePtr->AdvanceX);

		/// <summary>
		/// Glyph corners
		/// </summary>
		public ref float X0 => ref Unsafe.AsRef<float>(&NativePtr->X0);

		/// <summary>
		/// Glyph corners
		/// </summary>
		public ref float Y0 => ref Unsafe.AsRef<float>(&NativePtr->Y0);

		/// <summary>
		/// Glyph corners
		/// </summary>
		public ref float X1 => ref Unsafe.AsRef<float>(&NativePtr->X1);

		/// <summary>
		/// Glyph corners
		/// </summary>
		public ref float Y1 => ref Unsafe.AsRef<float>(&NativePtr->Y1);

		/// <summary>
		/// Texture coordinates
		/// </summary>
		public ref float U0 => ref Unsafe.AsRef<float>(&NativePtr->U0);

		/// <summary>
		/// Texture coordinates
		/// </summary>
		public ref float V0 => ref Unsafe.AsRef<float>(&NativePtr->V0);

		/// <summary>
		/// Texture coordinates
		/// </summary>
		public ref float U1 => ref Unsafe.AsRef<float>(&NativePtr->U1);

		/// <summary>
		/// Texture coordinates
		/// </summary>
		public ref float V1 => ref Unsafe.AsRef<float>(&NativePtr->V1);
	}
}
