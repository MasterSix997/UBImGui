using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Temporary storage for multi-select<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectTempData
	{
		/// <summary>
		/// MUST BE FIRST FIELD. Requests are set and returned by BeginMultiSelect()/EndMultiSelect() + written to by user during the loop.<br/>
		/// </summary>
		public ImGuiMultiSelectIO IO;
		public unsafe ImGuiMultiSelectState* Storage;
		/// <summary>
		/// Copied from g.CurrentFocusScopeId (unless another selection scope was pushed manually)<br/>
		/// </summary>
		public uint FocusScopeId;
		public ImGuiMultiSelectFlags Flags;
		public Vector2 ScopeRectMin;
		public Vector2 BackupCursorMaxPos;
		/// <summary>
		/// Copy of last submitted item data, used to merge output ranges.<br/>
		/// </summary>
		public long LastSubmittedItem;
		public uint BoxSelectId;
		public int KeyMods;
		/// <summary>
		/// -1: no operation, 0: clear all, 1: select all.<br/>
		/// </summary>
		public sbyte LoopRequestSetAll;
		/// <summary>
		/// Set when switching IO from BeginMultiSelect() to EndMultiSelect() state.<br/>
		/// </summary>
		public byte IsEndIO;
		/// <summary>
		/// Set if currently focusing the selection scope (any item of the selection). May be used if you have custom shortcut associated to selection.<br/>
		/// </summary>
		public byte IsFocused;
		/// <summary>
		/// Set by BeginMultiSelect() when using Shift+Navigation. Because scrolling may be affected we can't afford a frame of lag with Shift+Navigation.<br/>
		/// </summary>
		public byte IsKeyboardSetRange;
		public byte NavIdPassedBy;
		/// <summary>
		/// Set by the item that matches RangeSrcItem.<br/>
		/// </summary>
		public byte RangeSrcPassedBy;
		/// <summary>
		/// Set by the item that matches NavJustMovedToId when IsSetRange is set.<br/>
		/// </summary>
		public byte RangeDstPassedBy;
	}

	/// <summary>
	/// Temporary storage for multi-select<br/>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectTempDataPtr
	{
		public ImGuiMultiSelectTempData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiMultiSelectTempData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// MUST BE FIRST FIELD. Requests are set and returned by BeginMultiSelect()/EndMultiSelect() + written to by user during the loop.<br/>
		/// </summary>
		public ref ImGuiMultiSelectIO IO => ref Unsafe.AsRef<ImGuiMultiSelectIO>(&NativePtr->IO);
		public ref ImGuiMultiSelectStatePtr Storage => ref Unsafe.AsRef<ImGuiMultiSelectStatePtr>(&NativePtr->Storage);
		/// <summary>
		/// Copied from g.CurrentFocusScopeId (unless another selection scope was pushed manually)<br/>
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
		public ref ImGuiMultiSelectFlags Flags => ref Unsafe.AsRef<ImGuiMultiSelectFlags>(&NativePtr->Flags);
		public ref Vector2 ScopeRectMin => ref Unsafe.AsRef<Vector2>(&NativePtr->ScopeRectMin);
		public ref Vector2 BackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorMaxPos);
		/// <summary>
		/// Copy of last submitted item data, used to merge output ranges.<br/>
		/// </summary>
		public ref long LastSubmittedItem => ref Unsafe.AsRef<long>(&NativePtr->LastSubmittedItem);
		public ref uint BoxSelectId => ref Unsafe.AsRef<uint>(&NativePtr->BoxSelectId);
		public ref int KeyMods => ref Unsafe.AsRef<int>(&NativePtr->KeyMods);
		/// <summary>
		/// -1: no operation, 0: clear all, 1: select all.<br/>
		/// </summary>
		public ref sbyte LoopRequestSetAll => ref Unsafe.AsRef<sbyte>(&NativePtr->LoopRequestSetAll);
		/// <summary>
		/// Set when switching IO from BeginMultiSelect() to EndMultiSelect() state.<br/>
		/// </summary>
		public ref bool IsEndIO => ref Unsafe.AsRef<bool>(&NativePtr->IsEndIO);
		/// <summary>
		/// Set if currently focusing the selection scope (any item of the selection). May be used if you have custom shortcut associated to selection.<br/>
		/// </summary>
		public ref bool IsFocused => ref Unsafe.AsRef<bool>(&NativePtr->IsFocused);
		/// <summary>
		/// Set by BeginMultiSelect() when using Shift+Navigation. Because scrolling may be affected we can't afford a frame of lag with Shift+Navigation.<br/>
		/// </summary>
		public ref bool IsKeyboardSetRange => ref Unsafe.AsRef<bool>(&NativePtr->IsKeyboardSetRange);
		public ref bool NavIdPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->NavIdPassedBy);
		/// <summary>
		/// Set by the item that matches RangeSrcItem.<br/>
		/// </summary>
		public ref bool RangeSrcPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->RangeSrcPassedBy);
		/// <summary>
		/// Set by the item that matches NavJustMovedToId when IsSetRange is set.<br/>
		/// </summary>
		public ref bool RangeDstPassedBy => ref Unsafe.AsRef<bool>(&NativePtr->RangeDstPassedBy);
		public ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* nativePtr) => NativePtr = nativePtr;
		public ImGuiMultiSelectTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectTempData*)nativePtr;
		public static implicit operator ImGuiMultiSelectTempDataPtr(ImGuiMultiSelectTempData* ptr) => new ImGuiMultiSelectTempDataPtr(ptr);
		public static implicit operator ImGuiMultiSelectTempDataPtr(IntPtr ptr) => new ImGuiMultiSelectTempDataPtr(ptr);
		public static implicit operator ImGuiMultiSelectTempData*(ImGuiMultiSelectTempDataPtr nativePtr) => nativePtr.NativePtr;
		public void ClearIO()
		{
			ImGuiNative.ImGuiMultiSelectTempDataClearIO(NativePtr);
		}

		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.<br/>
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImGuiMultiSelectTempDataClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiMultiSelectTempDataDestroy(NativePtr);
		}

		public void ImGuiMultiSelectTempDataConstruct()
		{
			ImGuiNative.ImGuiMultiSelectTempDataImGuiMultiSelectTempDataConstruct(NativePtr);
		}

		public ImGuiMultiSelectTempDataPtr ImGuiMultiSelectTempData()
		{
			return ImGuiNative.ImGuiMultiSelectTempDataImGuiMultiSelectTempData();
		}

	}
}
