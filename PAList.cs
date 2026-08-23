using System;
using System.Runtime.InteropServices;
using PA;
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
        static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        static partial PAList PAListPerformInit(PAList list, PACount n, PASeries adj);
        [LibraryImport("pa")]
        static partial PAList PAListPerformCopy(PAList from, PAList to);
        [LibraryImport("pa")]
        static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        static partial PAList PAListPerformDelete(PAList PA);
        [LibraryImport("pa")]
        static partial void PAListPerformPrint(PAList List);
    }
}
