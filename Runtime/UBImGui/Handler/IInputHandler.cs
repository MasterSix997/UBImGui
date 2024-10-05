using ImGuiNET;

namespace UBImGui
{
    public interface IInputHandler
    {
        public void Initialize(ImGuiIOPtr io);
        public void Update(ImGuiIOPtr io);
    }
}