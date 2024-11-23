using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Storage for SetNexWindow** functions</para>
	/// </summary>
	public unsafe partial struct ImGuiNextWindowData
	{
		public ImGuiNextWindowDataFlags Flags;
		public ImGuiCond PosCond;
		public ImGuiCond SizeCond;
		public ImGuiCond CollapsedCond;
		public ImGuiCond DockCond;
		public Vector2 PosVal;
		public Vector2 PosPivotVal;
		public Vector2 SizeVal;
		public Vector2 ContentSizeVal;
		public Vector2 ScrollVal;
		public ImGuiChildFlags ChildFlags;
		public byte PosUndock;
		public byte CollapsedVal;
		public ImRect SizeConstraintRect;
		public IntPtr SizeCallback;
		public void* SizeCallbackUserData;
		/// <summary>
		/// Override background alpha
		/// </summary>
		public float BgAlphaVal;
		public uint ViewportId;
		public uint DockId;
		public ImGuiWindowClass WindowClass;
		/// <summary>
		/// (Always on) This is not exposed publicly, so we don't clear it and it doesn't have a corresponding flag (could we? for consistency?)
		/// </summary>
		public Vector2 MenuBarOffsetMinVal;
		public ImGuiWindowRefreshFlags RefreshFlagsVal;
	}

	/// <summary>
	/// <para>Storage for SetNexWindow** functions</para>
	/// </summary>
	public unsafe partial struct ImGuiNextWindowDataPtr
	{
		public ImGuiNextWindowData* NativePtr { get; }
		public ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNextWindowDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextWindowData*)nativePtr;
		public static implicit operator ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => new ImGuiNextWindowDataPtr(nativePtr);
		public static implicit operator ImGuiNextWindowData* (ImGuiNextWindowDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiNextWindowDataPtr(IntPtr nativePtr) => new ImGuiNextWindowDataPtr(nativePtr);

		public ref ImGuiNextWindowDataFlags Flags => ref Unsafe.AsRef<ImGuiNextWindowDataFlags>(&NativePtr->Flags);

		public ref ImGuiCond PosCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->PosCond);

		public ref ImGuiCond SizeCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SizeCond);

		public ref ImGuiCond CollapsedCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->CollapsedCond);

		public ref ImGuiCond DockCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->DockCond);

		public ref Vector2 PosVal => ref Unsafe.AsRef<Vector2>(&NativePtr->PosVal);

		public ref Vector2 PosPivotVal => ref Unsafe.AsRef<Vector2>(&NativePtr->PosPivotVal);

		public ref Vector2 SizeVal => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeVal);

		public ref Vector2 ContentSizeVal => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeVal);

		public ref Vector2 ScrollVal => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollVal);

		public ref ImGuiChildFlags ChildFlags => ref Unsafe.AsRef<ImGuiChildFlags>(&NativePtr->ChildFlags);

		public ref bool PosUndock => ref Unsafe.AsRef<bool>(&NativePtr->PosUndock);

		public ref bool CollapsedVal => ref Unsafe.AsRef<bool>(&NativePtr->CollapsedVal);

		public ref ImRect SizeConstraintRect => ref Unsafe.AsRef<ImRect>(&NativePtr->SizeConstraintRect);

		public ref ImGuiSizeCallback SizeCallback => ref Unsafe.AsRef<ImGuiSizeCallback>(&NativePtr->SizeCallback);

		public IntPtr SizeCallbackUserData { get => (IntPtr)NativePtr->SizeCallbackUserData; set => NativePtr->SizeCallbackUserData = (void*)value; }

		/// <summary>
		/// Override background alpha
		/// </summary>
		public ref float BgAlphaVal => ref Unsafe.AsRef<float>(&NativePtr->BgAlphaVal);

		public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);

		public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);

		public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);

		/// <summary>
		/// (Always on) This is not exposed publicly, so we don't clear it and it doesn't have a corresponding flag (could we? for consistency?)
		/// </summary>
		public ref Vector2 MenuBarOffsetMinVal => ref Unsafe.AsRef<Vector2>(&NativePtr->MenuBarOffsetMinVal);

		public ref ImGuiWindowRefreshFlags RefreshFlagsVal => ref Unsafe.AsRef<ImGuiWindowRefreshFlags>(&NativePtr->RefreshFlagsVal);

		public void ClearFlags()
		{
			ImGuiInternalNative.ImGuiNextWindowData_ClearFlags(NativePtr);
		}
	}
}
