using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;
using AL;
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
            // => 
            
        } 

        public readonly ArrayList Array
        {
            get
            {
                return _array;  
            } 
            
        } 

        internal readonly PACount _m;

        internal readonly ArrayList _array;

        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformInit(PASeries series, PACount n, ArrayList adj);
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
