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
		internal static partial PATransposeTree PATransposeTreePerformInit(PATransposeTree Tree, PATree Value);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformCopy(PATransposeTree from, PATransposeTree to);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformDelete(PATransposeTree PA);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformRuin(PATransposeTree PA);
	}
}