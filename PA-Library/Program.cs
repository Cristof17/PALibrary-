//@Author Cristofor Rotsching
using System;

//Console.WriteLine("Hello world!");

namespace PA_Library
{
    //class YourClass
    //{
    //}
    //public struct Algorithm
    //{
    //    public Algorithm(Input Input, Output output)
    //    {
    //        INPUT = Input;
    //        OUTPUT = output;
    //    }

    //    public Input INPUT { get; }
    //    public Output OUTPUT { get; }

    //    public override string ToString() => $"({INPUT}, {OUTPUT})";
    //}
    ////struct Algorithm
    ////{
    ////    Input Input;
    ////    Output output;
    ////}


    ////struct Edge
    ////{
    ////    Node Node;
    ////    Node Neigh;
    ////}
    //public readonly struct Edge
    //{
    //    public Edge(Node Node, Node Neigh)
    //    {
    //        NODE = Node;
    //        NEIGH = Neigh;
    //    }

    //    public Node NODE { get; }
    //    public Node NEIGH { get; }

    //    public override string ToString() => $"({NODE}, {NEIGH})";
    //}

    //public readonly struct Node
    //{
    //    public Node(int value)
    //    {
    //        VALUE = value;
    //    }

    //    public int VALUE { get; }

    //    public override string ToString() => $"({VALUE});
    //}

    //public readonly struct Output
    //{
    //    public Output(ArrayList d)
    //    {
    //        D = d;
    //    }

    //    public ArrayList D { get; }

    //    public override string ToString() => $"({D})";
    //}

    //public readonly struct Input
    //{
    //    public Input(Node Source, ArrayList[] Adj, int N, int M)
    //    {
    //        SOURCE = Source;
    //        ADJ = Adj;
    //        N = N;
    //        M = M;
    //    }

    //    public Node SOURCE { get; }
    //    public ArrayList[] ADJ { get; }
    //    public int N { get; }
    //    public int M { get; }

    //    public override string ToString() => $"({SOURCE}, {ADJ}, {N}, {M})");
    //}

    //struct Input
    //{
    //    Node Source;
    //    ArrayList[] Adj;
    //    int N;
    //    int M;
    //}

    //struct Node
    //{
    //    int value;
    //    //Output output;
    //}

    //struct Output
    //{
    //    ArrayList d;
    //    //Output output;
    //}
    class Program<T> where T : new()
    {
        public const String INPUT_FILE = "in";
        public const String OUTPUT_FILE = "out";

        static void Main(string[] args)
        {
            ReadInput(INPUT_FILE);
            WriteOutput(GetResults(), OUTPUT_FILE);
            Console.WriteLine("Hello world!");
        }

        public static void ReadInput(String path)
        {
            Console.WriteLine(path);
        }
        public static void WriteOutput(Output o, String path)
        {
            Console.WriteLine(path);
        }
        public static Output GetResults()
        {
            return new Output();
            //Console.WriteLine(message);
        }
    }
    //interface IYourInterface
    //{
    //}

    //delegate int YourDelegate();
    //s
    //enum YourEnum
    //{
    //}

    //namespace YourNestedNamespace
    //{
    //    struct YourStruct
    //    {
    //    }
    //}
}
