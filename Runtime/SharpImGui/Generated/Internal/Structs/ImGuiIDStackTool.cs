using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// State for ID Stack tool queries<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiIdStackTool
	{
		public int LastActiveFrame;
		/// <summary>
		/// -1: query stack and resize Results, &gt;= 0: individual stack level<br/>
		/// </summary>
		public int StackLevel;
		/// <summary>
		/// ID to query details for<br/>
		/// </summary>
		public uint QueryId;
		public ImVector<ImGuiStackLevelInfo> Results;
		public byte CopyToClipboardOnCtrlC;
		public float CopyToClipboardLastTime;
		public ImGuiTextBuffer ResultPathBuf;
	}

	/// <summary>
	/// State for ID Stack tool queries<br/>
	/// </summary>
	public unsafe partial struct ImGuiIdStackToolPtr
	{
		public ImGuiIdStackTool* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiIdStackTool this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref int LastActiveFrame => ref Unsafe.AsRef<int>(&NativePtr->LastActiveFrame);
		/// <summary>
		/// -1: query stack and resize Results, &gt;= 0: individual stack level<br/>
		/// </summary>
		public ref int StackLevel => ref Unsafe.AsRef<int>(&NativePtr->StackLevel);
		/// <summary>
		/// ID to query details for<br/>
		/// </summary>
		public ref uint QueryId => ref Unsafe.AsRef<uint>(&NativePtr->QueryId);
		public ref ImVector<ImGuiStackLevelInfo> Results => ref Unsafe.AsRef<ImVector<ImGuiStackLevelInfo>>(&NativePtr->Results);
		public ref bool CopyToClipboardOnCtrlC => ref Unsafe.AsRef<bool>(&NativePtr->CopyToClipboardOnCtrlC);
		public ref float CopyToClipboardLastTime => ref Unsafe.AsRef<float>(&NativePtr->CopyToClipboardLastTime);
		public ref ImGuiTextBuffer ResultPathBuf => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->ResultPathBuf);
		public ImGuiIdStackToolPtr(ImGuiIdStackTool* nativePtr) => NativePtr = nativePtr;
		public ImGuiIdStackToolPtr(IntPtr nativePtr) => NativePtr = (ImGuiIdStackTool*)nativePtr;
		public static implicit operator ImGuiIdStackToolPtr(ImGuiIdStackTool* ptr) => new ImGuiIdStackToolPtr(ptr);
		public static implicit operator ImGuiIdStackToolPtr(IntPtr ptr) => new ImGuiIdStackToolPtr(ptr);
		public static implicit operator ImGuiIdStackTool*(ImGuiIdStackToolPtr nativePtr) => nativePtr.NativePtr;
	}
}
