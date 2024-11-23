using System;

namespace SharpImGui
{
	/// <summary>
	/// <para>Flags for ImGui::Begin()</para>
	/// <para>(Those are per-window flags. There are shared flags in ImGuiIO: io.ConfigWindowsResizeFromEdges and io.ConfigWindowsMoveFromTitleBarOnly)</para>
	/// </summary>
	[Flags]
	public enum ImGuiWindowFlags
	{
		None = 0,
		/// <summary>
		/// Disable title-bar
		/// </summary>
		NoTitleBar = 1<<0,
		/// <summary>
		/// Disable user resizing with the lower-right grip
		/// </summary>
		NoResize = 1<<1,
		/// <summary>
		/// Disable user moving the window
		/// </summary>
		NoMove = 1<<2,
		/// <summary>
		/// Disable scrollbars (window can still scroll with mouse or programmatically)
		/// </summary>
		NoScrollbar = 1<<3,
		/// <summary>
		/// Disable user vertically scrolling with mouse wheel. On child window, mouse wheel will be forwarded to the parent unless NoScrollbar is also set.
		/// </summary>
		NoScrollWithMouse = 1<<4,
		/// <summary>
		/// Disable user collapsing window by double-clicking on it. Also referred to as Window Menu Button (e.g. within a docking node).
		/// </summary>
		NoCollapse = 1<<5,
		/// <summary>
		/// Resize every window to its content every frame
		/// </summary>
		AlwaysAutoResize = 1<<6,
		/// <summary>
		/// Disable drawing background color (WindowBg, etc.) and outside border. Similar as using SetNextWindowBgAlpha(0.0f).
		/// </summary>
		NoBackground = 1<<7,
		/// <summary>
		/// Never load/save settings in .ini file
		/// </summary>
		NoSavedSettings = 1<<8,
		/// <summary>
		/// Disable catching mouse, hovering test with pass through.
		/// </summary>
		NoMouseInputs = 1<<9,
		/// <summary>
		/// Has a menu-bar
		/// </summary>
		MenuBar = 1<<10,
		/// <summary>
		/// Allow horizontal scrollbar to appear (off by default). You may use SetNextWindowContentSize(ImVec2(width,0.0f)); prior to calling Begin() to specify width. Read code in imgui_demo in the "Horizontal Scrolling" section.
		/// </summary>
		HorizontalScrollbar = 1<<11,
		/// <summary>
		/// Disable taking focus when transitioning from hidden to visible state
		/// </summary>
		NoFocusOnAppearing = 1<<12,
		/// <summary>
		/// Disable bringing window to front when taking focus (e.g. clicking on it or programmatically giving it focus)
		/// </summary>
		NoBringToFrontOnFocus = 1<<13,
		/// <summary>
		/// Always show vertical scrollbar (even if ContentSize.y &lt; Size.y)
		/// </summary>
		AlwaysVerticalScrollbar = 1<<14,
		/// <summary>
		/// Always show horizontal scrollbar (even if ContentSize.x &lt; Size.x)
		/// </summary>
		AlwaysHorizontalScrollbar = 1<<15,
		/// <summary>
		/// No keyboard/gamepad navigation within the window
		/// </summary>
		NoNavInputs = 1<<16,
		/// <summary>
		/// No focusing toward this window with keyboard/gamepad navigation (e.g. skipped by CTRL+TAB)
		/// </summary>
		NoNavFocus = 1<<17,
		/// <summary>
		/// Display a dot next to the title. When used in a tab/docking context, tab is selected when clicking the X + closure is not assumed (will wait for user to stop submitting the tab). Otherwise closure is assumed when pressing the X, so if you keep submitting the tab may reappear at end of tab bar.
		/// </summary>
		UnsavedDocument = 1<<18,
		/// <summary>
		/// Disable docking of this window
		/// </summary>
		NoDocking = 1<<19,
		NoNav = NoNavInputs | NoNavFocus,
		NoDecoration = NoTitleBar | NoResize | NoScrollbar | NoCollapse,
		NoInputs = NoMouseInputs | NoNavInputs | NoNavFocus,
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Don't use! For internal use by BeginChild()
		/// </summary>
		ChildWindow = 1<<24,
		/// <summary>
		/// Don't use! For internal use by BeginTooltip()
		/// </summary>
		Tooltip = 1<<25,
		/// <summary>
		/// Don't use! For internal use by BeginPopup()
		/// </summary>
		Popup = 1<<26,
		/// <summary>
		/// Don't use! For internal use by BeginPopupModal()
		/// </summary>
		Modal = 1<<27,
		/// <summary>
		/// Don't use! For internal use by BeginMenu()
		/// </summary>
		ChildMenu = 1<<28,
		/// <summary>
		/// Don't use! For internal use by Begin()/NewFrame()
		/// </summary>
		DockNodeHost = 1<<29,
	}

	/// <summary>
	/// <para>Flags for ImGui::BeginChild()</para>
	/// <para>(Legacy: bit 0 must always correspond to ImGuiChildFlags_Borders to be backward compatible with old API using 'bool border = false'.</para>
	/// <para>About using AutoResizeX/AutoResizeY flags:</para>
	/// <para>- May be combined with SetNextWindowSizeConstraints() to set a min/max size for each axis (see "Demo-&gt;Child-&gt;Auto-resize with Constraints").</para>
	/// <para>- Size measurement for a given axis is only performed when the child window is within visible boundaries, or is just appearing.</para>
	/// <para>  - This allows BeginChild() to return false when not within boundaries (e.g. when scrolling), which is more optimal. BUT it won't update its auto-size while clipped.</para>
	/// <para>    While not perfect, it is a better default behavior as the always-on performance gain is more valuable than the occasional "resizing after becoming visible again" glitch.</para>
	/// <para>  - You may also use ImGuiChildFlags_AlwaysAutoResize to force an update even when child window is not in view.</para>
	/// <para>    HOWEVER PLEASE UNDERSTAND THAT DOING SO WILL PREVENT BeginChild() FROM EVER RETURNING FALSE, disabling benefits of coarse clipping.</para>
	/// </summary>
	[Flags]
	public enum ImGuiChildFlags
	{
		None = 0,
		/// <summary>
		/// Show an outer border and enable WindowPadding. (IMPORTANT: this is always == 1 == true for legacy reason)
		/// </summary>
		Borders = 1<<0,
		/// <summary>
		/// Pad with style.WindowPadding even if no border are drawn (no padding by default for non-bordered child windows because it makes more sense)
		/// </summary>
		AlwaysUseWindowPadding = 1<<1,
		/// <summary>
		/// Allow resize from right border (layout direction). Enable .ini saving (unless ImGuiWindowFlags_NoSavedSettings passed to window flags)
		/// </summary>
		ResizeX = 1<<2,
		/// <summary>
		/// Allow resize from bottom border (layout direction). "
		/// </summary>
		ResizeY = 1<<3,
		/// <summary>
		/// Enable auto-resizing width. Read "IMPORTANT: Size measurement" details above.
		/// </summary>
		AutoResizeX = 1<<4,
		/// <summary>
		/// Enable auto-resizing height. Read "IMPORTANT: Size measurement" details above.
		/// </summary>
		AutoResizeY = 1<<5,
		/// <summary>
		/// Combined with AutoResizeX/AutoResizeY. Always measure size even when child is hidden, always return true, always disable clipping optimization! NOT RECOMMENDED.
		/// </summary>
		AlwaysAutoResize = 1<<6,
		/// <summary>
		/// Style the child window like a framed item: use FrameBg, FrameRounding, FrameBorderSize, FramePadding instead of ChildBg, ChildRounding, ChildBorderSize, WindowPadding.
		/// </summary>
		FrameStyle = 1<<7,
		/// <summary>
		/// [BETA] Share focus scope, allow keyboard/gamepad navigation to cross over parent border to this child or between sibling child windows.
		/// </summary>
		NavFlattened = 1<<8,
	}

	/// <summary>
	/// <para>Flags for ImGui::PushItemFlag()</para>
	/// <para>(Those are shared by all items)</para>
	/// </summary>
	[Flags]
	public enum ImGuiItemFlags
	{
		/// <summary>
		/// (Default)
		/// </summary>
		None = 0,
		/// <summary>
		/// false    // Disable keyboard tabbing. This is a "lighter" version of ImGuiItemFlags_NoNav.
		/// </summary>
		NoTabStop = 1<<0,
		/// <summary>
		/// false    // Disable any form of focusing (keyboard/gamepad directional navigation and SetKeyboardFocusHere() calls).
		/// </summary>
		NoNav = 1<<1,
		/// <summary>
		/// false    // Disable item being a candidate for default focus (e.g. used by title bar items).
		/// </summary>
		NoNavDefaultFocus = 1<<2,
		/// <summary>
		/// false    // Any button-like behavior will have repeat mode enabled (based on io.KeyRepeatDelay and io.KeyRepeatRate values). Note that you can also call IsItemActive() after any button to tell if it is being held.
		/// </summary>
		ButtonRepeat = 1<<3,
		/// <summary>
		/// true     // MenuItem()/Selectable() automatically close their parent popup window.
		/// </summary>
		AutoClosePopups = 1<<4,
		/// <summary>
		/// false    // Allow submitting an item with the same identifier as an item already submitted this frame without triggering a warning tooltip if io.ConfigDebugHighlightIdConflicts is set.
		/// </summary>
		AllowDuplicateId = 1<<5,
	}

	/// <summary>
	/// <para>Flags for ImGui::InputText()</para>
	/// <para>(Those are per-item flags. There are shared flags in ImGuiIO: io.ConfigInputTextCursorBlink and io.ConfigInputTextEnterKeepActive)</para>
	/// </summary>
	[Flags]
	public enum ImGuiInputTextFlags
	{
		/// <summary>
		/// <para>Basic filters (also see ImGuiInputTextFlags_CallbackCharFilter)</para>
		/// </summary>
		None = 0,
		/// <summary>
		/// Allow 0123456789.+-*/
		/// </summary>
		CharsDecimal = 1<<0,
		/// <summary>
		/// Allow 0123456789ABCDEFabcdef
		/// </summary>
		CharsHexadecimal = 1<<1,
		/// <summary>
		/// Allow 0123456789.+-*/eE (Scientific notation input)
		/// </summary>
		CharsScientific = 1<<2,
		/// <summary>
		/// Turn a..z into A..Z
		/// </summary>
		CharsUppercase = 1<<3,
		/// <summary>
		/// Filter out spaces, tabs
		/// </summary>
		CharsNoBlank = 1<<4,
		/// <summary>
		/// <para>Inputs</para>
		/// </summary>
		/// <summary>
		/// Pressing TAB input a '\t' character into the text field
		/// </summary>
		AllowTabInput = 1<<5,
		/// <summary>
		/// Return 'true' when Enter is pressed (as opposed to every time the value was modified). Consider using IsItemDeactivatedAfterEdit() instead!
		/// </summary>
		EnterReturnsTrue = 1<<6,
		/// <summary>
		/// Escape key clears content if not empty, and deactivate otherwise (contrast to default behavior of Escape to revert)
		/// </summary>
		EscapeClearsAll = 1<<7,
		/// <summary>
		/// In multi-line mode, validate with Enter, add new line with Ctrl+Enter (default is opposite: validate with Ctrl+Enter, add line with Enter).
		/// </summary>
		CtrlEnterForNewLine = 1<<8,
		/// <summary>
		/// <para>Other options</para>
		/// </summary>
		/// <summary>
		/// Read-only mode
		/// </summary>
		ReadOnly = 1<<9,
		/// <summary>
		/// Password mode, display all characters as '*', disable copy
		/// </summary>
		Password = 1<<10,
		/// <summary>
		/// Overwrite mode
		/// </summary>
		AlwaysOverwrite = 1<<11,
		/// <summary>
		/// Select entire text when first taking mouse focus
		/// </summary>
		AutoSelectAll = 1<<12,
		/// <summary>
		/// InputFloat(), InputInt(), InputScalar() etc. only: parse empty string as zero value.
		/// </summary>
		ParseEmptyRefVal = 1<<13,
		/// <summary>
		/// InputFloat(), InputInt(), InputScalar() etc. only: when value is zero, do not display it. Generally used with ImGuiInputTextFlags_ParseEmptyRefVal.
		/// </summary>
		DisplayEmptyRefVal = 1<<14,
		/// <summary>
		/// Disable following the cursor horizontally
		/// </summary>
		NoHorizontalScroll = 1<<15,
		/// <summary>
		/// Disable undo/redo. Note that input text owns the text data while active, if you want to provide your own undo/redo stack you need e.g. to call ClearActiveID().
		/// </summary>
		NoUndoRedo = 1<<16,
		/// <summary>
		/// <para>Callback features</para>
		/// </summary>
		/// <summary>
		/// Callback on pressing TAB (for completion handling)
		/// </summary>
		CallbackCompletion = 1<<17,
		/// <summary>
		/// Callback on pressing Up/Down arrows (for history handling)
		/// </summary>
		CallbackHistory = 1<<18,
		/// <summary>
		/// Callback on each iteration. User code may query cursor position, modify text buffer.
		/// </summary>
		CallbackAlways = 1<<19,
		/// <summary>
		/// Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.
		/// </summary>
		CallbackCharFilter = 1<<20,
		/// <summary>
		/// Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow. Notify when the string wants to be resized (for string types which hold a cache of their Size). You will be provided a new BufSize in the callback and NEED to honor it. (see misc/cpp/imgui_stdlib.h for an example of using this)
		/// </summary>
		CallbackResize = 1<<21,
		/// <summary>
		/// Callback on any edit (note that InputText() already returns true on edit, the callback is useful mainly to manipulate the underlying buffer while focus is active)
		/// </summary>
		CallbackEdit = 1<<22,
	}

