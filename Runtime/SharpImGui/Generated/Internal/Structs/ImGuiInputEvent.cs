using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEvent
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiInputEventUnion
		{
			[FieldOffset(0)]
			public ImGuiInputEventMousePos MousePos;
			[FieldOffset(0)]
			public ImGuiInputEventMouseWheel MouseWheel;
			[FieldOffset(0)]
			public ImGuiInputEventMouseButton MouseButton;
			[FieldOffset(0)]
			public ImGuiInputEventMouseViewport MouseViewport;
			[FieldOffset(0)]
			public ImGuiInputEventKey Key;
			[FieldOffset(0)]
			public ImGuiInputEventText Text;
			[FieldOffset(0)]
			public ImGuiInputEventAppFocused AppFocused;
		}
		public ImGuiInputEventType Type;
		public ImGuiInputSource Source;
		/// <summary>
		/// Unique, sequential increasing integer to identify an event (if you need to correlate them to other data).<br/>
		/// </summary>
		public uint EventId;
		public ImGuiInputEventUnion Union;
		public byte AddedByTestEngine;
	}

	public unsafe partial struct ImGuiInputEventPtr
	{
		public ImGuiInputEvent* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEvent this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiInputEventType Type => ref Unsafe.AsRef<ImGuiInputEventType>(&NativePtr->Type);
		public ref ImGuiInputSource Source => ref Unsafe.AsRef<ImGuiInputSource>(&NativePtr->Source);
		/// <summary>
		/// Unique, sequential increasing integer to identify an event (if you need to correlate them to other data).<br/>
		/// </summary>
		public ref uint EventId => ref Unsafe.AsRef<uint>(&NativePtr->EventId);
		public ref ImGuiInputEvent.ImGuiInputEventUnion Union => ref Unsafe.AsRef<ImGuiInputEvent.ImGuiInputEventUnion>(&NativePtr->Union);
		public ref bool AddedByTestEngine => ref Unsafe.AsRef<bool>(&NativePtr->AddedByTestEngine);
		public ImGuiInputEventPtr(ImGuiInputEvent* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEvent*)nativePtr;
		public static implicit operator ImGuiInputEventPtr(ImGuiInputEvent* ptr) => new ImGuiInputEventPtr(ptr);
		public static implicit operator ImGuiInputEventPtr(IntPtr ptr) => new ImGuiInputEventPtr(ptr);
		public static implicit operator ImGuiInputEvent*(ImGuiInputEventPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiInputEventDestroy(NativePtr);
		}

		public void ImGuiInputEventConstruct()
		{
			ImGuiNative.ImGuiInputEventImGuiInputEventConstruct(NativePtr);
		}

		public ImGuiInputEventPtr ImGuiInputEvent()
		{
			return ImGuiNative.ImGuiInputEventImGuiInputEvent();
		}

	}
}
