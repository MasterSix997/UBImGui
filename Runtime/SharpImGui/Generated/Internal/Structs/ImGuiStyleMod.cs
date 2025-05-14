using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyleMod
	{
		[StructLayout(LayoutKind.Explicit)]
		public partial struct ImGuiStyleModUnion
		{
			[FieldOffset(0)]
			public unsafe int* BackupInt;
			[FieldOffset(0)]
			public unsafe Vector2* BackupFloat;
		}
		public ImGuiStyleVar VarIdx;
		public ImGuiStyleModUnion Union;
	}

	/// <summary>
	/// Stacked style modifier, backup of modified data so we can restore it. Data type inferred from the variable.<br/>
	/// </summary>
	public unsafe partial struct ImGuiStyleModPtr
	{
		public ImGuiStyleMod* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStyleMod this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiStyleVar VarIdx => ref Unsafe.AsRef<ImGuiStyleVar>(&NativePtr->VarIdx);
		public ref ImGuiStyleMod.ImGuiStyleModUnion Union => ref Unsafe.AsRef<ImGuiStyleMod.ImGuiStyleModUnion>(&NativePtr->Union);
		public ImGuiStyleModPtr(ImGuiStyleMod* nativePtr) => NativePtr = nativePtr;
		public ImGuiStyleModPtr(IntPtr nativePtr) => NativePtr = (ImGuiStyleMod*)nativePtr;
		public static implicit operator ImGuiStyleModPtr(ImGuiStyleMod* ptr) => new ImGuiStyleModPtr(ptr);
		public static implicit operator ImGuiStyleModPtr(IntPtr ptr) => new ImGuiStyleModPtr(ptr);
		public static implicit operator ImGuiStyleMod*(ImGuiStyleModPtr nativePtr) => nativePtr.NativePtr;
		public void ImGuiStyleModVec2Construct(ImGuiStyleVar idx, Vector2 v)
		{
			ImGuiNative.ImGuiStyleModImGuiStyleModVec2Construct(NativePtr, idx, v);
		}

		public ImGuiStyleModPtr ImGuiStyleMod(ImGuiStyleVar idx, Vector2 v)
		{
			return ImGuiNative.ImGuiStyleModImGuiStyleMod(idx, v);
		}

		public void ImGuiStyleModFloatConstruct(ImGuiStyleVar idx, float v)
		{
			ImGuiNative.ImGuiStyleModImGuiStyleModFloatConstruct(NativePtr, idx, v);
		}

		public ImGuiStyleModPtr ImGuiStyleMod(ImGuiStyleVar idx, float v)
		{
			return ImGuiNative.ImGuiStyleModImGuiStyleMod(idx, v);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiStyleModDestroy(NativePtr);
		}

		public void ImGuiStyleModIntConstruct(ImGuiStyleVar idx, int v)
		{
			ImGuiNative.ImGuiStyleModImGuiStyleModIntConstruct(NativePtr, idx, v);
		}

		public ImGuiStyleModPtr ImGuiStyleMod(ImGuiStyleVar idx, int v)
		{
			return ImGuiNative.ImGuiStyleModImGuiStyleMod(idx, v);
		}

	}
}
