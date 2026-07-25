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
        public PACount(PANumber Number) : this()
        {
            // Construct(Number);
            PACount count;
            count = PACountPerformConstruct();
            count = PACountPerformInit(count,Number);
            count.value = PANumber.PANumberPerformCopy(Number,count.value);
            value = PANumber.PANumberPerformCopy(count.value,value);
        }
        private PANumber value;

        [LibraryImport("pa")]
        internal static partial PACount PACountPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformInit(PACount Count, PANumber Number);
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformCopy(PACount from, PACount to);
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformRuin(PACount PA);
        [LibraryImport("pa")]
        internal static partial PACount PACountPerformDelete(PACount PA);

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
