using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Optional helper to apply multi-selection requests to existing randomly accessible storage.</para>
	/// <para>Convenient if you want to quickly wire multi-select API on e.g. an array of bool or items storing their own selection state.</para>
	/// </summary>
	public unsafe partial struct ImGuiSelectionExternalStorage
	{
		/// <summary>
		/// <para>Members</para>
		/// </summary>
		/// <summary>
		/// User data for use by adapter function                                // e.g. selection.UserData = (void*)my_items;
		/// </summary>
		public void* UserData;
		/// <summary>
		/// e.g. AdapterSetItemSelected = [](ImGuiSelectionExternalStorage* self, int idx, bool selected) { ((MyItems**)self-&gt;UserData)[idx]-&gt;Selected = selected; }
		/// </summary>
		public IntPtr AdapterSetItemSelected;
	}

	/// <summary>
	/// <para>Optional helper to apply multi-selection requests to existing randomly accessible storage.</para>
	/// <para>Convenient if you want to quickly wire multi-select API on e.g. an array of bool or items storing their own selection state.</para>
	/// </summary>
	public unsafe partial struct ImGuiSelectionExternalStoragePtr
	{
		public ImGuiSelectionExternalStorage* NativePtr { get; }
		public ImGuiSelectionExternalStoragePtr(ImGuiSelectionExternalStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiSelectionExternalStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionExternalStorage*)nativePtr;
		public static implicit operator ImGuiSelectionExternalStoragePtr(ImGuiSelectionExternalStorage* nativePtr) => new ImGuiSelectionExternalStoragePtr(nativePtr);
		public static implicit operator ImGuiSelectionExternalStorage* (ImGuiSelectionExternalStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiSelectionExternalStoragePtr(IntPtr nativePtr) => new ImGuiSelectionExternalStoragePtr(nativePtr);

		/// <summary>
		/// <para>Members</para>
		/// </summary>
		/// <summary>
		/// User data for use by adapter function                                // e.g. selection.UserData = (void*)my_items;
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }

		/// <summary>
		/// e.g. AdapterSetItemSelected = [](ImGuiSelectionExternalStorage* self, int idx, bool selected) { ((MyItems**)self-&gt;UserData)[idx]-&gt;Selected = selected; }
		/// </summary>
		public AdapterSetItemSelectedDelegate AdapterSetItemSelected
		{
			get => (AdapterSetItemSelectedDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->AdapterSetItemSelected, typeof(AdapterSetItemSelectedDelegate));
			set => NativePtr->AdapterSetItemSelected = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// Apply selection requests by using AdapterSetItemSelected() calls
		/// </summary>
		public void ApplyRequests(ImGuiMultiSelectIOPtr ms_io)
		{
			ImGuiNative.ImGuiSelectionExternalStorage_ApplyRequests(NativePtr, ms_io);
		}
	}
}
