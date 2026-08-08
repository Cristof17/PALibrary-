using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAResource
    {

        public readonly PANumber Value => _value;

        internal readonly PANumber _value;

        [LibraryImport("pa")]
        public static partial PAResource PAResourcePerformConstruct();
        [LibraryImport("pa")]
        public static partial PAResource PAResourcePerformInit(PAResource resource, PANumber number);
        [LibraryImport("pa")]
        public static partial PAResource PAResourcePerformCopy(PAResource from, PAResource to);
        [LibraryImport("pa")]
        public static partial int PAResourcePerformRuin(PAResource pa);
        [LibraryImport("pa")]
        internal static partial int PAResourcePerformDelete(PAResource pa);
    }
}