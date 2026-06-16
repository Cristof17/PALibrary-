using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PAInput
    {
        PACount n;

        PACount m;

        PAList adj;

        PAElement sursa;

        [DllImport("pa")]
        static extern Input InputPerformConstruct();
        [DllImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        static extern Input InputPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAInput input, [MarshalAs(UnmanagedType.IUnknown)] PACount Count2, [MarshalAs(UnmanagedType.IUnknown)] PAElement Element);
        [DllImport("pa")]
        static extern Input InputPerformCopy([MarshalAs(UnmanagedType.IUnknown)] Input from, [MarshalAs(UnmanagedType.IUnknown)] Input to);
        [DllImport("pa")]
        static extern void InputDispose();
        [DllImport("pa")]
        static extern PAInput InputPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAInput PA);
        [DllImport("pa")]
        static extern void InputRuin([MarshalAs(UnmanagedType.IUnknown)] PAInput PA);
        PAInput(PACount n, PACount m, PASeries adj, PAElement sursa) : this()
        {

        }
    }
}
