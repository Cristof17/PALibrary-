using System.Xml.XPath;
namespace PA_Library {
	public class Arbore
	
	//public readonly class PAGraf
	//public struct PAGraf
	{
		[DllImport("palibrary")]
        public static extern void PATreeSearch();
		[DllImport("palibrary")]
        public static extern void PATreeConstruct();
		[DllImport("palibrary")]
        public static extern void PATreeRuin();
		[DllImport("palibrary")]
        public static extern void PATreeInit();
		[DllImport("palibrary")]
        public static extern void PATreeDelete();

		[StructLayout(LayoutKind.Sequential)]
		private struct PATree tree;

		public Arbore(Cardinal n, Cardinal m, Lista adj, Punct sursa)
        {
            
        }
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}