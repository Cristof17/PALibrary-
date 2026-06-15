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
        [MarshalAs(UnmanagedType.IUnknown)]
        PAElement Node;
        [MarshalAs(UnmanagedType.IUnknown)]
        PAElement Neigh;
        [DllImport("pa")]
        static extern PAPair PAPairConstruct();
        [DllImport("pa")]
        static extern PAPair PAPairInit(PAPair p, PAElement Node, PAElement Neigh);
        [DllImport("pa")]
        static extern int PAPairDelete(PAElement PA);
        [DllImport("pa")]
        static extern int PAPairRuin(PAPair PA);

        // [StructLayout(LayoutKind.Sequential)]
        // private struct PAPair Pair;

        // public PAPair(Element Node, Element Neigh)
        PAPair(PAElement Node, PAElement Neigh) : this()
        {

        }
        // PANod node;
        // PANod neigh;
    }
}