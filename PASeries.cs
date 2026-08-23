using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;
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
        static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        static unsafe partial PASeries PASeriesPerformInit(PASeries series, PACount n, PAElement* adj);
        [LibraryImport("pa")]
        static partial PASeries PASeriesPerformCopy(PASeries from, PASeries to);
        [LibraryImport("pa")]
        static partial void PASeriesPerformPrint(PASeries series);
        [LibraryImport("pa")]
        static partial PASeries PASeriesPerformRuin(PASeries pa);
        [LibraryImport("pa")]
        static partial PASeries PASeriesPerformDelete(PASeries pa);
    }
}
// }
