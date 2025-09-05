using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Routing table entry (sizeof() == 16 bytes)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyRoutingData
	{
		public short NextEntryIndex;
		/// <summary>
		/// Technically we'd only need 4-bits but for simplify we store ImGuiMod_ values which need 16-bits.<br/>
		/// </summary>
		public ushort Mods;
		/// <summary>
		/// [DEBUG] For debug display<br/>
		/// </summary>
		public byte RoutingCurrScore;
		/// <summary>
		/// Lower is better (0: perfect score)<br/>
		/// </summary>
		public byte RoutingNextScore;
		public uint RoutingCurr;
		public uint RoutingNext;
	}

	/// <summary>
	/// Routing table entry (sizeof() == 16 bytes)<br/>
	/// </summary>
	public unsafe partial struct ImGuiKeyRoutingDataPtr
	{
		public ImGuiKeyRoutingData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiKeyRoutingData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref short NextEntryIndex => ref Unsafe.AsRef<short>(&NativePtr->NextEntryIndex);
		/// <summary>
		/// Technically we'd only need 4-bits but for simplify we store ImGuiMod_ values which need 16-bits.<br/>
		/// </summary>
		public ref ushort Mods => ref Unsafe.AsRef<ushort>(&NativePtr->Mods);
		/// <summary>
		/// [DEBUG] For debug display<br/>
		/// </summary>
		public ref bool RoutingCurrScore => ref Unsafe.AsRef<bool>(&NativePtr->RoutingCurrScore);
		/// <summary>
		/// Lower is better (0: perfect score)<br/>
		/// </summary>
		public ref bool RoutingNextScore => ref Unsafe.AsRef<bool>(&NativePtr->RoutingNextScore);
		public ref uint RoutingCurr => ref Unsafe.AsRef<uint>(&NativePtr->RoutingCurr);
		public ref uint RoutingNext => ref Unsafe.AsRef<uint>(&NativePtr->RoutingNext);
		public ImGuiKeyRoutingDataPtr(ImGuiKeyRoutingData* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyRoutingDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyRoutingData*)nativePtr;
		public static implicit operator ImGuiKeyRoutingDataPtr(ImGuiKeyRoutingData* ptr) => new ImGuiKeyRoutingDataPtr(ptr);
		public static implicit operator ImGuiKeyRoutingDataPtr(IntPtr ptr) => new ImGuiKeyRoutingDataPtr(ptr);
		public static implicit operator ImGuiKeyRoutingData*(ImGuiKeyRoutingDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiKeyRoutingDataDestroy(NativePtr);
		}

		public void ImGuiKeyRoutingDataConstruct()
		{
			ImGuiNative.ImGuiKeyRoutingDataImGuiKeyRoutingDataConstruct(NativePtr);
		}

		public ImGuiKeyRoutingDataPtr ImGuiKeyRoutingData()
		{
			return ImGuiNative.ImGuiKeyRoutingDataImGuiKeyRoutingData();
		}

	}
}
