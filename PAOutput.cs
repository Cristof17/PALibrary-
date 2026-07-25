using System.Runtime.InteropServices;
using PA;
using BFS;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAOutput
    {
        private BFSRecord result;

        public PAOutput(BFSRecord result) : this()
        {
            PAOutput output;
            output = PAOutputPerformConstruct();
            output = PAOutputPerformInit(output,result);
            // o
            // result = BFSRecord.BFSRecordPerformCopy(output.result,result);
        }
        [LibraryImport("pa")]
        internal static extern PAOutput PAOutputPerformConstruct();
        [LibraryImport("pa")]
        internal static extern PAOutput PAOutputPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAOutput Output, [MarshalAs(UnmanagedType.IUnknown)] BFSRecord Record);
        [LibraryImport("pa")]
        internal static extern PAOutput PAOutputPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAOutput Output, [MarshalAs(UnmanagedType.IUnknown)] PAOutput to);
        [LibraryImport("pa")]
        internal static extern void PAOutputPerformPrint(int resulrt);
        //struct Output dispose();
        [LibraryImport("pa")]
        internal static extern void PAOutputPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAOutput PA);
        [LibraryImport("pa")]
        internal static extern void PAOutputPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAOutput PA);

        // public PAOutput() : this()
        // {

        // }
    }
}