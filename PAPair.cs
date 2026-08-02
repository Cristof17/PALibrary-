using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAPair
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

        public readonly PAElement node => _node;
        // {   
        //     get
        //     {
        //         return _node;
        //     } 
        // }

        public readonly PAElement neigh => _neigh;
        // { get; }

        internal readonly PAElement _node;

        internal readonly PAElement _neigh;

        [LibraryImport("pa")]
        public static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        public static partial PAPair PAPairInit(PAPair pair, PAElement node, PAElement neigh);
        [LibraryImport("pa")]
        public static partial int PAPairRuin(PAPair pa);
        [LibraryImport("pa")]
        public static partial int PAPairDelete(PAElement pa);

    }
}