using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImDrawDataBuilder
	{
		/// <summary>
		/// Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.
		/// </summary>
		public ImVector Layers_0;
		public ImVector Layers_1;
		public ImVector LayerData1;
	}

	public unsafe partial struct ImDrawDataBuilderPtr
	{
		public ImDrawDataBuilder* NativePtr { get; }
		public ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => NativePtr = nativePtr;
		public ImDrawDataBuilderPtr(IntPtr nativePtr) => NativePtr = (ImDrawDataBuilder*)nativePtr;
		public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => new ImDrawDataBuilderPtr(nativePtr);
		public static implicit operator ImDrawDataBuilder* (ImDrawDataBuilderPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawDataBuilderPtr(IntPtr nativePtr) => new ImDrawDataBuilderPtr(nativePtr);

		/// <summary>
		/// Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.
		/// </summary>
		public RangeAccessor<ImPtrVector<ImDrawListPtr>> Layers => new RangeAccessor<ImPtrVector<ImDrawListPtr>>(&NativePtr->Layers_0, 2);

		public ImVector<ImDrawListPtr> LayerData1 => new ImVector<ImDrawListPtr>(NativePtr->LayerData1);
	}
}
