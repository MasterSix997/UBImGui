using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>This extends ImGuiKeyData but only for named keys (legacy keys don't support the new features)</para>
	/// <para>Stored in main context (1 per named key). In the future it might be merged into ImGuiKeyData.</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyOwnerData
	{
		public uint OwnerCurr;
		public uint OwnerNext;
		/// <summary>
		/// Reading this key requires explicit owner id (until end of frame). Set by ImGuiInputFlags_LockThisFrame.
		/// </summary>
		public byte LockThisFrame;
		/// <summary>
		/// Reading this key requires explicit owner id (until key is released). Set by ImGuiInputFlags_LockUntilRelease. When this is true LockThisFrame is always true as well.
		/// </summary>
		public byte LockUntilRelease;
	}

	/// <summary>
	/// <para>This extends ImGuiKeyData but only for named keys (legacy keys don't support the new features)</para>
	/// <para>Stored in main context (1 per named key). In the future it might be merged into ImGuiKeyData.</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyOwnerDataPtr
	{
		public ImGuiKeyOwnerData* NativePtr { get; }
		public ImGuiKeyOwnerDataPtr(ImGuiKeyOwnerData* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyOwnerDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyOwnerData*)nativePtr;
		public static implicit operator ImGuiKeyOwnerDataPtr(ImGuiKeyOwnerData* nativePtr) => new ImGuiKeyOwnerDataPtr(nativePtr);
		public static implicit operator ImGuiKeyOwnerData* (ImGuiKeyOwnerDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiKeyOwnerDataPtr(IntPtr nativePtr) => new ImGuiKeyOwnerDataPtr(nativePtr);

		public ref uint OwnerCurr => ref Unsafe.AsRef<uint>(&NativePtr->OwnerCurr);

		public ref uint OwnerNext => ref Unsafe.AsRef<uint>(&NativePtr->OwnerNext);

		/// <summary>
		/// Reading this key requires explicit owner id (until end of frame). Set by ImGuiInputFlags_LockThisFrame.
		/// </summary>
		public ref bool LockThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->LockThisFrame);

		/// <summary>
		/// Reading this key requires explicit owner id (until key is released). Set by ImGuiInputFlags_LockUntilRelease. When this is true LockThisFrame is always true as well.
		/// </summary>
		public ref bool LockUntilRelease => ref Unsafe.AsRef<bool>(&NativePtr->LockUntilRelease);
	}
}
