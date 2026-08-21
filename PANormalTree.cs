using System.Runtime.InteropServices;
using PA;

namespace PA
{
	public readonly partial struct PANormalTree
	{
		public readonly PATree Adj
        {
			get
            {
				return _adj;
            }
        }

		public PAElement this[PAElement node]
        {
            get
            {
                return _adj[node];
            }
        }

		internal readonly PATree _adj;

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