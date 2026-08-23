using System.Runtime.InteropServices;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PALink
	{
		PAPair Pair;

		[LibraryImport("pa")]
		static partial PALink PALinkPerformConstruct();
		[LibraryImport("pa")]
		static partial PALink PALinkPerformInit(PALink link, PAPair pair);
		[LibraryImport("pa")]
		static partial PALink PALinkPerformCopy(PALink from, PALink to);
		[LibraryImport("pa")]
		static partial PALink PALinkPerformRuin(PALink pa);
		[LibraryImport("pa")]
		static partial PALink PALinkPerformDelete(PALink pa);
	}
}