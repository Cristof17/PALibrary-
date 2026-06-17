// using System.Linq.Expressions;
using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAElement
    {
        public PAElement(PAData Data, PAStatus Status) : this()
        {
            index = PAData.PADataPerformConstruct();
            index = PAData.PADataPerformCopy(Data,index);
            status = PAStatus.PAStatusPerformConstruct();
            status = PAStatus.PAStatusPerformCopy(Status,status);
        }
        private PAData index;

        private PAStatus status;

        [DllImport("pa")]
        internal static extern PAElement PAElementPerformConstruct();
        [DllImport("pa")]
        internal static extern PAElement PAElementPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAData data, [MarshalAs(UnmanagedType.IUnknown)] PAStatus status);
        [DllImport("pa")]
        internal static extern void PAElementVisit([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        internal static extern int PAElementIsVisited([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        internal static extern void PAElementReset([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        internal static extern PAElement PAElementPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAElement element2);
        [DllImport("pa")]
        internal static extern PAElement PAElementPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        internal static extern PAElement PAElementPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
    }
}