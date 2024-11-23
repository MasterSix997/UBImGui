using System;
using UnityEngine;
using System.Runtime.InteropServices;
namespace SharpImGui.Internal
{
	public static unsafe partial class ImGuiInternalNative
	{
		/// <summary>
		/// <para>Helpers: Hashing</para>
		/// </summary>
		/// <summary>
		/// Implied seed = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImHashData")]
		public static extern uint cImHashData(void* data, uint data_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImHashDataEx")]
		public static extern uint cImHashDataEx(void* data, uint data_size, uint seed);
		/// <summary>
		/// Implied data_size = 0, seed = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImHashStr")]
		public static extern uint cImHashStr(byte* data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImHashStrEx")]
		public static extern uint cImHashStrEx(byte* data, uint data_size, uint seed);
		/// <summary>
		/// <para>Helpers: Color Blending</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImAlphaBlendColors")]
		public static extern uint cImAlphaBlendColors(uint col_a, uint col_b);
		/// <summary>
		/// <para>Helpers: Bit manipulation</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImIsPowerOfTwo")]
		public static extern byte cImIsPowerOfTwo(int v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImIsPowerOfTwoImU64")]
		public static extern byte cImIsPowerOfTwoImU64(ulong v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImUpperPowerOfTwo")]
		public static extern int cImUpperPowerOfTwo(int v);
		/// <summary>
		/// <para>Helpers: String</para>
		/// </summary>
		/// <summary>
		/// Case insensitive compare.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStricmp")]
		public static extern int cImStricmp(byte* str1, byte* str2);
		/// <summary>
		/// Case insensitive compare to a certain count.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrnicmp")]
		public static extern int cImStrnicmp(byte* str1, byte* str2, uint count);
		/// <summary>
		/// Copy to a certain count and always zero terminate (strncpy doesn't).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrncpy")]
		public static extern void cImStrncpy(byte* dst, byte* src, uint count);
		/// <summary>
		/// Duplicate a string.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrdup")]
		public static extern byte* cImStrdup(byte* str);
		/// <summary>
		/// Copy in provided buffer, recreate buffer if needed.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrdupcpy")]
		public static extern byte* cImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
		/// <summary>
		/// Find first occurrence of 'c' in string range.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrchrRange")]
		public static extern byte* cImStrchrRange(byte* str_begin, byte* str_end, byte c);
		/// <summary>
		/// End end-of-line
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStreolRange")]
		public static extern byte* cImStreolRange(byte* str, byte* str_end);
		/// <summary>
		/// Find a substring in a string range.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStristr")]
		public static extern byte* cImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
		/// <summary>
		/// Remove leading and trailing blanks from a buffer.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrTrimBlanks")]
		public static extern void cImStrTrimBlanks(byte* str);
		/// <summary>
		/// Find first non-blank character.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrSkipBlank")]
		public static extern byte* cImStrSkipBlank(byte* str);
		/// <summary>
		/// Computer string length (ImWchar string)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrlenW")]
		public static extern int cImStrlenW(ushort* str);
		/// <summary>
		/// Find beginning-of-line
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImStrbol")]
		public static extern byte* cImStrbol(byte* buf_mid_line, byte* buf_begin);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImToUpper")]
		public static extern byte cImToUpper(byte c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImCharIsBlankA")]
		public static extern byte cImCharIsBlankA(byte c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImCharIsBlankW")]
		public static extern byte cImCharIsBlankW(uint c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImCharIsXdigitA")]
		public static extern byte cImCharIsXdigitA(byte c);
		/// <summary>
		/// <para>Helpers: Formatting</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFormatString")]
		public static extern int cImFormatString(byte* buf, uint buf_size, byte* fmt);
		/// <summary>
		/// <para>Helpers: Formatting</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFormatStringUnformatted")]
		public static extern int cImFormatStringUnformatted(byte* buf, uint buf_size, byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFormatStringToTempBuffer")]
		public static extern void cImFormatStringToTempBuffer(byte** out_buf, byte** out_buf_end, byte* fmt);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFormatStringToTempBufferUnformatted")]
		public static extern void cImFormatStringToTempBufferUnformatted(byte** out_buf, byte** out_buf_end, byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImParseFormatFindStart")]
		public static extern byte* cImParseFormatFindStart(byte* format);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImParseFormatFindEnd")]
		public static extern byte* cImParseFormatFindEnd(byte* format);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImParseFormatTrimDecorations")]
		public static extern byte* cImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImParseFormatSanitizeForPrinting")]
		public static extern void cImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImParseFormatSanitizeForScanning")]
		public static extern byte* cImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImParseFormatPrecision")]
		public static extern int cImParseFormatPrecision(byte* format, int default_value);
		/// <summary>
		/// <para>Helpers: UTF-8 &lt;&gt; wchar conversions</para>
		/// </summary>
		/// <summary>
		/// return out_buf
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextCharToUtf8")]
		public static extern byte* cImTextCharToUtf8(byte* out_buf, uint c);
		/// <summary>
		/// return output UTF-8 bytes count
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextStrToUtf8")]
		public static extern int cImTextStrToUtf8(byte* out_buf, int out_buf_size, ushort* in_text, ushort* in_text_end);
		/// <summary>
		/// read one character. return input UTF-8 bytes count
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextCharFromUtf8")]
		public static extern int cImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
		/// <summary>
		/// Implied in_remaining = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextStrFromUtf8")]
		public static extern int cImTextStrFromUtf8(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end);
		/// <summary>
		/// return input UTF-8 bytes count
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextStrFromUtf8Ex")]
		public static extern int cImTextStrFromUtf8Ex(ushort* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
		/// <summary>
		/// return number of UTF-8 code-points (NOT bytes count)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextCountCharsFromUtf8")]
		public static extern int cImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
		/// <summary>
		/// return number of bytes to express one char in UTF-8
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextCountUtf8BytesFromChar")]
		public static extern int cImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
		/// <summary>
		/// return number of bytes to express string in UTF-8
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextCountUtf8BytesFromStr")]
		public static extern int cImTextCountUtf8BytesFromStr(ushort* in_text, ushort* in_text_end);
		/// <summary>
		/// return previous UTF-8 code-point.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextFindPreviousUtf8Codepoint")]
		public static extern byte* cImTextFindPreviousUtf8Codepoint(byte* in_text_start, byte* in_text_curr);
		/// <summary>
		/// return number of lines taken by text. trailing carriage return doesn't count as an extra line.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTextCountLines")]
		public static extern int cImTextCountLines(byte* in_text, byte* in_text_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileOpen")]
		public static extern IntPtr cImFileOpen(byte* filename, byte* mode);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileClose")]
		public static extern byte cImFileClose(IntPtr file);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileGetSize")]
		public static extern ulong cImFileGetSize(IntPtr file);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileRead")]
		public static extern ulong cImFileRead(void* data, ulong size, ulong count, IntPtr file);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileWrite")]
		public static extern ulong cImFileWrite(void* data, ulong size, ulong count, IntPtr file);
		/// <summary>
		/// Implied out_file_size = NULL, padding_bytes = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileLoadToMemory")]
		public static extern void* cImFileLoadToMemory(byte* filename, byte* mode);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFileLoadToMemoryEx")]
		public static extern void* cImFileLoadToMemoryEx(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
		/// <summary>
		/// DragBehaviorT/SliderBehaviorT uses ImPow with either float/double and need the precision
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImPow")]
		public static extern float cImPow(float x, float y);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImPowDouble")]
		public static extern double cImPowDouble(double x, double y);
		/// <summary>
		/// DragBehaviorT/SliderBehaviorT uses ImLog with either float/double and need the precision
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLog")]
		public static extern float cImLog(float x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLogDouble")]
		public static extern double cImLogDouble(double x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImAbs")]
		public static extern int cImAbs(int x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImAbsFloat")]
		public static extern float cImAbsFloat(float x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImAbsDouble")]
		public static extern double cImAbsDouble(double x);
		/// <summary>
		/// Sign operator - returns -1, 0 or 1 based on sign of argument
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImSign")]
		public static extern float cImSign(float x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImSignDouble")]
		public static extern double cImSignDouble(double x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImRsqrtFloat")]
		public static extern float cImRsqrtFloat(float x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImRsqrtDouble")]
		public static extern double cImRsqrtDouble(double x);
		/// <summary>
		/// <para>- Misc maths helpers</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImMin")]
		public static extern Vector2 cImMin(Vector2 lhs, Vector2 rhs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImMax")]
		public static extern Vector2 cImMax(Vector2 lhs, Vector2 rhs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImClamp")]
		public static extern Vector2 cImClamp(Vector2 v, Vector2 mn, Vector2 mx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLerp")]
		public static extern Vector2 cImLerp(Vector2 a, Vector2 b, float t);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLerpImVec2")]
		public static extern Vector2 cImLerpImVec2(Vector2 a, Vector2 b, Vector2 t);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLerpImVec4")]
		public static extern Vector4 cImLerpImVec4(Vector4 a, Vector4 b, float t);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImSaturate")]
		public static extern float cImSaturate(float f);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLengthSqr")]
		public static extern float cImLengthSqr(Vector2 lhs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLengthSqrImVec4")]
		public static extern float cImLengthSqrImVec4(Vector4 lhs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImInvLength")]
		public static extern float cImInvLength(Vector2 lhs, float fail_value);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTrunc")]
		public static extern float cImTrunc(float f);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTruncImVec2")]
		public static extern Vector2 cImTruncImVec2(Vector2 v);
		/// <summary>
		/// Decent replacement for floorf()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFloor")]
		public static extern float cImFloor(float f);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFloorImVec2")]
		public static extern Vector2 cImFloorImVec2(Vector2 v);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImModPositive")]
		public static extern int cImModPositive(int a, int b);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImDot")]
		public static extern float cImDot(Vector2 a, Vector2 b);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImRotate")]
		public static extern Vector2 cImRotate(Vector2 v, float cos_a, float sin_a);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLinearSweep")]
		public static extern float cImLinearSweep(float current, float target, float speed);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLinearRemapClamp")]
		public static extern float cImLinearRemapClamp(float s0, float s1, float d0, float d1, float x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImMul")]
		public static extern Vector2 cImMul(Vector2 lhs, Vector2 rhs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImIsFloatAboveGuaranteedIntegerPrecision")]
		public static extern byte cImIsFloatAboveGuaranteedIntegerPrecision(float f);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImExponentialMovingAverage")]
		public static extern float cImExponentialMovingAverage(float avg, float sample, int n);
		/// <summary>
		/// <para>Helpers: Geometry</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBezierCubicCalc")]
		public static extern Vector2 cImBezierCubicCalc(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
		/// <summary>
		/// For curves with explicit number of segments
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBezierCubicClosestPoint")]
		public static extern Vector2 cImBezierCubicClosestPoint(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
		/// <summary>
		/// For auto-tessellated curves you can use tess_tol = style.CurveTessellationTol
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBezierCubicClosestPointCasteljau")]
		public static extern Vector2 cImBezierCubicClosestPointCasteljau(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBezierQuadraticCalc")]
		public static extern Vector2 cImBezierQuadraticCalc(Vector2 p1, Vector2 p2, Vector2 p3, float t);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLineClosestPoint")]
		public static extern Vector2 cImLineClosestPoint(Vector2 a, Vector2 b, Vector2 p);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTriangleContainsPoint")]
		public static extern byte cImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTriangleClosestPoint")]
		public static extern Vector2 cImTriangleClosestPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTriangleBarycentricCoords")]
		public static extern void cImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTriangleArea")]
		public static extern float cImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImTriangleIsClockwise")]
		public static extern byte cImTriangleIsClockwise(Vector2 a, Vector2 b, Vector2 c);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetCenter")]
		public static extern Vector2 ImRect_GetCenter(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetSize")]
		public static extern Vector2 ImRect_GetSize(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetWidth")]
		public static extern float ImRect_GetWidth(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetHeight")]
		public static extern float ImRect_GetHeight(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetArea")]
		public static extern float ImRect_GetArea(ImRect* self);
		/// <summary>
		/// Top-left
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetTL")]
		public static extern Vector2 ImRect_GetTL(ImRect* self);
		/// <summary>
		/// Top-right
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetTR")]
		public static extern Vector2 ImRect_GetTR(ImRect* self);
		/// <summary>
		/// Bottom-left
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetBL")]
		public static extern Vector2 ImRect_GetBL(ImRect* self);
		/// <summary>
		/// Bottom-right
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_GetBR")]
		public static extern Vector2 ImRect_GetBR(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_Contains")]
		public static extern byte ImRect_Contains(ImRect* self, Vector2 p);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_ContainsImRect")]
		public static extern byte ImRect_ContainsImRect(ImRect* self, ImRect r);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_ContainsWithPad")]
		public static extern byte ImRect_ContainsWithPad(ImRect* self, Vector2 p, Vector2 pad);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_Overlaps")]
		public static extern byte ImRect_Overlaps(ImRect* self, ImRect r);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_Add")]
		public static extern void ImRect_Add(ImRect* self, Vector2 p);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_AddImRect")]
		public static extern void ImRect_AddImRect(ImRect* self, ImRect r);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_Expand")]
		public static extern void ImRect_Expand(ImRect* self, float amount);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_ExpandImVec2")]
		public static extern void ImRect_ExpandImVec2(ImRect* self, Vector2 amount);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_Translate")]
		public static extern void ImRect_Translate(ImRect* self, Vector2 d);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_TranslateX")]
		public static extern void ImRect_TranslateX(ImRect* self, float dx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_TranslateY")]
		public static extern void ImRect_TranslateY(ImRect* self, float dy);
		/// <summary>
		/// Simple version, may lead to an inverted rectangle, which is fine for Contains/Overlaps test but not for display.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_ClipWith")]
		public static extern void ImRect_ClipWith(ImRect* self, ImRect r);
		/// <summary>
		/// Full version, ensure both points are fully clipped.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_ClipWithFull")]
		public static extern void ImRect_ClipWithFull(ImRect* self, ImRect r);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_Floor")]
		public static extern void ImRect_Floor(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_IsInverted")]
		public static extern byte ImRect_IsInverted(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImRect_ToVec4")]
		public static extern Vector4 ImRect_ToVec4(ImRect* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBitArrayGetStorageSizeInBytes")]
		public static extern uint cImBitArrayGetStorageSizeInBytes(int bitcount);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBitArrayClearAllBits")]
		public static extern void cImBitArrayClearAllBits(uint* arr, int bitcount);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBitArrayTestBit")]
		public static extern byte cImBitArrayTestBit(uint* arr, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBitArrayClearBit")]
		public static extern void cImBitArrayClearBit(uint* arr, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBitArraySetBit")]
		public static extern void cImBitArraySetBit(uint* arr, int n);
		/// <summary>
		/// Works on range [n..n2)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImBitArraySetBitRange")]
		public static extern void cImBitArraySetBitRange(uint* arr, int n, int n2);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImBitVector_Create")]
		public static extern void ImBitVector_Create(ImBitVector* self, int sz);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImBitVector_Clear")]
		public static extern void ImBitVector_Clear(ImBitVector* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImBitVector_TestBit")]
		public static extern byte ImBitVector_TestBit(ImBitVector* self, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImBitVector_SetBit")]
		public static extern void ImBitVector_SetBit(ImBitVector* self, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImBitVector_ClearBit")]
		public static extern void ImBitVector_ClearBit(ImBitVector* self, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextIndex_clear")]
		public static extern void ImGuiTextIndex_clear(ImGuiTextIndex* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextIndex_size")]
		public static extern int ImGuiTextIndex_size(ImGuiTextIndex* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextIndex_get_line_begin")]
		public static extern byte* ImGuiTextIndex_get_line_begin(ImGuiTextIndex* self, byte* _base, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextIndex_get_line_end")]
		public static extern byte* ImGuiTextIndex_get_line_end(ImGuiTextIndex* self, byte* _base, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTextIndex_append")]
		public static extern void ImGuiTextIndex_append(ImGuiTextIndex* self, byte* _base, int old_size, int new_size);
		/// <summary>
		/// <para>Helper: ImGuiStorage</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImLowerBound")]
		public static extern ImGuiStoragePair* cImLowerBound(ImGuiStoragePair* in_begin, ImGuiStoragePair* in_end, uint key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawListSharedData_SetCircleTessellationMaxError")]
		public static extern void ImDrawListSharedData_SetCircleTessellationMaxError(ImDrawListSharedData* self, float max_error);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDataVarInfo_GetVarPtr")]
		public static extern void* ImGuiDataVarInfo_GetVarPtr(ImGuiDataVarInfo* self, void* parent);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiMenuColumns_Update")]
		public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiMenuColumns_DeclColumns")]
		public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiMenuColumns_CalcNextTotalWidth")]
		public static extern void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextDeactivatedState_ClearFreeMemory")]
		public static extern void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_ClearText")]
		public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_ClearFreeMemory")]
		public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);
		/// <summary>
		/// Cannot be inline because we call in code in stb_textedit.h implementation
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_OnKeyPressed")]
		public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_OnCharPressed")]
		public static extern void ImGuiInputTextState_OnCharPressed(ImGuiInputTextState* self, uint c);
		/// <summary>
		/// <para>Cursor &amp; Selection</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_CursorAnimReset")]
		public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_CursorClamp")]
		public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_HasSelection")]
		public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_ClearSelection")]
		public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_GetCursorPos")]
		public static extern int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_GetSelectionStart")]
		public static extern int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_GetSelectionEnd")]
		public static extern int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_SelectAll")]
		public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);
		/// <summary>
		/// <para>Reload user buf (WIP #2890)</para>
		/// <para>If you modify underlying user-passed const char* while active you need to call this (InputText V2 may lift this)</para>
		/// <para>  strcpy(my_buf, "hello");</para>
		/// <para>  if (ImGuiInputTextState* state = ImGui::GetInputTextState(id)) // id may be ImGui::GetItemID() is last item</para>
		/// <para>      state-&gt;ReloadUserBufAndSelectAll();</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_ReloadUserBufAndSelectAll")]
		public static extern void ImGuiInputTextState_ReloadUserBufAndSelectAll(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_ReloadUserBufAndKeepSelection")]
		public static extern void ImGuiInputTextState_ReloadUserBufAndKeepSelection(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiInputTextState_ReloadUserBufAndMoveToEnd")]
		public static extern void ImGuiInputTextState_ReloadUserBufAndMoveToEnd(ImGuiInputTextState* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiNextWindowData_ClearFlags")]
		public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);
		/// <summary>
		/// Also cleared manually by ItemAdd()!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiNextItemData_ClearFlags")]
		public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiKeyRoutingTable_Clear")]
		public static extern void ImGuiKeyRoutingTable_Clear(ImGuiKeyRoutingTable* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipperRange_FromIndices")]
		public static extern ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipperRange_FromPositions")]
		public static extern ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiListClipperData_Reset")]
		public static extern void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiNavItemData_Clear")]
		public static extern void ImGuiNavItemData_Clear(ImGuiNavItemData* self);
		/// <summary>
		/// We preserve remaining data for easier debugging
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTypingSelectState_Clear")]
		public static extern void ImGuiTypingSelectState_Clear(ImGuiTypingSelectState* self);
		/// <summary>
		/// Zero-clear except IO as we preserve IO.Requests[] buffer allocation.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiMultiSelectTempData_Clear")]
		public static extern void ImGuiMultiSelectTempData_Clear(ImGuiMultiSelectTempData* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiMultiSelectTempData_ClearIO")]
		public static extern void ImGuiMultiSelectTempData_ClearIO(ImGuiMultiSelectTempData* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsRootNode")]
		public static extern byte ImGuiDockNode_IsRootNode(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsDockSpace")]
		public static extern byte ImGuiDockNode_IsDockSpace(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsFloatingNode")]
		public static extern byte ImGuiDockNode_IsFloatingNode(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsCentralNode")]
		public static extern byte ImGuiDockNode_IsCentralNode(ImGuiDockNode* self);
		/// <summary>
		/// Hidden tab bar can be shown back by clicking the small triangle
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsHiddenTabBar")]
		public static extern byte ImGuiDockNode_IsHiddenTabBar(ImGuiDockNode* self);
		/// <summary>
		/// Never show a tab bar
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsNoTabBar")]
		public static extern byte ImGuiDockNode_IsNoTabBar(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsSplitNode")]
		public static extern byte ImGuiDockNode_IsSplitNode(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsLeafNode")]
		public static extern byte ImGuiDockNode_IsLeafNode(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_IsEmpty")]
		public static extern byte ImGuiDockNode_IsEmpty(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_Rect")]
		public static extern ImRect ImGuiDockNode_Rect(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_SetLocalFlags")]
		public static extern void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiDockNode_UpdateMergedFlags")]
		public static extern void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_ClearRequestFlags")]
		public static extern void ImGuiViewportP_ClearRequestFlags(ImGuiViewportP* self);
		/// <summary>
		/// <para>Calculate work rect pos/size given a set of offset (we have 1 pair of offset for rect locked from last frame data, and 1 pair for currently building rect)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_CalcWorkRectPos")]
		public static extern Vector2 ImGuiViewportP_CalcWorkRectPos(ImGuiViewportP* self, Vector2 inset_min);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_CalcWorkRectSize")]
		public static extern Vector2 ImGuiViewportP_CalcWorkRectSize(ImGuiViewportP* self, Vector2 inset_min, Vector2 inset_max);
		/// <summary>
		/// Update public fields
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_UpdateWorkRect")]
		public static extern void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);
		/// <summary>
		/// <para>Helpers to retrieve ImRect (we don't need to store BuildWorkRect as every access tend to change it, hence the code asymmetry)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_GetMainRect")]
		public static extern ImRect ImGuiViewportP_GetMainRect(ImGuiViewportP* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_GetWorkRect")]
		public static extern ImRect ImGuiViewportP_GetWorkRect(ImGuiViewportP* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiViewportP_GetBuildWorkRect")]
		public static extern ImRect ImGuiViewportP_GetBuildWorkRect(ImGuiViewportP* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindowSettings_GetName")]
		public static extern byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);
		/// <summary>
		/// Implied str_end = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_GetIDStr")]
		public static extern uint ImGuiWindow_GetIDStr(ImGuiWindow* self, byte* str);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_GetIDStrEx")]
		public static extern uint ImGuiWindow_GetIDStrEx(ImGuiWindow* self, byte* str, byte* str_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_GetID")]
		public static extern uint ImGuiWindow_GetID(ImGuiWindow* self, void* ptr);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_GetIDInt")]
		public static extern uint ImGuiWindow_GetIDInt(ImGuiWindow* self, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_GetIDFromPos")]
		public static extern uint ImGuiWindow_GetIDFromPos(ImGuiWindow* self, Vector2 p_abs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_GetIDFromRectangle")]
		public static extern uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);
		/// <summary>
		/// <para>We don't use g.FontSize because the window may be != g.CurrentWindow.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_Rect")]
		public static extern ImRect ImGuiWindow_Rect(ImGuiWindow* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_CalcFontSize")]
		public static extern float ImGuiWindow_CalcFontSize(ImGuiWindow* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_TitleBarRect")]
		public static extern ImRect ImGuiWindow_TitleBarRect(ImGuiWindow* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiWindow_MenuBarRect")]
		public static extern ImRect ImGuiWindow_MenuBarRect(ImGuiWindow* self);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGuiTableSettings_GetColumnSettings")]
		public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);
		/// <summary>
		/// <para>Windows</para>
		/// <para>We should always have a CurrentWindow in the stack (there is an implicit "Debug" window)</para>
		/// <para>If this ever crashes because g.CurrentWindow is NULL, it means that either:</para>
		/// <para>- ImGui::NewFrame() has never been called, which is illegal.</para>
		/// <para>- You are calling ImGui functions after ImGui::EndFrame()/ImGui::Render() and before the next ImGui::NewFrame(), which is also illegal.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIOEx")]
		public static extern ImGuiIO* ImGui_GetIOEx(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetPlatformIOEx")]
		public static extern ImGuiPlatformIO* ImGui_GetPlatformIOEx(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCurrentWindowRead")]
		public static extern ImGuiWindow* ImGui_GetCurrentWindowRead();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCurrentWindow")]
		public static extern ImGuiWindow* ImGui_GetCurrentWindow();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindWindowByID")]
		public static extern ImGuiWindow* ImGui_FindWindowByID(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindWindowByName")]
		public static extern ImGuiWindow* ImGui_FindWindowByName(byte* name);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdateWindowParentAndRootLinks")]
		public static extern void ImGui_UpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdateWindowSkipRefresh")]
		public static extern void ImGui_UpdateWindowSkipRefresh(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcWindowNextAutoFitSize")]
		public static extern Vector2 ImGui_CalcWindowNextAutoFitSize(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowChildOf")]
		public static extern byte ImGui_IsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowWithinBeginStackOf")]
		public static extern byte ImGui_IsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowAbove")]
		public static extern byte ImGui_IsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowNavFocusable")]
		public static extern byte ImGui_IsWindowNavFocusable(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowPosImGuiWindowPtr")]
		public static extern void ImGui_SetWindowPosImGuiWindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowSizeImGuiWindowPtr")]
		public static extern void ImGui_SetWindowSizeImGuiWindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowCollapsedImGuiWindowPtr")]
		public static extern void ImGui_SetWindowCollapsedImGuiWindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowHitTestHole")]
		public static extern void ImGui_SetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowHiddenAndSkipItemsForCurrentFrame")]
		public static extern void ImGui_SetWindowHiddenAndSkipItemsForCurrentFrame(ImGuiWindow* window);
		/// <summary>
		/// You may also use SetNextWindowClass()'s FocusRouteParentWindowId field.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowParentWindowForFocusRoute")]
		public static extern void ImGui_SetWindowParentWindowForFocusRoute(ImGuiWindow* window, ImGuiWindow* parent_window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_WindowRectAbsToRel")]
		public static extern ImRect ImGui_WindowRectAbsToRel(ImGuiWindow* window, ImRect r);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_WindowRectRelToAbs")]
		public static extern ImRect ImGui_WindowRectRelToAbs(ImGuiWindow* window, ImRect r);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_WindowPosAbsToRel")]
		public static extern Vector2 ImGui_WindowPosAbsToRel(ImGuiWindow* window, Vector2 p);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_WindowPosRelToAbs")]
		public static extern Vector2 ImGui_WindowPosRelToAbs(ImGuiWindow* window, Vector2 p);
		/// <summary>
		/// <para>Windows: Display Order and Focus Order</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FocusWindow")]
		public static extern void ImGui_FocusWindow(ImGuiWindow* window, ImGuiFocusRequestFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FocusTopMostWindowUnderOne")]
		public static extern void ImGui_FocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport, ImGuiFocusRequestFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BringWindowToFocusFront")]
		public static extern void ImGui_BringWindowToFocusFront(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BringWindowToDisplayFront")]
		public static extern void ImGui_BringWindowToDisplayFront(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BringWindowToDisplayBack")]
		public static extern void ImGui_BringWindowToDisplayBack(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BringWindowToDisplayBehind")]
		public static extern void ImGui_BringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindWindowDisplayIndex")]
		public static extern int ImGui_FindWindowDisplayIndex(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindBottomMostVisibleWindowWithinBeginStack")]
		public static extern ImGuiWindow* ImGui_FindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
		/// <summary>
		/// <para>Windows: Idle, Refresh Policies [EXPERIMENTAL]</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextWindowRefreshPolicy")]
		public static extern void ImGui_SetNextWindowRefreshPolicy(ImGuiWindowRefreshFlags flags);
		/// <summary>
		/// <para>Fonts, drawing</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCurrentFont")]
		public static extern void ImGui_SetCurrentFont(ImFont* font);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetDefaultFont")]
		public static extern ImFont* ImGui_GetDefaultFont();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetForegroundDrawListImGuiWindowPtr")]
		public static extern ImDrawList* ImGui_GetForegroundDrawListImGuiWindowPtr(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_AddDrawListToDrawDataEx")]
		public static extern void ImGui_AddDrawListToDrawDataEx(ImDrawData* draw_data, ImVector* out_list, ImDrawList* draw_list);
		/// <summary>
		/// <para>Init</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Initialize")]
		public static extern void ImGui_Initialize();
		/// <summary>
		/// Since 1.60 this is a _private_ function. You can call DestroyContext() to destroy the context created by CreateContext().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Shutdown")]
		public static extern void ImGui_Shutdown();
		/// <summary>
		/// <para>NewFrame</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdateInputEvents")]
		public static extern void ImGui_UpdateInputEvents(byte trickle_fast_inputs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdateHoveredWindowAndCaptureFlags")]
		public static extern void ImGui_UpdateHoveredWindowAndCaptureFlags();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindHoveredWindowEx")]
		public static extern void ImGui_FindHoveredWindowEx(Vector2 pos, byte find_first_and_in_any_viewport, ImGuiWindow** out_hovered_window, ImGuiWindow** out_hovered_window_under_moving_window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_StartMouseMovingWindow")]
		public static extern void ImGui_StartMouseMovingWindow(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_StartMouseMovingWindowOrNode")]
		public static extern void ImGui_StartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdateMouseMovingWindowNewFrame")]
		public static extern void ImGui_UpdateMouseMovingWindowNewFrame();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_UpdateMouseMovingWindowEndFrame")]
		public static extern void ImGui_UpdateMouseMovingWindowEndFrame();
		/// <summary>
		/// <para>Generic context hooks</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_AddContextHook")]
		public static extern uint ImGui_AddContextHook(ImGuiContext* context, ImGuiContextHook* hook);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RemoveContextHook")]
		public static extern void ImGui_RemoveContextHook(ImGuiContext* context, uint hook_to_remove);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CallContextHooks")]
		public static extern void ImGui_CallContextHooks(ImGuiContext* context, ImGuiContextHookType type);
		/// <summary>
		/// <para>Viewports</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TranslateWindowsInViewport")]
		public static extern void ImGui_TranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 old_pos, Vector2 new_pos, Vector2 old_size, Vector2 new_size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ScaleWindowsInViewport")]
		public static extern void ImGui_ScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DestroyPlatformWindow")]
		public static extern void ImGui_DestroyPlatformWindow(ImGuiViewportP* viewport);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowViewport")]
		public static extern void ImGui_SetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetCurrentViewport")]
		public static extern void ImGui_SetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetViewportPlatformMonitor")]
		public static extern ImGuiPlatformMonitor* ImGui_GetViewportPlatformMonitor(ImGuiViewport* viewport);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindHoveredViewportFromPlatformWindowStack")]
		public static extern ImGuiViewportP* ImGui_FindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos);
		/// <summary>
		/// <para>Settings</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MarkIniSettingsDirty")]
		public static extern void ImGui_MarkIniSettingsDirty();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MarkIniSettingsDirtyImGuiWindowPtr")]
		public static extern void ImGui_MarkIniSettingsDirtyImGuiWindowPtr(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClearIniSettings")]
		public static extern void ImGui_ClearIniSettings();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_AddSettingsHandler")]
		public static extern void ImGui_AddSettingsHandler(ImGuiSettingsHandler* handler);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RemoveSettingsHandler")]
		public static extern void ImGui_RemoveSettingsHandler(byte* type_name);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindSettingsHandler")]
		public static extern ImGuiSettingsHandler* ImGui_FindSettingsHandler(byte* type_name);
		/// <summary>
		/// <para>Settings - Windows</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CreateNewWindowSettings")]
		public static extern ImGuiWindowSettings* ImGui_CreateNewWindowSettings(byte* name);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindWindowSettingsByID")]
		public static extern ImGuiWindowSettings* ImGui_FindWindowSettingsByID(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindWindowSettingsByWindow")]
		public static extern ImGuiWindowSettings* ImGui_FindWindowSettingsByWindow(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClearWindowSettings")]
		public static extern void ImGui_ClearWindowSettings(byte* name);
		/// <summary>
		/// <para>Localization</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LocalizeRegisterEntries")]
		public static extern void ImGui_LocalizeRegisterEntries(ImGuiLocEntry* entries, int count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LocalizeGetMsg")]
		public static extern byte* ImGui_LocalizeGetMsg(ImGuiLocKey key);
		/// <summary>
		/// <para>Scrolling</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollXImGuiWindowPtr")]
		public static extern void ImGui_SetScrollXImGuiWindowPtr(ImGuiWindow* window, float scroll_x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollYImGuiWindowPtr")]
		public static extern void ImGui_SetScrollYImGuiWindowPtr(ImGuiWindow* window, float scroll_y);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollFromPosXImGuiWindowPtr")]
		public static extern void ImGui_SetScrollFromPosXImGuiWindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetScrollFromPosYImGuiWindowPtr")]
		public static extern void ImGui_SetScrollFromPosYImGuiWindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);
		/// <summary>
		/// <para>Early work-in-progress API (ScrollToItem() will become public)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ScrollToItem")]
		public static extern void ImGui_ScrollToItem(ImGuiScrollFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ScrollToRect")]
		public static extern void ImGui_ScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ScrollToRectEx")]
		public static extern Vector2 ImGui_ScrollToRectEx(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
		/// <summary>
		/// <para>//#ifndef IMGUI_DISABLE_OBSOLETE_FUNCTIONS</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ScrollToBringRectIntoView")]
		public static extern void ImGui_ScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);
		/// <summary>
		/// <para>Basic Accessors</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetItemStatusFlags")]
		public static extern ImGuiItemStatusFlags ImGui_GetItemStatusFlags();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetItemFlags")]
		public static extern ImGuiItemFlags ImGui_GetItemFlags();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetActiveID")]
		public static extern uint ImGui_GetActiveID();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetFocusID")]
		public static extern uint ImGui_GetFocusID();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetActiveID")]
		public static extern void ImGui_SetActiveID(uint id, ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetFocusID")]
		public static extern void ImGui_SetFocusID(uint id, ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClearActiveID")]
		public static extern void ImGui_ClearActiveID();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetHoveredID")]
		public static extern uint ImGui_GetHoveredID();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetHoveredID")]
		public static extern void ImGui_SetHoveredID(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_KeepAliveID")]
		public static extern void ImGui_KeepAliveID(uint id);
		/// <summary>
		/// Mark data associated to given item as "edited", used by IsItemDeactivatedAfterEdit() function.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MarkItemEdited")]
		public static extern void ImGui_MarkItemEdited(uint id);
		/// <summary>
		/// Push given value as-is at the top of the ID stack (whereas PushID combines old and new hashes)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushOverrideID")]
		public static extern void ImGui_PushOverrideID(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIDWithSeedStr")]
		public static extern uint ImGui_GetIDWithSeedStr(byte* str_id_begin, byte* str_id_end, uint seed);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetIDWithSeed")]
		public static extern uint ImGui_GetIDWithSeed(int n, uint seed);
		/// <summary>
		/// <para>Basic Helpers for widget code</para>
		/// </summary>
		/// <summary>
		/// Implied text_baseline_y = -1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemSize")]
		public static extern void ImGui_ItemSize(Vector2 size);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemSizeEx")]
		public static extern void ImGui_ItemSizeEx(Vector2 size, float text_baseline_y);
		/// <summary>
		/// Implied text_baseline_y = -1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemSizeImRect")]
		public static extern void ImGui_ItemSizeImRect(ImRect bb);
		/// <summary>
		/// FIXME: This is a misleading API since we expect CursorPos to be bb.Min.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemSizeImRectEx")]
		public static extern void ImGui_ItemSizeImRectEx(ImRect bb, float text_baseline_y);
		/// <summary>
		/// Implied nav_bb = NULL, extra_flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemAdd")]
		public static extern byte ImGui_ItemAdd(ImRect bb, uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemAddEx")]
		public static extern byte ImGui_ItemAddEx(ImRect bb, uint id, ImRect* nav_bb, ImGuiItemFlags extra_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ItemHoverable")]
		public static extern byte ImGui_ItemHoverable(ImRect bb, uint id, ImGuiItemFlags item_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsWindowContentHoverable")]
		public static extern byte ImGui_IsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsClippedEx")]
		public static extern byte ImGui_IsClippedEx(ImRect bb, uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetLastItemData")]
		public static extern void ImGui_SetLastItemData(uint item_id, ImGuiItemFlags in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcItemSize")]
		public static extern Vector2 ImGui_CalcItemSize(Vector2 size, float default_w, float default_h);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcWrapWidthForPos")]
		public static extern float ImGui_CalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushMultiItemsWidths")]
		public static extern void ImGui_PushMultiItemsWidths(int components, float width_full);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShrinkWidths")]
		public static extern void ImGui_ShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
		/// <summary>
		/// <para>Parameter stacks (shared)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetStyleVarInfo")]
		public static extern ImGuiDataVarInfo* ImGui_GetStyleVarInfo(ImGuiStyleVar idx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDisabledOverrideReenable")]
		public static extern void ImGui_BeginDisabledOverrideReenable();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndDisabledOverrideReenable")]
		public static extern void ImGui_EndDisabledOverrideReenable();
		/// <summary>
		/// <para>Logging/Capture</para>
		/// </summary>
		/// <summary>
		/// -&gt; BeginCapture() when we design v2 api, for now stay under the radar by using the old name.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogBegin")]
		public static extern void ImGui_LogBegin(ImGuiLogFlags flags, int auto_open_depth);
		/// <summary>
		/// Implied auto_open_depth = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogToBuffer")]
		public static extern void ImGui_LogToBuffer();
		/// <summary>
		/// Start logging/capturing to internal buffer
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogToBufferEx")]
		public static extern void ImGui_LogToBufferEx(int auto_open_depth);
		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogRenderedText")]
		public static extern void ImGui_LogRenderedText(Vector2* ref_pos, byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogRenderedTextEx")]
		public static extern void ImGui_LogRenderedTextEx(Vector2* ref_pos, byte* text, byte* text_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_LogSetNextTextDecoration")]
		public static extern void ImGui_LogSetNextTextDecoration(byte* prefix, byte* suffix);
		/// <summary>
		/// <para>Childs</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginChildEx")]
		public static extern byte ImGui_BeginChildEx(byte* name, uint id, Vector2 size_arg, ImGuiChildFlags child_flags, ImGuiWindowFlags window_flags);
		/// <summary>
		/// <para>Popups, Modals</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginPopupEx")]
		public static extern byte ImGui_BeginPopupEx(uint id, ImGuiWindowFlags extra_window_flags);
		/// <summary>
		/// Implied popup_flags = ImGuiPopupFlags_None
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_OpenPopupEx")]
		public static extern void ImGui_OpenPopupEx(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_OpenPopupExEx")]
		public static extern void ImGui_OpenPopupExEx(uint id, ImGuiPopupFlags popup_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClosePopupToLevel")]
		public static extern void ImGui_ClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClosePopupsOverWindow")]
		public static extern void ImGui_ClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClosePopupsExceptModals")]
		public static extern void ImGui_ClosePopupsExceptModals();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsPopupOpenID")]
		public static extern byte ImGui_IsPopupOpenID(uint id, ImGuiPopupFlags popup_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetPopupAllowedExtentRect")]
		public static extern ImRect ImGui_GetPopupAllowedExtentRect(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTopMostPopupModal")]
		public static extern ImGuiWindow* ImGui_GetTopMostPopupModal();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTopMostAndVisiblePopupModal")]
		public static extern ImGuiWindow* ImGui_GetTopMostAndVisiblePopupModal();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindBlockingModal")]
		public static extern ImGuiWindow* ImGui_FindBlockingModal(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindBestWindowPosForPopup")]
		public static extern Vector2 ImGui_FindBestWindowPosForPopup(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindBestWindowPosForPopupEx")]
		public static extern Vector2 ImGui_FindBestWindowPosForPopupEx(Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);
		/// <summary>
		/// <para>Tooltips</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTooltipEx")]
		public static extern byte ImGui_BeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTooltipHidden")]
		public static extern byte ImGui_BeginTooltipHidden();
		/// <summary>
		/// <para>Menus</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginViewportSideBar")]
		public static extern byte ImGui_BeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);
		/// <summary>
		/// Implied enabled = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMenuWithIcon")]
		public static extern byte ImGui_BeginMenuWithIcon(byte* label, byte* icon);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginMenuWithIconEx")]
		public static extern byte ImGui_BeginMenuWithIconEx(byte* label, byte* icon, byte enabled);
		/// <summary>
		/// Implied shortcut = NULL, selected = false, enabled = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MenuItemWithIcon")]
		public static extern byte ImGui_MenuItemWithIcon(byte* label, byte* icon);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MenuItemWithIconEx")]
		public static extern byte ImGui_MenuItemWithIconEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
		/// <summary>
		/// <para>Combos</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginComboPopup")]
		public static extern byte ImGui_BeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginComboPreview")]
		public static extern byte ImGui_BeginComboPreview();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndComboPreview")]
		public static extern void ImGui_EndComboPreview();
		/// <summary>
		/// <para>Keyboard/Gamepad Navigation</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavInitWindow")]
		public static extern void ImGui_NavInitWindow(ImGuiWindow* window, byte force_reinit);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavInitRequestApplyResult")]
		public static extern void ImGui_NavInitRequestApplyResult();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestButNoResultYet")]
		public static extern byte ImGui_NavMoveRequestButNoResultYet();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestSubmit")]
		public static extern void ImGui_NavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestForward")]
		public static extern void ImGui_NavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestResolveWithLastItem")]
		public static extern void ImGui_NavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestResolveWithPastTreeNode")]
		public static extern void ImGui_NavMoveRequestResolveWithPastTreeNode(ImGuiNavItemData* result, ImGuiTreeNodeStackData* tree_node_data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestCancel")]
		public static extern void ImGui_NavMoveRequestCancel();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestApplyResult")]
		public static extern void ImGui_NavMoveRequestApplyResult();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavMoveRequestTryWrapping")]
		public static extern void ImGui_NavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavHighlightActivated")]
		public static extern void ImGui_NavHighlightActivated(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavClearPreferredPosForAxis")]
		public static extern void ImGui_NavClearPreferredPosForAxis(ImGuiAxis axis);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNavCursorVisibleAfterMove")]
		public static extern void ImGui_SetNavCursorVisibleAfterMove();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_NavUpdateCurrentWindowIsScrollPushableX")]
		public static extern void ImGui_NavUpdateCurrentWindowIsScrollPushableX();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNavWindow")]
		public static extern void ImGui_SetNavWindow(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNavID")]
		public static extern void ImGui_SetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNavFocusScope")]
		public static extern void ImGui_SetNavFocusScope(uint focus_scope_id);
		/// <summary>
		/// <para>Focus/Activation</para>
		/// <para>This should be part of a larger set of API: FocusItem(offset = -1), FocusItemByID(id), ActivateItem(offset = -1), ActivateItemByID(id) etc. which are</para>
		/// <para>much harder to design and implement than expected. I have a couple of private branches on this matter but it's not simple. For now implementing the easy ones.</para>
		/// </summary>
		/// <summary>
		/// Focus last item (no selection/activation).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FocusItem")]
		public static extern void ImGui_FocusItem();
		/// <summary>
		/// Activate an item by ID (button, checkbox, tree node etc.). Activation is queued and processed on the next frame when the item is encountered again.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ActivateItemByID")]
		public static extern void ImGui_ActivateItemByID(uint id);
		/// <summary>
		/// <para>Inputs</para>
		/// <para>FIXME: Eventually we should aim to move e.g. IsActiveIdUsingKey() into IsKeyXXX functions.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsNamedKey")]
		public static extern byte ImGui_IsNamedKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsNamedKeyOrMod")]
		public static extern byte ImGui_IsNamedKeyOrMod(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsLegacyKey")]
		public static extern byte ImGui_IsLegacyKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyboardKey")]
		public static extern byte ImGui_IsKeyboardKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsGamepadKey")]
		public static extern byte ImGui_IsGamepadKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseKey")]
		public static extern byte ImGui_IsMouseKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsAliasKey")]
		public static extern byte ImGui_IsAliasKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsLRModKey")]
		public static extern byte ImGui_IsLRModKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FixupKeyChord")]
		public static extern ImGuiKey ImGui_FixupKeyChord(ImGuiKey key_chord);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ConvertSingleModFlagToKey")]
		public static extern ImGuiKey ImGui_ConvertSingleModFlagToKey(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyDataImGuiContextPtr")]
		public static extern ImGuiKeyData* ImGui_GetKeyDataImGuiContextPtr(ImGuiContext* ctx, ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyData")]
		public static extern ImGuiKeyData* ImGui_GetKeyData(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyChordName")]
		public static extern byte* ImGui_GetKeyChordName(ImGuiKey key_chord);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MouseButtonToKey")]
		public static extern ImGuiKey ImGui_MouseButtonToKey(ImGuiMouseButton button);
		/// <summary>
		/// Implied lock_threshold = -1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDragPastThreshold")]
		public static extern byte ImGui_IsMouseDragPastThreshold(ImGuiMouseButton button);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDragPastThresholdEx")]
		public static extern byte ImGui_IsMouseDragPastThresholdEx(ImGuiMouseButton button, float lock_threshold);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyMagnitude2d")]
		public static extern Vector2 ImGui_GetKeyMagnitude2d(ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetNavTweakPressedAmount")]
		public static extern float ImGui_GetNavTweakPressedAmount(ImGuiAxis axis);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcTypematicRepeatAmount")]
		public static extern int ImGui_CalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTypematicRepeatRate")]
		public static extern void ImGui_GetTypematicRepeatRate(ImGuiInputFlags flags, float* repeat_delay, float* repeat_rate);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TeleportMousePos")]
		public static extern void ImGui_TeleportMousePos(Vector2 pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetActiveIdUsingAllKeyboardKeys")]
		public static extern void ImGui_SetActiveIdUsingAllKeyboardKeys();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsActiveIdUsingNavDir")]
		public static extern byte ImGui_IsActiveIdUsingNavDir(ImGuiDir dir);
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
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyOwner")]
		public static extern uint ImGui_GetKeyOwner(ImGuiKey key);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetKeyOwner")]
		public static extern void ImGui_SetKeyOwner(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetKeyOwnersForKeyChord")]
		public static extern void ImGui_SetKeyOwnersForKeyChord(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
		/// <summary>
		/// Set key owner to last item if it is hovered or active. Equivalent to 'if (IsItemHovered() || IsItemActive()) { SetKeyOwner(key, GetItemID());'.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetItemKeyOwnerImGuiInputFlags")]
		public static extern void ImGui_SetItemKeyOwnerImGuiInputFlags(ImGuiKey key, ImGuiInputFlags flags);
		/// <summary>
		/// Test that key is either not owned, either owned by 'owner_id'
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TestKeyOwner")]
		public static extern byte ImGui_TestKeyOwner(ImGuiKey key, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetKeyOwnerData")]
		public static extern ImGuiKeyOwnerData* ImGui_GetKeyOwnerData(ImGuiContext* ctx, ImGuiKey key);
		/// <summary>
		/// <para>[EXPERIMENTAL] High-Level: Input Access functions w/ support for Key/Input Ownership</para>
		/// <para>- Important: legacy IsKeyPressed(ImGuiKey, bool repeat=true) _DEFAULTS_ to repeat, new IsKeyPressed() requires _EXPLICIT_ ImGuiInputFlags_Repeat flag.</para>
		/// <para>- Expected to be later promoted to public API, the prototypes are designed to replace existing ones (since owner_id can default to Any == 0)</para>
		/// <para>- Specifying a value for 'ImGuiID owner' will test that EITHER the key is NOT owned (UNLESS locked), EITHER the key is owned by 'owner'.</para>
		/// <para>  Legacy functions use ImGuiKeyOwner_Any meaning that they typically ignore ownership, unless a call to SetKeyOwner() explicitly used ImGuiInputFlags_LockThisFrame or ImGuiInputFlags_LockUntilRelease.</para>
		/// <para>- Binding generators may want to ignore those for now, or suffix them with Ex() until we decide if this gets moved into public API.</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyDownID")]
		public static extern byte ImGui_IsKeyDownID(ImGuiKey key, uint owner_id);
		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyPressedImGuiInputFlags")]
		public static extern byte ImGui_IsKeyPressedImGuiInputFlags(ImGuiKey key, ImGuiInputFlags flags);
		/// <summary>
		/// Important: when transitioning from old to new IsKeyPressed(): old API has "bool repeat = true", so would default to repeat. New API requiress explicit ImGuiInputFlags_Repeat.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyPressedImGuiInputFlagsEx")]
		public static extern byte ImGui_IsKeyPressedImGuiInputFlagsEx(ImGuiKey key, ImGuiInputFlags flags, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyReleasedID")]
		public static extern byte ImGui_IsKeyReleasedID(ImGuiKey key, uint owner_id);
		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyChordPressedImGuiInputFlags")]
		public static extern byte ImGui_IsKeyChordPressedImGuiInputFlags(ImGuiKey key_chord, ImGuiInputFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsKeyChordPressedImGuiInputFlagsEx")]
		public static extern byte ImGui_IsKeyChordPressedImGuiInputFlagsEx(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDownID")]
		public static extern byte ImGui_IsMouseDownID(ImGuiMouseButton button, uint owner_id);
		/// <summary>
		/// Implied owner_id = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseClickedImGuiInputFlags")]
		public static extern byte ImGui_IsMouseClickedImGuiInputFlags(ImGuiMouseButton button, ImGuiInputFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseClickedImGuiInputFlagsEx")]
		public static extern byte ImGui_IsMouseClickedImGuiInputFlagsEx(ImGuiMouseButton button, ImGuiInputFlags flags, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseReleasedID")]
		public static extern byte ImGui_IsMouseReleasedID(ImGuiMouseButton button, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsMouseDoubleClickedID")]
		public static extern byte ImGui_IsMouseDoubleClickedID(ImGuiMouseButton button, uint owner_id);
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
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShortcutID")]
		public static extern byte ImGui_ShortcutID(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id);
		/// <summary>
		/// owner_id needs to be explicit and cannot be 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetShortcutRouting")]
		public static extern byte ImGui_SetShortcutRouting(ImGuiKey key_chord, ImGuiInputFlags flags, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TestShortcutRouting")]
		public static extern byte ImGui_TestShortcutRouting(ImGuiKey key_chord, uint owner_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetShortcutRoutingData")]
		public static extern ImGuiKeyRoutingData* ImGui_GetShortcutRoutingData(ImGuiKey key_chord);
		/// <summary>
		/// <para>Docking</para>
		/// <para>(some functions are only declared in imgui.cpp, see Docking section)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextInitialize")]
		public static extern void ImGui_DockContextInitialize(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextShutdown")]
		public static extern void ImGui_DockContextShutdown(ImGuiContext* ctx);
		/// <summary>
		/// Use root_id==0 to clear all
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextClearNodes")]
		public static extern void ImGui_DockContextClearNodes(ImGuiContext* ctx, uint root_id, byte clear_settings_refs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextRebuildNodes")]
		public static extern void ImGui_DockContextRebuildNodes(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextNewFrameUpdateUndocking")]
		public static extern void ImGui_DockContextNewFrameUpdateUndocking(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextNewFrameUpdateDocking")]
		public static extern void ImGui_DockContextNewFrameUpdateDocking(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextEndFrame")]
		public static extern void ImGui_DockContextEndFrame(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextGenNodeID")]
		public static extern uint ImGui_DockContextGenNodeID(ImGuiContext* ctx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextQueueDock")]
		public static extern void ImGui_DockContextQueueDock(ImGuiContext* ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextQueueUndockWindow")]
		public static extern void ImGui_DockContextQueueUndockWindow(ImGuiContext* ctx, ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextQueueUndockNode")]
		public static extern void ImGui_DockContextQueueUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
		/// <summary>
		/// Implied clear_persistent_docking_ref = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextProcessUndockWindow")]
		public static extern void ImGui_DockContextProcessUndockWindow(ImGuiContext* ctx, ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextProcessUndockWindowEx")]
		public static extern void ImGui_DockContextProcessUndockWindowEx(ImGuiContext* ctx, ImGuiWindow* window, byte clear_persistent_docking_ref);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextProcessUndockNode")]
		public static extern void ImGui_DockContextProcessUndockNode(ImGuiContext* ctx, ImGuiDockNode* node);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextCalcDropPosForDocking")]
		public static extern byte ImGui_DockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, byte split_outer, Vector2* out_pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockContextFindNodeByID")]
		public static extern ImGuiDockNode* ImGui_DockContextFindNodeByID(ImGuiContext* ctx, uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeWindowMenuHandler_Default")]
		public static extern void ImGui_DockNodeWindowMenuHandler_Default(ImGuiContext* ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeBeginAmendTabBar")]
		public static extern byte ImGui_DockNodeBeginAmendTabBar(ImGuiDockNode* node);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeEndAmendTabBar")]
		public static extern void ImGui_DockNodeEndAmendTabBar();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeGetRootNode")]
		public static extern ImGuiDockNode* ImGui_DockNodeGetRootNode(ImGuiDockNode* node);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeIsInHierarchyOf")]
		public static extern byte ImGui_DockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeGetDepth")]
		public static extern int ImGui_DockNodeGetDepth(ImGuiDockNode* node);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockNodeGetWindowMenuButtonId")]
		public static extern uint ImGui_DockNodeGetWindowMenuButtonId(ImGuiDockNode* node);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowDockNode")]
		public static extern ImGuiDockNode* ImGui_GetWindowDockNode();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowAlwaysWantOwnTabBar")]
		public static extern byte ImGui_GetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDocked")]
		public static extern void ImGui_BeginDocked(ImGuiWindow* window, byte* p_open);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDockableDragDropSource")]
		public static extern void ImGui_BeginDockableDragDropSource(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDockableDragDropTarget")]
		public static extern void ImGui_BeginDockableDragDropTarget(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowDock")]
		public static extern void ImGui_SetWindowDock(ImGuiWindow* window, uint dock_id, ImGuiCond cond);
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
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderDockWindow")]
		public static extern void ImGui_DockBuilderDockWindow(byte* window_name, uint node_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderGetNode")]
		public static extern ImGuiDockNode* ImGui_DockBuilderGetNode(uint node_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderGetCentralNode")]
		public static extern ImGuiDockNode* ImGui_DockBuilderGetCentralNode(uint node_id);
		/// <summary>
		/// Implied node_id = 0, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderAddNode")]
		public static extern uint ImGui_DockBuilderAddNode();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderAddNodeEx")]
		public static extern uint ImGui_DockBuilderAddNodeEx(uint node_id, ImGuiDockNodeFlags flags);
		/// <summary>
		/// Remove node and all its child, undock all windows
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderRemoveNode")]
		public static extern void ImGui_DockBuilderRemoveNode(uint node_id);
		/// <summary>
		/// Implied clear_settings_refs = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderRemoveNodeDockedWindows")]
		public static extern void ImGui_DockBuilderRemoveNodeDockedWindows(uint node_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderRemoveNodeDockedWindowsEx")]
		public static extern void ImGui_DockBuilderRemoveNodeDockedWindowsEx(uint node_id, byte clear_settings_refs);
		/// <summary>
		/// Remove all split/hierarchy. All remaining docked windows will be re-docked to the remaining root node (node_id).
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderRemoveNodeChildNodes")]
		public static extern void ImGui_DockBuilderRemoveNodeChildNodes(uint node_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderSetNodePos")]
		public static extern void ImGui_DockBuilderSetNodePos(uint node_id, Vector2 pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderSetNodeSize")]
		public static extern void ImGui_DockBuilderSetNodeSize(uint node_id, Vector2 size);
		/// <summary>
		/// Create 2 child nodes in this parent node.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderSplitNode")]
		public static extern uint ImGui_DockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderCopyDockSpace")]
		public static extern void ImGui_DockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector* in_window_remap_pairs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderCopyNode")]
		public static extern void ImGui_DockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector* out_node_remap_pairs);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderCopyWindowSettings")]
		public static extern void ImGui_DockBuilderCopyWindowSettings(byte* src_name, byte* dst_name);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DockBuilderFinish")]
		public static extern void ImGui_DockBuilderFinish(uint node_id);
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
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushFocusScope")]
		public static extern void ImGui_PushFocusScope(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopFocusScope")]
		public static extern void ImGui_PopFocusScope();
		/// <summary>
		/// Focus scope we are outputting into, set by PushFocusScope()
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCurrentFocusScope")]
		public static extern uint ImGui_GetCurrentFocusScope();
		/// <summary>
		/// <para>Drag and Drop</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsDragDropActive")]
		public static extern byte ImGui_IsDragDropActive();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginDragDropTargetCustom")]
		public static extern byte ImGui_BeginDragDropTargetCustom(ImRect bb, uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ClearDragDrop")]
		public static extern void ImGui_ClearDragDrop();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_IsDragDropPayloadBeingAccepted")]
		public static extern byte ImGui_IsDragDropPayloadBeingAccepted();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderDragDropTargetRect")]
		public static extern void ImGui_RenderDragDropTargetRect(ImRect bb, ImRect item_clip_rect);
		/// <summary>
		/// <para>Typing-Select API</para>
		/// <para>(provide Windows Explorer style "select items by typing partial name" + "cycle through items by typing same letter" feature)</para>
		/// <para>(this is currently not documented nor used by main library, but should work. See "widgets_typingselect" in imgui_test_suite for usage code. Please let us know if you use this!)</para>
		/// </summary>
		/// <summary>
		/// Implied flags = ImGuiTypingSelectFlags_None
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTypingSelectRequest")]
		public static extern ImGuiTypingSelectRequest* ImGui_GetTypingSelectRequest();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetTypingSelectRequestEx")]
		public static extern ImGuiTypingSelectRequest* ImGui_GetTypingSelectRequestEx(ImGuiTypingSelectFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TypingSelectFindMatch")]
		public static extern int ImGui_TypingSelectFindMatch(ImGuiTypingSelectRequest* req, int items_count, ImGui_TypingSelectFindMatchget_item_name_funcDelegate get_item_name_func, void* user_data, int nav_item_idx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TypingSelectFindNextSingleCharMatch")]
		public static extern int ImGui_TypingSelectFindNextSingleCharMatch(ImGuiTypingSelectRequest* req, int items_count, ImGui_TypingSelectFindNextSingleCharMatchget_item_name_funcDelegate get_item_name_func, void* user_data, int nav_item_idx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TypingSelectFindBestLeadingMatch")]
		public static extern int ImGui_TypingSelectFindBestLeadingMatch(ImGuiTypingSelectRequest* req, int items_count, ImGui_TypingSelectFindBestLeadingMatchget_item_name_funcDelegate get_item_name_func, void* user_data);
		/// <summary>
		/// <para>Box-Select API</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginBoxSelect")]
		public static extern byte ImGui_BeginBoxSelect(ImRect scope_rect, ImGuiWindow* window, uint box_select_id, ImGuiMultiSelectFlags ms_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndBoxSelect")]
		public static extern void ImGui_EndBoxSelect(ImRect scope_rect, ImGuiMultiSelectFlags ms_flags);
		/// <summary>
		/// <para>Multi-Select API</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MultiSelectItemHeader")]
		public static extern void ImGui_MultiSelectItemHeader(uint id, byte* p_selected, ImGuiButtonFlags* p_button_flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MultiSelectItemFooter")]
		public static extern void ImGui_MultiSelectItemFooter(uint id, byte* p_selected, byte* p_pressed);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MultiSelectAddSetAll")]
		public static extern void ImGui_MultiSelectAddSetAll(ImGuiMultiSelectTempData* ms, byte selected);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_MultiSelectAddSetRange")]
		public static extern void ImGui_MultiSelectAddSetRange(ImGuiMultiSelectTempData* ms, byte selected, int range_dir, long first_item, long last_item);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetBoxSelectState")]
		public static extern ImGuiBoxSelectState* ImGui_GetBoxSelectState(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetMultiSelectState")]
		public static extern ImGuiMultiSelectState* ImGui_GetMultiSelectState(uint id);
		/// <summary>
		/// <para>Internal Columns API (this is not exposed because we will encourage transitioning to the Tables API)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetWindowClipRectBeforeSetChannel")]
		public static extern void ImGui_SetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);
		/// <summary>
		/// setup number of columns. use an identifier to distinguish multiple column sets. close with EndColumns().
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginColumns")]
		public static extern void ImGui_BeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);
		/// <summary>
		/// close columns
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndColumns")]
		public static extern void ImGui_EndColumns();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushColumnClipRect")]
		public static extern void ImGui_PushColumnClipRect(int column_index);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PushColumnsBackground")]
		public static extern void ImGui_PushColumnsBackground();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PopColumnsBackground")]
		public static extern void ImGui_PopColumnsBackground();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnsID")]
		public static extern uint ImGui_GetColumnsID(byte* str_id, int count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindOrCreateColumns")]
		public static extern ImGuiOldColumns* ImGui_FindOrCreateColumns(ImGuiWindow* window, uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnOffsetFromNorm")]
		public static extern float ImGui_GetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetColumnNormFromOffset")]
		public static extern float ImGui_GetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
		/// <summary>
		/// <para>Tables: Candidates for public API</para>
		/// </summary>
		/// <summary>
		/// Implied column_n = -1
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableOpenContextMenu")]
		public static extern void ImGui_TableOpenContextMenu();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableOpenContextMenuEx")]
		public static extern void ImGui_TableOpenContextMenuEx(int column_n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetColumnWidth")]
		public static extern void ImGui_TableSetColumnWidth(int column_n, float width);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetColumnSortDirection")]
		public static extern void ImGui_TableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
		/// <summary>
		/// Retrieve *PREVIOUS FRAME* hovered row. This difference with TableGetHoveredColumn() is the reason why this is not public yet.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetHoveredRow")]
		public static extern int ImGui_TableGetHoveredRow();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetHeaderRowHeight")]
		public static extern float ImGui_TableGetHeaderRowHeight();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetHeaderAngledMaxLabelWidth")]
		public static extern float ImGui_TableGetHeaderAngledMaxLabelWidth();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TablePushBackgroundChannel")]
		public static extern void ImGui_TablePushBackgroundChannel();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TablePopBackgroundChannel")]
		public static extern void ImGui_TablePopBackgroundChannel();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableAngledHeadersRowEx")]
		public static extern void ImGui_TableAngledHeadersRowEx(uint row_id, float angle, float max_label_width, ImGuiTableHeaderData* data, int data_count);
		/// <summary>
		/// <para>Tables: Internals</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCurrentTable")]
		public static extern ImGuiTable* ImGui_GetCurrentTable();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableFindByID")]
		public static extern ImGuiTable* ImGui_TableFindByID(uint id);
		/// <summary>
		/// Implied outer_size = ImVec2(0, 0), inner_width = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTableWithID")]
		public static extern byte ImGui_BeginTableWithID(byte* name, uint id, int columns_count, ImGuiTableFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTableWithIDEx")]
		public static extern byte ImGui_BeginTableWithIDEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableBeginInitMemory")]
		public static extern void ImGui_TableBeginInitMemory(ImGuiTable* table, int columns_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableBeginApplyRequests")]
		public static extern void ImGui_TableBeginApplyRequests(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetupDrawChannels")]
		public static extern void ImGui_TableSetupDrawChannels(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableUpdateLayout")]
		public static extern void ImGui_TableUpdateLayout(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableUpdateBorders")]
		public static extern void ImGui_TableUpdateBorders(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableUpdateColumnsWeightFromWidth")]
		public static extern void ImGui_TableUpdateColumnsWeightFromWidth(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableDrawBorders")]
		public static extern void ImGui_TableDrawBorders(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableDrawDefaultContextMenu")]
		public static extern void ImGui_TableDrawDefaultContextMenu(ImGuiTable* table, ImGuiTableFlags flags_for_section_to_display);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableBeginContextMenuPopup")]
		public static extern byte ImGui_TableBeginContextMenuPopup(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableMergeDrawChannels")]
		public static extern void ImGui_TableMergeDrawChannels(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetInstanceData")]
		public static extern ImGuiTableInstanceData* ImGui_TableGetInstanceData(ImGuiTable* table, int instance_no);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetInstanceID")]
		public static extern uint ImGui_TableGetInstanceID(ImGuiTable* table, int instance_no);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSortSpecsSanitize")]
		public static extern void ImGui_TableSortSpecsSanitize(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSortSpecsBuild")]
		public static extern void ImGui_TableSortSpecsBuild(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnNextSortDirection")]
		public static extern ImGuiSortDirection ImGui_TableGetColumnNextSortDirection(ImGuiTableColumn* column);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableFixColumnSortDirection")]
		public static extern void ImGui_TableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnWidthAuto")]
		public static extern float ImGui_TableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableBeginRow")]
		public static extern void ImGui_TableBeginRow(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableEndRow")]
		public static extern void ImGui_TableEndRow(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableBeginCell")]
		public static extern void ImGui_TableBeginCell(ImGuiTable* table, int column_n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableEndCell")]
		public static extern void ImGui_TableEndCell(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetCellBgRect")]
		public static extern ImRect ImGui_TableGetCellBgRect(ImGuiTable* table, int column_n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnNameImGuiTablePtr")]
		public static extern byte* ImGui_TableGetColumnNameImGuiTablePtr(ImGuiTable* table, int column_n);
		/// <summary>
		/// Implied instance_no = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnResizeID")]
		public static extern uint ImGui_TableGetColumnResizeID(ImGuiTable* table, int column_n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetColumnResizeIDEx")]
		public static extern uint ImGui_TableGetColumnResizeIDEx(ImGuiTable* table, int column_n, int instance_no);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableCalcMaxColumnWidth")]
		public static extern float ImGui_TableCalcMaxColumnWidth(ImGuiTable* table, int column_n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetColumnWidthAutoSingle")]
		public static extern void ImGui_TableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSetColumnWidthAutoAll")]
		public static extern void ImGui_TableSetColumnWidthAutoAll(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableRemove")]
		public static extern void ImGui_TableRemove(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGcCompactTransientBuffers")]
		public static extern void ImGui_TableGcCompactTransientBuffers(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGcCompactTransientBuffersImGuiTableTempDataPtr")]
		public static extern void ImGui_TableGcCompactTransientBuffersImGuiTableTempDataPtr(ImGuiTableTempData* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGcCompactSettings")]
		public static extern void ImGui_TableGcCompactSettings();
		/// <summary>
		/// <para>Tables: Settings</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableLoadSettings")]
		public static extern void ImGui_TableLoadSettings(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSaveSettings")]
		public static extern void ImGui_TableSaveSettings(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableResetSettings")]
		public static extern void ImGui_TableResetSettings(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableGetBoundSettings")]
		public static extern ImGuiTableSettings* ImGui_TableGetBoundSettings(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSettingsAddSettingsHandler")]
		public static extern void ImGui_TableSettingsAddSettingsHandler();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSettingsCreate")]
		public static extern ImGuiTableSettings* ImGui_TableSettingsCreate(uint id, int columns_count);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TableSettingsFindByID")]
		public static extern ImGuiTableSettings* ImGui_TableSettingsFindByID(uint id);
		/// <summary>
		/// <para>Tab Bars</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetCurrentTabBar")]
		public static extern ImGuiTabBar* ImGui_GetCurrentTabBar();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginTabBarEx")]
		public static extern byte ImGui_BeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarFindTabByID")]
		public static extern ImGuiTabItem* ImGui_TabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarFindTabByOrder")]
		public static extern ImGuiTabItem* ImGui_TabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarFindMostRecentlySelectedTabForActiveWindow")]
		public static extern ImGuiTabItem* ImGui_TabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarGetCurrentTab")]
		public static extern ImGuiTabItem* ImGui_TabBarGetCurrentTab(ImGuiTabBar* tab_bar);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarGetTabOrder")]
		public static extern int ImGui_TabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarGetTabName")]
		public static extern byte* ImGui_TabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarAddTab")]
		public static extern void ImGui_TabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarRemoveTab")]
		public static extern void ImGui_TabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarCloseTab")]
		public static extern void ImGui_TabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarQueueFocus")]
		public static extern void ImGui_TabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarQueueFocusStr")]
		public static extern void ImGui_TabBarQueueFocusStr(ImGuiTabBar* tab_bar, byte* tab_name);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarQueueReorder")]
		public static extern void ImGui_TabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarQueueReorderFromMousePos")]
		public static extern void ImGui_TabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabBarProcessReorder")]
		public static extern byte ImGui_TabBarProcessReorder(ImGuiTabBar* tab_bar);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabItemEx")]
		public static extern byte ImGui_TabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabItemCalcSizeStr")]
		public static extern Vector2 ImGui_TabItemCalcSizeStr(byte* label, byte has_close_button_or_unsaved_marker);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabItemCalcSize")]
		public static extern Vector2 ImGui_TabItemCalcSize(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabItemBackground")]
		public static extern void ImGui_TabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TabItemLabelAndCloseButton")]
		public static extern void ImGui_TabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
		/// <summary>
		/// <para>Render helpers</para>
		/// <para>AVOID USING OUTSIDE OF IMGUI.CPP! NOT FOR PUBLIC CONSUMPTION. THOSE FUNCTIONS ARE A MESS. THEIR SIGNATURE AND BEHAVIOR WILL CHANGE, THEY NEED TO BE REFACTORED INTO SOMETHING DECENT.</para>
		/// <para>NB: All position are in absolute pixels coordinates (we are never using window coordinates internally)</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, hide_text_after_hash = true
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderText")]
		public static extern void ImGui_RenderText(Vector2 pos, byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextEx")]
		public static extern void ImGui_RenderTextEx(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextWrapped")]
		public static extern void ImGui_RenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextClipped")]
		public static extern void ImGui_RenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextClippedEx")]
		public static extern void ImGui_RenderTextClippedEx(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
		/// <summary>
		/// Implied align = ImVec2(0, 0), clip_rect = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextClippedWithDrawList")]
		public static extern void ImGui_RenderTextClippedWithDrawList(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextClippedWithDrawListEx")]
		public static extern void ImGui_RenderTextClippedWithDrawListEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderTextEllipsis")]
		public static extern void ImGui_RenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
		/// <summary>
		/// Implied borders = true, rounding = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderFrame")]
		public static extern void ImGui_RenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderFrameEx")]
		public static extern void ImGui_RenderFrameEx(Vector2 p_min, Vector2 p_max, uint fill_col, byte borders, float rounding);
		/// <summary>
		/// Implied rounding = 0.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderFrameBorder")]
		public static extern void ImGui_RenderFrameBorder(Vector2 p_min, Vector2 p_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderFrameBorderEx")]
		public static extern void ImGui_RenderFrameBorderEx(Vector2 p_min, Vector2 p_max, float rounding);
		/// <summary>
		/// Implied rounding = 0.0f, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderColorRectWithAlphaCheckerboard")]
		public static extern void ImGui_RenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderColorRectWithAlphaCheckerboardEx")]
		public static extern void ImGui_RenderColorRectWithAlphaCheckerboardEx(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags);
		/// <summary>
		/// Implied flags = ImGuiNavRenderCursorFlags_None
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderNavCursor")]
		public static extern void ImGui_RenderNavCursor(ImRect bb, uint id);
		/// <summary>
		/// Navigation highlight
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderNavCursorEx")]
		public static extern void ImGui_RenderNavCursorEx(ImRect bb, uint id, ImGuiNavRenderCursorFlags flags);
		/// <summary>
		/// Implied text_end = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindRenderedTextEnd")]
		public static extern byte* ImGui_FindRenderedTextEnd(byte* text);
		/// <summary>
		/// Find the optional ## from which we stop displaying text.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_FindRenderedTextEndEx")]
		public static extern byte* ImGui_FindRenderedTextEndEx(byte* text, byte* text_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderMouseCursor")]
		public static extern void ImGui_RenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
		/// <summary>
		/// <para>Render helpers (those functions don't access any ImGui state!)</para>
		/// </summary>
		/// <summary>
		/// Implied scale = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderArrow")]
		public static extern void ImGui_RenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderArrowEx")]
		public static extern void ImGui_RenderArrowEx(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderBullet")]
		public static extern void ImGui_RenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderCheckMark")]
		public static extern void ImGui_RenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderArrowPointingAt")]
		public static extern void ImGui_RenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderArrowDockMenu")]
		public static extern void ImGui_RenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderRectFilledRangeH")]
		public static extern void ImGui_RenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_RenderRectFilledWithHole")]
		public static extern void ImGui_RenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CalcRoundingFlagsForRectInRect")]
		public static extern ImDrawFlags ImGui_CalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold);
		/// <summary>
		/// <para>Widgets</para>
		/// </summary>
		/// <summary>
		/// Implied text_end = NULL, flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextEx")]
		public static extern void ImGui_TextEx(byte* text);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TextExEx")]
		public static extern void ImGui_TextExEx(byte* text, byte* text_end, ImGuiTextFlags flags);
		/// <summary>
		/// Implied size_arg = ImVec2(0, 0), flags = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ButtonWithFlags")]
		public static extern byte ImGui_ButtonWithFlags(byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ButtonWithFlagsEx")]
		public static extern byte ImGui_ButtonWithFlagsEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ArrowButtonEx")]
		public static extern byte ImGui_ArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ImageButtonWithFlags")]
		public static extern byte ImGui_ImageButtonWithFlags(uint id, IntPtr texture_id, Vector2 image_size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col, ImGuiButtonFlags flags);
		/// <summary>
		/// Implied thickness = 1.0f
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SeparatorEx")]
		public static extern void ImGui_SeparatorEx(ImGuiSeparatorFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SeparatorExEx")]
		public static extern void ImGui_SeparatorExEx(ImGuiSeparatorFlags flags, float thickness);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SeparatorTextEx")]
		public static extern void ImGui_SeparatorTextEx(uint id, byte* label, byte* label_end, float extra_width);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CheckboxFlagsImS64Ptr")]
		public static extern byte ImGui_CheckboxFlagsImS64Ptr(byte* label, long* flags, long flags_value);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CheckboxFlagsImU64Ptr")]
		public static extern byte ImGui_CheckboxFlagsImU64Ptr(byte* label, ulong* flags, ulong flags_value);
		/// <summary>
		/// <para>Widgets: Window Decorations</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CloseButton")]
		public static extern byte ImGui_CloseButton(uint id, Vector2 pos);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_CollapseButton")]
		public static extern byte ImGui_CollapseButton(uint id, Vector2 pos, ImGuiDockNode* dock_node);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_Scrollbar")]
		public static extern void ImGui_Scrollbar(ImGuiAxis axis);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ScrollbarEx")]
		public static extern byte ImGui_ScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowScrollbarRect")]
		public static extern ImRect ImGui_GetWindowScrollbarRect(ImGuiWindow* window, ImGuiAxis axis);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowScrollbarID")]
		public static extern uint ImGui_GetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
		/// <summary>
		/// 0..3: corners
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowResizeCornerID")]
		public static extern uint ImGui_GetWindowResizeCornerID(ImGuiWindow* window, int n);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GetWindowResizeBorderID")]
		public static extern uint ImGui_GetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
		/// <summary>
		/// <para>Widgets low-level behaviors</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ButtonBehavior")]
		public static extern byte ImGui_ButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DragBehavior")]
		public static extern byte ImGui_DragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SliderBehavior")]
		public static extern byte ImGui_SliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
		/// <summary>
		/// Implied hover_extend = 0.0f, hover_visibility_delay = 0.0f, bg_col = 0
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SplitterBehavior")]
		public static extern byte ImGui_SplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SplitterBehaviorEx")]
		public static extern byte ImGui_SplitterBehaviorEx(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col);
		/// <summary>
		/// <para>Widgets: Tree Nodes</para>
		/// </summary>
		/// <summary>
		/// Implied label_end = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeBehavior")]
		public static extern byte ImGui_TreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeBehaviorEx")]
		public static extern byte ImGui_TreeNodeBehaviorEx(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreePushOverrideID")]
		public static extern void ImGui_TreePushOverrideID(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeGetOpen")]
		public static extern byte ImGui_TreeNodeGetOpen(uint storage_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeSetOpen")]
		public static extern void ImGui_TreeNodeSetOpen(uint storage_id, byte open);
		/// <summary>
		/// Return open state. Consume previous SetNextItemOpen() data, if any. May return true when logging.
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TreeNodeUpdateNextOpen")]
		public static extern byte ImGui_TreeNodeUpdateNextOpen(uint storage_id, ImGuiTreeNodeFlags flags);
		/// <summary>
		/// <para>Data type helpers</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeGetInfo")]
		public static extern ImGuiDataTypeInfo* ImGui_DataTypeGetInfo(ImGuiDataType data_type);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeFormatString")]
		public static extern int ImGui_DataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeApplyOp")]
		public static extern void ImGui_DataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
		/// <summary>
		/// Implied p_data_when_empty = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeApplyFromText")]
		public static extern byte ImGui_DataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeApplyFromTextEx")]
		public static extern byte ImGui_DataTypeApplyFromTextEx(byte* buf, ImGuiDataType data_type, void* p_data, byte* format, void* p_data_when_empty);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeCompare")]
		public static extern int ImGui_DataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeClamp")]
		public static extern byte ImGui_DataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DataTypeIsZero")]
		public static extern byte ImGui_DataTypeIsZero(ImGuiDataType data_type, void* p_data);
		/// <summary>
		/// <para>InputText</para>
		/// </summary>
		/// <summary>
		/// Implied callback = NULL, user_data = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextWithHintAndSize")]
		public static extern byte ImGui_InputTextWithHintAndSize(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextWithHintAndSizeEx")]
		public static extern byte ImGui_InputTextWithHintAndSizeEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_InputTextDeactivateHook")]
		public static extern void ImGui_InputTextDeactivateHook(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TempInputText")]
		public static extern byte ImGui_TempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);
		/// <summary>
		/// Implied p_clamp_min = NULL, p_clamp_max = NULL
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TempInputScalar")]
		public static extern byte ImGui_TempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TempInputScalarEx")]
		public static extern byte ImGui_TempInputScalarEx(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_TempInputIsActive")]
		public static extern byte ImGui_TempInputIsActive(uint id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_SetNextItemRefVal")]
		public static extern void ImGui_SetNextItemRefVal(ImGuiDataType data_type, void* p_data);
		/// <summary>
		/// <para>Color</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorTooltip")]
		public static extern void ImGui_ColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorEditOptionsPopup")]
		public static extern void ImGui_ColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ColorPickerOptionsPopup")]
		public static extern void ImGui_ColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
		/// <summary>
		/// <para>Plot</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_PlotEx")]
		public static extern int ImGui_PlotEx(ImGuiPlotType plot_type, byte* label, ImGui_PlotExvalues_getterDelegate values_getter, void* data, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 size_arg);
		/// <summary>
		/// <para>Shade functions (write over already created vertices)</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShadeVertsLinearColorGradientKeepAlpha")]
		public static extern void ImGui_ShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShadeVertsLinearUV")]
		public static extern void ImGui_ShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShadeVertsTransformPos")]
		public static extern void ImGui_ShadeVertsTransformPos(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 pivot_in, float cos_a, float sin_a, Vector2 pivot_out);
		/// <summary>
		/// <para>Garbage collection</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GcCompactTransientMiscBuffers")]
		public static extern void ImGui_GcCompactTransientMiscBuffers();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GcCompactTransientWindowBuffers")]
		public static extern void ImGui_GcCompactTransientWindowBuffers(ImGuiWindow* window);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_GcAwakeTransientWindowBuffers")]
		public static extern void ImGui_GcAwakeTransientWindowBuffers(ImGuiWindow* window);
		/// <summary>
		/// <para>Error handling, State Recovery</para>
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ErrorLog")]
		public static extern byte ImGui_ErrorLog(byte* msg);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ErrorRecoveryStoreState")]
		public static extern void ImGui_ErrorRecoveryStoreState(ImGuiErrorRecoveryState* state_out);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ErrorRecoveryTryToRecoverState")]
		public static extern void ImGui_ErrorRecoveryTryToRecoverState(ImGuiErrorRecoveryState* state_in);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ErrorRecoveryTryToRecoverWindowState")]
		public static extern void ImGui_ErrorRecoveryTryToRecoverWindowState(ImGuiErrorRecoveryState* state_in);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ErrorCheckUsingSetCursorPosToExtendParentBoundaries")]
		public static extern void ImGui_ErrorCheckUsingSetCursorPosToExtendParentBoundaries();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ErrorCheckEndFrameFinalizeErrorTooltip")]
		public static extern void ImGui_ErrorCheckEndFrameFinalizeErrorTooltip();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_BeginErrorTooltip")]
		public static extern byte ImGui_BeginErrorTooltip();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_EndErrorTooltip")]
		public static extern void ImGui_EndErrorTooltip();
		/// <summary>
		/// <para>Debug Tools</para>
		/// </summary>
		/// <summary>
		/// size &gt;= 0 : alloc, size = -1 : free
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugAllocHook")]
		public static extern void ImGui_DebugAllocHook(ImGuiDebugAllocInfo* info, int frame_count, void* ptr, uint size);
		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugDrawCursorPos")]
		public static extern void ImGui_DebugDrawCursorPos();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugDrawCursorPosEx")]
		public static extern void ImGui_DebugDrawCursorPosEx(uint col);
		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugDrawLineExtents")]
		public static extern void ImGui_DebugDrawLineExtents();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugDrawLineExtentsEx")]
		public static extern void ImGui_DebugDrawLineExtentsEx(uint col);
		/// <summary>
		/// Implied col = IM_COL32(255, 0, 0, 255)
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugDrawItemRect")]
		public static extern void ImGui_DebugDrawItemRect();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugDrawItemRectEx")]
		public static extern void ImGui_DebugDrawItemRectEx(uint col);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugTextUnformattedWithLocateItem")]
		public static extern void ImGui_DebugTextUnformattedWithLocateItem(byte* line_begin, byte* line_end);
		/// <summary>
		/// Call sparingly: only 1 at the same time!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugLocateItem")]
		public static extern void ImGui_DebugLocateItem(uint target_id);
		/// <summary>
		/// Only call on reaction to a mouse Hover: because only 1 at the same time!
		/// </summary>
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugLocateItemOnHover")]
		public static extern void ImGui_DebugLocateItemOnHover(uint target_id);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugLocateItemResolveWithLastItem")]
		public static extern void ImGui_DebugLocateItemResolveWithLastItem();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugBreakClearData")]
		public static extern void ImGui_DebugBreakClearData();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugBreakButton")]
		public static extern byte ImGui_DebugBreakButton(byte* label, byte* description_of_location);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugBreakButtonTooltip")]
		public static extern void ImGui_DebugBreakButtonTooltip(byte keyboard_only, byte* description_of_location);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_ShowFontAtlas")]
		public static extern void ImGui_ShowFontAtlas(ImFontAtlas* atlas);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugHookIdInfo")]
		public static extern void ImGui_DebugHookIdInfo(uint id, ImGuiDataType data_type, void* data_id, void* data_id_end);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeColumns")]
		public static extern void ImGui_DebugNodeColumns(ImGuiOldColumns* columns);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeDockNode")]
		public static extern void ImGui_DebugNodeDockNode(ImGuiDockNode* node, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeDrawList")]
		public static extern void ImGui_DebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* draw_list, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeDrawCmdShowMeshAndBoundingBox")]
		public static extern void ImGui_DebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeFont")]
		public static extern void ImGui_DebugNodeFont(ImFont* font);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeFontGlyph")]
		public static extern void ImGui_DebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeStorage")]
		public static extern void ImGui_DebugNodeStorage(ImGuiStorage* storage, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeTabBar")]
		public static extern void ImGui_DebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeTable")]
		public static extern void ImGui_DebugNodeTable(ImGuiTable* table);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeTableSettings")]
		public static extern void ImGui_DebugNodeTableSettings(ImGuiTableSettings* settings);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeTypingSelectState")]
		public static extern void ImGui_DebugNodeTypingSelectState(ImGuiTypingSelectState* state);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeMultiSelectState")]
		public static extern void ImGui_DebugNodeMultiSelectState(ImGuiMultiSelectState* state);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeWindow")]
		public static extern void ImGui_DebugNodeWindow(ImGuiWindow* window, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeWindowSettings")]
		public static extern void ImGui_DebugNodeWindowSettings(ImGuiWindowSettings* settings);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeWindowsList")]
		public static extern void ImGui_DebugNodeWindowsList(ImVector* windows, byte* label);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeWindowsListByBeginStackParent")]
		public static extern void ImGui_DebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodeViewport")]
		public static extern void ImGui_DebugNodeViewport(ImGuiViewportP* viewport);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugNodePlatformMonitor")]
		public static extern void ImGui_DebugNodePlatformMonitor(ImGuiPlatformMonitor* monitor, byte* label, int idx);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugRenderKeyboardPreview")]
		public static extern void ImGui_DebugRenderKeyboardPreview(ImDrawList* draw_list);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImGui_DebugRenderViewportThumbnail")]
		public static extern void ImGui_DebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasGetBuilderForStbTruetype")]
		public static extern IntPtr cImFontAtlasGetBuilderForStbTruetype();
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasUpdateConfigDataPointers")]
		public static extern void cImFontAtlasUpdateConfigDataPointers(ImFontAtlas* atlas);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildInit")]
		public static extern void cImFontAtlasBuildInit(ImFontAtlas* atlas);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildSetupFont")]
		public static extern void cImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildPackCustomRects")]
		public static extern void cImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildFinish")]
		public static extern void cImFontAtlasBuildFinish(ImFontAtlas* atlas);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildRender8bppRectFromString")]
		public static extern void cImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildRender32bppRectFromString")]
		public static extern void cImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildMultiplyCalcLookupTable")]
		public static extern void cImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor);
		[DllImport("dcimgui", CallingConvention = CallingConvention.Cdecl, EntryPoint = "cImFontAtlasBuildMultiplyRectAlpha8")]
		public static extern void cImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
	}
}
