using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Storage for one window</para>
	/// </summary>
	public unsafe partial struct ImGuiWindow
	{
		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).
		/// </summary>
		public ImGuiContext* Ctx;
		/// <summary>
		/// Window name, owned by the window.
		/// </summary>
		public byte* Name;
		/// <summary>
		/// == ImHashStr(Name)
		/// </summary>
		public uint ID;
		/// <summary>
		/// See enum ImGuiWindowFlags_
		/// </summary>
		public ImGuiWindowFlags Flags;
		/// <summary>
		/// See enum ImGuiWindowFlags_
		/// </summary>
		public ImGuiWindowFlags FlagsPreviousFrame;
		/// <summary>
		/// Set when window is a child window. See enum ImGuiChildFlags_
		/// </summary>
		public ImGuiChildFlags ChildFlags;
		/// <summary>
		/// Advanced users only. Set with SetNextWindowClass()
		/// </summary>
		public ImGuiWindowClass WindowClass;
		/// <summary>
		/// Always set in Begin(). Inactive windows may have a NULL value here if their viewport was discarded.
		/// </summary>
		public ImGuiViewportP* Viewport;
		/// <summary>
		/// We backup the viewport id (since the viewport may disappear or never be created if the window is inactive)
		/// </summary>
		public uint ViewportId;
		/// <summary>
		/// We backup the viewport position (since the viewport may disappear or never be created if the window is inactive)
		/// </summary>
		public Vector2 ViewportPos;
		/// <summary>
		/// Reset to -1 every frame (index is guaranteed to be valid between NewFrame..EndFrame), only used in the Appearing frame of a tooltip/popup to enforce clamping to a given monitor
		/// </summary>
		public int ViewportAllowPlatformMonitorExtend;
		/// <summary>
		/// Position (always rounded-up to nearest pixel)
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Current size (==SizeFull or collapsed title bar size)
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// Size when non collapsed
		/// </summary>
		public Vector2 SizeFull;
		/// <summary>
		/// Size of contents/scrollable client area (calculated from the extents reach of the cursor) from previous frame. Does not include window decoration or window padding.
		/// </summary>
		public Vector2 ContentSize;
		public Vector2 ContentSizeIdeal;
		/// <summary>
		/// Size of contents/scrollable client area explicitly request by the user via SetNextWindowContentSize().
		/// </summary>
		public Vector2 ContentSizeExplicit;
		/// <summary>
		/// Window padding at the time of Begin().
		/// </summary>
		public Vector2 WindowPadding;
		/// <summary>
		/// Window rounding at the time of Begin(). May be clamped lower to avoid rendering artifacts with title bar, menu bar etc.
		/// </summary>
		public float WindowRounding;
		/// <summary>
		/// Window border size at the time of Begin().
		/// </summary>
		public float WindowBorderSize;
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.
		/// </summary>
		public float TitleBarHeight;
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.
		/// </summary>
		public float MenuBarHeight;
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().
		/// </summary>
		public float DecoOuterSizeX1;
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().
		/// </summary>
		public float DecoOuterSizeY1;
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).
		/// </summary>
		public float DecoOuterSizeX2;
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).
		/// </summary>
		public float DecoOuterSizeY2;
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).
		/// </summary>
		public float DecoInnerSizeX1;
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).
		/// </summary>
		public float DecoInnerSizeY1;
		/// <summary>
		/// Size of buffer storing Name. May be larger than strlen(Name)!
		/// </summary>
		public int NameBufLen;
		/// <summary>
		/// == window-&gt;GetID("#MOVE")
		/// </summary>
		public uint MoveId;
		/// <summary>
		/// == window-&gt;GetID("#TAB")
		/// </summary>
		public uint TabId;
		/// <summary>
		/// ID of corresponding item in parent window (for navigation to return from child window to parent window)
		/// </summary>
		public uint ChildId;
		/// <summary>
		/// ID in the popup stack when this window is used as a popup/menu (because we use generic Name/ID for recycling)
		/// </summary>
		public uint PopupId;
		public Vector2 Scroll;
		public Vector2 ScrollMax;
		/// <summary>
		/// target scroll position. stored as cursor position with scrolling canceled out, so the highest point is always 0.0f. (FLT_MAX for no change)
		/// </summary>
		public Vector2 ScrollTarget;
		/// <summary>
		/// 0.0f = scroll so that target position is at top, 0.5f = scroll so that target position is centered
		/// </summary>
		public Vector2 ScrollTargetCenterRatio;
		/// <summary>
		/// 0.0f = no snapping, &gt;0.0f snapping threshold
		/// </summary>
		public Vector2 ScrollTargetEdgeSnapDist;
		/// <summary>
		/// Size taken by each scrollbars on their smaller axis. Pay attention! ScrollbarSizes.x == width of the vertical scrollbar, ScrollbarSizes.y = height of the horizontal scrollbar.
		/// </summary>
		public Vector2 ScrollbarSizes;
		/// <summary>
		/// Are scrollbars visible?
		/// </summary>
		public byte ScrollbarX;
		/// <summary>
		/// Are scrollbars visible?
		/// </summary>
		public byte ScrollbarY;
		public byte ViewportOwned;
		/// <summary>
		/// Set to true on Begin(), unless Collapsed
		/// </summary>
		public byte Active;
		public byte WasActive;
		/// <summary>
		/// Set to true when any widget access the current window
		/// </summary>
		public byte WriteAccessed;
		/// <summary>
		/// Set when collapsing window to become only title-bar
		/// </summary>
		public byte Collapsed;
		public byte WantCollapseToggle;
		/// <summary>
		/// Set when items can safely be all clipped (e.g. window not visible or collapsed)
		/// </summary>
		public byte SkipItems;
		/// <summary>
		/// [EXPERIMENTAL] Reuse previous frame drawn contents, Begin() returns false.
		/// </summary>
		public byte SkipRefresh;
		/// <summary>
		/// Set during the frame where the window is appearing (or re-appearing)
		/// </summary>
		public byte Appearing;
		/// <summary>
		/// Do not display (== HiddenFrames*** &gt; 0)
		/// </summary>
		public byte Hidden;
		/// <summary>
		/// Set on the "Debug##Default" window.
		/// </summary>
		public byte IsFallbackWindow;
		/// <summary>
		/// Set when passed _ChildWindow, left to false by BeginDocked()
		/// </summary>
		public byte IsExplicitChild;
		/// <summary>
		/// Set when the window has a close button (p_open != NULL)
		/// </summary>
		public byte HasCloseButton;
		/// <summary>
		/// Current border being hovered for resize (-1: none, otherwise 0-3)
		/// </summary>
		public byte ResizeBorderHovered;
		/// <summary>
		/// Current border being held for resize (-1: none, otherwise 0-3)
		/// </summary>
		public byte ResizeBorderHeld;
		/// <summary>
		/// Number of Begin() during the current frame (generally 0 or 1, 1+ if appending via multiple Begin/End pairs)
		/// </summary>
		public short BeginCount;
		/// <summary>
		/// Number of Begin() during the previous frame
		/// </summary>
		public short BeginCountPreviousFrame;
		/// <summary>
		/// Begin() order within immediate parent window, if we are a child window. Otherwise 0.
		/// </summary>
		public short BeginOrderWithinParent;
		/// <summary>
		/// Begin() order within entire imgui context. This is mostly used for debugging submission order related issues.
		/// </summary>
		public short BeginOrderWithinContext;
		/// <summary>
		/// Order within WindowsFocusOrder[], altered when windows are focused.
		/// </summary>
		public short FocusOrder;
		public sbyte AutoFitFramesX;
		public sbyte AutoFitFramesY;
		public byte AutoFitOnlyGrows;
		public ImGuiDir AutoPosLastDirection;
		/// <summary>
		/// Hide the window for N frames
		/// </summary>
		public sbyte HiddenFramesCanSkipItems;
		/// <summary>
		/// Hide the window for N frames while allowing items to be submitted so we can measure their size
		/// </summary>
		public sbyte HiddenFramesCannotSkipItems;
		/// <summary>
		/// Hide the window until frame N at Render() time only
		/// </summary>
		public sbyte HiddenFramesForRenderOnly;
		/// <summary>
		/// Disable window interactions for N frames
		/// </summary>
		public sbyte DisableInputsFrames;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowPos() use.
		/// </summary>
		public ImGuiCond SetWindowPosAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowSize() use.
		/// </summary>
		public ImGuiCond SetWindowSizeAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowCollapsed() use.
		/// </summary>
		public ImGuiCond SetWindowCollapsedAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowDock() use.
		/// </summary>
		public ImGuiCond SetWindowDockAllowFlags;
		/// <summary>
		/// store window position when using a non-zero Pivot (position set needs to be processed when we know the window size)
		/// </summary>
		public Vector2 SetWindowPosVal;
		/// <summary>
		/// store window pivot for positioning. ImVec2(0, 0) when positioning from top-left corner; ImVec2(0.5f, 0.5f) for centering; ImVec2(1, 1) for bottom right.
		/// </summary>
		public Vector2 SetWindowPosPivot;
		/// <summary>
		/// ID stack. ID are hashes seeded with the value at the top of the stack. (In theory this should be in the TempData structure)
		/// </summary>
		public ImVector IDStack;
		/// <summary>
		/// Temporary per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the "DC" variable name.
		/// </summary>
		public ImGuiWindowTempData DC;
		/// <summary>
		/// <para>The best way to understand what those rectangles are is to use the 'Metrics-&gt;Tools-&gt;Show Windows Rectangles' viewer.</para>
		/// <para>The main 'OuterRect', omitted as a field, is window-&gt;Rect().</para>
		/// </summary>
		/// <summary>
		/// == Window-&gt;Rect() just after setup in Begin(). == window-&gt;Rect() for root window.
		/// </summary>
		public ImRect OuterRectClipped;
		/// <summary>
		/// Inner rectangle (omit title bar, menu bar, scroll bar)
		/// </summary>
		public ImRect InnerRect;
		/// <summary>
		/// == InnerRect shrunk by WindowPadding*0.5f on each side, clipped within viewport or parent clip rect.
		/// </summary>
		public ImRect InnerClipRect;
		/// <summary>
		/// Initially covers the whole scrolling region. Reduced by containers e.g columns/tables when active. Shrunk by WindowPadding*1.0f on each side. This is meant to replace ContentRegionRect over time (from 1.71+ onward).
		/// </summary>
		public ImRect WorkRect;
		/// <summary>
		/// Backup of WorkRect before entering a container such as columns/tables. Used by e.g. SpanAllColumns functions to easily access. Stacked containers are responsible for maintaining this. // FIXME-WORKRECT: Could be a stack?
		/// </summary>
		public ImRect ParentWorkRect;
		/// <summary>
		/// Current clipping/scissoring rectangle, evolve as we are using PushClipRect(), etc. == DrawList-&gt;clip_rect_stack.back().
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// FIXME: This is currently confusing/misleading. It is essentially WorkRect but not handling of scrolling. We currently rely on it as right/bottom aligned sizing operation need some size to rely on.
		/// </summary>
		public ImRect ContentRegionRect;
		/// <summary>
		/// Define an optional rectangular hole where mouse will pass-through the window.
		/// </summary>
		public ImVec2ih HitTestHoleSize;
		public ImVec2ih HitTestHoleOffset;
		/// <summary>
		/// Last frame number the window was Active.
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last frame number the window was made Focused.
		/// </summary>
		public int LastFrameJustFocused;
		/// <summary>
		/// Last timestamp the window was Active (using float as we don't need high precision there)
		/// </summary>
		public float LastTimeActive;
		public float ItemWidthDefault;
		public ImGuiStorage StateStorage;
		public ImVector ColumnsStorage;
		/// <summary>
		/// User scale multiplier per-window, via SetWindowFontScale()
		/// </summary>
		public float FontWindowScale;
		public float FontDpiScale;
		/// <summary>
		/// Offset into SettingsWindows[] (offsets are always valid as we only grow the array from the back)
		/// </summary>
		public int SettingsOffset;
		/// <summary>
		/// == &amp;DrawListInst (for backward compatibility reason with code using imgui_internal.h we keep this a pointer)
		/// </summary>
		public ImDrawList* DrawList;
		public ImDrawList DrawListInst;
		/// <summary>
		/// If we are a child _or_ popup _or_ docked window, this is pointing to our parent. Otherwise NULL.
		/// </summary>
		public ImGuiWindow* ParentWindow;
		public ImGuiWindow* ParentWindowInBeginStack;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Doesn't cross through popups/dock nodes.
		/// </summary>
		public ImGuiWindow* RootWindow;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through popups parent&lt;&gt;child.
		/// </summary>
		public ImGuiWindow* RootWindowPopupTree;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through dock nodes.
		/// </summary>
		public ImGuiWindow* RootWindowDockTree;
		/// <summary>
		/// Point to ourself or first ancestor which will display TitleBgActive color when this window is active.
		/// </summary>
		public ImGuiWindow* RootWindowForTitleBarHighlight;
		/// <summary>
		/// Point to ourself or first ancestor which doesn't have the NavFlattened flag.
		/// </summary>
		public ImGuiWindow* RootWindowForNav;
		/// <summary>
		/// Set to manual link a window to its logical parent so that Shortcut() chain are honoerd (e.g. Tool linked to Document)
		/// </summary>
		public ImGuiWindow* ParentWindowForFocusRoute;
		/// <summary>
		/// When going to the menu bar, we remember the child window we came from. (This could probably be made implicit if we kept g.Windows sorted by last focused including child window.)
		/// </summary>
		public ImGuiWindow* NavLastChildNavWindow;
		/// <summary>
		/// Last known NavId for this window, per layer (0/1)
		/// </summary>
		public fixed uint NavLastIds[2];
		/// <summary>
		/// Reference rectangle, in window relative space
		/// </summary>
		public ImRect NavRectRel_0;
		public ImRect NavRectRel_1;
		/// <summary>
		/// Preferred X/Y position updated when moving on a given axis, reset to FLT_MAX.
		/// </summary>
		public Vector2 NavPreferredScoringPosRel_0;
		public Vector2 NavPreferredScoringPosRel_1;
		/// <summary>
		/// Focus Scope ID at the time of Begin()
		/// </summary>
		public uint NavRootFocusScopeId;
		/// <summary>
		/// Backup of last idx/vtx count, so when waking up the window we can preallocate and avoid iterative alloc/copy
		/// </summary>
		public int MemoryDrawListIdxCapacity;
		public int MemoryDrawListVtxCapacity;
		/// <summary>
		/// Set when window extraneous data have been garbage collected
		/// </summary>
		public byte MemoryCompacted;
		/// <summary>
		/// <para>Docking</para>
		/// </summary>
		/// <summary>
		/// When docking artifacts are actually visible. When this is set, DockNode is guaranteed to be != NULL. ~~ (DockNode != NULL) &amp;&amp; (DockNode-&gt;Windows.Size &gt; 1).
		/// </summary>
		public byte DockIsActive;
		public byte DockNodeIsVisible;
		/// <summary>
		/// Is our window visible this frame? ~~ is the corresponding tab selected?
		/// </summary>
		public byte DockTabIsVisible;
		public byte DockTabWantClose;
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.
		/// </summary>
		public short DockOrder;
		public ImGuiWindowDockStyle DockStyle;
		/// <summary>
		/// Which node are we docked into. Important: Prefer testing DockIsActive in many cases as this will still be set when the dock node is hidden.
		/// </summary>
		public ImGuiDockNode* DockNode;
		/// <summary>
		/// Which node are we owning (for parent windows)
		/// </summary>
		public ImGuiDockNode* DockNodeAsHost;
		/// <summary>
		/// Backup of last valid DockNode-&gt;ID, so single window remember their dock node id even when they are not bound any more
		/// </summary>
		public uint DockId;
		public ImGuiItemStatusFlags DockTabItemStatusFlags;
		public ImRect DockTabItemRect;
	}

	/// <summary>
	/// <para>Storage for one window</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowPtr
	{
		public ImGuiWindow* NativePtr { get; }
		public ImGuiWindowPtr(ImGuiWindow* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindow*)nativePtr;
		public static implicit operator ImGuiWindowPtr(ImGuiWindow* nativePtr) => new ImGuiWindowPtr(nativePtr);
		public static implicit operator ImGuiWindow* (ImGuiWindowPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiWindowPtr(IntPtr nativePtr) => new ImGuiWindowPtr(nativePtr);

		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).
		/// </summary>
		public ImGuiContextPtr Ctx => new ImGuiContextPtr(NativePtr->Ctx);

		/// <summary>
		/// Window name, owned by the window.
		/// </summary>
		public NullTerminatedString Name => new NullTerminatedString(NativePtr->Name);

		/// <summary>
		/// == ImHashStr(Name)
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// See enum ImGuiWindowFlags_
		/// </summary>
		public ref ImGuiWindowFlags Flags => ref Unsafe.AsRef<ImGuiWindowFlags>(&NativePtr->Flags);

		/// <summary>
		/// See enum ImGuiWindowFlags_
		/// </summary>
		public ref ImGuiWindowFlags FlagsPreviousFrame => ref Unsafe.AsRef<ImGuiWindowFlags>(&NativePtr->FlagsPreviousFrame);

		/// <summary>
		/// Set when window is a child window. See enum ImGuiChildFlags_
		/// </summary>
		public ref ImGuiChildFlags ChildFlags => ref Unsafe.AsRef<ImGuiChildFlags>(&NativePtr->ChildFlags);

		/// <summary>
		/// Advanced users only. Set with SetNextWindowClass()
		/// </summary>
		public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);

		/// <summary>
		/// Always set in Begin(). Inactive windows may have a NULL value here if their viewport was discarded.
		/// </summary>
		public ImGuiViewportPPtr Viewport => new ImGuiViewportPPtr(NativePtr->Viewport);

		/// <summary>
		/// We backup the viewport id (since the viewport may disappear or never be created if the window is inactive)
		/// </summary>
		public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);

		/// <summary>
		/// We backup the viewport position (since the viewport may disappear or never be created if the window is inactive)
		/// </summary>
		public ref Vector2 ViewportPos => ref Unsafe.AsRef<Vector2>(&NativePtr->ViewportPos);

		/// <summary>
		/// Reset to -1 every frame (index is guaranteed to be valid between NewFrame..EndFrame), only used in the Appearing frame of a tooltip/popup to enforce clamping to a given monitor
		/// </summary>
		public ref int ViewportAllowPlatformMonitorExtend => ref Unsafe.AsRef<int>(&NativePtr->ViewportAllowPlatformMonitorExtend);

		/// <summary>
		/// Position (always rounded-up to nearest pixel)
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);

		/// <summary>
		/// Current size (==SizeFull or collapsed title bar size)
		/// </summary>
		public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);

		/// <summary>
		/// Size when non collapsed
		/// </summary>
		public ref Vector2 SizeFull => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeFull);

		/// <summary>
		/// Size of contents/scrollable client area (calculated from the extents reach of the cursor) from previous frame. Does not include window decoration or window padding.
		/// </summary>
		public ref Vector2 ContentSize => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSize);

		public ref Vector2 ContentSizeIdeal => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeIdeal);

		/// <summary>
		/// Size of contents/scrollable client area explicitly request by the user via SetNextWindowContentSize().
		/// </summary>
		public ref Vector2 ContentSizeExplicit => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeExplicit);

		/// <summary>
		/// Window padding at the time of Begin().
		/// </summary>
		public ref Vector2 WindowPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowPadding);

		/// <summary>
		/// Window rounding at the time of Begin(). May be clamped lower to avoid rendering artifacts with title bar, menu bar etc.
		/// </summary>
		public ref float WindowRounding => ref Unsafe.AsRef<float>(&NativePtr->WindowRounding);

		/// <summary>
		/// Window border size at the time of Begin().
		/// </summary>
		public ref float WindowBorderSize => ref Unsafe.AsRef<float>(&NativePtr->WindowBorderSize);

		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.
		/// </summary>
		public ref float TitleBarHeight => ref Unsafe.AsRef<float>(&NativePtr->TitleBarHeight);

		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.
		/// </summary>
		public ref float MenuBarHeight => ref Unsafe.AsRef<float>(&NativePtr->MenuBarHeight);

		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().
		/// </summary>
		public ref float DecoOuterSizeX1 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeX1);

		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().
		/// </summary>
		public ref float DecoOuterSizeY1 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeY1);

		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).
		/// </summary>
		public ref float DecoOuterSizeX2 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeX2);

		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).
		/// </summary>
		public ref float DecoOuterSizeY2 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeY2);

		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).
		/// </summary>
		public ref float DecoInnerSizeX1 => ref Unsafe.AsRef<float>(&NativePtr->DecoInnerSizeX1);

		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).
		/// </summary>
		public ref float DecoInnerSizeY1 => ref Unsafe.AsRef<float>(&NativePtr->DecoInnerSizeY1);

		/// <summary>
		/// Size of buffer storing Name. May be larger than strlen(Name)!
		/// </summary>
		public ref int NameBufLen => ref Unsafe.AsRef<int>(&NativePtr->NameBufLen);

		/// <summary>
		/// == window-&gt;GetID("#MOVE")
		/// </summary>
		public ref uint MoveId => ref Unsafe.AsRef<uint>(&NativePtr->MoveId);

		/// <summary>
		/// == window-&gt;GetID("#TAB")
		/// </summary>
		public ref uint TabId => ref Unsafe.AsRef<uint>(&NativePtr->TabId);

		/// <summary>
		/// ID of corresponding item in parent window (for navigation to return from child window to parent window)
		/// </summary>
		public ref uint ChildId => ref Unsafe.AsRef<uint>(&NativePtr->ChildId);

		/// <summary>
		/// ID in the popup stack when this window is used as a popup/menu (because we use generic Name/ID for recycling)
		/// </summary>
		public ref uint PopupId => ref Unsafe.AsRef<uint>(&NativePtr->PopupId);

		public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);

		public ref Vector2 ScrollMax => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollMax);

		/// <summary>
		/// target scroll position. stored as cursor position with scrolling canceled out, so the highest point is always 0.0f. (FLT_MAX for no change)
		/// </summary>
		public ref Vector2 ScrollTarget => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollTarget);

		/// <summary>
		/// 0.0f = scroll so that target position is at top, 0.5f = scroll so that target position is centered
		/// </summary>
		public ref Vector2 ScrollTargetCenterRatio => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollTargetCenterRatio);

		/// <summary>
		/// 0.0f = no snapping, &gt;0.0f snapping threshold
		/// </summary>
		public ref Vector2 ScrollTargetEdgeSnapDist => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollTargetEdgeSnapDist);

		/// <summary>
		/// Size taken by each scrollbars on their smaller axis. Pay attention! ScrollbarSizes.x == width of the vertical scrollbar, ScrollbarSizes.y = height of the horizontal scrollbar.
		/// </summary>
		public ref Vector2 ScrollbarSizes => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollbarSizes);

		/// <summary>
		/// Are scrollbars visible?
		/// </summary>
		public ref bool ScrollbarX => ref Unsafe.AsRef<bool>(&NativePtr->ScrollbarX);

		/// <summary>
		/// Are scrollbars visible?
		/// </summary>
		public ref bool ScrollbarY => ref Unsafe.AsRef<bool>(&NativePtr->ScrollbarY);

		public ref bool ViewportOwned => ref Unsafe.AsRef<bool>(&NativePtr->ViewportOwned);

		/// <summary>
		/// Set to true on Begin(), unless Collapsed
		/// </summary>
		public ref bool Active => ref Unsafe.AsRef<bool>(&NativePtr->Active);

		public ref bool WasActive => ref Unsafe.AsRef<bool>(&NativePtr->WasActive);

		/// <summary>
		/// Set to true when any widget access the current window
		/// </summary>
		public ref bool WriteAccessed => ref Unsafe.AsRef<bool>(&NativePtr->WriteAccessed);

		/// <summary>
		/// Set when collapsing window to become only title-bar
		/// </summary>
		public ref bool Collapsed => ref Unsafe.AsRef<bool>(&NativePtr->Collapsed);

		public ref bool WantCollapseToggle => ref Unsafe.AsRef<bool>(&NativePtr->WantCollapseToggle);

		/// <summary>
		/// Set when items can safely be all clipped (e.g. window not visible or collapsed)
		/// </summary>
		public ref bool SkipItems => ref Unsafe.AsRef<bool>(&NativePtr->SkipItems);

		/// <summary>
		/// [EXPERIMENTAL] Reuse previous frame drawn contents, Begin() returns false.
		/// </summary>
		public ref bool SkipRefresh => ref Unsafe.AsRef<bool>(&NativePtr->SkipRefresh);

		/// <summary>
		/// Set during the frame where the window is appearing (or re-appearing)
		/// </summary>
		public ref bool Appearing => ref Unsafe.AsRef<bool>(&NativePtr->Appearing);

		/// <summary>
		/// Do not display (== HiddenFrames*** &gt; 0)
		/// </summary>
		public ref bool Hidden => ref Unsafe.AsRef<bool>(&NativePtr->Hidden);

		/// <summary>
		/// Set on the "Debug##Default" window.
		/// </summary>
		public ref bool IsFallbackWindow => ref Unsafe.AsRef<bool>(&NativePtr->IsFallbackWindow);

		/// <summary>
		/// Set when passed _ChildWindow, left to false by BeginDocked()
		/// </summary>
		public ref bool IsExplicitChild => ref Unsafe.AsRef<bool>(&NativePtr->IsExplicitChild);

		/// <summary>
		/// Set when the window has a close button (p_open != NULL)
		/// </summary>
		public ref bool HasCloseButton => ref Unsafe.AsRef<bool>(&NativePtr->HasCloseButton);

		/// <summary>
		/// Current border being hovered for resize (-1: none, otherwise 0-3)
		/// </summary>
		public ref bool ResizeBorderHovered => ref Unsafe.AsRef<bool>(&NativePtr->ResizeBorderHovered);

		/// <summary>
		/// Current border being held for resize (-1: none, otherwise 0-3)
		/// </summary>
		public ref bool ResizeBorderHeld => ref Unsafe.AsRef<bool>(&NativePtr->ResizeBorderHeld);

		/// <summary>
		/// Number of Begin() during the current frame (generally 0 or 1, 1+ if appending via multiple Begin/End pairs)
		/// </summary>
		public ref short BeginCount => ref Unsafe.AsRef<short>(&NativePtr->BeginCount);

		/// <summary>
		/// Number of Begin() during the previous frame
		/// </summary>
		public ref short BeginCountPreviousFrame => ref Unsafe.AsRef<short>(&NativePtr->BeginCountPreviousFrame);

		/// <summary>
		/// Begin() order within immediate parent window, if we are a child window. Otherwise 0.
		/// </summary>
		public ref short BeginOrderWithinParent => ref Unsafe.AsRef<short>(&NativePtr->BeginOrderWithinParent);

		/// <summary>
		/// Begin() order within entire imgui context. This is mostly used for debugging submission order related issues.
		/// </summary>
		public ref short BeginOrderWithinContext => ref Unsafe.AsRef<short>(&NativePtr->BeginOrderWithinContext);

		/// <summary>
		/// Order within WindowsFocusOrder[], altered when windows are focused.
		/// </summary>
		public ref short FocusOrder => ref Unsafe.AsRef<short>(&NativePtr->FocusOrder);

		public ref sbyte AutoFitFramesX => ref Unsafe.AsRef<sbyte>(&NativePtr->AutoFitFramesX);

		public ref sbyte AutoFitFramesY => ref Unsafe.AsRef<sbyte>(&NativePtr->AutoFitFramesY);

		public ref bool AutoFitOnlyGrows => ref Unsafe.AsRef<bool>(&NativePtr->AutoFitOnlyGrows);

		public ref ImGuiDir AutoPosLastDirection => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->AutoPosLastDirection);

		/// <summary>
		/// Hide the window for N frames
		/// </summary>
		public ref sbyte HiddenFramesCanSkipItems => ref Unsafe.AsRef<sbyte>(&NativePtr->HiddenFramesCanSkipItems);

		/// <summary>
		/// Hide the window for N frames while allowing items to be submitted so we can measure their size
		/// </summary>
		public ref sbyte HiddenFramesCannotSkipItems => ref Unsafe.AsRef<sbyte>(&NativePtr->HiddenFramesCannotSkipItems);

		/// <summary>
		/// Hide the window until frame N at Render() time only
		/// </summary>
		public ref sbyte HiddenFramesForRenderOnly => ref Unsafe.AsRef<sbyte>(&NativePtr->HiddenFramesForRenderOnly);

		/// <summary>
		/// Disable window interactions for N frames
		/// </summary>
		public ref sbyte DisableInputsFrames => ref Unsafe.AsRef<sbyte>(&NativePtr->DisableInputsFrames);

		/// <summary>
		/// store acceptable condition flags for SetNextWindowPos() use.
		/// </summary>
		public ref ImGuiCond SetWindowPosAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowPosAllowFlags);

		/// <summary>
		/// store acceptable condition flags for SetNextWindowSize() use.
		/// </summary>
		public ref ImGuiCond SetWindowSizeAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowSizeAllowFlags);

		/// <summary>
		/// store acceptable condition flags for SetNextWindowCollapsed() use.
		/// </summary>
		public ref ImGuiCond SetWindowCollapsedAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowCollapsedAllowFlags);

		/// <summary>
		/// store acceptable condition flags for SetNextWindowDock() use.
		/// </summary>
		public ref ImGuiCond SetWindowDockAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowDockAllowFlags);

		/// <summary>
		/// store window position when using a non-zero Pivot (position set needs to be processed when we know the window size)
		/// </summary>
		public ref Vector2 SetWindowPosVal => ref Unsafe.AsRef<Vector2>(&NativePtr->SetWindowPosVal);

		/// <summary>
		/// store window pivot for positioning. ImVec2(0, 0) when positioning from top-left corner; ImVec2(0.5f, 0.5f) for centering; ImVec2(1, 1) for bottom right.
		/// </summary>
		public ref Vector2 SetWindowPosPivot => ref Unsafe.AsRef<Vector2>(&NativePtr->SetWindowPosPivot);

		/// <summary>
		/// ID stack. ID are hashes seeded with the value at the top of the stack. (In theory this should be in the TempData structure)
		/// </summary>
		public ImVector<uint> IDStack => new ImVector<uint>(NativePtr->IDStack);

		/// <summary>
		/// Temporary per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the "DC" variable name.
		/// </summary>
		public ref ImGuiWindowTempData DC => ref Unsafe.AsRef<ImGuiWindowTempData>(&NativePtr->DC);

		/// <summary>
		/// <para>The best way to understand what those rectangles are is to use the 'Metrics-&gt;Tools-&gt;Show Windows Rectangles' viewer.</para>
		/// <para>The main 'OuterRect', omitted as a field, is window-&gt;Rect().</para>
		/// </summary>
		/// <summary>
		/// == Window-&gt;Rect() just after setup in Begin(). == window-&gt;Rect() for root window.
		/// </summary>
		public ref ImRect OuterRectClipped => ref Unsafe.AsRef<ImRect>(&NativePtr->OuterRectClipped);

		/// <summary>
		/// Inner rectangle (omit title bar, menu bar, scroll bar)
		/// </summary>
		public ref ImRect InnerRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerRect);

		/// <summary>
		/// == InnerRect shrunk by WindowPadding*0.5f on each side, clipped within viewport or parent clip rect.
		/// </summary>
		public ref ImRect InnerClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerClipRect);

		/// <summary>
		/// Initially covers the whole scrolling region. Reduced by containers e.g columns/tables when active. Shrunk by WindowPadding*1.0f on each side. This is meant to replace ContentRegionRect over time (from 1.71+ onward).
		/// </summary>
		public ref ImRect WorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->WorkRect);

		/// <summary>
		/// Backup of WorkRect before entering a container such as columns/tables. Used by e.g. SpanAllColumns functions to easily access. Stacked containers are responsible for maintaining this. // FIXME-WORKRECT: Could be a stack?
		/// </summary>
		public ref ImRect ParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ParentWorkRect);

		/// <summary>
		/// Current clipping/scissoring rectangle, evolve as we are using PushClipRect(), etc. == DrawList-&gt;clip_rect_stack.back().
		/// </summary>
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);

		/// <summary>
		/// FIXME: This is currently confusing/misleading. It is essentially WorkRect but not handling of scrolling. We currently rely on it as right/bottom aligned sizing operation need some size to rely on.
		/// </summary>
		public ref ImRect ContentRegionRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ContentRegionRect);

		/// <summary>
		/// Define an optional rectangular hole where mouse will pass-through the window.
		/// </summary>
		public ref ImVec2ih HitTestHoleSize => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->HitTestHoleSize);

		public ref ImVec2ih HitTestHoleOffset => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->HitTestHoleOffset);

		/// <summary>
		/// Last frame number the window was Active.
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);

		/// <summary>
		/// Last frame number the window was made Focused.
		/// </summary>
		public ref int LastFrameJustFocused => ref Unsafe.AsRef<int>(&NativePtr->LastFrameJustFocused);

		/// <summary>
		/// Last timestamp the window was Active (using float as we don't need high precision there)
		/// </summary>
		public ref float LastTimeActive => ref Unsafe.AsRef<float>(&NativePtr->LastTimeActive);

		public ref float ItemWidthDefault => ref Unsafe.AsRef<float>(&NativePtr->ItemWidthDefault);

		public ref ImGuiStorage StateStorage => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->StateStorage);

		public ImPtrVector<ImGuiOldColumnsPtr> ColumnsStorage => new ImPtrVector<ImGuiOldColumnsPtr>(NativePtr->ColumnsStorage, Unsafe.SizeOf<ImGuiOldColumns>());

		/// <summary>
		/// User scale multiplier per-window, via SetWindowFontScale()
		/// </summary>
		public ref float FontWindowScale => ref Unsafe.AsRef<float>(&NativePtr->FontWindowScale);

		public ref float FontDpiScale => ref Unsafe.AsRef<float>(&NativePtr->FontDpiScale);

		/// <summary>
		/// Offset into SettingsWindows[] (offsets are always valid as we only grow the array from the back)
		/// </summary>
		public ref int SettingsOffset => ref Unsafe.AsRef<int>(&NativePtr->SettingsOffset);

		/// <summary>
		/// == &amp;DrawListInst (for backward compatibility reason with code using imgui_internal.h we keep this a pointer)
		/// </summary>
		public ImDrawListPtr DrawList => new ImDrawListPtr(NativePtr->DrawList);

		public ref ImDrawList DrawListInst => ref Unsafe.AsRef<ImDrawList>(&NativePtr->DrawListInst);

		/// <summary>
		/// If we are a child _or_ popup _or_ docked window, this is pointing to our parent. Otherwise NULL.
		/// </summary>
		public ImGuiWindowPtr ParentWindow => new ImGuiWindowPtr(NativePtr->ParentWindow);

		public ImGuiWindowPtr ParentWindowInBeginStack => new ImGuiWindowPtr(NativePtr->ParentWindowInBeginStack);

		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Doesn't cross through popups/dock nodes.
		/// </summary>
		public ImGuiWindowPtr RootWindow => new ImGuiWindowPtr(NativePtr->RootWindow);

		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through popups parent&lt;&gt;child.
		/// </summary>
		public ImGuiWindowPtr RootWindowPopupTree => new ImGuiWindowPtr(NativePtr->RootWindowPopupTree);

		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through dock nodes.
		/// </summary>
		public ImGuiWindowPtr RootWindowDockTree => new ImGuiWindowPtr(NativePtr->RootWindowDockTree);

		/// <summary>
		/// Point to ourself or first ancestor which will display TitleBgActive color when this window is active.
		/// </summary>
		public ImGuiWindowPtr RootWindowForTitleBarHighlight => new ImGuiWindowPtr(NativePtr->RootWindowForTitleBarHighlight);

		/// <summary>
		/// Point to ourself or first ancestor which doesn't have the NavFlattened flag.
		/// </summary>
		public ImGuiWindowPtr RootWindowForNav => new ImGuiWindowPtr(NativePtr->RootWindowForNav);

		/// <summary>
		/// Set to manual link a window to its logical parent so that Shortcut() chain are honoerd (e.g. Tool linked to Document)
		/// </summary>
		public ImGuiWindowPtr ParentWindowForFocusRoute => new ImGuiWindowPtr(NativePtr->ParentWindowForFocusRoute);

		/// <summary>
		/// When going to the menu bar, we remember the child window we came from. (This could probably be made implicit if we kept g.Windows sorted by last focused including child window.)
		/// </summary>
		public ImGuiWindowPtr NavLastChildNavWindow => new ImGuiWindowPtr(NativePtr->NavLastChildNavWindow);

		/// <summary>
		/// Last known NavId for this window, per layer (0/1)
		/// </summary>
		public RangeAccessor<uint> NavLastIds => new RangeAccessor<uint>(NativePtr->NavLastIds, 2);

		/// <summary>
		/// Reference rectangle, in window relative space
		/// </summary>
		public RangeAccessor<ImRect> NavRectRel => new RangeAccessor<ImRect>(&NativePtr->NavRectRel_0, 2);

		/// <summary>
		/// Preferred X/Y position updated when moving on a given axis, reset to FLT_MAX.
		/// </summary>
		public RangeAccessor<Vector2> NavPreferredScoringPosRel => new RangeAccessor<Vector2>(&NativePtr->NavPreferredScoringPosRel_0, 2);

		/// <summary>
		/// Focus Scope ID at the time of Begin()
		/// </summary>
		public ref uint NavRootFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavRootFocusScopeId);

		/// <summary>
		/// Backup of last idx/vtx count, so when waking up the window we can preallocate and avoid iterative alloc/copy
		/// </summary>
		public ref int MemoryDrawListIdxCapacity => ref Unsafe.AsRef<int>(&NativePtr->MemoryDrawListIdxCapacity);

		public ref int MemoryDrawListVtxCapacity => ref Unsafe.AsRef<int>(&NativePtr->MemoryDrawListVtxCapacity);

		/// <summary>
		/// Set when window extraneous data have been garbage collected
		/// </summary>
		public ref bool MemoryCompacted => ref Unsafe.AsRef<bool>(&NativePtr->MemoryCompacted);

		/// <summary>
		/// <para>Docking</para>
		/// </summary>
		/// <summary>
		/// When docking artifacts are actually visible. When this is set, DockNode is guaranteed to be != NULL. ~~ (DockNode != NULL) &amp;&amp; (DockNode-&gt;Windows.Size &gt; 1).
		/// </summary>
		public ref bool DockIsActive => ref Unsafe.AsRef<bool>(&NativePtr->DockIsActive);

		public ref bool DockNodeIsVisible => ref Unsafe.AsRef<bool>(&NativePtr->DockNodeIsVisible);

		/// <summary>
		/// Is our window visible this frame? ~~ is the corresponding tab selected?
		/// </summary>
		public ref bool DockTabIsVisible => ref Unsafe.AsRef<bool>(&NativePtr->DockTabIsVisible);

		public ref bool DockTabWantClose => ref Unsafe.AsRef<bool>(&NativePtr->DockTabWantClose);

		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.
		/// </summary>
		public ref short DockOrder => ref Unsafe.AsRef<short>(&NativePtr->DockOrder);

		public ref ImGuiWindowDockStyle DockStyle => ref Unsafe.AsRef<ImGuiWindowDockStyle>(&NativePtr->DockStyle);

		/// <summary>
		/// Which node are we docked into. Important: Prefer testing DockIsActive in many cases as this will still be set when the dock node is hidden.
		/// </summary>
		public ImGuiDockNodePtr DockNode => new ImGuiDockNodePtr(NativePtr->DockNode);

		/// <summary>
		/// Which node are we owning (for parent windows)
		/// </summary>
		public ImGuiDockNodePtr DockNodeAsHost => new ImGuiDockNodePtr(NativePtr->DockNodeAsHost);

		/// <summary>
		/// Backup of last valid DockNode-&gt;ID, so single window remember their dock node id even when they are not bound any more
		/// </summary>
		public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);

		public ref ImGuiItemStatusFlags DockTabItemStatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->DockTabItemStatusFlags);

		public ref ImRect DockTabItemRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DockTabItemRect);

		/// <summary>
		/// Implied str_end = NULL
		/// </summary>
		public uint GetIDStr(ReadOnlySpan<char> str)
		{
			// Marshaling 'str' to native string
			byte* native_str;
			var str_byteCount = 0;
			if (str != null)
			{
				str_byteCount = Encoding.UTF8.GetByteCount(str);
				if (str_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str = Util.Allocate(str_byteCount + 1);
				}
				else
				{
					var native_str_stackBytes = stackalloc byte[str_byteCount + 1];
					native_str = native_str_stackBytes;
				}
				var str_offset = Util.GetUtf8(str, native_str, str_byteCount);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			var ret = ImGuiInternalNative.ImGuiWindow_GetIDStr(NativePtr, native_str);
			if (str_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str);
			}
			return ret;
		}

		/// <summary>
		/// Implied str_end = NULL
		/// </summary>
		public uint GetIDStr(ReadOnlySpan<char> str, ReadOnlySpan<char> str_end)
		{
			// Marshaling 'str' to native string
			byte* native_str;
			var str_byteCount = 0;
			if (str != null)
			{
				str_byteCount = Encoding.UTF8.GetByteCount(str);
				if (str_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str = Util.Allocate(str_byteCount + 1);
				}
				else
				{
					var native_str_stackBytes = stackalloc byte[str_byteCount + 1];
					native_str = native_str_stackBytes;
				}
				var str_offset = Util.GetUtf8(str, native_str, str_byteCount);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			// Marshaling 'str_end' to native string
			byte* native_str_end;
			var str_end_byteCount = 0;
			if (str_end != null)
			{
				str_end_byteCount = Encoding.UTF8.GetByteCount(str_end);
				if (str_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_end = Util.Allocate(str_end_byteCount + 1);
				}
				else
				{
					var native_str_end_stackBytes = stackalloc byte[str_end_byteCount + 1];
					native_str_end = native_str_end_stackBytes;
				}
				var str_end_offset = Util.GetUtf8(str_end, native_str_end, str_end_byteCount);
				native_str_end[str_end_offset] = 0;
			}
			else native_str_end = null;

			var ret = ImGuiInternalNative.ImGuiWindow_GetIDStrEx(NativePtr, native_str, native_str_end);
			if (str_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str);
			}
			if (str_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_end);
			}
			return ret;
		}

		public uint GetID(IntPtr ptr)
		{
			// Marshaling 'ptr' to native void pointer
			var native_ptr = ptr.ToPointer();

			var ret = ImGuiInternalNative.ImGuiWindow_GetID(NativePtr, native_ptr);
			return ret;
		}

		public uint GetIDInt(int n)
		{
			var ret = ImGuiInternalNative.ImGuiWindow_GetIDInt(NativePtr, n);
			return ret;
		}

		public uint GetIDFromPos(Vector2 p_abs)
		{
			var ret = ImGuiInternalNative.ImGuiWindow_GetIDFromPos(NativePtr, p_abs);
			return ret;
		}

		public uint GetIDFromRectangle(ImRect r_abs)
		{
			var ret = ImGuiInternalNative.ImGuiWindow_GetIDFromRectangle(NativePtr, r_abs);
			return ret;
		}

		/// <summary>
		/// <para>We don't use g.FontSize because the window may be != g.CurrentWindow.</para>
		/// </summary>
		public ImRect Rect()
		{
			var ret = ImGuiInternalNative.ImGuiWindow_Rect(NativePtr);
			return ret;
		}

		public float CalcFontSize()
		{
			var ret = ImGuiInternalNative.ImGuiWindow_CalcFontSize(NativePtr);
			return ret;
		}

		public ImRect TitleBarRect()
		{
			var ret = ImGuiInternalNative.ImGuiWindow_TitleBarRect(NativePtr);
			return ret;
		}

		public ImRect MenuBarRect()
		{
			var ret = ImGuiInternalNative.ImGuiWindow_MenuBarRect(NativePtr);
			return ret;
		}
	}
}
