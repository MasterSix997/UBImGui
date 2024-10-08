﻿using System;
using ImGuiNET;
using NUnit.Framework;
using UnityEngine;
namespace UBImGui
{
    public class ImGuiController : IDisposable
    {
        private bool _frameBegun;

        private IInputHandler _inputHandler;
        private IImGuiRenderer _renderer;
        private ImGuiTextures _textures;
        private ClipboardHandler _clipboardHandler;
        private UBImGuiSettings _settings;
        private Camera _camera;
        
        public IntPtr Context { get; private set; }
        
        internal ImGuiTextures Textures => _textures;
        
        public ImGuiController(Camera camera)
        {
            _inputHandler = new InputManagerHandler();
            _textures = new ImGuiTextures();
            _camera = camera;
            _clipboardHandler = new ClipboardHandler();
            
            Initialize();
        }

        private void Initialize()
        {
            Context = ImGui.CreateContext();
            ImGui.SetCurrentContext(Context);
            // ImGui.StyleColorsDark();
            
            var io = ImGui.GetIO();

            _settings = UBImGuiSettingsPersistent.GetSettings();
            _settings.ApplyTo(ImGui.GetStyle());
            if (_settings.iniSettingsSize > 0)
                ImGui.LoadIniSettingsFromMemory(_settings.iniSettings, _settings.iniSettingsSize);
            
            _inputHandler.Initialize(io);
            _textures.BuildFontAtlas(io, _settings.fontAsset);
            _textures.BuildAtlasTexture(io);
            _renderer = new GraphicsBufferRenderer(io, _textures);
            _clipboardHandler.Assign(io);
            
            ImGui.NewFrame();
            _frameBegun = true;
            
        }

        public void NewFrame()
        {
            var io = ImGui.GetIO();
            if (_frameBegun)
            {
                ImGui.Render();
            }
            
            SetPerFrameImGuiData();
            _inputHandler.Update(io);
            _textures.UpdateTextures(io);
            _frameBegun = true;
            
            ImGui.NewFrame();
        }

        private void SetPerFrameImGuiData()
        {
            var io = ImGui.GetIO();
            io.DisplaySize = new Vector2(_camera.pixelRect.width, _camera.pixelRect.height);
            
            io.DeltaTime = Time.unscaledDeltaTime;

            if (io.WantSaveIniSettings)
            {
                _settings.iniSettings = ImGui.SaveIniSettingsToMemory(out var size);
                _settings.iniSettingsSize = size;
                io.WantSaveIniSettings = false;
            }
        }

        public void Render(CommandBufferWrapper cmd, Camera camera)
        {
            if(_camera != camera)
                return;
            
            if(!_frameBegun)
                return;

            _frameBegun = false;
            ImGui.Render();

            var drawData = ImGui.GetDrawData();
            var frameBufferSize = drawData.DisplaySize * drawData.FramebufferScale;
            if (frameBufferSize.x <= 0 || frameBufferSize.y <= 0)
                return;
            
            _renderer.UpdateBuffers(drawData);
            _renderer.Render(cmd, drawData, frameBufferSize);
        }

        public void Dispose()
        {
            var io = ImGui.GetIO();
            _textures.Dispose();
            _renderer.Dispose();
            _clipboardHandler.Unset(io);
            _clipboardHandler.Dispose();
            ImGui.DestroyContext(Context);
            Context = IntPtr.Zero;
        }
    }
}