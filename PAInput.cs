using System.Runtime.InteropServices;
using System;
using PA;
using AL;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAInput
    {
        // internal PAInput(PACount N, PACount M, PAList Adj, PAElement Sursa) : this()
        // {
        //     PAInput input = PAInputPerformConstruct();
        //     input = PAInputPerformInit(input, N, Sursa);
        //     // n = 
        //     // n = PACount.PACountPerformConstruct();
        //     n = PACount.PACountPerformCopy(input.n, n);
        //     // m = PACount.PACountPerformConstruct();
        //     m = PACount.PACountPerformCopy(input.m, m);
        //     input.adj = PAList.PAListPerformCopy(Adj, input.adj);
        //     // adj = PAList.PAListPerformConstruct();
        //     adj = PAList.PAListPerformCopy(input.adj, adj);
        //     // sursa = PAElement.PAElementPerformConstruct();
        //     sursa = PAElement.PAElementPerformCopy(input.sursa, sursa);
        // }

        internal required PACount _n;

        internal required PACount _m;

        internal required PAList _adj;

        internal required PAElement _sursa;

        public readonly PACount n { get; }

        public readonly PACount m { get; }

        public readonly PAList adj { get; }

        public readonly PAElement sursa { get; }

        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformConstruct();
        [LibraryImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        internal static partial PAInput PAInputPerformInit(PAInput input, PACount count, PAElement element);
        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformCopy(PAInput from, PAInput to);
        [LibraryImport("pa")]
        internal static partial void PAInputRuin(PAInput pa);
        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformDelete(PAInput pa);

    }
}
