using System.Runtime.InteropServices;
using System;
using PA;
using AL;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;

namespace PA
{
    public readonly partial struct PAInput
    {

        PACount N;

        PACount M;

        PAList Adj;

        PAElement Sursa;
        
        [LibraryImport("pa")]
        public static partial PAInput PAInputPerformConstruct();
        [LibraryImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        public static partial PAInput PAInputPerformInit(PAInput input, PACount count, PAElement element);
        [LibraryImport("pa")]
        public static partial PAInput PAInputPerformCopy(PAInput from, PAInput to);
        [LibraryImport("pa")]
        public static partial void PAInputRuin(PAInput pa);
        [LibraryImport("pa")]
        public static partial PAInput PAInputPerformDelete(PAInput pa);

        public static bool operator ==(PAInput from, PAInput to) => (from._n == to._n) && (from._m == to._m) && (from._adj == to._adj) && (from._sursa == to._sursa);
        public static bool operator !=(PAInput from, PAInput to) => (from._n != to._n) || (from._m != to._m) || (from._adj != to._adj) || (from._sursa != to._sursa);

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
