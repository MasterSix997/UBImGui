using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Stacked color modifier, backup of modified data so we can restore it<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiColorMod
	{
		public ImGuiCol Col;
		public Vector4 BackupValue;
	}

	/// <summary>
	/// Stacked color modifier, backup of modified data so we can restore it<br/>
	/// </summary>
	public unsafe partial struct ImGuiColorModPtr
	{
		public ImGuiColorMod* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiColorMod this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiCol Col => ref Unsafe.AsRef<ImGuiCol>(&NativePtr->Col);
		public ref Vector4 BackupValue => ref Unsafe.AsRef<Vector4>(&NativePtr->BackupValue);
		public ImGuiColorModPtr(ImGuiColorMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiColorModPtr(IntPtr nativePtr) => NativePtr = (ImGuiColorMod*)nativePtr;
		public static implicit operator ImGuiColorModPtr(ImGuiColorMod* ptr) => new ImGuiColorModPtr(ptr);
		public static implicit operator ImGuiColorModPtr(IntPtr ptr) => new ImGuiColorModPtr(ptr);
		public static implicit operator ImGuiColorMod*(ImGuiColorModPtr nativePtr) => nativePtr.NativePtr;
	}
}
