using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
    public readonly partial struct PAList
    {
        PACount N;

        PASeries Adj;

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
        public static partial void PAListPerformPrint(PAList List);

        public static bool operator==(PAList one, PAList other) => (one._n == other._n) && (one._adj == other._adj);
        public static bool operator!=(PAList one, PAList other) => (one._n != other._n) || (one._adj != other._adj);

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
