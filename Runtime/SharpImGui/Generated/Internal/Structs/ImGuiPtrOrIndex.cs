using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPtrOrIndex
	{
		/// <summary>
		/// Either field can be set, not both. e.g. Dock node tab bars are loose while BeginTabBar() ones are in a pool.<br/>
		/// </summary>
		public unsafe void* Ptr;
		/// <summary>
		/// Usually index in a main pool.<br/>
		/// </summary>
		public int Index;
	}

	public unsafe partial struct ImGuiPtrOrIndexPtr
	{
		public ImGuiPtrOrIndex* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPtrOrIndex this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Either field can be set, not both. e.g. Dock node tab bars are loose while BeginTabBar() ones are in a pool.<br/>
		/// </summary>
		public IntPtr Ptr { get => (IntPtr)NativePtr->Ptr; set => NativePtr->Ptr = (void*)value; }
		/// <summary>
		/// Usually index in a main pool.<br/>
		/// </summary>
		public ref int Index => ref Unsafe.AsRef<int>(&NativePtr->Index);
		public ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* nativePtr) => NativePtr = nativePtr;
		public ImGuiPtrOrIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiPtrOrIndex*)nativePtr;
		public static implicit operator ImGuiPtrOrIndexPtr(ImGuiPtrOrIndex* ptr) => new ImGuiPtrOrIndexPtr(ptr);
		public static implicit operator ImGuiPtrOrIndexPtr(IntPtr ptr) => new ImGuiPtrOrIndexPtr(ptr);
		public static implicit operator ImGuiPtrOrIndex*(ImGuiPtrOrIndexPtr nativePtr) => nativePtr.NativePtr;
		public void ImGuiPtrOrIndexIntConstruct(int index)
		{
			ImGuiNative.ImGuiPtrOrIndexImGuiPtrOrIndexIntConstruct(NativePtr, index);
		}

		public ImGuiPtrOrIndexPtr ImGuiPtrOrIndex(int index)
		{
			return ImGuiNative.ImGuiPtrOrIndexImGuiPtrOrIndex(index);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiPtrOrIndexDestroy(NativePtr);
		}

		public void ImGuiPtrOrIndexPtrConstruct(IntPtr ptr)
		{
			ImGuiNative.ImGuiPtrOrIndexImGuiPtrOrIndexPtrConstruct(NativePtr, (void*)ptr);
		}

		public ImGuiPtrOrIndexPtr ImGuiPtrOrIndex(IntPtr ptr)
		{
			return ImGuiNative.ImGuiPtrOrIndexImGuiPtrOrIndex((void*)ptr);
		}

	}
}
