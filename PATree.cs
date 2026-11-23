// using System.Runtime.InteropServices;
// // using System.Object;
// using System.Runtime.UnmanagedType;
using System;
using System.Runtime.InteropServices;

namespace PA
{
	public partial struct PATree
	{

		readonly PACount N { get {return _n;}}

		readonly PACount M { get {return _m;}}

		readonly PAList Adj {get {return _adj;}}

		readonly PAElement Sursa { get {return _sursa;}}

		internal readonly PACount _n;

		internal readonly PACount _m;

		internal readonly PAList _adj;

		internal readonly PAElement _sursa;

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
		[LibraryImport("pa")]
		internal static partial PAResult PATreeOperatorEqual(PATree one, PATree other);
		[LibraryImport("pa")]
		internal static partial PAResult PATreeOperatorNotEqual(PATree one, PATree other);

		internal UIntPtr this[PAElement element]
        {
			get
            {
            	return Adj[element];
            }
        }
	}
}