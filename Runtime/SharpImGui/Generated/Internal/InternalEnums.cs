using System;

namespace SharpImGui
{
	/// <summary>
	/// Extend ImGuiTabItemFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTabItemFlagsPrivate
	{
		SectionMask = 192,
		/// <summary>
		/// Track whether p_open was set or not (we'll need this info on the next frame to recompute ContentWidth during layout)<br/>
		/// </summary>
		NoCloseButton = 1048576,
		/// <summary>
		/// Used by TabItemButton, change the tab item behavior to mimic a button<br/>
		/// </summary>
		Button = 2097152,
		/// <summary>
		/// To reserve space e.g. with ImGuiTabItemFlags_Leading<br/>
		/// </summary>
		Invisible = 4194304,
		/// <summary>
		/// [Docking] Trailing tabs with the _Unsorted flag will be sorted based on the DockOrder of their Window.<br/>
		/// </summary>
		Unsorted = 8388608,
	}

	/// <summary>
	/// Extend ImGuiTabBarFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTabBarFlagsPrivate
	{
		/// <summary>
		/// Part of a dock node [we don't use this in the master branch but it facilitate branch syncing to keep this around]<br/>
		/// </summary>
		DockNode = 1048576,
		IsFocused = 2097152,
		/// <summary>
		/// FIXME: Settings are handled by the docking system, this only request the tab bar to mark settings dirty when reordering tabs<br/>
		/// </summary>
		SaveSettings = 4194304,
	}

	public enum ImGuiContextHookType
	{
		NewFramePre = 0,
		NewFramePost = 1,
		EndFramePre = 2,
		EndFramePost = 3,
		RenderPre = 4,
		RenderPost = 5,
		Shutdown = 6,
		PendingRemoval = 7,
	}

	/// <summary>
	/// See IMGUI_DEBUG_LOG() and IMGUI_DEBUG_LOG_XXX() macros.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiDebugLogFlags
	{
		None = 0,
		/// <summary>
		/// Error submitted by IM_ASSERT_USER_ERROR()<br/>
		/// </summary>
		EventError = 1,
		EventActiveId = 2,
		EventFocus = 4,
		EventPopup = 8,
		EventNav = 16,
		EventClipper = 32,
		EventSelection = 64,
		EventIO = 128,
		EventFont = 256,
		EventInputRouting = 512,
		EventDocking = 1024,
		EventViewport = 2048,
		EventMask = 4095,
		/// <summary>
		/// Also send output to TTY<br/>
		/// </summary>
		OutputToTTY = 1048576,
		/// <summary>
		/// Also send output to Test Engine<br/>
		/// </summary>
		OutputToTestEngine = 2097152,
	}

	/// <summary>
	/// This is experimental and not officially supported, it'll probably fall short of features, if/when it does we may backtrack.<br/>
	/// </summary>
	public enum ImGuiLocKey
	{
		VersionStr = 0,
		TableSizeOne = 1,
		TableSizeAllFit = 2,
		TableSizeAllDefault = 3,
		TableResetOrder = 4,
		WindowingMainMenuBar = 5,
		WindowingPopup = 6,
		WindowingUntitled = 7,
		OpenLinkS = 8,
		CopyLink = 9,
		DockingHideTabBar = 10,
		DockingHoldShiftToDock = 11,
		DockingDragToUndockOrMoveNode = 12,
		COUNT = 13,
	}

	/// <summary>
	/// List of colors that are stored at the time of Begin() into Docked Windows.<br/>We currently store the packed colors in a simple array window-&gt;DockStyle.Colors[].<br/>A better solution may involve appending into a log of colors in ImGuiContext + store offsets into those arrays in ImGuiWindow,<br/>but it would be more complex as we'd need to double-buffer both as e.g. drop target may refer to window from last frame.<br/>
	/// </summary>
	public enum ImGuiWindowDockStyleCol
	{
		Text = 0,
		TabHovered = 1,
		TabFocused = 2,
		TabSelected = 3,
		TabSelectedOverline = 4,
		TabDimmed = 5,
		TabDimmedSelected = 6,
		TabDimmedSelectedOverline = 7,
		COUNT = 8,
	}

