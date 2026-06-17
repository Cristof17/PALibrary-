using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PATransposeTree : StateMachine
	{
		public PATransposeTree(PATree tree) : this()
		{
			tree = PATree.PATreePerformConstruct();
			tree = PATree.PATreePerformCopy(tree, tree);
		}
		private PATree tree;

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

        public void Construct()
        {
			Initialise();
            // throw new System.NotImplementedException();
        }

        public void Initialise()
        {
			Delete();
            // throw new System.NotImplementedException();
        }

        public void Delete()
        {
			Finish();
            // throw new System.NotImplementedException();
        }

        public void Finish()
        {
            // throw new System.NotImplementedException();
        }
    }
}