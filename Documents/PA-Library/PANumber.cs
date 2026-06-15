using System;
using PA_Library;
// using System;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Explicit)]
public struct PANumber
{
    [MarshalAs(UnmanagedType.IUnknown)]
    // int value;
    [FieldOffset(0)]
    char value;

    [DllImport("pa")]
    static extern PANumber PANumberPerformConstruct();
    [DllImport("pa")]
    static extern PANumber PANumberPerformInit(PANumber Number, char Value);
    [DllImport("pa")]
    static extern PANumber PANumberPerformDelete(PANumber Number);
    [DllImport("pa")]
    static extern PANumber PANumberPerformRuin(PANumber Number);
    [DllImport("pa")]
    static extern PANumber PANumberPerformCopy(PANumber from, PANumber to);
    // [StructLayout(LayoutKind.Sequential)]
    // public struct PANumber Number;
}