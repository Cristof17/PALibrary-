using System;
// using System.Data.Common;
using System.Runtime.InteropServices;
using PA;
using SM;

namespace PA
{
    public readonly partial struct PACount
    {

        PANumber Value;

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
        [LibraryImport("pa")]
        public static partial PACount PACountPerformDelete(PACount PA);
        [LibraryImport("pa")]
        public static partial PAResult PACountOperatorLess(PACount one,PACount other);
        [LibraryImport("pa")]
        public static partial PAResult PACountOperatorEqual(PACount one,PACount other);
        [LibraryImport("pa")]
        public static partial PAResult PACountOperatorGreater(PACount one,PACount other);
        [LibraryImport("pa")]
        public static partial PAResult PACountOperatorNotEqual(PACount one, PACount other);

    }
}
