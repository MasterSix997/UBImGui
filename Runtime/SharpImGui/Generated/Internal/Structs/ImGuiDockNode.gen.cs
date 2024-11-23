using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>sizeof() 156~192</para>
	/// </summary>
	public unsafe partial struct ImGuiDockNode
	{
		public uint ID;
		/// <summary>
		/// (Write) Flags shared by all nodes of a same dockspace hierarchy (inherited from the root node)
		/// </summary>
		public ImGuiDockNodeFlags SharedFlags;
		/// <summary>
		/// (Write) Flags specific to this node
		/// </summary>
		public ImGuiDockNodeFlags LocalFlags;
		/// <summary>
		/// (Write) Flags specific to this node, applied from windows
		/// </summary>
		public ImGuiDockNodeFlags LocalFlagsInWindows;
		/// <summary>
		/// (Read)  Effective flags (== SharedFlags | LocalFlagsInNode | LocalFlagsInWindows)
		/// </summary>
		public ImGuiDockNodeFlags MergedFlags;
		public ImGuiDockNodeState State;
		public ImGuiDockNode* ParentNode;
		/// <summary>
		/// [Split node only] Child nodes (left/right or top/bottom). Consider switching to an array.
		/// </summary>
		public ImGuiDockNode* ChildNodes_0;
		public ImGuiDockNode* ChildNodes_1;
		/// <summary>
		/// Note: unordered list! Iterate TabBar-&gt;Tabs for user-order.
		/// </summary>
		public ImVector Windows;
		public ImGuiTabBar* TabBar;
		/// <summary>
		/// Current position
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Current size
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// [Split node only] Last explicitly written-to size (overridden when using a splitter affecting the node), used to calculate Size.
		/// </summary>
		public Vector2 SizeRef;
		/// <summary>
		/// [Split node only] Split axis (X or Y)
		/// </summary>
		public ImGuiAxis SplitAxis;
		/// <summary>
		/// [Root node only]
		/// </summary>
		public ImGuiWindowClass WindowClass;
		public uint LastBgColor;
		public ImGuiWindow* HostWindow;
		/// <summary>
		/// Generally point to window which is ID is == SelectedTabID, but when CTRL+Tabbing this can be a different window.
		/// </summary>
		public ImGuiWindow* VisibleWindow;
		/// <summary>
		/// [Root node only] Pointer to central node.
		/// </summary>
		public ImGuiDockNode* CentralNode;
		/// <summary>
		/// [Root node only] Set when there is a single visible node within the hierarchy.
		/// </summary>
		public ImGuiDockNode* OnlyNodeWithWindows;
		/// <summary>
		/// [Root node only]
		/// </summary>
		public int CountNodeWithWindows;
		/// <summary>
		/// Last frame number the node was updated or kept alive explicitly with DockSpace() + ImGuiDockNodeFlags_KeepAliveOnly
		/// </summary>
		public int LastFrameAlive;
		/// <summary>
		/// Last frame number the node was updated.
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last frame number the node was focused.
		/// </summary>
		public int LastFrameFocused;
		/// <summary>
		/// [Root node only] Which of our child docking node (any ancestor in the hierarchy) was last focused.
		/// </summary>
		public uint LastFocusedNodeId;
		/// <summary>
		/// [Leaf node only] Which of our tab/window is selected.
		/// </summary>
		public uint SelectedTabId;
		/// <summary>
		/// [Leaf node only] Set when closing a specific tab/window.
		/// </summary>
		public uint WantCloseTabId;
		/// <summary>
		/// Reference viewport ID from visible window when HostWindow == NULL.
		/// </summary>
		public uint RefViewportId;
		public ImGuiDataAuthority AuthorityForPos;
		public ImGuiDataAuthority AuthorityForSize;
		public ImGuiDataAuthority AuthorityForViewport;
		/// <summary>
		/// Set to false when the node is hidden (usually disabled as it has no active window)
		/// </summary>
		public byte IsVisible;
		public byte IsFocused;
		public byte IsBgDrawnThisFrame;
		/// <summary>
		/// Provide space for a close button (if any of the docked window has one). Note that button may be hidden on window without one.
		/// </summary>
		public byte HasCloseButton;
		public byte HasWindowMenuButton;
		public byte HasCentralNodeChild;
		/// <summary>
		/// Set when closing all tabs at once.
		/// </summary>
		public byte WantCloseAll;
		public byte WantLockSizeOnce;
		/// <summary>
		/// After a node extraction we need to transition toward moving the newly created host window
		/// </summary>
		public byte WantMouseMove;
		public byte WantHiddenTabBarUpdate;
		public byte WantHiddenTabBarToggle;
	}

	/// <summary>
	/// <para>sizeof() 156~192</para>
	/// </summary>
	public unsafe partial struct ImGuiDockNodePtr
	{
		public ImGuiDockNode* NativePtr { get; }
		public ImGuiDockNodePtr(ImGuiDockNode* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockNodePtr(IntPtr nativePtr) => NativePtr = (ImGuiDockNode*)nativePtr;
		public static implicit operator ImGuiDockNodePtr(ImGuiDockNode* nativePtr) => new ImGuiDockNodePtr(nativePtr);
		public static implicit operator ImGuiDockNode* (ImGuiDockNodePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiDockNodePtr(IntPtr nativePtr) => new ImGuiDockNodePtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// (Write) Flags shared by all nodes of a same dockspace hierarchy (inherited from the root node)
		/// </summary>
		public ref ImGuiDockNodeFlags SharedFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->SharedFlags);

		/// <summary>
		/// (Write) Flags specific to this node
		/// </summary>
		public ref ImGuiDockNodeFlags LocalFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->LocalFlags);

		/// <summary>
		/// (Write) Flags specific to this node, applied from windows
		/// </summary>
		public ref ImGuiDockNodeFlags LocalFlagsInWindows => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->LocalFlagsInWindows);

		/// <summary>
		/// (Read)  Effective flags (== SharedFlags | LocalFlagsInNode | LocalFlagsInWindows)
		/// </summary>
		public ref ImGuiDockNodeFlags MergedFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->MergedFlags);

		public ref ImGuiDockNodeState State => ref Unsafe.AsRef<ImGuiDockNodeState>(&NativePtr->State);

		public ImGuiDockNodePtr ParentNode => new ImGuiDockNodePtr(NativePtr->ParentNode);

		/// <summary>
		/// [Split node only] Child nodes (left/right or top/bottom). Consider switching to an array.
		/// </summary>
		public RangeAccessor<ImGuiDockNode> ChildNodes => new RangeAccessor<ImGuiDockNode>(&NativePtr->ChildNodes_0, 2);

		/// <summary>
		/// Note: unordered list! Iterate TabBar-&gt;Tabs for user-order.
		/// </summary>
		public ImVector<ImGuiWindowPtr> Windows => new ImVector<ImGuiWindowPtr>(NativePtr->Windows);

		public ImGuiTabBarPtr TabBar => new ImGuiTabBarPtr(NativePtr->TabBar);

		/// <summary>
		/// Current position
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);

		/// <summary>
		/// Current size
		/// </summary>
		public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);

		/// <summary>
		/// [Split node only] Last explicitly written-to size (overridden when using a splitter affecting the node), used to calculate Size.
		/// </summary>
		public ref Vector2 SizeRef => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeRef);

		/// <summary>
		/// [Split node only] Split axis (X or Y)
		/// </summary>
		public ref ImGuiAxis SplitAxis => ref Unsafe.AsRef<ImGuiAxis>(&NativePtr->SplitAxis);

		/// <summary>
		/// [Root node only]
		/// </summary>
		public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);

		public ref uint LastBgColor => ref Unsafe.AsRef<uint>(&NativePtr->LastBgColor);

		public ImGuiWindowPtr HostWindow => new ImGuiWindowPtr(NativePtr->HostWindow);

		/// <summary>
		/// Generally point to window which is ID is == SelectedTabID, but when CTRL+Tabbing this can be a different window.
		/// </summary>
		public ImGuiWindowPtr VisibleWindow => new ImGuiWindowPtr(NativePtr->VisibleWindow);

		/// <summary>
		/// [Root node only] Pointer to central node.
		/// </summary>
		public ImGuiDockNodePtr CentralNode => new ImGuiDockNodePtr(NativePtr->CentralNode);

		/// <summary>
		/// [Root node only] Set when there is a single visible node within the hierarchy.
		/// </summary>
		public ImGuiDockNodePtr OnlyNodeWithWindows => new ImGuiDockNodePtr(NativePtr->OnlyNodeWithWindows);

		/// <summary>
		/// [Root node only]
		/// </summary>
		public ref int CountNodeWithWindows => ref Unsafe.AsRef<int>(&NativePtr->CountNodeWithWindows);

		/// <summary>
		/// Last frame number the node was updated or kept alive explicitly with DockSpace() + ImGuiDockNodeFlags_KeepAliveOnly
		/// </summary>
		public ref int LastFrameAlive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameAlive);

		/// <summary>
		/// Last frame number the node was updated.
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);

		/// <summary>
		/// Last frame number the node was focused.
		/// </summary>
		public ref int LastFrameFocused => ref Unsafe.AsRef<int>(&NativePtr->LastFrameFocused);

		/// <summary>
		/// [Root node only] Which of our child docking node (any ancestor in the hierarchy) was last focused.
		/// </summary>
		public ref uint LastFocusedNodeId => ref Unsafe.AsRef<uint>(&NativePtr->LastFocusedNodeId);

		/// <summary>
		/// [Leaf node only] Which of our tab/window is selected.
		/// </summary>
		public ref uint SelectedTabId => ref Unsafe.AsRef<uint>(&NativePtr->SelectedTabId);

		/// <summary>
		/// [Leaf node only] Set when closing a specific tab/window.
		/// </summary>
		public ref uint WantCloseTabId => ref Unsafe.AsRef<uint>(&NativePtr->WantCloseTabId);

		/// <summary>
		/// Reference viewport ID from visible window when HostWindow == NULL.
		/// </summary>
		public ref uint RefViewportId => ref Unsafe.AsRef<uint>(&NativePtr->RefViewportId);

		public ref ImGuiDataAuthority AuthorityForPos => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForPos);

		public ref ImGuiDataAuthority AuthorityForSize => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForSize);

		public ref ImGuiDataAuthority AuthorityForViewport => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForViewport);

		/// <summary>
		/// Set to false when the node is hidden (usually disabled as it has no active window)
		/// </summary>
		public ref bool IsVisible => ref Unsafe.AsRef<bool>(&NativePtr->IsVisible);

		public ref bool IsFocused => ref Unsafe.AsRef<bool>(&NativePtr->IsFocused);

		public ref bool IsBgDrawnThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->IsBgDrawnThisFrame);

		/// <summary>
		/// Provide space for a close button (if any of the docked window has one). Note that button may be hidden on window without one.
		/// </summary>
		public ref bool HasCloseButton => ref Unsafe.AsRef<bool>(&NativePtr->HasCloseButton);

		public ref bool HasWindowMenuButton => ref Unsafe.AsRef<bool>(&NativePtr->HasWindowMenuButton);

		public ref bool HasCentralNodeChild => ref Unsafe.AsRef<bool>(&NativePtr->HasCentralNodeChild);

		/// <summary>
		/// Set when closing all tabs at once.
		/// </summary>
		public ref bool WantCloseAll => ref Unsafe.AsRef<bool>(&NativePtr->WantCloseAll);

		public ref bool WantLockSizeOnce => ref Unsafe.AsRef<bool>(&NativePtr->WantLockSizeOnce);

		/// <summary>
		/// After a node extraction we need to transition toward moving the newly created host window
		/// </summary>
		public ref bool WantMouseMove => ref Unsafe.AsRef<bool>(&NativePtr->WantMouseMove);

		public ref bool WantHiddenTabBarUpdate => ref Unsafe.AsRef<bool>(&NativePtr->WantHiddenTabBarUpdate);

		public ref bool WantHiddenTabBarToggle => ref Unsafe.AsRef<bool>(&NativePtr->WantHiddenTabBarToggle);

		public bool IsRootNode()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsRootNode(NativePtr);
			return ret != 0;
		}

		public bool IsDockSpace()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsDockSpace(NativePtr);
			return ret != 0;
		}

		public bool IsFloatingNode()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsFloatingNode(NativePtr);
			return ret != 0;
		}

		public bool IsCentralNode()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsCentralNode(NativePtr);
			return ret != 0;
		}

		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle
		/// </summary>
		public bool IsHiddenTabBar()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsHiddenTabBar(NativePtr);
			return ret != 0;
		}

		/// <summary>
		/// Never show a tab bar
		/// </summary>
		public bool IsNoTabBar()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsNoTabBar(NativePtr);
			return ret != 0;
		}

		public bool IsSplitNode()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsSplitNode(NativePtr);
			return ret != 0;
		}

		public bool IsLeafNode()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsLeafNode(NativePtr);
			return ret != 0;
		}

		public bool IsEmpty()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_IsEmpty(NativePtr);
			return ret != 0;
		}

		public ImRect Rect()
		{
			var ret = ImGuiInternalNative.ImGuiDockNode_Rect(NativePtr);
			return ret;
		}

		public void SetLocalFlags(ImGuiDockNodeFlags flags)
		{
			ImGuiInternalNative.ImGuiDockNode_SetLocalFlags(NativePtr, flags);
		}

		public void UpdateMergedFlags()
		{
			ImGuiInternalNative.ImGuiDockNode_UpdateMergedFlags(NativePtr);
		}
	}
}
