using System;
using System.Net;

// using System.Data.Common;
using System.Runtime.InteropServices;
using PA;
using SM;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PACount
    {
        internal PANumber Value;

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

        // private static bool operator <(PACount a, PACount b) => a._value < b._value;
        // private static bool operator >(PACount a, PACount b) => a._value > b._value;
        // private static implicit operator int(PACount count) => (int)count._value;

    }
}
