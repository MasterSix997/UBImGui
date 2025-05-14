using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// sizeof() = 20<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiErrorRecoveryState
	{
		public short SizeOfWindowStack;
		public short SizeOfIdStack;
		public short SizeOfTreeStack;
		public short SizeOfColorStack;
		public short SizeOfStyleVarStack;
		public short SizeOfFontStack;
		public short SizeOfFocusScopeStack;
		public short SizeOfGroupStack;
		public short SizeOfItemFlagsStack;
		public short SizeOfBeginPopupStack;
		public short SizeOfDisabledStack;
	}

	/// <summary>
	/// sizeof() = 20<br/>
	/// </summary>
	public unsafe partial struct ImGuiErrorRecoveryStatePtr
	{
		public ImGuiErrorRecoveryState* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiErrorRecoveryState this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref short SizeOfWindowStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfWindowStack);
		public ref short SizeOfIdStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfIdStack);
		public ref short SizeOfTreeStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfTreeStack);
		public ref short SizeOfColorStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfColorStack);
		public ref short SizeOfStyleVarStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfStyleVarStack);
		public ref short SizeOfFontStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfFontStack);
		public ref short SizeOfFocusScopeStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfFocusScopeStack);
		public ref short SizeOfGroupStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfGroupStack);
		public ref short SizeOfItemFlagsStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfItemFlagsStack);
		public ref short SizeOfBeginPopupStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfBeginPopupStack);
		public ref short SizeOfDisabledStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfDisabledStack);
		public ImGuiErrorRecoveryStatePtr(ImGuiErrorRecoveryState* nativePtr) => NativePtr = nativePtr;
		public ImGuiErrorRecoveryStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiErrorRecoveryState*)nativePtr;
		public static implicit operator ImGuiErrorRecoveryStatePtr(ImGuiErrorRecoveryState* ptr) => new ImGuiErrorRecoveryStatePtr(ptr);
		public static implicit operator ImGuiErrorRecoveryStatePtr(IntPtr ptr) => new ImGuiErrorRecoveryStatePtr(ptr);
		public static implicit operator ImGuiErrorRecoveryState*(ImGuiErrorRecoveryStatePtr nativePtr) => nativePtr.NativePtr;
		public void Destroy()
		{
			ImGuiNative.ImGuiErrorRecoveryStateDestroy(NativePtr);
		}

		public void ImGuiErrorRecoveryStateConstruct()
		{
			ImGuiNative.ImGuiErrorRecoveryStateImGuiErrorRecoveryStateConstruct(NativePtr);
		}

		public ImGuiErrorRecoveryStatePtr ImGuiErrorRecoveryState()
		{
			return ImGuiNative.ImGuiErrorRecoveryStateImGuiErrorRecoveryState();
		}

	}
}
