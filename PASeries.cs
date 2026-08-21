using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;
using AL;
using System.Runtime.CompilerServices;
namespace PA
{
    public readonly partial struct PASeries
    {
        public readonly PACount M
        {
            get
            {
                return _m;
            }
        }

        public readonly unsafe PAElement* Adj;
        // {
        //     // get
        //     // {
        //     //     return ref _adj;  
        //     // } 
        // }

        // public PAElement this[int node]
        // {
        //     get
        //     {
        //         PAElement element = PAElement.PAElementPerformConstruct();
        //         return element;
        //         // return _array[node];
        //         //get element at position node
        //     }
        // }

        internal readonly PACount _m;

        internal readonly PAElement _adj;

        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformInit(PASeries series, PACount n, ref PAElement adj);
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
