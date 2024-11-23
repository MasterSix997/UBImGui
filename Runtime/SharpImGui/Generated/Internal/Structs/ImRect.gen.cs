using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Helper: ImRect (2D axis aligned bounding-box)</para>
	/// <para>NB: we can't rely on ImVec2 math operators being available here!</para>
	/// </summary>
	public unsafe partial struct ImRect
	{
		/// <summary>
		/// Upper-left
		/// </summary>
		public Vector2 Min;
		/// <summary>
		/// Lower-right
		/// </summary>
		public Vector2 Max;
	}

	/// <summary>
	/// <para>Helper: ImRect (2D axis aligned bounding-box)</para>
	/// <para>NB: we can't rely on ImVec2 math operators being available here!</para>
	/// </summary>
	public unsafe partial struct ImRectPtr
	{
		public ImRect* NativePtr { get; }
		public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
		public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
		public static implicit operator ImRectPtr(ImRect* nativePtr) => new ImRectPtr(nativePtr);
		public static implicit operator ImRect* (ImRectPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImRectPtr(IntPtr nativePtr) => new ImRectPtr(nativePtr);

		/// <summary>
		/// Upper-left
		/// </summary>
		public ref Vector2 Min => ref Unsafe.AsRef<Vector2>(&NativePtr->Min);

		/// <summary>
		/// Lower-right
		/// </summary>
		public ref Vector2 Max => ref Unsafe.AsRef<Vector2>(&NativePtr->Max);

		public Vector2 GetCenter()
		{
			var ret = ImGuiInternalNative.ImRect_GetCenter(NativePtr);
			return ret;
		}

		public Vector2 GetSize()
		{
			var ret = ImGuiInternalNative.ImRect_GetSize(NativePtr);
			return ret;
		}

		public float GetWidth()
		{
			var ret = ImGuiInternalNative.ImRect_GetWidth(NativePtr);
			return ret;
		}

		public float GetHeight()
		{
			var ret = ImGuiInternalNative.ImRect_GetHeight(NativePtr);
			return ret;
		}

		public float GetArea()
		{
			var ret = ImGuiInternalNative.ImRect_GetArea(NativePtr);
			return ret;
		}

		/// <summary>
		/// Top-left
		/// </summary>
		public Vector2 GetTL()
		{
			var ret = ImGuiInternalNative.ImRect_GetTL(NativePtr);
			return ret;
		}

		/// <summary>
		/// Top-right
		/// </summary>
		public Vector2 GetTR()
		{
			var ret = ImGuiInternalNative.ImRect_GetTR(NativePtr);
			return ret;
		}

		/// <summary>
		/// Bottom-left
		/// </summary>
		public Vector2 GetBL()
		{
			var ret = ImGuiInternalNative.ImRect_GetBL(NativePtr);
			return ret;
		}

		/// <summary>
		/// Bottom-right
		/// </summary>
		public Vector2 GetBR()
		{
			var ret = ImGuiInternalNative.ImRect_GetBR(NativePtr);
			return ret;
		}

		public bool Contains(Vector2 p)
		{
			var ret = ImGuiInternalNative.ImRect_Contains(NativePtr, p);
			return ret != 0;
		}

		public bool ContainsImRect(ImRect r)
		{
			var ret = ImGuiInternalNative.ImRect_ContainsImRect(NativePtr, r);
			return ret != 0;
		}

		public bool ContainsWithPad(Vector2 p, Vector2 pad)
		{
			var ret = ImGuiInternalNative.ImRect_ContainsWithPad(NativePtr, p, pad);
			return ret != 0;
		}

		public bool Overlaps(ImRect r)
		{
			var ret = ImGuiInternalNative.ImRect_Overlaps(NativePtr, r);
			return ret != 0;
		}

		public void Add(Vector2 p)
		{
			ImGuiInternalNative.ImRect_Add(NativePtr, p);
		}

		public void AddImRect(ImRect r)
		{
			ImGuiInternalNative.ImRect_AddImRect(NativePtr, r);
		}

		public void Expand(float amount)
		{
			ImGuiInternalNative.ImRect_Expand(NativePtr, amount);
		}

		public void ExpandImVec2(Vector2 amount)
		{
			ImGuiInternalNative.ImRect_ExpandImVec2(NativePtr, amount);
		}

		public void Translate(Vector2 d)
		{
			ImGuiInternalNative.ImRect_Translate(NativePtr, d);
		}

		public void TranslateX(float dx)
		{
			ImGuiInternalNative.ImRect_TranslateX(NativePtr, dx);
		}

		public void TranslateY(float dy)
		{
			ImGuiInternalNative.ImRect_TranslateY(NativePtr, dy);
		}

		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.
		/// </summary>
		public void ClipWith(ImRect r)
		{
			ImGuiInternalNative.ImRect_ClipWith(NativePtr, r);
		}

		/// <summary>
		/// Full version, ensure both points are fully clipped.
		/// </summary>
		public void ClipWithFull(ImRect r)
		{
			ImGuiInternalNative.ImRect_ClipWithFull(NativePtr, r);
		}

		public void Floor()
		{
			ImGuiInternalNative.ImRect_Floor(NativePtr);
		}

		public bool IsInverted()
		{
			var ret = ImGuiInternalNative.ImRect_IsInverted(NativePtr);
			return ret != 0;
		}

		public Vector4 ToVec4()
		{
			var ret = ImGuiInternalNative.ImRect_ToVec4(NativePtr);
			return ret;
		}
	}
}
