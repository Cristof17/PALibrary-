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
        static partial PAPair PAPairPerformCopy(PAPair from, PAPair to);
        [LibraryImport("pa")]
        static partial PAPair PAPairConstruct();
        [LibraryImport("pa")]
        static partial PAPair PAPairInit(PAPair pair, PAElement node, PAElement neigh);
        [LibraryImport("pa")]
        static partial int PAPairRuin(PAPair pa);
        [LibraryImport("pa")]
        static partial int PAPairDelete(PAElement pa);

    }
}