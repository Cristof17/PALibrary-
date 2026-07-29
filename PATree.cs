// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PATree
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
		public readonly PACount n => _n;
		// { 
		// 	get
        //     {
		// 		return _n;
        //     }
		// }

		public readonly PACount m => _m;
		// { 
		// 	get
        //     {
		// 		return _m;
        //     } 
		// }

		public readonly PAList adj => _adj;
		// { 
		// 	get
        //     {
        //         return _adj;
        //     }
		// }

		public readonly PAElement sursa => _sursa;
		// { 
		// 	get
        //     {
		// 		return _sursa;
        //     }
		// }

		internal PACount _n;

		internal PACount _m;

		internal PAList _adj;

		internal PAElement _sursa;

		[LibraryImport("pa")]
		internal static partial PATree PATreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformInit(PATree tree, PACount n, PACount m, PAList list, PAElement element);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformCopy(PATree from, PATree to);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformRuin(PATree pa);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformDelete(PATree pa);
	}
}