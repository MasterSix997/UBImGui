using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// <para>Helper: Key-&gt;Value storage</para>
	/// <para>Typically you don't have to worry about this since a storage is held within each Window.</para>
	/// <para>We use it to e.g. store collapse state for a tree (Int 0/1)</para>
	/// <para>This is optimized for efficient lookup (dichotomy into a contiguous buffer) and rare insertion (typically tied to user interactions aka max once a frame)</para>
	/// <para>You can use it as custom user storage for temporary values. Declare your own storage if, for example:</para>
	/// <para>- You want to manipulate the open/close state of a particular sub-tree in your interface (tree node uses Int 0/1 to store their state).</para>
	/// <para>- You want to store custom debug data easily without adding or editing structures in your code (probably not efficient, but convenient)</para>
	/// <para>Types are NOT stored, so it is up to you to make sure your Key don't collide with different types.</para>
	/// </summary>
	public unsafe partial struct ImGuiStorage
	{
		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		public ImVector Data;
	}

	/// <summary>
	/// <para>Helper: Key-&gt;Value storage</para>
	/// <para>Typically you don't have to worry about this since a storage is held within each Window.</para>
	/// <para>We use it to e.g. store collapse state for a tree (Int 0/1)</para>
	/// <para>This is optimized for efficient lookup (dichotomy into a contiguous buffer) and rare insertion (typically tied to user interactions aka max once a frame)</para>
	/// <para>You can use it as custom user storage for temporary values. Declare your own storage if, for example:</para>
	/// <para>- You want to manipulate the open/close state of a particular sub-tree in your interface (tree node uses Int 0/1 to store their state).</para>
	/// <para>- You want to store custom debug data easily without adding or editing structures in your code (probably not efficient, but convenient)</para>
	/// <para>Types are NOT stored, so it is up to you to make sure your Key don't collide with different types.</para>
	/// </summary>
	public unsafe partial struct ImGuiStoragePtr
	{
		public ImGuiStorage* NativePtr { get; }
		public ImGuiStoragePtr(ImGuiStorage* nativePtr) => NativePtr = nativePtr;
		public ImGuiStoragePtr(IntPtr nativePtr) => NativePtr = (ImGuiStorage*)nativePtr;
		public static implicit operator ImGuiStoragePtr(ImGuiStorage* nativePtr) => new ImGuiStoragePtr(nativePtr);
		public static implicit operator ImGuiStorage* (ImGuiStoragePtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiStoragePtr(IntPtr nativePtr) => new ImGuiStoragePtr(nativePtr);

		/// <summary>
		/// <para>[Internal]</para>
		/// </summary>
		public ImPtrVector<ImGuiStoragePairPtr> Data => new ImPtrVector<ImGuiStoragePairPtr>(NativePtr->Data, Unsafe.SizeOf<ImGuiStoragePair>());

		/// <summary>
		/// <para>- Get***() functions find pair, never add/allocate. Pairs are sorted so a query is O(log N)</para>
		/// <para>- Set***() functions find pair, insertion on demand if missing.</para>
		/// <para>- Sorted insertion is costly, paid once. A typical frame shouldn't need to insert any new pair.</para>
		/// </summary>
		public void Clear()
		{
			ImGuiNative.ImGuiStorage_Clear(NativePtr);
		}

		public int GetInt(uint key)
		{
			int default_val = 0;

			var ret = ImGuiNative.ImGuiStorage_GetInt(NativePtr, key, default_val);
			return ret;
		}
		public int GetInt(uint key, int default_val)
		{
			var ret = ImGuiNative.ImGuiStorage_GetInt(NativePtr, key, default_val);
			return ret;
		}

		public void SetInt(uint key, int val)
		{
			ImGuiNative.ImGuiStorage_SetInt(NativePtr, key, val);
		}

		public bool GetBool(uint key)
		{
			byte default_val = 0;

			var ret = ImGuiNative.ImGuiStorage_GetBool(NativePtr, key, default_val);
			return ret != 0;
		}
		public bool GetBool(uint key, bool default_val)
		{
			// Marshaling 'default_val' to native bool
			var native_default_val = default_val ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGuiStorage_GetBool(NativePtr, key, native_default_val);
			return ret != 0;
		}

		public void SetBool(uint key, bool val)
		{
			// Marshaling 'val' to native bool
			var native_val = val ? (byte)1 : (byte)0;

			ImGuiNative.ImGuiStorage_SetBool(NativePtr, key, native_val);
		}

		public float GetFloat(uint key)
		{
			float default_val = 0.0f;

			var ret = ImGuiNative.ImGuiStorage_GetFloat(NativePtr, key, default_val);
			return ret;
		}
		public float GetFloat(uint key, float default_val)
		{
			var ret = ImGuiNative.ImGuiStorage_GetFloat(NativePtr, key, default_val);
			return ret;
		}

		public void SetFloat(uint key, float val)
		{
			ImGuiNative.ImGuiStorage_SetFloat(NativePtr, key, val);
		}

		/// <summary>
		/// default_val is NULL
		/// </summary>
		public void* GetVoidPtr(uint key)
		{
			var ret = ImGuiNative.ImGuiStorage_GetVoidPtr(NativePtr, key);
			return ret;
		}

		public void SetVoidPtr(uint key, IntPtr val)
		{
			// Marshaling 'val' to native void pointer
			var native_val = val.ToPointer();

			ImGuiNative.ImGuiStorage_SetVoidPtr(NativePtr, key, native_val);
		}

		/// <summary>
		/// <para>- Get***Ref() functions finds pair, insert on demand if missing, return pointer. Useful if you intend to do Get+Set.</para>
		/// <para>- References are only valid until a new value is added to the storage. Calling a Set***() function or a Get***Ref() function invalidates the pointer.</para>
		/// <para>- A typical use case where this is convenient for quick hacking (e.g. add storage during a live Edit&amp;Continue session if you can't modify existing struct)</para>
		/// <para>     float* pvar = ImGui::GetFloatRef(key); ImGui::SliderFloat("var", pvar, 0, 100.0f); some_var += *pvar;</para>
		/// </summary>
		public int* GetIntRef(uint key)
		{
			int default_val = 0;

			var ret = ImGuiNative.ImGuiStorage_GetIntRef(NativePtr, key, default_val);
			return ret;
		}
		/// <summary>
		/// <para>- Get***Ref() functions finds pair, insert on demand if missing, return pointer. Useful if you intend to do Get+Set.</para>
		/// <para>- References are only valid until a new value is added to the storage. Calling a Set***() function or a Get***Ref() function invalidates the pointer.</para>
		/// <para>- A typical use case where this is convenient for quick hacking (e.g. add storage during a live Edit&amp;Continue session if you can't modify existing struct)</para>
		/// <para>     float* pvar = ImGui::GetFloatRef(key); ImGui::SliderFloat("var", pvar, 0, 100.0f); some_var += *pvar;</para>
		/// </summary>
		public int* GetIntRef(uint key, int default_val)
		{
			var ret = ImGuiNative.ImGuiStorage_GetIntRef(NativePtr, key, default_val);
			return ret;
		}

		public byte* GetBoolRef(uint key)
		{
			byte default_val = 0;

			var ret = ImGuiNative.ImGuiStorage_GetBoolRef(NativePtr, key, default_val);
			return ret;
		}
		public byte* GetBoolRef(uint key, bool default_val)
		{
			// Marshaling 'default_val' to native bool
			var native_default_val = default_val ? (byte)1 : (byte)0;

			var ret = ImGuiNative.ImGuiStorage_GetBoolRef(NativePtr, key, native_default_val);
			return ret;
		}

		public float* GetFloatRef(uint key)
		{
			float default_val = 0.0f;

			var ret = ImGuiNative.ImGuiStorage_GetFloatRef(NativePtr, key, default_val);
			return ret;
		}
		public float* GetFloatRef(uint key, float default_val)
		{
			var ret = ImGuiNative.ImGuiStorage_GetFloatRef(NativePtr, key, default_val);
			return ret;
		}

		public void** GetVoidPtrRef(uint key)
		{
			void* default_val = null;

			var ret = ImGuiNative.ImGuiStorage_GetVoidPtrRef(NativePtr, key, default_val);
			return ret;
		}
		public void** GetVoidPtrRef(uint key, IntPtr default_val)
		{
			// Marshaling 'default_val' to native void pointer
			var native_default_val = default_val.ToPointer();

			var ret = ImGuiNative.ImGuiStorage_GetVoidPtrRef(NativePtr, key, native_default_val);
			return ret;
		}

		/// <summary>
		/// <para>Advanced: for quicker full rebuild of a storage (instead of an incremental one), you may add all your contents and then sort once.</para>
		/// </summary>
		public void BuildSortByKey()
		{
			ImGuiNative.ImGuiStorage_BuildSortByKey(NativePtr);
		}

		/// <summary>
		/// <para>Obsolete: use on your own storage if you know only integer are being stored (open/close all tree nodes)</para>
		/// </summary>
		public void SetAllInt(int val)
		{
			ImGuiNative.ImGuiStorage_SetAllInt(NativePtr, val);
		}
	}
}
