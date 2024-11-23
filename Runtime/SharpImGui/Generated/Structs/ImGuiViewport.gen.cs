using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>- Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.</para>
	/// <para>- With multi-viewport enabled, we extend this concept to have multiple active viewports.</para>
	/// <para>- In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.</para>
	/// <para>- About Main Area vs Work Area:</para>
	/// <para>  - Main Area = entire viewport.</para>
	/// <para>  - Work Area = entire viewport minus sections used by main menu bars (for platform windows), or by task bar (for platform monitor).</para>
	/// <para>  - Windows are generally trying to stay within the Work Area of their host viewport.</para>
	/// </summary>
	public unsafe partial struct ImGuiViewport
	{
		/// <summary>
		/// Unique identifier for the viewport
		/// </summary>
		public uint ID;
		/// <summary>
		/// See ImGuiViewportFlags_
		/// </summary>
		public ImGuiViewportFlags Flags;
		/// <summary>
		/// Main Area: Position of the viewport (Dear ImGui coordinates are the same as OS desktop/native coordinates)
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Main Area: Size of the viewport.
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// Work Area: Position of the viewport minus task bars, menus bars, status bars (&gt;= Pos)
		/// </summary>
		public Vector2 WorkPos;
		/// <summary>
		/// Work Area: Size of the viewport minus task bars, menu bars, status bars (&lt;= Size)
		/// </summary>
		public Vector2 WorkSize;
		/// <summary>
		/// 1.0f = 96 DPI = No extra scale.
		/// </summary>
		public float DpiScale;
		/// <summary>
		/// (Advanced) 0: no parent. Instruct the platform backend to setup a parent/child relationship between platform windows.
		/// </summary>
		public uint ParentViewportId;
		/// <summary>
		/// The ImDrawData corresponding to this viewport. Valid after Render() and until the next call to NewFrame().
		/// </summary>
		public ImDrawData* DrawData;
		/// <summary>
		/// <para>Platform/Backend Dependent Data</para>
		/// <para>Our design separate the Renderer and Platform backends to facilitate combining default backends with each others.</para>
		/// <para>When our create your own backend for a custom engine, it is possible that both Renderer and Platform will be handled</para>
		/// <para>by the same system and you may not need to use all the UserData/Handle fields.</para>
		/// <para>The library never uses those fields, they are merely storage to facilitate backend implementation.</para>
		/// </summary>
		/// <summary>
		/// void* to hold custom data structure for the renderer (e.g. swap chain, framebuffers etc.). generally set by your Renderer_CreateWindow function.
		/// </summary>
		public void* RendererUserData;
		/// <summary>
		/// void* to hold custom data structure for the OS / platform (e.g. windowing info, render context). generally set by your Platform_CreateWindow function.
		/// </summary>
		public void* PlatformUserData;
		/// <summary>
		/// void* to hold higher-level, platform window handle (e.g. HWND, GLFWWindow*, SDL_Window*), for FindViewportByPlatformHandle().
		/// </summary>
		public void* PlatformHandle;
		/// <summary>
		/// void* to hold lower-level, platform-native window handle (under Win32 this is expected to be a HWND, unused for other platforms), when using an abstraction layer like GLFW or SDL (where PlatformHandle would be a SDL_Window*)
		/// </summary>
		public void* PlatformHandleRaw;
		/// <summary>
		/// Platform window has been created (Platform_CreateWindow() has been called). This is false during the first frame where a viewport is being created.
		/// </summary>
		public byte PlatformWindowCreated;
		/// <summary>
		/// Platform window requested move (e.g. window was moved by the OS / host window manager, authoritative position will be OS window position)
		/// </summary>
		public byte PlatformRequestMove;
		/// <summary>
		/// Platform window requested resize (e.g. window was resized by the OS / host window manager, authoritative size will be OS window size)
		/// </summary>
		public byte PlatformRequestResize;
		/// <summary>
		/// Platform window requested closure (e.g. window was moved by the OS / host window manager, e.g. pressing ALT-F4)
		/// </summary>
		public byte PlatformRequestClose;
	}

	/// <summary>
	/// <para>- Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.</para>
	/// <para>- With multi-viewport enabled, we extend this concept to have multiple active viewports.</para>
	/// <para>- In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.</para>
	/// <para>- About Main Area vs Work Area:</para>
	/// <para>  - Main Area = entire viewport.</para>
	/// <para>  - Work Area = entire viewport minus sections used by main menu bars (for platform windows), or by task bar (for platform monitor).</para>
	/// <para>  - Windows are generally trying to stay within the Work Area of their host viewport.</para>
	/// </summary>
	public unsafe partial struct ImGuiViewportPtr
	{
		public ImGuiViewport* NativePtr { get; }
		public ImGuiViewportPtr(ImGuiViewport* nativePtr) => NativePtr = nativePtr;
		public ImGuiViewportPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewport*)nativePtr;
		public static implicit operator ImGuiViewportPtr(ImGuiViewport* nativePtr) => new ImGuiViewportPtr(nativePtr);
		public static implicit operator ImGuiViewport* (ImGuiViewportPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiViewportPtr(IntPtr nativePtr) => new ImGuiViewportPtr(nativePtr);

		/// <summary>
		/// Unique identifier for the viewport
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// See ImGuiViewportFlags_
		/// </summary>
		public ref ImGuiViewportFlags Flags => ref Unsafe.AsRef<ImGuiViewportFlags>(&NativePtr->Flags);

		/// <summary>
		/// Main Area: Position of the viewport (Dear ImGui coordinates are the same as OS desktop/native coordinates)
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);

		/// <summary>
		/// Main Area: Size of the viewport.
		/// </summary>
		public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);

		/// <summary>
		/// Work Area: Position of the viewport minus task bars, menus bars, status bars (&gt;= Pos)
		/// </summary>
		public ref Vector2 WorkPos => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkPos);

		/// <summary>
		/// Work Area: Size of the viewport minus task bars, menu bars, status bars (&lt;= Size)
		/// </summary>
		public ref Vector2 WorkSize => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkSize);

		/// <summary>
		/// 1.0f = 96 DPI = No extra scale.
		/// </summary>
		public ref float DpiScale => ref Unsafe.AsRef<float>(&NativePtr->DpiScale);

		/// <summary>
		/// (Advanced) 0: no parent. Instruct the platform backend to setup a parent/child relationship between platform windows.
		/// </summary>
		public ref uint ParentViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ParentViewportId);

		/// <summary>
		/// The ImDrawData corresponding to this viewport. Valid after Render() and until the next call to NewFrame().
		/// </summary>
		public ImDrawDataPtr DrawData => new ImDrawDataPtr(NativePtr->DrawData);

		/// <summary>
		/// <para>Platform/Backend Dependent Data</para>
		/// <para>Our design separate the Renderer and Platform backends to facilitate combining default backends with each others.</para>
		/// <para>When our create your own backend for a custom engine, it is possible that both Renderer and Platform will be handled</para>
		/// <para>by the same system and you may not need to use all the UserData/Handle fields.</para>
		/// <para>The library never uses those fields, they are merely storage to facilitate backend implementation.</para>
		/// </summary>
		/// <summary>
		/// void* to hold custom data structure for the renderer (e.g. swap chain, framebuffers etc.). generally set by your Renderer_CreateWindow function.
		/// </summary>
		public IntPtr RendererUserData { get => (IntPtr)NativePtr->RendererUserData; set => NativePtr->RendererUserData = (void*)value; }

		/// <summary>
		/// void* to hold custom data structure for the OS / platform (e.g. windowing info, render context). generally set by your Platform_CreateWindow function.
		/// </summary>
		public IntPtr PlatformUserData { get => (IntPtr)NativePtr->PlatformUserData; set => NativePtr->PlatformUserData = (void*)value; }

		/// <summary>
		/// void* to hold higher-level, platform window handle (e.g. HWND, GLFWWindow*, SDL_Window*), for FindViewportByPlatformHandle().
		/// </summary>
		public IntPtr PlatformHandle { get => (IntPtr)NativePtr->PlatformHandle; set => NativePtr->PlatformHandle = (void*)value; }

		/// <summary>
		/// void* to hold lower-level, platform-native window handle (under Win32 this is expected to be a HWND, unused for other platforms), when using an abstraction layer like GLFW or SDL (where PlatformHandle would be a SDL_Window*)
		/// </summary>
		public IntPtr PlatformHandleRaw { get => (IntPtr)NativePtr->PlatformHandleRaw; set => NativePtr->PlatformHandleRaw = (void*)value; }

		/// <summary>
		/// Platform window has been created (Platform_CreateWindow() has been called). This is false during the first frame where a viewport is being created.
		/// </summary>
		public ref bool PlatformWindowCreated => ref Unsafe.AsRef<bool>(&NativePtr->PlatformWindowCreated);

		/// <summary>
		/// Platform window requested move (e.g. window was moved by the OS / host window manager, authoritative position will be OS window position)
		/// </summary>
		public ref bool PlatformRequestMove => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestMove);

		/// <summary>
		/// Platform window requested resize (e.g. window was resized by the OS / host window manager, authoritative size will be OS window size)
		/// </summary>
		public ref bool PlatformRequestResize => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestResize);

		/// <summary>
		/// Platform window requested closure (e.g. window was moved by the OS / host window manager, e.g. pressing ALT-F4)
		/// </summary>
		public ref bool PlatformRequestClose => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestClose);

		/// <summary>
		/// <para>Helpers</para>
		/// </summary>
		public Vector2 GetCenter()
		{
			var ret = ImGuiNative.ImGuiViewport_GetCenter(NativePtr);
			return ret;
		}

		public Vector2 GetWorkCenter()
		{
			var ret = ImGuiNative.ImGuiViewport_GetWorkCenter(NativePtr);
			return ret;
		}
	}
}
