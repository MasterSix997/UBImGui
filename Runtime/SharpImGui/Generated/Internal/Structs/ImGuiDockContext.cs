using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiDockContext
	{
		/// <summary>
		/// Map ID -&gt; ImGuiDockNode*: Active nodes<br/>
		/// </summary>
		public ImGuiStorage Nodes;
		public ImVector<EmptyStruct> Requests;
		public ImVector<EmptyStruct> NodesSettings;
		public byte WantFullRebuild;
	}

	public unsafe partial struct ImGuiDockContextPtr
	{
		public ImGuiDockContext* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiDockContext this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Map ID -&gt; ImGuiDockNode*: Active nodes<br/>
		/// </summary>
		public ref ImGuiStorage Nodes => ref Unsafe.AsRef<ImGuiStorage>(&NativePtr->Nodes);
		public ref ImVector<EmptyStruct> Requests => ref Unsafe.AsRef<ImVector<EmptyStruct>>(&NativePtr->Requests);
		public ref ImVector<EmptyStruct> NodesSettings => ref Unsafe.AsRef<ImVector<EmptyStruct>>(&NativePtr->NodesSettings);
		public ref bool WantFullRebuild => ref Unsafe.AsRef<bool>(&NativePtr->WantFullRebuild);
		public ImGuiDockContextPtr(ImGuiDockContext* nativePtr) => NativePtr = nativePtr;
		public ImGuiDockContextPtr(IntPtr nativePtr) => NativePtr = (ImGuiDockContext*)nativePtr;
		public static implicit operator ImGuiDockContextPtr(ImGuiDockContext* ptr) => new ImGuiDockContextPtr(ptr);
		public static implicit operator ImGuiDockContextPtr(IntPtr ptr) => new ImGuiDockContextPtr(ptr);
		public static implicit operator ImGuiDockContext*(ImGuiDockContextPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiDockContextDestroy(NativePtr);
		}

		public void ImGuiDockContextConstruct()
		{
			ImGuiNative.ImGuiDockContextImGuiDockContextConstruct(NativePtr);
		}

		public ImGuiDockContextPtr ImGuiDockContext()
		{
			return ImGuiNative.ImGuiDockContextImGuiDockContext();
		}

	}
}
