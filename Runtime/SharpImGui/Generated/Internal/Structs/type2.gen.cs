using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct type2
	{
		/// <summary>
		/// if Type == ImGuiInputEventType_MousePos
		/// </summary>
		public ImGuiInputEventMousePos MousePos;
		/// <summary>
		/// if Type == ImGuiInputEventType_MouseWheel
		/// </summary>
		public ImGuiInputEventMouseWheel MouseWheel;
		/// <summary>
		/// if Type == ImGuiInputEventType_MouseButton
		/// </summary>
		public ImGuiInputEventMouseButton MouseButton;
		/// <summary>
		/// if Type == ImGuiInputEventType_MouseViewport
		/// </summary>
		public ImGuiInputEventMouseViewport MouseViewport;
		/// <summary>
		/// if Type == ImGuiInputEventType_Key
		/// </summary>
		public ImGuiInputEventKey Key;
		/// <summary>
		/// if Type == ImGuiInputEventType_Text
		/// </summary>
		public ImGuiInputEventText Text;
		/// <summary>
		/// if Type == ImGuiInputEventType_Focus
		/// </summary>
		public ImGuiInputEventAppFocused AppFocused;
	}

	public unsafe partial struct type2Ptr
	{
		public type2* NativePtr { get; }
		public type2Ptr(type2* nativePtr) => NativePtr = nativePtr;
		public type2Ptr(IntPtr nativePtr) => NativePtr = (type2*)nativePtr;
		public static implicit operator type2Ptr(type2* nativePtr) => new type2Ptr(nativePtr);
		public static implicit operator type2* (type2Ptr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator type2Ptr(IntPtr nativePtr) => new type2Ptr(nativePtr);

		/// <summary>
		/// if Type == ImGuiInputEventType_MousePos
		/// </summary>
		public ref ImGuiInputEventMousePos MousePos => ref Unsafe.AsRef<ImGuiInputEventMousePos>(&NativePtr->MousePos);

		/// <summary>
		/// if Type == ImGuiInputEventType_MouseWheel
		/// </summary>
		public ref ImGuiInputEventMouseWheel MouseWheel => ref Unsafe.AsRef<ImGuiInputEventMouseWheel>(&NativePtr->MouseWheel);

		/// <summary>
		/// if Type == ImGuiInputEventType_MouseButton
		/// </summary>
		public ref ImGuiInputEventMouseButton MouseButton => ref Unsafe.AsRef<ImGuiInputEventMouseButton>(&NativePtr->MouseButton);

		/// <summary>
		/// if Type == ImGuiInputEventType_MouseViewport
		/// </summary>
		public ref ImGuiInputEventMouseViewport MouseViewport => ref Unsafe.AsRef<ImGuiInputEventMouseViewport>(&NativePtr->MouseViewport);

		/// <summary>
		/// if Type == ImGuiInputEventType_Key
		/// </summary>
		public ref ImGuiInputEventKey Key => ref Unsafe.AsRef<ImGuiInputEventKey>(&NativePtr->Key);

		/// <summary>
		/// if Type == ImGuiInputEventType_Text
		/// </summary>
		public ref ImGuiInputEventText Text => ref Unsafe.AsRef<ImGuiInputEventText>(&NativePtr->Text);

		/// <summary>
		/// if Type == ImGuiInputEventType_Focus
		/// </summary>
		public ref ImGuiInputEventAppFocused AppFocused => ref Unsafe.AsRef<ImGuiInputEventAppFocused>(&NativePtr->AppFocused);
	}
}
