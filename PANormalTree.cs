using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	internal struct PANormalTree
	{
		PACount n;

		PACount m;

		PASeries adj;

		PAElement sursa;

		[DllImport("pa")]
		static extern PANormalTree PATreePerformConstruct();
		[DllImport("pa")]
		static extern PANormalTree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PANormalTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree tree);
		[DllImport("pa")]
		static extern PANormalTree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PANormalTree from, [MarshalAs(UnmanagedType.IUnknown)] PANormalTree to);
		[DllImport("pa")]
		static extern PANormalTree PATreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PANormalTree PA);
		[DllImport("pa")]
		static extern PANormalTree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PANormalTree PA);

		PANormalTree(PATree tree) : this()
		{

		}
	}
}