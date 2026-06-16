using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PANormalTree
	{
		PANormalTree(PATree Tree) : this()
		{
			tree = PATree.PATreePerformConstruct();
			tree = PATree.PATreePerformCopy(Tree,tree);	
		}
		private PATree tree;

		[DllImport("pa")]
		internal static extern PANormalTree PATreePerformConstruct();
		[DllImport("pa")]
		internal static extern PANormalTree PATreePerformInit([MarshalAs(UnmanagedType.IUnknown)] PANormalTree Tree, [MarshalAs(UnmanagedType.IUnknown)] PATree tree);
		[DllImport("pa")]
		internal static extern PANormalTree PATreePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PANormalTree from, [MarshalAs(UnmanagedType.IUnknown)] PANormalTree to);
		[DllImport("pa")]
		internal static extern PANormalTree PATreePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PANormalTree PA);
		[DllImport("pa")]
		internal static extern PANormalTree PATreePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PANormalTree PA);

	}
}