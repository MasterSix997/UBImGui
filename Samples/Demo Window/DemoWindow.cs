using ImGuiNET;
using UnityEngine;

namespace UBImGui.Samples
{
    public class DemoWindow : MonoBehaviour
    {
        private void OnEnable()
        {
            ImGui.Layout += ImGuiOnLayout;
        }
        
        private void OnDisable()
        {
            ImGui.Layout -= ImGuiOnLayout;
        }

        private void ImGuiOnLayout()
        {
            ImGui.ShowDemoWindow();
        }
    }
}