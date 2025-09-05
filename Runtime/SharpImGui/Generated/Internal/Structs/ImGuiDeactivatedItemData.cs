using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Data used by IsItemDeactivated()/IsItemDeactivatedAfterEdit() functions<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDeactivatedItemData
	{
		public uint ID;
		public int ElapseFrame;
		public byte HasBeenEditedBefore;
		public byte IsAlive;
	}

	/// <summary>
	/// Data used by IsItemDeactivated()/IsItemDeactivatedAfterEdit() functions<br/>
	/// </summary>
	public unsafe partial struct ImGuiDeactivatedItemDataPtr
	{
		public ImGuiDeactivatedItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDeactivatedItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref int ElapseFrame => ref Unsafe.AsRef<int>(&NativePtr->ElapseFrame);
		public ref bool HasBeenEditedBefore => ref Unsafe.AsRef<bool>(&NativePtr->HasBeenEditedBefore);
		public ref bool IsAlive => ref Unsafe.AsRef<bool>(&NativePtr->IsAlive);
		public ImGuiDeactivatedItemDataPtr(ImGuiDeactivatedItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiDeactivatedItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiDeactivatedItemData*)nativePtr;
		public static implicit operator ImGuiDeactivatedItemDataPtr(ImGuiDeactivatedItemData* ptr) => new ImGuiDeactivatedItemDataPtr(ptr);
		public static implicit operator ImGuiDeactivatedItemDataPtr(IntPtr ptr) => new ImGuiDeactivatedItemDataPtr(ptr);
		public static implicit operator ImGuiDeactivatedItemData*(ImGuiDeactivatedItemDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