	public enum ImGuiDockNodeState
	{
		Unknown = 0,
		HostWindowHiddenBecauseSingleWindow = 1,
		HostWindowHiddenBecauseWindowsAreResizing = 2,
		HostWindowVisible = 3,
	}

	/// <summary>
	/// Store the source authority (dock node vs window) of a field<br/>
	/// </summary>
	public enum ImGuiDataAuthority
	{
		Auto = 0,
		DockNode = 1,
		Window = 2,
	}

	/// <summary>
	/// Extend ImGuiDockNodeFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiDockNodeFlagsPrivate
	{
		/// <summary>
		/// Saved A dockspace is a node that occupy space within an existing user window. Otherwise the node is floating and create its own window.<br/>
		/// </summary>
		DockSpace = 1024,
		/// <summary>
		/// Saved The central node has 2 main properties: stay visible when empty, only use "remaining" spaces from its neighbor.<br/>
		/// </summary>
		CentralNode = 2048,
		/// <summary>
		/// Saved Tab bar is completely unavailable. No triangle in the corner to enable it back.<br/>
		/// </summary>
		NoTabBar = 4096,
		/// <summary>
		/// Saved Tab bar is hidden, with a triangle in the corner to show it again (NB: actual tab-bar instance may be destroyed as this is only used for single-window tab bar)<br/>
		/// </summary>
		HiddenTabBar = 8192,
		/// <summary>
		/// Saved Disable window/docking menu (that one that appears instead of the collapse button)<br/>
		/// </summary>
		NoWindowMenuButton = 16384,
		/// <summary>
		/// Saved Disable close button<br/>
		/// </summary>
		NoCloseButton = 32768,
		/// <summary>
		///       //<br/>
		/// </summary>
		NoResizeX = 65536,
		/// <summary>
		///       //<br/>
		/// </summary>
		NoResizeY = 131072,
		/// <summary>
		///       Any docked window will be automatically be focus-route chained (window-&gt;ParentWindowForFocusRoute set to this) so Shortcut() in this window can run when any docked window is focused.<br/>
		/// </summary>
		DockedWindowsInFocusRoute = 262144,
		/// <summary>
		///       Disable this node from splitting other windows/nodes.<br/>
		/// </summary>
		NoDockingSplitOther = 524288,
		/// <summary>
		///       Disable other windows/nodes from being docked over this node.<br/>
		/// </summary>
		NoDockingOverMe = 1048576,
		/// <summary>
		///       Disable this node from being docked over another window or non-empty node.<br/>
		/// </summary>
		NoDockingOverOther = 2097152,
		/// <summary>
		///       Disable this node from being docked over an empty node (e.g. DockSpace with no other windows)<br/>
		/// </summary>
		NoDockingOverEmpty = 4194304,
		NoDocking = 7864336,
		SharedFlagsInheritMask = -1,
		NoResizeFlagsMask = 196640,
		LocalFlagsTransferMask = 260208,
		SavedFlagsMask = 261152,
	}

	/// <summary>
	/// Flags for internal's BeginColumns(). This is an obsolete API. Prefer using BeginTable() nowadays!<br/>
	/// </summary>
	[Flags]
	public enum ImGuiOldColumnFlags
	{
		None = 0,
		/// <summary>
		/// Disable column dividers<br/>
		/// </summary>
		NoBorder = 1,
		/// <summary>
		/// Disable resizing columns when clicking on the dividers<br/>
		/// </summary>
		NoResize = 2,
		/// <summary>
		/// Disable column width preservation when adjusting columns<br/>
		/// </summary>
		NoPreserveWidths = 4,
		/// <summary>
		/// Disable forcing columns to fit within window<br/>
		/// </summary>
		NoForceWithinWindow = 8,
		/// <summary>
		/// Restore pre-1.51 behavior of extending the parent window contents size but _without affecting the columns width at all_. Will eventually remove.<br/>
		/// </summary>
		GrowParentContentsSize = 16,
	}

