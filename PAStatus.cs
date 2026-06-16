using PA_Library;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
protected struct PAStatus
{
    int Visited;

    PAResource resource;
    
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformConstruct();
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAStatus Status, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAStatus from, [MarshalAs(UnmanagedType.IUnknown)] PAStatus to);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);
}