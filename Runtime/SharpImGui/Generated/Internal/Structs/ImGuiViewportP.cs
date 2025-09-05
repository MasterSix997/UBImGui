using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// ImGuiViewport Private/Internals fields (cardinal sin: we are using inheritance!)<br/>Every instance of ImGuiViewport is in fact a ImGuiViewportP.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiViewportP
	{
		public ImGuiViewport ImGuiViewport;
		/// <summary>
		/// Set when the viewport is owned by a window (and ImGuiViewportFlags_CanHostOtherWindows is NOT set)<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		public int Idx;
		/// <summary>
		/// Last frame number this viewport was activated by a window<br/>
		/// </summary>
		public int LastFrameActive;
		/// <summary>
		/// Last stamp number from when a window hosted by this viewport was focused (by comparing this value between two viewport we have an implicit viewport z-order we use as fallback)<br/>
		/// </summary>
		public int LastFocusedStampCount;
		public uint LastNameHash;
		public Vector2 LastPos;
		public Vector2 LastSize;
		/// <summary>
		/// Window opacity (when dragging dockable windows/viewports we make them transparent)<br/>
		/// </summary>
		public float Alpha;
		public float LastAlpha;
		/// <summary>
		/// Instead of maintaining a LastFocusedWindow (which may harder to correctly maintain), we merely store weither NavWindow != NULL last time the viewport was focused.<br/>
		/// </summary>
		public byte LastFocusedHadNavWindow;
		public short PlatformMonitor;
		/// <summary>
		/// Last frame number the background (0) and foreground (1) draw lists were used<br/>
		/// </summary>
		public int BgFgDrawListsLastFrame_0;
		public int BgFgDrawListsLastFrame_1;
		/// <summary>
		/// Convenience background (0) and foreground (1) draw lists. We use them to draw software mouser cursor when io.MouseDrawCursor is set and to draw most debug overlays.<br/>
		/// </summary>
		public unsafe ImDrawList* BgFgDrawLists_0;
		public unsafe ImDrawList* BgFgDrawLists_1;
		public ImDrawData DrawDataP;
		/// <summary>
		/// Temporary data while building final ImDrawData<br/>
		/// </summary>
		public ImDrawDataBuilder DrawDataBuilder;
		public Vector2 LastPlatformPos;
		public Vector2 LastPlatformSize;
		public Vector2 LastRendererSize;
		/// <summary>
		///     Per-viewport work area<br/>    - Insets are &gt;= 0.0f values, distance from viewport corners to work area.<br/>    - BeginMainMenuBar() and DockspaceOverViewport() tend to use work area to avoid stepping over existing contents.<br/>    - Generally 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.<br/>
		/// Work Area inset locked for the frame. GetWorkRect() always fits within GetMainRect().<br/>
		/// </summary>
		public Vector2 WorkInsetMin;
		/// <summary>
		/// "<br/>
		/// </summary>
		public Vector2 WorkInsetMax;
		/// <summary>
		/// Work Area inset accumulator for current frame, to become next frame's WorkInset<br/>
		/// </summary>
		public Vector2 BuildWorkInsetMin;
		/// <summary>
		/// "<br/>
		/// </summary>
		public Vector2 BuildWorkInsetMax;
	}

	/// <summary>
	/// ImGuiViewport Private/Internals fields (cardinal sin: we are using inheritance!)<br/>Every instance of ImGuiViewport is in fact a ImGuiViewportP.<br/>
	/// </summary>
	public unsafe partial struct ImGuiViewportPPtr
	{
		public ImGuiViewportP* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiViewportP this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiViewport ImGuiViewport => ref Unsafe.AsRef<ImGuiViewport>(&NativePtr->ImGuiViewport);
		/// <summary>
		/// Set when the viewport is owned by a window (and ImGuiViewportFlags_CanHostOtherWindows is NOT set)<br/>
		/// </summary>
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		public ref int Idx => ref Unsafe.AsRef<int>(&NativePtr->Idx);
		/// <summary>
		/// Last frame number this viewport was activated by a window<br/>
		/// </summary>
		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);
		/// <summary>
		/// Last stamp number from when a window hosted by this viewport was focused (by comparing this value between two viewport we have an implicit viewport z-order we use as fallback)<br/>
		/// </summary>
		public ref int LastFocusedStampCount => ref Unsafe.AsRef<int>(&NativePtr->LastFocusedStampCount);
		public ref uint LastNameHash => ref Unsafe.AsRef<uint>(&NativePtr->LastNameHash);
		public ref Vector2 LastPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPos);
		public ref Vector2 LastSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastSize);
		/// <summary>
		/// Window opacity (when dragging dockable windows/viewports we make them transparent)<br/>
		/// </summary>
		public ref float Alpha => ref Unsafe.AsRef<float>(&NativePtr->Alpha);
		public ref float LastAlpha => ref Unsafe.AsRef<float>(&NativePtr->LastAlpha);
		/// <summary>
		/// Instead of maintaining a LastFocusedWindow (which may harder to correctly maintain), we merely store weither NavWindow != NULL last time the viewport was focused.<br/>
		/// </summary>
		public ref bool LastFocusedHadNavWindow => ref Unsafe.AsRef<bool>(&NativePtr->LastFocusedHadNavWindow);
		public ref short PlatformMonitor => ref Unsafe.AsRef<short>(&NativePtr->PlatformMonitor);
		/// <summary>
		/// Last frame number the background (0) and foreground (1) draw lists were used<br/>
		/// </summary>
		public Span<int> BgFgDrawListsLastFrame => new Span<int>(&NativePtr->BgFgDrawListsLastFrame_0, 2);
		/// <summary>
		/// Convenience background (0) and foreground (1) draw lists. We use them to draw software mouser cursor when io.MouseDrawCursor is set and to draw most debug overlays.<br/>
		/// </summary>
		public Span<ImPointer<ImDrawList>> BgFgDrawLists => new Span<ImPointer<ImDrawList>>(&NativePtr->BgFgDrawLists_0, 2);
		public ref ImDrawData DrawDataP => ref Unsafe.AsRef<ImDrawData>(&NativePtr->DrawDataP);
		/// <summary>
		/// Temporary data while building final ImDrawData<br/>
		/// </summary>
		public ref ImDrawDataBuilder DrawDataBuilder => ref Unsafe.AsRef<ImDrawDataBuilder>(&NativePtr->DrawDataBuilder);
		public ref Vector2 LastPlatformPos => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformPos);
		public ref Vector2 LastPlatformSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastPlatformSize);
		public ref Vector2 LastRendererSize => ref Unsafe.AsRef<Vector2>(&NativePtr->LastRendererSize);
		/// <summary>
		///     Per-viewport work area<br/>    - Insets are &gt;= 0.0f values, distance from viewport corners to work area.<br/>    - BeginMainMenuBar() and DockspaceOverViewport() tend to use work area to avoid stepping over existing contents.<br/>    - Generally 'safeAreaInsets' in iOS land, 'DisplayCutout' in Android land.<br/>
		/// Work Area inset locked for the frame. GetWorkRect() always fits within GetMainRect().<br/>
		/// </summary>
		public ref Vector2 WorkInsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkInsetMin);
		/// <summary>
		/// "<br/>
		/// </summary>
		public ref Vector2 WorkInsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkInsetMax);
		/// <summary>
		/// Work Area inset accumulator for current frame, to become next frame's WorkInset<br/>
		/// </summary>
		public ref Vector2 BuildWorkInsetMin => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkInsetMin);
		/// <summary>
		/// "<br/>
		/// </summary>
		public ref Vector2 BuildWorkInsetMax => ref Unsafe.AsRef<Vector2>(&NativePtr->BuildWorkInsetMax);
		public ImGuiViewportPPtr(ImGuiViewportP* nativePtr) => NativePtr = nativePtr;
		public ImGuiViewportPPtr(IntPtr nativePtr) => NativePtr = (ImGuiViewportP*)nativePtr;
		public static implicit operator ImGuiViewportPPtr(ImGuiViewportP* ptr) => new ImGuiViewportPPtr(ptr);
		public static implicit operator ImGuiViewportPPtr(IntPtr ptr) => new ImGuiViewportPPtr(ptr);
		public static implicit operator ImGuiViewportP*(ImGuiViewportPPtr nativePtr) => nativePtr.NativePtr;
		public void GetBuildWorkRect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiViewportPGetBuildWorkRect(pOut, NativePtr);
		}

		public void GetWorkRect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiViewportPGetWorkRect(pOut, NativePtr);
		}

		public void GetMainRect(ImRectPtr pOut)
		{
			ImGuiNative.ImGuiViewportPGetMainRect(pOut, NativePtr);
		}

		/// <summary>
		/// Update public fields<br/>
		/// </summary>
		public void UpdateWorkRect()
		{
			ImGuiNative.ImGuiViewportPUpdateWorkRect(NativePtr);
		}

		public void CalcWorkRectSize(out Vector2 pOut, Vector2 insetMin, Vector2 insetMax)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImGuiViewportPCalcWorkRectSize(nativePOut, NativePtr, insetMin, insetMax);
			}
		}

		public void CalcWorkRectPos(out Vector2 pOut, Vector2 insetMin)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImGuiViewportPCalcWorkRectPos(nativePOut, NativePtr, insetMin);
			}
		}

		public void ClearRequestFlags()
		{
			ImGuiNative.ImGuiViewportPClearRequestFlags(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiViewportPDestroy(NativePtr);
		}

		public void ImGuiViewportPConstruct()
		{
			ImGuiNative.ImGuiViewportPImGuiViewportPConstruct(NativePtr);
		}

		public ImGuiViewportPPtr ImGuiViewportP()
		{
			return ImGuiNative.ImGuiViewportPImGuiViewportP();
		}

	}
}
