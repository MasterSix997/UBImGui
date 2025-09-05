using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() ~ 16<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnSettings
	{
		public float WidthOrWeight;
		public uint UserID;
		public short Index;
		public short DisplayOrder;
		public short SortOrder;
		public byte SortDirection;
		/// <summary>
		/// "Visible" in ini file<br/>
		/// </summary>
		public sbyte IsEnabled;
		public byte IsStretch;
	}

	/// <summary>
	/// sizeof() ~ 16<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnSettingsPtr
	{
		public ImGuiTableColumnSettings* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableColumnSettings this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float WidthOrWeight => ref Unsafe.AsRef<float>(&NativePtr->WidthOrWeight);
		public ref uint UserID => ref Unsafe.AsRef<uint>(&NativePtr->UserID);
		public ref short Index => ref Unsafe.AsRef<short>(&NativePtr->Index);
		public ref short DisplayOrder => ref Unsafe.AsRef<short>(&NativePtr->DisplayOrder);
		public ref short SortOrder => ref Unsafe.AsRef<short>(&NativePtr->SortOrder);
		public ref bool SortDirection => ref Unsafe.AsRef<bool>(&NativePtr->SortDirection);
		/// <summary>
		/// "Visible" in ini file<br/>
		/// </summary>
		public ref sbyte IsEnabled => ref Unsafe.AsRef<sbyte>(&NativePtr->IsEnabled);
		public ref bool IsStretch => ref Unsafe.AsRef<bool>(&NativePtr->IsStretch);
		public ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnSettings*)nativePtr;
		public static implicit operator ImGuiTableColumnSettingsPtr(ImGuiTableColumnSettings* ptr) => new ImGuiTableColumnSettingsPtr(ptr);
		public static implicit operator ImGuiTableColumnSettingsPtr(IntPtr ptr) => new ImGuiTableColumnSettingsPtr(ptr);
		public static implicit operator ImGuiTableColumnSettings*(ImGuiTableColumnSettingsPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTableColumnSettingsDestroy(NativePtr);
		}

		public void ImGuiTableColumnSettingsConstruct()
		{
			ImGuiNative.ImGuiTableColumnSettingsImGuiTableColumnSettingsConstruct(NativePtr);
		}

		public ImGuiTableColumnSettingsPtr ImGuiTableColumnSettings()
		{
			return ImGuiNative.ImGuiTableColumnSettingsImGuiTableColumnSettings();
		}

	}
}
