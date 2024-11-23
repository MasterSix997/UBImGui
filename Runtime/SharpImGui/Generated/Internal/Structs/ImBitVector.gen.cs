using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Helper: ImBitVector</para>
	/// <para>Store 1-bit per value.</para>
	/// </summary>
	public unsafe partial struct ImBitVector
	{
		public ImVector Storage;
	}

	/// <summary>
	/// <para>Helper: ImBitVector</para>
	/// <para>Store 1-bit per value.</para>
	/// </summary>
	public unsafe partial struct ImBitVectorPtr
	{
		public ImBitVector* NativePtr { get; }
		public ImBitVectorPtr(ImBitVector* nativePtr) => NativePtr = nativePtr;
		public ImBitVectorPtr(IntPtr nativePtr) => NativePtr = (ImBitVector*)nativePtr;
		public static implicit operator ImBitVectorPtr(ImBitVector* nativePtr) => new ImBitVectorPtr(nativePtr);
		public static implicit operator ImBitVector* (ImBitVectorPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImBitVectorPtr(IntPtr nativePtr) => new ImBitVectorPtr(nativePtr);

		public ImVector<uint> Storage => new ImVector<uint>(NativePtr->Storage);

		public void Create(int sz)
		{
			ImGuiInternalNative.ImBitVector_Create(NativePtr, sz);
		}

		public void Clear()
		{
			ImGuiInternalNative.ImBitVector_Clear(NativePtr);
		}

		public bool TestBit(int n)
		{
			var ret = ImGuiInternalNative.ImBitVector_TestBit(NativePtr, n);
			return ret != 0;
		}

		public void SetBit(int n)
		{
			ImGuiInternalNative.ImBitVector_SetBit(NativePtr, n);
		}

		public void ClearBit(int n)
		{
			ImGuiInternalNative.ImBitVector_ClearBit(NativePtr, n);
		}
	}
}
