using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Storage data for BeginComboPreview()/EndComboPreview()<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiComboPreviewData
	{
		public ImRect PreviewRect;
		public Vector2 BackupCursorPos;
		public Vector2 BackupCursorMaxPos;
		public Vector2 BackupCursorPosPrevLine;
		public float BackupPrevLineTextBaseOffset;
		public ImGuiLayoutType BackupLayout;
	}

	/// <summary>
	/// Storage data for BeginComboPreview()/EndComboPreview()<br/>
	/// </summary>
	public unsafe partial struct ImGuiComboPreviewDataPtr
	{
		public ImGuiComboPreviewData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiComboPreviewData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref ImRect PreviewRect => ref Unsafe.AsRef<ImRect>(&NativePtr->PreviewRect);
		public ref Vector2 BackupCursorPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorPos);
		public ref Vector2 BackupCursorMaxPos => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorMaxPos);
		public ref Vector2 BackupCursorPosPrevLine => ref Unsafe.AsRef<Vector2>(&NativePtr->BackupCursorPosPrevLine);
		public ref float BackupPrevLineTextBaseOffset => ref Unsafe.AsRef<float>(&NativePtr->BackupPrevLineTextBaseOffset);
		public ref ImGuiLayoutType BackupLayout => ref Unsafe.AsRef<ImGuiLayoutType>(&NativePtr->BackupLayout);
		public ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* nativePtr) => NativePtr = nativePtr;
		public ImGuiComboPreviewDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiComboPreviewData*)nativePtr;
		public static implicit operator ImGuiComboPreviewDataPtr(ImGuiComboPreviewData* ptr) => new ImGuiComboPreviewDataPtr(ptr);
		public static implicit operator ImGuiComboPreviewDataPtr(IntPtr ptr) => new ImGuiComboPreviewDataPtr(ptr);
		public static implicit operator ImGuiComboPreviewData*(ImGuiComboPreviewDataPtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiComboPreviewDataDestroy(NativePtr);
		}

		public void ImGuiComboPreviewDataConstruct()
		{
			ImGuiNative.ImGuiComboPreviewDataImGuiComboPreviewDataConstruct(NativePtr);
		}

		public ImGuiComboPreviewDataPtr ImGuiComboPreviewData()
		{
			return ImGuiNative.ImGuiComboPreviewDataImGuiComboPreviewData();
		}

	}
}
