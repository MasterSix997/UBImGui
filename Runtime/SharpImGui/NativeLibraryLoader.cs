using System;

#if !NET5_0_OR_GREATER
namespace SharpImGui
{
    using System.Runtime.InteropServices;

    public unsafe class NativeLibrary
    {
        // Windows
        [DllImport("kernel32", EntryPoint = "LoadLibrary", SetLastError = true)]
        private static extern IntPtr LoadLibraryNative(byte* lpFileName);

        [DllImport("kernel32", EntryPoint = "FreeLibrary", SetLastError = true)]
        private static extern bool FreeLibraryNative(IntPtr hModule);

        [DllImport("kernel32", EntryPoint = "GetProcAddress", SetLastError = true)]
        private static extern IntPtr GetProcAddressNative(IntPtr hModule, byte* lpProcName);

        // Unix/Linux/Android
        [DllImport("libdl.so", EntryPoint = "dlopen")]
        private static extern IntPtr DLOpenNative(byte* fileName, int flags);

        [DllImport("libdl.so", EntryPoint = "dlclose")]
        private static extern int DLCloseNative(IntPtr handle);

        [DllImport("libdl.so", EntryPoint = "dlsym")]
        private static extern IntPtr DLSymNative(IntPtr handle, byte* name);

        private const int RTLD_NOW = 2;

        public static IntPtr Load(string libraryPath)
        {
            byte* pLibraryPath = Utils.StringToUTF8Ptr(libraryPath);
            IntPtr libraryHandle;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                libraryHandle = LoadLibraryNative(pLibraryPath);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                     RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                libraryHandle = DLOpenNative(pLibraryPath, RTLD_NOW);
            }
            else
            {
                libraryHandle = DLOpenNative(pLibraryPath, RTLD_NOW);
            }
            Utils.Free(pLibraryPath);
            return libraryHandle;
        }

        public static bool Free(IntPtr libraryHandle)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return FreeLibraryNative(libraryHandle);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                     RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return DLCloseNative(libraryHandle) == 0;
            }
            else
            {
                return DLCloseNative(libraryHandle) == 0;
            }
        }
        
        private static IntPtr GetProcAddress(IntPtr libraryHandle, byte* pFunctionName)
        {
            IntPtr functionAddress;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                functionAddress = GetProcAddressNative(libraryHandle, pFunctionName);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) ||
                     RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                functionAddress = DLSymNative(libraryHandle, pFunctionName);
            }
            else
            {
                functionAddress = DLSymNative(libraryHandle, pFunctionName);
            }

            return functionAddress;
        }

        public static IntPtr GetExport(IntPtr libraryHandle, string functionName)
        {
            byte* pFunctionName = Utils.StringToUTF8Ptr(functionName);

            IntPtr functionAddress = GetProcAddress(libraryHandle, pFunctionName);

            Utils.Free(pFunctionName);

            if (functionAddress == IntPtr.Zero)
            {
                throw new EntryPointNotFoundException(functionName);
            }

            return functionAddress;
        }

        public static bool TryGetExport(IntPtr libraryHandle, string functionName, out IntPtr functionAddress)
        {
            byte* pFunctionName = Utils.StringToUTF8Ptr(functionName);

            functionAddress = GetProcAddress(libraryHandle, pFunctionName);

            Utils.Free(pFunctionName);

            if (functionAddress == IntPtr.Zero)
            {
                return false;
            }

            return true;
        }
    }
}
#endif