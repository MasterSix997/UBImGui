using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{

    public static unsafe class Utils
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T* Alloc<T>(int size) where T : unmanaged => (T*)Marshal.AllocHGlobal(size * sizeof(T));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Free(void* ptr) => Marshal.FreeHGlobal((IntPtr)ptr);

        public static void FreeBSTR(void* ptr) => Marshal.FreeBSTR((IntPtr)ptr);

        public const int MaxStackallocSize = 2048;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr GetFunctionPointerForDelegate<T>(T? d) where T : Delegate
        {
            if (d == null)
            {
                return IntPtr.Zero;
            }
            return Marshal.GetFunctionPointerForDelegate(d);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? GetDelegateForFunctionPointer<T>(void* ptr) where T : Delegate
        {
            if (ptr == null)
            {
                return null;
            }
            return Marshal.GetDelegateForFunctionPointer<T>((IntPtr)ptr);
        }

        #region String Encoding/Decoding

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetByteCountUTF8(string str)
        {
            return Encoding.UTF8.GetByteCount(str);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetByteCountUTF16(string str)
        {
            return Encoding.Unicode.GetByteCount(str);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int EncodeStringUTF8(string str, byte* data, int size)
        {
            fixed (char* pStr = str)
            {
                return Encoding.UTF8.GetBytes(pStr, str.Length, data, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int EncodeStringUTF16(string str, char* data, int size)
        {
            fixed (char* pStr = str)
            {
                return Encoding.Unicode.GetBytes(pStr, str.Length, (byte*)data, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string DecodeStringUTF8(byte* data)
        {
            int length = CStringLength(data);
            return Encoding.UTF8.GetString(data, length);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string DecodeStringUTF16(char* data)
        {
            int length = CStringLength(data);
            return new string(data, 0, length);
        }

        public static int CStringLength(char* pointer)
        {
            if (pointer == null)
            {
                throw new ArgumentNullException(nameof(pointer));
            }

            // Find the length of the null-terminated string
            int length = 0;
            while (pointer[length] != '\0')
            {
                length++;
            }

            return length;
        }

        public static int CStringLength(byte* pointer)
        {
            if (pointer == null)
            {
                throw new ArgumentNullException(nameof(pointer));
            }

            // Find the length of the null-terminated string
            int length = 0;
            while (pointer[length] != '\0')
            {
                length++;
            }

            return length;
        }

        public static string DecodeStringBSTR(void* data)
        {
            return Marshal.PtrToStringBSTR((IntPtr)data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte* StringToUTF8Ptr(string str)
        {
            var size = GetByteCountUTF8(str);
            var ptr = Alloc<byte>(size + 1);
            fixed (char* pStr = str)
            {
                Encoding.UTF8.GetBytes(pStr, str.Length, ptr, size);
            }
            ptr[size] = 0;
            return ptr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char* StringToUTF16Ptr(string str)
        {
            var size = GetByteCountUTF16(str);
            var ptr = Alloc<byte>(size);
            fixed (char* pStr = str) 
            { 
                Encoding.Unicode.GetBytes(pStr, str.Length, ptr, size); 
            }
            var result = (char*)ptr;
            result[str.Length] = '\0';
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void* StringToBSTR(string str)
        {
            return (void*)Marshal.StringToBSTR(str);
        }
        #endregion

        #region ReadOnlySpan<char> Encoding/Decoding

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetByteCountUTF8(ReadOnlySpan<char> str)
        {
            return Encoding.UTF8.GetByteCount(str);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetByteCountUTF16(ReadOnlySpan<char> str)
        {
            return Encoding.Unicode.GetByteCount(str);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int EncodeStringUTF8(ReadOnlySpan<char> str, byte* data, int size)
        {
            fixed (char* pStr = str)
            {
                return Encoding.UTF8.GetBytes(pStr, str.Length, data, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int EncodeStringUTF16(ReadOnlySpan<char> str, char* data, int size)
        {
            fixed (char* pStr = str)
            {
                return Encoding.Unicode.GetBytes(pStr, str.Length, (byte*)data, size);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string DecodeStringUTF8(ReadOnlySpan<byte> data)
        {
            return Encoding.UTF8.GetString(data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string DecodeStringUTF16(ReadOnlySpan<char> data)
        {
            return new string(data);
        }
        
        // [MethodImpl(MethodImplOptions.AggressiveInlining)]
        // public static ReadOnlySpan<char> DecodeStringUTF8(ReadOnlySpan<byte> data)
        // {
        //     return DecodeStringUTF8(data);
        // }

        public static int CStringLength(ReadOnlySpan<char> span)
        {
            int length = 0;
            for (int i = 0; i < span.Length; i++)
            {
                if (span[i] == '\0')
                {
                    break;
                }
                length++;
            }
            return length;
        }

        public static int CStringLength(ReadOnlySpan<byte> span)
        {
            int length = 0;
            for (int i = 0; i < span.Length; i++)
            {
                if (span[i] == 0)
                {
                    break;
                }
                length++;
            }
            return length;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte* StringToUTF8Ptr(ReadOnlySpan<char> str)
        {
            var size = GetByteCountUTF8(str);
            var ptr = Alloc<byte>(size + 1);
            fixed (char* pStr = str)
            {
                Encoding.UTF8.GetBytes(pStr, str.Length, ptr, size);
            }
            ptr[size] = 0;
            return ptr;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static char* StringToUTF16Ptr(ReadOnlySpan<char> str)
        {
            var size = GetByteCountUTF16(str);
            var ptr = Alloc<byte>(size);
            fixed (char* pStr = str)
            {
                Encoding.Unicode.GetBytes(pStr, str.Length, ptr, size);
            }
            var result = (char*)ptr;
            result[str.Length] = '\0';
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void* StringToBSTR(ReadOnlySpan<char> str)
        {
            return (void*)Marshal.StringToBSTR(str.ToString());
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int GetByteCountArray<T>(T[] array) where T : unmanaged => array.Length * sizeof(T);
    }
}