using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMouseButton
	{
		public int Button;
		public byte Down;
		public ImGuiMouseSource MouseSource;
	}

	public unsafe partial struct ImGuiInputEventMouseButtonPtr
	{
		public ImGuiInputEventMouseButton* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventMouseButton this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref int Button => ref Unsafe.AsRef<int>(&NativePtr->Button);
		public ref bool Down => ref Unsafe.AsRef<bool>(&NativePtr->Down);
		public ref ImGuiMouseSource MouseSource => ref Unsafe.AsRef<ImGuiMouseSource>(&NativePtr->MouseSource);
		public ImGuiInputEventMouseButtonPtr(ImGuiInputEventMouseButton* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventMouseButtonPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMouseButton*)nativePtr;
		public static implicit operator ImGuiInputEventMouseButtonPtr(ImGuiInputEventMouseButton* ptr) => new ImGuiInputEventMouseButtonPtr(ptr);
		public static implicit operator ImGuiInputEventMouseButtonPtr(IntPtr ptr) => new ImGuiInputEventMouseButtonPtr(ptr);
		public static implicit operator ImGuiInputEventMouseButton*(ImGuiInputEventMouseButtonPtr nativePtr) => nativePtr.NativePtr;
	}
}
