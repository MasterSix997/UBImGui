using ImGuiNET;
using UnityEngine;

namespace UBImGui
{
    [CreateAssetMenu(fileName = "UBImGui Settings", menuName = "Dear ImGui/Settings")]
    public class UBImGuiSettings : ScriptableObject
    {
        public ImGuiStyleAsset styleAsset;
        public ImGuiFontAsset fontAsset;
        public bool renderInFront;
        
        [TextArea(3, 20)]
        public string iniSettings;
        public uint iniSettingsSize;

        public void ApplyTo(ImGuiStylePtr style)
        {
            styleAsset?.ApplyTo(style);
        }

        public void Reset()
        {
            renderInFront = false;
        }

        public void ResetRecursive()
        {
            Reset();
            styleAsset.Reset();
            // fontAsset.Res
        }
        
        public static UBImGuiSettings Default()
        {
            var asset = CreateInstance<UBImGuiSettings>();
            asset.IsDefault = true;
            asset.styleAsset = ImGuiStyleAsset.Default();
            return asset;
        }

        internal bool IsDefault;
        internal bool IsDirt;
    }
}