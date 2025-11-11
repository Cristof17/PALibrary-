namespace PA_Library
{
	public readonly ref struct BFSResult
    {
        [MarshalAs(UnmanagedType.IDispatch)]
        PALista d;
        [MarshalAs(UnmanagedType.IDispatch)]
        PACardinal n;
        [MarshalAs(UnmanagedType.IDispatch)]
        BFSResult result;

        public void Dispose()
        {
            
        }

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

        //public PALista d { get; }
        public PALista d { get; }
		public PACardinal n { get; }
		public BFSResult result { get; }
	}
}