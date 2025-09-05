using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Per-instance data that needs preserving across frames (seemingly most others do not need to be preserved aside from debug needs. Does that means they could be moved to ImGuiTableTempData?)<br/>sizeof() ~ 24 bytes<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableInstanceData
	{
		public uint TableInstanceID;
		/// <summary>
		/// Outer height from last frame<br/>
		/// </summary>
		public float LastOuterHeight;
		/// <summary>
		/// Height of first consecutive header rows from last frame (FIXME: this is used assuming consecutive headers are in same frozen set)<br/>
		/// </summary>
		public float LastTopHeadersRowHeight;
		/// <summary>
		/// Height of frozen section from last frame<br/>
		/// </summary>
		public float LastFrozenHeight;
		/// <summary>
		/// Index of row which was hovered last frame.<br/>
		/// </summary>
		public int HoveredRowLast;
		/// <summary>
		/// Index of row hovered this frame, set after encountering it.<br/>
		/// </summary>
		public int HoveredRowNext;
	}

	/// <summary>
	/// Per-instance data that needs preserving across frames (seemingly most others do not need to be preserved aside from debug needs. Does that means they could be moved to ImGuiTableTempData?)<br/>sizeof() ~ 24 bytes<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableInstanceDataPtr
	{
		public ImGuiTableInstanceData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableInstanceData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint TableInstanceID => ref Unsafe.AsRef<uint>(&NativePtr->TableInstanceID);
		/// <summary>
		/// Outer height from last frame<br/>
		/// </summary>
		public ref float LastOuterHeight => ref Unsafe.AsRef<float>(&NativePtr->LastOuterHeight);
		/// <summary>
		/// Height of first consecutive header rows from last frame (FIXME: this is used assuming consecutive headers are in same frozen set)<br/>
		/// </summary>
		public ref float LastTopHeadersRowHeight => ref Unsafe.AsRef<float>(&NativePtr->LastTopHeadersRowHeight);
		/// <summary>
		/// Height of frozen section from last frame<br/>
		/// </summary>
		public ref float LastFrozenHeight => ref Unsafe.AsRef<float>(&NativePtr->LastFrozenHeight);
		/// <summary>
		/// Index of row which was hovered last frame.<br/>
		/// </summary>
		public ref int HoveredRowLast => ref Unsafe.AsRef<int>(&NativePtr->HoveredRowLast);
		/// <summary>
		/// Index of row hovered this frame, set after encountering it.<br/>
		/// </summary>
		public ref int HoveredRowNext => ref Unsafe.AsRef<int>(&NativePtr->HoveredRowNext);
		public ImGuiTableInstanceDataPtr(ImGuiTableInstanceData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableInstanceDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableInstanceData*)nativePtr;
		public static implicit operator ImGuiTableInstanceDataPtr(ImGuiTableInstanceData* ptr) => new ImGuiTableInstanceDataPtr(ptr);
		public static implicit operator ImGuiTableInstanceDataPtr(IntPtr ptr) => new ImGuiTableInstanceDataPtr(ptr);
		public static implicit operator ImGuiTableInstanceData*(ImGuiTableInstanceDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTableInstanceDataDestroy(NativePtr);
		}

		public void ImGuiTableInstanceDataConstruct()
		{
			ImGuiNative.ImGuiTableInstanceDataImGuiTableInstanceDataConstruct(NativePtr);
		}

		public ImGuiTableInstanceDataPtr ImGuiTableInstanceData()
		{
			return ImGuiNative.ImGuiTableInstanceDataImGuiTableInstanceData();
		}

	}
}
