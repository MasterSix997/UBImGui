using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Helper: Key-&gt;Value storage<br/>Typically you don't have to worry about this since a storage is held within each Window.<br/>We use it to e.g. store collapse state for a tree (Int 0/1)<br/>This is optimized for efficient lookup (dichotomy into a contiguous buffer) and rare insertion (typically tied to user interactions aka max once a frame)<br/>You can use it as custom user storage for temporary values. Declare your own storage if, for example:<br/>- You want to manipulate the open/close state of a particular sub-tree in your interface (tree node uses Int 0/1 to store their state).<br/>- You want to store custom debug data easily without adding or editing structures in your code (probably not efficient, but convenient)<br/>Types are NOT stored, so it is up to you to make sure your Key don't collide with different types.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiStorage
	{
		/// <summary>
		/// <br/>    [Internal]<br/>
		/// </summary>
		public ImVector<ImGuiStoragePair> Data;
	}

	/// <summary>
	/// Helper: Key-&gt;Value storage<br/>Typically you don't have to worry about this since a storage is held within each Window.<br/>We use it to e.g. store collapse state for a tree (Int 0/1)<br/>This is optimized for efficient lookup (dichotomy into a contiguous buffer) and rare insertion (typically tied to user interactions aka max once a frame)<br/>You can use it as custom user storage for temporary values. Declare your own storage if, for example:<br/>- You want to manipulate the open/close state of a particular sub-tree in your interface (tree node uses Int 0/1 to store their state).<br/>- You want to store custom debug data easily without adding or editing structures in your code (probably not efficient, but convenient)<br/>Types are NOT stored, so it is up to you to make sure your Key don't collide with different types.<br/>
	/// </summary>
	public unsafe partial struct ImGuiStoragePtr
	{
		public ImGuiStorage* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiStorage this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// <br/>    [Internal]<br/>
		/// </summary>
		public ref ImVector<ImGuiStoragePair> Data => ref Unsafe.AsRef<ImVector<ImGuiStoragePair>>(&NativePtr->Data);
		public ImGuiStoragePtr(ImGuiStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiStorage*)nativePtr;
		public static implicit operator ImGuiStoragePtr(ImGuiStorage* ptr) => new ImGuiStoragePtr(ptr);
		public static implicit operator ImGuiStoragePtr(IntPtr ptr) => new ImGuiStoragePtr(ptr);
		public static implicit operator ImGuiStorage*(ImGuiStoragePtr nativePtr) => nativePtr.NativePtr;
		public void SetAllInt(int val)
		{
			ImGuiNative.ImGuiStorageSetAllInt(NativePtr, val);
		}

		public void BuildSortByKey()
		{
			ImGuiNative.ImGuiStorageBuildSortByKey(NativePtr);
		}

		public ref void* GetVoidPtrRef(uint key, IntPtr defaultVal)
		{
			var nativeResult = ImGuiNative.ImGuiStorageGetVoidPtrRef(NativePtr, key, (void*)defaultVal);
			return ref *(void**)&nativeResult;
		}

		public ref void* GetVoidPtrRef(uint key)
		{
			// defining omitted parameters
			void* defaultVal = null;
			var nativeResult = ImGuiNative.ImGuiStorageGetVoidPtrRef(NativePtr, key, defaultVal);
			return ref *(void**)&nativeResult;
		}

		public ref float GetFloatRef(uint key, float defaultVal)
		{
			var nativeResult = ImGuiNative.ImGuiStorageGetFloatRef(NativePtr, key, defaultVal);
			return ref *(float*)&nativeResult;
		}

		public ref float GetFloatRef(uint key)
		{
			// defining omitted parameters
			float defaultVal = 0.0f;
			var nativeResult = ImGuiNative.ImGuiStorageGetFloatRef(NativePtr, key, defaultVal);
			return ref *(float*)&nativeResult;
		}

		public ref byte GetBoolRef(uint key, bool defaultVal)
		{
			var native_defaultVal = defaultVal ? (byte)1 : (byte)0;
			var nativeResult = ImGuiNative.ImGuiStorageGetBoolRef(NativePtr, key, native_defaultVal);
			return ref *(byte*)&nativeResult;
		}

		public ref byte GetBoolRef(uint key)
		{
			// defining omitted parameters
			byte defaultVal = 0;
			var nativeResult = ImGuiNative.ImGuiStorageGetBoolRef(NativePtr, key, defaultVal);
			return ref *(byte*)&nativeResult;
		}

		public ref int GetIntRef(uint key, int defaultVal)
		{
			var nativeResult = ImGuiNative.ImGuiStorageGetIntRef(NativePtr, key, defaultVal);
			return ref *(int*)&nativeResult;
		}

		public ref int GetIntRef(uint key)
		{
			// defining omitted parameters
			int defaultVal = 0;
			var nativeResult = ImGuiNative.ImGuiStorageGetIntRef(NativePtr, key, defaultVal);
			return ref *(int*)&nativeResult;
		}

		public void SetVoidPtr(uint key, IntPtr val)
		{
			ImGuiNative.ImGuiStorageSetVoidPtr(NativePtr, key, (void*)val);
		}

		/// <summary>
		/// default_val is NULL<br/>
		/// </summary>
		public IntPtr GetVoidPtr(uint key)
		{
			return (IntPtr)ImGuiNative.ImGuiStorageGetVoidPtr(NativePtr, key);
		}

		public void SetFloat(uint key, float val)
		{
			ImGuiNative.ImGuiStorageSetFloat(NativePtr, key, val);
		}

		public float GetFloat(uint key, float defaultVal)
		{
			return ImGuiNative.ImGuiStorageGetFloat(NativePtr, key, defaultVal);
		}

		public float GetFloat(uint key)
		{
			// defining omitted parameters
			float defaultVal = 0.0f;
			return ImGuiNative.ImGuiStorageGetFloat(NativePtr, key, defaultVal);
		}

		public void SetBool(uint key, bool val)
		{
			var native_val = val ? (byte)1 : (byte)0;
			ImGuiNative.ImGuiStorageSetBool(NativePtr, key, native_val);
		}

		public bool GetBool(uint key, bool defaultVal)
		{
			var native_defaultVal = defaultVal ? (byte)1 : (byte)0;
			var result = ImGuiNative.ImGuiStorageGetBool(NativePtr, key, native_defaultVal);
			return result != 0;
		}

		public bool GetBool(uint key)
		{
			// defining omitted parameters
			byte defaultVal = 0;
			var result = ImGuiNative.ImGuiStorageGetBool(NativePtr, key, defaultVal);
			return result != 0;
		}

		public void SetInt(uint key, int val)
		{
			ImGuiNative.ImGuiStorageSetInt(NativePtr, key, val);
		}

		public int GetInt(uint key, int defaultVal)
		{
			return ImGuiNative.ImGuiStorageGetInt(NativePtr, key, defaultVal);
		}

		public int GetInt(uint key)
		{
			// defining omitted parameters
			int defaultVal = 0;
			return ImGuiNative.ImGuiStorageGetInt(NativePtr, key, defaultVal);
		}

		public void Clear()
		{
			ImGuiNative.ImGuiStorageClear(NativePtr);
		}

	}
}
