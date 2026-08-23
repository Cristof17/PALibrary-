using System.Runtime.InteropServices;
// using System.Xml.Schema;
// using PA;
using AL;
using System.Runtime.CompilerServices;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PASeries
    {
        PACount M ;

        // public readonly unsafe PAElement* Adj;
        // {
        //     // get
        //     // {
        //     //     return ref _adj;  
        //     // } 
        // }

        [LibraryImport("pa")]
        internal static partial 
        PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        internal static unsafe partial 
        PASeries PASeriesPerformInit(PASeries series, PACount n, PAElement* adj);
        [LibraryImport("pa")]
        internal static partial 
        PASeries PASeriesPerformCopy(PASeries from, PASeries to);
        [LibraryImport("pa")]
        internal static partial
        void PASeriesPerformPrint(PASeries series);
        [LibraryImport("pa")]
        internal static partial 
        PASeries PASeriesPerformRuin(PASeries pa);
        [LibraryImport("pa")]
        internal static partial 
        PASeries PASeriesPerformDelete(PASeries pa);
    }
}
// }
