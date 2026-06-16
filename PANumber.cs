using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PANumber
    {
        public PANumber(int Value) : this()
        {
            value = Value;
        }
        private int value;

        [DllImport("pa")]
        internal static extern PANumber PANumberPerformConstruct();
        [DllImport("pa")]
        internal static extern PANumber PANumberPerformInit([MarshalAs(UnmanagedType.IUnknown)] PANumber Number, int Value);
        [DllImport("pa")]
        internal static extern PANumber PANumberPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PANumber from, [MarshalAs(UnmanagedType.IUnknown)] PANumber to);
        [DllImport("pa")]
        internal static extern PANumber PANumberPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PANumber PA);
        [DllImport("pa")]
        internal static extern PANumber PANumberPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PANumber PA);

        public static PANumber operator++(PANumber Number) => PANumber.PANumberPerformInit(Number,Number.value++);
    }
}