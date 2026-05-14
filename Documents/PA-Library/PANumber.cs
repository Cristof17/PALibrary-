using System;
using PA_Library;
// using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
public struct PANumber
{
    [FieldOffset(0)]
    private int val;
    // [StructLayout(LayoutKind.Sequential)]
    // public struct PANumber Number;
}