	/// <summary>
	/// Flags for GetTypingSelectRequest()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTypingSelectFlags
	{
		None = 0,
		/// <summary>
		/// Backspace to delete character inputs. If using: ensure GetTypingSelectRequest() is not called more than once per frame (filter by e.g. focus state)<br/>
		/// </summary>
		AllowBackspace = 1,
		/// <summary>
		/// Allow "single char" search mode which is activated when pressing the same character multiple times.<br/>
		/// </summary>
		AllowSingleCharMode = 2,
	}

	public enum ImGuiNavLayer
	{
		/// <summary>
		/// Main scrolling layer<br/>
		/// </summary>
		Main = 0,
		/// <summary>
		/// Menu layer (access with Alt)<br/>
		/// </summary>
		Menu = 1,
		COUNT = 2,
	}

	[Flags]
	public enum ImGuiNavMoveFlags
	{
		None = 0,
		/// <summary>
		/// On failed request, restart from opposite side<br/>
		/// </summary>
		LoopX = 1,
		LoopY = 2,
		/// <summary>
		/// On failed request, request from opposite side one line down (when NavDir==right) or one line up (when NavDir==left)<br/>
		/// </summary>
		WrapX = 4,
		/// <summary>
		/// This is not super useful but provided for completeness<br/>
		/// </summary>
		WrapY = 8,
		WrapMask = 15,
		/// <summary>
		/// Allow scoring and considering the current NavId as a move target candidate. This is used when the move source is offset (e.g. pressing PageDown actually needs to send a Up move request, if we are pressing PageDown from the bottom-most item we need to stay in place)<br/>
		/// </summary>
		AllowCurrentNavId = 16,
		/// <summary>
		/// Store alternate result in NavMoveResultLocalVisible that only comprise elements that are already fully visible (used by PageUp/PageDown)<br/>
		/// </summary>
		AlsoScoreVisibleSet = 32,
		/// <summary>
		/// Force scrolling to min/max (used by Home/End) FIXME-NAV: Aim to remove or reword, probably unnecessary<br/>
		/// </summary>
		ScrollToEdgeY = 64,
		Forwarded = 128,
		/// <summary>
		/// Dummy scoring for debug purpose, don't apply result<br/>
		/// </summary>
		DebugNoResult = 256,
		/// <summary>
		/// Requests from focus API can land/focus/activate items even if they are marked with _NoTabStop (see NavProcessItemForTabbingRequest() for details)<br/>
		/// </summary>
		FocusApi = 512,
		/// <summary>
		/// == Focus + Activate if item is Inputable + DontChangeNavHighlight<br/>
		/// </summary>
		IsTabbing = 1024,
		/// <summary>
		/// Identify a PageDown/PageUp request.<br/>
		/// </summary>
		IsPageMove = 2048,
		/// <summary>
		/// Activate/select target item.<br/>
		/// </summary>
		Activate = 4096,
		/// <summary>
		/// Don't trigger selection by not setting g.NavJustMovedTo<br/>
		/// </summary>
		NoSelect = 8192,
		/// <summary>
		/// Do not alter the nav cursor visible state<br/>
		/// </summary>
		NoSetNavCursorVisible = 16384,
		/// <summary>
		/// (Experimental) Do not clear active id when applying move result<br/>
		/// </summary>
		NoClearActiveId = 32768,
	}

	[Flags]
	public enum ImGuiNavRenderCursorFlags
	{
		None = 0,
		/// <summary>
		/// Compact highlight, no padding/distance from focused item<br/>
		/// </summary>
		Compact = 2,
		/// <summary>
		/// Draw rectangular highlight if (g.NavId == id) even when g.NavCursorVisible == false, aka even when using the mouse.<br/>
		/// </summary>
		AlwaysDraw = 4,
		NoRounding = 8,
	}

