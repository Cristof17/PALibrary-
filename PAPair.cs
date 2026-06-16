using System.Runtime.InteropServices;
using PA_Library;

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

        PAPair(PAElement Node, PAElement Neigh) : this()
        {

        }
    }
}