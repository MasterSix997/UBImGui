using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImGuiTextIndex<br/>Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextIndex
	{
		public ImVector<int> LineOffsets;
		/// <summary>
		/// Because we don't own text buffer we need to maintain EndOffset (may bake in LineOffsets?)<br/>
		/// </summary>
		public int EndOffset;
	}

	/// <summary>
	/// Helper: ImGuiTextIndex<br/>Maintain a line index for a text buffer. This is a strong candidate to be moved into the public API.<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextIndexPtr
	{
		public ImGuiTextIndex* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextIndex this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImVector<int> LineOffsets => ref Unsafe.AsRef<ImVector<int>>(&NativePtr->LineOffsets);
		/// <summary>
		/// Because we don't own text buffer we need to maintain EndOffset (may bake in LineOffsets?)<br/>
		/// </summary>
		public ref int EndOffset => ref Unsafe.AsRef<int>(&NativePtr->EndOffset);
		public ImGuiTextIndexPtr(ImGuiTextIndex* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextIndexPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextIndex*)nativePtr;
		public static implicit operator ImGuiTextIndexPtr(ImGuiTextIndex* ptr) => new ImGuiTextIndexPtr(ptr);
		public static implicit operator ImGuiTextIndexPtr(IntPtr ptr) => new ImGuiTextIndexPtr(ptr);
		public static implicit operator ImGuiTextIndex*(ImGuiTextIndexPtr nativePtr) => nativePtr.NativePtr;
		public void Append(ReadOnlySpan<byte> _base, int oldSize, int newSize)
		{
			fixed (byte* nativeBase = _base)
			{
				ImGuiNative.ImGuiTextIndexAppend(NativePtr, nativeBase, oldSize, newSize);
			}
		}

		public void Append(ReadOnlySpan<char> _base, int oldSize, int newSize)
		{
			// Marshaling _base to native string
			byte* nativeBase;
			var byteCountBase = 0;
			if (_base != null && !_base.IsEmpty)
			{
				byteCountBase = Encoding.UTF8.GetByteCount(_base);
				if(byteCountBase > Utils.MaxStackallocSize)
				{
					nativeBase = Utils.Alloc<byte>(byteCountBase + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBase + 1];
					nativeBase = stackallocBytes;
				}
				var offsetBase = Utils.EncodeStringUTF8(_base, nativeBase, byteCountBase);
				nativeBase[offsetBase] = 0;
			}
			else nativeBase = null;

			ImGuiNative.ImGuiTextIndexAppend(NativePtr, nativeBase, oldSize, newSize);
			// Freeing _base native string
			if (byteCountBase > Utils.MaxStackallocSize)
				Utils.Free(nativeBase);
		}

		public string GetLineEnd(ReadOnlySpan<byte> _base, int n)
		{
			fixed (byte* nativeBase = _base)
			{
				var result = ImGuiNative.ImGuiTextIndexGetLineEnd(NativePtr, nativeBase, n);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public string GetLineEnd(ReadOnlySpan<char> _base, int n)
		{
			// Marshaling _base to native string
			byte* nativeBase;
			var byteCountBase = 0;
			if (_base != null && !_base.IsEmpty)
			{
				byteCountBase = Encoding.UTF8.GetByteCount(_base);
				if(byteCountBase > Utils.MaxStackallocSize)
				{
					nativeBase = Utils.Alloc<byte>(byteCountBase + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBase + 1];
					nativeBase = stackallocBytes;
				}
				var offsetBase = Utils.EncodeStringUTF8(_base, nativeBase, byteCountBase);
				nativeBase[offsetBase] = 0;
			}
			else nativeBase = null;

			var result = ImGuiNative.ImGuiTextIndexGetLineEnd(NativePtr, nativeBase, n);
			// Freeing _base native string
			if (byteCountBase > Utils.MaxStackallocSize)
				Utils.Free(nativeBase);
			return Utils.DecodeStringUTF8(result);
		}

		public string GetLineBegin(ReadOnlySpan<byte> _base, int n)
		{
			fixed (byte* nativeBase = _base)
			{
				var result = ImGuiNative.ImGuiTextIndexGetLineBegin(NativePtr, nativeBase, n);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public string GetLineBegin(ReadOnlySpan<char> _base, int n)
		{
			// Marshaling _base to native string
			byte* nativeBase;
			var byteCountBase = 0;
			if (_base != null && !_base.IsEmpty)
			{
				byteCountBase = Encoding.UTF8.GetByteCount(_base);
				if(byteCountBase > Utils.MaxStackallocSize)
				{
					nativeBase = Utils.Alloc<byte>(byteCountBase + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountBase + 1];
					nativeBase = stackallocBytes;
				}
				var offsetBase = Utils.EncodeStringUTF8(_base, nativeBase, byteCountBase);
				nativeBase[offsetBase] = 0;
			}
			else nativeBase = null;

			var result = ImGuiNative.ImGuiTextIndexGetLineBegin(NativePtr, nativeBase, n);
			// Freeing _base native string
			if (byteCountBase > Utils.MaxStackallocSize)
				Utils.Free(nativeBase);
			return Utils.DecodeStringUTF8(result);
		}

		public int Size()
		{
			return ImGuiNative.ImGuiTextIndexSize(NativePtr);
		}

		public void Clear()
		{
			ImGuiNative.ImGuiTextIndexClear(NativePtr);
		}

	}
}
