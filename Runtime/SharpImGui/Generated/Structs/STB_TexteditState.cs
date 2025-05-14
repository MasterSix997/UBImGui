using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct STBTexteditState
	{
	}

	public unsafe partial struct STBTexteditStatePtr
	{
		public STBTexteditState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public STBTexteditState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public STBTexteditStatePtr(STBTexteditState* nativePtr) => NativePtr = nativePtr;
		public STBTexteditStatePtr(IntPtr nativePtr) => NativePtr = (STBTexteditState*)nativePtr;
		public static implicit operator STBTexteditStatePtr(STBTexteditState* ptr) => new STBTexteditStatePtr(ptr);
		public static implicit operator STBTexteditStatePtr(IntPtr ptr) => new STBTexteditStatePtr(ptr);
		public static implicit operator STBTexteditState*(STBTexteditStatePtr nativePtr) => nativePtr.NativePtr;
	}
}
