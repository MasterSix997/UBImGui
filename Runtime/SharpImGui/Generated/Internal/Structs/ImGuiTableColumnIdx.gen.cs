using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Instantiation of ImSpan&lt;ImGuiTableColumnIdx&gt;</para>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnIdx
	{
		public short* Data;
		public short* DataEnd;
	}

	/// <summary>
	/// <para>Instantiation of ImSpan&lt;ImGuiTableColumnIdx&gt;</para>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnIdxPtr
	{
		public ImGuiTableColumnIdx* NativePtr { get; }
		public ImGuiTableColumnIdxPtr(ImGuiTableColumnIdx* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnIdxPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnIdx*)nativePtr;
		public static implicit operator ImGuiTableColumnIdxPtr(ImGuiTableColumnIdx* nativePtr) => new ImGuiTableColumnIdxPtr(nativePtr);
		public static implicit operator ImGuiTableColumnIdx* (ImGuiTableColumnIdxPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableColumnIdxPtr(IntPtr nativePtr) => new ImGuiTableColumnIdxPtr(nativePtr);

		public IntPtr Data { get => (IntPtr)NativePtr->Data; set => NativePtr->Data = (short*)value; }

		public IntPtr DataEnd { get => (IntPtr)NativePtr->DataEnd; set => NativePtr->DataEnd = (short*)value; }
	}
}
