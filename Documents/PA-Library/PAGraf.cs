using System.Xml.XPath;
namespace PA_Library {
	public class PAGraf
	//public readonly class PAGraf
	//public struct PAGraf
	{
		[DllImport("palibrary.dll")]
        public static extern void PATreeSearch();
		[DllImport("palibrary.dll")]
        public static extern void PATreeConstruct();
		[DllImport("palibrary.dll")]
        public static extern void PATreeRuin();
		[DllImport("palibrary.dll")]
        public static extern void PATreeInit();
		[DllImport("palibrary.dll")]
        public static extern void PATreeDelete();

		[StructLayout(LayoutKind.Sequential)]
		private struct PATree tree;
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}