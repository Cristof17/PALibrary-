using System.Runtime.InteropServices;
using PA;
using BFS;
using System.Numerics;
namespace PA
{
    public readonly partial struct PAOutput
    {
        readonly BFSRecord Result;

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

        [LibraryImport("pa")]
        public static partial int PAOutputOperatorEqual(PAOutput one, PAOutput other);

        [LibraryImport("pa")]
        public static partial int PAOutputOperatorNotEqual(PAOutput one, PAOutput other);

        public static bool operator ==(PAOutput one, PAOutput other) => (PAOutputOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PAOutput one, PAOutput other) => (PAOutputOperatorNotEqual(one, other) == PA.PARESULT_SUCCESS) ? true : false;

        // public static bool operator ==(PAOutput one, PAOutput other) => one._result == other._result;
        // public static bool operator !=(PAOutput one, PAOutput other) => one._result != other._result;
    }
}