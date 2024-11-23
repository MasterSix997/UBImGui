using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiShrinkWidthItem
	{
		public int Index;
		public float Width;
		public float InitialWidth;
	}

	public unsafe partial struct ImGuiShrinkWidthItemPtr
	{
		public ImGuiShrinkWidthItem* NativePtr { get; }
		public ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => NativePtr = nativePtr;
		public ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiShrinkWidthItem*)nativePtr;
		public static implicit operator ImGuiShrinkWidthItemPtr(ImGuiShrinkWidthItem* nativePtr) => new ImGuiShrinkWidthItemPtr(nativePtr);
		public static implicit operator ImGuiShrinkWidthItem* (ImGuiShrinkWidthItemPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiShrinkWidthItemPtr(IntPtr nativePtr) => new ImGuiShrinkWidthItemPtr(nativePtr);

		public ref int Index => ref Unsafe.AsRef<int>(&NativePtr->Index);

		public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);

		public ref float InitialWidth => ref Unsafe.AsRef<float>(&NativePtr->InitialWidth);
	}
}
