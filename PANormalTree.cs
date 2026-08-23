using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PANormalTree
	{
		PATree Adj;

		[LibraryImport("pa")]
		static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		static partial PANormalTree PANormalTreePerformInit(PANormalTree normalTree, PATree tree);
		[LibraryImport("pa")]
		static partial PANormalTree PANormalTreePerformCopy(PANormalTree from, PANormalTree to);
		[LibraryImport("pa")]
		static partial PANormalTree PANormalTreePerformRuin(PANormalTree pa);
		[LibraryImport("pa")]
		static partial PANormalTree PANormalTreePerformDelete(PANormalTree pa);
	}
}