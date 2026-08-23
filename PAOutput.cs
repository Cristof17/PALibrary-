using System.Runtime.InteropServices;
using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAOutput
    {
        public BFSRecord Result;

        [LibraryImport("pa")]
        public static partial PAOutput PAOutputPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAOutput PAOutputPerformInit(PAOutput output, BFSRecord record);
        [LibraryImport("pa")]
        public static partial PAOutput PAOutputPerformCopy(PAOutput from, PAOutput to);
        [LibraryImport("pa")]
        public static partial void PAOutputPerformRuin(PAOutput pa);
        [LibraryImport("pa")]
        public static partial void PAOutputPerformDelete(PAOutput pa);
        [LibraryImport("pa")]
        public static partial void PAOutputPerformPrint(int result);
    }
}