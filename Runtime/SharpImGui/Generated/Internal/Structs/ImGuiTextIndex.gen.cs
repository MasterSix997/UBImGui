using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Helper: ImGuiTextIndex</para>
	/// <para>Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.</para>
	/// </summary>
	public unsafe partial struct ImGuiTextIndex
	{
		public ImVector LineOffsets;
		/// <summary>
		/// Because we don't own text buffer we need to maintain EndOffset (may bake in LineOffsets?)
		/// </summary>
		public int EndOffset;
	}

	/// <summary>
	/// <para>Helper: ImGuiTextIndex</para>
	/// <para>Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.</para>
	/// </summary>
	public unsafe partial struct ImGuiTextIndexPtr
	{
		public ImGuiTextIndex* NativePtr { get; }
		public ImGuiTextIndexPtr(ImGuiTextIndex* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextIndex*)nativePtr;
		public static implicit operator ImGuiTextIndexPtr(ImGuiTextIndex* nativePtr) => new ImGuiTextIndexPtr(nativePtr);
		public static implicit operator ImGuiTextIndex* (ImGuiTextIndexPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTextIndexPtr(IntPtr nativePtr) => new ImGuiTextIndexPtr(nativePtr);

		public ImVector<int> LineOffsets => new ImVector<int>(NativePtr->LineOffsets);

		/// <summary>
		/// Because we don't own text buffer we need to maintain EndOffset (may bake in LineOffsets?)
		/// </summary>
		public ref int EndOffset => ref Unsafe.AsRef<int>(&NativePtr->EndOffset);

		public void clear()
		{
			ImGuiInternalNative.ImGuiTextIndex_clear(NativePtr);
		}

		public int size()
		{
			var ret = ImGuiInternalNative.ImGuiTextIndex_size(NativePtr);
			return ret;
		}

		public void append(ReadOnlySpan<char> _base, int old_size, int new_size)
		{
			// Marshaling '_base' to native string
			byte* native__base;
			var _base_byteCount = 0;
			if (_base != null)
			{
				_base_byteCount = Encoding.UTF8.GetByteCount(_base);
				if (_base_byteCount > Util.StackAllocationSizeLimit)
				{
					native__base = Util.Allocate(_base_byteCount + 1);
				}
				else
				{
					var native__base_stackBytes = stackalloc byte[_base_byteCount + 1];
					native__base = native__base_stackBytes;
				}
				var _base_offset = Util.GetUtf8(_base, native__base, _base_byteCount);
				native__base[_base_offset] = 0;
			}
			else native__base = null;

			ImGuiInternalNative.ImGuiTextIndex_append(NativePtr, native__base, old_size, new_size);
			if (_base_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native__base);
			}
		}
	}
}
