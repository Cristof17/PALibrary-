using System.Runtime.InteropServices;
using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAOutput
    {
        private BFSRecord result;

        public PAOutput(BFSRecord result) : this()
        {
            PAOutput output;
            output = PAOutputPerformConstruct();
            output = PAOutputPerformInit(output, result);
            // o
            // result = BFSRecord.BFSRecordPerformCopy(output.result,result);
        }
        [LibraryImport("pa")]
        internal static partial PAOutput PAOutputPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAOutput PAOutputPerformInit(PAOutput Output, BFSRecord Record);
        [LibraryImport("pa")]
        internal static partial PAOutput PAOutputPerformCopy(PAOutput From, PAOutput To);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformRuin(PAOutput PA);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformDelete(PAOutput PA);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformPrint(int Result);
        //struct Output dispose();

        // public PAOutput() : this()
        // {

        // }
    }
}