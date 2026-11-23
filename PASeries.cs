using System.Runtime.InteropServices;
// using System.Xml.Schema;
using System;
namespace PA
{
    public readonly partial struct PASeries
    {

        internal readonly PACount _m;
        internal readonly UIntPtr _adj;
        readonly PACount M => _m;
        readonly UIntPtr Adj => _adj;

        // public readonly unsafe PAElement* Adj;
        // {
        //     // get
        //     // {
        //     //     return ref _adj;  
        //     // } 
        // }

        public unsafe UIntPtr this[PAElement node]
        {
            get
            {
                UIntPtr start = _adj;
                PANumber number;
                number = PANumber.PANumberPerformConstruct();
                number = PANumber.PANumberPerformInit(number,1);
                PACount count;
                count = PACount.PACountPerformConstruct();
                count = PACount.PACountPerformInit(count,number);
                void* auxPtr;
                PAElement* elementPtr;
                PAElement element;
                while (count < _m)
                {
                    start = _adj;
                    start += (uint)Marshal.SizeOf<PAElement>();
                    auxPtr = start.ToPointer();
                    elementPtr = (PAElement*) auxPtr;
                    element = *elementPtr;
                    if (node == element)
                    {
                        return _adj;
                    }
                }
                return UIntPtr.Zero;
                // int iteration = 1;
                // PAElement* curr;
                // curr = _adj;
                // while (iteration < (int)_m)
                // {
                //     if (curr == null)
                //     {
                //         break;
                //     }
                //     if (node == (*curr))
                //     {
                //         return (*curr);
                //     }
                //     else
                //     {
                //         // curr = _adj->;
                //         iteration++;
                //     }
                // }
                // return (*curr);
                // return _adj[node];
                // PAElement element = PAElement.PAElementPerformConstruct();
                // return element;
                // return _array[node];
                //get element at position node
            }
        }

        // internal unsafe readonly PAElement* _adj;

        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformConstruct();
        [LibraryImport("pa")]
        public static unsafe partial PASeries PASeriesPerformInit(PASeries series, PACount m, PAElement* adj);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformCopy(PASeries from, PASeries to);
        [LibraryImport("pa")]
        public static partial void PASeriesPerformPrint(PASeries series);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformRuin(PASeries pa);
        [LibraryImport("pa")]
        public static partial PASeries PASeriesPerformDelete(PASeries pa);

        [LibraryImport("pa")]
        public static partial int PASeriesOperatorEqual(PASeries one, PASeries other);

        [LibraryImport("pa")]
        public static partial int PASeriesOperatorNotEqual(PASeries one, PASeries other);


        public static bool operator ==(PASeries one, PASeries other) => (PASeriesOperatorEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;
        public static bool operator !=(PASeries one, PASeries other) => (PASeriesOperatorNotEqual(one,other) == PA.PARESULT_SUCCESS) ? true : false;

    }
}
// }
