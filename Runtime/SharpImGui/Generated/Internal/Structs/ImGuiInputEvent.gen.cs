using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiInputEvent
	{
		public ImGuiInputEventType Type;
		public ImGuiInputSource Source;
		/// <summary>
		/// Unique, sequential increasing integer to identify an event (if you need to correlate them to other data).
		/// </summary>
		public uint EventId;
		public byte AddedByTestEngine;
	}

	public unsafe partial struct ImGuiInputEventPtr
	{
		public ImGuiInputEvent* NativePtr { get; }
		public ImGuiInputEventPtr(ImGuiInputEvent* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEvent*)nativePtr;
		public static implicit operator ImGuiInputEventPtr(ImGuiInputEvent* nativePtr) => new ImGuiInputEventPtr(nativePtr);
		public static implicit operator ImGuiInputEvent* (ImGuiInputEventPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiInputEventPtr(IntPtr nativePtr) => new ImGuiInputEventPtr(nativePtr);

		public ref ImGuiInputEventType Type => ref Unsafe.AsRef<ImGuiInputEventType>(&NativePtr->Type);

		public ref ImGuiInputSource Source => ref Unsafe.AsRef<ImGuiInputSource>(&NativePtr->Source);

		/// <summary>
		/// Unique, sequential increasing integer to identify an event (if you need to correlate them to other data).
		/// </summary>
		public ref uint EventId => ref Unsafe.AsRef<uint>(&NativePtr->EventId);

		public ref bool AddedByTestEngine => ref Unsafe.AsRef<bool>(&NativePtr->AddedByTestEngine);
	}
}
