using System.Runtime.InteropServices;
using System;
using PA;
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
        static partial PAInput PAInputPerformConstruct();
        [LibraryImport("pa")]
        // static extern Input InputPerformInit(PAInput imPACount Count, PACount Count2, PAElement Element);
        static partial PAInput PAInputPerformInit(PAInput input, PACount count, PAElement element);
        [LibraryImport("pa")]
        static partial PAInput PAInputPerformCopy(PAInput from, PAInput to);
        [LibraryImport("pa")]
        static partial void PAInputRuin(PAInput pa);
        [LibraryImport("pa")]
        static partial PAInput PAInputPerformDelete(PAInput pa);

    }
}
