using System;
// using System.Data.Common;
using System.Runtime.InteropServices;
using PA_Library;
using SM;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PACount
    {
        public PACount(PANumber Number) : this()
        {
            // Construct(Number);
            PACount count;
            count = PACountPerformConstruct();
            count = PACountPerformInit(count,Number);
            value = PANumber.PANumberPerformCopy(count.value,value);
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

        public static PACount operator++(PACount count) => PACount.PACountPerformInit(count,count.value++);
        public static bool operator<(PACount a, PACount b) => a.value < b.value;
        public static bool operator>(PACount a, PACount b) => a.value > b.value;
        // public static bool operator==(PACount a, PACount b) => a.value == b.value;
        // public static bool operator!=(PACount a, PACount b) => a.value != b.value;
        public static implicit operator int(PACount count) => (int) count.value;
        public static explicit operator PACount(int value) => new PACount(new PANumber(value));

        // public override bool Equals(object obj)
        // {
        //     return base.Equals(obj);
        // }

        // public override int GetHashCode()
        // {
        //     return base.GetHashCode();
        // }
    }
}
