// using System.Linq.Expressions;
using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    public readonly partial struct PAElement
    {
        public readonly PAData Index
        {
            get
            {
                return _index; 
            }
        }

        public readonly PAStatus Status
        {
            get
            {
                return _status; 
            }
        } 

        public readonly unsafe PAElement* Next;
        // {    
        //     get
        //     {
        //         return _next; 
        //     }
        // }

        internal readonly PAData _index;

        internal readonly PAStatus _status;

        // internal readonly PAElement _next;


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