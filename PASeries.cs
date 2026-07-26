using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PASeries
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
        internal required PACount m { get; set; }

        internal required PAElement array { get; set; }

        [LibraryImport("pa")]
        internal static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PASeries PASeriesPerformInit(PASeries Series, PACount M, in PAElement[] Adj);
        [LibraryImport("pa")]
        internal static partial PASeries PASeriesPerformCopy(PASeries From, PASeries To);
        [LibraryImport("pa")]
        // internal static extern PAResource PASeriesGet([MarshalAs(UnmanagedType.IUnknown)] PAData Data);
        // [DllImport("pa")]
        internal static partial void PASeriesPerformPrint(PASeries Series);
        [LibraryImport("pa")]
        internal static partial PASeries PASeriesPerformRuin(PASeries PA);
        [LibraryImport("pa")]
        internal static partial PASeries PASeriesPerformDelete(PASeries PA);
    }
}
// }
