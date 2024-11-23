using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiContext
	{
		public byte Initialized;
		/// <summary>
		/// IO.Fonts-&gt; is owned by the ImGuiContext and will be destructed along with it.
		/// </summary>
		public byte FontAtlasOwnedByContext;
		public ImGuiIO IO;
		public ImGuiPlatformIO PlatformIO;
		public ImGuiStyle Style;
		/// <summary>
		/// = g.IO.ConfigFlags at the time of NewFrame()
		/// </summary>
		public ImGuiConfigFlags ConfigFlagsCurrFrame;
		public ImGuiConfigFlags ConfigFlagsLastFrame;
		/// <summary>
		/// (Shortcut) == FontStack.empty() ? IO.Font : FontStack.back()
		/// </summary>
		public ImFont* Font;
		/// <summary>
		/// (Shortcut) == FontBaseSize * g.CurrentWindow-&gt;FontWindowScale == window-&gt;FontSize(). Text height for current window.
		/// </summary>
		public float FontSize;
		/// <summary>
		/// (Shortcut) == IO.FontGlobalScale * Font-&gt;Scale * Font-&gt;FontSize. Base text height.
		/// </summary>
		public float FontBaseSize;
		/// <summary>
		/// == FontSize / Font-&gt;FontSize
		/// </summary>
		public float FontScale;
		/// <summary>
		/// Current window/viewport DpiScale == CurrentViewport-&gt;DpiScale
		/// </summary>
		public float CurrentDpiScale;
		public ImDrawListSharedData DrawListSharedData;
		public double Time;
		public int FrameCount;
		public int FrameCountEnded;
		public int FrameCountPlatformEnded;
		public int FrameCountRendered;
		/// <summary>
		/// Set by NewFrame(), cleared by EndFrame()
		/// </summary>
		public byte WithinFrameScope;
		/// <summary>
		/// Set by NewFrame(), cleared by EndFrame() when the implicit debug window has been pushed
		/// </summary>
		public byte WithinFrameScopeWithImplicitWindow;
		/// <summary>
		/// Set within EndChild()
		/// </summary>
		public byte WithinEndChild;
		/// <summary>
		/// Request full GC
		/// </summary>
		public byte GcCompactAll;
		/// <summary>
		/// Will call test engine hooks: ImGuiTestEngineHook_ItemAdd(), ImGuiTestEngineHook_ItemInfo(), ImGuiTestEngineHook_Log()
		/// </summary>
		public byte TestEngineHookItems;
		/// <summary>
		/// Test engine user data
		/// </summary>
		public void* TestEngine;
		/// <summary>
		/// Storage for a context name (to facilitate debugging multi-context setups)
		/// </summary>
		public fixed byte ContextName[16];
		/// <summary>
		/// <para>Inputs</para>
		/// </summary>
		/// <summary>
		/// Input events which will be trickled/written into IO structure.
		/// </summary>
		public ImVector InputEventsQueue;
		/// <summary>
		/// Past input events processed in NewFrame(). This is to allow domain-specific application to access e.g mouse/pen trail.
		/// </summary>
		public ImVector InputEventsTrail;
		public ImGuiMouseSource InputEventsNextMouseSource;
		public uint InputEventsNextEventId;
		/// <summary>
		/// <para>Windows state</para>
		/// </summary>
		/// <summary>
		/// Windows, sorted in display order, back to front
		/// </summary>
		public ImVector Windows;
		/// <summary>
		/// Root windows, sorted in focus order, back to front.
		/// </summary>
		public ImVector WindowsFocusOrder;
		/// <summary>
		/// Temporary buffer used in EndFrame() to reorder windows so parents are kept before their child
		/// </summary>
		public ImVector WindowsTempSortBuffer;
		public ImVector CurrentWindowStack;
		/// <summary>
		/// Map window's ImGuiID to ImGuiWindow*
		/// </summary>
		public ImGuiStorage WindowsById;
		/// <summary>
		/// Number of unique windows submitted by frame
		/// </summary>
		public int WindowsActiveCount;
		/// <summary>
		/// Padding around resizable windows for which hovering on counts as hovering the window == ImMax(style.TouchExtraPadding, WINDOWS_HOVER_PADDING).
		/// </summary>
		public Vector2 WindowsHoverPadding;
		/// <summary>
		/// Set to break in Begin() call.
		/// </summary>
		public uint DebugBreakInWindow;
		/// <summary>
		/// Window being drawn into
		/// </summary>
		public ImGuiWindow* CurrentWindow;
		/// <summary>
		/// Window the mouse is hovering. Will typically catch mouse inputs.
		/// </summary>
		public ImGuiWindow* HoveredWindow;
		/// <summary>
		/// Hovered window ignoring MovingWindow. Only set if MovingWindow is set.
		/// </summary>
		public ImGuiWindow* HoveredWindowUnderMovingWindow;
		/// <summary>
		/// Window the mouse is hovering. Filled even with _NoMouse. This is currently useful for multi-context compositors.
		/// </summary>
		public ImGuiWindow* HoveredWindowBeforeClear;
		/// <summary>
		/// Track the window we clicked on (in order to preserve focus). The actual window that is moved is generally MovingWindow-&gt;RootWindowDockTree.
		/// </summary>
		public ImGuiWindow* MovingWindow;
		/// <summary>
		/// Track the window we started mouse-wheeling on. Until a timer elapse or mouse has moved, generally keep scrolling the same window even if during the course of scrolling the mouse ends up hovering a child window.
		/// </summary>
		public ImGuiWindow* WheelingWindow;
		public Vector2 WheelingWindowRefMousePos;
		/// <summary>
		/// This may be set one frame before WheelingWindow is != NULL
		/// </summary>
		public int WheelingWindowStartFrame;
		public int WheelingWindowScrolledFrame;
		public float WheelingWindowReleaseTimer;
		public Vector2 WheelingWindowWheelRemainder;
		public Vector2 WheelingAxisAvg;
		/// <summary>
		/// <para>Item/widgets state and tracking information</para>
		/// </summary>
		/// <summary>
		/// Set when we detect multiple items with the same identifier
		/// </summary>
		public uint DebugDrawIdConflicts;
		/// <summary>
		/// Will call core hooks: DebugHookIdInfo() from GetID functions, used by ID Stack Tool [next HoveredId/ActiveId to not pull in an extra cache-line]
		/// </summary>
		public uint DebugHookIdInfo;
		/// <summary>
		/// Hovered widget, filled during the frame
		/// </summary>
		public uint HoveredId;
		public uint HoveredIdPreviousFrame;
		/// <summary>
		/// Count numbers of items using the same ID as last frame's hovered id
		/// </summary>
		public int HoveredIdPreviousFrameItemCount;
		/// <summary>
		/// Measure contiguous hovering time
		/// </summary>
		public float HoveredIdTimer;
		/// <summary>
		/// Measure contiguous hovering time where the item has not been active
		/// </summary>
		public float HoveredIdNotActiveTimer;
		public byte HoveredIdAllowOverlap;
		/// <summary>
		/// At least one widget passed the rect test, but has been discarded by disabled flag or popup inhibit. May be true even if HoveredId == 0.
		/// </summary>
		public byte HoveredIdIsDisabled;
		/// <summary>
		/// Disable ItemAdd() clipping, essentially a memory-locality friendly copy of LogEnabled
		/// </summary>
		public byte ItemUnclipByLog;
		/// <summary>
		/// Active widget
		/// </summary>
		public uint ActiveId;
		/// <summary>
		/// Active widget has been seen this frame (we can't use a bool as the ActiveId may change within the frame)
		/// </summary>
		public uint ActiveIdIsAlive;
		public float ActiveIdTimer;
		/// <summary>
		/// Set at the time of activation for one frame
		/// </summary>
		public byte ActiveIdIsJustActivated;
		/// <summary>
		/// Active widget allows another widget to steal active id (generally for overlapping widgets, but not always)
		/// </summary>
		public byte ActiveIdAllowOverlap;
		/// <summary>
		/// Disable losing active id if the active id window gets unfocused.
		/// </summary>
		public byte ActiveIdNoClearOnFocusLoss;
		/// <summary>
		/// Track whether the active id led to a press (this is to allow changing between PressOnClick and PressOnRelease without pressing twice). Used by range_select branch.
		/// </summary>
		public byte ActiveIdHasBeenPressedBefore;
		/// <summary>
		/// Was the value associated to the widget Edited over the course of the Active state.
		/// </summary>
		public byte ActiveIdHasBeenEditedBefore;
		public byte ActiveIdHasBeenEditedThisFrame;
		public byte ActiveIdFromShortcut;
		public int ActiveIdMouseButton;
		/// <summary>
		/// Clicked offset from upper-left corner, if applicable (currently only set by ButtonBehavior)
		/// </summary>
		public Vector2 ActiveIdClickOffset;
		public ImGuiWindow* ActiveIdWindow;
		/// <summary>
		/// Activating source: ImGuiInputSource_Mouse OR ImGuiInputSource_Keyboard OR ImGuiInputSource_Gamepad
		/// </summary>
		public ImGuiInputSource ActiveIdSource;
		public uint ActiveIdPreviousFrame;
		public byte ActiveIdPreviousFrameIsAlive;
		public byte ActiveIdPreviousFrameHasBeenEditedBefore;
		public ImGuiWindow* ActiveIdPreviousFrameWindow;
		/// <summary>
		/// Store the last non-zero ActiveId, useful for animation.
		/// </summary>
		public uint LastActiveId;
		/// <summary>
		/// Store the last non-zero ActiveId timer since the beginning of activation, useful for animation.
		/// </summary>
		public float LastActiveIdTimer;
		/// <summary>
		/// <para>Key/Input Ownership + Shortcut Routing system</para>
		/// <para>- The idea is that instead of "eating" a given key, we can link to an owner.</para>
		/// <para>- Input query can then read input by specifying ImGuiKeyOwner_Any (== 0), ImGuiKeyOwner_NoOwner (== -1) or a custom ID.</para>
		/// <para>- Routing is requested ahead of time for a given chord (Key + Mods) and granted in NewFrame().</para>
		/// </summary>
		/// <summary>
		/// Record the last time key mods changed (affect repeat delay when using shortcut logic)
		/// </summary>
		public double LastKeyModsChangeTime;
		/// <summary>
		/// Record the last time key mods changed away from being 0 (affect repeat delay when using shortcut logic)
		/// </summary>
		public double LastKeyModsChangeFromNoneTime;
		/// <summary>
		/// Record the last time a keyboard key (ignore mouse/gamepad ones) was pressed.
		/// </summary>
		public double LastKeyboardKeyPressTime;
		/// <summary>
		/// Lookup to tell if a key can emit char input, see IsKeyChordPotentiallyCharInput(). sizeof() = 20 bytes
		/// </summary>
		public ImBitArrayForNamedKeys KeysMayBeCharInput;
		public ImGuiKeyOwnerData KeysOwnerData_0;
		public ImGuiKeyOwnerData KeysOwnerData_1;
		public ImGuiKeyOwnerData KeysOwnerData_2;
		public ImGuiKeyOwnerData KeysOwnerData_3;
		public ImGuiKeyOwnerData KeysOwnerData_4;
		public ImGuiKeyOwnerData KeysOwnerData_5;
		public ImGuiKeyOwnerData KeysOwnerData_6;
		public ImGuiKeyOwnerData KeysOwnerData_7;
		public ImGuiKeyOwnerData KeysOwnerData_8;
		public ImGuiKeyOwnerData KeysOwnerData_9;
		public ImGuiKeyOwnerData KeysOwnerData_10;
		public ImGuiKeyOwnerData KeysOwnerData_11;
		public ImGuiKeyOwnerData KeysOwnerData_12;
		public ImGuiKeyOwnerData KeysOwnerData_13;
		public ImGuiKeyOwnerData KeysOwnerData_14;
		public ImGuiKeyOwnerData KeysOwnerData_15;
		public ImGuiKeyOwnerData KeysOwnerData_16;
		public ImGuiKeyOwnerData KeysOwnerData_17;
		public ImGuiKeyOwnerData KeysOwnerData_18;
		public ImGuiKeyOwnerData KeysOwnerData_19;
		public ImGuiKeyOwnerData KeysOwnerData_20;
		public ImGuiKeyOwnerData KeysOwnerData_21;
		public ImGuiKeyOwnerData KeysOwnerData_22;
		public ImGuiKeyOwnerData KeysOwnerData_23;
		public ImGuiKeyOwnerData KeysOwnerData_24;
		public ImGuiKeyOwnerData KeysOwnerData_25;
		public ImGuiKeyOwnerData KeysOwnerData_26;
		public ImGuiKeyOwnerData KeysOwnerData_27;
		public ImGuiKeyOwnerData KeysOwnerData_28;
		public ImGuiKeyOwnerData KeysOwnerData_29;
		public ImGuiKeyOwnerData KeysOwnerData_30;
		public ImGuiKeyOwnerData KeysOwnerData_31;
		public ImGuiKeyOwnerData KeysOwnerData_32;
		public ImGuiKeyOwnerData KeysOwnerData_33;
		public ImGuiKeyOwnerData KeysOwnerData_34;
		public ImGuiKeyOwnerData KeysOwnerData_35;
		public ImGuiKeyOwnerData KeysOwnerData_36;
		public ImGuiKeyOwnerData KeysOwnerData_37;
		public ImGuiKeyOwnerData KeysOwnerData_38;
		public ImGuiKeyOwnerData KeysOwnerData_39;
		public ImGuiKeyOwnerData KeysOwnerData_40;
		public ImGuiKeyOwnerData KeysOwnerData_41;
		public ImGuiKeyOwnerData KeysOwnerData_42;
		public ImGuiKeyOwnerData KeysOwnerData_43;
		public ImGuiKeyOwnerData KeysOwnerData_44;
		public ImGuiKeyOwnerData KeysOwnerData_45;
		public ImGuiKeyOwnerData KeysOwnerData_46;
		public ImGuiKeyOwnerData KeysOwnerData_47;
		public ImGuiKeyOwnerData KeysOwnerData_48;
		public ImGuiKeyOwnerData KeysOwnerData_49;
		public ImGuiKeyOwnerData KeysOwnerData_50;
		public ImGuiKeyOwnerData KeysOwnerData_51;
		public ImGuiKeyOwnerData KeysOwnerData_52;
		public ImGuiKeyOwnerData KeysOwnerData_53;
		public ImGuiKeyOwnerData KeysOwnerData_54;
		public ImGuiKeyOwnerData KeysOwnerData_55;
		public ImGuiKeyOwnerData KeysOwnerData_56;
		public ImGuiKeyOwnerData KeysOwnerData_57;
		public ImGuiKeyOwnerData KeysOwnerData_58;
		public ImGuiKeyOwnerData KeysOwnerData_59;
		public ImGuiKeyOwnerData KeysOwnerData_60;
		public ImGuiKeyOwnerData KeysOwnerData_61;
		public ImGuiKeyOwnerData KeysOwnerData_62;
		public ImGuiKeyOwnerData KeysOwnerData_63;
		public ImGuiKeyOwnerData KeysOwnerData_64;
		public ImGuiKeyOwnerData KeysOwnerData_65;
		public ImGuiKeyOwnerData KeysOwnerData_66;
		public ImGuiKeyOwnerData KeysOwnerData_67;
		public ImGuiKeyOwnerData KeysOwnerData_68;
		public ImGuiKeyOwnerData KeysOwnerData_69;
		public ImGuiKeyOwnerData KeysOwnerData_70;
		public ImGuiKeyOwnerData KeysOwnerData_71;
		public ImGuiKeyOwnerData KeysOwnerData_72;
		public ImGuiKeyOwnerData KeysOwnerData_73;
		public ImGuiKeyOwnerData KeysOwnerData_74;
		public ImGuiKeyOwnerData KeysOwnerData_75;
		public ImGuiKeyOwnerData KeysOwnerData_76;
		public ImGuiKeyOwnerData KeysOwnerData_77;
		public ImGuiKeyOwnerData KeysOwnerData_78;
		public ImGuiKeyOwnerData KeysOwnerData_79;
		public ImGuiKeyOwnerData KeysOwnerData_80;
		public ImGuiKeyOwnerData KeysOwnerData_81;
		public ImGuiKeyOwnerData KeysOwnerData_82;
		public ImGuiKeyOwnerData KeysOwnerData_83;
		public ImGuiKeyOwnerData KeysOwnerData_84;
		public ImGuiKeyOwnerData KeysOwnerData_85;
		public ImGuiKeyOwnerData KeysOwnerData_86;
		public ImGuiKeyOwnerData KeysOwnerData_87;
		public ImGuiKeyOwnerData KeysOwnerData_88;
		public ImGuiKeyOwnerData KeysOwnerData_89;
		public ImGuiKeyOwnerData KeysOwnerData_90;
		public ImGuiKeyOwnerData KeysOwnerData_91;
		public ImGuiKeyOwnerData KeysOwnerData_92;
		public ImGuiKeyOwnerData KeysOwnerData_93;
		public ImGuiKeyOwnerData KeysOwnerData_94;
		public ImGuiKeyOwnerData KeysOwnerData_95;
		public ImGuiKeyOwnerData KeysOwnerData_96;
		public ImGuiKeyOwnerData KeysOwnerData_97;
		public ImGuiKeyOwnerData KeysOwnerData_98;
		public ImGuiKeyOwnerData KeysOwnerData_99;
		public ImGuiKeyOwnerData KeysOwnerData_100;
		public ImGuiKeyOwnerData KeysOwnerData_101;
		public ImGuiKeyOwnerData KeysOwnerData_102;
		public ImGuiKeyOwnerData KeysOwnerData_103;
		public ImGuiKeyOwnerData KeysOwnerData_104;
		public ImGuiKeyOwnerData KeysOwnerData_105;
		public ImGuiKeyOwnerData KeysOwnerData_106;
		public ImGuiKeyOwnerData KeysOwnerData_107;
		public ImGuiKeyOwnerData KeysOwnerData_108;
		public ImGuiKeyOwnerData KeysOwnerData_109;
		public ImGuiKeyOwnerData KeysOwnerData_110;
		public ImGuiKeyOwnerData KeysOwnerData_111;
		public ImGuiKeyOwnerData KeysOwnerData_112;
		public ImGuiKeyOwnerData KeysOwnerData_113;
		public ImGuiKeyOwnerData KeysOwnerData_114;
		public ImGuiKeyOwnerData KeysOwnerData_115;
		public ImGuiKeyOwnerData KeysOwnerData_116;
		public ImGuiKeyOwnerData KeysOwnerData_117;
		public ImGuiKeyOwnerData KeysOwnerData_118;
		public ImGuiKeyOwnerData KeysOwnerData_119;
		public ImGuiKeyOwnerData KeysOwnerData_120;
		public ImGuiKeyOwnerData KeysOwnerData_121;
		public ImGuiKeyOwnerData KeysOwnerData_122;
		public ImGuiKeyOwnerData KeysOwnerData_123;
		public ImGuiKeyOwnerData KeysOwnerData_124;
		public ImGuiKeyOwnerData KeysOwnerData_125;
		public ImGuiKeyOwnerData KeysOwnerData_126;
		public ImGuiKeyOwnerData KeysOwnerData_127;
		public ImGuiKeyOwnerData KeysOwnerData_128;
		public ImGuiKeyOwnerData KeysOwnerData_129;
		public ImGuiKeyOwnerData KeysOwnerData_130;
		public ImGuiKeyOwnerData KeysOwnerData_131;
		public ImGuiKeyOwnerData KeysOwnerData_132;
		public ImGuiKeyOwnerData KeysOwnerData_133;
		public ImGuiKeyOwnerData KeysOwnerData_134;
		public ImGuiKeyOwnerData KeysOwnerData_135;
		public ImGuiKeyOwnerData KeysOwnerData_136;
		public ImGuiKeyOwnerData KeysOwnerData_137;
		public ImGuiKeyOwnerData KeysOwnerData_138;
		public ImGuiKeyOwnerData KeysOwnerData_139;
		public ImGuiKeyOwnerData KeysOwnerData_140;
		public ImGuiKeyOwnerData KeysOwnerData_141;
		public ImGuiKeyOwnerData KeysOwnerData_142;
		public ImGuiKeyOwnerData KeysOwnerData_143;
		public ImGuiKeyOwnerData KeysOwnerData_144;
		public ImGuiKeyOwnerData KeysOwnerData_145;
		public ImGuiKeyOwnerData KeysOwnerData_146;
		public ImGuiKeyOwnerData KeysOwnerData_147;
		public ImGuiKeyOwnerData KeysOwnerData_148;
		public ImGuiKeyOwnerData KeysOwnerData_149;
		public ImGuiKeyOwnerData KeysOwnerData_150;
		public ImGuiKeyOwnerData KeysOwnerData_151;
		public ImGuiKeyOwnerData KeysOwnerData_152;
		public ImGuiKeyOwnerData KeysOwnerData_153;
		public ImGuiKeyRoutingTable KeysRoutingTable;
		/// <summary>
		/// Active widget will want to read those nav move requests (e.g. can activate a button and move away from it)
		/// </summary>
		public uint ActiveIdUsingNavDirMask;
		/// <summary>
		/// Active widget will want to read all keyboard keys inputs. (this is a shortcut for not taking ownership of 100+ keys, frequently used by drag operations)
		/// </summary>
		public byte ActiveIdUsingAllKeyboardKeys;
		/// <summary>
		/// Set to break in SetShortcutRouting()/Shortcut() calls.
		/// </summary>
		public ImGuiKey DebugBreakInShortcutRouting;
		/// <summary>
		/// <para>Next window/item data</para>
		/// </summary>
		/// <summary>
		/// Value for currently appending items == g.FocusScopeStack.back(). Not to be mistaken with g.NavFocusScopeId.
		/// </summary>
		public uint CurrentFocusScopeId;
		/// <summary>
		/// Value for currently appending items == g.ItemFlagsStack.back()
		/// </summary>
		public ImGuiItemFlags CurrentItemFlags;
		/// <summary>
		/// Storage for DebugLocateItemOnHover() feature: this is read by ItemAdd() so we keep it in a hot/cached location
		/// </summary>
		public uint DebugLocateId;
		/// <summary>
		/// Storage for SetNextItem** functions
		/// </summary>
		public ImGuiNextItemData NextItemData;
		/// <summary>
		/// Storage for last submitted item (setup by ItemAdd)
		/// </summary>
		public ImGuiLastItemData LastItemData;
		/// <summary>
		/// Storage for SetNextWindow** functions
		/// </summary>
		public ImGuiNextWindowData NextWindowData;
		public byte DebugShowGroupRects;
		/// <summary>
		/// <para>Shared stacks</para>
		/// </summary>
		/// <summary>
		/// (Keep close to ColorStack to share cache line)
		/// </summary>
		public ImGuiCol DebugFlashStyleColorIdx;
		/// <summary>
		/// Stack for PushStyleColor()/PopStyleColor() - inherited by Begin()
		/// </summary>
		public ImVector ColorStack;
		/// <summary>
		/// Stack for PushStyleVar()/PopStyleVar() - inherited by Begin()
		/// </summary>
		public ImVector StyleVarStack;
		/// <summary>
		/// Stack for PushFont()/PopFont() - inherited by Begin()
		/// </summary>
		public ImVector FontStack;
		/// <summary>
		/// Stack for PushFocusScope()/PopFocusScope() - inherited by BeginChild(), pushed into by Begin()
		/// </summary>
		public ImVector FocusScopeStack;
		/// <summary>
		/// Stack for PushItemFlag()/PopItemFlag() - inherited by Begin()
		/// </summary>
		public ImVector ItemFlagsStack;
		/// <summary>
		/// Stack for BeginGroup()/EndGroup() - not inherited by Begin()
		/// </summary>
		public ImVector GroupStack;
		/// <summary>
		/// Which popups are open (persistent)
		/// </summary>
		public ImVector OpenPopupStack;
		/// <summary>
		/// Which level of BeginPopup() we are in (reset every frame)
		/// </summary>
		public ImVector BeginPopupStack;
		/// <summary>
		/// Stack for TreeNode()
		/// </summary>
		public ImVector TreeNodeStack;
		/// <summary>
		/// <para>Viewports</para>
		/// </summary>
		/// <summary>
		/// Active viewports (always 1+, and generally 1 unless multi-viewports are enabled). Each viewports hold their copy of ImDrawData.
		/// </summary>
		public ImVector Viewports;
		/// <summary>
		/// We track changes of viewport (happening in Begin) so we can call Platform_OnChangedViewport()
		/// </summary>
		public ImGuiViewportP* CurrentViewport;
		public ImGuiViewportP* MouseViewport;
		/// <summary>
		/// Last known viewport that was hovered by mouse (even if we are not hovering any viewport any more) + honoring the _NoInputs flag.
		/// </summary>
		public ImGuiViewportP* MouseLastHoveredViewport;
		public uint PlatformLastFocusedViewportId;
		/// <summary>
		/// Virtual monitor used as fallback if backend doesn't provide monitor information.
		/// </summary>
		public ImGuiPlatformMonitor FallbackMonitor;
		/// <summary>
		/// Bounding box of all platform monitors
		/// </summary>
		public ImRect PlatformMonitorsFullWorkRect;
		/// <summary>
		/// Unique sequential creation counter (mostly for testing/debugging)
		/// </summary>
		public int ViewportCreatedCount;
		/// <summary>
		/// Unique sequential creation counter (mostly for testing/debugging)
		/// </summary>
		public int PlatformWindowsCreatedCount;
		/// <summary>
		/// Every time the front-most window changes, we stamp its viewport with an incrementing counter
		/// </summary>
		public int ViewportFocusedStampCount;
		/// <summary>
		/// <para>Keyboard/Gamepad Navigation</para>
		/// </summary>
		/// <summary>
		/// Nav focus cursor/rectangle is visible? We hide it after a mouse click. We show it after a nav move.
		/// </summary>
		public byte NavCursorVisible;
		/// <summary>
		/// Disable mouse hovering highlight. Highlight navigation focused item instead of mouse hovered item.
		/// </summary>
		public byte NavHighlightItemUnderNav;
		/// <summary>
		/// <para>//bool                  NavDisableHighlight;                // Old name for !g.NavCursorVisible before 1.91.4 (2024/10/18). OPPOSITE VALUE (g.NavDisableHighlight == !g.NavCursorVisible)</para>
		/// <para>//bool                  NavDisableMouseHover;               // Old name for g.NavHighlightItemUnderNav before 1.91.1 (2024/10/18) this was called When user starts using keyboard/gamepad, we hide mouse hovering highlight until mouse is touched again.</para>
		/// </summary>
		/// <summary>
		/// When set we will update mouse position if io.ConfigNavMoveSetMousePos is set (not enabled by default)
		/// </summary>
		public byte NavMousePosDirty;
		/// <summary>
		/// Nav widget has been seen this frame ~~ NavRectRel is valid
		/// </summary>
		public byte NavIdIsAlive;
		/// <summary>
		/// Focused item for navigation
		/// </summary>
		public uint NavId;
		/// <summary>
		/// Focused window for navigation. Could be called 'FocusedWindow'
		/// </summary>
		public ImGuiWindow* NavWindow;
		/// <summary>
		/// Focused focus scope (e.g. selection code often wants to "clear other items" when landing on an item of the same scope)
		/// </summary>
		public uint NavFocusScopeId;
		/// <summary>
		/// Focused layer (main scrolling layer, or menu/title bar layer)
		/// </summary>
		public ImGuiNavLayer NavLayer;
		/// <summary>
		/// ~~ (g.ActiveId == 0) &amp;&amp; (IsKeyPressed(ImGuiKey_Space) || IsKeyDown(ImGuiKey_Enter) || IsKeyPressed(ImGuiKey_NavGamepadActivate)) ? NavId : 0, also set when calling ActivateItem()
		/// </summary>
		public uint NavActivateId;
		/// <summary>
		/// ~~ IsKeyDown(ImGuiKey_Space) || IsKeyDown(ImGuiKey_Enter) || IsKeyDown(ImGuiKey_NavGamepadActivate) ? NavId : 0
		/// </summary>
		public uint NavActivateDownId;
		/// <summary>
		/// ~~ IsKeyPressed(ImGuiKey_Space) || IsKeyPressed(ImGuiKey_Enter) || IsKeyPressed(ImGuiKey_NavGamepadActivate) ? NavId : 0 (no repeat)
		/// </summary>
		public uint NavActivatePressedId;
		public ImGuiActivateFlags NavActivateFlags;
		/// <summary>
		/// Reversed copy focus scope stack for NavId (should contains NavFocusScopeId). This essentially follow the window-&gt;ParentWindowForFocusRoute chain.
		/// </summary>
		public ImVector NavFocusRoute;
		public uint NavHighlightActivatedId;
		public float NavHighlightActivatedTimer;
		/// <summary>
		/// Set by ActivateItem(), queued until next frame.
		/// </summary>
		public uint NavNextActivateId;
		public ImGuiActivateFlags NavNextActivateFlags;
		/// <summary>
		/// Keyboard or Gamepad mode? THIS CAN ONLY BE ImGuiInputSource_Keyboard or ImGuiInputSource_Mouse
		/// </summary>
		public ImGuiInputSource NavInputSource;
		/// <summary>
		/// Last valid data passed to SetNextItemSelectionUser(), or -1. For current window. Not reset when focusing an item that doesn't have selection data.
		/// </summary>
		public long NavLastValidSelectionUserData;
		public sbyte NavCursorHideFrames;
		/// <summary>
		/// <para>Navigation: Init &amp; Move Requests</para>
		/// </summary>
		/// <summary>
		/// ~~ NavMoveRequest || NavInitRequest this is to perform early out in ItemAdd()
		/// </summary>
		public byte NavAnyRequest;
		/// <summary>
		/// Init request for appearing window to select first item
		/// </summary>
		public byte NavInitRequest;
		public byte NavInitRequestFromMove;
		/// <summary>
		/// Init request result (first item of the window, or one for which SetItemDefaultFocus() was called)
		/// </summary>
		public ImGuiNavItemData NavInitResult;
		/// <summary>
		/// Move request submitted, will process result on next NewFrame()
		/// </summary>
		public byte NavMoveSubmitted;
		/// <summary>
		/// Move request submitted, still scoring incoming items
		/// </summary>
		public byte NavMoveScoringItems;
		public byte NavMoveForwardToNextFrame;
		public ImGuiNavMoveFlags NavMoveFlags;
		public ImGuiScrollFlags NavMoveScrollFlags;
		public ImGuiKey NavMoveKeyMods;
		/// <summary>
		/// Direction of the move request (left/right/up/down)
		/// </summary>
		public ImGuiDir NavMoveDir;
		public ImGuiDir NavMoveDirForDebug;
		/// <summary>
		/// FIXME-NAV: Describe the purpose of this better. Might want to rename?
		/// </summary>
		public ImGuiDir NavMoveClipDir;
		/// <summary>
		/// Rectangle used for scoring, in screen space. Based of window-&gt;NavRectRel[], modified for directional navigation scoring.
		/// </summary>
		public ImRect NavScoringRect;
		/// <summary>
		/// Some nav operations (such as PageUp/PageDown) enforce a region which clipper will attempt to always keep submitted
		/// </summary>
		public ImRect NavScoringNoClipRect;
		/// <summary>
		/// Metrics for debugging
		/// </summary>
		public int NavScoringDebugCount;
		/// <summary>
		/// Generally -1 or +1, 0 when tabbing without a nav id
		/// </summary>
		public int NavTabbingDir;
		/// <summary>
		/// &gt;0 when counting items for tabbing
		/// </summary>
		public int NavTabbingCounter;
		/// <summary>
		/// Best move request candidate within NavWindow
		/// </summary>
		public ImGuiNavItemData NavMoveResultLocal;
		/// <summary>
		/// Best move request candidate within NavWindow that are mostly visible (when using ImGuiNavMoveFlags_AlsoScoreVisibleSet flag)
		/// </summary>
		public ImGuiNavItemData NavMoveResultLocalVisible;
		/// <summary>
		/// Best move request candidate within NavWindow's flattened hierarchy (when using ImGuiWindowFlags_NavFlattened flag)
		/// </summary>
		public ImGuiNavItemData NavMoveResultOther;
		/// <summary>
		/// First tabbing request candidate within NavWindow and flattened hierarchy
		/// </summary>
		public ImGuiNavItemData NavTabbingResultFirst;
		/// <summary>
		/// <para>Navigation: record of last move request</para>
		/// </summary>
		/// <summary>
		/// Just navigated from this focus scope id (result of a successfully MoveRequest).
		/// </summary>
		public uint NavJustMovedFromFocusScopeId;
		/// <summary>
		/// Just navigated to this id (result of a successfully MoveRequest).
		/// </summary>
		public uint NavJustMovedToId;
		/// <summary>
		/// Just navigated to this focus scope id (result of a successfully MoveRequest).
		/// </summary>
		public uint NavJustMovedToFocusScopeId;
		public ImGuiKey NavJustMovedToKeyMods;
		/// <summary>
		/// Copy of ImGuiNavMoveFlags_IsTabbing. Maybe we should store whole flags.
		/// </summary>
		public byte NavJustMovedToIsTabbing;
		/// <summary>
		/// Copy of move result's ItemFlags &amp; ImGuiItemFlags_HasSelectionUserData). Maybe we should just store ImGuiNavItemData.
		/// </summary>
		public byte NavJustMovedToHasSelectionData;
		/// <summary>
		/// <para>Navigation: Windowing (CTRL+TAB for list, or Menu button + keys or directional pads to move/resize)</para>
		/// </summary>
		/// <summary>
		/// = ImGuiMod_Ctrl | ImGuiKey_Tab (or ImGuiMod_Super | ImGuiKey_Tab on OS X). For reconfiguration (see #4828)
		/// </summary>
		public ImGuiKey ConfigNavWindowingKeyNext;
		/// <summary>
		/// = ImGuiMod_Ctrl | ImGuiMod_Shift | ImGuiKey_Tab (or ImGuiMod_Super | ImGuiMod_Shift | ImGuiKey_Tab on OS X)
		/// </summary>
		public ImGuiKey ConfigNavWindowingKeyPrev;
		/// <summary>
		/// Target window when doing CTRL+Tab (or Pad Menu + FocusPrev/Next), this window is temporarily displayed top-most!
		/// </summary>
		public ImGuiWindow* NavWindowingTarget;
		/// <summary>
		/// Record of last valid NavWindowingTarget until DimBgRatio and NavWindowingHighlightAlpha becomes 0.0f, so the fade-out can stay on it.
		/// </summary>
		public ImGuiWindow* NavWindowingTargetAnim;
		/// <summary>
		/// Internal window actually listing the CTRL+Tab contents
		/// </summary>
		public ImGuiWindow* NavWindowingListWindow;
		public float NavWindowingTimer;
		public float NavWindowingHighlightAlpha;
		public byte NavWindowingToggleLayer;
		public ImGuiKey NavWindowingToggleKey;
		public Vector2 NavWindowingAccumDeltaPos;
		public Vector2 NavWindowingAccumDeltaSize;
		/// <summary>
		/// <para>Render</para>
		/// </summary>
		/// <summary>
		/// 0.0..1.0 animation when fading in a dimming background (for modal window and CTRL+TAB list)
		/// </summary>
		public float DimBgRatio;
		/// <summary>
		/// <para>Drag and Drop</para>
		/// </summary>
		public byte DragDropActive;
		/// <summary>
		/// Set when within a BeginDragDropXXX/EndDragDropXXX block for a drag source.
		/// </summary>
		public byte DragDropWithinSource;
		/// <summary>
		/// Set when within a BeginDragDropXXX/EndDragDropXXX block for a drag target.
		/// </summary>
		public byte DragDropWithinTarget;
		public ImGuiDragDropFlags DragDropSourceFlags;
		public int DragDropSourceFrameCount;
		public int DragDropMouseButton;
		public ImGuiPayload DragDropPayload;
		/// <summary>
		/// Store rectangle of current target candidate (we favor small targets when overlapping)
		/// </summary>
		public ImRect DragDropTargetRect;
		/// <summary>
		/// Store ClipRect at the time of item's drawing
		/// </summary>
		public ImRect DragDropTargetClipRect;
		public uint DragDropTargetId;
		public ImGuiDragDropFlags DragDropAcceptFlags;
		/// <summary>
		/// Target item surface (we resolve overlapping targets by prioritizing the smaller surface)
		/// </summary>
		public float DragDropAcceptIdCurrRectSurface;
		/// <summary>
		/// Target item id (set at the time of accepting the payload)
		/// </summary>
		public uint DragDropAcceptIdCurr;
		/// <summary>
		/// Target item id from previous frame (we need to store this to allow for overlapping drag and drop targets)
		/// </summary>
		public uint DragDropAcceptIdPrev;
		/// <summary>
		/// Last time a target expressed a desire to accept the source
		/// </summary>
		public int DragDropAcceptFrameCount;
		/// <summary>
		/// Set when holding a payload just made ButtonBehavior() return a press.
		/// </summary>
		public uint DragDropHoldJustPressedId;
		/// <summary>
		/// We don't expose the ImVector&lt;&gt; directly, ImGuiPayload only holds pointer+size
		/// </summary>
		public ImVector DragDropPayloadBufHeap;
		/// <summary>
		/// Local buffer for small payloads
		/// </summary>
		public fixed byte DragDropPayloadBufLocal[16];
		/// <summary>
		/// <para>Clipper</para>
		/// </summary>
		public int ClipperTempDataStacked;
		public ImVector ClipperTempData;
		/// <summary>
		/// <para>Tables</para>
		/// </summary>
		public ImGuiTable* CurrentTable;
		/// <summary>
		/// Set to break in BeginTable() call.
		/// </summary>
		public uint DebugBreakInTable;
		/// <summary>
		/// Temporary table data size (because we leave previous instances undestructed, we generally don't use TablesTempData.Size)
		/// </summary>
		public int TablesTempDataStacked;
		/// <summary>
		/// Temporary table data (buffers reused/shared across instances, support nesting)
		/// </summary>
		public ImVector TablesTempData;
		/// <summary>
		/// Persistent table data
		/// </summary>
		public ImGuiTable Tables;
		/// <summary>
		/// Last used timestamp of each tables (SOA, for efficient GC)
		/// </summary>
		public ImVector TablesLastTimeActive;
		public ImVector DrawChannelsTempMergeBuffer;
		/// <summary>
		/// <para>Tab bars</para>
		/// </summary>
		public ImGuiTabBar* CurrentTabBar;
		public ImGuiTabBar TabBars;
		public ImVector CurrentTabBarStack;
		public ImVector ShrinkWidthBuffer;
		/// <summary>
		/// <para>Multi-Select state</para>
		/// </summary>
		public ImGuiBoxSelectState BoxSelectState;
		public ImGuiMultiSelectTempData* CurrentMultiSelect;
		/// <summary>
		/// Temporary multi-select data size (because we leave previous instances undestructed, we generally don't use MultiSelectTempData.Size)
		/// </summary>
		public int MultiSelectTempDataStacked;
		public ImVector MultiSelectTempData;
		public ImGuiMultiSelectState MultiSelectStorage;
		/// <summary>
		/// <para>Hover Delay system</para>
		/// </summary>
		public uint HoverItemDelayId;
		public uint HoverItemDelayIdPreviousFrame;
		/// <summary>
		/// Currently used by IsItemHovered()
		/// </summary>
		public float HoverItemDelayTimer;
		/// <summary>
		/// Currently used by IsItemHovered(): grace time before g.TooltipHoverTimer gets cleared.
		/// </summary>
		public float HoverItemDelayClearTimer;
		/// <summary>
		/// Mouse has once been stationary on this item. Only reset after departing the item.
		/// </summary>
		public uint HoverItemUnlockedStationaryId;
		/// <summary>
		/// Mouse has once been stationary on this window. Only reset after departing the window.
		/// </summary>
		public uint HoverWindowUnlockedStationaryId;
		/// <summary>
		/// <para>Mouse state</para>
		/// </summary>
		public ImGuiMouseCursor MouseCursor;
		/// <summary>
		/// Time the mouse has been stationary (with some loose heuristic)
		/// </summary>
		public float MouseStationaryTimer;
		public Vector2 MouseLastValidPos;
		/// <summary>
		/// <para>Widget state</para>
		/// </summary>
		public ImGuiInputTextState InputTextState;
		public ImGuiInputTextDeactivatedState InputTextDeactivatedState;
		public ImFont InputTextPasswordFont;
		/// <summary>
		/// Temporary text input when CTRL+clicking on a slider, etc.
		/// </summary>
		public uint TempInputId;
		/// <summary>
		/// 0 for all data types
		/// </summary>
		public ImGuiDataTypeStorage DataTypeZeroValue;
		public int BeginMenuDepth;
		public int BeginComboDepth;
		/// <summary>
		/// Store user options for color edit widgets
		/// </summary>
		public ImGuiColorEditFlags ColorEditOptions;
		/// <summary>
		/// Set temporarily while inside of the parent-most ColorEdit4/ColorPicker4 (because they call each others).
		/// </summary>
		public uint ColorEditCurrentID;
		/// <summary>
		/// ID we are saving/restoring HS for
		/// </summary>
		public uint ColorEditSavedID;
		/// <summary>
		/// Backup of last Hue associated to LastColor, so we can restore Hue in lossy RGB&lt;&gt;HSV round trips
		/// </summary>
		public float ColorEditSavedHue;
		/// <summary>
		/// Backup of last Saturation associated to LastColor, so we can restore Saturation in lossy RGB&lt;&gt;HSV round trips
		/// </summary>
		public float ColorEditSavedSat;
		/// <summary>
		/// RGB value with alpha set to 0.
		/// </summary>
		public uint ColorEditSavedColor;
		/// <summary>
		/// Initial/reference color at the time of opening the color picker.
		/// </summary>
		public Vector4 ColorPickerRef;
		public ImGuiComboPreviewData ComboPreviewData;
		/// <summary>
		/// Expected border rect, switch to relative edit if moving
		/// </summary>
		public ImRect WindowResizeBorderExpectedRect;
		public byte WindowResizeRelativeMode;
		/// <summary>
		/// 0: scroll to clicked location, -1/+1: prev/next page.
		/// </summary>
		public short ScrollbarSeekMode;
		/// <summary>
		/// When scrolling to mouse location: distance between mouse and center of grab box, normalized in parent space.
		/// </summary>
		public float ScrollbarClickDeltaToGrabCenter;
		public float SliderGrabClickOffset;
		/// <summary>
		/// Accumulated slider delta when using navigation controls.
		/// </summary>
		public float SliderCurrentAccum;
		/// <summary>
		/// Has the accumulated slider delta changed since last time we tried to apply it?
		/// </summary>
		public byte SliderCurrentAccumDirty;
		public byte DragCurrentAccumDirty;
		/// <summary>
		/// Accumulator for dragging modification. Always high-precision, not rounded by end-user precision settings
		/// </summary>
		public float DragCurrentAccum;
		/// <summary>
		/// If speed == 0.0f, uses (max-min) * DragSpeedDefaultRatio
		/// </summary>
		public float DragSpeedDefaultRatio;
		/// <summary>
		/// Backup for style.Alpha for BeginDisabled()
		/// </summary>
		public float DisabledAlphaBackup;
		public short DisabledStackSize;
		public short TooltipOverrideCount;
		/// <summary>
		/// Window of last tooltip submitted during the frame
		/// </summary>
		public ImGuiWindow* TooltipPreviousWindow;
		/// <summary>
		/// If no custom clipboard handler is defined
		/// </summary>
		public ImVector ClipboardHandlerData;
		/// <summary>
		/// A list of menu IDs that were rendered at least once
		/// </summary>
		public ImVector MenusIdSubmittedThisFrame;
		/// <summary>
		/// State for GetTypingSelectRequest()
		/// </summary>
		public ImGuiTypingSelectState TypingSelectState;
		/// <summary>
		/// <para>Platform support</para>
		/// </summary>
		/// <summary>
		/// Data updated by current frame
		/// </summary>
		public ImGuiPlatformImeData PlatformImeData;
		/// <summary>
		/// Previous frame data. When changed we call the platform_io.Platform_SetImeDataFn() handler.
		/// </summary>
		public ImGuiPlatformImeData PlatformImeDataPrev;
		public uint PlatformImeViewport;
		/// <summary>
		/// <para>Extensions</para>
		/// <para>FIXME: We could provide an API to register one slot in an array held in ImGuiContext?</para>
		/// </summary>
		public ImGuiDockContext DockContext;
		public IntPtr DockNodeWindowMenuHandler;
		/// <summary>
		/// <para>Settings</para>
		/// </summary>
		public byte SettingsLoaded;
		/// <summary>
		/// Save .ini Settings to memory when time reaches zero
		/// </summary>
		public float SettingsDirtyTimer;
		/// <summary>
		/// In memory .ini settings
		/// </summary>
		public ImGuiTextBuffer SettingsIniData;
		/// <summary>
		/// List of .ini settings handlers
		/// </summary>
		public ImVector SettingsHandlers;
		/// <summary>
		/// ImGuiWindow .ini settings entries
		/// </summary>
		public ImGuiWindowSettings SettingsWindows;
		/// <summary>
		/// ImGuiTable .ini settings entries
		/// </summary>
		public ImGuiTableSettings SettingsTables;
		/// <summary>
		/// Hooks for extensions (e.g. test engine)
		/// </summary>
		public ImVector Hooks;
		/// <summary>
		/// Next available HookId
		/// </summary>
		public uint HookIdNext;
		/// <summary>
		/// <para>Localization</para>
		/// </summary>
		public byte* LocalizationTable_0;
		public byte* LocalizationTable_1;
		public byte* LocalizationTable_2;
		public byte* LocalizationTable_3;
		public byte* LocalizationTable_4;
		public byte* LocalizationTable_5;
		public byte* LocalizationTable_6;
		public byte* LocalizationTable_7;
		public byte* LocalizationTable_8;
		public byte* LocalizationTable_9;
		public byte* LocalizationTable_10;
		public byte* LocalizationTable_11;
		public byte* LocalizationTable_12;
		/// <summary>
		/// <para>Capture/Logging</para>
		/// </summary>
		/// <summary>
		/// Currently capturing
		/// </summary>
		public byte LogEnabled;
		/// <summary>
		/// Capture flags/type
		/// </summary>
		public ImGuiLogFlags LogFlags;
		public ImGuiWindow* LogWindow;
		/// <summary>
		/// If != NULL log to stdout/ file
		/// </summary>
		public IntPtr LogFile;
		/// <summary>
		/// Accumulation buffer when log to clipboard. This is pointer so our GImGui static constructor doesn't call heap allocators.
		/// </summary>
		public ImGuiTextBuffer LogBuffer;
		public byte* LogNextPrefix;
		public byte* LogNextSuffix;
		public float LogLinePosY;
		public byte LogLineFirstItem;
		public int LogDepthRef;
		public int LogDepthToExpand;
		/// <summary>
		/// Default/stored value for LogDepthMaxExpand if not specified in the LogXXX function call.
		/// </summary>
		public int LogDepthToExpandDefault;
		/// <summary>
		/// <para>Error Handling</para>
		/// </summary>
		/// <summary>
		/// = NULL. May be exposed in public API eventually.
		/// </summary>
		public IntPtr ErrorCallback;
		/// <summary>
		/// = NULL
		/// </summary>
		public void* ErrorCallbackUserData;
		public Vector2 ErrorTooltipLockedPos;
		public byte ErrorFirst;
		/// <summary>
		/// [Internal] Number of errors submitted this frame.
		/// </summary>
		public int ErrorCountCurrentFrame;
		/// <summary>
		/// [Internal]
		/// </summary>
		public ImGuiErrorRecoveryState StackSizesInNewFrame;
		/// <summary>
		/// [Internal]
		/// </summary>
		public ImGuiErrorRecoveryState* StackSizesInBeginForCurrentWindow;
		/// <summary>
		/// <para>Debug Tools</para>
		/// <para>(some of the highly frequently used data are interleaved in other structures above: DebugBreakXXX fields, DebugHookIdInfo, DebugLocateId etc.)</para>
		/// </summary>
		/// <summary>
		/// Locked count (preserved when holding CTRL)
		/// </summary>
		public int DebugDrawIdConflictsCount;
		public ImGuiDebugLogFlags DebugLogFlags;
		public ImGuiTextBuffer DebugLogBuf;
		public ImGuiTextIndex DebugLogIndex;
		public int DebugLogSkippedErrors;
		public ImGuiDebugLogFlags DebugLogAutoDisableFlags;
		public byte DebugLogAutoDisableFrames;
		/// <summary>
		/// For DebugLocateItemOnHover(). This is used together with DebugLocateId which is in a hot/cached spot above.
		/// </summary>
		public byte DebugLocateFrames;
		/// <summary>
		/// Debug break in ItemAdd() call for g.DebugLocateId.
		/// </summary>
		public byte DebugBreakInLocateId;
		/// <summary>
		/// = ImGuiKey_Pause
		/// </summary>
		public ImGuiKey DebugBreakKeyChord;
		/// <summary>
		/// Cycle between 0..9 then wrap around.
		/// </summary>
		public sbyte DebugBeginReturnValueCullDepth;
		/// <summary>
		/// Item picker is active (started with DebugStartItemPicker())
		/// </summary>
		public byte DebugItemPickerActive;
		public byte DebugItemPickerMouseButton;
		/// <summary>
		/// Will call IM_DEBUG_BREAK() when encountering this ID
		/// </summary>
		public uint DebugItemPickerBreakId;
		public float DebugFlashStyleColorTime;
		public Vector4 DebugFlashStyleColorBackup;
		public ImGuiMetricsConfig DebugMetricsConfig;
		public ImGuiIDStackTool DebugIDStackTool;
		public ImGuiDebugAllocInfo DebugAllocInfo;
		/// <summary>
		/// Hovered dock node.
		/// </summary>
		public ImGuiDockNode* DebugHoveredDockNode;
		/// <summary>
		/// <para>Misc</para>
		/// </summary>
		/// <summary>
		/// Calculate estimate of framerate for user over the last 60 frames..
		/// </summary>
		public fixed float FramerateSecPerFrame[60];
		public int FramerateSecPerFrameIdx;
		public int FramerateSecPerFrameCount;
		public float FramerateSecPerFrameAccum;
		/// <summary>
		/// Explicit capture override via SetNextFrameWantCaptureMouse()/SetNextFrameWantCaptureKeyboard(). Default to -1.
		/// </summary>
		public int WantCaptureMouseNextFrame;
		/// <summary>
		/// "
		/// </summary>
		public int WantCaptureKeyboardNextFrame;
		public int WantTextInputNextFrame;
		/// <summary>
		/// Temporary text buffer
		/// </summary>
		public ImVector TempBuffer;
		public fixed byte TempKeychordName[64];
	}

	public unsafe partial struct ImGuiContextPtr
	{
		public ImGuiContext* NativePtr { get; }
		public ImGuiContextPtr(ImGuiContext* nativePtr) => NativePtr = nativePtr;
		public ImGuiContextPtr(IntPtr nativePtr) => NativePtr = (ImGuiContext*)nativePtr;
		public static implicit operator ImGuiContextPtr(ImGuiContext* nativePtr) => new ImGuiContextPtr(nativePtr);
		public static implicit operator ImGuiContext* (ImGuiContextPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiContextPtr(IntPtr nativePtr) => new ImGuiContextPtr(nativePtr);

		public ref bool Initialized => ref Unsafe.AsRef<bool>(&NativePtr->Initialized);

		/// <summary>
		/// IO.Fonts-&gt; is owned by the ImGuiContext and will be destructed along with it.
		/// </summary>
		public ref bool FontAtlasOwnedByContext => ref Unsafe.AsRef<bool>(&NativePtr->FontAtlasOwnedByContext);

		public ref ImGuiIO IO => ref Unsafe.AsRef<ImGuiIO>(&NativePtr->IO);

		public ref ImGuiPlatformIO PlatformIO => ref Unsafe.AsRef<ImGuiPlatformIO>(&NativePtr->PlatformIO);

		public ref ImGuiStyle Style => ref Unsafe.AsRef<ImGuiStyle>(&NativePtr->Style);

		/// <summary>
		/// = g.IO.ConfigFlags at the time of NewFrame()
		/// </summary>
		public ref ImGuiConfigFlags ConfigFlagsCurrFrame => ref Unsafe.AsRef<ImGuiConfigFlags>(&NativePtr->ConfigFlagsCurrFrame);

		public ref ImGuiConfigFlags ConfigFlagsLastFrame => ref Unsafe.AsRef<ImGuiConfigFlags>(&NativePtr->ConfigFlagsLastFrame);

		/// <summary>
		/// (Shortcut) == FontStack.empty() ? IO.Font : FontStack.back()
		/// </summary>
		public ImFontPtr Font => new ImFontPtr(NativePtr->Font);

		/// <summary>
		/// (Shortcut) == FontBaseSize * g.CurrentWindow-&gt;FontWindowScale == window-&gt;FontSize(). Text height for current window.
		/// </summary>
		public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);

		/// <summary>
		/// (Shortcut) == IO.FontGlobalScale * Font-&gt;Scale * Font-&gt;FontSize. Base text height.
		/// </summary>
		public ref float FontBaseSize => ref Unsafe.AsRef<float>(&NativePtr->FontBaseSize);

		/// <summary>
		/// == FontSize / Font-&gt;FontSize
		/// </summary>
		public ref float FontScale => ref Unsafe.AsRef<float>(&NativePtr->FontScale);

		/// <summary>
		/// Current window/viewport DpiScale == CurrentViewport-&gt;DpiScale
		/// </summary>
		public ref float CurrentDpiScale => ref Unsafe.AsRef<float>(&NativePtr->CurrentDpiScale);

		public ref ImDrawListSharedData DrawListSharedData => ref Unsafe.AsRef<ImDrawListSharedData>(&NativePtr->DrawListSharedData);

		public ref double Time => ref Unsafe.AsRef<double>(&NativePtr->Time);

		public ref int FrameCount => ref Unsafe.AsRef<int>(&NativePtr->FrameCount);

		public ref int FrameCountEnded => ref Unsafe.AsRef<int>(&NativePtr->FrameCountEnded);

		public ref int FrameCountPlatformEnded => ref Unsafe.AsRef<int>(&NativePtr->FrameCountPlatformEnded);

		public ref int FrameCountRendered => ref Unsafe.AsRef<int>(&NativePtr->FrameCountRendered);

		/// <summary>
		/// Set by NewFrame(), cleared by EndFrame()
		/// </summary>
		public ref bool WithinFrameScope => ref Unsafe.AsRef<bool>(&NativePtr->WithinFrameScope);

		/// <summary>
		/// Set by NewFrame(), cleared by EndFrame() when the implicit debug window has been pushed
		/// </summary>
		public ref bool WithinFrameScopeWithImplicitWindow => ref Unsafe.AsRef<bool>(&NativePtr->WithinFrameScopeWithImplicitWindow);

		/// <summary>
		/// Set within EndChild()
		/// </summary>
		public ref bool WithinEndChild => ref Unsafe.AsRef<bool>(&NativePtr->WithinEndChild);

		/// <summary>
		/// Request full GC
		/// </summary>
		public ref bool GcCompactAll => ref Unsafe.AsRef<bool>(&NativePtr->GcCompactAll);

		/// <summary>
		/// Will call test engine hooks: ImGuiTestEngineHook_ItemAdd(), ImGuiTestEngineHook_ItemInfo(), ImGuiTestEngineHook_Log()
		/// </summary>
		public ref bool TestEngineHookItems => ref Unsafe.AsRef<bool>(&NativePtr->TestEngineHookItems);

		/// <summary>
		/// Test engine user data
		/// </summary>
		public IntPtr TestEngine { get => (IntPtr)NativePtr->TestEngine; set => NativePtr->TestEngine = (void*)value; }

		/// <summary>
		/// Storage for a context name (to facilitate debugging multi-context setups)
		/// </summary>
		public RangeAccessor<byte> ContextName => new RangeAccessor<byte>(NativePtr->ContextName, 16);

		/// <summary>
		/// <para>Inputs</para>
		/// </summary>
		/// <summary>
		/// Input events which will be trickled/written into IO structure.
		/// </summary>
		public ImPtrVector<ImGuiInputEventPtr> InputEventsQueue => new ImPtrVector<ImGuiInputEventPtr>(NativePtr->InputEventsQueue, Unsafe.SizeOf<ImGuiInputEvent>());

		/// <summary>
		/// Past input events processed in NewFrame(). This is to allow domain-specific application to access e.g mouse/pen trail.
		/// </summary>
		public ImPtrVector<ImGuiInputEventPtr> InputEventsTrail => new ImPtrVector<ImGuiInputEventPtr>(NativePtr->InputEventsTrail, Unsafe.SizeOf<ImGuiInputEvent>());

		public ref ImGuiMouseSource InputEventsNextMouseSource => ref Unsafe.AsRef<ImGuiMouseSource>(&NativePtr->InputEventsNextMouseSource);

		public ref uint InputEventsNextEventId => ref Unsafe.AsRef<uint>(&NativePtr->InputEventsNextEventId);

		/// <summary>
		/// <para>Windows state</para>
		/// </summary>
		/// <summary>
		/// Windows, sorted in display order, back to front
		/// </summary>
		public ImVector<ImGuiWindowPtr> Windows => new ImVector<ImGuiWindowPtr>(NativePtr->Windows);

		/// <summary>
		/// Root windows, sorted in focus order, back to front.
		/// </summary>
		public ImVector<ImGuiWindowPtr> WindowsFocusOrder => new ImVector<ImGuiWindowPtr>(NativePtr->WindowsFocusOrder);

		/// <summary>
		/// Temporary buffer used in EndFrame() to reorder windows so parents are kept before their child
		/// </summary>
		public ImVector<ImGuiWindowPtr> WindowsTempSortBuffer => new ImVector<ImGuiWindowPtr>(NativePtr->WindowsTempSortBuffer);

		public ImPtrVector<ImGuiWindowStackDataPtr> CurrentWindowStack => new ImPtrVector<ImGuiWindowStackDataPtr>(NativePtr->CurrentWindowStack, Unsafe.SizeOf<ImGuiWindowStackData>());

		/// <summary>
		/// Map window's ImGuiID to ImGuiWindow*
		/// </summary>
		public ref ImGuiStorage WindowsById => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->WindowsById);

		/// <summary>
		/// Number of unique windows submitted by frame
		/// </summary>
		public ref int WindowsActiveCount => ref Unsafe.AsRef<int>(&NativePtr->WindowsActiveCount);

		/// <summary>
		/// Padding around resizable windows for which hovering on counts as hovering the window == ImMax(style.TouchExtraPadding, WINDOWS_HOVER_PADDING).
		/// </summary>
		public ref Vector2 WindowsHoverPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowsHoverPadding);

		/// <summary>
		/// Set to break in Begin() call.
		/// </summary>
		public ref uint DebugBreakInWindow => ref Unsafe.AsRef<uint>(&NativePtr->DebugBreakInWindow);

		/// <summary>
		/// Window being drawn into
		/// </summary>
		public ImGuiWindowPtr CurrentWindow => new ImGuiWindowPtr(NativePtr->CurrentWindow);

		/// <summary>
		/// Window the mouse is hovering. Will typically catch mouse inputs.
		/// </summary>
		public ImGuiWindowPtr HoveredWindow => new ImGuiWindowPtr(NativePtr->HoveredWindow);

		/// <summary>
		/// Hovered window ignoring MovingWindow. Only set if MovingWindow is set.
		/// </summary>
		public ImGuiWindowPtr HoveredWindowUnderMovingWindow => new ImGuiWindowPtr(NativePtr->HoveredWindowUnderMovingWindow);

		/// <summary>
		/// Window the mouse is hovering. Filled even with _NoMouse. This is currently useful for multi-context compositors.
		/// </summary>
		public ImGuiWindowPtr HoveredWindowBeforeClear => new ImGuiWindowPtr(NativePtr->HoveredWindowBeforeClear);

		/// <summary>
		/// Track the window we clicked on (in order to preserve focus). The actual window that is moved is generally MovingWindow-&gt;RootWindowDockTree.
		/// </summary>
		public ImGuiWindowPtr MovingWindow => new ImGuiWindowPtr(NativePtr->MovingWindow);

		/// <summary>
		/// Track the window we started mouse-wheeling on. Until a timer elapse or mouse has moved, generally keep scrolling the same window even if during the course of scrolling the mouse ends up hovering a child window.
		/// </summary>
		public ImGuiWindowPtr WheelingWindow => new ImGuiWindowPtr(NativePtr->WheelingWindow);

		public ref Vector2 WheelingWindowRefMousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->WheelingWindowRefMousePos);

		/// <summary>
		/// This may be set one frame before WheelingWindow is != NULL
		/// </summary>
		public ref int WheelingWindowStartFrame => ref Unsafe.AsRef<int>(&NativePtr->WheelingWindowStartFrame);

		public ref int WheelingWindowScrolledFrame => ref Unsafe.AsRef<int>(&NativePtr->WheelingWindowScrolledFrame);

		public ref float WheelingWindowReleaseTimer => ref Unsafe.AsRef<float>(&NativePtr->WheelingWindowReleaseTimer);

		public ref Vector2 WheelingWindowWheelRemainder => ref Unsafe.AsRef<Vector2>(&NativePtr->WheelingWindowWheelRemainder);

		public ref Vector2 WheelingAxisAvg => ref Unsafe.AsRef<Vector2>(&NativePtr->WheelingAxisAvg);

		/// <summary>
		/// <para>Item/widgets state and tracking information</para>
		/// </summary>
		/// <summary>
		/// Set when we detect multiple items with the same identifier
		/// </summary>
		public ref uint DebugDrawIdConflicts => ref Unsafe.AsRef<uint>(&NativePtr->DebugDrawIdConflicts);

		/// <summary>
		/// Will call core hooks: DebugHookIdInfo() from GetID functions, used by ID Stack Tool [next HoveredId/ActiveId to not pull in an extra cache-line]
		/// </summary>
		public ref uint DebugHookIdInfo => ref Unsafe.AsRef<uint>(&NativePtr->DebugHookIdInfo);

		/// <summary>
		/// Hovered widget, filled during the frame
		/// </summary>
		public ref uint HoveredId => ref Unsafe.AsRef<uint>(&NativePtr->HoveredId);

		public ref uint HoveredIdPreviousFrame => ref Unsafe.AsRef<uint>(&NativePtr->HoveredIdPreviousFrame);

		/// <summary>
		/// Count numbers of items using the same ID as last frame's hovered id
		/// </summary>
		public ref int HoveredIdPreviousFrameItemCount => ref Unsafe.AsRef<int>(&NativePtr->HoveredIdPreviousFrameItemCount);

		/// <summary>
		/// Measure contiguous hovering time
		/// </summary>
		public ref float HoveredIdTimer => ref Unsafe.AsRef<float>(&NativePtr->HoveredIdTimer);

		/// <summary>
		/// Measure contiguous hovering time where the item has not been active
		/// </summary>
		public ref float HoveredIdNotActiveTimer => ref Unsafe.AsRef<float>(&NativePtr->HoveredIdNotActiveTimer);

		public ref bool HoveredIdAllowOverlap => ref Unsafe.AsRef<bool>(&NativePtr->HoveredIdAllowOverlap);

		/// <summary>
		/// At least one widget passed the rect test, but has been discarded by disabled flag or popup inhibit. May be true even if HoveredId == 0.
		/// </summary>
		public ref bool HoveredIdIsDisabled => ref Unsafe.AsRef<bool>(&NativePtr->HoveredIdIsDisabled);

		/// <summary>
		/// Disable ItemAdd() clipping, essentially a memory-locality friendly copy of LogEnabled
		/// </summary>
		public ref bool ItemUnclipByLog => ref Unsafe.AsRef<bool>(&NativePtr->ItemUnclipByLog);

		/// <summary>
		/// Active widget
		/// </summary>
		public ref uint ActiveId => ref Unsafe.AsRef<uint>(&NativePtr->ActiveId);

		/// <summary>
		/// Active widget has been seen this frame (we can't use a bool as the ActiveId may change within the frame)
		/// </summary>
		public ref uint ActiveIdIsAlive => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdIsAlive);

		public ref float ActiveIdTimer => ref Unsafe.AsRef<float>(&NativePtr->ActiveIdTimer);

		/// <summary>
		/// Set at the time of activation for one frame
		/// </summary>
		public ref bool ActiveIdIsJustActivated => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdIsJustActivated);

		/// <summary>
		/// Active widget allows another widget to steal active id (generally for overlapping widgets, but not always)
		/// </summary>
		public ref bool ActiveIdAllowOverlap => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdAllowOverlap);

		/// <summary>
		/// Disable losing active id if the active id window gets unfocused.
		/// </summary>
		public ref bool ActiveIdNoClearOnFocusLoss => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdNoClearOnFocusLoss);

		/// <summary>
		/// Track whether the active id led to a press (this is to allow changing between PressOnClick and PressOnRelease without pressing twice). Used by range_select branch.
		/// </summary>
		public ref bool ActiveIdHasBeenPressedBefore => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdHasBeenPressedBefore);

		/// <summary>
		/// Was the value associated to the widget Edited over the course of the Active state.
		/// </summary>
		public ref bool ActiveIdHasBeenEditedBefore => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdHasBeenEditedBefore);

		public ref bool ActiveIdHasBeenEditedThisFrame => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdHasBeenEditedThisFrame);

		public ref bool ActiveIdFromShortcut => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdFromShortcut);

		public ref int ActiveIdMouseButton => ref Unsafe.AsRef<int>(&NativePtr->ActiveIdMouseButton);

		/// <summary>
		/// Clicked offset from upper-left corner, if applicable (currently only set by ButtonBehavior)
		/// </summary>
		public ref Vector2 ActiveIdClickOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->ActiveIdClickOffset);

		public ImGuiWindowPtr ActiveIdWindow => new ImGuiWindowPtr(NativePtr->ActiveIdWindow);

		/// <summary>
		/// Activating source: ImGuiInputSource_Mouse OR ImGuiInputSource_Keyboard OR ImGuiInputSource_Gamepad
		/// </summary>
		public ref ImGuiInputSource ActiveIdSource => ref Unsafe.AsRef<ImGuiInputSource>(&NativePtr->ActiveIdSource);

		public ref uint ActiveIdPreviousFrame => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdPreviousFrame);

		public ref bool ActiveIdPreviousFrameIsAlive => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdPreviousFrameIsAlive);

		public ref bool ActiveIdPreviousFrameHasBeenEditedBefore => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdPreviousFrameHasBeenEditedBefore);

		public ImGuiWindowPtr ActiveIdPreviousFrameWindow => new ImGuiWindowPtr(NativePtr->ActiveIdPreviousFrameWindow);

		/// <summary>
		/// Store the last non-zero ActiveId, useful for animation.
		/// </summary>
		public ref uint LastActiveId => ref Unsafe.AsRef<uint>(&NativePtr->LastActiveId);

		/// <summary>
		/// Store the last non-zero ActiveId timer since the beginning of activation, useful for animation.
		/// </summary>
		public ref float LastActiveIdTimer => ref Unsafe.AsRef<float>(&NativePtr->LastActiveIdTimer);

		/// <summary>
		/// <para>Key/Input Ownership + Shortcut Routing system</para>
		/// <para>- The idea is that instead of "eating" a given key, we can link to an owner.</para>
		/// <para>- Input query can then read input by specifying ImGuiKeyOwner_Any (== 0), ImGuiKeyOwner_NoOwner (== -1) or a custom ID.</para>
		/// <para>- Routing is requested ahead of time for a given chord (Key + Mods) and granted in NewFrame().</para>
		/// </summary>
		/// <summary>
		/// Record the last time key mods changed (affect repeat delay when using shortcut logic)
		/// </summary>
		public ref double LastKeyModsChangeTime => ref Unsafe.AsRef<double>(&NativePtr->LastKeyModsChangeTime);

		/// <summary>
		/// Record the last time key mods changed away from being 0 (affect repeat delay when using shortcut logic)
		/// </summary>
		public ref double LastKeyModsChangeFromNoneTime => ref Unsafe.AsRef<double>(&NativePtr->LastKeyModsChangeFromNoneTime);

		/// <summary>
		/// Record the last time a keyboard key (ignore mouse/gamepad ones) was pressed.
		/// </summary>
		public ref double LastKeyboardKeyPressTime => ref Unsafe.AsRef<double>(&NativePtr->LastKeyboardKeyPressTime);

		/// <summary>
		/// Lookup to tell if a key can emit char input, see IsKeyChordPotentiallyCharInput(). sizeof() = 20 bytes
		/// </summary>
		public ref ImBitArrayForNamedKeys KeysMayBeCharInput => ref Unsafe.AsRef<ImBitArrayForNamedKeys>(&NativePtr->KeysMayBeCharInput);

		public RangeAccessor<ImGuiKeyOwnerData> KeysOwnerData => new RangeAccessor<ImGuiKeyOwnerData>(&NativePtr->KeysOwnerData_0, 154);

		public ref ImGuiKeyRoutingTable KeysRoutingTable => ref Unsafe.AsRef<ImGuiKeyRoutingTable>(&NativePtr->KeysRoutingTable);

		/// <summary>
		/// Active widget will want to read those nav move requests (e.g. can activate a button and move away from it)
		/// </summary>
		public ref uint ActiveIdUsingNavDirMask => ref Unsafe.AsRef<uint>(&NativePtr->ActiveIdUsingNavDirMask);

		/// <summary>
		/// Active widget will want to read all keyboard keys inputs. (this is a shortcut for not taking ownership of 100+ keys, frequently used by drag operations)
		/// </summary>
		public ref bool ActiveIdUsingAllKeyboardKeys => ref Unsafe.AsRef<bool>(&NativePtr->ActiveIdUsingAllKeyboardKeys);

		/// <summary>
		/// Set to break in SetShortcutRouting()/Shortcut() calls.
		/// </summary>
		public ref ImGuiKey DebugBreakInShortcutRouting => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->DebugBreakInShortcutRouting);

		/// <summary>
		/// <para>Next window/item data</para>
		/// </summary>
		/// <summary>
		/// Value for currently appending items == g.FocusScopeStack.back(). Not to be mistaken with g.NavFocusScopeId.
		/// </summary>
		public ref uint CurrentFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->CurrentFocusScopeId);

		/// <summary>
		/// Value for currently appending items == g.ItemFlagsStack.back()
		/// </summary>
		public ref ImGuiItemFlags CurrentItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->CurrentItemFlags);

		/// <summary>
		/// Storage for DebugLocateItemOnHover() feature: this is read by ItemAdd() so we keep it in a hot/cached location
		/// </summary>
		public ref uint DebugLocateId => ref Unsafe.AsRef<uint>(&NativePtr->DebugLocateId);

		/// <summary>
		/// Storage for SetNextItem** functions
		/// </summary>
		public ref ImGuiNextItemData NextItemData => ref Unsafe.AsRef<ImGuiNextItemData>(&NativePtr->NextItemData);

		/// <summary>
		/// Storage for last submitted item (setup by ItemAdd)
		/// </summary>
		public ref ImGuiLastItemData LastItemData => ref Unsafe.AsRef<ImGuiLastItemData>(&NativePtr->LastItemData);

		/// <summary>
		/// Storage for SetNextWindow** functions
		/// </summary>
		public ref ImGuiNextWindowData NextWindowData => ref Unsafe.AsRef<ImGuiNextWindowData>(&NativePtr->NextWindowData);

		public ref bool DebugShowGroupRects => ref Unsafe.AsRef<bool>(&NativePtr->DebugShowGroupRects);

		/// <summary>
		/// <para>Shared stacks</para>
		/// </summary>
		/// <summary>
		/// (Keep close to ColorStack to share cache line)
		/// </summary>
		public ref ImGuiCol DebugFlashStyleColorIdx => ref Unsafe.AsRef<ImGuiCol>(&NativePtr->DebugFlashStyleColorIdx);

		/// <summary>
		/// Stack for PushStyleColor()/PopStyleColor() - inherited by Begin()
		/// </summary>
		public ImPtrVector<ImGuiColorModPtr> ColorStack => new ImPtrVector<ImGuiColorModPtr>(NativePtr->ColorStack, Unsafe.SizeOf<ImGuiColorMod>());

		/// <summary>
		/// Stack for PushStyleVar()/PopStyleVar() - inherited by Begin()
		/// </summary>
		public ImPtrVector<ImGuiStyleModPtr> StyleVarStack => new ImPtrVector<ImGuiStyleModPtr>(NativePtr->StyleVarStack, Unsafe.SizeOf<ImGuiStyleMod>());

		/// <summary>
		/// Stack for PushFont()/PopFont() - inherited by Begin()
		/// </summary>
		public ImVector<ImFontPtr> FontStack => new ImVector<ImFontPtr>(NativePtr->FontStack);

		/// <summary>
		/// Stack for PushFocusScope()/PopFocusScope() - inherited by BeginChild(), pushed into by Begin()
		/// </summary>
		public ImPtrVector<ImGuiFocusScopeDataPtr> FocusScopeStack => new ImPtrVector<ImGuiFocusScopeDataPtr>(NativePtr->FocusScopeStack, Unsafe.SizeOf<ImGuiFocusScopeData>());

		/// <summary>
		/// Stack for PushItemFlag()/PopItemFlag() - inherited by Begin()
		/// </summary>
		public ImVector<ImGuiItemFlags> ItemFlagsStack => new ImVector<ImGuiItemFlags>(NativePtr->ItemFlagsStack);

		/// <summary>
		/// Stack for BeginGroup()/EndGroup() - not inherited by Begin()
		/// </summary>
		public ImPtrVector<ImGuiGroupDataPtr> GroupStack => new ImPtrVector<ImGuiGroupDataPtr>(NativePtr->GroupStack, Unsafe.SizeOf<ImGuiGroupData>());

		/// <summary>
		/// Which popups are open (persistent)
		/// </summary>
		public ImPtrVector<ImGuiPopupDataPtr> OpenPopupStack => new ImPtrVector<ImGuiPopupDataPtr>(NativePtr->OpenPopupStack, Unsafe.SizeOf<ImGuiPopupData>());

		/// <summary>
		/// Which level of BeginPopup() we are in (reset every frame)
		/// </summary>
		public ImPtrVector<ImGuiPopupDataPtr> BeginPopupStack => new ImPtrVector<ImGuiPopupDataPtr>(NativePtr->BeginPopupStack, Unsafe.SizeOf<ImGuiPopupData>());

		/// <summary>
		/// Stack for TreeNode()
		/// </summary>
		public ImPtrVector<ImGuiTreeNodeStackDataPtr> TreeNodeStack => new ImPtrVector<ImGuiTreeNodeStackDataPtr>(NativePtr->TreeNodeStack, Unsafe.SizeOf<ImGuiTreeNodeStackData>());

		/// <summary>
		/// <para>Viewports</para>
		/// </summary>
		/// <summary>
		/// Active viewports (always 1+, and generally 1 unless multi-viewports are enabled). Each viewports hold their copy of ImDrawData.
		/// </summary>
		public ImVector<ImGuiViewportPPtr> Viewports => new ImVector<ImGuiViewportPPtr>(NativePtr->Viewports);

		/// <summary>
		/// We track changes of viewport (happening in Begin) so we can call Platform_OnChangedViewport()
		/// </summary>
		public ImGuiViewportPPtr CurrentViewport => new ImGuiViewportPPtr(NativePtr->CurrentViewport);

		public ImGuiViewportPPtr MouseViewport => new ImGuiViewportPPtr(NativePtr->MouseViewport);

		/// <summary>
		/// Last known viewport that was hovered by mouse (even if we are not hovering any viewport any more) + honoring the _NoInputs flag.
		/// </summary>
		public ImGuiViewportPPtr MouseLastHoveredViewport => new ImGuiViewportPPtr(NativePtr->MouseLastHoveredViewport);

		public ref uint PlatformLastFocusedViewportId => ref Unsafe.AsRef<uint>(&NativePtr->PlatformLastFocusedViewportId);

		/// <summary>
		/// Virtual monitor used as fallback if backend doesn't provide monitor information.
		/// </summary>
		public ref ImGuiPlatformMonitor FallbackMonitor => ref Unsafe.AsRef<ImGuiPlatformMonitor>(&NativePtr->FallbackMonitor);

		/// <summary>
		/// Bounding box of all platform monitors
		/// </summary>
		public ref ImRect PlatformMonitorsFullWorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->PlatformMonitorsFullWorkRect);

		/// <summary>
		/// Unique sequential creation counter (mostly for testing/debugging)
		/// </summary>
		public ref int ViewportCreatedCount => ref Unsafe.AsRef<int>(&NativePtr->ViewportCreatedCount);

		/// <summary>
		/// Unique sequential creation counter (mostly for testing/debugging)
		/// </summary>
		public ref int PlatformWindowsCreatedCount => ref Unsafe.AsRef<int>(&NativePtr->PlatformWindowsCreatedCount);

		/// <summary>
		/// Every time the front-most window changes, we stamp its viewport with an incrementing counter
		/// </summary>
		public ref int ViewportFocusedStampCount => ref Unsafe.AsRef<int>(&NativePtr->ViewportFocusedStampCount);

		/// <summary>
		/// <para>Keyboard/Gamepad Navigation</para>
		/// </summary>
		/// <summary>
		/// Nav focus cursor/rectangle is visible? We hide it after a mouse click. We show it after a nav move.
		/// </summary>
		public ref bool NavCursorVisible => ref Unsafe.AsRef<bool>(&NativePtr->NavCursorVisible);

		/// <summary>
		/// Disable mouse hovering highlight. Highlight navigation focused item instead of mouse hovered item.
		/// </summary>
		public ref bool NavHighlightItemUnderNav => ref Unsafe.AsRef<bool>(&NativePtr->NavHighlightItemUnderNav);

		/// <summary>
		/// <para>//bool                  NavDisableHighlight;                // Old name for !g.NavCursorVisible before 1.91.4 (2024/10/18). OPPOSITE VALUE (g.NavDisableHighlight == !g.NavCursorVisible)</para>
		/// <para>//bool                  NavDisableMouseHover;               // Old name for g.NavHighlightItemUnderNav before 1.91.1 (2024/10/18) this was called When user starts using keyboard/gamepad, we hide mouse hovering highlight until mouse is touched again.</para>
		/// </summary>
		/// <summary>
		/// When set we will update mouse position if io.ConfigNavMoveSetMousePos is set (not enabled by default)
		/// </summary>
		public ref bool NavMousePosDirty => ref Unsafe.AsRef<bool>(&NativePtr->NavMousePosDirty);

		/// <summary>
		/// Nav widget has been seen this frame ~~ NavRectRel is valid
		/// </summary>
		public ref bool NavIdIsAlive => ref Unsafe.AsRef<bool>(&NativePtr->NavIdIsAlive);

		/// <summary>
		/// Focused item for navigation
		/// </summary>
		public ref uint NavId => ref Unsafe.AsRef<uint>(&NativePtr->NavId);

		/// <summary>
		/// Focused window for navigation. Could be called 'FocusedWindow'
		/// </summary>
		public ImGuiWindowPtr NavWindow => new ImGuiWindowPtr(NativePtr->NavWindow);

		/// <summary>
		/// Focused focus scope (e.g. selection code often wants to "clear other items" when landing on an item of the same scope)
		/// </summary>
		public ref uint NavFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavFocusScopeId);

		/// <summary>
		/// Focused layer (main scrolling layer, or menu/title bar layer)
		/// </summary>
		public ref ImGuiNavLayer NavLayer => ref Unsafe.AsRef<ImGuiNavLayer>(&NativePtr->NavLayer);

		/// <summary>
		/// ~~ (g.ActiveId == 0) &amp;&amp; (IsKeyPressed(ImGuiKey_Space) || IsKeyDown(ImGuiKey_Enter) || IsKeyPressed(ImGuiKey_NavGamepadActivate)) ? NavId : 0, also set when calling ActivateItem()
		/// </summary>
		public ref uint NavActivateId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivateId);

		/// <summary>
		/// ~~ IsKeyDown(ImGuiKey_Space) || IsKeyDown(ImGuiKey_Enter) || IsKeyDown(ImGuiKey_NavGamepadActivate) ? NavId : 0
		/// </summary>
		public ref uint NavActivateDownId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivateDownId);

		/// <summary>
		/// ~~ IsKeyPressed(ImGuiKey_Space) || IsKeyPressed(ImGuiKey_Enter) || IsKeyPressed(ImGuiKey_NavGamepadActivate) ? NavId : 0 (no repeat)
		/// </summary>
		public ref uint NavActivatePressedId => ref Unsafe.AsRef<uint>(&NativePtr->NavActivatePressedId);

		public ref ImGuiActivateFlags NavActivateFlags => ref Unsafe.AsRef<ImGuiActivateFlags>(&NativePtr->NavActivateFlags);

		/// <summary>
		/// Reversed copy focus scope stack for NavId (should contains NavFocusScopeId). This essentially follow the window-&gt;ParentWindowForFocusRoute chain.
		/// </summary>
		public ImPtrVector<ImGuiFocusScopeDataPtr> NavFocusRoute => new ImPtrVector<ImGuiFocusScopeDataPtr>(NativePtr->NavFocusRoute, Unsafe.SizeOf<ImGuiFocusScopeData>());

		public ref uint NavHighlightActivatedId => ref Unsafe.AsRef<uint>(&NativePtr->NavHighlightActivatedId);

		public ref float NavHighlightActivatedTimer => ref Unsafe.AsRef<float>(&NativePtr->NavHighlightActivatedTimer);

		/// <summary>
		/// Set by ActivateItem(), queued until next frame.
		/// </summary>
		public ref uint NavNextActivateId => ref Unsafe.AsRef<uint>(&NativePtr->NavNextActivateId);

		public ref ImGuiActivateFlags NavNextActivateFlags => ref Unsafe.AsRef<ImGuiActivateFlags>(&NativePtr->NavNextActivateFlags);

		/// <summary>
		/// Keyboard or Gamepad mode? THIS CAN ONLY BE ImGuiInputSource_Keyboard or ImGuiInputSource_Mouse
		/// </summary>
		public ref ImGuiInputSource NavInputSource => ref Unsafe.AsRef<ImGuiInputSource>(&NativePtr->NavInputSource);

		/// <summary>
		/// Last valid data passed to SetNextItemSelectionUser(), or -1. For current window. Not reset when focusing an item that doesn't have selection data.
		/// </summary>
		public ref long NavLastValidSelectionUserData => ref Unsafe.AsRef<long>(&NativePtr->NavLastValidSelectionUserData);

		public ref sbyte NavCursorHideFrames => ref Unsafe.AsRef<sbyte>(&NativePtr->NavCursorHideFrames);

		/// <summary>
		/// <para>Navigation: Init &amp; Move Requests</para>
		/// </summary>
		/// <summary>
		/// ~~ NavMoveRequest || NavInitRequest this is to perform early out in ItemAdd()
		/// </summary>
		public ref bool NavAnyRequest => ref Unsafe.AsRef<bool>(&NativePtr->NavAnyRequest);

		/// <summary>
		/// Init request for appearing window to select first item
		/// </summary>
		public ref bool NavInitRequest => ref Unsafe.AsRef<bool>(&NativePtr->NavInitRequest);

		public ref bool NavInitRequestFromMove => ref Unsafe.AsRef<bool>(&NativePtr->NavInitRequestFromMove);

		/// <summary>
		/// Init request result (first item of the window, or one for which SetItemDefaultFocus() was called)
		/// </summary>
		public ref ImGuiNavItemData NavInitResult => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavInitResult);

		/// <summary>
		/// Move request submitted, will process result on next NewFrame()
		/// </summary>
		public ref bool NavMoveSubmitted => ref Unsafe.AsRef<bool>(&NativePtr->NavMoveSubmitted);

		/// <summary>
		/// Move request submitted, still scoring incoming items
		/// </summary>
		public ref bool NavMoveScoringItems => ref Unsafe.AsRef<bool>(&NativePtr->NavMoveScoringItems);

		public ref bool NavMoveForwardToNextFrame => ref Unsafe.AsRef<bool>(&NativePtr->NavMoveForwardToNextFrame);

		public ref ImGuiNavMoveFlags NavMoveFlags => ref Unsafe.AsRef<ImGuiNavMoveFlags>(&NativePtr->NavMoveFlags);

		public ref ImGuiScrollFlags NavMoveScrollFlags => ref Unsafe.AsRef<ImGuiScrollFlags>(&NativePtr->NavMoveScrollFlags);

		public ref ImGuiKey NavMoveKeyMods => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->NavMoveKeyMods);

		/// <summary>
		/// Direction of the move request (left/right/up/down)
		/// </summary>
		public ref ImGuiDir NavMoveDir => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->NavMoveDir);

		public ref ImGuiDir NavMoveDirForDebug => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->NavMoveDirForDebug);

		/// <summary>
		/// FIXME-NAV: Describe the purpose of this better. Might want to rename?
		/// </summary>
		public ref ImGuiDir NavMoveClipDir => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->NavMoveClipDir);

		/// <summary>
		/// Rectangle used for scoring, in screen space. Based of window-&gt;NavRectRel[], modified for directional navigation scoring.
		/// </summary>
		public ref ImRect NavScoringRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavScoringRect);

		/// <summary>
		/// Some nav operations (such as PageUp/PageDown) enforce a region which clipper will attempt to always keep submitted
		/// </summary>
		public ref ImRect NavScoringNoClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavScoringNoClipRect);

		/// <summary>
		/// Metrics for debugging
		/// </summary>
		public ref int NavScoringDebugCount => ref Unsafe.AsRef<int>(&NativePtr->NavScoringDebugCount);

		/// <summary>
		/// Generally -1 or +1, 0 when tabbing without a nav id
		/// </summary>
		public ref int NavTabbingDir => ref Unsafe.AsRef<int>(&NativePtr->NavTabbingDir);

		/// <summary>
		/// &gt;0 when counting items for tabbing
		/// </summary>
		public ref int NavTabbingCounter => ref Unsafe.AsRef<int>(&NativePtr->NavTabbingCounter);

		/// <summary>
		/// Best move request candidate within NavWindow
		/// </summary>
		public ref ImGuiNavItemData NavMoveResultLocal => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavMoveResultLocal);

		/// <summary>
		/// Best move request candidate within NavWindow that are mostly visible (when using ImGuiNavMoveFlags_AlsoScoreVisibleSet flag)
		/// </summary>
		public ref ImGuiNavItemData NavMoveResultLocalVisible => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavMoveResultLocalVisible);

		/// <summary>
		/// Best move request candidate within NavWindow's flattened hierarchy (when using ImGuiWindowFlags_NavFlattened flag)
		/// </summary>
		public ref ImGuiNavItemData NavMoveResultOther => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavMoveResultOther);

		/// <summary>
		/// First tabbing request candidate within NavWindow and flattened hierarchy
		/// </summary>
		public ref ImGuiNavItemData NavTabbingResultFirst => ref Unsafe.AsRef<ImGuiNavItemData>(&NativePtr->NavTabbingResultFirst);

		/// <summary>
		/// <para>Navigation: record of last move request</para>
		/// </summary>
		/// <summary>
		/// Just navigated from this focus scope id (result of a successfully MoveRequest).
		/// </summary>
		public ref uint NavJustMovedFromFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavJustMovedFromFocusScopeId);

		/// <summary>
		/// Just navigated to this id (result of a successfully MoveRequest).
		/// </summary>
		public ref uint NavJustMovedToId => ref Unsafe.AsRef<uint>(&NativePtr->NavJustMovedToId);

		/// <summary>
		/// Just navigated to this focus scope id (result of a successfully MoveRequest).
		/// </summary>
		public ref uint NavJustMovedToFocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->NavJustMovedToFocusScopeId);

		public ref ImGuiKey NavJustMovedToKeyMods => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->NavJustMovedToKeyMods);

		/// <summary>
		/// Copy of ImGuiNavMoveFlags_IsTabbing. Maybe we should store whole flags.
		/// </summary>
		public ref bool NavJustMovedToIsTabbing => ref Unsafe.AsRef<bool>(&NativePtr->NavJustMovedToIsTabbing);

		/// <summary>
		/// Copy of move result's ItemFlags &amp; ImGuiItemFlags_HasSelectionUserData). Maybe we should just store ImGuiNavItemData.
		/// </summary>
		public ref bool NavJustMovedToHasSelectionData => ref Unsafe.AsRef<bool>(&NativePtr->NavJustMovedToHasSelectionData);

		/// <summary>
		/// <para>Navigation: Windowing (CTRL+TAB for list, or Menu button + keys or directional pads to move/resize)</para>
		/// </summary>
		/// <summary>
		/// = ImGuiMod_Ctrl | ImGuiKey_Tab (or ImGuiMod_Super | ImGuiKey_Tab on OS X). For reconfiguration (see #4828)
		/// </summary>
		public ref ImGuiKey ConfigNavWindowingKeyNext => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->ConfigNavWindowingKeyNext);

		/// <summary>
		/// = ImGuiMod_Ctrl | ImGuiMod_Shift | ImGuiKey_Tab (or ImGuiMod_Super | ImGuiMod_Shift | ImGuiKey_Tab on OS X)
		/// </summary>
		public ref ImGuiKey ConfigNavWindowingKeyPrev => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->ConfigNavWindowingKeyPrev);

		/// <summary>
		/// Target window when doing CTRL+Tab (or Pad Menu + FocusPrev/Next), this window is temporarily displayed top-most!
		/// </summary>
		public ImGuiWindowPtr NavWindowingTarget => new ImGuiWindowPtr(NativePtr->NavWindowingTarget);

		/// <summary>
		/// Record of last valid NavWindowingTarget until DimBgRatio and NavWindowingHighlightAlpha becomes 0.0f, so the fade-out can stay on it.
		/// </summary>
		public ImGuiWindowPtr NavWindowingTargetAnim => new ImGuiWindowPtr(NativePtr->NavWindowingTargetAnim);

		/// <summary>
		/// Internal window actually listing the CTRL+Tab contents
		/// </summary>
		public ImGuiWindowPtr NavWindowingListWindow => new ImGuiWindowPtr(NativePtr->NavWindowingListWindow);

		public ref float NavWindowingTimer => ref Unsafe.AsRef<float>(&NativePtr->NavWindowingTimer);

		public ref float NavWindowingHighlightAlpha => ref Unsafe.AsRef<float>(&NativePtr->NavWindowingHighlightAlpha);

		public ref bool NavWindowingToggleLayer => ref Unsafe.AsRef<bool>(&NativePtr->NavWindowingToggleLayer);

		public ref ImGuiKey NavWindowingToggleKey => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->NavWindowingToggleKey);

		public ref Vector2 NavWindowingAccumDeltaPos => ref Unsafe.AsRef<Vector2>(&NativePtr->NavWindowingAccumDeltaPos);

		public ref Vector2 NavWindowingAccumDeltaSize => ref Unsafe.AsRef<Vector2>(&NativePtr->NavWindowingAccumDeltaSize);

		/// <summary>
		/// <para>Render</para>
		/// </summary>
		/// <summary>
		/// 0.0..1.0 animation when fading in a dimming background (for modal window and CTRL+TAB list)
		/// </summary>
		public ref float DimBgRatio => ref Unsafe.AsRef<float>(&NativePtr->DimBgRatio);

		/// <summary>
		/// <para>Drag and Drop</para>
		/// </summary>
		public ref bool DragDropActive => ref Unsafe.AsRef<bool>(&NativePtr->DragDropActive);

		/// <summary>
		/// Set when within a BeginDragDropXXX/EndDragDropXXX block for a drag source.
		/// </summary>
		public ref bool DragDropWithinSource => ref Unsafe.AsRef<bool>(&NativePtr->DragDropWithinSource);

		/// <summary>
		/// Set when within a BeginDragDropXXX/EndDragDropXXX block for a drag target.
		/// </summary>
		public ref bool DragDropWithinTarget => ref Unsafe.AsRef<bool>(&NativePtr->DragDropWithinTarget);

		public ref ImGuiDragDropFlags DragDropSourceFlags => ref Unsafe.AsRef<ImGuiDragDropFlags>(&NativePtr->DragDropSourceFlags);

		public ref int DragDropSourceFrameCount => ref Unsafe.AsRef<int>(&NativePtr->DragDropSourceFrameCount);

		public ref int DragDropMouseButton => ref Unsafe.AsRef<int>(&NativePtr->DragDropMouseButton);

		public ref ImGuiPayload DragDropPayload => ref Unsafe.AsRef<ImGuiPayload>(&NativePtr->DragDropPayload);

		/// <summary>
		/// Store rectangle of current target candidate (we favor small targets when overlapping)
		/// </summary>
		public ref ImRect DragDropTargetRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DragDropTargetRect);

		/// <summary>
		/// Store ClipRect at the time of item's drawing
		/// </summary>
		public ref ImRect DragDropTargetClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DragDropTargetClipRect);

		public ref uint DragDropTargetId => ref Unsafe.AsRef<uint>(&NativePtr->DragDropTargetId);

		public ref ImGuiDragDropFlags DragDropAcceptFlags => ref Unsafe.AsRef<ImGuiDragDropFlags>(&NativePtr->DragDropAcceptFlags);

		/// <summary>
		/// Target item surface (we resolve overlapping targets by prioritizing the smaller surface)
		/// </summary>
		public ref float DragDropAcceptIdCurrRectSurface => ref Unsafe.AsRef<float>(&NativePtr->DragDropAcceptIdCurrRectSurface);

		/// <summary>
		/// Target item id (set at the time of accepting the payload)
		/// </summary>
		public ref uint DragDropAcceptIdCurr => ref Unsafe.AsRef<uint>(&NativePtr->DragDropAcceptIdCurr);

		/// <summary>
		/// Target item id from previous frame (we need to store this to allow for overlapping drag and drop targets)
		/// </summary>
		public ref uint DragDropAcceptIdPrev => ref Unsafe.AsRef<uint>(&NativePtr->DragDropAcceptIdPrev);

		/// <summary>
		/// Last time a target expressed a desire to accept the source
		/// </summary>
		public ref int DragDropAcceptFrameCount => ref Unsafe.AsRef<int>(&NativePtr->DragDropAcceptFrameCount);

		/// <summary>
		/// Set when holding a payload just made ButtonBehavior() return a press.
		/// </summary>
		public ref uint DragDropHoldJustPressedId => ref Unsafe.AsRef<uint>(&NativePtr->DragDropHoldJustPressedId);

		/// <summary>
		/// We don't expose the ImVector&lt;&gt; directly, ImGuiPayload only holds pointer+size
		/// </summary>
		public ImVector<byte> DragDropPayloadBufHeap => new ImVector<byte>(NativePtr->DragDropPayloadBufHeap);

		/// <summary>
		/// Local buffer for small payloads
		/// </summary>
		public RangeAccessor<byte> DragDropPayloadBufLocal => new RangeAccessor<byte>(NativePtr->DragDropPayloadBufLocal, 16);

		/// <summary>
		/// <para>Clipper</para>
		/// </summary>
		public ref int ClipperTempDataStacked => ref Unsafe.AsRef<int>(&NativePtr->ClipperTempDataStacked);

		public ImPtrVector<ImGuiListClipperDataPtr> ClipperTempData => new ImPtrVector<ImGuiListClipperDataPtr>(NativePtr->ClipperTempData, Unsafe.SizeOf<ImGuiListClipperData>());

		/// <summary>
		/// <para>Tables</para>
		/// </summary>
		public ImGuiTablePtr CurrentTable => new ImGuiTablePtr(NativePtr->CurrentTable);

		/// <summary>
		/// Set to break in BeginTable() call.
		/// </summary>
		public ref uint DebugBreakInTable => ref Unsafe.AsRef<uint>(&NativePtr->DebugBreakInTable);

		/// <summary>
		/// Temporary table data size (because we leave previous instances undestructed, we generally don't use TablesTempData.Size)
		/// </summary>
		public ref int TablesTempDataStacked => ref Unsafe.AsRef<int>(&NativePtr->TablesTempDataStacked);

		/// <summary>
		/// Temporary table data (buffers reused/shared across instances, support nesting)
		/// </summary>
		public ImPtrVector<ImGuiTableTempDataPtr> TablesTempData => new ImPtrVector<ImGuiTableTempDataPtr>(NativePtr->TablesTempData, Unsafe.SizeOf<ImGuiTableTempData>());

		/// <summary>
		/// Persistent table data
		/// </summary>
		public ref ImGuiTable Tables => ref Unsafe.AsRef<ImGuiTable>(&NativePtr->Tables);

		/// <summary>
		/// Last used timestamp of each tables (SOA, for efficient GC)
		/// </summary>
		public ImVector<float> TablesLastTimeActive => new ImVector<float>(NativePtr->TablesLastTimeActive);

		public ImPtrVector<ImDrawChannelPtr> DrawChannelsTempMergeBuffer => new ImPtrVector<ImDrawChannelPtr>(NativePtr->DrawChannelsTempMergeBuffer, Unsafe.SizeOf<ImDrawChannel>());

		/// <summary>
		/// <para>Tab bars</para>
		/// </summary>
		public ImGuiTabBarPtr CurrentTabBar => new ImGuiTabBarPtr(NativePtr->CurrentTabBar);

		public ref ImGuiTabBar TabBars => ref Unsafe.AsRef<ImGuiTabBar>(&NativePtr->TabBars);

		public ImPtrVector<ImGuiPtrOrIndexPtr> CurrentTabBarStack => new ImPtrVector<ImGuiPtrOrIndexPtr>(NativePtr->CurrentTabBarStack, Unsafe.SizeOf<ImGuiPtrOrIndex>());

		public ImPtrVector<ImGuiShrinkWidthItemPtr> ShrinkWidthBuffer => new ImPtrVector<ImGuiShrinkWidthItemPtr>(NativePtr->ShrinkWidthBuffer, Unsafe.SizeOf<ImGuiShrinkWidthItem>());

		/// <summary>
		/// <para>Multi-Select state</para>
		/// </summary>
		public ref ImGuiBoxSelectState BoxSelectState => ref Unsafe.AsRef<ImGuiBoxSelectState>(&NativePtr->BoxSelectState);

		public ImGuiMultiSelectTempDataPtr CurrentMultiSelect => new ImGuiMultiSelectTempDataPtr(NativePtr->CurrentMultiSelect);

		/// <summary>
		/// Temporary multi-select data size (because we leave previous instances undestructed, we generally don't use MultiSelectTempData.Size)
		/// </summary>
		public ref int MultiSelectTempDataStacked => ref Unsafe.AsRef<int>(&NativePtr->MultiSelectTempDataStacked);

		public ImPtrVector<ImGuiMultiSelectTempDataPtr> MultiSelectTempData => new ImPtrVector<ImGuiMultiSelectTempDataPtr>(NativePtr->MultiSelectTempData, Unsafe.SizeOf<ImGuiMultiSelectTempData>());

		public ref ImGuiMultiSelectState MultiSelectStorage => ref Unsafe.AsRef<ImGuiMultiSelectState>(&NativePtr->MultiSelectStorage);

		/// <summary>
		/// <para>Hover Delay system</para>
		/// </summary>
		public ref uint HoverItemDelayId => ref Unsafe.AsRef<uint>(&NativePtr->HoverItemDelayId);

		public ref uint HoverItemDelayIdPreviousFrame => ref Unsafe.AsRef<uint>(&NativePtr->HoverItemDelayIdPreviousFrame);

		/// <summary>
		/// Currently used by IsItemHovered()
		/// </summary>
		public ref float HoverItemDelayTimer => ref Unsafe.AsRef<float>(&NativePtr->HoverItemDelayTimer);

		/// <summary>
		/// Currently used by IsItemHovered(): grace time before g.TooltipHoverTimer gets cleared.
		/// </summary>
		public ref float HoverItemDelayClearTimer => ref Unsafe.AsRef<float>(&NativePtr->HoverItemDelayClearTimer);

		/// <summary>
		/// Mouse has once been stationary on this item. Only reset after departing the item.
		/// </summary>
		public ref uint HoverItemUnlockedStationaryId => ref Unsafe.AsRef<uint>(&NativePtr->HoverItemUnlockedStationaryId);

		/// <summary>
		/// Mouse has once been stationary on this window. Only reset after departing the window.
		/// </summary>
		public ref uint HoverWindowUnlockedStationaryId => ref Unsafe.AsRef<uint>(&NativePtr->HoverWindowUnlockedStationaryId);

		/// <summary>
		/// <para>Mouse state</para>
		/// </summary>
		public ref ImGuiMouseCursor MouseCursor => ref Unsafe.AsRef<ImGuiMouseCursor>(&NativePtr->MouseCursor);

		/// <summary>
		/// Time the mouse has been stationary (with some loose heuristic)
		/// </summary>
		public ref float MouseStationaryTimer => ref Unsafe.AsRef<float>(&NativePtr->MouseStationaryTimer);

		public ref Vector2 MouseLastValidPos => ref Unsafe.AsRef<Vector2>(&NativePtr->MouseLastValidPos);

		/// <summary>
		/// <para>Widget state</para>
		/// </summary>
		public ref ImGuiInputTextState InputTextState => ref Unsafe.AsRef<ImGuiInputTextState>(&NativePtr->InputTextState);

		public ref ImGuiInputTextDeactivatedState InputTextDeactivatedState => ref Unsafe.AsRef<ImGuiInputTextDeactivatedState>(&NativePtr->InputTextDeactivatedState);

		public ref ImFont InputTextPasswordFont => ref Unsafe.AsRef<ImFont>(&NativePtr->InputTextPasswordFont);

		/// <summary>
		/// Temporary text input when CTRL+clicking on a slider, etc.
		/// </summary>
		public ref uint TempInputId => ref Unsafe.AsRef<uint>(&NativePtr->TempInputId);

		/// <summary>
		/// 0 for all data types
		/// </summary>
		public ref ImGuiDataTypeStorage DataTypeZeroValue => ref Unsafe.AsRef<ImGuiDataTypeStorage>(&NativePtr->DataTypeZeroValue);

		public ref int BeginMenuDepth => ref Unsafe.AsRef<int>(&NativePtr->BeginMenuDepth);

		public ref int BeginComboDepth => ref Unsafe.AsRef<int>(&NativePtr->BeginComboDepth);

		/// <summary>
		/// Store user options for color edit widgets
		/// </summary>
		public ref ImGuiColorEditFlags ColorEditOptions => ref Unsafe.AsRef<ImGuiColorEditFlags>(&NativePtr->ColorEditOptions);

		/// <summary>
		/// Set temporarily while inside of the parent-most ColorEdit4/ColorPicker4 (because they call each others).
		/// </summary>
		public ref uint ColorEditCurrentID => ref Unsafe.AsRef<uint>(&NativePtr->ColorEditCurrentID);

		/// <summary>
		/// ID we are saving/restoring HS for
		/// </summary>
		public ref uint ColorEditSavedID => ref Unsafe.AsRef<uint>(&NativePtr->ColorEditSavedID);

		/// <summary>
		/// Backup of last Hue associated to LastColor, so we can restore Hue in lossy RGB&lt;&gt;HSV round trips
		/// </summary>
		public ref float ColorEditSavedHue => ref Unsafe.AsRef<float>(&NativePtr->ColorEditSavedHue);

		/// <summary>
		/// Backup of last Saturation associated to LastColor, so we can restore Saturation in lossy RGB&lt;&gt;HSV round trips
		/// </summary>
		public ref float ColorEditSavedSat => ref Unsafe.AsRef<float>(&NativePtr->ColorEditSavedSat);

		/// <summary>
		/// RGB value with alpha set to 0.
		/// </summary>
		public ref uint ColorEditSavedColor => ref Unsafe.AsRef<uint>(&NativePtr->ColorEditSavedColor);

		/// <summary>
		/// Initial/reference color at the time of opening the color picker.
		/// </summary>
		public ref Vector4 ColorPickerRef => ref Unsafe.AsRef<Vector4>(&NativePtr->ColorPickerRef);

		public ref ImGuiComboPreviewData ComboPreviewData => ref Unsafe.AsRef<ImGuiComboPreviewData>(&NativePtr->ComboPreviewData);

		/// <summary>
		/// Expected border rect, switch to relative edit if moving
		/// </summary>
		public ref ImRect WindowResizeBorderExpectedRect => ref Unsafe.AsRef<ImRect>(&NativePtr->WindowResizeBorderExpectedRect);

		public ref bool WindowResizeRelativeMode => ref Unsafe.AsRef<bool>(&NativePtr->WindowResizeRelativeMode);

		/// <summary>
		/// 0: scroll to clicked location, -1/+1: prev/next page.
		/// </summary>
		public ref short ScrollbarSeekMode => ref Unsafe.AsRef<short>(&NativePtr->ScrollbarSeekMode);

		/// <summary>
		/// When scrolling to mouse location: distance between mouse and center of grab box, normalized in parent space.
		/// </summary>
		public ref float ScrollbarClickDeltaToGrabCenter => ref Unsafe.AsRef<float>(&NativePtr->ScrollbarClickDeltaToGrabCenter);

		public ref float SliderGrabClickOffset => ref Unsafe.AsRef<float>(&NativePtr->SliderGrabClickOffset);

		/// <summary>
		/// Accumulated slider delta when using navigation controls.
		/// </summary>
		public ref float SliderCurrentAccum => ref Unsafe.AsRef<float>(&NativePtr->SliderCurrentAccum);

		/// <summary>
		/// Has the accumulated slider delta changed since last time we tried to apply it?
		/// </summary>
		public ref bool SliderCurrentAccumDirty => ref Unsafe.AsRef<bool>(&NativePtr->SliderCurrentAccumDirty);

		public ref bool DragCurrentAccumDirty => ref Unsafe.AsRef<bool>(&NativePtr->DragCurrentAccumDirty);

		/// <summary>
		/// Accumulator for dragging modification. Always high-precision, not rounded by end-user precision settings
		/// </summary>
		public ref float DragCurrentAccum => ref Unsafe.AsRef<float>(&NativePtr->DragCurrentAccum);

		/// <summary>
		/// If speed == 0.0f, uses (max-min) * DragSpeedDefaultRatio
		/// </summary>
		public ref float DragSpeedDefaultRatio => ref Unsafe.AsRef<float>(&NativePtr->DragSpeedDefaultRatio);

		/// <summary>
		/// Backup for style.Alpha for BeginDisabled()
		/// </summary>
		public ref float DisabledAlphaBackup => ref Unsafe.AsRef<float>(&NativePtr->DisabledAlphaBackup);

		public ref short DisabledStackSize => ref Unsafe.AsRef<short>(&NativePtr->DisabledStackSize);

		public ref short TooltipOverrideCount => ref Unsafe.AsRef<short>(&NativePtr->TooltipOverrideCount);

		/// <summary>
		/// Window of last tooltip submitted during the frame
		/// </summary>
		public ImGuiWindowPtr TooltipPreviousWindow => new ImGuiWindowPtr(NativePtr->TooltipPreviousWindow);

		/// <summary>
		/// If no custom clipboard handler is defined
		/// </summary>
		public ImVector<byte> ClipboardHandlerData => new ImVector<byte>(NativePtr->ClipboardHandlerData);

		/// <summary>
		/// A list of menu IDs that were rendered at least once
		/// </summary>
		public ImVector<uint> MenusIdSubmittedThisFrame => new ImVector<uint>(NativePtr->MenusIdSubmittedThisFrame);

		/// <summary>
		/// State for GetTypingSelectRequest()
		/// </summary>
		public ref ImGuiTypingSelectState TypingSelectState => ref Unsafe.AsRef<ImGuiTypingSelectState>(&NativePtr->TypingSelectState);

		/// <summary>
		/// <para>Platform support</para>
		/// </summary>
		/// <summary>
		/// Data updated by current frame
		/// </summary>
		public ref ImGuiPlatformImeData PlatformImeData => ref Unsafe.AsRef<ImGuiPlatformImeData>(&NativePtr->PlatformImeData);

		/// <summary>
		/// Previous frame data. When changed we call the platform_io.Platform_SetImeDataFn() handler.
		/// </summary>
		public ref ImGuiPlatformImeData PlatformImeDataPrev => ref Unsafe.AsRef<ImGuiPlatformImeData>(&NativePtr->PlatformImeDataPrev);

		public ref uint PlatformImeViewport => ref Unsafe.AsRef<uint>(&NativePtr->PlatformImeViewport);

		/// <summary>
		/// <para>Extensions</para>
		/// <para>FIXME: We could provide an API to register one slot in an array held in ImGuiContext?</para>
		/// </summary>
		public ref ImGuiDockContext DockContext => ref Unsafe.AsRef<ImGuiDockContext>(&NativePtr->DockContext);

		public DockNodeWindowMenuHandlerDelegate DockNodeWindowMenuHandler
		{
			get => (DockNodeWindowMenuHandlerDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->DockNodeWindowMenuHandler, typeof(DockNodeWindowMenuHandlerDelegate));
			set => NativePtr->DockNodeWindowMenuHandler = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// <para>Settings</para>
		/// </summary>
		public ref bool SettingsLoaded => ref Unsafe.AsRef<bool>(&NativePtr->SettingsLoaded);

		/// <summary>
		/// Save .ini Settings to memory when time reaches zero
		/// </summary>
		public ref float SettingsDirtyTimer => ref Unsafe.AsRef<float>(&NativePtr->SettingsDirtyTimer);

		/// <summary>
		/// In memory .ini settings
		/// </summary>
		public ref ImGuiTextBuffer SettingsIniData => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->SettingsIniData);

		/// <summary>
		/// List of .ini settings handlers
		/// </summary>
		public ImPtrVector<ImGuiSettingsHandlerPtr> SettingsHandlers => new ImPtrVector<ImGuiSettingsHandlerPtr>(NativePtr->SettingsHandlers, Unsafe.SizeOf<ImGuiSettingsHandler>());

		/// <summary>
		/// ImGuiWindow .ini settings entries
		/// </summary>
		public ref ImGuiWindowSettings SettingsWindows => ref Unsafe.AsRef<ImGuiWindowSettings>(&NativePtr->SettingsWindows);

		/// <summary>
		/// ImGuiTable .ini settings entries
		/// </summary>
		public ref ImGuiTableSettings SettingsTables => ref Unsafe.AsRef<ImGuiTableSettings>(&NativePtr->SettingsTables);

		/// <summary>
		/// Hooks for extensions (e.g. test engine)
		/// </summary>
		public ImPtrVector<ImGuiContextHookPtr> Hooks => new ImPtrVector<ImGuiContextHookPtr>(NativePtr->Hooks, Unsafe.SizeOf<ImGuiContextHook>());

		/// <summary>
		/// Next available HookId
		/// </summary>
		public ref uint HookIdNext => ref Unsafe.AsRef<uint>(&NativePtr->HookIdNext);

		/// <summary>
		/// <para>Localization</para>
		/// </summary>
		public RangeAccessor<byte> LocalizationTable => new RangeAccessor<byte>(&NativePtr->LocalizationTable_0, 13);

		/// <summary>
		/// <para>Capture/Logging</para>
		/// </summary>
		/// <summary>
		/// Currently capturing
		/// </summary>
		public ref bool LogEnabled => ref Unsafe.AsRef<bool>(&NativePtr->LogEnabled);

		/// <summary>
		/// Capture flags/type
		/// </summary>
		public ref ImGuiLogFlags LogFlags => ref Unsafe.AsRef<ImGuiLogFlags>(&NativePtr->LogFlags);

		public ImGuiWindowPtr LogWindow => new ImGuiWindowPtr(NativePtr->LogWindow);

		/// <summary>
		/// If != NULL log to stdout/ file
		/// </summary>
		public ref IntPtr LogFile => ref Unsafe.AsRef<IntPtr>(&NativePtr->LogFile);

		/// <summary>
		/// Accumulation buffer when log to clipboard. This is pointer so our GImGui static constructor doesn't call heap allocators.
		/// </summary>
		public ref ImGuiTextBuffer LogBuffer => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->LogBuffer);

		public IntPtr LogNextPrefix { get => (IntPtr)NativePtr->LogNextPrefix; set => NativePtr->LogNextPrefix = (byte*)value; }

		public IntPtr LogNextSuffix { get => (IntPtr)NativePtr->LogNextSuffix; set => NativePtr->LogNextSuffix = (byte*)value; }

		public ref float LogLinePosY => ref Unsafe.AsRef<float>(&NativePtr->LogLinePosY);

		public ref bool LogLineFirstItem => ref Unsafe.AsRef<bool>(&NativePtr->LogLineFirstItem);

		public ref int LogDepthRef => ref Unsafe.AsRef<int>(&NativePtr->LogDepthRef);

		public ref int LogDepthToExpand => ref Unsafe.AsRef<int>(&NativePtr->LogDepthToExpand);

		/// <summary>
		/// Default/stored value for LogDepthMaxExpand if not specified in the LogXXX function call.
		/// </summary>
		public ref int LogDepthToExpandDefault => ref Unsafe.AsRef<int>(&NativePtr->LogDepthToExpandDefault);

		/// <summary>
		/// <para>Error Handling</para>
		/// </summary>
		/// <summary>
		/// = NULL. May be exposed in public API eventually.
		/// </summary>
		public ref ImGuiErrorCallback ErrorCallback => ref Unsafe.AsRef<ImGuiErrorCallback>(&NativePtr->ErrorCallback);

		/// <summary>
		/// = NULL
		/// </summary>
		public IntPtr ErrorCallbackUserData { get => (IntPtr)NativePtr->ErrorCallbackUserData; set => NativePtr->ErrorCallbackUserData = (void*)value; }

		public ref Vector2 ErrorTooltipLockedPos => ref Unsafe.AsRef<Vector2>(&NativePtr->ErrorTooltipLockedPos);

		public ref bool ErrorFirst => ref Unsafe.AsRef<bool>(&NativePtr->ErrorFirst);

		/// <summary>
		/// [Internal] Number of errors submitted this frame.
		/// </summary>
		public ref int ErrorCountCurrentFrame => ref Unsafe.AsRef<int>(&NativePtr->ErrorCountCurrentFrame);

		/// <summary>
		/// [Internal]
		/// </summary>
		public ref ImGuiErrorRecoveryState StackSizesInNewFrame => ref Unsafe.AsRef<ImGuiErrorRecoveryState>(&NativePtr->StackSizesInNewFrame);

		/// <summary>
		/// [Internal]
		/// </summary>
		public ImGuiErrorRecoveryStatePtr StackSizesInBeginForCurrentWindow => new ImGuiErrorRecoveryStatePtr(NativePtr->StackSizesInBeginForCurrentWindow);

		/// <summary>
		/// <para>Debug Tools</para>
		/// <para>(some of the highly frequently used data are interleaved in other structures above: DebugBreakXXX fields, DebugHookIdInfo, DebugLocateId etc.)</para>
		/// </summary>
		/// <summary>
		/// Locked count (preserved when holding CTRL)
		/// </summary>
		public ref int DebugDrawIdConflictsCount => ref Unsafe.AsRef<int>(&NativePtr->DebugDrawIdConflictsCount);

		public ref ImGuiDebugLogFlags DebugLogFlags => ref Unsafe.AsRef<ImGuiDebugLogFlags>(&NativePtr->DebugLogFlags);

		public ref ImGuiTextBuffer DebugLogBuf => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->DebugLogBuf);

		public ref ImGuiTextIndex DebugLogIndex => ref Unsafe.AsRef<ImGuiTextIndex>(&NativePtr->DebugLogIndex);

		public ref int DebugLogSkippedErrors => ref Unsafe.AsRef<int>(&NativePtr->DebugLogSkippedErrors);

		public ref ImGuiDebugLogFlags DebugLogAutoDisableFlags => ref Unsafe.AsRef<ImGuiDebugLogFlags>(&NativePtr->DebugLogAutoDisableFlags);

		public ref bool DebugLogAutoDisableFrames => ref Unsafe.AsRef<bool>(&NativePtr->DebugLogAutoDisableFrames);

		/// <summary>
		/// For DebugLocateItemOnHover(). This is used together with DebugLocateId which is in a hot/cached spot above.
		/// </summary>
		public ref bool DebugLocateFrames => ref Unsafe.AsRef<bool>(&NativePtr->DebugLocateFrames);

		/// <summary>
		/// Debug break in ItemAdd() call for g.DebugLocateId.
		/// </summary>
		public ref bool DebugBreakInLocateId => ref Unsafe.AsRef<bool>(&NativePtr->DebugBreakInLocateId);

		/// <summary>
		/// = ImGuiKey_Pause
		/// </summary>
		public ref ImGuiKey DebugBreakKeyChord => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->DebugBreakKeyChord);

		/// <summary>
		/// Cycle between 0..9 then wrap around.
		/// </summary>
		public ref sbyte DebugBeginReturnValueCullDepth => ref Unsafe.AsRef<sbyte>(&NativePtr->DebugBeginReturnValueCullDepth);

		/// <summary>
		/// Item picker is active (started with DebugStartItemPicker())
		/// </summary>
		public ref bool DebugItemPickerActive => ref Unsafe.AsRef<bool>(&NativePtr->DebugItemPickerActive);

		public ref bool DebugItemPickerMouseButton => ref Unsafe.AsRef<bool>(&NativePtr->DebugItemPickerMouseButton);

		/// <summary>
		/// Will call IM_DEBUG_BREAK() when encountering this ID
		/// </summary>
		public ref uint DebugItemPickerBreakId => ref Unsafe.AsRef<uint>(&NativePtr->DebugItemPickerBreakId);

		public ref float DebugFlashStyleColorTime => ref Unsafe.AsRef<float>(&NativePtr->DebugFlashStyleColorTime);

		public ref Vector4 DebugFlashStyleColorBackup => ref Unsafe.AsRef<Vector4>(&NativePtr->DebugFlashStyleColorBackup);

		public ref ImGuiMetricsConfig DebugMetricsConfig => ref Unsafe.AsRef<ImGuiMetricsConfig>(&NativePtr->DebugMetricsConfig);

		public ref ImGuiIDStackTool DebugIDStackTool => ref Unsafe.AsRef<ImGuiIDStackTool>(&NativePtr->DebugIDStackTool);

		public ref ImGuiDebugAllocInfo DebugAllocInfo => ref Unsafe.AsRef<ImGuiDebugAllocInfo>(&NativePtr->DebugAllocInfo);

		/// <summary>
		/// Hovered dock node.
		/// </summary>
		public ImGuiDockNodePtr DebugHoveredDockNode => new ImGuiDockNodePtr(NativePtr->DebugHoveredDockNode);

		/// <summary>
		/// <para>Misc</para>
		/// </summary>
		/// <summary>
		/// Calculate estimate of framerate for user over the last 60 frames..
		/// </summary>
		public RangeAccessor<float> FramerateSecPerFrame => new RangeAccessor<float>(NativePtr->FramerateSecPerFrame, 60);

		public ref int FramerateSecPerFrameIdx => ref Unsafe.AsRef<int>(&NativePtr->FramerateSecPerFrameIdx);

		public ref int FramerateSecPerFrameCount => ref Unsafe.AsRef<int>(&NativePtr->FramerateSecPerFrameCount);

		public ref float FramerateSecPerFrameAccum => ref Unsafe.AsRef<float>(&NativePtr->FramerateSecPerFrameAccum);

		/// <summary>
		/// Explicit capture override via SetNextFrameWantCaptureMouse()/SetNextFrameWantCaptureKeyboard(). Default to -1.
		/// </summary>
		public ref int WantCaptureMouseNextFrame => ref Unsafe.AsRef<int>(&NativePtr->WantCaptureMouseNextFrame);

		/// <summary>
		/// "
		/// </summary>
		public ref int WantCaptureKeyboardNextFrame => ref Unsafe.AsRef<int>(&NativePtr->WantCaptureKeyboardNextFrame);

		public ref int WantTextInputNextFrame => ref Unsafe.AsRef<int>(&NativePtr->WantTextInputNextFrame);

		/// <summary>
		/// Temporary text buffer
		/// </summary>
		public ImVector<byte> TempBuffer => new ImVector<byte>(NativePtr->TempBuffer);

		public RangeAccessor<byte> TempKeychordName => new RangeAccessor<byte>(NativePtr->TempKeychordName, 64);
	}
}
