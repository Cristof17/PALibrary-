using System.Xml.XPath;
namespace PA_Library {
	[StructLayout(LayoutKind.Sequential)]
	public struct PATree
	
	//public readonly class PAGraf
	//public struct PAGraf
	{
		[DllImport("palibrary")]
        public static extern void PATreeSearch(struct PAElement nod);
		[DllImport("palibrary")]
        public static extern struct PATree PATreeConstruct(struct PACount n, struct PACount m, struct PAList adj, struct PAElement source);
		[DllImport("palibrary")]
        public static extern void PATreeRuin(struct PACount n, struct PACount m, struct PAList adj, struct PAElement source);
		[DllImport("palibrary")]
        public static extern struct PATree PATreeInit(struct PATree graf);
		[DllImport("palibrary")]
        public static extern int PATreeDelete(struct PATree PA);

		[StructLayout(LayoutKind.Sequential)]
		private struct PATree tree { get;}

		public PATree(Cardinal n, Cardinal m, Lista adj, Punct sursa)
        {
            
        }
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}