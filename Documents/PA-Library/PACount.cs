using System;
using System.Runtime.InteropServices;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PACount
    //public struct PAPACount
    {
        [MarshalAs(UnmanagedType.IUnknown)]
        PANumber value;

        [DllImport("pa")]
        static extern PACount PACountPerformConstruct();
        [DllImport("pa")]
        static extern PACount PACountPerformInit(PACount Count, PANumber Number);
        [DllImport("pa")]
        static extern PACount PACountPerformCopy(PACount from, PACount to);
        [DllImport("pa")]
        static extern PACount PACountPerformRuin(PACount PA);
        [DllImport("pa")]
        static extern PACount PACountPerformDelete(PACount PA);
// DllExport struct PACount PACountPerformCopy(struct PACount);
// void PASize(PA_INT);
// DllExport HRESULT PACountPerformPrint(struct PACount);
// DllExport struct PACount PACountPerformPutValue(struct PACount, PAInt);
// struct 
//         [DllImport("palibrary")]
//          static extern PACount PACountPerformConstruct();
//         [DllImport("palibrary")]
//         static extern PACount PACountPerformInit( PACount Count,  PANumber Number);
//         [DllImport("palibrary")]
//         static extern  PACount PACountPerformCopy( PACount from,  PACount to);
//         [DllImport("palibrary")]
// // DllExport struct PACount PACountPerformCopy(struct PACount);
// // void PASize(PA_INT);
// // DllExport HRESULT PACountPerformPrint(struct PACount);
//         static extern PACount PACountPerformRuin( PACount Count);
// // DllExport struct PACount PACountPerformPutValue(struct PACount, PAInt);
// // struct 
//         [DllImport("palibrary")]
//         static extern PACount PACountPerformDelete( PACount PA);

//         // [FieldOffset(0)]
//         private int Number;
//         [DllImport("palibrary")]
//         public static extern void PACountConstruct(int value);
//         [DllImport("palibrary")]
//         public static extern int PACountRuin(int value);
//         [DllImport("palibrary")]
//         public static extern PACount PACountInit(PACount value);

//         [DllImport("palibrary")]
//         public static extern int PACountDelete(PACount PA);

        // [FieldOffset(0)]
        private int number;

        // [StructLayout(LayoutKind.Sequential)]
        // public struct PACount Count {get;}
        // PACount(int number) : this()
        // {
            
        // }
        // public Cardinal(int number)
        // {
        //     NUMBER = default;//(int) value;
        // }
        // public Cardinal(ulong value)
        // {
        //     NUMBER = default;// (int)value;
        // }
        // public Cardinal(int Value)
        // {
        //     NUMBER = default;// value;
        // }
        //public PACount(int value)
        //{
        //NUMBER = value;
        //if (value < 0)
        //{
        //    Console.Error.WriteLine("value < 0");
        //    VALUE = value;
        //}
        //else if (value == 0)
        //{
        //    Console.Error.WriteLine("value == 0");
        //    VALUE = value;
        //}
        //else if ((value != 0) && (value > 0))
        //{ 
        //    VALUE = value;
        //}
        //OUTPUT = output;
        //}

        // public static implicit operator byte(PACount d) => (byte)d.NUMBER;
        // public static implicit operator PACount(byte b) => new PACount(b);
        // public static implicit operator int(PACount d) => (int)d.NUMBER;
        // public static implicit operator PACount(int b) => new PACount(b);
        // public static implicit operator long(PACount d) => (long)d.NUMBER;
        // public static explicit operator PACount(long b) => new PACount(b);
        // public static implicit operator short(PACount d) => (short)d.NUMBER;
        // public static explicit operator PACount(short b) => new PACount(b);
        // public static implicit operator ushort(PACount d) => (ushort)d.NUMBER;
        // public static explicit operator PACount(ushort b) => new PACount(b);
        // public static implicit operator ulong(PACount d) => (ulong)d.NUMBER;
        // public static explicit operator PACount(ulong b) => new PACount(b);
        // public static PACount operator -(PACount a) => new PACount(-a.NUMBER);

        // public static PACount operator +(PACount a, PACount b)
        //     => new PACount(a.NUMBER + b.NUMBER);

        // public static PACount operator -(PACount a, PACount b)
        //     => new PACount(a.NUMBER + (-b.NUMBER));

        // public static PACount operator *(PACount a, PACount b)
        //     => new PACount(a.NUMBER * b.NUMBER);

        // public static PACount operator /(PACount a, PACount b)
        // {
        //     if (b.NUMBER == 0)
        //     {
        //         throw new DivideByZeroException();
        //     }
        //     // return new PACount(a.NUMBER * b.NUMBER);
        // }

        // public override bool Equals(Object o)
        // {
            // return o == (Object)this;
        // }

        //public struct PACount
        // public int NUMBER { get; }
        //public Output OUTPUT { get; }

        //public override string ToString() => $"({N})";
        // public override string ToString() => $"({NUMBER})";

        // public override int GetHashCode()
        // {
            // return -1271321926 + NUMBER.GetHashCode();
        // }
        //        public override string ToString() => $"({INPUT}, {OUTPUT})";
        //internal class PACount
        // {
        // int N,
        //}
    }
}
