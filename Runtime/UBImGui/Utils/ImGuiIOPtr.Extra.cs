using System;
using System.Collections.Generic;
using System.Text;
using UBImGui;

namespace SharpImGui
{
    public unsafe partial struct ImGuiIOPtr
    {
        static readonly HashSet<IntPtr> _managedAllocations = new HashSet<IntPtr>(IntPtrEqualityComparer.Instance);

        public void SetBackendRendererName(string name)
        {
            if (NativePtr->BackendRendererName != (byte*)0)
            {
                if (_managedAllocations.Contains((IntPtr)NativePtr->BackendRendererName))
                    Utils.Free(NativePtr->BackendRendererName);
                NativePtr->BackendRendererName = (byte*)0;
            }
            if (name != null)
            {
                int byteCount = Encoding.UTF8.GetByteCount(name);
                byte* nativeName = Utils.Alloc<byte>(byteCount + 1);
                int offset = Utils.EncodeStringUTF8(name, nativeName, byteCount);
                nativeName[offset] = 0;
                NativePtr->BackendRendererName = nativeName;
                _managedAllocations.Add((IntPtr)nativeName);
            }
        }

        public void SetBackendPlatformName(string name)
        {
            if (NativePtr->BackendPlatformName != (byte*)0)
            {
                if (_managedAllocations.Contains((IntPtr)NativePtr->BackendPlatformName))
                    Utils.Free(NativePtr->BackendPlatformName);
                NativePtr->BackendPlatformName = (byte*)0;
            }
            if (name != null)
            {
                int byteCount = Encoding.UTF8.GetByteCount(name);
                byte* nativeName = Utils.Alloc<byte>(byteCount + 1);
                int offset = Utils.EncodeStringUTF8(name, nativeName, byteCount);
                nativeName[offset] = 0;
                NativePtr->BackendPlatformName = nativeName;
                _managedAllocations.Add((IntPtr)nativeName);
            }
        }

        public void SetIniFilename(string name)
        {
            if (NativePtr->IniFilename != (byte*)0)
            {
                if (_managedAllocations.Contains((IntPtr)NativePtr->IniFilename))
                    Utils.Free(NativePtr->IniFilename);
                NativePtr->IniFilename = (byte*)0;
            }
            if (name != null)
            {
                int byteCount = Encoding.UTF8.GetByteCount(name);
                byte* nativeName = Utils.Alloc<byte>(byteCount + 1);
                int offset = Utils.EncodeStringUTF8(name, nativeName, byteCount);
                nativeName[offset] = 0;
                NativePtr->IniFilename = nativeName;
                _managedAllocations.Add((IntPtr)nativeName);
            }
        }
    }
}
