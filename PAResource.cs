using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAResource
    {
        // public PAResource(PANumber Number)
        // {
        //     // PAResource resout;
        //     PAResource resource;
        //     // resu
        //     resource = PAResourcePerformConstruct();
        //     // resource = PAA
        //     value = default;
        //     // resource = PAResourcePerformInit(ref,Number);
        //     // resource = PAResourcePerformInit(resource,Number_
        //     resource = PAResourcePerformInit(resource, Number);
        //     resource.value = PANumber.PANumberPerformCopy(Number, resource.value);
        //     value = PANumber.PANumberPerformCopy(resource.value, value);
        //     // value = PANumber.PANumberPerformConstruct();
        //     // value = PANumber.PANumberPerformCopy(Number, value);
        // }
        internal required PANumber _value;

        [LibraryImport("pa")]
        internal static partial PAResource PAResourcePerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAResource PAResourcePerformInit(PAResource resource, PANumber number);
        [LibraryImport("pa")]
        internal static partial PAResource PAResourcePerformCopy(PAResource from, PAResource to);
        [LibraryImport("pa")]
        internal static partial int PAResourcePerformRuin(PAResource pa);
        [LibraryImport("pa")]
        internal static partial int PAResourcePerformDelete(PAResource pa);
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
    }
}