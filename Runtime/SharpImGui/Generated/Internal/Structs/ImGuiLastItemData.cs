using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Status storage for the last submitted item<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiLastItemData
	{
		public uint ID;
		/// <summary>
		/// See ImGuiItemFlags_ (called 'InFlags' before v1.91.4).<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// See ImGuiItemStatusFlags_<br/>
		/// </summary>
		public ImGuiItemStatusFlags StatusFlags;
		/// <summary>
		/// Full rectangle<br/>
		/// </summary>
		public ImRect Rect;
		/// <summary>
		/// Navigation scoring rectangle (not displayed)<br/>
		/// </summary>
		public ImRect NavRect;
		/// <summary>
		/// <br/>    Rarely used fields are not explicitly cleared, only valid when the corresponding ImGuiItemStatusFlags are set.<br/>
		/// Display rectangle. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasDisplayRect) is set.<br/>
		/// </summary>
		public ImRect DisplayRect;
		/// <summary>
		/// Clip rectangle at the time of submitting item. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasClipRect) is set..<br/>
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// Shortcut at the time of submitting item. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasShortcut) is set..<br/>
		/// </summary>
		public int Shortcut;
	}

	/// <summary>
	/// Status storage for the last submitted item<br/>
	/// </summary>
	public unsafe partial struct ImGuiLastItemDataPtr
	{
		public ImGuiLastItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiLastItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// See ImGuiItemFlags_ (called 'InFlags' before v1.91.4).<br/>
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);
		/// <summary>
		/// See ImGuiItemStatusFlags_<br/>
		/// </summary>
		public ref ImGuiItemStatusFlags StatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->StatusFlags);
		/// <summary>
		/// Full rectangle<br/>
		/// </summary>
		public ref ImRect Rect => ref Unsafe.AsRef<ImRect>(&NativePtr->Rect);
		/// <summary>
		/// Navigation scoring rectangle (not displayed)<br/>
		/// </summary>
		public ref ImRect NavRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavRect);
		/// <summary>
		/// <br/>    Rarely used fields are not explicitly cleared, only valid when the corresponding ImGuiItemStatusFlags are set.<br/>
		/// Display rectangle. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasDisplayRect) is set.<br/>
		/// </summary>
		public ref ImRect DisplayRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DisplayRect);
		/// <summary>
		/// Clip rectangle at the time of submitting item. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasClipRect) is set..<br/>
		/// </summary>
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
		/// <summary>
		/// Shortcut at the time of submitting item. ONLY VALID IF (StatusFlags & ImGuiItemStatusFlags_HasShortcut) is set..<br/>
		/// </summary>
		public ref int Shortcut => ref Unsafe.AsRef<int>(&NativePtr->Shortcut);
		public ImGuiLastItemDataPtr(ImGuiLastItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiLastItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiLastItemData*)nativePtr;
		public static implicit operator ImGuiLastItemDataPtr(ImGuiLastItemData* ptr) => new ImGuiLastItemDataPtr(ptr);
		public static implicit operator ImGuiLastItemDataPtr(IntPtr ptr) => new ImGuiLastItemDataPtr(ptr);
		public static implicit operator ImGuiLastItemData*(ImGuiLastItemDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiLastItemDataDestroy(NativePtr);
		}

		public void ImGuiLastItemDataConstruct()
		{
			ImGuiNative.ImGuiLastItemDataImGuiLastItemDataConstruct(NativePtr);
		}

		public ImGuiLastItemDataPtr ImGuiLastItemData()
		{
			return ImGuiNative.ImGuiLastItemDataImGuiLastItemData();
		}

	}
}
