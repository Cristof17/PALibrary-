using System.Runtime.InteropServices;
using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAOutput
    {

        // public PAOutput(BFSRecord result) : this()
        // {
        //     PAOutput output;
        //     output = PAOutputPerformConstruct();
        //     output = PAOutputPerformInit(output, result);
        //     // o
        //     // result = BFSRecord.BFSRecordPerformCopy(output.result,result);
        // }
        internal required BFSRecord _result;

        public readonly BFSRecord result { get; }

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
        //struct Output dispose();

        // public PAOutput() : this()
        // {

        // }
    }
}