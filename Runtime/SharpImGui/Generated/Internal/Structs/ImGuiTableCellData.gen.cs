using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Transient cell data stored per row.</para>
	/// <para>sizeof() ~ 6 bytes</para>
	/// </summary>
	public unsafe partial struct ImGuiTableCellData
	{
		/// <summary>
		/// Actual color
		/// </summary>
		public uint BgColor;
		/// <summary>
		/// Column number
		/// </summary>
		public short Column;
	}

	/// <summary>
	/// <para>Transient cell data stored per row.</para>
	/// <para>sizeof() ~ 6 bytes</para>
	/// </summary>
	public unsafe partial struct ImGuiTableCellDataPtr
	{
		public ImGuiTableCellData* NativePtr { get; }
		public ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableCellDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableCellData*)nativePtr;
		public static implicit operator ImGuiTableCellDataPtr(ImGuiTableCellData* nativePtr) => new ImGuiTableCellDataPtr(nativePtr);
		public static implicit operator ImGuiTableCellData* (ImGuiTableCellDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableCellDataPtr(IntPtr nativePtr) => new ImGuiTableCellDataPtr(nativePtr);

		/// <summary>
		/// Actual color
		/// </summary>
		public ref uint BgColor => ref Unsafe.AsRef<uint>(&NativePtr->BgColor);

		/// <summary>
		/// Column number
		/// </summary>
		public ref short Column => ref Unsafe.AsRef<short>(&NativePtr->Column);
	}
}
