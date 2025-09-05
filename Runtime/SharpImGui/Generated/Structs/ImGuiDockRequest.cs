using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockRequest
	{
	}

	public unsafe partial struct ImGuiDockRequestPtr
	{
		public ImGuiDockRequest* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDockRequest this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiDockRequestPtr(ImGuiDockRequest* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockRequest*)nativePtr;
		public static implicit operator ImGuiDockRequestPtr(ImGuiDockRequest* ptr) => new ImGuiDockRequestPtr(ptr);
		public static implicit operator ImGuiDockRequestPtr(IntPtr ptr) => new ImGuiDockRequestPtr(ptr);
		public static implicit operator ImGuiDockRequest*(ImGuiDockRequestPtr nativePtr) => nativePtr.NativePtr;
	}
}
