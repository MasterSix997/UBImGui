using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Persistent storage for multi-select (as long as selection is alive)</para>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectState
	{
		public ImGuiWindow* Window;
		public uint ID;
		/// <summary>
		/// Last used frame-count, for GC.
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Set by BeginMultiSelect() based on optional info provided by user. May be -1 if unknown.
		/// </summary>
		public int LastSelectionSize;
		/// <summary>
		/// -1 (don't have) or true/false
		/// </summary>
		public sbyte RangeSelected;
		/// <summary>
		/// -1 (don't have) or true/false
		/// </summary>
		public sbyte NavIdSelected;
		/// <summary>
		/// //
		/// </summary>
		public long RangeSrcItem;
		/// <summary>
		/// SetNextItemSelectionUserData() value for NavId (if part of submitted items)
		/// </summary>
		public long NavIdItem;
	}

	/// <summary>
	/// <para>Persistent storage for multi-select (as long as selection is alive)</para>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectStatePtr
	{
		public ImGuiMultiSelectState* NativePtr { get; }
		public ImGuiMultiSelectStatePtr(ImGuiMultiSelectState* nativePtr) => NativePtr = nativePtr;
		public ImGuiMultiSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectState*)nativePtr;
		public static implicit operator ImGuiMultiSelectStatePtr(ImGuiMultiSelectState* nativePtr) => new ImGuiMultiSelectStatePtr(nativePtr);
		public static implicit operator ImGuiMultiSelectState* (ImGuiMultiSelectStatePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiMultiSelectStatePtr(IntPtr nativePtr) => new ImGuiMultiSelectStatePtr(nativePtr);

		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// Last used frame-count, for GC.
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);

		/// <summary>
		/// Set by BeginMultiSelect() based on optional info provided by user. May be -1 if unknown.
		/// </summary>
		public ref int LastSelectionSize => ref Unsafe.AsRef<int>(&NativePtr->LastSelectionSize);

		/// <summary>
		/// -1 (don't have) or true/false
		/// </summary>
		public ref sbyte RangeSelected => ref Unsafe.AsRef<sbyte>(&NativePtr->RangeSelected);

		/// <summary>
		/// -1 (don't have) or true/false
		/// </summary>
		public ref sbyte NavIdSelected => ref Unsafe.AsRef<sbyte>(&NativePtr->NavIdSelected);

		/// <summary>
		/// //
		/// </summary>
		public ref long RangeSrcItem => ref Unsafe.AsRef<long>(&NativePtr->RangeSrcItem);

		/// <summary>
		/// SetNextItemSelectionUserData() value for NavId (if part of submitted items)
		/// </summary>
		public ref long NavIdItem => ref Unsafe.AsRef<long>(&NativePtr->NavIdItem);
	}
}
