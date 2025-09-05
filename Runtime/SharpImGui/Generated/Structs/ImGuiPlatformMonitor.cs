using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// (Optional) This is required when enabling multi-viewport. Represent the bounds of each connected monitor/display and their DPI.<br/>We use this information for multiple DPI support + clamping the position of popups and tooltips so they don't straddle multiple monitors.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPlatformMonitor
	{
		/// <summary>
		/// Coordinates of the area displayed on this monitor (Min = upper left, Max = bottom right)<br/>
		/// </summary>
		public Vector2 MainPos;
		/// <summary>
		/// Coordinates of the area displayed on this monitor (Min = upper left, Max = bottom right)<br/>
		/// </summary>
		public Vector2 MainSize;
		/// <summary>
		/// Coordinates without task bars / side bars / menu bars. Used to avoid positioning popups/tooltips inside this region. If you don't have this info, please copy the value for MainPos/MainSize.<br/>
		/// </summary>
		public Vector2 WorkPos;
		/// <summary>
		/// Coordinates without task bars / side bars / menu bars. Used to avoid positioning popups/tooltips inside this region. If you don't have this info, please copy the value for MainPos/MainSize.<br/>
		/// </summary>
		public Vector2 WorkSize;
		/// <summary>
		/// 1.0f = 96 DPI<br/>
		/// </summary>
		public float DpiScale;
		/// <summary>
		/// Backend dependant data (e.g. HMONITOR, GLFWmonitor*, SDL Display Index, NSScreen*)<br/>
		/// </summary>
		public unsafe void* PlatformHandle;
	}

	/// <summary>
	/// (Optional) This is required when enabling multi-viewport. Represent the bounds of each connected monitor/display and their DPI.<br/>We use this information for multiple DPI support + clamping the position of popups and tooltips so they don't straddle multiple monitors.<br/>
	/// </summary>
	public unsafe partial struct ImGuiPlatformMonitorPtr
	{
		public ImGuiPlatformMonitor* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPlatformMonitor this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Coordinates of the area displayed on this monitor (Min = upper left, Max = bottom right)<br/>
		/// </summary>
		public ref Vector2 MainPos => ref Unsafe.AsRef<Vector2>(&NativePtr->MainPos);
		/// <summary>
		/// Coordinates of the area displayed on this monitor (Min = upper left, Max = bottom right)<br/>
		/// </summary>
		public ref Vector2 MainSize => ref Unsafe.AsRef<Vector2>(&NativePtr->MainSize);
		/// <summary>
		/// Coordinates without task bars / side bars / menu bars. Used to avoid positioning popups/tooltips inside this region. If you don't have this info, please copy the value for MainPos/MainSize.<br/>
		/// </summary>
		public ref Vector2 WorkPos => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkPos);
		/// <summary>
		/// Coordinates without task bars / side bars / menu bars. Used to avoid positioning popups/tooltips inside this region. If you don't have this info, please copy the value for MainPos/MainSize.<br/>
		/// </summary>
		public ref Vector2 WorkSize => ref Unsafe.AsRef<Vector2>(&NativePtr->WorkSize);
		/// <summary>
		/// 1.0f = 96 DPI<br/>
		/// </summary>
		public ref float DpiScale => ref Unsafe.AsRef<float>(&NativePtr->DpiScale);
		/// <summary>
		/// Backend dependant data (e.g. HMONITOR, GLFWmonitor*, SDL Display Index, NSScreen*)<br/>
		/// </summary>
		public IntPtr PlatformHandle { get => (IntPtr)NativePtr->PlatformHandle; set => NativePtr->PlatformHandle = (void*)value; }
		public ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* nativePtr) => NativePtr = nativePtr;
		public ImGuiPlatformMonitorPtr(IntPtr nativePtr) => NativePtr = (ImGuiPlatformMonitor*)nativePtr;
		public static implicit operator ImGuiPlatformMonitorPtr(ImGuiPlatformMonitor* ptr) => new ImGuiPlatformMonitorPtr(ptr);
		public static implicit operator ImGuiPlatformMonitorPtr(IntPtr ptr) => new ImGuiPlatformMonitorPtr(ptr);
		public static implicit operator ImGuiPlatformMonitor*(ImGuiPlatformMonitorPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiPlatformMonitorDestroy(NativePtr);
		}

		public void ImGuiPlatformMonitorConstruct()
		{
			ImGuiNative.ImGuiPlatformMonitorImGuiPlatformMonitorConstruct(NativePtr);
		}

		public ImGuiPlatformMonitorPtr ImGuiPlatformMonitor()
		{
			return ImGuiNative.ImGuiPlatformMonitorImGuiPlatformMonitor();
		}

	}
}
