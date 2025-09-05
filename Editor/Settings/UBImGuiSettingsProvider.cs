using System.Collections.Generic;
using SharpImGui;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace UBImGui.Editor
{
    public class UBImGuiSettingsProvider : SettingsProvider
    {
        // private SerializedObject _serializedSettings;

        private UBImGuiSettingsProvider(string path, SettingsScope scopes = SettingsScope.Project, IEnumerable<string> keywords = null) : base(path, scopes, keywords) { }

        public override void OnActivate(string searchContext, VisualElement rootElement)
        {
            // _serializedSettings = UBImGuiSettingsPersistent.GetSerializedSettings();
            
            var header = new VisualElement
            {
                name = "UBImGui Project Settings",
                style =
                {
                    marginBottom = 8,
                    minHeight = 20,
                    paddingLeft = 11,
                    flexDirection = FlexDirection.Row,
                }
            };
            rootElement.Add(header);

            var headerTitle = new Label("<b>UB ImGui<b>")
            {
                style =
                {
                    fontSize = 18
                }
            };
            header.Add(headerTitle);
            
            var settingsSection = new ScrollView(ScrollViewMode.VerticalAndHorizontal);
            rootElement.Add(settingsSection);
            var settingsPersistent = UBImGuiSettingsPersistent.GetOrCreateSettingsPersistent();

            var settingsFoldout = new Foldout
            {
                text = "Settings"
            };

            var settingsPicker = new ObjectField();
            settingsPicker.objectType = typeof(UBImGuiSettings);
            settingsPicker.value = settingsPersistent.settings;
            settingsPicker.RegisterValueChangedCallback(evt =>
            {
                var settings = (UBImGuiSettings)evt.newValue;
                if (!settings)
                {
                    settings = UBImGuiSettingsPersistent.GetOrCreateSettings();
                    settingsPicker.SetValueWithoutNotify(settings);
                }

                settingsPersistent.settings = settings;
                settingsFoldout.Clear();
                CreateSettingElements(settingsFoldout, settingsPersistent.settings);
            });
            settingsSection.Add(settingsPicker);

            CreateSettingElements(settingsFoldout, settingsPersistent.settings);
            settingsSection.Add(settingsFoldout);
            
            base.OnActivate(searchContext, rootElement);
        }

        // private VisualElement Section(VisualElement root, string title)
        // {
        //     var container = new VisualElement
        //     {
        //         name = $"{title} Project Settings",
        //         style =
        //         {
        //             fontSize = 12,
        //             paddingBottom = 12,
        //             paddingLeft = 12,
        //             paddingRight = 3,
        //         }
        //     };
        //     root.Add(container);
        //     // var shapesTitle = new Label($"<b>{title}<b>")
        //     // {
        //     //     style = { fontSize = 14 }
        //     // };
        //     // container.Add(shapesTitle);
        //     
        //     return container;
        // }

        private void CreateSettingElements(VisualElement root, UBImGuiSettings settings)
        {
            if (!settings)
                return;

            var styleSection = new VisualElement();
            root.Add(styleSection);

            var styleFoldout = new Foldout
            {
                text = "Style",
                value = false
            };

            var stylePicker = new ObjectField();
            stylePicker.objectType = typeof(ImGuiStyleAsset);
            stylePicker.value = settings.styleAsset;
            stylePicker.RegisterValueChangedCallback(evt =>
            {
                if (settings.IsDefault)
                {
                    var styleAsset = (ImGuiStyleAsset)evt.newValue;
                    if (!styleAsset)
                    {
                        styleAsset = UBImGuiSettingsPersistent.GetOrCreateStyle();
                        stylePicker.SetValueWithoutNotify(styleAsset);
                    }

                    settings.styleAsset = styleAsset;
                }
                else
                    settings.styleAsset = evt.newValue ? (ImGuiStyleAsset)evt.newValue : null;
                
                styleFoldout.Clear();
                CreateStyleElements(styleFoldout, settings.styleAsset);
            });
            styleSection.Add(stylePicker);

            CreateStyleElements(styleFoldout, settings.styleAsset);
            styleSection.Add(styleFoldout);
            
            //Settings
            var iterator = new SerializedObject(settings).GetIterator();
            iterator.NextVisible(true);
            iterator.NextVisible(false);
            while (iterator.NextVisible(false))
            {
                var propertyField = new PropertyField(iterator, iterator.displayName);
                propertyField.BindProperty(iterator);
                root.Add(propertyField);
            }
        }

        private void CreateStyleElements(VisualElement root, ImGuiStyleAsset styleAsset)
        {
            if (!styleAsset)
                return;

            var iterator = new SerializedObject(styleAsset).GetIterator();
            iterator.NextVisible(true);
            while (iterator.NextVisible(false))
            {
                var propertyField = new PropertyField(iterator, iterator.displayName);
                propertyField.BindProperty(iterator);
                root.Add(propertyField);
            }
            
            var colorsFoldout = new Foldout
            {
                text = "Colors",
                style =
                {
                    maxHeight = 500,
                    backgroundColor = new Color(0, 0, 0, 0.1f)
                },
                value = false
            };
            root.Add(colorsFoldout);
            
            var scrollView = new ScrollView(ScrollViewMode.Vertical);
            colorsFoldout.Add(scrollView);
            
            for (int i = 0; i < (int)ImGuiCol.COUNT; i++)
            {
                var colorField = new ColorField(ImGui.GetStyleColorName((ImGuiCol)i));
                colorField.value = styleAsset.Colors[i];
                var i1 = i;
                colorField.RegisterValueChangedCallback(evt => styleAsset.Colors[i1] = evt.newValue);
                scrollView.Add(colorField);
            }
        }

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new UBImGuiSettingsProvider("Project/UB ImGui")
            {
                keywords = new[] { "draw", "debug", "drawing", "imgui", "ui", "Dear", "UB", "Unity", "Best"}
            };
        }
    }
}