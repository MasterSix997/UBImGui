using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Helper: Parse and apply text filters. In format "aaaaa[,bbbb][,ccccc]"</para>
	/// </summary>
	public unsafe partial struct ImGuiTextFilter
	{
		public fixed byte InputBuf[256];
		public ImVector Filters;
		public int CountGrep;
	}

	/// <summary>
	/// <para>Helper: Parse and apply text filters. In format "aaaaa[,bbbb][,ccccc]"</para>
	/// </summary>
	public unsafe partial struct ImGuiTextFilterPtr
	{
		public ImGuiTextFilter* NativePtr { get; }
		public ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => NativePtr = nativePtr;
		public ImGuiTextFilterPtr(IntPtr nativePtr) => NativePtr = (ImGuiTextFilter*)nativePtr;
		public static implicit operator ImGuiTextFilterPtr(ImGuiTextFilter* nativePtr) => new ImGuiTextFilterPtr(nativePtr);
		public static implicit operator ImGuiTextFilter* (ImGuiTextFilterPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTextFilterPtr(IntPtr nativePtr) => new ImGuiTextFilterPtr(nativePtr);

		public RangeAccessor<byte> InputBuf => new RangeAccessor<byte>(NativePtr->InputBuf, 256);

		public ImPtrVector<ImGuiTextRangePtr> Filters => new ImPtrVector<ImGuiTextRangePtr>(NativePtr->Filters, Unsafe.SizeOf<ImGuiTextRange>());

		public ref int CountGrep => ref Unsafe.AsRef<int>(&NativePtr->CountGrep);

		/// <summary>
		/// Helper calling InputText+Build
		/// </summary>
		public bool Draw()
		{
			byte* label;
			var label_byteCount = Encoding.UTF8.GetByteCount("Filter (inc,-exc)");
			if (label_byteCount > Util.StackAllocationSizeLimit)
				label = Util.Allocate(label_byteCount + 1);
			else
			{
				var label_stackBytes = stackalloc byte[label_byteCount + 1];
				label = label_stackBytes;
			}
			var label_offset = Util.GetUtf8("Filter (inc,-exc)", label, label_byteCount);
			label[label_offset] = 0;

			float width = 0.0f;

			var ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, label, width);
			if (label_byteCount > Util.StackAllocationSizeLimit)
				Util.Free(label);
			return ret != 0;
		}
		/// <summary>
		/// Helper calling InputText+Build
		/// </summary>
		public bool Draw(ReadOnlySpan<char> label)
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

			float width = 0.0f;

			var ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}
		/// <summary>
		/// Helper calling InputText+Build
		/// </summary>
		public bool Draw(ReadOnlySpan<char> label, float width)
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

			var ret = ImGuiNative.ImGuiTextFilter_Draw(NativePtr, native_label, width);
			if (label_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_label);
			}
			return ret != 0;
		}

		public bool PassFilter(ReadOnlySpan<char> text)
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

			var ret = ImGuiNative.ImGuiTextFilter_PassFilter(NativePtr, native_text, text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			return ret != 0;
		}
		public bool PassFilter(ReadOnlySpan<char> text, ReadOnlySpan<char> text_end)
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

			var ret = ImGuiNative.ImGuiTextFilter_PassFilter(NativePtr, native_text, native_text_end);
			if (text_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text);
			}
			if (text_end_byteCount > Util.StackAllocationSizeLimit)
			{
				Util.Free(native_text_end);
			}
			return ret != 0;
		}

		public void Build()
		{
			ImGuiNative.ImGuiTextFilter_Build(NativePtr);
		}

		public void Clear()
		{
			ImGuiNative.ImGuiTextFilter_Clear(NativePtr);
		}

		public bool IsActive()
		{
			var ret = ImGuiNative.ImGuiTextFilter_IsActive(NativePtr);
			return ret != 0;
		}
	}
}
