using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiNextItemData
	{
		/// <summary>
		/// Called HasFlags instead of Flags to avoid mistaking this<br/>
		/// </summary>
		public ImGuiNextItemDataFlags HasFlags;
		/// <summary>
		/// Currently only tested/used for ImGuiItemFlags_AllowOverlap and ImGuiItemFlags_HasSelectionUserData.<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		///     Members below are NOT cleared by ItemAdd() meaning they are still valid during e.g. NavProcessItem(). Always rely on HasFlags.<br/>
		/// Set by SetNextItemSelectionUserData()<br/>
		/// </summary>
		public uint FocusScopeId;
		/// <summary>
		/// Set by SetNextItemSelectionUserData() (note that NULL/0 is a valid value, we use -1 == ImGuiSelectionUserData_Invalid to mark invalid values)<br/>
		/// </summary>
		public long SelectionUserData;
		/// <summary>
		/// Set by SetNextItemWidth()<br/>
		/// </summary>
		public float Width;
		/// <summary>
		/// Set by SetNextItemShortcut()<br/>
		/// </summary>
		public int Shortcut;
		/// <summary>
		/// Set by SetNextItemShortcut()<br/>
		/// </summary>
		public ImGuiInputFlags ShortcutFlags;
		/// <summary>
		/// Set by SetNextItemOpen()<br/>
		/// </summary>
		public byte OpenVal;
		/// <summary>
		/// Set by SetNextItemOpen()<br/>
		/// </summary>
		public byte OpenCond;
		/// <summary>
		/// Not exposed yet, for ImGuiInputTextFlags_ParseEmptyAsRefVal<br/>
		/// </summary>
		public ImGuiDataTypeStorage RefVal;
		/// <summary>
		/// Set by SetNextItemStorageID()<br/>
		/// </summary>
		public uint StorageId;
	}

	public unsafe partial struct ImGuiNextItemDataPtr
	{
		public ImGuiNextItemData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiNextItemData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Called HasFlags instead of Flags to avoid mistaking this<br/>
		/// </summary>
		public ref ImGuiNextItemDataFlags HasFlags => ref Unsafe.AsRef<ImGuiNextItemDataFlags>(&NativePtr->HasFlags);
		/// <summary>
		/// Currently only tested/used for ImGuiItemFlags_AllowOverlap and ImGuiItemFlags_HasSelectionUserData.<br/>
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);
		/// <summary>
		///     Members below are NOT cleared by ItemAdd() meaning they are still valid during e.g. NavProcessItem(). Always rely on HasFlags.<br/>
		/// Set by SetNextItemSelectionUserData()<br/>
		/// </summary>
		public ref uint FocusScopeId => ref Unsafe.AsRef<uint>(&NativePtr->FocusScopeId);
		/// <summary>
		/// Set by SetNextItemSelectionUserData() (note that NULL/0 is a valid value, we use -1 == ImGuiSelectionUserData_Invalid to mark invalid values)<br/>
		/// </summary>
		public ref long SelectionUserData => ref Unsafe.AsRef<long>(&NativePtr->SelectionUserData);
		/// <summary>
		/// Set by SetNextItemWidth()<br/>
		/// </summary>
		public ref float Width => ref Unsafe.AsRef<float>(&NativePtr->Width);
		/// <summary>
		/// Set by SetNextItemShortcut()<br/>
		/// </summary>
		public ref int Shortcut => ref Unsafe.AsRef<int>(&NativePtr->Shortcut);
		/// <summary>
		/// Set by SetNextItemShortcut()<br/>
		/// </summary>
		public ref ImGuiInputFlags ShortcutFlags => ref Unsafe.AsRef<ImGuiInputFlags>(&NativePtr->ShortcutFlags);
		/// <summary>
		/// Set by SetNextItemOpen()<br/>
		/// </summary>
		public ref bool OpenVal => ref Unsafe.AsRef<bool>(&NativePtr->OpenVal);
		/// <summary>
		/// Set by SetNextItemOpen()<br/>
		/// </summary>
		public ref bool OpenCond => ref Unsafe.AsRef<bool>(&NativePtr->OpenCond);
		/// <summary>
		/// Not exposed yet, for ImGuiInputTextFlags_ParseEmptyAsRefVal<br/>
		/// </summary>
		public ref ImGuiDataTypeStorage RefVal => ref Unsafe.AsRef<ImGuiDataTypeStorage>(&NativePtr->RefVal);
		/// <summary>
		/// Set by SetNextItemStorageID()<br/>
		/// </summary>
		public ref uint StorageId => ref Unsafe.AsRef<uint>(&NativePtr->StorageId);
		public ImGuiNextItemDataPtr(ImGuiNextItemData* nativePtr) => NativePtr = nativePtr;
		public ImGuiNextItemDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiNextItemData*)nativePtr;
		public static implicit operator ImGuiNextItemDataPtr(ImGuiNextItemData* ptr) => new ImGuiNextItemDataPtr(ptr);
		public static implicit operator ImGuiNextItemDataPtr(IntPtr ptr) => new ImGuiNextItemDataPtr(ptr);
		public static implicit operator ImGuiNextItemData*(ImGuiNextItemDataPtr nativePtr) => nativePtr.NativePtr;
		/// <summary>
		/// Also cleared manually by ItemAdd()!<br/>
		/// </summary>
		public void ClearFlags()
		{
			ImGuiNative.ImGuiNextItemDataClearFlags(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiNextItemDataDestroy(NativePtr);
		}

		public void ImGuiNextItemDataConstruct()
		{
			ImGuiNative.ImGuiNextItemDataImGuiNextItemDataConstruct(NativePtr);
		}

		public ImGuiNextItemDataPtr ImGuiNextItemData()
		{
			return ImGuiNative.ImGuiNextItemDataImGuiNextItemData();
		}

	}
}