	/// <summary>
	/// <para>Flags for ImGui::TreeNodeEx(), ImGui::CollapsingHeader*()</para>
	/// </summary>
	[Flags]
	public enum ImGuiTreeNodeFlags
	{
		None = 0,
		/// <summary>
		/// Draw as selected
		/// </summary>
		Selected = 1<<0,
		/// <summary>
		/// Draw frame with background (e.g. for CollapsingHeader)
		/// </summary>
		Framed = 1<<1,
		/// <summary>
		/// Hit testing to allow subsequent widgets to overlap this one
		/// </summary>
		AllowOverlap = 1<<2,
		/// <summary>
		/// Don't do a TreePush() when open (e.g. for CollapsingHeader) = no extra indent nor pushing on ID stack
		/// </summary>
		NoTreePushOnOpen = 1<<3,
		/// <summary>
		/// Don't automatically and temporarily open node when Logging is active (by default logging will automatically open tree nodes)
		/// </summary>
		NoAutoOpenOnLog = 1<<4,
		/// <summary>
		/// Default node to be open
		/// </summary>
		DefaultOpen = 1<<5,
		/// <summary>
		/// Open on double-click instead of simple click (default for multi-select unless any _OpenOnXXX behavior is set explicitly). Both behaviors may be combined.
		/// </summary>
		OpenOnDoubleClick = 1<<6,
		/// <summary>
		/// Open when clicking on the arrow part (default for multi-select unless any _OpenOnXXX behavior is set explicitly). Both behaviors may be combined.
		/// </summary>
		OpenOnArrow = 1<<7,
		/// <summary>
		/// No collapsing, no arrow (use as a convenience for leaf nodes).
		/// </summary>
		Leaf = 1<<8,
		/// <summary>
		/// Display a bullet instead of arrow. IMPORTANT: node can still be marked open/close if you don't set the _Leaf flag!
		/// </summary>
		Bullet = 1<<9,
		/// <summary>
		/// Use FramePadding (even for an unframed text node) to vertically align text baseline to regular widget height. Equivalent to calling AlignTextToFramePadding() before the node.
		/// </summary>
		FramePadding = 1<<10,
		/// <summary>
		/// Extend hit box to the right-most edge, even if not framed. This is not the default in order to allow adding other items on the same line without using AllowOverlap mode.
		/// </summary>
		SpanAvailWidth = 1<<11,
		/// <summary>
		/// Extend hit box to the left-most and right-most edges (cover the indent area).
		/// </summary>
		SpanFullWidth = 1<<12,
		/// <summary>
		/// Narrow hit box + narrow hovering highlight, will only cover the label text.
		/// </summary>
		SpanTextWidth = 1<<13,
		/// <summary>
		/// Frame will span all columns of its container table (text will still fit in current column)
		/// </summary>
		SpanAllColumns = 1<<14,
		/// <summary>
		/// (WIP) Nav: left direction may move to this TreeNode() from any of its child (items submitted between TreeNode and TreePop)
		/// </summary>
		NavLeftJumpsBackHere = 1<<15,
		/// <summary>
		/// <para>//ImGuiTreeNodeFlags_NoScrollOnOpen     = 1 &lt;&lt; 16,  // FIXME: TODO: Disable automatic scroll on TreePop() if node got just open and contents is not visible</para>
		/// </summary>
		CollapsingHeader = Framed | NoTreePushOnOpen | NoAutoOpenOnLog,
	}

	/// <summary>
	/// <para>Flags for OpenPopup*(), BeginPopupContext*(), IsPopupOpen() functions.</para>
	/// <para>- To be backward compatible with older API which took an 'int mouse_button = 1' argument instead of 'ImGuiPopupFlags flags',</para>
	/// <para>  we need to treat small flags values as a mouse button index, so we encode the mouse button in the first few bits of the flags.</para>
	/// <para>  It is therefore guaranteed to be legal to pass a mouse button index in ImGuiPopupFlags.</para>
	/// <para>- For the same reason, we exceptionally default the ImGuiPopupFlags argument of BeginPopupContextXXX functions to 1 instead of 0.</para>
	/// <para>  IMPORTANT: because the default parameter is 1 (==ImGuiPopupFlags_MouseButtonRight), if you rely on the default parameter</para>
	/// <para>  and want to use another flag, you need to pass in the ImGuiPopupFlags_MouseButtonRight flag explicitly.</para>
	/// <para>- Multiple buttons currently cannot be combined/or-ed in those functions (we could allow it later).</para>
	/// </summary>
	[Flags]
	public enum ImGuiPopupFlags
	{
		None = 0,
		/// <summary>
		/// For BeginPopupContext*(): open on Left Mouse release. Guaranteed to always be == 0 (same as ImGuiMouseButton_Left)
		/// </summary>
		MouseButtonLeft = 0,
		/// <summary>
		/// For BeginPopupContext*(): open on Right Mouse release. Guaranteed to always be == 1 (same as ImGuiMouseButton_Right)
		/// </summary>
		MouseButtonRight = 1,
		/// <summary>
		/// For BeginPopupContext*(): open on Middle Mouse release. Guaranteed to always be == 2 (same as ImGuiMouseButton_Middle)
		/// </summary>
		MouseButtonMiddle = 2,
		MouseButtonMask_ = 0x1F,
		MouseButtonDefault_ = 1,
		/// <summary>
		/// For OpenPopup*(), BeginPopupContext*(): don't reopen same popup if already open (won't reposition, won't reinitialize navigation)
		/// </summary>
		NoReopen = 1<<5,
		/// <summary>
		/// <para>//ImGuiPopupFlags_NoReopenAlwaysNavInit = 1 &lt;&lt; 6,   // For OpenPopup*(), BeginPopupContext*(): focus and initialize navigation even when not reopening.</para>
		/// </summary>
		/// <summary>
		/// For OpenPopup*(), BeginPopupContext*(): don't open if there's already a popup at the same level of the popup stack
		/// </summary>
		NoOpenOverExistingPopup = 1<<7,
		/// <summary>
		/// For BeginPopupContextWindow(): don't return true when hovering items, only when hovering empty space
		/// </summary>
		NoOpenOverItems = 1<<8,
		/// <summary>
		/// For IsPopupOpen(): ignore the ImGuiID parameter and test for any popup.
		/// </summary>
		AnyPopupId = 1<<10,
		/// <summary>
		/// For IsPopupOpen(): search/test at any level of the popup stack (default test in the current level)
		/// </summary>
		AnyPopupLevel = 1<<11,
		AnyPopup = AnyPopupId | AnyPopupLevel,
	}

	/// <summary>
	/// <para>Flags for ImGui::Selectable()</para>
	/// </summary>
	[Flags]
	public enum ImGuiSelectableFlags
	{
		None = 0,
		/// <summary>
		/// Clicking this doesn't close parent popup window (overrides ImGuiItemFlags_AutoClosePopups)
		/// </summary>
		NoAutoClosePopups = 1<<0,
		/// <summary>
		/// Frame will span all columns of its container table (text will still fit in current column)
		/// </summary>
		SpanAllColumns = 1<<1,
		/// <summary>
		/// Generate press events on double clicks too
		/// </summary>
		AllowDoubleClick = 1<<2,
		/// <summary>
		/// Cannot be selected, display grayed out text
		/// </summary>
		Disabled = 1<<3,
		/// <summary>
		/// (WIP) Hit testing to allow subsequent widgets to overlap this one
		/// </summary>
		AllowOverlap = 1<<4,
		/// <summary>
		/// Make the item be displayed as if it is hovered
		/// </summary>
		Highlight = 1<<5,
	}

	/// <summary>
	/// <para>Flags for ImGui::BeginCombo()</para>
	/// </summary>
	[Flags]
	public enum ImGuiComboFlags
	{
		None = 0,
		/// <summary>
		/// Align the popup toward the left by default
		/// </summary>
		PopupAlignLeft = 1<<0,
		/// <summary>
		/// Max ~4 items visible. Tip: If you want your combo popup to be a specific size you can use SetNextWindowSizeConstraints() prior to calling BeginCombo()
		/// </summary>
		HeightSmall = 1<<1,
		/// <summary>
		/// Max ~8 items visible (default)
		/// </summary>
		HeightRegular = 1<<2,
		/// <summary>
		/// Max ~20 items visible
		/// </summary>
		HeightLarge = 1<<3,
		/// <summary>
		/// As many fitting items as possible
		/// </summary>
		HeightLargest = 1<<4,
		/// <summary>
		/// Display on the preview box without the square arrow button
		/// </summary>
		NoArrowButton = 1<<5,
		/// <summary>
		/// Display only a square arrow button
		/// </summary>
		NoPreview = 1<<6,
		/// <summary>
		/// Width dynamically calculated from preview contents
		/// </summary>
		WidthFitPreview = 1<<7,
		HeightMask_ = HeightSmall | HeightRegular | HeightLarge | HeightLargest,
	}

	/// <summary>
	/// <para>Flags for ImGui::BeginTabBar()</para>
	/// </summary>
	[Flags]
	public enum ImGuiTabBarFlags
	{
		None = 0,
		/// <summary>
		/// Allow manually dragging tabs to re-order them + New tabs are appended at the end of list
		/// </summary>
		Reorderable = 1<<0,
		/// <summary>
		/// Automatically select new tabs when they appear
		/// </summary>
		AutoSelectNewTabs = 1<<1,
		/// <summary>
		/// Disable buttons to open the tab list popup
		/// </summary>
		TabListPopupButton = 1<<2,
		/// <summary>
		/// Disable behavior of closing tabs (that are submitted with p_open != NULL) with middle mouse button. You may handle this behavior manually on user's side with if (IsItemHovered() &amp;&amp; IsMouseClicked(2)) *p_open = false.
		/// </summary>
		NoCloseWithMiddleMouseButton = 1<<3,
		/// <summary>
		/// Disable scrolling buttons (apply when fitting policy is ImGuiTabBarFlags_FittingPolicyScroll)
		/// </summary>
		NoTabListScrollingButtons = 1<<4,
		/// <summary>
		/// Disable tooltips when hovering a tab
		/// </summary>
		NoTooltip = 1<<5,
		/// <summary>
		/// Draw selected overline markers over selected tab
		/// </summary>
		DrawSelectedOverline = 1<<6,
		/// <summary>
		/// Resize tabs when they don't fit
		/// </summary>
		FittingPolicyResizeDown = 1<<7,
		/// <summary>
		/// Add scroll buttons when tabs don't fit
		/// </summary>
		FittingPolicyScroll = 1<<8,
		FittingPolicyMask_ = FittingPolicyResizeDown | FittingPolicyScroll,
		FittingPolicyDefault_ = FittingPolicyResizeDown,
	}

	/// <summary>
	/// <para>Flags for ImGui::BeginTabItem()</para>
	/// </summary>
	[Flags]
	public enum ImGuiTabItemFlags
	{
		None = 0,
		/// <summary>
		/// Display a dot next to the title + set ImGuiTabItemFlags_NoAssumedClosure.
		/// </summary>
		UnsavedDocument = 1<<0,
		/// <summary>
		/// Trigger flag to programmatically make the tab selected when calling BeginTabItem()
		/// </summary>
		SetSelected = 1<<1,
		/// <summary>
		/// Disable behavior of closing tabs (that are submitted with p_open != NULL) with middle mouse button. You may handle this behavior manually on user's side with if (IsItemHovered() &amp;&amp; IsMouseClicked(2)) *p_open = false.
		/// </summary>
		NoCloseWithMiddleMouseButton = 1<<2,
		/// <summary>
		/// Don't call PushID()/PopID() on BeginTabItem()/EndTabItem()
		/// </summary>
		NoPushId = 1<<3,
		/// <summary>
		/// Disable tooltip for the given tab
		/// </summary>
		NoTooltip = 1<<4,
		/// <summary>
		/// Disable reordering this tab or having another tab cross over this tab
		/// </summary>
		NoReorder = 1<<5,
		/// <summary>
		/// Enforce the tab position to the left of the tab bar (after the tab list popup button)
		/// </summary>
		Leading = 1<<6,
		/// <summary>
		/// Enforce the tab position to the right of the tab bar (before the scrolling buttons)
		/// </summary>
		Trailing = 1<<7,
		/// <summary>
		/// Tab is selected when trying to close + closure is not immediately assumed (will wait for user to stop submitting the tab). Otherwise closure is assumed when pressing the X, so if you keep submitting the tab may reappear at end of tab bar.
		/// </summary>
		NoAssumedClosure = 1<<8,
	}

