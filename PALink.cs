using PA_Library;

using System.Runtime.InteropServices;
namespace PA_Library
{
	[StructLayout(LayoutKind.Sequential)]
	protected struct PALink
	{
		PAPair p;

		[DllImport("pa")]
		static extern PALink PALinkPerformConstruct();
		[DllImport("pa")]
		// DllExport struct PALink PALinkPerformCopy(struct PALink);
		static extern PALink PALinkPerformInit([MarshalAs(UnmanagedType.IUnknown)] PALink init, [MarshalAs(UnmanagedType.IUnknown)] PAPair pair);
		[DllImport("pa")]
		static extern PALink PALinkPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PALink from, [MarshalAs(UnmanagedType.IUnknown)] PALink to);
		[DllImport("pa")]
		static extern PALink PALinkPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
		[DllImport("pa")]
		// DllExport struct PALink PALinkPerformPutPair(struct PALink,struct PAPair);
		static extern PALink PALinkPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PALink PA);
	}
}