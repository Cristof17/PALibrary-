using System.Runtime.InteropServices;
using System;
using PA;
using AL;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct PAInput
    {

        internal PACount N;

        internal PACount M;

        internal PAList Adj;

        internal PAElement Sursa;
        // _sursa;

        [LibraryImport("pa")]
        public static partial PAInput PAInputPerformConstruct();
        [LibraryImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        public static partial PAInput PAInputPerformInit(PAInput input, PACount count, PAElement element);
        [LibraryImport("pa")]
        public static partial PAInput PAInputPerformCopy(PAInput from, PAInput to);
        [LibraryImport("pa")]
        public static partial void PAInputRuin(PAInput pa);
        [LibraryImport("pa")]
        public static partial PAInput PAInputPerformDelete(PAInput pa);

    }
}
