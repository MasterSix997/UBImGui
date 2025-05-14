using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Transient cell data stored per row.<br/>sizeof() ~ 6 bytes<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableCellData
	{
		/// <summary>
		/// Actual color<br/>
		/// </summary>
		public uint BgColor;
		/// <summary>
		/// Column number<br/>
		/// </summary>
		public short Column;
	}

	/// <summary>
	/// Transient cell data stored per row.<br/>sizeof() ~ 6 bytes<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableCellDataPtr
	{
		public ImGuiTableCellData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableCellData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Actual color<br/>
		/// </summary>
		public ref uint BgColor => ref Unsafe.AsRef<uint>(&NativePtr->BgColor);
		/// <summary>
		/// Column number<br/>
		/// </summary>
		public ref short Column => ref Unsafe.AsRef<short>(&NativePtr->Column);
		public ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableCellDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableCellData*)nativePtr;
		public static implicit operator ImGuiTableCellDataPtr(ImGuiTableCellData* ptr) => new ImGuiTableCellDataPtr(ptr);
		public static implicit operator ImGuiTableCellDataPtr(IntPtr ptr) => new ImGuiTableCellDataPtr(ptr);
		public static implicit operator ImGuiTableCellData*(ImGuiTableCellDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
