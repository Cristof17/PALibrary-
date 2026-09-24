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
        PACount PACountPerformDelete(PACount PA);
        [LibraryImport("pa")]
        PAResult PACountOperatorLess(PACount one,PACount other);
        [LibraryImport("pa")]
        PAResult PACountOperatorEqual(PACount one,PACount other);
        [LibraryImport("pa")]
        PAResult PACountOperatorGreater(PACount one,PACount other);
        [LibraryImport("pa")]
        PAResult PACountOperatorNotEqual(PACount one, PACount other);

    }
}
