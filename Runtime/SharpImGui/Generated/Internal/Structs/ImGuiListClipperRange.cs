using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Note that Max is exclusive, so perhaps should be using a Begin/End convention.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperRange
	{
		public int Min;
		public int Max;
		/// <summary>
		/// Begin/End are absolute position (will be converted to indices later)<br/>
		/// </summary>
		public byte PosToIndexConvert;
		/// <summary>
		/// Add to Min after converting to indices<br/>
		/// </summary>
		public sbyte PosToIndexOffsetMin;
		/// <summary>
		/// Add to Min after converting to indices<br/>
		/// </summary>
		public sbyte PosToIndexOffsetMax;
	}

	/// <summary>
	/// Note that Max is exclusive, so perhaps should be using a Begin/End convention.<br/>
	/// </summary>
	public unsafe partial struct ImGuiListClipperRangePtr
	{
		public ImGuiListClipperRange* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiListClipperRange this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref int Min => ref Unsafe.AsRef<int>(&NativePtr->Min);
		public ref int Max => ref Unsafe.AsRef<int>(&NativePtr->Max);
		/// <summary>
		/// Begin/End are absolute position (will be converted to indices later)<br/>
		/// </summary>
		public ref bool PosToIndexConvert => ref Unsafe.AsRef<bool>(&NativePtr->PosToIndexConvert);
		/// <summary>
		/// Add to Min after converting to indices<br/>
		/// </summary>
		public ref sbyte PosToIndexOffsetMin => ref Unsafe.AsRef<sbyte>(&NativePtr->PosToIndexOffsetMin);
		/// <summary>
		/// Add to Min after converting to indices<br/>
		/// </summary>
		public ref sbyte PosToIndexOffsetMax => ref Unsafe.AsRef<sbyte>(&NativePtr->PosToIndexOffsetMax);
		public ImGuiListClipperRangePtr(ImGuiListClipperRange* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperRange*)nativePtr;
		public static implicit operator ImGuiListClipperRangePtr(ImGuiListClipperRange* ptr) => new ImGuiListClipperRangePtr(ptr);
		public static implicit operator ImGuiListClipperRangePtr(IntPtr ptr) => new ImGuiListClipperRangePtr(ptr);
		public static implicit operator ImGuiListClipperRange*(ImGuiListClipperRangePtr nativePtr) => nativePtr.NativePtr;
		public ImGuiListClipperRange FromPositions(float y1, float y2, int offMin, int offMax)
		{
			return ImGuiNative.ImGuiListClipperRangeFromPositions(y1, y2, offMin, offMax);
		}

		public ImGuiListClipperRange FromIndices(int min, int max)
		{
			return ImGuiNative.ImGuiListClipperRangeFromIndices(min, max);
		}

	}
}
