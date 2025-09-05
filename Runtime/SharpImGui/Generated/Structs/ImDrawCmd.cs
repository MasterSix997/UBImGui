using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Typically, 1 command = 1 GPU draw call (unless command is a callback)<br/>- VtxOffset: When 'io.BackendFlags & ImGuiBackendFlags_RendererHasVtxOffset' is enabled,<br/>  this fields allow us to render meshes larger than 64K vertices while keeping 16-bit indices.<br/>  Backends made for &lt;1.71. will typically ignore the VtxOffset fields.<br/>- The ClipRect/TextureId/VtxOffset fields must be contiguous as we memcmp() them together (this is asserted for).<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawCmd
	{
		/// <summary>
		/// 4*4  Clipping rectangle (x1, y1, x2, y2). Subtract ImDrawData-&gt;DisplayPos to get clipping rectangle in "viewport" coordinates<br/>
		/// </summary>
		public Vector4 ClipRect;
		/// <summary>
		/// 4-8  User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions. Ignore if never using images or multiple fonts atlas.<br/>
		/// </summary>
		public ulong TextureId;
		/// <summary>
		/// 4    Start offset in vertex buffer. ImGuiBackendFlags_RendererHasVtxOffset: always 0, otherwise may be &gt;0 to support meshes larger than 64K vertices with 16-bit indices.<br/>
		/// </summary>
		public uint VtxOffset;
		/// <summary>
		/// 4    Start offset in index buffer.<br/>
		/// </summary>
		public uint IdxOffset;
		/// <summary>
		/// 4    Number of indices (multiple of 3) to be rendered as triangles. Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].<br/>
		/// </summary>
		public uint ElemCount;
		/// <summary>
		/// 4-8  If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.<br/>
		/// </summary>
		public unsafe void* UserCallback;
		/// <summary>
		/// 4-8  Callback user data (when UserCallback != NULL). If called AddCallback() with size == 0, this is a copy of the AddCallback() argument. If called AddCallback() with size &gt; 0, this is pointing to a buffer where data is stored.<br/>
		/// </summary>
		public unsafe void* UserCallbackData;
		/// <summary>
		/// 4 Size of callback user data when using storage, otherwise 0.<br/>
		/// </summary>
		public int UserCallbackDataSize;
		/// <summary>
		/// 4 [Internal] Offset of callback user data when using storage, otherwise -1.<br/>
		/// </summary>
		public int UserCallbackDataOffset;
	}

	/// <summary>
	/// Typically, 1 command = 1 GPU draw call (unless command is a callback)<br/>- VtxOffset: When 'io.BackendFlags & ImGuiBackendFlags_RendererHasVtxOffset' is enabled,<br/>  this fields allow us to render meshes larger than 64K vertices while keeping 16-bit indices.<br/>  Backends made for &lt;1.71. will typically ignore the VtxOffset fields.<br/>- The ClipRect/TextureId/VtxOffset fields must be contiguous as we memcmp() them together (this is asserted for).<br/>
	/// </summary>
	public unsafe partial struct ImDrawCmdPtr
	{
		public ImDrawCmd* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawCmd this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// 4*4  Clipping rectangle (x1, y1, x2, y2). Subtract ImDrawData-&gt;DisplayPos to get clipping rectangle in "viewport" coordinates<br/>
		/// </summary>
		public ref Vector4 ClipRect => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRect);
		/// <summary>
		/// 4-8  User-provided texture ID. Set by user in ImfontAtlas::SetTexID() for fonts or passed to Image*() functions. Ignore if never using images or multiple fonts atlas.<br/>
		/// </summary>
		public ref ulong TextureId => ref Unsafe.AsRef<ulong>(&NativePtr->TextureId);
		/// <summary>
		/// 4    Start offset in vertex buffer. ImGuiBackendFlags_RendererHasVtxOffset: always 0, otherwise may be &gt;0 to support meshes larger than 64K vertices with 16-bit indices.<br/>
		/// </summary>
		public ref uint VtxOffset => ref Unsafe.AsRef<uint>(&NativePtr->VtxOffset);
		/// <summary>
		/// 4    Start offset in index buffer.<br/>
		/// </summary>
		public ref uint IdxOffset => ref Unsafe.AsRef<uint>(&NativePtr->IdxOffset);
		/// <summary>
		/// 4    Number of indices (multiple of 3) to be rendered as triangles. Vertices are stored in the callee ImDrawList's vtx_buffer[] array, indices in idx_buffer[].<br/>
		/// </summary>
		public ref uint ElemCount => ref Unsafe.AsRef<uint>(&NativePtr->ElemCount);
		/// <summary>
		/// 4-8  If != NULL, call the function instead of rendering the vertices. clip_rect and texture_id will be set normally.<br/>
		/// </summary>
		public IntPtr UserCallback { get => (IntPtr)NativePtr->UserCallback; set => NativePtr->UserCallback = (void*)value; }
		/// <summary>
		/// 4-8  Callback user data (when UserCallback != NULL). If called AddCallback() with size == 0, this is a copy of the AddCallback() argument. If called AddCallback() with size &gt; 0, this is pointing to a buffer where data is stored.<br/>
		/// </summary>
		public IntPtr UserCallbackData { get => (IntPtr)NativePtr->UserCallbackData; set => NativePtr->UserCallbackData = (void*)value; }
		/// <summary>
		/// 4 Size of callback user data when using storage, otherwise 0.<br/>
		/// </summary>
		public ref int UserCallbackDataSize => ref Unsafe.AsRef<int>(&NativePtr->UserCallbackDataSize);
		/// <summary>
		/// 4 [Internal] Offset of callback user data when using storage, otherwise -1.<br/>
		/// </summary>
		public ref int UserCallbackDataOffset => ref Unsafe.AsRef<int>(&NativePtr->UserCallbackDataOffset);
		public ImDrawCmdPtr(ImDrawCmd* nativePtr) => NativePtr = nativePtr;
		public ImDrawCmdPtr(IntPtr nativePtr) => NativePtr = (ImDrawCmd*)nativePtr;
		public static implicit operator ImDrawCmdPtr(ImDrawCmd* ptr) => new ImDrawCmdPtr(ptr);
		public static implicit operator ImDrawCmdPtr(IntPtr ptr) => new ImDrawCmdPtr(ptr);
		public static implicit operator ImDrawCmd*(ImDrawCmdPtr nativePtr) => nativePtr.NativePtr;
		public ulong GetTexID()
		{
			return ImGuiNative.ImDrawCmdGetTexID(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImDrawCmdDestroy(NativePtr);
		}

		public void ImDrawCmdConstruct()
		{
			ImGuiNative.ImDrawCmdImDrawCmdConstruct(NativePtr);
		}

		/// <summary>
		/// Also ensure our padding fields are zeroed<br/>
		/// </summary>
		public ImDrawCmdPtr ImDrawCmd()
		{
			return ImGuiNative.ImDrawCmdImDrawCmd();
		}

	}
}
