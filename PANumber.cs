using System.Runtime.InteropServices;
// using System.Xml.Serialization;
// using PA;

namespace PA
{
        [StructLayout(LayoutKind.Sequential)]
    public partial struct PANumber
    {
        int Value;

        [LibraryImport("pa")]
        static partial PANumber PANumberPerformConstruct();
        [LibraryImport("pa")]
        static partial PANumber PANumberPerformInit(PANumber Number, int Value);
        [LibraryImport("pa")]
        static partial PANumber PANumberPerformCopy(PANumber from, PANumber to);
        [LibraryImport("pa")]
        static partial PANumber PANumberPerformRuin(PANumber pa);
        [LibraryImport("pa")]
        static partial PANumber PANumberPerformDelete(PANumber pa);

        // public static bool operator <(PANumber a, PANumber b) => a._value < b._value;
        // public static bool operator >(PANumber a, PANumber b) => a._value > b._value;
        // public static implicit operator int(PANumber a) => (int)a._value;
    }
}