using ImGuiNET;
using UnityEngine;

namespace UBImGui
{
    [CreateAssetMenu(fileName = "UBImGui Settings", menuName = "UB ImGui/Settings")]
    public class UBImGuiSettings : ScriptableObject
    {
        public ImGuiStyleAsset styleAsset;
        public ImGuiFontAsset fontAsset;
        public ImGuiCursorAsset cursorAsset;
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
        
        public static UBImGuiSettings CreateTemporary()
        {
            var asset = CreateInstance<UBImGuiSettings>();
            asset.IsTemp = true;
            asset.styleAsset = ImGuiStyleAsset.Default();
            return asset;
        }

        internal bool IsDefault;
        internal bool IsTemp;
        internal bool IsDirt;
    }
}