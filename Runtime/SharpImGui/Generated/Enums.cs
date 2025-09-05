using System;

namespace SharpImGui
{
	/// <summary>
	/// Flags for ImGui::Begin()<br/>(Those are per-window flags. There are shared flags in ImGuiIO: io.ConfigWindowsResizeFromEdges and io.ConfigWindowsMoveFromTitleBarOnly)<br/>
	/// </summary>
	[Flags]
	public enum ImGuiWindowFlags
	{
		None = 0,
		/// <summary>
		/// Disable title-bar<br/>
		/// </summary>
		NoTitleBar = 1,
		/// <summary>
		/// Disable user resizing with the lower-right grip<br/>
		/// </summary>
		NoResize = 2,
		/// <summary>
		/// Disable user moving the window<br/>
		/// </summary>
		NoMove = 4,
		/// <summary>
		/// Disable scrollbars (window can still scroll with mouse or programmatically)<br/>
		/// </summary>
		NoScrollbar = 8,
		/// <summary>
		/// Disable user vertically scrolling with mouse wheel. On child window, mouse wheel will be forwarded to the parent unless NoScrollbar is also set.<br/>
		/// </summary>
		NoScrollWithMouse = 16,
		/// <summary>
		/// Disable user collapsing window by double-clicking on it. Also referred to as Window Menu Button (e.g. within a docking node).<br/>
		/// </summary>
		NoCollapse = 32,
		/// <summary>
		/// Resize every window to its content every frame<br/>
		/// </summary>
		AlwaysAutoResize = 64,
		/// <summary>
		/// Disable drawing background color (WindowBg, etc.) and outside border. Similar as using SetNextWindowBgAlpha(0.0f).<br/>
		/// </summary>
		NoBackground = 128,
		/// <summary>
		/// Never load/save settings in .ini file<br/>
		/// </summary>
		NoSavedSettings = 256,
		/// <summary>
		/// Disable catching mouse, hovering test with pass through.<br/>
		/// </summary>
		NoMouseInputs = 512,
		/// <summary>
		/// Has a menu-bar<br/>
		/// </summary>
		MenuBar = 1024,
		/// <summary>
		/// Allow horizontal scrollbar to appear (off by default). You may use SetNextWindowContentSize(ImVec2(width,0.0f)); prior to calling Begin() to specify width. Read code in imgui_demo in the "Horizontal Scrolling" section.<br/>
		/// </summary>
		HorizontalScrollbar = 2048,
		/// <summary>
		/// Disable taking focus when transitioning from hidden to visible state<br/>
		/// </summary>
		NoFocusOnAppearing = 4096,
		/// <summary>
		/// Disable bringing window to front when taking focus (e.g. clicking on it or programmatically giving it focus)<br/>
		/// </summary>
		NoBringToFrontOnFocus = 8192,
		/// <summary>
		/// Always show vertical scrollbar (even if ContentSize.y &lt; Size.y)<br/>
		/// </summary>
		AlwaysVerticalScrollbar = 16384,
		/// <summary>
		/// Always show horizontal scrollbar (even if ContentSize.x &lt; Size.x)<br/>
		/// </summary>
		AlwaysHorizontalScrollbar = 32768,
		/// <summary>
		/// No keyboard/gamepad navigation within the window<br/>
		/// </summary>
		NoNavInputs = 65536,
		/// <summary>
		/// No focusing toward this window with keyboard/gamepad navigation (e.g. skipped by CTRL+TAB)<br/>
		/// </summary>
		NoNavFocus = 131072,
		/// <summary>
		/// Display a dot next to the title. When used in a tab/docking context, tab is selected when clicking the X + closure is not assumed (will wait for user to stop submitting the tab). Otherwise closure is assumed when pressing the X, so if you keep submitting the tab may reappear at end of tab bar.<br/>
		/// </summary>
		UnsavedDocument = 262144,
		/// <summary>
		/// Disable docking of this window<br/>
		/// </summary>
		NoDocking = 524288,
		NoNav = 196608,
		NoDecoration = 43,
		NoInputs = 197120,
		/// <summary>
		/// Don't use! For internal use by Begin()/NewFrame()<br/>
		/// </summary>
		DockNodeHost = 8388608,
		/// <summary>
		/// Don't use! For internal use by BeginChild()<br/>
		/// </summary>
		ChildWindow = 16777216,
		/// <summary>
		/// Don't use! For internal use by BeginTooltip()<br/>
		/// </summary>
		Tooltip = 33554432,
		/// <summary>
		/// Don't use! For internal use by BeginPopup()<br/>
		/// </summary>
		Popup = 67108864,
		/// <summary>
		/// Don't use! For internal use by BeginPopupModal()<br/>
		/// </summary>
		Modal = 134217728,
		/// <summary>
		/// Don't use! For internal use by BeginMenu()<br/>
		/// </summary>
		ChildMenu = 268435456,
	}

	/// <summary>
	/// Flags for ImGui::BeginChild()<br/>(Legacy: bit 0 must always correspond to ImGuiChildFlags_Borders to be backward compatible with old API using 'bool border = false'.<br/>About using AutoResizeX/AutoResizeY flags:<br/>- May be combined with SetNextWindowSizeConstraints() to set a min/max size for each axis (see "Demo-&gt;Child-&gt;Auto-resize with Constraints").<br/>- Size measurement for a given axis is only performed when the child window is within visible boundaries, or is just appearing.<br/>  - This allows BeginChild() to return false when not within boundaries (e.g. when scrolling), which is more optimal. BUT it won't update its auto-size while clipped.<br/>    While not perfect, it is a better default behavior as the always-on performance gain is more valuable than the occasional "resizing after becoming visible again" glitch.<br/>  - You may also use ImGuiChildFlags_AlwaysAutoResize to force an update even when child window is not in view.<br/>    HOWEVER PLEASE UNDERSTAND THAT DOING SO WILL PREVENT BeginChild() FROM EVER RETURNING FALSE, disabling benefits of coarse clipping.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiChildFlags
	{
		None = 0,
		/// <summary>
		/// Show an outer border and enable WindowPadding. (IMPORTANT: this is always == 1 == true for legacy reason)<br/>
		/// </summary>
		Borders = 1,
		/// <summary>
		/// Pad with style.WindowPadding even if no border are drawn (no padding by default for non-bordered child windows because it makes more sense)<br/>
		/// </summary>
		AlwaysUseWindowPadding = 2,
		/// <summary>
		/// Allow resize from right border (layout direction). Enable .ini saving (unless ImGuiWindowFlags_NoSavedSettings passed to window flags)<br/>
		/// </summary>
		ResizeX = 4,
		/// <summary>
		/// Allow resize from bottom border (layout direction). "<br/>
		/// </summary>
		ResizeY = 8,
		/// <summary>
		/// Enable auto-resizing width. Read "IMPORTANT: Size measurement" details above.<br/>
		/// </summary>
		AutoResizeX = 16,
		/// <summary>
		/// Enable auto-resizing height. Read "IMPORTANT: Size measurement" details above.<br/>
		/// </summary>
		AutoResizeY = 32,
		/// <summary>
		/// Combined with AutoResizeX/AutoResizeY. Always measure size even when child is hidden, always return true, always disable clipping optimization! NOT RECOMMENDED.<br/>
		/// </summary>
		AlwaysAutoResize = 64,
		/// <summary>
		/// Style the child window like a framed item: use FrameBg, FrameRounding, FrameBorderSize, FramePadding instead of ChildBg, ChildRounding, ChildBorderSize, WindowPadding.<br/>
		/// </summary>
		FrameStyle = 128,
		/// <summary>
		/// [BETA] Share focus scope, allow keyboard/gamepad navigation to cross over parent border to this child or between sibling child windows.<br/>
		/// </summary>
		NavFlattened = 256,
	}

	/// <summary>
	/// Flags for ImGui::PushItemFlag()<br/>(Those are shared by all items)<br/>
	/// </summary>
	[Flags]
	public enum ImGuiItemFlags
	{
		/// <summary>
		/// (Default)<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// false    Disable keyboard tabbing. This is a "lighter" version of ImGuiItemFlags_NoNav.<br/>
		/// </summary>
		NoTabStop = 1,
		/// <summary>
		/// false    Disable any form of focusing (keyboard/gamepad directional navigation and SetKeyboardFocusHere() calls).<br/>
		/// </summary>
		NoNav = 2,
		/// <summary>
		/// false    Disable item being a candidate for default focus (e.g. used by title bar items).<br/>
		/// </summary>
		NoNavDefaultFocus = 4,
		/// <summary>
		/// false    Any button-like behavior will have repeat mode enabled (based on io.KeyRepeatDelay and io.KeyRepeatRate values). Note that you can also call IsItemActive() after any button to tell if it is being held.<br/>
		/// </summary>
		ButtonRepeat = 8,
		/// <summary>
		/// true     MenuItem()/Selectable() automatically close their parent popup window.<br/>
		/// </summary>
		AutoClosePopups = 16,
		/// <summary>
		/// false    Allow submitting an item with the same identifier as an item already submitted this frame without triggering a warning tooltip if io.ConfigDebugHighlightIdConflicts is set.<br/>
		/// </summary>
		AllowDuplicateId = 32,
	}

	/// <summary>
	/// Flags for ImGui::InputText()<br/>(Those are per-item flags. There are shared flags in ImGuiIO: io.ConfigInputTextCursorBlink and io.ConfigInputTextEnterKeepActive)<br/>
	/// </summary>
	[Flags]
	public enum ImGuiInputTextFlags
	{
		None = 0,
		/// <summary>
		/// Allow 0123456789.+-*/<br/>
		/// </summary>
		CharsDecimal = 1,
		/// <summary>
		/// Allow 0123456789ABCDEFabcdef<br/>
		/// </summary>
		CharsHexadecimal = 2,
		/// <summary>
		/// Allow 0123456789.+-*/eE (Scientific notation input)<br/>
		/// </summary>
		CharsScientific = 4,
		/// <summary>
		/// Turn a..z into A..Z<br/>
		/// </summary>
		CharsUppercase = 8,
		/// <summary>
		/// Filter out spaces, tabs<br/>
		/// </summary>
		CharsNoBlank = 16,
		/// <summary>
		/// Pressing TAB input a '\t' character into the text field<br/>
		/// </summary>
		AllowTabInput = 32,
		/// <summary>
		/// Return 'true' when Enter is pressed (as opposed to every time the value was modified). Consider using IsItemDeactivatedAfterEdit() instead!<br/>
		/// </summary>
		EnterReturnsTrue = 64,
		/// <summary>
		/// Escape key clears content if not empty, and deactivate otherwise (contrast to default behavior of Escape to revert)<br/>
		/// </summary>
		EscapeClearsAll = 128,
		/// <summary>
		/// In multi-line mode, validate with Enter, add new line with Ctrl+Enter (default is opposite: validate with Ctrl+Enter, add line with Enter).<br/>
		/// </summary>
		CtrlEnterForNewLine = 256,
		/// <summary>
		/// Read-only mode<br/>
		/// </summary>
		ReadOnly = 512,
		/// <summary>
		/// Password mode, display all characters as '*', disable copy<br/>
		/// </summary>
		Password = 1024,
		/// <summary>
		/// Overwrite mode<br/>
		/// </summary>
		AlwaysOverwrite = 2048,
		/// <summary>
		/// Select entire text when first taking mouse focus<br/>
		/// </summary>
		AutoSelectAll = 4096,
		/// <summary>
		/// InputFloat(), InputInt(), InputScalar() etc. only: parse empty string as zero value.<br/>
		/// </summary>
		ParseEmptyRefVal = 8192,
		/// <summary>
		/// InputFloat(), InputInt(), InputScalar() etc. only: when value is zero, do not display it. Generally used with ImGuiInputTextFlags_ParseEmptyRefVal.<br/>
		/// </summary>
		DisplayEmptyRefVal = 16384,
		/// <summary>
		/// Disable following the cursor horizontally<br/>
		/// </summary>
		NoHorizontalScroll = 32768,
		/// <summary>
		/// Disable undo/redo. Note that input text owns the text data while active, if you want to provide your own undo/redo stack you need e.g. to call ClearActiveID().<br/>
		/// </summary>
		NoUndoRedo = 65536,
		/// <summary>
		/// When text doesn't fit, elide left side to ensure right side stays visible. Useful for path/filenames. Single-line only!<br/>
		/// </summary>
		ElideLeft = 131072,
		/// <summary>
		/// Callback on pressing TAB (for completion handling)<br/>
		/// </summary>
		CallbackCompletion = 262144,
		/// <summary>
		/// Callback on pressing Up/Down arrows (for history handling)<br/>
		/// </summary>
		CallbackHistory = 524288,
		/// <summary>
		/// Callback on each iteration. User code may query cursor position, modify text buffer.<br/>
		/// </summary>
		CallbackAlways = 1048576,
		/// <summary>
		/// Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.<br/>
		/// </summary>
		CallbackCharFilter = 2097152,
		/// <summary>
		/// Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow. Notify when the string wants to be resized (for string types which hold a cache of their Size). You will be provided a new BufSize in the callback and NEED to honor it. (see misc/cpp/imgui_stdlib.h for an example of using this)<br/>
		/// </summary>
		CallbackResize = 4194304,
		/// <summary>
		/// Callback on any edit. Note that InputText() already returns true on edit + you can always use IsItemEdited(). The callback is useful to manipulate the underlying buffer while focus is active.<br/>
		/// </summary>
		CallbackEdit = 8388608,
	}

