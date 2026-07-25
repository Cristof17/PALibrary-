using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PALink
	{
		public PALink(PAPair P) : this()
        {
            // p = PAPair.PAPairConstruct();
			PALink link;
			// p = new PAPair(P.node,P.neigh);
			link = PALinkPerformConstruct();
			link = PALinkPerformInit(link,p);
			// link.p = PAPair.PAPairPerformCopy()
			// link.p = PAPair.PAPairPerformCopy(P,link.p);
			// p = PAPair.PAPairPerformCopy(link.p,p);
			// link = PALin
			// p = 
			// p = Pair
        }
		PAPair p;

		[LibraryImport("pa")]
		internal static extern PALink PALinkPerformConstruct();
		[LibraryImport("pa")]
		internal static extern PALink PALinkPerformInit([MarshalAs(UnmanagedType.IUnknown)] PALink init, [MarshalAs(UnmanagedType.IUnknown)] PAPair pair);
		[LibraryImport("pa")]
		internal static extern PALink PALinkPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PALink from, [MarshalAs(UnmanagedType.IUnknown)] PALink to);
		[LibraryImport("pa")]
		internal static extern PALink PALinkPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
		[LibraryImport("pa")]
		internal static extern PALink PALinkPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
    }
}