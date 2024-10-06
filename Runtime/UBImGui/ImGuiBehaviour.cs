using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace UBImGui
{
    [DefaultExecutionOrder(1000)]
    public class ImGuiBehaviour : MonoBehaviour
    {
        private static ImGuiBehaviour _instance;

        private ImGuiController _controller;
        private CommandBuffer _cmd;
        private bool _isEnabled;
        private Action _layout;
        
        internal static bool IsEnabled => _instance?._isEnabled?? false;
        
        internal static event Action Layout
        {
            add
            {
                Initialize();
                _instance._layout += value;
            }
            remove
            {
                if(_instance)
                    _instance._layout -= value;
                else
                {
                    Debug.LogWarning("ImGuiBehaviour not found, Layout event not removed.");
                }
            }
        }
        
        internal static ImGuiController Controller => _instance?._controller;

        public static void Initialize()
        {
            if(_instance)
                return;
            
            if(!Application.isPlaying)
                throw new Exception("ImGuiBehaviour can only be initialized while the application is playing.");

            var gameObj = new GameObject("ImGuiBehaviour");
            
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
            _controller = new ImGuiController(Camera.main);
            // Camera.onPostRender += PostRender;
            StartCoroutine(ExecuteCommandBuffer());
        }


        private void OnDisable()
        {
            if (!_isEnabled)
                return;
            
            _isEnabled = false;
            _instance = null;
            _layout = null;
            _cmd.Dispose();
            _controller.Dispose();
            
            // Camera.onPostRender -= PostRender;
        }
        
        private void Update()
        {
            _controller.NewFrame();
            _layout?.Invoke();
        }
        // private void PostRender (Camera camera) 
        // {
        //     _cmd.Clear();
        //     Render(new CommandBufferWrapper(_cmd), camera);
        //
        //     
        // }
        
        IEnumerator ExecuteCommandBuffer()
        {
            while (true)
            {
                if (!_isEnabled)
                    yield break;
                
                _cmd.Clear();
                _controller.Render(new CommandBufferWrapper(_cmd), Camera.main);
                yield return new WaitForEndOfFrame();
                Graphics.ExecuteCommandBuffer(_cmd);
            }
        }
        
        private void Render(CommandBufferWrapper cmd, Camera camera)
        {
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
        
        internal static void ExecuteCustomRenderGraphPass(CommandBufferWrapper cmd, Camera camera)
        {
            if(!_instance || !_instance._isEnabled)
                return;
            
            _instance.Render(cmd, camera);
        }
    }
}