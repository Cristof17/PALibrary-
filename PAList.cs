using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
    public readonly partial struct PAList
    {
        readonly PACount N;

        readonly PASeries Adj;

        [LibraryImport("pa")]
        public static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAList PAListPerformInit(PAList list, PACount n, in PASeries adj);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformCopy(PAList from, PAList to);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformDelete(PAList PA);

        [LibraryImport("pa")]
        public static partial int PAListOperatorEqual(PAList one, PAList other);

        [LibraryImport("pa")]
        public static partial int PAListOperatorNotEqual(PAList one, PAList other);

        public PAElement this[PAElement element]
        {
            get
            {
                return Adj[element];
            }
        }
        [LibraryImport("pa")]
        public static partial void PAListPerformPrint(PAList List);

        public static bool operator==(PAList one, PAList other) => (PAListOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator!=(PAList one, PAList other) => (PAListOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;

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
