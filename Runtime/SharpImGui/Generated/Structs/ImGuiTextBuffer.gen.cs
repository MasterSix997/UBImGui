using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Helper: Growable text buffer for logging/accumulating text</para>
	/// <para>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')</para>
	/// </summary>
	public unsafe partial struct ImGuiTextBuffer
	{
		public ImVector Buf;
	}

	/// <summary>
	/// <para>Helper: Growable text buffer for logging/accumulating text</para>
	/// <para>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')</para>
	/// </summary>
	public unsafe partial struct ImGuiTextBufferPtr
	{
		public ImGuiTextBuffer* NativePtr { get; }
		public ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextBufferPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextBuffer*)nativePtr;
		public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => new ImGuiTextBufferPtr(nativePtr);
		public static implicit operator ImGuiTextBuffer* (ImGuiTextBufferPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTextBufferPtr(IntPtr nativePtr) => new ImGuiTextBufferPtr(nativePtr);

		public ImVector<byte> Buf => new ImVector<byte>(NativePtr->Buf);

		public string begin()
		{
			var ret = ImGuiNative.ImGuiTextBuffer_begin(NativePtr);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator
		/// </summary>
		public string end()
		{
			var ret = ImGuiNative.ImGuiTextBuffer_end(NativePtr);
			return Util.StringFromPtr(ret);
		}

		public int size()
		{
			var ret = ImGuiNative.ImGuiTextBuffer_size(NativePtr);
			return ret;
		}

		public bool empty()
		{
			var ret = ImGuiNative.ImGuiTextBuffer_empty(NativePtr);
			return ret != 0;
		}

		public void clear()
		{
			ImGuiNative.ImGuiTextBuffer_clear(NativePtr);
		}

		public void reserve(int capacity)
		{
			ImGuiNative.ImGuiTextBuffer_reserve(NativePtr, capacity);
		}

		public void append(ReadOnlySpan<char> str)
		{
			// Marshaling 'str' to native string
			byte* native_str;
			var str_byteCount = 0;
			if (str != null)
			{
				str_byteCount = Encoding.UTF8.GetByteCount(str);
				if (str_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str = Util.Allocate(str_byteCount + 1);
				}
				else
				{
					var native_str_stackBytes = stackalloc byte[str_byteCount + 1];
					native_str = native_str_stackBytes;
				}
				var str_offset = Util.GetUtf8(str, native_str, str_byteCount);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			byte* str_end = null;

			ImGuiNative.ImGuiTextBuffer_append(NativePtr, native_str, str_end);
			if (str_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str);
			}
		}
		public void append(ReadOnlySpan<char> str, ReadOnlySpan<char> str_end)
		{
			// Marshaling 'str' to native string
			byte* native_str;
			var str_byteCount = 0;
			if (str != null)
			{
				str_byteCount = Encoding.UTF8.GetByteCount(str);
				if (str_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str = Util.Allocate(str_byteCount + 1);
				}
				else
				{
					var native_str_stackBytes = stackalloc byte[str_byteCount + 1];
					native_str = native_str_stackBytes;
				}
				var str_offset = Util.GetUtf8(str, native_str, str_byteCount);
				native_str[str_offset] = 0;
			}
			else native_str = null;

			// Marshaling 'str_end' to native string
			byte* native_str_end;
			var str_end_byteCount = 0;
			if (str_end != null)
			{
				str_end_byteCount = Encoding.UTF8.GetByteCount(str_end);
				if (str_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_end = Util.Allocate(str_end_byteCount + 1);
				}
				else
				{
					var native_str_end_stackBytes = stackalloc byte[str_end_byteCount + 1];
					native_str_end = native_str_end_stackBytes;
				}
				var str_end_offset = Util.GetUtf8(str_end, native_str_end, str_end_byteCount);
				native_str_end[str_end_offset] = 0;
			}
			else native_str_end = null;

			ImGuiNative.ImGuiTextBuffer_append(NativePtr, native_str, native_str_end);
			if (str_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str);
			}
			if (str_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_end);
			}
		}

		public void appendf(ReadOnlySpan<char> fmt)
		{
			// Marshaling 'fmt' to native string
			byte* native_fmt;
			var fmt_byteCount = 0;
			if (fmt != null)
			{
				fmt_byteCount = Encoding.UTF8.GetByteCount(fmt);
				if (fmt_byteCount > Util.StackAllocationSizeLimit)
				{
					native_fmt = Util.Allocate(fmt_byteCount + 1);
				}
				else
				{
					var native_fmt_stackBytes = stackalloc byte[fmt_byteCount + 1];
					native_fmt = native_fmt_stackBytes;
				}
				var fmt_offset = Util.GetUtf8(fmt, native_fmt, fmt_byteCount);
				native_fmt[fmt_offset] = 0;
			}
			else native_fmt = null;

			ImGuiNative.ImGuiTextBuffer_appendf(NativePtr, native_fmt);
			if (fmt_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_fmt);
			}
		}
	}
}
