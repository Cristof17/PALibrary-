using System;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAList
    {
        public PAList(PACount N, PASeries Adj) : this()
        {
            PAList list;
            list = PAListPerformConstruct();
            list = PAListPerformInit(list,N,Adj);
            // n = 
            // n = PACount.PACountPerformConstruct();
            n = PACount.PACountPerformCopy(list.n, n);
            list.adj = PASeries.PASeriesPerformCopy(Adj,list.adj);
            adj = PASeries.PASeriesPerformCopy(list.adj,adj);
            // PAList.PAListPerformCopy()
            // adj_node = PA
            // PACount x = PACount.PACountPerformConstruct();
            // while (x < n)
            // {
            //     // adj_node[x] = PASerie
            //     PASeries aux = PASeries.PASeriesPerformConstruct();
            //     aux = PASeries.copy(ADJ_NODE[x], aux);
            //     adj_node[x] = PASeries.PASeriesPerformCopy(aux, adj_node[x]);
            //     x++;
            // }
        }

        private PACount n;
        private PASeries adj;

        [LibraryImport("pa")]
        internal static extern PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        internal static extern PAList PAListPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PACount N, [MarshalAs(UnmanagedType.IUnknown)] in PASeries adj);
        [LibraryImport("pa")]
        internal static extern PAList PAListPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAList from, [MarshalAs(UnmanagedType.IUnknown)] PAList to);
        // DllExport void PAListDispose(void);
        [LibraryImport("pa")]
        static extern void PAListPerformPrint([MarshalAs(UnmanagedType.IUnknown)] PAList List);
        // DllExport struct PAList PAListPerformCopy(struct PAList);
        // DllExportPAResult PAListPerformPutCount(struct PAList, struct PACount);
        // DllExport PAResult PAListPerformPutList(struct PAList);
        [LibraryImport("pa")]
        internal static extern PAList PAListPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAList PA);
        [LibraryImport("pa")]
        internal static extern PAList PAListPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAList PA);
    }
}
