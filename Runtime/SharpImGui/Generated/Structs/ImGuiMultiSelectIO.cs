using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Main IO structure returned by BeginMultiSelect()/EndMultiSelect().<br/>This mainly contains a list of selection requests.<br/>- Use 'Demo-&gt;Tools-&gt;Debug Log-&gt;Selection' to see requests as they happen.<br/>- Some fields are only useful if your list is dynamic and allows deletion (getting post-deletion focus/state right is shown in the demo)<br/>- Below: who reads/writes each fields? 'r'=read, 'w'=write, 'ms'=multi-select code, 'app'=application/user code.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMultiSelectIO
	{
		/// <summary>
		/// <br/>    //------------------------------------------BeginMultiSelect / EndMultiSelect<br/>
		///  ms:w, app:r     /  ms:w  app:r   Requests to apply to your selection data.<br/>
		/// </summary>
		public ImVector<ImGuiSelectionRequest> Requests;
		/// <summary>
		///  ms:w  app:r     /                (If using clipper) Begin: Source item (often the first selected item) must never be clipped: use clipper.IncludeItemByIndex() to ensure it is submitted.<br/>
		/// </summary>
		public long RangeSrcItem;
		/// <summary>
		///  ms:w, app:r     /                (If using deletion) Last known SetNextItemSelectionUserData() value for NavId (if part of submitted items).<br/>
		/// </summary>
		public long NavIdItem;
		/// <summary>
		///  ms:w, app:r     /        app:r   (If using deletion) Last known selection state for NavId (if part of submitted items).<br/>
		/// </summary>
		public byte NavIdSelected;
		/// <summary>
		///        app:w     /  ms:r          (If using deletion) Set before EndMultiSelect() to reset ResetSrcItem (e.g. if deleted selection).<br/>
		/// </summary>
		public byte RangeSrcReset;
		/// <summary>
		///  ms:w, app:r     /        app:r   'int items_count' parameter to BeginMultiSelect() is copied here for convenience, allowing simpler calls to your ApplyRequests handler. Not used internally.<br/>
		/// </summary>
		public int ItemsCount;
	}

	/// <summary>
	/// Main IO structure returned by BeginMultiSelect()/EndMultiSelect().<br/>This mainly contains a list of selection requests.<br/>- Use 'Demo-&gt;Tools-&gt;Debug Log-&gt;Selection' to see requests as they happen.<br/>- Some fields are only useful if your list is dynamic and allows deletion (getting post-deletion focus/state right is shown in the demo)<br/>- Below: who reads/writes each fields? 'r'=read, 'w'=write, 'ms'=multi-select code, 'app'=application/user code.<br/>
	/// </summary>
	public unsafe partial struct ImGuiMultiSelectIOPtr
	{
		public ImGuiMultiSelectIO* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiMultiSelectIO this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    //------------------------------------------BeginMultiSelect / EndMultiSelect<br/>
		///  ms:w, app:r     /  ms:w  app:r   Requests to apply to your selection data.<br/>
		/// </summary>
		public ref ImVector<ImGuiSelectionRequest> Requests => ref Unsafe.AsRef<ImVector<ImGuiSelectionRequest>>(&NativePtr->Requests);
		/// <summary>
		///  ms:w  app:r     /                (If using clipper) Begin: Source item (often the first selected item) must never be clipped: use clipper.IncludeItemByIndex() to ensure it is submitted.<br/>
		/// </summary>
		public ref long RangeSrcItem => ref Unsafe.AsRef<long>(&NativePtr->RangeSrcItem);
		/// <summary>
		///  ms:w, app:r     /                (If using deletion) Last known SetNextItemSelectionUserData() value for NavId (if part of submitted items).<br/>
		/// </summary>
		public ref long NavIdItem => ref Unsafe.AsRef<long>(&NativePtr->NavIdItem);
		/// <summary>
		///  ms:w, app:r     /        app:r   (If using deletion) Last known selection state for NavId (if part of submitted items).<br/>
		/// </summary>
		public ref bool NavIdSelected => ref Unsafe.AsRef<bool>(&NativePtr->NavIdSelected);
		/// <summary>
		///        app:w     /  ms:r          (If using deletion) Set before EndMultiSelect() to reset ResetSrcItem (e.g. if deleted selection).<br/>
		/// </summary>
		public ref bool RangeSrcReset => ref Unsafe.AsRef<bool>(&NativePtr->RangeSrcReset);
		/// <summary>
		///  ms:w, app:r     /        app:r   'int items_count' parameter to BeginMultiSelect() is copied here for convenience, allowing simpler calls to your ApplyRequests handler. Not used internally.<br/>
		/// </summary>
		public ref int ItemsCount => ref Unsafe.AsRef<int>(&NativePtr->ItemsCount);
		public ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* nativePtr) => NativePtr = nativePtr;
		public ImGuiMultiSelectIOPtr(IntPtr nativePtr) => NativePtr = (ImGuiMultiSelectIO*)nativePtr;
		public static implicit operator ImGuiMultiSelectIOPtr(ImGuiMultiSelectIO* ptr) => new ImGuiMultiSelectIOPtr(ptr);
		public static implicit operator ImGuiMultiSelectIOPtr(IntPtr ptr) => new ImGuiMultiSelectIOPtr(ptr);
		public static implicit operator ImGuiMultiSelectIO*(ImGuiMultiSelectIOPtr nativePtr) => nativePtr.NativePtr;
	}
}
