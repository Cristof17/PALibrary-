using System.Runtime.InteropServices;
// using System.Xml.Serialization;
using PA;

namespace PA
{
    public readonly partial struct PANumber
    {
        int Value;

        // internal readonly int _value;

        [LibraryImport("pa")]
        public static partial PANumber PANumberPerformConstruct();
        [LibraryImport("pa")]
        public static partial PANumber PANumberPerformInit(PANumber number, int value);
        [LibraryImport("pa")]
        public static partial PANumber PANumberPerformCopy(PANumber from, PANumber to);
        [LibraryImport("pa")]
        public static partial PANumber PANumberPerformRuin(PANumber pa);
        [LibraryImport("pa")]
        public static partial PANumber PANumberPerformDelete(PANumber pa);
    }
}