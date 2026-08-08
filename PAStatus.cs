using System.Runtime.InteropServices;
using PA;

namespace PA
{
    // internal enum PAStatus {
    // STATUS_VISITED=0,
    // s
    // STATUS_NOT_VISITED=1
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAStatus
    {
        public readonly int Visited => _visited;

        internal readonly int _visited;

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