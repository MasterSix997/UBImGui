using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	public unsafe partial struct ImGuiNextItemData
	{
		/// <summary>
		/// Called HasFlags instead of Flags to avoid mistaking this
		/// </summary>
		public ImGuiNextItemDataFlags HasFlags;
		/// <summary>
		/// Currently only tested/used for ImGuiItemFlags_AllowOverlap and ImGuiItemFlags_HasSelectionUserData.
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// <para>Non-flags members are NOT cleared by ItemAdd() meaning they are still valid during NavProcessItem()</para>
		/// </summary>
		/// <summary>
		/// Set by SetNextItemSelectionUserData()
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// Set by SetNextItemSelectionUserData() (note that NULL/0 is a valid value, we use -1 == ImGuiSelectionUserData_Invalid to mark invalid values)
		/// </summary>
		public long SelectionUserData;
		/// <summary>
		/// Set by SetNextItemWidth()
		/// </summary>
		public float Width;
		/// <summary>
		/// Set by SetNextItemShortcut()
		/// </summary>
		public ImGuiKey Shortcut;
		/// <summary>
		/// Set by SetNextItemShortcut()
		/// </summary>
		public ImGuiInputFlags ShortcutFlags;
		/// <summary>
		/// Set by SetNextItemOpen()
		/// </summary>
		public byte OpenVal;
		/// <summary>
		/// Set by SetNextItemOpen()
		/// </summary>
		public byte OpenCond;
		/// <summary>
		/// Not exposed yet, for ImGuiInputTextFlags_ParseEmptyAsRefVal
		/// </summary>
		public ImGuiDataTypeStorage RefVal;
		/// <summary>
		/// Set by SetNextItemStorageID()
		/// </summary>
		public uint StorageId;
	}

	public unsafe partial struct ImGuiNextItemDataPtr
	{
		public ImGuiNextItemData* NativePtr { get; }
		public ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextItemData*)nativePtr;
		public static implicit operator ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => new ImGuiNextItemDataPtr(nativePtr);
		public static implicit operator ImGuiNextItemData* (ImGuiNextItemDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiNextItemDataPtr(IntPtr nativePtr) => new ImGuiNextItemDataPtr(nativePtr);

		/// <summary>
		/// Called HasFlags instead of Flags to avoid mistaking this
		/// </summary>
		public ref ImGuiNextItemDataFlags HasFlags => ref Unsafe.AsRef<ImGuiNextItemDataFlags>(&NativePtr->HasFlags);

		/// <summary>
		/// Currently only tested/used for ImGuiItemFlags_AllowOverlap and ImGuiItemFlags_HasSelectionUserData.
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);

		/// <summary>
		/// <para>Non-flags members are NOT cleared by ItemAdd() meaning they are still valid during NavProcessItem()</para>
		/// </summary>
		/// <summary>
		/// Set by SetNextItemSelectionUserData()
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);

		/// <summary>
		/// Set by SetNextItemSelectionUserData() (note that NULL/0 is a valid value, we use -1 == ImGuiSelectionUserData_Invalid to mark invalid values)
		/// </summary>
		public ref long SelectionUserData => ref Unsafe.AsRef<long>(&NativePtr->SelectionUserData);

		/// <summary>
		/// Set by SetNextItemWidth()
		/// </summary>
		public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);

		/// <summary>
		/// Set by SetNextItemShortcut()
		/// </summary>
		public ref ImGuiKey Shortcut => ref Unsafe.AsRef<ImGuiKey>(&NativePtr->Shortcut);

		/// <summary>
		/// Set by SetNextItemShortcut()
		/// </summary>
		public ref ImGuiInputFlags ShortcutFlags => ref Unsafe.AsRef<ImGuiInputFlags>(&NativePtr->ShortcutFlags);

		/// <summary>
		/// Set by SetNextItemOpen()
		/// </summary>
		public ref bool OpenVal => ref Unsafe.AsRef<bool>(&NativePtr->OpenVal);

		/// <summary>
		/// Set by SetNextItemOpen()
		/// </summary>
		public ref bool OpenCond => ref Unsafe.AsRef<bool>(&NativePtr->OpenCond);

		/// <summary>
		/// Not exposed yet, for ImGuiInputTextFlags_ParseEmptyAsRefVal
		/// </summary>
		public ref ImGuiDataTypeStorage RefVal => ref Unsafe.AsRef<ImGuiDataTypeStorage>(&NativePtr->RefVal);

		/// <summary>
		/// Set by SetNextItemStorageID()
		/// </summary>
		public ref uint StorageId => ref Unsafe.AsRef<uint>(&NativePtr->StorageId);

		/// <summary>
		/// Also cleared manually by ItemAdd()!
		/// </summary>
		public void ClearFlags()
		{
			ImGuiInternalNative.ImGuiNextItemData_ClearFlags(NativePtr);
		}
	}
}
