using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	protected struct PALink
	{
		PAPair p;

		[DllImport("pa")]
		static extern PALink PALinkPerformConstruct();
		[DllImport("pa")]
		static extern PALink PALinkPerformInit([MarshalAs(UnmanagedType.IUnknown)] PALink init, [MarshalAs(UnmanagedType.IUnknown)] PAPair pair);
		[DllImport("pa")]
		static extern PALink PALinkPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PALink from, [MarshalAs(UnmanagedType.IUnknown)] PALink to);
		[DllImport("pa")]
		static extern PALink PALinkPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
		[DllImport("pa")]
		static extern PALink PALinkPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
	}
}