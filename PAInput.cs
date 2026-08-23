using System.Runtime.InteropServices;
using System;
using AL;

namespace PA
{
    [StructLayout(LayoutKind.Sequential)]
    partial struct PAInput
    {

        PACount N;

        PACount M;

        PAList Adj;

        PAElement Sursa;
        // _sursa;

        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformConstruct();
        [LibraryImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        internal static partial PAInput PAInputPerformInit(PAInput input, PACount count, PAElement element);
        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformCopy(PAInput from, PAInput to);
        [LibraryImport("pa")]
        internal static partial void PAInputRuin(PAInput pa);
        [LibraryImport("pa")]
        internal static partial PAInput PAInputPerformDelete(PAInput pa);

    }
}
