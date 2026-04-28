namespace PA_Library
{
	class BFSResult
	{
        [DllImport("palibrary.dll")]
        public static extern void BFSRecordConstruct();
        [DllImport("palibrary.dll")]
        public static extern void BFSRecordRuin();
        [DllImport("palibrary.dll")]
        public static extern void BFSRecordInit();
        [DllImport("palibrary.dll")]
        public static extern void BFSRecordDelete();
		public BFSResult(BFSResult Rezultat)
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
        public struct BFSRecord RESULT;
        //public PALista d { get; }
        // public PALista d { get; }
		// public PACardinal n { get; }
		// public BFSResult result { get; }
	}
}