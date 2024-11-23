using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Returned by GetTypingSelectRequest(), designed to eventually be public.</para>
	/// </summary>
	public unsafe partial struct ImGuiTypingSelectRequest
	{
		/// <summary>
		/// Flags passed to GetTypingSelectRequest()
		/// </summary>
		public ImGuiTypingSelectFlags Flags;
		public int SearchBufferLen;
		/// <summary>
		/// Search buffer contents (use full string. unless SingleCharMode is set, in which case use SingleCharSize).
		/// </summary>
		public byte* SearchBuffer;
		/// <summary>
		/// Set when buffer was modified this frame, requesting a selection.
		/// </summary>
		public byte SelectRequest;
		/// <summary>
		/// Notify when buffer contains same character repeated, to implement special mode. In this situation it preferred to not display any on-screen search indication.
		/// </summary>
		public byte SingleCharMode;
		/// <summary>
		/// Length in bytes of first letter codepoint (1 for ascii, 2-4 for UTF-8). If (SearchBufferLen==RepeatCharSize) only 1 letter has been input.
		/// </summary>
		public sbyte SingleCharSize;
	}

	/// <summary>
	/// <para>Returned by GetTypingSelectRequest(), designed to eventually be public.</para>
	/// </summary>
	public unsafe partial struct ImGuiTypingSelectRequestPtr
	{
		public ImGuiTypingSelectRequest* NativePtr { get; }
		public ImGuiTypingSelectRequestPtr(ImGuiTypingSelectRequest* nativePtr) => NativePtr = nativePtr;
		public ImGuiTypingSelectRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiTypingSelectRequest*)nativePtr;
		public static implicit operator ImGuiTypingSelectRequestPtr(ImGuiTypingSelectRequest* nativePtr) => new ImGuiTypingSelectRequestPtr(nativePtr);
		public static implicit operator ImGuiTypingSelectRequest* (ImGuiTypingSelectRequestPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTypingSelectRequestPtr(IntPtr nativePtr) => new ImGuiTypingSelectRequestPtr(nativePtr);

		/// <summary>
		/// Flags passed to GetTypingSelectRequest()
		/// </summary>
		public ref ImGuiTypingSelectFlags Flags => ref Unsafe.AsRef<ImGuiTypingSelectFlags>(&NativePtr->Flags);

		public ref int SearchBufferLen => ref Unsafe.AsRef<int>(&NativePtr->SearchBufferLen);

		/// <summary>
		/// Search buffer contents (use full string. unless SingleCharMode is set, in which case use SingleCharSize).
		/// </summary>
		public IntPtr SearchBuffer { get => (IntPtr)NativePtr->SearchBuffer; set => NativePtr->SearchBuffer = (byte*)value; }

		/// <summary>
		/// Set when buffer was modified this frame, requesting a selection.
		/// </summary>
		public ref bool SelectRequest => ref Unsafe.AsRef<bool>(&NativePtr->SelectRequest);

		/// <summary>
		/// Notify when buffer contains same character repeated, to implement special mode. In this situation it preferred to not display any on-screen search indication.
		/// </summary>
		public ref bool SingleCharMode => ref Unsafe.AsRef<bool>(&NativePtr->SingleCharMode);

		/// <summary>
		/// Length in bytes of first letter codepoint (1 for ascii, 2-4 for UTF-8). If (SearchBufferLen==RepeatCharSize) only 1 letter has been input.
		/// </summary>
		public ref sbyte SingleCharSize => ref Unsafe.AsRef<sbyte>(&NativePtr->SingleCharSize);
	}
}
