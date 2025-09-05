using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiContextHook
	{
		/// <summary>
		/// A unique ID assigned by AddContextHook()<br/>
		/// </summary>
		public uint HookId;
		public ImGuiContextHookType Type;
		public uint Owner;
		public unsafe void* Callback;
		public unsafe void* UserData;
	}

	public unsafe partial struct ImGuiContextHookPtr
	{
		public ImGuiContextHook* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiContextHook this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// A unique ID assigned by AddContextHook()<br/>
		/// </summary>
		public ref uint HookId => ref Unsafe.AsRef<uint>(&NativePtr->HookId);
		public ref ImGuiContextHookType Type => ref Unsafe.AsRef<ImGuiContextHookType>(&NativePtr->Type);
		public ref uint Owner => ref Unsafe.AsRef<uint>(&NativePtr->Owner);
		public IntPtr Callback { get => (IntPtr)NativePtr->Callback; set => NativePtr->Callback = (void*)value; }
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
		public ImGuiContextHookPtr(ImGuiContextHook* nativePtr) => NativePtr = nativePtr;
		public ImGuiContextHookPtr(IntPtr nativePtr) => NativePtr = (ImGuiContextHook*)nativePtr;
		public static implicit operator ImGuiContextHookPtr(ImGuiContextHook* ptr) => new ImGuiContextHookPtr(ptr);
		public static implicit operator ImGuiContextHookPtr(IntPtr ptr) => new ImGuiContextHookPtr(ptr);
		public static implicit operator ImGuiContextHook*(ImGuiContextHookPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiContextHookDestroy(NativePtr);
		}

		public void ImGuiContextHookConstruct()
		{
			ImGuiNative.ImGuiContextHookImGuiContextHookConstruct(NativePtr);
		}

		public ImGuiContextHookPtr ImGuiContextHook()
		{
			return ImGuiNative.ImGuiContextHookImGuiContextHook();
		}

	}
}
