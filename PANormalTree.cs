using System.Runtime.InteropServices;
// using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PANormalTree
	{
		PATree Adj;

		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformInit(PANormalTree normalTree, PATree tree);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformCopy(PANormalTree from, PANormalTree to);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformRuin(PANormalTree pa);
		[LibraryImport("pa")]
		internal static partial PANormalTree PANormalTreePerformDelete(PANormalTree pa);
	}
}