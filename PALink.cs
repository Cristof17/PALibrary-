using System.Runtime.InteropServices;
using PA;

namespace PA
{
	public readonly partial struct PALink
	{
		public readonly PAPair Pair
        { 
			get
            {
				return _p;
            }
        } 

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