using System.Runtime.InteropServices;
using PA;

namespace PA
{
	public readonly partial struct PANormalTree
	{
		PATree Pa;

		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformConstruct();
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformInit(PANormalTree normalTree, PATree tree);
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformCopy(PANormalTree from, PANormalTree to);
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformRuin(PANormalTree pa);
		[LibraryImport("pa")]
		public static partial PANormalTree PANormalTreePerformDelete(PANormalTree pa);
		[LibraryImport("pa")]
		PAResult PANormalTreeOperatorEqual(PANormalTree one, PANormalTree other);
		[LibraryImport("pa")]
		PAResult PANormalTreeOperatorNotEqual(PANormalTree one, PANormalTree other);
	}
}