using System.Runtime.InteropServices;
using System;
using PA;
using AL;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAInput
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


        public readonly PACount n => _n;
        // { 
        //     get
        //     {
        //         return _n;   
        //     } 
        // }

        public readonly PACount m => _m;
        // { 
        //     get
        //     {
        //         return _m;
        //     }
        // }

        public readonly PAList adj => _adj;
        // {
        //      get
        //     {
        //         return _adj;   
        //     } 
        // }

        public readonly PAElement sursa => _sursa;
        // { 
        //     get
        //     {
        //         return _sursa;
        //     } 
        // }
        
        internal PACount _n;

        internal PACount _m;

        internal PAList _adj;

        internal PAElement _sursa;

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
