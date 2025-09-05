using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage for navigation query/results<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNavItemData
	{
		/// <summary>
		/// Init,Move    Best candidate window (result-&gt;ItemWindow-&gt;RootWindowForNav == request-&gt;Window)<br/>
		/// </summary>
		public unsafe ImGuiWindow* Window;
		/// <summary>
		/// Init,Move    Best candidate item ID<br/>
		/// </summary>
		public uint ID;
		/// <summary>
		/// Init,Move    Best candidate focus scope ID<br/>
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// Init,Move    Best candidate bounding box in window relative space<br/>
		/// </summary>
		public ImRect RectRel;
		/// <summary>
		/// ????,Move    Best candidate item flags<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		///      Move    Best candidate box distance to current NavId<br/>
		/// </summary>
		public float DistBox;
		/// <summary>
		///      Move    Best candidate center distance to current NavId<br/>
		/// </summary>
		public float DistCenter;
		/// <summary>
		///      Move    Best candidate axial distance to current NavId<br/>
		/// </summary>
		public float DistAxial;
		/// <summary>
		/// //I+Mov    Best candidate SetNextItemSelectionUserData() value. Valid if (ItemFlags & ImGuiItemFlags_HasSelectionUserData)<br/>
		/// </summary>
		public long SelectionUserData;
	}

	/// <summary>
	/// Storage for navigation query/results<br/>
	/// </summary>
	public unsafe partial struct ImGuiNavItemDataPtr
	{
		public ImGuiNavItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiNavItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Init,Move    Best candidate window (result-&gt;ItemWindow-&gt;RootWindowForNav == request-&gt;Window)<br/>
		/// </summary>
		public ref ImGuiWindowPtr Window => ref Unsafe.AsRef<ImGuiWindowPtr>(&NativePtr->Window);
		/// <summary>
		/// Init,Move    Best candidate item ID<br/>
		/// </summary>
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		/// <summary>
		/// Init,Move    Best candidate focus scope ID<br/>
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
		/// <summary>
		/// Init,Move    Best candidate bounding box in window relative space<br/>
		/// </summary>
		public ref ImRect RectRel => ref Unsafe.AsRef<ImRect>(&NativePtr->RectRel);
		/// <summary>
		/// ????,Move    Best candidate item flags<br/>
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);
		/// <summary>
		///      Move    Best candidate box distance to current NavId<br/>
		/// </summary>
		public ref float DistBox => ref Unsafe.AsRef<float>(&NativePtr->DistBox);
		/// <summary>
		///      Move    Best candidate center distance to current NavId<br/>
		/// </summary>
		public ref float DistCenter => ref Unsafe.AsRef<float>(&NativePtr->DistCenter);
		/// <summary>
		///      Move    Best candidate axial distance to current NavId<br/>
		/// </summary>
		public ref float DistAxial => ref Unsafe.AsRef<float>(&NativePtr->DistAxial);
		/// <summary>
		/// //I+Mov    Best candidate SetNextItemSelectionUserData() value. Valid if (ItemFlags & ImGuiItemFlags_HasSelectionUserData)<br/>
		/// </summary>
		public ref long SelectionUserData => ref Unsafe.AsRef<long>(&NativePtr->SelectionUserData);
		public ImGuiNavItemDataPtr(ImGuiNavItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNavItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNavItemData*)nativePtr;
		public static implicit operator ImGuiNavItemDataPtr(ImGuiNavItemData* ptr) => new ImGuiNavItemDataPtr(ptr);
		public static implicit operator ImGuiNavItemDataPtr(IntPtr ptr) => new ImGuiNavItemDataPtr(ptr);
		public static implicit operator ImGuiNavItemData*(ImGuiNavItemDataPtr nativePtr) => nativePtr.NativePtr;
		public void Clear()
		{
			ImGuiNative.ImGuiNavItemDataClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiNavItemDataDestroy(NativePtr);
		}

		public void ImGuiNavItemDataConstruct()
		{
			ImGuiNative.ImGuiNavItemDataImGuiNavItemDataConstruct(NativePtr);
		}

		public ImGuiNavItemDataPtr ImGuiNavItemData()
		{
			return ImGuiNative.ImGuiNavItemDataImGuiNavItemData();
		}

	}
}
