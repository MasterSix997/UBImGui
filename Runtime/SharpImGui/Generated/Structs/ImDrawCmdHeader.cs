using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <br/>[Internal] For use by ImDrawList<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawCmdHeader
	{
		public Vector4 ClipRect;
		public ulong TextureId;
		public uint VtxOffset;
	}

	/// <summary>
	/// <br/>[Internal] For use by ImDrawList<br/>
	/// </summary>
	public unsafe partial struct ImDrawCmdHeaderPtr
	{
		public ImDrawCmdHeader* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawCmdHeader this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref Vector4 ClipRect => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRect);
		public ref ulong TextureId => ref Unsafe.AsRef<ulong>(&NativePtr->TextureId);
		public ref uint VtxOffset => ref Unsafe.AsRef<uint>(&NativePtr->VtxOffset);
		public ImDrawCmdHeaderPtr(ImDrawCmdHeader* nativePtr) => NativePtr = nativePtr;
		public ImDrawCmdHeaderPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmdHeader*)nativePtr;
		public static implicit operator ImDrawCmdHeaderPtr(ImDrawCmdHeader* ptr) => new ImDrawCmdHeaderPtr(ptr);
		public static implicit operator ImDrawCmdHeaderPtr(IntPtr ptr) => new ImDrawCmdHeaderPtr(ptr);
		public static implicit operator ImDrawCmdHeader*(ImDrawCmdHeaderPtr nativePtr) => nativePtr.NativePtr;
	}
}
