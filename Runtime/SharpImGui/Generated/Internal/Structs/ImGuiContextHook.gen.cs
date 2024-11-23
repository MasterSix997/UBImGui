using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiContextHook
	{
		/// <summary>
		/// A unique ID assigned by AddContextHook()
		/// </summary>
		public uint HookId;
		public ImGuiContextHookType Type;
		public uint Owner;
		public IntPtr Callback;
		public void* UserData;
	}

	public unsafe partial struct ImGuiContextHookPtr
	{
		public ImGuiContextHook* NativePtr { get; }
		public ImGuiContextHookPtr(ImGuiContextHook* nativePtr) => NativePtr = nativePtr;
		public ImGuiContextHookPtr(IntPtr nativePtr) => NativePtr = (ImGuiContextHook*)nativePtr;
		public static implicit operator ImGuiContextHookPtr(ImGuiContextHook* nativePtr) => new ImGuiContextHookPtr(nativePtr);
		public static implicit operator ImGuiContextHook* (ImGuiContextHookPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiContextHookPtr(IntPtr nativePtr) => new ImGuiContextHookPtr(nativePtr);

		/// <summary>
		/// A unique ID assigned by AddContextHook()
		/// </summary>
		public ref uint HookId => ref Unsafe.AsRef<uint>(&NativePtr->HookId);

		public ref ImGuiContextHookType Type => ref Unsafe.AsRef<ImGuiContextHookType>(&NativePtr->Type);

		public ref uint Owner => ref Unsafe.AsRef<uint>(&NativePtr->Owner);

		public ref ImGuiContextHookCallback Callback => ref Unsafe.AsRef<ImGuiContextHookCallback>(&NativePtr->Callback);

		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
	}
}
