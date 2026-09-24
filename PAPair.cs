using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAPair
    {

        PAElement Node;

        PAElement Neigh;

        [LibraryImport("pa")]
        public static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        public static partial PAPair PAPairInit(PAPair pair, PAElement node, PAElement neigh);
        [LibraryImport("pa")]
        public static partial int PAPairRuin(PAPair pa);
        [LibraryImport("pa")]
        public static partial int PAPairDelete(PAElement pa);
        [LibraryImport("pa")]
        PAResult PAPairOperatorEqual(PAPair other,PAPair one);
        [LibraryImport("pa")]
        PAResult PAPairOperatorNotEqual(PAPair one,PAPair other);
        [LibraryImport("pa")]
        PAResult PAResourceOperatorLess(PAResource one,PAResource other);
        [LibraryImport("pa")]
        PAResult PAResourceOperatorGreater(PAResource one,PAResource other);
        [LibraryImport("pa")]
        PAResult PAResourceOperatorEqual(PAResource one,PAResource other);
        [LibraryImport("pa")]
        PAResult PAResourceOperatorNotEqual(PAResource one,PAResource other);
    } 
}