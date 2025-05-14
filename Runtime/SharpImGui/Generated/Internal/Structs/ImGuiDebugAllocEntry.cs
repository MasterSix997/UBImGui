using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDebugAllocEntry
	{
		public int FrameCount;
		public short AllocCount;
		public short FreeCount;
	}

	public unsafe partial struct ImGuiDebugAllocEntryPtr
	{
		public ImGuiDebugAllocEntry* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDebugAllocEntry this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref int FrameCount => ref Unsafe.AsRef<int>(&NativePtr->FrameCount);
		public ref short AllocCount => ref Unsafe.AsRef<short>(&NativePtr->AllocCount);
		public ref short FreeCount => ref Unsafe.AsRef<short>(&NativePtr->FreeCount);
		public ImGuiDebugAllocEntryPtr(ImGuiDebugAllocEntry* nativePtr) => NativePtr = nativePtr;
		public ImGuiDebugAllocEntryPtr(IntPtr nativePtr) => NativePtr = (ImGuiDebugAllocEntry*)nativePtr;
		public static implicit operator ImGuiDebugAllocEntryPtr(ImGuiDebugAllocEntry* ptr) => new ImGuiDebugAllocEntryPtr(ptr);
		public static implicit operator ImGuiDebugAllocEntryPtr(IntPtr ptr) => new ImGuiDebugAllocEntryPtr(ptr);
		public static implicit operator ImGuiDebugAllocEntry*(ImGuiDebugAllocEntryPtr nativePtr) => nativePtr.NativePtr;
	}
}
