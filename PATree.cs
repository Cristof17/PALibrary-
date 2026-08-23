// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	public partial struct PATree
	{

		public PACount N ;

		public PACount M ;

		public PAList Adj;

		public PAElement Sursa;

		[LibraryImport("pa")]
		public static partial PATree PATreePerformConstruct();
		[LibraryImport("pa")]
		public static partial PATree PATreePerformInit(PATree tree, PACount n, PACount m, PAList list, PAElement element);
		[LibraryImport("pa")]
		public static partial PATree PATreePerformCopy(PATree from, PATree to);
		[LibraryImport("pa")]
		public static partial PATree PATreePerformRuin(PATree pa);
		[LibraryImport("pa")]
		public static partial PATree PATreePerformDelete(PATree pa);
	}
}