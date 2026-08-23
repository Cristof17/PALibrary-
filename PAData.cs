using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAData
    {
        public PAResource Resource;

        [LibraryImport("pa")]
        public static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAData PADataPerformInit(PAData data, PAResource resource);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformCopy(PAData from, PAData to);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformRuin(PAData pa);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformDelete(PAData pa);
    }
}