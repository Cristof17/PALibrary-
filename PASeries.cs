using System.Runtime.InteropServices;
// using System.Xml.Schema;
using PA;
using AL;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Dynamic;
using System.Diagnostics.CodeAnalysis;
namespace PA
{
    public readonly partial struct PASeries
    {
        public readonly PACount M
        {
            get
            {
                return _m;
            }
        }

        // public readonly unsafe PAElement* Adj;
        // {
        //     // get
        //     // {
        //     //     return ref _adj;  
        //     // } 
        // }

        public unsafe PAElement this[PAElement node]
        {
            get
            {
                int iteration = 1;
                PAElement* curr;
                curr = _adj;
                while (iteration < _m)
                {
                    if (curr == null)
                    {
                        break;
                    }
                    if (node == (*curr))
                    {
                        return (*curr);
                    }
                    else
                    {
                        curr = _adj->_next;
                        iteration++;
                    }
                }
                return (*curr);
                // return _adj[node];
                // PAElement element = PAElement.PAElementPerformConstruct();
                // return element;
                // return _array[node];
                //get element at position node
            }
        }

        internal readonly PACount _m;

        internal unsafe readonly PAElement* _adj;

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

        public static unsafe bool operator ==(PASeries one, PASeries other) => (one._m == other._m) && ((*one._adj) == (*other._adj));
        public static unsafe bool operator !=(PASeries one, PASeries other) => (one._m != other._m) || ((*one._adj) != (*other._adj));

        public override bool Equals([NotNullWhen(true)] object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
// }
