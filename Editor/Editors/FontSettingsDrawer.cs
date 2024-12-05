// using UnityEditor;
// using UnityEditor.UIElements;
// using UnityEngine.UIElements;
//
// namespace UBImGui.Editor
// {
//     [CustomPropertyDrawer(typeof(FontSettings))]
//     public class FontSettingsDrawer : PropertyDrawer
//     {
//         const string EditorStreamingAssetsPath = "Assets/StreamingAssets/";
//         
//         public override VisualElement CreatePropertyGUI(SerializedProperty property)
//         {
//             var root = new VisualElement();
//
//             var fontObjectProperty = property.FindPropertyRelative(nameof(FontSettings.fontObject));
//             var fontPathProperty = property.FindPropertyRelative(nameof(FontSettings.fontPath));
//
//             var headerContainer = new VisualElement();
//             root.Add(headerContainer);
//             
//             var objectField = new ObjectField("Font");
//             objectField.allowSceneObjects = false;
//             objectField.value = fontObjectProperty.objectReferenceValue;
//             objectField.BindProperty(fontObjectProperty);
//             
//             var pathLabel = new Label($"{EditorStreamingAssetsPath}{fontPathProperty.stringValue}");
//             pathLabel.AddToClassList(InspectorElement.disabledUssClassName);
//
//             var invalidPath = new HelpBox($"Font file must be in '{EditorStreamingAssetsPath}' folder.", HelpBoxMessageType.Error);
//             invalidPath.style.display = DisplayStyle.None;
//             if (string.IsNullOrEmpty(GetStreamingAssetPath(fontObjectProperty)))
//                 invalidPath.style.display = DisplayStyle.Flex;
//             
//             objectField.RegisterValueChangedCallback(evt =>
//             {
//                 fontPathProperty.stringValue = GetStreamingAssetPath(fontObjectProperty);
//                 property.serializedObject.ApplyModifiedProperties();
//                 pathLabel.text = $"{EditorStreamingAssetsPath}{fontPathProperty.stringValue}";
//                 if (string.IsNullOrEmpty(fontPathProperty.stringValue))
//                     invalidPath.style.display = DisplayStyle.Flex;
//                 else
//                     invalidPath.style.display = DisplayStyle.None;
//             });
//             headerContainer.Add(objectField);
//             headerContainer.Add(invalidPath);
//             headerContainer.Add(pathLabel);
//             
//             property.NextVisible(true);
//             var depth = property.depth;
//             while (property.NextVisible(false) && property.depth >= depth)
//             {
//                 var propertyField = new PropertyField(property, property.displayName);
//                 propertyField.BindProperty(property);
//                 root.Add(propertyField);
//             }
//
//             return root;
//         }
//         
//         private string GetStreamingAssetPath(SerializedProperty property)
//         {
//             string path = property.objectReferenceValue != null
//                 ? AssetDatabase.GetAssetPath(property.objectReferenceValue.GetInstanceID())
//                 : string.Empty;
//             return path.StartsWith(EditorStreamingAssetsPath) ? path.Substring(EditorStreamingAssetsPath.Length) : string.Empty;
//         }
//     }
// }