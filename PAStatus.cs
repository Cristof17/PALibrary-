using System.Runtime.InteropServices;
using PA;

namespace PA
{
    // internal enum PAStatus {
        // STATUS_VISITED=0,
        // s
        // STATUS_NOT_VISITED=1
    [StructLayout(LayoutKind.Sequential)]
    public struct PAStatus
    {
        public PAStatus(bool Visited) : this()
        {
            // Visited = visited;
            visited = (Visited == true) ? 0x01 : 0x00;
            // visited = (int) (Visited & (0x01));
            // PAStatus status;
            PAStatus status = PAStatusPerformConstruct();
            status = PAStatusPerformInit(status,visited);
            // status = PAStatusPerformInit(status,)
        }
        private int visited;

        // public PAResource resource;

        [LibraryImport("pa")]
        internal static extern PAStatus PAStatusPerformConstruct();
        [LibraryImport("pa")]
        internal static extern PAStatus PAStatusPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAStatus Status, [MarshalAs(UnmanagedType.IUnknown)] int Visited);
        [LibraryImport("pa")]
        internal static extern PAStatus PAStatusPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAStatus from, [MarshalAs(UnmanagedType.IUnknown)] PAStatus to);
        [LibraryImport("pa")]
        internal static extern PAStatus PAStatusPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
        [LibraryImport("pa")]
        internal static extern PAStatus PAStatusPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
    }
    // }
}