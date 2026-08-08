using System.Runtime.InteropServices;
using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAOutput
    {

        // public PAOutput(BFSRecord result) : this()
        // {
        //     PAOutput output;
        //     output = PAOutputPerformConstruct();
        //     output = PAOutputPerformInit(output, result);
        //     // o
        //     // result = BFSRecord.BFSRecordPerformCopy(output.result,result);
        // }
        public readonly BFSRecord Result => _result;
        // { 
        //     get
        //     {
        //         return _result;       
        //     }
        // }

        internal readonly BFSRecord _result;

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
        //struct Output dispose();

        // public PAOutput() : this()
        // {

        // }
    }
}