	/// <summary>
	/// Flags for ImGui::TreeNodeEx(), ImGui::CollapsingHeader*()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTreeNodeFlags
	{
		None = 0,
		/// <summary>
		/// Draw as selected<br/>
		/// </summary>
		Selected = 1,
		/// <summary>
		/// Draw frame with background (e.g. for CollapsingHeader)<br/>
		/// </summary>
		Framed = 2,
		/// <summary>
		/// Hit testing to allow subsequent widgets to overlap this one<br/>
		/// </summary>
		AllowOverlap = 4,
		/// <summary>
		/// Don't do a TreePush() when open (e.g. for CollapsingHeader) = no extra indent nor pushing on ID stack<br/>
		/// </summary>
		NoTreePushOnOpen = 8,
		/// <summary>
		/// Don't automatically and temporarily open node when Logging is active (by default logging will automatically open tree nodes)<br/>
		/// </summary>
		NoAutoOpenOnLog = 16,
		/// <summary>
		/// Default node to be open<br/>
		/// </summary>
		DefaultOpen = 32,
		/// <summary>
		/// Open on double-click instead of simple click (default for multi-select unless any _OpenOnXXX behavior is set explicitly). Both behaviors may be combined.<br/>
		/// </summary>
		OpenOnDoubleClick = 64,
		/// <summary>
		/// Open when clicking on the arrow part (default for multi-select unless any _OpenOnXXX behavior is set explicitly). Both behaviors may be combined.<br/>
		/// </summary>
		OpenOnArrow = 128,
		/// <summary>
		/// No collapsing, no arrow (use as a convenience for leaf nodes).<br/>
		/// </summary>
		Leaf = 256,
		/// <summary>
		/// Display a bullet instead of arrow. IMPORTANT: node can still be marked open/close if you don't set the _Leaf flag!<br/>
		/// </summary>
		Bullet = 512,
		/// <summary>
		/// Use FramePadding (even for an unframed text node) to vertically align text baseline to regular widget height. Equivalent to calling AlignTextToFramePadding() before the node.<br/>
		/// </summary>
		FramePadding = 1024,
		/// <summary>
		/// Extend hit box to the right-most edge, even if not framed. This is not the default in order to allow adding other items on the same line without using AllowOverlap mode.<br/>
		/// </summary>
		SpanAvailWidth = 2048,
		/// <summary>
		/// Extend hit box to the left-most and right-most edges (cover the indent area).<br/>
		/// </summary>
		SpanFullWidth = 4096,
		/// <summary>
		/// Narrow hit box + narrow hovering highlight, will only cover the label text.<br/>
		/// </summary>
		SpanLabelWidth = 8192,
		/// <summary>
		/// Frame will span all columns of its container table (label will still fit in current column)<br/>
		/// </summary>
		SpanAllColumns = 16384,
		/// <summary>
		/// Label will span all columns of its container table<br/>
		/// </summary>
		LabelSpanAllColumns = 32768,
		/// <summary>
		/// (WIP) Nav: left direction may move to this TreeNode() from any of its child (items submitted between TreeNode and TreePop)<br/>
		/// </summary>
		NavLeftJumpsBackHere = 131072,
		CollapsingHeader = 26,
	}

	/// <summary>
	/// Flags for OpenPopup*(), BeginPopupContext*(), IsPopupOpen() functions.<br/>- To be backward compatible with older API which took an 'int mouse_button = 1' argument instead of 'ImGuiPopupFlags flags',<br/>  we need to treat small flags values as a mouse button index, so we encode the mouse button in the first few bits of the flags.<br/>  It is therefore guaranteed to be legal to pass a mouse button index in ImGuiPopupFlags.<br/>- For the same reason, we exceptionally default the ImGuiPopupFlags argument of BeginPopupContextXXX functions to 1 instead of 0.<br/>  IMPORTANT: because the default parameter is 1 (==ImGuiPopupFlags_MouseButtonRight), if you rely on the default parameter<br/>  and want to use another flag, you need to pass in the ImGuiPopupFlags_MouseButtonRight flag explicitly.<br/>- Multiple buttons currently cannot be combined/or-ed in those functions (we could allow it later).<br/>
	/// </summary>
	[Flags]
	public enum ImGuiPopupFlags
	{
		None = 0,
		/// <summary>
		/// For BeginPopupContext*(): open on Left Mouse release. Guaranteed to always be == 0 (same as ImGuiMouseButton_Left)<br/>
		/// </summary>
		MouseButtonLeft = 0,
		/// <summary>
		/// For BeginPopupContext*(): open on Right Mouse release. Guaranteed to always be == 1 (same as ImGuiMouseButton_Right)<br/>
		/// </summary>
		MouseButtonRight = 1,
		/// <summary>
		/// For BeginPopupContext*(): open on Middle Mouse release. Guaranteed to always be == 2 (same as ImGuiMouseButton_Middle)<br/>
		/// </summary>
		MouseButtonMiddle = 2,
		MouseButtonMask = 31,
		MouseButtonDefault = 1,
		/// <summary>
		/// For OpenPopup*(), BeginPopupContext*(): don't reopen same popup if already open (won't reposition, won't reinitialize navigation)<br/>
		/// </summary>
		NoReopen = 32,
		/// <summary>
		/// For OpenPopup*(), BeginPopupContext*(): don't open if there's already a popup at the same level of the popup stack<br/>
		/// </summary>
		NoOpenOverExistingPopup = 128,
		/// <summary>
		/// For BeginPopupContextWindow(): don't return true when hovering items, only when hovering empty space<br/>
		/// </summary>
		NoOpenOverItems = 256,
		/// <summary>
		/// For IsPopupOpen(): ignore the ImGuiID parameter and test for any popup.<br/>
		/// </summary>
		AnyPopupId = 1024,
		/// <summary>
		/// For IsPopupOpen(): search/test at any level of the popup stack (default test in the current level)<br/>
		/// </summary>
		AnyPopupLevel = 2048,
		AnyPopup = 3072,
	}

	/// <summary>
	/// Flags for ImGui::Selectable()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiSelectableFlags
	{
		None = 0,
		/// <summary>
		/// Clicking this doesn't close parent popup window (overrides ImGuiItemFlags_AutoClosePopups)<br/>
		/// </summary>
		NoAutoClosePopups = 1,
		/// <summary>
		/// Frame will span all columns of its container table (text will still fit in current column)<br/>
		/// </summary>
		SpanAllColumns = 2,
		/// <summary>
		/// Generate press events on double clicks too<br/>
		/// </summary>
		AllowDoubleClick = 4,
		/// <summary>
		/// Cannot be selected, display grayed out text<br/>
		/// </summary>
		Disabled = 8,
		/// <summary>
		/// (WIP) Hit testing to allow subsequent widgets to overlap this one<br/>
		/// </summary>
		AllowOverlap = 16,
		/// <summary>
		/// Make the item be displayed as if it is hovered<br/>
		/// </summary>
		Highlight = 32,
	}

	/// <summary>
	/// Flags for ImGui::BeginCombo()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiComboFlags
	{
		None = 0,
		/// <summary>
		/// Align the popup toward the left by default<br/>
		/// </summary>
		PopupAlignLeft = 1,
		/// <summary>
		/// Max ~4 items visible. Tip: If you want your combo popup to be a specific size you can use SetNextWindowSizeConstraints() prior to calling BeginCombo()<br/>
		/// </summary>
		HeightSmall = 2,
		/// <summary>
		/// Max ~8 items visible (default)<br/>
		/// </summary>
		HeightRegular = 4,
		/// <summary>
		/// Max ~20 items visible<br/>
		/// </summary>
		HeightLarge = 8,
		/// <summary>
		/// As many fitting items as possible<br/>
		/// </summary>
		HeightLargest = 16,
		/// <summary>
		/// Display on the preview box without the square arrow button<br/>
		/// </summary>
		NoArrowButton = 32,
		/// <summary>
		/// Display only a square arrow button<br/>
		/// </summary>
		NoPreview = 64,
		/// <summary>
		/// Width dynamically calculated from preview contents<br/>
		/// </summary>
		WidthFitPreview = 128,
		HeightMask = 30,
	}

	/// <summary>
	/// Flags for ImGui::BeginTabBar()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTabBarFlags
	{
		None = 0,
		/// <summary>
		/// Allow manually dragging tabs to re-order them + New tabs are appended at the end of list<br/>
		/// </summary>
		Reorderable = 1,
		/// <summary>
		/// Automatically select new tabs when they appear<br/>
		/// </summary>
		AutoSelectNewTabs = 2,
		/// <summary>
		/// Disable buttons to open the tab list popup<br/>
		/// </summary>
		TabListPopupButton = 4,
		/// <summary>
		/// Disable behavior of closing tabs (that are submitted with p_open != NULL) with middle mouse button. You may handle this behavior manually on user's side with if (IsItemHovered() && IsMouseClicked(2)) *p_open = false.<br/>
		/// </summary>
		NoCloseWithMiddleMouseButton = 8,
		/// <summary>
		/// Disable scrolling buttons (apply when fitting policy is ImGuiTabBarFlags_FittingPolicyScroll)<br/>
		/// </summary>
		NoTabListScrollingButtons = 16,
		/// <summary>
		/// Disable tooltips when hovering a tab<br/>
		/// </summary>
		NoTooltip = 32,
		/// <summary>
		/// Draw selected overline markers over selected tab<br/>
		/// </summary>
		DrawSelectedOverline = 64,
		/// <summary>
		/// Resize tabs when they don't fit<br/>
		/// </summary>
		FittingPolicyResizeDown = 128,
		/// <summary>
		/// Add scroll buttons when tabs don't fit<br/>
		/// </summary>
		FittingPolicyScroll = 256,
		FittingPolicyMask = 384,
		FittingPolicyDefault = 128,
	}

	/// <summary>
	/// Flags for ImGui::BeginTabItem()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTabItemFlags
	{
		None = 0,
		/// <summary>
		/// Display a dot next to the title + set ImGuiTabItemFlags_NoAssumedClosure.<br/>
		/// </summary>
		UnsavedDocument = 1,
		/// <summary>
		/// Trigger flag to programmatically make the tab selected when calling BeginTabItem()<br/>
		/// </summary>
		SetSelected = 2,
		/// <summary>
		/// Disable behavior of closing tabs (that are submitted with p_open != NULL) with middle mouse button. You may handle this behavior manually on user's side with if (IsItemHovered() && IsMouseClicked(2)) *p_open = false.<br/>
		/// </summary>
		NoCloseWithMiddleMouseButton = 4,
		/// <summary>
		/// Don't call PushID()/PopID() on BeginTabItem()/EndTabItem()<br/>
		/// </summary>
		NoPushId = 8,
		/// <summary>
		/// Disable tooltip for the given tab<br/>
		/// </summary>
		NoTooltip = 16,
		/// <summary>
		/// Disable reordering this tab or having another tab cross over this tab<br/>
		/// </summary>
		NoReorder = 32,
		/// <summary>
		/// Enforce the tab position to the left of the tab bar (after the tab list popup button)<br/>
		/// </summary>
		Leading = 64,
		/// <summary>
		/// Enforce the tab position to the right of the tab bar (before the scrolling buttons)<br/>
		/// </summary>
		Trailing = 128,
		/// <summary>
		/// Tab is selected when trying to close + closure is not immediately assumed (will wait for user to stop submitting the tab). Otherwise closure is assumed when pressing the X, so if you keep submitting the tab may reappear at end of tab bar.<br/>
		/// </summary>
		NoAssumedClosure = 256,
	}

