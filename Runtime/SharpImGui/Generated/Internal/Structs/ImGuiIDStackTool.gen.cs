using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>State for ID Stack tool queries</para>
	/// </summary>
	public unsafe partial struct ImGuiIDStackTool
	{
		public int LastActiveFrame;
		/// <summary>
		/// -1: query stack and resize Results, &gt;= 0: individual stack level
		/// </summary>
		public int StackLevel;
		/// <summary>
		/// ID to query details for
		/// </summary>
		public uint QueryId;
		public ImVector Results;
		public byte CopyToClipboardOnCtrlC;
		public float CopyToClipboardLastTime;
	}

	/// <summary>
	/// <para>State for ID Stack tool queries</para>
	/// </summary>
	public unsafe partial struct ImGuiIDStackToolPtr
	{
		public ImGuiIDStackTool* NativePtr { get; }
		public ImGuiIDStackToolPtr(ImGuiIDStackTool* nativePtr) => NativePtr = nativePtr;
		public ImGuiIDStackToolPtr(IntPtr nativePtr) => NativePtr = (ImGuiIDStackTool*)nativePtr;
		public static implicit operator ImGuiIDStackToolPtr(ImGuiIDStackTool* nativePtr) => new ImGuiIDStackToolPtr(nativePtr);
		public static implicit operator ImGuiIDStackTool* (ImGuiIDStackToolPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiIDStackToolPtr(IntPtr nativePtr) => new ImGuiIDStackToolPtr(nativePtr);

		public ref int LastActiveFrame => ref Unsafe.AsRef<int>(&NativePtr->LastActiveFrame);

		/// <summary>
		/// -1: query stack and resize Results, &gt;= 0: individual stack level
		/// </summary>
		public ref int StackLevel => ref Unsafe.AsRef<int>(&NativePtr->StackLevel);

		/// <summary>
		/// ID to query details for
		/// </summary>
		public ref uint QueryId => ref Unsafe.AsRef<uint>(&NativePtr->QueryId);

		public ImPtrVector<ImGuiStackLevelInfoPtr> Results => new ImPtrVector<ImGuiStackLevelInfoPtr>(NativePtr->Results, Unsafe.SizeOf<ImGuiStackLevelInfo>());

		public ref bool CopyToClipboardOnCtrlC => ref Unsafe.AsRef<bool>(&NativePtr->CopyToClipboardOnCtrlC);

		public ref float CopyToClipboardLastTime => ref Unsafe.AsRef<float>(&NativePtr->CopyToClipboardLastTime);
	}
}
