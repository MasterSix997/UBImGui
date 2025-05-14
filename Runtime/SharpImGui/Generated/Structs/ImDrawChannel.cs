using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// [Internal] For use by ImDrawListSplitter<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawChannel
	{
		public ImVector<ImDrawCmd> CmdBuffer;
		public ImVector<ushort> IdxBuffer;
	}

	/// <summary>
	/// [Internal] For use by ImDrawListSplitter<br/>
	/// </summary>
	public unsafe partial struct ImDrawChannelPtr
	{
		public ImDrawChannel* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawChannel this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<ImDrawCmd> CmdBuffer => ref Unsafe.AsRef<ImVector<ImDrawCmd>>(&NativePtr->CmdBuffer);
		public ref ImVector<ushort> IdxBuffer => ref Unsafe.AsRef<ImVector<ushort>>(&NativePtr->IdxBuffer);
		public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
		public ImDrawChannelPtr(IntPtr nativePtr) => NativePtr = (ImDrawChannel*)nativePtr;
		public static implicit operator ImDrawChannelPtr(ImDrawChannel* ptr) => new ImDrawChannelPtr(ptr);
		public static implicit operator ImDrawChannelPtr(IntPtr ptr) => new ImDrawChannelPtr(ptr);
		public static implicit operator ImDrawChannel*(ImDrawChannelPtr nativePtr) => nativePtr.NativePtr;
	}
}
