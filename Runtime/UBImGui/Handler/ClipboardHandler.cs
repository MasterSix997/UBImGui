using System;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using SharpImGui;
using UnityEngine;

namespace UBImGui
{
    public unsafe class ClipboardHandler : IDisposable
    {
        // Store bytes to free later
        private static byte* _lastClipboardText = null;
        
        [MonoPInvokeCallback(typeof(Platform_GetClipboardTextFnDelegate))]
        private static byte* GetClipboardTextCallback(IntPtr ctx)
        {
            _lastClipboardText = PtrFromString(GUIUtility.systemCopyBuffer);
            return _lastClipboardText;
        }

        [MonoPInvokeCallback(typeof(Platform_GetClipboardTextFnDelegate))]
        private static void SetClipboardTextCallback(IntPtr ctx, byte* text)
        {
            GUIUtility.systemCopyBuffer = StringFromPtr(text);
        }
        
        public void Assign(ImGuiPlatformIOPtr io)
        {
            io.Platform_ClipboardUserData = IntPtr.Zero;
            io.Platform_SetClipboardTextFn = SetClipboardTextCallback;
            io.Platform_GetClipboardTextFn = GetClipboardTextCallback;
        }

        public void Unset(ImGuiPlatformIOPtr io)
        {
            io.NativePtr->Platform_SetClipboardTextFn = IntPtr.Zero;
            io.NativePtr->Platform_GetClipboardTextFn = IntPtr.Zero;
        }

        public void Dispose()
        {
            if (_lastClipboardText != null)
            {
                Marshal.FreeHGlobal(new IntPtr(_lastClipboardText));
                _lastClipboardText = null;
            }
        }
        
        private static string StringFromPtr(byte* ptr)
        {
            var length = 0;
            while (ptr[length] != 0)
            {
                length++;
            }
            return Encoding.UTF8.GetString(ptr, length);
        }
        
        private static byte* PtrFromString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return null;
            
            var bytes = Encoding.UTF8.GetBytes(str);
            var ptr = (byte*)Marshal.AllocHGlobal(bytes.Length + 1);
            Marshal.Copy(bytes, 0, new IntPtr(ptr), bytes.Length);
            ptr[bytes.Length] = 0;
            return ptr;
        }
    }
}