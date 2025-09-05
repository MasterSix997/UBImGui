using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Returned by GetTypingSelectRequest(), designed to eventually be public.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTypingSelectRequest
	{
		/// <summary>
		/// Flags passed to GetTypingSelectRequest()<br/>
		/// </summary>
		public ImGuiTypingSelectFlags Flags;
		public int SearchBufferLen;
		/// <summary>
		/// Search buffer contents (use full string. unless SingleCharMode is set, in which case use SingleCharSize).<br/>
		/// </summary>
		public unsafe byte* SearchBuffer;
		/// <summary>
		/// Set when buffer was modified this frame, requesting a selection.<br/>
		/// </summary>
		public byte SelectRequest;
		/// <summary>
		/// Notify when buffer contains same character repeated, to implement special mode. In this situation it preferred to not display any on-screen search indication.<br/>
		/// </summary>
		public byte SingleCharMode;
		/// <summary>
		/// Length in bytes of first letter codepoint (1 for ascii, 2-4 for UTF-8). If (SearchBufferLen==RepeatCharSize) only 1 letter has been input.<br/>
		/// </summary>
		public sbyte SingleCharSize;
	}

	/// <summary>
	/// Returned by GetTypingSelectRequest(), designed to eventually be public.<br/>
	/// </summary>
	public unsafe partial struct ImGuiTypingSelectRequestPtr
	{
		public ImGuiTypingSelectRequest* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTypingSelectRequest this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Flags passed to GetTypingSelectRequest()<br/>
		/// </summary>
		public ref ImGuiTypingSelectFlags Flags => ref Unsafe.AsRef<ImGuiTypingSelectFlags>(&NativePtr->Flags);
		public ref int SearchBufferLen => ref Unsafe.AsRef<int>(&NativePtr->SearchBufferLen);
		/// <summary>
		/// Search buffer contents (use full string. unless SingleCharMode is set, in which case use SingleCharSize).<br/>
		/// </summary>
		public IntPtr SearchBuffer { get => (IntPtr)NativePtr->SearchBuffer; set => NativePtr->SearchBuffer = (byte*)value; }
		/// <summary>
		/// Set when buffer was modified this frame, requesting a selection.<br/>
		/// </summary>
		public ref bool SelectRequest => ref Unsafe.AsRef<bool>(&NativePtr->SelectRequest);
		/// <summary>
		/// Notify when buffer contains same character repeated, to implement special mode. In this situation it preferred to not display any on-screen search indication.<br/>
		/// </summary>
		public ref bool SingleCharMode => ref Unsafe.AsRef<bool>(&NativePtr->SingleCharMode);
		/// <summary>
		/// Length in bytes of first letter codepoint (1 for ascii, 2-4 for UTF-8). If (SearchBufferLen==RepeatCharSize) only 1 letter has been input.<br/>
		/// </summary>
		public ref sbyte SingleCharSize => ref Unsafe.AsRef<sbyte>(&NativePtr->SingleCharSize);
		public ImGuiTypingSelectRequestPtr(ImGuiTypingSelectRequest* nativePtr) => NativePtr = nativePtr;
		public ImGuiTypingSelectRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiTypingSelectRequest*)nativePtr;
		public static implicit operator ImGuiTypingSelectRequestPtr(ImGuiTypingSelectRequest* ptr) => new ImGuiTypingSelectRequestPtr(ptr);
		public static implicit operator ImGuiTypingSelectRequestPtr(IntPtr ptr) => new ImGuiTypingSelectRequestPtr(ptr);
		public static implicit operator ImGuiTypingSelectRequest*(ImGuiTypingSelectRequestPtr nativePtr) => nativePtr.NativePtr;
	}
}
