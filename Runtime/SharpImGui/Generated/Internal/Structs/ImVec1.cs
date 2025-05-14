using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec1
	{
		public float X;
	}

	public unsafe partial struct ImVec1Ptr
	{
		public ImVec1* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec1 this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float X => ref Unsafe.AsRef<float>(&NativePtr->X);
		public ImVec1Ptr(ImVec1* nativePtr) => NativePtr = nativePtr;
		public ImVec1Ptr(IntPtr nativePtr) => NativePtr = (ImVec1*)nativePtr;
		public static implicit operator ImVec1Ptr(ImVec1* ptr) => new ImVec1Ptr(ptr);
		public static implicit operator ImVec1Ptr(IntPtr ptr) => new ImVec1Ptr(ptr);
		public static implicit operator ImVec1*(ImVec1Ptr nativePtr) => nativePtr.NativePtr;
		public void ImVec1FloatConstruct(float x)
		{
			ImGuiNative.ImVec1ImVec1FloatConstruct(NativePtr, x);
		}

		public ImVec1Ptr ImVec1(float x)
		{
			return ImGuiNative.ImVec1ImVec1(x);
		}

		public void Destroy()
		{
			ImGuiNative.ImVec1Destroy(NativePtr);
		}

		public void ImVec1NilConstruct()
		{
			ImGuiNative.ImVec1ImVec1NilConstruct(NativePtr);
		}

		public ImVec1Ptr ImVec1()
		{
			return ImGuiNative.ImVec1ImVec1();
		}

	}
}
