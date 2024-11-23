using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Routing table: maintain a desired owner for each possible key-chord (key + mods), and setup owner in NewFrame() when mods are matching.</para>
	/// <para>Stored in main context (1 instance)</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyRoutingTable
	{
		/// <summary>
		/// Index of first entry in Entries[]
		/// </summary>
		public fixed short Index[154];
		public ImVector Entries;
		/// <summary>
		/// Double-buffer to avoid reallocation (could use a shared buffer)
		/// </summary>
		public ImVector EntriesNext;
	}

	/// <summary>
	/// <para>Routing table: maintain a desired owner for each possible key-chord (key + mods), and setup owner in NewFrame() when mods are matching.</para>
	/// <para>Stored in main context (1 instance)</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyRoutingTablePtr
	{
		public ImGuiKeyRoutingTable* NativePtr { get; }
		public ImGuiKeyRoutingTablePtr(ImGuiKeyRoutingTable* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyRoutingTablePtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyRoutingTable*)nativePtr;
		public static implicit operator ImGuiKeyRoutingTablePtr(ImGuiKeyRoutingTable* nativePtr) => new ImGuiKeyRoutingTablePtr(nativePtr);
		public static implicit operator ImGuiKeyRoutingTable* (ImGuiKeyRoutingTablePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiKeyRoutingTablePtr(IntPtr nativePtr) => new ImGuiKeyRoutingTablePtr(nativePtr);

		/// <summary>
		/// Index of first entry in Entries[]
		/// </summary>
		public RangeAccessor<short> Index => new RangeAccessor<short>(NativePtr->Index, 154);

		public ImPtrVector<ImGuiKeyRoutingDataPtr> Entries => new ImPtrVector<ImGuiKeyRoutingDataPtr>(NativePtr->Entries, Unsafe.SizeOf<ImGuiKeyRoutingData>());

		/// <summary>
		/// Double-buffer to avoid reallocation (could use a shared buffer)
		/// </summary>
		public ImPtrVector<ImGuiKeyRoutingDataPtr> EntriesNext => new ImPtrVector<ImGuiKeyRoutingDataPtr>(NativePtr->EntriesNext, Unsafe.SizeOf<ImGuiKeyRoutingData>());

		public void Clear()
		{
			ImGuiInternalNative.ImGuiKeyRoutingTable_Clear(NativePtr);
		}
	}
}
