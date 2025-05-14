using System;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;

namespace SharpImGui
{
	/// <summary>
	/// Routing table: maintain a desired owner for each possible key-chord (key + mods), and setup owner in NewFrame() when mods are matching.<br/>Stored in main context (1 instance)<br/>
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public partial struct ImGuiKeyRoutingTable
	{
		/// <summary>
		/// Index of first entry in Entries[]<br/>
		/// </summary>
		public short Index_0;
		public short Index_1;
		public short Index_2;
		public short Index_3;
		public short Index_4;
		public short Index_5;
		public short Index_6;
		public short Index_7;
		public short Index_8;
		public short Index_9;
		public short Index_10;
		public short Index_11;
		public short Index_12;
		public short Index_13;
		public short Index_14;
		public short Index_15;
		public short Index_16;
		public short Index_17;
		public short Index_18;
		public short Index_19;
		public short Index_20;
		public short Index_21;
		public short Index_22;
		public short Index_23;
		public short Index_24;
		public short Index_25;
		public short Index_26;
		public short Index_27;
		public short Index_28;
		public short Index_29;
		public short Index_30;
		public short Index_31;
		public short Index_32;
		public short Index_33;
		public short Index_34;
		public short Index_35;
		public short Index_36;
		public short Index_37;
		public short Index_38;
		public short Index_39;
		public short Index_40;
		public short Index_41;
		public short Index_42;
		public short Index_43;
		public short Index_44;
		public short Index_45;
		public short Index_46;
		public short Index_47;
		public short Index_48;
		public short Index_49;
		public short Index_50;
		public short Index_51;
		public short Index_52;
		public short Index_53;
		public short Index_54;
		public short Index_55;
		public short Index_56;
		public short Index_57;
		public short Index_58;
		public short Index_59;
		public short Index_60;
		public short Index_61;
		public short Index_62;
		public short Index_63;
		public short Index_64;
		public short Index_65;
		public short Index_66;
		public short Index_67;
		public short Index_68;
		public short Index_69;
		public short Index_70;
		public short Index_71;
		public short Index_72;
		public short Index_73;
		public short Index_74;
		public short Index_75;
		public short Index_76;
		public short Index_77;
		public short Index_78;
		public short Index_79;
		public short Index_80;
		public short Index_81;
		public short Index_82;
		public short Index_83;
		public short Index_84;
		public short Index_85;
		public short Index_86;
		public short Index_87;
		public short Index_88;
		public short Index_89;
		public short Index_90;
		public short Index_91;
		public short Index_92;
		public short Index_93;
		public short Index_94;
		public short Index_95;
		public short Index_96;
		public short Index_97;
		public short Index_98;
		public short Index_99;
		public short Index_100;
		public short Index_101;
		public short Index_102;
		public short Index_103;
		public short Index_104;
		public short Index_105;
		public short Index_106;
		public short Index_107;
		public short Index_108;
		public short Index_109;
		public short Index_110;
		public short Index_111;
		public short Index_112;
		public short Index_113;
		public short Index_114;
		public short Index_115;
		public short Index_116;
		public short Index_117;
		public short Index_118;
		public short Index_119;
		public short Index_120;
		public short Index_121;
		public short Index_122;
		public short Index_123;
		public short Index_124;
		public short Index_125;
		public short Index_126;
		public short Index_127;
		public short Index_128;
		public short Index_129;
		public short Index_130;
		public short Index_131;
		public short Index_132;
		public short Index_133;
		public short Index_134;
		public short Index_135;
		public short Index_136;
		public short Index_137;
		public short Index_138;
		public short Index_139;
		public short Index_140;
		public short Index_141;
		public short Index_142;
		public short Index_143;
		public short Index_144;
		public short Index_145;
		public short Index_146;
		public short Index_147;
		public short Index_148;
		public short Index_149;
		public short Index_150;
		public short Index_151;
		public short Index_152;
		public short Index_153;
		public short Index_154;
		public ImVector<ImGuiKeyRoutingData> Entries;
		/// <summary>
		/// Double-buffer to avoid reallocation (could use a shared buffer)<br/>
		/// </summary>
		public ImVector<ImGuiKeyRoutingData> EntriesNext;
	}

	/// <summary>
	/// Routing table: maintain a desired owner for each possible key-chord (key + mods), and setup owner in NewFrame() when mods are matching.<br/>Stored in main context (1 instance)<br/>
	/// </summary>
	public unsafe partial struct ImGuiKeyRoutingTablePtr
	{
		public ImGuiKeyRoutingTable* NativePtr { get; }
		public bool IsNull => NativePtr == null;
		public ImGuiKeyRoutingTable this[int index] { get => NativePtr[index]; set => NativePtr[index] = value; }
		/// <summary>
		/// Index of first entry in Entries[]<br/>
		/// </summary>
		public Span<short> Index => new Span<short>(&NativePtr->Index_0, 155);
		public ref ImVector<ImGuiKeyRoutingData> Entries => ref Unsafe.AsRef<ImVector<ImGuiKeyRoutingData>>(&NativePtr->Entries);
		/// <summary>
		/// Double-buffer to avoid reallocation (could use a shared buffer)<br/>
		/// </summary>
		public ref ImVector<ImGuiKeyRoutingData> EntriesNext => ref Unsafe.AsRef<ImVector<ImGuiKeyRoutingData>>(&NativePtr->EntriesNext);
		public ImGuiKeyRoutingTablePtr(ImGuiKeyRoutingTable* nativePtr) => NativePtr = nativePtr;
		public ImGuiKeyRoutingTablePtr(IntPtr nativePtr) => NativePtr = (ImGuiKeyRoutingTable*)nativePtr;
		public static implicit operator ImGuiKeyRoutingTablePtr(ImGuiKeyRoutingTable* ptr) => new ImGuiKeyRoutingTablePtr(ptr);
		public static implicit operator ImGuiKeyRoutingTablePtr(IntPtr ptr) => new ImGuiKeyRoutingTablePtr(ptr);
		public static implicit operator ImGuiKeyRoutingTable*(ImGuiKeyRoutingTablePtr nativePtr) => nativePtr.NativePtr;
		public void Clear()
		{
			ImGuiNative.ImGuiKeyRoutingTableClear(NativePtr);
		}

		public void Destroy()
		{
			ImGuiNative.ImGuiKeyRoutingTableDestroy(NativePtr);
		}

		public void ImGuiKeyRoutingTableConstruct()
		{
			ImGuiNative.ImGuiKeyRoutingTableImGuiKeyRoutingTableConstruct(NativePtr);
		}

		public ImGuiKeyRoutingTablePtr ImGuiKeyRoutingTable()
		{
			return ImGuiNative.ImGuiKeyRoutingTableImGuiKeyRoutingTable();
		}

	}
}