	/// <summary>
	/// Flags for ImGui::IsWindowFocused()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiFocusedFlags
	{
		None = 0,
		/// <summary>
		/// Return true if any children of the window is focused<br/>
		/// </summary>
		ChildWindows = 1,
		/// <summary>
		/// Test from root window (top most parent of the current hierarchy)<br/>
		/// </summary>
		RootWindow = 2,
		/// <summary>
		/// Return true if any window is focused. Important: If you are trying to tell how to dispatch your low-level inputs, do NOT use this. Use 'io.WantCaptureMouse' instead! Please read the FAQ!<br/>
		/// </summary>
		AnyWindow = 4,
		/// <summary>
		/// Do not consider popup hierarchy (do not treat popup emitter as parent of popup) (when used with _ChildWindows or _RootWindow)<br/>
		/// </summary>
		NoPopupHierarchy = 8,
		/// <summary>
		/// Consider docking hierarchy (treat dockspace host as parent of docked window) (when used with _ChildWindows or _RootWindow)<br/>
		/// </summary>
		DockHierarchy = 16,
		RootAndChildWindows = 3,
	}

	/// <summary>
	/// Flags for ImGui::IsItemHovered(), ImGui::IsWindowHovered()<br/>Note: if you are trying to check whether your mouse should be dispatched to Dear ImGui or to your app, you should use 'io.WantCaptureMouse' instead! Please read the FAQ!<br/>Note: windows with the ImGuiWindowFlags_NoInputs flag are ignored by IsWindowHovered() calls.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiHoveredFlags
	{
		/// <summary>
		/// Return true if directly over the item/window, not obstructed by another window, not obstructed by an active popup or modal blocking inputs under them.<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// IsWindowHovered() only: Return true if any children of the window is hovered<br/>
		/// </summary>
		ChildWindows = 1,
		/// <summary>
		/// IsWindowHovered() only: Test from root window (top most parent of the current hierarchy)<br/>
		/// </summary>
		RootWindow = 2,
		/// <summary>
		/// IsWindowHovered() only: Return true if any window is hovered<br/>
		/// </summary>
		AnyWindow = 4,
		/// <summary>
		/// IsWindowHovered() only: Do not consider popup hierarchy (do not treat popup emitter as parent of popup) (when used with _ChildWindows or _RootWindow)<br/>
		/// </summary>
		NoPopupHierarchy = 8,
		/// <summary>
		/// IsWindowHovered() only: Consider docking hierarchy (treat dockspace host as parent of docked window) (when used with _ChildWindows or _RootWindow)<br/>
		/// </summary>
		DockHierarchy = 16,
		/// <summary>
		/// Return true even if a popup window is normally blocking access to this item/window<br/>
		/// </summary>
		AllowWhenBlockedByPopup = 32,
		/// <summary>
		/// Return true even if an active item is blocking access to this item/window. Useful for Drag and Drop patterns.<br/>
		/// </summary>
		AllowWhenBlockedByActiveItem = 128,
		/// <summary>
		/// IsItemHovered() only: Return true even if the item uses AllowOverlap mode and is overlapped by another hoverable item.<br/>
		/// </summary>
		AllowWhenOverlappedByItem = 256,
		/// <summary>
		/// IsItemHovered() only: Return true even if the position is obstructed or overlapped by another window.<br/>
		/// </summary>
		AllowWhenOverlappedByWindow = 512,
		/// <summary>
		/// IsItemHovered() only: Return true even if the item is disabled<br/>
		/// </summary>
		AllowWhenDisabled = 1024,
		/// <summary>
		/// IsItemHovered() only: Disable using keyboard/gamepad navigation state when active, always query mouse<br/>
		/// </summary>
		NoNavOverride = 2048,
		AllowWhenOverlapped = 768,
		RectOnly = 928,
		RootAndChildWindows = 3,
		/// <summary>
		/// Shortcut for standard flags when using IsItemHovered() + SetTooltip() sequence.<br/>
		/// </summary>
		ForTooltip = 4096,
		/// <summary>
		/// Require mouse to be stationary for style.HoverStationaryDelay (~0.15 sec) _at least one time_. After this, can move on same item/window. Using the stationary test tends to reduces the need for a long delay.<br/>
		/// </summary>
		Stationary = 8192,
		/// <summary>
		/// IsItemHovered() only: Return true immediately (default). As this is the default you generally ignore this.<br/>
		/// </summary>
		DelayNone = 16384,
		/// <summary>
		/// IsItemHovered() only: Return true after style.HoverDelayShort elapsed (~0.15 sec) (shared between items) + requires mouse to be stationary for style.HoverStationaryDelay (once per item).<br/>
		/// </summary>
		DelayShort = 32768,
		/// <summary>
		/// IsItemHovered() only: Return true after style.HoverDelayNormal elapsed (~0.40 sec) (shared between items) + requires mouse to be stationary for style.HoverStationaryDelay (once per item).<br/>
		/// </summary>
		DelayNormal = 65536,
		/// <summary>
		/// IsItemHovered() only: Disable shared delay system where moving from one item to the next keeps the previous timer for a short time (standard for tooltips with long delays)<br/>
		/// </summary>
		NoSharedDelay = 131072,
	}

	/// <summary>
	/// Flags for ImGui::DockSpace(), shared/inherited by child nodes.<br/>(Some flags can be applied to individual nodes directly)<br/>FIXME-DOCK: Also see ImGuiDockNodeFlagsPrivate_ which may involve using the WIP and internal DockBuilder api.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiDockNodeFlags
	{
		None = 0,
		/// <summary>
		///       Don't display the dockspace node but keep it alive. Windows docked into this dockspace node won't be undocked.<br/>
		/// </summary>
		KeepAliveOnly = 1,
		/// <summary>
		///       Disable docking over the Central Node, which will be always kept empty.<br/>
		/// </summary>
		NoDockingOverCentralNode = 4,
		/// <summary>
		///       Enable passthru dockspace: 1) DockSpace() will render a ImGuiCol_WindowBg background covering everything excepted the Central Node when empty. Meaning the host window should probably use SetNextWindowBgAlpha(0.0f) prior to Begin() when using this. 2) When Central Node is empty: let inputs pass-through + won't display a DockingEmptyBg background. See demo for details.<br/>
		/// </summary>
		PassthruCentralNode = 8,
		/// <summary>
		///       Disable other windows/nodes from splitting this node.<br/>
		/// </summary>
		NoDockingSplit = 16,
		/// <summary>
		/// Saved Disable resizing node using the splitter/separators. Useful with programmatically setup dockspaces.<br/>
		/// </summary>
		NoResize = 32,
		/// <summary>
		///       Tab bar will automatically hide when there is a single window in the dock node.<br/>
		/// </summary>
		AutoHideTabBar = 64,
		/// <summary>
		///       Disable undocking this node.<br/>
		/// </summary>
		NoUndocking = 128,
	}

	/// <summary>
	/// Flags for ImGui::BeginDragDropSource(), ImGui::AcceptDragDropPayload()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiDragDropFlags
	{
		None = 0,
		/// <summary>
		/// Disable preview tooltip. By default, a successful call to BeginDragDropSource opens a tooltip so you can display a preview or description of the source contents. This flag disables this behavior.<br/>
		/// </summary>
		SourceNoPreviewTooltip = 1,
		/// <summary>
		/// By default, when dragging we clear data so that IsItemHovered() will return false, to avoid subsequent user code submitting tooltips. This flag disables this behavior so you can still call IsItemHovered() on the source item.<br/>
		/// </summary>
		SourceNoDisableHover = 2,
		/// <summary>
		/// Disable the behavior that allows to open tree nodes and collapsing header by holding over them while dragging a source item.<br/>
		/// </summary>
		SourceNoHoldToOpenOthers = 4,
		/// <summary>
		/// Allow items such as Text(), Image() that have no unique identifier to be used as drag source, by manufacturing a temporary identifier based on their window-relative position. This is extremely unusual within the dear imgui ecosystem and so we made it explicit.<br/>
		/// </summary>
		SourceAllowNullID = 8,
		/// <summary>
		/// External source (from outside of dear imgui), won't attempt to read current item/window info. Will always return true. Only one Extern source can be active simultaneously.<br/>
		/// </summary>
		SourceExtern = 16,
		/// <summary>
		/// Automatically expire the payload if the source cease to be submitted (otherwise payloads are persisting while being dragged)<br/>
		/// </summary>
		PayloadAutoExpire = 32,
		/// <summary>
		/// Hint to specify that the payload may not be copied outside current dear imgui context.<br/>
		/// </summary>
		PayloadNoCrossContext = 64,
		/// <summary>
		/// Hint to specify that the payload may not be copied outside current process.<br/>
		/// </summary>
		PayloadNoCrossProcess = 128,
		/// <summary>
		/// AcceptDragDropPayload() will returns true even before the mouse button is released. You can then call IsDelivery() to test if the payload needs to be delivered.<br/>
		/// </summary>
		AcceptBeforeDelivery = 1024,
		/// <summary>
		/// Do not draw the default highlight rectangle when hovering over target.<br/>
		/// </summary>
		AcceptNoDrawDefaultRect = 2048,
		/// <summary>
		/// Request hiding the BeginDragDropSource tooltip from the BeginDragDropTarget site.<br/>
		/// </summary>
		AcceptNoPreviewTooltip = 4096,
		/// <summary>
		/// For peeking ahead and inspecting the payload before delivery.<br/>
		/// </summary>
		AcceptPeekOnly = 3072,
	}

	/// <summary>
	/// A primary data type<br/>
	/// </summary>
	public enum ImGuiDataType
	{
		/// <summary>
		/// signed char / char (with sensible compilers)<br/>
		/// </summary>
		S8 = 0,
		/// <summary>
		/// unsigned char<br/>
		/// </summary>
		U8 = 1,
		/// <summary>
		/// short<br/>
		/// </summary>
		S16 = 2,
		/// <summary>
		/// unsigned short<br/>
		/// </summary>
		U16 = 3,
		/// <summary>
		/// int<br/>
		/// </summary>
		S32 = 4,
		/// <summary>
		/// unsigned int<br/>
		/// </summary>
		U32 = 5,
		/// <summary>
		/// long long / __int64<br/>
		/// </summary>
		S64 = 6,
		/// <summary>
		/// unsigned long long / unsigned __int64<br/>
		/// </summary>
		U64 = 7,
		/// <summary>
		/// float<br/>
		/// </summary>
		Float = 8,
		/// <summary>
		/// double<br/>
		/// </summary>
		Double = 9,
		/// <summary>
		/// bool (provided for user convenience, not supported by scalar widgets)<br/>
		/// </summary>
		Bool = 10,
		/// <summary>
		/// char* (provided for user convenience, not supported by scalar widgets)<br/>
		/// </summary>
		String = 11,
		COUNT = 12,
	}

	/// <summary>
	/// A cardinal direction<br/>
	/// </summary>
	public enum ImGuiDir
	{
		None = -1,
		Left = 0,
		Right = 1,
		Up = 2,
		Down = 3,
		COUNT = 4,
	}

	/// <summary>
	/// A sorting direction<br/>
	/// </summary>
	public enum ImGuiSortDirection
	{
		None = 0,
		/// <summary>
		/// Ascending = 0-&gt;9, A-&gt;Z etc.<br/>
		/// </summary>
		Ascending = 1,
		/// <summary>
		/// Descending = 9-&gt;0, Z-&gt;A etc.<br/>
		/// </summary>
		Descending = 2,
	}

