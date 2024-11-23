using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Internal state of the currently focused/edited text input box</para>
	/// <para>For a given item ID, access with ImGui::GetInputTextState()</para>
	/// </summary>
	public unsafe partial struct ImGuiInputTextState
	{
		/// <summary>
		/// parent UI context (needs to be set explicitly by parent).
		/// </summary>
		public ImGuiContext* Ctx;
		/// <summary>
		/// State for stb_textedit.h
		/// </summary>
		public void* Stb;
		/// <summary>
		/// widget id owning the text state
		/// </summary>
		public uint ID;
		/// <summary>
		/// UTF-8 length of the string in TextA (in bytes)
		/// </summary>
		public int TextLen;
		/// <summary>
		/// main UTF8 buffer. TextA.Size is a buffer size! Should always be &gt;= buf_size passed by user (and of course &gt;= CurLenA + 1).
		/// </summary>
		public ImVector TextA;
		/// <summary>
		/// value to revert to when pressing Escape = backup of end-user buffer at the time of focus (in UTF-8, unaltered)
		/// </summary>
		public ImVector TextToRevertTo;
		/// <summary>
		/// temporary storage for callback to support automatic reconcile of undo-stack
		/// </summary>
		public ImVector CallbackTextBackup;
		/// <summary>
		/// end-user buffer capacity (include zero terminator)
		/// </summary>
		public int BufCapacity;
		/// <summary>
		/// horizontal offset (managed manually) + vertical scrolling (pulled from child window's own Scroll.y)
		/// </summary>
		public Vector2 Scroll;
		/// <summary>
		/// timer for cursor blink, reset on every user action so the cursor reappears immediately
		/// </summary>
		public float CursorAnim;
		/// <summary>
		/// set when we want scrolling to follow the current cursor position (not always!)
		/// </summary>
		public byte CursorFollow;
		/// <summary>
		/// after a double-click to select all, we ignore further mouse drags to update selection
		/// </summary>
		public byte SelectedAllMouseLock;
		/// <summary>
		/// edited this frame
		/// </summary>
		public byte Edited;
		/// <summary>
		/// copy of InputText() flags. may be used to check if e.g. ImGuiInputTextFlags_Password is set.
		/// </summary>
		public ImGuiInputTextFlags Flags;
		/// <summary>
		/// force a reload of user buf so it may be modified externally. may be automatic in future version.
		/// </summary>
		public byte ReloadUserBuf;
		/// <summary>
		/// POSITIONS ARE IN IMWCHAR units *NOT* UTF-8 this is why this is not exposed yet.
		/// </summary>
		public int ReloadSelectionStart;
		public int ReloadSelectionEnd;
	}

	/// <summary>
	/// <para>Internal state of the currently focused/edited text input box</para>
	/// <para>For a given item ID, access with ImGui::GetInputTextState()</para>
	/// </summary>
	public unsafe partial struct ImGuiInputTextStatePtr
	{
		public ImGuiInputTextState* NativePtr { get; }
		public ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextState*)nativePtr;
		public static implicit operator ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => new ImGuiInputTextStatePtr(nativePtr);
		public static implicit operator ImGuiInputTextState* (ImGuiInputTextStatePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiInputTextStatePtr(IntPtr nativePtr) => new ImGuiInputTextStatePtr(nativePtr);

		/// <summary>
		/// parent UI context (needs to be set explicitly by parent).
		/// </summary>
		public ImGuiContextPtr Ctx => new ImGuiContextPtr(NativePtr->Ctx);

		/// <summary>
		/// State for stb_textedit.h
		/// </summary>
		public IntPtr Stb { get => (IntPtr)NativePtr->Stb; set => NativePtr->Stb = (void*)value; }

		/// <summary>
		/// widget id owning the text state
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// UTF-8 length of the string in TextA (in bytes)
		/// </summary>
		public ref int TextLen => ref Unsafe.AsRef<int>(&NativePtr->TextLen);

		/// <summary>
		/// main UTF8 buffer. TextA.Size is a buffer size! Should always be &gt;= buf_size passed by user (and of course &gt;= CurLenA + 1).
		/// </summary>
		public ImVector<byte> TextA => new ImVector<byte>(NativePtr->TextA);

		/// <summary>
		/// value to revert to when pressing Escape = backup of end-user buffer at the time of focus (in UTF-8, unaltered)
		/// </summary>
		public ImVector<byte> TextToRevertTo => new ImVector<byte>(NativePtr->TextToRevertTo);

		/// <summary>
		/// temporary storage for callback to support automatic reconcile of undo-stack
		/// </summary>
		public ImVector<byte> CallbackTextBackup => new ImVector<byte>(NativePtr->CallbackTextBackup);

		/// <summary>
		/// end-user buffer capacity (include zero terminator)
		/// </summary>
		public ref int BufCapacity => ref Unsafe.AsRef<int>(&NativePtr->BufCapacity);

		/// <summary>
		/// horizontal offset (managed manually) + vertical scrolling (pulled from child window's own Scroll.y)
		/// </summary>
		public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);

		/// <summary>
		/// timer for cursor blink, reset on every user action so the cursor reappears immediately
		/// </summary>
		public ref float CursorAnim => ref Unsafe.AsRef<float>(&NativePtr->CursorAnim);

		/// <summary>
		/// set when we want scrolling to follow the current cursor position (not always!)
		/// </summary>
		public ref bool CursorFollow => ref Unsafe.AsRef<bool>(&NativePtr->CursorFollow);

		/// <summary>
		/// after a double-click to select all, we ignore further mouse drags to update selection
		/// </summary>
		public ref bool SelectedAllMouseLock => ref Unsafe.AsRef<bool>(&NativePtr->SelectedAllMouseLock);

		/// <summary>
		/// edited this frame
		/// </summary>
		public ref bool Edited => ref Unsafe.AsRef<bool>(&NativePtr->Edited);

		/// <summary>
		/// copy of InputText() flags. may be used to check if e.g. ImGuiInputTextFlags_Password is set.
		/// </summary>
		public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);

		/// <summary>
		/// force a reload of user buf so it may be modified externally. may be automatic in future version.
		/// </summary>
		public ref bool ReloadUserBuf => ref Unsafe.AsRef<bool>(&NativePtr->ReloadUserBuf);

		/// <summary>
		/// POSITIONS ARE IN IMWCHAR units *NOT* UTF-8 this is why this is not exposed yet.
		/// </summary>
		public ref int ReloadSelectionStart => ref Unsafe.AsRef<int>(&NativePtr->ReloadSelectionStart);

		public ref int ReloadSelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->ReloadSelectionEnd);

		public void ClearText()
		{
			ImGuiInternalNative.ImGuiInputTextState_ClearText(NativePtr);
		}

		public void ClearFreeMemory()
		{
			ImGuiInternalNative.ImGuiInputTextState_ClearFreeMemory(NativePtr);
		}

		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation
		/// </summary>
		public void OnKeyPressed(int key)
		{
			ImGuiInternalNative.ImGuiInputTextState_OnKeyPressed(NativePtr, key);
		}

		public void OnCharPressed(uint c)
		{
			ImGuiInternalNative.ImGuiInputTextState_OnCharPressed(NativePtr, c);
		}

		/// <summary>
		/// <para>Cursor &amp; Selection</para>
		/// </summary>
		public void CursorAnimReset()
		{
			ImGuiInternalNative.ImGuiInputTextState_CursorAnimReset(NativePtr);
		}

		public void CursorClamp()
		{
			ImGuiInternalNative.ImGuiInputTextState_CursorClamp(NativePtr);
		}

		public bool HasSelection()
		{
			var ret = ImGuiInternalNative.ImGuiInputTextState_HasSelection(NativePtr);
			return ret != 0;
		}

		public void ClearSelection()
		{
			ImGuiInternalNative.ImGuiInputTextState_ClearSelection(NativePtr);
		}

		public int GetCursorPos()
		{
			var ret = ImGuiInternalNative.ImGuiInputTextState_GetCursorPos(NativePtr);
			return ret;
		}

		public int GetSelectionStart()
		{
			var ret = ImGuiInternalNative.ImGuiInputTextState_GetSelectionStart(NativePtr);
			return ret;
		}

		public int GetSelectionEnd()
		{
			var ret = ImGuiInternalNative.ImGuiInputTextState_GetSelectionEnd(NativePtr);
			return ret;
		}

		public void SelectAll()
		{
			ImGuiInternalNative.ImGuiInputTextState_SelectAll(NativePtr);
		}

		/// <summary>
		/// <para>Reload user buf (WIP #2890)</para>
		/// <para>If you modify underlying user-passed const char* while active you need to call this (InputText V2 may lift this)</para>
		/// <para>  strcpy(my_buf, "hello");</para>
		/// <para>  if (ImGuiInputTextState* state = ImGui::GetInputTextState(id)) // id may be ImGui::GetItemID() is last item</para>
		/// <para>      state-&gt;ReloadUserBufAndSelectAll();</para>
		/// </summary>
		public void ReloadUserBufAndSelectAll()
		{
			ImGuiInternalNative.ImGuiInputTextState_ReloadUserBufAndSelectAll(NativePtr);
		}

		public void ReloadUserBufAndKeepSelection()
		{
			ImGuiInternalNative.ImGuiInputTextState_ReloadUserBufAndKeepSelection(NativePtr);
		}

		public void ReloadUserBufAndMoveToEnd()
		{
			ImGuiInternalNative.ImGuiInputTextState_ReloadUserBufAndMoveToEnd(NativePtr);
		}
	}
}
