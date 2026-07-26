using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	internal partial struct PALink
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
		internal required PAPair _p { get; set; }

		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformConstruct();
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformInit(PALink link, PAPair pair);
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformCopy(PALink from, PALink to);
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformRuin(PALink pa);
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformDelete(PALink pa);
	}
}