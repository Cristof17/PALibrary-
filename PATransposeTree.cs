using System.Runtime.InteropServices;
// using PA;

namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PATransposeTree
	{
		PATree Adj_trans;

		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformInit(PATransposeTree transposeTree, PATree tree);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformCopy(PATransposeTree from, PATransposeTree to);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformRuin(PATransposeTree pa);
		[LibraryImport("pa")]
		internal static partial PATransposeTree PATransposeTreePerformDelete(PATransposeTree pa);
	}
}