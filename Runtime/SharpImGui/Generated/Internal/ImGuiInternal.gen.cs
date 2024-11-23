using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Text;
// ReSharper disable InconsistentNaming

namespace SharpImGui.Internal
{
	public static unsafe partial class ImGuiInternal
	{

		/// <summary>
		/// <para>Windows</para>
		/// <para>We should always have a CurrentWindow in the stack (there is an implicit "Debug" window)</para>
		/// <para>If this ever crashes because g.CurrentWindow is NULL, it means that either:</para>
		/// <para>- ImGui::NewFrame() has never been called, which is illegal.</para>
		/// <para>- You are calling ImGui functions after ImGui::EndFrame()/ImGui::Render() and before the next ImGui::NewFrame(), which is also illegal.</para>
		/// </summary>
		public static ImGuiIOPtr GetIO(ImGuiContextPtr ctx)
		{
			var ret = ImGuiInternalNative.ImGui_GetIOEx(ctx);
			return ret;
		}

		public static ImGuiPlatformIOPtr GetPlatformIO(ImGuiContextPtr ctx)
		{
			var ret = ImGuiInternalNative.ImGui_GetPlatformIOEx(ctx);
			return ret;
		}

		public static ImGuiWindowPtr GetCurrentWindowRead()
		{
			var ret = ImGuiInternalNative.ImGui_GetCurrentWindowRead();
			return ret;
		}

		public static ImGuiWindowPtr GetCurrentWindow()
		{
			var ret = ImGuiInternalNative.ImGui_GetCurrentWindow();
			return ret;
		}

		public static ImGuiWindowPtr FindWindowByID(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_FindWindowByID(id);
			return ret;
		}

		public static ImGuiWindowPtr FindWindowByName(ReadOnlySpan<char> name)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var ret = ImGuiInternalNative.ImGui_FindWindowByName(native_name);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret;
		}

		public static void UpdateWindowParentAndRootLinks(ImGuiWindowPtr window, ImGuiWindowFlags flags, ImGuiWindowPtr parent_window)
		{
			ImGuiInternalNative.ImGui_UpdateWindowParentAndRootLinks(window, flags, parent_window);
		}

		public static void UpdateWindowSkipRefresh(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_UpdateWindowSkipRefresh(window);
		}

		public static Vector2 CalcWindowNextAutoFitSize(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_CalcWindowNextAutoFitSize(window);
			return ret;
		}

