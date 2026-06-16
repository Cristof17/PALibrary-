using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PACount
    {
        PACount(PANumber Number) : this()
        {
            value = PANumber.PANumberPerformConstruct();
            value = PANumber.PANumberPerformCopy(Number,value);
        }
        private PANumber value;

        [DllImport("pa")]
        internal static extern PACount PACountPerformConstruct();
        [DllImport("pa")]
        internal static extern PACount PACountPerformInit([MarshalAs(UnmanagedType.IUnknown)] PACount Count, [MarshalAs(UnmanagedType.IUnknown)] PANumber Number);
        [DllImport("pa")]
        internal static extern PACount PACountPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PACount from, [MarshalAs(UnmanagedType.IUnknown)] PACount to);
        [DllImport("pa")]
        internal static extern PACount PACountPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PACount PA);
        [DllImport("pa")]
        internal static extern PACount PACountPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PACount PA);
    }
}
