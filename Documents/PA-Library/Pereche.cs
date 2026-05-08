//public class PAPereche
//struct PAPereche
namespace PA_Library
{
    struct Pereche
    {
        [DllImport("pa-library")]
        public static extern PAPAirInit();
        [DllImport("pa-library")]
        public static extern PAPairRuin();
        [DllImport("pa-library")]
        public static extern PAPairConstruct();
        [DllImport("pa-library")]
        public static extern PAPairDelete();

        [StructLayout(LayoutKind.Sequential)]
        private struct PAPair Pair;

        public Pereche(Element Node, Element Neigh)
        {
            
        }
        // PANod node;
        // PANod neigh;
    }
}