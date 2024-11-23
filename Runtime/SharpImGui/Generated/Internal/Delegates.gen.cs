using System;
using UnityEngine;
using System.Runtime.InteropServices;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>The error callback is currently not public, as it is expected that only advanced users will rely on it.</para>
	/// </summary>
	/// <summary>
	/// Function signature for g.ErrorCallback
	/// </summary>
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiErrorCallback(ImGuiContextPtr ctx, IntPtr user_data, byte* msg);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ImGuiContextHookCallback(ImGuiContextPtr ctx, ImGuiContextHookPtr hook);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ClearAllFnDelegate(ImGuiContextPtr ctx, ImGuiSettingsHandlerPtr handler);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadInitFnDelegate(ImGuiContextPtr ctx, ImGuiSettingsHandlerPtr handler);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void* ReadOpenFnDelegate(ImGuiContextPtr ctx, ImGuiSettingsHandlerPtr handler, byte* name);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ReadLineFnDelegate(ImGuiContextPtr ctx, ImGuiSettingsHandlerPtr handler, IntPtr entry, byte* line);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ApplyAllFnDelegate(ImGuiContextPtr ctx, ImGuiSettingsHandlerPtr handler);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void WriteAllFnDelegate(ImGuiContextPtr ctx, ImGuiSettingsHandlerPtr handler, ImGuiTextBufferPtr out_buf);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void DockNodeWindowMenuHandlerDelegate(ImGuiContextPtr ctx, ImGuiDockNodePtr node, ImGuiTabBarPtr tab_bar);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte FontBuilder_BuildDelegate(ImFontAtlasPtr atlas);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_TypingSelectFindMatchget_item_name_funcDelegate(IntPtr arg0, int arg1);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_TypingSelectFindNextSingleCharMatchget_item_name_funcDelegate(IntPtr arg0, int arg1);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate byte* ImGui_TypingSelectFindBestLeadingMatchget_item_name_funcDelegate(IntPtr arg0, int arg1);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate float ImGui_PlotExvalues_getterDelegate(IntPtr data, int idx);
}
