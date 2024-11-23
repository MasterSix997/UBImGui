using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Stacked color modifier, backup of modified data so we can restore it</para>
	/// </summary>
	public unsafe partial struct ImGuiColorMod
	{
		public ImGuiCol Col;
		public Vector4 BackupValue;
	}

	/// <summary>
	/// <para>Stacked color modifier, backup of modified data so we can restore it</para>
	/// </summary>
	public unsafe partial struct ImGuiColorModPtr
	{
		public ImGuiColorMod* NativePtr { get; }
		public ImGuiColorModPtr(ImGuiColorMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiColorModPtr(IntPtr nativePtr) => NativePtr = (ImGuiColorMod*)nativePtr;
		public static implicit operator ImGuiColorModPtr(ImGuiColorMod* nativePtr) => new ImGuiColorModPtr(nativePtr);
		public static implicit operator ImGuiColorMod* (ImGuiColorModPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiColorModPtr(IntPtr nativePtr) => new ImGuiColorModPtr(nativePtr);

		public ref ImGuiCol Col => ref Unsafe.AsRef<ImGuiCol>(&NativePtr->Col);

		public ref Vector4 BackupValue => ref Unsafe.AsRef<Vector4>(&NativePtr->BackupValue);
	}
}
