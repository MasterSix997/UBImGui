using ImGuiNET;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

namespace UBImGui
{
    public class GraphicsBufferRenderer : IImGuiRenderer
    {
        private readonly Material _material = new Material(Resources.Load<Shader>("DearImGui"));
        private readonly MaterialPropertyBlock _properties = new MaterialPropertyBlock();
        private readonly ImGuiTextures _textures;
        
        private static readonly int VertexProperty = Shader.PropertyToID("_Vertices");
        private static readonly int TextureProperty = Shader.PropertyToID("_Texture");
        private static readonly int BaseVertexProperty = Shader.PropertyToID("_BaseVertex");
        
        private GraphicsBuffer _vertexBuffer;
        private GraphicsBuffer _indexBuffer;
        private GraphicsBuffer _argsBuffer;
        
        private int[] _drawArgs = { 0, 1, 0, 0, 0 };

        public GraphicsBufferRenderer(ImGuiIOPtr io, ImGuiTextures textures)
        {
            _textures = textures;
            io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset;
        }

        public unsafe void UpdateBuffers(ImDrawDataPtr drawData)
        {
            var drawArgCount = 0;
            for (int n = 0, nMax = drawData.CmdListsCount; n < nMax; n++)
                drawArgCount += drawData.CmdLists[n].CmdBuffer.Size;
            
            EnsureCapacity<ImDrawVert>(ref _vertexBuffer, GraphicsBuffer.Target.Structured, drawData.TotalVtxCount);
            EnsureCapacity<ushort>(ref _indexBuffer, GraphicsBuffer.Target.Index, drawData.TotalIdxCount);
            EnsureCapacity<int>(ref _argsBuffer, GraphicsBuffer.Target.IndirectArguments, drawArgCount * 5);
            
            // Copy vertex and index data into graphics buffers
            var vtxOffset = 0;
            var idxOffset = 0;
            var argsOffset = 0;
            for (int n = 0, nMax = drawData.CmdListsCount; n < nMax; n++)
            {
                var cmdList = drawData.CmdLists[n];
                
                var vtxArray = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ImDrawVert>(
                    (void*)cmdList.VtxBuffer.Data, cmdList.VtxBuffer.Size, Allocator.None);
                var idxArray     = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ushort>(
                    (void*)cmdList.IdxBuffer.Data, cmdList.IdxBuffer.Size, Allocator.None);
                
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                NativeArrayUnsafeUtility.SetAtomicSafetyHandle(ref vtxArray, AtomicSafetyHandle.GetTempMemoryHandle());
                NativeArrayUnsafeUtility.SetAtomicSafetyHandle(ref idxArray, AtomicSafetyHandle.GetTempMemoryHandle());
#endif
                // upload vertex/index data
                _vertexBuffer.SetData(vtxArray, 0, vtxOffset, vtxArray.Length);
                _indexBuffer.SetData(idxArray, 0, idxOffset, idxArray.Length);
                
                // arguments for DrawProceduralIndirect
                _drawArgs[3] = vtxOffset;                          // base vertex location
                for (int i = 0, iMax = cmdList.CmdBuffer.Size; i < iMax; i++)
                {
                    var cmd = cmdList.CmdBuffer[i];
                    _drawArgs[0] = (int)cmd.ElemCount;             // index count per instance
                    _drawArgs[2] = idxOffset + (int)cmd.IdxOffset; // start index location
                    _argsBuffer.SetData(_drawArgs, 0, argsOffset, 5);
                    
                    argsOffset += 5;                               // 5 int for each cmd
                }
                vtxOffset += vtxArray.Length;
                idxOffset += idxArray.Length;
            }
        }

        public void Render(CommandBufferWrapper cmd, ImDrawDataPtr drawData, Vector2 frameBufferSize)
        {
            var prevTextureId = System.IntPtr.Zero;
            var clipOffset = new Vector4(drawData.DisplayPos.x, drawData.DisplayPos.y, drawData.DisplayPos.x, drawData.DisplayPos.y);
            var clipScale = new Vector4(drawData.FramebufferScale.x, drawData.FramebufferScale.y, drawData.FramebufferScale.x, drawData.FramebufferScale.y);

            _material.SetBuffer(VertexProperty, _vertexBuffer);                          // bind vertex buffer

            cmd.SetViewport(new Rect(0f, 0f, frameBufferSize.x, frameBufferSize.y));
            cmd.SetViewProjectionMatrices(
                Matrix4x4.Translate(new Vector3(0.5f / frameBufferSize.x, 0.5f / frameBufferSize.y, 0f)), // small adjustment to improve text
                Matrix4x4.Ortho(0f, frameBufferSize.x, frameBufferSize.y, 0f, 0f, 1f));
            
            var vtxOffset = 0;
            var argOffset = 0;
            for (int n = 0, nMax = drawData.CmdListsCount; n < nMax; ++n)
            {
                var drawList = drawData.CmdLists[n];
                for (int i = 0, iMax = drawList.CmdBuffer.Size; i < iMax; ++i, argOffset += 5 * 4)
                {
                    var drawCmd = drawList.CmdBuffer[i];
                    // TODO: user callback in drawCmd.UserCallback & drawCmd.UserCallbackData

                    // project scissor rectangle into framebuffer space and skip if fully outside
                    var drawCmdU = new Vector4(drawCmd.ClipRect.x, drawCmd.ClipRect.y, drawCmd.ClipRect.z, drawCmd.ClipRect.w);
                    var clip = Vector4.Scale(drawCmdU - clipOffset, clipScale);
                    if (clip.x >= frameBufferSize.x || clip.y >= frameBufferSize.y || clip.z < 0f || clip.w < 0f) continue;

                    if (prevTextureId != drawCmd.TextureId)
                    {
                        _properties.SetTexture(TextureProperty, _textures.GetTexture((int)(prevTextureId = drawCmd.TextureId)));
                    }

                    _properties.SetInt(BaseVertexProperty, vtxOffset + (int)drawCmd.VtxOffset); // base vertex location not automatically added to SV_VertexID
                    cmd.EnableScissorRect(new Rect(clip.x, frameBufferSize.y - clip.w, clip.z - clip.x, clip.w - clip.y)); // invert y
                    cmd.DrawProceduralIndirect(_indexBuffer, Matrix4x4.identity, _material, -1, MeshTopology.Triangles, _argsBuffer, argOffset, _properties);
                }
                vtxOffset += drawList.VtxBuffer.Size;
            }
            cmd.DisableScissorRect();
        }

        private static void EnsureCapacity<T>(ref GraphicsBuffer buffer, GraphicsBuffer.Target target, int size) where T : struct
        {
            if (buffer != null && buffer.count > size)
                return;
            
            size = ((size - 1) / 256 + 1) * 256;
            buffer?.Release();
            buffer = new GraphicsBuffer(target, GraphicsBuffer.UsageFlags.None, size, UnsafeUtility.SizeOf<T>());
        }
        
        public void Dispose()
        {
            if (_material)
                Object.Destroy(_material);
            
            _vertexBuffer?.Release();
            _indexBuffer?.Release();
            _argsBuffer?.Release();
        }
    }
}