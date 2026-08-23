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
        static partial PAElement PAElementPerformConstruct();
        [LibraryImport("pa")]
        static partial PAElement PAElementPerformInit(PAElement element, PAData data, PAStatus status);
        [LibraryImport("pa")]
        static partial PAElement PAElementPerformCopy(PAElement from, PAElement to);
        [LibraryImport("pa")]
        static partial PAElement PAElementPerformRuin(PAElement pa);
        [LibraryImport("pa")]
        static partial PAElement PAElementPerformDelete(PAElement pa);
        [LibraryImport("pa")]
        static partial int PAElementIsVisited(PAElement element);
        [LibraryImport("pa")]
        static partial void PAElementReset(PAElement element);
    }
}