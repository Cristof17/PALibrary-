using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAInput : StateMachine
    {
        public PAInput(PACount N, PACount M, PAList ADJ, PAElement Sursa) : this()
        {
            n = PACount.PACountPerformConstruct();
            n = PACount.PACountPerformCopy(N,n);
            m = PACount.PACountPerformConstruct();
            m = PACount.PACountPerformCopy(M,m);
            adj = PAList.PAListPerformConstruct();
            adj = PAList.PAListPerformCopy(ADJ,adj);
            sursa = PAElement.PAElementPerformConstruct();
            sursa = PAElement.PAElementPerformCopy(Sursa,sursa);
        }

        private PACount n;

        private PACount m;

        private PAList adj;

        private PAElement sursa;

        [DllImport("pa")]
        internal static extern Input InputPerformConstruct();
        [DllImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        internal static extern Input InputPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAInput input, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
        [DllImport("pa")]
        internal static extern Input InputPerformCopy([MarshalAs(UnmanagedType.IUnknown)] Input from, [MarshalAs(UnmanagedType.IUnknown)] Input to);
        [DllImport("pa")]
        internal static extern void InputDispose();
        [DllImport("pa")]
        internal static extern PAInput InputPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAInput PA);
        [DllImport("pa")]
        internal static extern void InputRuin([MarshalAs(UnmanagedType.IUnknown)] PAInput PA);

        public void Construct()
        {
            throw new System.NotImplementedException();
        }

        public void Initialise()
        {
            throw new System.NotImplementedException();
        }

        public void Delete()
        {
            throw new System.NotImplementedException();
        }

        public void Finish()
        {
            throw new System.NotImplementedException();
        }
    }
}
