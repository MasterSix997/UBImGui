using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>[Internal] Storage used by IsKeyDown(), IsKeyPressed() etc functions.</para>
	/// <para>If prior to 1.87 you used io.KeysDownDuration[] (which was marked as internal), you should use GetKeyData(key)-&gt;DownDuration and *NOT* io.KeysData[key]-&gt;DownDuration.</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyData
	{
		/// <summary>
		/// True for if key is down
		/// </summary>
		public byte Down;
		/// <summary>
		/// Duration the key has been down (&lt;0.0f: not pressed, 0.0f: just pressed, &gt;0.0f: time held)
		/// </summary>
		public float DownDuration;
		/// <summary>
		/// Last frame duration the key has been down
		/// </summary>
		public float DownDurationPrev;
		/// <summary>
		/// 0.0f..1.0f for gamepad values
		/// </summary>
		public float AnalogValue;
	}

	/// <summary>
	/// <para>[Internal] Storage used by IsKeyDown(), IsKeyPressed() etc functions.</para>
	/// <para>If prior to 1.87 you used io.KeysDownDuration[] (which was marked as internal), you should use GetKeyData(key)-&gt;DownDuration and *NOT* io.KeysData[key]-&gt;DownDuration.</para>
	/// </summary>
	public unsafe partial struct ImGuiKeyDataPtr
	{
		public ImGuiKeyData* NativePtr { get; }
		public ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyData*)nativePtr;
		public static implicit operator ImGuiKeyDataPtr(ImGuiKeyData* nativePtr) => new ImGuiKeyDataPtr(nativePtr);
		public static implicit operator ImGuiKeyData* (ImGuiKeyDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiKeyDataPtr(IntPtr nativePtr) => new ImGuiKeyDataPtr(nativePtr);

		/// <summary>
		/// True for if key is down
		/// </summary>
		public ref bool Down => ref Unsafe.AsRef<bool>(&NativePtr->Down);

		/// <summary>
		/// Duration the key has been down (&lt;0.0f: not pressed, 0.0f: just pressed, &gt;0.0f: time held)
		/// </summary>
		public ref float DownDuration => ref Unsafe.AsRef<float>(&NativePtr->DownDuration);

		/// <summary>
		/// Last frame duration the key has been down
		/// </summary>
		public ref float DownDurationPrev => ref Unsafe.AsRef<float>(&NativePtr->DownDurationPrev);

		/// <summary>
		/// 0.0f..1.0f for gamepad values
		/// </summary>
		public ref float AnalogValue => ref Unsafe.AsRef<float>(&NativePtr->AnalogValue);
	}
}
