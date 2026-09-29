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
        public static bool operator <(PACount a, PACount b) => a._value < b._value;
        public static bool operator >(PACount a, PACount b) => a._value > b._value;
        public static implicit operator int(PACount count) => (int)count._value;
        public static bool operator ==(PACount from, PACount to) => from._value == to._value;
        public static bool operator !=(PACount from, PACount to) => from._value != to._value;


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
