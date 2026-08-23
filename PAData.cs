using System.ComponentModel;
using System.Runtime.InteropServices;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAData
    {
        PAResource Resource;

        [LibraryImport("pa")]
        internal static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformInit(PAData data, PAResource resource);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformCopy(PAData from, PAData to);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformRuin(PAData pa);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformDelete(PAData pa);
    }
}