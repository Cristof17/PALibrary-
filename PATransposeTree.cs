using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PATransposeTree
	{
		public PATransposeTree(PATree Tree) : this()
		{
			PATransposeTree tree;
			tree = PATransposeTreePerformConstruct();
			tree = PATransposeTreePerformInit(Tree,tree);
			// tree
			tree.pa = PATree.PATreePerformCopy(Tree.tree,tree.pa);
			pa = PATree.PATreePerformCopy(tree.pa,pa);
			// tree = PATree.PATreePerformConstruct();
			// tree = PATree.PATreePerformCopy(tree, tree);
		}
		private PATree pa;

		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformConstruct();
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree Value);
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
    }
}