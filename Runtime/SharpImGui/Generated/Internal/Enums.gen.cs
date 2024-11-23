using System;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Extend ImGuiDataType_</para>
	/// </summary>
	public enum ImGuiDataType
	{
		// ImGuiDataType values

		S8 = 0,
		U8 = 1,
		S16 = 2,
		U16 = 3,
		S32 = 4,
		U32 = 5,
		S64 = 6,
		U64 = 7,
		Float = 8,
		Double = 9,
		Bool = 10,
		COUNT = 11,

		// Extended ImGuiDataType values

		String = COUNT+1,
		Pointer = 13,
		ID = 14,
	}

	/// <summary>
	/// <para>Extend ImGuiItemFlags</para>
	/// <para>- input: PushItemFlag() manipulates g.CurrentItemFlags, g.NextItemData.ItemFlags, ItemAdd() calls may add extra flags too.</para>
	/// <para>- output: stored in g.LastItemData.ItemFlags</para>
	/// </summary>
	public enum ImGuiItemFlags
	{
		// ImGuiItemFlags values

		None = 0,
		NoTabStop = 1<<0,
		NoNav = 1<<1,
		NoNavDefaultFocus = 1<<2,
		ButtonRepeat = 1<<3,
		AutoClosePopups = 1<<4,
		AllowDuplicateId = 1<<5,

		// Extended ImGuiItemFlags values

		/// <summary>
		/// <para>Controlled by user</para>
		/// </summary>
		/// <summary>
		/// false     // Disable interactions (DOES NOT affect visuals. DO NOT mix direct use of this with BeginDisabled(). See BeginDisabled()/EndDisabled() for full disable feature, and github #211).
		/// </summary>
		Disabled = 1<<10,
		/// <summary>
		/// false     // [ALPHA] Allow hovering interactions but underlying value is not changed.
		/// </summary>
		ReadOnly = 1<<11,
		/// <summary>
		/// false     // [BETA] Represent a mixed/indeterminate value, generally multi-selection where values differ. Currently only supported by Checkbox() (later should support all sorts of widgets)
		/// </summary>
		MixedValue = 1<<12,
		/// <summary>
		/// false     // Disable hoverable check in ItemHoverable()
		/// </summary>
		NoWindowHoverableCheck = 1<<13,
		/// <summary>
		/// false     // Allow being overlapped by another widget. Not-hovered to Hovered transition deferred by a frame.
		/// </summary>
		AllowOverlap = 1<<14,
		/// <summary>
		/// false     // Nav keyboard/gamepad mode doesn't disable hover highlight (behave as if NavHighlightItemUnderNav==false).
		/// </summary>
		NoNavDisableMouseHover = 1<<15,
		/// <summary>
		/// false     // Skip calling MarkItemEdited()
		/// </summary>
		NoMarkEdited = 1<<16,
		/// <summary>
		/// <para>Controlled by widget code</para>
		/// </summary>
		/// <summary>
		/// false     // [WIP] Auto-activate input mode when tab focused. Currently only used and supported by a few items before it becomes a generic feature.
		/// </summary>
		Inputable = 1<<20,
		/// <summary>
		/// false     // Set by SetNextItemSelectionUserData()
		/// </summary>
		HasSelectionUserData = 1<<21,
		/// <summary>
		/// false     // Set by SetNextItemSelectionUserData()
		/// </summary>
		IsMultiSelect = 1<<22,
		/// <summary>
		/// Please don't change, use PushItemFlag() instead.
		/// </summary>
		Default_ = AutoClosePopups,
	}

	/// <summary>
	/// <para>Status flags for an already submitted item</para>
	/// <para>- output: stored in g.LastItemData.StatusFlags</para>
	/// </summary>
	[Flags]
	public enum ImGuiItemStatusFlags
	{
		None = 0,
		/// <summary>
		/// Mouse position is within item rectangle (does NOT mean that the window is in correct z-order and can be hovered!, this is only one part of the most-common IsItemHovered test)
		/// </summary>
		HoveredRect = 1<<0,
		/// <summary>
		/// g.LastItemData.DisplayRect is valid
		/// </summary>
		HasDisplayRect = 1<<1,
		/// <summary>
		/// Value exposed by item was edited in the current frame (should match the bool return value of most widgets)
		/// </summary>
		Edited = 1<<2,
		/// <summary>
		/// Set when Selectable(), TreeNode() reports toggling a selection. We can't report "Selected", only state changes, in order to easily handle clipping with less issues.
		/// </summary>
		ToggledSelection = 1<<3,
		/// <summary>
		/// Set when TreeNode() reports toggling their open state.
		/// </summary>
		ToggledOpen = 1<<4,
		/// <summary>
		/// Set if the widget/group is able to provide data for the ImGuiItemStatusFlags_Deactivated flag.
		/// </summary>
		HasDeactivated = 1<<5,
		/// <summary>
		/// Only valid if ImGuiItemStatusFlags_HasDeactivated is set.
		/// </summary>
		Deactivated = 1<<6,
		/// <summary>
		/// Override the HoveredWindow test to allow cross-window hover testing.
		/// </summary>
		HoveredWindow = 1<<7,
		/// <summary>
		/// [WIP] Set when item is overlapping the current clipping rectangle (Used internally. Please don't use yet: API/system will change as we refactor Itemadd()).
		/// </summary>
		Visible = 1<<8,
		/// <summary>
		/// g.LastItemData.ClipRect is valid.
		/// </summary>
		HasClipRect = 1<<9,
		/// <summary>
		/// g.LastItemData.Shortcut valid. Set by SetNextItemShortcut() -&gt; ItemAdd().
		/// </summary>
		HasShortcut = 1<<10,
	}

	/// <summary>
	/// <para>Extend ImGuiHoveredFlags_</para>
	/// </summary>
	public enum ImGuiHoveredFlags
	{
		// ImGuiHoveredFlags values

		None = 0,
		ChildWindows = 1<<0,
		RootWindow = 1<<1,
		AnyWindow = 1<<2,
		NoPopupHierarchy = 1<<3,
		DockHierarchy = 1<<4,
		AllowWhenBlockedByPopup = 1<<5,
		AllowWhenBlockedByActiveItem = 1<<7,
		AllowWhenOverlappedByItem = 1<<8,
		AllowWhenOverlappedByWindow = 1<<9,
		AllowWhenDisabled = 1<<10,
		NoNavOverride = 1<<11,
		AllowWhenOverlapped = AllowWhenOverlappedByItem | AllowWhenOverlappedByWindow,
		RectOnly = AllowWhenBlockedByPopup | AllowWhenBlockedByActiveItem | AllowWhenOverlapped,
		RootAndChildWindows = RootWindow | ChildWindows,
		ForTooltip = 1<<12,
		Stationary = 1<<13,
		DelayNone = 1<<14,
		DelayShort = 1<<15,
		DelayNormal = 1<<16,
		NoSharedDelay = 1<<17,

		// Extended ImGuiHoveredFlags values

		DelayMask_ = DelayNone | DelayShort | DelayNormal | NoSharedDelay,
		AllowedMaskForIsWindowHovered = ChildWindows | RootWindow | AnyWindow | NoPopupHierarchy | DockHierarchy | AllowWhenBlockedByPopup | AllowWhenBlockedByActiveItem | ForTooltip | Stationary,
		AllowedMaskForIsItemHovered = AllowWhenBlockedByPopup | AllowWhenBlockedByActiveItem | AllowWhenOverlapped | AllowWhenDisabled | NoNavOverride | ForTooltip | Stationary | DelayMask_,
	}

	/// <summary>
	/// <para>Extend ImGuiInputTextFlags_</para>
	/// </summary>
	public enum ImGuiInputTextFlags
	{
		// ImGuiInputTextFlags values

		None = 0,
		CharsDecimal = 1<<0,
		CharsHexadecimal = 1<<1,
		CharsScientific = 1<<2,
		CharsUppercase = 1<<3,
		CharsNoBlank = 1<<4,
		AllowTabInput = 1<<5,
		EnterReturnsTrue = 1<<6,
		EscapeClearsAll = 1<<7,
		CtrlEnterForNewLine = 1<<8,
		ReadOnly = 1<<9,
		Password = 1<<10,
		AlwaysOverwrite = 1<<11,
		AutoSelectAll = 1<<12,
		ParseEmptyRefVal = 1<<13,
		DisplayEmptyRefVal = 1<<14,
		NoHorizontalScroll = 1<<15,
		NoUndoRedo = 1<<16,
		CallbackCompletion = 1<<17,
		CallbackHistory = 1<<18,
		CallbackAlways = 1<<19,
		CallbackCharFilter = 1<<20,
		CallbackResize = 1<<21,
		CallbackEdit = 1<<22,

		// Extended ImGuiInputTextFlags values

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// For internal use by InputTextMultiline()
		/// </summary>
		Multiline = 1<<26,
		/// <summary>
		/// For internal use by TempInputText(), will skip calling ItemAdd(). Require bounding-box to strictly match.
		/// </summary>
		MergedItem = 1<<27,
		/// <summary>
		/// For internal use by InputScalar() and TempInputScalar()
		/// </summary>
		LocalizeDecimalPoint = 1<<28,
	}

	/// <summary>
	/// <para>Extend ImGuiButtonFlags_</para>
	/// </summary>
	public enum ImGuiButtonFlags
	{
		// ImGuiButtonFlags values

		None = 0,
		MouseButtonLeft = 1<<0,
		MouseButtonRight = 1<<1,
		MouseButtonMiddle = 1<<2,
		MouseButtonMask_ = MouseButtonLeft | MouseButtonRight | MouseButtonMiddle,
		EnableNav = 1<<3,

		// Extended ImGuiButtonFlags values

		/// <summary>
		/// return true on click (mouse down event)
		/// </summary>
		PressedOnClick = 1<<4,
		/// <summary>
		/// [Default] return true on click + release on same item &lt;-- this is what the majority of Button are using
		/// </summary>
		PressedOnClickRelease = 1<<5,
		/// <summary>
		/// return true on click + release even if the release event is not done while hovering the item
		/// </summary>
		PressedOnClickReleaseAnywhere = 1<<6,
		/// <summary>
		/// return true on release (default requires click+release)
		/// </summary>
		PressedOnRelease = 1<<7,
		/// <summary>
		/// return true on double-click (default requires click+release)
		/// </summary>
		PressedOnDoubleClick = 1<<8,
		/// <summary>
		/// return true when held into while we are drag and dropping another item (used by e.g. tree nodes, collapsing headers)
		/// </summary>
		PressedOnDragDropHold = 1<<9,
		/// <summary>
		/// <para>//ImGuiButtonFlags_Repeat               = 1 &lt;&lt; 10,  // hold to repeat</para>
		/// </summary>
		/// <summary>
		/// allow interactions even if a child window is overlapping
		/// </summary>
		FlattenChildren = 1<<11,
		/// <summary>
		/// require previous frame HoveredId to either match id or be null before being usable.
		/// </summary>
		AllowOverlap = 1<<12,
		/// <summary>
		/// <para>//ImGuiButtonFlags_DontClosePopups      = 1 &lt;&lt; 13,  // disable automatically closing parent popup on press</para>
		/// <para>//ImGuiButtonFlags_Disabled             = 1 &lt;&lt; 14,  // disable interactions -&gt; use BeginDisabled() or ImGuiItemFlags_Disabled</para>
		/// </summary>
		/// <summary>
		/// vertically align button to match text baseline - ButtonEx() only // FIXME: Should be removed and handled by SmallButton(), not possible currently because of DC.CursorPosPrevLine
		/// </summary>
		AlignTextBaseLine = 1<<15,
		/// <summary>
		/// disable mouse interaction if a key modifier is held
		/// </summary>
		NoKeyModsAllowed = 1<<16,
		/// <summary>
		/// don't set ActiveId while holding the mouse (ImGuiButtonFlags_PressedOnClick only)
		/// </summary>
		NoHoldingActiveId = 1<<17,
		/// <summary>
		/// don't override navigation focus when activated (FIXME: this is essentially used every time an item uses ImGuiItemFlags_NoNav, but because legacy specs don't requires LastItemData to be set ButtonBehavior(), we can't poll g.LastItemData.ItemFlags)
		/// </summary>
		NoNavFocus = 1<<18,
		/// <summary>
		/// don't report as hovered when nav focus is on this item
		/// </summary>
		NoHoveredOnFocus = 1<<19,
		/// <summary>
		/// don't set key/input owner on the initial click (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)
		/// </summary>
		NoSetKeyOwner = 1<<20,
		/// <summary>
		/// don't test key/input owner when polling the key (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)
		/// </summary>
		NoTestKeyOwner = 1<<21,
		PressedOnMask_ = PressedOnClick | PressedOnClickRelease | PressedOnClickReleaseAnywhere | PressedOnRelease | PressedOnDoubleClick | PressedOnDragDropHold,
		PressedOnDefault_ = PressedOnClickRelease,
	}

	/// <summary>
	/// <para>Extend ImGuiComboFlags_</para>
	/// </summary>
	public enum ImGuiComboFlags
	{
		// ImGuiComboFlags values

		None = 0,
		PopupAlignLeft = 1<<0,
		HeightSmall = 1<<1,
		HeightRegular = 1<<2,
		HeightLarge = 1<<3,
		HeightLargest = 1<<4,
		NoArrowButton = 1<<5,
		NoPreview = 1<<6,
		WidthFitPreview = 1<<7,
		HeightMask_ = HeightSmall | HeightRegular | HeightLarge | HeightLargest,

		// Extended ImGuiComboFlags values

		/// <summary>
		/// enable BeginComboPreview()
		/// </summary>
		CustomPreview = 1<<20,
	}

	/// <summary>
	/// <para>Extend ImGuiSliderFlags_</para>
	/// </summary>
	public enum ImGuiSliderFlags
	{
		// ImGuiSliderFlags values

		None = 0,
		Logarithmic = 1<<5,
		NoRoundToFormat = 1<<6,
		NoInput = 1<<7,
		WrapAround = 1<<8,
		ClampOnInput = 1<<9,
		ClampZeroRange = 1<<10,
		AlwaysClamp = ClampOnInput | ClampZeroRange,
		InvalidMask_ = 0x7000000F,

		// Extended ImGuiSliderFlags values

		/// <summary>
		/// Should this slider be orientated vertically?
		/// </summary>
		Vertical = 1<<20,
		/// <summary>
		/// Consider using g.NextItemData.ItemFlags |= ImGuiItemFlags_ReadOnly instead.
		/// </summary>
		ReadOnly = 1<<21,
	}

	/// <summary>
	/// <para>Extend ImGuiSelectableFlags_</para>
	/// </summary>
	public enum ImGuiSelectableFlags
	{
		// ImGuiSelectableFlags values

		None = 0,
		NoAutoClosePopups = 1<<0,
		SpanAllColumns = 1<<1,
		AllowDoubleClick = 1<<2,
		Disabled = 1<<3,
		AllowOverlap = 1<<4,
		Highlight = 1<<5,

		// Extended ImGuiSelectableFlags values

		/// <summary>
		/// <para>NB: need to be in sync with last value of ImGuiSelectableFlags_</para>
		/// </summary>
		NoHoldingActiveID = 1<<20,
		/// <summary>
		/// (WIP) Auto-select when moved into. This is not exposed in public API as to handle multi-select and modifiers we will need user to explicitly control focus scope. May be replaced with a BeginSelection() API.
		/// </summary>
		SelectOnNav = 1<<21,
		/// <summary>
		/// Override button behavior to react on Click (default is Click+Release)
		/// </summary>
		SelectOnClick = 1<<22,
		/// <summary>
		/// Override button behavior to react on Release (default is Click+Release)
		/// </summary>
		SelectOnRelease = 1<<23,
		/// <summary>
		/// Span all avail width even if we declared less for layout purpose. FIXME: We may be able to remove this (added in 6251d379, 2bcafc86 for menus)
		/// </summary>
		SpanAvailWidth = 1<<24,
		/// <summary>
		/// Set Nav/Focus ID on mouse hover (used by MenuItem)
		/// </summary>
		SetNavIdOnHover = 1<<25,
		/// <summary>
		/// Disable padding each side with ItemSpacing * 0.5f
		/// </summary>
		NoPadWithHalfSpacing = 1<<26,
		/// <summary>
		/// Don't set key/input owner on the initial click (note: mouse buttons are keys! often, the key in question will be ImGuiKey_MouseLeft!)
		/// </summary>
		NoSetKeyOwner = 1<<27,
	}

	/// <summary>
	/// <para>Extend ImGuiTreeNodeFlags_</para>
	/// </summary>
	public enum ImGuiTreeNodeFlags
	{
		// ImGuiTreeNodeFlags values

		None = 0,
		Selected = 1<<0,
		Framed = 1<<1,
		AllowOverlap = 1<<2,
		NoTreePushOnOpen = 1<<3,
		NoAutoOpenOnLog = 1<<4,
		DefaultOpen = 1<<5,
		OpenOnDoubleClick = 1<<6,
		OpenOnArrow = 1<<7,
		Leaf = 1<<8,
		Bullet = 1<<9,
		FramePadding = 1<<10,
		SpanAvailWidth = 1<<11,
		SpanFullWidth = 1<<12,
		SpanTextWidth = 1<<13,
		SpanAllColumns = 1<<14,
		NavLeftJumpsBackHere = 1<<15,
		CollapsingHeader = Framed | NoTreePushOnOpen | NoAutoOpenOnLog,

		// Extended ImGuiTreeNodeFlags values

		/// <summary>
		/// FIXME-WIP: Hard-coded for CollapsingHeader()
		/// </summary>
		ClipLabelForTrailingButton = 1<<28,
		/// <summary>
		/// FIXME-WIP: Turn Down arrow into an Up arrow, for reversed trees (#6517)
		/// </summary>
		UpsideDownArrow = 1<<29,
		OpenOnMask_ = OpenOnDoubleClick | OpenOnArrow,
	}

	[Flags]
	public enum ImGuiSeparatorFlags
	{
		None = 0,
		/// <summary>
		/// Axis default to current layout type, so generally Horizontal unless e.g. in a menu bar
		/// </summary>
		Horizontal = 1<<0,
		Vertical = 1<<1,
		/// <summary>
		/// Make separator cover all columns of a legacy Columns() set.
		/// </summary>
		SpanAllColumns = 1<<2,
	}

	/// <summary>
	/// <para>Flags for FocusWindow(). This is not called ImGuiFocusFlags to avoid confusion with public-facing ImGuiFocusedFlags.</para>
	/// <para>FIXME: Once we finishing replacing more uses of GetTopMostPopupModal()+IsWindowWithinBeginStackOf()</para>
	/// <para>and FindBlockingModal() with this, we may want to change the flag to be opt-out instead of opt-in.</para>
	/// </summary>
	[Flags]
	public enum ImGuiFocusRequestFlags
	{
		None = 0,
		/// <summary>
		/// Find last focused child (if any) and focus it instead.
		/// </summary>
		RestoreFocusedChild = 1<<0,
		/// <summary>
		/// Do not set focus if the window is below a modal.
		/// </summary>
		UnlessBelowModal = 1<<1,
	}

	[Flags]
	public enum ImGuiTextFlags
	{
		None = 0,
		NoWidthForLargeClippedText = 1<<0,
	}

	[Flags]
	public enum ImGuiTooltipFlags
	{
		None = 0,
		/// <summary>
		/// Clear/ignore previously submitted tooltip (defaults to append)
		/// </summary>
		OverridePrevious = 1<<1,
	}

	/// <summary>
	/// <para>FIXME: this is in development, not exposed/functional as a generic feature yet.</para>
	/// <para>Horizontal/Vertical enums are fixed to 0/1 so they may be used to index ImVec2</para>
	/// </summary>
	public enum ImGuiLayoutType
	{
		Horizontal = 0,
		Vertical = 1,
	}

	/// <summary>
	/// <para>Flags for LogBegin() text capturing function</para>
	/// </summary>
	[Flags]
	public enum ImGuiLogFlags
	{
		None = 0,
		OutputTTY = 1<<0,
		OutputFile = 1<<1,
		OutputBuffer = 1<<2,
		OutputClipboard = 1<<3,
		OutputMask_ = OutputTTY | OutputFile | OutputBuffer | OutputClipboard,
	}

	/// <summary>
	/// <para>X/Y enums are fixed to 0/1 so they may be used to index ImVec2</para>
	/// </summary>
	public enum ImGuiAxis
	{
		None = -1,
		X = 0,
		Y = 1,
	}

	public enum ImGuiPlotType
	{
		Lines = 0,
		Histogram = 1,
	}

	[Flags]
	public enum ImGuiWindowRefreshFlags
	{
		None = 0,
		/// <summary>
		/// [EXPERIMENTAL] Try to keep existing contents, USER MUST NOT HONOR BEGIN() RETURNING FALSE AND NOT APPEND.
		/// </summary>
		TryToAvoidRefresh = 1<<0,
		/// <summary>
		/// [EXPERIMENTAL] Always refresh on hover
		/// </summary>
		RefreshOnHover = 1<<1,
		/// <summary>
		/// [EXPERIMENTAL] Always refresh on focus
		/// </summary>
		RefreshOnFocus = 1<<2,
	}

	[Flags]
	public enum ImGuiNextWindowDataFlags
	{
		None = 0,
		HasPos = 1<<0,
		HasSize = 1<<1,
		HasContentSize = 1<<2,
		HasCollapsed = 1<<3,
		HasSizeConstraint = 1<<4,
		HasFocus = 1<<5,
		HasBgAlpha = 1<<6,
		HasScroll = 1<<7,
		HasChildFlags = 1<<8,
		HasRefreshPolicy = 1<<9,
		HasViewport = 1<<10,
		HasDock = 1<<11,
		HasWindowClass = 1<<12,
	}

	[Flags]
	public enum ImGuiNextItemDataFlags
	{
		None = 0,
		HasWidth = 1<<0,
		HasOpen = 1<<1,
		HasShortcut = 1<<2,
		HasRefVal = 1<<3,
		HasStorageID = 1<<4,
	}

	public enum ImGuiPopupPositionPolicy
	{
		Default = 0,
		ComboBox = 1,
		Tooltip = 2,
	}

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

	public enum ImGuiInputSource
	{
		None = 0,
		/// <summary>
		/// Note: may be Mouse or TouchScreen or Pen. See io.MouseSource to distinguish them.
		/// </summary>
		Mouse = 1,
		Keyboard = 2,
		Gamepad = 3,
		COUNT = 4,
	}

	/// <summary>
	/// <para>Extend ImGuiInputFlags_</para>
	/// <para>Flags for extended versions of IsKeyPressed(), IsMouseClicked(), Shortcut(), SetKeyOwner(), SetItemKeyOwner()</para>
	/// <para>Don't mistake with ImGuiInputTextFlags! (which is for ImGui::InputText() function)</para>
	/// </summary>
	public enum ImGuiInputFlags
	{
		// ImGuiInputFlags values

		None = 0,
		Repeat = 1<<0,
		RouteActive = 1<<10,
		RouteFocused = 1<<11,
		RouteGlobal = 1<<12,
		RouteAlways = 1<<13,
		RouteOverFocused = 1<<14,
		RouteOverActive = 1<<15,
		RouteUnlessBgFocused = 1<<16,
		RouteFromRootWindow = 1<<17,
		Tooltip = 1<<18,

		// Extended ImGuiInputFlags values

		/// <summary>
		/// <para>Flags for IsKeyPressed(), IsKeyChordPressed(), IsMouseClicked(), Shortcut()</para>
		/// <para>- Repeat mode: Repeat rate selection</para>
		/// </summary>
		/// <summary>
		/// Repeat rate: Regular (default)
		/// </summary>
		RepeatRateDefault = 1<<1,
		/// <summary>
		/// Repeat rate: Fast
		/// </summary>
		RepeatRateNavMove = 1<<2,
		/// <summary>
		/// Repeat rate: Faster
		/// </summary>
		RepeatRateNavTweak = 1<<3,
		/// <summary>
		/// <para>- Repeat mode: Specify when repeating key pressed can be interrupted.</para>
		/// <para>- In theory ImGuiInputFlags_RepeatUntilOtherKeyPress may be a desirable default, but it would break too many behavior so everything is opt-in.</para>
		/// </summary>
		/// <summary>
		/// Stop repeating when released (default for all functions except Shortcut). This only exists to allow overriding Shortcut() default behavior.
		/// </summary>
		RepeatUntilRelease = 1<<4,
		/// <summary>
		/// Stop repeating when released OR if keyboard mods are changed (default for Shortcut)
		/// </summary>
		RepeatUntilKeyModsChange = 1<<5,
		/// <summary>
		/// Stop repeating when released OR if keyboard mods are leaving the None state. Allows going from Mod+Key to Key by releasing Mod.
		/// </summary>
		RepeatUntilKeyModsChangeFromNone = 1<<6,
		/// <summary>
		/// Stop repeating when released OR if any other keyboard key is pressed during the repeat
		/// </summary>
		RepeatUntilOtherKeyPress = 1<<7,
		/// <summary>
		/// <para>Flags for SetKeyOwner(), SetItemKeyOwner()</para>
		/// <para>- Locking key away from non-input aware code. Locking is useful to make input-owner-aware code steal keys from non-input-owner-aware code. If all code is input-owner-aware locking would never be necessary.</para>
		/// </summary>
		/// <summary>
		/// Further accesses to key data will require EXPLICIT owner ID (ImGuiKeyOwner_Any/0 will NOT accepted for polling). Cleared at end of frame.
		/// </summary>
		LockThisFrame = 1<<20,
		/// <summary>
		/// Further accesses to key data will require EXPLICIT owner ID (ImGuiKeyOwner_Any/0 will NOT accepted for polling). Cleared when the key is released or at end of each frame if key is released.
		/// </summary>
		LockUntilRelease = 1<<21,
		/// <summary>
		/// <para>- Condition for SetItemKeyOwner()</para>
		/// </summary>
		/// <summary>
		/// Only set if item is hovered (default to both)
		/// </summary>
		CondHovered = 1<<22,
		/// <summary>
		/// Only set if item is active (default to both)
		/// </summary>
		CondActive = 1<<23,
		CondDefault_ = CondHovered | CondActive,
		/// <summary>
		/// <para>[Internal] Mask of which function support which flags</para>
		/// </summary>
		RepeatRateMask_ = RepeatRateDefault | RepeatRateNavMove | RepeatRateNavTweak,
		RepeatUntilMask_ = RepeatUntilRelease | RepeatUntilKeyModsChange | RepeatUntilKeyModsChangeFromNone | RepeatUntilOtherKeyPress,
		RepeatMask_ = Repeat | RepeatRateMask_ | RepeatUntilMask_,
		CondMask_ = CondHovered | CondActive,
		RouteTypeMask_ = RouteActive | RouteFocused | RouteGlobal | RouteAlways,
		RouteOptionsMask_ = RouteOverFocused | RouteOverActive | RouteUnlessBgFocused | RouteFromRootWindow,
		SupportedByIsKeyPressed = RepeatMask_,
		SupportedByIsMouseClicked = Repeat,
		SupportedByShortcut = RepeatMask_ | RouteTypeMask_ | RouteOptionsMask_,
		SupportedBySetNextItemShortcut = RepeatMask_ | RouteTypeMask_ | RouteOptionsMask_ | Tooltip,
		SupportedBySetKeyOwner = LockThisFrame | LockUntilRelease,
		SupportedBySetItemKeyOwner = SupportedBySetKeyOwner | CondMask_,
	}

	[Flags]
	public enum ImGuiActivateFlags
	{
		None = 0,
		/// <summary>
		/// Favor activation that requires keyboard text input (e.g. for Slider/Drag). Default for Enter key.
		/// </summary>
		PreferInput = 1<<0,
		/// <summary>
		/// Favor activation for tweaking with arrows or gamepad (e.g. for Slider/Drag). Default for Space key and if keyboard is not used.
		/// </summary>
		PreferTweak = 1<<1,
		/// <summary>
		/// Request widget to preserve state if it can (e.g. InputText will try to preserve cursor/selection)
		/// </summary>
		TryToPreserveState = 1<<2,
		/// <summary>
		/// Activation requested by a tabbing request
		/// </summary>
		FromTabbing = 1<<3,
		/// <summary>
		/// Activation requested by an item shortcut via SetNextItemShortcut() function.
		/// </summary>
		FromShortcut = 1<<4,
	}

	/// <summary>
	/// <para>Early work-in-progress API for ScrollToItem()</para>
	/// </summary>
	[Flags]
	public enum ImGuiScrollFlags
	{
		None = 0,
		/// <summary>
		/// If item is not visible: scroll as little as possible on X axis to bring item back into view [default for X axis]
		/// </summary>
		KeepVisibleEdgeX = 1<<0,
		/// <summary>
		/// If item is not visible: scroll as little as possible on Y axis to bring item back into view [default for Y axis for windows that are already visible]
		/// </summary>
		KeepVisibleEdgeY = 1<<1,
		/// <summary>
		/// If item is not visible: scroll to make the item centered on X axis [rarely used]
		/// </summary>
		KeepVisibleCenterX = 1<<2,
		/// <summary>
		/// If item is not visible: scroll to make the item centered on Y axis
		/// </summary>
		KeepVisibleCenterY = 1<<3,
		/// <summary>
		/// Always center the result item on X axis [rarely used]
		/// </summary>
		AlwaysCenterX = 1<<4,
		/// <summary>
		/// Always center the result item on Y axis [default for Y axis for appearing window)
		/// </summary>
		AlwaysCenterY = 1<<5,
		/// <summary>
		/// Disable forwarding scrolling to parent window if required to keep item/rect visible (only scroll window the function was applied to).
		/// </summary>
		NoScrollParent = 1<<6,
		MaskX_ = KeepVisibleEdgeX | KeepVisibleCenterX | AlwaysCenterX,
		MaskY_ = KeepVisibleEdgeY | KeepVisibleCenterY | AlwaysCenterY,
	}

	[Flags]
	public enum ImGuiNavRenderCursorFlags
	{
		None = 0,
		/// <summary>
		/// Compact highlight, no padding/distance from focused item
		/// </summary>
		Compact = 1<<1,
		/// <summary>
		/// Draw rectangular highlight if (g.NavId == id) even when g.NavCursorVisible == false, aka even when using the mouse.
		/// </summary>
		AlwaysDraw = 1<<2,
		NoRounding = 1<<3,
	}

	[Flags]
	public enum ImGuiNavMoveFlags
	{
		None = 0,
		/// <summary>
		/// On failed request, restart from opposite side
		/// </summary>
		LoopX = 1<<0,
		LoopY = 1<<1,
		/// <summary>
		/// On failed request, request from opposite side one line down (when NavDir==right) or one line up (when NavDir==left)
		/// </summary>
		WrapX = 1<<2,
		/// <summary>
		/// This is not super useful but provided for completeness
		/// </summary>
		WrapY = 1<<3,
		WrapMask_ = LoopX | LoopY | WrapX | WrapY,
		/// <summary>
		/// Allow scoring and considering the current NavId as a move target candidate. This is used when the move source is offset (e.g. pressing PageDown actually needs to send a Up move request, if we are pressing PageDown from the bottom-most item we need to stay in place)
		/// </summary>
		AllowCurrentNavId = 1<<4,
		/// <summary>
		/// Store alternate result in NavMoveResultLocalVisible that only comprise elements that are already fully visible (used by PageUp/PageDown)
		/// </summary>
		AlsoScoreVisibleSet = 1<<5,
		/// <summary>
		/// Force scrolling to min/max (used by Home/End) // FIXME-NAV: Aim to remove or reword, probably unnecessary
		/// </summary>
		ScrollToEdgeY = 1<<6,
		Forwarded = 1<<7,
		/// <summary>
		/// Dummy scoring for debug purpose, don't apply result
		/// </summary>
		DebugNoResult = 1<<8,
		/// <summary>
		/// Requests from focus API can land/focus/activate items even if they are marked with _NoTabStop (see NavProcessItemForTabbingRequest() for details)
		/// </summary>
		FocusApi = 1<<9,
		/// <summary>
		/// == Focus + Activate if item is Inputable + DontChangeNavHighlight
		/// </summary>
		IsTabbing = 1<<10,
		/// <summary>
		/// Identify a PageDown/PageUp request.
		/// </summary>
		IsPageMove = 1<<11,
		/// <summary>
		/// Activate/select target item.
		/// </summary>
		Activate = 1<<12,
		/// <summary>
		/// Don't trigger selection by not setting g.NavJustMovedTo
		/// </summary>
		NoSelect = 1<<13,
		/// <summary>
		/// Do not alter the nav cursor visible state
		/// </summary>
		NoSetNavCursorVisible = 1<<14,
		/// <summary>
		/// (Experimental) Do not clear active id when applying move result
		/// </summary>
		NoClearActiveId = 1<<15,
	}

	public enum ImGuiNavLayer
	{
		/// <summary>
		/// Main scrolling layer
		/// </summary>
		Main = 0,
		/// <summary>
		/// Menu layer (access with Alt)
		/// </summary>
		Menu = 1,
		COUNT = 2,
	}

	/// <summary>
	/// <para>Flags for GetTypingSelectRequest()</para>
	/// </summary>
	[Flags]
	public enum ImGuiTypingSelectFlags
	{
		None = 0,
		/// <summary>
		/// Backspace to delete character inputs. If using: ensure GetTypingSelectRequest() is not called more than once per frame (filter by e.g. focus state)
		/// </summary>
		AllowBackspace = 1<<0,
		/// <summary>
		/// Allow "single char" search mode which is activated when pressing the same character multiple times.
		/// </summary>
		AllowSingleCharMode = 1<<1,
	}

	/// <summary>
	/// <para>Flags for internal's BeginColumns(). This is an obsolete API. Prefer using BeginTable() nowadays!</para>
	/// </summary>
	[Flags]
	public enum ImGuiOldColumnFlags
	{
		None = 0,
		/// <summary>
		/// Disable column dividers
		/// </summary>
		NoBorder = 1<<0,
		/// <summary>
		/// Disable resizing columns when clicking on the dividers
		/// </summary>
		NoResize = 1<<1,
		/// <summary>
		/// Disable column width preservation when adjusting columns
		/// </summary>
		NoPreserveWidths = 1<<2,
		/// <summary>
		/// Disable forcing columns to fit within window
		/// </summary>
		NoForceWithinWindow = 1<<3,
		/// <summary>
		/// Restore pre-1.51 behavior of extending the parent window contents size but _without affecting the columns width at all_. Will eventually remove.
		/// </summary>
		GrowParentContentsSize = 1<<4,
	}

	/// <summary>
	/// <para>Extend ImGuiDockNodeFlags_</para>
	/// </summary>
	public enum ImGuiDockNodeFlags
	{
		// ImGuiDockNodeFlags values

		None = 0,
		KeepAliveOnly = 1<<0,
		NoDockingOverCentralNode = 1<<2,
		PassthruCentralNode = 1<<3,
		NoDockingSplit = 1<<4,
		NoResize = 1<<5,
		AutoHideTabBar = 1<<6,
		NoUndocking = 1<<7,

		// Extended ImGuiDockNodeFlags values

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Saved // A dockspace is a node that occupy space within an existing user window. Otherwise the node is floating and create its own window.
		/// </summary>
		DockSpace = 1<<10,
		/// <summary>
		/// Saved // The central node has 2 main properties: stay visible when empty, only use "remaining" spaces from its neighbor.
		/// </summary>
		CentralNode = 1<<11,
		/// <summary>
		/// Saved // Tab bar is completely unavailable. No triangle in the corner to enable it back.
		/// </summary>
		NoTabBar = 1<<12,
		/// <summary>
		/// Saved // Tab bar is hidden, with a triangle in the corner to show it again (NB: actual tab-bar instance may be destroyed as this is only used for single-window tab bar)
		/// </summary>
		HiddenTabBar = 1<<13,
		/// <summary>
		/// Saved // Disable window/docking menu (that one that appears instead of the collapse button)
		/// </summary>
		NoWindowMenuButton = 1<<14,
		/// <summary>
		/// Saved // Disable close button
		/// </summary>
		NoCloseButton = 1<<15,
		/// <summary>
		///       //
		/// </summary>
		NoResizeX = 1<<16,
		/// <summary>
		///       //
		/// </summary>
		NoResizeY = 1<<17,
		/// <summary>
		///       // Any docked window will be automatically be focus-route chained (window-&gt;ParentWindowForFocusRoute set to this) so Shortcut() in this window can run when any docked window is focused.
		/// </summary>
		DockedWindowsInFocusRoute = 1<<18,
		/// <summary>
		/// <para>Disable docking/undocking actions in this dockspace or individual node (existing docked nodes will be preserved)</para>
		/// <para>Those are not exposed in public because the desirable sharing/inheriting/copy-flag-on-split behaviors are quite difficult to design and understand.</para>
		/// <para>The two public flags ImGuiDockNodeFlags_NoDockingOverCentralNode/ImGuiDockNodeFlags_NoDockingSplit don't have those issues.</para>
		/// </summary>
		/// <summary>
		///       // Disable this node from splitting other windows/nodes.
		/// </summary>
		NoDockingSplitOther = 1<<19,
		/// <summary>
		///       // Disable other windows/nodes from being docked over this node.
		/// </summary>
		NoDockingOverMe = 1<<20,
		/// <summary>
		///       // Disable this node from being docked over another window or non-empty node.
		/// </summary>
		NoDockingOverOther = 1<<21,
		/// <summary>
		///       // Disable this node from being docked over an empty node (e.g. DockSpace with no other windows)
		/// </summary>
		NoDockingOverEmpty = 1<<22,
		NoDocking = NoDockingOverMe | NoDockingOverOther | NoDockingOverEmpty | NoDockingSplit | NoDockingSplitOther,
		/// <summary>
		/// <para>Masks</para>
		/// </summary>
		SharedFlagsInheritMask_ = ~0,
		NoResizeFlagsMask_ = (int)NoResize | NoResizeX | NoResizeY,
		/// <summary>
		/// <para>When splitting, those local flags are moved to the inheriting child, never duplicated</para>
		/// </summary>
		LocalFlagsTransferMask_ = (int)NoDockingSplit | NoResizeFlagsMask_ |(int)AutoHideTabBar | CentralNode | NoTabBar | HiddenTabBar | NoWindowMenuButton | NoCloseButton,
		SavedFlagsMask_ = NoResizeFlagsMask_ | DockSpace | CentralNode | NoTabBar | HiddenTabBar | NoWindowMenuButton | NoCloseButton,
	}

	/// <summary>
	/// <para>Store the source authority (dock node vs window) of a field</para>
	/// </summary>
	public enum ImGuiDataAuthority
	{
		Auto = 0,
		DockNode = 1,
		Window = 2,
	}

	public enum ImGuiDockNodeState
	{
		Unknown = 0,
		HostWindowHiddenBecauseSingleWindow = 1,
		HostWindowHiddenBecauseWindowsAreResizing = 2,
		HostWindowVisible = 3,
	}

	/// <summary>
	/// <para>List of colors that are stored at the time of Begin() into Docked Windows.</para>
	/// <para>We currently store the packed colors in a simple array window-&gt;DockStyle.Colors[].</para>
	/// <para>A better solution may involve appending into a log of colors in ImGuiContext + store offsets into those arrays in ImGuiWindow,</para>
	/// <para>but it would be more complex as we'd need to double-buffer both as e.g. drop target may refer to window from last frame.</para>
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

	/// <summary>
	/// <para>This is experimental and not officially supported, it'll probably fall short of features, if/when it does we may backtrack.</para>
	/// </summary>
	/// <summary>
	/// Forward declared enum type ImGuiLocKey
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
		OpenLink_s = 8,
		CopyLink = 9,
		DockingHideTabBar = 10,
		DockingHoldShiftToDock = 11,
		DockingDragToUndockOrMoveNode = 12,
		COUNT = 13,
	}

	/// <summary>
	/// <para>See IMGUI_DEBUG_LOG() and IMGUI_DEBUG_LOG_XXX() macros.</para>
	/// </summary>
	[Flags]
	public enum ImGuiDebugLogFlags
	{
		/// <summary>
		/// <para>Event types</para>
		/// </summary>
		None = 0,
		/// <summary>
		/// Error submitted by IM_ASSERT_USER_ERROR()
		/// </summary>
		EventError = 1<<0,
		EventActiveId = 1<<1,
		EventFocus = 1<<2,
		EventPopup = 1<<3,
		EventNav = 1<<4,
		EventClipper = 1<<5,
		EventSelection = 1<<6,
		EventIO = 1<<7,
		EventFont = 1<<8,
		EventInputRouting = 1<<9,
		EventDocking = 1<<10,
		EventViewport = 1<<11,
		EventMask_ = EventError | EventActiveId | EventFocus | EventPopup | EventNav | EventClipper | EventSelection | EventIO | EventFont | EventInputRouting | EventDocking | EventViewport,
		/// <summary>
		/// Also send output to TTY
		/// </summary>
		OutputToTTY = 1<<20,
		/// <summary>
		/// Also send output to Test Engine
		/// </summary>
		OutputToTestEngine = 1<<21,
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
		PendingRemoval_ = 7,
	}

	/// <summary>
	/// <para>Extend ImGuiTabBarFlags_</para>
	/// </summary>
	public enum ImGuiTabBarFlags
	{
		// ImGuiTabBarFlags values

		None = 0,
		Reorderable = 1<<0,
		AutoSelectNewTabs = 1<<1,
		TabListPopupButton = 1<<2,
		NoCloseWithMiddleMouseButton = 1<<3,
		NoTabListScrollingButtons = 1<<4,
		NoTooltip = 1<<5,
		DrawSelectedOverline = 1<<6,
		FittingPolicyResizeDown = 1<<7,
		FittingPolicyScroll = 1<<8,
		FittingPolicyMask_ = FittingPolicyResizeDown | FittingPolicyScroll,
		FittingPolicyDefault_ = FittingPolicyResizeDown,

		// Extended ImGuiTabBarFlags values

		/// <summary>
		/// Part of a dock node [we don't use this in the master branch but it facilitate branch syncing to keep this around]
		/// </summary>
		DockNode = 1<<20,
		IsFocused = 1<<21,
		/// <summary>
		/// FIXME: Settings are handled by the docking system, this only request the tab bar to mark settings dirty when reordering tabs
		/// </summary>
		SaveSettings = 1<<22,
	}

	/// <summary>
	/// <para>Extend ImGuiTabItemFlags_</para>
	/// </summary>
	public enum ImGuiTabItemFlags
	{
		// ImGuiTabItemFlags values

		None = 0,
		UnsavedDocument = 1<<0,
		SetSelected = 1<<1,
		NoCloseWithMiddleMouseButton = 1<<2,
		NoPushId = 1<<3,
		NoTooltip = 1<<4,
		NoReorder = 1<<5,
		Leading = 1<<6,
		Trailing = 1<<7,
		NoAssumedClosure = 1<<8,

		// Extended ImGuiTabItemFlags values

		SectionMask_ = Leading | Trailing,
		/// <summary>
		/// Track whether p_open was set or not (we'll need this info on the next frame to recompute ContentWidth during layout)
		/// </summary>
		NoCloseButton = 1<<20,
		/// <summary>
		/// Used by TabItemButton, change the tab item behavior to mimic a button
		/// </summary>
		Button = 1<<21,
		/// <summary>
		/// [Docking] Trailing tabs with the _Unsorted flag will be sorted based on the DockOrder of their Window.
		/// </summary>
		Unsorted = 1<<22,
	}

}
