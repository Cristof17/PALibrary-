using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
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

        public static bool operator ==(PAPair one, PAPair other) => (one._node == other._node) && (one._neigh == other._neigh);
        public static bool operator !=(PAPair one, PAPair other) => (one._node != other._node) || (one._neigh != other._neigh);

        public override bool Equals([NotNullWhen(true)] object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}