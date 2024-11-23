using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Access via ImGui::GetPlatformIO()</para>
	/// </summary>
	public unsafe partial struct ImGuiPlatformIO
	{
		/// <summary>
		/// <para>Optional: Access OS clipboard</para>
		/// <para>(default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)</para>
		/// </summary>
		public IntPtr Platform_GetClipboardTextFn;
		public IntPtr Platform_SetClipboardTextFn;
		public void* Platform_ClipboardUserData;
		/// <summary>
		/// <para>Optional: Open link/folder/file in OS Shell</para>
		/// <para>(default to use ShellExecuteA() on Windows, system() on Linux/Mac)</para>
		/// </summary>
		public IntPtr Platform_OpenInShellFn;
		public void* Platform_OpenInShellUserData;
		/// <summary>
		/// <para>Optional: Notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME on Windows)</para>
		/// <para>(default to use native imm32 api on Windows)</para>
		/// </summary>
		public IntPtr Platform_SetImeDataFn;
		public void* Platform_ImeUserData;
		/// <summary>
		/// <para>Optional: Platform locale</para>
		/// <para>[Experimental] Configure decimal point e.g. '.' or ',' useful for some languages (e.g. German), generally pulled from *localeconv()-&gt;decimal_point</para>
		/// </summary>
		/// <summary>
		/// '.'
		/// </summary>
		public ushort Platform_LocaleDecimalPoint;
		/// <summary>
		/// <para>Written by some backends during ImGui_ImplXXXX_RenderDrawData() call to point backend_specific ImGui_ImplXXXX_RenderState* structure.</para>
		/// </summary>
		public void* Renderer_RenderState;
		/// <summary>
		/// <para>Platform Backend functions (e.g. Win32, GLFW, SDL) ------------------- Called by -----</para>
		/// </summary>
		/// <summary>
		/// . . U . .  // Create a new platform window for the given viewport
		/// </summary>
		public IntPtr Platform_CreateWindow;
		/// <summary>
		/// N . U . D  //
		/// </summary>
		public IntPtr Platform_DestroyWindow;
		/// <summary>
		/// . . U . .  // Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them before showing the window
		/// </summary>
		public IntPtr Platform_ShowWindow;
		/// <summary>
		/// . . U . .  // Set platform window position (given the upper-left corner of client area)
		/// </summary>
		public IntPtr Platform_SetWindowPos;
		/// <summary>
		/// N . . . .  //
		/// </summary>
		public IntPtr Platform_GetWindowPos;
		/// <summary>
		/// . . U . .  // Set platform window client area size (ignoring OS decorations such as OS title bar etc.)
		/// </summary>
		public IntPtr Platform_SetWindowSize;
		/// <summary>
		/// N . . . .  // Get platform window client area size
		/// </summary>
		public IntPtr Platform_GetWindowSize;
		/// <summary>
		/// N . . . .  // Move window to front and set input focus
		/// </summary>
		public IntPtr Platform_SetWindowFocus;
		/// <summary>
		/// . . U . .  //
		/// </summary>
		public IntPtr Platform_GetWindowFocus;
		/// <summary>
		/// N . . . .  // Get platform window minimized state. When minimized, we generally won't attempt to get/set size and contents will be culled more easily
		/// </summary>
		public IntPtr Platform_GetWindowMinimized;
		/// <summary>
		/// . . U . .  // Set platform window title (given an UTF-8 string)
		/// </summary>
		public IntPtr Platform_SetWindowTitle;
		/// <summary>
		/// . . U . .  // (Optional) Setup global transparency (not per-pixel transparency)
		/// </summary>
		public IntPtr Platform_SetWindowAlpha;
		/// <summary>
		/// . . U . .  // (Optional) Called by UpdatePlatformWindows(). Optional hook to allow the platform backend from doing general book-keeping every frame.
		/// </summary>
		public IntPtr Platform_UpdateWindow;
		/// <summary>
		/// . . . R .  // (Optional) Main rendering (platform side! This is often unused, or just setting a "current" context for OpenGL bindings). 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public IntPtr Platform_RenderWindow;
		/// <summary>
		/// . . . R .  // (Optional) Call Present/SwapBuffers (platform side! This is often unused!). 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public IntPtr Platform_SwapBuffers;
		/// <summary>
		/// N . . . .  // (Optional) [BETA] FIXME-DPI: DPI handling: Return DPI scale for this viewport. 1.0f = 96 DPI.
		/// </summary>
		public IntPtr Platform_GetWindowDpiScale;
		/// <summary>
		/// . F . . .  // (Optional) [BETA] FIXME-DPI: DPI handling: Called during Begin() every time the viewport we are outputting into changes, so backend has a chance to swap fonts to adjust style.
		/// </summary>
		public IntPtr Platform_OnChangedViewport;
		/// <summary>
		/// N . . . .  // (Optional) [BETA] Get initial work area inset for the viewport (won't be covered by main menu bar, dockspace over viewport etc.). Default to (0,0),(0,0). 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.
		/// </summary>
		public IntPtr Platform_GetWindowWorkAreaInsets;
		/// <summary>
		/// (Optional) For a Vulkan Renderer to call into Platform code (since the surface creation needs to tie them both).
		/// </summary>
		public IntPtr Platform_CreateVkSurface;
		/// <summary>
		/// <para>Renderer Backend functions (e.g. DirectX, OpenGL, Vulkan) ------------ Called by -----</para>
		/// </summary>
		/// <summary>
		/// . . U . .  // Create swap chain, frame buffers etc. (called after Platform_CreateWindow)
		/// </summary>
		public IntPtr Renderer_CreateWindow;
		/// <summary>
		/// N . U . D  // Destroy swap chain, frame buffers etc. (called before Platform_DestroyWindow)
		/// </summary>
		public IntPtr Renderer_DestroyWindow;
		/// <summary>
		/// . . U . .  // Resize swap chain, frame buffers etc. (called after Platform_SetWindowSize)
		/// </summary>
		public IntPtr Renderer_SetWindowSize;
		/// <summary>
		/// . . . R .  // (Optional) Clear framebuffer, setup render target, then render the viewport-&gt;DrawData. 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public IntPtr Renderer_RenderWindow;
		/// <summary>
		/// . . . R .  // (Optional) Call Present/SwapBuffers. 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public IntPtr Renderer_SwapBuffers;
		/// <summary>
		/// <para>(Optional) Monitor list</para>
		/// <para>- Updated by: app/backend. Update every frame to dynamically support changing monitor or DPI configuration.</para>
		/// <para>- Used by: dear imgui to query DPI info, clamp popups/tooltips within same monitor and not have them straddle monitors.</para>
		/// </summary>
		public ImVector Monitors;
		/// <summary>
		/// <para>Viewports list (the list is updated by calling ImGui::EndFrame or ImGui::Render)</para>
		/// <para>(in the future we will attempt to organize this feature to remove the need for a "main viewport")</para>
		/// </summary>
		/// <summary>
		/// Main viewports, followed by all secondary viewports.
		/// </summary>
		public ImVector Viewports;
	}

	/// <summary>
	/// <para>Access via ImGui::GetPlatformIO()</para>
	/// </summary>
	public unsafe partial struct ImGuiPlatformIOPtr
	{
		public ImGuiPlatformIO* NativePtr { get; }
		public ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformIO*)nativePtr;
		public static implicit operator ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => new ImGuiPlatformIOPtr(nativePtr);
		public static implicit operator ImGuiPlatformIO* (ImGuiPlatformIOPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiPlatformIOPtr(IntPtr nativePtr) => new ImGuiPlatformIOPtr(nativePtr);

		/// <summary>
		/// <para>Optional: Access OS clipboard</para>
		/// <para>(default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)</para>
		/// </summary>
		public Platform_GetClipboardTextFnDelegate Platform_GetClipboardTextFn
		{
			get => (Platform_GetClipboardTextFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetClipboardTextFn, typeof(Platform_GetClipboardTextFnDelegate));
			set => NativePtr->Platform_GetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		public Platform_SetClipboardTextFnDelegate Platform_SetClipboardTextFn
		{
			get => (Platform_SetClipboardTextFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetClipboardTextFn, typeof(Platform_SetClipboardTextFnDelegate));
			set => NativePtr->Platform_SetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		public IntPtr Platform_ClipboardUserData { get => (IntPtr)NativePtr->Platform_ClipboardUserData; set => NativePtr->Platform_ClipboardUserData = (void*)value; }

		/// <summary>
		/// <para>Optional: Open link/folder/file in OS Shell</para>
		/// <para>(default to use ShellExecuteA() on Windows, system() on Linux/Mac)</para>
		/// </summary>
		public Platform_OpenInShellFnDelegate Platform_OpenInShellFn
		{
			get => (Platform_OpenInShellFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_OpenInShellFn, typeof(Platform_OpenInShellFnDelegate));
			set => NativePtr->Platform_OpenInShellFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		public IntPtr Platform_OpenInShellUserData { get => (IntPtr)NativePtr->Platform_OpenInShellUserData; set => NativePtr->Platform_OpenInShellUserData = (void*)value; }

		/// <summary>
		/// <para>Optional: Notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME on Windows)</para>
		/// <para>(default to use native imm32 api on Windows)</para>
		/// </summary>
		public Platform_SetImeDataFnDelegate Platform_SetImeDataFn
		{
			get => (Platform_SetImeDataFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetImeDataFn, typeof(Platform_SetImeDataFnDelegate));
			set => NativePtr->Platform_SetImeDataFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		public IntPtr Platform_ImeUserData { get => (IntPtr)NativePtr->Platform_ImeUserData; set => NativePtr->Platform_ImeUserData = (void*)value; }

		/// <summary>
		/// <para>Optional: Platform locale</para>
		/// <para>[Experimental] Configure decimal point e.g. '.' or ',' useful for some languages (e.g. German), generally pulled from *localeconv()-&gt;decimal_point</para>
		/// </summary>
		/// <summary>
		/// '.'
		/// </summary>
		public ref ushort Platform_LocaleDecimalPoint => ref Unsafe.AsRef<ushort>(&NativePtr->Platform_LocaleDecimalPoint);

		/// <summary>
		/// <para>Written by some backends during ImGui_ImplXXXX_RenderDrawData() call to point backend_specific ImGui_ImplXXXX_RenderState* structure.</para>
		/// </summary>
		public IntPtr Renderer_RenderState { get => (IntPtr)NativePtr->Renderer_RenderState; set => NativePtr->Renderer_RenderState = (void*)value; }

		/// <summary>
		/// <para>Platform Backend functions (e.g. Win32, GLFW, SDL) ------------------- Called by -----</para>
		/// </summary>
		/// <summary>
		/// . . U . .  // Create a new platform window for the given viewport
		/// </summary>
		public Platform_CreateWindowDelegate Platform_CreateWindow
		{
			get => (Platform_CreateWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_CreateWindow, typeof(Platform_CreateWindowDelegate));
			set => NativePtr->Platform_CreateWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . U . D  //
		/// </summary>
		public Platform_DestroyWindowDelegate Platform_DestroyWindow
		{
			get => (Platform_DestroyWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_DestroyWindow, typeof(Platform_DestroyWindowDelegate));
			set => NativePtr->Platform_DestroyWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them before showing the window
		/// </summary>
		public Platform_ShowWindowDelegate Platform_ShowWindow
		{
			get => (Platform_ShowWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_ShowWindow, typeof(Platform_ShowWindowDelegate));
			set => NativePtr->Platform_ShowWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // Set platform window position (given the upper-left corner of client area)
		/// </summary>
		public Platform_SetWindowPosDelegate Platform_SetWindowPos
		{
			get => (Platform_SetWindowPosDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetWindowPos, typeof(Platform_SetWindowPosDelegate));
			set => NativePtr->Platform_SetWindowPos = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . . . .  //
		/// </summary>
		public Platform_GetWindowPosDelegate Platform_GetWindowPos
		{
			get => (Platform_GetWindowPosDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetWindowPos, typeof(Platform_GetWindowPosDelegate));
			set => NativePtr->Platform_GetWindowPos = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // Set platform window client area size (ignoring OS decorations such as OS title bar etc.)
		/// </summary>
		public Platform_SetWindowSizeDelegate Platform_SetWindowSize
		{
			get => (Platform_SetWindowSizeDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetWindowSize, typeof(Platform_SetWindowSizeDelegate));
			set => NativePtr->Platform_SetWindowSize = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . . . .  // Get platform window client area size
		/// </summary>
		public Platform_GetWindowSizeDelegate Platform_GetWindowSize
		{
			get => (Platform_GetWindowSizeDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetWindowSize, typeof(Platform_GetWindowSizeDelegate));
			set => NativePtr->Platform_GetWindowSize = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . . . .  // Move window to front and set input focus
		/// </summary>
		public Platform_SetWindowFocusDelegate Platform_SetWindowFocus
		{
			get => (Platform_SetWindowFocusDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetWindowFocus, typeof(Platform_SetWindowFocusDelegate));
			set => NativePtr->Platform_SetWindowFocus = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  //
		/// </summary>
		public Platform_GetWindowFocusDelegate Platform_GetWindowFocus
		{
			get => (Platform_GetWindowFocusDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetWindowFocus, typeof(Platform_GetWindowFocusDelegate));
			set => NativePtr->Platform_GetWindowFocus = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . . . .  // Get platform window minimized state. When minimized, we generally won't attempt to get/set size and contents will be culled more easily
		/// </summary>
		public Platform_GetWindowMinimizedDelegate Platform_GetWindowMinimized
		{
			get => (Platform_GetWindowMinimizedDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetWindowMinimized, typeof(Platform_GetWindowMinimizedDelegate));
			set => NativePtr->Platform_GetWindowMinimized = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // Set platform window title (given an UTF-8 string)
		/// </summary>
		public Platform_SetWindowTitleDelegate Platform_SetWindowTitle
		{
			get => (Platform_SetWindowTitleDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetWindowTitle, typeof(Platform_SetWindowTitleDelegate));
			set => NativePtr->Platform_SetWindowTitle = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // (Optional) Setup global transparency (not per-pixel transparency)
		/// </summary>
		public Platform_SetWindowAlphaDelegate Platform_SetWindowAlpha
		{
			get => (Platform_SetWindowAlphaDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SetWindowAlpha, typeof(Platform_SetWindowAlphaDelegate));
			set => NativePtr->Platform_SetWindowAlpha = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // (Optional) Called by UpdatePlatformWindows(). Optional hook to allow the platform backend from doing general book-keeping every frame.
		/// </summary>
		public Platform_UpdateWindowDelegate Platform_UpdateWindow
		{
			get => (Platform_UpdateWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_UpdateWindow, typeof(Platform_UpdateWindowDelegate));
			set => NativePtr->Platform_UpdateWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . . R .  // (Optional) Main rendering (platform side! This is often unused, or just setting a "current" context for OpenGL bindings). 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public Platform_RenderWindowDelegate Platform_RenderWindow
		{
			get => (Platform_RenderWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_RenderWindow, typeof(Platform_RenderWindowDelegate));
			set => NativePtr->Platform_RenderWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . . R .  // (Optional) Call Present/SwapBuffers (platform side! This is often unused!). 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public Platform_SwapBuffersDelegate Platform_SwapBuffers
		{
			get => (Platform_SwapBuffersDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_SwapBuffers, typeof(Platform_SwapBuffersDelegate));
			set => NativePtr->Platform_SwapBuffers = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . . . .  // (Optional) [BETA] FIXME-DPI: DPI handling: Return DPI scale for this viewport. 1.0f = 96 DPI.
		/// </summary>
		public Platform_GetWindowDpiScaleDelegate Platform_GetWindowDpiScale
		{
			get => (Platform_GetWindowDpiScaleDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetWindowDpiScale, typeof(Platform_GetWindowDpiScaleDelegate));
			set => NativePtr->Platform_GetWindowDpiScale = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . F . . .  // (Optional) [BETA] FIXME-DPI: DPI handling: Called during Begin() every time the viewport we are outputting into changes, so backend has a chance to swap fonts to adjust style.
		/// </summary>
		public Platform_OnChangedViewportDelegate Platform_OnChangedViewport
		{
			get => (Platform_OnChangedViewportDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_OnChangedViewport, typeof(Platform_OnChangedViewportDelegate));
			set => NativePtr->Platform_OnChangedViewport = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . . . .  // (Optional) [BETA] Get initial work area inset for the viewport (won't be covered by main menu bar, dockspace over viewport etc.). Default to (0,0),(0,0). 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.
		/// </summary>
		public Platform_GetWindowWorkAreaInsetsDelegate Platform_GetWindowWorkAreaInsets
		{
			get => (Platform_GetWindowWorkAreaInsetsDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_GetWindowWorkAreaInsets, typeof(Platform_GetWindowWorkAreaInsetsDelegate));
			set => NativePtr->Platform_GetWindowWorkAreaInsets = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// (Optional) For a Vulkan Renderer to call into Platform code (since the surface creation needs to tie them both).
		/// </summary>
		public Platform_CreateVkSurfaceDelegate Platform_CreateVkSurface
		{
			get => (Platform_CreateVkSurfaceDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Platform_CreateVkSurface, typeof(Platform_CreateVkSurfaceDelegate));
			set => NativePtr->Platform_CreateVkSurface = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// <para>Renderer Backend functions (e.g. DirectX, OpenGL, Vulkan) ------------ Called by -----</para>
		/// </summary>
		/// <summary>
		/// . . U . .  // Create swap chain, frame buffers etc. (called after Platform_CreateWindow)
		/// </summary>
		public Renderer_CreateWindowDelegate Renderer_CreateWindow
		{
			get => (Renderer_CreateWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Renderer_CreateWindow, typeof(Renderer_CreateWindowDelegate));
			set => NativePtr->Renderer_CreateWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// N . U . D  // Destroy swap chain, frame buffers etc. (called before Platform_DestroyWindow)
		/// </summary>
		public Renderer_DestroyWindowDelegate Renderer_DestroyWindow
		{
			get => (Renderer_DestroyWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Renderer_DestroyWindow, typeof(Renderer_DestroyWindowDelegate));
			set => NativePtr->Renderer_DestroyWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . U . .  // Resize swap chain, frame buffers etc. (called after Platform_SetWindowSize)
		/// </summary>
		public Renderer_SetWindowSizeDelegate Renderer_SetWindowSize
		{
			get => (Renderer_SetWindowSizeDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Renderer_SetWindowSize, typeof(Renderer_SetWindowSizeDelegate));
			set => NativePtr->Renderer_SetWindowSize = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . . R .  // (Optional) Clear framebuffer, setup render target, then render the viewport-&gt;DrawData. 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public Renderer_RenderWindowDelegate Renderer_RenderWindow
		{
			get => (Renderer_RenderWindowDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Renderer_RenderWindow, typeof(Renderer_RenderWindowDelegate));
			set => NativePtr->Renderer_RenderWindow = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// . . . R .  // (Optional) Call Present/SwapBuffers. 'render_arg' is the value passed to RenderPlatformWindowsDefault().
		/// </summary>
		public Renderer_SwapBuffersDelegate Renderer_SwapBuffers
		{
			get => (Renderer_SwapBuffersDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->Renderer_SwapBuffers, typeof(Renderer_SwapBuffersDelegate));
			set => NativePtr->Renderer_SwapBuffers = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// <para>(Optional) Monitor list</para>
		/// <para>- Updated by: app/backend. Update every frame to dynamically support changing monitor or DPI configuration.</para>
		/// <para>- Used by: dear imgui to query DPI info, clamp popups/tooltips within same monitor and not have them straddle monitors.</para>
		/// </summary>
		public ImPtrVector<ImGuiPlatformMonitorPtr> Monitors => new ImPtrVector<ImGuiPlatformMonitorPtr>(NativePtr->Monitors, Unsafe.SizeOf<ImGuiPlatformMonitor>());

		/// <summary>
		/// <para>Viewports list (the list is updated by calling ImGui::EndFrame or ImGui::Render)</para>
		/// <para>(in the future we will attempt to organize this feature to remove the need for a "main viewport")</para>
		/// </summary>
		/// <summary>
		/// Main viewports, followed by all secondary viewports.
		/// </summary>
		public ImVector<ImGuiViewportPtr> Viewports => new ImVector<ImGuiViewportPtr>(NativePtr->Viewports);
	}
}
