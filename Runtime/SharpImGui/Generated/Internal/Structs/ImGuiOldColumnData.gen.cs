using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiOldColumnData
	{
		/// <summary>
		/// Column start offset, normalized 0.0 (far left) -&gt; 1.0 (far right)
		/// </summary>
		public float OffsetNorm;
		public float OffsetNormBeforeResize;
		/// <summary>
		/// Not exposed
		/// </summary>
		public ImGuiOldColumnFlags Flags;
		public ImRect ClipRect;
	}

	public unsafe partial struct ImGuiOldColumnDataPtr
	{
		public ImGuiOldColumnData* NativePtr { get; }
		public ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => NativePtr = nativePtr;
		public ImGuiOldColumnDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiOldColumnData*)nativePtr;
		public static implicit operator ImGuiOldColumnDataPtr(ImGuiOldColumnData* nativePtr) => new ImGuiOldColumnDataPtr(nativePtr);
		public static implicit operator ImGuiOldColumnData* (ImGuiOldColumnDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiOldColumnDataPtr(IntPtr nativePtr) => new ImGuiOldColumnDataPtr(nativePtr);

		/// <summary>
		/// Column start offset, normalized 0.0 (far left) -&gt; 1.0 (far right)
		/// </summary>
		public ref float OffsetNorm => ref Unsafe.AsRef<float>(&NativePtr->OffsetNorm);

		public ref float OffsetNormBeforeResize => ref Unsafe.AsRef<float>(&NativePtr->OffsetNormBeforeResize);

		/// <summary>
		/// Not exposed
		/// </summary>
		public ref ImGuiOldColumnFlags Flags => ref Unsafe.AsRef<ImGuiOldColumnFlags>(&NativePtr->Flags);

		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
	}
}