	/// <summary>
	/// A key identifier (ImGuiKey_XXX or ImGuiMod_XXX value): can represent Keyboard, Mouse and Gamepad values.<br/>All our named keys are &gt;= 512. Keys value 0 to 511 are left unused and were legacy native/opaque key values (&lt; 1.87).<br/>Support for legacy keys was completely removed in 1.91.5.<br/>Read details about the 1.87+ transition : https://github.com/ocornut/imgui/issues/4921<br/>Note that "Keys" related to physical keys and are not the same concept as input "Characters", the later are submitted via io.AddInputCharacter().<br/>The keyboard key enum values are named after the keys on a standard US keyboard, and on other keyboard types the keys reported may not match the keycaps.<br/>
	/// </summary>
	public enum ImGuiKey
	{
		None = 0,
		/// <summary>
		/// First valid key value (other than 0)<br/>
		/// </summary>
		NamedKeyBEGIN = 512,
		/// <summary>
		/// == ImGuiKey_NamedKey_BEGIN<br/>
		/// </summary>
		Tab = 512,
		LeftArrow = 513,
		RightArrow = 514,
		UpArrow = 515,
		DownArrow = 516,
		PageUp = 517,
		PageDown = 518,
		Home = 519,
		End = 520,
		Insert = 521,
		Delete = 522,
		Backspace = 523,
		Space = 524,
		Enter = 525,
		Escape = 526,
		LeftCtrl = 527,
		LeftShift = 528,
		LeftAlt = 529,
		LeftSuper = 530,
		RightCtrl = 531,
		RightShift = 532,
		RightAlt = 533,
		RightSuper = 534,
		Menu = 535,
		_0 = 536,
		_1 = 537,
		_2 = 538,
		_3 = 539,
		_4 = 540,
		_5 = 541,
		_6 = 542,
		_7 = 543,
		_8 = 544,
		_9 = 545,
		A = 546,
		B = 547,
		C = 548,
		D = 549,
		E = 550,
		F = 551,
		G = 552,
		H = 553,
		I = 554,
		J = 555,
		K = 556,
		L = 557,
		M = 558,
		N = 559,
		O = 560,
		P = 561,
		Q = 562,
		R = 563,
		S = 564,
		T = 565,
		U = 566,
		V = 567,
		W = 568,
		X = 569,
		Y = 570,
		Z = 571,
		F1 = 572,
		F2 = 573,
		F3 = 574,
		F4 = 575,
		F5 = 576,
		F6 = 577,
		F7 = 578,
		F8 = 579,
		F9 = 580,
		F10 = 581,
		F11 = 582,
		F12 = 583,
		F13 = 584,
		F14 = 585,
		F15 = 586,
		F16 = 587,
		F17 = 588,
		F18 = 589,
		F19 = 590,
		F20 = 591,
		F21 = 592,
		F22 = 593,
		F23 = 594,
		F24 = 595,
		/// <summary>
		/// '<br/>
		/// </summary>
		Apostrophe = 596,
		/// <summary>
		/// ,<br/>
		/// </summary>
		Comma = 597,
		/// <summary>
		/// -<br/>
		/// </summary>
		Minus = 598,
		/// <summary>
		/// .<br/>
		/// </summary>
		Period = 599,
		/// <summary>
		/// /<br/>
		/// </summary>
		Slash = 600,
		/// <summary>
		/// ;<br/>
		/// </summary>
		Semicolon = 601,
		/// <summary>
		/// =<br/>
		/// </summary>
		Equal = 602,
		/// <summary>
		/// [<br/>
		/// </summary>
		LeftBracket = 603,
		/// <summary>
		/// \ (this text inhibit multiline comment caused by backslash)<br/>
		/// </summary>
		Backslash = 604,
		/// <summary>
		/// ]<br/>
		/// </summary>
		RightBracket = 605,
		/// <summary>
		/// `<br/>
		/// </summary>
		GraveAccent = 606,
		CapsLock = 607,
		ScrollLock = 608,
		NumLock = 609,
		PrintScreen = 610,
		Pause = 611,
		Keypad0 = 612,
		Keypad1 = 613,
		Keypad2 = 614,
		Keypad3 = 615,
		Keypad4 = 616,
		Keypad5 = 617,
		Keypad6 = 618,
		Keypad7 = 619,
		Keypad8 = 620,
		Keypad9 = 621,
		KeypadDecimal = 622,
		KeypadDivide = 623,
		KeypadMultiply = 624,
		KeypadSubtract = 625,
		KeypadAdd = 626,
		KeypadEnter = 627,
		KeypadEqual = 628,
		/// <summary>
		/// Available on some keyboard/mouses. Often referred as "Browser Back"<br/>
		/// </summary>
		AppBack = 629,
		AppForward = 630,
		/// <summary>
		/// Non-US backslash.<br/>
		/// </summary>
		Oem102 = 631,
		/// <summary>
		/// Menu (Xbox)      + (Switch)   Start/Options (PS)<br/>
		/// </summary>
		GamepadStart = 632,
		/// <summary>
		/// View (Xbox)      - (Switch)   Share (PS)<br/>
		/// </summary>
		GamepadBack = 633,
		/// <summary>
		/// X (Xbox)         Y (Switch)   Square (PS)        Tap: Toggle Menu. Hold: Windowing mode (Focus/Move/Resize windows)<br/>
		/// </summary>
		GamepadFaceLeft = 634,
		/// <summary>
		/// B (Xbox)         A (Switch)   Circle (PS)        Cancel / Close / Exit<br/>
		/// </summary>
		GamepadFaceRight = 635,
		/// <summary>
		/// Y (Xbox)         X (Switch)   Triangle (PS)      Text Input / On-screen Keyboard<br/>
		/// </summary>
		GamepadFaceUp = 636,
		/// <summary>
		/// A (Xbox)         B (Switch)   Cross (PS)         Activate / Open / Toggle / Tweak<br/>
		/// </summary>
		GamepadFaceDown = 637,
		/// <summary>
		/// D-pad Left                                       Move / Tweak / Resize Window (in Windowing mode)<br/>
		/// </summary>
		GamepadDpadLeft = 638,
		/// <summary>
		/// D-pad Right                                      Move / Tweak / Resize Window (in Windowing mode)<br/>
		/// </summary>
		GamepadDpadRight = 639,
		/// <summary>
		/// D-pad Up                                         Move / Tweak / Resize Window (in Windowing mode)<br/>
		/// </summary>
		GamepadDpadUp = 640,
		/// <summary>
		/// D-pad Down                                       Move / Tweak / Resize Window (in Windowing mode)<br/>
		/// </summary>
		GamepadDpadDown = 641,
		/// <summary>
		/// L Bumper (Xbox)  L (Switch)   L1 (PS)            Tweak Slower / Focus Previous (in Windowing mode)<br/>
		/// </summary>
		GamepadL1 = 642,
		/// <summary>
		/// R Bumper (Xbox)  R (Switch)   R1 (PS)            Tweak Faster / Focus Next (in Windowing mode)<br/>
		/// </summary>
		GamepadR1 = 643,
		/// <summary>
		/// L Trig. (Xbox)   ZL (Switch)  L2 (PS) [Analog]<br/>
		/// </summary>
		GamepadL2 = 644,
		/// <summary>
		/// R Trig. (Xbox)   ZR (Switch)  R2 (PS) [Analog]<br/>
		/// </summary>
		GamepadR2 = 645,
		/// <summary>
		/// L Stick (Xbox)   L3 (Switch)  L3 (PS)<br/>
		/// </summary>
		GamepadL3 = 646,
		/// <summary>
		/// R Stick (Xbox)   R3 (Switch)  R3 (PS)<br/>
		/// </summary>
		GamepadR3 = 647,
		/// <summary>
		/// [Analog]                                         Move Window (in Windowing mode)<br/>
		/// </summary>
		GamepadLStickLeft = 648,
		/// <summary>
		/// [Analog]                                         Move Window (in Windowing mode)<br/>
		/// </summary>
		GamepadLStickRight = 649,
		/// <summary>
		/// [Analog]                                         Move Window (in Windowing mode)<br/>
		/// </summary>
		GamepadLStickUp = 650,
		/// <summary>
		/// [Analog]                                         Move Window (in Windowing mode)<br/>
		/// </summary>
		GamepadLStickDown = 651,
		/// <summary>
		/// [Analog]<br/>
		/// </summary>
		GamepadRStickLeft = 652,
		/// <summary>
		/// [Analog]<br/>
		/// </summary>
		GamepadRStickRight = 653,
		/// <summary>
		/// [Analog]<br/>
		/// </summary>
		GamepadRStickUp = 654,
		/// <summary>
		/// [Analog]<br/>
		/// </summary>
		GamepadRStickDown = 655,
		MouseLeft = 656,
		MouseRight = 657,
		MouseMiddle = 658,
		MouseX1 = 659,
		MouseX2 = 660,
		MouseWheelX = 661,
		MouseWheelY = 662,
		ReservedForModCtrl = 663,
		ReservedForModShift = 664,
		ReservedForModAlt = 665,
		ReservedForModSuper = 666,
		NamedKeyEND = 667,
		ImGuiModNone = 0,
		/// <summary>
		/// Ctrl (non-macOS), Cmd (macOS)<br/>
		/// </summary>
		ImGuiModCtrl = 4096,
		/// <summary>
		/// Shift<br/>
		/// </summary>
		ImGuiModShift = 8192,
		/// <summary>
		/// Option/Menu<br/>
		/// </summary>
		ImGuiModAlt = 16384,
		/// <summary>
		/// Windows/Super (non-macOS), Ctrl (macOS)<br/>
		/// </summary>
		ImGuiModSuper = 32768,
		/// <summary>
		/// 4-bits<br/>
		/// </summary>
		ImGuiModMask = 61440,
		NamedKeyCOUNT = 155,
	}

	/// <summary>
	/// Flags for Shortcut(), SetNextItemShortcut(),<br/>(and for upcoming extended versions of IsKeyPressed(), IsMouseClicked(), Shortcut(), SetKeyOwner(), SetItemKeyOwner() that are still in imgui_internal.h)<br/>Don't mistake with ImGuiInputTextFlags! (which is for ImGui::InputText() function)<br/>
	/// </summary>
	[Flags]
	public enum ImGuiInputFlags
	{
		None = 0,
		/// <summary>
		/// Enable repeat. Return true on successive repeats. Default for legacy IsKeyPressed(). NOT Default for legacy IsMouseClicked(). MUST BE == 1.<br/>
		/// </summary>
		Repeat = 1,
		/// <summary>
		/// Route to active item only.<br/>
		/// </summary>
		RouteActive = 1024,
		/// <summary>
		/// Route to windows in the focus stack (DEFAULT). Deep-most focused window takes inputs. Active item takes inputs over deep-most focused window.<br/>
		/// </summary>
		RouteFocused = 2048,
		/// <summary>
		/// Global route (unless a focused window or active item registered the route).<br/>
		/// </summary>
		RouteGlobal = 4096,
		/// <summary>
		/// Do not register route, poll keys directly.<br/>
		/// </summary>
		RouteAlways = 8192,
		/// <summary>
		/// Option: global route: higher priority than focused route (unless active item in focused route).<br/>
		/// </summary>
		RouteOverFocused = 16384,
		/// <summary>
		/// Option: global route: higher priority than active item. Unlikely you need to use that: will interfere with every active items, e.g. CTRL+A registered by InputText will be overridden by this. May not be fully honored as user/internal code is likely to always assume they can access keys when active.<br/>
		/// </summary>
		RouteOverActive = 32768,
		/// <summary>
		/// Option: global route: will not be applied if underlying background/void is focused (== no Dear ImGui windows are focused). Useful for overlay applications.<br/>
		/// </summary>
		RouteUnlessBgFocused = 65536,
		/// <summary>
		/// Option: route evaluated from the point of view of root window rather than current window.<br/>
		/// </summary>
		RouteFromRootWindow = 131072,
		/// <summary>
		/// Automatically display a tooltip when hovering item [BETA] Unsure of right api (opt-in/opt-out)<br/>
		/// </summary>
		Tooltip = 262144,
	}

	/// <summary>
	/// Configuration flags stored in io.ConfigFlags. Set by user/application.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiConfigFlags
	{
		None = 0,
		/// <summary>
		/// Master keyboard navigation enable flag. Enable full Tabbing + directional arrows + space/enter to activate.<br/>
		/// </summary>
		NavEnableKeyboard = 1,
		/// <summary>
		/// Master gamepad navigation enable flag. Backend also needs to set ImGuiBackendFlags_HasGamepad.<br/>
		/// </summary>
		NavEnableGamepad = 2,
		/// <summary>
		/// Instruct dear imgui to disable mouse inputs and interactions.<br/>
		/// </summary>
		NoMouse = 16,
		/// <summary>
		/// Instruct backend to not alter mouse cursor shape and visibility. Use if the backend cursor changes are interfering with yours and you don't want to use SetMouseCursor() to change mouse cursor. You may want to honor requests from imgui by reading GetMouseCursor() yourself instead.<br/>
		/// </summary>
		NoMouseCursorChange = 32,
		/// <summary>
		/// Instruct dear imgui to disable keyboard inputs and interactions. This is done by ignoring keyboard events and clearing existing states.<br/>
		/// </summary>
		NoKeyboard = 64,
		/// <summary>
		/// Docking enable flags.<br/>
		/// </summary>
		DockingEnable = 128,
		/// <summary>
		/// Viewport enable flags (require both ImGuiBackendFlags_PlatformHasViewports + ImGuiBackendFlags_RendererHasViewports set by the respective backends)<br/>
		/// </summary>
		ViewportsEnable = 1024,
		/// <summary>
		/// [BETA: Don't use] FIXME-DPI: Reposition and resize imgui windows when the DpiScale of a viewport changed (mostly useful for the main viewport hosting other window). Note that resizing the main window itself is up to your application.<br/>
		/// </summary>
		DpiEnableScaleViewports = 16384,
		/// <summary>
		/// [BETA: Don't use] FIXME-DPI: Request bitmap-scaled fonts to match DpiScale. This is a very low-quality workaround. The correct way to handle DPI is _currently_ to replace the atlas and/or fonts in the Platform_OnChangedViewport callback, but this is all early work in progress.<br/>
		/// </summary>
		DpiEnableScaleFonts = 32768,
		/// <summary>
		/// Application is SRGB-aware.<br/>
		/// </summary>
		IsSRGB = 1048576,
		/// <summary>
		/// Application is using a touch screen instead of a mouse.<br/>
		/// </summary>
		IsTouchScreen = 2097152,
	}

