using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Storage for GetTypingSelectRequest()</para>
	/// </summary>
	public unsafe partial struct ImGuiTypingSelectState
	{
		/// <summary>
		/// User-facing data
		/// </summary>
		public ImGuiTypingSelectRequest Request;
		/// <summary>
		/// Search buffer: no need to make dynamic as this search is very transient.
		/// </summary>
		public fixed byte SearchBuffer[64];
		public uint FocusScope;
		public int LastRequestFrame;
		public float LastRequestTime;
		/// <summary>
		/// After a certain single char repeat count we lock into SingleCharMode. Two benefits: 1) buffer never fill, 2) we can provide an immediate SingleChar mode without timer elapsing.
		/// </summary>
		public byte SingleCharModeLock;
	}

	/// <summary>
	/// <para>Storage for GetTypingSelectRequest()</para>
	/// </summary>
	public unsafe partial struct ImGuiTypingSelectStatePtr
	{
		public ImGuiTypingSelectState* NativePtr { get; }
		public ImGuiTypingSelectStatePtr(ImGuiTypingSelectState* nativePtr) => NativePtr = nativePtr;
		public ImGuiTypingSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiTypingSelectState*)nativePtr;
		public static implicit operator ImGuiTypingSelectStatePtr(ImGuiTypingSelectState* nativePtr) => new ImGuiTypingSelectStatePtr(nativePtr);
		public static implicit operator ImGuiTypingSelectState* (ImGuiTypingSelectStatePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTypingSelectStatePtr(IntPtr nativePtr) => new ImGuiTypingSelectStatePtr(nativePtr);

		/// <summary>
		/// User-facing data
		/// </summary>
		public ref ImGuiTypingSelectRequest Request => ref Unsafe.AsRef<ImGuiTypingSelectRequest>(&NativePtr->Request);

		/// <summary>
		/// Search buffer: no need to make dynamic as this search is very transient.
		/// </summary>
		public RangeAccessor<byte> SearchBuffer => new RangeAccessor<byte>(NativePtr->SearchBuffer, 64);

		public ref uint FocusScope => ref Unsafe.AsRef<uint>(&NativePtr->FocusScope);

		public ref int LastRequestFrame => ref Unsafe.AsRef<int>(&NativePtr->LastRequestFrame);

		public ref float LastRequestTime => ref Unsafe.AsRef<float>(&NativePtr->LastRequestTime);

		/// <summary>
		/// After a certain single char repeat count we lock into SingleCharMode. Two benefits: 1) buffer never fill, 2) we can provide an immediate SingleChar mode without timer elapsing.
		/// </summary>
		public ref bool SingleCharModeLock => ref Unsafe.AsRef<bool>(&NativePtr->SingleCharModeLock);

		/// <summary>
		/// We preserve remaining data for easier debugging
		/// </summary>
		public void Clear()
		{
			ImGuiInternalNative.ImGuiTypingSelectState_Clear(NativePtr);
		}
	}
}
