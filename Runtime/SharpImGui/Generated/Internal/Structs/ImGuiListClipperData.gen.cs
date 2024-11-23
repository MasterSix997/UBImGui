using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Temporary clipper data, buffers shared/reused between instances</para>
	/// </summary>
	public unsafe partial struct ImGuiListClipperData
	{
		public ImGuiListClipper* ListClipper;
		public float LossynessOffset;
		public int StepNo;
		public int ItemsFrozen;
		public ImVector Ranges;
	}

	/// <summary>
	/// <para>Temporary clipper data, buffers shared/reused between instances</para>
	/// </summary>
	public unsafe partial struct ImGuiListClipperDataPtr
	{
		public ImGuiListClipperData* NativePtr { get; }
		public ImGuiListClipperDataPtr(ImGuiListClipperData* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperData*)nativePtr;
		public static implicit operator ImGuiListClipperDataPtr(ImGuiListClipperData* nativePtr) => new ImGuiListClipperDataPtr(nativePtr);
		public static implicit operator ImGuiListClipperData* (ImGuiListClipperDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiListClipperDataPtr(IntPtr nativePtr) => new ImGuiListClipperDataPtr(nativePtr);

		public ImGuiListClipperPtr ListClipper => new ImGuiListClipperPtr(NativePtr->ListClipper);

		public ref float LossynessOffset => ref Unsafe.AsRef<float>(&NativePtr->LossynessOffset);

		public ref int StepNo => ref Unsafe.AsRef<int>(&NativePtr->StepNo);

		public ref int ItemsFrozen => ref Unsafe.AsRef<int>(&NativePtr->ItemsFrozen);

		public ImPtrVector<ImGuiListClipperRangePtr> Ranges => new ImPtrVector<ImGuiListClipperRangePtr>(NativePtr->Ranges, Unsafe.SizeOf<ImGuiListClipperRange>());

		public void Reset(ImGuiListClipperPtr clipper)
		{
			ImGuiInternalNative.ImGuiListClipperData_Reset(NativePtr, clipper);
		}
	}
}
