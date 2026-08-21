using System;
using System.Runtime.InteropServices;
using PA;
namespace PA
{
    public readonly partial struct PAList
    {
        public readonly PACount N
        {
            get
            {
                return _n;
            }
        } 

        public readonly PASeries Adj
        {
            get
            {
                return _adj; 
            }
        }

        public PAElement this[PAElement node]
        {
            get
            {
                return _adj[node];
            }
        }

        internal readonly PACount _n;

        internal readonly PASeries _adj;

        [LibraryImport("pa")]
        public static partial PAList PAListPerformConstruct();
        [LibraryImport("pa")]
        public static partial PAList PAListPerformInit(PAList list, PACount n, PASeries adj);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformCopy(PAList from, PAList to);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformRuin(PAList PA);
        [LibraryImport("pa")]
        public static partial PAList PAListPerformDelete(PAList PA);
        [LibraryImport("pa")]
        public static partial void PAListPerformPrint(PAList List);
    }
}
