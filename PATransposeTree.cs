using System.Runtime.InteropServices;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	protected struct PATransposeTree
	{
		PACount n;

		PACount m;

		PASeries adj;

		PAElement sursa;

		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformConstruct();
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree Value);
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree from, [MarshalAs(UnmanagedType.IUnknown)] PATree to);
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
		[DllImport("pa")]
		static extern PATransposeTree PATransposeTreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PATransposeTree PA);
		PATransposeTree(PATree tree) : this()
		{

		}
	}
}