using System;
using PA_Library;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential)]
struct PAResource
    // [StructLayout(LayoutKind.Sequential)]
{
    // public PAResource Resource;

    // [FieldOffset(0)]
    public PANumber Value;
    // public Resursa(int value)
    public PAResource(int value)
    {

    }
}