	/// <summary>
	/// Backend capabilities flags stored in io.BackendFlags. Set by imgui_impl_xxx or custom backend.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiBackendFlags
	{
		None = 0,
		/// <summary>
		/// Backend Platform supports gamepad and currently has one connected.<br/>
		/// </summary>
		HasGamepad = 1,
		/// <summary>
		/// Backend Platform supports honoring GetMouseCursor() value to change the OS cursor shape.<br/>
		/// </summary>
		HasMouseCursors = 2,
		/// <summary>
		/// Backend Platform supports io.WantSetMousePos requests to reposition the OS mouse position (only used if io.ConfigNavMoveSetMousePos is set).<br/>
		/// </summary>
		HasSetMousePos = 4,
		/// <summary>
		/// Backend Renderer supports ImDrawCmd::VtxOffset. This enables output of large meshes (64K+ vertices) while still using 16-bit indices.<br/>
		/// </summary>
		RendererHasVtxOffset = 8,
		/// <summary>
		/// Backend Platform supports multiple viewports.<br/>
		/// </summary>
		PlatformHasViewports = 1024,
		/// <summary>
		/// Backend Platform supports calling io.AddMouseViewportEvent() with the viewport under the mouse. IF POSSIBLE, ignore viewports with the ImGuiViewportFlags_NoInputs flag (Win32 backend, GLFW 3.30+ backend can do this, SDL backend cannot). If this cannot be done, Dear ImGui needs to use a flawed heuristic to find the viewport under.<br/>
		/// </summary>
		HasMouseHoveredViewport = 2048,
		/// <summary>
		/// Backend Renderer supports multiple viewports.<br/>
		/// </summary>
		RendererHasViewports = 4096,
	}

	/// <summary>
	/// Enumeration for PushStyleColor() / PopStyleColor()<br/>
	/// </summary>
	public enum ImGuiCol
	{
		Text = 0,
		TextDisabled = 1,
		/// <summary>
		/// Background of normal windows<br/>
		/// </summary>
		WindowBg = 2,
		/// <summary>
		/// Background of child windows<br/>
		/// </summary>
		ChildBg = 3,
		/// <summary>
		/// Background of popups, menus, tooltips windows<br/>
		/// </summary>
		PopupBg = 4,
		Border = 5,
		BorderShadow = 6,
		/// <summary>
		/// Background of checkbox, radio button, plot, slider, text input<br/>
		/// </summary>
		FrameBg = 7,
		FrameBgHovered = 8,
		FrameBgActive = 9,
		/// <summary>
		/// Title bar<br/>
		/// </summary>
		TitleBg = 10,
		/// <summary>
		/// Title bar when focused<br/>
		/// </summary>
		TitleBgActive = 11,
		/// <summary>
		/// Title bar when collapsed<br/>
		/// </summary>
		TitleBgCollapsed = 12,
		MenuBarBg = 13,
		ScrollbarBg = 14,
		ScrollbarGrab = 15,
		ScrollbarGrabHovered = 16,
		ScrollbarGrabActive = 17,
		/// <summary>
		/// Checkbox tick and RadioButton circle<br/>
		/// </summary>
		CheckMark = 18,
		SliderGrab = 19,
		SliderGrabActive = 20,
		Button = 21,
		ButtonHovered = 22,
		ButtonActive = 23,
		/// <summary>
		/// Header* colors are used for CollapsingHeader, TreeNode, Selectable, MenuItem<br/>
		/// </summary>
		Header = 24,
		HeaderHovered = 25,
		HeaderActive = 26,
		Separator = 27,
		SeparatorHovered = 28,
		SeparatorActive = 29,
		/// <summary>
		/// Resize grip in lower-right and lower-left corners of windows.<br/>
		/// </summary>
		ResizeGrip = 30,
		ResizeGripHovered = 31,
		ResizeGripActive = 32,
		/// <summary>
		/// Tab background, when hovered<br/>
		/// </summary>
		TabHovered = 33,
		/// <summary>
		/// Tab background, when tab-bar is focused & tab is unselected<br/>
		/// </summary>
		Tab = 34,
		/// <summary>
		/// Tab background, when tab-bar is focused & tab is selected<br/>
		/// </summary>
		TabSelected = 35,
		/// <summary>
		/// Tab horizontal overline, when tab-bar is focused & tab is selected<br/>
		/// </summary>
		TabSelectedOverline = 36,
		/// <summary>
		/// Tab background, when tab-bar is unfocused & tab is unselected<br/>
		/// </summary>
		TabDimmed = 37,
		/// <summary>
		/// Tab background, when tab-bar is unfocused & tab is selected<br/>
		/// </summary>
		TabDimmedSelected = 38,
		/// <summary>
		/// //..horizontal overline, when tab-bar is unfocused & tab is selected<br/>
		/// </summary>
		TabDimmedSelectedOverline = 39,
		/// <summary>
		/// Preview overlay color when about to docking something<br/>
		/// </summary>
		DockingPreview = 40,
		/// <summary>
		/// Background color for empty node (e.g. CentralNode with no window docked into it)<br/>
		/// </summary>
		DockingEmptyBg = 41,
		PlotLines = 42,
		PlotLinesHovered = 43,
		PlotHistogram = 44,
		PlotHistogramHovered = 45,
		/// <summary>
		/// Table header background<br/>
		/// </summary>
		TableHeaderBg = 46,
		/// <summary>
		/// Table outer and header borders (prefer using Alpha=1.0 here)<br/>
		/// </summary>
		TableBorderStrong = 47,
		/// <summary>
		/// Table inner borders (prefer using Alpha=1.0 here)<br/>
		/// </summary>
		TableBorderLight = 48,
		/// <summary>
		/// Table row background (even rows)<br/>
		/// </summary>
		TableRowBg = 49,
		/// <summary>
		/// Table row background (odd rows)<br/>
		/// </summary>
		TableRowBgAlt = 50,
		/// <summary>
		/// Hyperlink color<br/>
		/// </summary>
		TextLink = 51,
		TextSelectedBg = 52,
		/// <summary>
		/// Rectangle highlighting a drop target<br/>
		/// </summary>
		DragDropTarget = 53,
		/// <summary>
		/// Color of keyboard/gamepad navigation cursor/rectangle, when visible<br/>
		/// </summary>
		NavCursor = 54,
		/// <summary>
		/// Highlight window when using CTRL+TAB<br/>
		/// </summary>
		NavWindowingHighlight = 55,
		/// <summary>
		/// Darken/colorize entire screen behind the CTRL+TAB window list, when active<br/>
		/// </summary>
		NavWindowingDimBg = 56,
		/// <summary>
		/// Darken/colorize entire screen behind a modal window, when one is active<br/>
		/// </summary>
		ModalWindowDimBg = 57,
		COUNT = 58,
	}

	/// <summary>
	/// Enumeration for PushStyleVar() / PopStyleVar() to temporarily modify the ImGuiStyle structure.<br/>- The enum only refers to fields of ImGuiStyle which makes sense to be pushed/popped inside UI code.<br/>  During initialization or between frames, feel free to just poke into ImGuiStyle directly.<br/>- Tip: Use your programming IDE navigation facilities on the names in the _second column_ below to find the actual members and their description.<br/>  - In Visual Studio: CTRL+comma ("Edit.GoToAll") can follow symbols inside comments, whereas CTRL+F12 ("Edit.GoToImplementation") cannot.<br/>  - In Visual Studio w/ Visual Assist installed: ALT+G ("VAssistX.GoToImplementation") can also follow symbols inside comments.<br/>  - In VS Code, CLion, etc.: CTRL+click can follow symbols inside comments.<br/>- When changing this enum, you need to update the associated internal table GStyleVarInfo[] accordingly. This is where we link enum values to members offset/type.<br/>
	/// </summary>
	public enum ImGuiStyleVar
	{
		/// <summary>
		/// float     Alpha<br/>
		/// </summary>
		Alpha = 0,
		/// <summary>
		/// float     DisabledAlpha<br/>
		/// </summary>
		DisabledAlpha = 1,
		/// <summary>
		/// ImVec2    WindowPadding<br/>
		/// </summary>
		WindowPadding = 2,
		/// <summary>
		/// float     WindowRounding<br/>
		/// </summary>
		WindowRounding = 3,
		/// <summary>
		/// float     WindowBorderSize<br/>
		/// </summary>
		WindowBorderSize = 4,
		/// <summary>
		/// ImVec2    WindowMinSize<br/>
		/// </summary>
		WindowMinSize = 5,
		/// <summary>
		/// ImVec2    WindowTitleAlign<br/>
		/// </summary>
		WindowTitleAlign = 6,
		/// <summary>
		/// float     ChildRounding<br/>
		/// </summary>
		ChildRounding = 7,
		/// <summary>
		/// float     ChildBorderSize<br/>
		/// </summary>
		ChildBorderSize = 8,
		/// <summary>
		/// float     PopupRounding<br/>
		/// </summary>
		PopupRounding = 9,
		/// <summary>
		/// float     PopupBorderSize<br/>
		/// </summary>
		PopupBorderSize = 10,
		/// <summary>
		/// ImVec2    FramePadding<br/>
		/// </summary>
		FramePadding = 11,
		/// <summary>
		/// float     FrameRounding<br/>
		/// </summary>
		FrameRounding = 12,
		/// <summary>
		/// float     FrameBorderSize<br/>
		/// </summary>
		FrameBorderSize = 13,
		/// <summary>
		/// ImVec2    ItemSpacing<br/>
		/// </summary>
		ItemSpacing = 14,
		/// <summary>
		/// ImVec2    ItemInnerSpacing<br/>
		/// </summary>
		ItemInnerSpacing = 15,
		/// <summary>
		/// float     IndentSpacing<br/>
		/// </summary>
		IndentSpacing = 16,
		/// <summary>
		/// ImVec2    CellPadding<br/>
		/// </summary>
		CellPadding = 17,
		/// <summary>
		/// float     ScrollbarSize<br/>
		/// </summary>
		ScrollbarSize = 18,
		/// <summary>
		/// float     ScrollbarRounding<br/>
		/// </summary>
		ScrollbarRounding = 19,
		/// <summary>
		/// float     GrabMinSize<br/>
		/// </summary>
		GrabMinSize = 20,
		/// <summary>
		/// float     GrabRounding<br/>
		/// </summary>
		GrabRounding = 21,
		/// <summary>
		/// float     ImageBorderSize<br/>
		/// </summary>
		ImageBorderSize = 22,
		/// <summary>
		/// float     TabRounding<br/>
		/// </summary>
		TabRounding = 23,
		/// <summary>
		/// float     TabBorderSize<br/>
		/// </summary>
		TabBorderSize = 24,
		/// <summary>
		/// float     TabBarBorderSize<br/>
		/// </summary>
		TabBarBorderSize = 25,
		/// <summary>
		/// float     TabBarOverlineSize<br/>
		/// </summary>
		TabBarOverlineSize = 26,
		/// <summary>
		/// float     TableAngledHeadersAngle<br/>
		/// </summary>
		TableAngledHeadersAngle = 27,
		/// <summary>
		/// ImVec2  TableAngledHeadersTextAlign<br/>
		/// </summary>
		TableAngledHeadersTextAlign = 28,
		/// <summary>
		/// ImVec2    ButtonTextAlign<br/>
		/// </summary>
		ButtonTextAlign = 29,
		/// <summary>
		/// ImVec2    SelectableTextAlign<br/>
		/// </summary>
		SelectableTextAlign = 30,
		/// <summary>
		/// float     SeparatorTextBorderSize<br/>
		/// </summary>
		SeparatorTextBorderSize = 31,
		/// <summary>
		/// ImVec2    SeparatorTextAlign<br/>
		/// </summary>
		SeparatorTextAlign = 32,
		/// <summary>
		/// ImVec2    SeparatorTextPadding<br/>
		/// </summary>
		SeparatorTextPadding = 33,
		/// <summary>
		/// float     DockingSeparatorSize<br/>
		/// </summary>
		DockingSeparatorSize = 34,
		COUNT = 35,
	}

