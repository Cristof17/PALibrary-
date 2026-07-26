using System.Runtime.InteropServices;
// using System.Xml.Serialization;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PANumber
    {
        public PANumber(int Value) : this()
        {
            value = Value;
            PANumber number;
            number = PANumberPerformConstruct();
            number = PANumberPerformInit(number, Value);
            value = number.value;
            // number.value,value);
        }
        public int value {get; set; }

        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformInit(PANumber Number, int Value);
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformCopy(PANumber From, PANumber To);
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformRuin(PANumber PA);
        [LibraryImport("pa")]
        internal static partial PANumber PANumberPerformDelete(PANumber PA);

        public static PANumber operator ++(PANumber Number) => PANumber.PANumberPerformInit(Number, Number.value++);
        public static bool operator <(PANumber a, PANumber b) => a.value < b.value;
        public static bool operator >(PANumber a, PANumber b) => a.value > b.value;
        // public static bool operator ==(PANumber a, PANumber b) => a.value == b.value;
        // public static bool operator !=(PANumber a, PANumber b) => a.value != b.value;
        // public static bool operator int(PANumber a) => (int) a.value;
        public static implicit operator int(PANumber a) => (int)a.value;
        // public static explicit operator PANod
        public static explicit operator PANumber(int value) => new PANumber(value);

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