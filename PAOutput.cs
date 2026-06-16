using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    protected struct PAOutput
    {
        BFSRecord result;

        [DllImport("pa")]
        static extern Output OutputPerformConstruct();
        [DllImport("pa")]
        static extern Output OutputPerformInit([MarshalAs(UnmanagedType.IUnknown)] Output Output, [MarshalAs(UnmanagedType.IUnknown)] BFSRecord Record);
        [DllImport("pa")]
        static extern Output OutputPerformCopy([MarshalAs(UnmanagedType.IUnknown)] Output Output, [MarshalAs(UnmanagedType.IUnknown)] Output to);
        [DllImport("pa")]
        static extern void OutputPerformPrint(int resulrt);
        //struct Output dispose();
        [DllImport("pa")]
        static extern void OutputPerformDelete([MarshalAs(UnmanagedType.IUnknown)] Output PA);
        [DllImport("pa")]
        static extern void OutputPerformRuin([MarshalAs(UnmanagedType.IUnknown)] Output PA);
    }
}