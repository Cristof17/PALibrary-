using System.Runtime.InteropServices;
using PA;

namespace PA
{
	public readonly partial struct PATransposeTree
	{
		public readonly PATree Adj_trans
        {
        	get
            {
                return  _adj_trans;
            }   
        }

		public PAElement this[int node]
        {
			get
			{
				return _adj_trans[node];
			}
        }

		internal readonly PATree _adj_trans;

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