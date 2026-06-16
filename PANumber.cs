using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PANumber
    {
        public int value;

        [DllImport("pa")]
        static extern PANumber PANumberPerformConstruct();
        [DllImport("pa")]
        static extern PANumber PANumberPerformInit([MarshalAs(UnmanagedType.IUnknown)] PANumber Number, int Value);
        [DllImport("pa")]
        static extern PANumber PANumberPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PANumber from, [MarshalAs(UnmanagedType.IUnknown)] PANumber to);
        [DllImport("pa")]
        static extern PANumber PANumberPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PANumber PA);
        [DllImport("pa")]
        static extern PANumber PANumberPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PANumber PA);
    }
}