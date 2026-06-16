using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAStatus
    {
        public int Visited;

        public PAResource resource;

        [DllImport("pa")]
        static extern PAStatus PAStatusPerformConstruct();
        [DllImport("pa")]
        static extern PAStatus PAStatusPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAStatus Status, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
        [DllImport("pa")]
        static extern PAStatus PAStatusPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAStatus from, [MarshalAs(UnmanagedType.IUnknown)] PAStatus to);
        [DllImport("pa")]
        static extern PAStatus PAStatusPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
        [DllImport("pa")]
        static extern PAStatus PAStatusPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
    }
}