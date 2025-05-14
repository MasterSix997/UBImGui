using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextBuffer
	{
		public ImVector<byte> Buf;
	}

	/// <summary>
	/// Helper: Growable text buffer for logging/accumulating text<br/>(this could be called 'ImGuiTextBuilder' / 'ImGuiStringBuilder')<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextBufferPtr
	{
		public ImGuiTextBuffer* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextBuffer this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<byte> Buf => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->Buf);
		public ImGuiTextBufferPtr(ImGuiTextBuffer* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextBufferPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextBuffer*)nativePtr;
		public static implicit operator ImGuiTextBufferPtr(ImGuiTextBuffer* ptr) => new ImGuiTextBufferPtr(ptr);
		public static implicit operator ImGuiTextBufferPtr(IntPtr ptr) => new ImGuiTextBufferPtr(ptr);
		public static implicit operator ImGuiTextBuffer*(ImGuiTextBufferPtr nativePtr) => nativePtr.NativePtr;
		public void Appendf(ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.ImGuiTextBufferAppendf(NativePtr, nativeFmt);
			}
		}

		public void Appendf(ReadOnlySpan<char> fmt)
		{
			// Marshaling fmt to native string
			byte* nativeFmt;
			var byteCountFmt = 0;
			if (fmt != null && !fmt.IsEmpty)
			{
				byteCountFmt = Encoding.UTF8.GetByteCount(fmt);
				if(byteCountFmt > Utils.MaxStackallocSize)
				{
					nativeFmt = Utils.Alloc<byte>(byteCountFmt + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountFmt + 1];
					nativeFmt = stackallocBytes;
				}
				var offsetFmt = Utils.EncodeStringUTF8(fmt, nativeFmt, byteCountFmt);
				nativeFmt[offsetFmt] = 0;
			}
			else nativeFmt = null;

			ImGuiNative.ImGuiTextBufferAppendf(NativePtr, nativeFmt);
			// Freeing fmt native string
			if (byteCountFmt > Utils.MaxStackallocSize)
				Utils.Free(nativeFmt);
		}

		public void Append(ReadOnlySpan<byte> str, ReadOnlySpan<byte> strEnd)
		{
			fixed (byte* nativeStr = str)
			fixed (byte* nativeStrEnd = strEnd)
			{
				ImGuiNative.ImGuiTextBufferAppend(NativePtr, nativeStr, nativeStrEnd);
			}
		}

		public void Append(ReadOnlySpan<char> str, ReadOnlySpan<char> strEnd)
		{
			// Marshaling str to native string
			byte* nativeStr;
			var byteCountStr = 0;
			if (str != null && !str.IsEmpty)
			{
				byteCountStr = Encoding.UTF8.GetByteCount(str);
				if(byteCountStr > Utils.MaxStackallocSize)
				{
					nativeStr = Utils.Alloc<byte>(byteCountStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr + 1];
					nativeStr = stackallocBytes;
				}
				var offsetStr = Utils.EncodeStringUTF8(str, nativeStr, byteCountStr);
				nativeStr[offsetStr] = 0;
			}
			else nativeStr = null;

			// Marshaling strEnd to native string
			byte* nativeStrEnd;
			var byteCountStrEnd = 0;
			if (strEnd != null && !strEnd.IsEmpty)
			{
				byteCountStrEnd = Encoding.UTF8.GetByteCount(strEnd);
				if(byteCountStrEnd > Utils.MaxStackallocSize)
				{
					nativeStrEnd = Utils.Alloc<byte>(byteCountStrEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStrEnd + 1];
					nativeStrEnd = stackallocBytes;
				}
				var offsetStrEnd = Utils.EncodeStringUTF8(strEnd, nativeStrEnd, byteCountStrEnd);
				nativeStrEnd[offsetStrEnd] = 0;
			}
			else nativeStrEnd = null;

			ImGuiNative.ImGuiTextBufferAppend(NativePtr, nativeStr, nativeStrEnd);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
			// Freeing strEnd native string
			if (byteCountStrEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeStrEnd);
		}

		public void Append(ReadOnlySpan<byte> str)
		{
			// defining omitted parameters
			byte* strEnd = null;
			fixed (byte* nativeStr = str)
			{
				ImGuiNative.ImGuiTextBufferAppend(NativePtr, nativeStr, strEnd);
			}
		}

		public void Append(ReadOnlySpan<char> str)
		{
			// defining omitted parameters
			byte* strEnd = null;
			// Marshaling str to native string
			byte* nativeStr;
			var byteCountStr = 0;
			if (str != null && !str.IsEmpty)
			{
				byteCountStr = Encoding.UTF8.GetByteCount(str);
				if(byteCountStr > Utils.MaxStackallocSize)
				{
					nativeStr = Utils.Alloc<byte>(byteCountStr + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountStr + 1];
					nativeStr = stackallocBytes;
				}
				var offsetStr = Utils.EncodeStringUTF8(str, nativeStr, byteCountStr);
				nativeStr[offsetStr] = 0;
			}
			else nativeStr = null;

			ImGuiNative.ImGuiTextBufferAppend(NativePtr, nativeStr, strEnd);
			// Freeing str native string
			if (byteCountStr > Utils.MaxStackallocSize)
				Utils.Free(nativeStr);
		}

		public string CStr()
		{
			var result = ImGuiNative.ImGuiTextBufferCStr(NativePtr);
			return Utils.DecodeStringUTF8(result);
		}

		public void Reserve(int capacity)
		{
			ImGuiNative.ImGuiTextBufferReserve(NativePtr, capacity);
		}

		/// <summary>
		/// Similar to resize(0) on ImVector: empty string but don't free buffer.<br/>
		/// </summary>
		public void Resize(int size)
		{
			ImGuiNative.ImGuiTextBufferResize(NativePtr, size);
		}

		public void Clear()
		{
			ImGuiNative.ImGuiTextBufferClear(NativePtr);
		}

		public bool Empty()
		{
			var result = ImGuiNative.ImGuiTextBufferEmpty(NativePtr);
			return result != 0;
		}

		public int Size()
		{
			return ImGuiNative.ImGuiTextBufferSize(NativePtr);
		}

		/// <summary>
		/// Buf is zero-terminated, so end() will point on the zero-terminator<br/>
		/// </summary>
		public string End()
		{
			var result = ImGuiNative.ImGuiTextBufferEnd(NativePtr);
			return Utils.DecodeStringUTF8(result);
		}

		public string Begin()
		{
			var result = ImGuiNative.ImGuiTextBufferBegin(NativePtr);
			return Utils.DecodeStringUTF8(result);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiTextBufferDestroy(NativePtr);
		}

		public void ImGuiTextBufferConstruct()
		{
			ImGuiNative.ImGuiTextBufferImGuiTextBufferConstruct(NativePtr);
		}

		public ImGuiTextBufferPtr ImGuiTextBuffer()
		{
			return ImGuiNative.ImGuiTextBufferImGuiTextBuffer();
		}

	}
}
