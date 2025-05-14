using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Manually clip large list of items.<br/>If you have lots evenly spaced items and you have random access to the list, you can perform coarse<br/>clipping based on visibility to only submit items that are in view.<br/>The clipper calculates the range of visible items and advance the cursor to compensate for the non-visible items we have skipped.<br/>(Dear ImGui already clip items based on their bounds but: it needs to first layout the item to do so, and generally<br/> fetching/submitting your own data incurs additional cost. Coarse clipping using ImGuiListClipper allows you to easily<br/> scale using lists with tens of thousands of items without a problem)<br/>Usage:<br/>  ImGuiListClipper clipper;<br/>  clipper.Begin(1000);         We have 1000 elements, evenly spaced.<br/>  while (clipper.Step())<br/>      for (int i = clipper.DisplayStart; i &lt; clipper.DisplayEnd; i++)<br/>          ImGui::Text("line number %d", i);<br/>Generally what happens is:<br/>- Clipper lets you process the first element (DisplayStart = 0, DisplayEnd = 1) regardless of it being visible or not.<br/>- User code submit that one element.<br/>- Clipper can measure the height of the first element<br/>- Clipper calculate the actual range of elements to display based on the current clipping rectangle, position the cursor before the first visible element.<br/>- User code submit visible elements.<br/>- The clipper also handles various subtleties related to keyboard/gamepad navigation, wrapping etc.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiListClipper
	{
		/// <summary>
		/// Parent UI context<br/>
		/// </summary>
		public unsafe ImGuiContext* Ctx;
		/// <summary>
		/// First item to display, updated by each call to Step()<br/>
		/// </summary>
		public int DisplayStart;
		/// <summary>
		/// End of items to display (exclusive)<br/>
		/// </summary>
		public int DisplayEnd;
		/// <summary>
		/// [Internal] Number of items<br/>
		/// </summary>
		public int ItemsCount;
		/// <summary>
		/// [Internal] Height of item after a first step and item submission can calculate it<br/>
		/// </summary>
		public float ItemsHeight;
		/// <summary>
		/// [Internal] Cursor position at the time of Begin() or after table frozen rows are all processed<br/>
		/// </summary>
		public float StartPosY;
		/// <summary>
		/// [Internal] Account for frozen rows in a table and initial loss of precision in very large windows.<br/>
		/// </summary>
		public double StartSeekOffsetY;
		/// <summary>
		/// [Internal] Internal data<br/>
		/// </summary>
		public unsafe void* TempData;
	}

	/// <summary>
	/// Helper: Manually clip large list of items.<br/>If you have lots evenly spaced items and you have random access to the list, you can perform coarse<br/>clipping based on visibility to only submit items that are in view.<br/>The clipper calculates the range of visible items and advance the cursor to compensate for the non-visible items we have skipped.<br/>(Dear ImGui already clip items based on their bounds but: it needs to first layout the item to do so, and generally<br/> fetching/submitting your own data incurs additional cost. Coarse clipping using ImGuiListClipper allows you to easily<br/> scale using lists with tens of thousands of items without a problem)<br/>Usage:<br/>  ImGuiListClipper clipper;<br/>  clipper.Begin(1000);         We have 1000 elements, evenly spaced.<br/>  while (clipper.Step())<br/>      for (int i = clipper.DisplayStart; i &lt; clipper.DisplayEnd; i++)<br/>          ImGui::Text("line number %d", i);<br/>Generally what happens is:<br/>- Clipper lets you process the first element (DisplayStart = 0, DisplayEnd = 1) regardless of it being visible or not.<br/>- User code submit that one element.<br/>- Clipper can measure the height of the first element<br/>- Clipper calculate the actual range of elements to display based on the current clipping rectangle, position the cursor before the first visible element.<br/>- User code submit visible elements.<br/>- The clipper also handles various subtleties related to keyboard/gamepad navigation, wrapping etc.<br/>
	/// </summary>
	public unsafe partial struct ImGuiListClipperPtr
	{
		public ImGuiListClipper* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiListClipper this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Parent UI context<br/>
		/// </summary>
		public ref ImGuiContextPtr Ctx => ref Unsafe.AsRef<ImGuiContextPtr>(&NativePtr->Ctx);
		/// <summary>
		/// First item to display, updated by each call to Step()<br/>
		/// </summary>
		public ref int DisplayStart => ref Unsafe.AsRef<int>(&NativePtr->DisplayStart);
		/// <summary>
		/// End of items to display (exclusive)<br/>
		/// </summary>
		public ref int DisplayEnd => ref Unsafe.AsRef<int>(&NativePtr->DisplayEnd);
		/// <summary>
		/// [Internal] Number of items<br/>
		/// </summary>
		public ref int ItemsCount => ref Unsafe.AsRef<int>(&NativePtr->ItemsCount);
		/// <summary>
		/// [Internal] Height of item after a first step and item submission can calculate it<br/>
		/// </summary>
		public ref float ItemsHeight => ref Unsafe.AsRef<float>(&NativePtr->ItemsHeight);
		/// <summary>
		/// [Internal] Cursor position at the time of Begin() or after table frozen rows are all processed<br/>
		/// </summary>
		public ref float StartPosY => ref Unsafe.AsRef<float>(&NativePtr->StartPosY);
		/// <summary>
		/// [Internal] Account for frozen rows in a table and initial loss of precision in very large windows.<br/>
		/// </summary>
		public ref double StartSeekOffsetY => ref Unsafe.AsRef<double>(&NativePtr->StartSeekOffsetY);
		/// <summary>
		/// [Internal] Internal data<br/>
		/// </summary>
		public IntPtr TempData { get => (IntPtr)NativePtr->TempData; set => NativePtr->TempData = (void*)value; }
		public ImGuiListClipperPtr(ImGuiListClipper* nativePtr) => NativePtr = nativePtr;
		public ImGuiListClipperPtr(IntPtr nativePtr) => NativePtr = (ImGuiListClipper*)nativePtr;
		public static implicit operator ImGuiListClipperPtr(ImGuiListClipper* ptr) => new ImGuiListClipperPtr(ptr);
		public static implicit operator ImGuiListClipperPtr(IntPtr ptr) => new ImGuiListClipperPtr(ptr);
		public static implicit operator ImGuiListClipper*(ImGuiListClipperPtr nativePtr) => nativePtr.NativePtr;
		public void SeekCursorForItem(int itemIndex)
		{
			ImGuiNative.ImGuiListClipperSeekCursorForItem(NativePtr, itemIndex);
		}

		/// <summary>
		/// item_end is exclusive e.g. use (42, 42+1) to make item 42 never clipped.<br/>
		/// </summary>
		public void IncludeItemsByIndex(int itemBegin, int itemEnd)
		{
			ImGuiNative.ImGuiListClipperIncludeItemsByIndex(NativePtr, itemBegin, itemEnd);
		}

		public void IncludeItemByIndex(int itemIndex)
		{
			ImGuiNative.ImGuiListClipperIncludeItemByIndex(NativePtr, itemIndex);
		}

		/// <summary>
		/// Call until it returns false. The DisplayStart/DisplayEnd fields will be set and you can process/draw those items.<br/>
		/// </summary>
		public bool Step()
		{
			var result = ImGuiNative.ImGuiListClipperStep(NativePtr);
			return result != 0;
		}

		/// <summary>
		/// Automatically called on the last call of Step() that returns false.<br/>
		/// </summary>
		public void End()
		{
			ImGuiNative.ImGuiListClipperEnd(NativePtr);
		}

		public void Begin(int itemsCount, float itemsHeight)
		{
			ImGuiNative.ImGuiListClipperBegin(NativePtr, itemsCount, itemsHeight);
		}

		public void Begin(int itemsCount)
		{
			// defining omitted parameters
			float itemsHeight = -1.0f;
			ImGuiNative.ImGuiListClipperBegin(NativePtr, itemsCount, itemsHeight);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiListClipperDestroy(NativePtr);
		}

		public void ImGuiListClipperConstruct()
		{
			ImGuiNative.ImGuiListClipperImGuiListClipperConstruct(NativePtr);
		}

		public ImGuiListClipperPtr ImGuiListClipper()
		{
			return ImGuiNative.ImGuiListClipperImGuiListClipper();
		}

	}
}
