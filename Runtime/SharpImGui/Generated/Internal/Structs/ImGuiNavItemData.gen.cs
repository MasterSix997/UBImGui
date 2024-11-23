using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Storage for navigation query/results</para>
	/// </summary>
	public unsafe partial struct ImGuiNavItemData
	{
		/// <summary>
		/// Init,Move    // Best candidate window (result-&gt;ItemWindow-&gt;RootWindowForNav == request-&gt;Window)
		/// </summary>
		public ImGuiWindow* Window;
		/// <summary>
		/// Init,Move    // Best candidate item ID
		/// </summary>
		public uint ID;
		/// <summary>
		/// Init,Move    // Best candidate focus scope ID
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// Init,Move    // Best candidate bounding box in window relative space
		/// </summary>
		public ImRect RectRel;
		/// <summary>
		/// ????,Move    // Best candidate item flags
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		///      Move    // Best candidate box distance to current NavId
		/// </summary>
		public float DistBox;
		/// <summary>
		///      Move    // Best candidate center distance to current NavId
		/// </summary>
		public float DistCenter;
		/// <summary>
		///      Move    // Best candidate axial distance to current NavId
		/// </summary>
		public float DistAxial;
		/// <summary>
		/// //I+Mov    // Best candidate SetNextItemSelectionUserData() value. Valid if (ItemFlags &amp; ImGuiItemFlags_HasSelectionUserData)
		/// </summary>
		public long SelectionUserData;
	}

	/// <summary>
	/// <para>Storage for navigation query/results</para>
	/// </summary>
	public unsafe partial struct ImGuiNavItemDataPtr
	{
		public ImGuiNavItemData* NativePtr { get; }
		public ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNavItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNavItemData*)nativePtr;
		public static implicit operator ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => new ImGuiNavItemDataPtr(nativePtr);
		public static implicit operator ImGuiNavItemData* (ImGuiNavItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiNavItemDataPtr(IntPtr nativePtr) => new ImGuiNavItemDataPtr(nativePtr);

		/// <summary>
		/// Init,Move    // Best candidate window (result-&gt;ItemWindow-&gt;RootWindowForNav == request-&gt;Window)
		/// </summary>
		public ImGuiWindowPtr Window => new ImGuiWindowPtr(NativePtr->Window);

		/// <summary>
		/// Init,Move    // Best candidate item ID
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		/// <summary>
		/// Init,Move    // Best candidate focus scope ID
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);

		/// <summary>
		/// Init,Move    // Best candidate bounding box in window relative space
		/// </summary>
		public ref ImRect RectRel => ref Unsafe.AsRef<ImRect>(&NativePtr->RectRel);

		/// <summary>
		/// ????,Move    // Best candidate item flags
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);

		/// <summary>
		///      Move    // Best candidate box distance to current NavId
		/// </summary>
		public ref float DistBox => ref Unsafe.AsRef<float>(&NativePtr->DistBox);

		/// <summary>
		///      Move    // Best candidate center distance to current NavId
		/// </summary>
		public ref float DistCenter => ref Unsafe.AsRef<float>(&NativePtr->DistCenter);

		/// <summary>
		///      Move    // Best candidate axial distance to current NavId
		/// </summary>
		public ref float DistAxial => ref Unsafe.AsRef<float>(&NativePtr->DistAxial);

		/// <summary>
		/// //I+Mov    // Best candidate SetNextItemSelectionUserData() value. Valid if (ItemFlags &amp; ImGuiItemFlags_HasSelectionUserData)
		/// </summary>
		public ref long SelectionUserData => ref Unsafe.AsRef<long>(&NativePtr->SelectionUserData);

		public void Clear()
		{
			ImGuiInternalNative.ImGuiNavItemData_Clear(NativePtr);
		}
	}
}
