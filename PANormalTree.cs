using System.Runtime.InteropServices;
using PA;

namespace PA
{
	    [StructLayout(LayoutKind.Sequential)]
	public partial struct PANormalTree
	{
		internal PATree Adj;

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
	}
}