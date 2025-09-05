using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStyle
	{
		/// <summary>
		/// Global alpha applies to everything in Dear ImGui.<br/>
		/// </summary>
		public float Alpha;
		/// <summary>
		/// Additional alpha multiplier applied by BeginDisabled(). Multiply over current value of Alpha.<br/>
		/// </summary>
		public float DisabledAlpha;
		/// <summary>
		/// Padding within a window.<br/>
		/// </summary>
		public Vector2 WindowPadding;
		/// <summary>
		/// Radius of window corners rounding. Set to 0.0f to have rectangular windows. Large values tend to lead to variety of artifacts and are not recommended.<br/>
		/// </summary>
		public float WindowRounding;
		/// <summary>
		/// Thickness of border around windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public float WindowBorderSize;
		/// <summary>
		/// Hit-testing extent outside/inside resizing border. Also extend determination of hovered window. Generally meaningfully larger than WindowBorderSize to make it easy to reach borders.<br/>
		/// </summary>
		public float WindowBorderHoverPadding;
		/// <summary>
		/// Minimum window size. This is a global setting. If you want to constrain individual windows, use SetNextWindowSizeConstraints().<br/>
		/// </summary>
		public Vector2 WindowMinSize;
		/// <summary>
		/// Alignment for title bar text. Defaults to (0.0f,0.5f) for left-aligned,vertically centered.<br/>
		/// </summary>
		public Vector2 WindowTitleAlign;
		/// <summary>
		/// Side of the collapsing/docking button in the title bar (None/Left/Right). Defaults to ImGuiDir_Left.<br/>
		/// </summary>
		public ImGuiDir WindowMenuButtonPosition;
		/// <summary>
		/// Radius of child window corners rounding. Set to 0.0f to have rectangular windows.<br/>
		/// </summary>
		public float ChildRounding;
		/// <summary>
		/// Thickness of border around child windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public float ChildBorderSize;
		/// <summary>
		/// Radius of popup window corners rounding. (Note that tooltip windows use WindowRounding)<br/>
		/// </summary>
		public float PopupRounding;
		/// <summary>
		/// Thickness of border around popup/tooltip windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public float PopupBorderSize;
		/// <summary>
		/// Padding within a framed rectangle (used by most widgets).<br/>
		/// </summary>
		public Vector2 FramePadding;
		/// <summary>
		/// Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets).<br/>
		/// </summary>
		public float FrameRounding;
		/// <summary>
		/// Thickness of border around frames. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public float FrameBorderSize;
		/// <summary>
		/// Horizontal and vertical spacing between widgets/lines.<br/>
		/// </summary>
		public Vector2 ItemSpacing;
		/// <summary>
		/// Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label).<br/>
		/// </summary>
		public Vector2 ItemInnerSpacing;
		/// <summary>
		/// Padding within a table cell. Cellpadding.x is locked for entire table. CellPadding.y may be altered between different rows.<br/>
		/// </summary>
		public Vector2 CellPadding;
		/// <summary>
		/// Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!<br/>
		/// </summary>
		public Vector2 TouchExtraPadding;
		/// <summary>
		/// Horizontal indentation when e.g. entering a tree node. Generally == (FontSize + FramePadding.x*2).<br/>
		/// </summary>
		public float IndentSpacing;
		/// <summary>
		/// Minimum horizontal spacing between two columns. Preferably &gt; (FramePadding.x + 1).<br/>
		/// </summary>
		public float ColumnsMinSpacing;
		/// <summary>
		/// Width of the vertical scrollbar, Height of the horizontal scrollbar.<br/>
		/// </summary>
		public float ScrollbarSize;
		/// <summary>
		/// Radius of grab corners for scrollbar.<br/>
		/// </summary>
		public float ScrollbarRounding;
		/// <summary>
		/// Minimum width/height of a grab box for slider/scrollbar.<br/>
		/// </summary>
		public float GrabMinSize;
		/// <summary>
		/// Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.<br/>
		/// </summary>
		public float GrabRounding;
		/// <summary>
		/// The size in pixels of the dead-zone around zero on logarithmic sliders that cross zero.<br/>
		/// </summary>
		public float LogSliderDeadzone;
		/// <summary>
		/// Thickness of border around Image() calls.<br/>
		/// </summary>
		public float ImageBorderSize;
		/// <summary>
		/// Radius of upper corners of a tab. Set to 0.0f to have rectangular tabs.<br/>
		/// </summary>
		public float TabRounding;
		/// <summary>
		/// Thickness of border around tabs.<br/>
		/// </summary>
		public float TabBorderSize;
		/// <summary>
		/// -1: always visible. 0.0f: visible when hovered. &gt;0.0f: visible when hovered if minimum width.<br/>
		/// </summary>
		public float TabCloseButtonMinWidthSelected;
		/// <summary>
		/// -1: always visible. 0.0f: visible when hovered. &gt;0.0f: visible when hovered if minimum width. FLT_MAX: never show close button when unselected.<br/>
		/// </summary>
		public float TabCloseButtonMinWidthUnselected;
		/// <summary>
		/// Thickness of tab-bar separator, which takes on the tab active color to denote focus.<br/>
		/// </summary>
		public float TabBarBorderSize;
		/// <summary>
		/// Thickness of tab-bar overline, which highlights the selected tab-bar.<br/>
		/// </summary>
		public float TabBarOverlineSize;
		/// <summary>
		/// Angle of angled headers (supported values range from -50.0f degrees to +50.0f degrees).<br/>
		/// </summary>
		public float TableAngledHeadersAngle;
		/// <summary>
		/// Alignment of angled headers within the cell<br/>
		/// </summary>
		public Vector2 TableAngledHeadersTextAlign;
		/// <summary>
		/// Side of the color button in the ColorEdit4 widget (left/right). Defaults to ImGuiDir_Right.<br/>
		/// </summary>
		public ImGuiDir ColorButtonPosition;
		/// <summary>
		/// Alignment of button text when button is larger than text. Defaults to (0.5f, 0.5f) (centered).<br/>
		/// </summary>
		public Vector2 ButtonTextAlign;
		/// <summary>
		/// Alignment of selectable text. Defaults to (0.0f, 0.0f) (top-left aligned). It's generally important to keep this left-aligned if you want to lay multiple items on a same line.<br/>
		/// </summary>
		public Vector2 SelectableTextAlign;
		/// <summary>
		/// Thickness of border in SeparatorText()<br/>
		/// </summary>
		public float SeparatorTextBorderSize;
		/// <summary>
		/// Alignment of text within the separator. Defaults to (0.0f, 0.5f) (left aligned, center).<br/>
		/// </summary>
		public Vector2 SeparatorTextAlign;
		/// <summary>
		/// Horizontal offset of text from each edge of the separator + spacing on other axis. Generally small values. .y is recommended to be == FramePadding.y.<br/>
		/// </summary>
		public Vector2 SeparatorTextPadding;
		/// <summary>
		/// Apply to regular windows: amount which we enforce to keep visible when moving near edges of your screen.<br/>
		/// </summary>
		public Vector2 DisplayWindowPadding;
		/// <summary>
		/// Apply to every windows, menus, popups, tooltips: amount where we avoid displaying contents. Adjust if you cannot see the edges of your screen (e.g. on a TV where scaling has not been configured).<br/>
		/// </summary>
		public Vector2 DisplaySafeAreaPadding;
		/// <summary>
		/// Thickness of resizing border between docked windows<br/>
		/// </summary>
		public float DockingSeparatorSize;
		/// <summary>
		/// Scale software rendered mouse cursor (when io.MouseDrawCursor is enabled). We apply per-monitor DPI scaling over this scale. May be removed later.<br/>
		/// </summary>
		public float MouseCursorScale;
		/// <summary>
		/// Enable anti-aliased lines/borders. Disable if you are really tight on CPU/GPU. Latched at the beginning of the frame (copied to ImDrawList).<br/>
		/// </summary>
		public byte AntiAliasedLines;
		/// <summary>
		/// Enable anti-aliased lines/borders using textures where possible. Require backend to render with bilinear filtering (NOT point/nearest filtering). Latched at the beginning of the frame (copied to ImDrawList).<br/>
		/// </summary>
		public byte AntiAliasedLinesUseTex;
		/// <summary>
		/// Enable anti-aliased edges around filled shapes (rounded rectangles, circles, etc.). Disable if you are really tight on CPU/GPU. Latched at the beginning of the frame (copied to ImDrawList).<br/>
		/// </summary>
		public byte AntiAliasedFill;
		/// <summary>
		/// Tessellation tolerance when using PathBezierCurveTo() without a specific number of segments. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.<br/>
		/// </summary>
		public float CurveTessellationTol;
		/// <summary>
		/// Maximum error (in pixels) allowed when using AddCircle()/AddCircleFilled() or drawing rounded corner rectangles with no explicit segment count specified. Decrease for higher quality but more geometry.<br/>
		/// </summary>
		public float CircleTessellationMaxError;
		/// <summary>
		///     Colors<br/>
		/// </summary>
		public Vector4 Colors_0;
		public Vector4 Colors_1;
		public Vector4 Colors_2;
		public Vector4 Colors_3;
		public Vector4 Colors_4;
		public Vector4 Colors_5;
		public Vector4 Colors_6;
		public Vector4 Colors_7;
		public Vector4 Colors_8;
		public Vector4 Colors_9;
		public Vector4 Colors_10;
		public Vector4 Colors_11;
		public Vector4 Colors_12;
		public Vector4 Colors_13;
		public Vector4 Colors_14;
		public Vector4 Colors_15;
		public Vector4 Colors_16;
		public Vector4 Colors_17;
		public Vector4 Colors_18;
		public Vector4 Colors_19;
		public Vector4 Colors_20;
		public Vector4 Colors_21;
		public Vector4 Colors_22;
		public Vector4 Colors_23;
		public Vector4 Colors_24;
		public Vector4 Colors_25;
		public Vector4 Colors_26;
		public Vector4 Colors_27;
		public Vector4 Colors_28;
		public Vector4 Colors_29;
		public Vector4 Colors_30;
		public Vector4 Colors_31;
		public Vector4 Colors_32;
		public Vector4 Colors_33;
		public Vector4 Colors_34;
		public Vector4 Colors_35;
		public Vector4 Colors_36;
		public Vector4 Colors_37;
		public Vector4 Colors_38;
		public Vector4 Colors_39;
		public Vector4 Colors_40;
		public Vector4 Colors_41;
		public Vector4 Colors_42;
		public Vector4 Colors_43;
		public Vector4 Colors_44;
		public Vector4 Colors_45;
		public Vector4 Colors_46;
		public Vector4 Colors_47;
		public Vector4 Colors_48;
		public Vector4 Colors_49;
		public Vector4 Colors_50;
		public Vector4 Colors_51;
		public Vector4 Colors_52;
		public Vector4 Colors_53;
		public Vector4 Colors_54;
		public Vector4 Colors_55;
		public Vector4 Colors_56;
		public Vector4 Colors_57;
		/// <summary>
		///     Behaviors<br/>    (It is possible to modify those fields mid-frame if specific behavior need it, unlike e.g. configuration fields in ImGuiIO)<br/>
		/// Delay for IsItemHovered(ImGuiHoveredFlags_Stationary). Time required to consider mouse stationary.<br/>
		/// </summary>
		public float HoverStationaryDelay;
		/// <summary>
		/// Delay for IsItemHovered(ImGuiHoveredFlags_DelayShort). Usually used along with HoverStationaryDelay.<br/>
		/// </summary>
		public float HoverDelayShort;
		/// <summary>
		/// Delay for IsItemHovered(ImGuiHoveredFlags_DelayNormal). "<br/>
		/// </summary>
		public float HoverDelayNormal;
		/// <summary>
		/// Default flags when using IsItemHovered(ImGuiHoveredFlags_ForTooltip) or BeginItemTooltip()/SetItemTooltip() while using mouse.<br/>
		/// </summary>
		public ImGuiHoveredFlags HoverFlagsForTooltipMouse;
		/// <summary>
		/// Default flags when using IsItemHovered(ImGuiHoveredFlags_ForTooltip) or BeginItemTooltip()/SetItemTooltip() while using keyboard/gamepad.<br/>
		/// </summary>
		public ImGuiHoveredFlags HoverFlagsForTooltipNav;
	}

	public unsafe partial struct ImGuiStylePtr
	{
		public ImGuiStyle* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStyle this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Global alpha applies to everything in Dear ImGui.<br/>
		/// </summary>
		public ref float Alpha => ref Unsafe.AsRef<float>(&NativePtr->Alpha);
		/// <summary>
		/// Additional alpha multiplier applied by BeginDisabled(). Multiply over current value of Alpha.<br/>
		/// </summary>
		public ref float DisabledAlpha => ref Unsafe.AsRef<float>(&NativePtr->DisabledAlpha);
		/// <summary>
		/// Padding within a window.<br/>
		/// </summary>
		public ref Vector2 WindowPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowPadding);
		/// <summary>
		/// Radius of window corners rounding. Set to 0.0f to have rectangular windows. Large values tend to lead to variety of artifacts and are not recommended.<br/>
		/// </summary>
		public ref float WindowRounding => ref Unsafe.AsRef<float>(&NativePtr->WindowRounding);
		/// <summary>
		/// Thickness of border around windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public ref float WindowBorderSize => ref Unsafe.AsRef<float>(&NativePtr->WindowBorderSize);
		/// <summary>
		/// Hit-testing extent outside/inside resizing border. Also extend determination of hovered window. Generally meaningfully larger than WindowBorderSize to make it easy to reach borders.<br/>
		/// </summary>
		public ref float WindowBorderHoverPadding => ref Unsafe.AsRef<float>(&NativePtr->WindowBorderHoverPadding);
		/// <summary>
		/// Minimum window size. This is a global setting. If you want to constrain individual windows, use SetNextWindowSizeConstraints().<br/>
		/// </summary>
		public ref Vector2 WindowMinSize => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowMinSize);
		/// <summary>
		/// Alignment for title bar text. Defaults to (0.0f,0.5f) for left-aligned,vertically centered.<br/>
		/// </summary>
		public ref Vector2 WindowTitleAlign => ref Unsafe.AsRef<Vector2>(&NativePtr->WindowTitleAlign);
		/// <summary>
		/// Side of the collapsing/docking button in the title bar (None/Left/Right). Defaults to ImGuiDir_Left.<br/>
		/// </summary>
		public ref ImGuiDir WindowMenuButtonPosition => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->WindowMenuButtonPosition);
		/// <summary>
		/// Radius of child window corners rounding. Set to 0.0f to have rectangular windows.<br/>
		/// </summary>
		public ref float ChildRounding => ref Unsafe.AsRef<float>(&NativePtr->ChildRounding);
		/// <summary>
		/// Thickness of border around child windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public ref float ChildBorderSize => ref Unsafe.AsRef<float>(&NativePtr->ChildBorderSize);
		/// <summary>
		/// Radius of popup window corners rounding. (Note that tooltip windows use WindowRounding)<br/>
		/// </summary>
		public ref float PopupRounding => ref Unsafe.AsRef<float>(&NativePtr->PopupRounding);
		/// <summary>
		/// Thickness of border around popup/tooltip windows. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public ref float PopupBorderSize => ref Unsafe.AsRef<float>(&NativePtr->PopupBorderSize);
		/// <summary>
		/// Padding within a framed rectangle (used by most widgets).<br/>
		/// </summary>
		public ref Vector2 FramePadding => ref Unsafe.AsRef<Vector2>(&NativePtr->FramePadding);
		/// <summary>
		/// Radius of frame corners rounding. Set to 0.0f to have rectangular frame (used by most widgets).<br/>
		/// </summary>
		public ref float FrameRounding => ref Unsafe.AsRef<float>(&NativePtr->FrameRounding);
		/// <summary>
		/// Thickness of border around frames. Generally set to 0.0f or 1.0f. (Other values are not well tested and more CPU/GPU costly).<br/>
		/// </summary>
		public ref float FrameBorderSize => ref Unsafe.AsRef<float>(&NativePtr->FrameBorderSize);
		/// <summary>
		/// Horizontal and vertical spacing between widgets/lines.<br/>
		/// </summary>
		public ref Vector2 ItemSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->ItemSpacing);
		/// <summary>
		/// Horizontal and vertical spacing between within elements of a composed widget (e.g. a slider and its label).<br/>
		/// </summary>
		public ref Vector2 ItemInnerSpacing => ref Unsafe.AsRef<Vector2>(&NativePtr->ItemInnerSpacing);
		/// <summary>
		/// Padding within a table cell. Cellpadding.x is locked for entire table. CellPadding.y may be altered between different rows.<br/>
		/// </summary>
		public ref Vector2 CellPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->CellPadding);
		/// <summary>
		/// Expand reactive bounding box for touch-based system where touch position is not accurate enough. Unfortunately we don't sort widgets so priority on overlap will always be given to the first widget. So don't grow this too much!<br/>
		/// </summary>
		public ref Vector2 TouchExtraPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->TouchExtraPadding);
		/// <summary>
		/// Horizontal indentation when e.g. entering a tree node. Generally == (FontSize + FramePadding.x*2).<br/>
		/// </summary>
		public ref float IndentSpacing => ref Unsafe.AsRef<float>(&NativePtr->IndentSpacing);
		/// <summary>
		/// Minimum horizontal spacing between two columns. Preferably &gt; (FramePadding.x + 1).<br/>
		/// </summary>
		public ref float ColumnsMinSpacing => ref Unsafe.AsRef<float>(&NativePtr->ColumnsMinSpacing);
		/// <summary>
		/// Width of the vertical scrollbar, Height of the horizontal scrollbar.<br/>
		/// </summary>
		public ref float ScrollbarSize => ref Unsafe.AsRef<float>(&NativePtr->ScrollbarSize);
		/// <summary>
		/// Radius of grab corners for scrollbar.<br/>
		/// </summary>
		public ref float ScrollbarRounding => ref Unsafe.AsRef<float>(&NativePtr->ScrollbarRounding);
		/// <summary>
		/// Minimum width/height of a grab box for slider/scrollbar.<br/>
		/// </summary>
		public ref float GrabMinSize => ref Unsafe.AsRef<float>(&NativePtr->GrabMinSize);
		/// <summary>
		/// Radius of grabs corners rounding. Set to 0.0f to have rectangular slider grabs.<br/>
		/// </summary>
		public ref float GrabRounding => ref Unsafe.AsRef<float>(&NativePtr->GrabRounding);
		/// <summary>
		/// The size in pixels of the dead-zone around zero on logarithmic sliders that cross zero.<br/>
		/// </summary>
		public ref float LogSliderDeadzone => ref Unsafe.AsRef<float>(&NativePtr->LogSliderDeadzone);
		/// <summary>
		/// Thickness of border around Image() calls.<br/>
		/// </summary>
		public ref float ImageBorderSize => ref Unsafe.AsRef<float>(&NativePtr->ImageBorderSize);
		/// <summary>
		/// Radius of upper corners of a tab. Set to 0.0f to have rectangular tabs.<br/>
		/// </summary>
		public ref float TabRounding => ref Unsafe.AsRef<float>(&NativePtr->TabRounding);
		/// <summary>
		/// Thickness of border around tabs.<br/>
		/// </summary>
		public ref float TabBorderSize => ref Unsafe.AsRef<float>(&NativePtr->TabBorderSize);
		/// <summary>
		/// -1: always visible. 0.0f: visible when hovered. &gt;0.0f: visible when hovered if minimum width.<br/>
		/// </summary>
		public ref float TabCloseButtonMinWidthSelected => ref Unsafe.AsRef<float>(&NativePtr->TabCloseButtonMinWidthSelected);
		/// <summary>
		/// -1: always visible. 0.0f: visible when hovered. &gt;0.0f: visible when hovered if minimum width. FLT_MAX: never show close button when unselected.<br/>
		/// </summary>
		public ref float TabCloseButtonMinWidthUnselected => ref Unsafe.AsRef<float>(&NativePtr->TabCloseButtonMinWidthUnselected);
		/// <summary>
		/// Thickness of tab-bar separator, which takes on the tab active color to denote focus.<br/>
		/// </summary>
		public ref float TabBarBorderSize => ref Unsafe.AsRef<float>(&NativePtr->TabBarBorderSize);
		/// <summary>
		/// Thickness of tab-bar overline, which highlights the selected tab-bar.<br/>
		/// </summary>
		public ref float TabBarOverlineSize => ref Unsafe.AsRef<float>(&NativePtr->TabBarOverlineSize);
		/// <summary>
		/// Angle of angled headers (supported values range from -50.0f degrees to +50.0f degrees).<br/>
		/// </summary>
		public ref float TableAngledHeadersAngle => ref Unsafe.AsRef<float>(&NativePtr->TableAngledHeadersAngle);
		/// <summary>
		/// Alignment of angled headers within the cell<br/>
		/// </summary>
		public ref Vector2 TableAngledHeadersTextAlign => ref Unsafe.AsRef<Vector2>(&NativePtr->TableAngledHeadersTextAlign);
		/// <summary>
		/// Side of the color button in the ColorEdit4 widget (left/right). Defaults to ImGuiDir_Right.<br/>
		/// </summary>
		public ref ImGuiDir ColorButtonPosition => ref Unsafe.AsRef<ImGuiDir>(&NativePtr->ColorButtonPosition);
		/// <summary>
		/// Alignment of button text when button is larger than text. Defaults to (0.5f, 0.5f) (centered).<br/>
		/// </summary>
		public ref Vector2 ButtonTextAlign => ref Unsafe.AsRef<Vector2>(&NativePtr->ButtonTextAlign);
		/// <summary>
		/// Alignment of selectable text. Defaults to (0.0f, 0.0f) (top-left aligned). It's generally important to keep this left-aligned if you want to lay multiple items on a same line.<br/>
		/// </summary>
		public ref Vector2 SelectableTextAlign => ref Unsafe.AsRef<Vector2>(&NativePtr->SelectableTextAlign);
		/// <summary>
		/// Thickness of border in SeparatorText()<br/>
		/// </summary>
		public ref float SeparatorTextBorderSize => ref Unsafe.AsRef<float>(&NativePtr->SeparatorTextBorderSize);
		/// <summary>
		/// Alignment of text within the separator. Defaults to (0.0f, 0.5f) (left aligned, center).<br/>
		/// </summary>
		public ref Vector2 SeparatorTextAlign => ref Unsafe.AsRef<Vector2>(&NativePtr->SeparatorTextAlign);
		/// <summary>
		/// Horizontal offset of text from each edge of the separator + spacing on other axis. Generally small values. .y is recommended to be == FramePadding.y.<br/>
		/// </summary>
		public ref Vector2 SeparatorTextPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->SeparatorTextPadding);
		/// <summary>
		/// Apply to regular windows: amount which we enforce to keep visible when moving near edges of your screen.<br/>
		/// </summary>
		public ref Vector2 DisplayWindowPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplayWindowPadding);
		/// <summary>
		/// Apply to every windows, menus, popups, tooltips: amount where we avoid displaying contents. Adjust if you cannot see the edges of your screen (e.g. on a TV where scaling has not been configured).<br/>
		/// </summary>
		public ref Vector2 DisplaySafeAreaPadding => ref Unsafe.AsRef<Vector2>(&NativePtr->DisplaySafeAreaPadding);
		/// <summary>
		/// Thickness of resizing border between docked windows<br/>
		/// </summary>
		public ref float DockingSeparatorSize => ref Unsafe.AsRef<float>(&NativePtr->DockingSeparatorSize);
		/// <summary>
		/// Scale software rendered mouse cursor (when io.MouseDrawCursor is enabled). We apply per-monitor DPI scaling over this scale. May be removed later.<br/>
		/// </summary>
		public ref float MouseCursorScale => ref Unsafe.AsRef<float>(&NativePtr->MouseCursorScale);
		/// <summary>
		/// Enable anti-aliased lines/borders. Disable if you are really tight on CPU/GPU. Latched at the beginning of the frame (copied to ImDrawList).<br/>
		/// </summary>
		public ref bool AntiAliasedLines => ref Unsafe.AsRef<bool>(&NativePtr->AntiAliasedLines);
		/// <summary>
		/// Enable anti-aliased lines/borders using textures where possible. Require backend to render with bilinear filtering (NOT point/nearest filtering). Latched at the beginning of the frame (copied to ImDrawList).<br/>
		/// </summary>
		public ref bool AntiAliasedLinesUseTex => ref Unsafe.AsRef<bool>(&NativePtr->AntiAliasedLinesUseTex);
		/// <summary>
		/// Enable anti-aliased edges around filled shapes (rounded rectangles, circles, etc.). Disable if you are really tight on CPU/GPU. Latched at the beginning of the frame (copied to ImDrawList).<br/>
		/// </summary>
		public ref bool AntiAliasedFill => ref Unsafe.AsRef<bool>(&NativePtr->AntiAliasedFill);
		/// <summary>
		/// Tessellation tolerance when using PathBezierCurveTo() without a specific number of segments. Decrease for highly tessellated curves (higher quality, more polygons), increase to reduce quality.<br/>
		/// </summary>
		public ref float CurveTessellationTol => ref Unsafe.AsRef<float>(&NativePtr->CurveTessellationTol);
		/// <summary>
		/// Maximum error (in pixels) allowed when using AddCircle()/AddCircleFilled() or drawing rounded corner rectangles with no explicit segment count specified. Decrease for higher quality but more geometry.<br/>
		/// </summary>
		public ref float CircleTessellationMaxError => ref Unsafe.AsRef<float>(&NativePtr->CircleTessellationMaxError);
		/// <summary>
		///     Colors<br/>
		/// </summary>
		public Span<Vector4> Colors => new Span<Vector4>(&NativePtr->Colors_0, 58);
		/// <summary>
		///     Behaviors<br/>    (It is possible to modify those fields mid-frame if specific behavior need it, unlike e.g. configuration fields in ImGuiIO)<br/>
		/// Delay for IsItemHovered(ImGuiHoveredFlags_Stationary). Time required to consider mouse stationary.<br/>
		/// </summary>
		public ref float HoverStationaryDelay => ref Unsafe.AsRef<float>(&NativePtr->HoverStationaryDelay);
		/// <summary>
		/// Delay for IsItemHovered(ImGuiHoveredFlags_DelayShort). Usually used along with HoverStationaryDelay.<br/>
		/// </summary>
		public ref float HoverDelayShort => ref Unsafe.AsRef<float>(&NativePtr->HoverDelayShort);
		/// <summary>
		/// Delay for IsItemHovered(ImGuiHoveredFlags_DelayNormal). "<br/>
		/// </summary>
		public ref float HoverDelayNormal => ref Unsafe.AsRef<float>(&NativePtr->HoverDelayNormal);
		/// <summary>
		/// Default flags when using IsItemHovered(ImGuiHoveredFlags_ForTooltip) or BeginItemTooltip()/SetItemTooltip() while using mouse.<br/>
		/// </summary>
		public ref ImGuiHoveredFlags HoverFlagsForTooltipMouse => ref Unsafe.AsRef<ImGuiHoveredFlags>(&NativePtr->HoverFlagsForTooltipMouse);
		/// <summary>
		/// Default flags when using IsItemHovered(ImGuiHoveredFlags_ForTooltip) or BeginItemTooltip()/SetItemTooltip() while using keyboard/gamepad.<br/>
		/// </summary>
		public ref ImGuiHoveredFlags HoverFlagsForTooltipNav => ref Unsafe.AsRef<ImGuiHoveredFlags>(&NativePtr->HoverFlagsForTooltipNav);
		public ImGuiStylePtr(ImGuiStyle* nativePtr) => NativePtr = nativePtr;
		public ImGuiStylePtr(IntPtr nativePtr) => NativePtr = (ImGuiStyle*)nativePtr;
		public static implicit operator ImGuiStylePtr(ImGuiStyle* ptr) => new ImGuiStylePtr(ptr);
		public static implicit operator ImGuiStylePtr(IntPtr ptr) => new ImGuiStylePtr(ptr);
		public static implicit operator ImGuiStyle*(ImGuiStylePtr nativePtr) => nativePtr.NativePtr;
		public void ScaleAllSizes(float scaleFactor)
		{
			ImGuiNative.ImGuiStyleScaleAllSizes(NativePtr, scaleFactor);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiStyleDestroy(NativePtr);
		}

		public void ImGuiStyleConstruct()
		{
			ImGuiNative.ImGuiStyleImGuiStyleConstruct(NativePtr);
		}

		public ImGuiStylePtr ImGuiStyle()
		{
			return ImGuiNative.ImGuiStyleImGuiStyle();
		}

	}
}
