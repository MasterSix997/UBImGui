using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Shared state of InputText(), passed as an argument to your callback when a ImGuiInputTextFlags_Callback* flag is used.<br/>The callback function should return 0 by default.<br/>Callbacks (follow a flag name and see comments in ImGuiInputTextFlags_ declarations for more details)<br/>- ImGuiInputTextFlags_CallbackEdit:        Callback on buffer edit. Note that InputText() already returns true on edit + you can always use IsItemEdited(). The callback is useful to manipulate the underlying buffer while focus is active.<br/>- ImGuiInputTextFlags_CallbackAlways:      Callback on each iteration<br/>- ImGuiInputTextFlags_CallbackCompletion:  Callback on pressing TAB<br/>- ImGuiInputTextFlags_CallbackHistory:     Callback on pressing Up/Down arrows<br/>- ImGuiInputTextFlags_CallbackCharFilter:  Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.<br/>- ImGuiInputTextFlags_CallbackResize:      Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextCallbackData
	{
		/// <summary>
		/// Parent UI context<br/>
		/// </summary>
		public unsafe ImGuiContext* Ctx;
		/// <summary>
		/// One ImGuiInputTextFlags_Callback*    Read-only<br/>
		/// </summary>
		public ImGuiInputTextFlags EventFlag;
		/// <summary>
		/// What user passed to InputText()      Read-only<br/>
		/// </summary>
		public ImGuiInputTextFlags Flags;
		/// <summary>
		/// What user passed to InputText()      Read-only<br/>
		/// </summary>
		public unsafe void* UserData;
		/// <summary>
		///     Arguments for the different callback events<br/>    - During Resize callback, Buf will be same as your input buffer.<br/>    - However, during Completion/History/Always callback, Buf always points to our own internal data (it is not the same as your buffer)! Changes to it will be reflected into your own buffer shortly after the callback.<br/>    - To modify the text buffer in a callback, prefer using the InsertChars() / DeleteChars() function. InsertChars() will take care of calling the resize callback if necessary.<br/>    - If you know your edits are not going to resize the underlying buffer allocation, you may modify the contents of 'Buf[]' directly. You need to update 'BufTextLen' accordingly (0 &lt;= BufTextLen &lt; BufSize) and set 'BufDirty'' to true so InputText can update its internal state.<br/>
		/// Character input                      Read-write   [CharFilter] Replace character with another one, or set to zero to drop. return 1 is equivalent to setting EventChar=0;<br/>
		/// </summary>
		public ushort EventChar;
		/// <summary>
		/// Key pressed (Up/Down/TAB)            Read-only    [Completion,History]<br/>
		/// </summary>
		public ImGuiKey EventKey;
		/// <summary>
		/// Text buffer                          Read-write   [Resize] Can replace pointer / [Completion,History,Always] Only write to pointed data, don't replace the actual pointer!<br/>
		/// </summary>
		public unsafe byte* Buf;
		/// <summary>
		/// Text length (in bytes)               Read-write   [Resize,Completion,History,Always] Exclude zero-terminator storage. In C land: == strlen(some_text), in C++ land: string.length()<br/>
		/// </summary>
		public int BufTextLen;
		/// <summary>
		/// Buffer size (in bytes) = capacity+1  Read-only    [Resize,Completion,History,Always] Include zero-terminator storage. In C land == ARRAYSIZE(my_char_array), in C++ land: string.capacity()+1<br/>
		/// </summary>
		public int BufSize;
		/// <summary>
		/// Set if you modify Buf/BufTextLen!    Write        [Completion,History,Always]<br/>
		/// </summary>
		public byte BufDirty;
		/// <summary>
		///                                      Read-write   [Completion,History,Always]<br/>
		/// </summary>
		public int CursorPos;
		/// <summary>
		///                                      Read-write   [Completion,History,Always] == to SelectionEnd when no selection)<br/>
		/// </summary>
		public int SelectionStart;
		/// <summary>
		///                                      Read-write   [Completion,History,Always]<br/>
		/// </summary>
		public int SelectionEnd;
	}

	/// <summary>
	/// Shared state of InputText(), passed as an argument to your callback when a ImGuiInputTextFlags_Callback* flag is used.<br/>The callback function should return 0 by default.<br/>Callbacks (follow a flag name and see comments in ImGuiInputTextFlags_ declarations for more details)<br/>- ImGuiInputTextFlags_CallbackEdit:        Callback on buffer edit. Note that InputText() already returns true on edit + you can always use IsItemEdited(). The callback is useful to manipulate the underlying buffer while focus is active.<br/>- ImGuiInputTextFlags_CallbackAlways:      Callback on each iteration<br/>- ImGuiInputTextFlags_CallbackCompletion:  Callback on pressing TAB<br/>- ImGuiInputTextFlags_CallbackHistory:     Callback on pressing Up/Down arrows<br/>- ImGuiInputTextFlags_CallbackCharFilter:  Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.<br/>- ImGuiInputTextFlags_CallbackResize:      Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow.<br/>
	/// </summary>
	public unsafe partial struct ImGuiInputTextCallbackDataPtr
	{
		public ImGuiInputTextCallbackData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputTextCallbackData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Parent UI context<br/>
		/// </summary>
		public ref ImGuiContextPtr Ctx => ref Unsafe.AsRef<ImGuiContextPtr>(&NativePtr->Ctx);
		/// <summary>
		/// One ImGuiInputTextFlags_Callback*    Read-only<br/>
		/// </summary>
		public ref ImGuiInputTextFlags EventFlag => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->EventFlag);
		/// <summary>
		/// What user passed to InputText()      Read-only<br/>
		/// </summary>
		public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);
		/// <summary>
		/// What user passed to InputText()      Read-only<br/>
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
		/// <summary>
		///     Arguments for the different callback events<br/>    - During Resize callback, Buf will be same as your input buffer.<br/>    - However, during Completion/History/Always callback, Buf always points to our own internal data (it is not the same as your buffer)! Changes to it will be reflected into your own buffer shortly after the callback.<br/>    - To modify the text buffer in a callback, prefer using the InsertChars() / DeleteChars() function. InsertChars() will take care of calling the resize callback if necessary.<br/>    - If you know your edits are not going to resize the underlying buffer allocation, you may modify the contents of 'Buf[]' directly. You need to update 'BufTextLen' accordingly (0 &lt;= BufTextLen &lt; BufSize) and set 'BufDirty'' to true so InputText can update its internal state.<br/>
		/// Character input                      Read-write   [CharFilter] Replace character with another one, or set to zero to drop. return 1 is equivalent to setting EventChar=0;<br/>
		/// </summary>
		public ref ushort EventChar => ref Unsafe.AsRef<ushort>(&NativePtr->EventChar);
		/// <summary>
		/// Key pressed (Up/Down/TAB)            Read-only    [Completion,History]<br/>
		/// </summary>
		public ref ImGuiKey EventKey => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->EventKey);
		/// <summary>
		/// Text buffer                          Read-write   [Resize] Can replace pointer / [Completion,History,Always] Only write to pointed data, don't replace the actual pointer!<br/>
		/// </summary>
		public IntPtr Buf { get => (IntPtr)NativePtr->Buf; set => NativePtr->Buf = (byte*)value; }
		/// <summary>
		/// Text length (in bytes)               Read-write   [Resize,Completion,History,Always] Exclude zero-terminator storage. In C land: == strlen(some_text), in C++ land: string.length()<br/>
		/// </summary>
		public ref int BufTextLen => ref Unsafe.AsRef<int>(&NativePtr->BufTextLen);
		/// <summary>
		/// Buffer size (in bytes) = capacity+1  Read-only    [Resize,Completion,History,Always] Include zero-terminator storage. In C land == ARRAYSIZE(my_char_array), in C++ land: string.capacity()+1<br/>
		/// </summary>
		public ref int BufSize => ref Unsafe.AsRef<int>(&NativePtr->BufSize);
		/// <summary>
		/// Set if you modify Buf/BufTextLen!    Write        [Completion,History,Always]<br/>
		/// </summary>
		public ref bool BufDirty => ref Unsafe.AsRef<bool>(&NativePtr->BufDirty);
		/// <summary>
		///                                      Read-write   [Completion,History,Always]<br/>
		/// </summary>
		public ref int CursorPos => ref Unsafe.AsRef<int>(&NativePtr->CursorPos);
		/// <summary>
		///                                      Read-write   [Completion,History,Always] == to SelectionEnd when no selection)<br/>
		/// </summary>
		public ref int SelectionStart => ref Unsafe.AsRef<int>(&NativePtr->SelectionStart);
		/// <summary>
		///                                      Read-write   [Completion,History,Always]<br/>
		/// </summary>
		public ref int SelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->SelectionEnd);
		public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextCallbackData*)nativePtr;
		public static implicit operator ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* ptr) => new ImGuiInputTextCallbackDataPtr(ptr);
		public static implicit operator ImGuiInputTextCallbackDataPtr(IntPtr ptr) => new ImGuiInputTextCallbackDataPtr(ptr);
		public static implicit operator ImGuiInputTextCallbackData*(ImGuiInputTextCallbackDataPtr nativePtr) => nativePtr.NativePtr;
		public bool HasSelection()
		{
			var result = ImGuiNative.ImGuiInputTextCallbackDataHasSelection(NativePtr);
			return result != 0;
		}

		public void ClearSelection()
		{
			ImGuiNative.ImGuiInputTextCallbackDataClearSelection(NativePtr);
		}

		public void SelectAll()
		{
			ImGuiNative.ImGuiInputTextCallbackDataSelectAll(NativePtr);
		}

		public void InsertChars(int pos, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.ImGuiInputTextCallbackDataInsertChars(NativePtr, pos, nativeText, nativeTextEnd);
			}
		}

		public void InsertChars(int pos, ReadOnlySpan<char> text, ReadOnlySpan<char> textEnd)
		{
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			// Marshaling textEnd to native string
			byte* nativeTextEnd;
			var byteCountTextEnd = 0;
			if (textEnd != null && !textEnd.IsEmpty)
			{
				byteCountTextEnd = Encoding.UTF8.GetByteCount(textEnd);
				if(byteCountTextEnd > Utils.MaxStackallocSize)
				{
					nativeTextEnd = Utils.Alloc<byte>(byteCountTextEnd + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountTextEnd + 1];
					nativeTextEnd = stackallocBytes;
				}
				var offsetTextEnd = Utils.EncodeStringUTF8(textEnd, nativeTextEnd, byteCountTextEnd);
				nativeTextEnd[offsetTextEnd] = 0;
			}
			else nativeTextEnd = null;

			ImGuiNative.ImGuiInputTextCallbackDataInsertChars(NativePtr, pos, nativeText, nativeTextEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
			// Freeing textEnd native string
			if (byteCountTextEnd > Utils.MaxStackallocSize)
				Utils.Free(nativeTextEnd);
		}

		public void InsertChars(int pos, ReadOnlySpan<byte> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			fixed (byte* nativeText = text)
			{
				ImGuiNative.ImGuiInputTextCallbackDataInsertChars(NativePtr, pos, nativeText, textEnd);
			}
		}

		public void InsertChars(int pos, ReadOnlySpan<char> text)
		{
			// defining omitted parameters
			byte* textEnd = null;
			// Marshaling text to native string
			byte* nativeText;
			var byteCountText = 0;
			if (text != null && !text.IsEmpty)
			{
				byteCountText = Encoding.UTF8.GetByteCount(text);
				if(byteCountText > Utils.MaxStackallocSize)
				{
					nativeText = Utils.Alloc<byte>(byteCountText + 1);
				}
				else
				{
					var stackallocBytes = stackalloc byte[byteCountText + 1];
					nativeText = stackallocBytes;
				}
				var offsetText = Utils.EncodeStringUTF8(text, nativeText, byteCountText);
				nativeText[offsetText] = 0;
			}
			else nativeText = null;

			ImGuiNative.ImGuiInputTextCallbackDataInsertChars(NativePtr, pos, nativeText, textEnd);
			// Freeing text native string
			if (byteCountText > Utils.MaxStackallocSize)
				Utils.Free(nativeText);
		}

		public void DeleteChars(int pos, int bytesCount)
		{
			ImGuiNative.ImGuiInputTextCallbackDataDeleteChars(NativePtr, pos, bytesCount);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiInputTextCallbackDataDestroy(NativePtr);
		}

		public void ImGuiInputTextCallbackDataConstruct()
		{
			ImGuiNative.ImGuiInputTextCallbackDataImGuiInputTextCallbackDataConstruct(NativePtr);
		}

		public ImGuiInputTextCallbackDataPtr ImGuiInputTextCallbackData()
		{
			return ImGuiNative.ImGuiInputTextCallbackDataImGuiInputTextCallbackData();
		}

	}
}
