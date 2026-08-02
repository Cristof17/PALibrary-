using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PAResource
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

        public readonly PANumber value => _value;
        // { 
        //     get
        //     {
        //         return _value;    
        //     }
        // }

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
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
    }
}