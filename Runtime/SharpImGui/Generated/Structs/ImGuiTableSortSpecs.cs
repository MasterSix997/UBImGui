using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Sorting specifications for a table (often handling sort specs for a single column, occasionally more)<br/>Obtained by calling TableGetSortSpecs().<br/>When 'SpecsDirty == true' you can sort your data. It will be true with sorting specs have changed since last call, or the first time.<br/>Make sure to set 'SpecsDirty = false' after sorting, else you may wastefully sort your data every frame!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableSortSpecs
	{
		/// <summary>
		/// Pointer to sort spec array.<br/>
		/// </summary>
		public unsafe ImGuiTableColumnSortSpecs* Specs;
		/// <summary>
		/// Sort spec count. Most often 1. May be &gt; 1 when ImGuiTableFlags_SortMulti is enabled. May be == 0 when ImGuiTableFlags_SortTristate is enabled.<br/>
		/// </summary>
		public int SpecsCount;
		/// <summary>
		/// Set to true when specs have changed since last time! Use this to sort again, then clear the flag.<br/>
		/// </summary>
		public byte SpecsDirty;
	}

	/// <summary>
	/// Sorting specifications for a table (often handling sort specs for a single column, occasionally more)<br/>Obtained by calling TableGetSortSpecs().<br/>When 'SpecsDirty == true' you can sort your data. It will be true with sorting specs have changed since last call, or the first time.<br/>Make sure to set 'SpecsDirty = false' after sorting, else you may wastefully sort your data every frame!<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableSortSpecsPtr
	{
		public ImGuiTableSortSpecs* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableSortSpecs this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Pointer to sort spec array.<br/>
		/// </summary>
		public ref ImGuiTableColumnSortSpecsPtr Specs => ref Unsafe.AsRef<ImGuiTableColumnSortSpecsPtr>(&NativePtr->Specs);
		/// <summary>
		/// Sort spec count. Most often 1. May be &gt; 1 when ImGuiTableFlags_SortMulti is enabled. May be == 0 when ImGuiTableFlags_SortTristate is enabled.<br/>
		/// </summary>
		public ref int SpecsCount => ref Unsafe.AsRef<int>(&NativePtr->SpecsCount);
		/// <summary>
		/// Set to true when specs have changed since last time! Use this to sort again, then clear the flag.<br/>
		/// </summary>
		public ref bool SpecsDirty => ref Unsafe.AsRef<bool>(&NativePtr->SpecsDirty);
		public ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableSortSpecsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSortSpecs*)nativePtr;
		public static implicit operator ImGuiTableSortSpecsPtr(ImGuiTableSortSpecs* ptr) => new ImGuiTableSortSpecsPtr(ptr);
		public static implicit operator ImGuiTableSortSpecsPtr(IntPtr ptr) => new ImGuiTableSortSpecsPtr(ptr);
		public static implicit operator ImGuiTableSortSpecs*(ImGuiTableSortSpecsPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTableSortSpecsDestroy(NativePtr);
		}

		public void ImGuiTableSortSpecsConstruct()
		{
			ImGuiNative.ImGuiTableSortSpecsImGuiTableSortSpecsConstruct(NativePtr);
		}

		public ImGuiTableSortSpecsPtr ImGuiTableSortSpecs()
		{
			return ImGuiNative.ImGuiTableSortSpecsImGuiTableSortSpecs();
		}

	}
}
