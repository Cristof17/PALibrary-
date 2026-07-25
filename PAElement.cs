// using System.Linq.Expressions;
using System.Runtime.InteropServices;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAElement
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
        internal static partial PAElement PAElementPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformInit(PAElement element, PAData data, PAStatus status);
        [LibraryImport("pa")]
        internal static partial void PAElementVisit(PAElement element);
        [LibraryImport("pa")]
        internal static partial int PAElementIsVisited(PAElement element);
        [LibraryImport("pa")]
        internal static partial void PAElementReset(PAElement element);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformCopy(PAElement element, PAElement element2);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformDelete(PAElement element);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformRuin(PAElement element);
    }
}