using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// All draw data to render a Dear ImGui frame<br/>(NB: the style and the naming convention here is a little inconsistent, we currently preserve them for backward compatibility purpose,<br/>as this is one of the oldest structure exposed by the library! Basically, ImDrawList == CmdList)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawData
	{
		/// <summary>
		/// Only valid after Render() is called and before the next NewFrame() is called.<br/>
		/// </summary>
		public byte Valid;
		/// <summary>
		/// Number of ImDrawList* to render<br/>
		/// </summary>
		public int CmdListsCount;
		/// <summary>
		/// For convenience, sum of all ImDrawList's IdxBuffer.Size<br/>
		/// </summary>
		public int TotalIdxCount;
		/// <summary>
		/// For convenience, sum of all ImDrawList's VtxBuffer.Size<br/>
		/// </summary>
		public int TotalVtxCount;
		/// <summary>
		/// Array of ImDrawList* to render. The ImDrawLists are owned by ImGuiContext and only pointed to from here.<br/>
		/// </summary>
		public ImVector<ImDrawListPtr> CmdLists;
		/// <summary>
		/// Top-left position of the viewport to render (== top-left of the orthogonal projection matrix to use) (== GetMainViewport()-&gt;Pos for the main viewport, == (0.0) in most single-viewport applications)<br/>
		/// </summary>
		public Vector2 DisplayPos;
		/// <summary>
		/// Size of the viewport to render (== GetMainViewport()-&gt;Size for the main viewport, == io.DisplaySize in most single-viewport applications)<br/>
		/// </summary>
		public Vector2 DisplaySize;
		/// <summary>
		/// Amount of pixels for each unit of DisplaySize. Based on io.DisplayFramebufferScale. Generally (1,1) on normal display, (2,2) on OSX with Retina display.<br/>
		/// </summary>
		public Vector2 FramebufferScale;
		/// <summary>
		/// Viewport carrying the ImDrawData instance, might be of use to the renderer (generally not).<br/>
		/// </summary>
		public unsafe ImGuiViewport* OwnerViewport;
	}

	/// <summary>
	/// All draw data to render a Dear ImGui frame<br/>(NB: the style and the naming convention here is a little inconsistent, we currently preserve them for backward compatibility purpose,<br/>as this is one of the oldest structure exposed by the library! Basically, ImDrawList == CmdList)<br/>
	/// </summary>
	public unsafe partial struct ImDrawDataPtr
	{
		public ImDrawData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Only valid after Render() is called and before the next NewFrame() is called.<br/>
		/// </summary>
		public ref bool Valid => ref Unsafe.AsRef<bool>(&NativePtr->Valid);
		/// <summary>
		/// Number of ImDrawList* to render<br/>
		/// </summary>
		public ref int CmdListsCount => ref Unsafe.AsRef<int>(&NativePtr->CmdListsCount);
		/// <summary>
		/// For convenience, sum of all ImDrawList's IdxBuffer.Size<br/>
		/// </summary>
		public ref int TotalIdxCount => ref Unsafe.AsRef<int>(&NativePtr->TotalIdxCount);
		/// <summary>
		/// For convenience, sum of all ImDrawList's VtxBuffer.Size<br/>
		/// </summary>
		public ref int TotalVtxCount => ref Unsafe.AsRef<int>(&NativePtr->TotalVtxCount);
		/// <summary>
		/// Array of ImDrawList* to render. The ImDrawLists are owned by ImGuiContext and only pointed to from here.<br/>
		/// </summary>
		public ref ImVector<ImDrawListPtr> CmdLists => ref Unsafe.AsRef<ImVector<ImDrawListPtr>>(&NativePtr->CmdLists);
		/// <summary>
		/// Top-left position of the viewport to render (== top-left of the orthogonal projection matrix to use) (== GetMainViewport()-&gt;Pos for the main viewport, == (0.0) in most single-viewport applications)<br/>
		/// </summary>
		public ref Vector2 DisplayPos => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayPos);
		/// <summary>
		/// Size of the viewport to render (== GetMainViewport()-&gt;Size for the main viewport, == io.DisplaySize in most single-viewport applications)<br/>
		/// </summary>
		public ref Vector2 DisplaySize => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySize);
		/// <summary>
		/// Amount of pixels for each unit of DisplaySize. Based on io.DisplayFramebufferScale. Generally (1,1) on normal display, (2,2) on OSX with Retina display.<br/>
		/// </summary>
		public ref Vector2 FramebufferScale => ref Unsafe.AsRef<Vector2>(&NativePtr->FramebufferScale);
		/// <summary>
		/// Viewport carrying the ImDrawData instance, might be of use to the renderer (generally not).<br/>
		/// </summary>
		public ref ImGuiViewportPtr OwnerViewport => ref Unsafe.AsRef<ImGuiViewportPtr>(&NativePtr->OwnerViewport);
		public ImDrawDataPtr(ImDrawData* nativePtr) => NativePtr = nativePtr;
		public ImDrawDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawData*)nativePtr;
		public static implicit operator ImDrawDataPtr(ImDrawData* ptr) => new ImDrawDataPtr(ptr);
		public static implicit operator ImDrawDataPtr(IntPtr ptr) => new ImDrawDataPtr(ptr);
		public static implicit operator ImDrawData*(ImDrawDataPtr nativePtr) => nativePtr.NativePtr;
		/// <summary>
		/// Helper to scale the ClipRect field of each ImDrawCmd. Use if your final output buffer is at a different scale than Dear ImGui expects, or if there is a difference between your window resolution and framebuffer resolution.<br/>
		/// </summary>
		public void ScaleClipRects(Vector2 fbScale)
		{
			ImGuiNative.ImDrawDataScaleClipRects(NativePtr, fbScale);
		}

		/// <summary>
		/// Helper to convert all buffers from indexed to non-indexed, in case you cannot render indexed. Note: this is slow and most likely a waste of resources. Always prefer indexed rendering!<br/>
		/// </summary>
		public void DeIndexAllBuffers()
		{
			ImGuiNative.ImDrawDataDeIndexAllBuffers(NativePtr);
		}

		/// <summary>
		/// Helper to add an external draw list into an existing ImDrawData.<br/>
		/// </summary>
		public void AddDrawList(ImDrawListPtr drawList)
		{
			ImGuiNative.ImDrawDataAddDrawList(NativePtr, drawList);
		}

		public void Clear()
		{
			ImGuiNative.ImDrawDataClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImDrawDataDestroy(NativePtr);
		}

		public void ImDrawDataConstruct()
		{
			ImGuiNative.ImDrawDataImDrawDataConstruct(NativePtr);
		}

		public ImDrawDataPtr ImDrawData()
		{
			return ImGuiNative.ImDrawDataImDrawData();
		}

	}
}
