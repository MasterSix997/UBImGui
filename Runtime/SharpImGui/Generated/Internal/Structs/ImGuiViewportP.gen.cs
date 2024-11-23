using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>ImGuiViewport Private/Internals fields (cardinal sin: we are using inheritance!)</para>
	/// <para>Every instance of ImGuiViewport is in fact a ImGuiViewportP.</para>
	/// </summary>
	public unsafe partial struct ImGuiViewportP
	{
		/// <summary>
		/// <para>Appended from parent type ImGuiViewport</para>
		/// </summary>
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
		/// <summary>
		/// Set when the viewport is owned by a window (and ImGuiViewportFlags_CanHostOtherWindows is NOT set)
		/// </summary>
		public ImGuiWindow* Window;
		public int Idx;
		/// <summary>
		/// Last frame number this viewport was activated by a window
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last stamp number from when a window hosted by this viewport was focused (by comparing this value between two viewport we have an implicit viewport z-order we use as fallback)
		/// </summary>
		public int LastFocusedStampCount;
		public uint LastNameHash;
		public Vector2 LastPos;
		public Vector2 LastSize;
		/// <summary>
		/// Window opacity (when dragging dockable windows/viewports we make them transparent)
		/// </summary>
		public float Alpha;
		public float LastAlpha;
		/// <summary>
		/// Instead of maintaining a LastFocusedWindow (which may harder to correctly maintain), we merely store weither NavWindow != NULL last time the viewport was focused.
		/// </summary>
		public byte LastFocusedHadNavWindow;
		public short PlatformMonitor;
		/// <summary>
		/// Last frame number the background (0) and foreground (1) draw lists were used
		/// </summary>
		public fixed int BgFgDrawListsLastFrame[2];
		/// <summary>
		/// Convenience background (0) and foreground (1) draw lists. We use them to draw software mouser cursor when io.MouseDrawCursor is set and to draw most debug overlays.
		/// </summary>
		public ImDrawList* BgFgDrawLists_0;
		public ImDrawList* BgFgDrawLists_1;
		public ImDrawData DrawDataP;
		/// <summary>
		/// Temporary data while building final ImDrawData
		/// </summary>
		public ImDrawDataBuilder DrawDataBuilder;
		public Vector2 LastPlatformPos;
		public Vector2 LastPlatformSize;
		public Vector2 LastRendererSize;
		/// <summary>
		/// <para>Per-viewport work area</para>
		/// <para>- Insets are &gt;= 0.0f values, distance from viewport corners to work area.</para>
		/// <para>- BeginMainMenuBar() and DockspaceOverViewport() tend to use work area to avoid stepping over existing contents.</para>
		/// <para>- Generally 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.</para>
		/// </summary>
		/// <summary>
		/// Work Area inset locked for the frame. GetWorkRect() always fits within GetMainRect().
		/// </summary>
		public Vector2 WorkInsetMin;
		/// <summary>
		/// "
		/// </summary>
		public Vector2 WorkInsetMax;
		/// <summary>
		/// Work Area inset accumulator for current frame, to become next frame's WorkInset
		/// </summary>
		public Vector2 BuildWorkInsetMin;
		/// <summary>
		/// "
		/// </summary>
		public Vector2 BuildWorkInsetMax;
	}

	/// <summary>
	/// <para>ImGuiViewport Private/Internals fields (cardinal sin: we are using inheritance!)</para>
	/// <para>Every instance of ImGuiViewport is in fact a ImGuiViewportP.</para>
	/// </summary>
	public unsafe partial struct ImGuiViewportPPtr
	{
		public ImGuiViewportP* NativePtr { get; }
		public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
		public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
		public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => new ImGuiViewportPPtr(nativePtr);
		public static implicit operator ImGuiViewportP* (ImGuiViewportPPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiViewportPPtr(IntPtr nativePtr) => new ImGuiViewportPPtr(nativePtr);

		/// <summary>
		/// <para>Appended from parent type ImGuiViewport</para>
		/// </summary>
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
		/// Set when the viewport is owned by a window (and ImGuiViewportFlags_CanHostOtherWindows is NOT set)
		/// </summary>
		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		public ref int Idx => ref Unsafe.AsRef<int>(&NativePtr->Idx);

		/// <summary>
		/// Last frame number this viewport was activated by a window
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);

		/// <summary>
		/// Last stamp number from when a window hosted by this viewport was focused (by comparing this value between two viewport we have an implicit viewport z-order we use as fallback)
		/// </summary>
		public ref int LastFocusedStampCount => ref Unsafe.AsRef<int>(&NativePtr->LastFocusedStampCount);

		public ref uint LastNameHash => ref Unsafe.AsRef<uint>(&NativePtr->LastNameHash);

		public ref Vector2 LastPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPos);

		public ref Vector2 LastSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastSize);

		/// <summary>
		/// Window opacity (when dragging dockable windows/viewports we make them transparent)
		/// </summary>
		public ref float Alpha => ref Unsafe.AsRef<float>(&NativePtr->Alpha);

		public ref float LastAlpha => ref Unsafe.AsRef<float>(&NativePtr->LastAlpha);

		/// <summary>
		/// Instead of maintaining a LastFocusedWindow (which may harder to correctly maintain), we merely store weither NavWindow != NULL last time the viewport was focused.
		/// </summary>
		public ref bool LastFocusedHadNavWindow => ref Unsafe.AsRef<bool>(&NativePtr->LastFocusedHadNavWindow);

		public ref short PlatformMonitor => ref Unsafe.AsRef<short>(&NativePtr->PlatformMonitor);

		/// <summary>
		/// Last frame number the background (0) and foreground (1) draw lists were used
		/// </summary>
		public RangeAccessor<int> BgFgDrawListsLastFrame => new RangeAccessor<int>(NativePtr->BgFgDrawListsLastFrame, 2);

		/// <summary>
		/// Convenience background (0) and foreground (1) draw lists. We use them to draw software mouser cursor when io.MouseDrawCursor is set and to draw most debug overlays.
		/// </summary>
		public RangeAccessor<ImDrawList> BgFgDrawLists => new RangeAccessor<ImDrawList>(&NativePtr->BgFgDrawLists_0, 2);

		public ref ImDrawData DrawDataP => ref Unsafe.AsRef<ImDrawData>(&NativePtr->DrawDataP);

		/// <summary>
		/// Temporary data while building final ImDrawData
		/// </summary>
		public ref ImDrawDataBuilder DrawDataBuilder => ref Unsafe.AsRef<ImDrawDataBuilder>(&NativePtr->DrawDataBuilder);

		public ref Vector2 LastPlatformPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformPos);

		public ref Vector2 LastPlatformSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformSize);

		public ref Vector2 LastRendererSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastRendererSize);

		/// <summary>
		/// <para>Per-viewport work area</para>
		/// <para>- Insets are &gt;= 0.0f values, distance from viewport corners to work area.</para>
		/// <para>- BeginMainMenuBar() and DockspaceOverViewport() tend to use work area to avoid stepping over existing contents.</para>
		/// <para>- Generally 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.</para>
		/// </summary>
		/// <summary>
		/// Work Area inset locked for the frame. GetWorkRect() always fits within GetMainRect().
		/// </summary>
		public ref Vector2 WorkInsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkInsetMin);

		/// <summary>
		/// "
		/// </summary>
		public ref Vector2 WorkInsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkInsetMax);

		/// <summary>
		/// Work Area inset accumulator for current frame, to become next frame's WorkInset
		/// </summary>
		public ref Vector2 BuildWorkInsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkInsetMin);

		/// <summary>
		/// "
		/// </summary>
		public ref Vector2 BuildWorkInsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkInsetMax);

		public void ClearRequestFlags()
		{
			ImGuiInternalNative.ImGuiViewportP_ClearRequestFlags(NativePtr);
		}

		/// <summary>
		/// <para>Calculate work rect pos/size given a set of offset (we have 1 pair of offset for rect locked from last frame data, and 1 pair for currently building rect)</para>
		/// </summary>
		public Vector2 CalcWorkRectPos(Vector2 inset_min)
		{
			var ret = ImGuiInternalNative.ImGuiViewportP_CalcWorkRectPos(NativePtr, inset_min);
			return ret;
		}

		public Vector2 CalcWorkRectSize(Vector2 inset_min, Vector2 inset_max)
		{
			var ret = ImGuiInternalNative.ImGuiViewportP_CalcWorkRectSize(NativePtr, inset_min, inset_max);
			return ret;
		}

		/// <summary>
		/// Update public fields
		/// </summary>
		public void UpdateWorkRect()
		{
			ImGuiInternalNative.ImGuiViewportP_UpdateWorkRect(NativePtr);
		}

		/// <summary>
		/// <para>Helpers to retrieve ImRect (we don't need to store BuildWorkRect as every access tend to change it, hence the code asymmetry)</para>
		/// </summary>
		public ImRect GetMainRect()
		{
			var ret = ImGuiInternalNative.ImGuiViewportP_GetMainRect(NativePtr);
			return ret;
		}

		public ImRect GetWorkRect()
		{
			var ret = ImGuiInternalNative.ImGuiViewportP_GetWorkRect(NativePtr);
			return ret;
		}

		public ImRect GetBuildWorkRect()
		{
			var ret = ImGuiInternalNative.ImGuiViewportP_GetBuildWorkRect(NativePtr);
			return ret;
		}
	}
}
