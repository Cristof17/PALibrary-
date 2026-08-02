using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;
using AL;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public readonly partial struct PASeries
    {
        // public PASeries(PACount M, PAElement[] array) : this()
        // {
        //     PASeries series;
        //     series = PASeriesPerformConstruct();
        //     // series = PASeriesPerformInit(sb)
        //     // series = PASeriesPerformInit(sbyte
        //     // ser)
        //     series = PASeriesPerformInit(series, M, array);
        //     // serie
        //     m = PACount.PACountPerformCopy(series.m, m);
        //     // adj = 
        //     // m = PACount.PACountPerformConstruct();
        //     // m = PACount.PACountPerformCopy(M, m);

        //     // PACount x = PACount.PACountPerformConstruct();
        //     // while (x < M)
        //     // {
        //     //     PAElement aux = PAElement.PAElementPerformConstruct();
        //     //     aux = PAElement.PAElementPerformCopy(ADJ[x], aux);
        //     //     adj[x] = PAElement.PAElementPerformCopy(aux, adj[x]);
        //     //     x++;
        //     // }

        //     // PASeriesPerformCopy(ADJ,adj);
        //     // PAList.PAListPerformCopy(ADJ,adj);
        //     // PASeries series;
        //     // PACount x = PACount.PACountPerformConstruct();
        //     // while (x.)
        // }

        // // internal static extern PASeries copy(PASeries from, PASeries to);
        // // {
        // //     PASeries copy;
        // //     copy = PASeriesPerformConstruct();
        // //     PACount x;
        // //     // PACount y;
        // //     x = PACount.PACountPerformConstruct();
        // //     // y = PACount.PACountPerformConstruct();
        // //     // PACount n;
        // //     // PACount m;
        // //     while (x < from.m)
        // //     {
        // //         PAElement aux = from.adj[x];
        // //         copy.adj[x] = aux;
        // //         x++;
        // //     }
        // //     x = PACount.PACountPerformDelete(x);
        // //     x = PACount.PACountPerformRuin(x);
        // //     x = PACount.PACountPerformConstruct();
        // //     // x = PACountPerformConstruct();;
        // //     while (x < from.m)
        // //     {
        // //         PAElement aux = copy.adj[x];
        // //         to.adj[x] = aux;
        // //         x++;
        // //     }
        // //     return to;
        // //     // PACount fromCount = from.C
        // // }

        public readonly PACount m => _m;
        // { 
        //     get
        //     {
        //         return _m;   
        //     } 
        // }

        // public readonly PAElement array => _array;
        public readonly ArrayList array => _array;
        // { 
        //     get
        //     {
        //         return _array;   
        //     } 
        // }

        internal readonly PACount _m;

        internal readonly ArrayList _array;

        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformInit(PASeries series, PACount n, ArrayList adj);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformCopy(PASeries from, PASeries to);
        [LibraryImport("pa")]
        // internal static extern PAResource PASeriesGet([MarshalAs(UnmanagedType.IUnknown)] PAData Data);
        // [DllImport("pa")]
        public static partial void PASeriesPerformPrint(PASeries series);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformRuin(PASeries pa);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformDelete(PASeries pa);
    }
}
// }
