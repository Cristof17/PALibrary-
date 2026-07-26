using System.Runtime.InteropServices;
using System;
using PA;
using AL;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAInput
    {
        internal PAInput(PACount N, PACount M, PAList Adj, PAElement Sursa) : this()
        {
            PAInput input = PAInputPerformConstruct();
            input = PAInputPerformInit(input, N, Sursa);
            // n = 
            // n = PACount.PACountPerformConstruct();
            n = PACount.PACountPerformCopy(input.n, n);
            // m = PACount.PACountPerformConstruct();
            m = PACount.PACountPerformCopy(input.m, m);
            input.adj = PAList.PAListPerformCopy(Adj, input.adj);
            // adj = PAList.PAListPerformConstruct();
            adj = PAList.PAListPerformCopy(input.adj, adj);
            // sursa = PAElement.PAElementPerformConstruct();
            sursa = PAElement.PAElementPerformCopy(input.sursa, sursa);
        }

        private PACount n;

        private PACount m;

        private PAList adj;

        private PAElement sursa;

        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformConstruct();
        [LibraryImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        internal static partial PAInput PAInputPerformInit(PAInput Input, PACount Count, PAElement Element);
        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformCopy(Input From, Input To);
        [LibraryImport("pa")]
        internal static partial void PAInputDispose();
        [LibraryImport("pa")]
        internal static partial void PAInputRuin(PAInput PA);
        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformDelete(PAInput PA);
    }
}
