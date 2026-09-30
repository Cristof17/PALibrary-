using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAResource
    {

        PANumber Value;

        [LibraryImport("pa")]
        public static partial PAResource PAResourcePerformConstruct();
        [LibraryImport("pa")]
        public static partial PAResource PAResourcePerformInit(PAResource resource, PANumber number);
        [LibraryImport("pa")]
        public static partial PAResource PAResourcePerformCopy(PAResource from, PAResource to);
        [LibraryImport("pa")]
        public static partial int PAResourcePerformRuin(PAResource pa);
        [LibraryImport("pa")]
        internal static partial int PAResourcePerformDelete(PAResource pa);

        [LibraryImport("pa")]
        internal static partial int PAResourceOperatorEqual(PAResource one, PAResource other);

        [LibraryImport("pa")]
        internal static partial int PAResourceOperatorNotEqual(PAResource one, PAResource other);

        public static bool operator ==(PAResource one, PAResource other) => (PAResourceOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PAResource one, PAResource other) => (PAResourceOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;

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