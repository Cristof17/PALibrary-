using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAStatus
    {
        int Visited;

        [LibraryImport("pa")]
        static partial PAStatus PAStatusPerformConstruct();

        [LibraryImport("pa")]
        static partial 
        PAStatus PAStatusPerformInit(PAStatus status, int visited);

        [LibraryImport("pa")]
        static partial 
        PAStatus PAStatusPerformCopy(PAStatus from, PAStatus to);

        [LibraryImport("pa")]
        static partial 
        PAStatus PAStatusPerformRuin(PAStatus pa);

        [LibraryImport("pa")]
        static partial 
        PAStatus PAStatusPerformDelete(PAStatus pa);
    }
}