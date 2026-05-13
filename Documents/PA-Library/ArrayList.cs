using PA_Library;
using System;
using System.Runtime.InteropServices;
using System;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ArrayList
    {
        // [DllImport("palibrary")]
        public static extern ArrayList ArrayListConstruct(ArrayListPosition place, int[] objects);
        [DllImport("palibrary")]
        public static extern void ArrayListRuin(ArrayListPosition place, int[] objects);
        [DllImport("palibrary")]
        public static extern ArrayList ArrayListInit(ArrayList List);
        [DllImport("palibrary")]
        public static extern void ArrayListDelete();
        // [StructLayout(LayoutKind.Sequential)]
        // private struct ArrayList List;
        // int[] objects;
    }
}