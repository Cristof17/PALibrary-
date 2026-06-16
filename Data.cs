using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAData
    {
        [DllImport("pa")]
        static extern PAData PADataPerformConstruct();
        [DllImport("pa")]
        static extern PAData PADataPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAData Data, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
        [DllImport("pa")]
        static extern PAData PADataPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAData PA);
        [DllImport("pa")]
        static extern PAData PADataPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAData PA);
        [DllImport("pa")]
        static extern PAData PADataPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAData from, [MarshalAs(UnmanagedType.IUnknown)] PAData to);
    }
}