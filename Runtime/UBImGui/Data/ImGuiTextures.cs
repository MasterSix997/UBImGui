using System;
using System.Collections.Generic;
using ImGuiNET;
using UBImGui.Utils;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UBImGui
{
    public class ImGuiTextures : IDisposable
    {
        private Texture2D _atlasTexture;
        private int _currentTextureId;
        // private readonly Dictionary<int, Texture> _textures = new Dictionary<int, Texture>();
        private readonly TwoWayDictionary<int, Texture> _textures = new TwoWayDictionary<int, Texture>();

        public void UpdateTextures(ImGuiIOPtr io)
        {
            _textures.Clear();
            io.Fonts.SetTexID((IntPtr)Bind(_atlasTexture));
        }

        private int Bind(Texture texture)
        {
            _textures[++_currentTextureId] = texture;
            return _currentTextureId;
        }
        
        public Texture GetTexture(int id)
        {
            return _textures.Contains(id) ? _textures[id] : null;
        }
        
        public int GetTextureId(Texture texture)
        {
            return _textures.Contains(texture) ? _textures[texture] : -1;
        }
        
        public IntPtr GetTexturePtr(Texture texture)
        {
            return (IntPtr)GetTextureId(texture);
        }
        
        public IntPtr GetTexturePtr(int id)
        {
            return _textures.Contains(id) ? (IntPtr)id : IntPtr.Zero;
        }

        public IntPtr GetOrCreate(Texture texture)
        {
            var id = GetTextureId(texture);
            if (id == -1)
                id = Bind(texture);
            
            return (IntPtr)id;
        }
        
        public void BuildDefaultFont(ImGuiIOPtr io)
        {
            if (!io.MouseDrawCursor)
                io.Fonts.Flags |= ImFontAtlasFlags.NoMouseCursors;
            
            io.Fonts.AddFontDefault();
            io.Fonts.Build();
        }

        public unsafe void BuildAtlasTexture(ImGuiIOPtr io)
        {
            io.Fonts.GetTexDataAsRGBA32(out byte* pixels, out var width, out var height, out var bytesPerPixel);
            _atlasTexture = new Texture2D(width, height, TextureFormat.RGBA32, false, false)
            {
                filterMode = FilterMode.Point
            };

            var srcData = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>(pixels, width * height * bytesPerPixel, Allocator.None);
#if ENABLE_UNITY_COLLECTIONS_CHECKS
            NativeArrayUnsafeUtility.SetAtomicSafetyHandle(ref srcData, AtomicSafetyHandle.GetTempMemoryHandle());
#endif
            // invert y while copying the atlas texture
            var dstData = _atlasTexture.GetRawTextureData<byte>();
            var stride = width * bytesPerPixel;
            for (var y = 0; y < height; ++y)
                NativeArray<byte>.Copy(srcData, y * stride, dstData, (height - y - 1) * stride, stride);
            _atlasTexture.Apply();
        }

        public void Dispose()
        {
            _currentTextureId = 0;
            _textures.Clear();
            if (_atlasTexture)
            {
                Object.Destroy(_atlasTexture); 
                _atlasTexture = null;
            }
        }
    }
}