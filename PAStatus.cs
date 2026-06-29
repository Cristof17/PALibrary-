using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAStatus
    {
        public PAStatus(int Visited) : this()
        {
            // Visited = visited;
            visited = Visited;
            PAStatus status;
            status = PAStatusPerformConstruct();
            // status = PAStatusPerformInit(status,)
        }
        private int visited;

        public PAResource resource;

        [DllImport("pa")]
        internal static extern PAStatus PAStatusPerformConstruct();
        [DllImport("pa")]
        internal static extern PAStatus PAStatusPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAStatus Status, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
        [DllImport("pa")]
        internal static extern PAStatus PAStatusPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAStatus from, [MarshalAs(UnmanagedType.IUnknown)] PAStatus to);
        [DllImport("pa")]
        internal static extern PAStatus PAStatusPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
        [DllImport("pa")]
        internal static extern PAStatus PAStatusPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
    }
}