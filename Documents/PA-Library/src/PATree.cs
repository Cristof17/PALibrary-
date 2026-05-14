// using System.Xml.XPath;
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

		[DllImport("palibrary")]
        private static extern void PATreeSearch(PAElement nod);
		[DllImport("palibrary")]
        private static extern PATree PATreeConstruct(PACount n, PACount m, PAList adj, PAElement source);
		[DllImport("palibrary")]
        private static extern void PATreeRuin( PACount n, PACount m, PAList adj, PAElement source);
		[DllImport("palibrary")]
        private static extern PATree PATreeInit(PATree graf);
		[DllImport("palibrary")]
        private static extern int PATreeDelete(PATree PA);

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