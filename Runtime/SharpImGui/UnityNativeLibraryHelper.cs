using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SharpImGui
{
    public static class UnityLibraryHelper
    {
        public static void SetupUnityPaths()
        {
            if (Application.isEditor)
                ConfigureEditorPaths();
            else
                ConfigureBuildPaths();
            
            LibraryLoader.ResolvePath += CustomUnityPathResolver;
            LibraryLoader.InterceptLibraryName += AdjustLibraryName;
#if UBIMGUI_DEV_MODE
            Debug.Log($"Unity library paths configured. Running in {(Application.isEditor ? "Editor" : "Build")}");
#endif
        }
        
        private static void ConfigureEditorPaths()
        {
            string unityPluginsPath = Path.Combine("Packages", "UBImGui", "Runtime", "Plugins");
            LibraryLoader.CustomLoadFolders.Add(unityPluginsPath);
            
            string platform = GetPlatformFolderName();
            string architecture = GetArchitectureFolderName();
            
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(unityPluginsPath, "cimgui", platform));
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(unityPluginsPath, "cimgui", platform, architecture));
            
            string assetsPluginsPath = Path.Combine("Assets", "Plugins");
            LibraryLoader.CustomLoadFolders.Add(assetsPluginsPath);
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(assetsPluginsPath, platform));
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(assetsPluginsPath, platform, architecture));
#if UBIMGUI_DEV_MODE
            Debug.Log($"Editor paths configured: Platform={platform}, Architecture={architecture}");
#endif
        }
        
        private static void ConfigureBuildPaths()
        {
            string platform = GetPlatformFolderName();
            string architecture = GetCorrectedArchitectureFolderName();
            
            string executablePath = Application.dataPath;
            LibraryLoader.CustomLoadFolders.Add(executablePath);
            
            string pluginsPath = "";
            
            switch (Application.platform)
            {
                case RuntimePlatform.WindowsPlayer:
                    // Windows: {ProjectName}_Data/Plugins/x86_64/
                    pluginsPath = Path.Combine(Application.dataPath, "Plugins");
                    break;
                    
                case RuntimePlatform.LinuxPlayer:
                    // Linux: {ProjectName}_Data/Plugins/x86_64/
                    pluginsPath = Path.Combine(Application.dataPath, "Plugins");
                    break;
                    
                case RuntimePlatform.OSXPlayer:
                    // macOS: {ProjectName}.app/Contents/Plugins/
                    pluginsPath = Path.Combine(Application.dataPath, "..", "Plugins");
                    break;
                    
                case RuntimePlatform.Android:
                    pluginsPath = Application.dataPath;
                    break;
                    
                case RuntimePlatform.IPhonePlayer:
                    pluginsPath = Application.dataPath;
                    break;
                    
                case RuntimePlatform.WebGLPlayer:
                    pluginsPath = Application.streamingAssetsPath;
                    break;
                    
                default:
                    pluginsPath = Path.Combine(Application.dataPath, "Plugins");
                    break;
            }
            
            LibraryLoader.CustomLoadFolders.Add(pluginsPath);
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(pluginsPath, architecture));
            
            if (Application.platform == RuntimePlatform.Android || 
                Application.platform == RuntimePlatform.WebGLPlayer ||
                Application.platform == RuntimePlatform.IPhonePlayer)
            {
                LibraryLoader.CustomLoadFolders.Add(Application.streamingAssetsPath);
                LibraryLoader.CustomLoadFolders.Add(Path.Combine(Application.streamingAssetsPath, "Plugins"));
                LibraryLoader.CustomLoadFolders.Add(Path.Combine(Application.streamingAssetsPath, "Plugins", platform));
                LibraryLoader.CustomLoadFolders.Add(Path.Combine(Application.streamingAssetsPath, "Plugins", platform, architecture));
            }
            
            if (Application.platform == RuntimePlatform.Android || 
                Application.platform == RuntimePlatform.WebGLPlayer)
            {
                string tempPath = Path.Combine(Application.temporaryCachePath, "Plugins");
                LibraryLoader.CustomLoadFolders.Add(tempPath);
            }
#if UBIMGUI_DEV_MODE
            Debug.Log($"Build paths configured: Platform={Application.platform}, Path={pluginsPath}");
