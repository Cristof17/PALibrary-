using System;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
        [StructLayout(LayoutKind.Sequential)]
    public partial struct PAList
    {
        internal PACount N;

        internal PASeries Adj;

        internal PACount N ;

        internal PASeries Adj;

        [LibraryImport("pa")]
        public static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAList PAListPerformInit(PAList list, PACount n, PASeries adj);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformCopy(PAList from, PAList to);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformDelete(PAList PA);
        [LibraryImport("pa")]
        public static partial void PAListPerformPrint(PAList List);
    }
}
