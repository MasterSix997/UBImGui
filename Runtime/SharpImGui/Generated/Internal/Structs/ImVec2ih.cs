using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImVec2ih (2D vector, half-size integer, for long-term packed storage)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec2Ih
	{
		public short X;
		public short Y;
	}

	/// <summary>
	/// Helper: ImVec2ih (2D vector, half-size integer, for long-term packed storage)<br/>
	/// </summary>
	public unsafe partial struct ImVec2IhPtr
	{
		public ImVec2Ih* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec2Ih this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref short X => ref Unsafe.AsRef<short>(&NativePtr->X);
		public ref short Y => ref Unsafe.AsRef<short>(&NativePtr->Y);
		public ImVec2IhPtr(ImVec2Ih* nativePtr) => NativePtr = nativePtr;
		public ImVec2IhPtr(IntPtr nativePtr) => NativePtr = (ImVec2Ih*)nativePtr;
		public static implicit operator ImVec2IhPtr(ImVec2Ih* ptr) => new ImVec2IhPtr(ptr);
		public static implicit operator ImVec2IhPtr(IntPtr ptr) => new ImVec2IhPtr(ptr);
		public static implicit operator ImVec2Ih*(ImVec2IhPtr nativePtr) => nativePtr.NativePtr;
	}
}
