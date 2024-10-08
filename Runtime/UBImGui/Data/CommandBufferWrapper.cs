using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace UBImGui
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct CommandBufferWrapper
    {
        private readonly CommandBuffer _cmd;
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
        private readonly RasterCommandBuffer _rasterCmd;
#endif
        private readonly bool _isRaster;

        public CommandBufferWrapper(CommandBuffer cmd)
        {
            _cmd = cmd;
            _rasterCmd = null;
            _isRaster = false;
        }
        
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
        public CommandBufferWrapper(RasterCommandBuffer rasterCmd)
        {
            _cmd = null;
            _rasterCmd = rasterCmd;
            _isRaster = true;
        }
#endif

        public void SetViewport(Rect viewport)
        {
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
            if (_isRaster)
            {
                _rasterCmd.SetViewport(viewport);
                return;
            }
#endif
            _cmd.SetViewport(viewport);
        }

        public void SetViewProjectionMatrices(Matrix4x4 view, Matrix4x4 projection)
        {
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
            if (_isRaster)
            {
                _rasterCmd.SetViewProjectionMatrices(view, projection);
                return;
            }
#endif
            _cmd.SetViewProjectionMatrices(view, projection);
        }
        
        public void EnableScissorRect(Rect viewport)
        {
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
            if (_isRaster)
            {
                _rasterCmd.EnableScissorRect(viewport);
                return;
            }
#endif
            _cmd.EnableScissorRect(viewport);
        }
        
        public void DisableScissorRect()
        {
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
            if (_isRaster)
            {
                _rasterCmd.DisableScissorRect();
                return;
            }
#endif
            _cmd.DisableScissorRect();
        }
        
        public void DrawProceduralIndirect(GraphicsBuffer indexBuffer, Matrix4x4 matrix, Material material, int shaderPass, 
            MeshTopology topology, GraphicsBuffer bufferWithArgs, int argsOffset, MaterialPropertyBlock properties)
        {
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
            if (_isRaster)
            {
                _rasterCmd.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
                return;
            }
#endif
            _cmd.DrawProceduralIndirect(indexBuffer, matrix, material, shaderPass, topology, bufferWithArgs, argsOffset, properties);
        }
        
        public void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int submeshIndex, int shaderPass, MaterialPropertyBlock properties)
        {
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
            if (_isRaster)
            {
                _rasterCmd.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
                return;
            }
#endif
            _cmd.DrawMesh(mesh, matrix, material, submeshIndex, shaderPass, properties);
        }
        
    }
}