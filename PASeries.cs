using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;
using AL;
using System.Runtime.CompilerServices;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PASeries
    {
        public PACount M ;

        // public readonly unsafe PAElement* Adj;
        // {
        //     // get
        //     // {
        //     //     return ref _adj;  
        //     // } 
        // }

        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        public static unsafe partial PASeries PASeriesPerformInit(PASeries series, PACount n, PAElement* adj);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformCopy(PASeries from, PASeries to);
        [LibraryImport("pa")]
        public static partial void PASeriesPerformPrint(PASeries series);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformRuin(PASeries pa);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformDelete(PASeries pa);
    }
}
// }
