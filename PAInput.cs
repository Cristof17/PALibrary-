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

        readonly PACount N;

        readonly PACount M;

        readonly PAList Adj;

        readonly PAElement Sursa;
        
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

        [LibraryImport("pa")]
        public static partial int PAInputOperatorEqual(PAInput one, PAInput other);

        [LibraryImport("pa")]
        public static partial int PAInputOperatorNotEqual(PAInput one, PAInput other);

        public static bool operator ==(PAInput from, PAInput to) => (PAInputOperatorEqual(from,to) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PAInput from, PAInput to) => (PAInputOperatorNotEqual(from,to) == PA.PARESULT_SUCCESS) ? true : false;

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
