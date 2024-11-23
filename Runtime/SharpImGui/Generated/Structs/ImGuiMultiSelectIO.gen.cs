using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Main IO structure returned by BeginMultiSelect()/EndMultiSelect().</para>
	/// <para>This mainly contains a list of selection requests.</para>
	/// <para>- Use 'Demo-&gt;Tools-&gt;Debug Log-&gt;Selection' to see requests as they happen.</para>
	/// <para>- Some fields are only useful if your list is dynamic and allows deletion (getting post-deletion focus/state right is shown in the demo)</para>
	/// <para>- Below: who reads/writes each fields? 'r'=read, 'w'=write, 'ms'=multi-select code, 'app'=application/user code.</para>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectIO
	{
		/// <summary>
		/// <para>//------------------------------------------// BeginMultiSelect / EndMultiSelect</para>
		/// </summary>
		/// <summary>
		///  ms:w, app:r     /  ms:w  app:r   // Requests to apply to your selection data.
		/// </summary>
		public ImVector Requests;
		/// <summary>
		///  ms:w  app:r     /                // (If using clipper) Begin: Source item (often the first selected item) must never be clipped: use clipper.IncludeItemByIndex() to ensure it is submitted.
		/// </summary>
		public long RangeSrcItem;
		/// <summary>
		///  ms:w, app:r     /                // (If using deletion) Last known SetNextItemSelectionUserData() value for NavId (if part of submitted items).
		/// </summary>
		public long NavIdItem;
		/// <summary>
		///  ms:w, app:r     /        app:r   // (If using deletion) Last known selection state for NavId (if part of submitted items).
		/// </summary>
		public byte NavIdSelected;
		/// <summary>
		///        app:w     /  ms:r          // (If using deletion) Set before EndMultiSelect() to reset ResetSrcItem (e.g. if deleted selection).
		/// </summary>
		public byte RangeSrcReset;
		/// <summary>
		///  ms:w, app:r     /        app:r   // 'int items_count' parameter to BeginMultiSelect() is copied here for convenience, allowing simpler calls to your ApplyRequests handler. Not used internally.
		/// </summary>
		public int ItemsCount;
	}

	/// <summary>
	/// <para>Main IO structure returned by BeginMultiSelect()/EndMultiSelect().</para>
	/// <para>This mainly contains a list of selection requests.</para>
	/// <para>- Use 'Demo-&gt;Tools-&gt;Debug Log-&gt;Selection' to see requests as they happen.</para>
	/// <para>- Some fields are only useful if your list is dynamic and allows deletion (getting post-deletion focus/state right is shown in the demo)</para>
	/// <para>- Below: who reads/writes each fields? 'r'=read, 'w'=write, 'ms'=multi-select code, 'app'=application/user code.</para>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectIOPtr
	{
		public ImGuiMultiSelectIO* NativePtr { get; }
		public ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => NativePtr = nativePtr;
		public ImGuiMultiSelectIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectIO*)nativePtr;
		public static implicit operator ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => new ImGuiMultiSelectIOPtr(nativePtr);
		public static implicit operator ImGuiMultiSelectIO* (ImGuiMultiSelectIOPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiMultiSelectIOPtr(IntPtr nativePtr) => new ImGuiMultiSelectIOPtr(nativePtr);

		/// <summary>
		/// <para>//------------------------------------------// BeginMultiSelect / EndMultiSelect</para>
		/// </summary>
		/// <summary>
		///  ms:w, app:r     /  ms:w  app:r   // Requests to apply to your selection data.
		/// </summary>
		public ImPtrVector<ImGuiSelectionRequestPtr> Requests => new ImPtrVector<ImGuiSelectionRequestPtr>(NativePtr->Requests, Unsafe.SizeOf<ImGuiSelectionRequest>());

		/// <summary>
		///  ms:w  app:r     /                // (If using clipper) Begin: Source item (often the first selected item) must never be clipped: use clipper.IncludeItemByIndex() to ensure it is submitted.
		/// </summary>
		public ref long RangeSrcItem => ref Unsafe.AsRef<long>(&NativePtr->RangeSrcItem);

		/// <summary>
		///  ms:w, app:r     /                // (If using deletion) Last known SetNextItemSelectionUserData() value for NavId (if part of submitted items).
		/// </summary>
		public ref long NavIdItem => ref Unsafe.AsRef<long>(&NativePtr->NavIdItem);

		/// <summary>
		///  ms:w, app:r     /        app:r   // (If using deletion) Last known selection state for NavId (if part of submitted items).
		/// </summary>
		public ref bool NavIdSelected => ref Unsafe.AsRef<bool>(&NativePtr->NavIdSelected);

		/// <summary>
		///        app:w     /  ms:r          // (If using deletion) Set before EndMultiSelect() to reset ResetSrcItem (e.g. if deleted selection).
		/// </summary>
		public ref bool RangeSrcReset => ref Unsafe.AsRef<bool>(&NativePtr->RangeSrcReset);

		/// <summary>
		///  ms:w, app:r     /        app:r   // 'int items_count' parameter to BeginMultiSelect() is copied here for convenience, allowing simpler calls to your ApplyRequests handler. Not used internally.
		/// </summary>
		public ref int ItemsCount => ref Unsafe.AsRef<int>(&NativePtr->ItemsCount);
	}
}
