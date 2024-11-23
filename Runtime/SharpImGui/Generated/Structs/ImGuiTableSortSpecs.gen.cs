using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Sorting specifications for a table (often handling sort specs for a single column, occasionally more)</para>
	/// <para>Obtained by calling TableGetSortSpecs().</para>
	/// <para>When 'SpecsDirty == true' you can sort your data. It will be true with sorting specs have changed since last call, or the first time.</para>
	/// <para>Make sure to set 'SpecsDirty = false' after sorting, else you may wastefully sort your data every frame!</para>
	/// </summary>
	public unsafe partial struct ImGuiTableSortSpecs
	{
		/// <summary>
		/// Pointer to sort spec array.
		/// </summary>
		public ImGuiTableColumnSortSpecs* Specs;
		/// <summary>
		/// Sort spec count. Most often 1. May be &gt; 1 when ImGuiTableFlags_SortMulti is enabled. May be == 0 when ImGuiTableFlags_SortTristate is enabled.
		/// </summary>
		public int SpecsCount;
		/// <summary>
		/// Set to true when specs have changed since last time! Use this to sort again, then clear the flag.
		/// </summary>
		public byte SpecsDirty;
	}

	/// <summary>
	/// <para>Sorting specifications for a table (often handling sort specs for a single column, occasionally more)</para>
	/// <para>Obtained by calling TableGetSortSpecs().</para>
	/// <para>When 'SpecsDirty == true' you can sort your data. It will be true with sorting specs have changed since last call, or the first time.</para>
	/// <para>Make sure to set 'SpecsDirty = false' after sorting, else you may wastefully sort your data every frame!</para>
	/// </summary>
	public unsafe partial struct ImGuiTableSortSpecsPtr
	{
		public ImGuiTableSortSpecs* NativePtr { get; }
		public ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSortSpecs*)nativePtr;
		public static implicit operator ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => new ImGuiTableSortSpecsPtr(nativePtr);
		public static implicit operator ImGuiTableSortSpecs* (ImGuiTableSortSpecsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableSortSpecsPtr(IntPtr nativePtr) => new ImGuiTableSortSpecsPtr(nativePtr);

		/// <summary>
		/// Pointer to sort spec array.
		/// </summary>
		public ImGuiTableColumnSortSpecsPtr Specs => new ImGuiTableColumnSortSpecsPtr(NativePtr->Specs);

		/// <summary>
		/// Sort spec count. Most often 1. May be &gt; 1 when ImGuiTableFlags_SortMulti is enabled. May be == 0 when ImGuiTableFlags_SortTristate is enabled.
		/// </summary>
		public ref int SpecsCount => ref Unsafe.AsRef<int>(&NativePtr->SpecsCount);

		/// <summary>
		/// Set to true when specs have changed since last time! Use this to sort again, then clear the flag.
		/// </summary>
		public ref bool SpecsDirty => ref Unsafe.AsRef<bool>(&NativePtr->SpecsDirty);
	}
}
