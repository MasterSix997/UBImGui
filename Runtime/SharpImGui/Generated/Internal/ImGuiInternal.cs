using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	public static unsafe partial class ImGuiInternal
	{
		public static ImGuiIdStackToolPtr ImGuiIdStackToolImGuiIdStackTool()
		{
			return ImGuiNative.ImGuiIdStackToolImGuiIdStackTool();
		}

		public static void ImGuiIdStackToolDestroy(ImGuiIdStackToolPtr self)
		{
			ImGuiNative.ImGuiIdStackToolDestroy(self);
		}

		public static void ImVec2IhDestroy(ImVec2IhPtr self)
		{
			ImGuiNative.ImVec2IhDestroy(self);
		}

		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.<br/>
		/// </summary>
		public static void ActivateItemByID(uint id)
		{
			ImGuiNative.ActivateItemByID(id);
		}

		public static uint AddContextHook(ImGuiContextPtr context, ImGuiContextHookPtr hook)
		{
			return ImGuiNative.AddContextHook(context, hook);
		}

		public static void AddDrawListToDrawDataEx(ImDrawDataPtr drawData, out ImVector<ImDrawListPtr> outList, ImDrawListPtr drawList)
		{
			fixed (ImVector<ImDrawListPtr>* nativeOutList = &outList)
			{
				ImGuiNative.AddDrawListToDrawDataEx(drawData, nativeOutList, drawList);
			}
		}

		public static void AddSettingsHandler(ImGuiSettingsHandlerPtr handler)
		{
			ImGuiNative.AddSettingsHandler(handler);
		}

		public static bool ArrowButtonEx(ReadOnlySpan<byte> strId, ImGuiDir dir, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			fixed (byte* nativeStrId = strId)
			{
				var result = ImGuiNative.ArrowButtonEx(nativeStrId, dir, sizeArg, flags);
				return result != 0;
			}
		}

		public static bool BeginBoxSelect(ImRect scopeRect, ImGuiWindowPtr window, uint boxSelectId, ImGuiMultiSelectFlags msFlags)
		{
			var result = ImGuiNative.BeginBoxSelect(scopeRect, window, boxSelectId, msFlags);
			return result != 0;
		}

		public static bool BeginChildEx(ReadOnlySpan<byte> name, uint id, Vector2 sizeArg, ImGuiChildFlags childFlags, ImGuiWindowFlags windowFlags)
		{
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginChildEx(nativeName, id, sizeArg, childFlags, windowFlags);
				return result != 0;
			}
		}

		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().<br/>
		/// </summary>
		public static void BeginColumns(ReadOnlySpan<byte> strId, int count, ImGuiOldColumnFlags flags)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.BeginColumns(nativeStrId, count, flags);
			}
		}

		public static bool BeginComboPopup(uint popupId, ImRect bb, ImGuiComboFlags flags)
		{
			var result = ImGuiNative.BeginComboPopup(popupId, bb, flags);
			return result != 0;
		}

		public static bool BeginComboPreview()
		{
			var result = ImGuiNative.BeginComboPreview();
			return result != 0;
		}

		public static void BeginDisabledOverrideReenable()
		{
			ImGuiNative.BeginDisabledOverrideReenable();
		}

		public static void BeginDockableDragDropSource(ImGuiWindowPtr window)
		{
			ImGuiNative.BeginDockableDragDropSource(window);
		}

		public static void BeginDockableDragDropTarget(ImGuiWindowPtr window)
		{
			ImGuiNative.BeginDockableDragDropTarget(window);
		}

		public static void BeginDocked(ImGuiWindowPtr window, ref bool pOpen)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			ImGuiNative.BeginDocked(window, nativePOpen);
			pOpen = nativePOpenVal != 0;
		}

		public static bool BeginDragDropTargetCustom(ImRect bb, uint id)
		{
			var result = ImGuiNative.BeginDragDropTargetCustom(bb, id);
			return result != 0;
		}

		public static bool BeginErrorTooltip()
		{
			var result = ImGuiNative.BeginErrorTooltip();
			return result != 0;
		}

		public static bool BeginMenuEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon, bool enabled)
		{
			var native_enabled = enabled ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			{
				var result = ImGuiNative.BeginMenuEx(nativeLabel, nativeIcon, native_enabled);
				return result != 0;
			}
		}

		public static bool BeginPopupEx(uint id, ImGuiWindowFlags extraWindowFlags)
		{
			var result = ImGuiNative.BeginPopupEx(id, extraWindowFlags);
			return result != 0;
		}

		public static bool BeginPopupMenuEx(uint id, ReadOnlySpan<byte> label, ImGuiWindowFlags extraWindowFlags)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.BeginPopupMenuEx(id, nativeLabel, extraWindowFlags);
				return result != 0;
			}
		}

		public static bool BeginTabBarEx(ImGuiTabBarPtr tabBar, ImRect bb, ImGuiTabBarFlags flags)
		{
			var result = ImGuiNative.BeginTabBarEx(tabBar, bb, flags);
			return result != 0;
		}

		public static bool BeginTableEx(ReadOnlySpan<byte> name, uint id, int columnsCount, ImGuiTableFlags flags, Vector2 outerSize, float innerWidth)
		{
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginTableEx(nativeName, id, columnsCount, flags, outerSize, innerWidth);
				return result != 0;
			}
		}

		public static bool BeginTooltipEx(ImGuiTooltipFlags tooltipFlags, ImGuiWindowFlags extraWindowFlags)
		{
			var result = ImGuiNative.BeginTooltipEx(tooltipFlags, extraWindowFlags);
			return result != 0;
		}

		public static bool BeginTooltipHidden()
		{
			var result = ImGuiNative.BeginTooltipHidden();
			return result != 0;
		}

		public static bool BeginViewportSideBar(ReadOnlySpan<byte> name, ImGuiViewportPtr viewport, ImGuiDir dir, float size, ImGuiWindowFlags windowFlags)
		{
			fixed (byte* nativeName = name)
			{
				var result = ImGuiNative.BeginViewportSideBar(nativeName, viewport, dir, size, windowFlags);
				return result != 0;
			}
		}

		public static void BringWindowToDisplayBack(ImGuiWindowPtr window)
		{
			ImGuiNative.BringWindowToDisplayBack(window);
		}

		public static void BringWindowToDisplayBehind(ImGuiWindowPtr window, ImGuiWindowPtr aboveWindow)
		{
			ImGuiNative.BringWindowToDisplayBehind(window, aboveWindow);
		}

		public static void BringWindowToDisplayFront(ImGuiWindowPtr window)
		{
			ImGuiNative.BringWindowToDisplayFront(window);
		}

		public static void BringWindowToFocusFront(ImGuiWindowPtr window)
		{
			ImGuiNative.BringWindowToFocusFront(window);
		}

		public static bool ButtonBehavior(ImRect bb, uint id, ref bool outHovered, ref bool outHeld, ImGuiButtonFlags flags)
		{
			var nativeOutHoveredVal = outHovered ? (byte)1 : (byte)0;
			var nativeOutHovered = &nativeOutHoveredVal;
			var nativeOutHeldVal = outHeld ? (byte)1 : (byte)0;
			var nativeOutHeld = &nativeOutHeldVal;
			var result = ImGuiNative.ButtonBehavior(bb, id, nativeOutHovered, nativeOutHeld, flags);
			outHovered = nativeOutHoveredVal != 0;
			outHeld = nativeOutHeldVal != 0;
			return result != 0;
		}

		public static bool ButtonEx(ReadOnlySpan<byte> label, Vector2 sizeArg, ImGuiButtonFlags flags)
		{
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.ButtonEx(nativeLabel, sizeArg, flags);
				return result != 0;
			}
		}

		public static void CalcItemSize(out Vector2 pOut, Vector2 size, float defaultW, float defaultH)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.CalcItemSize(nativePOut, size, defaultW, defaultH);
			}
		}

		public static ImDrawFlags CalcRoundingFlagsForRectInRect(ImRect rIn, ImRect rOuter, float threshold)
		{
			return ImGuiNative.CalcRoundingFlagsForRectInRect(rIn, rOuter, threshold);
		}

		public static int CalcTypematicRepeatAmount(float t0, float t1, float repeatDelay, float repeatRate)
		{
			return ImGuiNative.CalcTypematicRepeatAmount(t0, t1, repeatDelay, repeatRate);
		}

		public static void CalcWindowNextAutoFitSize(out Vector2 pOut, ImGuiWindowPtr window)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.CalcWindowNextAutoFitSize(nativePOut, window);
			}
		}

		public static float CalcWrapWidthForPos(Vector2 pos, float wrapPosX)
		{
			return ImGuiNative.CalcWrapWidthForPos(pos, wrapPosX);
		}

		public static void CallContextHooks(ImGuiContextPtr context, ImGuiContextHookType type)
		{
			ImGuiNative.CallContextHooks(context, type);
		}

		public static void ClearActiveID()
		{
			ImGuiNative.ClearActiveID();
		}

		public static void ClearDragDrop()
		{
			ImGuiNative.ClearDragDrop();
		}

		public static void ClearIniSettings()
		{
			ImGuiNative.ClearIniSettings();
		}

		public static void ClearWindowSettings(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				ImGuiNative.ClearWindowSettings(nativeName);
			}
		}

		public static bool CloseButton(uint id, Vector2 pos)
		{
			var result = ImGuiNative.CloseButton(id, pos);
			return result != 0;
		}

		public static void ClosePopupToLevel(int remaining, bool restoreFocusToWindowUnderPopup)
		{
			var native_restoreFocusToWindowUnderPopup = restoreFocusToWindowUnderPopup ? (byte)1 : (byte)0;
			ImGuiNative.ClosePopupToLevel(remaining, native_restoreFocusToWindowUnderPopup);
		}

		public static void ClosePopupsExceptModals()
		{
			ImGuiNative.ClosePopupsExceptModals();
		}

		public static void ClosePopupsOverWindow(ImGuiWindowPtr refWindow, bool restoreFocusToWindowUnderPopup)
		{
			var native_restoreFocusToWindowUnderPopup = restoreFocusToWindowUnderPopup ? (byte)1 : (byte)0;
			ImGuiNative.ClosePopupsOverWindow(refWindow, native_restoreFocusToWindowUnderPopup);
		}

		public static bool CollapseButton(uint id, Vector2 pos, ImGuiDockNodePtr dockNode)
		{
			var result = ImGuiNative.CollapseButton(id, pos, dockNode);
			return result != 0;
		}

		public static void ColorEditOptionsPopup(float[] col, ImGuiColorEditFlags flags)
		{
			fixed (float* nativeCol = col)
			{
				ImGuiNative.ColorEditOptionsPopup(nativeCol, flags);
			}
		}

		public static void ColorPickerOptionsPopup(float[] refCol, ImGuiColorEditFlags flags)
		{
			fixed (float* nativeRefCol = refCol)
			{
				ImGuiNative.ColorPickerOptionsPopup(nativeRefCol, flags);
			}
		}

		public static void ColorTooltip(ReadOnlySpan<byte> text, float[] col, ImGuiColorEditFlags flags)
		{
			fixed (byte* nativeText = text)
			fixed (float* nativeCol = col)
			{
				ImGuiNative.ColorTooltip(nativeText, nativeCol, flags);
			}
		}

		public static ImGuiKey ConvertSingleModFlagToKey(ImGuiKey key)
		{
			return ImGuiNative.ConvertSingleModFlagToKey(key);
		}

		public static ImGuiWindowSettingsPtr CreateNewWindowSettings(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				return ImGuiNative.CreateNewWindowSettings(nativeName);
			}
		}

		public static bool DataTypeApplyFromText(ReadOnlySpan<byte> buf, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format, IntPtr pDataWhenEmpty)
		{
			fixed (byte* nativeBuf = buf)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DataTypeApplyFromText(nativeBuf, dataType, (void*)pData, nativeFormat, (void*)pDataWhenEmpty);
				return result != 0;
			}
		}

		public static void DataTypeApplyOp(ImGuiDataType dataType, int op, IntPtr output, IntPtr arg_1, IntPtr arg_2)
		{
			ImGuiNative.DataTypeApplyOp(dataType, op, (void*)output, (void*)arg_1, (void*)arg_2);
		}

		public static bool DataTypeClamp(ImGuiDataType dataType, IntPtr pData, IntPtr pMin, IntPtr pMax)
		{
			var result = ImGuiNative.DataTypeClamp(dataType, (void*)pData, (void*)pMin, (void*)pMax);
			return result != 0;
		}

		public static int DataTypeCompare(ImGuiDataType dataType, IntPtr arg_1, IntPtr arg_2)
		{
			return ImGuiNative.DataTypeCompare(dataType, (void*)arg_1, (void*)arg_2);
		}

		public static int DataTypeFormatString(byte[] buf, int bufSize, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format)
		{
			fixed (byte* nativeBuf = buf)
			fixed (byte* nativeFormat = format)
			{
				return ImGuiNative.DataTypeFormatString(nativeBuf, bufSize, dataType, (void*)pData, nativeFormat);
			}
		}

		public static ImGuiDataTypeInfoPtr DataTypeGetInfo(ImGuiDataType dataType)
		{
			return ImGuiNative.DataTypeGetInfo(dataType);
		}

		public static bool DataTypeIsZero(ImGuiDataType dataType, IntPtr pData)
		{
			var result = ImGuiNative.DataTypeIsZero(dataType, (void*)pData);
			return result != 0;
		}

		/// <summary>
		/// size &gt;= 0 : alloc, size = -1 : free<br/>
		/// </summary>
		public static void DebugAllocHook(ImGuiDebugAllocInfoPtr info, int frameCount, IntPtr ptr, uint size)
		{
			ImGuiNative.DebugAllocHook(info, frameCount, (void*)ptr, size);
		}

		public static bool DebugBreakButton(ReadOnlySpan<byte> label, ReadOnlySpan<byte> descriptionOfLocation)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeDescriptionOfLocation = descriptionOfLocation)
			{
				var result = ImGuiNative.DebugBreakButton(nativeLabel, nativeDescriptionOfLocation);
				return result != 0;
			}
		}

		public static void DebugBreakButtonTooltip(bool keyboardOnly, ReadOnlySpan<byte> descriptionOfLocation)
		{
			var native_keyboardOnly = keyboardOnly ? (byte)1 : (byte)0;
			fixed (byte* nativeDescriptionOfLocation = descriptionOfLocation)
			{
				ImGuiNative.DebugBreakButtonTooltip(native_keyboardOnly, nativeDescriptionOfLocation);
			}
		}

		public static void DebugBreakClearData()
		{
			ImGuiNative.DebugBreakClearData();
		}

		public static void DebugDrawCursorPos(uint col)
		{
			ImGuiNative.DebugDrawCursorPos(col);
		}

		public static void DebugDrawItemRect(uint col)
		{
			ImGuiNative.DebugDrawItemRect(col);
		}

		public static void DebugDrawLineExtents(uint col)
		{
			ImGuiNative.DebugDrawLineExtents(col);
		}

		public static void DebugHookIdInfo(uint id, ImGuiDataType dataType, IntPtr dataId, IntPtr dataIdEnd)
		{
			ImGuiNative.DebugHookIdInfo(id, dataType, (void*)dataId, (void*)dataIdEnd);
		}

		/// <summary>
		/// Call sparingly: only 1 at the same time!<br/>
		/// </summary>
		public static void DebugLocateItem(uint targetId)
		{
			ImGuiNative.DebugLocateItem(targetId);
		}

		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!<br/>
		/// </summary>
		public static void DebugLocateItemOnHover(uint targetId)
		{
			ImGuiNative.DebugLocateItemOnHover(targetId);
		}

		public static void DebugLocateItemResolveWithLastItem()
		{
			ImGuiNative.DebugLocateItemResolveWithLastItem();
		}

		public static void DebugNodeColumns(ImGuiOldColumnsPtr columns)
		{
			ImGuiNative.DebugNodeColumns(columns);
		}

		public static void DebugNodeDockNode(ImGuiDockNodePtr node, ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodeDockNode(node, nativeLabel);
			}
		}

		public static void DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawListPtr outDrawList, ImDrawListPtr drawList, ImDrawCmdPtr drawCmd, bool showMesh, bool showAabb)
		{
			var native_showMesh = showMesh ? (byte)1 : (byte)0;
			var native_showAabb = showAabb ? (byte)1 : (byte)0;
			ImGuiNative.DebugNodeDrawCmdShowMeshAndBoundingBox(outDrawList, drawList, drawCmd, native_showMesh, native_showAabb);
		}

		public static void DebugNodeDrawList(ImGuiWindowPtr window, ImGuiViewportPPtr viewport, ImDrawListPtr drawList, ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodeDrawList(window, viewport, drawList, nativeLabel);
			}
		}

		public static void DebugNodeFont(ImFontPtr font)
		{
			ImGuiNative.DebugNodeFont(font);
		}

		public static void DebugNodeFontGlyph(ImFontPtr font, ImFontGlyphPtr glyph)
		{
			ImGuiNative.DebugNodeFontGlyph(font, glyph);
		}

		public static void DebugNodeInputTextState(ImGuiInputTextStatePtr state)
		{
			ImGuiNative.DebugNodeInputTextState(state);
		}

		public static void DebugNodeMultiSelectState(ImGuiMultiSelectStatePtr state)
		{
			ImGuiNative.DebugNodeMultiSelectState(state);
		}

		public static void DebugNodePlatformMonitor(ImGuiPlatformMonitorPtr monitor, ReadOnlySpan<byte> label, int idx)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodePlatformMonitor(monitor, nativeLabel, idx);
			}
		}

		public static void DebugNodeStorage(ImGuiStoragePtr storage, ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodeStorage(storage, nativeLabel);
			}
		}

		public static void DebugNodeTabBar(ImGuiTabBarPtr tabBar, ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodeTabBar(tabBar, nativeLabel);
			}
		}

		public static void DebugNodeTable(ImGuiTablePtr table)
		{
			ImGuiNative.DebugNodeTable(table);
		}

		public static void DebugNodeTableSettings(ImGuiTableSettingsPtr settings)
		{
			ImGuiNative.DebugNodeTableSettings(settings);
		}

		public static void DebugNodeTypingSelectState(ImGuiTypingSelectStatePtr state)
		{
			ImGuiNative.DebugNodeTypingSelectState(state);
		}

		public static void DebugNodeViewport(ImGuiViewportPPtr viewport)
		{
			ImGuiNative.DebugNodeViewport(viewport);
		}

		public static void DebugNodeWindow(ImGuiWindowPtr window, ReadOnlySpan<byte> label)
		{
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodeWindow(window, nativeLabel);
			}
		}

		public static void DebugNodeWindowSettings(ImGuiWindowSettingsPtr settings)
		{
			ImGuiNative.DebugNodeWindowSettings(settings);
		}

		public static void DebugNodeWindowsList(ref ImVector<ImGuiWindowPtr> windows, ReadOnlySpan<byte> label)
		{
			fixed (ImVector<ImGuiWindowPtr>* nativeWindows = &windows)
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.DebugNodeWindowsList(nativeWindows, nativeLabel);
			}
		}

		public static void DebugNodeWindowsListByBeginStackParent(ref ImGuiWindow* windows, int windowsSize, ImGuiWindowPtr parentInBeginStack)
		{
			fixed (ImGuiWindow** nativeWindows = &windows)
			{
				ImGuiNative.DebugNodeWindowsListByBeginStackParent(nativeWindows, windowsSize, parentInBeginStack);
			}
		}

		public static void DebugRenderKeyboardPreview(ImDrawListPtr drawList)
		{
			ImGuiNative.DebugRenderKeyboardPreview(drawList);
		}

		public static void DebugRenderViewportThumbnail(ImDrawListPtr drawList, ImGuiViewportPPtr viewport, ImRect bb)
		{
			ImGuiNative.DebugRenderViewportThumbnail(drawList, viewport, bb);
		}

		public static void DebugTextUnformattedWithLocateItem(ReadOnlySpan<byte> lineBegin, ReadOnlySpan<byte> lineEnd)
		{
			fixed (byte* nativeLineBegin = lineBegin)
			fixed (byte* nativeLineEnd = lineEnd)
			{
				ImGuiNative.DebugTextUnformattedWithLocateItem(nativeLineBegin, nativeLineEnd);
			}
		}

		public static void DestroyPlatformWindow(ImGuiViewportPPtr viewport)
		{
			ImGuiNative.DestroyPlatformWindow(viewport);
		}

		public static uint DockBuilderAddNode(uint nodeId, ImGuiDockNodeFlags flags)
		{
			return ImGuiNative.DockBuilderAddNode(nodeId, flags);
		}

		public static void DockBuilderCopyDockSpace(uint srcDockspaceId, uint dstDockspaceId, ref ImVector<ImPointer<byte>> inWindowRemapPairs)
		{
			fixed (ImVector<ImPointer<byte>>* nativeInWindowRemapPairs = &inWindowRemapPairs)
			{
				ImGuiNative.DockBuilderCopyDockSpace(srcDockspaceId, dstDockspaceId, nativeInWindowRemapPairs);
			}
		}

		public static void DockBuilderCopyNode(uint srcNodeId, uint dstNodeId, out ImVector<uint> outNodeRemapPairs)
		{
			fixed (ImVector<uint>* nativeOutNodeRemapPairs = &outNodeRemapPairs)
			{
				ImGuiNative.DockBuilderCopyNode(srcNodeId, dstNodeId, nativeOutNodeRemapPairs);
			}
		}

		public static void DockBuilderCopyWindowSettings(ReadOnlySpan<byte> srcName, ReadOnlySpan<byte> dstName)
		{
			fixed (byte* nativeSrcName = srcName)
			fixed (byte* nativeDstName = dstName)
			{
				ImGuiNative.DockBuilderCopyWindowSettings(nativeSrcName, nativeDstName);
			}
		}

		public static void DockBuilderDockWindow(ReadOnlySpan<byte> windowName, uint nodeId)
		{
			fixed (byte* nativeWindowName = windowName)
			{
				ImGuiNative.DockBuilderDockWindow(nativeWindowName, nodeId);
			}
		}

		public static void DockBuilderFinish(uint nodeId)
		{
			ImGuiNative.DockBuilderFinish(nodeId);
		}

		public static ImGuiDockNodePtr DockBuilderGetCentralNode(uint nodeId)
		{
			return ImGuiNative.DockBuilderGetCentralNode(nodeId);
		}

		public static ImGuiDockNodePtr DockBuilderGetNode(uint nodeId)
		{
			return ImGuiNative.DockBuilderGetNode(nodeId);
		}

		/// <summary>
		/// Remove node and all its child, undock all windows<br/>
		/// </summary>
		public static void DockBuilderRemoveNode(uint nodeId)
		{
			ImGuiNative.DockBuilderRemoveNode(nodeId);
		}

		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).<br/>
		/// </summary>
		public static void DockBuilderRemoveNodeChildNodes(uint nodeId)
		{
			ImGuiNative.DockBuilderRemoveNodeChildNodes(nodeId);
		}

		public static void DockBuilderRemoveNodeDockedWindows(uint nodeId, bool clearSettingsRefs)
		{
			var native_clearSettingsRefs = clearSettingsRefs ? (byte)1 : (byte)0;
			ImGuiNative.DockBuilderRemoveNodeDockedWindows(nodeId, native_clearSettingsRefs);
		}

		public static void DockBuilderSetNodePos(uint nodeId, Vector2 pos)
		{
			ImGuiNative.DockBuilderSetNodePos(nodeId, pos);
		}

		public static void DockBuilderSetNodeSize(uint nodeId, Vector2 size)
		{
			ImGuiNative.DockBuilderSetNodeSize(nodeId, size);
		}

		/// <summary>
		/// Create 2 child nodes in this parent node.<br/>
		/// </summary>
		public static uint DockBuilderSplitNode(uint nodeId, ImGuiDir splitDir, float sizeRatioForNodeAtDir, out uint outIdAtDir, out uint outIdAtOppositeDir)
		{
			fixed (uint* nativeOutIdAtDir = &outIdAtDir)
			fixed (uint* nativeOutIdAtOppositeDir = &outIdAtOppositeDir)
			{
				return ImGuiNative.DockBuilderSplitNode(nodeId, splitDir, sizeRatioForNodeAtDir, nativeOutIdAtDir, nativeOutIdAtOppositeDir);
			}
		}

		public static bool DockContextCalcDropPosForDocking(ImGuiWindowPtr target, ImGuiDockNodePtr targetNode, ImGuiWindowPtr payloadWindow, ImGuiDockNodePtr payloadNode, ImGuiDir splitDir, bool splitOuter, out Vector2 outPos)
		{
			var native_splitOuter = splitOuter ? (byte)1 : (byte)0;
			fixed (Vector2* nativeOutPos = &outPos)
			{
				var result = ImGuiNative.DockContextCalcDropPosForDocking(target, targetNode, payloadWindow, payloadNode, splitDir, native_splitOuter, nativeOutPos);
				return result != 0;
			}
		}

		/// <summary>
		/// Use root_id==0 to clear all<br/>
		/// </summary>
		public static void DockContextClearNodes(ImGuiContextPtr ctx, uint rootId, bool clearSettingsRefs)
		{
			var native_clearSettingsRefs = clearSettingsRefs ? (byte)1 : (byte)0;
			ImGuiNative.DockContextClearNodes(ctx, rootId, native_clearSettingsRefs);
		}

		public static void DockContextEndFrame(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextEndFrame(ctx);
		}

		public static ImGuiDockNodePtr DockContextFindNodeByID(ImGuiContextPtr ctx, uint id)
		{
			return ImGuiNative.DockContextFindNodeByID(ctx, id);
		}

		public static uint DockContextGenNodeID(ImGuiContextPtr ctx)
		{
			return ImGuiNative.DockContextGenNodeID(ctx);
		}

		public static void DockContextInitialize(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextInitialize(ctx);
		}

		public static void DockContextNewFrameUpdateDocking(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextNewFrameUpdateDocking(ctx);
		}

		public static void DockContextNewFrameUpdateUndocking(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextNewFrameUpdateUndocking(ctx);
		}

		public static void DockContextProcessUndockNode(ImGuiContextPtr ctx, ImGuiDockNodePtr node)
		{
			ImGuiNative.DockContextProcessUndockNode(ctx, node);
		}

		public static void DockContextProcessUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window, bool clearPersistentDockingRef)
		{
			var native_clearPersistentDockingRef = clearPersistentDockingRef ? (byte)1 : (byte)0;
			ImGuiNative.DockContextProcessUndockWindow(ctx, window, native_clearPersistentDockingRef);
		}

		public static void DockContextQueueDock(ImGuiContextPtr ctx, ImGuiWindowPtr target, ImGuiDockNodePtr targetNode, ImGuiWindowPtr payload, ImGuiDir splitDir, float splitRatio, bool splitOuter)
		{
			var native_splitOuter = splitOuter ? (byte)1 : (byte)0;
			ImGuiNative.DockContextQueueDock(ctx, target, targetNode, payload, splitDir, splitRatio, native_splitOuter);
		}

		public static void DockContextQueueUndockNode(ImGuiContextPtr ctx, ImGuiDockNodePtr node)
		{
			ImGuiNative.DockContextQueueUndockNode(ctx, node);
		}

		public static void DockContextQueueUndockWindow(ImGuiContextPtr ctx, ImGuiWindowPtr window)
		{
			ImGuiNative.DockContextQueueUndockWindow(ctx, window);
		}

		public static void DockContextRebuildNodes(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextRebuildNodes(ctx);
		}

		public static void DockContextShutdown(ImGuiContextPtr ctx)
		{
			ImGuiNative.DockContextShutdown(ctx);
		}

		public static bool DockNodeBeginAmendTabBar(ImGuiDockNodePtr node)
		{
			var result = ImGuiNative.DockNodeBeginAmendTabBar(node);
			return result != 0;
		}

		public static void DockNodeEndAmendTabBar()
		{
			ImGuiNative.DockNodeEndAmendTabBar();
		}

		public static int DockNodeGetDepth(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeGetDepth(node);
		}

		public static ImGuiDockNodePtr DockNodeGetRootNode(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeGetRootNode(node);
		}

		public static uint DockNodeGetWindowMenuButtonId(ImGuiDockNodePtr node)
		{
			return ImGuiNative.DockNodeGetWindowMenuButtonId(node);
		}

		public static bool DockNodeIsInHierarchyOf(ImGuiDockNodePtr node, ImGuiDockNodePtr parent)
		{
			var result = ImGuiNative.DockNodeIsInHierarchyOf(node, parent);
			return result != 0;
		}

		public static void DockNodeWindowMenuHandlerDefault(ImGuiContextPtr ctx, ImGuiDockNodePtr node, ImGuiTabBarPtr tabBar)
		{
			ImGuiNative.DockNodeWindowMenuHandlerDefault(ctx, node, tabBar);
		}

		public static bool DragBehavior(uint id, ImGuiDataType dataType, IntPtr pV, float vSpeed, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags)
		{
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.DragBehavior(id, dataType, (void*)pV, vSpeed, (void*)pMin, (void*)pMax, nativeFormat, flags);
				return result != 0;
			}
		}

		public static void EndBoxSelect(ImRect scopeRect, ImGuiMultiSelectFlags msFlags)
		{
			ImGuiNative.EndBoxSelect(scopeRect, msFlags);
		}

		/// <summary>
		/// close columns<br/>
		/// </summary>
		public static void EndColumns()
		{
			ImGuiNative.EndColumns();
		}

		public static void EndComboPreview()
		{
			ImGuiNative.EndComboPreview();
		}

		public static void EndDisabledOverrideReenable()
		{
			ImGuiNative.EndDisabledOverrideReenable();
		}

		public static void EndErrorTooltip()
		{
			ImGuiNative.EndErrorTooltip();
		}

		public static void ErrorCheckEndFrameFinalizeErrorTooltip()
		{
			ImGuiNative.ErrorCheckEndFrameFinalizeErrorTooltip();
		}

		public static void ErrorCheckUsingSetCursorPosToExtendParentBoundaries()
		{
			ImGuiNative.ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		}

		public static bool ErrorLog(ReadOnlySpan<byte> msg)
		{
			fixed (byte* nativeMsg = msg)
			{
				var result = ImGuiNative.ErrorLog(nativeMsg);
				return result != 0;
			}
		}

		public static void ErrorRecoveryStoreState(ImGuiErrorRecoveryStatePtr stateOut)
		{
			ImGuiNative.ErrorRecoveryStoreState(stateOut);
		}

		public static void ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryStatePtr stateIn)
		{
			ImGuiNative.ErrorRecoveryTryToRecoverState(stateIn);
		}

		public static void ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryStatePtr stateIn)
		{
			ImGuiNative.ErrorRecoveryTryToRecoverWindowState(stateIn);
		}

		public static void FindBestWindowPosForPopup(out Vector2 pOut, ImGuiWindowPtr window)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.FindBestWindowPosForPopup(nativePOut, window);
			}
		}

		public static void FindBestWindowPosForPopupEx(out Vector2 pOut, Vector2 refPos, Vector2 size, ref ImGuiDir lastDir, ImRect rOuter, ImRect rAvoid, ImGuiPopupPositionPolicy policy)
		{
			fixed (Vector2* nativePOut = &pOut)
			fixed (ImGuiDir* nativeLastDir = &lastDir)
			{
				ImGuiNative.FindBestWindowPosForPopupEx(nativePOut, refPos, size, nativeLastDir, rOuter, rAvoid, policy);
			}
		}

		public static ImGuiWindowPtr FindBlockingModal(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindBlockingModal(window);
		}

		public static ImGuiWindowPtr FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindBottomMostVisibleWindowWithinBeginStack(window);
		}

		public static ImGuiViewportPPtr FindHoveredViewportFromPlatformWindowStack(Vector2 mousePlatformPos)
		{
			return ImGuiNative.FindHoveredViewportFromPlatformWindowStack(mousePlatformPos);
		}

		public static void FindHoveredWindowEx(Vector2 pos, bool findFirstAndInAnyViewport, out ImGuiWindow* outHoveredWindow, out ImGuiWindow* outHoveredWindowUnderMovingWindow)
		{
			var native_findFirstAndInAnyViewport = findFirstAndInAnyViewport ? (byte)1 : (byte)0;
			fixed (ImGuiWindow** nativeOutHoveredWindow = &outHoveredWindow)
			fixed (ImGuiWindow** nativeOutHoveredWindowUnderMovingWindow = &outHoveredWindowUnderMovingWindow)
			{
				ImGuiNative.FindHoveredWindowEx(pos, native_findFirstAndInAnyViewport, nativeOutHoveredWindow, nativeOutHoveredWindowUnderMovingWindow);
			}
		}

		public static ImGuiOldColumnsPtr FindOrCreateColumns(ImGuiWindowPtr window, uint id)
		{
			return ImGuiNative.FindOrCreateColumns(window, id);
		}

		/// <summary>
		/// Find the optional ## from which we stop displaying text.<br/>
		/// </summary>
		public static string FindRenderedTextEnd(ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				var result = ImGuiNative.FindRenderedTextEnd(nativeText, nativeTextEnd);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static ImGuiSettingsHandlerPtr FindSettingsHandler(ReadOnlySpan<byte> typeName)
		{
			fixed (byte* nativeTypeName = typeName)
			{
				return ImGuiNative.FindSettingsHandler(nativeTypeName);
			}
		}

		public static ImGuiWindowPtr FindWindowByID(uint id)
		{
			return ImGuiNative.FindWindowByID(id);
		}

		public static ImGuiWindowPtr FindWindowByName(ReadOnlySpan<byte> name)
		{
			fixed (byte* nativeName = name)
			{
				return ImGuiNative.FindWindowByName(nativeName);
			}
		}

		public static int FindWindowDisplayIndex(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindWindowDisplayIndex(window);
		}

		public static ImGuiWindowSettingsPtr FindWindowSettingsByID(uint id)
		{
			return ImGuiNative.FindWindowSettingsByID(id);
		}

		public static ImGuiWindowSettingsPtr FindWindowSettingsByWindow(ImGuiWindowPtr window)
		{
			return ImGuiNative.FindWindowSettingsByWindow(window);
		}

		public static int FixupKeyChord(int keyChord)
		{
			return ImGuiNative.FixupKeyChord(keyChord);
		}

		/// <summary>
		/// Focus last item (no selection/activation).<br/>
		/// </summary>
		public static void FocusItem()
		{
			ImGuiNative.FocusItem();
		}

		public static void FocusTopMostWindowUnderOne(ImGuiWindowPtr underThisWindow, ImGuiWindowPtr ignoreWindow, ImGuiViewportPtr filterViewport, ImGuiFocusRequestFlags flags)
		{
			ImGuiNative.FocusTopMostWindowUnderOne(underThisWindow, ignoreWindow, filterViewport, flags);
		}

		public static void FocusWindow(ImGuiWindowPtr window, ImGuiFocusRequestFlags flags)
		{
			ImGuiNative.FocusWindow(window, flags);
		}

		public static void GcAwakeTransientWindowBuffers(ImGuiWindowPtr window)
		{
			ImGuiNative.GcAwakeTransientWindowBuffers(window);
		}

		public static void GcCompactTransientMiscBuffers()
		{
			ImGuiNative.GcCompactTransientMiscBuffers();
		}

		public static void GcCompactTransientWindowBuffers(ImGuiWindowPtr window)
		{
			ImGuiNative.GcCompactTransientWindowBuffers(window);
		}

		public static uint GetActiveID()
		{
			return ImGuiNative.GetActiveID();
		}

		public static ImGuiBoxSelectStatePtr GetBoxSelectState(uint id)
		{
			return ImGuiNative.GetBoxSelectState(id);
		}

		public static float GetColumnNormFromOffset(ImGuiOldColumnsPtr columns, float offset)
		{
			return ImGuiNative.GetColumnNormFromOffset(columns, offset);
		}

		public static float GetColumnOffsetFromNorm(ImGuiOldColumnsPtr columns, float offsetNorm)
		{
			return ImGuiNative.GetColumnOffsetFromNorm(columns, offsetNorm);
		}

		public static uint GetColumnsID(ReadOnlySpan<byte> strId, int count)
		{
			fixed (byte* nativeStrId = strId)
			{
				return ImGuiNative.GetColumnsID(nativeStrId, count);
			}
		}

		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()<br/>
		/// </summary>
		public static uint GetCurrentFocusScope()
		{
			return ImGuiNative.GetCurrentFocusScope();
		}

		public static ImGuiTabBarPtr GetCurrentTabBar()
		{
			return ImGuiNative.GetCurrentTabBar();
		}

		public static ImGuiTablePtr GetCurrentTable()
		{
			return ImGuiNative.GetCurrentTable();
		}

		public static ImGuiWindowPtr GetCurrentWindow()
		{
			return ImGuiNative.GetCurrentWindow();
		}

		public static ImGuiWindowPtr GetCurrentWindowRead()
		{
			return ImGuiNative.GetCurrentWindowRead();
		}

		public static ImFontPtr GetDefaultFont()
		{
			return ImGuiNative.GetDefaultFont();
		}

		public static uint GetFocusID()
		{
			return ImGuiNative.GetFocusID();
		}

		public static uint GetHoveredID()
		{
			return ImGuiNative.GetHoveredID();
		}

		/// <summary>
		/// Get input text state if active<br/>
		/// </summary>
		public static ImGuiInputTextStatePtr GetInputTextState(uint id)
		{
			return ImGuiNative.GetInputTextState(id);
		}

		public static ImGuiItemFlags GetItemFlags()
		{
			return ImGuiNative.GetItemFlags();
		}

		public static ImGuiItemStatusFlags GetItemStatusFlags()
		{
			return ImGuiNative.GetItemStatusFlags();
		}

		public static string GetKeyChordName(int keyChord)
		{
			var result = ImGuiNative.GetKeyChordName(keyChord);
			return Utils.DecodeStringUTF8(result);
		}

		public static void GetKeyMagnitude2D(out Vector2 pOut, ImGuiKey keyLeft, ImGuiKey keyRight, ImGuiKey keyUp, ImGuiKey keyDown)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.GetKeyMagnitude2D(nativePOut, keyLeft, keyRight, keyUp, keyDown);
			}
		}

		public static uint GetKeyOwner(ImGuiKey key)
		{
			return ImGuiNative.GetKeyOwner(key);
		}

		public static ImGuiKeyOwnerDataPtr GetKeyOwnerData(ImGuiContextPtr ctx, ImGuiKey key)
		{
			return ImGuiNative.GetKeyOwnerData(ctx, key);
		}

		public static ImGuiMultiSelectStatePtr GetMultiSelectState(uint id)
		{
			return ImGuiNative.GetMultiSelectState(id);
		}

		public static float GetNavTweakPressedAmount(ImGuiAxis axis)
		{
			return ImGuiNative.GetNavTweakPressedAmount(axis);
		}

		public static void GetPopupAllowedExtentRect(ImRectPtr pOut, ImGuiWindowPtr window)
		{
			ImGuiNative.GetPopupAllowedExtentRect(pOut, window);
		}

		public static ImGuiKeyRoutingDataPtr GetShortcutRoutingData(int keyChord)
		{
			return ImGuiNative.GetShortcutRoutingData(keyChord);
		}

		public static ImGuiStyleVarInfoPtr GetStyleVarInfo(ImGuiStyleVar idx)
		{
			return ImGuiNative.GetStyleVarInfo(idx);
		}

		public static ImGuiWindowPtr GetTopMostAndVisiblePopupModal()
		{
			return ImGuiNative.GetTopMostAndVisiblePopupModal();
		}

		public static ImGuiWindowPtr GetTopMostPopupModal()
		{
			return ImGuiNative.GetTopMostPopupModal();
		}

		public static void GetTypematicRepeatRate(ImGuiInputFlags flags, ref float repeatDelay, ref float repeatRate)
		{
			fixed (float* nativeRepeatDelay = &repeatDelay)
			fixed (float* nativeRepeatRate = &repeatRate)
			{
				ImGuiNative.GetTypematicRepeatRate(flags, nativeRepeatDelay, nativeRepeatRate);
			}
		}

		public static ImGuiTypingSelectRequestPtr GetTypingSelectRequest(ImGuiTypingSelectFlags flags)
		{
			return ImGuiNative.GetTypingSelectRequest(flags);
		}

		public static ImGuiPlatformMonitorPtr GetViewportPlatformMonitor(ImGuiViewportPtr viewport)
		{
			return ImGuiNative.GetViewportPlatformMonitor(viewport);
		}

		public static bool GetWindowAlwaysWantOwnTabBar(ImGuiWindowPtr window)
		{
			var result = ImGuiNative.GetWindowAlwaysWantOwnTabBar(window);
			return result != 0;
		}

		public static ImGuiDockNodePtr GetWindowDockNode()
		{
			return ImGuiNative.GetWindowDockNode();
		}

		public static uint GetWindowResizeBorderID(ImGuiWindowPtr window, ImGuiDir dir)
		{
			return ImGuiNative.GetWindowResizeBorderID(window, dir);
		}

		/// <summary>
		/// 0..3: corners<br/>
		/// </summary>
		public static uint GetWindowResizeCornerID(ImGuiWindowPtr window, int n)
		{
			return ImGuiNative.GetWindowResizeCornerID(window, n);
		}

		public static uint GetWindowScrollbarID(ImGuiWindowPtr window, ImGuiAxis axis)
		{
			return ImGuiNative.GetWindowScrollbarID(window, axis);
		}

		public static void GetWindowScrollbarRect(ImRectPtr pOut, ImGuiWindowPtr window, ImGuiAxis axis)
		{
			ImGuiNative.GetWindowScrollbarRect(pOut, window, axis);
		}

		public static uint ImAlphaBlendColors(uint colA, uint colB)
		{
			return ImGuiNative.ImAlphaBlendColors(colA, colB);
		}

		public static void ImBezierCubicCalc(out Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImBezierCubicCalc(nativePOut, p1, p2, p3, p4, t);
			}
		}

		/// <summary>
		/// For curves with explicit number of segments<br/>
		/// </summary>
		public static void ImBezierCubicClosestPoint(out Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int numSegments)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImBezierCubicClosestPoint(nativePOut, p1, p2, p3, p4, p, numSegments);
			}
		}

		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol<br/>
		/// </summary>
		public static void ImBezierCubicClosestPointCasteljau(out Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tessTol)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImBezierCubicClosestPointCasteljau(nativePOut, p1, p2, p3, p4, p, tessTol);
			}
		}

		public static void ImBezierQuadraticCalc(out Vector2 pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImBezierQuadraticCalc(nativePOut, p1, p2, p3, t);
			}
		}

		public static void ImBitArrayClearAllBits(ref uint arr, int bitcount)
		{
			fixed (uint* nativeArr = &arr)
			{
				ImGuiNative.ImBitArrayClearAllBits(nativeArr, bitcount);
			}
		}

		public static void ImBitArrayClearBit(ref uint arr, int n)
		{
			fixed (uint* nativeArr = &arr)
			{
				ImGuiNative.ImBitArrayClearBit(nativeArr, n);
			}
		}

		public static uint ImBitArrayGetStorageSizeInBytes(int bitcount)
		{
			return ImGuiNative.ImBitArrayGetStorageSizeInBytes(bitcount);
		}

		public static void ImBitArraySetBit(ref uint arr, int n)
		{
			fixed (uint* nativeArr = &arr)
			{
				ImGuiNative.ImBitArraySetBit(nativeArr, n);
			}
		}

		public static void ImBitArraySetBitRange(ref uint arr, int n, int n2)
		{
			fixed (uint* nativeArr = &arr)
			{
				ImGuiNative.ImBitArraySetBitRange(nativeArr, n, n2);
			}
		}

		public static bool ImBitArrayTestBit(uint[] arr, int n)
		{
			fixed (uint* nativeArr = arr)
			{
				var result = ImGuiNative.ImBitArrayTestBit(nativeArr, n);
				return result != 0;
			}
		}

		public static bool ImCharIsBlankA(bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			var result = ImGuiNative.ImCharIsBlankA(native_c);
			return result != 0;
		}

		public static bool ImCharIsBlankW(uint c)
		{
			var result = ImGuiNative.ImCharIsBlankW(c);
			return result != 0;
		}

		public static bool ImCharIsXditA(bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			var result = ImGuiNative.ImCharIsXditA(native_c);
			return result != 0;
		}

		public static void ImClamp(out Vector2 pOut, Vector2 v, Vector2 mn, Vector2 mx)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImClamp(nativePOut, v, mn, mx);
			}
		}

		public static uint ImCountSetBits(uint v)
		{
			return ImGuiNative.ImCountSetBits(v);
		}

		public static float ImDot(Vector2 a, Vector2 b)
		{
			return ImGuiNative.ImDot(a, b);
		}

		public static float ImExponentialMovingAverage(float avg, float sample, int n)
		{
			return ImGuiNative.ImExponentialMovingAverage(avg, sample, n);
		}

		public static bool ImFileClose(IntPtr file)
		{
			var result = ImGuiNative.ImFileClose((void*)file);
			return result != 0;
		}

		public static ulong ImFileGetSize(IntPtr file)
		{
			return ImGuiNative.ImFileGetSize((void*)file);
		}

		public static IntPtr ImFileLoadToMemory(ReadOnlySpan<byte> filename, ReadOnlySpan<byte> mode, out uint outFileSize, int paddingBytes)
		{
			fixed (byte* nativeFilename = filename)
			fixed (byte* nativeMode = mode)
			fixed (uint* nativeOutFileSize = &outFileSize)
			{
				return (IntPtr)ImGuiNative.ImFileLoadToMemory(nativeFilename, nativeMode, nativeOutFileSize, paddingBytes);
			}
		}

		public static IntPtr ImFileOpen(ReadOnlySpan<byte> filename, ReadOnlySpan<byte> mode)
		{
			fixed (byte* nativeFilename = filename)
			fixed (byte* nativeMode = mode)
			{
				return (IntPtr)ImGuiNative.ImFileOpen(nativeFilename, nativeMode);
			}
		}

		public static ulong ImFileRead(IntPtr data, ulong size, ulong count, IntPtr file)
		{
			return ImGuiNative.ImFileRead((void*)data, size, count, (void*)file);
		}

		public static ulong ImFileWrite(IntPtr data, ulong size, ulong count, IntPtr file)
		{
			return ImGuiNative.ImFileWrite((void*)data, size, count, (void*)file);
		}

		public static void ImFontAtlasBuildFinish(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ImFontAtlasBuildFinish(atlas);
		}

		public static void ImFontAtlasBuildGetOversampleFactors(ImFontConfigPtr src, out int outOversampleH, out int outOversampleV)
		{
			fixed (int* nativeOutOversampleH = &outOversampleH)
			fixed (int* nativeOutOversampleV = &outOversampleV)
			{
				ImGuiNative.ImFontAtlasBuildGetOversampleFactors(src, nativeOutOversampleH, nativeOutOversampleV);
			}
		}

		public static void ImFontAtlasBuildInit(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ImFontAtlasBuildInit(atlas);
		}

		public static void ImFontAtlasBuildMultiplyCalcLookupTable(out byte outTable, float inMultiplyFactor)
		{
			fixed (byte* nativeOutTable = &outTable)
			{
				ImGuiNative.ImFontAtlasBuildMultiplyCalcLookupTable(nativeOutTable, inMultiplyFactor);
			}
		}

		public static void ImFontAtlasBuildMultiplyRectAlpha8(ref byte table, ref byte pixels, int x, int y, int w, int h, int stride)
		{
			fixed (byte* nativeTable = &table)
			fixed (byte* nativePixels = &pixels)
			{
				ImGuiNative.ImFontAtlasBuildMultiplyRectAlpha8(nativeTable, nativePixels, x, y, w, h, stride);
			}
		}

		public static void ImFontAtlasBuildPackCustomRects(ImFontAtlasPtr atlas, IntPtr stbrpContextOpaque)
		{
			ImGuiNative.ImFontAtlasBuildPackCustomRects(atlas, (void*)stbrpContextOpaque);
		}

		public static void ImFontAtlasBuildRender32BppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, ReadOnlySpan<byte> inStr, bool inMarkerChar, uint inMarkerPixelValue)
		{
			var native_inMarkerChar = inMarkerChar ? (byte)1 : (byte)0;
			fixed (byte* nativeInStr = inStr)
			{
				ImGuiNative.ImFontAtlasBuildRender32BppRectFromString(atlas, x, y, w, h, nativeInStr, native_inMarkerChar, inMarkerPixelValue);
			}
		}

		public static void ImFontAtlasBuildRender8BppRectFromString(ImFontAtlasPtr atlas, int x, int y, int w, int h, ReadOnlySpan<byte> inStr, bool inMarkerChar, bool inMarkerPixelValue)
		{
			var native_inMarkerChar = inMarkerChar ? (byte)1 : (byte)0;
			var native_inMarkerPixelValue = inMarkerPixelValue ? (byte)1 : (byte)0;
			fixed (byte* nativeInStr = inStr)
			{
				ImGuiNative.ImFontAtlasBuildRender8BppRectFromString(atlas, x, y, w, h, nativeInStr, native_inMarkerChar, native_inMarkerPixelValue);
			}
		}

		public static void ImFontAtlasBuildSetupFont(ImFontAtlasPtr atlas, ImFontPtr font, ImFontConfigPtr src, float ascent, float descent)
		{
			ImGuiNative.ImFontAtlasBuildSetupFont(atlas, font, src, ascent, descent);
		}

		public static ImFontBuilderIOPtr ImFontAtlasGetBuilderForStbTruetype()
		{
			return ImGuiNative.ImFontAtlasGetBuilderForStbTruetype();
		}

		public static bool ImFontAtlasGetMouseCursorTexData(ImFontAtlasPtr atlas, ImGuiMouseCursor cursorType, out Vector2 outOffset, out Vector2 outSize, out Vector2 outUvBorder, out Vector2 outUvFill)
		{
			fixed (Vector2* nativeOutOffset = &outOffset)
			fixed (Vector2* nativeOutSize = &outSize)
			fixed (Vector2* nativeOutUvBorder = &outUvBorder)
			fixed (Vector2* nativeOutUvFill = &outUvFill)
			{
				var result = ImGuiNative.ImFontAtlasGetMouseCursorTexData(atlas, cursorType, nativeOutOffset, nativeOutSize, nativeOutUvBorder, nativeOutUvFill);
				return result != 0;
			}
		}

		public static void ImFontAtlasUpdateSourcesPointers(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ImFontAtlasUpdateSourcesPointers(atlas);
		}

		public static int ImFormatString(byte[] buf, uint bufSize, ReadOnlySpan<byte> fmt)
		{
			fixed (byte* nativeBuf = buf)
			fixed (byte* nativeFmt = fmt)
			{
				return ImGuiNative.ImFormatString(nativeBuf, bufSize, nativeFmt);
			}
		}

		public static void ImFormatStringToTempBuffer(out byte* outBuf, out byte* outBufEnd, ReadOnlySpan<byte> fmt)
		{
			fixed (byte** nativeOutBuf = &outBuf)
			fixed (byte** nativeOutBufEnd = &outBufEnd)
			fixed (byte* nativeFmt = fmt)
			{
				ImGuiNative.ImFormatStringToTempBuffer(nativeOutBuf, nativeOutBufEnd, nativeFmt);
			}
		}

		public static uint ImHashData(IntPtr data, uint dataSize, uint seed)
		{
			return ImGuiNative.ImHashData((void*)data, dataSize, seed);
		}

		public static uint ImHashStr(ReadOnlySpan<byte> data, uint dataSize, uint seed)
		{
			fixed (byte* nativeData = data)
			{
				return ImGuiNative.ImHashStr(nativeData, dataSize, seed);
			}
		}

		public static float ImInvLength(Vector2 lhs, float failValue)
		{
			return ImGuiNative.ImInvLength(lhs, failValue);
		}

		public static bool ImIsFloatAboveGuaranteedIntegerPrecision(float f)
		{
			var result = ImGuiNative.ImIsFloatAboveGuaranteedIntegerPrecision(f);
			return result != 0;
		}

		public static void ImLineClosestPoint(out Vector2 pOut, Vector2 a, Vector2 b, Vector2 p)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImLineClosestPoint(nativePOut, a, b, p);
			}
		}

		public static float ImLinearRemapClamp(float s0, float s1, float d0, float d1, float x)
		{
			return ImGuiNative.ImLinearRemapClamp(s0, s1, d0, d1, x);
		}

		public static float ImLinearSweep(float current, float target, float speed)
		{
			return ImGuiNative.ImLinearSweep(current, target, speed);
		}

		public static ImGuiStoragePairPtr ImLowerBound(ImGuiStoragePairPtr inBegin, ImGuiStoragePairPtr inEnd, uint key)
		{
			return ImGuiNative.ImLowerBound(inBegin, inEnd, key);
		}

		public static void ImMax(out Vector2 pOut, Vector2 lhs, Vector2 rhs)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImMax(nativePOut, lhs, rhs);
			}
		}

		public static void ImMin(out Vector2 pOut, Vector2 lhs, Vector2 rhs)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImMin(nativePOut, lhs, rhs);
			}
		}

		public static int ImModPositive(int a, int b)
		{
			return ImGuiNative.ImModPositive(a, b);
		}

		public static void ImMul(out Vector2 pOut, Vector2 lhs, Vector2 rhs)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImMul(nativePOut, lhs, rhs);
			}
		}

		public static string ImParseFormatFindEnd(ReadOnlySpan<byte> format)
		{
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.ImParseFormatFindEnd(nativeFormat);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static string ImParseFormatFindStart(ReadOnlySpan<byte> format)
		{
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.ImParseFormatFindStart(nativeFormat);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static int ImParseFormatPrecision(ReadOnlySpan<byte> format, int defaultValue)
		{
			fixed (byte* nativeFormat = format)
			{
				return ImGuiNative.ImParseFormatPrecision(nativeFormat, defaultValue);
			}
		}

		public static void ImParseFormatSanitizeForPrinting(ReadOnlySpan<byte> fmtIn, byte[] fmtOut, uint fmtOutSize)
		{
			fixed (byte* nativeFmtIn = fmtIn)
			fixed (byte* nativeFmtOut = fmtOut)
			{
				ImGuiNative.ImParseFormatSanitizeForPrinting(nativeFmtIn, nativeFmtOut, fmtOutSize);
			}
		}

		public static string ImParseFormatSanitizeForScanning(ReadOnlySpan<byte> fmtIn, byte[] fmtOut, uint fmtOutSize)
		{
			fixed (byte* nativeFmtIn = fmtIn)
			fixed (byte* nativeFmtOut = fmtOut)
			{
				var result = ImGuiNative.ImParseFormatSanitizeForScanning(nativeFmtIn, nativeFmtOut, fmtOutSize);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static string ImParseFormatTrimDecorations(ReadOnlySpan<byte> format, byte[] buf, uint bufSize)
		{
			fixed (byte* nativeFormat = format)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.ImParseFormatTrimDecorations(nativeFormat, nativeBuf, bufSize);
				return Utils.DecodeStringUTF8(result);
			}
		}

		public static void ImQsort(IntPtr _base, uint count, uint sizeOfElement, IgImQsortCompareFunc compareFunc)
		{
			ImGuiNative.ImQsort((void*)_base, count, sizeOfElement, compareFunc);
		}

		public static void ImRotate(out Vector2 pOut, Vector2 v, float cosA, float sinA)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImRotate(nativePOut, v, cosA, sinA);
			}
		}

		public static float ImSaturate(float f)
		{
			return ImGuiNative.ImSaturate(f);
		}

		/// <summary>
		/// Find first non-blank character.<br/>
		/// </summary>
		public static string ImStrSkipBlank(ReadOnlySpan<byte> str)
		{
			fixed (byte* nativeStr = str)
			{
				var result = ImGuiNative.ImStrSkipBlank(nativeStr);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// Remove leading and trailing blanks from a buffer.<br/>
		/// </summary>
		public static void ImStrTrimBlanks(byte[] str)
		{
			fixed (byte* nativeStr = str)
			{
				ImGuiNative.ImStrTrimBlanks(nativeStr);
			}
		}

		/// <summary>
		/// Find beginning-of-line<br/>
		/// </summary>
		public static string ImStrbol(ReadOnlySpan<byte> bufMidLine, ReadOnlySpan<byte> bufBegin)
		{
			fixed (byte* nativeBufMidLine = bufMidLine)
			fixed (byte* nativeBufBegin = bufBegin)
			{
				var result = ImGuiNative.ImStrbol(nativeBufMidLine, nativeBufBegin);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// Find first occurrence of 'c' in string range.<br/>
		/// </summary>
		public static string ImStrchrRange(ReadOnlySpan<byte> strBegin, ReadOnlySpan<byte> strEnd, bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			fixed (byte* nativeStrBegin = strBegin)
			fixed (byte* nativeStrEnd = strEnd)
			{
				var result = ImGuiNative.ImStrchrRange(nativeStrBegin, nativeStrEnd, native_c);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// Duplicate a string.<br/>
		/// </summary>
		public static ref byte ImStrdup(ReadOnlySpan<byte> str)
		{
			fixed (byte* nativeStr = str)
			{
				var nativeResult = ImGuiNative.ImStrdup(nativeStr);
				return ref *(byte*)&nativeResult;
			}
		}

		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.<br/>
		/// </summary>
		public static ref byte ImStrdupcpy(byte[] dst, ref uint pDstSize, ReadOnlySpan<byte> str)
		{
			fixed (byte* nativeDst = dst)
			fixed (uint* nativePDstSize = &pDstSize)
			fixed (byte* nativeStr = str)
			{
				var nativeResult = ImGuiNative.ImStrdupcpy(nativeDst, nativePDstSize, nativeStr);
				return ref *(byte*)&nativeResult;
			}
		}

		/// <summary>
		/// End end-of-line<br/>
		/// </summary>
		public static string ImStreolRange(ReadOnlySpan<byte> str, ReadOnlySpan<byte> strEnd)
		{
			fixed (byte* nativeStr = str)
			fixed (byte* nativeStrEnd = strEnd)
			{
				var result = ImGuiNative.ImStreolRange(nativeStr, nativeStrEnd);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// Case insensitive compare.<br/>
		/// </summary>
		public static int ImStricmp(ReadOnlySpan<byte> str1, ReadOnlySpan<byte> str2)
		{
			fixed (byte* nativeStr1 = str1)
			fixed (byte* nativeStr2 = str2)
			{
				return ImGuiNative.ImStricmp(nativeStr1, nativeStr2);
			}
		}

		/// <summary>
		/// Find a substring in a string range.<br/>
		/// </summary>
		public static string ImStristr(ReadOnlySpan<byte> haystack, ReadOnlySpan<byte> haystackEnd, ReadOnlySpan<byte> needle, ReadOnlySpan<byte> needleEnd)
		{
			fixed (byte* nativeHaystack = haystack)
			fixed (byte* nativeHaystackEnd = haystackEnd)
			fixed (byte* nativeNeedle = needle)
			fixed (byte* nativeNeedleEnd = needleEnd)
			{
				var result = ImGuiNative.ImStristr(nativeHaystack, nativeHaystackEnd, nativeNeedle, nativeNeedleEnd);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// Computer string length (ImWchar string)<br/>
		/// </summary>
		public static int ImStrlenW(ushort[] str)
		{
			fixed (ushort* nativeStr = str)
			{
				return ImGuiNative.ImStrlenW(nativeStr);
			}
		}

		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).<br/>
		/// </summary>
		public static void ImStrncpy(byte[] dst, ReadOnlySpan<byte> src, uint count)
		{
			fixed (byte* nativeDst = dst)
			fixed (byte* nativeSrc = src)
			{
				ImGuiNative.ImStrncpy(nativeDst, nativeSrc, count);
			}
		}

		/// <summary>
		/// Case insensitive compare to a certain count.<br/>
		/// </summary>
		public static int ImStrnicmp(ReadOnlySpan<byte> str1, ReadOnlySpan<byte> str2, uint count)
		{
			fixed (byte* nativeStr1 = str1)
			fixed (byte* nativeStr2 = str2)
			{
				return ImGuiNative.ImStrnicmp(nativeStr1, nativeStr2, count);
			}
		}

		/// <summary>
		/// read one character. return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextCharFromUtf8(out uint outChar, ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd)
		{
			fixed (uint* nativeOutChar = &outChar)
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextCharFromUtf8(nativeOutChar, nativeInText, nativeInTextEnd);
			}
		}

		/// <summary>
		/// return out_buf<br/>
		/// </summary>
		public static string ImTextCharToUtf8(out byte outBuf, uint c)
		{
			fixed (byte* nativeOutBuf = &outBuf)
			{
				var result = ImGuiNative.ImTextCharToUtf8(nativeOutBuf, c);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)<br/>
		/// </summary>
		public static int ImTextCountCharsFromUtf8(ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd)
		{
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextCountCharsFromUtf8(nativeInText, nativeInTextEnd);
			}
		}

		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.<br/>
		/// </summary>
		public static int ImTextCountLines(ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd)
		{
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextCountLines(nativeInText, nativeInTextEnd);
			}
		}

		/// <summary>
		/// return number of bytes to express one char in UTF-8<br/>
		/// </summary>
		public static int ImTextCountUtf8BytesFromChar(ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd)
		{
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextCountUtf8BytesFromChar(nativeInText, nativeInTextEnd);
			}
		}

		/// <summary>
		/// return number of bytes to express string in UTF-8<br/>
		/// </summary>
		public static int ImTextCountUtf8BytesFromStr(ushort[] inText, ushort[] inTextEnd)
		{
			fixed (ushort* nativeInText = inText)
			fixed (ushort* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextCountUtf8BytesFromStr(nativeInText, nativeInTextEnd);
			}
		}

		/// <summary>
		/// return previous UTF-8 code-point.<br/>
		/// </summary>
		public static string ImTextFindPreviousUtf8Codepoint(ReadOnlySpan<byte> inTextStart, ReadOnlySpan<byte> inTextCurr)
		{
			fixed (byte* nativeInTextStart = inTextStart)
			fixed (byte* nativeInTextCurr = inTextCurr)
			{
				var result = ImGuiNative.ImTextFindPreviousUtf8Codepoint(nativeInTextStart, nativeInTextCurr);
				return Utils.DecodeStringUTF8(result);
			}
		}

		/// <summary>
		/// return input UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrFromUtf8(out ushort outBuf, int outBufSize, ReadOnlySpan<byte> inText, ReadOnlySpan<byte> inTextEnd, ref byte* inRemaining)
		{
			fixed (ushort* nativeOutBuf = &outBuf)
			fixed (byte* nativeInText = inText)
			fixed (byte* nativeInTextEnd = inTextEnd)
			fixed (byte** nativeInRemaining = &inRemaining)
			{
				return ImGuiNative.ImTextStrFromUtf8(nativeOutBuf, outBufSize, nativeInText, nativeInTextEnd, nativeInRemaining);
			}
		}

		/// <summary>
		/// return output UTF-8 bytes count<br/>
		/// </summary>
		public static int ImTextStrToUtf8(byte[] outBuf, int outBufSize, ushort[] inText, ushort[] inTextEnd)
		{
			fixed (byte* nativeOutBuf = outBuf)
			fixed (ushort* nativeInText = inText)
			fixed (ushort* nativeInTextEnd = inTextEnd)
			{
				return ImGuiNative.ImTextStrToUtf8(nativeOutBuf, outBufSize, nativeInText, nativeInTextEnd);
			}
		}

		public static bool ImToUpper(bool c)
		{
			var native_c = c ? (byte)1 : (byte)0;
			var result = ImGuiNative.ImToUpper(native_c);
			return result != 0;
		}

		public static float ImTriangleArea(Vector2 a, Vector2 b, Vector2 c)
		{
			return ImGuiNative.ImTriangleArea(a, b, c);
		}

		public static void ImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, out float outU, out float outV, out float outW)
		{
			fixed (float* nativeOutU = &outU)
			fixed (float* nativeOutV = &outV)
			fixed (float* nativeOutW = &outW)
			{
				ImGuiNative.ImTriangleBarycentricCoords(a, b, c, p, nativeOutU, nativeOutV, nativeOutW);
			}
		}

		public static void ImTriangleClosestPoint(out Vector2 pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ImTriangleClosestPoint(nativePOut, a, b, c, p);
			}
		}

		public static bool ImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p)
		{
			var result = ImGuiNative.ImTriangleContainsPoint(a, b, c, p);
			return result != 0;
		}

		public static bool ImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c)
		{
			var result = ImGuiNative.ImTriangleIsClockwise(a, b, c);
			return result != 0;
		}

		public static int ImUpperPowerOfTwo(int v)
		{
			return ImGuiNative.ImUpperPowerOfTwo(v);
		}

		public static bool ImageButtonEx(uint id, ulong userTextureId, Vector2 imageSize, Vector2 uv0, Vector2 uv1, Vector4 bgCol, Vector4 tintCol, ImGuiButtonFlags flags)
		{
			var result = ImGuiNative.ImageButtonEx(id, userTextureId, imageSize, uv0, uv1, bgCol, tintCol, flags);
			return result != 0;
		}

		public static void Initialize()
		{
			ImGuiNative.Initialize();
		}

		public static void InputTextDeactivateHook(uint id)
		{
			ImGuiNative.InputTextDeactivateHook(id);
		}

		public static bool InputTextEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> hint, byte[] buf, int bufSize, Vector2 sizeArg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, IntPtr userData)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeHint = hint)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.InputTextEx(nativeLabel, nativeHint, nativeBuf, bufSize, sizeArg, flags, callback, (void*)userData);
				return result != 0;
			}
		}

		public static bool IsActiveIdUsingNavDir(ImGuiDir dir)
		{
			var result = ImGuiNative.IsActiveIdUsingNavDir(dir);
			return result != 0;
		}

		public static bool IsAliasKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsAliasKey(key);
			return result != 0;
		}

		public static bool IsClippedEx(ImRect bb, uint id)
		{
			var result = ImGuiNative.IsClippedEx(bb, id);
			return result != 0;
		}

		public static bool IsDragDropActive()
		{
			var result = ImGuiNative.IsDragDropActive();
			return result != 0;
		}

		public static bool IsDragDropPayloadBeingAccepted()
		{
			var result = ImGuiNative.IsDragDropPayloadBeingAccepted();
			return result != 0;
		}

		public static bool IsGamepadKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsGamepadKey(key);
			return result != 0;
		}

		/// <summary>
		/// This may be useful to apply workaround that a based on distinguish whenever an item is active as a text input field.<br/>
		/// </summary>
		public static bool IsItemActiveAsInputText()
		{
			var result = ImGuiNative.IsItemActiveAsInputText();
			return result != 0;
		}

		public static bool IsKeyboardKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsKeyboardKey(key);
			return result != 0;
		}

		public static bool IsLrModKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsLrModKey(key);
			return result != 0;
		}

		public static bool IsLegacyKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsLegacyKey(key);
			return result != 0;
		}

		public static bool IsMouseDragPastThreshold(ImGuiMouseButton button, float lockThreshold)
		{
			var result = ImGuiNative.IsMouseDragPastThreshold(button, lockThreshold);
			return result != 0;
		}

		public static bool IsMouseKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsMouseKey(key);
			return result != 0;
		}

		public static bool IsNamedKey(ImGuiKey key)
		{
			var result = ImGuiNative.IsNamedKey(key);
			return result != 0;
		}

		public static bool IsNamedKeyOrMod(ImGuiKey key)
		{
			var result = ImGuiNative.IsNamedKeyOrMod(key);
			return result != 0;
		}

		public static bool IsWindowAbove(ImGuiWindowPtr potentialAbove, ImGuiWindowPtr potentialBelow)
		{
			var result = ImGuiNative.IsWindowAbove(potentialAbove, potentialBelow);
			return result != 0;
		}

		public static bool IsWindowChildOf(ImGuiWindowPtr window, ImGuiWindowPtr potentialParent, bool popupHierarchy, bool dockHierarchy)
		{
			var native_popupHierarchy = popupHierarchy ? (byte)1 : (byte)0;
			var native_dockHierarchy = dockHierarchy ? (byte)1 : (byte)0;
			var result = ImGuiNative.IsWindowChildOf(window, potentialParent, native_popupHierarchy, native_dockHierarchy);
			return result != 0;
		}

		public static bool IsWindowContentHoverable(ImGuiWindowPtr window, ImGuiHoveredFlags flags)
		{
			var result = ImGuiNative.IsWindowContentHoverable(window, flags);
			return result != 0;
		}

		public static bool IsWindowNavFocusable(ImGuiWindowPtr window)
		{
			var result = ImGuiNative.IsWindowNavFocusable(window);
			return result != 0;
		}

		public static bool IsWindowWithinBeginStackOf(ImGuiWindowPtr window, ImGuiWindowPtr potentialParent)
		{
			var result = ImGuiNative.IsWindowWithinBeginStackOf(window, potentialParent);
			return result != 0;
		}

		public static bool ItemAdd(ImRect bb, uint id, ImRectPtr navBb, ImGuiItemFlags extraFlags)
		{
			var result = ImGuiNative.ItemAdd(bb, id, navBb, extraFlags);
			return result != 0;
		}

		public static bool ItemHoverable(ImRect bb, uint id, ImGuiItemFlags itemFlags)
		{
			var result = ImGuiNative.ItemHoverable(bb, id, itemFlags);
			return result != 0;
		}

		public static void KeepAliveID(uint id)
		{
			ImGuiNative.KeepAliveID(id);
		}

		public static string LocalizeGetMsg(ImGuiLocKey key)
		{
			var result = ImGuiNative.LocalizeGetMsg(key);
			return Utils.DecodeStringUTF8(result);
		}

		public static void LocalizeRegisterEntries(ImGuiLocEntryPtr entries, int count)
		{
			ImGuiNative.LocalizeRegisterEntries(entries, count);
		}

		/// <summary>
		/// -&gt; BeginCapture() when we design v2 api, for now stay under the radar by using the old name.<br/>
		/// </summary>
		public static void LogBegin(ImGuiLogFlags flags, int autoOpenDepth)
		{
			ImGuiNative.LogBegin(flags, autoOpenDepth);
		}

		public static void LogRenderedText(Vector2[] refPos, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd)
		{
			fixed (Vector2* nativeRefPos = refPos)
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.LogRenderedText(nativeRefPos, nativeText, nativeTextEnd);
			}
		}

		public static void LogSetNextTextDecoration(ReadOnlySpan<byte> prefix, ReadOnlySpan<byte> suffix)
		{
			fixed (byte* nativePrefix = prefix)
			fixed (byte* nativeSuffix = suffix)
			{
				ImGuiNative.LogSetNextTextDecoration(nativePrefix, nativeSuffix);
			}
		}

		/// <summary>
		/// Start logging/capturing to internal buffer<br/>
		/// </summary>
		public static void LogToBuffer(int autoOpenDepth)
		{
			ImGuiNative.LogToBuffer(autoOpenDepth);
		}

		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.<br/>
		/// </summary>
		public static void MarkItemEdited(uint id)
		{
			ImGuiNative.MarkItemEdited(id);
		}

		public static bool MenuItemEx(ReadOnlySpan<byte> label, ReadOnlySpan<byte> icon, ReadOnlySpan<byte> shortcut, bool selected, bool enabled)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			var native_enabled = enabled ? (byte)1 : (byte)0;
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeIcon = icon)
			fixed (byte* nativeShortcut = shortcut)
			{
				var result = ImGuiNative.MenuItemEx(nativeLabel, nativeIcon, nativeShortcut, native_selected, native_enabled);
				return result != 0;
			}
		}

		public static ImGuiKey MouseButtonToKey(ImGuiMouseButton button)
		{
			return ImGuiNative.MouseButtonToKey(button);
		}

		public static void MultiSelectAddSetAll(ImGuiMultiSelectTempDataPtr ms, bool selected)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			ImGuiNative.MultiSelectAddSetAll(ms, native_selected);
		}

		public static void MultiSelectAddSetRange(ImGuiMultiSelectTempDataPtr ms, bool selected, int rangeDir, long firstItem, long lastItem)
		{
			var native_selected = selected ? (byte)1 : (byte)0;
			ImGuiNative.MultiSelectAddSetRange(ms, native_selected, rangeDir, firstItem, lastItem);
		}

		public static void MultiSelectItemFooter(uint id, ref bool pSelected, ref bool pPressed)
		{
			var nativePSelectedVal = pSelected ? (byte)1 : (byte)0;
			var nativePSelected = &nativePSelectedVal;
			var nativePPressedVal = pPressed ? (byte)1 : (byte)0;
			var nativePPressed = &nativePPressedVal;
			ImGuiNative.MultiSelectItemFooter(id, nativePSelected, nativePPressed);
			pSelected = nativePSelectedVal != 0;
			pPressed = nativePPressedVal != 0;
		}

		public static void MultiSelectItemHeader(uint id, ref bool pSelected, ref ImGuiButtonFlags pButtonFlags)
		{
			var nativePSelectedVal = pSelected ? (byte)1 : (byte)0;
			var nativePSelected = &nativePSelectedVal;
			fixed (ImGuiButtonFlags* nativePButtonFlags = &pButtonFlags)
			{
				ImGuiNative.MultiSelectItemHeader(id, nativePSelected, nativePButtonFlags);
				pSelected = nativePSelectedVal != 0;
			}
		}

		public static void NavClearPreferredPosForAxis(ImGuiAxis axis)
		{
			ImGuiNative.NavClearPreferredPosForAxis(axis);
		}

		public static void NavHhlhtActivated(uint id)
		{
			ImGuiNative.NavHhlhtActivated(id);
		}

		public static void NavInitRequestApplyResult()
		{
			ImGuiNative.NavInitRequestApplyResult();
		}

		public static void NavInitWindow(ImGuiWindowPtr window, bool forceReinit)
		{
			var native_forceReinit = forceReinit ? (byte)1 : (byte)0;
			ImGuiNative.NavInitWindow(window, native_forceReinit);
		}

		public static void NavMoveRequestApplyResult()
		{
			ImGuiNative.NavMoveRequestApplyResult();
		}

		public static bool NavMoveRequestButNoResultYet()
		{
			var result = ImGuiNative.NavMoveRequestButNoResultYet();
			return result != 0;
		}

		public static void NavMoveRequestCancel()
		{
			ImGuiNative.NavMoveRequestCancel();
		}

		public static void NavMoveRequestForward(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags)
		{
			ImGuiNative.NavMoveRequestForward(moveDir, clipDir, moveFlags, scrollFlags);
		}

		public static void NavMoveRequestResolveWithLastItem(ImGuiNavItemDataPtr result)
		{
			ImGuiNative.NavMoveRequestResolveWithLastItem(result);
		}

		public static void NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemDataPtr result, ImGuiTreeNodeStackDataPtr treeNodeData)
		{
			ImGuiNative.NavMoveRequestResolveWithPastTreeNode(result, treeNodeData);
		}

		public static void NavMoveRequestSubmit(ImGuiDir moveDir, ImGuiDir clipDir, ImGuiNavMoveFlags moveFlags, ImGuiScrollFlags scrollFlags)
		{
			ImGuiNative.NavMoveRequestSubmit(moveDir, clipDir, moveFlags, scrollFlags);
		}

		public static void NavMoveRequestTryWrapping(ImGuiWindowPtr window, ImGuiNavMoveFlags moveFlags)
		{
			ImGuiNative.NavMoveRequestTryWrapping(window, moveFlags);
		}

		public static void NavUpdateCurrentWindowIsScrollPushableX()
		{
			ImGuiNative.NavUpdateCurrentWindowIsScrollPushableX();
		}

		public static void OpenPopupEx(uint id, ImGuiPopupFlags popupFlags)
		{
			ImGuiNative.OpenPopupEx(id, popupFlags);
		}

		public static int PlotEx(ImGuiPlotType plotType, ReadOnlySpan<byte> label, IgPlotLinesValuesGetter valuesGetter, IntPtr data, int valuesCount, int valuesOffset, ReadOnlySpan<byte> overlayText, float scaleMin, float scaleMax, Vector2 sizeArg)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeOverlayText = overlayText)
			{
				return ImGuiNative.PlotEx(plotType, nativeLabel, valuesGetter, (void*)data, valuesCount, valuesOffset, nativeOverlayText, scaleMin, scaleMax, sizeArg);
			}
		}

		public static void PopColumnsBackground()
		{
			ImGuiNative.PopColumnsBackground();
		}

		public static void PopFocusScope()
		{
			ImGuiNative.PopFocusScope();
		}

		public static void PushColumnClipRect(int columnIndex)
		{
			ImGuiNative.PushColumnClipRect(columnIndex);
		}

		public static void PushColumnsBackground()
		{
			ImGuiNative.PushColumnsBackground();
		}

		public static void PushFocusScope(uint id)
		{
			ImGuiNative.PushFocusScope(id);
		}

		public static void PushMultiItemsWidths(int components, float widthFull)
		{
			ImGuiNative.PushMultiItemsWidths(components, widthFull);
		}

		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)<br/>
		/// </summary>
		public static void PushOverrideID(uint id)
		{
			ImGuiNative.PushOverrideID(id);
		}

		public static void PushPasswordFont()
		{
			ImGuiNative.PushPasswordFont();
		}

		public static void RemoveContextHook(ImGuiContextPtr context, uint hookToRemove)
		{
			ImGuiNative.RemoveContextHook(context, hookToRemove);
		}

		public static void RemoveSettingsHandler(ReadOnlySpan<byte> typeName)
		{
			fixed (byte* nativeTypeName = typeName)
			{
				ImGuiNative.RemoveSettingsHandler(nativeTypeName);
			}
		}

		public static void RenderArrow(ImDrawListPtr drawList, Vector2 pos, uint col, ImGuiDir dir, float scale)
		{
			ImGuiNative.RenderArrow(drawList, pos, col, dir, scale);
		}

		public static void RenderArrowDockMenu(ImDrawListPtr drawList, Vector2 pMin, float sz, uint col)
		{
			ImGuiNative.RenderArrowDockMenu(drawList, pMin, sz, col);
		}

		public static void RenderArrowPointingAt(ImDrawListPtr drawList, Vector2 pos, Vector2 halfSz, ImGuiDir direction, uint col)
		{
			ImGuiNative.RenderArrowPointingAt(drawList, pos, halfSz, direction, col);
		}

		public static void RenderBullet(ImDrawListPtr drawList, Vector2 pos, uint col)
		{
			ImGuiNative.RenderBullet(drawList, pos, col);
		}

		public static void RenderCheckMark(ImDrawListPtr drawList, Vector2 pos, uint col, float sz)
		{
			ImGuiNative.RenderCheckMark(drawList, pos, col, sz);
		}

		public static void RenderColorRectWithAlphaCheckerboard(ImDrawListPtr drawList, Vector2 pMin, Vector2 pMax, uint fillCol, float gridStep, Vector2 gridOff, float rounding, ImDrawFlags flags)
		{
			ImGuiNative.RenderColorRectWithAlphaCheckerboard(drawList, pMin, pMax, fillCol, gridStep, gridOff, rounding, flags);
		}

		public static void RenderDragDropTargetRect(ImRect bb, ImRect itemClipRect)
		{
			ImGuiNative.RenderDragDropTargetRect(bb, itemClipRect);
		}

		public static void RenderFrame(Vector2 pMin, Vector2 pMax, uint fillCol, bool borders, float rounding)
		{
			var native_borders = borders ? (byte)1 : (byte)0;
			ImGuiNative.RenderFrame(pMin, pMax, fillCol, native_borders, rounding);
		}

		public static void RenderFrameBorder(Vector2 pMin, Vector2 pMax, float rounding)
		{
			ImGuiNative.RenderFrameBorder(pMin, pMax, rounding);
		}

		public static void RenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouseCursor, uint colFill, uint colBorder, uint colShadow)
		{
			ImGuiNative.RenderMouseCursor(pos, scale, mouseCursor, colFill, colBorder, colShadow);
		}

		/// <summary>
		/// Navigation highlight<br/>
		/// </summary>
		public static void RenderNavCursor(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags)
		{
			ImGuiNative.RenderNavCursor(bb, id, flags);
		}

		public static void RenderRectFilledRangeH(ImDrawListPtr drawList, ImRect rect, uint col, float xStartNorm, float xEndNorm, float rounding)
		{
			ImGuiNative.RenderRectFilledRangeH(drawList, rect, col, xStartNorm, xEndNorm, rounding);
		}

		public static void RenderRectFilledWithHole(ImDrawListPtr drawList, ImRect outer, ImRect inner, uint col, float rounding)
		{
			ImGuiNative.RenderRectFilledWithHole(drawList, outer, inner, col, rounding);
		}

		public static void RenderText(Vector2 pos, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, bool hideTextAfterHash)
		{
			var native_hideTextAfterHash = hideTextAfterHash ? (byte)1 : (byte)0;
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.RenderText(pos, nativeText, nativeTextEnd, native_hideTextAfterHash);
			}
		}

		public static void RenderTextClipped(Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown, Vector2 align, ImRectPtr clipRect)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClipped(posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextClippedEx(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown, Vector2 align, ImRectPtr clipRect)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextClippedEx(drawList, posMin, posMax, nativeText, nativeTextEnd, nativeTextSizeIfKnown, align, clipRect);
			}
		}

		public static void RenderTextEllipsis(ImDrawListPtr drawList, Vector2 posMin, Vector2 posMax, float clipMaxX, float ellipsisMaxX, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, Vector2[] textSizeIfKnown)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			fixed (Vector2* nativeTextSizeIfKnown = textSizeIfKnown)
			{
				ImGuiNative.RenderTextEllipsis(drawList, posMin, posMax, clipMaxX, ellipsisMaxX, nativeText, nativeTextEnd, nativeTextSizeIfKnown);
			}
		}

		public static void RenderTextWrapped(Vector2 pos, ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, float wrapWidth)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.RenderTextWrapped(pos, nativeText, nativeTextEnd, wrapWidth);
			}
		}

		public static void ScaleWindowsInViewport(ImGuiViewportPPtr viewport, float scale)
		{
			ImGuiNative.ScaleWindowsInViewport(viewport, scale);
		}

		public static void ScrollToBringRectIntoView(ImGuiWindowPtr window, ImRect rect)
		{
			ImGuiNative.ScrollToBringRectIntoView(window, rect);
		}

		public static void ScrollToItem(ImGuiScrollFlags flags)
		{
			ImGuiNative.ScrollToItem(flags);
		}

		public static void ScrollToRect(ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
		{
			ImGuiNative.ScrollToRect(window, rect, flags);
		}

		public static void ScrollToRectEx(out Vector2 pOut, ImGuiWindowPtr window, ImRect rect, ImGuiScrollFlags flags)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.ScrollToRectEx(nativePOut, window, rect, flags);
			}
		}

		public static void Scrollbar(ImGuiAxis axis)
		{
			ImGuiNative.Scrollbar(axis);
		}

		public static bool ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, ref long pScrollV, long availV, long contentsV, ImDrawFlags drawRoundingFlags)
		{
			fixed (long* nativePScrollV = &pScrollV)
			{
				var result = ImGuiNative.ScrollbarEx(bb, id, axis, nativePScrollV, availV, contentsV, drawRoundingFlags);
				return result != 0;
			}
		}

		public static void SeparatorEx(ImGuiSeparatorFlags flags, float thickness)
		{
			ImGuiNative.SeparatorEx(flags, thickness);
		}

		public static void SeparatorTextEx(uint id, ReadOnlySpan<byte> label, ReadOnlySpan<byte> labelEnd, float extraWidth)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeLabelEnd = labelEnd)
			{
				ImGuiNative.SeparatorTextEx(id, nativeLabel, nativeLabelEnd, extraWidth);
			}
		}

		public static void SetActiveID(uint id, ImGuiWindowPtr window)
		{
			ImGuiNative.SetActiveID(id, window);
		}

		public static void SetActiveIdUsingAllKeyboardKeys()
		{
			ImGuiNative.SetActiveIdUsingAllKeyboardKeys();
		}

		public static void SetCurrentFont(ImFontPtr font)
		{
			ImGuiNative.SetCurrentFont(font);
		}

		public static void SetCurrentViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
		{
			ImGuiNative.SetCurrentViewport(window, viewport);
		}

		public static void SetFocusID(uint id, ImGuiWindowPtr window)
		{
			ImGuiNative.SetFocusID(id, window);
		}

		public static void SetHoveredID(uint id)
		{
			ImGuiNative.SetHoveredID(id);
		}

		public static void SetKeyOwner(ImGuiKey key, uint ownerId, ImGuiInputFlags flags)
		{
			ImGuiNative.SetKeyOwner(key, ownerId, flags);
		}

		public static void SetKeyOwnersForKeyChord(int key, uint ownerId, ImGuiInputFlags flags)
		{
			ImGuiNative.SetKeyOwnersForKeyChord(key, ownerId, flags);
		}

		public static void SetLastItemData(uint itemId, ImGuiItemFlags itemFlags, ImGuiItemStatusFlags statusFlags, ImRect itemRect)
		{
			ImGuiNative.SetLastItemData(itemId, itemFlags, statusFlags, itemRect);
		}

		public static void SetNavCursorVisibleAfterMove()
		{
			ImGuiNative.SetNavCursorVisibleAfterMove();
		}

		public static void SetNavFocusScope(uint focusScopeId)
		{
			ImGuiNative.SetNavFocusScope(focusScopeId);
		}

		public static void SetNavID(uint id, ImGuiNavLayer navLayer, uint focusScopeId, ImRect rectRel)
		{
			ImGuiNative.SetNavID(id, navLayer, focusScopeId, rectRel);
		}

		public static void SetNavWindow(ImGuiWindowPtr window)
		{
			ImGuiNative.SetNavWindow(window);
		}

		public static void SetNextItemRefVal(ImGuiDataType dataType, IntPtr pData)
		{
			ImGuiNative.SetNextItemRefVal(dataType, (void*)pData);
		}

		public static void SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags)
		{
			ImGuiNative.SetNextWindowRefreshPolicy(flags);
		}

		/// <summary>
		/// owner_id needs to be explicit and cannot be 0<br/>
		/// </summary>
		public static bool SetShortcutRouting(int keyChord, ImGuiInputFlags flags, uint ownerId)
		{
			var result = ImGuiNative.SetShortcutRouting(keyChord, flags, ownerId);
			return result != 0;
		}

		public static void SetWindowClipRectBeforeSetChannel(ImGuiWindowPtr window, ImRect clipRect)
		{
			ImGuiNative.SetWindowClipRectBeforeSetChannel(window, clipRect);
		}

		public static void SetWindowDock(ImGuiWindowPtr window, uint dockId, ImGuiCond cond)
		{
			ImGuiNative.SetWindowDock(window, dockId, cond);
		}

		public static void SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindowPtr window)
		{
			ImGuiNative.SetWindowHiddenAndSkipItemsForCurrentFrame(window);
		}

		public static void SetWindowHitTestHole(ImGuiWindowPtr window, Vector2 pos, Vector2 size)
		{
			ImGuiNative.SetWindowHitTestHole(window, pos, size);
		}

		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.<br/>
		/// </summary>
		public static void SetWindowParentWindowForFocusRoute(ImGuiWindowPtr window, ImGuiWindowPtr parentWindow)
		{
			ImGuiNative.SetWindowParentWindowForFocusRoute(window, parentWindow);
		}

		public static void SetWindowViewport(ImGuiWindowPtr window, ImGuiViewportPPtr viewport)
		{
			ImGuiNative.SetWindowViewport(window, viewport);
		}

		public static void ShadeVertsLinearColorGradientKeepAlpha(ImDrawListPtr drawList, int vertStartIdx, int vertEndIdx, Vector2 gradientP0, Vector2 gradientP1, uint col0, uint col1)
		{
			ImGuiNative.ShadeVertsLinearColorGradientKeepAlpha(drawList, vertStartIdx, vertEndIdx, gradientP0, gradientP1, col0, col1);
		}

		public static void ShadeVertsLinearUV(ImDrawListPtr drawList, int vertStartIdx, int vertEndIdx, Vector2 a, Vector2 b, Vector2 uvA, Vector2 uvB, bool clamp)
		{
			var native_clamp = clamp ? (byte)1 : (byte)0;
			ImGuiNative.ShadeVertsLinearUV(drawList, vertStartIdx, vertEndIdx, a, b, uvA, uvB, native_clamp);
		}

		public static void ShadeVertsTransformPos(ImDrawListPtr drawList, int vertStartIdx, int vertEndIdx, Vector2 pivotIn, float cosA, float sinA, Vector2 pivotOut)
		{
			ImGuiNative.ShadeVertsTransformPos(drawList, vertStartIdx, vertEndIdx, pivotIn, cosA, sinA, pivotOut);
		}

		public static void ShowFontAtlas(ImFontAtlasPtr atlas)
		{
			ImGuiNative.ShowFontAtlas(atlas);
		}

		public static void ShrinkWidths(ImGuiShrinkWidthItemPtr items, int count, float widthExcess)
		{
			ImGuiNative.ShrinkWidths(items, count, widthExcess);
		}

		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().<br/>
		/// </summary>
		public static void Shutdown()
		{
			ImGuiNative.Shutdown();
		}

		public static bool SliderBehavior(ImRect bb, uint id, ImGuiDataType dataType, IntPtr pV, IntPtr pMin, IntPtr pMax, ReadOnlySpan<byte> format, ImGuiSliderFlags flags, ImRectPtr outGrabBb)
		{
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.SliderBehavior(bb, id, dataType, (void*)pV, (void*)pMin, (void*)pMax, nativeFormat, flags, outGrabBb);
				return result != 0;
			}
		}

		public static bool SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, ref float size1, ref float size2, float minSize1, float minSize2, float hoverExtend, float hoverVisibilityDelay, uint bgCol)
		{
			fixed (float* nativeSize1 = &size1)
			fixed (float* nativeSize2 = &size2)
			{
				var result = ImGuiNative.SplitterBehavior(bb, id, axis, nativeSize1, nativeSize2, minSize1, minSize2, hoverExtend, hoverVisibilityDelay, bgCol);
				return result != 0;
			}
		}

		public static void StartMouseMovingWindow(ImGuiWindowPtr window)
		{
			ImGuiNative.StartMouseMovingWindow(window);
		}

		public static void StartMouseMovingWindowOrNode(ImGuiWindowPtr window, ImGuiDockNodePtr node, bool undock)
		{
			var native_undock = undock ? (byte)1 : (byte)0;
			ImGuiNative.StartMouseMovingWindowOrNode(window, node, native_undock);
		}

		public static void TabBarAddTab(ImGuiTabBarPtr tabBar, ImGuiTabItemFlags tabFlags, ImGuiWindowPtr window)
		{
			ImGuiNative.TabBarAddTab(tabBar, tabFlags, window);
		}

		public static void TabBarCloseTab(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			ImGuiNative.TabBarCloseTab(tabBar, tab);
		}

		public static ImGuiTabItemPtr TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBarPtr tabBar)
		{
			return ImGuiNative.TabBarFindMostRecentlySelectedTabForActiveWindow(tabBar);
		}

		public static ImGuiTabItemPtr TabBarFindTabByID(ImGuiTabBarPtr tabBar, uint tabId)
		{
			return ImGuiNative.TabBarFindTabByID(tabBar, tabId);
		}

		public static ImGuiTabItemPtr TabBarFindTabByOrder(ImGuiTabBarPtr tabBar, int order)
		{
			return ImGuiNative.TabBarFindTabByOrder(tabBar, order);
		}

		public static ImGuiTabItemPtr TabBarGetCurrentTab(ImGuiTabBarPtr tabBar)
		{
			return ImGuiNative.TabBarGetCurrentTab(tabBar);
		}

		public static string TabBarGetTabName(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			var result = ImGuiNative.TabBarGetTabName(tabBar, tab);
			return Utils.DecodeStringUTF8(result);
		}

		public static int TabBarGetTabOrder(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab)
		{
			return ImGuiNative.TabBarGetTabOrder(tabBar, tab);
		}

		public static bool TabBarProcessReorder(ImGuiTabBarPtr tabBar)
		{
			var result = ImGuiNative.TabBarProcessReorder(tabBar);
			return result != 0;
		}

		public static void TabBarQueueReorder(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab, int offset)
		{
			ImGuiNative.TabBarQueueReorder(tabBar, tab, offset);
		}

		public static void TabBarQueueReorderFromMousePos(ImGuiTabBarPtr tabBar, ImGuiTabItemPtr tab, Vector2 mousePos)
		{
			ImGuiNative.TabBarQueueReorderFromMousePos(tabBar, tab, mousePos);
		}

		public static void TabBarRemoveTab(ImGuiTabBarPtr tabBar, uint tabId)
		{
			ImGuiNative.TabBarRemoveTab(tabBar, tabId);
		}

		public static void TabItemBackground(ImDrawListPtr drawList, ImRect bb, ImGuiTabItemFlags flags, uint col)
		{
			ImGuiNative.TabItemBackground(drawList, bb, flags, col);
		}

		public static bool TabItemEx(ImGuiTabBarPtr tabBar, ReadOnlySpan<byte> label, ref bool pOpen, ImGuiTabItemFlags flags, ImGuiWindowPtr dockedWindow)
		{
			var nativePOpenVal = pOpen ? (byte)1 : (byte)0;
			var nativePOpen = &nativePOpenVal;
			fixed (byte* nativeLabel = label)
			{
				var result = ImGuiNative.TabItemEx(tabBar, nativeLabel, nativePOpen, flags, dockedWindow);
				pOpen = nativePOpenVal != 0;
				return result != 0;
			}
		}

		public static void TabItemLabelAndCloseButton(ImDrawListPtr drawList, ImRect bb, ImGuiTabItemFlags flags, Vector2 framePadding, ReadOnlySpan<byte> label, uint tabId, uint closeButtonId, bool isContentsVisible, ref bool outJustClosed, ref bool outTextClipped)
		{
			var native_isContentsVisible = isContentsVisible ? (byte)1 : (byte)0;
			var nativeOutJustClosedVal = outJustClosed ? (byte)1 : (byte)0;
			var nativeOutJustClosed = &nativeOutJustClosedVal;
			var nativeOutTextClippedVal = outTextClipped ? (byte)1 : (byte)0;
			var nativeOutTextClipped = &nativeOutTextClippedVal;
			fixed (byte* nativeLabel = label)
			{
				ImGuiNative.TabItemLabelAndCloseButton(drawList, bb, flags, framePadding, nativeLabel, tabId, closeButtonId, native_isContentsVisible, nativeOutJustClosed, nativeOutTextClipped);
				outJustClosed = nativeOutJustClosedVal != 0;
				outTextClipped = nativeOutTextClippedVal != 0;
			}
		}

		public static void TabItemSpacing(ReadOnlySpan<byte> strId, ImGuiTabItemFlags flags, float width)
		{
			fixed (byte* nativeStrId = strId)
			{
				ImGuiNative.TabItemSpacing(nativeStrId, flags, width);
			}
		}

		public static void TableAngledHeadersRowEx(uint rowId, float angle, float maxLabelWidth, ImGuiTableHeaderDataPtr data, int dataCount)
		{
			ImGuiNative.TableAngledHeadersRowEx(rowId, angle, maxLabelWidth, data, dataCount);
		}

		public static void TableBeginApplyRequests(ImGuiTablePtr table)
		{
			ImGuiNative.TableBeginApplyRequests(table);
		}

		public static void TableBeginCell(ImGuiTablePtr table, int columnN)
		{
			ImGuiNative.TableBeginCell(table, columnN);
		}

		public static bool TableBeginContextMenuPopup(ImGuiTablePtr table)
		{
			var result = ImGuiNative.TableBeginContextMenuPopup(table);
			return result != 0;
		}

		public static void TableBeginInitMemory(ImGuiTablePtr table, int columnsCount)
		{
			ImGuiNative.TableBeginInitMemory(table, columnsCount);
		}

		public static void TableBeginRow(ImGuiTablePtr table)
		{
			ImGuiNative.TableBeginRow(table);
		}

		public static float TableCalcMaxColumnWidth(ImGuiTablePtr table, int columnN)
		{
			return ImGuiNative.TableCalcMaxColumnWidth(table, columnN);
		}

		public static void TableDrawBorders(ImGuiTablePtr table)
		{
			ImGuiNative.TableDrawBorders(table);
		}

		public static void TableDrawDefaultContextMenu(ImGuiTablePtr table, ImGuiTableFlags flagsForSectionToDisplay)
		{
			ImGuiNative.TableDrawDefaultContextMenu(table, flagsForSectionToDisplay);
		}

		public static void TableEndCell(ImGuiTablePtr table)
		{
			ImGuiNative.TableEndCell(table);
		}

		public static void TableEndRow(ImGuiTablePtr table)
		{
			ImGuiNative.TableEndRow(table);
		}

		public static ImGuiTablePtr TableFindByID(uint id)
		{
			return ImGuiNative.TableFindByID(id);
		}

		public static void TableFixColumnSortDirection(ImGuiTablePtr table, ImGuiTableColumnPtr column)
		{
			ImGuiNative.TableFixColumnSortDirection(table, column);
		}

		public static void TableGcCompactSettings()
		{
			ImGuiNative.TableGcCompactSettings();
		}

		public static ImGuiTableSettingsPtr TableGetBoundSettings(ImGuiTablePtr table)
		{
			return ImGuiNative.TableGetBoundSettings(table);
		}

		public static void TableGetCellBgRect(ImRectPtr pOut, ImGuiTablePtr table, int columnN)
		{
			ImGuiNative.TableGetCellBgRect(pOut, table, columnN);
		}

		public static ImGuiSortDirection TableGetColumnNextSortDirection(ImGuiTableColumnPtr column)
		{
			return ImGuiNative.TableGetColumnNextSortDirection(column);
		}

		public static uint TableGetColumnResizeID(ImGuiTablePtr table, int columnN, int instanceNo)
		{
			return ImGuiNative.TableGetColumnResizeID(table, columnN, instanceNo);
		}

		public static float TableGetColumnWidthAuto(ImGuiTablePtr table, ImGuiTableColumnPtr column)
		{
			return ImGuiNative.TableGetColumnWidthAuto(table, column);
		}

		public static float TableGetHeaderAngledMaxLabelWidth()
		{
			return ImGuiNative.TableGetHeaderAngledMaxLabelWidth();
		}

		public static float TableGetHeaderRowHeht()
		{
			return ImGuiNative.TableGetHeaderRowHeht();
		}

		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.<br/>
		/// </summary>
		public static int TableGetHoveredRow()
		{
			return ImGuiNative.TableGetHoveredRow();
		}

		public static ImGuiTableInstanceDataPtr TableGetInstanceData(ImGuiTablePtr table, int instanceNo)
		{
			return ImGuiNative.TableGetInstanceData(table, instanceNo);
		}

		public static uint TableGetInstanceID(ImGuiTablePtr table, int instanceNo)
		{
			return ImGuiNative.TableGetInstanceID(table, instanceNo);
		}

		public static void TableLoadSettings(ImGuiTablePtr table)
		{
			ImGuiNative.TableLoadSettings(table);
		}

		public static void TableMergeDrawChannels(ImGuiTablePtr table)
		{
			ImGuiNative.TableMergeDrawChannels(table);
		}

		public static void TableOpenContextMenu(int columnN)
		{
			ImGuiNative.TableOpenContextMenu(columnN);
		}

		public static void TablePopBackgroundChannel()
		{
			ImGuiNative.TablePopBackgroundChannel();
		}

		public static void TablePushBackgroundChannel()
		{
			ImGuiNative.TablePushBackgroundChannel();
		}

		public static void TableRemove(ImGuiTablePtr table)
		{
			ImGuiNative.TableRemove(table);
		}

		public static void TableResetSettings(ImGuiTablePtr table)
		{
			ImGuiNative.TableResetSettings(table);
		}

		public static void TableSaveSettings(ImGuiTablePtr table)
		{
			ImGuiNative.TableSaveSettings(table);
		}

		public static void TableSetColumnSortDirection(int columnN, ImGuiSortDirection sortDirection, bool appendToSortSpecs)
		{
			var native_appendToSortSpecs = appendToSortSpecs ? (byte)1 : (byte)0;
			ImGuiNative.TableSetColumnSortDirection(columnN, sortDirection, native_appendToSortSpecs);
		}

		public static void TableSetColumnWidth(int columnN, float width)
		{
			ImGuiNative.TableSetColumnWidth(columnN, width);
		}

		public static void TableSetColumnWidthAutoAll(ImGuiTablePtr table)
		{
			ImGuiNative.TableSetColumnWidthAutoAll(table);
		}

		public static void TableSetColumnWidthAutoSingle(ImGuiTablePtr table, int columnN)
		{
			ImGuiNative.TableSetColumnWidthAutoSingle(table, columnN);
		}

		public static void TableSettingsAddSettingsHandler()
		{
			ImGuiNative.TableSettingsAddSettingsHandler();
		}

		public static ImGuiTableSettingsPtr TableSettingsCreate(uint id, int columnsCount)
		{
			return ImGuiNative.TableSettingsCreate(id, columnsCount);
		}

		public static ImGuiTableSettingsPtr TableSettingsFindByID(uint id)
		{
			return ImGuiNative.TableSettingsFindByID(id);
		}

		public static void TableSetupDrawChannels(ImGuiTablePtr table)
		{
			ImGuiNative.TableSetupDrawChannels(table);
		}

		public static void TableSortSpecsBuild(ImGuiTablePtr table)
		{
			ImGuiNative.TableSortSpecsBuild(table);
		}

		public static void TableSortSpecsSanitize(ImGuiTablePtr table)
		{
			ImGuiNative.TableSortSpecsSanitize(table);
		}

		public static void TableUpdateBorders(ImGuiTablePtr table)
		{
			ImGuiNative.TableUpdateBorders(table);
		}

		public static void TableUpdateColumnsWehtFromWidth(ImGuiTablePtr table)
		{
			ImGuiNative.TableUpdateColumnsWehtFromWidth(table);
		}

		public static void TableUpdateLayout(ImGuiTablePtr table)
		{
			ImGuiNative.TableUpdateLayout(table);
		}

		public static void TeleportMousePos(Vector2 pos)
		{
			ImGuiNative.TeleportMousePos(pos);
		}

		public static bool TempInputIsActive(uint id)
		{
			var result = ImGuiNative.TempInputIsActive(id);
			return result != 0;
		}

		public static bool TempInputScalar(ImRect bb, uint id, ReadOnlySpan<byte> label, ImGuiDataType dataType, IntPtr pData, ReadOnlySpan<byte> format, IntPtr pClampMin, IntPtr pClampMax)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeFormat = format)
			{
				var result = ImGuiNative.TempInputScalar(bb, id, nativeLabel, dataType, (void*)pData, nativeFormat, (void*)pClampMin, (void*)pClampMax);
				return result != 0;
			}
		}

		public static bool TempInputText(ImRect bb, uint id, ReadOnlySpan<byte> label, byte[] buf, int bufSize, ImGuiInputTextFlags flags)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeBuf = buf)
			{
				var result = ImGuiNative.TempInputText(bb, id, nativeLabel, nativeBuf, bufSize, flags);
				return result != 0;
			}
		}

		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'<br/>
		/// </summary>
		public static bool TestKeyOwner(ImGuiKey key, uint ownerId)
		{
			var result = ImGuiNative.TestKeyOwner(key, ownerId);
			return result != 0;
		}

		public static bool TestShortcutRouting(int keyChord, uint ownerId)
		{
			var result = ImGuiNative.TestShortcutRouting(keyChord, ownerId);
			return result != 0;
		}

		public static void TextEx(ReadOnlySpan<byte> text, ReadOnlySpan<byte> textEnd, ImGuiTextFlags flags)
		{
			fixed (byte* nativeText = text)
			fixed (byte* nativeTextEnd = textEnd)
			{
				ImGuiNative.TextEx(nativeText, nativeTextEnd, flags);
			}
		}

		public static void TranslateWindowsInViewport(ImGuiViewportPPtr viewport, Vector2 oldPos, Vector2 newPos, Vector2 oldSize, Vector2 newSize)
		{
			ImGuiNative.TranslateWindowsInViewport(viewport, oldPos, newPos, oldSize, newSize);
		}

		public static bool TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, ReadOnlySpan<byte> label, ReadOnlySpan<byte> labelEnd)
		{
			fixed (byte* nativeLabel = label)
			fixed (byte* nativeLabelEnd = labelEnd)
			{
				var result = ImGuiNative.TreeNodeBehavior(id, flags, nativeLabel, nativeLabelEnd);
				return result != 0;
			}
		}

		public static bool TreeNodeGetOpen(uint storageId)
		{
			var result = ImGuiNative.TreeNodeGetOpen(storageId);
			return result != 0;
		}

		public static void TreeNodeSetOpen(uint storageId, bool open)
		{
			var native_open = open ? (byte)1 : (byte)0;
			ImGuiNative.TreeNodeSetOpen(storageId, native_open);
		}

		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.<br/>
		/// </summary>
		public static bool TreeNodeUpdateNextOpen(uint storageId, ImGuiTreeNodeFlags flags)
		{
			var result = ImGuiNative.TreeNodeUpdateNextOpen(storageId, flags);
			return result != 0;
		}

		public static void TreePushOverrideID(uint id)
		{
			ImGuiNative.TreePushOverrideID(id);
		}

		public static int TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequestPtr req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, IntPtr userData)
		{
			return ImGuiNative.TypingSelectFindBestLeadingMatch(req, itemsCount, getItemNameFunc, (void*)userData);
		}

		public static int TypingSelectFindMatch(ImGuiTypingSelectRequestPtr req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, IntPtr userData, int navItemIdx)
		{
			return ImGuiNative.TypingSelectFindMatch(req, itemsCount, getItemNameFunc, (void*)userData, navItemIdx);
		}

		public static int TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequestPtr req, int itemsCount, IgTypingSelectFindMatchGetItemNameFunc getItemNameFunc, IntPtr userData, int navItemIdx)
		{
			return ImGuiNative.TypingSelectFindNextSingleCharMatch(req, itemsCount, getItemNameFunc, (void*)userData, navItemIdx);
		}

		public static void UpdateHoveredWindowAndCaptureFlags()
		{
			ImGuiNative.UpdateHoveredWindowAndCaptureFlags();
		}

		public static void UpdateInputEvents(bool trickleFastInputs)
		{
			var native_trickleFastInputs = trickleFastInputs ? (byte)1 : (byte)0;
			ImGuiNative.UpdateInputEvents(native_trickleFastInputs);
		}

		public static void UpdateMouseMovingWindowEndFrame()
		{
			ImGuiNative.UpdateMouseMovingWindowEndFrame();
		}

		public static void UpdateMouseMovingWindowNewFrame()
		{
			ImGuiNative.UpdateMouseMovingWindowNewFrame();
		}

		public static void UpdateWindowParentAndRootLinks(ImGuiWindowPtr window, ImGuiWindowFlags flags, ImGuiWindowPtr parentWindow)
		{
			ImGuiNative.UpdateWindowParentAndRootLinks(window, flags, parentWindow);
		}

		public static void UpdateWindowSkipRefresh(ImGuiWindowPtr window)
		{
			ImGuiNative.UpdateWindowSkipRefresh(window);
		}

		public static void WindowPosAbsToRel(out Vector2 pOut, ImGuiWindowPtr window, Vector2 p)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.WindowPosAbsToRel(nativePOut, window, p);
			}
		}

		public static void WindowPosRelToAbs(out Vector2 pOut, ImGuiWindowPtr window, Vector2 p)
		{
			fixed (Vector2* nativePOut = &pOut)
			{
				ImGuiNative.WindowPosRelToAbs(nativePOut, window, p);
			}
		}

		public static void WindowRectAbsToRel(ImRectPtr pOut, ImGuiWindowPtr window, ImRect r)
		{
			ImGuiNative.WindowRectAbsToRel(pOut, window, r);
		}

		public static void WindowRectRelToAbs(ImRectPtr pOut, ImGuiWindowPtr window, ImRect r)
		{
			ImGuiNative.WindowRectRelToAbs(pOut, window, r);
		}

	}
}
