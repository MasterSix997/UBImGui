using ImGuiNET;
using UnityEngine;

namespace UBImGui.Samples
{
    public class SimpleWindow : MonoBehaviour
    {
        private void OnEnable()
        {
            ImGui.Layout += OnLayout;
        }

        private void OnDisable()
        {
            ImGui.Layout -= OnLayout;
        }

        // Fields to be used in the window
        private bool enableFields;
        // As this string is not serialized (public or [SerializeField]), it is necessary to initialize it before using
        private string textValue = "";
        private float sliderValue;
        private Vector3 vector3Value;
        
        private void OnLayout()
        {
            // Begin a new window called "Simple Window"
            // If the window is collapsed, there is no need to create widgets (no need to call ImGui.End())
            if (ImGui.Begin("Simple Window"))
            {
                // Add some text to the window
                ImGui.Text("Im a text");
                
                // If the button is clicked, log a message to the console
                if (ImGui.Button("Click Me!"))
                {
                    Debug.Log("Thanks :)");
                }

                // Add a checkbox to enable/disable fields
                ImGui.Checkbox("Toggle Fields", ref enableFields);

                // If fields are enabled, add widgets
                if (enableFields)
                {
                    // Add input fields for text, slider, and vector3
                    ImGui.InputText("Text Field", ref textValue, 100);
                    ImGui.SliderFloat("Slider Field", ref sliderValue, 0, 100);
                    ImGui.SliderFloat3("Vector3 Field", ref vector3Value, -10, 10);
                }

                // End the "Simple Window"
                ImGui.End();
            }
        }
    }
}
