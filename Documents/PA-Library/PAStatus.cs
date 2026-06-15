using PA_Library;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ComponentModel;
// using System.Inter
//public class PAStare
//public class PAStare
[StructLayout(LayoutKind.Sequential)]
public struct PAStatus
{
    [MarshalAs(UnmanagedType.IUnknown)]
    int Visited;

    [MarshalAs(UnmanagedType.IUnknown)]
    PAResource resource;
    // [StructLayout(LayoutKind.Sequential)]
    // struct PAStatus status;
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformConstruct();
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformInit([MarshalAs(UnmanagedType.IUnknown)] PAStatus Status, [MarshalAs(UnmanagedType.IUnknown)] PAResource Resource);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAStatus from, [MarshalAs(UnmanagedType.IUnknown)] PAStatus to);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformDelete(PAStatus PA);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAStatus PA);

    // [FieldOffset(0)]
    // PAStatus(int Visited) : this()
    // {

    // }
    //struct PAStatus
    // VISITED,
    // NOT_VISITED
}