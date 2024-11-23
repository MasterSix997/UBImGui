using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	public unsafe partial struct type0
	{
		public int val_i;
		public float val_f;
		public void* val_p;
	}

	public unsafe partial struct type0Ptr
	{
		public type0* NativePtr { get; }
		public type0Ptr(type0* nativePtr) => NativePtr = nativePtr;
		public type0Ptr(IntPtr nativePtr) => NativePtr = (type0*)nativePtr;
		public static implicit operator type0Ptr(type0* nativePtr) => new type0Ptr(nativePtr);
		public static implicit operator type0* (type0Ptr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator type0Ptr(IntPtr nativePtr) => new type0Ptr(nativePtr);

		public ref int val_i => ref Unsafe.AsRef<int>(&NativePtr->val_i);

		public ref float val_f => ref Unsafe.AsRef<float>(&NativePtr->val_f);

		public IntPtr val_p { get => (IntPtr)NativePtr->val_p; set => NativePtr->val_p = (void*)value; }
	}
}
