using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PATransposeTree
	{
		// public PATransposeTree(PATree Tree) : this()
		// {
		// 	PATransposeTree tree;
		// 	tree = PATransposeTreePerformConstruct();
		// 	tree = PATransposeTreePerformInit(tree, Tree);
		// 	// tree
		// 	tree.pa = PATree.PATreePerformCopy(Tree, tree.pa);
		// 	pa = PATree.PATreePerformCopy(tree.pa, pa);
		// 	// tree = PATree.PATreePerformConstruct();
		// 	// tree = PATree.PATreePerformCopy(tree, tree);
		// }
		public readonly PATree pa => _pa;
		// { 
		// 	get
        //     {
		// 		return _pa;
        //     } 
		// }

		internal PATree _pa;

		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformInit(PATransposeTree transposeTree, PATree tree);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformCopy(PATransposeTree from, PATransposeTree to);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformRuin(PATransposeTree pa);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformDelete(PATransposeTree pa);
	}
}