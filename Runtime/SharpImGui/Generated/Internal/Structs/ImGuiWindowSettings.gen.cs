using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Windows data saved in imgui.ini file</para>
	/// <para>Because we never destroy or rename ImGuiWindowSettings, we can store the names in a separate buffer easily.</para>
	/// <para>(this is designed to be stored in a ImChunkStream buffer, with the variable-length Name following our structure)</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowSettings
	{
		public uint ID;
		/// <summary>
		/// NB: Settings position are stored RELATIVE to the viewport! Whereas runtime ones are absolute positions.
		/// </summary>
		public ImVec2ih Pos;
		public ImVec2ih Size;
		public ImVec2ih ViewportPos;
		public uint ViewportId;
		/// <summary>
		/// ID of last known DockNode (even if the DockNode is invisible because it has only 1 active window), or 0 if none.
		/// </summary>
		public uint DockId;
		/// <summary>
		/// ID of window class if specified
		/// </summary>
		public uint ClassId;
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.
		/// </summary>
		public short DockOrder;
		public byte Collapsed;
		public byte IsChild;
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)
		/// </summary>
		public byte WantApply;
		/// <summary>
		/// Set to invalidate/delete the settings entry
		/// </summary>
		public byte WantDelete;
	}

	/// <summary>
	/// <para>Windows data saved in imgui.ini file</para>
	/// <para>Because we never destroy or rename ImGuiWindowSettings, we can store the names in a separate buffer easily.</para>
	/// <para>(this is designed to be stored in a ImChunkStream buffer, with the variable-length Name following our structure)</para>
	/// </summary>
	public unsafe partial struct ImGuiWindowSettingsPtr
	{
		public ImGuiWindowSettings* NativePtr { get; }
		public ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowSettings*)nativePtr;
		public static implicit operator ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => new ImGuiWindowSettingsPtr(nativePtr);
		public static implicit operator ImGuiWindowSettings* (ImGuiWindowSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiWindowSettingsPtr(IntPtr nativePtr) => new ImGuiWindowSettingsPtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// NB: Settings position are stored RELATIVE to the viewport! Whereas runtime ones are absolute positions.
		/// </summary>
		public ref ImVec2ih Pos => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->Pos);

		public ref ImVec2ih Size => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->Size);

		public ref ImVec2ih ViewportPos => ref Unsafe.AsRef<ImVec2ih>(&NativePtr->ViewportPos);

		public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);

		/// <summary>
		/// ID of last known DockNode (even if the DockNode is invisible because it has only 1 active window), or 0 if none.
		/// </summary>
		public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);

		/// <summary>
		/// ID of window class if specified
		/// </summary>
		public ref uint ClassId => ref Unsafe.AsRef<uint>(&NativePtr->ClassId);

		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.
		/// </summary>
		public ref short DockOrder => ref Unsafe.AsRef<short>(&NativePtr->DockOrder);

		public ref bool Collapsed => ref Unsafe.AsRef<bool>(&NativePtr->Collapsed);

		public ref bool IsChild => ref Unsafe.AsRef<bool>(&NativePtr->IsChild);

		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)
		/// </summary>
		public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);

		/// <summary>
		/// Set to invalidate/delete the settings entry
		/// </summary>
		public ref bool WantDelete => ref Unsafe.AsRef<bool>(&NativePtr->WantDelete);

		public string GetName()
		{
			var ret = ImGuiInternalNative.ImGuiWindowSettings_GetName(NativePtr);
			return Util.StringFromPtr(ret);
		}
	}
}
