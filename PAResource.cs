using System.Numerics;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAResource
    {

        public readonly PANumber Value
        {
            get
            {
                return _value;  
            } 
        } 

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

        public static bool operator ==(PAResource one, PAResource other) => one._value == other._value;
        public static bool operator !=(PAResource one, PAResource other) => one._value != other._value;
    }
}