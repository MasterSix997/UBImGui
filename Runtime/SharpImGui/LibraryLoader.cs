using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
#if ANDROID
    using Android.Content.PM;
#endif

namespace SharpImGui
{
    public enum TargetPlatform
    {
        Unknown = 0,
        FreeBSD = 1 << 0,
        Linux = 1 << 1,
        OSX = 1 << 2,
        Windows = 1 << 3,
        Android = 1 << 4,
        IOS = 1 << 5,
        Tizen = 1 << 6,
        ChromeOS = 1 << 7,
        WebAssembly = 1 << 8,
        Solaris = 1 << 9,
        WatchOS = 1 << 10,
        TVO = 1 << 11,
        Any = FreeBSD | Linux | OSX | Windows | Android | IOS | Tizen | ChromeOS | WebAssembly | Solaris | WatchOS | TVO
    }

    public delegate void ResolvePathHandler(string libraryName, out string? pathToLibrary);

    public delegate void LibraryNameInterceptor(ref string libraryName);

    public static class LibraryLoader
    {
        public static OSPlatform FreeBSD { get; } = OSPlatform.Create("FREEBSD");
        public static OSPlatform Linux { get; } = OSPlatform.Create("LINUX");
        public static OSPlatform OSX { get; } = OSPlatform.Create("OSX");
        public static OSPlatform Windows { get; } = OSPlatform.Create("WINDOWS");
        public static OSPlatform Android { get; } = OSPlatform.Create("ANDROID");
        public static OSPlatform IOS { get; } = OSPlatform.Create("IOS");
        public static OSPlatform Tizen { get; } = OSPlatform.Create("TIZEN");
        public static OSPlatform ChromeOS { get; } = OSPlatform.Create("CHROMEOS");
        public static OSPlatform WebAssembly { get; } = OSPlatform.Create("WEBASSEMBLY");
        public static OSPlatform Solaris { get; } = OSPlatform.Create("SOLARIS");
        public static OSPlatform WatchOS { get; } = OSPlatform.Create("WATCHOS");
        public static OSPlatform TVOS { get; } = OSPlatform.Create("TVOS");

        public static List<string> CustomLoadFolders { get; } = new List<string>();

        public static ResolvePathHandler? ResolvePath;

        public static LibraryNameInterceptor? InterceptLibraryName;

        // Cache para os caminhos encontrados, para evitar buscas repetidas
        private static Dictionary<string, string> _cachedPaths = new Dictionary<string, string>();