	/// <summary>
	/// Flags for InvisibleButton() [extended in imgui_internal.h]<br/>
	/// </summary>
	[Flags]
	public enum ImGuiButtonFlags
	{
		None = 0,
		/// <summary>
		/// React on left mouse button (default)<br/>
		/// </summary>
		MouseButtonLeft = 1,
		/// <summary>
		/// React on right mouse button<br/>
		/// </summary>
		MouseButtonRight = 2,
		/// <summary>
		/// React on center mouse button<br/>
		/// </summary>
		MouseButtonMiddle = 4,
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		MouseButtonMask = 7,
		/// <summary>
		/// InvisibleButton(): do not disable navigation/tabbing. Otherwise disabled by default.<br/>
		/// </summary>
		EnableNav = 8,
	}

	/// <summary>
	/// Flags for ColorEdit3() / ColorEdit4() / ColorPicker3() / ColorPicker4() / ColorButton()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiColorEditFlags
	{
		None = 0,
		/// <summary>
		///              ColorEdit, ColorPicker, ColorButton: ignore Alpha component (will only read 3 components from the input pointer).<br/>
		/// </summary>
		NoAlpha = 2,
		/// <summary>
		///              ColorEdit: disable picker when clicking on color square.<br/>
		/// </summary>
		NoPicker = 4,
		/// <summary>
		///              ColorEdit: disable toggling options menu when right-clicking on inputs/small preview.<br/>
		/// </summary>
		NoOptions = 8,
		/// <summary>
		///              ColorEdit, ColorPicker: disable color square preview next to the inputs. (e.g. to show only the inputs)<br/>
		/// </summary>
		NoSmallPreview = 16,
		/// <summary>
		///              ColorEdit, ColorPicker: disable inputs sliders/text widgets (e.g. to show only the small preview color square).<br/>
		/// </summary>
		NoInputs = 32,
		/// <summary>
		///              ColorEdit, ColorPicker, ColorButton: disable tooltip when hovering the preview.<br/>
		/// </summary>
		NoTooltip = 64,
		/// <summary>
		///              ColorEdit, ColorPicker: disable display of inline text label (the label is still forwarded to the tooltip and picker).<br/>
		/// </summary>
		NoLabel = 128,
		/// <summary>
		///              ColorPicker: disable bigger color preview on right side of the picker, use small color square preview instead.<br/>
		/// </summary>
		NoSidePreview = 256,
		/// <summary>
		///              ColorEdit: disable drag and drop target. ColorButton: disable drag and drop source.<br/>
		/// </summary>
		NoDragDrop = 512,
		/// <summary>
		///              ColorButton: disable border (which is enforced by default)<br/>
		/// </summary>
		NoBorder = 1024,
		/// <summary>
		///              ColorEdit, ColorPicker, ColorButton: disable alpha in the preview,. Contrary to _NoAlpha it may still be edited when calling ColorEdit4()/ColorPicker4(). For ColorButton() this does the same as _NoAlpha.<br/>
		/// </summary>
		AlphaOpaque = 2048,
		/// <summary>
		///              ColorEdit, ColorPicker, ColorButton: disable rendering a checkerboard background behind transparent color.<br/>
		/// </summary>
		AlphaNoBg = 4096,
		/// <summary>
		///              ColorEdit, ColorPicker, ColorButton: display half opaque / half transparent preview.<br/>
		/// </summary>
		AlphaPreviewHalf = 8192,
		/// <summary>
		///              ColorEdit, ColorPicker: show vertical alpha bar/gradient in picker.<br/>
		/// </summary>
		AlphaBar = 65536,
		/// <summary>
		///              (WIP) ColorEdit: Currently only disable 0.0f..1.0f limits in RGBA edition (note: you probably want to use ImGuiColorEditFlags_Float flag as well).<br/>
		/// </summary>
		HDR = 524288,
		/// <summary>
		/// [Display]    ColorEdit: override _display_ type among RGB/HSV/Hex. ColorPicker: select any combination using one or more of RGB/HSV/Hex.<br/>
		/// </summary>
		DisplayRGB = 1048576,
		/// <summary>
		/// [Display]    "<br/>
		/// </summary>
		DisplayHSV = 2097152,
		/// <summary>
		/// [Display]    "<br/>
		/// </summary>
		DisplayHex = 4194304,
		/// <summary>
		/// [DataType]   ColorEdit, ColorPicker, ColorButton: _display_ values formatted as 0..255.<br/>
		/// </summary>
		Uint8 = 8388608,
		/// <summary>
		/// [DataType]   ColorEdit, ColorPicker, ColorButton: _display_ values formatted as 0.0f..1.0f floats instead of 0..255 integers. No round-trip of value via integers.<br/>
		/// </summary>
		Float = 16777216,
		/// <summary>
		/// [Picker]     ColorPicker: bar for Hue, rectangle for Sat/Value.<br/>
		/// </summary>
		PickerHueBar = 33554432,
		/// <summary>
		/// [Picker]     ColorPicker: wheel for Hue, triangle for Sat/Value.<br/>
		/// </summary>
		PickerHueWheel = 67108864,
		/// <summary>
		/// [Input]      ColorEdit, ColorPicker: input and output data in RGB format.<br/>
		/// </summary>
		InputRGB = 134217728,
		/// <summary>
		/// [Input]      ColorEdit, ColorPicker: input and output data in HSV format.<br/>
		/// </summary>
		InputHSV = 268435456,
		DefaultOptions = 177209344,
		AlphaMask = 14338,
		DisplayMask = 7340032,
		DataTypeMask = 25165824,
		PickerMask = 100663296,
		InputMask = 402653184,
	}

	/// <summary>
	/// Flags for DragFloat(), DragInt(), SliderFloat(), SliderInt() etc.<br/>We use the same sets of flags for DragXXX() and SliderXXX() functions as the features are the same and it makes it easier to swap them.<br/>(Those are per-item flags. There is shared behavior flag too: ImGuiIO: io.ConfigDragClickToInputText)<br/>
	/// </summary>
	[Flags]
	public enum ImGuiSliderFlags
	{
		None = 0,
		/// <summary>
		/// Make the widget logarithmic (linear otherwise). Consider using ImGuiSliderFlags_NoRoundToFormat with this if using a format-string with small amount of digits.<br/>
		/// </summary>
		Logarithmic = 32,
		/// <summary>
		/// Disable rounding underlying value to match precision of the display format string (e.g. %.3f values are rounded to those 3 digits).<br/>
		/// </summary>
		NoRoundToFormat = 64,
		/// <summary>
		/// Disable CTRL+Click or Enter key allowing to input text directly into the widget.<br/>
		/// </summary>
		NoInput = 128,
		/// <summary>
		/// Enable wrapping around from max to min and from min to max. Only supported by DragXXX() functions for now.<br/>
		/// </summary>
		WrapAround = 256,
		/// <summary>
		/// Clamp value to min/max bounds when input manually with CTRL+Click. By default CTRL+Click allows going out of bounds.<br/>
		/// </summary>
		ClampOnInput = 512,
		/// <summary>
		/// Clamp even if min==max==0.0f. Otherwise due to legacy reason DragXXX functions don't clamp with those values. When your clamping limits are dynamic you almost always want to use it.<br/>
		/// </summary>
		ClampZeroRange = 1024,
		/// <summary>
		/// Disable keyboard modifiers altering tweak speed. Useful if you want to alter tweak speed yourself based on your own logic.<br/>
		/// </summary>
		NoSpeedTweaks = 2048,
		AlwaysClamp = 1536,
		/// <summary>
		/// [Internal] We treat using those bits as being potentially a 'float power' argument from the previous API that has got miscast to this enum, and will trigger an assert if needed.<br/>
		/// </summary>
		InvalidMask = 1879048207,
	}

