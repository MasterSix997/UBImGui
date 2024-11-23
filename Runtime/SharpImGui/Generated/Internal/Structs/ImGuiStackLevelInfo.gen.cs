using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiStackLevelInfo
	{
		public uint ID;
		/// <summary>
		/// &gt;= 1: Query in progress
		/// </summary>
		public sbyte QueryFrameCount;
		/// <summary>
		/// Obtained result from DebugHookIdInfo()
		/// </summary>
		public byte QuerySuccess;
		public ImGuiDataType DataType;
		/// <summary>
		/// Arbitrarily sized buffer to hold a result (FIXME: could replace Results[] with a chunk stream?) FIXME: Now that we added CTRL+C this should be fixed.
		/// </summary>
		public fixed byte Desc[57];
	}

	public unsafe partial struct ImGuiStackLevelInfoPtr
	{
		public ImGuiStackLevelInfo* NativePtr { get; }
		public ImGuiStackLevelInfoPtr(ImGuiStackLevelInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiStackLevelInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiStackLevelInfo*)nativePtr;
		public static implicit operator ImGuiStackLevelInfoPtr(ImGuiStackLevelInfo* nativePtr) => new ImGuiStackLevelInfoPtr(nativePtr);
		public static implicit operator ImGuiStackLevelInfo* (ImGuiStackLevelInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiStackLevelInfoPtr(IntPtr nativePtr) => new ImGuiStackLevelInfoPtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// &gt;= 1: Query in progress
		/// </summary>
		public ref sbyte QueryFrameCount => ref Unsafe.AsRef<sbyte>(&NativePtr->QueryFrameCount);

		/// <summary>
		/// Obtained result from DebugHookIdInfo()
		/// </summary>
		public ref bool QuerySuccess => ref Unsafe.AsRef<bool>(&NativePtr->QuerySuccess);

		public ref ImGuiDataType DataType => ref Unsafe.AsRef<ImGuiDataType>(&NativePtr->DataType);

		/// <summary>
		/// Arbitrarily sized buffer to hold a result (FIXME: could replace Results[] with a chunk stream?) FIXME: Now that we added CTRL+C this should be fixed.
		/// </summary>
		public RangeAccessor<byte> Desc => new RangeAccessor<byte>(NativePtr->Desc, 57);
	}
}
