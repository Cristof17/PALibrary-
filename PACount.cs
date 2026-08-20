using System;
// using System.Data.Common;
using System.Runtime.InteropServices;
using PA;
using SM;

namespace PA
{
    public readonly partial struct PACount
    {

        public readonly PANumber Value
        {
            get
            {
                return _value; 
            }
        } 

        internal readonly PANumber _value;

        [LibraryImport("pa")]
        public static partial PACount PACountPerformConstruct();
        [LibraryImport("pa")]
        public static partial PACount PACountPerformInit(PACount count, PANumber number);
        [LibraryImport("pa")]
        public static partial PACount PACountPerformCopy(PACount from, PACount to);
        [LibraryImport("pa")]
        public static partial PACount PACountPerformRuin(PACount pa);
        [LibraryImport("pa")]
        public static partial PACount PACountPerformDelete(PACount pa);

        public static bool operator <(PACount a, PACount b) => a._value < b._value;
        public static bool operator >(PACount a, PACount b) => a._value > b._value;
        public static implicit operator int(PACount count) => (int)count._value;

    }
}
