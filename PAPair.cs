using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using PA;

namespace PA
{
    public readonly partial struct PAPair
    {

        readonly PAElement Node;

        readonly PAElement Neigh;

        [LibraryImport("pa")]
        public static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        public static partial PAPair PAPairInit(PAPair pair, PAElement node, PAElement neigh);
        [LibraryImport("pa")]
        public static partial int PAPairRuin(PAPair pa);
        [LibraryImport("pa")]
        public static partial int PAPairDelete(PAElement pa);

        [LibraryImport("pa")]
        public static partial int PAPairOperatorEqual(PAPair one, PAPair other);
        [LibraryImport("pa")]
        public static partial int PAPairOperatorNotEqual(PAPair one, PAPair other);

        public static bool operator ==(PAPair one, PAPair other) => (PAPairOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PAPair one, PAPair other) => (PAPairOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;

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