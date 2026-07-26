// using System.Linq.Expressions;
using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAElement
    {
        // public PAElement(PAData Data) : this()
        // {
        //     PAStatus status;
        //     PAData n;
        //     PAElement element;
        //     // status = PAStatus.STATUS_VISITED;
        //     // status = PAStatus.STATUS_NOT_VISITED;
        //     status = new PAStatus(false);
        //     element = PAElementPerformConstruct();
        //     element = PAElementPerformInit(element, Data, status);
        //     n = PAData.PADataPerformCopy(element.Index, Index);
        //     // index = 
        //     // index = PAData.PADataPerformConstruct();
        //     // status = PAStatus.PAStatusPerformConstruct();
        //     // status = PAStatus.PAStatusPerformCopy(element.status,status);
        // }
        internal required PAData Index { get; set; }

        internal required PAStatus Status { get; set; }

        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformInit(PAElement element, PAData data, PAStatus status);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformCopy(PAElement from, PAElement to);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformRuin(PAElement pa);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformDelete(PAElement pa);
        [LibraryImport("pa")]
        internal static partial int PAElementIsVisited(PAElement element);
        [LibraryImport("pa")]
        internal static partial void PAElementReset(PAElement element);
    }
}