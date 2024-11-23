using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>This is designed to be stored in a single ImChunkStream (1 header followed by N ImGuiTableColumnSettings, etc.)</para>
	/// </summary>
	public unsafe partial struct ImGuiTableSettings
	{
		/// <summary>
		/// Set to 0 to invalidate/delete the setting
		/// </summary>
		public uint ID;
		/// <summary>
		/// Indicate data we want to save using the Resizable/Reorderable/Sortable/Hideable flags (could be using its own flags..)
		/// </summary>
		public ImGuiTableFlags SaveFlags;
		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.
		/// </summary>
		public float RefScale;
		public short ColumnsCount;
		/// <summary>
		/// Maximum number of columns this settings instance can store, we can recycle a settings instance with lower number of columns but not higher
		/// </summary>
		public short ColumnsCountMax;
		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)
		/// </summary>
		public byte WantApply;
	}

	/// <summary>
	/// <para>This is designed to be stored in a single ImChunkStream (1 header followed by N ImGuiTableColumnSettings, etc.)</para>
	/// </summary>
	public unsafe partial struct ImGuiTableSettingsPtr
	{
		public ImGuiTableSettings* NativePtr { get; }
		public ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => NativePtr = nativePtr;
		public ImGuiTableSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSettings*)nativePtr;
		public static implicit operator ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => new ImGuiTableSettingsPtr(nativePtr);
		public static implicit operator ImGuiTableSettings* (ImGuiTableSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTableSettingsPtr(IntPtr nativePtr) => new ImGuiTableSettingsPtr(nativePtr);

		/// <summary>
		/// Set to 0 to invalidate/delete the setting
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// Indicate data we want to save using the Resizable/Reorderable/Sortable/Hideable flags (could be using its own flags..)
		/// </summary>
		public ref ImGuiTableFlags SaveFlags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->SaveFlags);

		/// <summary>
		/// Reference scale to be able to rescale columns on font/dpi changes.
		/// </summary>
		public ref float RefScale => ref Unsafe.AsRef<float>(&NativePtr->RefScale);

		public ref short ColumnsCount => ref Unsafe.AsRef<short>(&NativePtr->ColumnsCount);

		/// <summary>
		/// Maximum number of columns this settings instance can store, we can recycle a settings instance with lower number of columns but not higher
		/// </summary>
		public ref short ColumnsCountMax => ref Unsafe.AsRef<short>(&NativePtr->ColumnsCountMax);

		/// <summary>
		/// Set when loaded from .ini data (to enable merging/loading .ini data into an already running context)
		/// </summary>
		public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);

		public ImGuiTableColumnSettingsPtr GetColumnSettings()
		{
			var ret = ImGuiInternalNative.ImGuiTableSettings_GetColumnSettings(NativePtr);
			return ret;
		}
	}
}
