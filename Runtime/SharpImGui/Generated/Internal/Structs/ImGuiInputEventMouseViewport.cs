using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMouseViewport
	{
		public uint HoveredViewportID;
	}

	public unsafe partial struct ImGuiInputEventMouseViewportPtr
	{
		public ImGuiInputEventMouseViewport* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventMouseViewport this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint HoveredViewportID => ref Unsafe.AsRef<uint>(&NativePtr->HoveredViewportID);
		public ImGuiInputEventMouseViewportPtr(ImGuiInputEventMouseViewport* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventMouseViewportPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMouseViewport*)nativePtr;
		public static implicit operator ImGuiInputEventMouseViewportPtr(ImGuiInputEventMouseViewport* ptr) => new ImGuiInputEventMouseViewportPtr(ptr);
		public static implicit operator ImGuiInputEventMouseViewportPtr(IntPtr ptr) => new ImGuiInputEventMouseViewportPtr(ptr);
		public static implicit operator ImGuiInputEventMouseViewport*(ImGuiInputEventMouseViewportPtr nativePtr) => nativePtr.NativePtr;
	}
}
