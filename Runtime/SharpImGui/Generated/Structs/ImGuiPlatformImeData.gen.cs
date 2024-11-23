using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>(Optional) Support for IME (Input Method Editor) via the platform_io.Platform_SetImeDataFn() function.</para>
	/// </summary>
	public unsafe partial struct ImGuiPlatformImeData
	{
		/// <summary>
		/// A widget wants the IME to be visible
		/// </summary>
		public byte WantVisible;
		/// <summary>
		/// Position of the input cursor
		/// </summary>
		public Vector2 InputPos;
		/// <summary>
		/// Line height
		/// </summary>
		public float InputLineHeight;
	}

	/// <summary>
	/// <para>(Optional) Support for IME (Input Method Editor) via the platform_io.Platform_SetImeDataFn() function.</para>
	/// </summary>
	public unsafe partial struct ImGuiPlatformImeDataPtr
	{
		public ImGuiPlatformImeData* NativePtr { get; }
		public ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformImeDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformImeData*)nativePtr;
		public static implicit operator ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => new ImGuiPlatformImeDataPtr(nativePtr);
		public static implicit operator ImGuiPlatformImeData* (ImGuiPlatformImeDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiPlatformImeDataPtr(IntPtr nativePtr) => new ImGuiPlatformImeDataPtr(nativePtr);

		/// <summary>
		/// A widget wants the IME to be visible
		/// </summary>
		public ref bool WantVisible => ref Unsafe.AsRef<bool>(&NativePtr->WantVisible);

		/// <summary>
		/// Position of the input cursor
		/// </summary>
		public ref Vector2 InputPos => ref Unsafe.AsRef<Vector2>(&NativePtr->InputPos);

		/// <summary>
		/// Line height
		/// </summary>
		public ref float InputLineHeight => ref Unsafe.AsRef<float>(&NativePtr->InputLineHeight);
	}
}
