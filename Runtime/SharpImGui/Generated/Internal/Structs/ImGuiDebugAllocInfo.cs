using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDebugAllocInfo
	{
		/// <summary>
		/// Number of call to MemAlloc().<br/>
		/// </summary>
		public int TotalAllocCount;
		public int TotalFreeCount;
		/// <summary>
		/// Current index in buffer<br/>
		/// </summary>
		public short LastEntriesIdx;
		/// <summary>
		/// Track last 6 frames that had allocations<br/>
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
		public bool IsNull => NativePtr == null;
		public ImGuiDebugAllocInfo this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Number of call to MemAlloc().<br/>
		/// </summary>
		public ref int TotalAllocCount => ref Unsafe.AsRef<int>(&NativePtr->TotalAllocCount);
		public ref int TotalFreeCount => ref Unsafe.AsRef<int>(&NativePtr->TotalFreeCount);
		/// <summary>
		/// Current index in buffer<br/>
		/// </summary>
		public ref short LastEntriesIdx => ref Unsafe.AsRef<short>(&NativePtr->LastEntriesIdx);
		/// <summary>
		/// Track last 6 frames that had allocations<br/>
		/// </summary>
		public Span<ImGuiDebugAllocEntry> LastEntriesBuf => new Span<ImGuiDebugAllocEntry>(&NativePtr->LastEntriesBuf_0, 6);
		public ImGuiDebugAllocInfoPtr(ImGuiDebugAllocInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiDebugAllocInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDebugAllocInfo*)nativePtr;
		public static implicit operator ImGuiDebugAllocInfoPtr(ImGuiDebugAllocInfo* ptr) => new ImGuiDebugAllocInfoPtr(ptr);
		public static implicit operator ImGuiDebugAllocInfoPtr(IntPtr ptr) => new ImGuiDebugAllocInfoPtr(ptr);
		public static implicit operator ImGuiDebugAllocInfo*(ImGuiDebugAllocInfoPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiDebugAllocInfoDestroy(NativePtr);
		}

		public void ImGuiDebugAllocInfoConstruct()
		{
			ImGuiNative.ImGuiDebugAllocInfoImGuiDebugAllocInfoConstruct(NativePtr);
		}

		public ImGuiDebugAllocInfoPtr ImGuiDebugAllocInfo()
		{
			return ImGuiNative.ImGuiDebugAllocInfoImGuiDebugAllocInfo();
		}

	}
}
