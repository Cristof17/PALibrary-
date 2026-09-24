using System.Runtime.InteropServices;
using PA;

namespace PA
{
	public readonly partial struct PALink
	{
		PAPair Pair;

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
		[LibraryImport("pa")]
		PAResult PALinkOperatorEqual(PALink one, PALink other);
		[LibraryImport("pa")]
		PAResult PALinkOperatorNotEqual(PALink one, PALink other);
	}
}