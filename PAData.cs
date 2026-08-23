using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAData
    {
        PAResource Resource;

        [LibraryImport("pa")]
        static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        static partial PAData PADataPerformInit(PAData data, PAResource resource);
        [LibraryImport("pa")]
        static partial PAData PADataPerformCopy(PAData from, PAData to);
        [LibraryImport("pa")]
        static partial PAData PADataPerformRuin(PAData pa);
        [LibraryImport("pa")]
        static partial PAData PADataPerformDelete(PAData pa);
    }
}