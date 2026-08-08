using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public readonly partial struct PANormalTree
	{
		// public PANormalTree(PATree Tree) : this()
		// {
		// 	// PATreePerformConstruct tre
		// 	PANormalTree tree;
		// 	tree = PANormalTreePerformConstruct();
		// 	tree = PANormalTreePerformInit(tree, Tree);
		// 	tree.pa = PATree.PATreePerformCopy(Tree, tree.pa);
		// 	pa = PATree.PATreePerformCopy(tree.pa, pa);
		// 	// tree.tree = PA
		// 	// tree = PATree.PATreePerformConstruct();
		// }

		public readonly PATree Pa => _pa;
		// { 
		// 	get
        //     {
		// 		return _pa;
        //     } 
		// }

		internal readonly PATree _pa;

		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformInit(PANormalTree normalTree, PATree tree);
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformCopy(PANormalTree from, PANormalTree to);
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformRuin(PANormalTree pa);
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformDelete(PANormalTree pa);
	}
}