using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAData
    {
        PAResource Resource;

        [LibraryImport("pa")]
        public static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAData PADataPerformInit(PAData data, PAResource resource);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformCopy(PAData from, PAData to);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformRuin(PAData pa);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformDelete(PAData pa);
        [LibraryImport("pa")]
        public static partial PAResult PADataOperatorLess(PAData one, PAData other);
        [LibraryImport("pa")]
        public static partial PAResult PADataOperatorEqual(PAData one,PAData other);
        [LibraryImport("pa")]
        public static partial PAResult PADataOperatorGreater(PAData one,PAData other);
        [LibraryImport("pa")]
        public static partial PAResult PADataOperatorNotEqual(PAData,PAData);
    }
}