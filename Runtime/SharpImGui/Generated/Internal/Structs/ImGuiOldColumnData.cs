using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOldColumnData
	{
		/// <summary>
		/// Column start offset, normalized 0.0 (far left) -&gt; 1.0 (far right)<br/>
		/// </summary>
		public float OffsetNorm;
		public float OffsetNormBeforeResize;
		/// <summary>
		/// Not exposed<br/>
		/// </summary>
		public ImGuiOldColumnFlags Flags;
		public ImRect ClipRect;
	}

	public unsafe partial struct ImGuiOldColumnDataPtr
	{
		public ImGuiOldColumnData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiOldColumnData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Column start offset, normalized 0.0 (far left) -&gt; 1.0 (far right)<br/>
		/// </summary>
		public ref float OffsetNorm => ref Unsafe.AsRef<float>(&NativePtr->OffsetNorm);
		public ref float OffsetNormBeforeResize => ref Unsafe.AsRef<float>(&NativePtr->OffsetNormBeforeResize);
		/// <summary>
		/// Not exposed<br/>
		/// </summary>
		public ref ImGuiOldColumnFlags Flags => ref Unsafe.AsRef<ImGuiOldColumnFlags>(&NativePtr->Flags);
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
		public ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => NativePtr = nativePtr;
		public ImGuiOldColumnDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumnData*)nativePtr;
		public static implicit operator ImGuiOldColumnDataPtr(ImGuiOldColumnData* ptr) => new ImGuiOldColumnDataPtr(ptr);
		public static implicit operator ImGuiOldColumnDataPtr(IntPtr ptr) => new ImGuiOldColumnDataPtr(ptr);
		public static implicit operator ImGuiOldColumnData*(ImGuiOldColumnDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiOldColumnDataDestroy(NativePtr);
		}

		public void ImGuiOldColumnDataConstruct()
		{
			ImGuiNative.ImGuiOldColumnDataImGuiOldColumnDataConstruct(NativePtr);
		}

		public ImGuiOldColumnDataPtr ImGuiOldColumnData()
		{
			return ImGuiNative.ImGuiOldColumnDataImGuiOldColumnData();
		}

	}
}
