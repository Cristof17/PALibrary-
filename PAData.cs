using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAData
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
        public readonly PAResource resource 
        { 
            get
            {
                return _resource;
            }
        }
        
        internal PAResource _resource;

        [LibraryImport("pa")]
        internal static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformInit(PAData data, PAResource resource);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformCopy(PAData from, PAData to);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformRuin(PAData pa);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformDelete(PAData pa);
    }
}