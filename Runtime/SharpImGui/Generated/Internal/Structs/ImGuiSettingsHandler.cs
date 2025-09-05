using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiSettingsHandler
	{
		/// <summary>
		/// Short description stored in .ini file. Disallowed characters: '[' ']'<br/>
		/// </summary>
		public unsafe byte* TypeName;
		/// <summary>
		/// == ImHashStr(TypeName)<br/>
		/// </summary>
		public uint TypeHash;
		/// <summary>
		/// Clear all settings data<br/>
		/// </summary>
		public unsafe void* ClearAllFn;
		/// <summary>
		/// Read: Called before reading (in registration order)<br/>
		/// </summary>
		public unsafe void* ReadInitFn;
		/// <summary>
		/// Read: Called when entering into a new ini entry e.g. "[Window][Name]"<br/>
		/// </summary>
		public unsafe void* ReadOpenFn;
		/// <summary>
		/// Read: Called for every line of text within an ini entry<br/>
		/// </summary>
		public unsafe void* ReadLineFn;
		/// <summary>
		/// Read: Called after reading (in registration order)<br/>
		/// </summary>
		public unsafe void* ApplyAllFn;
		/// <summary>
		/// Write: Output every entries into 'out_buf'<br/>
		/// </summary>
		public unsafe void* WriteAllFn;
		public unsafe void* UserData;
	}

	public unsafe partial struct ImGuiSettingsHandlerPtr
	{
		public ImGuiSettingsHandler* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiSettingsHandler this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Short description stored in .ini file. Disallowed characters: '[' ']'<br/>
		/// </summary>
		public IntPtr TypeName { get => (IntPtr)NativePtr->TypeName; set => NativePtr->TypeName = (byte*)value; }
		/// <summary>
		/// == ImHashStr(TypeName)<br/>
		/// </summary>
		public ref uint TypeHash => ref Unsafe.AsRef<uint>(&NativePtr->TypeHash);
		/// <summary>
		/// Clear all settings data<br/>
		/// </summary>
		public ClearAllFn ClearAllFn { get => (ClearAllFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->ClearAllFn, typeof(ClearAllFn)); set => NativePtr->ClearAllFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// Read: Called before reading (in registration order)<br/>
		/// </summary>
		public ReadInitFn ReadInitFn { get => (ReadInitFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->ReadInitFn, typeof(ReadInitFn)); set => NativePtr->ReadInitFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// Read: Called when entering into a new ini entry e.g. "[Window][Name]"<br/>
		/// </summary>
		public ReadOpenFn ReadOpenFn { get => (ReadOpenFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->ReadOpenFn, typeof(ReadOpenFn)); set => NativePtr->ReadOpenFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// Read: Called for every line of text within an ini entry<br/>
		/// </summary>
		public ReadLineFn ReadLineFn { get => (ReadLineFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->ReadLineFn, typeof(ReadLineFn)); set => NativePtr->ReadLineFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// Read: Called after reading (in registration order)<br/>
		/// </summary>
		public ApplyAllFn ApplyAllFn { get => (ApplyAllFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->ApplyAllFn, typeof(ApplyAllFn)); set => NativePtr->ApplyAllFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		/// <summary>
		/// Write: Output every entries into 'out_buf'<br/>
		/// </summary>
		public WriteAllFn WriteAllFn { get => (WriteAllFn) Marshal.GetDelegateForFunctionPointer((IntPtr)NativePtr->WriteAllFn, typeof(WriteAllFn)); set => NativePtr->WriteAllFn = (void*)Marshal.GetFunctionPointerForDelegate(value); }
		public IntPtr UserData { get => (IntPtr)NativePtr->UserData; set => NativePtr->UserData = (void*)value; }
		public ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* nativePtr) => NativePtr = nativePtr;
		public ImGuiSettingsHandlerPtr(IntPtr nativePtr) => NativePtr = (ImGuiSettingsHandler*)nativePtr;
		public static implicit operator ImGuiSettingsHandlerPtr(ImGuiSettingsHandler* ptr) => new ImGuiSettingsHandlerPtr(ptr);
		public static implicit operator ImGuiSettingsHandlerPtr(IntPtr ptr) => new ImGuiSettingsHandlerPtr(ptr);
		public static implicit operator ImGuiSettingsHandler*(ImGuiSettingsHandlerPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiSettingsHandlerDestroy(NativePtr);
		}

		public void ImGuiSettingsHandlerConstruct()
		{
			ImGuiNative.ImGuiSettingsHandlerImGuiSettingsHandlerConstruct(NativePtr);
		}

		public ImGuiSettingsHandlerPtr ImGuiSettingsHandler()
		{
			return ImGuiNative.ImGuiSettingsHandlerImGuiSettingsHandler();
		}

	}
}
