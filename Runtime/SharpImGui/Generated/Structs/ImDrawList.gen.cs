using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Draw command list</para>
	/// <para>This is the low-level list of polygons that ImGui:: functions are filling. At the end of the frame,</para>
	/// <para>all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.</para>
	/// <para>Each dear imgui window contains its own ImDrawList. You can use ImGui::GetWindowDrawList() to</para>
	/// <para>access the current window draw list and draw custom primitives.</para>
	/// <para>You can interleave normal ImGui:: calls and adding primitives to the current draw list.</para>
	/// <para>In single viewport mode, top-left is == GetMainViewport()-&gt;Pos (generally 0,0), bottom-right is == GetMainViewport()-&gt;Pos+Size (generally io.DisplaySize).</para>
	/// <para>You are totally free to apply whatever transformation matrix you want to the data (depending on the use of the transformation you may want to apply it to ClipRect as well!)</para>
	/// <para>Important: Primitives are always added to the list and not culled (culling is done at higher-level by ImGui:: functions), if you use this API a lot consider coarse culling your drawn objects.</para>
	/// </summary>
	public unsafe partial struct ImDrawList
	{
		/// <summary>
		/// <para>This is what you have to render</para>
		/// </summary>
		/// <summary>
		/// Draw commands. Typically 1 command = 1 GPU draw call, unless the command is a callback.
		/// </summary>
		public ImVector CmdBuffer;
		/// <summary>
		/// Index buffer. Each command consume ImDrawCmd::ElemCount of those
		/// </summary>
		public ImVector IdxBuffer;
		/// <summary>
		/// Vertex buffer.
		/// </summary>
		public ImVector VtxBuffer;
		/// <summary>
		/// Flags, you may poke into these to adjust anti-aliasing settings per-primitive.
		/// </summary>
		public ImDrawListFlags Flags;
		/// <summary>
		/// <para>[Internal, used while building lists]</para>
		/// </summary>
		/// <summary>
		/// [Internal] generally == VtxBuffer.Size unless we are past 64K vertices, in which case this gets reset to 0.
		/// </summary>
		public uint _VtxCurrentIdx;
		/// <summary>
		/// Pointer to shared draw data (you can use ImGui::GetDrawListSharedData() to get the one from current ImGui context)
		/// </summary>
		public IntPtr _Data;
		/// <summary>
		/// [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)
		/// </summary>
		public ImDrawVert* _VtxWritePtr;
		/// <summary>
		/// [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)
		/// </summary>
		public ushort* _IdxWritePtr;
		/// <summary>
		/// [Internal] current path building
		/// </summary>
		public ImVector _Path;
		/// <summary>
		/// [Internal] template of active commands. Fields should match those of CmdBuffer.back().
		/// </summary>
		public ImDrawCmdHeader _CmdHeader;
		/// <summary>
		/// [Internal] for channels api (note: prefer using your own persistent instance of ImDrawListSplitter!)
		/// </summary>
		public ImDrawListSplitter _Splitter;
		/// <summary>
		/// [Internal]
		/// </summary>
		public ImVector _ClipRectStack;
		/// <summary>
		/// [Internal]
		/// </summary>
		public ImVector _TextureIdStack;
		/// <summary>
		/// [Internal]
		/// </summary>
		public ImVector _CallbacksDataBuf;
		/// <summary>
		/// [Internal] anti-alias fringe is scaled by this value, this helps to keep things sharp while zooming at vertex buffer content
		/// </summary>
		public float _FringeScale;
		/// <summary>
		/// Pointer to owner window's name for debugging
		/// </summary>
		public byte* _OwnerName;
	}

	/// <summary>
	/// <para>Draw command list</para>
	/// <para>This is the low-level list of polygons that ImGui:: functions are filling. At the end of the frame,</para>
	/// <para>all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.</para>
	/// <para>Each dear imgui window contains its own ImDrawList. You can use ImGui::GetWindowDrawList() to</para>
	/// <para>access the current window draw list and draw custom primitives.</para>
	/// <para>You can interleave normal ImGui:: calls and adding primitives to the current draw list.</para>
	/// <para>In single viewport mode, top-left is == GetMainViewport()-&gt;Pos (generally 0,0), bottom-right is == GetMainViewport()-&gt;Pos+Size (generally io.DisplaySize).</para>
	/// <para>You are totally free to apply whatever transformation matrix you want to the data (depending on the use of the transformation you may want to apply it to ClipRect as well!)</para>
	/// <para>Important: Primitives are always added to the list and not culled (culling is done at higher-level by ImGui:: functions), if you use this API a lot consider coarse culling your drawn objects.</para>
	/// </summary>
	public unsafe partial struct ImDrawListPtr
	{
		public ImDrawList* NativePtr { get; }
		public ImDrawListPtr(ImDrawList* nativePtr) => NativePtr = nativePtr;
		public ImDrawListPtr(IntPtr nativePtr) => NativePtr = (ImDrawList*)nativePtr;
		public static implicit operator ImDrawListPtr(ImDrawList* nativePtr) => new ImDrawListPtr(nativePtr);
		public static implicit operator ImDrawList* (ImDrawListPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawListPtr(IntPtr nativePtr) => new ImDrawListPtr(nativePtr);

		/// <summary>
		/// <para>This is what you have to render</para>
		/// </summary>
		/// <summary>
		/// Draw commands. Typically 1 command = 1 GPU draw call, unless the command is a callback.
		/// </summary>
		public ImPtrVector<ImDrawCmdPtr> CmdBuffer => new ImPtrVector<ImDrawCmdPtr>(NativePtr->CmdBuffer, Unsafe.SizeOf<ImDrawCmd>());

		/// <summary>
		/// Index buffer. Each command consume ImDrawCmd::ElemCount of those
		/// </summary>
		public ImVector<ushort> IdxBuffer => new ImVector<ushort>(NativePtr->IdxBuffer);

		/// <summary>
		/// Vertex buffer.
		/// </summary>
		public ImPtrVector<ImDrawVertPtr> VtxBuffer => new ImPtrVector<ImDrawVertPtr>(NativePtr->VtxBuffer, Unsafe.SizeOf<ImDrawVert>());

		/// <summary>
		/// Flags, you may poke into these to adjust anti-aliasing settings per-primitive.
		/// </summary>
		public ref ImDrawListFlags Flags => ref Unsafe.AsRef<ImDrawListFlags>(&NativePtr->Flags);

		/// <summary>
		/// <para>[Internal, used while building lists]</para>
		/// </summary>
		/// <summary>
		/// [Internal] generally == VtxBuffer.Size unless we are past 64K vertices, in which case this gets reset to 0.
		/// </summary>
		public ref uint _VtxCurrentIdx => ref Unsafe.AsRef<uint>(&NativePtr->_VtxCurrentIdx);

		/// <summary>
		/// Pointer to shared draw data (you can use ImGui::GetDrawListSharedData() to get the one from current ImGui context)
		/// </summary>
		public ref IntPtr _Data => ref Unsafe.AsRef<IntPtr>(&NativePtr->_Data);

		/// <summary>
		/// [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)
		/// </summary>
		public ImDrawVertPtr _VtxWritePtr => new ImDrawVertPtr(NativePtr->_VtxWritePtr);

		/// <summary>
		/// [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)
		/// </summary>
		public IntPtr _IdxWritePtr { get => (IntPtr)NativePtr->_IdxWritePtr; set => NativePtr->_IdxWritePtr = (ushort*)value; }

		/// <summary>
		/// [Internal] current path building
		/// </summary>
		public ImVector<Vector2> _Path => new ImVector<Vector2>(NativePtr->_Path);

		/// <summary>
		/// [Internal] template of active commands. Fields should match those of CmdBuffer.back().
		/// </summary>
		public ref ImDrawCmdHeader _CmdHeader => ref Unsafe.AsRef<ImDrawCmdHeader>(&NativePtr->_CmdHeader);

		/// <summary>
		/// [Internal] for channels api (note: prefer using your own persistent instance of ImDrawListSplitter!)
		/// </summary>
		public ref ImDrawListSplitter _Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->_Splitter);

		/// <summary>
		/// [Internal]
		/// </summary>
		public ImVector<Vector4> _ClipRectStack => new ImVector<Vector4>(NativePtr->_ClipRectStack);

		/// <summary>
		/// [Internal]
		/// </summary>
		public ImVector<IntPtr> _TextureIdStack => new ImVector<IntPtr>(NativePtr->_TextureIdStack);

		/// <summary>
		/// [Internal]
		/// </summary>
		public ImVector<byte> _CallbacksDataBuf => new ImVector<byte>(NativePtr->_CallbacksDataBuf);

		/// <summary>
		/// [Internal] anti-alias fringe is scaled by this value, this helps to keep things sharp while zooming at vertex buffer content
		/// </summary>
		public ref float _FringeScale => ref Unsafe.AsRef<float>(&NativePtr->_FringeScale);

		/// <summary>
		/// Pointer to owner window's name for debugging
		/// </summary>
		public NullTerminatedString _OwnerName => new NullTerminatedString(NativePtr->_OwnerName);

		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)
		/// </summary>
		public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max)
		{
			byte intersect_with_current_clip_rect = 0;

			ImGuiNative.ImDrawList_PushClipRect(NativePtr, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect);
		}
		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)
		/// </summary>
		public void PushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, bool intersect_with_current_clip_rect)
		{
			// Marshaling 'intersect_with_current_clip_rect' to native bool
			var native_intersect_with_current_clip_rect = intersect_with_current_clip_rect ? (byte)1 : (byte)0;

			ImGuiNative.ImDrawList_PushClipRect(NativePtr, clip_rect_min, clip_rect_max, native_intersect_with_current_clip_rect);
		}

		public void PushClipRectFullScreen()
		{
			ImGuiNative.ImDrawList_PushClipRectFullScreen(NativePtr);
		}

		public void PopClipRect()
		{
			ImGuiNative.ImDrawList_PopClipRect(NativePtr);
		}

		public void PushTextureID(IntPtr texture_id)
		{
			ImGuiNative.ImDrawList_PushTextureID(NativePtr, texture_id);
		}

		public void PopTextureID()
		{
			ImGuiNative.ImDrawList_PopTextureID(NativePtr);
		}

		public Vector2 GetClipRectMin()
		{
			var ret = ImGuiNative.ImDrawList_GetClipRectMin(NativePtr);
			return ret;
		}

		public Vector2 GetClipRectMax()
		{
			var ret = ImGuiNative.ImDrawList_GetClipRectMax(NativePtr);
			return ret;
		}

		/// <summary>
		/// <para>Primitives</para>
		/// <para>- Filled shapes must always use clockwise winding order. The anti-aliasing fringe depends on it. Counter-clockwise shapes will have "inward" anti-aliasing.</para>
		/// <para>- For rectangular primitives, "p_min" and "p_max" represent the upper-left and lower-right corners.</para>
		/// <para>- For circle primitives, use "num_segments == 0" to automatically calculate tessellation (preferred).</para>
		/// <para>  In older versions (until Dear ImGui 1.77) the AddCircle functions defaulted to num_segments == 12.</para>
		/// <para>  In future versions we will use textures to provide cheaper and higher-quality circles.</para>
		/// <para>  Use AddNgon() and AddNgonFilled() functions if you need to guarantee a specific number of sides.</para>
		/// </summary>
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddLine(Vector2 p1, Vector2 p2, uint col)
		{
			ImGuiNative.ImDrawList_AddLine(NativePtr, p1, p2, col);
		}

		/// <summary>
		/// <para>Primitives</para>
		/// <para>- Filled shapes must always use clockwise winding order. The anti-aliasing fringe depends on it. Counter-clockwise shapes will have "inward" anti-aliasing.</para>
		/// <para>- For rectangular primitives, "p_min" and "p_max" represent the upper-left and lower-right corners.</para>
		/// <para>- For circle primitives, use "num_segments == 0" to automatically calculate tessellation (preferred).</para>
		/// <para>  In older versions (until Dear ImGui 1.77) the AddCircle functions defaulted to num_segments == 12.</para>
		/// <para>  In future versions we will use textures to provide cheaper and higher-quality circles.</para>
		/// <para>  Use AddNgon() and AddNgonFilled() functions if you need to guarantee a specific number of sides.</para>
		/// </summary>
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddLine(Vector2 p1, Vector2 p2, uint col, float thickness)
		{
			ImGuiNative.ImDrawList_AddLineEx(NativePtr, p1, p2, col, thickness);
		}

		/// <summary>
		/// Implied rounding = 0.0f, flags = 0, thickness = 1.0f
		/// </summary>
		public void AddRect(Vector2 p_min, Vector2 p_max, uint col)
		{
			ImGuiNative.ImDrawList_AddRect(NativePtr, p_min, p_max, col);
		}

		/// <summary>
		/// Implied rounding = 0.0f, flags = 0, thickness = 1.0f
		/// </summary>
		public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding)
		{
			ImDrawFlags flags = (ImDrawFlags)0;

			float thickness = 1.0f;

			ImGuiNative.ImDrawList_AddRectEx(NativePtr, p_min, p_max, col, rounding, flags, thickness);
		}
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0, thickness = 1.0f
		/// </summary>
		public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags)
		{
			float thickness = 1.0f;

			ImGuiNative.ImDrawList_AddRectEx(NativePtr, p_min, p_max, col, rounding, flags, thickness);
		}
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0, thickness = 1.0f
		/// </summary>
		public void AddRect(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness)
		{
			ImGuiNative.ImDrawList_AddRectEx(NativePtr, p_min, p_max, col, rounding, flags, thickness);
		}

		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col)
		{
			ImGuiNative.ImDrawList_AddRectFilled(NativePtr, p_min, p_max, col);
		}

		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding)
		{
			ImDrawFlags flags = (ImDrawFlags)0;

			ImGuiNative.ImDrawList_AddRectFilledEx(NativePtr, p_min, p_max, col, rounding, flags);
		}
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		public void AddRectFilled(Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.ImDrawList_AddRectFilledEx(NativePtr, p_min, p_max, col, rounding, flags);
		}

		public void AddRectFilledMultiColor(Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
		{
			ImGuiNative.ImDrawList_AddRectFilledMultiColor(NativePtr, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left);
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			ImGuiNative.ImDrawList_AddQuad(NativePtr, p1, p2, p3, p4, col);
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
		{
			ImGuiNative.ImDrawList_AddQuadEx(NativePtr, p1, p2, p3, p4, col, thickness);
		}

		public void AddQuadFilled(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			ImGuiNative.ImDrawList_AddQuadFilled(NativePtr, p1, p2, p3, p4, col);
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			ImGuiNative.ImDrawList_AddTriangle(NativePtr, p1, p2, p3, col);
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
		{
			ImGuiNative.ImDrawList_AddTriangleEx(NativePtr, p1, p2, p3, col, thickness);
		}

		public void AddTriangleFilled(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			ImGuiNative.ImDrawList_AddTriangleFilled(NativePtr, p1, p2, p3, col);
		}

		/// <summary>
		/// Implied num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddCircle(Vector2 center, float radius, uint col)
		{
			ImGuiNative.ImDrawList_AddCircle(NativePtr, center, radius, col);
		}

		/// <summary>
		/// Implied num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddCircle(Vector2 center, float radius, uint col, int num_segments)
		{
			float thickness = 1.0f;

			ImGuiNative.ImDrawList_AddCircleEx(NativePtr, center, radius, col, num_segments, thickness);
		}
		/// <summary>
		/// Implied num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddCircle(Vector2 center, float radius, uint col, int num_segments, float thickness)
		{
			ImGuiNative.ImDrawList_AddCircleEx(NativePtr, center, radius, col, num_segments, thickness);
		}

		public void AddCircleFilled(Vector2 center, float radius, uint col)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_AddCircleFilled(NativePtr, center, radius, col, num_segments);
		}
		public void AddCircleFilled(Vector2 center, float radius, uint col, int num_segments)
		{
			ImGuiNative.ImDrawList_AddCircleFilled(NativePtr, center, radius, col, num_segments);
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddNgon(Vector2 center, float radius, uint col, int num_segments)
		{
			ImGuiNative.ImDrawList_AddNgon(NativePtr, center, radius, col, num_segments);
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public void AddNgon(Vector2 center, float radius, uint col, int num_segments, float thickness)
		{
			ImGuiNative.ImDrawList_AddNgonEx(NativePtr, center, radius, col, num_segments, thickness);
		}

		public void AddNgonFilled(Vector2 center, float radius, uint col, int num_segments)
		{
			ImGuiNative.ImDrawList_AddNgonFilled(NativePtr, center, radius, col, num_segments);
		}

		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddEllipse(Vector2 center, Vector2 radius, uint col)
		{
			ImGuiNative.ImDrawList_AddEllipse(NativePtr, center, radius, col);
		}

		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddEllipse(Vector2 center, Vector2 radius, uint col, float rot)
		{
			int num_segments = 0;

			float thickness = 1.0f;

			ImGuiNative.ImDrawList_AddEllipseEx(NativePtr, center, radius, col, rot, num_segments, thickness);
		}
		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddEllipse(Vector2 center, Vector2 radius, uint col, float rot, int num_segments)
		{
			float thickness = 1.0f;

			ImGuiNative.ImDrawList_AddEllipseEx(NativePtr, center, radius, col, rot, num_segments, thickness);
		}
		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0, thickness = 1.0f
		/// </summary>
		public void AddEllipse(Vector2 center, Vector2 radius, uint col, float rot, int num_segments, float thickness)
		{
			ImGuiNative.ImDrawList_AddEllipseEx(NativePtr, center, radius, col, rot, num_segments, thickness);
		}

		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0
		/// </summary>
		public void AddEllipseFilled(Vector2 center, Vector2 radius, uint col)
		{
			ImGuiNative.ImDrawList_AddEllipseFilled(NativePtr, center, radius, col);
		}

		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0
		/// </summary>
		public void AddEllipseFilled(Vector2 center, Vector2 radius, uint col, float rot)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_AddEllipseFilledEx(NativePtr, center, radius, col, rot, num_segments);
		}
		/// <summary>
		/// Implied rot = 0.0f, num_segments = 0
		/// </summary>
		public void AddEllipseFilled(Vector2 center, Vector2 radius, uint col, float rot, int num_segments)
		{
			ImGuiNative.ImDrawList_AddEllipseFilledEx(NativePtr, center, radius, col, rot, num_segments);
		}

		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public void AddText(Vector2 pos, uint col, ReadOnlySpan<char> text_begin)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			ImGuiNative.ImDrawList_AddText(NativePtr, pos, col, native_text_begin);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
		}

		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public void AddText(Vector2 pos, uint col, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

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

			ImGuiNative.ImDrawList_AddTextEx(NativePtr, pos, col, native_text_begin, native_text_end);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		/// <summary>
		/// Implied text_end = NULL, wrap_width = 0.0f, cpu_fine_clip_rect = NULL
		/// </summary>
		public void AddTextImFontPtr(ImFontPtr font, float font_size, Vector2 pos, uint col, ReadOnlySpan<char> text_begin)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

			ImGuiNative.ImDrawList_AddTextImFontPtr(NativePtr, font, font_size, pos, col, native_text_begin);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
		}

		/// <summary>
		/// Implied text_end = NULL, wrap_width = 0.0f, cpu_fine_clip_rect = NULL
		/// </summary>
		public void AddTextImFontPtr(ImFontPtr font, float font_size, Vector2 pos, uint col, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

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

			float wrap_width = 0.0f;

			Vector4* cpu_fine_clip_rect = null;

			ImGuiNative.ImDrawList_AddTextImFontPtrEx(NativePtr, font, font_size, pos, col, native_text_begin, native_text_end, wrap_width, cpu_fine_clip_rect);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}
		/// <summary>
		/// Implied text_end = NULL, wrap_width = 0.0f, cpu_fine_clip_rect = NULL
		/// </summary>
		public void AddTextImFontPtr(ImFontPtr font, float font_size, Vector2 pos, uint col, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end, float wrap_width)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

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

			Vector4* cpu_fine_clip_rect = null;

			ImGuiNative.ImDrawList_AddTextImFontPtrEx(NativePtr, font, font_size, pos, col, native_text_begin, native_text_end, wrap_width, cpu_fine_clip_rect);
			if (text_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_begin);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}
		/// <summary>
		/// Implied text_end = NULL, wrap_width = 0.0f, cpu_fine_clip_rect = NULL
		/// </summary>
		public void AddTextImFontPtr(ImFontPtr font, float font_size, Vector2 pos, uint col, ReadOnlySpan<char> text_begin, ReadOnlySpan<char> text_end, float wrap_width, ref Vector4 cpu_fine_clip_rect)
		{
			// Marshaling 'text_begin' to native string
			byte* native_text_begin;
			var text_begin_byteCount = 0;
			if (text_begin != null)
			{
				text_begin_byteCount = Encoding.UTF8.GetByteCount(text_begin);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_begin = Util.Allocate(text_begin_byteCount + 1);
				}
				else
				{
					var native_text_begin_stackBytes = stackalloc byte[text_begin_byteCount + 1];
					native_text_begin = native_text_begin_stackBytes;
				}
				var text_begin_offset = Util.GetUtf8(text_begin, native_text_begin, text_begin_byteCount);
				native_text_begin[text_begin_offset] = 0;
			}
			else native_text_begin = null;

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

			fixed (Vector4* native_cpu_fine_clip_rect = &cpu_fine_clip_rect)
			{
				ImGuiNative.ImDrawList_AddTextImFontPtrEx(NativePtr, font, font_size, pos, col, native_text_begin, native_text_end, wrap_width, native_cpu_fine_clip_rect);
				if (text_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_begin);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		/// <summary>
		/// Cubic Bezier (4 control points)
		/// </summary>
		public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_AddBezierCubic(NativePtr, p1, p2, p3, p4, col, thickness, num_segments);
		}
		/// <summary>
		/// Cubic Bezier (4 control points)
		/// </summary>
		public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments)
		{
			ImGuiNative.ImDrawList_AddBezierCubic(NativePtr, p1, p2, p3, p4, col, thickness, num_segments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)
		/// </summary>
		public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_AddBezierQuadratic(NativePtr, p1, p2, p3, col, thickness, num_segments);
		}
		/// <summary>
		/// Quadratic Bezier (3 control points)
		/// </summary>
		public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments)
		{
			ImGuiNative.ImDrawList_AddBezierQuadratic(NativePtr, p1, p2, p3, col, thickness, num_segments);
		}

		/// <summary>
		/// <para>General polygon</para>
		/// <para>- Only simple polygons are supported by filling functions (no self-intersections, no holes).</para>
		/// <para>- Concave polygon fill is more expensive than convex one: it has O(N^2) complexity. Provided as a convenience fo user but not used by main library.</para>
		/// </summary>
		public void AddPolyline(ref Vector2 points, int num_points, uint col, ImDrawFlags flags, float thickness)
		{
			fixed (Vector2* native_points = &points)
			{
				ImGuiNative.ImDrawList_AddPolyline(NativePtr, native_points, num_points, col, flags, thickness);
			}
		}

		public void AddConvexPolyFilled(ref Vector2 points, int num_points, uint col)
		{
			fixed (Vector2* native_points = &points)
			{
				ImGuiNative.ImDrawList_AddConvexPolyFilled(NativePtr, native_points, num_points, col);
			}
		}

		public void AddConcavePolyFilled(ref Vector2 points, int num_points, uint col)
		{
			fixed (Vector2* native_points = &points)
			{
				ImGuiNative.ImDrawList_AddConcavePolyFilled(NativePtr, native_points, num_points, col);
			}
		}

		/// <summary>
		/// <para>Image primitives</para>
		/// <para>- Read FAQ to understand what ImTextureID is.</para>
		/// <para>- "p_min" and "p_max" represent the upper-left and lower-right corners of the rectangle.</para>
		/// <para>- "uv_min" and "uv_max" represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.</para>
		/// </summary>
		/// <summary>
		/// Implied uv_min = ImVec2(0, 0), uv_max = ImVec2(1, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max)
		{
			ImGuiNative.ImDrawList_AddImage(NativePtr, user_texture_id, p_min, p_max);
		}

		/// <summary>
		/// <para>Image primitives</para>
		/// <para>- Read FAQ to understand what ImTextureID is.</para>
		/// <para>- "p_min" and "p_max" represent the upper-left and lower-right corners of the rectangle.</para>
		/// <para>- "uv_min" and "uv_max" represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.</para>
		/// </summary>
		/// <summary>
		/// Implied uv_min = ImVec2(0, 0), uv_max = ImVec2(1, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min)
		{
			Vector2 uv_max = new Vector2(1, 1);

			uint col = 0xFFFFFFFF;

			ImGuiNative.ImDrawList_AddImageEx(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
		}
		/// <summary>
		/// <para>Image primitives</para>
		/// <para>- Read FAQ to understand what ImTextureID is.</para>
		/// <para>- "p_min" and "p_max" represent the upper-left and lower-right corners of the rectangle.</para>
		/// <para>- "uv_min" and "uv_max" represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.</para>
		/// </summary>
		/// <summary>
		/// Implied uv_min = ImVec2(0, 0), uv_max = ImVec2(1, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max)
		{
			uint col = 0xFFFFFFFF;

			ImGuiNative.ImDrawList_AddImageEx(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
		}
		/// <summary>
		/// <para>Image primitives</para>
		/// <para>- Read FAQ to understand what ImTextureID is.</para>
		/// <para>- "p_min" and "p_max" represent the upper-left and lower-right corners of the rectangle.</para>
		/// <para>- "uv_min" and "uv_max" represent the normalized texture coordinates to use for those corners. Using (0,0)-&gt;(1,1) texture coordinates will generally display the entire texture.</para>
		/// </summary>
		/// <summary>
		/// Implied uv_min = ImVec2(0, 0), uv_max = ImVec2(1, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImage(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col)
		{
			ImGuiNative.ImDrawList_AddImageEx(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col);
		}

		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			ImGuiNative.ImDrawList_AddImageQuad(NativePtr, user_texture_id, p1, p2, p3, p4);
		}

		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1)
		{
			Vector2 uv2 = new Vector2(1, 0);

			Vector2 uv3 = new Vector2(1, 1);

			Vector2 uv4 = new Vector2(0, 1);

			uint col = 0xFFFFFFFF;

			ImGuiNative.ImDrawList_AddImageQuadEx(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}
		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2)
		{
			Vector2 uv3 = new Vector2(1, 1);

			Vector2 uv4 = new Vector2(0, 1);

			uint col = 0xFFFFFFFF;

			ImGuiNative.ImDrawList_AddImageQuadEx(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}
		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3)
		{
			Vector2 uv4 = new Vector2(0, 1);

			uint col = 0xFFFFFFFF;

			ImGuiNative.ImDrawList_AddImageQuadEx(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}
		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4)
		{
			uint col = 0xFFFFFFFF;

			ImGuiNative.ImDrawList_AddImageQuadEx(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}
		/// <summary>
		/// Implied uv1 = ImVec2(0, 0), uv2 = ImVec2(1, 0), uv3 = ImVec2(1, 1), uv4 = ImVec2(0, 1), col = IM_COL32_WHITE
		/// </summary>
		public void AddImageQuad(IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col)
		{
			ImGuiNative.ImDrawList_AddImageQuadEx(NativePtr, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding)
		{
			ImDrawFlags flags = (ImDrawFlags)0;

			ImGuiNative.ImDrawList_AddImageRounded(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags);
		}
		public void AddImageRounded(IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.ImDrawList_AddImageRounded(NativePtr, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, flags);
		}

		/// <summary>
		/// <para>Stateful path API, add points then finish with PathFillConvex() or PathStroke()</para>
		/// <para>- Important: filled shapes must always use clockwise winding order! The anti-aliasing fringe depends on it. Counter-clockwise shapes will have "inward" anti-aliasing.</para>
		/// <para>  so e.g. 'PathArcTo(center, radius, PI * -0.5f, PI)' is ok, whereas 'PathArcTo(center, radius, PI, PI * -0.5f)' won't have correct anti-aliasing when followed by PathFillConvex().</para>
		/// </summary>
		public void PathClear()
		{
			ImGuiNative.ImDrawList_PathClear(NativePtr);
		}

		public void PathLineTo(Vector2 pos)
		{
			ImGuiNative.ImDrawList_PathLineTo(NativePtr, pos);
		}

		public void PathLineToMergeDuplicate(Vector2 pos)
		{
			ImGuiNative.ImDrawList_PathLineToMergeDuplicate(NativePtr, pos);
		}

		public void PathFillConvex(uint col)
		{
			ImGuiNative.ImDrawList_PathFillConvex(NativePtr, col);
		}

		public void PathFillConcave(uint col)
		{
			ImGuiNative.ImDrawList_PathFillConcave(NativePtr, col);
		}

		public void PathStroke(uint col)
		{
			ImDrawFlags flags = (ImDrawFlags)0;

			float thickness = 1.0f;

			ImGuiNative.ImDrawList_PathStroke(NativePtr, col, flags, thickness);
		}
		public void PathStroke(uint col, ImDrawFlags flags)
		{
			float thickness = 1.0f;

			ImGuiNative.ImDrawList_PathStroke(NativePtr, col, flags, thickness);
		}
		public void PathStroke(uint col, ImDrawFlags flags, float thickness)
		{
			ImGuiNative.ImDrawList_PathStroke(NativePtr, col, flags, thickness);
		}

		public void PathArcTo(Vector2 center, float radius, float a_min, float a_max)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_PathArcTo(NativePtr, center, radius, a_min, a_max, num_segments);
		}
		public void PathArcTo(Vector2 center, float radius, float a_min, float a_max, int num_segments)
		{
			ImGuiNative.ImDrawList_PathArcTo(NativePtr, center, radius, a_min, a_max, num_segments);
		}

		/// <summary>
		/// Use precomputed angles for a 12 steps circle
		/// </summary>
		public void PathArcToFast(Vector2 center, float radius, int a_min_of_12, int a_max_of_12)
		{
			ImGuiNative.ImDrawList_PathArcToFast(NativePtr, center, radius, a_min_of_12, a_max_of_12);
		}

		/// <summary>
		/// Implied num_segments = 0
		/// </summary>
		public void PathEllipticalArcTo(Vector2 center, Vector2 radius, float rot, float a_min, float a_max)
		{
			ImGuiNative.ImDrawList_PathEllipticalArcTo(NativePtr, center, radius, rot, a_min, a_max);
		}

		/// <summary>
		/// Implied num_segments = 0
		/// </summary>
		public void PathEllipticalArcTo(Vector2 center, Vector2 radius, float rot, float a_min, float a_max, int num_segments)
		{
			ImGuiNative.ImDrawList_PathEllipticalArcToEx(NativePtr, center, radius, rot, a_min, a_max, num_segments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)
		/// </summary>
		public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_PathBezierCubicCurveTo(NativePtr, p2, p3, p4, num_segments);
		}
		/// <summary>
		/// Cubic Bezier (4 control points)
		/// </summary>
		public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4, int num_segments)
		{
			ImGuiNative.ImDrawList_PathBezierCubicCurveTo(NativePtr, p2, p3, p4, num_segments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)
		/// </summary>
		public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3)
		{
			int num_segments = 0;

			ImGuiNative.ImDrawList_PathBezierQuadraticCurveTo(NativePtr, p2, p3, num_segments);
		}
		/// <summary>
		/// Quadratic Bezier (3 control points)
		/// </summary>
		public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3, int num_segments)
		{
			ImGuiNative.ImDrawList_PathBezierQuadraticCurveTo(NativePtr, p2, p3, num_segments);
		}

		public void PathRect(Vector2 rect_min, Vector2 rect_max)
		{
			float rounding = 0.0f;

			ImDrawFlags flags = (ImDrawFlags)0;

			ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, flags);
		}
		public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding)
		{
			ImDrawFlags flags = (ImDrawFlags)0;

			ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, flags);
		}
		public void PathRect(Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.ImDrawList_PathRect(NativePtr, rect_min, rect_max, rounding, flags);
		}

		/// <summary>
		/// <para>Advanced: Draw Callbacks</para>
		/// <para>- May be used to alter render state (change sampler, blending, current shader). May be used to emit custom rendering commands (difficult to do correctly, but possible).</para>
		/// <para>- Use special ImDrawCallback_ResetRenderState callback to instruct backend to reset its render state to the default.</para>
		/// <para>- Your rendering loop must check for 'UserCallback' in ImDrawCmd and call the function instead of rendering triangles. All standard backends are honoring this.</para>
		/// <para>- For some backends, the callback may access selected render-states exposed by the backend in a ImGui_ImplXXXX_RenderState structure pointed to by platform_io.Renderer_RenderState.</para>
		/// <para>- IMPORTANT: please be mindful of the different level of indirection between using size==0 (copying argument) and using size&gt;0 (copying pointed data into a buffer).</para>
		/// <para>  - If userdata_size == 0: we copy/store the 'userdata' argument as-is. It will be available unmodified in ImDrawCmd::UserCallbackData during render.</para>
		/// <para>  - If userdata_size &gt; 0,  we copy/store 'userdata_size' bytes pointed to by 'userdata'. We store them in a buffer stored inside the drawlist. ImDrawCmd::UserCallbackData will point inside that buffer so you have to retrieve data from there. Your callback may need to use ImDrawCmd::UserCallbackDataSize if you expect dynamically-sized data.</para>
		/// <para>  - Support for userdata_size &gt; 0 was added in v1.91.4, October 2024. So earlier code always only allowed to copy/store a simple void*.</para>
		/// </summary>
		/// <summary>
		/// Implied userdata_size = 0
		/// </summary>
		public void AddCallback(IntPtr callback, IntPtr userdata)
		{
			// Marshaling 'userdata' to native void pointer
			var native_userdata = userdata.ToPointer();

			ImGuiNative.ImDrawList_AddCallback(NativePtr, callback, native_userdata);
		}

		/// <summary>
		/// <para>Advanced: Draw Callbacks</para>
		/// <para>- May be used to alter render state (change sampler, blending, current shader). May be used to emit custom rendering commands (difficult to do correctly, but possible).</para>
		/// <para>- Use special ImDrawCallback_ResetRenderState callback to instruct backend to reset its render state to the default.</para>
		/// <para>- Your rendering loop must check for 'UserCallback' in ImDrawCmd and call the function instead of rendering triangles. All standard backends are honoring this.</para>
		/// <para>- For some backends, the callback may access selected render-states exposed by the backend in a ImGui_ImplXXXX_RenderState structure pointed to by platform_io.Renderer_RenderState.</para>
		/// <para>- IMPORTANT: please be mindful of the different level of indirection between using size==0 (copying argument) and using size&gt;0 (copying pointed data into a buffer).</para>
		/// <para>  - If userdata_size == 0: we copy/store the 'userdata' argument as-is. It will be available unmodified in ImDrawCmd::UserCallbackData during render.</para>
		/// <para>  - If userdata_size &gt; 0,  we copy/store 'userdata_size' bytes pointed to by 'userdata'. We store them in a buffer stored inside the drawlist. ImDrawCmd::UserCallbackData will point inside that buffer so you have to retrieve data from there. Your callback may need to use ImDrawCmd::UserCallbackDataSize if you expect dynamically-sized data.</para>
		/// <para>  - Support for userdata_size &gt; 0 was added in v1.91.4, October 2024. So earlier code always only allowed to copy/store a simple void*.</para>
		/// </summary>
		/// <summary>
		/// Implied userdata_size = 0
		/// </summary>
		public void AddCallback(IntPtr callback, IntPtr userdata, uint userdata_size)
		{
			// Marshaling 'userdata' to native void pointer
			var native_userdata = userdata.ToPointer();

			ImGuiNative.ImDrawList_AddCallbackEx(NativePtr, callback, native_userdata, userdata_size);
		}

		/// <summary>
		/// <para>Advanced: Miscellaneous</para>
		/// </summary>
		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible
		/// </summary>
		public void AddDrawCmd()
		{
			ImGuiNative.ImDrawList_AddDrawCmd(NativePtr);
		}

		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.
		/// </summary>
		public ImDrawListPtr CloneOutput()
		{
			var ret = ImGuiNative.ImDrawList_CloneOutput(NativePtr);
			return ret;
		}

		/// <summary>
		/// <para>Advanced: Channels</para>
		/// <para>- Use to split render into layers. By switching channels to can render out-of-order (e.g. submit FG primitives before BG primitives)</para>
		/// <para>- Use to minimize draw calls (e.g. if going back-and-forth between multiple clipping rectangles, prefer to append into separate channels then merge at the end)</para>
		/// <para>- This API shouldn't have been in ImDrawList in the first place!</para>
		/// <para>  Prefer using your own persistent instance of ImDrawListSplitter as you can stack them.</para>
		/// <para>  Using the ImDrawList::ChannelsXXXX you cannot stack a split over another.</para>
		/// </summary>
		public void ChannelsSplit(int count)
		{
			ImGuiNative.ImDrawList_ChannelsSplit(NativePtr, count);
		}

		public void ChannelsMerge()
		{
			ImGuiNative.ImDrawList_ChannelsMerge(NativePtr);
		}

		public void ChannelsSetCurrent(int n)
		{
			ImGuiNative.ImDrawList_ChannelsSetCurrent(NativePtr, n);
		}

		/// <summary>
		/// <para>Advanced: Primitives allocations</para>
		/// <para>- We render triangles (three vertices)</para>
		/// <para>- All primitives needs to be reserved via PrimReserve() beforehand.</para>
		/// </summary>
		public void PrimReserve(int idx_count, int vtx_count)
		{
			ImGuiNative.ImDrawList_PrimReserve(NativePtr, idx_count, vtx_count);
		}

		public void PrimUnreserve(int idx_count, int vtx_count)
		{
			ImGuiNative.ImDrawList_PrimUnreserve(NativePtr, idx_count, vtx_count);
		}

		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)
		/// </summary>
		public void PrimRect(Vector2 a, Vector2 b, uint col)
		{
			ImGuiNative.ImDrawList_PrimRect(NativePtr, a, b, col);
		}

		public void PrimRectUV(Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col)
		{
			ImGuiNative.ImDrawList_PrimRectUV(NativePtr, a, b, uv_a, uv_b, col);
		}

		public void PrimQuadUV(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col)
		{
			ImGuiNative.ImDrawList_PrimQuadUV(NativePtr, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col);
		}

		public void PrimWriteVtx(Vector2 pos, Vector2 uv, uint col)
		{
			ImGuiNative.ImDrawList_PrimWriteVtx(NativePtr, pos, uv, col);
		}

		public void PrimWriteIdx(ushort idx)
		{
			ImGuiNative.ImDrawList_PrimWriteIdx(NativePtr, idx);
		}

		/// <summary>
		/// Write vertex with unique index
		/// </summary>
		public void PrimVtx(Vector2 pos, Vector2 uv, uint col)
		{
			ImGuiNative.ImDrawList_PrimVtx(NativePtr, pos, uv, col);
		}
	}
}
