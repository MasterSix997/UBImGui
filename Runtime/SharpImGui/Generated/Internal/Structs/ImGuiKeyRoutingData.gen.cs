using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Routing table entry (sizeof() == 16 bytes)</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyRoutingData
	{
		public short NextEntryIndex;
		/// <summary>
		/// Technically we'd only need 4-bits but for simplify we store ImGuiMod_ values which need 16-bits.
		/// </summary>
		public ushort Mods;
		/// <summary>
		/// [DEBUG] For debug display
		/// </summary>
		public byte RoutingCurrScore;
		/// <summary>
		/// Lower is better (0: perfect score)
		/// </summary>
		public byte RoutingNextScore;
		public uint RoutingCurr;
		public uint RoutingNext;
	}

	/// <summary>
	/// <para>Routing table entry (sizeof() == 16 bytes)</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyRoutingDataPtr
	{
		public ImGuiKeyRoutingData* NativePtr { get; }
		public ImGuiKeyRoutingDataPtr(ImGuiKeyRoutingData* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyRoutingDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyRoutingData*)nativePtr;
		public static implicit operator ImGuiKeyRoutingDataPtr(ImGuiKeyRoutingData* nativePtr) => new ImGuiKeyRoutingDataPtr(nativePtr);
		public static implicit operator ImGuiKeyRoutingData* (ImGuiKeyRoutingDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiKeyRoutingDataPtr(IntPtr nativePtr) => new ImGuiKeyRoutingDataPtr(nativePtr);

		public ref short NextEntryIndex => ref Unsafe.AsRef<short>(&NativePtr->NextEntryIndex);

		/// <summary>
		/// Technically we'd only need 4-bits but for simplify we store ImGuiMod_ values which need 16-bits.
		/// </summary>
		public ref ushort Mods => ref Unsafe.AsRef<ushort>(&NativePtr->Mods);

		/// <summary>
		/// [DEBUG] For debug display
		/// </summary>
		public ref bool RoutingCurrScore => ref Unsafe.AsRef<bool>(&NativePtr->RoutingCurrScore);

		/// <summary>
		/// Lower is better (0: perfect score)
		/// </summary>
		public ref bool RoutingNextScore => ref Unsafe.AsRef<bool>(&NativePtr->RoutingNextScore);

		public ref uint RoutingCurr => ref Unsafe.AsRef<uint>(&NativePtr->RoutingCurr);

		public ref uint RoutingNext => ref Unsafe.AsRef<uint>(&NativePtr->RoutingNext);
	}
}
