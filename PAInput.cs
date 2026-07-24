using System.Runtime.InteropServices;
using System;
using PA;
using AL;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAInput
    {
        public PAInput(PACount N, PACount M, PAList Adj, PAElement Sursa) : this()
        {
            PAInput input = PAInputPerformConstruct();
            input = PAInputPerformInit(input,N,Sursa);
            // n = 
            // n = PACount.PACountPerformConstruct();
            n = PACount.PACountPerformCopy(input.n,n);
            // m = PACount.PACountPerformConstruct();
            m = PACount.PACountPerformCopy(input.m,m);
            input.adj = PAList.PAListPerformCopy(Adj,input.adj);
            // adj = PAList.PAListPerformConstruct();
            adj = PAList.PAListPerformCopy(input.adj,adj);
            // sursa = PAElement.PAElementPerformConstruct();
            sursa = PAElement.PAElementPerformCopy(input.sursa,sursa);
        }

        private PACount n;

        private PACount m;

        private PAList adj;

        private PAElement sursa;

        [DllImport("pa")]
        internal static extern PAInput PAInputPerformConstruct();
        [DllImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        internal static extern PAInput PAInputPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAInput input, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
        [DllImport("pa")]
        internal static extern PAInput PAInputPerformCopy([MarshalAs(UnmanagedType.IUnknown)] Input from, [MarshalAs(UnmanagedType.IUnknown)] Input to);
        [DllImport("pa")]
        internal static extern void PAInputDispose();
        [DllImport("pa")]
        internal static extern PAInput PAInputPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAInput PA);
        [DllImport("pa")]
        internal static extern void PAInputRuin([MarshalAs(UnmanagedType.IUnknown)] PAInput PA);
    }
}
