using System;
namespace PA_Library
{
    public class ListaSir
    {
        [DllImport("pa-library")]
        public static extern struct ArrayList ArrayListConstruct(struct ArrayListPosition place, int[] objects);
        [DllImport("pa-library")]
        public static extern void ArrayListRuin(struct ArrayListPosition place, int[] objects);
        [DllImport("pa-library")]
        public static extern struct ArrayList ArrayListInit(struct ArrayList List);
        [DllImport("pa-library")]
        public static extern void ArrayListDelete();
        [StructLayout(LayoutKind.Sequential)]
        private struct ArrayList List;
        // int[] objects;
    }
}