using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAPair
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
        private required PAElement node { get; set; }

        private PAElement neigh { get; set; }

        [LibraryImport("pa")]
        internal static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        internal static partial PAPair PAPairInit(PAPair Pair, PAElement Node, PAElement Neigh);
        [LibraryImport("pa")]
        internal static partial int PAPairRuin(PAPair PA);
        [LibraryImport("pa")]
        internal static partial int PAPairDelete(PAElement PA);

    }
}