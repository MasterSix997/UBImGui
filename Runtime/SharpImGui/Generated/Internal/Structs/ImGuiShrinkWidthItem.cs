using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiShrinkWidthItem
	{
		public int Index;
		public float Width;
		public float InitialWidth;
	}

	public unsafe partial struct ImGuiShrinkWidthItemPtr
	{
		public ImGuiShrinkWidthItem* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiShrinkWidthItem this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref int Index => ref Unsafe.AsRef<int>(&NativePtr->Index);
		public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
		public ref float InitialWidth => ref Unsafe.AsRef<float>(&NativePtr->InitialWidth);
		public ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => NativePtr = nativePtr;
		public ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiShrinkWidthItem*)nativePtr;
		public static implicit operator ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* ptr) => new ImGuiShrinkWidthItemPtr(ptr);
		public static implicit operator ImGuiShrinkWidthItemPtr(IntPtr ptr) => new ImGuiShrinkWidthItemPtr(ptr);
		public static implicit operator ImGuiShrinkWidthItem*(ImGuiShrinkWidthItemPtr nativePtr) => nativePtr.NativePtr;
	}
}
