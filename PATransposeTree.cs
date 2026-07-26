using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PATransposeTree
	{
		public PATransposeTree(PATree Tree) : this()
		{
			PATransposeTree tree;
			tree = PATransposeTreePerformConstruct();
			tree = PATransposeTreePerformInit(tree, Tree);
			// tree
			tree.pa = PATree.PATreePerformCopy(Tree, tree.pa);
			pa = PATree.PATreePerformCopy(tree.pa, pa);
			// tree = PATree.PATreePerformConstruct();
			// tree = PATree.PATreePerformCopy(tree, tree);
		}
		private PATree pa;

		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformInit(PATransposeTree TransposeTree, PATree Tree);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformCopy(PATransposeTree From, PATransposeTree To);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformRuin(PATransposeTree PA);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformDelete(PATransposeTree PA);
	}
}