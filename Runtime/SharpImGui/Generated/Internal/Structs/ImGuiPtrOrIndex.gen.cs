using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiPtrOrIndex
	{
		/// <summary>
		/// Either field can be set, not both. e.g. Dock node tab bars are loose while BeginTabBar() ones are in a pool.
		/// </summary>
		public void* Ptr;
		/// <summary>
		/// Usually index in a main pool.
		/// </summary>
		public int Index;
	}

	public unsafe partial struct ImGuiPtrOrIndexPtr
	{
		public ImGuiPtrOrIndex* NativePtr { get; }
		public ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => NativePtr = nativePtr;
		public ImGuiPtrOrIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiPtrOrIndex*)nativePtr;
		public static implicit operator ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => new ImGuiPtrOrIndexPtr(nativePtr);
		public static implicit operator ImGuiPtrOrIndex* (ImGuiPtrOrIndexPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiPtrOrIndexPtr(IntPtr nativePtr) => new ImGuiPtrOrIndexPtr(nativePtr);

		/// <summary>
		/// Either field can be set, not both. e.g. Dock node tab bars are loose while BeginTabBar() ones are in a pool.
		/// </summary>
		public IntPtr Ptr { get => (IntPtr)NativePtr->Ptr; set => NativePtr->Ptr = (void*)value; }

		/// <summary>
		/// Usually index in a main pool.
		/// </summary>
		public ref int Index => ref Unsafe.AsRef<int>(&NativePtr->Index);
	}
}
