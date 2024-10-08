using UnityEngine;

namespace UBImGui
{
    [CreateAssetMenu(fileName = "ImGui Font Atlas", menuName = "Dear ImGui/Font Atlas")]
    public class ImGuiFontAsset : ScriptableObject
    {
        public FontSettings[] fontSettings;
    }
}