#endif
            foreach (var path in LibraryLoader.CustomLoadFolders)
            {
                Debug.Log($"Registered library path: {path}");
            }
        }
        
        private static void CustomUnityPathResolver(string libraryName, out string? pathToLibrary)
        {
            pathToLibrary = null;
            
            var libraryVariants = new List<string> { 
                libraryName,
                $"lib{libraryName}",
            };
            
            foreach (var path in LibraryLoader.CustomLoadFolders)
            {
                if (!Directory.Exists(path))
                    continue;
                
                foreach (var variant in libraryVariants)
                {
                    string fullPath = Path.Combine(path, variant);
                    if (File.Exists(fullPath))
                    {
                        pathToLibrary = fullPath;
#if UBIMGUI_DEV_MODE
                        Debug.Log($"Library founded: {fullPath}");
#endif
                        return;
                    }
                }
            }
            
            if (Application.platform == RuntimePlatform.Android)
            {
                string androidLibName = $"lib{libraryName.Replace("lib", "")}";
                
                if (androidLibName.EndsWith(".so"))
                {
                    pathToLibrary = androidLibName;
                    return;
                }
                else 
                {
                    pathToLibrary = $"{androidLibName}.so";
                    return;
                }
            }
            
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                Debug.LogWarning($"WebGL: Native library {libraryName} needs be loaded by JavaScript");
                return;
            }
            
            Debug.LogWarning($"It was not possible to locate the native library: {libraryName}");
            
            pathToLibrary = libraryName;
        }
        
        private static void AdjustLibraryName(ref string libraryName)
        {
            string nameOnly = Path.GetFileNameWithoutExtension(libraryName);
            
            switch (Application.platform)
            {
                case RuntimePlatform.Android:
                    if (!nameOnly.StartsWith("lib"))
                    {
                        libraryName = $"lib{nameOnly}";
                    }
                    else 
                    {
                        libraryName = nameOnly;
                    }
                    break;
                    
                case RuntimePlatform.IPhonePlayer:
                case RuntimePlatform.OSXPlayer:
                    libraryName = nameOnly;
                    break;
                    
                default:
                    libraryName = nameOnly;
                    break;
            }
#if UBIMGUI_DEV_MODE
            Debug.Log($"Adjusted library name: {libraryName}");
#endif
        }
        
        private static string GetPlatformFolderName()
        {
            if (Application.platform == RuntimePlatform.WindowsEditor || 
                Application.platform == RuntimePlatform.WindowsPlayer)
                return "win";
            else if (Application.platform == RuntimePlatform.LinuxEditor || 
                    Application.platform == RuntimePlatform.LinuxPlayer)
                return "linux";
            else if (Application.platform == RuntimePlatform.OSXEditor || 
                    Application.platform == RuntimePlatform.OSXPlayer)
                return "osx";
            else if (Application.platform == RuntimePlatform.Android)
                return "android";
            else if (Application.platform == RuntimePlatform.IPhonePlayer)
                return "ios";
            else if (Application.platform == RuntimePlatform.WebGLPlayer)
                return "webgl";
            
            return "unknown";
        }
        
        private static string GetArchitectureFolderName()
        {
            return RuntimeInformation.ProcessArchitecture switch
            {
                Architecture.X86 => "x86",
                Architecture.X64 => "x64",
                Architecture.Arm => "arm",
                Architecture.Arm64 => "arm64",
                _ => "unknown",
            };
        }

        private static string GetCorrectedArchitectureFolderName()
        {
            if (Application.platform == RuntimePlatform.WindowsEditor ||
                Application.platform == RuntimePlatform.WindowsPlayer)
            {
                return RuntimeInformation.ProcessArchitecture switch
                {
                    Architecture.X86 => "x86",
                    Architecture.X64 => "x86_64",
                    Architecture.Arm => "arm",
                    Architecture.Arm64 => "arm64",
                    _ => "unknown",
                };
            }

            return GetPlatformFolderName();
        }
        
        public static IntPtr LoadLibraryWithErrorHandling(string libraryName)
        {
            try
            {
#if UBIMGUI_DEV_MODE
                Debug.Log($"Trying to load: {libraryName}");
#endif
                
                var handle = LibraryLoader.LoadLibrary(() => libraryName, null);
                
                if (handle != IntPtr.Zero)
                {
#if UBIMGUI_DEV_MODE
                    Debug.Log($"Library '{libraryName}' successful loaded.");
#endif
                    return handle;
                }

                Debug.LogError($"Failed on load library '{libraryName}': handle is zero");
                throw new DllNotFoundException($"Was not possible to load the library '{libraryName}'");
            }
            catch (Exception ex)
            {
                Debug.LogError($"Error on load library '{libraryName}': {ex.Message}\n{ex.StackTrace}");
                
                Debug.LogError("Details:");
                Debug.LogError($"  Platform: {Application.platform}");
                Debug.LogError($"  Architecture: {RuntimeInformation.ProcessArchitecture}");
                Debug.LogError($"  Data path: {Application.dataPath}");
                Debug.LogError($"  StreamingAssets: {Application.streamingAssetsPath}");
                Debug.LogError($"  Temp dir: {Application.temporaryCachePath}");
                
                Debug.LogError("Registered custom folders:");
                foreach (var path in LibraryLoader.CustomLoadFolders)
                {
                    Debug.LogError($"  {path} (Exists: {Directory.Exists(path)})");
                }
                
                throw;
            }
        }
    }
}