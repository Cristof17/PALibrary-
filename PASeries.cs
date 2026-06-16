using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PASeries
    {
        PACount n;

        PAList[] adj;

        [DllImport("pa")]
        static extern PASeries PASeriesPerformConstruct();
        [DllImport("pa")]
        static extern PASeries PASeriesPerformInit([MarshalAs(UnmanagedType.IUnknown)] PASeries Series, [MarshalAs(UnmanagedType.IUnknown)] PACount M, [MarshalAs(UnmanagedType.IUnknown)] in PAElement[] adj);
        [DllImport("pa")]
        static extern PASeries PASeriesPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PASeries Series1, [MarshalAs(UnmanagedType.IUnknown)] PASeries Series);
        [DllImport("pa")]
        static extern PAResource PASeriesGet([MarshalAs(UnmanagedType.IUnknown)] PAData Data);
        [DllImport("pa")]
        static extern void PASeriesPerformPrint([MarshalAs(UnmanagedType.IUnknown)] PASeries Series);
        [DllImport("pa")]
        static extern PASeries PASeriesPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PASeries PA);
        [DllImport("pa")]
        static extern PASeries PASeriesPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PASeries PA);

        public PASeries(PACount n, PAList[] adj) : this()
        {
        }
    }
}
// }
