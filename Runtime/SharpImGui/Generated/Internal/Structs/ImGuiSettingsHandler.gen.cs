using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiSettingsHandler
	{
		/// <summary>
		/// Short description stored in .ini file. Disallowed characters: '[' ']'
		/// </summary>
		public byte* TypeName;
		/// <summary>
		/// == ImHashStr(TypeName)
		/// </summary>
		public uint TypeHash;
		/// <summary>
		/// Clear all settings data
		/// </summary>
		public IntPtr ClearAllFn;
		/// <summary>
		/// Read: Called before reading (in registration order)
		/// </summary>
		public IntPtr ReadInitFn;
		/// <summary>
		/// Read: Called when entering into a new ini entry e.g. "[Window][Name]"
		/// </summary>
		public IntPtr ReadOpenFn;
		/// <summary>
		/// Read: Called for every line of text within an ini entry
		/// </summary>
		public IntPtr ReadLineFn;
		/// <summary>
		/// Read: Called after reading (in registration order)
		/// </summary>
		public IntPtr ApplyAllFn;
		/// <summary>
		/// Write: Output every entries into 'out_buf'
		/// </summary>
		public IntPtr WriteAllFn;
		public void* UserData;
	}

	public unsafe partial struct ImGuiSettingsHandlerPtr
	{
		public ImGuiSettingsHandler* NativePtr { get; }
		public ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => NativePtr = nativePtr;
		public ImGuiSettingsHandlerPtr(IntPtr nativePtr) => NativePtr = (ImGuiSettingsHandler*)nativePtr;
		public static implicit operator ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => new ImGuiSettingsHandlerPtr(nativePtr);
		public static implicit operator ImGuiSettingsHandler* (ImGuiSettingsHandlerPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiSettingsHandlerPtr(IntPtr nativePtr) => new ImGuiSettingsHandlerPtr(nativePtr);

		/// <summary>
		/// Short description stored in .ini file. Disallowed characters: '[' ']'
		/// </summary>
		public NullTerminatedString TypeName => new NullTerminatedString(NativePtr->TypeName);

		/// <summary>
		/// == ImHashStr(TypeName)
		/// </summary>
		public ref uint TypeHash => ref Unsafe.AsRef<uint>(&NativePtr->TypeHash);

		/// <summary>
		/// Clear all settings data
		/// </summary>
		public ClearAllFnDelegate ClearAllFn
		{
			get => (ClearAllFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->ClearAllFn, typeof(ClearAllFnDelegate));
			set => NativePtr->ClearAllFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// Read: Called before reading (in registration order)
		/// </summary>
		public ReadInitFnDelegate ReadInitFn
		{
			get => (ReadInitFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->ReadInitFn, typeof(ReadInitFnDelegate));
			set => NativePtr->ReadInitFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// Read: Called when entering into a new ini entry e.g. "[Window][Name]"
		/// </summary>
		public ReadOpenFnDelegate ReadOpenFn
		{
			get => (ReadOpenFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->ReadOpenFn, typeof(ReadOpenFnDelegate));
			set => NativePtr->ReadOpenFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// Read: Called for every line of text within an ini entry
		/// </summary>
		public ReadLineFnDelegate ReadLineFn
		{
			get => (ReadLineFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->ReadLineFn, typeof(ReadLineFnDelegate));
			set => NativePtr->ReadLineFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// Read: Called after reading (in registration order)
		/// </summary>
		public ApplyAllFnDelegate ApplyAllFn
		{
			get => (ApplyAllFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->ApplyAllFn, typeof(ApplyAllFnDelegate));
			set => NativePtr->ApplyAllFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		/// <summary>
		/// Write: Output every entries into 'out_buf'
		/// </summary>
		public WriteAllFnDelegate WriteAllFn
		{
			get => (WriteAllFnDelegate)Marshal.GetDelegateForFunctionPointer(NativePtr->WriteAllFn, typeof(WriteAllFnDelegate));
			set => NativePtr->WriteAllFn = Marshal.GetFunctionPointerForDelegate(value);
		}

		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
	}
}
