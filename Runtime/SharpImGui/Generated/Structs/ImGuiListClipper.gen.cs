using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Helper: Manually clip large list of items.</para>
	/// <para>If you have lots evenly spaced items and you have random access to the list, you can perform coarse</para>
	/// <para>clipping based on visibility to only submit items that are in view.</para>
	/// <para>The clipper calculates the range of visible items and advance the cursor to compensate for the non-visible items we have skipped.</para>
	/// <para>(Dear ImGui already clip items based on their bounds but: it needs to first layout the item to do so, and generally</para>
	/// <para> fetching/submitting your own data incurs additional cost. Coarse clipping using ImGuiListClipper allows you to easily</para>
	/// <para> scale using lists with tens of thousands of items without a problem)</para>
	/// <para>Usage:</para>
	/// <para>  ImGuiListClipper clipper;</para>
	/// <para>  clipper.Begin(1000);         // We have 1000 elements, evenly spaced.</para>
	/// <para>  while (clipper.Step())</para>
	/// <para>      for (int i = clipper.DisplayStart; i &lt; clipper.DisplayEnd; i++)</para>
	/// <para>          ImGui::Text("line number %d", i);</para>
	/// <para>Generally what happens is:</para>
	/// <para>- Clipper lets you process the first element (DisplayStart = 0, DisplayEnd = 1) regardless of it being visible or not.</para>
	/// <para>- User code submit that one element.</para>
	/// <para>- Clipper can measure the height of the first element</para>
	/// <para>- Clipper calculate the actual range of elements to display based on the current clipping rectangle, position the cursor before the first visible element.</para>
	/// <para>- User code submit visible elements.</para>
	/// <para>- The clipper also handles various subtleties related to keyboard/gamepad navigation, wrapping etc.</para>
	/// </summary>
	public unsafe partial struct ImGuiListClipper
	{
		/// <summary>
		/// Parent UI context
		/// </summary>
		public IntPtr Ctx;
		/// <summary>
		/// First item to display, updated by each call to Step()
		/// </summary>
		public int DisplayStart;
		/// <summary>
		/// End of items to display (exclusive)
		/// </summary>
		public int DisplayEnd;
		/// <summary>
		/// [Internal] Number of items
		/// </summary>
		public int ItemsCount;
		/// <summary>
		/// [Internal] Height of item after a first step and item submission can calculate it
		/// </summary>
		public float ItemsHeight;
		/// <summary>
		/// [Internal] Cursor position at the time of Begin() or after table frozen rows are all processed
		/// </summary>
		public float StartPosY;
		/// <summary>
		/// [Internal] Account for frozen rows in a table and initial loss of precision in very large windows.
		/// </summary>
		public double StartSeekOffsetY;
		/// <summary>
		/// [Internal] Internal data
		/// </summary>
		public void* TempData;
	}

	/// <summary>
	/// <para>Helper: Manually clip large list of items.</para>
	/// <para>If you have lots evenly spaced items and you have random access to the list, you can perform coarse</para>
	/// <para>clipping based on visibility to only submit items that are in view.</para>
	/// <para>The clipper calculates the range of visible items and advance the cursor to compensate for the non-visible items we have skipped.</para>
	/// <para>(Dear ImGui already clip items based on their bounds but: it needs to first layout the item to do so, and generally</para>
	/// <para> fetching/submitting your own data incurs additional cost. Coarse clipping using ImGuiListClipper allows you to easily</para>
	/// <para> scale using lists with tens of thousands of items without a problem)</para>
	/// <para>Usage:</para>
	/// <para>  ImGuiListClipper clipper;</para>
	/// <para>  clipper.Begin(1000);         // We have 1000 elements, evenly spaced.</para>
	/// <para>  while (clipper.Step())</para>
	/// <para>      for (int i = clipper.DisplayStart; i &lt; clipper.DisplayEnd; i++)</para>
	/// <para>          ImGui::Text("line number %d", i);</para>
	/// <para>Generally what happens is:</para>
	/// <para>- Clipper lets you process the first element (DisplayStart = 0, DisplayEnd = 1) regardless of it being visible or not.</para>
	/// <para>- User code submit that one element.</para>
	/// <para>- Clipper can measure the height of the first element</para>
	/// <para>- Clipper calculate the actual range of elements to display based on the current clipping rectangle, position the cursor before the first visible element.</para>
	/// <para>- User code submit visible elements.</para>
	/// <para>- The clipper also handles various subtleties related to keyboard/gamepad navigation, wrapping etc.</para>
	/// </summary>
	public unsafe partial struct ImGuiListClipperPtr
	{
		public ImGuiListClipper* NativePtr { get; }
		public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipper*)nativePtr;
		public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => new ImGuiListClipperPtr(nativePtr);
		public static implicit operator ImGuiListClipper* (ImGuiListClipperPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiListClipperPtr(IntPtr nativePtr) => new ImGuiListClipperPtr(nativePtr);

		/// <summary>
		/// Parent UI context
		/// </summary>
		public ref IntPtr Ctx => ref Unsafe.AsRef<IntPtr>(&NativePtr->Ctx);

		/// <summary>
		/// First item to display, updated by each call to Step()
		/// </summary>
		public ref int DisplayStart => ref Unsafe.AsRef<int>(&NativePtr->DisplayStart);

		/// <summary>
		/// End of items to display (exclusive)
		/// </summary>
		public ref int DisplayEnd => ref Unsafe.AsRef<int>(&NativePtr->DisplayEnd);

		/// <summary>
		/// [Internal] Number of items
		/// </summary>
		public ref int ItemsCount => ref Unsafe.AsRef<int>(&NativePtr->ItemsCount);

		/// <summary>
		/// [Internal] Height of item after a first step and item submission can calculate it
		/// </summary>
		public ref float ItemsHeight => ref Unsafe.AsRef<float>(&NativePtr->ItemsHeight);

		/// <summary>
		/// [Internal] Cursor position at the time of Begin() or after table frozen rows are all processed
		/// </summary>
		public ref float StartPosY => ref Unsafe.AsRef<float>(&NativePtr->StartPosY);

		/// <summary>
		/// [Internal] Account for frozen rows in a table and initial loss of precision in very large windows.
		/// </summary>
		public ref double StartSeekOffsetY => ref Unsafe.AsRef<double>(&NativePtr->StartSeekOffsetY);

		/// <summary>
		/// [Internal] Internal data
		/// </summary>
		public IntPtr TempData { get => (IntPtr)NativePtr->TempData; set => NativePtr->TempData = (void*)value; }

		public void Begin(int items_count)
		{
			float items_height = -1.0f;

			ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
		}
		public void Begin(int items_count, float items_height)
		{
			ImGuiNative.ImGuiListClipper_Begin(NativePtr, items_count, items_height);
		}

		/// <summary>
		/// Automatically called on the last call of Step() that returns false.
		/// </summary>
		public void End()
		{
			ImGuiNative.ImGuiListClipper_End(NativePtr);
		}

		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.
		/// </summary>
		public bool Step()
		{
			var ret = ImGuiNative.ImGuiListClipper_Step(NativePtr);
			return ret != 0;
		}

		/// <summary>
		/// <para>Call IncludeItemByIndex() or IncludeItemsByIndex() *BEFORE* first call to Step() if you need a range of items to not be clipped, regardless of their visibility.</para>
		/// <para>(Due to alignment / padding of certain items it is possible that an extra item may be included on either end of the display range).</para>
		/// </summary>
		public void IncludeItemByIndex(int item_index)
		{
			ImGuiNative.ImGuiListClipper_IncludeItemByIndex(NativePtr, item_index);
		}

		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.
		/// </summary>
		public void IncludeItemsByIndex(int item_begin, int item_end)
		{
			ImGuiNative.ImGuiListClipper_IncludeItemsByIndex(NativePtr, item_begin, item_end);
		}

		/// <summary>
		/// <para>Seek cursor toward given item. This is automatically called while stepping.</para>
		/// <para>- The only reason to call this is: you can use ImGuiListClipper::Begin(INT_MAX) if you don't know item count ahead of time.</para>
		/// <para>- In this case, after all steps are done, you'll want to call SeekCursorForItem(item_count).</para>
		/// </summary>
		public void SeekCursorForItem(int item_index)
		{
			ImGuiNative.ImGuiListClipper_SeekCursorForItem(NativePtr, item_index);
		}
	}
}
