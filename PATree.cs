using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PATree
	{
		PACount n;

		PACount m;

		PASeries adj;

		PAElement sursa;

		[DllImport("pa")]
		static extern PATree PATreePerformConstruct();
		[DllImport("pa")]
		static extern PATree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATree Tree, [MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
		[DllImport("pa")]
		static extern PATree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		static extern PATree PATreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		[DllImport("pa")]
		static extern PATree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		PATree(PACount n, PACount m, PASeries adj, PAElement sursa) : this()
		{

		}
	}
}