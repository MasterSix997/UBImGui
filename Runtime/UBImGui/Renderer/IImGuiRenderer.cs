using System;
using ImGuiNET;
using UBImGui;
using UnityEngine;

namespace UBImGui
{
    public interface IImGuiRenderer : IDisposable
    {
        public void UpdateBuffers(ImDrawDataPtr drawData);
        public void Render(CommandBufferWrapper cmd, ImDrawDataPtr drawData, Vector2 frameBufferSize);
    }
}