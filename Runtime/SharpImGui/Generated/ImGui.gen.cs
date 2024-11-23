using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
// ReSharper disable InconsistentNaming

namespace SharpImGui
{
	public static unsafe partial class ImGui
	{

		/// <summary>
		/// <para>Context creation and access</para>
		/// <para>- Each context create its own ImFontAtlas by default. You may instance one yourself and pass it to CreateContext() to share a font atlas between contexts.</para>
		/// <para>- DLL users: heaps and globals are not shared across DLL boundaries! You will need to call SetCurrentContext() + SetAllocatorFunctions()</para>
		/// <para>  for each static/DLL boundary you are calling from. Read "Context and Memory Allocators" section of imgui.cpp for details.</para>
		/// </summary>
		public static IntPtr CreateContext()
		{
			ImFontAtlas* shared_font_atlas = null;

			var ret = ImGuiNative.ImGui_CreateContext(shared_font_atlas);
			return ret;
		}
		/// <summary>
		/// <para>Context creation and access</para>
		/// <para>- Each context create its own ImFontAtlas by default. You may instance one yourself and pass it to CreateContext() to share a font atlas between contexts.</para>
		/// <para>- DLL users: heaps and globals are not shared across DLL boundaries! You will need to call SetCurrentContext() + SetAllocatorFunctions()</para>
		/// <para>  for each static/DLL boundary you are calling from. Read "Context and Memory Allocators" section of imgui.cpp for details.</para>
		/// </summary>
		public static IntPtr CreateContext(ImFontAtlasPtr shared_font_atlas)
		{
			var ret = ImGuiNative.ImGui_CreateContext(shared_font_atlas);
			return ret;
		}

		/// <summary>
		/// NULL = destroy current context
		/// </summary>
		public static void DestroyContext()
		{
			IntPtr ctx = IntPtr.Zero;

			ImGuiNative.ImGui_DestroyContext(ctx);
		}
		/// <summary>
		/// NULL = destroy current context
		/// </summary>
		public static void DestroyContext(IntPtr ctx)
		{
			ImGuiNative.ImGui_DestroyContext(ctx);
		}

		public static IntPtr GetCurrentContext()
		{
			var ret = ImGuiNative.ImGui_GetCurrentContext();
			return ret;
		}

		public static void SetCurrentContext(IntPtr ctx)
		{
			ImGuiNative.ImGui_SetCurrentContext(ctx);
		}

		/// <summary>
		/// <para>Main</para>
		/// </summary>
		/// <summary>
		/// access the ImGuiIO structure (mouse/keyboard/gamepad inputs, time, various configuration options/flags)
		/// </summary>
		public static ImGuiIOPtr GetIO()
		{
			var ret = ImGuiNative.ImGui_GetIO();
			return ret;
		}

		/// <summary>
		/// access the ImGuiPlatformIO structure (mostly hooks/functions to connect to platform/renderer and OS Clipboard, IME etc.)
		/// </summary>
		public static ImGuiPlatformIOPtr GetPlatformIO()
		{
			var ret = ImGuiNative.ImGui_GetPlatformIO();
			return ret;
		}

		/// <summary>
		/// access the Style structure (colors, sizes). Always use PushStyleColor(), PushStyleVar() to modify style mid-frame!
		/// </summary>
		public static ImGuiStylePtr GetStyle()
		{
			var ret = ImGuiNative.ImGui_GetStyle();
			return ret;
		}

		/// <summary>
		/// start a new Dear ImGui frame, you can submit any command from this point until Render()/EndFrame().
		/// </summary>
		public static void NewFrame()
		{
			ImGuiNative.ImGui_NewFrame();
		}

		/// <summary>
		/// ends the Dear ImGui frame. automatically called by Render(). If you don't need to render data (skipping rendering) you may call EndFrame() without Render()... but you'll have wasted CPU already! If you don't need to render, better to not create any windows and not call NewFrame() at all!
		/// </summary>
		public static void EndFrame()
		{
			ImGuiNative.ImGui_EndFrame();
		}

		/// <summary>
		/// ends the Dear ImGui frame, finalize the draw data. You can then get call GetDrawData().
		/// </summary>
		public static void Render()
		{
			ImGuiNative.ImGui_Render();
		}

		/// <summary>
		/// valid after Render() and until the next call to NewFrame(). this is what you have to render.
		/// </summary>
		public static ImDrawDataPtr GetDrawData()
		{
			var ret = ImGuiNative.ImGui_GetDrawData();
			return ret;
		}

		/// <summary>
		/// <para>Demo, Debug, Information</para>
		/// </summary>
		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!
		/// </summary>
		public static void ShowDemoWindow()
		{
			byte* p_open = null;

			ImGuiNative.ImGui_ShowDemoWindow(p_open);
		}
		/// <summary>
		/// <para>Demo, Debug, Information</para>
		/// </summary>
		/// <summary>
		/// create Demo window. demonstrate most ImGui features. call this to learn about the library! try to make it always available in your application!
		/// </summary>
		public static void ShowDemoWindow(ref bool p_open)
		{
			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiNative.ImGui_ShowDemoWindow(native_p_open);
			p_open = native_p_open_val != 0;
		}

		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.
		/// </summary>
		public static void ShowMetricsWindow()
		{
			byte* p_open = null;

			ImGuiNative.ImGui_ShowMetricsWindow(p_open);
		}
		/// <summary>
		/// create Metrics/Debugger window. display Dear ImGui internals: windows, draw commands, various internal state, etc.
		/// </summary>
		public static void ShowMetricsWindow(ref bool p_open)
		{
			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiNative.ImGui_ShowMetricsWindow(native_p_open);
			p_open = native_p_open_val != 0;
		}

		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.
		/// </summary>
		public static void ShowDebugLogWindow()
		{
			byte* p_open = null;

			ImGuiNative.ImGui_ShowDebugLogWindow(p_open);
		}
		/// <summary>
		/// create Debug Log window. display a simplified log of important dear imgui events.
		/// </summary>
		public static void ShowDebugLogWindow(ref bool p_open)
		{
			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiNative.ImGui_ShowDebugLogWindow(native_p_open);
			p_open = native_p_open_val != 0;
		}

		/// <summary>
		/// Implied p_open = NULL
		/// </summary>
		public static void ShowIDStackToolWindow()
		{
			ImGuiNative.ImGui_ShowIDStackToolWindow();
		}

		/// <summary>
		/// Implied p_open = NULL
		/// </summary>
		public static void ShowIDStackToolWindow(ref bool p_open)
		{
			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiNative.ImGui_ShowIDStackToolWindowEx(native_p_open);
			p_open = native_p_open_val != 0;
		}

		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.
		/// </summary>
		public static void ShowAboutWindow()
		{
			byte* p_open = null;

			ImGuiNative.ImGui_ShowAboutWindow(p_open);
		}
		/// <summary>
		/// create About window. display Dear ImGui version, credits and build/system information.
		/// </summary>
		public static void ShowAboutWindow(ref bool p_open)
		{
			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiNative.ImGui_ShowAboutWindow(native_p_open);
			p_open = native_p_open_val != 0;
		}

		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)
		/// </summary>
		public static void ShowStyleEditor()
		{
			ImGuiStyle* _ref = null;

			ImGuiNative.ImGui_ShowStyleEditor(_ref);
		}
		/// <summary>
		/// add style editor block (not a window). you can pass in a reference ImGuiStyle structure to compare to, revert to and save to (else it uses the default style)
		/// </summary>
		public static void ShowStyleEditor(ImGuiStylePtr _ref)
		{
			ImGuiNative.ImGui_ShowStyleEditor(_ref);
		}

		/// <summary>
		/// add style selector block (not a window), essentially a combo listing the default styles.
		/// </summary>
		public static bool ShowStyleSelector(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_ShowStyleSelector(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// add font selector block (not a window), essentially a combo listing the loaded fonts.
		/// </summary>
		public static void ShowFontSelector(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ImGui_ShowFontSelector(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// add basic help/info block (not a window): how to manipulate ImGui as an end-user (mouse/keyboard controls).
		/// </summary>
		public static void ShowUserGuide()
		{
			ImGuiNative.ImGui_ShowUserGuide();
		}

		/// <summary>
		/// get the compiled version string e.g. "1.80 WIP" (essentially the value for IMGUI_VERSION from the compiled version of imgui.cpp)
		/// </summary>
		public static string GetVersion()
		{
			var ret = ImGuiNative.ImGui_GetVersion();
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// <para>Styles</para>
		/// </summary>
		/// <summary>
		/// new, recommended style (default)
		/// </summary>
		public static void StyleColorsDark()
		{
			ImGuiStyle* dst = null;

			ImGuiNative.ImGui_StyleColorsDark(dst);
		}
		/// <summary>
		/// <para>Styles</para>
		/// </summary>
		/// <summary>
		/// new, recommended style (default)
		/// </summary>
		public static void StyleColorsDark(ImGuiStylePtr dst)
		{
			ImGuiNative.ImGui_StyleColorsDark(dst);
		}

		/// <summary>
		/// best used with borders and a custom, thicker font
		/// </summary>
		public static void StyleColorsLight()
		{
			ImGuiStyle* dst = null;

			ImGuiNative.ImGui_StyleColorsLight(dst);
		}
		/// <summary>
		/// best used with borders and a custom, thicker font
		/// </summary>
		public static void StyleColorsLight(ImGuiStylePtr dst)
		{
			ImGuiNative.ImGui_StyleColorsLight(dst);
		}

		/// <summary>
		/// classic imgui style
		/// </summary>
		public static void StyleColorsClassic()
		{
			ImGuiStyle* dst = null;

			ImGuiNative.ImGui_StyleColorsClassic(dst);
		}
		/// <summary>
		/// classic imgui style
		/// </summary>
		public static void StyleColorsClassic(ImGuiStylePtr dst)
		{
			ImGuiNative.ImGui_StyleColorsClassic(dst);
		}

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
		public static bool Begin(ReadOnlySpan<char> name)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			byte* p_open = null;

			ImGuiWindowFlags flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_Begin(native_name, p_open, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}
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
		public static bool Begin(ReadOnlySpan<char> name, ref bool p_open)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiWindowFlags flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_Begin(native_name, native_p_open, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}
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
		public static bool Begin(ReadOnlySpan<char> name, ref bool p_open, ImGuiWindowFlags flags)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			var ret = ImGuiNative.ImGui_Begin(native_name, native_p_open, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}

		public static void End()
		{
			ImGuiNative.ImGui_End();
		}

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
		public static bool BeginChild(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			Vector2 size = new Vector2();

			ImGuiChildFlags child_flags = (ImGuiChildFlags)0;

			ImGuiWindowFlags window_flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginChild(native_str_id, size, child_flags, window_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginChild(ReadOnlySpan<char> str_id, Vector2 size)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiChildFlags child_flags = (ImGuiChildFlags)0;

			ImGuiWindowFlags window_flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginChild(native_str_id, size, child_flags, window_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginChild(ReadOnlySpan<char> str_id, Vector2 size, ImGuiChildFlags child_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiWindowFlags window_flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginChild(native_str_id, size, child_flags, window_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginChild(ReadOnlySpan<char> str_id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginChild(native_str_id, size, child_flags, window_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		public static bool BeginChildID(uint id)
		{
			Vector2 size = new Vector2();

			ImGuiChildFlags child_flags = (ImGuiChildFlags)0;

			ImGuiWindowFlags window_flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginChildID(id, size, child_flags, window_flags);
			return ret != 0;
		}
		public static bool BeginChildID(uint id, Vector2 size)
		{
			ImGuiChildFlags child_flags = (ImGuiChildFlags)0;

			ImGuiWindowFlags window_flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginChildID(id, size, child_flags, window_flags);
			return ret != 0;
		}
		public static bool BeginChildID(uint id, Vector2 size, ImGuiChildFlags child_flags)
		{
			ImGuiWindowFlags window_flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginChildID(id, size, child_flags, window_flags);
			return ret != 0;
		}
		public static bool BeginChildID(uint id, Vector2 size, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags)
		{
			var ret = ImGuiNative.ImGui_BeginChildID(id, size, child_flags, window_flags);
			return ret != 0;
		}

		public static void EndChild()
		{
			ImGuiNative.ImGui_EndChild();
		}

		/// <summary>
		/// <para>Windows Utilities</para>
		/// <para>- 'current window' = the window we are appending into while inside a Begin()/End() block. 'next window' = next window we will Begin() into.</para>
		/// </summary>
		public static bool IsWindowAppearing()
		{
			var ret = ImGuiNative.ImGui_IsWindowAppearing();
			return ret != 0;
		}

		public static bool IsWindowCollapsed()
		{
			var ret = ImGuiNative.ImGui_IsWindowCollapsed();
			return ret != 0;
		}

		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.
		/// </summary>
		public static bool IsWindowFocused()
		{
			ImGuiFocusedFlags flags = (ImGuiFocusedFlags)0;

			var ret = ImGuiNative.ImGui_IsWindowFocused(flags);
			return ret != 0;
		}
		/// <summary>
		/// is current window focused? or its root/child, depending on flags. see flags for options.
		/// </summary>
		public static bool IsWindowFocused(ImGuiFocusedFlags flags)
		{
			var ret = ImGuiNative.ImGui_IsWindowFocused(flags);
			return ret != 0;
		}

		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.
		/// </summary>
		public static bool IsWindowHovered()
		{
			ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;

			var ret = ImGuiNative.ImGui_IsWindowHovered(flags);
			return ret != 0;
		}
		/// <summary>
		/// is current window hovered and hoverable (e.g. not blocked by a popup/modal)? See ImGuiHoveredFlags_ for options. IMPORTANT: If you are trying to check whether your mouse should be dispatched to Dear ImGui or to your underlying app, you should not use this function! Use the 'io.WantCaptureMouse' boolean for that! Refer to FAQ entry "How can I tell whether to dispatch mouse/keyboard to Dear ImGui or my application?" for details.
		/// </summary>
		public static bool IsWindowHovered(ImGuiHoveredFlags flags)
		{
			var ret = ImGuiNative.ImGui_IsWindowHovered(flags);
			return ret != 0;
		}

		/// <summary>
		/// get draw list associated to the current window, to append your own drawing primitives
		/// </summary>
		public static ImDrawListPtr GetWindowDrawList()
		{
			var ret = ImGuiNative.ImGui_GetWindowDrawList();
			return ret;
		}

		/// <summary>
		/// get DPI scale currently associated to the current window's viewport.
		/// </summary>
		public static float GetWindowDpiScale()
		{
			var ret = ImGuiNative.ImGui_GetWindowDpiScale();
			return ret;
		}

		/// <summary>
		/// get current window position in screen space (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)
		/// </summary>
		public static Vector2 GetWindowPos()
		{
			var ret = ImGuiNative.ImGui_GetWindowPos();
			return ret;
		}

		/// <summary>
		/// get current window size (IT IS UNLIKELY YOU EVER NEED TO USE THIS. Consider always using GetCursorScreenPos() and GetContentRegionAvail() instead)
		/// </summary>
		public static Vector2 GetWindowSize()
		{
			var ret = ImGuiNative.ImGui_GetWindowSize();
			return ret;
		}

		/// <summary>
		/// get current window width (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().x.
		/// </summary>
		public static float GetWindowWidth()
		{
			var ret = ImGuiNative.ImGui_GetWindowWidth();
			return ret;
		}

		/// <summary>
		/// get current window height (IT IS UNLIKELY YOU EVER NEED TO USE THIS). Shortcut for GetWindowSize().y.
		/// </summary>
		public static float GetWindowHeight()
		{
			var ret = ImGuiNative.ImGui_GetWindowHeight();
			return ret;
		}

		/// <summary>
		/// get viewport currently associated to the current window.
		/// </summary>
		public static ImGuiViewportPtr GetWindowViewport()
		{
			var ret = ImGuiNative.ImGui_GetWindowViewport();
			return ret;
		}

		/// <summary>
		/// <para>Window manipulation</para>
		/// <para>- Prefer using SetNextXXX functions (before Begin) rather that SetXXX functions (after Begin).</para>
		/// </summary>
		/// <summary>
		/// Implied pivot = ImVec2(0, 0)
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetNextWindowPos(pos, cond);
		}
		/// <summary>
		/// <para>Window manipulation</para>
		/// <para>- Prefer using SetNextXXX functions (before Begin) rather that SetXXX functions (after Begin).</para>
		/// </summary>
		/// <summary>
		/// Implied pivot = ImVec2(0, 0)
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond)
		{
			ImGuiNative.ImGui_SetNextWindowPos(pos, cond);
		}

		/// <summary>
		/// <para>Window manipulation</para>
		/// <para>- Prefer using SetNextXXX functions (before Begin) rather that SetXXX functions (after Begin).</para>
		/// </summary>
		/// <summary>
		/// Implied pivot = ImVec2(0, 0)
		/// </summary>
		public static void SetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot)
		{
			ImGuiNative.ImGui_SetNextWindowPosEx(pos, cond, pivot);
		}

		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()
		/// </summary>
		public static void SetNextWindowSize(Vector2 size)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetNextWindowSize(size, cond);
		}
		/// <summary>
		/// set next window size. set axis to 0.0f to force an auto-fit on this axis. call before Begin()
		/// </summary>
		public static void SetNextWindowSize(Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.ImGui_SetNextWindowSize(size, cond);
		}

		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max)
		{
			ImGuiSizeCallback custom_callback = null;

			void* custom_callback_data = null;

			ImGuiNative.ImGui_SetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
		}
		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback)
		{
			void* custom_callback_data = null;

			ImGuiNative.ImGui_SetNextWindowSizeConstraints(size_min, size_max, custom_callback, custom_callback_data);
		}
		/// <summary>
		/// set next window size limits. use 0.0f or FLT_MAX if you don't want limits. Use -1 for both min and max of same axis to preserve current size (which itself is a constraint). Use callback to apply non-trivial programmatic constraints.
		/// </summary>
		public static void SetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, IntPtr custom_callback_data)
		{
			// Marshaling 'custom_callback_data' to native void pointer
			var native_custom_callback_data = custom_callback_data.ToPointer();

			ImGuiNative.ImGui_SetNextWindowSizeConstraints(size_min, size_max, custom_callback, native_custom_callback_data);
		}

		/// <summary>
		/// set next window content size (~ scrollable client area, which enforce the range of scrollbars). Not including window decorations (title bar, menu bar, etc.) nor WindowPadding. set an axis to 0.0f to leave it automatic. call before Begin()
		/// </summary>
		public static void SetNextWindowContentSize(Vector2 size)
		{
			ImGuiNative.ImGui_SetNextWindowContentSize(size);
		}

		/// <summary>
		/// set next window collapsed state. call before Begin()
		/// </summary>
		public static void SetNextWindowCollapsed(bool collapsed)
		{
			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetNextWindowCollapsed(native_collapsed, cond);
		}
		/// <summary>
		/// set next window collapsed state. call before Begin()
		/// </summary>
		public static void SetNextWindowCollapsed(bool collapsed, ImGuiCond cond)
		{
			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetNextWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// set next window to be focused / top-most. call before Begin()
		/// </summary>
		public static void SetNextWindowFocus()
		{
			ImGuiNative.ImGui_SetNextWindowFocus();
		}

		/// <summary>
		/// set next window scrolling value (use &lt; 0.0f to not affect a given axis).
		/// </summary>
		public static void SetNextWindowScroll(Vector2 scroll)
		{
			ImGuiNative.ImGui_SetNextWindowScroll(scroll);
		}

		/// <summary>
		/// set next window background color alpha. helper to easily override the Alpha component of ImGuiCol_WindowBg/ChildBg/PopupBg. you may also use ImGuiWindowFlags_NoBackground.
		/// </summary>
		public static void SetNextWindowBgAlpha(float alpha)
		{
			ImGuiNative.ImGui_SetNextWindowBgAlpha(alpha);
		}

		/// <summary>
		/// set next window viewport
		/// </summary>
		public static void SetNextWindowViewport(uint viewport_id)
		{
			ImGuiNative.ImGui_SetNextWindowViewport(viewport_id);
		}

		/// <summary>
		/// (not recommended) set current window position - call within Begin()/End(). prefer using SetNextWindowPos(), as this may incur tearing and side-effects.
		/// </summary>
		public static void SetWindowPos(Vector2 pos)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetWindowPos(pos, cond);
		}
		/// <summary>
		/// (not recommended) set current window position - call within Begin()/End(). prefer using SetNextWindowPos(), as this may incur tearing and side-effects.
		/// </summary>
		public static void SetWindowPos(Vector2 pos, ImGuiCond cond)
		{
			ImGuiNative.ImGui_SetWindowPos(pos, cond);
		}

		/// <summary>
		/// (not recommended) set current window size - call within Begin()/End(). set to ImVec2(0, 0) to force an auto-fit. prefer using SetNextWindowSize(), as this may incur tearing and minor side-effects.
		/// </summary>
		public static void SetWindowSize(Vector2 size)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetWindowSize(size, cond);
		}
		/// <summary>
		/// (not recommended) set current window size - call within Begin()/End(). set to ImVec2(0, 0) to force an auto-fit. prefer using SetNextWindowSize(), as this may incur tearing and minor side-effects.
		/// </summary>
		public static void SetWindowSize(Vector2 size, ImGuiCond cond)
		{
			ImGuiNative.ImGui_SetWindowSize(size, cond);
		}

		/// <summary>
		/// (not recommended) set current window collapsed state. prefer using SetNextWindowCollapsed().
		/// </summary>
		public static void SetWindowCollapsed(bool collapsed)
		{
			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetWindowCollapsed(native_collapsed, cond);
		}
		/// <summary>
		/// (not recommended) set current window collapsed state. prefer using SetNextWindowCollapsed().
		/// </summary>
		public static void SetWindowCollapsed(bool collapsed, ImGuiCond cond)
		{
			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetWindowCollapsed(native_collapsed, cond);
		}

		/// <summary>
		/// (not recommended) set current window to be focused / top-most. prefer using SetNextWindowFocus().
		/// </summary>
		public static void SetWindowFocus()
		{
			ImGuiNative.ImGui_SetWindowFocus();
		}

		/// <summary>
		/// [OBSOLETE] set font scale. Adjust IO.FontGlobalScale if you want to scale all windows. This is an old API! For correct scaling, prefer to reload font + rebuild ImFontAtlas + call style.ScaleAllSizes().
		/// </summary>
		public static void SetWindowFontScale(float scale)
		{
			ImGuiNative.ImGui_SetWindowFontScale(scale);
		}

		/// <summary>
		/// set named window position.
		/// </summary>
		public static void SetWindowPosStr(ReadOnlySpan<char> name, Vector2 pos)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetWindowPosStr(native_name, pos, cond);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}
		/// <summary>
		/// set named window position.
		/// </summary>
		public static void SetWindowPosStr(ReadOnlySpan<char> name, Vector2 pos, ImGuiCond cond)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.ImGui_SetWindowPosStr(native_name, pos, cond);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}

		/// <summary>
		/// set named window size. set axis to 0.0f to force an auto-fit on this axis.
		/// </summary>
		public static void SetWindowSizeStr(ReadOnlySpan<char> name, Vector2 size)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetWindowSizeStr(native_name, size, cond);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}
		/// <summary>
		/// set named window size. set axis to 0.0f to force an auto-fit on this axis.
		/// </summary>
		public static void SetWindowSizeStr(ReadOnlySpan<char> name, Vector2 size, ImGuiCond cond)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.ImGui_SetWindowSizeStr(native_name, size, cond);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}

