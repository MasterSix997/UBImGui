using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Sorting specification for one column of a table (sizeof == 12 bytes)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSortSpecs
	{
		/// <summary>
		/// User id of the column (if specified by a TableSetupColumn() call)<br/>
		/// </summary>
		public uint ColumnUserID;
		/// <summary>
		/// Index of the column<br/>
		/// </summary>
		public short ColumnIndex;
		/// <summary>
		/// Index within parent ImGuiTableSortSpecs (always stored in order starting from 0, tables sorted on a single criteria will always have a 0 here)<br/>
		/// </summary>
		public short SortOrder;
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending<br/>
		/// </summary>
		public ImGuiSortDirection SortDirection;
	}

	/// <summary>
	/// Sorting specification for one column of a table (sizeof == 12 bytes)<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSortSpecsPtr
	{
		public ImGuiTableColumnSortSpecs* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableColumnSortSpecs this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// User id of the column (if specified by a TableSetupColumn() call)<br/>
		/// </summary>
		public ref uint ColumnUserID => ref Unsafe.AsRef<uint>(&NativePtr->ColumnUserID);
		/// <summary>
		/// Index of the column<br/>
		/// </summary>
		public ref short ColumnIndex => ref Unsafe.AsRef<short>(&NativePtr->ColumnIndex);
		/// <summary>
		/// Index within parent ImGuiTableSortSpecs (always stored in order starting from 0, tables sorted on a single criteria will always have a 0 here)<br/>
		/// </summary>
		public ref short SortOrder => ref Unsafe.AsRef<short>(&NativePtr->SortOrder);
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending<br/>
		/// </summary>
		public ref ImGuiSortDirection SortDirection => ref Unsafe.AsRef<ImGuiSortDirection>(&NativePtr->SortDirection);
		public ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSortSpecs*)nativePtr;
		public static implicit operator ImGuiTableColumnSortSpecsPtr(ImGuiTableColumnSortSpecs* ptr) => new ImGuiTableColumnSortSpecsPtr(ptr);
		public static implicit operator ImGuiTableColumnSortSpecsPtr(IntPtr ptr) => new ImGuiTableColumnSortSpecsPtr(ptr);
		public static implicit operator ImGuiTableColumnSortSpecs*(ImGuiTableColumnSortSpecsPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTableColumnSortSpecsDestroy(NativePtr);
		}

		public void ImGuiTableColumnSortSpecsConstruct()
		{
			ImGuiNative.ImGuiTableColumnSortSpecsImGuiTableColumnSortSpecsConstruct(NativePtr);
		}

		public ImGuiTableColumnSortSpecsPtr ImGuiTableColumnSortSpecs()
		{
			return ImGuiNative.ImGuiTableColumnSortSpecsImGuiTableColumnSortSpecs();
		}

	}
}
