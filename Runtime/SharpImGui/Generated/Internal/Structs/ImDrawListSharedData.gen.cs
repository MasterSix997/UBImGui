using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Data shared between all ImDrawList instances</para>
	/// <para>Conceptually this could have been called e.g. ImDrawListSharedContext</para>
	/// <para>Typically one ImGui context would create and maintain one of this.</para>
	/// <para>You may want to create your own instance of you try to ImDrawList completely without ImGui. In that case, watch out for future changes to this structure.</para>
	/// </summary>
	public unsafe partial struct ImDrawListSharedData
	{
		/// <summary>
		/// UV of white pixel in the atlas
		/// </summary>
		public Vector2 TexUvWhitePixel;
		/// <summary>
		/// UV of anti-aliased lines in the atlas
		/// </summary>
		public Vector4* TexUvLines;
		/// <summary>
		/// Current/default font (optional, for simplified AddText overload)
		/// </summary>
		public ImFont* Font;
		/// <summary>
		/// Current/default font size (optional, for simplified AddText overload)
		/// </summary>
		public float FontSize;
		/// <summary>
		/// Current/default font scale (== FontSize / Font-&gt;FontSize)
		/// </summary>
		public float FontScale;
		/// <summary>
		/// Tessellation tolerance when using PathBezierCurveTo()
		/// </summary>
		public float CurveTessellationTol;
		/// <summary>
		/// Number of circle segments to use per pixel of radius for AddCircle() etc
		/// </summary>
		public float CircleSegmentMaxError;
		/// <summary>
		/// Value for PushClipRectFullscreen()
		/// </summary>
		public Vector4 ClipRectFullscreen;
		/// <summary>
		/// Initial flags at the beginning of the frame (it is possible to alter flags on a per-drawlist basis afterwards)
		/// </summary>
		public ImDrawListFlags InitialFlags;
		/// <summary>
		/// <para>[Internal] Temp write buffer</para>
		/// </summary>
		public ImVector TempBuffer;
		/// <summary>
		/// <para>[Internal] Lookup tables</para>
		/// </summary>
		/// <summary>
		/// Sample points on the quarter of the circle.
		/// </summary>
		public Vector2 ArcFastVtx_0;
		public Vector2 ArcFastVtx_1;
		public Vector2 ArcFastVtx_2;
		public Vector2 ArcFastVtx_3;
		public Vector2 ArcFastVtx_4;
		public Vector2 ArcFastVtx_5;
		public Vector2 ArcFastVtx_6;
		public Vector2 ArcFastVtx_7;
		public Vector2 ArcFastVtx_8;
		public Vector2 ArcFastVtx_9;
		public Vector2 ArcFastVtx_10;
		public Vector2 ArcFastVtx_11;
		public Vector2 ArcFastVtx_12;
		public Vector2 ArcFastVtx_13;
		public Vector2 ArcFastVtx_14;
		public Vector2 ArcFastVtx_15;
		public Vector2 ArcFastVtx_16;
		public Vector2 ArcFastVtx_17;
		public Vector2 ArcFastVtx_18;
		public Vector2 ArcFastVtx_19;
		public Vector2 ArcFastVtx_20;
		public Vector2 ArcFastVtx_21;
		public Vector2 ArcFastVtx_22;
		public Vector2 ArcFastVtx_23;
		public Vector2 ArcFastVtx_24;
		public Vector2 ArcFastVtx_25;
		public Vector2 ArcFastVtx_26;
		public Vector2 ArcFastVtx_27;
		public Vector2 ArcFastVtx_28;
		public Vector2 ArcFastVtx_29;
		public Vector2 ArcFastVtx_30;
		public Vector2 ArcFastVtx_31;
		public Vector2 ArcFastVtx_32;
		public Vector2 ArcFastVtx_33;
		public Vector2 ArcFastVtx_34;
		public Vector2 ArcFastVtx_35;
		public Vector2 ArcFastVtx_36;
		public Vector2 ArcFastVtx_37;
		public Vector2 ArcFastVtx_38;
		public Vector2 ArcFastVtx_39;
		public Vector2 ArcFastVtx_40;
		public Vector2 ArcFastVtx_41;
		public Vector2 ArcFastVtx_42;
		public Vector2 ArcFastVtx_43;
		public Vector2 ArcFastVtx_44;
		public Vector2 ArcFastVtx_45;
		public Vector2 ArcFastVtx_46;
		public Vector2 ArcFastVtx_47;
		/// <summary>
		/// Cutoff radius after which arc drawing will fallback to slower PathArcTo()
		/// </summary>
		public float ArcFastRadiusCutoff;
		/// <summary>
		/// Precomputed segment count for given radius before we calculate it dynamically (to avoid calculation overhead)
		/// </summary>
		public fixed byte CircleSegmentCounts[64];
	}

	/// <summary>
	/// <para>Data shared between all ImDrawList instances</para>
	/// <para>Conceptually this could have been called e.g. ImDrawListSharedContext</para>
	/// <para>Typically one ImGui context would create and maintain one of this.</para>
	/// <para>You may want to create your own instance of you try to ImDrawList completely without ImGui. In that case, watch out for future changes to this structure.</para>
	/// </summary>
	public unsafe partial struct ImDrawListSharedDataPtr
	{
		public ImDrawListSharedData* NativePtr { get; }
		public ImDrawListSharedDataPtr(ImDrawListSharedData* nativePtr) => NativePtr = nativePtr;
		public ImDrawListSharedDataPtr(IntPtr nativePtr) => NativePtr = (ImDrawListSharedData*)nativePtr;
		public static implicit operator ImDrawListSharedDataPtr(ImDrawListSharedData* nativePtr) => new ImDrawListSharedDataPtr(nativePtr);
		public static implicit operator ImDrawListSharedData* (ImDrawListSharedDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImDrawListSharedDataPtr(IntPtr nativePtr) => new ImDrawListSharedDataPtr(nativePtr);

		/// <summary>
		/// UV of white pixel in the atlas
		/// </summary>
		public ref Vector2 TexUvWhitePixel => ref Unsafe.AsRef<Vector2>(&NativePtr->TexUvWhitePixel);

		/// <summary>
		/// UV of anti-aliased lines in the atlas
		/// </summary>
		public IntPtr TexUvLines { get => (IntPtr)NativePtr->TexUvLines; set => NativePtr->TexUvLines = (Vector4*)value; }

		/// <summary>
		/// Current/default font (optional, for simplified AddText overload)
		/// </summary>
		public ImFontPtr Font => new ImFontPtr(NativePtr->Font);

		/// <summary>
		/// Current/default font size (optional, for simplified AddText overload)
		/// </summary>
		public ref float FontSize => ref Unsafe.AsRef<float>(&NativePtr->FontSize);

		/// <summary>
		/// Current/default font scale (== FontSize / Font-&gt;FontSize)
		/// </summary>
		public ref float FontScale => ref Unsafe.AsRef<float>(&NativePtr->FontScale);

		/// <summary>
		/// Tessellation tolerance when using PathBezierCurveTo()
		/// </summary>
		public ref float CurveTessellationTol => ref Unsafe.AsRef<float>(&NativePtr->CurveTessellationTol);

		/// <summary>
		/// Number of circle segments to use per pixel of radius for AddCircle() etc
		/// </summary>
		public ref float CircleSegmentMaxError => ref Unsafe.AsRef<float>(&NativePtr->CircleSegmentMaxError);

		/// <summary>
		/// Value for PushClipRectFullscreen()
		/// </summary>
		public ref Vector4 ClipRectFullscreen => ref Unsafe.AsRef<Vector4>(&NativePtr->ClipRectFullscreen);

		/// <summary>
		/// Initial flags at the beginning of the frame (it is possible to alter flags on a per-drawlist basis afterwards)
		/// </summary>
		public ref ImDrawListFlags InitialFlags => ref Unsafe.AsRef<ImDrawListFlags>(&NativePtr->InitialFlags);

		/// <summary>
		/// <para>[Internal] Temp write buffer</para>
		/// </summary>
		public ImVector<Vector2> TempBuffer => new ImVector<Vector2>(NativePtr->TempBuffer);

		/// <summary>
		/// <para>[Internal] Lookup tables</para>
		/// </summary>
		/// <summary>
		/// Sample points on the quarter of the circle.
		/// </summary>
		public RangeAccessor<Vector2> ArcFastVtx => new RangeAccessor<Vector2>(&NativePtr->ArcFastVtx_0, 48);

		/// <summary>
		/// Cutoff radius after which arc drawing will fallback to slower PathArcTo()
		/// </summary>
		public ref float ArcFastRadiusCutoff => ref Unsafe.AsRef<float>(&NativePtr->ArcFastRadiusCutoff);

		/// <summary>
		/// Precomputed segment count for given radius before we calculate it dynamically (to avoid calculation overhead)
		/// </summary>
		public RangeAccessor<byte> CircleSegmentCounts => new RangeAccessor<byte>(NativePtr->CircleSegmentCounts, 64);

		public void SetCircleTessellationMaxError(float max_error)
		{
			ImGuiInternalNative.ImDrawListSharedData_SetCircleTessellationMaxError(NativePtr, max_error);
		}
	}
}
