using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>[Internal]</para>
	/// </summary>
	public unsafe partial struct ImGuiTextRange
	{
		public byte* b;
		public byte* e;
	}

	/// <summary>
	/// <para>[Internal]</para>
	/// </summary>
	public unsafe partial struct ImGuiTextRangePtr
	{
		public ImGuiTextRange* NativePtr { get; }
		public ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiTextRange*)nativePtr;
		public static implicit operator ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => new ImGuiTextRangePtr(nativePtr);
		public static implicit operator ImGuiTextRange* (ImGuiTextRangePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTextRangePtr(IntPtr nativePtr) => new ImGuiTextRangePtr(nativePtr);

		public IntPtr b { get => (IntPtr)NativePtr->b; set => NativePtr->b = (byte*)value; }

		public IntPtr e { get => (IntPtr)NativePtr->e; set => NativePtr->e = (byte*)value; }

		public bool empty()
		{
			var ret = ImGuiNative.ImGuiTextFilter_ImGuiTextRange_empty(NativePtr);
			return ret != 0;
		}

		public void split(byte separator, ImVector* _out)
		{
			ImGuiNative.ImGuiTextFilter_ImGuiTextRange_split(NativePtr, separator, _out);
		}
	}
}
