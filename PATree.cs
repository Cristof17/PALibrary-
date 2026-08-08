// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public readonly partial struct PATree
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
		public readonly PACount N => _n;
		// { 
		// 	get
        //     {
		// 		return _n;
        //     }
		// }

		public readonly PACount M => _m;
		// { 
		// 	get
        //     {
		// 		return _m;
        //     } 
		// }

		public readonly PAList Adj => _adj;
		// { 
		// 	get
        //     {
        //         return _adj;
        //     }
		// }

		public readonly PAElement Sursa => _sursa;
		// { 
		// 	get
        //     {
		// 		return _sursa;
        //     }
		// }

		internal readonly PACount _n;

		internal readonly PACount _m;

		internal readonly PAList _adj;

		internal readonly PAElement _sursa;

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