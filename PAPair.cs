using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAPair : StateMachine
    {
        public PAPair(PAElement Node, PAElement Neigh) : this()
        {
            node = PAElement.PAElementPerformConstruct();
            node = PAElement.PAElementPerformCopy(Node, node);
            neigh = PAElement.PAElementPerformConstruct();
            neigh = PAElement.PAElementPerformCopy(Neigh, neigh);
        }
        private PAElement node;

        private PAElement neigh;

        [DllImport("pa")]
        internal static extern PAPair PAPairConstruct();
        [DllImport("pa")]
        internal static extern PAPair PAPairInit([MarshalAs(UnmanagedType.IUnknown)] PAPair p, [MarshalAs(UnmanagedType.IUnknown)] PAElement Node, [MarshalAs(UnmanagedType.IUnknown)] PAElement Neigh);
        [DllImport("pa")]
        internal static extern int PAPairDelete([MarshalAs(UnmanagedType.IUnknown)] PAElement PA);
        [DllImport("pa")]
        internal static extern int PAPairRuin([MarshalAs(UnmanagedType.IUnknown)] PAPair PA);

        public void Construct()
        {
            Initialise();
            // throw new System.NotImplementedException();
        }

        public void Initialise()
        {
            Delete();
            // throw new System.NotImplementedException();
        }

        public void Delete()
        {
            Finish();
            // throw new System.NotImplementedException();
        }

        public void Finish()
        {
            // throw new System.NotImplementedException();
        }
    }
}