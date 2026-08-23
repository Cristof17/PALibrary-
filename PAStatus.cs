using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAStatus
    {
        int Visited;

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformConstruct();

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformInit(PAStatus status, int visited);

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformCopy(PAStatus from, PAStatus to);

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformRuin(PAStatus pa);

        [LibraryImport("pa")]
        internal static partial 
        PAStatus PAStatusPerformDelete(PAStatus pa);
    }
}