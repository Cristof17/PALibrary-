using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PANormalTree
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
		private PATree pa;

		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformInit(PANormalTree Tree, PATree tree);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformCopy(PANormalTree from, PANormalTree to);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformDelete(PANormalTree PA);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformRuin(PANormalTree PA);
	}
}