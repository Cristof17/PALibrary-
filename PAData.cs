using System.ComponentModel;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAData
    {
        public PAData(PAResource Resource)
        {
            PAData data;
            data = PADataPerformConstruct();
            data = PADataPerformInit(data,Resource);
            resource = default;
            // data 
            // resource = PAResource.PAResourcePerformConstruct();
            resource = PAResource.PAResourcePerformCopy(data.resource,resource);
        }
        private PAResource resource;

        [LibraryImport("pa")]
        internal static extern PAData PADataPerformConstruct();
        [LibraryImport("pa")]
        internal static extern PAData PADataPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAData Data, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
        [LibraryImport("pa")]
        internal static extern PAData PADataPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAData PA);
        [LibraryImport("pa")]
        internal static extern PAData PADataPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAData PA);
        [LibraryImport("pa")]
        internal static extern PAData PADataPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAData from, [MarshalAs(UnmanagedType.IUnknown)] PAData to);
    }
}