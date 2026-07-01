using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAPair
    {
        public PAPair(PAElement Node, PAElement Neigh) : this()
        {
            PAPair p;
            // object 
            p = PAPairConstruct();
            p = PAPairInit(p,Node,Neigh);
            // node =
            // node = PAElement.PAElementPerformConstruct();
            node = PAElement.PAElementPerformCopy(Node, node);
            // neigh = PAElement.PAElementPerformConstruct();
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

    }
}