using System;
using System.Runtime.CompilerServices;
using ImGuiNET;
using UnityEngine;

namespace UBImGui
{
    public interface IInputHandler : IDisposable
    {
        Vector2 MouseOffset { get; set; }
        
        public void Initialize(ImGuiIOPtr io);
        public void Update(ImGuiIOPtr io);
        
        void IDisposable.Dispose() { }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector2 ScreenToImGui(in Vector2 point, in Vector2 offset = default)
        {
            return new Vector2(point.x, ImGui.GetIO().DisplaySize.y - point.y) + offset;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Vector2 ImGuiToScreen(in Vector2 point, in Vector2 offset = default)
        {
            return new Vector2(point.x, ImGui.GetIO().DisplaySize.y - point.y) + offset;
        }
    }
}