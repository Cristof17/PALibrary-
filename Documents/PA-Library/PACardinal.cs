using System;

namespace PA_Library
{
    public class PACardinal
    //public struct PAPACardinal
    {
        [DllImport("palibrary.dll")]
        public static extern void PACountConstruct();
        [DllImport("palibrary.dll")]
        public static extern void PACountRuin();
        [DllImport("palibrary.dll")]
        public static extern void PACountInit();
        [DllImport("palibrary.dll")]
        public static extern void PACountDelete();

        public PACardinal(long value)
        {
            NUMBER = default;//(int) value;
        }
        public PACardinal(ulong value)
        {
            NUMBER = default;// (int)value;
        }
        public PACardinal(int Value)
        {
            NUMBER = default;// value;
        }
        //public PACardinal(int value)
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

        public static implicit operator byte(PACardinal d) => (byte)d.NUMBER;
        public static implicit operator PACardinal(byte b) => new PACardinal(b);
        public static implicit operator int(PACardinal d) => (int)d.NUMBER;
        public static implicit operator PACardinal(int b) => new PACardinal(b);
        public static implicit operator long(PACardinal d) => (long)d.NUMBER;
        public static explicit operator PACardinal(long b) => new PACardinal(b);
        public static implicit operator short(PACardinal d) => (short)d.NUMBER;
        public static explicit operator PACardinal(short b) => new PACardinal(b);
        public static implicit operator ushort(PACardinal d) => (ushort)d.NUMBER;
        public static explicit operator PACardinal(ushort b) => new PACardinal(b);
        public static implicit operator ulong(PACardinal d) => (ulong)d.NUMBER;
        public static explicit operator PACardinal(ulong b) => new PACardinal(b);
        public static PACardinal operator -(PACardinal a) => new PACardinal(-a.NUMBER);

        public static PACardinal operator +(PACardinal a, PACardinal b)
            => new PACardinal(a.NUMBER + b.NUMBER);

        public static PACardinal operator -(PACardinal a, PACardinal b)
            => new PACardinal(a.NUMBER + (-b.NUMBER));

        public static PACardinal operator *(PACardinal a, PACardinal b)
            => new PACardinal(a.NUMBER * b.NUMBER);

        public static PACardinal operator /(PACardinal a, PACardinal b)
        {
            if (b.NUMBER == 0)
            {
                throw new DivideByZeroException();
            }
            return new PACardinal(a.NUMBER * b.NUMBER);
        }

        public override bool Equals(Object o)
        {
            return o == (Object)this;
        }

        //public struct PACount
        public int NUMBER { get; }
        //public Output OUTPUT { get; }

        //public override string ToString() => $"({N})";
        public override string ToString() => $"({NUMBER})";

        public override int GetHashCode()
        {
            return -1271321926 + NUMBER.GetHashCode();
        }
        //        public override string ToString() => $"({INPUT}, {OUTPUT})";
        //internal class PACardinal
        // {
        // int N,
        //}
    }
}
