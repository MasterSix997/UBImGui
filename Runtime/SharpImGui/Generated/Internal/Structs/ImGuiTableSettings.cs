using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// This is designed to be stored in a single ImChunkStream (1 header followed by N ImGuiTableColumnSettings, etc.)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTableSettings
	{
		/// <summary>
		/// Set to 0 to invalidate/delete the setting<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// Indicate data we want to save using the Resizable/Reorderable/Sortable/Hideable flags (could be using its own flags..)<br/>
		/// </summary>
		public ImGuiTableFlags SaveFlags;
		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.<br/>
		/// </summary>
		public float RefScale;
		public short ColumnsCount;
		/// <summary>
		/// Maximum number of columns this settings instance can store, we can recycle a settings instance with lower number of columns but not higher<br/>
		/// </summary>
		public short ColumnsCountMax;
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)<br/>
		/// </summary>
		public byte WantApply;
	}

	/// <summary>
	/// This is designed to be stored in a single ImChunkStream (1 header followed by N ImGuiTableColumnSettings, etc.)<br/>
	/// </summary>
	public unsafe partial struct ImGuiTableSettingsPtr
	{
		public ImGuiTableSettings* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTableSettings this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Set to 0 to invalidate/delete the setting<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// Indicate data we want to save using the Resizable/Reorderable/Sortable/Hideable flags (could be using its own flags..)<br/>
		/// </summary>
		public ref ImGuiTableFlags SaveFlags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->SaveFlags);
		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.<br/>
		/// </summary>
		public ref float RefScale => ref Unsafe.AsRef<float>(&NativePtr->RefScale);
		public ref short ColumnsCount => ref Unsafe.AsRef<short>(&NativePtr->ColumnsCount);
		/// <summary>
		/// Maximum number of columns this settings instance can store, we can recycle a settings instance with lower number of columns but not higher<br/>
		/// </summary>
		public ref short ColumnsCountMax => ref Unsafe.AsRef<short>(&NativePtr->ColumnsCountMax);
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)<br/>
		/// </summary>
		public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);
		public ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSettings*)nativePtr;
		public static implicit operator ImGuiTableSettingsPtr(ImGuiTableSettings* ptr) => new ImGuiTableSettingsPtr(ptr);
		public static implicit operator ImGuiTableSettingsPtr(IntPtr ptr) => new ImGuiTableSettingsPtr(ptr);
		public static implicit operator ImGuiTableSettings*(ImGuiTableSettingsPtr nativePtr) => nativePtr.NativePtr;
		public ImGuiTableColumnSettingsPtr GetColumnSettings()
		{
			return ImGuiNative.ImGuiTableSettingsGetColumnSettings(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiTableSettingsDestroy(NativePtr);
		}

		public void ImGuiTableSettingsConstruct()
		{
			ImGuiNative.ImGuiTableSettingsImGuiTableSettingsConstruct(NativePtr);
		}

		public ImGuiTableSettingsPtr ImGuiTableSettings()
		{
			return ImGuiNative.ImGuiTableSettingsImGuiTableSettings();
		}

	}
}
