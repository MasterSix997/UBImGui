using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Execute a block of code at maximum once a frame. Convenient if you want to quickly create a UI within deep-nested code that runs multiple times every frame.<br/>Usage: static ImGuiOnceUponAFrame oaf; if (oaf) ImGui::Text("This will be called only once per frame");<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiOnceUponAFrame
	{
		public int RefFrame;
	}

	/// <summary>
	/// Helper: Execute a block of code at maximum once a frame. Convenient if you want to quickly create a UI within deep-nested code that runs multiple times every frame.<br/>Usage: static ImGuiOnceUponAFrame oaf; if (oaf) ImGui::Text("This will be called only once per frame");<br/>
	/// </summary>
	public unsafe partial struct ImGuiOnceUponAFramePtr
	{
		public ImGuiOnceUponAFrame* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiOnceUponAFrame this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref int RefFrame => ref Unsafe.AsRef<int>(&NativePtr->RefFrame);
		public ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* nativePtr) => NativePtr = nativePtr;
		public ImGuiOnceUponAFramePtr(IntPtr nativePtr) => NativePtr = (ImGuiOnceUponAFrame*)nativePtr;
		public static implicit operator ImGuiOnceUponAFramePtr(ImGuiOnceUponAFrame* ptr) => new ImGuiOnceUponAFramePtr(ptr);
		public static implicit operator ImGuiOnceUponAFramePtr(IntPtr ptr) => new ImGuiOnceUponAFramePtr(ptr);
		public static implicit operator ImGuiOnceUponAFrame*(ImGuiOnceUponAFramePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiOnceUponAFrameDestroy(NativePtr);
		}

		public void ImGuiOnceUponAFrameConstruct()
		{
			ImGuiNative.ImGuiOnceUponAFrameImGuiOnceUponAFrameConstruct(NativePtr);
		}

		public ImGuiOnceUponAFramePtr ImGuiOnceUponAFrame()
		{
			return ImGuiNative.ImGuiOnceUponAFrameImGuiOnceUponAFrame();
		}

	}
}
