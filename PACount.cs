using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PACount
    {
        PANumber value;

        [DllImport("pa")]
        static extern PACount PACountPerformConstruct();
        [DllImport("pa")]
        static extern PACount PACountPerformInit([MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PANumber Number);
        [DllImport("pa")]
        static extern PACount PACountPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PACount from, [MarshalAs(UnmanagedType.IUnknown)] PACount to);
        [DllImport("pa")]
        static extern PACount PACountPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PACount PA);
        [DllImport("pa")]
        static extern PACount PACountPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PACount PA);
    }
}
