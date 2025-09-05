using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public unsafe delegate int ImGuiInputTextCallback(ImGuiInputTextCallbackData* data);

	public unsafe delegate void ImGuiSizeCallback(ImGuiSizeCallbackData* data);

	public unsafe delegate void* ImGuiMemAllocFunc(uint sz, void* userData);

	public unsafe delegate void ImGuiMemFreeFunc(void* ptr, void* userData);

	public unsafe delegate void ImDrawCallback(ImDrawList* parentList, ImDrawCmd* cmd);

	public unsafe delegate void ImGuiErrorCallback(ImGuiContext* ctx, void* userData, byte* msg);

	public unsafe delegate void ImGuiContextHookCallback(ImGuiContext* ctx, ImGuiContextHook* hook);

	public unsafe delegate byte FontBuilderBuild(ImFontAtlas* atlas);

	public unsafe delegate void DockNodeWindowMenuHandler(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tabBar);

	public unsafe delegate byte* PlatformGetClipboardTextFn(ImGuiContext* ctx);

	public unsafe delegate void PlatformSetClipboardTextFn(ImGuiContext* ctx, byte* text);

	public unsafe delegate byte PlatformOpenInShellFn(ImGuiContext* ctx, byte* path);

	public unsafe delegate void PlatformSetImeDataFn(ImGuiContext* ctx, ImGuiViewport* viewport, ImGuiPlatformImeData* data);

	public unsafe delegate void PlatformCreateWindow(ImGuiViewport* vp);

	public unsafe delegate void PlatformDestroyWindow(ImGuiViewport* vp);

	public unsafe delegate void PlatformShowWindow(ImGuiViewport* vp);

	public unsafe delegate void PlatformSetWindowPos(ImGuiViewport* vp, Vector2 pos);

	public unsafe delegate Vector2 PlatformGetWindowPos(ImGuiViewport* vp);

	public unsafe delegate void PlatformSetWindowSize(ImGuiViewport* vp, Vector2 size);

	public unsafe delegate Vector2 PlatformGetWindowSize(ImGuiViewport* vp);

	public unsafe delegate void PlatformSetWindowFocus(ImGuiViewport* vp);

	public unsafe delegate byte PlatformGetWindowFocus(ImGuiViewport* vp);

	public unsafe delegate byte PlatformGetWindowMinimized(ImGuiViewport* vp);

	public unsafe delegate void PlatformSetWindowTitle(ImGuiViewport* vp, byte* str);

	public unsafe delegate void PlatformSetWindowAlpha(ImGuiViewport* vp, float alpha);

	public unsafe delegate void PlatformUpdateWindow(ImGuiViewport* vp);

	public unsafe delegate void PlatformRenderWindow(ImGuiViewport* vp, void* renderArg);

	public unsafe delegate void PlatformSwapBuffers(ImGuiViewport* vp, void* renderArg);

	public unsafe delegate float PlatformGetWindowDpiScale(ImGuiViewport* vp);

	public unsafe delegate void PlatformOnChangedViewport(ImGuiViewport* vp);

	public unsafe delegate Vector4 PlatformGetWindowWorkAreaInsets(ImGuiViewport* vp);

	public unsafe delegate int PlatformCreateVkSurface(ImGuiViewport* vp, ulong vkInst, void* vkAllocators, ulong* outVkSurface);

	public unsafe delegate void RendererCreateWindow(ImGuiViewport* vp);

	public unsafe delegate void RendererDestroyWindow(ImGuiViewport* vp);

	public unsafe delegate void RendererSetWindowSize(ImGuiViewport* vp, Vector2 size);

	public unsafe delegate void RendererRenderWindow(ImGuiViewport* vp, void* renderArg);

	public unsafe delegate void RendererSwapBuffers(ImGuiViewport* vp, void* renderArg);

	public unsafe delegate uint AdapterIndexToStorageId(ImGuiSelectionBasicStorage* self, int idx);

	public unsafe delegate void AdapterSetItemSelected(ImGuiSelectionExternalStorage* self, int idx, byte selected);

	public unsafe delegate void ClearAllFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void ReadInitFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void* ReadOpenFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler, byte* name);

	public unsafe delegate void ReadLineFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler, void* entry, byte* line);

	public unsafe delegate void ApplyAllFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler);

	public unsafe delegate void WriteAllFn(ImGuiContext* ctx, ImGuiSettingsHandler* handler, ImGuiTextBuffer* outBuf);

	public unsafe delegate byte* IgComboGetter(void* userData, int idx);

	public unsafe delegate byte* IgListBoxFnStrPtrGetter(void* userData, int idx);

	public unsafe delegate float IgPlotLinesValuesGetter(void* data, int idx);

	public unsafe delegate float IgPlotHistogramValuesGetter(void* data, int idx);

	public unsafe delegate int IgImQsortCompareFunc(void* arg0, void* arg1);

	public unsafe delegate byte* IgTypingSelectFindMatchGetItemNameFunc(void* arg0, int arg1);

	public unsafe delegate byte* IgTypingSelectFindNextSingleCharMatchGetItemNameFunc(void* arg0, int arg1);

	public unsafe delegate byte* IgTypingSelectFindBestLeadingMatchGetItemNameFunc(void* arg0, int arg1);

	public unsafe delegate float IgPlotExValuesGetter(void* data, int idx);

	public unsafe delegate void ImGuiPlatformIOSetPlatformGetWindowPosUserCallback(ImGuiViewport* vp, Vector2* outPos);

	public unsafe delegate void ImGuiPlatformIOSetPlatformGetWindowSizeUserCallback(ImGuiViewport* vp, Vector2* outSize);
}
