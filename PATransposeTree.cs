// using System.Xml.XPath;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	protected struct PATransposeTree

	//public readonly class PAGraf
	//public struct PAGraf
	{
		PACount n;

		PACount m;

		PASeries adj;

		PAElement sursa;

		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformConstruct();
		// DllExport struct PACount PATreeSize();
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree Value);
		// DllExport HRESULT PATreePerformCopy();
		// DllExport HRESULT PATreePerformPutCount(struct PACount, struct PACount);
		// struct PATree PATreePutList(struct PATree, struct PAList);
		// DllExport HRESULT PATreePerformPutElement();
		// DllExport HRESULT PATreePerformPutSeries();
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
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
		// PANTree(PATree tree) : this()
		PATransposeTree(PATree tree) : this()
		{

		}
		// private PACardinal n { get; }
		// private PACardinal m { get; }
		// private PALista adj { get; }
		// private PANod sursa { get; }
	}
}