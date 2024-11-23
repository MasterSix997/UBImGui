using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Data saved for each window pushed into the stack</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowStackData
	{
		public ImGuiWindow* Window;
		public ImGuiLastItemData ParentLastItemDataBackup;
		/// <summary>
		/// Store size of various stacks for asserting
		/// </summary>
		public ImGuiErrorRecoveryState StackSizesInBegin;
		/// <summary>
		/// Non-child window override disabled flag
		/// </summary>
		public byte DisabledOverrideReenable;
	}

	/// <summary>
	/// <para>Data saved for each window pushed into the stack</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowStackDataPtr
	{
		public ImGuiWindowStackData* NativePtr { get; }
		public ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowStackData*)nativePtr;
		public static implicit operator ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => new ImGuiWindowStackDataPtr(nativePtr);
		public static implicit operator ImGuiWindowStackData* (ImGuiWindowStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiWindowStackDataPtr(IntPtr nativePtr) => new ImGuiWindowStackDataPtr(nativePtr);

		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		public ref ImGuiLastItemData ParentLastItemDataBackup => ref Unsafe.AsRef<ImGuiLastItemData>(&NativePtr->ParentLastItemDataBackup);

		/// <summary>
		/// Store size of various stacks for asserting
		/// </summary>
		public ref ImGuiErrorRecoveryState StackSizesInBegin => ref Unsafe.AsRef<ImGuiErrorRecoveryState>(&NativePtr->StackSizesInBegin);

		/// <summary>
		/// Non-child window override disabled flag
		/// </summary>
		public ref bool DisabledOverrideReenable => ref Unsafe.AsRef<bool>(&NativePtr->DisabledOverrideReenable);
	}
}
