using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventText
	{
		public uint Char;
	}

	public unsafe partial struct ImGuiInputEventTextPtr
	{
		public ImGuiInputEventText* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventText this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint Char => ref Unsafe.AsRef<uint>(&NativePtr->Char);
		public ImGuiInputEventTextPtr(ImGuiInputEventText* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventTextPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventText*)nativePtr;
		public static implicit operator ImGuiInputEventTextPtr(ImGuiInputEventText* ptr) => new ImGuiInputEventTextPtr(ptr);
		public static implicit operator ImGuiInputEventTextPtr(IntPtr ptr) => new ImGuiInputEventTextPtr(ptr);
		public static implicit operator ImGuiInputEventText*(ImGuiInputEventTextPtr nativePtr) => nativePtr.NativePtr;
	}
}
