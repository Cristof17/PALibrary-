
using System.Runtime.InteropServices;
// using System.Xml.Serialization;
using PA;

namespace PA
{
    public readonly partial struct PANumber
    {
        public readonly int Value { get { return _Value; } }

        internal readonly int _Value;

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
        [LibraryImport("pa")]
        public static partial int PANumberOperatorEqual(PANumber one, PANumber other);
        [LibraryImport("pa")]
        public static partial int PANumberOperatorNotEqual(PANumber one, PANumber other);
        [LibraryImport("pa")]
        public static partial int PANumberOperatorLess(PANumber one, PANumber other);
        [LibraryImport("pa")]
        public static partial int PANumberOperatorGreater(PANumber one, PANumber other);

        public static bool operator ==(PANumber one, PANumber other) => (PANumberOperatorEqual(one, other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PANumber one, PANumber other) => (PANumberOperatorNotEqual(one, other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator <(PANumber one, PANumber other) => (PANumberOperatorLess(one, other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator >(PANumber one, PANumber other) => (PANumberOperatorGreater(one, other) == PA.PARESULT_SUCCESS) ? true : false;
        public static implicit operator int(PANumber number) => (int)number.Value;
        public static implicit operator uint(PANumber number) => (uint)number.Value;
    }
}