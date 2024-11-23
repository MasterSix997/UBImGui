using System;
using System.Runtime.CompilerServices;
using SharpImGui;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UBImGui
{
    public class InputManagerHandler : IInputHandler
    {
        private readonly Event _charEvent = new Event();
        private ImGuiMouseCursor _lastCursor = ImGuiMouseCursor.None;
        private readonly ImGuiCursorAsset _cursorAsset;

        public InputManagerHandler(ImGuiCursorAsset cursorAsset = null)
        {
            _cursorAsset = cursorAsset;
        }

        public void Initialize(ImGuiIOPtr io)
        {
            io.SetBackendPlatformName("Unity Input Manager");
            io.BackendFlags |= ImGuiBackendFlags.HasSetMousePos;
            io.BackendFlags = _cursorAsset ? 
                io.BackendFlags | ImGuiBackendFlags.HasMouseCursors : 
                io.BackendFlags & ~ImGuiBackendFlags.HasMouseCursors;
        }

        public void Update(ImGuiIOPtr io)
        {
            // text input (To any Device)
            var isAnyInputSelected =  EventSystem.current != null && EventSystem.current.currentSelectedGameObject != null &&
                                      EventSystem.current.currentSelectedGameObject.GetComponent<InputField>() != null;
            
            while (!isAnyInputSelected && Event.PopEvent(_charEvent))
                if (_charEvent.rawType == EventType.KeyDown && _charEvent.character != 0 && _charEvent.character != '\n')
                    io.AddInputCharacter(_charEvent.character);
            
            // Keyboard
            foreach (KeyCode keyCode in Enum.GetValues(typeof(KeyCode)))
            {
                if (KeyCodeToImGuiKey(keyCode, out var key))
                {
                    io.AddKeyEvent(key, Input.GetKey(keyCode));
                }
            }
            
            // Mouse
            if (io.WantSetMousePos)
            {
                Input.compositionCursorPos = ImGuiToScreen(new Vector2(io.MousePos.x, io.MousePos.y));
                io.WantSetMousePos = false;
            }
            
            var mousePos = ScreenToImGui(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            io.AddMousePosEvent(mousePos.x, mousePos.y);
            io.AddMouseButtonEvent(0, Input.GetMouseButton(0));
            io.AddMouseButtonEvent(1, Input.GetMouseButton(1));
            io.AddMouseButtonEvent(2, Input.GetMouseButton(2));
            io.AddMouseWheelEvent(Input.mouseScrollDelta.x, Input.mouseScrollDelta.y);

            if (_cursorAsset)
            {
                UpdateCursor(io, ImGui.GetMouseCursor());
            }

            
            // Gamepad
            // TODO: Implement Gamepad support
            
            // Touches
            // TODO: Implement Touches support
        }

        private void UpdateCursor(ImGuiIOPtr io, ImGuiMouseCursor cursor)
        {
            if (io.MouseDrawCursor)
                cursor = ImGuiMouseCursor.None;

            if (_lastCursor == cursor)
                return;
            if ((io.ConfigFlags & ImGuiConfigFlags.NoMouseCursorChange) != 0)
                return;

            _lastCursor = cursor;
            Cursor.visible = cursor != ImGuiMouseCursor.None;
            Cursor.SetCursor(_cursorAsset[cursor].texture, _cursorAsset[cursor].hotspot, CursorMode.Auto);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool KeyCodeToImGuiKey(KeyCode keyCode, out ImGuiKey key)
        {
            if (keyCode == KeyCode.None)
            {
                key = ImGuiKey.None;
                return true;
            }

            key = keyCode switch
            {
                KeyCode.Backspace => ImGuiKey.Backspace,
                KeyCode.Tab => ImGuiKey.Tab,
                KeyCode.Return => ImGuiKey.Enter,
                KeyCode.CapsLock => ImGuiKey.CapsLock,
                KeyCode.Escape => ImGuiKey.Escape,
                KeyCode.Space => ImGuiKey.Space,
                KeyCode.PageUp => ImGuiKey.PageUp,
                KeyCode.PageDown => ImGuiKey.PageDown,
                KeyCode.End => ImGuiKey.End,
                KeyCode.Home => ImGuiKey.Home,
                KeyCode.LeftArrow => ImGuiKey.LeftArrow,
                KeyCode.RightArrow => ImGuiKey.RightArrow,
                KeyCode.UpArrow => ImGuiKey.UpArrow,
                KeyCode.DownArrow => ImGuiKey.DownArrow,
                KeyCode.Print => ImGuiKey.PrintScreen,
                KeyCode.Insert => ImGuiKey.Insert,
                KeyCode.Delete => ImGuiKey.Delete,
                >= KeyCode.Keypad0 and <= KeyCode.Keypad9 => ImGuiKey._0 + (keyCode - KeyCode.Keypad0),
                >= KeyCode.A and <= KeyCode.Z => ImGuiKey.A + (keyCode - KeyCode.A),
                >= KeyCode.Alpha0 and <= KeyCode.Alpha9 => ImGuiKey.Keypad0 + (keyCode - KeyCode.Alpha0),
                KeyCode.KeypadMultiply => ImGuiKey.KeypadMultiply,
                KeyCode.KeypadPlus => ImGuiKey.KeypadAdd,
                KeyCode.KeypadMinus => ImGuiKey.KeypadSubtract,
                KeyCode.KeypadPeriod => ImGuiKey.KeypadDecimal,
                KeyCode.KeypadDivide => ImGuiKey.KeypadDivide,
                >= KeyCode.F1 and <= KeyCode.F15 => ImGuiKey.F1 + (keyCode - KeyCode.F1),
                KeyCode.Numlock => ImGuiKey.NumLock,
                KeyCode.ScrollLock => ImGuiKey.ScrollLock,
                KeyCode.LeftShift => ImGuiKey.ImGuiMod_Shift,
                KeyCode.LeftControl => ImGuiKey.ImGuiMod_Ctrl,
                KeyCode.LeftAlt => ImGuiKey.ImGuiMod_Alt,
                KeyCode.Semicolon => ImGuiKey.Semicolon,
                KeyCode.Equals => ImGuiKey.Equal,
                KeyCode.Comma => ImGuiKey.Comma,
                KeyCode.Minus => ImGuiKey.Minus,
                KeyCode.Period => ImGuiKey.Period,
                KeyCode.Slash => ImGuiKey.Slash,
                KeyCode.BackQuote => ImGuiKey.GraveAccent,
                KeyCode.LeftBracket => ImGuiKey.LeftBracket,
                KeyCode.RightBracket => ImGuiKey.RightBracket,
                KeyCode.Backslash => ImGuiKey.Backslash,
                KeyCode.Quote => ImGuiKey.Apostrophe,
                // KeyCode.Ap => ImGuiKey.AppBack,
                // KeyCode.Br => ImGuiKey.AppForward,
                _ => ImGuiKey.None,
            };

            return key != ImGuiKey.None;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector2 ScreenToImGui(in Vector2 point)
        {
            return new Vector2(point.x, ImGui.GetIO().DisplaySize.y - point.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector2 ImGuiToScreen(in Vector2 point)
        {
            return new Vector2(point.x, ImGui.GetIO().DisplaySize.y - point.y);
        }
    }
}