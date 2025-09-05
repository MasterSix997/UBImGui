using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// FIXME: Structures in the union below need to be declared as anonymous unions appears to be an extension?<br/>Using ImVec2() would fail on Clang 'union member 'MousePos' has a non-trivial default constructor'<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiInputEventMousePos
	{
		public float PosX;
		public float PosY;
		public ImGuiMouseSource MouseSource;
	}

	/// <summary>
	/// FIXME: Structures in the union below need to be declared as anonymous unions appears to be an extension?<br/>Using ImVec2() would fail on Clang 'union member 'MousePos' has a non-trivial default constructor'<br/>
	/// </summary>
	public unsafe partial struct ImGuiInputEventMousePosPtr
	{
		public ImGuiInputEventMousePos* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiInputEventMousePos this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref float PosX => ref Unsafe.AsRef<float>(&NativePtr->PosX);
		public ref float PosY => ref Unsafe.AsRef<float>(&NativePtr->PosY);
		public ref ImGuiMouseSource MouseSource => ref Unsafe.AsRef<ImGuiMouseSource>(&NativePtr->MouseSource);
		public ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* nativePtr) => NativePtr = nativePtr;
		public ImGuiInputEventMousePosPtr(IntPtr nativePtr) => NativePtr = (ImGuiInputEventMousePos*)nativePtr;
		public static implicit operator ImGuiInputEventMousePosPtr(ImGuiInputEventMousePos* ptr) => new ImGuiInputEventMousePosPtr(ptr);
		public static implicit operator ImGuiInputEventMousePosPtr(IntPtr ptr) => new ImGuiInputEventMousePosPtr(ptr);
		public static implicit operator ImGuiInputEventMousePos*(ImGuiInputEventMousePosPtr nativePtr) => nativePtr.NativePtr;
	}
}
