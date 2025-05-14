using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Optional helper to store multi-selection state + apply multi-selection requests.<br/>- Used by our demos and provided as a convenience to easily implement basic multi-selection.<br/>- Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>  Or you can check 'if (Contains(id))  ... ' for each possible object if their number is not too high to iterate.<br/>- USING THIS IS NOT MANDATORY. This is only a helper and not a required API.<br/>To store a multi-selection, in your application you could:<br/>- Use this helper as a convenience. We use our simple key-&gt;value ImGuiStorage as a std::set&lt;ImGuiID&gt; replacement.<br/>- Use your own external storage: e.g. std::set&lt;MyObjectId&gt;, std::vector&lt;MyObjectId&gt;, interval trees, intrusively stored selection etc.<br/>In ImGuiSelectionBasicStorage we:<br/>- always use indices in the multi-selection API (passed to SetNextItemSelectionUserData(), retrieved in ImGuiMultiSelectIO)<br/>- use the AdapterIndexToStorageId() indirection layer to abstract how persistent selection data is derived from an index.<br/>- use decently optimized logic to allow queries and insertion of very large selection sets.<br/>- do not preserve selection order.<br/>Many combinations are possible depending on how you prefer to store your items and how you prefer to store your selection.<br/>Large applications are likely to eventually want to get rid of this indirection layer and do their own thing.<br/>See https://github.com/ocornut/imgui/wiki/Multi-Select for details and pseudo-code using this helper.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSelectionBasicStorage
	{
		/// <summary>
		/// <br/>    Members<br/>
		///          Number of selected items, maintained by this helper.<br/>
		/// </summary>
		public int Size;
		/// <summary>
		/// = false  GetNextSelectedItem() will return ordered selection (currently implemented by two additional sorts of selection. Could be improved)<br/>
		/// </summary>
		public byte PreserveOrder;
		/// <summary>
		/// = NULL   User data for use by adapter function        e.g. selection.UserData = (void*)my_items;<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		/// e.g. selection.AdapterIndexToStorageId = [](ImGuiSelectionBasicStorage* self, int idx)  return ((MyItems**)self-&gt;UserData)[idx]-&gt;ID; ;<br/>
		/// </summary>
		public unsafe void* AdapterIndexToStorageId;
		/// <summary>
		/// [Internal] Increasing counter to store selection order<br/>
		/// </summary>
		public int SelectionOrder;
		/// <summary>
		/// [Internal] Selection set. Think of this as similar to e.g. std::set&lt;ImGuiID&gt;. Prefer not accessing directly: iterate with GetNextSelectedItem().<br/>
		/// </summary>
		public ImGuiStorage Storage;
	}

	/// <summary>
	/// Optional helper to store multi-selection state + apply multi-selection requests.<br/>- Used by our demos and provided as a convenience to easily implement basic multi-selection.<br/>- Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>  Or you can check 'if (Contains(id))  ... ' for each possible object if their number is not too high to iterate.<br/>- USING THIS IS NOT MANDATORY. This is only a helper and not a required API.<br/>To store a multi-selection, in your application you could:<br/>- Use this helper as a convenience. We use our simple key-&gt;value ImGuiStorage as a std::set&lt;ImGuiID&gt; replacement.<br/>- Use your own external storage: e.g. std::set&lt;MyObjectId&gt;, std::vector&lt;MyObjectId&gt;, interval trees, intrusively stored selection etc.<br/>In ImGuiSelectionBasicStorage we:<br/>- always use indices in the multi-selection API (passed to SetNextItemSelectionUserData(), retrieved in ImGuiMultiSelectIO)<br/>- use the AdapterIndexToStorageId() indirection layer to abstract how persistent selection data is derived from an index.<br/>- use decently optimized logic to allow queries and insertion of very large selection sets.<br/>- do not preserve selection order.<br/>Many combinations are possible depending on how you prefer to store your items and how you prefer to store your selection.<br/>Large applications are likely to eventually want to get rid of this indirection layer and do their own thing.<br/>See https://github.com/ocornut/imgui/wiki/Multi-Select for details and pseudo-code using this helper.<br/>
	/// </summary>
	public unsafe partial struct ImGuiSelectionBasicStoragePtr
	{
		public ImGuiSelectionBasicStorage* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiSelectionBasicStorage this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    Members<br/>
		///          Number of selected items, maintained by this helper.<br/>
		/// </summary>
		public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);
		/// <summary>
		/// = false  GetNextSelectedItem() will return ordered selection (currently implemented by two additional sorts of selection. Could be improved)<br/>
		/// </summary>
		public ref bool PreserveOrder => ref Unsafe.AsRef<bool>(&NativePtr->PreserveOrder);
		/// <summary>
		/// = NULL   User data for use by adapter function        e.g. selection.UserData = (void*)my_items;<br/>
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
		/// <summary>
		/// e.g. selection.AdapterIndexToStorageId = [](ImGuiSelectionBasicStorage* self, int idx)  return ((MyItems**)self-&gt;UserData)[idx]-&gt;ID; ;<br/>
		/// </summary>
		public AdapterIndexToStorageId AdapterIndexToStorageId { get => (AdapterIndexToStorageId) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->AdapterIndexToStorageId, typeof(AdapterIndexToStorageId)); set => NativePtr->AdapterIndexToStorageId = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// [Internal] Increasing counter to store selection order<br/>
		/// </summary>
		public ref int SelectionOrder => ref Unsafe.AsRef<int>(&NativePtr->SelectionOrder);
		/// <summary>
		/// [Internal] Selection set. Think of this as similar to e.g. std::set&lt;ImGuiID&gt;. Prefer not accessing directly: iterate with GetNextSelectedItem().<br/>
		/// </summary>
		public ref ImGuiStorage Storage => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Storage);
		public ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionBasicStorage*)nativePtr;
		public static implicit operator ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* ptr) => new ImGuiSelectionBasicStoragePtr(ptr);
		public static implicit operator ImGuiSelectionBasicStoragePtr(IntPtr ptr) => new ImGuiSelectionBasicStoragePtr(ptr);
		public static implicit operator ImGuiSelectionBasicStorage*(ImGuiSelectionBasicStoragePtr nativePtr) => nativePtr.NativePtr;
		/// <summary>
		/// Convert index to item id based on provided adapter.<br/>
		/// </summary>
		public uint GetStorageIdFromIndex(int idx)
		{
			return ImGuiNative.ImGuiSelectionBasicStorageGetStorageIdFromIndex(NativePtr, idx);
		}

		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&it, &id))  ... '<br/>
		/// </summary>
		public bool GetNextSelectedItem(ref void* opaqueIt, out uint outId)
		{
			fixed (void** nativeOpaqueIt = &opaqueIt)
			fixed (uint* nativeOutId = &outId)
			{
				var result = ImGuiNative.ImGuiSelectionBasicStorageGetNextSelectedItem(NativePtr, nativeOpaqueIt, nativeOutId);
				return result != 0;
			}
		}

		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)<br/>
		/// </summary>
		public void SetItemSelected(uint id, bool selected)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiSelectionBasicStorageSetItemSelected(NativePtr, id, native_selected);
		}

		/// <summary>
		/// Swap two selections<br/>
		/// </summary>
		public void Swap(ImGuiSelectionBasicStoragePtr r)
		{
			ImGuiNative.ImGuiSelectionBasicStorageSwap(NativePtr, r);
		}

		/// <summary>
		/// Clear selection<br/>
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImGuiSelectionBasicStorageClear(NativePtr);
		}

		/// <summary>
		/// Query if an item id is in selection.<br/>
		/// </summary>
		public bool Contains(uint id)
		{
			var result = ImGuiNative.ImGuiSelectionBasicStorageContains(NativePtr, id);
			return result != 0;
		}

		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()<br/>
		/// </summary>
		public void ApplyRequests(ImGuiMultiSelectIOPtr msIo)
		{
			ImGuiNative.ImGuiSelectionBasicStorageApplyRequests(NativePtr, msIo);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiSelectionBasicStorageDestroy(NativePtr);
		}

		public void ImGuiSelectionBasicStorageConstruct()
		{
			ImGuiNative.ImGuiSelectionBasicStorageImGuiSelectionBasicStorageConstruct(NativePtr);
		}

		public ImGuiSelectionBasicStoragePtr ImGuiSelectionBasicStorage()
		{
			return ImGuiNative.ImGuiSelectionBasicStorageImGuiSelectionBasicStorage();
		}

	}
}
