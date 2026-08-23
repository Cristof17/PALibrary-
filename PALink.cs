using System.Runtime.InteropServices;
using PA;

namespace PA
{
	    [StructLayout(LayoutKind.Sequential)]
	public partial struct PALink
	{
		internal PAPair Pair;

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