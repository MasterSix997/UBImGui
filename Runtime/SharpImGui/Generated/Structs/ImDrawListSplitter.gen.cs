using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.</para>
	/// <para>This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.</para>
	/// </summary>
	public unsafe partial struct ImDrawListSplitter
	{
		/// <summary>
		/// Current channel number (0)
		/// </summary>
		public int _Current;
		/// <summary>
		/// Number of active channels (1+)
		/// </summary>
		public int _Count;
		/// <summary>
		/// Draw channels (not resized down so _Count might be &lt; Channels.Size)
		/// </summary>
		public ImVector _Channels;
	}

	/// <summary>
	/// <para>Split/Merge functions are used to split the draw list into different layers which can be drawn into out of order.</para>
	/// <para>This is used by the Columns/Tables API, so items of each column can be batched together in a same draw call.</para>
	/// </summary>
	public unsafe partial struct ImDrawListSplitterPtr
	{
		public ImDrawListSplitter* NativePtr { get; }
		public ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) => NativePtr = nativePtr;
		public ImDrawListSplitterPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSplitter*)nativePtr;
		public static implicit operator ImDrawListSplitterPtr(ImDrawListSplitter* nativePtr) => new ImDrawListSplitterPtr(nativePtr);
		public static implicit operator ImDrawListSplitter* (ImDrawListSplitterPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawListSplitterPtr(IntPtr nativePtr) => new ImDrawListSplitterPtr(nativePtr);

		/// <summary>
		/// Current channel number (0)
		/// </summary>
		public ref int _Current => ref Unsafe.AsRef<int>(&NativePtr->_Current);

		/// <summary>
		/// Number of active channels (1+)
		/// </summary>
		public ref int _Count => ref Unsafe.AsRef<int>(&NativePtr->_Count);

		/// <summary>
		/// Draw channels (not resized down so _Count might be &lt; Channels.Size)
		/// </summary>
		public ImPtrVector<ImDrawChannelPtr> _Channels => new ImPtrVector<ImDrawChannelPtr>(NativePtr->_Channels, Unsafe.SizeOf<ImDrawChannel>());

		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImDrawListSplitter_Clear(NativePtr);
		}

		public void ClearFreeMemory()
		{
			ImGuiNative.ImDrawListSplitter_ClearFreeMemory(NativePtr);
		}

		public void Split(ImDrawListPtr draw_list, int count)
		{
			ImGuiNative.ImDrawListSplitter_Split(NativePtr, draw_list, count);
		}

		public void Merge(ImDrawListPtr draw_list)
		{
			ImGuiNative.ImDrawListSplitter_Merge(NativePtr, draw_list);
		}

		public void SetCurrentChannel(ImDrawListPtr draw_list, int channel_idx)
		{
			ImGuiNative.ImDrawListSplitter_SetCurrentChannel(NativePtr, draw_list, channel_idx);
		}
	}
}
