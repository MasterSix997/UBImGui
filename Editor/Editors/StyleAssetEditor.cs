// using ImGuiNET;
// using UnityEditor;
// using UnityEditor.UIElements;
// using UnityEngine;
// using UnityEngine.UIElements;
//
// namespace UBImGui.Editor
// {
//     [CustomEditor(typeof(ImGuiStyleAsset))]
//     public class StyleAssetEditor : UnityEditor.Editor
//     {
//         public override VisualElement CreateInspectorGUI()
//         {
//             var root = new VisualElement();
//             InspectorElement.FillDefaultInspector(root, serializedObject, this);
//             
//             var colorsFoldout = new Foldout
//             {
//                 text = "Colors",
//                 style =
//                 {
//                     maxHeight = 500,
//                     backgroundColor = new Color(0, 0, 0, 0.1f)
//                 }
//             };
//             colorsFoldout.viewDataKey = "UBImGui.ColorsFoldout";
//             root.Add(colorsFoldout);
//
//             var scrollView = new ScrollView(ScrollViewMode.Vertical);
//             colorsFoldout.Add(scrollView);
//             var styleAsset = (ImGuiStyleAsset)target;
//
//             for (int i = 0; i < (int)ImGuiCol.COUNT; i++)
//             {
//                 var colorField = new ColorField(ImGui.GetStyleColorName((ImGuiCol)i));
//                 colorField.value = styleAsset.Colors[i];
//                 var i1 = i;
//                 colorField.RegisterValueChangedCallback(evt =>
//                 {
//                     styleAsset.Colors[i1] = evt.newValue;
//                     EditorUtility.SetDirty(target);
//                 });
//                 scrollView.Add(colorField);
//             }
//
//             return root;
//         }
//     }
// }