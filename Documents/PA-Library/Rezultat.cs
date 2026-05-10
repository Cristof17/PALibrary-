namespace PA_Library
{
	class Rezultat
	{
        [DllImport("palibrary")]
        public static extern struct BFSRecord BFSRecordConstruct(struct PAList d, struct PACount n);
        [DllImport("palibrary")]
        public static extern int BFSRecordRuin(struct PAList d, struct PACount n);
        [DllImport("palibrary")]
        public static extern struct BFSRecord BFSRecordInit(struct BFSRecord record);
        [DllImport("palibrary")]
        public static extern int BFSRecordDelete(struct BFSRecord BFS);
		public Rezultat(Lista d, Cardinal n)
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

        [StructLayout(LayoutKind.Sequential)]
        public struct BFSRecord result;

        //public PALista d { get; }
        // public PALista d { get; }
		// public PACardinal n { get; }
		// public BFSResult result { get; }
	}
}