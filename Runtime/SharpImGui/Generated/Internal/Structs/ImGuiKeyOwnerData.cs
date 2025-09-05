using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// This extends ImGuiKeyData but only for named keys (legacy keys don't support the new features)<br/>Stored in main context (1 per named key). In the future it might be merged into ImGuiKeyData.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyOwnerData
	{
		public uint OwnerCurr;
		public uint OwnerNext;
		/// <summary>
		/// Reading this key requires explicit owner id (until end of frame). Set by ImGuiInputFlags_LockThisFrame.<br/>
		/// </summary>
		public byte LockThisFrame;
		/// <summary>
		/// Reading this key requires explicit owner id (until key is released). Set by ImGuiInputFlags_LockUntilRelease. When this is true LockThisFrame is always true as well.<br/>
		/// </summary>
		public byte LockUntilRelease;
	}

	/// <summary>
	/// This extends ImGuiKeyData but only for named keys (legacy keys don't support the new features)<br/>Stored in main context (1 per named key). In the future it might be merged into ImGuiKeyData.<br/>
	/// </summary>
	public unsafe partial struct ImGuiKeyOwnerDataPtr
	{
		public ImGuiKeyOwnerData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiKeyOwnerData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint OwnerCurr => ref Unsafe.AsRef<uint>(&NativePtr->OwnerCurr);
		public ref uint OwnerNext => ref Unsafe.AsRef<uint>(&NativePtr->OwnerNext);
		/// <summary>
		/// Reading this key requires explicit owner id (until end of frame). Set by ImGuiInputFlags_LockThisFrame.<br/>
		/// </summary>
		public ref bool LockThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->LockThisFrame);
		/// <summary>
		/// Reading this key requires explicit owner id (until key is released). Set by ImGuiInputFlags_LockUntilRelease. When this is true LockThisFrame is always true as well.<br/>
		/// </summary>
		public ref bool LockUntilRelease => ref Unsafe.AsRef<bool>(&NativePtr->LockUntilRelease);
		public ImGuiKeyOwnerDataPtr(ImGuiKeyOwnerData* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyOwnerDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyOwnerData*)nativePtr;
		public static implicit operator ImGuiKeyOwnerDataPtr(ImGuiKeyOwnerData* ptr) => new ImGuiKeyOwnerDataPtr(ptr);
		public static implicit operator ImGuiKeyOwnerDataPtr(IntPtr ptr) => new ImGuiKeyOwnerDataPtr(ptr);
		public static implicit operator ImGuiKeyOwnerData*(ImGuiKeyOwnerDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiKeyOwnerDataDestroy(NativePtr);
		}

		public void ImGuiKeyOwnerDataConstruct()
		{
			ImGuiNative.ImGuiKeyOwnerDataImGuiKeyOwnerDataConstruct(NativePtr);
		}

		public ImGuiKeyOwnerDataPtr ImGuiKeyOwnerData()
		{
			return ImGuiNative.ImGuiKeyOwnerDataImGuiKeyOwnerData();
		}

	}
}
