using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Parameters for TableAngledHeadersRowEx()</para>
	/// <para>This may end up being refactored for more general purpose.</para>
	/// <para>sizeof() ~ 12 bytes</para>
	/// </summary>
	public unsafe partial struct ImGuiTableHeaderData
	{
		/// <summary>
		/// Column index
		/// </summary>
		public short Index;
		public uint TextColor;
		public uint BgColor0;
		public uint BgColor1;
	}

	/// <summary>
	/// <para>Parameters for TableAngledHeadersRowEx()</para>
	/// <para>This may end up being refactored for more general purpose.</para>
	/// <para>sizeof() ~ 12 bytes</para>
	/// </summary>
	public unsafe partial struct ImGuiTableHeaderDataPtr
	{
		public ImGuiTableHeaderData* NativePtr { get; }
		public ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableHeaderDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableHeaderData*)nativePtr;
		public static implicit operator ImGuiTableHeaderDataPtr(ImGuiTableHeaderData* nativePtr) => new ImGuiTableHeaderDataPtr(nativePtr);
		public static implicit operator ImGuiTableHeaderData* (ImGuiTableHeaderDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableHeaderDataPtr(IntPtr nativePtr) => new ImGuiTableHeaderDataPtr(nativePtr);

		/// <summary>
		/// Column index
		/// </summary>
		public ref short Index => ref Unsafe.AsRef<short>(&NativePtr->Index);

		public ref uint TextColor => ref Unsafe.AsRef<uint>(&NativePtr->TextColor);

		public ref uint BgColor0 => ref Unsafe.AsRef<uint>(&NativePtr->BgColor0);

		public ref uint BgColor1 => ref Unsafe.AsRef<uint>(&NativePtr->BgColor1);
	}
}
