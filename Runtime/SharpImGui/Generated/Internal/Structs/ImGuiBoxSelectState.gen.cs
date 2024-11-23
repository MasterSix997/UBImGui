using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiBoxSelectState
	{
		/// <summary>
		/// <para>Active box-selection data (persistent, 1 active at a time)</para>
		/// </summary>
		public uint ID;
		public byte IsActive;
		public byte IsStarting;
		/// <summary>
		/// Starting click was not from an item.
		/// </summary>
		public byte IsStartedFromVoid;
		public byte IsStartedSetNavIdOnce;
		public byte RequestClear;
		/// <summary>
		/// Latched key-mods for box-select logic.
		/// </summary>
		public ImGuiKey KeyMods;
		/// <summary>
		/// Start position in window-contents relative space (to support scrolling)
		/// </summary>
		public Vector2 StartPosRel;
		/// <summary>
		/// End position in window-contents relative space
		/// </summary>
		public Vector2 EndPosRel;
		/// <summary>
		/// Scrolling accumulator (to behave at high-frame spaces)
		/// </summary>
		public Vector2 ScrollAccum;
		public ImGuiWindow* Window;
		/// <summary>
		/// <para>Temporary/Transient data</para>
		/// </summary>
		/// <summary>
		/// (Temp/Transient, here in hot area). Set/cleared by the BeginMultiSelect()/EndMultiSelect() owning active box-select.
		/// </summary>
		public byte UnclipMode;
		/// <summary>
		/// Rectangle where ItemAdd() clipping may be temporarily disabled. Need support by multi-select supporting widgets.
		/// </summary>
		public ImRect UnclipRect;
		/// <summary>
		/// Selection rectangle in absolute coordinates (derived every frame from BoxSelectStartPosRel and MousePos)
		/// </summary>
		public ImRect BoxSelectRectPrev;
		public ImRect BoxSelectRectCurr;
	}

	public unsafe partial struct ImGuiBoxSelectStatePtr
	{
		public ImGuiBoxSelectState* NativePtr { get; }
		public ImGuiBoxSelectStatePtr(ImGuiBoxSelectState* nativePtr) => NativePtr = nativePtr;
		public ImGuiBoxSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiBoxSelectState*)nativePtr;
		public static implicit operator ImGuiBoxSelectStatePtr(ImGuiBoxSelectState* nativePtr) => new ImGuiBoxSelectStatePtr(nativePtr);
		public static implicit operator ImGuiBoxSelectState* (ImGuiBoxSelectStatePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiBoxSelectStatePtr(IntPtr nativePtr) => new ImGuiBoxSelectStatePtr(nativePtr);

		/// <summary>
		/// <para>Active box-selection data (persistent, 1 active at a time)</para>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		public ref bool IsActive => ref Unsafe.AsRef<bool>(&NativePtr->IsActive);

		public ref bool IsStarting => ref Unsafe.AsRef<bool>(&NativePtr->IsStarting);

		/// <summary>
		/// Starting click was not from an item.
		/// </summary>
		public ref bool IsStartedFromVoid => ref Unsafe.AsRef<bool>(&NativePtr->IsStartedFromVoid);

		public ref bool IsStartedSetNavIdOnce => ref Unsafe.AsRef<bool>(&NativePtr->IsStartedSetNavIdOnce);

		public ref bool RequestClear => ref Unsafe.AsRef<bool>(&NativePtr->RequestClear);

		/// <summary>
		/// Latched key-mods for box-select logic.
		/// </summary>
		public ref ImGuiKey KeyMods => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->KeyMods);

		/// <summary>
		/// Start position in window-contents relative space (to support scrolling)
		/// </summary>
		public ref Vector2 StartPosRel => ref Unsafe.AsRef<Vector2>(&NativePtr->StartPosRel);

		/// <summary>
		/// End position in window-contents relative space
		/// </summary>
		public ref Vector2 EndPosRel => ref Unsafe.AsRef<Vector2>(&NativePtr->EndPosRel);

		/// <summary>
		/// Scrolling accumulator (to behave at high-frame spaces)
		/// </summary>
		public ref Vector2 ScrollAccum => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollAccum);

		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		/// <summary>
		/// <para>Temporary/Transient data</para>
		/// </summary>
		/// <summary>
		/// (Temp/Transient, here in hot area). Set/cleared by the BeginMultiSelect()/EndMultiSelect() owning active box-select.
		/// </summary>
		public ref bool UnclipMode => ref Unsafe.AsRef<bool>(&NativePtr->UnclipMode);

		/// <summary>
		/// Rectangle where ItemAdd() clipping may be temporarily disabled. Need support by multi-select supporting widgets.
		/// </summary>
		public ref ImRect UnclipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->UnclipRect);

		/// <summary>
		/// Selection rectangle in absolute coordinates (derived every frame from BoxSelectStartPosRel and MousePos)
		/// </summary>
		public ref ImRect BoxSelectRectPrev => ref Unsafe.AsRef<ImRect>(&NativePtr->BoxSelectRectPrev);

		public ref ImRect BoxSelectRectCurr => ref Unsafe.AsRef<ImRect>(&NativePtr->BoxSelectRectCurr);
	}
}
