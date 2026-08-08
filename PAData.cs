using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAData
    {
        // public PAData(PAResource Resource)
        // {
        //     PAData data;
        //     data = PADataPerformConstruct();
        //     data = PADataPerformInit(data, Resource);
        //     resource = default;
        //     // data 
        //     // resource = PAResource.PAResourcePerformConstruct();
        //     resource = PAResource.PAResourcePerformCopy(data.resource, resource);
        // }
        public readonly PAResource Resource => _resource;
        // { 
        //     get
        //     {
        //         return _resource;
        //     }
        // }
        
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
    }
}