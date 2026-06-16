using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PASeries
    {
        public PASeries(PACount M, PAList[] ADJ) : this()
        {
            m = PACount.PACountPerformConstruct();
            m = PACount.PACountPerformCopy(M,m);
            // PASeriesPerformCopy(ADJ,adj);
            // PAList.PAListPerformCopy(ADJ,adj);
            // PASeries series;
            // PACount x = PACount.PACountPerformConstruct();
            // while (x.)
        }
        private PACount m;

        private PAList[] adj;

        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformConstruct();
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformInit([MarshalAs(UnmanagedType.IUnknown)] PASeries Series, [MarshalAs(UnmanagedType.IUnknown)] PACount M, [MarshalAs(UnmanagedType.IUnknown)] in PAElement[] adj);
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PASeries Series1, [MarshalAs(UnmanagedType.IUnknown)] PASeries Series);
        [DllImport("pa")]
        internal static extern PAResource PASeriesGet([MarshalAs(UnmanagedType.IUnknown)] PAData Data);
        [DllImport("pa")]
        internal static extern void PASeriesPerformPrint([MarshalAs(UnmanagedType.IUnknown)] PASeries Series);
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PASeries PA);
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PASeries PA);

    }
}
// }
