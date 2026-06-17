using System.ComponentModel;
using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAData : IStateMachine
    {
        public PAData(PAResource Resource)
        {
            resource = PAResource.PAResourcePerformConstruct();
            resource = PAResource.PAResourcePerformCopy(Resource,resource);
        }
        private PAResource resource;

        [DllImport("pa")]
        internal static extern PAData PADataPerformConstruct();
        [DllImport("pa")]
        internal static extern PAData PADataPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAData Data, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
        [DllImport("pa")]
        internal static extern PAData PADataPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAData PA);
        [DllImport("pa")]
        internal static extern PAData PADataPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAData PA);
        [DllImport("pa")]
        internal static extern PAData PADataPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAData from, [MarshalAs(UnmanagedType.IUnknown)] PAData to);
    }
}