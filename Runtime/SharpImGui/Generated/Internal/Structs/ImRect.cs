using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImRect
	{
		/// <summary>
		/// Upper-left<br/>
		/// </summary>
		public Vector2 Min;
		/// <summary>
		/// Lower-right<br/>
		/// </summary>
		public Vector2 Max;
	}

	/// <summary>
	/// Helper: ImRect (2D axis aligned bounding-box)<br/>NB: we can't rely on ImVec2 math operators being available here!<br/>
	/// </summary>
	public unsafe partial struct ImRectPtr
	{
		public ImRect* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImRect this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Upper-left<br/>
		/// </summary>
		public ref Vector2 Min => ref Unsafe.AsRef<Vector2>(&NativePtr->Min);
		/// <summary>
		/// Lower-right<br/>
		/// </summary>
		public ref Vector2 Max => ref Unsafe.AsRef<Vector2>(&NativePtr->Max);
		public ImRectPtr(ImRect* nativePtr) => NativePtr = nativePtr;
		public ImRectPtr(IntPtr nativePtr) => NativePtr = (ImRect*)nativePtr;
		public static implicit operator ImRectPtr(ImRect* ptr) => new ImRectPtr(ptr);
		public static implicit operator ImRectPtr(IntPtr ptr) => new ImRectPtr(ptr);
		public static implicit operator ImRect*(ImRectPtr nativePtr) => nativePtr.NativePtr;
		public void ToVec4(out Vector4 pOut)
		{
			fixed (Vector4* nativePOut = &pOut)
			{
				ImGuiNative.ImRectToVec4(nativePOut, NativePtr);
			}
		}

		public bool IsInverted()
		{
			var result = ImGuiNative.ImRectIsInverted(NativePtr);
			return result != 0;
		}

		public void Floor()
		{
			ImGuiNative.ImRectFloor(NativePtr);
		}

		/// <summary>
		/// Full version, ensure both points are fully clipped.<br/>
		/// </summary>
		public void ClipWithFull(ImRect r)
		{
			ImGuiNative.ImRectClipWithFull(NativePtr, r);
		}

		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.<br/>
		/// </summary>
		public void ClipWith(ImRect r)
		{
			ImGuiNative.ImRectClipWith(NativePtr, r);
		}

		public void TranslateY(float dy)
		{
			ImGuiNative.ImRectTranslateY(NativePtr, dy);
		}

		public void TranslateX(float dx)
		{
			ImGuiNative.ImRectTranslateX(NativePtr, dx);
		}

		public void Translate(Vector2 d)
		{
			ImGuiNative.ImRectTranslate(NativePtr, d);
		}

		public void Expand(Vector2 amount)
		{
			ImGuiNative.ImRectExpand(NativePtr, amount);
		}

		public void Expand(float amount)
		{
			ImGuiNative.ImRectExpand(NativePtr, amount);
		}

		public void AddRect(ImRect r)
		{
			ImGuiNative.ImRectAddRect(NativePtr, r);
		}

		public void AddVec2(Vector2 p)
		{
			ImGuiNative.ImRectAddVec2(NativePtr, p);
		}

		public bool Overlaps(ImRect r)
		{
			var result = ImGuiNative.ImRectOverlaps(NativePtr, r);
			return result != 0;
		}

		public bool ContainsWithPad(Vector2 p, Vector2 pad)
		{
			var result = ImGuiNative.ImRectContainsWithPad(NativePtr, p, pad);
			return result != 0;
		}

		public bool ContainsRect(ImRect r)
		{
			var result = ImGuiNative.ImRectContainsRect(NativePtr, r);
			return result != 0;
		}

		public bool ContainsVec2(Vector2 p)
		{
			var result = ImGuiNative.ImRectContainsVec2(NativePtr, p);
			return result != 0;
		}

		/// <summary>
		/// Bottom-right<br/>
		/// </summary>
		public void GetBR(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRectGetBR(nativePOut, NativePtr);
			}
		}

		/// <summary>
		/// Bottom-left<br/>
		/// </summary>
		public void GetBL(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRectGetBL(nativePOut, NativePtr);
			}
		}

		/// <summary>
		/// Top-right<br/>
		/// </summary>
		public void GetTR(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRectGetTR(nativePOut, NativePtr);
			}
		}

		/// <summary>
		/// Top-left<br/>
		/// </summary>
		public void GetTL(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRectGetTL(nativePOut, NativePtr);
			}
		}

		public float GetArea()
		{
			return ImGuiNative.ImRectGetArea(NativePtr);
		}

		public float GetHeht()
		{
			return ImGuiNative.ImRectGetHeht(NativePtr);
		}

		public float GetWidth()
		{
			return ImGuiNative.ImRectGetWidth(NativePtr);
		}

		public void GetSize(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRectGetSize(nativePOut, NativePtr);
			}
		}

		public void GetCenter(out Vector2 pOut)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRectGetCenter(nativePOut, NativePtr);
			}
		}

		public void ImRectFloatConstruct(float x1, float y1, float x2, float y2)
		{
			ImGuiNative.ImRectImRectFloatConstruct(NativePtr, x1, y1, x2, y2);
		}

		public ImRectPtr ImRect(float x1, float y1, float x2, float y2)
		{
			return ImGuiNative.ImRectImRect(x1, y1, x2, y2);
		}

		public void ImRectVec4Construct(Vector4 v)
		{
			ImGuiNative.ImRectImRectVec4Construct(NativePtr, v);
		}

		public ImRectPtr ImRect(Vector4 v)
		{
			return ImGuiNative.ImRectImRect(v);
		}

		public void ImRectVec2Construct(Vector2 min, Vector2 max)
		{
			ImGuiNative.ImRectImRectVec2Construct(NativePtr, min, max);
		}

		public ImRectPtr ImRect(Vector2 min, Vector2 max)
		{
			return ImGuiNative.ImRectImRect(min, max);
		}

		public void Destroy()
		{
			ImGuiNative.ImRectDestroy(NativePtr);
		}

		public void ImRectNilConstruct()
		{
			ImGuiNative.ImRectImRectNilConstruct(NativePtr);
		}

		public ImRectPtr ImRect()
		{
			return ImGuiNative.ImRectImRect();
		}

	}
}
