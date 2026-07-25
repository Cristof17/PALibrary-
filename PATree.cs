// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using PA;
using System.Runtime.InteropServices;
namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PATree
	{
		public PATree(PACount N, PACount M, PAList Adj, PAElement Sursa) : this()
		{
			PATree tree;
			tree = PATreePerformConstruct();
			tree = PATreePerformInit(tree,N,M,Adj,Sursa);
			// n = PACount.PACountPerformConstruct();
			n = PACount.PACountPerformCopy(tree.n, n);
			// m = PACount.PACountPerformConstruct();
			m = PACount.PACountPerformCopy(tree.m, m);
			tree.adj = PAList.PAListPerformCopy(Adj,tree.adj);
			adj = PAList.PAListPerformCopy(tree.adj,adj);
			// sursa = PAElement.PAElementPerformConstruct();
			sursa = PAElement.PAElementPerformCopy(tree.sursa, sursa);
		}
		private PACount n;

		private PACount m;

		private PAList adj;

		private PAElement sursa;

		[LibraryImport("pa")]
		public static extern PATree PATreePerformConstruct();
		[LibraryImport("pa")]
		public  extern PATree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATree Tree, [MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
		[LibraryImport("pa")]
		public extern PATree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[LibraryImport("pa")]
		public static extern PATree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		[LibraryImport("pa")]
		internal static partial int PATreePerformRuin(PATree PA);
    }
}