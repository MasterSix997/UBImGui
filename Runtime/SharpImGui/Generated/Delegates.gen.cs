using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace SharpImGui
{
	/// <summary>
	/// <para>Callback and functions types</para>
	/// </summary>
	/// <summary>
	/// Callback function for ImGui::InputText()
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int ImGuiInputTextCallback(ImGuiInputTextCallbackDataPtr data);
	/// <summary>
	/// Callback function for ImGui::SetNextWindowSizeConstraints()
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiSizeCallback(ImGuiSizeCallbackDataPtr data);
	/// <summary>
	/// Function signature for ImGui::SetAllocatorFunctions()
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void* ImGuiMemAllocFunc(uint sz, IntPtr user_data);
	/// <summary>
	/// Function signature for ImGui::SetAllocatorFunctions()
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiMemFreeFunc(IntPtr ptr, IntPtr user_data);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImDrawCallback(ImDrawListPtr parent_list, ImDrawCmdPtr cmd);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate uint AdapterIndexToStorageIdDelegate(ImGuiSelectionBasicStoragePtr self, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void AdapterSetItemSelectedDelegate(ImGuiSelectionExternalStoragePtr self, int idx, byte selected);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* Platform_GetClipboardTextFnDelegate(IntPtr ctx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetClipboardTextFnDelegate(IntPtr ctx, byte* text);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte Platform_OpenInShellFnDelegate(IntPtr ctx, byte* path);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetImeDataFnDelegate(IntPtr ctx, ImGuiViewportPtr viewport, ImGuiPlatformImeDataPtr data);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_CreateWindowDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_DestroyWindowDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_ShowWindowDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetWindowPosDelegate(ImGuiViewportPtr vp, Vector2 pos);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2 Platform_GetWindowPosDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetWindowSizeDelegate(ImGuiViewportPtr vp, Vector2 size);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector2 Platform_GetWindowSizeDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetWindowFocusDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte Platform_GetWindowFocusDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte Platform_GetWindowMinimizedDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetWindowTitleDelegate(ImGuiViewportPtr vp, byte* str);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SetWindowAlphaDelegate(ImGuiViewportPtr vp, float alpha);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_UpdateWindowDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_RenderWindowDelegate(ImGuiViewportPtr vp, IntPtr render_arg);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_SwapBuffersDelegate(ImGuiViewportPtr vp, IntPtr render_arg);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float Platform_GetWindowDpiScaleDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Platform_OnChangedViewportDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate Vector4 Platform_GetWindowWorkAreaInsetsDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate int Platform_CreateVkSurfaceDelegate(ImGuiViewportPtr vp, ulong vk_inst, IntPtr vk_allocators, ulong* out_vk_surface);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Renderer_CreateWindowDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Renderer_DestroyWindowDelegate(ImGuiViewportPtr vp);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Renderer_SetWindowSizeDelegate(ImGuiViewportPtr vp, Vector2 size);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Renderer_RenderWindowDelegate(ImGuiViewportPtr vp, IntPtr render_arg);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void Renderer_SwapBuffersDelegate(ImGuiViewportPtr vp, IntPtr render_arg);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_ComboCallbackgetterDelegate(IntPtr user_data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_ComboCallbackExgetterDelegate(IntPtr user_data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_ListBoxCallbackgetterDelegate(IntPtr user_data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_ListBoxCallbackExgetterDelegate(IntPtr user_data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float ImGui_PlotLinesCallbackvalues_getterDelegate(IntPtr data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float ImGui_PlotLinesCallbackExvalues_getterDelegate(IntPtr data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float ImGui_PlotHistogramCallbackvalues_getterDelegate(IntPtr data, int idx);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float ImGui_PlotHistogramCallbackExvalues_getterDelegate(IntPtr data, int idx);
}
