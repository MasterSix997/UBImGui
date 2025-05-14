using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawVert
	{
		public Vector2 Pos;
		public Vector2 Uv;
		public uint Col;
	}

	public unsafe partial struct ImDrawVertPtr
	{
		public ImDrawVert* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawVert this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
		public ref Vector2 Uv => ref Unsafe.AsRef<Vector2>(&NativePtr->Uv);
		public ref uint Col => ref Unsafe.AsRef<uint>(&NativePtr->Col);
		public ImDrawVertPtr(ImDrawVert* nativePtr) => NativePtr = nativePtr;
		public ImDrawVertPtr(IntPtr nativePtr) => NativePtr = (ImDrawVert*)nativePtr;
		public static implicit operator ImDrawVertPtr(ImDrawVert* ptr) => new ImDrawVertPtr(ptr);
		public static implicit operator ImDrawVertPtr(IntPtr ptr) => new ImDrawVertPtr(ptr);
		public static implicit operator ImDrawVert*(ImDrawVertPtr nativePtr) => nativePtr.NativePtr;
	}
}
