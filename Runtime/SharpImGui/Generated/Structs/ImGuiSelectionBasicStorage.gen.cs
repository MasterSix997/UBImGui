using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Optional helper to store multi-selection state + apply multi-selection requests.</para>
	/// <para>- Used by our demos and provided as a convenience to easily implement basic multi-selection.</para>
	/// <para>- Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&amp;it, &amp;id)) { ... }'</para>
	/// <para>  Or you can check 'if (Contains(id)) { ... }' for each possible object if their number is not too high to iterate.</para>
	/// <para>- USING THIS IS NOT MANDATORY. This is only a helper and not a required API.</para>
	/// <para>To store a multi-selection, in your application you could:</para>
	/// <para>- Use this helper as a convenience. We use our simple key-&gt;value ImGuiStorage as a std::set&lt;ImGuiID&gt; replacement.</para>
	/// <para>- Use your own external storage: e.g. std::set&lt;MyObjectId&gt;, std::vector&lt;MyObjectId&gt;, interval trees, intrusively stored selection etc.</para>
	/// <para>In ImGuiSelectionBasicStorage we:</para>
	/// <para>- always use indices in the multi-selection API (passed to SetNextItemSelectionUserData(), retrieved in ImGuiMultiSelectIO)</para>
	/// <para>- use the AdapterIndexToStorageId() indirection layer to abstract how persistent selection data is derived from an index.</para>
	/// <para>- use decently optimized logic to allow queries and insertion of very large selection sets.</para>
	/// <para>- do not preserve selection order.</para>
	/// <para>Many combinations are possible depending on how you prefer to store your items and how you prefer to store your selection.</para>
	/// <para>Large applications are likely to eventually want to get rid of this indirection layer and do their own thing.</para>
	/// <para>See https://github.com/ocornut/imgui/wiki/Multi-Select for details and pseudo-code using this helper.</para>
	/// </summary>
	public unsafe partial struct ImGuiSelectionBasicStorage
	{
		/// <summary>
		/// <para>Members</para>
		/// </summary>
		/// <summary>
		///          // Number of selected items, maintained by this helper.
		/// </summary>
		public int Size;
		/// <summary>
		/// = false  // GetNextSelectedItem() will return ordered selection (currently implemented by two additional sorts of selection. Could be improved)
		/// </summary>
		public byte PreserveOrder;
		/// <summary>
		/// = NULL   // User data for use by adapter function        // e.g. selection.UserData = (void*)my_items;
		/// </summary>
		public void* UserData;
		/// <summary>
		/// e.g. selection.AdapterIndexToStorageId = [](ImGuiSelectionBasicStorage* self, int idx) { return ((MyItems**)self-&gt;UserData)[idx]-&gt;ID; };
		/// </summary>
		public IntPtr AdapterIndexToStorageId;
		/// <summary>
		/// [Internal] Increasing counter to store selection order
		/// </summary>
		public int _SelectionOrder;
		/// <summary>
		/// [Internal] Selection set. Think of this as similar to e.g. std::set&lt;ImGuiID&gt;. Prefer not accessing directly: iterate with GetNextSelectedItem().
		/// </summary>
		public ImGuiStorage _Storage;
	}

	/// <summary>
	/// <para>Optional helper to store multi-selection state + apply multi-selection requests.</para>
	/// <para>- Used by our demos and provided as a convenience to easily implement basic multi-selection.</para>
	/// <para>- Iterate selection with 'void* it = NULL; ImGuiID id; while (selection.GetNextSelectedItem(&amp;it, &amp;id)) { ... }'</para>
	/// <para>  Or you can check 'if (Contains(id)) { ... }' for each possible object if their number is not too high to iterate.</para>
	/// <para>- USING THIS IS NOT MANDATORY. This is only a helper and not a required API.</para>
	/// <para>To store a multi-selection, in your application you could:</para>
	/// <para>- Use this helper as a convenience. We use our simple key-&gt;value ImGuiStorage as a std::set&lt;ImGuiID&gt; replacement.</para>
	/// <para>- Use your own external storage: e.g. std::set&lt;MyObjectId&gt;, std::vector&lt;MyObjectId&gt;, interval trees, intrusively stored selection etc.</para>
	/// <para>In ImGuiSelectionBasicStorage we:</para>
	/// <para>- always use indices in the multi-selection API (passed to SetNextItemSelectionUserData(), retrieved in ImGuiMultiSelectIO)</para>
	/// <para>- use the AdapterIndexToStorageId() indirection layer to abstract how persistent selection data is derived from an index.</para>
	/// <para>- use decently optimized logic to allow queries and insertion of very large selection sets.</para>
	/// <para>- do not preserve selection order.</para>
	/// <para>Many combinations are possible depending on how you prefer to store your items and how you prefer to store your selection.</para>
	/// <para>Large applications are likely to eventually want to get rid of this indirection layer and do their own thing.</para>
	/// <para>See https://github.com/ocornut/imgui/wiki/Multi-Select for details and pseudo-code using this helper.</para>
	/// </summary>
	public unsafe partial struct ImGuiSelectionBasicStoragePtr
	{
		public ImGuiSelectionBasicStorage* NativePtr { get; }
		public ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionBasicStorage*)nativePtr;
		public static implicit operator ImGuiSelectionBasicStoragePtr(ImGuiSelectionBasicStorage* nativePtr) => new ImGuiSelectionBasicStoragePtr(nativePtr);
		public static implicit operator ImGuiSelectionBasicStorage* (ImGuiSelectionBasicStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiSelectionBasicStoragePtr(IntPtr nativePtr) => new ImGuiSelectionBasicStoragePtr(nativePtr);

		/// <summary>
		/// <para>Members</para>
		/// </summary>
		/// <summary>
		///          // Number of selected items, maintained by this helper.
		/// </summary>
		public ref int Size => ref Unsafe.AsRef<int>(&NativePtr->Size);

		/// <summary>
		/// = false  // GetNextSelectedItem() will return ordered selection (currently implemented by two additional sorts of selection. Could be improved)
		/// </summary>
		public ref bool PreserveOrder => ref Unsafe.AsRef<bool>(&NativePtr->PreserveOrder);

		/// <summary>
		/// = NULL   // User data for use by adapter function        // e.g. selection.UserData = (void*)my_items;
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }

		/// <summary>
		/// e.g. selection.AdapterIndexToStorageId = [](ImGuiSelectionBasicStorage* self, int idx) { return ((MyItems**)self-&gt;UserData)[idx]-&gt;ID; };
		/// </summary>
		public AdapterIndexToStorageIdDelegate AdapterIndexToStorageId
		{
			get => (AdapterIndexToStorageIdDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->AdapterIndexToStorageId, typeof(AdapterIndexToStorageIdDelegate));
			set => NativePtr->AdapterIndexToStorageId = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// [Internal] Increasing counter to store selection order
		/// </summary>
		public ref int _SelectionOrder => ref Unsafe.AsRef<int>(&NativePtr->_SelectionOrder);

		/// <summary>
		/// [Internal] Selection set. Think of this as similar to e.g. std::set&lt;ImGuiID&gt;. Prefer not accessing directly: iterate with GetNextSelectedItem().
		/// </summary>
		public ref ImGuiStorage _Storage => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->_Storage);

		/// <summary>
		/// Apply selection requests coming from BeginMultiSelect() and EndMultiSelect() functions. It uses 'items_count' passed to BeginMultiSelect()
		/// </summary>
		public void ApplyRequests(ImGuiMultiSelectIOPtr ms_io)
		{
			ImGuiNative.ImGuiSelectionBasicStorage_ApplyRequests(NativePtr, ms_io);
		}

		/// <summary>
		/// Query if an item id is in selection.
		/// </summary>
		public bool Contains(uint id)
		{
			var ret = ImGuiNative.ImGuiSelectionBasicStorage_Contains(NativePtr, id);
			return ret != 0;
		}

		/// <summary>
		/// Clear selection
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImGuiSelectionBasicStorage_Clear(NativePtr);
		}

		/// <summary>
		/// Swap two selections
		/// </summary>
		public void Swap(ImGuiSelectionBasicStoragePtr r)
		{
			ImGuiNative.ImGuiSelectionBasicStorage_Swap(NativePtr, r);
		}

		/// <summary>
		/// Add/remove an item from selection (generally done by ApplyRequests() function)
		/// </summary>
		public void SetItemSelected(uint id, bool selected)
		{
			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			ImGuiNative.ImGuiSelectionBasicStorage_SetItemSelected(NativePtr, id, native_selected);
		}

		/// <summary>
		/// Iterate selection with 'void* it = NULL; ImGuiId id; while (selection.GetNextSelectedItem(&amp;it, &amp;id)) { ... }'
		/// </summary>
		public bool GetNextSelectedItem(ref void* opaque_it, out uint out_id)
		{
			fixed (void** native_opaque_it = &opaque_it)
			fixed (uint* native_out_id = &out_id)
			{
				var ret = ImGuiNative.ImGuiSelectionBasicStorage_GetNextSelectedItem(NativePtr, native_opaque_it, native_out_id);
				return ret != 0;
			}
		}

		/// <summary>
		/// Convert index to item id based on provided adapter.
		/// </summary>
		public uint GetStorageIdFromIndex(int idx)
		{
			var ret = ImGuiNative.ImGuiSelectionBasicStorage_GetStorageIdFromIndex(NativePtr, idx);
			return ret;
		}
	}
}
