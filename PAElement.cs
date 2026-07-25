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
            PAStatus status;
            PAData n;
            PAElement element;
            // status = PAStatus.STATUS_VISITED;
            // status = PAStatus.STATUS_NOT_VISITED;
            status = new PAStatus(false);
            element = PAElementPerformConstruct();
            element = PAElementPerformInit(element,Data,status);
            n = PAData.PADataPerformCopy(element.Index,Index);
            // index = 
            // index = PAData.PADataPerformConstruct();
            // status = PAStatus.PAStatusPerformConstruct();
            // status = PAStatus.PAStatusPerformCopy(element.status,status);
        }
        private PAData Index;

        private PAStatus Status;

        [LibraryImport("pa")]
        internal static extern PAElement PAElementPerformConstruct();
        [LibraryImport("pa")]
        internal static extern PAElement PAElementPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAData data, [MarshalAs(UnmanagedType.IUnknown)] PAStatus status);
        [LibraryImport("pa")]
        internal static extern void PAElementVisit([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [LibraryImport("pa")]
        internal static extern int PAElementIsVisited([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [LibraryImport("pa")]
        internal static extern void PAElementReset([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [LibraryImport("pa")]
        internal static extern PAElement PAElementPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAElement element2);
        [LibraryImport("pa")]
        internal static extern PAElement PAElementPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [LibraryImport("pa")]
        internal static extern PAElement PAElementPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
    }
}