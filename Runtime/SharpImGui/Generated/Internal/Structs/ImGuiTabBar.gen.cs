using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Storage for a tab bar (sizeof() 160 bytes)</para>
	/// </summary>
	public unsafe partial struct ImGuiTabBar
	{
		public ImGuiWindow* Window;
		public ImVector Tabs;
		public ImGuiTabBarFlags Flags;
		/// <summary>
		/// Zero for tab-bars used by docking
		/// </summary>
		public uint ID;
		/// <summary>
		/// Selected tab/window
		/// </summary>
		public uint SelectedTabId;
		/// <summary>
		/// Next selected tab/window. Will also trigger a scrolling animation
		/// </summary>
		public uint NextSelectedTabId;
		/// <summary>
		/// Can occasionally be != SelectedTabId (e.g. when previewing contents for CTRL+TAB preview)
		/// </summary>
		public uint VisibleTabId;
		public int CurrFrameVisible;
		public int PrevFrameVisible;
		public ImRect BarRect;
		public float CurrTabsContentsHeight;
		/// <summary>
		/// Record the height of contents submitted below the tab bar
		/// </summary>
		public float PrevTabsContentsHeight;
		/// <summary>
		/// Actual width of all tabs (locked during layout)
		/// </summary>
		public float WidthAllTabs;
		/// <summary>
		/// Ideal width if all tabs were visible and not clipped
		/// </summary>
		public float WidthAllTabsIdeal;
		public float ScrollingAnim;
		public float ScrollingTarget;
		public float ScrollingTargetDistToVisibility;
		public float ScrollingSpeed;
		public float ScrollingRectMinX;
		public float ScrollingRectMaxX;
		public float SeparatorMinX;
		public float SeparatorMaxX;
		public uint ReorderRequestTabId;
		public short ReorderRequestOffset;
		public sbyte BeginCount;
		public byte WantLayout;
		public byte VisibleTabWasSubmitted;
		/// <summary>
		/// Set to true when a new tab item or button has been added to the tab bar during last frame
		/// </summary>
		public byte TabsAddedNew;
		/// <summary>
		/// Number of tabs submitted this frame.
		/// </summary>
		public short TabsActiveCount;
		/// <summary>
		/// Index of last BeginTabItem() tab for use by EndTabItem()
		/// </summary>
		public short LastTabItemIdx;
		public float ItemSpacingY;
		/// <summary>
		/// style.FramePadding locked at the time of BeginTabBar()
		/// </summary>
		public Vector2 FramePadding;
		public Vector2 BackupCursorPos;
		/// <summary>
		/// For non-docking tab bar we re-append names in a contiguous buffer.
		/// </summary>
		public ImGuiTextBuffer TabsNames;
	}

	/// <summary>
	/// <para>Storage for a tab bar (sizeof() 160 bytes)</para>
	/// </summary>
	public unsafe partial struct ImGuiTabBarPtr
	{
		public ImGuiTabBar* NativePtr { get; }
		public ImGuiTabBarPtr(ImGuiTabBar* nativePtr) => NativePtr = nativePtr;
		public ImGuiTabBarPtr(IntPtr nativePtr) => NativePtr = (ImGuiTabBar*)nativePtr;
		public static implicit operator ImGuiTabBarPtr(ImGuiTabBar* nativePtr) => new ImGuiTabBarPtr(nativePtr);
		public static implicit operator ImGuiTabBar* (ImGuiTabBarPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTabBarPtr(IntPtr nativePtr) => new ImGuiTabBarPtr(nativePtr);

		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		public ImPtrVector<ImGuiTabItemPtr> Tabs => new ImPtrVector<ImGuiTabItemPtr>(NativePtr->Tabs, Unsafe.SizeOf<ImGuiTabItem>());

		public ref ImGuiTabBarFlags Flags => ref Unsafe.AsRef<ImGuiTabBarFlags>(&NativePtr->Flags);

		/// <summary>
		/// Zero for tab-bars used by docking
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// Selected tab/window
		/// </summary>
		public ref uint SelectedTabId => ref Unsafe.AsRef<uint>(&NativePtr->SelectedTabId);

		/// <summary>
		/// Next selected tab/window. Will also trigger a scrolling animation
		/// </summary>
		public ref uint NextSelectedTabId => ref Unsafe.AsRef<uint>(&NativePtr->NextSelectedTabId);

		/// <summary>
		/// Can occasionally be != SelectedTabId (e.g. when previewing contents for CTRL+TAB preview)
		/// </summary>
		public ref uint VisibleTabId => ref Unsafe.AsRef<uint>(&NativePtr->VisibleTabId);

		public ref int CurrFrameVisible => ref Unsafe.AsRef<int>(&NativePtr->CurrFrameVisible);

		public ref int PrevFrameVisible => ref Unsafe.AsRef<int>(&NativePtr->PrevFrameVisible);

		public ref ImRect BarRect => ref Unsafe.AsRef<ImRect>(&NativePtr->BarRect);

		public ref float CurrTabsContentsHeight => ref Unsafe.AsRef<float>(&NativePtr->CurrTabsContentsHeight);

		/// <summary>
		/// Record the height of contents submitted below the tab bar
		/// </summary>
		public ref float PrevTabsContentsHeight => ref Unsafe.AsRef<float>(&NativePtr->PrevTabsContentsHeight);

		/// <summary>
		/// Actual width of all tabs (locked during layout)
		/// </summary>
		public ref float WidthAllTabs => ref Unsafe.AsRef<float>(&NativePtr->WidthAllTabs);

		/// <summary>
		/// Ideal width if all tabs were visible and not clipped
		/// </summary>
		public ref float WidthAllTabsIdeal => ref Unsafe.AsRef<float>(&NativePtr->WidthAllTabsIdeal);

		public ref float ScrollingAnim => ref Unsafe.AsRef<float>(&NativePtr->ScrollingAnim);

		public ref float ScrollingTarget => ref Unsafe.AsRef<float>(&NativePtr->ScrollingTarget);

		public ref float ScrollingTargetDistToVisibility => ref Unsafe.AsRef<float>(&NativePtr->ScrollingTargetDistToVisibility);

		public ref float ScrollingSpeed => ref Unsafe.AsRef<float>(&NativePtr->ScrollingSpeed);

		public ref float ScrollingRectMinX => ref Unsafe.AsRef<float>(&NativePtr->ScrollingRectMinX);

		public ref float ScrollingRectMaxX => ref Unsafe.AsRef<float>(&NativePtr->ScrollingRectMaxX);

		public ref float SeparatorMinX => ref Unsafe.AsRef<float>(&NativePtr->SeparatorMinX);

		public ref float SeparatorMaxX => ref Unsafe.AsRef<float>(&NativePtr->SeparatorMaxX);

		public ref uint ReorderRequestTabId => ref Unsafe.AsRef<uint>(&NativePtr->ReorderRequestTabId);

		public ref short ReorderRequestOffset => ref Unsafe.AsRef<short>(&NativePtr->ReorderRequestOffset);

		public ref sbyte BeginCount => ref Unsafe.AsRef<sbyte>(&NativePtr->BeginCount);

		public ref bool WantLayout => ref Unsafe.AsRef<bool>(&NativePtr->WantLayout);

		public ref bool VisibleTabWasSubmitted => ref Unsafe.AsRef<bool>(&NativePtr->VisibleTabWasSubmitted);

		/// <summary>
		/// Set to true when a new tab item or button has been added to the tab bar during last frame
		/// </summary>
		public ref bool TabsAddedNew => ref Unsafe.AsRef<bool>(&NativePtr->TabsAddedNew);

		/// <summary>
		/// Number of tabs submitted this frame.
		/// </summary>
		public ref short TabsActiveCount => ref Unsafe.AsRef<short>(&NativePtr->TabsActiveCount);

		/// <summary>
		/// Index of last BeginTabItem() tab for use by EndTabItem()
		/// </summary>
		public ref short LastTabItemIdx => ref Unsafe.AsRef<short>(&NativePtr->LastTabItemIdx);

		public ref float ItemSpacingY => ref Unsafe.AsRef<float>(&NativePtr->ItemSpacingY);

		/// <summary>
		/// style.FramePadding locked at the time of BeginTabBar()
		/// </summary>
		public ref Vector2 FramePadding => ref Unsafe.AsRef<Vector2>(&NativePtr->FramePadding);

		public ref Vector2 BackupCursorPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorPos);

		/// <summary>
		/// For non-docking tab bar we re-append names in a contiguous buffer.
		/// </summary>
		public ref ImGuiTextBuffer TabsNames => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->TabsNames);
	}
}
