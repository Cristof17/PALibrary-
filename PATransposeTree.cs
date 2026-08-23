using System.Runtime.InteropServices;
using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PATransposeTree
	{
		public PATree Adj_trans;

		[LibraryImport("pa")]
		public static partial PATransposeTree PATransposeTreePerformConstruct();
		[LibraryImport("pa")]
		public static partial PATransposeTree PATransposeTreePerformInit(PATransposeTree transposeTree, PATree tree);
		[LibraryImport("pa")]
		public static partial PATransposeTree PATransposeTreePerformCopy(PATransposeTree from, PATransposeTree to);
		[LibraryImport("pa")]
		public static partial PATransposeTree PATransposeTreePerformRuin(PATransposeTree pa);
		[LibraryImport("pa")]
		public static partial PATransposeTree PATransposeTreePerformDelete(PATransposeTree pa);
	}
}