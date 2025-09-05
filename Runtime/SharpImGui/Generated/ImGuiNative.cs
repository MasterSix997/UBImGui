using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public unsafe partial class ImGuiNative
	{
		public const string LibraryName = "cimgui";
		[DllImport(LibraryName, EntryPoint = "ImVec2_ImVec2_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2* ImVec2ImVec2();
		[DllImport(LibraryName, EntryPoint = "ImVec2_ImVec2_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2ImVec2NilConstruct(Vector2* self);
		[DllImport(LibraryName, EntryPoint = "ImVec2_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2Destroy(Vector2* self);
		[DllImport(LibraryName, EntryPoint = "ImVec2_ImVec2_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector2* ImVec2ImVec2(float x, float y);
		[DllImport(LibraryName, EntryPoint = "ImVec2_ImVec2_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2ImVec2FloatConstruct(Vector2* self, float x, float y);
		[DllImport(LibraryName, EntryPoint = "ImVec4_ImVec4_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector4* ImVec4ImVec4();
		[DllImport(LibraryName, EntryPoint = "ImVec4_ImVec4_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec4ImVec4NilConstruct(Vector4* self);
		[DllImport(LibraryName, EntryPoint = "ImVec4_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec4Destroy(Vector4* self);
		[DllImport(LibraryName, EntryPoint = "ImVec4_ImVec4_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector4* ImVec4ImVec4(float x, float y, float z, float w);
		[DllImport(LibraryName, EntryPoint = "ImVec4_ImVec4_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec4ImVec4FloatConstruct(Vector4* self, float x, float y, float z, float w);
		[DllImport(LibraryName, EntryPoint = "igCreateContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiContext* CreateContext(ImFontAtlas* sharedFontAtlas);
		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDestroyContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DestroyContext(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igGetCurrentContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiContext* GetCurrentContext();
		[DllImport(LibraryName, EntryPoint = "igSetCurrentContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCurrentContext(ImGuiContext* ctx);
		/// <summary>
		/// access the ImGuiIO structure (mouse/keyboard/gamepad inputs, time, various configuration options/flags)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetIO", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiIO* GetIO();
		[DllImport(LibraryName, EntryPoint = "igGetPlatformIO_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPlatformIO* GetPlatformIO();
		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetStyle", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyle* GetStyle();
		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igNewFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NewFrame();
		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndFrame();
		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igRender", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Render();
		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetDrawData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawData* GetDrawData();
		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowDemoWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowDemoWindow(byte* pOpen);
		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowMetricsWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowMetricsWindow(byte* pOpen);
		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowDebugLogWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowDebugLogWindow(byte* pOpen);
		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowIDStackToolWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowIdStackToolWindow(byte* pOpen);
		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowAboutWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowAboutWindow(byte* pOpen);
		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowStyleEditor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowStyleEditor(ImGuiStyle* _ref);
		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowStyleSelector", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ShowStyleSelector(byte* label);
		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowFontSelector", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowFontSelector(byte* label);
		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShowUserGuide", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowUserGuide();
		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetVersion", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* GetVersion();
		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igStyleColorsDark", CallingConvention = CallingConvention.Cdecl)]
		public static extern void StyleColorsDark(ImGuiStyle* dst);
		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igStyleColorsLight", CallingConvention = CallingConvention.Cdecl)]
		public static extern void StyleColorsLht(ImGuiStyle* dst);
		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igStyleColorsClassic", CallingConvention = CallingConvention.Cdecl)]
		public static extern void StyleColorsClassic(ImGuiStyle* dst);
		[DllImport(LibraryName, EntryPoint = "igBegin", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Begin(byte* name, byte* pOpen, ImGuiWindowFlags flags);
		[DllImport(LibraryName, EntryPoint = "igEnd", CallingConvention = CallingConvention.Cdecl)]
		public static extern void End();
		[DllImport(LibraryName, EntryPoint = "igBeginChild_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginChild(byte* strId, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags);
		[DllImport(LibraryName, EntryPoint = "igBeginChild_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginChild(uint id, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags);
		[DllImport(LibraryName, EntryPoint = "igEndChild", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndChild();
		[DllImport(LibraryName, EntryPoint = "igIsWindowAppearing", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowAppearing();
		[DllImport(LibraryName, EntryPoint = "igIsWindowCollapsed", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowCollapsed();
		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsWindowFocused", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowFocused(ImGuiFocusedFlags flags);
		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsWindowHovered", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowDrawList", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* GetWindowDrawList();
		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowDpiScale", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetWindowDpiScale();
		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetWindowPos(Vector2* pOut);
		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetWindowSize(Vector2* pOut);
		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetWindowWidth();
		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowHeight", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetWindowHeht();
		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewport* GetWindowViewport();
		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowSize(Vector2 size, ImGuiCond cond);
		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowSizeConstraints", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowSizeConstraints(Vector2 sizeMin, Vector2 sizeMax, ImGuiSizeCallback customCallback, void* customCallbackData);
		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowContentSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowContentSize(Vector2 size);
		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowCollapsed", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowFocus", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowFocus();
		/// <summary>
		/// set next window scrolling value (use &lt; 0.0f to not affect a given axis).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowScroll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowScroll(Vector2 scroll);
		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowBgAlpha", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowBgAlpha(float alpha);
		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowViewport(uint viewportId);
		[DllImport(LibraryName, EntryPoint = "igSetWindowPos_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowPos(Vector2 pos, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowSize_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowSize(Vector2 size, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowCollapsed_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowCollapsed(byte collapsed, ImGuiCond cond);
		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetWindowFocus_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowFocus();
		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetWindowFontScale", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowFontScale(float scale);
		[DllImport(LibraryName, EntryPoint = "igSetWindowPos_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowPos(byte* name, Vector2 pos, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowSize_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowSize(byte* name, Vector2 size, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowCollapsed_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowCollapsed(byte* name, byte collapsed, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowFocus_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowFocus(byte* name);
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetScrollX", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetScrollX();
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetScrollY", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetScrollY();
		[DllImport(LibraryName, EntryPoint = "igSetScrollX_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollX(float scrollX);
		[DllImport(LibraryName, EntryPoint = "igSetScrollY_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollY(float scrollY);
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetScrollMaxX", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetScrollMaxX();
		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetScrollMaxY", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetScrollMaxY();
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetScrollHereX", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollHereX(float centerXRatio);
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetScrollHereY", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollHereY(float centerYRatio);
		[DllImport(LibraryName, EntryPoint = "igSetScrollFromPosX_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollFromPosX(float localX, float centerXRatio);
		[DllImport(LibraryName, EntryPoint = "igSetScrollFromPosY_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollFromPosY(float localY, float centerYRatio);
		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushFont(ImFont* font);
		[DllImport(LibraryName, EntryPoint = "igPopFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopFont();
		[DllImport(LibraryName, EntryPoint = "igPushStyleColor_U32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushStyleColor(ImGuiCol idx, uint col);
		[DllImport(LibraryName, EntryPoint = "igPushStyleColor_Vec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushStyleColor(ImGuiCol idx, Vector4 col);
		[DllImport(LibraryName, EntryPoint = "igPopStyleColor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopStyleColor(int count);
		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushStyleVar_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushStyleVar(ImGuiStyleVar idx, float val);
		[DllImport(LibraryName, EntryPoint = "igPushStyleVar_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushStyleVar(ImGuiStyleVar idx, Vector2 val);
		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushStyleVarX", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushStyleVarX(ImGuiStyleVar idx, float valX);
		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushStyleVarY", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushStyleVarY(ImGuiStyleVar idx, float valY);
		[DllImport(LibraryName, EntryPoint = "igPopStyleVar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopStyleVar(int count);
		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushItemFlag", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushItemFlag(ImGuiItemFlags option, byte enabled);
		[DllImport(LibraryName, EntryPoint = "igPopItemFlag", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopItemFlag();
		/// <summary>
		/// push width of items for common large "item+label" widgets. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushItemWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushItemWidth(float itemWidth);
		[DllImport(LibraryName, EntryPoint = "igPopItemWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopItemWidth();
		/// <summary>
		/// set width of the _next_ common large "item+label" widget. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextItemWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemWidth(float itemWidth);
		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igCalcItemWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern float CalcItemWidth();
		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushTextWrapPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushTextWrapPos(float wrapLocalPosX);
		[DllImport(LibraryName, EntryPoint = "igPopTextWrapPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopTextWrapPos();
		/// <summary>
		/// get current font<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* GetFont();
		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetFontSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetFontSize();
		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetFontTexUvWhitePixel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetFontTexUvWhitePixel(Vector2* pOut);
		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetColorU32_Col", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetColorU32(ImGuiCol idx, float alphaMul);
		[DllImport(LibraryName, EntryPoint = "igGetColorU32_Vec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetColorU32(Vector4 col);
		[DllImport(LibraryName, EntryPoint = "igGetColorU32_U32", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetColorU32(uint col, float alphaMul);
		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetStyleColorVec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern Vector4* GetStyleColorVec4(ImGuiCol idx);
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetCursorScreenPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetCursorScreenPos(Vector2* pOut);
		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetCursorScreenPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCursorScreenPos(Vector2 pos);
		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetContentRegionAvail", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetContentRegionAvail(Vector2* pOut);
		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetCursorPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetCursorPos(Vector2* pOut);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetCursorPosX", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetCursorPosX();
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetCursorPosY", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetCursorPosY();
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetCursorPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCursorPos(Vector2 localPos);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetCursorPosX", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCursorPosX(float localX);
		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetCursorPosY", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCursorPosY(float localY);
		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetCursorStartPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetCursorStartPos(Vector2* pOut);
		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSeparator", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Separator();
		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSameLine", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SameLine(float offsetFromStartX, float spacing);
		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igNewLine", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NewLine();
		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSpacing", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Spacing();
		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDummy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Dummy(Vector2 size);
		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIndent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Indent(float indentW);
		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igUnindent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Unindent(float indentW);
		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginGroup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginGroup();
		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndGroup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndGroup();
		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igAlignTextToFramePadding", CallingConvention = CallingConvention.Cdecl)]
		public static extern void AlnTextToFramePadding();
		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetTextLineHeight", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetTextLineHeht();
		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetTextLineHeightWithSpacing", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetTextLineHehtWithSpacing();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetFrameHeight", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetFrameHeht();
		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetFrameHeightWithSpacing", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetFrameHehtWithSpacing();
		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushID_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushID(byte* strId);
		[DllImport(LibraryName, EntryPoint = "igPushID_StrStr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushID(byte* strIdBegin, byte* strIdEnd);
		[DllImport(LibraryName, EntryPoint = "igPushID_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushID(void* ptrId);
		[DllImport(LibraryName, EntryPoint = "igPushID_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushID(int intId);
		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPopID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopID();
		[DllImport(LibraryName, EntryPoint = "igGetID_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetID(byte* strId);
		[DllImport(LibraryName, EntryPoint = "igGetID_StrStr", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetID(byte* strIdBegin, byte* strIdEnd);
		[DllImport(LibraryName, EntryPoint = "igGetID_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetID(void* ptrId);
		[DllImport(LibraryName, EntryPoint = "igGetID_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetID(int intId);
		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTextUnformatted", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextUnformatted(byte* text, byte* textEnd);
		/// <summary>
		/// formatted text<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Text(byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTextColored", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextColored(Vector4 col, byte* fmt);
		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTextDisabled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextDisabled(byte* fmt);
		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTextWrapped", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextWrapped(byte* fmt);
		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLabelText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LabelText(byte* label, byte* fmt);
		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBulletText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BulletText(byte* fmt);
		/// <summary>
		/// currently: formatted text with a horizontal line<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSeparatorText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SeparatorText(byte* label);
		/// <summary>
		/// button<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Button(byte* label, Vector2 size);
		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSmallButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SmallButton(byte* label);
		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igInvisibleButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InvisibleButton(byte* strId, Vector2 size, ImGuiButtonFlags flags);
		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igArrowButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ArrowButton(byte* strId, ImGuiDir dir);
		[DllImport(LibraryName, EntryPoint = "igCheckbox", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Checkbox(byte* label, byte* v);
		[DllImport(LibraryName, EntryPoint = "igCheckboxFlags_IntPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CheckboxFlags(byte* label, int* flags, int flagsValue);
		[DllImport(LibraryName, EntryPoint = "igCheckboxFlags_UintPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CheckboxFlags(byte* label, uint* flags, uint flagsValue);
		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igRadioButton_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte RadioButton(byte* label, byte active);
		[DllImport(LibraryName, EntryPoint = "igRadioButton_IntPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte RadioButton(byte* label, int* v, int vButton);
		[DllImport(LibraryName, EntryPoint = "igProgressBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ProgressBar(float fraction, Vector2 sizeArg, byte* overlay);
		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBullet", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Bullet();
		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTextLink", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TextLink(byte* label);
		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTextLinkOpenURL", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextLinkOpenURL(byte* label, byte* url);
		[DllImport(LibraryName, EntryPoint = "igImage", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Image(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1);
		[DllImport(LibraryName, EntryPoint = "igImageWithBg", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol);
		[DllImport(LibraryName, EntryPoint = "igImageButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImageButton(byte* strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol);
		[DllImport(LibraryName, EntryPoint = "igBeginCombo", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginCombo(byte* label, byte* previewValue, ImGuiComboFlags flags);
		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndCombo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndCombo();
		[DllImport(LibraryName, EntryPoint = "igCombo_Str_arr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ComboStrArr(byte* label, int* currentItem, byte** items, int itemsCount, int popupMaxHeightInItems);
		[DllImport(LibraryName, EntryPoint = "igCombo_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Combo(byte* label, int* currentItem, byte* itemsSeparatedByZeros, int popupMaxHeightInItems);
		[DllImport(LibraryName, EntryPoint = "igCombo_FnStrPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Combo(byte* label, int* currentItem, IgComboGetter getter, void* userData, int itemsCount, int popupMaxHeightInItems);
		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDragFloat", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragFloat(byte* label, float* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragFloat2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragFloat2(byte* label, Vector2* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragFloat3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragFloat3(byte* label, Vector3* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragFloat4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragFloat4(byte* label, Vector4* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragFloatRange2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragFloatRange2(byte* label, float* vCurrentMin, float* vCurrentMax, float vSpeed, float vMin, float vMax, byte* format, byte* formatMax, ImGuiSliderFlags flags);
		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDragInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragInt(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragInt2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragInt2(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragInt3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragInt3(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragInt4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragInt4(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragIntRange2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragIntRange2(byte* label, int* vCurrentMin, int* vCurrentMax, float vSpeed, int vMin, int vMax, byte* format, byte* formatMax, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragScalar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragScalar(byte* label, ImGuiDataType dataType, void* pData, float vSpeed, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragScalarN", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragScalarN(byte* label, ImGuiDataType dataType, void* pData, int components, float vSpeed, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags);
		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSliderFloat", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderFloat(byte* label, float* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderFloat2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderFloat2(byte* label, Vector2* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderFloat3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderFloat3(byte* label, Vector3* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderFloat4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderFloat4(byte* label, Vector4* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderAngle", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderAngle(byte* label, float* vRad, float vDegreesMin, float vDegreesMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderInt(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderInt2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderInt2(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderInt3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderInt3(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderInt4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderInt4(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderScalar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderScalar(byte* label, ImGuiDataType dataType, void* pData, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderScalarN", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderScalarN(byte* label, ImGuiDataType dataType, void* pData, int components, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igVSliderFloat", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte VSliderFloat(byte* label, Vector2 size, float* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igVSliderInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte VSliderInt(byte* label, Vector2 size, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igVSliderScalar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte VSliderScalar(byte* label, Vector2 size, ImGuiDataType dataType, void* pData, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputText", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputText(byte* label, byte* buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData);
		[DllImport(LibraryName, EntryPoint = "igInputTextMultiline", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputTextMultiline(byte* label, byte* buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData);
		[DllImport(LibraryName, EntryPoint = "igInputTextWithHint", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputTextWithHint(byte* label, byte* hint, byte* buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData);
		[DllImport(LibraryName, EntryPoint = "igInputFloat", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputFloat(byte* label, float* v, float step, float stepFast, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputFloat2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputFloat3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputFloat4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputInt(byte* label, int* v, int step, int stepFast, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputInt2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputInt3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputInt4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputDouble", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputDouble(byte* label, double* v, double step, double stepFast, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputScalar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputScalar(byte* label, ImGuiDataType dataType, void* pData, void* pStep, void* pStepFast, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igInputScalarN", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputScalarN(byte* label, ImGuiDataType dataType, void* pData, int components, void* pStep, void* pStepFast, byte* format, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igColorEdit3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
		[DllImport(LibraryName, EntryPoint = "igColorEdit4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
		[DllImport(LibraryName, EntryPoint = "igColorPicker3", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
		[DllImport(LibraryName, EntryPoint = "igColorPicker4", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* refCol);
		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igColorButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ColorButton(byte* descId, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetColorEditOptions", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetColorEditOptions(ImGuiColorEditFlags flags);
		/// <summary>
		/// "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTreeNode_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNode(byte* label);
		[DllImport(LibraryName, EntryPoint = "igTreeNode_StrStr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNode(byte* strId, byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igTreeNode_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNode(void* ptrId, byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igTreeNodeEx_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNodeEx(byte* label, ImGuiTreeNodeFlags flags);
		[DllImport(LibraryName, EntryPoint = "igTreeNodeEx_StrStr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNodeEx(byte* strId, ImGuiTreeNodeFlags flags, byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igTreeNodeEx_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNodeEx(void* ptrId, ImGuiTreeNodeFlags flags, byte* fmt);
		/// <summary>
		/// "<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTreePush_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TreePush(byte* strId);
		[DllImport(LibraryName, EntryPoint = "igTreePush_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TreePush(void* ptrId);
		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTreePop", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TreePop();
		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetTreeNodeToLabelSpacing", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetTreeNodeToLabelSpacing();
		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igCollapsingHeader_TreeNodeFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CollapsingHeader(byte* label, ImGuiTreeNodeFlags flags);
		[DllImport(LibraryName, EntryPoint = "igCollapsingHeader_BoolPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CollapsingHeader(byte* label, byte* pVisible, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextItemOpen", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemOpen(byte isOpen, ImGuiCond cond);
		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextItemStorageID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemStorageID(uint storageId);
		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSelectable_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Selectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
		[DllImport(LibraryName, EntryPoint = "igSelectable_BoolPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Selectable(byte* label, byte* pSelected, ImGuiSelectableFlags flags, Vector2 size);
		[DllImport(LibraryName, EntryPoint = "igBeginMultiSelect", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMultiSelectIO* BeginMultiSelect(ImGuiMultiSelectFlags flags, int selectionSize, int itemsCount);
		[DllImport(LibraryName, EntryPoint = "igEndMultiSelect", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMultiSelectIO* EndMultiSelect();
		[DllImport(LibraryName, EntryPoint = "igSetNextItemSelectionUserData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemSelectionUserData(long selectionUserData);
		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemToggledSelection", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemToggledSelection();
		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginListBox", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginListBox(byte* label, Vector2 size);
		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndListBox", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndListBox();
		[DllImport(LibraryName, EntryPoint = "igListBox_Str_arr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ListBoxStrArr(byte* label, int* currentItem, byte** items, int itemsCount, int heightInItems);
		[DllImport(LibraryName, EntryPoint = "igListBox_FnStrPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ListBoxFnStrPtr(byte* label, int* currentItem, IgComboGetter getter, void* userData, int itemsCount, int heightInItems);
		[DllImport(LibraryName, EntryPoint = "igPlotLines_FloatPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PlotLines(byte* label, float* values, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride);
		[DllImport(LibraryName, EntryPoint = "igPlotLines_FnFloatPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PlotLines(byte* label, IgPlotLinesValuesGetter valuesGetter, void* data, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize);
		[DllImport(LibraryName, EntryPoint = "igPlotHistogram_FloatPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PlotHistogram(byte* label, float* values, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride);
		[DllImport(LibraryName, EntryPoint = "igPlotHistogram_FnFloatPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PlotHistogram(byte* label, IgPlotLinesValuesGetter valuesGetter, void* data, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize);
		[DllImport(LibraryName, EntryPoint = "igValue_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Value(byte* prefix, byte b);
		[DllImport(LibraryName, EntryPoint = "igValue_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Value(byte* prefix, int v);
		[DllImport(LibraryName, EntryPoint = "igValue_Uint", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Value(byte* prefix, uint v);
		[DllImport(LibraryName, EntryPoint = "igValue_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Value(byte* prefix, float v, byte* floatFormat);
		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginMenuBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginMenuBar();
		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndMenuBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndMenuBar();
		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginMainMenuBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginMainMenuBar();
		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndMainMenuBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndMainMenuBar();
		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginMenu", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginMenu(byte* label, byte enabled);
		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndMenu", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndMenu();
		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igMenuItem_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte MenuItem(byte* label, byte* shortcut, byte selected, byte enabled);
		[DllImport(LibraryName, EntryPoint = "igMenuItem_BoolPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte MenuItem(byte* label, byte* shortcut, byte* pSelected, byte enabled);
		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTooltip();
		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndTooltip();
		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTooltip(byte* fmt);
		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginItemTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginItemTooltip();
		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetItemTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetItemTooltip(byte* fmt);
		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopup(byte* strId, ImGuiWindowFlags flags);
		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginPopupModal", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopupModal(byte* name, byte* pOpen, ImGuiWindowFlags flags);
		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndPopup();
		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igOpenPopup_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void OpenPopup(byte* strId, ImGuiPopupFlags popupFlags);
		[DllImport(LibraryName, EntryPoint = "igOpenPopup_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void OpenPopup(uint id, ImGuiPopupFlags popupFlags);
		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igOpenPopupOnItemClick", CallingConvention = CallingConvention.Cdecl)]
		public static extern void OpenPopupOnItemClick(byte* strId, ImGuiPopupFlags popupFlags);
		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igCloseCurrentPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CloseCurrentPopup();
		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginPopupContextItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopupContextItem(byte* strId, ImGuiPopupFlags popupFlags);
		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginPopupContextWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopupContextWindow(byte* strId, ImGuiPopupFlags popupFlags);
		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginPopupContextVoid", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopupContextVoid(byte* strId, ImGuiPopupFlags popupFlags);
		[DllImport(LibraryName, EntryPoint = "igIsPopupOpen_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsPopupOpen(byte* strId, ImGuiPopupFlags flags);
		[DllImport(LibraryName, EntryPoint = "igBeginTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTable(byte* strId, int columns, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth);
		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndTable();
		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableNextRow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableNextRow(ImGuiTableRowFlags rowFlags, float minRowHeight);
		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableNextColumn", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TableNextColumn();
		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableSetColumnIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TableSetColumnIndex(int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableSetupColumn", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float initWidthOrWeight, uint userId);
		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableSetupScrollFreeze", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetupScrollFreeze(int cols, int rows);
		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableHeader", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableHeader(byte* label);
		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableHeadersRow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableHeadersRow();
		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableAngledHeadersRow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableAngledHeadersRow();
		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetSortSpecs", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSortSpecs* TableGetSortSpecs();
		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnCount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TableGetColumnCount();
		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TableGetColumnIndex();
		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetRowIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TableGetRowIndex();
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnName_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* TableGetColumnName(int columnN);
		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumnFlags TableGetColumnFlags(int columnN);
		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableSetColumnEnabled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetColumnEnabled(int columnN, byte v);
		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetHoveredColumn", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TableGetHoveredColumn();
		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableSetBgColor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetBgColor(ImGuiTableBgTarget target, uint color, int columnN);
		[DllImport(LibraryName, EntryPoint = "igColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Columns(int count, byte* id, byte borders);
		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igNextColumn", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NextColumn();
		/// <summary>
		/// get current column index<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetColumnIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetColumnIndex();
		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetColumnWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetColumnWidth(int columnIndex);
		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetColumnWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetColumnWidth(int columnIndex, float width);
		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetColumnOffset", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetColumnOffset(int columnIndex);
		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetColumnOffset", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetColumnOffset(int columnIndex, float offsetX);
		[DllImport(LibraryName, EntryPoint = "igGetColumnsCount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetColumnsCount();
		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTabBar(byte* strId, ImGuiTabBarFlags flags);
		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndTabBar();
		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginTabItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTabItem(byte* label, byte* pOpen, ImGuiTabItemFlags flags);
		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndTabItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndTabItem();
		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTabItemButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TabItemButton(byte* label, ImGuiTabItemFlags flags);
		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetTabItemClosed", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetTabItemClosed(byte* tabOrDockedWindowLabel);
		[DllImport(LibraryName, EntryPoint = "igDockSpace", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint DockSpace(uint dockspaceId, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* windowClass);
		[DllImport(LibraryName, EntryPoint = "igDockSpaceOverViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint DockSpaceOverViewport(uint dockspaceId, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* windowClass);
		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowDockID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowDockID(uint dockId, ImGuiCond cond);
		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowClass", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowClass(ImGuiWindowClass* windowClass);
		[DllImport(LibraryName, EntryPoint = "igGetWindowDockID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetWindowDockID();
		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsWindowDocked", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowDocked();
		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogToTTY", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogToTTY(int autoOpenDepth);
		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogToFile", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogToFile(int autoOpenDepth, byte* filename);
		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogToClipboard", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogToClipboard(int autoOpenDepth);
		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogFinish", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogFinish();
		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogButtons", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogButtons();
		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginDragDropSource", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginDragDropSource(ImGuiDragDropFlags flags);
		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetDragDropPayload", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndDragDropSource", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndDragDropSource();
		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginDragDropTarget", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginDragDropTarget();
		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igAcceptDragDropPayload", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPayload* AcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndDragDropTarget", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndDragDropTarget();
		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetDragDropPayload", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPayload* GetDragDropPayload();
		[DllImport(LibraryName, EntryPoint = "igBeginDisabled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginDisabled(byte disabled);
		[DllImport(LibraryName, EntryPoint = "igEndDisabled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndDisabled();
		[DllImport(LibraryName, EntryPoint = "igPushClipRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushClipRect(Vector2 clipRectMin, Vector2 clipRectMax, byte intersectWithCurrentClipRect);
		[DllImport(LibraryName, EntryPoint = "igPopClipRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopClipRect();
		/// <summary>
		/// make last item the default focused item of a newly appearing window.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetItemDefaultFocus", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetItemDefaultFocus();
		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetKeyboardFocusHere", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetKeyboardFocusHere(int offset);
		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNavCursorVisible", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNavCursorVisible(byte visible);
		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextItemAllowOverlap", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemAllowOverlap();
		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemHovered", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemHovered(ImGuiHoveredFlags flags);
		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemActive", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemActive();
		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemFocused", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemFocused();
		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemClicked", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemClicked(ImGuiMouseButton mouseButton);
		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemVisible", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemVisible();
		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemEdited", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemEdited();
		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemActivated", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemActivated();
		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemDeactivated", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemDeactivated();
		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemDeactivatedAfterEdit", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemDeactivatedAfterEdit();
		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemToggledOpen", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemToggledOpen();
		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsAnyItemHovered", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsAnyItemHovered();
		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsAnyItemActive", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsAnyItemActive();
		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsAnyItemFocused", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsAnyItemFocused();
		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetItemID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetItemID();
		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetItemRectMin", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetItemRectMin(Vector2* pOut);
		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetItemRectMax", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetItemRectMax(Vector2* pOut);
		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetItemRectSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetItemRectSize(Vector2* pOut);
		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetMainViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewport* GetMainViewport();
		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetBackgroundDrawList", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* GetBackgroundDrawList(ImGuiViewport* viewport);
		[DllImport(LibraryName, EntryPoint = "igGetForegroundDrawList_ViewportPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* GetForegroundDrawList(ImGuiViewport* viewport);
		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsRectVisible_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsRectVisible(Vector2 size);
		[DllImport(LibraryName, EntryPoint = "igIsRectVisible_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsRectVisible(Vector2 rectMin, Vector2 rectMax);
		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetTime", CallingConvention = CallingConvention.Cdecl)]
		public static extern double GetTime();
		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetFrameCount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetFrameCount();
		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetDrawListSharedData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawListSharedData* GetDrawListSharedData();
		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetStyleColorName", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* GetStyleColorName(ImGuiCol idx);
		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetStateStorage", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetStateStorage(ImGuiStorage* storage);
		[DllImport(LibraryName, EntryPoint = "igGetStateStorage", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStorage* GetStateStorage();
		[DllImport(LibraryName, EntryPoint = "igCalcTextSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CalcTextSize(Vector2* pOut, byte* text, byte* textEnd, byte hideTextAfterDoubleHash, float wrapWidth);
		[DllImport(LibraryName, EntryPoint = "igColorConvertU32ToFloat4", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ColorConvertU32ToFloat4(Vector4* pOut, uint _in);
		[DllImport(LibraryName, EntryPoint = "igColorConvertFloat4ToU32", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ColorConvertFloat4ToU32(Vector4 _in);
		[DllImport(LibraryName, EntryPoint = "igColorConvertRGBtoHSV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ColorConvertRgBtoHSV(float r, float g, float b, float* outH, float* outS, float* outV);
		[DllImport(LibraryName, EntryPoint = "igColorConvertHSVtoRGB", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ColorConvertHsVtoRGB(float h, float s, float v, float* outR, float* outG, float* outB);
		[DllImport(LibraryName, EntryPoint = "igIsKeyDown_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyDown(ImGuiKey key);
		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsKeyPressed_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyPressed(ImGuiKey key, byte repeat);
		[DllImport(LibraryName, EntryPoint = "igIsKeyReleased_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyReleased(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsKeyChordPressed_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyChordPressed(int keyChord);
		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be &gt;1 if RepeatRate is small enough that DeltaTime &gt; RepeatRate<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetKeyPressedAmount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetKeyPressedAmount(ImGuiKey key, float repeatDelay, float rate);
		/// <summary>
		/// [DEBUG] returns English name of the key. Those names are provided for debugging purpose and are not meant to be saved persistently nor compared.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetKeyName", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* GetKeyName(ImGuiKey key);
		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextFrameWantCaptureKeyboard", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextFrameWantCaptureKeyboard(byte wantCaptureKeyboard);
		[DllImport(LibraryName, EntryPoint = "igShortcut_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Shortcut(int keyChord, ImGuiInputFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSetNextItemShortcut", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemShortcut(int keyChord, ImGuiInputFlags flags);
		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetItemKeyOwner_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetItemKeyOwner(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsMouseDown_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseDown(ImGuiMouseButton button);
		[DllImport(LibraryName, EntryPoint = "igIsMouseClicked_Bool", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseClicked(ImGuiMouseButton button, byte repeat);
		[DllImport(LibraryName, EntryPoint = "igIsMouseReleased_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseReleased(ImGuiMouseButton button);
		[DllImport(LibraryName, EntryPoint = "igIsMouseDoubleClicked_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseDoubleClicked(ImGuiMouseButton button);
		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay &gt;= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsMouseReleasedWithDelay", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseReleasedWithDelay(ImGuiMouseButton button, float delay);
		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetMouseClickedCount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int GetMouseClickedCount(ImGuiMouseButton button);
		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsMouseHoveringRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseHoveringRect(Vector2 rMin, Vector2 rMax, byte clip);
		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsMousePosValid", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMousePosValid(Vector2* mousePos);
		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsAnyMouseDown", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsAnyMouseDown();
		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetMousePos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetMousePos(Vector2* pOut);
		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetMousePosOnOpeningCurrentPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetMousePosOnOpeningCurrentPopup(Vector2* pOut);
		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsMouseDragging", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseDragging(ImGuiMouseButton button, float lockThreshold);
		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetMouseDragDelta", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lockThreshold);
		/// <summary>
		/// //<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igResetMouseDragDelta", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ResetMouseDragDelta(ImGuiMouseButton button);
		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetMouseCursor", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMouseCursor GetMouseCursor();
		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetMouseCursor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetMouseCursor(ImGuiMouseCursor cursorType);
		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetNextFrameWantCaptureMouse", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextFrameWantCaptureMouse(byte wantCaptureMouse);
		[DllImport(LibraryName, EntryPoint = "igGetClipboardText", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* GetClipboardText();
		[DllImport(LibraryName, EntryPoint = "igSetClipboardText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetClipboardText(byte* text);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLoadIniSettingsFromDisk", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LoadIniSettingsFromDisk(byte* iniFilename);
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLoadIniSettingsFromMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LoadIniSettingsFromMemory(byte* iniData, uint iniSize);
		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSaveIniSettingsToDisk", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SaveIniSettingsToDisk(byte* iniFilename);
		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSaveIniSettingsToMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* SaveIniSettingsToMemory(uint* outIniSize);
		[DllImport(LibraryName, EntryPoint = "igDebugTextEncoding", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugTextEncoding(byte* text);
		[DllImport(LibraryName, EntryPoint = "igDebugFlashStyleColor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugFlashStyleColor(ImGuiCol idx);
		[DllImport(LibraryName, EntryPoint = "igDebugStartItemPicker", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugStartItemPicker();
		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDebugCheckVersionAndDataLayout", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DebugCheckVersionAndDataLayout(byte* versionStr, uint szIo, uint szStyle, uint szVec2, uint szVec4, uint szDrawvert, uint szDrawidx);
		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDebugLog", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugLog(byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igSetAllocatorFunctions", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetAllocatorFunctions(ImGuiMemAllocFunc allocFunc, ImGuiMemFreeFunc freeFunc, void* userData);
		[DllImport(LibraryName, EntryPoint = "igGetAllocatorFunctions", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetAllocatorFunctions(void* pAllocFunc, void* pFreeFunc, void** pUserData);
		[DllImport(LibraryName, EntryPoint = "igMemAlloc", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* MemAlloc(uint size);
		[DllImport(LibraryName, EntryPoint = "igMemFree", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MemFree(void* ptr);
		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igUpdatePlatformWindows", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdatePlatformWindows();
		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igRenderPlatformWindowsDefault", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderPlatformWindowsDefault(void* platformRenderArg, void* rendererRenderArg);
		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDestroyPlatformWindows", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DestroyPlatformWindows();
		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igFindViewportByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewport* FindViewportByID(uint id);
		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igFindViewportByPlatformHandle", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewport* FindViewportByPlatformHandle(void* platformHandle);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSortSpecs_ImGuiTableSortSpecs", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecsImGuiTableSortSpecs();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSortSpecs_ImGuiTableSortSpecs_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSortSpecsImGuiTableSortSpecsConstruct(ImGuiTableSortSpecs* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSortSpecs_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSortSpecsDestroy(ImGuiTableSortSpecs* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecsImGuiTableColumnSortSpecs();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSortSpecsImGuiTableColumnSortSpecsConstruct(ImGuiTableColumnSortSpecs* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumnSortSpecs_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSortSpecsDestroy(ImGuiTableColumnSortSpecs* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyle_ImGuiStyle", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyle* ImGuiStyleImGuiStyle();
		[DllImport(LibraryName, EntryPoint = "ImGuiStyle_ImGuiStyle_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleImGuiStyleConstruct(ImGuiStyle* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyle_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleDestroy(ImGuiStyle* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyle_ScaleAllSizes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleScaleAllSizes(ImGuiStyle* self, float scaleFactor);
		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddKeyEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);
		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddKeyAnalogEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);
		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddMousePosEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddMousePosEvent(ImGuiIO* self, float x, float y);
		/// <summary>
		/// Queue a mouse button change<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddMouseButtonEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddMouseButtonEvent(ImGuiIO* self, int button, byte down);
		/// <summary>
		/// Queue a mouse wheel update. wheel_y&lt;0: scroll down, wheel_y&gt;0: scroll up, wheel_x&lt;0: scroll right, wheel_x&gt;0: scroll left.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddMouseWheelEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddMouseWheelEvent(ImGuiIO* self, float wheelX, float wheelY);
		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddMouseSourceEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddMouseViewportEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddMouseViewportEvent(ImGuiIO* self, uint id);
		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddFocusEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddFocusEvent(ImGuiIO* self, byte focused);
		/// <summary>
		/// Queue a new character input<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddInputCharacter", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddInputCharacter(ImGuiIO* self, uint c);
		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddInputCharacterUTF16", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddInputCharacterUtf16(ImGuiIO* self, ushort c);
		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_AddInputCharactersUTF8", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOAddInputCharactersUtf8(ImGuiIO* self, byte* str);
		/// <summary>
		/// [Optional] Specify index for legacy &lt;1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_SetKeyEventNativeData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOSetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int nativeKeycode, int nativeScancode, int nativeLegacyIndex);
		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_SetAppAcceptingEvents", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOSetAppAcceptingEvents(ImGuiIO* self, byte acceptingEvents);
		/// <summary>
		/// Clear all incoming events.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_ClearEventsQueue", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOClearEventsQueue(ImGuiIO* self);
		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_ClearInputKeys", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOClearInputKeys(ImGuiIO* self);
		/// <summary>
		/// Clear current mouse state.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_ClearInputMouse", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOClearInputMouse(ImGuiIO* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_ImGuiIO", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiIO* ImGuiIOImGuiIO();
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_ImGuiIO_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIOImGuiIOConstruct(ImGuiIO* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiIO_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIODestroy(ImGuiIO* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_ImGuiInputTextCallbackData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackDataImGuiInputTextCallbackData();
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_ImGuiInputTextCallbackData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackDataImGuiInputTextCallbackDataConstruct(ImGuiInputTextCallbackData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackDataDestroy(ImGuiInputTextCallbackData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_DeleteChars", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackDataDeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytesCount);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_InsertChars", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackDataInsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* textEnd);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_SelectAll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackDataSelectAll(ImGuiInputTextCallbackData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_ClearSelection", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextCallbackDataClearSelection(ImGuiInputTextCallbackData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextCallbackData_HasSelection", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiInputTextCallbackDataHasSelection(ImGuiInputTextCallbackData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowClass_ImGuiWindowClass", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowClass* ImGuiWindowClassImGuiWindowClass();
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowClass_ImGuiWindowClass_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowClassImGuiWindowClassConstruct(ImGuiWindowClass* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowClass_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowClassDestroy(ImGuiWindowClass* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_ImGuiPayload", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPayload* ImGuiPayloadImGuiPayload();
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_ImGuiPayload_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPayloadImGuiPayloadConstruct(ImGuiPayload* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPayloadDestroy(ImGuiPayload* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPayloadClear(ImGuiPayload* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_IsDataType", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiPayloadIsDataType(ImGuiPayload* self, byte* type);
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_IsPreview", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiPayloadIsPreview(ImGuiPayload* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPayload_IsDelivery", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiPayloadIsDelivery(ImGuiPayload* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiOnceUponAFrame_ImGuiOnceUponAFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrameImGuiOnceUponAFrame();
		[DllImport(LibraryName, EntryPoint = "ImGuiOnceUponAFrame_ImGuiOnceUponAFrame_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOnceUponAFrameImGuiOnceUponAFrameConstruct(ImGuiOnceUponAFrame* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiOnceUponAFrame_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOnceUponAFrameDestroy(ImGuiOnceUponAFrame* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_ImGuiTextFilter", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTextFilter* ImGuiTextFilterImGuiTextFilter(byte* defaultFilter);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_ImGuiTextFilter_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilterImGuiTextFilterConstruct(ImGuiTextFilter* self, byte* defaultFilter);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilterDestroy(ImGuiTextFilter* self);
		/// <summary>
		/// Helper calling InputText+Build<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_Draw", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextFilterDraw(ImGuiTextFilter* self, byte* label, float width);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_PassFilter", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextFilterPassFilter(ImGuiTextFilter* self, byte* text, byte* textEnd);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_Build", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilterBuild(ImGuiTextFilter* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextFilterClear(ImGuiTextFilter* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextFilter_IsActive", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextFilterIsActive(ImGuiTextFilter* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_ImGuiTextRange_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTextRange* ImGuiTextRangeImGuiTextRange();
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_ImGuiTextRange_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRangeImGuiTextRangeNilConstruct(ImGuiTextRange* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRangeDestroy(ImGuiTextRange* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_ImGuiTextRange_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTextRange* ImGuiTextRangeImGuiTextRange(byte* b, byte* e);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_ImGuiTextRange_Str_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRangeImGuiTextRangeStrConstruct(ImGuiTextRange* self, byte* b, byte* e);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_empty", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextRangeEmpty(ImGuiTextRange* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextRange_split", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextRangeSplit(ImGuiTextRange* self, byte separator, ImVector<ImGuiTextRange>* _out);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_ImGuiTextBuffer", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTextBuffer* ImGuiTextBufferImGuiTextBuffer();
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_ImGuiTextBuffer_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferImGuiTextBufferConstruct(ImGuiTextBuffer* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferDestroy(ImGuiTextBuffer* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_begin", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextBufferBegin(ImGuiTextBuffer* self);
		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_end", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextBufferEnd(ImGuiTextBuffer* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_size", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiTextBufferSize(ImGuiTextBuffer* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_empty", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiTextBufferEmpty(ImGuiTextBuffer* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferClear(ImGuiTextBuffer* self);
		/// <summary>
		/// Similar to resize(0) on ImVector: empty string but don't free buffer.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_resize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferResize(ImGuiTextBuffer* self, int size);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_reserve", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferReserve(ImGuiTextBuffer* self, int capacity);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_c_str", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextBufferCStr(ImGuiTextBuffer* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_append", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferAppend(ImGuiTextBuffer* self, byte* str, byte* strEnd);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStoragePair* ImGuiStoragePairImGuiStoragePair(uint key, int val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Int_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePairImGuiStoragePairIntConstruct(ImGuiStoragePair* self, uint key, int val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePairDestroy(ImGuiStoragePair* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStoragePair* ImGuiStoragePairImGuiStoragePair(uint key, float val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePairImGuiStoragePairFloatConstruct(ImGuiStoragePair* self, uint key, float val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStoragePair* ImGuiStoragePairImGuiStoragePair(uint key, void* val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStoragePair_ImGuiStoragePair_Ptr_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStoragePairImGuiStoragePairPtrConstruct(ImGuiStoragePair* self, uint key, void* val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageClear(ImGuiStorage* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiStorageGetInt(ImGuiStorage* self, uint key, int defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_SetInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageSetInt(ImGuiStorage* self, uint key, int val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetBool", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiStorageGetBool(ImGuiStorage* self, uint key, byte defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_SetBool", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageSetBool(ImGuiStorage* self, uint key, byte val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetFloat", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiStorageGetFloat(ImGuiStorage* self, uint key, float defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_SetFloat", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageSetFloat(ImGuiStorage* self, uint key, float val);
		/// <summary>
		/// default_val is NULL<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetVoidPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImGuiStorageGetVoidPtr(ImGuiStorage* self, uint key);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_SetVoidPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageSetVoidPtr(ImGuiStorage* self, uint key, void* val);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetIntRef", CallingConvention = CallingConvention.Cdecl)]
		public static extern int* ImGuiStorageGetIntRef(ImGuiStorage* self, uint key, int defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetBoolRef", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiStorageGetBoolRef(ImGuiStorage* self, uint key, byte defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetFloatRef", CallingConvention = CallingConvention.Cdecl)]
		public static extern float* ImGuiStorageGetFloatRef(ImGuiStorage* self, uint key, float defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_GetVoidPtrRef", CallingConvention = CallingConvention.Cdecl)]
		public static extern void** ImGuiStorageGetVoidPtrRef(ImGuiStorage* self, uint key, void* defaultVal);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_BuildSortByKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageBuildSortByKey(ImGuiStorage* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStorage_SetAllInt", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStorageSetAllInt(ImGuiStorage* self, int val);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_ImGuiListClipper", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiListClipper* ImGuiListClipperImGuiListClipper();
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_ImGuiListClipper_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperImGuiListClipperConstruct(ImGuiListClipper* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperDestroy(ImGuiListClipper* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_Begin", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperBegin(ImGuiListClipper* self, int itemsCount, float itemsHeight);
		/// <summary>
		/// Automatically called on the last call of Step() that returns false.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_End", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperEnd(ImGuiListClipper* self);
		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_Step", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiListClipperStep(ImGuiListClipper* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_IncludeItemByIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperIncludeItemByIndex(ImGuiListClipper* self, int itemIndex);
		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_IncludeItemsByIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperIncludeItemsByIndex(ImGuiListClipper* self, int itemBegin, int itemEnd);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipper_SeekCursorForItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperSeekCursorForItem(ImGuiListClipper* self, int itemIndex);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImColor* ImColorImColor();
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorImColorNilConstruct(ImColor* self);
		[DllImport(LibraryName, EntryPoint = "ImColor_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorDestroy(ImColor* self);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImColor* ImColorImColor(float r, float g, float b, float a);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorImColorFloatConstruct(ImColor* self, float r, float g, float b, float a);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Vec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImColor* ImColorImColor(Vector4 col);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Vec4_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorImColorVec4Construct(ImColor* self, Vector4 col);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImColor* ImColorImColor(int r, int g, int b, int a);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_Int_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorImColorIntConstruct(ImColor* self, int r, int g, int b, int a);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_U32", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImColor* ImColorImColorU32(uint rgba);
		[DllImport(LibraryName, EntryPoint = "ImColor_ImColor_U32_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorImColorU32Construct(ImColor* self, uint rgba);
		[DllImport(LibraryName, EntryPoint = "ImColor_SetHSV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorSetHSV(ImColor* self, float h, float s, float v, float a);
		[DllImport(LibraryName, EntryPoint = "ImColor_HSV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImColorHSV(ImColor* pOut, float h, float s, float v, float a);
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSelectionBasicStorage* ImGuiSelectionBasicStorageImGuiSelectionBasicStorage();
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_ImGuiSelectionBasicStorage_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionBasicStorageImGuiSelectionBasicStorageConstruct(ImGuiSelectionBasicStorage* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionBasicStorageDestroy(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_ApplyRequests", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionBasicStorageApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* msIo);
		/// <summary>
		/// Query if an item id is in selection.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_Contains", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiSelectionBasicStorageContains(ImGuiSelectionBasicStorage* self, uint id);
		/// <summary>
		/// Clear selection<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionBasicStorageClear(ImGuiSelectionBasicStorage* self);
		/// <summary>
		/// Swap two selections<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_Swap", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionBasicStorageSwap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r);
		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_SetItemSelected", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionBasicStorageSetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected);
		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_GetNextSelectedItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiSelectionBasicStorageGetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaqueIt, uint* outId);
		/// <summary>
		/// Convert index to item id based on provided adapter.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionBasicStorage_GetStorageIdFromIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuiSelectionBasicStorageGetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx);
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSelectionExternalStorage* ImGuiSelectionExternalStorageImGuiSelectionExternalStorage();
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionExternalStorage_ImGuiSelectionExternalStorage_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionExternalStorageImGuiSelectionExternalStorageConstruct(ImGuiSelectionExternalStorage* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionExternalStorage_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionExternalStorageDestroy(ImGuiSelectionExternalStorage* self);
		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiSelectionExternalStorage_ApplyRequests", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSelectionExternalStorageApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* msIo);
		/// <summary>
		/// Also ensure our padding fields are zeroed<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawCmd_ImDrawCmd", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawCmd* ImDrawCmdImDrawCmd();
		[DllImport(LibraryName, EntryPoint = "ImDrawCmd_ImDrawCmd_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawCmdImDrawCmdConstruct(ImDrawCmd* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawCmd_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawCmdDestroy(ImDrawCmd* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawCmd_GetTexID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImDrawCmdGetTexID(ImDrawCmd* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_ImDrawListSplitter", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawListSplitter* ImDrawListSplitterImDrawListSplitter();
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_ImDrawListSplitter_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterImDrawListSplitterConstruct(ImDrawListSplitter* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterDestroy(ImDrawListSplitter* self);
		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterClear(ImDrawListSplitter* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_ClearFreeMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterClearFreeMemory(ImDrawListSplitter* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_Split", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterSplit(ImDrawListSplitter* self, ImDrawList* drawList, int count);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_Merge", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterMerge(ImDrawListSplitter* self, ImDrawList* drawList);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSplitter_SetCurrentChannel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSplitterSetCurrentChannel(ImDrawListSplitter* self, ImDrawList* drawList, int channelIdx);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_ImDrawList", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* ImDrawListImDrawList(ImDrawListSharedData* sharedData);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_ImDrawList_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListImDrawListConstruct(ImDrawList* self, ImDrawListSharedData* sharedData);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListDestroy(ImDrawList* self);
		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PushClipRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPushClipRect(ImDrawList* self, Vector2 clipRectMin, Vector2 clipRectMax, byte intersectWithCurrentClipRect);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PushClipRectFullScreen", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPushClipRectFullScreen(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PopClipRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPopClipRect(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PushTextureID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPushTextureID(ImDrawList* self, ulong textureId);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PopTextureID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPopTextureID(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_GetClipRectMin", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListGetClipRectMin(Vector2* pOut, ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_GetClipRectMax", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListGetClipRectMax(Vector2* pOut, ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddLine", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddRect(ImDrawList* self, Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags, float thickness);
		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddRectFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddRectFilled(ImDrawList* self, Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddRectFilledMultiColor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddRectFilledMultiColor(ImDrawList* self, Vector2 pMin, Vector2 pMax, uint colUprLeft, uint colUprRight, uint colBotRight, uint colBotLeft);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddQuad", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddQuadFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddTriangle", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddTriangleFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddCircle", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddCircleFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddNgon", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddNgonFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddEllipse", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int numSegments, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddEllipseFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int numSegments);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddText_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddText(ImDrawList* self, Vector2 pos, uint col, byte* textBegin, byte* textEnd);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddText_FontPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddText(ImDrawList* self, ImFont* font, float fontSize, Vector2 pos, uint col, byte* textBegin, byte* textEnd, float wrapWidth, Vector4* cpuFineClipRect);
		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddBezierCubic", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int numSegments);
		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddBezierQuadratic", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int numSegments);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddPolyline", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddPolyline(ImDrawList* self, Vector2* points, int numPoints, uint col, ImDrawFlags flags, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddConvexPolyFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddConvexPolyFilled(ImDrawList* self, Vector2* points, int numPoints, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddConcavePolyFilled", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddConcavePolyFilled(ImDrawList* self, Vector2* points, int numPoints, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddImage", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddImage(ImDrawList* self, ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddImageQuad", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddImageQuad(ImDrawList* self, ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddImageRounded", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddImageRounded(ImDrawList* self, ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col, float rounding, ImDrawFlags flags);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathClear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathClear(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathLineTo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathLineTo(ImDrawList* self, Vector2 pos);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathLineToMergeDuplicate", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathFillConvex", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathFillConvex(ImDrawList* self, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathFillConcave", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathFillConcave(ImDrawList* self, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathStroke", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathArcTo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathArcTo(ImDrawList* self, Vector2 center, float radius, float aMin, float aMax, int numSegments);
		/// <summary>
		/// Use precomputed angles for a 12 steps circle<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathArcToFast", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathArcToFast(ImDrawList* self, Vector2 center, float radius, int aMinOf_12, int aMaxOf_12);
		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathEllipticalArcTo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float aMin, float aMax, int numSegments);
		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathBezierCubicCurveTo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int numSegments);
		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathBezierQuadraticCurveTo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int numSegments);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PathRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathRect(ImDrawList* self, Vector2 rectMin, Vector2 rectMax, float rounding, ImDrawFlags flags);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddCallback", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddCallback(ImDrawList* self, ImDrawCallback callback, void* userdata, uint userdataSize);
		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_AddDrawCmd", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListAddDrawCmd(ImDrawList* self);
		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_CloneOutput", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* ImDrawListCloneOutput(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_ChannelsSplit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListChannelsSplit(ImDrawList* self, int count);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_ChannelsMerge", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListChannelsMerge(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_ChannelsSetCurrent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListChannelsSetCurrent(ImDrawList* self, int n);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimReserve", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimReserve(ImDrawList* self, int idxCount, int vtxCount);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimUnreserve", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimUnreserve(ImDrawList* self, int idxCount, int vtxCount);
		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimRectUV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimQuadUV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uvA, Vector2 uvB, Vector2 uvC, Vector2 uvD, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimWriteVtx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimWriteIdx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimWriteIdx(ImDrawList* self, ushort idx);
		/// <summary>
		/// Write vertex with unique index<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawList_PrimVtx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__ResetForNewFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListResetForNewFrame(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__ClearFreeMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListClearFreeMemory(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__PopUnusedDrawCmd", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPopUnusedDrawCmd(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__TryMergeDrawCmds", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListTryMergeDrawCmds(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__OnChangedClipRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListOnChangedClipRect(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__OnChangedTextureID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListOnChangedTextureID(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__OnChangedVtxOffset", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListOnChangedVtxOffset(ImDrawList* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__SetTextureID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSetTextureID(ImDrawList* self, ulong textureId);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__CalcCircleAutoSegmentCount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImDrawListCalcCircleAutoSegmentCount(ImDrawList* self, float radius);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__PathArcToFastEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int aMinSample, int aMaxSample, int aStep);
		[DllImport(LibraryName, EntryPoint = "ImDrawList__PathArcToN", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListPathArcToN(ImDrawList* self, Vector2 center, float radius, float aMin, float aMax, int numSegments);
		[DllImport(LibraryName, EntryPoint = "ImDrawData_ImDrawData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawData* ImDrawDataImDrawData();
		[DllImport(LibraryName, EntryPoint = "ImDrawData_ImDrawData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataImDrawDataConstruct(ImDrawData* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataDestroy(ImDrawData* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawData_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataClear(ImDrawData* self);
		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawData_AddDrawList", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataAddDrawList(ImDrawData* self, ImDrawList* drawList);
		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawData_DeIndexAllBuffers", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataDeIndexAllBuffers(ImDrawData* self);
		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImDrawData_ScaleClipRects", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataScaleClipRects(ImDrawData* self, Vector2 fbScale);
		[DllImport(LibraryName, EntryPoint = "ImFontConfig_ImFontConfig", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontConfig* ImFontConfImFontConf();
		[DllImport(LibraryName, EntryPoint = "ImFontConfig_ImFontConfig_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontConfImFontConfConstruct(ImFontConfig* self);
		[DllImport(LibraryName, EntryPoint = "ImFontConfig_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontConfDestroy(ImFontConfig* self);
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilderImFontGlyphRangesBuilder();
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderImFontGlyphRangesBuilderConstruct(ImFontGlyphRangesBuilder* self);
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderDestroy(ImFontGlyphRangesBuilder* self);
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderClear(ImFontGlyphRangesBuilder* self);
		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_GetBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontGlyphRangesBuilderGetBit(ImFontGlyphRangesBuilder* self, uint n);
		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_SetBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderSetBit(ImFontGlyphRangesBuilder* self, uint n);
		/// <summary>
		/// Add character<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_AddChar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderAddChar(ImFontGlyphRangesBuilder* self, ushort c);
		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_AddText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderAddText(ImFontGlyphRangesBuilder* self, byte* text, byte* textEnd);
		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_AddRanges", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderAddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontGlyphRangesBuilder_BuildRanges", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGlyphRangesBuilderBuildRanges(ImFontGlyphRangesBuilder* self, ImVector<ushort>* outRanges);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlasCustomRect_ImFontAtlasCustomRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRectImFontAtlasCustomRect();
		[DllImport(LibraryName, EntryPoint = "ImFontAtlasCustomRect_ImFontAtlasCustomRect_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasCustomRectImFontAtlasCustomRectConstruct(ImFontAtlasCustomRect* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlasCustomRect_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasCustomRectDestroy(ImFontAtlasCustomRect* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlasCustomRect_IsPacked", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlasCustomRectIsPacked(ImFontAtlasCustomRect* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_ImFontAtlas", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontAtlas* ImFontAtlasImFontAtlas();
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_ImFontAtlas_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasImFontAtlasConstruct(ImFontAtlas* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasDestroy(ImFontAtlas* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlasAddFont(ImFontAtlas* self, ImFontConfig* fontCfg);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddFontDefault", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlasAddFontDefault(ImFontAtlas* self, ImFontConfig* fontCfg);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddFontFromFileTTF", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlasAddFontFromFileTTF(ImFontAtlas* self, byte* filename, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges);
		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddFontFromMemoryTTF", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlasAddFontFromMemoryTTF(ImFontAtlas* self, void* fontData, int fontDataSize, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges);
		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedTTF", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlasAddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressedFontData, int compressedFontDataSize, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges);
		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddFontFromMemoryCompressedBase85TTF", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontAtlasAddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressedFontDataBase85, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges);
		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_ClearInputData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasClearInputData(ImFontAtlas* self);
		/// <summary>
		/// Clear input+output font data (same as ClearInputData() + glyphs storage, UV coordinates).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_ClearFonts", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasClearFonts(ImFontAtlas* self);
		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_ClearTexData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasClearTexData(ImFontAtlas* self);
		/// <summary>
		/// Clear all input and output.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasClear(ImFontAtlas* self);
		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_Build", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlasBuild(ImFontAtlas* self);
		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetTexDataAsAlpha8", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasGetTexDataAsAlpha8(ImFontAtlas* self, byte** outPixels, int* outWidth, int* outHeight, int* outBytesPerPixel);
		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetTexDataAsRGBA32", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasGetTexDataAsRgba32(ImFontAtlas* self, byte** outPixels, int* outWidth, int* outHeight, int* outBytesPerPixel);
		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_IsBuilt", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlasIsBuilt(ImFontAtlas* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_SetTexID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasSetTexID(ImFontAtlas* self, ulong id);
		/// <summary>
		/// Basic Latin, Extended Latin<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesDefault", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesDefault(ImFontAtlas* self);
		/// <summary>
		/// Default + Greek and Coptic<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesGreek", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesGreek(ImFontAtlas* self);
		/// <summary>
		/// Default + Korean characters<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesKorean", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesKorean(ImFontAtlas* self);
		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesJapanese", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesJapanese(ImFontAtlas* self);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesChineseFull", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesChineseFull(ImFontAtlas* self);
		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
		/// <summary>
		/// Default + about 400 Cyrillic characters<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesCyrillic", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesCyrillic(ImFontAtlas* self);
		/// <summary>
		/// Default + Thai characters<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesThai", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesThai(ImFontAtlas* self);
		/// <summary>
		/// Default + Vietnamese characters<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetGlyphRangesVietnamese", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort* ImFontAtlasGetGlyphRangesVietnamese(ImFontAtlas* self);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddCustomRectRegular", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImFontAtlasAddCustomRectRegular(ImFontAtlas* self, int width, int height);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_AddCustomRectFontGlyph", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImFontAtlasAddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advanceX, Vector2 offset);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_GetCustomRectByIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontAtlasCustomRect* ImFontAtlasGetCustomRectByIndex(ImFontAtlas* self, int index);
		[DllImport(LibraryName, EntryPoint = "ImFontAtlas_CalcCustomRectUV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasCalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* outUvMin, Vector2* outUvMax);
		[DllImport(LibraryName, EntryPoint = "ImFont_ImFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* ImFontImFont();
		[DllImport(LibraryName, EntryPoint = "ImFont_ImFont_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontImFontConstruct(ImFont* self);
		[DllImport(LibraryName, EntryPoint = "ImFont_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontDestroy(ImFont* self);
		[DllImport(LibraryName, EntryPoint = "ImFont_FindGlyph", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontGlyph* ImFontFindGlyph(ImFont* self, ushort c);
		[DllImport(LibraryName, EntryPoint = "ImFont_FindGlyphNoFallback", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontGlyph* ImFontFindGlyphNoFallback(ImFont* self, ushort c);
		[DllImport(LibraryName, EntryPoint = "ImFont_GetCharAdvance", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImFontGetCharAdvance(ImFont* self, ushort c);
		[DllImport(LibraryName, EntryPoint = "ImFont_IsLoaded", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontIsLoaded(ImFont* self);
		[DllImport(LibraryName, EntryPoint = "ImFont_GetDebugName", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImFontGetDebugName(ImFont* self);
		/// <summary>
		/// utf8<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFont_CalcTextSizeA", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontCalcTextSizeA(Vector2* pOut, ImFont* self, float size, float maxWidth, float wrapWidth, byte* textBegin, byte* textEnd, byte** remaining);
		[DllImport(LibraryName, EntryPoint = "ImFont_CalcWordWrapPositionA", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImFontCalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* textEnd, float wrapWidth);
		[DllImport(LibraryName, EntryPoint = "ImFont_RenderChar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontRenderChar(ImFont* self, ImDrawList* drawList, float size, Vector2 pos, uint col, ushort c);
		[DllImport(LibraryName, EntryPoint = "ImFont_RenderText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontRenderText(ImFont* self, ImDrawList* drawList, float size, Vector2 pos, uint col, Vector4 clipRect, byte* textBegin, byte* textEnd, float wrapWidth, byte cpuFineClip);
		[DllImport(LibraryName, EntryPoint = "ImFont_BuildLookupTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontBuildLookupTable(ImFont* self);
		[DllImport(LibraryName, EntryPoint = "ImFont_ClearOutputData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontClearOutputData(ImFont* self);
		[DllImport(LibraryName, EntryPoint = "ImFont_GrowIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontGrowIndex(ImFont* self, int newSize);
		[DllImport(LibraryName, EntryPoint = "ImFont_AddGlyph", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAddGlyph(ImFont* self, ImFontConfig* srcCfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX);
		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImFont_AddRemapChar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAddRemapChar(ImFont* self, ushort dst, ushort src, byte overwriteDst);
		[DllImport(LibraryName, EntryPoint = "ImFont_IsGlyphRangeUnused", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontIsGlyphRangeUnused(ImFont* self, uint cBegin, uint cLast);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewport_ImGuiViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewport* ImGuiViewportImGuiViewport();
		[DllImport(LibraryName, EntryPoint = "ImGuiViewport_ImGuiViewport_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportImGuiViewportConstruct(ImGuiViewport* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewport_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportDestroy(ImGuiViewport* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewport_GetCenter", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportGetCenter(Vector2* pOut, ImGuiViewport* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewport_GetWorkCenter", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportGetWorkCenter(Vector2* pOut, ImGuiViewport* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformIO_ImGuiPlatformIO", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPlatformIO* ImGuiPlatformIOImGuiPlatformIO();
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformIO_ImGuiPlatformIO_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformIOImGuiPlatformIOConstruct(ImGuiPlatformIO* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformIO_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformIODestroy(ImGuiPlatformIO* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformMonitor_ImGuiPlatformMonitor", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPlatformMonitor* ImGuiPlatformMonitorImGuiPlatformMonitor();
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformMonitor_ImGuiPlatformMonitor_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformMonitorImGuiPlatformMonitorConstruct(ImGuiPlatformMonitor* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformMonitor_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformMonitorDestroy(ImGuiPlatformMonitor* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformImeData_ImGuiPlatformImeData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPlatformImeData* ImGuiPlatformImeDataImGuiPlatformImeData();
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformImeData_ImGuiPlatformImeData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformImeDataImGuiPlatformImeDataConstruct(ImGuiPlatformImeData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformImeData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformImeDataDestroy(ImGuiPlatformImeData* self);
		[DllImport(LibraryName, EntryPoint = "igImHashData", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImHashData(void* data, uint dataSize, uint seed);
		[DllImport(LibraryName, EntryPoint = "igImHashStr", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImHashStr(byte* data, uint dataSize, uint seed);
		[DllImport(LibraryName, EntryPoint = "igImQsort", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImQsort(void* _base, uint count, uint sizeOfElement, IgImQsortCompareFunc compareFunc);
		[DllImport(LibraryName, EntryPoint = "igImAlphaBlendColors", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImAlphaBlendColors(uint colA, uint colB);
		[DllImport(LibraryName, EntryPoint = "igImIsPowerOfTwo_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImIsPowerOfTwo(int v);
		[DllImport(LibraryName, EntryPoint = "igImIsPowerOfTwo_U64", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImIsPowerOfTwo(ulong v);
		[DllImport(LibraryName, EntryPoint = "igImUpperPowerOfTwo", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImUpperPowerOfTwo(int v);
		[DllImport(LibraryName, EntryPoint = "igImCountSetBits", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImCountSetBits(uint v);
		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStricmp", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImStricmp(byte* str1, byte* str2);
		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrnicmp", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImStrnicmp(byte* str1, byte* str2, uint count);
		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrncpy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImStrncpy(byte* dst, byte* src, uint count);
		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrdup", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStrdup(byte* str);
		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrdupcpy", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStrdupcpy(byte* dst, uint* pDstSize, byte* str);
		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrchrRange", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStrchrRange(byte* strBegin, byte* strEnd, byte c);
		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStreolRange", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStreolRange(byte* str, byte* strEnd);
		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStristr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStristr(byte* haystack, byte* haystackEnd, byte* needle, byte* needleEnd);
		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrTrimBlanks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImStrTrimBlanks(byte* str);
		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrSkipBlank", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStrSkipBlank(byte* str);
		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrlenW", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImStrlenW(ushort* str);
		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImStrbol", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImStrbol(byte* bufMidLine, byte* bufBegin);
		[DllImport(LibraryName, EntryPoint = "igImToUpper", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImToUpper(byte c);
		[DllImport(LibraryName, EntryPoint = "igImCharIsBlankA", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImCharIsBlankA(byte c);
		[DllImport(LibraryName, EntryPoint = "igImCharIsBlankW", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImCharIsBlankW(uint c);
		[DllImport(LibraryName, EntryPoint = "igImCharIsXdigitA", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImCharIsXditA(byte c);
		[DllImport(LibraryName, EntryPoint = "igImFormatString", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImFormatString(byte* buf, uint bufSize, byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igImFormatStringToTempBuffer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFormatStringToTempBuffer(byte** outBuf, byte** outBufEnd, byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igImParseFormatFindStart", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImParseFormatFindStart(byte* format);
		[DllImport(LibraryName, EntryPoint = "igImParseFormatFindEnd", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImParseFormatFindEnd(byte* format);
		[DllImport(LibraryName, EntryPoint = "igImParseFormatTrimDecorations", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImParseFormatTrimDecorations(byte* format, byte* buf, uint bufSize);
		[DllImport(LibraryName, EntryPoint = "igImParseFormatSanitizeForPrinting", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImParseFormatSanitizeForPrinting(byte* fmtIn, byte* fmtOut, uint fmtOutSize);
		[DllImport(LibraryName, EntryPoint = "igImParseFormatSanitizeForScanning", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImParseFormatSanitizeForScanning(byte* fmtIn, byte* fmtOut, uint fmtOutSize);
		[DllImport(LibraryName, EntryPoint = "igImParseFormatPrecision", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImParseFormatPrecision(byte* format, int defaultValue);
		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextCharToUtf8", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImTextCharToUtf8(byte* outBuf, uint c);
		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextStrToUtf8", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextStrToUtf8(byte* outBuf, int outBufSize, ushort* inText, ushort* inTextEnd);
		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextCharFromUtf8", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextCharFromUtf8(uint* outChar, byte* inText, byte* inTextEnd);
		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextStrFromUtf8", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextStrFromUtf8(ushort* outBuf, int outBufSize, byte* inText, byte* inTextEnd, byte** inRemaining);
		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextCountCharsFromUtf8", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextCountCharsFromUtf8(byte* inText, byte* inTextEnd);
		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextCountUtf8BytesFromChar", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextCountUtf8BytesFromChar(byte* inText, byte* inTextEnd);
		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextCountUtf8BytesFromStr", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextCountUtf8BytesFromStr(ushort* inText, ushort* inTextEnd);
		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextFindPreviousUtf8Codepoint", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImTextFindPreviousUtf8Codepoint(byte* inTextStart, byte* inTextCurr);
		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImTextCountLines", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImTextCountLines(byte* inText, byte* inTextEnd);
		[DllImport(LibraryName, EntryPoint = "igImFileOpen", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImFileOpen(byte* filename, byte* mode);
		[DllImport(LibraryName, EntryPoint = "igImFileClose", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFileClose(void* file);
		[DllImport(LibraryName, EntryPoint = "igImFileGetSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImFileGetSize(void* file);
		[DllImport(LibraryName, EntryPoint = "igImFileRead", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImFileRead(void* data, ulong size, ulong count, void* file);
		[DllImport(LibraryName, EntryPoint = "igImFileWrite", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ImFileWrite(void* data, ulong size, ulong count, void* file);
		[DllImport(LibraryName, EntryPoint = "igImFileLoadToMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImFileLoadToMemory(byte* filename, byte* mode, uint* outFileSize, int paddingBytes);
		[DllImport(LibraryName, EntryPoint = "igImPow_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImPowFloat(float x, float y);
		[DllImport(LibraryName, EntryPoint = "igImPow_double", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImPowDouble(double x, double y);
		[DllImport(LibraryName, EntryPoint = "igImLog_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImLogFloat(float x);
		[DllImport(LibraryName, EntryPoint = "igImLog_double", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImLogDouble(double x);
		[DllImport(LibraryName, EntryPoint = "igImAbs_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImAbsInt(int x);
		[DllImport(LibraryName, EntryPoint = "igImAbs_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImAbsFloat(float x);
		[DllImport(LibraryName, EntryPoint = "igImAbs_double", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImAbsDouble(double x);
		[DllImport(LibraryName, EntryPoint = "igImSign_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImSnFloat(float x);
		[DllImport(LibraryName, EntryPoint = "igImSign_double", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImSnDouble(double x);
		[DllImport(LibraryName, EntryPoint = "igImRsqrt_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRsqrtFloat(float x);
		[DllImport(LibraryName, EntryPoint = "igImRsqrt_double", CallingConvention = CallingConvention.Cdecl)]
		public static extern double ImRsqrtDouble(double x);
		[DllImport(LibraryName, EntryPoint = "igImMin", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
		[DllImport(LibraryName, EntryPoint = "igImMax", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
		[DllImport(LibraryName, EntryPoint = "igImClamp", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
		[DllImport(LibraryName, EntryPoint = "igImLerp_Vec2Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImLerp(Vector2* pOut, Vector2 a, Vector2 b, float t);
		[DllImport(LibraryName, EntryPoint = "igImLerp_Vec2Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImLerp(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
		[DllImport(LibraryName, EntryPoint = "igImLerp_Vec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImLerp(Vector4* pOut, Vector4 a, Vector4 b, float t);
		[DllImport(LibraryName, EntryPoint = "igImSaturate", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImSaturate(float f);
		[DllImport(LibraryName, EntryPoint = "igImLengthSqr_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImLengthSqr(Vector2 lhs);
		[DllImport(LibraryName, EntryPoint = "igImLengthSqr_Vec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImLengthSqr(Vector4 lhs);
		[DllImport(LibraryName, EntryPoint = "igImInvLength", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImInvLength(Vector2 lhs, float failValue);
		[DllImport(LibraryName, EntryPoint = "igImTrunc_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImTruncFloat(float f);
		[DllImport(LibraryName, EntryPoint = "igImTrunc_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImTruncVec2(Vector2* pOut, Vector2 v);
		[DllImport(LibraryName, EntryPoint = "igImFloor_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImFloorFloat(float f);
		[DllImport(LibraryName, EntryPoint = "igImFloor_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFloorVec2(Vector2* pOut, Vector2 v);
		[DllImport(LibraryName, EntryPoint = "igImModPositive", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImModPositive(int a, int b);
		[DllImport(LibraryName, EntryPoint = "igImDot", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImDot(Vector2 a, Vector2 b);
		[DllImport(LibraryName, EntryPoint = "igImRotate", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRotate(Vector2* pOut, Vector2 v, float cosA, float sinA);
		[DllImport(LibraryName, EntryPoint = "igImLinearSweep", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImLinearSweep(float current, float target, float speed);
		[DllImport(LibraryName, EntryPoint = "igImLinearRemapClamp", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImLinearRemapClamp(float s0, float s1, float d0, float d1, float x);
		[DllImport(LibraryName, EntryPoint = "igImMul", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
		[DllImport(LibraryName, EntryPoint = "igImIsFloatAboveGuaranteedIntegerPrecision", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImIsFloatAboveGuaranteedIntegerPrecision(float f);
		[DllImport(LibraryName, EntryPoint = "igImExponentialMovingAverage", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImExponentialMovingAverage(float avg, float sample, int n);
		[DllImport(LibraryName, EntryPoint = "igImBezierCubicCalc", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImBezierCubicClosestPoint", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int numSegments);
		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igImBezierCubicClosestPointCasteljau", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tessTol);
		[DllImport(LibraryName, EntryPoint = "igImBezierQuadraticCalc", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);
		[DllImport(LibraryName, EntryPoint = "igImLineClosestPoint", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "igImTriangleContainsPoint", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "igImTriangleClosestPoint", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "igImTriangleBarycentricCoords", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* outU, float* outV, float* outW);
		[DllImport(LibraryName, EntryPoint = "igImTriangleArea", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
		[DllImport(LibraryName, EntryPoint = "igImTriangleIsClockwise", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c);
		[DllImport(LibraryName, EntryPoint = "ImVec1_ImVec1_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImVec1* ImVec1ImVec1();
		[DllImport(LibraryName, EntryPoint = "ImVec1_ImVec1_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec1ImVec1NilConstruct(ImVec1* self);
		[DllImport(LibraryName, EntryPoint = "ImVec1_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec1Destroy(ImVec1* self);
		[DllImport(LibraryName, EntryPoint = "ImVec1_ImVec1_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImVec1* ImVec1ImVec1(float x);
		[DllImport(LibraryName, EntryPoint = "ImVec1_ImVec1_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec1ImVec1FloatConstruct(ImVec1* self, float x);
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_ImVec2ih_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImVec2Ih* ImVec2IhImVec2Ih();
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_ImVec2ih_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2IhImVec2IhNilConstruct(ImVec2Ih* self);
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2IhDestroy(ImVec2Ih* self);
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_ImVec2ih_short", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImVec2Ih* ImVec2IhImVec2IhShort(short x, short y);
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_ImVec2ih_short_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2IhImVec2IhShortConstruct(ImVec2Ih* self, short x, short y);
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_ImVec2ih_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImVec2Ih* ImVec2IhImVec2Ih(Vector2 rhs);
		[DllImport(LibraryName, EntryPoint = "ImVec2ih_ImVec2ih_Vec2_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVec2IhImVec2IhVec2Construct(ImVec2Ih* self, Vector2 rhs);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImRect* ImRectImRect();
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Nil_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectImRectNilConstruct(ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectDestroy(ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImRect* ImRectImRect(Vector2 min, Vector2 max);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Vec2_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectImRectVec2Construct(ImRect* self, Vector2 min, Vector2 max);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Vec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImRect* ImRectImRect(Vector4 v);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Vec4_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectImRectVec4Construct(ImRect* self, Vector4 v);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImRect* ImRectImRect(float x1, float y1, float x2, float y2);
		[DllImport(LibraryName, EntryPoint = "ImRect_ImRect_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectImRectFloatConstruct(ImRect* self, float x1, float y1, float x2, float y2);
		[DllImport(LibraryName, EntryPoint = "ImRect_GetCenter", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectGetCenter(Vector2* pOut, ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_GetSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectGetSize(Vector2* pOut, ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_GetWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRectGetWidth(ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_GetHeight", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRectGetHeht(ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_GetArea", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImRectGetArea(ImRect* self);
		/// <summary>
		/// Top-left<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImRect_GetTL", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectGetTL(Vector2* pOut, ImRect* self);
		/// <summary>
		/// Top-right<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImRect_GetTR", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectGetTR(Vector2* pOut, ImRect* self);
		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImRect_GetBL", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectGetBL(Vector2* pOut, ImRect* self);
		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImRect_GetBR", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectGetBR(Vector2* pOut, ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_Contains_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRectContainsVec2(ImRect* self, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "ImRect_Contains_Rect", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRectContainsRect(ImRect* self, ImRect r);
		[DllImport(LibraryName, EntryPoint = "ImRect_ContainsWithPad", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRectContainsWithPad(ImRect* self, Vector2 p, Vector2 pad);
		[DllImport(LibraryName, EntryPoint = "ImRect_Overlaps", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRectOverlaps(ImRect* self, ImRect r);
		[DllImport(LibraryName, EntryPoint = "ImRect_Add_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectAddVec2(ImRect* self, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "ImRect_Add_Rect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectAddRect(ImRect* self, ImRect r);
		[DllImport(LibraryName, EntryPoint = "ImRect_Expand_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectExpand(ImRect* self, float amount);
		[DllImport(LibraryName, EntryPoint = "ImRect_Expand_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectExpand(ImRect* self, Vector2 amount);
		[DllImport(LibraryName, EntryPoint = "ImRect_Translate", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectTranslate(ImRect* self, Vector2 d);
		[DllImport(LibraryName, EntryPoint = "ImRect_TranslateX", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectTranslateX(ImRect* self, float dx);
		[DllImport(LibraryName, EntryPoint = "ImRect_TranslateY", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectTranslateY(ImRect* self, float dy);
		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImRect_ClipWith", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectClipWith(ImRect* self, ImRect r);
		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImRect_ClipWithFull", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectClipWithFull(ImRect* self, ImRect r);
		[DllImport(LibraryName, EntryPoint = "ImRect_Floor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectFloor(ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_IsInverted", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImRectIsInverted(ImRect* self);
		[DllImport(LibraryName, EntryPoint = "ImRect_ToVec4", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImRectToVec4(Vector4* pOut, ImRect* self);
		[DllImport(LibraryName, EntryPoint = "igImBitArrayGetStorageSizeInBytes", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImBitArrayGetStorageSizeInBytes(int bitcount);
		[DllImport(LibraryName, EntryPoint = "igImBitArrayClearAllBits", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArrayClearAllBits(uint* arr, int bitcount);
		[DllImport(LibraryName, EntryPoint = "igImBitArrayTestBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImBitArrayTestBit(uint* arr, int n);
		[DllImport(LibraryName, EntryPoint = "igImBitArrayClearBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArrayClearBit(uint* arr, int n);
		[DllImport(LibraryName, EntryPoint = "igImBitArraySetBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArraySetBit(uint* arr, int n);
		[DllImport(LibraryName, EntryPoint = "igImBitArraySetBitRange", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitArraySetBitRange(uint* arr, int n, int n2);
		[DllImport(LibraryName, EntryPoint = "ImBitVector_Create", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVectorCreate(ImBitVector* self, int sz);
		[DllImport(LibraryName, EntryPoint = "ImBitVector_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVectorClear(ImBitVector* self);
		[DllImport(LibraryName, EntryPoint = "ImBitVector_TestBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImBitVectorTestBit(ImBitVector* self, int n);
		[DllImport(LibraryName, EntryPoint = "ImBitVector_SetBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVectorSetBit(ImBitVector* self, int n);
		[DllImport(LibraryName, EntryPoint = "ImBitVector_ClearBit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImBitVectorClearBit(ImBitVector* self, int n);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextIndex_clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextIndexClear(ImGuiTextIndex* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextIndex_size", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiTextIndexSize(ImGuiTextIndex* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextIndex_get_line_begin", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextIndexGetLineBegin(ImGuiTextIndex* self, byte* _base, int n);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextIndex_get_line_end", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiTextIndexGetLineEnd(ImGuiTextIndex* self, byte* _base, int n);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextIndex_append", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextIndexAppend(ImGuiTextIndex* self, byte* _base, int oldSize, int newSize);
		[DllImport(LibraryName, EntryPoint = "igImLowerBound", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStoragePair* ImLowerBound(ImGuiStoragePair* inBegin, ImGuiStoragePair* inEnd, uint key);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSharedData_ImDrawListSharedData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawListSharedData* ImDrawListSharedDataImDrawListSharedData();
		[DllImport(LibraryName, EntryPoint = "ImDrawListSharedData_ImDrawListSharedData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSharedDataImDrawListSharedDataConstruct(ImDrawListSharedData* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSharedData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSharedDataDestroy(ImDrawListSharedData* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawListSharedData_SetCircleTessellationMaxError", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawListSharedDataSetCircleTessellationMaxError(ImDrawListSharedData* self, float maxError);
		[DllImport(LibraryName, EntryPoint = "ImDrawDataBuilder_ImDrawDataBuilder", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawDataBuilder* ImDrawDataBuilderImDrawDataBuilder();
		[DllImport(LibraryName, EntryPoint = "ImDrawDataBuilder_ImDrawDataBuilder_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataBuilderImDrawDataBuilderConstruct(ImDrawDataBuilder* self);
		[DllImport(LibraryName, EntryPoint = "ImDrawDataBuilder_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImDrawDataBuilderDestroy(ImDrawDataBuilder* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleVarInfo_GetVarPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void* ImGuiStyleVarInfoGetVarPtr(ImGuiStyleVarInfo* self, void* parent);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_ImGuiStyleMod_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyleMod* ImGuiStyleModImGuiStyleMod(ImGuiStyleVar idx, int v);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_ImGuiStyleMod_Int_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleModImGuiStyleModIntConstruct(ImGuiStyleMod* self, ImGuiStyleVar idx, int v);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleModDestroy(ImGuiStyleMod* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_ImGuiStyleMod_Float", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyleMod* ImGuiStyleModImGuiStyleMod(ImGuiStyleVar idx, float v);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_ImGuiStyleMod_Float_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleModImGuiStyleModFloatConstruct(ImGuiStyleMod* self, ImGuiStyleVar idx, float v);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_ImGuiStyleMod_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyleMod* ImGuiStyleModImGuiStyleMod(ImGuiStyleVar idx, Vector2 v);
		[DllImport(LibraryName, EntryPoint = "ImGuiStyleMod_ImGuiStyleMod_Vec2_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStyleModImGuiStyleModVec2Construct(ImGuiStyleMod* self, ImGuiStyleVar idx, Vector2 v);
		[DllImport(LibraryName, EntryPoint = "ImGuiComboPreviewData_ImGuiComboPreviewData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiComboPreviewData* ImGuiComboPreviewDataImGuiComboPreviewData();
		[DllImport(LibraryName, EntryPoint = "ImGuiComboPreviewData_ImGuiComboPreviewData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiComboPreviewDataImGuiComboPreviewDataConstruct(ImGuiComboPreviewData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiComboPreviewData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiComboPreviewDataDestroy(ImGuiComboPreviewData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMenuColumns_ImGuiMenuColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMenuColumns* ImGuiMenuColumnsImGuiMenuColumns();
		[DllImport(LibraryName, EntryPoint = "ImGuiMenuColumns_ImGuiMenuColumns_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumnsImGuiMenuColumnsConstruct(ImGuiMenuColumns* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMenuColumns_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumnsDestroy(ImGuiMenuColumns* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMenuColumns_Update", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumnsUpdate(ImGuiMenuColumns* self, float spacing, byte windowReappearing);
		[DllImport(LibraryName, EntryPoint = "ImGuiMenuColumns_DeclColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiMenuColumnsDeclColumns(ImGuiMenuColumns* self, float wIcon, float wLabel, float wShortcut, float wMark);
		[DllImport(LibraryName, EntryPoint = "ImGuiMenuColumns_CalcNextTotalWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMenuColumnsCalcNextTotalWidth(ImGuiMenuColumns* self, byte updateOffsets);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiInputTextDeactivatedState* ImGuiInputTextDeactivatedStateImGuiInputTextDeactivatedState();
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextDeactivatedStateImGuiInputTextDeactivatedStateConstruct(ImGuiInputTextDeactivatedState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextDeactivatedState_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextDeactivatedStateDestroy(ImGuiInputTextDeactivatedState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextDeactivatedState_ClearFreeMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextDeactivatedStateClearFreeMemory(ImGuiInputTextDeactivatedState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ImGuiInputTextState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiInputTextState* ImGuiInputTextStateImGuiInputTextState();
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ImGuiInputTextState_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateImGuiInputTextStateConstruct(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateDestroy(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ClearText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateClearText(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ClearFreeMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateClearFreeMemory(ImGuiInputTextState* self);
		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_OnKeyPressed", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateOnKeyPressed(ImGuiInputTextState* self, int key);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_OnCharPressed", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateOnCharPressed(ImGuiInputTextState* self, uint c);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_CursorAnimReset", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateCursorAnimReset(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_CursorClamp", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateCursorClamp(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_HasSelection", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiInputTextStateHasSelection(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ClearSelection", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateClearSelection(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_GetCursorPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextStateGetCursorPos(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_GetSelectionStart", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextStateGetSelectionStart(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_GetSelectionEnd", CallingConvention = CallingConvention.Cdecl)]
		public static extern int ImGuiInputTextStateGetSelectionEnd(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_SelectAll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateSelectAll(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ReloadUserBufAndSelectAll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateReloadUserBufAndSelectAll(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ReloadUserBufAndKeepSelection", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateReloadUserBufAndKeepSelection(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputTextState_ReloadUserBufAndMoveToEnd", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputTextStateReloadUserBufAndMoveToEnd(ImGuiInputTextState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNextWindowData_ImGuiNextWindowData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiNextWindowData* ImGuiNextWindowDataImGuiNextWindowData();
		[DllImport(LibraryName, EntryPoint = "ImGuiNextWindowData_ImGuiNextWindowData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextWindowDataImGuiNextWindowDataConstruct(ImGuiNextWindowData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNextWindowData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextWindowDataDestroy(ImGuiNextWindowData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNextWindowData_ClearFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextWindowDataClearFlags(ImGuiNextWindowData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNextItemData_ImGuiNextItemData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiNextItemData* ImGuiNextItemDataImGuiNextItemData();
		[DllImport(LibraryName, EntryPoint = "ImGuiNextItemData_ImGuiNextItemData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextItemDataImGuiNextItemDataConstruct(ImGuiNextItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNextItemData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextItemDataDestroy(ImGuiNextItemData* self);
		/// <summary>
		/// Also cleared manually by ItemAdd()!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiNextItemData_ClearFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNextItemDataClearFlags(ImGuiNextItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiLastItemData_ImGuiLastItemData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiLastItemData* ImGuiLastItemDataImGuiLastItemData();
		[DllImport(LibraryName, EntryPoint = "ImGuiLastItemData_ImGuiLastItemData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiLastItemDataImGuiLastItemDataConstruct(ImGuiLastItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiLastItemData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiLastItemDataDestroy(ImGuiLastItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiErrorRecoveryState_ImGuiErrorRecoveryState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiErrorRecoveryState* ImGuiErrorRecoveryStateImGuiErrorRecoveryState();
		[DllImport(LibraryName, EntryPoint = "ImGuiErrorRecoveryState_ImGuiErrorRecoveryState_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiErrorRecoveryStateImGuiErrorRecoveryStateConstruct(ImGuiErrorRecoveryState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiErrorRecoveryState_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiErrorRecoveryStateDestroy(ImGuiErrorRecoveryState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndexImGuiPtrOrIndex(void* ptr);
		[DllImport(LibraryName, EntryPoint = "ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPtrOrIndexImGuiPtrOrIndexPtrConstruct(ImGuiPtrOrIndex* self, void* ptr);
		[DllImport(LibraryName, EntryPoint = "ImGuiPtrOrIndex_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPtrOrIndexDestroy(ImGuiPtrOrIndex* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndexImGuiPtrOrIndex(int index);
		[DllImport(LibraryName, EntryPoint = "ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPtrOrIndexImGuiPtrOrIndexIntConstruct(ImGuiPtrOrIndex* self, int index);
		[DllImport(LibraryName, EntryPoint = "ImGuiPopupData_ImGuiPopupData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPopupData* ImGuiPopupDataImGuiPopupData();
		[DllImport(LibraryName, EntryPoint = "ImGuiPopupData_ImGuiPopupData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPopupDataImGuiPopupDataConstruct(ImGuiPopupData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiPopupData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPopupDataDestroy(ImGuiPopupData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputEvent_ImGuiInputEvent", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiInputEvent* ImGuiInputEventImGuiInputEvent();
		[DllImport(LibraryName, EntryPoint = "ImGuiInputEvent_ImGuiInputEvent_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputEventImGuiInputEventConstruct(ImGuiInputEvent* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiInputEvent_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiInputEventDestroy(ImGuiInputEvent* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingData_ImGuiKeyRoutingData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyRoutingData* ImGuiKeyRoutingDataImGuiKeyRoutingData();
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingData_ImGuiKeyRoutingData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyRoutingDataImGuiKeyRoutingDataConstruct(ImGuiKeyRoutingData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyRoutingDataDestroy(ImGuiKeyRoutingData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingTable_ImGuiKeyRoutingTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyRoutingTable* ImGuiKeyRoutingTableImGuiKeyRoutingTable();
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingTable_ImGuiKeyRoutingTable_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyRoutingTableImGuiKeyRoutingTableConstruct(ImGuiKeyRoutingTable* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingTable_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyRoutingTableDestroy(ImGuiKeyRoutingTable* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyRoutingTable_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyRoutingTableClear(ImGuiKeyRoutingTable* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyOwnerData_ImGuiKeyOwnerData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyOwnerData* ImGuiKeyOwnerDataImGuiKeyOwnerData();
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyOwnerData_ImGuiKeyOwnerData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyOwnerDataImGuiKeyOwnerDataConstruct(ImGuiKeyOwnerData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiKeyOwnerData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiKeyOwnerDataDestroy(ImGuiKeyOwnerData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipperRange_FromIndices", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiListClipperRange ImGuiListClipperRangeFromIndices(int min, int max);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipperRange_FromPositions", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiListClipperRange ImGuiListClipperRangeFromPositions(float y1, float y2, int offMin, int offMax);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipperData_ImGuiListClipperData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiListClipperData* ImGuiListClipperDataImGuiListClipperData();
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipperData_ImGuiListClipperData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperDataImGuiListClipperDataConstruct(ImGuiListClipperData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipperData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperDataDestroy(ImGuiListClipperData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiListClipperData_Reset", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiListClipperDataReset(ImGuiListClipperData* self, ImGuiListClipper* clipper);
		[DllImport(LibraryName, EntryPoint = "ImGuiNavItemData_ImGuiNavItemData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiNavItemData* ImGuiNavItemDataImGuiNavItemData();
		[DllImport(LibraryName, EntryPoint = "ImGuiNavItemData_ImGuiNavItemData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNavItemDataImGuiNavItemDataConstruct(ImGuiNavItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNavItemData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNavItemDataDestroy(ImGuiNavItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiNavItemData_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiNavItemDataClear(ImGuiNavItemData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTypingSelectState_ImGuiTypingSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTypingSelectState* ImGuiTypingSelectStateImGuiTypingSelectState();
		[DllImport(LibraryName, EntryPoint = "ImGuiTypingSelectState_ImGuiTypingSelectState_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTypingSelectStateImGuiTypingSelectStateConstruct(ImGuiTypingSelectState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTypingSelectState_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTypingSelectStateDestroy(ImGuiTypingSelectState* self);
		/// <summary>
		/// We preserve remaining data for easier debugging<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiTypingSelectState_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTypingSelectStateClear(ImGuiTypingSelectState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiOldColumnData_ImGuiOldColumnData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiOldColumnData* ImGuiOldColumnDataImGuiOldColumnData();
		[DllImport(LibraryName, EntryPoint = "ImGuiOldColumnData_ImGuiOldColumnData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumnDataImGuiOldColumnDataConstruct(ImGuiOldColumnData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiOldColumnData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumnDataDestroy(ImGuiOldColumnData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiOldColumns_ImGuiOldColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiOldColumns* ImGuiOldColumnsImGuiOldColumns();
		[DllImport(LibraryName, EntryPoint = "ImGuiOldColumns_ImGuiOldColumns_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumnsImGuiOldColumnsConstruct(ImGuiOldColumns* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiOldColumns_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiOldColumnsDestroy(ImGuiOldColumns* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiBoxSelectState_ImGuiBoxSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiBoxSelectState* ImGuiBoxSelectStateImGuiBoxSelectState();
		[DllImport(LibraryName, EntryPoint = "ImGuiBoxSelectState_ImGuiBoxSelectState_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiBoxSelectStateImGuiBoxSelectStateConstruct(ImGuiBoxSelectState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiBoxSelectState_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiBoxSelectStateDestroy(ImGuiBoxSelectState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectTempData_ImGuiMultiSelectTempData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMultiSelectTempData* ImGuiMultiSelectTempDataImGuiMultiSelectTempData();
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectTempData_ImGuiMultiSelectTempData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMultiSelectTempDataImGuiMultiSelectTempDataConstruct(ImGuiMultiSelectTempData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectTempData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMultiSelectTempDataDestroy(ImGuiMultiSelectTempData* self);
		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectTempData_Clear", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMultiSelectTempDataClear(ImGuiMultiSelectTempData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectTempData_ClearIO", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMultiSelectTempDataClearIO(ImGuiMultiSelectTempData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectState_ImGuiMultiSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMultiSelectState* ImGuiMultiSelectStateImGuiMultiSelectState();
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectState_ImGuiMultiSelectState_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMultiSelectStateImGuiMultiSelectStateConstruct(ImGuiMultiSelectState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiMultiSelectState_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiMultiSelectStateDestroy(ImGuiMultiSelectState* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_ImGuiDockNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockNode* ImGuiDockNodeImGuiDockNode(uint id);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_ImGuiDockNode_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockNodeImGuiDockNodeConstruct(ImGuiDockNode* self, uint id);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockNodeDestroy(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsRootNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsRootNode(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsDockSpace", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsDockSpace(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsFloatingNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsFloatingNode(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsCentralNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsCentralNode(ImGuiDockNode* self);
		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsHiddenTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsHiddenTabBar(ImGuiDockNode* self);
		/// <summary>
		/// Never show a tab bar<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsNoTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsNoTabBar(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsSplitNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsSplitNode(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsLeafNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsLeafNode(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_IsEmpty", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImGuiDockNodeIsEmpty(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_Rect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockNodeRect(ImRect* pOut, ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_SetLocalFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockNodeSetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockNode_UpdateMergedFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockNodeUpdateMergedFlags(ImGuiDockNode* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockContext_ImGuiDockContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockContext* ImGuiDockContextImGuiDockContext();
		[DllImport(LibraryName, EntryPoint = "ImGuiDockContext_ImGuiDockContext_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockContextImGuiDockContextConstruct(ImGuiDockContext* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDockContext_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDockContextDestroy(ImGuiDockContext* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_ImGuiViewportP", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewportP* ImGuiViewportPImGuiViewportP();
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_ImGuiViewportP_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPImGuiViewportPConstruct(ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPDestroy(ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_ClearRequestFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPClearRequestFlags(ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_CalcWorkRectPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPCalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 insetMin);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_CalcWorkRectSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPCalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 insetMin, Vector2 insetMax);
		/// <summary>
		/// Update public fields<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_UpdateWorkRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPUpdateWorkRect(ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_GetMainRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPGetMainRect(ImRect* pOut, ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_GetWorkRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPGetWorkRect(ImRect* pOut, ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiViewportP_GetBuildWorkRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiViewportPGetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowSettings_ImGuiWindowSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* ImGuiWindowSettingsImGuiWindowSettings();
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowSettings_ImGuiWindowSettings_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowSettingsImGuiWindowSettingsConstruct(ImGuiWindowSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowSettings_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowSettingsDestroy(ImGuiWindowSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindowSettings_GetName", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* ImGuiWindowSettingsGetName(ImGuiWindowSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiSettingsHandler_ImGuiSettingsHandler", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSettingsHandler* ImGuiSettingsHandlerImGuiSettingsHandler();
		[DllImport(LibraryName, EntryPoint = "ImGuiSettingsHandler_ImGuiSettingsHandler_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSettingsHandlerImGuiSettingsHandlerConstruct(ImGuiSettingsHandler* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiSettingsHandler_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiSettingsHandlerDestroy(ImGuiSettingsHandler* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDebugAllocInfo_ImGuiDebugAllocInfo", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDebugAllocInfo* ImGuiDebugAllocInfoImGuiDebugAllocInfo();
		[DllImport(LibraryName, EntryPoint = "ImGuiDebugAllocInfo_ImGuiDebugAllocInfo_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDebugAllocInfoImGuiDebugAllocInfoConstruct(ImGuiDebugAllocInfo* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiDebugAllocInfo_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiDebugAllocInfoDestroy(ImGuiDebugAllocInfo* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStackLevelInfo_ImGuiStackLevelInfo", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStackLevelInfo* ImGuiStackLevelInfoImGuiStackLevelInfo();
		[DllImport(LibraryName, EntryPoint = "ImGuiStackLevelInfo_ImGuiStackLevelInfo_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackLevelInfoImGuiStackLevelInfoConstruct(ImGuiStackLevelInfo* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiStackLevelInfo_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiStackLevelInfoDestroy(ImGuiStackLevelInfo* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiIDStackTool_ImGuiIDStackTool", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiIdStackTool* ImGuiIdStackToolImGuiIdStackTool();
		[DllImport(LibraryName, EntryPoint = "ImGuiIDStackTool_ImGuiIDStackTool_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIdStackToolImGuiIdStackToolConstruct(ImGuiIdStackTool* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiIDStackTool_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiIdStackToolDestroy(ImGuiIdStackTool* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiContextHook_ImGuiContextHook", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiContextHook* ImGuiContextHookImGuiContextHook();
		[DllImport(LibraryName, EntryPoint = "ImGuiContextHook_ImGuiContextHook_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContextHookImGuiContextHookConstruct(ImGuiContextHook* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiContextHook_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContextHookDestroy(ImGuiContextHook* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiContext_ImGuiContext", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiContext* ImGuiContextImGuiContext(ImFontAtlas* sharedFontAtlas);
		[DllImport(LibraryName, EntryPoint = "ImGuiContext_ImGuiContext_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContextImGuiContextConstruct(ImGuiContext* self, ImFontAtlas* sharedFontAtlas);
		[DllImport(LibraryName, EntryPoint = "ImGuiContext_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiContextDestroy(ImGuiContext* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_ImGuiWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* ImGuiWindowImGuiWindow(ImGuiContext* context, byte* name);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_ImGuiWindow_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowImGuiWindowConstruct(ImGuiWindow* self, ImGuiContext* context, byte* name);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowDestroy(ImGuiWindow* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_GetID_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuiWindowGetID(ImGuiWindow* self, byte* str, byte* strEnd);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_GetID_Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuiWindowGetID(ImGuiWindow* self, void* ptr);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_GetID_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuiWindowGetID(ImGuiWindow* self, int n);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_GetIDFromPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuiWindowGetIdFromPos(ImGuiWindow* self, Vector2 pAbs);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_GetIDFromRectangle", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint ImGuiWindowGetIdFromRectangle(ImGuiWindow* self, ImRect rAbs);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_Rect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowRect(ImRect* pOut, ImGuiWindow* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_CalcFontSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern float ImGuiWindowCalcFontSize(ImGuiWindow* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_TitleBarRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowTitleBarRect(ImRect* pOut, ImGuiWindow* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiWindow_MenuBarRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiWindowMenuBarRect(ImRect* pOut, ImGuiWindow* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTabItem_ImGuiTabItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabItem* ImGuiTabItemImGuiTabItem();
		[DllImport(LibraryName, EntryPoint = "ImGuiTabItem_ImGuiTabItem_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabItemImGuiTabItemConstruct(ImGuiTabItem* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTabItem_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabItemDestroy(ImGuiTabItem* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTabBar_ImGuiTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabBar* ImGuiTabBarImGuiTabBar();
		[DllImport(LibraryName, EntryPoint = "ImGuiTabBar_ImGuiTabBar_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabBarImGuiTabBarConstruct(ImGuiTabBar* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTabBar_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTabBarDestroy(ImGuiTabBar* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumn_ImGuiTableColumn", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumn* ImGuiTableColumnImGuiTableColumn();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumn_ImGuiTableColumn_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnImGuiTableColumnConstruct(ImGuiTableColumn* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumn_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnDestroy(ImGuiTableColumn* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableInstanceData_ImGuiTableInstanceData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableInstanceData* ImGuiTableInstanceDataImGuiTableInstanceData();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableInstanceData_ImGuiTableInstanceData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableInstanceDataImGuiTableInstanceDataConstruct(ImGuiTableInstanceData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableInstanceData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableInstanceDataDestroy(ImGuiTableInstanceData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTable_ImGuiTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTable* ImGuiTableImGuiTable();
		[DllImport(LibraryName, EntryPoint = "ImGuiTable_ImGuiTable_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableImGuiTableConstruct(ImGuiTable* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTable_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableDestroy(ImGuiTable* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableTempData_ImGuiTableTempData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableTempData* ImGuiTableTempDataImGuiTableTempData();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableTempData_ImGuiTableTempData_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableTempDataImGuiTableTempDataConstruct(ImGuiTableTempData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableTempData_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableTempDataDestroy(ImGuiTableTempData* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumnSettings_ImGuiTableColumnSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumnSettings* ImGuiTableColumnSettingsImGuiTableColumnSettings();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumnSettings_ImGuiTableColumnSettings_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSettingsImGuiTableColumnSettingsConstruct(ImGuiTableColumnSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableColumnSettings_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableColumnSettingsDestroy(ImGuiTableColumnSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSettings_ImGuiTableSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* ImGuiTableSettingsImGuiTableSettings();
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSettings_ImGuiTableSettings_Construct", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSettingsImGuiTableSettingsConstruct(ImGuiTableSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSettings_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTableSettingsDestroy(ImGuiTableSettings* self);
		[DllImport(LibraryName, EntryPoint = "ImGuiTableSettings_GetColumnSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableColumnSettings* ImGuiTableSettingsGetColumnSettings(ImGuiTableSettings* self);
		[DllImport(LibraryName, EntryPoint = "igGetIOEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiIO* GetIoEx(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igGetPlatformIO_ContextPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPlatformIO* GetPlatformIO(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igGetCurrentWindowRead", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* GetCurrentWindowRead();
		[DllImport(LibraryName, EntryPoint = "igGetCurrentWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* GetCurrentWindow();
		[DllImport(LibraryName, EntryPoint = "igFindWindowByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* FindWindowByID(uint id);
		[DllImport(LibraryName, EntryPoint = "igFindWindowByName", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* FindWindowByName(byte* name);
		[DllImport(LibraryName, EntryPoint = "igUpdateWindowParentAndRootLinks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parentWindow);
		[DllImport(LibraryName, EntryPoint = "igUpdateWindowSkipRefresh", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateWindowSkipRefresh(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igCalcWindowNextAutoFitSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igIsWindowChildOf", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potentialParent, byte popupHierarchy, byte dockHierarchy);
		[DllImport(LibraryName, EntryPoint = "igIsWindowWithinBeginStackOf", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potentialParent);
		[DllImport(LibraryName, EntryPoint = "igIsWindowAbove", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowAbove(ImGuiWindow* potentialAbove, ImGuiWindow* potentialBelow);
		[DllImport(LibraryName, EntryPoint = "igIsWindowNavFocusable", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowNavFocusable(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igSetWindowPos_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowPos(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowSize_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowSize(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowCollapsed_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowCollapsed(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igSetWindowHitTestHole", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
		[DllImport(LibraryName, EntryPoint = "igSetWindowHiddenAndSkipItemsForCurrentFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);
		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetWindowParentWindowForFocusRoute", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parentWindow);
		[DllImport(LibraryName, EntryPoint = "igWindowRectAbsToRel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r);
		[DllImport(LibraryName, EntryPoint = "igWindowRectRelToAbs", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r);
		[DllImport(LibraryName, EntryPoint = "igWindowPosAbsToRel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WindowPosAbsToRel(Vector2* pOut, ImGuiWindow* window, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "igWindowPosRelToAbs", CallingConvention = CallingConvention.Cdecl)]
		public static extern void WindowPosRelToAbs(Vector2* pOut, ImGuiWindow* window, Vector2 p);
		[DllImport(LibraryName, EntryPoint = "igFocusWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void FocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags);
		[DllImport(LibraryName, EntryPoint = "igFocusTopMostWindowUnderOne", CallingConvention = CallingConvention.Cdecl)]
		public static extern void FocusTopMostWindowUnderOne(ImGuiWindow* underThisWindow, ImGuiWindow* ignoreWindow, ImGuiViewport* filterViewport, ImGuiFocusRequestFlags flags);
		[DllImport(LibraryName, EntryPoint = "igBringWindowToFocusFront", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BringWindowToFocusFront(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igBringWindowToDisplayFront", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BringWindowToDisplayFront(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igBringWindowToDisplayBack", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BringWindowToDisplayBack(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igBringWindowToDisplayBehind", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* aboveWindow);
		[DllImport(LibraryName, EntryPoint = "igFindWindowDisplayIndex", CallingConvention = CallingConvention.Cdecl)]
		public static extern int FindWindowDisplayIndex(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igFindBottomMostVisibleWindowWithinBeginStack", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igSetNextWindowRefreshPolicy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSetCurrentFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCurrentFont(ImFont* font);
		[DllImport(LibraryName, EntryPoint = "igGetDefaultFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFont* GetDefaultFont();
		[DllImport(LibraryName, EntryPoint = "igPushPasswordFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushPasswordFont();
		[DllImport(LibraryName, EntryPoint = "igGetForegroundDrawList_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawList* GetForegroundDrawList(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igAddDrawListToDrawDataEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void AddDrawListToDrawDataEx(ImDrawData* drawData, ImVector<ImDrawListPtr>* outList, ImDrawList* drawList);
		[DllImport(LibraryName, EntryPoint = "igInitialize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Initialize();
		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igShutdown", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Shutdown();
		[DllImport(LibraryName, EntryPoint = "igUpdateInputEvents", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateInputEvents(byte trickleFastInputs);
		[DllImport(LibraryName, EntryPoint = "igUpdateHoveredWindowAndCaptureFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateHoveredWindowAndCaptureFlags();
		[DllImport(LibraryName, EntryPoint = "igFindHoveredWindowEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void FindHoveredWindowEx(Vector2 pos, byte findFirstAndInAnyViewport, ImGuiWindow** outHoveredWindow, ImGuiWindow** outHoveredWindowUnderMovingWindow);
		[DllImport(LibraryName, EntryPoint = "igStartMouseMovingWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void StartMouseMovingWindow(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igStartMouseMovingWindowOrNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void StartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock);
		[DllImport(LibraryName, EntryPoint = "igUpdateMouseMovingWindowNewFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateMouseMovingWindowNewFrame();
		[DllImport(LibraryName, EntryPoint = "igUpdateMouseMovingWindowEndFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void UpdateMouseMovingWindowEndFrame();
		[DllImport(LibraryName, EntryPoint = "igAddContextHook", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint AddContextHook(ImGuiContext* context, ImGuiContextHook* hook);
		[DllImport(LibraryName, EntryPoint = "igRemoveContextHook", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RemoveContextHook(ImGuiContext* context, uint hookToRemove);
		[DllImport(LibraryName, EntryPoint = "igCallContextHooks", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CallContextHooks(ImGuiContext* context, ImGuiContextHookType type);
		[DllImport(LibraryName, EntryPoint = "igTranslateWindowsInViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 oldPos, Vector2 newPos, Vector2 oldSize, Vector2 newSize);
		[DllImport(LibraryName, EntryPoint = "igScaleWindowsInViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
		[DllImport(LibraryName, EntryPoint = "igDestroyPlatformWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DestroyPlatformWindow(ImGuiViewportP* viewport);
		[DllImport(LibraryName, EntryPoint = "igSetWindowViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		[DllImport(LibraryName, EntryPoint = "igSetCurrentViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		[DllImport(LibraryName, EntryPoint = "igGetViewportPlatformMonitor", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiPlatformMonitor* GetViewportPlatformMonitor(ImGuiViewport* viewport);
		[DllImport(LibraryName, EntryPoint = "igFindHoveredViewportFromPlatformWindowStack", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiViewportP* FindHoveredViewportFromPlatformWindowStack(Vector2 mousePlatformPos);
		[DllImport(LibraryName, EntryPoint = "igMarkIniSettingsDirty_Nil", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MarkIniSettingsDirty();
		[DllImport(LibraryName, EntryPoint = "igMarkIniSettingsDirty_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MarkIniSettingsDirty(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igClearIniSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClearIniSettings();
		[DllImport(LibraryName, EntryPoint = "igAddSettingsHandler", CallingConvention = CallingConvention.Cdecl)]
		public static extern void AddSettingsHandler(ImGuiSettingsHandler* handler);
		[DllImport(LibraryName, EntryPoint = "igRemoveSettingsHandler", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RemoveSettingsHandler(byte* typeName);
		[DllImport(LibraryName, EntryPoint = "igFindSettingsHandler", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSettingsHandler* FindSettingsHandler(byte* typeName);
		[DllImport(LibraryName, EntryPoint = "igCreateNewWindowSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* CreateNewWindowSettings(byte* name);
		[DllImport(LibraryName, EntryPoint = "igFindWindowSettingsByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* FindWindowSettingsByID(uint id);
		[DllImport(LibraryName, EntryPoint = "igFindWindowSettingsByWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindowSettings* FindWindowSettingsByWindow(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igClearWindowSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClearWindowSettings(byte* name);
		[DllImport(LibraryName, EntryPoint = "igLocalizeRegisterEntries", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LocalizeRegisterEntries(ImGuiLocEntry* entries, int count);
		[DllImport(LibraryName, EntryPoint = "igLocalizeGetMsg", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* LocalizeGetMsg(ImGuiLocKey key);
		[DllImport(LibraryName, EntryPoint = "igSetScrollX_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollX(ImGuiWindow* window, float scrollX);
		[DllImport(LibraryName, EntryPoint = "igSetScrollY_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollY(ImGuiWindow* window, float scrollY);
		[DllImport(LibraryName, EntryPoint = "igSetScrollFromPosX_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollFromPosX(ImGuiWindow* window, float localX, float centerXRatio);
		[DllImport(LibraryName, EntryPoint = "igSetScrollFromPosY_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetScrollFromPosY(ImGuiWindow* window, float localY, float centerYRatio);
		[DllImport(LibraryName, EntryPoint = "igScrollToItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ScrollToItem(ImGuiScrollFlags flags);
		[DllImport(LibraryName, EntryPoint = "igScrollToRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
		[DllImport(LibraryName, EntryPoint = "igScrollToRectEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
		[DllImport(LibraryName, EntryPoint = "igScrollToBringRectIntoView", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);
		[DllImport(LibraryName, EntryPoint = "igGetItemStatusFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiItemStatusFlags GetItemStatusFlags();
		[DllImport(LibraryName, EntryPoint = "igGetItemFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiItemFlags GetItemFlags();
		[DllImport(LibraryName, EntryPoint = "igGetActiveID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetActiveID();
		[DllImport(LibraryName, EntryPoint = "igGetFocusID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetFocusID();
		[DllImport(LibraryName, EntryPoint = "igSetActiveID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetActiveID(uint id, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igSetFocusID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetFocusID(uint id, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igClearActiveID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClearActiveID();
		[DllImport(LibraryName, EntryPoint = "igGetHoveredID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetHoveredID();
		[DllImport(LibraryName, EntryPoint = "igSetHoveredID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetHoveredID(uint id);
		[DllImport(LibraryName, EntryPoint = "igKeepAliveID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void KeepAliveID(uint id);
		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igMarkItemEdited", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MarkItemEdited(uint id);
		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igPushOverrideID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushOverrideID(uint id);
		[DllImport(LibraryName, EntryPoint = "igGetIDWithSeed_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetIdWithSeed(byte* strIdBegin, byte* strIdEnd, uint seed);
		[DllImport(LibraryName, EntryPoint = "igGetIDWithSeed_Int", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetIdWithSeed(int n, uint seed);
		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igItemSize_Vec2", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ItemSize(Vector2 size, float textBaselineY);
		[DllImport(LibraryName, EntryPoint = "igItemSize_Rect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ItemSize(ImRect bb, float textBaselineY);
		[DllImport(LibraryName, EntryPoint = "igItemAdd", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ItemAdd(ImRect bb, uint id, ImRect* navBb, ImGuiItemFlags extraFlags);
		[DllImport(LibraryName, EntryPoint = "igItemHoverable", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ItemHoverable(ImRect bb, uint id, ImGuiItemFlags itemFlags);
		[DllImport(LibraryName, EntryPoint = "igIsWindowContentHoverable", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags);
		[DllImport(LibraryName, EntryPoint = "igIsClippedEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsClippedEx(ImRect bb, uint id);
		[DllImport(LibraryName, EntryPoint = "igSetLastItemData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetLastItemData(uint itemId, ImGuiItemFlags itemFlags, ImGuiItemStatusFlags statusFlags, ImRect itemRect);
		[DllImport(LibraryName, EntryPoint = "igCalcItemSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void CalcItemSize(Vector2* pOut, Vector2 size, float defaultW, float defaultH);
		[DllImport(LibraryName, EntryPoint = "igCalcWrapWidthForPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern float CalcWrapWidthForPos(Vector2 pos, float wrapPosX);
		[DllImport(LibraryName, EntryPoint = "igPushMultiItemsWidths", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushMultiItemsWidths(int components, float widthFull);
		[DllImport(LibraryName, EntryPoint = "igShrinkWidths", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShrinkWidths(ImGuiShrinkWidthItem* items, int count, float widthExcess);
		[DllImport(LibraryName, EntryPoint = "igGetStyleVarInfo", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiStyleVarInfo* GetStyleVarInfo(ImGuiStyleVar idx);
		[DllImport(LibraryName, EntryPoint = "igBeginDisabledOverrideReenable", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginDisabledOverrideReenable();
		[DllImport(LibraryName, EntryPoint = "igEndDisabledOverrideReenable", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndDisabledOverrideReenable();
		/// <summary>
		/// -&gt; BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogBegin", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogBegin(ImGuiLogFlags flags, int autoOpenDepth);
		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogToBuffer", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogToBuffer(int autoOpenDepth);
		[DllImport(LibraryName, EntryPoint = "igLogRenderedText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogRenderedText(Vector2* refPos, byte* text, byte* textEnd);
		[DllImport(LibraryName, EntryPoint = "igLogSetNextTextDecoration", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogSetNextTextDecoration(byte* prefix, byte* suffix);
		[DllImport(LibraryName, EntryPoint = "igBeginChildEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginChildEx(byte* name, uint id, Vector2 sizeArg, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags);
		[DllImport(LibraryName, EntryPoint = "igBeginPopupEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopupEx(uint id, ImGuiWindowFlags extraWindowFlags);
		[DllImport(LibraryName, EntryPoint = "igBeginPopupMenuEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginPopupMenuEx(uint id, byte* label, ImGuiWindowFlags extraWindowFlags);
		[DllImport(LibraryName, EntryPoint = "igOpenPopupEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void OpenPopupEx(uint id, ImGuiPopupFlags popupFlags);
		[DllImport(LibraryName, EntryPoint = "igClosePopupToLevel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClosePopupToLevel(int remaining, byte restoreFocusToWindowUnderPopup);
		[DllImport(LibraryName, EntryPoint = "igClosePopupsOverWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClosePopupsOverWindow(ImGuiWindow* refWindow, byte restoreFocusToWindowUnderPopup);
		[DllImport(LibraryName, EntryPoint = "igClosePopupsExceptModals", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClosePopupsExceptModals();
		[DllImport(LibraryName, EntryPoint = "igIsPopupOpen_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsPopupOpen(uint id, ImGuiPopupFlags popupFlags);
		[DllImport(LibraryName, EntryPoint = "igGetPopupAllowedExtentRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igGetTopMostPopupModal", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* GetTopMostPopupModal();
		[DllImport(LibraryName, EntryPoint = "igGetTopMostAndVisiblePopupModal", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* GetTopMostAndVisiblePopupModal();
		[DllImport(LibraryName, EntryPoint = "igFindBlockingModal", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiWindow* FindBlockingModal(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igFindBestWindowPosForPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void FindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igFindBestWindowPosForPopupEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void FindBestWindowPosForPopupEx(Vector2* pOut, Vector2 refPos, Vector2 size, ImGuiDir* lastDir, ImRect rOuter, ImRect rAvoid, ImGuiPopupPositionPolicy policy);
		[DllImport(LibraryName, EntryPoint = "igBeginTooltipEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTooltipEx(ImGuiTooltipFlags tooltipFlags, ImGuiWindowFlags extraWindowFlags);
		[DllImport(LibraryName, EntryPoint = "igBeginTooltipHidden", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTooltipHidden();
		[DllImport(LibraryName, EntryPoint = "igBeginViewportSideBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags windowFlags);
		[DllImport(LibraryName, EntryPoint = "igBeginMenuEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginMenuEx(byte* label, byte* icon, byte enabled);
		[DllImport(LibraryName, EntryPoint = "igMenuItemEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte MenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
		[DllImport(LibraryName, EntryPoint = "igBeginComboPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginComboPopup(uint popupId, ImRect bb, ImGuiComboFlags flags);
		[DllImport(LibraryName, EntryPoint = "igBeginComboPreview", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginComboPreview();
		[DllImport(LibraryName, EntryPoint = "igEndComboPreview", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndComboPreview();
		[DllImport(LibraryName, EntryPoint = "igNavInitWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavInitWindow(ImGuiWindow* window, byte forceReinit);
		[DllImport(LibraryName, EntryPoint = "igNavInitRequestApplyResult", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavInitRequestApplyResult();
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestButNoResultYet", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte NavMoveRequestButNoResultYet();
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestSubmit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestSubmit(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags);
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestForward", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestForward(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags);
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestResolveWithLastItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestResolveWithPastTreeNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* treeNodeData);
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestCancel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestCancel();
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestApplyResult", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestApplyResult();
		[DllImport(LibraryName, EntryPoint = "igNavMoveRequestTryWrapping", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags moveFlags);
		[DllImport(LibraryName, EntryPoint = "igNavHighlightActivated", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavHhlhtActivated(uint id);
		[DllImport(LibraryName, EntryPoint = "igNavClearPreferredPosForAxis", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavClearPreferredPosForAxis(ImGuiAxis axis);
		[DllImport(LibraryName, EntryPoint = "igSetNavCursorVisibleAfterMove", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNavCursorVisibleAfterMove();
		[DllImport(LibraryName, EntryPoint = "igNavUpdateCurrentWindowIsScrollPushableX", CallingConvention = CallingConvention.Cdecl)]
		public static extern void NavUpdateCurrentWindowIsScrollPushableX();
		[DllImport(LibraryName, EntryPoint = "igSetNavWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNavWindow(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igSetNavID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNavID(uint id, ImGuiNavLayer navLayer, uint focusScopeId, ImRect rectRel);
		[DllImport(LibraryName, EntryPoint = "igSetNavFocusScope", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNavFocusScope(uint focusScopeId);
		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igFocusItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void FocusItem();
		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igActivateItemByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ActivateItemByID(uint id);
		[DllImport(LibraryName, EntryPoint = "igIsNamedKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsNamedKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsNamedKeyOrMod", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsNamedKeyOrMod(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsLegacyKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsLegacyKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsKeyboardKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyboardKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsGamepadKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsGamepadKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsMouseKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsAliasKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsAliasKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsLRModKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsLrModKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igFixupKeyChord", CallingConvention = CallingConvention.Cdecl)]
		public static extern int FixupKeyChord(int keyChord);
		[DllImport(LibraryName, EntryPoint = "igConvertSingleModFlagToKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKey ConvertSingleModFlagToKey(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igGetKeyData_ContextPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyData* GetKeyData(ImGuiContext* ctx, ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igGetKeyData_Key", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyData* GetKeyData(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igGetKeyChordName", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* GetKeyChordName(int keyChord);
		[DllImport(LibraryName, EntryPoint = "igMouseButtonToKey", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKey MouseButtonToKey(ImGuiMouseButton button);
		[DllImport(LibraryName, EntryPoint = "igIsMouseDragPastThreshold", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseDragPastThreshold(ImGuiMouseButton button, float lockThreshold);
		[DllImport(LibraryName, EntryPoint = "igGetKeyMagnitude2d", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetKeyMagnitude2D(Vector2* pOut, ImGuiKey keyLeft, ImGuiKey keyRight, ImGuiKey keyUp, ImGuiKey keyDown);
		[DllImport(LibraryName, EntryPoint = "igGetNavTweakPressedAmount", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetNavTweakPressedAmount(ImGuiAxis axis);
		[DllImport(LibraryName, EntryPoint = "igCalcTypematicRepeatAmount", CallingConvention = CallingConvention.Cdecl)]
		public static extern int CalcTypematicRepeatAmount(float t0, float t1, float repeatDelay, float repeatRate);
		[DllImport(LibraryName, EntryPoint = "igGetTypematicRepeatRate", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetTypematicRepeatRate(ImGuiInputFlags flags, float* repeatDelay, float* repeatRate);
		[DllImport(LibraryName, EntryPoint = "igTeleportMousePos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TeleportMousePos(Vector2 pos);
		[DllImport(LibraryName, EntryPoint = "igSetActiveIdUsingAllKeyboardKeys", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetActiveIdUsingAllKeyboardKeys();
		[DllImport(LibraryName, EntryPoint = "igIsActiveIdUsingNavDir", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsActiveIdUsingNavDir(ImGuiDir dir);
		[DllImport(LibraryName, EntryPoint = "igGetKeyOwner", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetKeyOwner(ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igSetKeyOwner", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetKeyOwner(ImGuiKey key, uint ownerId, ImGuiInputFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSetKeyOwnersForKeyChord", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetKeyOwnersForKeyChord(int key, uint ownerId, ImGuiInputFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSetItemKeyOwner_InputFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags);
		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTestKeyOwner", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TestKeyOwner(ImGuiKey key, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igGetKeyOwnerData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyOwnerData* GetKeyOwnerData(ImGuiContext* ctx, ImGuiKey key);
		[DllImport(LibraryName, EntryPoint = "igIsKeyDown_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyDown(ImGuiKey key, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsKeyPressed_InputFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsKeyReleased_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyReleased(ImGuiKey key, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsKeyChordPressed_InputFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsKeyChordPressed(int keyChord, ImGuiInputFlags flags, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsMouseDown_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseDown(ImGuiMouseButton button, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsMouseClicked_InputFlags", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsMouseReleased_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseReleased(ImGuiMouseButton button, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igIsMouseDoubleClicked_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsMouseDoubleClicked(ImGuiMouseButton button, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igShortcut_ID", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte Shortcut(int keyChord, ImGuiInputFlags flags, uint ownerId);
		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igSetShortcutRouting", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SetShortcutRouting(int keyChord, ImGuiInputFlags flags, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igTestShortcutRouting", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TestShortcutRouting(int keyChord, uint ownerId);
		[DllImport(LibraryName, EntryPoint = "igGetShortcutRoutingData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiKeyRoutingData* GetShortcutRoutingData(int keyChord);
		[DllImport(LibraryName, EntryPoint = "igDockContextInitialize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextInitialize(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igDockContextShutdown", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextShutdown(ImGuiContext* ctx);
		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDockContextClearNodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextClearNodes(ImGuiContext* ctx, uint rootId, byte clearSettingsRefs);
		[DllImport(LibraryName, EntryPoint = "igDockContextRebuildNodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextRebuildNodes(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igDockContextNewFrameUpdateUndocking", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextNewFrameUpdateUndocking(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igDockContextNewFrameUpdateDocking", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextNewFrameUpdateDocking(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igDockContextEndFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextEndFrame(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igDockContextGenNodeID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint DockContextGenNodeID(ImGuiContext* ctx);
		[DllImport(LibraryName, EntryPoint = "igDockContextQueueDock", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* targetNode, ImGuiWindow* payload, ImGuiDir splitDir, float splitRatio, byte splitOuter);
		[DllImport(LibraryName, EntryPoint = "igDockContextQueueUndockWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igDockContextQueueUndockNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
		[DllImport(LibraryName, EntryPoint = "igDockContextProcessUndockWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window, byte clearPersistentDockingRef);
		[DllImport(LibraryName, EntryPoint = "igDockContextProcessUndockNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
		[DllImport(LibraryName, EntryPoint = "igDockContextCalcDropPosForDocking", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* targetNode, ImGuiWindow* payloadWindow, ImGuiDockNode* payloadNode, ImGuiDir splitDir, byte splitOuter, Vector2* outPos);
		[DllImport(LibraryName, EntryPoint = "igDockContextFindNodeByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockNode* DockContextFindNodeByID(ImGuiContext* ctx, uint id);
		[DllImport(LibraryName, EntryPoint = "igDockNodeWindowMenuHandler_Default", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockNodeWindowMenuHandlerDefault(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tabBar);
		[DllImport(LibraryName, EntryPoint = "igDockNodeBeginAmendTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DockNodeBeginAmendTabBar(ImGuiDockNode* node);
		[DllImport(LibraryName, EntryPoint = "igDockNodeEndAmendTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockNodeEndAmendTabBar();
		[DllImport(LibraryName, EntryPoint = "igDockNodeGetRootNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockNode* DockNodeGetRootNode(ImGuiDockNode* node);
		[DllImport(LibraryName, EntryPoint = "igDockNodeIsInHierarchyOf", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
		[DllImport(LibraryName, EntryPoint = "igDockNodeGetDepth", CallingConvention = CallingConvention.Cdecl)]
		public static extern int DockNodeGetDepth(ImGuiDockNode* node);
		[DllImport(LibraryName, EntryPoint = "igDockNodeGetWindowMenuButtonId", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint DockNodeGetWindowMenuButtonId(ImGuiDockNode* node);
		[DllImport(LibraryName, EntryPoint = "igGetWindowDockNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockNode* GetWindowDockNode();
		[DllImport(LibraryName, EntryPoint = "igGetWindowAlwaysWantOwnTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte GetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igBeginDocked", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginDocked(ImGuiWindow* window, byte* pOpen);
		[DllImport(LibraryName, EntryPoint = "igBeginDockableDragDropSource", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginDockableDragDropSource(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igBeginDockableDragDropTarget", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginDockableDragDropTarget(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igSetWindowDock", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowDock(ImGuiWindow* window, uint dockId, ImGuiCond cond);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderDockWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderDockWindow(byte* windowName, uint nodeId);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderGetNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockNode* DockBuilderGetNode(uint nodeId);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderGetCentralNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDockNode* DockBuilderGetCentralNode(uint nodeId);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderAddNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint DockBuilderAddNode(uint nodeId, ImGuiDockNodeFlags flags);
		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDockBuilderRemoveNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderRemoveNode(uint nodeId);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderRemoveNodeDockedWindows", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderRemoveNodeDockedWindows(uint nodeId, byte clearSettingsRefs);
		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDockBuilderRemoveNodeChildNodes", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderRemoveNodeChildNodes(uint nodeId);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderSetNodePos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderSetNodePos(uint nodeId, Vector2 pos);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderSetNodeSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderSetNodeSize(uint nodeId, Vector2 size);
		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDockBuilderSplitNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint DockBuilderSplitNode(uint nodeId, ImGuiDir splitDir, float sizeRatioForNodeAtDir, uint* outIdAtDir, uint* outIdAtOppositeDir);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderCopyDockSpace", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderCopyDockSpace(uint srcDockspaceId, uint dstDockspaceId, ImVector<ImPointer<byte>>* inWindowRemapPairs);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderCopyNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderCopyNode(uint srcNodeId, uint dstNodeId, ImVector<uint>* outNodeRemapPairs);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderCopyWindowSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderCopyWindowSettings(byte* srcName, byte* dstName);
		[DllImport(LibraryName, EntryPoint = "igDockBuilderFinish", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DockBuilderFinish(uint nodeId);
		[DllImport(LibraryName, EntryPoint = "igPushFocusScope", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushFocusScope(uint id);
		[DllImport(LibraryName, EntryPoint = "igPopFocusScope", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopFocusScope();
		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetCurrentFocusScope", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetCurrentFocusScope();
		[DllImport(LibraryName, EntryPoint = "igIsDragDropActive", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsDragDropActive();
		[DllImport(LibraryName, EntryPoint = "igBeginDragDropTargetCustom", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginDragDropTargetCustom(ImRect bb, uint id);
		[DllImport(LibraryName, EntryPoint = "igClearDragDrop", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ClearDragDrop();
		[DllImport(LibraryName, EntryPoint = "igIsDragDropPayloadBeingAccepted", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsDragDropPayloadBeingAccepted();
		[DllImport(LibraryName, EntryPoint = "igRenderDragDropTargetRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderDragDropTargetRect(ImRect bb, ImRect itemClipRect);
		[DllImport(LibraryName, EntryPoint = "igGetTypingSelectRequest", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTypingSelectRequest* GetTypingSelectRequest(ImGuiTypingSelectFlags flags);
		[DllImport(LibraryName, EntryPoint = "igTypingSelectFindMatch", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TypingSelectFindMatch(ImGuiTypingSelectRequest* req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, void* userData, int navItemIdx);
		[DllImport(LibraryName, EntryPoint = "igTypingSelectFindNextSingleCharMatch", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, void* userData, int navItemIdx);
		[DllImport(LibraryName, EntryPoint = "igTypingSelectFindBestLeadingMatch", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, void* userData);
		[DllImport(LibraryName, EntryPoint = "igBeginBoxSelect", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginBoxSelect(ImRect scopeRect, ImGuiWindow* window, uint boxSelectId, ImGuiMultiSelectFlags msFlags);
		[DllImport(LibraryName, EntryPoint = "igEndBoxSelect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndBoxSelect(ImRect scopeRect, ImGuiMultiSelectFlags msFlags);
		[DllImport(LibraryName, EntryPoint = "igMultiSelectItemHeader", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MultiSelectItemHeader(uint id, byte* pSelected, ImGuiButtonFlags* pButtonFlags);
		[DllImport(LibraryName, EntryPoint = "igMultiSelectItemFooter", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MultiSelectItemFooter(uint id, byte* pSelected, byte* pPressed);
		[DllImport(LibraryName, EntryPoint = "igMultiSelectAddSetAll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected);
		[DllImport(LibraryName, EntryPoint = "igMultiSelectAddSetRange", CallingConvention = CallingConvention.Cdecl)]
		public static extern void MultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int rangeDir, long firstItem, long lastItem);
		[DllImport(LibraryName, EntryPoint = "igGetBoxSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiBoxSelectState* GetBoxSelectState(uint id);
		[DllImport(LibraryName, EntryPoint = "igGetMultiSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiMultiSelectState* GetMultiSelectState(uint id);
		[DllImport(LibraryName, EntryPoint = "igSetWindowClipRectBeforeSetChannel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clipRect);
		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igBeginColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern void BeginColumns(byte* strId, int count, ImGuiOldColumnFlags flags);
		/// <summary>
		/// close columns<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igEndColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndColumns();
		[DllImport(LibraryName, EntryPoint = "igPushColumnClipRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushColumnClipRect(int columnIndex);
		[DllImport(LibraryName, EntryPoint = "igPushColumnsBackground", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PushColumnsBackground();
		[DllImport(LibraryName, EntryPoint = "igPopColumnsBackground", CallingConvention = CallingConvention.Cdecl)]
		public static extern void PopColumnsBackground();
		[DllImport(LibraryName, EntryPoint = "igGetColumnsID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetColumnsID(byte* strId, int count);
		[DllImport(LibraryName, EntryPoint = "igFindOrCreateColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiOldColumns* FindOrCreateColumns(ImGuiWindow* window, uint id);
		[DllImport(LibraryName, EntryPoint = "igGetColumnOffsetFromNorm", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offsetNorm);
		[DllImport(LibraryName, EntryPoint = "igGetColumnNormFromOffset", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
		[DllImport(LibraryName, EntryPoint = "igTableOpenContextMenu", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableOpenContextMenu(int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableSetColumnWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetColumnWidth(int columnN, float width);
		[DllImport(LibraryName, EntryPoint = "igTableSetColumnSortDirection", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetColumnSortDirection(int columnN, ImGuiSortDirection sortDirection, byte appendToSortSpecs);
		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTableGetHoveredRow", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TableGetHoveredRow();
		[DllImport(LibraryName, EntryPoint = "igTableGetHeaderRowHeight", CallingConvention = CallingConvention.Cdecl)]
		public static extern float TableGetHeaderRowHeht();
		[DllImport(LibraryName, EntryPoint = "igTableGetHeaderAngledMaxLabelWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern float TableGetHeaderAngledMaxLabelWidth();
		[DllImport(LibraryName, EntryPoint = "igTablePushBackgroundChannel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TablePushBackgroundChannel();
		[DllImport(LibraryName, EntryPoint = "igTablePopBackgroundChannel", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TablePopBackgroundChannel();
		[DllImport(LibraryName, EntryPoint = "igTableAngledHeadersRowEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableAngledHeadersRowEx(uint rowId, float angle, float maxLabelWidth, ImGuiTableHeaderData* data, int dataCount);
		[DllImport(LibraryName, EntryPoint = "igGetCurrentTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTable* GetCurrentTable();
		[DllImport(LibraryName, EntryPoint = "igTableFindByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTable* TableFindByID(uint id);
		[DllImport(LibraryName, EntryPoint = "igBeginTableEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTableEx(byte* name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth);
		[DllImport(LibraryName, EntryPoint = "igTableBeginInitMemory", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableBeginInitMemory(ImGuiTable* table, int columnsCount);
		[DllImport(LibraryName, EntryPoint = "igTableBeginApplyRequests", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableBeginApplyRequests(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableSetupDrawChannels", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetupDrawChannels(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableUpdateLayout", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableUpdateLayout(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableUpdateBorders", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableUpdateBorders(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableUpdateColumnsWeightFromWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableUpdateColumnsWehtFromWidth(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableDrawBorders", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableDrawBorders(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableDrawDefaultContextMenu", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flagsForSectionToDisplay);
		[DllImport(LibraryName, EntryPoint = "igTableBeginContextMenuPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TableBeginContextMenuPopup(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableMergeDrawChannels", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableMergeDrawChannels(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableGetInstanceData", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableInstanceData* TableGetInstanceData(ImGuiTable* table, int instanceNo);
		[DllImport(LibraryName, EntryPoint = "igTableGetInstanceID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint TableGetInstanceID(ImGuiTable* table, int instanceNo);
		[DllImport(LibraryName, EntryPoint = "igTableSortSpecsSanitize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSortSpecsSanitize(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableSortSpecsBuild", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSortSpecsBuild(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnNextSortDirection", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumn* column);
		[DllImport(LibraryName, EntryPoint = "igTableFixColumnSortDirection", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnWidthAuto", CallingConvention = CallingConvention.Cdecl)]
		public static extern float TableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
		[DllImport(LibraryName, EntryPoint = "igTableBeginRow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableBeginRow(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableEndRow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableEndRow(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableBeginCell", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableBeginCell(ImGuiTable* table, int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableEndCell", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableEndCell(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableGetCellBgRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnName_TablePtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* TableGetColumnName(ImGuiTable* table, int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableGetColumnResizeID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint TableGetColumnResizeID(ImGuiTable* table, int columnN, int instanceNo);
		[DllImport(LibraryName, EntryPoint = "igTableCalcMaxColumnWidth", CallingConvention = CallingConvention.Cdecl)]
		public static extern float TableCalcMaxColumnWidth(ImGuiTable* table, int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableSetColumnWidthAutoSingle", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetColumnWidthAutoSingle(ImGuiTable* table, int columnN);
		[DllImport(LibraryName, EntryPoint = "igTableSetColumnWidthAutoAll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSetColumnWidthAutoAll(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableRemove", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableRemove(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableGcCompactTransientBuffers_TablePtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableGcCompactTransientBuffers(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableGcCompactTransientBuffers_TableTempDataPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableGcCompactTransientBuffers(ImGuiTableTempData* table);
		[DllImport(LibraryName, EntryPoint = "igTableGcCompactSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableGcCompactSettings();
		[DllImport(LibraryName, EntryPoint = "igTableLoadSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableLoadSettings(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableSaveSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSaveSettings(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableResetSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableResetSettings(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableGetBoundSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* TableGetBoundSettings(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igTableSettingsAddSettingsHandler", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TableSettingsAddSettingsHandler();
		[DllImport(LibraryName, EntryPoint = "igTableSettingsCreate", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* TableSettingsCreate(uint id, int columnsCount);
		[DllImport(LibraryName, EntryPoint = "igTableSettingsFindByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTableSettings* TableSettingsFindByID(uint id);
		[DllImport(LibraryName, EntryPoint = "igGetCurrentTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabBar* GetCurrentTabBar();
		[DllImport(LibraryName, EntryPoint = "igBeginTabBarEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginTabBarEx(ImGuiTabBar* tabBar, ImRect bb, ImGuiTabBarFlags flags);
		[DllImport(LibraryName, EntryPoint = "igTabBarFindTabByID", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabItem* TabBarFindTabByID(ImGuiTabBar* tabBar, uint tabId);
		[DllImport(LibraryName, EntryPoint = "igTabBarFindTabByOrder", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabItem* TabBarFindTabByOrder(ImGuiTabBar* tabBar, int order);
		[DllImport(LibraryName, EntryPoint = "igTabBarFindMostRecentlySelectedTabForActiveWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabItem* TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tabBar);
		[DllImport(LibraryName, EntryPoint = "igTabBarGetCurrentTab", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiTabItem* TabBarGetCurrentTab(ImGuiTabBar* tabBar);
		[DllImport(LibraryName, EntryPoint = "igTabBarGetTabOrder", CallingConvention = CallingConvention.Cdecl)]
		public static extern int TabBarGetTabOrder(ImGuiTabBar* tabBar, ImGuiTabItem* tab);
		[DllImport(LibraryName, EntryPoint = "igTabBarGetTabName", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* TabBarGetTabName(ImGuiTabBar* tabBar, ImGuiTabItem* tab);
		[DllImport(LibraryName, EntryPoint = "igTabBarAddTab", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarAddTab(ImGuiTabBar* tabBar, ImGuiTabItemFlags tabFlags, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igTabBarRemoveTab", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarRemoveTab(ImGuiTabBar* tabBar, uint tabId);
		[DllImport(LibraryName, EntryPoint = "igTabBarCloseTab", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarCloseTab(ImGuiTabBar* tabBar, ImGuiTabItem* tab);
		[DllImport(LibraryName, EntryPoint = "igTabBarQueueFocus_TabItemPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarQueueFocus(ImGuiTabBar* tabBar, ImGuiTabItem* tab);
		[DllImport(LibraryName, EntryPoint = "igTabBarQueueFocus_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarQueueFocus(ImGuiTabBar* tabBar, byte* tabName);
		[DllImport(LibraryName, EntryPoint = "igTabBarQueueReorder", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarQueueReorder(ImGuiTabBar* tabBar, ImGuiTabItem* tab, int offset);
		[DllImport(LibraryName, EntryPoint = "igTabBarQueueReorderFromMousePos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabBarQueueReorderFromMousePos(ImGuiTabBar* tabBar, ImGuiTabItem* tab, Vector2 mousePos);
		[DllImport(LibraryName, EntryPoint = "igTabBarProcessReorder", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TabBarProcessReorder(ImGuiTabBar* tabBar);
		[DllImport(LibraryName, EntryPoint = "igTabItemEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TabItemEx(ImGuiTabBar* tabBar, byte* label, byte* pOpen, ImGuiTabItemFlags flags, ImGuiWindow* dockedWindow);
		[DllImport(LibraryName, EntryPoint = "igTabItemSpacing", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabItemSpacing(byte* strId, ImGuiTabItemFlags flags, float width);
		[DllImport(LibraryName, EntryPoint = "igTabItemCalcSize_Str", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabItemCalcSize(Vector2* pOut, byte* label, byte hasCloseButtonOrUnsavedMarker);
		[DllImport(LibraryName, EntryPoint = "igTabItemCalcSize_WindowPtr", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabItemCalcSize(Vector2* pOut, ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igTabItemBackground", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabItemBackground(ImDrawList* drawList, ImRect bb, ImGuiTabItemFlags flags, uint col);
		[DllImport(LibraryName, EntryPoint = "igTabItemLabelAndCloseButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TabItemLabelAndCloseButton(ImDrawList* drawList, ImRect bb, ImGuiTabItemFlags flags, Vector2 framePadding, byte* label, uint tabId, uint closeButtonId, byte isContentsVisible, byte* outJustClosed, byte* outTextClipped);
		[DllImport(LibraryName, EntryPoint = "igRenderText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderText(Vector2 pos, byte* text, byte* textEnd, byte hideTextAfterHash);
		[DllImport(LibraryName, EntryPoint = "igRenderTextWrapped", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderTextWrapped(Vector2 pos, byte* text, byte* textEnd, float wrapWidth);
		[DllImport(LibraryName, EntryPoint = "igRenderTextClipped", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderTextClipped(Vector2 posMin, Vector2 posMax, byte* text, byte* textEnd, Vector2* textSizeIfKnown, Vector2 align, ImRect* clipRect);
		[DllImport(LibraryName, EntryPoint = "igRenderTextClippedEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderTextClippedEx(ImDrawList* drawList, Vector2 posMin, Vector2 posMax, byte* text, byte* textEnd, Vector2* textSizeIfKnown, Vector2 align, ImRect* clipRect);
		[DllImport(LibraryName, EntryPoint = "igRenderTextEllipsis", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderTextEllipsis(ImDrawList* drawList, Vector2 posMin, Vector2 posMax, float clipMaxX, float ellipsisMaxX, byte* text, byte* textEnd, Vector2* textSizeIfKnown);
		[DllImport(LibraryName, EntryPoint = "igRenderFrame", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol, byte borders, float rounding);
		[DllImport(LibraryName, EntryPoint = "igRenderFrameBorder", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderFrameBorder(Vector2 pMin, Vector2 pMax, float rounding);
		[DllImport(LibraryName, EntryPoint = "igRenderColorRectWithAlphaCheckerboard", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderColorRectWithAlphaCheckerboard(ImDrawList* drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff, float rounding, ImDrawFlags flags);
		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igRenderNavCursor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags);
		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igFindRenderedTextEnd", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte* FindRenderedTextEnd(byte* text, byte* textEnd);
		[DllImport(LibraryName, EntryPoint = "igRenderMouseCursor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouseCursor, uint colFill, uint colBorder, uint colShadow);
		[DllImport(LibraryName, EntryPoint = "igRenderArrow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderArrow(ImDrawList* drawList, Vector2 pos, uint col, ImGuiDir dir, float scale);
		[DllImport(LibraryName, EntryPoint = "igRenderBullet", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderBullet(ImDrawList* drawList, Vector2 pos, uint col);
		[DllImport(LibraryName, EntryPoint = "igRenderCheckMark", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderCheckMark(ImDrawList* drawList, Vector2 pos, uint col, float sz);
		[DllImport(LibraryName, EntryPoint = "igRenderArrowPointingAt", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderArrowPointingAt(ImDrawList* drawList, Vector2 pos, Vector2 halfSz, ImGuiDir direction, uint col);
		[DllImport(LibraryName, EntryPoint = "igRenderArrowDockMenu", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderArrowDockMenu(ImDrawList* drawList, Vector2 pMin, float sz, uint col);
		[DllImport(LibraryName, EntryPoint = "igRenderRectFilledRangeH", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderRectFilledRangeH(ImDrawList* drawList, ImRect rect, uint col, float xStartNorm, float xEndNorm, float rounding);
		[DllImport(LibraryName, EntryPoint = "igRenderRectFilledWithHole", CallingConvention = CallingConvention.Cdecl)]
		public static extern void RenderRectFilledWithHole(ImDrawList* drawList, ImRect outer, ImRect inner, uint col, float rounding);
		[DllImport(LibraryName, EntryPoint = "igCalcRoundingFlagsForRectInRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImDrawFlags CalcRoundingFlagsForRectInRect(ImRect rIn, ImRect rOuter, float threshold);
		[DllImport(LibraryName, EntryPoint = "igTextEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TextEx(byte* text, byte* textEnd, ImGuiTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igButtonEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ButtonEx(byte* label, Vector2 sizeArg, ImGuiButtonFlags flags);
		[DllImport(LibraryName, EntryPoint = "igArrowButtonEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ArrowButtonEx(byte* strId, ImGuiDir dir, Vector2 sizeArg, ImGuiButtonFlags flags);
		[DllImport(LibraryName, EntryPoint = "igImageButtonEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImageButtonEx(uint id, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol, ImGuiButtonFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSeparatorEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SeparatorEx(ImGuiSeparatorFlags flags, float thickness);
		[DllImport(LibraryName, EntryPoint = "igSeparatorTextEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SeparatorTextEx(uint id, byte* label, byte* labelEnd, float extraWidth);
		[DllImport(LibraryName, EntryPoint = "igCheckboxFlags_S64Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CheckboxFlags(byte* label, long* flags, long flagsValue);
		[DllImport(LibraryName, EntryPoint = "igCheckboxFlags_U64Ptr", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CheckboxFlags(byte* label, ulong* flags, ulong flagsValue);
		[DllImport(LibraryName, EntryPoint = "igCloseButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CloseButton(uint id, Vector2 pos);
		[DllImport(LibraryName, EntryPoint = "igCollapseButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte CollapseButton(uint id, Vector2 pos, ImGuiDockNode* dockNode);
		[DllImport(LibraryName, EntryPoint = "igScrollbar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void Scrollbar(ImGuiAxis axis);
		[DllImport(LibraryName, EntryPoint = "igScrollbarEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* pScrollV, long availV, long contentsV, ImDrawFlags drawRoundingFlags);
		[DllImport(LibraryName, EntryPoint = "igGetWindowScrollbarRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
		[DllImport(LibraryName, EntryPoint = "igGetWindowScrollbarID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetWindowResizeCornerID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetWindowResizeCornerID(ImGuiWindow* window, int n);
		[DllImport(LibraryName, EntryPoint = "igGetWindowResizeBorderID", CallingConvention = CallingConvention.Cdecl)]
		public static extern uint GetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
		[DllImport(LibraryName, EntryPoint = "igButtonBehavior", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ButtonBehavior(ImRect bb, uint id, byte* outHovered, byte* outHeld, ImGuiButtonFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDragBehavior", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DragBehavior(uint id, ImGuiDataType dataType, void* pV, float vSpeed, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags);
		[DllImport(LibraryName, EntryPoint = "igSliderBehavior", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SliderBehavior(ImRect bb, uint id, ImGuiDataType dataType, void* pV, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags, ImRect* outGrabBb);
		[DllImport(LibraryName, EntryPoint = "igSplitterBehavior", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float minSize1, float minSize2, float hoverExtend, float hoverVisibilityDelay, uint bgCol);
		[DllImport(LibraryName, EntryPoint = "igTreeNodeBehavior", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* labelEnd);
		[DllImport(LibraryName, EntryPoint = "igTreePushOverrideID", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TreePushOverrideID(uint id);
		[DllImport(LibraryName, EntryPoint = "igTreeNodeGetOpen", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNodeGetOpen(uint storageId);
		[DllImport(LibraryName, EntryPoint = "igTreeNodeSetOpen", CallingConvention = CallingConvention.Cdecl)]
		public static extern void TreeNodeSetOpen(uint storageId, byte open);
		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igTreeNodeUpdateNextOpen", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TreeNodeUpdateNextOpen(uint storageId, ImGuiTreeNodeFlags flags);
		[DllImport(LibraryName, EntryPoint = "igDataTypeGetInfo", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiDataTypeInfo* DataTypeGetInfo(ImGuiDataType dataType);
		[DllImport(LibraryName, EntryPoint = "igDataTypeFormatString", CallingConvention = CallingConvention.Cdecl)]
		public static extern int DataTypeFormatString(byte* buf, int bufSize, ImGuiDataType dataType, void* pData, byte* format);
		[DllImport(LibraryName, EntryPoint = "igDataTypeApplyOp", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DataTypeApplyOp(ImGuiDataType dataType, int op, void* output, void* arg_1, void* arg_2);
		[DllImport(LibraryName, EntryPoint = "igDataTypeApplyFromText", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DataTypeApplyFromText(byte* buf, ImGuiDataType dataType, void* pData, byte* format, void* pDataWhenEmpty);
		[DllImport(LibraryName, EntryPoint = "igDataTypeCompare", CallingConvention = CallingConvention.Cdecl)]
		public static extern int DataTypeCompare(ImGuiDataType dataType, void* arg_1, void* arg_2);
		[DllImport(LibraryName, EntryPoint = "igDataTypeClamp", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DataTypeClamp(ImGuiDataType dataType, void* pData, void* pMin, void* pMax);
		[DllImport(LibraryName, EntryPoint = "igDataTypeIsZero", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DataTypeIsZero(ImGuiDataType dataType, void* pData);
		[DllImport(LibraryName, EntryPoint = "igInputTextEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte InputTextEx(byte* label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData);
		[DllImport(LibraryName, EntryPoint = "igInputTextDeactivateHook", CallingConvention = CallingConvention.Cdecl)]
		public static extern void InputTextDeactivateHook(uint id);
		[DllImport(LibraryName, EntryPoint = "igTempInputText", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TempInputText(ImRect bb, uint id, byte* label, byte* buf, int bufSize, ImGuiInputTextFlags flags);
		[DllImport(LibraryName, EntryPoint = "igTempInputScalar", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType dataType, void* pData, byte* format, void* pClampMin, void* pClampMax);
		[DllImport(LibraryName, EntryPoint = "igTempInputIsActive", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte TempInputIsActive(uint id);
		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igGetInputTextState", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImGuiInputTextState* GetInputTextState(uint id);
		[DllImport(LibraryName, EntryPoint = "igSetNextItemRefVal", CallingConvention = CallingConvention.Cdecl)]
		public static extern void SetNextItemRefVal(ImGuiDataType dataType, void* pData);
		/// <summary>
		/// This may be useful to apply workaround that a based on distinguish whenever an item is active as a text input field.<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igIsItemActiveAsInputText", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte IsItemActiveAsInputText();
		[DllImport(LibraryName, EntryPoint = "igColorTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
		[DllImport(LibraryName, EntryPoint = "igColorEditOptionsPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
		[DllImport(LibraryName, EntryPoint = "igColorPickerOptionsPopup", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ColorPickerOptionsPopup(float* refCol, ImGuiColorEditFlags flags);
		[DllImport(LibraryName, EntryPoint = "igPlotEx", CallingConvention = CallingConvention.Cdecl)]
		public static extern int PlotEx(ImGuiPlotType plotType, byte* label, IgPlotLinesValuesGetter valuesGetter, void* data, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 sizeArg);
		[DllImport(LibraryName, EntryPoint = "igShadeVertsLinearColorGradientKeepAlpha", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShadeVertsLinearColorGradientKeepAlpha(ImDrawList* drawList, int vertStartIdx, int vertEndIdx, Vector2 gradientP0, Vector2 gradientP1, uint col0, uint col1);
		[DllImport(LibraryName, EntryPoint = "igShadeVertsLinearUV", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShadeVertsLinearUV(ImDrawList* drawList, int vertStartIdx, int vertEndIdx, Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, byte clamp);
		[DllImport(LibraryName, EntryPoint = "igShadeVertsTransformPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShadeVertsTransformPos(ImDrawList* drawList, int vertStartIdx, int vertEndIdx, Vector2 pivotIn, float cosA, float sinA, Vector2 pivotOut);
		[DllImport(LibraryName, EntryPoint = "igGcCompactTransientMiscBuffers", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GcCompactTransientMiscBuffers();
		[DllImport(LibraryName, EntryPoint = "igGcCompactTransientWindowBuffers", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GcCompactTransientWindowBuffers(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igGcAwakeTransientWindowBuffers", CallingConvention = CallingConvention.Cdecl)]
		public static extern void GcAwakeTransientWindowBuffers(ImGuiWindow* window);
		[DllImport(LibraryName, EntryPoint = "igErrorLog", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ErrorLog(byte* msg);
		[DllImport(LibraryName, EntryPoint = "igErrorRecoveryStoreState", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ErrorRecoveryStoreState(ImGuiErrorRecoveryState* stateOut);
		[DllImport(LibraryName, EntryPoint = "igErrorRecoveryTryToRecoverState", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* stateIn);
		[DllImport(LibraryName, EntryPoint = "igErrorRecoveryTryToRecoverWindowState", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* stateIn);
		[DllImport(LibraryName, EntryPoint = "igErrorCheckUsingSetCursorPosToExtendParentBoundaries", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		[DllImport(LibraryName, EntryPoint = "igErrorCheckEndFrameFinalizeErrorTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ErrorCheckEndFrameFinalizeErrorTooltip();
		[DllImport(LibraryName, EntryPoint = "igBeginErrorTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte BeginErrorTooltip();
		[DllImport(LibraryName, EntryPoint = "igEndErrorTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void EndErrorTooltip();
		/// <summary>
		/// size &gt;= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDebugAllocHook", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugAllocHook(ImGuiDebugAllocInfo* info, int frameCount, void* ptr, uint size);
		[DllImport(LibraryName, EntryPoint = "igDebugDrawCursorPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugDrawCursorPos(uint col);
		[DllImport(LibraryName, EntryPoint = "igDebugDrawLineExtents", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugDrawLineExtents(uint col);
		[DllImport(LibraryName, EntryPoint = "igDebugDrawItemRect", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugDrawItemRect(uint col);
		[DllImport(LibraryName, EntryPoint = "igDebugTextUnformattedWithLocateItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugTextUnformattedWithLocateItem(byte* lineBegin, byte* lineEnd);
		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDebugLocateItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugLocateItem(uint targetId);
		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igDebugLocateItemOnHover", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugLocateItemOnHover(uint targetId);
		[DllImport(LibraryName, EntryPoint = "igDebugLocateItemResolveWithLastItem", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugLocateItemResolveWithLastItem();
		[DllImport(LibraryName, EntryPoint = "igDebugBreakClearData", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugBreakClearData();
		[DllImport(LibraryName, EntryPoint = "igDebugBreakButton", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte DebugBreakButton(byte* label, byte* descriptionOfLocation);
		[DllImport(LibraryName, EntryPoint = "igDebugBreakButtonTooltip", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugBreakButtonTooltip(byte keyboardOnly, byte* descriptionOfLocation);
		[DllImport(LibraryName, EntryPoint = "igShowFontAtlas", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ShowFontAtlas(ImFontAtlas* atlas);
		[DllImport(LibraryName, EntryPoint = "igDebugHookIdInfo", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugHookIdInfo(uint id, ImGuiDataType dataType, void* dataId, void* dataIdEnd);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeColumns", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeColumns(ImGuiOldColumns* columns);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeDockNode", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeDockNode(ImGuiDockNode* node, byte* label);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeDrawList", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* drawList, byte* label);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeDrawCmdShowMeshAndBoundingBox", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* outDrawList, ImDrawList* drawList, ImDrawCmd* drawCmd, byte showMesh, byte showAabb);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeFont(ImFont* font);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeFontGlyph", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeStorage", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeStorage(ImGuiStorage* storage, byte* label);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeTabBar", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeTabBar(ImGuiTabBar* tabBar, byte* label);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeTable(ImGuiTable* table);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeTableSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeTableSettings(ImGuiTableSettings* settings);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeInputTextState", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeInputTextState(ImGuiInputTextState* state);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeTypingSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeTypingSelectState(ImGuiTypingSelectState* state);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeMultiSelectState", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeMultiSelectState(ImGuiMultiSelectState* state);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeWindow", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeWindow(ImGuiWindow* window, byte* label);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeWindowSettings", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeWindowSettings(ImGuiWindowSettings* settings);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeWindowsList", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeWindowsList(ImVector<ImGuiWindowPtr>* windows, byte* label);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeWindowsListByBeginStackParent", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windowsSize, ImGuiWindow* parentInBeginStack);
		[DllImport(LibraryName, EntryPoint = "igDebugNodeViewport", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodeViewport(ImGuiViewportP* viewport);
		[DllImport(LibraryName, EntryPoint = "igDebugNodePlatformMonitor", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, byte* label, int idx);
		[DllImport(LibraryName, EntryPoint = "igDebugRenderKeyboardPreview", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugRenderKeyboardPreview(ImDrawList* drawList);
		[DllImport(LibraryName, EntryPoint = "igDebugRenderViewportThumbnail", CallingConvention = CallingConvention.Cdecl)]
		public static extern void DebugRenderViewportThumbnail(ImDrawList* drawList, ImGuiViewportP* viewport, ImRect bb);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasGetBuilderForStbTruetype", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImFontBuilderIO* ImFontAtlasGetBuilderForStbTruetype();
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasUpdateSourcesPointers", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasUpdateSourcesPointers(ImFontAtlas* atlas);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildInit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildInit(ImFontAtlas* atlas);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildSetupFont", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* src, float ascent, float descent);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildPackCustomRects", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrpContextOpaque);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildFinish", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildFinish(ImFontAtlas* atlas);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildRender8bppRectFromString", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildRender8BppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* inStr, byte inMarkerChar, byte inMarkerPixelValue);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildRender32bppRectFromString", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildRender32BppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* inStr, byte inMarkerChar, uint inMarkerPixelValue);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildMultiplyCalcLookupTable", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildMultiplyCalcLookupTable(byte* outTable, float inMultiplyFactor);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildMultiplyRectAlpha8", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasBuildGetOversampleFactors", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImFontAtlasBuildGetOversampleFactors(ImFontConfig* src, int* outOversampleH, int* outOversampleV);
		[DllImport(LibraryName, EntryPoint = "igImFontAtlasGetMouseCursorTexData", CallingConvention = CallingConvention.Cdecl)]
		public static extern byte ImFontAtlasGetMouseCursorTexData(ImFontAtlas* atlas, ImGuiMouseCursor cursorType, Vector2* outOffset, Vector2* outSize, Vector2* outUvBorder, Vector2* outUvFill);
		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		[DllImport(LibraryName, EntryPoint = "igLogText", CallingConvention = CallingConvention.Cdecl)]
		public static extern void LogText(byte* fmt);
		[DllImport(LibraryName, EntryPoint = "ImGuiTextBuffer_appendf", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiTextBufferAppendf(ImGuiTextBuffer* self, byte* fmt);
		[DllImport(LibraryName, EntryPoint = "igGET_FLT_MAX", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GETFLTMAX();
		[DllImport(LibraryName, EntryPoint = "igGET_FLT_MIN", CallingConvention = CallingConvention.Cdecl)]
		public static extern float GETFLTMIN();
		[DllImport(LibraryName, EntryPoint = "ImVector_ImWchar_create", CallingConvention = CallingConvention.Cdecl)]
		public static extern ImVector<ushort>* ImVectorImWcharCreate();
		[DllImport(LibraryName, EntryPoint = "ImVector_ImWchar_destroy", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVectorImWcharDestroy(ImVector<ushort>* self);
		[DllImport(LibraryName, EntryPoint = "ImVector_ImWchar_Init", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVectorImWcharInit(ImVector<ushort>* p);
		[DllImport(LibraryName, EntryPoint = "ImVector_ImWchar_UnInit", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImVectorImWcharUnInit(ImVector<ushort>* p);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformIO_Set_Platform_GetWindowPos", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformIOSetPlatformGetWindowPos(ImGuiPlatformIO* platformIo, ImGuiPlatformIOSetPlatformGetWindowPosUserCallback userCallback);
		[DllImport(LibraryName, EntryPoint = "ImGuiPlatformIO_Set_Platform_GetWindowSize", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ImGuiPlatformIOSetPlatformGetWindowSize(ImGuiPlatformIO* platformIo, ImGuiPlatformIOSetPlatformGetWindowSizeUserCallback userCallback);
	}
}
