using System.Runtime.InteropServices;
// using System.Xml.Serialization;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PANumber
    {
        // public PANumber(int Value) : this()
        // {
        //     value = Value;
        //     PANumber number;
        //     number = PANumberPerformConstruct();
        //     number = PANumberPerformInit(number, Value);
        //     value = number.value;
        //     // number.value,value);
        // }
        public readonly int value => _value;
        // { 
        //     get
        //     {
        //         return _value;        
        //     } 
        // }

        internal int _value;

        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformInit(PANumber number, int value);
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformCopy(PANumber from, PANumber to);
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformRuin(PANumber pa);
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformDelete(PANumber pa);

        public static PANumber operator ++(PANumber number) => PANumber.PANumberPerformInit(number, number._value++);
        public static bool operator <(PANumber a, PANumber b) => a._value < b._value;
        public static bool operator >(PANumber a, PANumber b) => a._value > b._value;
        // public static bool operator ==(PANumber a, PANumber b) => a.value == b.value;
        // public static bool operator !=(PANumber a, PANumber b) => a.value != b.value;
        // public static bool operator int(PANumber a) => (int) a.value;
        public static implicit operator int(PANumber a) => (int)a._value;
        // public static explicit operator PANod
        // public static explicit operator PANumber(int value) => PANumberPerformInit();

        // public override bool Equals(object obj)
        // {
        //     PANumber other = (PANumber)obj;

        //     return other == value;
        // }

        // public override int GetHashCode()
        // {
        //     return base.GetHashCode();
        // }
    }
}