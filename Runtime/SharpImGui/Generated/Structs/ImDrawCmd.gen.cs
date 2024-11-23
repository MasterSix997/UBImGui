using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Typically, 1 command = 1 GPU draw call (unless command is a callback)</para>
	/// <para>- VtxOffset: When 'io.BackendFlags &amp; ImGuiBackendFlags_RendererHasVtxOffset' is enabled,</para>
	/// <para>  this fields allow us to render meshes larger than 64K vertices while keeping 16-bit indices.</para>
	/// <para>  Backends made for &lt;1.71. will typically ignore the VtxOffset fields.</para>
	/// <para>- The ClipRect/TextureId/VtxOffset fields must be contiguous as we memcmp() them together (this is asserted for).</para>
	/// </summary>
	public unsafe partial struct ImDrawCmd
	{
		/// <summary>
		/// 4*4  // Clipping rectangle (x1, y1, x2, y2). Subtract ImDrawData-&gt;DisplayPos to get clipping rectangle in "viewport" coordinates
		/// </summary>
		public Vector4 ClipRect;
		/// <summary>
		/// 4-8  // User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions. Ignore if never using images or multiple fonts atlas.
		/// </summary>
		public IntPtr TextureId;
		/// <summary>
		/// 4    // Start offset in vertex buffer. ImGuiBackendFlags_RendererHasVtxOffset: always 0, otherwise may be &gt;0 to support meshes larger than 64K vertices with 16-bit indices.
		/// </summary>
		public uint VtxOffset;
		/// <summary>
		/// 4    // Start offset in index buffer.
		/// </summary>
		public uint IdxOffset;
		/// <summary>
		/// 4    // Number of indices (multiple of 3) to be rendered as triangles. Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].
		/// </summary>
		public uint ElemCount;
		/// <summary>
		/// 4-8  // If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.
		/// </summary>
		public IntPtr UserCallback;
		/// <summary>
		/// 4-8  // Callback user data (when UserCallback != NULL). If called AddCallback() with size == 0, this is a copy of the AddCallback() argument. If called AddCallback() with size &gt; 0, this is pointing to a buffer where data is stored.
		/// </summary>
		public void* UserCallbackData;
		/// <summary>
		/// 4 // Size of callback user data when using storage, otherwise 0.
		/// </summary>
		public int UserCallbackDataSize;
		/// <summary>
		/// 4 // [Internal] Offset of callback user data when using storage, otherwise -1.
		/// </summary>
		public int UserCallbackDataOffset;
	}

	/// <summary>
	/// <para>Typically, 1 command = 1 GPU draw call (unless command is a callback)</para>
	/// <para>- VtxOffset: When 'io.BackendFlags &amp; ImGuiBackendFlags_RendererHasVtxOffset' is enabled,</para>
	/// <para>  this fields allow us to render meshes larger than 64K vertices while keeping 16-bit indices.</para>
	/// <para>  Backends made for &lt;1.71. will typically ignore the VtxOffset fields.</para>
	/// <para>- The ClipRect/TextureId/VtxOffset fields must be contiguous as we memcmp() them together (this is asserted for).</para>
	/// </summary>
	public unsafe partial struct ImDrawCmdPtr
	{
		public ImDrawCmd* NativePtr { get; }
		public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
		public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
		public static implicit operator ImDrawCmdPtr(ImDrawCmd* nativePtr) => new ImDrawCmdPtr(nativePtr);
		public static implicit operator ImDrawCmd* (ImDrawCmdPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawCmdPtr(IntPtr nativePtr) => new ImDrawCmdPtr(nativePtr);

		/// <summary>
		/// 4*4  // Clipping rectangle (x1, y1, x2, y2). Subtract ImDrawData-&gt;DisplayPos to get clipping rectangle in "viewport" coordinates
		/// </summary>
		public ref Vector4 ClipRect => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRect);

		/// <summary>
		/// 4-8  // User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions. Ignore if never using images or multiple fonts atlas.
		/// </summary>
		public ref IntPtr TextureId => ref Unsafe.AsRef<IntPtr>(&NativePtr->TextureId);

		/// <summary>
		/// 4    // Start offset in vertex buffer. ImGuiBackendFlags_RendererHasVtxOffset: always 0, otherwise may be &gt;0 to support meshes larger than 64K vertices with 16-bit indices.
		/// </summary>
		public ref uint VtxOffset => ref Unsafe.AsRef<uint>(&NativePtr->VtxOffset);

		/// <summary>
		/// 4    // Start offset in index buffer.
		/// </summary>
		public ref uint IdxOffset => ref Unsafe.AsRef<uint>(&NativePtr->IdxOffset);

		/// <summary>
		/// 4    // Number of indices (multiple of 3) to be rendered as triangles. Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].
		/// </summary>
		public ref uint ElemCount => ref Unsafe.AsRef<uint>(&NativePtr->ElemCount);

		/// <summary>
		/// 4-8  // If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.
		/// </summary>
		public ref IntPtr UserCallback => ref Unsafe.AsRef<IntPtr>(&NativePtr->UserCallback);

		/// <summary>
		/// 4-8  // Callback user data (when UserCallback != NULL). If called AddCallback() with size == 0, this is a copy of the AddCallback() argument. If called AddCallback() with size &gt; 0, this is pointing to a buffer where data is stored.
		/// </summary>
		public IntPtr UserCallbackData { get => (IntPtr)NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = (void*)value; }

		/// <summary>
		/// 4 // Size of callback user data when using storage, otherwise 0.
		/// </summary>
		public ref int UserCallbackDataSize => ref Unsafe.AsRef<int>(&NativePtr->UserCallbackDataSize);

		/// <summary>
		/// 4 // [Internal] Offset of callback user data when using storage, otherwise -1.
		/// </summary>
		public ref int UserCallbackDataOffset => ref Unsafe.AsRef<int>(&NativePtr->UserCallbackDataOffset);

		/// <summary>
		/// <para>Since 1.83: returns ImTextureID associated with this draw call. Warning: DO NOT assume this is always same as 'TextureId' (we will change this function for an upcoming feature)</para>
		/// </summary>
		public IntPtr GetTexID()
		{
			var ret = ImGuiNative.ImDrawCmd_GetTexID(NativePtr);
			return ret;
		}
	}
}
