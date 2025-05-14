using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Type information associated to one ImGuiDataType. Retrieve with DataTypeGetInfo().<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDataTypeInfo
	{
		/// <summary>
		/// Size in bytes<br/>
		/// </summary>
		public uint Size;
		/// <summary>
		/// Short descriptive name for the type, for debugging<br/>
		/// </summary>
		public unsafe byte* Name;
		/// <summary>
		/// Default printf format for the type<br/>
		/// </summary>
		public unsafe byte* PrintFmt;
		/// <summary>
		/// Default scanf format for the type<br/>
		/// </summary>
		public unsafe byte* ScanFmt;
	}

	/// <summary>
	/// Type information associated to one ImGuiDataType. Retrieve with DataTypeGetInfo().<br/>
	/// </summary>
	public unsafe partial struct ImGuiDataTypeInfoPtr
	{
		public ImGuiDataTypeInfo* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDataTypeInfo this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Size in bytes<br/>
		/// </summary>
		public ref uint Size => ref Unsafe.AsRef<uint>(&NativePtr->Size);
		/// <summary>
		/// Short descriptive name for the type, for debugging<br/>
		/// </summary>
		public IntPtr Name { get => (IntPtr)NativePtr->Name; set => NativePtr->Name = (byte*)value; }
		/// <summary>
		/// Default printf format for the type<br/>
		/// </summary>
		public IntPtr PrintFmt { get => (IntPtr)NativePtr->PrintFmt; set => NativePtr->PrintFmt = (byte*)value; }
		/// <summary>
		/// Default scanf format for the type<br/>
		/// </summary>
		public IntPtr ScanFmt { get => (IntPtr)NativePtr->ScanFmt; set => NativePtr->ScanFmt = (byte*)value; }
		public ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiDataTypeInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDataTypeInfo*)nativePtr;
		public static implicit operator ImGuiDataTypeInfoPtr(ImGuiDataTypeInfo* ptr) => new ImGuiDataTypeInfoPtr(ptr);
		public static implicit operator ImGuiDataTypeInfoPtr(IntPtr ptr) => new ImGuiDataTypeInfoPtr(ptr);
		public static implicit operator ImGuiDataTypeInfo*(ImGuiDataTypeInfoPtr nativePtr) => nativePtr.NativePtr;
	}
}
