using System;
using System.Runtime.InteropServices;

namespace SharpImGui
{
    internal unsafe class FunctionTable : IDisposable
    {
        private void** _vtable;
        private int _length;
        private readonly NativeLibraryContext _context;

        // public FunctionTable(void** vtable, int lenght)
        // {
        //     _context = null;
        //     _vtable = vtable;
        //     _length = lenght;
        // }
        
        public FunctionTable(IntPtr library, int length) : this(new NativeLibraryContext(library), length)
        {
        }

        public FunctionTable(string libraryPath, int length) : this(new NativeLibraryContext(libraryPath), length)
        {
        }

        public FunctionTable(NativeLibraryContext context, int length)
        {
            _context = context;
            _vtable = (void**)Marshal.AllocHGlobal(length * sizeof(void*));
            new Span<int>(_vtable, length).Clear(); // Fill with null pointers
            _length = length;
        }
        
        public void Load(int index, string export)
        {
            if (!_context.TryGetProcAddress(export, out var address))
            {
                _vtable[index] = null;
                return;
            }

            _vtable[index] = (void*)address;
        }

        public void Resize(int newLength)
        {
            if (newLength == _length)
                return;

            _vtable = (void**)Marshal.ReAllocHGlobal((IntPtr)_vtable, (IntPtr)(newLength * sizeof(void*)));
            _length = newLength;
        }

        public void* this[int index]
        {
            get => _vtable[index];
            set => _vtable[index] = value;
        }

        public void Free()
        {
            if (_vtable != null)
            {
                Marshal.FreeHGlobal((IntPtr)_vtable);
                _vtable = null;
            }

            _context.Dispose();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Free();
        }
    }
}