using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Type information associated to one ImGuiDataType. Retrieve with DataTypeGetInfo().</para>
	/// </summary>
	public unsafe partial struct ImGuiDataTypeInfo
	{
		/// <summary>
		/// Size in bytes
		/// </summary>
		public uint Size;
		/// <summary>
		/// Short descriptive name for the type, for debugging
		/// </summary>
		public byte* Name;
		/// <summary>
		/// Default printf format for the type
		/// </summary>
		public byte* PrintFmt;
		/// <summary>
		/// Default scanf format for the type
		/// </summary>
		public byte* ScanFmt;
	}

	/// <summary>
	/// <para>Type information associated to one ImGuiDataType. Retrieve with DataTypeGetInfo().</para>
	/// </summary>
	public unsafe partial struct ImGuiDataTypeInfoPtr
	{
		public ImGuiDataTypeInfo* NativePtr { get; }
		public ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiDataTypeInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeInfo*)nativePtr;
		public static implicit operator ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* nativePtr) => new ImGuiDataTypeInfoPtr(nativePtr);
		public static implicit operator ImGuiDataTypeInfo* (ImGuiDataTypeInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiDataTypeInfoPtr(IntPtr nativePtr) => new ImGuiDataTypeInfoPtr(nativePtr);

		/// <summary>
		/// Size in bytes
		/// </summary>
		public ref uint Size => ref Unsafe.AsRef<uint>(&NativePtr->Size);

		/// <summary>
		/// Short descriptive name for the type, for debugging
		/// </summary>
		public NullTerminatedString Name => new NullTerminatedString(NativePtr->Name);

		/// <summary>
		/// Default printf format for the type
		/// </summary>
		public IntPtr PrintFmt { get => (IntPtr)NativePtr->PrintFmt; set => NativePtr->PrintFmt = (byte*)value; }

		/// <summary>
		/// Default scanf format for the type
		/// </summary>
		public IntPtr ScanFmt { get => (IntPtr)NativePtr->ScanFmt; set => NativePtr->ScanFmt = (byte*)value; }
	}
}
