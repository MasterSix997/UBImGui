using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiOldColumns
	{
		public uint ID;
		public ImGuiOldColumnFlags Flags;
		public byte IsFirstFrame;
		public byte IsBeingResized;
		public int Current;
		public int Count;
		/// <summary>
		/// Offsets from HostWorkRect.Min.x
		/// </summary>
		public float OffMinX;
		/// <summary>
		/// Offsets from HostWorkRect.Min.x
		/// </summary>
		public float OffMaxX;
		public float LineMinY;
		public float LineMaxY;
		/// <summary>
		/// Backup of CursorPos at the time of BeginColumns()
		/// </summary>
		public float HostCursorPosY;
		/// <summary>
		/// Backup of CursorMaxPos at the time of BeginColumns()
		/// </summary>
		public float HostCursorMaxPosX;
		/// <summary>
		/// Backup of ClipRect at the time of BeginColumns()
		/// </summary>
		public ImRect HostInitialClipRect;
		/// <summary>
		/// Backup of ClipRect during PushColumnsBackground()/PopColumnsBackground()
		/// </summary>
		public ImRect HostBackupClipRect;
		/// <summary>
		/// //Backup of WorkRect at the time of BeginColumns()
		/// </summary>
		public ImRect HostBackupParentWorkRect;
		public ImVector Columns;
		public ImDrawListSplitter Splitter;
	}

	public unsafe partial struct ImGuiOldColumnsPtr
	{
		public ImGuiOldColumns* NativePtr { get; }
		public ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => NativePtr = nativePtr;
		public ImGuiOldColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumns*)nativePtr;
		public static implicit operator ImGuiOldColumnsPtr(ImGuiOldColumns* nativePtr) => new ImGuiOldColumnsPtr(nativePtr);
		public static implicit operator ImGuiOldColumns* (ImGuiOldColumnsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiOldColumnsPtr(IntPtr nativePtr) => new ImGuiOldColumnsPtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		public ref ImGuiOldColumnFlags Flags => ref Unsafe.AsRef<ImGuiOldColumnFlags>(&NativePtr->Flags);

		public ref bool IsFirstFrame => ref Unsafe.AsRef<bool>(&NativePtr->IsFirstFrame);

		public ref bool IsBeingResized => ref Unsafe.AsRef<bool>(&NativePtr->IsBeingResized);

		public ref int Current => ref Unsafe.AsRef<int>(&NativePtr->Current);

		public ref int Count => ref Unsafe.AsRef<int>(&NativePtr->Count);

		/// <summary>
		/// Offsets from HostWorkRect.Min.x
		/// </summary>
		public ref float OffMinX => ref Unsafe.AsRef<float>(&NativePtr->OffMinX);

		/// <summary>
		/// Offsets from HostWorkRect.Min.x
		/// </summary>
		public ref float OffMaxX => ref Unsafe.AsRef<float>(&NativePtr->OffMaxX);

		public ref float LineMinY => ref Unsafe.AsRef<float>(&NativePtr->LineMinY);

		public ref float LineMaxY => ref Unsafe.AsRef<float>(&NativePtr->LineMaxY);

		/// <summary>
		/// Backup of CursorPos at the time of BeginColumns()
		/// </summary>
		public ref float HostCursorPosY => ref Unsafe.AsRef<float>(&NativePtr->HostCursorPosY);

		/// <summary>
		/// Backup of CursorMaxPos at the time of BeginColumns()
		/// </summary>
		public ref float HostCursorMaxPosX => ref Unsafe.AsRef<float>(&NativePtr->HostCursorMaxPosX);

		/// <summary>
		/// Backup of ClipRect at the time of BeginColumns()
		/// </summary>
		public ref ImRect HostInitialClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostInitialClipRect);

		/// <summary>
		/// Backup of ClipRect during PushColumnsBackground()/PopColumnsBackground()
		/// </summary>
		public ref ImRect HostBackupClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupClipRect);

		/// <summary>
		/// //Backup of WorkRect at the time of BeginColumns()
		/// </summary>
		public ref ImRect HostBackupParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupParentWorkRect);

		public ImPtrVector<ImGuiOldColumnDataPtr> Columns => new ImPtrVector<ImGuiOldColumnDataPtr>(NativePtr->Columns, Unsafe.SizeOf<ImGuiOldColumnData>());

		public ref ImDrawListSplitter Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->Splitter);
	}
}
