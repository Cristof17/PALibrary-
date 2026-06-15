using System;
using PA_Library;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential)]
// [StructLayout(LayoutKind.Sequential)]
struct PAResource
{
    [MarshalAs(UnmanagedType.IUnknown)]
    PANumber value;

    [DllImport("pa")]
    static extern PAResource PAResourcePerformConstruct();
    [DllImport("pa")]
    static extern PAResource PAResourcePerformInit(PAResource resource, PANumber number);
    [DllImport("pa")]
    static extern PAResource PAResourcePerformCopy(PAResource from, PAResource to);
    [DllImport("pa")]
    static extern int PAResourcePerformDelete(PAResource PA);
    // [DllImport("pa")]
    // static extern PAResourcePerformD();
    [DllImport("pa")]
    static extern int PAResourcePerformRuin(PAResource PA);
    // public PAResource Resource;

    // [FieldOffset(0)]
    // public PANumber Value;
    // public Resursa(int value)
    // public PAResource(int value)
    // {

    // }
}