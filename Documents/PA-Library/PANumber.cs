using System;
using PA_Library;
// using System;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Explicit)]
public struct PANumber
{
    [DllImport("palibrary")]
 static extern PANumber PANumberPerformConstruct();
[DllImport("palibrary")]
 static extern PANumber PANumberPerformInit(PANumber Number,  char Value);
[DllImport("palibrary")]
 static extern PANumber PANumberPerformDelete( PANumber Number);
[DllImport("palibrary")]
 static extern PANumber PANumberPerformRuin( PANumber Number);
[DllImport("palibrary")]
 static extern PANumber PANumberPerformCopy( PANumber from,  PANumber to);
    // [StructLayout(LayoutKind.Sequential)]
    // public struct PANumber Number;
}