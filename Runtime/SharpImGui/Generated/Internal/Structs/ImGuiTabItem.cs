using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for one active tab item (sizeof() 48 bytes)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTabItem
	{
		public uint ID;
		public ImGuiTabItemFlags Flags;
		/// <summary>
		/// When TabItem is part of a DockNode's TabBar, we hold on to a window.<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		public int LastFrameVisible;
		/// <summary>
		/// This allows us to infer an ordered list of the last activated tabs with little maintenance<br/>
		/// </summary>
		public int LastFrameSelected;
		/// <summary>
		/// Position relative to beginning of tab<br/>
		/// </summary>
		public float Offset;
		/// <summary>
		/// Width currently displayed<br/>
		/// </summary>
		public float Width;
		/// <summary>
		/// Width of label, stored during BeginTabItem() call<br/>
		/// </summary>
		public float ContentWidth;
		/// <summary>
		/// Width optionally requested by caller, -1.0f is unused<br/>
		/// </summary>
		public float RequestedWidth;
		/// <summary>
		/// When Window==NULL, offset to name within parent ImGuiTabBar::TabsNames<br/>
		/// </summary>
		public int NameOffset;
		/// <summary>
		/// BeginTabItem() order, used to re-order tabs after toggling ImGuiTabBarFlags_Reorderable<br/>
		/// </summary>
		public short BeginOrder;
		/// <summary>
		/// Index only used during TabBarLayout(). Tabs gets reordered so 'Tabs[n].IndexDuringLayout == n' but may mismatch during additions.<br/>
		/// </summary>
		public short IndexDuringLayout;
		/// <summary>
		/// Marked as closed by SetTabItemClosed()<br/>
		/// </summary>
		public byte WantClose;
	}

	/// <summary>
	/// Storage for one active tab item (sizeof() 48 bytes)<br/>
	/// </summary>
	public unsafe partial struct ImGuiTabItemPtr
	{
		public ImGuiTabItem* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTabItem this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref ImGuiTabItemFlags Flags => ref Unsafe.AsRef<ImGuiTabItemFlags>(&NativePtr->Flags);
		/// <summary>
		/// When TabItem is part of a DockNode's TabBar, we hold on to a window.<br/>
		/// </summary>
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		public ref int LastFrameVisible => ref Unsafe.AsRef<int>(&NativePtr->LastFrameVisible);
		/// <summary>
		/// This allows us to infer an ordered list of the last activated tabs with little maintenance<br/>
		/// </summary>
		public ref int LastFrameSelected => ref Unsafe.AsRef<int>(&NativePtr->LastFrameSelected);
		/// <summary>
		/// Position relative to beginning of tab<br/>
		/// </summary>
		public ref float Offset => ref Unsafe.AsRef<float>(&NativePtr->Offset);
		/// <summary>
		/// Width currently displayed<br/>
		/// </summary>
		public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
		/// <summary>
		/// Width of label, stored during BeginTabItem() call<br/>
		/// </summary>
		public ref float ContentWidth => ref Unsafe.AsRef<float>(&NativePtr->ContentWidth);
		/// <summary>
		/// Width optionally requested by caller, -1.0f is unused<br/>
		/// </summary>
		public ref float RequestedWidth => ref Unsafe.AsRef<float>(&NativePtr->RequestedWidth);
		/// <summary>
		/// When Window==NULL, offset to name within parent ImGuiTabBar::TabsNames<br/>
		/// </summary>
		public ref int NameOffset => ref Unsafe.AsRef<int>(&NativePtr->NameOffset);
		/// <summary>
		/// BeginTabItem() order, used to re-order tabs after toggling ImGuiTabBarFlags_Reorderable<br/>
		/// </summary>
		public ref short BeginOrder => ref Unsafe.AsRef<short>(&NativePtr->BeginOrder);
		/// <summary>
		/// Index only used during TabBarLayout(). Tabs gets reordered so 'Tabs[n].IndexDuringLayout == n' but may mismatch during additions.<br/>
		/// </summary>
		public ref short IndexDuringLayout => ref Unsafe.AsRef<short>(&NativePtr->IndexDuringLayout);
		/// <summary>
		/// Marked as closed by SetTabItemClosed()<br/>
		/// </summary>
		public ref bool WantClose => ref Unsafe.AsRef<bool>(&NativePtr->WantClose);
		public ImGuiTabItemPtr(ImGuiTabItem* nativePtr) => NativePtr = nativePtr;
		public ImGuiTabItemPtr(IntPtr nativePtr) => NativePtr = (ImGuiTabItem*)nativePtr;
		public static implicit operator ImGuiTabItemPtr(ImGuiTabItem* ptr) => new ImGuiTabItemPtr(ptr);
		public static implicit operator ImGuiTabItemPtr(IntPtr ptr) => new ImGuiTabItemPtr(ptr);
		public static implicit operator ImGuiTabItem*(ImGuiTabItemPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiTabItemDestroy(NativePtr);
		}

		public void ImGuiTabItemConstruct()
		{
			ImGuiNative.ImGuiTabItemImGuiTabItemConstruct(NativePtr);
		}

		public ImGuiTabItemPtr ImGuiTabItem()
		{
			return ImGuiNative.ImGuiTabItemImGuiTabItem();
		}

	}
}
