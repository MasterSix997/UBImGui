using System;
using UnityEngine;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SharpImGui.Internal
{
	/// <summary>
	/// <para>Store data emitted by TreeNode() for usage by TreePop()</para>
	/// <para>- To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data</para>
	/// <para>  which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().</para>
	/// <para>  Only stored when the node is a potential candidate for landing on a Left arrow jump.</para>
	/// </summary>
	public unsafe partial struct ImGuiTreeNodeStackData
	{
		public uint ID;
		public ImGuiTreeNodeFlags TreeFlags;
		/// <summary>
		/// Used for nav landing
		/// </summary>
		public ImGuiItemFlags ItemFlags;
		/// <summary>
		/// Used for nav landing
		/// </summary>
		public ImRect NavRect;
	}

	/// <summary>
	/// <para>Store data emitted by TreeNode() for usage by TreePop()</para>
	/// <para>- To implement ImGuiTreeNodeFlags_NavLeftJumpsBackHere: store the minimum amount of data</para>
	/// <para>  which we can't infer in TreePop(), to perform the equivalent of NavApplyItemToResult().</para>
	/// <para>  Only stored when the node is a potential candidate for landing on a Left arrow jump.</para>
	/// </summary>
	public unsafe partial struct ImGuiTreeNodeStackDataPtr
	{
		public ImGuiTreeNodeStackData* NativePtr { get; }
		public ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* nativePtr) => NativePtr = nativePtr;
		public ImGuiTreeNodeStackDataPtr(IntPtr nativePtr) => NativePtr = (ImGuiTreeNodeStackData*)nativePtr;
		public static implicit operator ImGuiTreeNodeStackDataPtr(ImGuiTreeNodeStackData* nativePtr) => new ImGuiTreeNodeStackDataPtr(nativePtr);
		public static implicit operator ImGuiTreeNodeStackData* (ImGuiTreeNodeStackDataPtr wrappedPtr) => wrappedPtr.NativePtr;
		public static implicit operator ImGuiTreeNodeStackDataPtr(IntPtr nativePtr) => new ImGuiTreeNodeStackDataPtr(nativePtr);

		public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);

		public ref ImGuiTreeNodeFlags TreeFlags => ref Unsafe.AsRef<ImGuiTreeNodeFlags>(&NativePtr->TreeFlags);

		/// <summary>
		/// Used for nav landing
		/// </summary>
		public ref ImGuiItemFlags ItemFlags => ref Unsafe.AsRef<ImGuiItemFlags>(&NativePtr->ItemFlags);

		/// <summary>
		/// Used for nav landing
		/// </summary>
		public ref ImRect NavRect => ref Unsafe.AsRef<ImRect>(&NativePtr->NavRect);
	}
}
