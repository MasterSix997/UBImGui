#if PACKAGE_INPUT_SYSTEM
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SharpImGui;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UBImGui
{
    public class InputSystemHandler : IInputHandler
    {
        private readonly Queue<char> _textInput = new Queue<char>();
        private ImGuiMouseCursor _lastCursor = ImGuiMouseCursor.None;
        private readonly ImGuiCursorAsset _cursorAsset;
        private Keyboard _keyboard;

        public InputSystemHandler(ImGuiCursorAsset cursorAsset = null)
        {
            _cursorAsset = cursorAsset;
        }

        public void Initialize(ImGuiIOPtr io)
        {
            io.SetBackendPlatformName("Unity Input System");
            io.BackendFlags |= ImGuiBackendFlags.HasSetMousePos;
            io.BackendFlags = _cursorAsset ? 
                io.BackendFlags | ImGuiBackendFlags.HasMouseCursors : 
                io.BackendFlags & ~ImGuiBackendFlags.HasMouseCursors;

            _keyboard = Keyboard.current;
            _keyboard.onTextInput += _textInput.Enqueue ;
        }

        public void Update(ImGuiIOPtr io)
        {
            // text input (To any Device)
            while (_textInput.TryDequeue(out var c))
            {
                io.AddInputCharacter(c);
            }
            
            UpdateKeyboard(io, _keyboard);
            UpdateMouse(io, Mouse.current);
            if (_cursorAsset)
                UpdateCursor(io, ImGui.GetMouseCursor());
            UpdateGamepad(io, Gamepad.current);
            // UpdateTouch(io, Touchscreen.current);
        }

        private void UpdateKeyboard(ImGuiIOPtr io, Keyboard keyboard)
        {
            if (keyboard == null)
                return;
            
            foreach (var inputKey in _keyboard.allKeys)
            {
                if (KeyToImGuiKey(inputKey.keyCode, out var key))
                {
                    io.AddKeyEvent(key, inputKey.isPressed);
                }
            }
        }
        
        private void UpdateMouse(ImGuiIOPtr io, Mouse mouse)
        {
            if (mouse == null)
                return;

            if (io.WantSetMousePos)
            {
                mouse.WarpCursorPosition(ImGuiToScreen(new Vector2(io.MousePos.x, io.MousePos.y)));
                io.WantSetMousePos = false;
            }
            
            var mousePos = ScreenToImGui(mouse.position.ReadValue());
            io.AddMousePosEvent(mousePos.x, mousePos.y);
            io.AddMouseButtonEvent(0, mouse.leftButton.isPressed);
            io.AddMouseButtonEvent(1, mouse.rightButton.isPressed);
            io.AddMouseButtonEvent(2, mouse.middleButton.isPressed);
            io.AddMouseButtonEvent(3, mouse.forwardButton.isPressed);
            io.AddMouseButtonEvent(4, mouse.backButton.isPressed);
            var mouseScroll = mouse.scroll.ReadValue();
            io.AddMouseWheelEvent(mouseScroll.x, mouseScroll.y);
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
        
        private void UpdateGamepad(ImGuiIOPtr io, Gamepad gamepad)
        {
            io.BackendFlags = gamepad != null ? io.BackendFlags | ImGuiBackendFlags.HasGamepad : io.BackendFlags & ~ImGuiBackendFlags.HasGamepad;
            if (gamepad == null || (io.ConfigFlags & ImGuiConfigFlags.NavEnableGamepad) == 0)
                return;
            
            io.AddKeyEvent(ImGuiKey.GamepadStart, gamepad.startButton.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadBack, gamepad.selectButton.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadFaceLeft, gamepad.buttonWest.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadFaceRight, gamepad.buttonEast.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadFaceUp, gamepad.buttonNorth.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadFaceDown, gamepad.buttonSouth.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadDpadLeft, gamepad.dpad.left.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadDpadRight, gamepad.dpad.right.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadDpadUp, gamepad.dpad.up.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadDpadDown, gamepad.dpad.down.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadL1, gamepad.leftShoulder.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadR1, gamepad.rightShoulder.isPressed);
            io.AddKeyAnalogEvent(ImGuiKey.GamepadL2, gamepad.leftTrigger.isPressed, gamepad.leftTrigger.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadR2, gamepad.rightTrigger.isPressed, gamepad.rightTrigger.ReadValue());
            io.AddKeyEvent(ImGuiKey.GamepadL3, gamepad.leftStickButton.isPressed);
            io.AddKeyEvent(ImGuiKey.GamepadR3, gamepad.rightStickButton.isPressed);
            io.AddKeyAnalogEvent(ImGuiKey.GamepadLStickLeft, gamepad.leftStick.left.isPressed, gamepad.leftStick.left.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadLStickRight, gamepad.leftStick.right.isPressed, gamepad.leftStick.right.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadLStickUp, gamepad.leftStick.up.isPressed, gamepad.leftStick.up.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadLStickDown, gamepad.leftStick.down.isPressed, gamepad.leftStick.down.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadRStickLeft, gamepad.rightStick.left.isPressed, gamepad.rightStick.left.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadRStickRight, gamepad.rightStick.right.isPressed, gamepad.rightStick.right.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadRStickUp, gamepad.rightStick.up.isPressed, gamepad.rightStick.up.ReadValue());
            io.AddKeyAnalogEvent(ImGuiKey.GamepadRStickDown, gamepad.rightStick.down.isPressed, gamepad.rightStick.down.ReadValue());
        }
        
        private void UpdateTouch(ImGuiIOPtr io, Touchscreen touch)
        {
            if (touch == null)
                return;
            
            // TODO: Implement Touches support
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool KeyToImGuiKey(Key inputKey, out ImGuiKey key)
        {
            if (inputKey == Key.None)
            {
                key = ImGuiKey.None;
                return true;
            }

            key = inputKey switch
            {
                Key.Backspace => ImGuiKey.Backspace,
                Key.Tab => ImGuiKey.Tab,
                Key.Enter => ImGuiKey.Enter,
                Key.CapsLock => ImGuiKey.CapsLock,
                Key.Escape => ImGuiKey.Escape,
                Key.Space => ImGuiKey.Space,
                Key.PageUp => ImGuiKey.PageUp,
                Key.PageDown => ImGuiKey.PageDown,
                Key.End => ImGuiKey.End,
                Key.Home => ImGuiKey.Home,
                Key.LeftArrow => ImGuiKey.LeftArrow,
                Key.RightArrow => ImGuiKey.RightArrow,
                Key.UpArrow => ImGuiKey.UpArrow,
                Key.DownArrow => ImGuiKey.DownArrow,
                Key.PrintScreen => ImGuiKey.PrintScreen,
                Key.Insert => ImGuiKey.Insert,
                Key.Delete => ImGuiKey.Delete,
                Key.Digit0 => ImGuiKey._0,
                >= Key.Digit1 and <= Key.Digit9 => ImGuiKey._1 + (inputKey - Key.Digit1),
                >= Key.A and <= Key.Z => ImGuiKey.A + (inputKey - Key.A),
                >= Key.Numpad0 and <= Key.Numpad9 => ImGuiKey.Keypad0 + (inputKey - Key.Numpad0),
                Key.NumpadMultiply => ImGuiKey.KeypadMultiply,
                Key.NumpadPlus => ImGuiKey.KeypadAdd,
                Key.NumpadMinus => ImGuiKey.KeypadSubtract,
                Key.NumpadPeriod => ImGuiKey.KeypadDecimal,
                Key.NumpadDivide => ImGuiKey.KeypadDivide,
                >= Key.F1 and <= Key.F12 => ImGuiKey.F1 + (inputKey - Key.F1),
                Key.NumLock => ImGuiKey.NumLock,
                Key.ScrollLock => ImGuiKey.ScrollLock,
                Key.LeftShift => ImGuiKey.ImGuiModShift,
                Key.LeftCtrl => ImGuiKey.ImGuiModCtrl,
                Key.LeftAlt => ImGuiKey.ImGuiModAlt,
                Key.Semicolon => ImGuiKey.Semicolon,
                Key.Equals => ImGuiKey.Equal,
                Key.Comma => ImGuiKey.Comma,
                Key.Minus => ImGuiKey.Minus,
                Key.Period => ImGuiKey.Period,
                Key.Slash => ImGuiKey.Slash,
                Key.Backquote => ImGuiKey.GraveAccent,
                Key.LeftBracket => ImGuiKey.LeftBracket,
                Key.RightBracket => ImGuiKey.RightBracket,
                Key.Backslash => ImGuiKey.Backslash,
                Key.Quote => ImGuiKey.Apostrophe,
                Key.LeftApple => ImGuiKey.AppBack,
                Key.RightApple => ImGuiKey.AppForward,
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

        public void Dispose()
        {
            _keyboard.onTextInput -= _textInput.Enqueue;
        }
    }
}
#endif