using System;
using System.Collections.Generic;
using System.IO;
using SharpImGui;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using Application = UnityEngine.Device.Application;
using Object = UnityEngine.Object;

namespace UBImGui
{
    public class ImGuiTextures : IDisposable
    {
        private Texture2D _atlasTexture;
        private readonly TwoWayDictionary<int, Texture> _textures = new TwoWayDictionary<int, Texture>();
        private int _currentTextureId;
        readonly HashSet<IntPtr> _allocatedGlyphRangeArrays = new HashSet<IntPtr>(IntPtrEqualityComparer.Instance);

        public void UpdateTextures(ImGuiIOPtr io)
        {
            _currentTextureId = 0;
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
        
        unsafe IntPtr AllocateGlyphRangeArray(in FontSettings fontSettings)
        {
            var values = fontSettings.BuildRanges();
            if (values.Count == 0)
                return IntPtr.Zero;
        
            int byteCount = sizeof(ushort) * (values.Count + 1); // terminating zero
            var ranges = (ushort*)Util.Allocate(byteCount);
            _allocatedGlyphRangeArrays.Add((IntPtr)ranges);
            for (var i = 0; i < values.Count; ++i)
                ranges[i] = values[i];
            ranges[values.Count] = 0;
            return (IntPtr)ranges;
        }

        unsafe void FreeGlyphRangeArrays()
        {
            foreach (var range in _allocatedGlyphRangeArrays)
                Util.Free((byte*)range);
            _allocatedGlyphRangeArrays.Clear();
        }
        
        public unsafe void BuildFontAtlas(ImGuiIOPtr io, in ImGuiFontAsset fontAsset = null)
        {
            if (io.Fonts.IsBuilt())
                DestroyFontAtlas(io);
            
            if (!io.MouseDrawCursor)
                io.Fonts.Flags |= ImFontAtlasFlags.NoMouseCursors;
            
            if (fontAsset && fontAsset.fontSettings.Length > 0)
            {
                foreach (var fontSetting in fontAsset.fontSettings)
                {
                    var fontPath = Path.Combine(Application.streamingAssetsPath, fontSetting.fontPath);
                    if (!File.Exists(fontPath))
                    {
                        Debug.LogError($"Font file not found: {fontPath}");
                        continue;
                    }

                    io.Fonts.AddFontFromFileTTF(fontPath, fontSetting.sizeInPixels, null, AllocateGlyphRangeArray(fontSetting));
                }
            }
            
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
        
        public unsafe void DestroyFontAtlas(ImGuiIOPtr io)
        {
            FreeGlyphRangeArrays();

            io.Fonts.Clear();
            io.NativePtr->FontDefault = default;
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