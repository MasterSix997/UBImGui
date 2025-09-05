using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiIO
	{
		/// <summary>
		/// = 0              See ImGuiConfigFlags_ enum. Set by user/application. Keyboard/Gamepad navigation options, etc.<br/>
		/// </summary>
		public ImGuiConfigFlags ConfigFlags;
		/// <summary>
		/// = 0              See ImGuiBackendFlags_ enum. Set by backend (imgui_impl_xxx files or custom backend) to communicate features supported by the backend.<br/>
		/// </summary>
		public ImGuiBackendFlags BackendFlags;
		/// <summary>
		/// &lt;unset&gt;          Main display size, in pixels (generally == GetMainViewport()-&gt;Size). May change every frame.<br/>
		/// </summary>
		public Vector2 DisplaySize;
		/// <summary>
		/// = 1.0f/60.0f     Time elapsed since last frame, in seconds. May change every frame.<br/>
		/// </summary>
		public float DeltaTime;
		/// <summary>
		/// = 5.0f           Minimum time between saving positions/sizes to .ini file, in seconds.<br/>
		/// </summary>
		public float IniSavingRate;
		/// <summary>
		/// = "imgui.ini"    Path to .ini file (important: default "imgui.ini" is relative to current working dir!). Set NULL to disable automatic .ini loading/saving or if you want to manually call LoadIniSettingsXXX() / SaveIniSettingsXXX() functions.<br/>
		/// </summary>
		public unsafe byte* IniFilename;
		/// <summary>
		/// = "imgui_log.txt"Path to .log file (default parameter to ImGui::LogToFile when no file is specified).<br/>
		/// </summary>
		public unsafe byte* LogFilename;
		/// <summary>
		/// = NULL           Store your own data.<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		///     Font system<br/>
		/// &lt;auto&gt;           Font atlas: load, rasterize and pack one or more fonts into a single texture.<br/>
		/// </summary>
		public unsafe ImFontAtlas* Fonts;
		/// <summary>
		/// = 1.0f           Global scale all fonts<br/>
		/// </summary>
		public float FontGlobalScale;
		/// <summary>
		/// = false          [OBSOLETE] Allow user scaling text of individual window with CTRL+Wheel.<br/>
		/// </summary>
		public byte FontAllowUserScaling;
		/// <summary>
		/// = NULL           Font to use on NewFrame(). Use NULL to uses Fonts-&gt;Fonts[0].<br/>
		/// </summary>
		public unsafe ImFont* FontDefault;
		/// <summary>
		/// = (1, 1)         For retina display or other situations where window coordinates are different from framebuffer coordinates. This generally ends up in ImDrawData::FramebufferScale.<br/>
		/// </summary>
		public Vector2 DisplayFramebufferScale;
		/// <summary>
		///     Keyboard/Gamepad Navigation options<br/>
		/// = false          Swap Activate&lt;&gt;Cancel (A&lt;&gt;B) buttons, matching typical "Nintendo/Japanese style" gamepad layout.<br/>
		/// </summary>
		public byte ConfigNavSwapGamepadButtons;
		/// <summary>
		/// = false          Directional/tabbing navigation teleports the mouse cursor. May be useful on TV/console systems where moving a virtual mouse is difficult. Will update io.MousePos and set io.WantSetMousePos=true.<br/>
		/// </summary>
		public byte ConfigNavMoveSetMousePos;
		/// <summary>
		/// = true           Sets io.WantCaptureKeyboard when io.NavActive is set.<br/>
		/// </summary>
		public byte ConfigNavCaptureKeyboard;
		/// <summary>
		/// = true           Pressing Escape can clear focused item + navigation id/highlight. Set to false if you want to always keep highlight on.<br/>
		/// </summary>
		public byte ConfigNavEscapeClearFocusItem;
		/// <summary>
		/// = false          Pressing Escape can clear focused window as well (super set of io.ConfigNavEscapeClearFocusItem).<br/>
		/// </summary>
		public byte ConfigNavEscapeClearFocusWindow;
		/// <summary>
		/// = true           Using directional navigation key makes the cursor visible. Mouse click hides the cursor.<br/>
		/// </summary>
		public byte ConfigNavCursorVisibleAuto;
		/// <summary>
		/// = false          Navigation cursor is always visible.<br/>
		/// </summary>
		public byte ConfigNavCursorVisibleAlways;
		/// <summary>
		///     Docking options (when ImGuiConfigFlags_DockingEnable is set)<br/>
		/// = false          Simplified docking mode: disable window splitting, so docking is limited to merging multiple windows together into tab-bars.<br/>
		/// </summary>
		public byte ConfigDockingNoSplit;
		/// <summary>
		/// = false          Enable docking with holding Shift key (reduce visual noise, allows dropping in wider space)<br/>
		/// </summary>
		public byte ConfigDockingWithShift;
		/// <summary>
		/// = false          [BETA] [FIXME: This currently creates regression with auto-sizing and general overhead] Make every single floating window display within a docking node.<br/>
		/// </summary>
		public byte ConfigDockingAlwaysTabBar;
		/// <summary>
		/// = false          [BETA] Make window or viewport transparent when docking and only display docking boxes on the target viewport. Useful if rendering of multiple viewport cannot be synced. Best used with ConfigViewportsNoAutoMerge.<br/>
		/// </summary>
		public byte ConfigDockingTransparentPayload;
		/// <summary>
		///     Viewport options (when ImGuiConfigFlags_ViewportsEnable is set)<br/>
		/// = false;         Set to make all floating imgui windows always create their own viewport. Otherwise, they are merged into the main host viewports when overlapping it. May also set ImGuiViewportFlags_NoAutoMerge on individual viewport.<br/>
		/// </summary>
		public byte ConfigViewportsNoAutoMerge;
		/// <summary>
		/// = false          Disable default OS task bar icon flag for secondary viewports. When a viewport doesn't want a task bar icon, ImGuiViewportFlags_NoTaskBarIcon will be set on it.<br/>
		/// </summary>
		public byte ConfigViewportsNoTaskBarIcon;
		/// <summary>
		/// = true           Disable default OS window decoration flag for secondary viewports. When a viewport doesn't want window decorations, ImGuiViewportFlags_NoDecoration will be set on it. Enabling decoration can create subsequent issues at OS levels (e.g. minimum window size).<br/>
		/// </summary>
		public byte ConfigViewportsNoDecoration;
		/// <summary>
		/// = false          Disable default OS parenting to main viewport for secondary viewports. By default, viewports are marked with ParentViewportId = &lt;main_viewport&gt;, expecting the platform backend to setup a parent/child relationship between the OS windows (some backend may ignore this). Set to true if you want the default to be 0, then all viewports will be top-level OS windows.<br/>
		/// </summary>
		public byte ConfigViewportsNoDefaultParent;
		/// <summary>
		///     Miscellaneous options<br/>    (you can visualize and interact with all options in 'Demo-&gt;Configuration')<br/>
		/// = false          Request ImGui to draw a mouse cursor for you (if you are on a platform without a mouse cursor). Cannot be easily renamed to 'io.ConfigXXX' because this is frequently used by backend implementations.<br/>
		/// </summary>
		public byte MouseDrawCursor;
		/// <summary>
		/// = defined(__APPLE__) Swap Cmd&lt;&gt;Ctrl keys + OS X style text editing cursor movement using Alt instead of Ctrl, Shortcuts using Cmd/Super instead of Ctrl, Line/Text Start and End using Cmd+Arrows instead of Home/End, Double click selects by word instead of selecting whole text, Multi-selection in lists uses Cmd/Super instead of Ctrl.<br/>
		/// </summary>
		public byte ConfigMacOsxBehaviors;
		/// <summary>
		/// = true           Enable input queue trickling: some types of events submitted during the same frame (e.g. button down + up) will be spread over multiple frames, improving interactions with low framerates.<br/>
		/// </summary>
		public byte ConfigInputTrickleEventQueue;
		/// <summary>
		/// = true           Enable blinking cursor (optional as some users consider it to be distracting).<br/>
		/// </summary>
		public byte ConfigInputTextCursorBlink;
		/// <summary>
		/// = false          [BETA] Pressing Enter will keep item active and select contents (single-line only).<br/>
		/// </summary>
		public byte ConfigInputTextEnterKeepActive;
		/// <summary>
		/// = false          [BETA] Enable turning DragXXX widgets into text input with a simple mouse click-release (without moving). Not desirable on devices without a keyboard.<br/>
		/// </summary>
		public byte ConfigDragClickToInputText;
		/// <summary>
		/// = true           Enable resizing of windows from their edges and from the lower-left corner. This requires ImGuiBackendFlags_HasMouseCursors for better mouse cursor feedback. (This used to be a per-window ImGuiWindowFlags_ResizeFromAnySide flag)<br/>
		/// </summary>
		public byte ConfigWindowsResizeFromEdges;
		/// <summary>
		/// = false      Enable allowing to move windows only when clicking on their title bar. Does not apply to windows without a title bar.<br/>
		/// </summary>
		public byte ConfigWindowsMoveFromTitleBarOnly;
		/// <summary>
		/// = false      [EXPERIMENTAL] CTRL+C copy the contents of focused window into the clipboard. Experimental because: (1) has known issues with nested Begin/End pairs (2) text output quality varies (3) text output is in submission order rather than spatial order.<br/>
		/// </summary>
		public byte ConfigWindowsCopyContentsWithCtrlC;
		/// <summary>
		/// = true           Enable scrolling page by page when clicking outside the scrollbar grab. When disabled, always scroll to clicked location. When enabled, Shift+Click scrolls to clicked location.<br/>
		/// </summary>
		public byte ConfigScrollbarScrollByPage;
		/// <summary>
		/// = 60.0f          Timer (in seconds) to free transient windows/tables memory buffers when unused. Set to -1.0f to disable.<br/>
		/// </summary>
		public float ConfigMemoryCompactTimer;
		/// <summary>
		///     Inputs Behaviors<br/>    (other variables, ones which are expected to be tweaked within UI code, are exposed in ImGuiStyle)<br/>
		/// = 0.30f          Time for a double-click, in seconds.<br/>
		/// </summary>
		public float MouseDoubleClickTime;
		/// <summary>
		/// = 6.0f           Distance threshold to stay in to validate a double-click, in pixels.<br/>
		/// </summary>
		public float MouseDoubleClickMaxDist;
		/// <summary>
		/// = 6.0f           Distance threshold before considering we are dragging.<br/>
		/// </summary>
		public float MouseDragThreshold;
		/// <summary>
		/// = 0.275f         When holding a key/button, time before it starts repeating, in seconds (for buttons in Repeat mode, etc.).<br/>
		/// </summary>
		public float KeyRepeatDelay;
		/// <summary>
		/// = 0.050f         When holding a key/button, rate at which it repeats, in seconds.<br/>
		/// </summary>
		public float KeyRepeatRate;
		/// <summary>
		///     Options to configure Error Handling and how we handle recoverable errors [EXPERIMENTAL]<br/>    - Error recovery is provided as a way to facilitate:<br/>       - Recovery after a programming error (native code or scripting language - the later tends to facilitate iterating on code while running).<br/>       - Recovery after running an exception handler or any error processing which may skip code after an error has been detected.<br/>    - Error recovery is not perfect nor guaranteed! It is a feature to ease development.<br/>      You not are not supposed to rely on it in the course of a normal application run.<br/>    - Functions that support error recovery are using IM_ASSERT_USER_ERROR() instead of IM_ASSERT().<br/>    - By design, we do NOT allow error recovery to be 100% silent. One of the three options needs to be checked!<br/>    - Always ensure that on programmers seats you have at minimum Asserts or Tooltips enabled when making direct imgui API calls!<br/>      Otherwise it would severely hinder your ability to catch and correct mistakes!<br/>    Read https://github.com/ocornut/imgui/wiki/Error-Handling for details.<br/>    - Programmer seats: keep asserts (default), or disable asserts and keep error tooltips (new and nice!)<br/>    - Non-programmer seats: maybe disable asserts, but make sure errors are resurfaced (tooltips, visible log entries, use callback etc.)<br/>    - Recovery after error/exception: record stack sizes with ErrorRecoveryStoreState(), disable assert, set log callback (to e.g. trigger high-level breakpoint), recover with ErrorRecoveryTryToRecoverState(), restore settings.<br/>
		/// = true       Enable error recovery support. Some errors won't be detected and lead to direct crashes if recovery is disabled.<br/>
		/// </summary>
		public byte ConfigErrorRecovery;
		/// <summary>
		/// = true       Enable asserts on recoverable error. By default call IM_ASSERT() when returning from a failing IM_ASSERT_USER_ERROR()<br/>
		/// </summary>
		public byte ConfigErrorRecoveryEnableAssert;
		/// <summary>
		/// = true       Enable debug log output on recoverable errors.<br/>
		/// </summary>
		public byte ConfigErrorRecoveryEnableDebugLog;
		/// <summary>
		/// = true       Enable tooltip on recoverable errors. The tooltip include a way to enable asserts if they were disabled.<br/>
		/// </summary>
		public byte ConfigErrorRecoveryEnableTooltip;
		/// <summary>
		///     Option to enable various debug tools showing buttons that will call the IM_DEBUG_BREAK() macro.<br/>    - The Item Picker tool will be available regardless of this being enabled, in order to maximize its discoverability.<br/>    - Requires a debugger being attached, otherwise IM_DEBUG_BREAK() options will appear to crash your application.<br/>      e.g. io.ConfigDebugIsDebuggerPresent = ::IsDebuggerPresent() on Win32, or refer to ImOsIsDebuggerPresent() imgui_test_engine/imgui_te_utils.cpp for a Unix compatible version).<br/>
		/// = false          Enable various tools calling IM_DEBUG_BREAK().<br/>
		/// </summary>
		public byte ConfigDebugIsDebuggerPresent;
		/// <summary>
		///     Tools to detect code submitting items with conflicting/duplicate IDs<br/>    - Code should use PushID()/PopID() in loops, or append "##xx" to same-label identifiers.<br/>    - Empty label e.g. Button("") == same ID as parent widget/node. Use Button("##xx") instead!<br/>    - See FAQ https://github.com/ocornut/imgui/blob/master/docs/FAQ.md#q-about-the-id-stack-system<br/>
		/// = true           Highlight and show an error message popup when multiple items have conflicting identifiers.<br/>
		/// </summary>
		public byte ConfigDebugHighlightIdConflicts;
		/// <summary>
		/// //=true Show "Item Picker" button in aforementioned popup.<br/>
		/// </summary>
		public byte ConfigDebugHighlightIdConflictsShowItemPicker;
		/// <summary>
		///     Tools to test correct Begin/End and BeginChild/EndChild behaviors.<br/>    - Presently Begin()/End() and BeginChild()/EndChild() needs to ALWAYS be called in tandem, regardless of return value of BeginXXX()<br/>    - This is inconsistent with other BeginXXX functions and create confusion for many users.<br/>    - We expect to update the API eventually. In the meanwhile we provide tools to facilitate checking user-code behavior.<br/>
		/// = false          First-time calls to Begin()/BeginChild() will return false. NEEDS TO BE SET AT APPLICATION BOOT TIME if you don't want to miss windows.<br/>
		/// </summary>
		public byte ConfigDebugBeginReturnValueOnce;
		/// <summary>
		/// = false          Some calls to Begin()/BeginChild() will return false. Will cycle through window depths then repeat. Suggested use: add "io.ConfigDebugBeginReturnValue = io.KeyShift" in your main loop then occasionally press SHIFT. Windows should be flickering while running.<br/>
		/// </summary>
		public byte ConfigDebugBeginReturnValueLoop;
		/// <summary>
		///     Option to deactivate io.AddFocusEvent(false) handling.<br/>    - May facilitate interactions with a debugger when focus loss leads to clearing inputs data.<br/>    - Backends may have other side-effects on focus loss, so this will reduce side-effects but not necessary remove all of them.<br/>
		/// = false          Ignore io.AddFocusEvent(false), consequently not calling io.ClearInputKeys()/io.ClearInputMouse() in input processing.<br/>
		/// </summary>
		public byte ConfigDebugIgnoreFocusLoss;
		/// <summary>
		///     Option to audit .ini data<br/>
		/// = false          Save .ini data with extra comments (particularly helpful for Docking, but makes saving slower)<br/>
		/// </summary>
		public byte ConfigDebugIniSettings;
		/// <summary>
		///     Nowadays those would be stored in ImGuiPlatformIO but we are leaving them here for legacy reasons.<br/>    Optional: Platform/Renderer backend name (informational only! will be displayed in About Window) + User data for backend/wrappers to store their own stuff.<br/>
		/// = NULL<br/>
		/// </summary>
		public unsafe byte* BackendPlatformName;
		/// <summary>
		/// = NULL<br/>
		/// </summary>
		public unsafe byte* BackendRendererName;
		/// <summary>
		/// = NULL           User data for platform backend<br/>
		/// </summary>
		public unsafe void* BackendPlatformUserData;
		/// <summary>
		/// = NULL           User data for renderer backend<br/>
		/// </summary>
		public unsafe void* BackendRendererUserData;
		/// <summary>
		/// = NULL           User data for non C++ programming language backend<br/>
		/// </summary>
		public unsafe void* BackendLanguageUserData;
		/// <summary>
		/// Set when Dear ImGui will use mouse inputs, in this case do not dispatch them to your main game/application (either way, always pass on mouse inputs to imgui). (e.g. unclicked mouse is hovering over an imgui window, widget is active, mouse was clicked over an imgui window, etc.).<br/>
		/// </summary>
		public byte WantCaptureMouse;
		/// <summary>
		/// Set when Dear ImGui will use keyboard inputs, in this case do not dispatch them to your main game/application (either way, always pass keyboard inputs to imgui). (e.g. InputText active, or an imgui window is focused and navigation is enabled, etc.).<br/>
		/// </summary>
		public byte WantCaptureKeyboard;
		/// <summary>
		/// Mobile/console: when set, you may display an on-screen keyboard. This is set by Dear ImGui when it wants textual keyboard input to happen (e.g. when a InputText widget is active).<br/>
		/// </summary>
		public byte WantTextInput;
		/// <summary>
		/// MousePos has been altered, backend should reposition mouse on next frame. Rarely used! Set only when io.ConfigNavMoveSetMousePos is enabled.<br/>
		/// </summary>
		public byte WantSetMousePos;
		/// <summary>
		/// When manual .ini load/save is active (io.IniFilename == NULL), this will be set to notify your application that you can call SaveIniSettingsToMemory() and save yourself. Important: clear io.WantSaveIniSettings yourself after saving!<br/>
		/// </summary>
		public byte WantSaveIniSettings;
		/// <summary>
		/// Keyboard/Gamepad navigation is currently allowed (will handle ImGuiKey_NavXXX events) = a window is focused and it doesn't use the ImGuiWindowFlags_NoNavInputs flag.<br/>
		/// </summary>
		public byte NavActive;
		/// <summary>
		/// Keyboard/Gamepad navigation highlight is visible and allowed (will handle ImGuiKey_NavXXX events).<br/>
		/// </summary>
		public byte NavVisible;
		/// <summary>
		/// Estimate of application framerate (rolling average over 60 frames, based on io.DeltaTime), in frame per second. Solely for convenience. Slow applications may not want to use a moving average or may want to reset underlying buffers occasionally.<br/>
		/// </summary>
		public float Framerate;
		/// <summary>
		/// Vertices output during last call to Render()<br/>
		/// </summary>
		public int MetricsRenderVertices;
		/// <summary>
		/// Indices output during last call to Render() = number of triangles * 3<br/>
		/// </summary>
		public int MetricsRenderIndices;
		/// <summary>
		/// Number of visible windows<br/>
		/// </summary>
		public int MetricsRenderWindows;
		/// <summary>
		/// Number of active windows<br/>
		/// </summary>
		public int MetricsActiveWindows;
		/// <summary>
		/// Mouse delta. Note that this is zero if either current or previous position are invalid (-FLT_MAX,-FLT_MAX), so a disappearing/reappearing mouse won't have a huge delta.<br/>
		/// </summary>
		public Vector2 MouseDelta;
		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public unsafe ImGuiContext* Ctx;
		/// <summary>
		///     Main Input State<br/>    (this block used to be written by backend, since 1.87 it is best to NOT write to those directly, call the AddXXX functions above instead)<br/>    (reading from those variables is fair game, as they are extremely unlikely to be moving anywhere)<br/>
		/// Mouse position, in pixels. Set to ImVec2(-FLT_MAX, -FLT_MAX) if mouse is unavailable (on another screen, etc.)<br/>
		/// </summary>
		public Vector2 MousePos;
		/// <summary>
		/// Mouse buttons: 0=left, 1=right, 2=middle + extras (ImGuiMouseButton_COUNT == 5). Dear ImGui mostly uses left and right buttons. Other buttons allow us to track if the mouse is being used by your application + available to user as a convenience via IsMouse** API.<br/>
		/// </summary>
		public byte MouseDown_0;
		public byte MouseDown_1;
		public byte MouseDown_2;
		public byte MouseDown_3;
		public byte MouseDown_4;
		/// <summary>
		/// Mouse wheel Vertical: 1 unit scrolls about 5 lines text. &gt;0 scrolls Up, &lt;0 scrolls Down. Hold SHIFT to turn vertical scroll into horizontal scroll.<br/>
		/// </summary>
		public float MouseWheel;
		/// <summary>
		/// Mouse wheel Horizontal. &gt;0 scrolls Left, &lt;0 scrolls Right. Most users don't have a mouse with a horizontal wheel, may not be filled by all backends.<br/>
		/// </summary>
		public float MouseWheelH;
		/// <summary>
		/// Mouse actual input peripheral (Mouse/TouchScreen/Pen).<br/>
		/// </summary>
		public ImGuiMouseSource MouseSource;
		/// <summary>
		/// (Optional) Modify using io.AddMouseViewportEvent(). With multi-viewports: viewport the OS mouse is hovering. If possible _IGNORING_ viewports with the ImGuiViewportFlags_NoInputs flag is much better (few backends can handle that). Set io.BackendFlags |= ImGuiBackendFlags_HasMouseHoveredViewport if you can provide this info. If you don't imgui will infer the value using the rectangles and last focused time of the viewports it knows about (ignoring other OS windows).<br/>
		/// </summary>
		public uint MouseHoveredViewport;
		/// <summary>
		/// Keyboard modifier down: Control<br/>
		/// </summary>
		public byte KeyCtrl;
		/// <summary>
		/// Keyboard modifier down: Shift<br/>
		/// </summary>
		public byte KeyShift;
		/// <summary>
		/// Keyboard modifier down: Alt<br/>
		/// </summary>
		public byte KeyAlt;
		/// <summary>
		/// Keyboard modifier down: Cmd/Super/Windows<br/>
		/// </summary>
		public byte KeySuper;
		/// <summary>
		///     Other state maintained from data above + IO function calls<br/>
		/// Key mods flags (any of ImGuiMod_Ctrl/ImGuiMod_Shift/ImGuiMod_Alt/ImGuiMod_Super flags, same as io.KeyCtrl/KeyShift/KeyAlt/KeySuper but merged into flags. Read-only, updated by NewFrame()<br/>
		/// </summary>
		public int KeyMods;
		/// <summary>
		/// Key state for all known keys. Use IsKeyXXX() functions to access this.<br/>
		/// </summary>
		public ImGuiKeyData KeysData_0;
		public ImGuiKeyData KeysData_1;
		public ImGuiKeyData KeysData_2;
		public ImGuiKeyData KeysData_3;
		public ImGuiKeyData KeysData_4;
		public ImGuiKeyData KeysData_5;
		public ImGuiKeyData KeysData_6;
		public ImGuiKeyData KeysData_7;
		public ImGuiKeyData KeysData_8;
		public ImGuiKeyData KeysData_9;
		public ImGuiKeyData KeysData_10;
		public ImGuiKeyData KeysData_11;
		public ImGuiKeyData KeysData_12;
		public ImGuiKeyData KeysData_13;
		public ImGuiKeyData KeysData_14;
		public ImGuiKeyData KeysData_15;
		public ImGuiKeyData KeysData_16;
		public ImGuiKeyData KeysData_17;
		public ImGuiKeyData KeysData_18;
		public ImGuiKeyData KeysData_19;
		public ImGuiKeyData KeysData_20;
		public ImGuiKeyData KeysData_21;
		public ImGuiKeyData KeysData_22;
		public ImGuiKeyData KeysData_23;
		public ImGuiKeyData KeysData_24;
		public ImGuiKeyData KeysData_25;
		public ImGuiKeyData KeysData_26;
		public ImGuiKeyData KeysData_27;
		public ImGuiKeyData KeysData_28;
		public ImGuiKeyData KeysData_29;
		public ImGuiKeyData KeysData_30;
		public ImGuiKeyData KeysData_31;
		public ImGuiKeyData KeysData_32;
		public ImGuiKeyData KeysData_33;
		public ImGuiKeyData KeysData_34;
		public ImGuiKeyData KeysData_35;
		public ImGuiKeyData KeysData_36;
		public ImGuiKeyData KeysData_37;
		public ImGuiKeyData KeysData_38;
		public ImGuiKeyData KeysData_39;
		public ImGuiKeyData KeysData_40;
		public ImGuiKeyData KeysData_41;
		public ImGuiKeyData KeysData_42;
		public ImGuiKeyData KeysData_43;
		public ImGuiKeyData KeysData_44;
		public ImGuiKeyData KeysData_45;
		public ImGuiKeyData KeysData_46;
		public ImGuiKeyData KeysData_47;
		public ImGuiKeyData KeysData_48;
		public ImGuiKeyData KeysData_49;
		public ImGuiKeyData KeysData_50;
		public ImGuiKeyData KeysData_51;
		public ImGuiKeyData KeysData_52;
		public ImGuiKeyData KeysData_53;
		public ImGuiKeyData KeysData_54;
		public ImGuiKeyData KeysData_55;
		public ImGuiKeyData KeysData_56;
		public ImGuiKeyData KeysData_57;
		public ImGuiKeyData KeysData_58;
		public ImGuiKeyData KeysData_59;
		public ImGuiKeyData KeysData_60;
		public ImGuiKeyData KeysData_61;
		public ImGuiKeyData KeysData_62;
		public ImGuiKeyData KeysData_63;
		public ImGuiKeyData KeysData_64;
		public ImGuiKeyData KeysData_65;
		public ImGuiKeyData KeysData_66;
		public ImGuiKeyData KeysData_67;
		public ImGuiKeyData KeysData_68;
		public ImGuiKeyData KeysData_69;
		public ImGuiKeyData KeysData_70;
		public ImGuiKeyData KeysData_71;
		public ImGuiKeyData KeysData_72;
		public ImGuiKeyData KeysData_73;
		public ImGuiKeyData KeysData_74;
		public ImGuiKeyData KeysData_75;
		public ImGuiKeyData KeysData_76;
		public ImGuiKeyData KeysData_77;
		public ImGuiKeyData KeysData_78;
		public ImGuiKeyData KeysData_79;
		public ImGuiKeyData KeysData_80;
		public ImGuiKeyData KeysData_81;
		public ImGuiKeyData KeysData_82;
		public ImGuiKeyData KeysData_83;
		public ImGuiKeyData KeysData_84;
		public ImGuiKeyData KeysData_85;
		public ImGuiKeyData KeysData_86;
		public ImGuiKeyData KeysData_87;
		public ImGuiKeyData KeysData_88;
		public ImGuiKeyData KeysData_89;
		public ImGuiKeyData KeysData_90;
		public ImGuiKeyData KeysData_91;
		public ImGuiKeyData KeysData_92;
		public ImGuiKeyData KeysData_93;
		public ImGuiKeyData KeysData_94;
		public ImGuiKeyData KeysData_95;
		public ImGuiKeyData KeysData_96;
		public ImGuiKeyData KeysData_97;
		public ImGuiKeyData KeysData_98;
		public ImGuiKeyData KeysData_99;
		public ImGuiKeyData KeysData_100;
		public ImGuiKeyData KeysData_101;
		public ImGuiKeyData KeysData_102;
		public ImGuiKeyData KeysData_103;
		public ImGuiKeyData KeysData_104;
		public ImGuiKeyData KeysData_105;
		public ImGuiKeyData KeysData_106;
		public ImGuiKeyData KeysData_107;
		public ImGuiKeyData KeysData_108;
		public ImGuiKeyData KeysData_109;
		public ImGuiKeyData KeysData_110;
		public ImGuiKeyData KeysData_111;
		public ImGuiKeyData KeysData_112;
		public ImGuiKeyData KeysData_113;
		public ImGuiKeyData KeysData_114;
		public ImGuiKeyData KeysData_115;
		public ImGuiKeyData KeysData_116;
		public ImGuiKeyData KeysData_117;
		public ImGuiKeyData KeysData_118;
		public ImGuiKeyData KeysData_119;
		public ImGuiKeyData KeysData_120;
		public ImGuiKeyData KeysData_121;
		public ImGuiKeyData KeysData_122;
		public ImGuiKeyData KeysData_123;
		public ImGuiKeyData KeysData_124;
		public ImGuiKeyData KeysData_125;
		public ImGuiKeyData KeysData_126;
		public ImGuiKeyData KeysData_127;
		public ImGuiKeyData KeysData_128;
		public ImGuiKeyData KeysData_129;
		public ImGuiKeyData KeysData_130;
		public ImGuiKeyData KeysData_131;
		public ImGuiKeyData KeysData_132;
		public ImGuiKeyData KeysData_133;
		public ImGuiKeyData KeysData_134;
		public ImGuiKeyData KeysData_135;
		public ImGuiKeyData KeysData_136;
		public ImGuiKeyData KeysData_137;
		public ImGuiKeyData KeysData_138;
		public ImGuiKeyData KeysData_139;
		public ImGuiKeyData KeysData_140;
		public ImGuiKeyData KeysData_141;
		public ImGuiKeyData KeysData_142;
		public ImGuiKeyData KeysData_143;
		public ImGuiKeyData KeysData_144;
		public ImGuiKeyData KeysData_145;
		public ImGuiKeyData KeysData_146;
		public ImGuiKeyData KeysData_147;
		public ImGuiKeyData KeysData_148;
		public ImGuiKeyData KeysData_149;
		public ImGuiKeyData KeysData_150;
		public ImGuiKeyData KeysData_151;
		public ImGuiKeyData KeysData_152;
		public ImGuiKeyData KeysData_153;
		public ImGuiKeyData KeysData_154;
		/// <summary>
		/// Alternative to WantCaptureMouse: (WantCaptureMouse == true && WantCaptureMouseUnlessPopupClose == false) when a click over void is expected to close a popup.<br/>
		/// </summary>
		public byte WantCaptureMouseUnlessPopupClose;
		/// <summary>
		/// Previous mouse position (note that MouseDelta is not necessary == MousePos-MousePosPrev, in case either position is invalid)<br/>
		/// </summary>
		public Vector2 MousePosPrev;
		/// <summary>
		/// Position at time of clicking<br/>
		/// </summary>
		public Vector2 MouseClickedPos_0;
		public Vector2 MouseClickedPos_1;
		public Vector2 MouseClickedPos_2;
		public Vector2 MouseClickedPos_3;
		public Vector2 MouseClickedPos_4;
		/// <summary>
		/// Time of last click (used to figure out double-click)<br/>
		/// </summary>
		public double MouseClickedTime_0;
		public double MouseClickedTime_1;
		public double MouseClickedTime_2;
		public double MouseClickedTime_3;
		public double MouseClickedTime_4;
		/// <summary>
		/// Mouse button went from !Down to Down (same as MouseClickedCount[x] != 0)<br/>
		/// </summary>
		public byte MouseClicked_0;
		public byte MouseClicked_1;
		public byte MouseClicked_2;
		public byte MouseClicked_3;
		public byte MouseClicked_4;
		/// <summary>
		/// Has mouse button been double-clicked? (same as MouseClickedCount[x] == 2)<br/>
		/// </summary>
		public byte MouseDoubleClicked_0;
		public byte MouseDoubleClicked_1;
		public byte MouseDoubleClicked_2;
		public byte MouseDoubleClicked_3;
		public byte MouseDoubleClicked_4;
		/// <summary>
		/// == 0 (not clicked), == 1 (same as MouseClicked[]), == 2 (double-clicked), == 3 (triple-clicked) etc. when going from !Down to Down<br/>
		/// </summary>
		public ushort MouseClickedCount_0;
		public ushort MouseClickedCount_1;
		public ushort MouseClickedCount_2;
		public ushort MouseClickedCount_3;
		public ushort MouseClickedCount_4;
		/// <summary>
		/// Count successive number of clicks. Stays valid after mouse release. Reset after another click is done.<br/>
		/// </summary>
		public ushort MouseClickedLastCount_0;
		public ushort MouseClickedLastCount_1;
		public ushort MouseClickedLastCount_2;
		public ushort MouseClickedLastCount_3;
		public ushort MouseClickedLastCount_4;
		/// <summary>
		/// Mouse button went from Down to !Down<br/>
		/// </summary>
		public byte MouseReleased_0;
		public byte MouseReleased_1;
		public byte MouseReleased_2;
		public byte MouseReleased_3;
		public byte MouseReleased_4;
		/// <summary>
		/// Time of last released (rarely used! but useful to handle delayed single-click when trying to disambiguate them from double-click).<br/>
		/// </summary>
		public double MouseReleasedTime_0;
		public double MouseReleasedTime_1;
		public double MouseReleasedTime_2;
		public double MouseReleasedTime_3;
		public double MouseReleasedTime_4;
		/// <summary>
		/// Track if button was clicked inside a dear imgui window or over void blocked by a popup. We don't request mouse capture from the application if click started outside ImGui bounds.<br/>
		/// </summary>
		public byte MouseDownOwned_0;
		public byte MouseDownOwned_1;
		public byte MouseDownOwned_2;
		public byte MouseDownOwned_3;
		public byte MouseDownOwned_4;
		/// <summary>
		/// Track if button was clicked inside a dear imgui window.<br/>
		/// </summary>
		public byte MouseDownOwnedUnlessPopupClose_0;
		public byte MouseDownOwnedUnlessPopupClose_1;
		public byte MouseDownOwnedUnlessPopupClose_2;
		public byte MouseDownOwnedUnlessPopupClose_3;
		public byte MouseDownOwnedUnlessPopupClose_4;
		/// <summary>
		/// On a non-Mac system, holding SHIFT requests WheelY to perform the equivalent of a WheelX event. On a Mac system this is already enforced by the system.<br/>
		/// </summary>
		public byte MouseWheelRequestAxisSwap;
		/// <summary>
		/// (OSX) Set to true when the current click was a Ctrl+click that spawned a simulated right click<br/>
		/// </summary>
		public byte MouseCtrlLeftAsRightClick;
		/// <summary>
		/// Duration the mouse button has been down (0.0f == just clicked)<br/>
		/// </summary>
		public float MouseDownDuration_0;
		public float MouseDownDuration_1;
		public float MouseDownDuration_2;
		public float MouseDownDuration_3;
		public float MouseDownDuration_4;
		/// <summary>
		/// Previous time the mouse button has been down<br/>
		/// </summary>
		public float MouseDownDurationPrev_0;
		public float MouseDownDurationPrev_1;
		public float MouseDownDurationPrev_2;
		public float MouseDownDurationPrev_3;
		public float MouseDownDurationPrev_4;
		/// <summary>
		/// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point<br/>
		/// </summary>
		public Vector2 MouseDragMaxDistanceAbs_0;
		public Vector2 MouseDragMaxDistanceAbs_1;
		public Vector2 MouseDragMaxDistanceAbs_2;
		public Vector2 MouseDragMaxDistanceAbs_3;
		public Vector2 MouseDragMaxDistanceAbs_4;
		/// <summary>
		/// Squared maximum distance of how much mouse has traveled from the clicking point (used for moving thresholds)<br/>
		/// </summary>
		public float MouseDragMaxDistanceSqr_0;
		public float MouseDragMaxDistanceSqr_1;
		public float MouseDragMaxDistanceSqr_2;
		public float MouseDragMaxDistanceSqr_3;
		public float MouseDragMaxDistanceSqr_4;
		/// <summary>
		/// Touch/Pen pressure (0.0f to 1.0f, should be &gt;0.0f only when MouseDown[0] == true). Helper storage currently unused by Dear ImGui.<br/>
		/// </summary>
		public float PenPressure;
		/// <summary>
		/// Only modify via AddFocusEvent()<br/>
		/// </summary>
		public byte AppFocusLost;
		/// <summary>
		/// Only modify via SetAppAcceptingEvents()<br/>
		/// </summary>
		public byte AppAcceptingEvents;
		/// <summary>
		/// For AddInputCharacterUTF16()<br/>
		/// </summary>
		public ushort InputQueueSurrogate;
		/// <summary>
		/// Queue of _characters_ input (obtained by platform backend). Fill using AddInputCharacter() helper.<br/>
		/// </summary>
		public ImVector<ushort> InputQueueCharacters;
	}

	public unsafe partial struct ImGuiIOPtr
	{
		public ImGuiIO* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiIO this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// = 0              See ImGuiConfigFlags_ enum. Set by user/application. Keyboard/Gamepad navigation options, etc.<br/>
		/// </summary>
		public ref ImGuiConfigFlags ConfigFlags => ref Unsafe.AsRef<ImGuiConfigFlags>(&NativePtr->ConfigFlags);
		/// <summary>
		/// = 0              See ImGuiBackendFlags_ enum. Set by backend (imgui_impl_xxx files or custom backend) to communicate features supported by the backend.<br/>
		/// </summary>
		public ref ImGuiBackendFlags BackendFlags => ref Unsafe.AsRef<ImGuiBackendFlags>(&NativePtr->BackendFlags);
		/// <summary>
		/// &lt;unset&gt;          Main display size, in pixels (generally == GetMainViewport()-&gt;Size). May change every frame.<br/>
		/// </summary>
		public ref Vector2 DisplaySize => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySize);
		/// <summary>
		/// = 1.0f/60.0f     Time elapsed since last frame, in seconds. May change every frame.<br/>
		/// </summary>
		public ref float DeltaTime => ref Unsafe.AsRef<float>(&NativePtr->DeltaTime);
		/// <summary>
		/// = 5.0f           Minimum time between saving positions/sizes to .ini file, in seconds.<br/>
		/// </summary>
		public ref float IniSavingRate => ref Unsafe.AsRef<float>(&NativePtr->IniSavingRate);
		/// <summary>
		/// = "imgui.ini"    Path to .ini file (important: default "imgui.ini" is relative to current working dir!). Set NULL to disable automatic .ini loading/saving or if you want to manually call LoadIniSettingsXXX() / SaveIniSettingsXXX() functions.<br/>
		/// </summary>
		public IntPtr IniFilename { get => (IntPtr)NativePtr->IniFilename; set => NativePtr->IniFilename = (byte*)value; }
		/// <summary>
		/// = "imgui_log.txt"Path to .log file (default parameter to ImGui::LogToFile when no file is specified).<br/>
		/// </summary>
		public IntPtr LogFilename { get => (IntPtr)NativePtr->LogFilename; set => NativePtr->LogFilename = (byte*)value; }
		/// <summary>
		/// = NULL           Store your own data.<br/>
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
		/// <summary>
		///     Font system<br/>
		/// &lt;auto&gt;           Font atlas: load, rasterize and pack one or more fonts into a single texture.<br/>
		/// </summary>
		public ref ImFontAtlasPtr Fonts => ref Unsafe.AsRef<ImFontAtlasPtr>(&NativePtr->Fonts);
		/// <summary>
		/// = 1.0f           Global scale all fonts<br/>
		/// </summary>
		public ref float FontGlobalScale => ref Unsafe.AsRef<float>(&NativePtr->FontGlobalScale);
		/// <summary>
		/// = false          [OBSOLETE] Allow user scaling text of individual window with CTRL+Wheel.<br/>
		/// </summary>
		public ref bool FontAllowUserScaling => ref Unsafe.AsRef<bool>(&NativePtr->FontAllowUserScaling);
		/// <summary>
		/// = NULL           Font to use on NewFrame(). Use NULL to uses Fonts-&gt;Fonts[0].<br/>
		/// </summary>
		public ref ImFontPtr FontDefault => ref Unsafe.AsRef<ImFontPtr>(&NativePtr->FontDefault);
		/// <summary>
		/// = (1, 1)         For retina display or other situations where window coordinates are different from framebuffer coordinates. This generally ends up in ImDrawData::FramebufferScale.<br/>
		/// </summary>
		public ref Vector2 DisplayFramebufferScale => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayFramebufferScale);
		/// <summary>
		///     Keyboard/Gamepad Navigation options<br/>
		/// = false          Swap Activate&lt;&gt;Cancel (A&lt;&gt;B) buttons, matching typical "Nintendo/Japanese style" gamepad layout.<br/>
		/// </summary>
		public ref bool ConfigNavSwapGamepadButtons => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavSwapGamepadButtons);
		/// <summary>
		/// = false          Directional/tabbing navigation teleports the mouse cursor. May be useful on TV/console systems where moving a virtual mouse is difficult. Will update io.MousePos and set io.WantSetMousePos=true.<br/>
		/// </summary>
		public ref bool ConfigNavMoveSetMousePos => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavMoveSetMousePos);
		/// <summary>
		/// = true           Sets io.WantCaptureKeyboard when io.NavActive is set.<br/>
		/// </summary>
		public ref bool ConfigNavCaptureKeyboard => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavCaptureKeyboard);
		/// <summary>
		/// = true           Pressing Escape can clear focused item + navigation id/highlight. Set to false if you want to always keep highlight on.<br/>
		/// </summary>
		public ref bool ConfigNavEscapeClearFocusItem => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavEscapeClearFocusItem);
		/// <summary>
		/// = false          Pressing Escape can clear focused window as well (super set of io.ConfigNavEscapeClearFocusItem).<br/>
		/// </summary>
		public ref bool ConfigNavEscapeClearFocusWindow => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavEscapeClearFocusWindow);
		/// <summary>
		/// = true           Using directional navigation key makes the cursor visible. Mouse click hides the cursor.<br/>
		/// </summary>
		public ref bool ConfigNavCursorVisibleAuto => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavCursorVisibleAuto);
		/// <summary>
		/// = false          Navigation cursor is always visible.<br/>
		/// </summary>
		public ref bool ConfigNavCursorVisibleAlways => ref Unsafe.AsRef<bool>(&NativePtr->ConfigNavCursorVisibleAlways);
		/// <summary>
		///     Docking options (when ImGuiConfigFlags_DockingEnable is set)<br/>
		/// = false          Simplified docking mode: disable window splitting, so docking is limited to merging multiple windows together into tab-bars.<br/>
		/// </summary>
		public ref bool ConfigDockingNoSplit => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDockingNoSplit);
		/// <summary>
		/// = false          Enable docking with holding Shift key (reduce visual noise, allows dropping in wider space)<br/>
		/// </summary>
		public ref bool ConfigDockingWithShift => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDockingWithShift);
		/// <summary>
		/// = false          [BETA] [FIXME: This currently creates regression with auto-sizing and general overhead] Make every single floating window display within a docking node.<br/>
		/// </summary>
		public ref bool ConfigDockingAlwaysTabBar => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDockingAlwaysTabBar);
		/// <summary>
		/// = false          [BETA] Make window or viewport transparent when docking and only display docking boxes on the target viewport. Useful if rendering of multiple viewport cannot be synced. Best used with ConfigViewportsNoAutoMerge.<br/>
		/// </summary>
		public ref bool ConfigDockingTransparentPayload => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDockingTransparentPayload);
		/// <summary>
		///     Viewport options (when ImGuiConfigFlags_ViewportsEnable is set)<br/>
		/// = false;         Set to make all floating imgui windows always create their own viewport. Otherwise, they are merged into the main host viewports when overlapping it. May also set ImGuiViewportFlags_NoAutoMerge on individual viewport.<br/>
		/// </summary>
		public ref bool ConfigViewportsNoAutoMerge => ref Unsafe.AsRef<bool>(&NativePtr->ConfigViewportsNoAutoMerge);
		/// <summary>
		/// = false          Disable default OS task bar icon flag for secondary viewports. When a viewport doesn't want a task bar icon, ImGuiViewportFlags_NoTaskBarIcon will be set on it.<br/>
		/// </summary>
		public ref bool ConfigViewportsNoTaskBarIcon => ref Unsafe.AsRef<bool>(&NativePtr->ConfigViewportsNoTaskBarIcon);
		/// <summary>
		/// = true           Disable default OS window decoration flag for secondary viewports. When a viewport doesn't want window decorations, ImGuiViewportFlags_NoDecoration will be set on it. Enabling decoration can create subsequent issues at OS levels (e.g. minimum window size).<br/>
		/// </summary>
		public ref bool ConfigViewportsNoDecoration => ref Unsafe.AsRef<bool>(&NativePtr->ConfigViewportsNoDecoration);
		/// <summary>
		/// = false          Disable default OS parenting to main viewport for secondary viewports. By default, viewports are marked with ParentViewportId = &lt;main_viewport&gt;, expecting the platform backend to setup a parent/child relationship between the OS windows (some backend may ignore this). Set to true if you want the default to be 0, then all viewports will be top-level OS windows.<br/>
		/// </summary>
		public ref bool ConfigViewportsNoDefaultParent => ref Unsafe.AsRef<bool>(&NativePtr->ConfigViewportsNoDefaultParent);
		/// <summary>
		///     Miscellaneous options<br/>    (you can visualize and interact with all options in 'Demo-&gt;Configuration')<br/>
		/// = false          Request ImGui to draw a mouse cursor for you (if you are on a platform without a mouse cursor). Cannot be easily renamed to 'io.ConfigXXX' because this is frequently used by backend implementations.<br/>
		/// </summary>
		public ref bool MouseDrawCursor => ref Unsafe.AsRef<bool>(&NativePtr->MouseDrawCursor);
		/// <summary>
		/// = defined(__APPLE__) Swap Cmd&lt;&gt;Ctrl keys + OS X style text editing cursor movement using Alt instead of Ctrl, Shortcuts using Cmd/Super instead of Ctrl, Line/Text Start and End using Cmd+Arrows instead of Home/End, Double click selects by word instead of selecting whole text, Multi-selection in lists uses Cmd/Super instead of Ctrl.<br/>
		/// </summary>
		public ref bool ConfigMacOsxBehaviors => ref Unsafe.AsRef<bool>(&NativePtr->ConfigMacOsxBehaviors);
		/// <summary>
		/// = true           Enable input queue trickling: some types of events submitted during the same frame (e.g. button down + up) will be spread over multiple frames, improving interactions with low framerates.<br/>
		/// </summary>
		public ref bool ConfigInputTrickleEventQueue => ref Unsafe.AsRef<bool>(&NativePtr->ConfigInputTrickleEventQueue);
		/// <summary>
		/// = true           Enable blinking cursor (optional as some users consider it to be distracting).<br/>
		/// </summary>
		public ref bool ConfigInputTextCursorBlink => ref Unsafe.AsRef<bool>(&NativePtr->ConfigInputTextCursorBlink);
		/// <summary>
		/// = false          [BETA] Pressing Enter will keep item active and select contents (single-line only).<br/>
		/// </summary>
		public ref bool ConfigInputTextEnterKeepActive => ref Unsafe.AsRef<bool>(&NativePtr->ConfigInputTextEnterKeepActive);
		/// <summary>
		/// = false          [BETA] Enable turning DragXXX widgets into text input with a simple mouse click-release (without moving). Not desirable on devices without a keyboard.<br/>
		/// </summary>
		public ref bool ConfigDragClickToInputText => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDragClickToInputText);
		/// <summary>
		/// = true           Enable resizing of windows from their edges and from the lower-left corner. This requires ImGuiBackendFlags_HasMouseCursors for better mouse cursor feedback. (This used to be a per-window ImGuiWindowFlags_ResizeFromAnySide flag)<br/>
		/// </summary>
		public ref bool ConfigWindowsResizeFromEdges => ref Unsafe.AsRef<bool>(&NativePtr->ConfigWindowsResizeFromEdges);
		/// <summary>
		/// = false      Enable allowing to move windows only when clicking on their title bar. Does not apply to windows without a title bar.<br/>
		/// </summary>
		public ref bool ConfigWindowsMoveFromTitleBarOnly => ref Unsafe.AsRef<bool>(&NativePtr->ConfigWindowsMoveFromTitleBarOnly);
		/// <summary>
		/// = false      [EXPERIMENTAL] CTRL+C copy the contents of focused window into the clipboard. Experimental because: (1) has known issues with nested Begin/End pairs (2) text output quality varies (3) text output is in submission order rather than spatial order.<br/>
		/// </summary>
		public ref bool ConfigWindowsCopyContentsWithCtrlC => ref Unsafe.AsRef<bool>(&NativePtr->ConfigWindowsCopyContentsWithCtrlC);
		/// <summary>
		/// = true           Enable scrolling page by page when clicking outside the scrollbar grab. When disabled, always scroll to clicked location. When enabled, Shift+Click scrolls to clicked location.<br/>
		/// </summary>
		public ref bool ConfigScrollbarScrollByPage => ref Unsafe.AsRef<bool>(&NativePtr->ConfigScrollbarScrollByPage);
		/// <summary>
		/// = 60.0f          Timer (in seconds) to free transient windows/tables memory buffers when unused. Set to -1.0f to disable.<br/>
		/// </summary>
		public ref float ConfigMemoryCompactTimer => ref Unsafe.AsRef<float>(&NativePtr->ConfigMemoryCompactTimer);
		/// <summary>
		///     Inputs Behaviors<br/>    (other variables, ones which are expected to be tweaked within UI code, are exposed in ImGuiStyle)<br/>
		/// = 0.30f          Time for a double-click, in seconds.<br/>
		/// </summary>
		public ref float MouseDoubleClickTime => ref Unsafe.AsRef<float>(&NativePtr->MouseDoubleClickTime);
		/// <summary>
		/// = 6.0f           Distance threshold to stay in to validate a double-click, in pixels.<br/>
		/// </summary>
		public ref float MouseDoubleClickMaxDist => ref Unsafe.AsRef<float>(&NativePtr->MouseDoubleClickMaxDist);
		/// <summary>
		/// = 6.0f           Distance threshold before considering we are dragging.<br/>
		/// </summary>
		public ref float MouseDragThreshold => ref Unsafe.AsRef<float>(&NativePtr->MouseDragThreshold);
		/// <summary>
		/// = 0.275f         When holding a key/button, time before it starts repeating, in seconds (for buttons in Repeat mode, etc.).<br/>
		/// </summary>
		public ref float KeyRepeatDelay => ref Unsafe.AsRef<float>(&NativePtr->KeyRepeatDelay);
		/// <summary>
		/// = 0.050f         When holding a key/button, rate at which it repeats, in seconds.<br/>
		/// </summary>
		public ref float KeyRepeatRate => ref Unsafe.AsRef<float>(&NativePtr->KeyRepeatRate);
		/// <summary>
		///     Options to configure Error Handling and how we handle recoverable errors [EXPERIMENTAL]<br/>    - Error recovery is provided as a way to facilitate:<br/>       - Recovery after a programming error (native code or scripting language - the later tends to facilitate iterating on code while running).<br/>       - Recovery after running an exception handler or any error processing which may skip code after an error has been detected.<br/>    - Error recovery is not perfect nor guaranteed! It is a feature to ease development.<br/>      You not are not supposed to rely on it in the course of a normal application run.<br/>    - Functions that support error recovery are using IM_ASSERT_USER_ERROR() instead of IM_ASSERT().<br/>    - By design, we do NOT allow error recovery to be 100% silent. One of the three options needs to be checked!<br/>    - Always ensure that on programmers seats you have at minimum Asserts or Tooltips enabled when making direct imgui API calls!<br/>      Otherwise it would severely hinder your ability to catch and correct mistakes!<br/>    Read https://github.com/ocornut/imgui/wiki/Error-Handling for details.<br/>    - Programmer seats: keep asserts (default), or disable asserts and keep error tooltips (new and nice!)<br/>    - Non-programmer seats: maybe disable asserts, but make sure errors are resurfaced (tooltips, visible log entries, use callback etc.)<br/>    - Recovery after error/exception: record stack sizes with ErrorRecoveryStoreState(), disable assert, set log callback (to e.g. trigger high-level breakpoint), recover with ErrorRecoveryTryToRecoverState(), restore settings.<br/>
		/// = true       Enable error recovery support. Some errors won't be detected and lead to direct crashes if recovery is disabled.<br/>
		/// </summary>
		public ref bool ConfigErrorRecovery => ref Unsafe.AsRef<bool>(&NativePtr->ConfigErrorRecovery);
		/// <summary>
		/// = true       Enable asserts on recoverable error. By default call IM_ASSERT() when returning from a failing IM_ASSERT_USER_ERROR()<br/>
		/// </summary>
		public ref bool ConfigErrorRecoveryEnableAssert => ref Unsafe.AsRef<bool>(&NativePtr->ConfigErrorRecoveryEnableAssert);
		/// <summary>
		/// = true       Enable debug log output on recoverable errors.<br/>
		/// </summary>
		public ref bool ConfigErrorRecoveryEnableDebugLog => ref Unsafe.AsRef<bool>(&NativePtr->ConfigErrorRecoveryEnableDebugLog);
		/// <summary>
		/// = true       Enable tooltip on recoverable errors. The tooltip include a way to enable asserts if they were disabled.<br/>
		/// </summary>
		public ref bool ConfigErrorRecoveryEnableTooltip => ref Unsafe.AsRef<bool>(&NativePtr->ConfigErrorRecoveryEnableTooltip);
		/// <summary>
		///     Option to enable various debug tools showing buttons that will call the IM_DEBUG_BREAK() macro.<br/>    - The Item Picker tool will be available regardless of this being enabled, in order to maximize its discoverability.<br/>    - Requires a debugger being attached, otherwise IM_DEBUG_BREAK() options will appear to crash your application.<br/>      e.g. io.ConfigDebugIsDebuggerPresent = ::IsDebuggerPresent() on Win32, or refer to ImOsIsDebuggerPresent() imgui_test_engine/imgui_te_utils.cpp for a Unix compatible version).<br/>
		/// = false          Enable various tools calling IM_DEBUG_BREAK().<br/>
		/// </summary>
		public ref bool ConfigDebugIsDebuggerPresent => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugIsDebuggerPresent);
		/// <summary>
		///     Tools to detect code submitting items with conflicting/duplicate IDs<br/>    - Code should use PushID()/PopID() in loops, or append "##xx" to same-label identifiers.<br/>    - Empty label e.g. Button("") == same ID as parent widget/node. Use Button("##xx") instead!<br/>    - See FAQ https://github.com/ocornut/imgui/blob/master/docs/FAQ.md#q-about-the-id-stack-system<br/>
		/// = true           Highlight and show an error message popup when multiple items have conflicting identifiers.<br/>
		/// </summary>
		public ref bool ConfigDebugHighlightIdConflicts => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugHighlightIdConflicts);
		/// <summary>
		/// //=true Show "Item Picker" button in aforementioned popup.<br/>
		/// </summary>
		public ref bool ConfigDebugHighlightIdConflictsShowItemPicker => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugHighlightIdConflictsShowItemPicker);
		/// <summary>
		///     Tools to test correct Begin/End and BeginChild/EndChild behaviors.<br/>    - Presently Begin()/End() and BeginChild()/EndChild() needs to ALWAYS be called in tandem, regardless of return value of BeginXXX()<br/>    - This is inconsistent with other BeginXXX functions and create confusion for many users.<br/>    - We expect to update the API eventually. In the meanwhile we provide tools to facilitate checking user-code behavior.<br/>
		/// = false          First-time calls to Begin()/BeginChild() will return false. NEEDS TO BE SET AT APPLICATION BOOT TIME if you don't want to miss windows.<br/>
		/// </summary>
		public ref bool ConfigDebugBeginReturnValueOnce => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugBeginReturnValueOnce);
		/// <summary>
		/// = false          Some calls to Begin()/BeginChild() will return false. Will cycle through window depths then repeat. Suggested use: add "io.ConfigDebugBeginReturnValue = io.KeyShift" in your main loop then occasionally press SHIFT. Windows should be flickering while running.<br/>
		/// </summary>
		public ref bool ConfigDebugBeginReturnValueLoop => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugBeginReturnValueLoop);
		/// <summary>
		///     Option to deactivate io.AddFocusEvent(false) handling.<br/>    - May facilitate interactions with a debugger when focus loss leads to clearing inputs data.<br/>    - Backends may have other side-effects on focus loss, so this will reduce side-effects but not necessary remove all of them.<br/>
		/// = false          Ignore io.AddFocusEvent(false), consequently not calling io.ClearInputKeys()/io.ClearInputMouse() in input processing.<br/>
		/// </summary>
		public ref bool ConfigDebugIgnoreFocusLoss => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugIgnoreFocusLoss);
		/// <summary>
		///     Option to audit .ini data<br/>
		/// = false          Save .ini data with extra comments (particularly helpful for Docking, but makes saving slower)<br/>
		/// </summary>
		public ref bool ConfigDebugIniSettings => ref Unsafe.AsRef<bool>(&NativePtr->ConfigDebugIniSettings);
		/// <summary>
		///     Nowadays those would be stored in ImGuiPlatformIO but we are leaving them here for legacy reasons.<br/>    Optional: Platform/Renderer backend name (informational only! will be displayed in About Window) + User data for backend/wrappers to store their own stuff.<br/>
		/// = NULL<br/>
		/// </summary>
		public IntPtr BackendPlatformName { get => (IntPtr)NativePtr->BackendPlatformName; set => NativePtr->BackendPlatformName = (byte*)value; }
		/// <summary>
		/// = NULL<br/>
		/// </summary>
		public IntPtr BackendRendererName { get => (IntPtr)NativePtr->BackendRendererName; set => NativePtr->BackendRendererName = (byte*)value; }
		/// <summary>
		/// = NULL           User data for platform backend<br/>
		/// </summary>
		public IntPtr BackendPlatformUserData { get => (IntPtr)NativePtr->BackendPlatformUserData; set => NativePtr->BackendPlatformUserData = (void*)value; }
		/// <summary>
		/// = NULL           User data for renderer backend<br/>
		/// </summary>
		public IntPtr BackendRendererUserData { get => (IntPtr)NativePtr->BackendRendererUserData; set => NativePtr->BackendRendererUserData = (void*)value; }
		/// <summary>
		/// = NULL           User data for non C++ programming language backend<br/>
		/// </summary>
		public IntPtr BackendLanguageUserData { get => (IntPtr)NativePtr->BackendLanguageUserData; set => NativePtr->BackendLanguageUserData = (void*)value; }
		/// <summary>
		/// Set when Dear ImGui will use mouse inputs, in this case do not dispatch them to your main game/application (either way, always pass on mouse inputs to imgui). (e.g. unclicked mouse is hovering over an imgui window, widget is active, mouse was clicked over an imgui window, etc.).<br/>
		/// </summary>
		public ref bool WantCaptureMouse => ref Unsafe.AsRef<bool>(&NativePtr->WantCaptureMouse);
		/// <summary>
		/// Set when Dear ImGui will use keyboard inputs, in this case do not dispatch them to your main game/application (either way, always pass keyboard inputs to imgui). (e.g. InputText active, or an imgui window is focused and navigation is enabled, etc.).<br/>
		/// </summary>
		public ref bool WantCaptureKeyboard => ref Unsafe.AsRef<bool>(&NativePtr->WantCaptureKeyboard);
		/// <summary>
		/// Mobile/console: when set, you may display an on-screen keyboard. This is set by Dear ImGui when it wants textual keyboard input to happen (e.g. when a InputText widget is active).<br/>
		/// </summary>
		public ref bool WantTextInput => ref Unsafe.AsRef<bool>(&NativePtr->WantTextInput);
		/// <summary>
		/// MousePos has been altered, backend should reposition mouse on next frame. Rarely used! Set only when io.ConfigNavMoveSetMousePos is enabled.<br/>
		/// </summary>
		public ref bool WantSetMousePos => ref Unsafe.AsRef<bool>(&NativePtr->WantSetMousePos);
		/// <summary>
		/// When manual .ini load/save is active (io.IniFilename == NULL), this will be set to notify your application that you can call SaveIniSettingsToMemory() and save yourself. Important: clear io.WantSaveIniSettings yourself after saving!<br/>
		/// </summary>
		public ref bool WantSaveIniSettings => ref Unsafe.AsRef<bool>(&NativePtr->WantSaveIniSettings);
		/// <summary>
		/// Keyboard/Gamepad navigation is currently allowed (will handle ImGuiKey_NavXXX events) = a window is focused and it doesn't use the ImGuiWindowFlags_NoNavInputs flag.<br/>
		/// </summary>
		public ref bool NavActive => ref Unsafe.AsRef<bool>(&NativePtr->NavActive);
		/// <summary>
		/// Keyboard/Gamepad navigation highlight is visible and allowed (will handle ImGuiKey_NavXXX events).<br/>
		/// </summary>
		public ref bool NavVisible => ref Unsafe.AsRef<bool>(&NativePtr->NavVisible);
		/// <summary>
		/// Estimate of application framerate (rolling average over 60 frames, based on io.DeltaTime), in frame per second. Solely for convenience. Slow applications may not want to use a moving average or may want to reset underlying buffers occasionally.<br/>
		/// </summary>
		public ref float Framerate => ref Unsafe.AsRef<float>(&NativePtr->Framerate);
		/// <summary>
		/// Vertices output during last call to Render()<br/>
		/// </summary>
		public ref int MetricsRenderVertices => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderVertices);
		/// <summary>
		/// Indices output during last call to Render() = number of triangles * 3<br/>
		/// </summary>
		public ref int MetricsRenderIndices => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderIndices);
		/// <summary>
		/// Number of visible windows<br/>
		/// </summary>
		public ref int MetricsRenderWindows => ref Unsafe.AsRef<int>(&NativePtr->MetricsRenderWindows);
		/// <summary>
		/// Number of active windows<br/>
		/// </summary>
		public ref int MetricsActiveWindows => ref Unsafe.AsRef<int>(&NativePtr->MetricsActiveWindows);
		/// <summary>
		/// Mouse delta. Note that this is zero if either current or previous position are invalid (-FLT_MAX,-FLT_MAX), so a disappearing/reappearing mouse won't have a huge delta.<br/>
		/// </summary>
		public ref Vector2 MouseDelta => ref Unsafe.AsRef<Vector2>(&NativePtr->MouseDelta);
		/// <summary>
		/// Parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public ref ImGuiContextPtr Ctx => ref Unsafe.AsRef<ImGuiContextPtr>(&NativePtr->Ctx);
		/// <summary>
		///     Main Input State<br/>    (this block used to be written by backend, since 1.87 it is best to NOT write to those directly, call the AddXXX functions above instead)<br/>    (reading from those variables is fair game, as they are extremely unlikely to be moving anywhere)<br/>
		/// Mouse position, in pixels. Set to ImVec2(-FLT_MAX, -FLT_MAX) if mouse is unavailable (on another screen, etc.)<br/>
		/// </summary>
		public ref Vector2 MousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePos);
		/// <summary>
		/// Mouse buttons: 0=left, 1=right, 2=middle + extras (ImGuiMouseButton_COUNT == 5). Dear ImGui mostly uses left and right buttons. Other buttons allow us to track if the mouse is being used by your application + available to user as a convenience via IsMouse** API.<br/>
		/// </summary>
		public Span<byte> MouseDown => new Span<byte>(&NativePtr->MouseDown_0, 5);
		/// <summary>
		/// Mouse wheel Vertical: 1 unit scrolls about 5 lines text. &gt;0 scrolls Up, &lt;0 scrolls Down. Hold SHIFT to turn vertical scroll into horizontal scroll.<br/>
		/// </summary>
		public ref float MouseWheel => ref Unsafe.AsRef<float>(&NativePtr->MouseWheel);
		/// <summary>
		/// Mouse wheel Horizontal. &gt;0 scrolls Left, &lt;0 scrolls Right. Most users don't have a mouse with a horizontal wheel, may not be filled by all backends.<br/>
		/// </summary>
		public ref float MouseWheelH => ref Unsafe.AsRef<float>(&NativePtr->MouseWheelH);
		/// <summary>
		/// Mouse actual input peripheral (Mouse/TouchScreen/Pen).<br/>
		/// </summary>
		public ref ImGuiMouseSource MouseSource => ref Unsafe.AsRef<ImGuiMouseSource>(&NativePtr->MouseSource);
		/// <summary>
		/// (Optional) Modify using io.AddMouseViewportEvent(). With multi-viewports: viewport the OS mouse is hovering. If possible _IGNORING_ viewports with the ImGuiViewportFlags_NoInputs flag is much better (few backends can handle that). Set io.BackendFlags |= ImGuiBackendFlags_HasMouseHoveredViewport if you can provide this info. If you don't imgui will infer the value using the rectangles and last focused time of the viewports it knows about (ignoring other OS windows).<br/>
		/// </summary>
		public ref uint MouseHoveredViewport => ref Unsafe.AsRef<uint>(&NativePtr->MouseHoveredViewport);
		/// <summary>
		/// Keyboard modifier down: Control<br/>
		/// </summary>
		public ref bool KeyCtrl => ref Unsafe.AsRef<bool>(&NativePtr->KeyCtrl);
		/// <summary>
		/// Keyboard modifier down: Shift<br/>
		/// </summary>
		public ref bool KeyShift => ref Unsafe.AsRef<bool>(&NativePtr->KeyShift);
		/// <summary>
		/// Keyboard modifier down: Alt<br/>
		/// </summary>
		public ref bool KeyAlt => ref Unsafe.AsRef<bool>(&NativePtr->KeyAlt);
		/// <summary>
		/// Keyboard modifier down: Cmd/Super/Windows<br/>
		/// </summary>
		public ref bool KeySuper => ref Unsafe.AsRef<bool>(&NativePtr->KeySuper);
		/// <summary>
		///     Other state maintained from data above + IO function calls<br/>
		/// Key mods flags (any of ImGuiMod_Ctrl/ImGuiMod_Shift/ImGuiMod_Alt/ImGuiMod_Super flags, same as io.KeyCtrl/KeyShift/KeyAlt/KeySuper but merged into flags. Read-only, updated by NewFrame()<br/>
		/// </summary>
		public ref int KeyMods => ref Unsafe.AsRef<int>(&NativePtr->KeyMods);
		/// <summary>
		/// Key state for all known keys. Use IsKeyXXX() functions to access this.<br/>
		/// </summary>
		public Span<ImGuiKeyData> KeysData => new Span<ImGuiKeyData>(&NativePtr->KeysData_0, 155);
		/// <summary>
		/// Alternative to WantCaptureMouse: (WantCaptureMouse == true && WantCaptureMouseUnlessPopupClose == false) when a click over void is expected to close a popup.<br/>
		/// </summary>
		public ref bool WantCaptureMouseUnlessPopupClose => ref Unsafe.AsRef<bool>(&NativePtr->WantCaptureMouseUnlessPopupClose);
		/// <summary>
		/// Previous mouse position (note that MouseDelta is not necessary == MousePos-MousePosPrev, in case either position is invalid)<br/>
		/// </summary>
		public ref Vector2 MousePosPrev => ref Unsafe.AsRef<Vector2>(&NativePtr->MousePosPrev);
		/// <summary>
		/// Position at time of clicking<br/>
		/// </summary>
		public Span<Vector2> MouseClickedPos => new Span<Vector2>(&NativePtr->MouseClickedPos_0, 5);
		/// <summary>
		/// Time of last click (used to figure out double-click)<br/>
		/// </summary>
		public Span<double> MouseClickedTime => new Span<double>(&NativePtr->MouseClickedTime_0, 5);
		/// <summary>
		/// Mouse button went from !Down to Down (same as MouseClickedCount[x] != 0)<br/>
		/// </summary>
		public Span<byte> MouseClicked => new Span<byte>(&NativePtr->MouseClicked_0, 5);
		/// <summary>
		/// Has mouse button been double-clicked? (same as MouseClickedCount[x] == 2)<br/>
		/// </summary>
		public Span<byte> MouseDoubleClicked => new Span<byte>(&NativePtr->MouseDoubleClicked_0, 5);
		/// <summary>
		/// == 0 (not clicked), == 1 (same as MouseClicked[]), == 2 (double-clicked), == 3 (triple-clicked) etc. when going from !Down to Down<br/>
		/// </summary>
		public Span<ushort> MouseClickedCount => new Span<ushort>(&NativePtr->MouseClickedCount_0, 5);
		/// <summary>
		/// Count successive number of clicks. Stays valid after mouse release. Reset after another click is done.<br/>
		/// </summary>
		public Span<ushort> MouseClickedLastCount => new Span<ushort>(&NativePtr->MouseClickedLastCount_0, 5);
		/// <summary>
		/// Mouse button went from Down to !Down<br/>
		/// </summary>
		public Span<byte> MouseReleased => new Span<byte>(&NativePtr->MouseReleased_0, 5);
		/// <summary>
		/// Time of last released (rarely used! but useful to handle delayed single-click when trying to disambiguate them from double-click).<br/>
		/// </summary>
		public Span<double> MouseReleasedTime => new Span<double>(&NativePtr->MouseReleasedTime_0, 5);
		/// <summary>
		/// Track if button was clicked inside a dear imgui window or over void blocked by a popup. We don't request mouse capture from the application if click started outside ImGui bounds.<br/>
		/// </summary>
		public Span<byte> MouseDownOwned => new Span<byte>(&NativePtr->MouseDownOwned_0, 5);
		/// <summary>
		/// Track if button was clicked inside a dear imgui window.<br/>
		/// </summary>
		public Span<byte> MouseDownOwnedUnlessPopupClose => new Span<byte>(&NativePtr->MouseDownOwnedUnlessPopupClose_0, 5);
		/// <summary>
		/// On a non-Mac system, holding SHIFT requests WheelY to perform the equivalent of a WheelX event. On a Mac system this is already enforced by the system.<br/>
		/// </summary>
		public ref bool MouseWheelRequestAxisSwap => ref Unsafe.AsRef<bool>(&NativePtr->MouseWheelRequestAxisSwap);
		/// <summary>
		/// (OSX) Set to true when the current click was a Ctrl+click that spawned a simulated right click<br/>
		/// </summary>
		public ref bool MouseCtrlLeftAsRightClick => ref Unsafe.AsRef<bool>(&NativePtr->MouseCtrlLeftAsRightClick);
		/// <summary>
		/// Duration the mouse button has been down (0.0f == just clicked)<br/>
		/// </summary>
		public Span<float> MouseDownDuration => new Span<float>(&NativePtr->MouseDownDuration_0, 5);
		/// <summary>
		/// Previous time the mouse button has been down<br/>
		/// </summary>
		public Span<float> MouseDownDurationPrev => new Span<float>(&NativePtr->MouseDownDurationPrev_0, 5);
		/// <summary>
		/// Maximum distance, absolute, on each axis, of how much mouse has traveled from the clicking point<br/>
		/// </summary>
		public Span<Vector2> MouseDragMaxDistanceAbs => new Span<Vector2>(&NativePtr->MouseDragMaxDistanceAbs_0, 5);
		/// <summary>
		/// Squared maximum distance of how much mouse has traveled from the clicking point (used for moving thresholds)<br/>
		/// </summary>
		public Span<float> MouseDragMaxDistanceSqr => new Span<float>(&NativePtr->MouseDragMaxDistanceSqr_0, 5);
		/// <summary>
		/// Touch/Pen pressure (0.0f to 1.0f, should be &gt;0.0f only when MouseDown[0] == true). Helper storage currently unused by Dear ImGui.<br/>
		/// </summary>
		public ref float PenPressure => ref Unsafe.AsRef<float>(&NativePtr->PenPressure);
		/// <summary>
		/// Only modify via AddFocusEvent()<br/>
		/// </summary>
		public ref bool AppFocusLost => ref Unsafe.AsRef<bool>(&NativePtr->AppFocusLost);
		/// <summary>
		/// Only modify via SetAppAcceptingEvents()<br/>
		/// </summary>
		public ref bool AppAcceptingEvents => ref Unsafe.AsRef<bool>(&NativePtr->AppAcceptingEvents);
		/// <summary>
		/// For AddInputCharacterUTF16()<br/>
		/// </summary>
		public ref ushort InputQueueSurrogate => ref Unsafe.AsRef<ushort>(&NativePtr->InputQueueSurrogate);
		/// <summary>
		/// Queue of _characters_ input (obtained by platform backend). Fill using AddInputCharacter() helper.<br/>
		/// </summary>
		public ref ImVector<ushort> InputQueueCharacters => ref Unsafe.AsRef<ImVector<ushort>>(&NativePtr->InputQueueCharacters);
		public ImGuiIOPtr(ImGuiIO* nativePtr) => NativePtr = nativePtr;
		public ImGuiIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiIO*)nativePtr;
		public static implicit operator ImGuiIOPtr(ImGuiIO* ptr) => new ImGuiIOPtr(ptr);
		public static implicit operator ImGuiIOPtr(IntPtr ptr) => new ImGuiIOPtr(ptr);
		public static implicit operator ImGuiIO*(ImGuiIOPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiIODestroy(NativePtr);
		}

		public void ImGuiIOConstruct()
		{
			ImGuiNative.ImGuiIOImGuiIOConstruct(NativePtr);
		}

		public ImGuiIOPtr ImGuiIO()
		{
			return ImGuiNative.ImGuiIOImGuiIO();
		}

		/// <summary>
		/// Clear current mouse state.<br/>
		/// </summary>
		public void ClearInputMouse()
		{
			ImGuiNative.ImGuiIOClearInputMouse(NativePtr);
		}

		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.<br/>
		/// </summary>
		public void ClearInputKeys()
		{
			ImGuiNative.ImGuiIOClearInputKeys(NativePtr);
		}

		/// <summary>
		/// Clear all incoming events.<br/>
		/// </summary>
		public void ClearEventsQueue()
		{
			ImGuiNative.ImGuiIOClearEventsQueue(NativePtr);
		}

		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.<br/>
		/// </summary>
		public void SetAppAcceptingEvents(bool acceptingEvents)
		{
			var native_acceptingEvents = acceptingEvents ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiIOSetAppAcceptingEvents(NativePtr, native_acceptingEvents);
		}

		/// <summary>
		/// [Optional] Specify index for legacy &lt;1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		public void SetKeyEventNativeData(ImGuiKey key, int nativeKeycode, int nativeScancode, int nativeLegacyIndex)
		{
			ImGuiNative.ImGuiIOSetKeyEventNativeData(NativePtr, key, nativeKeycode, nativeScancode, nativeLegacyIndex);
		}

		/// <summary>
		/// [Optional] Specify index for legacy &lt;1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		public void SetKeyEventNativeData(ImGuiKey key, int nativeKeycode, int nativeScancode)
		{
			// defining omitted parameters
			int nativeLegacyIndex = -1;
			ImGuiNative.ImGuiIOSetKeyEventNativeData(NativePtr, key, nativeKeycode, nativeScancode, nativeLegacyIndex);
		}

		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		public void AddInputCharactersUtf8(ReadOnlySpan<byte> str)
		{
			fixed (byte* nativeStr = str)
			{
				ImGuiNative.ImGuiIOAddInputCharactersUtf8(NativePtr, nativeStr);
			}
		}

		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		public void AddInputCharactersUtf8(ReadOnlySpan<char> str)
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

			ImGuiNative.ImGuiIOAddInputCharactersUtf8(NativePtr, nativeStr);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
		}

		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate<br/>
		/// </summary>
		public void AddInputCharacterUtf16(ushort c)
		{
			ImGuiNative.ImGuiIOAddInputCharacterUtf16(NativePtr, c);
		}

		/// <summary>
		/// Queue a new character input<br/>
		/// </summary>
		public void AddInputCharacter(uint c)
		{
			ImGuiNative.ImGuiIOAddInputCharacter(NativePtr, c);
		}

		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)<br/>
		/// </summary>
		public void AddFocusEvent(bool focused)
		{
			var native_focused = focused ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiIOAddFocusEvent(NativePtr, native_focused);
		}

		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).<br/>
		/// </summary>
		public void AddMouseViewportEvent(uint id)
		{
			ImGuiNative.ImGuiIOAddMouseViewportEvent(NativePtr, id);
		}

		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)<br/>
		/// </summary>
		public void AddMouseSourceEvent(ImGuiMouseSource source)
		{
			ImGuiNative.ImGuiIOAddMouseSourceEvent(NativePtr, source);
		}

		/// <summary>
		/// Queue a mouse wheel update. wheel_y&lt;0: scroll down, wheel_y&gt;0: scroll up, wheel_x&lt;0: scroll right, wheel_x&gt;0: scroll left.<br/>
		/// </summary>
		public void AddMouseWheelEvent(float wheelX, float wheelY)
		{
			ImGuiNative.ImGuiIOAddMouseWheelEvent(NativePtr, wheelX, wheelY);
		}

		/// <summary>
		/// Queue a mouse button change<br/>
		/// </summary>
		public void AddMouseButtonEvent(int button, bool down)
		{
			var native_down = down ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiIOAddMouseButtonEvent(NativePtr, button, native_down);
		}

		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)<br/>
		/// </summary>
		public void AddMousePosEvent(float x, float y)
		{
			ImGuiNative.ImGuiIOAddMousePosEvent(NativePtr, x, y);
		}

		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.<br/>
		/// </summary>
		public void AddKeyAnalogEvent(ImGuiKey key, bool down, float v)
		{
			var native_down = down ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiIOAddKeyAnalogEvent(NativePtr, key, native_down, v);
		}

		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)<br/>
		/// </summary>
		public void AddKeyEvent(ImGuiKey key, bool down)
		{
			var native_down = down ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiIOAddKeyEvent(NativePtr, key, native_down);
		}

	}
}
