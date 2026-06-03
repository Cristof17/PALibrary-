//public class PAPereche
//struct PAPereche

using PA_Library;
using System;
using System.Runtime.InteropServices;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAPair
    {
        private PAElement Node;
        private PAElement Neigh; 

        [DllImport("pa")]
        public static extern  PAElement PAPairInit(PAElement e);
        [DllImport("pa")]
        public static extern int PAPairRuin(PAData Data, PAElement Next, PAStatus status);
        [DllImport("pa")]
        public static extern  PAPair PAPairConstruct(PAElement Node, PAElement Neigh);
        [DllImport("pa")]
        public static extern int PAPairDelete(PAElement PA);

        // [StructLayout(LayoutKind.Sequential)]
        // private struct PAPair Pair;

        // public PAPair(Element Node, Element Neigh)
        public PAPair(PAElement Node, PAElement Neigh) : this()
        {
            
        }
        // PANod node;
        // PANod neigh;
    }
}