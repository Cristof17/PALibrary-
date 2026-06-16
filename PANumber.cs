// using System;
using PA_Library;
// using System;
using System.Runtime.InteropServices;
// using System.Security.Authentication.ExtendedProtection;
[StructLayout(LayoutKind.Sequential)]
protected struct PANumber
{
    // [MarshalAs(UnmanagedType.IUnknown)]
    int value;
    // int value;
    // [FieldOffset(0)]

    [DllImport("pa")]
    static extern PANumber PANumberPerformConstruct();
    [DllImport("pa")]
    static extern PANumber PANumberPerformInit([MarshalAs(UnmanagedType.IUnknown)]PANumber Number, int Value);
    [DllImport("pa")]
    static extern PANumber PANumberPerformCopy([MarshalAs(UnmanagedType.IUnknown)]PANumber from, [MarshalAs(UnmanagedType.IUnknown)]PANumber to);
    [DllImport("pa")]
    static extern PANumber PANumberPerformDelete([MarshalAs(UnmanagedType.IUnknown)]PANumber PA);
    [DllImport("pa")]
    static extern PANumber PANumberPerformRuin([MarshalAs(UnmanagedType.IUnknown)]PANumber PA);
    // [StructLayout(LayoutKind.Sequential)]
    // public struct PANumber Number;
}