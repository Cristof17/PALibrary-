//public class PAPereche
//struct PAPereche
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    struct PAPair
    {
        [DllImport("palibrary")]
        public static extern  PAElement PAPairInit(PAElement e);
        [DllImport("palibrary")]
        public static extern int PAPairRuin(PAData Data, PAElement Next, PAStatus status);
        [DllImport("palibrary")]
        public static extern  PAPair PAPairConstruct(PAElement Node, PAElement Neigh);
        [DllImport("palibrary")]
        public static extern int PAPairDelete(PAElement PA);

        // [StructLayout(LayoutKind.Sequential)]
        // private struct PAPair Pair;

        public PAPair(Element Node, Element Neigh)
        {
            
        }
        // PANod node;
        // PANod neigh;
    }
}