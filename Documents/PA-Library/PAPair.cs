//public class PAPereche
//struct PAPereche

using PA_Library;
// using System;
using System.Runtime.InteropServices;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    protected struct PAPair
    {
        PAElement Node;

        PAElement Neigh;

        [DllImport("pa")]
        static extern PAPair PAPairConstruct();
        [DllImport("pa")]
        static extern PAPair PAPairInit([MarshalAs(UnmanagedType.IUnknown)] PAPair p, [MarshalAs(UnmanagedType.IUnknown)] PAElement Node, [MarshalAs(UnmanagedType.IUnknown)] PAElement Neigh);
        [DllImport("pa")]
        static extern int PAPairDelete([MarshalAs(UnmanagedType.IUnknown)] PAElement PA);
        [DllImport("pa")]
        static extern int PAPairRuin([MarshalAs(UnmanagedType.IUnknown)] PAPair PA);

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