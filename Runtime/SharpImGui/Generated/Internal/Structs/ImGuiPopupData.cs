using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for popup stacks (g.OpenPopupStack and g.BeginPopupStack)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiPopupData
	{
		/// <summary>
		/// Set on OpenPopup()<br/>
		/// </summary>
		public uint PopupId;
		/// <summary>
		/// Resolved on BeginPopup() - may stay unresolved if user never calls OpenPopup()<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		/// <summary>
		/// Set on OpenPopup(), a NavWindow that will be restored on popup close<br/>
		/// </summary>
		public unsafe ImGuiWindow* RestoreNavWindow;
		/// <summary>
		/// Resolved on BeginPopup(). Actually a ImGuiNavLayer type (declared down below), initialized to -1 which is not part of an enum, but serves well-enough as "not any of layers" value<br/>
		/// </summary>
		public int ParentNavLayer;
		/// <summary>
		/// Set on OpenPopup()<br/>
		/// </summary>
		public int OpenFrameCount;
		/// <summary>
		/// Set on OpenPopup(), we need this to differentiate multiple menu sets from each others (e.g. inside menu bar vs loose menu items)<br/>
		/// </summary>
		public uint OpenParentId;
		/// <summary>
		/// Set on OpenPopup(), preferred popup position (typically == OpenMousePos when using mouse)<br/>
		/// </summary>
		public Vector2 OpenPopupPos;
		/// <summary>
		/// Set on OpenPopup(), copy of mouse position at the time of opening popup<br/>
		/// </summary>
		public Vector2 OpenMousePos;
	}

	/// <summary>
	/// Storage for popup stacks (g.OpenPopupStack and g.BeginPopupStack)<br/>
	/// </summary>
	public unsafe partial struct ImGuiPopupDataPtr
	{
		public ImGuiPopupData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiPopupData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Set on OpenPopup()<br/>
		/// </summary>
		public ref uint PopupId => ref Unsafe.AsRef<uint>(&NativePtr->PopupId);
		/// <summary>
		/// Resolved on BeginPopup() - may stay unresolved if user never calls OpenPopup()<br/>
		/// </summary>
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		/// <summary>
		/// Set on OpenPopup(), a NavWindow that will be restored on popup close<br/>
		/// </summary>
		public ref ImGuiWindowPtr RestoreNavWindow => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->RestoreNavWindow);
		/// <summary>
		/// Resolved on BeginPopup(). Actually a ImGuiNavLayer type (declared down below), initialized to -1 which is not part of an enum, but serves well-enough as "not any of layers" value<br/>
		/// </summary>
		public ref int ParentNavLayer => ref Unsafe.AsRef<int>(&NativePtr->ParentNavLayer);
		/// <summary>
		/// Set on OpenPopup()<br/>
		/// </summary>
		public ref int OpenFrameCount => ref Unsafe.AsRef<int>(&NativePtr->OpenFrameCount);
		/// <summary>
		/// Set on OpenPopup(), we need this to differentiate multiple menu sets from each others (e.g. inside menu bar vs loose menu items)<br/>
		/// </summary>
		public ref uint OpenParentId => ref Unsafe.AsRef<uint>(&NativePtr->OpenParentId);
		/// <summary>
		/// Set on OpenPopup(), preferred popup position (typically == OpenMousePos when using mouse)<br/>
		/// </summary>
		public ref Vector2 OpenPopupPos => ref Unsafe.AsRef<Vector2>(&NativePtr->OpenPopupPos);
		/// <summary>
		/// Set on OpenPopup(), copy of mouse position at the time of opening popup<br/>
		/// </summary>
		public ref Vector2 OpenMousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->OpenMousePos);
		public ImGuiPopupDataPtr(ImGuiPopupData* nativePtr) => NativePtr = nativePtr;
		public ImGuiPopupDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPopupData*)nativePtr;
		public static implicit operator ImGuiPopupDataPtr(ImGuiPopupData* ptr) => new ImGuiPopupDataPtr(ptr);
		public static implicit operator ImGuiPopupDataPtr(IntPtr ptr) => new ImGuiPopupDataPtr(ptr);
		public static implicit operator ImGuiPopupData*(ImGuiPopupDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiPopupDataDestroy(NativePtr);
		}

		public void ImGuiPopupDataConstruct()
		{
			ImGuiNative.ImGuiPopupDataImGuiPopupDataConstruct(NativePtr);
		}

		public ImGuiPopupDataPtr ImGuiPopupData()
		{
			return ImGuiNative.ImGuiPopupDataImGuiPopupData();
		}

	}
}
