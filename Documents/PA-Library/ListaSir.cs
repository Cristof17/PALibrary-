using System;
namespace PA_Library
{
    public class ListaSir
    {
        [DllImport("pa-library")]
        public static extern ArrayListConstruct();
        [DllImport("pa-library")]
        public static extern ArrayListRuin();
        [DllImport("pa-library")]
        public static extern ArrayListInit();
        [DllImport("pa-library")]
        public static extern ArrayListDelete();
        [StructLayout(LayoutKind.Sequential)]
        private struct ArrayList List;
        // int[] objects;
    }
}