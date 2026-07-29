using System.Runtime.InteropServices;
using PA;

namespace PA
{
    // internal enum PAStatus {
    // STATUS_VISITED=0,
    // s
    // STATUS_NOT_VISITED=1
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAStatus
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
        public readonly int visited => _visited;
        // { 
        //     get
        //     {
        //         return _visited;        
        //     } 
        // }

        internal int _visited;

        // public PAResource resource;

        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformInit(PAStatus status, int visited);
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformCopy(PAStatus from, PAStatus to);
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformRuin(PAStatus pa);
        [LibraryImport("pa")]
        internal static partial PAStatus PAStatusPerformDelete(PAStatus pa);
    }
    // }
}