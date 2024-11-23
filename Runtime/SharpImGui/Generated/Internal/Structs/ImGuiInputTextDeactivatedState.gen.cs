using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Internal temporary state for deactivating InputText() instances.</para>
	/// </summary>
	public unsafe partial struct ImGuiInputTextDeactivatedState
	{
		/// <summary>
		/// widget id owning the text state (which just got deactivated)
		/// </summary>
		public uint ID;
		/// <summary>
		/// text buffer
		/// </summary>
		public ImVector TextA;
	}

	/// <summary>
	/// <para>Internal temporary state for deactivating InputText() instances.</para>
	/// </summary>
	public unsafe partial struct ImGuiInputTextDeactivatedStatePtr
	{
		public ImGuiInputTextDeactivatedState* NativePtr { get; }
		public ImGuiInputTextDeactivatedStatePtr(ImGuiInputTextDeactivatedState* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextDeactivatedStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextDeactivatedState*)nativePtr;
		public static implicit operator ImGuiInputTextDeactivatedStatePtr(ImGuiInputTextDeactivatedState* nativePtr) => new ImGuiInputTextDeactivatedStatePtr(nativePtr);
		public static implicit operator ImGuiInputTextDeactivatedState* (ImGuiInputTextDeactivatedStatePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiInputTextDeactivatedStatePtr(IntPtr nativePtr) => new ImGuiInputTextDeactivatedStatePtr(nativePtr);

		/// <summary>
		/// widget id owning the text state (which just got deactivated)
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// text buffer
		/// </summary>
		public ImVector<byte> TextA => new ImVector<byte>(NativePtr->TextA);

		public void ClearFreeMemory()
		{
			ImGuiInternalNative.ImGuiInputTextDeactivatedState_ClearFreeMemory(NativePtr);
		}
	}
}
