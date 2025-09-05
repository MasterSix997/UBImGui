using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumnsSettings
	{
	}

	public unsafe partial struct ImGuiTableColumnsSettingsPtr
	{
		public ImGuiTableColumnsSettings* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableColumnsSettings this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ImGuiTableColumnsSettingsPtr(ImGuiTableColumnsSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnsSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumnsSettings*)nativePtr;
		public static implicit operator ImGuiTableColumnsSettingsPtr(ImGuiTableColumnsSettings* ptr) => new ImGuiTableColumnsSettingsPtr(ptr);
		public static implicit operator ImGuiTableColumnsSettingsPtr(IntPtr ptr) => new ImGuiTableColumnsSettingsPtr(ptr);
		public static implicit operator ImGuiTableColumnsSettings*(ImGuiTableColumnsSettingsPtr nativePtr) => nativePtr.NativePtr;
	}
}
