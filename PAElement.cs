// using System.Linq.Expressions;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAElement
    {
        public PAElement(PAData Data) : this()
        {
            PAElement element;
            PAStatus status;
            // status = PAStatus.STATUS_VISITED;
            // status = PAStatus.STATUS_NOT_VISITED;
            status = new PAStatus(false);
            element = PAElementPerformConstruct();
            element = PAElementPerformInit(element,Data,status);
            index = PAData.PADataPerformCopy(element.index,Index);
            // index = 
            // index = PAData.PADataPerformConstruct();
            // status = PAStatus.PAStatusPerformConstruct();
            // status = PAStatus.PAStatusPerformCopy(element.status,status);
        }
        private PAData Index;

        private int Status;

        [DllImport("pa")]
        internal static extern PAElement PAElementPerformConstruct();
        [DllImport("pa")]
        internal static extern PAElement PAElementPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAData data, [MarshalAs(UnmanagedType.IUnknown)] int status);
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