using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for GetTypingSelectRequest()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTypingSelectState
	{
		/// <summary>
		/// User-facing data<br/>
		/// </summary>
		public ImGuiTypingSelectRequest Request;
		/// <summary>
		/// Search buffer: no need to make dynamic as this search is very transient.<br/>
		/// </summary>
		public byte SearchBuffer_0;
		public byte SearchBuffer_1;
		public byte SearchBuffer_2;
		public byte SearchBuffer_3;
		public byte SearchBuffer_4;
		public byte SearchBuffer_5;
		public byte SearchBuffer_6;
		public byte SearchBuffer_7;
		public byte SearchBuffer_8;
		public byte SearchBuffer_9;
		public byte SearchBuffer_10;
		public byte SearchBuffer_11;
		public byte SearchBuffer_12;
		public byte SearchBuffer_13;
		public byte SearchBuffer_14;
		public byte SearchBuffer_15;
		public byte SearchBuffer_16;
		public byte SearchBuffer_17;
		public byte SearchBuffer_18;
		public byte SearchBuffer_19;
		public byte SearchBuffer_20;
		public byte SearchBuffer_21;
		public byte SearchBuffer_22;
		public byte SearchBuffer_23;
		public byte SearchBuffer_24;
		public byte SearchBuffer_25;
		public byte SearchBuffer_26;
		public byte SearchBuffer_27;
		public byte SearchBuffer_28;
		public byte SearchBuffer_29;
		public byte SearchBuffer_30;
		public byte SearchBuffer_31;
		public byte SearchBuffer_32;
		public byte SearchBuffer_33;
		public byte SearchBuffer_34;
		public byte SearchBuffer_35;
		public byte SearchBuffer_36;
		public byte SearchBuffer_37;
		public byte SearchBuffer_38;
		public byte SearchBuffer_39;
		public byte SearchBuffer_40;
		public byte SearchBuffer_41;
		public byte SearchBuffer_42;
		public byte SearchBuffer_43;
		public byte SearchBuffer_44;
		public byte SearchBuffer_45;
		public byte SearchBuffer_46;
		public byte SearchBuffer_47;
		public byte SearchBuffer_48;
		public byte SearchBuffer_49;
		public byte SearchBuffer_50;
		public byte SearchBuffer_51;
		public byte SearchBuffer_52;
		public byte SearchBuffer_53;
		public byte SearchBuffer_54;
		public byte SearchBuffer_55;
		public byte SearchBuffer_56;
		public byte SearchBuffer_57;
		public byte SearchBuffer_58;
		public byte SearchBuffer_59;
		public byte SearchBuffer_60;
		public byte SearchBuffer_61;
		public byte SearchBuffer_62;
		public byte SearchBuffer_63;
		public uint FocusScope;
		public int LastRequestFrame;
		public float LastRequestTime;
		/// <summary>
		/// After a certain single char repeat count we lock into SingleCharMode. Two benefits: 1) buffer never fill, 2) we can provide an immediate SingleChar mode without timer elapsing.<br/>
		/// </summary>
		public byte SingleCharModeLock;
	}

	/// <summary>
	/// Storage for GetTypingSelectRequest()<br/>
	/// </summary>
	public unsafe partial struct ImGuiTypingSelectStatePtr
	{
		public ImGuiTypingSelectState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTypingSelectState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// User-facing data<br/>
		/// </summary>
		public ref ImGuiTypingSelectRequest Request => ref Unsafe.AsRef<ImGuiTypingSelectRequest>(&NativePtr->Request);
		/// <summary>
		/// Search buffer: no need to make dynamic as this search is very transient.<br/>
		/// </summary>
		public Span<byte> SearchBuffer => new Span<byte>(&NativePtr->SearchBuffer_0, 64);
		public ref uint FocusScope => ref Unsafe.AsRef<uint>(&NativePtr->FocusScope);
		public ref int LastRequestFrame => ref Unsafe.AsRef<int>(&NativePtr->LastRequestFrame);
		public ref float LastRequestTime => ref Unsafe.AsRef<float>(&NativePtr->LastRequestTime);
		/// <summary>
		/// After a certain single char repeat count we lock into SingleCharMode. Two benefits: 1) buffer never fill, 2) we can provide an immediate SingleChar mode without timer elapsing.<br/>
		/// </summary>
		public ref bool SingleCharModeLock => ref Unsafe.AsRef<bool>(&NativePtr->SingleCharModeLock);
		public ImGuiTypingSelectStatePtr(ImGuiTypingSelectState* nativePtr) => NativePtr = nativePtr;
		public ImGuiTypingSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiTypingSelectState*)nativePtr;
		public static implicit operator ImGuiTypingSelectStatePtr(ImGuiTypingSelectState* ptr) => new ImGuiTypingSelectStatePtr(ptr);
		public static implicit operator ImGuiTypingSelectStatePtr(IntPtr ptr) => new ImGuiTypingSelectStatePtr(ptr);
		public static implicit operator ImGuiTypingSelectState*(ImGuiTypingSelectStatePtr nativePtr) => nativePtr.NativePtr;
		/// <summary>
		/// We preserve remaining data for easier debugging<br/>
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImGuiTypingSelectStateClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiTypingSelectStateDestroy(NativePtr);
		}

		public void ImGuiTypingSelectStateConstruct()
		{
			ImGuiNative.ImGuiTypingSelectStateImGuiTypingSelectStateConstruct(NativePtr);
		}

		public ImGuiTypingSelectStatePtr ImGuiTypingSelectState()
		{
			return ImGuiNative.ImGuiTypingSelectStateImGuiTypingSelectState();
		}

	}
}
