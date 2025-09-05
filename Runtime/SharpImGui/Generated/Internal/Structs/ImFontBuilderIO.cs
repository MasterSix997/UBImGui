using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// This structure is likely to evolve as we add support for incremental atlas updates.<br/>Conceptually this could be in ImGuiPlatformIO, but we are far from ready to make this public.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImFontBuilderIO
	{
		public unsafe void* FontBuilderBuild;
	}

	/// <summary>
	/// This structure is likely to evolve as we add support for incremental atlas updates.<br/>Conceptually this could be in ImGuiPlatformIO, but we are far from ready to make this public.<br/>
	/// </summary>
	public unsafe partial struct ImFontBuilderIOPtr
	{
		public ImFontBuilderIO* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImFontBuilderIO this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public FontBuilderBuild FontBuilderBuild { get => (FontBuilderBuild) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->FontBuilderBuild, typeof(FontBuilderBuild)); set => NativePtr->FontBuilderBuild = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		public ImFontBuilderIOPtr(ImFontBuilderIO* nativePtr) => NativePtr = nativePtr;
		public ImFontBuilderIOPtr(IntPtr nativePtr) => NativePtr = (ImFontBuilderIO*)nativePtr;
		public static implicit operator ImFontBuilderIOPtr(ImFontBuilderIO* ptr) => new ImFontBuilderIOPtr(ptr);
		public static implicit operator ImFontBuilderIOPtr(IntPtr ptr) => new ImFontBuilderIOPtr(ptr);
		public static implicit operator ImFontBuilderIO*(ImFontBuilderIOPtr nativePtr) => nativePtr.NativePtr;
	}
}
