using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAPair
    {

        PAElement Node;

        PAElement Neigh;

        [LibraryImport("pa")]
        internal static partial PAPair PAPairPerformCopy(PAPair from, PAPair to);
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