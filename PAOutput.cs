using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAOutput : IStateMachine
    {
        private BFSRecord result;

        [DllImport("pa")]
        internal static extern Output OutputPerformConstruct();
        [DllImport("pa")]
        internal static extern Output OutputPerformInit([MarshalAs(UnmanagedType.IUnknown)] Output Output, [MarshalAs(UnmanagedType.IUnknown)] BFSRecord Record);
        [DllImport("pa")]
        internal static extern Output OutputPerformCopy([MarshalAs(UnmanagedType.IUnknown)] Output Output, [MarshalAs(UnmanagedType.IUnknown)] Output to);
        [DllImport("pa")]
        internal static extern void OutputPerformPrint(int resulrt);
        //struct Output dispose();
        [DllImport("pa")]
        internal static extern void OutputPerformDelete([MarshalAs(UnmanagedType.IUnknown)] Output PA);
        [DllImport("pa")]
        internal static extern void OutputPerformRuin([MarshalAs(UnmanagedType.IUnknown)] Output PA);

        // public PAOutput() : this()
        // {

        // }
    }
}