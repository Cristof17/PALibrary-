// using System;
using System.Runtime.InteropServices;
//using System.Collections.Generic;
//using System.Text;
//using System.Collections;

//namespace PA_Library
//{
//    class Input<T>
//    {
//        protected internal T N;
//        protected internal T M;
//        protected internal ArrayList[] Adj;
//    }
//
//}
//using System;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Xml.Linq;

//Console.WriteLine("Hello world!");

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Input
    {
        private PACount n;
        private PACount m;
        private PAList adj; 
        private PAElement sursa;

        [DllImport("pa")]
        public static extern void InputConstruct();
        [DllImport("pa")]
        public static extern void InputRuin();
        [DllImport("pa")]
        public static extern void InputInit();
        [DllImport("pa")]
        public static extern void Dispose();
        [DllImport("pa")]
        public static extern void InputDelete();
        public Input(int Source, ArrayList[] Adj, int N, int M) : this()
        {
            //ADJ = default(AdjacencyList<Node>);
            // this.N = default;
            // this.M = default;
            // ADJ = default;
            // SOURCE = default;
            // SOURCE = new Node(Source);
            // int Success = 0;
            // int Fail = -1;
            // int Result = Success;
            // Result = CheckSource(Source, Adj,N,M);
            // if (Result == Fail)
            // {
            //     //SOURCE = default;
            //     //Console.Error.WriteLine("Source error");
            // }
            // else if (Result == Success)
            // {
            //     SOURCE = new Node(Source);
            // }
            // Result = CheckNodeCardinal(Source, Adj, N,M);
            // if (Result == Fail)
            // {
            //     //N = default;
            //     //Console.Error.WriteLine("N error");
            // }
            // else if (Result == Success)
            // {
            //     N = CopyNodeCardinal(Source, Adj, N, M);
            // }
            // Result = CheckReferenceVector(Source, Adj, N,M);
            // if (Result == Success)
            // {
            //     ADJ = CopyVector(Source, Adj, N, M);//Adj;
            // }
            // else if (Result == Fail)
            // {
            //     //Console.Error.WriteLine("Adj error");
            // }
            // Result = CheckEdgeCardinal(Source, Adj, N, M);
            // if (Result == Success)
            // {
            //     M = CopyEdgeCardinal(Source, Adj, N, M);
            //     //M = M;
            // }
            // else if (Result == Fail)
            // {
            //     //Console.Error.WriteLine("M error");
            // }
        }
            //Result = CheckEdgeCardinal(Source, Adj, N, M);
            //if (Result == Success)
            //{
            //    M = CopyEdgeCardinal(Source, Adj, N, M);
            //    //int Node = 1;
            //    //while (Node < N)
            //    //{
            //}
            //else if (Result == Fail)
            //{
            //    //int Node = 1;
            //    ADJ = default;
            //}
                //    ADJ[Node] = Adj[Node];
                //    Node++;
                //}
                //int Node = 1;
                //while (Node < N)
                //{
                //    ADJ[Node] = Adj[Node];
                //    Node++;
                //}
            //N = new Cardinal(N);
            //Result = check(Adj);
            //if (Result == Fail)
            //{
            //    Console.Error.WriteLine("N error");
            //    ADJ = default;
            //}
            //else
            //{
            //    Adj = copy(Adj, N);
            //    //ADJ = new AdjacencyList(Adj,N);
            //}
            //Result = check(M);
            //if (Result == Fail)
            //{
            //    Console.Error.WriteLine("M error");
            //    M = default;
            //}
            //else
            //{
            //    M = copy(M);
            //    //new Cardinal(M);
            //}
           
            //if (Source == null)
            //{
            //    SOURCE = default;
            //Console.Error.WriteLine("Source == null");
            //}
            //else if (Source != null)
            //{
            //new Node<T>(Source);
            //}
            //N = new Cardinal(N);
            //M = new Cardinal(M);
            //else if (Source != null)
            //{
            //}
            //if (Source < 0)
            // {
            //   Console.Error.WriteLine("Source < 0");
            //    SOURCE = new Node(Source);
            //Console.WriteLine("Source < 0");
            // }
            //else if (Source == 0)
            //{
            //    Console.Error.WriteLine("Source == 0");
            //    SOURCE = new Node(Source);
            //}
            //else if (Source > 0)
            //{
            //    SOURCE = new Node(Source);
            //}
            //ADJ = initArray(Source,N,N + 2);
            //DJ = allocArray(Source, N, ADJ);
            //N = nw
            //<
            //int i = default(int);
            //int j = default(int);
            //i = 1;
            //j = (i + 1);
            //if (N < 0)
            //{
            //    Console.Error.WriteLine("N < 0");
            //}
            //else if (N == 0)
            //{
            //    Console.Error.WriteLine(@"N == 0");
            //}
            //else
            //{
            //    if (N > 0)
            //    {
            //        ADJ = new AdjacencyList[N+2];
            //        while (i <= N)
            //        {
            //            ADJ[i] = new AdjacencyList(Adj[i]);
            //            i = j;
            //            j = (i + 1);
            //        }
            //        M = new Cardinal(M);
            //        N = new Cardinal(N);
            //    }
            //}
      
        //public ArrayList[] copy(ArrayList[] Adj, int N)
        //{
        //    ArrayList[] copy;
        //    copy = new ArrayList[N];
        //    return copy;
        //}

        // // public int CheckVector(int Node, ArrayList[] Adj, int N, int M)
        // // {
        // //     int Success = 0;
        // //     int Fail = -1;
        // //     int Result = Success;
        // //     //int Node = 1;
        // //     if (Result == Fail)
        // //     {
        // //         Result = Fail;
        // //         //Console.Error.WriteLine("Adj == null");
        // //         return Result;
        // //     }
        // //     else if (Result == Success)
        // //     {
        // //         while (Node < N)
        // //         {
        // //             Result = CheckReferenceArrayList(Node,Adj,N,M);
        // //             if (Result == Success)
        // //             {
        // //                 Result = CheckArrayList(Node, Adj, N, M);
        // //                 Node++;
        // //             }
        // //             else if (Result == Fail)
        // //             {
        // //                 //Console.Error.WriteLine($"Adj{Node} error");
        // //                 return Result;
        // //             }
        // //             //else if (Result == Success)
        // //             //{
        // //             //}
        // //         }
        // //     }
        // //         //if (Result == Success)
        //         //{
        //         //    //Node++;
        //         //    Result = Success;
        //         //}
        //         //else
        //         //{
        //         //    return Result;
        //         //    //Node++;
        //         //    //Result = Fail;
        //         //}
        //         //Node++;
        //     //}
        //     return Result;
        // }

        //check_reference

        // public ArrayList[] CopyVector(int Source,ArrayList[] Adj, int N, int M)
        // {
        //     //ArrayList[] Result;
        //     ArrayList[] Result = new ArrayList[N];
        //     int Node = 1;
        //     //int Result;
        //     //int Success = 0;
        //     //int Fail = -1;
        //     //Result = new ArrayList[N];
        //     //Node = 1;
        //     //int M = Adj[x].Capacity;
        //     while (Node < N)
        //     {

        //         int Count = Size(Source,Adj,N,M);
        //         Result[Node] = CopyArrayList(Source,Adj,N,M);
        //         Node++;
        //         //Result[x] = copy(Adj[x], M);
        //     }
        //     return Result;
        // }
        // public int CheckReferenceVector(int Source, ArrayList[] Adj, int N, int M)
        // {
        //     int Result;
        //     int Success = 0;
        //     int Fail = -1;
        //     //int Neigh = 1;
        //     if (Adj == null)
        //     {
        //         //Console.Error.WriteLine($"Adj == null");
        //         Result = Fail;
        //         return Result;
        //     }
        //     else
        //     {
        //         Result = Success;
        //         Result =CheckVector(Source, Adj, N, M);
        //     }
        //     return Result;
        // }

        // public int CheckReferenceArrayList(int Source, ArrayList[] Adj, int N, int M)
        // {
        //     int Result;
        //     int Success = 0;
        //     int Fail = -1;
        //     //int Neigh = 1;
        //     if (Adj[Source] == null)
        //     {
        //         //Console.Error.WriteLine($"Adj[{Source} == null");
        //         Result = Fail;
        //         return Result;
        //     }
        //     else
        //     {
        //         Result = Success;
        //         //Result = CheckArrayList(Source, Adj, N, M);
        //     }
        //     return Result;
        // }

        // public int CheckArrayList(int Source, ArrayList[] Adj, int N, int M)
        // {
        //     int Result;
        //     int Success = 0;
        //     int Fail = -1;
        //     Result = CheckReferenceArrayList(Source, Adj, N, M);
        //     if (Result == Success)
        //     {
        //         M = Size(Source, Adj, N, M);
        //         int Neigh = 1;
        //         while (Neigh < M)
        //         {
        //             Result = CheckEdge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
        //             if (Result == Fail)
        //             {
        //                 //Console.Error.WriteLine("Adj[Neigh] error");
        //                 return Result;
        //             }
        //             else if (Result == Success)
        //             {
        //                 Neigh++;
        //             }
        //         }
        //     }
        //     else if (Result == Fail)
        //     {
        //         //Console.Error.WriteLine($"Adj[{Source}] == null");
        //         Result = Fail;
        //         return Result;
        //     }
        //     return Result;
        //     //else if (Result == Fail)
        //     //{
        //     //    Console.Error.WriteLine("reference error");
        //     //}
        //     ////}
        //     //Result = Fail;
        //     //Neigh++;
        //     //Result = Success;
        //     //return Result;
        //     //return Result;
        // }

        //public int CheckReferenceVector(int Source, ArrayList[] Adj, int N, int M)
        //{
        //    int Result;
        //    int Success = 0;
        //    int Fail = -1;
        //    int Neigh = 1;
        //    Result = check_reference_array_list(Source, Adj, N, M);
        //    if (Result == Success)
        //    {
        //    }
        //    else if (Result == Fail)
        //    {
        //        Console.Error.WriteLine($"Adj[{Source}] == null");
        //        Result = Fail;
        //        return Result;
        //    }
        //    M = size(Source, Adj, N, M);
        //    while (Neigh < M)
        //    {
        //        Result = check_edge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
        //        if (Result == Fail)
        //        {
        //            Console.Error.WriteLine("Adj[Neigh] error");
        //            return Result;
        //        }
        //        else if (Result == Success)
        //        {
        //            Neigh++;
        //        }
        //    }
        //    return Result;
        //    //else if (Result == Fail)
        //    //{
        //    //    Console.Error.WriteLine("reference error");
        //    //}
        //    ////}
        //    //Result = Fail;
        //    //Neigh++;
        //    //Result = Success;
        //    //return Result;
        //    //return Result;
        //}

        //        while (Neigh < M)
        //        {
        //            Result = check_edge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
        //            if (Result == Fail)
        //            {
        //                Console.Error.WriteLine("Adj[Neigh] error");
        //                return Result;
        //            }
        //            else
        //            {
        //                Neigh++;
        //            }
        //        }
        //    //Result = Fail;
        //    //Neigh++;
        //    Result = Success;
        //    return Result;
        //    //return Result;
        //}
        //public int CheckArrayList(int Source, ArrayList[] Adj, int N, int M)
        //{
        //    int Result;
        //    int Success = 0;
        //    int Fail = -1;
        //    int Neigh = 1;
        //    while (Neigh < M)
        //    {
        //        Result = check_reference(Source, Adj, N, M);
        //        if (Result == Success)
        //        {
        //            Result = check_edge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
        //            if (Result == Fail)
        //            {
        //                Console.Error.WriteLine("Adj[Neigh] error");
        //                return Result;
        //            }
        //            else
        //            {
        //                Neigh++;
        //            }
        //        }
        //        else if (Result == Fail)
        //        {
        //            Console.Error.WriteLine("reference error");
        //        }
        //    }
        //            //Result = Fail;
        //            //Neigh++;
        //    Result = Success;
        //    return Result;
        //    //return Result;
        //}

        // public int Size(int Source, ArrayList[] Adj, int N, int M)
        // {
        //     int size = 0;
        //     size = Adj[Source].Capacity;
        //     return size;
        // }

        //public ArrayList[] copy_vector(int Source, ArrayList[] Adj, int N, int M)
        //{
        //    ArrayList[] Result = new ArrayList[N];
        //    int Node = 1;
        //    while (Node < N)
        //    {
        //        int count = size(Node, Adj, N, M);
        //        Result[Node] = copy_array_list(Source, Adj, N, count);
        //        Node++;
        //}

        // public ArrayList CopyArrayList(int Source, ArrayList[] Adj,int N, int M)
        // {
        //     ArrayList Result = new ArrayList(M);
        //     int Neigh = 1;
        //     while (Neigh < M)
        //     {
        //         Result[Neigh] = CopyEdge(Source, Neigh, Adj, N, M);
        //         Neigh++;
        //     }
        //     return Result;
        // }

    //     public int CopyEdge(int Node, int Neigh, ArrayList[] Adj, int N, int M)
    //     {
    //         int Success = 0;
    //         int Fail = -1;
    //         int Result = Success;
    //         Result = (int) Adj[Node][Neigh];
    //         return Result;
    //     }
    //     public ArrayList Copy(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         ArrayList Result = new ArrayList(M);
    //         int Neigh = 1;
    //         while (Neigh < M)
    //         {
    //             Result[Neigh] = Copy(Source,Neigh,Adj,N,M);
    //             Neigh++;
    //         }
    //         return Result;
    //     }

    //     public int Copy(int Node, int Neigh, ArrayList[] Adj, int N, int M)
    //     {
    //         int Copy;
    //         Copy = (int)Adj[Node][Neigh];
    //         return Copy;
    //     }
    //     public int CheckSource(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         int Success = 0;
    //         int Fail = -1;
    //         int Result = Success;
    //         if (Source < 0)
    //         {
    //             Result = Fail;
    //             Console.Error.WriteLine($"{Source} < 0");
    //             //Result = Success;
    //             //resul
    //         }
    //         else if (Source == 0)
    //         {
    //             Result = Fail;
    //             Console.Error.WriteLine($"{Source} == 0");
    //         }
    //         else if (Source > 0)
    //         {
    //             Result = Success;
    //         }
    //         return Result;
    //     }


    //     public int CheckEdge(int Node, int Neigh, ArrayList[] Adj, int N, int M)
    //     {
    //         int Success = 0;
    //         int Fail = -1;
    //         int Result = Success;
    //         int Edge = (int) Adj[Node][Neigh];
    //         if (Edge < 0)
    //         {
    //             Console.Error.WriteLine($"{Edge} < 0");
    //             Result = Fail;
    //         }
    //         else if (Edge == 0)
    //         {
    //             Console.Error.WriteLine($"{Edge} == 0");
    //             Result = Fail;
    //         }
    //         else if (Edge > 0)
    //         {
    //             Result = Success;
    //         }
    //         return Result;
    //     }

    //     public int Check(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         int Success = 0;
    //         int Fail = -1;
    //         int Result = Success;
    //         if (Adj == null)
    //         {
    //             Console.Error.WriteLine($"{Adj} == null");
    //             Result = Fail;
    //             return Result;
    //         }
    //         else
    //         {
    //             Result = CheckVector(Source, Adj, N, M);
    //         }
    //         return Result;
    //     }

    //     public int CheckNodeCardinal(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         int Success = 0;
    //         int Fail = -1;
    //         int Result = Success;
    //         //nt32 edge = (int)Adj[Node][Neigh];
    //         if (N < 0)
    //         {
    //             Console.Error.WriteLine($"{N} < 0");
    //             Result = Fail;
    //         }
    //         else if (N == 0)
    //         {
    //             Console.Error.WriteLine($"{N} == 0");
    //             Result = Fail;
    //         }
    //         else if (N > 0)
    //         {
    //             Result = Success;
    //         }
    //         return Result;
    //     }

    //     public int CheckEdgeCardinal(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         int Success = 0;
    //         int Fail = -1;
    //         int Result = Success;
    //         //nt32 edge = (int)Adj[Node][Neigh];
    //         if (N < 0)
    //         {
    //             Console.Error.WriteLine($"{N} < 0");
    //             Result = Fail;
    //         }
    //         else if (N == 0)
    //         {
    //             Console.Error.WriteLine($"{N} == 0");
    //             Result = Fail;
    //         }
    //         else if (N > 0)
    //         {
    //             Result = Success;
    //         }
    //         return Result;
    //     }


    //     public int CopyNodeCardinal(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         int Result = 0;
    //         Result = N;
    //         return Result;
    //         //int Fail = -1;
    //         //int Result = Success;
    //         ////nt32 edge = (int)Adj[Node][Neigh];
    //         //if (N < 0)
    //         //{
    //         //    Console.Error.WriteLine($"{N} < 0");
    //         //    Result = Fail;
    //         //}
    //         //else if (N == 0)
    //         //{
    //         //    Console.Error.WriteLine($"{N} == 0");
    //         //    Result = Fail;
    //         //}
    //         //else if (N > 0)
    //         //{
    //         //    Result = Success;
    //         //}
    //         //return Result;
    //     }

    //     public int CopyEdgeCardinal(int Source, ArrayList[] Adj, int N, int M)
    //     {
    //         int Result = 0;
    //         Result = M;
    //         return Result;
    //         //int Fail = -1;
    //         //int Result = Success;
    //         ////nt32 edge = (int)Adj[Node][Neigh];
    //         //if (N < 0)
    //         //{
    //         //    Console.Error.WriteLine($"{N} < 0");
    //         //    Result = Fail;
    //         //}
    //         //else if (N == 0)
    //         //{
    //         //    Console.Error.WriteLine($"{N} == 0");
    //         //    Result = Fail;
    //         //}
    //         //else if (N > 0)
    //         //{
    //         //    Result = Success;
    //         //}
    //         //return Result;
    //     }
    //     //public int check(int Node)
    //     //{
    //     //    int Result;
    //     //    int Success = 9;
    //     //    int Fail = -1;
    //     //    if (Node < 0)
    //     //    {
    //     //        Console.Error.WriteLine("Node < 9");
    //     //        Result = Fail;
    //     //    }
    //     //    else if (Node == 0)
    //     //    {
    //     //        Console.Error.WriteLine("Node == 0");
    //     //        Result = Fail;
    //     //    }
    //     //    else
    //     //    {
    //     //        Result = Success;
    //     //    }
    //     //    return Result;
    //     //}
    //     /*
    //     private AdjacencyList<Node> initArray(int x, int y, int N)
    //     {
    //         int i = default(int);
    //         int j = default(int);
    //         AdjacencyList<Node> Adj = default(AdjacencyList<Node>);
    //         if (x < 0)
    //         {
    //             Console.Error.WriteLine("x < 0");
    //         }
    //         else if (x == 0)
    //         {
    //             Console.Error.WriteLine("x == 0");
    //         }
    //         else if ((x > 0) && (x != 0))
    //         {
    //             if (y < 0)
    //             {
    //                 Console.Error.WriteLine("y < 0");
    //             }
    //             else if (y == 0)
    //             {
    //                 Console.Error.WriteLine("y == 0");
    //             }
    //             else if ((y > 0) && (y != 0))
    //             {
    //                 if (N < 0)
    //                 {
    //                     Console.Error.WriteLine("N < 0");
    //                 }
    //                 else if (N == 0)
    //                 {
    //                     Console.Error.WriteLine("N == 0");
    //                 }
    //                 else if ((N > 0) && (N != 0))
    //                 {
    //                     //Adj = new AdjacencyList[N + 2];
    //                     Adj = new AdjacencyList<Node>();
    //                     i = 1;
    //                     j = (i + 1);
    //                     while (i < y)
    //                     {
    //                         Adj = default(AdjacencyList<Node>) ;
    //                         i = j;
    //                         j = (i + 1);
    //                     }
    //                 }
    //             }
    //         }
    //         /*
    //         if (N < 0)
    //         {
    //             Console.Error.WriteLine("N < 0");
    //             Adj = default(AdjacencyList[]);
    //         }
    //         {
    //             Console.Error.WriteLine("N == 0");
    //         else if (N == 0)
    //             Adj = default(AdjacencyList[]);
    //         }
    //         else if (N > 0 && N != 0)
    //         {
                
    //         }*/
    //     //return Adj;
    //     //}

    //     /*
    //     private AdjacencyList<Node> allocArray(int x, int y, AdjacencyList<Node> Adj)
    //     {
    //         int i = default(int);
    //         int j = default(int);
    //         //AdjacencyList[] Adj = default(AdjacencyList[]);
    //         if (x < 0)
    //         {
    //             Console.Error.WriteLine("x < 0");
    //         }
    //         else if (x == 0)
    //         {
    //             Console.Error.WriteLine("x == 0");
    //         }
    //         else if ((x > 0) && (x != 0))
    //         {
    //             if (y < 0)
    //             {
    //                 Console.Error.WriteLine("y < 0");
    //             }
    //             else if (y == 0)
    //             {
    //                 Console.Error.WriteLine("y == 0");
    //             }
    //             else if ((y > 0) && (y != 0))
    //             {
    //                 if (Adj == null)
    //                 {
    //                     Console.Error.WriteLine("Adj == null");

    //                 }
    //                 else if (Adj != null)
    //                 {
    //                     i = x;
    //                     j = (i + 1);
    //                     while (i < y)
    //                     {
    //                         Adj[i] = default(AdjacencyList);
    //                         i = j;
    //                         j = (i + 1);
    //                     }
    //                 }
    //                     //Adj = new AdjacencyList[N + 2];
    //                     //Adj = new AdjacencyList[N];
                        
    //             }
    //         }
    //         return Adj;
    //     }
    //     */
    //     /*
    //     if (N < 0)
    //     {
    //         Console.Error.WriteLine("N < 0");
    //         Adj = default(AdjacencyList[]);
    //     }
    //     {
    //         Console.Error.WriteLine("N == 0");
    //     else if (N == 0)
    //         Adj = default(AdjacencyList[]);
    //     }
    //     else if (N > 0 && N != 0)
    //     {

    //     }*/
    //     // return Adj;
    //     //}

    //     //public int SOURCE { get; }
    //     //public AdjacencyList ADJ { get; }
    //     //public int N { get; }

    //     //public ArrayList[] ADJ { get; }
    //     //public int M { get; }

    //     public override string ToString() => $"({SOURCE}, {N}, {M})";

    //     //        public override string ToString() => $"({SOURCE}, {ADJ}, {N}, {M})";
    // }

    //class YourClass
    //{
    //}

    //struct Input
    //{
    //    Node Source;
    //    Output Adj;
    //    int N;
    //    int M;
    //}

    //interface IYourInterface
    //{
    //}

    //delegate int YourDelegate();

    //enum YourEnum
    //{
    //}

    //namespace YourNestedNamespace
    //{
    //    struct YourStruct
    //    {
    //    }
    }
}
