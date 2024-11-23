using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.</para>
	/// </summary>
	public unsafe partial struct ImGuiMenuColumns
	{
		public uint TotalWidth;
		public uint NextTotalWidth;
		public ushort Spacing;
		/// <summary>
		/// Always zero for now
		/// </summary>
		public ushort OffsetIcon;
		/// <summary>
		/// Offsets are locked in Update()
		/// </summary>
		public ushort OffsetLabel;
		public ushort OffsetShortcut;
		public ushort OffsetMark;
		/// <summary>
		/// Width of:   Icon, Label, Shortcut, Mark  (accumulators for current frame)
		/// </summary>
		public fixed ushort Widths[4];
	}

	/// <summary>
	/// <para>Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.</para>
	/// </summary>
	public unsafe partial struct ImGuiMenuColumnsPtr
	{
		public ImGuiMenuColumns* NativePtr { get; }
		public ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => NativePtr = nativePtr;
		public ImGuiMenuColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiMenuColumns*)nativePtr;
		public static implicit operator ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => new ImGuiMenuColumnsPtr(nativePtr);
		public static implicit operator ImGuiMenuColumns* (ImGuiMenuColumnsPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiMenuColumnsPtr(IntPtr nativePtr) => new ImGuiMenuColumnsPtr(nativePtr);

		public ref uint TotalWidth => ref Unsafe.AsRef<uint>(&NativePtr->TotalWidth);

		public ref uint NextTotalWidth => ref Unsafe.AsRef<uint>(&NativePtr->NextTotalWidth);

		public ref ushort Spacing => ref Unsafe.AsRef<ushort>(&NativePtr->Spacing);

		/// <summary>
		/// Always zero for now
		/// </summary>
		public ref ushort OffsetIcon => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetIcon);

		/// <summary>
		/// Offsets are locked in Update()
		/// </summary>
		public ref ushort OffsetLabel => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetLabel);

		public ref ushort OffsetShortcut => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetShortcut);

		public ref ushort OffsetMark => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetMark);

		/// <summary>
		/// Width of:   Icon, Label, Shortcut, Mark  (accumulators for current frame)
		/// </summary>
		public RangeAccessor<ushort> Widths => new RangeAccessor<ushort>(NativePtr->Widths, 4);

		public void Update(float spacing, bool window_reappearing)
		{
			// Marshaling 'window_reappearing' to native bool
			var native_window_reappearing = window_reappearing ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGuiMenuColumns_Update(NativePtr, spacing, native_window_reappearing);
		}

		public float DeclColumns(float w_icon, float w_label, float w_shortcut, float w_mark)
		{
			var ret = ImGuiInternalNative.ImGuiMenuColumns_DeclColumns(NativePtr, w_icon, w_label, w_shortcut, w_mark);
			return ret;
		}

		public void CalcNextTotalWidth(bool update_offsets)
		{
			// Marshaling 'update_offsets' to native bool
			var native_update_offsets = update_offsets ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGuiMenuColumns_CalcNextTotalWidth(NativePtr, native_update_offsets);
		}
	}
}
