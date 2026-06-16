using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    protected struct PAList
    {
        ArrayList edges;

        [DllImport("pa")]
        static extern PAList PAListPerformConstruct();
        [DllImport("pa")]
        static extern PAList PAListPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PACount N, [MarshalAs(UnmanagedType.IUnknown)] in PASeries[] adj);
        [DllImport("pa")]
        static extern PAList PAListPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAList from, [MarshalAs(UnmanagedType.IUnknown)] PAList to);
        [DllImport("pa")]
        static extern void PAListPerformPrint([MarshalAs(UnmanagedType.IUnknown)] PAList List);
        [DllImport("pa")]
        static extern PAList PAListPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAList PA);
        [DllImport("pa")]
        static extern PAList PAListPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAList PA);
    }
}
