using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PATransposeTree
	{
		public PACount n;

		public PACount m;

		public PASeries adj;

		public PAElement sursa;

		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformConstruct();
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree Value);
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
		[DllImport("pa")]
		internal static extern PATransposeTree PATransposeTreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
		PATransposeTree(PATree tree) : this()
		{

		}
	}
}