using PA_Library;
using System;
using System.Runtime.InteropServices;
// using System;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ArrayList
    {
        [DllImport("palibrary")]
        private static extern ArrayList ArrayListConstruct(ArrayListPosition place, int[] objects);
        [DllImport("palibrary")]
        private static extern void ArrayListRuin(ArrayListPosition place, int[] objects);
        [DllImport("palibrary")]
        private static extern ArrayList ArrayListInit(ArrayList List);
        [DllImport("palibrary")]
        private static extern void ArrayListDelete();
        // [StructLayout(LayoutKind.Sequential)]
        // private struct ArrayList List;
        // private int[] objects;
    }
}