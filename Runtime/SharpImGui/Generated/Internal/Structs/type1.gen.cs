using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct type1
	{
		public fixed int BackupInt[2];
		public fixed float BackupFloat[2];
	}

	public unsafe partial struct type1Ptr
	{
		public type1* NativePtr { get; }
		public type1Ptr(type1* nativePtr) => NativePtr = nativePtr;
		public type1Ptr(IntPtr nativePtr) => NativePtr = (type1*)nativePtr;
		public static implicit operator type1Ptr(type1* nativePtr) => new type1Ptr(nativePtr);
		public static implicit operator type1* (type1Ptr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator type1Ptr(IntPtr nativePtr) => new type1Ptr(nativePtr);

		public RangeAccessor<int> BackupInt => new RangeAccessor<int>(NativePtr->BackupInt, 2);

		public RangeAccessor<float> BackupFloat => new RangeAccessor<float>(NativePtr->BackupFloat, 2);
	}
}
