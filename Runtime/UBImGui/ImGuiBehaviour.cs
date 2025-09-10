using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
#if PACKAGE_UNIVERSAL_RP
using UnityEngine.Rendering.Universal;
#endif
#if PACKAGE_HIGH_DEFINITION_RP
using UnityEngine.Rendering.HighDefinition;
#endif

namespace UBImGui
{
    [DefaultExecutionOrder(1000)]
    public class ImGuiBehaviour : MonoBehaviour
    {
        private enum RenderPipelineOption
        {
            BuiltIn,
            Custom,
            URP,
            HDRP
        }
        
        private static ImGuiBehaviour _instance;

        private ImGuiController _controller;
        private CommandBuffer _cmd;
        private bool _isEnabled;
        private bool _renderInFront;
        private Camera _imguiCamera;
        
        private RenderPipelineOption _currentRenderPipeline = RenderPipelineOption.BuiltIn;
#if PACKAGE_UNIVERSAL_RP
        private DearImGuiRenderPassFeature _renderPassFeature;
#endif
        
        public static void Initialize()
        {
            if(_instance)
                return;
            
            if(!Application.isPlaying)
                throw new Exception("ImGuiBehaviour can only be initialized while the application is playing.");

            var gameObj = new GameObject("ImGuiBehaviour")
            {
#if !UBIMGUI_DEV_MODE
                hideFlags = HideFlags.NotEditable | HideFlags.HideInHierarchy | HideFlags.HideInInspector
#endif
            };
            
            _instance = gameObj.AddComponent<ImGuiBehaviour>();
            
            DontDestroyOnLoad(gameObj);
        }

        private void OnEnable()
        {
            if (!_instance)
                _instance = this;
        
            if (_instance != this)
            {
                DestroyImmediate(gameObject);
                return;
            }
            
            _isEnabled = true;
            _cmd = new CommandBuffer { name = "Dear ImGui" };
            CreateImGuiCamera();
            _controller = new ImGuiController(_imguiCamera);
            _controller.MakeCurrent();
            _controller.BaseCamera = Camera.main;
            _renderInFront = _controller.Settings.renderInFront;

            if (_renderInFront)
            {
                StartCoroutine(RenderInFront());
                return;
            }
            
            Camera.onPostRender += PostRender;
#if UNITY_2023_3_OR_NEWER
            RenderPipelineManager.beginContextRendering += BeginContextRendering;
#else
			RenderPipelineManager.beginFrameRendering += BeginFrameRendering;
#endif
            RenderPipelineManager.beginCameraRendering += BeginCameraRendering;
            RenderPipelineManager.endCameraRendering += EndCameraRendering;
        }
        
        private void OnDisable()
        {
            if (!_isEnabled)
                return;
            
            _isEnabled = false;
            _instance = null;
            _cmd.Dispose();
            _controller.Dispose();

            if (_renderInFront)
                return;
            
            Camera.onPostRender -= PostRender;
#if UNITY_2023_3_OR_NEWER
            RenderPipelineManager.beginContextRendering -= BeginContextRendering;
#else
			RenderPipelineManager.beginFrameRendering -= BeginFrameRendering;
#endif
            RenderPipelineManager.beginCameraRendering -= BeginCameraRendering;
            RenderPipelineManager.endCameraRendering -= EndCameraRendering;
            
#if PACKAGE_UNIVERSAL_RP
            AddToMainCameraStack();
            if (_renderPassFeature != null) 
            {
                DestroyImmediate(_renderPassFeature);
                _renderPassFeature = null;
            }
#endif
        }
        
        private void UpdateCurrentRenderPipeline()
        {
            var pipelineType = RenderPipelineManager.currentPipeline != null ? RenderPipelineManager.currentPipeline.GetType() : null;
            
#if PACKAGE_HIGH_DEFINITION_RP
            if (pipelineType == typeof(HDRenderPipeline)) {
                if (_currentRenderPipeline != RenderPipelineOption.HDRP) {
                    _currentRenderPipeline = RenderPipelineOption.HDRP;
                    if (!_instance.gameObject.TryGetComponent(out CustomPassVolume volume)) {
                        volume = _instance.gameObject.AddComponent<CustomPassVolume>();
                        volume.isGlobal = true;
                        volume.injectionPoint = CustomPassInjectionPoint.AfterPostProcess;
                        volume.customPasses.Add(new DearImGuiHDRPCustomPass());
                    }

                    var asset = GraphicsSettings.defaultRenderPipeline as HDRenderPipelineAsset;
                    if (asset != null) {
                        if (!asset.currentPlatformRenderPipelineSettings.supportCustomPass) {
                            Debug.LogWarning("UB ImGui: Custom pass support is disabled in the current render pipeline. Please enable it in the HDRenderPipelineAsset.", asset);
                        }
                    }
                }
                return;
            }
#endif
#if PACKAGE_UNIVERSAL_RP
            if (pipelineType == typeof(UniversalRenderPipeline)) {
                _currentRenderPipeline = RenderPipelineOption.URP;
                return;
            }
#endif
            _currentRenderPipeline = pipelineType != null ? RenderPipelineOption.Custom : RenderPipelineOption.BuiltIn;
        }
        
