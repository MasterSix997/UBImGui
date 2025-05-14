using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiMenuColumns
	{
		public uint TotalWidth;
		public uint NextTotalWidth;
		public ushort Spacing;
		/// <summary>
		/// Always zero for now<br/>
		/// </summary>
		public ushort OffsetIcon;
		/// <summary>
		/// Offsets are locked in Update()<br/>
		/// </summary>
		public ushort OffsetLabel;
		public ushort OffsetShortcut;
		public ushort OffsetMark;
		/// <summary>
		/// Width of:   Icon, Label, Shortcut, Mark  (accumulators for current frame)<br/>
		/// </summary>
		public ushort Widths_0;
		public ushort Widths_1;
		public ushort Widths_2;
		public ushort Widths_3;
	}

	/// <summary>
	/// Simple column measurement, currently used for MenuItem() only.. This is very short-sighted/throw-away code and NOT a generic helper.<br/>
	/// </summary>
	public unsafe partial struct ImGuiMenuColumnsPtr
	{
		public ImGuiMenuColumns* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiMenuColumns this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint TotalWidth => ref Unsafe.AsRef<uint>(&NativePtr->TotalWidth);
		public ref uint NextTotalWidth => ref Unsafe.AsRef<uint>(&NativePtr->NextTotalWidth);
		public ref ushort Spacing => ref Unsafe.AsRef<ushort>(&NativePtr->Spacing);
		/// <summary>
		/// Always zero for now<br/>
		/// </summary>
		public ref ushort OffsetIcon => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetIcon);
		/// <summary>
		/// Offsets are locked in Update()<br/>
		/// </summary>
		public ref ushort OffsetLabel => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetLabel);
		public ref ushort OffsetShortcut => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetShortcut);
		public ref ushort OffsetMark => ref Unsafe.AsRef<ushort>(&NativePtr->OffsetMark);
		/// <summary>
		/// Width of:   Icon, Label, Shortcut, Mark  (accumulators for current frame)<br/>
		/// </summary>
		public Span<ushort> Widths => new Span<ushort>(&NativePtr->Widths_0, 4);
		public ImGuiMenuColumnsPtr(ImGuiMenuColumns* nativePtr) => NativePtr = nativePtr;
		public ImGuiMenuColumnsPtr(IntPtr nativePtr) => NativePtr = (ImGuiMenuColumns*)nativePtr;
		public static implicit operator ImGuiMenuColumnsPtr(ImGuiMenuColumns* ptr) => new ImGuiMenuColumnsPtr(ptr);
		public static implicit operator ImGuiMenuColumnsPtr(IntPtr ptr) => new ImGuiMenuColumnsPtr(ptr);
		public static implicit operator ImGuiMenuColumns*(ImGuiMenuColumnsPtr nativePtr) => nativePtr.NativePtr;
		public void CalcNextTotalWidth(bool updateOffsets)
		{
			var native_updateOffsets = updateOffsets ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiMenuColumnsCalcNextTotalWidth(NativePtr, native_updateOffsets);
		}

		public float DeclColumns(float wIcon, float wLabel, float wShortcut, float wMark)
		{
			return ImGuiNative.ImGuiMenuColumnsDeclColumns(NativePtr, wIcon, wLabel, wShortcut, wMark);
		}

		public void Update(float spacing, bool windowReappearing)
		{
			var native_windowReappearing = windowReappearing ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiMenuColumnsUpdate(NativePtr, spacing, native_windowReappearing);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiMenuColumnsDestroy(NativePtr);
		}

		public void ImGuiMenuColumnsConstruct()
		{
			ImGuiNative.ImGuiMenuColumnsImGuiMenuColumnsConstruct(NativePtr);
		}

		public ImGuiMenuColumnsPtr ImGuiMenuColumns()
		{
			return ImGuiNative.ImGuiMenuColumnsImGuiMenuColumns();
		}

	}
}
