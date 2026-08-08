// using System.Linq.Expressions;
using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAElement
    {
        // public PAElement(PAData Data) : this()
        // {
        //     PAStatus status;
        //     PAData n;
        //     PAElement element;
        //     // status = PAStatus.STATUS_VISITED;
        //     // status = PAStatus.STATUS_NOT_VISITED;
        //     status = new PAStatus(false);
        //     element = PAElementPerformConstruct();
        //     element = PAElementPerformInit(element, Data, status);
        //     n = PAData.PADataPerformCopy(element.Index, Index);
        //     // index = 
        //     // index = PAData.PADataPerformConstruct();
        //     // status = PAStatus.PAStatusPerformConstruct();
        //     // status = PAStatus.PAStatusPerformCopy(element.status,status);
        // }
        public readonly PAData Index => _index;
        // {
        //     get
        //     {
        //         return _index;
        //     } 
        // }

        public readonly PAStatus Status => _status;

        public readonly PAList Adj => _next;

        // public readonly PAElement next => _next;
        // { 
        //     get
        //     {
        //         return _status;
        //     } 
        // }
        internal readonly PAData _index;

        internal readonly PAStatus _status;

        internal readonly PAList _next;


        [LibraryImport("pa")]
        public static partial PAElement PAElementPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAElement PAElementPerformInit(PAElement element, PAData data, PAStatus status);
        [LibraryImport("pa")]
        public static partial PAElement PAElementPerformCopy(PAElement from, PAElement to);
        [LibraryImport("pa")]
        public static partial PAElement PAElementPerformRuin(PAElement pa);
        [LibraryImport("pa")]
        public static partial PAElement PAElementPerformDelete(PAElement pa);
        [LibraryImport("pa")]
        public static partial int PAElementIsVisited(PAElement element);
        [LibraryImport("pa")]
        public static partial void PAElementReset(PAElement element);
    }
}