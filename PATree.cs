// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
	public readonly partial struct PATree
	{

		PACount N;

		PACount M;

		PAList Adj;

		PAElement Sursa;

		// internal readonly PACount _n;

		// internal readonly PACount _m;

		// internal readonly PAList _adj;

		// internal readonly PAElement _sursa;

		[LibraryImport("pa")]
		internal static partial PATree PATreePerformConstruct();
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformInit(PATree tree, PACount n, PACount m, PAList list, PAElement element);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformCopy(PATree from, PATree to);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformRuin(PATree pa);
		[LibraryImport("pa")]
		internal static partial PATree PATreePerformDelete(PATree pa);
	}
}