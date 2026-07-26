using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	internal partial struct PANormalTree
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
		internal required PATree _pa { get; set; }

		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformInit(PANormalTree normalTree, PATree tree);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformCopy(PANormalTree from, PANormalTree to);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformRuin(PANormalTree pa);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformDelete(PANormalTree pa);
	}
}