		/// <summary>
		/// set named window collapsed state
		/// </summary>
		public static void SetWindowCollapsedStr(ReadOnlySpan<char> name, bool collapsed)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetWindowCollapsedStr(native_name, native_collapsed, cond);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}
		/// <summary>
		/// set named window collapsed state
		/// </summary>
		public static void SetWindowCollapsedStr(ReadOnlySpan<char> name, bool collapsed, ImGuiCond cond)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetWindowCollapsedStr(native_name, native_collapsed, cond);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}

		/// <summary>
		/// set named window to be focused / top-most. use NULL to remove focus.
		/// </summary>
		public static void SetWindowFocusStr(ReadOnlySpan<char> name)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiNative.ImGui_SetWindowFocusStr(native_name);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}

		/// <summary>
		/// <para>Windows Scrolling</para>
		/// <para>- Any change of Scroll will be applied at the beginning of next frame in the first call to Begin().</para>
		/// <para>- You may instead use SetNextWindowScroll() prior to calling Begin() to avoid this delay, as an alternative to using SetScrollX()/SetScrollY().</para>
		/// </summary>
		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxX()]
		/// </summary>
		public static float GetScrollX()
		{
			var ret = ImGuiNative.ImGui_GetScrollX();
			return ret;
		}

		/// <summary>
		/// get scrolling amount [0 .. GetScrollMaxY()]
		/// </summary>
		public static float GetScrollY()
		{
			var ret = ImGuiNative.ImGui_GetScrollY();
			return ret;
		}

		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxX()]
		/// </summary>
		public static void SetScrollX(float scroll_x)
		{
			ImGuiNative.ImGui_SetScrollX(scroll_x);
		}

		/// <summary>
		/// set scrolling amount [0 .. GetScrollMaxY()]
		/// </summary>
		public static void SetScrollY(float scroll_y)
		{
			ImGuiNative.ImGui_SetScrollY(scroll_y);
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.x - WindowSize.x - DecorationsSize.x
		/// </summary>
		public static float GetScrollMaxX()
		{
			var ret = ImGuiNative.ImGui_GetScrollMaxX();
			return ret;
		}

		/// <summary>
		/// get maximum scrolling amount ~~ ContentSize.y - WindowSize.y - DecorationsSize.y
		/// </summary>
		public static float GetScrollMaxY()
		{
			var ret = ImGuiNative.ImGui_GetScrollMaxY();
			return ret;
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.
		/// </summary>
		public static void SetScrollHereX()
		{
			float center_x_ratio = 0.5f;

			ImGuiNative.ImGui_SetScrollHereX(center_x_ratio);
		}
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_x_ratio=0.0: left, 0.5: center, 1.0: right. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.
		/// </summary>
		public static void SetScrollHereX(float center_x_ratio)
		{
			ImGuiNative.ImGui_SetScrollHereX(center_x_ratio);
		}

		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.
		/// </summary>
		public static void SetScrollHereY()
		{
			float center_y_ratio = 0.5f;

			ImGuiNative.ImGui_SetScrollHereY(center_y_ratio);
		}
		/// <summary>
		/// adjust scrolling amount to make current cursor position visible. center_y_ratio=0.0: top, 0.5: center, 1.0: bottom. When using to make a "default/current item" visible, consider using SetItemDefaultFocus() instead.
		/// </summary>
		public static void SetScrollHereY(float center_y_ratio)
		{
			ImGuiNative.ImGui_SetScrollHereY(center_y_ratio);
		}

		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.
		/// </summary>
		public static void SetScrollFromPosX(float local_x)
		{
			float center_x_ratio = 0.5f;

			ImGuiNative.ImGui_SetScrollFromPosX(local_x, center_x_ratio);
		}
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.
		/// </summary>
		public static void SetScrollFromPosX(float local_x, float center_x_ratio)
		{
			ImGuiNative.ImGui_SetScrollFromPosX(local_x, center_x_ratio);
		}

		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.
		/// </summary>
		public static void SetScrollFromPosY(float local_y)
		{
			float center_y_ratio = 0.5f;

			ImGuiNative.ImGui_SetScrollFromPosY(local_y, center_y_ratio);
		}
		/// <summary>
		/// adjust scrolling amount to make given position visible. Generally GetCursorStartPos() + offset to compute a valid position.
		/// </summary>
		public static void SetScrollFromPosY(float local_y, float center_y_ratio)
		{
			ImGuiNative.ImGui_SetScrollFromPosY(local_y, center_y_ratio);
		}

		/// <summary>
		/// <para>Parameters stacks (shared)</para>
		/// </summary>
		/// <summary>
		/// use NULL as a shortcut to push default font
		/// </summary>
		public static void PushFont(ImFontPtr font)
		{
			ImGuiNative.ImGui_PushFont(font);
		}

		public static void PopFont()
		{
			ImGuiNative.ImGui_PopFont();
		}

		/// <summary>
		/// modify a style color. always use this if you modify the style after NewFrame().
		/// </summary>
		public static void PushStyleColor(ImGuiCol idx, uint col)
		{
			ImGuiNative.ImGui_PushStyleColor(idx, col);
		}

		public static void PushStyleColorImVec4(ImGuiCol idx, Vector4 col)
		{
			ImGuiNative.ImGui_PushStyleColorImVec4(idx, col);
		}

		/// <summary>
		/// Implied count = 1
		/// </summary>
		public static void PopStyleColor()
		{
			ImGuiNative.ImGui_PopStyleColor();
		}

		/// <summary>
		/// Implied count = 1
		/// </summary>
		public static void PopStyleColor(int count)
		{
			ImGuiNative.ImGui_PopStyleColorEx(count);
		}

		/// <summary>
		/// modify a style float variable. always use this if you modify the style after NewFrame()!
		/// </summary>
		public static void PushStyleVar(ImGuiStyleVar idx, float val)
		{
			ImGuiNative.ImGui_PushStyleVar(idx, val);
		}

		/// <summary>
		/// modify a style ImVec2 variable. "
		/// </summary>
		public static void PushStyleVarImVec2(ImGuiStyleVar idx, Vector2 val)
		{
			ImGuiNative.ImGui_PushStyleVarImVec2(idx, val);
		}

		/// <summary>
		/// modify X component of a style ImVec2 variable. "
		/// </summary>
		public static void PushStyleVarX(ImGuiStyleVar idx, float val_x)
		{
			ImGuiNative.ImGui_PushStyleVarX(idx, val_x);
		}

		/// <summary>
		/// modify Y component of a style ImVec2 variable. "
		/// </summary>
		public static void PushStyleVarY(ImGuiStyleVar idx, float val_y)
		{
			ImGuiNative.ImGui_PushStyleVarY(idx, val_y);
		}

		/// <summary>
		/// Implied count = 1
		/// </summary>
		public static void PopStyleVar()
		{
			ImGuiNative.ImGui_PopStyleVar();
		}

		/// <summary>
		/// Implied count = 1
		/// </summary>
		public static void PopStyleVar(int count)
		{
			ImGuiNative.ImGui_PopStyleVarEx(count);
		}

		/// <summary>
		/// modify specified shared item flag, e.g. PushItemFlag(ImGuiItemFlags_NoTabStop, true)
		/// </summary>
		public static void PushItemFlag(ImGuiItemFlags option, bool enabled)
		{
			// Marshaling 'enabled' to native bool
			var native_enabled = enabled ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_PushItemFlag(option, native_enabled);
		}

		public static void PopItemFlag()
		{
			ImGuiNative.ImGui_PopItemFlag();
		}

		/// <summary>
		/// <para>Parameters stacks (current window)</para>
		/// </summary>
		/// <summary>
		/// push width of items for common large "item+label" widgets. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side).
		/// </summary>
		public static void PushItemWidth(float item_width)
		{
			ImGuiNative.ImGui_PushItemWidth(item_width);
		}

		public static void PopItemWidth()
		{
			ImGuiNative.ImGui_PopItemWidth();
		}

		/// <summary>
		/// set width of the _next_ common large "item+label" widget. &gt;0.0f: width in pixels, &lt;0.0f align xx pixels to the right of window (so -FLT_MIN always align width to the right side)
		/// </summary>
		public static void SetNextItemWidth(float item_width)
		{
			ImGuiNative.ImGui_SetNextItemWidth(item_width);
		}

		/// <summary>
		/// width of item given pushed settings and current cursor position. NOT necessarily the width of last item unlike most 'Item' functions.
		/// </summary>
		public static float CalcItemWidth()
		{
			var ret = ImGuiNative.ImGui_CalcItemWidth();
			return ret;
		}

		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space
		/// </summary>
		public static void PushTextWrapPos()
		{
			float wrap_local_pos_x = 0.0f;

			ImGuiNative.ImGui_PushTextWrapPos(wrap_local_pos_x);
		}
		/// <summary>
		/// push word-wrapping position for Text*() commands. &lt; 0.0f: no wrapping; 0.0f: wrap to end of window (or column); &gt; 0.0f: wrap at 'wrap_pos_x' position in window local space
		/// </summary>
		public static void PushTextWrapPos(float wrap_local_pos_x)
		{
			ImGuiNative.ImGui_PushTextWrapPos(wrap_local_pos_x);
		}

		public static void PopTextWrapPos()
		{
			ImGuiNative.ImGui_PopTextWrapPos();
		}

		/// <summary>
		/// <para>Style read access</para>
		/// <para>- Use the ShowStyleEditor() function to interactively see/edit the colors.</para>
		/// </summary>
		/// <summary>
		/// get current font
		/// </summary>
		public static ImFontPtr GetFont()
		{
			var ret = ImGuiNative.ImGui_GetFont();
			return ret;
		}

		/// <summary>
		/// get current font size (= height in pixels) of current font with current scale applied
		/// </summary>
		public static float GetFontSize()
		{
			var ret = ImGuiNative.ImGui_GetFontSize();
			return ret;
		}

		/// <summary>
		/// get UV coordinate for a white pixel, useful to draw custom shapes via the ImDrawList API
		/// </summary>
		public static Vector2 GetFontTexUvWhitePixel()
		{
			var ret = ImGuiNative.ImGui_GetFontTexUvWhitePixel();
			return ret;
		}

		/// <summary>
		/// Implied alpha_mul = 1.0f
		/// </summary>
		public static uint GetColorU32(ImGuiCol idx)
		{
			var ret = ImGuiNative.ImGui_GetColorU32(idx);
			return ret;
		}

		/// <summary>
		/// Implied alpha_mul = 1.0f
		/// </summary>
		public static uint GetColorU32(ImGuiCol idx, float alpha_mul)
		{
			var ret = ImGuiNative.ImGui_GetColorU32Ex(idx, alpha_mul);
			return ret;
		}

		/// <summary>
		/// retrieve given color with style alpha applied, packed as a 32-bit value suitable for ImDrawList
		/// </summary>
		public static uint GetColorU32ImVec4(Vector4 col)
		{
			var ret = ImGuiNative.ImGui_GetColorU32ImVec4(col);
			return ret;
		}

		/// <summary>
		/// Implied alpha_mul = 1.0f
		/// </summary>
		public static uint GetColorU32ImU32(uint col)
		{
			var ret = ImGuiNative.ImGui_GetColorU32ImU32(col);
			return ret;
		}

		/// <summary>
		/// Implied alpha_mul = 1.0f
		/// </summary>
		public static uint GetColorU32ImU32(uint col, float alpha_mul)
		{
			var ret = ImGuiNative.ImGui_GetColorU32ImU32Ex(col, alpha_mul);
			return ret;
		}

		/// <summary>
		/// retrieve style color as stored in ImGuiStyle structure. use to feed back into PushStyleColor(), otherwise use GetColorU32() to get style color with style alpha baked in.
		/// </summary>
		public static Vector4* GetStyleColorVec4(ImGuiCol idx)
		{
			var ret = ImGuiNative.ImGui_GetStyleColorVec4(idx);
			return ret;
		}

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
		public static Vector2 GetCursorScreenPos()
		{
			var ret = ImGuiNative.ImGui_GetCursorScreenPos();
			return ret;
		}

		/// <summary>
		/// cursor position, absolute coordinates. THIS IS YOUR BEST FRIEND.
		/// </summary>
		public static void SetCursorScreenPos(Vector2 pos)
		{
			ImGuiNative.ImGui_SetCursorScreenPos(pos);
		}

		/// <summary>
		/// available space from current position. THIS IS YOUR BEST FRIEND.
		/// </summary>
		public static Vector2 GetContentRegionAvail()
		{
			var ret = ImGuiNative.ImGui_GetContentRegionAvail();
			return ret;
		}

		/// <summary>
		/// [window-local] cursor position in window-local coordinates. This is not your best friend.
		/// </summary>
		public static Vector2 GetCursorPos()
		{
			var ret = ImGuiNative.ImGui_GetCursorPos();
			return ret;
		}

		/// <summary>
		/// [window-local] "
		/// </summary>
		public static float GetCursorPosX()
		{
			var ret = ImGuiNative.ImGui_GetCursorPosX();
			return ret;
		}

		/// <summary>
		/// [window-local] "
		/// </summary>
		public static float GetCursorPosY()
		{
			var ret = ImGuiNative.ImGui_GetCursorPosY();
			return ret;
		}

		/// <summary>
		/// [window-local] "
		/// </summary>
		public static void SetCursorPos(Vector2 local_pos)
		{
			ImGuiNative.ImGui_SetCursorPos(local_pos);
		}

		/// <summary>
		/// [window-local] "
		/// </summary>
		public static void SetCursorPosX(float local_x)
		{
			ImGuiNative.ImGui_SetCursorPosX(local_x);
		}

		/// <summary>
		/// [window-local] "
		/// </summary>
		public static void SetCursorPosY(float local_y)
		{
			ImGuiNative.ImGui_SetCursorPosY(local_y);
		}

		/// <summary>
		/// [window-local] initial cursor position, in window-local coordinates. Call GetCursorScreenPos() after Begin() to get the absolute coordinates version.
		/// </summary>
		public static Vector2 GetCursorStartPos()
		{
			var ret = ImGuiNative.ImGui_GetCursorStartPos();
			return ret;
		}

		/// <summary>
		/// <para>Other layout functions</para>
		/// </summary>
		/// <summary>
		/// separator, generally horizontal. inside a menu bar or in horizontal layout mode, this becomes a vertical separator.
		/// </summary>
		public static void Separator()
		{
			ImGuiNative.ImGui_Separator();
		}

		/// <summary>
		/// Implied offset_from_start_x = 0.0f, spacing = -1.0f
		/// </summary>
		public static void SameLine()
		{
			ImGuiNative.ImGui_SameLine();
		}

		/// <summary>
		/// Implied offset_from_start_x = 0.0f, spacing = -1.0f
		/// </summary>
		public static void SameLine(float offset_from_start_x)
		{
			float spacing = -1.0f;

			ImGuiNative.ImGui_SameLineEx(offset_from_start_x, spacing);
		}
		/// <summary>
		/// Implied offset_from_start_x = 0.0f, spacing = -1.0f
		/// </summary>
		public static void SameLine(float offset_from_start_x, float spacing)
		{
			ImGuiNative.ImGui_SameLineEx(offset_from_start_x, spacing);
		}

		/// <summary>
		/// undo a SameLine() or force a new line when in a horizontal-layout context.
		/// </summary>
		public static void NewLine()
		{
			ImGuiNative.ImGui_NewLine();
		}

		/// <summary>
		/// add vertical spacing.
		/// </summary>
		public static void Spacing()
		{
			ImGuiNative.ImGui_Spacing();
		}

		/// <summary>
		/// add a dummy item of given size. unlike InvisibleButton(), Dummy() won't take the mouse click or be navigable into.
		/// </summary>
		public static void Dummy(Vector2 size)
		{
			ImGuiNative.ImGui_Dummy(size);
		}

		/// <summary>
		/// Implied indent_w = 0.0f
		/// </summary>
		public static void Indent()
		{
			ImGuiNative.ImGui_Indent();
		}

		/// <summary>
		/// Implied indent_w = 0.0f
		/// </summary>
		public static void Indent(float indent_w)
		{
			ImGuiNative.ImGui_IndentEx(indent_w);
		}

		/// <summary>
		/// Implied indent_w = 0.0f
		/// </summary>
		public static void Unindent()
		{
			ImGuiNative.ImGui_Unindent();
		}

		/// <summary>
		/// Implied indent_w = 0.0f
		/// </summary>
		public static void Unindent(float indent_w)
		{
			ImGuiNative.ImGui_UnindentEx(indent_w);
		}

		/// <summary>
		/// lock horizontal starting position
		/// </summary>
		public static void BeginGroup()
		{
			ImGuiNative.ImGui_BeginGroup();
		}

		/// <summary>
		/// unlock horizontal starting position + capture the whole group bounding box into one "item" (so you can use IsItemHovered() or layout primitives such as SameLine() on whole group, etc.)
		/// </summary>
		public static void EndGroup()
		{
			ImGuiNative.ImGui_EndGroup();
		}

		/// <summary>
		/// vertically align upcoming text baseline to FramePadding.y so that it will align properly to regularly framed items (call if you have text on a line before a framed item)
		/// </summary>
		public static void AlignTextToFramePadding()
		{
			ImGuiNative.ImGui_AlignTextToFramePadding();
		}

		/// <summary>
		/// ~ FontSize
		/// </summary>
		public static float GetTextLineHeight()
		{
			var ret = ImGuiNative.ImGui_GetTextLineHeight();
			return ret;
		}

		/// <summary>
		/// ~ FontSize + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of text)
		/// </summary>
		public static float GetTextLineHeightWithSpacing()
		{
			var ret = ImGuiNative.ImGui_GetTextLineHeightWithSpacing();
			return ret;
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2
		/// </summary>
		public static float GetFrameHeight()
		{
			var ret = ImGuiNative.ImGui_GetFrameHeight();
			return ret;
		}

		/// <summary>
		/// ~ FontSize + style.FramePadding.y * 2 + style.ItemSpacing.y (distance in pixels between 2 consecutive lines of framed widgets)
		/// </summary>
		public static float GetFrameHeightWithSpacing()
		{
			var ret = ImGuiNative.ImGui_GetFrameHeightWithSpacing();
			return ret;
		}

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
		public static void PushID(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiNative.ImGui_PushID(native_str_id);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}

		/// <summary>
		/// push string into the ID stack (will hash string).
		/// </summary>
		public static void PushIDStr(ReadOnlySpan<char> str_id_begin, ReadOnlySpan<char> str_id_end)
		{
			// Marshaling 'str_id_begin' to native string
			byte* native_str_id_begin;
			var str_id_begin_byteCount = 0;
			if (str_id_begin != null)
			{
				str_id_begin_byteCount = Encoding.UTF8.GetByteCount(str_id_begin);
				if (str_id_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id_begin = Util.Allocate(str_id_begin_byteCount + 1);
				}
				else
				{
					var native_str_id_begin_stackBytes = stackalloc byte[str_id_begin_byteCount + 1];
					native_str_id_begin = native_str_id_begin_stackBytes;
				}
				var str_id_begin_offset = Util.GetUtf8(str_id_begin, native_str_id_begin, str_id_begin_byteCount);
				native_str_id_begin[str_id_begin_offset] = 0;
			}
			else native_str_id_begin = null;

			// Marshaling 'str_id_end' to native string
			byte* native_str_id_end;
			var str_id_end_byteCount = 0;
			if (str_id_end != null)
			{
				str_id_end_byteCount = Encoding.UTF8.GetByteCount(str_id_end);
				if (str_id_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id_end = Util.Allocate(str_id_end_byteCount + 1);
				}
				else
				{
					var native_str_id_end_stackBytes = stackalloc byte[str_id_end_byteCount + 1];
					native_str_id_end = native_str_id_end_stackBytes;
				}
				var str_id_end_offset = Util.GetUtf8(str_id_end, native_str_id_end, str_id_end_byteCount);
				native_str_id_end[str_id_end_offset] = 0;
			}
			else native_str_id_end = null;

			ImGuiNative.ImGui_PushIDStr(native_str_id_begin, native_str_id_end);
			if (str_id_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id_begin);
			}
			if (str_id_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id_end);
			}
		}

		/// <summary>
		/// push pointer into the ID stack (will hash pointer).
		/// </summary>
		public static void PushIDPtr(IntPtr ptr_id)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			ImGuiNative.ImGui_PushIDPtr(native_ptr_id);
		}

		/// <summary>
		/// push integer into the ID stack (will hash integer).
		/// </summary>
		public static void PushIDInt(int int_id)
		{
			ImGuiNative.ImGui_PushIDInt(int_id);
		}

		/// <summary>
		/// pop from the ID stack.
		/// </summary>
		public static void PopID()
		{
			ImGuiNative.ImGui_PopID();
		}

		/// <summary>
		/// calculate unique ID (hash of whole ID stack + given parameter). e.g. if you want to query into ImGuiStorage yourself
		/// </summary>
		public static uint GetID(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_GetID(native_str_id);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret;
		}

		public static uint GetIDStr(ReadOnlySpan<char> str_id_begin, ReadOnlySpan<char> str_id_end)
		{
			// Marshaling 'str_id_begin' to native string
			byte* native_str_id_begin;
			var str_id_begin_byteCount = 0;
			if (str_id_begin != null)
			{
				str_id_begin_byteCount = Encoding.UTF8.GetByteCount(str_id_begin);
				if (str_id_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id_begin = Util.Allocate(str_id_begin_byteCount + 1);
				}
				else
				{
					var native_str_id_begin_stackBytes = stackalloc byte[str_id_begin_byteCount + 1];
					native_str_id_begin = native_str_id_begin_stackBytes;
				}
				var str_id_begin_offset = Util.GetUtf8(str_id_begin, native_str_id_begin, str_id_begin_byteCount);
				native_str_id_begin[str_id_begin_offset] = 0;
			}
			else native_str_id_begin = null;

			// Marshaling 'str_id_end' to native string
			byte* native_str_id_end;
			var str_id_end_byteCount = 0;
			if (str_id_end != null)
			{
				str_id_end_byteCount = Encoding.UTF8.GetByteCount(str_id_end);
				if (str_id_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id_end = Util.Allocate(str_id_end_byteCount + 1);
				}
				else
				{
					var native_str_id_end_stackBytes = stackalloc byte[str_id_end_byteCount + 1];
					native_str_id_end = native_str_id_end_stackBytes;
				}
				var str_id_end_offset = Util.GetUtf8(str_id_end, native_str_id_end, str_id_end_byteCount);
				native_str_id_end[str_id_end_offset] = 0;
			}
			else native_str_id_end = null;

			var ret = ImGuiNative.ImGui_GetIDStr(native_str_id_begin, native_str_id_end);
			if (str_id_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id_begin);
			}
			if (str_id_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id_end);
			}
			return ret;
		}

		public static uint GetIDPtr(IntPtr ptr_id)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			var ret = ImGuiNative.ImGui_GetIDPtr(native_ptr_id);
			return ret;
		}

		public static uint GetIDInt(int int_id)
		{
			var ret = ImGuiNative.ImGui_GetIDInt(int_id);
			return ret;
		}

		/// <summary>
		/// <para>Widgets: Text</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_TextUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// <para>Widgets: Text</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public static void TextUnformatted(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImGuiNative.ImGui_TextUnformattedEx(native_text, native_text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		/// <summary>
		/// formatted text
		/// </summary>
		public static void Text(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_Text(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();
		/// </summary>
		public static void TextColored(Vector4 col, ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_TextColored(col, native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, col); Text(fmt, ...); PopStyleColor();
		/// </summary>
		public static void TextColoredUnformatted(Vector4 col, ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_TextColoredUnformatted(col, native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();
		/// </summary>
		public static void TextDisabled(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_TextDisabled(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// shortcut for PushStyleColor(ImGuiCol_Text, style.Colors[ImGuiCol_TextDisabled]); Text(fmt, ...); PopStyleColor();
		/// </summary>
		public static void TextDisabledUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_TextDisabledUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().
		/// </summary>
		public static void TextWrapped(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_TextWrapped(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// shortcut for PushTextWrapPos(0.0f); Text(fmt, ...); PopTextWrapPos();. Note that this won't work on an auto-resizing window if there's no other widgets to extend the window width, yoy may need to set a size using SetNextWindowSize().
		/// </summary>
		public static void TextWrappedUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_TextWrappedUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets
		/// </summary>
		public static void LabelText(ReadOnlySpan<char> label, ReadOnlySpan<char> fmt)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_LabelText(native_label, native_fmt);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// display text+label aligned the same way as value+label widgets
		/// </summary>
		public static void LabelTextUnformatted(ReadOnlySpan<char> label, ReadOnlySpan<char> text)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_LabelTextUnformatted(native_label, native_text);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// shortcut for Bullet()+Text()
		/// </summary>
		public static void BulletText(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_BulletText(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// shortcut for Bullet()+Text()
		/// </summary>
		public static void BulletTextUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_BulletTextUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// currently: formatted text with an horizontal line
		/// </summary>
		public static void SeparatorText(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ImGui_SeparatorText(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// <para>Widgets: Main</para>
		/// <para>- Most widgets return true when the value has been changed or when pressed/selected</para>
		/// <para>- You may also use one of the many IsItemXXX functions (e.g. IsItemActive, IsItemHovered, etc.) to query widget state.</para>
		/// </summary>
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool Button(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_Button(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Main</para>
		/// <para>- Most widgets return true when the value has been changed or when pressed/selected</para>
		/// <para>- You may also use one of the many IsItemXXX functions (e.g. IsItemActive, IsItemHovered, etc.) to query widget state.</para>
		/// </summary>
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool Button(ReadOnlySpan<char> label, Vector2 size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_ButtonEx(native_label, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// button with (FramePadding.y == 0) to easily embed within text
		/// </summary>
		public static bool SmallButton(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_SmallButton(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)
		/// </summary>
		public static bool InvisibleButton(ReadOnlySpan<char> str_id, Vector2 size)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiButtonFlags flags = (ImGuiButtonFlags)0;

			var ret = ImGuiNative.ImGui_InvisibleButton(native_str_id, size, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// flexible button behavior without the visuals, frequently useful to build custom behaviors using the public api (along with IsItemActive, IsItemHovered, etc.)
		/// </summary>
		public static bool InvisibleButton(ReadOnlySpan<char> str_id, Vector2 size, ImGuiButtonFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_InvisibleButton(native_str_id, size, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// square button with an arrow shape
		/// </summary>
		public static bool ArrowButton(ReadOnlySpan<char> str_id, ImGuiDir dir)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_ArrowButton(native_str_id, dir);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		public static bool Checkbox(ReadOnlySpan<char> label, ref bool v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native bool
			var native_v_val = v ? (byte)1 : (byte)0;
			var native_v = &native_v_val;

			var ret = ImGuiNative.ImGui_Checkbox(native_label, native_v);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			v = native_v_val != 0;
			return ret != 0;
		}

		public static bool CheckboxFlagsIntPtr(ReadOnlySpan<char> label, ref int flags, int flags_value)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_flags = &flags)
			{
				var ret = ImGuiNative.ImGui_CheckboxFlagsIntPtr(native_label, native_flags, flags_value);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static bool CheckboxFlagsUintPtr(ReadOnlySpan<char> label, ref uint flags, uint flags_value)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (uint* native_flags = &flags)
			{
				var ret = ImGuiNative.ImGui_CheckboxFlagsUintPtr(native_label, native_flags, flags_value);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// use with e.g. if (RadioButton("one", my_value==1)) { my_value = 1; }
		/// </summary>
		public static bool RadioButton(ReadOnlySpan<char> label, bool active)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'active' to native bool
			var native_active = active ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_RadioButton(native_label, native_active);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// shortcut to handle the above pattern when value is an integer
		/// </summary>
		public static bool RadioButtonIntPtr(ReadOnlySpan<char> label, ref int v, int v_button)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_RadioButtonIntPtr(native_label, native_v, v_button);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static void ProgressBar(float fraction)
		{
			Vector2 size_arg = new Vector2(-float.MinValue, 0.0f);

			byte* overlay = null;

			ImGuiNative.ImGui_ProgressBar(fraction, size_arg, overlay);
		}
		public static void ProgressBar(float fraction, Vector2 size_arg)
		{
			byte* overlay = null;

			ImGuiNative.ImGui_ProgressBar(fraction, size_arg, overlay);
		}
		public static void ProgressBar(float fraction, Vector2 size_arg, ReadOnlySpan<char> overlay)
		{
			// Marshaling 'overlay' to native string
			byte* native_overlay;
			var overlay_byteCount = 0;
			if (overlay != null)
			{
				overlay_byteCount = Encoding.UTF8.GetByteCount(overlay);
				if (overlay_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay = Util.Allocate(overlay_byteCount + 1);
				}
				else
				{
					var native_overlay_stackBytes = stackalloc byte[overlay_byteCount + 1];
					native_overlay = native_overlay_stackBytes;
				}
				var overlay_offset = Util.GetUtf8(overlay, native_overlay, overlay_byteCount);
				native_overlay[overlay_offset] = 0;
			}
			else native_overlay = null;

			ImGuiNative.ImGui_ProgressBar(fraction, size_arg, native_overlay);
			if (overlay_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay);
			}
		}

		/// <summary>
		/// draw a small circle + keep the cursor on the same line. advance cursor x position by GetTreeNodeToLabelSpacing(), same distance that TreeNode() uses
		/// </summary>
		public static void Bullet()
		{
			ImGuiNative.ImGui_Bullet();
		}

		/// <summary>
		/// hyperlink text button, return true when clicked
		/// </summary>
		public static bool TextLink(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_TextLink(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied url = NULL
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ImGui_TextLinkOpenURL(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// Implied url = NULL
		/// </summary>
		public static void TextLinkOpenURL(ReadOnlySpan<char> label, ReadOnlySpan<char> url)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'url' to native string
			byte* native_url;
			var url_byteCount = 0;
			if (url != null)
			{
				url_byteCount = Encoding.UTF8.GetByteCount(url);
				if (url_byteCount > Util.StackAllocationSizeLimit)
				{
					native_url = Util.Allocate(url_byteCount + 1);
				}
				else
				{
					var native_url_stackBytes = stackalloc byte[url_byteCount + 1];
					native_url = native_url_stackBytes;
				}
				var url_offset = Util.GetUtf8(url, native_url, url_byteCount);
				native_url[url_offset] = 0;
			}
			else native_url = null;

			ImGuiNative.ImGui_TextLinkOpenURLEx(native_label, native_url);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (url_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_url);
			}
		}

		/// <summary>
		/// <para>Widgets: Images</para>
		/// <para>- Read about ImTextureID here: https://github.com/ocornut/imgui/wiki/Image-Loading-and-Displaying-Examples</para>
		/// <para>- 'uv0' and 'uv1' are texture coordinates. Read about them from the same link above.</para>
		/// <para>- Note that Image() may add +2.0f to provided size if a border is visible, ImageButton() adds style.FramePadding*2.0f to provided size.</para>
		/// </summary>
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), tint_col = ImVec4(1, 1, 1, 1), border_col = ImVec4(0, 0, 0, 0)
		/// </summary>
		public static void Image(IntPtr user_texture_id, Vector2 image_size)
		{
			ImGuiNative.ImGui_Image(user_texture_id, image_size);
		}

		/// <summary>
		/// <para>Widgets: Images</para>
		/// <para>- Read about ImTextureID here: https://github.com/ocornut/imgui/wiki/Image-Loading-and-Displaying-Examples</para>
		/// <para>- 'uv0' and 'uv1' are texture coordinates. Read about them from the same link above.</para>
		/// <para>- Note that Image() may add +2.0f to provided size if a border is visible, ImageButton() adds style.FramePadding*2.0f to provided size.</para>
		/// </summary>
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), tint_col = ImVec4(1, 1, 1, 1), border_col = ImVec4(0, 0, 0, 0)
		/// </summary>
		public static void Image(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0)
		{
			Vector2 uv1 = new Vector2(1, 1);

			Vector4 tint_col = new Vector4(1, 1, 1, 1);

			Vector4 border_col = new Vector4();

			ImGuiNative.ImGui_ImageEx(user_texture_id, image_size, uv0, uv1, tint_col, border_col);
		}
		/// <summary>
		/// <para>Widgets: Images</para>
		/// <para>- Read about ImTextureID here: https://github.com/ocornut/imgui/wiki/Image-Loading-and-Displaying-Examples</para>
		/// <para>- 'uv0' and 'uv1' are texture coordinates. Read about them from the same link above.</para>
		/// <para>- Note that Image() may add +2.0f to provided size if a border is visible, ImageButton() adds style.FramePadding*2.0f to provided size.</para>
		/// </summary>
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), tint_col = ImVec4(1, 1, 1, 1), border_col = ImVec4(0, 0, 0, 0)
		/// </summary>
		public static void Image(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1)
		{
			Vector4 tint_col = new Vector4(1, 1, 1, 1);

			Vector4 border_col = new Vector4();

			ImGuiNative.ImGui_ImageEx(user_texture_id, image_size, uv0, uv1, tint_col, border_col);
		}
		/// <summary>
		/// <para>Widgets: Images</para>
		/// <para>- Read about ImTextureID here: https://github.com/ocornut/imgui/wiki/Image-Loading-and-Displaying-Examples</para>
		/// <para>- 'uv0' and 'uv1' are texture coordinates. Read about them from the same link above.</para>
		/// <para>- Note that Image() may add +2.0f to provided size if a border is visible, ImageButton() adds style.FramePadding*2.0f to provided size.</para>
		/// </summary>
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), tint_col = ImVec4(1, 1, 1, 1), border_col = ImVec4(0, 0, 0, 0)
		/// </summary>
		public static void Image(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 tint_col)
		{
			Vector4 border_col = new Vector4();

			ImGuiNative.ImGui_ImageEx(user_texture_id, image_size, uv0, uv1, tint_col, border_col);
		}
		/// <summary>
		/// <para>Widgets: Images</para>
		/// <para>- Read about ImTextureID here: https://github.com/ocornut/imgui/wiki/Image-Loading-and-Displaying-Examples</para>
		/// <para>- 'uv0' and 'uv1' are texture coordinates. Read about them from the same link above.</para>
		/// <para>- Note that Image() may add +2.0f to provided size if a border is visible, ImageButton() adds style.FramePadding*2.0f to provided size.</para>
		/// </summary>
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), tint_col = ImVec4(1, 1, 1, 1), border_col = ImVec4(0, 0, 0, 0)
		/// </summary>
		public static void Image(IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col)
		{
			ImGuiNative.ImGui_ImageEx(user_texture_id, image_size, uv0, uv1, tint_col, border_col);
		}

		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), bg_col = ImVec4(0, 0, 0, 0), tint_col = ImVec4(1, 1, 1, 1)
		/// </summary>
		public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 image_size)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_ImageButton(native_str_id, user_texture_id, image_size);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), bg_col = ImVec4(0, 0, 0, 0), tint_col = ImVec4(1, 1, 1, 1)
		/// </summary>
		public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			Vector2 uv1 = new Vector2(1, 1);

			Vector4 bg_col = new Vector4();

			Vector4 tint_col = new Vector4(1, 1, 1, 1);

			var ret = ImGuiNative.ImGui_ImageButtonEx(native_str_id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), bg_col = ImVec4(0, 0, 0, 0), tint_col = ImVec4(1, 1, 1, 1)
		/// </summary>
		public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			Vector4 bg_col = new Vector4();

			Vector4 tint_col = new Vector4(1, 1, 1, 1);

			var ret = ImGuiNative.ImGui_ImageButtonEx(native_str_id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), bg_col = ImVec4(0, 0, 0, 0), tint_col = ImVec4(1, 1, 1, 1)
		/// </summary>
		public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			Vector4 tint_col = new Vector4(1, 1, 1, 1);

			var ret = ImGuiNative.ImGui_ImageButtonEx(native_str_id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied uv0 = ImVec2(0, 0), uv1 = ImVec2(1, 1), bg_col = ImVec4(0, 0, 0, 0), tint_col = ImVec4(1, 1, 1, 1)
		/// </summary>
		public static bool ImageButton(ReadOnlySpan<char> str_id, IntPtr user_texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_ImageButtonEx(native_str_id, user_texture_id, image_size, uv0, uv1, bg_col, tint_col);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Combo Box (Dropdown)</para>
		/// <para>- The BeginCombo()/EndCombo() api allows you to manage your contents and selection state however you want it, by creating e.g. Selectable() items.</para>
		/// <para>- The old Combo() api are helpers over BeginCombo()/EndCombo() which are kept available for convenience purpose. This is analogous to how ListBox are created.</para>
		/// </summary>
		public static bool BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> preview_value)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'preview_value' to native string
			byte* native_preview_value;
			var preview_value_byteCount = 0;
			if (preview_value != null)
			{
				preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
				if (preview_value_byteCount > Util.StackAllocationSizeLimit)
				{
					native_preview_value = Util.Allocate(preview_value_byteCount + 1);
				}
				else
				{
					var native_preview_value_stackBytes = stackalloc byte[preview_value_byteCount + 1];
					native_preview_value = native_preview_value_stackBytes;
				}
				var preview_value_offset = Util.GetUtf8(preview_value, native_preview_value, preview_value_byteCount);
				native_preview_value[preview_value_offset] = 0;
			}
			else native_preview_value = null;

			ImGuiComboFlags flags = (ImGuiComboFlags)0;

			var ret = ImGuiNative.ImGui_BeginCombo(native_label, native_preview_value, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (preview_value_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_preview_value);
			}
			return ret != 0;
		}
		/// <summary>
		/// <para>Widgets: Combo Box (Dropdown)</para>
		/// <para>- The BeginCombo()/EndCombo() api allows you to manage your contents and selection state however you want it, by creating e.g. Selectable() items.</para>
		/// <para>- The old Combo() api are helpers over BeginCombo()/EndCombo() which are kept available for convenience purpose. This is analogous to how ListBox are created.</para>
		/// </summary>
		public static bool BeginCombo(ReadOnlySpan<char> label, ReadOnlySpan<char> preview_value, ImGuiComboFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'preview_value' to native string
			byte* native_preview_value;
			var preview_value_byteCount = 0;
			if (preview_value != null)
			{
				preview_value_byteCount = Encoding.UTF8.GetByteCount(preview_value);
				if (preview_value_byteCount > Util.StackAllocationSizeLimit)
				{
					native_preview_value = Util.Allocate(preview_value_byteCount + 1);
				}
				else
				{
					var native_preview_value_stackBytes = stackalloc byte[preview_value_byteCount + 1];
					native_preview_value = native_preview_value_stackBytes;
				}
				var preview_value_offset = Util.GetUtf8(preview_value, native_preview_value, preview_value_byteCount);
				native_preview_value[preview_value_offset] = 0;
			}
			else native_preview_value = null;

			var ret = ImGuiNative.ImGui_BeginCombo(native_label, native_preview_value, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (preview_value_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_preview_value);
			}
			return ret != 0;
		}

		/// <summary>
		/// only call EndCombo() if BeginCombo() returns true!
		/// </summary>
		public static void EndCombo()
		{
			ImGuiNative.ImGui_EndCombo();
		}

		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool ComboChar(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'items' to native string array
			var items_byteCounts = stackalloc int[items.Length];
			var items_byteCount = 0;
			for (var i = 0; i < items.Length; i++)
			{
				items_byteCounts[i] = Encoding.UTF8.GetByteCount(items[i]);
				items_byteCount += items_byteCounts[i] + 1;
			}
			var native_items_data = stackalloc byte[items_byteCount];
			var items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				var s = items[i];
				items_offset += Util.GetUtf8(s, native_items_data + items_offset, items_byteCounts[i]);
				native_items_data[items_offset++] = 0;
			}
			var native_items = stackalloc byte*[items.Length];
			items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				native_items[i] = &native_items_data[items_offset];
				items_offset += items_byteCounts[i] + 1;
			}

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ComboChar(native_label, native_current_item, native_items, items_count);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool ComboChar(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count, int popup_max_height_in_items)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'items' to native string array
			var items_byteCounts = stackalloc int[items.Length];
			var items_byteCount = 0;
			for (var i = 0; i < items.Length; i++)
			{
				items_byteCounts[i] = Encoding.UTF8.GetByteCount(items[i]);
				items_byteCount += items_byteCounts[i] + 1;
			}
			var native_items_data = stackalloc byte[items_byteCount];
			var items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				var s = items[i];
				items_offset += Util.GetUtf8(s, native_items_data + items_offset, items_byteCounts[i]);
				native_items_data[items_offset++] = 0;
			}
			var native_items = stackalloc byte*[items.Length];
			items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				native_items[i] = &native_items_data[items_offset];
				items_offset += items_byteCounts[i] + 1;
			}

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ComboCharEx(native_label, native_current_item, native_items, items_count, popup_max_height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool Combo(ReadOnlySpan<char> label, ref int current_item, ReadOnlySpan<char> items_separated_by_zeros)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'items_separated_by_zeros' to native string
			byte* native_items_separated_by_zeros;
			var items_separated_by_zeros_byteCount = 0;
			if (items_separated_by_zeros != null)
			{
				items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
				if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
				{
					native_items_separated_by_zeros = Util.Allocate(items_separated_by_zeros_byteCount + 1);
				}
				else
				{
					var native_items_separated_by_zeros_stackBytes = stackalloc byte[items_separated_by_zeros_byteCount + 1];
					native_items_separated_by_zeros = native_items_separated_by_zeros_stackBytes;
				}
				var items_separated_by_zeros_offset = Util.GetUtf8(items_separated_by_zeros, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
				native_items_separated_by_zeros[items_separated_by_zeros_offset] = 0;
			}
			else native_items_separated_by_zeros = null;

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_Combo(native_label, native_current_item, native_items_separated_by_zeros);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_items_separated_by_zeros);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool Combo(ReadOnlySpan<char> label, ref int current_item, ReadOnlySpan<char> items_separated_by_zeros, int popup_max_height_in_items)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'items_separated_by_zeros' to native string
			byte* native_items_separated_by_zeros;
			var items_separated_by_zeros_byteCount = 0;
			if (items_separated_by_zeros != null)
			{
				items_separated_by_zeros_byteCount = Encoding.UTF8.GetByteCount(items_separated_by_zeros);
				if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
				{
					native_items_separated_by_zeros = Util.Allocate(items_separated_by_zeros_byteCount + 1);
				}
				else
				{
					var native_items_separated_by_zeros_stackBytes = stackalloc byte[items_separated_by_zeros_byteCount + 1];
					native_items_separated_by_zeros = native_items_separated_by_zeros_stackBytes;
				}
				var items_separated_by_zeros_offset = Util.GetUtf8(items_separated_by_zeros, native_items_separated_by_zeros, items_separated_by_zeros_byteCount);
				native_items_separated_by_zeros[items_separated_by_zeros_offset] = 0;
			}
			else native_items_separated_by_zeros = null;

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ComboEx(native_label, native_current_item, native_items_separated_by_zeros, popup_max_height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (items_separated_by_zeros_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_items_separated_by_zeros);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool ComboCallback(ReadOnlySpan<char> label, ref int current_item, ImGui_ComboCallbackgetterDelegate getter, IntPtr user_data, int items_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ComboCallback(native_label, native_current_item, getter, native_user_data, items_count);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool ComboCallback(ReadOnlySpan<char> label, ref int current_item, ImGui_ComboCallbackExgetterDelegate getter, IntPtr user_data, int items_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			int popup_max_height_in_items = -1;

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ComboCallbackEx(native_label, native_current_item, getter, native_user_data, items_count, popup_max_height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied popup_max_height_in_items = -1
		/// </summary>
		public static bool ComboCallback(ReadOnlySpan<char> label, ref int current_item, ImGui_ComboCallbackExgetterDelegate getter, IntPtr user_data, int items_count, int popup_max_height_in_items)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ComboCallbackEx(native_label, native_current_item, getter, native_user_data, items_count, popup_max_height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

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
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

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
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_min = 0.0f;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloatEx(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
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
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloatEx(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
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
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloatEx(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
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
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloatEx(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
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
		public static bool DragFloat(ReadOnlySpan<char> label, ref float v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloatEx(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat2(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_min = 0.0f;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat2Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat2Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat2Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat2Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat2Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat3(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_min = 0.0f;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat3Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat3Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat3Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat3Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat3Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat4(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_min = 0.0f;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat4Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat4Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat4Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat4Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool DragFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragFloat4Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2(native_label, native_v_current_min, native_v_current_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_min = 0.0f;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_max = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'format_max' to native string
			byte* native_format_max;
			var format_max_byteCount = 0;
			if (format_max != null)
			{
				format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format_max = Util.Allocate(format_max_byteCount + 1);
				}
				else
				{
					var native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
					native_format_max = native_format_max_stackBytes;
				}
				var format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
				native_format_max[format_max_offset] = 0;
			}
			else native_format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format_max);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0.0f, v_max = 0.0f, format = "%.3f", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragFloatRange2(ReadOnlySpan<char> label, ref float v_current_min, ref float v_current_max, float v_speed, float v_min, float v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'format_max' to native string
			byte* native_format_max;
			var format_max_byteCount = 0;
			if (format_max != null)
			{
				format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format_max = Util.Allocate(format_max_byteCount + 1);
				}
				else
				{
					var native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
					native_format_max = native_format_max_stackBytes;
				}
				var format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
				native_format_max[format_max_offset] = 0;
			}
			else native_format_max = null;

			fixed (float* native_v_current_min = &v_current_min)
			fixed (float* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragFloatRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format_max);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragInt(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			int v_min = 0;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragIntEx(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragIntEx(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragIntEx(native_label, native_v, v_speed, v_min, v_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragIntEx(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt(ReadOnlySpan<char> label, ref int v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_DragIntEx(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt2(ReadOnlySpan<char> label, int[] v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_DragInt2(native_label, native_v);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt2(ReadOnlySpan<char> label, int[] v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			int v_min = 0;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt2Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt2(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt2Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt2(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt2Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt2(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt2Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt2(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_DragInt2Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt3(ReadOnlySpan<char> label, int[] v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_DragInt3(native_label, native_v);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt3(ReadOnlySpan<char> label, int[] v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			int v_min = 0;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt3Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt3(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt3Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt3(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt3Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt3(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt3Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt3(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_DragInt3Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt4(ReadOnlySpan<char> label, int[] v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_DragInt4(native_label, native_v);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt4(ReadOnlySpan<char> label, int[] v, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			int v_min = 0;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt4Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt4(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt4Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt4(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt4Ex(native_label, native_v, v_speed, v_min, v_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(format);
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt4(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragInt4Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", flags = 0
		/// </summary>
		public static bool DragInt4(ReadOnlySpan<char> label, int[] v, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_DragInt4Ex(native_label, native_v, v_speed, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2(native_label, native_v_current_min, native_v_current_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			int v_min = 0;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			int v_max = 0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%d");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%d", format, format_byteCount);
			format[format_offset] = 0;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			byte* format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'format_max' to native string
			byte* native_format_max;
			var format_max_byteCount = 0;
			if (format_max != null)
			{
				format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format_max = Util.Allocate(format_max_byteCount + 1);
				}
				else
				{
					var native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
					native_format_max = native_format_max_stackBytes;
				}
				var format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
				native_format_max[format_max_offset] = 0;
			}
			else native_format_max = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format_max);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_speed = 1.0f, v_min = 0, v_max = 0, format = "%d", format_max = NULL, flags = 0
		/// </summary>
		public static bool DragIntRange2(ReadOnlySpan<char> label, ref int v_current_min, ref int v_current_max, float v_speed, int v_min, int v_max, ReadOnlySpan<char> format, ReadOnlySpan<char> format_max, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'format_max' to native string
			byte* native_format_max;
			var format_max_byteCount = 0;
			if (format_max != null)
			{
				format_max_byteCount = Encoding.UTF8.GetByteCount(format_max);
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format_max = Util.Allocate(format_max_byteCount + 1);
				}
				else
				{
					var native_format_max_stackBytes = stackalloc byte[format_max_byteCount + 1];
					native_format_max = native_format_max_stackBytes;
				}
				var format_max_offset = Util.GetUtf8(format_max, native_format_max, format_max_byteCount);
				native_format_max[format_max_offset] = 0;
			}
			else native_format_max = null;

			fixed (int* native_v_current_min = &v_current_min)
			fixed (int* native_v_current_max = &v_current_max)
			{
				var ret = ImGuiNative.ImGui_DragIntRange2Ex(native_label, native_v_current_min, native_v_current_max, v_speed, v_min, v_max, native_format, native_format_max, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				if (format_max_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format_max);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			var ret = ImGuiNative.ImGui_DragScalar(native_label, data_type, native_p_data);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			void* p_min = null;

			void* p_max = null;

			byte* format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarEx(native_label, data_type, native_p_data, v_speed, p_min, p_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			void* p_max = null;

			byte* format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarEx(native_label, data_type, native_p_data, v_speed, native_p_min, p_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			byte* format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarEx(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarEx(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_DragScalarEx(native_label, data_type, native_p_data, v_speed, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			var ret = ImGuiNative.ImGui_DragScalarN(native_label, data_type, native_p_data, components);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			void* p_min = null;

			void* p_max = null;

			byte* format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarNEx(native_label, data_type, native_p_data, components, v_speed, p_min, p_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			void* p_max = null;

			byte* format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarNEx(native_label, data_type, native_p_data, components, v_speed, native_p_min, p_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			byte* format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarNEx(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_DragScalarNEx(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied v_speed = 1.0f, p_min = NULL, p_max = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool DragScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_DragScalarNEx(native_label, data_type, native_p_data, components, v_speed, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

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
		public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat(native_label, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

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
		public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloatEx(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
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
		public static bool SliderFloat(ReadOnlySpan<char> label, ref float v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloatEx(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat2(native_label, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat2Ex(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat2(ReadOnlySpan<char> label, ref Vector2 v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat2Ex(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat3(native_label, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat3Ex(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat3(ReadOnlySpan<char> label, ref Vector3 v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat3Ex(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat4(native_label, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat4Ex(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool SliderFloat4(ReadOnlySpan<char> label, ref Vector4 v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderFloat4Ex(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_degrees_min = -360.0f, v_degrees_max = +360.0f, format = "%.0f deg", flags = 0
		/// </summary>
		public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_v_rad = &v_rad)
			{
				var ret = ImGuiNative.ImGui_SliderAngle(native_label, native_v_rad);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied v_degrees_min = -360.0f, v_degrees_max = +360.0f, format = "%.0f deg", flags = 0
		/// </summary>
		public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float v_degrees_max = +360.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.0f deg", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_rad = &v_rad)
			{
				var ret = ImGuiNative.ImGui_SliderAngleEx(native_label, native_v_rad, v_degrees_min, v_degrees_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_degrees_min = -360.0f, v_degrees_max = +360.0f, format = "%.0f deg", flags = 0
		/// </summary>
		public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min, float v_degrees_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.0f deg");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.0f deg", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_rad = &v_rad)
			{
				var ret = ImGuiNative.ImGui_SliderAngleEx(native_label, native_v_rad, v_degrees_min, v_degrees_max, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_degrees_min = -360.0f, v_degrees_max = +360.0f, format = "%.0f deg", flags = 0
		/// </summary>
		public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min, float v_degrees_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v_rad = &v_rad)
			{
				var ret = ImGuiNative.ImGui_SliderAngleEx(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied v_degrees_min = -360.0f, v_degrees_max = +360.0f, format = "%.0f deg", flags = 0
		/// </summary>
		public static bool SliderAngle(ReadOnlySpan<char> label, ref float v_rad, float v_degrees_min, float v_degrees_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v_rad = &v_rad)
			{
				var ret = ImGuiNative.ImGui_SliderAngleEx(native_label, native_v_rad, v_degrees_min, v_degrees_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderInt(native_label, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderIntEx(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt(ReadOnlySpan<char> label, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_SliderIntEx(native_label, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt2(ReadOnlySpan<char> label, int[] v, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_SliderInt2(native_label, native_v, v_min, v_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt2(ReadOnlySpan<char> label, int[] v, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_SliderInt2Ex(native_label, native_v, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt2(ReadOnlySpan<char> label, int[] v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_SliderInt2Ex(native_label, native_v, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt3(ReadOnlySpan<char> label, int[] v, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_SliderInt3(native_label, native_v, v_min, v_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt3(ReadOnlySpan<char> label, int[] v, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_SliderInt3Ex(native_label, native_v, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt3(ReadOnlySpan<char> label, int[] v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_SliderInt3Ex(native_label, native_v, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt4(ReadOnlySpan<char> label, int[] v, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_SliderInt4(native_label, native_v, v_min, v_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt4(ReadOnlySpan<char> label, int[] v, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_SliderInt4Ex(native_label, native_v, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool SliderInt4(ReadOnlySpan<char> label, int[] v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_SliderInt4Ex(native_label, native_v, v_min, v_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			var ret = ImGuiNative.ImGui_SliderScalar(native_label, data_type, native_p_data, native_p_min, native_p_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_SliderScalarEx(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool SliderScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_SliderScalarEx(native_label, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			var ret = ImGuiNative.ImGui_SliderScalarN(native_label, data_type, native_p_data, components, native_p_min, native_p_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_SliderScalarNEx(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool SliderScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_SliderScalarNEx(native_label, data_type, native_p_data, components, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float v_min, float v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_VSliderFloat(native_label, size, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float v_min, float v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_VSliderFloatEx(native_label, size, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool VSliderFloat(ReadOnlySpan<char> label, Vector2 size, ref float v, float v_min, float v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_VSliderFloatEx(native_label, size, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int v_min, int v_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_VSliderInt(native_label, size, native_v, v_min, v_max);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int v_min, int v_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_VSliderIntEx(native_label, size, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%d", flags = 0
		/// </summary>
		public static bool VSliderInt(ReadOnlySpan<char> label, Vector2 size, ref int v, int v_min, int v_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_VSliderIntEx(native_label, size, native_v, v_min, v_max, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			var ret = ImGuiNative.ImGui_VSliderScalar(native_label, size, data_type, native_p_data, native_p_min, native_p_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiSliderFlags flags = (ImGuiSliderFlags)0;

			var ret = ImGuiNative.ImGui_VSliderScalarEx(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied format = NULL, flags = 0
		/// </summary>
		public static bool VSliderScalar(ReadOnlySpan<char> label, Vector2 size, ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_VSliderScalarEx(native_label, size, data_type, native_p_data, native_p_min, native_p_max, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Input with Keyboard</para>
		/// <para>- If you want to use InputText() with std::string or any custom dynamic string type, see misc/cpp/imgui_stdlib.h and comments in imgui_demo.cpp.</para>
		/// <para>- Most of the ImGuiInputTextFlags flags are only useful for InputText() and not for InputFloatX, InputIntX, InputDouble etc.</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint buf_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputText(native_label, native_buf, buf_size, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// <para>Widgets: Input with Keyboard</para>
		/// <para>- If you want to use InputText() with std::string or any custom dynamic string type, see misc/cpp/imgui_stdlib.h and comments in imgui_demo.cpp.</para>
		/// <para>- Most of the ImGuiInputTextFlags flags are only useful for InputText() and not for InputFloatX, InputIntX, InputDouble etc.</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint buf_size, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputText(native_label, native_buf, buf_size, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// <para>Widgets: Input with Keyboard</para>
		/// <para>- If you want to use InputText() with std::string or any custom dynamic string type, see misc/cpp/imgui_stdlib.h and comments in imgui_demo.cpp.</para>
		/// <para>- Most of the ImGuiInputTextFlags flags are only useful for InputText() and not for InputFloatX, InputIntX, InputDouble etc.</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			void* user_data = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextEx(native_label, native_buf, buf_size, flags, callback, user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// <para>Widgets: Input with Keyboard</para>
		/// <para>- If you want to use InputText() with std::string or any custom dynamic string type, see misc/cpp/imgui_stdlib.h and comments in imgui_demo.cpp.</para>
		/// <para>- Most of the ImGuiInputTextFlags flags are only useful for InputText() and not for InputFloatX, InputIntX, InputDouble etc.</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputText(ReadOnlySpan<char> label, byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextEx(native_label, native_buf, buf_size, flags, callback, native_user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint buf_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextMultiline(native_label, native_buf, buf_size);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint buf_size, Vector2 size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			ImGuiInputTextCallback callback = null;

			void* user_data = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextMultilineEx(native_label, native_buf, buf_size, size, flags, callback, user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInputTextCallback callback = null;

			void* user_data = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextMultilineEx(native_label, native_buf, buf_size, size, flags, callback, user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			void* user_data = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextMultilineEx(native_label, native_buf, buf_size, size, flags, callback, user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied size = ImVec2(0, 0), flags = 0, callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextMultiline(ReadOnlySpan<char> label, byte[] buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextMultilineEx(native_label, native_buf, buf_size, size, flags, callback, native_user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint buf_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextWithHint(native_label, native_hint, native_buf, buf_size, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint buf_size, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextWithHint(native_label, native_hint, native_buf, buf_size, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			void* user_data = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextWithHintEx(native_label, native_hint, native_buf, buf_size, flags, callback, user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHint(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiNative.ImGui_InputTextWithHintEx(native_label, native_hint, native_buf, buf_size, flags, callback, native_user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied step = 0.0f, step_fast = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat(ReadOnlySpan<char> label, ref float v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied step = 0.0f, step_fast = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float step_fast = 0.0f;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloatEx(native_label, native_v, step, step_fast, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 0.0f, step_fast = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float step_fast)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.3f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.3f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloatEx(native_label, native_v, step, step_fast, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 0.0f, step_fast = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float step_fast, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloatEx(native_label, native_v, step, step_fast, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 0.0f, step_fast = 0.0f, format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat(ReadOnlySpan<char> label, ref float v, float step, float step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (float* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloatEx(native_label, native_v, step, step_fast, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat2(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat2Ex(native_label, native_v, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat2(ReadOnlySpan<char> label, ref Vector2 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector2* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat2Ex(native_label, native_v, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat3(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat3Ex(native_label, native_v, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat3(ReadOnlySpan<char> label, ref Vector3 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector3* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat3Ex(native_label, native_v, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat4(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat4Ex(native_label, native_v, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied format = "%.3f", flags = 0
		/// </summary>
		public static bool InputFloat4(ReadOnlySpan<char> label, ref Vector4 v, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (Vector4* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputFloat4Ex(native_label, native_v, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied step = 1, step_fast = 100, flags = 0
		/// </summary>
		public static bool InputInt(ReadOnlySpan<char> label, ref int v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputInt(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied step = 1, step_fast = 100, flags = 0
		/// </summary>
		public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			int step_fast = 100;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputIntEx(native_label, native_v, step, step_fast, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 1, step_fast = 100, flags = 0
		/// </summary>
		public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step, int step_fast)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputIntEx(native_label, native_v, step, step_fast, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 1, step_fast = 100, flags = 0
		/// </summary>
		public static bool InputInt(ReadOnlySpan<char> label, ref int v, int step, int step_fast, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (int* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputIntEx(native_label, native_v, step, step_fast, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static bool InputInt2(ReadOnlySpan<char> label, int[] v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputInt2(native_label, native_v, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		public static bool InputInt2(ReadOnlySpan<char> label, int[] v, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_InputInt2(native_label, native_v, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		public static bool InputInt3(ReadOnlySpan<char> label, int[] v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputInt3(native_label, native_v, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		public static bool InputInt3(ReadOnlySpan<char> label, int[] v, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_InputInt3(native_label, native_v, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		public static bool InputInt4(ReadOnlySpan<char> label, int[] v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputInt4(native_label, native_v, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		public static bool InputInt4(ReadOnlySpan<char> label, int[] v, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'v' to native int array
			var native_v = stackalloc int[v.Length];
			for (var i = 0; i < v.Length; i++)
			{
				native_v[i] = v[i];
			}

			var ret = ImGuiNative.ImGui_InputInt4(native_label, native_v, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied step = 0.0, step_fast = 0.0, format = "%.6f", flags = 0
		/// </summary>
		public static bool InputDouble(ReadOnlySpan<char> label, ref double v)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (double* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputDouble(native_label, native_v);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied step = 0.0, step_fast = 0.0, format = "%.6f", flags = 0
		/// </summary>
		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			double step_fast = 0.0;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.6f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (double* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputDoubleEx(native_label, native_v, step, step_fast, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 0.0, step_fast = 0.0, format = "%.6f", flags = 0
		/// </summary>
		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double step_fast)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* format;
			var format_byteCount = Encoding.UTF8.GetByteCount("%.6f");
			if (format_byteCount > Util.StackAllocationSizeLimit)
				format = Util.Allocate(format_byteCount + 1);
			else
			{
				var format_stackBytes = stackalloc byte[format_byteCount + 1];
				format = format_stackBytes;
			}
			var format_offset = Util.GetUtf8("%.6f", format, format_byteCount);
			format[format_offset] = 0;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (double* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputDoubleEx(native_label, native_v, step, step_fast, format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
					Util.Free(format);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 0.0, step_fast = 0.0, format = "%.6f", flags = 0
		/// </summary>
		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double step_fast, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			fixed (double* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputDoubleEx(native_label, native_v, step, step_fast, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied step = 0.0, step_fast = 0.0, format = "%.6f", flags = 0
		/// </summary>
		public static bool InputDouble(ReadOnlySpan<char> label, ref double v, double step, double step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (double* native_v = &v)
			{
				var ret = ImGuiNative.ImGui_InputDoubleEx(native_label, native_v, step, step_fast, native_format, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			var ret = ImGuiNative.ImGui_InputScalar(native_label, data_type, native_p_data);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			void* p_step_fast = null;

			byte* format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputScalarEx(native_label, data_type, native_p_data, native_p_step, p_step_fast, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			// Marshaling 'p_step_fast' to native void pointer
			var native_p_step_fast = p_step_fast.ToPointer();

			byte* format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputScalarEx(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			// Marshaling 'p_step_fast' to native void pointer
			var native_p_step_fast = p_step_fast.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputScalarEx(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalar(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			// Marshaling 'p_step_fast' to native void pointer
			var native_p_step_fast = p_step_fast.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_InputScalarEx(native_label, data_type, native_p_data, native_p_step, native_p_step_fast, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			var ret = ImGuiNative.ImGui_InputScalarN(native_label, data_type, native_p_data, components);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			void* p_step_fast = null;

			byte* format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputScalarNEx(native_label, data_type, native_p_data, components, native_p_step, p_step_fast, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			// Marshaling 'p_step_fast' to native void pointer
			var native_p_step_fast = p_step_fast.ToPointer();

			byte* format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputScalarNEx(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			// Marshaling 'p_step_fast' to native void pointer
			var native_p_step_fast = p_step_fast.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			ImGuiInputTextFlags flags = (ImGuiInputTextFlags)0;

			var ret = ImGuiNative.ImGui_InputScalarNEx(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_step = NULL, p_step_fast = NULL, format = NULL, flags = 0
		/// </summary>
		public static bool InputScalarN(ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, int components, IntPtr p_step, IntPtr p_step_fast, ReadOnlySpan<char> format, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_step' to native void pointer
			var native_p_step = p_step.ToPointer();

			// Marshaling 'p_step_fast' to native void pointer
			var native_p_step_fast = p_step_fast.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiNative.ImGui_InputScalarNEx(native_label, data_type, native_p_data, components, native_p_step, native_p_step_fast, native_format, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Color Editor/Picker (tip: the ColorEdit* functions have a little color square that can be left-clicked to open a picker, and right-clicked to open an option menu.)</para>
		/// <para>- Note that in C++ a 'float v[X]' function argument is the _same_ as 'float* v', the array syntax is just a way to document the number of elements that are expected to be accessible.</para>
		/// <para>- You can pass the address of a first float element out of a contiguous structure, e.g. &amp;myvector.x</para>
		/// </summary>
		public static bool ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;

			fixed (Vector3* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorEdit3(native_label, native_col, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// <para>Widgets: Color Editor/Picker (tip: the ColorEdit* functions have a little color square that can be left-clicked to open a picker, and right-clicked to open an option menu.)</para>
		/// <para>- Note that in C++ a 'float v[X]' function argument is the _same_ as 'float* v', the array syntax is just a way to document the number of elements that are expected to be accessible.</para>
		/// <para>- You can pass the address of a first float element out of a contiguous structure, e.g. &amp;myvector.x</para>
		/// </summary>
		public static bool ColorEdit3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorEdit3(native_label, native_col, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static bool ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;

			fixed (Vector4* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorEdit4(native_label, native_col, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		public static bool ColorEdit4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorEdit4(native_label, native_col, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static bool ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;

			fixed (Vector3* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorPicker3(native_label, native_col, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		public static bool ColorPicker3(ReadOnlySpan<char> label, ref Vector3 col, ImGuiColorEditFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector3* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorPicker3(native_label, native_col, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;

			float* ref_col = null;

			fixed (Vector4* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorPicker4(native_label, native_col, flags, ref_col);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			float* ref_col = null;

			fixed (Vector4* native_col = &col)
			{
				var ret = ImGuiNative.ImGui_ColorPicker4(native_label, native_col, flags, ref_col);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		public static bool ColorPicker4(ReadOnlySpan<char> label, ref Vector4 col, ImGuiColorEditFlags flags, float[] ref_col)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (Vector4* native_col = &col)
			fixed (float* native_ref_col = ref_col)
			{
				var ret = ImGuiNative.ImGui_ColorPicker4(native_label, native_col, flags, native_ref_col);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<char> desc_id, Vector4 col)
		{
			// Marshaling 'desc_id' to native string
			byte* native_desc_id;
			var desc_id_byteCount = 0;
			if (desc_id != null)
			{
				desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
				if (desc_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_desc_id = Util.Allocate(desc_id_byteCount + 1);
				}
				else
				{
					var native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
					native_desc_id = native_desc_id_stackBytes;
				}
				var desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
				native_desc_id[desc_id_offset] = 0;
			}
			else native_desc_id = null;

			ImGuiColorEditFlags flags = (ImGuiColorEditFlags)0;

			var ret = ImGuiNative.ImGui_ColorButton(native_desc_id, col, flags);
			if (desc_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_desc_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<char> desc_id, Vector4 col, ImGuiColorEditFlags flags)
		{
			// Marshaling 'desc_id' to native string
			byte* native_desc_id;
			var desc_id_byteCount = 0;
			if (desc_id != null)
			{
				desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
				if (desc_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_desc_id = Util.Allocate(desc_id_byteCount + 1);
				}
				else
				{
					var native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
					native_desc_id = native_desc_id_stackBytes;
				}
				var desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
				native_desc_id[desc_id_offset] = 0;
			}
			else native_desc_id = null;

			var ret = ImGuiNative.ImGui_ColorButton(native_desc_id, col, flags);
			if (desc_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_desc_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool ColorButton(ReadOnlySpan<char> desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size)
		{
			// Marshaling 'desc_id' to native string
			byte* native_desc_id;
			var desc_id_byteCount = 0;
			if (desc_id != null)
			{
				desc_id_byteCount = Encoding.UTF8.GetByteCount(desc_id);
				if (desc_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_desc_id = Util.Allocate(desc_id_byteCount + 1);
				}
				else
				{
					var native_desc_id_stackBytes = stackalloc byte[desc_id_byteCount + 1];
					native_desc_id = native_desc_id_stackBytes;
				}
				var desc_id_offset = Util.GetUtf8(desc_id, native_desc_id, desc_id_byteCount);
				native_desc_id[desc_id_offset] = 0;
			}
			else native_desc_id = null;

			var ret = ImGuiNative.ImGui_ColorButtonEx(native_desc_id, col, flags, size);
			if (desc_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_desc_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// initialize current options (generally on application startup) if you want to select a default format, picker type, etc. User will be able to change many settings, unless you pass the _NoOptions flag to your calls.
		/// </summary>
		public static void SetColorEditOptions(ImGuiColorEditFlags flags)
		{
			ImGuiNative.ImGui_SetColorEditOptions(flags);
		}

		/// <summary>
		/// <para>Widgets: Trees</para>
		/// <para>- TreeNode functions return true when the node is open, in which case you need to also call TreePop() when you are finished displaying the tree node contents.</para>
		/// </summary>
		public static bool TreeNode(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_TreeNode(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// helper variation to easily decorelate the id from the displayed string. Read the FAQ about why and how to use ID. to align arbitrary text at the same level as a TreeNode() you can use Bullet().
		/// </summary>
		public static bool TreeNodeStr(ReadOnlySpan<char> str_id, ReadOnlySpan<char> fmt)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			var ret = ImGuiNative.ImGui_TreeNodeStr(native_str_id, native_fmt);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
			return ret != 0;
		}

		/// <summary>
		/// helper variation to easily decorelate the id from the displayed string. Read the FAQ about why and how to use ID. to align arbitrary text at the same level as a TreeNode() you can use Bullet().
		/// </summary>
		public static bool TreeNodeStrUnformatted(ReadOnlySpan<char> str_id, ReadOnlySpan<char> text)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			var ret = ImGuiNative.ImGui_TreeNodeStrUnformatted(native_str_id, native_text);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return ret != 0;
		}

		/// <summary>
		/// "
		/// </summary>
		public static bool TreeNodePtr(IntPtr ptr_id, ReadOnlySpan<char> fmt)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			var ret = ImGuiNative.ImGui_TreeNodePtr(native_ptr_id, native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
			return ret != 0;
		}

		/// <summary>
		/// "
		/// </summary>
		public static bool TreeNodePtrUnformatted(IntPtr ptr_id, ReadOnlySpan<char> text)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			var ret = ImGuiNative.ImGui_TreeNodePtrUnformatted(native_ptr_id, native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Trees</para>
		/// <para>- TreeNode functions return true when the node is open, in which case you need to also call TreePop() when you are finished displaying the tree node contents.</para>
		/// </summary>
		public static bool TreeNode(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_TreeNodeEx(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		public static bool TreeNodeExStr(ReadOnlySpan<char> str_id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			var ret = ImGuiNative.ImGui_TreeNodeExStr(native_str_id, flags, native_fmt);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
			return ret != 0;
		}

		public static bool TreeNodeExStrUnformatted(ReadOnlySpan<char> str_id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> text)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			var ret = ImGuiNative.ImGui_TreeNodeExStrUnformatted(native_str_id, flags, native_text);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return ret != 0;
		}

		public static bool TreeNodeExPtr(IntPtr ptr_id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> fmt)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			var ret = ImGuiNative.ImGui_TreeNodeExPtr(native_ptr_id, flags, native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
			return ret != 0;
		}

		public static bool TreeNodeExPtrUnformatted(IntPtr ptr_id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> text)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			var ret = ImGuiNative.ImGui_TreeNodeExPtrUnformatted(native_ptr_id, flags, native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return ret != 0;
		}

		/// <summary>
		/// ~ Indent()+PushID(). Already called by TreeNode() when returning true, but you can call TreePush/TreePop yourself if desired.
		/// </summary>
		public static void TreePush(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiNative.ImGui_TreePush(native_str_id);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}

		/// <summary>
		/// "
		/// </summary>
		public static void TreePushPtr(IntPtr ptr_id)
		{
			// Marshaling 'ptr_id' to native void pointer
			var native_ptr_id = ptr_id.ToPointer();

			ImGuiNative.ImGui_TreePushPtr(native_ptr_id);
		}

		/// <summary>
		/// ~ Unindent()+PopID()
		/// </summary>
		public static void TreePop()
		{
			ImGuiNative.ImGui_TreePop();
		}

		/// <summary>
		/// horizontal distance preceding label when using TreeNode*() or Bullet() == (g.FontSize + style.FramePadding.x*2) for a regular unframed TreeNode
		/// </summary>
		public static float GetTreeNodeToLabelSpacing()
		{
			var ret = ImGuiNative.ImGui_GetTreeNodeToLabelSpacing();
			return ret;
		}

		/// <summary>
		/// if returning 'true' the header is open. doesn't indent nor push on ID stack. user doesn't have to call TreePop().
		/// </summary>
		public static bool CollapsingHeader(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;

			var ret = ImGuiNative.ImGui_CollapsingHeader(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// if returning 'true' the header is open. doesn't indent nor push on ID stack. user doesn't have to call TreePop().
		/// </summary>
		public static bool CollapsingHeader(ReadOnlySpan<char> label, ImGuiTreeNodeFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_CollapsingHeader(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.
		/// </summary>
		public static bool CollapsingHeaderBoolPtr(ReadOnlySpan<char> label, ref bool p_visible)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_visible' to native bool
			var native_p_visible_val = p_visible ? (byte)1 : (byte)0;
			var native_p_visible = &native_p_visible_val;

			ImGuiTreeNodeFlags flags = (ImGuiTreeNodeFlags)0;

			var ret = ImGuiNative.ImGui_CollapsingHeaderBoolPtr(native_label, native_p_visible, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_visible = native_p_visible_val != 0;
			return ret != 0;
		}
		/// <summary>
		/// when 'p_visible != NULL': if '*p_visible==true' display an additional small close button on upper right of the header which will set the bool to false when clicked, if '*p_visible==false' don't display the header.
		/// </summary>
		public static bool CollapsingHeaderBoolPtr(ReadOnlySpan<char> label, ref bool p_visible, ImGuiTreeNodeFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_visible' to native bool
			var native_p_visible_val = p_visible ? (byte)1 : (byte)0;
			var native_p_visible = &native_p_visible_val;

			var ret = ImGuiNative.ImGui_CollapsingHeaderBoolPtr(native_label, native_p_visible, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_visible = native_p_visible_val != 0;
			return ret != 0;
		}

		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.
		/// </summary>
		public static void SetNextItemOpen(bool is_open)
		{
			// Marshaling 'is_open' to native bool
			var native_is_open = is_open ? (byte)1 : (byte)0;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetNextItemOpen(native_is_open, cond);
		}
		/// <summary>
		/// set next TreeNode/CollapsingHeader open state.
		/// </summary>
		public static void SetNextItemOpen(bool is_open, ImGuiCond cond)
		{
			// Marshaling 'is_open' to native bool
			var native_is_open = is_open ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetNextItemOpen(native_is_open, cond);
		}

		/// <summary>
		/// set id to use for open/close storage (default to same as item id).
		/// </summary>
		public static void SetNextItemStorageID(uint storage_id)
		{
			ImGuiNative.ImGui_SetNextItemStorageID(storage_id);
		}

		/// <summary>
		/// <para>Widgets: Selectables</para>
		/// <para>- A selectable highlights when hovered, and can display another color when selected.</para>
		/// <para>- Neighbors selectable extend their highlight bounds in order to leave no gap between them. This is so a series of selected Selectable appear contiguous.</para>
		/// </summary>
		/// <summary>
		/// Implied selected = false, flags = 0, size = ImVec2(0, 0)
		/// </summary>
		public static bool Selectable(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_Selectable(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Selectables</para>
		/// <para>- A selectable highlights when hovered, and can display another color when selected.</para>
		/// <para>- Neighbors selectable extend their highlight bounds in order to leave no gap between them. This is so a series of selected Selectable appear contiguous.</para>
		/// </summary>
		/// <summary>
		/// Implied selected = false, flags = 0, size = ImVec2(0, 0)
		/// </summary>
		public static bool Selectable(ReadOnlySpan<char> label, bool selected)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;

			Vector2 size = new Vector2();

			var ret = ImGuiNative.ImGui_SelectableEx(native_label, native_selected, flags, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// <para>Widgets: Selectables</para>
		/// <para>- A selectable highlights when hovered, and can display another color when selected.</para>
		/// <para>- Neighbors selectable extend their highlight bounds in order to leave no gap between them. This is so a series of selected Selectable appear contiguous.</para>
		/// </summary>
		/// <summary>
		/// Implied selected = false, flags = 0, size = ImVec2(0, 0)
		/// </summary>
		public static bool Selectable(ReadOnlySpan<char> label, bool selected, ImGuiSelectableFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			Vector2 size = new Vector2();

			var ret = ImGuiNative.ImGui_SelectableEx(native_label, native_selected, flags, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// <para>Widgets: Selectables</para>
		/// <para>- A selectable highlights when hovered, and can display another color when selected.</para>
		/// <para>- Neighbors selectable extend their highlight bounds in order to leave no gap between them. This is so a series of selected Selectable appear contiguous.</para>
		/// </summary>
		/// <summary>
		/// Implied selected = false, flags = 0, size = ImVec2(0, 0)
		/// </summary>
		public static bool Selectable(ReadOnlySpan<char> label, bool selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_SelectableEx(native_label, native_selected, flags, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool SelectableBoolPtr(ReadOnlySpan<char> label, ref bool p_selected)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			ImGuiSelectableFlags flags = (ImGuiSelectableFlags)0;

			var ret = ImGuiNative.ImGui_SelectableBoolPtr(native_label, native_p_selected, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_selected = native_p_selected_val != 0;
			return ret != 0;
		}
		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool SelectableBoolPtr(ReadOnlySpan<char> label, ref bool p_selected, ImGuiSelectableFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			var ret = ImGuiNative.ImGui_SelectableBoolPtr(native_label, native_p_selected, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_selected = native_p_selected_val != 0;
			return ret != 0;
		}

		/// <summary>
		/// Implied size = ImVec2(0, 0)
		/// </summary>
		public static bool SelectableBoolPtr(ReadOnlySpan<char> label, ref bool p_selected, ImGuiSelectableFlags flags, Vector2 size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			var ret = ImGuiNative.ImGui_SelectableBoolPtrEx(native_label, native_p_selected, flags, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_selected = native_p_selected_val != 0;
			return ret != 0;
		}

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
		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags)
		{
			var ret = ImGuiNative.ImGui_BeginMultiSelect(flags);
			return ret;
		}

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
		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size)
		{
			int items_count = -1;

			var ret = ImGuiNative.ImGui_BeginMultiSelectEx(flags, selection_size, items_count);
			return ret;
		}
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
		public static ImGuiMultiSelectIOPtr BeginMultiSelect(ImGuiMultiSelectFlags flags, int selection_size, int items_count)
		{
			var ret = ImGuiNative.ImGui_BeginMultiSelectEx(flags, selection_size, items_count);
			return ret;
		}

		public static ImGuiMultiSelectIOPtr EndMultiSelect()
		{
			var ret = ImGuiNative.ImGui_EndMultiSelect();
			return ret;
		}

		public static void SetNextItemSelectionUserData(long selection_user_data)
		{
			ImGuiNative.ImGui_SetNextItemSelectionUserData(selection_user_data);
		}

		/// <summary>
		/// Was the last item selection state toggled? Useful if you need the per-item information _before_ reaching EndMultiSelect(). We only returns toggle _event_ in order to handle clipping correctly.
		/// </summary>
		public static bool IsItemToggledSelection()
		{
			var ret = ImGuiNative.ImGui_IsItemToggledSelection();
			return ret != 0;
		}

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
		public static bool BeginListBox(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			Vector2 size = new Vector2();

			var ret = ImGuiNative.ImGui_BeginListBox(native_label, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
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
		public static bool BeginListBox(ReadOnlySpan<char> label, Vector2 size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_BeginListBox(native_label, size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// only call EndListBox() if BeginListBox() returned true!
		/// </summary>
		public static void EndListBox()
		{
			ImGuiNative.ImGui_EndListBox();
		}

		public static bool ListBox(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'items' to native string array
			var items_byteCounts = stackalloc int[items.Length];
			var items_byteCount = 0;
			for (var i = 0; i < items.Length; i++)
			{
				items_byteCounts[i] = Encoding.UTF8.GetByteCount(items[i]);
				items_byteCount += items_byteCounts[i] + 1;
			}
			var native_items_data = stackalloc byte[items_byteCount];
			var items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				var s = items[i];
				items_offset += Util.GetUtf8(s, native_items_data + items_offset, items_byteCounts[i]);
				native_items_data[items_offset++] = 0;
			}
			var native_items = stackalloc byte*[items.Length];
			items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				native_items[i] = &native_items_data[items_offset];
				items_offset += items_byteCounts[i] + 1;
			}

			int height_in_items = -1;

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ListBox(native_label, native_current_item, native_items, items_count, height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		public static bool ListBox(ReadOnlySpan<char> label, ref int current_item, string[] items, int items_count, int height_in_items)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'items' to native string array
			var items_byteCounts = stackalloc int[items.Length];
			var items_byteCount = 0;
			for (var i = 0; i < items.Length; i++)
			{
				items_byteCounts[i] = Encoding.UTF8.GetByteCount(items[i]);
				items_byteCount += items_byteCounts[i] + 1;
			}
			var native_items_data = stackalloc byte[items_byteCount];
			var items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				var s = items[i];
				items_offset += Util.GetUtf8(s, native_items_data + items_offset, items_byteCounts[i]);
				native_items_data[items_offset++] = 0;
			}
			var native_items = stackalloc byte*[items.Length];
			items_offset = 0;
			for (var i = 0; i < items.Length; i++)
			{
				native_items[i] = &native_items_data[items_offset];
				items_offset += items_byteCounts[i] + 1;
			}

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ListBox(native_label, native_current_item, native_items, items_count, height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied height_in_items = -1
		/// </summary>
		public static bool ListBoxCallback(ReadOnlySpan<char> label, ref int current_item, ImGui_ListBoxCallbackgetterDelegate getter, IntPtr user_data, int items_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ListBoxCallback(native_label, native_current_item, getter, native_user_data, items_count);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied height_in_items = -1
		/// </summary>
		public static bool ListBoxCallback(ReadOnlySpan<char> label, ref int current_item, ImGui_ListBoxCallbackExgetterDelegate getter, IntPtr user_data, int items_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			int height_in_items = -1;

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ListBoxCallbackEx(native_label, native_current_item, getter, native_user_data, items_count, height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied height_in_items = -1
		/// </summary>
		public static bool ListBoxCallback(ReadOnlySpan<char> label, ref int current_item, ImGui_ListBoxCallbackExgetterDelegate getter, IntPtr user_data, int items_count, int height_in_items)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (int* native_current_item = &current_item)
			{
				var ret = ImGuiNative.ImGui_ListBoxCallbackEx(native_label, native_current_item, getter, native_user_data, items_count, height_in_items);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLines(native_label, native_values, values_count);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
			}
		}

		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLinesEx(native_label, native_values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
			}
		}
		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLinesEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLinesEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLinesEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLinesEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// <para>Widgets: Data Plotting</para>
		/// <para>- Consider using ImPlot (https://github.com/epezent/implot) which is much better!</para>
		/// </summary>
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotLines(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotLinesEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}

		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackvalues_getterDelegate values_getter, IntPtr data, int values_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			ImGuiNative.ImGui_PlotLinesCallback(native_label, values_getter, native_data, values_count);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			int values_offset = 0;

			byte* overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotLinesCallbackEx(native_label, values_getter, native_data, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			byte* overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotLinesCallbackEx(native_label, values_getter, native_data, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotLinesCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotLinesCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotLinesCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotLinesCallback(ReadOnlySpan<char> label, ImGui_PlotLinesCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			ImGuiNative.ImGui_PlotLinesCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}

		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogram(native_label, native_values, values_count);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
			}
		}

		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogramEx(native_label, native_values, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogramEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogramEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			Vector2 graph_size = new Vector2();

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogramEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			int stride = sizeof(float);

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogramEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0), stride = sizeof(float)
		/// </summary>
		public static void PlotHistogram(ReadOnlySpan<char> label, float[] values, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			fixed (float* native_values = values)
			{
				ImGuiNative.ImGui_PlotHistogramEx(native_label, native_values, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size, stride);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_overlay_text);
				}
			}
		}

		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackvalues_getterDelegate values_getter, IntPtr data, int values_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			ImGuiNative.ImGui_PlotHistogramCallback(native_label, values_getter, native_data, values_count);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			int values_offset = 0;

			byte* overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotHistogramCallbackEx(native_label, values_getter, native_data, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			byte* overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotHistogramCallbackEx(native_label, values_getter, native_data, values_count, values_offset, overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_min = float.MaxValue;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotHistogramCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			float scale_max = float.MaxValue;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotHistogramCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			Vector2 graph_size = new Vector2();

			ImGuiNative.ImGui_PlotHistogramCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}
		/// <summary>
		/// Implied values_offset = 0, overlay_text = NULL, scale_min = FLT_MAX, scale_max = FLT_MAX, graph_size = ImVec2(0, 0)
		/// </summary>
		public static void PlotHistogramCallback(ReadOnlySpan<char> label, ImGui_PlotHistogramCallbackExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 graph_size)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			ImGuiNative.ImGui_PlotHistogramCallbackEx(native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, graph_size);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
		}

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
		public static bool BeginMenuBar()
		{
			var ret = ImGuiNative.ImGui_BeginMenuBar();
			return ret != 0;
		}

		/// <summary>
		/// only call EndMenuBar() if BeginMenuBar() returns true!
		/// </summary>
		public static void EndMenuBar()
		{
			ImGuiNative.ImGui_EndMenuBar();
		}

		/// <summary>
		/// create and append to a full screen menu-bar.
		/// </summary>
		public static bool BeginMainMenuBar()
		{
			var ret = ImGuiNative.ImGui_BeginMainMenuBar();
			return ret != 0;
		}

		/// <summary>
		/// only call EndMainMenuBar() if BeginMainMenuBar() returns true!
		/// </summary>
		public static void EndMainMenuBar()
		{
			ImGuiNative.ImGui_EndMainMenuBar();
		}

		/// <summary>
		/// Implied enabled = true
		/// </summary>
		public static bool BeginMenu(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_BeginMenu(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied enabled = true
		/// </summary>
		public static bool BeginMenu(ReadOnlySpan<char> label, bool enabled)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'enabled' to native bool
			var native_enabled = enabled ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_BeginMenuEx(native_label, native_enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// only call EndMenu() if BeginMenu() returns true!
		/// </summary>
		public static void EndMenu()
		{
			ImGuiNative.ImGui_EndMenu();
		}

		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItem(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_MenuItem(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			byte selected = 0;

			byte enabled = 1;

			var ret = ImGuiNative.ImGui_MenuItemEx(native_label, native_shortcut, selected, enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, bool selected)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			byte enabled = 1;

			var ret = ImGuiNative.ImGui_MenuItemEx(native_label, native_shortcut, native_selected, enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItem(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			// Marshaling 'enabled' to native bool
			var native_enabled = enabled ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_MenuItemEx(native_label, native_shortcut, native_selected, native_enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			return ret != 0;
		}

		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL
		/// </summary>
		public static bool MenuItemBoolPtr(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, ref bool p_selected)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			byte enabled = 1;

			var ret = ImGuiNative.ImGui_MenuItemBoolPtr(native_label, native_shortcut, native_p_selected, enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			p_selected = native_p_selected_val != 0;
			return ret != 0;
		}
		/// <summary>
		/// return true when activated + toggle (*p_selected) if p_selected != NULL
		/// </summary>
		public static bool MenuItemBoolPtr(ReadOnlySpan<char> label, ReadOnlySpan<char> shortcut, ref bool p_selected, bool enabled)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			// Marshaling 'enabled' to native bool
			var native_enabled = enabled ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_MenuItemBoolPtr(native_label, native_shortcut, native_p_selected, native_enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			p_selected = native_p_selected_val != 0;
			return ret != 0;
		}

		/// <summary>
		/// <para>Tooltips</para>
		/// <para>- Tooltips are windows following the mouse. They do not take focus away.</para>
		/// <para>- A tooltip window can contain items of any types.</para>
		/// <para>- SetTooltip() is more or less a shortcut for the 'if (BeginTooltip()) { Text(...); EndTooltip(); }' idiom (with a subtlety that it discard any previously submitted tooltip)</para>
		/// </summary>
		/// <summary>
		/// begin/append a tooltip window.
		/// </summary>
		public static bool BeginTooltip()
		{
			var ret = ImGuiNative.ImGui_BeginTooltip();
			return ret != 0;
		}

		/// <summary>
		/// only call EndTooltip() if BeginTooltip()/BeginItemTooltip() returns true!
		/// </summary>
		public static void EndTooltip()
		{
			ImGuiNative.ImGui_EndTooltip();
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().
		/// </summary>
		public static void SetTooltip(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_SetTooltip(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// set a text-only tooltip. Often used after a ImGui::IsItemHovered() check. Override any previous call to SetTooltip().
		/// </summary>
		public static void SetTooltipUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_SetTooltipUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// <para>Tooltips: helpers for showing a tooltip when hovering an item</para>
		/// <para>- BeginItemTooltip() is a shortcut for the 'if (IsItemHovered(ImGuiHoveredFlags_ForTooltip) &amp;&amp; BeginTooltip())' idiom.</para>
		/// <para>- SetItemTooltip() is a shortcut for the 'if (IsItemHovered(ImGuiHoveredFlags_ForTooltip)) { SetTooltip(...); }' idiom.</para>
		/// <para>- Where 'ImGuiHoveredFlags_ForTooltip' itself is a shortcut to use 'style.HoverFlagsForTooltipMouse' or 'style.HoverFlagsForTooltipNav' depending on active input type. For mouse it defaults to 'ImGuiHoveredFlags_Stationary | ImGuiHoveredFlags_DelayShort'.</para>
		/// </summary>
		/// <summary>
		/// begin/append a tooltip window if preceding item was hovered.
		/// </summary>
		public static bool BeginItemTooltip()
		{
			var ret = ImGuiNative.ImGui_BeginItemTooltip();
			return ret != 0;
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().
		/// </summary>
		public static void SetItemTooltip(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_SetItemTooltip(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// set a text-only tooltip if preceding item was hovered. override any previous call to SetTooltip().
		/// </summary>
		public static void SetItemTooltipUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_SetItemTooltipUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

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
		public static bool BeginPopup(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiWindowFlags flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginPopup(native_str_id, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginPopup(ReadOnlySpan<char> str_id, ImGuiWindowFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginPopup(native_str_id, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<char> name)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			byte* p_open = null;

			ImGuiWindowFlags flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginPopupModal(native_name, p_open, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}
		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<char> name, ref bool p_open)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiWindowFlags flags = (ImGuiWindowFlags)0;

			var ret = ImGuiNative.ImGui_BeginPopupModal(native_name, native_p_open, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}
		/// <summary>
		/// return true if the modal is open, and you can start outputting to it.
		/// </summary>
		public static bool BeginPopupModal(ReadOnlySpan<char> name, ref bool p_open, ImGuiWindowFlags flags)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			var ret = ImGuiNative.ImGui_BeginPopupModal(native_name, native_p_open, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}

		/// <summary>
		/// only call EndPopup() if BeginPopupXXX() returns true!
		/// </summary>
		public static void EndPopup()
		{
			ImGuiNative.ImGui_EndPopup();
		}

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
		public static void OpenPopup(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)0;

			ImGuiNative.ImGui_OpenPopup(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}
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
		public static void OpenPopup(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiNative.ImGui_OpenPopup(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}

		/// <summary>
		/// id overload to facilitate calling from nested stacks
		/// </summary>
		public static void OpenPopupID(uint id)
		{
			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)0;

			ImGuiNative.ImGui_OpenPopupID(id, popup_flags);
		}
		/// <summary>
		/// id overload to facilitate calling from nested stacks
		/// </summary>
		public static void OpenPopupID(uint id, ImGuiPopupFlags popup_flags)
		{
			ImGuiNative.ImGui_OpenPopupID(id, popup_flags);
		}

		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)
		/// </summary>
		public static void OpenPopupOnItemClick()
		{
			byte* str_id = null;

			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;

			ImGuiNative.ImGui_OpenPopupOnItemClick(str_id, popup_flags);
		}
		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;

			ImGuiNative.ImGui_OpenPopupOnItemClick(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}
		/// <summary>
		/// helper to open popup when clicked on last item. Default to ImGuiPopupFlags_MouseButtonRight == 1. (note: actually triggers on the mouse _released_ event to be consistent with popup behaviors)
		/// </summary>
		public static void OpenPopupOnItemClick(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiNative.ImGui_OpenPopupOnItemClick(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}

		/// <summary>
		/// manually close the popup we have begin-ed into.
		/// </summary>
		public static void CloseCurrentPopup()
		{
			ImGuiNative.ImGui_CloseCurrentPopup();
		}

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
		public static bool BeginPopupContextItem()
		{
			var ret = ImGuiNative.ImGui_BeginPopupContextItem();
			return ret != 0;
		}

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
		public static bool BeginPopupContextItem(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;

			var ret = ImGuiNative.ImGui_BeginPopupContextItemEx(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginPopupContextItem(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginPopupContextItemEx(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		public static bool BeginPopupContextWindow()
		{
			var ret = ImGuiNative.ImGui_BeginPopupContextWindow();
			return ret != 0;
		}

		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		public static bool BeginPopupContextWindow(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;

			var ret = ImGuiNative.ImGui_BeginPopupContextWindowEx(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		public static bool BeginPopupContextWindow(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginPopupContextWindowEx(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		public static bool BeginPopupContextVoid()
		{
			var ret = ImGuiNative.ImGui_BeginPopupContextVoid();
			return ret != 0;
		}

		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		public static bool BeginPopupContextVoid(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)1;

			var ret = ImGuiNative.ImGui_BeginPopupContextVoidEx(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied str_id = NULL, popup_flags = 1
		/// </summary>
		public static bool BeginPopupContextVoid(ReadOnlySpan<char> str_id, ImGuiPopupFlags popup_flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginPopupContextVoidEx(native_str_id, popup_flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Popups: query functions</para>
		/// <para> - IsPopupOpen(): return true if the popup is open at the current BeginPopup() level of the popup stack.</para>
		/// <para> - IsPopupOpen() with ImGuiPopupFlags_AnyPopupId: return true if any popup is open at the current BeginPopup() level of the popup stack.</para>
		/// <para> - IsPopupOpen() with ImGuiPopupFlags_AnyPopupId + ImGuiPopupFlags_AnyPopupLevel: return true if any popup is open.</para>
		/// </summary>
		/// <summary>
		/// return true if the popup is open.
		/// </summary>
		public static bool IsPopupOpen(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiPopupFlags flags = (ImGuiPopupFlags)0;

			var ret = ImGuiNative.ImGui_IsPopupOpen(native_str_id, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// <para>Popups: query functions</para>
		/// <para> - IsPopupOpen(): return true if the popup is open at the current BeginPopup() level of the popup stack.</para>
		/// <para> - IsPopupOpen() with ImGuiPopupFlags_AnyPopupId: return true if any popup is open at the current BeginPopup() level of the popup stack.</para>
		/// <para> - IsPopupOpen() with ImGuiPopupFlags_AnyPopupId + ImGuiPopupFlags_AnyPopupLevel: return true if any popup is open.</para>
		/// </summary>
		/// <summary>
		/// return true if the popup is open.
		/// </summary>
		public static bool IsPopupOpen(ReadOnlySpan<char> str_id, ImGuiPopupFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_IsPopupOpen(native_str_id, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

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
		public static bool BeginTable(ReadOnlySpan<char> str_id, int columns)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiTableFlags flags = (ImGuiTableFlags)0;

			var ret = ImGuiNative.ImGui_BeginTable(native_str_id, columns, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginTable(ReadOnlySpan<char> str_id, int columns, ImGuiTableFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginTable(native_str_id, columns, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

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
		public static bool BeginTable(ReadOnlySpan<char> str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			float inner_width = 0.0f;

			var ret = ImGuiNative.ImGui_BeginTableEx(native_str_id, columns, flags, outer_size, inner_width);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
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
		public static bool BeginTable(ReadOnlySpan<char> str_id, int columns, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginTableEx(native_str_id, columns, flags, outer_size, inner_width);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// only call EndTable() if BeginTable() returns true!
		/// </summary>
		public static void EndTable()
		{
			ImGuiNative.ImGui_EndTable();
		}

		/// <summary>
		/// Implied row_flags = 0, min_row_height = 0.0f
		/// </summary>
		public static void TableNextRow()
		{
			ImGuiNative.ImGui_TableNextRow();
		}

		/// <summary>
		/// Implied row_flags = 0, min_row_height = 0.0f
		/// </summary>
		public static void TableNextRow(ImGuiTableRowFlags row_flags)
		{
			float min_row_height = 0.0f;

			ImGuiNative.ImGui_TableNextRowEx(row_flags, min_row_height);
		}
		/// <summary>
		/// Implied row_flags = 0, min_row_height = 0.0f
		/// </summary>
		public static void TableNextRow(ImGuiTableRowFlags row_flags, float min_row_height)
		{
			ImGuiNative.ImGui_TableNextRowEx(row_flags, min_row_height);
		}

		/// <summary>
		/// append into the next column (or first column of next row if currently in last column). Return true when column is visible.
		/// </summary>
		public static bool TableNextColumn()
		{
			var ret = ImGuiNative.ImGui_TableNextColumn();
			return ret != 0;
		}

		/// <summary>
		/// append into the specified column. Return true when column is visible.
		/// </summary>
		public static bool TableSetColumnIndex(int column_n)
		{
			var ret = ImGuiNative.ImGui_TableSetColumnIndex(column_n);
			return ret != 0;
		}

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
		public static void TableSetupColumn(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiTableColumnFlags flags = (ImGuiTableColumnFlags)0;

			ImGuiNative.ImGui_TableSetupColumn(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}
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
		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ImGui_TableSetupColumn(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

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
		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float init_width_or_weight)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			uint user_id = 0;

			ImGuiNative.ImGui_TableSetupColumnEx(native_label, flags, init_width_or_weight, user_id);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}
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
		public static void TableSetupColumn(ReadOnlySpan<char> label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ImGui_TableSetupColumnEx(native_label, flags, init_width_or_weight, user_id);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// lock columns/rows so they stay visible when scrolled.
		/// </summary>
		public static void TableSetupScrollFreeze(int cols, int rows)
		{
			ImGuiNative.ImGui_TableSetupScrollFreeze(cols, rows);
		}

		/// <summary>
		/// submit one header cell manually (rarely used)
		/// </summary>
		public static void TableHeader(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiNative.ImGui_TableHeader(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		/// <summary>
		/// submit a row with headers cells based on data provided to TableSetupColumn() + submit context menu
		/// </summary>
		public static void TableHeadersRow()
		{
			ImGuiNative.ImGui_TableHeadersRow();
		}

		/// <summary>
		/// submit a row with angled headers for every column with the ImGuiTableColumnFlags_AngledHeader flag. MUST BE FIRST ROW.
		/// </summary>
		public static void TableAngledHeadersRow()
		{
			ImGuiNative.ImGui_TableAngledHeadersRow();
		}

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
		public static ImGuiTableSortSpecsPtr TableGetSortSpecs()
		{
			var ret = ImGuiNative.ImGui_TableGetSortSpecs();
			return ret;
		}

		/// <summary>
		/// return number of columns (value passed to BeginTable)
		/// </summary>
		public static int TableGetColumnCount()
		{
			var ret = ImGuiNative.ImGui_TableGetColumnCount();
			return ret;
		}

		/// <summary>
		/// return current column index.
		/// </summary>
		public static int TableGetColumnIndex()
		{
			var ret = ImGuiNative.ImGui_TableGetColumnIndex();
			return ret;
		}

		/// <summary>
		/// return current row index.
		/// </summary>
		public static int TableGetRowIndex()
		{
			var ret = ImGuiNative.ImGui_TableGetRowIndex();
			return ret;
		}

		/// <summary>
		/// return "" if column didn't have a name declared by TableSetupColumn(). Pass -1 to use current column.
		/// </summary>
		public static string TableGetColumnName()
		{
			int column_n = -1;

			var ret = ImGuiNative.ImGui_TableGetColumnName(column_n);
			return Util.StringFromPtr(ret);
		}
		/// <summary>
		/// return "" if column didn't have a name declared by TableSetupColumn(). Pass -1 to use current column.
		/// </summary>
		public static string TableGetColumnName(int column_n)
		{
			var ret = ImGuiNative.ImGui_TableGetColumnName(column_n);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.
		/// </summary>
		public static ImGuiTableColumnFlags TableGetColumnFlags()
		{
			int column_n = -1;

			var ret = ImGuiNative.ImGui_TableGetColumnFlags(column_n);
			return ret;
		}
		/// <summary>
		/// return column flags so you can query their Enabled/Visible/Sorted/Hovered status flags. Pass -1 to use current column.
		/// </summary>
		public static ImGuiTableColumnFlags TableGetColumnFlags(int column_n)
		{
			var ret = ImGuiNative.ImGui_TableGetColumnFlags(column_n);
			return ret;
		}

		/// <summary>
		/// change user accessible enabled/disabled state of a column. Set to false to hide the column. User can use the context menu to change this themselves (right-click in headers, or right-click in columns body with ImGuiTableFlags_ContextMenuInBody)
		/// </summary>
		public static void TableSetColumnEnabled(int column_n, bool v)
		{
			// Marshaling 'v' to native bool
			var native_v = v ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_TableSetColumnEnabled(column_n, native_v);
		}

		/// <summary>
		/// return hovered column. return -1 when table is not hovered. return columns_count if the unused space at the right of visible columns is hovered. Can also use (TableGetColumnFlags() &amp; ImGuiTableColumnFlags_IsHovered) instead.
		/// </summary>
		public static int TableGetHoveredColumn()
		{
			var ret = ImGuiNative.ImGui_TableGetHoveredColumn();
			return ret;
		}

		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.
		/// </summary>
		public static void TableSetBgColor(ImGuiTableBgTarget target, uint color)
		{
			int column_n = -1;

			ImGuiNative.ImGui_TableSetBgColor(target, color, column_n);
		}
		/// <summary>
		/// change the color of a cell, row, or column. See ImGuiTableBgTarget_ flags for details.
		/// </summary>
		public static void TableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n)
		{
			ImGuiNative.ImGui_TableSetBgColor(target, color, column_n);
		}

		/// <summary>
		/// <para>Legacy Columns API (prefer using Tables!)</para>
		/// <para>- You can also use SameLine(pos_x) to mimic simplified columns.</para>
		/// </summary>
		/// <summary>
		/// Implied count = 1, id = NULL, borders = true
		/// </summary>
		public static void Columns()
		{
			ImGuiNative.ImGui_Columns();
		}

		/// <summary>
		/// <para>Legacy Columns API (prefer using Tables!)</para>
		/// <para>- You can also use SameLine(pos_x) to mimic simplified columns.</para>
		/// </summary>
		/// <summary>
		/// Implied count = 1, id = NULL, borders = true
		/// </summary>
		public static void Columns(int count)
		{
			byte* id = null;

			byte borders = 1;

			ImGuiNative.ImGui_ColumnsEx(count, id, borders);
		}
		/// <summary>
		/// <para>Legacy Columns API (prefer using Tables!)</para>
		/// <para>- You can also use SameLine(pos_x) to mimic simplified columns.</para>
		/// </summary>
		/// <summary>
		/// Implied count = 1, id = NULL, borders = true
		/// </summary>
		public static void Columns(int count, ReadOnlySpan<char> id)
		{
			// Marshaling 'id' to native string
			byte* native_id;
			var id_byteCount = 0;
			if (id != null)
			{
				id_byteCount = Encoding.UTF8.GetByteCount(id);
				if (id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_id = Util.Allocate(id_byteCount + 1);
				}
				else
				{
					var native_id_stackBytes = stackalloc byte[id_byteCount + 1];
					native_id = native_id_stackBytes;
				}
				var id_offset = Util.GetUtf8(id, native_id, id_byteCount);
				native_id[id_offset] = 0;
			}
			else native_id = null;

			byte borders = 1;

			ImGuiNative.ImGui_ColumnsEx(count, native_id, borders);
			if (id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_id);
			}
		}
		/// <summary>
		/// <para>Legacy Columns API (prefer using Tables!)</para>
		/// <para>- You can also use SameLine(pos_x) to mimic simplified columns.</para>
		/// </summary>
		/// <summary>
		/// Implied count = 1, id = NULL, borders = true
		/// </summary>
		public static void Columns(int count, ReadOnlySpan<char> id, bool borders)
		{
			// Marshaling 'id' to native string
			byte* native_id;
			var id_byteCount = 0;
			if (id != null)
			{
				id_byteCount = Encoding.UTF8.GetByteCount(id);
				if (id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_id = Util.Allocate(id_byteCount + 1);
				}
				else
				{
					var native_id_stackBytes = stackalloc byte[id_byteCount + 1];
					native_id = native_id_stackBytes;
				}
				var id_offset = Util.GetUtf8(id, native_id, id_byteCount);
				native_id[id_offset] = 0;
			}
			else native_id = null;

			// Marshaling 'borders' to native bool
			var native_borders = borders ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_ColumnsEx(count, native_id, native_borders);
			if (id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_id);
			}
		}

		/// <summary>
		/// next column, defaults to current row or next row if the current row is finished
		/// </summary>
		public static void NextColumn()
		{
			ImGuiNative.ImGui_NextColumn();
		}

		/// <summary>
		/// get current column index
		/// </summary>
		public static int GetColumnIndex()
		{
			var ret = ImGuiNative.ImGui_GetColumnIndex();
			return ret;
		}

		/// <summary>
		/// get column width (in pixels). pass -1 to use current column
		/// </summary>
		public static float GetColumnWidth()
		{
			int column_index = -1;

			var ret = ImGuiNative.ImGui_GetColumnWidth(column_index);
			return ret;
		}
		/// <summary>
		/// get column width (in pixels). pass -1 to use current column
		/// </summary>
		public static float GetColumnWidth(int column_index)
		{
			var ret = ImGuiNative.ImGui_GetColumnWidth(column_index);
			return ret;
		}

		/// <summary>
		/// set column width (in pixels). pass -1 to use current column
		/// </summary>
		public static void SetColumnWidth(int column_index, float width)
		{
			ImGuiNative.ImGui_SetColumnWidth(column_index, width);
		}

		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f
		/// </summary>
		public static float GetColumnOffset()
		{
			int column_index = -1;

			var ret = ImGuiNative.ImGui_GetColumnOffset(column_index);
			return ret;
		}
		/// <summary>
		/// get position of column line (in pixels, from the left side of the contents region). pass -1 to use current column, otherwise 0..GetColumnsCount() inclusive. column 0 is typically 0.0f
		/// </summary>
		public static float GetColumnOffset(int column_index)
		{
			var ret = ImGuiNative.ImGui_GetColumnOffset(column_index);
			return ret;
		}

		/// <summary>
		/// set position of column line (in pixels, from the left side of the contents region). pass -1 to use current column
		/// </summary>
		public static void SetColumnOffset(int column_index, float offset_x)
		{
			ImGuiNative.ImGui_SetColumnOffset(column_index, offset_x);
		}

		public static int GetColumnsCount()
		{
			var ret = ImGuiNative.ImGui_GetColumnsCount();
			return ret;
		}

		/// <summary>
		/// <para>Tab Bars, Tabs</para>
		/// <para>- Note: Tabs are automatically created by the docking system (when in 'docking' branch). Use this to create tab bars/tabs yourself.</para>
		/// </summary>
		/// <summary>
		/// create and append into a TabBar
		/// </summary>
		public static bool BeginTabBar(ReadOnlySpan<char> str_id)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiTabBarFlags flags = (ImGuiTabBarFlags)0;

			var ret = ImGuiNative.ImGui_BeginTabBar(native_str_id, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		/// <summary>
		/// <para>Tab Bars, Tabs</para>
		/// <para>- Note: Tabs are automatically created by the docking system (when in 'docking' branch). Use this to create tab bars/tabs yourself.</para>
		/// </summary>
		/// <summary>
		/// create and append into a TabBar
		/// </summary>
		public static bool BeginTabBar(ReadOnlySpan<char> str_id, ImGuiTabBarFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiNative.ImGui_BeginTabBar(native_str_id, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		/// <summary>
		/// only call EndTabBar() if BeginTabBar() returns true!
		/// </summary>
		public static void EndTabBar()
		{
			ImGuiNative.ImGui_EndTabBar();
		}

		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			byte* p_open = null;

			ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;

			var ret = ImGuiNative.ImGui_BeginTabItem(native_label, p_open, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<char> label, ref bool p_open)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;

			var ret = ImGuiNative.ImGui_BeginTabItem(native_label, native_p_open, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}
		/// <summary>
		/// create a Tab. Returns true if the Tab is selected.
		/// </summary>
		public static bool BeginTabItem(ReadOnlySpan<char> label, ref bool p_open, ImGuiTabItemFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			var ret = ImGuiNative.ImGui_BeginTabItem(native_label, native_p_open, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}

		/// <summary>
		/// only call EndTabItem() if BeginTabItem() returns true!
		/// </summary>
		public static void EndTabItem()
		{
			ImGuiNative.ImGui_EndTabItem();
		}

		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.
		/// </summary>
		public static bool TabItemButton(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiTabItemFlags flags = (ImGuiTabItemFlags)0;

			var ret = ImGuiNative.ImGui_TabItemButton(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// create a Tab behaving like a button. return true when clicked. cannot be selected in the tab bar.
		/// </summary>
		public static bool TabItemButton(ReadOnlySpan<char> label, ImGuiTabItemFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiNative.ImGui_TabItemButton(native_label, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// notify TabBar or Docking system of a closed tab/window ahead (useful to reduce visual flicker on reorderable tab bars). For tab-bar: call after BeginTabBar() and before Tab submissions. Otherwise call with a window name.
		/// </summary>
		public static void SetTabItemClosed(ReadOnlySpan<char> tab_or_docked_window_label)
		{
			// Marshaling 'tab_or_docked_window_label' to native string
			byte* native_tab_or_docked_window_label;
			var tab_or_docked_window_label_byteCount = 0;
			if (tab_or_docked_window_label != null)
			{
				tab_or_docked_window_label_byteCount = Encoding.UTF8.GetByteCount(tab_or_docked_window_label);
				if (tab_or_docked_window_label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_tab_or_docked_window_label = Util.Allocate(tab_or_docked_window_label_byteCount + 1);
				}
				else
				{
					var native_tab_or_docked_window_label_stackBytes = stackalloc byte[tab_or_docked_window_label_byteCount + 1];
					native_tab_or_docked_window_label = native_tab_or_docked_window_label_stackBytes;
				}
				var tab_or_docked_window_label_offset = Util.GetUtf8(tab_or_docked_window_label, native_tab_or_docked_window_label, tab_or_docked_window_label_byteCount);
				native_tab_or_docked_window_label[tab_or_docked_window_label_offset] = 0;
			}
			else native_tab_or_docked_window_label = null;

			ImGuiNative.ImGui_SetTabItemClosed(native_tab_or_docked_window_label);
			if (tab_or_docked_window_label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_tab_or_docked_window_label);
			}
		}

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
		public static uint DockSpace(uint dockspace_id)
		{
			var ret = ImGuiNative.ImGui_DockSpace(dockspace_id);
			return ret;
		}

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
		public static uint DockSpace(uint dockspace_id, Vector2 size)
		{
			ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;

			ImGuiWindowClass* window_class = null;

			var ret = ImGuiNative.ImGui_DockSpaceEx(dockspace_id, size, flags, window_class);
			return ret;
		}
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
		public static uint DockSpace(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags)
		{
			ImGuiWindowClass* window_class = null;

			var ret = ImGuiNative.ImGui_DockSpaceEx(dockspace_id, size, flags, window_class);
			return ret;
		}
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
		public static uint DockSpace(uint dockspace_id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr window_class)
		{
			var ret = ImGuiNative.ImGui_DockSpaceEx(dockspace_id, size, flags, window_class);
			return ret;
		}

		/// <summary>
		/// Implied dockspace_id = 0, viewport = NULL, flags = 0, window_class = NULL
		/// </summary>
		public static uint DockSpaceOverViewport()
		{
			var ret = ImGuiNative.ImGui_DockSpaceOverViewport();
			return ret;
		}

		/// <summary>
		/// Implied dockspace_id = 0, viewport = NULL, flags = 0, window_class = NULL
		/// </summary>
		public static uint DockSpaceOverViewport(uint dockspace_id)
		{
			ImGuiViewport* viewport = null;

			ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;

			ImGuiWindowClass* window_class = null;

			var ret = ImGuiNative.ImGui_DockSpaceOverViewportEx(dockspace_id, viewport, flags, window_class);
			return ret;
		}
		/// <summary>
		/// Implied dockspace_id = 0, viewport = NULL, flags = 0, window_class = NULL
		/// </summary>
		public static uint DockSpaceOverViewport(uint dockspace_id, ImGuiViewportPtr viewport)
		{
			ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;

			ImGuiWindowClass* window_class = null;

			var ret = ImGuiNative.ImGui_DockSpaceOverViewportEx(dockspace_id, viewport, flags, window_class);
			return ret;
		}
		/// <summary>
		/// Implied dockspace_id = 0, viewport = NULL, flags = 0, window_class = NULL
		/// </summary>
		public static uint DockSpaceOverViewport(uint dockspace_id, ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags)
		{
			ImGuiWindowClass* window_class = null;

			var ret = ImGuiNative.ImGui_DockSpaceOverViewportEx(dockspace_id, viewport, flags, window_class);
			return ret;
		}
		/// <summary>
		/// Implied dockspace_id = 0, viewport = NULL, flags = 0, window_class = NULL
		/// </summary>
		public static uint DockSpaceOverViewport(uint dockspace_id, ImGuiViewportPtr viewport, ImGuiDockNodeFlags flags, ImGuiWindowClassPtr window_class)
		{
			var ret = ImGuiNative.ImGui_DockSpaceOverViewportEx(dockspace_id, viewport, flags, window_class);
			return ret;
		}

		/// <summary>
		/// set next window dock id
		/// </summary>
		public static void SetNextWindowDockID(uint dock_id)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiNative.ImGui_SetNextWindowDockID(dock_id, cond);
		}
		/// <summary>
		/// set next window dock id
		/// </summary>
		public static void SetNextWindowDockID(uint dock_id, ImGuiCond cond)
		{
			ImGuiNative.ImGui_SetNextWindowDockID(dock_id, cond);
		}

		/// <summary>
		/// set next window class (control docking compatibility + provide hints to platform backend via custom viewport flags and platform parent/child relationship)
		/// </summary>
		public static void SetNextWindowClass(ImGuiWindowClassPtr window_class)
		{
			ImGuiNative.ImGui_SetNextWindowClass(window_class);
		}

		public static uint GetWindowDockID()
		{
			var ret = ImGuiNative.ImGui_GetWindowDockID();
			return ret;
		}

		/// <summary>
		/// is current window docked into another window?
		/// </summary>
		public static bool IsWindowDocked()
		{
			var ret = ImGuiNative.ImGui_IsWindowDocked();
			return ret != 0;
		}

		/// <summary>
		/// <para>Logging/Capture</para>
		/// <para>- All text output from the interface can be captured into tty/file/clipboard. By default, tree nodes are automatically opened during logging.</para>
		/// </summary>
		/// <summary>
		/// start logging to tty (stdout)
		/// </summary>
		public static void LogToTTY()
		{
			int auto_open_depth = -1;

			ImGuiNative.ImGui_LogToTTY(auto_open_depth);
		}
		/// <summary>
		/// <para>Logging/Capture</para>
		/// <para>- All text output from the interface can be captured into tty/file/clipboard. By default, tree nodes are automatically opened during logging.</para>
		/// </summary>
		/// <summary>
		/// start logging to tty (stdout)
		/// </summary>
		public static void LogToTTY(int auto_open_depth)
		{
			ImGuiNative.ImGui_LogToTTY(auto_open_depth);
		}

		/// <summary>
		/// start logging to file
		/// </summary>
		public static void LogToFile()
		{
			int auto_open_depth = -1;

			byte* filename = null;

			ImGuiNative.ImGui_LogToFile(auto_open_depth, filename);
		}
		/// <summary>
		/// start logging to file
		/// </summary>
		public static void LogToFile(int auto_open_depth)
		{
			byte* filename = null;

			ImGuiNative.ImGui_LogToFile(auto_open_depth, filename);
		}
		/// <summary>
		/// start logging to file
		/// </summary>
		public static void LogToFile(int auto_open_depth, ReadOnlySpan<char> filename)
		{
			// Marshaling 'filename' to native string
			byte* native_filename;
			var filename_byteCount = 0;
			if (filename != null)
			{
				filename_byteCount = Encoding.UTF8.GetByteCount(filename);
				if (filename_byteCount > Util.StackAllocationSizeLimit)
				{
					native_filename = Util.Allocate(filename_byteCount + 1);
				}
				else
				{
					var native_filename_stackBytes = stackalloc byte[filename_byteCount + 1];
					native_filename = native_filename_stackBytes;
				}
				var filename_offset = Util.GetUtf8(filename, native_filename, filename_byteCount);
				native_filename[filename_offset] = 0;
			}
			else native_filename = null;

			ImGuiNative.ImGui_LogToFile(auto_open_depth, native_filename);
			if (filename_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_filename);
			}
		}

		/// <summary>
		/// start logging to OS clipboard
		/// </summary>
		public static void LogToClipboard()
		{
			int auto_open_depth = -1;

			ImGuiNative.ImGui_LogToClipboard(auto_open_depth);
		}
		/// <summary>
		/// start logging to OS clipboard
		/// </summary>
		public static void LogToClipboard(int auto_open_depth)
		{
			ImGuiNative.ImGui_LogToClipboard(auto_open_depth);
		}

		/// <summary>
		/// stop logging (close file, etc.)
		/// </summary>
		public static void LogFinish()
		{
			ImGuiNative.ImGui_LogFinish();
		}

		/// <summary>
		/// helper to display buttons for logging to tty/file/clipboard
		/// </summary>
		public static void LogButtons()
		{
			ImGuiNative.ImGui_LogButtons();
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)
		/// </summary>
		public static void LogText(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_LogText(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// pass text data straight to log (without being displayed)
		/// </summary>
		public static void LogTextUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_LogTextUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

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
		public static bool BeginDragDropSource()
		{
			ImGuiDragDropFlags flags = (ImGuiDragDropFlags)0;

			var ret = ImGuiNative.ImGui_BeginDragDropSource(flags);
			return ret != 0;
		}
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
		public static bool BeginDragDropSource(ImGuiDragDropFlags flags)
		{
			var ret = ImGuiNative.ImGui_BeginDragDropSource(flags);
			return ret != 0;
		}

		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.
		/// </summary>
		public static bool SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz)
		{
			// Marshaling 'type' to native string
			byte* native_type;
			var type_byteCount = 0;
			if (type != null)
			{
				type_byteCount = Encoding.UTF8.GetByteCount(type);
				if (type_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type = Util.Allocate(type_byteCount + 1);
				}
				else
				{
					var native_type_stackBytes = stackalloc byte[type_byteCount + 1];
					native_type = native_type_stackBytes;
				}
				var type_offset = Util.GetUtf8(type, native_type, type_byteCount);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			ImGuiCond cond = (ImGuiCond)0;

			var ret = ImGuiNative.ImGui_SetDragDropPayload(native_type, native_data, sz, cond);
			if (type_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type);
			}
			return ret != 0;
		}
		/// <summary>
		/// type is a user defined string of maximum 32 characters. Strings starting with '_' are reserved for dear imgui internal types. Data is copied and held by imgui. Return true when payload has been accepted.
		/// </summary>
		public static bool SetDragDropPayload(ReadOnlySpan<char> type, IntPtr data, uint sz, ImGuiCond cond)
		{
			// Marshaling 'type' to native string
			byte* native_type;
			var type_byteCount = 0;
			if (type != null)
			{
				type_byteCount = Encoding.UTF8.GetByteCount(type);
				if (type_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type = Util.Allocate(type_byteCount + 1);
				}
				else
				{
					var native_type_stackBytes = stackalloc byte[type_byteCount + 1];
					native_type = native_type_stackBytes;
				}
				var type_offset = Util.GetUtf8(type, native_type, type_byteCount);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			var ret = ImGuiNative.ImGui_SetDragDropPayload(native_type, native_data, sz, cond);
			if (type_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type);
			}
			return ret != 0;
		}

		/// <summary>
		/// only call EndDragDropSource() if BeginDragDropSource() returns true!
		/// </summary>
		public static void EndDragDropSource()
		{
			ImGuiNative.ImGui_EndDragDropSource();
		}

		/// <summary>
		/// call after submitting an item that may receive a payload. If this returns true, you can call AcceptDragDropPayload() + EndDragDropTarget()
		/// </summary>
		public static bool BeginDragDropTarget()
		{
			var ret = ImGuiNative.ImGui_BeginDragDropTarget();
			return ret != 0;
		}

		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type)
		{
			// Marshaling 'type' to native string
			byte* native_type;
			var type_byteCount = 0;
			if (type != null)
			{
				type_byteCount = Encoding.UTF8.GetByteCount(type);
				if (type_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type = Util.Allocate(type_byteCount + 1);
				}
				else
				{
					var native_type_stackBytes = stackalloc byte[type_byteCount + 1];
					native_type = native_type_stackBytes;
				}
				var type_offset = Util.GetUtf8(type, native_type, type_byteCount);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			ImGuiDragDropFlags flags = (ImGuiDragDropFlags)0;

			var ret = ImGuiNative.ImGui_AcceptDragDropPayload(native_type, flags);
			if (type_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type);
			}
			return ret;
		}
		/// <summary>
		/// accept contents of a given type. If ImGuiDragDropFlags_AcceptBeforeDelivery is set you can peek into the payload before the mouse button is released.
		/// </summary>
		public static ImGuiPayloadPtr AcceptDragDropPayload(ReadOnlySpan<char> type, ImGuiDragDropFlags flags)
		{
			// Marshaling 'type' to native string
			byte* native_type;
			var type_byteCount = 0;
			if (type != null)
			{
				type_byteCount = Encoding.UTF8.GetByteCount(type);
				if (type_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type = Util.Allocate(type_byteCount + 1);
				}
				else
				{
					var native_type_stackBytes = stackalloc byte[type_byteCount + 1];
					native_type = native_type_stackBytes;
				}
				var type_offset = Util.GetUtf8(type, native_type, type_byteCount);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			var ret = ImGuiNative.ImGui_AcceptDragDropPayload(native_type, flags);
			if (type_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type);
			}
			return ret;
		}

		/// <summary>
		/// only call EndDragDropTarget() if BeginDragDropTarget() returns true!
		/// </summary>
		public static void EndDragDropTarget()
		{
			ImGuiNative.ImGui_EndDragDropTarget();
		}

		/// <summary>
		/// peek directly into the current payload from anywhere. returns NULL when drag and drop is finished or inactive. use ImGuiPayload::IsDataType() to test for the payload type.
		/// </summary>
		public static ImGuiPayloadPtr GetDragDropPayload()
		{
			var ret = ImGuiNative.ImGui_GetDragDropPayload();
			return ret;
		}

		/// <summary>
		/// <para>Disabling [BETA API]</para>
		/// <para>- Disable all user interactions and dim items visuals (applying style.DisabledAlpha over current colors)</para>
		/// <para>- Those can be nested but it cannot be used to enable an already disabled section (a single BeginDisabled(true) in the stack is enough to keep everything disabled)</para>
		/// <para>- Tooltips windows by exception are opted out of disabling.</para>
		/// <para>- BeginDisabled(false)/EndDisabled() essentially does nothing but is provided to facilitate use of boolean expressions (as a micro-optimization: if you have tens of thousands of BeginDisabled(false)/EndDisabled() pairs, you might want to reformulate your code to avoid making those calls)</para>
		/// </summary>
		public static void BeginDisabled()
		{
			byte disabled = 1;

			ImGuiNative.ImGui_BeginDisabled(disabled);
		}
		/// <summary>
		/// <para>Disabling [BETA API]</para>
		/// <para>- Disable all user interactions and dim items visuals (applying style.DisabledAlpha over current colors)</para>
		/// <para>- Those can be nested but it cannot be used to enable an already disabled section (a single BeginDisabled(true) in the stack is enough to keep everything disabled)</para>
		/// <para>- Tooltips windows by exception are opted out of disabling.</para>
		/// <para>- BeginDisabled(false)/EndDisabled() essentially does nothing but is provided to facilitate use of boolean expressions (as a micro-optimization: if you have tens of thousands of BeginDisabled(false)/EndDisabled() pairs, you might want to reformulate your code to avoid making those calls)</para>
		/// </summary>
		public static void BeginDisabled(bool disabled)
		{
			// Marshaling 'disabled' to native bool
			var native_disabled = disabled ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_BeginDisabled(native_disabled);
		}

		public static void EndDisabled()
		{
			ImGuiNative.ImGui_EndDisabled();
		}

		/// <summary>
		/// <para>Clipping</para>
		/// <para>- Mouse hovering is affected by ImGui::PushClipRect() calls, unlike direct calls to ImDrawList::PushClipRect() which are render only.</para>
		/// </summary>
		public static void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
		{
			// Marshaling 'intersect_with_current_clip_rect' to native bool
			var native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_PushClipRect(clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
		}

		public static void PopClipRect()
		{
			ImGuiNative.ImGui_PopClipRect();
		}

		/// <summary>
		/// <para>Focus, Activation</para>
		/// </summary>
		/// <summary>
		/// make last item the default focused item of of a newly appearing window.
		/// </summary>
		public static void SetItemDefaultFocus()
		{
			ImGuiNative.ImGui_SetItemDefaultFocus();
		}

		/// <summary>
		/// Implied offset = 0
		/// </summary>
		public static void SetKeyboardFocusHere()
		{
			ImGuiNative.ImGui_SetKeyboardFocusHere();
		}

		/// <summary>
		/// Implied offset = 0
		/// </summary>
		public static void SetKeyboardFocusHere(int offset)
		{
			ImGuiNative.ImGui_SetKeyboardFocusHereEx(offset);
		}

		/// <summary>
		/// <para>Keyboard/Gamepad Navigation</para>
		/// </summary>
		/// <summary>
		/// alter visibility of keyboard/gamepad cursor. by default: show when using an arrow key, hide when clicking with mouse.
		/// </summary>
		public static void SetNavCursorVisible(bool visible)
		{
			// Marshaling 'visible' to native bool
			var native_visible = visible ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetNavCursorVisible(native_visible);
		}

		/// <summary>
		/// <para>Overlapping mode</para>
		/// </summary>
		/// <summary>
		/// allow next item to be overlapped by a subsequent item. Useful with invisible buttons, selectable, treenode covering an area where subsequent items may need to be added. Note that both Selectable() and TreeNode() have dedicated flags doing this.
		/// </summary>
		public static void SetNextItemAllowOverlap()
		{
			ImGuiNative.ImGui_SetNextItemAllowOverlap();
		}

		/// <summary>
		/// <para>Item/Widgets Utilities and Query Functions</para>
		/// <para>- Most of the functions are referring to the previous Item that has been submitted.</para>
		/// <para>- See Demo Window under "Widgets-&gt;Querying Status" for an interactive visualization of most of those functions.</para>
		/// </summary>
		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.
		/// </summary>
		public static bool IsItemHovered()
		{
			ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;

			var ret = ImGuiNative.ImGui_IsItemHovered(flags);
			return ret != 0;
		}
		/// <summary>
		/// <para>Item/Widgets Utilities and Query Functions</para>
		/// <para>- Most of the functions are referring to the previous Item that has been submitted.</para>
		/// <para>- See Demo Window under "Widgets-&gt;Querying Status" for an interactive visualization of most of those functions.</para>
		/// </summary>
		/// <summary>
		/// is the last item hovered? (and usable, aka not blocked by a popup, etc.). See ImGuiHoveredFlags for more options.
		/// </summary>
		public static bool IsItemHovered(ImGuiHoveredFlags flags)
		{
			var ret = ImGuiNative.ImGui_IsItemHovered(flags);
			return ret != 0;
		}

		/// <summary>
		/// is the last item active? (e.g. button being held, text field being edited. This will continuously return true while holding mouse button on an item. Items that don't interact will always return false)
		/// </summary>
		public static bool IsItemActive()
		{
			var ret = ImGuiNative.ImGui_IsItemActive();
			return ret != 0;
		}

		/// <summary>
		/// is the last item focused for keyboard/gamepad navigation?
		/// </summary>
		public static bool IsItemFocused()
		{
			var ret = ImGuiNative.ImGui_IsItemFocused();
			return ret != 0;
		}

		/// <summary>
		/// Implied mouse_button = 0
		/// </summary>
		public static bool IsItemClicked()
		{
			var ret = ImGuiNative.ImGui_IsItemClicked();
			return ret != 0;
		}

		/// <summary>
		/// Implied mouse_button = 0
		/// </summary>
		public static bool IsItemClicked(ImGuiMouseButton mouse_button)
		{
			var ret = ImGuiNative.ImGui_IsItemClickedEx(mouse_button);
			return ret != 0;
		}

		/// <summary>
		/// is the last item visible? (items may be out of sight because of clipping/scrolling)
		/// </summary>
		public static bool IsItemVisible()
		{
			var ret = ImGuiNative.ImGui_IsItemVisible();
			return ret != 0;
		}

		/// <summary>
		/// did the last item modify its underlying value this frame? or was pressed? This is generally the same as the "bool" return value of many widgets.
		/// </summary>
		public static bool IsItemEdited()
		{
			var ret = ImGuiNative.ImGui_IsItemEdited();
			return ret != 0;
		}

		/// <summary>
		/// was the last item just made active (item was previously inactive).
		/// </summary>
		public static bool IsItemActivated()
		{
			var ret = ImGuiNative.ImGui_IsItemActivated();
			return ret != 0;
		}

		/// <summary>
		/// was the last item just made inactive (item was previously active). Useful for Undo/Redo patterns with widgets that require continuous editing.
		/// </summary>
		public static bool IsItemDeactivated()
		{
			var ret = ImGuiNative.ImGui_IsItemDeactivated();
			return ret != 0;
		}

		/// <summary>
		/// was the last item just made inactive and made a value change when it was active? (e.g. Slider/Drag moved). Useful for Undo/Redo patterns with widgets that require continuous editing. Note that you may get false positives (some widgets such as Combo()/ListBox()/Selectable() will return true even when clicking an already selected item).
		/// </summary>
		public static bool IsItemDeactivatedAfterEdit()
		{
			var ret = ImGuiNative.ImGui_IsItemDeactivatedAfterEdit();
			return ret != 0;
		}

		/// <summary>
		/// was the last item open state toggled? set by TreeNode().
		/// </summary>
		public static bool IsItemToggledOpen()
		{
			var ret = ImGuiNative.ImGui_IsItemToggledOpen();
			return ret != 0;
		}

		/// <summary>
		/// is any item hovered?
		/// </summary>
		public static bool IsAnyItemHovered()
		{
			var ret = ImGuiNative.ImGui_IsAnyItemHovered();
			return ret != 0;
		}

		/// <summary>
		/// is any item active?
		/// </summary>
		public static bool IsAnyItemActive()
		{
			var ret = ImGuiNative.ImGui_IsAnyItemActive();
			return ret != 0;
		}

		/// <summary>
		/// is any item focused?
		/// </summary>
		public static bool IsAnyItemFocused()
		{
			var ret = ImGuiNative.ImGui_IsAnyItemFocused();
			return ret != 0;
		}

		/// <summary>
		/// get ID of last item (~~ often same ImGui::GetID(label) beforehand)
		/// </summary>
		public static uint GetItemID()
		{
			var ret = ImGuiNative.ImGui_GetItemID();
			return ret;
		}

		/// <summary>
		/// get upper-left bounding rectangle of the last item (screen space)
		/// </summary>
		public static Vector2 GetItemRectMin()
		{
			var ret = ImGuiNative.ImGui_GetItemRectMin();
			return ret;
		}

		/// <summary>
		/// get lower-right bounding rectangle of the last item (screen space)
		/// </summary>
		public static Vector2 GetItemRectMax()
		{
			var ret = ImGuiNative.ImGui_GetItemRectMax();
			return ret;
		}

		/// <summary>
		/// get size of last item
		/// </summary>
		public static Vector2 GetItemRectSize()
		{
			var ret = ImGuiNative.ImGui_GetItemRectSize();
			return ret;
		}

		/// <summary>
		/// <para>Viewports</para>
		/// <para>- Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.</para>
		/// <para>- In 'docking' branch with multi-viewport enabled, we extend this concept to have multiple active viewports.</para>
		/// <para>- In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.</para>
		/// </summary>
		/// <summary>
		/// return primary/default viewport. This can never be NULL.
		/// </summary>
		public static ImGuiViewportPtr GetMainViewport()
		{
			var ret = ImGuiNative.ImGui_GetMainViewport();
			return ret;
		}

		/// <summary>
		/// <para>Background/Foreground Draw Lists</para>
		/// </summary>
		/// <summary>
		/// Implied viewport = NULL
		/// </summary>
		public static ImDrawListPtr GetBackgroundDrawList()
		{
			var ret = ImGuiNative.ImGui_GetBackgroundDrawList();
			return ret;
		}

		/// <summary>
		/// <para>Background/Foreground Draw Lists</para>
		/// </summary>
		/// <summary>
		/// Implied viewport = NULL
		/// </summary>
		public static ImDrawListPtr GetBackgroundDrawList(ImGuiViewportPtr viewport)
		{
			var ret = ImGuiNative.ImGui_GetBackgroundDrawListEx(viewport);
			return ret;
		}

		/// <summary>
		/// Implied viewport = NULL
		/// </summary>
		public static ImDrawListPtr GetForegroundDrawList()
		{
			var ret = ImGuiNative.ImGui_GetForegroundDrawList();
			return ret;
		}

		/// <summary>
		/// Implied viewport = NULL
		/// </summary>
		public static ImDrawListPtr GetForegroundDrawList(ImGuiViewportPtr viewport)
		{
			var ret = ImGuiNative.ImGui_GetForegroundDrawListEx(viewport);
			return ret;
		}

		/// <summary>
		/// <para>Miscellaneous Utilities</para>
		/// </summary>
		/// <summary>
		/// test if rectangle (of given size, starting from cursor position) is visible / not clipped.
		/// </summary>
		public static bool IsRectVisibleBySize(Vector2 size)
		{
			var ret = ImGuiNative.ImGui_IsRectVisibleBySize(size);
			return ret != 0;
		}

		/// <summary>
		/// test if rectangle (in screen space) is visible / not clipped. to perform coarse clipping on user's side.
		/// </summary>
		public static bool IsRectVisible(Vector2 rect_min, Vector2 rect_max)
		{
			var ret = ImGuiNative.ImGui_IsRectVisible(rect_min, rect_max);
			return ret != 0;
		}

		/// <summary>
		/// get global imgui time. incremented by io.DeltaTime every frame.
		/// </summary>
		public static double GetTime()
		{
			var ret = ImGuiNative.ImGui_GetTime();
			return ret;
		}

		/// <summary>
		/// get global imgui frame count. incremented by 1 every frame.
		/// </summary>
		public static int GetFrameCount()
		{
			var ret = ImGuiNative.ImGui_GetFrameCount();
			return ret;
		}

		/// <summary>
		/// you may use this when creating your own ImDrawList instances.
		/// </summary>
		public static IntPtr GetDrawListSharedData()
		{
			var ret = ImGuiNative.ImGui_GetDrawListSharedData();
			return ret;
		}

		/// <summary>
		/// get a string corresponding to the enum value (for display, saving, etc.).
		/// </summary>
		public static string GetStyleColorName(ImGuiCol idx)
		{
			var ret = ImGuiNative.ImGui_GetStyleColorName(idx);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// replace current window storage with our own (if you want to manipulate it yourself, typically clear subsection of it)
		/// </summary>
		public static void SetStateStorage(ImGuiStoragePtr storage)
		{
			ImGuiNative.ImGui_SetStateStorage(storage);
		}

		public static ImGuiStoragePtr GetStateStorage()
		{
			var ret = ImGuiNative.ImGui_GetStateStorage();
			return ret;
		}

		/// <summary>
		/// <para>Text Utilities</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_double_hash = false, wrap_width = -1.0f
		/// </summary>
		public static Vector2 CalcTextSize(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			var ret = ImGuiNative.ImGui_CalcTextSize(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return ret;
		}

		/// <summary>
		/// <para>Text Utilities</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_double_hash = false, wrap_width = -1.0f
		/// </summary>
		public static Vector2 CalcTextSize(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			byte hide_text_after_double_hash = 0;

			float wrap_width = -1.0f;

			var ret = ImGuiNative.ImGui_CalcTextSizeEx(native_text, native_text_end, hide_text_after_double_hash, wrap_width);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return ret;
		}
		/// <summary>
		/// <para>Text Utilities</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_double_hash = false, wrap_width = -1.0f
		/// </summary>
		public static Vector2 CalcTextSize(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, bool hide_text_after_double_hash)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			// Marshaling 'hide_text_after_double_hash' to native bool
			var native_hide_text_after_double_hash = hide_text_after_double_hash ? (byte)1 : (byte)0;

			float wrap_width = -1.0f;

			var ret = ImGuiNative.ImGui_CalcTextSizeEx(native_text, native_text_end, native_hide_text_after_double_hash, wrap_width);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return ret;
		}
		/// <summary>
		/// <para>Text Utilities</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_double_hash = false, wrap_width = -1.0f
		/// </summary>
		public static Vector2 CalcTextSize(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, bool hide_text_after_double_hash, float wrap_width)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			// Marshaling 'hide_text_after_double_hash' to native bool
			var native_hide_text_after_double_hash = hide_text_after_double_hash ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_CalcTextSizeEx(native_text, native_text_end, native_hide_text_after_double_hash, wrap_width);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return ret;
		}

		/// <summary>
		/// <para>Color Utilities</para>
		/// </summary>
		public static Vector4 ColorConvertU32ToFloat4(uint _in)
		{
			var ret = ImGuiNative.ImGui_ColorConvertU32ToFloat4(_in);
			return ret;
		}

		public static uint ColorConvertFloat4ToU32(Vector4 _in)
		{
			var ret = ImGuiNative.ImGui_ColorConvertFloat4ToU32(_in);
			return ret;
		}

		public static void ColorConvertRGBtoHSV(float r, float g, float b, out float out_h, out float out_s, out float out_v)
		{
			fixed (float* native_out_h = &out_h)
			fixed (float* native_out_s = &out_s)
			fixed (float* native_out_v = &out_v)
			{
				ImGuiNative.ImGui_ColorConvertRGBtoHSV(r, g, b, native_out_h, native_out_s, native_out_v);
			}
		}

		public static void ColorConvertHSVtoRGB(float h, float s, float v, out float out_r, out float out_g, out float out_b)
		{
			fixed (float* native_out_r = &out_r)
			fixed (float* native_out_g = &out_g)
			fixed (float* native_out_b = &out_b)
			{
				ImGuiNative.ImGui_ColorConvertHSVtoRGB(h, s, v, native_out_r, native_out_g, native_out_b);
			}
		}

		/// <summary>
		/// <para>Inputs Utilities: Keyboard/Mouse/Gamepad</para>
		/// <para>- the ImGuiKey enum contains all possible keyboard, mouse and gamepad inputs (e.g. ImGuiKey_A, ImGuiKey_MouseLeft, ImGuiKey_GamepadDpadUp...).</para>
		/// <para>- (legacy: before v1.87, we used ImGuiKey to carry native/user indices as defined by each backends. This was obsoleted in 1.87 (2022-02) and completely removed in 1.91.5 (2024-11). See https://github.com/ocornut/imgui/issues/4921)</para>
		/// <para>- (legacy: any use of ImGuiKey will assert when key &lt; 512 to detect passing legacy native/user indices)</para>
		/// </summary>
		/// <summary>
		/// is key being held.
		/// </summary>
		public static bool IsKeyDown(ImGuiKey key)
		{
			var ret = ImGuiNative.ImGui_IsKeyDown(key);
			return ret != 0;
		}

		/// <summary>
		/// Implied repeat = true
		/// </summary>
		public static bool IsKeyPressed(ImGuiKey key)
		{
			var ret = ImGuiNative.ImGui_IsKeyPressed(key);
			return ret != 0;
		}

		/// <summary>
		/// Implied repeat = true
		/// </summary>
		public static bool IsKeyPressed(ImGuiKey key, bool repeat)
		{
			// Marshaling 'repeat' to native bool
			var native_repeat = repeat ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_IsKeyPressedEx(key, native_repeat);
			return ret != 0;
		}

		/// <summary>
		/// was key released (went from Down to !Down)?
		/// </summary>
		public static bool IsKeyReleased(ImGuiKey key)
		{
			var ret = ImGuiNative.ImGui_IsKeyReleased(key);
			return ret != 0;
		}

		/// <summary>
		/// was key chord (mods + key) pressed, e.g. you can pass 'ImGuiMod_Ctrl | ImGuiKey_S' as a key-chord. This doesn't do any routing or focus check, please consider using Shortcut() function instead.
		/// </summary>
		public static bool IsKeyChordPressed(ImGuiKey key_chord)
		{
			var ret = ImGuiNative.ImGui_IsKeyChordPressed(key_chord);
			return ret != 0;
		}

		/// <summary>
		/// uses provided repeat rate/delay. return a count, most often 0 or 1 but might be &gt;1 if RepeatRate is small enough that DeltaTime &gt; RepeatRate
		/// </summary>
		public static int GetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate)
		{
			var ret = ImGuiNative.ImGui_GetKeyPressedAmount(key, repeat_delay, rate);
			return ret;
		}

		/// <summary>
		/// [DEBUG] returns English name of the key. Those names a provided for debugging purpose and are not meant to be saved persistently not compared.
		/// </summary>
		public static string GetKeyName(ImGuiKey key)
		{
			var ret = ImGuiNative.ImGui_GetKeyName(key);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// Override io.WantCaptureKeyboard flag next frame (said flag is left for your application to handle, typically when true it instructs your app to ignore inputs). e.g. force capture keyboard when your widget is being hovered. This is equivalent to setting "io.WantCaptureKeyboard = want_capture_keyboard"; after the next NewFrame() call.
		/// </summary>
		public static void SetNextFrameWantCaptureKeyboard(bool want_capture_keyboard)
		{
			// Marshaling 'want_capture_keyboard' to native bool
			var native_want_capture_keyboard = want_capture_keyboard ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetNextFrameWantCaptureKeyboard(native_want_capture_keyboard);
		}

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
		public static bool Shortcut(ImGuiKey key_chord)
		{
			ImGuiInputFlags flags = (ImGuiInputFlags)0;

			var ret = ImGuiNative.ImGui_Shortcut(key_chord, flags);
			return ret != 0;
		}
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
		public static bool Shortcut(ImGuiKey key_chord, ImGuiInputFlags flags)
		{
			var ret = ImGuiNative.ImGui_Shortcut(key_chord, flags);
			return ret != 0;
		}

		public static void SetNextItemShortcut(ImGuiKey key_chord)
		{
			ImGuiInputFlags flags = (ImGuiInputFlags)0;

			ImGuiNative.ImGui_SetNextItemShortcut(key_chord, flags);
		}
		public static void SetNextItemShortcut(ImGuiKey key_chord, ImGuiInputFlags flags)
		{
			ImGuiNative.ImGui_SetNextItemShortcut(key_chord, flags);
		}

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
		public static void SetItemKeyOwner(ImGuiKey key)
		{
			ImGuiNative.ImGui_SetItemKeyOwner(key);
		}

		/// <summary>
		/// <para>Inputs Utilities: Mouse</para>
		/// <para>- To refer to a mouse button, you may use named enums in your code e.g. ImGuiMouseButton_Left, ImGuiMouseButton_Right.</para>
		/// <para>- You can also use regular integer: it is forever guaranteed that 0=Left, 1=Right, 2=Middle.</para>
		/// <para>- Dragging operations are only reported after mouse has moved a certain distance away from the initial clicking position (see 'lock_threshold' and 'io.MouseDraggingThreshold')</para>
		/// </summary>
		/// <summary>
		/// is mouse button held?
		/// </summary>
		public static bool IsMouseDown(ImGuiMouseButton button)
		{
			var ret = ImGuiNative.ImGui_IsMouseDown(button);
			return ret != 0;
		}

		/// <summary>
		/// Implied repeat = false
		/// </summary>
		public static bool IsMouseClicked(ImGuiMouseButton button)
		{
			var ret = ImGuiNative.ImGui_IsMouseClicked(button);
			return ret != 0;
		}

		/// <summary>
		/// Implied repeat = false
		/// </summary>
		public static bool IsMouseClicked(ImGuiMouseButton button, bool repeat)
		{
			// Marshaling 'repeat' to native bool
			var native_repeat = repeat ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_IsMouseClickedEx(button, native_repeat);
			return ret != 0;
		}

		/// <summary>
		/// did mouse button released? (went from Down to !Down)
		/// </summary>
		public static bool IsMouseReleased(ImGuiMouseButton button)
		{
			var ret = ImGuiNative.ImGui_IsMouseReleased(button);
			return ret != 0;
		}

		/// <summary>
		/// did mouse button double-clicked? Same as GetMouseClickedCount() == 2. (note that a double-click will also report IsMouseClicked() == true)
		/// </summary>
		public static bool IsMouseDoubleClicked(ImGuiMouseButton button)
		{
			var ret = ImGuiNative.ImGui_IsMouseDoubleClicked(button);
			return ret != 0;
		}

		/// <summary>
		/// return the number of successive mouse-clicks at the time where a click happen (otherwise 0).
		/// </summary>
		public static int GetMouseClickedCount(ImGuiMouseButton button)
		{
			var ret = ImGuiNative.ImGui_GetMouseClickedCount(button);
			return ret;
		}

		/// <summary>
		/// Implied clip = true
		/// </summary>
		public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max)
		{
			var ret = ImGuiNative.ImGui_IsMouseHoveringRect(r_min, r_max);
			return ret != 0;
		}

		/// <summary>
		/// Implied clip = true
		/// </summary>
		public static bool IsMouseHoveringRect(Vector2 r_min, Vector2 r_max, bool clip)
		{
			// Marshaling 'clip' to native bool
			var native_clip = clip ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGui_IsMouseHoveringRectEx(r_min, r_max, native_clip);
			return ret != 0;
		}

		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available
		/// </summary>
		public static bool IsMousePosValid()
		{
			Vector2* mouse_pos = null;

			var ret = ImGuiNative.ImGui_IsMousePosValid(mouse_pos);
			return ret != 0;
		}
		/// <summary>
		/// by convention we use (-FLT_MAX,-FLT_MAX) to denote that there is no mouse available
		/// </summary>
		public static bool IsMousePosValid(ref Vector2 mouse_pos)
		{
			fixed (Vector2* native_mouse_pos = &mouse_pos)
			{
				var ret = ImGuiNative.ImGui_IsMousePosValid(native_mouse_pos);
				return ret != 0;
			}
		}

		/// <summary>
		/// [WILL OBSOLETE] is any mouse button held? This was designed for backends, but prefer having backend maintain a mask of held mouse buttons, because upcoming input queue system will make this invalid.
		/// </summary>
		public static bool IsAnyMouseDown()
		{
			var ret = ImGuiNative.ImGui_IsAnyMouseDown();
			return ret != 0;
		}

		/// <summary>
		/// shortcut to ImGui::GetIO().MousePos provided by user, to be consistent with other calls
		/// </summary>
		public static Vector2 GetMousePos()
		{
			var ret = ImGuiNative.ImGui_GetMousePos();
			return ret;
		}

		/// <summary>
		/// retrieve mouse position at the time of opening popup we have BeginPopup() into (helper to avoid user backing that value themselves)
		/// </summary>
		public static Vector2 GetMousePosOnOpeningCurrentPopup()
		{
			var ret = ImGuiNative.ImGui_GetMousePosOnOpeningCurrentPopup();
			return ret;
		}

		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		public static bool IsMouseDragging(ImGuiMouseButton button)
		{
			float lock_threshold = -1.0f;

			var ret = ImGuiNative.ImGui_IsMouseDragging(button, lock_threshold);
			return ret != 0;
		}
		/// <summary>
		/// is mouse dragging? (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		public static bool IsMouseDragging(ImGuiMouseButton button, float lock_threshold)
		{
			var ret = ImGuiNative.ImGui_IsMouseDragging(button, lock_threshold);
			return ret != 0;
		}

		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		public static Vector2 GetMouseDragDelta()
		{
			ImGuiMouseButton button = (ImGuiMouseButton)0;

			float lock_threshold = -1.0f;

			var ret = ImGuiNative.ImGui_GetMouseDragDelta(button, lock_threshold);
			return ret;
		}
		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		public static Vector2 GetMouseDragDelta(ImGuiMouseButton button)
		{
			float lock_threshold = -1.0f;

			var ret = ImGuiNative.ImGui_GetMouseDragDelta(button, lock_threshold);
			return ret;
		}
		/// <summary>
		/// return the delta from the initial clicking position while the mouse button is pressed or was just released. This is locked and return 0.0f until the mouse moves past a distance threshold at least once (uses io.MouseDraggingThreshold if lock_threshold &lt; 0.0f)
		/// </summary>
		public static Vector2 GetMouseDragDelta(ImGuiMouseButton button, float lock_threshold)
		{
			var ret = ImGuiNative.ImGui_GetMouseDragDelta(button, lock_threshold);
			return ret;
		}

		/// <summary>
		/// Implied button = 0
		/// </summary>
		public static void ResetMouseDragDelta()
		{
			ImGuiNative.ImGui_ResetMouseDragDelta();
		}

		/// <summary>
		/// Implied button = 0
		/// </summary>
		public static void ResetMouseDragDelta(ImGuiMouseButton button)
		{
			ImGuiNative.ImGui_ResetMouseDragDeltaEx(button);
		}

		/// <summary>
		/// get desired mouse cursor shape. Important: reset in ImGui::NewFrame(), this is updated during the frame. valid before Render(). If you use software rendering by setting io.MouseDrawCursor ImGui will render those for you
		/// </summary>
		public static ImGuiMouseCursor GetMouseCursor()
		{
			var ret = ImGuiNative.ImGui_GetMouseCursor();
			return ret;
		}

		/// <summary>
		/// set desired mouse cursor shape
		/// </summary>
		public static void SetMouseCursor(ImGuiMouseCursor cursor_type)
		{
			ImGuiNative.ImGui_SetMouseCursor(cursor_type);
		}

		/// <summary>
		/// Override io.WantCaptureMouse flag next frame (said flag is left for your application to handle, typical when true it instucts your app to ignore inputs). This is equivalent to setting "io.WantCaptureMouse = want_capture_mouse;" after the next NewFrame() call.
		/// </summary>
		public static void SetNextFrameWantCaptureMouse(bool want_capture_mouse)
		{
			// Marshaling 'want_capture_mouse' to native bool
			var native_want_capture_mouse = want_capture_mouse ? (byte)1 : (byte)0;

			ImGuiNative.ImGui_SetNextFrameWantCaptureMouse(native_want_capture_mouse);
		}

		/// <summary>
		/// <para>Clipboard Utilities</para>
		/// <para>- Also see the LogToClipboard() function to capture GUI into clipboard, or easily output text data to the clipboard.</para>
		/// </summary>
		public static string GetClipboardText()
		{
			var ret = ImGuiNative.ImGui_GetClipboardText();
			return Util.StringFromPtr(ret);
		}

		public static void SetClipboardText(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_SetClipboardText(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// <para>Settings/.Ini Utilities</para>
		/// <para>- The disk functions are automatically called if io.IniFilename != NULL (default is "imgui.ini").</para>
		/// <para>- Set io.IniFilename to NULL to load/save manually. Read io.WantSaveIniSettings description about handling .ini saving manually.</para>
		/// <para>- Important: default value "imgui.ini" is relative to current working dir! Most apps will want to lock this to an absolute path (e.g. same path as executables).</para>
		/// </summary>
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame(). NewFrame() automatically calls LoadIniSettingsFromDisk(io.IniFilename).
		/// </summary>
		public static void LoadIniSettingsFromDisk(ReadOnlySpan<char> ini_filename)
		{
			// Marshaling 'ini_filename' to native string
			byte* native_ini_filename;
			var ini_filename_byteCount = 0;
			if (ini_filename != null)
			{
				ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
				if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
				{
					native_ini_filename = Util.Allocate(ini_filename_byteCount + 1);
				}
				else
				{
					var native_ini_filename_stackBytes = stackalloc byte[ini_filename_byteCount + 1];
					native_ini_filename = native_ini_filename_stackBytes;
				}
				var ini_filename_offset = Util.GetUtf8(ini_filename, native_ini_filename, ini_filename_byteCount);
				native_ini_filename[ini_filename_offset] = 0;
			}
			else native_ini_filename = null;

			ImGuiNative.ImGui_LoadIniSettingsFromDisk(native_ini_filename);
			if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_ini_filename);
			}
		}

		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> ini_data)
		{
			// Marshaling 'ini_data' to native string
			byte* native_ini_data;
			var ini_data_byteCount = 0;
			if (ini_data != null)
			{
				ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
				if (ini_data_byteCount > Util.StackAllocationSizeLimit)
				{
					native_ini_data = Util.Allocate(ini_data_byteCount + 1);
				}
				else
				{
					var native_ini_data_stackBytes = stackalloc byte[ini_data_byteCount + 1];
					native_ini_data = native_ini_data_stackBytes;
				}
				var ini_data_offset = Util.GetUtf8(ini_data, native_ini_data, ini_data_byteCount);
				native_ini_data[ini_data_offset] = 0;
			}
			else native_ini_data = null;

			uint ini_size = 0;

			ImGuiNative.ImGui_LoadIniSettingsFromMemory(native_ini_data, ini_size);
			if (ini_data_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_ini_data);
			}
		}
		/// <summary>
		/// call after CreateContext() and before the first call to NewFrame() to provide .ini data from your own data source.
		/// </summary>
		public static void LoadIniSettingsFromMemory(ReadOnlySpan<char> ini_data, uint ini_size)
		{
			// Marshaling 'ini_data' to native string
			byte* native_ini_data;
			var ini_data_byteCount = 0;
			if (ini_data != null)
			{
				ini_data_byteCount = Encoding.UTF8.GetByteCount(ini_data);
				if (ini_data_byteCount > Util.StackAllocationSizeLimit)
				{
					native_ini_data = Util.Allocate(ini_data_byteCount + 1);
				}
				else
				{
					var native_ini_data_stackBytes = stackalloc byte[ini_data_byteCount + 1];
					native_ini_data = native_ini_data_stackBytes;
				}
				var ini_data_offset = Util.GetUtf8(ini_data, native_ini_data, ini_data_byteCount);
				native_ini_data[ini_data_offset] = 0;
			}
			else native_ini_data = null;

			ImGuiNative.ImGui_LoadIniSettingsFromMemory(native_ini_data, ini_size);
			if (ini_data_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_ini_data);
			}
		}

		/// <summary>
		/// this is automatically called (if io.IniFilename is not empty) a few seconds after any modification that should be reflected in the .ini file (and also by DestroyContext).
		/// </summary>
		public static void SaveIniSettingsToDisk(ReadOnlySpan<char> ini_filename)
		{
			// Marshaling 'ini_filename' to native string
			byte* native_ini_filename;
			var ini_filename_byteCount = 0;
			if (ini_filename != null)
			{
				ini_filename_byteCount = Encoding.UTF8.GetByteCount(ini_filename);
				if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
				{
					native_ini_filename = Util.Allocate(ini_filename_byteCount + 1);
				}
				else
				{
					var native_ini_filename_stackBytes = stackalloc byte[ini_filename_byteCount + 1];
					native_ini_filename = native_ini_filename_stackBytes;
				}
				var ini_filename_offset = Util.GetUtf8(ini_filename, native_ini_filename, ini_filename_byteCount);
				native_ini_filename[ini_filename_offset] = 0;
			}
			else native_ini_filename = null;

			ImGuiNative.ImGui_SaveIniSettingsToDisk(native_ini_filename);
			if (ini_filename_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_ini_filename);
			}
		}

		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.
		/// </summary>
		public static string SaveIniSettingsToMemory()
		{
			uint* out_ini_size = null;

			var ret = ImGuiNative.ImGui_SaveIniSettingsToMemory(out_ini_size);
			return Util.StringFromPtr(ret);
		}
		/// <summary>
		/// return a zero-terminated string with the .ini data which you can save by your own mean. call when io.WantSaveIniSettings is set, then save data by your own mean and clear io.WantSaveIniSettings.
		/// </summary>
		public static string SaveIniSettingsToMemory(out uint out_ini_size)
		{
			fixed (uint* native_out_ini_size = &out_ini_size)
			{
				var ret = ImGuiNative.ImGui_SaveIniSettingsToMemory(native_out_ini_size);
				return Util.StringFromPtr(ret);
			}
		}

		/// <summary>
		/// <para>Debug Utilities</para>
		/// <para>- Your main debugging friend is the ShowMetricsWindow() function, which is also accessible from Demo-&gt;Tools-&gt;Metrics Debugger</para>
		/// </summary>
		public static void DebugTextEncoding(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_DebugTextEncoding(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		public static void DebugFlashStyleColor(ImGuiCol idx)
		{
			ImGuiNative.ImGui_DebugFlashStyleColor(idx);
		}

		public static void DebugStartItemPicker()
		{
			ImGuiNative.ImGui_DebugStartItemPicker();
		}

		/// <summary>
		/// This is called by IMGUI_CHECKVERSION() macro.
		/// </summary>
		public static bool DebugCheckVersionAndDataLayout(ReadOnlySpan<char> version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx)
		{
			// Marshaling 'version_str' to native string
			byte* native_version_str;
			var version_str_byteCount = 0;
			if (version_str != null)
			{
				version_str_byteCount = Encoding.UTF8.GetByteCount(version_str);
				if (version_str_byteCount > Util.StackAllocationSizeLimit)
				{
					native_version_str = Util.Allocate(version_str_byteCount + 1);
				}
				else
				{
					var native_version_str_stackBytes = stackalloc byte[version_str_byteCount + 1];
					native_version_str = native_version_str_stackBytes;
				}
				var version_str_offset = Util.GetUtf8(version_str, native_version_str, version_str_byteCount);
				native_version_str[version_str_offset] = 0;
			}
			else native_version_str = null;

			var ret = ImGuiNative.ImGui_DebugCheckVersionAndDataLayout(native_version_str, sz_io, sz_style, sz_vec2, sz_vec4, sz_drawvert, sz_drawidx);
			if (version_str_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_version_str);
			}
			return ret != 0;
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!
		/// </summary>
		public static void DebugLog(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGui_DebugLog(native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}

		/// <summary>
		/// Call via IMGUI_DEBUG_LOG() for maximum stripping in caller code!
		/// </summary>
		public static void DebugLogUnformatted(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiNative.ImGui_DebugLogUnformatted(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// <para>Memory Allocators</para>
		/// <para>- Those functions are not reliant on the current context.</para>
		/// <para>- DLL users: heaps and globals are not shared across DLL boundaries! You will need to call SetCurrentContext() + SetAllocatorFunctions()</para>
		/// <para>  for each static/DLL boundary you are calling from. Read "Context and Memory Allocators" section of imgui.cpp for more details.</para>
		/// </summary>
		public static void SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func)
		{
			void* user_data = null;

			ImGuiNative.ImGui_SetAllocatorFunctions(alloc_func, free_func, user_data);
		}
		/// <summary>
		/// <para>Memory Allocators</para>
		/// <para>- Those functions are not reliant on the current context.</para>
		/// <para>- DLL users: heaps and globals are not shared across DLL boundaries! You will need to call SetCurrentContext() + SetAllocatorFunctions()</para>
		/// <para>  for each static/DLL boundary you are calling from. Read "Context and Memory Allocators" section of imgui.cpp for more details.</para>
		/// </summary>
		public static void SetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, IntPtr user_data)
		{
			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			ImGuiNative.ImGui_SetAllocatorFunctions(alloc_func, free_func, native_user_data);
		}

		public static void GetAllocatorFunctions(IntPtr p_alloc_func, IntPtr p_free_func, ref void* p_user_data)
		{
			fixed (void** native_p_user_data = &p_user_data)
			{
				ImGuiNative.ImGui_GetAllocatorFunctions(p_alloc_func, p_free_func, native_p_user_data);
			}
		}

		public static void* MemAlloc(uint size)
		{
			var ret = ImGuiNative.ImGui_MemAlloc(size);
			return ret;
		}

		public static void MemFree(IntPtr ptr)
		{
			// Marshaling 'ptr' to native void pointer
			var native_ptr = ptr.ToPointer();

			ImGuiNative.ImGui_MemFree(native_ptr);
		}

		/// <summary>
		/// <para>(Optional) Platform/OS interface for multi-viewport support</para>
		/// <para>Read comments around the ImGuiPlatformIO structure for more details.</para>
		/// <para>Note: You may use GetWindowViewport() to get the current viewport of the current window.</para>
		/// </summary>
		/// <summary>
		/// call in main loop. will call CreateWindow/ResizeWindow/etc. platform functions for each secondary viewport, and DestroyWindow for each inactive viewport.
		/// </summary>
		public static void UpdatePlatformWindows()
		{
			ImGuiNative.ImGui_UpdatePlatformWindows();
		}

		/// <summary>
		/// Implied platform_render_arg = NULL, renderer_render_arg = NULL
		/// </summary>
		public static void RenderPlatformWindowsDefault()
		{
			ImGuiNative.ImGui_RenderPlatformWindowsDefault();
		}

		/// <summary>
		/// Implied platform_render_arg = NULL, renderer_render_arg = NULL
		/// </summary>
		public static void RenderPlatformWindowsDefault(IntPtr platform_render_arg)
		{
			// Marshaling 'platform_render_arg' to native void pointer
			var native_platform_render_arg = platform_render_arg.ToPointer();

			void* renderer_render_arg = null;

			ImGuiNative.ImGui_RenderPlatformWindowsDefaultEx(native_platform_render_arg, renderer_render_arg);
		}
		/// <summary>
		/// Implied platform_render_arg = NULL, renderer_render_arg = NULL
		/// </summary>
		public static void RenderPlatformWindowsDefault(IntPtr platform_render_arg, IntPtr renderer_render_arg)
		{
			// Marshaling 'platform_render_arg' to native void pointer
			var native_platform_render_arg = platform_render_arg.ToPointer();

			// Marshaling 'renderer_render_arg' to native void pointer
			var native_renderer_render_arg = renderer_render_arg.ToPointer();

			ImGuiNative.ImGui_RenderPlatformWindowsDefaultEx(native_platform_render_arg, native_renderer_render_arg);
		}

		/// <summary>
		/// call DestroyWindow platform functions for all viewports. call from backend Shutdown() if you need to close platform windows before imgui shutdown. otherwise will be called by DestroyContext().
		/// </summary>
		public static void DestroyPlatformWindows()
		{
			ImGuiNative.ImGui_DestroyPlatformWindows();
		}

		/// <summary>
		/// this is a helper for backends.
		/// </summary>
		public static ImGuiViewportPtr FindViewportByID(uint id)
		{
			var ret = ImGuiNative.ImGui_FindViewportByID(id);
			return ret;
		}

		/// <summary>
		/// this is a helper for backends. the type platform_handle is decided by the backend (e.g. HWND, MyWindow*, GLFWwindow* etc.)
		/// </summary>
		public static ImGuiViewportPtr FindViewportByPlatformHandle(IntPtr platform_handle)
		{
			// Marshaling 'platform_handle' to native void pointer
			var native_platform_handle = platform_handle.ToPointer();

			var ret = ImGuiNative.ImGui_FindViewportByPlatformHandle(native_platform_handle);
			return ret;
		}
	}
}
