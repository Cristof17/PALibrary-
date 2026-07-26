// using System.Linq.Expressions;
using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAElement
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
            element = PAElementPerformInit(element, Data, status);
            n = PAData.PADataPerformCopy(element.Index, Index);
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
        internal static partial PAElement PAElementPerformInit(PAElement Element, PAData Data, PAStatus Status);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformCopy(PAElement From, PAElement To);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformRuin(PAElement PA);
        [LibraryImport("pa")]
        internal static partial PAElement PAElementPerformDelete(PAElement PA);
        [LibraryImport("pa")]
        internal static partial int PAElementIsVisited(PAElement Element);
        [LibraryImport("pa")]
        internal static partial void PAElementReset(PAElement Element);
        [LibraryImport("pa")]
        internal static partial void PAElementVisit(PAElement Element);
    }
}