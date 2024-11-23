using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Note that Max is exclusive, so perhaps should be using a Begin/End convention.</para>
	/// </summary>
	public unsafe partial struct ImGuiListClipperRange
	{
		public int Min;
		public int Max;
		/// <summary>
		/// Begin/End are absolute position (will be converted to indices later)
		/// </summary>
		public byte PosToIndexConvert;
		/// <summary>
		/// Add to Min after converting to indices
		/// </summary>
		public sbyte PosToIndexOffsetMin;
		/// <summary>
		/// Add to Min after converting to indices
		/// </summary>
		public sbyte PosToIndexOffsetMax;
	}

	/// <summary>
	/// <para>Note that Max is exclusive, so perhaps should be using a Begin/End convention.</para>
	/// </summary>
	public unsafe partial struct ImGuiListClipperRangePtr
	{
		public ImGuiListClipperRange* NativePtr { get; }
		public ImGuiListClipperRangePtr(ImGuiListClipperRange* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperRange*)nativePtr;
		public static implicit operator ImGuiListClipperRangePtr(ImGuiListClipperRange* nativePtr) => new ImGuiListClipperRangePtr(nativePtr);
		public static implicit operator ImGuiListClipperRange* (ImGuiListClipperRangePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiListClipperRangePtr(IntPtr nativePtr) => new ImGuiListClipperRangePtr(nativePtr);

		public ref int Min => ref Unsafe.AsRef<int>(&NativePtr->Min);

		public ref int Max => ref Unsafe.AsRef<int>(&NativePtr->Max);

		/// <summary>
		/// Begin/End are absolute position (will be converted to indices later)
		/// </summary>
		public ref bool PosToIndexConvert => ref Unsafe.AsRef<bool>(&NativePtr->PosToIndexConvert);

		/// <summary>
		/// Add to Min after converting to indices
		/// </summary>
		public ref sbyte PosToIndexOffsetMin => ref Unsafe.AsRef<sbyte>(&NativePtr->PosToIndexOffsetMin);

		/// <summary>
		/// Add to Min after converting to indices
		/// </summary>
		public ref sbyte PosToIndexOffsetMax => ref Unsafe.AsRef<sbyte>(&NativePtr->PosToIndexOffsetMax);

		public ImGuiListClipperRange FromIndices(int min, int max)
		{
			var ret = ImGuiInternalNative.ImGuiListClipperRange_FromIndices(min, max);
			return ret;
		}

		public ImGuiListClipperRange FromPositions(float y1, float y2, int off_min, int off_max)
		{
			var ret = ImGuiInternalNative.ImGuiListClipperRange_FromPositions(y1, y2, off_min, off_max);
			return ret;
		}
	}
}
