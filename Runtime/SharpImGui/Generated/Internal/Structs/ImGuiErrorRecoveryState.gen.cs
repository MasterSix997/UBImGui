using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>sizeof() = 20</para>
	/// </summary>
	public unsafe partial struct ImGuiErrorRecoveryState
	{
		public short SizeOfWindowStack;
		public short SizeOfIDStack;
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
	/// <para>sizeof() = 20</para>
	/// </summary>
	public unsafe partial struct ImGuiErrorRecoveryStatePtr
	{
		public ImGuiErrorRecoveryState* NativePtr { get; }
		public ImGuiErrorRecoveryStatePtr(ImGuiErrorRecoveryState* nativePtr) => NativePtr = nativePtr;
		public ImGuiErrorRecoveryStatePtr(IntPtr nativePtr) => NativePtr = (ImGuiErrorRecoveryState*)nativePtr;
		public static implicit operator ImGuiErrorRecoveryStatePtr(ImGuiErrorRecoveryState* nativePtr) => new ImGuiErrorRecoveryStatePtr(nativePtr);
		public static implicit operator ImGuiErrorRecoveryState* (ImGuiErrorRecoveryStatePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiErrorRecoveryStatePtr(IntPtr nativePtr) => new ImGuiErrorRecoveryStatePtr(nativePtr);

		public ref short SizeOfWindowStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfWindowStack);

		public ref short SizeOfIDStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfIDStack);

		public ref short SizeOfTreeStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfTreeStack);

		public ref short SizeOfColorStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfColorStack);

		public ref short SizeOfStyleVarStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfStyleVarStack);

		public ref short SizeOfFontStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfFontStack);

		public ref short SizeOfFocusScopeStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfFocusScopeStack);

		public ref short SizeOfGroupStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfGroupStack);

		public ref short SizeOfItemFlagsStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfItemFlagsStack);

		public ref short SizeOfBeginPopupStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfBeginPopupStack);

		public ref short SizeOfDisabledStack => ref Unsafe.AsRef<short>(&NativePtr->SizeOfDisabledStack);
	}
}
