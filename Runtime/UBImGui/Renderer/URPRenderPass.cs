#if PACKAGE_UNIVERSAL_RP
using UBImGui;
using UnityEngine;
using UnityEngine.Rendering;
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
using UnityEngine.Rendering.RenderGraphModule;
#endif
using UnityEngine.Rendering.Universal;

namespace UBImGui 
{
	public class DearImGuiRenderPassFeature : ScriptableRendererFeature 
	{
		public class DearImGuiURPRenderPass : ScriptableRenderPass 
		{
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
			[System.Obsolete]
#endif
			public override void Configure (CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
			[System.Obsolete]
#endif
			public override void Execute (ScriptableRenderContext context, ref RenderingData renderingData) 
			{
				ImGuiBehaviour.ExecuteCustomRenderPass(context, renderingData.cameraData.camera);
			}
			
#if PACKAGE_UNIVERSAL_RP_17_0_0_OR_NEWER
			private class PassData 
			{
				public Camera camera;
			}

			public override void RecordRenderGraph (RenderGraph renderGraph, ContextContainer frameData) 
			{
				var cameraData = frameData.Get<UniversalCameraData>();
				var resourceData = frameData.Get<UniversalResourceData>();

				using var builder = renderGraph.AddRasterRenderPass("Dear Im Gui", out PassData passData, profilingSampler);
				
				builder.SetRenderAttachment(resourceData.activeColorTexture, 0);
				builder.SetRenderAttachmentDepth(resourceData.activeDepthTexture);
				passData.camera = cameraData.camera;
				
				builder.SetRenderFunc((PassData data, RasterGraphContext context) => {
						ImGuiBehaviour.ExecuteCustomRenderGraphPass(new CommandBufferWrapper(context.cmd), data.camera);
					}
				);
			}
#endif

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
			AddRenderPasses(renderer, renderingData.cameraData.camera);
		}
		
		public void AddRenderPasses (ScriptableRenderer renderer, Camera camera) {
			if (!ImGuiController.HasController || 
			    ImGuiController.CurrentController.CameraToRender != camera)
				return;
			
			renderer.EnqueuePass(_scriptablePass);
		}
	}
}
#endif