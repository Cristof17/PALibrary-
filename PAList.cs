using System;
using System.Runtime.InteropServices;
namespace PA
{
    public readonly partial struct PAList
    {
        readonly PACount N { get {return _N;}}

        readonly UIntPtr Adj { get { return _Adj;}}

        internal readonly PACount _N;

        internal readonly UIntPtr _Adj;

        [LibraryImport("pa")]
        public static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAList PAListPerformInit(PAList list, PACount n, in PASeries adj);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformCopy(PAList from, PAList to);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformDelete(PAList PA);

        [LibraryImport("pa")]
        public static partial int PAListOperatorEqual(PAList one, PAList other);

        [LibraryImport("pa")]
        public static partial int PAListOperatorNotEqual(PAList one, PAList other);

        public unsafe UIntPtr this[PAElement element]
        {
            get
            {
                UIntPtr aux = _Adj;
                PANumber number;
                PACount count;
                number = PANumber.PANumberPerformConstruct();
                number = PANumber.PANumberPerformInit(number,1);
                count = PACount.PACountPerformConstruct();
                count = PACount.PACountPerformInit(count,number);
                void* auxPtr;
                PASeries* seriesPtr;
                PASeries series;
                while (count < _N)
                {
                    aux += (uint)Marshal.SizeOf<PASeries>();
                    auxPtr = aux.ToPointer();
                    seriesPtr = (PASeries*) aux;
                    series = *seriesPtr;
                    UIntPtr adj_node = series[element];
                    if (adj_node == UIntPtr.Zero)
                    {
                        
                    }
                    else
                    {
                        return adj_node;
                    }
                }
                // return PA
                return UIntPtr.Zero;
                // return PAElement.PAElementPerformConstruct();
                // return Adj[element];
            }
        }
        [LibraryImport("pa")]
        public static partial void PAListPerformPrint(PAList List);

        public static bool operator==(PAList one, PAList other) => (PAListOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator!=(PAList one, PAList other) => (PAListOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
    }
}