	/// <summary>
	/// <para>Flags for ImGui::IsWindowFocused()</para>
	/// </summary>
	[Flags]
	public enum ImGuiFocusedFlags
	{
		None = 0,
		/// <summary>
		/// Return true if any children of the window is focused
		/// </summary>
		ChildWindows = 1<<0,
		/// <summary>
		/// Test from root window (top most parent of the current hierarchy)
		/// </summary>
		RootWindow = 1<<1,
		/// <summary>
		/// Return true if any window is focused. Important: If you are trying to tell how to dispatch your low-level inputs, do NOT use this. Use 'io.WantCaptureMouse' instead! Please read the FAQ!
		/// </summary>
		AnyWindow = 1<<2,
		/// <summary>
		/// Do not consider popup hierarchy (do not treat popup emitter as parent of popup) (when used with _ChildWindows or _RootWindow)
		/// </summary>
		NoPopupHierarchy = 1<<3,
		/// <summary>
		/// Consider docking hierarchy (treat dockspace host as parent of docked window) (when used with _ChildWindows or _RootWindow)
		/// </summary>
		DockHierarchy = 1<<4,
		RootAndChildWindows = RootWindow | ChildWindows,
	}

	/// <summary>
	/// <para>Flags for ImGui::IsItemHovered(), ImGui::IsWindowHovered()</para>
	/// <para>Note: if you are trying to check whether your mouse should be dispatched to Dear ImGui or to your app, you should use 'io.WantCaptureMouse' instead! Please read the FAQ!</para>
	/// <para>Note: windows with the ImGuiWindowFlags_NoInputs flag are ignored by IsWindowHovered() calls.</para>
	/// </summary>
	[Flags]
	public enum ImGuiHoveredFlags
	{
		/// <summary>
		/// Return true if directly over the item/window, not obstructed by another window, not obstructed by an active popup or modal blocking inputs under them.
		/// </summary>
		None = 0,
		/// <summary>
		/// IsWindowHovered() only: Return true if any children of the window is hovered
		/// </summary>
		ChildWindows = 1<<0,
		/// <summary>
		/// IsWindowHovered() only: Test from root window (top most parent of the current hierarchy)
		/// </summary>
		RootWindow = 1<<1,
		/// <summary>
		/// IsWindowHovered() only: Return true if any window is hovered
		/// </summary>
		AnyWindow = 1<<2,
		/// <summary>
		/// IsWindowHovered() only: Do not consider popup hierarchy (do not treat popup emitter as parent of popup) (when used with _ChildWindows or _RootWindow)
		/// </summary>
		NoPopupHierarchy = 1<<3,
		/// <summary>
		/// IsWindowHovered() only: Consider docking hierarchy (treat dockspace host as parent of docked window) (when used with _ChildWindows or _RootWindow)
		/// </summary>
		DockHierarchy = 1<<4,
		/// <summary>
		/// Return true even if a popup window is normally blocking access to this item/window
		/// </summary>
		AllowWhenBlockedByPopup = 1<<5,
		/// <summary>
		/// <para>//ImGuiHoveredFlags_AllowWhenBlockedByModal     = 1 &lt;&lt; 6,   // Return true even if a modal popup window is normally blocking access to this item/window. FIXME-TODO: Unavailable yet.</para>
		/// </summary>
		/// <summary>
		/// Return true even if an active item is blocking access to this item/window. Useful for Drag and Drop patterns.
		/// </summary>
		AllowWhenBlockedByActiveItem = 1<<7,
		/// <summary>
		/// IsItemHovered() only: Return true even if the item uses AllowOverlap mode and is overlapped by another hoverable item.
		/// </summary>
		AllowWhenOverlappedByItem = 1<<8,
		/// <summary>
		/// IsItemHovered() only: Return true even if the position is obstructed or overlapped by another window.
		/// </summary>
		AllowWhenOverlappedByWindow = 1<<9,
		/// <summary>
		/// IsItemHovered() only: Return true even if the item is disabled
		/// </summary>
		AllowWhenDisabled = 1<<10,
		/// <summary>
		/// IsItemHovered() only: Disable using keyboard/gamepad navigation state when active, always query mouse
		/// </summary>
		NoNavOverride = 1<<11,
		AllowWhenOverlapped = AllowWhenOverlappedByItem | AllowWhenOverlappedByWindow,
		RectOnly = AllowWhenBlockedByPopup | AllowWhenBlockedByActiveItem | AllowWhenOverlapped,
		RootAndChildWindows = RootWindow | ChildWindows,
		/// <summary>
		/// <para>Tooltips mode</para>
		/// <para>- typically used in IsItemHovered() + SetTooltip() sequence.</para>
		/// <para>- this is a shortcut to pull flags from 'style.HoverFlagsForTooltipMouse' or 'style.HoverFlagsForTooltipNav' where you can reconfigure desired behavior.</para>
		/// <para>  e.g. 'TooltipHoveredFlagsForMouse' defaults to 'ImGuiHoveredFlags_Stationary | ImGuiHoveredFlags_DelayShort'.</para>
		/// <para>- for frequently actioned or hovered items providing a tooltip, you want may to use ImGuiHoveredFlags_ForTooltip (stationary + delay) so the tooltip doesn't show too often.</para>
		/// <para>- for items which main purpose is to be hovered, or items with low affordance, or in less consistent apps, prefer no delay or shorter delay.</para>
		/// </summary>
		/// <summary>
		/// Shortcut for standard flags when using IsItemHovered() + SetTooltip() sequence.
		/// </summary>
		ForTooltip = 1<<12,
		/// <summary>
		/// <para>(Advanced) Mouse Hovering delays.</para>
		/// <para>- generally you can use ImGuiHoveredFlags_ForTooltip to use application-standardized flags.</para>
		/// <para>- use those if you need specific overrides.</para>
		/// </summary>
		/// <summary>
		/// Require mouse to be stationary for style.HoverStationaryDelay (~0.15 sec) _at least one time_. After this, can move on same item/window. Using the stationary test tends to reduces the need for a long delay.
		/// </summary>
		Stationary = 1<<13,
		/// <summary>
		/// IsItemHovered() only: Return true immediately (default). As this is the default you generally ignore this.
		/// </summary>
		DelayNone = 1<<14,
		/// <summary>
		/// IsItemHovered() only: Return true after style.HoverDelayShort elapsed (~0.15 sec) (shared between items) + requires mouse to be stationary for style.HoverStationaryDelay (once per item).
		/// </summary>
		DelayShort = 1<<15,
		/// <summary>
		/// IsItemHovered() only: Return true after style.HoverDelayNormal elapsed (~0.40 sec) (shared between items) + requires mouse to be stationary for style.HoverStationaryDelay (once per item).
		/// </summary>
		DelayNormal = 1<<16,
		/// <summary>
		/// IsItemHovered() only: Disable shared delay system where moving from one item to the next keeps the previous timer for a short time (standard for tooltips with long delays)
		/// </summary>
		NoSharedDelay = 1<<17,
	}

	/// <summary>
	/// <para>Flags for ImGui::DockSpace(), shared/inherited by child nodes.</para>
	/// <para>(Some flags can be applied to individual nodes directly)</para>
	/// <para>FIXME-DOCK: Also see ImGuiDockNodeFlagsPrivate_ which may involve using the WIP and internal DockBuilder api.</para>
	/// </summary>
	[Flags]
	public enum ImGuiDockNodeFlags
	{
		None = 0,
		/// <summary>
		///       // Don't display the dockspace node but keep it alive. Windows docked into this dockspace node won't be undocked.
		/// </summary>
		KeepAliveOnly = 1<<0,
		/// <summary>
		/// <para>//ImGuiDockNodeFlags_NoCentralNode              = 1 &lt;&lt; 1,   //       // Disable Central Node (the node which can stay empty)</para>
		/// </summary>
		/// <summary>
		///       // Disable docking over the Central Node, which will be always kept empty.
		/// </summary>
		NoDockingOverCentralNode = 1<<2,
		/// <summary>
		///       // Enable passthru dockspace: 1) DockSpace() will render a ImGuiCol_WindowBg background covering everything excepted the Central Node when empty. Meaning the host window should probably use SetNextWindowBgAlpha(0.0f) prior to Begin() when using this. 2) When Central Node is empty: let inputs pass-through + won't display a DockingEmptyBg background. See demo for details.
		/// </summary>
		PassthruCentralNode = 1<<3,
		/// <summary>
		///       // Disable other windows/nodes from splitting this node.
		/// </summary>
		NoDockingSplit = 1<<4,
		/// <summary>
		/// Saved // Disable resizing node using the splitter/separators. Useful with programmatically setup dockspaces.
		/// </summary>
		NoResize = 1<<5,
		/// <summary>
		///       // Tab bar will automatically hide when there is a single window in the dock node.
		/// </summary>
		AutoHideTabBar = 1<<6,
		/// <summary>
		///       // Disable undocking this node.
		/// </summary>
		NoUndocking = 1<<7,
	}

	/// <summary>
	/// <para>Flags for ImGui::BeginDragDropSource(), ImGui::AcceptDragDropPayload()</para>
	/// </summary>
	[Flags]
	public enum ImGuiDragDropFlags
	{
		None = 0,
		/// <summary>
		/// <para>BeginDragDropSource() flags</para>
		/// </summary>
		/// <summary>
		/// Disable preview tooltip. By default, a successful call to BeginDragDropSource opens a tooltip so you can display a preview or description of the source contents. This flag disables this behavior.
		/// </summary>
		SourceNoPreviewTooltip = 1<<0,
		/// <summary>
		/// By default, when dragging we clear data so that IsItemHovered() will return false, to avoid subsequent user code submitting tooltips. This flag disables this behavior so you can still call IsItemHovered() on the source item.
		/// </summary>
		SourceNoDisableHover = 1<<1,
		/// <summary>
		/// Disable the behavior that allows to open tree nodes and collapsing header by holding over them while dragging a source item.
		/// </summary>
		SourceNoHoldToOpenOthers = 1<<2,
		/// <summary>
		/// Allow items such as Text(), Image() that have no unique identifier to be used as drag source, by manufacturing a temporary identifier based on their window-relative position. This is extremely unusual within the dear imgui ecosystem and so we made it explicit.
		/// </summary>
		SourceAllowNullID = 1<<3,
		/// <summary>
		/// External source (from outside of dear imgui), won't attempt to read current item/window info. Will always return true. Only one Extern source can be active simultaneously.
		/// </summary>
		SourceExtern = 1<<4,
		/// <summary>
		/// Automatically expire the payload if the source cease to be submitted (otherwise payloads are persisting while being dragged)
		/// </summary>
		PayloadAutoExpire = 1<<5,
		/// <summary>
		/// Hint to specify that the payload may not be copied outside current dear imgui context.
		/// </summary>
		PayloadNoCrossContext = 1<<6,
		/// <summary>
		/// Hint to specify that the payload may not be copied outside current process.
		/// </summary>
		PayloadNoCrossProcess = 1<<7,
		/// <summary>
		/// <para>AcceptDragDropPayload() flags</para>
		/// </summary>
		/// <summary>
		/// AcceptDragDropPayload() will returns true even before the mouse button is released. You can then call IsDelivery() to test if the payload needs to be delivered.
		/// </summary>
		AcceptBeforeDelivery = 1<<10,
		/// <summary>
		/// Do not draw the default highlight rectangle when hovering over target.
		/// </summary>
		AcceptNoDrawDefaultRect = 1<<11,
		/// <summary>
		/// Request hiding the BeginDragDropSource tooltip from the BeginDragDropTarget site.
		/// </summary>
		AcceptNoPreviewTooltip = 1<<12,
		/// <summary>
		/// For peeking ahead and inspecting the payload before delivery.
		/// </summary>
		AcceptPeekOnly = AcceptBeforeDelivery | AcceptNoDrawDefaultRect,
	}

	/// <summary>
	/// <para>A primary data type</para>
	/// </summary>
	public enum ImGuiDataType
	{
		/// <summary>
		/// signed char / char (with sensible compilers)
		/// </summary>
		S8 = 0,
		/// <summary>
		/// unsigned char
		/// </summary>
		U8 = 1,
		/// <summary>
		/// short
		/// </summary>
		S16 = 2,
		/// <summary>
		/// unsigned short
		/// </summary>
		U16 = 3,
		/// <summary>
		/// int
		/// </summary>
		S32 = 4,
		/// <summary>
		/// unsigned int
		/// </summary>
		U32 = 5,
		/// <summary>
		/// long long / __int64
		/// </summary>
		S64 = 6,
		/// <summary>
		/// unsigned long long / unsigned __int64
		/// </summary>
		U64 = 7,
		/// <summary>
		/// float
		/// </summary>
		Float = 8,
		/// <summary>
		/// double
		/// </summary>
		Double = 9,
		/// <summary>
		/// bool (provided for user convenience, not supported by scalar widgets)
		/// </summary>
		Bool = 10,
		COUNT = 11,
	}

	/// <summary>
	/// <para>A cardinal direction</para>
	/// </summary>
	/// <summary>
	/// Forward declared enum type ImGuiDir
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
	/// <para>A sorting direction</para>
	/// </summary>
	/// <summary>
	/// Forward declared enum type ImGuiSortDirection
	/// </summary>
	public enum ImGuiSortDirection
	{
		None = 0,
		/// <summary>
		/// Ascending = 0-&gt;9, A-&gt;Z etc.
		/// </summary>
		Ascending = 1,
		/// <summary>
		/// Descending = 9-&gt;0, Z-&gt;A etc.
		/// </summary>
		Descending = 2,
	}

