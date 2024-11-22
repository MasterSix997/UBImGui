using SharpImgui;
using UnityEngine;

namespace UBImGui
{
    [CreateAssetMenu(fileName = "UBImGui Settings", menuName = "UB ImGui/Settings")]
    public class UBImGuiSettings : ScriptableObject
    {
        public enum InputMode
        {
            InputManager,
#if PACKAGE_INPUT_SYSTEM
            InputSystem
#endif
        }
        public ImGuiStyleAsset styleAsset;
        public ImGuiFontAsset fontAsset;
        public ImGuiCursorAsset cursorAsset;
        
        [Header("UB ImGui Settings")]
        public bool renderInFront;
        public InputMode inputMode;

        [Header("Dear ImGui Settings")] 
        public DearImGuiIOConfig dearImGuiConfig;
        
        [TextArea(3, 20)]
        public string iniSettings;
        public uint iniSettingsSize;

        public void ApplyTo(ImGuiStylePtr style, ImGuiIOPtr io)
        {
            styleAsset?.ApplyTo(style);
            dearImGuiConfig.ApplyTo(io);
        }

        public void Reset()
        {
            renderInFront = false;
            inputMode = InputMode.InputManager;
            dearImGuiConfig.Reset();
            iniSettings = "";
            iniSettingsSize = 0;
        }

        public void ResetRecursive()
        {
            Reset();
            styleAsset.Reset();
        }
        
        public static UBImGuiSettings CreateTemporary()
        {
            var asset = CreateInstance<UBImGuiSettings>();
            asset.Reset();
            asset.IsTemp = true;
            asset.styleAsset = ImGuiStyleAsset.Default();
            return asset;
        }

        internal bool IsDefault;
        internal bool IsTemp;
        internal bool IsDirt;
    }
}