using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helpers: ImVec2/ImVec4 operators<br/>- It is important that we are keeping those disabled by default so they don't leak in user space.<br/>- This is in order to allow user enabling implicit cast operators between ImVec2/ImVec4 and their own types (using IM_VEC2_CLASS_EXTRA in imconfig.h)<br/>- Add '#define IMGUI_DEFINE_MATH_OPERATORS' before including this file (or in imconfig.h) to access courtesy maths operators for ImVec2 and ImVec4.<br/>- We intentionally provide ImVec2*float but not float*ImVec2: this is rare enough and we want to reduce the surface for possible user mistake.<br/>Helpers macros to generate 32-bit encoded colors<br/>- User can declare their own format by #defining the 5 _SHIFT/_MASK macros in their imconfig file.<br/>- Any setting other than the default will need custom backend support. The only standard backend that supports anything else than the default is DirectX9.<br/>Helper: ImColor() implicitly converts colors to either ImU32 (packed 4x1 byte) or ImVec4 (4x1 float)<br/>Prefer using IM_COL32() macros if you want a guaranteed compile-time ImU32 for usage with ImDrawList API.<br/>**Avoid storing ImColor! Store either u32 of ImVec4. This is not a full-featured color class. MAY OBSOLETE.<br/>**None of the ImGui API are using ImColor directly but you can use it as a convenience to pass colors in either ImU32 or ImVec4 formats. Explicitly cast to ImU32 or ImVec4 if needed.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImColor
	{
		public Vector4 Value;
	}

	/// <summary>
	/// Helpers: ImVec2/ImVec4 operators<br/>- It is important that we are keeping those disabled by default so they don't leak in user space.<br/>- This is in order to allow user enabling implicit cast operators between ImVec2/ImVec4 and their own types (using IM_VEC2_CLASS_EXTRA in imconfig.h)<br/>- Add '#define IMGUI_DEFINE_MATH_OPERATORS' before including this file (or in imconfig.h) to access courtesy maths operators for ImVec2 and ImVec4.<br/>- We intentionally provide ImVec2*float but not float*ImVec2: this is rare enough and we want to reduce the surface for possible user mistake.<br/>Helpers macros to generate 32-bit encoded colors<br/>- User can declare their own format by #defining the 5 _SHIFT/_MASK macros in their imconfig file.<br/>- Any setting other than the default will need custom backend support. The only standard backend that supports anything else than the default is DirectX9.<br/>Helper: ImColor() implicitly converts colors to either ImU32 (packed 4x1 byte) or ImVec4 (4x1 float)<br/>Prefer using IM_COL32() macros if you want a guaranteed compile-time ImU32 for usage with ImDrawList API.<br/>**Avoid storing ImColor! Store either u32 of ImVec4. This is not a full-featured color class. MAY OBSOLETE.<br/>**None of the ImGui API are using ImColor directly but you can use it as a convenience to pass colors in either ImU32 or ImVec4 formats. Explicitly cast to ImU32 or ImVec4 if needed.<br/>
	/// </summary>
	public unsafe partial struct ImColorPtr
	{
		public ImColor* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImColor this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref Vector4 Value => ref Unsafe.AsRef<Vector4>(&NativePtr->Value);
		public ImColorPtr(ImColor* nativePtr) => NativePtr = nativePtr;
		public ImColorPtr(IntPtr nativePtr) => NativePtr = (ImColor*)nativePtr;
		public static implicit operator ImColorPtr(ImColor* ptr) => new ImColorPtr(ptr);
		public static implicit operator ImColorPtr(IntPtr ptr) => new ImColorPtr(ptr);
		public static implicit operator ImColor*(ImColorPtr nativePtr) => nativePtr.NativePtr;
		public void HSV(ImColorPtr pOut, float h, float s, float v, float a)
		{
			ImGuiNative.ImColorHSV(pOut, h, s, v, a);
		}

		public void HSV(ImColorPtr pOut, float h, float s, float v)
		{
			// defining omitted parameters
			float a = 1.0f;
			ImGuiNative.ImColorHSV(pOut, h, s, v, a);
		}

		public void SetHSV(float h, float s, float v, float a)
		{
			ImGuiNative.ImColorSetHSV(NativePtr, h, s, v, a);
		}

		public void SetHSV(float h, float s, float v)
		{
			// defining omitted parameters
			float a = 1.0f;
			ImGuiNative.ImColorSetHSV(NativePtr, h, s, v, a);
		}

		public void ImColorU32Construct(uint rgba)
		{
			ImGuiNative.ImColorImColorU32Construct(NativePtr, rgba);
		}

		public ImColorPtr ImColorU32(uint rgba)
		{
			return ImGuiNative.ImColorImColorU32(rgba);
		}

		public void ImColorIntConstruct(int r, int g, int b, int a)
		{
			ImGuiNative.ImColorImColorIntConstruct(NativePtr, r, g, b, a);
		}

		public ImColorPtr ImColor(int r, int g, int b, int a)
		{
			return ImGuiNative.ImColorImColor(r, g, b, a);
		}

		public void ImColorVec4Construct(Vector4 col)
		{
			ImGuiNative.ImColorImColorVec4Construct(NativePtr, col);
		}

		public ImColorPtr ImColor(Vector4 col)
		{
			return ImGuiNative.ImColorImColor(col);
		}

		public void ImColorFloatConstruct(float r, float g, float b, float a)
		{
			ImGuiNative.ImColorImColorFloatConstruct(NativePtr, r, g, b, a);
		}

		public ImColorPtr ImColor(float r, float g, float b, float a)
		{
			return ImGuiNative.ImColorImColor(r, g, b, a);
		}

		public void Destroy()
		{
			ImGuiNative.ImColorDestroy(NativePtr);
		}

		public void ImColorNilConstruct()
		{
			ImGuiNative.ImColorImColorNilConstruct(NativePtr);
		}

		public ImColorPtr ImColor()
		{
			return ImGuiNative.ImColorImColor();
		}

	}
}
