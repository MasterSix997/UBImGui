using System;
using System.Runtime.CompilerServices;
using UBImGui;
using UnityEngine;

namespace SharpImgui
{
    public static unsafe partial class ImGui
    {
        public static event Action Layout
        {
            add
            {
                ImGuiBehaviour.Initialize();
                ImGuiController.CurrentController.Layout += value;
            }
            remove
            {
                if (ImGuiController.CurrentController != null)
                    ImGuiController.CurrentController.Layout -= value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IntPtr ImageId(Texture texture) => ImGuiController.CurrentController.Textures.GetOrCreate(texture);

        public static void Image(Texture texture)
        {
            var idPtr = ImageId(texture);
            var size = new Vector2(texture.width, texture.height);
            var uv0 = new Vector2();
            var uv1 = new Vector2(1, 1);
            var tintCol = new Vector4(1, 1, 1, 1);
            var borderCol = new Vector4();
            ImGuiNative.igImage(idPtr, size, uv0, uv1, tintCol, borderCol);
        }
        
        public static void Image(Texture texture, Vector2 size)
        {
            var idPtr = ImageId(texture);
            var uv0 = new Vector2();
            var uv1 = new Vector2(1, 1);
            var tintCol = new Vector4(1, 1, 1, 1);
            var borderCol = new Vector4();
            ImGuiNative.igImage(idPtr, size, uv0, uv1, tintCol, borderCol);
        }
        
        public static void Image(Sprite sprite)
        {
            var texture = sprite.texture;
            var idPtr = ImageId(texture);
            var size = sprite.rect.size;
            var uvs = sprite.uv; // allocates memory
            var uv0 = new Vector2(uvs[0].x, 1f - uvs[0].y);
            var uv1 = new Vector2(uvs[1].x, 1f - uvs[1].y);
            var tintCol = new Vector4(1, 1, 1, 1);
            var borderCol = new Vector4();
            ImGuiNative.igImage(idPtr, size, uv0, uv1, tintCol, borderCol);
        }
        
        public static void Image(Sprite sprite, Vector2 size)
        {
            var texture = sprite.texture;
            var idPtr = ImageId(texture);
            var uvs = sprite.uv; // allocates memory
            var uv0 = new Vector2(uvs[0].x, 1f - uvs[0].y);
            var uv1 = new Vector2(uvs[1].x, 1f - uvs[1].y);
            var tintCol = new Vector4(1, 1, 1, 1);
            var borderCol = new Vector4();
            ImGuiNative.igImage(idPtr, size, uv0, uv1, tintCol, borderCol);
        }

        public static bool ImageButton(string str_id, Texture texture)
        {
            var idPtr = ImageId(texture);
            var size = new Vector2(texture.width, texture.height);
            return ImageButton(str_id, idPtr, size);
        }
        
        public static bool ImageButton(string str_id, Texture texture, Vector2 size)
        {
            var idPtr = ImageId(texture);
            return ImageButton(str_id, idPtr, size);
        }

        public static bool ImageButton(string str_id, Sprite sprite)
        {
            var texture = sprite.texture;
            var idPtr = ImageId(texture);
            var size = sprite.rect.size;
            var uvs = sprite.uv; // allocates memory
            var uv0 = new Vector2(uvs[0].x, 1f - uvs[0].y);
            var uv1 = new Vector2(uvs[1].x, 1f - uvs[1].y);
            return ImageButton(str_id, idPtr, size, uv0, uv1);
        }
        
        public static bool ImageButton(string str_id, Sprite sprite, Vector2 size)
        {
            var texture = sprite.texture;
            var idPtr = ImageId(texture);
            var uvs = sprite.uv; // allocates memory
            var uv0 = new Vector2(uvs[0].x, 1f - uvs[0].y);
            var uv1 = new Vector2(uvs[1].x, 1f - uvs[1].y);
            return ImageButton(str_id, idPtr, size, uv0, uv1);
        }
    }
}