using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
    public readonly unsafe struct RangeAccessor<T> where T : struct
    {
        private static readonly int SizeOfT = Unsafe.SizeOf<T>();

        public readonly void* Data;
        public readonly int Count;

        public RangeAccessor(IntPtr data, int count) : this(data.ToPointer(), count) { }
        public RangeAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public ref T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return ref Unsafe.AsRef<T>((byte*)Data + SizeOfT * index);
            }
        }
    }

    public readonly unsafe struct RangePtrAccessor<T> where T : struct
    {
        public readonly void* Data;
        public readonly int Count;

        public RangePtrAccessor(IntPtr data, int count) : this(data.ToPointer(), count) { }
        public RangePtrAccessor(void* data, int count)
        {
            Data = data;
            Count = count;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return Unsafe.Read<T>((byte*)Data + sizeof(void*) * index);
            }
        }
    }

    public static class RangeAccessorExtensions
    {
        public static unsafe string GetStringAscii(this RangeAccessor<byte> stringAccessor)
        {
            return Encoding.ASCII.GetString((byte*)stringAccessor.Data, stringAccessor.Count);
        }
    }
}
