using System;
using SharpImGui;
using UnityEngine;

namespace UBImGui
{
    [Serializable]
    public struct DearImGuiIOConfig
    {
        public bool KeyboardNavigation;
        
        public bool GamepadNavigation;

        [Tooltip("Instruct navigation to move the move the mouse cursor.")]
        public bool NavSetMousePos;

        [Tooltip("Instruct navigation to set the io.WantCaptureKeyboard when io.NavActive is set.")]
        public bool NavCaptureKeyboard;

        [Tooltip("Time for a double-click, in seconds.")]
        public float DoubleClickTime;

        [Tooltip("Distance threshold to stay in to validate a double-click, in pixels.")]
        public float DoubleClickMaxDist;

        [Tooltip("Distance threshold before considering we are dragging.")]
        public float DragThreshold;

        [Tooltip("When holding a key/button, time before it starts repeating, in seconds.")]
        public float KeyRepeatDelay;

        [Tooltip("When holding a key/button, rate at which it repeats, in seconds.")]
        public float KeyRepeatRate;

        [Tooltip("Global scale all fonts.")]
        public float FontGlobalScale;

        [Tooltip("Allow user scaling text of individual window with CTRL+Wheel.")]
        public bool FontAllowUserScaling;

        [Tooltip("Set to false to disable blinking cursor.")]
        public bool TextCursorBlink;

        [Tooltip("Enable resizing from the edges and from the lower-left corner.")]
        public bool ResizeFromEdges;

        [Tooltip("Set to true to only allow moving windows when clicked+dragged from the title bar. Windows without a title bar are not affected.")]
        public bool MoveFromTitleOnly;

        [Tooltip("Compact window memory usage when unused. Set to -1.0f to disable.")]
        public float MemoryCompactTimer;
        
        [Tooltip("Time between saving positions in .ini file, in seconds.")]
        public float IniSavingRate;
        
        [Tooltip("Enable docking support.")]
        public bool DockingEnable;
        
        public bool DockingNoSplit;
        
        [Tooltip("Show docking indicators when dragging a window, only if SHIFT is pressed.")]
        public bool DockingWithShift;
        
        [Tooltip("Always show the docking tab even with only one window")]
        public bool DockingAlwaysTabBar;
        
        public bool DockingTransparentPayload;
        
        public bool InputTextEnterKeepActive;

        public void ApplyTo(ImGuiIOPtr io)
        {
            io.ConfigFlags = KeyboardNavigation ? io.ConfigFlags | ImGuiConfigFlags.NavEnableKeyboard : io.ConfigFlags & ~ImGuiConfigFlags.NavEnableKeyboard;
            io.ConfigFlags = GamepadNavigation ? io.ConfigFlags | ImGuiConfigFlags.NavEnableGamepad : io.ConfigFlags & ~ImGuiConfigFlags.NavEnableGamepad;
            io.MouseDoubleClickTime = DoubleClickTime;
            io.MouseDoubleClickMaxDist = DoubleClickMaxDist;
            io.MouseDragThreshold = DragThreshold;
            io.KeyRepeatDelay = KeyRepeatDelay;
            io.KeyRepeatRate = KeyRepeatRate;
            io.FontGlobalScale = FontGlobalScale;
            io.FontAllowUserScaling = FontAllowUserScaling;
            io.ConfigInputTextCursorBlink = TextCursorBlink;
            io.ConfigWindowsResizeFromEdges = ResizeFromEdges;
            io.ConfigWindowsMoveFromTitleBarOnly = MoveFromTitleOnly;
            io.ConfigMemoryCompactTimer = MemoryCompactTimer;
            io.ConfigNavMoveSetMousePos = NavSetMousePos;
            io.ConfigNavCaptureKeyboard = NavCaptureKeyboard;
            io.IniSavingRate = IniSavingRate;
            io.ConfigFlags = DockingEnable ? io.ConfigFlags | ImGuiConfigFlags.DockingEnable : io.ConfigFlags & ~ImGuiConfigFlags.DockingEnable;
            io.ConfigDockingNoSplit = DockingNoSplit;
            io.ConfigDockingWithShift = DockingWithShift;
            io.ConfigDockingAlwaysTabBar = DockingAlwaysTabBar;
            io.ConfigDockingTransparentPayload = DockingTransparentPayload;
            io.ConfigInputTextEnterKeepActive = InputTextEnterKeepActive;
        }

        public void CopyFrom(ImGuiIOPtr io)
        {
            KeyboardNavigation = (io.ConfigFlags & ImGuiConfigFlags.NavEnableKeyboard) != 0;
            GamepadNavigation = (io.ConfigFlags & ImGuiConfigFlags.NavEnableGamepad) != 0;
            NavSetMousePos = io.ConfigNavMoveSetMousePos;
            NavCaptureKeyboard = io.ConfigNavCaptureKeyboard;
            DoubleClickTime = io.MouseDoubleClickTime;
            DoubleClickMaxDist = io.MouseDoubleClickMaxDist;
            DragThreshold = io.MouseDragThreshold;
            KeyRepeatDelay = io.KeyRepeatDelay;
            KeyRepeatRate = io.KeyRepeatRate;
            FontGlobalScale = io.FontGlobalScale;
            FontAllowUserScaling = io.FontAllowUserScaling;
            TextCursorBlink = io.ConfigInputTextCursorBlink;
            ResizeFromEdges = io.ConfigWindowsResizeFromEdges;
            MoveFromTitleOnly = io.ConfigWindowsMoveFromTitleBarOnly;
            MemoryCompactTimer = io.ConfigMemoryCompactTimer;
            
            IniSavingRate = io.IniSavingRate;
            DockingEnable = (io.ConfigFlags & ImGuiConfigFlags.DockingEnable) != 0;
            DockingNoSplit = io.ConfigDockingNoSplit;
            DockingWithShift = io.ConfigDockingWithShift;
            DockingAlwaysTabBar = io.ConfigDockingAlwaysTabBar;
            DockingTransparentPayload = io.ConfigDockingTransparentPayload;
            InputTextEnterKeepActive = io.ConfigInputTextEnterKeepActive;
        }
        
        public void Reset()
        {
            var oldCtx = ImGui.GetCurrentContext();
            var context = ImGui.CreateContext();
            ImGui.SetCurrentContext(context);
            CopyFrom(ImGui.GetIO());
            
            if (!oldCtx.IsNull)
                ImGui.SetCurrentContext(oldCtx);
            
            ImGui.DestroyContext(context);
        }
    }
}