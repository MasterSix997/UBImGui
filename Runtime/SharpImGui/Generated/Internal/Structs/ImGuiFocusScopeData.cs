using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for PushFocusScope(), g.FocusScopeStack[], g.NavFocusRoute[]<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiFocusScopeData
	{
		public uint ID;
		public uint WindowID;
	}

	/// <summary>
	/// Storage for PushFocusScope(), g.FocusScopeStack[], g.NavFocusRoute[]<br/>
	/// </summary>
	public unsafe partial struct ImGuiFocusScopeDataPtr
	{
		public ImGuiFocusScopeData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiFocusScopeData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref uint WindowID => ref Unsafe.AsRef<uint>(&NativePtr->WindowID);
		public ImGuiFocusScopeDataPtr(ImGuiFocusScopeData* nativePtr) => NativePtr = nativePtr;
		public ImGuiFocusScopeDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiFocusScopeData*)nativePtr;
		public static implicit operator ImGuiFocusScopeDataPtr(ImGuiFocusScopeData* ptr) => new ImGuiFocusScopeDataPtr(ptr);
		public static implicit operator ImGuiFocusScopeDataPtr(IntPtr ptr) => new ImGuiFocusScopeDataPtr(ptr);
		public static implicit operator ImGuiFocusScopeData*(ImGuiFocusScopeDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
