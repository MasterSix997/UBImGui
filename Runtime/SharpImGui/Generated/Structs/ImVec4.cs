using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// ImVec4: 4D vector used to store clipping rectangles, colors etc. [Compile-time configurable type]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImVec4
	{
		public float X;
		public float Y;
		public float Z;
		public float W;
	}

	/// <summary>
	/// ImVec4: 4D vector used to store clipping rectangles, colors etc. [Compile-time configurable type]<br/>
	/// </summary>
	public unsafe partial struct ImVec4Ptr
	{
		public ImVec4* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImVec4 this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float X => ref Unsafe.AsRef<float>(&NativePtr->X);
		public ref float Y => ref Unsafe.AsRef<float>(&NativePtr->Y);
		public ref float Z => ref Unsafe.AsRef<float>(&NativePtr->Z);
		public ref float W => ref Unsafe.AsRef<float>(&NativePtr->W);
		public ImVec4Ptr(ImVec4* nativePtr) => NativePtr = nativePtr;
		public ImVec4Ptr(IntPtr nativePtr) => NativePtr = (ImVec4*)nativePtr;
		public static implicit operator ImVec4Ptr(ImVec4* ptr) => new ImVec4Ptr(ptr);
		public static implicit operator ImVec4Ptr(IntPtr ptr) => new ImVec4Ptr(ptr);
		public static implicit operator ImVec4*(ImVec4Ptr nativePtr) => nativePtr.NativePtr;
		public void ImVec4FloatConstruct(ref Vector4 self, float x, float y, float z, float w)
		{
			fixed (Vector4* nativeSelf = &self)
			{
				ImGuiNative.ImVec4ImVec4FloatConstruct(nativeSelf, x, y, z, w);
			}
		}

		public ref Vector4 ImVec4(float x, float y, float z, float w)
		{
			var nativeResult = ImGuiNative.ImVec4ImVec4(x, y, z, w);
			return ref *(Vector4*)&nativeResult;
		}

		public void Destroy(ref Vector4 self)
		{
			fixed (Vector4* nativeSelf = &self)
			{
				ImGuiNative.ImVec4Destroy(nativeSelf);
			}
		}

		public void ImVec4NilConstruct(ref Vector4 self)
		{
			fixed (Vector4* nativeSelf = &self)
			{
				ImGuiNative.ImVec4ImVec4NilConstruct(nativeSelf);
			}
		}

		public ref Vector4 ImVec4()
		{
			var nativeResult = ImGuiNative.ImVec4ImVec4();
			return ref *(Vector4*)&nativeResult;
		}

	}
}
