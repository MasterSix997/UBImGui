using System;

namespace SharpImGui
{
	public static class Constants
	{
		public const string IMGUI_DISABLE_OBSOLETE_FUNCTIONS = "";
		public const string IMGUI_DISABLE_OBSOLETE_KEYIO = "";
		public const string IMGUI_VERSION = "1.91.6 WIP";
		public const long IMGUI_VERSION_NUM = 19151;
		public const bool IMGUI_HAS_TABLE = true;
		/// <summary>
		/// Viewport WIP branch
		/// </summary>
		public const bool IMGUI_HAS_VIEWPORT = true;
		/// <summary>
		/// Docking WIP branch
		/// </summary>
		public const bool IMGUI_HAS_DOCK = true;
		/// <summary>
		/// float[3]: Standard type for colors, without alpha. User code may use this type.
		/// </summary>
		public const string IMGUI_PAYLOAD_TYPE_COLOR_3F = "_COL3F";
		/// <summary>
		/// float[4]: Standard type for colors. User code may use this type.
		/// </summary>
		public const string IMGUI_PAYLOAD_TYPE_COLOR_4F = "_COL4F";
		/// <summary>
		/// Invalid Unicode code point (standard value).
		/// </summary>
		public const long IM_UNICODE_CODEPOINT_INVALID = 0xFFFD;
		public const bool IMGUI_API = true;
		public const bool IMGUI_IMPL_API = IMGUI_API;
		/// <summary>
		/// Maximum Unicode code point supported by this build.
		/// </summary>
		public const long IM_UNICODE_CODEPOINT_MAX = 0xFFFF;
		public const long IM_DRAWLIST_TEX_LINES_WIDTH_MAX = 63;
		public const long IM_COL32_R_SHIFT = 0;
		public const long IM_COL32_G_SHIFT = 8;
		public const long IM_COL32_B_SHIFT = 16;
		public const long IM_COL32_A_SHIFT = 24;
		public const long IM_COL32_A_MASK = 0xFF000000;
	}
}
