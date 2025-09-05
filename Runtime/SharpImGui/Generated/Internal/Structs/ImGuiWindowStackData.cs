using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Data saved for each window pushed into the stack<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowStackData
	{
		public unsafe ImGuiWindow* Window;
		public ImGuiLastItemData ParentLastItemDataBackup;
		/// <summary>
		/// Store size of various stacks for asserting<br/>
		/// </summary>
		public ImGuiErrorRecoveryState StackSizesInBegin;
		/// <summary>
		/// Non-child window override disabled flag<br/>
		/// </summary>
		public byte DisabledOverrideReenable;
		public float DisabledOverrideReenableAlphaBackup;
	}

	/// <summary>
	/// Data saved for each window pushed into the stack<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowStackDataPtr
	{
		public ImGuiWindowStackData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindowStackData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		public ref ImGuiLastItemData ParentLastItemDataBackup => ref Unsafe.AsRef<ImGuiLastItemData>(&NativePtr->ParentLastItemDataBackup);
		/// <summary>
		/// Store size of various stacks for asserting<br/>
		/// </summary>
		public ref ImGuiErrorRecoveryState StackSizesInBegin => ref Unsafe.AsRef<ImGuiErrorRecoveryState>(&NativePtr->StackSizesInBegin);
		/// <summary>
		/// Non-child window override disabled flag<br/>
		/// </summary>
		public ref bool DisabledOverrideReenable => ref Unsafe.AsRef<bool>(&NativePtr->DisabledOverrideReenable);
		public ref float DisabledOverrideReenableAlphaBackup => ref Unsafe.AsRef<float>(&NativePtr->DisabledOverrideReenableAlphaBackup);
		public ImGuiWindowStackDataPtr(ImGuiWindowStackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowStackData*)nativePtr;
		public static implicit operator ImGuiWindowStackDataPtr(ImGuiWindowStackData* ptr) => new ImGuiWindowStackDataPtr(ptr);
		public static implicit operator ImGuiWindowStackDataPtr(IntPtr ptr) => new ImGuiWindowStackDataPtr(ptr);
		public static implicit operator ImGuiWindowStackData*(ImGuiWindowStackDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
