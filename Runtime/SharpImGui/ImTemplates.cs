using System.Runtime.InteropServices;

namespace SharpImGui
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImChunkStream
    {
        public ImVector<byte> Buf;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImPool<T> where T : unmanaged
    {
        public ImVector<T> Buf;
        public ImGuiStorage Map;
        public int FreeIdx;
        public int AliveCount;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImSpan<T> where T : unmanaged
    {
        public unsafe T* Data;
        public unsafe T* DataEnd;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public partial struct EmptyStruct
    {
        
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ImPointer<T> where T : unmanaged
    {
        public unsafe T* Ptr;
    }
}