using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImBitVector<br/>Store 1-bit per value.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImBitVector
	{
		public ImVector<uint> Storage;
	}

	/// <summary>
	/// Helper: ImBitVector<br/>Store 1-bit per value.<br/>
	/// </summary>
	public unsafe partial struct ImBitVectorPtr
	{
		public ImBitVector* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImBitVector this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<uint> Storage => ref Unsafe.AsRef<ImVector<uint>>(&NativePtr->Storage);
		public ImBitVectorPtr(ImBitVector* nativePtr) => NativePtr = nativePtr;
		public ImBitVectorPtr(IntPtr nativePtr) => NativePtr = (ImBitVector*)nativePtr;
		public static implicit operator ImBitVectorPtr(ImBitVector* ptr) => new ImBitVectorPtr(ptr);
		public static implicit operator ImBitVectorPtr(IntPtr ptr) => new ImBitVectorPtr(ptr);
		public static implicit operator ImBitVector*(ImBitVectorPtr nativePtr) => nativePtr.NativePtr;
		public void ClearBit(int n)
		{
			ImGuiNative.ImBitVectorClearBit(NativePtr, n);
		}

		public void SetBit(int n)
		{
			ImGuiNative.ImBitVectorSetBit(NativePtr, n);
		}

		public bool TestBit(int n)
		{
			var result = ImGuiNative.ImBitVectorTestBit(NativePtr, n);
			return result != 0;
		}

		public void Clear()
		{
			ImGuiNative.ImBitVectorClear(NativePtr);
		}

		public void Create(int sz)
		{
			ImGuiNative.ImBitVectorCreate(NativePtr, sz);
		}

	}
}
