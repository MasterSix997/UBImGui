using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for SetNexWindow** functions<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextWindowData
	{
		public ImGuiNextWindowDataFlags HasFlags;
		/// <summary>
		///     Members below are NOT cleared. Always rely on HasFlags.<br/>
		/// </summary>
		public ImGuiCond PosCond;
		public ImGuiCond SizeCond;
		public ImGuiCond CollapsedCond;
		public ImGuiCond DockCond;
		public Vector2 PosVal;
		public Vector2 PosPivotVal;
		public Vector2 SizeVal;
		public Vector2 ContentSizeVal;
		public Vector2 ScrollVal;
		/// <summary>
		/// Only honored by BeginTable()<br/>
		/// </summary>
		public ImGuiWindowFlags WindowFlags;
		public ImGuiChildFlags ChildFlags;
		public byte PosUndock;
		public byte CollapsedVal;
		public ImRect SizeConstraintRect;
		public unsafe void* SizeCallback;
		public unsafe void* SizeCallbackUserData;
		/// <summary>
		/// Override background alpha<br/>
		/// </summary>
		public float BgAlphaVal;
		public uint ViewportId;
		public uint DockId;
		public ImGuiWindowClass WindowClass;
		/// <summary>
		/// (Always on) This is not exposed publicly, so we don't clear it and it doesn't have a corresponding flag (could we? for consistency?)<br/>
		/// </summary>
		public Vector2 MenuBarOffsetMinVal;
		public ImGuiWindowRefreshFlags RefreshFlagsVal;
	}

	/// <summary>
	/// Storage for SetNexWindow** functions<br/>
	/// </summary>
	public unsafe partial struct ImGuiNextWindowDataPtr
	{
		public ImGuiNextWindowData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiNextWindowData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImGuiNextWindowDataFlags HasFlags => ref Unsafe.AsRef<ImGuiNextWindowDataFlags>(&NativePtr->HasFlags);
		/// <summary>
		///     Members below are NOT cleared. Always rely on HasFlags.<br/>
		/// </summary>
		public ref ImGuiCond PosCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->PosCond);
		public ref ImGuiCond SizeCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->SizeCond);
		public ref ImGuiCond CollapsedCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->CollapsedCond);
		public ref ImGuiCond DockCond => ref Unsafe.AsRef<ImGuiCond>(&NativePtr->DockCond);
		public ref Vector2 PosVal => ref Unsafe.AsRef<Vector2>(&NativePtr->PosVal);
		public ref Vector2 PosPivotVal => ref Unsafe.AsRef<Vector2>(&NativePtr->PosPivotVal);
		public ref Vector2 SizeVal => ref Unsafe.AsRef<Vector2>(&NativePtr->SizeVal);
		public ref Vector2 ContentSizeVal => ref Unsafe.AsRef<Vector2>(&NativePtr->ContentSizeVal);
		public ref Vector2 ScrollVal => ref Unsafe.AsRef<Vector2>(&NativePtr->ScrollVal);
		/// <summary>
		/// Only honored by BeginTable()<br/>
		/// </summary>
		public ref ImGuiWindowFlags WindowFlags => ref Unsafe.AsRef<ImGuiWindowFlags>(&NativePtr->WindowFlags);
		public ref ImGuiChildFlags ChildFlags => ref Unsafe.AsRef<ImGuiChildFlags>(&NativePtr->ChildFlags);
		public ref bool PosUndock => ref Unsafe.AsRef<bool>(&NativePtr->PosUndock);
		public ref bool CollapsedVal => ref Unsafe.AsRef<bool>(&NativePtr->CollapsedVal);
		public ref ImRect SizeConstraintRect => ref Unsafe.AsRef<ImRect>(&NativePtr->SizeConstraintRect);
		public IntPtr SizeCallback { get => (IntPtr)NativePtr->SizeCallback; set => NativePtr->SizeCallback = (void*)value; }
		public IntPtr SizeCallbackUserData { get => (IntPtr)NativePtr->SizeCallbackUserData; set => NativePtr->SizeCallbackUserData = (void*)value; }
		/// <summary>
		/// Override background alpha<br/>
		/// </summary>
		public ref float BgAlphaVal => ref Unsafe.AsRef<float>(&NativePtr->BgAlphaVal);
		public ref uint ViewportId => ref Unsafe.AsRef<uint>(&NativePtr->ViewportId);
		public ref uint DockId => ref Unsafe.AsRef<uint>(&NativePtr->DockId);
		public ref ImGuiWindowClass WindowClass => ref Unsafe.AsRef<ImGuiWindowClass>(&NativePtr->WindowClass);
		/// <summary>
		/// (Always on) This is not exposed publicly, so we don't clear it and it doesn't have a corresponding flag (could we? for consistency?)<br/>
		/// </summary>
		public ref Vector2 MenuBarOffsetMinVal => ref Unsafe.AsRef<Vector2>(&NativePtr->MenuBarOffsetMinVal);
		public ref ImGuiWindowRefreshFlags RefreshFlagsVal => ref Unsafe.AsRef<ImGuiWindowRefreshFlags>(&NativePtr->RefreshFlagsVal);
		public ImGuiNextWindowDataPtr(ImGuiNextWindowData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNextWindowDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextWindowData*)nativePtr;
		public static implicit operator ImGuiNextWindowDataPtr(ImGuiNextWindowData* ptr) => new ImGuiNextWindowDataPtr(ptr);
		public static implicit operator ImGuiNextWindowDataPtr(IntPtr ptr) => new ImGuiNextWindowDataPtr(ptr);
		public static implicit operator ImGuiNextWindowData*(ImGuiNextWindowDataPtr nativePtr) => nativePtr.NativePtr;
		public void ClearFlags()
		{
			ImGuiNative.ImGuiNextWindowDataClearFlags(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiNextWindowDataDestroy(NativePtr);
		}

		public void ImGuiNextWindowDataConstruct()
		{
			ImGuiNative.ImGuiNextWindowDataImGuiNextWindowDataConstruct(NativePtr);
		}

		public ImGuiNextWindowDataPtr ImGuiNextWindowData()
		{
			return ImGuiNative.ImGuiNextWindowDataImGuiNextWindowData();
		}

	}
}
