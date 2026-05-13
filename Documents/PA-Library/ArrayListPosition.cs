using PA_Library;
using System;
using System.Runtime.InteropServices;
namespace PA_Library
{

    [StructLayout(LayoutKind.Explicit)]
    public struct ArrayListPosition
    {
        // [DllImport("palibrary")]
        [FieldOffset(0)]
        private int Position; 
    }

}