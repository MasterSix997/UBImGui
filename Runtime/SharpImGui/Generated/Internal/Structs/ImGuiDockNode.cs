using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() 156~192<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockNode
	{
		public uint ID;
		/// <summary>
		/// (Write) Flags shared by all nodes of a same dockspace hierarchy (inherited from the root node)<br/>
		/// </summary>
		public ImGuiDockNodeFlags SharedFlags;
		/// <summary>
		/// (Write) Flags specific to this node<br/>
		/// </summary>
		public ImGuiDockNodeFlags LocalFlags;
		/// <summary>
		/// (Write) Flags specific to this node, applied from windows<br/>
		/// </summary>
		public ImGuiDockNodeFlags LocalFlagsInWindows;
		/// <summary>
		/// (Read)  Effective flags (== SharedFlags | LocalFlagsInNode | LocalFlagsInWindows)<br/>
		/// </summary>
		public ImGuiDockNodeFlags MergedFlags;
		public ImGuiDockNodeState State;
		public unsafe ImGuiDockNode* ParentNode;
		/// <summary>
		/// [Split node only] Child nodes (left/right or top/bottom). Consider switching to an array.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* ChildNodes_0;
		public unsafe ImGuiDockNode* ChildNodes_1;
		/// <summary>
		/// Note: unordered list! Iterate TabBar-&gt;Tabs for user-order.<br/>
		/// </summary>
		public ImVector<ImGuiWindowPtr> Windows;
		public unsafe ImGuiTabBar* TabBar;
		/// <summary>
		/// Current position<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Current size<br/>
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// [Split node only] Last explicitly written-to size (overridden when using a splitter affecting the node), used to calculate Size.<br/>
		/// </summary>
		public Vector2 SizeRef;
		/// <summary>
		/// [Split node only] Split axis (X or Y)<br/>
		/// </summary>
		public ImGuiAxis SplitAxis;
		/// <summary>
		/// [Root node only]<br/>
		/// </summary>
		public ImGuiWindowClass WindowClass;
		public uint LastBgColor;
		public unsafe ImGuiWindow* HostWindow;
		/// <summary>
		/// Generally point to window which is ID is == SelectedTabID, but when CTRL+Tabbing this can be a different window.<br/>
		/// </summary>
		public unsafe ImGuiWindow* VisibleWindow;
		/// <summary>
		/// [Root node only] Pointer to central node.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* CentralNode;
		/// <summary>
		/// [Root node only] Set when there is a single visible node within the hierarchy.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* OnlyNodeWithWindows;
		/// <summary>
		/// [Root node only]<br/>
		/// </summary>
		public int CountNodeWithWindows;
		/// <summary>
		/// Last frame number the node was updated or kept alive explicitly with DockSpace() + ImGuiDockNodeFlags_KeepAliveOnly<br/>
		/// </summary>
		public int LastFrameAlive;
		/// <summary>
		/// Last frame number the node was updated.<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last frame number the node was focused.<br/>
		/// </summary>
		public int LastFrameFocused;
		/// <summary>
		/// [Root node only] Which of our child docking node (any ancestor in the hierarchy) was last focused.<br/>
		/// </summary>
		public uint LastFocusedNodeId;
		/// <summary>
		/// [Leaf node only] Which of our tab/window is selected.<br/>
		/// </summary>
		public uint SelectedTabId;
		/// <summary>
		/// [Leaf node only] Set when closing a specific tab/window.<br/>
		/// </summary>
		public uint WantCloseTabId;
		/// <summary>
		/// Reference viewport ID from visible window when HostWindow == NULL.<br/>
		/// </summary>
		public uint RefViewportId;
		public ImGuiDataAuthority AuthorityForPos;
		public ImGuiDataAuthority AuthorityForSize;
		public ImGuiDataAuthority AuthorityForViewport;
		/// <summary>
		/// Set to false when the node is hidden (usually disabled as it has no active window)<br/>
		/// </summary>
		public byte IsVisible;
		public byte IsFocused;
		public byte IsBgDrawnThisFrame;
		/// <summary>
		/// Provide space for a close button (if any of the docked window has one). Note that button may be hidden on window without one.<br/>
		/// </summary>
		public byte HasCloseButton;
		public byte HasWindowMenuButton;
		public byte HasCentralNodeChild;
		/// <summary>
		/// Set when closing all tabs at once.<br/>
		/// </summary>
		public byte WantCloseAll;
		public byte WantLockSizeOnce;
		/// <summary>
		/// After a node extraction we need to transition toward moving the newly created host window<br/>
		/// </summary>
		public byte WantMouseMove;
		public byte WantHiddenTabBarUpdate;
		public byte WantHiddenTabBarToggle;
	}

	/// <summary>
	/// sizeof() 156~192<br/>
	/// </summary>
	public unsafe partial struct ImGuiDockNodePtr
	{
		public ImGuiDockNode* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDockNode this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// (Write) Flags shared by all nodes of a same dockspace hierarchy (inherited from the root node)<br/>
		/// </summary>
		public ref ImGuiDockNodeFlags SharedFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->SharedFlags);
		/// <summary>
		/// (Write) Flags specific to this node<br/>
		/// </summary>
		public ref ImGuiDockNodeFlags LocalFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->LocalFlags);
		/// <summary>
		/// (Write) Flags specific to this node, applied from windows<br/>
		/// </summary>
		public ref ImGuiDockNodeFlags LocalFlagsInWindows => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->LocalFlagsInWindows);
		/// <summary>
		/// (Read)  Effective flags (== SharedFlags | LocalFlagsInNode | LocalFlagsInWindows)<br/>
		/// </summary>
		public ref ImGuiDockNodeFlags MergedFlags => ref Unsafe.AsRef<ImGuiDockNodeFlags>(&NativePtr->MergedFlags);
		public ref ImGuiDockNodeState State => ref Unsafe.AsRef<ImGuiDockNodeState>(&NativePtr->State);
		public ref ImGuiDockNodePtr ParentNode => ref Unsafe.AsRef<ImGuiDockNodePtr>(&NativePtr->ParentNode);
		/// <summary>
		/// [Split node only] Child nodes (left/right or top/bottom). Consider switching to an array.<br/>
		/// </summary>
		public Span<ImPointer<ImGuiDockNode>> ChildNodes => new Span<ImPointer<ImGuiDockNode>>(&NativePtr->ChildNodes_0, 2);
		/// <summary>
		/// Note: unordered list! Iterate TabBar-&gt;Tabs for user-order.<br/>
		/// </summary>
		public ref ImVector<ImGuiWindowPtr> Windows => ref Unsafe.AsRef<ImVector<ImGuiWindowPtr>>(&NativePtr->Windows);
		public ref ImGuiTabBarPtr TabBar => ref Unsafe.AsRef<ImGuiTabBarPtr>(&NativePtr->TabBar);
		/// <summary>
		/// Current position<br/>
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
		/// <summary>
		/// Current size<br/>
		/// </summary>
		public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);
		/// <summary>
		/// [Split node only] Last explicitly written-to size (overridden when using a splitter affecting the node), used to calculate Size.<br/>
		/// </summary>
		public ref Vector2 SizeRef => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeRef);
		/// <summary>
		/// [Split node only] Split axis (X or Y)<br/>
		/// </summary>
		public ref ImGuiAxis SplitAxis => ref Unsafe.AsRef<ImGuiAxis>(&NativePtr->SplitAxis);
		/// <summary>
		/// [Root node only]<br/>
		/// </summary>
		public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);
		public ref uint LastBgColor => ref Unsafe.AsRef<uint>(&NativePtr->LastBgColor);
		public ref ImGuiWindowPtr HostWindow => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->HostWindow);
		/// <summary>
		/// Generally point to window which is ID is == SelectedTabID, but when CTRL+Tabbing this can be a different window.<br/>
		/// </summary>
		public ref ImGuiWindowPtr VisibleWindow => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->VisibleWindow);
		/// <summary>
		/// [Root node only] Pointer to central node.<br/>
		/// </summary>
		public ref ImGuiDockNodePtr CentralNode => ref Unsafe.AsRef<ImGuiDockNodePtr>(&NativePtr->CentralNode);
		/// <summary>
		/// [Root node only] Set when there is a single visible node within the hierarchy.<br/>
		/// </summary>
		public ref ImGuiDockNodePtr OnlyNodeWithWindows => ref Unsafe.AsRef<ImGuiDockNodePtr>(&NativePtr->OnlyNodeWithWindows);
		/// <summary>
		/// [Root node only]<br/>
		/// </summary>
		public ref int CountNodeWithWindows => ref Unsafe.AsRef<int>(&NativePtr->CountNodeWithWindows);
		/// <summary>
		/// Last frame number the node was updated or kept alive explicitly with DockSpace() + ImGuiDockNodeFlags_KeepAliveOnly<br/>
		/// </summary>
		public ref int LastFrameAlive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameAlive);
		/// <summary>
		/// Last frame number the node was updated.<br/>
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
		/// <summary>
		/// Last frame number the node was focused.<br/>
		/// </summary>
		public ref int LastFrameFocused => ref Unsafe.AsRef<int>(&NativePtr->LastFrameFocused);
		/// <summary>
		/// [Root node only] Which of our child docking node (any ancestor in the hierarchy) was last focused.<br/>
		/// </summary>
		public ref uint LastFocusedNodeId => ref Unsafe.AsRef<uint>(&NativePtr->LastFocusedNodeId);
		/// <summary>
		/// [Leaf node only] Which of our tab/window is selected.<br/>
		/// </summary>
		public ref uint SelectedTabId => ref Unsafe.AsRef<uint>(&NativePtr->SelectedTabId);
		/// <summary>
		/// [Leaf node only] Set when closing a specific tab/window.<br/>
		/// </summary>
		public ref uint WantCloseTabId => ref Unsafe.AsRef<uint>(&NativePtr->WantCloseTabId);
		/// <summary>
		/// Reference viewport ID from visible window when HostWindow == NULL.<br/>
		/// </summary>
		public ref uint RefViewportId => ref Unsafe.AsRef<uint>(&NativePtr->RefViewportId);
		public ref ImGuiDataAuthority AuthorityForPos => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForPos);
		public ref ImGuiDataAuthority AuthorityForSize => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForSize);
		public ref ImGuiDataAuthority AuthorityForViewport => ref Unsafe.AsRef<ImGuiDataAuthority>(&NativePtr->AuthorityForViewport);
		/// <summary>
		/// Set to false when the node is hidden (usually disabled as it has no active window)<br/>
		/// </summary>
		public ref bool IsVisible => ref Unsafe.AsRef<bool>(&NativePtr->IsVisible);
		public ref bool IsFocused => ref Unsafe.AsRef<bool>(&NativePtr->IsFocused);
		public ref bool IsBgDrawnThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->IsBgDrawnThisFrame);
		/// <summary>
		/// Provide space for a close button (if any of the docked window has one). Note that button may be hidden on window without one.<br/>
		/// </summary>
		public ref bool HasCloseButton => ref Unsafe.AsRef<bool>(&NativePtr->HasCloseButton);
		public ref bool HasWindowMenuButton => ref Unsafe.AsRef<bool>(&NativePtr->HasWindowMenuButton);
		public ref bool HasCentralNodeChild => ref Unsafe.AsRef<bool>(&NativePtr->HasCentralNodeChild);
		/// <summary>
		/// Set when closing all tabs at once.<br/>
		/// </summary>
		public ref bool WantCloseAll => ref Unsafe.AsRef<bool>(&NativePtr->WantCloseAll);
		public ref bool WantLockSizeOnce => ref Unsafe.AsRef<bool>(&NativePtr->WantLockSizeOnce);
		/// <summary>
		/// After a node extraction we need to transition toward moving the newly created host window<br/>
		/// </summary>
		public ref bool WantMouseMove => ref Unsafe.AsRef<bool>(&NativePtr->WantMouseMove);
		public ref bool WantHiddenTabBarUpdate => ref Unsafe.AsRef<bool>(&NativePtr->WantHiddenTabBarUpdate);
		public ref bool WantHiddenTabBarToggle => ref Unsafe.AsRef<bool>(&NativePtr->WantHiddenTabBarToggle);
		public ImGuiDockNodePtr(ImGuiDockNode* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockNodePtr(IntPtr nativePtr) => NativePtr = (ImGuiDockNode*)nativePtr;
		public static implicit operator ImGuiDockNodePtr(ImGuiDockNode* ptr) => new ImGuiDockNodePtr(ptr);
		public static implicit operator ImGuiDockNodePtr(IntPtr ptr) => new ImGuiDockNodePtr(ptr);
		public static implicit operator ImGuiDockNode*(ImGuiDockNodePtr nativePtr) => nativePtr.NativePtr;
		public void UpdateMergedFlags()
		{
			ImGuiNative.ImGuiDockNodeUpdateMergedFlags(NativePtr);
		}

		public void SetLocalFlags(ImGuiDockNodeFlags flags)
		{
			ImGuiNative.ImGuiDockNodeSetLocalFlags(NativePtr, flags);
		}

		public void Rect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiDockNodeRect(pOut, NativePtr);
		}

		public bool IsEmpty()
		{
			var result = ImGuiNative.ImGuiDockNodeIsEmpty(NativePtr);
			return result != 0;
		}

		public bool IsLeafNode()
		{
			var result = ImGuiNative.ImGuiDockNodeIsLeafNode(NativePtr);
			return result != 0;
		}

		public bool IsSplitNode()
		{
			var result = ImGuiNative.ImGuiDockNodeIsSplitNode(NativePtr);
			return result != 0;
		}

		/// <summary>
		/// Never show a tab bar<br/>
		/// </summary>
		public bool IsNoTabBar()
		{
			var result = ImGuiNative.ImGuiDockNodeIsNoTabBar(NativePtr);
			return result != 0;
		}

		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle<br/>
		/// </summary>
		public bool IsHiddenTabBar()
		{
			var result = ImGuiNative.ImGuiDockNodeIsHiddenTabBar(NativePtr);
			return result != 0;
		}

		public bool IsCentralNode()
		{
			var result = ImGuiNative.ImGuiDockNodeIsCentralNode(NativePtr);
			return result != 0;
		}

		public bool IsFloatingNode()
		{
			var result = ImGuiNative.ImGuiDockNodeIsFloatingNode(NativePtr);
			return result != 0;
		}

		public bool IsDockSpace()
		{
			var result = ImGuiNative.ImGuiDockNodeIsDockSpace(NativePtr);
			return result != 0;
		}

		public bool IsRootNode()
		{
			var result = ImGuiNative.ImGuiDockNodeIsRootNode(NativePtr);
			return result != 0;
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiDockNodeDestroy(NativePtr);
		}

		public void ImGuiDockNodeConstruct(uint id)
		{
			ImGuiNative.ImGuiDockNodeImGuiDockNodeConstruct(NativePtr, id);
		}

		public ImGuiDockNodePtr ImGuiDockNode(uint id)
		{
			return ImGuiNative.ImGuiDockNodeImGuiDockNode(id);
		}

	}
}
