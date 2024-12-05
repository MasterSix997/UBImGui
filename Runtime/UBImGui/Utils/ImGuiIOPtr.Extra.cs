// using System;
// using System.Collections.Generic;
// using System.Text;
// using UBImGui;
//
// namespace Hexa.NET.ImGui
// {
//     public unsafe partial struct ImGuiIOPtr
//     {
//         static readonly HashSet<IntPtr> _managedAllocations = new HashSet<IntPtr>(IntPtrEqualityComparer.Instance);
//
//         public void SetBackendRendererName(string name)
//         {
//             if (NativePtr->BackendRendererName != (byte*)0)
//             {
//                 if (_managedAllocations.Contains((IntPtr)NativePtr->BackendRendererName))
//                     Util.Free(NativePtr->BackendRendererName);
//                 NativePtr->BackendRendererName = (byte*)0;
//             }
//             if (name != null)
//             {
//                 int byteCount = Encoding.UTF8.GetByteCount(name);
//                 byte* nativeName = Util.Allocate(byteCount + 1);
//                 int offset = Util.GetUtf8(name, nativeName, byteCount);
//                 nativeName[offset] = 0;
//                 NativePtr->BackendRendererName = nativeName;
//                 _managedAllocations.Add((IntPtr)nativeName);
//             }
//         }
//
//         public void SetBackendPlatformName(string name)
//         {
//             if (NativePtr->BackendPlatformName != (byte*)0)
//             {
//                 if (_managedAllocations.Contains((IntPtr)NativePtr->BackendPlatformName))
//                     Util.Free(NativePtr->BackendPlatformName);
//                 NativePtr->BackendPlatformName = (byte*)0;
//             }
//             if (name != null)
//             {
//                 int byteCount = Encoding.UTF8.GetByteCount(name);
//                 byte* nativeName = Util.Allocate(byteCount + 1);
//                 int offset = Util.GetUtf8(name, nativeName, byteCount);
//                 nativeName[offset] = 0;
//                 NativePtr->BackendPlatformName = nativeName;
//                 _managedAllocations.Add((IntPtr)nativeName);
//             }
//         }
//
//         public void SetIniFilename(string name)
//         {
//             if (NativePtr->IniFilename != (byte*)0)
//             {
//                 if (_managedAllocations.Contains((IntPtr)NativePtr->IniFilename))
//                     Util.Free(NativePtr->IniFilename);
//                 NativePtr->IniFilename = (byte*)0;
//             }
//             if (name != null)
//             {
//                 int byteCount = Encoding.UTF8.GetByteCount(name);
//                 byte* nativeName = Util.Allocate(byteCount + 1);
//                 int offset = Util.GetUtf8(name, nativeName, byteCount);
//                 nativeName[offset] = 0;
//                 NativePtr->IniFilename = nativeName;
//                 _managedAllocations.Add((IntPtr)nativeName);
//             }
//         }
//     }
// }