        private void CreateImGuiCamera()
        {
            var cameraObj = new GameObject("ImGui Camera");
            cameraObj.transform.SetParent(transform);

            _imguiCamera = cameraObj.AddComponent<Camera>();
            _imguiCamera.clearFlags = CameraClearFlags.Nothing;
            _imguiCamera.cullingMask = 0; // Not render any geometry
            _imguiCamera.orthographic = true;
            _imguiCamera.orthographicSize = 1;
            _imguiCamera.nearClipPlane = -1;
            _imguiCamera.farClipPlane = 1;
            
            _imguiCamera.rect = new Rect(0, 0, 1, 1);
            _imguiCamera.depth = float.MaxValue;
            
#if PACKAGE_UNIVERSAL_RP
            var urpData = _imguiCamera.GetUniversalAdditionalCameraData();
            if (!urpData) return;
            urpData.renderPostProcessing = false;
            urpData.renderShadows = false;
            urpData.requiresColorOption = CameraOverrideOption.Off;
            urpData.requiresDepthOption = CameraOverrideOption.Off;
            urpData.renderType = CameraRenderType.Overlay;
            AddToMainCameraStack();
#endif
        }
        
#if PACKAGE_UNIVERSAL_RP
        private void AddToMainCameraStack()
        {
            var mainCamera = Camera.main;
            if (!mainCamera) return;

            var mainCameraData = mainCamera.GetUniversalAdditionalCameraData();
            if (!mainCameraData) return;

            var cameraStack = mainCameraData.cameraStack;
            if (!cameraStack.Contains(_imguiCamera))
            {
                cameraStack.Add(_imguiCamera);
            }
        }

        private void RemoveFromMainCameraStack()
        {
            var mainCamera = Camera.main;
            if (!mainCamera) return;

            var mainCameraData = mainCamera.GetUniversalAdditionalCameraData();
            if (!mainCameraData) return;

            var cameraStack = mainCameraData.cameraStack;
            if (cameraStack.Contains(_imguiCamera))
            {
                cameraStack.Remove(_imguiCamera);
            }
        }
#endif
        
        private void Update()
        {
            _controller.NewFrame();
        }
        
        private void PostRender (Camera camera) 
        {
            _cmd.Clear();
            Render(new CommandBufferWrapper(_cmd), camera);
            Graphics.ExecuteCommandBuffer(_cmd);
        }
        
        void BeginContextRendering (ScriptableRenderContext context, List<Camera> cameras) 
        {
            UpdateCurrentRenderPipeline();
        }

        void BeginFrameRendering (ScriptableRenderContext context, Camera[] cameras) 
        {
            UpdateCurrentRenderPipeline();
        }

        void BeginCameraRendering (ScriptableRenderContext context, Camera camera) 
        {
#if PACKAGE_UNIVERSAL_RP
            if (_currentRenderPipeline == RenderPipelineOption.URP) 
            {
                var data = camera.GetUniversalAdditionalCameraData();
                if (data != null) {
                    var renderer = data.scriptableRenderer;
                    if (_renderPassFeature == null) {
                        _renderPassFeature = ScriptableObject.CreateInstance<DearImGuiRenderPassFeature>();
                    }
                    _renderPassFeature.AddRenderPasses(renderer, camera);
                }
            }
#endif
        }
        
        private void EndCameraRendering (ScriptableRenderContext context, Camera camera) {
            if (_currentRenderPipeline == RenderPipelineOption.Custom) 
            {
                ExecuteCustomRenderPass(context, camera);
            }
        }
        
        private IEnumerator RenderInFront()
        {
            while (_renderInFront)
            {
                if (!_isEnabled)
                    yield break;
                
                _cmd.Clear();
                _controller.Render(new CommandBufferWrapper(_cmd), _controller.CameraToRender);
                yield return new WaitForEndOfFrame();
                Graphics.ExecuteCommandBuffer(_cmd);
            }
        }
        
        private void Render(in CommandBufferWrapper cmd, Camera camera)
        {
            if (!_renderInFront)
                _controller.Render(cmd, camera);
        }

        internal static void ExecuteCustomRenderPass(ScriptableRenderContext context, Camera camera)
        {
            if(!_instance._isEnabled)
                return;
            
            _instance._cmd.Clear();
            _instance.Render(new CommandBufferWrapper(_instance._cmd), camera);
            context.ExecuteCommandBuffer(_instance._cmd);
        }
        
#if PACKAGE_UNIVERSAL_RP
        internal static void ExecuteCustomRenderGraphPass(in CommandBufferWrapper cmd, Camera camera)
        {
            if(!_instance || !_instance._isEnabled)
                return;
            
            _instance.Render(cmd, camera);
        }
#endif
        
#if PACKAGE_HIGH_DEFINITION_RP
        internal static void ExecuteCustomPass(CommandBuffer cmd, Camera camera)
        {
            if(!_instance._isEnabled)
                return;
            
            _instance.Render(new CommandBufferWrapper(cmd), camera);
        }
#endif
    }
}