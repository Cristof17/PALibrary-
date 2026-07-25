using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAPair
    {
        public PAPair(PAElement Node, PAElement Neigh) : this()
        {
            PAPair pair;
            // object 
            pair = PAPairConstruct();
            pair = PAPairInit(pair,Node,Neigh);
            // node =
            // node = PAElement.PAElementPerformConstruct();
            pair.node = PAElement.PAElementPerformCopy(Node, node);
            node = PAElement.PAElementPerformCopy(pair.node,node);
            // neigh = PAElement.PAElementPerformConstruct();
            pair.neigh = PAElement.PAElementPerformCopy(Neigh, neigh);
            neigh = PAElement.PAElementPerformCopy(pair.neigh,neigh);
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