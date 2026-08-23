using System.Runtime.InteropServices;

namespace PA
{
    public readonly partial struct PASize
    {
        internal readonly unsafe byte* _digits;
        internal readonly unsafe byte* _value;
        internal readonly unsafe ulong _size;

        public unsafe byte* Digits => _digits;
        public unsafe byte* Value => _value;

        public ulong Size => _size;
    }
}