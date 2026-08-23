using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAStatus
    {
        public int Visited;

        [LibraryImport("pa")]
        public static partial PAStatus PAStatusPerformConstruct();

        [LibraryImport("pa")]
        public static partial 
        PAStatus PAStatusPerformInit(PAStatus status, int visited);

        [LibraryImport("pa")]
        public static partial 
        PAStatus PAStatusPerformCopy(PAStatus from, PAStatus to);

        [LibraryImport("pa")]
        public static partial 
        PAStatus PAStatusPerformRuin(PAStatus pa);

        [LibraryImport("pa")]
        public static partial 
        PAStatus PAStatusPerformDelete(PAStatus pa);
    }
}