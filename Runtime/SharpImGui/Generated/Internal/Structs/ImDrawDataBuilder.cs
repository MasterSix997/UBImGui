using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImDrawDataBuilder
	{
		/// <summary>
		/// Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.<br/>
		/// </summary>
		public unsafe ImVector<ImDrawListPtr>* Layers_0;
		public unsafe ImVector<ImDrawListPtr>* Layers_1;
		public ImVector<ImDrawListPtr> LayerData1;
	}

	public unsafe partial struct ImDrawDataBuilderPtr
	{
		public ImDrawDataBuilder* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImDrawDataBuilder this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Pointers to global layers for: regular, tooltip. LayersP[0] is owned by DrawData.<br/>
		/// </summary>
		public Span<ImPointer<ImVector<ImDrawListPtr>>> Layers => new Span<ImPointer<ImVector<ImDrawListPtr>>>(&NativePtr->Layers_0, 2);
		public ref ImVector<ImDrawListPtr> LayerData1 => ref Unsafe.AsRef<ImVector<ImDrawListPtr>>(&NativePtr->LayerData1);
		public ImDrawDataBuilderPtr(ImDrawDataBuilder* nativePtr) => NativePtr = nativePtr;
		public ImDrawDataBuilderPtr(IntPtr nativePtr) => NativePtr = (ImDrawDataBuilder*)nativePtr;
		public static implicit operator ImDrawDataBuilderPtr(ImDrawDataBuilder* ptr) => new ImDrawDataBuilderPtr(ptr);
		public static implicit operator ImDrawDataBuilderPtr(IntPtr ptr) => new ImDrawDataBuilderPtr(ptr);
		public static implicit operator ImDrawDataBuilder*(ImDrawDataBuilderPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImDrawDataBuilderDestroy(NativePtr);
		}

		public void ImDrawDataBuilderConstruct()
		{
			ImGuiNative.ImDrawDataBuilderImDrawDataBuilderConstruct(NativePtr);
		}

		public ImDrawDataBuilderPtr ImDrawDataBuilder()
		{
			return ImGuiNative.ImDrawDataBuilderImDrawDataBuilder();
		}

	}
}
