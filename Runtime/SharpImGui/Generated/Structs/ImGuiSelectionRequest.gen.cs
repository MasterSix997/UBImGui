using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Selection request item</para>
	/// </summary>
	public unsafe partial struct ImGuiSelectionRequest
	{
		/// <summary>
		/// <para>//------------------------------------------// BeginMultiSelect / EndMultiSelect</para>
		/// </summary>
		/// <summary>
		///  ms:w, app:r     /  ms:w, app:r   // Request type. You'll most often receive 1 Clear + 1 SetRange with a single-item range.
		/// </summary>
		public ImGuiSelectionRequestType Type;
		/// <summary>
		///  ms:w, app:r     /  ms:w, app:r   // Parameter for SetAll/SetRange requests (true = select, false = unselect)
		/// </summary>
		public byte Selected;
		/// <summary>
		///                  /  ms:w  app:r   // Parameter for SetRange request: +1 when RangeFirstItem comes before RangeLastItem, -1 otherwise. Useful if you want to preserve selection order on a backward Shift+Click.
		/// </summary>
		public sbyte RangeDirection;
		/// <summary>
		///                  /  ms:w, app:r   // Parameter for SetRange request (this is generally == RangeSrcItem when shift selecting from top to bottom).
		/// </summary>
		public long RangeFirstItem;
		/// <summary>
		///                  /  ms:w, app:r   // Parameter for SetRange request (this is generally == RangeSrcItem when shift selecting from bottom to top). Inclusive!
		/// </summary>
		public long RangeLastItem;
	}

	/// <summary>
	/// <para>Selection request item</para>
	/// </summary>
	public unsafe partial struct ImGuiSelectionRequestPtr
	{
		public ImGuiSelectionRequest* NativePtr { get; }
		public ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => NativePtr = nativePtr;
		public ImGuiSelectionRequestPtr(IntPtr nativePtr) => NativePtr = (ImGuiSelectionRequest*)nativePtr;
		public static implicit operator ImGuiSelectionRequestPtr(ImGuiSelectionRequest* nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);
		public static implicit operator ImGuiSelectionRequest* (ImGuiSelectionRequestPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiSelectionRequestPtr(IntPtr nativePtr) => new ImGuiSelectionRequestPtr(nativePtr);

		/// <summary>
		/// <para>//------------------------------------------// BeginMultiSelect / EndMultiSelect</para>
		/// </summary>
		/// <summary>
		///  ms:w, app:r     /  ms:w, app:r   // Request type. You'll most often receive 1 Clear + 1 SetRange with a single-item range.
		/// </summary>
		public ref ImGuiSelectionRequestType Type => ref Unsafe.AsRef<ImGuiSelectionRequestType>(&NativePtr->Type);

		/// <summary>
		///  ms:w, app:r     /  ms:w, app:r   // Parameter for SetAll/SetRange requests (true = select, false = unselect)
		/// </summary>
		public ref bool Selected => ref Unsafe.AsRef<bool>(&NativePtr->Selected);

		/// <summary>
		///                  /  ms:w  app:r   // Parameter for SetRange request: +1 when RangeFirstItem comes before RangeLastItem, -1 otherwise. Useful if you want to preserve selection order on a backward Shift+Click.
		/// </summary>
		public ref sbyte RangeDirection => ref Unsafe.AsRef<sbyte>(&NativePtr->RangeDirection);

		/// <summary>
		///                  /  ms:w, app:r   // Parameter for SetRange request (this is generally == RangeSrcItem when shift selecting from top to bottom).
		/// </summary>
		public ref long RangeFirstItem => ref Unsafe.AsRef<long>(&NativePtr->RangeFirstItem);

		/// <summary>
		///                  /  ms:w, app:r   // Parameter for SetRange request (this is generally == RangeSrcItem when shift selecting from bottom to top). Inclusive!
		/// </summary>
		public ref long RangeLastItem => ref Unsafe.AsRef<long>(&NativePtr->RangeLastItem);
	}
}
