using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>This structure is likely to evolve as we add support for incremental atlas updates.</para>
	/// <para>Conceptually this could be in ImGuiPlatformIO, but we are far from ready to make this public.</para>
	/// </summary>
	public unsafe partial struct ImFontBuilderIO
	{
		public IntPtr FontBuilder_Build;
	}

	/// <summary>
	/// <para>This structure is likely to evolve as we add support for incremental atlas updates.</para>
	/// <para>Conceptually this could be in ImGuiPlatformIO, but we are far from ready to make this public.</para>
	/// </summary>
	public unsafe partial struct ImFontBuilderIOPtr
	{
		public ImFontBuilderIO* NativePtr { get; }
		public ImFontBuilderIOPtr(ImFontBuilderIO* nativePtr) => NativePtr = nativePtr;
		public ImFontBuilderIOPtr(IntPtr nativePtr) => NativePtr = (ImFontBuilderIO*)nativePtr;
		public static implicit operator ImFontBuilderIOPtr(ImFontBuilderIO* nativePtr) => new ImFontBuilderIOPtr(nativePtr);
		public static implicit operator ImFontBuilderIO* (ImFontBuilderIOPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImFontBuilderIOPtr(IntPtr nativePtr) => new ImFontBuilderIOPtr(nativePtr);

		public FontBuilder_BuildDelegate FontBuilder_Build
		{
			get => (FontBuilder_BuildDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->FontBuilder_Build, typeof(FontBuilder_BuildDelegate));
			set => NativePtr->FontBuilder_Build = Marshal.GetFunctionPointerForDelegate(value);
		}
	}
}
