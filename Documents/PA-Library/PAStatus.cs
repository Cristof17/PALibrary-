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
    static extern PAStatus PAStatusPerformInit(PAStatus Status, PAResource Resource);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformDelete(PAStatus Status);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformConstruct();
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformRuin(PAStatus Status);
    [DllImport("pa")]
    static extern PAStatus PAStatusPerformCopy(PAStatus Status, PAStatus Status2);
    // [FieldOffset(0)]
    // PAStatus(int Visited) : this()
    // {

    // }
    //struct PAStatus
    // VISITED,
    // NOT_VISITED
}