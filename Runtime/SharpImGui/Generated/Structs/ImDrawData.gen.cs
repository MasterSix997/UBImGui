using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>All draw data to render a Dear ImGui frame</para>
	/// <para>(NB: the style and the naming convention here is a little inconsistent, we currently preserve them for backward compatibility purpose,</para>
	/// <para>as this is one of the oldest structure exposed by the library! Basically, ImDrawList == CmdList)</para>
	/// </summary>
	public unsafe partial struct ImDrawData
	{
		/// <summary>
		/// Only valid after Render() is called and before the next NewFrame() is called.
		/// </summary>
		public byte Valid;
		/// <summary>
		/// Number of ImDrawList* to render
		/// </summary>
		public int CmdListsCount;
		/// <summary>
		/// For convenience, sum of all ImDrawList's IdxBuffer.Size
		/// </summary>
		public int TotalIdxCount;
		/// <summary>
		/// For convenience, sum of all ImDrawList's VtxBuffer.Size
		/// </summary>
		public int TotalVtxCount;
		/// <summary>
		/// Array of ImDrawList* to render. The ImDrawLists are owned by ImGuiContext and only pointed to from here.
		/// </summary>
		public ImVector CmdLists;
		/// <summary>
		/// Top-left position of the viewport to render (== top-left of the orthogonal projection matrix to use) (== GetMainViewport()-&gt;Pos for the main viewport, == (0.0) in most single-viewport applications)
		/// </summary>
		public Vector2 DisplayPos;
		/// <summary>
		/// Size of the viewport to render (== GetMainViewport()-&gt;Size for the main viewport, == io.DisplaySize in most single-viewport applications)
		/// </summary>
		public Vector2 DisplaySize;
		/// <summary>
		/// Amount of pixels for each unit of DisplaySize. Based on io.DisplayFramebufferScale. Generally (1,1) on normal display, (2,2) on OSX with Retina display.
		/// </summary>
		public Vector2 FramebufferScale;
		/// <summary>
		/// Viewport carrying the ImDrawData instance, might be of use to the renderer (generally not).
		/// </summary>
		public ImGuiViewport* OwnerViewport;
	}

	/// <summary>
	/// <para>All draw data to render a Dear ImGui frame</para>
	/// <para>(NB: the style and the naming convention here is a little inconsistent, we currently preserve them for backward compatibility purpose,</para>
	/// <para>as this is one of the oldest structure exposed by the library! Basically, ImDrawList == CmdList)</para>
	/// </summary>
	public unsafe partial struct ImDrawDataPtr
	{
		public ImDrawData* NativePtr { get; }
		public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
		public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
		public static implicit operator ImDrawDataPtr(ImDrawData* nativePtr) => new ImDrawDataPtr(nativePtr);
		public static implicit operator ImDrawData* (ImDrawDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawDataPtr(IntPtr nativePtr) => new ImDrawDataPtr(nativePtr);

		/// <summary>
		/// Only valid after Render() is called and before the next NewFrame() is called.
		/// </summary>
		public ref bool Valid => ref Unsafe.AsRef<bool>(&NativePtr->Valid);

		/// <summary>
		/// Number of ImDrawList* to render
		/// </summary>
		public ref int CmdListsCount => ref Unsafe.AsRef<int>(&NativePtr->CmdListsCount);

		/// <summary>
		/// For convenience, sum of all ImDrawList's IdxBuffer.Size
		/// </summary>
		public ref int TotalIdxCount => ref Unsafe.AsRef<int>(&NativePtr->TotalIdxCount);

		/// <summary>
		/// For convenience, sum of all ImDrawList's VtxBuffer.Size
		/// </summary>
		public ref int TotalVtxCount => ref Unsafe.AsRef<int>(&NativePtr->TotalVtxCount);

		/// <summary>
		/// Array of ImDrawList* to render. The ImDrawLists are owned by ImGuiContext and only pointed to from here.
		/// </summary>
		public ImVector<ImDrawListPtr> CmdLists => new ImVector<ImDrawListPtr>(NativePtr->CmdLists);

		/// <summary>
		/// Top-left position of the viewport to render (== top-left of the orthogonal projection matrix to use) (== GetMainViewport()-&gt;Pos for the main viewport, == (0.0) in most single-viewport applications)
		/// </summary>
		public ref Vector2 DisplayPos => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayPos);

		/// <summary>
		/// Size of the viewport to render (== GetMainViewport()-&gt;Size for the main viewport, == io.DisplaySize in most single-viewport applications)
		/// </summary>
		public ref Vector2 DisplaySize => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySize);

		/// <summary>
		/// Amount of pixels for each unit of DisplaySize. Based on io.DisplayFramebufferScale. Generally (1,1) on normal display, (2,2) on OSX with Retina display.
		/// </summary>
		public ref Vector2 FramebufferScale => ref Unsafe.AsRef<Vector2>(&NativePtr->FramebufferScale);

		/// <summary>
		/// Viewport carrying the ImDrawData instance, might be of use to the renderer (generally not).
		/// </summary>
		public ImGuiViewportPtr OwnerViewport => new ImGuiViewportPtr(NativePtr->OwnerViewport);

		public void Clear()
		{
			ImGuiNative.ImDrawData_Clear(NativePtr);
		}

		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.
		/// </summary>
		public void AddDrawList(ImDrawListPtr draw_list)
		{
			ImGuiNative.ImDrawData_AddDrawList(NativePtr, draw_list);
		}

		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!
		/// </summary>
		public void DeIndexAllBuffers()
		{
			ImGuiNative.ImDrawData_DeIndexAllBuffers(NativePtr);
		}

		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.
		/// </summary>
		public void ScaleClipRects(Vector2 fb_scale)
		{
			ImGuiNative.ImDrawData_ScaleClipRects(NativePtr, fb_scale);
		}
	}
}
