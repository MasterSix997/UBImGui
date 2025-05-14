using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Temporary clipper data, buffers shared/reused between instances<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipperData
	{
		public unsafe ImGuiListClipper* ListClipper;
		public float LossynessOffset;
		public int StepNo;
		public int ItemsFrozen;
		public ImVector<ImGuiListClipperRange> Ranges;
	}

	/// <summary>
	/// Temporary clipper data, buffers shared/reused between instances<br/>
	/// </summary>
	public unsafe partial struct ImGuiListClipperDataPtr
	{
		public ImGuiListClipperData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiListClipperData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiListClipperPtr ListClipper => ref Unsafe.AsRef<ImGuiListClipperPtr>(&NativePtr->ListClipper);
		public ref float LossynessOffset => ref Unsafe.AsRef<float>(&NativePtr->LossynessOffset);
		public ref int StepNo => ref Unsafe.AsRef<int>(&NativePtr->StepNo);
		public ref int ItemsFrozen => ref Unsafe.AsRef<int>(&NativePtr->ItemsFrozen);
		public ref ImVector<ImGuiListClipperRange> Ranges => ref Unsafe.AsRef<ImVector<ImGuiListClipperRange>>(&NativePtr->Ranges);
		public ImGuiListClipperDataPtr(ImGuiListClipperData* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipperData*)nativePtr;
		public static implicit operator ImGuiListClipperDataPtr(ImGuiListClipperData* ptr) => new ImGuiListClipperDataPtr(ptr);
		public static implicit operator ImGuiListClipperDataPtr(IntPtr ptr) => new ImGuiListClipperDataPtr(ptr);
		public static implicit operator ImGuiListClipperData*(ImGuiListClipperDataPtr nativePtr) => nativePtr.NativePtr;
		public void Reset(ImGuiListClipperPtr clipper)
		{
			ImGuiNative.ImGuiListClipperDataReset(NativePtr, clipper);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiListClipperDataDestroy(NativePtr);
		}

		public void ImGuiListClipperDataConstruct()
		{
			ImGuiNative.ImGuiListClipperDataImGuiListClipperDataConstruct(NativePtr);
		}

		public ImGuiListClipperDataPtr ImGuiListClipperData()
		{
			return ImGuiNative.ImGuiListClipperDataImGuiListClipperData();
		}

	}
}
