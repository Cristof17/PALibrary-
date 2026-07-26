// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using PA;
using System.Runtime.InteropServices;
namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PATree
	{
		// public PATree(PACount N, PACount M, PAList Adj, PAElement Sursa) : this()
		// {
		// 	PATree tree;
		// 	tree = PATreePerformConstruct();
		// 	tree = PATreePerformInit(tree, N, M, Adj, Sursa);
		// 	// n = PACount.PACountPerformConstruct();
		// 	n = PACount.PACountPerformCopy(tree.n, n);
		// 	// m = PACount.PACountPerformConstruct();
		// 	m = PACount.PACountPerformCopy(tree.m, m);
		// 	tree.adj = PAList.PAListPerformCopy(Adj, tree.adj);
		// 	adj = PAList.PAListPerformCopy(tree.adj, adj);
		// 	// sursa = PAElement.PAElementPerformConstruct();
		// 	sursa = PAElement.PAElementPerformCopy(tree.sursa, sursa);
		// }
		internal required PACount n { get; set; }

		internal required PACount m { get; set; }

		internal required PAList adj { get; set; }

		internal required PAElement sursa { get; set; }

		[LibraryImport("pa")]
		internal static partial PATree PATreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformInit(PATree Tree, PACount N, PACount M, PAList List, PAElement Element);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformCopy(PATree From, PATree To);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformRuin(PATree PA);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformDelete(PATree PA);
	}
}