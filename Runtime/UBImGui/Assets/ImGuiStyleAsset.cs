using System;
using Hexa.NET.ImGui;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;
using Vector4 = System.Numerics.Vector4;

namespace UBImGui
{
    [CreateAssetMenu(fileName = "ImGui Style", menuName = "UB ImGui/Style")]
    public class ImGuiStyleAsset : ScriptableObject
    {
        public float Alpha;
        public float DisabledAlpha;
        public Vector2 WindowPadding;
        public float WindowRounding;
        public float WindowBorderSize;
        public Vector2 WindowMinSize;
        public Vector2 WindowTitleAlign;
        public ImGuiDir WindowMenuButtonPosition;
        public float ChildRounding;
        public float ChildBorderSize;
        public float PopupRounding;
        public float PopupBorderSize;
        public Vector2 FramePadding;
        public float FrameRounding;
        public float FrameBorderSize;
        public Vector2 ItemSpacing;
        public Vector2 ItemInnerSpacing;
        public Vector2 CellPadding;
        public Vector2 TouchExtraPadding;
        public float IndentSpacing;
        public float ColumnsMinSpacing;
        public float ScrollbarSize;
        public float ScrollbarRounding;
        public float GrabMinSize;
        public float GrabRounding;
        public float LogSliderDeadzone;
        public float TabRounding;
        public float TabBorderSize;
        public float TabMinWidthForCloseButton;
        public float TabBarBorderSize;
        public float TabBarOverlineSize;
        public float TableAngledHeadersAngle;
        public Vector2 TableAngledHeadersTextAlign;
        public ImGuiDir ColorButtonPosition;
        public Vector2 ButtonTextAlign;
        public Vector2 SelectableTextAlign;
        public float SeparatorTextBorderSize;
        public Vector2 SeparatorTextAlign;
        public Vector2 SeparatorTextPadding;
        public Vector2 DisplayWindowPadding;
        public Vector2 DisplaySafeAreaPadding;
        public float DockingSeparatorSize;
        public float MouseCursorScale;
        public bool AntiAliasedLines;
        public bool AntiAliasedLinesUseTex;
        public bool AntiAliasedFill;
        public float CurveTessellationTol;
        public float CircleTessellationMaxError;
        public float HoverStationaryDelay;
        public float HoverDelayShort;
        public float HoverDelayNormal;
        public ImGuiHoveredFlags HoverFlagsForTooltipMouse;
        public ImGuiHoveredFlags HoverFlagsForTooltipNav;
        [HideInInspector]
        public Color[] Colors = new Color[(int)ImGuiCol.Count];
        
        public void ApplyTo(ImGuiStylePtr style)
        {
            style.Alpha = Alpha;
            style.DisabledAlpha = DisabledAlpha;
            style.WindowPadding = WindowPadding;
            style.WindowRounding = WindowRounding;
            style.WindowBorderSize = WindowBorderSize;
            style.WindowMinSize = WindowMinSize;
            style.WindowTitleAlign = WindowTitleAlign;
            style.WindowMenuButtonPosition = WindowMenuButtonPosition;
            style.ChildRounding = ChildRounding;
            style.ChildBorderSize = ChildBorderSize;
            style.PopupRounding = PopupRounding;
            style.PopupBorderSize = PopupBorderSize;
            style.FramePadding = FramePadding;
            style.FrameRounding = FrameRounding;
            style.FrameBorderSize = FrameBorderSize;
            style.ItemSpacing = ItemSpacing;
            style.ItemInnerSpacing = ItemInnerSpacing;
            style.CellPadding = CellPadding;
            style.TouchExtraPadding = TouchExtraPadding;
            style.IndentSpacing = IndentSpacing;
            style.ColumnsMinSpacing = ColumnsMinSpacing;
            style.ScrollbarSize = ScrollbarSize;
            style.ScrollbarRounding = ScrollbarRounding;
            style.GrabMinSize = GrabMinSize;
            style.GrabRounding = GrabRounding;
            style.LogSliderDeadzone = LogSliderDeadzone;
            style.TabRounding = TabRounding;
            style.TabBorderSize = TabBorderSize;
            style.TabMinWidthForCloseButton = TabMinWidthForCloseButton;
            style.TabBarBorderSize = TabBarBorderSize;
            style.TabBarOverlineSize = TabBarOverlineSize;
            style.TableAngledHeadersAngle = TableAngledHeadersAngle;
            style.TableAngledHeadersTextAlign = TableAngledHeadersTextAlign;
            style.ColorButtonPosition = ColorButtonPosition;
            style.ButtonTextAlign = ButtonTextAlign;
            style.SelectableTextAlign = SelectableTextAlign;
            style.SeparatorTextBorderSize = SeparatorTextBorderSize;
            style.SeparatorTextAlign = SeparatorTextAlign;
            style.SeparatorTextPadding = SeparatorTextPadding;
            style.DisplayWindowPadding = DisplayWindowPadding;
            style.DisplaySafeAreaPadding = DisplaySafeAreaPadding;
            style.DockingSeparatorSize = DockingSeparatorSize;
            style.MouseCursorScale = MouseCursorScale;
            style.AntiAliasedLines = AntiAliasedLines;
            style.AntiAliasedLinesUseTex = AntiAliasedLinesUseTex;
            style.AntiAliasedFill = AntiAliasedFill;
            style.CurveTessellationTol = CurveTessellationTol;
            style.CircleTessellationMaxError = CircleTessellationMaxError;
            style.HoverStationaryDelay = HoverStationaryDelay;
            style.HoverDelayShort = HoverDelayShort;
            style.HoverDelayNormal = HoverDelayNormal;
            style.HoverFlagsForTooltipMouse = HoverFlagsForTooltipMouse;
            style.HoverFlagsForTooltipNav = HoverFlagsForTooltipNav;
            for (int i = 0; i < Colors.Length; i++)
            {
                style.Colors[i] = new Vector4(Colors[i].r, Colors[i].g, Colors[i].b, Colors[i].a);
            }
        }

