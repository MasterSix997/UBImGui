using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMouseWheel
	{
		public float WheelX;
		public float WheelY;
		public ImGuiMouseSource MouseSource;
	}

	public unsafe partial struct ImGuiInputEventMouseWheelPtr
	{
		public ImGuiInputEventMouseWheel* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventMouseWheel this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float WheelX => ref Unsafe.AsRef<float>(&NativePtr->WheelX);
		public ref float WheelY => ref Unsafe.AsRef<float>(&NativePtr->WheelY);
		public ref ImGuiMouseSource MouseSource => ref Unsafe.AsRef<ImGuiMouseSource>(&NativePtr->MouseSource);
		public ImGuiInputEventMouseWheelPtr(ImGuiInputEventMouseWheel* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventMouseWheelPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMouseWheel*)nativePtr;
		public static implicit operator ImGuiInputEventMouseWheelPtr(ImGuiInputEventMouseWheel* ptr) => new ImGuiInputEventMouseWheelPtr(ptr);
		public static implicit operator ImGuiInputEventMouseWheelPtr(IntPtr ptr) => new ImGuiInputEventMouseWheelPtr(ptr);
		public static implicit operator ImGuiInputEventMouseWheel*(ImGuiInputEventMouseWheelPtr nativePtr) => nativePtr.NativePtr;
	}
}
