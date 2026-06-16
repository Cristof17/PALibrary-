using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    protected struct PAElement
    {
        PAData index;

        PAStatus status;

        [DllImport("pa")]
        static extern PAElement PAElementPerformConstruct();
        [DllImport("pa")]
        static extern PAElement PAElementPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAData data, [MarshalAs(UnmanagedType.IUnknown)] PAStatus status);
        [DllImport("pa")]
        static extern void PAElementVisit([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        static extern int PAElementIsVisited([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        static extern void PAElementReset([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        static extern PAElement PAElementPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAElement element, [MarshalAs(UnmanagedType.IUnknown)] PAElement element2);
        [DllImport("pa")]
        static extern PAElement PAElementPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
        [DllImport("pa")]
        static extern PAElement PAElementPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAElement element);
    }
}