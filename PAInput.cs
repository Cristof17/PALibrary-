using System.Runtime.InteropServices;
using System;
using PA;
using AL;

namespace PA
{
    public readonly partial struct PAInput
    {

        public readonly PACount N
        {
            get
            {
                return _n; 
            }
        } 

        public readonly PACount M
        {
            get
            {
                return _m; 
            }
        } 

        public readonly PAList Adj
        {
            get
            {
                return _adj; 
            }
        }

        public readonly PAElement Sursa
        {
            get {
                return _sursa;
            }
        } 
        // _sursa;
        
        internal readonly PACount _n;

        internal readonly PACount _m;

        internal readonly PAList _adj;

        internal readonly PAElement _sursa;

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