        public static string GetExtension()
        {
            // Default extension based on platform
            if (RuntimeInformation.IsOSPlatform(Windows))
            {
                return ".dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSX))
            {
                return ".dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(Linux))
            {
                return ".so";
            }
            else if (RuntimeInformation.IsOSPlatform(Android))
            {
                return ".so";
            }
            else if (RuntimeInformation.IsOSPlatform(IOS))
            {
                return ".dylib"; // iOS also uses .dylib for dynamic libraries
            }
            else if (RuntimeInformation.IsOSPlatform(FreeBSD))
            {
                return ".so";
            }
            else if (RuntimeInformation.IsOSPlatform(TVOS))
            {
                return ".dylib"; // tvOS uses the same dynamic library extension as iOS
            }
            else if (RuntimeInformation.IsOSPlatform(WatchOS))
            {
                return ".dylib"; // watchOS also uses .dylib
            }
            else if (RuntimeInformation.IsOSPlatform(Solaris))
            {
                return ".so";
            }
            else if (RuntimeInformation.IsOSPlatform(WebAssembly))
            {
                return ".wasm";
            }
            else if (RuntimeInformation.IsOSPlatform(Tizen))
            {
                return ".so";
            }
            else if (RuntimeInformation.IsOSPlatform(ChromeOS))
            {
                return ".so";
            }

            // Default to .so if no platform matches
            return ".so";
        }

        public delegate string LibraryNameCallback();

        public delegate string LibraryExtensionCallback();

        public static IntPtr LoadLibrary(LibraryNameCallback libraryNameCallback, LibraryExtensionCallback? libraryExtensionCallback)
        {
            var libraryName = libraryNameCallback();

            InterceptLibraryName?.Invoke(ref libraryName);

            var extension = libraryExtensionCallback != null ? libraryExtensionCallback() : GetExtension();

            if (!libraryName.EndsWith(extension, StringComparison.OrdinalIgnoreCase))
            {
                libraryName += extension;
            }

            var osPlatform = GetOSPlatform();
            var architecture = GetArchitecture();
            
            // Verificar se o caminho já está em cache
            string cacheKey = $"{osPlatform}-{architecture}-{libraryName}";
            if (!_cachedPaths.TryGetValue(cacheKey, out var libraryPath))
            {
                libraryPath = GetNativeAssemblyPath(osPlatform, architecture, libraryName);
                _cachedPaths[cacheKey] = libraryPath;
            }
            
            Debug.Log($"[LibraryLoader] Carregando biblioteca: {libraryName}, Extension: {extension}, OS: {osPlatform}, Arch: {architecture}, Caminho: {libraryPath}");

            var handle = NativeLibrary.Load(libraryPath);

            if (handle == IntPtr.Zero)
            {
                throw new DllNotFoundException($"Não foi possível carregar a biblioteca '{libraryName}'. Caminho tentado: {libraryPath}");
            }

            return handle;
        }

        private static string GetNativeAssemblyPath(string osPlatform, string architecture, string libraryName)
        {
            // 1. Verificar se o usuário definiu um resolver personalizado
            if (ResolvePath != null)
            {
                ResolvePath.Invoke(libraryName, out var pathToLibrary);
                if (pathToLibrary != null)
                {
                    Debug.Log($"[LibraryLoader] Caminho resolvido pelo ResolvePath: {pathToLibrary}");
                    return pathToLibrary;
                }
            }

            // 2. Localização base - diferentes em cada plataforma
            string baseDir;

#if UNITY_ANDROID && !UNITY_EDITOR
            // No Android, use o diretório de bibliotecas nativas da aplicação
            baseDir = UnityEngine.Application.dataPath + "!/lib/";
            Debug.Log($"[LibraryLoader] Android base directory: {baseDir}");
#elif UNITY_IOS && !UNITY_EDITOR
            // No iOS, as bibliotecas são empacotadas no app bundle
            baseDir = UnityEngine.Application.dataPath + "/Frameworks/";
            Debug.Log($"[LibraryLoader] iOS base directory: {baseDir}");
#else
            // Editor e outras plataformas
            baseDir = UnityEngine.Application.dataPath;
            Debug.Log($"[LibraryLoader] Base directory: {baseDir}");
#endif

            // 3. Criar uma lista de caminhos potenciais para verificar
            var paths = new List<string>
            {
                 // Caminho direto com o nome da biblioteca
                 Path.Combine(baseDir, libraryName),
                 
                 // Caminhos padrões da Unity
                 Path.Combine(baseDir, "Plugins", libraryName),
                 Path.Combine(baseDir, "Plugins", osPlatform, libraryName),
                 Path.Combine(baseDir, "Plugins", $"{osPlatform}-{architecture}", libraryName),
                 
                 // Estrutura de tempo de execução .NET
                 Path.Combine(baseDir, "runtimes", osPlatform, "native", libraryName),
                 Path.Combine(baseDir, "runtimes", $"{osPlatform}-{architecture}", "native", libraryName),
                 
                 // Diretório StreamingAssets (útil para conteúdo móvel)
                 Path.Combine(UnityEngine.Application.streamingAssetsPath, libraryName),
                 Path.Combine(UnityEngine.Application.streamingAssetsPath, "Plugins", libraryName),
                 Path.Combine(UnityEngine.Application.streamingAssetsPath, "Plugins", osPlatform, libraryName),
                 
                 // Para o editor, verifique em mais alguns lugares comuns
#if UNITY_EDITOR
                 Path.Combine(UnityEngine.Application.dataPath, "Editor", "Plugins", libraryName),
                 Path.Combine(UnityEngine.Application.dataPath, "..", "Plugins", libraryName),
                 Path.Combine(UnityEngine.Application.dataPath, "..", "Builds", osPlatform, libraryName),
#endif
            };

            // 4. Adicionar caminhos personalizados do usuário
            foreach (var customPath in CustomLoadFolders)
            {
                if (IsPathFullyQualified(customPath))
                {
                    paths.Add(Path.Combine(customPath, libraryName));
                }
                else
                {
                    paths.Add(Path.Combine(baseDir, customPath, libraryName));
                }
            }

            // 5. Verificar cada caminho e retornar o primeiro existente
            foreach (var path in paths)
            {
                if (File.Exists(path))
                {
                    Debug.Log($"[LibraryLoader] Biblioteca encontrada em: {path}");
                    return path;
                }
            }

            // 6. Se não encontrar em nenhum caminho específico, dependa de bibliotecas do sistema
            Debug.LogWarning($"[LibraryLoader] Biblioteca não encontrada em caminhos específicos. Tentando usar biblioteca do sistema: {libraryName}");
            return libraryName;
        }

        public static bool IsPathFullyQualified(string path)
        {
            if (path.Length == 0)
            {
                return false;
            }

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return IsFullyQualifiedWindows(path);
            }

            return IsFullyQualifiedUnix(path);
        }

        private static bool IsFullyQualifiedWindows(string path)
        {
            if (path.Length < 2)
            {
                return false;
            }

            if (char.IsLetter(path[0]) && path[1] == ':' &&
                (path.Length > 2 && (path[2] == '\\' || path[2] == '/')))
            {
                return true;
            }

            if (path.Length > 1 && path[0] == '\\' && path[1] == '\\')
            {
                return true;
            }

            return false;
        }

        private static bool IsFullyQualifiedUnix(string path)
        {
            return path.Length > 0 && path[0] == '/';
        }

        private static string GetArchitecture()
        {
            return RuntimeInformation.ProcessArchitecture switch
            {
                Architecture.X86 => "x86",
                Architecture.X64 => "x64",
                Architecture.Arm => "arm",
                Architecture.Arm64 => "arm64",
                _ => throw new ArgumentException("Arquitetura não suportada."),
            };
        }

        private static string GetOSPlatform()
        {
            if (RuntimeInformation.IsOSPlatform(Windows))
            {
                return "win";
            }
            else if (RuntimeInformation.IsOSPlatform(Linux))
            {
                return "linux";
            }
            else if (RuntimeInformation.IsOSPlatform(OSX))
            {
                return "osx";
            }
            else if (RuntimeInformation.IsOSPlatform(Android))
            {
                return "android";
            }
            else if (RuntimeInformation.IsOSPlatform(IOS))
            {
                return "ios";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("FREEBSD")))
            {
                return "freebsd";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("TVOS")))
            {
                return "tvos";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("WATCHOS")))
            {
                return "watchos";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("SOLARIS")))
            {
                return "solaris";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("WEBASSEMBLY")))
            {
                return "webassembly";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("TIZEN")))
            {
                return "tizen";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("CHROMEOS")))
            {
                return "chromeos";
            }

            throw new ArgumentException("Plataforma OS não suportada.");
        }
    }
}