using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PATree
	{
		public PACount n;

		public PACount m;

		public PASeries adj;

		public PAElement sursa;

		[DllImport("pa")]
		internal static extern PATree PATreePerformConstruct();
		[DllImport("pa")]
		internal static extern PATree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATree Tree, [MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
		[DllImport("pa")]
		internal static extern PATree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		internal static extern PATree PATreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		[DllImport("pa")]
		internal static extern PATree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATree PA);
		PATree(PACount n, PACount m, PASeries adj, PAElement sursa) : this()
		{

		}
	}
}