using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PALink
	{
		public PALink(PAPair P)
        {
            p = PAPair.PAPairConstruct();
        }
		private PAPair p;

		[DllImport("pa")]
		internal static extern PALink PALinkPerformConstruct();
		[DllImport("pa")]
		internal static extern PALink PALinkPerformInit([MarshalAs(UnmanagedType.IUnknown)] PALink init, [MarshalAs(UnmanagedType.IUnknown)] PAPair pair);
		[DllImport("pa")]
		internal static extern PALink PALinkPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PALink from, [MarshalAs(UnmanagedType.IUnknown)] PALink to);
		[DllImport("pa")]
		internal static extern PALink PALinkPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
		[DllImport("pa")]
		internal static extern PALink PALinkPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
    }
}