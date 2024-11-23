using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Transient per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the DC variable name in ImGuiWindow.</para>
	/// <para>(That's theory, in practice the delimitation between ImGuiWindow and ImGuiWindowTempData is quite tenuous and could be reconsidered..)</para>
	/// <para>(This doesn't need a constructor because we zero-clear it as part of ImGuiWindow and all frame-temporary data are setup on Begin)</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowTempData
	{
		/// <summary>
		/// <para>Layout</para>
		/// </summary>
		/// <summary>
		/// Current emitting position, in absolute coordinates.
		/// </summary>
		public Vector2 CursorPos;
		public Vector2 CursorPosPrevLine;
		/// <summary>
		/// Initial position after Begin(), generally ~ window position + WindowPadding.
		/// </summary>
		public Vector2 CursorStartPos;
		/// <summary>
		/// Used to implicitly calculate ContentSize at the beginning of next frame, for scrolling range and auto-resize. Always growing during the frame.
		/// </summary>
		public Vector2 CursorMaxPos;
		/// <summary>
		/// Used to implicitly calculate ContentSizeIdeal at the beginning of next frame, for auto-resize only. Always growing during the frame.
		/// </summary>
		public Vector2 IdealMaxPos;
		public Vector2 CurrLineSize;
		public Vector2 PrevLineSize;
		/// <summary>
		/// Baseline offset (0.0f by default on a new line, generally == style.FramePadding.y when a framed item has been added).
		/// </summary>
		public float CurrLineTextBaseOffset;
		public float PrevLineTextBaseOffset;
		public byte IsSameLine;
		public byte IsSetPos;
		/// <summary>
		/// Indentation / start position from left of window (increased by TreePush/TreePop, etc.)
		/// </summary>
		public ImVec1 Indent;
		/// <summary>
		/// Offset to the current column (if ColumnsCurrent &gt; 0). FIXME: This and the above should be a stack to allow use cases like Tree-&gt;Column-&gt;Tree. Need revamp columns API.
		/// </summary>
		public ImVec1 ColumnsOffset;
		public ImVec1 GroupOffset;
		/// <summary>
		/// Record the loss of precision of CursorStartPos due to really large scrolling amount. This is used by clipper to compensate and fix the most common use case of large scroll area.
		/// </summary>
		public Vector2 CursorStartPosLossyness;
		/// <summary>
		/// <para>Keyboard/Gamepad navigation</para>
		/// </summary>
		/// <summary>
		/// Current layer, 0..31 (we currently only use 0..1)
		/// </summary>
		public ImGuiNavLayer NavLayerCurrent;
		/// <summary>
		/// Which layers have been written to (result from previous frame)
		/// </summary>
		public short NavLayersActiveMask;
		/// <summary>
		/// Which layers have been written to (accumulator for current frame)
		/// </summary>
		public short NavLayersActiveMaskNext;
		/// <summary>
		/// Set when current work location may be scrolled horizontally when moving left / right. This is generally always true UNLESS within a column.
		/// </summary>
		public byte NavIsScrollPushableX;
		public byte NavHideHighlightOneFrame;
		/// <summary>
		/// Set per window when scrolling can be used (== ScrollMax.y &gt; 0.0f)
		/// </summary>
		public byte NavWindowHasScrollY;
		/// <summary>
		/// <para>Miscellaneous</para>
		/// </summary>
		/// <summary>
		/// FIXME: Remove this
		/// </summary>
		public byte MenuBarAppending;
		/// <summary>
		/// MenuBarOffset.x is sort of equivalent of a per-layer CursorPos.x, saved/restored as we switch to the menu bar. The only situation when MenuBarOffset.y is &gt; 0 if when (SafeAreaPadding.y &gt; FramePadding.y), often used on TVs.
		/// </summary>
		public Vector2 MenuBarOffset;
		/// <summary>
		/// Simplified columns storage for menu items measurement
		/// </summary>
		public ImGuiMenuColumns MenuColumns;
		/// <summary>
		/// Current tree depth.
		/// </summary>
		public int TreeDepth;
		/// <summary>
		/// Store whether given depth has ImGuiTreeNodeStackData data. Could be turned into a ImU64 if necessary.
		/// </summary>
		public uint TreeHasStackDataDepthMask;
		public ImVector ChildWindows;
		/// <summary>
		/// Current persistent per-window storage (store e.g. tree node open/close state)
		/// </summary>
		public ImGuiStorage* StateStorage;
		/// <summary>
		/// Current columns set
		/// </summary>
		public ImGuiOldColumns* CurrentColumns;
		/// <summary>
		/// Current table index (into g.Tables)
		/// </summary>
		public int CurrentTableIdx;
		public ImGuiLayoutType LayoutType;
		/// <summary>
		/// Layout type of parent window at the time of Begin()
		/// </summary>
		public ImGuiLayoutType ParentLayoutType;
		public uint ModalDimBgColor;
		/// <summary>
		/// <para>Local parameters stacks</para>
		/// <para>We store the current settings outside of the vectors to increase memory locality (reduce cache misses). The vectors are rarely modified. Also it allows us to not heap allocate for short-lived windows which are not using those settings.</para>
		/// </summary>
		/// <summary>
		/// Current item width (&gt;0.0: width in pixels, &lt;0.0: align xx pixels to the right of window).
		/// </summary>
		public float ItemWidth;
		/// <summary>
		/// Current text wrap pos.
		/// </summary>
		public float TextWrapPos;
		/// <summary>
		/// Store item widths to restore (attention: .back() is not == ItemWidth)
		/// </summary>
		public ImVector ItemWidthStack;
		/// <summary>
		/// Store text wrap pos to restore (attention: .back() is not == TextWrapPos)
		/// </summary>
		public ImVector TextWrapPosStack;
	}

	/// <summary>
	/// <para>Transient per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the DC variable name in ImGuiWindow.</para>
	/// <para>(That's theory, in practice the delimitation between ImGuiWindow and ImGuiWindowTempData is quite tenuous and could be reconsidered..)</para>
	/// <para>(This doesn't need a constructor because we zero-clear it as part of ImGuiWindow and all frame-temporary data are setup on Begin)</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowTempDataPtr
	{
		public ImGuiWindowTempData* NativePtr { get; }
		public ImGuiWindowTempDataPtr(ImGuiWindowTempData* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowTempData*)nativePtr;
		public static implicit operator ImGuiWindowTempDataPtr(ImGuiWindowTempData* nativePtr) => new ImGuiWindowTempDataPtr(nativePtr);
		public static implicit operator ImGuiWindowTempData* (ImGuiWindowTempDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiWindowTempDataPtr(IntPtr nativePtr) => new ImGuiWindowTempDataPtr(nativePtr);

		/// <summary>
		/// <para>Layout</para>
		/// </summary>
		/// <summary>
		/// Current emitting position, in absolute coordinates.
		/// </summary>
		public ref Vector2 CursorPos => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorPos);

		public ref Vector2 CursorPosPrevLine => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorPosPrevLine);

		/// <summary>
		/// Initial position after Begin(), generally ~ window position + WindowPadding.
		/// </summary>
		public ref Vector2 CursorStartPos => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorStartPos);

		/// <summary>
		/// Used to implicitly calculate ContentSize at the beginning of next frame, for scrolling range and auto-resize. Always growing during the frame.
		/// </summary>
		public ref Vector2 CursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorMaxPos);

		/// <summary>
		/// Used to implicitly calculate ContentSizeIdeal at the beginning of next frame, for auto-resize only. Always growing during the frame.
		/// </summary>
		public ref Vector2 IdealMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->IdealMaxPos);

		public ref Vector2 CurrLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->CurrLineSize);

		public ref Vector2 PrevLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PrevLineSize);

		/// <summary>
		/// Baseline offset (0.0f by default on a new line, generally == style.FramePadding.y when a framed item has been added).
		/// </summary>
		public ref float CurrLineTextBaseOffset => ref Unsafe.AsRef<float>(&NativePtr->CurrLineTextBaseOffset);

		public ref float PrevLineTextBaseOffset => ref Unsafe.AsRef<float>(&NativePtr->PrevLineTextBaseOffset);

		public ref bool IsSameLine => ref Unsafe.AsRef<bool>(&NativePtr->IsSameLine);

		public ref bool IsSetPos => ref Unsafe.AsRef<bool>(&NativePtr->IsSetPos);

		/// <summary>
		/// Indentation / start position from left of window (increased by TreePush/TreePop, etc.)
		/// </summary>
		public ref ImVec1 Indent => ref Unsafe.AsRef<ImVec1>(&NativePtr->Indent);

		/// <summary>
		/// Offset to the current column (if ColumnsCurrent &gt; 0). FIXME: This and the above should be a stack to allow use cases like Tree-&gt;Column-&gt;Tree. Need revamp columns API.
		/// </summary>
		public ref ImVec1 ColumnsOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->ColumnsOffset);

		public ref ImVec1 GroupOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->GroupOffset);

		/// <summary>
		/// Record the loss of precision of CursorStartPos due to really large scrolling amount. This is used by clipper to compensate and fix the most common use case of large scroll area.
		/// </summary>
		public ref Vector2 CursorStartPosLossyness => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorStartPosLossyness);

		/// <summary>
		/// <para>Keyboard/Gamepad navigation</para>
		/// </summary>
		/// <summary>
		/// Current layer, 0..31 (we currently only use 0..1)
		/// </summary>
		public ref ImGuiNavLayer NavLayerCurrent => ref Unsafe.AsRef<ImGuiNavLayer>(&NativePtr->NavLayerCurrent);

		/// <summary>
		/// Which layers have been written to (result from previous frame)
		/// </summary>
		public ref short NavLayersActiveMask => ref Unsafe.AsRef<short>(&NativePtr->NavLayersActiveMask);

		/// <summary>
		/// Which layers have been written to (accumulator for current frame)
		/// </summary>
		public ref short NavLayersActiveMaskNext => ref Unsafe.AsRef<short>(&NativePtr->NavLayersActiveMaskNext);

		/// <summary>
		/// Set when current work location may be scrolled horizontally when moving left / right. This is generally always true UNLESS within a column.
		/// </summary>
		public ref bool NavIsScrollPushableX => ref Unsafe.AsRef<bool>(&NativePtr->NavIsScrollPushableX);

		public ref bool NavHideHighlightOneFrame => ref Unsafe.AsRef<bool>(&NativePtr->NavHideHighlightOneFrame);

		/// <summary>
		/// Set per window when scrolling can be used (== ScrollMax.y &gt; 0.0f)
		/// </summary>
		public ref bool NavWindowHasScrollY => ref Unsafe.AsRef<bool>(&NativePtr->NavWindowHasScrollY);

		/// <summary>
		/// <para>Miscellaneous</para>
		/// </summary>
		/// <summary>
		/// FIXME: Remove this
		/// </summary>
		public ref bool MenuBarAppending => ref Unsafe.AsRef<bool>(&NativePtr->MenuBarAppending);

		/// <summary>
		/// MenuBarOffset.x is sort of equivalent of a per-layer CursorPos.x, saved/restored as we switch to the menu bar. The only situation when MenuBarOffset.y is &gt; 0 if when (SafeAreaPadding.y &gt; FramePadding.y), often used on TVs.
		/// </summary>
		public ref Vector2 MenuBarOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->MenuBarOffset);

		/// <summary>
		/// Simplified columns storage for menu items measurement
		/// </summary>
		public ref ImGuiMenuColumns MenuColumns => ref Unsafe.AsRef<ImGuiMenuColumns>(&NativePtr->MenuColumns);

		/// <summary>
		/// Current tree depth.
		/// </summary>
		public ref int TreeDepth => ref Unsafe.AsRef<int>(&NativePtr->TreeDepth);

		/// <summary>
		/// Store whether given depth has ImGuiTreeNodeStackData data. Could be turned into a ImU64 if necessary.
		/// </summary>
		public ref uint TreeHasStackDataDepthMask => ref Unsafe.AsRef<uint>(&NativePtr->TreeHasStackDataDepthMask);

		public ImVector<ImGuiWindowPtr> ChildWindows => new ImVector<ImGuiWindowPtr>(NativePtr->ChildWindows);

		/// <summary>
		/// Current persistent per-window storage (store e.g. tree node open/close state)
		/// </summary>
		public ImGuiStoragePtr StateStorage => new ImGuiStoragePtr(NativePtr->StateStorage);

		/// <summary>
		/// Current columns set
		/// </summary>
		public ImGuiOldColumnsPtr CurrentColumns => new ImGuiOldColumnsPtr(NativePtr->CurrentColumns);

		/// <summary>
		/// Current table index (into g.Tables)
		/// </summary>
		public ref int CurrentTableIdx => ref Unsafe.AsRef<int>(&NativePtr->CurrentTableIdx);

		public ref ImGuiLayoutType LayoutType => ref Unsafe.AsRef<ImGuiLayoutType>(&NativePtr->LayoutType);

		/// <summary>
		/// Layout type of parent window at the time of Begin()
		/// </summary>
		public ref ImGuiLayoutType ParentLayoutType => ref Unsafe.AsRef<ImGuiLayoutType>(&NativePtr->ParentLayoutType);

		public ref uint ModalDimBgColor => ref Unsafe.AsRef<uint>(&NativePtr->ModalDimBgColor);

		/// <summary>
		/// <para>Local parameters stacks</para>
		/// <para>We store the current settings outside of the vectors to increase memory locality (reduce cache misses). The vectors are rarely modified. Also it allows us to not heap allocate for short-lived windows which are not using those settings.</para>
		/// </summary>
		/// <summary>
		/// Current item width (&gt;0.0: width in pixels, &lt;0.0: align xx pixels to the right of window).
		/// </summary>
		public ref float ItemWidth => ref Unsafe.AsRef<float>(&NativePtr->ItemWidth);

		/// <summary>
		/// Current text wrap pos.
		/// </summary>
		public ref float TextWrapPos => ref Unsafe.AsRef<float>(&NativePtr->TextWrapPos);

		/// <summary>
		/// Store item widths to restore (attention: .back() is not == ItemWidth)
		/// </summary>
		public ImVector<float> ItemWidthStack => new ImVector<float>(NativePtr->ItemWidthStack);

		/// <summary>
		/// Store text wrap pos to restore (attention: .back() is not == TextWrapPos)
		/// </summary>
		public ImVector<float> TextWrapPosStack => new ImVector<float>(NativePtr->TextWrapPosStack);
	}
}
