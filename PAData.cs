using System.ComponentModel;
using System.Data;
using System.Numerics;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    public readonly partial struct PAData
    {
        public readonly PAResource Resource
        {
            get
            {
                return  _resource;
            }
        }
        
        internal readonly PAResource _resource;

        [LibraryImport("pa")]
        public static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAData PADataPerformInit(PAData data, PAResource resource);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformCopy(PAData from, PAData to);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformRuin(PAData pa);
        [LibraryImport("pa")]
        public static partial PAData PADataPerformDelete(PAData pa);

        public static bool operator ==(PAData one, PAData other) => one._resource == other._resource;
        public static bool operator != (PAData one, PAData other) => one._resource != other._resource;
    }
}