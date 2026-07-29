using System;
// using System.Data.Common;
using System.Runtime.InteropServices;
using PA;
using SM;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PACount
    {
        // public PACount(PANumber Number) : this()
        // {
        //     // Construct(Number);
        //     PACount count;
        //     count = PACountPerformConstruct();
        //     count = PACountPerformInit(count, Number);
        //     count.value = PANumber.PANumberPerformCopy(Number, count.value);
        //     value = PANumber.PANumberPerformCopy(count.value, value);
        // }
        public readonly PANumber value => _value;
        // { 
        //     get
        //     {
        //         return _value;
        //     }
        // }
        internal PANumber _value;

        [LibraryImport("pa")]
        public static partial PACount PACountPerformConstruct();
        [LibraryImport("pa")]
        public static partial PACount PACountPerformInit(PACount count, PANumber number);
        [LibraryImport("pa")]
        public static partial PACount PACountPerformCopy(PACount from, PACount to);
        [LibraryImport("pa")]
        public static partial PACount PACountPerformRuin(PACount pa);
        [LibraryImport("pa")]
        public static partial PACount PACountPerformDelete(PACount pa);

        public static PACount operator ++(PACount count) => PACount.PACountPerformInit(count, count._value++);
        public static bool operator <(PACount a, PACount b) => a._value < b._value;
        public static bool operator >(PACount a, PACount b) => a._value > b._value;
        // public static bool operator==(PACount a, PACount b) => a.value == b.value;
        // public static bool operator!=(PACount a, PACount b) => a.value != b.value;
        public static implicit operator int(PACount count) => (int)count._value;
        // public static explicit operator PACount(int value) => ;

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
