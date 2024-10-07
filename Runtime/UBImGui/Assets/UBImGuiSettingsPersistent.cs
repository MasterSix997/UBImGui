using UnityEngine;

namespace UBImGui
{
    internal class UBImGuiSettingsPersistent : ScriptableObject
    {
        public UBImGuiSettings settings;
        
        private const string SettingsPath = "Packages/com.mastersix.ubimgui/Resources/Settings/";
        private const string SettingsPersistentAssetName = "UBImGui Settings Persister.asset";
        private const string SettingsAssetName = "DEFAULT Settings.asset";
        private const string StyleAssetName = "DEFAULT Style.asset";
        
        internal static UBImGuiSettings GetSettings()
        {
            var settings = Resources.Load<UBImGuiSettingsPersistent>("Settings/UBImGui Settings Persister");
            if (settings)
            {
                return settings.settings;
            }

            return UBImGuiSettings.Default();
        }

#if UNITY_EDITOR
        internal static UBImGuiSettingsPersistent GetOrCreateSettingsPersistent()
        {
            var settingsPersistent = UnityEditor.AssetDatabase.LoadAssetAtPath<UBImGuiSettingsPersistent>(SettingsPath + SettingsPersistentAssetName);
            if (!settingsPersistent)
            {
                settingsPersistent = CreateInstance<UBImGuiSettingsPersistent>();
                settingsPersistent.settings = GetOrCreateSettings();
                UnityEditor.AssetDatabase.CreateAsset(settingsPersistent, SettingsPath + SettingsPersistentAssetName);
                UnityEditor.AssetDatabase.SaveAssets();
            }
            return settingsPersistent;
        }

        internal static UBImGuiSettings GetOrCreateSettings()
        {
            var settings = UnityEditor.AssetDatabase.LoadAssetAtPath<UBImGuiSettings>(SettingsPath + SettingsAssetName);
            if (!settings)
            {
                settings = CreateInstance<UBImGuiSettings>();
                settings.IsDefault = true;
                settings.styleAsset = GetOrCreateStyle();
                UnityEditor.AssetDatabase.CreateAsset(settings, SettingsPath + SettingsAssetName);
                UnityEditor.AssetDatabase.SaveAssets();
            }
            return settings;
        }

        internal static ImGuiStyleAsset GetOrCreateStyle()
        {
            var styleAsset = UnityEditor.AssetDatabase.LoadAssetAtPath<ImGuiStyleAsset>(SettingsPath + StyleAssetName);
            if (!styleAsset)
            {
                styleAsset = CreateInstance<ImGuiStyleAsset>();
                UnityEditor.AssetDatabase.CreateAsset(styleAsset, SettingsPath + StyleAssetName);
                UnityEditor.AssetDatabase.SaveAssets();
            }
            return styleAsset;
        }
#endif
    }
}