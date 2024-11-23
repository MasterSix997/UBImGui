using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Per-instance data that needs preserving across frames (seemingly most others do not need to be preserved aside from debug needs. Does that means they could be moved to ImGuiTableTempData?)</para>
	/// <para>sizeof() ~ 24 bytes</para>
	/// </summary>
	public unsafe partial struct ImGuiTableInstanceData
	{
		public uint TableInstanceID;
		/// <summary>
		/// Outer height from last frame
		/// </summary>
		public float LastOuterHeight;
		/// <summary>
		/// Height of first consecutive header rows from last frame (FIXME: this is used assuming consecutive headers are in same frozen set)
		/// </summary>
		public float LastTopHeadersRowHeight;
		/// <summary>
		/// Height of frozen section from last frame
		/// </summary>
		public float LastFrozenHeight;
		/// <summary>
		/// Index of row which was hovered last frame.
		/// </summary>
		public int HoveredRowLast;
		/// <summary>
		/// Index of row hovered this frame, set after encountering it.
		/// </summary>
		public int HoveredRowNext;
	}

	/// <summary>
	/// <para>Per-instance data that needs preserving across frames (seemingly most others do not need to be preserved aside from debug needs. Does that means they could be moved to ImGuiTableTempData?)</para>
	/// <para>sizeof() ~ 24 bytes</para>
	/// </summary>
	public unsafe partial struct ImGuiTableInstanceDataPtr
	{
		public ImGuiTableInstanceData* NativePtr { get; }
		public ImGuiTableInstanceDataPtr(ImGuiTableInstanceData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableInstanceDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableInstanceData*)nativePtr;
		public static implicit operator ImGuiTableInstanceDataPtr(ImGuiTableInstanceData* nativePtr) => new ImGuiTableInstanceDataPtr(nativePtr);
		public static implicit operator ImGuiTableInstanceData* (ImGuiTableInstanceDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableInstanceDataPtr(IntPtr nativePtr) => new ImGuiTableInstanceDataPtr(nativePtr);

		public ref uint TableInstanceID => ref Unsafe.AsRef<uint>(&NativePtr->TableInstanceID);

		/// <summary>
		/// Outer height from last frame
		/// </summary>
		public ref float LastOuterHeight => ref Unsafe.AsRef<float>(&NativePtr->LastOuterHeight);

		/// <summary>
		/// Height of first consecutive header rows from last frame (FIXME: this is used assuming consecutive headers are in same frozen set)
		/// </summary>
		public ref float LastTopHeadersRowHeight => ref Unsafe.AsRef<float>(&NativePtr->LastTopHeadersRowHeight);

		/// <summary>
		/// Height of frozen section from last frame
		/// </summary>
		public ref float LastFrozenHeight => ref Unsafe.AsRef<float>(&NativePtr->LastFrozenHeight);

		/// <summary>
		/// Index of row which was hovered last frame.
		/// </summary>
		public ref int HoveredRowLast => ref Unsafe.AsRef<int>(&NativePtr->HoveredRowLast);

		/// <summary>
		/// Index of row hovered this frame, set after encountering it.
		/// </summary>
		public ref int HoveredRowNext => ref Unsafe.AsRef<int>(&NativePtr->HoveredRowNext);
	}
}
