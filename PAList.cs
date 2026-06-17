using System;
using System.Runtime.InteropServices;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAList
    {
        public PAList(PACount N, PASeries[] ADJ_NODE) : this()
        {
            n = PACount.PACountPerformConstruct();
            n = PACount.PACountPerformCopy(N, n);

            PACount x = PACount.PACountPerformConstruct();
            while (x < n)
            {
                // adj_node[x] = PASerie
                PASeries aux = PASeries.PASeriesPerformConstruct();
                aux = PASeries.copy(ADJ_NODE[x], aux);
                adj_node[x] = PASeries.PASeriesPerformCopy(aux, adj_node[x]);
                x++;
            }
        }

        private PACount n;
        private PASeries[] adj_node;

        [DllImport("pa")]
        internal static extern PAList PAListPerformConstruct();
        [DllImport("pa")]
        internal static extern PAList PAListPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAList List, [MarshalAs(UnmanagedType.IUnknown)] PACount N, [MarshalAs(UnmanagedType.IUnknown)] in PASeries[] adj);
        [DllImport("pa")]
        internal static extern PAList PAListPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAList from, [MarshalAs(UnmanagedType.IUnknown)] PAList to);
        // DllExport void PAListDispose(void);
        [DllImport("pa")]
        static extern void PAListPerformPrint([MarshalAs(UnmanagedType.IUnknown)] PAList List);
        // DllExport struct PAList PAListPerformCopy(struct PAList);
        // DllExportPAResult PAListPerformPutCount(struct PAList, struct PACount);
        // DllExport PAResult PAListPerformPutList(struct PAList);
        [DllImport("pa")]
        internal static extern PAList PAListPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAList PA);
        [DllImport("pa")]
        internal static extern PAList PAListPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAList PA);
    }
}
