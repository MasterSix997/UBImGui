using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiDataTypeStorage
	{
		/// <summary>
		/// Opaque storage to fit any data up to ImGuiDataType_COUNT
		/// </summary>
		public fixed byte Data[8];
	}

	public unsafe partial struct ImGuiDataTypeStoragePtr
	{
		public ImGuiDataTypeStorage* NativePtr { get; }
		public ImGuiDataTypeStoragePtr(ImGuiDataTypeStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiDataTypeStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeStorage*)nativePtr;
		public static implicit operator ImGuiDataTypeStoragePtr(ImGuiDataTypeStorage* nativePtr) => new ImGuiDataTypeStoragePtr(nativePtr);
		public static implicit operator ImGuiDataTypeStorage* (ImGuiDataTypeStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiDataTypeStoragePtr(IntPtr nativePtr) => new ImGuiDataTypeStoragePtr(nativePtr);

		/// <summary>
		/// Opaque storage to fit any data up to ImGuiDataType_COUNT
		/// </summary>
		public RangeAccessor<byte> Data => new RangeAccessor<byte>(NativePtr->Data, 8);
	}
}
