using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Data payload for Drag and Drop operations: AcceptDragDropPayload(), GetDragDropPayload()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPayload
	{
		/// <summary>
		/// <br/>    Members<br/>
		/// Data (copied and owned by dear imgui)<br/>
		/// </summary>
		public unsafe void* Data;
		/// <summary>
		/// Data size<br/>
		/// </summary>
		public int DataSize;
		/// <summary>
		///     [Internal]<br/>
		/// Source item id<br/>
		/// </summary>
		public uint SourceId;
		/// <summary>
		/// Source parent id (if available)<br/>
		/// </summary>
		public uint SourceParentId;
		/// <summary>
		/// Data timestamp<br/>
		/// </summary>
		public int DataFrameCount;
		/// <summary>
		/// Data type tag (short user-supplied string, 32 characters max)<br/>
		/// </summary>
		public byte DataType_0;
		public byte DataType_1;
		public byte DataType_2;
		public byte DataType_3;
		public byte DataType_4;
		public byte DataType_5;
		public byte DataType_6;
		public byte DataType_7;
		public byte DataType_8;
		public byte DataType_9;
		public byte DataType_10;
		public byte DataType_11;
		public byte DataType_12;
		public byte DataType_13;
		public byte DataType_14;
		public byte DataType_15;
		public byte DataType_16;
		public byte DataType_17;
		public byte DataType_18;
		public byte DataType_19;
		public byte DataType_20;
		public byte DataType_21;
		public byte DataType_22;
		public byte DataType_23;
		public byte DataType_24;
		public byte DataType_25;
		public byte DataType_26;
		public byte DataType_27;
		public byte DataType_28;
		public byte DataType_29;
		public byte DataType_30;
		public byte DataType_31;
		public byte DataType_32;
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse has been hovering the target item (nb: handle overlapping drag targets)<br/>
		/// </summary>
		public byte Preview;
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse button is released over the target item.<br/>
		/// </summary>
		public byte Delivery;
	}

	/// <summary>
	/// Data payload for Drag and Drop operations: AcceptDragDropPayload(), GetDragDropPayload()<br/>
	/// </summary>
	public unsafe partial struct ImGuiPayloadPtr
	{
		public ImGuiPayload* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPayload this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    Members<br/>
		/// Data (copied and owned by dear imgui)<br/>
		/// </summary>
		public IntPtr Data { get => (IntPtr)NativePtr->Data; set => NativePtr->Data = (void*)value; }
		/// <summary>
		/// Data size<br/>
		/// </summary>
		public ref int DataSize => ref Unsafe.AsRef<int>(&NativePtr->DataSize);
		/// <summary>
		///     [Internal]<br/>
		/// Source item id<br/>
		/// </summary>
		public ref uint SourceId => ref Unsafe.AsRef<uint>(&NativePtr->SourceId);
		/// <summary>
		/// Source parent id (if available)<br/>
		/// </summary>
		public ref uint SourceParentId => ref Unsafe.AsRef<uint>(&NativePtr->SourceParentId);
		/// <summary>
		/// Data timestamp<br/>
		/// </summary>
		public ref int DataFrameCount => ref Unsafe.AsRef<int>(&NativePtr->DataFrameCount);
		/// <summary>
		/// Data type tag (short user-supplied string, 32 characters max)<br/>
		/// </summary>
		public Span<byte> DataType => new Span<byte>(&NativePtr->DataType_0, 33);
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse has been hovering the target item (nb: handle overlapping drag targets)<br/>
		/// </summary>
		public ref bool Preview => ref Unsafe.AsRef<bool>(&NativePtr->Preview);
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse button is released over the target item.<br/>
		/// </summary>
		public ref bool Delivery => ref Unsafe.AsRef<bool>(&NativePtr->Delivery);
		public ImGuiPayloadPtr(ImGuiPayload* nativePtr) => NativePtr = nativePtr;
		public ImGuiPayloadPtr(IntPtr nativePtr) => NativePtr = (ImGuiPayload*)nativePtr;
		public static implicit operator ImGuiPayloadPtr(ImGuiPayload* ptr) => new ImGuiPayloadPtr(ptr);
		public static implicit operator ImGuiPayloadPtr(IntPtr ptr) => new ImGuiPayloadPtr(ptr);
		public static implicit operator ImGuiPayload*(ImGuiPayloadPtr nativePtr) => nativePtr.NativePtr;
		public bool IsDelivery()
		{
			var result = ImGuiNative.ImGuiPayloadIsDelivery(NativePtr);
			return result != 0;
		}

		public bool IsPreview()
		{
			var result = ImGuiNative.ImGuiPayloadIsPreview(NativePtr);
			return result != 0;
		}

		public bool IsDataType(ReadOnlySpan<byte> type)
		{
			fixed (byte* nativeType = type)
			{
				var result = ImGuiNative.ImGuiPayloadIsDataType(NativePtr, nativeType);
				return result != 0;
			}
		}

		public bool IsDataType(ReadOnlySpan<char> type)
		{
			// Marshaling type to native string
			byte* nativeType;
			var byteCountType = 0;
			if (type != null && !type.IsEmpty)
			{
				byteCountType = Encoding.UTF8.GetByteCount(type);
				if(byteCountType > Utils.MaxStackallocSize)
				{
					nativeType = Utils.Alloc<byte>(byteCountType + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountType + 1];
					nativeType = stackallocBytes;
				}
				var offsetType = Utils.EncodeStringUTF8(type, nativeType, byteCountType);
				nativeType[offsetType] = 0;
			}
			else nativeType = null;

			var result = ImGuiNative.ImGuiPayloadIsDataType(NativePtr, nativeType);
			// Freeing type native string
			if (byteCountType > Utils.MaxStackallocSize)
				Utils.Free(nativeType);
			return result != 0;
		}

		public void Clear()
		{
			ImGuiNative.ImGuiPayloadClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiPayloadDestroy(NativePtr);
		}

		public void ImGuiPayloadConstruct()
		{
			ImGuiNative.ImGuiPayloadImGuiPayloadConstruct(NativePtr);
		}

		public ImGuiPayloadPtr ImGuiPayload()
		{
			return ImGuiNative.ImGuiPayloadImGuiPayload();
		}

	}
}
