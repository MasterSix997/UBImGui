using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// (Optional) Support for IME (Input Method Editor) via the platform_io.Platform_SetImeDataFn() function.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformImeData
	{
		/// <summary>
		/// A widget wants the IME to be visible<br/>
		/// </summary>
		public byte WantVisible;
		/// <summary>
		/// Position of the input cursor<br/>
		/// </summary>
		public Vector2 InputPos;
		/// <summary>
		/// Line height<br/>
		/// </summary>
		public float InputLineHeight;
	}

	/// <summary>
	/// (Optional) Support for IME (Input Method Editor) via the platform_io.Platform_SetImeDataFn() function.<br/>
	/// </summary>
	public unsafe partial struct ImGuiPlatformImeDataPtr
	{
		public ImGuiPlatformImeData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPlatformImeData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// A widget wants the IME to be visible<br/>
		/// </summary>
		public ref bool WantVisible => ref Unsafe.AsRef<bool>(&NativePtr->WantVisible);
		/// <summary>
		/// Position of the input cursor<br/>
		/// </summary>
		public ref Vector2 InputPos => ref Unsafe.AsRef<Vector2>(&NativePtr->InputPos);
		/// <summary>
		/// Line height<br/>
		/// </summary>
		public ref float InputLineHeight => ref Unsafe.AsRef<float>(&NativePtr->InputLineHeight);
		public ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformImeDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformImeData*)nativePtr;
		public static implicit operator ImGuiPlatformImeDataPtr(ImGuiPlatformImeData* ptr) => new ImGuiPlatformImeDataPtr(ptr);
		public static implicit operator ImGuiPlatformImeDataPtr(IntPtr ptr) => new ImGuiPlatformImeDataPtr(ptr);
		public static implicit operator ImGuiPlatformImeData*(ImGuiPlatformImeDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiPlatformImeDataDestroy(NativePtr);
		}

		public void ImGuiPlatformImeDataConstruct()
		{
			ImGuiNative.ImGuiPlatformImeDataImGuiPlatformImeDataConstruct(NativePtr);
		}

		public ImGuiPlatformImeDataPtr ImGuiPlatformImeData()
		{
			return ImGuiNative.ImGuiPlatformImeDataImGuiPlatformImeData();
		}

	}
}
