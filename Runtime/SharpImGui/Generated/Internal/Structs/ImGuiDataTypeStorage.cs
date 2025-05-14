using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataTypeStorage
	{
		/// <summary>
		/// Opaque storage to fit any data up to ImGuiDataType_COUNT<br/>
		/// </summary>
		public byte Data_0;
		public byte Data_1;
		public byte Data_2;
		public byte Data_3;
		public byte Data_4;
		public byte Data_5;
		public byte Data_6;
		public byte Data_7;
	}

	public unsafe partial struct ImGuiDataTypeStoragePtr
	{
		public ImGuiDataTypeStorage* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDataTypeStorage this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Opaque storage to fit any data up to ImGuiDataType_COUNT<br/>
		/// </summary>
		public Span<byte> Data => new Span<byte>(&NativePtr->Data_0, 8);
		public ImGuiDataTypeStoragePtr(ImGuiDataTypeStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiDataTypeStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeStorage*)nativePtr;
		public static implicit operator ImGuiDataTypeStoragePtr(ImGuiDataTypeStorage* ptr) => new ImGuiDataTypeStoragePtr(ptr);
		public static implicit operator ImGuiDataTypeStoragePtr(IntPtr ptr) => new ImGuiDataTypeStoragePtr(ptr);
		public static implicit operator ImGuiDataTypeStorage*(ImGuiDataTypeStoragePtr nativePtr) => nativePtr.NativePtr;
	}
}
