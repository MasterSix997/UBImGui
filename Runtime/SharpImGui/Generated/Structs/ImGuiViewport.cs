using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// - Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.<br/>- With multi-viewport enabled, we extend this concept to have multiple active viewports.<br/>- In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.<br/>- About Main Area vs Work Area:<br/>  - Main Area = entire viewport.<br/>  - Work Area = entire viewport minus sections used by main menu bars (for platform windows), or by task bar (for platform monitor).<br/>  - Windows are generally trying to stay within the Work Area of their host viewport.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiViewport
	{
		/// <summary>
		/// Unique identifier for the viewport<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// See ImGuiViewportFlags_<br/>
		/// </summary>
		public ImGuiViewportFlags Flags;
		/// <summary>
		/// Main Area: Position of the viewport (Dear ImGui coordinates are the same as OS desktop/native coordinates)<br/>
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Main Area: Size of the viewport.<br/>
		/// </summary>
		public Vector2 Size;
		/// <summary>
		/// Work Area: Position of the viewport minus task bars, menus bars, status bars (&gt;= Pos)<br/>
		/// </summary>
		public Vector2 WorkPos;
		/// <summary>
		/// Work Area: Size of the viewport minus task bars, menu bars, status bars (&lt;= Size)<br/>
		/// </summary>
		public Vector2 WorkSize;
		/// <summary>
		/// 1.0f = 96 DPI = No extra scale.<br/>
		/// </summary>
		public float DpiScale;
		/// <summary>
		/// (Advanced) 0: no parent. Instruct the platform backend to setup a parent/child relationship between platform windows.<br/>
		/// </summary>
		public uint ParentViewportId;
		/// <summary>
		/// The ImDrawData corresponding to this viewport. Valid after Render() and until the next call to NewFrame().<br/>
		/// </summary>
		public unsafe ImDrawData* DrawData;
		/// <summary>
		///     Platform/Backend Dependent Data<br/>    Our design separate the Renderer and Platform backends to facilitate combining default backends with each others.<br/>    When our create your own backend for a custom engine, it is possible that both Renderer and Platform will be handled<br/>    by the same system and you may not need to use all the UserData/Handle fields.<br/>    The library never uses those fields, they are merely storage to facilitate backend implementation.<br/>
		/// void* to hold custom data structure for the renderer (e.g. swap chain, framebuffers etc.). generally set by your Renderer_CreateWindow function.<br/>
		/// </summary>
		public unsafe void* RendererUserData;
		/// <summary>
		/// void* to hold custom data structure for the OS / platform (e.g. windowing info, render context). generally set by your Platform_CreateWindow function.<br/>
		/// </summary>
		public unsafe void* PlatformUserData;
		/// <summary>
		/// void* to hold higher-level, platform window handle (e.g. HWND for Win32 backend, Uint32 WindowID for SDL, GLFWWindow* for GLFW), for FindViewportByPlatformHandle().<br/>
		/// </summary>
		public unsafe void* PlatformHandle;
		/// <summary>
		/// void* to hold lower-level, platform-native window handle (always HWND on Win32 platform, unused for other platforms).<br/>
		/// </summary>
		public unsafe void* PlatformHandleRaw;
		/// <summary>
		/// Platform window has been created (Platform_CreateWindow() has been called). This is false during the first frame where a viewport is being created.<br/>
		/// </summary>
		public byte PlatformWindowCreated;
		/// <summary>
		/// Platform window requested move (e.g. window was moved by the OS / host window manager, authoritative position will be OS window position)<br/>
		/// </summary>
		public byte PlatformRequestMove;
		/// <summary>
		/// Platform window requested resize (e.g. window was resized by the OS / host window manager, authoritative size will be OS window size)<br/>
		/// </summary>
		public byte PlatformRequestResize;
		/// <summary>
		/// Platform window requested closure (e.g. window was moved by the OS / host window manager, e.g. pressing ALT-F4)<br/>
		/// </summary>
		public byte PlatformRequestClose;
	}

	/// <summary>
	/// - Currently represents the Platform Window created by the application which is hosting our Dear ImGui windows.<br/>- With multi-viewport enabled, we extend this concept to have multiple active viewports.<br/>- In the future we will extend this concept further to also represent Platform Monitor and support a "no main platform window" operation mode.<br/>- About Main Area vs Work Area:<br/>  - Main Area = entire viewport.<br/>  - Work Area = entire viewport minus sections used by main menu bars (for platform windows), or by task bar (for platform monitor).<br/>  - Windows are generally trying to stay within the Work Area of their host viewport.<br/>
	/// </summary>
	public unsafe partial struct ImGuiViewportPtr
	{
		public ImGuiViewport* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiViewport this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Unique identifier for the viewport<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// See ImGuiViewportFlags_<br/>
		/// </summary>
		public ref ImGuiViewportFlags Flags => ref Unsafe.AsRef<ImGuiViewportFlags>(&NativePtr->Flags);
		/// <summary>
		/// Main Area: Position of the viewport (Dear ImGui coordinates are the same as OS desktop/native coordinates)<br/>
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);
		/// <summary>
		/// Main Area: Size of the viewport.<br/>
		/// </summary>
		public ref Vector2 Size => ref Unsafe.AsRef<Vector2>(&NativePtr->Size);
		/// <summary>
		/// Work Area: Position of the viewport minus task bars, menus bars, status bars (&gt;= Pos)<br/>
		/// </summary>
		public ref Vector2 WorkPos => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkPos);
		/// <summary>
		/// Work Area: Size of the viewport minus task bars, menu bars, status bars (&lt;= Size)<br/>
		/// </summary>
		public ref Vector2 WorkSize => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkSize);
		/// <summary>
		/// 1.0f = 96 DPI = No extra scale.<br/>
		/// </summary>
		public ref float DpiScale => ref Unsafe.AsRef<float>(&NativePtr->DpiScale);
		/// <summary>
		/// (Advanced) 0: no parent. Instruct the platform backend to setup a parent/child relationship between platform windows.<br/>
		/// </summary>
		public ref uint ParentViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ParentViewportId);
		/// <summary>
		/// The ImDrawData corresponding to this viewport. Valid after Render() and until the next call to NewFrame().<br/>
		/// </summary>
		public ref ImDrawDataPtr DrawData => ref Unsafe.AsRef<ImDrawDataPtr>(&NativePtr->DrawData);
		/// <summary>
		///     Platform/Backend Dependent Data<br/>    Our design separate the Renderer and Platform backends to facilitate combining default backends with each others.<br/>    When our create your own backend for a custom engine, it is possible that both Renderer and Platform will be handled<br/>    by the same system and you may not need to use all the UserData/Handle fields.<br/>    The library never uses those fields, they are merely storage to facilitate backend implementation.<br/>
		/// void* to hold custom data structure for the renderer (e.g. swap chain, framebuffers etc.). generally set by your Renderer_CreateWindow function.<br/>
		/// </summary>
		public IntPtr RendererUserData { get => (IntPtr)NativePtr->RendererUserData; set => NativePtr->RendererUserData = (void*)value; }
		/// <summary>
		/// void* to hold custom data structure for the OS / platform (e.g. windowing info, render context). generally set by your Platform_CreateWindow function.<br/>
		/// </summary>
		public IntPtr PlatformUserData { get => (IntPtr)NativePtr->PlatformUserData; set => NativePtr->PlatformUserData = (void*)value; }
		/// <summary>
		/// void* to hold higher-level, platform window handle (e.g. HWND for Win32 backend, Uint32 WindowID for SDL, GLFWWindow* for GLFW), for FindViewportByPlatformHandle().<br/>
		/// </summary>
		public IntPtr PlatformHandle { get => (IntPtr)NativePtr->PlatformHandle; set => NativePtr->PlatformHandle = (void*)value; }
		/// <summary>
		/// void* to hold lower-level, platform-native window handle (always HWND on Win32 platform, unused for other platforms).<br/>
		/// </summary>
		public IntPtr PlatformHandleRaw { get => (IntPtr)NativePtr->PlatformHandleRaw; set => NativePtr->PlatformHandleRaw = (void*)value; }
		/// <summary>
		/// Platform window has been created (Platform_CreateWindow() has been called). This is false during the first frame where a viewport is being created.<br/>
		/// </summary>
		public ref bool PlatformWindowCreated => ref Unsafe.AsRef<bool>(&NativePtr->PlatformWindowCreated);
		/// <summary>
		/// Platform window requested move (e.g. window was moved by the OS / host window manager, authoritative position will be OS window position)<br/>
		/// </summary>
		public ref bool PlatformRequestMove => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestMove);
		/// <summary>
		/// Platform window requested resize (e.g. window was resized by the OS / host window manager, authoritative size will be OS window size)<br/>
		/// </summary>
		public ref bool PlatformRequestResize => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestResize);
		/// <summary>
		/// Platform window requested closure (e.g. window was moved by the OS / host window manager, e.g. pressing ALT-F4)<br/>
		/// </summary>
		public ref bool PlatformRequestClose => ref Unsafe.AsRef<bool>(&NativePtr->PlatformRequestClose);
		public ImGuiViewportPtr(ImGuiViewport* nativePtr) => NativePtr = nativePtr;
		public ImGuiViewportPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewport*)nativePtr;
		public static implicit operator ImGuiViewportPtr(ImGuiViewport* ptr) => new ImGuiViewportPtr(ptr);
		public static implicit operator ImGuiViewportPtr(IntPtr ptr) => new ImGuiViewportPtr(ptr);
		public static implicit operator ImGuiViewport*(ImGuiViewportPtr nativePtr) => nativePtr.NativePtr;
		public void GetWorkCenter(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImGuiViewportGetWorkCenter(nativePOut, NativePtr);
			}
		}

		public void GetCenter(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImGuiViewportGetCenter(nativePOut, NativePtr);
			}
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiViewportDestroy(NativePtr);
		}

		public void ImGuiViewportConstruct()
		{
			ImGuiNative.ImGuiViewportImGuiViewportConstruct(NativePtr);
		}

		public ImGuiViewportPtr ImGuiViewport()
		{
			return ImGuiNative.ImGuiViewportImGuiViewport();
		}

	}
}
