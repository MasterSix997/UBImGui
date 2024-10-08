using System;
using ImGuiNET;
using UnityEngine;

namespace UBImGui
{
    public interface IImGuiRenderer : IDisposable
    {
        public void UpdateBuffers(ImDrawDataPtr drawData);
        public void Render(in CommandBufferWrapper cmd, ImDrawDataPtr drawData, Vector2 frameBufferSize);
    }
}