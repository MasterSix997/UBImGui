using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Status storage for the last submitted item</para>
	/// </summary>
	public unsafe partial struct ImGuiLastItemData
	{
		public uint ID;
		/// <summary>
		/// See ImGuiItemFlags_
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// See ImGuiItemStatusFlags_
		/// </summary>
		public ImGuiItemStatusFlags StatusFlags;
		/// <summary>
		/// Full rectangle
		/// </summary>
		public ImRect Rect;
		/// <summary>
		/// Navigation scoring rectangle (not displayed)
		/// </summary>
		public ImRect NavRect;
		/// <summary>
		/// <para>Rarely used fields are not explicitly cleared, only valid when the corresponding ImGuiItemStatusFlags ar set.</para>
		/// </summary>
		/// <summary>
		/// Display rectangle. ONLY VALID IF (StatusFlags &amp; ImGuiItemStatusFlags_HasDisplayRect) is set.
		/// </summary>
		public ImRect DisplayRect;
		/// <summary>
		/// Clip rectangle at the time of submitting item. ONLY VALID IF (StatusFlags &amp; ImGuiItemStatusFlags_HasClipRect) is set..
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// Shortcut at the time of submitting item. ONLY VALID IF (StatusFlags &amp; ImGuiItemStatusFlags_HasShortcut) is set..
		/// </summary>
		public ImGuiKey Shortcut;
	}

	/// <summary>
	/// <para>Status storage for the last submitted item</para>
	/// </summary>
	public unsafe partial struct ImGuiLastItemDataPtr
	{
		public ImGuiLastItemData* NativePtr { get; }
		public ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiLastItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiLastItemData*)nativePtr;
		public static implicit operator ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => new ImGuiLastItemDataPtr(nativePtr);
		public static implicit operator ImGuiLastItemData* (ImGuiLastItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiLastItemDataPtr(IntPtr nativePtr) => new ImGuiLastItemDataPtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// See ImGuiItemFlags_
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);

		/// <summary>
		/// See ImGuiItemStatusFlags_
		/// </summary>
		public ref ImGuiItemStatusFlags StatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->StatusFlags);

		/// <summary>
		/// Full rectangle
		/// </summary>
		public ref ImRect Rect => ref Unsafe.AsRef<ImRect>(&NativePtr->Rect);

		/// <summary>
		/// Navigation scoring rectangle (not displayed)
		/// </summary>
		public ref ImRect NavRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavRect);

		/// <summary>
		/// <para>Rarely used fields are not explicitly cleared, only valid when the corresponding ImGuiItemStatusFlags ar set.</para>
		/// </summary>
		/// <summary>
		/// Display rectangle. ONLY VALID IF (StatusFlags &amp; ImGuiItemStatusFlags_HasDisplayRect) is set.
		/// </summary>
		public ref ImRect DisplayRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DisplayRect);

		/// <summary>
		/// Clip rectangle at the time of submitting item. ONLY VALID IF (StatusFlags &amp; ImGuiItemStatusFlags_HasClipRect) is set..
		/// </summary>
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);

		/// <summary>
		/// Shortcut at the time of submitting item. ONLY VALID IF (StatusFlags &amp; ImGuiItemStatusFlags_HasShortcut) is set..
		/// </summary>
		public ref ImGuiKey Shortcut => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->Shortcut);
	}
}
