using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PANormalTree
	{
		public PANormalTree(PATree Tree) : this()
		{
			// PATreePerformConstruct tre
			PANormalTree tree;
			tree = PANormalTreePerformConstruct();
			tree = PANormalTreePerformInit(tree, Tree);
			tree.pa = PATree.PATreePerformCopy(Tree, tree.pa);
			pa = PATree.PATreePerformCopy(tree.pa, pa);
			// tree.tree = PA
			// tree = PATree.PATreePerformConstruct();
		}
		private PATree pa { get; set; }

		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformInit(PANormalTree NormalTree, PATree Tree);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformCopy(PANormalTree From, PANormalTree To);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformRuin(PANormalTree PA);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformDelete(PANormalTree PA);
	}
}