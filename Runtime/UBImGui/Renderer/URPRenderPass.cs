using UBImGui;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

namespace Drawbug 
{
	public class DearImGuiRenderPassFeature : ScriptableRendererFeature 
	{
		public class DearImGuiURPRenderPass : ScriptableRenderPass 
		{
			[System.Obsolete]
			public override void Configure (CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

			[System.Obsolete]
			public override void Execute (ScriptableRenderContext context, ref RenderingData renderingData) 
			{
				ImGuiBehaviour.ExecuteCustomRenderPass(context, renderingData.cameraData.camera);
			}
			
			private class PassData 
			{
				public Camera camera;
			}

			public override void RecordRenderGraph (RenderGraph renderGraph, ContextContainer frameData) 
			{
				var cameraData = frameData.Get<UniversalCameraData>();
				var resourceData = frameData.Get<UniversalResourceData>();

				using var builder = renderGraph.AddRasterRenderPass("Dear Im Gui", out PassData passData, profilingSampler);
				
				builder.SetRenderAttachment(resourceData.activeColorTexture, 0, AccessFlags.Write);
				builder.SetRenderAttachmentDepth(resourceData.activeDepthTexture);
				passData.camera = cameraData.camera;
				
				builder.SetRenderFunc((PassData data, RasterGraphContext context) => {
						ImGuiBehaviour.ExecuteCustomRenderGraphPass(new CommandBufferWrapper(context.cmd), data.camera);
					}
				);
			}

			public override void FrameCleanup (CommandBuffer cmd) { }
		}

		private DearImGuiURPRenderPass _scriptablePass;

		public override void Create () 
		{
			_scriptablePass = new DearImGuiURPRenderPass
			{
				renderPassEvent = RenderPassEvent.AfterRendering
			};
		}

		public override void AddRenderPasses (ScriptableRenderer renderer, ref RenderingData renderingData) 
		{
			// if (renderingData.cameraData.camera != Camera.main)
			// 	return;
			
			AddRenderPasses(renderer);
		}
		
		public void AddRenderPasses (ScriptableRenderer renderer) {
			if (!ImGuiBehaviour.IsEnabled)
				return;
			
			renderer.EnqueuePass(_scriptablePass);
		}
	}
}