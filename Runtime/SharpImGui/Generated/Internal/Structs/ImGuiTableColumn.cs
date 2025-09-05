using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// [Internal] sizeof() ~ 112<br/>We use the terminology "Enabled" to refer to a column that is not Hidden by user/api.<br/>We use the terminology "Clipped" to refer to a column that is out of sight because of scrolling/clipping.<br/>This is in contrast with some user-facing api such as IsItemVisible() / IsRectVisible() which use "Visible" to mean "not clipped".<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableColumn
	{
		/// <summary>
		/// Flags after some patching (not directly same as provided by user). See ImGuiTableColumnFlags_<br/>
		/// </summary>
		public ImGuiTableColumnFlags Flags;
		/// <summary>
		/// Final/actual width visible == (MaxX - MinX), locked in TableUpdateLayout(). May be &gt; WidthRequest to honor minimum width, may be &lt; WidthRequest to honor shrinking columns down in tight space.<br/>
		/// </summary>
		public float WidthGiven;
		/// <summary>
		/// Absolute positions<br/>
		/// </summary>
		public float MinX;
		public float MaxX;
		/// <summary>
		/// Master width absolute value when !(Flags & _WidthStretch). When Stretch this is derived every frame from StretchWeight in TableUpdateLayout()<br/>
		/// </summary>
		public float WidthRequest;
		/// <summary>
		/// Automatic width<br/>
		/// </summary>
		public float WidthAuto;
		/// <summary>
		/// Maximum width (FIXME: overwritten by each instance)<br/>
		/// </summary>
		public float WidthMax;
		/// <summary>
		/// Master width weight when (Flags & _WidthStretch). Often around ~1.0f initially.<br/>
		/// </summary>
		public float StretchWeight;
		/// <summary>
		/// Value passed to TableSetupColumn(). For Width it is a content width (_without padding_).<br/>
		/// </summary>
		public float InitStretchWeightOrWidth;
		/// <summary>
		/// Clipping rectangle for the column<br/>
		/// </summary>
		public ImRect ClipRect;
		/// <summary>
		/// Optional, value passed to TableSetupColumn()<br/>
		/// </summary>
		public uint UserID;
		/// <summary>
		/// Contents region min ~(MinX + CellPaddingX + CellSpacingX1) == cursor start position when entering column<br/>
		/// </summary>
		public float WorkMinX;
		/// <summary>
		/// Contents region max ~(MaxX - CellPaddingX - CellSpacingX2)<br/>
		/// </summary>
		public float WorkMaxX;
		/// <summary>
		/// Current item width for the column, preserved across rows<br/>
		/// </summary>
		public float ItemWidth;
		/// <summary>
		/// Contents maximum position for frozen rows (apart from headers), from which we can infer content width.<br/>
		/// </summary>
		public float ContentMaxXFrozen;
		public float ContentMaxXUnfrozen;
		/// <summary>
		/// Contents maximum position for headers rows (regardless of freezing). TableHeader() automatically softclip itself + report ideal desired size, to avoid creating extraneous draw calls<br/>
		/// </summary>
		public float ContentMaxXHeadersUsed;
		public float ContentMaxXHeadersIdeal;
		/// <summary>
		/// Offset into parent ColumnsNames[]<br/>
		/// </summary>
		public short NameOffset;
		/// <summary>
		/// Index within Table's IndexToDisplayOrder[] (column may be reordered by users)<br/>
		/// </summary>
		public short DisplayOrder;
		/// <summary>
		/// Index within enabled/visible set (&lt;= IndexToDisplayOrder)<br/>
		/// </summary>
		public short IndexWithinEnabledSet;
		/// <summary>
		/// Index of prev enabled/visible column within Columns[], -1 if first enabled/visible column<br/>
		/// </summary>
		public short PrevEnabledColumn;
		/// <summary>
		/// Index of next enabled/visible column within Columns[], -1 if last enabled/visible column<br/>
		/// </summary>
		public short NextEnabledColumn;
		/// <summary>
		/// Index of this column within sort specs, -1 if not sorting on this column, 0 for single-sort, may be &gt;0 on multi-sort<br/>
		/// </summary>
		public short SortOrder;
		/// <summary>
		/// Index within DrawSplitter.Channels[]<br/>
		/// </summary>
		public ushort DrawChannelCurrent;
		/// <summary>
		/// Draw channels for frozen rows (often headers)<br/>
		/// </summary>
		public ushort DrawChannelFrozen;
		/// <summary>
		/// Draw channels for unfrozen rows<br/>
		/// </summary>
		public ushort DrawChannelUnfrozen;
		/// <summary>
		/// IsUserEnabled && (Flags & ImGuiTableColumnFlags_Disabled) == 0<br/>
		/// </summary>
		public byte IsEnabled;
		/// <summary>
		/// Is the column not marked Hidden by the user? (unrelated to being off view, e.g. clipped by scrolling).<br/>
		/// </summary>
		public byte IsUserEnabled;
		public byte IsUserEnabledNextFrame;
		/// <summary>
		/// Is actually in view (e.g. overlapping the host window clipping rectangle, not scrolled).<br/>
		/// </summary>
		public byte IsVisibleX;
		public byte IsVisibleY;
		/// <summary>
		/// Return value for TableSetColumnIndex() / TableNextColumn(): whether we request user to output contents or not.<br/>
		/// </summary>
		public byte IsRequestOutput;
		/// <summary>
		/// Do we want item submissions to this column to be completely ignored (no layout will happen).<br/>
		/// </summary>
		public byte IsSkipItems;
		public byte IsPreserveWidthAuto;
		/// <summary>
		/// ImGuiNavLayer in 1 byte<br/>
		/// </summary>
		public sbyte NavLayerCurrent;
		/// <summary>
		/// Queue of 8 values for the next 8 frames to request auto-fit<br/>
		/// </summary>
		public byte AutoFitQueue;
		/// <summary>
		/// Queue of 8 values for the next 8 frames to disable Clipped/SkipItem<br/>
		/// </summary>
		public byte CannotSkipItemsQueue;
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending<br/>
		/// </summary>
		public byte SortDirection;
		/// <summary>
		/// Number of available sort directions (0 to 3)<br/>
		/// </summary>
		public byte SortDirectionsAvailCount;
		/// <summary>
		/// Mask of available sort directions (1-bit each)<br/>
		/// </summary>
		public byte SortDirectionsAvailMask;
		/// <summary>
		/// Ordered list of available sort directions (2-bits each, total 8-bits)<br/>
		/// </summary>
		public byte SortDirectionsAvailList;
	}

	/// <summary>
	/// [Internal] sizeof() ~ 112<br/>We use the terminology "Enabled" to refer to a column that is not Hidden by user/api.<br/>We use the terminology "Clipped" to refer to a column that is out of sight because of scrolling/clipping.<br/>This is in contrast with some user-facing api such as IsItemVisible() / IsRectVisible() which use "Visible" to mean "not clipped".<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableColumnPtr
	{
		public ImGuiTableColumn* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableColumn this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Flags after some patching (not directly same as provided by user). See ImGuiTableColumnFlags_<br/>
		/// </summary>
		public ref ImGuiTableColumnFlags Flags => ref Unsafe.AsRef<ImGuiTableColumnFlags>(&NativePtr->Flags);
		/// <summary>
		/// Final/actual width visible == (MaxX - MinX), locked in TableUpdateLayout(). May be &gt; WidthRequest to honor minimum width, may be &lt; WidthRequest to honor shrinking columns down in tight space.<br/>
		/// </summary>
		public ref float WidthGiven => ref Unsafe.AsRef<float>(&NativePtr->WidthGiven);
		/// <summary>
		/// Absolute positions<br/>
		/// </summary>
		public ref float MinX => ref Unsafe.AsRef<float>(&NativePtr->MinX);
		public ref float MaxX => ref Unsafe.AsRef<float>(&NativePtr->MaxX);
		/// <summary>
		/// Master width absolute value when !(Flags & _WidthStretch). When Stretch this is derived every frame from StretchWeight in TableUpdateLayout()<br/>
		/// </summary>
		public ref float WidthRequest => ref Unsafe.AsRef<float>(&NativePtr->WidthRequest);
		/// <summary>
		/// Automatic width<br/>
		/// </summary>
		public ref float WidthAuto => ref Unsafe.AsRef<float>(&NativePtr->WidthAuto);
		/// <summary>
		/// Maximum width (FIXME: overwritten by each instance)<br/>
		/// </summary>
		public ref float WidthMax => ref Unsafe.AsRef<float>(&NativePtr->WidthMax);
		/// <summary>
		/// Master width weight when (Flags & _WidthStretch). Often around ~1.0f initially.<br/>
		/// </summary>
		public ref float StretchWeight => ref Unsafe.AsRef<float>(&NativePtr->StretchWeight);
		/// <summary>
		/// Value passed to TableSetupColumn(). For Width it is a content width (_without padding_).<br/>
		/// </summary>
		public ref float InitStretchWeightOrWidth => ref Unsafe.AsRef<float>(&NativePtr->InitStretchWeightOrWidth);
		/// <summary>
		/// Clipping rectangle for the column<br/>
		/// </summary>
		public ref ImRect ClipRect => ref Unsafe.AsRef<ImRect>(&NativePtr->ClipRect);
		/// <summary>
		/// Optional, value passed to TableSetupColumn()<br/>
		/// </summary>
		public ref uint UserID => ref Unsafe.AsRef<uint>(&NativePtr->UserID);
		/// <summary>
		/// Contents region min ~(MinX + CellPaddingX + CellSpacingX1) == cursor start position when entering column<br/>
		/// </summary>
		public ref float WorkMinX => ref Unsafe.AsRef<float>(&NativePtr->WorkMinX);
		/// <summary>
		/// Contents region max ~(MaxX - CellPaddingX - CellSpacingX2)<br/>
		/// </summary>
		public ref float WorkMaxX => ref Unsafe.AsRef<float>(&NativePtr->WorkMaxX);
		/// <summary>
		/// Current item width for the column, preserved across rows<br/>
		/// </summary>
		public ref float ItemWidth => ref Unsafe.AsRef<float>(&NativePtr->ItemWidth);
		/// <summary>
		/// Contents maximum position for frozen rows (apart from headers), from which we can infer content width.<br/>
		/// </summary>
		public ref float ContentMaxXFrozen => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXFrozen);
		public ref float ContentMaxXUnfrozen => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXUnfrozen);
		/// <summary>
		/// Contents maximum position for headers rows (regardless of freezing). TableHeader() automatically softclip itself + report ideal desired size, to avoid creating extraneous draw calls<br/>
		/// </summary>
		public ref float ContentMaxXHeadersUsed => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXHeadersUsed);
		public ref float ContentMaxXHeadersIdeal => ref Unsafe.AsRef<float>(&NativePtr->ContentMaxXHeadersIdeal);
		/// <summary>
		/// Offset into parent ColumnsNames[]<br/>
		/// </summary>
		public ref short NameOffset => ref Unsafe.AsRef<short>(&NativePtr->NameOffset);
		/// <summary>
		/// Index within Table's IndexToDisplayOrder[] (column may be reordered by users)<br/>
		/// </summary>
		public ref short DisplayOrder => ref Unsafe.AsRef<short>(&NativePtr->DisplayOrder);
		/// <summary>
		/// Index within enabled/visible set (&lt;= IndexToDisplayOrder)<br/>
		/// </summary>
		public ref short IndexWithinEnabledSet => ref Unsafe.AsRef<short>(&NativePtr->IndexWithinEnabledSet);
		/// <summary>
		/// Index of prev enabled/visible column within Columns[], -1 if first enabled/visible column<br/>
		/// </summary>
		public ref short PrevEnabledColumn => ref Unsafe.AsRef<short>(&NativePtr->PrevEnabledColumn);
		/// <summary>
		/// Index of next enabled/visible column within Columns[], -1 if last enabled/visible column<br/>
		/// </summary>
		public ref short NextEnabledColumn => ref Unsafe.AsRef<short>(&NativePtr->NextEnabledColumn);
		/// <summary>
		/// Index of this column within sort specs, -1 if not sorting on this column, 0 for single-sort, may be &gt;0 on multi-sort<br/>
		/// </summary>
		public ref short SortOrder => ref Unsafe.AsRef<short>(&NativePtr->SortOrder);
		/// <summary>
		/// Index within DrawSplitter.Channels[]<br/>
		/// </summary>
		public ref ushort DrawChannelCurrent => ref Unsafe.AsRef<ushort>(&NativePtr->DrawChannelCurrent);
		/// <summary>
		/// Draw channels for frozen rows (often headers)<br/>
		/// </summary>
		public ref ushort DrawChannelFrozen => ref Unsafe.AsRef<ushort>(&NativePtr->DrawChannelFrozen);
		/// <summary>
		/// Draw channels for unfrozen rows<br/>
		/// </summary>
		public ref ushort DrawChannelUnfrozen => ref Unsafe.AsRef<ushort>(&NativePtr->DrawChannelUnfrozen);
		/// <summary>
		/// IsUserEnabled && (Flags & ImGuiTableColumnFlags_Disabled) == 0<br/>
		/// </summary>
		public ref bool IsEnabled => ref Unsafe.AsRef<bool>(&NativePtr->IsEnabled);
		/// <summary>
		/// Is the column not marked Hidden by the user? (unrelated to being off view, e.g. clipped by scrolling).<br/>
		/// </summary>
		public ref bool IsUserEnabled => ref Unsafe.AsRef<bool>(&NativePtr->IsUserEnabled);
		public ref bool IsUserEnabledNextFrame => ref Unsafe.AsRef<bool>(&NativePtr->IsUserEnabledNextFrame);
		/// <summary>
		/// Is actually in view (e.g. overlapping the host window clipping rectangle, not scrolled).<br/>
		/// </summary>
		public ref bool IsVisibleX => ref Unsafe.AsRef<bool>(&NativePtr->IsVisibleX);
		public ref bool IsVisibleY => ref Unsafe.AsRef<bool>(&NativePtr->IsVisibleY);
		/// <summary>
		/// Return value for TableSetColumnIndex() / TableNextColumn(): whether we request user to output contents or not.<br/>
		/// </summary>
		public ref bool IsRequestOutput => ref Unsafe.AsRef<bool>(&NativePtr->IsRequestOutput);
		/// <summary>
		/// Do we want item submissions to this column to be completely ignored (no layout will happen).<br/>
		/// </summary>
		public ref bool IsSkipItems => ref Unsafe.AsRef<bool>(&NativePtr->IsSkipItems);
		public ref bool IsPreserveWidthAuto => ref Unsafe.AsRef<bool>(&NativePtr->IsPreserveWidthAuto);
		/// <summary>
		/// ImGuiNavLayer in 1 byte<br/>
		/// </summary>
		public ref sbyte NavLayerCurrent => ref Unsafe.AsRef<sbyte>(&NativePtr->NavLayerCurrent);
		/// <summary>
		/// Queue of 8 values for the next 8 frames to request auto-fit<br/>
		/// </summary>
		public ref bool AutoFitQueue => ref Unsafe.AsRef<bool>(&NativePtr->AutoFitQueue);
		/// <summary>
		/// Queue of 8 values for the next 8 frames to disable Clipped/SkipItem<br/>
		/// </summary>
		public ref bool CannotSkipItemsQueue => ref Unsafe.AsRef<bool>(&NativePtr->CannotSkipItemsQueue);
		/// <summary>
		/// ImGuiSortDirection_Ascending or ImGuiSortDirection_Descending<br/>
		/// </summary>
		public ref bool SortDirection => ref Unsafe.AsRef<bool>(&NativePtr->SortDirection);
		/// <summary>
		/// Number of available sort directions (0 to 3)<br/>
		/// </summary>
		public ref bool SortDirectionsAvailCount => ref Unsafe.AsRef<bool>(&NativePtr->SortDirectionsAvailCount);
		/// <summary>
		/// Mask of available sort directions (1-bit each)<br/>
		/// </summary>
		public ref bool SortDirectionsAvailMask => ref Unsafe.AsRef<bool>(&NativePtr->SortDirectionsAvailMask);
		/// <summary>
		/// Ordered list of available sort directions (2-bits each, total 8-bits)<br/>
		/// </summary>
		public ref bool SortDirectionsAvailList => ref Unsafe.AsRef<bool>(&NativePtr->SortDirectionsAvailList);
		public ImGuiTableColumnPtr(ImGuiTableColumn* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableColumnPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableColumn*)nativePtr;
		public static implicit operator ImGuiTableColumnPtr(ImGuiTableColumn* ptr) => new ImGuiTableColumnPtr(ptr);
		public static implicit operator ImGuiTableColumnPtr(IntPtr ptr) => new ImGuiTableColumnPtr(ptr);
		public static implicit operator ImGuiTableColumn*(ImGuiTableColumnPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTableColumnDestroy(NativePtr);
		}

		public void ImGuiTableColumnConstruct()
		{
			ImGuiNative.ImGuiTableColumnImGuiTableColumnConstruct(NativePtr);
		}

		public ImGuiTableColumnPtr ImGuiTableColumn()
		{
			return ImGuiNative.ImGuiTableColumnImGuiTableColumn();
		}

	}
}
