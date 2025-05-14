using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	///     [Internal]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTextRange
	{
		public unsafe byte* B;
		public unsafe byte* E;
	}

	/// <summary>
	///     [Internal]<br/>
	/// </summary>
	public unsafe partial struct ImGuiTextRangePtr
	{
		public ImGuiTextRange* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTextRange this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public IntPtr B { get => (IntPtr)NativePtr->B; set => NativePtr->B = (byte*)value; }
		public IntPtr E { get => (IntPtr)NativePtr->E; set => NativePtr->E = (byte*)value; }
		public ImGuiTextRangePtr(ImGuiTextRange* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextRangePtr(IntPtr nativePtr) => NativePtr = (ImGuiTextRange*)nativePtr;
		public static implicit operator ImGuiTextRangePtr(ImGuiTextRange* ptr) => new ImGuiTextRangePtr(ptr);
		public static implicit operator ImGuiTextRangePtr(IntPtr ptr) => new ImGuiTextRangePtr(ptr);
		public static implicit operator ImGuiTextRange*(ImGuiTextRangePtr nativePtr) => nativePtr.NativePtr;
		public void Split(bool separator, out ImVector<ImGuiTextRange> _out)
		{
			var native_separator = separator ? (byte)1 : (byte)0;
			fixed (ImVector<ImGuiTextRange>* nativeOut = &_out)
			{
				ImGuiNative.ImGuiTextRangeSplit(NativePtr, native_separator, nativeOut);
			}
		}

		public bool Empty()
		{
			var result = ImGuiNative.ImGuiTextRangeEmpty(NativePtr);
			return result != 0;
		}

		public void ImGuiTextRangeStrConstruct(ReadOnlySpan<byte> b, ReadOnlySpan<byte> e)
		{
			fixed (byte* nativeB = b)
			fixed (byte* nativeE = e)
			{
				ImGuiNative.ImGuiTextRangeImGuiTextRangeStrConstruct(NativePtr, nativeB, nativeE);
			}
		}

		public void ImGuiTextRangeStrConstruct(ReadOnlySpan<char> b, ReadOnlySpan<char> e)
		{
			// Marshaling b to native string
			byte* nativeB;
			var byteCountB = 0;
			if (b != null && !b.IsEmpty)
			{
				byteCountB = Encoding.UTF8.GetByteCount(b);
				if(byteCountB > Utils.MaxStackallocSize)
				{
					nativeB = Utils.Alloc<byte>(byteCountB + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountB + 1];
					nativeB = stackallocBytes;
				}
				var offsetB = Utils.EncodeStringUTF8(b, nativeB, byteCountB);
				nativeB[offsetB] = 0;
			}
			else nativeB = null;

			// Marshaling e to native string
			byte* nativeE;
			var byteCountE = 0;
			if (e != null && !e.IsEmpty)
			{
				byteCountE = Encoding.UTF8.GetByteCount(e);
				if(byteCountE > Utils.MaxStackallocSize)
				{
					nativeE = Utils.Alloc<byte>(byteCountE + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountE + 1];
					nativeE = stackallocBytes;
				}
				var offsetE = Utils.EncodeStringUTF8(e, nativeE, byteCountE);
				nativeE[offsetE] = 0;
			}
			else nativeE = null;

			ImGuiNative.ImGuiTextRangeImGuiTextRangeStrConstruct(NativePtr, nativeB, nativeE);
			// Freeing b native string
			if (byteCountB > Utils.MaxStackallocSize)
				Utils.Free(nativeB);
			// Freeing e native string
			if (byteCountE > Utils.MaxStackallocSize)
				Utils.Free(nativeE);
		}

		public ImGuiTextRangePtr ImGuiTextRange(ReadOnlySpan<byte> b, ReadOnlySpan<byte> e)
		{
			fixed (byte* nativeB = b)
			fixed (byte* nativeE = e)
			{
				return ImGuiNative.ImGuiTextRangeImGuiTextRange(nativeB, nativeE);
			}
		}

		public ImGuiTextRangePtr ImGuiTextRange(ReadOnlySpan<char> b, ReadOnlySpan<char> e)
		{
			// Marshaling b to native string
			byte* nativeB;
			var byteCountB = 0;
			if (b != null && !b.IsEmpty)
			{
				byteCountB = Encoding.UTF8.GetByteCount(b);
				if(byteCountB > Utils.MaxStackallocSize)
				{
					nativeB = Utils.Alloc<byte>(byteCountB + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountB + 1];
					nativeB = stackallocBytes;
				}
				var offsetB = Utils.EncodeStringUTF8(b, nativeB, byteCountB);
				nativeB[offsetB] = 0;
			}
			else nativeB = null;

			// Marshaling e to native string
			byte* nativeE;
			var byteCountE = 0;
			if (e != null && !e.IsEmpty)
			{
				byteCountE = Encoding.UTF8.GetByteCount(e);
				if(byteCountE > Utils.MaxStackallocSize)
				{
					nativeE = Utils.Alloc<byte>(byteCountE + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountE + 1];
					nativeE = stackallocBytes;
				}
				var offsetE = Utils.EncodeStringUTF8(e, nativeE, byteCountE);
				nativeE[offsetE] = 0;
			}
			else nativeE = null;

			var result = ImGuiNative.ImGuiTextRangeImGuiTextRange(nativeB, nativeE);
			// Freeing b native string
			if (byteCountB > Utils.MaxStackallocSize)
				Utils.Free(nativeB);
			// Freeing e native string
			if (byteCountE > Utils.MaxStackallocSize)
				Utils.Free(nativeE);
			return result;
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiTextRangeDestroy(NativePtr);
		}

		public void ImGuiTextRangeNilConstruct()
		{
			ImGuiNative.ImGuiTextRangeImGuiTextRangeNilConstruct(NativePtr);
		}

		public ImGuiTextRangePtr ImGuiTextRange()
		{
			return ImGuiNative.ImGuiTextRangeImGuiTextRange();
		}

	}
}
