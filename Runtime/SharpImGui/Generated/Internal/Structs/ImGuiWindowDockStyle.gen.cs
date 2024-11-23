using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>We don't store style.Alpha: dock_node-&gt;LastBgColor embeds it and otherwise it would only affect the docking tab, which intuitively I would say we don't want to.</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowDockStyle
	{
		public fixed uint Colors[8];
	}

	/// <summary>
	/// <para>We don't store style.Alpha: dock_node-&gt;LastBgColor embeds it and otherwise it would only affect the docking tab, which intuitively I would say we don't want to.</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowDockStylePtr
	{
		public ImGuiWindowDockStyle* NativePtr { get; }
		public ImGuiWindowDockStylePtr(ImGuiWindowDockStyle* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowDockStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowDockStyle*)nativePtr;
		public static implicit operator ImGuiWindowDockStylePtr(ImGuiWindowDockStyle* nativePtr) => new ImGuiWindowDockStylePtr(nativePtr);
		public static implicit operator ImGuiWindowDockStyle* (ImGuiWindowDockStylePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiWindowDockStylePtr(IntPtr nativePtr) => new ImGuiWindowDockStylePtr(nativePtr);

		public RangeAccessor<uint> Colors => new RangeAccessor<uint>(NativePtr->Colors, 8);
	}
}
