using System;
using System.Runtime.InteropServices;
using System.Text;
using AOT;
using ImGuiNET;
using UnityEngine;

namespace UBImGui
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate string GetClipboardTextCallback(void* userData);
        
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SetClipboardTextCallback(void* userData, byte* text);
    
    public unsafe class ClipboardHandler : IDisposable
    {
        public ClipboardHandler()
        {
            _getClipboardText = GetClipboardTextCallback;
            _setClipboardText = SetClipboardTextCallback;
        }
        
        private static GetClipboardTextCallback _getClipboardText;
        private static SetClipboardTextCallback _setClipboardText;

        [MonoPInvokeCallback(typeof(GetClipboardTextCallback))]
        private static string GetClipboardTextCallback(void* userData)
        {
            return GUIUtility.systemCopyBuffer;
        }

        [MonoPInvokeCallback(typeof(SetClipboardTextCallback))]
        private static void SetClipboardTextCallback(void* userData, byte* text)
        {
            GUIUtility.systemCopyBuffer = StringFromPtr(text);
        }


        // Método Assign para configurar as funções de clipboard
        public void Assign(ImGuiIOPtr io)
        {
            io.SetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(_setClipboardText);
            io.GetClipboardTextFn = Marshal.GetFunctionPointerForDelegate(_getClipboardText);
        }

        // Método Unset para remover as funções de clipboard
        public void Unset(ImGuiIOPtr io)
        {
            io.SetClipboardTextFn = IntPtr.Zero;
            io.GetClipboardTextFn = IntPtr.Zero;
        }

        public void Dispose()
        {
            _getClipboardText = null;
            _setClipboardText = null;
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
        
        // Exposição simplificada para definir as funções de clipboard de forma segura com IntPtr
        // public static GetClipboardTextSafeCallback GetClipboardText
        // {
        //     set => _getClipboardText = (userData) =>
        //     {
        //         try { return value(new IntPtr(userData)); }
        //         catch (Exception ex) { Debug.LogException(ex); return null; }
        //     };
        // }
        //
        // public static SetClipboardTextSafeCallback SetClipboardText
        // {
        //     set => _setClipboardText = (userData, text) =>
        //     {
        //         try { value(new IntPtr(userData), StringFromPtr(text)); }
        //         catch (Exception ex) { Debug.LogException(ex); }
        //     };
        // }
    }
}