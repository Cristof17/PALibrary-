using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PALink
	{
		public PALink(PAPair P) : this()
		{
			// p = PAPair.PAPairConstruct();
			PALink link;
			// p = new PAPair(P.node,P.neigh);
			link = PALinkPerformConstruct();
			link = PALinkPerformInit(link, p);
			// link.p = PAPair.PAPairPerformCopy()
			// link.p = PAPair.PAPairPerformCopy(P,link.p);
			// p = PAPair.PAPairPerformCopy(link.p,p);
			// link = PALin
			// p = 
			// p = Pair
		}
		PAPair p { get; set; }

		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformConstruct();
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformInit(PALink Link, PAPair Pair);
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformCopy(PALink From, PALink To);
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformRuin(PALink PA);
		[LibraryImport("pa")]
		internal static partial PALink PALinkPerformDelete(PALink PA);
	}
}