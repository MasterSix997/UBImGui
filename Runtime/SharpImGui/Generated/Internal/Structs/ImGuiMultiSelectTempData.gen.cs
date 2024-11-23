using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Temporary storage for multi-select</para>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectTempData
	{
		/// <summary>
		/// MUST BE FIRST FIELD. Requests are set and returned by BeginMultiSelect()/EndMultiSelect() + written to by user during the loop.
		/// </summary>
		public ImGuiMultiSelectIO IO;
		public ImGuiMultiSelectState* Storage;
		/// <summary>
		/// Copied from g.CurrentFocusScopeId (unless another selection scope was pushed manually)
		/// </summary>
		public uint FocusScopeId;
		public ImGuiMultiSelectFlags Flags;
		public Vector2 ScopeRectMin;
		public Vector2 BackupCursorMaxPos;
		/// <summary>
		/// Copy of last submitted item data, used to merge output ranges.
		/// </summary>
		public long LastSubmittedItem;
		public uint BoxSelectId;
		public ImGuiKey KeyMods;
		/// <summary>
		/// -1: no operation, 0: clear all, 1: select all.
		/// </summary>
		public sbyte LoopRequestSetAll;
		/// <summary>
		/// Set when switching IO from BeginMultiSelect() to EndMultiSelect() state.
		/// </summary>
		public byte IsEndIO;
		/// <summary>
		/// Set if currently focusing the selection scope (any item of the selection). May be used if you have custom shortcut associated to selection.
		/// </summary>
		public byte IsFocused;
		/// <summary>
		/// Set by BeginMultiSelect() when using Shift+Navigation. Because scrolling may be affected we can't afford a frame of lag with Shift+Navigation.
		/// </summary>
		public byte IsKeyboardSetRange;
		public byte NavIdPassedBy;
		/// <summary>
		/// Set by the item that matches RangeSrcItem.
		/// </summary>
		public byte RangeSrcPassedBy;
		/// <summary>
		/// Set by the item that matches NavJustMovedToId when IsSetRange is set.
		/// </summary>
		public byte RangeDstPassedBy;
	}

	/// <summary>
	/// <para>Temporary storage for multi-select</para>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectTempDataPtr
	{
		public ImGuiMultiSelectTempData* NativePtr { get; }
		public ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* nativePtr) => NativePtr = nativePtr;
		public ImGuiMultiSelectTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectTempData*)nativePtr;
		public static implicit operator ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* nativePtr) => new ImGuiMultiSelectTempDataPtr(nativePtr);
		public static implicit operator ImGuiMultiSelectTempData* (ImGuiMultiSelectTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiMultiSelectTempDataPtr(IntPtr nativePtr) => new ImGuiMultiSelectTempDataPtr(nativePtr);

		/// <summary>
		/// MUST BE FIRST FIELD. Requests are set and returned by BeginMultiSelect()/EndMultiSelect() + written to by user during the loop.
		/// </summary>
		public ref ImGuiMultiSelectIO IO => ref Unsafe.AsRef<ImGuiMultiSelectIO>(&NativePtr->IO);

		public ImGuiMultiSelectStatePtr Storage => new ImGuiMultiSelectStatePtr(NativePtr->Storage);

		/// <summary>
		/// Copied from g.CurrentFocusScopeId (unless another selection scope was pushed manually)
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);

		public ref ImGuiMultiSelectFlags Flags => ref Unsafe.AsRef<ImGuiMultiSelectFlags>(&NativePtr->Flags);

		public ref Vector2 ScopeRectMin => ref Unsafe.AsRef<Vector2>(&NativePtr->ScopeRectMin);

		public ref Vector2 BackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorMaxPos);

		/// <summary>
		/// Copy of last submitted item data, used to merge output ranges.
		/// </summary>
		public ref long LastSubmittedItem => ref Unsafe.AsRef<long>(&NativePtr->LastSubmittedItem);

		public ref uint BoxSelectId => ref Unsafe.AsRef<uint>(&NativePtr->BoxSelectId);

		public ref ImGuiKey KeyMods => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->KeyMods);

		/// <summary>
		/// -1: no operation, 0: clear all, 1: select all.
		/// </summary>
		public ref sbyte LoopRequestSetAll => ref Unsafe.AsRef<sbyte>(&NativePtr->LoopRequestSetAll);

		/// <summary>
		/// Set when switching IO from BeginMultiSelect() to EndMultiSelect() state.
		/// </summary>
		public ref bool IsEndIO => ref Unsafe.AsRef<bool>(&NativePtr->IsEndIO);

		/// <summary>
		/// Set if currently focusing the selection scope (any item of the selection). May be used if you have custom shortcut associated to selection.
		/// </summary>
		public ref bool IsFocused => ref Unsafe.AsRef<bool>(&NativePtr->IsFocused);

		/// <summary>
		/// Set by BeginMultiSelect() when using Shift+Navigation. Because scrolling may be affected we can't afford a frame of lag with Shift+Navigation.
		/// </summary>
		public ref bool IsKeyboardSetRange => ref Unsafe.AsRef<bool>(&NativePtr->IsKeyboardSetRange);

		public ref bool NavIdPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->NavIdPassedBy);

		/// <summary>
		/// Set by the item that matches RangeSrcItem.
		/// </summary>
		public ref bool RangeSrcPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->RangeSrcPassedBy);

		/// <summary>
		/// Set by the item that matches NavJustMovedToId when IsSetRange is set.
		/// </summary>
		public ref bool RangeDstPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->RangeDstPassedBy);

		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.
		/// </summary>
		public void Clear()
		{
			ImGuiInternalNative.ImGuiMultiSelectTempData_Clear(NativePtr);
		}

		public void ClearIO()
		{
			ImGuiInternalNative.ImGuiMultiSelectTempData_ClearIO(NativePtr);
		}
	}
}