	/// <summary>
	/// Early work-in-progress API for ScrollToItem()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiScrollFlags
	{
		None = 0,
		/// <summary>
		/// If item is not visible: scroll as little as possible on X axis to bring item back into view [default for X axis]<br/>
		/// </summary>
		KeepVisibleEdgeX = 1,
		/// <summary>
		/// If item is not visible: scroll as little as possible on Y axis to bring item back into view [default for Y axis for windows that are already visible]<br/>
		/// </summary>
		KeepVisibleEdgeY = 2,
		/// <summary>
		/// If item is not visible: scroll to make the item centered on X axis [rarely used]<br/>
		/// </summary>
		KeepVisibleCenterX = 4,
		/// <summary>
		/// If item is not visible: scroll to make the item centered on Y axis<br/>
		/// </summary>
		KeepVisibleCenterY = 8,
		/// <summary>
		/// Always center the result item on X axis [rarely used]<br/>
		/// </summary>
		AlwaysCenterX = 16,
		/// <summary>
		/// Always center the result item on Y axis [default for Y axis for appearing window)<br/>
		/// </summary>
		AlwaysCenterY = 32,
		/// <summary>
		/// Disable forwarding scrolling to parent window if required to keep item/rect visible (only scroll window the function was applied to).<br/>
		/// </summary>
		NoScrollParent = 64,
		MaskX = 21,
		MaskY = 42,
	}

	[Flags]
	public enum ImGuiActivateFlags
	{
		None = 0,
		/// <summary>
		/// Favor activation that requires keyboard text input (e.g. for Slider/Drag). Default for Enter key.<br/>
		/// </summary>
		PreferInput = 1,
		/// <summary>
		/// Favor activation for tweaking with arrows or gamepad (e.g. for Slider/Drag). Default for Space key and if keyboard is not used.<br/>
		/// </summary>
		PreferTweak = 2,
		/// <summary>
		/// Request widget to preserve state if it can (e.g. InputText will try to preserve cursor/selection)<br/>
		/// </summary>
		TryToPreserveState = 4,
		/// <summary>
		/// Activation requested by a tabbing request<br/>
		/// </summary>
		FromTabbing = 8,
		/// <summary>
		/// Activation requested by an item shortcut via SetNextItemShortcut() function.<br/>
		/// </summary>
		FromShortcut = 16,
	}

	/// <summary>
	/// Extend ImGuiInputFlags_<br/>Flags for extended versions of IsKeyPressed(), IsMouseClicked(), Shortcut(), SetKeyOwner(), SetItemKeyOwner()<br/>Don't mistake with ImGuiInputTextFlags! (which is for ImGui::InputText() function)<br/>
	/// </summary>
	[Flags]
	public enum ImGuiInputFlagsPrivate
	{
		/// <summary>
		/// Repeat rate: Regular (default)<br/>
		/// </summary>
		RepeatRateDefault = 2,
		/// <summary>
		/// Repeat rate: Fast<br/>
		/// </summary>
		RepeatRateNavMove = 4,
		/// <summary>
		/// Repeat rate: Faster<br/>
		/// </summary>
		RepeatRateNavTweak = 8,
		/// <summary>
		/// Stop repeating when released (default for all functions except Shortcut). This only exists to allow overriding Shortcut() default behavior.<br/>
		/// </summary>
		RepeatUntilRelease = 16,
		/// <summary>
		/// Stop repeating when released OR if keyboard mods are changed (default for Shortcut)<br/>
		/// </summary>
		RepeatUntilKeyModsChange = 32,
		/// <summary>
		/// Stop repeating when released OR if keyboard mods are leaving the None state. Allows going from Mod+Key to Key by releasing Mod.<br/>
		/// </summary>
		RepeatUntilKeyModsChangeFromNone = 64,
		/// <summary>
		/// Stop repeating when released OR if any other keyboard key is pressed during the repeat<br/>
		/// </summary>
		RepeatUntilOtherKeyPress = 128,
		/// <summary>
		/// Further accesses to key data will require EXPLICIT owner ID (ImGuiKeyOwner_Any/0 will NOT accepted for polling). Cleared at end of frame.<br/>
		/// </summary>
		LockThisFrame = 1048576,
		/// <summary>
		/// Further accesses to key data will require EXPLICIT owner ID (ImGuiKeyOwner_Any/0 will NOT accepted for polling). Cleared when the key is released or at end of each frame if key is released.<br/>
		/// </summary>
		LockUntilRelease = 2097152,
		/// <summary>
		/// Only set if item is hovered (default to both)<br/>
		/// </summary>
		CondHovered = 4194304,
		/// <summary>
		/// Only set if item is active (default to both)<br/>
		/// </summary>
		CondActive = 8388608,
		CondDefault = 12582912,
		RepeatRateMask = 14,
		RepeatUntilMask = 240,
		RepeatMask = 255,
		CondMask = 12582912,
		RouteTypeMask = 15360,
		RouteOptionsMask = 245760,
		SupportedByIsKeyPressed = 255,
		SupportedByIsMouseClicked = 1,
		SupportedByShortcut = 261375,
		SupportedBySetNextItemShortcut = 523519,
		SupportedBySetKeyOwner = 3145728,
		SupportedBySetItemKeyOwner = 15728640,
	}

