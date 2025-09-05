using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public static unsafe partial class ImGui
	{
		public static ImGuiContextPtr CreateContext(ImFontAtlasPtr sharedFontAtlas)
		{
			return ImGuiNative.CreateContext(sharedFontAtlas);
		}

		public static ImGuiContextPtr CreateContext()
		{
			// defining omitted parameters
			ImFontAtlas* sharedFontAtlas = null;
			return ImGuiNative.CreateContext(sharedFontAtlas);
		}

		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		public static void DestroyContext(ImGuiContextPtr ctx)
		{
			ImGuiNative.DestroyContext(ctx);
		}

		/// <summary>
		/// NULL = destroy current context<br/>
		/// </summary>
		public static void DestroyContext()
		{
			// defining omitted parameters
			ImGuiContext* ctx = null;
			ImGuiNative.DestroyContext(ctx);
		}

		public static ImGuiContextPtr GetCurrentContext()
		{
			return ImGuiNative.GetCurrentContext();
		}

		public static void SetCurrentContext(ImGuiContextPtr ctx)
		{
			ImGuiNative.SetCurrentContext(ctx);
		}

		/// <summary>
		/// access the ImGuiIO structure (mouse/keyboard/gamepad inputs, time, various configuration options/flags)<br/>
		/// </summary>
		public static ImGuiIOPtr GetIO()
		{
			return ImGuiNative.GetIO();
		}

		public static ImGuiPlatformIOPtr GetPlatformIO()
		{
			return ImGuiNative.GetPlatformIO();
		}

		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!<br/>
		/// </summary>
		public static ImGuiStylePtr GetStyle()
		{
			return ImGuiNative.GetStyle();
		}

		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().<br/>
		/// </summary>
		public static void NewFrame()
		{
			ImGuiNative.NewFrame();
		}

		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!<br/>
		/// </summary>
		public static void EndFrame()
		{
			ImGuiNative.EndFrame();
		}

		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().<br/>
		/// </summary>
		public static void Render()
		{
			ImGuiNative.Render();
		}

		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.<br/>
		/// </summary>
		public static ImDrawDataPtr GetDrawData()
		{
			return ImGuiNative.GetDrawData();
		}

		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		public static void ShowDemoWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImGuiNative.ShowDemoWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!<br/>
		/// </summary>
		public static void ShowDemoWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImGuiNative.ShowDemoWindow(pOpen);
		}

		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		public static void ShowMetricsWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImGuiNative.ShowMetricsWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.<br/>
		/// </summary>
		public static void ShowMetricsWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImGuiNative.ShowMetricsWindow(pOpen);
		}

		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		public static void ShowDebugLogWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImGuiNative.ShowDebugLogWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.<br/>
		/// </summary>
		public static void ShowDebugLogWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImGuiNative.ShowDebugLogWindow(pOpen);
		}

		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		public static void ShowIdStackToolWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImGuiNative.ShowIdStackToolWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		/// <summary>
		/// create Stack Tool window. hover items with mouse to query information about the source of their unique ID.<br/>
		/// </summary>
		public static void ShowIdStackToolWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImGuiNative.ShowIdStackToolWindow(pOpen);
		}

		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		public static void ShowAboutWindow(ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImGuiNative.ShowAboutWindow(nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.<br/>
		/// </summary>
		public static void ShowAboutWindow()
		{
			// defining omitted parameters
			byte* pOpen = null;
			ImGuiNative.ShowAboutWindow(pOpen);
		}

		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		public static void ShowStyleEditor(ImGuiStylePtr _ref)
		{
			ImGuiNative.ShowStyleEditor(_ref);
		}

		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)<br/>
		/// </summary>
		public static void ShowStyleEditor()
		{
			// defining omitted parameters
			ImGuiStyle* _ref = null;
			ImGuiNative.ShowStyleEditor(_ref);
		}

		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		public static bool ShowStyleSelector(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.ShowStyleSelector(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.<br/>
		/// </summary>
		public static bool ShowStyleSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.ShowStyleSelector(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		public static void ShowFontSelector(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.ShowFontSelector(nativeLabel);
			}
		}

		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.<br/>
		/// </summary>
		public static void ShowFontSelector(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.ShowFontSelector(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).<br/>
		/// </summary>
		public static void ShowUserGuide()
		{
			ImGuiNative.ShowUserGuide();
		}

		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)<br/>
		/// </summary>
		public static string GetVersion()
		{
			var result = ImGuiNative.GetVersion();
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		public static void StyleColorsDark(ImGuiStylePtr dst)
		{
			ImGuiNative.StyleColorsDark(dst);
		}

		/// <summary>
		/// new, recommended style (default)<br/>
		/// </summary>
		public static void StyleColorsDark()
		{
			// defining omitted parameters
			ImGuiStyle* dst = null;
			ImGuiNative.StyleColorsDark(dst);
		}

		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		public static void StyleColorsLht(ImGuiStylePtr dst)
		{
			ImGuiNative.StyleColorsLht(dst);
		}

		/// <summary>
		/// best used with borders and a custom, thicker font<br/>
		/// </summary>
		public static void StyleColorsLht()
		{
			// defining omitted parameters
			ImGuiStyle* dst = null;
			ImGuiNative.StyleColorsLht(dst);
		}

		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		public static void StyleColorsClassic(ImGuiStylePtr dst)
		{
			ImGuiNative.StyleColorsClassic(dst);
		}

		/// <summary>
		/// classic imgui style<br/>
		/// </summary>
		public static void StyleColorsClassic()
		{
			// defining omitted parameters
			ImGuiStyle* dst = null;
			ImGuiNative.StyleColorsClassic(dst);
		}

		public static bool Begin(ReadOnlySpan<byte> name, ref bool pOpen, ImGuiWindowFlags flags)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.Begin(nativeName, nativePOpen, flags);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		public static bool Begin(ReadOnlySpan<char> name, ref bool pOpen, ImGuiWindowFlags flags)
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

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.Begin(nativeName, nativePOpen, flags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		public static bool Begin(ReadOnlySpan<byte> name, ref bool pOpen)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.Begin(nativeName, nativePOpen, flags);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		public static bool Begin(ReadOnlySpan<char> name, ref bool pOpen)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
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

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.Begin(nativeName, nativePOpen, flags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		public static bool Begin(ReadOnlySpan<byte> name)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			byte* pOpen = null;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.Begin(nativeName, pOpen, flags);
				return result != 0;
			}
		}

		public static bool Begin(ReadOnlySpan<char> name)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			byte* pOpen = null;
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

			var result = ImGuiNative.Begin(nativeName, pOpen, flags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static void End()
		{
			ImGuiNative.End();
		}

		public static bool BeginChild(ReadOnlySpan<byte> strId, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginChild(nativeStrId, size, childFlags, windowFlags);
				return result != 0;
			}
		}

		public static bool BeginChild(ReadOnlySpan<char> strId, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginChild(nativeStrId, size, childFlags, windowFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool BeginChild(uint id, Vector2 size, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			var result = ImGuiNative.BeginChild(id, size, childFlags, windowFlags);
			return result != 0;
		}

		public static void EndChild()
		{
			ImGuiNative.EndChild();
		}

		public static bool IsWindowAppearing()
		{
			var result = ImGuiNative.IsWindowAppearing();
			return result != 0;
		}

		public static bool IsWindowCollapsed()
		{
			var result = ImGuiNative.IsWindowCollapsed();
			return result != 0;
		}

		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		public static bool IsWindowFocused(ImGuiFocusedFlags flags)
		{
			var result = ImGuiNative.IsWindowFocused(flags);
			return result != 0;
		}

		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.<br/>
		/// </summary>
		public static bool IsWindowFocused()
		{
			// defining omitted parameters
			ImGuiFocusedFlags flags = ImGuiFocusedFlags.None;
			var result = ImGuiNative.IsWindowFocused(flags);
			return result != 0;
		}

		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		public static bool IsWindowHovered(ImGuiHoveredFlags flags)
		{
			var result = ImGuiNative.IsWindowHovered(flags);
			return result != 0;
		}

		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.<br/>
		/// </summary>
		public static bool IsWindowHovered()
		{
			// defining omitted parameters
			ImGuiHoveredFlags flags = ImGuiHoveredFlags.None;
			var result = ImGuiNative.IsWindowHovered(flags);
			return result != 0;
		}

		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives<br/>
		/// </summary>
		public static ImDrawListPtr GetWindowDrawList()
		{
			return ImGuiNative.GetWindowDrawList();
		}

		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.<br/>
		/// </summary>
		public static float GetWindowDpiScale()
		{
			return ImGuiNative.GetWindowDpiScale();
		}

		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static void GetWindowPos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetWindowPos(nativePOut);
			}
		}

		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)<br/>
		/// </summary>
		public static void GetWindowSize(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetWindowSize(nativePOut);
			}
		}

		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.<br/>
		/// </summary>
		public static float GetWindowWidth()
		{
			return ImGuiNative.GetWindowWidth();
		}

		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.<br/>
		/// </summary>
		public static float GetWindowHeht()
		{
			return ImGuiNative.GetWindowHeht();
		}

		/// <summary>
		/// get viewport currently associated to the current window.<br/>
		/// </summary>
		public static ImGuiViewportPtr GetWindowViewport()
		{
			return ImGuiNative.GetWindowViewport();
		}

		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
		{
			ImGuiNative.SetNextWindowPos(pos, cond, pivot);
		}

		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond)
		{
			// defining omitted parameters
			Vector2 pivot = new Vector2(0,0);
			ImGuiNative.SetNextWindowPos(pos, cond, pivot);
		}

		/// <summary>
		/// set next window position. call before Begin(). use pivot=(0.5f,0.5f) to center on given point, etc.<br/>
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos)
		{
			// defining omitted parameters
			Vector2 pivot = new Vector2(0,0);
			ImGuiCond cond = ImGuiCond.None;
			ImGuiNative.SetNextWindowPos(pos, cond, pivot);
		}

		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.SetNextWindowSize(size, cond);
		}

		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowSize(Vector2 size)
		{
			// defining omitted parameters
			ImGuiCond cond = ImGuiCond.None;
			ImGuiNative.SetNextWindowSize(size, cond);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 sizeMin, Vector2 sizeMax, ImGuiSizeCallback customCallback, IntPtr customCallbackData)
		{
			ImGuiNative.SetNextWindowSizeConstraints(sizeMin, sizeMax, customCallback, (void*)customCallbackData);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 sizeMin, Vector2 sizeMax, ImGuiSizeCallback customCallback)
		{
			// defining omitted parameters
			void* customCallbackData = null;
			ImGuiNative.SetNextWindowSizeConstraints(sizeMin, sizeMax, customCallback, customCallbackData);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.<br/>
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 sizeMin, Vector2 sizeMax)
		{
			// defining omitted parameters
			void* customCallbackData = null;
			ImGuiSizeCallback customCallback = null;
			ImGuiNative.SetNextWindowSizeConstraints(sizeMin, sizeMax, customCallback, customCallbackData);
		}

		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowContentSize(Vector2 size)
		{
			ImGuiNative.SetNextWindowContentSize(size);
		}

		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetNextWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// set next window collapsed state. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowCollapsed(bool collapsed)
		{
			// defining omitted parameters
			ImGuiCond cond = ImGuiCond.None;
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetNextWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// set next window to be focused / top-most. call before Begin()<br/>
		/// </summary>
		public static void SetNextWindowFocus()
		{
			ImGuiNative.SetNextWindowFocus();
		}

		/// <summary>
		/// set next window scrolling value (use &lt; 0.0f to not affect a given axis).<br/>
		/// </summary>
		public static void SetNextWindowScroll(Vector2 scroll)
		{
			ImGuiNative.SetNextWindowScroll(scroll);
		}

		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.<br/>
		/// </summary>
		public static void SetNextWindowBgAlpha(float alpha)
		{
			ImGuiNative.SetNextWindowBgAlpha(alpha);
		}

		/// <summary>
		/// set next window viewport<br/>
		/// </summary>
		public static void SetNextWindowViewport(uint viewportId)
		{
			ImGuiNative.SetNextWindowViewport(viewportId);
		}

		public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
		{
			ImGuiNative.SetWindowPos(pos, cond);
		}

		public static void SetWindowSize(Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.SetWindowSize(size, cond);
		}

		public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.<br/>
		/// </summary>
		public static void SetWindowFocus()
		{
			ImGuiNative.SetWindowFocus();
		}

		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().<br/>
		/// </summary>
		public static void SetWindowFontScale(float scale)
		{
			ImGuiNative.SetWindowFontScale(scale);
		}

		public static void SetWindowPos(ReadOnlySpan<byte> name, Vector2 pos, ImGuiCond cond)
		{
			fixed (byte* nativeName = name)
			{
				ImGuiNative.SetWindowPos(nativeName, pos, cond);
			}
		}

		public static void SetWindowPos(ReadOnlySpan<char> name, Vector2 pos, ImGuiCond cond)
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

			ImGuiNative.SetWindowPos(nativeName, pos, cond);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public static void SetWindowSize(ReadOnlySpan<byte> name, Vector2 size, ImGuiCond cond)
		{
			fixed (byte* nativeName = name)
			{
				ImGuiNative.SetWindowSize(nativeName, size, cond);
			}
		}

		public static void SetWindowSize(ReadOnlySpan<char> name, Vector2 size, ImGuiCond cond)
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

			ImGuiNative.SetWindowSize(nativeName, size, cond);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public static void SetWindowCollapsed(ReadOnlySpan<byte> name, bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			fixed (byte* nativeName = name)
			{
				ImGuiNative.SetWindowCollapsed(nativeName, native_collapsed, cond);
			}
		}

		public static void SetWindowCollapsed(ReadOnlySpan<char> name, bool collapsed, ImGuiCond cond)
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

			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetWindowCollapsed(nativeName, native_collapsed, cond);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public static void SetWindowFocus(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				ImGuiNative.SetWindowFocus(nativeName);
			}
		}

		public static void SetWindowFocus(ReadOnlySpan<char> name)
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

			ImGuiNative.SetWindowFocus(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]<br/>
		/// </summary>
		public static float GetScrollX()
		{
			return ImGuiNative.GetScrollX();
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]<br/>
		/// </summary>
		public static float GetScrollY()
		{
			return ImGuiNative.GetScrollY();
		}

		public static void SetScrollX(float scrollX)
		{
			ImGuiNative.SetScrollX(scrollX);
		}

		public static void SetScrollY(float scrollY)
		{
			ImGuiNative.SetScrollY(scrollY);
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x<br/>
		/// </summary>
		public static float GetScrollMaxX()
		{
			return ImGuiNative.GetScrollMaxX();
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y<br/>
		/// </summary>
		public static float GetScrollMaxY()
		{
			return ImGuiNative.GetScrollMaxY();
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static void SetScrollHereX(float centerXRatio)
		{
			ImGuiNative.SetScrollHereX(centerXRatio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static void SetScrollHereX()
		{
			// defining omitted parameters
			float centerXRatio = 0.5f;
			ImGuiNative.SetScrollHereX(centerXRatio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static void SetScrollHereY(float centerYRatio)
		{
			ImGuiNative.SetScrollHereY(centerYRatio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.<br/>
		/// </summary>
		public static void SetScrollHereY()
		{
			// defining omitted parameters
			float centerYRatio = 0.5f;
			ImGuiNative.SetScrollHereY(centerYRatio);
		}

		public static void SetScrollFromPosX(float localX, float centerXRatio)
		{
			ImGuiNative.SetScrollFromPosX(localX, centerXRatio);
		}

		public static void SetScrollFromPosY(float localY, float centerYRatio)
		{
			ImGuiNative.SetScrollFromPosY(localY, centerYRatio);
		}

		/// <summary>
		/// use NULL as a shortcut to push default font<br/>
		/// </summary>
		public static void PushFont(ImFontPtr font)
		{
			ImGuiNative.PushFont(font);
		}

		public static void PopFont()
		{
			ImGuiNative.PopFont();
		}

		public static void PushStyleColor(ImGuiCol idx, uint col)
		{
			ImGuiNative.PushStyleColor(idx, col);
		}

		public static void PushStyleColor(ImGuiCol idx, Vector4 col)
		{
			ImGuiNative.PushStyleColor(idx, col);
		}

		public static void PopStyleColor(int count)
		{
			ImGuiNative.PopStyleColor(count);
		}

		public static void PopStyleColor()
		{
			// defining omitted parameters
			int count = 1;
			ImGuiNative.PopStyleColor(count);
		}

		/// <summary>
		/// modify a style ImVec2 variable. "<br/>
		/// </summary>
		public static void PushStyleVar(ImGuiStyleVar idx, float val)
		{
			ImGuiNative.PushStyleVar(idx, val);
		}

		public static void PushStyleVar(ImGuiStyleVar idx, Vector2 val)
		{
			ImGuiNative.PushStyleVar(idx, val);
		}

		/// <summary>
		/// modify X component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static void PushStyleVarX(ImGuiStyleVar idx, float valX)
		{
			ImGuiNative.PushStyleVarX(idx, valX);
		}

		/// <summary>
		/// modify Y component of a style ImVec2 variable. "<br/>
		/// </summary>
		public static void PushStyleVarY(ImGuiStyleVar idx, float valY)
		{
			ImGuiNative.PushStyleVarY(idx, valY);
		}

		public static void PopStyleVar(int count)
		{
			ImGuiNative.PopStyleVar(count);
		}

		public static void PopStyleVar()
		{
			// defining omitted parameters
			int count = 1;
			ImGuiNative.PopStyleVar(count);
		}

		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)<br/>
		/// </summary>
		public static void PushItemFlag(ImGuiItemFlags option, bool enabled)
		{
			var native_enabled = enabled ? (byte)1 : (byte)0;
			ImGuiNative.PushItemFlag(option, native_enabled);
		}

		public static void PopItemFlag()
		{
			ImGuiNative.PopItemFlag();
		}

		/// <summary>
		/// push width of items for common large "item+label" widgets. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).<br/>
		/// </summary>
		public static void PushItemWidth(float itemWidth)
		{
			ImGuiNative.PushItemWidth(itemWidth);
		}

		public static void PopItemWidth()
		{
			ImGuiNative.PopItemWidth();
		}

		/// <summary>
		/// set width of the _next_ common large "item+label" widget. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)<br/>
		/// </summary>
		public static void SetNextItemWidth(float itemWidth)
		{
			ImGuiNative.SetNextItemWidth(itemWidth);
		}

		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.<br/>
		/// </summary>
		public static float CalcItemWidth()
		{
			return ImGuiNative.CalcItemWidth();
		}

		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		public static void PushTextWrapPos(float wrapLocalPosX)
		{
			ImGuiNative.PushTextWrapPos(wrapLocalPosX);
		}

		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space<br/>
		/// </summary>
		public static void PushTextWrapPos()
		{
			// defining omitted parameters
			float wrapLocalPosX = 0.0f;
			ImGuiNative.PushTextWrapPos(wrapLocalPosX);
		}

		public static void PopTextWrapPos()
		{
			ImGuiNative.PopTextWrapPos();
		}

		/// <summary>
		/// get current font<br/>
		/// </summary>
		public static ImFontPtr GetFont()
		{
			return ImGuiNative.GetFont();
		}

		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied<br/>
		/// </summary>
		public static float GetFontSize()
		{
			return ImGuiNative.GetFontSize();
		}

		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API<br/>
		/// </summary>
		public static void GetFontTexUvWhitePixel(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetFontTexUvWhitePixel(nativePOut);
			}
		}

		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList<br/>
		/// </summary>
		public static uint GetColorU32(ImGuiCol idx, float alphaMul)
		{
			return ImGuiNative.GetColorU32(idx, alphaMul);
		}

		public static uint GetColorU32(Vector4 col)
		{
			return ImGuiNative.GetColorU32(col);
		}

		public static uint GetColorU32(uint col, float alphaMul)
		{
			return ImGuiNative.GetColorU32(col, alphaMul);
		}

		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.<br/>
		/// </summary>
		public static ref Vector4 GetStyleColorVec4(ImGuiCol idx)
		{
			var nativeResult = ImGuiNative.GetStyleColorVec4(idx);
			return ref *(Vector4*)&nativeResult;
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND (prefer using this rather than GetCursorPos(), also more useful to work with ImDrawList API).<br/>
		/// </summary>
		public static void GetCursorScreenPos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetCursorScreenPos(nativePOut);
			}
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static void SetCursorScreenPos(Vector2 pos)
		{
			ImGuiNative.SetCursorScreenPos(pos);
		}

		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.<br/>
		/// </summary>
		public static void GetContentRegionAvail(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetContentRegionAvail(nativePOut);
			}
		}

		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.<br/>
		/// </summary>
		public static void GetCursorPos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetCursorPos(nativePOut);
			}
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static float GetCursorPosX()
		{
			return ImGuiNative.GetCursorPosX();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static float GetCursorPosY()
		{
			return ImGuiNative.GetCursorPosY();
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static void SetCursorPos(Vector2 localPos)
		{
			ImGuiNative.SetCursorPos(localPos);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static void SetCursorPosX(float localX)
		{
			ImGuiNative.SetCursorPosX(localX);
		}

		/// <summary>
		/// [window-local] "<br/>
		/// </summary>
		public static void SetCursorPosY(float localY)
		{
			ImGuiNative.SetCursorPosY(localY);
		}

		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.<br/>
		/// </summary>
		public static void GetCursorStartPos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetCursorStartPos(nativePOut);
			}
		}

		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.<br/>
		/// </summary>
		public static void Separator()
		{
			ImGuiNative.Separator();
		}

		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		public static void SameLine(float offsetFromStartX, float spacing)
		{
			ImGuiNative.SameLine(offsetFromStartX, spacing);
		}

		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		public static void SameLine(float offsetFromStartX)
		{
			// defining omitted parameters
			float spacing = -1.0f;
			ImGuiNative.SameLine(offsetFromStartX, spacing);
		}

		/// <summary>
		/// call between widgets or groups to layout them horizontally. X position given in window coordinates.<br/>
		/// </summary>
		public static void SameLine()
		{
			// defining omitted parameters
			float spacing = -1.0f;
			float offsetFromStartX = 0.0f;
			ImGuiNative.SameLine(offsetFromStartX, spacing);
		}

		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.<br/>
		/// </summary>
		public static void NewLine()
		{
			ImGuiNative.NewLine();
		}

		/// <summary>
		/// add vertical spacing.<br/>
		/// </summary>
		public static void Spacing()
		{
			ImGuiNative.Spacing();
		}

		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.<br/>
		/// </summary>
		public static void Dummy(Vector2 size)
		{
			ImGuiNative.Dummy(size);
		}

		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		public static void Indent(float indentW)
		{
			ImGuiNative.Indent(indentW);
		}

		/// <summary>
		/// move content position toward the right, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		public static void Indent()
		{
			// defining omitted parameters
			float indentW = 0.0f;
			ImGuiNative.Indent(indentW);
		}

		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		public static void Unindent(float indentW)
		{
			ImGuiNative.Unindent(indentW);
		}

		/// <summary>
		/// move content position back to the left, by indent_w, or style.IndentSpacing if indent_w &lt;= 0<br/>
		/// </summary>
		public static void Unindent()
		{
			// defining omitted parameters
			float indentW = 0.0f;
			ImGuiNative.Unindent(indentW);
		}

		/// <summary>
		/// lock horizontal starting position<br/>
		/// </summary>
		public static void BeginGroup()
		{
			ImGuiNative.BeginGroup();
		}

		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)<br/>
		/// </summary>
		public static void EndGroup()
		{
			ImGuiNative.EndGroup();
		}

		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)<br/>
		/// </summary>
		public static void AlnTextToFramePadding()
		{
			ImGuiNative.AlnTextToFramePadding();
		}

		/// <summary>
		/// ~ FontSize<br/>
		/// </summary>
		public static float GetTextLineHeht()
		{
			return ImGuiNative.GetTextLineHeht();
		}

		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)<br/>
		/// </summary>
		public static float GetTextLineHehtWithSpacing()
		{
			return ImGuiNative.GetTextLineHehtWithSpacing();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2<br/>
		/// </summary>
		public static float GetFrameHeht()
		{
			return ImGuiNative.GetFrameHeht();
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)<br/>
		/// </summary>
		public static float GetFrameHehtWithSpacing()
		{
			return ImGuiNative.GetFrameHehtWithSpacing();
		}

		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		public static void PushID(ReadOnlySpan<byte> strId)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.PushID(nativeStrId);
			}
		}

		/// <summary>
		/// push integer into the ID stack (will hash integer).<br/>
		/// </summary>
		public static void PushID(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.PushID(nativeStrId);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		public static void PushID(ReadOnlySpan<byte> strIdBegin, ReadOnlySpan<byte> strIdEnd)
		{
			fixed (byte* nativeStrIdBegin = strIdBegin)
			fixed (byte* nativeStrIdEnd = strIdEnd)
			{
				ImGuiNative.PushID(nativeStrIdBegin, nativeStrIdEnd);
			}
		}

		public static void PushID(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* nativeStrIdBegin;
			var byteCountStrIdBegin = 0;
			if (strIdBegin != null && !strIdBegin.IsEmpty)
			{
				byteCountStrIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCountStrIdBegin > Utils.MaxStackallocSize)
				{
					nativeStrIdBegin = Utils.Alloc<byte>(byteCountStrIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdBegin + 1];
					nativeStrIdBegin = stackallocBytes;
				}
				var offsetStrIdBegin = Utils.EncodeStringUTF8(strIdBegin, nativeStrIdBegin, byteCountStrIdBegin);
				nativeStrIdBegin[offsetStrIdBegin] = 0;
			}
			else nativeStrIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* nativeStrIdEnd;
			var byteCountStrIdEnd = 0;
			if (strIdEnd != null && !strIdEnd.IsEmpty)
			{
				byteCountStrIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCountStrIdEnd > Utils.MaxStackallocSize)
				{
					nativeStrIdEnd = Utils.Alloc<byte>(byteCountStrIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdEnd + 1];
					nativeStrIdEnd = stackallocBytes;
				}
				var offsetStrIdEnd = Utils.EncodeStringUTF8(strIdEnd, nativeStrIdEnd, byteCountStrIdEnd);
				nativeStrIdEnd[offsetStrIdEnd] = 0;
			}
			else nativeStrIdEnd = null;

			ImGuiNative.PushID(nativeStrIdBegin, nativeStrIdEnd);
			// Freeing strIdBegin native string
			if (byteCountStrIdBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdBegin);
			// Freeing strIdEnd native string
			if (byteCountStrIdEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdEnd);
		}

		public static void PushID(IntPtr ptrId)
		{
			ImGuiNative.PushID((void*)ptrId);
		}

		public static void PushID(int intId)
		{
			ImGuiNative.PushID(intId);
		}

		/// <summary>
		/// pop from the ID stack.<br/>
		/// </summary>
		public static void PopID()
		{
			ImGuiNative.PopID();
		}

		public static uint GetID(ReadOnlySpan<byte> strId)
		{
			fixed (byte* nativeStrId = strId)
			{
				return ImGuiNative.GetID(nativeStrId);
			}
		}

		public static uint GetID(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.GetID(nativeStrId);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result;
		}

		public static uint GetID(ReadOnlySpan<byte> strIdBegin, ReadOnlySpan<byte> strIdEnd)
		{
			fixed (byte* nativeStrIdBegin = strIdBegin)
			fixed (byte* nativeStrIdEnd = strIdEnd)
			{
				return ImGuiNative.GetID(nativeStrIdBegin, nativeStrIdEnd);
			}
		}

		public static uint GetID(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd)
		{
			// Marshaling strIdBegin to native string
			byte* nativeStrIdBegin;
			var byteCountStrIdBegin = 0;
			if (strIdBegin != null && !strIdBegin.IsEmpty)
			{
				byteCountStrIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCountStrIdBegin > Utils.MaxStackallocSize)
				{
					nativeStrIdBegin = Utils.Alloc<byte>(byteCountStrIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdBegin + 1];
					nativeStrIdBegin = stackallocBytes;
				}
				var offsetStrIdBegin = Utils.EncodeStringUTF8(strIdBegin, nativeStrIdBegin, byteCountStrIdBegin);
				nativeStrIdBegin[offsetStrIdBegin] = 0;
			}
			else nativeStrIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* nativeStrIdEnd;
			var byteCountStrIdEnd = 0;
			if (strIdEnd != null && !strIdEnd.IsEmpty)
			{
				byteCountStrIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCountStrIdEnd > Utils.MaxStackallocSize)
				{
					nativeStrIdEnd = Utils.Alloc<byte>(byteCountStrIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdEnd + 1];
					nativeStrIdEnd = stackallocBytes;
				}
				var offsetStrIdEnd = Utils.EncodeStringUTF8(strIdEnd, nativeStrIdEnd, byteCountStrIdEnd);
				nativeStrIdEnd[offsetStrIdEnd] = 0;
			}
			else nativeStrIdEnd = null;

			var result = ImGuiNative.GetID(nativeStrIdBegin, nativeStrIdEnd);
			// Freeing strIdBegin native string
			if (byteCountStrIdBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdBegin);
			// Freeing strIdEnd native string
			if (byteCountStrIdEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdEnd);
			return result;
		}

		public static uint GetID(IntPtr ptrId)
		{
			return ImGuiNative.GetID((void*)ptrId);
		}

		public static uint GetID(int intId)
		{
			return ImGuiNative.GetID(intId);
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.TextUnformatted(nativeText, nativeTextEnd);
			}
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.TextUnformatted(nativeText, nativeTextEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				ImGuiNative.TextUnformatted(nativeText, textEnd);
			}
		}

		/// <summary>
		/// raw text without formatting. Roughly equivalent to Text("%s", text) but: A) doesn't require null terminated string if 'text_end' is specified, B) it's faster, no memory copy is done, no buffer size limits, recommended for long chunks of text.<br/>
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImGuiNative.TextUnformatted(nativeText, textEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		/// <summary>
		/// formatted text<br/>
		/// </summary>
		public static void Text(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.Text(nativeFmt);
			}
		}

		/// <summary>
		/// formatted text<br/>
		/// </summary>
		public static void Text(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.Text(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static void TextColored(Vector4 col, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.TextColored(col, nativeFmt);
			}
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static void TextColored(Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.TextColored(col, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static void TextDisabled(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.TextDisabled(nativeFmt);
			}
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();<br/>
		/// </summary>
		public static void TextDisabled(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.TextDisabled(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		public static void TextWrapped(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.TextWrapped(nativeFmt);
			}
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().<br/>
		/// </summary>
		public static void TextWrapped(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.TextWrapped(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		public static void LabelText(ReadOnlySpan<byte> label, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.LabelText(nativeLabel, nativeFmt);
			}
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets<br/>
		/// </summary>
		public static void LabelText(ReadOnlySpan<char> label, ReadOnlySpan<char> fmt)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.LabelText(nativeLabel, nativeFmt);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		public static void BulletText(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.BulletText(nativeFmt);
			}
		}

		/// <summary>
		/// shortcut for Bullet()+Text()<br/>
		/// </summary>
		public static void BulletText(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.BulletText(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// currently: formatted text with a horizontal line<br/>
		/// </summary>
		public static void SeparatorText(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.SeparatorText(nativeLabel);
			}
		}

		/// <summary>
		/// currently: formatted text with a horizontal line<br/>
		/// </summary>
		public static void SeparatorText(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.SeparatorText(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		public static bool Button(ReadOnlySpan<byte> label, Vector2 size)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.Button(nativeLabel, size);
				return result != 0;
			}
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		public static bool Button(ReadOnlySpan<char> label, Vector2 size)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.Button(nativeLabel, size);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		public static bool Button(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.Button(nativeLabel, size);
				return result != 0;
			}
		}

		/// <summary>
		/// button<br/>
		/// </summary>
		public static bool Button(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.Button(nativeLabel, size);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		public static bool SmallButton(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.SmallButton(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text<br/>
		/// </summary>
		public static bool SmallButton(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.SmallButton(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static bool InvisibleButton(ReadOnlySpan<byte> strId, Vector2 size, ImGuiButtonFlags flags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.InvisibleButton(nativeStrId, size, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static bool InvisibleButton(ReadOnlySpan<char> strId, Vector2 size, ImGuiButtonFlags flags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.InvisibleButton(nativeStrId, size, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static bool InvisibleButton(ReadOnlySpan<byte> strId, Vector2 size)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.InvisibleButton(nativeStrId, size, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)<br/>
		/// </summary>
		public static bool InvisibleButton(ReadOnlySpan<char> strId, Vector2 size)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.InvisibleButton(nativeStrId, size, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		public static bool ArrowButton(ReadOnlySpan<byte> strId, ImGuiDir dir)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ArrowButton(nativeStrId, dir);
				return result != 0;
			}
		}

		/// <summary>
		/// square button with an arrow shape<br/>
		/// </summary>
		public static bool ArrowButton(ReadOnlySpan<char> strId, ImGuiDir dir)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ArrowButton(nativeStrId, dir);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool Checkbox(ReadOnlySpan<byte> label, ref bool v)
		{
			var nativeVVal = v ? (byte)1 : (byte)0;
			var nativeV = &nativeVVal;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.Checkbox(nativeLabel, nativeV);
				v = nativeVVal != 0;
				return result != 0;
			}
		}

		public static bool Checkbox(ReadOnlySpan<char> label, ref bool v)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var nativeVVal = v ? (byte)1 : (byte)0;
			var nativeV = &nativeVVal;
			var result = ImGuiNative.Checkbox(nativeLabel, nativeV);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			v = nativeVVal != 0;
			return result != 0;
		}

		public static bool CheckboxFlags(ReadOnlySpan<byte> label, ref int flags, int flagsValue)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				return result != 0;
			}
		}

		public static bool CheckboxFlags(ReadOnlySpan<char> label, ref int flags, int flagsValue)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool CheckboxFlags(ReadOnlySpan<byte> label, ref uint flags, uint flagsValue)
		{
			fixed (byte* nativeLabel = label)
			fixed (uint* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				return result != 0;
			}
		}

		public static bool CheckboxFlags(ReadOnlySpan<char> label, ref uint flags, uint flagsValue)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (uint* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		public static bool RadioButton(ReadOnlySpan<byte> label, bool active)
		{
			var native_active = active ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.RadioButton(nativeLabel, native_active);
				return result != 0;
			}
		}

		/// <summary>
		/// shortcut to handle the above pattern when value is an integer<br/>
		/// </summary>
		public static bool RadioButton(ReadOnlySpan<char> label, bool active)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var native_active = active ? (byte)1 : (byte)0;
			var result = ImGuiNative.RadioButton(nativeLabel, native_active);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool RadioButton(ReadOnlySpan<byte> label, ref int v, int vButton)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.RadioButton(nativeLabel, nativeV, vButton);
				return result != 0;
			}
		}

		public static bool RadioButton(ReadOnlySpan<char> label, ref int v, int vButton)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.RadioButton(nativeLabel, nativeV, vButton);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static void ProgressBar(float fraction, Vector2 sizeArg, ReadOnlySpan<byte> overlay)
		{
			fixed (byte* nativeOverlay = overlay)
			{
				ImGuiNative.ProgressBar(fraction, sizeArg, nativeOverlay);
			}
		}

		public static void ProgressBar(float fraction, Vector2 sizeArg, ReadOnlySpan<char> overlay)
		{
			// Marshaling overlay to native string
			byte* nativeOverlay;
			var byteCountOverlay = 0;
			if (overlay != null && !overlay.IsEmpty)
			{
				byteCountOverlay = Encoding.UTF8.GetByteCount(overlay);
				if(byteCountOverlay > Utils.MaxStackallocSize)
				{
					nativeOverlay = Utils.Alloc<byte>(byteCountOverlay + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountOverlay + 1];
					nativeOverlay = stackallocBytes;
				}
				var offsetOverlay = Utils.EncodeStringUTF8(overlay, nativeOverlay, byteCountOverlay);
				nativeOverlay[offsetOverlay] = 0;
			}
			else nativeOverlay = null;

			ImGuiNative.ProgressBar(fraction, sizeArg, nativeOverlay);
			// Freeing overlay native string
			if (byteCountOverlay > Utils.MaxStackallocSize)
				Utils.Free(nativeOverlay);
		}

		public static void ProgressBar(float fraction, Vector2 sizeArg)
		{
			// defining omitted parameters
			byte* overlay = null;
			ImGuiNative.ProgressBar(fraction, sizeArg, overlay);
		}

		public static void ProgressBar(float fraction)
		{
			// defining omitted parameters
			byte* overlay = null;
			Vector2 sizeArg = new Vector2(- float.MinValue,0);
			ImGuiNative.ProgressBar(fraction, sizeArg, overlay);
		}

		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses<br/>
		/// </summary>
		public static void Bullet()
		{
			ImGuiNative.Bullet();
		}

		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		public static bool TextLink(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TextLink(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// hyperlink text button, return true when clicked<br/>
		/// </summary>
		public static bool TextLink(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.TextLink(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<byte> label, ReadOnlySpan<byte> url)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeUrl = url)
			{
				ImGuiNative.TextLinkOpenURL(nativeLabel, nativeUrl);
			}
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<char> label, ReadOnlySpan<char> url)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling url to native string
			byte* nativeUrl;
			var byteCountUrl = 0;
			if (url != null && !url.IsEmpty)
			{
				byteCountUrl = Encoding.UTF8.GetByteCount(url);
				if(byteCountUrl > Utils.MaxStackallocSize)
				{
					nativeUrl = Utils.Alloc<byte>(byteCountUrl + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountUrl + 1];
					nativeUrl = stackallocBytes;
				}
				var offsetUrl = Utils.EncodeStringUTF8(url, nativeUrl, byteCountUrl);
				nativeUrl[offsetUrl] = 0;
			}
			else nativeUrl = null;

			ImGuiNative.TextLinkOpenURL(nativeLabel, nativeUrl);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing url native string
			if (byteCountUrl > Utils.MaxStackallocSize)
				Utils.Free(nativeUrl);
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			byte* url = null;
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TextLinkOpenURL(nativeLabel, url);
			}
		}

		/// <summary>
		/// hyperlink text button, automatically open file/url when clicked<br/>
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			byte* url = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.TextLinkOpenURL(nativeLabel, url);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void Image(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1)
		{
			ImGuiNative.Image(userTextureId, imageSize, uv0, uv1);
		}

		public static void Image(ulong userTextureId, Vector2 imageSize, Vector2 uv0)
		{
			// defining omitted parameters
			Vector2 uv1 = new Vector2(1,1);
			ImGuiNative.Image(userTextureId, imageSize, uv0, uv1);
		}

		public static void Image(ulong userTextureId, Vector2 imageSize)
		{
			// defining omitted parameters
			Vector2 uv1 = new Vector2(1,1);
			Vector2 uv0 = new Vector2(0,0);
			ImGuiNative.Image(userTextureId, imageSize, uv0, uv1);
		}

		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			ImGuiNative.ImageWithBg(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			ImGuiNative.ImageWithBg(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			ImGuiNative.ImageWithBg(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize, Vector2 uv0)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			Vector2 uv1 = new Vector2(1,1);
			ImGuiNative.ImageWithBg(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		public static void ImageWithBg(ulong userTextureId, Vector2 imageSize)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			Vector2 uv1 = new Vector2(1,1);
			Vector2 uv0 = new Vector2(0,0);
			ImGuiNative.ImageWithBg(userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
		}

		public static bool ImageButton(ReadOnlySpan<byte> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
				return result != 0;
			}
		}

		public static bool ImageButton(ReadOnlySpan<char> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool ImageButton(ReadOnlySpan<byte> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
				return result != 0;
			}
		}

		public static bool ImageButton(ReadOnlySpan<char> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool ImageButton(ReadOnlySpan<byte> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
				return result != 0;
			}
		}

		public static bool ImageButton(ReadOnlySpan<char> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool ImageButton(ReadOnlySpan<byte> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			Vector2 uv1 = new Vector2(1,1);
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
				return result != 0;
			}
		}

		public static bool ImageButton(ReadOnlySpan<char> strId, ulong userTextureId, Vector2 imageSize, Vector2 uv0)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			Vector2 uv1 = new Vector2(1,1);
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool ImageButton(ReadOnlySpan<byte> strId, ulong userTextureId, Vector2 imageSize)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			Vector2 uv1 = new Vector2(1,1);
			Vector2 uv0 = new Vector2(0,0);
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
				return result != 0;
			}
		}

		public static bool ImageButton(ReadOnlySpan<char> strId, ulong userTextureId, Vector2 imageSize)
		{
			// defining omitted parameters
			Vector4 tintCol = new Vector4(1,1,1,1);
			Vector4 bgCol = new Vector4(0,0,0,0);
			Vector2 uv1 = new Vector2(1,1);
			Vector2 uv0 = new Vector2(0,0);
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ImageButton(nativeStrId, userTextureId, imageSize, uv0, uv1, bgCol, tintCol);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool BeginCombo(ReadOnlySpan<byte> label, ReadOnlySpan<byte> previewValue, ImGuiComboFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativePreviewValue = previewValue)
			{
				var result = ImGuiNative.BeginCombo(nativeLabel, nativePreviewValue, flags);
				return result != 0;
			}
		}

		public static bool BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> previewValue, ImGuiComboFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling previewValue to native string
			byte* nativePreviewValue;
			var byteCountPreviewValue = 0;
			if (previewValue != null && !previewValue.IsEmpty)
			{
				byteCountPreviewValue = Encoding.UTF8.GetByteCount(previewValue);
				if(byteCountPreviewValue > Utils.MaxStackallocSize)
				{
					nativePreviewValue = Utils.Alloc<byte>(byteCountPreviewValue + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPreviewValue + 1];
					nativePreviewValue = stackallocBytes;
				}
				var offsetPreviewValue = Utils.EncodeStringUTF8(previewValue, nativePreviewValue, byteCountPreviewValue);
				nativePreviewValue[offsetPreviewValue] = 0;
			}
			else nativePreviewValue = null;

			var result = ImGuiNative.BeginCombo(nativeLabel, nativePreviewValue, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing previewValue native string
			if (byteCountPreviewValue > Utils.MaxStackallocSize)
				Utils.Free(nativePreviewValue);
			return result != 0;
		}

		public static bool BeginCombo(ReadOnlySpan<byte> label, ReadOnlySpan<byte> previewValue)
		{
			// defining omitted parameters
			ImGuiComboFlags flags = ImGuiComboFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativePreviewValue = previewValue)
			{
				var result = ImGuiNative.BeginCombo(nativeLabel, nativePreviewValue, flags);
				return result != 0;
			}
		}

		public static bool BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> previewValue)
		{
			// defining omitted parameters
			ImGuiComboFlags flags = ImGuiComboFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling previewValue to native string
			byte* nativePreviewValue;
			var byteCountPreviewValue = 0;
			if (previewValue != null && !previewValue.IsEmpty)
			{
				byteCountPreviewValue = Encoding.UTF8.GetByteCount(previewValue);
				if(byteCountPreviewValue > Utils.MaxStackallocSize)
				{
					nativePreviewValue = Utils.Alloc<byte>(byteCountPreviewValue + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPreviewValue + 1];
					nativePreviewValue = stackallocBytes;
				}
				var offsetPreviewValue = Utils.EncodeStringUTF8(previewValue, nativePreviewValue, byteCountPreviewValue);
				nativePreviewValue[offsetPreviewValue] = 0;
			}
			else nativePreviewValue = null;

			var result = ImGuiNative.BeginCombo(nativeLabel, nativePreviewValue, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing previewValue native string
			if (byteCountPreviewValue > Utils.MaxStackallocSize)
				Utils.Free(nativePreviewValue);
			return result != 0;
		}

		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!<br/>
		/// </summary>
		public static void EndCombo()
		{
			ImGuiNative.EndCombo();
		}

		public static bool ComboStrArr(ReadOnlySpan<byte> label, ref int currentItem, ref byte* items, int itemsCount, int popupMaxHeightInItems)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeCurrentItem = &currentItem)
			fixed (byte** nativeItems = &items)
			{
				var result = ImGuiNative.ComboStrArr(nativeLabel, nativeCurrentItem, nativeItems, itemsCount, popupMaxHeightInItems);
				return result != 0;
			}
		}

		public static bool ComboStrArr(ReadOnlySpan<char> label, ref int currentItem, ref byte* items, int itemsCount, int popupMaxHeightInItems)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeCurrentItem = &currentItem)
			fixed (byte** nativeItems = &items)
			{
				var result = ImGuiNative.ComboStrArr(nativeLabel, nativeCurrentItem, nativeItems, itemsCount, popupMaxHeightInItems);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool Combo(ReadOnlySpan<byte> label, ref int currentItem, ReadOnlySpan<byte> itemsSeparatedByZeros, int popupMaxHeightInItems)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeCurrentItem = &currentItem)
			fixed (byte* nativeItemsSeparatedByZeros = itemsSeparatedByZeros)
			{
				var result = ImGuiNative.Combo(nativeLabel, nativeCurrentItem, nativeItemsSeparatedByZeros, popupMaxHeightInItems);
				return result != 0;
			}
		}

		public static bool Combo(ReadOnlySpan<char> label, ref int currentItem, ReadOnlySpan<char> itemsSeparatedByZeros, int popupMaxHeightInItems)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling itemsSeparatedByZeros to native string
			byte* nativeItemsSeparatedByZeros;
			var byteCountItemsSeparatedByZeros = 0;
			if (itemsSeparatedByZeros != null && !itemsSeparatedByZeros.IsEmpty)
			{
				byteCountItemsSeparatedByZeros = Encoding.UTF8.GetByteCount(itemsSeparatedByZeros);
				if(byteCountItemsSeparatedByZeros > Utils.MaxStackallocSize)
				{
					nativeItemsSeparatedByZeros = Utils.Alloc<byte>(byteCountItemsSeparatedByZeros + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountItemsSeparatedByZeros + 1];
					nativeItemsSeparatedByZeros = stackallocBytes;
				}
				var offsetItemsSeparatedByZeros = Utils.EncodeStringUTF8(itemsSeparatedByZeros, nativeItemsSeparatedByZeros, byteCountItemsSeparatedByZeros);
				nativeItemsSeparatedByZeros[offsetItemsSeparatedByZeros] = 0;
			}
			else nativeItemsSeparatedByZeros = null;

			fixed (int* nativeCurrentItem = &currentItem)
			{
				var result = ImGuiNative.Combo(nativeLabel, nativeCurrentItem, nativeItemsSeparatedByZeros, popupMaxHeightInItems);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing itemsSeparatedByZeros native string
				if (byteCountItemsSeparatedByZeros > Utils.MaxStackallocSize)
					Utils.Free(nativeItemsSeparatedByZeros);
				return result != 0;
			}
		}

		public static bool Combo(ReadOnlySpan<byte> label, ref int currentItem, IgComboGetter getter, IntPtr userData, int itemsCount, int popupMaxHeightInItems)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeCurrentItem = &currentItem)
			{
				var result = ImGuiNative.Combo(nativeLabel, nativeCurrentItem, getter, (void*)userData, itemsCount, popupMaxHeightInItems);
				return result != 0;
			}
		}

		public static bool Combo(ReadOnlySpan<char> label, ref int currentItem, IgComboGetter getter, IntPtr userData, int itemsCount, int popupMaxHeightInItems)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeCurrentItem = &currentItem)
			{
				var result = ImGuiNative.Combo(nativeLabel, nativeCurrentItem, getter, (void*)userData, itemsCount, popupMaxHeightInItems);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<byte> label, ref float v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<byte> label, ref float v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<byte> label, ref float v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<byte> label, ref float v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<byte> label, ref float v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<byte> label, ref float v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<byte> label, ref Vector2 v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<byte> label, ref Vector3 v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<byte> label, ref Vector4 v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.DragFloat4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format, ReadOnlySpan<byte> formatMax, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			fixed (byte* nativeFormat = format)
			fixed (byte* nativeFormatMax = formatMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ReadOnlySpan<char> formatMax, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			// Marshaling formatMax to native string
			byte* nativeFormatMax;
			var byteCountFormatMax = 0;
			if (formatMax != null && !formatMax.IsEmpty)
			{
				byteCountFormatMax = Encoding.UTF8.GetByteCount(formatMax);
				if(byteCountFormatMax > Utils.MaxStackallocSize)
				{
					nativeFormatMax = Utils.Alloc<byte>(byteCountFormatMax + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormatMax + 1];
					nativeFormatMax = stackallocBytes;
				}
				var offsetFormatMax = Utils.EncodeStringUTF8(formatMax, nativeFormatMax, byteCountFormatMax);
				nativeFormatMax[offsetFormatMax] = 0;
			}
			else nativeFormatMax = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				// Freeing formatMax native string
				if (byteCountFormatMax > Utils.MaxStackallocSize)
					Utils.Free(nativeFormatMax);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format, ReadOnlySpan<byte> formatMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			fixed (byte* nativeFormat = format)
			fixed (byte* nativeFormatMax = formatMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format, ReadOnlySpan<char> formatMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			// Marshaling formatMax to native string
			byte* nativeFormatMax;
			var byteCountFormatMax = 0;
			if (formatMax != null && !formatMax.IsEmpty)
			{
				byteCountFormatMax = Encoding.UTF8.GetByteCount(formatMax);
				if(byteCountFormatMax > Utils.MaxStackallocSize)
				{
					nativeFormatMax = Utils.Alloc<byte>(byteCountFormatMax + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormatMax + 1];
					nativeFormatMax = stackallocBytes;
				}
				var offsetFormatMax = Utils.EncodeStringUTF8(formatMax, nativeFormatMax, byteCountFormatMax);
				nativeFormatMax[offsetFormatMax] = 0;
			}
			else nativeFormatMax = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				// Freeing formatMax native string
				if (byteCountFormatMax > Utils.MaxStackallocSize)
					Utils.Free(nativeFormatMax);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed, float vMin)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax, float vSpeed)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<byte> label, ref float vCurrentMin, ref float vCurrentMax)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float vCurrentMin, ref float vCurrentMax)
		{
			// defining omitted parameters
			float vMax = 0.0f;
			float vMin = 0.0f;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVCurrentMin = &vCurrentMin)
			fixed (float* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragFloatRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<byte> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// If v_min &gt;= v_max we have no bound<br/>
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<byte> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<char> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt2(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt2(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<byte> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<char> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt3(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt3(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<byte> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<byte> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<char> label, ref int v, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragInt4(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.DragInt4(nativeLabel, nativeV, vSpeed, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format, ReadOnlySpan<byte> formatMax, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			fixed (byte* nativeFormat = format)
			fixed (byte* nativeFormatMax = formatMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ReadOnlySpan<char> formatMax, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			// Marshaling formatMax to native string
			byte* nativeFormatMax;
			var byteCountFormatMax = 0;
			if (formatMax != null && !formatMax.IsEmpty)
			{
				byteCountFormatMax = Encoding.UTF8.GetByteCount(formatMax);
				if(byteCountFormatMax > Utils.MaxStackallocSize)
				{
					nativeFormatMax = Utils.Alloc<byte>(byteCountFormatMax + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormatMax + 1];
					nativeFormatMax = stackallocBytes;
				}
				var offsetFormatMax = Utils.EncodeStringUTF8(formatMax, nativeFormatMax, byteCountFormatMax);
				nativeFormatMax[offsetFormatMax] = 0;
			}
			else nativeFormatMax = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				// Freeing formatMax native string
				if (byteCountFormatMax > Utils.MaxStackallocSize)
					Utils.Free(nativeFormatMax);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format, ReadOnlySpan<byte> formatMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			fixed (byte* nativeFormat = format)
			fixed (byte* nativeFormatMax = formatMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format, ReadOnlySpan<char> formatMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			// Marshaling formatMax to native string
			byte* nativeFormatMax;
			var byteCountFormatMax = 0;
			if (formatMax != null && !formatMax.IsEmpty)
			{
				byteCountFormatMax = Encoding.UTF8.GetByteCount(formatMax);
				if(byteCountFormatMax > Utils.MaxStackallocSize)
				{
					nativeFormatMax = Utils.Alloc<byte>(byteCountFormatMax + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormatMax + 1];
					nativeFormatMax = stackallocBytes;
				}
				var offsetFormatMax = Utils.EncodeStringUTF8(formatMax, nativeFormatMax, byteCountFormatMax);
				nativeFormatMax[offsetFormatMax] = 0;
			}
			else nativeFormatMax = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, nativeFormatMax, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				// Freeing formatMax native string
				if (byteCountFormatMax > Utils.MaxStackallocSize)
					Utils.Free(nativeFormatMax);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed, int vMin)
		{
			// defining omitted parameters
			int vMax = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax, float vSpeed)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<byte> label, ref int vCurrentMin, ref int vCurrentMax)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeFormat, formatMax, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int vCurrentMin, ref int vCurrentMax)
		{
			// defining omitted parameters
			int vMax = 0;
			int vMin = 0;
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* formatMax = null;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeVCurrentMin = &vCurrentMin)
			fixed (int* nativeVCurrentMax = &vCurrentMax)
			{
				var result = ImGuiNative.DragIntRange2(nativeLabel, nativeVCurrentMin, nativeVCurrentMax, vSpeed, vMin, vMax, nativeNativeFormat, formatMax, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool DragScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool DragScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, (void*)pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, float vSpeed, IntPtr pMin)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, (void*)pMin, pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, float vSpeed)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, pMin, pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, float vSpeed)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, pMin, pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData)
		{
			// defining omitted parameters
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, pMin, pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData)
		{
			// defining omitted parameters
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalar(nativeLabel, dataType, (void*)pData, vSpeed, pMin, pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool DragScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool DragScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, (void*)pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed, IntPtr pMin)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, (void*)pMin, pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, pMin, pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, float vSpeed)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, pMin, pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool DragScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components)
		{
			// defining omitted parameters
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, pMin, pMax, format, flags);
				return result != 0;
			}
		}

		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components)
		{
			// defining omitted parameters
			float vSpeed = 1.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			void* pMax = null;
			void* pMin = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.DragScalarN(nativeLabel, dataType, (void*)pData, components, vSpeed, pMin, pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static bool SliderFloat(ReadOnlySpan<byte> label, ref float v, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static bool SliderFloat(ReadOnlySpan<byte> label, ref float v, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static bool SliderFloat(ReadOnlySpan<byte> label, ref float v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		/// <summary>
		/// adjust format to decorate the value with a prefix or a suffix for in-slider labels or unit display.<br/>
		/// </summary>
		public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat2(ReadOnlySpan<byte> label, ref Vector2 v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat2(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat3(ReadOnlySpan<byte> label, ref Vector3 v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat3(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderFloat4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat4(ReadOnlySpan<byte> label, ref Vector4 v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.SliderFloat4(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<byte> label, ref float vRad, float vDegreesMin, float vDegreesMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVRad = &vRad)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<char> label, ref float vRad, float vDegreesMin, float vDegreesMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<byte> label, ref float vRad, float vDegreesMin, float vDegreesMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVRad = &vRad)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<char> label, ref float vRad, float vDegreesMin, float vDegreesMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<byte> label, ref float vRad, float vDegreesMin, float vDegreesMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.0f deg");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.0f deg", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<char> label, ref float vRad, float vDegreesMin, float vDegreesMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.0f deg");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.0f deg", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<byte> label, ref float vRad, float vDegreesMin)
		{
			// defining omitted parameters
			float vDegreesMax = +360.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.0f deg");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.0f deg", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<char> label, ref float vRad, float vDegreesMin)
		{
			// defining omitted parameters
			float vDegreesMax = +360.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.0f deg");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.0f deg", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<byte> label, ref float vRad)
		{
			// defining omitted parameters
			float vDegreesMax = +360.0f;
			float vDegreesMin = -360.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.0f deg");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.0f deg", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderAngle(ReadOnlySpan<char> label, ref float vRad)
		{
			// defining omitted parameters
			float vDegreesMax = +360.0f;
			float vDegreesMin = -360.0f;
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.0f deg");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.0f deg", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeVRad = &vRad)
			{
				var result = ImGuiNative.SliderAngle(nativeLabel, nativeVRad, vDegreesMin, vDegreesMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderInt(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderInt2(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt2(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt2(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt2(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt2(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt2(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt2(ReadOnlySpan<char> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt2(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderInt3(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt3(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt3(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt3(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt3(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt3(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt3(ReadOnlySpan<char> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt3(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderInt4(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt4(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt4(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderInt4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderInt4(ReadOnlySpan<char> label, ref int v, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt4(ReadOnlySpan<byte> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt4(nativeLabel, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool SliderInt4(ReadOnlySpan<char> label, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.SliderInt4(nativeLabel, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool SliderScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderScalar(nativeLabel, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.SliderScalar(nativeLabel, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool SliderScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderScalar(nativeLabel, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.SliderScalar(nativeLabel, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool SliderScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.SliderScalar(nativeLabel, dataType, (void*)pData, (void*)pMin, (void*)pMax, format, flags);
				return result != 0;
			}
		}

		public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.SliderScalar(nativeLabel, dataType, (void*)pData, (void*)pMin, (void*)pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool SliderScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.SliderScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool SliderScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.SliderScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool SliderScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.SliderScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, format, flags);
				return result != 0;
			}
		}

		public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.SliderScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pMin, (void*)pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool VSliderFloat(ReadOnlySpan<byte> label, Vector2 size, ref float v, float vMin, float vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.VSliderFloat(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float vMin, float vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.VSliderFloat(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool VSliderFloat(ReadOnlySpan<byte> label, Vector2 size, ref float v, float vMin, float vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.VSliderFloat(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float vMin, float vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.VSliderFloat(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool VSliderFloat(ReadOnlySpan<byte> label, Vector2 size, ref float v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.VSliderFloat(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float vMin, float vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.VSliderFloat(nativeLabel, size, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool VSliderInt(ReadOnlySpan<byte> label, Vector2 size, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.VSliderInt(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int vMin, int vMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.VSliderInt(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool VSliderInt(ReadOnlySpan<byte> label, Vector2 size, ref int v, int vMin, int vMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.VSliderInt(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int vMin, int vMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.VSliderInt(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool VSliderInt(ReadOnlySpan<byte> label, Vector2 size, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%d", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.VSliderInt(nativeLabel, size, nativeV, vMin, vMax, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int vMin, int vMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%d");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%d", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.VSliderInt(nativeLabel, size, nativeV, vMin, vMax, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool VSliderScalar(ReadOnlySpan<byte> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.VSliderScalar(nativeLabel, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.VSliderScalar(nativeLabel, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool VSliderScalar(ReadOnlySpan<byte> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.VSliderScalar(nativeLabel, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.VSliderScalar(nativeLabel, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool VSliderScalar(ReadOnlySpan<byte> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.VSliderScalar(nativeLabel, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, format, flags);
				return result != 0;
			}
		}

		public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax)
		{
			// defining omitted parameters
			ImGuiSliderFlags flags = ImGuiSliderFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.VSliderScalar(nativeLabel, size, dataType, (void*)pData, (void*)pMin, (void*)pMax, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool InputText(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, (void*)userData);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, (void*)userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint bufSize, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<byte> label, byte[] buf, uint bufSize)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint bufSize)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputText(nativeLabel, nativeBuf, bufSize, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, (void*)userData);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, (void*)userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint bufSize, Vector2 size, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<byte> label, byte[] buf, uint bufSize, Vector2 size)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint bufSize, Vector2 size)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<byte> label, byte[] buf, uint bufSize)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			Vector2 size = new Vector2(0,0);
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint bufSize)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			Vector2 size = new Vector2(0,0);
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextMultiline(nativeLabel, nativeBuf, bufSize, size, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, (void*)userData);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, (void*)userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint bufSize, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, uint bufSize, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint bufSize, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, uint bufSize)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint bufSize)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextWithHint(nativeLabel, nativeHint, nativeBuf, bufSize, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<byte> label, ref float v, float step, float stepFast, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float stepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<byte> label, ref float v, float step, float stepFast, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float stepFast, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<byte> label, ref float v, float step, float stepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float stepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<byte> label, ref float v, float step)
		{
			// defining omitted parameters
			float stepFast = 0.0f;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step)
		{
			// defining omitted parameters
			float stepFast = 0.0f;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<byte> label, ref float v)
		{
			// defining omitted parameters
			float stepFast = 0.0f;
			float step = 0.0f;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat(ReadOnlySpan<char> label, ref float v)
		{
			// defining omitted parameters
			float stepFast = 0.0f;
			float step = 0.0f;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (float* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat(nativeLabel, nativeV, step, stepFast, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputFloat2(ReadOnlySpan<byte> label, ref Vector2 v, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat2(nativeLabel, nativeV, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat2(nativeLabel, nativeV, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat2(ReadOnlySpan<byte> label, ref Vector2 v, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat2(nativeLabel, nativeV, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat2(nativeLabel, nativeV, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat2(ReadOnlySpan<byte> label, ref Vector2 v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat2(nativeLabel, nativeV, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector2* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat2(nativeLabel, nativeV, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputFloat3(ReadOnlySpan<byte> label, ref Vector3 v, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat3(nativeLabel, nativeV, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat3(nativeLabel, nativeV, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat3(ReadOnlySpan<byte> label, ref Vector3 v, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat3(nativeLabel, nativeV, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat3(nativeLabel, nativeV, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat3(ReadOnlySpan<byte> label, ref Vector3 v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat3(nativeLabel, nativeV, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat3(nativeLabel, nativeV, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputFloat4(ReadOnlySpan<byte> label, ref Vector4 v, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat4(nativeLabel, nativeV, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat4(nativeLabel, nativeV, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat4(ReadOnlySpan<byte> label, ref Vector4 v, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputFloat4(nativeLabel, nativeV, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat4(nativeLabel, nativeV, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat4(ReadOnlySpan<byte> label, ref Vector4 v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat4(nativeLabel, nativeV, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.3f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.3f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeV = &v)
			{
				var result = ImGuiNative.InputFloat4(nativeLabel, nativeV, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<byte> label, ref int v, int step, int stepFast, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step, int stepFast, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<byte> label, ref int v, int step, int stepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step, int stepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<byte> label, ref int v, int step)
		{
			// defining omitted parameters
			int stepFast = 100;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step)
		{
			// defining omitted parameters
			int stepFast = 100;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			int stepFast = 100;
			int step = 1;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				return result != 0;
			}
		}

		public static bool InputInt(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			int stepFast = 100;
			int step = 1;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt(nativeLabel, nativeV, step, stepFast, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt2(ReadOnlySpan<byte> label, ref int v, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt2(nativeLabel, nativeV, flags);
				return result != 0;
			}
		}

		public static bool InputInt2(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt2(nativeLabel, nativeV, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt2(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt2(nativeLabel, nativeV, flags);
				return result != 0;
			}
		}

		public static bool InputInt2(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt2(nativeLabel, nativeV, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt3(ReadOnlySpan<byte> label, ref int v, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt3(nativeLabel, nativeV, flags);
				return result != 0;
			}
		}

		public static bool InputInt3(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt3(nativeLabel, nativeV, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt3(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt3(nativeLabel, nativeV, flags);
				return result != 0;
			}
		}

		public static bool InputInt3(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt3(nativeLabel, nativeV, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt4(ReadOnlySpan<byte> label, ref int v, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt4(nativeLabel, nativeV, flags);
				return result != 0;
			}
		}

		public static bool InputInt4(ReadOnlySpan<char> label, ref int v, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt4(nativeLabel, nativeV, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputInt4(ReadOnlySpan<byte> label, ref int v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt4(nativeLabel, nativeV, flags);
				return result != 0;
			}
		}

		public static bool InputInt4(ReadOnlySpan<char> label, ref int v)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeV = &v)
			{
				var result = ImGuiNative.InputInt4(nativeLabel, nativeV, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<byte> label, ref double v, double step, double stepFast, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (double* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double stepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<byte> label, ref double v, double step, double stepFast, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (double* nativeV = &v)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double stepFast, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<byte> label, ref double v, double step, double stepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.6f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.6f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double stepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.6f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.6f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<byte> label, ref double v, double step)
		{
			// defining omitted parameters
			double stepFast = 0.0;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.6f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.6f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step)
		{
			// defining omitted parameters
			double stepFast = 0.0;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.6f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.6f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<byte> label, ref double v)
		{
			// defining omitted parameters
			double stepFast = 0.0;
			double step = 0.0;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeFormat = null;
			var byteCountFormat = Encoding.UTF8.GetByteCount("%.6f");
			if(byteCountFormat > Utils.MaxStackallocSize)
			{
				nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountFormat + 1];
				nativeFormat = stackallocBytes;
			}
			var offsetNativeFormat = Utils.EncodeStringUTF8("%.6f", nativeFormat, byteCountFormat);
			nativeFormat[offsetNativeFormat] = 0;
			fixed (byte* nativeLabel = label)
			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeFormat, flags);
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result != 0;
			}
		}

		public static bool InputDouble(ReadOnlySpan<char> label, ref double v)
		{
			// defining omitted parameters
			double stepFast = 0.0;
			double step = 0.0;
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* nativeNativeFormat = null;
			var byteCountNativeFormat = Encoding.UTF8.GetByteCount("%.6f");
			if(byteCountNativeFormat > Utils.MaxStackallocSize)
			{
				nativeNativeFormat = Utils.Alloc<byte>(byteCountNativeFormat + 1);
			}
			else
			{
				var stackallocBytes = stackalloc byte[byteCountNativeFormat + 1];
				nativeNativeFormat = stackallocBytes;
			}
			var offsetNativeNativeFormat = Utils.EncodeStringUTF8("%.6f", nativeNativeFormat, byteCountNativeFormat);
			nativeNativeFormat[offsetNativeNativeFormat] = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (double* nativeV = &v)
			{
				var result = ImGuiNative.InputDouble(nativeLabel, nativeV, step, stepFast, nativeNativeFormat, flags);
				if (byteCountNativeFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeNativeFormat);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool InputScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool InputScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool InputScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, format, flags);
				return result != 0;
			}
		}

		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep, IntPtr pStepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, (void*)pStepFast, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool InputScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, pStepFast, format, flags);
				return result != 0;
			}
		}

		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, IntPtr pStep)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, (void*)pStep, pStepFast, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool InputScalar(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			void* pStep = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, pStep, pStepFast, format, flags);
				return result != 0;
			}
		}

		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			void* pStep = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.InputScalar(nativeLabel, dataType, (void*)pData, pStep, pStepFast, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool InputScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<byte> format, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool InputScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
				return result != 0;
			}
		}

		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, nativeFormat, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool InputScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, format, flags);
				return result != 0;
			}
		}

		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep, IntPtr pStepFast)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, (void*)pStepFast, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool InputScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, pStepFast, format, flags);
				return result != 0;
			}
		}

		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components, IntPtr pStep)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, (void*)pStep, pStepFast, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool InputScalarN(ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, int components)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			void* pStep = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, pStep, pStepFast, format, flags);
				return result != 0;
			}
		}

		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, int components)
		{
			// defining omitted parameters
			ImGuiInputTextFlags flags = ImGuiInputTextFlags.None;
			byte* format = null;
			void* pStepFast = null;
			void* pStep = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.InputScalarN(nativeLabel, dataType, (void*)pData, components, pStep, pStepFast, format, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ColorEdit3(ReadOnlySpan<byte> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit3(nativeLabel, nativeCol, flags);
				return result != 0;
			}
		}

		public static bool ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit3(nativeLabel, nativeCol, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorEdit3(ReadOnlySpan<byte> label, ref Vector3 col)
		{
			// defining omitted parameters
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit3(nativeLabel, nativeCol, flags);
				return result != 0;
			}
		}

		public static bool ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col)
		{
			// defining omitted parameters
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit3(nativeLabel, nativeCol, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorEdit4(ReadOnlySpan<byte> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit4(nativeLabel, nativeCol, flags);
				return result != 0;
			}
		}

		public static bool ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit4(nativeLabel, nativeCol, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorEdit4(ReadOnlySpan<byte> label, ref Vector4 col)
		{
			// defining omitted parameters
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit4(nativeLabel, nativeCol, flags);
				return result != 0;
			}
		}

		public static bool ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col)
		{
			// defining omitted parameters
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorEdit4(nativeLabel, nativeCol, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorPicker3(ReadOnlySpan<byte> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker3(nativeLabel, nativeCol, flags);
				return result != 0;
			}
		}

		public static bool ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker3(nativeLabel, nativeCol, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorPicker3(ReadOnlySpan<byte> label, ref Vector3 col)
		{
			// defining omitted parameters
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker3(nativeLabel, nativeCol, flags);
				return result != 0;
			}
		}

		public static bool ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col)
		{
			// defining omitted parameters
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector3* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker3(nativeLabel, nativeCol, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<byte> label, ref Vector4 col, ImGuiColorEditFlags flags, float[] refCol)
		{
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeCol = &col)
			fixed (float* nativeRefCol = refCol)
			{
				var result = ImGuiNative.ColorPicker4(nativeLabel, nativeCol, flags, nativeRefCol);
				return result != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags, float[] refCol)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeCol = &col)
			fixed (float* nativeRefCol = refCol)
			{
				var result = ImGuiNative.ColorPicker4(nativeLabel, nativeCol, flags, nativeRefCol);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<byte> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			// defining omitted parameters
			float* refCol = null;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker4(nativeLabel, nativeCol, flags, refCol);
				return result != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			// defining omitted parameters
			float* refCol = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker4(nativeLabel, nativeCol, flags, refCol);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<byte> label, ref Vector4 col)
		{
			// defining omitted parameters
			float* refCol = null;
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			fixed (byte* nativeLabel = label)
			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker4(nativeLabel, nativeCol, flags, refCol);
				return result != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col)
		{
			// defining omitted parameters
			float* refCol = null;
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (Vector4* nativeCol = &col)
			{
				var result = ImGuiNative.ColorPicker4(nativeLabel, nativeCol, flags, refCol);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<byte> descId, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
		{
			fixed (byte* nativeDescId = descId)
			{
				var result = ImGuiNative.ColorButton(nativeDescId, col, flags, size);
				return result != 0;
			}
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<char> descId, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
		{
			// Marshaling descId to native string
			byte* nativeDescId;
			var byteCountDescId = 0;
			if (descId != null && !descId.IsEmpty)
			{
				byteCountDescId = Encoding.UTF8.GetByteCount(descId);
				if(byteCountDescId > Utils.MaxStackallocSize)
				{
					nativeDescId = Utils.Alloc<byte>(byteCountDescId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountDescId + 1];
					nativeDescId = stackallocBytes;
				}
				var offsetDescId = Utils.EncodeStringUTF8(descId, nativeDescId, byteCountDescId);
				nativeDescId[offsetDescId] = 0;
			}
			else nativeDescId = null;

			var result = ImGuiNative.ColorButton(nativeDescId, col, flags, size);
			// Freeing descId native string
			if (byteCountDescId > Utils.MaxStackallocSize)
				Utils.Free(nativeDescId);
			return result != 0;
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<byte> descId, Vector4 col, ImGuiColorEditFlags flags)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			fixed (byte* nativeDescId = descId)
			{
				var result = ImGuiNative.ColorButton(nativeDescId, col, flags, size);
				return result != 0;
			}
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<char> descId, Vector4 col, ImGuiColorEditFlags flags)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			// Marshaling descId to native string
			byte* nativeDescId;
			var byteCountDescId = 0;
			if (descId != null && !descId.IsEmpty)
			{
				byteCountDescId = Encoding.UTF8.GetByteCount(descId);
				if(byteCountDescId > Utils.MaxStackallocSize)
				{
					nativeDescId = Utils.Alloc<byte>(byteCountDescId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountDescId + 1];
					nativeDescId = stackallocBytes;
				}
				var offsetDescId = Utils.EncodeStringUTF8(descId, nativeDescId, byteCountDescId);
				nativeDescId[offsetDescId] = 0;
			}
			else nativeDescId = null;

			var result = ImGuiNative.ColorButton(nativeDescId, col, flags, size);
			// Freeing descId native string
			if (byteCountDescId > Utils.MaxStackallocSize)
				Utils.Free(nativeDescId);
			return result != 0;
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<byte> descId, Vector4 col)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			fixed (byte* nativeDescId = descId)
			{
				var result = ImGuiNative.ColorButton(nativeDescId, col, flags, size);
				return result != 0;
			}
		}

		/// <summary>
		/// display a color square/button, hover for details, return true when pressed.<br/>
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<char> descId, Vector4 col)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			ImGuiColorEditFlags flags = ImGuiColorEditFlags.None;
			// Marshaling descId to native string
			byte* nativeDescId;
			var byteCountDescId = 0;
			if (descId != null && !descId.IsEmpty)
			{
				byteCountDescId = Encoding.UTF8.GetByteCount(descId);
				if(byteCountDescId > Utils.MaxStackallocSize)
				{
					nativeDescId = Utils.Alloc<byte>(byteCountDescId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountDescId + 1];
					nativeDescId = stackallocBytes;
				}
				var offsetDescId = Utils.EncodeStringUTF8(descId, nativeDescId, byteCountDescId);
				nativeDescId[offsetDescId] = 0;
			}
			else nativeDescId = null;

			var result = ImGuiNative.ColorButton(nativeDescId, col, flags, size);
			// Freeing descId native string
			if (byteCountDescId > Utils.MaxStackallocSize)
				Utils.Free(nativeDescId);
			return result != 0;
		}

		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.<br/>
		/// </summary>
		public static void SetColorEditOptions(ImGuiColorEditFlags flags)
		{
			ImGuiNative.SetColorEditOptions(flags);
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		public static bool TreeNode(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TreeNode(nativeLabel);
				return result != 0;
			}
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		public static bool TreeNode(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.TreeNode(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool TreeNode(ReadOnlySpan<byte> strId, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeStrId = strId)
			fixed (byte* nativeFmt = fmt)
			{
				var result = ImGuiNative.TreeNode(nativeStrId, nativeFmt);
				return result != 0;
			}
		}

		public static bool TreeNode(ReadOnlySpan<char> strId, ReadOnlySpan<char> fmt)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			var result = ImGuiNative.TreeNode(nativeStrId, nativeFmt);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
			return result != 0;
		}

		public static bool TreeNode(IntPtr ptrId, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				var result = ImGuiNative.TreeNode((void*)ptrId, nativeFmt);
				return result != 0;
			}
		}

		public static bool TreeNode(IntPtr ptrId, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			var result = ImGuiNative.TreeNode((void*)ptrId, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
			return result != 0;
		}

		public static bool TreeNodeEx(ReadOnlySpan<byte> label, ImGuiTreeNodeFlags flags)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TreeNodeEx(nativeLabel, flags);
				return result != 0;
			}
		}

		public static bool TreeNodeEx(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.TreeNodeEx(nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool TreeNodeEx(ReadOnlySpan<byte> strId, ImGuiTreeNodeFlags flags, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeStrId = strId)
			fixed (byte* nativeFmt = fmt)
			{
				var result = ImGuiNative.TreeNodeEx(nativeStrId, flags, nativeFmt);
				return result != 0;
			}
		}

		public static bool TreeNodeEx(ReadOnlySpan<char> strId, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			var result = ImGuiNative.TreeNodeEx(nativeStrId, flags, nativeFmt);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
			return result != 0;
		}

		public static bool TreeNodeEx(IntPtr ptrId, ImGuiTreeNodeFlags flags, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				var result = ImGuiNative.TreeNodeEx((void*)ptrId, flags, nativeFmt);
				return result != 0;
			}
		}

		public static bool TreeNodeEx(IntPtr ptrId, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			var result = ImGuiNative.TreeNodeEx((void*)ptrId, flags, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
			return result != 0;
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		public static void TreePush(ReadOnlySpan<byte> strId)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.TreePush(nativeStrId);
			}
		}

		/// <summary>
		/// "<br/>
		/// </summary>
		public static void TreePush(ReadOnlySpan<char> strId)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.TreePush(nativeStrId);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		public static void TreePush(IntPtr ptrId)
		{
			ImGuiNative.TreePush((void*)ptrId);
		}

		/// <summary>
		/// ~ Unindent()+PopID()<br/>
		/// </summary>
		public static void TreePop()
		{
			ImGuiNative.TreePop();
		}

		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode<br/>
		/// </summary>
		public static float GetTreeNodeToLabelSpacing()
		{
			return ImGuiNative.GetTreeNodeToLabelSpacing();
		}

		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		public static bool CollapsingHeader(ReadOnlySpan<byte> label, ImGuiTreeNodeFlags flags)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.CollapsingHeader(nativeLabel, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.<br/>
		/// </summary>
		public static bool CollapsingHeader(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.CollapsingHeader(nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool CollapsingHeader(ReadOnlySpan<byte> label, ref bool pVisible, ImGuiTreeNodeFlags flags)
		{
			var nativePVisibleVal = pVisible ? (byte)1 : (byte)0;
			var nativePVisible = &nativePVisibleVal;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.CollapsingHeader(nativeLabel, nativePVisible, flags);
				pVisible = nativePVisibleVal != 0;
				return result != 0;
			}
		}

		public static bool CollapsingHeader(ReadOnlySpan<char> label, ref bool pVisible, ImGuiTreeNodeFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var nativePVisibleVal = pVisible ? (byte)1 : (byte)0;
			var nativePVisible = &nativePVisibleVal;
			var result = ImGuiNative.CollapsingHeader(nativeLabel, nativePVisible, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			pVisible = nativePVisibleVal != 0;
			return result != 0;
		}

		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		public static void SetNextItemOpen(bool isOpen, ImGuiCond cond)
		{
			var native_isOpen = isOpen ? (byte)1 : (byte)0;
			ImGuiNative.SetNextItemOpen(native_isOpen, cond);
		}

		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.<br/>
		/// </summary>
		public static void SetNextItemOpen(bool isOpen)
		{
			// defining omitted parameters
			ImGuiCond cond = ImGuiCond.None;
			var native_isOpen = isOpen ? (byte)1 : (byte)0;
			ImGuiNative.SetNextItemOpen(native_isOpen, cond);
		}

		/// <summary>
		/// set id to use for open/close storage (default to same as item id).<br/>
		/// </summary>
		public static void SetNextItemStorageID(uint storageId)
		{
			ImGuiNative.SetNextItemStorageID(storageId);
		}

		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		public static bool Selectable(ReadOnlySpan<byte> label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.Selectable(nativeLabel, native_selected, flags, size);
				return result != 0;
			}
		}

		/// <summary>
		/// "bool* p_selected" point to the selection state (read-write), as a convenient helper.<br/>
		/// </summary>
		public static bool Selectable(ReadOnlySpan<char> label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			var result = ImGuiNative.Selectable(nativeLabel, native_selected, flags, size);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool Selectable(ReadOnlySpan<byte> label, ref bool pSelected, ImGuiSelectableFlags flags, Vector2 size)
		{
			var nativePSelectedVal = pSelected ? (byte)1 : (byte)0;
			var nativePSelected = &nativePSelectedVal;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.Selectable(nativeLabel, nativePSelected, flags, size);
				pSelected = nativePSelectedVal != 0;
				return result != 0;
			}
		}

		public static bool Selectable(ReadOnlySpan<char> label, ref bool pSelected, ImGuiSelectableFlags flags, Vector2 size)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var nativePSelectedVal = pSelected ? (byte)1 : (byte)0;
			var nativePSelected = &nativePSelectedVal;
			var result = ImGuiNative.Selectable(nativeLabel, nativePSelected, flags, size);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			pSelected = nativePSelectedVal != 0;
			return result != 0;
		}

		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags, int selectionSize, int itemsCount)
		{
			return ImGuiNative.BeginMultiSelect(flags, selectionSize, itemsCount);
		}

		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags, int selectionSize)
		{
			// defining omitted parameters
			int itemsCount = -1;
			return ImGuiNative.BeginMultiSelect(flags, selectionSize, itemsCount);
		}

		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags)
		{
			// defining omitted parameters
			int itemsCount = -1;
			int selectionSize = -1;
			return ImGuiNative.BeginMultiSelect(flags, selectionSize, itemsCount);
		}

		public static ImGuiMultiSelectIOPtr EndMultiSelect()
		{
			return ImGuiNative.EndMultiSelect();
		}

		public static void SetNextItemSelectionUserData(long selectionUserData)
		{
			ImGuiNative.SetNextItemSelectionUserData(selectionUserData);
		}

		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.<br/>
		/// </summary>
		public static bool IsItemToggledSelection()
		{
			var result = ImGuiNative.IsItemToggledSelection();
			return result != 0;
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static bool BeginListBox(ReadOnlySpan<byte> label, Vector2 size)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginListBox(nativeLabel, size);
				return result != 0;
			}
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static bool BeginListBox(ReadOnlySpan<char> label, Vector2 size)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.BeginListBox(nativeLabel, size);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static bool BeginListBox(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginListBox(nativeLabel, size);
				return result != 0;
			}
		}

		/// <summary>
		/// open a framed scrolling region<br/>
		/// </summary>
		public static bool BeginListBox(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			Vector2 size = new Vector2(0,0);
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.BeginListBox(nativeLabel, size);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!<br/>
		/// </summary>
		public static void EndListBox()
		{
			ImGuiNative.EndListBox();
		}

		public static bool ListBoxStrArr(ReadOnlySpan<byte> label, ref int currentItem, ref byte* items, int itemsCount, int heightInItems)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeCurrentItem = &currentItem)
			fixed (byte** nativeItems = &items)
			{
				var result = ImGuiNative.ListBoxStrArr(nativeLabel, nativeCurrentItem, nativeItems, itemsCount, heightInItems);
				return result != 0;
			}
		}

		public static bool ListBoxStrArr(ReadOnlySpan<char> label, ref int currentItem, ref byte* items, int itemsCount, int heightInItems)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeCurrentItem = &currentItem)
			fixed (byte** nativeItems = &items)
			{
				var result = ImGuiNative.ListBoxStrArr(nativeLabel, nativeCurrentItem, nativeItems, itemsCount, heightInItems);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ListBoxFnStrPtr(ReadOnlySpan<byte> label, ref int currentItem, IgComboGetter getter, IntPtr userData, int itemsCount, int heightInItems)
		{
			fixed (byte* nativeLabel = label)
			fixed (int* nativeCurrentItem = &currentItem)
			{
				var result = ImGuiNative.ListBoxFnStrPtr(nativeLabel, nativeCurrentItem, getter, (void*)userData, itemsCount, heightInItems);
				return result != 0;
			}
		}

		public static bool ListBoxFnStrPtr(ReadOnlySpan<char> label, ref int currentItem, IgComboGetter getter, IntPtr userData, int itemsCount, int heightInItems)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (int* nativeCurrentItem = &currentItem)
			{
				var result = ImGuiNative.ListBoxFnStrPtr(nativeLabel, nativeCurrentItem, getter, (void*)userData, itemsCount, heightInItems);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static void PlotLines(ReadOnlySpan<byte> label, float[] values, int valuesCount, int valuesOffset, ReadOnlySpan<byte> overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeValues = values)
			fixed (byte* nativeOverlayText = overlayText)
			{
				ImGuiNative.PlotLines(nativeLabel, nativeValues, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize, stride);
			}
		}

		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling overlayText to native string
			byte* nativeOverlayText;
			var byteCountOverlayText = 0;
			if (overlayText != null && !overlayText.IsEmpty)
			{
				byteCountOverlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCountOverlayText > Utils.MaxStackallocSize)
				{
					nativeOverlayText = Utils.Alloc<byte>(byteCountOverlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountOverlayText + 1];
					nativeOverlayText = stackallocBytes;
				}
				var offsetOverlayText = Utils.EncodeStringUTF8(overlayText, nativeOverlayText, byteCountOverlayText);
				nativeOverlayText[offsetOverlayText] = 0;
			}
			else nativeOverlayText = null;

			fixed (float* nativeValues = values)
			{
				ImGuiNative.PlotLines(nativeLabel, nativeValues, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize, stride);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing overlayText native string
				if (byteCountOverlayText > Utils.MaxStackallocSize)
					Utils.Free(nativeOverlayText);
			}
		}

		public static void PlotLines(ReadOnlySpan<byte> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<byte> overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeOverlayText = overlayText)
			{
				ImGuiNative.PlotLines(nativeLabel, valuesGetter, (void*)data, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize);
			}
		}

		public static void PlotLines(ReadOnlySpan<char> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling overlayText to native string
			byte* nativeOverlayText;
			var byteCountOverlayText = 0;
			if (overlayText != null && !overlayText.IsEmpty)
			{
				byteCountOverlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCountOverlayText > Utils.MaxStackallocSize)
				{
					nativeOverlayText = Utils.Alloc<byte>(byteCountOverlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountOverlayText + 1];
					nativeOverlayText = stackallocBytes;
				}
				var offsetOverlayText = Utils.EncodeStringUTF8(overlayText, nativeOverlayText, byteCountOverlayText);
				nativeOverlayText[offsetOverlayText] = 0;
			}
			else nativeOverlayText = null;

			ImGuiNative.PlotLines(nativeLabel, valuesGetter, (void*)data, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing overlayText native string
			if (byteCountOverlayText > Utils.MaxStackallocSize)
				Utils.Free(nativeOverlayText);
		}

		public static void PlotHistogram(ReadOnlySpan<byte> label, float[] values, int valuesCount, int valuesOffset, ReadOnlySpan<byte> overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			fixed (byte* nativeLabel = label)
			fixed (float* nativeValues = values)
			fixed (byte* nativeOverlayText = overlayText)
			{
				ImGuiNative.PlotHistogram(nativeLabel, nativeValues, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize, stride);
			}
		}

		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize, int stride)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling overlayText to native string
			byte* nativeOverlayText;
			var byteCountOverlayText = 0;
			if (overlayText != null && !overlayText.IsEmpty)
			{
				byteCountOverlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCountOverlayText > Utils.MaxStackallocSize)
				{
					nativeOverlayText = Utils.Alloc<byte>(byteCountOverlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountOverlayText + 1];
					nativeOverlayText = stackallocBytes;
				}
				var offsetOverlayText = Utils.EncodeStringUTF8(overlayText, nativeOverlayText, byteCountOverlayText);
				nativeOverlayText[offsetOverlayText] = 0;
			}
			else nativeOverlayText = null;

			fixed (float* nativeValues = values)
			{
				ImGuiNative.PlotHistogram(nativeLabel, nativeValues, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize, stride);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing overlayText native string
				if (byteCountOverlayText > Utils.MaxStackallocSize)
					Utils.Free(nativeOverlayText);
			}
		}

		public static void PlotHistogram(ReadOnlySpan<byte> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<byte> overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeOverlayText = overlayText)
			{
				ImGuiNative.PlotHistogram(nativeLabel, valuesGetter, (void*)data, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize);
			}
		}

		public static void PlotHistogram(ReadOnlySpan<char> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 graphSize)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling overlayText to native string
			byte* nativeOverlayText;
			var byteCountOverlayText = 0;
			if (overlayText != null && !overlayText.IsEmpty)
			{
				byteCountOverlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCountOverlayText > Utils.MaxStackallocSize)
				{
					nativeOverlayText = Utils.Alloc<byte>(byteCountOverlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountOverlayText + 1];
					nativeOverlayText = stackallocBytes;
				}
				var offsetOverlayText = Utils.EncodeStringUTF8(overlayText, nativeOverlayText, byteCountOverlayText);
				nativeOverlayText[offsetOverlayText] = 0;
			}
			else nativeOverlayText = null;

			ImGuiNative.PlotHistogram(nativeLabel, valuesGetter, (void*)data, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, graphSize);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing overlayText native string
			if (byteCountOverlayText > Utils.MaxStackallocSize)
				Utils.Free(nativeOverlayText);
		}

		public static void Value(ReadOnlySpan<byte> prefix, bool b)
		{
			var native_b = b ? (byte)1 : (byte)0;
			fixed (byte* nativePrefix = prefix)
			{
				ImGuiNative.Value(nativePrefix, native_b);
			}
		}

		public static void Value(ReadOnlySpan<char> prefix, bool b)
		{
			// Marshaling prefix to native string
			byte* nativePrefix;
			var byteCountPrefix = 0;
			if (prefix != null && !prefix.IsEmpty)
			{
				byteCountPrefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCountPrefix > Utils.MaxStackallocSize)
				{
					nativePrefix = Utils.Alloc<byte>(byteCountPrefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPrefix + 1];
					nativePrefix = stackallocBytes;
				}
				var offsetPrefix = Utils.EncodeStringUTF8(prefix, nativePrefix, byteCountPrefix);
				nativePrefix[offsetPrefix] = 0;
			}
			else nativePrefix = null;

			var native_b = b ? (byte)1 : (byte)0;
			ImGuiNative.Value(nativePrefix, native_b);
			// Freeing prefix native string
			if (byteCountPrefix > Utils.MaxStackallocSize)
				Utils.Free(nativePrefix);
		}

		public static void Value(ReadOnlySpan<byte> prefix, int v)
		{
			fixed (byte* nativePrefix = prefix)
			{
				ImGuiNative.Value(nativePrefix, v);
			}
		}

		public static void Value(ReadOnlySpan<char> prefix, int v)
		{
			// Marshaling prefix to native string
			byte* nativePrefix;
			var byteCountPrefix = 0;
			if (prefix != null && !prefix.IsEmpty)
			{
				byteCountPrefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCountPrefix > Utils.MaxStackallocSize)
				{
					nativePrefix = Utils.Alloc<byte>(byteCountPrefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPrefix + 1];
					nativePrefix = stackallocBytes;
				}
				var offsetPrefix = Utils.EncodeStringUTF8(prefix, nativePrefix, byteCountPrefix);
				nativePrefix[offsetPrefix] = 0;
			}
			else nativePrefix = null;

			ImGuiNative.Value(nativePrefix, v);
			// Freeing prefix native string
			if (byteCountPrefix > Utils.MaxStackallocSize)
				Utils.Free(nativePrefix);
		}

		public static void Value(ReadOnlySpan<byte> prefix, uint v)
		{
			fixed (byte* nativePrefix = prefix)
			{
				ImGuiNative.Value(nativePrefix, v);
			}
		}

		public static void Value(ReadOnlySpan<char> prefix, uint v)
		{
			// Marshaling prefix to native string
			byte* nativePrefix;
			var byteCountPrefix = 0;
			if (prefix != null && !prefix.IsEmpty)
			{
				byteCountPrefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCountPrefix > Utils.MaxStackallocSize)
				{
					nativePrefix = Utils.Alloc<byte>(byteCountPrefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPrefix + 1];
					nativePrefix = stackallocBytes;
				}
				var offsetPrefix = Utils.EncodeStringUTF8(prefix, nativePrefix, byteCountPrefix);
				nativePrefix[offsetPrefix] = 0;
			}
			else nativePrefix = null;

			ImGuiNative.Value(nativePrefix, v);
			// Freeing prefix native string
			if (byteCountPrefix > Utils.MaxStackallocSize)
				Utils.Free(nativePrefix);
		}

		public static void Value(ReadOnlySpan<byte> prefix, float v, ReadOnlySpan<byte> floatFormat)
		{
			fixed (byte* nativePrefix = prefix)
			fixed (byte* nativeFloatFormat = floatFormat)
			{
				ImGuiNative.Value(nativePrefix, v, nativeFloatFormat);
			}
		}

		public static void Value(ReadOnlySpan<char> prefix, float v, ReadOnlySpan<char> floatFormat)
		{
			// Marshaling prefix to native string
			byte* nativePrefix;
			var byteCountPrefix = 0;
			if (prefix != null && !prefix.IsEmpty)
			{
				byteCountPrefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCountPrefix > Utils.MaxStackallocSize)
				{
					nativePrefix = Utils.Alloc<byte>(byteCountPrefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPrefix + 1];
					nativePrefix = stackallocBytes;
				}
				var offsetPrefix = Utils.EncodeStringUTF8(prefix, nativePrefix, byteCountPrefix);
				nativePrefix[offsetPrefix] = 0;
			}
			else nativePrefix = null;

			// Marshaling floatFormat to native string
			byte* nativeFloatFormat;
			var byteCountFloatFormat = 0;
			if (floatFormat != null && !floatFormat.IsEmpty)
			{
				byteCountFloatFormat = Encoding.UTF8.GetByteCount(floatFormat);
				if(byteCountFloatFormat > Utils.MaxStackallocSize)
				{
					nativeFloatFormat = Utils.Alloc<byte>(byteCountFloatFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFloatFormat + 1];
					nativeFloatFormat = stackallocBytes;
				}
				var offsetFloatFormat = Utils.EncodeStringUTF8(floatFormat, nativeFloatFormat, byteCountFloatFormat);
				nativeFloatFormat[offsetFloatFormat] = 0;
			}
			else nativeFloatFormat = null;

			ImGuiNative.Value(nativePrefix, v, nativeFloatFormat);
			// Freeing prefix native string
			if (byteCountPrefix > Utils.MaxStackallocSize)
				Utils.Free(nativePrefix);
			// Freeing floatFormat native string
			if (byteCountFloatFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFloatFormat);
		}

		/// <summary>
		/// append to menu-bar of current window (requires ImGuiWindowFlags_MenuBar flag set on parent window).<br/>
		/// </summary>
		public static bool BeginMenuBar()
		{
			var result = ImGuiNative.BeginMenuBar();
			return result != 0;
		}

		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!<br/>
		/// </summary>
		public static void EndMenuBar()
		{
			ImGuiNative.EndMenuBar();
		}

		/// <summary>
		/// create and append to a full screen menu-bar.<br/>
		/// </summary>
		public static bool BeginMainMenuBar()
		{
			var result = ImGuiNative.BeginMainMenuBar();
			return result != 0;
		}

		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!<br/>
		/// </summary>
		public static void EndMainMenuBar()
		{
			ImGuiNative.EndMainMenuBar();
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static bool BeginMenu(ReadOnlySpan<byte> label, bool enabled)
		{
			var native_enabled = enabled ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginMenu(nativeLabel, native_enabled);
				return result != 0;
			}
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static bool BeginMenu(ReadOnlySpan<char> label, bool enabled)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var native_enabled = enabled ? (byte)1 : (byte)0;
			var result = ImGuiNative.BeginMenu(nativeLabel, native_enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static bool BeginMenu(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			byte enabled = 1;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginMenu(nativeLabel, enabled);
				return result != 0;
			}
		}

		/// <summary>
		/// create a sub-menu entry. only call EndMenu() if this returns true!<br/>
		/// </summary>
		public static bool BeginMenu(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			byte enabled = 1;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.BeginMenu(nativeLabel, enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!<br/>
		/// </summary>
		public static void EndMenu()
		{
			ImGuiNative.EndMenu();
		}

		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		public static bool MenuItem(ReadOnlySpan<byte> label, ReadOnlySpan<byte> shortcut, bool selected, bool enabled)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeShortcut = shortcut)
			{
				var result = ImGuiNative.MenuItem(nativeLabel, nativeShortcut, native_selected, native_enabled);
				return result != 0;
			}
		}

		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL<br/>
		/// </summary>
		public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling shortcut to native string
			byte* nativeShortcut;
			var byteCountShortcut = 0;
			if (shortcut != null && !shortcut.IsEmpty)
			{
				byteCountShortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCountShortcut > Utils.MaxStackallocSize)
				{
					nativeShortcut = Utils.Alloc<byte>(byteCountShortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountShortcut + 1];
					nativeShortcut = stackallocBytes;
				}
				var offsetShortcut = Utils.EncodeStringUTF8(shortcut, nativeShortcut, byteCountShortcut);
				nativeShortcut[offsetShortcut] = 0;
			}
			else nativeShortcut = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			var result = ImGuiNative.MenuItem(nativeLabel, nativeShortcut, native_selected, native_enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing shortcut native string
			if (byteCountShortcut > Utils.MaxStackallocSize)
				Utils.Free(nativeShortcut);
			return result != 0;
		}

		public static bool MenuItem(ReadOnlySpan<byte> label, ReadOnlySpan<byte> shortcut, ref bool pSelected, bool enabled)
		{
			var nativePSelectedVal = pSelected ? (byte)1 : (byte)0;
			var nativePSelected = &nativePSelectedVal;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeShortcut = shortcut)
			{
				var result = ImGuiNative.MenuItem(nativeLabel, nativeShortcut, nativePSelected, native_enabled);
				pSelected = nativePSelectedVal != 0;
				return result != 0;
			}
		}

		public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, ref bool pSelected, bool enabled)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling shortcut to native string
			byte* nativeShortcut;
			var byteCountShortcut = 0;
			if (shortcut != null && !shortcut.IsEmpty)
			{
				byteCountShortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCountShortcut > Utils.MaxStackallocSize)
				{
					nativeShortcut = Utils.Alloc<byte>(byteCountShortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountShortcut + 1];
					nativeShortcut = stackallocBytes;
				}
				var offsetShortcut = Utils.EncodeStringUTF8(shortcut, nativeShortcut, byteCountShortcut);
				nativeShortcut[offsetShortcut] = 0;
			}
			else nativeShortcut = null;

			var nativePSelectedVal = pSelected ? (byte)1 : (byte)0;
			var nativePSelected = &nativePSelectedVal;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			var result = ImGuiNative.MenuItem(nativeLabel, nativeShortcut, nativePSelected, native_enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing shortcut native string
			if (byteCountShortcut > Utils.MaxStackallocSize)
				Utils.Free(nativeShortcut);
			pSelected = nativePSelectedVal != 0;
			return result != 0;
		}

		/// <summary>
		/// begin/append a tooltip window.<br/>
		/// </summary>
		public static bool BeginTooltip()
		{
			var result = ImGuiNative.BeginTooltip();
			return result != 0;
		}

		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!<br/>
		/// </summary>
		public static void EndTooltip()
		{
			ImGuiNative.EndTooltip();
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		public static void SetTooltip(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.SetTooltip(nativeFmt);
			}
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().<br/>
		/// </summary>
		public static void SetTooltip(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.SetTooltip(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.<br/>
		/// </summary>
		public static bool BeginItemTooltip()
		{
			var result = ImGuiNative.BeginItemTooltip();
			return result != 0;
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		public static void SetItemTooltip(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.SetItemTooltip(nativeFmt);
			}
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().<br/>
		/// </summary>
		public static void SetItemTooltip(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.SetItemTooltip(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopup(ReadOnlySpan<byte> strId, ImGuiWindowFlags flags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopup(nativeStrId, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopup(ReadOnlySpan<char> strId, ImGuiWindowFlags flags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopup(nativeStrId, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopup(ReadOnlySpan<byte> strId)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopup(nativeStrId, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// return true if the popup is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopup(ReadOnlySpan<char> strId)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopup(nativeStrId, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<byte> name, ref bool pOpen, ImGuiWindowFlags flags)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginPopupModal(nativeName, nativePOpen, flags);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<char> name, ref bool pOpen, ImGuiWindowFlags flags)
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

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.BeginPopupModal(nativeName, nativePOpen, flags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<byte> name, ref bool pOpen)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginPopupModal(nativeName, nativePOpen, flags);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<char> name, ref bool pOpen)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
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

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.BeginPopupModal(nativeName, nativePOpen, flags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<byte> name)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			byte* pOpen = null;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginPopupModal(nativeName, pOpen, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.<br/>
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<char> name)
		{
			// defining omitted parameters
			ImGuiWindowFlags flags = ImGuiWindowFlags.None;
			byte* pOpen = null;
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

			var result = ImGuiNative.BeginPopupModal(nativeName, pOpen, flags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!<br/>
		/// </summary>
		public static void EndPopup()
		{
			ImGuiNative.EndPopup();
		}

		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		public static void OpenPopup(ReadOnlySpan<byte> strId, ImGuiPopupFlags popupFlags)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.OpenPopup(nativeStrId, popupFlags);
			}
		}

		/// <summary>
		/// id overload to facilitate calling from nested stacks<br/>
		/// </summary>
		public static void OpenPopup(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.OpenPopup(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		public static void OpenPopup(uint id, ImGuiPopupFlags popupFlags)
		{
			ImGuiNative.OpenPopup(id, popupFlags);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<byte> strId, ImGuiPopupFlags popupFlags)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.OpenPopupOnItemClick(nativeStrId, popupFlags);
			}
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.OpenPopupOnItemClick(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<byte> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.OpenPopupOnItemClick(nativeStrId, popupFlags);
			}
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<char> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.OpenPopupOnItemClick(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)<br/>
		/// </summary>
		public static void OpenPopupOnItemClick()
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			byte* strId = null;
			ImGuiNative.OpenPopupOnItemClick(strId, popupFlags);
		}

		/// <summary>
		/// manually close the popup we have begin-ed into.<br/>
		/// </summary>
		public static void CloseCurrentPopup()
		{
			ImGuiNative.CloseCurrentPopup();
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static bool BeginPopupContextItem(ReadOnlySpan<byte> strId, ImGuiPopupFlags popupFlags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopupContextItem(nativeStrId, popupFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static bool BeginPopupContextItem(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopupContextItem(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static bool BeginPopupContextItem(ReadOnlySpan<byte> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopupContextItem(nativeStrId, popupFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static bool BeginPopupContextItem(ReadOnlySpan<char> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopupContextItem(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked on last item. Use str_id==NULL to associate the popup to previous item. If you want to use that on a non-interactive item such as Text() you need to pass in an explicit ID here. read comments in .cpp!<br/>
		/// </summary>
		public static bool BeginPopupContextItem()
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			byte* strId = null;
			var result = ImGuiNative.BeginPopupContextItem(strId, popupFlags);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static bool BeginPopupContextWindow(ReadOnlySpan<byte> strId, ImGuiPopupFlags popupFlags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopupContextWindow(nativeStrId, popupFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static bool BeginPopupContextWindow(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopupContextWindow(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static bool BeginPopupContextWindow(ReadOnlySpan<byte> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopupContextWindow(nativeStrId, popupFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static bool BeginPopupContextWindow(ReadOnlySpan<char> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopupContextWindow(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked on current window.<br/>
		/// </summary>
		public static bool BeginPopupContextWindow()
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			byte* strId = null;
			var result = ImGuiNative.BeginPopupContextWindow(strId, popupFlags);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static bool BeginPopupContextVoid(ReadOnlySpan<byte> strId, ImGuiPopupFlags popupFlags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopupContextVoid(nativeStrId, popupFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static bool BeginPopupContextVoid(ReadOnlySpan<char> strId, ImGuiPopupFlags popupFlags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopupContextVoid(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static bool BeginPopupContextVoid(ReadOnlySpan<byte> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginPopupContextVoid(nativeStrId, popupFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static bool BeginPopupContextVoid(ReadOnlySpan<char> strId)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginPopupContextVoid(nativeStrId, popupFlags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// open+begin popup when clicked in void (where there are no windows).<br/>
		/// </summary>
		public static bool BeginPopupContextVoid()
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.MouseButtonRight;
			byte* strId = null;
			var result = ImGuiNative.BeginPopupContextVoid(strId, popupFlags);
			return result != 0;
		}

		public static bool IsPopupOpen(ReadOnlySpan<byte> strId, ImGuiPopupFlags flags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.IsPopupOpen(nativeStrId, flags);
				return result != 0;
			}
		}

		public static bool IsPopupOpen(ReadOnlySpan<char> strId, ImGuiPopupFlags flags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.IsPopupOpen(nativeStrId, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool BeginTable(ReadOnlySpan<byte> strId, int columns, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTable(ReadOnlySpan<char> strId, int columns, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool BeginTable(ReadOnlySpan<byte> strId, int columns, ImGuiTableFlags flags, Vector2 outerSize)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTable(ReadOnlySpan<char> strId, int columns, ImGuiTableFlags flags, Vector2 outerSize)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool BeginTable(ReadOnlySpan<byte> strId, int columns, ImGuiTableFlags flags)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0.0f,0.0f);
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTable(ReadOnlySpan<char> strId, int columns, ImGuiTableFlags flags)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0.0f,0.0f);
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool BeginTable(ReadOnlySpan<byte> strId, int columns)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0.0f,0.0f);
			ImGuiTableFlags flags = ImGuiTableFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTable(ReadOnlySpan<char> strId, int columns)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0.0f,0.0f);
			ImGuiTableFlags flags = ImGuiTableFlags.None;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginTable(nativeStrId, columns, flags, outerSize, innerWidth);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// only call EndTable() if BeginTable() returns true!<br/>
		/// </summary>
		public static void EndTable()
		{
			ImGuiNative.EndTable();
		}

		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		public static void TableNextRow(ImGuiTableRowFlags rowFlags, float minRowHeight)
		{
			ImGuiNative.TableNextRow(rowFlags, minRowHeight);
		}

		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		public static void TableNextRow(ImGuiTableRowFlags rowFlags)
		{
			// defining omitted parameters
			float minRowHeight = 0.0f;
			ImGuiNative.TableNextRow(rowFlags, minRowHeight);
		}

		/// <summary>
		/// append into the first cell of a new row.<br/>
		/// </summary>
		public static void TableNextRow()
		{
			// defining omitted parameters
			float minRowHeight = 0.0f;
			ImGuiTableRowFlags rowFlags = ImGuiTableRowFlags.None;
			ImGuiNative.TableNextRow(rowFlags, minRowHeight);
		}

		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.<br/>
		/// </summary>
		public static bool TableNextColumn()
		{
			var result = ImGuiNative.TableNextColumn();
			return result != 0;
		}

		/// <summary>
		/// append into the specified column. Return true when column is visible.<br/>
		/// </summary>
		public static bool TableSetColumnIndex(int columnN)
		{
			var result = ImGuiNative.TableSetColumnIndex(columnN);
			return result != 0;
		}

		public static void TableSetupColumn(ReadOnlySpan<byte> label, ImGuiTableColumnFlags flags, float initWidthOrWeight, uint userId)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			}
		}

		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float initWidthOrWeight, uint userId)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void TableSetupColumn(ReadOnlySpan<byte> label, ImGuiTableColumnFlags flags, float initWidthOrWeight)
		{
			// defining omitted parameters
			uint userId = 0;
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			}
		}

		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float initWidthOrWeight)
		{
			// defining omitted parameters
			uint userId = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void TableSetupColumn(ReadOnlySpan<byte> label, ImGuiTableColumnFlags flags)
		{
			// defining omitted parameters
			uint userId = 0;
			float initWidthOrWeight = 0.0f;
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			}
		}

		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags)
		{
			// defining omitted parameters
			uint userId = 0;
			float initWidthOrWeight = 0.0f;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void TableSetupColumn(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			uint userId = 0;
			float initWidthOrWeight = 0.0f;
			ImGuiTableColumnFlags flags = ImGuiTableColumnFlags.None;
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			}
		}

		public static void TableSetupColumn(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			uint userId = 0;
			float initWidthOrWeight = 0.0f;
			ImGuiTableColumnFlags flags = ImGuiTableColumnFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.TableSetupColumn(nativeLabel, flags, initWidthOrWeight, userId);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.<br/>
		/// </summary>
		public static void TableSetupScrollFreeze(int cols, int rows)
		{
			ImGuiNative.TableSetupScrollFreeze(cols, rows);
		}

		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		public static void TableHeader(ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TableHeader(nativeLabel);
			}
		}

		/// <summary>
		/// submit one header cell manually (rarely used)<br/>
		/// </summary>
		public static void TableHeader(ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.TableHeader(nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu<br/>
		/// </summary>
		public static void TableHeadersRow()
		{
			ImGuiNative.TableHeadersRow();
		}

		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.<br/>
		/// </summary>
		public static void TableAngledHeadersRow()
		{
			ImGuiNative.TableAngledHeadersRow();
		}

		/// <summary>
		/// get latest sort specs for the table (NULL if not sorting).  Lifetime: don't hold on this pointer over multiple frames or past any subsequent call to BeginTable().<br/>
		/// </summary>
		public static ImGuiTableSortSpecsPtr TableGetSortSpecs()
		{
			return ImGuiNative.TableGetSortSpecs();
		}

		/// <summary>
		/// return number of columns (value passed to BeginTable)<br/>
		/// </summary>
		public static int TableGetColumnCount()
		{
			return ImGuiNative.TableGetColumnCount();
		}

		/// <summary>
		/// return current column index.<br/>
		/// </summary>
		public static int TableGetColumnIndex()
		{
			return ImGuiNative.TableGetColumnIndex();
		}

		/// <summary>
		/// return current row index.<br/>
		/// </summary>
		public static int TableGetRowIndex()
		{
			return ImGuiNative.TableGetRowIndex();
		}

		public static string TableGetColumnName(int columnN)
		{
			var result = ImGuiNative.TableGetColumnName(columnN);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		public static ImGuiTableColumnFlags TableGetColumnFlags(int columnN)
		{
			return ImGuiNative.TableGetColumnFlags(columnN);
		}

		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.<br/>
		/// </summary>
		public static ImGuiTableColumnFlags TableGetColumnFlags()
		{
			// defining omitted parameters
			int columnN = -1;
			return ImGuiNative.TableGetColumnFlags(columnN);
		}

		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)<br/>
		/// </summary>
		public static void TableSetColumnEnabled(int columnN, bool v)
		{
			var native_v = v ? (byte)1 : (byte)0;
			ImGuiNative.TableSetColumnEnabled(columnN, native_v);
		}

		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() & ImGuiTableColumnFlags_IsHovered) instead.<br/>
		/// </summary>
		public static int TableGetHoveredColumn()
		{
			return ImGuiNative.TableGetHoveredColumn();
		}

		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int columnN)
		{
			ImGuiNative.TableSetBgColor(target, color, columnN);
		}

		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.<br/>
		/// </summary>
		public static void TableSetBgColor(ImGuiTableBgTarget target, uint color)
		{
			// defining omitted parameters
			int columnN = -1;
			ImGuiNative.TableSetBgColor(target, color, columnN);
		}

		public static void Columns(int count, ReadOnlySpan<byte> id, bool borders)
		{
			var native_borders = borders ? (byte)1 : (byte)0;
			fixed (byte* nativeId = id)
			{
				ImGuiNative.Columns(count, nativeId, native_borders);
			}
		}

		public static void Columns(int count, ReadOnlySpan<char> id, bool borders)
		{
			// Marshaling id to native string
			byte* nativeId;
			var byteCountId = 0;
			if (id != null && !id.IsEmpty)
			{
				byteCountId = Encoding.UTF8.GetByteCount(id);
				if(byteCountId > Utils.MaxStackallocSize)
				{
					nativeId = Utils.Alloc<byte>(byteCountId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountId + 1];
					nativeId = stackallocBytes;
				}
				var offsetId = Utils.EncodeStringUTF8(id, nativeId, byteCountId);
				nativeId[offsetId] = 0;
			}
			else nativeId = null;

			var native_borders = borders ? (byte)1 : (byte)0;
			ImGuiNative.Columns(count, nativeId, native_borders);
			// Freeing id native string
			if (byteCountId > Utils.MaxStackallocSize)
				Utils.Free(nativeId);
		}

		public static void Columns(int count, ReadOnlySpan<byte> id)
		{
			// defining omitted parameters
			byte borders = 1;
			fixed (byte* nativeId = id)
			{
				ImGuiNative.Columns(count, nativeId, borders);
			}
		}

		public static void Columns(int count, ReadOnlySpan<char> id)
		{
			// defining omitted parameters
			byte borders = 1;
			// Marshaling id to native string
			byte* nativeId;
			var byteCountId = 0;
			if (id != null && !id.IsEmpty)
			{
				byteCountId = Encoding.UTF8.GetByteCount(id);
				if(byteCountId > Utils.MaxStackallocSize)
				{
					nativeId = Utils.Alloc<byte>(byteCountId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountId + 1];
					nativeId = stackallocBytes;
				}
				var offsetId = Utils.EncodeStringUTF8(id, nativeId, byteCountId);
				nativeId[offsetId] = 0;
			}
			else nativeId = null;

			ImGuiNative.Columns(count, nativeId, borders);
			// Freeing id native string
			if (byteCountId > Utils.MaxStackallocSize)
				Utils.Free(nativeId);
		}

		public static void Columns(int count)
		{
			// defining omitted parameters
			byte borders = 1;
			byte* id = null;
			ImGuiNative.Columns(count, id, borders);
		}

		public static void Columns()
		{
			// defining omitted parameters
			int count = 1;
			byte borders = 1;
			byte* id = null;
			ImGuiNative.Columns(count, id, borders);
		}

		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished<br/>
		/// </summary>
		public static void NextColumn()
		{
			ImGuiNative.NextColumn();
		}

		/// <summary>
		/// get current column index<br/>
		/// </summary>
		public static int GetColumnIndex()
		{
			return ImGuiNative.GetColumnIndex();
		}

		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static float GetColumnWidth(int columnIndex)
		{
			return ImGuiNative.GetColumnWidth(columnIndex);
		}

		/// <summary>
		/// get column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static float GetColumnWidth()
		{
			// defining omitted parameters
			int columnIndex = -1;
			return ImGuiNative.GetColumnWidth(columnIndex);
		}

		/// <summary>
		/// set column width (in pixels). pass -1 to use current column<br/>
		/// </summary>
		public static void SetColumnWidth(int columnIndex, float width)
		{
			ImGuiNative.SetColumnWidth(columnIndex, width);
		}

		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		public static float GetColumnOffset(int columnIndex)
		{
			return ImGuiNative.GetColumnOffset(columnIndex);
		}

		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f<br/>
		/// </summary>
		public static float GetColumnOffset()
		{
			// defining omitted parameters
			int columnIndex = -1;
			return ImGuiNative.GetColumnOffset(columnIndex);
		}

		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column<br/>
		/// </summary>
		public static void SetColumnOffset(int columnIndex, float offsetX)
		{
			ImGuiNative.SetColumnOffset(columnIndex, offsetX);
		}

		public static int GetColumnsCount()
		{
			return ImGuiNative.GetColumnsCount();
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static bool BeginTabBar(ReadOnlySpan<byte> strId, ImGuiTabBarFlags flags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginTabBar(nativeStrId, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static bool BeginTabBar(ReadOnlySpan<char> strId, ImGuiTabBarFlags flags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginTabBar(nativeStrId, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static bool BeginTabBar(ReadOnlySpan<byte> strId)
		{
			// defining omitted parameters
			ImGuiTabBarFlags flags = ImGuiTabBarFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.BeginTabBar(nativeStrId, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// create and append into a TabBar<br/>
		/// </summary>
		public static bool BeginTabBar(ReadOnlySpan<char> strId)
		{
			// defining omitted parameters
			ImGuiTabBarFlags flags = ImGuiTabBarFlags.None;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.BeginTabBar(nativeStrId, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!<br/>
		/// </summary>
		public static void EndTabBar()
		{
			ImGuiNative.EndTabBar();
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<byte> label, ref bool pOpen, ImGuiTabItemFlags flags)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginTabItem(nativeLabel, nativePOpen, flags);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<char> label, ref bool pOpen, ImGuiTabItemFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.BeginTabItem(nativeLabel, nativePOpen, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<byte> label, ref bool pOpen)
		{
			// defining omitted parameters
			ImGuiTabItemFlags flags = ImGuiTabItemFlags.None;
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginTabItem(nativeLabel, nativePOpen, flags);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<char> label, ref bool pOpen)
		{
			// defining omitted parameters
			ImGuiTabItemFlags flags = ImGuiTabItemFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.BeginTabItem(nativeLabel, nativePOpen, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			ImGuiTabItemFlags flags = ImGuiTabItemFlags.None;
			byte* pOpen = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginTabItem(nativeLabel, pOpen, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.<br/>
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			ImGuiTabItemFlags flags = ImGuiTabItemFlags.None;
			byte* pOpen = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.BeginTabItem(nativeLabel, pOpen, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!<br/>
		/// </summary>
		public static void EndTabItem()
		{
			ImGuiNative.EndTabItem();
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static bool TabItemButton(ReadOnlySpan<byte> label, ImGuiTabItemFlags flags)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TabItemButton(nativeLabel, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static bool TabItemButton(ReadOnlySpan<char> label, ImGuiTabItemFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.TabItemButton(nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static bool TabItemButton(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			ImGuiTabItemFlags flags = ImGuiTabItemFlags.None;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TabItemButton(nativeLabel, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.<br/>
		/// </summary>
		public static bool TabItemButton(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			ImGuiTabItemFlags flags = ImGuiTabItemFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.TabItemButton(nativeLabel, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		public static void SetTabItemClosed(ReadOnlySpan<byte> tabOrDockedWindowLabel)
		{
			fixed (byte* nativeTabOrDockedWindowLabel = tabOrDockedWindowLabel)
			{
				ImGuiNative.SetTabItemClosed(nativeTabOrDockedWindowLabel);
			}
		}

		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.<br/>
		/// </summary>
		public static void SetTabItemClosed(ReadOnlySpan<char> tabOrDockedWindowLabel)
		{
			// Marshaling tabOrDockedWindowLabel to native string
			byte* nativeTabOrDockedWindowLabel;
			var byteCountTabOrDockedWindowLabel = 0;
			if (tabOrDockedWindowLabel != null && !tabOrDockedWindowLabel.IsEmpty)
			{
				byteCountTabOrDockedWindowLabel = Encoding.UTF8.GetByteCount(tabOrDockedWindowLabel);
				if(byteCountTabOrDockedWindowLabel > Utils.MaxStackallocSize)
				{
					nativeTabOrDockedWindowLabel = Utils.Alloc<byte>(byteCountTabOrDockedWindowLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTabOrDockedWindowLabel + 1];
					nativeTabOrDockedWindowLabel = stackallocBytes;
				}
				var offsetTabOrDockedWindowLabel = Utils.EncodeStringUTF8(tabOrDockedWindowLabel, nativeTabOrDockedWindowLabel, byteCountTabOrDockedWindowLabel);
				nativeTabOrDockedWindowLabel[offsetTabOrDockedWindowLabel] = 0;
			}
			else nativeTabOrDockedWindowLabel = null;

			ImGuiNative.SetTabItemClosed(nativeTabOrDockedWindowLabel);
			// Freeing tabOrDockedWindowLabel native string
			if (byteCountTabOrDockedWindowLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeTabOrDockedWindowLabel);
		}

		public static uint DockSpace(uint dockspaceId, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr windowClass)
		{
			return ImGuiNative.DockSpace(dockspaceId, size, flags, windowClass);
		}

		public static uint DockSpace(uint dockspaceId, Vector2 size, ImGuiDockNodeFlags flags)
		{
			// defining omitted parameters
			ImGuiWindowClass* windowClass = null;
			return ImGuiNative.DockSpace(dockspaceId, size, flags, windowClass);
		}

		public static uint DockSpace(uint dockspaceId, Vector2 size)
		{
			// defining omitted parameters
			ImGuiWindowClass* windowClass = null;
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			return ImGuiNative.DockSpace(dockspaceId, size, flags, windowClass);
		}

		public static uint DockSpace(uint dockspaceId)
		{
			// defining omitted parameters
			ImGuiWindowClass* windowClass = null;
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			Vector2 size = new Vector2(0,0);
			return ImGuiNative.DockSpace(dockspaceId, size, flags, windowClass);
		}

		public static uint DockSpaceOverViewport(uint dockspaceId, ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr windowClass)
		{
			return ImGuiNative.DockSpaceOverViewport(dockspaceId, viewport, flags, windowClass);
		}

		public static uint DockSpaceOverViewport(uint dockspaceId, ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags)
		{
			// defining omitted parameters
			ImGuiWindowClass* windowClass = null;
			return ImGuiNative.DockSpaceOverViewport(dockspaceId, viewport, flags, windowClass);
		}

		public static uint DockSpaceOverViewport(uint dockspaceId, ImGuiViewportPtr viewport)
		{
			// defining omitted parameters
			ImGuiWindowClass* windowClass = null;
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			return ImGuiNative.DockSpaceOverViewport(dockspaceId, viewport, flags, windowClass);
		}

		public static uint DockSpaceOverViewport(uint dockspaceId)
		{
			// defining omitted parameters
			ImGuiWindowClass* windowClass = null;
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			ImGuiViewport* viewport = null;
			return ImGuiNative.DockSpaceOverViewport(dockspaceId, viewport, flags, windowClass);
		}

		public static uint DockSpaceOverViewport()
		{
			// defining omitted parameters
			uint dockspaceId = 0;
			ImGuiWindowClass* windowClass = null;
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			ImGuiViewport* viewport = null;
			return ImGuiNative.DockSpaceOverViewport(dockspaceId, viewport, flags, windowClass);
		}

		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		public static void SetNextWindowDockID(uint dockId, ImGuiCond cond)
		{
			ImGuiNative.SetNextWindowDockID(dockId, cond);
		}

		/// <summary>
		/// set next window dock id<br/>
		/// </summary>
		public static void SetNextWindowDockID(uint dockId)
		{
			// defining omitted parameters
			ImGuiCond cond = ImGuiCond.None;
			ImGuiNative.SetNextWindowDockID(dockId, cond);
		}

		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)<br/>
		/// </summary>
		public static void SetNextWindowClass(ImGuiWindowClassPtr windowClass)
		{
			ImGuiNative.SetNextWindowClass(windowClass);
		}

		public static uint GetWindowDockID()
		{
			return ImGuiNative.GetWindowDockID();
		}

		/// <summary>
		/// is current window docked into another window?<br/>
		/// </summary>
		public static bool IsWindowDocked()
		{
			var result = ImGuiNative.IsWindowDocked();
			return result != 0;
		}

		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		public static void LogToTTY(int autoOpenDepth)
		{
			ImGuiNative.LogToTTY(autoOpenDepth);
		}

		/// <summary>
		/// start logging to tty (stdout)<br/>
		/// </summary>
		public static void LogToTTY()
		{
			// defining omitted parameters
			int autoOpenDepth = -1;
			ImGuiNative.LogToTTY(autoOpenDepth);
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static void LogToFile(int autoOpenDepth, ReadOnlySpan<byte> filename)
		{
			fixed (byte* nativeFilename = filename)
			{
				ImGuiNative.LogToFile(autoOpenDepth, nativeFilename);
			}
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static void LogToFile(int autoOpenDepth, ReadOnlySpan<char> filename)
		{
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			ImGuiNative.LogToFile(autoOpenDepth, nativeFilename);
			// Freeing filename native string
			if (byteCountFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeFilename);
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static void LogToFile(int autoOpenDepth)
		{
			// defining omitted parameters
			byte* filename = null;
			ImGuiNative.LogToFile(autoOpenDepth, filename);
		}

		/// <summary>
		/// start logging to file<br/>
		/// </summary>
		public static void LogToFile()
		{
			// defining omitted parameters
			int autoOpenDepth = -1;
			byte* filename = null;
			ImGuiNative.LogToFile(autoOpenDepth, filename);
		}

		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		public static void LogToClipboard(int autoOpenDepth)
		{
			ImGuiNative.LogToClipboard(autoOpenDepth);
		}

		/// <summary>
		/// start logging to OS clipboard<br/>
		/// </summary>
		public static void LogToClipboard()
		{
			// defining omitted parameters
			int autoOpenDepth = -1;
			ImGuiNative.LogToClipboard(autoOpenDepth);
		}

		/// <summary>
		/// stop logging (close file, etc.)<br/>
		/// </summary>
		public static void LogFinish()
		{
			ImGuiNative.LogFinish();
		}

		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard<br/>
		/// </summary>
		public static void LogButtons()
		{
			ImGuiNative.LogButtons();
		}

		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		public static bool BeginDragDropSource(ImGuiDragDropFlags flags)
		{
			var result = ImGuiNative.BeginDragDropSource(flags);
			return result != 0;
		}

		/// <summary>
		/// call after submitting an item which may be dragged. when this return true, you can call SetDragDropPayload() + EndDragDropSource()<br/>
		/// </summary>
		public static bool BeginDragDropSource()
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			var result = ImGuiNative.BeginDragDropSource(flags);
			return result != 0;
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static bool SetDragDropPayload(ReadOnlySpan<byte> type, IntPtr data, uint sz, ImGuiCond cond)
		{
			fixed (byte* nativeType = type)
			{
				var result = ImGuiNative.SetDragDropPayload(nativeType, (void*)data, sz, cond);
				return result != 0;
			}
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static bool SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz, ImGuiCond cond)
		{
			// Marshaling type to native string
			byte* nativeType;
			var byteCountType = 0;
			if (type != null && !type.IsEmpty)
			{
				byteCountType = Encoding.UTF8.GetByteCount(type);
				if(byteCountType > Utils.MaxStackallocSize)
				{
					nativeType = Utils.Alloc<byte>(byteCountType + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountType + 1];
					nativeType = stackallocBytes;
				}
				var offsetType = Utils.EncodeStringUTF8(type, nativeType, byteCountType);
				nativeType[offsetType] = 0;
			}
			else nativeType = null;

			var result = ImGuiNative.SetDragDropPayload(nativeType, (void*)data, sz, cond);
			// Freeing type native string
			if (byteCountType > Utils.MaxStackallocSize)
				Utils.Free(nativeType);
			return result != 0;
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static bool SetDragDropPayload(ReadOnlySpan<byte> type, IntPtr data, uint sz)
		{
			// defining omitted parameters
			ImGuiCond cond = ImGuiCond.None;
			fixed (byte* nativeType = type)
			{
				var result = ImGuiNative.SetDragDropPayload(nativeType, (void*)data, sz, cond);
				return result != 0;
			}
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.<br/>
		/// </summary>
		public static bool SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz)
		{
			// defining omitted parameters
			ImGuiCond cond = ImGuiCond.None;
			// Marshaling type to native string
			byte* nativeType;
			var byteCountType = 0;
			if (type != null && !type.IsEmpty)
			{
				byteCountType = Encoding.UTF8.GetByteCount(type);
				if(byteCountType > Utils.MaxStackallocSize)
				{
					nativeType = Utils.Alloc<byte>(byteCountType + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountType + 1];
					nativeType = stackallocBytes;
				}
				var offsetType = Utils.EncodeStringUTF8(type, nativeType, byteCountType);
				nativeType[offsetType] = 0;
			}
			else nativeType = null;

			var result = ImGuiNative.SetDragDropPayload(nativeType, (void*)data, sz, cond);
			// Freeing type native string
			if (byteCountType > Utils.MaxStackallocSize)
				Utils.Free(nativeType);
			return result != 0;
		}

		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!<br/>
		/// </summary>
		public static void EndDragDropSource()
		{
			ImGuiNative.EndDragDropSource();
		}

		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()<br/>
		/// </summary>
		public static bool BeginDragDropTarget()
		{
			var result = ImGuiNative.BeginDragDropTarget();
			return result != 0;
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<byte> type, ImGuiDragDropFlags flags)
		{
			fixed (byte* nativeType = type)
			{
				return ImGuiNative.AcceptDragDropPayload(nativeType, flags);
			}
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type, ImGuiDragDropFlags flags)
		{
			// Marshaling type to native string
			byte* nativeType;
			var byteCountType = 0;
			if (type != null && !type.IsEmpty)
			{
				byteCountType = Encoding.UTF8.GetByteCount(type);
				if(byteCountType > Utils.MaxStackallocSize)
				{
					nativeType = Utils.Alloc<byte>(byteCountType + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountType + 1];
					nativeType = stackallocBytes;
				}
				var offsetType = Utils.EncodeStringUTF8(type, nativeType, byteCountType);
				nativeType[offsetType] = 0;
			}
			else nativeType = null;

			var result = ImGuiNative.AcceptDragDropPayload(nativeType, flags);
			// Freeing type native string
			if (byteCountType > Utils.MaxStackallocSize)
				Utils.Free(nativeType);
			return result;
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<byte> type)
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			fixed (byte* nativeType = type)
			{
				return ImGuiNative.AcceptDragDropPayload(nativeType, flags);
			}
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.<br/>
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type)
		{
			// defining omitted parameters
			ImGuiDragDropFlags flags = ImGuiDragDropFlags.None;
			// Marshaling type to native string
			byte* nativeType;
			var byteCountType = 0;
			if (type != null && !type.IsEmpty)
			{
				byteCountType = Encoding.UTF8.GetByteCount(type);
				if(byteCountType > Utils.MaxStackallocSize)
				{
					nativeType = Utils.Alloc<byte>(byteCountType + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountType + 1];
					nativeType = stackallocBytes;
				}
				var offsetType = Utils.EncodeStringUTF8(type, nativeType, byteCountType);
				nativeType[offsetType] = 0;
			}
			else nativeType = null;

			var result = ImGuiNative.AcceptDragDropPayload(nativeType, flags);
			// Freeing type native string
			if (byteCountType > Utils.MaxStackallocSize)
				Utils.Free(nativeType);
			return result;
		}

		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!<br/>
		/// </summary>
		public static void EndDragDropTarget()
		{
			ImGuiNative.EndDragDropTarget();
		}

		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.<br/>
		/// </summary>
		public static ImGuiPayloadPtr GetDragDropPayload()
		{
			return ImGuiNative.GetDragDropPayload();
		}

		public static void BeginDisabled(bool disabled)
		{
			var native_disabled = disabled ? (byte)1 : (byte)0;
			ImGuiNative.BeginDisabled(native_disabled);
		}

		public static void BeginDisabled()
		{
			// defining omitted parameters
			byte disabled = 1;
			ImGuiNative.BeginDisabled(disabled);
		}

		public static void EndDisabled()
		{
			ImGuiNative.EndDisabled();
		}

		public static void PushClipRect(Vector2 clipRectMin, Vector2 clipRectMax, bool intersectWithCurrentClipRect)
		{
			var native_intersectWithCurrentClipRect = intersectWithCurrentClipRect ? (byte)1 : (byte)0;
			ImGuiNative.PushClipRect(clipRectMin, clipRectMax, native_intersectWithCurrentClipRect);
		}

		public static void PopClipRect()
		{
			ImGuiNative.PopClipRect();
		}

		/// <summary>
		/// make last item the default focused item of a newly appearing window.<br/>
		/// </summary>
		public static void SetItemDefaultFocus()
		{
			ImGuiNative.SetItemDefaultFocus();
		}

		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		public static void SetKeyboardFocusHere(int offset)
		{
			ImGuiNative.SetKeyboardFocusHere(offset);
		}

		/// <summary>
		/// focus keyboard on the next widget. Use positive 'offset' to access sub components of a multiple component widget. Use -1 to access previous widget.<br/>
		/// </summary>
		public static void SetKeyboardFocusHere()
		{
			// defining omitted parameters
			int offset = 0;
			ImGuiNative.SetKeyboardFocusHere(offset);
		}

		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.<br/>
		/// </summary>
		public static void SetNavCursorVisible(bool visible)
		{
			var native_visible = visible ? (byte)1 : (byte)0;
			ImGuiNative.SetNavCursorVisible(native_visible);
		}

		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.<br/>
		/// </summary>
		public static void SetNextItemAllowOverlap()
		{
			ImGuiNative.SetNextItemAllowOverlap();
		}

		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		public static bool IsItemHovered(ImGuiHoveredFlags flags)
		{
			var result = ImGuiNative.IsItemHovered(flags);
			return result != 0;
		}

		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.<br/>
		/// </summary>
		public static bool IsItemHovered()
		{
			// defining omitted parameters
			ImGuiHoveredFlags flags = ImGuiHoveredFlags.None;
			var result = ImGuiNative.IsItemHovered(flags);
			return result != 0;
		}

		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)<br/>
		/// </summary>
		public static bool IsItemActive()
		{
			var result = ImGuiNative.IsItemActive();
			return result != 0;
		}

		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?<br/>
		/// </summary>
		public static bool IsItemFocused()
		{
			var result = ImGuiNative.IsItemFocused();
			return result != 0;
		}

		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		public static bool IsItemClicked(ImGuiMouseButton mouseButton)
		{
			var result = ImGuiNative.IsItemClicked(mouseButton);
			return result != 0;
		}

		/// <summary>
		/// is the last item hovered and mouse clicked on? (**)  == IsMouseClicked(mouse_button) && IsItemHovered()Important. (**) this is NOT equivalent to the behavior of e.g. Button(). Read comments in function definition.<br/>
		/// </summary>
		public static bool IsItemClicked()
		{
			// defining omitted parameters
			ImGuiMouseButton mouseButton = ImGuiMouseButton.Left;
			var result = ImGuiNative.IsItemClicked(mouseButton);
			return result != 0;
		}

		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)<br/>
		/// </summary>
		public static bool IsItemVisible()
		{
			var result = ImGuiNative.IsItemVisible();
			return result != 0;
		}

		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.<br/>
		/// </summary>
		public static bool IsItemEdited()
		{
			var result = ImGuiNative.IsItemEdited();
			return result != 0;
		}

		/// <summary>
		/// was the last item just made active (item was previously inactive).<br/>
		/// </summary>
		public static bool IsItemActivated()
		{
			var result = ImGuiNative.IsItemActivated();
			return result != 0;
		}

		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.<br/>
		/// </summary>
		public static bool IsItemDeactivated()
		{
			var result = ImGuiNative.IsItemDeactivated();
			return result != 0;
		}

		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).<br/>
		/// </summary>
		public static bool IsItemDeactivatedAfterEdit()
		{
			var result = ImGuiNative.IsItemDeactivatedAfterEdit();
			return result != 0;
		}

		/// <summary>
		/// was the last item open state toggled? set by TreeNode().<br/>
		/// </summary>
		public static bool IsItemToggledOpen()
		{
			var result = ImGuiNative.IsItemToggledOpen();
			return result != 0;
		}

		/// <summary>
		/// is any item hovered?<br/>
		/// </summary>
		public static bool IsAnyItemHovered()
		{
			var result = ImGuiNative.IsAnyItemHovered();
			return result != 0;
		}

		/// <summary>
		/// is any item active?<br/>
		/// </summary>
		public static bool IsAnyItemActive()
		{
			var result = ImGuiNative.IsAnyItemActive();
			return result != 0;
		}

		/// <summary>
		/// is any item focused?<br/>
		/// </summary>
		public static bool IsAnyItemFocused()
		{
			var result = ImGuiNative.IsAnyItemFocused();
			return result != 0;
		}

		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)<br/>
		/// </summary>
		public static uint GetItemID()
		{
			return ImGuiNative.GetItemID();
		}

		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static void GetItemRectMin(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetItemRectMin(nativePOut);
			}
		}

		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)<br/>
		/// </summary>
		public static void GetItemRectMax(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetItemRectMax(nativePOut);
			}
		}

		/// <summary>
		/// get size of last item<br/>
		/// </summary>
		public static void GetItemRectSize(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetItemRectSize(nativePOut);
			}
		}

		/// <summary>
		/// return primary/default viewport. This can never be NULL.<br/>
		/// </summary>
		public static ImGuiViewportPtr GetMainViewport()
		{
			return ImGuiNative.GetMainViewport();
		}

		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		public static ImDrawListPtr GetBackgroundDrawList(ImGuiViewportPtr viewport)
		{
			return ImGuiNative.GetBackgroundDrawList(viewport);
		}

		/// <summary>
		/// get background draw list for the given viewport or viewport associated to the current window. this draw list will be the first rendering one. Useful to quickly draw shapes/text behind dear imgui contents.<br/>
		/// </summary>
		public static ImDrawListPtr GetBackgroundDrawList()
		{
			// defining omitted parameters
			ImGuiViewport* viewport = null;
			return ImGuiNative.GetBackgroundDrawList(viewport);
		}

		public static ImDrawListPtr GetForegroundDrawList(ImGuiViewportPtr viewport)
		{
			return ImGuiNative.GetForegroundDrawList(viewport);
		}

		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.<br/>
		/// </summary>
		public static bool IsRectVisible(Vector2 size)
		{
			var result = ImGuiNative.IsRectVisible(size);
			return result != 0;
		}

		public static bool IsRectVisible(Vector2 rectMin, Vector2 rectMax)
		{
			var result = ImGuiNative.IsRectVisible(rectMin, rectMax);
			return result != 0;
		}

		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.<br/>
		/// </summary>
		public static double GetTime()
		{
			return ImGuiNative.GetTime();
		}

		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.<br/>
		/// </summary>
		public static int GetFrameCount()
		{
			return ImGuiNative.GetFrameCount();
		}

		/// <summary>
		/// you may use this when creating your own ImDrawList instances.<br/>
		/// </summary>
		public static ImDrawListSharedDataPtr GetDrawListSharedData()
		{
			return ImGuiNative.GetDrawListSharedData();
		}

		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).<br/>
		/// </summary>
		public static string GetStyleColorName(ImGuiCol idx)
		{
			var result = ImGuiNative.GetStyleColorName(idx);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)<br/>
		/// </summary>
		public static void SetStateStorage(ImGuiStoragePtr storage)
		{
			ImGuiNative.SetStateStorage(storage);
		}

		public static ImGuiStoragePtr GetStateStorage()
		{
			return ImGuiNative.GetStateStorage();
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, bool hideTextAfterDoubleHash, float wrapWidth)
		{
			var native_hideTextAfterDoubleHash = hideTextAfterDoubleHash ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, nativeTextEnd, native_hideTextAfterDoubleHash, wrapWidth);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, bool hideTextAfterDoubleHash, float wrapWidth)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			var native_hideTextAfterDoubleHash = hideTextAfterDoubleHash ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, nativeTextEnd, native_hideTextAfterDoubleHash, wrapWidth);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, bool hideTextAfterDoubleHash)
		{
			// defining omitted parameters
			float wrapWidth = -1.0f;
			var native_hideTextAfterDoubleHash = hideTextAfterDoubleHash ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, nativeTextEnd, native_hideTextAfterDoubleHash, wrapWidth);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, bool hideTextAfterDoubleHash)
		{
			// defining omitted parameters
			float wrapWidth = -1.0f;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			var native_hideTextAfterDoubleHash = hideTextAfterDoubleHash ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, nativeTextEnd, native_hideTextAfterDoubleHash, wrapWidth);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			float wrapWidth = -1.0f;
			byte hideTextAfterDoubleHash = 0;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, nativeTextEnd, hideTextAfterDoubleHash, wrapWidth);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// defining omitted parameters
			float wrapWidth = -1.0f;
			byte hideTextAfterDoubleHash = 0;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, nativeTextEnd, hideTextAfterDoubleHash, wrapWidth);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			float wrapWidth = -1.0f;
			byte hideTextAfterDoubleHash = 0;
			byte* textEnd = null;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeText = text)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, textEnd, hideTextAfterDoubleHash, wrapWidth);
			}
		}

		public static void CalcTextSize(out Vector2 pOut, ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			float wrapWidth = -1.0f;
			byte hideTextAfterDoubleHash = 0;
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.CalcTextSize(nativePOut, nativeText, textEnd, hideTextAfterDoubleHash, wrapWidth);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
			}
		}

		public static void ColorConvertU32ToFloat4(out Vector4 pOut, uint _in)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImGuiNative.ColorConvertU32ToFloat4(nativePOut, _in);
			}
		}

		public static uint ColorConvertFloat4ToU32(Vector4 _in)
		{
			return ImGuiNative.ColorConvertFloat4ToU32(_in);
		}

		public static void ColorConvertRgBtoHSV(float r, float g, float b, out float outH, out float outS, out float outV)
		{
			fixed (float* nativeOutH = &outH)
			fixed (float* nativeOutS = &outS)
			fixed (float* nativeOutV = &outV)
			{
				ImGuiNative.ColorConvertRgBtoHSV(r, g, b, nativeOutH, nativeOutS, nativeOutV);
			}
		}

		public static void ColorConvertHsVtoRGB(float h, float s, float v, out float outR, out float outG, out float outB)
		{
			fixed (float* nativeOutR = &outR)
			fixed (float* nativeOutG = &outG)
			fixed (float* nativeOutB = &outB)
			{
				ImGuiNative.ColorConvertHsVtoRGB(h, s, v, nativeOutR, nativeOutG, nativeOutB);
			}
		}

		public static bool IsKeyDown(ImGuiKey key)
		{
			var result = ImGuiNative.IsKeyDown(key);
			return result != 0;
		}

		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.<br/>
		/// </summary>
		public static bool IsKeyPressed(ImGuiKey key, bool repeat)
		{
			var native_repeat = repeat ? (byte)1 : (byte)0;
			var result = ImGuiNative.IsKeyPressed(key, native_repeat);
			return result != 0;
		}

		public static bool IsKeyReleased(ImGuiKey key)
		{
			var result = ImGuiNative.IsKeyReleased(key);
			return result != 0;
		}

		public static bool IsKeyChordPressed(int keyChord)
		{
			var result = ImGuiNative.IsKeyChordPressed(keyChord);
			return result != 0;
		}

		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be &gt;1 if RepeatRate is small enough that DeltaTime &gt; RepeatRate<br/>
		/// </summary>
		public static int GetKeyPressedAmount(ImGuiKey key, float repeatDelay, float rate)
		{
			return ImGuiNative.GetKeyPressedAmount(key, repeatDelay, rate);
		}

		/// <summary>
		/// [DEBUG] returns English name of the key. Those names are provided for debugging purpose and are not meant to be saved persistently nor compared.<br/>
		/// </summary>
		public static string GetKeyName(ImGuiKey key)
		{
			var result = ImGuiNative.GetKeyName(key);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.<br/>
		/// </summary>
		public static void SetNextFrameWantCaptureKeyboard(bool wantCaptureKeyboard)
		{
			var native_wantCaptureKeyboard = wantCaptureKeyboard ? (byte)1 : (byte)0;
			ImGuiNative.SetNextFrameWantCaptureKeyboard(native_wantCaptureKeyboard);
		}

		public static bool Shortcut(int keyChord, ImGuiInputFlags flags)
		{
			var result = ImGuiNative.Shortcut(keyChord, flags);
			return result != 0;
		}

		public static void SetNextItemShortcut(int keyChord, ImGuiInputFlags flags)
		{
			ImGuiNative.SetNextItemShortcut(keyChord, flags);
		}

		public static void SetNextItemShortcut(int keyChord)
		{
			// defining omitted parameters
			ImGuiInputFlags flags = ImGuiInputFlags.None;
			ImGuiNative.SetNextItemShortcut(keyChord, flags);
		}

		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive())  SetKeyOwner(key, GetItemID());'.<br/>
		/// </summary>
		public static void SetItemKeyOwner(ImGuiKey key)
		{
			ImGuiNative.SetItemKeyOwner(key);
		}

		public static bool IsMouseDown(ImGuiMouseButton button)
		{
			var result = ImGuiNative.IsMouseDown(button);
			return result != 0;
		}

		public static bool IsMouseClicked(ImGuiMouseButton button, bool repeat)
		{
			var native_repeat = repeat ? (byte)1 : (byte)0;
			var result = ImGuiNative.IsMouseClicked(button, native_repeat);
			return result != 0;
		}

		public static bool IsMouseReleased(ImGuiMouseButton button)
		{
			var result = ImGuiNative.IsMouseReleased(button);
			return result != 0;
		}

		public static bool IsMouseDoubleClicked(ImGuiMouseButton button)
		{
			var result = ImGuiNative.IsMouseDoubleClicked(button);
			return result != 0;
		}

		/// <summary>
		/// delayed mouse release (use very sparingly!). Generally used with 'delay &gt;= io.MouseDoubleClickTime' + combined with a 'io.MouseClickedLastCount==1' test. This is a very rarely used UI idiom, but some apps use this: e.g. MS Explorer single click on an icon to rename.<br/>
		/// </summary>
		public static bool IsMouseReleasedWithDelay(ImGuiMouseButton button, float delay)
		{
			var result = ImGuiNative.IsMouseReleasedWithDelay(button, delay);
			return result != 0;
		}

		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).<br/>
		/// </summary>
		public static int GetMouseClickedCount(ImGuiMouseButton button)
		{
			return ImGuiNative.GetMouseClickedCount(button);
		}

		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		public static bool IsMouseHoveringRect(Vector2 rMin, Vector2 rMax, bool clip)
		{
			var native_clip = clip ? (byte)1 : (byte)0;
			var result = ImGuiNative.IsMouseHoveringRect(rMin, rMax, native_clip);
			return result != 0;
		}

		/// <summary>
		/// is mouse hovering given bounding rect (in screen space). clipped by current clipping settings, but disregarding of other consideration of focus/window ordering/popup-block.<br/>
		/// </summary>
		public static bool IsMouseHoveringRect(Vector2 rMin, Vector2 rMax)
		{
			// defining omitted parameters
			byte clip = 1;
			var result = ImGuiNative.IsMouseHoveringRect(rMin, rMax, clip);
			return result != 0;
		}

		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		public static bool IsMousePosValid(Vector2[] mousePos)
		{
			fixed (Vector2* nativeMousePos = mousePos)
			{
				var result = ImGuiNative.IsMousePosValid(nativeMousePos);
				return result != 0;
			}
		}

		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available<br/>
		/// </summary>
		public static bool IsMousePosValid()
		{
			// defining omitted parameters
			Vector2* mousePos = null;
			var result = ImGuiNative.IsMousePosValid(mousePos);
			return result != 0;
		}

		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.<br/>
		/// </summary>
		public static bool IsAnyMouseDown()
		{
			var result = ImGuiNative.IsAnyMouseDown();
			return result != 0;
		}

		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls<br/>
		/// </summary>
		public static void GetMousePos(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetMousePos(nativePOut);
			}
		}

		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)<br/>
		/// </summary>
		public static void GetMousePosOnOpeningCurrentPopup(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetMousePosOnOpeningCurrentPopup(nativePOut);
			}
		}

		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static bool IsMouseDragging(ImGuiMouseButton button, float lockThreshold)
		{
			var result = ImGuiNative.IsMouseDragging(button, lockThreshold);
			return result != 0;
		}

		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static bool IsMouseDragging(ImGuiMouseButton button)
		{
			// defining omitted parameters
			float lockThreshold = -1.0f;
			var result = ImGuiNative.IsMouseDragging(button, lockThreshold);
			return result != 0;
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static void GetMouseDragDelta(out Vector2 pOut, ImGuiMouseButton button, float lockThreshold)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetMouseDragDelta(nativePOut, button, lockThreshold);
			}
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static void GetMouseDragDelta(out Vector2 pOut, ImGuiMouseButton button)
		{
			// defining omitted parameters
			float lockThreshold = -1.0f;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetMouseDragDelta(nativePOut, button, lockThreshold);
			}
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)<br/>
		/// </summary>
		public static void GetMouseDragDelta(out Vector2 pOut)
		{
			// defining omitted parameters
			float lockThreshold = -1.0f;
			ImGuiMouseButton button = ImGuiMouseButton.Left;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetMouseDragDelta(nativePOut, button, lockThreshold);
			}
		}

		/// <summary>
		/// //<br/>
		/// </summary>
		public static void ResetMouseDragDelta(ImGuiMouseButton button)
		{
			ImGuiNative.ResetMouseDragDelta(button);
		}

		/// <summary>
		/// //<br/>
		/// </summary>
		public static void ResetMouseDragDelta()
		{
			// defining omitted parameters
			ImGuiMouseButton button = ImGuiMouseButton.Left;
			ImGuiNative.ResetMouseDragDelta(button);
		}

		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you<br/>
		/// </summary>
		public static ImGuiMouseCursor GetMouseCursor()
		{
			return ImGuiNative.GetMouseCursor();
		}

		/// <summary>
		/// set desired mouse cursor shape<br/>
		/// </summary>
		public static void SetMouseCursor(ImGuiMouseCursor cursorType)
		{
			ImGuiNative.SetMouseCursor(cursorType);
		}

		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.<br/>
		/// </summary>
		public static void SetNextFrameWantCaptureMouse(bool wantCaptureMouse)
		{
			var native_wantCaptureMouse = wantCaptureMouse ? (byte)1 : (byte)0;
			ImGuiNative.SetNextFrameWantCaptureMouse(native_wantCaptureMouse);
		}

		public static string GetClipboardText()
		{
			var result = ImGuiNative.GetClipboardText();
			return Utils.DecodeStringUTF8(result);
		}

		public static void SetClipboardText(ReadOnlySpan<byte> text)
		{
			fixed (byte* nativeText = text)
			{
				ImGuiNative.SetClipboardText(nativeText);
			}
		}

		public static void SetClipboardText(ReadOnlySpan<char> text)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImGuiNative.SetClipboardText(nativeText);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		public static void LoadIniSettingsFromDisk(ReadOnlySpan<byte> iniFilename)
		{
			fixed (byte* nativeIniFilename = iniFilename)
			{
				ImGuiNative.LoadIniSettingsFromDisk(nativeIniFilename);
			}
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).<br/>
		/// </summary>
		public static void LoadIniSettingsFromDisk(ReadOnlySpan<char> iniFilename)
		{
			// Marshaling iniFilename to native string
			byte* nativeIniFilename;
			var byteCountIniFilename = 0;
			if (iniFilename != null && !iniFilename.IsEmpty)
			{
				byteCountIniFilename = Encoding.UTF8.GetByteCount(iniFilename);
				if(byteCountIniFilename > Utils.MaxStackallocSize)
				{
					nativeIniFilename = Utils.Alloc<byte>(byteCountIniFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIniFilename + 1];
					nativeIniFilename = stackallocBytes;
				}
				var offsetIniFilename = Utils.EncodeStringUTF8(iniFilename, nativeIniFilename, byteCountIniFilename);
				nativeIniFilename[offsetIniFilename] = 0;
			}
			else nativeIniFilename = null;

			ImGuiNative.LoadIniSettingsFromDisk(nativeIniFilename);
			// Freeing iniFilename native string
			if (byteCountIniFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeIniFilename);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<byte> iniData, uint iniSize)
		{
			fixed (byte* nativeIniData = iniData)
			{
				ImGuiNative.LoadIniSettingsFromMemory(nativeIniData, iniSize);
			}
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> iniData, uint iniSize)
		{
			// Marshaling iniData to native string
			byte* nativeIniData;
			var byteCountIniData = 0;
			if (iniData != null && !iniData.IsEmpty)
			{
				byteCountIniData = Encoding.UTF8.GetByteCount(iniData);
				if(byteCountIniData > Utils.MaxStackallocSize)
				{
					nativeIniData = Utils.Alloc<byte>(byteCountIniData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIniData + 1];
					nativeIniData = stackallocBytes;
				}
				var offsetIniData = Utils.EncodeStringUTF8(iniData, nativeIniData, byteCountIniData);
				nativeIniData[offsetIniData] = 0;
			}
			else nativeIniData = null;

			ImGuiNative.LoadIniSettingsFromMemory(nativeIniData, iniSize);
			// Freeing iniData native string
			if (byteCountIniData > Utils.MaxStackallocSize)
				Utils.Free(nativeIniData);
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<byte> iniData)
		{
			// defining omitted parameters
			uint iniSize = 0;
			fixed (byte* nativeIniData = iniData)
			{
				ImGuiNative.LoadIniSettingsFromMemory(nativeIniData, iniSize);
			}
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.<br/>
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> iniData)
		{
			// defining omitted parameters
			uint iniSize = 0;
			// Marshaling iniData to native string
			byte* nativeIniData;
			var byteCountIniData = 0;
			if (iniData != null && !iniData.IsEmpty)
			{
				byteCountIniData = Encoding.UTF8.GetByteCount(iniData);
				if(byteCountIniData > Utils.MaxStackallocSize)
				{
					nativeIniData = Utils.Alloc<byte>(byteCountIniData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIniData + 1];
					nativeIniData = stackallocBytes;
				}
				var offsetIniData = Utils.EncodeStringUTF8(iniData, nativeIniData, byteCountIniData);
				nativeIniData[offsetIniData] = 0;
			}
			else nativeIniData = null;

			ImGuiNative.LoadIniSettingsFromMemory(nativeIniData, iniSize);
			// Freeing iniData native string
			if (byteCountIniData > Utils.MaxStackallocSize)
				Utils.Free(nativeIniData);
		}

		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		public static void SaveIniSettingsToDisk(ReadOnlySpan<byte> iniFilename)
		{
			fixed (byte* nativeIniFilename = iniFilename)
			{
				ImGuiNative.SaveIniSettingsToDisk(nativeIniFilename);
			}
		}

		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).<br/>
		/// </summary>
		public static void SaveIniSettingsToDisk(ReadOnlySpan<char> iniFilename)
		{
			// Marshaling iniFilename to native string
			byte* nativeIniFilename;
			var byteCountIniFilename = 0;
			if (iniFilename != null && !iniFilename.IsEmpty)
			{
				byteCountIniFilename = Encoding.UTF8.GetByteCount(iniFilename);
				if(byteCountIniFilename > Utils.MaxStackallocSize)
				{
					nativeIniFilename = Utils.Alloc<byte>(byteCountIniFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIniFilename + 1];
					nativeIniFilename = stackallocBytes;
				}
				var offsetIniFilename = Utils.EncodeStringUTF8(iniFilename, nativeIniFilename, byteCountIniFilename);
				nativeIniFilename[offsetIniFilename] = 0;
			}
			else nativeIniFilename = null;

			ImGuiNative.SaveIniSettingsToDisk(nativeIniFilename);
			// Freeing iniFilename native string
			if (byteCountIniFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeIniFilename);
		}

		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		public static string SaveIniSettingsToMemory(out uint outIniSize)
		{
			fixed (uint* nativeOutIniSize = &outIniSize)
			{
				var result = ImGuiNative.SaveIniSettingsToMemory(nativeOutIniSize);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.<br/>
		/// </summary>
		public static string SaveIniSettingsToMemory()
		{
			// defining omitted parameters
			uint* outIniSize = null;
			var result = ImGuiNative.SaveIniSettingsToMemory(outIniSize);
			return Utils.DecodeStringUTF8(result);
		}

		public static void DebugTextEncoding(ReadOnlySpan<byte> text)
		{
			fixed (byte* nativeText = text)
			{
				ImGuiNative.DebugTextEncoding(nativeText);
			}
		}

		public static void DebugTextEncoding(ReadOnlySpan<char> text)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImGuiNative.DebugTextEncoding(nativeText);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void DebugFlashStyleColor(ImGuiCol idx)
		{
			ImGuiNative.DebugFlashStyleColor(idx);
		}

		public static void DebugStartItemPicker()
		{
			ImGuiNative.DebugStartItemPicker();
		}

		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		public static bool DebugCheckVersionAndDataLayout(ReadOnlySpan<byte> versionStr, uint szIo, uint szStyle, uint szVec2, uint szVec4, uint szDrawvert, uint szDrawidx)
		{
			fixed (byte* nativeVersionStr = versionStr)
			{
				var result = ImGuiNative.DebugCheckVersionAndDataLayout(nativeVersionStr, szIo, szStyle, szVec2, szVec4, szDrawvert, szDrawidx);
				return result != 0;
			}
		}

		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.<br/>
		/// </summary>
		public static bool DebugCheckVersionAndDataLayout(ReadOnlySpan<char> versionStr, uint szIo, uint szStyle, uint szVec2, uint szVec4, uint szDrawvert, uint szDrawidx)
		{
			// Marshaling versionStr to native string
			byte* nativeVersionStr;
			var byteCountVersionStr = 0;
			if (versionStr != null && !versionStr.IsEmpty)
			{
				byteCountVersionStr = Encoding.UTF8.GetByteCount(versionStr);
				if(byteCountVersionStr > Utils.MaxStackallocSize)
				{
					nativeVersionStr = Utils.Alloc<byte>(byteCountVersionStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountVersionStr + 1];
					nativeVersionStr = stackallocBytes;
				}
				var offsetVersionStr = Utils.EncodeStringUTF8(versionStr, nativeVersionStr, byteCountVersionStr);
				nativeVersionStr[offsetVersionStr] = 0;
			}
			else nativeVersionStr = null;

			var result = ImGuiNative.DebugCheckVersionAndDataLayout(nativeVersionStr, szIo, szStyle, szVec2, szVec4, szDrawvert, szDrawidx);
			// Freeing versionStr native string
			if (byteCountVersionStr > Utils.MaxStackallocSize)
				Utils.Free(nativeVersionStr);
			return result != 0;
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		public static void DebugLog(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.DebugLog(nativeFmt);
			}
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!<br/>
		/// </summary>
		public static void DebugLog(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.DebugLog(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public static void SetAllocatorFunctions(ImGuiMemAllocFunc allocFunc, ImGuiMemFreeFunc freeFunc, IntPtr userData)
		{
			ImGuiNative.SetAllocatorFunctions(allocFunc, freeFunc, (void*)userData);
		}

		public static void SetAllocatorFunctions(ImGuiMemAllocFunc allocFunc, ImGuiMemFreeFunc freeFunc)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiNative.SetAllocatorFunctions(allocFunc, freeFunc, userData);
		}

		public static void GetAllocatorFunctions(out ImGuiMemAllocFunc pAllocFunc, out ImGuiMemFreeFunc pFreeFunc, ref void* pUserData)
		{
			void* nativePAllocFunc;
			void* nativePFreeFunc;
			fixed (void** nativePUserData = &pUserData)
			{
				ImGuiNative.GetAllocatorFunctions(&nativePAllocFunc, &nativePFreeFunc, nativePUserData);
				pAllocFunc = Marshal.GetDelegateForFunctionPointer<ImGuiMemAllocFunc>((IntPtr)nativePAllocFunc);
				pFreeFunc = Marshal.GetDelegateForFunctionPointer<ImGuiMemFreeFunc>((IntPtr)nativePFreeFunc);
			}
		}

		public static IntPtr MemAlloc(uint size)
		{
			return (IntPtr)ImGuiNative.MemAlloc(size);
		}

		public static void MemFree(IntPtr ptr)
		{
			ImGuiNative.MemFree((void*)ptr);
		}

		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.<br/>
		/// </summary>
		public static void UpdatePlatformWindows()
		{
			ImGuiNative.UpdatePlatformWindows();
		}

		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		public static void RenderPlatformWindowsDefault(IntPtr platformRenderArg, IntPtr rendererRenderArg)
		{
			ImGuiNative.RenderPlatformWindowsDefault((void*)platformRenderArg, (void*)rendererRenderArg);
		}

		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		public static void RenderPlatformWindowsDefault(IntPtr platformRenderArg)
		{
			// defining omitted parameters
			void* rendererRenderArg = null;
			ImGuiNative.RenderPlatformWindowsDefault((void*)platformRenderArg, rendererRenderArg);
		}

		/// <summary>
		/// call in main loop. will call RenderWindow/SwapBuffers platform functions for each secondary viewport which doesn't have the ImGuiViewportFlags_Minimized flag set. May be reimplemented by user for custom rendering needs.<br/>
		/// </summary>
		public static void RenderPlatformWindowsDefault()
		{
			// defining omitted parameters
			void* rendererRenderArg = null;
			void* platformRenderArg = null;
			ImGuiNative.RenderPlatformWindowsDefault(platformRenderArg, rendererRenderArg);
		}

		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().<br/>
		/// </summary>
		public static void DestroyPlatformWindows()
		{
			ImGuiNative.DestroyPlatformWindows();
		}

		/// <summary>
		/// this is a helper for backends.<br/>
		/// </summary>
		public static ImGuiViewportPtr FindViewportByID(uint id)
		{
			return ImGuiNative.FindViewportByID(id);
		}

		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)<br/>
		/// </summary>
		public static ImGuiViewportPtr FindViewportByPlatformHandle(IntPtr platformHandle)
		{
			return ImGuiNative.FindViewportByPlatformHandle((void*)platformHandle);
		}

		public static uint ImHashData(IntPtr data, uint dataSize)
		{
			// defining omitted parameters
			uint seed = 0;
			return ImGuiNative.ImHashData((void*)data, dataSize, seed);
		}

		public static uint ImHashStr(ReadOnlySpan<char> data, uint dataSize, uint seed)
		{
			// Marshaling data to native string
			byte* nativeData;
			var byteCountData = 0;
			if (data != null && !data.IsEmpty)
			{
				byteCountData = Encoding.UTF8.GetByteCount(data);
				if(byteCountData > Utils.MaxStackallocSize)
				{
					nativeData = Utils.Alloc<byte>(byteCountData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountData + 1];
					nativeData = stackallocBytes;
				}
				var offsetData = Utils.EncodeStringUTF8(data, nativeData, byteCountData);
				nativeData[offsetData] = 0;
			}
			else nativeData = null;

			var result = ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
			return result;
		}

		public static uint ImHashStr(ReadOnlySpan<byte> data, uint dataSize)
		{
			// defining omitted parameters
			uint seed = 0;
			fixed (byte* nativeData = data)
			{
				return ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			}
		}

		public static uint ImHashStr(ReadOnlySpan<char> data, uint dataSize)
		{
			// defining omitted parameters
			uint seed = 0;
			// Marshaling data to native string
			byte* nativeData;
			var byteCountData = 0;
			if (data != null && !data.IsEmpty)
			{
				byteCountData = Encoding.UTF8.GetByteCount(data);
				if(byteCountData > Utils.MaxStackallocSize)
				{
					nativeData = Utils.Alloc<byte>(byteCountData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountData + 1];
					nativeData = stackallocBytes;
				}
				var offsetData = Utils.EncodeStringUTF8(data, nativeData, byteCountData);
				nativeData[offsetData] = 0;
			}
			else nativeData = null;

			var result = ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
			return result;
		}

		public static uint ImHashStr(ReadOnlySpan<byte> data)
		{
			// defining omitted parameters
			uint seed = 0;
			uint dataSize = 0;
			fixed (byte* nativeData = data)
			{
				return ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			}
		}

		public static uint ImHashStr(ReadOnlySpan<char> data)
		{
			// defining omitted parameters
			uint seed = 0;
			uint dataSize = 0;
			// Marshaling data to native string
			byte* nativeData;
			var byteCountData = 0;
			if (data != null && !data.IsEmpty)
			{
				byteCountData = Encoding.UTF8.GetByteCount(data);
				if(byteCountData > Utils.MaxStackallocSize)
				{
					nativeData = Utils.Alloc<byte>(byteCountData + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountData + 1];
					nativeData = stackallocBytes;
				}
				var offsetData = Utils.EncodeStringUTF8(data, nativeData, byteCountData);
				nativeData[offsetData] = 0;
			}
			else nativeData = null;

			var result = ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			// Freeing data native string
			if (byteCountData > Utils.MaxStackallocSize)
				Utils.Free(nativeData);
			return result;
		}

		public static bool ImIsPowerOfTwo(int v)
		{
			var result = ImGuiNative.ImIsPowerOfTwo(v);
			return result != 0;
		}

		public static bool ImIsPowerOfTwo(ulong v)
		{
			var result = ImGuiNative.ImIsPowerOfTwo(v);
			return result != 0;
		}

		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		public static int ImStricmp(ReadOnlySpan<char> str1, ReadOnlySpan<char> str2)
		{
			// Marshaling str1 to native string
			byte* nativeStr1;
			var byteCountStr1 = 0;
			if (str1 != null && !str1.IsEmpty)
			{
				byteCountStr1 = Encoding.UTF8.GetByteCount(str1);
				if(byteCountStr1 > Utils.MaxStackallocSize)
				{
					nativeStr1 = Utils.Alloc<byte>(byteCountStr1 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr1 + 1];
					nativeStr1 = stackallocBytes;
				}
				var offsetStr1 = Utils.EncodeStringUTF8(str1, nativeStr1, byteCountStr1);
				nativeStr1[offsetStr1] = 0;
			}
			else nativeStr1 = null;

			// Marshaling str2 to native string
			byte* nativeStr2;
			var byteCountStr2 = 0;
			if (str2 != null && !str2.IsEmpty)
			{
				byteCountStr2 = Encoding.UTF8.GetByteCount(str2);
				if(byteCountStr2 > Utils.MaxStackallocSize)
				{
					nativeStr2 = Utils.Alloc<byte>(byteCountStr2 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr2 + 1];
					nativeStr2 = stackallocBytes;
				}
				var offsetStr2 = Utils.EncodeStringUTF8(str2, nativeStr2, byteCountStr2);
				nativeStr2[offsetStr2] = 0;
			}
			else nativeStr2 = null;

			var result = ImGuiNative.ImStricmp(nativeStr1, nativeStr2);
			// Freeing str1 native string
			if (byteCountStr1 > Utils.MaxStackallocSize)
				Utils.Free(nativeStr1);
			// Freeing str2 native string
			if (byteCountStr2 > Utils.MaxStackallocSize)
				Utils.Free(nativeStr2);
			return result;
		}

		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		public static int ImStrnicmp(ReadOnlySpan<char> str1, ReadOnlySpan<char> str2, uint count)
		{
			// Marshaling str1 to native string
			byte* nativeStr1;
			var byteCountStr1 = 0;
			if (str1 != null && !str1.IsEmpty)
			{
				byteCountStr1 = Encoding.UTF8.GetByteCount(str1);
				if(byteCountStr1 > Utils.MaxStackallocSize)
				{
					nativeStr1 = Utils.Alloc<byte>(byteCountStr1 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr1 + 1];
					nativeStr1 = stackallocBytes;
				}
				var offsetStr1 = Utils.EncodeStringUTF8(str1, nativeStr1, byteCountStr1);
				nativeStr1[offsetStr1] = 0;
			}
			else nativeStr1 = null;

			// Marshaling str2 to native string
			byte* nativeStr2;
			var byteCountStr2 = 0;
			if (str2 != null && !str2.IsEmpty)
			{
				byteCountStr2 = Encoding.UTF8.GetByteCount(str2);
				if(byteCountStr2 > Utils.MaxStackallocSize)
				{
					nativeStr2 = Utils.Alloc<byte>(byteCountStr2 + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr2 + 1];
					nativeStr2 = stackallocBytes;
				}
				var offsetStr2 = Utils.EncodeStringUTF8(str2, nativeStr2, byteCountStr2);
				nativeStr2[offsetStr2] = 0;
			}
			else nativeStr2 = null;

			var result = ImGuiNative.ImStrnicmp(nativeStr1, nativeStr2, count);
			// Freeing str1 native string
			if (byteCountStr1 > Utils.MaxStackallocSize)
				Utils.Free(nativeStr1);
			// Freeing str2 native string
			if (byteCountStr2 > Utils.MaxStackallocSize)
				Utils.Free(nativeStr2);
			return result;
		}

		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		public static void ImStrncpy(byte[] dst, ReadOnlySpan<char> src, uint count)
		{
			// Marshaling src to native string
			byte* nativeSrc;
			var byteCountSrc = 0;
			if (src != null && !src.IsEmpty)
			{
				byteCountSrc = Encoding.UTF8.GetByteCount(src);
				if(byteCountSrc > Utils.MaxStackallocSize)
				{
					nativeSrc = Utils.Alloc<byte>(byteCountSrc + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountSrc + 1];
					nativeSrc = stackallocBytes;
				}
				var offsetSrc = Utils.EncodeStringUTF8(src, nativeSrc, byteCountSrc);
				nativeSrc[offsetSrc] = 0;
			}
			else nativeSrc = null;

			fixed (byte* nativeDst = dst)
			{
				ImGuiNative.ImStrncpy(nativeDst, nativeSrc, count);
				// Freeing src native string
				if (byteCountSrc > Utils.MaxStackallocSize)
					Utils.Free(nativeSrc);
			}
		}

		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		public static ref byte ImStrdup(ReadOnlySpan<char> str)
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

			var nativeResult = ImGuiNative.ImStrdup(nativeStr);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
			return ref *(byte*)&nativeResult;
		}

		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		public static ref byte ImStrdupcpy(byte[] dst, ref uint pDstSize, ReadOnlySpan<char> str)
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

			fixed (byte* nativeDst = dst)
			fixed (uint* nativePDstSize = &pDstSize)
			{
				var nativeResult = ImGuiNative.ImStrdupcpy(nativeDst, nativePDstSize, nativeStr);
				// Freeing str native string
				if (byteCountStr > Utils.MaxStackallocSize)
					Utils.Free(nativeStr);
				return ref *(byte*)&nativeResult;
			}
		}

		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		public static string ImStrchrRange(ReadOnlySpan<char> strBegin, ReadOnlySpan<char> strEnd, bool c)
		{
			// Marshaling strBegin to native string
			byte* nativeStrBegin;
			var byteCountStrBegin = 0;
			if (strBegin != null && !strBegin.IsEmpty)
			{
				byteCountStrBegin = Encoding.UTF8.GetByteCount(strBegin);
				if(byteCountStrBegin > Utils.MaxStackallocSize)
				{
					nativeStrBegin = Utils.Alloc<byte>(byteCountStrBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrBegin + 1];
					nativeStrBegin = stackallocBytes;
				}
				var offsetStrBegin = Utils.EncodeStringUTF8(strBegin, nativeStrBegin, byteCountStrBegin);
				nativeStrBegin[offsetStrBegin] = 0;
			}
			else nativeStrBegin = null;

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

			var native_c = c ? (byte)1 : (byte)0;
			var result = ImGuiNative.ImStrchrRange(nativeStrBegin, nativeStrEnd, native_c);
			// Freeing strBegin native string
			if (byteCountStrBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeStrBegin);
			// Freeing strEnd native string
			if (byteCountStrEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrEnd);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		public static string ImStreolRange(ReadOnlySpan<char> str, ReadOnlySpan<char> strEnd)
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

			var result = ImGuiNative.ImStreolRange(nativeStr, nativeStrEnd);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
			// Freeing strEnd native string
			if (byteCountStrEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrEnd);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		public static string ImStristr(ReadOnlySpan<char> haystack, ReadOnlySpan<char> haystackEnd, ReadOnlySpan<char> needle, ReadOnlySpan<char> needleEnd)
		{
			// Marshaling haystack to native string
			byte* nativeHaystack;
			var byteCountHaystack = 0;
			if (haystack != null && !haystack.IsEmpty)
			{
				byteCountHaystack = Encoding.UTF8.GetByteCount(haystack);
				if(byteCountHaystack > Utils.MaxStackallocSize)
				{
					nativeHaystack = Utils.Alloc<byte>(byteCountHaystack + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHaystack + 1];
					nativeHaystack = stackallocBytes;
				}
				var offsetHaystack = Utils.EncodeStringUTF8(haystack, nativeHaystack, byteCountHaystack);
				nativeHaystack[offsetHaystack] = 0;
			}
			else nativeHaystack = null;

			// Marshaling haystackEnd to native string
			byte* nativeHaystackEnd;
			var byteCountHaystackEnd = 0;
			if (haystackEnd != null && !haystackEnd.IsEmpty)
			{
				byteCountHaystackEnd = Encoding.UTF8.GetByteCount(haystackEnd);
				if(byteCountHaystackEnd > Utils.MaxStackallocSize)
				{
					nativeHaystackEnd = Utils.Alloc<byte>(byteCountHaystackEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHaystackEnd + 1];
					nativeHaystackEnd = stackallocBytes;
				}
				var offsetHaystackEnd = Utils.EncodeStringUTF8(haystackEnd, nativeHaystackEnd, byteCountHaystackEnd);
				nativeHaystackEnd[offsetHaystackEnd] = 0;
			}
			else nativeHaystackEnd = null;

			// Marshaling needle to native string
			byte* nativeNeedle;
			var byteCountNeedle = 0;
			if (needle != null && !needle.IsEmpty)
			{
				byteCountNeedle = Encoding.UTF8.GetByteCount(needle);
				if(byteCountNeedle > Utils.MaxStackallocSize)
				{
					nativeNeedle = Utils.Alloc<byte>(byteCountNeedle + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountNeedle + 1];
					nativeNeedle = stackallocBytes;
				}
				var offsetNeedle = Utils.EncodeStringUTF8(needle, nativeNeedle, byteCountNeedle);
				nativeNeedle[offsetNeedle] = 0;
			}
			else nativeNeedle = null;

			// Marshaling needleEnd to native string
			byte* nativeNeedleEnd;
			var byteCountNeedleEnd = 0;
			if (needleEnd != null && !needleEnd.IsEmpty)
			{
				byteCountNeedleEnd = Encoding.UTF8.GetByteCount(needleEnd);
				if(byteCountNeedleEnd > Utils.MaxStackallocSize)
				{
					nativeNeedleEnd = Utils.Alloc<byte>(byteCountNeedleEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountNeedleEnd + 1];
					nativeNeedleEnd = stackallocBytes;
				}
				var offsetNeedleEnd = Utils.EncodeStringUTF8(needleEnd, nativeNeedleEnd, byteCountNeedleEnd);
				nativeNeedleEnd[offsetNeedleEnd] = 0;
			}
			else nativeNeedleEnd = null;

			var result = ImGuiNative.ImStristr(nativeHaystack, nativeHaystackEnd, nativeNeedle, nativeNeedleEnd);
			// Freeing haystack native string
			if (byteCountHaystack > Utils.MaxStackallocSize)
				Utils.Free(nativeHaystack);
			// Freeing haystackEnd native string
			if (byteCountHaystackEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeHaystackEnd);
			// Freeing needle native string
			if (byteCountNeedle > Utils.MaxStackallocSize)
				Utils.Free(nativeNeedle);
			// Freeing needleEnd native string
			if (byteCountNeedleEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeNeedleEnd);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		public static string ImStrSkipBlank(ReadOnlySpan<char> str)
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

			var result = ImGuiNative.ImStrSkipBlank(nativeStr);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		public static string ImStrbol(ReadOnlySpan<char> bufMidLine, ReadOnlySpan<char> bufBegin)
		{
			// Marshaling bufMidLine to native string
			byte* nativeBufMidLine;
			var byteCountBufMidLine = 0;
			if (bufMidLine != null && !bufMidLine.IsEmpty)
			{
				byteCountBufMidLine = Encoding.UTF8.GetByteCount(bufMidLine);
				if(byteCountBufMidLine > Utils.MaxStackallocSize)
				{
					nativeBufMidLine = Utils.Alloc<byte>(byteCountBufMidLine + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBufMidLine + 1];
					nativeBufMidLine = stackallocBytes;
				}
				var offsetBufMidLine = Utils.EncodeStringUTF8(bufMidLine, nativeBufMidLine, byteCountBufMidLine);
				nativeBufMidLine[offsetBufMidLine] = 0;
			}
			else nativeBufMidLine = null;

			// Marshaling bufBegin to native string
			byte* nativeBufBegin;
			var byteCountBufBegin = 0;
			if (bufBegin != null && !bufBegin.IsEmpty)
			{
				byteCountBufBegin = Encoding.UTF8.GetByteCount(bufBegin);
				if(byteCountBufBegin > Utils.MaxStackallocSize)
				{
					nativeBufBegin = Utils.Alloc<byte>(byteCountBufBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBufBegin + 1];
					nativeBufBegin = stackallocBytes;
				}
				var offsetBufBegin = Utils.EncodeStringUTF8(bufBegin, nativeBufBegin, byteCountBufBegin);
				nativeBufBegin[offsetBufBegin] = 0;
			}
			else nativeBufBegin = null;

			var result = ImGuiNative.ImStrbol(nativeBufMidLine, nativeBufBegin);
			// Freeing bufMidLine native string
			if (byteCountBufMidLine > Utils.MaxStackallocSize)
				Utils.Free(nativeBufMidLine);
			// Freeing bufBegin native string
			if (byteCountBufBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeBufBegin);
			return Utils.DecodeStringUTF8(result);
		}

		public static int ImFormatString(byte[] buf, uint bufSize, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.ImFormatString(nativeBuf, bufSize, nativeFmt);
				// Freeing fmt native string
				if (byteCountFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeFmt);
				return result;
			}
		}

		public static void ImFormatStringToTempBuffer(out byte* outBuf, out byte* outBufEnd, ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			fixed (byte** nativeOutBuf = &outBuf)
			fixed (byte** nativeOutBufEnd = &outBufEnd)
			{
				ImGuiNative.ImFormatStringToTempBuffer(nativeOutBuf, nativeOutBufEnd, nativeFmt);
				// Freeing fmt native string
				if (byteCountFmt > Utils.MaxStackallocSize)
					Utils.Free(nativeFmt);
			}
		}

		public static string ImParseFormatFindStart(ReadOnlySpan<char> format)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.ImParseFormatFindStart(nativeFormat);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return Utils.DecodeStringUTF8(result);
		}

		public static string ImParseFormatFindEnd(ReadOnlySpan<char> format)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.ImParseFormatFindEnd(nativeFormat);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return Utils.DecodeStringUTF8(result);
		}

		public static string ImParseFormatTrimDecorations(ReadOnlySpan<char> format, byte[] buf, uint bufSize)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.ImParseFormatTrimDecorations(nativeFormat, nativeBuf, bufSize);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static void ImParseFormatSanitizeForPrinting(ReadOnlySpan<char> fmtIn, byte[] fmtOut, uint fmtOutSize)
		{
			// Marshaling fmtIn to native string
			byte* nativeFmtIn;
			var byteCountFmtIn = 0;
			if (fmtIn != null && !fmtIn.IsEmpty)
			{
				byteCountFmtIn = Encoding.UTF8.GetByteCount(fmtIn);
				if(byteCountFmtIn > Utils.MaxStackallocSize)
				{
					nativeFmtIn = Utils.Alloc<byte>(byteCountFmtIn + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmtIn + 1];
					nativeFmtIn = stackallocBytes;
				}
				var offsetFmtIn = Utils.EncodeStringUTF8(fmtIn, nativeFmtIn, byteCountFmtIn);
				nativeFmtIn[offsetFmtIn] = 0;
			}
			else nativeFmtIn = null;

			fixed (byte* nativeFmtOut = fmtOut)
			{
				ImGuiNative.ImParseFormatSanitizeForPrinting(nativeFmtIn, nativeFmtOut, fmtOutSize);
				// Freeing fmtIn native string
				if (byteCountFmtIn > Utils.MaxStackallocSize)
					Utils.Free(nativeFmtIn);
			}
		}

		public static string ImParseFormatSanitizeForScanning(ReadOnlySpan<char> fmtIn, byte[] fmtOut, uint fmtOutSize)
		{
			// Marshaling fmtIn to native string
			byte* nativeFmtIn;
			var byteCountFmtIn = 0;
			if (fmtIn != null && !fmtIn.IsEmpty)
			{
				byteCountFmtIn = Encoding.UTF8.GetByteCount(fmtIn);
				if(byteCountFmtIn > Utils.MaxStackallocSize)
				{
					nativeFmtIn = Utils.Alloc<byte>(byteCountFmtIn + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmtIn + 1];
					nativeFmtIn = stackallocBytes;
				}
				var offsetFmtIn = Utils.EncodeStringUTF8(fmtIn, nativeFmtIn, byteCountFmtIn);
				nativeFmtIn[offsetFmtIn] = 0;
			}
			else nativeFmtIn = null;

			fixed (byte* nativeFmtOut = fmtOut)
			{
				var result = ImGuiNative.ImParseFormatSanitizeForScanning(nativeFmtIn, nativeFmtOut, fmtOutSize);
				// Freeing fmtIn native string
				if (byteCountFmtIn > Utils.MaxStackallocSize)
					Utils.Free(nativeFmtIn);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static int ImParseFormatPrecision(ReadOnlySpan<char> format, int defaultValue)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.ImParseFormatPrecision(nativeFormat, defaultValue);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result;
		}

		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextCharFromUtf8(out uint outChar, ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* nativeInText;
			var byteCountInText = 0;
			if (inText != null && !inText.IsEmpty)
			{
				byteCountInText = Encoding.UTF8.GetByteCount(inText);
				if(byteCountInText > Utils.MaxStackallocSize)
				{
					nativeInText = Utils.Alloc<byte>(byteCountInText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInText + 1];
					nativeInText = stackallocBytes;
				}
				var offsetInText = Utils.EncodeStringUTF8(inText, nativeInText, byteCountInText);
				nativeInText[offsetInText] = 0;
			}
			else nativeInText = null;

			// Marshaling inTextEnd to native string
			byte* nativeInTextEnd;
			var byteCountInTextEnd = 0;
			if (inTextEnd != null && !inTextEnd.IsEmpty)
			{
				byteCountInTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCountInTextEnd > Utils.MaxStackallocSize)
				{
					nativeInTextEnd = Utils.Alloc<byte>(byteCountInTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextEnd + 1];
					nativeInTextEnd = stackallocBytes;
				}
				var offsetInTextEnd = Utils.EncodeStringUTF8(inTextEnd, nativeInTextEnd, byteCountInTextEnd);
				nativeInTextEnd[offsetInTextEnd] = 0;
			}
			else nativeInTextEnd = null;

			fixed (uint* nativeOutChar = &outChar)
			{
				var result = ImGuiNative.ImTextCharFromUtf8(nativeOutChar, nativeInText, nativeInTextEnd);
				// Freeing inText native string
				if (byteCountInText > Utils.MaxStackallocSize)
					Utils.Free(nativeInText);
				// Freeing inTextEnd native string
				if (byteCountInTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeInTextEnd);
				return result;
			}
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrFromUtf8(out ushort outBuf, int outBufSize, ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd, ref byte* inRemaining)
		{
			// Marshaling inText to native string
			byte* nativeInText;
			var byteCountInText = 0;
			if (inText != null && !inText.IsEmpty)
			{
				byteCountInText = Encoding.UTF8.GetByteCount(inText);
				if(byteCountInText > Utils.MaxStackallocSize)
				{
					nativeInText = Utils.Alloc<byte>(byteCountInText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInText + 1];
					nativeInText = stackallocBytes;
				}
				var offsetInText = Utils.EncodeStringUTF8(inText, nativeInText, byteCountInText);
				nativeInText[offsetInText] = 0;
			}
			else nativeInText = null;

			// Marshaling inTextEnd to native string
			byte* nativeInTextEnd;
			var byteCountInTextEnd = 0;
			if (inTextEnd != null && !inTextEnd.IsEmpty)
			{
				byteCountInTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCountInTextEnd > Utils.MaxStackallocSize)
				{
					nativeInTextEnd = Utils.Alloc<byte>(byteCountInTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextEnd + 1];
					nativeInTextEnd = stackallocBytes;
				}
				var offsetInTextEnd = Utils.EncodeStringUTF8(inTextEnd, nativeInTextEnd, byteCountInTextEnd);
				nativeInTextEnd[offsetInTextEnd] = 0;
			}
			else nativeInTextEnd = null;

			fixed (ushort* nativeOutBuf = &outBuf)
			fixed (byte** nativeInRemaining = &inRemaining)
			{
				var result = ImGuiNative.ImTextStrFromUtf8(nativeOutBuf, outBufSize, nativeInText, nativeInTextEnd, nativeInRemaining);
				// Freeing inText native string
				if (byteCountInText > Utils.MaxStackallocSize)
					Utils.Free(nativeInText);
				// Freeing inTextEnd native string
				if (byteCountInTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeInTextEnd);
				return result;
			}
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrFromUtf8(out ushort outBuf, int outBufSize, ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd)
		{
			// defining omitted parameters
			byte** inRemaining = null;
			fixed (ushort* nativeOutBuf = &outBuf)
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextStrFromUtf8(nativeOutBuf, outBufSize, nativeInText, nativeInTextEnd, inRemaining);
			}
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrFromUtf8(out ushort outBuf, int outBufSize, ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// defining omitted parameters
			byte** inRemaining = null;
			// Marshaling inText to native string
			byte* nativeInText;
			var byteCountInText = 0;
			if (inText != null && !inText.IsEmpty)
			{
				byteCountInText = Encoding.UTF8.GetByteCount(inText);
				if(byteCountInText > Utils.MaxStackallocSize)
				{
					nativeInText = Utils.Alloc<byte>(byteCountInText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInText + 1];
					nativeInText = stackallocBytes;
				}
				var offsetInText = Utils.EncodeStringUTF8(inText, nativeInText, byteCountInText);
				nativeInText[offsetInText] = 0;
			}
			else nativeInText = null;

			// Marshaling inTextEnd to native string
			byte* nativeInTextEnd;
			var byteCountInTextEnd = 0;
			if (inTextEnd != null && !inTextEnd.IsEmpty)
			{
				byteCountInTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCountInTextEnd > Utils.MaxStackallocSize)
				{
					nativeInTextEnd = Utils.Alloc<byte>(byteCountInTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextEnd + 1];
					nativeInTextEnd = stackallocBytes;
				}
				var offsetInTextEnd = Utils.EncodeStringUTF8(inTextEnd, nativeInTextEnd, byteCountInTextEnd);
				nativeInTextEnd[offsetInTextEnd] = 0;
			}
			else nativeInTextEnd = null;

			fixed (ushort* nativeOutBuf = &outBuf)
			{
				var result = ImGuiNative.ImTextStrFromUtf8(nativeOutBuf, outBufSize, nativeInText, nativeInTextEnd, inRemaining);
				// Freeing inText native string
				if (byteCountInText > Utils.MaxStackallocSize)
					Utils.Free(nativeInText);
				// Freeing inTextEnd native string
				if (byteCountInTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeInTextEnd);
				return result;
			}
		}

		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		public static int ImTextCountCharsFromUtf8(ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* nativeInText;
			var byteCountInText = 0;
			if (inText != null && !inText.IsEmpty)
			{
				byteCountInText = Encoding.UTF8.GetByteCount(inText);
				if(byteCountInText > Utils.MaxStackallocSize)
				{
					nativeInText = Utils.Alloc<byte>(byteCountInText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInText + 1];
					nativeInText = stackallocBytes;
				}
				var offsetInText = Utils.EncodeStringUTF8(inText, nativeInText, byteCountInText);
				nativeInText[offsetInText] = 0;
			}
			else nativeInText = null;

			// Marshaling inTextEnd to native string
			byte* nativeInTextEnd;
			var byteCountInTextEnd = 0;
			if (inTextEnd != null && !inTextEnd.IsEmpty)
			{
				byteCountInTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCountInTextEnd > Utils.MaxStackallocSize)
				{
					nativeInTextEnd = Utils.Alloc<byte>(byteCountInTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextEnd + 1];
					nativeInTextEnd = stackallocBytes;
				}
				var offsetInTextEnd = Utils.EncodeStringUTF8(inTextEnd, nativeInTextEnd, byteCountInTextEnd);
				nativeInTextEnd[offsetInTextEnd] = 0;
			}
			else nativeInTextEnd = null;

			var result = ImGuiNative.ImTextCountCharsFromUtf8(nativeInText, nativeInTextEnd);
			// Freeing inText native string
			if (byteCountInText > Utils.MaxStackallocSize)
				Utils.Free(nativeInText);
			// Freeing inTextEnd native string
			if (byteCountInTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeInTextEnd);
			return result;
		}

		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		public static int ImTextCountUtf8BytesFromChar(ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* nativeInText;
			var byteCountInText = 0;
			if (inText != null && !inText.IsEmpty)
			{
				byteCountInText = Encoding.UTF8.GetByteCount(inText);
				if(byteCountInText > Utils.MaxStackallocSize)
				{
					nativeInText = Utils.Alloc<byte>(byteCountInText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInText + 1];
					nativeInText = stackallocBytes;
				}
				var offsetInText = Utils.EncodeStringUTF8(inText, nativeInText, byteCountInText);
				nativeInText[offsetInText] = 0;
			}
			else nativeInText = null;

			// Marshaling inTextEnd to native string
			byte* nativeInTextEnd;
			var byteCountInTextEnd = 0;
			if (inTextEnd != null && !inTextEnd.IsEmpty)
			{
				byteCountInTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCountInTextEnd > Utils.MaxStackallocSize)
				{
					nativeInTextEnd = Utils.Alloc<byte>(byteCountInTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextEnd + 1];
					nativeInTextEnd = stackallocBytes;
				}
				var offsetInTextEnd = Utils.EncodeStringUTF8(inTextEnd, nativeInTextEnd, byteCountInTextEnd);
				nativeInTextEnd[offsetInTextEnd] = 0;
			}
			else nativeInTextEnd = null;

			var result = ImGuiNative.ImTextCountUtf8BytesFromChar(nativeInText, nativeInTextEnd);
			// Freeing inText native string
			if (byteCountInText > Utils.MaxStackallocSize)
				Utils.Free(nativeInText);
			// Freeing inTextEnd native string
			if (byteCountInTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeInTextEnd);
			return result;
		}

		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		public static string ImTextFindPreviousUtf8Codepoint(ReadOnlySpan<char> inTextStart, ReadOnlySpan<char> inTextCurr)
		{
			// Marshaling inTextStart to native string
			byte* nativeInTextStart;
			var byteCountInTextStart = 0;
			if (inTextStart != null && !inTextStart.IsEmpty)
			{
				byteCountInTextStart = Encoding.UTF8.GetByteCount(inTextStart);
				if(byteCountInTextStart > Utils.MaxStackallocSize)
				{
					nativeInTextStart = Utils.Alloc<byte>(byteCountInTextStart + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextStart + 1];
					nativeInTextStart = stackallocBytes;
				}
				var offsetInTextStart = Utils.EncodeStringUTF8(inTextStart, nativeInTextStart, byteCountInTextStart);
				nativeInTextStart[offsetInTextStart] = 0;
			}
			else nativeInTextStart = null;

			// Marshaling inTextCurr to native string
			byte* nativeInTextCurr;
			var byteCountInTextCurr = 0;
			if (inTextCurr != null && !inTextCurr.IsEmpty)
			{
				byteCountInTextCurr = Encoding.UTF8.GetByteCount(inTextCurr);
				if(byteCountInTextCurr > Utils.MaxStackallocSize)
				{
					nativeInTextCurr = Utils.Alloc<byte>(byteCountInTextCurr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextCurr + 1];
					nativeInTextCurr = stackallocBytes;
				}
				var offsetInTextCurr = Utils.EncodeStringUTF8(inTextCurr, nativeInTextCurr, byteCountInTextCurr);
				nativeInTextCurr[offsetInTextCurr] = 0;
			}
			else nativeInTextCurr = null;

			var result = ImGuiNative.ImTextFindPreviousUtf8Codepoint(nativeInTextStart, nativeInTextCurr);
			// Freeing inTextStart native string
			if (byteCountInTextStart > Utils.MaxStackallocSize)
				Utils.Free(nativeInTextStart);
			// Freeing inTextCurr native string
			if (byteCountInTextCurr > Utils.MaxStackallocSize)
				Utils.Free(nativeInTextCurr);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		public static int ImTextCountLines(ReadOnlySpan<char> inText, ReadOnlySpan<char> inTextEnd)
		{
			// Marshaling inText to native string
			byte* nativeInText;
			var byteCountInText = 0;
			if (inText != null && !inText.IsEmpty)
			{
				byteCountInText = Encoding.UTF8.GetByteCount(inText);
				if(byteCountInText > Utils.MaxStackallocSize)
				{
					nativeInText = Utils.Alloc<byte>(byteCountInText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInText + 1];
					nativeInText = stackallocBytes;
				}
				var offsetInText = Utils.EncodeStringUTF8(inText, nativeInText, byteCountInText);
				nativeInText[offsetInText] = 0;
			}
			else nativeInText = null;

			// Marshaling inTextEnd to native string
			byte* nativeInTextEnd;
			var byteCountInTextEnd = 0;
			if (inTextEnd != null && !inTextEnd.IsEmpty)
			{
				byteCountInTextEnd = Encoding.UTF8.GetByteCount(inTextEnd);
				if(byteCountInTextEnd > Utils.MaxStackallocSize)
				{
					nativeInTextEnd = Utils.Alloc<byte>(byteCountInTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInTextEnd + 1];
					nativeInTextEnd = stackallocBytes;
				}
				var offsetInTextEnd = Utils.EncodeStringUTF8(inTextEnd, nativeInTextEnd, byteCountInTextEnd);
				nativeInTextEnd[offsetInTextEnd] = 0;
			}
			else nativeInTextEnd = null;

			var result = ImGuiNative.ImTextCountLines(nativeInText, nativeInTextEnd);
			// Freeing inText native string
			if (byteCountInText > Utils.MaxStackallocSize)
				Utils.Free(nativeInText);
			// Freeing inTextEnd native string
			if (byteCountInTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeInTextEnd);
			return result;
		}

		public static IntPtr ImFileOpen(ReadOnlySpan<char> filename, ReadOnlySpan<char> mode)
		{
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			// Marshaling mode to native string
			byte* nativeMode;
			var byteCountMode = 0;
			if (mode != null && !mode.IsEmpty)
			{
				byteCountMode = Encoding.UTF8.GetByteCount(mode);
				if(byteCountMode > Utils.MaxStackallocSize)
				{
					nativeMode = Utils.Alloc<byte>(byteCountMode + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountMode + 1];
					nativeMode = stackallocBytes;
				}
				var offsetMode = Utils.EncodeStringUTF8(mode, nativeMode, byteCountMode);
				nativeMode[offsetMode] = 0;
			}
			else nativeMode = null;

			var result = (IntPtr)ImGuiNative.ImFileOpen(nativeFilename, nativeMode);
			// Freeing filename native string
			if (byteCountFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeFilename);
			// Freeing mode native string
			if (byteCountMode > Utils.MaxStackallocSize)
				Utils.Free(nativeMode);
			return result;
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<char> filename, ReadOnlySpan<char> mode, out uint outFileSize, int paddingBytes)
		{
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			// Marshaling mode to native string
			byte* nativeMode;
			var byteCountMode = 0;
			if (mode != null && !mode.IsEmpty)
			{
				byteCountMode = Encoding.UTF8.GetByteCount(mode);
				if(byteCountMode > Utils.MaxStackallocSize)
				{
					nativeMode = Utils.Alloc<byte>(byteCountMode + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountMode + 1];
					nativeMode = stackallocBytes;
				}
				var offsetMode = Utils.EncodeStringUTF8(mode, nativeMode, byteCountMode);
				nativeMode[offsetMode] = 0;
			}
			else nativeMode = null;

			fixed (uint* nativeOutFileSize = &outFileSize)
			{
				var result = (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, nativeOutFileSize, paddingBytes);
				// Freeing filename native string
				if (byteCountFilename > Utils.MaxStackallocSize)
					Utils.Free(nativeFilename);
				// Freeing mode native string
				if (byteCountMode > Utils.MaxStackallocSize)
					Utils.Free(nativeMode);
				return result;
			}
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<byte> filename, ReadOnlySpan<byte> mode, out uint outFileSize)
		{
			// defining omitted parameters
			int paddingBytes = 0;
			fixed (byte* nativeFilename = filename)
			fixed (byte* nativeMode = mode)
			fixed (uint* nativeOutFileSize = &outFileSize)
			{
				return (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, nativeOutFileSize, paddingBytes);
			}
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<char> filename, ReadOnlySpan<char> mode, out uint outFileSize)
		{
			// defining omitted parameters
			int paddingBytes = 0;
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			// Marshaling mode to native string
			byte* nativeMode;
			var byteCountMode = 0;
			if (mode != null && !mode.IsEmpty)
			{
				byteCountMode = Encoding.UTF8.GetByteCount(mode);
				if(byteCountMode > Utils.MaxStackallocSize)
				{
					nativeMode = Utils.Alloc<byte>(byteCountMode + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountMode + 1];
					nativeMode = stackallocBytes;
				}
				var offsetMode = Utils.EncodeStringUTF8(mode, nativeMode, byteCountMode);
				nativeMode[offsetMode] = 0;
			}
			else nativeMode = null;

			fixed (uint* nativeOutFileSize = &outFileSize)
			{
				var result = (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, nativeOutFileSize, paddingBytes);
				// Freeing filename native string
				if (byteCountFilename > Utils.MaxStackallocSize)
					Utils.Free(nativeFilename);
				// Freeing mode native string
				if (byteCountMode > Utils.MaxStackallocSize)
					Utils.Free(nativeMode);
				return result;
			}
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<byte> filename, ReadOnlySpan<byte> mode)
		{
			// defining omitted parameters
			int paddingBytes = 0;
			uint* outFileSize = null;
			fixed (byte* nativeFilename = filename)
			fixed (byte* nativeMode = mode)
			{
				return (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, outFileSize, paddingBytes);
			}
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<char> filename, ReadOnlySpan<char> mode)
		{
			// defining omitted parameters
			int paddingBytes = 0;
			uint* outFileSize = null;
			// Marshaling filename to native string
			byte* nativeFilename;
			var byteCountFilename = 0;
			if (filename != null && !filename.IsEmpty)
			{
				byteCountFilename = Encoding.UTF8.GetByteCount(filename);
				if(byteCountFilename > Utils.MaxStackallocSize)
				{
					nativeFilename = Utils.Alloc<byte>(byteCountFilename + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFilename + 1];
					nativeFilename = stackallocBytes;
				}
				var offsetFilename = Utils.EncodeStringUTF8(filename, nativeFilename, byteCountFilename);
				nativeFilename[offsetFilename] = 0;
			}
			else nativeFilename = null;

			// Marshaling mode to native string
			byte* nativeMode;
			var byteCountMode = 0;
			if (mode != null && !mode.IsEmpty)
			{
				byteCountMode = Encoding.UTF8.GetByteCount(mode);
				if(byteCountMode > Utils.MaxStackallocSize)
				{
					nativeMode = Utils.Alloc<byte>(byteCountMode + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountMode + 1];
					nativeMode = stackallocBytes;
				}
				var offsetMode = Utils.EncodeStringUTF8(mode, nativeMode, byteCountMode);
				nativeMode[offsetMode] = 0;
			}
			else nativeMode = null;

			var result = (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, outFileSize, paddingBytes);
			// Freeing filename native string
			if (byteCountFilename > Utils.MaxStackallocSize)
				Utils.Free(nativeFilename);
			// Freeing mode native string
			if (byteCountMode > Utils.MaxStackallocSize)
				Utils.Free(nativeMode);
			return result;
		}

		public static float ImPowFloat(float x, float y)
		{
			return ImGuiNative.ImPowFloat(x, y);
		}

		public static double ImPowDouble(double x, double y)
		{
			return ImGuiNative.ImPowDouble(x, y);
		}

		public static float ImLogFloat(float x)
		{
			return ImGuiNative.ImLogFloat(x);
		}

		public static double ImLogDouble(double x)
		{
			return ImGuiNative.ImLogDouble(x);
		}

		public static int ImAbsInt(int x)
		{
			return ImGuiNative.ImAbsInt(x);
		}

		public static float ImAbsFloat(float x)
		{
			return ImGuiNative.ImAbsFloat(x);
		}

		public static double ImAbsDouble(double x)
		{
			return ImGuiNative.ImAbsDouble(x);
		}

		public static float ImSnFloat(float x)
		{
			return ImGuiNative.ImSnFloat(x);
		}

		public static double ImSnDouble(double x)
		{
			return ImGuiNative.ImSnDouble(x);
		}

		public static float ImRsqrtFloat(float x)
		{
			return ImGuiNative.ImRsqrtFloat(x);
		}

		public static double ImRsqrtDouble(double x)
		{
			return ImGuiNative.ImRsqrtDouble(x);
		}

		public static void ImLerp(out Vector2 pOut, Vector2 a, Vector2 b, float t)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImLerp(nativePOut, a, b, t);
			}
		}

		public static void ImLerp(out Vector2 pOut, Vector2 a, Vector2 b, Vector2 t)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImLerp(nativePOut, a, b, t);
			}
		}

		public static void ImLerp(out Vector4 pOut, Vector4 a, Vector4 b, float t)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImGuiNative.ImLerp(nativePOut, a, b, t);
			}
		}

		public static float ImLengthSqr(Vector2 lhs)
		{
			return ImGuiNative.ImLengthSqr(lhs);
		}

		public static float ImLengthSqr(Vector4 lhs)
		{
			return ImGuiNative.ImLengthSqr(lhs);
		}

		public static float ImTruncFloat(float f)
		{
			return ImGuiNative.ImTruncFloat(f);
		}

		public static void ImTruncVec2(out Vector2 pOut, Vector2 v)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImTruncVec2(nativePOut, v);
			}
		}

		public static float ImFloorFloat(float f)
		{
			return ImGuiNative.ImFloorFloat(f);
		}

		public static void ImFloorVec2(out Vector2 pOut, Vector2 v)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImFloorVec2(nativePOut, v);
			}
		}

		public static ImVec2IhPtr ImVec2IhImVec2Ih()
		{
			return ImGuiNative.ImVec2IhImVec2Ih();
		}

		public static void ImVec2IhImVec2IhNilConstruct(ImVec2IhPtr self)
		{
			ImGuiNative.ImVec2IhImVec2IhNilConstruct(self);
		}

		public static ImVec2IhPtr ImVec2IhImVec2IhShort(short x, short y)
		{
			return ImGuiNative.ImVec2IhImVec2IhShort(x, y);
		}

		public static void ImVec2IhImVec2IhShortConstruct(ImVec2IhPtr self, short x, short y)
		{
			ImGuiNative.ImVec2IhImVec2IhShortConstruct(self, x, y);
		}

		public static ImVec2IhPtr ImVec2IhImVec2Ih(Vector2 rhs)
		{
			return ImGuiNative.ImVec2IhImVec2Ih(rhs);
		}

		public static void ImVec2IhImVec2IhVec2Construct(ImVec2IhPtr self, Vector2 rhs)
		{
			ImGuiNative.ImVec2IhImVec2IhVec2Construct(self, rhs);
		}

		public static void ImGuiIdStackToolImGuiIdStackToolConstruct(ImGuiIdStackToolPtr self)
		{
			ImGuiNative.ImGuiIdStackToolImGuiIdStackToolConstruct(self);
		}

		public static ImGuiIOPtr GetIoEx(ImGuiContextPtr ctx)
		{
			return ImGuiNative.GetIoEx(ctx);
		}

		public static ImGuiPlatformIOPtr GetPlatformIO(ImGuiContextPtr ctx)
		{
			return ImGuiNative.GetPlatformIO(ctx);
		}

		public static ImGuiWindowPtr FindWindowByName(ReadOnlySpan<char> name)
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

			var result = ImGuiNative.FindWindowByName(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result;
		}

		public static void SetWindowPos(ImGuiWindowPtr window, Vector2 pos, ImGuiCond cond)
		{
			ImGuiNative.SetWindowPos(window, pos, cond);
		}

		public static void SetWindowSize(ImGuiWindowPtr window, Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.SetWindowSize(window, size, cond);
		}

		public static void SetWindowCollapsed(ImGuiWindowPtr window, bool collapsed, ImGuiCond cond)
		{
			var native_collapsed = collapsed ? (byte)1 : (byte)0;
			ImGuiNative.SetWindowCollapsed(window, native_collapsed, cond);
		}

		public static void FocusWindow(ImGuiWindowPtr window)
		{
			// defining omitted parameters
			ImGuiFocusRequestFlags flags = ImGuiFocusRequestFlags.None;
			ImGuiNative.FocusWindow(window, flags);
		}

		public static ImDrawListPtr GetForegroundDrawList(ImGuiWindowPtr window)
		{
			return ImGuiNative.GetForegroundDrawList(window);
		}

		public static void MarkIniSettingsDirty()
		{
			ImGuiNative.MarkIniSettingsDirty();
		}

		public static void MarkIniSettingsDirty(ImGuiWindowPtr window)
		{
			ImGuiNative.MarkIniSettingsDirty(window);
		}

		public static void RemoveSettingsHandler(ReadOnlySpan<char> typeName)
		{
			// Marshaling typeName to native string
			byte* nativeTypeName;
			var byteCountTypeName = 0;
			if (typeName != null && !typeName.IsEmpty)
			{
				byteCountTypeName = Encoding.UTF8.GetByteCount(typeName);
				if(byteCountTypeName > Utils.MaxStackallocSize)
				{
					nativeTypeName = Utils.Alloc<byte>(byteCountTypeName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTypeName + 1];
					nativeTypeName = stackallocBytes;
				}
				var offsetTypeName = Utils.EncodeStringUTF8(typeName, nativeTypeName, byteCountTypeName);
				nativeTypeName[offsetTypeName] = 0;
			}
			else nativeTypeName = null;

			ImGuiNative.RemoveSettingsHandler(nativeTypeName);
			// Freeing typeName native string
			if (byteCountTypeName > Utils.MaxStackallocSize)
				Utils.Free(nativeTypeName);
		}

		public static ImGuiSettingsHandlerPtr FindSettingsHandler(ReadOnlySpan<char> typeName)
		{
			// Marshaling typeName to native string
			byte* nativeTypeName;
			var byteCountTypeName = 0;
			if (typeName != null && !typeName.IsEmpty)
			{
				byteCountTypeName = Encoding.UTF8.GetByteCount(typeName);
				if(byteCountTypeName > Utils.MaxStackallocSize)
				{
					nativeTypeName = Utils.Alloc<byte>(byteCountTypeName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTypeName + 1];
					nativeTypeName = stackallocBytes;
				}
				var offsetTypeName = Utils.EncodeStringUTF8(typeName, nativeTypeName, byteCountTypeName);
				nativeTypeName[offsetTypeName] = 0;
			}
			else nativeTypeName = null;

			var result = ImGuiNative.FindSettingsHandler(nativeTypeName);
			// Freeing typeName native string
			if (byteCountTypeName > Utils.MaxStackallocSize)
				Utils.Free(nativeTypeName);
			return result;
		}

		public static ImGuiWindowSettingsPtr CreateNewWindowSettings(ReadOnlySpan<char> name)
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

			var result = ImGuiNative.CreateNewWindowSettings(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result;
		}

		public static void ClearWindowSettings(ReadOnlySpan<char> name)
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

			ImGuiNative.ClearWindowSettings(nativeName);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
		}

		public static void SetScrollX(ImGuiWindowPtr window, float scrollX)
		{
			ImGuiNative.SetScrollX(window, scrollX);
		}

		public static void SetScrollY(ImGuiWindowPtr window, float scrollY)
		{
			ImGuiNative.SetScrollY(window, scrollY);
		}

		public static void SetScrollFromPosX(ImGuiWindowPtr window, float localX, float centerXRatio)
		{
			ImGuiNative.SetScrollFromPosX(window, localX, centerXRatio);
		}

		public static void SetScrollFromPosY(ImGuiWindowPtr window, float localY, float centerYRatio)
		{
			ImGuiNative.SetScrollFromPosY(window, localY, centerYRatio);
		}

		public static void ScrollToItem()
		{
			// defining omitted parameters
			ImGuiScrollFlags flags = ImGuiScrollFlags.None;
			ImGuiNative.ScrollToItem(flags);
		}

		public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect)
		{
			// defining omitted parameters
			ImGuiScrollFlags flags = ImGuiScrollFlags.None;
			ImGuiNative.ScrollToRect(window, rect, flags);
		}

		public static void ScrollToRectEx(out Vector2 pOut, ImGuiWindowPtr window, ImRect rect)
		{
			// defining omitted parameters
			ImGuiScrollFlags flags = ImGuiScrollFlags.None;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ScrollToRectEx(nativePOut, window, rect, flags);
			}
		}

		public static uint GetIdWithSeed(ReadOnlySpan<byte> strIdBegin, ReadOnlySpan<byte> strIdEnd, uint seed)
		{
			fixed (byte* nativeStrIdBegin = strIdBegin)
			fixed (byte* nativeStrIdEnd = strIdEnd)
			{
				return ImGuiNative.GetIdWithSeed(nativeStrIdBegin, nativeStrIdEnd, seed);
			}
		}

		public static uint GetIdWithSeed(ReadOnlySpan<char> strIdBegin, ReadOnlySpan<char> strIdEnd, uint seed)
		{
			// Marshaling strIdBegin to native string
			byte* nativeStrIdBegin;
			var byteCountStrIdBegin = 0;
			if (strIdBegin != null && !strIdBegin.IsEmpty)
			{
				byteCountStrIdBegin = Encoding.UTF8.GetByteCount(strIdBegin);
				if(byteCountStrIdBegin > Utils.MaxStackallocSize)
				{
					nativeStrIdBegin = Utils.Alloc<byte>(byteCountStrIdBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdBegin + 1];
					nativeStrIdBegin = stackallocBytes;
				}
				var offsetStrIdBegin = Utils.EncodeStringUTF8(strIdBegin, nativeStrIdBegin, byteCountStrIdBegin);
				nativeStrIdBegin[offsetStrIdBegin] = 0;
			}
			else nativeStrIdBegin = null;

			// Marshaling strIdEnd to native string
			byte* nativeStrIdEnd;
			var byteCountStrIdEnd = 0;
			if (strIdEnd != null && !strIdEnd.IsEmpty)
			{
				byteCountStrIdEnd = Encoding.UTF8.GetByteCount(strIdEnd);
				if(byteCountStrIdEnd > Utils.MaxStackallocSize)
				{
					nativeStrIdEnd = Utils.Alloc<byte>(byteCountStrIdEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrIdEnd + 1];
					nativeStrIdEnd = stackallocBytes;
				}
				var offsetStrIdEnd = Utils.EncodeStringUTF8(strIdEnd, nativeStrIdEnd, byteCountStrIdEnd);
				nativeStrIdEnd[offsetStrIdEnd] = 0;
			}
			else nativeStrIdEnd = null;

			var result = ImGuiNative.GetIdWithSeed(nativeStrIdBegin, nativeStrIdEnd, seed);
			// Freeing strIdBegin native string
			if (byteCountStrIdBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdBegin);
			// Freeing strIdEnd native string
			if (byteCountStrIdEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrIdEnd);
			return result;
		}

		public static uint GetIdWithSeed(int n, uint seed)
		{
			return ImGuiNative.GetIdWithSeed(n, seed);
		}

		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.<br/>
		/// </summary>
		public static void ItemSize(Vector2 size, float textBaselineY)
		{
			ImGuiNative.ItemSize(size, textBaselineY);
		}

		public static void ItemSize(ImRect bb, float textBaselineY)
		{
			ImGuiNative.ItemSize(bb, textBaselineY);
		}

		public static bool ItemAdd(ImRect bb, uint id, ImRectPtr navBb)
		{
			// defining omitted parameters
			ImGuiItemFlags extraFlags = ImGuiItemFlags.None;
			var result = ImGuiNative.ItemAdd(bb, id, navBb, extraFlags);
			return result != 0;
		}

		public static bool ItemAdd(ImRect bb, uint id)
		{
			// defining omitted parameters
			ImGuiItemFlags extraFlags = ImGuiItemFlags.None;
			ImRect* navBb = null;
			var result = ImGuiNative.ItemAdd(bb, id, navBb, extraFlags);
			return result != 0;
		}

		public static bool IsWindowContentHoverable(ImGuiWindowPtr window)
		{
			// defining omitted parameters
			ImGuiHoveredFlags flags = ImGuiHoveredFlags.None;
			var result = ImGuiNative.IsWindowContentHoverable(window, flags);
			return result != 0;
		}

		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		public static void LogToBuffer()
		{
			// defining omitted parameters
			int autoOpenDepth = -1;
			ImGuiNative.LogToBuffer(autoOpenDepth);
		}

		public static void LogRenderedText(Vector2[] refPos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeRefPos = refPos)
			{
				ImGuiNative.LogRenderedText(nativeRefPos, nativeText, nativeTextEnd);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void LogRenderedText(Vector2[] refPos, ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (Vector2* nativeRefPos = refPos)
			fixed (byte* nativeText = text)
			{
				ImGuiNative.LogRenderedText(nativeRefPos, nativeText, textEnd);
			}
		}

		public static void LogRenderedText(Vector2[] refPos, ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			fixed (Vector2* nativeRefPos = refPos)
			{
				ImGuiNative.LogRenderedText(nativeRefPos, nativeText, textEnd);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
			}
		}

		public static void LogSetNextTextDecoration(ReadOnlySpan<char> prefix, ReadOnlySpan<char> suffix)
		{
			// Marshaling prefix to native string
			byte* nativePrefix;
			var byteCountPrefix = 0;
			if (prefix != null && !prefix.IsEmpty)
			{
				byteCountPrefix = Encoding.UTF8.GetByteCount(prefix);
				if(byteCountPrefix > Utils.MaxStackallocSize)
				{
					nativePrefix = Utils.Alloc<byte>(byteCountPrefix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountPrefix + 1];
					nativePrefix = stackallocBytes;
				}
				var offsetPrefix = Utils.EncodeStringUTF8(prefix, nativePrefix, byteCountPrefix);
				nativePrefix[offsetPrefix] = 0;
			}
			else nativePrefix = null;

			// Marshaling suffix to native string
			byte* nativeSuffix;
			var byteCountSuffix = 0;
			if (suffix != null && !suffix.IsEmpty)
			{
				byteCountSuffix = Encoding.UTF8.GetByteCount(suffix);
				if(byteCountSuffix > Utils.MaxStackallocSize)
				{
					nativeSuffix = Utils.Alloc<byte>(byteCountSuffix + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountSuffix + 1];
					nativeSuffix = stackallocBytes;
				}
				var offsetSuffix = Utils.EncodeStringUTF8(suffix, nativeSuffix, byteCountSuffix);
				nativeSuffix[offsetSuffix] = 0;
			}
			else nativeSuffix = null;

			ImGuiNative.LogSetNextTextDecoration(nativePrefix, nativeSuffix);
			// Freeing prefix native string
			if (byteCountPrefix > Utils.MaxStackallocSize)
				Utils.Free(nativePrefix);
			// Freeing suffix native string
			if (byteCountSuffix > Utils.MaxStackallocSize)
				Utils.Free(nativeSuffix);
		}

		public static bool BeginChildEx(ReadOnlySpan<char> name, uint id, Vector2 sizeArg, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
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

			var result = ImGuiNative.BeginChildEx(nativeName, id, sizeArg, childFlags, windowFlags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static bool BeginPopupMenuEx(uint id, ReadOnlySpan<char> label, ImGuiWindowFlags extraWindowFlags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.BeginPopupMenuEx(id, nativeLabel, extraWindowFlags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static void OpenPopupEx(uint id)
		{
			// defining omitted parameters
			ImGuiPopupFlags popupFlags = ImGuiPopupFlags.None;
			ImGuiNative.OpenPopupEx(id, popupFlags);
		}

		public static bool IsPopupOpen(uint id, ImGuiPopupFlags popupFlags)
		{
			var result = ImGuiNative.IsPopupOpen(id, popupFlags);
			return result != 0;
		}

		public static bool BeginViewportSideBar(ReadOnlySpan<char> name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags windowFlags)
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

			var result = ImGuiNative.BeginViewportSideBar(nativeName, viewport, dir, size, windowFlags);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static bool BeginMenuEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, bool enabled)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling icon to native string
			byte* nativeIcon;
			var byteCountIcon = 0;
			if (icon != null && !icon.IsEmpty)
			{
				byteCountIcon = Encoding.UTF8.GetByteCount(icon);
				if(byteCountIcon > Utils.MaxStackallocSize)
				{
					nativeIcon = Utils.Alloc<byte>(byteCountIcon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIcon + 1];
					nativeIcon = stackallocBytes;
				}
				var offsetIcon = Utils.EncodeStringUTF8(icon, nativeIcon, byteCountIcon);
				nativeIcon[offsetIcon] = 0;
			}
			else nativeIcon = null;

			var native_enabled = enabled ? (byte)1 : (byte)0;
			var result = ImGuiNative.BeginMenuEx(nativeLabel, nativeIcon, native_enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing icon native string
			if (byteCountIcon > Utils.MaxStackallocSize)
				Utils.Free(nativeIcon);
			return result != 0;
		}

		public static bool BeginMenuEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon)
		{
			// defining omitted parameters
			byte enabled = 1;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			{
				var result = ImGuiNative.BeginMenuEx(nativeLabel, nativeIcon, enabled);
				return result != 0;
			}
		}

		public static bool BeginMenuEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon)
		{
			// defining omitted parameters
			byte enabled = 1;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling icon to native string
			byte* nativeIcon;
			var byteCountIcon = 0;
			if (icon != null && !icon.IsEmpty)
			{
				byteCountIcon = Encoding.UTF8.GetByteCount(icon);
				if(byteCountIcon > Utils.MaxStackallocSize)
				{
					nativeIcon = Utils.Alloc<byte>(byteCountIcon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIcon + 1];
					nativeIcon = stackallocBytes;
				}
				var offsetIcon = Utils.EncodeStringUTF8(icon, nativeIcon, byteCountIcon);
				nativeIcon[offsetIcon] = 0;
			}
			else nativeIcon = null;

			var result = ImGuiNative.BeginMenuEx(nativeLabel, nativeIcon, enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing icon native string
			if (byteCountIcon > Utils.MaxStackallocSize)
				Utils.Free(nativeIcon);
			return result != 0;
		}

		public static bool MenuItemEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling icon to native string
			byte* nativeIcon;
			var byteCountIcon = 0;
			if (icon != null && !icon.IsEmpty)
			{
				byteCountIcon = Encoding.UTF8.GetByteCount(icon);
				if(byteCountIcon > Utils.MaxStackallocSize)
				{
					nativeIcon = Utils.Alloc<byte>(byteCountIcon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIcon + 1];
					nativeIcon = stackallocBytes;
				}
				var offsetIcon = Utils.EncodeStringUTF8(icon, nativeIcon, byteCountIcon);
				nativeIcon[offsetIcon] = 0;
			}
			else nativeIcon = null;

			// Marshaling shortcut to native string
			byte* nativeShortcut;
			var byteCountShortcut = 0;
			if (shortcut != null && !shortcut.IsEmpty)
			{
				byteCountShortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCountShortcut > Utils.MaxStackallocSize)
				{
					nativeShortcut = Utils.Alloc<byte>(byteCountShortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountShortcut + 1];
					nativeShortcut = stackallocBytes;
				}
				var offsetShortcut = Utils.EncodeStringUTF8(shortcut, nativeShortcut, byteCountShortcut);
				nativeShortcut[offsetShortcut] = 0;
			}
			else nativeShortcut = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, native_selected, native_enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing icon native string
			if (byteCountIcon > Utils.MaxStackallocSize)
				Utils.Free(nativeIcon);
			// Freeing shortcut native string
			if (byteCountShortcut > Utils.MaxStackallocSize)
				Utils.Free(nativeShortcut);
			return result != 0;
		}

		public static bool MenuItemEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon, ReadOnlySpan<byte> shortcut, bool selected)
		{
			// defining omitted parameters
			byte enabled = 1;
			var native_selected = selected ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			fixed (byte* nativeShortcut = shortcut)
			{
				var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, native_selected, enabled);
				return result != 0;
			}
		}

		public static bool MenuItemEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut, bool selected)
		{
			// defining omitted parameters
			byte enabled = 1;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling icon to native string
			byte* nativeIcon;
			var byteCountIcon = 0;
			if (icon != null && !icon.IsEmpty)
			{
				byteCountIcon = Encoding.UTF8.GetByteCount(icon);
				if(byteCountIcon > Utils.MaxStackallocSize)
				{
					nativeIcon = Utils.Alloc<byte>(byteCountIcon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIcon + 1];
					nativeIcon = stackallocBytes;
				}
				var offsetIcon = Utils.EncodeStringUTF8(icon, nativeIcon, byteCountIcon);
				nativeIcon[offsetIcon] = 0;
			}
			else nativeIcon = null;

			// Marshaling shortcut to native string
			byte* nativeShortcut;
			var byteCountShortcut = 0;
			if (shortcut != null && !shortcut.IsEmpty)
			{
				byteCountShortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCountShortcut > Utils.MaxStackallocSize)
				{
					nativeShortcut = Utils.Alloc<byte>(byteCountShortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountShortcut + 1];
					nativeShortcut = stackallocBytes;
				}
				var offsetShortcut = Utils.EncodeStringUTF8(shortcut, nativeShortcut, byteCountShortcut);
				nativeShortcut[offsetShortcut] = 0;
			}
			else nativeShortcut = null;

			var native_selected = selected ? (byte)1 : (byte)0;
			var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, native_selected, enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing icon native string
			if (byteCountIcon > Utils.MaxStackallocSize)
				Utils.Free(nativeIcon);
			// Freeing shortcut native string
			if (byteCountShortcut > Utils.MaxStackallocSize)
				Utils.Free(nativeShortcut);
			return result != 0;
		}

		public static bool MenuItemEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon, ReadOnlySpan<byte> shortcut)
		{
			// defining omitted parameters
			byte enabled = 1;
			byte selected = 0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			fixed (byte* nativeShortcut = shortcut)
			{
				var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, selected, enabled);
				return result != 0;
			}
		}

		public static bool MenuItemEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut)
		{
			// defining omitted parameters
			byte enabled = 1;
			byte selected = 0;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling icon to native string
			byte* nativeIcon;
			var byteCountIcon = 0;
			if (icon != null && !icon.IsEmpty)
			{
				byteCountIcon = Encoding.UTF8.GetByteCount(icon);
				if(byteCountIcon > Utils.MaxStackallocSize)
				{
					nativeIcon = Utils.Alloc<byte>(byteCountIcon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIcon + 1];
					nativeIcon = stackallocBytes;
				}
				var offsetIcon = Utils.EncodeStringUTF8(icon, nativeIcon, byteCountIcon);
				nativeIcon[offsetIcon] = 0;
			}
			else nativeIcon = null;

			// Marshaling shortcut to native string
			byte* nativeShortcut;
			var byteCountShortcut = 0;
			if (shortcut != null && !shortcut.IsEmpty)
			{
				byteCountShortcut = Encoding.UTF8.GetByteCount(shortcut);
				if(byteCountShortcut > Utils.MaxStackallocSize)
				{
					nativeShortcut = Utils.Alloc<byte>(byteCountShortcut + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountShortcut + 1];
					nativeShortcut = stackallocBytes;
				}
				var offsetShortcut = Utils.EncodeStringUTF8(shortcut, nativeShortcut, byteCountShortcut);
				nativeShortcut[offsetShortcut] = 0;
			}
			else nativeShortcut = null;

			var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, selected, enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing icon native string
			if (byteCountIcon > Utils.MaxStackallocSize)
				Utils.Free(nativeIcon);
			// Freeing shortcut native string
			if (byteCountShortcut > Utils.MaxStackallocSize)
				Utils.Free(nativeShortcut);
			return result != 0;
		}

		public static bool MenuItemEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon)
		{
			// defining omitted parameters
			byte enabled = 1;
			byte selected = 0;
			byte* shortcut = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			{
				var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, shortcut, selected, enabled);
				return result != 0;
			}
		}

		public static bool MenuItemEx(ReadOnlySpan<char> label, ReadOnlySpan<char> icon)
		{
			// defining omitted parameters
			byte enabled = 1;
			byte selected = 0;
			byte* shortcut = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling icon to native string
			byte* nativeIcon;
			var byteCountIcon = 0;
			if (icon != null && !icon.IsEmpty)
			{
				byteCountIcon = Encoding.UTF8.GetByteCount(icon);
				if(byteCountIcon > Utils.MaxStackallocSize)
				{
					nativeIcon = Utils.Alloc<byte>(byteCountIcon + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountIcon + 1];
					nativeIcon = stackallocBytes;
				}
				var offsetIcon = Utils.EncodeStringUTF8(icon, nativeIcon, byteCountIcon);
				nativeIcon[offsetIcon] = 0;
			}
			else nativeIcon = null;

			var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, shortcut, selected, enabled);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing icon native string
			if (byteCountIcon > Utils.MaxStackallocSize)
				Utils.Free(nativeIcon);
			return result != 0;
		}

		public static ImGuiKeyDataPtr GetKeyData(ImGuiContextPtr ctx, ImGuiKey key)
		{
			return ImGuiNative.GetKeyData(ctx, key);
		}

		public static ImGuiKeyDataPtr GetKeyData(ImGuiKey key)
		{
			return ImGuiNative.GetKeyData(key);
		}

		public static bool IsMouseDragPastThreshold(ImGuiMouseButton button)
		{
			// defining omitted parameters
			float lockThreshold = -1.0f;
			var result = ImGuiNative.IsMouseDragPastThreshold(button, lockThreshold);
			return result != 0;
		}

		public static void SetKeyOwner(ImGuiKey key, uint ownerId)
		{
			// defining omitted parameters
			ImGuiInputFlags flags = ImGuiInputFlags.None;
			ImGuiNative.SetKeyOwner(key, ownerId, flags);
		}

		public static void SetKeyOwnersForKeyChord(int key, uint ownerId)
		{
			// defining omitted parameters
			ImGuiInputFlags flags = ImGuiInputFlags.None;
			ImGuiNative.SetKeyOwnersForKeyChord(key, ownerId, flags);
		}

		public static void SetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags)
		{
			ImGuiNative.SetItemKeyOwner(key, flags);
		}

		public static bool IsKeyDown(ImGuiKey key, uint ownerId)
		{
			var result = ImGuiNative.IsKeyDown(key, ownerId);
			return result != 0;
		}

		public static bool IsKeyPressed(ImGuiKey key, ImGuiInputFlags flags, uint ownerId)
		{
			var result = ImGuiNative.IsKeyPressed(key, flags, ownerId);
			return result != 0;
		}

		public static bool IsKeyReleased(ImGuiKey key, uint ownerId)
		{
			var result = ImGuiNative.IsKeyReleased(key, ownerId);
			return result != 0;
		}

		public static bool IsKeyChordPressed(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			var result = ImGuiNative.IsKeyChordPressed(keyChord, flags, ownerId);
			return result != 0;
		}

		public static bool IsMouseDown(ImGuiMouseButton button, uint ownerId)
		{
			var result = ImGuiNative.IsMouseDown(button, ownerId);
			return result != 0;
		}

		public static bool IsMouseClicked(ImGuiMouseButton button, ImGuiInputFlags flags, uint ownerId)
		{
			var result = ImGuiNative.IsMouseClicked(button, flags, ownerId);
			return result != 0;
		}

		public static bool IsMouseReleased(ImGuiMouseButton button, uint ownerId)
		{
			var result = ImGuiNative.IsMouseReleased(button, ownerId);
			return result != 0;
		}

		public static bool IsMouseDoubleClicked(ImGuiMouseButton button, uint ownerId)
		{
			var result = ImGuiNative.IsMouseDoubleClicked(button, ownerId);
			return result != 0;
		}

		public static bool Shortcut(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			var result = ImGuiNative.Shortcut(keyChord, flags, ownerId);
			return result != 0;
		}

		public static void DockContextProcessUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window)
		{
			// defining omitted parameters
			byte clearPersistentDockingRef = 1;
			ImGuiNative.DockContextProcessUndockWindow(ctx, window, clearPersistentDockingRef);
		}

		public static void DockBuilderDockWindow(ReadOnlySpan<char> windowName, uint nodeId)
		{
			// Marshaling windowName to native string
			byte* nativeWindowName;
			var byteCountWindowName = 0;
			if (windowName != null && !windowName.IsEmpty)
			{
				byteCountWindowName = Encoding.UTF8.GetByteCount(windowName);
				if(byteCountWindowName > Utils.MaxStackallocSize)
				{
					nativeWindowName = Utils.Alloc<byte>(byteCountWindowName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountWindowName + 1];
					nativeWindowName = stackallocBytes;
				}
				var offsetWindowName = Utils.EncodeStringUTF8(windowName, nativeWindowName, byteCountWindowName);
				nativeWindowName[offsetWindowName] = 0;
			}
			else nativeWindowName = null;

			ImGuiNative.DockBuilderDockWindow(nativeWindowName, nodeId);
			// Freeing windowName native string
			if (byteCountWindowName > Utils.MaxStackallocSize)
				Utils.Free(nativeWindowName);
		}

		public static uint DockBuilderAddNode(uint nodeId)
		{
			// defining omitted parameters
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			return ImGuiNative.DockBuilderAddNode(nodeId, flags);
		}

		public static uint DockBuilderAddNode()
		{
			// defining omitted parameters
			uint nodeId = 0;
			ImGuiDockNodeFlags flags = ImGuiDockNodeFlags.None;
			return ImGuiNative.DockBuilderAddNode(nodeId, flags);
		}

		public static void DockBuilderRemoveNodeDockedWindows(uint nodeId)
		{
			// defining omitted parameters
			byte clearSettingsRefs = 1;
			ImGuiNative.DockBuilderRemoveNodeDockedWindows(nodeId, clearSettingsRefs);
		}

		public static void DockBuilderCopyWindowSettings(ReadOnlySpan<char> srcName, ReadOnlySpan<char> dstName)
		{
			// Marshaling srcName to native string
			byte* nativeSrcName;
			var byteCountSrcName = 0;
			if (srcName != null && !srcName.IsEmpty)
			{
				byteCountSrcName = Encoding.UTF8.GetByteCount(srcName);
				if(byteCountSrcName > Utils.MaxStackallocSize)
				{
					nativeSrcName = Utils.Alloc<byte>(byteCountSrcName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountSrcName + 1];
					nativeSrcName = stackallocBytes;
				}
				var offsetSrcName = Utils.EncodeStringUTF8(srcName, nativeSrcName, byteCountSrcName);
				nativeSrcName[offsetSrcName] = 0;
			}
			else nativeSrcName = null;

			// Marshaling dstName to native string
			byte* nativeDstName;
			var byteCountDstName = 0;
			if (dstName != null && !dstName.IsEmpty)
			{
				byteCountDstName = Encoding.UTF8.GetByteCount(dstName);
				if(byteCountDstName > Utils.MaxStackallocSize)
				{
					nativeDstName = Utils.Alloc<byte>(byteCountDstName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountDstName + 1];
					nativeDstName = stackallocBytes;
				}
				var offsetDstName = Utils.EncodeStringUTF8(dstName, nativeDstName, byteCountDstName);
				nativeDstName[offsetDstName] = 0;
			}
			else nativeDstName = null;

			ImGuiNative.DockBuilderCopyWindowSettings(nativeSrcName, nativeDstName);
			// Freeing srcName native string
			if (byteCountSrcName > Utils.MaxStackallocSize)
				Utils.Free(nativeSrcName);
			// Freeing dstName native string
			if (byteCountDstName > Utils.MaxStackallocSize)
				Utils.Free(nativeDstName);
		}

		public static ImGuiTypingSelectRequestPtr GetTypingSelectRequest()
		{
			// defining omitted parameters
			ImGuiTypingSelectFlags flags = ImGuiTypingSelectFlags.None;
			return ImGuiNative.GetTypingSelectRequest(flags);
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<char> strId, int count, ImGuiOldColumnFlags flags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.BeginColumns(nativeStrId, count, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<byte> strId, int count)
		{
			// defining omitted parameters
			ImGuiOldColumnFlags flags = ImGuiOldColumnFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.BeginColumns(nativeStrId, count, flags);
			}
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<char> strId, int count)
		{
			// defining omitted parameters
			ImGuiOldColumnFlags flags = ImGuiOldColumnFlags.None;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.BeginColumns(nativeStrId, count, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		public static uint GetColumnsID(ReadOnlySpan<char> strId, int count)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.GetColumnsID(nativeStrId, count);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result;
		}

		public static void TableOpenContextMenu()
		{
			// defining omitted parameters
			int columnN = -1;
			ImGuiNative.TableOpenContextMenu(columnN);
		}

		public static bool BeginTableEx(ReadOnlySpan<char> name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
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

			var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static bool BeginTableEx(ReadOnlySpan<byte> name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTableEx(ReadOnlySpan<char> name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
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

			var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static bool BeginTableEx(ReadOnlySpan<byte> name, uint id, int columnsCount, ImGuiTableFlags flags)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0,0);
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTableEx(ReadOnlySpan<char> name, uint id, int columnsCount, ImGuiTableFlags flags)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0,0);
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

			var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static bool BeginTableEx(ReadOnlySpan<byte> name, uint id, int columnsCount)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0,0);
			ImGuiTableFlags flags = ImGuiTableFlags.None;
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTableEx(ReadOnlySpan<char> name, uint id, int columnsCount)
		{
			// defining omitted parameters
			float innerWidth = 0.0f;
			Vector2 outerSize = new Vector2(0,0);
			ImGuiTableFlags flags = ImGuiTableFlags.None;
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

			var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
			// Freeing name native string
			if (byteCountName > Utils.MaxStackallocSize)
				Utils.Free(nativeName);
			return result != 0;
		}

		public static string TableGetColumnName(ImGuiTablePtr table, int columnN)
		{
			var result = ImGuiNative.TableGetColumnName(table, columnN);
			return Utils.DecodeStringUTF8(result);
		}

		public static uint TableGetColumnResizeID(ImGuiTablePtr table, int columnN)
		{
			// defining omitted parameters
			int instanceNo = 0;
			return ImGuiNative.TableGetColumnResizeID(table, columnN, instanceNo);
		}

		public static void TableGcCompactTransientBuffers(ImGuiTablePtr table)
		{
			ImGuiNative.TableGcCompactTransientBuffers(table);
		}

		public static void TableGcCompactTransientBuffers(ImGuiTableTempDataPtr table)
		{
			ImGuiNative.TableGcCompactTransientBuffers(table);
		}

		public static void TabBarQueueFocus(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			ImGuiNative.TabBarQueueFocus(tabBar, tab);
		}

		public static void TabBarQueueFocus(ImGuiTabBarPtr tabBar, ReadOnlySpan<byte> tabName)
		{
			fixed (byte* nativeTabName = tabName)
			{
				ImGuiNative.TabBarQueueFocus(tabBar, nativeTabName);
			}
		}

		public static void TabBarQueueFocus(ImGuiTabBarPtr tabBar, ReadOnlySpan<char> tabName)
		{
			// Marshaling tabName to native string
			byte* nativeTabName;
			var byteCountTabName = 0;
			if (tabName != null && !tabName.IsEmpty)
			{
				byteCountTabName = Encoding.UTF8.GetByteCount(tabName);
				if(byteCountTabName > Utils.MaxStackallocSize)
				{
					nativeTabName = Utils.Alloc<byte>(byteCountTabName + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTabName + 1];
					nativeTabName = stackallocBytes;
				}
				var offsetTabName = Utils.EncodeStringUTF8(tabName, nativeTabName, byteCountTabName);
				nativeTabName[offsetTabName] = 0;
			}
			else nativeTabName = null;

			ImGuiNative.TabBarQueueFocus(tabBar, nativeTabName);
			// Freeing tabName native string
			if (byteCountTabName > Utils.MaxStackallocSize)
				Utils.Free(nativeTabName);
		}

		public static bool TabItemEx(ImGuiTabBarPtr tabBar, ReadOnlySpan<char> label, ref bool pOpen, ImGuiTabItemFlags flags, ImGuiWindowPtr dockedWindow)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			var result = ImGuiNative.TabItemEx(tabBar, nativeLabel, nativePOpen, flags, dockedWindow);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			pOpen = nativePOpenVal != 0;
			return result != 0;
		}

		public static void TabItemSpacing(ReadOnlySpan<char> strId, ImGuiTabItemFlags flags, float width)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			ImGuiNative.TabItemSpacing(nativeStrId, flags, width);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
		}

		public static void TabItemCalcSize(out Vector2 pOut, ReadOnlySpan<byte> label, bool hasCloseButtonOrUnsavedMarker)
		{
			var native_hasCloseButtonOrUnsavedMarker = hasCloseButtonOrUnsavedMarker ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TabItemCalcSize(nativePOut, nativeLabel, native_hasCloseButtonOrUnsavedMarker);
			}
		}

		public static void TabItemCalcSize(out Vector2 pOut, ReadOnlySpan<char> label, bool hasCloseButtonOrUnsavedMarker)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var native_hasCloseButtonOrUnsavedMarker = hasCloseButtonOrUnsavedMarker ? (byte)1 : (byte)0;
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.TabItemCalcSize(nativePOut, nativeLabel, native_hasCloseButtonOrUnsavedMarker);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
			}
		}

		public static void TabItemCalcSize(out Vector2 pOut, ImGuiWindowPtr window)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.TabItemCalcSize(nativePOut, window);
			}
		}

		public static void TabItemLabelAndCloseButton(ImDrawListPtr drawList, ImRect bb, ImGuiTabItemFlags flags, Vector2 framePadding, ReadOnlySpan<char> label, uint tabId, uint closeButtonId, bool isContentsVisible, ref bool outJustClosed, ref bool outTextClipped)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var native_isContentsVisible = isContentsVisible ? (byte)1 : (byte)0;
			var nativeOutJustClosedVal = outJustClosed ? (byte)1 : (byte)0;
			var nativeOutJustClosed = &nativeOutJustClosedVal;
			var nativeOutTextClippedVal = outTextClipped ? (byte)1 : (byte)0;
			var nativeOutTextClipped = &nativeOutTextClippedVal;
			ImGuiNative.TabItemLabelAndCloseButton(drawList, bb, flags, framePadding, nativeLabel, tabId, closeButtonId, native_isContentsVisible, nativeOutJustClosed, nativeOutTextClipped);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			outJustClosed = nativeOutJustClosedVal != 0;
			outTextClipped = nativeOutTextClippedVal != 0;
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, bool hideTextAfterHash)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			var native_hideTextAfterHash = hideTextAfterHash ? (byte)1 : (byte)0;
			ImGuiNative.RenderText(pos, nativeText, nativeTextEnd, native_hideTextAfterHash);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			byte hideTextAfterHash = 1;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.RenderText(pos, nativeText, nativeTextEnd, hideTextAfterHash);
			}
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// defining omitted parameters
			byte hideTextAfterHash = 1;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.RenderText(pos, nativeText, nativeTextEnd, hideTextAfterHash);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte hideTextAfterHash = 1;
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				ImGuiNative.RenderText(pos, nativeText, textEnd, hideTextAfterHash);
			}
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			byte hideTextAfterHash = 1;
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImGuiNative.RenderText(pos, nativeText, textEnd, hideTextAfterHash);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static void RenderTextWrapped(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, float wrapWidth)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.RenderTextWrapped(pos, nativeText, nativeTextEnd, wrapWidth);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown, Vector2 align, ImRectPtr clipRect)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown, Vector2 align)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown, Vector2 align)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			Vector2 align = new Vector2(0,0);
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			Vector2 align = new Vector2(0,0);
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown, Vector2 align, ImRectPtr clipRect)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown, Vector2 align)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown, Vector2 align)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			Vector2 align = new Vector2(0,0);
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown)
		{
			// defining omitted parameters
			ImRect* clipRect = null;
			Vector2 align = new Vector2(0,0);
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderTextEllipsis(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, float clipMaxX, float ellipsisMaxX, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, Vector2[] textSizeIfKnown)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextEllipsis(drawList, posMin, posMax, clipMaxX, ellipsisMaxX, nativeText, nativeTextEnd, nativeTextSizeIfKnown);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public static void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol, bool borders)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			var native_borders = borders ? (byte)1 : (byte)0;
			ImGuiNative.RenderFrame(pMin, pMax, fillCol, native_borders, rounding);
		}

		public static void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			byte borders = 1;
			ImGuiNative.RenderFrame(pMin, pMax, fillCol, borders, rounding);
		}

		public static void RenderFrameBorder(Vector2 pMin, Vector2 pMax)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			ImGuiNative.RenderFrameBorder(pMin, pMax, rounding);
		}

		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff, float rounding)
		{
			// defining omitted parameters
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.RenderColorRectWithAlphaCheckerboard(drawList, pMin, pMax, fillCol, gridStep, gridOff, rounding, flags);
		}

		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.RenderColorRectWithAlphaCheckerboard(drawList, pMin, pMax, fillCol, gridStep, gridOff, rounding, flags);
		}

		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		public static void RenderNavCursor(ImRect bb, uint id)
		{
			// defining omitted parameters
			ImGuiNavRenderCursorFlags flags = ImGuiNavRenderCursorFlags.None;
			ImGuiNative.RenderNavCursor(bb, id, flags);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static string FindRenderedTextEnd(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			var result = ImGuiNative.FindRenderedTextEnd(nativeText, nativeTextEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
			return Utils.DecodeStringUTF8(result);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static string FindRenderedTextEnd(ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				var result = ImGuiNative.FindRenderedTextEnd(nativeText, textEnd);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static string FindRenderedTextEnd(ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			var result = ImGuiNative.FindRenderedTextEnd(nativeText, textEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			return Utils.DecodeStringUTF8(result);
		}

		public static void RenderArrow(ImDrawListPtr drawList, Vector2 pos, uint col, ImGuiDir dir)
		{
			// defining omitted parameters
			float scale = 1.0f;
			ImGuiNative.RenderArrow(drawList, pos, col, dir, scale);
		}

		public static void TextEx(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd, ImGuiTextFlags flags)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.TextEx(nativeText, nativeTextEnd, flags);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public static void TextEx(ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			// defining omitted parameters
			ImGuiTextFlags flags = ImGuiTextFlags.None;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.TextEx(nativeText, nativeTextEnd, flags);
			}
		}

		public static void TextEx(ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// defining omitted parameters
			ImGuiTextFlags flags = ImGuiTextFlags.None;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.TextEx(nativeText, nativeTextEnd, flags);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public static void TextEx(ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			ImGuiTextFlags flags = ImGuiTextFlags.None;
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				ImGuiNative.TextEx(nativeText, textEnd, flags);
			}
		}

		public static void TextEx(ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			ImGuiTextFlags flags = ImGuiTextFlags.None;
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImGuiNative.TextEx(nativeText, textEnd, flags);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public static bool ButtonEx(ReadOnlySpan<char> label, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ButtonEx(ReadOnlySpan<byte> label, Vector2 sizeArg)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
				return result != 0;
			}
		}

		public static bool ButtonEx(ReadOnlySpan<char> label, Vector2 sizeArg)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ButtonEx(ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			Vector2 sizeArg = new Vector2(0,0);
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
				return result != 0;
			}
		}

		public static bool ButtonEx(ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			Vector2 sizeArg = new Vector2(0,0);
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static bool ArrowButtonEx(ReadOnlySpan<char> strId, ImGuiDir dir, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ArrowButtonEx(nativeStrId, dir, sizeArg, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool ArrowButtonEx(ReadOnlySpan<byte> strId, ImGuiDir dir, Vector2 sizeArg)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ArrowButtonEx(nativeStrId, dir, sizeArg, flags);
				return result != 0;
			}
		}

		public static bool ArrowButtonEx(ReadOnlySpan<char> strId, ImGuiDir dir, Vector2 sizeArg)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			// Marshaling strId to native string
			byte* nativeStrId;
			var byteCountStrId = 0;
			if (strId != null && !strId.IsEmpty)
			{
				byteCountStrId = Encoding.UTF8.GetByteCount(strId);
				if(byteCountStrId > Utils.MaxStackallocSize)
				{
					nativeStrId = Utils.Alloc<byte>(byteCountStrId + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrId + 1];
					nativeStrId = stackallocBytes;
				}
				var offsetStrId = Utils.EncodeStringUTF8(strId, nativeStrId, byteCountStrId);
				nativeStrId[offsetStrId] = 0;
			}
			else nativeStrId = null;

			var result = ImGuiNative.ArrowButtonEx(nativeStrId, dir, sizeArg, flags);
			// Freeing strId native string
			if (byteCountStrId > Utils.MaxStackallocSize)
				Utils.Free(nativeStrId);
			return result != 0;
		}

		public static bool ImageButtonEx(uint id, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			var result = ImGuiNative.ImageButtonEx(id, userTextureId, imageSize, uv0, uv1, bgCol, tintCol, flags);
			return result != 0;
		}

		public static void SeparatorEx(ImGuiSeparatorFlags flags)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.SeparatorEx(flags, thickness);
		}

		public static void SeparatorTextEx(uint id, ReadOnlySpan<char> label, ReadOnlySpan<char> labelEnd, float extraWidth)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling labelEnd to native string
			byte* nativeLabelEnd;
			var byteCountLabelEnd = 0;
			if (labelEnd != null && !labelEnd.IsEmpty)
			{
				byteCountLabelEnd = Encoding.UTF8.GetByteCount(labelEnd);
				if(byteCountLabelEnd > Utils.MaxStackallocSize)
				{
					nativeLabelEnd = Utils.Alloc<byte>(byteCountLabelEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelEnd + 1];
					nativeLabelEnd = stackallocBytes;
				}
				var offsetLabelEnd = Utils.EncodeStringUTF8(labelEnd, nativeLabelEnd, byteCountLabelEnd);
				nativeLabelEnd[offsetLabelEnd] = 0;
			}
			else nativeLabelEnd = null;

			ImGuiNative.SeparatorTextEx(id, nativeLabel, nativeLabelEnd, extraWidth);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing labelEnd native string
			if (byteCountLabelEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelEnd);
		}

		public static bool CheckboxFlags(ReadOnlySpan<byte> label, ref long flags, long flagsValue)
		{
			fixed (byte* nativeLabel = label)
			fixed (long* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				return result != 0;
			}
		}

		public static bool CheckboxFlags(ReadOnlySpan<char> label, ref long flags, long flagsValue)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (long* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool CheckboxFlags(ReadOnlySpan<byte> label, ref ulong flags, ulong flagsValue)
		{
			fixed (byte* nativeLabel = label)
			fixed (ulong* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				return result != 0;
			}
		}

		public static bool CheckboxFlags(ReadOnlySpan<char> label, ref ulong flags, ulong flagsValue)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (ulong* nativeFlags = &flags)
			{
				var result = ImGuiNative.CheckboxFlags(nativeLabel, nativeFlags, flagsValue);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, ref long pScrollV, long availV, long contentsV)
		{
			// defining omitted parameters
			ImDrawFlags drawRoundingFlags = ImDrawFlags.None;
			fixed (long* nativePScrollV = &pScrollV)
			{
				var result = ImGuiNative.ScrollbarEx(bb, id, axis, nativePScrollV, availV, contentsV, drawRoundingFlags);
				return result != 0;
			}
		}

		public static bool ButtonBehavior(ImRect bb, uint id, ref bool outHovered, ref bool outHeld)
		{
			// defining omitted parameters
			ImGuiButtonFlags flags = ImGuiButtonFlags.None;
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeOutHeldVal = outHeld ? (byte)1 : (byte)0;
			var nativeOutHeld = &nativeOutHeldVal;
			var result = ImGuiNative.ButtonBehavior(bb, id, nativeOutHovered, nativeOutHeld, flags);
			outHovered = nativeOutHoveredVal != 0;
			outHeld = nativeOutHeldVal != 0;
			return result != 0;
		}

		public static bool DragBehavior(uint id, ImGuiDataType dataType, IntPtr pV, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DragBehavior(id, dataType, (void*)pV, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool SliderBehavior(ImRect bb, uint id, ImGuiDataType dataType, IntPtr pV, IntPtr pMin, IntPtr pMax, ReadOnlySpan<char> format, ImGuiSliderFlags flags, ImRectPtr outGrabBb)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.SliderBehavior(bb, id, dataType, (void*)pV, (void*)pMin, (void*)pMax, nativeFormat, flags, outGrabBb);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float minSize1, float minSize2, float hoverExtend, float hoverVisibilityDelay)
		{
			// defining omitted parameters
			uint bgCol = 0;
			fixed (float* nativeSize1 = &size1)
			fixed (float* nativeSize2 = &size2)
			{
				var result = ImGuiNative.SplitterBehavior(bb, id, axis, nativeSize1, nativeSize2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
				return result != 0;
			}
		}

		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float minSize1, float minSize2, float hoverExtend)
		{
			// defining omitted parameters
			uint bgCol = 0;
			float hoverVisibilityDelay = 0.0f;
			fixed (float* nativeSize1 = &size1)
			fixed (float* nativeSize2 = &size2)
			{
				var result = ImGuiNative.SplitterBehavior(bb, id, axis, nativeSize1, nativeSize2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
				return result != 0;
			}
		}

		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float minSize1, float minSize2)
		{
			// defining omitted parameters
			uint bgCol = 0;
			float hoverVisibilityDelay = 0.0f;
			float hoverExtend = 0.0f;
			fixed (float* nativeSize1 = &size1)
			fixed (float* nativeSize2 = &size2)
			{
				var result = ImGuiNative.SplitterBehavior(bb, id, axis, nativeSize1, nativeSize2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
				return result != 0;
			}
		}

		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> label, ReadOnlySpan<char> labelEnd)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling labelEnd to native string
			byte* nativeLabelEnd;
			var byteCountLabelEnd = 0;
			if (labelEnd != null && !labelEnd.IsEmpty)
			{
				byteCountLabelEnd = Encoding.UTF8.GetByteCount(labelEnd);
				if(byteCountLabelEnd > Utils.MaxStackallocSize)
				{
					nativeLabelEnd = Utils.Alloc<byte>(byteCountLabelEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabelEnd + 1];
					nativeLabelEnd = stackallocBytes;
				}
				var offsetLabelEnd = Utils.EncodeStringUTF8(labelEnd, nativeLabelEnd, byteCountLabelEnd);
				nativeLabelEnd[offsetLabelEnd] = 0;
			}
			else nativeLabelEnd = null;

			var result = ImGuiNative.TreeNodeBehavior(id, flags, nativeLabel, nativeLabelEnd);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing labelEnd native string
			if (byteCountLabelEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeLabelEnd);
			return result != 0;
		}

		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<byte> label)
		{
			// defining omitted parameters
			byte* labelEnd = null;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TreeNodeBehavior(id, flags, nativeLabel, labelEnd);
				return result != 0;
			}
		}

		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> label)
		{
			// defining omitted parameters
			byte* labelEnd = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			var result = ImGuiNative.TreeNodeBehavior(id, flags, nativeLabel, labelEnd);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			return result != 0;
		}

		public static int DataTypeFormatString(byte[] buf, int bufSize, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format)
		{
			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.DataTypeFormatString(nativeBuf, bufSize, dataType, (void*)pData, nativeFormat);
				// Freeing format native string
				if (byteCountFormat > Utils.MaxStackallocSize)
					Utils.Free(nativeFormat);
				return result;
			}
		}

		public static bool DataTypeApplyFromText(ReadOnlySpan<char> buf, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format, IntPtr pDataWhenEmpty)
		{
			// Marshaling buf to native string
			byte* nativeBuf;
			var byteCountBuf = 0;
			if (buf != null && !buf.IsEmpty)
			{
				byteCountBuf = Encoding.UTF8.GetByteCount(buf);
				if(byteCountBuf > Utils.MaxStackallocSize)
				{
					nativeBuf = Utils.Alloc<byte>(byteCountBuf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBuf + 1];
					nativeBuf = stackallocBytes;
				}
				var offsetBuf = Utils.EncodeStringUTF8(buf, nativeBuf, byteCountBuf);
				nativeBuf[offsetBuf] = 0;
			}
			else nativeBuf = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DataTypeApplyFromText(nativeBuf, dataType, (void*)pData, nativeFormat, (void*)pDataWhenEmpty);
			// Freeing buf native string
			if (byteCountBuf > Utils.MaxStackallocSize)
				Utils.Free(nativeBuf);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool DataTypeApplyFromText(ReadOnlySpan<byte> buf, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			void* pDataWhenEmpty = null;
			fixed (byte* nativeBuf = buf)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DataTypeApplyFromText(nativeBuf, dataType, (void*)pData, nativeFormat, pDataWhenEmpty);
				return result != 0;
			}
		}

		public static bool DataTypeApplyFromText(ReadOnlySpan<char> buf, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			void* pDataWhenEmpty = null;
			// Marshaling buf to native string
			byte* nativeBuf;
			var byteCountBuf = 0;
			if (buf != null && !buf.IsEmpty)
			{
				byteCountBuf = Encoding.UTF8.GetByteCount(buf);
				if(byteCountBuf > Utils.MaxStackallocSize)
				{
					nativeBuf = Utils.Alloc<byte>(byteCountBuf + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBuf + 1];
					nativeBuf = stackallocBytes;
				}
				var offsetBuf = Utils.EncodeStringUTF8(buf, nativeBuf, byteCountBuf);
				nativeBuf[offsetBuf] = 0;
			}
			else nativeBuf = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.DataTypeApplyFromText(nativeBuf, dataType, (void*)pData, nativeFormat, pDataWhenEmpty);
			// Freeing buf native string
			if (byteCountBuf > Utils.MaxStackallocSize)
				Utils.Free(nativeBuf);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool InputTextEx(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, (void*)userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool InputTextEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextEx(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// defining omitted parameters
			void* userData = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool InputTextEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, userData);
				return result != 0;
			}
		}

		public static bool InputTextEx(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags)
		{
			// defining omitted parameters
			void* userData = null;
			ImGuiInputTextCallback callback = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling hint to native string
			byte* nativeHint;
			var byteCountHint = 0;
			if (hint != null && !hint.IsEmpty)
			{
				byteCountHint = Encoding.UTF8.GetByteCount(hint);
				if(byteCountHint > Utils.MaxStackallocSize)
				{
					nativeHint = Utils.Alloc<byte>(byteCountHint + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountHint + 1];
					nativeHint = stackallocBytes;
				}
				var offsetHint = Utils.EncodeStringUTF8(hint, nativeHint, byteCountHint);
				nativeHint[offsetHint] = 0;
			}
			else nativeHint = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, userData);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				// Freeing hint native string
				if (byteCountHint > Utils.MaxStackallocSize)
					Utils.Free(nativeHint);
				return result != 0;
			}
		}

		public static bool TempInputText(ImRect bb, uint id, ReadOnlySpan<char> label, byte[] buf, int bufSize, ImGuiInputTextFlags flags)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.TempInputText(bb, id, nativeLabel, nativeBuf, bufSize, flags);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
				return result != 0;
			}
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format, IntPtr pClampMin, IntPtr pClampMax)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, (void*)pClampMin, (void*)pClampMax);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format, IntPtr pClampMin)
		{
			// defining omitted parameters
			void* pClampMax = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, (void*)pClampMin, pClampMax);
				return result != 0;
			}
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format, IntPtr pClampMin)
		{
			// defining omitted parameters
			void* pClampMax = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, (void*)pClampMin, pClampMax);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format)
		{
			// defining omitted parameters
			void* pClampMax = null;
			void* pClampMin = null;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, pClampMin, pClampMax);
				return result != 0;
			}
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<char> format)
		{
			// defining omitted parameters
			void* pClampMax = null;
			void* pClampMin = null;
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling format to native string
			byte* nativeFormat;
			var byteCountFormat = 0;
			if (format != null && !format.IsEmpty)
			{
				byteCountFormat = Encoding.UTF8.GetByteCount(format);
				if(byteCountFormat > Utils.MaxStackallocSize)
				{
					nativeFormat = Utils.Alloc<byte>(byteCountFormat + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFormat + 1];
					nativeFormat = stackallocBytes;
				}
				var offsetFormat = Utils.EncodeStringUTF8(format, nativeFormat, byteCountFormat);
				nativeFormat[offsetFormat] = 0;
			}
			else nativeFormat = null;

			var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, pClampMin, pClampMax);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing format native string
			if (byteCountFormat > Utils.MaxStackallocSize)
				Utils.Free(nativeFormat);
			return result != 0;
		}

		public static void ColorTooltip(ReadOnlySpan<char> text, float[] col, ImGuiColorEditFlags flags)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			fixed (float* nativeCol = col)
			{
				ImGuiNative.ColorTooltip(nativeText, nativeCol, flags);
				// Freeing text native string
				if (byteCountText > Utils.MaxStackallocSize)
					Utils.Free(nativeText);
			}
		}

		public static int PlotEx(ImGuiPlotType plotType, ReadOnlySpan<char> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<char> overlayText, float scaleMin, float scaleMax, Vector2 sizeArg)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling overlayText to native string
			byte* nativeOverlayText;
			var byteCountOverlayText = 0;
			if (overlayText != null && !overlayText.IsEmpty)
			{
				byteCountOverlayText = Encoding.UTF8.GetByteCount(overlayText);
				if(byteCountOverlayText > Utils.MaxStackallocSize)
				{
					nativeOverlayText = Utils.Alloc<byte>(byteCountOverlayText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountOverlayText + 1];
					nativeOverlayText = stackallocBytes;
				}
				var offsetOverlayText = Utils.EncodeStringUTF8(overlayText, nativeOverlayText, byteCountOverlayText);
				nativeOverlayText[offsetOverlayText] = 0;
			}
			else nativeOverlayText = null;

			var result = ImGuiNative.PlotEx(plotType, nativeLabel, valuesGetter, (void*)data, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, sizeArg);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing overlayText native string
			if (byteCountOverlayText > Utils.MaxStackallocSize)
				Utils.Free(nativeOverlayText);
			return result;
		}

		public static bool ErrorLog(ReadOnlySpan<char> msg)
		{
			// Marshaling msg to native string
			byte* nativeMsg;
			var byteCountMsg = 0;
			if (msg != null && !msg.IsEmpty)
			{
				byteCountMsg = Encoding.UTF8.GetByteCount(msg);
				if(byteCountMsg > Utils.MaxStackallocSize)
				{
					nativeMsg = Utils.Alloc<byte>(byteCountMsg + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountMsg + 1];
					nativeMsg = stackallocBytes;
				}
				var offsetMsg = Utils.EncodeStringUTF8(msg, nativeMsg, byteCountMsg);
				nativeMsg[offsetMsg] = 0;
			}
			else nativeMsg = null;

			var result = ImGuiNative.ErrorLog(nativeMsg);
			// Freeing msg native string
			if (byteCountMsg > Utils.MaxStackallocSize)
				Utils.Free(nativeMsg);
			return result != 0;
		}

		public static void DebugDrawCursorPos()
		{
			// defining omitted parameters
			uint col = 4278190335;
			ImGuiNative.DebugDrawCursorPos(col);
		}

		public static void DebugDrawLineExtents()
		{
			// defining omitted parameters
			uint col = 4278190335;
			ImGuiNative.DebugDrawLineExtents(col);
		}

		public static void DebugDrawItemRect()
		{
			// defining omitted parameters
			uint col = 4278190335;
			ImGuiNative.DebugDrawItemRect(col);
		}

		public static void DebugTextUnformattedWithLocateItem(ReadOnlySpan<char> lineBegin, ReadOnlySpan<char> lineEnd)
		{
			// Marshaling lineBegin to native string
			byte* nativeLineBegin;
			var byteCountLineBegin = 0;
			if (lineBegin != null && !lineBegin.IsEmpty)
			{
				byteCountLineBegin = Encoding.UTF8.GetByteCount(lineBegin);
				if(byteCountLineBegin > Utils.MaxStackallocSize)
				{
					nativeLineBegin = Utils.Alloc<byte>(byteCountLineBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLineBegin + 1];
					nativeLineBegin = stackallocBytes;
				}
				var offsetLineBegin = Utils.EncodeStringUTF8(lineBegin, nativeLineBegin, byteCountLineBegin);
				nativeLineBegin[offsetLineBegin] = 0;
			}
			else nativeLineBegin = null;

			// Marshaling lineEnd to native string
			byte* nativeLineEnd;
			var byteCountLineEnd = 0;
			if (lineEnd != null && !lineEnd.IsEmpty)
			{
				byteCountLineEnd = Encoding.UTF8.GetByteCount(lineEnd);
				if(byteCountLineEnd > Utils.MaxStackallocSize)
				{
					nativeLineEnd = Utils.Alloc<byte>(byteCountLineEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLineEnd + 1];
					nativeLineEnd = stackallocBytes;
				}
				var offsetLineEnd = Utils.EncodeStringUTF8(lineEnd, nativeLineEnd, byteCountLineEnd);
				nativeLineEnd[offsetLineEnd] = 0;
			}
			else nativeLineEnd = null;

			ImGuiNative.DebugTextUnformattedWithLocateItem(nativeLineBegin, nativeLineEnd);
			// Freeing lineBegin native string
			if (byteCountLineBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeLineBegin);
			// Freeing lineEnd native string
			if (byteCountLineEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeLineEnd);
		}

		public static bool DebugBreakButton(ReadOnlySpan<char> label, ReadOnlySpan<char> descriptionOfLocation)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			// Marshaling descriptionOfLocation to native string
			byte* nativeDescriptionOfLocation;
			var byteCountDescriptionOfLocation = 0;
			if (descriptionOfLocation != null && !descriptionOfLocation.IsEmpty)
			{
				byteCountDescriptionOfLocation = Encoding.UTF8.GetByteCount(descriptionOfLocation);
				if(byteCountDescriptionOfLocation > Utils.MaxStackallocSize)
				{
					nativeDescriptionOfLocation = Utils.Alloc<byte>(byteCountDescriptionOfLocation + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountDescriptionOfLocation + 1];
					nativeDescriptionOfLocation = stackallocBytes;
				}
				var offsetDescriptionOfLocation = Utils.EncodeStringUTF8(descriptionOfLocation, nativeDescriptionOfLocation, byteCountDescriptionOfLocation);
				nativeDescriptionOfLocation[offsetDescriptionOfLocation] = 0;
			}
			else nativeDescriptionOfLocation = null;

			var result = ImGuiNative.DebugBreakButton(nativeLabel, nativeDescriptionOfLocation);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
			// Freeing descriptionOfLocation native string
			if (byteCountDescriptionOfLocation > Utils.MaxStackallocSize)
				Utils.Free(nativeDescriptionOfLocation);
			return result != 0;
		}

		public static void DebugBreakButtonTooltip(bool keyboardOnly, ReadOnlySpan<char> descriptionOfLocation)
		{
			var native_keyboardOnly = keyboardOnly ? (byte)1 : (byte)0;
			// Marshaling descriptionOfLocation to native string
			byte* nativeDescriptionOfLocation;
			var byteCountDescriptionOfLocation = 0;
			if (descriptionOfLocation != null && !descriptionOfLocation.IsEmpty)
			{
				byteCountDescriptionOfLocation = Encoding.UTF8.GetByteCount(descriptionOfLocation);
				if(byteCountDescriptionOfLocation > Utils.MaxStackallocSize)
				{
					nativeDescriptionOfLocation = Utils.Alloc<byte>(byteCountDescriptionOfLocation + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountDescriptionOfLocation + 1];
					nativeDescriptionOfLocation = stackallocBytes;
				}
				var offsetDescriptionOfLocation = Utils.EncodeStringUTF8(descriptionOfLocation, nativeDescriptionOfLocation, byteCountDescriptionOfLocation);
				nativeDescriptionOfLocation[offsetDescriptionOfLocation] = 0;
			}
			else nativeDescriptionOfLocation = null;

			ImGuiNative.DebugBreakButtonTooltip(native_keyboardOnly, nativeDescriptionOfLocation);
			// Freeing descriptionOfLocation native string
			if (byteCountDescriptionOfLocation > Utils.MaxStackallocSize)
				Utils.Free(nativeDescriptionOfLocation);
		}

		public static void DebugNodeDockNode(ImGuiDockNodePtr node, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.DebugNodeDockNode(node, nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void DebugNodeDrawList(ImGuiWindowPtr window, ImGuiViewportPPtr viewport, ImDrawListPtr drawList, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.DebugNodeDrawList(window, viewport, drawList, nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void DebugNodeStorage(ImGuiStoragePtr storage, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.DebugNodeStorage(storage, nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void DebugNodeTabBar(ImGuiTabBarPtr tabBar, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.DebugNodeTabBar(tabBar, nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void DebugNodeWindow(ImGuiWindowPtr window, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.DebugNodeWindow(window, nativeLabel);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void DebugNodeWindowsList(ref ImVector<ImGuiWindowPtr> windows, ReadOnlySpan<char> label)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			fixed (ImVector<ImGuiWindowPtr>* nativeWindows = &windows)
			{
				ImGuiNative.DebugNodeWindowsList(nativeWindows, nativeLabel);
				// Freeing label native string
				if (byteCountLabel > Utils.MaxStackallocSize)
					Utils.Free(nativeLabel);
			}
		}

		public static void DebugNodePlatformMonitor(ImGuiPlatformMonitorPtr monitor, ReadOnlySpan<char> label, int idx)
		{
			// Marshaling label to native string
			byte* nativeLabel;
			var byteCountLabel = 0;
			if (label != null && !label.IsEmpty)
			{
				byteCountLabel = Encoding.UTF8.GetByteCount(label);
				if(byteCountLabel > Utils.MaxStackallocSize)
				{
					nativeLabel = Utils.Alloc<byte>(byteCountLabel + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountLabel + 1];
					nativeLabel = stackallocBytes;
				}
				var offsetLabel = Utils.EncodeStringUTF8(label, nativeLabel, byteCountLabel);
				nativeLabel[offsetLabel] = 0;
			}
			else nativeLabel = null;

			ImGuiNative.DebugNodePlatformMonitor(monitor, nativeLabel, idx);
			// Freeing label native string
			if (byteCountLabel > Utils.MaxStackallocSize)
				Utils.Free(nativeLabel);
		}

		public static void ImFontAtlasBuildRender8BppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, ReadOnlySpan<char> inStr, bool inMarkerChar, bool inMarkerPixelValue)
		{
			// Marshaling inStr to native string
			byte* nativeInStr;
			var byteCountInStr = 0;
			if (inStr != null && !inStr.IsEmpty)
			{
				byteCountInStr = Encoding.UTF8.GetByteCount(inStr);
				if(byteCountInStr > Utils.MaxStackallocSize)
				{
					nativeInStr = Utils.Alloc<byte>(byteCountInStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInStr + 1];
					nativeInStr = stackallocBytes;
				}
				var offsetInStr = Utils.EncodeStringUTF8(inStr, nativeInStr, byteCountInStr);
				nativeInStr[offsetInStr] = 0;
			}
			else nativeInStr = null;

			var native_inMarkerChar = inMarkerChar ? (byte)1 : (byte)0;
			var native_inMarkerPixelValue = inMarkerPixelValue ? (byte)1 : (byte)0;
			ImGuiNative.ImFontAtlasBuildRender8BppRectFromString(atlas, x, y, w, h, nativeInStr, native_inMarkerChar, native_inMarkerPixelValue);
			// Freeing inStr native string
			if (byteCountInStr > Utils.MaxStackallocSize)
				Utils.Free(nativeInStr);
		}

		public static void ImFontAtlasBuildRender32BppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, ReadOnlySpan<char> inStr, bool inMarkerChar, uint inMarkerPixelValue)
		{
			// Marshaling inStr to native string
			byte* nativeInStr;
			var byteCountInStr = 0;
			if (inStr != null && !inStr.IsEmpty)
			{
				byteCountInStr = Encoding.UTF8.GetByteCount(inStr);
				if(byteCountInStr > Utils.MaxStackallocSize)
				{
					nativeInStr = Utils.Alloc<byte>(byteCountInStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountInStr + 1];
					nativeInStr = stackallocBytes;
				}
				var offsetInStr = Utils.EncodeStringUTF8(inStr, nativeInStr, byteCountInStr);
				nativeInStr[offsetInStr] = 0;
			}
			else nativeInStr = null;

			var native_inMarkerChar = inMarkerChar ? (byte)1 : (byte)0;
			ImGuiNative.ImFontAtlasBuildRender32BppRectFromString(atlas, x, y, w, h, nativeInStr, native_inMarkerChar, inMarkerPixelValue);
			// Freeing inStr native string
			if (byteCountInStr > Utils.MaxStackallocSize)
				Utils.Free(nativeInStr);
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.LogText(nativeFmt);
			}
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)<br/>
		/// </summary>
		public static void LogText(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.LogText(nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public static float GETFLTMAX()
		{
			return ImGuiNative.GETFLTMAX();
		}

		public static float GETFLTMIN()
		{
			return ImGuiNative.GETFLTMIN();
		}

		public static ref ImVector<ushort> ImVectorImWcharCreate()
		{
			var nativeResult = ImGuiNative.ImVectorImWcharCreate();
			return ref *(ImVector<ushort>*)&nativeResult;
		}

		public static void ImVectorImWcharDestroy(ref ImVector<ushort> self)
		{
			fixed (ImVector<ushort>* nativeSelf = &self)
			{
				ImGuiNative.ImVectorImWcharDestroy(nativeSelf);
			}
		}

		public static void ImVectorImWcharInit(ref ImVector<ushort> p)
		{
			fixed (ImVector<ushort>* nativeP = &p)
			{
				ImGuiNative.ImVectorImWcharInit(nativeP);
			}
		}

		public static void ImVectorImWcharUnInit(ref ImVector<ushort> p)
		{
			fixed (ImVector<ushort>* nativeP = &p)
			{
				ImGuiNative.ImVectorImWcharUnInit(nativeP);
			}
		}

	}
}
