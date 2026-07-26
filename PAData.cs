using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAData
    {
        public PAData(PAResource Resource)
        {
            PAData data;
            data = PADataPerformConstruct();
            data = PADataPerformInit(data, Resource);
            resource = default;
            // data 
            // resource = PAResource.PAResourcePerformConstruct();
            resource = PAResource.PAResourcePerformCopy(data.resource, resource);
        }
        private PAResource resource { get; set;}

        [LibraryImport("pa")]
        internal static partial PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformInit(PAData Data, PAResource Resource);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformCopy(PAData From, PAData To);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformRuin(PAData PA);
        [LibraryImport("pa")]
        internal static partial PAData PADataPerformDelete(PAData PA);
    }
}