	/// <summary>
	/// <para>A key identifier (ImGuiKey_XXX or ImGuiMod_XXX value): can represent Keyboard, Mouse and Gamepad values.</para>
	/// <para>All our named keys are &gt;= 512. Keys value 0 to 511 are left unused and were legacy native/opaque key values (&lt; 1.87).</para>
	/// <para>Support for legacy keys was completely removed in 1.91.5.</para>
	/// <para>Read details about the 1.87+ transition : https://github.com/ocornut/imgui/issues/4921</para>
	/// <para>Note that "Keys" related to physical keys and are not the same concept as input "Characters", the later are submitted via io.AddInputCharacter().</para>
	/// <para>The keyboard key enum values are named after the keys on a standard US keyboard, and on other keyboard types the keys reported may not match the keycaps.</para>
	/// </summary>
	/// <summary>
	/// Forward declared enum type ImGuiKey
	/// </summary>
	public enum ImGuiKey
	{
		/// <summary>
		/// <para>Keyboard</para>
		/// </summary>
		None = 0,
		/// <summary>
		/// First valid key value (other than 0)
		/// </summary>
		NamedKey_BEGIN = 512,
		/// <summary>
		/// == ImGuiKey_NamedKey_BEGIN
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
		/// '
		/// </summary>
		Apostrophe = 596,
		/// <summary>
		/// ,
		/// </summary>
		Comma = 597,
		/// <summary>
		/// -
		/// </summary>
		Minus = 598,
		/// <summary>
		/// .
		/// </summary>
		Period = 599,
		/// <summary>
		/// /
		/// </summary>
		Slash = 600,
		/// <summary>
		/// ;
		/// </summary>
		Semicolon = 601,
		/// <summary>
		/// =
		/// </summary>
		Equal = 602,
		/// <summary>
		/// [
		/// </summary>
		LeftBracket = 603,
		/// <summary>
		/// \ (this text inhibit multiline comment caused by backslash)
		/// </summary>
		Backslash = 604,
		/// <summary>
		/// ]
		/// </summary>
		RightBracket = 605,
		/// <summary>
		/// `
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
		/// Available on some keyboard/mouses. Often referred as "Browser Back"
		/// </summary>
		AppBack = 629,
		AppForward = 630,
		/// <summary>
		/// <para>Gamepad (some of those are analog values, 0.0f to 1.0f)                          // NAVIGATION ACTION</para>
		/// <para>(download controller mapping PNG/PSD at http://dearimgui.com/controls_sheets)</para>
		/// </summary>
		/// <summary>
		/// Menu (Xbox)      + (Switch)   Start/Options (PS)
		/// </summary>
		GamepadStart = 631,
		/// <summary>
		/// View (Xbox)      - (Switch)   Share (PS)
		/// </summary>
		GamepadBack = 632,
		/// <summary>
		/// X (Xbox)         Y (Switch)   Square (PS)        // Tap: Toggle Menu. Hold: Windowing mode (Focus/Move/Resize windows)
		/// </summary>
		GamepadFaceLeft = 633,
		/// <summary>
		/// B (Xbox)         A (Switch)   Circle (PS)        // Cancel / Close / Exit
		/// </summary>
		GamepadFaceRight = 634,
		/// <summary>
		/// Y (Xbox)         X (Switch)   Triangle (PS)      // Text Input / On-screen Keyboard
		/// </summary>
		GamepadFaceUp = 635,
		/// <summary>
		/// A (Xbox)         B (Switch)   Cross (PS)         // Activate / Open / Toggle / Tweak
		/// </summary>
		GamepadFaceDown = 636,
		/// <summary>
		/// D-pad Left                                       // Move / Tweak / Resize Window (in Windowing mode)
		/// </summary>
		GamepadDpadLeft = 637,
		/// <summary>
		/// D-pad Right                                      // Move / Tweak / Resize Window (in Windowing mode)
		/// </summary>
		GamepadDpadRight = 638,
		/// <summary>
		/// D-pad Up                                         // Move / Tweak / Resize Window (in Windowing mode)
		/// </summary>
		GamepadDpadUp = 639,
		/// <summary>
		/// D-pad Down                                       // Move / Tweak / Resize Window (in Windowing mode)
		/// </summary>
		GamepadDpadDown = 640,
		/// <summary>
		/// L Bumper (Xbox)  L (Switch)   L1 (PS)            // Tweak Slower / Focus Previous (in Windowing mode)
		/// </summary>
		GamepadL1 = 641,
		/// <summary>
		/// R Bumper (Xbox)  R (Switch)   R1 (PS)            // Tweak Faster / Focus Next (in Windowing mode)
		/// </summary>
		GamepadR1 = 642,
		/// <summary>
		/// L Trig. (Xbox)   ZL (Switch)  L2 (PS) [Analog]
		/// </summary>
		GamepadL2 = 643,
		/// <summary>
		/// R Trig. (Xbox)   ZR (Switch)  R2 (PS) [Analog]
		/// </summary>
		GamepadR2 = 644,
		/// <summary>
		/// L Stick (Xbox)   L3 (Switch)  L3 (PS)
		/// </summary>
		GamepadL3 = 645,
		/// <summary>
		/// R Stick (Xbox)   R3 (Switch)  R3 (PS)
		/// </summary>
		GamepadR3 = 646,
		/// <summary>
		/// [Analog]                                         // Move Window (in Windowing mode)
		/// </summary>
		GamepadLStickLeft = 647,
		/// <summary>
		/// [Analog]                                         // Move Window (in Windowing mode)
		/// </summary>
		GamepadLStickRight = 648,
		/// <summary>
		/// [Analog]                                         // Move Window (in Windowing mode)
		/// </summary>
		GamepadLStickUp = 649,
		/// <summary>
		/// [Analog]                                         // Move Window (in Windowing mode)
		/// </summary>
		GamepadLStickDown = 650,
		/// <summary>
		/// [Analog]
		/// </summary>
		GamepadRStickLeft = 651,
		/// <summary>
		/// [Analog]
		/// </summary>
		GamepadRStickRight = 652,
		/// <summary>
		/// [Analog]
		/// </summary>
		GamepadRStickUp = 653,
		/// <summary>
		/// [Analog]
		/// </summary>
		GamepadRStickDown = 654,
		/// <summary>
		/// <para>Aliases: Mouse Buttons (auto-submitted from AddMouseButtonEvent() calls)</para>
		/// <para>- This is mirroring the data also written to io.MouseDown[], io.MouseWheel, in a format allowing them to be accessed via standard key API.</para>
		/// </summary>
		MouseLeft = 655,
		MouseRight = 656,
		MouseMiddle = 657,
		MouseX1 = 658,
		MouseX2 = 659,
		MouseWheelX = 660,
		MouseWheelY = 661,
		/// <summary>
		/// <para>[Internal] Reserved for mod storage</para>
		/// </summary>
		ReservedForModCtrl = 662,
		ReservedForModShift = 663,
		ReservedForModAlt = 664,
		ReservedForModSuper = 665,
		NamedKey_END = 666,
		/// <summary>
		/// <para>Keyboard Modifiers (explicitly submitted by backend via AddKeyEvent() calls)</para>
		/// <para>- This is mirroring the data also written to io.KeyCtrl, io.KeyShift, io.KeyAlt, io.KeySuper, in a format allowing</para>
		/// <para>  them to be accessed via standard key API, allowing calls such as IsKeyPressed(), IsKeyReleased(), querying duration etc.</para>
		/// <para>- Code polling every key (e.g. an interface to detect a key press for input mapping) might want to ignore those</para>
		/// <para>  and prefer using the real keys (e.g. ImGuiKey_LeftCtrl, ImGuiKey_RightCtrl instead of ImGuiMod_Ctrl).</para>
		/// <para>- In theory the value of keyboard modifiers should be roughly equivalent to a logical or of the equivalent left/right keys.</para>
		/// <para>  In practice: it's complicated; mods are often provided from different sources. Keyboard layout, IME, sticky keys and</para>
		/// <para>  backends tend to interfere and break that equivalence. The safer decision is to relay that ambiguity down to the end-user...</para>
		/// <para>- On macOS, we swap Cmd(Super) and Ctrl keys at the time of the io.AddKeyEvent() call.</para>
		/// </summary>
		ImGuiMod_None = 0,
		/// <summary>
		/// Ctrl (non-macOS), Cmd (macOS)
		/// </summary>
		ImGuiMod_Ctrl = 1<<12,
		/// <summary>
		/// Shift
		/// </summary>
		ImGuiMod_Shift = 1<<13,
		/// <summary>
		/// Option/Menu
		/// </summary>
		ImGuiMod_Alt = 1<<14,
		/// <summary>
		/// Windows/Super (non-macOS), Ctrl (macOS)
		/// </summary>
		ImGuiMod_Super = 1<<15,
		/// <summary>
		/// 4-bits
		/// </summary>
		ImGuiMod_Mask_ = 0xF000,
		/// <summary>
		/// <para>[Internal] If you need to iterate all keys (for e.g. an input mapper) you may use ImGuiKey_NamedKey_BEGIN..ImGuiKey_NamedKey_END.</para>
		/// </summary>
		NamedKey_COUNT = NamedKey_END-NamedKey_BEGIN,
	}

	/// <summary>
	/// <para>Flags for Shortcut(), SetNextItemShortcut(),</para>
	/// <para>(and for upcoming extended versions of IsKeyPressed(), IsMouseClicked(), Shortcut(), SetKeyOwner(), SetItemKeyOwner() that are still in imgui_internal.h)</para>
	/// <para>Don't mistake with ImGuiInputTextFlags! (which is for ImGui::InputText() function)</para>
	/// </summary>
	[Flags]
	public enum ImGuiInputFlags
	{
		None = 0,
		/// <summary>
		/// Enable repeat. Return true on successive repeats. Default for legacy IsKeyPressed(). NOT Default for legacy IsMouseClicked(). MUST BE == 1.
		/// </summary>
		Repeat = 1<<0,
		/// <summary>
		/// <para>Flags for Shortcut(), SetNextItemShortcut()</para>
		/// <para>- Routing policies: RouteGlobal+OverActive &gt;&gt; RouteActive or RouteFocused (if owner is active item) &gt;&gt; RouteGlobal+OverFocused &gt;&gt; RouteFocused (if in focused window stack) &gt;&gt; RouteGlobal.</para>
		/// <para>- Default policy is RouteFocused. Can select only 1 policy among all available.</para>
		/// </summary>
		/// <summary>
		/// Route to active item only.
		/// </summary>
		RouteActive = 1<<10,
		/// <summary>
		/// Route to windows in the focus stack (DEFAULT). Deep-most focused window takes inputs. Active item takes inputs over deep-most focused window.
		/// </summary>
		RouteFocused = 1<<11,
		/// <summary>
		/// Global route (unless a focused window or active item registered the route).
		/// </summary>
		RouteGlobal = 1<<12,
		/// <summary>
		/// Do not register route, poll keys directly.
		/// </summary>
		RouteAlways = 1<<13,
		/// <summary>
		/// <para>- Routing options</para>
		/// </summary>
		/// <summary>
		/// Option: global route: higher priority than focused route (unless active item in focused route).
		/// </summary>
		RouteOverFocused = 1<<14,
		/// <summary>
		/// Option: global route: higher priority than active item. Unlikely you need to use that: will interfere with every active items, e.g. CTRL+A registered by InputText will be overridden by this. May not be fully honored as user/internal code is likely to always assume they can access keys when active.
		/// </summary>
		RouteOverActive = 1<<15,
		/// <summary>
		/// Option: global route: will not be applied if underlying background/void is focused (== no Dear ImGui windows are focused). Useful for overlay applications.
		/// </summary>
		RouteUnlessBgFocused = 1<<16,
		/// <summary>
		/// Option: route evaluated from the point of view of root window rather than current window.
		/// </summary>
		RouteFromRootWindow = 1<<17,
		/// <summary>
		/// <para>Flags for SetNextItemShortcut()</para>
		/// </summary>
		/// <summary>
		/// Automatically display a tooltip when hovering item [BETA] Unsure of right api (opt-in/opt-out)
		/// </summary>
		Tooltip = 1<<18,
	}

