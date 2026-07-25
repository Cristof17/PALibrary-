using PA_Library;
// using System;
using System.Runtime.InteropServices;
// using System;
namespace AL
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct ArrayList
    {
        [LibraryImport("pa")]
        internal static partial ArrayList ArrayListConstruct(ArrayListPosition place, int[] objects);
        [LibraryImport("pa")]
        internal static partial void ArrayListRuin(ArrayListPosition place, int[] objects);
        [LibraryImport("pa")]
        internal static partial ArrayList ArrayListInit(ArrayList List);
        [LibraryImport("pa")]
        internal static partial void ArrayListDelete();
        // [StructLayout(LayoutKind.Sequential)]
        // private struct ArrayList List;
        // int[] objects;
    }
}