using System.Xml.XPath;
namespace PA_Library {
	public class Arbore
	
	//public readonly class PAGraf
	//public struct PAGraf
	{
	[DllImport("palibrary")]
        public static extern void PATreeSearch(PAElement nod);
		[DllImport("palibrary")]
        public static extern PATree PATreeConstruct(PACount n, PACount m, PAList adj, PAElement source);
		[DllImport("palibrary")]
        public static extern void PATreeRuin(PACount n, PACount m, PAList adj, PAElement source);
		[DllImport("palibrary")]
        public static extern PATree PATreeInit(PATree graf);
		[DllImport("palibrary")]
        public static extern int PATreeDelete(PATree PA);
		
		// [StructLayout(LayoutKind.Sequential)]
		// private struct PATree tree;
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}