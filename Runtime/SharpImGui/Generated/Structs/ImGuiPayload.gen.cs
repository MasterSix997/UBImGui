using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Data payload for Drag and Drop operations: AcceptDragDropPayload(), GetDragDropPayload()</para>
	/// </summary>
	public unsafe partial struct ImGuiPayload
	{
		/// <summary>
		/// <para>Members</para>
		/// </summary>
		/// <summary>
		/// Data (copied and owned by dear imgui)
		/// </summary>
		public void* Data;
		/// <summary>
		/// Data size
		/// </summary>
		public int DataSize;
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Source item id
		/// </summary>
		public uint SourceId;
		/// <summary>
		/// Source parent id (if available)
		/// </summary>
		public uint SourceParentId;
		/// <summary>
		/// Data timestamp
		/// </summary>
		public int DataFrameCount;
		/// <summary>
		/// Data type tag (short user-supplied string, 32 characters max)
		/// </summary>
		public fixed byte DataType[33];
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse has been hovering the target item (nb: handle overlapping drag targets)
		/// </summary>
		public byte Preview;
		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse button is released over the target item.
		/// </summary>
		public byte Delivery;
	}

	/// <summary>
	/// <para>Data payload for Drag and Drop operations: AcceptDragDropPayload(), GetDragDropPayload()</para>
	/// </summary>
	public unsafe partial struct ImGuiPayloadPtr
	{
		public ImGuiPayload* NativePtr { get; }
		public ImGuiPayloadPtr(ImGuiPayload* nativePtr) => NativePtr = nativePtr;
		public ImGuiPayloadPtr(IntPtr nativePtr) => NativePtr = (ImGuiPayload*)nativePtr;
		public static implicit operator ImGuiPayloadPtr(ImGuiPayload* nativePtr) => new ImGuiPayloadPtr(nativePtr);
		public static implicit operator ImGuiPayload* (ImGuiPayloadPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiPayloadPtr(IntPtr nativePtr) => new ImGuiPayloadPtr(nativePtr);

		/// <summary>
		/// <para>Members</para>
		/// </summary>
		/// <summary>
		/// Data (copied and owned by dear imgui)
		/// </summary>
		public IntPtr Data { get => (IntPtr)NativePtr->Data; set => NativePtr->Data = (void*)value; }

		/// <summary>
		/// Data size
		/// </summary>
		public ref int DataSize => ref Unsafe.AsRef<int>(&NativePtr->DataSize);

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		/// <summary>
		/// Source item id
		/// </summary>
		public ref uint SourceId => ref Unsafe.AsRef<uint>(&NativePtr->SourceId);

		/// <summary>
		/// Source parent id (if available)
		/// </summary>
		public ref uint SourceParentId => ref Unsafe.AsRef<uint>(&NativePtr->SourceParentId);

		/// <summary>
		/// Data timestamp
		/// </summary>
		public ref int DataFrameCount => ref Unsafe.AsRef<int>(&NativePtr->DataFrameCount);

		/// <summary>
		/// Data type tag (short user-supplied string, 32 characters max)
		/// </summary>
		public RangeAccessor<byte> DataType => new RangeAccessor<byte>(NativePtr->DataType, 33);

		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse has been hovering the target item (nb: handle overlapping drag targets)
		/// </summary>
		public ref bool Preview => ref Unsafe.AsRef<bool>(&NativePtr->Preview);

		/// <summary>
		/// Set when AcceptDragDropPayload() was called and mouse button is released over the target item.
		/// </summary>
		public ref bool Delivery => ref Unsafe.AsRef<bool>(&NativePtr->Delivery);

		public void Clear()
		{
			ImGuiNative.ImGuiPayload_Clear(NativePtr);
		}

		public bool IsDataType(ReadOnlySpan<char> type)
		{
			// Marshaling 'type' to native string
			byte* native_type;
			var type_byteCount = 0;
			if (type != null)
			{
				type_byteCount = Encoding.UTF8.GetByteCount(type);
				if (type_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type = Util.Allocate(type_byteCount + 1);
				}
				else
				{
					var native_type_stackBytes = stackalloc byte[type_byteCount + 1];
					native_type = native_type_stackBytes;
				}
				var type_offset = Util.GetUtf8(type, native_type, type_byteCount);
				native_type[type_offset] = 0;
			}
			else native_type = null;

			var ret = ImGuiNative.ImGuiPayload_IsDataType(NativePtr, native_type);
			if (type_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type);
			}
			return ret != 0;
		}

		public bool IsPreview()
		{
			var ret = ImGuiNative.ImGuiPayload_IsPreview(NativePtr);
			return ret != 0;
		}

		public bool IsDelivery()
		{
			var ret = ImGuiNative.ImGuiPayload_IsDelivery(NativePtr);
			return ret != 0;
		}
	}
}
