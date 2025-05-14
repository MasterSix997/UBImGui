using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Persistent storage for multi-select (as long as selection is alive)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectState
	{
		public unsafe ImGuiWindow* Window;
		public uint ID;
		/// <summary>
		/// Last used frame-count, for GC.<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Set by BeginMultiSelect() based on optional info provided by user. May be -1 if unknown.<br/>
		/// </summary>
		public int LastSelectionSize;
		/// <summary>
		/// -1 (don't have) or true/false<br/>
		/// </summary>
		public sbyte RangeSelected;
		/// <summary>
		/// -1 (don't have) or true/false<br/>
		/// </summary>
		public sbyte NavIdSelected;
		/// <summary>
		/// //<br/>
		/// </summary>
		public long RangeSrcItem;
		/// <summary>
		/// SetNextItemSelectionUserData() value for NavId (if part of submitted items)<br/>
		/// </summary>
		public long NavIdItem;
	}

	/// <summary>
	/// Persistent storage for multi-select (as long as selection is alive)<br/>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectStatePtr
	{
		public ImGuiMultiSelectState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiMultiSelectState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// Last used frame-count, for GC.<br/>
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
		/// <summary>
		/// Set by BeginMultiSelect() based on optional info provided by user. May be -1 if unknown.<br/>
		/// </summary>
		public ref int LastSelectionSize => ref Unsafe.AsRef<int>(&NativePtr->LastSelectionSize);
		/// <summary>
		/// -1 (don't have) or true/false<br/>
		/// </summary>
		public ref sbyte RangeSelected => ref Unsafe.AsRef<sbyte>(&NativePtr->RangeSelected);
		/// <summary>
		/// -1 (don't have) or true/false<br/>
		/// </summary>
		public ref sbyte NavIdSelected => ref Unsafe.AsRef<sbyte>(&NativePtr->NavIdSelected);
		/// <summary>
		/// //<br/>
		/// </summary>
		public ref long RangeSrcItem => ref Unsafe.AsRef<long>(&NativePtr->RangeSrcItem);
		/// <summary>
		/// SetNextItemSelectionUserData() value for NavId (if part of submitted items)<br/>
		/// </summary>
		public ref long NavIdItem => ref Unsafe.AsRef<long>(&NativePtr->NavIdItem);
		public ImGuiMultiSelectStatePtr(ImGuiMultiSelectState* nativePtr) => NativePtr = nativePtr;
		public ImGuiMultiSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectState*)nativePtr;
		public static implicit operator ImGuiMultiSelectStatePtr(ImGuiMultiSelectState* ptr) => new ImGuiMultiSelectStatePtr(ptr);
		public static implicit operator ImGuiMultiSelectStatePtr(IntPtr ptr) => new ImGuiMultiSelectStatePtr(ptr);
		public static implicit operator ImGuiMultiSelectState*(ImGuiMultiSelectStatePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiMultiSelectStateDestroy(NativePtr);
		}

		public void ImGuiMultiSelectStateConstruct()
		{
			ImGuiNative.ImGuiMultiSelectStateImGuiMultiSelectStateConstruct(NativePtr);
		}

		public ImGuiMultiSelectStatePtr ImGuiMultiSelectState()
		{
			return ImGuiNative.ImGuiMultiSelectStateImGuiMultiSelectState();
		}

	}
}
