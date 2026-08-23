using System;
using System.Runtime.InteropServices;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAList
    {
        PACount N;

        PASeries Adj;

        PACount N ;

        PASeries Adj;

        [LibraryImport("pa")]
        internal static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformInit(PAList list, PACount n, PASeries adj);
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformCopy(PAList from, PAList to);
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformDelete(PAList PA);
        [LibraryImport("pa")]
        internal static partial void PAListPerformPrint(PAList List);
    }
}
