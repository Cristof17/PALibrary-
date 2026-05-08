namespace PA_Library
{
	class Rezultat
	{
        [DllImport("palibrary")]
        public static extern void BFSRecordConstruct();
        [DllImport("palibrary")]
        public static extern void BFSRecordRuin();
        [DllImport("palibrary")]
        public static extern void BFSRecordInit();
        [DllImport("palibrary")]
        public static extern void BFSRecordDelete();
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