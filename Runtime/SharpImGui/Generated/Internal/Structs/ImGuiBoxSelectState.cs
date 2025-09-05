using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiBoxSelectState
	{
		/// <summary>
		/// <br/>    Active box-selection data (persistent, 1 active at a time)<br/>
		/// </summary>
		public uint ID;
		public byte IsActive;
		public byte IsStarting;
		/// <summary>
		/// Starting click was not from an item.<br/>
		/// </summary>
		public byte IsStartedFromVoid;
		public byte IsStartedSetNavIdOnce;
		public byte RequestClear;
		/// <summary>
		/// Latched key-mods for box-select logic.<br/>
		/// </summary>
		public int KeyMods;
		/// <summary>
		/// Start position in window-contents relative space (to support scrolling)<br/>
		/// </summary>
		public Vector2 StartPosRel;
		/// <summary>
		/// End position in window-contents relative space<br/>
		/// </summary>
		public Vector2 EndPosRel;
		/// <summary>
		/// Scrolling accumulator (to behave at high-frame spaces)<br/>
		/// </summary>
		public Vector2 ScrollAccum;
		public unsafe ImGuiWindow* Window;
		/// <summary>
		///     Temporary/Transient data<br/>
		/// (Temp/Transient, here in hot area). Set/cleared by the BeginMultiSelect()/EndMultiSelect() owning active box-select.<br/>
		/// </summary>
		public byte UnclipMode;
		/// <summary>
		/// Rectangle where ItemAdd() clipping may be temporarily disabled. Need support by multi-select supporting widgets.<br/>
		/// </summary>
		public ImRect UnclipRect;
		/// <summary>
		/// Selection rectangle in absolute coordinates (derived every frame from BoxSelectStartPosRel and MousePos)<br/>
		/// </summary>
		public ImRect BoxSelectRectPrev;
		public ImRect BoxSelectRectCurr;
	}

	public unsafe partial struct ImGuiBoxSelectStatePtr
	{
		public ImGuiBoxSelectState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiBoxSelectState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    Active box-selection data (persistent, 1 active at a time)<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref bool IsActive => ref Unsafe.AsRef<bool>(&NativePtr->IsActive);
		public ref bool IsStarting => ref Unsafe.AsRef<bool>(&NativePtr->IsStarting);
		/// <summary>
		/// Starting click was not from an item.<br/>
		/// </summary>
		public ref bool IsStartedFromVoid => ref Unsafe.AsRef<bool>(&NativePtr->IsStartedFromVoid);
		public ref bool IsStartedSetNavIdOnce => ref Unsafe.AsRef<bool>(&NativePtr->IsStartedSetNavIdOnce);
		public ref bool RequestClear => ref Unsafe.AsRef<bool>(&NativePtr->RequestClear);
		/// <summary>
		/// Latched key-mods for box-select logic.<br/>
		/// </summary>
		public ref int KeyMods => ref Unsafe.AsRef<int>(&NativePtr->KeyMods);
		/// <summary>
		/// Start position in window-contents relative space (to support scrolling)<br/>
		/// </summary>
		public ref Vector2 StartPosRel => ref Unsafe.AsRef<Vector2>(&NativePtr->StartPosRel);
		/// <summary>
		/// End position in window-contents relative space<br/>
		/// </summary>
		public ref Vector2 EndPosRel => ref Unsafe.AsRef<Vector2>(&NativePtr->EndPosRel);
		/// <summary>
		/// Scrolling accumulator (to behave at high-frame spaces)<br/>
		/// </summary>
		public ref Vector2 ScrollAccum => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollAccum);
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		/// <summary>
		///     Temporary/Transient data<br/>
		/// (Temp/Transient, here in hot area). Set/cleared by the BeginMultiSelect()/EndMultiSelect() owning active box-select.<br/>
		/// </summary>
		public ref bool UnclipMode => ref Unsafe.AsRef<bool>(&NativePtr->UnclipMode);
		/// <summary>
		/// Rectangle where ItemAdd() clipping may be temporarily disabled. Need support by multi-select supporting widgets.<br/>
		/// </summary>
		public ref ImRect UnclipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->UnclipRect);
		/// <summary>
		/// Selection rectangle in absolute coordinates (derived every frame from BoxSelectStartPosRel and MousePos)<br/>
		/// </summary>
		public ref ImRect BoxSelectRectPrev => ref Unsafe.AsRef<ImRect>(&NativePtr->BoxSelectRectPrev);
		public ref ImRect BoxSelectRectCurr => ref Unsafe.AsRef<ImRect>(&NativePtr->BoxSelectRectCurr);
		public ImGuiBoxSelectStatePtr(ImGuiBoxSelectState* nativePtr) => NativePtr = nativePtr;
		public ImGuiBoxSelectStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiBoxSelectState*)nativePtr;
		public static implicit operator ImGuiBoxSelectStatePtr(ImGuiBoxSelectState* ptr) => new ImGuiBoxSelectStatePtr(ptr);
		public static implicit operator ImGuiBoxSelectStatePtr(IntPtr ptr) => new ImGuiBoxSelectStatePtr(ptr);
		public static implicit operator ImGuiBoxSelectState*(ImGuiBoxSelectStatePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiBoxSelectStateDestroy(NativePtr);
		}

		public void ImGuiBoxSelectStateConstruct()
		{
			ImGuiNative.ImGuiBoxSelectStateImGuiBoxSelectStateConstruct(NativePtr);
		}

		public ImGuiBoxSelectStatePtr ImGuiBoxSelectState()
		{
			return ImGuiNative.ImGuiBoxSelectStateImGuiBoxSelectState();
		}

	}
}