	/// <summary>
	/// <para>Configuration flags stored in io.ConfigFlags. Set by user/application.</para>
	/// </summary>
	[Flags]
	public enum ImGuiConfigFlags
	{
		None = 0,
		/// <summary>
		/// Master keyboard navigation enable flag. Enable full Tabbing + directional arrows + space/enter to activate.
		/// </summary>
		NavEnableKeyboard = 1<<0,
		/// <summary>
		/// Master gamepad navigation enable flag. Backend also needs to set ImGuiBackendFlags_HasGamepad.
		/// </summary>
		NavEnableGamepad = 1<<1,
		/// <summary>
		/// Instruct dear imgui to disable mouse inputs and interactions.
		/// </summary>
		NoMouse = 1<<4,
		/// <summary>
		/// Instruct backend to not alter mouse cursor shape and visibility. Use if the backend cursor changes are interfering with yours and you don't want to use SetMouseCursor() to change mouse cursor. You may want to honor requests from imgui by reading GetMouseCursor() yourself instead.
		/// </summary>
		NoMouseCursorChange = 1<<5,
		/// <summary>
		/// Instruct dear imgui to disable keyboard inputs and interactions. This is done by ignoring keyboard events and clearing existing states.
		/// </summary>
		NoKeyboard = 1<<6,
		/// <summary>
		/// <para>[BETA] Docking</para>
		/// </summary>
		/// <summary>
		/// Docking enable flags.
		/// </summary>
		DockingEnable = 1<<7,
		/// <summary>
		/// <para>[BETA] Viewports</para>
		/// <para>When using viewports it is recommended that your default value for ImGuiCol_WindowBg is opaque (Alpha=1.0) so transition to a viewport won't be noticeable.</para>
		/// </summary>
		/// <summary>
		/// Viewport enable flags (require both ImGuiBackendFlags_PlatformHasViewports + ImGuiBackendFlags_RendererHasViewports set by the respective backends)
		/// </summary>
		ViewportsEnable = 1<<10,
		/// <summary>
		/// [BETA: Don't use] FIXME-DPI: Reposition and resize imgui windows when the DpiScale of a viewport changed (mostly useful for the main viewport hosting other window). Note that resizing the main window itself is up to your application.
		/// </summary>
		DpiEnableScaleViewports = 1<<14,
		/// <summary>
		/// [BETA: Don't use] FIXME-DPI: Request bitmap-scaled fonts to match DpiScale. This is a very low-quality workaround. The correct way to handle DPI is _currently_ to replace the atlas and/or fonts in the Platform_OnChangedViewport callback, but this is all early work in progress.
		/// </summary>
		DpiEnableScaleFonts = 1<<15,
		/// <summary>
		/// <para>User storage (to allow your backend/engine to communicate to code that may be shared between multiple projects. Those flags are NOT used by core Dear ImGui)</para>
		/// </summary>
		/// <summary>
		/// Application is SRGB-aware.
		/// </summary>
		IsSRGB = 1<<20,
		/// <summary>
		/// Application is using a touch screen instead of a mouse.
		/// </summary>
		IsTouchScreen = 1<<21,
	}

	/// <summary>
	/// <para>Backend capabilities flags stored in io.BackendFlags. Set by imgui_impl_xxx or custom backend.</para>
	/// </summary>
	[Flags]
	public enum ImGuiBackendFlags
	{
		None = 0,
		/// <summary>
		/// Backend Platform supports gamepad and currently has one connected.
		/// </summary>
		HasGamepad = 1<<0,
		/// <summary>
		/// Backend Platform supports honoring GetMouseCursor() value to change the OS cursor shape.
		/// </summary>
		HasMouseCursors = 1<<1,
		/// <summary>
		/// Backend Platform supports io.WantSetMousePos requests to reposition the OS mouse position (only used if io.ConfigNavMoveSetMousePos is set).
		/// </summary>
		HasSetMousePos = 1<<2,
		/// <summary>
		/// Backend Renderer supports ImDrawCmd::VtxOffset. This enables output of large meshes (64K+ vertices) while still using 16-bit indices.
		/// </summary>
		RendererHasVtxOffset = 1<<3,
		/// <summary>
		/// <para>[BETA] Viewports</para>
		/// </summary>
		/// <summary>
		/// Backend Platform supports multiple viewports.
		/// </summary>
		PlatformHasViewports = 1<<10,
		/// <summary>
		/// Backend Platform supports calling io.AddMouseViewportEvent() with the viewport under the mouse. IF POSSIBLE, ignore viewports with the ImGuiViewportFlags_NoInputs flag (Win32 backend, GLFW 3.30+ backend can do this, SDL backend cannot). If this cannot be done, Dear ImGui needs to use a flawed heuristic to find the viewport under.
		/// </summary>
		HasMouseHoveredViewport = 1<<11,
		/// <summary>
		/// Backend Renderer supports multiple viewports.
		/// </summary>
		RendererHasViewports = 1<<12,
	}

	/// <summary>
	/// <para>Enumeration for PushStyleColor() / PopStyleColor()</para>
	/// </summary>
	public enum ImGuiCol
	{
		Text = 0,
		TextDisabled = 1,
		/// <summary>
		/// Background of normal windows
		/// </summary>
		WindowBg = 2,
		/// <summary>
		/// Background of child windows
		/// </summary>
		ChildBg = 3,
		/// <summary>
		/// Background of popups, menus, tooltips windows
		/// </summary>
		PopupBg = 4,
		Border = 5,
		BorderShadow = 6,
		/// <summary>
		/// Background of checkbox, radio button, plot, slider, text input
		/// </summary>
		FrameBg = 7,
		FrameBgHovered = 8,
		FrameBgActive = 9,
		/// <summary>
		/// Title bar
		/// </summary>
		TitleBg = 10,
		/// <summary>
		/// Title bar when focused
		/// </summary>
		TitleBgActive = 11,
		/// <summary>
		/// Title bar when collapsed
		/// </summary>
		TitleBgCollapsed = 12,
		MenuBarBg = 13,
		ScrollbarBg = 14,
		ScrollbarGrab = 15,
		ScrollbarGrabHovered = 16,
		ScrollbarGrabActive = 17,
		/// <summary>
		/// Checkbox tick and RadioButton circle
		/// </summary>
		CheckMark = 18,
		SliderGrab = 19,
		SliderGrabActive = 20,
		Button = 21,
		ButtonHovered = 22,
		ButtonActive = 23,
		/// <summary>
		/// Header* colors are used for CollapsingHeader, TreeNode, Selectable, MenuItem
		/// </summary>
		Header = 24,
		HeaderHovered = 25,
		HeaderActive = 26,
		Separator = 27,
		SeparatorHovered = 28,
		SeparatorActive = 29,
		/// <summary>
		/// Resize grip in lower-right and lower-left corners of windows.
		/// </summary>
		ResizeGrip = 30,
		ResizeGripHovered = 31,
		ResizeGripActive = 32,
		/// <summary>
		/// Tab background, when hovered
		/// </summary>
		TabHovered = 33,
		/// <summary>
		/// Tab background, when tab-bar is focused &amp; tab is unselected
		/// </summary>
		Tab = 34,
		/// <summary>
		/// Tab background, when tab-bar is focused &amp; tab is selected
		/// </summary>
		TabSelected = 35,
		/// <summary>
		/// Tab horizontal overline, when tab-bar is focused &amp; tab is selected
		/// </summary>
		TabSelectedOverline = 36,
		/// <summary>
		/// Tab background, when tab-bar is unfocused &amp; tab is unselected
		/// </summary>
		TabDimmed = 37,
		/// <summary>
		/// Tab background, when tab-bar is unfocused &amp; tab is selected
		/// </summary>
		TabDimmedSelected = 38,
		/// <summary>
		/// //..horizontal overline, when tab-bar is unfocused &amp; tab is selected
		/// </summary>
		TabDimmedSelectedOverline = 39,
		/// <summary>
		/// Preview overlay color when about to docking something
		/// </summary>
		DockingPreview = 40,
		/// <summary>
		/// Background color for empty node (e.g. CentralNode with no window docked into it)
		/// </summary>
		DockingEmptyBg = 41,
		PlotLines = 42,
		PlotLinesHovered = 43,
		PlotHistogram = 44,
		PlotHistogramHovered = 45,
		/// <summary>
		/// Table header background
		/// </summary>
		TableHeaderBg = 46,
		/// <summary>
		/// Table outer and header borders (prefer using Alpha=1.0 here)
		/// </summary>
		TableBorderStrong = 47,
		/// <summary>
		/// Table inner borders (prefer using Alpha=1.0 here)
		/// </summary>
		TableBorderLight = 48,
		/// <summary>
		/// Table row background (even rows)
		/// </summary>
		TableRowBg = 49,
		/// <summary>
		/// Table row background (odd rows)
		/// </summary>
		TableRowBgAlt = 50,
		/// <summary>
		/// Hyperlink color
		/// </summary>
		TextLink = 51,
		TextSelectedBg = 52,
		/// <summary>
		/// Rectangle highlighting a drop target
		/// </summary>
		DragDropTarget = 53,
		/// <summary>
		/// Color of keyboard/gamepad navigation cursor/rectangle, when visible
		/// </summary>
		NavCursor = 54,
		/// <summary>
		/// Highlight window when using CTRL+TAB
		/// </summary>
		NavWindowingHighlight = 55,
		/// <summary>
		/// Darken/colorize entire screen behind the CTRL+TAB window list, when active
		/// </summary>
		NavWindowingDimBg = 56,
		/// <summary>
		/// Darken/colorize entire screen behind a modal window, when one is active
		/// </summary>
		ModalWindowDimBg = 57,
		COUNT = 58,
	}

	/// <summary>
	/// <para>Enumeration for PushStyleVar() / PopStyleVar() to temporarily modify the ImGuiStyle structure.</para>
	/// <para>- The enum only refers to fields of ImGuiStyle which makes sense to be pushed/popped inside UI code.</para>
	/// <para>  During initialization or between frames, feel free to just poke into ImGuiStyle directly.</para>
	/// <para>- Tip: Use your programming IDE navigation facilities on the names in the _second column_ below to find the actual members and their description.</para>
	/// <para>  - In Visual Studio: CTRL+comma ("Edit.GoToAll") can follow symbols inside comments, whereas CTRL+F12 ("Edit.GoToImplementation") cannot.</para>
	/// <para>  - In Visual Studio w/ Visual Assist installed: ALT+G ("VAssistX.GoToImplementation") can also follow symbols inside comments.</para>
	/// <para>  - In VS Code, CLion, etc.: CTRL+click can follow symbols inside comments.</para>
	/// <para>- When changing this enum, you need to update the associated internal table GStyleVarInfo[] accordingly. This is where we link enum values to members offset/type.</para>
	/// </summary>
	public enum ImGuiStyleVar
	{
		/// <summary>
		/// <para>Enum name -------------------------- // Member in ImGuiStyle structure (see ImGuiStyle for descriptions)</para>
		/// </summary>
		/// <summary>
		/// float     Alpha
		/// </summary>
		Alpha = 0,
		/// <summary>
		/// float     DisabledAlpha
		/// </summary>
		DisabledAlpha = 1,
		/// <summary>
		/// ImVec2    WindowPadding
		/// </summary>
		WindowPadding = 2,
		/// <summary>
		/// float     WindowRounding
		/// </summary>
		WindowRounding = 3,
		/// <summary>
		/// float     WindowBorderSize
		/// </summary>
		WindowBorderSize = 4,
		/// <summary>
		/// ImVec2    WindowMinSize
		/// </summary>
		WindowMinSize = 5,
		/// <summary>
		/// ImVec2    WindowTitleAlign
		/// </summary>
		WindowTitleAlign = 6,
		/// <summary>
		/// float     ChildRounding
		/// </summary>
		ChildRounding = 7,
		/// <summary>
		/// float     ChildBorderSize
		/// </summary>
		ChildBorderSize = 8,
		/// <summary>
		/// float     PopupRounding
		/// </summary>
		PopupRounding = 9,
		/// <summary>
		/// float     PopupBorderSize
		/// </summary>
		PopupBorderSize = 10,
		/// <summary>
		/// ImVec2    FramePadding
		/// </summary>
		FramePadding = 11,
		/// <summary>
		/// float     FrameRounding
		/// </summary>
		FrameRounding = 12,
		/// <summary>
		/// float     FrameBorderSize
		/// </summary>
		FrameBorderSize = 13,
		/// <summary>
		/// ImVec2    ItemSpacing
		/// </summary>
		ItemSpacing = 14,
		/// <summary>
		/// ImVec2    ItemInnerSpacing
		/// </summary>
		ItemInnerSpacing = 15,
		/// <summary>
		/// float     IndentSpacing
		/// </summary>
		IndentSpacing = 16,
		/// <summary>
		/// ImVec2    CellPadding
		/// </summary>
		CellPadding = 17,
		/// <summary>
		/// float     ScrollbarSize
		/// </summary>
		ScrollbarSize = 18,
		/// <summary>
		/// float     ScrollbarRounding
		/// </summary>
		ScrollbarRounding = 19,
		/// <summary>
		/// float     GrabMinSize
		/// </summary>
		GrabMinSize = 20,
		/// <summary>
		/// float     GrabRounding
		/// </summary>
		GrabRounding = 21,
		/// <summary>
		/// float     TabRounding
		/// </summary>
		TabRounding = 22,
		/// <summary>
		/// float     TabBorderSize
		/// </summary>
		TabBorderSize = 23,
		/// <summary>
		/// float     TabBarBorderSize
		/// </summary>
		TabBarBorderSize = 24,
		/// <summary>
		/// float     TabBarOverlineSize
		/// </summary>
		TabBarOverlineSize = 25,
		/// <summary>
		/// float     TableAngledHeadersAngle
		/// </summary>
		TableAngledHeadersAngle = 26,
		/// <summary>
		/// ImVec2  TableAngledHeadersTextAlign
		/// </summary>
		TableAngledHeadersTextAlign = 27,
		/// <summary>
		/// ImVec2    ButtonTextAlign
		/// </summary>
		ButtonTextAlign = 28,
		/// <summary>
		/// ImVec2    SelectableTextAlign
		/// </summary>
		SelectableTextAlign = 29,
		/// <summary>
		/// float     SeparatorTextBorderSize
		/// </summary>
		SeparatorTextBorderSize = 30,
		/// <summary>
		/// ImVec2    SeparatorTextAlign
		/// </summary>
		SeparatorTextAlign = 31,
		/// <summary>
		/// ImVec2    SeparatorTextPadding
		/// </summary>
		SeparatorTextPadding = 32,
		/// <summary>
		/// float     DockingSeparatorSize
		/// </summary>
		DockingSeparatorSize = 33,
		COUNT = 34,
	}

