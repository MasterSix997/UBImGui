using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.<br/>This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawListSplitter
	{
		/// <summary>
		/// Current channel number (0)<br/>
		/// </summary>
		public int Current;
		/// <summary>
		/// Number of active channels (1+)<br/>
		/// </summary>
		public int Count;
		/// <summary>
		/// Draw channels (not resized down so _Count might be &lt; Channels.Size)<br/>
		/// </summary>
		public ImVector<ImDrawChannel> Channels;
	}

	/// <summary>
	/// Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.<br/>This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.<br/>
	/// </summary>
	public unsafe partial struct ImDrawListSplitterPtr
	{
		public ImDrawListSplitter* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawListSplitter this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Current channel number (0)<br/>
		/// </summary>
		public ref int Current => ref Unsafe.AsRef<int>(&NativePtr->Current);
		/// <summary>
		/// Number of active channels (1+)<br/>
		/// </summary>
		public ref int Count => ref Unsafe.AsRef<int>(&NativePtr->Count);
		/// <summary>
		/// Draw channels (not resized down so _Count might be &lt; Channels.Size)<br/>
		/// </summary>
		public ref ImVector<ImDrawChannel> Channels => ref Unsafe.AsRef<ImVector<ImDrawChannel>>(&NativePtr->Channels);
		public ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) => NativePtr = nativePtr;
		public ImDrawListSplitterPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSplitter*)nativePtr;
		public static implicit operator ImDrawListSplitterPtr(ImDrawListSplitter* ptr) => new ImDrawListSplitterPtr(ptr);
		public static implicit operator ImDrawListSplitterPtr(IntPtr ptr) => new ImDrawListSplitterPtr(ptr);
		public static implicit operator ImDrawListSplitter*(ImDrawListSplitterPtr nativePtr) => nativePtr.NativePtr;
		public void SetCurrentChannel(ImDrawListPtr drawList, int channelIdx)
		{
			ImGuiNative.ImDrawListSplitterSetCurrentChannel(NativePtr, drawList, channelIdx);
		}

		public void Merge(ImDrawListPtr drawList)
		{
			ImGuiNative.ImDrawListSplitterMerge(NativePtr, drawList);
		}

		public void Split(ImDrawListPtr drawList, int count)
		{
			ImGuiNative.ImDrawListSplitterSplit(NativePtr, drawList, count);
		}

		public void ClearFreeMemory()
		{
			ImGuiNative.ImDrawListSplitterClearFreeMemory(NativePtr);
		}

		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame<br/>
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImDrawListSplitterClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImDrawListSplitterDestroy(NativePtr);
		}

		public void ImDrawListSplitterConstruct()
		{
			ImGuiNative.ImDrawListSplitterImDrawListSplitterConstruct(NativePtr);
		}

		public ImDrawListSplitterPtr ImDrawListSplitter()
		{
			return ImGuiNative.ImDrawListSplitterImDrawListSplitter();
		}

	}
}
