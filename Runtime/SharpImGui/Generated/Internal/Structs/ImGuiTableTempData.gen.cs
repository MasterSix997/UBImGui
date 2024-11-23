using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Transient data that are only needed between BeginTable() and EndTable(), those buffers are shared (1 per level of stacked table).</para>
	/// <para>- Accessing those requires chasing an extra pointer so for very frequently used data we leave them in the main table structure.</para>
	/// <para>- We also leave out of this structure data that tend to be particularly useful for debugging/metrics.</para>
	/// <para>FIXME-TABLE: more transient data could be stored in a stacked ImGuiTableTempData: e.g. SortSpecs.</para>
	/// <para>sizeof() ~ 136 bytes.</para>
	/// </summary>
	public unsafe partial struct ImGuiTableTempData
	{
		/// <summary>
		/// Index in g.Tables.Buf[] pool
		/// </summary>
		public int TableIndex;
		/// <summary>
		/// Last timestamp this structure was used
		/// </summary>
		public float LastTimeActive;
		/// <summary>
		/// Used in EndTable()
		/// </summary>
		public float AngledHeadersExtraWidth;
		/// <summary>
		/// Used in TableAngledHeadersRow()
		/// </summary>
		public ImVector AngledHeadersRequests;
		/// <summary>
		/// outer_size.x passed to BeginTable()
		/// </summary>
		public Vector2 UserOuterSize;
		public ImDrawListSplitter DrawSplitter;
		/// <summary>
		/// Backup of InnerWindow-&gt;WorkRect at the end of BeginTable()
		/// </summary>
		public ImRect HostBackupWorkRect;
		/// <summary>
		/// Backup of InnerWindow-&gt;ParentWorkRect at the end of BeginTable()
		/// </summary>
		public ImRect HostBackupParentWorkRect;
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.PrevLineSize at the end of BeginTable()
		/// </summary>
		public Vector2 HostBackupPrevLineSize;
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CurrLineSize at the end of BeginTable()
		/// </summary>
		public Vector2 HostBackupCurrLineSize;
		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CursorMaxPos at the end of BeginTable()
		/// </summary>
		public Vector2 HostBackupCursorMaxPos;
		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ColumnsOffset at the end of BeginTable()
		/// </summary>
		public ImVec1 HostBackupColumnsOffset;
		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ItemWidth at the end of BeginTable()
		/// </summary>
		public float HostBackupItemWidth;
		/// <summary>
		/// //Backup of OuterWindow-&gt;DC.ItemWidthStack.Size at the end of BeginTable()
		/// </summary>
		public int HostBackupItemWidthStackSize;
	}

	/// <summary>
	/// <para>Transient data that are only needed between BeginTable() and EndTable(), those buffers are shared (1 per level of stacked table).</para>
	/// <para>- Accessing those requires chasing an extra pointer so for very frequently used data we leave them in the main table structure.</para>
	/// <para>- We also leave out of this structure data that tend to be particularly useful for debugging/metrics.</para>
	/// <para>FIXME-TABLE: more transient data could be stored in a stacked ImGuiTableTempData: e.g. SortSpecs.</para>
	/// <para>sizeof() ~ 136 bytes.</para>
	/// </summary>
	public unsafe partial struct ImGuiTableTempDataPtr
	{
		public ImGuiTableTempData* NativePtr { get; }
		public ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableTempData*)nativePtr;
		public static implicit operator ImGuiTableTempDataPtr(ImGuiTableTempData* nativePtr) => new ImGuiTableTempDataPtr(nativePtr);
		public static implicit operator ImGuiTableTempData* (ImGuiTableTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableTempDataPtr(IntPtr nativePtr) => new ImGuiTableTempDataPtr(nativePtr);

		/// <summary>
		/// Index in g.Tables.Buf[] pool
		/// </summary>
		public ref int TableIndex => ref Unsafe.AsRef<int>(&NativePtr->TableIndex);

		/// <summary>
		/// Last timestamp this structure was used
		/// </summary>
		public ref float LastTimeActive => ref Unsafe.AsRef<float>(&NativePtr->LastTimeActive);

		/// <summary>
		/// Used in EndTable()
		/// </summary>
		public ref float AngledHeadersExtraWidth => ref Unsafe.AsRef<float>(&NativePtr->AngledHeadersExtraWidth);

		/// <summary>
		/// Used in TableAngledHeadersRow()
		/// </summary>
		public ImPtrVector<ImGuiTableHeaderDataPtr> AngledHeadersRequests => new ImPtrVector<ImGuiTableHeaderDataPtr>(NativePtr->AngledHeadersRequests, Unsafe.SizeOf<ImGuiTableHeaderData>());

		/// <summary>
		/// outer_size.x passed to BeginTable()
		/// </summary>
		public ref Vector2 UserOuterSize => ref Unsafe.AsRef<Vector2>(&NativePtr->UserOuterSize);

		public ref ImDrawListSplitter DrawSplitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->DrawSplitter);

		/// <summary>
		/// Backup of InnerWindow-&gt;WorkRect at the end of BeginTable()
		/// </summary>
		public ref ImRect HostBackupWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupWorkRect);

		/// <summary>
		/// Backup of InnerWindow-&gt;ParentWorkRect at the end of BeginTable()
		/// </summary>
		public ref ImRect HostBackupParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupParentWorkRect);

		/// <summary>
		/// Backup of InnerWindow-&gt;DC.PrevLineSize at the end of BeginTable()
		/// </summary>
		public ref Vector2 HostBackupPrevLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupPrevLineSize);

		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CurrLineSize at the end of BeginTable()
		/// </summary>
		public ref Vector2 HostBackupCurrLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupCurrLineSize);

		/// <summary>
		/// Backup of InnerWindow-&gt;DC.CursorMaxPos at the end of BeginTable()
		/// </summary>
		public ref Vector2 HostBackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->HostBackupCursorMaxPos);

		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ColumnsOffset at the end of BeginTable()
		/// </summary>
		public ref ImVec1 HostBackupColumnsOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->HostBackupColumnsOffset);

		/// <summary>
		/// Backup of OuterWindow-&gt;DC.ItemWidth at the end of BeginTable()
		/// </summary>
		public ref float HostBackupItemWidth => ref Unsafe.AsRef<float>(&NativePtr->HostBackupItemWidth);

		/// <summary>
		/// //Backup of OuterWindow-&gt;DC.ItemWidthStack.Size at the end of BeginTable()
		/// </summary>
		public ref int HostBackupItemWidthStackSize => ref Unsafe.AsRef<int>(&NativePtr->HostBackupItemWidthStackSize);
	}
}
