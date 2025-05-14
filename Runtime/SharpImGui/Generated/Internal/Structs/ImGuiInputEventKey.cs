using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventKey
	{
		public ImGuiKey Key;
		public byte Down;
		public float AnalogValue;
	}

	public unsafe partial struct ImGuiInputEventKeyPtr
	{
		public ImGuiInputEventKey* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventKey this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiKey Key => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->Key);
		public ref bool Down => ref Unsafe.AsRef<bool>(&NativePtr->Down);
		public ref float AnalogValue => ref Unsafe.AsRef<float>(&NativePtr->AnalogValue);
		public ImGuiInputEventKeyPtr(ImGuiInputEventKey* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventKeyPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventKey*)nativePtr;
		public static implicit operator ImGuiInputEventKeyPtr(ImGuiInputEventKey* ptr) => new ImGuiInputEventKeyPtr(ptr);
		public static implicit operator ImGuiInputEventKeyPtr(IntPtr ptr) => new ImGuiInputEventKeyPtr(ptr);
		public static implicit operator ImGuiInputEventKey*(ImGuiInputEventKeyPtr nativePtr) => nativePtr.NativePtr;
	}
}
