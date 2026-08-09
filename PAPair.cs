using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAPair
    {

        public readonly PAElement Node
        {
            get => _node;
            
        } 

        public readonly PAElement Neigh
        {
            get => _neigh;
            
        } 

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