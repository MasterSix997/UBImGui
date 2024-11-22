using System;
using SharpImgui;

namespace UBImGui
{
    public interface IInputHandler : IDisposable
    {
        public void Initialize(ImGuiIOPtr io);
        public void Update(ImGuiIOPtr io);
        
        void IDisposable.Dispose() { }
    }
}