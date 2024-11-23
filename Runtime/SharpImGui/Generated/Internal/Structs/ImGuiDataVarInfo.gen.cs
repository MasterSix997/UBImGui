using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiDataVarInfo
	{
		public ImGuiDataType Type;
		/// <summary>
		/// 1+
		/// </summary>
		public uint Count;
		/// <summary>
		/// Offset in parent structure
		/// </summary>
		public uint Offset;
	}

	public unsafe partial struct ImGuiDataVarInfoPtr
	{
		public ImGuiDataVarInfo* NativePtr { get; }
		public ImGuiDataVarInfoPtr(ImGuiDataVarInfo* nativePtr) => NativePtr = nativePtr;
		public ImGuiDataVarInfoPtr(IntPtr nativePtr) => NativePtr = (ImGuiDataVarInfo*)nativePtr;
		public static implicit operator ImGuiDataVarInfoPtr(ImGuiDataVarInfo* nativePtr) => new ImGuiDataVarInfoPtr(nativePtr);
		public static implicit operator ImGuiDataVarInfo* (ImGuiDataVarInfoPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiDataVarInfoPtr(IntPtr nativePtr) => new ImGuiDataVarInfoPtr(nativePtr);

		public ref ImGuiDataType Type => ref Unsafe.AsRef<ImGuiDataType>(&NativePtr->Type);

		/// <summary>
		/// 1+
		/// </summary>
		public ref uint Count => ref Unsafe.AsRef<uint>(&NativePtr->Count);

		/// <summary>
		/// Offset in parent structure
		/// </summary>
		public ref uint Offset => ref Unsafe.AsRef<uint>(&NativePtr->Offset);

		public void* GetVarPtr(IntPtr parent)
		{
			// Marshaling 'parent' to native void pointer
			var native_parent = parent.ToPointer();

			var ret = ImGuiInternalNative.ImGuiDataVarInfo_GetVarPtr(NativePtr, native_parent);
			return ret;
		}
	}
}
