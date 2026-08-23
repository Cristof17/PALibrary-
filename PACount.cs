using System;
using System.Net;

// using System.Data.Common;
using System.Runtime.InteropServices;
using SM;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PACount
    {
        PANumber Value;

        [LibraryImport("pa")]
        internal static partial PACount PACountPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformInit(PACount count, PANumber number);
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformCopy(PACount from, PACount to);
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformRuin(PACount pa);
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformDelete(PACount pa);

        // private static bool operator <(PACount a, PACount b) => a._value < b._value;
        // private static bool operator >(PACount a, PACount b) => a._value > b._value;
        // private static implicit operator int(PACount count) => (int)count._value;

    }
}
