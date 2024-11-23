using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Resizing callback data to apply custom constraint. As enabled by SetNextWindowSizeConstraints(). Callback is called during the next Begin().</para>
	/// <para>NB: For basic min/max size constraint on each axis you don't need to use the callback! The SetNextWindowSizeConstraints() parameters are enough.</para>
	/// </summary>
	public unsafe partial struct ImGuiSizeCallbackData
	{
		/// <summary>
		/// Read-only.   What user passed to SetNextWindowSizeConstraints(). Generally store an integer or float in here (need reinterpret_cast&lt;&gt;).
		/// </summary>
		public void* UserData;
		/// <summary>
		/// Read-only.   Window position, for reference.
		/// </summary>
		public Vector2 Pos;
		/// <summary>
		/// Read-only.   Current window size.
		/// </summary>
		public Vector2 CurrentSize;
		/// <summary>
		/// Read-write.  Desired size, based on user's mouse position. Write to this field to restrain resizing.
		/// </summary>
		public Vector2 DesiredSize;
	}

	/// <summary>
	/// <para>Resizing callback data to apply custom constraint. As enabled by SetNextWindowSizeConstraints(). Callback is called during the next Begin().</para>
	/// <para>NB: For basic min/max size constraint on each axis you don't need to use the callback! The SetNextWindowSizeConstraints() parameters are enough.</para>
	/// </summary>
	public unsafe partial struct ImGuiSizeCallbackDataPtr
	{
		public ImGuiSizeCallbackData* NativePtr { get; }
		public ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiSizeCallbackData*)nativePtr;
		public static implicit operator ImGuiSizeCallbackDataPtr(ImGuiSizeCallbackData* nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);
		public static implicit operator ImGuiSizeCallbackData* (ImGuiSizeCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiSizeCallbackDataPtr(IntPtr nativePtr) => new ImGuiSizeCallbackDataPtr(nativePtr);

		/// <summary>
		/// Read-only.   What user passed to SetNextWindowSizeConstraints(). Generally store an integer or float in here (need reinterpret_cast&lt;&gt;).
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }

		/// <summary>
		/// Read-only.   Window position, for reference.
		/// </summary>
		public ref Vector2 Pos => ref Unsafe.AsRef<Vector2>(&NativePtr->Pos);

		/// <summary>
		/// Read-only.   Current window size.
		/// </summary>
		public ref Vector2 CurrentSize => ref Unsafe.AsRef<Vector2>(&NativePtr->CurrentSize);

		/// <summary>
		/// Read-write.  Desired size, based on user's mouse position. Write to this field to restrain resizing.
		/// </summary>
		public ref Vector2 DesiredSize => ref Unsafe.AsRef<Vector2>(&NativePtr->DesiredSize);
	}
}
