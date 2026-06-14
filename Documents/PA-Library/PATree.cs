using System.Xml.XPath;
using System.Runtime.InteropServices;
namespace PA_Library {
	[StructLayout(LayoutKind.Sequential)]
	public struct PATree

	//public readonly class PAGraf
	//public struct PAGraf
	{
		private PACount n;
		private PACount m ;
		private PASeries adj;
		private PAElement sursa;

		[DllImport("pa")]
 		static extern PATree PATreePerformConstruct();
 		[DllImport("pa")]
 		static extern PATree PATreePerformCopy( PATree from,  PATree to);
// DllExport struct PACount PATreeSize();
		[DllImport("pa")]
 		static extern PATree PATreePerformInit(PATree Tree,  PACount Count,  PACount Count2,  PAList List,  PAElement Element);
// DllExport HRESULT PATreePerformCopy();
// DllExport HRESULT PATreePerformPutCount(struct PACount, struct PACount);
// struct PATree PATreePutList(struct PATree, struct PAList);
// DllExport HRESULT PATreePerformPutElement();
// DllExport HRESULT PATreePerformPutSeries();
		[DllImport("pa")]
 		static extern PATree PATreePerformRuin( PATree PA);
 		[DllImport("pa")]
 		static extern PATree PATreePerformDelete( PATree PA);
		// [DllImport("palibrary")]
        // public static extern void PATreeSearch(PAElement nod);
		// [DllImport("palibrary")]
        // public static extern PATree PATreeConstruct(PACount n, PACount m, PAList adj, PAElement source);
		// [DllImport("palibrary")]
        // public static extern void PATreeRuin( PACount n, PACount m, PAList adj, PAElement source);
		// [DllImport("palibrary")]
        // public static extern PATree PATreeInit(PATree graf);
		[DllImport("palibrary")]
        public static extern int PATreeDelete(PATree PA);

		// [StructLayout(LayoutKind.Sequential)]
		// private  PATree tree { get;}

		// public PATree(Cardinal n, Cardinal m, Lista adj, Punct sursa)
		public PATree(PACount n, PACount m, PASeries adj, PAElement sursa) : this()
        {

        }
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}