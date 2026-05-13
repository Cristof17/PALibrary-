using PA_Library;
using System;
using System.Runtime.InteropServices;
//public class PAStare
//public class PAStare
[StructLayout(LayoutKind.Explicit)]
public struct PAStatus
{
    // [StructLayout(LayoutKind.Sequential)]
    // struct PAStatus status;

    [FieldOffset(0)]
    private int Visited;
    public PAStatus(int Visited) : this()
    {
        
    }
    //struct PAStatus
    // VISITED,
    // NOT_VISITED
}