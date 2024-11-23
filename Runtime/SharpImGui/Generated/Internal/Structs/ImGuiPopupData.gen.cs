using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Storage for popup stacks (g.OpenPopupStack and g.BeginPopupStack)</para>
	/// </summary>
	public unsafe partial struct ImGuiPopupData
	{
		/// <summary>
		/// Set on OpenPopup()
		/// </summary>
		public uint PopupId;
		/// <summary>
		/// Resolved on BeginPopup() - may stay unresolved if user never calls OpenPopup()
		/// </summary>
		public ImGuiWindow* Window;
		/// <summary>
		/// Set on OpenPopup(), a NavWindow that will be restored on popup close
		/// </summary>
		public ImGuiWindow* RestoreNavWindow;
		/// <summary>
		/// Resolved on BeginPopup(). Actually a ImGuiNavLayer type (declared down below), initialized to -1 which is not part of an enum, but serves well-enough as "not any of layers" value
		/// </summary>
		public int ParentNavLayer;
		/// <summary>
		/// Set on OpenPopup()
		/// </summary>
		public int OpenFrameCount;
		/// <summary>
		/// Set on OpenPopup(), we need this to differentiate multiple menu sets from each others (e.g. inside menu bar vs loose menu items)
		/// </summary>
		public uint OpenParentId;
		/// <summary>
		/// Set on OpenPopup(), preferred popup position (typically == OpenMousePos when using mouse)
		/// </summary>
		public Vector2 OpenPopupPos;
		/// <summary>
		/// Set on OpenPopup(), copy of mouse position at the time of opening popup
		/// </summary>
		public Vector2 OpenMousePos;
	}

	/// <summary>
	/// <para>Storage for popup stacks (g.OpenPopupStack and g.BeginPopupStack)</para>
	/// </summary>
	public unsafe partial struct ImGuiPopupDataPtr
	{
		public ImGuiPopupData* NativePtr { get; }
		public ImGuiPopupDataPtr(ImGuiPopupData* nativePtr) => NativePtr = nativePtr;
		public ImGuiPopupDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiPopupData*)nativePtr;
		public static implicit operator ImGuiPopupDataPtr(ImGuiPopupData* nativePtr) => new ImGuiPopupDataPtr(nativePtr);
		public static implicit operator ImGuiPopupData* (ImGuiPopupDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiPopupDataPtr(IntPtr nativePtr) => new ImGuiPopupDataPtr(nativePtr);

		/// <summary>
		/// Set on OpenPopup()
		/// </summary>
		public ref uint PopupId => ref Unsafe.AsRef<uint>(&NativePtr->PopupId);

		/// <summary>
		/// Resolved on BeginPopup() - may stay unresolved if user never calls OpenPopup()
		/// </summary>
		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		/// <summary>
		/// Set on OpenPopup(), a NavWindow that will be restored on popup close
		/// </summary>
		public ImGuiWindowPtr RestoreNavWindow => new ImGuiWindowPtr(NativePtr->RestoreNavWindow);

		/// <summary>
		/// Resolved on BeginPopup(). Actually a ImGuiNavLayer type (declared down below), initialized to -1 which is not part of an enum, but serves well-enough as "not any of layers" value
		/// </summary>
		public ref int ParentNavLayer => ref Unsafe.AsRef<int>(&NativePtr->ParentNavLayer);

		/// <summary>
		/// Set on OpenPopup()
		/// </summary>
		public ref int OpenFrameCount => ref Unsafe.AsRef<int>(&NativePtr->OpenFrameCount);

		/// <summary>
		/// Set on OpenPopup(), we need this to differentiate multiple menu sets from each others (e.g. inside menu bar vs loose menu items)
		/// </summary>
		public ref uint OpenParentId => ref Unsafe.AsRef<uint>(&NativePtr->OpenParentId);

		/// <summary>
		/// Set on OpenPopup(), preferred popup position (typically == OpenMousePos when using mouse)
		/// </summary>
		public ref Vector2 OpenPopupPos => ref Unsafe.AsRef<Vector2>(&NativePtr->OpenPopupPos);

		/// <summary>
		/// Set on OpenPopup(), copy of mouse position at the time of opening popup
		/// </summary>
		public ref Vector2 OpenMousePos => ref Unsafe.AsRef<Vector2>(&NativePtr->OpenMousePos);
	}
}
