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
        // Adiciona caminhos de bibliotecas para a Unity
        public static void SetupUnityPaths()
        {
            // Configura caminhos baseados no contexto (Editor vs. Build)
            if (Application.isEditor)
            {
                // Configurações específicas para o editor
                ConfigureEditorPaths();
            }
            else
            {
                // Configurações específicas para builds
                ConfigureBuildPaths();
            }
            
            // Registra um manipulador de resolução de caminho personalizado
            LibraryLoader.ResolvePath += CustomUnityPathResolver;
            
            // Interceptor para ajustar o nome da biblioteca se necessário
            LibraryLoader.InterceptLibraryName += AdjustLibraryName;
            
            Debug.Log($"Unity library paths configured. Running in {(Application.isEditor ? "Editor" : "Build")}");
        }
        
        // Configura caminhos específicos para o Editor
        private static void ConfigureEditorPaths()
        {
            // Caminhos para pacotes UPM
            string unityPluginsPath = Path.Combine("Packages", "UBImGui", "Runtime", "Plugins");
            LibraryLoader.CustomLoadFolders.Add(unityPluginsPath);
            
            // Caminhos específicos para plataforma/arquitetura
            string platform = GetPlatformFolderName();
            string architecture = GetArchitectureFolderName();
            
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(unityPluginsPath, "cimgui", platform));
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(unityPluginsPath, "cimgui", platform, architecture));
            
            // Caminhos em Assets/Plugins
            string assetsPluginsPath = Path.Combine("Assets", "Plugins");
            LibraryLoader.CustomLoadFolders.Add(assetsPluginsPath);
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(assetsPluginsPath, platform));
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(assetsPluginsPath, platform, architecture));
            
            Debug.Log($"Editor paths configured: Platform={platform}, Architecture={architecture}");
        }
        
        // Configura caminhos específicos para Builds
        private static void ConfigureBuildPaths()
        {
            string platform = GetPlatformFolderName();
            string architecture = GetCorrectedArchitectureFolderName();
            
            // 1. Diretório do executável principal
            string executablePath = Application.dataPath;
            LibraryLoader.CustomLoadFolders.Add(executablePath);
            
            // 2. Diretório de Plugins no build
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
                    // Android: utiliza o sistema de carregamento específico de Android
                    pluginsPath = Application.dataPath;
                    break;
                    
                case RuntimePlatform.IPhonePlayer:
                    // iOS: A biblioteca nativa estará embutida no aplicativo
                    pluginsPath = Application.dataPath;
                    break;
                    
                case RuntimePlatform.WebGLPlayer:
                    // WebGL: O carregamento de bibliotecas nativas funciona diferente
                    pluginsPath = Application.streamingAssetsPath;
                    break;
                    
                default:
                    // Fallback para o padrão
                    pluginsPath = Path.Combine(Application.dataPath, "Plugins");
                    break;
            }
            
            // Adiciona caminhos relacionados a Plugins
            LibraryLoader.CustomLoadFolders.Add(pluginsPath);
            LibraryLoader.CustomLoadFolders.Add(Path.Combine(pluginsPath, architecture));
            
            // 3. StreamingAssets (para algumas plataformas como Android e WebGL)
            if (Application.platform == RuntimePlatform.Android || 
                Application.platform == RuntimePlatform.WebGLPlayer ||
                Application.platform == RuntimePlatform.IPhonePlayer)
            {
                LibraryLoader.CustomLoadFolders.Add(Application.streamingAssetsPath);
                LibraryLoader.CustomLoadFolders.Add(Path.Combine(Application.streamingAssetsPath, "Plugins"));
                LibraryLoader.CustomLoadFolders.Add(Path.Combine(Application.streamingAssetsPath, "Plugins", platform));
                LibraryLoader.CustomLoadFolders.Add(Path.Combine(Application.streamingAssetsPath, "Plugins", platform, architecture));
            }
            
            // 4. Caminho temporário (para plataformas que extraem bibliotecas)
            if (Application.platform == RuntimePlatform.Android || 
                Application.platform == RuntimePlatform.WebGLPlayer)
            {
                string tempPath = Path.Combine(Application.temporaryCachePath, "Plugins");
                LibraryLoader.CustomLoadFolders.Add(tempPath);
            }
            
            Debug.Log($"Build paths configured: Platform={Application.platform}, Path={pluginsPath}");
            
            // Log de todos os caminhos registrados
            foreach (var path in LibraryLoader.CustomLoadFolders)
            {
                Debug.Log($"Registered library path: {path}");
            }
        }
        
        // Manipulador personalizado para resolver caminhos na Unity
        private static void CustomUnityPathResolver(string libraryName, out string? pathToLibrary)
        {
            pathToLibrary = null;
            
            // Nomes alternativos para tentar (com diferentes prefixos comuns)
            var libraryVariants = new List<string> { 
                libraryName,
                $"lib{libraryName}", // comum em plataformas Unix
            };
            
            // Primeiro, vamos tentar os caminhos que já adicionamos ao CustomLoadFolders
            foreach (var path in LibraryLoader.CustomLoadFolders)
            {
                // Verifica se o diretório existe
                if (!Directory.Exists(path))
                    continue;
                
                foreach (var variant in libraryVariants)
                {
                    string fullPath = Path.Combine(path, variant);
                    if (File.Exists(fullPath))
                    {
                        pathToLibrary = fullPath;
                        Debug.Log($"Biblioteca encontrada: {fullPath}");
                        return;
                    }
                }
            }
            
            // Tratamento específico para Android
            if (Application.platform == RuntimePlatform.Android)
            {
                // Em Android, o sistema carrega automaticamente de lib*.so no APK
                // mas podemos tentar encontrar em caminhos específicos
                string androidLibName = $"lib{libraryName.Replace("lib", "")}";
                
                // Tenta encontrar nas pastas de bibliotecas nativas Android
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
            
            // WebGL precisa de tratamento especial
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                // No WebGL, bibliotecas são carregadas via JavaScript
                Debug.LogWarning($"WebGL: Biblioteca nativa {libraryName} pode precisar ser carregada via JavaScript");
                return;
            }
            
            // Se chegarmos aqui, não encontramos o arquivo
            Debug.LogWarning($"Não foi possível localizar a biblioteca nativa: {libraryName}");
            
            // Último recurso: usar o nome original e deixar o sistema tentar resolver
            pathToLibrary = libraryName;
        }
        
        // Ajusta o nome da biblioteca se necessário
        private static void AdjustLibraryName(ref string libraryName)
        {
            // Remove extensões se já estiverem presentes
            string nameOnly = Path.GetFileNameWithoutExtension(libraryName);
            
            // Tratamento específico para diferentes plataformas
            switch (Application.platform)
            {
                case RuntimePlatform.Android:
                    // Android geralmente precisa de prefixo "lib"
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
                    // iOS/macOS pode precisar de tratamento especial
                    libraryName = nameOnly;
                    break;
                    
                default:
                    // Mantém o nome original para outras plataformas
                    libraryName = nameOnly;
                    break;
            }
            
            Debug.Log($"Adjusted library name: {libraryName}");
        }
        
        // Obtém o nome da pasta da plataforma no formato da Unity
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
        
        // Obtém o nome da pasta da arquitetura no formato da Unity
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
                Debug.Log($"Tentando carregar biblioteca: {libraryName}");
                
                var handle = LibraryLoader.LoadLibrary(() => libraryName, null);
                
                if (handle != IntPtr.Zero)
                {
                    Debug.Log($"Biblioteca '{libraryName}' carregada com sucesso.");
                    return handle;
                }
                else
                {
                    Debug.LogError($"Falha ao carregar biblioteca '{libraryName}': handle é zero");
                    throw new DllNotFoundException($"Não foi possível carregar a biblioteca '{libraryName}'");
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"Erro ao carregar biblioteca '{libraryName}': {ex.Message}\n{ex.StackTrace}");
                
                Debug.LogError("Detalhes do ambiente:");
                Debug.LogError($"  Plataforma: {Application.platform}");
                Debug.LogError($"  Arquitetura: {RuntimeInformation.ProcessArchitecture}");
                Debug.LogError($"  Diretório de dados: {Application.dataPath}");
                Debug.LogError($"  StreamingAssets: {Application.streamingAssetsPath}");
                Debug.LogError($"  Diretório temporário: {Application.temporaryCachePath}");
                
                Debug.LogError("Caminhos de busca registrados:");
                foreach (var path in LibraryLoader.CustomLoadFolders)
                {
                    Debug.LogError($"  {path} (Existe: {Directory.Exists(path)})");
                }
                
                throw;
            }
        }
    }
}