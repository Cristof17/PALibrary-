using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
[   StructLayout(LayoutKind.Sequential)]
    public struct PAResource
    {
        public PANumber value;

        [DllImport("pa")]
        static extern PAResource PAResourcePerformConstruct();
        [DllImport("pa")]
        static extern PAResource PAResourcePerformInit([MarshalAs(UnmanagedType.IUnknown)] PAResource resource, [MarshalAs(UnmanagedType.IUnknown)] PANumber number);
        [DllImport("pa")]
        static extern PAResource PAResourcePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAResource from, [MarshalAs(UnmanagedType.IUnknown)] PAResource to);
        [DllImport("pa")]
        static extern int PAResourcePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [DllImport("pa")]
        static extern int PAResourcePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
    }
}