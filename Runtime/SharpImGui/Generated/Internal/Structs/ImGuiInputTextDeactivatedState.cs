using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Internal temporary state for deactivating InputText() instances.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextDeactivatedState
	{
		/// <summary>
		/// widget id owning the text state (which just got deactivated)<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// text buffer<br/>
		/// </summary>
		public ImVector<byte> TextA;
	}

	/// <summary>
	/// Internal temporary state for deactivating InputText() instances.<br/>
	/// </summary>
	public unsafe partial struct ImGuiInputTextDeactivatedStatePtr
	{
		public ImGuiInputTextDeactivatedState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputTextDeactivatedState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// widget id owning the text state (which just got deactivated)<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// text buffer<br/>
		/// </summary>
		public ref ImVector<byte> TextA => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->TextA);
		public ImGuiInputTextDeactivatedStatePtr(ImGuiInputTextDeactivatedState* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextDeactivatedStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextDeactivatedState*)nativePtr;
		public static implicit operator ImGuiInputTextDeactivatedStatePtr(ImGuiInputTextDeactivatedState* ptr) => new ImGuiInputTextDeactivatedStatePtr(ptr);
		public static implicit operator ImGuiInputTextDeactivatedStatePtr(IntPtr ptr) => new ImGuiInputTextDeactivatedStatePtr(ptr);
		public static implicit operator ImGuiInputTextDeactivatedState*(ImGuiInputTextDeactivatedStatePtr nativePtr) => nativePtr.NativePtr;
		public void ClearFreeMemory()
		{
			ImGuiNative.ImGuiInputTextDeactivatedStateClearFreeMemory(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiInputTextDeactivatedStateDestroy(NativePtr);
		}

		public void ImGuiInputTextDeactivatedStateConstruct()
		{
			ImGuiNative.ImGuiInputTextDeactivatedStateImGuiInputTextDeactivatedStateConstruct(NativePtr);
		}

		public ImGuiInputTextDeactivatedStatePtr ImGuiInputTextDeactivatedState()
		{
			return ImGuiNative.ImGuiInputTextDeactivatedStateImGuiInputTextDeactivatedState();
		}

	}
}
