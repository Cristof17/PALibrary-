using System;
using PA_Library;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Sequential)]
// [StructLayout(LayoutKind.Sequential)]
struct PAResource
{
    PANumber value;

    [DllImport("pa")]
    static extern PAResource PAResourcePerformConstruct();
    [DllImport("pa")]
    static extern PAResource PAResourcePerformInit([MarshalAs(UnmanagedType.IUnknown)] PAResource resource, [MarshalAs(UnmanagedType.IUnknown)] PANumber number);
    [DllImport("pa")]
    static extern PAResource PAResourcePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAResource from, [MarshalAs(UnmanagedType.IUnknown)] PAResource to);
    [DllImport("pa")]
    static extern int PAResourcePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
    // [DllImport("pa")]
    // static extern PAResourcePerformD();
    [DllImport("pa")]
    static extern int PAResourcePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
    // public PAResource Resource;

    // [FieldOffset(0)]
    // public PANumber Value;
    // public Resursa(int value)
    // public PAResource(int value)
    // {

    // }
}