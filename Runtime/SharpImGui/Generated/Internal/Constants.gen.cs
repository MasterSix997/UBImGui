using System;

namespace SharpImGui.Internal
{
	public static class Constants
	{
		public const string IMGUI_DISABLE_OBSOLETE_FUNCTIONS = "";
		public const string IMGUI_DISABLE_OBSOLETE_KEYIO = "";
		public const string IMGUI_VERSION = "\"1.91.6 WIP\"";
		public const string IMGUI_VERSION_NUM = "19151";
		public const string IMGUI_HAS_TABLE = "";
		public const string IMGUI_HAS_VIEWPORT = "";
		public const string IMGUI_HAS_DOCK = "";
		public const string IMGUI_PAYLOAD_TYPE_COLOR_3F = "\"_COL3F\"";
		public const string IMGUI_PAYLOAD_TYPE_COLOR_4F = "\"_COL4F\"";
		public const string IM_UNICODE_CODEPOINT_INVALID = "0xFFFD";
		public const string IMGUI_API = "";
		public const string IMGUI_IMPL_API = "IMGUI_API";
		public const string IM_UNICODE_CODEPOINT_MAX = "0xFFFF";
		public const string IM_DRAWLIST_TEX_LINES_WIDTH_MAX = "63";
		public const string IM_COL32_R_SHIFT = "0";
		public const string IM_COL32_G_SHIFT = "8";
		public const string IM_COL32_B_SHIFT = "16";
		public const string IM_COL32_A_SHIFT = "24";
		public const string IM_COL32_A_MASK = "0xFF000000";
		public const bool IMGUI_ENABLE_STB_TRUETYPE = true;
		public const string IM_NEWLINE = "\n";
		public const long IM_TABSIZE = 4;
		public const bool IMGUI_CDECL = true;
		/// <summary>
		/// Number of samples in lookup table.
		/// </summary>
		public const long IM_DRAWLIST_ARCFAST_TABLE_SIZE = 48;
		/// <summary>
		/// Payload == ImGuiWindow*
		/// </summary>
		public const string IMGUI_PAYLOAD_TYPE_WINDOW = "_IMWINDOW";
		public const bool IM_PI = true;
		public const long IM_DRAWLIST_CIRCLE_AUTO_SEGMENT_MIN = 4;
		public const long IM_DRAWLIST_CIRCLE_AUTO_SEGMENT_MAX = 512;
		/// <summary>
		/// Sample index _PathArcToFastEx() for 360 angle.
		/// </summary>
		public const long IM_DRAWLIST_ARCFAST_SAMPLE_MAX = IM_DRAWLIST_ARCFAST_TABLE_SIZE;
		public const bool IMSTB_TEXTEDIT_STRING = true;
		public const bool IMSTB_TEXTEDIT_CHARTYPE = true;
		public const bool IMSTB_TEXTEDIT_GETWIDTH_NEWLINE = true;
		public const long IMSTB_TEXTEDIT_UNDOSTATECOUNT = 99;
		public const long IMSTB_TEXTEDIT_UNDOCHARCOUNT = 999;
		public const long ImGuiKey_LegacyNativeKey_BEGIN = 0;
		public const long ImGuiKey_LegacyNativeKey_END = 512;
		public const bool ImGuiKey_Keyboard_BEGIN = true;
		public const bool ImGuiKey_Keyboard_END = true;
		public const bool ImGuiKey_Gamepad_BEGIN = true;
		public const bool ImGuiKey_Gamepad_END = true;
		public const bool ImGuiKey_Mouse_BEGIN = true;
		public const bool ImGuiKey_Mouse_END = true;
		public const bool ImGuiKey_Aliases_BEGIN = ImGuiKey_Mouse_BEGIN;
		public const bool ImGuiKey_Aliases_END = ImGuiKey_Mouse_END;
		public const bool ImGuiKey_NavKeyboardTweakSlow = true;
		public const bool ImGuiKey_NavKeyboardTweakFast = true;
		public const bool ImGuiKey_NavGamepadTweakSlow = true;
		public const bool ImGuiKey_NavGamepadTweakFast = true;
		public const bool ImGuiKey_NavGamepadActivate = true;
		public const bool ImGuiKey_NavGamepadCancel = true;
		public const bool ImGuiKey_NavGamepadMenu = true;
		public const bool ImGuiKey_NavGamepadInput = true;
		/// <summary>
		/// Accept key that have an owner, UNLESS a call to SetKeyOwner() explicitly used ImGuiInputFlags_LockThisFrame or ImGuiInputFlags_LockUntilRelease.
		/// </summary>
		public const bool ImGuiKeyOwner_Any = true;
		/// <summary>
		/// Require key to have no owner.
		/// </summary>
		public const bool ImGuiKeyOwner_NoOwner = true;
		public const bool ImGuiSelectionUserData_Invalid = true;
		/// <summary>
		/// Dock host: background fill
		/// </summary>
		public const long DOCKING_HOST_DRAW_CHANNEL_BG = 0;
		/// <summary>
		/// Dock host: decorations and contents
		/// </summary>
		public const long DOCKING_HOST_DRAW_CHANNEL_FG = 1;
		/// <summary>
		/// Special sentinel code which cannot be used as a regular color.
		/// </summary>
		public const bool IM_COL32_DISABLE = true;
		/// <summary>
		/// May be further lifted
		/// </summary>
		public const long IMGUI_TABLE_MAX_COLUMNS = 512;
	}
}
