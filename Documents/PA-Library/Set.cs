 using System;

namespace PA_Library
{
    public readonly struct Set
    {
        //public Set(Node Source, ArrayList[] Adj, int N, int M)
// 
        // public Multime(int N) : this()
        public Set(int N) : this()
        {
            N = N;
            //ADJ = Adj;
            //N = N;
            //M = M;
        }

        public int N { get; }
        //public int N = ;
        //public ArrayList[] ADJ { get; }
        //public int N { get; }
        //public int M { get; }

        public override string ToString() => $"({N})";
    }
}
