using System.Runtime.InteropServices;
using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAOutput
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
        internal static partial PAOutput PAOutputPerformCopy(PAOutput Output, PAOutput to);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformPrint(int resulrt);
        //struct Output dispose();
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformDelete(PAOutput PA);
        [LibraryImport("pa")]
        internal static partial void PAOutputPerformRuin(PAOutput PA);

        // public PAOutput() : this()
        // {

        // }
    }
}