	public enum ImGuiInputSource
	{
		None = 0,
		/// <summary>
		/// Note: may be Mouse or TouchScreen or Pen. See io.MouseSource to distinguish them.<br/>
		/// </summary>
		Mouse = 1,
		Keyboard = 2,
		Gamepad = 3,
		COUNT = 4,
	}

	/// <summary>
	/// [Internal] Key ranges<br/>[Internal] Named shortcuts for Navigation<br/>
	/// </summary>
	public enum ImGuiInputEventType
	{
		None = 0,
		MousePos = 1,
		MouseWheel = 2,
		MouseButton = 3,
		MouseViewport = 4,
		Key = 5,
		Text = 6,
		Focus = 7,
		COUNT = 8,
	}

	public enum ImGuiPopupPositionPolicy
	{
		Default = 0,
		ComboBox = 1,
		Tooltip = 2,
	}

	[Flags]
	public enum ImGuiNextItemDataFlags
	{
		None = 0,
		HasWidth = 1,
		HasOpen = 2,
		HasShortcut = 4,
		HasRefVal = 8,
		HasStorageID = 16,
	}

	[Flags]
	public enum ImGuiNextWindowDataFlags
	{
		None = 0,
		HasPos = 1,
		HasSize = 2,
		HasContentSize = 4,
		HasCollapsed = 8,
		HasSizeConstraint = 16,
		HasFocus = 32,
		HasBgAlpha = 64,
		HasScroll = 128,
		HasWindowFlags = 256,
		HasChildFlags = 512,
		HasRefreshPolicy = 1024,
		HasViewport = 2048,
		HasDock = 4096,
		HasWindowClass = 8192,
	}

	[Flags]
	public enum ImGuiWindowRefreshFlags
	{
		None = 0,
		/// <summary>
		/// [EXPERIMENTAL] Try to keep existing contents, USER MUST NOT HONOR BEGIN() RETURNING FALSE AND NOT APPEND.<br/>
		/// </summary>
		TryToAvoidRefresh = 1,
		/// <summary>
		/// [EXPERIMENTAL] Always refresh on hover<br/>
		/// </summary>
		RefreshOnHover = 2,
		/// <summary>
		/// [EXPERIMENTAL] Always refresh on focus<br/>
		/// </summary>
		RefreshOnFocus = 4,
	}

	public enum ImGuiPlotType
	{
		Lines = 0,
		Histogram = 1,
	}

	/// <summary>
	/// X/Y enums are fixed to 0/1 so they may be used to index ImVec2<br/>
	/// </summary>
	public enum ImGuiAxis
	{
		None = -1,
		X = 0,
		Y = 1,
	}

	/// <summary>
	/// Flags for LogBegin() text capturing function<br/>
	/// </summary>
	[Flags]
	public enum ImGuiLogFlags
	{
		None = 0,
		OutputTTY = 1,
		OutputFile = 2,
		OutputBuffer = 4,
		OutputClipboard = 8,
		OutputMask = 15,
	}

	/// <summary>
	/// FIXME: this is in development, not exposed/functional as a generic feature yet.<br/>Horizontal/Vertical enums are fixed to 0/1 so they may be used to index ImVec2<br/>
	/// </summary>
	public enum ImGuiLayoutType
	{
		Horizontal = 0,
		Vertical = 1,
	}

	[Flags]
	public enum ImGuiTooltipFlags
	{
		None = 0,
		/// <summary>
		/// Clear/ignore previously submitted tooltip (defaults to append)<br/>
		/// </summary>
		OverridePrevious = 2,
	}

