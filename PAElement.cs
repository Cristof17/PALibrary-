// using System.Linq.Expressions;
using System.Runtime.InteropServices;
// using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAElement
    {
        PAData Index;
        PAStatus Status;

        // internal unsafe PAElement *Next ;


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