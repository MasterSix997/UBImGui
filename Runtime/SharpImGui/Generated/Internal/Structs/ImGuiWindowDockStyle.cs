using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// We don't store style.Alpha: dock_node-&gt;LastBgColor embeds it and otherwise it would only affect the docking tab, which intuitively I would say we don't want to.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowDockStyle
	{
		public uint Colors_0;
		public uint Colors_1;
		public uint Colors_2;
		public uint Colors_3;
		public uint Colors_4;
		public uint Colors_5;
		public uint Colors_6;
		public uint Colors_7;
	}

	/// <summary>
	/// We don't store style.Alpha: dock_node-&gt;LastBgColor embeds it and otherwise it would only affect the docking tab, which intuitively I would say we don't want to.<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowDockStylePtr
	{
		public ImGuiWindowDockStyle* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindowDockStyle this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public Span<uint> Colors => new Span<uint>(&NativePtr->Colors_0, 8);
		public ImGuiWindowDockStylePtr(ImGuiWindowDockStyle* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowDockStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowDockStyle*)nativePtr;
		public static implicit operator ImGuiWindowDockStylePtr(ImGuiWindowDockStyle* ptr) => new ImGuiWindowDockStylePtr(ptr);
		public static implicit operator ImGuiWindowDockStylePtr(IntPtr ptr) => new ImGuiWindowDockStylePtr(ptr);
		public static implicit operator ImGuiWindowDockStyle*(ImGuiWindowDockStylePtr nativePtr) => nativePtr.NativePtr;
	}
}
