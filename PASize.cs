using System.Runtime.InteropServices;

namespace PA
{
        [StructLayout(LayoutKind.Sequential)]
    public partial struct PASize
    {
        internal unsafe byte* _digits;
        internal unsafe byte* _value;
        internal unsafe ulong _size;
    }
}