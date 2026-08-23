// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
// using PA;
namespace PA
{
	[StructLayout(LayoutKind.Sequential)]
	partial struct PATree
	{

		PACount N ;

		PACount M ;

		PAList Adj;

		PAElement Sursa;

		[LibraryImport("pa")]
		static partial PATree PATreePerformConstruct();
		[LibraryImport("pa")]
		static partial PATree PATreePerformInit(PATree tree, PACount n, PACount m, PAList list, PAElement element);
		[LibraryImport("pa")]
		static partial PATree PATreePerformCopy(PATree from, PATree to);
		[LibraryImport("pa")]
		static partial PATree PATreePerformRuin(PATree pa);
		[LibraryImport("pa")]
		static partial PATree PATreePerformDelete(PATree pa);
	}
}