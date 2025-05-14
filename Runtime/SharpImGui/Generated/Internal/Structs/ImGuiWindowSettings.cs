using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Windows data saved in imgui.ini file<br/>Because we never destroy or rename ImGuiWindowSettings, we can store the names in a separate buffer easily.<br/>(this is designed to be stored in a ImChunkStream buffer, with the variable-length Name following our structure)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiWindowSettings
	{
		public uint ID;
		/// <summary>
		/// NB: Settings position are stored RELATIVE to the viewport! Whereas runtime ones are absolute positions.<br/>
		/// </summary>
		public ImVec2Ih Pos;
		public ImVec2Ih Size;
		public ImVec2Ih ViewportPos;
		public uint ViewportId;
		/// <summary>
		/// ID of last known DockNode (even if the DockNode is invisible because it has only 1 active window), or 0 if none.<br/>
		/// </summary>
		public uint DockId;
		/// <summary>
		/// ID of window class if specified<br/>
		/// </summary>
		public uint ClassId;
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.<br/>
		/// </summary>
		public short DockOrder;
		public byte Collapsed;
		public byte IsChild;
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)<br/>
		/// </summary>
		public byte WantApply;
		/// <summary>
		/// Set to invalidate/delete the settings entry<br/>
		/// </summary>
		public byte WantDelete;
	}

	/// <summary>
	/// Windows data saved in imgui.ini file<br/>Because we never destroy or rename ImGuiWindowSettings, we can store the names in a separate buffer easily.<br/>(this is designed to be stored in a ImChunkStream buffer, with the variable-length Name following our structure)<br/>
	/// </summary>
	public unsafe partial struct ImGuiWindowSettingsPtr
	{
		public ImGuiWindowSettings* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiWindowSettings this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// NB: Settings position are stored RELATIVE to the viewport! Whereas runtime ones are absolute positions.<br/>
		/// </summary>
		public ref ImVec2Ih Pos => ref Unsafe.AsRef<ImVec2Ih>(&NativePtr->Pos);
		public ref ImVec2Ih Size => ref Unsafe.AsRef<ImVec2Ih>(&NativePtr->Size);
		public ref ImVec2Ih ViewportPos => ref Unsafe.AsRef<ImVec2Ih>(&NativePtr->ViewportPos);
		public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);
		/// <summary>
		/// ID of last known DockNode (even if the DockNode is invisible because it has only 1 active window), or 0 if none.<br/>
		/// </summary>
		public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);
		/// <summary>
		/// ID of window class if specified<br/>
		/// </summary>
		public ref uint ClassId => ref Unsafe.AsRef<uint>(&NativePtr->ClassId);
		/// <summary>
		/// Order of the last time the window was visible within its DockNode. This is used to reorder windows that are reappearing on the same frame. Same value between windows that were active and windows that were none are possible.<br/>
		/// </summary>
		public ref short DockOrder => ref Unsafe.AsRef<short>(&NativePtr->DockOrder);
		public ref bool Collapsed => ref Unsafe.AsRef<bool>(&NativePtr->Collapsed);
		public ref bool IsChild => ref Unsafe.AsRef<bool>(&NativePtr->IsChild);
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)<br/>
		/// </summary>
		public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);
		/// <summary>
		/// Set to invalidate/delete the settings entry<br/>
		/// </summary>
		public ref bool WantDelete => ref Unsafe.AsRef<bool>(&NativePtr->WantDelete);
		public ImGuiWindowSettingsPtr(ImGuiWindowSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiWindowSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiWindowSettings*)nativePtr;
		public static implicit operator ImGuiWindowSettingsPtr(ImGuiWindowSettings* ptr) => new ImGuiWindowSettingsPtr(ptr);
		public static implicit operator ImGuiWindowSettingsPtr(IntPtr ptr) => new ImGuiWindowSettingsPtr(ptr);
		public static implicit operator ImGuiWindowSettings*(ImGuiWindowSettingsPtr nativePtr) => nativePtr.NativePtr;
		public ref byte GetName()
		{
			var nativeResult = ImGuiNative.ImGuiWindowSettingsGetName(NativePtr);
			return ref *(byte*)&nativeResult;
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiWindowSettingsDestroy(NativePtr);
		}

		public void ImGuiWindowSettingsConstruct()
		{
			ImGuiNative.ImGuiWindowSettingsImGuiWindowSettingsConstruct(NativePtr);
		}

		public ImGuiWindowSettingsPtr ImGuiWindowSettings()
		{
			return ImGuiNative.ImGuiWindowSettingsImGuiWindowSettings();
		}

	}
}
