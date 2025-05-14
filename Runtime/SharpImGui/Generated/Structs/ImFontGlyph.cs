using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Hold rendering data for one glyph.<br/>(Note: some language parsers may fail to convert the 31+1 bitfield members, in this case maybe drop store a single u32 or we can rework this)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontGlyph
	{
		/// <summary>
		/// Flag to indicate glyph is colored and should generally ignore tinting (make it usable with no shift on little-endian as this is used in loops)<br/>
		/// </summary>
		public uint Colored;
		/// <summary>
		/// Flag to indicate glyph has no visible pixels (e.g. space). Allow early out when rendering.<br/>
		/// </summary>
		public uint Visible;
		/// <summary>
		/// 0x0000..0x10FFFF<br/>
		/// </summary>
		public uint Codepoint;
		/// <summary>
		/// Horizontal distance to advance layout with<br/>
		/// </summary>
		public float AdvanceX;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float X0;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float Y0;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float X1;
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public float Y1;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float U0;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float V0;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float U1;
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public float V1;
	}

	/// <summary>
	/// Hold rendering data for one glyph.<br/>(Note: some language parsers may fail to convert the 31+1 bitfield members, in this case maybe drop store a single u32 or we can rework this)<br/>
	/// </summary>
	public unsafe partial struct ImFontGlyphPtr
	{
		public ImFontGlyph* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontGlyph this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Flag to indicate glyph is colored and should generally ignore tinting (make it usable with no shift on little-endian as this is used in loops)<br/>
		/// </summary>
		public ref uint Colored => ref Unsafe.AsRef<uint>(&NativePtr->Colored);
		/// <summary>
		/// Flag to indicate glyph has no visible pixels (e.g. space). Allow early out when rendering.<br/>
		/// </summary>
		public ref uint Visible => ref Unsafe.AsRef<uint>(&NativePtr->Visible);
		/// <summary>
		/// 0x0000..0x10FFFF<br/>
		/// </summary>
		public ref uint Codepoint => ref Unsafe.AsRef<uint>(&NativePtr->Codepoint);
		/// <summary>
		/// Horizontal distance to advance layout with<br/>
		/// </summary>
		public ref float AdvanceX => ref Unsafe.AsRef<float>(&NativePtr->AdvanceX);
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public ref float X0 => ref Unsafe.AsRef<float>(&NativePtr->X0);
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public ref float Y0 => ref Unsafe.AsRef<float>(&NativePtr->Y0);
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public ref float X1 => ref Unsafe.AsRef<float>(&NativePtr->X1);
		/// <summary>
		/// Glyph corners<br/>
		/// </summary>
		public ref float Y1 => ref Unsafe.AsRef<float>(&NativePtr->Y1);
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public ref float U0 => ref Unsafe.AsRef<float>(&NativePtr->U0);
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public ref float V0 => ref Unsafe.AsRef<float>(&NativePtr->V0);
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public ref float U1 => ref Unsafe.AsRef<float>(&NativePtr->U1);
		/// <summary>
		/// Texture coordinates<br/>
		/// </summary>
		public ref float V1 => ref Unsafe.AsRef<float>(&NativePtr->V1);
		public ImFontGlyphPtr(ImFontGlyph* nativePtr) => NativePtr = nativePtr;
		public ImFontGlyphPtr(IntPtr nativePtr) => NativePtr = (ImFontGlyph*)nativePtr;
		public static implicit operator ImFontGlyphPtr(ImFontGlyph* ptr) => new ImFontGlyphPtr(ptr);
		public static implicit operator ImFontGlyphPtr(IntPtr ptr) => new ImFontGlyphPtr(ptr);
		public static implicit operator ImFontGlyph*(ImFontGlyphPtr nativePtr) => nativePtr.NativePtr;
	}
}
