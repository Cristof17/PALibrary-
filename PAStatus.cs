using System.Runtime.InteropServices;
using PA;

namespace PA
{
    // internal enum PAStatus {
    // STATUS_VISITED=0,
    // s
    // STATUS_NOT_VISITED=1
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAStatus
    {
        // internal PAStatus(bool Visited) : this()
        // {
        //     // Visited = visited;
        //     visited = (Visited == true) ? 0x01 : 0x00;
        //     // visited = (int) (Visited & (0x01));
        //     // PAStatus status;
        //     PAStatus status = PAStatusPerformConstruct();
        //     status = PAStatusPerformInit(status, visited);
        //     // status = PAStatusPerformInit(status,)
        // }
        internal required int visited { get; set; }

        // public PAResource resource;

        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformInit(PAStatus Status, int Visited);
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformCopy(PAStatus From, PAStatus To);
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformRuin(PAStatus PA);
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformDelete(PAStatus PA);
    }
    // }
}