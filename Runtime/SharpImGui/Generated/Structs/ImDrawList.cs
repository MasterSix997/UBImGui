using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Draw command list<br/>This is the low-level list of polygons that ImGui:: functions are filling. At the end of the frame,<br/>all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.<br/>Each dear imgui window contains its own ImDrawList. You can use ImGui::GetWindowDrawList() to<br/>access the current window draw list and draw custom primitives.<br/>You can interleave normal ImGui:: calls and adding primitives to the current draw list.<br/>In single viewport mode, top-left is == GetMainViewport()-&gt;Pos (generally 0,0), bottom-right is == GetMainViewport()-&gt;Pos+Size (generally io.DisplaySize).<br/>You are totally free to apply whatever transformation matrix you want to the data (depending on the use of the transformation you may want to apply it to ClipRect as well!)<br/>Important: Primitives are always added to the list and not culled (culling is done at higher-level by ImGui:: functions), if you use this API a lot consider coarse culling your drawn objects.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawList
	{
		/// <summary>
		/// <br/>    This is what you have to render<br/>
		/// Draw commands. Typically 1 command = 1 GPU draw call, unless the command is a callback.<br/>
		/// </summary>
		public ImVector<ImDrawCmd> CmdBuffer;
		/// <summary>
		/// Index buffer. Each command consume ImDrawCmd::ElemCount of those<br/>
		/// </summary>
		public ImVector<ushort> IdxBuffer;
		/// <summary>
		/// Vertex buffer.<br/>
		/// </summary>
		public ImVector<ImDrawVert> VtxBuffer;
		/// <summary>
		/// Flags, you may poke into these to adjust anti-aliasing settings per-primitive.<br/>
		/// </summary>
		public ImDrawListFlags Flags;
		/// <summary>
		///     [Internal, used while building lists]<br/>
		/// [Internal] generally == VtxBuffer.Size unless we are past 64K vertices, in which case this gets reset to 0.<br/>
		/// </summary>
		public uint VtxCurrentIdx;
		/// <summary>
		/// Pointer to shared draw data (you can use ImGui::GetDrawListSharedData() to get the one from current ImGui context)<br/>
		/// </summary>
		public unsafe ImDrawListSharedData* Data;
		/// <summary>
		/// [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)<br/>
		/// </summary>
		public unsafe ImDrawVert* VtxWritePtr;
		/// <summary>
		/// [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)<br/>
		/// </summary>
		public unsafe ushort* IdxWritePtr;
		/// <summary>
		/// [Internal] current path building<br/>
		/// </summary>
		public ImVector<Vector2> Path;
		/// <summary>
		/// [Internal] template of active commands. Fields should match those of CmdBuffer.back().<br/>
		/// </summary>
		public ImDrawCmdHeader CmdHeader;
		/// <summary>
		/// [Internal] for channels api (note: prefer using your own persistent instance of ImDrawListSplitter!)<br/>
		/// </summary>
		public ImDrawListSplitter Splitter;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImVector<Vector4> ClipRectStack;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImVector<ulong> TextureIdStack;
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ImVector<byte> CallbacksDataBuf;
		/// <summary>
		/// [Internal] anti-alias fringe is scaled by this value, this helps to keep things sharp while zooming at vertex buffer content<br/>
		/// </summary>
		public float FringeScale;
		/// <summary>
		/// Pointer to owner window's name for debugging<br/>
		/// </summary>
		public unsafe byte* OwnerName;
	}

	/// <summary>
	/// Draw command list<br/>This is the low-level list of polygons that ImGui:: functions are filling. At the end of the frame,<br/>all command lists are passed to your ImGuiIO::RenderDrawListFn function for rendering.<br/>Each dear imgui window contains its own ImDrawList. You can use ImGui::GetWindowDrawList() to<br/>access the current window draw list and draw custom primitives.<br/>You can interleave normal ImGui:: calls and adding primitives to the current draw list.<br/>In single viewport mode, top-left is == GetMainViewport()-&gt;Pos (generally 0,0), bottom-right is == GetMainViewport()-&gt;Pos+Size (generally io.DisplaySize).<br/>You are totally free to apply whatever transformation matrix you want to the data (depending on the use of the transformation you may want to apply it to ClipRect as well!)<br/>Important: Primitives are always added to the list and not culled (culling is done at higher-level by ImGui:: functions), if you use this API a lot consider coarse culling your drawn objects.<br/>
	/// </summary>
	public unsafe partial struct ImDrawListPtr
	{
		public ImDrawList* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawList this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    This is what you have to render<br/>
		/// Draw commands. Typically 1 command = 1 GPU draw call, unless the command is a callback.<br/>
		/// </summary>
		public ref ImVector<ImDrawCmd> CmdBuffer => ref Unsafe.AsRef<ImVector<ImDrawCmd>>(&NativePtr->CmdBuffer);
		/// <summary>
		/// Index buffer. Each command consume ImDrawCmd::ElemCount of those<br/>
		/// </summary>
		public ref ImVector<ushort> IdxBuffer => ref Unsafe.AsRef<ImVector<ushort>>(&NativePtr->IdxBuffer);
		/// <summary>
		/// Vertex buffer.<br/>
		/// </summary>
		public ref ImVector<ImDrawVert> VtxBuffer => ref Unsafe.AsRef<ImVector<ImDrawVert>>(&NativePtr->VtxBuffer);
		/// <summary>
		/// Flags, you may poke into these to adjust anti-aliasing settings per-primitive.<br/>
		/// </summary>
		public ref ImDrawListFlags Flags => ref Unsafe.AsRef<ImDrawListFlags>(&NativePtr->Flags);
		/// <summary>
		///     [Internal, used while building lists]<br/>
		/// [Internal] generally == VtxBuffer.Size unless we are past 64K vertices, in which case this gets reset to 0.<br/>
		/// </summary>
		public ref uint VtxCurrentIdx => ref Unsafe.AsRef<uint>(&NativePtr->VtxCurrentIdx);
		/// <summary>
		/// Pointer to shared draw data (you can use ImGui::GetDrawListSharedData() to get the one from current ImGui context)<br/>
		/// </summary>
		public ref ImDrawListSharedDataPtr Data => ref Unsafe.AsRef<ImDrawListSharedDataPtr>(&NativePtr->Data);
		/// <summary>
		/// [Internal] point within VtxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)<br/>
		/// </summary>
		public ref ImDrawVertPtr VtxWritePtr => ref Unsafe.AsRef<ImDrawVertPtr>(&NativePtr->VtxWritePtr);
		/// <summary>
		/// [Internal] point within IdxBuffer.Data after each add command (to avoid using the ImVector&lt;&gt; operators too much)<br/>
		/// </summary>
		public IntPtr IdxWritePtr { get => (IntPtr)NativePtr->IdxWritePtr; set => NativePtr->IdxWritePtr = (ushort*)value; }
		/// <summary>
		/// [Internal] current path building<br/>
		/// </summary>
		public ref ImVector<Vector2> Path => ref Unsafe.AsRef<ImVector<Vector2>>(&NativePtr->Path);
		/// <summary>
		/// [Internal] template of active commands. Fields should match those of CmdBuffer.back().<br/>
		/// </summary>
		public ref ImDrawCmdHeader CmdHeader => ref Unsafe.AsRef<ImDrawCmdHeader>(&NativePtr->CmdHeader);
		/// <summary>
		/// [Internal] for channels api (note: prefer using your own persistent instance of ImDrawListSplitter!)<br/>
		/// </summary>
		public ref ImDrawListSplitter Splitter => ref Unsafe.AsRef<ImDrawListSplitter>(&NativePtr->Splitter);
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ref ImVector<Vector4> ClipRectStack => ref Unsafe.AsRef<ImVector<Vector4>>(&NativePtr->ClipRectStack);
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ref ImVector<ulong> TextureIdStack => ref Unsafe.AsRef<ImVector<ulong>>(&NativePtr->TextureIdStack);
		/// <summary>
		/// [Internal]<br/>
		/// </summary>
		public ref ImVector<byte> CallbacksDataBuf => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->CallbacksDataBuf);
		/// <summary>
		/// [Internal] anti-alias fringe is scaled by this value, this helps to keep things sharp while zooming at vertex buffer content<br/>
		/// </summary>
		public ref float FringeScale => ref Unsafe.AsRef<float>(&NativePtr->FringeScale);
		/// <summary>
		/// Pointer to owner window's name for debugging<br/>
		/// </summary>
		public IntPtr OwnerName { get => (IntPtr)NativePtr->OwnerName; set => NativePtr->OwnerName = (byte*)value; }
		public ImDrawListPtr(ImDrawList* nativePtr) => NativePtr = nativePtr;
		public ImDrawListPtr(IntPtr nativePtr) => NativePtr = (ImDrawList*)nativePtr;
		public static implicit operator ImDrawListPtr(ImDrawList* ptr) => new ImDrawListPtr(ptr);
		public static implicit operator ImDrawListPtr(IntPtr ptr) => new ImDrawListPtr(ptr);
		public static implicit operator ImDrawList*(ImDrawListPtr nativePtr) => nativePtr.NativePtr;
		public void PathArcToN(Vector2 center, float radius, float aMin, float aMax, int numSegments)
		{
			ImGuiNative.ImDrawListPathArcToN(NativePtr, center, radius, aMin, aMax, numSegments);
		}

		public void PathArcToFastEx(Vector2 center, float radius, int aMinSample, int aMaxSample, int aStep)
		{
			ImGuiNative.ImDrawListPathArcToFastEx(NativePtr, center, radius, aMinSample, aMaxSample, aStep);
		}

		public int CalcCircleAutoSegmentCount(float radius)
		{
			return ImGuiNative.ImDrawListCalcCircleAutoSegmentCount(NativePtr, radius);
		}

		public void SetTextureID(ulong textureId)
		{
			ImGuiNative.ImDrawListSetTextureID(NativePtr, textureId);
		}

		public void OnChangedVtxOffset()
		{
			ImGuiNative.ImDrawListOnChangedVtxOffset(NativePtr);
		}

		public void OnChangedTextureID()
		{
			ImGuiNative.ImDrawListOnChangedTextureID(NativePtr);
		}

		public void OnChangedClipRect()
		{
			ImGuiNative.ImDrawListOnChangedClipRect(NativePtr);
		}

		public void TryMergeDrawCmds()
		{
			ImGuiNative.ImDrawListTryMergeDrawCmds(NativePtr);
		}

		public void PopUnusedDrawCmd()
		{
			ImGuiNative.ImDrawListPopUnusedDrawCmd(NativePtr);
		}

		public void ClearFreeMemory()
		{
			ImGuiNative.ImDrawListClearFreeMemory(NativePtr);
		}

		public void ResetForNewFrame()
		{
			ImGuiNative.ImDrawListResetForNewFrame(NativePtr);
		}

		/// <summary>
		/// Write vertex with unique index<br/>
		/// </summary>
		public void PrimVtx(Vector2 pos, Vector2 uv, uint col)
		{
			ImGuiNative.ImDrawListPrimVtx(NativePtr, pos, uv, col);
		}

		public void PrimWriteIdx(ushort idx)
		{
			ImGuiNative.ImDrawListPrimWriteIdx(NativePtr, idx);
		}

		public void PrimWriteVtx(Vector2 pos, Vector2 uv, uint col)
		{
			ImGuiNative.ImDrawListPrimWriteVtx(NativePtr, pos, uv, col);
		}

		public void PrimQuadUV(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uvA, Vector2 uvB, Vector2 uvC, Vector2 uvD, uint col)
		{
			ImGuiNative.ImDrawListPrimQuadUV(NativePtr, a, b, c, d, uvA, uvB, uvC, uvD, col);
		}

		public void PrimRectUV(Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, uint col)
		{
			ImGuiNative.ImDrawListPrimRectUV(NativePtr, a, b, uvA, uvB, col);
		}

		/// <summary>
		/// Axis aligned rectangle (composed of two triangles)<br/>
		/// </summary>
		public void PrimRect(Vector2 a, Vector2 b, uint col)
		{
			ImGuiNative.ImDrawListPrimRect(NativePtr, a, b, col);
		}

		public void PrimUnreserve(int idxCount, int vtxCount)
		{
			ImGuiNative.ImDrawListPrimUnreserve(NativePtr, idxCount, vtxCount);
		}

		public void PrimReserve(int idxCount, int vtxCount)
		{
			ImGuiNative.ImDrawListPrimReserve(NativePtr, idxCount, vtxCount);
		}

		public void ChannelsSetCurrent(int n)
		{
			ImGuiNative.ImDrawListChannelsSetCurrent(NativePtr, n);
		}

		public void ChannelsMerge()
		{
			ImGuiNative.ImDrawListChannelsMerge(NativePtr);
		}

		public void ChannelsSplit(int count)
		{
			ImGuiNative.ImDrawListChannelsSplit(NativePtr, count);
		}

		/// <summary>
		/// Create a clone of the CmdBuffer/IdxBuffer/VtxBuffer.<br/>
		/// </summary>
		public ImDrawListPtr CloneOutput()
		{
			return ImGuiNative.ImDrawListCloneOutput(NativePtr);
		}

		/// <summary>
		/// This is useful if you need to forcefully create a new draw call (to allow for dependent rendering / blending). Otherwise primitives are merged into the same draw-call as much as possible<br/>
		/// </summary>
		public void AddDrawCmd()
		{
			ImGuiNative.ImDrawListAddDrawCmd(NativePtr);
		}

		public void AddCallback(ImDrawCallback callback, IntPtr userdata, uint userdataSize)
		{
			ImGuiNative.ImDrawListAddCallback(NativePtr, callback, (void*)userdata, userdataSize);
		}

		public void AddCallback(ImDrawCallback callback, IntPtr userdata)
		{
			// defining omitted parameters
			uint userdataSize = 0;
			ImGuiNative.ImDrawListAddCallback(NativePtr, callback, (void*)userdata, userdataSize);
		}

		public void PathRect(Vector2 rectMin, Vector2 rectMax, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.ImDrawListPathRect(NativePtr, rectMin, rectMax, rounding, flags);
		}

		public void PathRect(Vector2 rectMin, Vector2 rectMax, float rounding)
		{
			// defining omitted parameters
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListPathRect(NativePtr, rectMin, rectMax, rounding, flags);
		}

		public void PathRect(Vector2 rectMin, Vector2 rectMax)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListPathRect(NativePtr, rectMin, rectMax, rounding, flags);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3, int numSegments)
		{
			ImGuiNative.ImDrawListPathBezierQuadraticCurveTo(NativePtr, p2, p3, numSegments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public void PathBezierQuadraticCurveTo(Vector2 p2, Vector2 p3)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListPathBezierQuadraticCurveTo(NativePtr, p2, p3, numSegments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4, int numSegments)
		{
			ImGuiNative.ImDrawListPathBezierCubicCurveTo(NativePtr, p2, p3, p4, numSegments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public void PathBezierCubicCurveTo(Vector2 p2, Vector2 p3, Vector2 p4)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListPathBezierCubicCurveTo(NativePtr, p2, p3, p4, numSegments);
		}

		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		public void PathEllipticalArcTo(Vector2 center, Vector2 radius, float rot, float aMin, float aMax, int numSegments)
		{
			ImGuiNative.ImDrawListPathEllipticalArcTo(NativePtr, center, radius, rot, aMin, aMax, numSegments);
		}

		/// <summary>
		/// Ellipse<br/>
		/// </summary>
		public void PathEllipticalArcTo(Vector2 center, Vector2 radius, float rot, float aMin, float aMax)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListPathEllipticalArcTo(NativePtr, center, radius, rot, aMin, aMax, numSegments);
		}

		/// <summary>
		/// Use precomputed angles for a 12 steps circle<br/>
		/// </summary>
		public void PathArcToFast(Vector2 center, float radius, int aMinOf_12, int aMaxOf_12)
		{
			ImGuiNative.ImDrawListPathArcToFast(NativePtr, center, radius, aMinOf_12, aMaxOf_12);
		}

		public void PathArcTo(Vector2 center, float radius, float aMin, float aMax, int numSegments)
		{
			ImGuiNative.ImDrawListPathArcTo(NativePtr, center, radius, aMin, aMax, numSegments);
		}

		public void PathArcTo(Vector2 center, float radius, float aMin, float aMax)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListPathArcTo(NativePtr, center, radius, aMin, aMax, numSegments);
		}

		public void PathStroke(uint col, ImDrawFlags flags, float thickness)
		{
			ImGuiNative.ImDrawListPathStroke(NativePtr, col, flags, thickness);
		}

		public void PathStroke(uint col, ImDrawFlags flags)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListPathStroke(NativePtr, col, flags, thickness);
		}

		public void PathStroke(uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListPathStroke(NativePtr, col, flags, thickness);
		}

		public void PathFillConcave(uint col)
		{
			ImGuiNative.ImDrawListPathFillConcave(NativePtr, col);
		}

		public void PathFillConvex(uint col)
		{
			ImGuiNative.ImDrawListPathFillConvex(NativePtr, col);
		}

		public void PathLineToMergeDuplicate(Vector2 pos)
		{
			ImGuiNative.ImDrawListPathLineToMergeDuplicate(NativePtr, pos);
		}

		public void PathLineTo(Vector2 pos)
		{
			ImGuiNative.ImDrawListPathLineTo(NativePtr, pos);
		}

		public void PathClear()
		{
			ImGuiNative.ImDrawListPathClear(NativePtr);
		}

		public void AddImageRounded(ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.ImDrawListAddImageRounded(NativePtr, userTextureId, pMin, pMax, uvMin, uvMax, col, rounding, flags);
		}

		public void AddImageRounded(ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col, float rounding)
		{
			// defining omitted parameters
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListAddImageRounded(NativePtr, userTextureId, pMin, pMax, uvMin, uvMax, col, rounding, flags);
		}

		public void AddImageQuad(ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col)
		{
			ImGuiNative.ImDrawListAddImageQuad(NativePtr, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageQuad(ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4)
		{
			// defining omitted parameters
			uint col = 4294967295;
			ImGuiNative.ImDrawListAddImageQuad(NativePtr, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageQuad(ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3)
		{
			// defining omitted parameters
			uint col = 4294967295;
			Vector2 uv4 = new Vector2(0,1);
			ImGuiNative.ImDrawListAddImageQuad(NativePtr, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageQuad(ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2)
		{
			// defining omitted parameters
			uint col = 4294967295;
			Vector2 uv4 = new Vector2(0,1);
			Vector2 uv3 = new Vector2(1,1);
			ImGuiNative.ImDrawListAddImageQuad(NativePtr, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageQuad(ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1)
		{
			// defining omitted parameters
			uint col = 4294967295;
			Vector2 uv4 = new Vector2(0,1);
			Vector2 uv3 = new Vector2(1,1);
			Vector2 uv2 = new Vector2(1,0);
			ImGuiNative.ImDrawListAddImageQuad(NativePtr, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImageQuad(ulong userTextureId, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4)
		{
			// defining omitted parameters
			uint col = 4294967295;
			Vector2 uv4 = new Vector2(0,1);
			Vector2 uv3 = new Vector2(1,1);
			Vector2 uv2 = new Vector2(1,0);
			Vector2 uv1 = new Vector2(0,0);
			ImGuiNative.ImDrawListAddImageQuad(NativePtr, userTextureId, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col);
		}

		public void AddImage(ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax, uint col)
		{
			ImGuiNative.ImDrawListAddImage(NativePtr, userTextureId, pMin, pMax, uvMin, uvMax, col);
		}

		public void AddImage(ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin, Vector2 uvMax)
		{
			// defining omitted parameters
			uint col = 4294967295;
			ImGuiNative.ImDrawListAddImage(NativePtr, userTextureId, pMin, pMax, uvMin, uvMax, col);
		}

		public void AddImage(ulong userTextureId, Vector2 pMin, Vector2 pMax, Vector2 uvMin)
		{
			// defining omitted parameters
			uint col = 4294967295;
			Vector2 uvMax = new Vector2(1,1);
			ImGuiNative.ImDrawListAddImage(NativePtr, userTextureId, pMin, pMax, uvMin, uvMax, col);
		}

		public void AddImage(ulong userTextureId, Vector2 pMin, Vector2 pMax)
		{
			// defining omitted parameters
			uint col = 4294967295;
			Vector2 uvMax = new Vector2(1,1);
			Vector2 uvMin = new Vector2(0,0);
			ImGuiNative.ImDrawListAddImage(NativePtr, userTextureId, pMin, pMax, uvMin, uvMax, col);
		}

		public void AddConcavePolyFilled(Vector2[] points, int numPoints, uint col)
		{
			fixed (Vector2* nativePoints = points)
			{
				ImGuiNative.ImDrawListAddConcavePolyFilled(NativePtr, nativePoints, numPoints, col);
			}
		}

		public void AddConvexPolyFilled(Vector2[] points, int numPoints, uint col)
		{
			fixed (Vector2* nativePoints = points)
			{
				ImGuiNative.ImDrawListAddConvexPolyFilled(NativePtr, nativePoints, numPoints, col);
			}
		}

		public void AddPolyline(Vector2[] points, int numPoints, uint col, ImDrawFlags flags, float thickness)
		{
			fixed (Vector2* nativePoints = points)
			{
				ImGuiNative.ImDrawListAddPolyline(NativePtr, nativePoints, numPoints, col, flags, thickness);
			}
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int numSegments)
		{
			ImGuiNative.ImDrawListAddBezierQuadratic(NativePtr, p1, p2, p3, col, thickness, numSegments);
		}

		/// <summary>
		/// Quadratic Bezier (3 control points)<br/>
		/// </summary>
		public void AddBezierQuadratic(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListAddBezierQuadratic(NativePtr, p1, p2, p3, col, thickness, numSegments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int numSegments)
		{
			ImGuiNative.ImDrawListAddBezierCubic(NativePtr, p1, p2, p3, p4, col, thickness, numSegments);
		}

		/// <summary>
		/// Cubic Bezier (4 control points)<br/>
		/// </summary>
		public void AddBezierCubic(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListAddBezierCubic(NativePtr, p1, p2, p3, p4, col, thickness, numSegments);
		}

		public void AddText(ImFontPtr font, float fontSize, Vector2 pos, uint col, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd, float wrapWidth, Vector4[] cpuFineClipRect)
		{
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector4* nativeCpuFineClipRect = cpuFineClipRect)
			{
				ImGuiNative.ImDrawListAddText(NativePtr, font, fontSize, pos, col, nativeTextBegin, nativeTextEnd, wrapWidth, nativeCpuFineClipRect);
			}
		}

		public void AddText(ImFontPtr font, float fontSize, Vector2 pos, uint col, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd, float wrapWidth, Vector4[] cpuFineClipRect)
		{
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			fixed (Vector4* nativeCpuFineClipRect = cpuFineClipRect)
			{
				ImGuiNative.ImDrawListAddText(NativePtr, font, fontSize, pos, col, nativeTextBegin, nativeTextEnd, wrapWidth, nativeCpuFineClipRect);
				// Freeing textBegin native string
				if (byteCountTextBegin > Utils.MaxStackallocSize)
					Utils.Free(nativeTextBegin);
				// Freeing textEnd native string
				if (byteCountTextEnd > Utils.MaxStackallocSize)
					Utils.Free(nativeTextEnd);
			}
		}

		public void AddText(Vector2 pos, uint col, ReadOnlySpan<byte> textBegin, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeTextBegin = textBegin)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImDrawListAddText(NativePtr, pos, col, nativeTextBegin, nativeTextEnd);
			}
		}

		public void AddText(Vector2 pos, uint col, ReadOnlySpan<char> textBegin, ReadOnlySpan<char> textEnd)
		{
			// Marshaling textBegin to native string
			byte* nativeTextBegin;
			var byteCountTextBegin = 0;
			if (textBegin != null && !textBegin.IsEmpty)
			{
				byteCountTextBegin = Encoding.UTF8.GetByteCount(textBegin);
				if(byteCountTextBegin > Utils.MaxStackallocSize)
				{
					nativeTextBegin = Utils.Alloc<byte>(byteCountTextBegin + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextBegin + 1];
					nativeTextBegin = stackallocBytes;
				}
				var offsetTextBegin = Utils.EncodeStringUTF8(textBegin, nativeTextBegin, byteCountTextBegin);
				nativeTextBegin[offsetTextBegin] = 0;
			}
			else nativeTextBegin = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.ImDrawListAddText(NativePtr, pos, col, nativeTextBegin, nativeTextEnd);
			// Freeing textBegin native string
			if (byteCountTextBegin > Utils.MaxStackallocSize)
				Utils.Free(nativeTextBegin);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public void AddEllipseFilled(Vector2 center, Vector2 radius, uint col, float rot, int numSegments)
		{
			ImGuiNative.ImDrawListAddEllipseFilled(NativePtr, center, radius, col, rot, numSegments);
		}

		public void AddEllipseFilled(Vector2 center, Vector2 radius, uint col, float rot)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListAddEllipseFilled(NativePtr, center, radius, col, rot, numSegments);
		}

		public void AddEllipseFilled(Vector2 center, Vector2 radius, uint col)
		{
			// defining omitted parameters
			int numSegments = 0;
			float rot = 0.0f;
			ImGuiNative.ImDrawListAddEllipseFilled(NativePtr, center, radius, col, rot, numSegments);
		}

		public void AddEllipse(Vector2 center, Vector2 radius, uint col, float rot, int numSegments, float thickness)
		{
			ImGuiNative.ImDrawListAddEllipse(NativePtr, center, radius, col, rot, numSegments, thickness);
		}

		public void AddEllipse(Vector2 center, Vector2 radius, uint col, float rot, int numSegments)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddEllipse(NativePtr, center, radius, col, rot, numSegments, thickness);
		}

		public void AddEllipse(Vector2 center, Vector2 radius, uint col, float rot)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			int numSegments = 0;
			ImGuiNative.ImDrawListAddEllipse(NativePtr, center, radius, col, rot, numSegments, thickness);
		}

		public void AddEllipse(Vector2 center, Vector2 radius, uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			int numSegments = 0;
			float rot = 0.0f;
			ImGuiNative.ImDrawListAddEllipse(NativePtr, center, radius, col, rot, numSegments, thickness);
		}

		public void AddNgonFilled(Vector2 center, float radius, uint col, int numSegments)
		{
			ImGuiNative.ImDrawListAddNgonFilled(NativePtr, center, radius, col, numSegments);
		}

		public void AddNgon(Vector2 center, float radius, uint col, int numSegments, float thickness)
		{
			ImGuiNative.ImDrawListAddNgon(NativePtr, center, radius, col, numSegments, thickness);
		}

		public void AddNgon(Vector2 center, float radius, uint col, int numSegments)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddNgon(NativePtr, center, radius, col, numSegments, thickness);
		}

		public void AddCircleFilled(Vector2 center, float radius, uint col, int numSegments)
		{
			ImGuiNative.ImDrawListAddCircleFilled(NativePtr, center, radius, col, numSegments);
		}

		public void AddCircleFilled(Vector2 center, float radius, uint col)
		{
			// defining omitted parameters
			int numSegments = 0;
			ImGuiNative.ImDrawListAddCircleFilled(NativePtr, center, radius, col, numSegments);
		}

		public void AddCircle(Vector2 center, float radius, uint col, int numSegments, float thickness)
		{
			ImGuiNative.ImDrawListAddCircle(NativePtr, center, radius, col, numSegments, thickness);
		}

		public void AddCircle(Vector2 center, float radius, uint col, int numSegments)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddCircle(NativePtr, center, radius, col, numSegments, thickness);
		}

		public void AddCircle(Vector2 center, float radius, uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			int numSegments = 0;
			ImGuiNative.ImDrawListAddCircle(NativePtr, center, radius, col, numSegments, thickness);
		}

		public void AddTriangleFilled(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			ImGuiNative.ImDrawListAddTriangleFilled(NativePtr, p1, p2, p3, col);
		}

		public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness)
		{
			ImGuiNative.ImDrawListAddTriangle(NativePtr, p1, p2, p3, col, thickness);
		}

		public void AddTriangle(Vector2 p1, Vector2 p2, Vector2 p3, uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddTriangle(NativePtr, p1, p2, p3, col, thickness);
		}

		public void AddQuadFilled(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			ImGuiNative.ImDrawListAddQuadFilled(NativePtr, p1, p2, p3, p4, col);
		}

		public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness)
		{
			ImGuiNative.ImDrawListAddQuad(NativePtr, p1, p2, p3, p4, col, thickness);
		}

		public void AddQuad(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddQuad(NativePtr, p1, p2, p3, p4, col, thickness);
		}

		public void AddRectFilledMultiColor(Vector2 pMin, Vector2 pMax, uint colUprLeft, uint colUprRight, uint colBotRight, uint colBotLeft)
		{
			ImGuiNative.ImDrawListAddRectFilledMultiColor(NativePtr, pMin, pMax, colUprLeft, colUprRight, colBotRight, colBotLeft);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRectFilled(Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.ImDrawListAddRectFilled(NativePtr, pMin, pMax, col, rounding, flags);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRectFilled(Vector2 pMin, Vector2 pMax, uint col, float rounding)
		{
			// defining omitted parameters
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListAddRectFilled(NativePtr, pMin, pMax, col, rounding, flags);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRectFilled(Vector2 pMin, Vector2 pMax, uint col)
		{
			// defining omitted parameters
			float rounding = 0.0f;
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListAddRectFilled(NativePtr, pMin, pMax, col, rounding, flags);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRect(Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags, float thickness)
		{
			ImGuiNative.ImDrawListAddRect(NativePtr, pMin, pMax, col, rounding, flags, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRect(Vector2 pMin, Vector2 pMax, uint col, float rounding, ImDrawFlags flags)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddRect(NativePtr, pMin, pMax, col, rounding, flags, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRect(Vector2 pMin, Vector2 pMax, uint col, float rounding)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListAddRect(NativePtr, pMin, pMax, col, rounding, flags, thickness);
		}

		/// <summary>
		/// a: upper-left, b: lower-right (== upper-left + size)<br/>
		/// </summary>
		public void AddRect(Vector2 pMin, Vector2 pMax, uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			float rounding = 0.0f;
			ImDrawFlags flags = ImDrawFlags.None;
			ImGuiNative.ImDrawListAddRect(NativePtr, pMin, pMax, col, rounding, flags, thickness);
		}

		public void AddLine(Vector2 p1, Vector2 p2, uint col, float thickness)
		{
			ImGuiNative.ImDrawListAddLine(NativePtr, p1, p2, col, thickness);
		}

		public void AddLine(Vector2 p1, Vector2 p2, uint col)
		{
			// defining omitted parameters
			float thickness = 1.0f;
			ImGuiNative.ImDrawListAddLine(NativePtr, p1, p2, col, thickness);
		}

		public void GetClipRectMax(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImDrawListGetClipRectMax(nativePOut, NativePtr);
			}
		}

		public void GetClipRectMin(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImDrawListGetClipRectMin(nativePOut, NativePtr);
			}
		}

		public void PopTextureID()
		{
			ImGuiNative.ImDrawListPopTextureID(NativePtr);
		}

		public void PushTextureID(ulong textureId)
		{
			ImGuiNative.ImDrawListPushTextureID(NativePtr, textureId);
		}

		public void PopClipRect()
		{
			ImGuiNative.ImDrawListPopClipRect(NativePtr);
		}

		public void PushClipRectFullScreen()
		{
			ImGuiNative.ImDrawListPushClipRectFullScreen(NativePtr);
		}

		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		public void PushClipRect(Vector2 clipRectMin, Vector2 clipRectMax, bool intersectWithCurrentClipRect)
		{
			var native_intersectWithCurrentClipRect = intersectWithCurrentClipRect ? (byte)1 : (byte)0;
			ImGuiNative.ImDrawListPushClipRect(NativePtr, clipRectMin, clipRectMax, native_intersectWithCurrentClipRect);
		}

		/// <summary>
		/// Render-level scissoring. This is passed down to your render function but not used for CPU-side coarse clipping. Prefer using higher-level ImGui::PushClipRect() to affect logic (hit-testing and widget culling)<br/>
		/// </summary>
		public void PushClipRect(Vector2 clipRectMin, Vector2 clipRectMax)
		{
			// defining omitted parameters
			byte intersectWithCurrentClipRect = 0;
			ImGuiNative.ImDrawListPushClipRect(NativePtr, clipRectMin, clipRectMax, intersectWithCurrentClipRect);
		}

		public void Destroy()
		{
			ImGuiNative.ImDrawListDestroy(NativePtr);
		}

		public void ImDrawListConstruct(ImDrawListSharedDataPtr sharedData)
		{
			ImGuiNative.ImDrawListImDrawListConstruct(NativePtr, sharedData);
		}

		public ImDrawListPtr ImDrawList(ImDrawListSharedDataPtr sharedData)
		{
			return ImGuiNative.ImDrawListImDrawList(sharedData);
		}

	}
}
