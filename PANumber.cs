using System.Runtime.InteropServices;
// using System.Xml.Serialization;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PANumber
    {
        public PANumber(int Value) : this()
        {
            value = Value;
            PANumber number;
            number = PANumberPerformConstruct();
            number = PANumberPerformInit(number,Value);
            value = number.value ;
            // number.value,value);
        }
        public int value;

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

        public static PANumber operator ++(PANumber Number) => PANumber.PANumberPerformInit(Number, Number.value++);
        public static bool operator <(PANumber a, PANumber b) => a.value < b.value;
        public static bool operator >(PANumber a, PANumber b) => a.value > b.value;
        // public static bool operator ==(PANumber a, PANumber b) => a.value == b.value;
        // public static bool operator !=(PANumber a, PANumber b) => a.value != b.value;
        // public static bool operator int(PANumber a) => (int) a.value;
        public static implicit operator int(PANumber a) => (int)a.value;
        // public static explicit operator PANod
        public static explicit operator PANumber(int value) => new PANumber(value);

        // public override bool Equals(object obj)
        // {
        //     PANumber other = (PANumber)obj;

        //     return other == value;
        // }

        // public override int GetHashCode()
        // {
        //     return base.GetHashCode();
        // }
    }
}