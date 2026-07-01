using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PATree
	{
		public PATree(PACount N, PACount M, PAList ADJ, PAElement Sursa) : this()
		{
			PATree tree;
			tree = PATreePerformConstruct();
			tree = PATreePerformInit(tree,N,M,ADJ,Sursa);
			// n = PACount.PACountPerformConstruct();
			n = PACount.PACountPerformCopy(tree.n, n);
			// m = PACount.PACountPerformConstruct();
			m = PACount.PACountPerformCopy(tree.m, m);
			tree.adj = PAList.PAListPerformCopy(ADJ,tree.adj);
			adj = PAList.PAListPerformCopy(tree.adj,adj);
			// sursa = PAElement.PAElementPerformConstruct();
			sursa = PAElement.PAElementPerformCopy(tree.sursa, sursa);
		}
		private PACount n;

		private PACount m;

		private PASeries adj;

		private PAElement sursa;

		[DllImport("pa")]
		internal static extern PATree PATreePerformConstruct();
		[DllImport("pa")]
		internal static extern PATree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATree Tree, [MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
		[DllImport("pa")]
		internal static extern PATree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		internal static extern PATree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		[DllImport("pa")]
		internal static extern PATree PATreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
    }
}