using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAPair
    {
        // public PAPair(PAElement Node, PAElement Neigh) : this()
        // {
        //     PAPair pair;
        //     // object 
        //     pair = PAPairConstruct();
        //     pair = PAPairInit(pair, Node, Neigh);
        //     // node =
        //     // node = PAElement.PAElementPerformConstruct();
        //     pair.node = PAElement.PAElementPerformCopy(Node, node);
        //     node = PAElement.PAElementPerformCopy(pair.node, node);
        //     // neigh = PAElement.PAElementPerformConstruct();
        //     pair.neigh = PAElement.PAElementPerformCopy(Neigh, neigh);
        //     neigh = PAElement.PAElementPerformCopy(pair.neigh, neigh);
        // }

        public readonly PAElement node 
        {   
            get
            {
                return _node;
            } 
        }

        public readonly PAElement neigh { get; }

        internal PAElement _node;

        internal PAElement _neigh;

        [LibraryImport("pa")]
        internal static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        internal static partial PAPair PAPairInit(PAPair pair, PAElement node, PAElement neigh);
        [LibraryImport("pa")]
        internal static partial int PAPairRuin(PAPair pa);
        [LibraryImport("pa")]
        internal static partial int PAPairDelete(PAElement pa);

    }
}