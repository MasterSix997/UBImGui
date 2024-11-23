using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Helper: ImColor() implicitly converts colors to either ImU32 (packed 4x1 byte) or ImVec4 (4x1 float)</para>
	/// <para>Prefer using IM_COL32() macros if you want a guaranteed compile-time ImU32 for usage with ImDrawList API.</para>
	/// <para>**Avoid storing ImColor! Store either u32 of ImVec4. This is not a full-featured color class. MAY OBSOLETE.</para>
	/// <para>**None of the ImGui API are using ImColor directly but you can use it as a convenience to pass colors in either ImU32 or ImVec4 formats. Explicitly cast to ImU32 or ImVec4 if needed.</para>
	/// </summary>
	public unsafe partial struct ImColor
	{
		public Vector4 Value;
	}

	/// <summary>
	/// <para>Helper: ImColor() implicitly converts colors to either ImU32 (packed 4x1 byte) or ImVec4 (4x1 float)</para>
	/// <para>Prefer using IM_COL32() macros if you want a guaranteed compile-time ImU32 for usage with ImDrawList API.</para>
	/// <para>**Avoid storing ImColor! Store either u32 of ImVec4. This is not a full-featured color class. MAY OBSOLETE.</para>
	/// <para>**None of the ImGui API are using ImColor directly but you can use it as a convenience to pass colors in either ImU32 or ImVec4 formats. Explicitly cast to ImU32 or ImVec4 if needed.</para>
	/// </summary>
	public unsafe partial struct ImColorPtr
	{
		public ImColor* NativePtr { get; }
		public ImColorPtr(ImColor* nativePtr) => NativePtr = nativePtr;
		public ImColorPtr(IntPtr nativePtr) => NativePtr = (ImColor*)nativePtr;
		public static implicit operator ImColorPtr(ImColor* nativePtr) => new ImColorPtr(nativePtr);
		public static implicit operator ImColor* (ImColorPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImColorPtr(IntPtr nativePtr) => new ImColorPtr(nativePtr);

		public ref Vector4 Value => ref Unsafe.AsRef<Vector4>(&NativePtr->Value);

		/// <summary>
		/// <para>FIXME-OBSOLETE: May need to obsolete/cleanup those helpers.</para>
		/// </summary>
		public void SetHSV(float h, float s, float v)
		{
			float a = 1.0f;

			ImGuiNative.ImColor_SetHSV(NativePtr, h, s, v, a);
		}
		/// <summary>
		/// <para>FIXME-OBSOLETE: May need to obsolete/cleanup those helpers.</para>
		/// </summary>
		public void SetHSV(float h, float s, float v, float a)
		{
			ImGuiNative.ImColor_SetHSV(NativePtr, h, s, v, a);
		}

		public ImColor HSV(float h, float s, float v)
		{
			float a = 1.0f;

			var ret = ImGuiNative.ImColor_HSV(h, s, v, a);
			return ret;
		}
		public ImColor HSV(float h, float s, float v, float a)
		{
			var ret = ImGuiNative.ImColor_HSV(h, s, v, a);
			return ret;
		}
	}
}
