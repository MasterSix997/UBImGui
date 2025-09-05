using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextDeactivateData
	{
	}

	public unsafe partial struct ImGuiInputTextDeactivateDataPtr
	{
		public ImGuiInputTextDeactivateData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputTextDeactivateData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiInputTextDeactivateDataPtr(ImGuiInputTextDeactivateData* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextDeactivateDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextDeactivateData*)nativePtr;
		public static implicit operator ImGuiInputTextDeactivateDataPtr(ImGuiInputTextDeactivateData* ptr) => new ImGuiInputTextDeactivateDataPtr(ptr);
		public static implicit operator ImGuiInputTextDeactivateDataPtr(IntPtr ptr) => new ImGuiInputTextDeactivateDataPtr(ptr);
		public static implicit operator ImGuiInputTextDeactivateData*(ImGuiInputTextDeactivateDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
