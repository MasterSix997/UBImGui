using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiLocEntry
	{
		public ImGuiLocKey Key;
		public unsafe byte* Text;
	}

	public unsafe partial struct ImGuiLocEntryPtr
	{
		public ImGuiLocEntry* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiLocEntry this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiLocKey Key => ref Unsafe.AsRef<ImGuiLocKey>(&NativePtr->Key);
		public IntPtr Text { get => (IntPtr)NativePtr->Text; set => NativePtr->Text = (byte*)value; }
		public ImGuiLocEntryPtr(ImGuiLocEntry* nativePtr) => NativePtr = nativePtr;
		public ImGuiLocEntryPtr(IntPtr nativePtr) => NativePtr = (ImGuiLocEntry*)nativePtr;
		public static implicit operator ImGuiLocEntryPtr(ImGuiLocEntry* ptr) => new ImGuiLocEntryPtr(ptr);
		public static implicit operator ImGuiLocEntryPtr(IntPtr ptr) => new ImGuiLocEntryPtr(ptr);
		public static implicit operator ImGuiLocEntry*(ImGuiLocEntryPtr nativePtr) => nativePtr.NativePtr;
	}
}