	[Flags]
	public enum ImGuiTextFlags
	{
		None = 0,
		NoWidthForLargeClippedText = 1,
	}

	/// <summary>
	/// Flags for FocusWindow(). This is not called ImGuiFocusFlags to avoid confusion with public-facing ImGuiFocusedFlags.<br/>FIXME: Once we finishing replacing more uses of GetTopMostPopupModal()+IsWindowWithinBeginStackOf()<br/>and FindBlockingModal() with this, we may want to change the flag to be opt-out instead of opt-in.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiFocusRequestFlags
	{
		None = 0,
		/// <summary>
		/// Find last focused child (if any) and focus it instead.<br/>
		/// </summary>
		RestoreFocusedChild = 1,
		/// <summary>
		/// Do not set focus if the window is below a modal.<br/>
		/// </summary>
		UnlessBelowModal = 2,
	}

	[Flags]
	public enum ImGuiSeparatorFlags
	{
		None = 0,
		/// <summary>
		/// Axis default to current layout type, so generally Horizontal unless e.g. in a menu bar<br/>
		/// </summary>
		Horizontal = 1,
		Vertical = 2,
		/// <summary>
		/// Make separator cover all columns of a legacy Columns() set.<br/>
		/// </summary>
		SpanAllColumns = 4,
	}

	/// <summary>
	/// Extend ImGuiTreeNodeFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTreeNodeFlagsPrivate
	{
		/// <summary>
		/// FIXME-WIP: Hard-coded for CollapsingHeader()<br/>
		/// </summary>
		ClipLabelForTrailingButton = 268435456,
		/// <summary>
		/// FIXME-WIP: Turn Down arrow into an Up arrow, for reversed trees (#6517)<br/>
		/// </summary>
		UpsideDownArrow = 536870912,
		OpenOnMask = 192,
	}

	/// <summary>
	/// Extend ImGuiSelectableFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiSelectableFlagsPrivate
	{
		NoHoldingActiveID = 1048576,
		/// <summary>
		/// (WIP) Auto-select when moved into. This is not exposed in public API as to handle multi-select and modifiers we will need user to explicitly control focus scope. May be replaced with a BeginSelection() API.<br/>
		/// </summary>
		SelectOnNav = 2097152,
		/// <summary>
		/// Override button behavior to react on Click (default is Click+Release)<br/>
		/// </summary>
		SelectOnClick = 4194304,
		/// <summary>
		/// Override button behavior to react on Release (default is Click+Release)<br/>
		/// </summary>
		SelectOnRelease = 8388608,
		/// <summary>
		/// Span all avail width even if we declared less for layout purpose. FIXME: We may be able to remove this (added in 6251d379, 2bcafc86 for menus)<br/>
		/// </summary>
		SpanAvailWidth = 16777216,
		/// <summary>
		/// Set Nav/Focus ID on mouse hover (used by MenuItem)<br/>
		/// </summary>
		SetNavIdOnHover = 33554432,
		/// <summary>
		/// Disable padding each side with ItemSpacing * 0.5f<br/>
		/// </summary>
		NoPadWithHalfSpacing = 67108864,
		/// <summary>
		/// Don't set key/input owner on the initial click (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)<br/>
		/// </summary>
		NoSetKeyOwner = 134217728,
	}

	/// <summary>
	/// Extend ImGuiSliderFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiSliderFlagsPrivate
	{
		/// <summary>
		/// Should this slider be orientated vertically?<br/>
		/// </summary>
		Vertical = 1048576,
		/// <summary>
		/// Consider using g.NextItemData.ItemFlags |= ImGuiItemFlags_ReadOnly instead.<br/>
		/// </summary>
		ReadOnly = 2097152,
	}

	/// <summary>
	/// Extend ImGuiComboFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiComboFlagsPrivate
	{
		/// <summary>
		/// enable BeginComboPreview()<br/>
		/// </summary>
		CustomPreview = 1048576,
	}

