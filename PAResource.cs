using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAResource
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
            resource = PAResourcePerformInit(resource, Number);
            resource.value = PANumber.PANumberPerformCopy(Number, resource.value);
            value = PANumber.PANumberPerformCopy(resource.value, value);
            // value = PANumber.PANumberPerformConstruct();
            // value = PANumber.PANumberPerformCopy(Number, value);
        }
        private PANumber value;

        [LibraryImport("pa")]
        internal static partial PAResource PAResourcePerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAResource PAResourcePerformInit(PAResource Resource, PANumber Number);
        [LibraryImport("pa")]
        internal static partial PAResource PAResourcePerformCopy(PAResource From, PAResource To);
        [LibraryImport("pa")]
        internal static partial int PAResourcePerformDelete(PAResource PA);
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [LibraryImport("pa")]
        internal static partial int PAResourcePerformRuin(PAResource PA);
    }
}