	/// <summary>
	/// <para>Flags for InvisibleButton() [extended in imgui_internal.h]</para>
	/// </summary>
	[Flags]
	public enum ImGuiButtonFlags
	{
		None = 0,
		/// <summary>
		/// React on left mouse button (default)
		/// </summary>
		MouseButtonLeft = 1<<0,
		/// <summary>
		/// React on right mouse button
		/// </summary>
		MouseButtonRight = 1<<1,
		/// <summary>
		/// React on center mouse button
		/// </summary>
		MouseButtonMiddle = 1<<2,
		/// <summary>
		/// [Internal]
		/// </summary>
		MouseButtonMask_ = MouseButtonLeft | MouseButtonRight | MouseButtonMiddle,
		/// <summary>
		/// InvisibleButton(): do not disable navigation/tabbing. Otherwise disabled by default.
		/// </summary>
		EnableNav = 1<<3,
	}

	/// <summary>
	/// <para>Flags for ColorEdit3() / ColorEdit4() / ColorPicker3() / ColorPicker4() / ColorButton()</para>
	/// </summary>
	[Flags]
	public enum ImGuiColorEditFlags
	{
		None = 0,
		/// <summary>
		///              // ColorEdit, ColorPicker, ColorButton: ignore Alpha component (will only read 3 components from the input pointer).
		/// </summary>
		NoAlpha = 1<<1,
		/// <summary>
		///              // ColorEdit: disable picker when clicking on color square.
		/// </summary>
		NoPicker = 1<<2,
		/// <summary>
		///              // ColorEdit: disable toggling options menu when right-clicking on inputs/small preview.
		/// </summary>
		NoOptions = 1<<3,
		/// <summary>
		///              // ColorEdit, ColorPicker: disable color square preview next to the inputs. (e.g. to show only the inputs)
		/// </summary>
		NoSmallPreview = 1<<4,
		/// <summary>
		///              // ColorEdit, ColorPicker: disable inputs sliders/text widgets (e.g. to show only the small preview color square).
		/// </summary>
		NoInputs = 1<<5,
		/// <summary>
		///              // ColorEdit, ColorPicker, ColorButton: disable tooltip when hovering the preview.
		/// </summary>
		NoTooltip = 1<<6,
		/// <summary>
		///              // ColorEdit, ColorPicker: disable display of inline text label (the label is still forwarded to the tooltip and picker).
		/// </summary>
		NoLabel = 1<<7,
		/// <summary>
		///              // ColorPicker: disable bigger color preview on right side of the picker, use small color square preview instead.
		/// </summary>
		NoSidePreview = 1<<8,
		/// <summary>
		///              // ColorEdit: disable drag and drop target. ColorButton: disable drag and drop source.
		/// </summary>
		NoDragDrop = 1<<9,
		/// <summary>
		///              // ColorButton: disable border (which is enforced by default)
		/// </summary>
		NoBorder = 1<<10,
		/// <summary>
		/// <para>User Options (right-click on widget to change some of them).</para>
		/// </summary>
		/// <summary>
		///              // ColorEdit, ColorPicker: show vertical alpha bar/gradient in picker.
		/// </summary>
		AlphaBar = 1<<16,
		/// <summary>
		///              // ColorEdit, ColorPicker, ColorButton: display preview as a transparent color over a checkerboard, instead of opaque.
		/// </summary>
		AlphaPreview = 1<<17,
		/// <summary>
		///              // ColorEdit, ColorPicker, ColorButton: display half opaque / half checkerboard, instead of opaque.
		/// </summary>
		AlphaPreviewHalf = 1<<18,
		/// <summary>
		///              // (WIP) ColorEdit: Currently only disable 0.0f..1.0f limits in RGBA edition (note: you probably want to use ImGuiColorEditFlags_Float flag as well).
		/// </summary>
		HDR = 1<<19,
		/// <summary>
		/// [Display]    // ColorEdit: override _display_ type among RGB/HSV/Hex. ColorPicker: select any combination using one or more of RGB/HSV/Hex.
		/// </summary>
		DisplayRGB = 1<<20,
		/// <summary>
		/// [Display]    // "
		/// </summary>
		DisplayHSV = 1<<21,
		/// <summary>
		/// [Display]    // "
		/// </summary>
		DisplayHex = 1<<22,
		/// <summary>
		/// [DataType]   // ColorEdit, ColorPicker, ColorButton: _display_ values formatted as 0..255.
		/// </summary>
		Uint8 = 1<<23,
		/// <summary>
		/// [DataType]   // ColorEdit, ColorPicker, ColorButton: _display_ values formatted as 0.0f..1.0f floats instead of 0..255 integers. No round-trip of value via integers.
		/// </summary>
		Float = 1<<24,
		/// <summary>
		/// [Picker]     // ColorPicker: bar for Hue, rectangle for Sat/Value.
		/// </summary>
		PickerHueBar = 1<<25,
		/// <summary>
		/// [Picker]     // ColorPicker: wheel for Hue, triangle for Sat/Value.
		/// </summary>
		PickerHueWheel = 1<<26,
		/// <summary>
		/// [Input]      // ColorEdit, ColorPicker: input and output data in RGB format.
		/// </summary>
		InputRGB = 1<<27,
		/// <summary>
		/// [Input]      // ColorEdit, ColorPicker: input and output data in HSV format.
		/// </summary>
		InputHSV = 1<<28,
		/// <summary>
		/// <para>Defaults Options. You can set application defaults using SetColorEditOptions(). The intent is that you probably don't want to</para>
		/// <para>override them in most of your calls. Let the user choose via the option menu and/or call SetColorEditOptions() once during startup.</para>
		/// </summary>
		DefaultOptions_ = Uint8 | DisplayRGB | InputRGB | PickerHueBar,
		/// <summary>
		/// <para>[Internal] Masks</para>
		/// </summary>
		DisplayMask_ = DisplayRGB | DisplayHSV | DisplayHex,
		DataTypeMask_ = Uint8 | Float,
		PickerMask_ = PickerHueWheel | PickerHueBar,
		InputMask_ = InputRGB | InputHSV,
	}

	/// <summary>
	/// <para>Flags for DragFloat(), DragInt(), SliderFloat(), SliderInt() etc.</para>
	/// <para>We use the same sets of flags for DragXXX() and SliderXXX() functions as the features are the same and it makes it easier to swap them.</para>
	/// <para>(Those are per-item flags. There is shared behavior flag too: ImGuiIO: io.ConfigDragClickToInputText)</para>
	/// </summary>
	[Flags]
	public enum ImGuiSliderFlags
	{
		None = 0,
		/// <summary>
		/// Make the widget logarithmic (linear otherwise). Consider using ImGuiSliderFlags_NoRoundToFormat with this if using a format-string with small amount of digits.
		/// </summary>
		Logarithmic = 1<<5,
		/// <summary>
		/// Disable rounding underlying value to match precision of the display format string (e.g. %.3f values are rounded to those 3 digits).
		/// </summary>
		NoRoundToFormat = 1<<6,
		/// <summary>
		/// Disable CTRL+Click or Enter key allowing to input text directly into the widget.
		/// </summary>
		NoInput = 1<<7,
		/// <summary>
		/// Enable wrapping around from max to min and from min to max. Only supported by DragXXX() functions for now.
		/// </summary>
		WrapAround = 1<<8,
		/// <summary>
		/// Clamp value to min/max bounds when input manually with CTRL+Click. By default CTRL+Click allows going out of bounds.
		/// </summary>
		ClampOnInput = 1<<9,
		/// <summary>
		/// Clamp even if min==max==0.0f. Otherwise due to legacy reason DragXXX functions don't clamp with those values. When your clamping limits are dynamic you almost always want to use it.
		/// </summary>
		ClampZeroRange = 1<<10,
		AlwaysClamp = ClampOnInput | ClampZeroRange,
		/// <summary>
		/// [Internal] We treat using those bits as being potentially a 'float power' argument from the previous API that has got miscast to this enum, and will trigger an assert if needed.
		/// </summary>
		InvalidMask_ = 0x7000000F,
	}

	/// <summary>
	/// <para>Identify a mouse button.</para>
	/// <para>Those values are guaranteed to be stable and we frequently use 0/1 directly. Named enums provided for convenience.</para>
	/// </summary>
	public enum ImGuiMouseButton
	{
		Left = 0,
		Right = 1,
		Middle = 2,
		COUNT = 5,
	}

	/// <summary>
	/// <para>Enumeration for GetMouseCursor()</para>
	/// <para>User code may request backend to display given cursor by calling SetMouseCursor(), which is why we have some cursors that are marked unused here</para>
	/// </summary>
	public enum ImGuiMouseCursor
	{
		None = -1,
		Arrow = 0,
		/// <summary>
		/// When hovering over InputText, etc.
		/// </summary>
		TextInput = 1,
		/// <summary>
		/// (Unused by Dear ImGui functions)
		/// </summary>
		ResizeAll = 2,
		/// <summary>
		/// When hovering over a horizontal border
		/// </summary>
		ResizeNS = 3,
		/// <summary>
		/// When hovering over a vertical border or a column
		/// </summary>
		ResizeEW = 4,
		/// <summary>
		/// When hovering over the bottom-left corner of a window
		/// </summary>
		ResizeNESW = 5,
		/// <summary>
		/// When hovering over the bottom-right corner of a window
		/// </summary>
		ResizeNWSE = 6,
		/// <summary>
		/// (Unused by Dear ImGui functions. Use for e.g. hyperlinks)
		/// </summary>
		Hand = 7,
		/// <summary>
		/// When hovering something with disallowed interaction. Usually a crossed circle.
		/// </summary>
		NotAllowed = 8,
		COUNT = 9,
	}

	/// <summary>
	/// <para>Enumeration for AddMouseSourceEvent() actual source of Mouse Input data.</para>
	/// <para>Historically we use "Mouse" terminology everywhere to indicate pointer data, e.g. MousePos, IsMousePressed(), io.AddMousePosEvent()</para>
	/// <para>But that "Mouse" data can come from different source which occasionally may be useful for application to know about.</para>
	/// <para>You can submit a change of pointer type using io.AddMouseSourceEvent().</para>
	/// </summary>
	/// <summary>
	/// Forward declared enum type ImGuiMouseSource
	/// </summary>
	public enum ImGuiMouseSource
	{
		/// <summary>
		/// Input is coming from an actual mouse.
		/// </summary>
		Mouse = 0,
		/// <summary>
		/// Input is coming from a touch screen (no hovering prior to initial press, less precise initial press aiming, dual-axis wheeling possible).
		/// </summary>
		TouchScreen = 1,
		/// <summary>
		/// Input is coming from a pressure/magnetic pen (often used in conjunction with high-sampling rates).
		/// </summary>
		Pen = 2,
		COUNT = 3,
	}

	/// <summary>
	/// <para>Enumeration for ImGui::SetNextWindow***(), SetWindow***(), SetNextItem***() functions</para>
	/// <para>Represent a condition.</para>
	/// <para>Important: Treat as a regular enum! Do NOT combine multiple values using binary operators! All the functions above treat 0 as a shortcut to ImGuiCond_Always.</para>
	/// </summary>
	public enum ImGuiCond
	{
		/// <summary>
		/// No condition (always set the variable), same as _Always
		/// </summary>
		None = 0,
		/// <summary>
		/// No condition (always set the variable), same as _None
		/// </summary>
		Always = 1<<0,
		/// <summary>
		/// Set the variable once per runtime session (only the first call will succeed)
		/// </summary>
		Once = 1<<1,
		/// <summary>
		/// Set the variable if the object/window has no persistently saved data (no entry in .ini file)
		/// </summary>
		FirstUseEver = 1<<2,
		/// <summary>
		/// Set the variable if the object/window is appearing after being hidden/inactive (or the first time)
		/// </summary>
		Appearing = 1<<3,
	}

