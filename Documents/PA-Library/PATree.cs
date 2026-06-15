using System.Xml.XPath;
using System.Runtime.InteropServices;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	struct PATree

	//public readonly class PAGraf
	//public struct PAGraf
	{
		PACount n;

		PACount m;

		PASeries adj;

		PAElement sursa;

		[DllImport("pa")]
		static extern PATree PATreePerformConstruct();
		// DllExport struct PACount PATreeSize();
		[DllImport("pa")]
		static extern PATree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATree Tree, [MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
		// DllExport HRESULT PATreePerformCopy();
		// DllExport HRESULT PATreePerformPutCount(struct PACount, struct PACount);
		// struct PATree PATreePutList(struct PATree, struct PAList);
		// DllExport HRESULT PATreePerformPutElement();
		// DllExport HRESULT PATreePerformPutSeries();
		[DllImport("pa")]
		static extern PATree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		static extern PATree PATreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		[DllImport("pa")]
		static extern PATree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		// [DllImport("palibrary")]
		// public static extern void PATreeSearch(PAElement nod);
		// [DllImport("palibrary")]
		// public static extern PATree PATreeConstruct(PACount n, PACount m, PAList adj, PAElement source);
		// [DllImport("palibrary")]
		// public static extern void PATreeRuin( PACount n, PACount m, PAList adj, PAElement source);
		// [DllImport("palibrary")]
		// public static extern PATree PATreeInit(PATree graf);
		// [DllImport("palibrary")]
		// public static extern int PATreeDelete(PATree PA);

		// [StructLayout(LayoutKind.Sequential)]
		// private  PATree tree { get;}

		// public PATree(Cardinal n, Cardinal m, Lista adj, Punct sursa)
		PATree(PACount n, PACount m, PASeries adj, PAElement sursa) : this()
		{

		}
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}