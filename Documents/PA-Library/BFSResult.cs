namespace PA_Library
{
	class BFSResult
	{
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