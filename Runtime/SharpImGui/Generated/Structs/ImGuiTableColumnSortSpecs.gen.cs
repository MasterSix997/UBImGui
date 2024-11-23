using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Sorting specification for one column of a table (sizeof == 12 bytes)</para>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSortSpecs
	{
		/// <summary>
		/// User id of the column (if specified by a TableSetupColumn() call)
		/// </summary>
		public uint ColumnUserID;
		/// <summary>
		/// Index of the column
		/// </summary>
		public short ColumnIndex;
		/// <summary>
		/// Index within parent ImGuiTableSortSpecs (always stored in order starting from 0, tables sorted on a single criteria will always have a 0 here)
		/// </summary>
		public short SortOrder;
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending
		/// </summary>
		public ImGuiSortDirection SortDirection;
	}

	/// <summary>
	/// <para>Sorting specification for one column of a table (sizeof == 12 bytes)</para>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSortSpecsPtr
	{
		public ImGuiTableColumnSortSpecs* NativePtr { get; }
		public ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSortSpecs*)nativePtr;
		public static implicit operator ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => new ImGuiTableColumnSortSpecsPtr(nativePtr);
		public static implicit operator ImGuiTableColumnSortSpecs* (ImGuiTableColumnSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => new ImGuiTableColumnSortSpecsPtr(nativePtr);

		/// <summary>
		/// User id of the column (if specified by a TableSetupColumn() call)
		/// </summary>
		public ref uint ColumnUserID => ref Unsafe.AsRef<uint>(&NativePtr->ColumnUserID);

		/// <summary>
		/// Index of the column
		/// </summary>
		public ref short ColumnIndex => ref Unsafe.AsRef<short>(&NativePtr->ColumnIndex);

		/// <summary>
		/// Index within parent ImGuiTableSortSpecs (always stored in order starting from 0, tables sorted on a single criteria will always have a 0 here)
		/// </summary>
		public ref short SortOrder => ref Unsafe.AsRef<short>(&NativePtr->SortOrder);

		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending
		/// </summary>
		public ref ImGuiSortDirection SortDirection => ref Unsafe.AsRef<ImGuiSortDirection>(&NativePtr->SortDirection);
	}
}
