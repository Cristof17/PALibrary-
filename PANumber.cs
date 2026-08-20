using System.Runtime.InteropServices;
// using System.Xml.Serialization;
using PA;

namespace PA
{
    public readonly partial struct PANumber
    {
        public readonly int Value
        {
            get
            {
                return _value; 
            }
            // => 
            
        } 

        internal readonly int _value;

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

        public static bool operator <(PANumber a, PANumber b) => a._value < b._value;
        public static bool operator >(PANumber a, PANumber b) => a._value > b._value;
        public static implicit operator int(PANumber a) => (int)a._value;
    }
}