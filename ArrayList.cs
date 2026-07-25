using PA_Library;
// using System;
using System.Runtime.InteropServices;
// using System;
namespace AL
{
    [StructLayout(LayoutKind.Sequential)]
    public struct ArrayList
    {
        [LibraryImport("pa")]
        public static extern ArrayList ArrayListConstruct(ArrayListPosition place, int[] objects);
        [LibraryImport("pa")]
        public static extern void ArrayListRuin(ArrayListPosition place, int[] objects);
        [LibraryImport("pa")]
        public static extern ArrayList ArrayListInit(ArrayList List);
        [LibraryImport("pa")]
        public static extern void ArrayListDelete();
        // [StructLayout(LayoutKind.Sequential)]
        // private struct ArrayList List;
        // int[] objects;
    }
}