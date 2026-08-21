using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using PA;

namespace PA
{
    public readonly partial struct PAPair
    {

        public readonly PAElement Node
        {
            get
            {
                return _node; 
            }
        } 

        public readonly PAElement Neigh
        {
            get
            {
                return  _neigh;;  
            }
        } 

        internal readonly PAElement _node;

        internal readonly PAElement _neigh;

        [LibraryImport("pa")]
        public static partial PAPair PAPairPerformCopy(PAPair from, PAPair to);
        [LibraryImport("pa")]
        public static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        public static partial PAPair PAPairInit(PAPair pair, PAElement node, PAElement neigh);
        [LibraryImport("pa")]
        public static partial int PAPairRuin(PAPair pa);
        [LibraryImport("pa")]
        public static partial int PAPairDelete(PAElement pa);

        public static bool operator ==(PAPair one, PAPair other) => (one._node == other._node) && (one._neigh == other._neigh);
        public static bool operator !=(PAPair one, PAPair other) => (one._node != other._node) || (one._neigh != other._neigh);

    }
}