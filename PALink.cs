using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public readonly partial struct PALink
	{
		// public PALink(PAPair P) : this()
		// {
		// 	// p = PAPair.PAPairConstruct();
		// 	PALink link;
		// 	// p = new PAPair(P.node,P.neigh);
		// 	link = PALinkPerformConstruct();
		// 	link = PALinkPerformInit(link, p);
		// 	// link.p = PAPair.PAPairPerformCopy()
		// 	// link.p = PAPair.PAPairPerformCopy(P,link.p);
		// 	// p = PAPair.PAPairPerformCopy(link.p,p);
		// 	// link = PALin
		// 	// p = 
		// 	// p = Pair
		// }
		public readonly PAPair Pair => _p;
		// { 
		// 	get
        //     {
        //         return _p;
        //     } 
		// }

		internal readonly PAPair _p;

		[LibraryImport("pa")]
		public static partial PALink PALinkPerformConstruct();
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformInit(PALink link, PAPair pair);
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformCopy(PALink from, PALink to);
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformRuin(PALink pa);
		[LibraryImport("pa")]
		public static partial PALink PALinkPerformDelete(PALink pa);
	}
}