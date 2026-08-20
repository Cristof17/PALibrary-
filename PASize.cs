using System.Runtime.InteropServices;

namespace PA
{
    public readonly partial struct PASize
    {
        internal readonly unsafe byte* _digits;
        internal readonly unsafe byte* _value;
        internal readonly unsafe ulong size;

        public unsafe byte* Digits
        {
            get
            {
                return _digits;
            }
        }
        public unsafe byte* Value
        {
            get
            {
                return _value;
            }
        }

        public ulong Size
        {
            get
            {
                return size;
            }
        }
    }
}