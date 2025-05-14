using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// [Internal] Key+Value for ImGuiStorage<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStoragePair
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiStoragePairUnion
		{
			[FieldOffset(0)]
			public int val_i;
			[FieldOffset(0)]
			public float val_f;
			[FieldOffset(0)]
			public unsafe void* val_p;
		}
		public uint Key;
		public ImGuiStoragePairUnion Union;
	}

	/// <summary>
	/// [Internal] Key+Value for ImGuiStorage<br/>
	/// </summary>
	public unsafe partial struct ImGuiStoragePairPtr
	{
		public ImGuiStoragePair* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStoragePair this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint Key => ref Unsafe.AsRef<uint>(&NativePtr->Key);
		public ref ImGuiStoragePair.ImGuiStoragePairUnion Union => ref Unsafe.AsRef<ImGuiStoragePair.ImGuiStoragePairUnion>(&NativePtr->Union);
		public ImGuiStoragePairPtr(ImGuiStoragePair* nativePtr) => NativePtr = nativePtr;
		public ImGuiStoragePairPtr(IntPtr nativePtr) => NativePtr = (ImGuiStoragePair*)nativePtr;
		public static implicit operator ImGuiStoragePairPtr(ImGuiStoragePair* ptr) => new ImGuiStoragePairPtr(ptr);
		public static implicit operator ImGuiStoragePairPtr(IntPtr ptr) => new ImGuiStoragePairPtr(ptr);
		public static implicit operator ImGuiStoragePair*(ImGuiStoragePairPtr nativePtr) => nativePtr.NativePtr;
		public void ImGuiStoragePairPtrConstruct(uint key, IntPtr val)
		{
			ImGuiNative.ImGuiStoragePairImGuiStoragePairPtrConstruct(NativePtr, key, (void*)val);
		}

		public ImGuiStoragePairPtr ImGuiStoragePair(uint key, IntPtr val)
		{
			return ImGuiNative.ImGuiStoragePairImGuiStoragePair(key, (void*)val);
		}

		public void ImGuiStoragePairFloatConstruct(uint key, float val)
		{
			ImGuiNative.ImGuiStoragePairImGuiStoragePairFloatConstruct(NativePtr, key, val);
		}

		public ImGuiStoragePairPtr ImGuiStoragePair(uint key, float val)
		{
			return ImGuiNative.ImGuiStoragePairImGuiStoragePair(key, val);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiStoragePairDestroy(NativePtr);
		}

		public void ImGuiStoragePairIntConstruct(uint key, int val)
		{
			ImGuiNative.ImGuiStoragePairImGuiStoragePairIntConstruct(NativePtr, key, val);
		}

		public ImGuiStoragePairPtr ImGuiStoragePair(uint key, int val)
		{
			return ImGuiNative.ImGuiStoragePairImGuiStoragePair(key, val);
		}

	}
}
