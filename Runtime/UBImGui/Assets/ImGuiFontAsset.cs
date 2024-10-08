using UnityEngine;

namespace UBImGui
{
    [CreateAssetMenu(fileName = "ImGui Font Atlas", menuName = "UB ImGui/Font Atlas")]
    public class ImGuiFontAsset : ScriptableObject
    {
        public FontSettings[] fontSettings;
    }
}