	/// <summary>
	/// Extend ImGuiButtonFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiButtonFlagsPrivate
	{
		/// <summary>
		/// return true on click (mouse down event)<br/>
		/// </summary>
		PressedOnClick = 16,
		/// <summary>
		/// [Default] return true on click + release on same item &lt;-- this is what the majority of Button are using<br/>
		/// </summary>
		PressedOnClickRelease = 32,
		/// <summary>
		/// return true on click + release even if the release event is not done while hovering the item<br/>
		/// </summary>
		PressedOnClickReleaseAnywhere = 64,
		/// <summary>
		/// return true on release (default requires click+release)<br/>
		/// </summary>
		PressedOnRelease = 128,
		/// <summary>
		/// return true on double-click (default requires click+release)<br/>
		/// </summary>
		PressedOnDoubleClick = 256,
		/// <summary>
		/// return true when held into while we are drag and dropping another item (used by e.g. tree nodes, collapsing headers)<br/>
		/// </summary>
		PressedOnDragDropHold = 512,
		/// <summary>
		/// allow interactions even if a child window is overlapping<br/>
		/// </summary>
		FlattenChildren = 2048,
		/// <summary>
		/// require previous frame HoveredId to either match id or be null before being usable.<br/>
		/// </summary>
		AllowOverlap = 4096,
		/// <summary>
		/// vertically align button to match text baseline - ButtonEx() only FIXME: Should be removed and handled by SmallButton(), not possible currently because of DC.CursorPosPrevLine<br/>
		/// </summary>
		AlignTextBaseLine = 32768,
		/// <summary>
		/// disable mouse interaction if a key modifier is held<br/>
		/// </summary>
		NoKeyModsAllowed = 65536,
		/// <summary>
		/// don't set ActiveId while holding the mouse (ImGuiButtonFlags_PressedOnClick only)<br/>
		/// </summary>
		NoHoldingActiveId = 131072,
		/// <summary>
		/// don't override navigation focus when activated (FIXME: this is essentially used every time an item uses ImGuiItemFlags_NoNav, but because legacy specs don't requires LastItemData to be set ButtonBehavior(), we can't poll g.LastItemData.ItemFlags)<br/>
		/// </summary>
		NoNavFocus = 262144,
		/// <summary>
		/// don't report as hovered when nav focus is on this item<br/>
		/// </summary>
		NoHoveredOnFocus = 524288,
		/// <summary>
		/// don't set key/input owner on the initial click (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)<br/>
		/// </summary>
		NoSetKeyOwner = 1048576,
		/// <summary>
		/// don't test key/input owner when polling the key (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)<br/>
		/// </summary>
		NoTestKeyOwner = 2097152,
		PressedOnMask = 1008,
		PressedOnDefault = 32,
	}

	/// <summary>
	/// Extend ImGuiInputTextFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiInputTextFlagsPrivate
	{
		/// <summary>
		/// For internal use by InputTextMultiline()<br/>
		/// </summary>
		Multiline = 67108864,
		/// <summary>
		/// For internal use by TempInputText(), will skip calling ItemAdd(). Require bounding-box to strictly match.<br/>
		/// </summary>
		MergedItem = 134217728,
		/// <summary>
		/// For internal use by InputScalar() and TempInputScalar()<br/>
		/// </summary>
		LocalizeDecimalPoint = 268435456,
	}

	/// <summary>
	/// Extend ImGuiHoveredFlags_<br/>
	/// </summary>
	[Flags]
	public enum ImGuiHoveredFlagsPrivate
	{
		DelayMask = 245760,
		AllowedMaskForIsWindowHovered = 12479,
		AllowedMaskForIsItemHovered = 262048,
	}

