using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Transient per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the DC variable name in ImGuiWindow.<br/>(That's theory, in practice the delimitation between ImGuiWindow and ImGuiWindowTempData is quite tenuous and could be reconsidered..)<br/>(This doesn't need a constructor because we zero-clear it as part of ImGuiWindow and all frame-temporary data are setup on Begin)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowTempData
	{
		/// <summary>
		/// <br/>    Layout<br/>
		/// Current emitting position, in absolute coordinates.<br/>
		/// </summary>
		public Vector2 CursorPos;
		public Vector2 CursorPosPrevLine;
		/// <summary>
		/// Initial position after Begin(), generally ~ window position + WindowPadding.<br/>
		/// </summary>
		public Vector2 CursorStartPos;
		/// <summary>
		/// Used to implicitly calculate ContentSize at the beginning of next frame, for scrolling range and auto-resize. Always growing during the frame.<br/>
		/// </summary>
		public Vector2 CursorMaxPos;
		/// <summary>
		/// Used to implicitly calculate ContentSizeIdeal at the beginning of next frame, for auto-resize only. Always growing during the frame.<br/>
		/// </summary>
		public Vector2 IdealMaxPos;
		public Vector2 CurrLineSize;
		public Vector2 PrevLineSize;
		/// <summary>
		/// Baseline offset (0.0f by default on a new line, generally == style.FramePadding.y when a framed item has been added).<br/>
		/// </summary>
		public float CurrLineTextBaseOffset;
		public float PrevLineTextBaseOffset;
		public byte IsSameLine;
		public byte IsSetPos;
		/// <summary>
		/// Indentation / start position from left of window (increased by TreePush/TreePop, etc.)<br/>
		/// </summary>
		public ImVec1 Indent;
		/// <summary>
		/// Offset to the current column (if ColumnsCurrent &gt; 0). FIXME: This and the above should be a stack to allow use cases like Tree-&gt;Column-&gt;Tree. Need revamp columns API.<br/>
		/// </summary>
		public ImVec1 ColumnsOffset;
		public ImVec1 GroupOffset;
		/// <summary>
		/// Record the loss of precision of CursorStartPos due to really large scrolling amount. This is used by clipper to compensate and fix the most common use case of large scroll area.<br/>
		/// </summary>
		public Vector2 CursorStartPosLossyness;
		/// <summary>
		///     Keyboard/Gamepad navigation<br/>
		/// Current layer, 0..31 (we currently only use 0..1)<br/>
		/// </summary>
		public ImGuiNavLayer NavLayerCurrent;
		/// <summary>
		/// Which layers have been written to (result from previous frame)<br/>
		/// </summary>
		public short NavLayersActiveMask;
		/// <summary>
		/// Which layers have been written to (accumulator for current frame)<br/>
		/// </summary>
		public short NavLayersActiveMaskNext;
		/// <summary>
		/// Set when current work location may be scrolled horizontally when moving left / right. This is generally always true UNLESS within a column.<br/>
		/// </summary>
		public byte NavIsScrollPushableX;
		public byte NavHideHighlightOneFrame;
		/// <summary>
		/// Set per window when scrolling can be used (== ScrollMax.y &gt; 0.0f)<br/>
		/// </summary>
		public byte NavWindowHasScrollY;
		/// <summary>
		///     Miscellaneous<br/>
		/// FIXME: Remove this<br/>
		/// </summary>
		public byte MenuBarAppending;
		/// <summary>
		/// MenuBarOffset.x is sort of equivalent of a per-layer CursorPos.x, saved/restored as we switch to the menu bar. The only situation when MenuBarOffset.y is &gt; 0 if when (SafeAreaPadding.y &gt; FramePadding.y), often used on TVs.<br/>
		/// </summary>
		public Vector2 MenuBarOffset;
		/// <summary>
		/// Simplified columns storage for menu items measurement<br/>
		/// </summary>
		public ImGuiMenuColumns MenuColumns;
		/// <summary>
		/// Current tree depth.<br/>
		/// </summary>
		public int TreeDepth;
		/// <summary>
		/// Store whether given depth has ImGuiTreeNodeStackData data. Could be turned into a ImU64 if necessary.<br/>
		/// </summary>
		public uint TreeHasStackDataDepthMask;
		public ImVector<ImGuiWindowPtr> ChildWindows;
		/// <summary>
		/// Current persistent per-window storage (store e.g. tree node open/close state)<br/>
		/// </summary>
		public unsafe ImGuiStorage* StateStorage;
		/// <summary>
		/// Current columns set<br/>
		/// </summary>
		public unsafe ImGuiOldColumns* CurrentColumns;
		/// <summary>
		/// Current table index (into g.Tables)<br/>
		/// </summary>
		public int CurrentTableIdx;
		public ImGuiLayoutType LayoutType;
		/// <summary>
		/// Layout type of parent window at the time of Begin()<br/>
		/// </summary>
		public ImGuiLayoutType ParentLayoutType;
		public uint ModalDimBgColor;
		/// <summary>
		///     Status flags<br/>
		/// </summary>
		public ImGuiItemStatusFlags WindowItemStatusFlags;
		public ImGuiItemStatusFlags ChildItemStatusFlags;
		public ImGuiItemStatusFlags DockTabItemStatusFlags;
		public ImRect DockTabItemRect;
		/// <summary>
		///     Local parameters stacks<br/>    We store the current settings outside of the vectors to increase memory locality (reduce cache misses). The vectors are rarely modified. Also it allows us to not heap allocate for short-lived windows which are not using those settings.<br/>
		/// Current item width (&gt;0.0: width in pixels, &lt;0.0: align xx pixels to the right of window).<br/>
		/// </summary>
		public float ItemWidth;
		/// <summary>
		/// Current text wrap pos.<br/>
		/// </summary>
		public float TextWrapPos;
		/// <summary>
		/// Store item widths to restore (attention: .back() is not == ItemWidth)<br/>
		/// </summary>
		public ImVector<float> ItemWidthStack;
		/// <summary>
		/// Store text wrap pos to restore (attention: .back() is not == TextWrapPos)<br/>
		/// </summary>
		public ImVector<float> TextWrapPosStack;
	}

	/// <summary>
	/// Transient per-window data, reset at the beginning of the frame. This used to be called ImGuiDrawContext, hence the DC variable name in ImGuiWindow.<br/>(That's theory, in practice the delimitation between ImGuiWindow and ImGuiWindowTempData is quite tenuous and could be reconsidered..)<br/>(This doesn't need a constructor because we zero-clear it as part of ImGuiWindow and all frame-temporary data are setup on Begin)<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowTempDataPtr
	{
		public ImGuiWindowTempData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindowTempData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    Layout<br/>
		/// Current emitting position, in absolute coordinates.<br/>
		/// </summary>
		public ref Vector2 CursorPos => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorPos);
		public ref Vector2 CursorPosPrevLine => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorPosPrevLine);
		/// <summary>
		/// Initial position after Begin(), generally ~ window position + WindowPadding.<br/>
		/// </summary>
		public ref Vector2 CursorStartPos => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorStartPos);
		/// <summary>
		/// Used to implicitly calculate ContentSize at the beginning of next frame, for scrolling range and auto-resize. Always growing during the frame.<br/>
		/// </summary>
		public ref Vector2 CursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorMaxPos);
		/// <summary>
		/// Used to implicitly calculate ContentSizeIdeal at the beginning of next frame, for auto-resize only. Always growing during the frame.<br/>
		/// </summary>
		public ref Vector2 IdealMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->IdealMaxPos);
		public ref Vector2 CurrLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->CurrLineSize);
		public ref Vector2 PrevLineSize => ref Unsafe.AsRef<Vector2>(&NativePtr->PrevLineSize);
		/// <summary>
		/// Baseline offset (0.0f by default on a new line, generally == style.FramePadding.y when a framed item has been added).<br/>
		/// </summary>
		public ref float CurrLineTextBaseOffset => ref Unsafe.AsRef<float>(&NativePtr->CurrLineTextBaseOffset);
		public ref float PrevLineTextBaseOffset => ref Unsafe.AsRef<float>(&NativePtr->PrevLineTextBaseOffset);
		public ref bool IsSameLine => ref Unsafe.AsRef<bool>(&NativePtr->IsSameLine);
		public ref bool IsSetPos => ref Unsafe.AsRef<bool>(&NativePtr->IsSetPos);
		/// <summary>
		/// Indentation / start position from left of window (increased by TreePush/TreePop, etc.)<br/>
		/// </summary>
		public ref ImVec1 Indent => ref Unsafe.AsRef<ImVec1>(&NativePtr->Indent);
		/// <summary>
		/// Offset to the current column (if ColumnsCurrent &gt; 0). FIXME: This and the above should be a stack to allow use cases like Tree-&gt;Column-&gt;Tree. Need revamp columns API.<br/>
		/// </summary>
		public ref ImVec1 ColumnsOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->ColumnsOffset);
		public ref ImVec1 GroupOffset => ref Unsafe.AsRef<ImVec1>(&NativePtr->GroupOffset);
		/// <summary>
		/// Record the loss of precision of CursorStartPos due to really large scrolling amount. This is used by clipper to compensate and fix the most common use case of large scroll area.<br/>
		/// </summary>
		public ref Vector2 CursorStartPosLossyness => ref Unsafe.AsRef<Vector2>(&NativePtr->CursorStartPosLossyness);
		/// <summary>
		///     Keyboard/Gamepad navigation<br/>
		/// Current layer, 0..31 (we currently only use 0..1)<br/>
		/// </summary>
		public ref ImGuiNavLayer NavLayerCurrent => ref Unsafe.AsRef<ImGuiNavLayer>(&NativePtr->NavLayerCurrent);
		/// <summary>
		/// Which layers have been written to (result from previous frame)<br/>
		/// </summary>
		public ref short NavLayersActiveMask => ref Unsafe.AsRef<short>(&NativePtr->NavLayersActiveMask);
		/// <summary>
		/// Which layers have been written to (accumulator for current frame)<br/>
		/// </summary>
		public ref short NavLayersActiveMaskNext => ref Unsafe.AsRef<short>(&NativePtr->NavLayersActiveMaskNext);
		/// <summary>
		/// Set when current work location may be scrolled horizontally when moving left / right. This is generally always true UNLESS within a column.<br/>
		/// </summary>
		public ref bool NavIsScrollPushableX => ref Unsafe.AsRef<bool>(&NativePtr->NavIsScrollPushableX);
		public ref bool NavHideHighlightOneFrame => ref Unsafe.AsRef<bool>(&NativePtr->NavHideHighlightOneFrame);
		/// <summary>
		/// Set per window when scrolling can be used (== ScrollMax.y &gt; 0.0f)<br/>
		/// </summary>
		public ref bool NavWindowHasScrollY => ref Unsafe.AsRef<bool>(&NativePtr->NavWindowHasScrollY);
		/// <summary>
		///     Miscellaneous<br/>
		/// FIXME: Remove this<br/>
		/// </summary>
		public ref bool MenuBarAppending => ref Unsafe.AsRef<bool>(&NativePtr->MenuBarAppending);
		/// <summary>
		/// MenuBarOffset.x is sort of equivalent of a per-layer CursorPos.x, saved/restored as we switch to the menu bar. The only situation when MenuBarOffset.y is &gt; 0 if when (SafeAreaPadding.y &gt; FramePadding.y), often used on TVs.<br/>
		/// </summary>
		public ref Vector2 MenuBarOffset => ref Unsafe.AsRef<Vector2>(&NativePtr->MenuBarOffset);
		/// <summary>
		/// Simplified columns storage for menu items measurement<br/>
		/// </summary>
		public ref ImGuiMenuColumns MenuColumns => ref Unsafe.AsRef<ImGuiMenuColumns>(&NativePtr->MenuColumns);
		/// <summary>
		/// Current tree depth.<br/>
		/// </summary>
		public ref int TreeDepth => ref Unsafe.AsRef<int>(&NativePtr->TreeDepth);
		/// <summary>
		/// Store whether given depth has ImGuiTreeNodeStackData data. Could be turned into a ImU64 if necessary.<br/>
		/// </summary>
		public ref uint TreeHasStackDataDepthMask => ref Unsafe.AsRef<uint>(&NativePtr->TreeHasStackDataDepthMask);
		public ref ImVector<ImGuiWindowPtr> ChildWindows => ref Unsafe.AsRef<ImVector<ImGuiWindowPtr>>(&NativePtr->ChildWindows);
		/// <summary>
		/// Current persistent per-window storage (store e.g. tree node open/close state)<br/>
		/// </summary>
		public ref ImGuiStoragePtr StateStorage => ref Unsafe.AsRef<ImGuiStoragePtr>(&NativePtr->StateStorage);
		/// <summary>
		/// Current columns set<br/>
		/// </summary>
		public ref ImGuiOldColumnsPtr CurrentColumns => ref Unsafe.AsRef<ImGuiOldColumnsPtr>(&NativePtr->CurrentColumns);
		/// <summary>
		/// Current table index (into g.Tables)<br/>
		/// </summary>
		public ref int CurrentTableIdx => ref Unsafe.AsRef<int>(&NativePtr->CurrentTableIdx);
		public ref ImGuiLayoutType LayoutType => ref Unsafe.AsRef<ImGuiLayoutType>(&NativePtr->LayoutType);
		/// <summary>
		/// Layout type of parent window at the time of Begin()<br/>
		/// </summary>
		public ref ImGuiLayoutType ParentLayoutType => ref Unsafe.AsRef<ImGuiLayoutType>(&NativePtr->ParentLayoutType);
		public ref uint ModalDimBgColor => ref Unsafe.AsRef<uint>(&NativePtr->ModalDimBgColor);
		/// <summary>
		///     Status flags<br/>
		/// </summary>
		public ref ImGuiItemStatusFlags WindowItemStatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->WindowItemStatusFlags);
		public ref ImGuiItemStatusFlags ChildItemStatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->ChildItemStatusFlags);
		public ref ImGuiItemStatusFlags DockTabItemStatusFlags => ref Unsafe.AsRef<ImGuiItemStatusFlags>(&NativePtr->DockTabItemStatusFlags);
		public ref ImRect DockTabItemRect => ref Unsafe.AsRef<ImRect>(&NativePtr->DockTabItemRect);
		/// <summary>
		///     Local parameters stacks<br/>    We store the current settings outside of the vectors to increase memory locality (reduce cache misses). The vectors are rarely modified. Also it allows us to not heap allocate for short-lived windows which are not using those settings.<br/>
		/// Current item width (&gt;0.0: width in pixels, &lt;0.0: align xx pixels to the right of window).<br/>
		/// </summary>
		public ref float ItemWidth => ref Unsafe.AsRef<float>(&NativePtr->ItemWidth);
		/// <summary>
		/// Current text wrap pos.<br/>
		/// </summary>
		public ref float TextWrapPos => ref Unsafe.AsRef<float>(&NativePtr->TextWrapPos);
		/// <summary>
		/// Store item widths to restore (attention: .back() is not == ItemWidth)<br/>
		/// </summary>
		public ref ImVector<float> ItemWidthStack => ref Unsafe.AsRef<ImVector<float>>(&NativePtr->ItemWidthStack);
		/// <summary>
		/// Store text wrap pos to restore (attention: .back() is not == TextWrapPos)<br/>
		/// </summary>
		public ref ImVector<float> TextWrapPosStack => ref Unsafe.AsRef<ImVector<float>>(&NativePtr->TextWrapPosStack);
		public ImGuiWindowTempDataPtr(ImGuiWindowTempData* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowTempDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowTempData*)nativePtr;
		public static implicit operator ImGuiWindowTempDataPtr(ImGuiWindowTempData* ptr) => new ImGuiWindowTempDataPtr(ptr);
		public static implicit operator ImGuiWindowTempDataPtr(IntPtr ptr) => new ImGuiWindowTempDataPtr(ptr);
		public static implicit operator ImGuiWindowTempData*(ImGuiWindowTempDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
