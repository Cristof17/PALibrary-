using System;
using PA_Library;
// using System;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential)]
public struct PANumber
{
    // [MarshalAs(UnmanagedType.IUnknown)]
    char value;
    // int value;
    // [FieldOffset(0)]

    [DllImport("pa")]
    static extern PANumber PANumberPerformConstruct();
    [DllImport("pa")]
    static extern PANumber PANumberPerformInit(PANumber Number, char Value);\
    [DllImport("pa")]
    static extern PANumber PANumberPerformCopy(PANumber from, PANumber to);
    [DllImport("pa")]
    static extern PANumber PANumberPerformDelete(PANumber PA);
    [DllImport("pa")]
    static extern PANumber PANumberPerformRuin(PANumber PA);
    // [StructLayout(LayoutKind.Sequential)]
    // public struct PANumber Number;
}