	/// <summary>
	/// Status flags for an already submitted item<br/>- output: stored in g.LastItemData.StatusFlags<br/>
	/// </summary>
	[Flags]
	public enum ImGuiItemStatusFlags
	{
		None = 0,
		/// <summary>
		/// Mouse position is within item rectangle (does NOT mean that the window is in correct z-order and can be hovered!, this is only one part of the most-common IsItemHovered test)<br/>
		/// </summary>
		HoveredRect = 1,
		/// <summary>
		/// g.LastItemData.DisplayRect is valid<br/>
		/// </summary>
		HasDisplayRect = 2,
		/// <summary>
		/// Value exposed by item was edited in the current frame (should match the bool return value of most widgets)<br/>
		/// </summary>
		Edited = 4,
		/// <summary>
		/// Set when Selectable(), TreeNode() reports toggling a selection. We can't report "Selected", only state changes, in order to easily handle clipping with less issues.<br/>
		/// </summary>
		ToggledSelection = 8,
		/// <summary>
		/// Set when TreeNode() reports toggling their open state.<br/>
		/// </summary>
		ToggledOpen = 16,
		/// <summary>
		/// Set if the widget/group is able to provide data for the ImGuiItemStatusFlags_Deactivated flag.<br/>
		/// </summary>
		HasDeactivated = 32,
		/// <summary>
		/// Only valid if ImGuiItemStatusFlags_HasDeactivated is set.<br/>
		/// </summary>
		Deactivated = 64,
		/// <summary>
		/// Override the HoveredWindow test to allow cross-window hover testing.<br/>
		/// </summary>
		HoveredWindow = 128,
		/// <summary>
		/// [WIP] Set when item is overlapping the current clipping rectangle (Used internally. Please don't use yet: API/system will change as we refactor Itemadd()).<br/>
		/// </summary>
		Visible = 256,
		/// <summary>
		/// g.LastItemData.ClipRect is valid.<br/>
		/// </summary>
		HasClipRect = 512,
		/// <summary>
		/// g.LastItemData.Shortcut valid. Set by SetNextItemShortcut() -&gt; ItemAdd().<br/>
		/// </summary>
		HasShortcut = 1024,
	}

	/// <summary>
	/// Extend ImGuiItemFlags<br/>- input: PushItemFlag() manipulates g.CurrentItemFlags, g.NextItemData.ItemFlags, ItemAdd() calls may add extra flags too.<br/>- output: stored in g.LastItemData.ItemFlags<br/>
	/// </summary>
	[Flags]
	public enum ImGuiItemFlagsPrivate
	{
		/// <summary>
		/// false     Disable interactions (DOES NOT affect visuals. DO NOT mix direct use of this with BeginDisabled(). See BeginDisabled()/EndDisabled() for full disable feature, and github #211).<br/>
		/// </summary>
		Disabled = 1024,
		/// <summary>
		/// false     [ALPHA] Allow hovering interactions but underlying value is not changed.<br/>
		/// </summary>
		ReadOnly = 2048,
		/// <summary>
		/// false     [BETA] Represent a mixed/indeterminate value, generally multi-selection where values differ. Currently only supported by Checkbox() (later should support all sorts of widgets)<br/>
		/// </summary>
		MixedValue = 4096,
		/// <summary>
		/// false     Disable hoverable check in ItemHoverable()<br/>
		/// </summary>
		NoWindowHoverableCheck = 8192,
		/// <summary>
		/// false     Allow being overlapped by another widget. Not-hovered to Hovered transition deferred by a frame.<br/>
		/// </summary>
		AllowOverlap = 16384,
		/// <summary>
		/// false     Nav keyboard/gamepad mode doesn't disable hover highlight (behave as if NavHighlightItemUnderNav==false).<br/>
		/// </summary>
		NoNavDisableMouseHover = 32768,
		/// <summary>
		/// false     Skip calling MarkItemEdited()<br/>
		/// </summary>
		NoMarkEdited = 65536,
		/// <summary>
		/// false     [WIP] Auto-activate input mode when tab focused. Currently only used and supported by a few items before it becomes a generic feature.<br/>
		/// </summary>
		Inputable = 1048576,
		/// <summary>
		/// false     Set by SetNextItemSelectionUserData()<br/>
		/// </summary>
		HasSelectionUserData = 2097152,
		/// <summary>
		/// false     Set by SetNextItemSelectionUserData()<br/>
		/// </summary>
		IsMultiSelect = 4194304,
		/// <summary>
		/// Please don't change, use PushItemFlag() instead.<br/>
		/// </summary>
		Default = 16,
	}

	/// <summary>
	/// Extend ImGuiDataType_<br/>
	/// </summary>
	public enum ImGuiDataTypePrivate
	{
		Pointer = 12,
		ID = 13,
	}
}
