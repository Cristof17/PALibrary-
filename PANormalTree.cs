using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PANormalTree
	{
		public PANormalTree(PATree Tree) : this()
		{
			// PATreePerformConstruct tre
			PANormalTree tree;
			tree = PANormalTreePerformConstruct();
			tree = PANormalTreePerformInit(tree,Tree);
			tree.tree = PATree.PATreePerformCopy(Tree, tree.pa);
			pa = PATree.PATreePerformCopy(tree.pa,pa);
			// tree.tree = PA
			// tree = PATree.PATreePerformConstruct();
		}
		private PATree pa;

		[DllImport("pa")]
		internal static extern PANormalTree PANormalTreePerformConstruct();
		[DllImport("pa")]
		internal static extern PANormalTree PANormalTreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PANormalTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree tree);
		[DllImport("pa")]
		internal static extern PANormalTree PANormalTreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PANormalTree from, [MarshalAs(UnmanagedType.IUnknown)] PANormalTree to);
		[DllImport("pa")]
		internal static extern PANormalTree PANormalTreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PANormalTree PA);
		[DllImport("pa")]
		internal static extern PANormalTree PANormalTreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PANormalTree PA);
    }
}