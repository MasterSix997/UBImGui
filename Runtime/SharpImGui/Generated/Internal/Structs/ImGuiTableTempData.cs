using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Transient data that are only needed between BeginTable() and EndTable(), those buffers are shared (1 per level of stacked table).<br/>- Accessing those requires chasing an extra pointer so for very frequently used data we leave them in the main table structure.<br/>- We also leave out of this structure data that tend to be particularly useful for debugging/metrics.<br/>FIXME-TABLE: more transient data could be stored in a stacked ImGuiTableTempData: e.g. SortSpecs.<br/>sizeof() ~ 136 bytes.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableTempData
	{
		/// <summary>
		/// Index in g.Tables.Buf[] pool<br/>
		/// </summary>
		public int TableIndex;
		/// <summary>
		/// Last timestamp this structure was used<br/>
		/// </summary>
		public float LastTimeActive;
		/// <summary>
		/// Used in EndTable()<br/>
		/// </summary>
		public float AngledHeadersExtraWidth;
		/// <summary>
		/// Used in TableAngledHeadersRow()<br/>
		/// </summary>
		public ImVector<ImGuiTableHeaderData> AngledHeadersRequests;
		/// <summary>
		/// outer_size.x passed to BeginTable()<br/>
		/// </summary>
		public Vector2 UserOuterSize;
		public ImDrawListSplitter DrawSplitter;
		/// <summary>
		/// Backup of InnerWindow-&gt;WorkRect at the end of BeginTable()<br/>
		/// </summary>
		public ImRect HostBackupWorkRect;
		/// <summary>
		/// Backup of InnerWindow-&gt;ParentWorkRect at the end of BeginTable()<br/>
		/// </summary>
		public ImRect HostBackupParentWorkRect;
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.PrevLineSize at the end of BeginTable()<br/>
		/// </summary>
		public Vector2 HostBackupPrevLineSize;
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CurrLineSize at the end of BeginTable()<br/>
		/// </summary>
		public Vector2 HostBackupCurrLineSize;
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CursorMaxPos at the end of BeginTable()<br/>
		/// </summary>
		public Vector2 HostBackupCursorMaxPos;
		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ColumnsOffset at the end of BeginTable()<br/>
		/// </summary>
		public ImVec1 HostBackupColumnsOffset;
		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ItemWidth at the end of BeginTable()<br/>
		/// </summary>
		public float HostBackupItemWidth;
		/// <summary>
		/// //Backup of OuterWindow-&gt;DC.ItemWidthStack.Size at the end of BeginTable()<br/>
		/// </summary>
		public int HostBackupItemWidthStackSize;
	}

	/// <summary>
	/// Transient data that are only needed between BeginTable() and EndTable(), those buffers are shared (1 per level of stacked table).<br/>- Accessing those requires chasing an extra pointer so for very frequently used data we leave them in the main table structure.<br/>- We also leave out of this structure data that tend to be particularly useful for debugging/metrics.<br/>FIXME-TABLE: more transient data could be stored in a stacked ImGuiTableTempData: e.g. SortSpecs.<br/>sizeof() ~ 136 bytes.<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableTempDataPtr
	{
		public ImGuiTableTempData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableTempData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Index in g.Tables.Buf[] pool<br/>
		/// </summary>
		public ref int TableIndex => ref Unsafe.AsRef<int>(&NativePtr->TableIndex);
		/// <summary>
		/// Last timestamp this structure was used<br/>
		/// </summary>
		public ref float LastTimeActive => ref Unsafe.AsRef<float>(&NativePtr->LastTimeActive);
		/// <summary>
		/// Used in EndTable()<br/>
		/// </summary>
		public ref float AngledHeadersExtraWidth => ref Unsafe.AsRef<float>(&NativePtr->AngledHeadersExtraWidth);
		/// <summary>
		/// Used in TableAngledHeadersRow()<br/>
		/// </summary>
		public ref ImVector<ImGuiTableHeaderData> AngledHeadersRequests => ref Unsafe.AsRef<ImVector<ImGuiTableHeaderData>>(&NativePtr->AngledHeadersRequests);
		/// <summary>
		/// outer_size.x passed to BeginTable()<br/>
		/// </summary>
		public ref Vector2 UserOuterSize => ref Unsafe.AsRef<Vector2>(&NativePtr->UserOuterSize);
		public ref ImDrawListSplitter DrawSplitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->DrawSplitter);
		/// <summary>
		/// Backup of InnerWindow-&gt;WorkRect at the end of BeginTable()<br/>
		/// </summary>
		public ref ImRect HostBackupWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupWorkRect);
		/// <summary>
		/// Backup of InnerWindow-&gt;ParentWorkRect at the end of BeginTable()<br/>
		/// </summary>
		public ref ImRect HostBackupParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupParentWorkRect);
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.PrevLineSize at the end of BeginTable()<br/>
		/// </summary>
		public ref Vector2 HostBackupPrevLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupPrevLineSize);
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CurrLineSize at the end of BeginTable()<br/>
		/// </summary>
		public ref Vector2 HostBackupCurrLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupCurrLineSize);
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CursorMaxPos at the end of BeginTable()<br/>
		/// </summary>
		public ref Vector2 HostBackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupCursorMaxPos);
		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ColumnsOffset at the end of BeginTable()<br/>
		/// </summary>
		public ref ImVec1 HostBackupColumnsOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->HostBackupColumnsOffset);
		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ItemWidth at the end of BeginTable()<br/>
		/// </summary>
		public ref float HostBackupItemWidth => ref Unsafe.AsRef<float>(&NativePtr->HostBackupItemWidth);
		/// <summary>
		/// //Backup of OuterWindow-&gt;DC.ItemWidthStack.Size at the end of BeginTable()<br/>
		/// </summary>
		public ref int HostBackupItemWidthStackSize => ref Unsafe.AsRef<int>(&NativePtr->HostBackupItemWidthStackSize);
		public ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableTempData*)nativePtr;
		public static implicit operator ImGuiTableTempDataPtr(ImGuiTableTempData* ptr) => new ImGuiTableTempDataPtr(ptr);
		public static implicit operator ImGuiTableTempDataPtr(IntPtr ptr) => new ImGuiTableTempDataPtr(ptr);
		public static implicit operator ImGuiTableTempData*(ImGuiTableTempDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTableTempDataDestroy(NativePtr);
		}

		public void ImGuiTableTempDataConstruct()
		{
			ImGuiNative.ImGuiTableTempDataImGuiTableTempDataConstruct(NativePtr);
		}

		public ImGuiTableTempDataPtr ImGuiTableTempData()
		{
			return ImGuiNative.ImGuiTableTempDataImGuiTableTempData();
		}

	}
}
