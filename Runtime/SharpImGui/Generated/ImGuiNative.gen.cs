using System;
using UnityEngine;
using System.Runtime.InteropServices;
namespace SharpImGui
{
	public static unsafe partial class ImGuiNative
	{
		/// <summary>
		/// <para>Context creation and access</para>
		/// <para>- Each context create its own ImFontAtlas by default. You may instance one yourself and pass it to CreateContext() to share a font atlas between contexts.</para>
		/// <para>- DLL users: heaps and globals are not shared across DLL boundaries! You will need to call SetCurrentContext() + SetAllocatorFunctions()</para>
		/// <para>  for each static/DLL boundary you are calling from. Read "Context and Memory Allocators" section of imgui.cpp for details.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CreateContext")]
		public static extern IntPtr ImGui_CreateContext(ImFontAtlas* shared_font_atlas);
		/// <summary>
		/// NULL = destroy current context
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DestroyContext")]
		public static extern void ImGui_DestroyContext(IntPtr ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCurrentContext")]
		public static extern IntPtr ImGui_GetCurrentContext();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCurrentContext")]
		public static extern void ImGui_SetCurrentContext(IntPtr ctx);
		/// <summary>
		/// <para>Main</para>
		/// </summary>
		/// <summary>
		/// access the ImGuiIO structure (mouse/keyboard/gamepad inputs, time, various configuration options/flags)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIO")]
		public static extern ImGuiIO* ImGui_GetIO();
		/// <summary>
		/// access the ImGuiPlatformIO structure (mostly hooks/functions to connect to platform/renderer and OS Clipboard, IME etc.)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetPlatformIO")]
		public static extern ImGuiPlatformIO* ImGui_GetPlatformIO();
		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetStyle")]
		public static extern ImGuiStyle* ImGui_GetStyle();
		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NewFrame")]
		public static extern void ImGui_NewFrame();
		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndFrame")]
		public static extern void ImGui_EndFrame();
		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Render")]
		public static extern void ImGui_Render();
		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetDrawData")]
		public static extern ImDrawData* ImGui_GetDrawData();
		/// <summary>
		/// <para>Demo, Debug, Information</para>
		/// </summary>
		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowDemoWindow")]
		public static extern void ImGui_ShowDemoWindow(byte* p_open);
		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowMetricsWindow")]
		public static extern void ImGui_ShowMetricsWindow(byte* p_open);
		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowDebugLogWindow")]
		public static extern void ImGui_ShowDebugLogWindow(byte* p_open);
		/// <summary>
		/// Implied p_open = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowIDStackToolWindow")]
		public static extern void ImGui_ShowIDStackToolWindow();
		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowIDStackToolWindowEx")]
		public static extern void ImGui_ShowIDStackToolWindowEx(byte* p_open);
		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowAboutWindow")]
		public static extern void ImGui_ShowAboutWindow(byte* p_open);
		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowStyleEditor")]
		public static extern void ImGui_ShowStyleEditor(ImGuiStyle* _ref);
		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowStyleSelector")]
		public static extern byte ImGui_ShowStyleSelector(byte* label);
		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowFontSelector")]
		public static extern void ImGui_ShowFontSelector(byte* label);
		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowUserGuide")]
		public static extern void ImGui_ShowUserGuide();
		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetVersion")]
		public static extern byte* ImGui_GetVersion();
		/// <summary>
		/// <para>Styles</para>
		/// </summary>
		/// <summary>
		/// new, recommended style (default)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_StyleColorsDark")]
		public static extern void ImGui_StyleColorsDark(ImGuiStyle* dst);
		/// <summary>
		/// best used with borders and a custom, thicker font
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_StyleColorsLight")]
		public static extern void ImGui_StyleColorsLight(ImGuiStyle* dst);
		/// <summary>
		/// classic imgui style
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_StyleColorsClassic")]
		public static extern void ImGui_StyleColorsClassic(ImGuiStyle* dst);
		/// <summary>
		/// <para>Windows</para>
		/// <para>- Begin() = push window to the stack and start appending to it. End() = pop window from the stack.</para>
		/// <para>- Passing 'bool* p_open != NULL' shows a window-closing widget in the upper-right corner of the window,</para>
		/// <para>  which clicking will set the boolean to false when clicked.</para>
		/// <para>- You may append multiple times to the same window during the same frame by calling Begin()/End() pairs multiple times.</para>
		/// <para>  Some information such as 'flags' or 'p_open' will only be considered by the first call to Begin().</para>
		/// <para>- Begin() return false to indicate the window is collapsed or fully clipped, so you may early out and omit submitting</para>
		/// <para>  anything to the window. Always call a matching End() for each Begin() call, regardless of its return value!</para>
		/// <para>  [Important: due to legacy reason, Begin/End and BeginChild/EndChild are inconsistent with all other functions</para>
		/// <para>   such as BeginMenu/EndMenu, BeginPopup/EndPopup, etc. where the EndXXX call should only be called if the corresponding</para>
		/// <para>   BeginXXX function returned true. Begin and BeginChild are the only odd ones out. Will be fixed in a future update.]</para>
		/// <para>- Note that the bottom of window stack always contains a window called "Debug".</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Begin")]
		public static extern byte ImGui_Begin(byte* name, byte* p_open, ImGuiWindowFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_End")]
		public static extern void ImGui_End();
		/// <summary>
		/// <para>Child Windows</para>
		/// <para>- Use child windows to begin into a self-contained independent scrolling/clipping regions within a host window. Child windows can embed their own child.</para>
		/// <para>- Before 1.90 (November 2023), the "ImGuiChildFlags child_flags = 0" parameter was "bool border = false".</para>
		/// <para>  This API is backward compatible with old code, as we guarantee that ImGuiChildFlags_Borders == true.</para>
		/// <para>  Consider updating your old code:</para>
		/// <para>     BeginChild("Name", size, false)   -&gt; Begin("Name", size, 0); or Begin("Name", size, ImGuiChildFlags_None);</para>
		/// <para>     BeginChild("Name", size, true)    -&gt; Begin("Name", size, ImGuiChildFlags_Borders);</para>
		/// <para>- Manual sizing (each axis can use a different setting e.g. ImVec2(0.0f, 400.0f)):</para>
		/// <para>    == 0.0f: use remaining parent window size for this axis.</para>
		/// <para>     &gt; 0.0f: use specified size for this axis.</para>
		/// <para>     &lt; 0.0f: right/bottom-align to specified distance from available content boundaries.</para>
		/// <para>- Specifying ImGuiChildFlags_AutoResizeX or ImGuiChildFlags_AutoResizeY makes the sizing automatic based on child contents.</para>
		/// <para>  Combining both ImGuiChildFlags_AutoResizeX _and_ ImGuiChildFlags_AutoResizeY defeats purpose of a scrolling region and is NOT recommended.</para>
		/// <para>- BeginChild() returns false to indicate the window is collapsed or fully clipped, so you may early out and omit submitting</para>
		/// <para>  anything to the window. Always call a matching EndChild() for each BeginChild() call, regardless of its return value.</para>
		/// <para>  [Important: due to legacy reason, Begin/End and BeginChild/EndChild are inconsistent with all other functions</para>
		/// <para>   such as BeginMenu/EndMenu, BeginPopup/EndPopup, etc. where the EndXXX call should only be called if the corresponding</para>
		/// <para>   BeginXXX function returned true. Begin and BeginChild are the only odd ones out. Will be fixed in a future update.]</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginChild")]
		public static extern byte ImGui_BeginChild(byte* str_id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginChildID")]
		public static extern byte ImGui_BeginChildID(uint id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndChild")]
		public static extern void ImGui_EndChild();
		/// <summary>
		/// <para>Windows Utilities</para>
		/// <para>- 'current window' = the window we are appending into while inside a Begin()/End() block. 'next window' = next window we will Begin() into.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowAppearing")]
		public static extern byte ImGui_IsWindowAppearing();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowCollapsed")]
		public static extern byte ImGui_IsWindowCollapsed();
		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowFocused")]
		public static extern byte ImGui_IsWindowFocused(ImGuiFocusedFlags flags);
		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowHovered")]
		public static extern byte ImGui_IsWindowHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowDrawList")]
		public static extern ImDrawList* ImGui_GetWindowDrawList();
		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowDpiScale")]
		public static extern float ImGui_GetWindowDpiScale();
		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowPos")]
		public static extern Vector2 ImGui_GetWindowPos();
		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowSize")]
		public static extern Vector2 ImGui_GetWindowSize();
		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowWidth")]
		public static extern float ImGui_GetWindowWidth();
		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowHeight")]
		public static extern float ImGui_GetWindowHeight();
		/// <summary>
		/// get viewport currently associated to the current window.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowViewport")]
		public static extern ImGuiViewport* ImGui_GetWindowViewport();
		/// <summary>
		/// <para>Window manipulation</para>
		/// <para>- Prefer using SetNextXXX functions (before Begin) rather that SetXXX functions (after Begin).</para>
		/// </summary>
		/// <summary>
		/// Implied pivot = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowPos")]
		public static extern void ImGui_SetNextWindowPos(Vector2 pos, ImGuiCond cond);
		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowPosEx")]
		public static extern void ImGui_SetNextWindowPosEx(Vector2 pos, ImGuiCond cond, Vector2 pivot);
		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowSize")]
		public static extern void ImGui_SetNextWindowSize(Vector2 size, ImGuiCond cond);
		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowSizeConstraints")]
		public static extern void ImGui_SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowContentSize")]
		public static extern void ImGui_SetNextWindowContentSize(Vector2 size);
		/// <summary>
		/// set next window collapsed state. call before Begin()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowCollapsed")]
		public static extern void ImGui_SetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
		/// <summary>
		/// set next window to be focused / top-most. call before Begin()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowFocus")]
		public static extern void ImGui_SetNextWindowFocus();
		/// <summary>
		/// set next window scrolling value (use &lt; 0.0f to not affect a given axis).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowScroll")]
		public static extern void ImGui_SetNextWindowScroll(Vector2 scroll);
		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowBgAlpha")]
		public static extern void ImGui_SetNextWindowBgAlpha(float alpha);
		/// <summary>
		/// set next window viewport
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowViewport")]
		public static extern void ImGui_SetNextWindowViewport(uint viewport_id);
		/// <summary>
		/// (not recommended) set current window position - call within Begin()/End(). prefer using SetNextWindowPos(), as this may incur tearing and side-effects.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowPos")]
		public static extern void ImGui_SetWindowPos(Vector2 pos, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window size - call within Begin()/End(). set to ImVec2(0, 0) to force an auto-fit. prefer using SetNextWindowSize(), as this may incur tearing and minor side-effects.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowSize")]
		public static extern void ImGui_SetWindowSize(Vector2 size, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window collapsed state. prefer using SetNextWindowCollapsed().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowCollapsed")]
		public static extern void ImGui_SetWindowCollapsed(byte collapsed, ImGuiCond cond);
		/// <summary>
		/// (not recommended) set current window to be focused / top-most. prefer using SetNextWindowFocus().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowFocus")]
		public static extern void ImGui_SetWindowFocus();
		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowFontScale")]
		public static extern void ImGui_SetWindowFontScale(float scale);
		/// <summary>
		/// set named window position.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowPosStr")]
		public static extern void ImGui_SetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
		/// <summary>
		/// set named window size. set axis to 0.0f to force an auto-fit on this axis.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowSizeStr")]
		public static extern void ImGui_SetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
		/// <summary>
		/// set named window collapsed state
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowCollapsedStr")]
		public static extern void ImGui_SetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowFocusStr")]
		public static extern void ImGui_SetWindowFocusStr(byte* name);
		/// <summary>
		/// <para>Windows Scrolling</para>
		/// <para>- Any change of Scroll will be applied at the beginning of next frame in the first call to Begin().</para>
		/// <para>- You may instead use SetNextWindowScroll() prior to calling Begin() to avoid this delay, as an alternative to using SetScrollX()/SetScrollY().</para>
		/// </summary>
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetScrollX")]
		public static extern float ImGui_GetScrollX();
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetScrollY")]
		public static extern float ImGui_GetScrollY();
		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxX()]
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollX")]
		public static extern void ImGui_SetScrollX(float scroll_x);
		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxY()]
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollY")]
		public static extern void ImGui_SetScrollY(float scroll_y);
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetScrollMaxX")]
		public static extern float ImGui_GetScrollMaxX();
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetScrollMaxY")]
		public static extern float ImGui_GetScrollMaxY();
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollHereX")]
		public static extern void ImGui_SetScrollHereX(float center_x_ratio);
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollHereY")]
		public static extern void ImGui_SetScrollHereY(float center_y_ratio);
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollFromPosX")]
		public static extern void ImGui_SetScrollFromPosX(float local_x, float center_x_ratio);
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollFromPosY")]
		public static extern void ImGui_SetScrollFromPosY(float local_y, float center_y_ratio);
		/// <summary>
		/// <para>Parameters stacks (shared)</para>
		/// </summary>
		/// <summary>
		/// use NULL as a shortcut to push default font
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushFont")]
		public static extern void ImGui_PushFont(ImFont* font);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopFont")]
		public static extern void ImGui_PopFont();
		/// <summary>
		/// modify a style color. always use this if you modify the style after NewFrame().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushStyleColor")]
		public static extern void ImGui_PushStyleColor(ImGuiCol idx, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushStyleColorImVec4")]
		public static extern void ImGui_PushStyleColorImVec4(ImGuiCol idx, Vector4 col);
		/// <summary>
		/// Implied count = 1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopStyleColor")]
		public static extern void ImGui_PopStyleColor();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopStyleColorEx")]
		public static extern void ImGui_PopStyleColorEx(int count);
		/// <summary>
		/// modify a style float variable. always use this if you modify the style after NewFrame()!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushStyleVar")]
		public static extern void ImGui_PushStyleVar(ImGuiStyleVar idx, float val);
		/// <summary>
		/// modify a style ImVec2 variable. "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushStyleVarImVec2")]
		public static extern void ImGui_PushStyleVarImVec2(ImGuiStyleVar idx, Vector2 val);
		/// <summary>
		/// modify X component of a style ImVec2 variable. "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushStyleVarX")]
		public static extern void ImGui_PushStyleVarX(ImGuiStyleVar idx, float val_x);
		/// <summary>
		/// modify Y component of a style ImVec2 variable. "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushStyleVarY")]
		public static extern void ImGui_PushStyleVarY(ImGuiStyleVar idx, float val_y);
		/// <summary>
		/// Implied count = 1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopStyleVar")]
		public static extern void ImGui_PopStyleVar();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopStyleVarEx")]
		public static extern void ImGui_PopStyleVarEx(int count);
		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushItemFlag")]
		public static extern void ImGui_PushItemFlag(ImGuiItemFlags option, byte enabled);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopItemFlag")]
		public static extern void ImGui_PopItemFlag();
		/// <summary>
		/// <para>Parameters stacks (current window)</para>
		/// </summary>
		/// <summary>
		/// push width of items for common large "item+label" widgets. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushItemWidth")]
		public static extern void ImGui_PushItemWidth(float item_width);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopItemWidth")]
		public static extern void ImGui_PopItemWidth();
		/// <summary>
		/// set width of the _next_ common large "item+label" widget. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemWidth")]
		public static extern void ImGui_SetNextItemWidth(float item_width);
		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcItemWidth")]
		public static extern float ImGui_CalcItemWidth();
		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushTextWrapPos")]
		public static extern void ImGui_PushTextWrapPos(float wrap_local_pos_x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopTextWrapPos")]
		public static extern void ImGui_PopTextWrapPos();
		/// <summary>
		/// <para>Style read access</para>
		/// <para>- Use the ShowStyleEditor() function to interactively see/edit the colors.</para>
		/// </summary>
		/// <summary>
		/// get current font
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFont")]
		public static extern ImFont* ImGui_GetFont();
		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFontSize")]
		public static extern float ImGui_GetFontSize();
		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFontTexUvWhitePixel")]
		public static extern Vector2 ImGui_GetFontTexUvWhitePixel();
		/// <summary>
		/// Implied alpha_mul = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColorU32")]
		public static extern uint ImGui_GetColorU32(ImGuiCol idx);
		/// <summary>
		/// retrieve given style color with style alpha applied and optional extra alpha multiplier, packed as a 32-bit value suitable for ImDrawList
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColorU32Ex")]
		public static extern uint ImGui_GetColorU32Ex(ImGuiCol idx, float alpha_mul);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColorU32ImVec4")]
		public static extern uint ImGui_GetColorU32ImVec4(Vector4 col);
		/// <summary>
		/// Implied alpha_mul = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColorU32ImU32")]
		public static extern uint ImGui_GetColorU32ImU32(uint col);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColorU32ImU32Ex")]
		public static extern uint ImGui_GetColorU32ImU32Ex(uint col, float alpha_mul);
		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetStyleColorVec4")]
		public static extern Vector4* ImGui_GetStyleColorVec4(ImGuiCol idx);
		/// <summary>
		/// <para>Layout cursor positioning</para>
		/// <para>- By "cursor" we mean the current output position.</para>
		/// <para>- The typical widget behavior is to output themselves at the current cursor position, then move the cursor one line down.</para>
		/// <para>- You can call SameLine() between widgets to undo the last carriage return and output at the right of the preceding widget.</para>
		/// <para>- YOU CAN DO 99% OF WHAT YOU NEED WITH ONLY GetCursorScreenPos() and GetContentRegionAvail().</para>
		/// <para>- Attention! We currently have inconsistencies between window-local and absolute positions we will aim to fix with future API:</para>
		/// <para>   - Absolute coordinate:        GetCursorScreenPos(), SetCursorScreenPos(), all ImDrawList:: functions. -&gt; this is the preferred way forward.</para>
		/// <para>   - Window-local coordinates:   SameLine(offset), GetCursorPos(), SetCursorPos(), GetCursorStartPos(), PushTextWrapPos()</para>
		/// <para>   - Window-local coordinates:   GetContentRegionMax(), GetWindowContentRegionMin(), GetWindowContentRegionMax() --&gt; all obsoleted. YOU DON'T NEED THEM.</para>
		/// <para>- GetCursorScreenPos() = GetCursorPos() + GetWindowPos(). GetWindowPos() is almost only ever useful to convert from window-local to absolute coordinates. Try not to use it.</para>
		/// </summary>
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCursorScreenPos")]
		public static extern Vector2 ImGui_GetCursorScreenPos();
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCursorScreenPos")]
		public static extern void ImGui_SetCursorScreenPos(Vector2 pos);
		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetContentRegionAvail")]
		public static extern Vector2 ImGui_GetContentRegionAvail();
		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCursorPos")]
		public static extern Vector2 ImGui_GetCursorPos();
		/// <summary>
		/// [window-local] "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCursorPosX")]
		public static extern float ImGui_GetCursorPosX();
		/// <summary>
		/// [window-local] "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCursorPosY")]
		public static extern float ImGui_GetCursorPosY();
		/// <summary>
		/// [window-local] "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCursorPos")]
		public static extern void ImGui_SetCursorPos(Vector2 local_pos);
		/// <summary>
		/// [window-local] "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCursorPosX")]
		public static extern void ImGui_SetCursorPosX(float local_x);
		/// <summary>
		/// [window-local] "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCursorPosY")]
		public static extern void ImGui_SetCursorPosY(float local_y);
		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCursorStartPos")]
		public static extern Vector2 ImGui_GetCursorStartPos();
		/// <summary>
		/// <para>Other layout functions</para>
		/// </summary>
		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Separator")]
		public static extern void ImGui_Separator();
		/// <summary>
		/// Implied offset_from_start_x = 0.0f, spacing = -1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SameLine")]
		public static extern void ImGui_SameLine();
		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SameLineEx")]
		public static extern void ImGui_SameLineEx(float offset_from_start_x, float spacing);
		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NewLine")]
		public static extern void ImGui_NewLine();
		/// <summary>
		/// add vertical spacing.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Spacing")]
		public static extern void ImGui_Spacing();
		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Dummy")]
		public static extern void ImGui_Dummy(Vector2 size);
		/// <summary>
		/// Implied indent_w = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Indent")]
		public static extern void ImGui_Indent();
		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w &lt;= 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IndentEx")]
		public static extern void ImGui_IndentEx(float indent_w);
		/// <summary>
		/// Implied indent_w = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Unindent")]
		public static extern void ImGui_Unindent();
		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w &lt;= 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UnindentEx")]
		public static extern void ImGui_UnindentEx(float indent_w);
		/// <summary>
		/// lock horizontal starting position
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginGroup")]
		public static extern void ImGui_BeginGroup();
		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndGroup")]
		public static extern void ImGui_EndGroup();
		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_AlignTextToFramePadding")]
		public static extern void ImGui_AlignTextToFramePadding();
		/// <summary>
		/// ~ FontSize
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTextLineHeight")]
		public static extern float ImGui_GetTextLineHeight();
		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTextLineHeightWithSpacing")]
		public static extern float ImGui_GetTextLineHeightWithSpacing();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFrameHeight")]
		public static extern float ImGui_GetFrameHeight();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFrameHeightWithSpacing")]
		public static extern float ImGui_GetFrameHeightWithSpacing();
		/// <summary>
		/// <para>ID stack/scopes</para>
		/// <para>Read the FAQ (docs/FAQ.md or http://dearimgui.com/faq) for more details about how ID are handled in dear imgui.</para>
		/// <para>- Those questions are answered and impacted by understanding of the ID stack system:</para>
		/// <para>  - "Q: Why is my widget not reacting when I click on it?"</para>
		/// <para>  - "Q: How can I have widgets with an empty label?"</para>
		/// <para>  - "Q: How can I have multiple widgets with the same label?"</para>
		/// <para>- Short version: ID are hashes of the entire ID stack. If you are creating widgets in a loop you most likely</para>
		/// <para>  want to push a unique identifier (e.g. object pointer, loop index) to uniquely differentiate them.</para>
		/// <para>- You can also use the "Label##foobar" syntax within widget label to distinguish them from each others.</para>
		/// <para>- In this header file we use the "label"/"name" terminology to denote a string that will be displayed + used as an ID,</para>
		/// <para>  whereas "str_id" denote a string that is only used as an ID and not normally displayed.</para>
		/// </summary>
		/// <summary>
		/// push string into the ID stack (will hash string).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushID")]
		public static extern void ImGui_PushID(byte* str_id);
		/// <summary>
		/// push string into the ID stack (will hash string).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushIDStr")]
		public static extern void ImGui_PushIDStr(byte* str_id_begin, byte* str_id_end);
		/// <summary>
		/// push pointer into the ID stack (will hash pointer).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushIDPtr")]
		public static extern void ImGui_PushIDPtr(void* ptr_id);
		/// <summary>
		/// push integer into the ID stack (will hash integer).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushIDInt")]
		public static extern void ImGui_PushIDInt(int int_id);
		/// <summary>
		/// pop from the ID stack.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopID")]
		public static extern void ImGui_PopID();
		/// <summary>
		/// calculate unique ID (hash of whole ID stack + given parameter). e.g. if you want to query into ImGuiStorage yourself
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetID")]
		public static extern uint ImGui_GetID(byte* str_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIDStr")]
		public static extern uint ImGui_GetIDStr(byte* str_id_begin, byte* str_id_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIDPtr")]
		public static extern uint ImGui_GetIDPtr(void* ptr_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIDInt")]
		public static extern uint ImGui_GetIDInt(int int_id);
		/// <summary>
		/// <para>Widgets: Text</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextUnformatted")]
		public static extern void ImGui_TextUnformatted(byte* text);
		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextUnformattedEx")]
		public static extern void ImGui_TextUnformattedEx(byte* text, byte* text_end);
		/// <summary>
		/// formatted text
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Text")]
		public static extern void ImGui_Text(byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextColored")]
		public static extern void ImGui_TextColored(Vector4 col, byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextColoredUnformatted")]
		public static extern void ImGui_TextColoredUnformatted(Vector4 col, byte* text);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextDisabled")]
		public static extern void ImGui_TextDisabled(byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextDisabledUnformatted")]
		public static extern void ImGui_TextDisabledUnformatted(byte* text);
		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextWrapped")]
		public static extern void ImGui_TextWrapped(byte* fmt);
		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextWrappedUnformatted")]
		public static extern void ImGui_TextWrappedUnformatted(byte* text);
		/// <summary>
		/// display text+label aligned the same way as value+label widgets
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LabelText")]
		public static extern void ImGui_LabelText(byte* label, byte* fmt);
		/// <summary>
		/// display text+label aligned the same way as value+label widgets
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LabelTextUnformatted")]
		public static extern void ImGui_LabelTextUnformatted(byte* label, byte* text);
		/// <summary>
		/// shortcut for Bullet()+Text()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BulletText")]
		public static extern void ImGui_BulletText(byte* fmt);
		/// <summary>
		/// shortcut for Bullet()+Text()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BulletTextUnformatted")]
		public static extern void ImGui_BulletTextUnformatted(byte* text);
		/// <summary>
		/// currently: formatted text with an horizontal line
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SeparatorText")]
		public static extern void ImGui_SeparatorText(byte* label);
		/// <summary>
		/// <para>Widgets: Main</para>
		/// <para>- Most widgets return true when the value has been changed or when pressed/selected</para>
		/// <para>- You may also use one of the many IsItemXXX functions (e.g. IsItemActive, IsItemHovered, etc.) to query widget state.</para>
		/// </summary>
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Button")]
		public static extern byte ImGui_Button(byte* label);
		/// <summary>
		/// button
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ButtonEx")]
		public static extern byte ImGui_ButtonEx(byte* label, Vector2 size);
		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SmallButton")]
		public static extern byte ImGui_SmallButton(byte* label);
		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InvisibleButton")]
		public static extern byte ImGui_InvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
		/// <summary>
		/// square button with an arrow shape
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ArrowButton")]
		public static extern byte ImGui_ArrowButton(byte* str_id, ImGuiDir dir);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Checkbox")]
		public static extern byte ImGui_Checkbox(byte* label, byte* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CheckboxFlagsIntPtr")]
		public static extern byte ImGui_CheckboxFlagsIntPtr(byte* label, int* flags, int flags_value);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CheckboxFlagsUintPtr")]
		public static extern byte ImGui_CheckboxFlagsUintPtr(byte* label, uint* flags, uint flags_value);
		/// <summary>
		/// use with e.g. if (RadioButton("one", my_value==1)) { my_value = 1; }
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RadioButton")]
		public static extern byte ImGui_RadioButton(byte* label, byte active);
		/// <summary>
		/// shortcut to handle the above pattern when value is an integer
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RadioButtonIntPtr")]
		public static extern byte ImGui_RadioButtonIntPtr(byte* label, int* v, int v_button);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ProgressBar")]
		public static extern void ImGui_ProgressBar(float fraction, Vector2 size_arg, byte* overlay);
		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Bullet")]
		public static extern void ImGui_Bullet();
		/// <summary>
		/// hyperlink text button, return true when clicked
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextLink")]
		public static extern byte ImGui_TextLink(byte* label);
		/// <summary>
		/// Implied url = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextLinkOpenURL")]
		public static extern void ImGui_TextLinkOpenURL(byte* label);
		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextLinkOpenURLEx")]
		public static extern void ImGui_TextLinkOpenURLEx(byte* label, byte* url);
		/// <summary>
		/// <para>Widgets: Images</para>
		/// <para>- Read about ImTextureID here: https://github.com/ocornut/imgui/wiki/Image-Loading-and-Displaying-Examples</para>
		/// <para>- 'uv0' and 'uv1' are texture coordinates. Read about them from the same link above.</para>
		/// <para>- Note that Image() may add +2.0f to provided size if a border is visible, ImageButton() adds style.FramePadding*2.0f to provided size.</para>
		/// </summary>
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), tint_col = ImVec4(1, 1, 1, 1), border_col = ImVec4(0, 0, 0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Image")]
		public static extern void ImGui_Image(IntPtr user_texture_id, Vector2 image_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ImageEx")]
		public static extern void ImGui_ImageEx(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), bg_col = ImVec4(0, 0, 0, 0), tint_col = ImVec4(1, 1, 1, 1)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ImageButton")]
		public static extern byte ImGui_ImageButton(byte* str_id, IntPtr user_texture_id, Vector2 image_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ImageButtonEx")]
		public static extern byte ImGui_ImageButtonEx(byte* str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);
		/// <summary>
		/// <para>Widgets: Combo Box (Dropdown)</para>
		/// <para>- The BeginCombo()/EndCombo() api allows you to manage your contents and selection state however you want it, by creating e.g. Selectable() items.</para>
		/// <para>- The old Combo() api are helpers over BeginCombo()/EndCombo() which are kept available for convenience purpose. This is analogous to how ListBox are created.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginCombo")]
		public static extern byte ImGui_BeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndCombo")]
		public static extern void ImGui_EndCombo();
		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ComboChar")]
		public static extern byte ImGui_ComboChar(byte* label, int* current_item, byte** items, int items_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ComboCharEx")]
		public static extern byte ImGui_ComboCharEx(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Combo")]
		public static extern byte ImGui_Combo(byte* label, int* current_item, byte* items_separated_by_zeros);
		/// <summary>
		/// Separate items with \0 within a string, end item-list with \0\0. e.g. "One\0Two\0Three\0"
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ComboEx")]
		public static extern byte ImGui_ComboEx(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ComboCallback")]
		public static extern byte ImGui_ComboCallback(byte* label, int* current_item, ImGui_ComboCallbackgetterDelegate getter, void* user_data, int items_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ComboCallbackEx")]
		public static extern byte ImGui_ComboCallbackEx(byte* label, int* current_item, ImGui_ComboCallbackExgetterDelegate getter, void* user_data, int items_count, int popup_max_height_in_items);
		/// <summary>
		/// <para>Widgets: Drag Sliders</para>
		/// <para>- CTRL+Click on any drag box to turn them into an input box. Manually input values aren't clamped by default and can go off-bounds. Use ImGuiSliderFlags_AlwaysClamp to always clamp.</para>
		/// <para>- For all the Float2/Float3/Float4/Int2/Int3/Int4 versions of every function, note that a 'float v[X]' function argument is the same as 'float* v',</para>
		/// <para>  the array syntax is just a way to document the number of elements that are expected to be accessible. You can pass address of your first element out of a contiguous set, e.g. &amp;myvector.x</para>
		/// <para>- Adjust format string to decorate the value with a prefix, a suffix, or adapt the editing and display precision e.g. "%.3f" -&gt; 1.234; "%5.2f secs" -&gt; 01.23 secs; "Biscuit: %.0f" -&gt; Biscuit: 1; etc.</para>
		/// <para>- Format string may also be set to NULL or use the default format ("%f" or "%d").</para>
		/// <para>- Speed are per-pixel of mouse movement (v_speed=0.2f: mouse needs to move by 5 pixels to increase value by 1). For keyboard/gamepad navigation, minimum speed is Max(v_speed, minimum_step_at_given_precision).</para>
		/// <para>- Use v_min &lt; v_max to clamp edits to given limits. Note that CTRL+Click manual input can override those limits if ImGuiSliderFlags_AlwaysClamp is not used.</para>
		/// <para>- Use v_max = FLT_MAX / INT_MAX etc to avoid clamping to a maximum, same with v_min = -FLT_MAX / INT_MIN to avoid clamping to a minimum.</para>
		/// <para>- We use the same sets of flags for DragXXX() and SliderXXX() functions as the features are the same and it makes it easier to swap them.</para>
		/// <para>- Legacy: Pre-1.78 there are DragXXX() function signatures that take a final `float power=1.0f' argument instead of the `ImGuiSliderFlags flags=0' argument.</para>
		/// <para>  If you get a warning converting a float to ImGuiSliderFlags, read https://github.com/ocornut/imgui/issues/3361</para>
		/// </summary>
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat")]
		public static extern byte ImGui_DragFloat(byte* label, float* v);
		/// <summary>
		/// If v_min &gt;= v_max we have no bound
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloatEx")]
		public static extern byte ImGui_DragFloatEx(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat2")]
		public static extern byte ImGui_DragFloat2(byte* label, Vector2* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat2Ex")]
		public static extern byte ImGui_DragFloat2Ex(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat3")]
		public static extern byte ImGui_DragFloat3(byte* label, Vector3* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat3Ex")]
		public static extern byte ImGui_DragFloat3Ex(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat4")]
		public static extern byte ImGui_DragFloat4(byte* label, Vector4* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloat4Ex")]
		public static extern byte ImGui_DragFloat4Ex(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloatRange2")]
		public static extern byte ImGui_DragFloatRange2(byte* label, float* v_current_min, float* v_current_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragFloatRange2Ex")]
		public static extern byte ImGui_DragFloatRange2Ex(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt")]
		public static extern byte ImGui_DragInt(byte* label, int* v);
		/// <summary>
		/// If v_min &gt;= v_max we have no bound
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragIntEx")]
		public static extern byte ImGui_DragIntEx(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt2")]
		public static extern byte ImGui_DragInt2(byte* label, int* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt2Ex")]
		public static extern byte ImGui_DragInt2Ex(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt3")]
		public static extern byte ImGui_DragInt3(byte* label, int* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt3Ex")]
		public static extern byte ImGui_DragInt3Ex(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt4")]
		public static extern byte ImGui_DragInt4(byte* label, int* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragInt4Ex")]
		public static extern byte ImGui_DragInt4Ex(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragIntRange2")]
		public static extern byte ImGui_DragIntRange2(byte* label, int* v_current_min, int* v_current_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragIntRange2Ex")]
		public static extern byte ImGui_DragIntRange2Ex(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragScalar")]
		public static extern byte ImGui_DragScalar(byte* label, ImGuiDataType data_type, void* p_data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragScalarEx")]
		public static extern byte ImGui_DragScalarEx(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragScalarN")]
		public static extern byte ImGui_DragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragScalarNEx")]
		public static extern byte ImGui_DragScalarNEx(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// <para>Widgets: Regular Sliders</para>
		/// <para>- CTRL+Click on any slider to turn them into an input box. Manually input values aren't clamped by default and can go off-bounds. Use ImGuiSliderFlags_AlwaysClamp to always clamp.</para>
		/// <para>- Adjust format string to decorate the value with a prefix, a suffix, or adapt the editing and display precision e.g. "%.3f" -&gt; 1.234; "%5.2f secs" -&gt; 01.23 secs; "Biscuit: %.0f" -&gt; Biscuit: 1; etc.</para>
		/// <para>- Format string may also be set to NULL or use the default format ("%f" or "%d").</para>
		/// <para>- Legacy: Pre-1.78 there are SliderXXX() function signatures that take a final `float power=1.0f' argument instead of the `ImGuiSliderFlags flags=0' argument.</para>
		/// <para>  If you get a warning converting a float to ImGuiSliderFlags, read https://github.com/ocornut/imgui/issues/3361</para>
		/// </summary>
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat")]
		public static extern byte ImGui_SliderFloat(byte* label, float* v, float v_min, float v_max);
		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloatEx")]
		public static extern byte ImGui_SliderFloatEx(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat2")]
		public static extern byte ImGui_SliderFloat2(byte* label, Vector2* v, float v_min, float v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat2Ex")]
		public static extern byte ImGui_SliderFloat2Ex(byte* label, Vector2* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat3")]
		public static extern byte ImGui_SliderFloat3(byte* label, Vector3* v, float v_min, float v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat3Ex")]
		public static extern byte ImGui_SliderFloat3Ex(byte* label, Vector3* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat4")]
		public static extern byte ImGui_SliderFloat4(byte* label, Vector4* v, float v_min, float v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderFloat4Ex")]
		public static extern byte ImGui_SliderFloat4Ex(byte* label, Vector4* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied v_degrees_min = -360.0f, v_degrees_max = +360.0f, format = "%.0f deg", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderAngle")]
		public static extern byte ImGui_SliderAngle(byte* label, float* v_rad);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderAngleEx")]
		public static extern byte ImGui_SliderAngleEx(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt")]
		public static extern byte ImGui_SliderInt(byte* label, int* v, int v_min, int v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderIntEx")]
		public static extern byte ImGui_SliderIntEx(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt2")]
		public static extern byte ImGui_SliderInt2(byte* label, int* v, int v_min, int v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt2Ex")]
		public static extern byte ImGui_SliderInt2Ex(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt3")]
		public static extern byte ImGui_SliderInt3(byte* label, int* v, int v_min, int v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt3Ex")]
		public static extern byte ImGui_SliderInt3Ex(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt4")]
		public static extern byte ImGui_SliderInt4(byte* label, int* v, int v_min, int v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderInt4Ex")]
		public static extern byte ImGui_SliderInt4Ex(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderScalar")]
		public static extern byte ImGui_SliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderScalarEx")]
		public static extern byte ImGui_SliderScalarEx(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderScalarN")]
		public static extern byte ImGui_SliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderScalarNEx")]
		public static extern byte ImGui_SliderScalarNEx(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_VSliderFloat")]
		public static extern byte ImGui_VSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_VSliderFloatEx")]
		public static extern byte ImGui_VSliderFloatEx(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_VSliderInt")]
		public static extern byte ImGui_VSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_VSliderIntEx")]
		public static extern byte ImGui_VSliderIntEx(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_VSliderScalar")]
		public static extern byte ImGui_VSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_VSliderScalarEx")]
		public static extern byte ImGui_VSliderScalarEx(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// <para>Widgets: Input with Keyboard</para>
		/// <para>- If you want to use InputText() with std::string or any custom dynamic string type, see misc/cpp/imgui_stdlib.h and comments in imgui_demo.cpp.</para>
		/// <para>- Most of the ImGuiInputTextFlags flags are only useful for InputText() and not for InputFloatX, InputIntX, InputDouble etc.</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputText")]
		public static extern byte ImGui_InputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextEx")]
		public static extern byte ImGui_InputTextEx(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, callback = NULL, user_data = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextMultiline")]
		public static extern byte ImGui_InputTextMultiline(byte* label, byte* buf, uint buf_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextMultilineEx")]
		public static extern byte ImGui_InputTextMultilineEx(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextWithHint")]
		public static extern byte ImGui_InputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextWithHintEx")]
		public static extern byte ImGui_InputTextWithHintEx(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		/// <summary>
		/// Implied step = 0.0f, step_fast = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat")]
		public static extern byte ImGui_InputFloat(byte* label, float* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloatEx")]
		public static extern byte ImGui_InputFloatEx(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat2")]
		public static extern byte ImGui_InputFloat2(byte* label, Vector2* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat2Ex")]
		public static extern byte ImGui_InputFloat2Ex(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat3")]
		public static extern byte ImGui_InputFloat3(byte* label, Vector3* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat3Ex")]
		public static extern byte ImGui_InputFloat3Ex(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat4")]
		public static extern byte ImGui_InputFloat4(byte* label, Vector4* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputFloat4Ex")]
		public static extern byte ImGui_InputFloat4Ex(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied step = 1, step_fast = 100, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputInt")]
		public static extern byte ImGui_InputInt(byte* label, int* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputIntEx")]
		public static extern byte ImGui_InputIntEx(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputInt2")]
		public static extern byte ImGui_InputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputInt3")]
		public static extern byte ImGui_InputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputInt4")]
		public static extern byte ImGui_InputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied step = 0.0, step_fast = 0.0, format = "%.6f", flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputDouble")]
		public static extern byte ImGui_InputDouble(byte* label, double* v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputDoubleEx")]
		public static extern byte ImGui_InputDoubleEx(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputScalar")]
		public static extern byte ImGui_InputScalar(byte* label, ImGuiDataType data_type, void* p_data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputScalarEx")]
		public static extern byte ImGui_InputScalarEx(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputScalarN")]
		public static extern byte ImGui_InputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputScalarNEx")]
		public static extern byte ImGui_InputScalarNEx(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
		/// <summary>
		/// <para>Widgets: Color Editor/Picker (tip: the ColorEdit* functions have a little color square that can be left-clicked to open a picker, and right-clicked to open an option menu.)</para>
		/// <para>- Note that in C++ a 'float v[X]' function argument is the _same_ as 'float* v', the array syntax is just a way to document the number of elements that are expected to be accessible.</para>
		/// <para>- You can pass the address of a first float element out of a contiguous structure, e.g. &amp;myvector.x</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorEdit3")]
		public static extern byte ImGui_ColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorEdit4")]
		public static extern byte ImGui_ColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorPicker3")]
		public static extern byte ImGui_ColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorPicker4")]
		public static extern byte ImGui_ColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorButton")]
		public static extern byte ImGui_ColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags);
		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorButtonEx")]
		public static extern byte ImGui_ColorButtonEx(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetColorEditOptions")]
		public static extern void ImGui_SetColorEditOptions(ImGuiColorEditFlags flags);
		/// <summary>
		/// <para>Widgets: Trees</para>
		/// <para>- TreeNode functions return true when the node is open, in which case you need to also call TreePop() when you are finished displaying the tree node contents.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNode")]
		public static extern byte ImGui_TreeNode(byte* label);
		/// <summary>
		/// helper variation to easily decorelate the id from the displayed string. Read the FAQ about why and how to use ID. to align arbitrary text at the same level as a TreeNode() you can use Bullet().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeStr")]
		public static extern byte ImGui_TreeNodeStr(byte* str_id, byte* fmt);
		/// <summary>
		/// helper variation to easily decorelate the id from the displayed string. Read the FAQ about why and how to use ID. to align arbitrary text at the same level as a TreeNode() you can use Bullet().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeStrUnformatted")]
		public static extern byte ImGui_TreeNodeStrUnformatted(byte* str_id, byte* text);
		/// <summary>
		/// "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodePtr")]
		public static extern byte ImGui_TreeNodePtr(void* ptr_id, byte* fmt);
		/// <summary>
		/// "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodePtrUnformatted")]
		public static extern byte ImGui_TreeNodePtrUnformatted(void* ptr_id, byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeEx")]
		public static extern byte ImGui_TreeNodeEx(byte* label, ImGuiTreeNodeFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeExStr")]
		public static extern byte ImGui_TreeNodeExStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeExStrUnformatted")]
		public static extern byte ImGui_TreeNodeExStrUnformatted(byte* str_id, ImGuiTreeNodeFlags flags, byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeExPtr")]
		public static extern byte ImGui_TreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeExPtrUnformatted")]
		public static extern byte ImGui_TreeNodeExPtrUnformatted(void* ptr_id, ImGuiTreeNodeFlags flags, byte* text);
		/// <summary>
		/// ~ Indent()+PushID(). Already called by TreeNode() when returning true, but you can call TreePush/TreePop yourself if desired.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreePush")]
		public static extern void ImGui_TreePush(byte* str_id);
		/// <summary>
		/// "
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreePushPtr")]
		public static extern void ImGui_TreePushPtr(void* ptr_id);
		/// <summary>
		/// ~ Unindent()+PopID()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreePop")]
		public static extern void ImGui_TreePop();
		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTreeNodeToLabelSpacing")]
		public static extern float ImGui_GetTreeNodeToLabelSpacing();
		/// <summary>
		/// if returning 'true' the header is open. doesn't indent nor push on ID stack. user doesn't have to call TreePop().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CollapsingHeader")]
		public static extern byte ImGui_CollapsingHeader(byte* label, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CollapsingHeaderBoolPtr")]
		public static extern byte ImGui_CollapsingHeaderBoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemOpen")]
		public static extern void ImGui_SetNextItemOpen(byte is_open, ImGuiCond cond);
		/// <summary>
		/// set id to use for open/close storage (default to same as item id).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemStorageID")]
		public static extern void ImGui_SetNextItemStorageID(uint storage_id);
		/// <summary>
		/// <para>Widgets: Selectables</para>
		/// <para>- A selectable highlights when hovered, and can display another color when selected.</para>
		/// <para>- Neighbors selectable extend their highlight bounds in order to leave no gap between them. This is so a series of selected Selectable appear contiguous.</para>
		/// </summary>
		/// <summary>
		/// Implied selected = false, flags = 0, size = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Selectable")]
		public static extern byte ImGui_Selectable(byte* label);
		/// <summary>
		/// "bool selected" carry the selection state (read-only). Selectable() is clicked is returns true so you can modify your selection state. size.x==0.0: use remaining width, size.x&gt;0.0: specify width. size.y==0.0: use label height, size.y&gt;0.0: specify height
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SelectableEx")]
		public static extern byte ImGui_SelectableEx(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SelectableBoolPtr")]
		public static extern byte ImGui_SelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags);
		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SelectableBoolPtrEx")]
		public static extern byte ImGui_SelectableBoolPtrEx(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
		/// <summary>
		/// <para>Multi-selection system for Selectable(), Checkbox(), TreeNode() functions [BETA]</para>
		/// <para>- This enables standard multi-selection/range-selection idioms (CTRL+Mouse/Keyboard, SHIFT+Mouse/Keyboard, etc.) in a way that also allow a clipper to be used.</para>
		/// <para>- ImGuiSelectionUserData is often used to store your item index within the current view (but may store something else).</para>
		/// <para>- Read comments near ImGuiMultiSelectIO for instructions/details and see 'Demo-&gt;Widgets-&gt;Selection State &amp; Multi-Select' for demo.</para>
		/// <para>- TreeNode() is technically supported but... using this correctly is more complicated. You need some sort of linear/random access to your tree,</para>
		/// <para>  which is suited to advanced trees setups already implementing filters and clipper. We will work simplifying the current demo.</para>
		/// <para>- 'selection_size' and 'items_count' parameters are optional and used by a few features. If they are costly for you to compute, you may avoid them.</para>
		/// </summary>
		/// <summary>
		/// Implied selection_size = -1, items_count = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMultiSelect")]
		public static extern ImGuiMultiSelectIO* ImGui_BeginMultiSelect(ImGuiMultiSelectFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMultiSelectEx")]
		public static extern ImGuiMultiSelectIO* ImGui_BeginMultiSelectEx(ImGuiMultiSelectFlags flags, int selection_size, int items_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndMultiSelect")]
		public static extern ImGuiMultiSelectIO* ImGui_EndMultiSelect();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemSelectionUserData")]
		public static extern void ImGui_SetNextItemSelectionUserData(long selection_user_data);
		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemToggledSelection")]
		public static extern byte ImGui_IsItemToggledSelection();
		/// <summary>
		/// <para>Widgets: List Boxes</para>
		/// <para>- This is essentially a thin wrapper to using BeginChild/EndChild with the ImGuiChildFlags_FrameStyle flag for stylistic changes + displaying a label.</para>
		/// <para>- You can submit contents and manage your selection state however you want it, by creating e.g. Selectable() or any other items.</para>
		/// <para>- The simplified/old ListBox() api are helpers over BeginListBox()/EndListBox() which are kept available for convenience purpose. This is analoguous to how Combos are created.</para>
		/// <para>- Choose frame width:   size.x &gt; 0.0f: custom  /  size.x &lt; 0.0f or -FLT_MIN: right-align   /  size.x = 0.0f (default): use current ItemWidth</para>
		/// <para>- Choose frame height:  size.y &gt; 0.0f: custom  /  size.y &lt; 0.0f or -FLT_MIN: bottom-align  /  size.y = 0.0f (default): arbitrary default height which can fit ~7 items</para>
		/// </summary>
		/// <summary>
		/// open a framed scrolling region
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginListBox")]
		public static extern byte ImGui_BeginListBox(byte* label, Vector2 size);
		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndListBox")]
		public static extern void ImGui_EndListBox();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ListBox")]
		public static extern byte ImGui_ListBox(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
		/// <summary>
		/// Implied height_in_items = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ListBoxCallback")]
		public static extern byte ImGui_ListBoxCallback(byte* label, int* current_item, ImGui_ListBoxCallbackgetterDelegate getter, void* user_data, int items_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ListBoxCallbackEx")]
		public static extern byte ImGui_ListBoxCallbackEx(byte* label, int* current_item, ImGui_ListBoxCallbackExgetterDelegate getter, void* user_data, int items_count, int height_in_items);
		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotLines")]
		public static extern void ImGui_PlotLines(byte* label, float* values, int values_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotLinesEx")]
		public static extern void ImGui_PlotLinesEx(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotLinesCallback")]
		public static extern void ImGui_PlotLinesCallback(byte* label, ImGui_PlotLinesCallbackvalues_getterDelegate values_getter, void* data, int values_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotLinesCallbackEx")]
		public static extern void ImGui_PlotLinesCallbackEx(byte* label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotHistogram")]
		public static extern void ImGui_PlotHistogram(byte* label, float* values, int values_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotHistogramEx")]
		public static extern void ImGui_PlotHistogramEx(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotHistogramCallback")]
		public static extern void ImGui_PlotHistogramCallback(byte* label, ImGui_PlotHistogramCallbackvalues_getterDelegate values_getter, void* data, int values_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotHistogramCallbackEx")]
		public static extern void ImGui_PlotHistogramCallbackEx(byte* label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size);
		/// <summary>
		/// <para>Widgets: Menus</para>
		/// <para>- Use BeginMenuBar() on a window ImGuiWindowFlags_MenuBar to append to its menu bar.</para>
		/// <para>- Use BeginMainMenuBar() to create a menu bar at the top of the screen and append to it.</para>
		/// <para>- Use BeginMenu() to create a menu. You can call BeginMenu() multiple time with the same identifier to append more items to it.</para>
		/// <para>- Not that MenuItem() keyboardshortcuts are displayed as a convenience but _not processed_ by Dear ImGui at the moment.</para>
		/// </summary>
		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMenuBar")]
		public static extern byte ImGui_BeginMenuBar();
		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndMenuBar")]
		public static extern void ImGui_EndMenuBar();
		/// <summary>
		/// create and append to a full screen menu-bar.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMainMenuBar")]
		public static extern byte ImGui_BeginMainMenuBar();
		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndMainMenuBar")]
		public static extern void ImGui_EndMainMenuBar();
		/// <summary>
		/// Implied enabled = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMenu")]
		public static extern byte ImGui_BeginMenu(byte* label);
		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMenuEx")]
		public static extern byte ImGui_BeginMenuEx(byte* label, byte enabled);
		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndMenu")]
		public static extern void ImGui_EndMenu();
		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MenuItem")]
		public static extern byte ImGui_MenuItem(byte* label);
		/// <summary>
		/// return true when activated.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MenuItemEx")]
		public static extern byte ImGui_MenuItemEx(byte* label, byte* shortcut, byte selected, byte enabled);
		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MenuItemBoolPtr")]
		public static extern byte ImGui_MenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
		/// <summary>
		/// <para>Tooltips</para>
		/// <para>- Tooltips are windows following the mouse. They do not take focus away.</para>
		/// <para>- A tooltip window can contain items of any types.</para>
		/// <para>- SetTooltip() is more or less a shortcut for the 'if (BeginTooltip()) { Text(...); EndTooltip(); }' idiom (with a subtlety that it discard any previously submitted tooltip)</para>
		/// </summary>
		/// <summary>
		/// begin/append a tooltip window.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTooltip")]
		public static extern byte ImGui_BeginTooltip();
		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndTooltip")]
		public static extern void ImGui_EndTooltip();
		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetTooltip")]
		public static extern void ImGui_SetTooltip(byte* fmt);
		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetTooltipUnformatted")]
		public static extern void ImGui_SetTooltipUnformatted(byte* text);
		/// <summary>
		/// <para>Tooltips: helpers for showing a tooltip when hovering an item</para>
		/// <para>- BeginItemTooltip() is a shortcut for the 'if (IsItemHovered(ImGuiHoveredFlags_ForTooltip) &amp;&amp; BeginTooltip())' idiom.</para>
		/// <para>- SetItemTooltip() is a shortcut for the 'if (IsItemHovered(ImGuiHoveredFlags_ForTooltip)) { SetTooltip(...); }' idiom.</para>
		/// <para>- Where 'ImGuiHoveredFlags_ForTooltip' itself is a shortcut to use 'style.HoverFlagsForTooltipMouse' or 'style.HoverFlagsForTooltipNav' depending on active input type. For mouse it defaults to 'ImGuiHoveredFlags_Stationary | ImGuiHoveredFlags_DelayShort'.</para>
		/// </summary>
		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginItemTooltip")]
		public static extern byte ImGui_BeginItemTooltip();
		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetItemTooltip")]
		public static extern void ImGui_SetItemTooltip(byte* fmt);
		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetItemTooltipUnformatted")]
		public static extern void ImGui_SetItemTooltipUnformatted(byte* text);
		/// <summary>
		/// <para>Popups, Modals</para>
		/// <para> - They block normal mouse hovering detection (and therefore most mouse interactions) behind them.</para>
		/// <para> - If not modal: they can be closed by clicking anywhere outside them, or by pressing ESCAPE.</para>
		/// <para> - Their visibility state (~bool) is held internally instead of being held by the programmer as we are used to with regular Begin*() calls.</para>
		/// <para> - The 3 properties above are related: we need to retain popup visibility state in the library because popups may be closed as any time.</para>
		/// <para> - You can bypass the hovering restriction by using ImGuiHoveredFlags_AllowWhenBlockedByPopup when calling IsItemHovered() or IsWindowHovered().</para>
		/// <para> - IMPORTANT: Popup identifiers are relative to the current ID stack, so OpenPopup and BeginPopup generally needs to be at the same level of the stack.</para>
		/// <para>   This is sometimes leading to confusing mistakes. May rework this in the future.</para>
		/// <para> - BeginPopup(): query popup state, if open start appending into the window. Call EndPopup() afterwards if returned true. ImGuiWindowFlags are forwarded to the window.</para>
		/// <para> - BeginPopupModal(): block every interaction behind the window, cannot be closed by user, add a dimming background, has a title bar.</para>
		/// </summary>
		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopup")]
		public static extern byte ImGui_BeginPopup(byte* str_id, ImGuiWindowFlags flags);
		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupModal")]
		public static extern byte ImGui_BeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndPopup")]
		public static extern void ImGui_EndPopup();
		/// <summary>
		/// <para>Popups: open/close functions</para>
		/// <para> - OpenPopup(): set popup state to open. ImGuiPopupFlags are available for opening options.</para>
		/// <para> - If not modal: they can be closed by clicking anywhere outside them, or by pressing ESCAPE.</para>
		/// <para> - CloseCurrentPopup(): use inside the BeginPopup()/EndPopup() scope to close manually.</para>
		/// <para> - CloseCurrentPopup() is called by default by Selectable()/MenuItem() when activated (FIXME: need some options).</para>
		/// <para> - Use ImGuiPopupFlags_NoOpenOverExistingPopup to avoid opening a popup if there's already one at the same level. This is equivalent to e.g. testing for !IsAnyPopupOpen() prior to OpenPopup().</para>
		/// <para> - Use IsWindowAppearing() after BeginPopup() to tell if a window just opened.</para>
		/// <para> - IMPORTANT: Notice that for OpenPopupOnItemClick() we exceptionally default flags to 1 (== ImGuiPopupFlags_MouseButtonRight) for backward compatibility with older API taking 'int mouse_button = 1' parameter</para>
		/// </summary>
		/// <summary>
		/// call to mark popup as open (don't call every frame!).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_OpenPopup")]
		public static extern void ImGui_OpenPopup(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// id overload to facilitate calling from nested stacks
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_OpenPopupID")]
		public static extern void ImGui_OpenPopupID(uint id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_OpenPopupOnItemClick")]
		public static extern void ImGui_OpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// manually close the popup we have begin-ed into.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CloseCurrentPopup")]
		public static extern void ImGui_CloseCurrentPopup();
		/// <summary>
		/// <para>Popups: open+begin combined functions helpers</para>
		/// <para> - Helpers to do OpenPopup+BeginPopup where the Open action is triggered by e.g. hovering an item and right-clicking.</para>
		/// <para> - They are convenient to easily create context menus, hence the name.</para>
		/// <para> - IMPORTANT: Notice that BeginPopupContextXXX takes ImGuiPopupFlags just like OpenPopup() and unlike BeginPopup(). For full consistency, we may add ImGuiWindowFlags to the BeginPopupContextXXX functions in the future.</para>
		/// <para> - IMPORTANT: Notice that we exceptionally default their flags to 1 (== ImGuiPopupFlags_MouseButtonRight) for backward compatibility with older API taking 'int mouse_button = 1' parameter, so if you add other flags remember to re-add the ImGuiPopupFlags_MouseButtonRight.</para>
		/// </summary>
		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupContextItem")]
		public static extern byte ImGui_BeginPopupContextItem();
		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupContextItemEx")]
		public static extern byte ImGui_BeginPopupContextItemEx(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupContextWindow")]
		public static extern byte ImGui_BeginPopupContextWindow();
		/// <summary>
		/// open+begin popup when clicked on current window.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupContextWindowEx")]
		public static extern byte ImGui_BeginPopupContextWindowEx(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupContextVoid")]
		public static extern byte ImGui_BeginPopupContextVoid();
		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupContextVoidEx")]
		public static extern byte ImGui_BeginPopupContextVoidEx(byte* str_id, ImGuiPopupFlags popup_flags);
		/// <summary>
		/// <para>Popups: query functions</para>
		/// <para> - IsPopupOpen(): return true if the popup is open at the current BeginPopup() level of the popup stack.</para>
		/// <para> - IsPopupOpen() with ImGuiPopupFlags_AnyPopupId: return true if any popup is open at the current BeginPopup() level of the popup stack.</para>
		/// <para> - IsPopupOpen() with ImGuiPopupFlags_AnyPopupId + ImGuiPopupFlags_AnyPopupLevel: return true if any popup is open.</para>
		/// </summary>
		/// <summary>
		/// return true if the popup is open.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsPopupOpen")]
		public static extern byte ImGui_IsPopupOpen(byte* str_id, ImGuiPopupFlags flags);
		/// <summary>
		/// <para>Tables</para>
		/// <para>- Full-featured replacement for old Columns API.</para>
		/// <para>- See Demo-&gt;Tables for demo code. See top of imgui_tables.cpp for general commentary.</para>
		/// <para>- See ImGuiTableFlags_ and ImGuiTableColumnFlags_ enums for a description of available flags.</para>
		/// <para>The typical call flow is:</para>
		/// <para>- 1. Call BeginTable(), early out if returning false.</para>
		/// <para>- 2. Optionally call TableSetupColumn() to submit column name/flags/defaults.</para>
		/// <para>- 3. Optionally call TableSetupScrollFreeze() to request scroll freezing of columns/rows.</para>
		/// <para>- 4. Optionally call TableHeadersRow() to submit a header row. Names are pulled from TableSetupColumn() data.</para>
		/// <para>- 5. Populate contents:</para>
		/// <para>   - In most situations you can use TableNextRow() + TableSetColumnIndex(N) to start appending into a column.</para>
		/// <para>   - If you are using tables as a sort of grid, where every column is holding the same type of contents,</para>
		/// <para>     you may prefer using TableNextColumn() instead of TableNextRow() + TableSetColumnIndex().</para>
		/// <para>     TableNextColumn() will automatically wrap-around into the next row if needed.</para>
		/// <para>   - IMPORTANT: Comparatively to the old Columns() API, we need to call TableNextColumn() for the first column!</para>
		/// <para>   - Summary of possible call flow:</para>
		/// <para>       - TableNextRow() -&gt; TableSetColumnIndex(0) -&gt; Text("Hello 0") -&gt; TableSetColumnIndex(1) -&gt; Text("Hello 1")  // OK</para>
		/// <para>       - TableNextRow() -&gt; TableNextColumn()      -&gt; Text("Hello 0") -&gt; TableNextColumn()      -&gt; Text("Hello 1")  // OK</para>
		/// <para>       -                   TableNextColumn()      -&gt; Text("Hello 0") -&gt; TableNextColumn()      -&gt; Text("Hello 1")  // OK: TableNextColumn() automatically gets to next row!</para>
		/// <para>       - TableNextRow()                           -&gt; Text("Hello 0")                                               // Not OK! Missing TableSetColumnIndex() or TableNextColumn()! Text will not appear!</para>
		/// <para>- 5. Call EndTable()</para>
		/// </summary>
		/// <summary>
		/// Implied outer_size = ImVec2(0.0f, 0.0f), inner_width = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTable")]
		public static extern byte ImGui_BeginTable(byte* str_id, int columns, ImGuiTableFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTableEx")]
		public static extern byte ImGui_BeginTableEx(byte* str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
		/// <summary>
		/// only call EndTable() if BeginTable() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndTable")]
		public static extern void ImGui_EndTable();
		/// <summary>
		/// Implied row_flags = 0, min_row_height = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableNextRow")]
		public static extern void ImGui_TableNextRow();
		/// <summary>
		/// append into the first cell of a new row.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableNextRowEx")]
		public static extern void ImGui_TableNextRowEx(ImGuiTableRowFlags row_flags, float min_row_height);
		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableNextColumn")]
		public static extern byte ImGui_TableNextColumn();
		/// <summary>
		/// append into the specified column. Return true when column is visible.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetColumnIndex")]
		public static extern byte ImGui_TableSetColumnIndex(int column_n);
		/// <summary>
		/// <para>Tables: Headers &amp; Columns declaration</para>
		/// <para>- Use TableSetupColumn() to specify label, resizing policy, default width/weight, id, various other flags etc.</para>
		/// <para>- Use TableHeadersRow() to create a header row and automatically submit a TableHeader() for each column.</para>
		/// <para>  Headers are required to perform: reordering, sorting, and opening the context menu.</para>
		/// <para>  The context menu can also be made available in columns body using ImGuiTableFlags_ContextMenuInBody.</para>
		/// <para>- You may manually submit headers using TableNextRow() + TableHeader() calls, but this is only useful in</para>
		/// <para>  some advanced use cases (e.g. adding custom widgets in header row).</para>
		/// <para>- Use TableSetupScrollFreeze() to lock columns/rows so they stay visible when scrolled.</para>
		/// </summary>
		/// <summary>
		/// Implied init_width_or_weight = 0.0f, user_id = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetupColumn")]
		public static extern void ImGui_TableSetupColumn(byte* label, ImGuiTableColumnFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetupColumnEx")]
		public static extern void ImGui_TableSetupColumnEx(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetupScrollFreeze")]
		public static extern void ImGui_TableSetupScrollFreeze(int cols, int rows);
		/// <summary>
		/// submit one header cell manually (rarely used)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableHeader")]
		public static extern void ImGui_TableHeader(byte* label);
		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableHeadersRow")]
		public static extern void ImGui_TableHeadersRow();
		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableAngledHeadersRow")]
		public static extern void ImGui_TableAngledHeadersRow();
		/// <summary>
		/// <para>Tables: Sorting &amp; Miscellaneous functions</para>
		/// <para>- Sorting: call TableGetSortSpecs() to retrieve latest sort specs for the table. NULL when not sorting.</para>
		/// <para>  When 'sort_specs-&gt;SpecsDirty == true' you should sort your data. It will be true when sorting specs have</para>
		/// <para>  changed since last call, or the first time. Make sure to set 'SpecsDirty = false' after sorting,</para>
		/// <para>  else you may wastefully sort your data every frame!</para>
		/// <para>- Functions args 'int column_n' treat the default value of -1 as the same as passing the current column index.</para>
		/// </summary>
		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetSortSpecs")]
		public static extern ImGuiTableSortSpecs* ImGui_TableGetSortSpecs();
		/// <summary>
		/// return number of columns (value passed to BeginTable)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnCount")]
		public static extern int ImGui_TableGetColumnCount();
		/// <summary>
		/// return current column index.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnIndex")]
		public static extern int ImGui_TableGetColumnIndex();
		/// <summary>
		/// return current row index.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetRowIndex")]
		public static extern int ImGui_TableGetRowIndex();
		/// <summary>
		/// return "" if column didn't have a name declared by TableSetupColumn(). Pass -1 to use current column.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnName")]
		public static extern byte* ImGui_TableGetColumnName(int column_n);
		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnFlags")]
		public static extern ImGuiTableColumnFlags ImGui_TableGetColumnFlags(int column_n);
		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetColumnEnabled")]
		public static extern void ImGui_TableSetColumnEnabled(int column_n, byte v);
		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() &amp; ImGuiTableColumnFlags_IsHovered) instead.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetHoveredColumn")]
		public static extern int ImGui_TableGetHoveredColumn();
		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetBgColor")]
		public static extern void ImGui_TableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
		/// <summary>
		/// <para>Legacy Columns API (prefer using Tables!)</para>
		/// <para>- You can also use SameLine(pos_x) to mimic simplified columns.</para>
		/// </summary>
		/// <summary>
		/// Implied count = 1, id = NULL, borders = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Columns")]
		public static extern void ImGui_Columns();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColumnsEx")]
		public static extern void ImGui_ColumnsEx(int count, byte* id, byte borders);
		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NextColumn")]
		public static extern void ImGui_NextColumn();
		/// <summary>
		/// get current column index
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnIndex")]
		public static extern int ImGui_GetColumnIndex();
		/// <summary>
		/// get column width (in pixels). pass -1 to use current column
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnWidth")]
		public static extern float ImGui_GetColumnWidth(int column_index);
		/// <summary>
		/// set column width (in pixels). pass -1 to use current column
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetColumnWidth")]
		public static extern void ImGui_SetColumnWidth(int column_index, float width);
		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnOffset")]
		public static extern float ImGui_GetColumnOffset(int column_index);
		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetColumnOffset")]
		public static extern void ImGui_SetColumnOffset(int column_index, float offset_x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnsCount")]
		public static extern int ImGui_GetColumnsCount();
		/// <summary>
		/// <para>Tab Bars, Tabs</para>
		/// <para>- Note: Tabs are automatically created by the docking system (when in 'docking' branch). Use this to create tab bars/tabs yourself.</para>
		/// </summary>
		/// <summary>
		/// create and append into a TabBar
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTabBar")]
		public static extern byte ImGui_BeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndTabBar")]
		public static extern void ImGui_EndTabBar();
		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTabItem")]
		public static extern byte ImGui_BeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndTabItem")]
		public static extern void ImGui_EndTabItem();
		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabItemButton")]
		public static extern byte ImGui_TabItemButton(byte* label, ImGuiTabItemFlags flags);
		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetTabItemClosed")]
		public static extern void ImGui_SetTabItemClosed(byte* tab_or_docked_window_label);
		/// <summary>
		/// <para>Docking</para>
		/// <para>[BETA API] Enable with io.ConfigFlags |= ImGuiConfigFlags_DockingEnable.</para>
		/// <para>Note: You can use most Docking facilities without calling any API. You DO NOT need to call DockSpace() to use Docking!</para>
		/// <para>- Drag from window title bar or their tab to dock/undock. Hold SHIFT to disable docking.</para>
		/// <para>- Drag from window menu button (upper-left button) to undock an entire node (all windows).</para>
		/// <para>- When io.ConfigDockingWithShift == true, you instead need to hold SHIFT to enable docking.</para>
		/// <para>About dockspaces:</para>
		/// <para>- Use DockSpaceOverViewport() to create a window covering the screen or a specific viewport + a dockspace inside it.</para>
		/// <para>  This is often used with ImGuiDockNodeFlags_PassthruCentralNode to make it transparent.</para>
		/// <para>- Use DockSpace() to create an explicit dock node _within_ an existing window. See Docking demo for details.</para>
		/// <para>- Important: Dockspaces need to be submitted _before_ any window they can host. Submit it early in your frame!</para>
		/// <para>- Important: Dockspaces need to be kept alive if hidden, otherwise windows docked into it will be undocked.</para>
		/// <para>  e.g. if you have multiple tabs with a dockspace inside each tab: submit the non-visible dockspaces with ImGuiDockNodeFlags_KeepAliveOnly.</para>
		/// </summary>
		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, window_class = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockSpace")]
		public static extern uint ImGui_DockSpace(uint dockspace_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockSpaceEx")]
		public static extern uint ImGui_DockSpaceEx(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
		/// <summary>
		/// Implied dockspace_id = 0, viewport = NULL, flags = 0, window_class = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockSpaceOverViewport")]
		public static extern uint ImGui_DockSpaceOverViewport();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockSpaceOverViewportEx")]
		public static extern uint ImGui_DockSpaceOverViewportEx(uint dockspace_id, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
		/// <summary>
		/// set next window dock id
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowDockID")]
		public static extern void ImGui_SetNextWindowDockID(uint dock_id, ImGuiCond cond);
		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowClass")]
		public static extern void ImGui_SetNextWindowClass(ImGuiWindowClass* window_class);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowDockID")]
		public static extern uint ImGui_GetWindowDockID();
		/// <summary>
		/// is current window docked into another window?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowDocked")]
		public static extern byte ImGui_IsWindowDocked();
		/// <summary>
		/// <para>Logging/Capture</para>
		/// <para>- All text output from the interface can be captured into tty/file/clipboard. By default, tree nodes are automatically opened during logging.</para>
		/// </summary>
		/// <summary>
		/// start logging to tty (stdout)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogToTTY")]
		public static extern void ImGui_LogToTTY(int auto_open_depth);
		/// <summary>
		/// start logging to file
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogToFile")]
		public static extern void ImGui_LogToFile(int auto_open_depth, byte* filename);
		/// <summary>
		/// start logging to OS clipboard
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogToClipboard")]
		public static extern void ImGui_LogToClipboard(int auto_open_depth);
		/// <summary>
		/// stop logging (close file, etc.)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogFinish")]
		public static extern void ImGui_LogFinish();
		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogButtons")]
		public static extern void ImGui_LogButtons();
		/// <summary>
		/// pass text data straight to log (without being displayed)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogText")]
		public static extern void ImGui_LogText(byte* fmt);
		/// <summary>
		/// pass text data straight to log (without being displayed)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogTextUnformatted")]
		public static extern void ImGui_LogTextUnformatted(byte* text);
		/// <summary>
		/// <para>Drag and Drop</para>
		/// <para>- On source items, call BeginDragDropSource(), if it returns true also call SetDragDropPayload() + EndDragDropSource().</para>
		/// <para>- On target candidates, call BeginDragDropTarget(), if it returns true also call AcceptDragDropPayload() + EndDragDropTarget().</para>
		/// <para>- If you stop calling BeginDragDropSource() the payload is preserved however it won't have a preview tooltip (we currently display a fallback "..." tooltip, see #1725)</para>
		/// <para>- An item can be both drag source and drop target.</para>
		/// </summary>
		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDragDropSource")]
		public static extern byte ImGui_BeginDragDropSource(ImGuiDragDropFlags flags);
		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetDragDropPayload")]
		public static extern byte ImGui_SetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndDragDropSource")]
		public static extern void ImGui_EndDragDropSource();
		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDragDropTarget")]
		public static extern byte ImGui_BeginDragDropTarget();
		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_AcceptDragDropPayload")]
		public static extern ImGuiPayload* ImGui_AcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndDragDropTarget")]
		public static extern void ImGui_EndDragDropTarget();
		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetDragDropPayload")]
		public static extern ImGuiPayload* ImGui_GetDragDropPayload();
		/// <summary>
		/// <para>Disabling [BETA API]</para>
		/// <para>- Disable all user interactions and dim items visuals (applying style.DisabledAlpha over current colors)</para>
		/// <para>- Those can be nested but it cannot be used to enable an already disabled section (a single BeginDisabled(true) in the stack is enough to keep everything disabled)</para>
		/// <para>- Tooltips windows by exception are opted out of disabling.</para>
		/// <para>- BeginDisabled(false)/EndDisabled() essentially does nothing but is provided to facilitate use of boolean expressions (as a micro-optimization: if you have tens of thousands of BeginDisabled(false)/EndDisabled() pairs, you might want to reformulate your code to avoid making those calls)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDisabled")]
		public static extern void ImGui_BeginDisabled(byte disabled);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndDisabled")]
		public static extern void ImGui_EndDisabled();
		/// <summary>
		/// <para>Clipping</para>
		/// <para>- Mouse hovering is affected by ImGui::PushClipRect() calls, unlike direct calls to ImDrawList::PushClipRect() which are render only.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushClipRect")]
		public static extern void ImGui_PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopClipRect")]
		public static extern void ImGui_PopClipRect();
		/// <summary>
		/// <para>Focus, Activation</para>
		/// </summary>
		/// <summary>
		/// make last item the default focused item of of a newly appearing window.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetItemDefaultFocus")]
		public static extern void ImGui_SetItemDefaultFocus();
		/// <summary>
		/// Implied offset = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetKeyboardFocusHere")]
		public static extern void ImGui_SetKeyboardFocusHere();
		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetKeyboardFocusHereEx")]
		public static extern void ImGui_SetKeyboardFocusHereEx(int offset);
		/// <summary>
		/// <para>Keyboard/Gamepad Navigation</para>
		/// </summary>
		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNavCursorVisible")]
		public static extern void ImGui_SetNavCursorVisible(byte visible);
		/// <summary>
		/// <para>Overlapping mode</para>
		/// </summary>
		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemAllowOverlap")]
		public static extern void ImGui_SetNextItemAllowOverlap();
		/// <summary>
		/// <para>Item/Widgets Utilities and Query Functions</para>
		/// <para>- Most of the functions are referring to the previous Item that has been submitted.</para>
		/// <para>- See Demo Window under "Widgets-&gt;Querying Status" for an interactive visualization of most of those functions.</para>
		/// </summary>
		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemHovered")]
		public static extern byte ImGui_IsItemHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemActive")]
		public static extern byte ImGui_IsItemActive();
		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemFocused")]
		public static extern byte ImGui_IsItemFocused();
		/// <summary>
		/// Implied mouse_button = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemClicked")]
		public static extern byte ImGui_IsItemClicked();
		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) &amp;&amp; IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemClickedEx")]
		public static extern byte ImGui_IsItemClickedEx(ImGuiMouseButton mouse_button);
		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemVisible")]
		public static extern byte ImGui_IsItemVisible();
		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemEdited")]
		public static extern byte ImGui_IsItemEdited();
		/// <summary>
		/// was the last item just made active (item was previously inactive).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemActivated")]
		public static extern byte ImGui_IsItemActivated();
		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemDeactivated")]
		public static extern byte ImGui_IsItemDeactivated();
		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemDeactivatedAfterEdit")]
		public static extern byte ImGui_IsItemDeactivatedAfterEdit();
		/// <summary>
		/// was the last item open state toggled? set by TreeNode().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsItemToggledOpen")]
		public static extern byte ImGui_IsItemToggledOpen();
		/// <summary>
		/// is any item hovered?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsAnyItemHovered")]
		public static extern byte ImGui_IsAnyItemHovered();
		/// <summary>
		/// is any item active?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsAnyItemActive")]
		public static extern byte ImGui_IsAnyItemActive();
		/// <summary>
		/// is any item focused?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsAnyItemFocused")]
		public static extern byte ImGui_IsAnyItemFocused();
		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetItemID")]
		public static extern uint ImGui_GetItemID();
		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetItemRectMin")]
		public static extern Vector2 ImGui_GetItemRectMin();
		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetItemRectMax")]
		public static extern Vector2 ImGui_GetItemRectMax();
		/// <summary>
		/// get size of last item
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetItemRectSize")]
		public static extern Vector2 ImGui_GetItemRectSize();
		/// <summary>
		/// <para>Viewports</para>
		/// <para>- Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.</para>
		/// <para>- In 'docking' branch with multi-viewport enabled, we extend this concept to have multiple active viewports.</para>
		/// <para>- In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.</para>
		/// </summary>
		/// <summary>
		/// return primary/default viewport. This can never be NULL.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMainViewport")]
		public static extern ImGuiViewport* ImGui_GetMainViewport();
		/// <summary>
		/// <para>Background/Foreground Draw Lists</para>
		/// </summary>
		/// <summary>
		/// Implied viewport = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetBackgroundDrawList")]
		public static extern ImDrawList* ImGui_GetBackgroundDrawList();
		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetBackgroundDrawListEx")]
		public static extern ImDrawList* ImGui_GetBackgroundDrawListEx(ImGuiViewport* viewport);
		/// <summary>
		/// Implied viewport = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetForegroundDrawList")]
		public static extern ImDrawList* ImGui_GetForegroundDrawList();
		/// <summary>
		/// get foreground draw list for the given viewport or viewport associated to the current window. this draw list will be the top-most rendered one. Useful to quickly draw shapes/text over dear imgui contents.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetForegroundDrawListEx")]
		public static extern ImDrawList* ImGui_GetForegroundDrawListEx(ImGuiViewport* viewport);
		/// <summary>
		/// <para>Miscellaneous Utilities</para>
		/// </summary>
		/// <summary>
		/// test if rectangle (of given size, starting from cursor position) is visible / not clipped.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsRectVisibleBySize")]
		public static extern byte ImGui_IsRectVisibleBySize(Vector2 size);
		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsRectVisible")]
		public static extern byte ImGui_IsRectVisible(Vector2 rect_min, Vector2 rect_max);
		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTime")]
		public static extern double ImGui_GetTime();
		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFrameCount")]
		public static extern int ImGui_GetFrameCount();
		/// <summary>
		/// you may use this when creating your own ImDrawList instances.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetDrawListSharedData")]
		public static extern IntPtr ImGui_GetDrawListSharedData();
		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetStyleColorName")]
		public static extern byte* ImGui_GetStyleColorName(ImGuiCol idx);
		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetStateStorage")]
		public static extern void ImGui_SetStateStorage(ImGuiStorage* storage);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetStateStorage")]
		public static extern ImGuiStorage* ImGui_GetStateStorage();
		/// <summary>
		/// <para>Text Utilities</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_double_hash = false, wrap_width = -1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcTextSize")]
		public static extern Vector2 ImGui_CalcTextSize(byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcTextSizeEx")]
		public static extern Vector2 ImGui_CalcTextSizeEx(byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
		/// <summary>
		/// <para>Color Utilities</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorConvertU32ToFloat4")]
		public static extern Vector4 ImGui_ColorConvertU32ToFloat4(uint _in);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorConvertFloat4ToU32")]
		public static extern uint ImGui_ColorConvertFloat4ToU32(Vector4 _in);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorConvertRGBtoHSV")]
		public static extern void ImGui_ColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorConvertHSVtoRGB")]
		public static extern void ImGui_ColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
		/// <summary>
		/// <para>Inputs Utilities: Keyboard/Mouse/Gamepad</para>
		/// <para>- the ImGuiKey enum contains all possible keyboard, mouse and gamepad inputs (e.g. ImGuiKey_A, ImGuiKey_MouseLeft, ImGuiKey_GamepadDpadUp...).</para>
		/// <para>- (legacy: before v1.87, we used ImGuiKey to carry native/user indices as defined by each backends. This was obsoleted in 1.87 (2022-02) and completely removed in 1.91.5 (2024-11). See https://github.com/ocornut/imgui/issues/4921)</para>
		/// <para>- (legacy: any use of ImGuiKey will assert when key &lt; 512 to detect passing legacy native/user indices)</para>
		/// </summary>
		/// <summary>
		/// is key being held.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyDown")]
		public static extern byte ImGui_IsKeyDown(ImGuiKey key);
		/// <summary>
		/// Implied repeat = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyPressed")]
		public static extern byte ImGui_IsKeyPressed(ImGuiKey key);
		/// <summary>
		/// was key pressed (went from !Down to Down)? if repeat=true, uses io.KeyRepeatDelay / KeyRepeatRate
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyPressedEx")]
		public static extern byte ImGui_IsKeyPressedEx(ImGuiKey key, byte repeat);
		/// <summary>
		/// was key released (went from Down to !Down)?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyReleased")]
		public static extern byte ImGui_IsKeyReleased(ImGuiKey key);
		/// <summary>
		/// was key chord (mods + key) pressed, e.g. you can pass 'ImGuiMod_Ctrl | ImGuiKey_S' as a key-chord. This doesn't do any routing or focus check, please consider using Shortcut() function instead.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyChordPressed")]
		public static extern byte ImGui_IsKeyChordPressed(ImGuiKey key_chord);
		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be &gt;1 if RepeatRate is small enough that DeltaTime &gt; RepeatRate
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyPressedAmount")]
		public static extern int ImGui_GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);
		/// <summary>
		/// [DEBUG] returns English name of the key. Those names a provided for debugging purpose and are not meant to be saved persistently not compared.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyName")]
		public static extern byte* ImGui_GetKeyName(ImGuiKey key);
		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextFrameWantCaptureKeyboard")]
		public static extern void ImGui_SetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);
		/// <summary>
		/// <para>Inputs Utilities: Shortcut Testing &amp; Routing [BETA]</para>
		/// <para>- ImGuiKeyChord = a ImGuiKey + optional ImGuiMod_Alt/ImGuiMod_Ctrl/ImGuiMod_Shift/ImGuiMod_Super.</para>
		/// <para>      ImGuiKey_C                          // Accepted by functions taking ImGuiKey or ImGuiKeyChord arguments)</para>
		/// <para>      ImGuiMod_Ctrl | ImGuiKey_C          // Accepted by functions taking ImGuiKeyChord arguments)</para>
		/// <para>  only ImGuiMod_XXX values are legal to combine with an ImGuiKey. You CANNOT combine two ImGuiKey values.</para>
		/// <para>- The general idea is that several callers may register interest in a shortcut, and only one owner gets it.</para>
		/// <para>     Parent   -&gt; call Shortcut(Ctrl+S)    // When Parent is focused, Parent gets the shortcut.</para>
		/// <para>       Child1 -&gt; call Shortcut(Ctrl+S)    // When Child1 is focused, Child1 gets the shortcut (Child1 overrides Parent shortcuts)</para>
		/// <para>       Child2 -&gt; no call                  // When Child2 is focused, Parent gets the shortcut.</para>
		/// <para>  The whole system is order independent, so if Child1 makes its calls before Parent, results will be identical.</para>
		/// <para>  This is an important property as it facilitate working with foreign code or larger codebase.</para>
		/// <para>- To understand the difference:</para>
		/// <para>  - IsKeyChordPressed() compares mods and call IsKeyPressed() -&gt; function has no side-effect.</para>
		/// <para>  - Shortcut() submits a route, routes are resolved, if it currently can be routed it calls IsKeyChordPressed() -&gt; function has (desirable) side-effects as it can prevents another call from getting the route.</para>
		/// <para>- Visualize registered routes in 'Metrics/Debugger-&gt;Inputs'.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Shortcut")]
		public static extern byte ImGui_Shortcut(ImGuiKey key_chord, ImGuiInputFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemShortcut")]
		public static extern void ImGui_SetNextItemShortcut(ImGuiKey key_chord, ImGuiInputFlags flags);
		/// <summary>
		/// <para>Inputs Utilities: Key/Input Ownership [BETA]</para>
		/// <para>- One common use case would be to allow your items to disable standard inputs behaviors such</para>
		/// <para>  as Tab or Alt key handling, Mouse Wheel scrolling, etc.</para>
		/// <para>  e.g. Button(...); SetItemKeyOwner(ImGuiKey_MouseWheelY); to make hovering/activating a button disable wheel for scrolling.</para>
		/// <para>- Reminder ImGuiKey enum include access to mouse buttons and gamepad, so key ownership can apply to them.</para>
		/// <para>- Many related features are still in imgui_internal.h. For instance, most IsKeyXXX()/IsMouseXXX() functions have an owner-id-aware version.</para>
		/// </summary>
		/// <summary>
		/// Set key owner to last item ID if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive()) { SetKeyOwner(key, GetItemID());'.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetItemKeyOwner")]
		public static extern void ImGui_SetItemKeyOwner(ImGuiKey key);
		/// <summary>
		/// <para>Inputs Utilities: Mouse</para>
		/// <para>- To refer to a mouse button, you may use named enums in your code e.g. ImGuiMouseButton_Left, ImGuiMouseButton_Right.</para>
		/// <para>- You can also use regular integer: it is forever guaranteed that 0=Left, 1=Right, 2=Middle.</para>
		/// <para>- Dragging operations are only reported after mouse has moved a certain distance away from the initial clicking position (see 'lock_threshold' and 'io.MouseDraggingThreshold')</para>
		/// </summary>
		/// <summary>
		/// is mouse button held?
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDown")]
		public static extern byte ImGui_IsMouseDown(ImGuiMouseButton button);
		/// <summary>
		/// Implied repeat = false
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseClicked")]
		public static extern byte ImGui_IsMouseClicked(ImGuiMouseButton button);
		/// <summary>
		/// did mouse button clicked? (went from !Down to Down). Same as GetMouseClickedCount() == 1.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseClickedEx")]
		public static extern byte ImGui_IsMouseClickedEx(ImGuiMouseButton button, byte repeat);
		/// <summary>
		/// did mouse button released? (went from Down to !Down)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseReleased")]
		public static extern byte ImGui_IsMouseReleased(ImGuiMouseButton button);
		/// <summary>
		/// did mouse button double-clicked? Same as GetMouseClickedCount() == 2. (note that a double-click will also report IsMouseClicked() == true)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDoubleClicked")]
		public static extern byte ImGui_IsMouseDoubleClicked(ImGuiMouseButton button);
		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMouseClickedCount")]
		public static extern int ImGui_GetMouseClickedCount(ImGuiMouseButton button);
		/// <summary>
		/// Implied clip = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseHoveringRect")]
		public static extern byte ImGui_IsMouseHoveringRect(Vector2 r_min, Vector2 r_max);
		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseHoveringRectEx")]
		public static extern byte ImGui_IsMouseHoveringRectEx(Vector2 r_min, Vector2 r_max, byte clip);
		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMousePosValid")]
		public static extern byte ImGui_IsMousePosValid(Vector2* mouse_pos);
		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsAnyMouseDown")]
		public static extern byte ImGui_IsAnyMouseDown();
		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMousePos")]
		public static extern Vector2 ImGui_GetMousePos();
		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMousePosOnOpeningCurrentPopup")]
		public static extern Vector2 ImGui_GetMousePosOnOpeningCurrentPopup();
		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDragging")]
		public static extern byte ImGui_IsMouseDragging(ImGuiMouseButton button, float lock_threshold);
		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMouseDragDelta")]
		public static extern Vector2 ImGui_GetMouseDragDelta(ImGuiMouseButton button, float lock_threshold);
		/// <summary>
		/// Implied button = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ResetMouseDragDelta")]
		public static extern void ImGui_ResetMouseDragDelta();
		/// <summary>
		/// //
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ResetMouseDragDeltaEx")]
		public static extern void ImGui_ResetMouseDragDeltaEx(ImGuiMouseButton button);
		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMouseCursor")]
		public static extern ImGuiMouseCursor ImGui_GetMouseCursor();
		/// <summary>
		/// set desired mouse cursor shape
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetMouseCursor")]
		public static extern void ImGui_SetMouseCursor(ImGuiMouseCursor cursor_type);
		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextFrameWantCaptureMouse")]
		public static extern void ImGui_SetNextFrameWantCaptureMouse(byte want_capture_mouse);
		/// <summary>
		/// <para>Clipboard Utilities</para>
		/// <para>- Also see the LogToClipboard() function to capture GUI into clipboard, or easily output text data to the clipboard.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetClipboardText")]
		public static extern byte* ImGui_GetClipboardText();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetClipboardText")]
		public static extern void ImGui_SetClipboardText(byte* text);
		/// <summary>
		/// <para>Settings/.Ini Utilities</para>
		/// <para>- The disk functions are automatically called if io.IniFilename != NULL (default is "imgui.ini").</para>
		/// <para>- Set io.IniFilename to NULL to load/save manually. Read io.WantSaveIniSettings description about handling .ini saving manually.</para>
		/// <para>- Important: default value "imgui.ini" is relative to current working dir! Most apps will want to lock this to an absolute path (e.g. same path as executables).</para>
		/// </summary>
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LoadIniSettingsFromDisk")]
		public static extern void ImGui_LoadIniSettingsFromDisk(byte* ini_filename);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LoadIniSettingsFromMemory")]
		public static extern void ImGui_LoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SaveIniSettingsToDisk")]
		public static extern void ImGui_SaveIniSettingsToDisk(byte* ini_filename);
		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SaveIniSettingsToMemory")]
		public static extern byte* ImGui_SaveIniSettingsToMemory(uint* out_ini_size);
		/// <summary>
		/// <para>Debug Utilities</para>
		/// <para>- Your main debugging friend is the ShowMetricsWindow() function, which is also accessible from Demo-&gt;Tools-&gt;Metrics Debugger</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugTextEncoding")]
		public static extern void ImGui_DebugTextEncoding(byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugFlashStyleColor")]
		public static extern void ImGui_DebugFlashStyleColor(ImGuiCol idx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugStartItemPicker")]
		public static extern void ImGui_DebugStartItemPicker();
		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugCheckVersionAndDataLayout")]
		public static extern byte ImGui_DebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugLog")]
		public static extern void ImGui_DebugLog(byte* fmt);
		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugLogUnformatted")]
		public static extern void ImGui_DebugLogUnformatted(byte* text);
		/// <summary>
		/// <para>Memory Allocators</para>
		/// <para>- Those functions are not reliant on the current context.</para>
		/// <para>- DLL users: heaps and globals are not shared across DLL boundaries! You will need to call SetCurrentContext() + SetAllocatorFunctions()</para>
		/// <para>  for each static/DLL boundary you are calling from. Read "Context and Memory Allocators" section of imgui.cpp for more details.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetAllocatorFunctions")]
		public static extern void ImGui_SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetAllocatorFunctions")]
		public static extern void ImGui_GetAllocatorFunctions(IntPtr p_alloc_func, IntPtr p_free_func, void** p_user_data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MemAlloc")]
		public static extern void* ImGui_MemAlloc(uint size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MemFree")]
		public static extern void ImGui_MemFree(void* ptr);
		/// <summary>
		/// <para>(Optional) Platform/OS interface for multi-viewport support</para>
		/// <para>Read comments around the ImGuiPlatformIO structure for more details.</para>
		/// <para>Note: You may use GetWindowViewport() to get the current viewport of the current window.</para>
		/// </summary>
		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdatePlatformWindows")]
		public static extern void ImGui_UpdatePlatformWindows();
		/// <summary>
		/// Implied platform_render_arg = NULL, renderer_render_arg = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderPlatformWindowsDefault")]
		public static extern void ImGui_RenderPlatformWindowsDefault();
		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderPlatformWindowsDefaultEx")]
		public static extern void ImGui_RenderPlatformWindowsDefaultEx(void* platform_render_arg, void* renderer_render_arg);
		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DestroyPlatformWindows")]
		public static extern void ImGui_DestroyPlatformWindows();
		/// <summary>
		/// this is a helper for backends.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindViewportByID")]
		public static extern ImGuiViewport* ImGui_FindViewportByID(uint id);
		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindViewportByPlatformHandle")]
		public static extern ImGuiViewport* ImGui_FindViewportByPlatformHandle(void* platform_handle);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStyle_ScaleAllSizes")]
		public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
		/// <summary>
		/// <para>Input Functions</para>
		/// </summary>
		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddKeyEvent")]
		public static extern void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);
		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddKeyAnalogEvent")]
		public static extern void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);
		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddMousePosEvent")]
		public static extern void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);
		/// <summary>
		/// Queue a mouse button change
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddMouseButtonEvent")]
		public static extern void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);
		/// <summary>
		/// Queue a mouse wheel update. wheel_y&lt;0: scroll down, wheel_y&gt;0: scroll up, wheel_x&lt;0: scroll right, wheel_x&gt;0: scroll left.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddMouseWheelEvent")]
		public static extern void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);
		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddMouseSourceEvent")]
		public static extern void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddMouseViewportEvent")]
		public static extern void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id);
		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddFocusEvent")]
		public static extern void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);
		/// <summary>
		/// Queue a new character input
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddInputCharacter")]
		public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddInputCharacterUTF16")]
		public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
		/// <summary>
		/// Queue a new characters input from a UTF-8 string
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_AddInputCharactersUTF8")]
		public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
		/// <summary>
		/// Implied native_legacy_index = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_SetKeyEventNativeData")]
		public static extern void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode);
		/// <summary>
		/// [Optional] Specify index for legacy &lt;1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_SetKeyEventNativeDataEx")]
		public static extern void ImGuiIO_SetKeyEventNativeDataEx(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_SetAppAcceptingEvents")]
		public static extern void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events);
		/// <summary>
		/// Clear all incoming events.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_ClearEventsQueue")]
		public static extern void ImGuiIO_ClearEventsQueue(ImGuiIO* self);
		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_ClearInputKeys")]
		public static extern void ImGuiIO_ClearInputKeys(ImGuiIO* self);
		/// <summary>
		/// Clear current mouse state.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiIO_ClearInputMouse")]
		public static extern void ImGuiIO_ClearInputMouse(ImGuiIO* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextCallbackData_DeleteChars")]
		public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextCallbackData_InsertChars")]
		public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextCallbackData_SelectAll")]
		public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextCallbackData_ClearSelection")]
		public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextCallbackData_HasSelection")]
		public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiPayload_Clear")]
		public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiPayload_IsDataType")]
		public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiPayload_IsPreview")]
		public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiPayload_IsDelivery")]
		public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_ImGuiTextRange_empty")]
		public static extern byte ImGuiTextFilter_ImGuiTextRange_empty(ImGuiTextRange* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_ImGuiTextRange_split")]
		public static extern void ImGuiTextFilter_ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* _out);
		/// <summary>
		/// Helper calling InputText+Build
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_Draw")]
		public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_PassFilter")]
		public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_Build")]
		public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_Clear")]
		public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextFilter_IsActive")]
		public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_begin")]
		public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_end")]
		public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_size")]
		public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_empty")]
		public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_clear")]
		public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_reserve")]
		public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_c_str")]
		public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_append")]
		public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextBuffer_appendf")]
		public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
		/// <summary>
		/// <para>- Get***() functions find pair, never add/allocate. Pairs are sorted so a query is O(log N)</para>
		/// <para>- Set***() functions find pair, insertion on demand if missing.</para>
		/// <para>- Sorted insertion is costly, paid once. A typical frame shouldn't need to insert any new pair.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_Clear")]
		public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetInt")]
		public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_SetInt")]
		public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetBool")]
		public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_SetBool")]
		public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetFloat")]
		public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_SetFloat")]
		public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
		/// <summary>
		/// default_val is NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetVoidPtr")]
		public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_SetVoidPtr")]
		public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
		/// <summary>
		/// <para>- Get***Ref() functions finds pair, insert on demand if missing, return pointer. Useful if you intend to do Get+Set.</para>
		/// <para>- References are only valid until a new value is added to the storage. Calling a Set***() function or a Get***Ref() function invalidates the pointer.</para>
		/// <para>- A typical use case where this is convenient for quick hacking (e.g. add storage during a live Edit&amp;Continue session if you can't modify existing struct)</para>
		/// <para>     float* pvar = ImGui::GetFloatRef(key); ImGui::SliderFloat("var", pvar, 0, 100.0f); some_var += *pvar;</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetIntRef")]
		public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetBoolRef")]
		public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetFloatRef")]
		public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_GetVoidPtrRef")]
		public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
		/// <summary>
		/// <para>Advanced: for quicker full rebuild of a storage (instead of an incremental one), you may add all your contents and then sort once.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_BuildSortByKey")]
		public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
		/// <summary>
		/// <para>Obsolete: use on your own storage if you know only integer are being stored (open/close all tree nodes)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiStorage_SetAllInt")]
		public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipper_Begin")]
		public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
		/// <summary>
		/// Automatically called on the last call of Step() that returns false.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipper_End")]
		public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipper_Step")]
		public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
		/// <summary>
		/// <para>Call IncludeItemByIndex() or IncludeItemsByIndex() *BEFORE* first call to Step() if you need a range of items to not be clipped, regardless of their visibility.</para>
		/// <para>(Due to alignment / padding of certain items it is possible that an extra item may be included on either end of the display range).</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipper_IncludeItemByIndex")]
		public static extern void ImGuiListClipper_IncludeItemByIndex(ImGuiListClipper* self, int item_index);
		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipper_IncludeItemsByIndex")]
		public static extern void ImGuiListClipper_IncludeItemsByIndex(ImGuiListClipper* self, int item_begin, int item_end);
		/// <summary>
		/// <para>Seek cursor toward given item. This is automatically called while stepping.</para>
		/// <para>- The only reason to call this is: you can use ImGuiListClipper::Begin(INT_MAX) if you don't know item count ahead of time.</para>
		/// <para>- In this case, after all steps are done, you'll want to call SeekCursorForItem(item_count).</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipper_SeekCursorForItem")]
		public static extern void ImGuiListClipper_SeekCursorForItem(ImGuiListClipper* self, int item_index);
		/// <summary>
		/// <para>FIXME-OBSOLETE: May need to obsolete/cleanup those helpers.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImColor_SetHSV")]
		public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImColor_HSV")]
		public static extern ImColor ImColor_HSV(float h, float s, float v, float a);
		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_ApplyRequests")]
		public static extern void ImGuiSelectionBasicStorage_ApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* ms_io);
		/// <summary>
		/// Query if an item id is in selection.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_Contains")]
		public static extern byte ImGuiSelectionBasicStorage_Contains(ImGuiSelectionBasicStorage* self, uint id);
		/// <summary>
		/// Clear selection
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_Clear")]
		public static extern void ImGuiSelectionBasicStorage_Clear(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Swap two selections
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_Swap")]
		public static extern void ImGuiSelectionBasicStorage_Swap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);
		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_SetItemSelected")]
		public static extern void ImGuiSelectionBasicStorage_SetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected);
		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiId id; while (selection.GetNextSelectedItem(&amp;it, &amp;id)) { ... }'
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_GetNextSelectedItem")]
		public static extern byte ImGuiSelectionBasicStorage_GetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaque_it, uint* out_id);
		/// <summary>
		/// Convert index to item id based on provided adapter.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionBasicStorage_GetStorageIdFromIndex")]
		public static extern uint ImGuiSelectionBasicStorage_GetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);
		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiSelectionExternalStorage_ApplyRequests")]
		public static extern void ImGuiSelectionExternalStorage_ApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* ms_io);
		/// <summary>
		/// <para>Since 1.83: returns ImTextureID associated with this draw call. Warning: DO NOT assume this is always same as 'TextureId' (we will change this function for an upcoming feature)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawCmd_GetTexID")]
		public static extern IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self);
		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawListSplitter_Clear")]
		public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawListSplitter_ClearFreeMemory")]
		public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawListSplitter_Split")]
		public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawListSplitter_Merge")]
		public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawListSplitter_SetCurrentChannel")]
		public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PushClipRect")]
		public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PushClipRectFullScreen")]
		public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PopClipRect")]
		public static extern void ImDrawList_PopClipRect(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PushTextureID")]
		public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PopTextureID")]
		public static extern void ImDrawList_PopTextureID(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetClipRectMin")]
		public static extern Vector2 ImDrawList_GetClipRectMin(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetClipRectMax")]
		public static extern Vector2 ImDrawList_GetClipRectMax(ImDrawList* self);
		/// <summary>
		/// <para>Primitives</para>
		/// <para>- Filled shapes must always use clockwise winding order. The anti-aliasing fringe depends on it. Counter-clockwise shapes will have "inward" anti-aliasing.</para>
		/// <para>- For rectangular primitives, "p_min" and "p_max" represent the upper-left and lower-right corners.</para>
		/// <para>- For circle primitives, use "num_segments == 0" to automatically calculate tessellation (preferred).</para>
		/// <para>  In older versions (until Dear ImGui 1.77) the AddCircle functions defaulted to num_segments == 12.</para>
		/// <para>  In future versions we will use textures to provide cheaper and higher-quality circles.</para>
		/// <para>  Use AddNgon() and AddNgonFilled() functions if you need to guarantee a specific number of sides.</para>
		/// </summary>
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddLine")]
		public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddLineEx")]
		public static extern void ImDrawList_AddLineEx(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0, thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRect")]
		public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRectEx")]
		public static extern void ImDrawList_AddRectEx(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRectFilled")]
		public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRectFilledEx")]
		public static extern void ImDrawList_AddRectFilledEx(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddRectFilledMultiColor")]
		public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddQuad")]
		public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddQuadEx")]
		public static extern void ImDrawList_AddQuadEx(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddQuadFilled")]
		public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTriangle")]
		public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTriangleEx")]
		public static extern void ImDrawList_AddTriangleEx(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTriangleFilled")]
		public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
		/// <summary>
		/// Implied num_segments = 0, thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCircle")]
		public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCircleEx")]
		public static extern void ImDrawList_AddCircleEx(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCircleFilled")]
		public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddNgon")]
		public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddNgonEx")]
		public static extern void ImDrawList_AddNgonEx(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddNgonFilled")]
		public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0, thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddEllipse")]
		public static extern void ImDrawList_AddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddEllipseEx")]
		public static extern void ImDrawList_AddEllipseEx(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments, float thickness);
		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddEllipseFilled")]
		public static extern void ImDrawList_AddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddEllipseFilledEx")]
		public static extern void ImDrawList_AddEllipseFilledEx(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int num_segments);
		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddText")]
		public static extern void ImDrawList_AddText(ImDrawList* self, Vector2 pos, uint col, byte* text_begin);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTextEx")]
		public static extern void ImDrawList_AddTextEx(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
		/// <summary>
		/// Implied text_end = NULL, wrap_width = 0.0f, cpu_fine_clip_rect = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTextImFontPtr")]
		public static extern void ImDrawList_AddTextImFontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddTextImFontPtrEx")]
		public static extern void ImDrawList_AddTextImFontPtrEx(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
		/// <summary>
		/// Cubic Bezier (4 control points)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddBezierCubic")]
		public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
		/// <summary>
		/// Quadratic Bezier (3 control points)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddBezierQuadratic")]
		public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
		/// <summary>
		/// <para>General polygon</para>
		/// <para>- Only simple polygons are supported by filling functions (no self-intersections, no holes).</para>
		/// <para>- Concave polygon fill is more expensive than convex one: it has O(N^2) complexity. Provided as a convenience fo user but not used by main library.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddPolyline")]
		public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddConvexPolyFilled")]
		public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddConcavePolyFilled")]
		public static extern void ImDrawList_AddConcavePolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
		/// <summary>
		/// <para>Image primitives</para>
		/// <para>- Read FAQ to understand what ImTextureID is.</para>
		/// <para>- "p_min" and "p_max" represent the upper-left and lower-right corners of the rectangle.</para>
		/// <para>- "uv_min" and "uv_max" represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.</para>
		/// </summary>
		/// <summary>
		/// Implied uv_min = ImVec2(0, 0), uv_max = ImVec2(1, 1), col = IM_COL32_WHITE
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddImage")]
		public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddImageEx")]
		public static extern void ImDrawList_AddImageEx(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddImageQuad")]
		public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddImageQuadEx")]
		public static extern void ImDrawList_AddImageQuadEx(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddImageRounded")]
		public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);
		/// <summary>
		/// <para>Stateful path API, add points then finish with PathFillConvex() or PathStroke()</para>
		/// <para>- Important: filled shapes must always use clockwise winding order! The anti-aliasing fringe depends on it. Counter-clockwise shapes will have "inward" anti-aliasing.</para>
		/// <para>  so e.g. 'PathArcTo(center, radius, PI * -0.5f, PI)' is ok, whereas 'PathArcTo(center, radius, PI, PI * -0.5f)' won't have correct anti-aliasing when followed by PathFillConvex().</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathClear")]
		public static extern void ImDrawList_PathClear(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathLineTo")]
		public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathLineToMergeDuplicate")]
		public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathFillConvex")]
		public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathFillConcave")]
		public static extern void ImDrawList_PathFillConcave(ImDrawList* self, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathStroke")]
		public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathArcTo")]
		public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
		/// <summary>
		/// Use precomputed angles for a 12 steps circle
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathArcToFast")]
		public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
		/// <summary>
		/// Implied num_segments = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathEllipticalArcTo")]
		public static extern void ImDrawList_PathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float a_min, float a_max);
		/// <summary>
		/// Ellipse
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathEllipticalArcToEx")]
		public static extern void ImDrawList_PathEllipticalArcToEx(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float a_min, float a_max, int num_segments);
		/// <summary>
		/// Cubic Bezier (4 control points)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathBezierCubicCurveTo")]
		public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
		/// <summary>
		/// Quadratic Bezier (3 control points)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathBezierQuadraticCurveTo")]
		public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PathRect")]
		public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);
		/// <summary>
		/// <para>Advanced: Draw Callbacks</para>
		/// <para>- May be used to alter render state (change sampler, blending, current shader). May be used to emit custom rendering commands (difficult to do correctly, but possible).</para>
		/// <para>- Use special ImDrawCallback_ResetRenderState callback to instruct backend to reset its render state to the default.</para>
		/// <para>- Your rendering loop must check for 'UserCallback' in ImDrawCmd and call the function instead of rendering triangles. All standard backends are honoring this.</para>
		/// <para>- For some backends, the callback may access selected render-states exposed by the backend in a ImGui_ImplXXXX_RenderState structure pointed to by platform_io.Renderer_RenderState.</para>
		/// <para>- IMPORTANT: please be mindful of the different level of indirection between using size==0 (copying argument) and using size&gt;0 (copying pointed data into a buffer).</para>
		/// <para>  - If userdata_size == 0: we copy/store the 'userdata' argument as-is. It will be available unmodified in ImDrawCmd::UserCallbackData during render.</para>
		/// <para>  - If userdata_size &gt; 0,  we copy/store 'userdata_size' bytes pointed to by 'userdata'. We store them in a buffer stored inside the drawlist. ImDrawCmd::UserCallbackData will point inside that buffer so you have to retrieve data from there. Your callback may need to use ImDrawCmd::UserCallbackDataSize if you expect dynamically-sized data.</para>
		/// <para>  - Support for userdata_size &gt; 0 was added in v1.91.4, October 2024. So earlier code always only allowed to copy/store a simple void*.</para>
		/// </summary>
		/// <summary>
		/// Implied userdata_size = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCallback")]
		public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* userdata);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddCallbackEx")]
		public static extern void ImDrawList_AddCallbackEx(ImDrawList* self, IntPtr callback, void* userdata, uint userdata_size);
		/// <summary>
		/// <para>Advanced: Miscellaneous</para>
		/// </summary>
		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_AddDrawCmd")]
		public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_CloneOutput")]
		public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
		/// <summary>
		/// <para>Advanced: Channels</para>
		/// <para>- Use to split render into layers. By switching channels to can render out-of-order (e.g. submit FG primitives before BG primitives)</para>
		/// <para>- Use to minimize draw calls (e.g. if going back-and-forth between multiple clipping rectangles, prefer to append into separate channels then merge at the end)</para>
		/// <para>- This API shouldn't have been in ImDrawList in the first place!</para>
		/// <para>  Prefer using your own persistent instance of ImDrawListSplitter as you can stack them.</para>
		/// <para>  Using the ImDrawList::ChannelsXXXX you cannot stack a split over another.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_ChannelsSplit")]
		public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_ChannelsMerge")]
		public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_ChannelsSetCurrent")]
		public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
		/// <summary>
		/// <para>Advanced: Primitives allocations</para>
		/// <para>- We render triangles (three vertices)</para>
		/// <para>- All primitives needs to be reserved via PrimReserve() beforehand.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimReserve")]
		public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimUnreserve")]
		public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimRect")]
		public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimRectUV")]
		public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimQuadUV")]
		public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimWriteVtx")]
		public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimWriteIdx")]
		public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
		/// <summary>
		/// Write vertex with unique index
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_PrimVtx")]
		public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
		/// <summary>
		/// <para>[Internal helpers]</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__ResetForNewFrame")]
		public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__ClearFreeMemory")]
		public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__PopUnusedDrawCmd")]
		public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__TryMergeDrawCmds")]
		public static extern void ImDrawList__TryMergeDrawCmds(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__OnChangedClipRect")]
		public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__OnChangedTextureID")]
		public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__OnChangedVtxOffset")]
		public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__SetTextureID")]
		public static extern void ImDrawList__SetTextureID(ImDrawList* self, IntPtr texture_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__CalcCircleAutoSegmentCount")]
		public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__PathArcToFastEx")]
		public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList__PathArcToN")]
		public static extern void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawData_Clear")]
		public static extern void ImDrawData_Clear(ImDrawData* self);
		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawData_AddDrawList")]
		public static extern void ImDrawData_AddDrawList(ImDrawData* self, ImDrawList* draw_list);
		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawData_DeIndexAllBuffers")]
		public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawData_ScaleClipRects")]
		public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_Clear")]
		public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
		/// <summary>
		/// Get bit n in the array
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_GetBit")]
		public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
		/// <summary>
		/// Set bit n in the array
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_SetBit")]
		public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
		/// <summary>
		/// Add character
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_AddChar")]
		public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
		/// <summary>
		/// Add string (each character of the UTF-8 string are added)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_AddText")]
		public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_AddRanges")]
		public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
		/// <summary>
		/// Output new ranges (ImVector_Construct()/ImVector_Destruct() can be used to safely construct out_ranges)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontGlyphRangesBuilder_BuildRanges")]
		public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlasCustomRect_IsPacked")]
		public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFont")]
		public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontDefault")]
		public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromFileTTF")]
		public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromMemoryTTF")]
		public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedTTF")]
		public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_data_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedBase85TTF")]
		public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_ClearInputData")]
		public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_ClearTexData")]
		public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
		/// <summary>
		/// Clear output font data (glyphs storage, UV coordinates).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_ClearFonts")]
		public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
		/// <summary>
		/// Clear all input and output.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_Clear")]
		public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
		/// <summary>
		/// <para>Build atlas, retrieve pixel data.</para>
		/// <para>User is in charge of copying the pixels into graphics memory (e.g. create a texture with your engine). Then store your texture handle with SetTexID().</para>
		/// <para>The pitch is always = Width * BytesPerPixels (1 or 4)</para>
		/// <para>Building in RGBA32 format is provided for convenience and compatibility, but note that unless you manually manipulate or copy color data into</para>
		/// <para>the texture (e.g. when using the AddCustomRect*** api), then the RGB pixels emitted will always be white (~75% of memory/bandwidth waste.</para>
		/// </summary>
		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_Build")]
		public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
		/// <summary>
		/// 1 byte per-pixel
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetTexDataAsAlpha8")]
		public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
		/// <summary>
		/// 4 bytes-per-pixel
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetTexDataAsRGBA32")]
		public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_IsBuilt")]
		public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_SetTexID")]
		public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
		/// <summary>
		/// <para>Helpers to retrieve list of common Unicode ranges (2 value per range, values are inclusive, zero-terminated list)</para>
		/// <para>NB: Make sure that your string are UTF-8 and NOT in your local code page.</para>
		/// <para>Read https://github.com/ocornut/imgui/blob/master/docs/FONTS.md/#about-utf-8-encoding for details.</para>
		/// <para>NB: Consider using ImFontGlyphRangesBuilder to build glyph ranges from textual data.</para>
		/// </summary>
		/// <summary>
		/// Basic Latin, Extended Latin
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesDefault")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
		/// <summary>
		/// Default + Greek and Coptic
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesGreek")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self);
		/// <summary>
		/// Default + Korean characters
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesKorean")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesJapanese")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesChineseFull")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
		/// <summary>
		/// Default + about 400 Cyrillic characters
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesCyrillic")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
		/// <summary>
		/// Default + Thai characters
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesThai")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
		/// <summary>
		/// Default + Vietnamese characters
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetGlyphRangesVietnamese")]
		public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
		/// <summary>
		/// <para>You can request arbitrary rectangles to be packed into the atlas, for your own purposes.</para>
		/// <para>- After calling Build(), you can query the rectangle position and render your pixels.</para>
		/// <para>- If you render colored output, set 'atlas-&gt;TexPixelsUseColors = true' as this may help some backends decide of preferred texture format.</para>
		/// <para>- You can also request your rectangles to be mapped as font glyph (given a font + Unicode point),</para>
		/// <para>  so you can render e.g. custom colorful icons and use them as regular glyphs.</para>
		/// <para>- Read docs/FONTS.md for more details about using colorful icons.</para>
		/// <para>- Note: this API may be redesigned later in order to support multi-monitor varying DPI settings.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddCustomRectRegular")]
		public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_AddCustomRectFontGlyph")]
		public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetCustomRectByIndex")]
		public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_CalcCustomRectUV")]
		public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFontAtlas_GetMouseCursorTexData")]
		public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_FindGlyph")]
		public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_FindGlyphNoFallback")]
		public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_GetCharAdvance")]
		public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_IsLoaded")]
		public static extern byte ImFont_IsLoaded(ImFont* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_GetDebugName")]
		public static extern byte* ImFont_GetDebugName(ImFont* self);
		/// <summary>
		/// <para>'max_width' stops rendering after a certain width (could be turned into a 2d size). FLT_MAX to disable.</para>
		/// <para>'wrap_width' enable automatic word-wrapping across multiple lines to fit into given width. 0.0f to disable.</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, remaining = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_CalcTextSizeA")]
		public static extern Vector2 ImFont_CalcTextSizeA(ImFont* self, float size, float max_width, float wrap_width, byte* text_begin);
		/// <summary>
		/// utf8
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_CalcTextSizeAEx")]
		public static extern Vector2 ImFont_CalcTextSizeAEx(ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_CalcWordWrapPositionA")]
		public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_RenderChar")]
		public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_RenderText")]
		public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
		/// <summary>
		/// <para>[Internal] Don't use!</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_BuildLookupTable")]
		public static extern void ImFont_BuildLookupTable(ImFont* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_ClearOutputData")]
		public static extern void ImFont_ClearOutputData(ImFont* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_GrowIndex")]
		public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_AddGlyph")]
		public static extern void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_AddRemapChar")]
		public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_SetGlyphVisible")]
		public static extern void ImFont_SetGlyphVisible(ImFont* self, ushort c, byte visible);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_IsGlyphRangeUnused")]
		public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
		/// <summary>
		/// <para>Helpers</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewport_GetCenter")]
		public static extern Vector2 ImGuiViewport_GetCenter(ImGuiViewport* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewport_GetWorkCenter")]
		public static extern Vector2 ImGuiViewport_GetWorkCenter(ImGuiViewport* self);
	}
}
