// using System.Linq.Expressions;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
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

        public readonly unsafe PAElement Next
        {    
            get
            {
                return *_next; 
            }
        }

        // public unsafe PAElement this[PAElement node]
        // {
        //     get
        //     {
        //         //do logic for iteration and comparison
        //         return *_next;
        //     }
        // }

        internal readonly PAData _index;

        internal readonly PAStatus _status;

        internal readonly unsafe PAElement* _next;


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

        public static unsafe bool operator==(PAElement one, PAElement other) => (one._index == other._index) && ((*one._next) == (*other._next)) && (one._status == other._status);
        public static unsafe bool operator !=(PAElement one, PAElement other) => (one._index != other._index) || ((*one._next) != (*other._next)) || (one._status != other._status);
    }
}