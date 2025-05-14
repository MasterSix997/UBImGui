using System;

namespace SharpImGui
{

    public class NativeLibraryContext
    {
        private IntPtr library;

        public NativeLibraryContext(IntPtr library)
        {
            this.library = library;
        }

        public NativeLibraryContext(string libraryPath)
        {
            library = NativeLibrary.Load(libraryPath);
        }

        public IntPtr GetProcAddress(string procName)
        {
            if (!NativeLibrary.TryGetExport(library, procName, out var address))
            {
                return IntPtr.Zero;
            }

            return address;
        }

        public bool TryGetProcAddress(string procName, out IntPtr address)
        {
            return NativeLibrary.TryGetExport(library, procName, out address);
        }

        public void Dispose()
        {
            if (library != IntPtr.Zero)
            {
                NativeLibrary.Free(library);
                library = IntPtr.Zero;
            }
            GC.SuppressFinalize(this);
        }

        public bool IsExtensionSupported(string extensionName)
        {
            return false;
        }
    }
}