	/// <summary>
	/// Identify a mouse button.<br/>Those values are guaranteed to be stable and we frequently use 0/1 directly. Named enums provided for convenience.<br/>
	/// </summary>
	public enum ImGuiMouseButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		COUNT = 5,
	}

	/// <summary>
	/// Enumeration for GetMouseCursor()<br/>User code may request backend to display given cursor by calling SetMouseCursor(), which is why we have some cursors that are marked unused here<br/>
	/// </summary>
	public enum ImGuiMouseCursor
	{
		None = -1,
		Arrow = 0,
		/// <summary>
		/// When hovering over InputText, etc.<br/>
		/// </summary>
		TextInput = 1,
		/// <summary>
		/// (Unused by Dear ImGui functions)<br/>
		/// </summary>
		ResizeAll = 2,
		/// <summary>
		/// When hovering over a horizontal border<br/>
		/// </summary>
		ResizeNS = 3,
		/// <summary>
		/// When hovering over a vertical border or a column<br/>
		/// </summary>
		ResizeEW = 4,
		/// <summary>
		/// When hovering over the bottom-left corner of a window<br/>
		/// </summary>
		ResizeNESW = 5,
		/// <summary>
		/// When hovering over the bottom-right corner of a window<br/>
		/// </summary>
		ResizeNWSE = 6,
		/// <summary>
		/// (Unused by Dear ImGui functions. Use for e.g. hyperlinks)<br/>
		/// </summary>
		Hand = 7,
		/// <summary>
		/// When waiting for something to process/load.<br/>
		/// </summary>
		Wait = 8,
		/// <summary>
		/// When waiting for something to process/load, but application is still interactive.<br/>
		/// </summary>
		Progress = 9,
		/// <summary>
		/// When hovering something with disallowed interaction. Usually a crossed circle.<br/>
		/// </summary>
		NotAllowed = 10,
		COUNT = 11,
	}

	/// <summary>
	/// Enumeration for AddMouseSourceEvent() actual source of Mouse Input data.<br/>Historically we use "Mouse" terminology everywhere to indicate pointer data, e.g. MousePos, IsMousePressed(), io.AddMousePosEvent()<br/>But that "Mouse" data can come from different source which occasionally may be useful for application to know about.<br/>You can submit a change of pointer type using io.AddMouseSourceEvent().<br/>
	/// </summary>
	public enum ImGuiMouseSource
	{
		/// <summary>
		/// Input is coming from an actual mouse.<br/>
		/// </summary>
		Mouse = 0,
		/// <summary>
		/// Input is coming from a touch screen (no hovering prior to initial press, less precise initial press aiming, dual-axis wheeling possible).<br/>
		/// </summary>
		TouchScreen = 1,
		/// <summary>
		/// Input is coming from a pressure/magnetic pen (often used in conjunction with high-sampling rates).<br/>
		/// </summary>
		Pen = 2,
		COUNT = 3,
	}

	/// <summary>
	/// Enumeration for ImGui::SetNextWindow***(), SetWindow***(), SetNextItem***() functions<br/>Represent a condition.<br/>Important: Treat as a regular enum! Do NOT combine multiple values using binary operators! All the functions above treat 0 as a shortcut to ImGuiCond_Always.<br/>
	/// </summary>
	public enum ImGuiCond
	{
		/// <summary>
		/// No condition (always set the variable), same as _Always<br/>
		/// </summary>
		None = 0,
		/// <summary>
		/// No condition (always set the variable), same as _None<br/>
		/// </summary>
		Always = 1,
		/// <summary>
		/// Set the variable once per runtime session (only the first call will succeed)<br/>
		/// </summary>
		Once = 2,
		/// <summary>
		/// Set the variable if the object/window has no persistently saved data (no entry in .ini file)<br/>
		/// </summary>
		FirstUseEver = 4,
		/// <summary>
		/// Set the variable if the object/window is appearing after being hidden/inactive (or the first time)<br/>
		/// </summary>
		Appearing = 8,
	}

	/// <summary>
	/// Flags for ImGui::BeginTable()<br/>- Important! Sizing policies have complex and subtle side effects, much more so than you would expect.<br/>  Read comments/demos carefully + experiment with live demos to get acquainted with them.<br/>- The DEFAULT sizing policies are:<br/>   - Default to ImGuiTableFlags_SizingFixedFit    if ScrollX is on, or if host window has ImGuiWindowFlags_AlwaysAutoResize.<br/>   - Default to ImGuiTableFlags_SizingStretchSame if ScrollX is off.<br/>- When ScrollX is off:<br/>   - Table defaults to ImGuiTableFlags_SizingStretchSame -&gt; all Columns defaults to ImGuiTableColumnFlags_WidthStretch with same weight.<br/>   - Columns sizing policy allowed: Stretch (default), Fixed/Auto.<br/>   - Fixed Columns (if any) will generally obtain their requested width (unless the table cannot fit them all).<br/>   - Stretch Columns will share the remaining width according to their respective weight.<br/>   - Mixed Fixed/Stretch columns is possible but has various side-effects on resizing behaviors.<br/>     The typical use of mixing sizing policies is: any number of LEADING Fixed columns, followed by one or two TRAILING Stretch columns.<br/>     (this is because the visible order of columns have subtle but necessary effects on how they react to manual resizing).<br/>- When ScrollX is on:<br/>   - Table defaults to ImGuiTableFlags_SizingFixedFit -&gt; all Columns defaults to ImGuiTableColumnFlags_WidthFixed<br/>   - Columns sizing policy allowed: Fixed/Auto mostly.<br/>   - Fixed Columns can be enlarged as needed. Table will show a horizontal scrollbar if needed.<br/>   - When using auto-resizing (non-resizable) fixed columns, querying the content width to use item right-alignment e.g. SetNextItemWidth(-FLT_MIN) doesn't make sense, would create a feedback loop.<br/>   - Using Stretch columns OFTEN DOES NOT MAKE SENSE if ScrollX is on, UNLESS you have specified a value for 'inner_width' in BeginTable().<br/>     If you specify a value for 'inner_width' then effectively the scrolling space is known and Stretch or mixed Fixed/Stretch columns become meaningful again.<br/>- Read on documentation at the top of imgui_tables.cpp for details.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTableFlags
	{
		None = 0,
		/// <summary>
		/// Enable resizing columns.<br/>
		/// </summary>
		Resizable = 1,
		/// <summary>
		/// Enable reordering columns in header row (need calling TableSetupColumn() + TableHeadersRow() to display headers)<br/>
		/// </summary>
		Reorderable = 2,
		/// <summary>
		/// Enable hiding/disabling columns in context menu.<br/>
		/// </summary>
		Hideable = 4,
		/// <summary>
		/// Enable sorting. Call TableGetSortSpecs() to obtain sort specs. Also see ImGuiTableFlags_SortMulti and ImGuiTableFlags_SortTristate.<br/>
		/// </summary>
		Sortable = 8,
		/// <summary>
		/// Disable persisting columns order, width and sort settings in the .ini file.<br/>
		/// </summary>
		NoSavedSettings = 16,
		/// <summary>
		/// Right-click on columns body/contents will display table context menu. By default it is available in TableHeadersRow().<br/>
		/// </summary>
		ContextMenuInBody = 32,
		/// <summary>
		/// Set each RowBg color with ImGuiCol_TableRowBg or ImGuiCol_TableRowBgAlt (equivalent of calling TableSetBgColor with ImGuiTableBgFlags_RowBg0 on each row manually)<br/>
		/// </summary>
		RowBg = 64,
		/// <summary>
		/// Draw horizontal borders between rows.<br/>
		/// </summary>
		BordersInnerH = 128,
		/// <summary>
		/// Draw horizontal borders at the top and bottom.<br/>
		/// </summary>
		BordersOuterH = 256,
		/// <summary>
		/// Draw vertical borders between columns.<br/>
		/// </summary>
		BordersInnerV = 512,
		/// <summary>
		/// Draw vertical borders on the left and right sides.<br/>
		/// </summary>
		BordersOuterV = 1024,
		/// <summary>
		/// Draw horizontal borders.<br/>
		/// </summary>
		BordersH = 384,
		/// <summary>
		/// Draw vertical borders.<br/>
		/// </summary>
		BordersV = 1536,
		/// <summary>
		/// Draw inner borders.<br/>
		/// </summary>
		BordersInner = 640,
		/// <summary>
		/// Draw outer borders.<br/>
		/// </summary>
		BordersOuter = 1280,
		/// <summary>
		/// Draw all borders.<br/>
		/// </summary>
		Borders = 1920,
		/// <summary>
		/// [ALPHA] Disable vertical borders in columns Body (borders will always appear in Headers). -&gt; May move to style<br/>
		/// </summary>
		NoBordersInBody = 2048,
		/// <summary>
		/// [ALPHA] Disable vertical borders in columns Body until hovered for resize (borders will always appear in Headers). -&gt; May move to style<br/>
		/// </summary>
		NoBordersInBodyUntilResize = 4096,
		/// <summary>
		/// Columns default to _WidthFixed or _WidthAuto (if resizable or not resizable), matching contents width.<br/>
		/// </summary>
		SizingFixedFit = 8192,
		/// <summary>
		/// Columns default to _WidthFixed or _WidthAuto (if resizable or not resizable), matching the maximum contents width of all columns. Implicitly enable ImGuiTableFlags_NoKeepColumnsVisible.<br/>
		/// </summary>
		SizingFixedSame = 16384,
		/// <summary>
		/// Columns default to _WidthStretch with default weights proportional to each columns contents widths.<br/>
		/// </summary>
		SizingStretchProp = 24576,
		/// <summary>
		/// Columns default to _WidthStretch with default weights all equal, unless overridden by TableSetupColumn().<br/>
		/// </summary>
		SizingStretchSame = 32768,
		/// <summary>
		/// Make outer width auto-fit to columns, overriding outer_size.x value. Only available when ScrollX/ScrollY are disabled and Stretch columns are not used.<br/>
		/// </summary>
		NoHostExtendX = 65536,
		/// <summary>
		/// Make outer height stop exactly at outer_size.y (prevent auto-extending table past the limit). Only available when ScrollX/ScrollY are disabled. Data below the limit will be clipped and not visible.<br/>
		/// </summary>
		NoHostExtendY = 131072,
		/// <summary>
		/// Disable keeping column always minimally visible when ScrollX is off and table gets too small. Not recommended if columns are resizable.<br/>
		/// </summary>
		NoKeepColumnsVisible = 262144,
		/// <summary>
		/// Disable distributing remainder width to stretched columns (width allocation on a 100-wide table with 3 columns: Without this flag: 33,33,34. With this flag: 33,33,33). With larger number of columns, resizing will appear to be less smooth.<br/>
		/// </summary>
		PreciseWidths = 524288,
		/// <summary>
		/// Disable clipping rectangle for every individual columns (reduce draw command count, items will be able to overflow into other columns). Generally incompatible with TableSetupScrollFreeze().<br/>
		/// </summary>
		NoClip = 1048576,
		/// <summary>
		/// Default if BordersOuterV is on. Enable outermost padding. Generally desirable if you have headers.<br/>
		/// </summary>
		PadOuterX = 2097152,
		/// <summary>
		/// Default if BordersOuterV is off. Disable outermost padding.<br/>
		/// </summary>
		NoPadOuterX = 4194304,
		/// <summary>
		/// Disable inner padding between columns (double inner padding if BordersOuterV is on, single inner padding if BordersOuterV is off).<br/>
		/// </summary>
		NoPadInnerX = 8388608,
		/// <summary>
		/// Enable horizontal scrolling. Require 'outer_size' parameter of BeginTable() to specify the container size. Changes default sizing policy. Because this creates a child window, ScrollY is currently generally recommended when using ScrollX.<br/>
		/// </summary>
		ScrollX = 16777216,
		/// <summary>
		/// Enable vertical scrolling. Require 'outer_size' parameter of BeginTable() to specify the container size.<br/>
		/// </summary>
		ScrollY = 33554432,
		/// <summary>
		/// Hold shift when clicking headers to sort on multiple column. TableGetSortSpecs() may return specs where (SpecsCount &gt; 1).<br/>
		/// </summary>
		SortMulti = 67108864,
		/// <summary>
		/// Allow no sorting, disable default sorting. TableGetSortSpecs() may return specs where (SpecsCount == 0).<br/>
		/// </summary>
		SortTristate = 134217728,
		/// <summary>
		/// Highlight column headers when hovered (may evolve into a fuller highlight)<br/>
		/// </summary>
		HighlightHoveredColumn = 268435456,
		SizingMask = 57344,
	}

	/// <summary>
	/// Flags for ImGui::TableSetupColumn()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTableColumnFlags
	{
		None = 0,
		/// <summary>
		/// Overriding/master disable flag: hide column, won't show in context menu (unlike calling TableSetColumnEnabled() which manipulates the user accessible state)<br/>
		/// </summary>
		Disabled = 1,
		/// <summary>
		/// Default as a hidden/disabled column.<br/>
		/// </summary>
		DefaultHide = 2,
		/// <summary>
		/// Default as a sorting column.<br/>
		/// </summary>
		DefaultSort = 4,
		/// <summary>
		/// Column will stretch. Preferable with horizontal scrolling disabled (default if table sizing policy is _SizingStretchSame or _SizingStretchProp).<br/>
		/// </summary>
		WidthStretch = 8,
		/// <summary>
		/// Column will not stretch. Preferable with horizontal scrolling enabled (default if table sizing policy is _SizingFixedFit and table is resizable).<br/>
		/// </summary>
		WidthFixed = 16,
		/// <summary>
		/// Disable manual resizing.<br/>
		/// </summary>
		NoResize = 32,
		/// <summary>
		/// Disable manual reordering this column, this will also prevent other columns from crossing over this column.<br/>
		/// </summary>
		NoReorder = 64,
		/// <summary>
		/// Disable ability to hide/disable this column.<br/>
		/// </summary>
		NoHide = 128,
		/// <summary>
		/// Disable clipping for this column (all NoClip columns will render in a same draw command).<br/>
		/// </summary>
		NoClip = 256,
		/// <summary>
		/// Disable ability to sort on this field (even if ImGuiTableFlags_Sortable is set on the table).<br/>
		/// </summary>
		NoSort = 512,
		/// <summary>
		/// Disable ability to sort in the ascending direction.<br/>
		/// </summary>
		NoSortAscending = 1024,
		/// <summary>
		/// Disable ability to sort in the descending direction.<br/>
		/// </summary>
		NoSortDescending = 2048,
		/// <summary>
		/// TableHeadersRow() will submit an empty label for this column. Convenient for some small columns. Name will still appear in context menu or in angled headers. You may append into this cell by calling TableSetColumnIndex() right after the TableHeadersRow() call.<br/>
		/// </summary>
		NoHeaderLabel = 4096,
		/// <summary>
		/// Disable header text width contribution to automatic column width.<br/>
		/// </summary>
		NoHeaderWidth = 8192,
		/// <summary>
		/// Make the initial sort direction Ascending when first sorting on this column (default).<br/>
		/// </summary>
		PreferSortAscending = 16384,
		/// <summary>
		/// Make the initial sort direction Descending when first sorting on this column.<br/>
		/// </summary>
		PreferSortDescending = 32768,
		/// <summary>
		/// Use current Indent value when entering cell (default for column 0).<br/>
		/// </summary>
		IndentEnable = 65536,
		/// <summary>
		/// Ignore current Indent value when entering cell (default for columns &gt; 0). Indentation changes _within_ the cell will still be honored.<br/>
		/// </summary>
		IndentDisable = 131072,
		/// <summary>
		/// TableHeadersRow() will submit an angled header row for this column. Note this will add an extra row.<br/>
		/// </summary>
		AngledHeader = 262144,
		/// <summary>
		/// Status: is enabled == not hidden by user/api (referred to as "Hide" in _DefaultHide and _NoHide) flags.<br/>
		/// </summary>
		IsEnabled = 16777216,
		/// <summary>
		/// Status: is visible == is enabled AND not clipped by scrolling.<br/>
		/// </summary>
		IsVisible = 33554432,
		/// <summary>
		/// Status: is currently part of the sort specs<br/>
		/// </summary>
		IsSorted = 67108864,
		/// <summary>
		/// Status: is hovered by mouse<br/>
		/// </summary>
		IsHovered = 134217728,
		WidthMask = 24,
		IndentMask = 196608,
		StatusMask = 251658240,
		/// <summary>
		/// [Internal] Disable user resizing this column directly (it may however we resized indirectly from its left edge)<br/>
		/// </summary>
		NoDirectResize = 1073741824,
	}

	/// <summary>
	/// Flags for ImGui::TableNextRow()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiTableRowFlags
	{
		None = 0,
		/// <summary>
		/// Identify header row (set default background color + width of its contents accounted differently for auto column width)<br/>
		/// </summary>
		Headers = 1,
	}

	/// <summary>
	/// Enum for ImGui::TableSetBgColor()<br/>Background colors are rendering in 3 layers:<br/> - Layer 0: draw with RowBg0 color if set, otherwise draw with ColumnBg0 if set.<br/> - Layer 1: draw with RowBg1 color if set, otherwise draw with ColumnBg1 if set.<br/> - Layer 2: draw with CellBg color if set.<br/>The purpose of the two row/columns layers is to let you decide if a background color change should override or blend with the existing color.<br/>When using ImGuiTableFlags_RowBg on the table, each row has the RowBg0 color automatically set for odd/even rows.<br/>If you set the color of RowBg0 target, your color will override the existing RowBg0 color.<br/>If you set the color of RowBg1 or ColumnBg1 target, your color will blend over the RowBg0 color.<br/>
	/// </summary>
	public enum ImGuiTableBgTarget
	{
		None = 0,
		/// <summary>
		/// Set row background color 0 (generally used for background, automatically set when ImGuiTableFlags_RowBg is used)<br/>
		/// </summary>
		RowBg0 = 1,
		/// <summary>
		/// Set row background color 1 (generally used for selection marking)<br/>
		/// </summary>
		RowBg1 = 2,
		/// <summary>
		/// Set cell background color (top-most color)<br/>
		/// </summary>
		CellBg = 3,
	}

	/// <summary>
	/// Flags for BeginMultiSelect()<br/>
	/// </summary>
	[Flags]
	public enum ImGuiMultiSelectFlags
	{
		None = 0,
		/// <summary>
		/// Disable selecting more than one item. This is available to allow single-selection code to share same code/logic if desired. It essentially disables the main purpose of BeginMultiSelect() tho!<br/>
		/// </summary>
		SingleSelect = 1,
		/// <summary>
		/// Disable CTRL+A shortcut to select all.<br/>
		/// </summary>
		NoSelectAll = 2,
		/// <summary>
		/// Disable Shift+selection mouse/keyboard support (useful for unordered 2D selection). With BoxSelect is also ensure contiguous SetRange requests are not combined into one. This allows not handling interpolation in SetRange requests.<br/>
		/// </summary>
		NoRangeSelect = 4,
		/// <summary>
		/// Disable selecting items when navigating (useful for e.g. supporting range-select in a list of checkboxes).<br/>
		/// </summary>
		NoAutoSelect = 8,
		/// <summary>
		/// Disable clearing selection when navigating or selecting another one (generally used with ImGuiMultiSelectFlags_NoAutoSelect. useful for e.g. supporting range-select in a list of checkboxes).<br/>
		/// </summary>
		NoAutoClear = 16,
		/// <summary>
		/// Disable clearing selection when clicking/selecting an already selected item.<br/>
		/// </summary>
		NoAutoClearOnReselect = 32,
		/// <summary>
		/// Enable box-selection with same width and same x pos items (e.g. full row Selectable()). Box-selection works better with little bit of spacing between items hit-box in order to be able to aim at empty space.<br/>
		/// </summary>
		BoxSelect1D = 64,
		/// <summary>
		/// Enable box-selection with varying width or varying x pos items support (e.g. different width labels, or 2D layout/grid). This is slower: alters clipping logic so that e.g. horizontal movements will update selection of normally clipped items.<br/>
		/// </summary>
		BoxSelect2D = 128,
		/// <summary>
		/// Disable scrolling when box-selecting near edges of scope.<br/>
		/// </summary>
		BoxSelectNoScroll = 256,
		/// <summary>
		/// Clear selection when pressing Escape while scope is focused.<br/>
		/// </summary>
		ClearOnEscape = 512,
		/// <summary>
		/// Clear selection when clicking on empty location within scope.<br/>
		/// </summary>
		ClearOnClickVoid = 1024,
		/// <summary>
		/// Scope for _BoxSelect and _ClearOnClickVoid is whole window (Default). Use if BeginMultiSelect() covers a whole window or used a single time in same window.<br/>
		/// </summary>
		ScopeWindow = 2048,
		/// <summary>
		/// Scope for _BoxSelect and _ClearOnClickVoid is rectangle encompassing BeginMultiSelect()/EndMultiSelect(). Use if BeginMultiSelect() is called multiple times in same window.<br/>
		/// </summary>
		ScopeRect = 4096,
		/// <summary>
		/// Apply selection on mouse down when clicking on unselected item. (Default)<br/>
		/// </summary>
		SelectOnClick = 8192,
		/// <summary>
		/// Apply selection on mouse release when clicking an unselected item. Allow dragging an unselected item without altering selection.<br/>
		/// </summary>
		SelectOnClickRelease = 16384,
		/// <summary>
		/// [Temporary] Enable navigation wrapping on X axis. Provided as a convenience because we don't have a design for the general Nav API for this yet. When the more general feature be public we may obsolete this flag in favor of new one.<br/>
		/// </summary>
		NavWrapX = 65536,
	}

	/// <summary>
	/// Selection request type<br/>
	/// </summary>
	public enum ImGuiSelectionRequestType
	{
		None = 0,
		/// <summary>
		/// Request app to clear selection (if Selected==false) or select all items (if Selected==true). We cannot set RangeFirstItem/RangeLastItem as its contents is entirely up to user (not necessarily an index)<br/>
		/// </summary>
		SetAll = 1,
		/// <summary>
		/// Request app to select/unselect [RangeFirstItem..RangeLastItem] items (inclusive) based on value of Selected. Only EndMultiSelect() request this, app code can read after BeginMultiSelect() and it will always be false.<br/>
		/// </summary>
		SetRange = 2,
	}

	/// <summary>
	/// Flags for ImDrawList functions<br/>(Legacy: bit 0 must always correspond to ImDrawFlags_Closed to be backward compatible with old API using a bool. Bits 1..3 must be unused)<br/>
	/// </summary>
	[Flags]
	public enum ImDrawFlags
	{
		None = 0,
		/// <summary>
		/// PathStroke(), AddPolyline(): specify that shape should be closed (Important: this is always == 1 for legacy reason)<br/>
		/// </summary>
		Closed = 1,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding top-left corner only (when rounding &gt; 0.0f, we default to all corners). Was 0x01.<br/>
		/// </summary>
		RoundCornersTopLeft = 16,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding top-right corner only (when rounding &gt; 0.0f, we default to all corners). Was 0x02.<br/>
		/// </summary>
		RoundCornersTopRight = 32,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding bottom-left corner only (when rounding &gt; 0.0f, we default to all corners). Was 0x04.<br/>
		/// </summary>
		RoundCornersBottomLeft = 64,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding bottom-right corner only (when rounding &gt; 0.0f, we default to all corners). Wax 0x08.<br/>
		/// </summary>
		RoundCornersBottomRight = 128,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): disable rounding on all corners (when rounding &gt; 0.0f). This is NOT zero, NOT an implicit flag!<br/>
		/// </summary>
		RoundCornersNone = 256,
		RoundCornersTop = 48,
		RoundCornersBottom = 192,
		RoundCornersLeft = 80,
		RoundCornersRight = 160,
		RoundCornersAll = 240,
		/// <summary>
		/// Default to ALL corners if none of the _RoundCornersXX flags are specified.<br/>
		/// </summary>
		RoundCornersDefault = 240,
		RoundCornersMask = 496,
	}

	/// <summary>
	/// Flags for ImDrawList instance. Those are set automatically by ImGui:: functions from ImGuiIO settings, and generally not manipulated directly.<br/>It is however possible to temporarily alter flags between calls to ImDrawList:: functions.<br/>
	/// </summary>
	[Flags]
	public enum ImDrawListFlags
	{
		None = 0,
		/// <summary>
		/// Enable anti-aliased lines/borders (*2 the number of triangles for 1.0f wide line or lines thin enough to be drawn using textures, otherwise *3 the number of triangles)<br/>
		/// </summary>
		AntiAliasedLines = 1,
		/// <summary>
		/// Enable anti-aliased lines/borders using textures when possible. Require backend to render with bilinear filtering (NOT point/nearest filtering).<br/>
		/// </summary>
		AntiAliasedLinesUseTex = 2,
		/// <summary>
		/// Enable anti-aliased edge around filled shapes (rounded rectangles, circles).<br/>
		/// </summary>
		AntiAliasedFill = 4,
		/// <summary>
		/// Can emit 'VtxOffset &gt; 0' to allow large meshes. Set when 'ImGuiBackendFlags_RendererHasVtxOffset' is enabled.<br/>
		/// </summary>
		AllowVtxOffset = 8,
	}

	/// <summary>
	/// Flags for ImFontAtlas build<br/>
	/// </summary>
	[Flags]
	public enum ImFontAtlasFlags
	{
		None = 0,
		/// <summary>
		/// Don't round the height to next power of two<br/>
		/// </summary>
		NoPowerOfTwoHeight = 1,
		/// <summary>
		/// Don't build software mouse cursors into the atlas (save a little texture memory)<br/>
		/// </summary>
		NoMouseCursors = 2,
		/// <summary>
		/// Don't build thick line textures into the atlas (save a little texture memory, allow support for point/nearest filtering). The AntiAliasedLinesUseTex features uses them, otherwise they will be rendered using polygons (more expensive for CPU/GPU).<br/>
		/// </summary>
		NoBakedLines = 4,
	}

	/// <summary>
	/// Flags stored in ImGuiViewport::Flags, giving indications to the platform backends.<br/>
	/// </summary>
	[Flags]
	public enum ImGuiViewportFlags
	{
		None = 0,
		/// <summary>
		/// Represent a Platform Window<br/>
		/// </summary>
		IsPlatformWindow = 1,
		/// <summary>
		/// Represent a Platform Monitor (unused yet)<br/>
		/// </summary>
		IsPlatformMonitor = 2,
		/// <summary>
		/// Platform Window: Is created/managed by the user application? (rather than our backend)<br/>
		/// </summary>
		OwnedByApp = 4,
		/// <summary>
		/// Platform Window: Disable platform decorations: title bar, borders, etc. (generally set all windows, but if ImGuiConfigFlags_ViewportsDecoration is set we only set this on popups/tooltips)<br/>
		/// </summary>
		NoDecoration = 8,
		/// <summary>
		/// Platform Window: Disable platform task bar icon (generally set on popups/tooltips, or all windows if ImGuiConfigFlags_ViewportsNoTaskBarIcon is set)<br/>
		/// </summary>
		NoTaskBarIcon = 16,
		/// <summary>
		/// Platform Window: Don't take focus when created.<br/>
		/// </summary>
		NoFocusOnAppearing = 32,
		/// <summary>
		/// Platform Window: Don't take focus when clicked on.<br/>
		/// </summary>
		NoFocusOnClick = 64,
		/// <summary>
		/// Platform Window: Make mouse pass through so we can drag this window while peaking behind it.<br/>
		/// </summary>
		NoInputs = 128,
		/// <summary>
		/// Platform Window: Renderer doesn't need to clear the framebuffer ahead (because we will fill it entirely).<br/>
		/// </summary>
		NoRendererClear = 256,
		/// <summary>
		/// Platform Window: Avoid merging this window into another host window. This can only be set via ImGuiWindowClass viewport flags override (because we need to now ahead if we are going to create a viewport in the first place!).<br/>
		/// </summary>
		NoAutoMerge = 512,
		/// <summary>
		/// Platform Window: Display on top (for tooltips only).<br/>
		/// </summary>
		TopMost = 1024,
		/// <summary>
		/// Viewport can host multiple imgui windows (secondary viewports are associated to a single window). FIXME: In practice there's still probably code making the assumption that this is always and only on the MainViewport. Will fix once we add support for "no main viewport".<br/>
		/// </summary>
		CanHostOtherWindows = 2048,
		/// <summary>
		/// Platform Window: Window is minimized, can skip render. When minimized we tend to avoid using the viewport pos/size for clipping window or testing if they are contained in the viewport.<br/>
		/// </summary>
		IsMinimized = 4096,
		/// <summary>
		/// Platform Window: Window is focused (last call to Platform_GetWindowFocus() returned true)<br/>
		/// </summary>
		IsFocused = 8192,
	}
}