	/// <summary>
	/// <para>Flags for ImGui::BeginTable()</para>
	/// <para>- Important! Sizing policies have complex and subtle side effects, much more so than you would expect.</para>
	/// <para>  Read comments/demos carefully + experiment with live demos to get acquainted with them.</para>
	/// <para>- The DEFAULT sizing policies are:</para>
	/// <para>   - Default to ImGuiTableFlags_SizingFixedFit    if ScrollX is on, or if host window has ImGuiWindowFlags_AlwaysAutoResize.</para>
	/// <para>   - Default to ImGuiTableFlags_SizingStretchSame if ScrollX is off.</para>
	/// <para>- When ScrollX is off:</para>
	/// <para>   - Table defaults to ImGuiTableFlags_SizingStretchSame -&gt; all Columns defaults to ImGuiTableColumnFlags_WidthStretch with same weight.</para>
	/// <para>   - Columns sizing policy allowed: Stretch (default), Fixed/Auto.</para>
	/// <para>   - Fixed Columns (if any) will generally obtain their requested width (unless the table cannot fit them all).</para>
	/// <para>   - Stretch Columns will share the remaining width according to their respective weight.</para>
	/// <para>   - Mixed Fixed/Stretch columns is possible but has various side-effects on resizing behaviors.</para>
	/// <para>     The typical use of mixing sizing policies is: any number of LEADING Fixed columns, followed by one or two TRAILING Stretch columns.</para>
	/// <para>     (this is because the visible order of columns have subtle but necessary effects on how they react to manual resizing).</para>
	/// <para>- When ScrollX is on:</para>
	/// <para>   - Table defaults to ImGuiTableFlags_SizingFixedFit -&gt; all Columns defaults to ImGuiTableColumnFlags_WidthFixed</para>
	/// <para>   - Columns sizing policy allowed: Fixed/Auto mostly.</para>
	/// <para>   - Fixed Columns can be enlarged as needed. Table will show a horizontal scrollbar if needed.</para>
	/// <para>   - When using auto-resizing (non-resizable) fixed columns, querying the content width to use item right-alignment e.g. SetNextItemWidth(-FLT_MIN) doesn't make sense, would create a feedback loop.</para>
	/// <para>   - Using Stretch columns OFTEN DOES NOT MAKE SENSE if ScrollX is on, UNLESS you have specified a value for 'inner_width' in BeginTable().</para>
	/// <para>     If you specify a value for 'inner_width' then effectively the scrolling space is known and Stretch or mixed Fixed/Stretch columns become meaningful again.</para>
	/// <para>- Read on documentation at the top of imgui_tables.cpp for details.</para>
	/// </summary>
	[Flags]
	public enum ImGuiTableFlags
	{
		/// <summary>
		/// <para>Features</para>
		/// </summary>
		None = 0,
		/// <summary>
		/// Enable resizing columns.
		/// </summary>
		Resizable = 1<<0,
		/// <summary>
		/// Enable reordering columns in header row (need calling TableSetupColumn() + TableHeadersRow() to display headers)
		/// </summary>
		Reorderable = 1<<1,
		/// <summary>
		/// Enable hiding/disabling columns in context menu.
		/// </summary>
		Hideable = 1<<2,
		/// <summary>
		/// Enable sorting. Call TableGetSortSpecs() to obtain sort specs. Also see ImGuiTableFlags_SortMulti and ImGuiTableFlags_SortTristate.
		/// </summary>
		Sortable = 1<<3,
		/// <summary>
		/// Disable persisting columns order, width and sort settings in the .ini file.
		/// </summary>
		NoSavedSettings = 1<<4,
		/// <summary>
		/// Right-click on columns body/contents will display table context menu. By default it is available in TableHeadersRow().
		/// </summary>
		ContextMenuInBody = 1<<5,
		/// <summary>
		/// <para>Decorations</para>
		/// </summary>
		/// <summary>
		/// Set each RowBg color with ImGuiCol_TableRowBg or ImGuiCol_TableRowBgAlt (equivalent of calling TableSetBgColor with ImGuiTableBgFlags_RowBg0 on each row manually)
		/// </summary>
		RowBg = 1<<6,
		/// <summary>
		/// Draw horizontal borders between rows.
		/// </summary>
		BordersInnerH = 1<<7,
		/// <summary>
		/// Draw horizontal borders at the top and bottom.
		/// </summary>
		BordersOuterH = 1<<8,
		/// <summary>
		/// Draw vertical borders between columns.
		/// </summary>
		BordersInnerV = 1<<9,
		/// <summary>
		/// Draw vertical borders on the left and right sides.
		/// </summary>
		BordersOuterV = 1<<10,
		/// <summary>
		/// Draw horizontal borders.
		/// </summary>
		BordersH = BordersInnerH | BordersOuterH,
		/// <summary>
		/// Draw vertical borders.
		/// </summary>
		BordersV = BordersInnerV | BordersOuterV,
		/// <summary>
		/// Draw inner borders.
		/// </summary>
		BordersInner = BordersInnerV | BordersInnerH,
		/// <summary>
		/// Draw outer borders.
		/// </summary>
		BordersOuter = BordersOuterV | BordersOuterH,
		/// <summary>
		/// Draw all borders.
		/// </summary>
		Borders = BordersInner | BordersOuter,
		/// <summary>
		/// [ALPHA] Disable vertical borders in columns Body (borders will always appear in Headers). -&gt; May move to style
		/// </summary>
		NoBordersInBody = 1<<11,
		/// <summary>
		/// [ALPHA] Disable vertical borders in columns Body until hovered for resize (borders will always appear in Headers). -&gt; May move to style
		/// </summary>
		NoBordersInBodyUntilResize = 1<<12,
		/// <summary>
		/// <para>Sizing Policy (read above for defaults)</para>
		/// </summary>
		/// <summary>
		/// Columns default to _WidthFixed or _WidthAuto (if resizable or not resizable), matching contents width.
		/// </summary>
		SizingFixedFit = 1<<13,
		/// <summary>
		/// Columns default to _WidthFixed or _WidthAuto (if resizable or not resizable), matching the maximum contents width of all columns. Implicitly enable ImGuiTableFlags_NoKeepColumnsVisible.
		/// </summary>
		SizingFixedSame = 2<<13,
		/// <summary>
		/// Columns default to _WidthStretch with default weights proportional to each columns contents widths.
		/// </summary>
		SizingStretchProp = 3<<13,
		/// <summary>
		/// Columns default to _WidthStretch with default weights all equal, unless overridden by TableSetupColumn().
		/// </summary>
		SizingStretchSame = 4<<13,
		/// <summary>
		/// <para>Sizing Extra Options</para>
		/// </summary>
		/// <summary>
		/// Make outer width auto-fit to columns, overriding outer_size.x value. Only available when ScrollX/ScrollY are disabled and Stretch columns are not used.
		/// </summary>
		NoHostExtendX = 1<<16,
		/// <summary>
		/// Make outer height stop exactly at outer_size.y (prevent auto-extending table past the limit). Only available when ScrollX/ScrollY are disabled. Data below the limit will be clipped and not visible.
		/// </summary>
		NoHostExtendY = 1<<17,
		/// <summary>
		/// Disable keeping column always minimally visible when ScrollX is off and table gets too small. Not recommended if columns are resizable.
		/// </summary>
		NoKeepColumnsVisible = 1<<18,
		/// <summary>
		/// Disable distributing remainder width to stretched columns (width allocation on a 100-wide table with 3 columns: Without this flag: 33,33,34. With this flag: 33,33,33). With larger number of columns, resizing will appear to be less smooth.
		/// </summary>
		PreciseWidths = 1<<19,
		/// <summary>
		/// <para>Clipping</para>
		/// </summary>
		/// <summary>
		/// Disable clipping rectangle for every individual columns (reduce draw command count, items will be able to overflow into other columns). Generally incompatible with TableSetupScrollFreeze().
		/// </summary>
		NoClip = 1<<20,
		/// <summary>
		/// <para>Padding</para>
		/// </summary>
		/// <summary>
		/// Default if BordersOuterV is on. Enable outermost padding. Generally desirable if you have headers.
		/// </summary>
		PadOuterX = 1<<21,
		/// <summary>
		/// Default if BordersOuterV is off. Disable outermost padding.
		/// </summary>
		NoPadOuterX = 1<<22,
		/// <summary>
		/// Disable inner padding between columns (double inner padding if BordersOuterV is on, single inner padding if BordersOuterV is off).
		/// </summary>
		NoPadInnerX = 1<<23,
		/// <summary>
		/// <para>Scrolling</para>
		/// </summary>
		/// <summary>
		/// Enable horizontal scrolling. Require 'outer_size' parameter of BeginTable() to specify the container size. Changes default sizing policy. Because this creates a child window, ScrollY is currently generally recommended when using ScrollX.
		/// </summary>
		ScrollX = 1<<24,
		/// <summary>
		/// Enable vertical scrolling. Require 'outer_size' parameter of BeginTable() to specify the container size.
		/// </summary>
		ScrollY = 1<<25,
		/// <summary>
		/// <para>Sorting</para>
		/// </summary>
		/// <summary>
		/// Hold shift when clicking headers to sort on multiple column. TableGetSortSpecs() may return specs where (SpecsCount &gt; 1).
		/// </summary>
		SortMulti = 1<<26,
		/// <summary>
		/// Allow no sorting, disable default sorting. TableGetSortSpecs() may return specs where (SpecsCount == 0).
		/// </summary>
		SortTristate = 1<<27,
		/// <summary>
		/// <para>Miscellaneous</para>
		/// </summary>
		/// <summary>
		/// Highlight column headers when hovered (may evolve into a fuller highlight)
		/// </summary>
		HighlightHoveredColumn = 1<<28,
		/// <summary>
		/// <para>[Internal] Combinations and masks</para>
		/// </summary>
		SizingMask_ = SizingFixedFit | SizingFixedSame | SizingStretchProp | SizingStretchSame,
	}

	/// <summary>
	/// <para>Flags for ImGui::TableSetupColumn()</para>
	/// </summary>
	[Flags]
	public enum ImGuiTableColumnFlags
	{
		/// <summary>
		/// <para>Input configuration flags</para>
		/// </summary>
		None = 0,
		/// <summary>
		/// Overriding/master disable flag: hide column, won't show in context menu (unlike calling TableSetColumnEnabled() which manipulates the user accessible state)
		/// </summary>
		Disabled = 1<<0,
		/// <summary>
		/// Default as a hidden/disabled column.
		/// </summary>
		DefaultHide = 1<<1,
		/// <summary>
		/// Default as a sorting column.
		/// </summary>
		DefaultSort = 1<<2,
		/// <summary>
		/// Column will stretch. Preferable with horizontal scrolling disabled (default if table sizing policy is _SizingStretchSame or _SizingStretchProp).
		/// </summary>
		WidthStretch = 1<<3,
		/// <summary>
		/// Column will not stretch. Preferable with horizontal scrolling enabled (default if table sizing policy is _SizingFixedFit and table is resizable).
		/// </summary>
		WidthFixed = 1<<4,
		/// <summary>
		/// Disable manual resizing.
		/// </summary>
		NoResize = 1<<5,
		/// <summary>
		/// Disable manual reordering this column, this will also prevent other columns from crossing over this column.
		/// </summary>
		NoReorder = 1<<6,
		/// <summary>
		/// Disable ability to hide/disable this column.
		/// </summary>
		NoHide = 1<<7,
		/// <summary>
		/// Disable clipping for this column (all NoClip columns will render in a same draw command).
		/// </summary>
		NoClip = 1<<8,
		/// <summary>
		/// Disable ability to sort on this field (even if ImGuiTableFlags_Sortable is set on the table).
		/// </summary>
		NoSort = 1<<9,
		/// <summary>
		/// Disable ability to sort in the ascending direction.
		/// </summary>
		NoSortAscending = 1<<10,
		/// <summary>
		/// Disable ability to sort in the descending direction.
		/// </summary>
		NoSortDescending = 1<<11,
		/// <summary>
		/// TableHeadersRow() will submit an empty label for this column. Convenient for some small columns. Name will still appear in context menu or in angled headers. You may append into this cell by calling TableSetColumnIndex() right after the TableHeadersRow() call.
		/// </summary>
		NoHeaderLabel = 1<<12,
		/// <summary>
		/// Disable header text width contribution to automatic column width.
		/// </summary>
		NoHeaderWidth = 1<<13,
		/// <summary>
		/// Make the initial sort direction Ascending when first sorting on this column (default).
		/// </summary>
		PreferSortAscending = 1<<14,
		/// <summary>
		/// Make the initial sort direction Descending when first sorting on this column.
		/// </summary>
		PreferSortDescending = 1<<15,
		/// <summary>
		/// Use current Indent value when entering cell (default for column 0).
		/// </summary>
		IndentEnable = 1<<16,
		/// <summary>
		/// Ignore current Indent value when entering cell (default for columns &gt; 0). Indentation changes _within_ the cell will still be honored.
		/// </summary>
		IndentDisable = 1<<17,
		/// <summary>
		/// TableHeadersRow() will submit an angled header row for this column. Note this will add an extra row.
		/// </summary>
		AngledHeader = 1<<18,
		/// <summary>
		/// <para>Output status flags, read-only via TableGetColumnFlags()</para>
		/// </summary>
		/// <summary>
		/// Status: is enabled == not hidden by user/api (referred to as "Hide" in _DefaultHide and _NoHide) flags.
		/// </summary>
		IsEnabled = 1<<24,
		/// <summary>
		/// Status: is visible == is enabled AND not clipped by scrolling.
		/// </summary>
		IsVisible = 1<<25,
		/// <summary>
		/// Status: is currently part of the sort specs
		/// </summary>
		IsSorted = 1<<26,
		/// <summary>
		/// Status: is hovered by mouse
		/// </summary>
		IsHovered = 1<<27,
		/// <summary>
		/// <para>[Internal] Combinations and masks</para>
		/// </summary>
		WidthMask_ = WidthStretch | WidthFixed,
		IndentMask_ = IndentEnable | IndentDisable,
		StatusMask_ = IsEnabled | IsVisible | IsSorted | IsHovered,
		/// <summary>
		/// [Internal] Disable user resizing this column directly (it may however we resized indirectly from its left edge)
		/// </summary>
		NoDirectResize_ = 1<<30,
	}

