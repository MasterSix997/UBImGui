#if UBIMGUI_DEV_MODE
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace UBImGui.Editor
{
    public class SystemNumericsReplacer : EditorWindow
    {
        private string _folderPath = "Assets/DearImGui";
        private string _log = "Click Replace in Scripts to start.";
        private bool _isProcessing = false;
        private float _progress = 0f;
        private string _progressMessage = "";

        private Stack<Dictionary<string, string>> _undoFilesStack = new();

        [MenuItem("Tools/UBImGui/Replace System.Numerics with UnityEngine types")]
        public static void ShowWindow()
        {
            GetWindow<SystemNumericsReplacer>("SystemNumerics Replace");
        }

        private void OnGUI()
        {
            GUILayout.Label("Replace System.Numerics with UnityEngine types", EditorStyles.boldLabel);
            
            GUILayout.BeginHorizontal();
            _folderPath = EditorGUILayout.TextField("Folder Path", _folderPath);

            if (GUILayout.Button("Select Folder", GUILayout.MaxWidth(100)) && !_isProcessing)
            {
                string selectedPath = EditorUtility.OpenFolderPanel("Select Folder", _folderPath, "");
                if (!string.IsNullOrEmpty(selectedPath))
                {
                    _folderPath = selectedPath;
                }
            }
            GUILayout.EndHorizontal();

            EditorGUI.BeginDisabledGroup(_isProcessing);

            if (GUILayout.Button("Replace in Scripts") && !_isProcessing)
            {
                ReplaceInScriptsAsync(_folderPath);
            }

            GUILayout.BeginHorizontal();
            if (GUILayout.Button($"Undo ({_undoFilesStack.Count})") && !_isProcessing)
            {
                UndoReplacements();
            }
            
            if (GUILayout.Button($"Refresh Unity") && !_isProcessing)
            {
                AssetDatabase.Refresh();
            }
            GUILayout.EndHorizontal();

            EditorGUI.EndDisabledGroup();

            EditorGUILayout.HelpBox(_log, MessageType.Info);
        }

        private async void ReplaceInScriptsAsync(string folderPath)
        {
            _isProcessing = true;
            _log = "Processing...";

            try
            {
                var backupFiles = await Task.Run(() => ReplaceInScripts(folderPath));
                if (backupFiles != null)
                {
                    _undoFilesStack.Push(backupFiles);
                }
            }
            catch (System.Exception ex)
            {
                _log = $"Error: {ex.Message}";
            }
            finally
            {
                _isProcessing = false;
                EditorUtility.ClearProgressBar();
            }
        }

        private Dictionary<string, string> ReplaceInScripts(string folderPath)
        {
            var files = Directory.GetFiles(folderPath, "*.cs", SearchOption.AllDirectories);
            var replacementsCount = 0;
            
            var backupFiles = new Dictionary<string, string>();
            
            for (int i = 0; i < files.Length; i++)
            {
                var file = files[i];
                var content = File.ReadAllText(file);

                backupFiles.TryAdd(file, content);

                var newContent = Regex.Replace(content, @"\bSystem\.Numerics\b", "UnityEngine");

                //Find Variables
                newContent = Regex.Replace(newContent, @"(\bVector2\b|\bVector3\b|\bVector4\b)\s+(\w+)", match => match.Value);

                newContent = Regex.Replace(newContent, $@"(\w+)\.X\b", "$1.x");
                newContent = Regex.Replace(newContent, $@"(\w+)\.Y\b", "$1.y");
                newContent = Regex.Replace(newContent, $@"(\w+)\.Z\b", "$1.z");
                newContent = Regex.Replace(newContent, $@"(\w+)\.W\b", "$1.w");

                if (newContent != content)
                {
                    File.WriteAllText(file, newContent);
                    replacementsCount++;
                }
                else
                {
                    backupFiles.Remove(file);
                }

                _progress = (float)(i + 1) / files.Length;
                _progressMessage = $"Processing {Path.GetFileName(file)}";
                
                EditorApplication.update += UpdateProgressBar;
            }

            if (replacementsCount == 0)
            {
                _log = "No replacements found in scripts.";
                return null;
            }

            _log = $"Replaced in {replacementsCount} scripts.";
            return backupFiles;
        }

        private void UpdateProgressBar()
        {
            EditorUtility.DisplayProgressBar("Replacing System.Numerics", _progressMessage, _progress);

            if (_progress >= 1f)
            {
                EditorUtility.ClearProgressBar();
                EditorApplication.update -= UpdateProgressBar;
            }
        }

        private void UndoReplacements()
        {
            var undoCount = 0;
            
            var backupFiles = _undoFilesStack.Pop();

            foreach (var file in backupFiles.Where(file => File.Exists(file.Key)))
            {
                File.WriteAllText(file.Key, file.Value);
                undoCount++;
            }

            _log = undoCount > 0 ? $"Undo successful for {undoCount} files." : "No files to undo.";
        }
    }
}
#endif