using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiInputEventText
	{
		public uint Char;
	}

	public unsafe partial struct ImGuiInputEventTextPtr
	{
		public ImGuiInputEventText* NativePtr { get; }
		public ImGuiInputEventTextPtr(ImGuiInputEventText* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventTextPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventText*)nativePtr;
		public static implicit operator ImGuiInputEventTextPtr(ImGuiInputEventText* nativePtr) => new ImGuiInputEventTextPtr(nativePtr);
		public static implicit operator ImGuiInputEventText* (ImGuiInputEventTextPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiInputEventTextPtr(IntPtr nativePtr) => new ImGuiInputEventTextPtr(nativePtr);

		public ref uint Char => ref Unsafe.AsRef<uint>(&NativePtr->Char);
	}
}
