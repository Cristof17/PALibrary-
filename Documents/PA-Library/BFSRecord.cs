using PA_Library;
using System;
using System.Runtime.InteropServices;
namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
	struct BFSRecord
	{
        [DllImport("palibrary")]
        public static extern  BFSRecord BFSRecordConstruct(PAList d,  PACount n);
        [DllImport("palibrary")]
        public static extern int BFSRecordRuin(PAList d, PACount n);
        [DllImport("palibrary")]
        public static extern  BFSRecord BFSRecordInit(BFSRecord record);
        [DllImport("palibrary")]
        public static extern int BFSRecordDelete(BFSRecord BFS);
        public Rezultat(PASeries d, PACount n)
		// public Rezultat(Lista d, Cardinal n)
		{
			this.d = Rezultat.d;
			this.n = Rezultat.n;
		}
        public int this[int index]
        {
            get
            {
                return (int)d[index];
            }
            set
            {
                d[index] = (PANod) value;
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