using System;
using System.Diagnostics.CodeAnalysis;

// using System.Data.Common;
using System.Runtime.InteropServices;
using PA;
using SM;

namespace PA
{
    public readonly partial struct PACount
    {

        readonly PANumber Value;

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
        public static partial int PACountOperatorLess(PACount one, PACount other);
        [LibraryImport("pa")]
        public static partial int PACountOperatorMore(PACount one, PACount other);
        
        [LibraryImport("pa")]
        public static partial int PACountOperatorEqual(PACount one, PACount other);

        [LibraryImport("pa")]
        public static partial int PACountOperatorNotEqual(PACount one, PACount other);

        public static bool operator ==(PACount one, PACount other) => (PACountOperatorEqual(one, other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PACount one, PACount other) => (PACountOperatorNotEqual(one, other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator <(PACount a, PACount b) => (PACountOperatorLess(a, b) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator >(PACount a, PACount b) => (PACountOperatorMore(a, b) == PA.PARESULT_SUCCESS) ? true : false;
        public static implicit operator int(PACount count) => (int) count.Value.Value;

        public override bool Equals([NotNullWhen(true)] object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
