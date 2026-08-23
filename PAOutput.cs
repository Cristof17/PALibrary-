using System.Runtime.InteropServices;
// using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAOutput
    {
        BFSRecord Result;

        [LibraryImport("pa")]
        internal static partial PAOutput PAOutputPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAOutput PAOutputPerformInit(PAOutput output, BFSRecord record);
        [LibraryImport("pa")]
        internal static partial PAOutput PAOutputPerformCopy(PAOutput from, PAOutput to);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformRuin(PAOutput pa);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformDelete(PAOutput pa);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformPrint(int result);
    }
}