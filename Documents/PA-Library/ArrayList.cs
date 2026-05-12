using System;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequntial)]
    public struct ArrayList
    {
        [DllImport("palibrary")]
        public static extern struct ArrayList ArrayListConstruct(struct ArrayListPosition place, int[] objects);
        [DllImport("palibrary")]
        public static extern void ArrayListRuin(struct ArrayListPosition place, int[] objects);
        [DllImport("palibrary")]
        public static extern struct ArrayList ArrayListInit(struct ArrayList List);
        [DllImport("palibrary")]
        public static extern void ArrayListDelete();
        // [StructLayout(LayoutKind.Sequential)]
        // private struct ArrayList List;
        // int[] objects;
    }
}