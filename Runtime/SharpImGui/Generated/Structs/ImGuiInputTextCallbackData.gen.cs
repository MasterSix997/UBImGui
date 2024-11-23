using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Shared state of InputText(), passed as an argument to your callback when a ImGuiInputTextFlags_Callback* flag is used.</para>
	/// <para>The callback function should return 0 by default.</para>
	/// <para>Callbacks (follow a flag name and see comments in ImGuiInputTextFlags_ declarations for more details)</para>
	/// <para>- ImGuiInputTextFlags_CallbackEdit:        Callback on buffer edit (note that InputText() already returns true on edit, the callback is useful mainly to manipulate the underlying buffer while focus is active)</para>
	/// <para>- ImGuiInputTextFlags_CallbackAlways:      Callback on each iteration</para>
	/// <para>- ImGuiInputTextFlags_CallbackCompletion:  Callback on pressing TAB</para>
	/// <para>- ImGuiInputTextFlags_CallbackHistory:     Callback on pressing Up/Down arrows</para>
	/// <para>- ImGuiInputTextFlags_CallbackCharFilter:  Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.</para>
	/// <para>- ImGuiInputTextFlags_CallbackResize:      Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow.</para>
	/// </summary>
	public unsafe partial struct ImGuiInputTextCallbackData
	{
		/// <summary>
		/// Parent UI context
		/// </summary>
		public IntPtr Ctx;
		/// <summary>
		/// One ImGuiInputTextFlags_Callback*    // Read-only
		/// </summary>
		public ImGuiInputTextFlags EventFlag;
		/// <summary>
		/// What user passed to InputText()      // Read-only
		/// </summary>
		public ImGuiInputTextFlags Flags;
		/// <summary>
		/// What user passed to InputText()      // Read-only
		/// </summary>
		public void* UserData;
		/// <summary>
		/// <para>Arguments for the different callback events</para>
		/// <para>- During Resize callback, Buf will be same as your input buffer.</para>
		/// <para>- However, during Completion/History/Always callback, Buf always points to our own internal data (it is not the same as your buffer)! Changes to it will be reflected into your own buffer shortly after the callback.</para>
		/// <para>- To modify the text buffer in a callback, prefer using the InsertChars() / DeleteChars() function. InsertChars() will take care of calling the resize callback if necessary.</para>
		/// <para>- If you know your edits are not going to resize the underlying buffer allocation, you may modify the contents of 'Buf[]' directly. You need to update 'BufTextLen' accordingly (0 &lt;= BufTextLen &lt; BufSize) and set 'BufDirty'' to true so InputText can update its internal state.</para>
		/// </summary>
		/// <summary>
		/// Character input                      // Read-write   // [CharFilter] Replace character with another one, or set to zero to drop. return 1 is equivalent to setting EventChar=0;
		/// </summary>
		public ushort EventChar;
		/// <summary>
		/// Key pressed (Up/Down/TAB)            // Read-only    // [Completion,History]
		/// </summary>
		public ImGuiKey EventKey;
		/// <summary>
		/// Text buffer                          // Read-write   // [Resize] Can replace pointer / [Completion,History,Always] Only write to pointed data, don't replace the actual pointer!
		/// </summary>
		public byte* Buf;
		/// <summary>
		/// Text length (in bytes)               // Read-write   // [Resize,Completion,History,Always] Exclude zero-terminator storage. In C land: == strlen(some_text), in C++ land: string.length()
		/// </summary>
		public int BufTextLen;
		/// <summary>
		/// Buffer size (in bytes) = capacity+1  // Read-only    // [Resize,Completion,History,Always] Include zero-terminator storage. In C land == ARRAYSIZE(my_char_array), in C++ land: string.capacity()+1
		/// </summary>
		public int BufSize;
		/// <summary>
		/// Set if you modify Buf/BufTextLen!    // Write        // [Completion,History,Always]
		/// </summary>
		public byte BufDirty;
		/// <summary>
		///                                      // Read-write   // [Completion,History,Always]
		/// </summary>
		public int CursorPos;
		/// <summary>
		///                                      // Read-write   // [Completion,History,Always] == to SelectionEnd when no selection)
		/// </summary>
		public int SelectionStart;
		/// <summary>
		///                                      // Read-write   // [Completion,History,Always]
		/// </summary>
		public int SelectionEnd;
	}

	/// <summary>
	/// <para>Shared state of InputText(), passed as an argument to your callback when a ImGuiInputTextFlags_Callback* flag is used.</para>
	/// <para>The callback function should return 0 by default.</para>
	/// <para>Callbacks (follow a flag name and see comments in ImGuiInputTextFlags_ declarations for more details)</para>
	/// <para>- ImGuiInputTextFlags_CallbackEdit:        Callback on buffer edit (note that InputText() already returns true on edit, the callback is useful mainly to manipulate the underlying buffer while focus is active)</para>
	/// <para>- ImGuiInputTextFlags_CallbackAlways:      Callback on each iteration</para>
	/// <para>- ImGuiInputTextFlags_CallbackCompletion:  Callback on pressing TAB</para>
	/// <para>- ImGuiInputTextFlags_CallbackHistory:     Callback on pressing Up/Down arrows</para>
	/// <para>- ImGuiInputTextFlags_CallbackCharFilter:  Callback on character inputs to replace or discard them. Modify 'EventChar' to replace or discard, or return 1 in callback to discard.</para>
	/// <para>- ImGuiInputTextFlags_CallbackResize:      Callback on buffer capacity changes request (beyond 'buf_size' parameter value), allowing the string to grow.</para>
	/// </summary>
	public unsafe partial struct ImGuiInputTextCallbackDataPtr
	{
		public ImGuiInputTextCallbackData* NativePtr { get; }
		public ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextCallbackData*)nativePtr;
		public static implicit operator ImGuiInputTextCallbackDataPtr(ImGuiInputTextCallbackData* nativePtr) => new ImGuiInputTextCallbackDataPtr(nativePtr);
		public static implicit operator ImGuiInputTextCallbackData* (ImGuiInputTextCallbackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiInputTextCallbackDataPtr(IntPtr nativePtr) => new ImGuiInputTextCallbackDataPtr(nativePtr);

		/// <summary>
		/// Parent UI context
		/// </summary>
		public ref IntPtr Ctx => ref Unsafe.AsRef<IntPtr>(&NativePtr->Ctx);

		/// <summary>
		/// One ImGuiInputTextFlags_Callback*    // Read-only
		/// </summary>
		public ref ImGuiInputTextFlags EventFlag => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->EventFlag);

		/// <summary>
		/// What user passed to InputText()      // Read-only
		/// </summary>
		public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);

		/// <summary>
		/// What user passed to InputText()      // Read-only
		/// </summary>
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }

		/// <summary>
		/// <para>Arguments for the different callback events</para>
		/// <para>- During Resize callback, Buf will be same as your input buffer.</para>
		/// <para>- However, during Completion/History/Always callback, Buf always points to our own internal data (it is not the same as your buffer)! Changes to it will be reflected into your own buffer shortly after the callback.</para>
		/// <para>- To modify the text buffer in a callback, prefer using the InsertChars() / DeleteChars() function. InsertChars() will take care of calling the resize callback if necessary.</para>
		/// <para>- If you know your edits are not going to resize the underlying buffer allocation, you may modify the contents of 'Buf[]' directly. You need to update 'BufTextLen' accordingly (0 &lt;= BufTextLen &lt; BufSize) and set 'BufDirty'' to true so InputText can update its internal state.</para>
		/// </summary>
		/// <summary>
		/// Character input                      // Read-write   // [CharFilter] Replace character with another one, or set to zero to drop. return 1 is equivalent to setting EventChar=0;
		/// </summary>
		public ref ushort EventChar => ref Unsafe.AsRef<ushort>(&NativePtr->EventChar);

		/// <summary>
		/// Key pressed (Up/Down/TAB)            // Read-only    // [Completion,History]
		/// </summary>
		public ref ImGuiKey EventKey => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->EventKey);

		/// <summary>
		/// Text buffer                          // Read-write   // [Resize] Can replace pointer / [Completion,History,Always] Only write to pointed data, don't replace the actual pointer!
		/// </summary>
		public IntPtr Buf { get => (IntPtr)NativePtr->Buf; set => NativePtr->Buf = (byte*)value; }

		/// <summary>
		/// Text length (in bytes)               // Read-write   // [Resize,Completion,History,Always] Exclude zero-terminator storage. In C land: == strlen(some_text), in C++ land: string.length()
		/// </summary>
		public ref int BufTextLen => ref Unsafe.AsRef<int>(&NativePtr->BufTextLen);

		/// <summary>
		/// Buffer size (in bytes) = capacity+1  // Read-only    // [Resize,Completion,History,Always] Include zero-terminator storage. In C land == ARRAYSIZE(my_char_array), in C++ land: string.capacity()+1
		/// </summary>
		public ref int BufSize => ref Unsafe.AsRef<int>(&NativePtr->BufSize);

		/// <summary>
		/// Set if you modify Buf/BufTextLen!    // Write        // [Completion,History,Always]
		/// </summary>
		public ref bool BufDirty => ref Unsafe.AsRef<bool>(&NativePtr->BufDirty);

		/// <summary>
		///                                      // Read-write   // [Completion,History,Always]
		/// </summary>
		public ref int CursorPos => ref Unsafe.AsRef<int>(&NativePtr->CursorPos);

		/// <summary>
		///                                      // Read-write   // [Completion,History,Always] == to SelectionEnd when no selection)
		/// </summary>
		public ref int SelectionStart => ref Unsafe.AsRef<int>(&NativePtr->SelectionStart);

		/// <summary>
		///                                      // Read-write   // [Completion,History,Always]
		/// </summary>
		public ref int SelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->SelectionEnd);

		public void DeleteChars(int pos, int bytes_count)
		{
			ImGuiNative.ImGuiInputTextCallbackData_DeleteChars(NativePtr, pos, bytes_count);
		}

		public void InsertChars(int pos, ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			byte* text_end = null;

			ImGuiNative.ImGuiInputTextCallbackData_InsertChars(NativePtr, pos, native_text, text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}
		public void InsertChars(int pos, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImGuiNative.ImGuiInputTextCallbackData_InsertChars(NativePtr, pos, native_text, native_text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		public void SelectAll()
		{
			ImGuiNative.ImGuiInputTextCallbackData_SelectAll(NativePtr);
		}

		public void ClearSelection()
		{
			ImGuiNative.ImGuiInputTextCallbackData_ClearSelection(NativePtr);
		}

		public bool HasSelection()
		{
			var ret = ImGuiNative.ImGuiInputTextCallbackData_HasSelection(NativePtr);
			return ret != 0;
		}
	}
}