		public static bool IsWindowChildOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent, bool popup_hierarchy, bool dock_hierarchy)
		{
			// Marshaling 'popup_hierarchy' to native bool
			var native_popup_hierarchy = popup_hierarchy ? (byte)1 : (byte)0;

			// Marshaling 'dock_hierarchy' to native bool
			var native_dock_hierarchy = dock_hierarchy ? (byte)1 : (byte)0;

			var ret = ImGuiInternalNative.ImGui_IsWindowChildOf(window, potential_parent, native_popup_hierarchy, native_dock_hierarchy);
			return ret != 0;
		}

		public static bool IsWindowWithinBeginStackOf(ImGuiWindowPtr window, ImGuiWindowPtr potential_parent)
		{
			var ret = ImGuiInternalNative.ImGui_IsWindowWithinBeginStackOf(window, potential_parent);
			return ret != 0;
		}

		public static bool IsWindowAbove(ImGuiWindowPtr potential_above, ImGuiWindowPtr potential_below)
		{
			var ret = ImGuiInternalNative.ImGui_IsWindowAbove(potential_above, potential_below);
			return ret != 0;
		}

		public static bool IsWindowNavFocusable(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_IsWindowNavFocusable(window);
			return ret != 0;
		}

		public static void SetWindowPosImGuiWindowPtr(ImGuiWindowPtr window, Vector2 pos)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiInternalNative.ImGui_SetWindowPosImGuiWindowPtr(window, pos, cond);
		}
		public static void SetWindowPosImGuiWindowPtr(ImGuiWindowPtr window, Vector2 pos, ImGuiCond cond)
		{
			ImGuiInternalNative.ImGui_SetWindowPosImGuiWindowPtr(window, pos, cond);
		}

		public static void SetWindowSizeImGuiWindowPtr(ImGuiWindowPtr window, Vector2 size)
		{
			ImGuiCond cond = (ImGuiCond)0;

			ImGuiInternalNative.ImGui_SetWindowSizeImGuiWindowPtr(window, size, cond);
		}
		public static void SetWindowSizeImGuiWindowPtr(ImGuiWindowPtr window, Vector2 size, ImGuiCond cond)
		{
			ImGuiInternalNative.ImGui_SetWindowSizeImGuiWindowPtr(window, size, cond);
		}

		public static void SetWindowCollapsedImGuiWindowPtr(ImGuiWindowPtr window, bool collapsed)
		{
			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiCond cond = (ImGuiCond)0;

			ImGuiInternalNative.ImGui_SetWindowCollapsedImGuiWindowPtr(window, native_collapsed, cond);
		}
		public static void SetWindowCollapsedImGuiWindowPtr(ImGuiWindowPtr window, bool collapsed, ImGuiCond cond)
		{
			// Marshaling 'collapsed' to native bool
			var native_collapsed = collapsed ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_SetWindowCollapsedImGuiWindowPtr(window, native_collapsed, cond);
		}

		public static void SetWindowHitTestHole(ImGuiWindowPtr window, Vector2 pos, Vector2 size)
		{
			ImGuiInternalNative.ImGui_SetWindowHitTestHole(window, pos, size);
		}

		public static void SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_SetWindowHiddenAndSkipItemsForCurrentFrame(window);
		}

		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.
		/// </summary>
		public static void SetWindowParentWindowForFocusRoute(ImGuiWindowPtr window, ImGuiWindowPtr parent_window)
		{
			ImGuiInternalNative.ImGui_SetWindowParentWindowForFocusRoute(window, parent_window);
		}

		public static ImRect WindowRectAbsToRel(ImGuiWindowPtr window, ImRect r)
		{
			var ret = ImGuiInternalNative.ImGui_WindowRectAbsToRel(window, r);
			return ret;
		}

		public static ImRect WindowRectRelToAbs(ImGuiWindowPtr window, ImRect r)
		{
			var ret = ImGuiInternalNative.ImGui_WindowRectRelToAbs(window, r);
			return ret;
		}

		public static Vector2 WindowPosAbsToRel(ImGuiWindowPtr window, Vector2 p)
		{
			var ret = ImGuiInternalNative.ImGui_WindowPosAbsToRel(window, p);
			return ret;
		}

		public static Vector2 WindowPosRelToAbs(ImGuiWindowPtr window, Vector2 p)
		{
			var ret = ImGuiInternalNative.ImGui_WindowPosRelToAbs(window, p);
			return ret;
		}

		/// <summary>
		/// <para>Windows: Display Order and Focus Order</para>
		/// </summary>
		public static void FocusWindow(ImGuiWindowPtr window)
		{
			ImGuiFocusRequestFlags flags = (ImGuiFocusRequestFlags)0;

			ImGuiInternalNative.ImGui_FocusWindow(window, flags);
		}
		/// <summary>
		/// <para>Windows: Display Order and Focus Order</para>
		/// </summary>
		public static void FocusWindow(ImGuiWindowPtr window, ImGuiFocusRequestFlags flags)
		{
			ImGuiInternalNative.ImGui_FocusWindow(window, flags);
		}

		public static void FocusTopMostWindowUnderOne(ImGuiWindowPtr under_this_window, ImGuiWindowPtr ignore_window, ImGuiViewportPtr filter_viewport, ImGuiFocusRequestFlags flags)
		{
			ImGuiInternalNative.ImGui_FocusTopMostWindowUnderOne(under_this_window, ignore_window, filter_viewport, flags);
		}

		public static void BringWindowToFocusFront(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_BringWindowToFocusFront(window);
		}

		public static void BringWindowToDisplayFront(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_BringWindowToDisplayFront(window);
		}

		public static void BringWindowToDisplayBack(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_BringWindowToDisplayBack(window);
		}

		public static void BringWindowToDisplayBehind(ImGuiWindowPtr window, ImGuiWindowPtr above_window)
		{
			ImGuiInternalNative.ImGui_BringWindowToDisplayBehind(window, above_window);
		}

		public static int FindWindowDisplayIndex(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_FindWindowDisplayIndex(window);
			return ret;
		}

		public static ImGuiWindowPtr FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_FindBottomMostVisibleWindowWithinBeginStack(window);
			return ret;
		}

		/// <summary>
		/// <para>Windows: Idle, Refresh Policies [EXPERIMENTAL]</para>
		/// </summary>
		public static void SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags)
		{
			ImGuiInternalNative.ImGui_SetNextWindowRefreshPolicy(flags);
		}

		/// <summary>
		/// <para>Fonts, drawing</para>
		/// </summary>
		public static void SetCurrentFont(ImFontPtr font)
		{
			ImGuiInternalNative.ImGui_SetCurrentFont(font);
		}

		public static ImFontPtr GetDefaultFont()
		{
			var ret = ImGuiInternalNative.ImGui_GetDefaultFont();
			return ret;
		}

		public static ImDrawListPtr GetForegroundDrawListImGuiWindowPtr(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_GetForegroundDrawListImGuiWindowPtr(window);
			return ret;
		}

		public static void AddDrawListToDrawData(ImDrawDataPtr draw_data, ImVector* out_list, ImDrawListPtr draw_list)
		{
			ImGuiInternalNative.ImGui_AddDrawListToDrawDataEx(draw_data, out_list, draw_list);
		}

		/// <summary>
		/// <para>Init</para>
		/// </summary>
		public static void Initialize()
		{
			ImGuiInternalNative.ImGui_Initialize();
		}

		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().
		/// </summary>
		public static void Shutdown()
		{
			ImGuiInternalNative.ImGui_Shutdown();
		}

		/// <summary>
		/// <para>NewFrame</para>
		/// </summary>
		public static void UpdateInputEvents(bool trickle_fast_inputs)
		{
			// Marshaling 'trickle_fast_inputs' to native bool
			var native_trickle_fast_inputs = trickle_fast_inputs ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_UpdateInputEvents(native_trickle_fast_inputs);
		}

		public static void UpdateHoveredWindowAndCaptureFlags()
		{
			ImGuiInternalNative.ImGui_UpdateHoveredWindowAndCaptureFlags();
		}

		public static void FindHoveredWindow(Vector2 pos, bool find_first_and_in_any_viewport, out ImGuiWindow* out_hovered_window, out ImGuiWindow* out_hovered_window_under_moving_window)
		{
			// Marshaling 'find_first_and_in_any_viewport' to native bool
			var native_find_first_and_in_any_viewport = find_first_and_in_any_viewport ? (byte)1 : (byte)0;

			fixed (ImGuiWindow** native_out_hovered_window = &out_hovered_window)
			fixed (ImGuiWindow** native_out_hovered_window_under_moving_window = &out_hovered_window_under_moving_window)
			{
				ImGuiInternalNative.ImGui_FindHoveredWindowEx(pos, native_find_first_and_in_any_viewport, native_out_hovered_window, native_out_hovered_window_under_moving_window);
			}
		}

		public static void StartMouseMovingWindow(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_StartMouseMovingWindow(window);
		}

		public static void StartMouseMovingWindowOrNode(ImGuiWindowPtr window, ImGuiDockNodePtr node, bool undock)
		{
			// Marshaling 'undock' to native bool
			var native_undock = undock ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_StartMouseMovingWindowOrNode(window, node, native_undock);
		}

		public static void UpdateMouseMovingWindowNewFrame()
		{
			ImGuiInternalNative.ImGui_UpdateMouseMovingWindowNewFrame();
		}

		public static void UpdateMouseMovingWindowEndFrame()
		{
			ImGuiInternalNative.ImGui_UpdateMouseMovingWindowEndFrame();
		}

		/// <summary>
		/// <para>Generic context hooks</para>
		/// </summary>
		public static uint AddContextHook(ImGuiContextPtr context, ImGuiContextHookPtr hook)
		{
			var ret = ImGuiInternalNative.ImGui_AddContextHook(context, hook);
			return ret;
		}

		public static void RemoveContextHook(ImGuiContextPtr context, uint hook_to_remove)
		{
			ImGuiInternalNative.ImGui_RemoveContextHook(context, hook_to_remove);
		}

		public static void CallContextHooks(ImGuiContextPtr context, ImGuiContextHookType type)
		{
			ImGuiInternalNative.ImGui_CallContextHooks(context, type);
		}

		/// <summary>
		/// <para>Viewports</para>
		/// </summary>
		public static void TranslateWindowsInViewport(ImGuiViewportPPtr viewport, Vector2 old_pos, Vector2 new_pos, Vector2 old_size, Vector2 new_size)
		{
			ImGuiInternalNative.ImGui_TranslateWindowsInViewport(viewport, old_pos, new_pos, old_size, new_size);
		}

		public static void ScaleWindowsInViewport(ImGuiViewportPPtr viewport, float scale)
		{
			ImGuiInternalNative.ImGui_ScaleWindowsInViewport(viewport, scale);
		}

		public static void DestroyPlatformWindow(ImGuiViewportPPtr viewport)
		{
			ImGuiInternalNative.ImGui_DestroyPlatformWindow(viewport);
		}

		public static void SetWindowViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
		{
			ImGuiInternalNative.ImGui_SetWindowViewport(window, viewport);
		}

		public static void SetCurrentViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
		{
			ImGuiInternalNative.ImGui_SetCurrentViewport(window, viewport);
		}

		public static ImGuiPlatformMonitorPtr GetViewportPlatformMonitor(ImGuiViewportPtr viewport)
		{
			var ret = ImGuiInternalNative.ImGui_GetViewportPlatformMonitor(viewport);
			return ret;
		}

		public static ImGuiViewportPPtr FindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos)
		{
			var ret = ImGuiInternalNative.ImGui_FindHoveredViewportFromPlatformWindowStack(mouse_platform_pos);
			return ret;
		}

		/// <summary>
		/// <para>Settings</para>
		/// </summary>
		public static void MarkIniSettingsDirty()
		{
			ImGuiInternalNative.ImGui_MarkIniSettingsDirty();
		}

		public static void MarkIniSettingsDirtyImGuiWindowPtr(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_MarkIniSettingsDirtyImGuiWindowPtr(window);
		}

		public static void ClearIniSettings()
		{
			ImGuiInternalNative.ImGui_ClearIniSettings();
		}

		public static void AddSettingsHandler(ImGuiSettingsHandlerPtr handler)
		{
			ImGuiInternalNative.ImGui_AddSettingsHandler(handler);
		}

		public static void RemoveSettingsHandler(ReadOnlySpan<char> type_name)
		{
			// Marshaling 'type_name' to native string
			byte* native_type_name;
			var type_name_byteCount = 0;
			if (type_name != null)
			{
				type_name_byteCount = Encoding.UTF8.GetByteCount(type_name);
				if (type_name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type_name = Util.Allocate(type_name_byteCount + 1);
				}
				else
				{
					var native_type_name_stackBytes = stackalloc byte[type_name_byteCount + 1];
					native_type_name = native_type_name_stackBytes;
				}
				var type_name_offset = Util.GetUtf8(type_name, native_type_name, type_name_byteCount);
				native_type_name[type_name_offset] = 0;
			}
			else native_type_name = null;

			ImGuiInternalNative.ImGui_RemoveSettingsHandler(native_type_name);
			if (type_name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type_name);
			}
		}

		public static ImGuiSettingsHandlerPtr FindSettingsHandler(ReadOnlySpan<char> type_name)
		{
			// Marshaling 'type_name' to native string
			byte* native_type_name;
			var type_name_byteCount = 0;
			if (type_name != null)
			{
				type_name_byteCount = Encoding.UTF8.GetByteCount(type_name);
				if (type_name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_type_name = Util.Allocate(type_name_byteCount + 1);
				}
				else
				{
					var native_type_name_stackBytes = stackalloc byte[type_name_byteCount + 1];
					native_type_name = native_type_name_stackBytes;
				}
				var type_name_offset = Util.GetUtf8(type_name, native_type_name, type_name_byteCount);
				native_type_name[type_name_offset] = 0;
			}
			else native_type_name = null;

			var ret = ImGuiInternalNative.ImGui_FindSettingsHandler(native_type_name);
			if (type_name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_type_name);
			}
			return ret;
		}

		/// <summary>
		/// <para>Settings - Windows</para>
		/// </summary>
		public static ImGuiWindowSettingsPtr CreateNewWindowSettings(ReadOnlySpan<char> name)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var ret = ImGuiInternalNative.ImGui_CreateNewWindowSettings(native_name);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret;
		}

		public static ImGuiWindowSettingsPtr FindWindowSettingsByID(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_FindWindowSettingsByID(id);
			return ret;
		}

		public static ImGuiWindowSettingsPtr FindWindowSettingsByWindow(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_FindWindowSettingsByWindow(window);
			return ret;
		}

		public static void ClearWindowSettings(ReadOnlySpan<char> name)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiInternalNative.ImGui_ClearWindowSettings(native_name);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
		}

		/// <summary>
		/// <para>Localization</para>
		/// </summary>
		public static void LocalizeRegisterEntries(ImGuiLocEntryPtr entries, int count)
		{
			ImGuiInternalNative.ImGui_LocalizeRegisterEntries(entries, count);
		}

		public static string LocalizeGetMsg(ImGuiLocKey key)
		{
			var ret = ImGuiInternalNative.ImGui_LocalizeGetMsg(key);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// <para>Scrolling</para>
		/// </summary>
		public static void SetScrollXImGuiWindowPtr(ImGuiWindowPtr window, float scroll_x)
		{
			ImGuiInternalNative.ImGui_SetScrollXImGuiWindowPtr(window, scroll_x);
		}

		public static void SetScrollYImGuiWindowPtr(ImGuiWindowPtr window, float scroll_y)
		{
			ImGuiInternalNative.ImGui_SetScrollYImGuiWindowPtr(window, scroll_y);
		}

		public static void SetScrollFromPosXImGuiWindowPtr(ImGuiWindowPtr window, float local_x, float center_x_ratio)
		{
			ImGuiInternalNative.ImGui_SetScrollFromPosXImGuiWindowPtr(window, local_x, center_x_ratio);
		}

		public static void SetScrollFromPosYImGuiWindowPtr(ImGuiWindowPtr window, float local_y, float center_y_ratio)
		{
			ImGuiInternalNative.ImGui_SetScrollFromPosYImGuiWindowPtr(window, local_y, center_y_ratio);
		}

		/// <summary>
		/// <para>Early work-in-progress API (ScrollToItem() will become public)</para>
		/// </summary>
		public static void ScrollToItem()
		{
			ImGuiScrollFlags flags = (ImGuiScrollFlags)0;

			ImGuiInternalNative.ImGui_ScrollToItem(flags);
		}
		/// <summary>
		/// <para>Early work-in-progress API (ScrollToItem() will become public)</para>
		/// </summary>
		public static void ScrollToItem(ImGuiScrollFlags flags)
		{
			ImGuiInternalNative.ImGui_ScrollToItem(flags);
		}

		public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect)
		{
			ImGuiScrollFlags flags = (ImGuiScrollFlags)0;

			ImGuiInternalNative.ImGui_ScrollToRect(window, rect, flags);
		}
		public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
		{
			ImGuiInternalNative.ImGui_ScrollToRect(window, rect, flags);
		}


		/// <summary>
		/// <para>//#ifndef IMGUI_DISABLE_OBSOLETE_FUNCTIONS</para>
		/// </summary>
		public static void ScrollToBringRectIntoView(ImGuiWindowPtr window, ImRect rect)
		{
			ImGuiInternalNative.ImGui_ScrollToBringRectIntoView(window, rect);
		}

		/// <summary>
		/// <para>Basic Accessors</para>
		/// </summary>
		public static ImGuiItemStatusFlags GetItemStatusFlags()
		{
			var ret = ImGuiInternalNative.ImGui_GetItemStatusFlags();
			return ret;
		}

		public static ImGuiItemFlags GetItemFlags()
		{
			var ret = ImGuiInternalNative.ImGui_GetItemFlags();
			return ret;
		}

		public static uint GetActiveID()
		{
			var ret = ImGuiInternalNative.ImGui_GetActiveID();
			return ret;
		}

		public static uint GetFocusID()
		{
			var ret = ImGuiInternalNative.ImGui_GetFocusID();
			return ret;
		}

		public static void SetActiveID(uint id, ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_SetActiveID(id, window);
		}

		public static void SetFocusID(uint id, ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_SetFocusID(id, window);
		}

		public static void ClearActiveID()
		{
			ImGuiInternalNative.ImGui_ClearActiveID();
		}

		public static uint GetHoveredID()
		{
			var ret = ImGuiInternalNative.ImGui_GetHoveredID();
			return ret;
		}

		public static void SetHoveredID(uint id)
		{
			ImGuiInternalNative.ImGui_SetHoveredID(id);
		}

		public static void KeepAliveID(uint id)
		{
			ImGuiInternalNative.ImGui_KeepAliveID(id);
		}

		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.
		/// </summary>
		public static void MarkItemEdited(uint id)
		{
			ImGuiInternalNative.ImGui_MarkItemEdited(id);
		}

		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)
		/// </summary>
		public static void PushOverrideID(uint id)
		{
			ImGuiInternalNative.ImGui_PushOverrideID(id);
		}

		public static uint GetIDWithSeedStr(ReadOnlySpan<char> str_id_begin, ReadOnlySpan<char> str_id_end, uint seed)
		{
			// Marshaling 'str_id_begin' to native string
			byte* native_str_id_begin;
			var str_id_begin_byteCount = 0;
			if (str_id_begin != null)
			{
				str_id_begin_byteCount = Encoding.UTF8.GetByteCount(str_id_begin);
				if (str_id_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id_begin = Util.Allocate(str_id_begin_byteCount + 1);
				}
				else
				{
					var native_str_id_begin_stackBytes = stackalloc byte[str_id_begin_byteCount + 1];
					native_str_id_begin = native_str_id_begin_stackBytes;
				}
				var str_id_begin_offset = Util.GetUtf8(str_id_begin, native_str_id_begin, str_id_begin_byteCount);
				native_str_id_begin[str_id_begin_offset] = 0;
			}
			else native_str_id_begin = null;

			// Marshaling 'str_id_end' to native string
			byte* native_str_id_end;
			var str_id_end_byteCount = 0;
			if (str_id_end != null)
			{
				str_id_end_byteCount = Encoding.UTF8.GetByteCount(str_id_end);
				if (str_id_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id_end = Util.Allocate(str_id_end_byteCount + 1);
				}
				else
				{
					var native_str_id_end_stackBytes = stackalloc byte[str_id_end_byteCount + 1];
					native_str_id_end = native_str_id_end_stackBytes;
				}
				var str_id_end_offset = Util.GetUtf8(str_id_end, native_str_id_end, str_id_end_byteCount);
				native_str_id_end[str_id_end_offset] = 0;
			}
			else native_str_id_end = null;

			var ret = ImGuiInternalNative.ImGui_GetIDWithSeedStr(native_str_id_begin, native_str_id_end, seed);
			if (str_id_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id_begin);
			}
			if (str_id_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id_end);
			}
			return ret;
		}

		public static uint GetIDWithSeed(int n, uint seed)
		{
			var ret = ImGuiInternalNative.ImGui_GetIDWithSeed(n, seed);
			return ret;
		}

		/// <summary>
		/// <para>Basic Helpers for widget code</para>
		/// </summary>
		/// <summary>
		/// Implied text_baseline_y = -1.0f
		/// </summary>
		public static void ItemSize(Vector2 size)
		{
			ImGuiInternalNative.ImGui_ItemSize(size);
		}

		/// <summary>
		/// <para>Basic Helpers for widget code</para>
		/// </summary>
		/// <summary>
		/// Implied text_baseline_y = -1.0f
		/// </summary>
		public static void ItemSize(Vector2 size, float text_baseline_y)
		{
			ImGuiInternalNative.ImGui_ItemSizeEx(size, text_baseline_y);
		}

		/// <summary>
		/// Implied text_baseline_y = -1.0f
		/// </summary>
		public static void ItemSizeImRect(ImRect bb)
		{
			ImGuiInternalNative.ImGui_ItemSizeImRect(bb);
		}

		/// <summary>
		/// Implied text_baseline_y = -1.0f
		/// </summary>
		public static void ItemSizeImRect(ImRect bb, float text_baseline_y)
		{
			ImGuiInternalNative.ImGui_ItemSizeImRectEx(bb, text_baseline_y);
		}

		/// <summary>
		/// Implied nav_bb = NULL, extra_flags = 0
		/// </summary>
		public static bool ItemAdd(ImRect bb, uint id)
		{
			var ret = ImGuiInternalNative.ImGui_ItemAdd(bb, id);
			return ret != 0;
		}

		/// <summary>
		/// Implied nav_bb = NULL, extra_flags = 0
		/// </summary>
		public static bool ItemAdd(ImRect bb, uint id, ImRectPtr nav_bb)
		{
			ImGuiItemFlags extra_flags = (ImGuiItemFlags)0;

			var ret = ImGuiInternalNative.ImGui_ItemAddEx(bb, id, nav_bb, extra_flags);
			return ret != 0;
		}
		/// <summary>
		/// Implied nav_bb = NULL, extra_flags = 0
		/// </summary>
		public static bool ItemAdd(ImRect bb, uint id, ImRectPtr nav_bb, ImGuiItemFlags extra_flags)
		{
			var ret = ImGuiInternalNative.ImGui_ItemAddEx(bb, id, nav_bb, extra_flags);
			return ret != 0;
		}

		public static bool ItemHoverable(ImRect bb, uint id, ImGuiItemFlags item_flags)
		{
			var ret = ImGuiInternalNative.ImGui_ItemHoverable(bb, id, item_flags);
			return ret != 0;
		}

		public static bool IsWindowContentHoverable(ImGuiWindowPtr window)
		{
			ImGuiHoveredFlags flags = (ImGuiHoveredFlags)0;

			var ret = ImGuiInternalNative.ImGui_IsWindowContentHoverable(window, flags);
			return ret != 0;
		}
		public static bool IsWindowContentHoverable(ImGuiWindowPtr window, ImGuiHoveredFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_IsWindowContentHoverable(window, flags);
			return ret != 0;
		}

		public static bool IsClipped(ImRect bb, uint id)
		{
			var ret = ImGuiInternalNative.ImGui_IsClippedEx(bb, id);
			return ret != 0;
		}

		public static void SetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect)
		{
			ImGuiInternalNative.ImGui_SetLastItemData(item_id, in_flags, status_flags, item_rect);
		}

		public static Vector2 CalcItemSize(Vector2 size, float default_w, float default_h)
		{
			var ret = ImGuiInternalNative.ImGui_CalcItemSize(size, default_w, default_h);
			return ret;
		}

		public static float CalcWrapWidthForPos(Vector2 pos, float wrap_pos_x)
		{
			var ret = ImGuiInternalNative.ImGui_CalcWrapWidthForPos(pos, wrap_pos_x);
			return ret;
		}

		public static void PushMultiItemsWidths(int components, float width_full)
		{
			ImGuiInternalNative.ImGui_PushMultiItemsWidths(components, width_full);
		}

		public static void ShrinkWidths(ImGuiShrinkWidthItemPtr items, int count, float width_excess)
		{
			ImGuiInternalNative.ImGui_ShrinkWidths(items, count, width_excess);
		}

		/// <summary>
		/// <para>Parameter stacks (shared)</para>
		/// </summary>
		public static ImGuiDataVarInfoPtr GetStyleVarInfo(ImGuiStyleVar idx)
		{
			var ret = ImGuiInternalNative.ImGui_GetStyleVarInfo(idx);
			return ret;
		}

		public static void BeginDisabledOverrideReenable()
		{
			ImGuiInternalNative.ImGui_BeginDisabledOverrideReenable();
		}

		public static void EndDisabledOverrideReenable()
		{
			ImGuiInternalNative.ImGui_EndDisabledOverrideReenable();
		}

		/// <summary>
		/// <para>Logging/Capture</para>
		/// </summary>
		/// <summary>
		/// -&gt; BeginCapture() when we design v2 api, for now stay under the radar by using the old name.
		/// </summary>
		public static void LogBegin(ImGuiLogFlags flags, int auto_open_depth)
		{
			ImGuiInternalNative.ImGui_LogBegin(flags, auto_open_depth);
		}

		/// <summary>
		/// Implied auto_open_depth = -1
		/// </summary>
		public static void LogToBuffer()
		{
			ImGuiInternalNative.ImGui_LogToBuffer();
		}

		/// <summary>
		/// Implied auto_open_depth = -1
		/// </summary>
		public static void LogToBuffer(int auto_open_depth)
		{
			ImGuiInternalNative.ImGui_LogToBufferEx(auto_open_depth);
		}

		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public static void LogRenderedText(ref Vector2 ref_pos, ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			fixed (Vector2* native_ref_pos = &ref_pos)
			{
				ImGuiInternalNative.ImGui_LogRenderedText(native_ref_pos, native_text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
			}
		}

		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public static void LogRenderedText(ref Vector2 ref_pos, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (Vector2* native_ref_pos = &ref_pos)
			{
				ImGuiInternalNative.ImGui_LogRenderedTextEx(native_ref_pos, native_text, native_text_end);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		public static void LogSetNextTextDecoration(ReadOnlySpan<char> prefix, ReadOnlySpan<char> suffix)
		{
			// Marshaling 'prefix' to native string
			byte* native_prefix;
			var prefix_byteCount = 0;
			if (prefix != null)
			{
				prefix_byteCount = Encoding.UTF8.GetByteCount(prefix);
				if (prefix_byteCount > Util.StackAllocationSizeLimit)
				{
					native_prefix = Util.Allocate(prefix_byteCount + 1);
				}
				else
				{
					var native_prefix_stackBytes = stackalloc byte[prefix_byteCount + 1];
					native_prefix = native_prefix_stackBytes;
				}
				var prefix_offset = Util.GetUtf8(prefix, native_prefix, prefix_byteCount);
				native_prefix[prefix_offset] = 0;
			}
			else native_prefix = null;

			// Marshaling 'suffix' to native string
			byte* native_suffix;
			var suffix_byteCount = 0;
			if (suffix != null)
			{
				suffix_byteCount = Encoding.UTF8.GetByteCount(suffix);
				if (suffix_byteCount > Util.StackAllocationSizeLimit)
				{
					native_suffix = Util.Allocate(suffix_byteCount + 1);
				}
				else
				{
					var native_suffix_stackBytes = stackalloc byte[suffix_byteCount + 1];
					native_suffix = native_suffix_stackBytes;
				}
				var suffix_offset = Util.GetUtf8(suffix, native_suffix, suffix_byteCount);
				native_suffix[suffix_offset] = 0;
			}
			else native_suffix = null;

			ImGuiInternalNative.ImGui_LogSetNextTextDecoration(native_prefix, native_suffix);
			if (prefix_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_prefix);
			}
			if (suffix_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_suffix);
			}
		}

		/// <summary>
		/// <para>Childs</para>
		/// </summary>
		public static bool BeginChild(ReadOnlySpan<char> name, uint id, Vector2 size_arg, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var ret = ImGuiInternalNative.ImGui_BeginChildEx(native_name, id, size_arg, child_flags, window_flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Popups, Modals</para>
		/// </summary>
		public static bool BeginPopup(uint id, ImGuiWindowFlags extra_window_flags)
		{
			var ret = ImGuiInternalNative.ImGui_BeginPopupEx(id, extra_window_flags);
			return ret != 0;
		}

		/// <summary>
		/// Implied popup_flags = ImGuiPopupFlags_None
		/// </summary>
		public static void OpenPopup(uint id)
		{
			ImGuiInternalNative.ImGui_OpenPopupEx(id);
		}

		public static void OpenPopupEx(uint id)
		{
			ImGuiPopupFlags popup_flags = (ImGuiPopupFlags)ImGuiPopupFlags.None;

			ImGuiInternalNative.ImGui_OpenPopupExEx(id, popup_flags);
		}
		public static void OpenPopupEx(uint id, ImGuiPopupFlags popup_flags)
		{
			ImGuiInternalNative.ImGui_OpenPopupExEx(id, popup_flags);
		}

		public static void ClosePopupToLevel(int remaining, bool restore_focus_to_window_under_popup)
		{
			// Marshaling 'restore_focus_to_window_under_popup' to native bool
			var native_restore_focus_to_window_under_popup = restore_focus_to_window_under_popup ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_ClosePopupToLevel(remaining, native_restore_focus_to_window_under_popup);
		}

		public static void ClosePopupsOverWindow(ImGuiWindowPtr ref_window, bool restore_focus_to_window_under_popup)
		{
			// Marshaling 'restore_focus_to_window_under_popup' to native bool
			var native_restore_focus_to_window_under_popup = restore_focus_to_window_under_popup ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_ClosePopupsOverWindow(ref_window, native_restore_focus_to_window_under_popup);
		}

		public static void ClosePopupsExceptModals()
		{
			ImGuiInternalNative.ImGui_ClosePopupsExceptModals();
		}

		public static bool IsPopupOpenID(uint id, ImGuiPopupFlags popup_flags)
		{
			var ret = ImGuiInternalNative.ImGui_IsPopupOpenID(id, popup_flags);
			return ret != 0;
		}

		public static ImRect GetPopupAllowedExtentRect(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_GetPopupAllowedExtentRect(window);
			return ret;
		}

		public static ImGuiWindowPtr GetTopMostPopupModal()
		{
			var ret = ImGuiInternalNative.ImGui_GetTopMostPopupModal();
			return ret;
		}

		public static ImGuiWindowPtr GetTopMostAndVisiblePopupModal()
		{
			var ret = ImGuiInternalNative.ImGui_GetTopMostAndVisiblePopupModal();
			return ret;
		}

		public static ImGuiWindowPtr FindBlockingModal(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_FindBlockingModal(window);
			return ret;
		}

		public static Vector2 FindBestWindowPosForPopup(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_FindBestWindowPosForPopup(window);
			return ret;
		}

		public static Vector2 FindBestWindowPosForPopup(Vector2 ref_pos, Vector2 size, ref ImGuiDir last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy)
		{
			fixed (ImGuiDir* native_last_dir = &last_dir)
			{
				var ret = ImGuiInternalNative.ImGui_FindBestWindowPosForPopupEx(ref_pos, size, native_last_dir, r_outer, r_avoid, policy);
				return ret;
			}
		}

		/// <summary>
		/// <para>Tooltips</para>
		/// </summary>
		public static bool BeginTooltip(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags)
		{
			var ret = ImGuiInternalNative.ImGui_BeginTooltipEx(tooltip_flags, extra_window_flags);
			return ret != 0;
		}

		public static bool BeginTooltipHidden()
		{
			var ret = ImGuiInternalNative.ImGui_BeginTooltipHidden();
			return ret != 0;
		}

		/// <summary>
		/// <para>Menus</para>
		/// </summary>
		public static bool BeginViewportSideBar(ReadOnlySpan<char> name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var ret = ImGuiInternalNative.ImGui_BeginViewportSideBar(native_name, viewport, dir, size, window_flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied enabled = true
		/// </summary>
		public static bool BeginMenuWithIcon(ReadOnlySpan<char> label, ReadOnlySpan<char> icon)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'icon' to native string
			byte* native_icon;
			var icon_byteCount = 0;
			if (icon != null)
			{
				icon_byteCount = Encoding.UTF8.GetByteCount(icon);
				if (icon_byteCount > Util.StackAllocationSizeLimit)
				{
					native_icon = Util.Allocate(icon_byteCount + 1);
				}
				else
				{
					var native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
					native_icon = native_icon_stackBytes;
				}
				var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			var ret = ImGuiInternalNative.ImGui_BeginMenuWithIcon(native_label, native_icon);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (icon_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_icon);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied enabled = true
		/// </summary>
		public static bool BeginMenuWithIcon(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, bool enabled)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'icon' to native string
			byte* native_icon;
			var icon_byteCount = 0;
			if (icon != null)
			{
				icon_byteCount = Encoding.UTF8.GetByteCount(icon);
				if (icon_byteCount > Util.StackAllocationSizeLimit)
				{
					native_icon = Util.Allocate(icon_byteCount + 1);
				}
				else
				{
					var native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
					native_icon = native_icon_stackBytes;
				}
				var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			// Marshaling 'enabled' to native bool
			var native_enabled = enabled ? (byte)1 : (byte)0;

			var ret = ImGuiInternalNative.ImGui_BeginMenuWithIconEx(native_label, native_icon, native_enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (icon_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_icon);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItemWithIcon(ReadOnlySpan<char> label, ReadOnlySpan<char> icon)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'icon' to native string
			byte* native_icon;
			var icon_byteCount = 0;
			if (icon != null)
			{
				icon_byteCount = Encoding.UTF8.GetByteCount(icon);
				if (icon_byteCount > Util.StackAllocationSizeLimit)
				{
					native_icon = Util.Allocate(icon_byteCount + 1);
				}
				else
				{
					var native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
					native_icon = native_icon_stackBytes;
				}
				var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			var ret = ImGuiInternalNative.ImGui_MenuItemWithIcon(native_label, native_icon);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (icon_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_icon);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItemWithIcon(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'icon' to native string
			byte* native_icon;
			var icon_byteCount = 0;
			if (icon != null)
			{
				icon_byteCount = Encoding.UTF8.GetByteCount(icon);
				if (icon_byteCount > Util.StackAllocationSizeLimit)
				{
					native_icon = Util.Allocate(icon_byteCount + 1);
				}
				else
				{
					var native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
					native_icon = native_icon_stackBytes;
				}
				var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			byte selected = 0;

			byte enabled = 1;

			var ret = ImGuiInternalNative.ImGui_MenuItemWithIconEx(native_label, native_icon, native_shortcut, selected, enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (icon_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_icon);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItemWithIcon(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut, bool selected)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'icon' to native string
			byte* native_icon;
			var icon_byteCount = 0;
			if (icon != null)
			{
				icon_byteCount = Encoding.UTF8.GetByteCount(icon);
				if (icon_byteCount > Util.StackAllocationSizeLimit)
				{
					native_icon = Util.Allocate(icon_byteCount + 1);
				}
				else
				{
					var native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
					native_icon = native_icon_stackBytes;
				}
				var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			byte enabled = 1;

			var ret = ImGuiInternalNative.ImGui_MenuItemWithIconEx(native_label, native_icon, native_shortcut, native_selected, enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (icon_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_icon);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		public static bool MenuItemWithIcon(ReadOnlySpan<char> label, ReadOnlySpan<char> icon, ReadOnlySpan<char> shortcut, bool selected, bool enabled)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'icon' to native string
			byte* native_icon;
			var icon_byteCount = 0;
			if (icon != null)
			{
				icon_byteCount = Encoding.UTF8.GetByteCount(icon);
				if (icon_byteCount > Util.StackAllocationSizeLimit)
				{
					native_icon = Util.Allocate(icon_byteCount + 1);
				}
				else
				{
					var native_icon_stackBytes = stackalloc byte[icon_byteCount + 1];
					native_icon = native_icon_stackBytes;
				}
				var icon_offset = Util.GetUtf8(icon, native_icon, icon_byteCount);
				native_icon[icon_offset] = 0;
			}
			else native_icon = null;

			// Marshaling 'shortcut' to native string
			byte* native_shortcut;
			var shortcut_byteCount = 0;
			if (shortcut != null)
			{
				shortcut_byteCount = Encoding.UTF8.GetByteCount(shortcut);
				if (shortcut_byteCount > Util.StackAllocationSizeLimit)
				{
					native_shortcut = Util.Allocate(shortcut_byteCount + 1);
				}
				else
				{
					var native_shortcut_stackBytes = stackalloc byte[shortcut_byteCount + 1];
					native_shortcut = native_shortcut_stackBytes;
				}
				var shortcut_offset = Util.GetUtf8(shortcut, native_shortcut, shortcut_byteCount);
				native_shortcut[shortcut_offset] = 0;
			}
			else native_shortcut = null;

			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			// Marshaling 'enabled' to native bool
			var native_enabled = enabled ? (byte)1 : (byte)0;

			var ret = ImGuiInternalNative.ImGui_MenuItemWithIconEx(native_label, native_icon, native_shortcut, native_selected, native_enabled);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (icon_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_icon);
			}
			if (shortcut_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_shortcut);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Combos</para>
		/// </summary>
		public static bool BeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_BeginComboPopup(popup_id, bb, flags);
			return ret != 0;
		}

		public static bool BeginComboPreview()
		{
			var ret = ImGuiInternalNative.ImGui_BeginComboPreview();
			return ret != 0;
		}

		public static void EndComboPreview()
		{
			ImGuiInternalNative.ImGui_EndComboPreview();
		}

		/// <summary>
		/// <para>Keyboard/Gamepad Navigation</para>
		/// </summary>
		public static void NavInitWindow(ImGuiWindowPtr window, bool force_reinit)
		{
			// Marshaling 'force_reinit' to native bool
			var native_force_reinit = force_reinit ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_NavInitWindow(window, native_force_reinit);
		}

		public static void NavInitRequestApplyResult()
		{
			ImGuiInternalNative.ImGui_NavInitRequestApplyResult();
		}

		public static bool NavMoveRequestButNoResultYet()
		{
			var ret = ImGuiInternalNative.ImGui_NavMoveRequestButNoResultYet();
			return ret != 0;
		}

		public static void NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags)
		{
			ImGuiInternalNative.ImGui_NavMoveRequestSubmit(move_dir, clip_dir, move_flags, scroll_flags);
		}

		public static void NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags)
		{
			ImGuiInternalNative.ImGui_NavMoveRequestForward(move_dir, clip_dir, move_flags, scroll_flags);
		}

		public static void NavMoveRequestResolveWithLastItem(ImGuiNavItemDataPtr result)
		{
			ImGuiInternalNative.ImGui_NavMoveRequestResolveWithLastItem(result);
		}

		public static void NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemDataPtr result, ImGuiTreeNodeStackDataPtr tree_node_data)
		{
			ImGuiInternalNative.ImGui_NavMoveRequestResolveWithPastTreeNode(result, tree_node_data);
		}

		public static void NavMoveRequestCancel()
		{
			ImGuiInternalNative.ImGui_NavMoveRequestCancel();
		}

		public static void NavMoveRequestApplyResult()
		{
			ImGuiInternalNative.ImGui_NavMoveRequestApplyResult();
		}

		public static void NavMoveRequestTryWrapping(ImGuiWindowPtr window, ImGuiNavMoveFlags move_flags)
		{
			ImGuiInternalNative.ImGui_NavMoveRequestTryWrapping(window, move_flags);
		}

		public static void NavHighlightActivated(uint id)
		{
			ImGuiInternalNative.ImGui_NavHighlightActivated(id);
		}

		public static void NavClearPreferredPosForAxis(ImGuiAxis axis)
		{
			ImGuiInternalNative.ImGui_NavClearPreferredPosForAxis(axis);
		}

		public static void SetNavCursorVisibleAfterMove()
		{
			ImGuiInternalNative.ImGui_SetNavCursorVisibleAfterMove();
		}

		public static void NavUpdateCurrentWindowIsScrollPushableX()
		{
			ImGuiInternalNative.ImGui_NavUpdateCurrentWindowIsScrollPushableX();
		}

		public static void SetNavWindow(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_SetNavWindow(window);
		}

		public static void SetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel)
		{
			ImGuiInternalNative.ImGui_SetNavID(id, nav_layer, focus_scope_id, rect_rel);
		}

		public static void SetNavFocusScope(uint focus_scope_id)
		{
			ImGuiInternalNative.ImGui_SetNavFocusScope(focus_scope_id);
		}

		/// <summary>
		/// <para>Focus/Activation</para>
		/// <para>This should be part of a larger set of API: FocusItem(offset = -1), FocusItemByID(id), ActivateItem(offset = -1), ActivateItemByID(id) etc. which are</para>
		/// <para>much harder to design and implement than expected. I have a couple of private branches on this matter but it's not simple. For now implementing the easy ones.</para>
		/// </summary>
		/// <summary>
		/// Focus last item (no selection/activation).
		/// </summary>
		public static void FocusItem()
		{
			ImGuiInternalNative.ImGui_FocusItem();
		}

		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.
		/// </summary>
		public static void ActivateItemByID(uint id)
		{
			ImGuiInternalNative.ImGui_ActivateItemByID(id);
		}

		/// <summary>
		/// <para>Inputs</para>
		/// <para>FIXME: Eventually we should aim to move e.g. IsActiveIdUsingKey() into IsKeyXXX functions.</para>
		/// </summary>
		public static bool IsNamedKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsNamedKey(key);
			return ret != 0;
		}

		public static bool IsNamedKeyOrMod(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsNamedKeyOrMod(key);
			return ret != 0;
		}

		public static bool IsLegacyKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsLegacyKey(key);
			return ret != 0;
		}

		public static bool IsKeyboardKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyboardKey(key);
			return ret != 0;
		}

		public static bool IsGamepadKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsGamepadKey(key);
			return ret != 0;
		}

		public static bool IsMouseKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseKey(key);
			return ret != 0;
		}

		public static bool IsAliasKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsAliasKey(key);
			return ret != 0;
		}

		public static bool IsLRModKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_IsLRModKey(key);
			return ret != 0;
		}

		public static ImGuiKey FixupKeyChord(ImGuiKey key_chord)
		{
			var ret = ImGuiInternalNative.ImGui_FixupKeyChord(key_chord);
			return ret;
		}

		public static ImGuiKey ConvertSingleModFlagToKey(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_ConvertSingleModFlagToKey(key);
			return ret;
		}

		public static ImGuiKeyDataPtr GetKeyDataImGuiContextPtr(ImGuiContextPtr ctx, ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_GetKeyDataImGuiContextPtr(ctx, key);
			return ret;
		}

		public static ImGuiKeyDataPtr GetKeyData(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_GetKeyData(key);
			return ret;
		}

		public static string GetKeyChordName(ImGuiKey key_chord)
		{
			var ret = ImGuiInternalNative.ImGui_GetKeyChordName(key_chord);
			return Util.StringFromPtr(ret);
		}

		public static ImGuiKey MouseButtonToKey(ImGuiMouseButton button)
		{
			var ret = ImGuiInternalNative.ImGui_MouseButtonToKey(button);
			return ret;
		}

		/// <summary>
		/// Implied lock_threshold = -1.0f
		/// </summary>
		public static bool IsMouseDragPastThreshold(ImGuiMouseButton button)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseDragPastThreshold(button);
			return ret != 0;
		}

		/// <summary>
		/// Implied lock_threshold = -1.0f
		/// </summary>
		public static bool IsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseDragPastThresholdEx(button, lock_threshold);
			return ret != 0;
		}

		public static Vector2 GetKeyMagnitude2d(ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down)
		{
			var ret = ImGuiInternalNative.ImGui_GetKeyMagnitude2d(key_left, key_right, key_up, key_down);
			return ret;
		}

		public static float GetNavTweakPressedAmount(ImGuiAxis axis)
		{
			var ret = ImGuiInternalNative.ImGui_GetNavTweakPressedAmount(axis);
			return ret;
		}

		public static int CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate)
		{
			var ret = ImGuiInternalNative.ImGui_CalcTypematicRepeatAmount(t0, t1, repeat_delay, repeat_rate);
			return ret;
		}

		public static void GetTypematicRepeatRate(ImGuiInputFlags flags, ref float repeat_delay, ref float repeat_rate)
		{
			fixed (float* native_repeat_delay = &repeat_delay)
			fixed (float* native_repeat_rate = &repeat_rate)
			{
				ImGuiInternalNative.ImGui_GetTypematicRepeatRate(flags, native_repeat_delay, native_repeat_rate);
			}
		}

		public static void TeleportMousePos(Vector2 pos)
		{
			ImGuiInternalNative.ImGui_TeleportMousePos(pos);
		}

		public static void SetActiveIdUsingAllKeyboardKeys()
		{
			ImGuiInternalNative.ImGui_SetActiveIdUsingAllKeyboardKeys();
		}

		public static bool IsActiveIdUsingNavDir(ImGuiDir dir)
		{
			var ret = ImGuiInternalNative.ImGui_IsActiveIdUsingNavDir(dir);
			return ret != 0;
		}

		/// <summary>
		/// <para>[EXPERIMENTAL] Low-Level: Key/Input Ownership</para>
		/// <para>- The idea is that instead of "eating" a given input, we can link to an owner id.</para>
		/// <para>- Ownership is most often claimed as a result of reacting to a press/down event (but occasionally may be claimed ahead).</para>
		/// <para>- Input queries can then read input by specifying ImGuiKeyOwner_Any (== 0), ImGuiKeyOwner_NoOwner (== -1) or a custom ID.</para>
		/// <para>- Legacy input queries (without specifying an owner or _Any or _None) are equivalent to using ImGuiKeyOwner_Any (== 0).</para>
		/// <para>- Input ownership is automatically released on the frame after a key is released. Therefore:</para>
		/// <para>  - for ownership registration happening as a result of a down/press event, the SetKeyOwner() call may be done once (common case).</para>
		/// <para>  - for ownership registration happening ahead of a down/press event, the SetKeyOwner() call needs to be made every frame (happens if e.g. claiming ownership on hover).</para>
		/// <para>- SetItemKeyOwner() is a shortcut for common simple case. A custom widget will probably want to call SetKeyOwner() multiple times directly based on its interaction state.</para>
		/// <para>- This is marked experimental because not all widgets are fully honoring the Set/Test idioms. We will need to move forward step by step.</para>
		/// <para>  Please open a GitHub Issue to submit your usage scenario or if there's a use case you need solved.</para>
		/// </summary>
		public static uint GetKeyOwner(ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_GetKeyOwner(key);
			return ret;
		}

		public static void SetKeyOwner(ImGuiKey key, uint owner_id)
		{
			ImGuiInputFlags flags = (ImGuiInputFlags)0;

			ImGuiInternalNative.ImGui_SetKeyOwner(key, owner_id, flags);
		}
		public static void SetKeyOwner(ImGuiKey key, uint owner_id, ImGuiInputFlags flags)
		{
			ImGuiInternalNative.ImGui_SetKeyOwner(key, owner_id, flags);
		}

		public static void SetKeyOwnersForKeyChord(ImGuiKey key, uint owner_id)
		{
			ImGuiInputFlags flags = (ImGuiInputFlags)0;

			ImGuiInternalNative.ImGui_SetKeyOwnersForKeyChord(key, owner_id, flags);
		}
		public static void SetKeyOwnersForKeyChord(ImGuiKey key, uint owner_id, ImGuiInputFlags flags)
		{
			ImGuiInternalNative.ImGui_SetKeyOwnersForKeyChord(key, owner_id, flags);
		}

		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive()) { SetKeyOwner(key, GetItemID());'.
		/// </summary>
		public static void SetItemKeyOwnerImGuiInputFlags(ImGuiKey key, ImGuiInputFlags flags)
		{
			ImGuiInternalNative.ImGui_SetItemKeyOwnerImGuiInputFlags(key, flags);
		}

		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'
		/// </summary>
		public static bool TestKeyOwner(ImGuiKey key, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_TestKeyOwner(key, owner_id);
			return ret != 0;
		}

		public static ImGuiKeyOwnerDataPtr GetKeyOwnerData(ImGuiContextPtr ctx, ImGuiKey key)
		{
			var ret = ImGuiInternalNative.ImGui_GetKeyOwnerData(ctx, key);
			return ret;
		}

		/// <summary>
		/// <para>[EXPERIMENTAL] High-Level: Input Access functions w/ support for Key/Input Ownership</para>
		/// <para>- Important: legacy IsKeyPressed(ImGuiKey, bool repeat=true) _DEFAULTS_ to repeat, new IsKeyPressed() requires _EXPLICIT_ ImGuiInputFlags_Repeat flag.</para>
		/// <para>- Expected to be later promoted to public API, the prototypes are designed to replace existing ones (since owner_id can default to Any == 0)</para>
		/// <para>- Specifying a value for 'ImGuiID owner' will test that EITHER the key is NOT owned (UNLESS locked), EITHER the key is owned by 'owner'.</para>
		/// <para>  Legacy functions use ImGuiKeyOwner_Any meaning that they typically ignore ownership, unless a call to SetKeyOwner() explicitly used ImGuiInputFlags_LockThisFrame or ImGuiInputFlags_LockUntilRelease.</para>
		/// <para>- Binding generators may want to ignore those for now, or suffix them with Ex() until we decide if this gets moved into public API.</para>
		/// </summary>
		public static bool IsKeyDownID(ImGuiKey key, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyDownID(key, owner_id);
			return ret != 0;
		}

		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		public static bool IsKeyPressedImGuiInputFlags(ImGuiKey key, ImGuiInputFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyPressedImGuiInputFlags(key, flags);
			return ret != 0;
		}

		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		public static bool IsKeyPressedImGuiInputFlags(ImGuiKey key, ImGuiInputFlags flags, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyPressedImGuiInputFlagsEx(key, flags, owner_id);
			return ret != 0;
		}

		public static bool IsKeyReleasedID(ImGuiKey key, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyReleasedID(key, owner_id);
			return ret != 0;
		}

		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		public static bool IsKeyChordPressedImGuiInputFlags(ImGuiKey key_chord, ImGuiInputFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyChordPressedImGuiInputFlags(key_chord, flags);
			return ret != 0;
		}

		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		public static bool IsKeyChordPressedImGuiInputFlags(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsKeyChordPressedImGuiInputFlagsEx(key_chord, flags, owner_id);
			return ret != 0;
		}

		public static bool IsMouseDownID(ImGuiMouseButton button, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseDownID(button, owner_id);
			return ret != 0;
		}

		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		public static bool IsMouseClickedImGuiInputFlags(ImGuiMouseButton button, ImGuiInputFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseClickedImGuiInputFlags(button, flags);
			return ret != 0;
		}

		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		public static bool IsMouseClickedImGuiInputFlags(ImGuiMouseButton button, ImGuiInputFlags flags, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseClickedImGuiInputFlagsEx(button, flags, owner_id);
			return ret != 0;
		}

		public static bool IsMouseReleasedID(ImGuiMouseButton button, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseReleasedID(button, owner_id);
			return ret != 0;
		}

		public static bool IsMouseDoubleClickedID(ImGuiMouseButton button, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_IsMouseDoubleClickedID(button, owner_id);
			return ret != 0;
		}

		/// <summary>
		/// <para>Shortcut Testing &amp; Routing</para>
		/// <para>- Set Shortcut() and SetNextItemShortcut() in imgui.h</para>
		/// <para>- When a policy (except for ImGuiInputFlags_RouteAlways *) is set, Shortcut() will register itself with SetShortcutRouting(),</para>
		/// <para>  allowing the system to decide where to route the input among other route-aware calls.</para>
		/// <para>  (* using ImGuiInputFlags_RouteAlways is roughly equivalent to calling IsKeyChordPressed(key) and bypassing route registration and check)</para>
		/// <para>- When using one of the routing option:</para>
		/// <para>  - The default route is ImGuiInputFlags_RouteFocused (accept inputs if window is in focus stack. Deep-most focused window takes inputs. ActiveId takes inputs over deep-most focused window.)</para>
		/// <para>  - Routes are requested given a chord (key + modifiers) and a routing policy.</para>
		/// <para>  - Routes are resolved during NewFrame(): if keyboard modifiers are matching current ones: SetKeyOwner() is called + route is granted for the frame.</para>
		/// <para>  - Each route may be granted to a single owner. When multiple requests are made we have policies to select the winning route (e.g. deep most window).</para>
		/// <para>  - Multiple read sites may use the same owner id can all access the granted route.</para>
		/// <para>  - When owner_id is 0 we use the current Focus Scope ID as a owner ID in order to identify our location.</para>
		/// <para>- You can chain two unrelated windows in the focus stack using SetWindowParentWindowForFocusRoute()</para>
		/// <para>  e.g. if you have a tool window associated to a document, and you want document shortcuts to run when the tool is focused.</para>
		/// </summary>
		public static bool ShortcutID(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_ShortcutID(key_chord, flags, owner_id);
			return ret != 0;
		}

		/// <summary>
		/// owner_id needs to be explicit and cannot be 0
		/// </summary>
		public static bool SetShortcutRouting(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_SetShortcutRouting(key_chord, flags, owner_id);
			return ret != 0;
		}

		public static bool TestShortcutRouting(ImGuiKey key_chord, uint owner_id)
		{
			var ret = ImGuiInternalNative.ImGui_TestShortcutRouting(key_chord, owner_id);
			return ret != 0;
		}

		public static ImGuiKeyRoutingDataPtr GetShortcutRoutingData(ImGuiKey key_chord)
		{
			var ret = ImGuiInternalNative.ImGui_GetShortcutRoutingData(key_chord);
			return ret;
		}

		/// <summary>
		/// <para>Docking</para>
		/// <para>(some functions are only declared in imgui.cpp, see Docking section)</para>
		/// </summary>
		public static void DockContextInitialize(ImGuiContextPtr ctx)
		{
			ImGuiInternalNative.ImGui_DockContextInitialize(ctx);
		}

		public static void DockContextShutdown(ImGuiContextPtr ctx)
		{
			ImGuiInternalNative.ImGui_DockContextShutdown(ctx);
		}

		/// <summary>
		/// Use root_id==0 to clear all
		/// </summary>
		public static void DockContextClearNodes(ImGuiContextPtr ctx, uint root_id, bool clear_settings_refs)
		{
			// Marshaling 'clear_settings_refs' to native bool
			var native_clear_settings_refs = clear_settings_refs ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_DockContextClearNodes(ctx, root_id, native_clear_settings_refs);
		}

		public static void DockContextRebuildNodes(ImGuiContextPtr ctx)
		{
			ImGuiInternalNative.ImGui_DockContextRebuildNodes(ctx);
		}

		public static void DockContextNewFrameUpdateUndocking(ImGuiContextPtr ctx)
		{
			ImGuiInternalNative.ImGui_DockContextNewFrameUpdateUndocking(ctx);
		}

		public static void DockContextNewFrameUpdateDocking(ImGuiContextPtr ctx)
		{
			ImGuiInternalNative.ImGui_DockContextNewFrameUpdateDocking(ctx);
		}

		public static void DockContextEndFrame(ImGuiContextPtr ctx)
		{
			ImGuiInternalNative.ImGui_DockContextEndFrame(ctx);
		}

		public static uint DockContextGenNodeID(ImGuiContextPtr ctx)
		{
			var ret = ImGuiInternalNative.ImGui_DockContextGenNodeID(ctx);
			return ret;
		}

		public static void DockContextQueueDock(ImGuiContextPtr ctx, ImGuiWindowPtr target, ImGuiDockNodePtr target_node, ImGuiWindowPtr payload, ImGuiDir split_dir, float split_ratio, bool split_outer)
		{
			// Marshaling 'split_outer' to native bool
			var native_split_outer = split_outer ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_DockContextQueueDock(ctx, target, target_node, payload, split_dir, split_ratio, native_split_outer);
		}

		public static void DockContextQueueUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_DockContextQueueUndockWindow(ctx, window);
		}

		public static void DockContextQueueUndockNode(ImGuiContextPtr ctx, ImGuiDockNodePtr node)
		{
			ImGuiInternalNative.ImGui_DockContextQueueUndockNode(ctx, node);
		}

		/// <summary>
		/// Implied clear_persistent_docking_ref = true
		/// </summary>
		public static void DockContextProcessUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_DockContextProcessUndockWindow(ctx, window);
		}

		/// <summary>
		/// Implied clear_persistent_docking_ref = true
		/// </summary>
		public static void DockContextProcessUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window, bool clear_persistent_docking_ref)
		{
			// Marshaling 'clear_persistent_docking_ref' to native bool
			var native_clear_persistent_docking_ref = clear_persistent_docking_ref ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_DockContextProcessUndockWindowEx(ctx, window, native_clear_persistent_docking_ref);
		}

		public static void DockContextProcessUndockNode(ImGuiContextPtr ctx, ImGuiDockNodePtr node)
		{
			ImGuiInternalNative.ImGui_DockContextProcessUndockNode(ctx, node);
		}

		public static bool DockContextCalcDropPosForDocking(ImGuiWindowPtr target, ImGuiDockNodePtr target_node, ImGuiWindowPtr payload_window, ImGuiDockNodePtr payload_node, ImGuiDir split_dir, bool split_outer, out Vector2 out_pos)
		{
			// Marshaling 'split_outer' to native bool
			var native_split_outer = split_outer ? (byte)1 : (byte)0;

			fixed (Vector2* native_out_pos = &out_pos)
			{
				var ret = ImGuiInternalNative.ImGui_DockContextCalcDropPosForDocking(target, target_node, payload_window, payload_node, split_dir, native_split_outer, native_out_pos);
				return ret != 0;
			}
		}

		public static ImGuiDockNodePtr DockContextFindNodeByID(ImGuiContextPtr ctx, uint id)
		{
			var ret = ImGuiInternalNative.ImGui_DockContextFindNodeByID(ctx, id);
			return ret;
		}

		public static void Default(ImGuiContextPtr ctx, ImGuiDockNodePtr node, ImGuiTabBarPtr tab_bar)
		{
			ImGuiInternalNative.ImGui_DockNodeWindowMenuHandler_Default(ctx, node, tab_bar);
		}

		public static bool DockNodeBeginAmendTabBar(ImGuiDockNodePtr node)
		{
			var ret = ImGuiInternalNative.ImGui_DockNodeBeginAmendTabBar(node);
			return ret != 0;
		}

		public static void DockNodeEndAmendTabBar()
		{
			ImGuiInternalNative.ImGui_DockNodeEndAmendTabBar();
		}

		public static ImGuiDockNodePtr DockNodeGetRootNode(ImGuiDockNodePtr node)
		{
			var ret = ImGuiInternalNative.ImGui_DockNodeGetRootNode(node);
			return ret;
		}

		public static bool DockNodeIsInHierarchyOf(ImGuiDockNodePtr node, ImGuiDockNodePtr parent)
		{
			var ret = ImGuiInternalNative.ImGui_DockNodeIsInHierarchyOf(node, parent);
			return ret != 0;
		}

		public static int DockNodeGetDepth(ImGuiDockNodePtr node)
		{
			var ret = ImGuiInternalNative.ImGui_DockNodeGetDepth(node);
			return ret;
		}

		public static uint DockNodeGetWindowMenuButtonId(ImGuiDockNodePtr node)
		{
			var ret = ImGuiInternalNative.ImGui_DockNodeGetWindowMenuButtonId(node);
			return ret;
		}

		public static ImGuiDockNodePtr GetWindowDockNode()
		{
			var ret = ImGuiInternalNative.ImGui_GetWindowDockNode();
			return ret;
		}

		public static bool GetWindowAlwaysWantOwnTabBar(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_GetWindowAlwaysWantOwnTabBar(window);
			return ret != 0;
		}

		public static void BeginDocked(ImGuiWindowPtr window, ref bool p_open)
		{
			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			ImGuiInternalNative.ImGui_BeginDocked(window, native_p_open);
			p_open = native_p_open_val != 0;
		}

		public static void BeginDockableDragDropSource(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_BeginDockableDragDropSource(window);
		}

		public static void BeginDockableDragDropTarget(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_BeginDockableDragDropTarget(window);
		}

		public static void SetWindowDock(ImGuiWindowPtr window, uint dock_id, ImGuiCond cond)
		{
			ImGuiInternalNative.ImGui_SetWindowDock(window, dock_id, cond);
		}

		/// <summary>
		/// <para>Docking - Builder function needs to be generally called before the node is used/submitted.</para>
		/// <para>- The DockBuilderXXX functions are designed to _eventually_ become a public API, but it is too early to expose it and guarantee stability.</para>
		/// <para>- Do not hold on ImGuiDockNode* pointers! They may be invalidated by any split/merge/remove operation and every frame.</para>
		/// <para>- To create a DockSpace() node, make sure to set the ImGuiDockNodeFlags_DockSpace flag when calling DockBuilderAddNode().</para>
		/// <para>  You can create dockspace nodes (attached to a window) _or_ floating nodes (carry its own window) with this API.</para>
		/// <para>- DockBuilderSplitNode() create 2 child nodes within 1 node. The initial node becomes a parent node.</para>
		/// <para>- If you intend to split the node immediately after creation using DockBuilderSplitNode(), make sure</para>
		/// <para>  to call DockBuilderSetNodeSize() beforehand. If you don't, the resulting split sizes may not be reliable.</para>
		/// <para>- Call DockBuilderFinish() after you are done.</para>
		/// </summary>
		public static void DockBuilderDockWindow(ReadOnlySpan<char> window_name, uint node_id)
		{
			// Marshaling 'window_name' to native string
			byte* native_window_name;
			var window_name_byteCount = 0;
			if (window_name != null)
			{
				window_name_byteCount = Encoding.UTF8.GetByteCount(window_name);
				if (window_name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_window_name = Util.Allocate(window_name_byteCount + 1);
				}
				else
				{
					var native_window_name_stackBytes = stackalloc byte[window_name_byteCount + 1];
					native_window_name = native_window_name_stackBytes;
				}
				var window_name_offset = Util.GetUtf8(window_name, native_window_name, window_name_byteCount);
				native_window_name[window_name_offset] = 0;
			}
			else native_window_name = null;

			ImGuiInternalNative.ImGui_DockBuilderDockWindow(native_window_name, node_id);
			if (window_name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_window_name);
			}
		}

		public static ImGuiDockNodePtr DockBuilderGetNode(uint node_id)
		{
			var ret = ImGuiInternalNative.ImGui_DockBuilderGetNode(node_id);
			return ret;
		}

		public static ImGuiDockNodePtr DockBuilderGetCentralNode(uint node_id)
		{
			var ret = ImGuiInternalNative.ImGui_DockBuilderGetCentralNode(node_id);
			return ret;
		}

		/// <summary>
		/// Implied node_id = 0, flags = 0
		/// </summary>
		public static uint DockBuilderAddNode()
		{
			var ret = ImGuiInternalNative.ImGui_DockBuilderAddNode();
			return ret;
		}

		/// <summary>
		/// Implied node_id = 0, flags = 0
		/// </summary>
		public static uint DockBuilderAddNode(uint node_id)
		{
			ImGuiDockNodeFlags flags = (ImGuiDockNodeFlags)0;

			var ret = ImGuiInternalNative.ImGui_DockBuilderAddNodeEx(node_id, flags);
			return ret;
		}
		/// <summary>
		/// Implied node_id = 0, flags = 0
		/// </summary>
		public static uint DockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_DockBuilderAddNodeEx(node_id, flags);
			return ret;
		}

		/// <summary>
		/// Remove node and all its child, undock all windows
		/// </summary>
		public static void DockBuilderRemoveNode(uint node_id)
		{
			ImGuiInternalNative.ImGui_DockBuilderRemoveNode(node_id);
		}

		/// <summary>
		/// Implied clear_settings_refs = true
		/// </summary>
		public static void DockBuilderRemoveNodeDockedWindows(uint node_id)
		{
			ImGuiInternalNative.ImGui_DockBuilderRemoveNodeDockedWindows(node_id);
		}

		/// <summary>
		/// Implied clear_settings_refs = true
		/// </summary>
		public static void DockBuilderRemoveNodeDockedWindows(uint node_id, bool clear_settings_refs)
		{
			// Marshaling 'clear_settings_refs' to native bool
			var native_clear_settings_refs = clear_settings_refs ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_DockBuilderRemoveNodeDockedWindowsEx(node_id, native_clear_settings_refs);
		}

		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).
		/// </summary>
		public static void DockBuilderRemoveNodeChildNodes(uint node_id)
		{
			ImGuiInternalNative.ImGui_DockBuilderRemoveNodeChildNodes(node_id);
		}

		public static void DockBuilderSetNodePos(uint node_id, Vector2 pos)
		{
			ImGuiInternalNative.ImGui_DockBuilderSetNodePos(node_id, pos);
		}

		public static void DockBuilderSetNodeSize(uint node_id, Vector2 size)
		{
			ImGuiInternalNative.ImGui_DockBuilderSetNodeSize(node_id, size);
		}

		/// <summary>
		/// Create 2 child nodes in this parent node.
		/// </summary>
		public static uint DockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, out uint out_id_at_dir, out uint out_id_at_opposite_dir)
		{
			fixed (uint* native_out_id_at_dir = &out_id_at_dir)
			fixed (uint* native_out_id_at_opposite_dir = &out_id_at_opposite_dir)
			{
				var ret = ImGuiInternalNative.ImGui_DockBuilderSplitNode(node_id, split_dir, size_ratio_for_node_at_dir, native_out_id_at_dir, native_out_id_at_opposite_dir);
				return ret;
			}
		}

		public static void DockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector* in_window_remap_pairs)
		{
			ImGuiInternalNative.ImGui_DockBuilderCopyDockSpace(src_dockspace_id, dst_dockspace_id, in_window_remap_pairs);
		}

		public static void DockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector* out_node_remap_pairs)
		{
			ImGuiInternalNative.ImGui_DockBuilderCopyNode(src_node_id, dst_node_id, out_node_remap_pairs);
		}

		public static void DockBuilderCopyWindowSettings(ReadOnlySpan<char> src_name, ReadOnlySpan<char> dst_name)
		{
			// Marshaling 'src_name' to native string
			byte* native_src_name;
			var src_name_byteCount = 0;
			if (src_name != null)
			{
				src_name_byteCount = Encoding.UTF8.GetByteCount(src_name);
				if (src_name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_src_name = Util.Allocate(src_name_byteCount + 1);
				}
				else
				{
					var native_src_name_stackBytes = stackalloc byte[src_name_byteCount + 1];
					native_src_name = native_src_name_stackBytes;
				}
				var src_name_offset = Util.GetUtf8(src_name, native_src_name, src_name_byteCount);
				native_src_name[src_name_offset] = 0;
			}
			else native_src_name = null;

			// Marshaling 'dst_name' to native string
			byte* native_dst_name;
			var dst_name_byteCount = 0;
			if (dst_name != null)
			{
				dst_name_byteCount = Encoding.UTF8.GetByteCount(dst_name);
				if (dst_name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_dst_name = Util.Allocate(dst_name_byteCount + 1);
				}
				else
				{
					var native_dst_name_stackBytes = stackalloc byte[dst_name_byteCount + 1];
					native_dst_name = native_dst_name_stackBytes;
				}
				var dst_name_offset = Util.GetUtf8(dst_name, native_dst_name, dst_name_byteCount);
				native_dst_name[dst_name_offset] = 0;
			}
			else native_dst_name = null;

			ImGuiInternalNative.ImGui_DockBuilderCopyWindowSettings(native_src_name, native_dst_name);
			if (src_name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_src_name);
			}
			if (dst_name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_dst_name);
			}
		}

		public static void DockBuilderFinish(uint node_id)
		{
			ImGuiInternalNative.ImGui_DockBuilderFinish(node_id);
		}

		/// <summary>
		/// <para>[EXPERIMENTAL] Focus Scope</para>
		/// <para>This is generally used to identify a unique input location (for e.g. a selection set)</para>
		/// <para>There is one per window (automatically set in Begin), but:</para>
		/// <para>- Selection patterns generally need to react (e.g. clear a selection) when landing on one item of the set.</para>
		/// <para>  So in order to identify a set multiple lists in same window may each need a focus scope.</para>
		/// <para>  If you imagine an hypothetical BeginSelectionGroup()/EndSelectionGroup() api, it would likely call PushFocusScope()/EndFocusScope()</para>
		/// <para>- Shortcut routing also use focus scope as a default location identifier if an owner is not provided.</para>
		/// <para>We don't use the ID Stack for this as it is common to want them separate.</para>
		/// </summary>
		public static void PushFocusScope(uint id)
		{
			ImGuiInternalNative.ImGui_PushFocusScope(id);
		}

		public static void PopFocusScope()
		{
			ImGuiInternalNative.ImGui_PopFocusScope();
		}

		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()
		/// </summary>
		public static uint GetCurrentFocusScope()
		{
			var ret = ImGuiInternalNative.ImGui_GetCurrentFocusScope();
			return ret;
		}

		/// <summary>
		/// <para>Drag and Drop</para>
		/// </summary>
		public static bool IsDragDropActive()
		{
			var ret = ImGuiInternalNative.ImGui_IsDragDropActive();
			return ret != 0;
		}

		public static bool BeginDragDropTargetCustom(ImRect bb, uint id)
		{
			var ret = ImGuiInternalNative.ImGui_BeginDragDropTargetCustom(bb, id);
			return ret != 0;
		}

		public static void ClearDragDrop()
		{
			ImGuiInternalNative.ImGui_ClearDragDrop();
		}

		public static bool IsDragDropPayloadBeingAccepted()
		{
			var ret = ImGuiInternalNative.ImGui_IsDragDropPayloadBeingAccepted();
			return ret != 0;
		}

		public static void RenderDragDropTargetRect(ImRect bb, ImRect item_clip_rect)
		{
			ImGuiInternalNative.ImGui_RenderDragDropTargetRect(bb, item_clip_rect);
		}

		/// <summary>
		/// <para>Typing-Select API</para>
		/// <para>(provide Windows Explorer style "select items by typing partial name" + "cycle through items by typing same letter" feature)</para>
		/// <para>(this is currently not documented nor used by main library, but should work. See "widgets_typingselect" in imgui_test_suite for usage code. Please let us know if you use this!)</para>
		/// </summary>
		/// <summary>
		/// Implied flags = ImGuiTypingSelectFlags_None
		/// </summary>
		public static ImGuiTypingSelectRequestPtr GetTypingSelectRequest()
		{
			var ret = ImGuiInternalNative.ImGui_GetTypingSelectRequest();
			return ret;
		}

		/// <summary>
		/// <para>Typing-Select API</para>
		/// <para>(provide Windows Explorer style "select items by typing partial name" + "cycle through items by typing same letter" feature)</para>
		/// <para>(this is currently not documented nor used by main library, but should work. See "widgets_typingselect" in imgui_test_suite for usage code. Please let us know if you use this!)</para>
		/// </summary>
		/// <summary>
		/// Implied flags = ImGuiTypingSelectFlags_None
		/// </summary>
		public static ImGuiTypingSelectRequestPtr GetTypingSelectRequest(ImGuiTypingSelectFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_GetTypingSelectRequestEx(flags);
			return ret;
		}

		public static int TypingSelectFindMatch(ImGuiTypingSelectRequestPtr req, int items_count, ImGui_TypingSelectFindMatchget_item_name_funcDelegate get_item_name_func, IntPtr user_data, int nav_item_idx)
		{
			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			var ret = ImGuiInternalNative.ImGui_TypingSelectFindMatch(req, items_count, get_item_name_func, native_user_data, nav_item_idx);
			return ret;
		}

		public static int TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequestPtr req, int items_count, ImGui_TypingSelectFindNextSingleCharMatchget_item_name_funcDelegate get_item_name_func, IntPtr user_data, int nav_item_idx)
		{
			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			var ret = ImGuiInternalNative.ImGui_TypingSelectFindNextSingleCharMatch(req, items_count, get_item_name_func, native_user_data, nav_item_idx);
			return ret;
		}

		public static int TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequestPtr req, int items_count, ImGui_TypingSelectFindBestLeadingMatchget_item_name_funcDelegate get_item_name_func, IntPtr user_data)
		{
			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			var ret = ImGuiInternalNative.ImGui_TypingSelectFindBestLeadingMatch(req, items_count, get_item_name_func, native_user_data);
			return ret;
		}

		/// <summary>
		/// <para>Box-Select API</para>
		/// </summary>
		public static bool BeginBoxSelect(ImRect scope_rect, ImGuiWindowPtr window, uint box_select_id, ImGuiMultiSelectFlags ms_flags)
		{
			var ret = ImGuiInternalNative.ImGui_BeginBoxSelect(scope_rect, window, box_select_id, ms_flags);
			return ret != 0;
		}

		public static void EndBoxSelect(ImRect scope_rect, ImGuiMultiSelectFlags ms_flags)
		{
			ImGuiInternalNative.ImGui_EndBoxSelect(scope_rect, ms_flags);
		}

		/// <summary>
		/// <para>Multi-Select API</para>
		/// </summary>
		public static void MultiSelectItemHeader(uint id, ref bool p_selected, ref ImGuiButtonFlags p_button_flags)
		{
			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			fixed (ImGuiButtonFlags* native_p_button_flags = &p_button_flags)
			{
				ImGuiInternalNative.ImGui_MultiSelectItemHeader(id, native_p_selected, native_p_button_flags);
				p_selected = native_p_selected_val != 0;
			}
		}

		public static void MultiSelectItemFooter(uint id, ref bool p_selected, ref bool p_pressed)
		{
			// Marshaling 'p_selected' to native bool
			var native_p_selected_val = p_selected ? (byte)1 : (byte)0;
			var native_p_selected = &native_p_selected_val;

			// Marshaling 'p_pressed' to native bool
			var native_p_pressed_val = p_pressed ? (byte)1 : (byte)0;
			var native_p_pressed = &native_p_pressed_val;

			ImGuiInternalNative.ImGui_MultiSelectItemFooter(id, native_p_selected, native_p_pressed);
			p_selected = native_p_selected_val != 0;
			p_pressed = native_p_pressed_val != 0;
		}

		public static void MultiSelectAddSetAll(ImGuiMultiSelectTempDataPtr ms, bool selected)
		{
			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_MultiSelectAddSetAll(ms, native_selected);
		}

		public static void MultiSelectAddSetRange(ImGuiMultiSelectTempDataPtr ms, bool selected, int range_dir, long first_item, long last_item)
		{
			// Marshaling 'selected' to native bool
			var native_selected = selected ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_MultiSelectAddSetRange(ms, native_selected, range_dir, first_item, last_item);
		}

		public static ImGuiBoxSelectStatePtr GetBoxSelectState(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_GetBoxSelectState(id);
			return ret;
		}

		public static ImGuiMultiSelectStatePtr GetMultiSelectState(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_GetMultiSelectState(id);
			return ret;
		}

		/// <summary>
		/// <para>Internal Columns API (this is not exposed because we will encourage transitioning to the Tables API)</para>
		/// </summary>
		public static void SetWindowClipRectBeforeSetChannel(ImGuiWindowPtr window, ImRect clip_rect)
		{
			ImGuiInternalNative.ImGui_SetWindowClipRectBeforeSetChannel(window, clip_rect);
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<char> str_id, int count)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiOldColumnFlags flags = (ImGuiOldColumnFlags)0;

			ImGuiInternalNative.ImGui_BeginColumns(native_str_id, count, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}
		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<char> str_id, int count, ImGuiOldColumnFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiInternalNative.ImGui_BeginColumns(native_str_id, count, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
		}

		/// <summary>
		/// close columns
		/// </summary>
		public static void EndColumns()
		{
			ImGuiInternalNative.ImGui_EndColumns();
		}

		public static void PushColumnClipRect(int column_index)
		{
			ImGuiInternalNative.ImGui_PushColumnClipRect(column_index);
		}

		public static void PushColumnsBackground()
		{
			ImGuiInternalNative.ImGui_PushColumnsBackground();
		}

		public static void PopColumnsBackground()
		{
			ImGuiInternalNative.ImGui_PopColumnsBackground();
		}

		public static uint GetColumnsID(ReadOnlySpan<char> str_id, int count)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiInternalNative.ImGui_GetColumnsID(native_str_id, count);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret;
		}

		public static ImGuiOldColumnsPtr FindOrCreateColumns(ImGuiWindowPtr window, uint id)
		{
			var ret = ImGuiInternalNative.ImGui_FindOrCreateColumns(window, id);
			return ret;
		}

		public static float GetColumnOffsetFromNorm(ImGuiOldColumnsPtr columns, float offset_norm)
		{
			var ret = ImGuiInternalNative.ImGui_GetColumnOffsetFromNorm(columns, offset_norm);
			return ret;
		}

		public static float GetColumnNormFromOffset(ImGuiOldColumnsPtr columns, float offset)
		{
			var ret = ImGuiInternalNative.ImGui_GetColumnNormFromOffset(columns, offset);
			return ret;
		}

		/// <summary>
		/// <para>Tables: Candidates for public API</para>
		/// </summary>
		/// <summary>
		/// Implied column_n = -1
		/// </summary>
		public static void TableOpenContextMenu()
		{
			ImGuiInternalNative.ImGui_TableOpenContextMenu();
		}

		/// <summary>
		/// <para>Tables: Candidates for public API</para>
		/// </summary>
		/// <summary>
		/// Implied column_n = -1
		/// </summary>
		public static void TableOpenContextMenu(int column_n)
		{
			ImGuiInternalNative.ImGui_TableOpenContextMenuEx(column_n);
		}

		public static void TableSetColumnWidth(int column_n, float width)
		{
			ImGuiInternalNative.ImGui_TableSetColumnWidth(column_n, width);
		}

		public static void TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, bool append_to_sort_specs)
		{
			// Marshaling 'append_to_sort_specs' to native bool
			var native_append_to_sort_specs = append_to_sort_specs ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_TableSetColumnSortDirection(column_n, sort_direction, native_append_to_sort_specs);
		}

		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.
		/// </summary>
		public static int TableGetHoveredRow()
		{
			var ret = ImGuiInternalNative.ImGui_TableGetHoveredRow();
			return ret;
		}

		public static float TableGetHeaderRowHeight()
		{
			var ret = ImGuiInternalNative.ImGui_TableGetHeaderRowHeight();
			return ret;
		}

		public static float TableGetHeaderAngledMaxLabelWidth()
		{
			var ret = ImGuiInternalNative.ImGui_TableGetHeaderAngledMaxLabelWidth();
			return ret;
		}

		public static void TablePushBackgroundChannel()
		{
			ImGuiInternalNative.ImGui_TablePushBackgroundChannel();
		}

		public static void TablePopBackgroundChannel()
		{
			ImGuiInternalNative.ImGui_TablePopBackgroundChannel();
		}

		public static void TableAngledHeadersRow(uint row_id, float angle, float max_label_width, ImGuiTableHeaderDataPtr data, int data_count)
		{
			ImGuiInternalNative.ImGui_TableAngledHeadersRowEx(row_id, angle, max_label_width, data, data_count);
		}

		/// <summary>
		/// <para>Tables: Internals</para>
		/// </summary>
		public static ImGuiTablePtr GetCurrentTable()
		{
			var ret = ImGuiInternalNative.ImGui_GetCurrentTable();
			return ret;
		}

		public static ImGuiTablePtr TableFindByID(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_TableFindByID(id);
			return ret;
		}

		/// <summary>
		/// Implied outer_size = ImVec2(0, 0), inner_width = 0.0f
		/// </summary>
		public static bool BeginTableWithID(ReadOnlySpan<char> name, uint id, int columns_count)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			ImGuiTableFlags flags = (ImGuiTableFlags)0;

			var ret = ImGuiInternalNative.ImGui_BeginTableWithID(native_name, id, columns_count, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied outer_size = ImVec2(0, 0), inner_width = 0.0f
		/// </summary>
		public static bool BeginTableWithID(ReadOnlySpan<char> name, uint id, int columns_count, ImGuiTableFlags flags)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var ret = ImGuiInternalNative.ImGui_BeginTableWithID(native_name, id, columns_count, flags);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied outer_size = ImVec2(0, 0), inner_width = 0.0f
		/// </summary>
		public static bool BeginTableWithID(ReadOnlySpan<char> name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			float inner_width = 0.0f;

			var ret = ImGuiInternalNative.ImGui_BeginTableWithIDEx(native_name, id, columns_count, flags, outer_size, inner_width);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied outer_size = ImVec2(0, 0), inner_width = 0.0f
		/// </summary>
		public static bool BeginTableWithID(ReadOnlySpan<char> name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width)
		{
			// Marshaling 'name' to native string
			byte* native_name;
			var name_byteCount = 0;
			if (name != null)
			{
				name_byteCount = Encoding.UTF8.GetByteCount(name);
				if (name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_name = Util.Allocate(name_byteCount + 1);
				}
				else
				{
					var native_name_stackBytes = stackalloc byte[name_byteCount + 1];
					native_name = native_name_stackBytes;
				}
				var name_offset = Util.GetUtf8(name, native_name, name_byteCount);
				native_name[name_offset] = 0;
			}
			else native_name = null;

			var ret = ImGuiInternalNative.ImGui_BeginTableWithIDEx(native_name, id, columns_count, flags, outer_size, inner_width);
			if (name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_name);
			}
			return ret != 0;
		}

		public static void TableBeginInitMemory(ImGuiTablePtr table, int columns_count)
		{
			ImGuiInternalNative.ImGui_TableBeginInitMemory(table, columns_count);
		}

		public static void TableBeginApplyRequests(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableBeginApplyRequests(table);
		}

		public static void TableSetupDrawChannels(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableSetupDrawChannels(table);
		}

		public static void TableUpdateLayout(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableUpdateLayout(table);
		}

		public static void TableUpdateBorders(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableUpdateBorders(table);
		}

		public static void TableUpdateColumnsWeightFromWidth(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableUpdateColumnsWeightFromWidth(table);
		}

		public static void TableDrawBorders(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableDrawBorders(table);
		}

		public static void TableDrawDefaultContextMenu(ImGuiTablePtr table, ImGuiTableFlags flags_for_section_to_display)
		{
			ImGuiInternalNative.ImGui_TableDrawDefaultContextMenu(table, flags_for_section_to_display);
		}

		public static bool TableBeginContextMenuPopup(ImGuiTablePtr table)
		{
			var ret = ImGuiInternalNative.ImGui_TableBeginContextMenuPopup(table);
			return ret != 0;
		}

		public static void TableMergeDrawChannels(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableMergeDrawChannels(table);
		}

		public static ImGuiTableInstanceDataPtr TableGetInstanceData(ImGuiTablePtr table, int instance_no)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetInstanceData(table, instance_no);
			return ret;
		}

		public static uint TableGetInstanceID(ImGuiTablePtr table, int instance_no)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetInstanceID(table, instance_no);
			return ret;
		}

		public static void TableSortSpecsSanitize(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableSortSpecsSanitize(table);
		}

		public static void TableSortSpecsBuild(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableSortSpecsBuild(table);
		}

		public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumnPtr column)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetColumnNextSortDirection(column);
			return ret;
		}

		public static void TableFixColumnSortDirection(ImGuiTablePtr table, ImGuiTableColumnPtr column)
		{
			ImGuiInternalNative.ImGui_TableFixColumnSortDirection(table, column);
		}

		public static float TableGetColumnWidthAuto(ImGuiTablePtr table, ImGuiTableColumnPtr column)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetColumnWidthAuto(table, column);
			return ret;
		}

		public static void TableBeginRow(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableBeginRow(table);
		}

		public static void TableEndRow(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableEndRow(table);
		}

		public static void TableBeginCell(ImGuiTablePtr table, int column_n)
		{
			ImGuiInternalNative.ImGui_TableBeginCell(table, column_n);
		}

		public static void TableEndCell(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableEndCell(table);
		}

		public static ImRect TableGetCellBgRect(ImGuiTablePtr table, int column_n)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetCellBgRect(table, column_n);
			return ret;
		}

		public static string TableGetColumnNameImGuiTablePtr(ImGuiTablePtr table, int column_n)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetColumnNameImGuiTablePtr(table, column_n);
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// Implied instance_no = 0
		/// </summary>
		public static uint TableGetColumnResizeID(ImGuiTablePtr table, int column_n)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetColumnResizeID(table, column_n);
			return ret;
		}

		/// <summary>
		/// Implied instance_no = 0
		/// </summary>
		public static uint TableGetColumnResizeID(ImGuiTablePtr table, int column_n, int instance_no)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetColumnResizeIDEx(table, column_n, instance_no);
			return ret;
		}

		public static float TableCalcMaxColumnWidth(ImGuiTablePtr table, int column_n)
		{
			var ret = ImGuiInternalNative.ImGui_TableCalcMaxColumnWidth(table, column_n);
			return ret;
		}

		public static void TableSetColumnWidthAutoSingle(ImGuiTablePtr table, int column_n)
		{
			ImGuiInternalNative.ImGui_TableSetColumnWidthAutoSingle(table, column_n);
		}

		public static void TableSetColumnWidthAutoAll(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableSetColumnWidthAutoAll(table);
		}

		public static void TableRemove(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableRemove(table);
		}

		public static void TableGcCompactTransientBuffers(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableGcCompactTransientBuffers(table);
		}

		public static void TableGcCompactTransientBuffersImGuiTableTempDataPtr(ImGuiTableTempDataPtr table)
		{
			ImGuiInternalNative.ImGui_TableGcCompactTransientBuffersImGuiTableTempDataPtr(table);
		}

		public static void TableGcCompactSettings()
		{
			ImGuiInternalNative.ImGui_TableGcCompactSettings();
		}

		/// <summary>
		/// <para>Tables: Settings</para>
		/// </summary>
		public static void TableLoadSettings(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableLoadSettings(table);
		}

		public static void TableSaveSettings(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableSaveSettings(table);
		}

		public static void TableResetSettings(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_TableResetSettings(table);
		}

		public static ImGuiTableSettingsPtr TableGetBoundSettings(ImGuiTablePtr table)
		{
			var ret = ImGuiInternalNative.ImGui_TableGetBoundSettings(table);
			return ret;
		}

		public static void TableSettingsAddSettingsHandler()
		{
			ImGuiInternalNative.ImGui_TableSettingsAddSettingsHandler();
		}

		public static ImGuiTableSettingsPtr TableSettingsCreate(uint id, int columns_count)
		{
			var ret = ImGuiInternalNative.ImGui_TableSettingsCreate(id, columns_count);
			return ret;
		}

		public static ImGuiTableSettingsPtr TableSettingsFindByID(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_TableSettingsFindByID(id);
			return ret;
		}

		/// <summary>
		/// <para>Tab Bars</para>
		/// </summary>
		public static ImGuiTabBarPtr GetCurrentTabBar()
		{
			var ret = ImGuiInternalNative.ImGui_GetCurrentTabBar();
			return ret;
		}

		public static bool BeginTabBar(ImGuiTabBarPtr tab_bar, ImRect bb, ImGuiTabBarFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_BeginTabBarEx(tab_bar, bb, flags);
			return ret != 0;
		}

		public static ImGuiTabItemPtr TabBarFindTabByID(ImGuiTabBarPtr tab_bar, uint tab_id)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarFindTabByID(tab_bar, tab_id);
			return ret;
		}

		public static ImGuiTabItemPtr TabBarFindTabByOrder(ImGuiTabBarPtr tab_bar, int order)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarFindTabByOrder(tab_bar, order);
			return ret;
		}

		public static ImGuiTabItemPtr TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBarPtr tab_bar)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarFindMostRecentlySelectedTabForActiveWindow(tab_bar);
			return ret;
		}

		public static ImGuiTabItemPtr TabBarGetCurrentTab(ImGuiTabBarPtr tab_bar)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarGetCurrentTab(tab_bar);
			return ret;
		}

		public static int TabBarGetTabOrder(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarGetTabOrder(tab_bar, tab);
			return ret;
		}

		public static string TabBarGetTabName(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarGetTabName(tab_bar, tab);
			return Util.StringFromPtr(ret);
		}

		public static void TabBarAddTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_TabBarAddTab(tab_bar, tab_flags, window);
		}

		public static void TabBarRemoveTab(ImGuiTabBarPtr tab_bar, uint tab_id)
		{
			ImGuiInternalNative.ImGui_TabBarRemoveTab(tab_bar, tab_id);
		}

		public static void TabBarCloseTab(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab)
		{
			ImGuiInternalNative.ImGui_TabBarCloseTab(tab_bar, tab);
		}

		public static void TabBarQueueFocus(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab)
		{
			ImGuiInternalNative.ImGui_TabBarQueueFocus(tab_bar, tab);
		}

		public static void TabBarQueueFocusStr(ImGuiTabBarPtr tab_bar, ReadOnlySpan<char> tab_name)
		{
			// Marshaling 'tab_name' to native string
			byte* native_tab_name;
			var tab_name_byteCount = 0;
			if (tab_name != null)
			{
				tab_name_byteCount = Encoding.UTF8.GetByteCount(tab_name);
				if (tab_name_byteCount > Util.StackAllocationSizeLimit)
				{
					native_tab_name = Util.Allocate(tab_name_byteCount + 1);
				}
				else
				{
					var native_tab_name_stackBytes = stackalloc byte[tab_name_byteCount + 1];
					native_tab_name = native_tab_name_stackBytes;
				}
				var tab_name_offset = Util.GetUtf8(tab_name, native_tab_name, tab_name_byteCount);
				native_tab_name[tab_name_offset] = 0;
			}
			else native_tab_name = null;

			ImGuiInternalNative.ImGui_TabBarQueueFocusStr(tab_bar, native_tab_name);
			if (tab_name_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_tab_name);
			}
		}

		public static void TabBarQueueReorder(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, int offset)
		{
			ImGuiInternalNative.ImGui_TabBarQueueReorder(tab_bar, tab, offset);
		}

		public static void TabBarQueueReorderFromMousePos(ImGuiTabBarPtr tab_bar, ImGuiTabItemPtr tab, Vector2 mouse_pos)
		{
			ImGuiInternalNative.ImGui_TabBarQueueReorderFromMousePos(tab_bar, tab, mouse_pos);
		}

		public static bool TabBarProcessReorder(ImGuiTabBarPtr tab_bar)
		{
			var ret = ImGuiInternalNative.ImGui_TabBarProcessReorder(tab_bar);
			return ret != 0;
		}

		public static bool TabItem(ImGuiTabBarPtr tab_bar, ReadOnlySpan<char> label, ref bool p_open, ImGuiTabItemFlags flags, ImGuiWindowPtr docked_window)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_open' to native bool
			var native_p_open_val = p_open ? (byte)1 : (byte)0;
			var native_p_open = &native_p_open_val;

			var ret = ImGuiInternalNative.ImGui_TabItemEx(tab_bar, native_label, native_p_open, flags, docked_window);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			p_open = native_p_open_val != 0;
			return ret != 0;
		}

		public static Vector2 TabItemCalcSizeStr(ReadOnlySpan<char> label, bool has_close_button_or_unsaved_marker)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'has_close_button_or_unsaved_marker' to native bool
			var native_has_close_button_or_unsaved_marker = has_close_button_or_unsaved_marker ? (byte)1 : (byte)0;

			var ret = ImGuiInternalNative.ImGui_TabItemCalcSizeStr(native_label, native_has_close_button_or_unsaved_marker);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret;
		}

		public static Vector2 TabItemCalcSize(ImGuiWindowPtr window)
		{
			var ret = ImGuiInternalNative.ImGui_TabItemCalcSize(window);
			return ret;
		}

		public static void TabItemBackground(ImDrawListPtr draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col)
		{
			ImGuiInternalNative.ImGui_TabItemBackground(draw_list, bb, flags, col);
		}

		public static void TabItemLabelAndCloseButton(ImDrawListPtr draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, ReadOnlySpan<char> label, uint tab_id, uint close_button_id, bool is_contents_visible, ref bool out_just_closed, ref bool out_text_clipped)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'is_contents_visible' to native bool
			var native_is_contents_visible = is_contents_visible ? (byte)1 : (byte)0;

			// Marshaling 'out_just_closed' to native bool
			var native_out_just_closed_val = out_just_closed ? (byte)1 : (byte)0;
			var native_out_just_closed = &native_out_just_closed_val;

			// Marshaling 'out_text_clipped' to native bool
			var native_out_text_clipped_val = out_text_clipped ? (byte)1 : (byte)0;
			var native_out_text_clipped = &native_out_text_clipped_val;

			ImGuiInternalNative.ImGui_TabItemLabelAndCloseButton(draw_list, bb, flags, frame_padding, native_label, tab_id, close_button_id, native_is_contents_visible, native_out_just_closed, native_out_text_clipped);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			out_just_closed = native_out_just_closed_val != 0;
			out_text_clipped = native_out_text_clipped_val != 0;
		}

		/// <summary>
		/// <para>Render helpers</para>
		/// <para>AVOID USING OUTSIDE OF IMGUI.CPP! NOT FOR PUBLIC CONSUMPTION. THOSE FUNCTIONS ARE A MESS. THEIR SIGNATURE AND BEHAVIOR WILL CHANGE, THEY NEED TO BE REFACTORED INTO SOMETHING DECENT.</para>
		/// <para>NB: All position are in absolute pixels coordinates (we are never using window coordinates internally)</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_hash = true
		/// </summary>
		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiInternalNative.ImGui_RenderText(pos, native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		/// <summary>
		/// <para>Render helpers</para>
		/// <para>AVOID USING OUTSIDE OF IMGUI.CPP! NOT FOR PUBLIC CONSUMPTION. THOSE FUNCTIONS ARE A MESS. THEIR SIGNATURE AND BEHAVIOR WILL CHANGE, THEY NEED TO BE REFACTORED INTO SOMETHING DECENT.</para>
		/// <para>NB: All position are in absolute pixels coordinates (we are never using window coordinates internally)</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_hash = true
		/// </summary>
		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			byte hide_text_after_hash = 1;

			ImGuiInternalNative.ImGui_RenderTextEx(pos, native_text, native_text_end, hide_text_after_hash);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}
		/// <summary>
		/// <para>Render helpers</para>
		/// <para>AVOID USING OUTSIDE OF IMGUI.CPP! NOT FOR PUBLIC CONSUMPTION. THOSE FUNCTIONS ARE A MESS. THEIR SIGNATURE AND BEHAVIOR WILL CHANGE, THEY NEED TO BE REFACTORED INTO SOMETHING DECENT.</para>
		/// <para>NB: All position are in absolute pixels coordinates (we are never using window coordinates internally)</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_hash = true
		/// </summary>
		public static void RenderText(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, bool hide_text_after_hash)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			// Marshaling 'hide_text_after_hash' to native bool
			var native_hide_text_after_hash = hide_text_after_hash ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_RenderTextEx(pos, native_text, native_text_end, native_hide_text_after_hash);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		public static void RenderTextWrapped(Vector2 pos, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, float wrap_width)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImGuiInternalNative.ImGui_RenderTextWrapped(pos, native_text, native_text_end, wrap_width);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		public static void RenderTextClipped(Vector2 pos_min, Vector2 pos_max, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextClipped(pos_min, pos_max, native_text, native_text_end, native_text_size_if_known);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		public static void RenderTextClipped(Vector2 pos_min, Vector2 pos_max, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known, Vector2 align)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImRect* clip_rect = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextClippedEx(pos_min, pos_max, native_text, native_text_end, native_text_size_if_known, align, clip_rect);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}
		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		public static void RenderTextClipped(Vector2 pos_min, Vector2 pos_max, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known, Vector2 align, ImRectPtr clip_rect)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextClippedEx(pos_min, pos_max, native_text, native_text_end, native_text_size_if_known, align, clip_rect);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		public static void RenderTextClippedWithDrawList(ImDrawListPtr draw_list, Vector2 pos_min, Vector2 pos_max, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextClippedWithDrawList(draw_list, pos_min, pos_max, native_text, native_text_end, native_text_size_if_known);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		public static void RenderTextClippedWithDrawList(ImDrawListPtr draw_list, Vector2 pos_min, Vector2 pos_max, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known, Vector2 align)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImRect* clip_rect = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextClippedWithDrawListEx(draw_list, pos_min, pos_max, native_text, native_text_end, native_text_size_if_known, align, clip_rect);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}
		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		public static void RenderTextClippedWithDrawList(ImDrawListPtr draw_list, Vector2 pos_min, Vector2 pos_max, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known, Vector2 align, ImRectPtr clip_rect)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextClippedWithDrawListEx(draw_list, pos_min, pos_max, native_text, native_text_end, native_text_size_if_known, align, clip_rect);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		public static void RenderTextEllipsis(ImDrawListPtr draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ref Vector2 text_size_if_known)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			fixed (Vector2* native_text_size_if_known = &text_size_if_known)
			{
				ImGuiInternalNative.ImGui_RenderTextEllipsis(draw_list, pos_min, pos_max, clip_max_x, ellipsis_max_x, native_text, native_text_end, native_text_size_if_known);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text_end);
				}
			}
		}

		/// <summary>
		/// Implied borders = true, rounding = 0.0f
		/// </summary>
		public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col)
		{
			ImGuiInternalNative.ImGui_RenderFrame(p_min, p_max, fill_col);
		}

		/// <summary>
		/// Implied borders = true, rounding = 0.0f
		/// </summary>
		public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, bool borders)
		{
			// Marshaling 'borders' to native bool
			var native_borders = borders ? (byte)1 : (byte)0;

			float rounding = 0.0f;

			ImGuiInternalNative.ImGui_RenderFrameEx(p_min, p_max, fill_col, native_borders, rounding);
		}
		/// <summary>
		/// Implied borders = true, rounding = 0.0f
		/// </summary>
		public static void RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, bool borders, float rounding)
		{
			// Marshaling 'borders' to native bool
			var native_borders = borders ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_RenderFrameEx(p_min, p_max, fill_col, native_borders, rounding);
		}

		/// <summary>
		/// Implied rounding = 0.0f
		/// </summary>
		public static void RenderFrameBorder(Vector2 p_min, Vector2 p_max)
		{
			ImGuiInternalNative.ImGui_RenderFrameBorder(p_min, p_max);
		}

		/// <summary>
		/// Implied rounding = 0.0f
		/// </summary>
		public static void RenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding)
		{
			ImGuiInternalNative.ImGui_RenderFrameBorderEx(p_min, p_max, rounding);
		}

		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off)
		{
			ImGuiInternalNative.ImGui_RenderColorRectWithAlphaCheckerboard(draw_list, p_min, p_max, fill_col, grid_step, grid_off);
		}

		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding)
		{
			ImDrawFlags flags = (ImDrawFlags)0;

			ImGuiInternalNative.ImGui_RenderColorRectWithAlphaCheckerboardEx(draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
		}
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags)
		{
			ImGuiInternalNative.ImGui_RenderColorRectWithAlphaCheckerboardEx(draw_list, p_min, p_max, fill_col, grid_step, grid_off, rounding, flags);
		}

		/// <summary>
		/// Implied flags = ImGuiNavRenderCursorFlags_None
		/// </summary>
		public static void RenderNavCursor(ImRect bb, uint id)
		{
			ImGuiInternalNative.ImGui_RenderNavCursor(bb, id);
		}

		/// <summary>
		/// Implied flags = ImGuiNavRenderCursorFlags_None
		/// </summary>
		public static void RenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags)
		{
			ImGuiInternalNative.ImGui_RenderNavCursorEx(bb, id, flags);
		}

		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public static string FindRenderedTextEnd(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			var ret = ImGuiInternalNative.ImGui_FindRenderedTextEnd(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return Util.StringFromPtr(ret);
		}

		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		public static string FindRenderedTextEnd(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			var ret = ImGuiInternalNative.ImGui_FindRenderedTextEndEx(native_text, native_text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return Util.StringFromPtr(ret);
		}

		public static void RenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow)
		{
			ImGuiInternalNative.ImGui_RenderMouseCursor(pos, scale, mouse_cursor, col_fill, col_border, col_shadow);
		}

		/// <summary>
		/// <para>Render helpers (those functions don't access any ImGui state!)</para>
		/// </summary>
		/// <summary>
		/// Implied scale = 1.0f
		/// </summary>
		public static void RenderArrow(ImDrawListPtr draw_list, Vector2 pos, uint col, ImGuiDir dir)
		{
			ImGuiInternalNative.ImGui_RenderArrow(draw_list, pos, col, dir);
		}

		/// <summary>
		/// <para>Render helpers (those functions don't access any ImGui state!)</para>
		/// </summary>
		/// <summary>
		/// Implied scale = 1.0f
		/// </summary>
		public static void RenderArrow(ImDrawListPtr draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale)
		{
			ImGuiInternalNative.ImGui_RenderArrowEx(draw_list, pos, col, dir, scale);
		}

		public static void RenderBullet(ImDrawListPtr draw_list, Vector2 pos, uint col)
		{
			ImGuiInternalNative.ImGui_RenderBullet(draw_list, pos, col);
		}

		public static void RenderCheckMark(ImDrawListPtr draw_list, Vector2 pos, uint col, float sz)
		{
			ImGuiInternalNative.ImGui_RenderCheckMark(draw_list, pos, col, sz);
		}

		public static void RenderArrowPointingAt(ImDrawListPtr draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col)
		{
			ImGuiInternalNative.ImGui_RenderArrowPointingAt(draw_list, pos, half_sz, direction, col);
		}

		public static void RenderArrowDockMenu(ImDrawListPtr draw_list, Vector2 p_min, float sz, uint col)
		{
			ImGuiInternalNative.ImGui_RenderArrowDockMenu(draw_list, p_min, sz, col);
		}

		public static void RenderRectFilledRangeH(ImDrawListPtr draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding)
		{
			ImGuiInternalNative.ImGui_RenderRectFilledRangeH(draw_list, rect, col, x_start_norm, x_end_norm, rounding);
		}

		public static void RenderRectFilledWithHole(ImDrawListPtr draw_list, ImRect outer, ImRect inner, uint col, float rounding)
		{
			ImGuiInternalNative.ImGui_RenderRectFilledWithHole(draw_list, outer, inner, col, rounding);
		}

		public static ImDrawFlags CalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold)
		{
			var ret = ImGuiInternalNative.ImGui_CalcRoundingFlagsForRectInRect(r_in, r_outer, threshold);
			return ret;
		}

		/// <summary>
		/// <para>Widgets</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, flags = 0
		/// </summary>
		public static void Text(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			ImGuiInternalNative.ImGui_TextEx(native_text);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}

		public static void TextEx(ReadOnlySpan<char> text)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			byte* text_end = null;

			ImGuiTextFlags flags = (ImGuiTextFlags)0;

			ImGuiInternalNative.ImGui_TextExEx(native_text, text_end, flags);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
		}
		public static void TextEx(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImGuiTextFlags flags = (ImGuiTextFlags)0;

			ImGuiInternalNative.ImGui_TextExEx(native_text, native_text_end, flags);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}
		public static void TextEx(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end, ImGuiTextFlags flags)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			// Marshaling 'text_end' to native string
			byte* native_text_end;
			var text_end_byteCount = 0;
			if (text_end != null)
			{
				text_end_byteCount = Encoding.UTF8.GetByteCount(text_end);
				if (text_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text_end = Util.Allocate(text_end_byteCount + 1);
				}
				else
				{
					var native_text_end_stackBytes = stackalloc byte[text_end_byteCount + 1];
					native_text_end = native_text_end_stackBytes;
				}
				var text_end_offset = Util.GetUtf8(text_end, native_text_end, text_end_byteCount);
				native_text_end[text_end_offset] = 0;
			}
			else native_text_end = null;

			ImGuiInternalNative.ImGui_TextExEx(native_text, native_text_end, flags);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
		}

		/// <summary>
		/// Implied size_arg = ImVec2(0, 0), flags = 0
		/// </summary>
		public static bool ButtonWithFlags(ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiInternalNative.ImGui_ButtonWithFlags(native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied size_arg = ImVec2(0, 0), flags = 0
		/// </summary>
		public static bool ButtonWithFlags(ReadOnlySpan<char> label, Vector2 size_arg)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiButtonFlags flags = (ImGuiButtonFlags)0;

			var ret = ImGuiInternalNative.ImGui_ButtonWithFlagsEx(native_label, size_arg, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied size_arg = ImVec2(0, 0), flags = 0
		/// </summary>
		public static bool ButtonWithFlags(ReadOnlySpan<char> label, Vector2 size_arg, ImGuiButtonFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiInternalNative.ImGui_ButtonWithFlagsEx(native_label, size_arg, flags);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		public static bool ArrowButton(ReadOnlySpan<char> str_id, ImGuiDir dir, Vector2 size_arg)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			ImGuiButtonFlags flags = (ImGuiButtonFlags)0;

			var ret = ImGuiInternalNative.ImGui_ArrowButtonEx(native_str_id, dir, size_arg, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}
		public static bool ArrowButton(ReadOnlySpan<char> str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags)
		{
			// Marshaling 'str_id' to native string
			byte* native_str_id;
			var str_id_byteCount = 0;
			if (str_id != null)
			{
				str_id_byteCount = Encoding.UTF8.GetByteCount(str_id);
				if (str_id_byteCount > Util.StackAllocationSizeLimit)
				{
					native_str_id = Util.Allocate(str_id_byteCount + 1);
				}
				else
				{
					var native_str_id_stackBytes = stackalloc byte[str_id_byteCount + 1];
					native_str_id = native_str_id_stackBytes;
				}
				var str_id_offset = Util.GetUtf8(str_id, native_str_id, str_id_byteCount);
				native_str_id[str_id_offset] = 0;
			}
			else native_str_id = null;

			var ret = ImGuiInternalNative.ImGui_ArrowButtonEx(native_str_id, dir, size_arg, flags);
			if (str_id_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_str_id);
			}
			return ret != 0;
		}

		public static bool ImageButtonWithFlags(uint id, IntPtr texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col)
		{
			ImGuiButtonFlags flags = (ImGuiButtonFlags)0;

			var ret = ImGuiInternalNative.ImGui_ImageButtonWithFlags(id, texture_id, image_size, uv0, uv1, bg_col, tint_col, flags);
			return ret != 0;
		}
		public static bool ImageButtonWithFlags(uint id, IntPtr texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col, ImGuiButtonFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_ImageButtonWithFlags(id, texture_id, image_size, uv0, uv1, bg_col, tint_col, flags);
			return ret != 0;
		}

		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		public static void Separator(ImGuiSeparatorFlags flags)
		{
			ImGuiInternalNative.ImGui_SeparatorEx(flags);
		}

		public static void SeparatorEx(ImGuiSeparatorFlags flags)
		{
			float thickness = 1.0f;

			ImGuiInternalNative.ImGui_SeparatorExEx(flags, thickness);
		}
		public static void SeparatorEx(ImGuiSeparatorFlags flags, float thickness)
		{
			ImGuiInternalNative.ImGui_SeparatorExEx(flags, thickness);
		}

		public static void SeparatorText(uint id, ReadOnlySpan<char> label, ReadOnlySpan<char> label_end, float extra_width)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'label_end' to native string
			byte* native_label_end;
			var label_end_byteCount = 0;
			if (label_end != null)
			{
				label_end_byteCount = Encoding.UTF8.GetByteCount(label_end);
				if (label_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label_end = Util.Allocate(label_end_byteCount + 1);
				}
				else
				{
					var native_label_end_stackBytes = stackalloc byte[label_end_byteCount + 1];
					native_label_end = native_label_end_stackBytes;
				}
				var label_end_offset = Util.GetUtf8(label_end, native_label_end, label_end_byteCount);
				native_label_end[label_end_offset] = 0;
			}
			else native_label_end = null;

			ImGuiInternalNative.ImGui_SeparatorTextEx(id, native_label, native_label_end, extra_width);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (label_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label_end);
			}
		}

		public static bool CheckboxFlagsImS64Ptr(ReadOnlySpan<char> label, ref long flags, long flags_value)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (long* native_flags = &flags)
			{
				var ret = ImGuiInternalNative.ImGui_CheckboxFlagsImS64Ptr(native_label, native_flags, flags_value);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		public static bool CheckboxFlagsImU64Ptr(ReadOnlySpan<char> label, ref ulong flags, ulong flags_value)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (ulong* native_flags = &flags)
			{
				var ret = ImGuiInternalNative.ImGui_CheckboxFlagsImU64Ptr(native_label, native_flags, flags_value);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// <para>Widgets: Window Decorations</para>
		/// </summary>
		public static bool CloseButton(uint id, Vector2 pos)
		{
			var ret = ImGuiInternalNative.ImGui_CloseButton(id, pos);
			return ret != 0;
		}

		public static bool CollapseButton(uint id, Vector2 pos, ImGuiDockNodePtr dock_node)
		{
			var ret = ImGuiInternalNative.ImGui_CollapseButton(id, pos, dock_node);
			return ret != 0;
		}

		public static void Scrollbar(ImGuiAxis axis)
		{
			ImGuiInternalNative.ImGui_Scrollbar(axis);
		}

		public static bool Scrollbar(ImRect bb, uint id, ImGuiAxis axis, ref long p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags)
		{
			fixed (long* native_p_scroll_v = &p_scroll_v)
			{
				var ret = ImGuiInternalNative.ImGui_ScrollbarEx(bb, id, axis, native_p_scroll_v, avail_v, contents_v, flags);
				return ret != 0;
			}
		}

		public static ImRect GetWindowScrollbarRect(ImGuiWindowPtr window, ImGuiAxis axis)
		{
			var ret = ImGuiInternalNative.ImGui_GetWindowScrollbarRect(window, axis);
			return ret;
		}

		public static uint GetWindowScrollbarID(ImGuiWindowPtr window, ImGuiAxis axis)
		{
			var ret = ImGuiInternalNative.ImGui_GetWindowScrollbarID(window, axis);
			return ret;
		}

		/// <summary>
		/// 0..3: corners
		/// </summary>
		public static uint GetWindowResizeCornerID(ImGuiWindowPtr window, int n)
		{
			var ret = ImGuiInternalNative.ImGui_GetWindowResizeCornerID(window, n);
			return ret;
		}

		public static uint GetWindowResizeBorderID(ImGuiWindowPtr window, ImGuiDir dir)
		{
			var ret = ImGuiInternalNative.ImGui_GetWindowResizeBorderID(window, dir);
			return ret;
		}

		/// <summary>
		/// <para>Widgets low-level behaviors</para>
		/// </summary>
		public static bool ButtonBehavior(ImRect bb, uint id, ref bool out_hovered, ref bool out_held)
		{
			// Marshaling 'out_hovered' to native bool
			var native_out_hovered_val = out_hovered ? (byte)1 : (byte)0;
			var native_out_hovered = &native_out_hovered_val;

			// Marshaling 'out_held' to native bool
			var native_out_held_val = out_held ? (byte)1 : (byte)0;
			var native_out_held = &native_out_held_val;

			ImGuiButtonFlags flags = (ImGuiButtonFlags)0;

			var ret = ImGuiInternalNative.ImGui_ButtonBehavior(bb, id, native_out_hovered, native_out_held, flags);
			out_hovered = native_out_hovered_val != 0;
			out_held = native_out_held_val != 0;
			return ret != 0;
		}
		/// <summary>
		/// <para>Widgets low-level behaviors</para>
		/// </summary>
		public static bool ButtonBehavior(ImRect bb, uint id, ref bool out_hovered, ref bool out_held, ImGuiButtonFlags flags)
		{
			// Marshaling 'out_hovered' to native bool
			var native_out_hovered_val = out_hovered ? (byte)1 : (byte)0;
			var native_out_hovered = &native_out_hovered_val;

			// Marshaling 'out_held' to native bool
			var native_out_held_val = out_held ? (byte)1 : (byte)0;
			var native_out_held = &native_out_held_val;

			var ret = ImGuiInternalNative.ImGui_ButtonBehavior(bb, id, native_out_hovered, native_out_held, flags);
			out_hovered = native_out_hovered_val != 0;
			out_held = native_out_held_val != 0;
			return ret != 0;
		}

		public static bool DragBehavior(uint id, ImGuiDataType data_type, IntPtr p_v, float v_speed, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags)
		{
			// Marshaling 'p_v' to native void pointer
			var native_p_v = p_v.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiInternalNative.ImGui_DragBehavior(id, data_type, native_p_v, v_speed, native_p_min, native_p_max, native_format, flags);
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		public static bool SliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, IntPtr p_v, IntPtr p_min, IntPtr p_max, ReadOnlySpan<char> format, ImGuiSliderFlags flags, ImRectPtr out_grab_bb)
		{
			// Marshaling 'p_v' to native void pointer
			var native_p_v = p_v.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiInternalNative.ImGui_SliderBehavior(bb, id, data_type, native_p_v, native_p_min, native_p_max, native_format, flags, out_grab_bb);
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied hover_extend = 0.0f, hover_visibility_delay = 0.0f, bg_col = 0
		/// </summary>
		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2)
		{
			fixed (float* native_size1 = &size1)
			fixed (float* native_size2 = &size2)
			{
				var ret = ImGuiInternalNative.ImGui_SplitterBehavior(bb, id, axis, native_size1, native_size2, min_size1, min_size2);
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied hover_extend = 0.0f, hover_visibility_delay = 0.0f, bg_col = 0
		/// </summary>
		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend)
		{
			float hover_visibility_delay = 0.0f;

			uint bg_col = 0;

			fixed (float* native_size1 = &size1)
			fixed (float* native_size2 = &size2)
			{
				var ret = ImGuiInternalNative.ImGui_SplitterBehaviorEx(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied hover_extend = 0.0f, hover_visibility_delay = 0.0f, bg_col = 0
		/// </summary>
		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay)
		{
			uint bg_col = 0;

			fixed (float* native_size1 = &size1)
			fixed (float* native_size2 = &size2)
			{
				var ret = ImGuiInternalNative.ImGui_SplitterBehaviorEx(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
				return ret != 0;
			}
		}
		/// <summary>
		/// Implied hover_extend = 0.0f, hover_visibility_delay = 0.0f, bg_col = 0
		/// </summary>
		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col)
		{
			fixed (float* native_size1 = &size1)
			fixed (float* native_size2 = &size2)
			{
				var ret = ImGuiInternalNative.ImGui_SplitterBehaviorEx(bb, id, axis, native_size1, native_size2, min_size1, min_size2, hover_extend, hover_visibility_delay, bg_col);
				return ret != 0;
			}
		}

		/// <summary>
		/// <para>Widgets: Tree Nodes</para>
		/// </summary>
		/// <summary>
		/// Implied label_end = NULL
		/// </summary>
		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			var ret = ImGuiInternalNative.ImGui_TreeNodeBehavior(id, flags, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		/// <summary>
		/// <para>Widgets: Tree Nodes</para>
		/// </summary>
		/// <summary>
		/// Implied label_end = NULL
		/// </summary>
		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<char> label, ReadOnlySpan<char> label_end)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'label_end' to native string
			byte* native_label_end;
			var label_end_byteCount = 0;
			if (label_end != null)
			{
				label_end_byteCount = Encoding.UTF8.GetByteCount(label_end);
				if (label_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label_end = Util.Allocate(label_end_byteCount + 1);
				}
				else
				{
					var native_label_end_stackBytes = stackalloc byte[label_end_byteCount + 1];
					native_label_end = native_label_end_stackBytes;
				}
				var label_end_offset = Util.GetUtf8(label_end, native_label_end, label_end_byteCount);
				native_label_end[label_end_offset] = 0;
			}
			else native_label_end = null;

			var ret = ImGuiInternalNative.ImGui_TreeNodeBehaviorEx(id, flags, native_label, native_label_end);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (label_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label_end);
			}
			return ret != 0;
		}

		public static void TreePushOverrideID(uint id)
		{
			ImGuiInternalNative.ImGui_TreePushOverrideID(id);
		}

		public static bool TreeNodeGetOpen(uint storage_id)
		{
			var ret = ImGuiInternalNative.ImGui_TreeNodeGetOpen(storage_id);
			return ret != 0;
		}

		public static void TreeNodeSetOpen(uint storage_id, bool open)
		{
			// Marshaling 'open' to native bool
			var native_open = open ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_TreeNodeSetOpen(storage_id, native_open);
		}

		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.
		/// </summary>
		public static bool TreeNodeUpdateNextOpen(uint storage_id, ImGuiTreeNodeFlags flags)
		{
			var ret = ImGuiInternalNative.ImGui_TreeNodeUpdateNextOpen(storage_id, flags);
			return ret != 0;
		}

		/// <summary>
		/// <para>Data type helpers</para>
		/// </summary>
		public static ImGuiDataTypeInfoPtr DataTypeGetInfo(ImGuiDataType data_type)
		{
			var ret = ImGuiInternalNative.ImGui_DataTypeGetInfo(data_type);
			return ret;
		}

		public static int DataTypeFormatString(byte[] buf, int buf_size, ImGuiDataType data_type, IntPtr p_data, ReadOnlySpan<char> format)
		{
			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiInternalNative.ImGui_DataTypeFormatString(native_buf, buf_size, data_type, native_p_data, native_format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_format);
				}
				return ret;
			}
		}

		public static void DataTypeApplyOp(ImGuiDataType data_type, int op, IntPtr output, IntPtr arg_1, IntPtr arg_2)
		{
			// Marshaling 'output' to native void pointer
			var native_output = output.ToPointer();

			// Marshaling 'arg_1' to native void pointer
			var native_arg_1 = arg_1.ToPointer();

			// Marshaling 'arg_2' to native void pointer
			var native_arg_2 = arg_2.ToPointer();

			ImGuiInternalNative.ImGui_DataTypeApplyOp(data_type, op, native_output, native_arg_1, native_arg_2);
		}

		/// <summary>
		/// Implied p_data_when_empty = NULL
		/// </summary>
		public static bool DataTypeApplyFromText(ReadOnlySpan<char> buf, ImGuiDataType data_type, IntPtr p_data, ReadOnlySpan<char> format)
		{
			// Marshaling 'buf' to native string
			byte* native_buf;
			var buf_byteCount = 0;
			if (buf != null)
			{
				buf_byteCount = Encoding.UTF8.GetByteCount(buf);
				if (buf_byteCount > Util.StackAllocationSizeLimit)
				{
					native_buf = Util.Allocate(buf_byteCount + 1);
				}
				else
				{
					var native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
					native_buf = native_buf_stackBytes;
				}
				var buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiInternalNative.ImGui_DataTypeApplyFromText(native_buf, data_type, native_p_data, native_format);
			if (buf_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_buf);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied p_data_when_empty = NULL
		/// </summary>
		public static bool DataTypeApplyFromText(ReadOnlySpan<char> buf, ImGuiDataType data_type, IntPtr p_data, ReadOnlySpan<char> format, IntPtr p_data_when_empty)
		{
			// Marshaling 'buf' to native string
			byte* native_buf;
			var buf_byteCount = 0;
			if (buf != null)
			{
				buf_byteCount = Encoding.UTF8.GetByteCount(buf);
				if (buf_byteCount > Util.StackAllocationSizeLimit)
				{
					native_buf = Util.Allocate(buf_byteCount + 1);
				}
				else
				{
					var native_buf_stackBytes = stackalloc byte[buf_byteCount + 1];
					native_buf = native_buf_stackBytes;
				}
				var buf_offset = Util.GetUtf8(buf, native_buf, buf_byteCount);
				native_buf[buf_offset] = 0;
			}
			else native_buf = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'p_data_when_empty' to native void pointer
			var native_p_data_when_empty = p_data_when_empty.ToPointer();

			var ret = ImGuiInternalNative.ImGui_DataTypeApplyFromTextEx(native_buf, data_type, native_p_data, native_format, native_p_data_when_empty);
			if (buf_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_buf);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		public static int DataTypeCompare(ImGuiDataType data_type, IntPtr arg_1, IntPtr arg_2)
		{
			// Marshaling 'arg_1' to native void pointer
			var native_arg_1 = arg_1.ToPointer();

			// Marshaling 'arg_2' to native void pointer
			var native_arg_2 = arg_2.ToPointer();

			var ret = ImGuiInternalNative.ImGui_DataTypeCompare(data_type, native_arg_1, native_arg_2);
			return ret;
		}

		public static bool DataTypeClamp(ImGuiDataType data_type, IntPtr p_data, IntPtr p_min, IntPtr p_max)
		{
			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'p_min' to native void pointer
			var native_p_min = p_min.ToPointer();

			// Marshaling 'p_max' to native void pointer
			var native_p_max = p_max.ToPointer();

			var ret = ImGuiInternalNative.ImGui_DataTypeClamp(data_type, native_p_data, native_p_min, native_p_max);
			return ret != 0;
		}

		public static bool DataTypeIsZero(ImGuiDataType data_type, IntPtr p_data)
		{
			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			var ret = ImGuiInternalNative.ImGui_DataTypeIsZero(data_type, native_p_data);
			return ret != 0;
		}

		/// <summary>
		/// <para>InputText</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHintAndSize(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiInternalNative.ImGui_InputTextWithHintAndSize(native_label, native_hint, native_buf, buf_size, size_arg, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// <para>InputText</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHintAndSize(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			void* user_data = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiInternalNative.ImGui_InputTextWithHintAndSizeEx(native_label, native_hint, native_buf, buf_size, size_arg, flags, callback, user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}
		/// <summary>
		/// <para>InputText</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		public static bool InputTextWithHintAndSize(ReadOnlySpan<char> label, ReadOnlySpan<char> hint, byte[] buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr user_data)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'hint' to native string
			byte* native_hint;
			var hint_byteCount = 0;
			if (hint != null)
			{
				hint_byteCount = Encoding.UTF8.GetByteCount(hint);
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					native_hint = Util.Allocate(hint_byteCount + 1);
				}
				else
				{
					var native_hint_stackBytes = stackalloc byte[hint_byteCount + 1];
					native_hint = native_hint_stackBytes;
				}
				var hint_offset = Util.GetUtf8(hint, native_hint, hint_byteCount);
				native_hint[hint_offset] = 0;
			}
			else native_hint = null;

			// Marshaling 'user_data' to native void pointer
			var native_user_data = user_data.ToPointer();

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiInternalNative.ImGui_InputTextWithHintAndSizeEx(native_label, native_hint, native_buf, buf_size, size_arg, flags, callback, native_user_data);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				if (hint_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_hint);
				}
				return ret != 0;
			}
		}

		public static void InputTextDeactivateHook(uint id)
		{
			ImGuiInternalNative.ImGui_InputTextDeactivateHook(id);
		}

		public static bool TempInputText(ImRect bb, uint id, ReadOnlySpan<char> label, byte[] buf, int buf_size, ImGuiInputTextFlags flags)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			fixed (byte* native_buf = buf)
			{
				var ret = ImGuiInternalNative.ImGui_TempInputText(bb, id, native_label, native_buf, buf_size, flags);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_label);
				}
				return ret != 0;
			}
		}

		/// <summary>
		/// Implied p_clamp_min = NULL, p_clamp_max = NULL
		/// </summary>
		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, ReadOnlySpan<char> format)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			var ret = ImGuiInternalNative.ImGui_TempInputScalar(bb, id, native_label, data_type, native_p_data, native_format);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		/// <summary>
		/// Implied p_clamp_min = NULL, p_clamp_max = NULL
		/// </summary>
		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, ReadOnlySpan<char> format, IntPtr p_clamp_min)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'p_clamp_min' to native void pointer
			var native_p_clamp_min = p_clamp_min.ToPointer();

			void* p_clamp_max = null;

			var ret = ImGuiInternalNative.ImGui_TempInputScalarEx(bb, id, native_label, data_type, native_p_data, native_format, native_p_clamp_min, p_clamp_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}
		/// <summary>
		/// Implied p_clamp_min = NULL, p_clamp_max = NULL
		/// </summary>
		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<char> label, ImGuiDataType data_type, IntPtr p_data, ReadOnlySpan<char> format, IntPtr p_clamp_min, IntPtr p_clamp_max)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			// Marshaling 'format' to native string
			byte* native_format;
			var format_byteCount = 0;
			if (format != null)
			{
				format_byteCount = Encoding.UTF8.GetByteCount(format);
				if (format_byteCount > Util.StackAllocationSizeLimit)
				{
					native_format = Util.Allocate(format_byteCount + 1);
				}
				else
				{
					var native_format_stackBytes = stackalloc byte[format_byteCount + 1];
					native_format = native_format_stackBytes;
				}
				var format_offset = Util.GetUtf8(format, native_format, format_byteCount);
				native_format[format_offset] = 0;
			}
			else native_format = null;

			// Marshaling 'p_clamp_min' to native void pointer
			var native_p_clamp_min = p_clamp_min.ToPointer();

			// Marshaling 'p_clamp_max' to native void pointer
			var native_p_clamp_max = p_clamp_max.ToPointer();

			var ret = ImGuiInternalNative.ImGui_TempInputScalarEx(bb, id, native_label, data_type, native_p_data, native_format, native_p_clamp_min, native_p_clamp_max);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (format_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_format);
			}
			return ret != 0;
		}

		public static bool TempInputIsActive(uint id)
		{
			var ret = ImGuiInternalNative.ImGui_TempInputIsActive(id);
			return ret != 0;
		}

		public static void SetNextItemRefVal(ImGuiDataType data_type, IntPtr p_data)
		{
			// Marshaling 'p_data' to native void pointer
			var native_p_data = p_data.ToPointer();

			ImGuiInternalNative.ImGui_SetNextItemRefVal(data_type, native_p_data);
		}

		/// <summary>
		/// <para>Color</para>
		/// </summary>
		public static void ColorTooltip(ReadOnlySpan<char> text, float[] col, ImGuiColorEditFlags flags)
		{
			// Marshaling 'text' to native string
			byte* native_text;
			var text_byteCount = 0;
			if (text != null)
			{
				text_byteCount = Encoding.UTF8.GetByteCount(text);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_text = Util.Allocate(text_byteCount + 1);
				}
				else
				{
					var native_text_stackBytes = stackalloc byte[text_byteCount + 1];
					native_text = native_text_stackBytes;
				}
				var text_offset = Util.GetUtf8(text, native_text, text_byteCount);
				native_text[text_offset] = 0;
			}
			else native_text = null;

			fixed (float* native_col = col)
			{
				ImGuiInternalNative.ImGui_ColorTooltip(native_text, native_col, flags);
				if (text_byteCount > Util.StackAllocationSizeLimit)
				{
					Util.Free(native_text);
				}
			}
		}

		public static void ColorEditOptionsPopup(float[] col, ImGuiColorEditFlags flags)
		{
			fixed (float* native_col = col)
			{
				ImGuiInternalNative.ImGui_ColorEditOptionsPopup(native_col, flags);
			}
		}

		public static void ColorPickerOptionsPopup(float[] ref_col, ImGuiColorEditFlags flags)
		{
			fixed (float* native_ref_col = ref_col)
			{
				ImGuiInternalNative.ImGui_ColorPickerOptionsPopup(native_ref_col, flags);
			}
		}

		/// <summary>
		/// <para>Plot</para>
		/// </summary>
		public static int Plot(ImGuiPlotType plot_type, ReadOnlySpan<char> label, ImGui_PlotExvalues_getterDelegate values_getter, IntPtr data, int values_count, int values_offset, ReadOnlySpan<char> overlay_text, float scale_min, float scale_max, Vector2 size_arg)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'data' to native void pointer
			var native_data = data.ToPointer();

			// Marshaling 'overlay_text' to native string
			byte* native_overlay_text;
			var overlay_text_byteCount = 0;
			if (overlay_text != null)
			{
				overlay_text_byteCount = Encoding.UTF8.GetByteCount(overlay_text);
				if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
				{
					native_overlay_text = Util.Allocate(overlay_text_byteCount + 1);
				}
				else
				{
					var native_overlay_text_stackBytes = stackalloc byte[overlay_text_byteCount + 1];
					native_overlay_text = native_overlay_text_stackBytes;
				}
				var overlay_text_offset = Util.GetUtf8(overlay_text, native_overlay_text, overlay_text_byteCount);
				native_overlay_text[overlay_text_offset] = 0;
			}
			else native_overlay_text = null;

			var ret = ImGuiInternalNative.ImGui_PlotEx(plot_type, native_label, values_getter, native_data, values_count, values_offset, native_overlay_text, scale_min, scale_max, size_arg);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (overlay_text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_overlay_text);
			}
			return ret;
		}

		/// <summary>
		/// <para>Shade functions (write over already created vertices)</para>
		/// </summary>
		public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1)
		{
			ImGuiInternalNative.ImGui_ShadeVertsLinearColorGradientKeepAlpha(draw_list, vert_start_idx, vert_end_idx, gradient_p0, gradient_p1, col0, col1);
		}

		public static void ShadeVertsLinearUV(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, bool clamp)
		{
			// Marshaling 'clamp' to native bool
			var native_clamp = clamp ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_ShadeVertsLinearUV(draw_list, vert_start_idx, vert_end_idx, a, b, uv_a, uv_b, native_clamp);
		}

		public static void ShadeVertsTransformPos(ImDrawListPtr draw_list, int vert_start_idx, int vert_end_idx, Vector2 pivot_in, float cos_a, float sin_a, Vector2 pivot_out)
		{
			ImGuiInternalNative.ImGui_ShadeVertsTransformPos(draw_list, vert_start_idx, vert_end_idx, pivot_in, cos_a, sin_a, pivot_out);
		}

		/// <summary>
		/// <para>Garbage collection</para>
		/// </summary>
		public static void GcCompactTransientMiscBuffers()
		{
			ImGuiInternalNative.ImGui_GcCompactTransientMiscBuffers();
		}

		public static void GcCompactTransientWindowBuffers(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_GcCompactTransientWindowBuffers(window);
		}

		public static void GcAwakeTransientWindowBuffers(ImGuiWindowPtr window)
		{
			ImGuiInternalNative.ImGui_GcAwakeTransientWindowBuffers(window);
		}

		/// <summary>
		/// <para>Error handling, State Recovery</para>
		/// </summary>
		public static bool ErrorLog(ReadOnlySpan<char> msg)
		{
			// Marshaling 'msg' to native string
			byte* native_msg;
			var msg_byteCount = 0;
			if (msg != null)
			{
				msg_byteCount = Encoding.UTF8.GetByteCount(msg);
				if (msg_byteCount > Util.StackAllocationSizeLimit)
				{
					native_msg = Util.Allocate(msg_byteCount + 1);
				}
				else
				{
					var native_msg_stackBytes = stackalloc byte[msg_byteCount + 1];
					native_msg = native_msg_stackBytes;
				}
				var msg_offset = Util.GetUtf8(msg, native_msg, msg_byteCount);
				native_msg[msg_offset] = 0;
			}
			else native_msg = null;

			var ret = ImGuiInternalNative.ImGui_ErrorLog(native_msg);
			if (msg_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_msg);
			}
			return ret != 0;
		}

		public static void ErrorRecoveryStoreState(ImGuiErrorRecoveryStatePtr state_out)
		{
			ImGuiInternalNative.ImGui_ErrorRecoveryStoreState(state_out);
		}

		public static void ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryStatePtr state_in)
		{
			ImGuiInternalNative.ImGui_ErrorRecoveryTryToRecoverState(state_in);
		}

		public static void ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryStatePtr state_in)
		{
			ImGuiInternalNative.ImGui_ErrorRecoveryTryToRecoverWindowState(state_in);
		}

		public static void ErrorCheckUsingSetCursorPosToExtendParentBoundaries()
		{
			ImGuiInternalNative.ImGui_ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		}

		public static void ErrorCheckEndFrameFinalizeErrorTooltip()
		{
			ImGuiInternalNative.ImGui_ErrorCheckEndFrameFinalizeErrorTooltip();
		}

		public static bool BeginErrorTooltip()
		{
			var ret = ImGuiInternalNative.ImGui_BeginErrorTooltip();
			return ret != 0;
		}

		public static void EndErrorTooltip()
		{
			ImGuiInternalNative.ImGui_EndErrorTooltip();
		}

		/// <summary>
		/// <para>Debug Tools</para>
		/// </summary>
		/// <summary>
		/// size &gt;= 0 : alloc, size = -1 : free
		/// </summary>
		public static void DebugAllocHook(ImGuiDebugAllocInfoPtr info, int frame_count, IntPtr ptr, uint size)
		{
			// Marshaling 'ptr' to native void pointer
			var native_ptr = ptr.ToPointer();

			ImGuiInternalNative.ImGui_DebugAllocHook(info, frame_count, native_ptr, size);
		}

		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		public static void DebugDrawCursorPos()
		{
			ImGuiInternalNative.ImGui_DebugDrawCursorPos();
		}

		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		public static void DebugDrawCursorPos(uint col)
		{
			ImGuiInternalNative.ImGui_DebugDrawCursorPosEx(col);
		}

		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		public static void DebugDrawLineExtents()
		{
			ImGuiInternalNative.ImGui_DebugDrawLineExtents();
		}

		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		public static void DebugDrawLineExtents(uint col)
		{
			ImGuiInternalNative.ImGui_DebugDrawLineExtentsEx(col);
		}

		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		public static void DebugDrawItemRect()
		{
			ImGuiInternalNative.ImGui_DebugDrawItemRect();
		}

		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		public static void DebugDrawItemRect(uint col)
		{
			ImGuiInternalNative.ImGui_DebugDrawItemRectEx(col);
		}

		public static void DebugTextUnformattedWithLocateItem(ReadOnlySpan<char> line_begin, ReadOnlySpan<char> line_end)
		{
			// Marshaling 'line_begin' to native string
			byte* native_line_begin;
			var line_begin_byteCount = 0;
			if (line_begin != null)
			{
				line_begin_byteCount = Encoding.UTF8.GetByteCount(line_begin);
				if (line_begin_byteCount > Util.StackAllocationSizeLimit)
				{
					native_line_begin = Util.Allocate(line_begin_byteCount + 1);
				}
				else
				{
					var native_line_begin_stackBytes = stackalloc byte[line_begin_byteCount + 1];
					native_line_begin = native_line_begin_stackBytes;
				}
				var line_begin_offset = Util.GetUtf8(line_begin, native_line_begin, line_begin_byteCount);
				native_line_begin[line_begin_offset] = 0;
			}
			else native_line_begin = null;

			// Marshaling 'line_end' to native string
			byte* native_line_end;
			var line_end_byteCount = 0;
			if (line_end != null)
			{
				line_end_byteCount = Encoding.UTF8.GetByteCount(line_end);
				if (line_end_byteCount > Util.StackAllocationSizeLimit)
				{
					native_line_end = Util.Allocate(line_end_byteCount + 1);
				}
				else
				{
					var native_line_end_stackBytes = stackalloc byte[line_end_byteCount + 1];
					native_line_end = native_line_end_stackBytes;
				}
				var line_end_offset = Util.GetUtf8(line_end, native_line_end, line_end_byteCount);
				native_line_end[line_end_offset] = 0;
			}
			else native_line_end = null;

			ImGuiInternalNative.ImGui_DebugTextUnformattedWithLocateItem(native_line_begin, native_line_end);
			if (line_begin_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_line_begin);
			}
			if (line_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_line_end);
			}
		}

		/// <summary>
		/// Call sparingly: only 1 at the same time!
		/// </summary>
		public static void DebugLocateItem(uint target_id)
		{
			ImGuiInternalNative.ImGui_DebugLocateItem(target_id);
		}

		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!
		/// </summary>
		public static void DebugLocateItemOnHover(uint target_id)
		{
			ImGuiInternalNative.ImGui_DebugLocateItemOnHover(target_id);
		}

		public static void DebugLocateItemResolveWithLastItem()
		{
			ImGuiInternalNative.ImGui_DebugLocateItemResolveWithLastItem();
		}

		public static void DebugBreakClearData()
		{
			ImGuiInternalNative.ImGui_DebugBreakClearData();
		}

		public static bool DebugBreakButton(ReadOnlySpan<char> label, ReadOnlySpan<char> description_of_location)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			// Marshaling 'description_of_location' to native string
			byte* native_description_of_location;
			var description_of_location_byteCount = 0;
			if (description_of_location != null)
			{
				description_of_location_byteCount = Encoding.UTF8.GetByteCount(description_of_location);
				if (description_of_location_byteCount > Util.StackAllocationSizeLimit)
				{
					native_description_of_location = Util.Allocate(description_of_location_byteCount + 1);
				}
				else
				{
					var native_description_of_location_stackBytes = stackalloc byte[description_of_location_byteCount + 1];
					native_description_of_location = native_description_of_location_stackBytes;
				}
				var description_of_location_offset = Util.GetUtf8(description_of_location, native_description_of_location, description_of_location_byteCount);
				native_description_of_location[description_of_location_offset] = 0;
			}
			else native_description_of_location = null;

			var ret = ImGuiInternalNative.ImGui_DebugBreakButton(native_label, native_description_of_location);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			if (description_of_location_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_description_of_location);
			}
			return ret != 0;
		}

		public static void DebugBreakButtonTooltip(bool keyboard_only, ReadOnlySpan<char> description_of_location)
		{
			// Marshaling 'keyboard_only' to native bool
			var native_keyboard_only = keyboard_only ? (byte)1 : (byte)0;

			// Marshaling 'description_of_location' to native string
			byte* native_description_of_location;
			var description_of_location_byteCount = 0;
			if (description_of_location != null)
			{
				description_of_location_byteCount = Encoding.UTF8.GetByteCount(description_of_location);
				if (description_of_location_byteCount > Util.StackAllocationSizeLimit)
				{
					native_description_of_location = Util.Allocate(description_of_location_byteCount + 1);
				}
				else
				{
					var native_description_of_location_stackBytes = stackalloc byte[description_of_location_byteCount + 1];
					native_description_of_location = native_description_of_location_stackBytes;
				}
				var description_of_location_offset = Util.GetUtf8(description_of_location, native_description_of_location, description_of_location_byteCount);
				native_description_of_location[description_of_location_offset] = 0;
			}
			else native_description_of_location = null;

			ImGuiInternalNative.ImGui_DebugBreakButtonTooltip(native_keyboard_only, native_description_of_location);
			if (description_of_location_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_description_of_location);
			}
		}

		public static void ShowFontAtlas(ImFontAtlasPtr atlas)
		{
			ImGuiInternalNative.ImGui_ShowFontAtlas(atlas);
		}

		public static void DebugHookIdInfo(uint id, ImGuiDataType data_type, IntPtr data_id, IntPtr data_id_end)
		{
			// Marshaling 'data_id' to native void pointer
			var native_data_id = data_id.ToPointer();

			// Marshaling 'data_id_end' to native void pointer
			var native_data_id_end = data_id_end.ToPointer();

			ImGuiInternalNative.ImGui_DebugHookIdInfo(id, data_type, native_data_id, native_data_id_end);
		}

		public static void DebugNodeColumns(ImGuiOldColumnsPtr columns)
		{
			ImGuiInternalNative.ImGui_DebugNodeColumns(columns);
		}

		public static void DebugNodeDockNode(ImGuiDockNodePtr node, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodeDockNode(node, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugNodeDrawList(ImGuiWindowPtr window, ImGuiViewportPPtr viewport, ImDrawListPtr draw_list, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodeDrawList(window, viewport, draw_list, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawListPtr out_draw_list, ImDrawListPtr draw_list, ImDrawCmdPtr draw_cmd, bool show_mesh, bool show_aabb)
		{
			// Marshaling 'show_mesh' to native bool
			var native_show_mesh = show_mesh ? (byte)1 : (byte)0;

			// Marshaling 'show_aabb' to native bool
			var native_show_aabb = show_aabb ? (byte)1 : (byte)0;

			ImGuiInternalNative.ImGui_DebugNodeDrawCmdShowMeshAndBoundingBox(out_draw_list, draw_list, draw_cmd, native_show_mesh, native_show_aabb);
		}

		public static void DebugNodeFont(ImFontPtr font)
		{
			ImGuiInternalNative.ImGui_DebugNodeFont(font);
		}

		public static void DebugNodeFontGlyph(ImFontPtr font, ImFontGlyphPtr glyph)
		{
			ImGuiInternalNative.ImGui_DebugNodeFontGlyph(font, glyph);
		}

		public static void DebugNodeStorage(ImGuiStoragePtr storage, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodeStorage(storage, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugNodeTabBar(ImGuiTabBarPtr tab_bar, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodeTabBar(tab_bar, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugNodeTable(ImGuiTablePtr table)
		{
			ImGuiInternalNative.ImGui_DebugNodeTable(table);
		}

		public static void DebugNodeTableSettings(ImGuiTableSettingsPtr settings)
		{
			ImGuiInternalNative.ImGui_DebugNodeTableSettings(settings);
		}

		public static void DebugNodeTypingSelectState(ImGuiTypingSelectStatePtr state)
		{
			ImGuiInternalNative.ImGui_DebugNodeTypingSelectState(state);
		}

		public static void DebugNodeMultiSelectState(ImGuiMultiSelectStatePtr state)
		{
			ImGuiInternalNative.ImGui_DebugNodeMultiSelectState(state);
		}

		public static void DebugNodeWindow(ImGuiWindowPtr window, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodeWindow(window, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugNodeWindowSettings(ImGuiWindowSettingsPtr settings)
		{
			ImGuiInternalNative.ImGui_DebugNodeWindowSettings(settings);
		}

		public static void DebugNodeWindowsList(ImVector* windows, ReadOnlySpan<char> label)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodeWindowsList(windows, native_label);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugNodeWindowsListByBeginStackParent(ref ImGuiWindow* windows, int windows_size, ImGuiWindowPtr parent_in_begin_stack)
		{
			fixed (ImGuiWindow** native_windows = &windows)
			{
				ImGuiInternalNative.ImGui_DebugNodeWindowsListByBeginStackParent(native_windows, windows_size, parent_in_begin_stack);
			}
		}

		public static void DebugNodeViewport(ImGuiViewportPPtr viewport)
		{
			ImGuiInternalNative.ImGui_DebugNodeViewport(viewport);
		}

		public static void DebugNodePlatformMonitor(ImGuiPlatformMonitorPtr monitor, ReadOnlySpan<char> label, int idx)
		{
			// Marshaling 'label' to native string
			byte* native_label;
			var label_byteCount = 0;
			if (label != null)
			{
				label_byteCount = Encoding.UTF8.GetByteCount(label);
				if (label_byteCount > Util.StackAllocationSizeLimit)
				{
					native_label = Util.Allocate(label_byteCount + 1);
				}
				else
				{
					var native_label_stackBytes = stackalloc byte[label_byteCount + 1];
					native_label = native_label_stackBytes;
				}
				var label_offset = Util.GetUtf8(label, native_label, label_byteCount);
				native_label[label_offset] = 0;
			}
			else native_label = null;

			ImGuiInternalNative.ImGui_DebugNodePlatformMonitor(monitor, native_label, idx);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
		}

		public static void DebugRenderKeyboardPreview(ImDrawListPtr draw_list)
		{
			ImGuiInternalNative.ImGui_DebugRenderKeyboardPreview(draw_list);
		}

		public static void DebugRenderViewportThumbnail(ImDrawListPtr draw_list, ImGuiViewportPPtr viewport, ImRect bb)
		{
			ImGuiInternalNative.ImGui_DebugRenderViewportThumbnail(draw_list, viewport, bb);
		}
	}
}
