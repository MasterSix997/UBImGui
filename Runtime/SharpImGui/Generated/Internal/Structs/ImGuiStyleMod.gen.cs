using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.</para>
	/// </summary>
	public unsafe partial struct ImGuiStyleMod
	{
		public ImGuiStyleVar VarIdx;
	}

	/// <summary>
	/// <para>Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.</para>
	/// </summary>
	public unsafe partial struct ImGuiStyleModPtr
	{
		public ImGuiStyleMod* NativePtr { get; }
		public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
		public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => new ImGuiStyleModPtr(nativePtr);
		public static implicit operator ImGuiStyleMod* (ImGuiStyleModPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiStyleModPtr(IntPtr nativePtr) => new ImGuiStyleModPtr(nativePtr);

		public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);
	}
}
