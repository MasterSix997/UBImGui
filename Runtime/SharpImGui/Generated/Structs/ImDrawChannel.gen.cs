using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>[Internal] For use by ImDrawListSplitter</para>
	/// </summary>
	public unsafe partial struct ImDrawChannel
	{
		public ImVector _CmdBuffer;
		public ImVector _IdxBuffer;
	}

	/// <summary>
	/// <para>[Internal] For use by ImDrawListSplitter</para>
	/// </summary>
	public unsafe partial struct ImDrawChannelPtr
	{
		public ImDrawChannel* NativePtr { get; }
		public ImDrawChannelPtr(ImDrawChannel* nativePtr) => NativePtr = nativePtr;
		public ImDrawChannelPtr(IntPtr nativePtr) => NativePtr = (ImDrawChannel*)nativePtr;
		public static implicit operator ImDrawChannelPtr(ImDrawChannel* nativePtr) => new ImDrawChannelPtr(nativePtr);
		public static implicit operator ImDrawChannel* (ImDrawChannelPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawChannelPtr(IntPtr nativePtr) => new ImDrawChannelPtr(nativePtr);

		public ImPtrVector<ImDrawCmdPtr> _CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->_CmdBuffer, Unsafe.SizeOf<ImDrawCmd>());

		public ImVector<ushort> _IdxBuffer => new ImVector<ushort>(NativePtr->_IdxBuffer);
	}
}
