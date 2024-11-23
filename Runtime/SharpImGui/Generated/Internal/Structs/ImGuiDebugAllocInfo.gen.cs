using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiDebugAllocInfo
	{
		/// <summary>
		/// Number of call to MemAlloc().
		/// </summary>
		public int TotalAllocCount;
		public int TotalFreeCount;
		/// <summary>
		/// Current index in buffer
		/// </summary>
		public short LastEntriesIdx;
		/// <summary>
		/// Track last 6 frames that had allocations
		/// </summary>
		public ImGuiDebugAllocEntry LastEntriesBuf_0;
		public ImGuiDebugAllocEntry LastEntriesBuf_1;
		public ImGuiDebugAllocEntry LastEntriesBuf_2;
		public ImGuiDebugAllocEntry LastEntriesBuf_3;
		public ImGuiDebugAllocEntry LastEntriesBuf_4;
		public ImGuiDebugAllocEntry LastEntriesBuf_5;
	}

	public unsafe partial struct ImGuiDebugAllocInfoPtr
	{
		public ImGuiDebugAllocInfo* NativePtr { get; }
		public ImGuiDebugAllocInfoPtr(ImGuiDebugAllocInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiDebugAllocInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDebugAllocInfo*)nativePtr;
		public static implicit operator ImGuiDebugAllocInfoPtr(ImGuiDebugAllocInfo* nativePtr) => new ImGuiDebugAllocInfoPtr(nativePtr);
		public static implicit operator ImGuiDebugAllocInfo* (ImGuiDebugAllocInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiDebugAllocInfoPtr(IntPtr nativePtr) => new ImGuiDebugAllocInfoPtr(nativePtr);

		/// <summary>
		/// Number of call to MemAlloc().
		/// </summary>
		public ref int TotalAllocCount => ref Unsafe.AsRef<int>(&NativePtr->TotalAllocCount);

		public ref int TotalFreeCount => ref Unsafe.AsRef<int>(&NativePtr->TotalFreeCount);

		/// <summary>
		/// Current index in buffer
		/// </summary>
		public ref short LastEntriesIdx => ref Unsafe.AsRef<short>(&NativePtr->LastEntriesIdx);

		/// <summary>
		/// Track last 6 frames that had allocations
		/// </summary>
		public RangeAccessor<ImGuiDebugAllocEntry> LastEntriesBuf => new RangeAccessor<ImGuiDebugAllocEntry>(&NativePtr->LastEntriesBuf_0, 6);
	}
}
