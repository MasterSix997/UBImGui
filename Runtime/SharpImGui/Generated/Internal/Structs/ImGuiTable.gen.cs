using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>sizeof() ~ 592 bytes + heap allocs described in TableBeginInitMemory()</para>
	/// </summary>
	public unsafe partial struct ImGuiTable
	{
		public uint ID;
		public ImGuiTableFlags Flags;
		/// <summary>
		/// Single allocation to hold Columns[], DisplayOrderToIndex[] and RowCellData[]
		/// </summary>
		public void* RawData;
		/// <summary>
		/// Transient data while table is active. Point within g.CurrentTableStack[]
		/// </summary>
		public ImGuiTableTempData* TempData;
		/// <summary>
		/// Point within RawData[]
		/// </summary>
		public ImGuiTableColumn Columns;
		/// <summary>
		/// Point within RawData[]. Store display order of columns (when not reordered, the values are 0...Count-1)
		/// </summary>
		public ImGuiTableColumnIdx DisplayOrderToIndex;
		/// <summary>
		/// Point within RawData[]. Store cells background requests for current row.
		/// </summary>
		public ImGuiTableCellData RowCellData;
		/// <summary>
		/// Column DisplayOrder -&gt; IsEnabled map
		/// </summary>
		public uint* EnabledMaskByDisplayOrder;
		/// <summary>
		/// Column Index -&gt; IsEnabled map (== not hidden by user/api) in a format adequate for iterating column without touching cold data
		/// </summary>
		public uint* EnabledMaskByIndex;
		/// <summary>
		/// Column Index -&gt; IsVisibleX|IsVisibleY map (== not hidden by user/api &amp;&amp; not hidden by scrolling/cliprect)
		/// </summary>
		public uint* VisibleMaskByIndex;
		/// <summary>
		/// Which data were loaded from the .ini file (e.g. when order is not altered we won't save order)
		/// </summary>
		public ImGuiTableFlags SettingsLoadedFlags;
		/// <summary>
		/// Offset in g.SettingsTables
		/// </summary>
		public int SettingsOffset;
		public int LastFrameActive;
		/// <summary>
		/// Number of columns declared in BeginTable()
		/// </summary>
		public int ColumnsCount;
		public int CurrentRow;
		public int CurrentColumn;
		/// <summary>
		/// Count of BeginTable() calls with same ID in the same frame (generally 0). This is a little bit similar to BeginCount for a window, but multiple table with same ID look are multiple tables, they are just synched.
		/// </summary>
		public short InstanceCurrent;
		/// <summary>
		/// Mark which instance (generally 0) of the same ID is being interacted with
		/// </summary>
		public short InstanceInteracted;
		public float RowPosY1;
		public float RowPosY2;
		/// <summary>
		/// Height submitted to TableNextRow()
		/// </summary>
		public float RowMinHeight;
		/// <summary>
		/// Top and bottom padding. Reloaded during row change.
		/// </summary>
		public float RowCellPaddingY;
		public float RowTextBaseline;
		public float RowIndentOffsetX;
		/// <summary>
		/// Current row flags, see ImGuiTableRowFlags_
		/// </summary>
		public ImGuiTableRowFlags RowFlags;
		public ImGuiTableRowFlags LastRowFlags;
		/// <summary>
		/// Counter for alternating background colors (can be fast-forwarded by e.g clipper), not same as CurrentRow because header rows typically don't increase this.
		/// </summary>
		public int RowBgColorCounter;
		/// <summary>
		/// Background color override for current row.
		/// </summary>
		public fixed uint RowBgColor[2];
		public uint BorderColorStrong;
		public uint BorderColorLight;
		public float BorderX1;
		public float BorderX2;
		public float HostIndentX;
		public float MinColumnWidth;
		public float OuterPaddingX;
		/// <summary>
		/// Padding from each borders. Locked in BeginTable()/Layout.
		/// </summary>
		public float CellPaddingX;
		/// <summary>
		/// Spacing between non-bordered cells. Locked in BeginTable()/Layout.
		/// </summary>
		public float CellSpacingX1;
		public float CellSpacingX2;
		/// <summary>
		/// User value passed to BeginTable(), see comments at the top of BeginTable() for details.
		/// </summary>
		public float InnerWidth;
		/// <summary>
		/// Sum of current column width
		/// </summary>
		public float ColumnsGivenWidth;
		/// <summary>
		/// Sum of ideal column width in order nothing to be clipped, used for auto-fitting and content width submission in outer window
		/// </summary>
		public float ColumnsAutoFitWidth;
		/// <summary>
		/// Sum of weight of all enabled stretching columns
		/// </summary>
		public float ColumnsStretchSumWeights;
		public float ResizedColumnNextWidth;
		/// <summary>
		/// Lock minimum contents width while resizing down in order to not create feedback loops. But we allow growing the table.
		/// </summary>
		public float ResizeLockMinContentsX2;
		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.
		/// </summary>
		public float RefScale;
		/// <summary>
		/// Set by TableAngledHeadersRow(), used in TableUpdateLayout()
		/// </summary>
		public float AngledHeadersHeight;
		/// <summary>
		/// Set by TableAngledHeadersRow(), used in TableUpdateLayout()
		/// </summary>
		public float AngledHeadersSlope;
		/// <summary>
		/// Note: for non-scrolling table, OuterRect.Max.y is often FLT_MAX until EndTable(), unless a height has been specified in BeginTable().
		/// </summary>
		public ImRect OuterRect;
		/// <summary>
		/// InnerRect but without decoration. As with OuterRect, for non-scrolling tables, InnerRect.Max.y is
		/// </summary>
		public ImRect InnerRect;
		public ImRect WorkRect;
		public ImRect InnerClipRect;
		/// <summary>
		/// We use this to cpu-clip cell background color fill, evolve during the frame as we cross frozen rows boundaries
		/// </summary>
		public ImRect BgClipRect;
		/// <summary>
		/// Actual ImDrawCmd clip rect for BG0/1 channel. This tends to be == OuterWindow-&gt;ClipRect at BeginTable() because output in BG0/BG1 is cpu-clipped
		/// </summary>
		public ImRect Bg0ClipRectForDrawCmd;
		/// <summary>
		/// Actual ImDrawCmd clip rect for BG2 channel. This tends to be a correct, tight-fit, because output to BG2 are done by widgets relying on regular ClipRect.
		/// </summary>
		public ImRect Bg2ClipRectForDrawCmd;
		/// <summary>
		/// This is used to check if we can eventually merge our columns draw calls into the current draw call of the current window.
		/// </summary>
		public ImRect HostClipRect;
		/// <summary>
		/// Backup of InnerWindow-&gt;ClipRect during PushTableBackground()/PopTableBackground()
		/// </summary>
		public ImRect HostBackupInnerClipRect;
		/// <summary>
		/// Parent window for the table
		/// </summary>
		public ImGuiWindow* OuterWindow;
		/// <summary>
		/// Window holding the table data (== OuterWindow or a child window)
		/// </summary>
		public ImGuiWindow* InnerWindow;
		/// <summary>
		/// Contiguous buffer holding columns names
		/// </summary>
		public ImGuiTextBuffer ColumnsNames;
		/// <summary>
		/// Shortcut to TempData-&gt;DrawSplitter while in table. Isolate draw commands per columns to avoid switching clip rect constantly
		/// </summary>
		public ImDrawListSplitter* DrawSplitter;
		public ImGuiTableInstanceData InstanceDataFirst;
		/// <summary>
		/// FIXME-OPT: Using a small-vector pattern would be good.
		/// </summary>
		public ImVector InstanceDataExtra;
		public ImGuiTableColumnSortSpecs SortSpecsSingle;
		/// <summary>
		/// FIXME-OPT: Using a small-vector pattern would be good.
		/// </summary>
		public ImVector SortSpecsMulti;
		/// <summary>
		/// Public facing sorts specs, this is what we return in TableGetSortSpecs()
		/// </summary>
		public ImGuiTableSortSpecs SortSpecs;
		public short SortSpecsCount;
		/// <summary>
		/// Number of enabled columns (&lt;= ColumnsCount)
		/// </summary>
		public short ColumnsEnabledCount;
		/// <summary>
		/// Number of enabled columns using fixed width (&lt;= ColumnsCount)
		/// </summary>
		public short ColumnsEnabledFixedCount;
		/// <summary>
		/// Count calls to TableSetupColumn()
		/// </summary>
		public short DeclColumnsCount;
		/// <summary>
		/// Count columns with angled headers
		/// </summary>
		public short AngledHeadersCount;
		/// <summary>
		/// Index of column whose visible region is being hovered. Important: == ColumnsCount when hovering empty region after the right-most column!
		/// </summary>
		public short HoveredColumnBody;
		/// <summary>
		/// Index of column whose right-border is being hovered (for resizing).
		/// </summary>
		public short HoveredColumnBorder;
		/// <summary>
		/// Index of column which should be highlighted.
		/// </summary>
		public short HighlightColumnHeader;
		/// <summary>
		/// Index of single column requesting auto-fit.
		/// </summary>
		public short AutoFitSingleColumn;
		/// <summary>
		/// Index of column being resized. Reset when InstanceCurrent==0.
		/// </summary>
		public short ResizedColumn;
		/// <summary>
		/// Index of column being resized from previous frame.
		/// </summary>
		public short LastResizedColumn;
		/// <summary>
		/// Index of column header being held.
		/// </summary>
		public short HeldHeaderColumn;
		/// <summary>
		/// Index of column being reordered. (not cleared)
		/// </summary>
		public short ReorderColumn;
		/// <summary>
		/// -1 or +1
		/// </summary>
		public short ReorderColumnDir;
		/// <summary>
		/// Index of left-most non-hidden column.
		/// </summary>
		public short LeftMostEnabledColumn;
		/// <summary>
		/// Index of right-most non-hidden column.
		/// </summary>
		public short RightMostEnabledColumn;
		/// <summary>
		/// Index of left-most stretched column.
		/// </summary>
		public short LeftMostStretchedColumn;
		/// <summary>
		/// Index of right-most stretched column.
		/// </summary>
		public short RightMostStretchedColumn;
		/// <summary>
		/// Column right-clicked on, of -1 if opening context menu from a neutral/empty spot
		/// </summary>
		public short ContextPopupColumn;
		/// <summary>
		/// Requested frozen rows count
		/// </summary>
		public short FreezeRowsRequest;
		/// <summary>
		/// Actual frozen row count (== FreezeRowsRequest, or == 0 when no scrolling offset)
		/// </summary>
		public short FreezeRowsCount;
		/// <summary>
		/// Requested frozen columns count
		/// </summary>
		public short FreezeColumnsRequest;
		/// <summary>
		/// Actual frozen columns count (== FreezeColumnsRequest, or == 0 when no scrolling offset)
		/// </summary>
		public short FreezeColumnsCount;
		/// <summary>
		/// Index of current RowCellData[] entry in current row
		/// </summary>
		public short RowCellDataCurrent;
		/// <summary>
		/// Redirect non-visible columns here.
		/// </summary>
		public ushort DummyDrawChannel;
		/// <summary>
		/// For Selectable() and other widgets drawing across columns after the freezing line. Index within DrawSplitter.Channels[]
		/// </summary>
		public ushort Bg2DrawChannelCurrent;
		public ushort Bg2DrawChannelUnfrozen;
		/// <summary>
		/// Set by TableUpdateLayout() which is called when beginning the first row.
		/// </summary>
		public byte IsLayoutLocked;
		/// <summary>
		/// Set when inside TableBeginRow()/TableEndRow().
		/// </summary>
		public byte IsInsideRow;
		public byte IsInitializing;
		public byte IsSortSpecsDirty;
		/// <summary>
		/// Set when the first row had the ImGuiTableRowFlags_Headers flag.
		/// </summary>
		public byte IsUsingHeaders;
		/// <summary>
		/// Set when default context menu is open (also see: ContextPopupColumn, InstanceInteracted).
		/// </summary>
		public byte IsContextPopupOpen;
		/// <summary>
		/// Disable default context menu contents. You may submit your own using TableBeginContextMenuPopup()/EndPopup()
		/// </summary>
		public byte DisableDefaultContextMenu;
		public byte IsSettingsRequestLoad;
		/// <summary>
		/// Set when table settings have changed and needs to be reported into ImGuiTableSetttings data.
		/// </summary>
		public byte IsSettingsDirty;
		/// <summary>
		/// Set when display order is unchanged from default (DisplayOrder contains 0...Count-1)
		/// </summary>
		public byte IsDefaultDisplayOrder;
		public byte IsResetAllRequest;
		public byte IsResetDisplayOrderRequest;
		/// <summary>
		/// Set when we got past the frozen row.
		/// </summary>
		public byte IsUnfrozenRows;
		/// <summary>
		/// Set if user didn't explicitly set a sizing policy in BeginTable()
		/// </summary>
		public byte IsDefaultSizingPolicy;
		public byte IsActiveIdAliveBeforeTable;
		public byte IsActiveIdInTable;
		/// <summary>
		/// Whether ANY instance of this table had a vertical scrollbar during the current frame.
		/// </summary>
		public byte HasScrollbarYCurr;
		/// <summary>
		/// Whether ANY instance of this table had a vertical scrollbar during the previous.
		/// </summary>
		public byte HasScrollbarYPrev;
		public byte MemoryCompacted;
		/// <summary>
		/// Backup of InnerWindow-&gt;SkipItem at the end of BeginTable(), because we will overwrite InnerWindow-&gt;SkipItem on a per-column basis
		/// </summary>
		public byte HostSkipItems;
	}

	/// <summary>
	/// <para>sizeof() ~ 592 bytes + heap allocs described in TableBeginInitMemory()</para>
	/// </summary>
	public unsafe partial struct ImGuiTablePtr
	{
		public ImGuiTable* NativePtr { get; }
		public ImGuiTablePtr(ImGuiTable* nativePtr) => NativePtr = nativePtr;
		public ImGuiTablePtr(IntPtr nativePtr) => NativePtr = (ImGuiTable*)nativePtr;
		public static implicit operator ImGuiTablePtr(ImGuiTable* nativePtr) => new ImGuiTablePtr(nativePtr);
		public static implicit operator ImGuiTable* (ImGuiTablePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTablePtr(IntPtr nativePtr) => new ImGuiTablePtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		public ref ImGuiTableFlags Flags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->Flags);

		/// <summary>
		/// Single allocation to hold Columns[], DisplayOrderToIndex[] and RowCellData[]
		/// </summary>
		public IntPtr RawData { get => (IntPtr)NativePtr->RawData; set => NativePtr->RawData = (void*)value; }

		/// <summary>
		/// Transient data while table is active. Point within g.CurrentTableStack[]
		/// </summary>
		public ImGuiTableTempDataPtr TempData => new ImGuiTableTempDataPtr(NativePtr->TempData);

		/// <summary>
		/// Point within RawData[]
		/// </summary>
		public ref ImGuiTableColumn Columns => ref Unsafe.AsRef<ImGuiTableColumn>(&NativePtr->Columns);

		/// <summary>
		/// Point within RawData[]. Store display order of columns (when not reordered, the values are 0...Count-1)
		/// </summary>
		public ref ImGuiTableColumnIdx DisplayOrderToIndex => ref Unsafe.AsRef<ImGuiTableColumnIdx>(&NativePtr->DisplayOrderToIndex);

		/// <summary>
		/// Point within RawData[]. Store cells background requests for current row.
		/// </summary>
		public ref ImGuiTableCellData RowCellData => ref Unsafe.AsRef<ImGuiTableCellData>(&NativePtr->RowCellData);

		/// <summary>
		/// Column DisplayOrder -&gt; IsEnabled map
		/// </summary>
		public IntPtr EnabledMaskByDisplayOrder { get => (IntPtr)NativePtr->EnabledMaskByDisplayOrder; set => NativePtr->EnabledMaskByDisplayOrder = (uint*)value; }

		/// <summary>
		/// Column Index -&gt; IsEnabled map (== not hidden by user/api) in a format adequate for iterating column without touching cold data
		/// </summary>
		public IntPtr EnabledMaskByIndex { get => (IntPtr)NativePtr->EnabledMaskByIndex; set => NativePtr->EnabledMaskByIndex = (uint*)value; }

		/// <summary>
		/// Column Index -&gt; IsVisibleX|IsVisibleY map (== not hidden by user/api &amp;&amp; not hidden by scrolling/cliprect)
		/// </summary>
		public IntPtr VisibleMaskByIndex { get => (IntPtr)NativePtr->VisibleMaskByIndex; set => NativePtr->VisibleMaskByIndex = (uint*)value; }

		/// <summary>
		/// Which data were loaded from the .ini file (e.g. when order is not altered we won't save order)
		/// </summary>
		public ref ImGuiTableFlags SettingsLoadedFlags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->SettingsLoadedFlags);

		/// <summary>
		/// Offset in g.SettingsTables
		/// </summary>
		public ref int SettingsOffset => ref Unsafe.AsRef<int>(&NativePtr->SettingsOffset);

		public ref int LastFrameActive => ref Unsafe.AsRef<int>(&NativePtr->LastFrameActive);

		/// <summary>
		/// Number of columns declared in BeginTable()
		/// </summary>
		public ref int ColumnsCount => ref Unsafe.AsRef<int>(&NativePtr->ColumnsCount);

		public ref int CurrentRow => ref Unsafe.AsRef<int>(&NativePtr->CurrentRow);

		public ref int CurrentColumn => ref Unsafe.AsRef<int>(&NativePtr->CurrentColumn);

		/// <summary>
		/// Count of BeginTable() calls with same ID in the same frame (generally 0). This is a little bit similar to BeginCount for a window, but multiple table with same ID look are multiple tables, they are just synched.
		/// </summary>
		public ref short InstanceCurrent => ref Unsafe.AsRef<short>(&NativePtr->InstanceCurrent);

		/// <summary>
		/// Mark which instance (generally 0) of the same ID is being interacted with
		/// </summary>
		public ref short InstanceInteracted => ref Unsafe.AsRef<short>(&NativePtr->InstanceInteracted);

		public ref float RowPosY1 => ref Unsafe.AsRef<float>(&NativePtr->RowPosY1);

		public ref float RowPosY2 => ref Unsafe.AsRef<float>(&NativePtr->RowPosY2);

		/// <summary>
		/// Height submitted to TableNextRow()
		/// </summary>
		public ref float RowMinHeight => ref Unsafe.AsRef<float>(&NativePtr->RowMinHeight);

		/// <summary>
		/// Top and bottom padding. Reloaded during row change.
		/// </summary>
		public ref float RowCellPaddingY => ref Unsafe.AsRef<float>(&NativePtr->RowCellPaddingY);

		public ref float RowTextBaseline => ref Unsafe.AsRef<float>(&NativePtr->RowTextBaseline);

		public ref float RowIndentOffsetX => ref Unsafe.AsRef<float>(&NativePtr->RowIndentOffsetX);

		/// <summary>
		/// Current row flags, see ImGuiTableRowFlags_
		/// </summary>
		public ref ImGuiTableRowFlags RowFlags => ref Unsafe.AsRef<ImGuiTableRowFlags>(&NativePtr->RowFlags);

		public ref ImGuiTableRowFlags LastRowFlags => ref Unsafe.AsRef<ImGuiTableRowFlags>(&NativePtr->LastRowFlags);

		/// <summary>
		/// Counter for alternating background colors (can be fast-forwarded by e.g clipper), not same as CurrentRow because header rows typically don't increase this.
		/// </summary>
		public ref int RowBgColorCounter => ref Unsafe.AsRef<int>(&NativePtr->RowBgColorCounter);

		/// <summary>
		/// Background color override for current row.
		/// </summary>
		public RangeAccessor<uint> RowBgColor => new RangeAccessor<uint>(NativePtr->RowBgColor, 2);

		public ref uint BorderColorStrong => ref Unsafe.AsRef<uint>(&NativePtr->BorderColorStrong);

		public ref uint BorderColorLight => ref Unsafe.AsRef<uint>(&NativePtr->BorderColorLight);

		public ref float BorderX1 => ref Unsafe.AsRef<float>(&NativePtr->BorderX1);

		public ref float BorderX2 => ref Unsafe.AsRef<float>(&NativePtr->BorderX2);

		public ref float HostIndentX => ref Unsafe.AsRef<float>(&NativePtr->HostIndentX);

		public ref float MinColumnWidth => ref Unsafe.AsRef<float>(&NativePtr->MinColumnWidth);

		public ref float OuterPaddingX => ref Unsafe.AsRef<float>(&NativePtr->OuterPaddingX);

		/// <summary>
		/// Padding from each borders. Locked in BeginTable()/Layout.
		/// </summary>
		public ref float CellPaddingX => ref Unsafe.AsRef<float>(&NativePtr->CellPaddingX);

		/// <summary>
		/// Spacing between non-bordered cells. Locked in BeginTable()/Layout.
		/// </summary>
		public ref float CellSpacingX1 => ref Unsafe.AsRef<float>(&NativePtr->CellSpacingX1);

		public ref float CellSpacingX2 => ref Unsafe.AsRef<float>(&NativePtr->CellSpacingX2);

		/// <summary>
		/// User value passed to BeginTable(), see comments at the top of BeginTable() for details.
		/// </summary>
		public ref float InnerWidth => ref Unsafe.AsRef<float>(&NativePtr->InnerWidth);

		/// <summary>
		/// Sum of current column width
		/// </summary>
		public ref float ColumnsGivenWidth => ref Unsafe.AsRef<float>(&NativePtr->ColumnsGivenWidth);

		/// <summary>
		/// Sum of ideal column width in order nothing to be clipped, used for auto-fitting and content width submission in outer window
		/// </summary>
		public ref float ColumnsAutoFitWidth => ref Unsafe.AsRef<float>(&NativePtr->ColumnsAutoFitWidth);

		/// <summary>
		/// Sum of weight of all enabled stretching columns
		/// </summary>
		public ref float ColumnsStretchSumWeights => ref Unsafe.AsRef<float>(&NativePtr->ColumnsStretchSumWeights);

		public ref float ResizedColumnNextWidth => ref Unsafe.AsRef<float>(&NativePtr->ResizedColumnNextWidth);

		/// <summary>
		/// Lock minimum contents width while resizing down in order to not create feedback loops. But we allow growing the table.
		/// </summary>
		public ref float ResizeLockMinContentsX2 => ref Unsafe.AsRef<float>(&NativePtr->ResizeLockMinContentsX2);

		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.
		/// </summary>
		public ref float RefScale => ref Unsafe.AsRef<float>(&NativePtr->RefScale);

		/// <summary>
		/// Set by TableAngledHeadersRow(), used in TableUpdateLayout()
		/// </summary>
		public ref float AngledHeadersHeight => ref Unsafe.AsRef<float>(&NativePtr->AngledHeadersHeight);

		/// <summary>
		/// Set by TableAngledHeadersRow(), used in TableUpdateLayout()
		/// </summary>
		public ref float AngledHeadersSlope => ref Unsafe.AsRef<float>(&NativePtr->AngledHeadersSlope);

		/// <summary>
		/// Note: for non-scrolling table, OuterRect.Max.y is often FLT_MAX until EndTable(), unless a height has been specified in BeginTable().
		/// </summary>
		public ref ImRect OuterRect => ref Unsafe.AsRef<ImRect>(&NativePtr->OuterRect);

		/// <summary>
		/// InnerRect but without decoration. As with OuterRect, for non-scrolling tables, InnerRect.Max.y is
		/// </summary>
		public ref ImRect InnerRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerRect);

		public ref ImRect WorkRect => ref Unsafe.AsRef<ImRect>(&NativePtr->WorkRect);

		public ref ImRect InnerClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->InnerClipRect);

		/// <summary>
		/// We use this to cpu-clip cell background color fill, evolve during the frame as we cross frozen rows boundaries
		/// </summary>
		public ref ImRect BgClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->BgClipRect);

		/// <summary>
		/// Actual ImDrawCmd clip rect for BG0/1 channel. This tends to be == OuterWindow-&gt;ClipRect at BeginTable() because output in BG0/BG1 is cpu-clipped
		/// </summary>
		public ref ImRect Bg0ClipRectForDrawCmd => ref Unsafe.AsRef<ImRect>(&NativePtr->Bg0ClipRectForDrawCmd);

		/// <summary>
		/// Actual ImDrawCmd clip rect for BG2 channel. This tends to be a correct, tight-fit, because output to BG2 are done by widgets relying on regular ClipRect.
		/// </summary>
		public ref ImRect Bg2ClipRectForDrawCmd => ref Unsafe.AsRef<ImRect>(&NativePtr->Bg2ClipRectForDrawCmd);

		/// <summary>
		/// This is used to check if we can eventually merge our columns draw calls into the current draw call of the current window.
		/// </summary>
		public ref ImRect HostClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostClipRect);

		/// <summary>
		/// Backup of InnerWindow-&gt;ClipRect during PushTableBackground()/PopTableBackground()
		/// </summary>
		public ref ImRect HostBackupInnerClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->HostBackupInnerClipRect);

		/// <summary>
		/// Parent window for the table
		/// </summary>
		public ImGuiWindowPtr OuterWindow => new ImGuiWindowPtr(NativePtr->OuterWindow);

		/// <summary>
		/// Window holding the table data (== OuterWindow or a child window)
		/// </summary>
		public ImGuiWindowPtr InnerWindow => new ImGuiWindowPtr(NativePtr->InnerWindow);

		/// <summary>
		/// Contiguous buffer holding columns names
		/// </summary>
		public ref ImGuiTextBuffer ColumnsNames => ref Unsafe.AsRef<ImGuiTextBuffer>(&NativePtr->ColumnsNames);

		/// <summary>
		/// Shortcut to TempData-&gt;DrawSplitter while in table. Isolate draw commands per columns to avoid switching clip rect constantly
		/// </summary>
		public ImDrawListSplitterPtr DrawSplitter => new ImDrawListSplitterPtr(NativePtr->DrawSplitter);

		public ref ImGuiTableInstanceData InstanceDataFirst => ref Unsafe.AsRef<ImGuiTableInstanceData>(&NativePtr->InstanceDataFirst);

		/// <summary>
		/// FIXME-OPT: Using a small-vector pattern would be good.
		/// </summary>
		public ImPtrVector<ImGuiTableInstanceDataPtr> InstanceDataExtra => new ImPtrVector<ImGuiTableInstanceDataPtr>(NativePtr->InstanceDataExtra, Unsafe.SizeOf<ImGuiTableInstanceData>());

		public ref ImGuiTableColumnSortSpecs SortSpecsSingle => ref Unsafe.AsRef<ImGuiTableColumnSortSpecs>(&NativePtr->SortSpecsSingle);

		/// <summary>
		/// FIXME-OPT: Using a small-vector pattern would be good.
		/// </summary>
		public ImPtrVector<ImGuiTableColumnSortSpecsPtr> SortSpecsMulti => new ImPtrVector<ImGuiTableColumnSortSpecsPtr>(NativePtr->SortSpecsMulti, Unsafe.SizeOf<ImGuiTableColumnSortSpecs>());

		/// <summary>
		/// Public facing sorts specs, this is what we return in TableGetSortSpecs()
		/// </summary>
		public ref ImGuiTableSortSpecs SortSpecs => ref Unsafe.AsRef<ImGuiTableSortSpecs>(&NativePtr->SortSpecs);

		public ref short SortSpecsCount => ref Unsafe.AsRef<short>(&NativePtr->SortSpecsCount);

		/// <summary>
		/// Number of enabled columns (&lt;= ColumnsCount)
		/// </summary>
		public ref short ColumnsEnabledCount => ref Unsafe.AsRef<short>(&NativePtr->ColumnsEnabledCount);

		/// <summary>
		/// Number of enabled columns using fixed width (&lt;= ColumnsCount)
		/// </summary>
		public ref short ColumnsEnabledFixedCount => ref Unsafe.AsRef<short>(&NativePtr->ColumnsEnabledFixedCount);

		/// <summary>
		/// Count calls to TableSetupColumn()
		/// </summary>
		public ref short DeclColumnsCount => ref Unsafe.AsRef<short>(&NativePtr->DeclColumnsCount);

		/// <summary>
		/// Count columns with angled headers
		/// </summary>
		public ref short AngledHeadersCount => ref Unsafe.AsRef<short>(&NativePtr->AngledHeadersCount);

		/// <summary>
		/// Index of column whose visible region is being hovered. Important: == ColumnsCount when hovering empty region after the right-most column!
		/// </summary>
		public ref short HoveredColumnBody => ref Unsafe.AsRef<short>(&NativePtr->HoveredColumnBody);

		/// <summary>
		/// Index of column whose right-border is being hovered (for resizing).
		/// </summary>
		public ref short HoveredColumnBorder => ref Unsafe.AsRef<short>(&NativePtr->HoveredColumnBorder);

		/// <summary>
		/// Index of column which should be highlighted.
		/// </summary>
		public ref short HighlightColumnHeader => ref Unsafe.AsRef<short>(&NativePtr->HighlightColumnHeader);

		/// <summary>
		/// Index of single column requesting auto-fit.
		/// </summary>
		public ref short AutoFitSingleColumn => ref Unsafe.AsRef<short>(&NativePtr->AutoFitSingleColumn);

		/// <summary>
		/// Index of column being resized. Reset when InstanceCurrent==0.
		/// </summary>
		public ref short ResizedColumn => ref Unsafe.AsRef<short>(&NativePtr->ResizedColumn);

		/// <summary>
		/// Index of column being resized from previous frame.
		/// </summary>
		public ref short LastResizedColumn => ref Unsafe.AsRef<short>(&NativePtr->LastResizedColumn);

		/// <summary>
		/// Index of column header being held.
		/// </summary>
		public ref short HeldHeaderColumn => ref Unsafe.AsRef<short>(&NativePtr->HeldHeaderColumn);

		/// <summary>
		/// Index of column being reordered. (not cleared)
		/// </summary>
		public ref short ReorderColumn => ref Unsafe.AsRef<short>(&NativePtr->ReorderColumn);

		/// <summary>
		/// -1 or +1
		/// </summary>
		public ref short ReorderColumnDir => ref Unsafe.AsRef<short>(&NativePtr->ReorderColumnDir);

		/// <summary>
		/// Index of left-most non-hidden column.
		/// </summary>
		public ref short LeftMostEnabledColumn => ref Unsafe.AsRef<short>(&NativePtr->LeftMostEnabledColumn);

		/// <summary>
		/// Index of right-most non-hidden column.
		/// </summary>
		public ref short RightMostEnabledColumn => ref Unsafe.AsRef<short>(&NativePtr->RightMostEnabledColumn);

		/// <summary>
		/// Index of left-most stretched column.
		/// </summary>
		public ref short LeftMostStretchedColumn => ref Unsafe.AsRef<short>(&NativePtr->LeftMostStretchedColumn);

		/// <summary>
		/// Index of right-most stretched column.
		/// </summary>
		public ref short RightMostStretchedColumn => ref Unsafe.AsRef<short>(&NativePtr->RightMostStretchedColumn);

		/// <summary>
		/// Column right-clicked on, of -1 if opening context menu from a neutral/empty spot
		/// </summary>
		public ref short ContextPopupColumn => ref Unsafe.AsRef<short>(&NativePtr->ContextPopupColumn);

		/// <summary>
		/// Requested frozen rows count
		/// </summary>
		public ref short FreezeRowsRequest => ref Unsafe.AsRef<short>(&NativePtr->FreezeRowsRequest);

		/// <summary>
		/// Actual frozen row count (== FreezeRowsRequest, or == 0 when no scrolling offset)
		/// </summary>
		public ref short FreezeRowsCount => ref Unsafe.AsRef<short>(&NativePtr->FreezeRowsCount);

		/// <summary>
		/// Requested frozen columns count
		/// </summary>
		public ref short FreezeColumnsRequest => ref Unsafe.AsRef<short>(&NativePtr->FreezeColumnsRequest);

		/// <summary>
		/// Actual frozen columns count (== FreezeColumnsRequest, or == 0 when no scrolling offset)
		/// </summary>
		public ref short FreezeColumnsCount => ref Unsafe.AsRef<short>(&NativePtr->FreezeColumnsCount);

		/// <summary>
		/// Index of current RowCellData[] entry in current row
		/// </summary>
		public ref short RowCellDataCurrent => ref Unsafe.AsRef<short>(&NativePtr->RowCellDataCurrent);

		/// <summary>
		/// Redirect non-visible columns here.
		/// </summary>
		public ref ushort DummyDrawChannel => ref Unsafe.AsRef<ushort>(&NativePtr->DummyDrawChannel);

		/// <summary>
		/// For Selectable() and other widgets drawing across columns after the freezing line. Index within DrawSplitter.Channels[]
		/// </summary>
		public ref ushort Bg2DrawChannelCurrent => ref Unsafe.AsRef<ushort>(&NativePtr->Bg2DrawChannelCurrent);

		public ref ushort Bg2DrawChannelUnfrozen => ref Unsafe.AsRef<ushort>(&NativePtr->Bg2DrawChannelUnfrozen);

		/// <summary>
		/// Set by TableUpdateLayout() which is called when beginning the first row.
		/// </summary>
		public ref bool IsLayoutLocked => ref Unsafe.AsRef<bool>(&NativePtr->IsLayoutLocked);

		/// <summary>
		/// Set when inside TableBeginRow()/TableEndRow().
		/// </summary>
		public ref bool IsInsideRow => ref Unsafe.AsRef<bool>(&NativePtr->IsInsideRow);

		public ref bool IsInitializing => ref Unsafe.AsRef<bool>(&NativePtr->IsInitializing);

		public ref bool IsSortSpecsDirty => ref Unsafe.AsRef<bool>(&NativePtr->IsSortSpecsDirty);

		/// <summary>
		/// Set when the first row had the ImGuiTableRowFlags_Headers flag.
		/// </summary>
		public ref bool IsUsingHeaders => ref Unsafe.AsRef<bool>(&NativePtr->IsUsingHeaders);

		/// <summary>
		/// Set when default context menu is open (also see: ContextPopupColumn, InstanceInteracted).
		/// </summary>
		public ref bool IsContextPopupOpen => ref Unsafe.AsRef<bool>(&NativePtr->IsContextPopupOpen);

		/// <summary>
		/// Disable default context menu contents. You may submit your own using TableBeginContextMenuPopup()/EndPopup()
		/// </summary>
		public ref bool DisableDefaultContextMenu => ref Unsafe.AsRef<bool>(&NativePtr->DisableDefaultContextMenu);

		public ref bool IsSettingsRequestLoad => ref Unsafe.AsRef<bool>(&NativePtr->IsSettingsRequestLoad);

		/// <summary>
		/// Set when table settings have changed and needs to be reported into ImGuiTableSetttings data.
		/// </summary>
		public ref bool IsSettingsDirty => ref Unsafe.AsRef<bool>(&NativePtr->IsSettingsDirty);

		/// <summary>
		/// Set when display order is unchanged from default (DisplayOrder contains 0...Count-1)
		/// </summary>
		public ref bool IsDefaultDisplayOrder => ref Unsafe.AsRef<bool>(&NativePtr->IsDefaultDisplayOrder);

		public ref bool IsResetAllRequest => ref Unsafe.AsRef<bool>(&NativePtr->IsResetAllRequest);

		public ref bool IsResetDisplayOrderRequest => ref Unsafe.AsRef<bool>(&NativePtr->IsResetDisplayOrderRequest);

		/// <summary>
		/// Set when we got past the frozen row.
		/// </summary>
		public ref bool IsUnfrozenRows => ref Unsafe.AsRef<bool>(&NativePtr->IsUnfrozenRows);

		/// <summary>
		/// Set if user didn't explicitly set a sizing policy in BeginTable()
		/// </summary>
		public ref bool IsDefaultSizingPolicy => ref Unsafe.AsRef<bool>(&NativePtr->IsDefaultSizingPolicy);

		public ref bool IsActiveIdAliveBeforeTable => ref Unsafe.AsRef<bool>(&NativePtr->IsActiveIdAliveBeforeTable);

		public ref bool IsActiveIdInTable => ref Unsafe.AsRef<bool>(&NativePtr->IsActiveIdInTable);

		/// <summary>
		/// Whether ANY instance of this table had a vertical scrollbar during the current frame.
		/// </summary>
		public ref bool HasScrollbarYCurr => ref Unsafe.AsRef<bool>(&NativePtr->HasScrollbarYCurr);

		/// <summary>
		/// Whether ANY instance of this table had a vertical scrollbar during the previous.
		/// </summary>
		public ref bool HasScrollbarYPrev => ref Unsafe.AsRef<bool>(&NativePtr->HasScrollbarYPrev);

		public ref bool MemoryCompacted => ref Unsafe.AsRef<bool>(&NativePtr->MemoryCompacted);

		/// <summary>
		/// Backup of InnerWindow-&gt;SkipItem at the end of BeginTable(), because we will overwrite InnerWindow-&gt;SkipItem on a per-column basis
		/// </summary>
		public ref bool HostSkipItems => ref Unsafe.AsRef<bool>(&NativePtr->HostSkipItems);
	}
}