        public void CopyFrom(ImGuiStylePtr style)
        {
            Alpha = style.Alpha;
            DisabledAlpha = style.DisabledAlpha;
            WindowPadding = style.WindowPadding;
            WindowRounding = style.WindowRounding;
            WindowBorderSize = style.WindowBorderSize;
            WindowMinSize = style.WindowMinSize;
            WindowTitleAlign = style.WindowTitleAlign;
            WindowMenuButtonPosition = style.WindowMenuButtonPosition;
            ChildRounding = style.ChildRounding;
            ChildBorderSize = style.ChildBorderSize;
            PopupRounding = style.PopupRounding;
            PopupBorderSize = style.PopupBorderSize;
            FramePadding = style.FramePadding;
            FrameRounding = style.FrameRounding;
            FrameBorderSize = style.FrameBorderSize;
            ItemSpacing = style.ItemSpacing;
            ItemInnerSpacing = style.ItemInnerSpacing;
            CellPadding = style.CellPadding;
            TouchExtraPadding = style.TouchExtraPadding;
            IndentSpacing = style.IndentSpacing;
            ColumnsMinSpacing = style.ColumnsMinSpacing;
            ScrollbarSize = style.ScrollbarSize;
            ScrollbarRounding = style.ScrollbarRounding;
            GrabMinSize = style.GrabMinSize;
            GrabRounding = style.GrabRounding;
            LogSliderDeadzone = style.LogSliderDeadzone;
            TabRounding = style.TabRounding;
            TabBorderSize = style.TabBorderSize;
            TabMinWidthForCloseButton = style.TabMinWidthForCloseButton;
            TabBarBorderSize = style.TabBarBorderSize;
            TabBarOverlineSize = style.TabBarOverlineSize;
            TableAngledHeadersAngle = style.TableAngledHeadersAngle;
            TableAngledHeadersTextAlign = style.TableAngledHeadersTextAlign;
            ColorButtonPosition = style.ColorButtonPosition;
            ButtonTextAlign = style.ButtonTextAlign;
            SelectableTextAlign = style.SelectableTextAlign;
            SeparatorTextBorderSize = style.SeparatorTextBorderSize;
            SeparatorTextAlign = style.SeparatorTextAlign;
            SeparatorTextPadding = style.SeparatorTextPadding;
            DisplayWindowPadding = style.DisplayWindowPadding;
            DisplaySafeAreaPadding = style.DisplaySafeAreaPadding;
            DockingSeparatorSize = style.DockingSeparatorSize;
            MouseCursorScale = style.MouseCursorScale;
            AntiAliasedLines = style.AntiAliasedLines;
            AntiAliasedLinesUseTex = style.AntiAliasedLinesUseTex;
            AntiAliasedFill = style.AntiAliasedFill;
            CurveTessellationTol = style.CurveTessellationTol;
            CircleTessellationMaxError = style.CircleTessellationMaxError;
            HoverStationaryDelay = style.HoverStationaryDelay;
            HoverDelayShort = style.HoverDelayShort;
            HoverDelayNormal = style.HoverDelayNormal;
            HoverFlagsForTooltipMouse = style.HoverFlagsForTooltipMouse;
            HoverFlagsForTooltipNav = style.HoverFlagsForTooltipNav;
            for (int i = 0; i < Colors.Length; i++)
                Colors[i] = new Color(style.Colors[i].X, style.Colors[i].Y, style.Colors[i].Z, style.Colors[i].W);
        }

        public void Reset()
        {
            var oldCtx = ImGui.GetCurrentContext();
            var context = ImGui.CreateContext();
            ImGui.SetCurrentContext(context);
            CopyFrom(ImGui.GetStyle());
            
            if (oldCtx != ImGuiContextPtr.Null)
                ImGui.SetCurrentContext(oldCtx);
            
            ImGui.DestroyContext(context);
        }

        public static ImGuiStyleAsset Default()
        {
            var asset = CreateInstance<ImGuiStyleAsset>();
            asset.Reset();
            return asset;
        }
    }
}