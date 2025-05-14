using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Access via ImGui::GetPlatformIO()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformIO
	{
		/// <summary>
		///     Optional: Access OS clipboard<br/>    (default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)<br/>
		/// </summary>
		public unsafe void* PlatformGetClipboardTextFn;
		public unsafe void* PlatformSetClipboardTextFn;
		public unsafe void* PlatformClipboardUserData;
		/// <summary>
		///     Optional: Open link/folder/file in OS Shell<br/>    (default to use ShellExecuteW() on Windows, system() on Linux/Mac)<br/>
		/// </summary>
		public unsafe void* PlatformOpenInShellFn;
		public unsafe void* PlatformOpenInShellUserData;
		/// <summary>
		///     Optional: Notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME on Windows)<br/>    (default to use native imm32 api on Windows)<br/>
		/// </summary>
		public unsafe void* PlatformSetImeDataFn;
		public unsafe void* PlatformImeUserData;
		/// <summary>
		///     Optional: Platform locale<br/>    [Experimental] Configure decimal point e.g. '.' or ',' useful for some languages (e.g. German), generally pulled from *localeconv()-&gt;decimal_point<br/>
		/// '.'<br/>
		/// </summary>
		public ushort PlatformLocaleDecimalPoint;
		/// <summary>
		///     Written by some backends during ImGui_ImplXXXX_RenderDrawData() call to point backend_specific ImGui_ImplXXXX_RenderState* structure.<br/>
		/// </summary>
		public unsafe void* RendererRenderState;
		/// <summary>
		///     Platform Backend functions (e.g. Win32, GLFW, SDL) ------------------- Called by -----<br/>
		/// . . U . .  Create a new platform window for the given viewport<br/>
		/// </summary>
		public unsafe void* PlatformCreateWindow;
		/// <summary>
		/// N . U . D  //<br/>
		/// </summary>
		public unsafe void* PlatformDestroyWindow;
		/// <summary>
		/// . . U . .  Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them before showing the window<br/>
		/// </summary>
		public unsafe void* PlatformShowWindow;
		/// <summary>
		/// . . U . .  Set platform window position (given the upper-left corner of client area)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowPos;
		/// <summary>
		/// N . . . .  //<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowPos;
		/// <summary>
		/// . . U . .  Set platform window client area size (ignoring OS decorations such as OS title bar etc.)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowSize;
		/// <summary>
		/// N . . . .  Get platform window client area size<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowSize;
		/// <summary>
		/// N . . . .  Move window to front and set input focus<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowFocus;
		/// <summary>
		/// . . U . .  //<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowFocus;
		/// <summary>
		/// N . . . .  Get platform window minimized state. When minimized, we generally won't attempt to get/set size and contents will be culled more easily<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowMinimized;
		/// <summary>
		/// . . U . .  Set platform window title (given an UTF-8 string)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowTitle;
		/// <summary>
		/// . . U . .  (Optional) Setup global transparency (not per-pixel transparency)<br/>
		/// </summary>
		public unsafe void* PlatformSetWindowAlpha;
		/// <summary>
		/// . . U . .  (Optional) Called by UpdatePlatformWindows(). Optional hook to allow the platform backend from doing general book-keeping every frame.<br/>
		/// </summary>
		public unsafe void* PlatformUpdateWindow;
		/// <summary>
		/// . . . R .  (Optional) Main rendering (platform side! This is often unused, or just setting a "current" context for OpenGL bindings). 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* PlatformRenderWindow;
		/// <summary>
		/// . . . R .  (Optional) Call Present/SwapBuffers (platform side! This is often unused!). 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* PlatformSwapBuffers;
		/// <summary>
		/// N . . . .  (Optional) [BETA] FIXME-DPI: DPI handling: Return DPI scale for this viewport. 1.0f = 96 DPI.<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowDpiScale;
		/// <summary>
		/// . F . . .  (Optional) [BETA] FIXME-DPI: DPI handling: Called during Begin() every time the viewport we are outputting into changes, so backend has a chance to swap fonts to adjust style.<br/>
		/// </summary>
		public unsafe void* PlatformOnChangedViewport;
		/// <summary>
		/// N . . . .  (Optional) [BETA] Get initial work area inset for the viewport (won't be covered by main menu bar, dockspace over viewport etc.). Default to (0,0),(0,0). 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.<br/>
		/// </summary>
		public unsafe void* PlatformGetWindowWorkAreaInsets;
		/// <summary>
		/// (Optional) For a Vulkan Renderer to call into Platform code (since the surface creation needs to tie them both).<br/>
		/// </summary>
		public unsafe void* PlatformCreateVkSurface;
		/// <summary>
		///     Renderer Backend functions (e.g. DirectX, OpenGL, Vulkan) ------------ Called by -----<br/>
		/// . . U . .  Create swap chain, frame buffers etc. (called after Platform_CreateWindow)<br/>
		/// </summary>
		public unsafe void* RendererCreateWindow;
		/// <summary>
		/// N . U . D  Destroy swap chain, frame buffers etc. (called before Platform_DestroyWindow)<br/>
		/// </summary>
		public unsafe void* RendererDestroyWindow;
		/// <summary>
		/// . . U . .  Resize swap chain, frame buffers etc. (called after Platform_SetWindowSize)<br/>
		/// </summary>
		public unsafe void* RendererSetWindowSize;
		/// <summary>
		/// . . . R .  (Optional) Clear framebuffer, setup render target, then render the viewport-&gt;DrawData. 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* RendererRenderWindow;
		/// <summary>
		/// . . . R .  (Optional) Call Present/SwapBuffers. 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public unsafe void* RendererSwapBuffers;
		/// <summary>
		///     (Optional) Monitor list<br/>    - Updated by: app/backend. Update every frame to dynamically support changing monitor or DPI configuration.<br/>    - Used by: dear imgui to query DPI info, clamp popups/tooltips within same monitor and not have them straddle monitors.<br/>
		/// </summary>
		public ImVector<ImGuiPlatformMonitor> Monitors;
		/// <summary>
		///     Viewports list (the list is updated by calling ImGui::EndFrame or ImGui::Render)<br/>    (in the future we will attempt to organize this feature to remove the need for a "main viewport")<br/>
		/// Main viewports, followed by all secondary viewports.<br/>
		/// </summary>
		public ImVector<ImGuiViewportPtr> Viewports;
	}

	/// <summary>
	/// Access via ImGui::GetPlatformIO()<br/>
	/// </summary>
	public unsafe partial struct ImGuiPlatformIOPtr
	{
		public ImGuiPlatformIO* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPlatformIO this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		///     Optional: Access OS clipboard<br/>    (default to use native Win32 clipboard on Windows, otherwise uses a private clipboard. Override to access OS clipboard on other architectures)<br/>
		/// </summary>
		public PlatformGetClipboardTextFn PlatformGetClipboardTextFn { get => (PlatformGetClipboardTextFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetClipboardTextFn, typeof(PlatformGetClipboardTextFn)); set => NativePtr->PlatformGetClipboardTextFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		public PlatformSetClipboardTextFn PlatformSetClipboardTextFn { get => (PlatformSetClipboardTextFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetClipboardTextFn, typeof(PlatformSetClipboardTextFn)); set => NativePtr->PlatformSetClipboardTextFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		public IntPtr PlatformClipboardUserData { get => (IntPtr)NativePtr->PlatformClipboardUserData; set => NativePtr->PlatformClipboardUserData = (void*)value; }
		/// <summary>
		///     Optional: Open link/folder/file in OS Shell<br/>    (default to use ShellExecuteW() on Windows, system() on Linux/Mac)<br/>
		/// </summary>
		public PlatformOpenInShellFn PlatformOpenInShellFn { get => (PlatformOpenInShellFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformOpenInShellFn, typeof(PlatformOpenInShellFn)); set => NativePtr->PlatformOpenInShellFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		public IntPtr PlatformOpenInShellUserData { get => (IntPtr)NativePtr->PlatformOpenInShellUserData; set => NativePtr->PlatformOpenInShellUserData = (void*)value; }
		/// <summary>
		///     Optional: Notify OS Input Method Editor of the screen position of your cursor for text input position (e.g. when using Japanese/Chinese IME on Windows)<br/>    (default to use native imm32 api on Windows)<br/>
		/// </summary>
		public PlatformSetImeDataFn PlatformSetImeDataFn { get => (PlatformSetImeDataFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetImeDataFn, typeof(PlatformSetImeDataFn)); set => NativePtr->PlatformSetImeDataFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		public IntPtr PlatformImeUserData { get => (IntPtr)NativePtr->PlatformImeUserData; set => NativePtr->PlatformImeUserData = (void*)value; }
		/// <summary>
		///     Optional: Platform locale<br/>    [Experimental] Configure decimal point e.g. '.' or ',' useful for some languages (e.g. German), generally pulled from *localeconv()-&gt;decimal_point<br/>
		/// '.'<br/>
		/// </summary>
		public ref ushort PlatformLocaleDecimalPoint => ref Unsafe.AsRef<ushort>(&NativePtr->PlatformLocaleDecimalPoint);
		/// <summary>
		///     Written by some backends during ImGui_ImplXXXX_RenderDrawData() call to point backend_specific ImGui_ImplXXXX_RenderState* structure.<br/>
		/// </summary>
		public IntPtr RendererRenderState { get => (IntPtr)NativePtr->RendererRenderState; set => NativePtr->RendererRenderState = (void*)value; }
		/// <summary>
		///     Platform Backend functions (e.g. Win32, GLFW, SDL) ------------------- Called by -----<br/>
		/// . . U . .  Create a new platform window for the given viewport<br/>
		/// </summary>
		public PlatformCreateWindow PlatformCreateWindow { get => (PlatformCreateWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformCreateWindow, typeof(PlatformCreateWindow)); set => NativePtr->PlatformCreateWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . U . D  //<br/>
		/// </summary>
		public PlatformDestroyWindow PlatformDestroyWindow { get => (PlatformDestroyWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformDestroyWindow, typeof(PlatformDestroyWindow)); set => NativePtr->PlatformDestroyWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  Newly created windows are initially hidden so SetWindowPos/Size/Title can be called on them before showing the window<br/>
		/// </summary>
		public PlatformShowWindow PlatformShowWindow { get => (PlatformShowWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformShowWindow, typeof(PlatformShowWindow)); set => NativePtr->PlatformShowWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  Set platform window position (given the upper-left corner of client area)<br/>
		/// </summary>
		public PlatformSetWindowPos PlatformSetWindowPos { get => (PlatformSetWindowPos) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetWindowPos, typeof(PlatformSetWindowPos)); set => NativePtr->PlatformSetWindowPos = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . . . .  //<br/>
		/// </summary>
		public PlatformGetWindowPos PlatformGetWindowPos { get => (PlatformGetWindowPos) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetWindowPos, typeof(PlatformGetWindowPos)); set => NativePtr->PlatformGetWindowPos = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  Set platform window client area size (ignoring OS decorations such as OS title bar etc.)<br/>
		/// </summary>
		public PlatformSetWindowSize PlatformSetWindowSize { get => (PlatformSetWindowSize) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetWindowSize, typeof(PlatformSetWindowSize)); set => NativePtr->PlatformSetWindowSize = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . . . .  Get platform window client area size<br/>
		/// </summary>
		public PlatformGetWindowSize PlatformGetWindowSize { get => (PlatformGetWindowSize) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetWindowSize, typeof(PlatformGetWindowSize)); set => NativePtr->PlatformGetWindowSize = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . . . .  Move window to front and set input focus<br/>
		/// </summary>
		public PlatformSetWindowFocus PlatformSetWindowFocus { get => (PlatformSetWindowFocus) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetWindowFocus, typeof(PlatformSetWindowFocus)); set => NativePtr->PlatformSetWindowFocus = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  //<br/>
		/// </summary>
		public PlatformGetWindowFocus PlatformGetWindowFocus { get => (PlatformGetWindowFocus) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetWindowFocus, typeof(PlatformGetWindowFocus)); set => NativePtr->PlatformGetWindowFocus = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . . . .  Get platform window minimized state. When minimized, we generally won't attempt to get/set size and contents will be culled more easily<br/>
		/// </summary>
		public PlatformGetWindowMinimized PlatformGetWindowMinimized { get => (PlatformGetWindowMinimized) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetWindowMinimized, typeof(PlatformGetWindowMinimized)); set => NativePtr->PlatformGetWindowMinimized = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  Set platform window title (given an UTF-8 string)<br/>
		/// </summary>
		public PlatformSetWindowTitle PlatformSetWindowTitle { get => (PlatformSetWindowTitle) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetWindowTitle, typeof(PlatformSetWindowTitle)); set => NativePtr->PlatformSetWindowTitle = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  (Optional) Setup global transparency (not per-pixel transparency)<br/>
		/// </summary>
		public PlatformSetWindowAlpha PlatformSetWindowAlpha { get => (PlatformSetWindowAlpha) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSetWindowAlpha, typeof(PlatformSetWindowAlpha)); set => NativePtr->PlatformSetWindowAlpha = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  (Optional) Called by UpdatePlatformWindows(). Optional hook to allow the platform backend from doing general book-keeping every frame.<br/>
		/// </summary>
		public PlatformUpdateWindow PlatformUpdateWindow { get => (PlatformUpdateWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformUpdateWindow, typeof(PlatformUpdateWindow)); set => NativePtr->PlatformUpdateWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . . R .  (Optional) Main rendering (platform side! This is often unused, or just setting a "current" context for OpenGL bindings). 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public PlatformRenderWindow PlatformRenderWindow { get => (PlatformRenderWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformRenderWindow, typeof(PlatformRenderWindow)); set => NativePtr->PlatformRenderWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . . R .  (Optional) Call Present/SwapBuffers (platform side! This is often unused!). 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public PlatformSwapBuffers PlatformSwapBuffers { get => (PlatformSwapBuffers) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformSwapBuffers, typeof(PlatformSwapBuffers)); set => NativePtr->PlatformSwapBuffers = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . . . .  (Optional) [BETA] FIXME-DPI: DPI handling: Return DPI scale for this viewport. 1.0f = 96 DPI.<br/>
		/// </summary>
		public PlatformGetWindowDpiScale PlatformGetWindowDpiScale { get => (PlatformGetWindowDpiScale) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetWindowDpiScale, typeof(PlatformGetWindowDpiScale)); set => NativePtr->PlatformGetWindowDpiScale = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . F . . .  (Optional) [BETA] FIXME-DPI: DPI handling: Called during Begin() every time the viewport we are outputting into changes, so backend has a chance to swap fonts to adjust style.<br/>
		/// </summary>
		public PlatformOnChangedViewport PlatformOnChangedViewport { get => (PlatformOnChangedViewport) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformOnChangedViewport, typeof(PlatformOnChangedViewport)); set => NativePtr->PlatformOnChangedViewport = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . . . .  (Optional) [BETA] Get initial work area inset for the viewport (won't be covered by main menu bar, dockspace over viewport etc.). Default to (0,0),(0,0). 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.<br/>
		/// </summary>
		public PlatformGetWindowWorkAreaInsets PlatformGetWindowWorkAreaInsets { get => (PlatformGetWindowWorkAreaInsets) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformGetWindowWorkAreaInsets, typeof(PlatformGetWindowWorkAreaInsets)); set => NativePtr->PlatformGetWindowWorkAreaInsets = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// (Optional) For a Vulkan Renderer to call into Platform code (since the surface creation needs to tie them both).<br/>
		/// </summary>
		public PlatformCreateVkSurface PlatformCreateVkSurface { get => (PlatformCreateVkSurface) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->PlatformCreateVkSurface, typeof(PlatformCreateVkSurface)); set => NativePtr->PlatformCreateVkSurface = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		///     Renderer Backend functions (e.g. DirectX, OpenGL, Vulkan) ------------ Called by -----<br/>
		/// . . U . .  Create swap chain, frame buffers etc. (called after Platform_CreateWindow)<br/>
		/// </summary>
		public RendererCreateWindow RendererCreateWindow { get => (RendererCreateWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->RendererCreateWindow, typeof(RendererCreateWindow)); set => NativePtr->RendererCreateWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// N . U . D  Destroy swap chain, frame buffers etc. (called before Platform_DestroyWindow)<br/>
		/// </summary>
		public RendererDestroyWindow RendererDestroyWindow { get => (RendererDestroyWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->RendererDestroyWindow, typeof(RendererDestroyWindow)); set => NativePtr->RendererDestroyWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . U . .  Resize swap chain, frame buffers etc. (called after Platform_SetWindowSize)<br/>
		/// </summary>
		public RendererSetWindowSize RendererSetWindowSize { get => (RendererSetWindowSize) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->RendererSetWindowSize, typeof(RendererSetWindowSize)); set => NativePtr->RendererSetWindowSize = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . . R .  (Optional) Clear framebuffer, setup render target, then render the viewport-&gt;DrawData. 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public RendererRenderWindow RendererRenderWindow { get => (RendererRenderWindow) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->RendererRenderWindow, typeof(RendererRenderWindow)); set => NativePtr->RendererRenderWindow = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// . . . R .  (Optional) Call Present/SwapBuffers. 'render_arg' is the value passed to RenderPlatformWindowsDefault().<br/>
		/// </summary>
		public RendererSwapBuffers RendererSwapBuffers { get => (RendererSwapBuffers) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->RendererSwapBuffers, typeof(RendererSwapBuffers)); set => NativePtr->RendererSwapBuffers = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		///     (Optional) Monitor list<br/>    - Updated by: app/backend. Update every frame to dynamically support changing monitor or DPI configuration.<br/>    - Used by: dear imgui to query DPI info, clamp popups/tooltips within same monitor and not have them straddle monitors.<br/>
		/// </summary>
		public ref ImVector<ImGuiPlatformMonitor> Monitors => ref Unsafe.AsRef<ImVector<ImGuiPlatformMonitor>>(&NativePtr->Monitors);
		/// <summary>
		///     Viewports list (the list is updated by calling ImGui::EndFrame or ImGui::Render)<br/>    (in the future we will attempt to organize this feature to remove the need for a "main viewport")<br/>
		/// Main viewports, followed by all secondary viewports.<br/>
		/// </summary>
		public ref ImVector<ImGuiViewportPtr> Viewports => ref Unsafe.AsRef<ImVector<ImGuiViewportPtr>>(&NativePtr->Viewports);
		public ImGuiPlatformIOPtr(ImGuiPlatformIO* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformIO*)nativePtr;
		public static implicit operator ImGuiPlatformIOPtr(ImGuiPlatformIO* ptr) => new ImGuiPlatformIOPtr(ptr);
		public static implicit operator ImGuiPlatformIOPtr(IntPtr ptr) => new ImGuiPlatformIOPtr(ptr);
		public static implicit operator ImGuiPlatformIO*(ImGuiPlatformIOPtr nativePtr) => nativePtr.NativePtr;
		public void SetPlatformGetWindowSize(ImGuiPlatformIOPtr platformIo, ImGuiPlatformIOSetPlatformGetWindowSizeUserCallback userCallback)
		{
			ImGuiNative.ImGuiPlatformIOSetPlatformGetWindowSize(platformIo, userCallback);
		}

		public void SetPlatformGetWindowPos(ImGuiPlatformIOPtr platformIo, ImGuiPlatformIOSetPlatformGetWindowPosUserCallback userCallback)
		{
			ImGuiNative.ImGuiPlatformIOSetPlatformGetWindowPos(platformIo, userCallback);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiPlatformIODestroy(NativePtr);
		}

		public void ImGuiPlatformIOConstruct()
		{
			ImGuiNative.ImGuiPlatformIOImGuiPlatformIOConstruct(NativePtr);
		}

		public ImGuiPlatformIOPtr ImGuiPlatformIO()
		{
			return ImGuiNative.ImGuiPlatformIOImGuiPlatformIO();
		}

	}
}
