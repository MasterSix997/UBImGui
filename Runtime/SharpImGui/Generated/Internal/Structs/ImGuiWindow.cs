using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for one window<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindow
	{
		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public unsafe ImGuiContext* Ctx;
		/// <summary>
		/// Window name, owned by the window.<br/>
		/// </summary>
		public unsafe byte* Name;
		/// <summary>
		/// == ImHashStr(Name)<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// See enum ImGuiWindowFlags_<br/>
		/// </summary>
		public ImGuiWindowFlags Flags;
		/// <summary>
		/// See enum ImGuiWindowFlags_<br/>
		/// </summary>
		public ImGuiWindowFlags FlagsPreviousFrame;
		/// <summary>
		/// Set when window is a child window. See enum ImGuiChildFlags_<br/>
		/// </summary>
		public ImGuiChildFlags ChildFlags;
		/// <summary>
		/// Advanced users only. Set with SetNextWindowClass()<br/>
		/// </summary>
		public ImGuiWindowClass WindowClass;
		/// <summary>
		/// Always set in Begin(). Inactive windows may have a NULL value here if their viewport was discarded.<br/>
		/// </summary>
		public unsafe ImGuiViewportP* Viewport;
		/// <summary>
		/// We backup the viewport id (since the viewport may disappear or never be created if the window is inactive)<br/>
		/// </summary>
		public uint ViewportId;
		/// <summary>
		/// We backup the viewport position (since the viewport may disappear or never be created if the window is inactive)<br/>
		/// </summary>
		public Vector2 ViewportPos;
		/// <summary>
		/// Reset to -1 every frame (index is guaranteed to be valid between NewFrame..EndFrame), only used in the Appearing frame of a tooltip/popup to enforce clamping to a given monitor<br/>
		/// </summary>
		public int ViewportAllowPlatformMonitorExtend;
		/// <summary>
		/// Position (always rounded-up to nearest pixel)<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Current size (==SizeFull or collapsed title bar size)<br/>
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// Size when non collapsed<br/>
		/// </summary>
		public Vector2 SizeFull;
		/// <summary>
		/// Size of contents/scrollable client area (calculated from the extents reach of the cursor) from previous frame. Does not include window decoration or window padding.<br/>
		/// </summary>
		public Vector2 ContentSize;
		public Vector2 ContentSizeIdeal;
		/// <summary>
		/// Size of contents/scrollable client area explicitly request by the user via SetNextWindowContentSize().<br/>
		/// </summary>
		public Vector2 ContentSizeExplicit;
		/// <summary>
		/// Window padding at the time of Begin().<br/>
		/// </summary>
		public Vector2 WindowPadding;
		/// <summary>
		/// Window rounding at the time of Begin(). May be clamped lower to avoid rendering artifacts with title bar, menu bar etc.<br/>
		/// </summary>
		public float WindowRounding;
		/// <summary>
		/// Window border size at the time of Begin().<br/>
		/// </summary>
		public float WindowBorderSize;
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.<br/>
		/// </summary>
		public float TitleBarHeight;
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.<br/>
		/// </summary>
		public float MenuBarHeight;
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().<br/>
		/// </summary>
		public float DecoOuterSizeX1;
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().<br/>
		/// </summary>
		public float DecoOuterSizeY1;
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).<br/>
		/// </summary>
		public float DecoOuterSizeX2;
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).<br/>
		/// </summary>
		public float DecoOuterSizeY2;
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).<br/>
		/// </summary>
		public float DecoInnerSizeX1;
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).<br/>
		/// </summary>
		public float DecoInnerSizeY1;
		/// <summary>
		/// Size of buffer storing Name. May be larger than strlen(Name)!<br/>
		/// </summary>
		public int NameBufLen;
		/// <summary>
		/// == window-&gt;GetID("#MOVE")<br/>
		/// </summary>
		public uint MoveId;
		/// <summary>
		/// == window-&gt;GetID("#TAB")<br/>
		/// </summary>
		public uint TabId;
		/// <summary>
		/// ID of corresponding item in parent window (for navigation to return from child window to parent window)<br/>
		/// </summary>
		public uint ChildId;
		/// <summary>
		/// ID in the popup stack when this window is used as a popup/menu (because we use generic Name/ID for recycling)<br/>
		/// </summary>
		public uint PopupId;
		public Vector2 Scroll;
		public Vector2 ScrollMax;
		/// <summary>
		/// target scroll position. stored as cursor position with scrolling canceled out, so the highest point is always 0.0f. (FLT_MAX for no change)<br/>
		/// </summary>
		public Vector2 ScrollTarget;
		/// <summary>
		/// 0.0f = scroll so that target position is at top, 0.5f = scroll so that target position is centered<br/>
		/// </summary>
		public Vector2 ScrollTargetCenterRatio;
		/// <summary>
		/// 0.0f = no snapping, &gt;0.0f snapping threshold<br/>
		/// </summary>
		public Vector2 ScrollTargetEdgeSnapDist;
		/// <summary>
		/// Size taken by each scrollbars on their smaller axis. Pay attention! ScrollbarSizes.x == width of the vertical scrollbar, ScrollbarSizes.y = height of the horizontal scrollbar.<br/>
		/// </summary>
		public Vector2 ScrollbarSizes;
		/// <summary>
		/// Are scrollbars visible?<br/>
		/// </summary>
		public byte ScrollbarX;
		/// <summary>
		/// Are scrollbars visible?<br/>
		/// </summary>
		public byte ScrollbarY;
		/// <summary>
		/// Was ScrollbarX previously auto-stabilized?<br/>
		/// </summary>
		public byte ScrollbarXStabilizeEnabled;
		/// <summary>
		/// Used to stabilize scrollbar visibility in case of feedback loops<br/>
		/// </summary>
		public byte ScrollbarXStabilizeToggledHistory;
		public byte ViewportOwned;
		/// <summary>
		/// Set to true on Begin(), unless Collapsed<br/>
		/// </summary>
		public byte Active;
		public byte WasActive;
		/// <summary>
		/// Set to true when any widget access the current window<br/>
		/// </summary>
		public byte WriteAccessed;
		/// <summary>
		/// Set when collapsing window to become only title-bar<br/>
		/// </summary>
		public byte Collapsed;
		public byte WantCollapseToggle;
		/// <summary>
		/// Set when items can safely be all clipped (e.g. window not visible or collapsed)<br/>
		/// </summary>
		public byte SkipItems;
		/// <summary>
		/// [EXPERIMENTAL] Reuse previous frame drawn contents, Begin() returns false.<br/>
		/// </summary>
		public byte SkipRefresh;
		/// <summary>
		/// Set during the frame where the window is appearing (or re-appearing)<br/>
		/// </summary>
		public byte Appearing;
		/// <summary>
		/// Do not display (== HiddenFrames*** &gt; 0)<br/>
		/// </summary>
		public byte Hidden;
		/// <summary>
		/// Set on the "Debug##Default" window.<br/>
		/// </summary>
		public byte IsFallbackWindow;
		/// <summary>
		/// Set when passed _ChildWindow, left to false by BeginDocked()<br/>
		/// </summary>
		public byte IsExplicitChild;
		/// <summary>
		/// Set when the window has a close button (p_open != NULL)<br/>
		/// </summary>
		public byte HasCloseButton;
		/// <summary>
		/// Current border being hovered for resize (-1: none, otherwise 0-3)<br/>
		/// </summary>
		public byte ResizeBorderHovered;
		/// <summary>
		/// Current border being held for resize (-1: none, otherwise 0-3)<br/>
		/// </summary>
		public byte ResizeBorderHeld;
		/// <summary>
		/// Number of Begin() during the current frame (generally 0 or 1, 1+ if appending via multiple Begin/End pairs)<br/>
		/// </summary>
		public short BeginCount;
		/// <summary>
		/// Number of Begin() during the previous frame<br/>
		/// </summary>
		public short BeginCountPreviousFrame;
		/// <summary>
		/// Begin() order within immediate parent window, if we are a child window. Otherwise 0.<br/>
		/// </summary>
		public short BeginOrderWithinParent;
		/// <summary>
		/// Begin() order within entire imgui context. This is mostly used for debugging submission order related issues.<br/>
		/// </summary>
		public short BeginOrderWithinContext;
		/// <summary>
		/// Order within WindowsFocusOrder[], altered when windows are focused.<br/>
		/// </summary>
		public short FocusOrder;
		public sbyte AutoFitFramesX;
		public sbyte AutoFitFramesY;
		public byte AutoFitOnlyGrows;
		public ImGuiDir AutoPosLastDirection;
		/// <summary>
		/// Hide the window for N frames<br/>
		/// </summary>
		public sbyte HiddenFramesCanSkipItems;
		/// <summary>
		/// Hide the window for N frames while allowing items to be submitted so we can measure their size<br/>
		/// </summary>
		public sbyte HiddenFramesCannotSkipItems;
		/// <summary>
		/// Hide the window until frame N at Render() time only<br/>
		/// </summary>
		public sbyte HiddenFramesForRenderOnly;
		/// <summary>
		/// Disable window interactions for N frames<br/>
		/// </summary>
		public sbyte DisableInputsFrames;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowPos() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowPosAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowSize() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowSizeAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowCollapsed() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowCollapsedAllowFlags;
		/// <summary>
		/// store acceptable condition flags for SetNextWindowDock() use.<br/>
		/// </summary>
		public ImGuiCond SetWindowDockAllowFlags;
		/// <summary>
		/// store window position when using a non-zero Pivot (position set needs to be processed when we know the window size)<br/>
		/// </summary>
		public Vector2 SetWindowPosVal;
		/// <summary>
		/// store window pivot for positioning. ImVec2(0, 0) when positioning from top-left corner; ImVec2(0.5f, 0.5f) for centering; ImVec2(1, 1) for bottom right.<br/>
		/// </summary>
		public Vector2 SetWindowPosPivot;
		/// <summary>
		/// ID stack. ID are hashes seeded with the value at the top of the stack. (In theory this should be in the TempData structure)<br/>
		/// </summary>
		public ImVector<uint> IdStack;
		/// <summary>
		/// Temporary per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the "DC" variable name.<br/>
		/// </summary>
		public ImGuiWindowTempData DC;
		/// <summary>
		///     The best way to understand what those rectangles are is to use the 'Metrics-&gt;Tools-&gt;Show Windows Rectangles' viewer.<br/>    The main 'OuterRect', omitted as a field, is window-&gt;Rect().<br/>
		/// == Window-&gt;Rect() just after setup in Begin(). == window-&gt;Rect() for root window.<br/>
		/// </summary>
		public ImRect OuterRectClipped;
		/// <summary>
		/// Inner rectangle (omit title bar, menu bar, scroll bar)<br/>
		/// </summary>
		public ImRect InnerRect;
		/// <summary>
		/// == InnerRect shrunk by WindowPadding*0.5f on each side, clipped within viewport or parent clip rect.<br/>
		/// </summary>
		public ImRect InnerClipRect;
		/// <summary>
		/// Initially covers the whole scrolling region. Reduced by containers e.g columns/tables when active. Shrunk by WindowPadding*1.0f on each side. This is meant to replace ContentRegionRect over time (from 1.71+ onward).<br/>
		/// </summary>
		public ImRect WorkRect;
		/// <summary>
		/// Backup of WorkRect before entering a container such as columns/tables. Used by e.g. SpanAllColumns functions to easily access. Stacked containers are responsible for maintaining this. FIXME-WORKRECT: Could be a stack?<br/>
		/// </summary>
		public ImRect ParentWorkRect;
		/// <summary>
		/// Current clipping/scissoring rectangle, evolve as we are using PushClipRect(), etc. == DrawList-&gt;clip_rect_stack.back().<br/>
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// FIXME: This is currently confusing/misleading. It is essentially WorkRect but not handling of scrolling. We currently rely on it as right/bottom aligned sizing operation need some size to rely on.<br/>
		/// </summary>
		public ImRect ContentRegionRect;
		/// <summary>
		/// Define an optional rectangular hole where mouse will pass-through the window.<br/>
		/// </summary>
		public ImVec2Ih HitTestHoleSize;
		public ImVec2Ih HitTestHoleOffset;
		/// <summary>
		/// Last frame number the window was Active.<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last frame number the window was made Focused.<br/>
		/// </summary>
		public int LastFrameJustFocused;
		/// <summary>
		/// Last timestamp the window was Active (using float as we don't need high precision there)<br/>
		/// </summary>
		public float LastTimeActive;
		public float ItemWidthDefault;
		public ImGuiStorage StateStorage;
		public ImVector<ImGuiOldColumns> ColumnsStorage;
		/// <summary>
		/// User scale multiplier per-window, via SetWindowFontScale()<br/>
		/// </summary>
		public float FontWindowScale;
		public float FontWindowScaleParents;
		public float FontDpiScale;
		/// <summary>
		/// This is a copy of window-&gt;CalcFontSize() at the time of Begin(), trying to phase out CalcFontSize() especially as it may be called on non-current window.<br/>
		/// </summary>
		public float FontRefSize;
		/// <summary>
		/// Offset into SettingsWindows[] (offsets are always valid as we only grow the array from the back)<br/>
		/// </summary>
		public int SettingsOffset;
		/// <summary>
		/// == &DrawListInst (for backward compatibility reason with code using imgui_internal.h we keep this a pointer)<br/>
		/// </summary>
		public unsafe ImDrawList* DrawList;
		public ImDrawList DrawListInst;
		/// <summary>
		/// If we are a child _or_ popup _or_ docked window, this is pointing to our parent. Otherwise NULL.<br/>
		/// </summary>
		public unsafe ImGuiWindow* ParentWindow;
		public unsafe ImGuiWindow* ParentWindowInBeginStack;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Doesn't cross through popups/dock nodes.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindow;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through popups parent&lt;&gt;child.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowPopupTree;
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through dock nodes.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowDockTree;
		/// <summary>
		/// Point to ourself or first ancestor which will display TitleBgActive color when this window is active.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowForTitleBarHighlight;
		/// <summary>
		/// Point to ourself or first ancestor which doesn't have the NavFlattened flag.<br/>
		/// </summary>
		public unsafe ImGuiWindow* RootWindowForNav;
		/// <summary>
		/// Set to manual link a window to its logical parent so that Shortcut() chain are honoerd (e.g. Tool linked to Document)<br/>
		/// </summary>
		public unsafe ImGuiWindow* ParentWindowForFocusRoute;
		/// <summary>
		/// When going to the menu bar, we remember the child window we came from. (This could probably be made implicit if we kept g.Windows sorted by last focused including child window.)<br/>
		/// </summary>
		public unsafe ImGuiWindow* NavLastChildNavWindow;
		/// <summary>
		/// Last known NavId for this window, per layer (0/1)<br/>
		/// </summary>
		public uint NavLastIds_0;
		public uint NavLastIds_1;
		/// <summary>
		/// Reference rectangle, in window relative space<br/>
		/// </summary>
		public ImRect NavRectRel_0;
		public ImRect NavRectRel_1;
		/// <summary>
		/// Preferred X/Y position updated when moving on a given axis, reset to FLT_MAX.<br/>
		/// </summary>
		public Vector2 NavPreferredScoringPosRel_0;
		public Vector2 NavPreferredScoringPosRel_1;
		/// <summary>
		/// Focus Scope ID at the time of Begin()<br/>
		/// </summary>
		public uint NavRootFocusScopeId;
		/// <summary>
		/// Backup of last idx/vtx count, so when waking up the window we can preallocate and avoid iterative alloc/copy<br/>
		/// </summary>
		public int MemoryDrawListIdxCapacity;
		public int MemoryDrawListVtxCapacity;
		/// <summary>
		/// Set when window extraneous data have been garbage collected<br/>
		/// </summary>
		public byte MemoryCompacted;
		/// <summary>
		///     Docking<br/>
		/// When docking artifacts are actually visible. When this is set, DockNode is guaranteed to be != NULL. ~~ (DockNode != NULL) && (DockNode-&gt;Windows.Size &gt; 1).<br/>
		/// </summary>
		public byte DockIsActive;
		public byte DockNodeIsVisible;
		/// <summary>
		/// Is our window visible this frame? ~~ is the corresponding tab selected?<br/>
		/// </summary>
		public byte DockTabIsVisible;
		public byte DockTabWantClose;
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.<br/>
		/// </summary>
		public short DockOrder;
		public ImGuiWindowDockStyle DockStyle;
		/// <summary>
		/// Which node are we docked into. Important: Prefer testing DockIsActive in many cases as this will still be set when the dock node is hidden.<br/>
		/// </summary>
		public unsafe ImGuiDockNode* DockNode;
		/// <summary>
		/// Which node are we owning (for parent windows)<br/>
		/// </summary>
		public unsafe ImGuiDockNode* DockNodeAsHost;
		/// <summary>
		/// Backup of last valid DockNode-&gt;ID, so single window remember their dock node id even when they are not bound any more<br/>
		/// </summary>
		public uint DockId;
	}

	/// <summary>
	/// Storage for one window<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowPtr
	{
		public ImGuiWindow* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindow this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public ref ImGuiContextPtr Ctx => ref Unsafe.AsRef<ImGuiContextPtr>(&NativePtr->Ctx);
		/// <summary>
		/// Window name, owned by the window.<br/>
		/// </summary>
		public IntPtr Name { get => (IntPtr)NativePtr->Name; set => NativePtr->Name = (byte*)value; }
		/// <summary>
		/// == ImHashStr(Name)<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// See enum ImGuiWindowFlags_<br/>
		/// </summary>
		public ref ImGuiWindowFlags Flags => ref Unsafe.AsRef<ImGuiWindowFlags>(&NativePtr->Flags);
		/// <summary>
		/// See enum ImGuiWindowFlags_<br/>
		/// </summary>
		public ref ImGuiWindowFlags FlagsPreviousFrame => ref Unsafe.AsRef<ImGuiWindowFlags>(&NativePtr->FlagsPreviousFrame);
		/// <summary>
		/// Set when window is a child window. See enum ImGuiChildFlags_<br/>
		/// </summary>
		public ref ImGuiChildFlags ChildFlags => ref Unsafe.AsRef<ImGuiChildFlags>(&NativePtr->ChildFlags);
		/// <summary>
		/// Advanced users only. Set with SetNextWindowClass()<br/>
		/// </summary>
		public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);
		/// <summary>
		/// Always set in Begin(). Inactive windows may have a NULL value here if their viewport was discarded.<br/>
		/// </summary>
		public ref ImGuiViewportPPtr Viewport => ref Unsafe.AsRef<ImGuiViewportPPtr>(&NativePtr->Viewport);
		/// <summary>
		/// We backup the viewport id (since the viewport may disappear or never be created if the window is inactive)<br/>
		/// </summary>
		public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);
		/// <summary>
		/// We backup the viewport position (since the viewport may disappear or never be created if the window is inactive)<br/>
		/// </summary>
		public ref Vector2 ViewportPos => ref Unsafe.AsRef<Vector2>(&NativePtr->ViewportPos);
		/// <summary>
		/// Reset to -1 every frame (index is guaranteed to be valid between NewFrame..EndFrame), only used in the Appearing frame of a tooltip/popup to enforce clamping to a given monitor<br/>
		/// </summary>
		public ref int ViewportAllowPlatformMonitorExtend => ref Unsafe.AsRef<int>(&NativePtr->ViewportAllowPlatformMonitorExtend);
		/// <summary>
		/// Position (always rounded-up to nearest pixel)<br/>
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
		/// <summary>
		/// Current size (==SizeFull or collapsed title bar size)<br/>
		/// </summary>
		public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);
		/// <summary>
		/// Size when non collapsed<br/>
		/// </summary>
		public ref Vector2 SizeFull => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeFull);
		/// <summary>
		/// Size of contents/scrollable client area (calculated from the extents reach of the cursor) from previous frame. Does not include window decoration or window padding.<br/>
		/// </summary>
		public ref Vector2 ContentSize => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSize);
		public ref Vector2 ContentSizeIdeal => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeIdeal);
		/// <summary>
		/// Size of contents/scrollable client area explicitly request by the user via SetNextWindowContentSize().<br/>
		/// </summary>
		public ref Vector2 ContentSizeExplicit => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeExplicit);
		/// <summary>
		/// Window padding at the time of Begin().<br/>
		/// </summary>
		public ref Vector2 WindowPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowPadding);
		/// <summary>
		/// Window rounding at the time of Begin(). May be clamped lower to avoid rendering artifacts with title bar, menu bar etc.<br/>
		/// </summary>
		public ref float WindowRounding => ref Unsafe.AsRef<float>(&NativePtr->WindowRounding);
		/// <summary>
		/// Window border size at the time of Begin().<br/>
		/// </summary>
		public ref float WindowBorderSize => ref Unsafe.AsRef<float>(&NativePtr->WindowBorderSize);
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.<br/>
		/// </summary>
		public ref float TitleBarHeight => ref Unsafe.AsRef<float>(&NativePtr->TitleBarHeight);
		/// <summary>
		/// Note that those used to be function before 2024/05/28. If you have old code calling TitleBarHeight() you can change it to TitleBarHeight.<br/>
		/// </summary>
		public ref float MenuBarHeight => ref Unsafe.AsRef<float>(&NativePtr->MenuBarHeight);
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().<br/>
		/// </summary>
		public ref float DecoOuterSizeX1 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeX1);
		/// <summary>
		/// Left/Up offsets. Sum of non-scrolling outer decorations (X1 generally == 0.0f. Y1 generally = TitleBarHeight + MenuBarHeight). Locked during Begin().<br/>
		/// </summary>
		public ref float DecoOuterSizeY1 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeY1);
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).<br/>
		/// </summary>
		public ref float DecoOuterSizeX2 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeX2);
		/// <summary>
		/// Right/Down offsets (X2 generally == ScrollbarSize.x, Y2 == ScrollbarSizes.y).<br/>
		/// </summary>
		public ref float DecoOuterSizeY2 => ref Unsafe.AsRef<float>(&NativePtr->DecoOuterSizeY2);
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).<br/>
		/// </summary>
		public ref float DecoInnerSizeX1 => ref Unsafe.AsRef<float>(&NativePtr->DecoInnerSizeX1);
		/// <summary>
		/// Applied AFTER/OVER InnerRect. Specialized for Tables as they use specialized form of clipping and frozen rows/columns are inside InnerRect (and not part of regular decoration sizes).<br/>
		/// </summary>
		public ref float DecoInnerSizeY1 => ref Unsafe.AsRef<float>(&NativePtr->DecoInnerSizeY1);
		/// <summary>
		/// Size of buffer storing Name. May be larger than strlen(Name)!<br/>
		/// </summary>
		public ref int NameBufLen => ref Unsafe.AsRef<int>(&NativePtr->NameBufLen);
		/// <summary>
		/// == window-&gt;GetID("#MOVE")<br/>
		/// </summary>
		public ref uint MoveId => ref Unsafe.AsRef<uint>(&NativePtr->MoveId);
		/// <summary>
		/// == window-&gt;GetID("#TAB")<br/>
		/// </summary>
		public ref uint TabId => ref Unsafe.AsRef<uint>(&NativePtr->TabId);
		/// <summary>
		/// ID of corresponding item in parent window (for navigation to return from child window to parent window)<br/>
		/// </summary>
		public ref uint ChildId => ref Unsafe.AsRef<uint>(&NativePtr->ChildId);
		/// <summary>
		/// ID in the popup stack when this window is used as a popup/menu (because we use generic Name/ID for recycling)<br/>
		/// </summary>
		public ref uint PopupId => ref Unsafe.AsRef<uint>(&NativePtr->PopupId);
		public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);
		public ref Vector2 ScrollMax => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollMax);
		/// <summary>
		/// target scroll position. stored as cursor position with scrolling canceled out, so the highest point is always 0.0f. (FLT_MAX for no change)<br/>
		/// </summary>
		public ref Vector2 ScrollTarget => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollTarget);
		/// <summary>
		/// 0.0f = scroll so that target position is at top, 0.5f = scroll so that target position is centered<br/>
		/// </summary>
		public ref Vector2 ScrollTargetCenterRatio => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollTargetCenterRatio);
		/// <summary>
		/// 0.0f = no snapping, &gt;0.0f snapping threshold<br/>
		/// </summary>
		public ref Vector2 ScrollTargetEdgeSnapDist => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollTargetEdgeSnapDist);
		/// <summary>
		/// Size taken by each scrollbars on their smaller axis. Pay attention! ScrollbarSizes.x == width of the vertical scrollbar, ScrollbarSizes.y = height of the horizontal scrollbar.<br/>
		/// </summary>
		public ref Vector2 ScrollbarSizes => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollbarSizes);
		/// <summary>
		/// Are scrollbars visible?<br/>
		/// </summary>
		public ref bool ScrollbarX => ref Unsafe.AsRef<bool>(&NativePtr->ScrollbarX);
		/// <summary>
		/// Are scrollbars visible?<br/>
		/// </summary>
		public ref bool ScrollbarY => ref Unsafe.AsRef<bool>(&NativePtr->ScrollbarY);
		/// <summary>
		/// Was ScrollbarX previously auto-stabilized?<br/>
		/// </summary>
		public ref bool ScrollbarXStabilizeEnabled => ref Unsafe.AsRef<bool>(&NativePtr->ScrollbarXStabilizeEnabled);
		/// <summary>
		/// Used to stabilize scrollbar visibility in case of feedback loops<br/>
		/// </summary>
		public ref bool ScrollbarXStabilizeToggledHistory => ref Unsafe.AsRef<bool>(&NativePtr->ScrollbarXStabilizeToggledHistory);
		public ref bool ViewportOwned => ref Unsafe.AsRef<bool>(&NativePtr->ViewportOwned);
		/// <summary>
		/// Set to true on Begin(), unless Collapsed<br/>
		/// </summary>
		public ref bool Active => ref Unsafe.AsRef<bool>(&NativePtr->Active);
		public ref bool WasActive => ref Unsafe.AsRef<bool>(&NativePtr->WasActive);
		/// <summary>
		/// Set to true when any widget access the current window<br/>
		/// </summary>
		public ref bool WriteAccessed => ref Unsafe.AsRef<bool>(&NativePtr->WriteAccessed);
		/// <summary>
		/// Set when collapsing window to become only title-bar<br/>
		/// </summary>
		public ref bool Collapsed => ref Unsafe.AsRef<bool>(&NativePtr->Collapsed);
		public ref bool WantCollapseToggle => ref Unsafe.AsRef<bool>(&NativePtr->WantCollapseToggle);
		/// <summary>
		/// Set when items can safely be all clipped (e.g. window not visible or collapsed)<br/>
		/// </summary>
		public ref bool SkipItems => ref Unsafe.AsRef<bool>(&NativePtr->SkipItems);
		/// <summary>
		/// [EXPERIMENTAL] Reuse previous frame drawn contents, Begin() returns false.<br/>
		/// </summary>
		public ref bool SkipRefresh => ref Unsafe.AsRef<bool>(&NativePtr->SkipRefresh);
		/// <summary>
		/// Set during the frame where the window is appearing (or re-appearing)<br/>
		/// </summary>
		public ref bool Appearing => ref Unsafe.AsRef<bool>(&NativePtr->Appearing);
		/// <summary>
		/// Do not display (== HiddenFrames*** &gt; 0)<br/>
		/// </summary>
		public ref bool Hidden => ref Unsafe.AsRef<bool>(&NativePtr->Hidden);
		/// <summary>
		/// Set on the "Debug##Default" window.<br/>
		/// </summary>
		public ref bool IsFallbackWindow => ref Unsafe.AsRef<bool>(&NativePtr->IsFallbackWindow);
		/// <summary>
		/// Set when passed _ChildWindow, left to false by BeginDocked()<br/>
		/// </summary>
		public ref bool IsExplicitChild => ref Unsafe.AsRef<bool>(&NativePtr->IsExplicitChild);
		/// <summary>
		/// Set when the window has a close button (p_open != NULL)<br/>
		/// </summary>
		public ref bool HasCloseButton => ref Unsafe.AsRef<bool>(&NativePtr->HasCloseButton);
		/// <summary>
		/// Current border being hovered for resize (-1: none, otherwise 0-3)<br/>
		/// </summary>
		public ref bool ResizeBorderHovered => ref Unsafe.AsRef<bool>(&NativePtr->ResizeBorderHovered);
		/// <summary>
		/// Current border being held for resize (-1: none, otherwise 0-3)<br/>
		/// </summary>
		public ref bool ResizeBorderHeld => ref Unsafe.AsRef<bool>(&NativePtr->ResizeBorderHeld);
		/// <summary>
		/// Number of Begin() during the current frame (generally 0 or 1, 1+ if appending via multiple Begin/End pairs)<br/>
		/// </summary>
		public ref short BeginCount => ref Unsafe.AsRef<short>(&NativePtr->BeginCount);
		/// <summary>
		/// Number of Begin() during the previous frame<br/>
		/// </summary>
		public ref short BeginCountPreviousFrame => ref Unsafe.AsRef<short>(&NativePtr->BeginCountPreviousFrame);
		/// <summary>
		/// Begin() order within immediate parent window, if we are a child window. Otherwise 0.<br/>
		/// </summary>
		public ref short BeginOrderWithinParent => ref Unsafe.AsRef<short>(&NativePtr->BeginOrderWithinParent);
		/// <summary>
		/// Begin() order within entire imgui context. This is mostly used for debugging submission order related issues.<br/>
		/// </summary>
		public ref short BeginOrderWithinContext => ref Unsafe.AsRef<short>(&NativePtr->BeginOrderWithinContext);
		/// <summary>
		/// Order within WindowsFocusOrder[], altered when windows are focused.<br/>
		/// </summary>
		public ref short FocusOrder => ref Unsafe.AsRef<short>(&NativePtr->FocusOrder);
		public ref sbyte AutoFitFramesX => ref Unsafe.AsRef<sbyte>(&NativePtr->AutoFitFramesX);
		public ref sbyte AutoFitFramesY => ref Unsafe.AsRef<sbyte>(&NativePtr->AutoFitFramesY);
		public ref bool AutoFitOnlyGrows => ref Unsafe.AsRef<bool>(&NativePtr->AutoFitOnlyGrows);
		public ref ImGuiDir AutoPosLastDirection => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->AutoPosLastDirection);
		/// <summary>
		/// Hide the window for N frames<br/>
		/// </summary>
		public ref sbyte HiddenFramesCanSkipItems => ref Unsafe.AsRef<sbyte>(&NativePtr->HiddenFramesCanSkipItems);
		/// <summary>
		/// Hide the window for N frames while allowing items to be submitted so we can measure their size<br/>
		/// </summary>
		public ref sbyte HiddenFramesCannotSkipItems => ref Unsafe.AsRef<sbyte>(&NativePtr->HiddenFramesCannotSkipItems);
		/// <summary>
		/// Hide the window until frame N at Render() time only<br/>
		/// </summary>
		public ref sbyte HiddenFramesForRenderOnly => ref Unsafe.AsRef<sbyte>(&NativePtr->HiddenFramesForRenderOnly);
		/// <summary>
		/// Disable window interactions for N frames<br/>
		/// </summary>
		public ref sbyte DisableInputsFrames => ref Unsafe.AsRef<sbyte>(&NativePtr->DisableInputsFrames);
		/// <summary>
		/// store acceptable condition flags for SetNextWindowPos() use.<br/>
		/// </summary>
		public ref ImGuiCond SetWindowPosAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowPosAllowFlags);
		/// <summary>
		/// store acceptable condition flags for SetNextWindowSize() use.<br/>
		/// </summary>
		public ref ImGuiCond SetWindowSizeAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowSizeAllowFlags);
		/// <summary>
		/// store acceptable condition flags for SetNextWindowCollapsed() use.<br/>
		/// </summary>
		public ref ImGuiCond SetWindowCollapsedAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowCollapsedAllowFlags);
		/// <summary>
		/// store acceptable condition flags for SetNextWindowDock() use.<br/>
		/// </summary>
		public ref ImGuiCond SetWindowDockAllowFlags => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SetWindowDockAllowFlags);
		/// <summary>
		/// store window position when using a non-zero Pivot (position set needs to be processed when we know the window size)<br/>
		/// </summary>
		public ref Vector2 SetWindowPosVal => ref Unsafe.AsRef<Vector2>(&NativePtr->SetWindowPosVal);
		/// <summary>
		/// store window pivot for positioning. ImVec2(0, 0) when positioning from top-left corner; ImVec2(0.5f, 0.5f) for centering; ImVec2(1, 1) for bottom right.<br/>
		/// </summary>
		public ref Vector2 SetWindowPosPivot => ref Unsafe.AsRef<Vector2>(&NativePtr->SetWindowPosPivot);
		/// <summary>
		/// ID stack. ID are hashes seeded with the value at the top of the stack. (In theory this should be in the TempData structure)<br/>
		/// </summary>
		public ref ImVector<uint> IdStack => ref Unsafe.AsRef<ImVector<uint>>(&NativePtr->IdStack);
		/// <summary>
		/// Temporary per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the "DC" variable name.<br/>
		/// </summary>
		public ref ImGuiWindowTempData DC => ref Unsafe.AsRef<ImGuiWindowTempData>(&NativePtr->DC);
		/// <summary>
		///     The best way to understand what those rectangles are is to use the 'Metrics-&gt;Tools-&gt;Show Windows Rectangles' viewer.<br/>    The main 'OuterRect', omitted as a field, is window-&gt;Rect().<br/>
		/// == Window-&gt;Rect() just after setup in Begin(). == window-&gt;Rect() for root window.<br/>
		/// </summary>
		public ref ImRect OuterRectClipped => ref Unsafe.AsRef<ImRect>(&NativePtr->OuterRectClipped);
		/// <summary>
		/// Inner rectangle (omit title bar, menu bar, scroll bar)<br/>
		/// </summary>
		public ref ImRect InnerRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerRect);
		/// <summary>
		/// == InnerRect shrunk by WindowPadding*0.5f on each side, clipped within viewport or parent clip rect.<br/>
		/// </summary>
		public ref ImRect InnerClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerClipRect);
		/// <summary>
		/// Initially covers the whole scrolling region. Reduced by containers e.g columns/tables when active. Shrunk by WindowPadding*1.0f on each side. This is meant to replace ContentRegionRect over time (from 1.71+ onward).<br/>
		/// </summary>
		public ref ImRect WorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->WorkRect);
		/// <summary>
		/// Backup of WorkRect before entering a container such as columns/tables. Used by e.g. SpanAllColumns functions to easily access. Stacked containers are responsible for maintaining this. FIXME-WORKRECT: Could be a stack?<br/>
		/// </summary>
		public ref ImRect ParentWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ParentWorkRect);
		/// <summary>
		/// Current clipping/scissoring rectangle, evolve as we are using PushClipRect(), etc. == DrawList-&gt;clip_rect_stack.back().<br/>
		/// </summary>
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
		/// <summary>
		/// FIXME: This is currently confusing/misleading. It is essentially WorkRect but not handling of scrolling. We currently rely on it as right/bottom aligned sizing operation need some size to rely on.<br/>
		/// </summary>
		public ref ImRect ContentRegionRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ContentRegionRect);
		/// <summary>
		/// Define an optional rectangular hole where mouse will pass-through the window.<br/>
		/// </summary>
		public ref ImVec2Ih HitTestHoleSize => ref Unsafe.AsRef<ImVec2Ih>(&NativePtr->HitTestHoleSize);
		public ref ImVec2Ih HitTestHoleOffset => ref Unsafe.AsRef<ImVec2Ih>(&NativePtr->HitTestHoleOffset);
		/// <summary>
		/// Last frame number the window was Active.<br/>
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
		/// <summary>
		/// Last frame number the window was made Focused.<br/>
		/// </summary>
		public ref int LastFrameJustFocused => ref Unsafe.AsRef<int>(&NativePtr->LastFrameJustFocused);
		/// <summary>
		/// Last timestamp the window was Active (using float as we don't need high precision there)<br/>
		/// </summary>
		public ref float LastTimeActive => ref Unsafe.AsRef<float>(&NativePtr->LastTimeActive);
		public ref float ItemWidthDefault => ref Unsafe.AsRef<float>(&NativePtr->ItemWidthDefault);
		public ref ImGuiStorage StateStorage => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->StateStorage);
		public ref ImVector<ImGuiOldColumns> ColumnsStorage => ref Unsafe.AsRef<ImVector<ImGuiOldColumns>>(&NativePtr->ColumnsStorage);
		/// <summary>
		/// User scale multiplier per-window, via SetWindowFontScale()<br/>
		/// </summary>
		public ref float FontWindowScale => ref Unsafe.AsRef<float>(&NativePtr->FontWindowScale);
		public ref float FontWindowScaleParents => ref Unsafe.AsRef<float>(&NativePtr->FontWindowScaleParents);
		public ref float FontDpiScale => ref Unsafe.AsRef<float>(&NativePtr->FontDpiScale);
		/// <summary>
		/// This is a copy of window-&gt;CalcFontSize() at the time of Begin(), trying to phase out CalcFontSize() especially as it may be called on non-current window.<br/>
		/// </summary>
		public ref float FontRefSize => ref Unsafe.AsRef<float>(&NativePtr->FontRefSize);
		/// <summary>
		/// Offset into SettingsWindows[] (offsets are always valid as we only grow the array from the back)<br/>
		/// </summary>
		public ref int SettingsOffset => ref Unsafe.AsRef<int>(&NativePtr->SettingsOffset);
		/// <summary>
		/// == &DrawListInst (for backward compatibility reason with code using imgui_internal.h we keep this a pointer)<br/>
		/// </summary>
		public ref ImDrawListPtr DrawList => ref Unsafe.AsRef<ImDrawListPtr>(&NativePtr->DrawList);
		public ref ImDrawList DrawListInst => ref Unsafe.AsRef<ImDrawList>(&NativePtr->DrawListInst);
		/// <summary>
		/// If we are a child _or_ popup _or_ docked window, this is pointing to our parent. Otherwise NULL.<br/>
		/// </summary>
		public ref ImGuiWindowPtr ParentWindow => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->ParentWindow);
		public ref ImGuiWindowPtr ParentWindowInBeginStack => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->ParentWindowInBeginStack);
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Doesn't cross through popups/dock nodes.<br/>
		/// </summary>
		public ref ImGuiWindowPtr RootWindow => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->RootWindow);
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through popups parent&lt;&gt;child.<br/>
		/// </summary>
		public ref ImGuiWindowPtr RootWindowPopupTree => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->RootWindowPopupTree);
		/// <summary>
		/// Point to ourself or first ancestor that is not a child window. Cross through dock nodes.<br/>
		/// </summary>
		public ref ImGuiWindowPtr RootWindowDockTree => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->RootWindowDockTree);
		/// <summary>
		/// Point to ourself or first ancestor which will display TitleBgActive color when this window is active.<br/>
		/// </summary>
		public ref ImGuiWindowPtr RootWindowForTitleBarHighlight => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->RootWindowForTitleBarHighlight);
		/// <summary>
		/// Point to ourself or first ancestor which doesn't have the NavFlattened flag.<br/>
		/// </summary>
		public ref ImGuiWindowPtr RootWindowForNav => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->RootWindowForNav);
		/// <summary>
		/// Set to manual link a window to its logical parent so that Shortcut() chain are honoerd (e.g. Tool linked to Document)<br/>
		/// </summary>
		public ref ImGuiWindowPtr ParentWindowForFocusRoute => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->ParentWindowForFocusRoute);
		/// <summary>
		/// When going to the menu bar, we remember the child window we came from. (This could probably be made implicit if we kept g.Windows sorted by last focused including child window.)<br/>
		/// </summary>
		public ref ImGuiWindowPtr NavLastChildNavWindow => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->NavLastChildNavWindow);
		/// <summary>
		/// Last known NavId for this window, per layer (0/1)<br/>
		/// </summary>
		public Span<uint> NavLastIds => new Span<uint>(&NativePtr->NavLastIds_0, 2);
		/// <summary>
		/// Reference rectangle, in window relative space<br/>
		/// </summary>
		public Span<ImRect> NavRectRel => new Span<ImRect>(&NativePtr->NavRectRel_0, 2);
		/// <summary>
		/// Preferred X/Y position updated when moving on a given axis, reset to FLT_MAX.<br/>
		/// </summary>
		public Span<Vector2> NavPreferredScoringPosRel => new Span<Vector2>(&NativePtr->NavPreferredScoringPosRel_0, 2);
		/// <summary>
		/// Focus Scope ID at the time of Begin()<br/>
		/// </summary>
		public ref uint NavRootFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavRootFocusScopeId);
		/// <summary>
		/// Backup of last idx/vtx count, so when waking up the window we can preallocate and avoid iterative alloc/copy<br/>
		/// </summary>
		public ref int MemoryDrawListIdxCapacity => ref Unsafe.AsRef<int>(&NativePtr->MemoryDrawListIdxCapacity);
		public ref int MemoryDrawListVtxCapacity => ref Unsafe.AsRef<int>(&NativePtr->MemoryDrawListVtxCapacity);
		/// <summary>
		/// Set when window extraneous data have been garbage collected<br/>
		/// </summary>
		public ref bool MemoryCompacted => ref Unsafe.AsRef<bool>(&NativePtr->MemoryCompacted);
		/// <summary>
		///     Docking<br/>
		/// When docking artifacts are actually visible. When this is set, DockNode is guaranteed to be != NULL. ~~ (DockNode != NULL) && (DockNode-&gt;Windows.Size &gt; 1).<br/>
		/// </summary>
		public ref bool DockIsActive => ref Unsafe.AsRef<bool>(&NativePtr->DockIsActive);
		public ref bool DockNodeIsVisible => ref Unsafe.AsRef<bool>(&NativePtr->DockNodeIsVisible);
		/// <summary>
		/// Is our window visible this frame? ~~ is the corresponding tab selected?<br/>
		/// </summary>
		public ref bool DockTabIsVisible => ref Unsafe.AsRef<bool>(&NativePtr->DockTabIsVisible);
		public ref bool DockTabWantClose => ref Unsafe.AsRef<bool>(&NativePtr->DockTabWantClose);
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.<br/>
		/// </summary>
		public ref short DockOrder => ref Unsafe.AsRef<short>(&NativePtr->DockOrder);
		public ref ImGuiWindowDockStyle DockStyle => ref Unsafe.AsRef<ImGuiWindowDockStyle>(&NativePtr->DockStyle);
		/// <summary>
		/// Which node are we docked into. Important: Prefer testing DockIsActive in many cases as this will still be set when the dock node is hidden.<br/>
		/// </summary>
		public ref ImGuiDockNodePtr DockNode => ref Unsafe.AsRef<ImGuiDockNodePtr>(&NativePtr->DockNode);
		/// <summary>
		/// Which node are we owning (for parent windows)<br/>
		/// </summary>
		public ref ImGuiDockNodePtr DockNodeAsHost => ref Unsafe.AsRef<ImGuiDockNodePtr>(&NativePtr->DockNodeAsHost);
		/// <summary>
		/// Backup of last valid DockNode-&gt;ID, so single window remember their dock node id even when they are not bound any more<br/>
		/// </summary>
		public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);
		public ImGuiWindowPtr(ImGuiWindow* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindow*)nativePtr;
		public static implicit operator ImGuiWindowPtr(ImGuiWindow* ptr) => new ImGuiWindowPtr(ptr);
		public static implicit operator ImGuiWindowPtr(IntPtr ptr) => new ImGuiWindowPtr(ptr);
		public static implicit operator ImGuiWindow*(ImGuiWindowPtr nativePtr) => nativePtr.NativePtr;
		public void MenuBarRect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiWindowMenuBarRect(pOut, NativePtr);
		}

		public void TitleBarRect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiWindowTitleBarRect(pOut, NativePtr);
		}

		public float CalcFontSize()
		{
			return ImGuiNative.ImGuiWindowCalcFontSize(NativePtr);
		}

		public void Rect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiWindowRect(pOut, NativePtr);
		}

		public uint GetIdFromRectangle(ImRect rAbs)
		{
			return ImGuiNative.ImGuiWindowGetIdFromRectangle(NativePtr, rAbs);
		}

		public uint GetIdFromPos(Vector2 pAbs)
		{
			return ImGuiNative.ImGuiWindowGetIdFromPos(NativePtr, pAbs);
		}

		public uint GetID(int n)
		{
			return ImGuiNative.ImGuiWindowGetID(NativePtr, n);
		}

		public uint GetID(IntPtr ptr)
		{
			return ImGuiNative.ImGuiWindowGetID(NativePtr, (void*)ptr);
		}

		public uint GetID(ReadOnlySpan<byte> str, ReadOnlySpan<byte> strEnd)
		{
			fixed (byte* nativeStr = str)
			fixed (byte* nativeStrEnd = strEnd)
			{
				return ImGuiNative.ImGuiWindowGetID(NativePtr, nativeStr, nativeStrEnd);
			}
		}

		public uint GetID(ReadOnlySpan<char> str, ReadOnlySpan<char> strEnd)
		{
			// Marshaling str to native string
			byte* nativeStr;
			var byteCountStr = 0;
			if (str != null && !str.IsEmpty)
			{
				byteCountStr = Encoding.UTF8.GetByteCount(str);
				if(byteCountStr > Utils.MaxStackallocSize)
				{
					nativeStr = Utils.Alloc<byte>(byteCountStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr + 1];
					nativeStr = stackallocBytes;
				}
				var offsetStr = Utils.EncodeStringUTF8(str, nativeStr, byteCountStr);
				nativeStr[offsetStr] = 0;
			}
			else nativeStr = null;

			// Marshaling strEnd to native string
			byte* nativeStrEnd;
			var byteCountStrEnd = 0;
			if (strEnd != null && !strEnd.IsEmpty)
			{
				byteCountStrEnd = Encoding.UTF8.GetByteCount(strEnd);
				if(byteCountStrEnd > Utils.MaxStackallocSize)
				{
					nativeStrEnd = Utils.Alloc<byte>(byteCountStrEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrEnd + 1];
					nativeStrEnd = stackallocBytes;
				}
				var offsetStrEnd = Utils.EncodeStringUTF8(strEnd, nativeStrEnd, byteCountStrEnd);
				nativeStrEnd[offsetStrEnd] = 0;
			}
			else nativeStrEnd = null;

			var result = ImGuiNative.ImGuiWindowGetID(NativePtr, nativeStr, nativeStrEnd);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
			// Freeing strEnd native string
			if (byteCountStrEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrEnd);
			return result;
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiWindowDestroy(NativePtr);
		}

		public void ImGuiWindowConstruct(ImGuiContextPtr context, ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				ImGuiNative.ImGuiWindowImGuiWindowConstruct(NativePtr, context, nativeName);
			}
		}

		public void ImGuiWindowConstruct(ImGuiContextPtr context, ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			ImGuiNative.ImGuiWindowImGuiWindowConstruct(NativePtr, context, nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public ImGuiWindowPtr ImGuiWindow(ImGuiContextPtr context, ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				return ImGuiNative.ImGuiWindowImGuiWindow(context, nativeName);
			}
		}

		public ImGuiWindowPtr ImGuiWindow(ImGuiContextPtr context, ReadOnlySpan<char> name)
		{
			// Marshaling name to native string
			byte* nativeName;
			var byteCountName = 0;
			if (name != null && !name.IsEmpty)
			{
				byteCountName = Encoding.UTF8.GetByteCount(name);
				if(byteCountName > Utils.MaxStackallocSize)
				{
					nativeName = Utils.Alloc<byte>(byteCountName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountName + 1];
					nativeName = stackallocBytes;
				}
				var offsetName = Utils.EncodeStringUTF8(name, nativeName, byteCountName);
				nativeName[offsetName] = 0;
			}
			else nativeName = null;

			var result = ImGuiNative.ImGuiWindowImGuiWindow(context, nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result;
		}

	}
}