	/// <summary>
	/// <para>Flags for ImGui::TableNextRow()</para>
	/// </summary>
	[Flags]
	public enum ImGuiTableRowFlags
	{
		None = 0,
		/// <summary>
		/// Identify header row (set default background color + width of its contents accounted differently for auto column width)
		/// </summary>
		Headers = 1<<0,
	}

	/// <summary>
	/// <para>Enum for ImGui::TableSetBgColor()</para>
	/// <para>Background colors are rendering in 3 layers:</para>
	/// <para> - Layer 0: draw with RowBg0 color if set, otherwise draw with ColumnBg0 if set.</para>
	/// <para> - Layer 1: draw with RowBg1 color if set, otherwise draw with ColumnBg1 if set.</para>
	/// <para> - Layer 2: draw with CellBg color if set.</para>
	/// <para>The purpose of the two row/columns layers is to let you decide if a background color change should override or blend with the existing color.</para>
	/// <para>When using ImGuiTableFlags_RowBg on the table, each row has the RowBg0 color automatically set for odd/even rows.</para>
	/// <para>If you set the color of RowBg0 target, your color will override the existing RowBg0 color.</para>
	/// <para>If you set the color of RowBg1 or ColumnBg1 target, your color will blend over the RowBg0 color.</para>
	/// </summary>
	public enum ImGuiTableBgTarget
	{
		None = 0,
		/// <summary>
		/// Set row background color 0 (generally used for background, automatically set when ImGuiTableFlags_RowBg is used)
		/// </summary>
		RowBg0 = 1,
		/// <summary>
		/// Set row background color 1 (generally used for selection marking)
		/// </summary>
		RowBg1 = 2,
		/// <summary>
		/// Set cell background color (top-most color)
		/// </summary>
		CellBg = 3,
	}

	/// <summary>
	/// <para>Flags for BeginMultiSelect()</para>
	/// </summary>
	[Flags]
	public enum ImGuiMultiSelectFlags
	{
		None = 0,
		/// <summary>
		/// Disable selecting more than one item. This is available to allow single-selection code to share same code/logic if desired. It essentially disables the main purpose of BeginMultiSelect() tho!
		/// </summary>
		SingleSelect = 1<<0,
		/// <summary>
		/// Disable CTRL+A shortcut to select all.
		/// </summary>
		NoSelectAll = 1<<1,
		/// <summary>
		/// Disable Shift+selection mouse/keyboard support (useful for unordered 2D selection). With BoxSelect is also ensure contiguous SetRange requests are not combined into one. This allows not handling interpolation in SetRange requests.
		/// </summary>
		NoRangeSelect = 1<<2,
		/// <summary>
		/// Disable selecting items when navigating (useful for e.g. supporting range-select in a list of checkboxes).
		/// </summary>
		NoAutoSelect = 1<<3,
		/// <summary>
		/// Disable clearing selection when navigating or selecting another one (generally used with ImGuiMultiSelectFlags_NoAutoSelect. useful for e.g. supporting range-select in a list of checkboxes).
		/// </summary>
		NoAutoClear = 1<<4,
		/// <summary>
		/// Disable clearing selection when clicking/selecting an already selected item.
		/// </summary>
		NoAutoClearOnReselect = 1<<5,
		/// <summary>
		/// Enable box-selection with same width and same x pos items (e.g. full row Selectable()). Box-selection works better with little bit of spacing between items hit-box in order to be able to aim at empty space.
		/// </summary>
		BoxSelect1d = 1<<6,
		/// <summary>
		/// Enable box-selection with varying width or varying x pos items support (e.g. different width labels, or 2D layout/grid). This is slower: alters clipping logic so that e.g. horizontal movements will update selection of normally clipped items.
		/// </summary>
		BoxSelect2d = 1<<7,
		/// <summary>
		/// Disable scrolling when box-selecting near edges of scope.
		/// </summary>
		BoxSelectNoScroll = 1<<8,
		/// <summary>
		/// Clear selection when pressing Escape while scope is focused.
		/// </summary>
		ClearOnEscape = 1<<9,
		/// <summary>
		/// Clear selection when clicking on empty location within scope.
		/// </summary>
		ClearOnClickVoid = 1<<10,
		/// <summary>
		/// Scope for _BoxSelect and _ClearOnClickVoid is whole window (Default). Use if BeginMultiSelect() covers a whole window or used a single time in same window.
		/// </summary>
		ScopeWindow = 1<<11,
		/// <summary>
		/// Scope for _BoxSelect and _ClearOnClickVoid is rectangle encompassing BeginMultiSelect()/EndMultiSelect(). Use if BeginMultiSelect() is called multiple times in same window.
		/// </summary>
		ScopeRect = 1<<12,
		/// <summary>
		/// Apply selection on mouse down when clicking on unselected item. (Default)
		/// </summary>
		SelectOnClick = 1<<13,
		/// <summary>
		/// Apply selection on mouse release when clicking an unselected item. Allow dragging an unselected item without altering selection.
		/// </summary>
		SelectOnClickRelease = 1<<14,
		/// <summary>
		/// <para>//ImGuiMultiSelectFlags_RangeSelect2d       = 1 &lt;&lt; 15,  // Shift+Selection uses 2d geometry instead of linear sequence, so possible to use Shift+up/down to select vertically in grid. Analogous to what BoxSelect does.</para>
		/// </summary>
		/// <summary>
		/// [Temporary] Enable navigation wrapping on X axis. Provided as a convenience because we don't have a design for the general Nav API for this yet. When the more general feature be public we may obsolete this flag in favor of new one.
		/// </summary>
		NavWrapX = 1<<16,
	}

	/// <summary>
	/// <para>Selection request type</para>
	/// </summary>
	public enum ImGuiSelectionRequestType
	{
		None = 0,
		/// <summary>
		/// Request app to clear selection (if Selected==false) or select all items (if Selected==true). We cannot set RangeFirstItem/RangeLastItem as its contents is entirely up to user (not necessarily an index)
		/// </summary>
		SetAll = 1,
		/// <summary>
		/// Request app to select/unselect [RangeFirstItem..RangeLastItem] items (inclusive) based on value of Selected. Only EndMultiSelect() request this, app code can read after BeginMultiSelect() and it will always be false.
		/// </summary>
		SetRange = 2,
	}

	/// <summary>
	/// <para>Flags for ImDrawList functions</para>
	/// <para>(Legacy: bit 0 must always correspond to ImDrawFlags_Closed to be backward compatible with old API using a bool. Bits 1..3 must be unused)</para>
	/// </summary>
	[Flags]
	public enum ImDrawFlags
	{
		None = 0,
		/// <summary>
		/// PathStroke(), AddPolyline(): specify that shape should be closed (Important: this is always == 1 for legacy reason)
		/// </summary>
		Closed = 1<<0,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding top-left corner only (when rounding &gt; 0.0f, we default to all corners). Was 0x01.
		/// </summary>
		RoundCornersTopLeft = 1<<4,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding top-right corner only (when rounding &gt; 0.0f, we default to all corners). Was 0x02.
		/// </summary>
		RoundCornersTopRight = 1<<5,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding bottom-left corner only (when rounding &gt; 0.0f, we default to all corners). Was 0x04.
		/// </summary>
		RoundCornersBottomLeft = 1<<6,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): enable rounding bottom-right corner only (when rounding &gt; 0.0f, we default to all corners). Wax 0x08.
		/// </summary>
		RoundCornersBottomRight = 1<<7,
		/// <summary>
		/// AddRect(), AddRectFilled(), PathRect(): disable rounding on all corners (when rounding &gt; 0.0f). This is NOT zero, NOT an implicit flag!
		/// </summary>
		RoundCornersNone = 1<<8,
		RoundCornersTop = RoundCornersTopLeft | RoundCornersTopRight,
		RoundCornersBottom = RoundCornersBottomLeft | RoundCornersBottomRight,
		RoundCornersLeft = RoundCornersBottomLeft | RoundCornersTopLeft,
		RoundCornersRight = RoundCornersBottomRight | RoundCornersTopRight,
		RoundCornersAll = RoundCornersTopLeft | RoundCornersTopRight | RoundCornersBottomLeft | RoundCornersBottomRight,
		/// <summary>
		/// Default to ALL corners if none of the _RoundCornersXX flags are specified.
		/// </summary>
		RoundCornersDefault_ = RoundCornersAll,
		RoundCornersMask_ = RoundCornersAll | RoundCornersNone,
	}

	/// <summary>
	/// <para>Flags for ImDrawList instance. Those are set automatically by ImGui:: functions from ImGuiIO settings, and generally not manipulated directly.</para>
	/// <para>It is however possible to temporarily alter flags between calls to ImDrawList:: functions.</para>
	/// </summary>
	[Flags]
	public enum ImDrawListFlags
	{
		None = 0,
		/// <summary>
		/// Enable anti-aliased lines/borders (*2 the number of triangles for 1.0f wide line or lines thin enough to be drawn using textures, otherwise *3 the number of triangles)
		/// </summary>
		AntiAliasedLines = 1<<0,
		/// <summary>
		/// Enable anti-aliased lines/borders using textures when possible. Require backend to render with bilinear filtering (NOT point/nearest filtering).
		/// </summary>
		AntiAliasedLinesUseTex = 1<<1,
		/// <summary>
		/// Enable anti-aliased edge around filled shapes (rounded rectangles, circles).
		/// </summary>
		AntiAliasedFill = 1<<2,
		/// <summary>
		/// Can emit 'VtxOffset &gt; 0' to allow large meshes. Set when 'ImGuiBackendFlags_RendererHasVtxOffset' is enabled.
		/// </summary>
		AllowVtxOffset = 1<<3,
	}

	/// <summary>
	/// <para>Flags for ImFontAtlas build</para>
	/// </summary>
	[Flags]
	public enum ImFontAtlasFlags
	{
		None = 0,
		/// <summary>
		/// Don't round the height to next power of two
		/// </summary>
		NoPowerOfTwoHeight = 1<<0,
		/// <summary>
		/// Don't build software mouse cursors into the atlas (save a little texture memory)
		/// </summary>
		NoMouseCursors = 1<<1,
		/// <summary>
		/// Don't build thick line textures into the atlas (save a little texture memory, allow support for point/nearest filtering). The AntiAliasedLinesUseTex features uses them, otherwise they will be rendered using polygons (more expensive for CPU/GPU).
		/// </summary>
		NoBakedLines = 1<<2,
	}

	/// <summary>
	/// <para>Flags stored in ImGuiViewport::Flags, giving indications to the platform backends.</para>
	/// </summary>
	[Flags]
	public enum ImGuiViewportFlags
	{
		None = 0,
		/// <summary>
		/// Represent a Platform Window
		/// </summary>
		IsPlatformWindow = 1<<0,
		/// <summary>
		/// Represent a Platform Monitor (unused yet)
		/// </summary>
		IsPlatformMonitor = 1<<1,
		/// <summary>
		/// Platform Window: Is created/managed by the user application? (rather than our backend)
		/// </summary>
		OwnedByApp = 1<<2,
		/// <summary>
		/// Platform Window: Disable platform decorations: title bar, borders, etc. (generally set all windows, but if ImGuiConfigFlags_ViewportsDecoration is set we only set this on popups/tooltips)
		/// </summary>
		NoDecoration = 1<<3,
		/// <summary>
		/// Platform Window: Disable platform task bar icon (generally set on popups/tooltips, or all windows if ImGuiConfigFlags_ViewportsNoTaskBarIcon is set)
		/// </summary>
		NoTaskBarIcon = 1<<4,
		/// <summary>
		/// Platform Window: Don't take focus when created.
		/// </summary>
		NoFocusOnAppearing = 1<<5,
		/// <summary>
		/// Platform Window: Don't take focus when clicked on.
		/// </summary>
		NoFocusOnClick = 1<<6,
		/// <summary>
		/// Platform Window: Make mouse pass through so we can drag this window while peaking behind it.
		/// </summary>
		NoInputs = 1<<7,
		/// <summary>
		/// Platform Window: Renderer doesn't need to clear the framebuffer ahead (because we will fill it entirely).
		/// </summary>
		NoRendererClear = 1<<8,
		/// <summary>
		/// Platform Window: Avoid merging this window into another host window. This can only be set via ImGuiWindowClass viewport flags override (because we need to now ahead if we are going to create a viewport in the first place!).
		/// </summary>
		NoAutoMerge = 1<<9,
		/// <summary>
		/// Platform Window: Display on top (for tooltips only).
		/// </summary>
		TopMost = 1<<10,
		/// <summary>
		/// Viewport can host multiple imgui windows (secondary viewports are associated to a single window). // FIXME: In practice there's still probably code making the assumption that this is always and only on the MainViewport. Will fix once we add support for "no main viewport".
		/// </summary>
		CanHostOtherWindows = 1<<11,
		/// <summary>
		/// <para>Output status flags (from Platform)</para>
		/// </summary>
		/// <summary>
		/// Platform Window: Window is minimized, can skip render. When minimized we tend to avoid using the viewport pos/size for clipping window or testing if they are contained in the viewport.
		/// </summary>
		IsMinimized = 1<<12,
		/// <summary>
		/// Platform Window: Window is focused (last call to Platform_GetWindowFocus() returned true)
		/// </summary>
		IsFocused = 1<<13,
	}

}
