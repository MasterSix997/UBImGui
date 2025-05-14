using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Internal state of the currently focused/edited text input box<br/>For a given item ID, access with ImGui::GetInputTextState()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputTextState
	{
		/// <summary>
		/// parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public unsafe ImGuiContext* Ctx;
		/// <summary>
		/// State for stb_textedit.h<br/>
		/// </summary>
		public unsafe STBTexteditState* Stb;
		/// <summary>
		/// copy of InputText() flags. may be used to check if e.g. ImGuiInputTextFlags_Password is set.<br/>
		/// </summary>
		public ImGuiInputTextFlags Flags;
		/// <summary>
		/// widget id owning the text state<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// UTF-8 length of the string in TextA (in bytes)<br/>
		/// </summary>
		public int TextLen;
		/// <summary>
		/// == TextA.Data unless read-only, in which case == buf passed to InputText(). Field only set and valid _inside_ the call InputText() call.<br/>
		/// </summary>
		public unsafe byte* TextSrc;
		/// <summary>
		/// main UTF8 buffer. TextA.Size is a buffer size! Should always be &gt;= buf_size passed by user (and of course &gt;= CurLenA + 1).<br/>
		/// </summary>
		public ImVector<byte> TextA;
		/// <summary>
		/// value to revert to when pressing Escape = backup of end-user buffer at the time of focus (in UTF-8, unaltered)<br/>
		/// </summary>
		public ImVector<byte> TextToRevertTo;
		/// <summary>
		/// temporary storage for callback to support automatic reconcile of undo-stack<br/>
		/// </summary>
		public ImVector<byte> CallbackTextBackup;
		/// <summary>
		/// end-user buffer capacity (include zero terminator)<br/>
		/// </summary>
		public int BufCapacity;
		/// <summary>
		/// horizontal offset (managed manually) + vertical scrolling (pulled from child window's own Scroll.y)<br/>
		/// </summary>
		public Vector2 Scroll;
		/// <summary>
		/// timer for cursor blink, reset on every user action so the cursor reappears immediately<br/>
		/// </summary>
		public float CursorAnim;
		/// <summary>
		/// set when we want scrolling to follow the current cursor position (not always!)<br/>
		/// </summary>
		public byte CursorFollow;
		/// <summary>
		/// after a double-click to select all, we ignore further mouse drags to update selection<br/>
		/// </summary>
		public byte SelectedAllMouseLock;
		/// <summary>
		/// edited this frame<br/>
		/// </summary>
		public byte Edited;
		/// <summary>
		/// force a reload of user buf so it may be modified externally. may be automatic in future version.<br/>
		/// </summary>
		public byte WantReloadUserBuf;
		public int ReloadSelectionStart;
		public int ReloadSelectionEnd;
	}

	/// <summary>
	/// Internal state of the currently focused/edited text input box<br/>For a given item ID, access with ImGui::GetInputTextState()<br/>
	/// </summary>
	public unsafe partial struct ImGuiInputTextStatePtr
	{
		public ImGuiInputTextState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputTextState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// parent UI context (needs to be set explicitly by parent).<br/>
		/// </summary>
		public ref ImGuiContextPtr Ctx => ref Unsafe.AsRef<ImGuiContextPtr>(&NativePtr->Ctx);
		/// <summary>
		/// State for stb_textedit.h<br/>
		/// </summary>
		public ref STBTexteditStatePtr Stb => ref Unsafe.AsRef<STBTexteditStatePtr>(&NativePtr->Stb);
		/// <summary>
		/// copy of InputText() flags. may be used to check if e.g. ImGuiInputTextFlags_Password is set.<br/>
		/// </summary>
		public ref ImGuiInputTextFlags Flags => ref Unsafe.AsRef<ImGuiInputTextFlags>(&NativePtr->Flags);
		/// <summary>
		/// widget id owning the text state<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// UTF-8 length of the string in TextA (in bytes)<br/>
		/// </summary>
		public ref int TextLen => ref Unsafe.AsRef<int>(&NativePtr->TextLen);
		/// <summary>
		/// == TextA.Data unless read-only, in which case == buf passed to InputText(). Field only set and valid _inside_ the call InputText() call.<br/>
		/// </summary>
		public IntPtr TextSrc { get => (IntPtr)NativePtr->TextSrc; set => NativePtr->TextSrc = (byte*)value; }
		/// <summary>
		/// main UTF8 buffer. TextA.Size is a buffer size! Should always be &gt;= buf_size passed by user (and of course &gt;= CurLenA + 1).<br/>
		/// </summary>
		public ref ImVector<byte> TextA => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->TextA);
		/// <summary>
		/// value to revert to when pressing Escape = backup of end-user buffer at the time of focus (in UTF-8, unaltered)<br/>
		/// </summary>
		public ref ImVector<byte> TextToRevertTo => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->TextToRevertTo);
		/// <summary>
		/// temporary storage for callback to support automatic reconcile of undo-stack<br/>
		/// </summary>
		public ref ImVector<byte> CallbackTextBackup => ref Unsafe.AsRef<ImVector<byte>>(&NativePtr->CallbackTextBackup);
		/// <summary>
		/// end-user buffer capacity (include zero terminator)<br/>
		/// </summary>
		public ref int BufCapacity => ref Unsafe.AsRef<int>(&NativePtr->BufCapacity);
		/// <summary>
		/// horizontal offset (managed manually) + vertical scrolling (pulled from child window's own Scroll.y)<br/>
		/// </summary>
		public ref Vector2 Scroll => ref Unsafe.AsRef<Vector2>(&NativePtr->Scroll);
		/// <summary>
		/// timer for cursor blink, reset on every user action so the cursor reappears immediately<br/>
		/// </summary>
		public ref float CursorAnim => ref Unsafe.AsRef<float>(&NativePtr->CursorAnim);
		/// <summary>
		/// set when we want scrolling to follow the current cursor position (not always!)<br/>
		/// </summary>
		public ref bool CursorFollow => ref Unsafe.AsRef<bool>(&NativePtr->CursorFollow);
		/// <summary>
		/// after a double-click to select all, we ignore further mouse drags to update selection<br/>
		/// </summary>
		public ref bool SelectedAllMouseLock => ref Unsafe.AsRef<bool>(&NativePtr->SelectedAllMouseLock);
		/// <summary>
		/// edited this frame<br/>
		/// </summary>
		public ref bool Edited => ref Unsafe.AsRef<bool>(&NativePtr->Edited);
		/// <summary>
		/// force a reload of user buf so it may be modified externally. may be automatic in future version.<br/>
		/// </summary>
		public ref bool WantReloadUserBuf => ref Unsafe.AsRef<bool>(&NativePtr->WantReloadUserBuf);
		public ref int ReloadSelectionStart => ref Unsafe.AsRef<int>(&NativePtr->ReloadSelectionStart);
		public ref int ReloadSelectionEnd => ref Unsafe.AsRef<int>(&NativePtr->ReloadSelectionEnd);
		public ImGuiInputTextStatePtr(ImGuiInputTextState* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputTextStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiInputTextState*)nativePtr;
		public static implicit operator ImGuiInputTextStatePtr(ImGuiInputTextState* ptr) => new ImGuiInputTextStatePtr(ptr);
		public static implicit operator ImGuiInputTextStatePtr(IntPtr ptr) => new ImGuiInputTextStatePtr(ptr);
		public static implicit operator ImGuiInputTextState*(ImGuiInputTextStatePtr nativePtr) => nativePtr.NativePtr;
		public void ReloadUserBufAndMoveToEnd()
		{
			ImGuiNative.ImGuiInputTextStateReloadUserBufAndMoveToEnd(NativePtr);
		}

		public void ReloadUserBufAndKeepSelection()
		{
			ImGuiNative.ImGuiInputTextStateReloadUserBufAndKeepSelection(NativePtr);
		}

		public void ReloadUserBufAndSelectAll()
		{
			ImGuiNative.ImGuiInputTextStateReloadUserBufAndSelectAll(NativePtr);
		}

		public void SelectAll()
		{
			ImGuiNative.ImGuiInputTextStateSelectAll(NativePtr);
		}

		public int GetSelectionEnd()
		{
			return ImGuiNative.ImGuiInputTextStateGetSelectionEnd(NativePtr);
		}

		public int GetSelectionStart()
		{
			return ImGuiNative.ImGuiInputTextStateGetSelectionStart(NativePtr);
		}

		public int GetCursorPos()
		{
			return ImGuiNative.ImGuiInputTextStateGetCursorPos(NativePtr);
		}

		public void ClearSelection()
		{
			ImGuiNative.ImGuiInputTextStateClearSelection(NativePtr);
		}

		public bool HasSelection()
		{
			var result = ImGuiNative.ImGuiInputTextStateHasSelection(NativePtr);
			return result != 0;
		}

		public void CursorClamp()
		{
			ImGuiNative.ImGuiInputTextStateCursorClamp(NativePtr);
		}

		public void CursorAnimReset()
		{
			ImGuiNative.ImGuiInputTextStateCursorAnimReset(NativePtr);
		}

		public void OnCharPressed(uint c)
		{
			ImGuiNative.ImGuiInputTextStateOnCharPressed(NativePtr, c);
		}

		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation<br/>
		/// </summary>
		public void OnKeyPressed(int key)
		{
			ImGuiNative.ImGuiInputTextStateOnKeyPressed(NativePtr, key);
		}

		public void ClearFreeMemory()
		{
			ImGuiNative.ImGuiInputTextStateClearFreeMemory(NativePtr);
		}

		public void ClearText()
		{
			ImGuiNative.ImGuiInputTextStateClearText(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiInputTextStateDestroy(NativePtr);
		}

		public void ImGuiInputTextStateConstruct()
		{
			ImGuiNative.ImGuiInputTextStateImGuiInputTextStateConstruct(NativePtr);
		}

		public ImGuiInputTextStatePtr ImGuiInputTextState()
		{
			return ImGuiNative.ImGuiInputTextStateImGuiInputTextState();
		}

	}
}
