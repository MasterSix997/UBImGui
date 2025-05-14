using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec2
	{
		public float X;
		public float Y;
	}

	public unsafe partial struct ImVec2Ptr
	{
		public ImVec2* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec2 this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float X => ref Unsafe.AsRef<float>(&NativePtr->X);
		public ref float Y => ref Unsafe.AsRef<float>(&NativePtr->Y);
		public ImVec2Ptr(ImVec2* nativePtr) => NativePtr = nativePtr;
		public ImVec2Ptr(IntPtr nativePtr) => NativePtr = (ImVec2*)nativePtr;
		public static implicit operator ImVec2Ptr(ImVec2* ptr) => new ImVec2Ptr(ptr);
		public static implicit operator ImVec2Ptr(IntPtr ptr) => new ImVec2Ptr(ptr);
		public static implicit operator ImVec2*(ImVec2Ptr nativePtr) => nativePtr.NativePtr;
		public void ImVec2FloatConstruct(ref Vector2 self, float x, float y)
		{
			fixed (Vector2* nativeSelf = &self)
			{
				ImGuiNative.ImVec2ImVec2FloatConstruct(nativeSelf, x, y);
			}
		}

		public ref Vector2 ImVec2(float x, float y)
		{
			var nativeResult = ImGuiNative.ImVec2ImVec2(x, y);
			return ref *(Vector2*)&nativeResult;
		}

		public void Destroy(ref Vector2 self)
		{
			fixed (Vector2* nativeSelf = &self)
			{
				ImGuiNative.ImVec2Destroy(nativeSelf);
			}
		}

		public void ImVec2NilConstruct(ref Vector2 self)
		{
			fixed (Vector2* nativeSelf = &self)
			{
				ImGuiNative.ImVec2ImVec2NilConstruct(nativeSelf);
			}
		}

		public ref Vector2 ImVec2()
		{
			var nativeResult = ImGuiNative.ImVec2ImVec2();
			return ref *(Vector2*)&nativeResult;
		}

	}
}
