using System;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    internal partial struct PAList
    {
        // public PAList(PACount N, PASeries Adj) : this()
        // {
        //     PAList list;
        //     list = PAListPerformConstruct();
        //     list = PAListPerformInit(list, N, Adj);
        //     // n = 
        //     // n = PACount.PACountPerformConstruct();
        //     n = PACount.PACountPerformCopy(list.n, n);
        //     list.adj = PASeries.PASeriesPerformCopy(Adj, list.adj);
        //     adj = PASeries.PASeriesPerformCopy(list.adj, adj);
        //     // PAList.PAListPerformCopy()
        //     // adj_node = PA
        //     // PACount x = PACount.PACountPerformConstruct();
        //     // while (x < n)
        //     // {
        //     //     // adj_node[x] = PASerie
        //     //     PASeries aux = PASeries.PASeriesPerformConstruct();
        //     //     aux = PASeries.copy(ADJ_NODE[x], aux);
        //     //     adj_node[x] = PASeries.PASeriesPerformCopy(aux, adj_node[x]);
        //     //     x++;
        //     // }
        // }

        public readonly PACount n 
        { 
            get
            {
                return _n;        
            } 
        }

        public readonly PASeries adj 
        { 
            get
            {
                return _adj;
            } 
        }

        internal PACount _n;

        internal PASeries _adj;

        [LibraryImport("pa")]
        internal static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformInit(PAList list, PACount n, in PASeries adj);
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformCopy(PAList from, PAList to);
        // DllExport void PAListDispose(void);
        // DllExport struct PAList PAListPerformCopy(struct PAList);
        // DllExportPAResult PAListPerformPutCount(struct PAList, struct PACount);
        // DllExport PAResult PAListPerformPutList(struct PAList);
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        internal static partial PAList PAListPerformDelete(PAList PA);
        [LibraryImport("pa")]
        internal static partial void PAListPerformPrint(PAList List);
    }
}
