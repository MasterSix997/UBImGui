using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public unsafe partial class ImGuiNative
	{
		static ImGuiNative()
		{
			Debug.Log("ImGuiNative static constructor called. Initializing ImGuiNative...");
			InitApi(new NativeLibraryContext(LibraryLoader.LoadLibrary(GetLibraryName, null)));
		}
		
		~ImGuiNative()
		{
			Debug.Log("ImGuiNative destructor called. Freeing ImGuiNative resources...");
		}

		public static string GetLibraryName()
		{
			return "cimgui";
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2* ImVec2ImVec2()
		{
			return (Vector2*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[0])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2ImVec2NilConstruct(Vector2* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2Destroy(Vector2* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[2])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2* ImVec2ImVec2(float x, float y)
		{
			return (Vector2*)((delegate* unmanaged[Cdecl]<float, float, IntPtr>)FuncTable[3])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2ImVec2FloatConstruct(Vector2* self, float x, float y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[4])((IntPtr)self, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4* ImVec4ImVec4()
		{
			return (Vector4*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[5])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec4ImVec4NilConstruct(Vector4* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[6])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec4Destroy(Vector4* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[7])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4* ImVec4ImVec4(float x, float y, float z, float w)
		{
			return (Vector4*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[8])(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec4ImVec4FloatConstruct(Vector4* self, float x, float y, float z, float w)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[9])((IntPtr)self, x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContext* CreateContext(ImFontAtlas* sharedFontAtlas)
		{
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[10])((IntPtr)sharedFontAtlas);
		}

		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[11])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContext* GetCurrentContext()
		{
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[12])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentContext(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[13])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIO* GetIO()
		{
			return (ImGuiIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[14])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformIO* GetPlatformIO()
		{
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[15])();
		}

		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyle* GetStyle()
		{
			return (ImGuiStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[16])();
		}

		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NewFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[17])();
		}

		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[18])();
		}

		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Render()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[19])();
		}

		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawData* GetDrawData()
		{
			return (ImDrawData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[20])();
		}

		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowDemoWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[21])((IntPtr)pOpen);
		}

		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowMetricsWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[22])((IntPtr)pOpen);
		}

		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowDebugLogWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[23])((IntPtr)pOpen);
		}

		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowIdStackToolWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[24])((IntPtr)pOpen);
		}

		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowAboutWindow(byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[25])((IntPtr)pOpen);
		}

		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowStyleEditor(ImGuiStyle* _ref)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[26])((IntPtr)_ref);
		}

		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ShowStyleSelector(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[27])((IntPtr)label);
		}

		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowFontSelector(byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[28])((IntPtr)label);
		}

		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowUserGuide()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[29])();
		}

		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetVersion()
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[30])();
		}

		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsDark(ImGuiStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[31])((IntPtr)dst);
		}

		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsLht(ImGuiStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[32])((IntPtr)dst);
		}

		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StyleColorsClassic(ImGuiStyle* dst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[33])((IntPtr)dst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Begin(byte* name, byte* pOpen, ImGuiWindowFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiWindowFlags, byte>)FuncTable[34])((IntPtr)name, (IntPtr)pOpen, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void End()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[35])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginChild(byte* strId, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiChildFlags, ImGuiWindowFlags, byte>)FuncTable[36])((IntPtr)strId, size, childFlags, windowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginChild(uint id, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, ImGuiChildFlags, ImGuiWindowFlags, byte>)FuncTable[37])(id, size, childFlags, windowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndChild()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[38])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowAppearing()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[39])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowCollapsed()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[40])();
		}

		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowFocused(ImGuiFocusedFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiFocusedFlags, byte>)FuncTable[41])(flags);
		}

		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowHovered(ImGuiHoveredFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiHoveredFlags, byte>)FuncTable[42])(flags);
		}

		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* GetWindowDrawList()
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[43])();
		}

		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetWindowDpiScale()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[44])();
		}

		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetWindowPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[45])((IntPtr)pOut);
		}

		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetWindowSize(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[46])((IntPtr)pOut);
		}

		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetWindowWidth()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[47])();
		}

		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetWindowHeht()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[48])();
		}

		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* GetWindowViewport()
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[49])();
		}

		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, Vector2, void>)FuncTable[50])(pos, cond, pivot);
		}

		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, void>)FuncTable[51])(size, cond);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowSizeConstraints(Vector2 sizeMin, Vector2 sizeMax, ImGuiSizeCallback customCallback, void* customCallbackData)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, ImGuiSizeCallback, IntPtr, void>)FuncTable[52])(sizeMin, sizeMax, customCallback, (IntPtr)customCallbackData);
		}

		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowContentSize(Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[53])(size);
		}

		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowCollapsed(byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImGuiCond, void>)FuncTable[54])(collapsed, cond);
		}

		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowFocus()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[55])();
		}

		/// <summary>
		/// set next window scrolling value (use &lt; 0.0f to not affect a given axis).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowScroll(Vector2 scroll)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[56])(scroll);
		}

		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowBgAlpha(float alpha)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[57])(alpha);
		}

		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowViewport(uint viewportId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[58])(viewportId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, void>)FuncTable[59])(pos, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowSize(Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<Vector2, ImGuiCond, void>)FuncTable[60])(size, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowCollapsed(byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImGuiCond, void>)FuncTable[61])(collapsed, cond);
		}

		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowFocus()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[62])();
		}

		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowFontScale(float scale)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[63])(scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowPos(byte* name, Vector2 pos, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[64])((IntPtr)name, pos, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowSize(byte* name, Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[65])((IntPtr)name, size, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowCollapsed(byte* name, byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, ImGuiCond, void>)FuncTable[66])((IntPtr)name, collapsed, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowFocus(byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[67])((IntPtr)name);
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetScrollX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[68])();
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetScrollY()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[69])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollX(float scrollX)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[70])(scrollX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollY(float scrollY)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[71])(scrollY);
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetScrollMaxX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[72])();
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetScrollMaxY()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[73])();
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollHereX(float centerXRatio)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[74])(centerXRatio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollHereY(float centerYRatio)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[75])(centerYRatio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollFromPosX(float localX, float centerXRatio)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[76])(localX, centerXRatio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollFromPosY(float localY, float centerYRatio)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[77])(localY, centerYRatio);
		}

		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushFont(ImFont* font)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[78])((IntPtr)font);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopFont()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[79])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleColor(ImGuiCol idx, uint col)
		{
			((delegate* unmanaged[Cdecl]<ImGuiCol, uint, void>)FuncTable[80])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleColor(ImGuiCol idx, Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<ImGuiCol, Vector4, void>)FuncTable[81])(idx, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleColor(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[82])(count);
		}

		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImGuiStyleVar idx, float val)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, void>)FuncTable[83])(idx, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, Vector2, void>)FuncTable[84])(idx, val);
		}

		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVarX(ImGuiStyleVar idx, float valX)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, void>)FuncTable[85])(idx, valX);
		}

		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushStyleVarY(ImGuiStyleVar idx, float valY)
		{
			((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, void>)FuncTable[86])(idx, valY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopStyleVar(int count)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[87])(count);
		}

		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushItemFlag(ImGuiItemFlags option, byte enabled)
		{
			((delegate* unmanaged[Cdecl]<ImGuiItemFlags, byte, void>)FuncTable[88])(option, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopItemFlag()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[89])();
		}

		/// <summary>
		/// push width of items for common large "item+label" widgets. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushItemWidth(float itemWidth)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[90])(itemWidth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopItemWidth()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[91])();
		}

		/// <summary>
		/// set width of the _next_ common large "item+label" widget. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemWidth(float itemWidth)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[92])(itemWidth);
		}

		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CalcItemWidth()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[93])();
		}

		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushTextWrapPos(float wrapLocalPosX)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[94])(wrapLocalPosX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopTextWrapPos()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[95])();
		}

		/// <summary>
		/// get current font<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* GetFont()
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[96])();
		}

		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetFontSize()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[97])();
		}

		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetFontTexUvWhitePixel(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[98])((IntPtr)pOut);
		}

		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetColorU32(ImGuiCol idx, float alphaMul)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiCol, float, uint>)FuncTable[99])(idx, alphaMul);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetColorU32(Vector4 col)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, uint>)FuncTable[100])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetColorU32(uint col, float alphaMul)
		{
			return ((delegate* unmanaged[Cdecl]<uint, float, uint>)FuncTable[101])(col, alphaMul);
		}

		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4* GetStyleColorVec4(ImGuiCol idx)
		{
			return (Vector4*)((delegate* unmanaged[Cdecl]<ImGuiCol, IntPtr>)FuncTable[102])(idx);
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetCursorScreenPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[103])((IntPtr)pOut);
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCursorScreenPos(Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[104])(pos);
		}

		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetContentRegionAvail(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[105])((IntPtr)pOut);
		}

		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetCursorPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[106])((IntPtr)pOut);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetCursorPosX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[107])();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetCursorPosY()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[108])();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCursorPos(Vector2 localPos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[109])(localPos);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCursorPosX(float localX)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[110])(localX);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCursorPosY(float localY)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[111])(localY);
		}

		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetCursorStartPos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[112])((IntPtr)pOut);
		}

		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Separator()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[113])();
		}

		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SameLine(float offsetFromStartX, float spacing)
		{
			((delegate* unmanaged[Cdecl]<float, float, void>)FuncTable[114])(offsetFromStartX, spacing);
		}

		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NewLine()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[115])();
		}

		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Spacing()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[116])();
		}

		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Dummy(Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[117])(size);
		}

		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Indent(float indentW)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[118])(indentW);
		}

		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Unindent(float indentW)
		{
			((delegate* unmanaged[Cdecl]<float, void>)FuncTable[119])(indentW);
		}

		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginGroup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[120])();
		}

		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndGroup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[121])();
		}

		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AlnTextToFramePadding()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[122])();
		}

		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetTextLineHeht()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[123])();
		}

		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetTextLineHehtWithSpacing()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[124])();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetFrameHeht()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[125])();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetFrameHehtWithSpacing()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[126])();
		}

		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushID(byte* strId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[127])((IntPtr)strId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushID(byte* strIdBegin, byte* strIdEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[128])((IntPtr)strIdBegin, (IntPtr)strIdEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushID(void* ptrId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[129])((IntPtr)ptrId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushID(int intId)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[130])(intId);
		}

		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopID()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[131])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetID(byte* strId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[132])((IntPtr)strId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetID(byte* strIdBegin, byte* strIdEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[133])((IntPtr)strIdBegin, (IntPtr)strIdEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetID(void* ptrId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[134])((IntPtr)ptrId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetID(int intId)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint>)FuncTable[135])(intId);
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TextUnformatted(byte* text, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[136])((IntPtr)text, (IntPtr)textEnd);
		}

		/// <summary>
		/// formatted text<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Text(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[137])((IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TextColored(Vector4 col, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<Vector4, IntPtr, void>)FuncTable[138])(col, (IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TextDisabled(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[139])((IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TextWrapped(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[140])((IntPtr)fmt);
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LabelText(byte* label, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[141])((IntPtr)label, (IntPtr)fmt);
		}

		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BulletText(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[142])((IntPtr)fmt);
		}

		/// <summary>
		/// currently: formatted text with a horizontal line<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SeparatorText(byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[143])((IntPtr)label);
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Button(byte* label, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, byte>)FuncTable[144])((IntPtr)label, size);
		}

		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SmallButton(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[145])((IntPtr)label);
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InvisibleButton(byte* strId, Vector2 size, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiButtonFlags, byte>)FuncTable[146])((IntPtr)strId, size, flags);
		}

		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ArrowButton(byte* strId, ImGuiDir dir)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDir, byte>)FuncTable[147])((IntPtr)strId, dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Checkbox(byte* label, byte* v)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[148])((IntPtr)label, (IntPtr)v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CheckboxFlags(byte* label, int* flags, int flagsValue)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte>)FuncTable[149])((IntPtr)label, (IntPtr)flags, flagsValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CheckboxFlags(byte* label, uint* flags, uint flagsValue)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, byte>)FuncTable[150])((IntPtr)label, (IntPtr)flags, flagsValue);
		}

		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RadioButton(byte* label, byte active)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[151])((IntPtr)label, active);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte RadioButton(byte* label, int* v, int vButton)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, byte>)FuncTable[152])((IntPtr)label, (IntPtr)v, vButton);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ProgressBar(float fraction, Vector2 sizeArg, byte* overlay)
		{
			((delegate* unmanaged[Cdecl]<float, Vector2, IntPtr, void>)FuncTable[153])(fraction, sizeArg, (IntPtr)overlay);
		}

		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Bullet()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[154])();
		}

		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TextLink(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[155])((IntPtr)label);
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TextLinkOpenURL(byte* label, byte* url)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[156])((IntPtr)label, (IntPtr)url);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Image(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1)
		{
			((delegate* unmanaged[Cdecl]<ulong, Vector2, Vector2, Vector2, void>)FuncTable[157])(userTextureId, imageSize, uv0, uv1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			((delegate* unmanaged[Cdecl]<ulong, Vector2, Vector2, Vector2, Vector4, Vector4, void>)FuncTable[158])(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImageButton(byte* strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong, Vector2, Vector2, Vector2, Vector4, Vector4, byte>)FuncTable[159])((IntPtr)strId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginCombo(byte* label, byte* previewValue, ImGuiComboFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiComboFlags, byte>)FuncTable[160])((IntPtr)label, (IntPtr)previewValue, flags);
		}

		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndCombo()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[161])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ComboStrArr(byte* label, int* currentItem, byte** items, int itemsCount, int popupMaxHeightInItems)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, byte>)FuncTable[162])((IntPtr)label, (IntPtr)currentItem, (IntPtr)items, itemsCount, popupMaxHeightInItems);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Combo(byte* label, int* currentItem, byte* itemsSeparatedByZeros, int popupMaxHeightInItems)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, byte>)FuncTable[163])((IntPtr)label, (IntPtr)currentItem, (IntPtr)itemsSeparatedByZeros, popupMaxHeightInItems);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Combo(byte* label, int* currentItem, IgComboGetter getter, void* userData, int itemsCount, int popupMaxHeightInItems)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IgComboGetter, IntPtr, int, int, byte>)FuncTable[164])((IntPtr)label, (IntPtr)currentItem, getter, (IntPtr)userData, itemsCount, popupMaxHeightInItems);
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragFloat(byte* label, float* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[165])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragFloat2(byte* label, Vector2* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[166])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragFloat3(byte* label, Vector3* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[167])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragFloat4(byte* label, Vector4* v, float vSpeed, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[168])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragFloatRange2(byte* label, float* vCurrentMin, float* vCurrentMax, float vSpeed, float vMin, float vMax, byte* format, byte* formatMax, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, float, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[169])((IntPtr)label, (IntPtr)vCurrentMin, (IntPtr)vCurrentMax, vSpeed, vMin, vMax, (IntPtr)format, (IntPtr)formatMax, flags);
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragInt(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[170])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragInt2(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[171])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragInt3(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[172])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragInt4(byte* label, int* v, float vSpeed, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[173])((IntPtr)label, (IntPtr)v, vSpeed, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragIntRange2(byte* label, int* vCurrentMin, int* vCurrentMax, float vSpeed, int vMin, int vMax, byte* format, byte* formatMax, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, int, int, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[174])((IntPtr)label, (IntPtr)vCurrentMin, (IntPtr)vCurrentMax, vSpeed, vMin, vMax, (IntPtr)format, (IntPtr)formatMax, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragScalar(byte* label, ImGuiDataType dataType, void* pData, float vSpeed, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, float, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[175])((IntPtr)label, dataType, (IntPtr)pData, vSpeed, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragScalarN(byte* label, ImGuiDataType dataType, void* pData, int components, float vSpeed, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, int, float, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[176])((IntPtr)label, dataType, (IntPtr)pData, components, vSpeed, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags);
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderFloat(byte* label, float* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[177])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderFloat2(byte* label, Vector2* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[178])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderFloat3(byte* label, Vector3* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[179])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderFloat4(byte* label, Vector4* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[180])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderAngle(byte* label, float* vRad, float vDegreesMin, float vDegreesMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[181])((IntPtr)label, (IntPtr)vRad, vDegreesMin, vDegreesMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderInt(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[182])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderInt2(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[183])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderInt3(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[184])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderInt4(byte* label, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[185])((IntPtr)label, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderScalar(byte* label, ImGuiDataType dataType, void* pData, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[186])((IntPtr)label, dataType, (IntPtr)pData, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderScalarN(byte* label, ImGuiDataType dataType, void* pData, int components, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, int, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[187])((IntPtr)label, dataType, (IntPtr)pData, components, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte VSliderFloat(byte* label, Vector2 size, float* v, float vMin, float vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, IntPtr, float, float, IntPtr, ImGuiSliderFlags, byte>)FuncTable[188])((IntPtr)label, size, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte VSliderInt(byte* label, Vector2 size, int* v, int vMin, int vMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, IntPtr, int, int, IntPtr, ImGuiSliderFlags, byte>)FuncTable[189])((IntPtr)label, size, (IntPtr)v, vMin, vMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte VSliderScalar(byte* label, Vector2 size, ImGuiDataType dataType, void* pData, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[190])((IntPtr)label, size, dataType, (IntPtr)pData, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputText(byte* label, byte* buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, ImGuiInputTextFlags, ImGuiInputTextCallback, IntPtr, byte>)FuncTable[191])((IntPtr)label, (IntPtr)buf, bufSize, flags, callback, (IntPtr)userData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputTextMultiline(byte* label, byte* buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, Vector2, ImGuiInputTextFlags, ImGuiInputTextCallback, IntPtr, byte>)FuncTable[192])((IntPtr)label, (IntPtr)buf, bufSize, size, flags, callback, (IntPtr)userData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputTextWithHint(byte* label, byte* hint, byte* buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, uint, ImGuiInputTextFlags, ImGuiInputTextCallback, IntPtr, byte>)FuncTable[193])((IntPtr)label, (IntPtr)hint, (IntPtr)buf, bufSize, flags, callback, (IntPtr)userData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputFloat(byte* label, float* v, float step, float stepFast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[194])((IntPtr)label, (IntPtr)v, step, stepFast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[195])((IntPtr)label, (IntPtr)v, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[196])((IntPtr)label, (IntPtr)v, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[197])((IntPtr)label, (IntPtr)v, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputInt(byte* label, int* v, int step, int stepFast, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, ImGuiInputTextFlags, byte>)FuncTable[198])((IntPtr)label, (IntPtr)v, step, stepFast, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputInt2(byte* label, int* v, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[199])((IntPtr)label, (IntPtr)v, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputInt3(byte* label, int* v, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[200])((IntPtr)label, (IntPtr)v, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputInt4(byte* label, int* v, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[201])((IntPtr)label, (IntPtr)v, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputDouble(byte* label, double* v, double step, double stepFast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, double, double, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[202])((IntPtr)label, (IntPtr)v, step, stepFast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputScalar(byte* label, ImGuiDataType dataType, void* pData, void* pStep, void* pStepFast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[203])((IntPtr)label, dataType, (IntPtr)pData, (IntPtr)pStep, (IntPtr)pStepFast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputScalarN(byte* label, ImGuiDataType dataType, void* pData, int components, void* pStep, void* pStepFast, byte* format, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, int, IntPtr, IntPtr, IntPtr, ImGuiInputTextFlags, byte>)FuncTable[204])((IntPtr)label, dataType, (IntPtr)pData, components, (IntPtr)pStep, (IntPtr)pStepFast, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, byte>)FuncTable[205])((IntPtr)label, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, byte>)FuncTable[206])((IntPtr)label, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, byte>)FuncTable[207])((IntPtr)label, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* refCol)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, IntPtr, byte>)FuncTable[208])((IntPtr)label, (IntPtr)col, flags, (IntPtr)refCol);
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ColorButton(byte* descId, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector4, ImGuiColorEditFlags, Vector2, byte>)FuncTable[209])((IntPtr)descId, col, flags, size);
		}

		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetColorEditOptions(ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiColorEditFlags, void>)FuncTable[210])(flags);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNode(byte* label)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[211])((IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNode(byte* strId, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[212])((IntPtr)strId, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNode(void* ptrId, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[213])((IntPtr)ptrId, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNodeEx(byte* label, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, byte>)FuncTable[214])((IntPtr)label, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNodeEx(byte* strId, ImGuiTreeNodeFlags flags, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, IntPtr, byte>)FuncTable[215])((IntPtr)strId, flags, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNodeEx(void* ptrId, ImGuiTreeNodeFlags flags, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, IntPtr, byte>)FuncTable[216])((IntPtr)ptrId, flags, (IntPtr)fmt);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TreePush(byte* strId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[217])((IntPtr)strId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TreePush(void* ptrId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[218])((IntPtr)ptrId);
		}

		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TreePop()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[219])();
		}

		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetTreeNodeToLabelSpacing()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[220])();
		}

		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CollapsingHeader(byte* label, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTreeNodeFlags, byte>)FuncTable[221])((IntPtr)label, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CollapsingHeader(byte* label, byte* pVisible, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiTreeNodeFlags, byte>)FuncTable[222])((IntPtr)label, (IntPtr)pVisible, flags);
		}

		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemOpen(byte isOpen, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<byte, ImGuiCond, void>)FuncTable[223])(isOpen, cond);
		}

		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemStorageID(uint storageId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[224])(storageId);
		}

		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Selectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, ImGuiSelectableFlags, Vector2, byte>)FuncTable[225])((IntPtr)label, selected, flags, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Selectable(byte* label, byte* pSelected, ImGuiSelectableFlags flags, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiSelectableFlags, Vector2, byte>)FuncTable[226])((IntPtr)label, (IntPtr)pSelected, flags, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectIO* BeginMultiSelect(ImGuiMultiSelectFlags flags, int selectionSize, int itemsCount)
		{
			return (ImGuiMultiSelectIO*)((delegate* unmanaged[Cdecl]<ImGuiMultiSelectFlags, int, int, IntPtr>)FuncTable[227])(flags, selectionSize, itemsCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectIO* EndMultiSelect()
		{
			return (ImGuiMultiSelectIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[228])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemSelectionUserData(long selectionUserData)
		{
			((delegate* unmanaged[Cdecl]<long, void>)FuncTable[229])(selectionUserData);
		}

		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemToggledSelection()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[230])();
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginListBox(byte* label, Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, byte>)FuncTable[231])((IntPtr)label, size);
		}

		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndListBox()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[232])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ListBoxStrArr(byte* label, int* currentItem, byte** items, int itemsCount, int heightInItems)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, int, byte>)FuncTable[233])((IntPtr)label, (IntPtr)currentItem, (IntPtr)items, itemsCount, heightInItems);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ListBoxFnStrPtr(byte* label, int* currentItem, IgComboGetter getter, void* userData, int itemsCount, int heightInItems)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IgComboGetter, IntPtr, int, int, byte>)FuncTable[234])((IntPtr)label, (IntPtr)currentItem, getter, (IntPtr)userData, itemsCount, heightInItems);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLines(byte* label, float* values, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, int, void>)FuncTable[235])((IntPtr)label, (IntPtr)values, valuesCount, valuesOffset, (IntPtr)overlayText, scaleMin, scaleMax, graphSize, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotLines(byte* label, IgPlotLinesValuesGetter valuesGetter, void* data, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IgPlotLinesValuesGetter, IntPtr, int, int, IntPtr, float, float, Vector2, void>)FuncTable[236])((IntPtr)label, valuesGetter, (IntPtr)data, valuesCount, valuesOffset, (IntPtr)overlayText, scaleMin, scaleMax, graphSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHistogram(byte* label, float* values, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, IntPtr, float, float, Vector2, int, void>)FuncTable[237])((IntPtr)label, (IntPtr)values, valuesCount, valuesOffset, (IntPtr)overlayText, scaleMin, scaleMax, graphSize, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PlotHistogram(byte* label, IgPlotLinesValuesGetter valuesGetter, void* data, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IgPlotLinesValuesGetter, IntPtr, int, int, IntPtr, float, float, Vector2, void>)FuncTable[238])((IntPtr)label, valuesGetter, (IntPtr)data, valuesCount, valuesOffset, (IntPtr)overlayText, scaleMin, scaleMax, graphSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Value(byte* prefix, byte b)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[239])((IntPtr)prefix, b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Value(byte* prefix, int v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[240])((IntPtr)prefix, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Value(byte* prefix, uint v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[241])((IntPtr)prefix, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Value(byte* prefix, float v, byte* floatFormat)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, void>)FuncTable[242])((IntPtr)prefix, v, (IntPtr)floatFormat);
		}

		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginMenuBar()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[243])();
		}

		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndMenuBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[244])();
		}

		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginMainMenuBar()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[245])();
		}

		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndMainMenuBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[246])();
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginMenu(byte* label, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte, byte>)FuncTable[247])((IntPtr)label, enabled);
		}

		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndMenu()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[248])();
		}

		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte MenuItem(byte* label, byte* shortcut, byte selected, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte, byte>)FuncTable[249])((IntPtr)label, (IntPtr)shortcut, selected, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte MenuItem(byte* label, byte* shortcut, byte* pSelected, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, byte>)FuncTable[250])((IntPtr)label, (IntPtr)shortcut, (IntPtr)pSelected, enabled);
		}

		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTooltip()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[251])();
		}

		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndTooltip()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[252])();
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTooltip(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[253])((IntPtr)fmt);
		}

		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginItemTooltip()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[254])();
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemTooltip(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[255])((IntPtr)fmt);
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopup(byte* strId, ImGuiWindowFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiWindowFlags, byte>)FuncTable[256])((IntPtr)strId, flags);
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopupModal(byte* name, byte* pOpen, ImGuiWindowFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiWindowFlags, byte>)FuncTable[257])((IntPtr)name, (IntPtr)pOpen, flags);
		}

		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndPopup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[258])();
		}

		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void OpenPopup(byte* strId, ImGuiPopupFlags popupFlags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, void>)FuncTable[259])((IntPtr)strId, popupFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void OpenPopup(uint id, ImGuiPopupFlags popupFlags)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiPopupFlags, void>)FuncTable[260])(id, popupFlags);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void OpenPopupOnItemClick(byte* strId, ImGuiPopupFlags popupFlags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, void>)FuncTable[261])((IntPtr)strId, popupFlags);
		}

		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CloseCurrentPopup()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[262])();
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopupContextItem(byte* strId, ImGuiPopupFlags popupFlags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[263])((IntPtr)strId, popupFlags);
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopupContextWindow(byte* strId, ImGuiPopupFlags popupFlags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[264])((IntPtr)strId, popupFlags);
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopupContextVoid(byte* strId, ImGuiPopupFlags popupFlags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[265])((IntPtr)strId, popupFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsPopupOpen(byte* strId, ImGuiPopupFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPopupFlags, byte>)FuncTable[266])((IntPtr)strId, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTable(byte* strId, int columns, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ImGuiTableFlags, Vector2, float, byte>)FuncTable[267])((IntPtr)strId, columns, flags, outerSize, innerWidth);
		}

		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndTable()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[268])();
		}

		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableNextRow(ImGuiTableRowFlags rowFlags, float minRowHeight)
		{
			((delegate* unmanaged[Cdecl]<ImGuiTableRowFlags, float, void>)FuncTable[269])(rowFlags, minRowHeight);
		}

		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TableNextColumn()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[270])();
		}

		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TableSetColumnIndex(int columnN)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[271])(columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float initWidthOrWeight, uint userId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTableColumnFlags, float, uint, void>)FuncTable[272])((IntPtr)label, flags, initWidthOrWeight, userId);
		}

		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetupScrollFreeze(int cols, int rows)
		{
			((delegate* unmanaged[Cdecl]<int, int, void>)FuncTable[273])(cols, rows);
		}

		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableHeader(byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[274])((IntPtr)label);
		}

		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableHeadersRow()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[275])();
		}

		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableAngledHeadersRow()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[276])();
		}

		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSortSpecs* TableGetSortSpecs()
		{
			return (ImGuiTableSortSpecs*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[277])();
		}

		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TableGetColumnCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[278])();
		}

		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TableGetColumnIndex()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[279])();
		}

		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TableGetRowIndex()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[280])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* TableGetColumnName(int columnN)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<int, IntPtr>)FuncTable[281])(columnN);
		}

		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnFlags TableGetColumnFlags(int columnN)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImGuiTableColumnFlags>)FuncTable[282])(columnN);
		}

		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetColumnEnabled(int columnN, byte v)
		{
			((delegate* unmanaged[Cdecl]<int, byte, void>)FuncTable[283])(columnN, v);
		}

		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TableGetHoveredColumn()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[284])();
		}

		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int columnN)
		{
			((delegate* unmanaged[Cdecl]<ImGuiTableBgTarget, uint, int, void>)FuncTable[285])(target, color, columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Columns(int count, byte* id, byte borders)
		{
			((delegate* unmanaged[Cdecl]<int, IntPtr, byte, void>)FuncTable[286])(count, (IntPtr)id, borders);
		}

		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NextColumn()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[287])();
		}

		/// <summary>
		/// get current column index<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetColumnIndex()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[288])();
		}

		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetColumnWidth(int columnIndex)
		{
			return ((delegate* unmanaged[Cdecl]<int, float>)FuncTable[289])(columnIndex);
		}

		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetColumnWidth(int columnIndex, float width)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[290])(columnIndex, width);
		}

		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetColumnOffset(int columnIndex)
		{
			return ((delegate* unmanaged[Cdecl]<int, float>)FuncTable[291])(columnIndex);
		}

		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetColumnOffset(int columnIndex, float offsetX)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[292])(columnIndex, offsetX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetColumnsCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[293])();
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTabBar(byte* strId, ImGuiTabBarFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabBarFlags, byte>)FuncTable[294])((IntPtr)strId, flags);
		}

		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndTabBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[295])();
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTabItem(byte* label, byte* pOpen, ImGuiTabItemFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiTabItemFlags, byte>)FuncTable[296])((IntPtr)label, (IntPtr)pOpen, flags);
		}

		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndTabItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[297])();
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TabItemButton(byte* label, ImGuiTabItemFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabItemFlags, byte>)FuncTable[298])((IntPtr)label, flags);
		}

		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetTabItemClosed(byte* tabOrDockedWindowLabel)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[299])((IntPtr)tabOrDockedWindowLabel);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint DockSpace(uint dockspaceId, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* windowClass)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, ImGuiDockNodeFlags, IntPtr, uint>)FuncTable[300])(dockspaceId, size, flags, (IntPtr)windowClass);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint DockSpaceOverViewport(uint dockspaceId, ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* windowClass)
		{
			return ((delegate* unmanaged[Cdecl]<uint, IntPtr, ImGuiDockNodeFlags, IntPtr, uint>)FuncTable[301])(dockspaceId, (IntPtr)viewport, flags, (IntPtr)windowClass);
		}

		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowDockID(uint dockId, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiCond, void>)FuncTable[302])(dockId, cond);
		}

		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowClass(ImGuiWindowClass* windowClass)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[303])((IntPtr)windowClass);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetWindowDockID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[304])();
		}

		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowDocked()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[305])();
		}

		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogToTTY(int autoOpenDepth)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[306])(autoOpenDepth);
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogToFile(int autoOpenDepth, byte* filename)
		{
			((delegate* unmanaged[Cdecl]<int, IntPtr, void>)FuncTable[307])(autoOpenDepth, (IntPtr)filename);
		}

		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogToClipboard(int autoOpenDepth)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[308])(autoOpenDepth);
		}

		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogFinish()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[309])();
		}

		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogButtons()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[310])();
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogText(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[311])((IntPtr)fmt);
		}

		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropSource(ImGuiDragDropFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDragDropFlags, byte>)FuncTable[312])(flags);
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, ImGuiCond, byte>)FuncTable[313])((IntPtr)type, (IntPtr)data, sz, cond);
		}

		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndDragDropSource()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[314])();
		}

		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropTarget()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[315])();
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPayload* AcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags)
		{
			return (ImGuiPayload*)((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDragDropFlags, IntPtr>)FuncTable[316])((IntPtr)type, flags);
		}

		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndDragDropTarget()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[317])();
		}

		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPayload* GetDragDropPayload()
		{
			return (ImGuiPayload*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[318])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginDisabled(byte disabled)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[319])(disabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndDisabled()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[320])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushClipRect(Vector2 clipRectMin, Vector2 clipRectMax, byte intersectWithCurrentClipRect)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, byte, void>)FuncTable[321])(clipRectMin, clipRectMax, intersectWithCurrentClipRect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopClipRect()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[322])();
		}

		/// <summary>
		/// make last item the default focused item of a newly appearing window.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemDefaultFocus()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[323])();
		}

		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyboardFocusHere(int offset)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[324])(offset);
		}

		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNavCursorVisible(byte visible)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[325])(visible);
		}

		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemAllowOverlap()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[326])();
		}

		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemHovered(ImGuiHoveredFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiHoveredFlags, byte>)FuncTable[327])(flags);
		}

		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[328])();
		}

		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemFocused()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[329])();
		}

		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemClicked(ImGuiMouseButton mouseButton)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[330])(mouseButton);
		}

		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemVisible()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[331])();
		}

		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemEdited()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[332])();
		}

		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemActivated()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[333])();
		}

		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemDeactivated()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[334])();
		}

		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemDeactivatedAfterEdit()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[335])();
		}

		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemToggledOpen()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[336])();
		}

		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAnyItemHovered()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[337])();
		}

		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAnyItemActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[338])();
		}

		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAnyItemFocused()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[339])();
		}

		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetItemID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[340])();
		}

		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetItemRectMin(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[341])((IntPtr)pOut);
		}

		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetItemRectMax(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[342])((IntPtr)pOut);
		}

		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetItemRectSize(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[343])((IntPtr)pOut);
		}

		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* GetMainViewport()
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[344])();
		}

		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* GetBackgroundDrawList(ImGuiViewport* viewport)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[345])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* GetForegroundDrawList(ImGuiViewport* viewport)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[346])((IntPtr)viewport);
		}

		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsRectVisible(Vector2 size)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, byte>)FuncTable[347])(size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsRectVisible(Vector2 rectMin, Vector2 rectMax)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, byte>)FuncTable[348])(rectMin, rectMax);
		}

		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double GetTime()
		{
			return ((delegate* unmanaged[Cdecl]<double>)FuncTable[349])();
		}

		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetFrameCount()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[350])();
		}

		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawListSharedData* GetDrawListSharedData()
		{
			return (ImDrawListSharedData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[351])();
		}

		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetStyleColorName(ImGuiCol idx)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiCol, IntPtr>)FuncTable[352])(idx);
		}

		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetStateStorage(ImGuiStorage* storage)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[353])((IntPtr)storage);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStorage* GetStateStorage()
		{
			return (ImGuiStorage*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[354])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalcTextSize(Vector2* pOut, byte* text, byte* textEnd, byte hideTextAfterDoubleHash, float wrapWidth)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, float, void>)FuncTable[355])((IntPtr)pOut, (IntPtr)text, (IntPtr)textEnd, hideTextAfterDoubleHash, wrapWidth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColorConvertU32ToFloat4(Vector4* pOut, uint _in)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[356])((IntPtr)pOut, _in);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ColorConvertFloat4ToU32(Vector4 _in)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, uint>)FuncTable[357])(_in);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColorConvertRgBtoHSV(float r, float g, float b, float* outH, float* outS, float* outV)
		{
			((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[358])(r, g, b, (IntPtr)outH, (IntPtr)outS, (IntPtr)outV);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColorConvertHsVtoRGB(float h, float s, float v, float* outR, float* outG, float* outB)
		{
			((delegate* unmanaged[Cdecl]<float, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[359])(h, s, v, (IntPtr)outR, (IntPtr)outG, (IntPtr)outB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyDown(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[360])(key);
		}

		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyPressed(ImGuiKey key, byte repeat)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte, byte>)FuncTable[361])(key, repeat);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyReleased(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[362])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyChordPressed(int keyChord)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[363])(keyChord);
		}

		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be &gt;1 if RepeatRate is small enough that DeltaTime &gt; RepeatRate<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetKeyPressedAmount(ImGuiKey key, float repeatDelay, float rate)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, float, float, int>)FuncTable[364])(key, repeatDelay, rate);
		}

		/// <summary>
		/// [DEBUG] returns English name of the key. Those names are provided for debugging purpose and are not meant to be saved persistently nor compared.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetKeyName(ImGuiKey key)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiKey, IntPtr>)FuncTable[365])(key);
		}

		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextFrameWantCaptureKeyboard(byte wantCaptureKeyboard)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[366])(wantCaptureKeyboard);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Shortcut(int keyChord, ImGuiInputFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImGuiInputFlags, byte>)FuncTable[367])(keyChord, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemShortcut(int keyChord, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<int, ImGuiInputFlags, void>)FuncTable[368])(keyChord, flags);
		}

		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemKeyOwner(ImGuiKey key)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, void>)FuncTable[369])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseDown(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[370])(button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseClicked(ImGuiMouseButton button, byte repeat)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte, byte>)FuncTable[371])(button, repeat);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseReleased(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[372])(button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseDoubleClicked(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, byte>)FuncTable[373])(button);
		}

		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay &gt;= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseReleasedWithDelay(ImGuiMouseButton button, float delay)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, float, byte>)FuncTable[374])(button, delay);
		}

		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetMouseClickedCount(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, int>)FuncTable[375])(button);
		}

		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseHoveringRect(Vector2 rMin, Vector2 rMax, byte clip)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, byte, byte>)FuncTable[376])(rMin, rMax, clip);
		}

		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMousePosValid(Vector2* mousePos)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[377])((IntPtr)mousePos);
		}

		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAnyMouseDown()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[378])();
		}

		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetMousePos(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[379])((IntPtr)pOut);
		}

		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetMousePosOnOpeningCurrentPopup(Vector2* pOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[380])((IntPtr)pOut);
		}

		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseDragging(ImGuiMouseButton button, float lockThreshold)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, float, byte>)FuncTable[381])(button, lockThreshold);
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lockThreshold)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseButton, float, void>)FuncTable[382])((IntPtr)pOut, button, lockThreshold);
		}

		/// <summary>
		/// //<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ResetMouseDragDelta(ImGuiMouseButton button)
		{
			((delegate* unmanaged[Cdecl]<ImGuiMouseButton, void>)FuncTable[383])(button);
		}

		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMouseCursor GetMouseCursor()
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseCursor>)FuncTable[384])();
		}

		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMouseCursor(ImGuiMouseCursor cursorType)
		{
			((delegate* unmanaged[Cdecl]<ImGuiMouseCursor, void>)FuncTable[385])(cursorType);
		}

		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextFrameWantCaptureMouse(byte wantCaptureMouse)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[386])(wantCaptureMouse);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetClipboardText()
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[387])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetClipboardText(byte* text)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[388])((IntPtr)text);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LoadIniSettingsFromDisk(byte* iniFilename)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[389])((IntPtr)iniFilename);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LoadIniSettingsFromMemory(byte* iniData, uint iniSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[390])((IntPtr)iniData, iniSize);
		}

		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SaveIniSettingsToDisk(byte* iniFilename)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[391])((IntPtr)iniFilename);
		}

		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* SaveIniSettingsToMemory(uint* outIniSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[392])((IntPtr)outIniSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugTextEncoding(byte* text)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[393])((IntPtr)text);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugFlashStyleColor(ImGuiCol idx)
		{
			((delegate* unmanaged[Cdecl]<ImGuiCol, void>)FuncTable[394])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugStartItemPicker()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[395])();
		}

		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DebugCheckVersionAndDataLayout(byte* versionStr, uint szIo, uint szStyle, uint szVec2, uint szVec4, uint szDrawvert, uint szDrawidx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, uint, uint, uint, uint, byte>)FuncTable[396])((IntPtr)versionStr, szIo, szStyle, szVec2, szVec4, szDrawvert, szDrawidx);
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugLog(byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[397])((IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetAllocatorFunctions(ImGuiMemAllocFunc allocFunc, ImGuiMemFreeFunc freeFunc, void* userData)
		{
			((delegate* unmanaged[Cdecl]<ImGuiMemAllocFunc, ImGuiMemFreeFunc, IntPtr, void>)FuncTable[398])(allocFunc, freeFunc, (IntPtr)userData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetAllocatorFunctions(void* pAllocFunc, void* pFreeFunc, void** pUserData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[399])((IntPtr)pAllocFunc, (IntPtr)pFreeFunc, (IntPtr)pUserData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* MemAlloc(uint size)
		{
			return (void*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[400])(size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MemFree(void* ptr)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[401])((IntPtr)ptr);
		}

		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdatePlatformWindows()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[402])();
		}

		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderPlatformWindowsDefault(void* platformRenderArg, void* rendererRenderArg)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[403])((IntPtr)platformRenderArg, (IntPtr)rendererRenderArg);
		}

		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyPlatformWindows()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[404])();
		}

		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* FindViewportByID(uint id)
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[405])(id);
		}

		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* FindViewportByPlatformHandle(void* platformHandle)
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[406])((IntPtr)platformHandle);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSortSpecs* ImGuiTableSortSpecsImGuiTableSortSpecs()
		{
			return (ImGuiTableSortSpecs*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[407])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSortSpecsImGuiTableSortSpecsConstruct(ImGuiTableSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[408])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSortSpecsDestroy(ImGuiTableSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[409])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecsImGuiTableColumnSortSpecs()
		{
			return (ImGuiTableColumnSortSpecs*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[410])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSortSpecsImGuiTableColumnSortSpecsConstruct(ImGuiTableColumnSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[411])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSortSpecsDestroy(ImGuiTableColumnSortSpecs* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[412])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyle* ImGuiStyleImGuiStyle()
		{
			return (ImGuiStyle*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[413])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleImGuiStyleConstruct(ImGuiStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[414])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleDestroy(ImGuiStyle* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[415])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleScaleAllSizes(ImGuiStyle* self, float scaleFactor)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[416])((IntPtr)self, scaleFactor);
		}

		/// <summary>
		/// Queue a new key down/up event. Key should be "translated" (as in, generally ImGuiKey_A matches the key end-user would use to emit an 'A' character)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, byte, void>)FuncTable[417])((IntPtr)self, key, down);
		}

		/// <summary>
		/// Queue a new key down/up event for analog values (e.g. ImGuiKey_Gamepad_ values). Dead-zones should be handled by the backend.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, byte, float, void>)FuncTable[418])((IntPtr)self, key, down, v);
		}

		/// <summary>
		/// Queue a mouse position update. Use -FLT_MAX,-FLT_MAX to signify no mouse (e.g. app not focused and not hovered)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddMousePosEvent(ImGuiIO* self, float x, float y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[419])((IntPtr)self, x, y);
		}

		/// <summary>
		/// Queue a mouse button change<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddMouseButtonEvent(ImGuiIO* self, int button, byte down)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, byte, void>)FuncTable[420])((IntPtr)self, button, down);
		}

		/// <summary>
		/// Queue a mouse wheel update. wheel_y&lt;0: scroll down, wheel_y&gt;0: scroll up, wheel_x&lt;0: scroll right, wheel_x&gt;0: scroll left.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddMouseWheelEvent(ImGuiIO* self, float wheelX, float wheelY)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[421])((IntPtr)self, wheelX, wheelY);
		}

		/// <summary>
		/// Queue a mouse source change (Mouse/TouchScreen/Pen)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseSource, void>)FuncTable[422])((IntPtr)self, source);
		}

		/// <summary>
		/// Queue a mouse hovered viewport. Requires backend to set ImGuiBackendFlags_HasMouseHoveredViewport to call this (for multi-viewport support).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddMouseViewportEvent(ImGuiIO* self, uint id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[423])((IntPtr)self, id);
		}

		/// <summary>
		/// Queue a gain/loss of focus for the application (generally based on OS/platform focus of your window)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddFocusEvent(ImGuiIO* self, byte focused)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[424])((IntPtr)self, focused);
		}

		/// <summary>
		/// Queue a new character input<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddInputCharacter(ImGuiIO* self, uint c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[425])((IntPtr)self, c);
		}

		/// <summary>
		/// Queue a new character input from a UTF-16 character, it can be a surrogate<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddInputCharacterUtf16(ImGuiIO* self, ushort c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, void>)FuncTable[426])((IntPtr)self, c);
		}

		/// <summary>
		/// Queue a new characters input from a UTF-8 string<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOAddInputCharactersUtf8(ImGuiIO* self, byte* str)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[427])((IntPtr)self, (IntPtr)str);
		}

		/// <summary>
		/// [Optional] Specify index for legacy &lt;1.87 IsKeyXXX() functions with native indices + specify native keycode, scancode.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOSetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int nativeKeycode, int nativeScancode, int nativeLegacyIndex)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, int, int, int, void>)FuncTable[428])((IntPtr)self, key, nativeKeycode, nativeScancode, nativeLegacyIndex);
		}

		/// <summary>
		/// Set master flag for accepting key/mouse/text events (default to true). Useful if you have native dialog boxes that are interrupting your application loop/refresh, and you want to disable events being queued while your app is frozen.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOSetAppAcceptingEvents(ImGuiIO* self, byte acceptingEvents)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[429])((IntPtr)self, acceptingEvents);
		}

		/// <summary>
		/// Clear all incoming events.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOClearEventsQueue(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[430])((IntPtr)self);
		}

		/// <summary>
		/// Clear current keyboard/gamepad state + current frame text input buffer. Equivalent to releasing all keys/buttons.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOClearInputKeys(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[431])((IntPtr)self);
		}

		/// <summary>
		/// Clear current mouse state.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOClearInputMouse(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[432])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIO* ImGuiIOImGuiIO()
		{
			return (ImGuiIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[433])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIOImGuiIOConstruct(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[434])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIODestroy(ImGuiIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[435])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextCallbackData* ImGuiInputTextCallbackDataImGuiInputTextCallbackData()
		{
			return (ImGuiInputTextCallbackData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[436])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackDataImGuiInputTextCallbackDataConstruct(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[437])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackDataDestroy(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[438])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackDataDeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytesCount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[439])((IntPtr)self, pos, bytesCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackDataInsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, void>)FuncTable[440])((IntPtr)self, pos, (IntPtr)text, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackDataSelectAll(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[441])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextCallbackDataClearSelection(ImGuiInputTextCallbackData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[442])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiInputTextCallbackDataHasSelection(ImGuiInputTextCallbackData* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[443])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowClass* ImGuiWindowClassImGuiWindowClass()
		{
			return (ImGuiWindowClass*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[444])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowClassImGuiWindowClassConstruct(ImGuiWindowClass* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[445])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowClassDestroy(ImGuiWindowClass* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[446])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPayload* ImGuiPayloadImGuiPayload()
		{
			return (ImGuiPayload*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[447])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPayloadImGuiPayloadConstruct(ImGuiPayload* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[448])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPayloadDestroy(ImGuiPayload* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[449])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPayloadClear(ImGuiPayload* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[450])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiPayloadIsDataType(ImGuiPayload* self, byte* type)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[451])((IntPtr)self, (IntPtr)type);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiPayloadIsPreview(ImGuiPayload* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[452])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiPayloadIsDelivery(ImGuiPayload* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[453])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOnceUponAFrame* ImGuiOnceUponAFrameImGuiOnceUponAFrame()
		{
			return (ImGuiOnceUponAFrame*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[454])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOnceUponAFrameImGuiOnceUponAFrameConstruct(ImGuiOnceUponAFrame* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[455])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOnceUponAFrameDestroy(ImGuiOnceUponAFrame* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[456])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextFilter* ImGuiTextFilterImGuiTextFilter(byte* defaultFilter)
		{
			return (ImGuiTextFilter*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[457])((IntPtr)defaultFilter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilterImGuiTextFilterConstruct(ImGuiTextFilter* self, byte* defaultFilter)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[458])((IntPtr)self, (IntPtr)defaultFilter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilterDestroy(ImGuiTextFilter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[459])((IntPtr)self);
		}

		/// <summary>
		/// Helper calling InputText+Build<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextFilterDraw(ImGuiTextFilter* self, byte* label, float width)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, byte>)FuncTable[460])((IntPtr)self, (IntPtr)label, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextFilterPassFilter(ImGuiTextFilter* self, byte* text, byte* textEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte>)FuncTable[461])((IntPtr)self, (IntPtr)text, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilterBuild(ImGuiTextFilter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[462])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextFilterClear(ImGuiTextFilter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[463])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextFilterIsActive(ImGuiTextFilter* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[464])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextRange* ImGuiTextRangeImGuiTextRange()
		{
			return (ImGuiTextRange*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[465])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRangeImGuiTextRangeNilConstruct(ImGuiTextRange* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[466])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRangeDestroy(ImGuiTextRange* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[467])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextRange* ImGuiTextRangeImGuiTextRange(byte* b, byte* e)
		{
			return (ImGuiTextRange*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[468])((IntPtr)b, (IntPtr)e);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRangeImGuiTextRangeStrConstruct(ImGuiTextRange* self, byte* b, byte* e)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[469])((IntPtr)self, (IntPtr)b, (IntPtr)e);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextRangeEmpty(ImGuiTextRange* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[470])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextRangeSplit(ImGuiTextRange* self, byte separator, ImVector<ImGuiTextRange>* _out)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, IntPtr, void>)FuncTable[471])((IntPtr)self, separator, (IntPtr)_out);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTextBuffer* ImGuiTextBufferImGuiTextBuffer()
		{
			return (ImGuiTextBuffer*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[472])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferImGuiTextBufferConstruct(ImGuiTextBuffer* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[473])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferDestroy(ImGuiTextBuffer* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[474])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextBufferBegin(ImGuiTextBuffer* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[475])((IntPtr)self);
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextBufferEnd(ImGuiTextBuffer* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[476])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiTextBufferSize(ImGuiTextBuffer* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[477])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiTextBufferEmpty(ImGuiTextBuffer* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[478])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferClear(ImGuiTextBuffer* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[479])((IntPtr)self);
		}

		/// <summary>
		/// Similar to resize(0) on ImVector: empty string but don't free buffer.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferResize(ImGuiTextBuffer* self, int size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[480])((IntPtr)self, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferReserve(ImGuiTextBuffer* self, int capacity)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[481])((IntPtr)self, capacity);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextBufferCStr(ImGuiTextBuffer* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[482])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferAppend(ImGuiTextBuffer* self, byte* str, byte* strEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[483])((IntPtr)self, (IntPtr)str, (IntPtr)strEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImGuiStoragePairImGuiStoragePair(uint key, int val)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<uint, int, IntPtr>)FuncTable[484])(key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePairImGuiStoragePairIntConstruct(ImGuiStoragePair* self, uint key, int val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, int, void>)FuncTable[485])((IntPtr)self, key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePairDestroy(ImGuiStoragePair* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[486])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImGuiStoragePairImGuiStoragePair(uint key, float val)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<uint, float, IntPtr>)FuncTable[487])(key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePairImGuiStoragePairFloatConstruct(ImGuiStoragePair* self, uint key, float val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, float, void>)FuncTable[488])((IntPtr)self, key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImGuiStoragePairImGuiStoragePair(uint key, void* val)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr>)FuncTable[489])(key, (IntPtr)val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStoragePairImGuiStoragePairPtrConstruct(ImGuiStoragePair* self, uint key, void* val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, void>)FuncTable[490])((IntPtr)self, key, (IntPtr)val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageClear(ImGuiStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[491])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiStorageGetInt(ImGuiStorage* self, uint key, int defaultVal)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, int, int>)FuncTable[492])((IntPtr)self, key, defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageSetInt(ImGuiStorage* self, uint key, int val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, int, void>)FuncTable[493])((IntPtr)self, key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiStorageGetBool(ImGuiStorage* self, uint key, byte defaultVal)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, byte>)FuncTable[494])((IntPtr)self, key, defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageSetBool(ImGuiStorage* self, uint key, byte val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, void>)FuncTable[495])((IntPtr)self, key, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImGuiStorageGetFloat(ImGuiStorage* self, uint key, float defaultVal)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, float, float>)FuncTable[496])((IntPtr)self, key, defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageSetFloat(ImGuiStorage* self, uint key, float val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, float, void>)FuncTable[497])((IntPtr)self, key, val);
		}

		/// <summary>
		/// default_val is NULL<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* ImGuiStorageGetVoidPtr(ImGuiStorage* self, uint key)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[498])((IntPtr)self, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageSetVoidPtr(ImGuiStorage* self, uint key, void* val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, void>)FuncTable[499])((IntPtr)self, key, (IntPtr)val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int* ImGuiStorageGetIntRef(ImGuiStorage* self, uint key, int defaultVal)
		{
			return (int*)((delegate* unmanaged[Cdecl]<IntPtr, uint, int, IntPtr>)FuncTable[500])((IntPtr)self, key, defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiStorageGetBoolRef(ImGuiStorage* self, uint key, byte defaultVal)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, IntPtr>)FuncTable[501])((IntPtr)self, key, defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float* ImGuiStorageGetFloatRef(ImGuiStorage* self, uint key, float defaultVal)
		{
			return (float*)((delegate* unmanaged[Cdecl]<IntPtr, uint, float, IntPtr>)FuncTable[502])((IntPtr)self, key, defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void** ImGuiStorageGetVoidPtrRef(ImGuiStorage* self, uint key, void* defaultVal)
		{
			return (void**)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, IntPtr>)FuncTable[503])((IntPtr)self, key, (IntPtr)defaultVal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageBuildSortByKey(ImGuiStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[504])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStorageSetAllInt(ImGuiStorage* self, int val)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[505])((IntPtr)self, val);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipper* ImGuiListClipperImGuiListClipper()
		{
			return (ImGuiListClipper*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[506])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperImGuiListClipperConstruct(ImGuiListClipper* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[507])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperDestroy(ImGuiListClipper* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[508])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperBegin(ImGuiListClipper* self, int itemsCount, float itemsHeight)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, float, void>)FuncTable[509])((IntPtr)self, itemsCount, itemsHeight);
		}

		/// <summary>
		/// Automatically called on the last call of Step() that returns false.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperEnd(ImGuiListClipper* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[510])((IntPtr)self);
		}

		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiListClipperStep(ImGuiListClipper* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[511])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperIncludeItemByIndex(ImGuiListClipper* self, int itemIndex)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[512])((IntPtr)self, itemIndex);
		}

		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperIncludeItemsByIndex(ImGuiListClipper* self, int itemBegin, int itemEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[513])((IntPtr)self, itemBegin, itemEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperSeekCursorForItem(ImGuiListClipper* self, int itemIndex)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[514])((IntPtr)self, itemIndex);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColorImColor()
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[515])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorImColorNilConstruct(ImColor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[516])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorDestroy(ImColor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[517])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColorImColor(float r, float g, float b, float a)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[518])(r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorImColorFloatConstruct(ImColor* self, float r, float g, float b, float a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[519])((IntPtr)self, r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColorImColor(Vector4 col)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<Vector4, IntPtr>)FuncTable[520])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorImColorVec4Construct(ImColor* self, Vector4 col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector4, void>)FuncTable[521])((IntPtr)self, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColorImColor(int r, int g, int b, int a)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<int, int, int, int, IntPtr>)FuncTable[522])(r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorImColorIntConstruct(ImColor* self, int r, int g, int b, int a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, void>)FuncTable[523])((IntPtr)self, r, g, b, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImColor* ImColorImColorU32(uint rgba)
		{
			return (ImColor*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[524])(rgba);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorImColorU32Construct(ImColor* self, uint rgba)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[525])((IntPtr)self, rgba);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorSetHSV(ImColor* self, float h, float s, float v, float a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[526])((IntPtr)self, h, s, v, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImColorHSV(ImColor* pOut, float h, float s, float v, float a)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[527])((IntPtr)pOut, h, s, v, a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSelectionBasicStorage* ImGuiSelectionBasicStorageImGuiSelectionBasicStorage()
		{
			return (ImGuiSelectionBasicStorage*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[528])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorageImGuiSelectionBasicStorageConstruct(ImGuiSelectionBasicStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[529])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorageDestroy(ImGuiSelectionBasicStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[530])((IntPtr)self);
		}

		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorageApplyRequests(ImGuiSelectionBasicStorage* self, ImGuiMultiSelectIO* msIo)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[531])((IntPtr)self, (IntPtr)msIo);
		}

		/// <summary>
		/// Query if an item id is in selection.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiSelectionBasicStorageContains(ImGuiSelectionBasicStorage* self, uint id)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, byte>)FuncTable[532])((IntPtr)self, id);
		}

		/// <summary>
		/// Clear selection<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorageClear(ImGuiSelectionBasicStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[533])((IntPtr)self);
		}

		/// <summary>
		/// Swap two selections<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorageSwap(ImGuiSelectionBasicStorage* self, ImGuiSelectionBasicStorage* r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[534])((IntPtr)self, (IntPtr)r);
		}

		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionBasicStorageSetItemSelected(ImGuiSelectionBasicStorage* self, uint id, byte selected)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, void>)FuncTable[535])((IntPtr)self, id, selected);
		}

		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiSelectionBasicStorageGetNextSelectedItem(ImGuiSelectionBasicStorage* self, void** opaqueIt, uint* outId)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte>)FuncTable[536])((IntPtr)self, (IntPtr)opaqueIt, (IntPtr)outId);
		}

		/// <summary>
		/// Convert index to item id based on provided adapter.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiSelectionBasicStorageGetStorageIdFromIndex(ImGuiSelectionBasicStorage* self, int idx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[537])((IntPtr)self, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSelectionExternalStorage* ImGuiSelectionExternalStorageImGuiSelectionExternalStorage()
		{
			return (ImGuiSelectionExternalStorage*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[538])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionExternalStorageImGuiSelectionExternalStorageConstruct(ImGuiSelectionExternalStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[539])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionExternalStorageDestroy(ImGuiSelectionExternalStorage* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[540])((IntPtr)self);
		}

		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSelectionExternalStorageApplyRequests(ImGuiSelectionExternalStorage* self, ImGuiMultiSelectIO* msIo)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[541])((IntPtr)self, (IntPtr)msIo);
		}

		/// <summary>
		/// Also ensure our padding fields are zeroed<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawCmd* ImDrawCmdImDrawCmd()
		{
			return (ImDrawCmd*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[542])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawCmdImDrawCmdConstruct(ImDrawCmd* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[543])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawCmdDestroy(ImDrawCmd* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[544])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImDrawCmdGetTexID(ImDrawCmd* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong>)FuncTable[545])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawListSplitter* ImDrawListSplitterImDrawListSplitter()
		{
			return (ImDrawListSplitter*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[546])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterImDrawListSplitterConstruct(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[547])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterDestroy(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[548])((IntPtr)self);
		}

		/// <summary>
		/// Do not clear Channels[] so our allocations are reused next frame<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterClear(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[549])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterClearFreeMemory(ImDrawListSplitter* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[550])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterSplit(ImDrawListSplitter* self, ImDrawList* drawList, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[551])((IntPtr)self, (IntPtr)drawList, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterMerge(ImDrawListSplitter* self, ImDrawList* drawList)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[552])((IntPtr)self, (IntPtr)drawList);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSplitterSetCurrentChannel(ImDrawListSplitter* self, ImDrawList* drawList, int channelIdx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[553])((IntPtr)self, (IntPtr)drawList, channelIdx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* ImDrawListImDrawList(ImDrawListSharedData* sharedData)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[554])((IntPtr)sharedData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListImDrawListConstruct(ImDrawList* self, ImDrawListSharedData* sharedData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[555])((IntPtr)self, (IntPtr)sharedData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListDestroy(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[556])((IntPtr)self);
		}

		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPushClipRect(ImDrawList* self, Vector2 clipRectMin, Vector2 clipRectMax, byte intersectWithCurrentClipRect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, byte, void>)FuncTable[557])((IntPtr)self, clipRectMin, clipRectMax, intersectWithCurrentClipRect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPushClipRectFullScreen(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[558])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPopClipRect(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[559])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPushTextureID(ImDrawList* self, ulong textureId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ulong, void>)FuncTable[560])((IntPtr)self, textureId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPopTextureID(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[561])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListGetClipRectMin(Vector2* pOut, ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[562])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListGetClipRectMax(Vector2* pOut, ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[563])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, void>)FuncTable[564])((IntPtr)self, p1, p2, col, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddRect(ImDrawList* self, Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, ImDrawFlags, float, void>)FuncTable[565])((IntPtr)self, pMin, pMax, col, rounding, flags, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddRectFilled(ImDrawList* self, Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, ImDrawFlags, void>)FuncTable[566])((IntPtr)self, pMin, pMax, col, rounding, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddRectFilledMultiColor(ImDrawList* self, Vector2 pMin, Vector2 pMax, uint colUprLeft, uint colUprRight, uint colBotRight, uint colBotLeft)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, uint, uint, uint, void>)FuncTable[567])((IntPtr)self, pMin, pMax, colUprLeft, colUprRight, colBotRight, colBotLeft);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, float, void>)FuncTable[568])((IntPtr)self, p1, p2, p3, p4, col, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[569])((IntPtr)self, p1, p2, p3, p4, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, uint, float, void>)FuncTable[570])((IntPtr)self, p1, p2, p3, col, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, uint, void>)FuncTable[571])((IntPtr)self, p1, p2, p3, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, float, void>)FuncTable[572])((IntPtr)self, center, radius, col, numSegments, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, void>)FuncTable[573])((IntPtr)self, center, radius, col, numSegments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, float, void>)FuncTable[574])((IntPtr)self, center, radius, col, numSegments, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, int, void>)FuncTable[575])((IntPtr)self, center, radius, col, numSegments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddEllipse(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int numSegments, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, int, float, void>)FuncTable[576])((IntPtr)self, center, radius, col, rot, numSegments, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddEllipseFilled(ImDrawList* self, Vector2 center, Vector2 radius, uint col, float rot, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, int, void>)FuncTable[577])((IntPtr)self, center, radius, col, rot, numSegments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddText(ImDrawList* self, Vector2 pos, uint col, byte* textBegin, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, IntPtr, IntPtr, void>)FuncTable[578])((IntPtr)self, pos, col, (IntPtr)textBegin, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddText(ImDrawList* self, ImFont* font, float fontSize, Vector2 pos, uint col, byte* textBegin, byte* textEnd, float wrapWidth, Vector4* cpuFineClipRect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, Vector2, uint, IntPtr, IntPtr, float, IntPtr, void>)FuncTable[579])((IntPtr)self, (IntPtr)font, fontSize, pos, col, (IntPtr)textBegin, (IntPtr)textEnd, wrapWidth, (IntPtr)cpuFineClipRect);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, float, int, void>)FuncTable[580])((IntPtr)self, p1, p2, p3, p4, col, thickness, numSegments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, uint, float, int, void>)FuncTable[581])((IntPtr)self, p1, p2, p3, col, thickness, numSegments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddPolyline(ImDrawList* self, Vector2* points, int numPoints, uint col, ImDrawFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, uint, ImDrawFlags, float, void>)FuncTable[582])((IntPtr)self, (IntPtr)points, numPoints, col, flags, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddConvexPolyFilled(ImDrawList* self, Vector2* points, int numPoints, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, uint, void>)FuncTable[583])((IntPtr)self, (IntPtr)points, numPoints, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddConcavePolyFilled(ImDrawList* self, Vector2* points, int numPoints, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, uint, void>)FuncTable[584])((IntPtr)self, (IntPtr)points, numPoints, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddImage(ImDrawList* self, ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ulong, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[585])((IntPtr)self, userTextureId, pMin, pMax, uvMin, uvMax, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddImageQuad(ImDrawList* self, ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ulong, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[586])((IntPtr)self, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddImageRounded(ImDrawList* self, ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ulong, Vector2, Vector2, Vector2, Vector2, uint, float, ImDrawFlags, void>)FuncTable[587])((IntPtr)self, userTextureId, pMin, pMax, uvMin, uvMax, col, rounding, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathClear(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[588])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathLineTo(ImDrawList* self, Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[589])((IntPtr)self, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathLineToMergeDuplicate(ImDrawList* self, Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[590])((IntPtr)self, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathFillConvex(ImDrawList* self, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[591])((IntPtr)self, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathFillConcave(ImDrawList* self, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[592])((IntPtr)self, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, ImDrawFlags, float, void>)FuncTable[593])((IntPtr)self, col, flags, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathArcTo(ImDrawList* self, Vector2 center, float radius, float aMin, float aMax, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, float, int, void>)FuncTable[594])((IntPtr)self, center, radius, aMin, aMax, numSegments);
		}

		/// <summary>
		/// Use precomputed angles for a 12 steps circle<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathArcToFast(ImDrawList* self, Vector2 center, float radius, int aMinOf_12, int aMaxOf_12)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, int, int, void>)FuncTable[595])((IntPtr)self, center, radius, aMinOf_12, aMaxOf_12);
		}

		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathEllipticalArcTo(ImDrawList* self, Vector2 center, Vector2 radius, float rot, float aMin, float aMax, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, float, float, int, void>)FuncTable[596])((IntPtr)self, center, radius, rot, aMin, aMax, numSegments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, int, void>)FuncTable[597])((IntPtr)self, p2, p3, p4, numSegments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, int, void>)FuncTable[598])((IntPtr)self, p2, p3, numSegments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathRect(ImDrawList* self, Vector2 rectMin, Vector2 rectMax, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, ImDrawFlags, void>)FuncTable[599])((IntPtr)self, rectMin, rectMax, rounding, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddCallback(ImDrawList* self, ImDrawCallback callback, void* userdata, uint userdataSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImDrawCallback, IntPtr, uint, void>)FuncTable[600])((IntPtr)self, callback, (IntPtr)userdata, userdataSize);
		}

		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListAddDrawCmd(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[601])((IntPtr)self);
		}

		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* ImDrawListCloneOutput(ImDrawList* self)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[602])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListChannelsSplit(ImDrawList* self, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[603])((IntPtr)self, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListChannelsMerge(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[604])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListChannelsSetCurrent(ImDrawList* self, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[605])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimReserve(ImDrawList* self, int idxCount, int vtxCount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[606])((IntPtr)self, idxCount, vtxCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimUnreserve(ImDrawList* self, int idxCount, int vtxCount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[607])((IntPtr)self, idxCount, vtxCount);
		}

		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, void>)FuncTable[608])((IntPtr)self, a, b, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[609])((IntPtr)self, a, b, uvA, uvB, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uvA, Vector2 uvB, Vector2 uvC, Vector2 uvD, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, Vector2, uint, void>)FuncTable[610])((IntPtr)self, a, b, c, d, uvA, uvB, uvC, uvD, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, void>)FuncTable[611])((IntPtr)self, pos, uv, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimWriteIdx(ImDrawList* self, ushort idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, void>)FuncTable[612])((IntPtr)self, idx);
		}

		/// <summary>
		/// Write vertex with unique index<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, void>)FuncTable[613])((IntPtr)self, pos, uv, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListResetForNewFrame(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[614])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListClearFreeMemory(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[615])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPopUnusedDrawCmd(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[616])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListTryMergeDrawCmds(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[617])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListOnChangedClipRect(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[618])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListOnChangedTextureID(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[619])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListOnChangedVtxOffset(ImDrawList* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[620])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSetTextureID(ImDrawList* self, ulong textureId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ulong, void>)FuncTable[621])((IntPtr)self, textureId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImDrawListCalcCircleAutoSegmentCount(ImDrawList* self, float radius)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, int>)FuncTable[622])((IntPtr)self, radius);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int aMinSample, int aMaxSample, int aStep)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, int, int, int, void>)FuncTable[623])((IntPtr)self, center, radius, aMinSample, aMaxSample, aStep);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListPathArcToN(ImDrawList* self, Vector2 center, float radius, float aMin, float aMax, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, float, int, void>)FuncTable[624])((IntPtr)self, center, radius, aMin, aMax, numSegments);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawData* ImDrawDataImDrawData()
		{
			return (ImDrawData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[625])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataImDrawDataConstruct(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[626])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataDestroy(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[627])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataClear(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[628])((IntPtr)self);
		}

		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataAddDrawList(ImDrawData* self, ImDrawList* drawList)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[629])((IntPtr)self, (IntPtr)drawList);
		}

		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataDeIndexAllBuffers(ImDrawData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[630])((IntPtr)self);
		}

		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataScaleClipRects(ImDrawData* self, Vector2 fbScale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[631])((IntPtr)self, fbScale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontConfig* ImFontConfImFontConf()
		{
			return (ImFontConfig*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[632])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontConfImFontConfConstruct(ImFontConfig* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[633])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontConfDestroy(ImFontConfig* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[634])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilderImFontGlyphRangesBuilder()
		{
			return (ImFontGlyphRangesBuilder*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[635])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderImFontGlyphRangesBuilderConstruct(ImFontGlyphRangesBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[636])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderDestroy(ImFontGlyphRangesBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[637])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderClear(ImFontGlyphRangesBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[638])((IntPtr)self);
		}

		/// <summary>
		/// Get bit n in the array<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontGlyphRangesBuilderGetBit(ImFontGlyphRangesBuilder* self, uint n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, byte>)FuncTable[639])((IntPtr)self, n);
		}

		/// <summary>
		/// Set bit n in the array<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderSetBit(ImFontGlyphRangesBuilder* self, uint n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[640])((IntPtr)self, n);
		}

		/// <summary>
		/// Add character<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderAddChar(ImFontGlyphRangesBuilder* self, ushort c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, void>)FuncTable[641])((IntPtr)self, c);
		}

		/// <summary>
		/// Add string (each character of the UTF-8 string are added)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderAddText(ImFontGlyphRangesBuilder* self, byte* text, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[642])((IntPtr)self, (IntPtr)text, (IntPtr)textEnd);
		}

		/// <summary>
		/// Add ranges, e.g. builder.AddRanges(ImFontAtlas::GetGlyphRangesDefault()) to force add all of ASCII/Latin+Ext<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderAddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[643])((IntPtr)self, (IntPtr)ranges);
		}

		/// <summary>
		/// Output new ranges<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGlyphRangesBuilderBuildRanges(ImFontGlyphRangesBuilder* self, ImVector<ushort>* outRanges)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[644])((IntPtr)self, (IntPtr)outRanges);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontAtlasCustomRect* ImFontAtlasCustomRectImFontAtlasCustomRect()
		{
			return (ImFontAtlasCustomRect*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[645])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasCustomRectImFontAtlasCustomRectConstruct(ImFontAtlasCustomRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[646])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasCustomRectDestroy(ImFontAtlasCustomRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[647])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlasCustomRectIsPacked(ImFontAtlasCustomRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[648])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontAtlas* ImFontAtlasImFontAtlas()
		{
			return (ImFontAtlas*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[649])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasImFontAtlasConstruct(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[650])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasDestroy(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[651])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlasAddFont(ImFontAtlas* self, ImFontConfig* fontCfg)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[652])((IntPtr)self, (IntPtr)fontCfg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlasAddFontDefault(ImFontAtlas* self, ImFontConfig* fontCfg)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[653])((IntPtr)self, (IntPtr)fontCfg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlasAddFontFromFileTTF(ImFontAtlas* self, byte* filename, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>)FuncTable[654])((IntPtr)self, (IntPtr)filename, sizePixels, (IntPtr)fontCfg, (IntPtr)glyphRanges);
		}

		/// <summary>
		/// Note: Transfer ownership of 'ttf_data' to ImFontAtlas! Will be deleted after destruction of the atlas. Set font_cfg-&gt;FontDataOwnedByAtlas=false to keep ownership of your data and it won't be freed.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlasAddFontFromMemoryTTF(ImFontAtlas* self, void* fontData, int fontDataSize, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, IntPtr, IntPtr>)FuncTable[655])((IntPtr)self, (IntPtr)fontData, fontDataSize, sizePixels, (IntPtr)fontCfg, (IntPtr)glyphRanges);
		}

		/// <summary>
		/// 'compressed_font_data' still owned by caller. Compress with binary_to_compressed_c.cpp.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlasAddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressedFontData, int compressedFontDataSize, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, float, IntPtr, IntPtr, IntPtr>)FuncTable[656])((IntPtr)self, (IntPtr)compressedFontData, compressedFontDataSize, sizePixels, (IntPtr)fontCfg, (IntPtr)glyphRanges);
		}

		/// <summary>
		/// 'compressed_font_data_base85' still owned by caller. Compress with binary_to_compressed_c.cpp with -base85 parameter.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontAtlasAddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressedFontDataBase85, float sizePixels, ImFontConfig* fontCfg, ushort* glyphRanges)
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, IntPtr, IntPtr, IntPtr>)FuncTable[657])((IntPtr)self, (IntPtr)compressedFontDataBase85, sizePixels, (IntPtr)fontCfg, (IntPtr)glyphRanges);
		}

		/// <summary>
		/// Clear input data (all ImFontConfig structures including sizes, TTF data, glyph ranges, etc.) = all the data used to build the texture and fonts.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasClearInputData(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[658])((IntPtr)self);
		}

		/// <summary>
		/// Clear input+output font data (same as ClearInputData() + glyphs storage, UV coordinates).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasClearFonts(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[659])((IntPtr)self);
		}

		/// <summary>
		/// Clear output texture data (CPU side). Saves RAM once the texture has been copied to graphics memory.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasClearTexData(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[660])((IntPtr)self);
		}

		/// <summary>
		/// Clear all input and output.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasClear(ImFontAtlas* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[661])((IntPtr)self);
		}

		/// <summary>
		/// Build pixels data. This is called automatically for you by the GetTexData*** functions.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlasBuild(ImFontAtlas* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[662])((IntPtr)self);
		}

		/// <summary>
		/// 1 byte per-pixel<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasGetTexDataAsAlpha8(ImFontAtlas* self, byte** outPixels, int* outWidth, int* outHeight, int* outBytesPerPixel)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[663])((IntPtr)self, (IntPtr)outPixels, (IntPtr)outWidth, (IntPtr)outHeight, (IntPtr)outBytesPerPixel);
		}

		/// <summary>
		/// 4 bytes-per-pixel<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasGetTexDataAsRgba32(ImFontAtlas* self, byte** outPixels, int* outWidth, int* outHeight, int* outBytesPerPixel)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[664])((IntPtr)self, (IntPtr)outPixels, (IntPtr)outWidth, (IntPtr)outHeight, (IntPtr)outBytesPerPixel);
		}

		/// <summary>
		/// Bit ambiguous: used to detect when user didn't build texture but effectively we should check TexID != 0 except that would be backend dependent...<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlasIsBuilt(ImFontAtlas* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[665])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasSetTexID(ImFontAtlas* self, ulong id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ulong, void>)FuncTable[666])((IntPtr)self, id);
		}

		/// <summary>
		/// Basic Latin, Extended Latin<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesDefault(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[667])((IntPtr)self);
		}

		/// <summary>
		/// Default + Greek and Coptic<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesGreek(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[668])((IntPtr)self);
		}

		/// <summary>
		/// Default + Korean characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesKorean(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[669])((IntPtr)self);
		}

		/// <summary>
		/// Default + Hiragana, Katakana, Half-Width, Selection of 2999 Ideographs<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesJapanese(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[670])((IntPtr)self);
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + full set of about 21000 CJK Unified Ideographs<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesChineseFull(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[671])((IntPtr)self);
		}

		/// <summary>
		/// Default + Half-Width + Japanese Hiragana/Katakana + set of 2500 CJK Unified Ideographs for common simplified Chinese<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[672])((IntPtr)self);
		}

		/// <summary>
		/// Default + about 400 Cyrillic characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesCyrillic(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[673])((IntPtr)self);
		}

		/// <summary>
		/// Default + Thai characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesThai(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[674])((IntPtr)self);
		}

		/// <summary>
		/// Default + Vietnamese characters<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort* ImFontAtlasGetGlyphRangesVietnamese(ImFontAtlas* self)
		{
			return (ushort*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[675])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImFontAtlasAddCustomRectRegular(ImFontAtlas* self, int width, int height)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int, int>)FuncTable[676])((IntPtr)self, width, height);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImFontAtlasAddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advanceX, Vector2 offset)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ushort, int, int, float, Vector2, int>)FuncTable[677])((IntPtr)self, (IntPtr)font, id, width, height, advanceX, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontAtlasCustomRect* ImFontAtlasGetCustomRectByIndex(ImFontAtlas* self, int index)
		{
			return (ImFontAtlasCustomRect*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[678])((IntPtr)self, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasCalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* outUvMin, Vector2* outUvMax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[679])((IntPtr)self, (IntPtr)rect, (IntPtr)outUvMin, (IntPtr)outUvMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* ImFontImFont()
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[680])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontImFontConstruct(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[681])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontDestroy(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[682])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontGlyph* ImFontFindGlyph(ImFont* self, ushort c)
		{
			return (ImFontGlyph*)((delegate* unmanaged[Cdecl]<IntPtr, ushort, IntPtr>)FuncTable[683])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontGlyph* ImFontFindGlyphNoFallback(ImFont* self, ushort c)
		{
			return (ImFontGlyph*)((delegate* unmanaged[Cdecl]<IntPtr, ushort, IntPtr>)FuncTable[684])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImFontGetCharAdvance(ImFont* self, ushort c)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ushort, float>)FuncTable[685])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontIsLoaded(ImFont* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[686])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImFontGetDebugName(ImFont* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[687])((IntPtr)self);
		}

		/// <summary>
		/// utf8<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontCalcTextSizeA(Vector2* pOut, ImFont* self, float size, float maxWidth, float wrapWidth, byte* textBegin, byte* textEnd, byte** remaining)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[688])((IntPtr)pOut, (IntPtr)self, size, maxWidth, wrapWidth, (IntPtr)textBegin, (IntPtr)textEnd, (IntPtr)remaining);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImFontCalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* textEnd, float wrapWidth)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, float, IntPtr, IntPtr, float, IntPtr>)FuncTable[689])((IntPtr)self, scale, (IntPtr)text, (IntPtr)textEnd, wrapWidth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontRenderChar(ImFont* self, ImDrawList* drawList, float size, Vector2 pos, uint col, ushort c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, Vector2, uint, ushort, void>)FuncTable[690])((IntPtr)self, (IntPtr)drawList, size, pos, col, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontRenderText(ImFont* self, ImDrawList* drawList, float size, Vector2 pos, uint col, Vector4 clipRect, byte* textBegin, byte* textEnd, float wrapWidth, byte cpuFineClip)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float, Vector2, uint, Vector4, IntPtr, IntPtr, float, byte, void>)FuncTable[691])((IntPtr)self, (IntPtr)drawList, size, pos, col, clipRect, (IntPtr)textBegin, (IntPtr)textEnd, wrapWidth, cpuFineClip);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontBuildLookupTable(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[692])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontClearOutputData(ImFont* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[693])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontGrowIndex(ImFont* self, int newSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[694])((IntPtr)self, newSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAddGlyph(ImFont* self, ImFontConfig* srcCfg, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advanceX)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ushort, float, float, float, float, float, float, float, float, float, void>)FuncTable[695])((IntPtr)self, (IntPtr)srcCfg, c, x0, y0, x1, y1, u0, v0, u1, v1, advanceX);
		}

		/// <summary>
		/// Makes 'dst' character/glyph points to 'src' character/glyph. Currently needs to be called AFTER fonts have been built.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAddRemapChar(ImFont* self, ushort dst, ushort src, byte overwriteDst)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ushort, ushort, byte, void>)FuncTable[696])((IntPtr)self, dst, src, overwriteDst);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontIsGlyphRangeUnused(ImFont* self, uint cBegin, uint cLast)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, byte>)FuncTable[697])((IntPtr)self, cBegin, cLast);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewport* ImGuiViewportImGuiViewport()
		{
			return (ImGuiViewport*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[698])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportImGuiViewportConstruct(ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[699])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportDestroy(ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[700])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportGetCenter(Vector2* pOut, ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[701])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportGetWorkCenter(Vector2* pOut, ImGuiViewport* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[702])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformIO* ImGuiPlatformIOImGuiPlatformIO()
		{
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[703])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIOImGuiPlatformIOConstruct(ImGuiPlatformIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[704])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIODestroy(ImGuiPlatformIO* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[705])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformMonitor* ImGuiPlatformMonitorImGuiPlatformMonitor()
		{
			return (ImGuiPlatformMonitor*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[706])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformMonitorImGuiPlatformMonitorConstruct(ImGuiPlatformMonitor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[707])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformMonitorDestroy(ImGuiPlatformMonitor* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[708])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformImeData* ImGuiPlatformImeDataImGuiPlatformImeData()
		{
			return (ImGuiPlatformImeData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[709])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformImeDataImGuiPlatformImeDataConstruct(ImGuiPlatformImeData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[710])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformImeDataDestroy(ImGuiPlatformImeData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[711])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImHashData(void* data, uint dataSize, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, uint>)FuncTable[712])((IntPtr)data, dataSize, seed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImHashStr(byte* data, uint dataSize, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, uint>)FuncTable[713])((IntPtr)data, dataSize, seed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImQsort(void* _base, uint count, uint sizeOfElement, IgImQsortCompareFunc compareFunc)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, uint, IgImQsortCompareFunc, void>)FuncTable[714])((IntPtr)_base, count, sizeOfElement, compareFunc);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImAlphaBlendColors(uint colA, uint colB)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint, uint>)FuncTable[715])(colA, colB);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImIsPowerOfTwo(int v)
		{
			return ((delegate* unmanaged[Cdecl]<int, byte>)FuncTable[716])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImIsPowerOfTwo(ulong v)
		{
			return ((delegate* unmanaged[Cdecl]<ulong, byte>)FuncTable[717])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImUpperPowerOfTwo(int v)
		{
			return ((delegate* unmanaged[Cdecl]<int, int>)FuncTable[718])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImCountSetBits(uint v)
		{
			return ((delegate* unmanaged[Cdecl]<uint, uint>)FuncTable[719])(v);
		}

		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImStricmp(byte* str1, byte* str2)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[720])((IntPtr)str1, (IntPtr)str2);
		}

		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImStrnicmp(byte* str1, byte* str2, uint count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, int>)FuncTable[721])((IntPtr)str1, (IntPtr)str2, count);
		}

		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImStrncpy(byte* dst, byte* src, uint count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, void>)FuncTable[722])((IntPtr)dst, (IntPtr)src, count);
		}

		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStrdup(byte* str)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[723])((IntPtr)str);
		}

		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStrdupcpy(byte* dst, uint* pDstSize, byte* str)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr>)FuncTable[724])((IntPtr)dst, (IntPtr)pDstSize, (IntPtr)str);
		}

		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStrchrRange(byte* strBegin, byte* strEnd, byte c)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, IntPtr>)FuncTable[725])((IntPtr)strBegin, (IntPtr)strEnd, c);
		}

		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStreolRange(byte* str, byte* strEnd)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[726])((IntPtr)str, (IntPtr)strEnd);
		}

		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStristr(byte* haystack, byte* haystackEnd, byte* needle, byte* needleEnd)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)FuncTable[727])((IntPtr)haystack, (IntPtr)haystackEnd, (IntPtr)needle, (IntPtr)needleEnd);
		}

		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImStrTrimBlanks(byte* str)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[728])((IntPtr)str);
		}

		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStrSkipBlank(byte* str)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[729])((IntPtr)str);
		}

		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImStrlenW(ushort* str)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[730])((IntPtr)str);
		}

		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImStrbol(byte* bufMidLine, byte* bufBegin)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[731])((IntPtr)bufMidLine, (IntPtr)bufBegin);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImToUpper(byte c)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte>)FuncTable[732])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImCharIsBlankA(byte c)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte>)FuncTable[733])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImCharIsBlankW(uint c)
		{
			return ((delegate* unmanaged[Cdecl]<uint, byte>)FuncTable[734])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImCharIsXditA(byte c)
		{
			return ((delegate* unmanaged[Cdecl]<byte, byte>)FuncTable[735])(c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImFormatString(byte* buf, uint bufSize, byte* fmt)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr, int>)FuncTable[736])((IntPtr)buf, bufSize, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFormatStringToTempBuffer(byte** outBuf, byte** outBufEnd, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[737])((IntPtr)outBuf, (IntPtr)outBufEnd, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImParseFormatFindStart(byte* format)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[738])((IntPtr)format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImParseFormatFindEnd(byte* format)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[739])((IntPtr)format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImParseFormatTrimDecorations(byte* format, byte* buf, uint bufSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, IntPtr>)FuncTable[740])((IntPtr)format, (IntPtr)buf, bufSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImParseFormatSanitizeForPrinting(byte* fmtIn, byte* fmtOut, uint fmtOutSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, void>)FuncTable[741])((IntPtr)fmtIn, (IntPtr)fmtOut, fmtOutSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImParseFormatSanitizeForScanning(byte* fmtIn, byte* fmtOut, uint fmtOutSize)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, IntPtr>)FuncTable[742])((IntPtr)fmtIn, (IntPtr)fmtOut, fmtOutSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImParseFormatPrecision(byte* format, int defaultValue)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int>)FuncTable[743])((IntPtr)format, defaultValue);
		}

		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImTextCharToUtf8(byte* outBuf, uint c)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[744])((IntPtr)outBuf, c);
		}

		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextStrToUtf8(byte* outBuf, int outBufSize, ushort* inText, ushort* inTextEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, int>)FuncTable[745])((IntPtr)outBuf, outBufSize, (IntPtr)inText, (IntPtr)inTextEnd);
		}

		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextCharFromUtf8(uint* outChar, byte* inText, byte* inTextEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int>)FuncTable[746])((IntPtr)outChar, (IntPtr)inText, (IntPtr)inTextEnd);
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextStrFromUtf8(ushort* outBuf, int outBufSize, byte* inText, byte* inTextEnd, byte** inRemaining)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, IntPtr, IntPtr, int>)FuncTable[747])((IntPtr)outBuf, outBufSize, (IntPtr)inText, (IntPtr)inTextEnd, (IntPtr)inRemaining);
		}

		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextCountCharsFromUtf8(byte* inText, byte* inTextEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[748])((IntPtr)inText, (IntPtr)inTextEnd);
		}

		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextCountUtf8BytesFromChar(byte* inText, byte* inTextEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[749])((IntPtr)inText, (IntPtr)inTextEnd);
		}

		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextCountUtf8BytesFromStr(ushort* inText, ushort* inTextEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[750])((IntPtr)inText, (IntPtr)inTextEnd);
		}

		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImTextFindPreviousUtf8Codepoint(byte* inTextStart, byte* inTextCurr)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[751])((IntPtr)inTextStart, (IntPtr)inTextCurr);
		}

		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImTextCountLines(byte* inText, byte* inTextEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[752])((IntPtr)inText, (IntPtr)inTextEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* ImFileOpen(byte* filename, byte* mode)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[753])((IntPtr)filename, (IntPtr)mode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFileClose(void* file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[754])((IntPtr)file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImFileGetSize(void* file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong>)FuncTable[755])((IntPtr)file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImFileRead(void* data, ulong size, ulong count, void* file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong, ulong, IntPtr, ulong>)FuncTable[756])((IntPtr)data, size, count, (IntPtr)file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ImFileWrite(void* data, ulong size, ulong count, void* file)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ulong, ulong, IntPtr, ulong>)FuncTable[757])((IntPtr)data, size, count, (IntPtr)file);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* ImFileLoadToMemory(byte* filename, byte* mode, uint* outFileSize, int paddingBytes)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, IntPtr>)FuncTable[758])((IntPtr)filename, (IntPtr)mode, (IntPtr)outFileSize, paddingBytes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImPowFloat(float x, float y)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float>)FuncTable[759])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImPowDouble(double x, double y)
		{
			return ((delegate* unmanaged[Cdecl]<double, double, double>)FuncTable[760])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImLogFloat(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[761])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImLogDouble(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[762])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImAbsInt(int x)
		{
			return ((delegate* unmanaged[Cdecl]<int, int>)FuncTable[763])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImAbsFloat(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[764])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImAbsDouble(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[765])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImSnFloat(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[766])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImSnDouble(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[767])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRsqrtFloat(float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[768])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ImRsqrtDouble(double x)
		{
			return ((delegate* unmanaged[Cdecl]<double, double>)FuncTable[769])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[770])((IntPtr)pOut, lhs, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[771])((IntPtr)pOut, lhs, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[772])((IntPtr)pOut, v, mn, mx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImLerp(Vector2* pOut, Vector2 a, Vector2 b, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, void>)FuncTable[773])((IntPtr)pOut, a, b, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImLerp(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[774])((IntPtr)pOut, a, b, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImLerp(Vector4* pOut, Vector4 a, Vector4 b, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector4, Vector4, float, void>)FuncTable[775])((IntPtr)pOut, a, b, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImSaturate(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[776])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImLengthSqr(Vector2 lhs)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, float>)FuncTable[777])(lhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImLengthSqr(Vector4 lhs)
		{
			return ((delegate* unmanaged[Cdecl]<Vector4, float>)FuncTable[778])(lhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImInvLength(Vector2 lhs, float failValue)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, float, float>)FuncTable[779])(lhs, failValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImTruncFloat(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[780])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImTruncVec2(Vector2* pOut, Vector2 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[781])((IntPtr)pOut, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImFloorFloat(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, float>)FuncTable[782])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFloorVec2(Vector2* pOut, Vector2 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[783])((IntPtr)pOut, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImModPositive(int a, int b)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, int>)FuncTable[784])(a, b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImDot(Vector2 a, Vector2 b)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, float>)FuncTable[785])(a, b);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRotate(Vector2* pOut, Vector2 v, float cosA, float sinA)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, void>)FuncTable[786])((IntPtr)pOut, v, cosA, sinA);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImLinearSweep(float current, float target, float speed)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float>)FuncTable[787])(current, target, speed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImLinearRemapClamp(float s0, float s1, float d0, float d1, float x)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float, float, float>)FuncTable[788])(s0, s1, d0, d1, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[789])((IntPtr)pOut, lhs, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImIsFloatAboveGuaranteedIntegerPrecision(float f)
		{
			return ((delegate* unmanaged[Cdecl]<float, byte>)FuncTable[790])(f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImExponentialMovingAverage(float avg, float sample, int n)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, int, float>)FuncTable[791])(avg, sample, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, float, void>)FuncTable[792])((IntPtr)pOut, p1, p2, p3, p4, t);
		}

		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int numSegments)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, int, void>)FuncTable[793])((IntPtr)pOut, p1, p2, p3, p4, p, numSegments);
		}

		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tessTol)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, Vector2, float, void>)FuncTable[794])((IntPtr)pOut, p1, p2, p3, p4, p, tessTol);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, float, void>)FuncTable[795])((IntPtr)pOut, p1, p2, p3, t);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, void>)FuncTable[796])((IntPtr)pOut, a, b, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, Vector2, byte>)FuncTable[797])(a, b, c, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, void>)FuncTable[798])((IntPtr)pOut, a, b, c, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* outU, float* outV, float* outW)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, Vector2, IntPtr, IntPtr, IntPtr, void>)FuncTable[799])(a, b, c, p, (IntPtr)outU, (IntPtr)outV, (IntPtr)outW);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImTriangleArea(Vector2 a, Vector2 b, Vector2 c)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, float>)FuncTable[800])(a, b, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, Vector2, Vector2, byte>)FuncTable[801])(a, b, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec1* ImVec1ImVec1()
		{
			return (ImVec1*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[802])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec1ImVec1NilConstruct(ImVec1* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[803])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec1Destroy(ImVec1* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[804])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec1* ImVec1ImVec1(float x)
		{
			return (ImVec1*)((delegate* unmanaged[Cdecl]<float, IntPtr>)FuncTable[805])(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec1ImVec1FloatConstruct(ImVec1* self, float x)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[806])((IntPtr)self, x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec2Ih* ImVec2IhImVec2Ih()
		{
			return (ImVec2Ih*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[807])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2IhImVec2IhNilConstruct(ImVec2Ih* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[808])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2IhDestroy(ImVec2Ih* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[809])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec2Ih* ImVec2IhImVec2IhShort(short x, short y)
		{
			return (ImVec2Ih*)((delegate* unmanaged[Cdecl]<short, short, IntPtr>)FuncTable[810])(x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2IhImVec2IhShortConstruct(ImVec2Ih* self, short x, short y)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, short, short, void>)FuncTable[811])((IntPtr)self, x, y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVec2Ih* ImVec2IhImVec2Ih(Vector2 rhs)
		{
			return (ImVec2Ih*)((delegate* unmanaged[Cdecl]<Vector2, IntPtr>)FuncTable[812])(rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVec2IhImVec2IhVec2Construct(ImVec2Ih* self, Vector2 rhs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[813])((IntPtr)self, rhs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRectImRect()
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[814])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectImRectNilConstruct(ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[815])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectDestroy(ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[816])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRectImRect(Vector2 min, Vector2 max)
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<Vector2, Vector2, IntPtr>)FuncTable[817])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectImRectVec2Construct(ImRect* self, Vector2 min, Vector2 max)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[818])((IntPtr)self, min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRectImRect(Vector4 v)
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<Vector4, IntPtr>)FuncTable[819])(v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectImRectVec4Construct(ImRect* self, Vector4 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector4, void>)FuncTable[820])((IntPtr)self, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImRect* ImRectImRect(float x1, float y1, float x2, float y2)
		{
			return (ImRect*)((delegate* unmanaged[Cdecl]<float, float, float, float, IntPtr>)FuncTable[821])(x1, y1, x2, y2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectImRectFloatConstruct(ImRect* self, float x1, float y1, float x2, float y2)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, void>)FuncTable[822])((IntPtr)self, x1, y1, x2, y2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectGetCenter(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[823])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectGetSize(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[824])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRectGetWidth(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[825])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRectGetHeht(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[826])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImRectGetArea(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[827])((IntPtr)self);
		}

		/// <summary>
		/// Top-left<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectGetTL(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[828])((IntPtr)pOut, (IntPtr)self);
		}

		/// <summary>
		/// Top-right<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectGetTR(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[829])((IntPtr)pOut, (IntPtr)self);
		}

		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectGetBL(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[830])((IntPtr)pOut, (IntPtr)self);
		}

		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectGetBR(Vector2* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[831])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRectContainsVec2(ImRect* self, Vector2 p)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, byte>)FuncTable[832])((IntPtr)self, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRectContainsRect(ImRect* self, ImRect r)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, byte>)FuncTable[833])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRectContainsWithPad(ImRect* self, Vector2 p, Vector2 pad)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, byte>)FuncTable[834])((IntPtr)self, p, pad);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRectOverlaps(ImRect* self, ImRect r)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, byte>)FuncTable[835])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectAddVec2(ImRect* self, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[836])((IntPtr)self, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectAddRect(ImRect* self, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[837])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectExpand(ImRect* self, float amount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[838])((IntPtr)self, amount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectExpand(ImRect* self, Vector2 amount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[839])((IntPtr)self, amount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectTranslate(ImRect* self, Vector2 d)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, void>)FuncTable[840])((IntPtr)self, d);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectTranslateX(ImRect* self, float dx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[841])((IntPtr)self, dx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectTranslateY(ImRect* self, float dy)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[842])((IntPtr)self, dy);
		}

		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectClipWith(ImRect* self, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[843])((IntPtr)self, r);
		}

		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectClipWithFull(ImRect* self, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[844])((IntPtr)self, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectFloor(ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[845])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImRectIsInverted(ImRect* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[846])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImRectToVec4(Vector4* pOut, ImRect* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[847])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImBitArrayGetStorageSizeInBytes(int bitcount)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint>)FuncTable[848])(bitcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitArrayClearAllBits(uint* arr, int bitcount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[849])((IntPtr)arr, bitcount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImBitArrayTestBit(uint* arr, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[850])((IntPtr)arr, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitArrayClearBit(uint* arr, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[851])((IntPtr)arr, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitArraySetBit(uint* arr, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[852])((IntPtr)arr, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitArraySetBitRange(uint* arr, int n, int n2)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, void>)FuncTable[853])((IntPtr)arr, n, n2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVectorCreate(ImBitVector* self, int sz)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[854])((IntPtr)self, sz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVectorClear(ImBitVector* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[855])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImBitVectorTestBit(ImBitVector* self, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, byte>)FuncTable[856])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVectorSetBit(ImBitVector* self, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[857])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImBitVectorClearBit(ImBitVector* self, int n)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[858])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextIndexClear(ImGuiTextIndex* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[859])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiTextIndexSize(ImGuiTextIndex* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[860])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextIndexGetLineBegin(ImGuiTextIndex* self, byte* _base, int n)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr>)FuncTable[861])((IntPtr)self, (IntPtr)_base, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiTextIndexGetLineEnd(ImGuiTextIndex* self, byte* _base, int n)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, IntPtr>)FuncTable[862])((IntPtr)self, (IntPtr)_base, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextIndexAppend(ImGuiTextIndex* self, byte* _base, int oldSize, int newSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, void>)FuncTable[863])((IntPtr)self, (IntPtr)_base, oldSize, newSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStoragePair* ImLowerBound(ImGuiStoragePair* inBegin, ImGuiStoragePair* inEnd, uint key)
		{
			return (ImGuiStoragePair*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, IntPtr>)FuncTable[864])((IntPtr)inBegin, (IntPtr)inEnd, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawListSharedData* ImDrawListSharedDataImDrawListSharedData()
		{
			return (ImDrawListSharedData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[865])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSharedDataImDrawListSharedDataConstruct(ImDrawListSharedData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[866])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSharedDataDestroy(ImDrawListSharedData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[867])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawListSharedDataSetCircleTessellationMaxError(ImDrawListSharedData* self, float maxError)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[868])((IntPtr)self, maxError);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawDataBuilder* ImDrawDataBuilderImDrawDataBuilder()
		{
			return (ImDrawDataBuilder*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[869])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataBuilderImDrawDataBuilderConstruct(ImDrawDataBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[870])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImDrawDataBuilderDestroy(ImDrawDataBuilder* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[871])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void* ImGuiStyleVarInfoGetVarPtr(ImGuiStyleVarInfo* self, void* parent)
		{
			return (void*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[872])((IntPtr)self, (IntPtr)parent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleMod* ImGuiStyleModImGuiStyleMod(ImGuiStyleVar idx, int v)
		{
			return (ImGuiStyleMod*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, int, IntPtr>)FuncTable[873])(idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleModImGuiStyleModIntConstruct(ImGuiStyleMod* self, ImGuiStyleVar idx, int v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiStyleVar, int, void>)FuncTable[874])((IntPtr)self, idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleModDestroy(ImGuiStyleMod* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[875])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleMod* ImGuiStyleModImGuiStyleMod(ImGuiStyleVar idx, float v)
		{
			return (ImGuiStyleMod*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, float, IntPtr>)FuncTable[876])(idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleModImGuiStyleModFloatConstruct(ImGuiStyleMod* self, ImGuiStyleVar idx, float v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiStyleVar, float, void>)FuncTable[877])((IntPtr)self, idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleMod* ImGuiStyleModImGuiStyleMod(ImGuiStyleVar idx, Vector2 v)
		{
			return (ImGuiStyleMod*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, Vector2, IntPtr>)FuncTable[878])(idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStyleModImGuiStyleModVec2Construct(ImGuiStyleMod* self, ImGuiStyleVar idx, Vector2 v)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiStyleVar, Vector2, void>)FuncTable[879])((IntPtr)self, idx, v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiComboPreviewData* ImGuiComboPreviewDataImGuiComboPreviewData()
		{
			return (ImGuiComboPreviewData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[880])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiComboPreviewDataImGuiComboPreviewDataConstruct(ImGuiComboPreviewData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[881])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiComboPreviewDataDestroy(ImGuiComboPreviewData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[882])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMenuColumns* ImGuiMenuColumnsImGuiMenuColumns()
		{
			return (ImGuiMenuColumns*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[883])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumnsImGuiMenuColumnsConstruct(ImGuiMenuColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[884])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumnsDestroy(ImGuiMenuColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[885])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumnsUpdate(ImGuiMenuColumns* self, float spacing, byte windowReappearing)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, byte, void>)FuncTable[886])((IntPtr)self, spacing, windowReappearing);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImGuiMenuColumnsDeclColumns(ImGuiMenuColumns* self, float wIcon, float wLabel, float wShortcut, float wMark)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, float, float, float, float>)FuncTable[887])((IntPtr)self, wIcon, wLabel, wShortcut, wMark);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMenuColumnsCalcNextTotalWidth(ImGuiMenuColumns* self, byte updateOffsets)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[888])((IntPtr)self, updateOffsets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextDeactivatedState* ImGuiInputTextDeactivatedStateImGuiInputTextDeactivatedState()
		{
			return (ImGuiInputTextDeactivatedState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[889])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextDeactivatedStateImGuiInputTextDeactivatedStateConstruct(ImGuiInputTextDeactivatedState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[890])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextDeactivatedStateDestroy(ImGuiInputTextDeactivatedState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[891])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextDeactivatedStateClearFreeMemory(ImGuiInputTextDeactivatedState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[892])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextState* ImGuiInputTextStateImGuiInputTextState()
		{
			return (ImGuiInputTextState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[893])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateImGuiInputTextStateConstruct(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[894])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateDestroy(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[895])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateClearText(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[896])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateClearFreeMemory(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[897])((IntPtr)self);
		}

		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateOnKeyPressed(ImGuiInputTextState* self, int key)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[898])((IntPtr)self, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateOnCharPressed(ImGuiInputTextState* self, uint c)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[899])((IntPtr)self, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateCursorAnimReset(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[900])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateCursorClamp(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[901])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiInputTextStateHasSelection(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[902])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateClearSelection(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[903])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiInputTextStateGetCursorPos(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[904])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiInputTextStateGetSelectionStart(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[905])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ImGuiInputTextStateGetSelectionEnd(ImGuiInputTextState* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[906])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateSelectAll(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[907])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateReloadUserBufAndSelectAll(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[908])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateReloadUserBufAndKeepSelection(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[909])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputTextStateReloadUserBufAndMoveToEnd(ImGuiInputTextState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[910])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiNextWindowData* ImGuiNextWindowDataImGuiNextWindowData()
		{
			return (ImGuiNextWindowData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[911])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextWindowDataImGuiNextWindowDataConstruct(ImGuiNextWindowData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[912])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextWindowDataDestroy(ImGuiNextWindowData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[913])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextWindowDataClearFlags(ImGuiNextWindowData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[914])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiNextItemData* ImGuiNextItemDataImGuiNextItemData()
		{
			return (ImGuiNextItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[915])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextItemDataImGuiNextItemDataConstruct(ImGuiNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[916])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextItemDataDestroy(ImGuiNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[917])((IntPtr)self);
		}

		/// <summary>
		/// Also cleared manually by ItemAdd()!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNextItemDataClearFlags(ImGuiNextItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[918])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiLastItemData* ImGuiLastItemDataImGuiLastItemData()
		{
			return (ImGuiLastItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[919])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiLastItemDataImGuiLastItemDataConstruct(ImGuiLastItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[920])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiLastItemDataDestroy(ImGuiLastItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[921])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiErrorRecoveryState* ImGuiErrorRecoveryStateImGuiErrorRecoveryState()
		{
			return (ImGuiErrorRecoveryState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[922])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiErrorRecoveryStateImGuiErrorRecoveryStateConstruct(ImGuiErrorRecoveryState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[923])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiErrorRecoveryStateDestroy(ImGuiErrorRecoveryState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[924])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPtrOrIndex* ImGuiPtrOrIndexImGuiPtrOrIndex(void* ptr)
		{
			return (ImGuiPtrOrIndex*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[925])((IntPtr)ptr);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPtrOrIndexImGuiPtrOrIndexPtrConstruct(ImGuiPtrOrIndex* self, void* ptr)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[926])((IntPtr)self, (IntPtr)ptr);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPtrOrIndexDestroy(ImGuiPtrOrIndex* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[927])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPtrOrIndex* ImGuiPtrOrIndexImGuiPtrOrIndex(int index)
		{
			return (ImGuiPtrOrIndex*)((delegate* unmanaged[Cdecl]<int, IntPtr>)FuncTable[928])(index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPtrOrIndexImGuiPtrOrIndexIntConstruct(ImGuiPtrOrIndex* self, int index)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[929])((IntPtr)self, index);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPopupData* ImGuiPopupDataImGuiPopupData()
		{
			return (ImGuiPopupData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[930])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPopupDataImGuiPopupDataConstruct(ImGuiPopupData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[931])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPopupDataDestroy(ImGuiPopupData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[932])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputEvent* ImGuiInputEventImGuiInputEvent()
		{
			return (ImGuiInputEvent*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[933])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputEventImGuiInputEventConstruct(ImGuiInputEvent* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[934])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiInputEventDestroy(ImGuiInputEvent* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[935])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyRoutingData* ImGuiKeyRoutingDataImGuiKeyRoutingData()
		{
			return (ImGuiKeyRoutingData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[936])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingDataImGuiKeyRoutingDataConstruct(ImGuiKeyRoutingData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[937])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingDataDestroy(ImGuiKeyRoutingData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[938])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyRoutingTable* ImGuiKeyRoutingTableImGuiKeyRoutingTable()
		{
			return (ImGuiKeyRoutingTable*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[939])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingTableImGuiKeyRoutingTableConstruct(ImGuiKeyRoutingTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[940])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingTableDestroy(ImGuiKeyRoutingTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[941])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyRoutingTableClear(ImGuiKeyRoutingTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[942])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyOwnerData* ImGuiKeyOwnerDataImGuiKeyOwnerData()
		{
			return (ImGuiKeyOwnerData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[943])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyOwnerDataImGuiKeyOwnerDataConstruct(ImGuiKeyOwnerData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[944])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiKeyOwnerDataDestroy(ImGuiKeyOwnerData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[945])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipperRange ImGuiListClipperRangeFromIndices(int min, int max)
		{
			return ((delegate* unmanaged[Cdecl]<int, int, ImGuiListClipperRange>)FuncTable[946])(min, max);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipperRange ImGuiListClipperRangeFromPositions(float y1, float y2, int offMin, int offMax)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, int, int, ImGuiListClipperRange>)FuncTable[947])(y1, y2, offMin, offMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiListClipperData* ImGuiListClipperDataImGuiListClipperData()
		{
			return (ImGuiListClipperData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[948])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperDataImGuiListClipperDataConstruct(ImGuiListClipperData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[949])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperDataDestroy(ImGuiListClipperData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[950])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiListClipperDataReset(ImGuiListClipperData* self, ImGuiListClipper* clipper)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[951])((IntPtr)self, (IntPtr)clipper);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiNavItemData* ImGuiNavItemDataImGuiNavItemData()
		{
			return (ImGuiNavItemData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[952])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNavItemDataImGuiNavItemDataConstruct(ImGuiNavItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[953])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNavItemDataDestroy(ImGuiNavItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[954])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiNavItemDataClear(ImGuiNavItemData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[955])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTypingSelectState* ImGuiTypingSelectStateImGuiTypingSelectState()
		{
			return (ImGuiTypingSelectState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[956])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTypingSelectStateImGuiTypingSelectStateConstruct(ImGuiTypingSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[957])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTypingSelectStateDestroy(ImGuiTypingSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[958])((IntPtr)self);
		}

		/// <summary>
		/// We preserve remaining data for easier debugging<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTypingSelectStateClear(ImGuiTypingSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[959])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOldColumnData* ImGuiOldColumnDataImGuiOldColumnData()
		{
			return (ImGuiOldColumnData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[960])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumnDataImGuiOldColumnDataConstruct(ImGuiOldColumnData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[961])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumnDataDestroy(ImGuiOldColumnData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[962])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOldColumns* ImGuiOldColumnsImGuiOldColumns()
		{
			return (ImGuiOldColumns*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[963])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumnsImGuiOldColumnsConstruct(ImGuiOldColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[964])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiOldColumnsDestroy(ImGuiOldColumns* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[965])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiBoxSelectState* ImGuiBoxSelectStateImGuiBoxSelectState()
		{
			return (ImGuiBoxSelectState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[966])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiBoxSelectStateImGuiBoxSelectStateConstruct(ImGuiBoxSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[967])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiBoxSelectStateDestroy(ImGuiBoxSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[968])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectTempData* ImGuiMultiSelectTempDataImGuiMultiSelectTempData()
		{
			return (ImGuiMultiSelectTempData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[969])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempDataImGuiMultiSelectTempDataConstruct(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[970])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempDataDestroy(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[971])((IntPtr)self);
		}

		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempDataClear(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[972])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectTempDataClearIO(ImGuiMultiSelectTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[973])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectState* ImGuiMultiSelectStateImGuiMultiSelectState()
		{
			return (ImGuiMultiSelectState*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[974])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectStateImGuiMultiSelectStateConstruct(ImGuiMultiSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[975])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiMultiSelectStateDestroy(ImGuiMultiSelectState* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[976])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* ImGuiDockNodeImGuiDockNode(uint id)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[977])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNodeImGuiDockNodeConstruct(ImGuiDockNode* self, uint id)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[978])((IntPtr)self, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNodeDestroy(ImGuiDockNode* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[979])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsRootNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[980])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsDockSpace(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[981])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsFloatingNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[982])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsCentralNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[983])((IntPtr)self);
		}

		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsHiddenTabBar(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[984])((IntPtr)self);
		}

		/// <summary>
		/// Never show a tab bar<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsNoTabBar(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[985])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsSplitNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[986])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsLeafNode(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[987])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImGuiDockNodeIsEmpty(ImGuiDockNode* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[988])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNodeRect(ImRect* pOut, ImGuiDockNode* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[989])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNodeSetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDockNodeFlags, void>)FuncTable[990])((IntPtr)self, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockNodeUpdateMergedFlags(ImGuiDockNode* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[991])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockContext* ImGuiDockContextImGuiDockContext()
		{
			return (ImGuiDockContext*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[992])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockContextImGuiDockContextConstruct(ImGuiDockContext* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[993])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDockContextDestroy(ImGuiDockContext* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[994])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewportP* ImGuiViewportPImGuiViewportP()
		{
			return (ImGuiViewportP*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[995])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPImGuiViewportPConstruct(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[996])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPDestroy(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[997])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPClearRequestFlags(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[998])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPCalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 insetMin)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[999])((IntPtr)pOut, (IntPtr)self, insetMin);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPCalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 insetMin, Vector2 insetMax)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, Vector2, void>)FuncTable[1000])((IntPtr)pOut, (IntPtr)self, insetMin, insetMax);
		}

		/// <summary>
		/// Update public fields<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPUpdateWorkRect(ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1001])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPGetMainRect(ImRect* pOut, ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1002])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPGetWorkRect(ImRect* pOut, ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1003])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiViewportPGetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1004])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* ImGuiWindowSettingsImGuiWindowSettings()
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1005])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowSettingsImGuiWindowSettingsConstruct(ImGuiWindowSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1006])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowSettingsDestroy(ImGuiWindowSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1007])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* ImGuiWindowSettingsGetName(ImGuiWindowSettings* self)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1008])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSettingsHandler* ImGuiSettingsHandlerImGuiSettingsHandler()
		{
			return (ImGuiSettingsHandler*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1009])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSettingsHandlerImGuiSettingsHandlerConstruct(ImGuiSettingsHandler* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1010])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiSettingsHandlerDestroy(ImGuiSettingsHandler* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1011])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDebugAllocInfo* ImGuiDebugAllocInfoImGuiDebugAllocInfo()
		{
			return (ImGuiDebugAllocInfo*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1012])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDebugAllocInfoImGuiDebugAllocInfoConstruct(ImGuiDebugAllocInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1013])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiDebugAllocInfoDestroy(ImGuiDebugAllocInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1014])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStackLevelInfo* ImGuiStackLevelInfoImGuiStackLevelInfo()
		{
			return (ImGuiStackLevelInfo*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1015])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStackLevelInfoImGuiStackLevelInfoConstruct(ImGuiStackLevelInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1016])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiStackLevelInfoDestroy(ImGuiStackLevelInfo* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1017])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIdStackTool* ImGuiIdStackToolImGuiIdStackTool()
		{
			return (ImGuiIdStackTool*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1018])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIdStackToolImGuiIdStackToolConstruct(ImGuiIdStackTool* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1019])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiIdStackToolDestroy(ImGuiIdStackTool* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1020])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContextHook* ImGuiContextHookImGuiContextHook()
		{
			return (ImGuiContextHook*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1021])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContextHookImGuiContextHookConstruct(ImGuiContextHook* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1022])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContextHookDestroy(ImGuiContextHook* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1023])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiContext* ImGuiContextImGuiContext(ImFontAtlas* sharedFontAtlas)
		{
			return (ImGuiContext*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1024])((IntPtr)sharedFontAtlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContextImGuiContextConstruct(ImGuiContext* self, ImFontAtlas* sharedFontAtlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1025])((IntPtr)self, (IntPtr)sharedFontAtlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiContextDestroy(ImGuiContext* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1026])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* ImGuiWindowImGuiWindow(ImGuiContext* context, byte* name)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[1027])((IntPtr)context, (IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowImGuiWindowConstruct(ImGuiWindow* self, ImGuiContext* context, byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1028])((IntPtr)self, (IntPtr)context, (IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowDestroy(ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1029])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindowGetID(ImGuiWindow* self, byte* str, byte* strEnd)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, uint>)FuncTable[1030])((IntPtr)self, (IntPtr)str, (IntPtr)strEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindowGetID(ImGuiWindow* self, void* ptr)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[1031])((IntPtr)self, (IntPtr)ptr);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindowGetID(ImGuiWindow* self, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1032])((IntPtr)self, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindowGetIdFromPos(ImGuiWindow* self, Vector2 pAbs)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint>)FuncTable[1033])((IntPtr)self, pAbs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ImGuiWindowGetIdFromRectangle(ImGuiWindow* self, ImRect rAbs)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, uint>)FuncTable[1034])((IntPtr)self, rAbs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowRect(ImRect* pOut, ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1035])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ImGuiWindowCalcFontSize(ImGuiWindow* self)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float>)FuncTable[1036])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowTitleBarRect(ImRect* pOut, ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1037])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiWindowMenuBarRect(ImRect* pOut, ImGuiWindow* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1038])((IntPtr)pOut, (IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* ImGuiTabItemImGuiTabItem()
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1039])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabItemImGuiTabItemConstruct(ImGuiTabItem* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1040])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabItemDestroy(ImGuiTabItem* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1041])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabBar* ImGuiTabBarImGuiTabBar()
		{
			return (ImGuiTabBar*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1042])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabBarImGuiTabBarConstruct(ImGuiTabBar* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1043])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTabBarDestroy(ImGuiTabBar* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1044])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumn* ImGuiTableColumnImGuiTableColumn()
		{
			return (ImGuiTableColumn*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1045])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnImGuiTableColumnConstruct(ImGuiTableColumn* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1046])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnDestroy(ImGuiTableColumn* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1047])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableInstanceData* ImGuiTableInstanceDataImGuiTableInstanceData()
		{
			return (ImGuiTableInstanceData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1048])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableInstanceDataImGuiTableInstanceDataConstruct(ImGuiTableInstanceData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1049])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableInstanceDataDestroy(ImGuiTableInstanceData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1050])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTable* ImGuiTableImGuiTable()
		{
			return (ImGuiTable*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1051])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableImGuiTableConstruct(ImGuiTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1052])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableDestroy(ImGuiTable* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1053])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableTempData* ImGuiTableTempDataImGuiTableTempData()
		{
			return (ImGuiTableTempData*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1054])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableTempDataImGuiTableTempDataConstruct(ImGuiTableTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1055])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableTempDataDestroy(ImGuiTableTempData* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1056])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnSettings* ImGuiTableColumnSettingsImGuiTableColumnSettings()
		{
			return (ImGuiTableColumnSettings*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1057])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSettingsImGuiTableColumnSettingsConstruct(ImGuiTableColumnSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1058])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableColumnSettingsDestroy(ImGuiTableColumnSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1059])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* ImGuiTableSettingsImGuiTableSettings()
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1060])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSettingsImGuiTableSettingsConstruct(ImGuiTableSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1061])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTableSettingsDestroy(ImGuiTableSettings* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1062])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableColumnSettings* ImGuiTableSettingsGetColumnSettings(ImGuiTableSettings* self)
		{
			return (ImGuiTableColumnSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1063])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiIO* GetIO(ImGuiContext* ctx)
		{
			return (ImGuiIO*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1064])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformIO* GetPlatformIO(ImGuiContext* ctx)
		{
			return (ImGuiPlatformIO*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1065])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* GetCurrentWindowRead()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1066])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* GetCurrentWindow()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1067])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* FindWindowByID(uint id)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1068])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* FindWindowByName(byte* name)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1069])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parentWindow)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiWindowFlags, IntPtr, void>)FuncTable[1070])((IntPtr)window, flags, (IntPtr)parentWindow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdateWindowSkipRefresh(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1071])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1072])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potentialParent, byte popupHierarchy, byte dockHierarchy)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte, byte>)FuncTable[1073])((IntPtr)window, (IntPtr)potentialParent, popupHierarchy, dockHierarchy);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potentialParent)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1074])((IntPtr)window, (IntPtr)potentialParent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowAbove(ImGuiWindow* potentialAbove, ImGuiWindow* potentialBelow)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1075])((IntPtr)potentialAbove, (IntPtr)potentialBelow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowNavFocusable(ImGuiWindow* window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1076])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowPos(ImGuiWindow* window, Vector2 pos, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[1077])((IntPtr)window, pos, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowSize(ImGuiWindow* window, Vector2 size, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiCond, void>)FuncTable[1078])((IntPtr)window, size, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowCollapsed(ImGuiWindow* window, byte collapsed, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, ImGuiCond, void>)FuncTable[1079])((IntPtr)window, collapsed, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, void>)FuncTable[1080])((IntPtr)window, pos, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1081])((IntPtr)window);
		}

		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parentWindow)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1082])((IntPtr)window, (IntPtr)parentWindow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, void>)FuncTable[1083])((IntPtr)pOut, (IntPtr)window, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, void>)FuncTable[1084])((IntPtr)pOut, (IntPtr)window, r);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WindowPosAbsToRel(Vector2* pOut, ImGuiWindow* window, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[1085])((IntPtr)pOut, (IntPtr)window, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WindowPosRelToAbs(Vector2* pOut, ImGuiWindow* window, Vector2 p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[1086])((IntPtr)pOut, (IntPtr)window, p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiFocusRequestFlags, void>)FuncTable[1087])((IntPtr)window, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FocusTopMostWindowUnderOne(ImGuiWindow* underThisWindow, ImGuiWindow* ignoreWindow, ImGuiViewport* filterViewport, ImGuiFocusRequestFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiFocusRequestFlags, void>)FuncTable[1088])((IntPtr)underThisWindow, (IntPtr)ignoreWindow, (IntPtr)filterViewport, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BringWindowToFocusFront(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1089])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BringWindowToDisplayFront(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1090])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BringWindowToDisplayBack(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1091])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* aboveWindow)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1092])((IntPtr)window, (IntPtr)aboveWindow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FindWindowDisplayIndex(ImGuiWindow* window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[1093])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1094])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiWindowRefreshFlags, void>)FuncTable[1095])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentFont(ImFont* font)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1096])((IntPtr)font);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFont* GetDefaultFont()
		{
			return (ImFont*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1097])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushPasswordFont()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1098])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawList* GetForegroundDrawList(ImGuiWindow* window)
		{
			return (ImDrawList*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1099])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddDrawListToDrawDataEx(ImDrawData* drawData, ImVector<ImDrawListPtr>* outList, ImDrawList* drawList)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1100])((IntPtr)drawData, (IntPtr)outList, (IntPtr)drawList);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Initialize()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1101])();
		}

		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Shutdown()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1102])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdateInputEvents(byte trickleFastInputs)
		{
			((delegate* unmanaged[Cdecl]<byte, void>)FuncTable[1103])(trickleFastInputs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdateHoveredWindowAndCaptureFlags()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1104])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FindHoveredWindowEx(Vector2 pos, byte findFirstAndInAnyViewport, ImGuiWindow** outHoveredWindow, ImGuiWindow** outHoveredWindowUnderMovingWindow)
		{
			((delegate* unmanaged[Cdecl]<Vector2, byte, IntPtr, IntPtr, void>)FuncTable[1105])(pos, findFirstAndInAnyViewport, (IntPtr)outHoveredWindow, (IntPtr)outHoveredWindowUnderMovingWindow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StartMouseMovingWindow(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1106])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void StartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[1107])((IntPtr)window, (IntPtr)node, undock);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdateMouseMovingWindowNewFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1108])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UpdateMouseMovingWindowEndFrame()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1109])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint AddContextHook(ImGuiContext* context, ImGuiContextHook* hook)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint>)FuncTable[1110])((IntPtr)context, (IntPtr)hook);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RemoveContextHook(ImGuiContext* context, uint hookToRemove)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[1111])((IntPtr)context, hookToRemove);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CallContextHooks(ImGuiContext* context, ImGuiContextHookType type)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiContextHookType, void>)FuncTable[1112])((IntPtr)context, type);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 oldPos, Vector2 newPos, Vector2 oldSize, Vector2 newSize)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, Vector2, Vector2, void>)FuncTable[1113])((IntPtr)viewport, oldPos, newPos, oldSize, newSize);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ScaleWindowsInViewport(ImGuiViewportP* viewport, float scale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1114])((IntPtr)viewport, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DestroyPlatformWindow(ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1115])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1116])((IntPtr)window, (IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1117])((IntPtr)window, (IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiPlatformMonitor* GetViewportPlatformMonitor(ImGuiViewport* viewport)
		{
			return (ImGuiPlatformMonitor*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1118])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiViewportP* FindHoveredViewportFromPlatformWindowStack(Vector2 mousePlatformPos)
		{
			return (ImGuiViewportP*)((delegate* unmanaged[Cdecl]<Vector2, IntPtr>)FuncTable[1119])(mousePlatformPos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MarkIniSettingsDirty()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1120])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MarkIniSettingsDirty(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1121])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearIniSettings()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1122])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddSettingsHandler(ImGuiSettingsHandler* handler)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1123])((IntPtr)handler);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RemoveSettingsHandler(byte* typeName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1124])((IntPtr)typeName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSettingsHandler* FindSettingsHandler(byte* typeName)
		{
			return (ImGuiSettingsHandler*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1125])((IntPtr)typeName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* CreateNewWindowSettings(byte* name)
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1126])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* FindWindowSettingsByID(uint id)
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1127])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindowSettings* FindWindowSettingsByWindow(ImGuiWindow* window)
		{
			return (ImGuiWindowSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1128])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearWindowSettings(byte* name)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1129])((IntPtr)name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LocalizeRegisterEntries(ImGuiLocEntry* entries, int count)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1130])((IntPtr)entries, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* LocalizeGetMsg(ImGuiLocKey key)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<ImGuiLocKey, IntPtr>)FuncTable[1131])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollX(ImGuiWindow* window, float scrollX)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1132])((IntPtr)window, scrollX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollY(ImGuiWindow* window, float scrollY)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1133])((IntPtr)window, scrollY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollFromPosX(ImGuiWindow* window, float localX, float centerXRatio)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[1134])((IntPtr)window, localX, centerXRatio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetScrollFromPosY(ImGuiWindow* window, float localY, float centerYRatio)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, float, void>)FuncTable[1135])((IntPtr)window, localY, centerYRatio);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ScrollToItem(ImGuiScrollFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiScrollFlags, void>)FuncTable[1136])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiScrollFlags, void>)FuncTable[1137])((IntPtr)window, rect, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, ImGuiScrollFlags, void>)FuncTable[1138])((IntPtr)pOut, (IntPtr)window, rect, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[1139])((IntPtr)window, rect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiItemStatusFlags GetItemStatusFlags()
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiItemStatusFlags>)FuncTable[1140])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiItemFlags GetItemFlags()
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiItemFlags>)FuncTable[1141])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetActiveID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1142])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetFocusID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1143])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetActiveID(uint id, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, void>)FuncTable[1144])(id, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetFocusID(uint id, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, void>)FuncTable[1145])(id, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearActiveID()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1146])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetHoveredID()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1147])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHoveredID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1148])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void KeepAliveID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1149])(id);
		}

		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MarkItemEdited(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1150])(id);
		}

		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushOverrideID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1151])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetIdWithSeed(byte* strIdBegin, byte* strIdEnd, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, uint, uint>)FuncTable[1152])((IntPtr)strIdBegin, (IntPtr)strIdEnd, seed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetIdWithSeed(int n, uint seed)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint, uint>)FuncTable[1153])(n, seed);
		}

		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemSize(Vector2 size, float textBaselineY)
		{
			((delegate* unmanaged[Cdecl]<Vector2, float, void>)FuncTable[1154])(size, textBaselineY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ItemSize(ImRect bb, float textBaselineY)
		{
			((delegate* unmanaged[Cdecl]<ImRect, float, void>)FuncTable[1155])(bb, textBaselineY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ItemAdd(ImRect bb, uint id, ImRect* navBb, ImGuiItemFlags extraFlags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, ImGuiItemFlags, byte>)FuncTable[1156])(bb, id, (IntPtr)navBb, extraFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ItemHoverable(ImRect bb, uint id, ImGuiItemFlags itemFlags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiItemFlags, byte>)FuncTable[1157])(bb, id, itemFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiHoveredFlags, byte>)FuncTable[1158])((IntPtr)window, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsClippedEx(ImRect bb, uint id)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, byte>)FuncTable[1159])(bb, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetLastItemData(uint itemId, ImGuiItemFlags itemFlags, ImGuiItemStatusFlags statusFlags, ImRect itemRect)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiItemFlags, ImGuiItemStatusFlags, ImRect, void>)FuncTable[1160])(itemId, itemFlags, statusFlags, itemRect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CalcItemSize(Vector2* pOut, Vector2 size, float defaultW, float defaultH)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, float, void>)FuncTable[1161])((IntPtr)pOut, size, defaultW, defaultH);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CalcWrapWidthForPos(Vector2 pos, float wrapPosX)
		{
			return ((delegate* unmanaged[Cdecl]<Vector2, float, float>)FuncTable[1162])(pos, wrapPosX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushMultiItemsWidths(int components, float widthFull)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[1163])(components, widthFull);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShrinkWidths(ImGuiShrinkWidthItem* items, int count, float widthExcess)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, float, void>)FuncTable[1164])((IntPtr)items, count, widthExcess);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiStyleVarInfo* GetStyleVarInfo(ImGuiStyleVar idx)
		{
			return (ImGuiStyleVarInfo*)((delegate* unmanaged[Cdecl]<ImGuiStyleVar, IntPtr>)FuncTable[1165])(idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginDisabledOverrideReenable()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1166])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndDisabledOverrideReenable()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1167])();
		}

		/// <summary>
		/// -&gt; BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogBegin(ImGuiLogFlags flags, int autoOpenDepth)
		{
			((delegate* unmanaged[Cdecl]<ImGuiLogFlags, int, void>)FuncTable[1168])(flags, autoOpenDepth);
		}

		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogToBuffer(int autoOpenDepth)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[1169])(autoOpenDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogRenderedText(Vector2* refPos, byte* text, byte* textEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1170])((IntPtr)refPos, (IntPtr)text, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void LogSetNextTextDecoration(byte* prefix, byte* suffix)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1171])((IntPtr)prefix, (IntPtr)suffix);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginChildEx(byte* name, uint id, Vector2 sizeArg, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, Vector2, ImGuiChildFlags, ImGuiWindowFlags, byte>)FuncTable[1172])((IntPtr)name, id, sizeArg, childFlags, windowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopupEx(uint id, ImGuiWindowFlags extraWindowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiWindowFlags, byte>)FuncTable[1173])(id, extraWindowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginPopupMenuEx(uint id, byte* label, ImGuiWindowFlags extraWindowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, IntPtr, ImGuiWindowFlags, byte>)FuncTable[1174])(id, (IntPtr)label, extraWindowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void OpenPopupEx(uint id, ImGuiPopupFlags popupFlags)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiPopupFlags, void>)FuncTable[1175])(id, popupFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClosePopupToLevel(int remaining, byte restoreFocusToWindowUnderPopup)
		{
			((delegate* unmanaged[Cdecl]<int, byte, void>)FuncTable[1176])(remaining, restoreFocusToWindowUnderPopup);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClosePopupsOverWindow(ImGuiWindow* refWindow, byte restoreFocusToWindowUnderPopup)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[1177])((IntPtr)refWindow, restoreFocusToWindowUnderPopup);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClosePopupsExceptModals()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1178])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsPopupOpen(uint id, ImGuiPopupFlags popupFlags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiPopupFlags, byte>)FuncTable[1179])(id, popupFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1180])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* GetTopMostPopupModal()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1181])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* GetTopMostAndVisiblePopupModal()
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1182])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiWindow* FindBlockingModal(ImGuiWindow* window)
		{
			return (ImGuiWindow*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1183])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1184])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FindBestWindowPosForPopupEx(Vector2* pOut, Vector2 refPos, Vector2 size, ImGuiDir* lastDir, ImRect rOuter, ImRect rAvoid, ImGuiPopupPositionPolicy policy)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, IntPtr, ImRect, ImRect, ImGuiPopupPositionPolicy, void>)FuncTable[1185])((IntPtr)pOut, refPos, size, (IntPtr)lastDir, rOuter, rAvoid, policy);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTooltipEx(ImGuiTooltipFlags tooltipFlags, ImGuiWindowFlags extraWindowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiTooltipFlags, ImGuiWindowFlags, byte>)FuncTable[1186])(tooltipFlags, extraWindowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTooltipHidden()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1187])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags windowFlags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiDir, float, ImGuiWindowFlags, byte>)FuncTable[1188])((IntPtr)name, (IntPtr)viewport, dir, size, windowFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginMenuEx(byte* label, byte* icon, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, byte>)FuncTable[1189])((IntPtr)label, (IntPtr)icon, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte MenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, byte, byte>)FuncTable[1190])((IntPtr)label, (IntPtr)icon, (IntPtr)shortcut, selected, enabled);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginComboPopup(uint popupId, ImRect bb, ImGuiComboFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImRect, ImGuiComboFlags, byte>)FuncTable[1191])(popupId, bb, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginComboPreview()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1192])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndComboPreview()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1193])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavInitWindow(ImGuiWindow* window, byte forceReinit)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[1194])((IntPtr)window, forceReinit);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavInitRequestApplyResult()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1195])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte NavMoveRequestButNoResultYet()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1196])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestSubmit(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDir, ImGuiDir, ImGuiNavMoveFlags, ImGuiScrollFlags, void>)FuncTable[1197])(moveDir, clipDir, moveFlags, scrollFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestForward(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDir, ImGuiDir, ImGuiNavMoveFlags, ImGuiScrollFlags, void>)FuncTable[1198])(moveDir, clipDir, moveFlags, scrollFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestResolveWithLastItem(ImGuiNavItemData* result)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1199])((IntPtr)result);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* treeNodeData)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1200])((IntPtr)result, (IntPtr)treeNodeData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestCancel()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1201])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestApplyResult()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1202])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags moveFlags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiNavMoveFlags, void>)FuncTable[1203])((IntPtr)window, moveFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavHhlhtActivated(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1204])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavClearPreferredPosForAxis(ImGuiAxis axis)
		{
			((delegate* unmanaged[Cdecl]<ImGuiAxis, void>)FuncTable[1205])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNavCursorVisibleAfterMove()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1206])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void NavUpdateCurrentWindowIsScrollPushableX()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1207])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNavWindow(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1208])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNavID(uint id, ImGuiNavLayer navLayer, uint focusScopeId, ImRect rectRel)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiNavLayer, uint, ImRect, void>)FuncTable[1209])(id, navLayer, focusScopeId, rectRel);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNavFocusScope(uint focusScopeId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1210])(focusScopeId);
		}

		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void FocusItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1211])();
		}

		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ActivateItemByID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1212])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsNamedKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1213])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsNamedKeyOrMod(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1214])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLegacyKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1215])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyboardKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1216])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsGamepadKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1217])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1218])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsAliasKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1219])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsLrModKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, byte>)FuncTable[1220])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int FixupKeyChord(int keyChord)
		{
			return ((delegate* unmanaged[Cdecl]<int, int>)FuncTable[1221])(keyChord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKey ConvertSingleModFlagToKey(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiKey>)FuncTable[1222])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyData* GetKeyData(ImGuiContext* ctx, ImGuiKey key)
		{
			return (ImGuiKeyData*)((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, IntPtr>)FuncTable[1223])((IntPtr)ctx, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyData* GetKeyData(ImGuiKey key)
		{
			return (ImGuiKeyData*)((delegate* unmanaged[Cdecl]<ImGuiKey, IntPtr>)FuncTable[1224])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* GetKeyChordName(int keyChord)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<int, IntPtr>)FuncTable[1225])(keyChord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKey MouseButtonToKey(ImGuiMouseButton button)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, ImGuiKey>)FuncTable[1226])(button);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseDragPastThreshold(ImGuiMouseButton button, float lockThreshold)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, float, byte>)FuncTable[1227])(button, lockThreshold);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetKeyMagnitude2D(Vector2* pOut, ImGuiKey keyLeft, ImGuiKey keyRight, ImGuiKey keyUp, ImGuiKey keyDown)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, ImGuiKey, ImGuiKey, ImGuiKey, void>)FuncTable[1228])((IntPtr)pOut, keyLeft, keyRight, keyUp, keyDown);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetNavTweakPressedAmount(ImGuiAxis axis)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiAxis, float>)FuncTable[1229])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int CalcTypematicRepeatAmount(float t0, float t1, float repeatDelay, float repeatRate)
		{
			return ((delegate* unmanaged[Cdecl]<float, float, float, float, int>)FuncTable[1230])(t0, t1, repeatDelay, repeatRate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetTypematicRepeatRate(ImGuiInputFlags flags, float* repeatDelay, float* repeatRate)
		{
			((delegate* unmanaged[Cdecl]<ImGuiInputFlags, IntPtr, IntPtr, void>)FuncTable[1231])(flags, (IntPtr)repeatDelay, (IntPtr)repeatRate);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TeleportMousePos(Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<Vector2, void>)FuncTable[1232])(pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetActiveIdUsingAllKeyboardKeys()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1233])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsActiveIdUsingNavDir(ImGuiDir dir)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDir, byte>)FuncTable[1234])(dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetKeyOwner(ImGuiKey key)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint>)FuncTable[1235])(key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyOwner(ImGuiKey key, uint ownerId, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, uint, ImGuiInputFlags, void>)FuncTable[1236])(key, ownerId, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetKeyOwnersForKeyChord(int key, uint ownerId, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<int, uint, ImGuiInputFlags, void>)FuncTable[1237])(key, ownerId, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, void>)FuncTable[1238])(key, flags);
		}

		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TestKeyOwner(ImGuiKey key, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1239])(key, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyOwnerData* GetKeyOwnerData(ImGuiContext* ctx, ImGuiKey key)
		{
			return (ImGuiKeyOwnerData*)((delegate* unmanaged[Cdecl]<IntPtr, ImGuiKey, IntPtr>)FuncTable[1240])((IntPtr)ctx, key);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyDown(ImGuiKey key, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1241])(key, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, ImGuiInputFlags, uint, byte>)FuncTable[1242])(key, flags, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyReleased(ImGuiKey key, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiKey, uint, byte>)FuncTable[1243])(key, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsKeyChordPressed(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImGuiInputFlags, uint, byte>)FuncTable[1244])(keyChord, flags, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseDown(ImGuiMouseButton button, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, uint, byte>)FuncTable[1245])(button, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, ImGuiInputFlags, uint, byte>)FuncTable[1246])(button, flags, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseReleased(ImGuiMouseButton button, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, uint, byte>)FuncTable[1247])(button, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsMouseDoubleClicked(ImGuiMouseButton button, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiMouseButton, uint, byte>)FuncTable[1248])(button, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte Shortcut(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImGuiInputFlags, uint, byte>)FuncTable[1249])(keyChord, flags, ownerId);
		}

		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SetShortcutRouting(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<int, ImGuiInputFlags, uint, byte>)FuncTable[1250])(keyChord, flags, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TestShortcutRouting(int keyChord, uint ownerId)
		{
			return ((delegate* unmanaged[Cdecl]<int, uint, byte>)FuncTable[1251])(keyChord, ownerId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiKeyRoutingData* GetShortcutRoutingData(int keyChord)
		{
			return (ImGuiKeyRoutingData*)((delegate* unmanaged[Cdecl]<int, IntPtr>)FuncTable[1252])(keyChord);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextInitialize(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1253])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextShutdown(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1254])((IntPtr)ctx);
		}

		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextClearNodes(ImGuiContext* ctx, uint rootId, byte clearSettingsRefs)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, byte, void>)FuncTable[1255])((IntPtr)ctx, rootId, clearSettingsRefs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextRebuildNodes(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1256])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextNewFrameUpdateUndocking(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1257])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextNewFrameUpdateDocking(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1258])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextEndFrame(ImGuiContext* ctx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1259])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint DockContextGenNodeID(ImGuiContext* ctx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[1260])((IntPtr)ctx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* targetNode, ImGuiWindow* payload, ImGuiDir splitDir, float splitRatio, byte splitOuter)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, ImGuiDir, float, byte, void>)FuncTable[1261])((IntPtr)ctx, (IntPtr)target, (IntPtr)targetNode, (IntPtr)payload, splitDir, splitRatio, splitOuter);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1262])((IntPtr)ctx, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1263])((IntPtr)ctx, (IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window, byte clearPersistentDockingRef)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[1264])((IntPtr)ctx, (IntPtr)window, clearPersistentDockingRef);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1265])((IntPtr)ctx, (IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* targetNode, ImGuiWindow* payloadWindow, ImGuiDockNode* payloadNode, ImGuiDir splitDir, byte splitOuter, Vector2* outPos)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, ImGuiDir, byte, IntPtr, byte>)FuncTable[1266])((IntPtr)target, (IntPtr)targetNode, (IntPtr)payloadWindow, (IntPtr)payloadNode, splitDir, splitOuter, (IntPtr)outPos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* DockContextFindNodeByID(ImGuiContext* ctx, uint id)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[1267])((IntPtr)ctx, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockNodeWindowMenuHandlerDefault(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tabBar)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1268])((IntPtr)ctx, (IntPtr)node, (IntPtr)tabBar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DockNodeBeginAmendTabBar(ImGuiDockNode* node)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1269])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockNodeEndAmendTabBar()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1270])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* DockNodeGetRootNode(ImGuiDockNode* node)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1271])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1272])((IntPtr)node, (IntPtr)parent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DockNodeGetDepth(ImGuiDockNode* node)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int>)FuncTable[1273])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint DockNodeGetWindowMenuButtonId(ImGuiDockNode* node)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint>)FuncTable[1274])((IntPtr)node);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* GetWindowDockNode()
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1275])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte GetWindowAlwaysWantOwnTabBar(ImGuiWindow* window)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1276])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginDocked(ImGuiWindow* window, byte* pOpen)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1277])((IntPtr)window, (IntPtr)pOpen);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginDockableDragDropSource(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1278])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginDockableDragDropTarget(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1279])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowDock(ImGuiWindow* window, uint dockId, ImGuiCond cond)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, ImGuiCond, void>)FuncTable[1280])((IntPtr)window, dockId, cond);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderDockWindow(byte* windowName, uint nodeId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[1281])((IntPtr)windowName, nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* DockBuilderGetNode(uint nodeId)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1282])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDockNode* DockBuilderGetCentralNode(uint nodeId)
		{
			return (ImGuiDockNode*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1283])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint DockBuilderAddNode(uint nodeId, ImGuiDockNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiDockNodeFlags, uint>)FuncTable[1284])(nodeId, flags);
		}

		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderRemoveNode(uint nodeId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1285])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderRemoveNodeDockedWindows(uint nodeId, byte clearSettingsRefs)
		{
			((delegate* unmanaged[Cdecl]<uint, byte, void>)FuncTable[1286])(nodeId, clearSettingsRefs);
		}

		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderRemoveNodeChildNodes(uint nodeId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1287])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderSetNodePos(uint nodeId, Vector2 pos)
		{
			((delegate* unmanaged[Cdecl]<uint, Vector2, void>)FuncTable[1288])(nodeId, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderSetNodeSize(uint nodeId, Vector2 size)
		{
			((delegate* unmanaged[Cdecl]<uint, Vector2, void>)FuncTable[1289])(nodeId, size);
		}

		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint DockBuilderSplitNode(uint nodeId, ImGuiDir splitDir, float sizeRatioForNodeAtDir, uint* outIdAtDir, uint* outIdAtOppositeDir)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiDir, float, IntPtr, IntPtr, uint>)FuncTable[1290])(nodeId, splitDir, sizeRatioForNodeAtDir, (IntPtr)outIdAtDir, (IntPtr)outIdAtOppositeDir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderCopyDockSpace(uint srcDockspaceId, uint dstDockspaceId, ImVector<ImPointer<byte>>* inWindowRemapPairs)
		{
			((delegate* unmanaged[Cdecl]<uint, uint, IntPtr, void>)FuncTable[1291])(srcDockspaceId, dstDockspaceId, (IntPtr)inWindowRemapPairs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderCopyNode(uint srcNodeId, uint dstNodeId, ImVector<uint>* outNodeRemapPairs)
		{
			((delegate* unmanaged[Cdecl]<uint, uint, IntPtr, void>)FuncTable[1292])(srcNodeId, dstNodeId, (IntPtr)outNodeRemapPairs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderCopyWindowSettings(byte* srcName, byte* dstName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1293])((IntPtr)srcName, (IntPtr)dstName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DockBuilderFinish(uint nodeId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1294])(nodeId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushFocusScope(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1295])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopFocusScope()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1296])();
		}

		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetCurrentFocusScope()
		{
			return ((delegate* unmanaged[Cdecl]<uint>)FuncTable[1297])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsDragDropActive()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1298])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginDragDropTargetCustom(ImRect bb, uint id)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, byte>)FuncTable[1299])(bb, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ClearDragDrop()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1300])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsDragDropPayloadBeingAccepted()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1301])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderDragDropTargetRect(ImRect bb, ImRect itemClipRect)
		{
			((delegate* unmanaged[Cdecl]<ImRect, ImRect, void>)FuncTable[1302])(bb, itemClipRect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTypingSelectRequest* GetTypingSelectRequest(ImGuiTypingSelectFlags flags)
		{
			return (ImGuiTypingSelectRequest*)((delegate* unmanaged[Cdecl]<ImGuiTypingSelectFlags, IntPtr>)FuncTable[1303])(flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TypingSelectFindMatch(ImGuiTypingSelectRequest* req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, void* userData, int navItemIdx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IgTypingSelectFindMatchGetItemNameFunc, IntPtr, int, int>)FuncTable[1304])((IntPtr)req, itemsCount, getItemNameFunc, (IntPtr)userData, navItemIdx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, void* userData, int navItemIdx)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IgTypingSelectFindMatchGetItemNameFunc, IntPtr, int, int>)FuncTable[1305])((IntPtr)req, itemsCount, getItemNameFunc, (IntPtr)userData, navItemIdx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, void* userData)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, IgTypingSelectFindMatchGetItemNameFunc, IntPtr, int>)FuncTable[1306])((IntPtr)req, itemsCount, getItemNameFunc, (IntPtr)userData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginBoxSelect(ImRect scopeRect, ImGuiWindow* window, uint boxSelectId, ImGuiMultiSelectFlags msFlags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, IntPtr, uint, ImGuiMultiSelectFlags, byte>)FuncTable[1307])(scopeRect, (IntPtr)window, boxSelectId, msFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndBoxSelect(ImRect scopeRect, ImGuiMultiSelectFlags msFlags)
		{
			((delegate* unmanaged[Cdecl]<ImRect, ImGuiMultiSelectFlags, void>)FuncTable[1308])(scopeRect, msFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MultiSelectItemHeader(uint id, byte* pSelected, ImGuiButtonFlags* pButtonFlags)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr, void>)FuncTable[1309])(id, (IntPtr)pSelected, (IntPtr)pButtonFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MultiSelectItemFooter(uint id, byte* pSelected, byte* pPressed)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr, void>)FuncTable[1310])(id, (IntPtr)pSelected, (IntPtr)pPressed);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, void>)FuncTable[1311])((IntPtr)ms, selected);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void MultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int rangeDir, long firstItem, long lastItem)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, byte, int, long, long, void>)FuncTable[1312])((IntPtr)ms, selected, rangeDir, firstItem, lastItem);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiBoxSelectState* GetBoxSelectState(uint id)
		{
			return (ImGuiBoxSelectState*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1313])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiMultiSelectState* GetMultiSelectState(uint id)
		{
			return (ImGuiMultiSelectState*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1314])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clipRect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, void>)FuncTable[1315])((IntPtr)window, clipRect);
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BeginColumns(byte* strId, int count, ImGuiOldColumnFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, ImGuiOldColumnFlags, void>)FuncTable[1316])((IntPtr)strId, count, flags);
		}

		/// <summary>
		/// close columns<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndColumns()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1317])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColumnClipRect(int columnIndex)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[1318])(columnIndex);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PushColumnsBackground()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1319])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void PopColumnsBackground()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1320])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetColumnsID(byte* strId, int count)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1321])((IntPtr)strId, count);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiOldColumns* FindOrCreateColumns(ImGuiWindow* window, uint id)
		{
			return (ImGuiOldColumns*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[1322])((IntPtr)window, id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offsetNorm)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, float>)FuncTable[1323])((IntPtr)columns, offsetNorm);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GetColumnNormFromOffset(ImGuiOldColumns* columns, float offset)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, float, float>)FuncTable[1324])((IntPtr)columns, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableOpenContextMenu(int columnN)
		{
			((delegate* unmanaged[Cdecl]<int, void>)FuncTable[1325])(columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetColumnWidth(int columnN, float width)
		{
			((delegate* unmanaged[Cdecl]<int, float, void>)FuncTable[1326])(columnN, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetColumnSortDirection(int columnN, ImGuiSortDirection sortDirection, byte appendToSortSpecs)
		{
			((delegate* unmanaged[Cdecl]<int, ImGuiSortDirection, byte, void>)FuncTable[1327])(columnN, sortDirection, appendToSortSpecs);
		}

		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TableGetHoveredRow()
		{
			return ((delegate* unmanaged[Cdecl]<int>)FuncTable[1328])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TableGetHeaderRowHeht()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1329])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TableGetHeaderAngledMaxLabelWidth()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1330])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TablePushBackgroundChannel()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1331])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TablePopBackgroundChannel()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1332])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableAngledHeadersRowEx(uint rowId, float angle, float maxLabelWidth, ImGuiTableHeaderData* data, int dataCount)
		{
			((delegate* unmanaged[Cdecl]<uint, float, float, IntPtr, int, void>)FuncTable[1333])(rowId, angle, maxLabelWidth, (IntPtr)data, dataCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTable* GetCurrentTable()
		{
			return (ImGuiTable*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1334])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTable* TableFindByID(uint id)
		{
			return (ImGuiTable*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1335])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTableEx(byte* name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, uint, int, ImGuiTableFlags, Vector2, float, byte>)FuncTable[1336])((IntPtr)name, id, columnsCount, flags, outerSize, innerWidth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableBeginInitMemory(ImGuiTable* table, int columnsCount)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1337])((IntPtr)table, columnsCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableBeginApplyRequests(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1338])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetupDrawChannels(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1339])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableUpdateLayout(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1340])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableUpdateBorders(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1341])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableUpdateColumnsWehtFromWidth(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1342])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableDrawBorders(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1343])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flagsForSectionToDisplay)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTableFlags, void>)FuncTable[1344])((IntPtr)table, flagsForSectionToDisplay);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TableBeginContextMenuPopup(ImGuiTable* table)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1345])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableMergeDrawChannels(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1346])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableInstanceData* TableGetInstanceData(ImGuiTable* table, int instanceNo)
		{
			return (ImGuiTableInstanceData*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[1347])((IntPtr)table, instanceNo);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint TableGetInstanceID(ImGuiTable* table, int instanceNo)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1348])((IntPtr)table, instanceNo);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSortSpecsSanitize(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1349])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSortSpecsBuild(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1350])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumn* column)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiSortDirection>)FuncTable[1351])((IntPtr)column);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1352])((IntPtr)table, (IntPtr)column);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, float>)FuncTable[1353])((IntPtr)table, (IntPtr)column);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableBeginRow(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1354])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableEndRow(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1355])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableBeginCell(ImGuiTable* table, int columnN)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1356])((IntPtr)table, columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableEndCell(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1357])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int columnN)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[1358])((IntPtr)pOut, (IntPtr)table, columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* TableGetColumnName(ImGuiTable* table, int columnN)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[1359])((IntPtr)table, columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint TableGetColumnResizeID(ImGuiTable* table, int columnN, int instanceNo)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, int, uint>)FuncTable[1360])((IntPtr)table, columnN, instanceNo);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TableCalcMaxColumnWidth(ImGuiTable* table, int columnN)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, float>)FuncTable[1361])((IntPtr)table, columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetColumnWidthAutoSingle(ImGuiTable* table, int columnN)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, void>)FuncTable[1362])((IntPtr)table, columnN);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSetColumnWidthAutoAll(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1363])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableRemove(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1364])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableGcCompactTransientBuffers(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1365])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableGcCompactTransientBuffers(ImGuiTableTempData* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1366])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableGcCompactSettings()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1367])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableLoadSettings(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1368])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSaveSettings(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1369])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableResetSettings(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1370])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* TableGetBoundSettings(ImGuiTable* table)
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1371])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TableSettingsAddSettingsHandler()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1372])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* TableSettingsCreate(uint id, int columnsCount)
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<uint, int, IntPtr>)FuncTable[1373])(id, columnsCount);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTableSettings* TableSettingsFindByID(uint id)
		{
			return (ImGuiTableSettings*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1374])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabBar* GetCurrentTabBar()
		{
			return (ImGuiTabBar*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1375])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginTabBarEx(ImGuiTabBar* tabBar, ImRect bb, ImGuiTabBarFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiTabBarFlags, byte>)FuncTable[1376])((IntPtr)tabBar, bb, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* TabBarFindTabByID(ImGuiTabBar* tabBar, uint tabId)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, uint, IntPtr>)FuncTable[1377])((IntPtr)tabBar, tabId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* TabBarFindTabByOrder(ImGuiTabBar* tabBar, int order)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr>)FuncTable[1378])((IntPtr)tabBar, order);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tabBar)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1379])((IntPtr)tabBar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiTabItem* TabBarGetCurrentTab(ImGuiTabBar* tabBar)
		{
			return (ImGuiTabItem*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr>)FuncTable[1380])((IntPtr)tabBar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TabBarGetTabOrder(ImGuiTabBar* tabBar, ImGuiTabItem* tab)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int>)FuncTable[1381])((IntPtr)tabBar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* TabBarGetTabName(ImGuiTabBar* tabBar, ImGuiTabItem* tab)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[1382])((IntPtr)tabBar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarAddTab(ImGuiTabBar* tabBar, ImGuiTabItemFlags tabFlags, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabItemFlags, IntPtr, void>)FuncTable[1383])((IntPtr)tabBar, tabFlags, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarRemoveTab(ImGuiTabBar* tabBar, uint tabId)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, uint, void>)FuncTable[1384])((IntPtr)tabBar, tabId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarCloseTab(ImGuiTabBar* tabBar, ImGuiTabItem* tab)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1385])((IntPtr)tabBar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarQueueFocus(ImGuiTabBar* tabBar, ImGuiTabItem* tab)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1386])((IntPtr)tabBar, (IntPtr)tab);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarQueueFocus(ImGuiTabBar* tabBar, byte* tabName)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1387])((IntPtr)tabBar, (IntPtr)tabName);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarQueueReorder(ImGuiTabBar* tabBar, ImGuiTabItem* tab, int offset)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[1388])((IntPtr)tabBar, (IntPtr)tab, offset);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabBarQueueReorderFromMousePos(ImGuiTabBar* tabBar, ImGuiTabItem* tab, Vector2 mousePos)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, Vector2, void>)FuncTable[1389])((IntPtr)tabBar, (IntPtr)tab, mousePos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TabBarProcessReorder(ImGuiTabBar* tabBar)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1390])((IntPtr)tabBar);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TabItemEx(ImGuiTabBar* tabBar, byte* label, byte* pOpen, ImGuiTabItemFlags flags, ImGuiWindow* dockedWindow)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, ImGuiTabItemFlags, IntPtr, byte>)FuncTable[1391])((IntPtr)tabBar, (IntPtr)label, (IntPtr)pOpen, flags, (IntPtr)dockedWindow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabItemSpacing(byte* strId, ImGuiTabItemFlags flags, float width)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiTabItemFlags, float, void>)FuncTable[1392])((IntPtr)strId, flags, width);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabItemCalcSize(Vector2* pOut, byte* label, byte hasCloseButtonOrUnsavedMarker)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte, void>)FuncTable[1393])((IntPtr)pOut, (IntPtr)label, hasCloseButtonOrUnsavedMarker);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabItemCalcSize(Vector2* pOut, ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1394])((IntPtr)pOut, (IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabItemBackground(ImDrawList* drawList, ImRect bb, ImGuiTabItemFlags flags, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiTabItemFlags, uint, void>)FuncTable[1395])((IntPtr)drawList, bb, flags, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TabItemLabelAndCloseButton(ImDrawList* drawList, ImRect bb, ImGuiTabItemFlags flags, Vector2 framePadding, byte* label, uint tabId, uint closeButtonId, byte isContentsVisible, byte* outJustClosed, byte* outTextClipped)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImGuiTabItemFlags, Vector2, IntPtr, uint, uint, byte, IntPtr, IntPtr, void>)FuncTable[1396])((IntPtr)drawList, bb, flags, framePadding, (IntPtr)label, tabId, closeButtonId, isContentsVisible, (IntPtr)outJustClosed, (IntPtr)outTextClipped);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderText(Vector2 pos, byte* text, byte* textEnd, byte hideTextAfterHash)
		{
			((delegate* unmanaged[Cdecl]<Vector2, IntPtr, IntPtr, byte, void>)FuncTable[1397])(pos, (IntPtr)text, (IntPtr)textEnd, hideTextAfterHash);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderTextWrapped(Vector2 pos, byte* text, byte* textEnd, float wrapWidth)
		{
			((delegate* unmanaged[Cdecl]<Vector2, IntPtr, IntPtr, float, void>)FuncTable[1398])(pos, (IntPtr)text, (IntPtr)textEnd, wrapWidth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, byte* text, byte* textEnd, Vector2* textSizeIfKnown, Vector2 align, ImRect* clipRect)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, IntPtr, IntPtr, IntPtr, Vector2, IntPtr, void>)FuncTable[1399])(posMin, posMax, (IntPtr)text, (IntPtr)textEnd, (IntPtr)textSizeIfKnown, align, (IntPtr)clipRect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderTextClippedEx(ImDrawList* drawList, Vector2 posMin, Vector2 posMax, byte* text, byte* textEnd, Vector2* textSizeIfKnown, Vector2 align, ImRect* clipRect)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, IntPtr, IntPtr, IntPtr, Vector2, IntPtr, void>)FuncTable[1400])((IntPtr)drawList, posMin, posMax, (IntPtr)text, (IntPtr)textEnd, (IntPtr)textSizeIfKnown, align, (IntPtr)clipRect);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderTextEllipsis(ImDrawList* drawList, Vector2 posMin, Vector2 posMax, float clipMaxX, float ellipsisMaxX, byte* text, byte* textEnd, Vector2* textSizeIfKnown)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, float, float, IntPtr, IntPtr, IntPtr, void>)FuncTable[1401])((IntPtr)drawList, posMin, posMax, clipMaxX, ellipsisMaxX, (IntPtr)text, (IntPtr)textEnd, (IntPtr)textSizeIfKnown);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol, byte borders, float rounding)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, uint, byte, float, void>)FuncTable[1402])(pMin, pMax, fillCol, borders, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderFrameBorder(Vector2 pMin, Vector2 pMax, float rounding)
		{
			((delegate* unmanaged[Cdecl]<Vector2, Vector2, float, void>)FuncTable[1403])(pMin, pMax, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderColorRectWithAlphaCheckerboard(ImDrawList* drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff, float rounding, ImDrawFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, uint, float, Vector2, float, ImDrawFlags, void>)FuncTable[1404])((IntPtr)drawList, pMin, pMax, fillCol, gridStep, gridOff, rounding, flags);
		}

		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags)
		{
			((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiNavRenderCursorFlags, void>)FuncTable[1405])(bb, id, flags);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte* FindRenderedTextEnd(byte* text, byte* textEnd)
		{
			return (byte*)((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr>)FuncTable[1406])((IntPtr)text, (IntPtr)textEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouseCursor, uint colFill, uint colBorder, uint colShadow)
		{
			((delegate* unmanaged[Cdecl]<Vector2, float, ImGuiMouseCursor, uint, uint, uint, void>)FuncTable[1407])(pos, scale, mouseCursor, colFill, colBorder, colShadow);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderArrow(ImDrawList* drawList, Vector2 pos, uint col, ImGuiDir dir, float scale)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, ImGuiDir, float, void>)FuncTable[1408])((IntPtr)drawList, pos, col, dir, scale);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderBullet(ImDrawList* drawList, Vector2 pos, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, void>)FuncTable[1409])((IntPtr)drawList, pos, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderCheckMark(ImDrawList* drawList, Vector2 pos, uint col, float sz)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, uint, float, void>)FuncTable[1410])((IntPtr)drawList, pos, col, sz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderArrowPointingAt(ImDrawList* drawList, Vector2 pos, Vector2 halfSz, ImGuiDir direction, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, Vector2, ImGuiDir, uint, void>)FuncTable[1411])((IntPtr)drawList, pos, halfSz, direction, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderArrowDockMenu(ImDrawList* drawList, Vector2 pMin, float sz, uint col)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, Vector2, float, uint, void>)FuncTable[1412])((IntPtr)drawList, pMin, sz, col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderRectFilledRangeH(ImDrawList* drawList, ImRect rect, uint col, float xStartNorm, float xEndNorm, float rounding)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, uint, float, float, float, void>)FuncTable[1413])((IntPtr)drawList, rect, col, xStartNorm, xEndNorm, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void RenderRectFilledWithHole(ImDrawList* drawList, ImRect outer, ImRect inner, uint col, float rounding)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImRect, ImRect, uint, float, void>)FuncTable[1414])((IntPtr)drawList, outer, inner, col, rounding);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImDrawFlags CalcRoundingFlagsForRectInRect(ImRect rIn, ImRect rOuter, float threshold)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, ImRect, float, ImDrawFlags>)FuncTable[1415])(rIn, rOuter, threshold);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TextEx(byte* text, byte* textEnd, ImGuiTextFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiTextFlags, void>)FuncTable[1416])((IntPtr)text, (IntPtr)textEnd, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ButtonEx(byte* label, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, Vector2, ImGuiButtonFlags, byte>)FuncTable[1417])((IntPtr)label, sizeArg, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ArrowButtonEx(byte* strId, ImGuiDir dir, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDir, Vector2, ImGuiButtonFlags, byte>)FuncTable[1418])((IntPtr)strId, dir, sizeArg, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImageButtonEx(uint id, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ulong, Vector2, Vector2, Vector2, Vector4, Vector4, ImGuiButtonFlags, byte>)FuncTable[1419])(id, userTextureId, imageSize, uv0, uv1, bgCol, tintCol, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SeparatorEx(ImGuiSeparatorFlags flags, float thickness)
		{
			((delegate* unmanaged[Cdecl]<ImGuiSeparatorFlags, float, void>)FuncTable[1420])(flags, thickness);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SeparatorTextEx(uint id, byte* label, byte* labelEnd, float extraWidth)
		{
			((delegate* unmanaged[Cdecl]<uint, IntPtr, IntPtr, float, void>)FuncTable[1421])(id, (IntPtr)label, (IntPtr)labelEnd, extraWidth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CheckboxFlags(byte* label, long* flags, long flagsValue)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, long, byte>)FuncTable[1422])((IntPtr)label, (IntPtr)flags, flagsValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CheckboxFlags(byte* label, ulong* flags, ulong flagsValue)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ulong, byte>)FuncTable[1423])((IntPtr)label, (IntPtr)flags, flagsValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CloseButton(uint id, Vector2 pos)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, byte>)FuncTable[1424])(id, pos);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte CollapseButton(uint id, Vector2 pos, ImGuiDockNode* dockNode)
		{
			return ((delegate* unmanaged[Cdecl]<uint, Vector2, IntPtr, byte>)FuncTable[1425])(id, pos, (IntPtr)dockNode);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scrollbar(ImGuiAxis axis)
		{
			((delegate* unmanaged[Cdecl]<ImGuiAxis, void>)FuncTable[1426])(axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* pScrollV, long availV, long contentsV, ImDrawFlags drawRoundingFlags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiAxis, IntPtr, long, long, ImDrawFlags, byte>)FuncTable[1427])(bb, id, axis, (IntPtr)pScrollV, availV, contentsV, drawRoundingFlags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiAxis, void>)FuncTable[1428])((IntPtr)pOut, (IntPtr)window, axis);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiAxis, uint>)FuncTable[1429])((IntPtr)window, axis);
		}

		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetWindowResizeCornerID(ImGuiWindow* window, int n)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, uint>)FuncTable[1430])((IntPtr)window, n);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDir, uint>)FuncTable[1431])((IntPtr)window, dir);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ButtonBehavior(ImRect bb, uint id, byte* outHovered, byte* outHeld, ImGuiButtonFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, IntPtr, ImGuiButtonFlags, byte>)FuncTable[1432])(bb, id, (IntPtr)outHovered, (IntPtr)outHeld, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DragBehavior(uint id, ImGuiDataType dataType, void* pV, float vSpeed, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiDataType, IntPtr, float, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, byte>)FuncTable[1433])(id, dataType, (IntPtr)pV, vSpeed, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SliderBehavior(ImRect bb, uint id, ImGuiDataType dataType, void* pV, void* pMin, void* pMax, byte* format, ImGuiSliderFlags flags, ImRect* outGrabBb)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, ImGuiSliderFlags, IntPtr, byte>)FuncTable[1434])(bb, id, dataType, (IntPtr)pV, (IntPtr)pMin, (IntPtr)pMax, (IntPtr)format, flags, (IntPtr)outGrabBb);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float minSize1, float minSize2, float hoverExtend, float hoverVisibilityDelay, uint bgCol)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, ImGuiAxis, IntPtr, IntPtr, float, float, float, float, uint, byte>)FuncTable[1435])(bb, id, axis, (IntPtr)size1, (IntPtr)size2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* labelEnd)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiTreeNodeFlags, IntPtr, IntPtr, byte>)FuncTable[1436])(id, flags, (IntPtr)label, (IntPtr)labelEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TreePushOverrideID(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1437])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNodeGetOpen(uint storageId)
		{
			return ((delegate* unmanaged[Cdecl]<uint, byte>)FuncTable[1438])(storageId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TreeNodeSetOpen(uint storageId, byte open)
		{
			((delegate* unmanaged[Cdecl]<uint, byte, void>)FuncTable[1439])(storageId, open);
		}

		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TreeNodeUpdateNextOpen(uint storageId, ImGuiTreeNodeFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<uint, ImGuiTreeNodeFlags, byte>)FuncTable[1440])(storageId, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiDataTypeInfo* DataTypeGetInfo(ImGuiDataType dataType)
		{
			return (ImGuiDataTypeInfo*)((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr>)FuncTable[1441])(dataType);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DataTypeFormatString(byte* buf, int bufSize, ImGuiDataType dataType, void* pData, byte* format)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, int, ImGuiDataType, IntPtr, IntPtr, int>)FuncTable[1442])((IntPtr)buf, bufSize, dataType, (IntPtr)pData, (IntPtr)format);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DataTypeApplyOp(ImGuiDataType dataType, int op, void* output, void* arg_1, void* arg_2)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDataType, int, IntPtr, IntPtr, IntPtr, void>)FuncTable[1443])(dataType, op, (IntPtr)output, (IntPtr)arg_1, (IntPtr)arg_2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DataTypeApplyFromText(byte* buf, ImGuiDataType dataType, void* pData, byte* format, void* pDataWhenEmpty)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1444])((IntPtr)buf, dataType, (IntPtr)pData, (IntPtr)format, (IntPtr)pDataWhenEmpty);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int DataTypeCompare(ImGuiDataType dataType, void* arg_1, void* arg_2)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, IntPtr, int>)FuncTable[1445])(dataType, (IntPtr)arg_1, (IntPtr)arg_2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DataTypeClamp(ImGuiDataType dataType, void* pData, void* pMin, void* pMax)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1446])(dataType, (IntPtr)pData, (IntPtr)pMin, (IntPtr)pMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DataTypeIsZero(ImGuiDataType dataType, void* pData)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, byte>)FuncTable[1447])(dataType, (IntPtr)pData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte InputTextEx(byte* label, byte* hint, byte* buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* userData)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, int, Vector2, ImGuiInputTextFlags, ImGuiInputTextCallback, IntPtr, byte>)FuncTable[1448])((IntPtr)label, (IntPtr)hint, (IntPtr)buf, bufSize, sizeArg, flags, callback, (IntPtr)userData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void InputTextDeactivateHook(uint id)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1449])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TempInputText(ImRect bb, uint id, byte* label, byte* buf, int bufSize, ImGuiInputTextFlags flags)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, IntPtr, int, ImGuiInputTextFlags, byte>)FuncTable[1450])(bb, id, (IntPtr)label, (IntPtr)buf, bufSize, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType dataType, void* pData, byte* format, void* pClampMin, void* pClampMax)
		{
			return ((delegate* unmanaged[Cdecl]<ImRect, uint, IntPtr, ImGuiDataType, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1451])(bb, id, (IntPtr)label, dataType, (IntPtr)pData, (IntPtr)format, (IntPtr)pClampMin, (IntPtr)pClampMax);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte TempInputIsActive(uint id)
		{
			return ((delegate* unmanaged[Cdecl]<uint, byte>)FuncTable[1452])(id);
		}

		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImGuiInputTextState* GetInputTextState(uint id)
		{
			return (ImGuiInputTextState*)((delegate* unmanaged[Cdecl]<uint, IntPtr>)FuncTable[1453])(id);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetNextItemRefVal(ImGuiDataType dataType, void* pData)
		{
			((delegate* unmanaged[Cdecl]<ImGuiDataType, IntPtr, void>)FuncTable[1454])(dataType, (IntPtr)pData);
		}

		/// <summary>
		/// This may be useful to apply workaround that a based on distinguish whenever an item is active as a text input field.<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte IsItemActiveAsInputText()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1455])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImGuiColorEditFlags, void>)FuncTable[1456])((IntPtr)text, (IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiColorEditFlags, void>)FuncTable[1457])((IntPtr)col, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ColorPickerOptionsPopup(float* refCol, ImGuiColorEditFlags flags)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiColorEditFlags, void>)FuncTable[1458])((IntPtr)refCol, flags);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PlotEx(ImGuiPlotType plotType, byte* label, IgPlotLinesValuesGetter valuesGetter, void* data, int valuesCount, int valuesOffset, byte* overlayText, float scaleMin, float scaleMax, Vector2 sizeArg)
		{
			return ((delegate* unmanaged[Cdecl]<ImGuiPlotType, IntPtr, IgPlotLinesValuesGetter, IntPtr, int, int, IntPtr, float, float, Vector2, int>)FuncTable[1459])(plotType, (IntPtr)label, valuesGetter, (IntPtr)data, valuesCount, valuesOffset, (IntPtr)overlayText, scaleMin, scaleMax, sizeArg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawList* drawList, int vertStartIdx, int vertEndIdx, Vector2 gradientP0, Vector2 gradientP1, uint col0, uint col1)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, Vector2, uint, uint, void>)FuncTable[1460])((IntPtr)drawList, vertStartIdx, vertEndIdx, gradientP0, gradientP1, col0, col1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShadeVertsLinearUV(ImDrawList* drawList, int vertStartIdx, int vertEndIdx, Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, byte clamp)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, Vector2, Vector2, Vector2, byte, void>)FuncTable[1461])((IntPtr)drawList, vertStartIdx, vertEndIdx, a, b, uvA, uvB, clamp);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShadeVertsTransformPos(ImDrawList* drawList, int vertStartIdx, int vertEndIdx, Vector2 pivotIn, float cosA, float sinA, Vector2 pivotOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, Vector2, float, float, Vector2, void>)FuncTable[1462])((IntPtr)drawList, vertStartIdx, vertEndIdx, pivotIn, cosA, sinA, pivotOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GcCompactTransientMiscBuffers()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1463])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GcCompactTransientWindowBuffers(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1464])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void GcAwakeTransientWindowBuffers(ImGuiWindow* window)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1465])((IntPtr)window);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ErrorLog(byte* msg)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, byte>)FuncTable[1466])((IntPtr)msg);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ErrorRecoveryStoreState(ImGuiErrorRecoveryState* stateOut)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1467])((IntPtr)stateOut);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* stateIn)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1468])((IntPtr)stateIn);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* stateIn)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1469])((IntPtr)stateIn);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ErrorCheckUsingSetCursorPosToExtendParentBoundaries()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1470])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ErrorCheckEndFrameFinalizeErrorTooltip()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1471])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte BeginErrorTooltip()
		{
			return ((delegate* unmanaged[Cdecl]<byte>)FuncTable[1472])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void EndErrorTooltip()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1473])();
		}

		/// <summary>
		/// size &gt;= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugAllocHook(ImGuiDebugAllocInfo* info, int frameCount, void* ptr, uint size)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, uint, void>)FuncTable[1474])((IntPtr)info, frameCount, (IntPtr)ptr, size);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugDrawCursorPos(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1475])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugDrawLineExtents(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1476])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugDrawItemRect(uint col)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1477])(col);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugTextUnformattedWithLocateItem(byte* lineBegin, byte* lineEnd)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1478])((IntPtr)lineBegin, (IntPtr)lineEnd);
		}

		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugLocateItem(uint targetId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1479])(targetId);
		}

		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugLocateItemOnHover(uint targetId)
		{
			((delegate* unmanaged[Cdecl]<uint, void>)FuncTable[1480])(targetId);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugLocateItemResolveWithLastItem()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1481])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugBreakClearData()
		{
			((delegate* unmanaged[Cdecl]<void>)FuncTable[1482])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte DebugBreakButton(byte* label, byte* descriptionOfLocation)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, byte>)FuncTable[1483])((IntPtr)label, (IntPtr)descriptionOfLocation);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugBreakButtonTooltip(byte keyboardOnly, byte* descriptionOfLocation)
		{
			((delegate* unmanaged[Cdecl]<byte, IntPtr, void>)FuncTable[1484])(keyboardOnly, (IntPtr)descriptionOfLocation);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ShowFontAtlas(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1485])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugHookIdInfo(uint id, ImGuiDataType dataType, void* dataId, void* dataIdEnd)
		{
			((delegate* unmanaged[Cdecl]<uint, ImGuiDataType, IntPtr, IntPtr, void>)FuncTable[1486])(id, dataType, (IntPtr)dataId, (IntPtr)dataIdEnd);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeColumns(ImGuiOldColumns* columns)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1487])((IntPtr)columns);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeDockNode(ImGuiDockNode* node, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1488])((IntPtr)node, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* drawList, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, IntPtr, void>)FuncTable[1489])((IntPtr)window, (IntPtr)viewport, (IntPtr)drawList, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* outDrawList, ImDrawList* drawList, ImDrawCmd* drawCmd, byte showMesh, byte showAabb)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, byte, byte, void>)FuncTable[1490])((IntPtr)outDrawList, (IntPtr)drawList, (IntPtr)drawCmd, showMesh, showAabb);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeFont(ImFont* font)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1491])((IntPtr)font);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1492])((IntPtr)font, (IntPtr)glyph);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeStorage(ImGuiStorage* storage, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1493])((IntPtr)storage, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeTabBar(ImGuiTabBar* tabBar, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1494])((IntPtr)tabBar, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeTable(ImGuiTable* table)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1495])((IntPtr)table);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeTableSettings(ImGuiTableSettings* settings)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1496])((IntPtr)settings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeInputTextState(ImGuiInputTextState* state)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1497])((IntPtr)state);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeTypingSelectState(ImGuiTypingSelectState* state)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1498])((IntPtr)state);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeMultiSelectState(ImGuiMultiSelectState* state)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1499])((IntPtr)state);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeWindow(ImGuiWindow* window, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1500])((IntPtr)window, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeWindowSettings(ImGuiWindowSettings* settings)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1501])((IntPtr)settings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeWindowsList(ImVector<ImGuiWindowPtr>* windows, byte* label)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1502])((IntPtr)windows, (IntPtr)label);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windowsSize, ImGuiWindow* parentInBeginStack)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, IntPtr, void>)FuncTable[1503])((IntPtr)windows, windowsSize, (IntPtr)parentInBeginStack);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodeViewport(ImGuiViewportP* viewport)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1504])((IntPtr)viewport);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, byte* label, int idx)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, void>)FuncTable[1505])((IntPtr)monitor, (IntPtr)label, idx);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugRenderKeyboardPreview(ImDrawList* drawList)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1506])((IntPtr)drawList);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DebugRenderViewportThumbnail(ImDrawList* drawList, ImGuiViewportP* viewport, ImRect bb)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, ImRect, void>)FuncTable[1507])((IntPtr)drawList, (IntPtr)viewport, bb);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImFontBuilderIO* ImFontAtlasGetBuilderForStbTruetype()
		{
			return (ImFontBuilderIO*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1508])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasUpdateSourcesPointers(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1509])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildInit(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1510])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* src, float ascent, float descent)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, float, float, void>)FuncTable[1511])((IntPtr)atlas, (IntPtr)font, (IntPtr)src, ascent, descent);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrpContextOpaque)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1512])((IntPtr)atlas, (IntPtr)stbrpContextOpaque);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildFinish(ImFontAtlas* atlas)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1513])((IntPtr)atlas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildRender8BppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* inStr, byte inMarkerChar, byte inMarkerPixelValue)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, IntPtr, byte, byte, void>)FuncTable[1514])((IntPtr)atlas, x, y, w, h, (IntPtr)inStr, inMarkerChar, inMarkerPixelValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildRender32BppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* inStr, byte inMarkerChar, uint inMarkerPixelValue)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, int, int, int, int, IntPtr, byte, uint, void>)FuncTable[1515])((IntPtr)atlas, x, y, w, h, (IntPtr)inStr, inMarkerChar, inMarkerPixelValue);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildMultiplyCalcLookupTable(byte* outTable, float inMultiplyFactor)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, float, void>)FuncTable[1516])((IntPtr)outTable, inMultiplyFactor);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, int, int, int, int, int, void>)FuncTable[1517])((IntPtr)table, (IntPtr)pixels, x, y, w, h, stride);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImFontAtlasBuildGetOversampleFactors(ImFontConfig* src, int* outOversampleH, int* outOversampleV)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, IntPtr, void>)FuncTable[1518])((IntPtr)src, (IntPtr)outOversampleH, (IntPtr)outOversampleV);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ImFontAtlasGetMouseCursorTexData(ImFontAtlas* atlas, ImGuiMouseCursor cursorType, Vector2* outOffset, Vector2* outSize, Vector2* outUvBorder, Vector2* outUvFill)
		{
			return ((delegate* unmanaged[Cdecl]<IntPtr, ImGuiMouseCursor, IntPtr, IntPtr, IntPtr, IntPtr, byte>)FuncTable[1519])((IntPtr)atlas, cursorType, (IntPtr)outOffset, (IntPtr)outSize, (IntPtr)outUvBorder, (IntPtr)outUvFill);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiTextBufferAppendf(ImGuiTextBuffer* self, byte* fmt)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, IntPtr, void>)FuncTable[1520])((IntPtr)self, (IntPtr)fmt);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GETFLTMAX()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1521])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GETFLTMIN()
		{
			return ((delegate* unmanaged[Cdecl]<float>)FuncTable[1522])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ImVector<ushort>* ImVectorImWcharCreate()
		{
			return (ImVector<ushort>*)((delegate* unmanaged[Cdecl]<IntPtr>)FuncTable[1523])();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVectorImWcharDestroy(ImVector<ushort>* self)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1524])((IntPtr)self);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVectorImWcharInit(ImVector<ushort>* p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1525])((IntPtr)p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImVectorImWcharUnInit(ImVector<ushort>* p)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, void>)FuncTable[1526])((IntPtr)p);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIOSetPlatformGetWindowPos(ImGuiPlatformIO* platformIo, ImGuiPlatformIOSetPlatformGetWindowPosUserCallback userCallback)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPlatformIOSetPlatformGetWindowPosUserCallback, void>)FuncTable[1527])((IntPtr)platformIo, userCallback);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ImGuiPlatformIOSetPlatformGetWindowSize(ImGuiPlatformIO* platformIo, ImGuiPlatformIOSetPlatformGetWindowSizeUserCallback userCallback)
		{
			((delegate* unmanaged[Cdecl]<IntPtr, ImGuiPlatformIOSetPlatformGetWindowSizeUserCallback, void>)FuncTable[1528])((IntPtr)platformIo, userCallback);
		}

	}
}
