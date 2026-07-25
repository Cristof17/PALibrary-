using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAResource
    {
        public PAResource(PANumber Number)
        {
            // PAResource resout;
            PAResource resource;
            // resu
            resource = PAResourcePerformConstruct();
            // resource = PAA
            value = default;
            // resource = PAResourcePerformInit(ref,Number);
            // resource = PAResourcePerformInit(resource,Number_
            resource = PAResourcePerformInit(resource,Number);
            resource.value = PANumber.PANumberPerformCopy(Number,resource.value);
            value = PANumber.PANumberPerformCopy(resource.value,value);
            // value = PANumber.PANumberPerformConstruct();
            // value = PANumber.PANumberPerformCopy(Number, value);
        }
        private PANumber value;

        [LibraryImport("pa")]
        internal static extern PAResource PAResourcePerformConstruct();
        [LibraryImport("pa")]
        internal static extern PAResource PAResourcePerformInit([MarshalAs(UnmanagedType.IUnknown)] PAResource resource, [MarshalAs(UnmanagedType.IUnknown)] PANumber number);
        [LibraryImport("pa")]
        internal static extern PAResource PAResourcePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAResource from, [MarshalAs(UnmanagedType.IUnknown)] PAResource to);
        [LibraryImport("pa")]
        internal static extern int PAResourcePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [LibraryImport("pa")]
        internal static extern int PAResourcePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
    }
}