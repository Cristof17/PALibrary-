using System.Runtime.InteropServices;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PALink
	{
		PAPair Pair;

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