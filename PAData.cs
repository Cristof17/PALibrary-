using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAData
    {
        readonly PAResource Resource;

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
        public static partial int PADataOperatorEqual(PAData one, PAData other);
        [LibraryImport("pa")]
        public static partial int PADataOperatorNotEqual(PAData one, PAData other);

        public static bool operator ==(PAData one, PAData other) => (PADataOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator != (PAData one, PAData other) => (PADataOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;

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