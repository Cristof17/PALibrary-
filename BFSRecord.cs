using PA_Library;
// using System;
using PA;
using System.Runtime.InteropServices;
namespace BFS
{
    [StructLayout(LayoutKind.Sequential)]
	public partial struct BFSRecord
	{
        private  PAList d;
        private PACount n;

        [LibraryImport("pa")]
        internal static partial BFSRecord BFSRecordConstruct(PAList d,  PACount n);
        [LibraryImport("pa")]
        internal static partial int BFSRecordRuin(PAList d, PACount n);
        [LibraryImport("pa")]
        internal static partial  BFSRecord BFSRecordInit(BFSRecord record);
        [LibraryImport("pa")]
        internal static partial int BFSRecordDelete(BFSRecord BFS);
        // public Rezultat(PASeries d, PACount n)
        public BFSRecord(PASeries d, PACount n) : this()
		// public Rezultat(Lista d, Cardinal n)
		{
			// this.d = Rezultat.d;
			// this.n = Rezultat.n;
		}
        public int this[int index]
        {
            get
            {
                return 0;
                // return (int)d[index];
            }
            set
            {
                
                // d[index] = (PANod) value;
            }
        }

        // [StructLayout(LayoutKind.Sequential)]
        // public struct BFSRecord result;

        //public PALista d { get; }
        // public PALista d { get; }
		// public PACardinal n { get; }
		// public BFSResult result { get; }
	}
}