using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Store data emitted by TreeNode() for usage by TreePop()<br/>- To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data<br/>  which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().<br/>  Only stored when the node is a potential candidate for landing on a Left arrow jump.<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiTreeNodeStackData
	{
		public uint ID;
		public ImGuiTreeNodeFlags TreeFlags;
		/// <summary>
		/// Used for nav landing<br/>
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// Used for nav landing<br/>
		/// </summary>
		public ImRect NavRect;
	}

	/// <summary>
	/// Store data emitted by TreeNode() for usage by TreePop()<br/>- To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data<br/>  which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().<br/>  Only stored when the node is a potential candidate for landing on a Left arrow jump.<br/>
	/// </summary>
	public unsafe partial struct ImGuiTreeNodeStackDataPtr
	{
		public ImGuiTreeNodeStackData* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiTreeNodeStackData this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
		public ref ImGuiTreeNodeFlags TreeFlags => ref Unsafe.AsRef<ImGuiTreeNodeFlags>(&NativePtr->TreeFlags);
		/// <summary>
		/// Used for nav landing<br/>
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);
		/// <summary>
		/// Used for nav landing<br/>
		/// </summary>
		public ref ImRect NavRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavRect);
		public ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTreeNodeStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTreeNodeStackData*)nativePtr;
		public static implicit operator ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* ptr) => new ImGuiTreeNodeStackDataPtr(ptr);
		public static implicit operator ImGuiTreeNodeStackDataPtr(IntPtr ptr) => new ImGuiTreeNodeStackDataPtr(ptr);
		public static implicit operator ImGuiTreeNodeStackData*(ImGuiTreeNodeStackDataPtr nativePtr) => nativePtr.NativePtr;
	}
}
