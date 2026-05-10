//public class PAPereche
//struct PAPereche
namespace PA_Library
{
    struct Pereche
    {
        [DllImport("pa-library")]
        public static extern struct PAElement PAPairInit(struct PAElement e);
        [DllImport("pa-library")]
        public static extern int PAPairRuin(struct PAData Data, struct PAElement Next, struct PAStatus status);
        [DllImport("pa-library")]
        public static extern struct PAPair PAPairConstruct(struct PAElement Node, struct PAElement Neigh);
        [DllImport("pa-library")]
        public static extern int PAPairDelete(struct PAElement PA);

        [StructLayout(LayoutKind.Sequential)]
        private struct PAPair Pair;

        public Pereche(Element Node, Element Neigh)
        {
            
        }
        // PANod node;
        // PANod neigh;
    }
}