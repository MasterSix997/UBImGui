using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImBitArrayForNamedKeys
	{
		public fixed byte __dummy[20];
	}

	public unsafe partial struct ImBitArrayForNamedKeysPtr
	{
		public ImBitArrayForNamedKeys* NativePtr { get; }
		public ImBitArrayForNamedKeysPtr(ImBitArrayForNamedKeys* nativePtr) => NativePtr = nativePtr;
		public ImBitArrayForNamedKeysPtr(IntPtr nativePtr) => NativePtr = (ImBitArrayForNamedKeys*)nativePtr;
		public static implicit operator ImBitArrayForNamedKeysPtr(ImBitArrayForNamedKeys* nativePtr) => new ImBitArrayForNamedKeysPtr(nativePtr);
		public static implicit operator ImBitArrayForNamedKeys* (ImBitArrayForNamedKeysPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImBitArrayForNamedKeysPtr(IntPtr nativePtr) => new ImBitArrayForNamedKeysPtr(nativePtr);

		public RangeAccessor<byte> __dummy => new RangeAccessor<byte>(NativePtr->__dummy, 20);
	}
}
