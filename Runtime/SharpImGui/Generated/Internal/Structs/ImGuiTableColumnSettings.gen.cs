using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>sizeof() ~ 12</para>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSettings
	{
		public float WidthOrWeight;
		public uint UserID;
		public short Index;
		public short DisplayOrder;
		public short SortOrder;
		public byte SortDirection;
		/// <summary>
		/// "Visible" in ini file
		/// </summary>
		public byte IsEnabled;
		public byte IsStretch;
	}

	/// <summary>
	/// <para>sizeof() ~ 12</para>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSettingsPtr
	{
		public ImGuiTableColumnSettings* NativePtr { get; }
		public ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSettings*)nativePtr;
		public static implicit operator ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => new ImGuiTableColumnSettingsPtr(nativePtr);
		public static implicit operator ImGuiTableColumnSettings* (ImGuiTableColumnSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => new ImGuiTableColumnSettingsPtr(nativePtr);

		public ref float WidthOrWeight => ref Unsafe.AsRef<float>(&NativePtr->WidthOrWeight);

		public ref uint UserID => ref Unsafe.AsRef<uint>(&NativePtr->UserID);

		public ref short Index => ref Unsafe.AsRef<short>(&NativePtr->Index);

		public ref short DisplayOrder => ref Unsafe.AsRef<short>(&NativePtr->DisplayOrder);

		public ref short SortOrder => ref Unsafe.AsRef<short>(&NativePtr->SortOrder);

		public ref bool SortDirection => ref Unsafe.AsRef<bool>(&NativePtr->SortDirection);

		/// <summary>
		/// "Visible" in ini file
		/// </summary>
		public ref bool IsEnabled => ref Unsafe.AsRef<bool>(&NativePtr->IsEnabled);

		public ref bool IsStretch => ref Unsafe.AsRef<bool>(&NativePtr->IsStretch);
	}
}
