#if PACKAGE_HIGH_DEFINITION_RP
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Rendering;

namespace UBImGui {
	class DearImGuiHDRPCustomPass : CustomPass 
	{
		protected override void Setup (ScriptableRenderContext renderContext, CommandBuffer cmd) { }

#if PACKAGE_HIGH_DEFINITION_RP_9_0_OR_NEWER
		protected override void Execute (CustomPassContext context) 
		{
			ImGuiBehaviour.ExecuteCustomPass(context.cmd, context.hdCamera.camera);
		}
#else
		protected override void Execute (ScriptableRenderContext context, CommandBuffer cmd, HDCamera camera, CullingResults cullingResult) 
		{
			ImGuiBehaviour.ExecuteCustomPass(cmd, camera.camera);
		}
#endif

		protected override void Cleanup () { }
	}
}
#endif