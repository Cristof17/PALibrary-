using PA_Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace PA_Library
{
    public class BFSAlgorithm
    //public readonly class BFSAlgorithm
    //public readonly struct BFSAlgorithm
    {
        [DllInport("palibrary.dll")]
        private static extern void BFSProcedureConstruct();
        [DllInport("palibrary.dll")]
        private static extern void BFSProcedureRuin();
        [DllInport("palibrary.dll")]
        private static extern void BFSProcedureDelete();

        //struct PAInput
        //struct PATree 
        
        // [DllInport("palibrary.dll")]
        // private static extern void BFS();
        // [DllInport("palibrary.dll")]
        // private static extern void PAGraphInit();
        // [DllInport("palibrary.dll")]
        // private static extern void PAGraphCopy();
        // [DllInport("palibrary.dll")]
        // private static extern void PAGraphDelete();
        // [DllInport("palibrary.dll")]
        // private static extern void PAGraphRuin();
        // [DllInport("palibrary.dll")]
        // private static extern void BFSProcedureRun();
        
        //public BFSAlgorithm(BFSInput Input, BFSOutput output, State state)
        public BFSAlgorithm(BFSInput Input, PAGraf Graf)
        {
            //int Success = 0;
            //int Fail = -1;
            //int Result = Success;
            input = Input;
            graf = Graf;
            //IN = default;
            //IN = new BFSInput(Input.SOURCE, Input.ADJ, Input.N, Input.M);
            //OUT = default;
            //STATE = default;
            //copy(Input);
            //OUT = default;
            ////Result = check(Input);
            //if (Result == Fail)
            //{
            //    //IN = default;
            //    Console.Error.WriteLine("Input error");
            //}
            //else
            //{
            //    OUT =new BFSOutput(Bfs(IN.SOURCE,IN.ADJ, IN.N, IN.M),IN.N);
            //}
            //INPUT = Input;
            //IN = default(BFSInput);
            //OUT = default(BFSOutput);
            //if ((Object)Input == null)
            //{
            //    Console.Error.WriteLine("Input == null");
            //    IN = default;
            //}
            //else if ((Object)Input != null)
            //{
            //    IN = Input;
            //    Console.Out.WriteLine(IN);
            //    OUT = default;

            //}

            //int valid = checkInput(Input);
            //if (valid == 0) ;
            //else if (valid == 1) INPUT = Input;
            //else if (valid == 0)
            //INPUT = default(BFSInput);
            //OUTPUT = default(BFSOutput);
            //OUTPUT = Bfs(Input);
            //retrnu;
            //return OUTPUT;
            //STATE = state;
            //OUTPUT = output;
        }

        public BFSAlgorithm(int Source, ArrayList[] Adj, int N, int M)
        {
            //IN = default;
            //OUT = default;
            //IN = new BFSInput(Source, Adj, N, M);
            //STATE = default;
        }
        //int Success = 0;
        //int Fail = -1;
        //int Result =   Success;
        //Result = check(Source);
        //if (Result == Success)
        //{
        //    Result = Success;
        //}
        //else if (Result == Fail)
        //{
        //    Console.Error.WriteLine("Source error");
        //}
        //Result = check(Adj, N, M);
        //if (Result == Success)
        //{
        //    Result = Success;
        //}
        //else if (Result == Fail)
        //{
        //    Console.Error.WriteLine("Adj error");
        //}
        //Result = check(N);
        //if (Result == Success)
        //{
        //    Result = Success;
        //}
        //else if (Result == Fail)
        //{
        //    Console.Error.WriteLine("N error");
        //}
        //Result = check(M);
        //if (Result == Success)
        //{
        //    Result = Success;
        //}
        //else if (Result == Fail)
        //{
        //    Console.Error.WriteLine("M eror");
        //}
        //IN = default;
        //OUT = default;
        //Result = check(Input);
        //if (Result == Fail)
        //{
        //    //IN = default;
        //    Console.Error.WriteLine("Input error");
        //}
        //else
        //{
        //    IN = copy(Input);
        //    OUT = new BFSOutput(Bfs(IN.SOURCE, IN.ADJ, IN.N, IN.M), IN.N);
        //}
        ////INPUT = Input;
        //IN = default(BFSInput);
        //OUT = default(BFSOutput);
        //if ((Object)Input == null)
        //{
        //    Console.Error.WriteLine("Input == null");
        //    IN = default;
        //}
        //else if ((Object)Input != null)
        //{
        //    IN = Input;
        //    Console.Out.WriteLine(IN);
        //    OUT = default;

        //}

        //int valid = checkInput(Input);
        //if (valid == 0) ;
        //else if (valid == 1) INPUT = Input;
        //else if (valid == 0)
        //INPUT = default(BFSInput);
        //OUTPUT = default(BFSOutput);
        //OUTPUT = Bfs(Input);
        //retrnu;
        //return OUTPUT;
        //STATE = state;
        //OUTPUT = output;

        //public int check(ArrayList Adj, int N, int M)
        //    {
        //    int Successs = 0;
        //    int Fail = -1;
        //    int Result = Successs;
        //    Result = check(Adj);
        //    if (Result == Successs)
        //    {
        //        Result = check(M);
        //        if (Result == Successs)
        //        {
        //            int Neigh = -1;
        //            while (Neigh < M)
        //            {
        //                check(Adj[Neigh]);
        //                Neigh++;
        //            }
        //        }
        //        else
        //        {
        //            Console.Error.WriteLine("error M)");
        //        }
        //        //    int Neigh = 1;
        //        //while )Neigh < mbox)
        //    }
        //    else if (Result == Fail)
        //    {
        //        Console.Error.WriteLine("Adj error");
        //    }
        //    return Result;
        //}

        //public int check(ArrayList[] Adj, int N, int M)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = check(Adj);
        //    if (Result == Success)
        //    {
        //        int Node = 1;
        //        while (Node < N)
        //        {
        //            Node++;
        //            Result = check(Node, Adj[Node], M);
        //        }
        //    }
        //    else if (Result == Fail)
        //    {
        //        Console.Error.WriteLine("Adj error");
        //        Result = Fail;
        //    }
        //    return Result;
        //}
        ////        Result = check();
        ////        int Node = 1;
        ////        if (Result == Success)
        ////        {
        ////            Node = 1;
        ////            while (Node < N)
        ////            {
        ////                int Neigh = 1;
        ////                M = size(Adj[Node]);
        ////                while (Neigh < M)
        ////                {
        ////                    Result = check(Adj[Node][Neigh]);
        ////                    if (Result == Success)
        ////                    {
        ////                        Neigh++;
        ////                    }
        ////                    else
        ////                    {
        ////                        Console.Error.WriteLine("arror Adj[Node][Neigh]");
        ////                        Neigh++;
        ////                    }
        ////                }
        ////            }
        ////        }
        ////        else
        ////        {
        ////            Console.Error.WriteLine("N error");
        ////        }
        ////    }
        ////    else
        ////    {
        ////        Console.Error.WriteLine("Adj error");
        ////        Result = Fail;
        ////    }
        ////}

        //public int check(ArrayList[] Adj)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj == null");
        //        Result = Fail;
        //    }
        //    else if (Adj != null)
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}

        //public int check(ArrayList Adj)
        //{
        //    int Fail = -1;
        //    int Success = 0;
        //    int Result = Success;
        //    if (Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj[Node][Neigh] == null");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}

        //public int check(int Node, ArrayList Adj, int M)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    Result = check(Adj);
        //    if (Result == Success)
        //    {
        //        //Result = check(Adj, Node, M);
        //        Result = check(M);
        //        if (Result == Success)
        //        {
        //            Result = check(Node, Adj, M);
        //        }
        //        else
        //        {
        //            Console.Error.WriteLine("M error");
        //            Result = Fail;
        //        }
        //    }
        //    else
        //    {
        //        Console.Error.WriteLine("Adj[Node] == null");
        //        Result = Fail;
        //    }
        //    return Result;
        //}
        ////        Result = check(M);
        ////    if (Result == Success)
        ////    {
        ////        int Neigh = 1;
        ////        while (Neigh < M)
        ////        {
        ////            check(Adj[Neigh]];)
        ////            y++;
        ////        }
        ////    }
        ////    else
        ////    {
        ////        Console.Error.WriteLine("M error");
        ////    }
        ////}

        //public int size(ArrayList Adj, int M)
        //{
        //    int size = Adj.Capacity;
        //    return size;
        //}

        //public int check(ArrayList[] Adj, int N, int M)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj == null");
        //        //Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //        int x = 1;
        //        int y = 1;
        //        while (x < N)
        //        {
        //            ArrayList temp = Adj[x];
        //            M = size(temp);
        //            while (y < M)
        //            {
        //                Result = check(Adj[x][y]);
        //                y++;
        //                if (Result == Success)
        //                {
        //                }
        //                else
        //                {
        //                    Console.Error.WriteLine("error Adj[x][y]");
        //                }
        //            }

        //        }
        //    }
        //    return Result;
        //}

        public ArrayList Bfs(int Source, ArrayList[] Adj, int N, int M)
        {
            //int Result = default;
            //int Success = 0;
            //int Fail = -1;
            //ArrayList d = OUT.D;
            //BFSOutput d = OUT.D;
            //ArrayList d = default;
            ArrayList d = new ArrayList(N + 1);//= OUT;
                                               //d = state.D;
                                               //BFSState state = new BFSState(IN);
                                               //d = state.D;
                                               //.D;
                                               //OUT;
                                               //if (valid == 0) return default(BFSOutput);
                                               //C//onsole.WriteLine($"Notification received for: {name}");
                                               //BFSInput BfsInput;
                                               //BFSOutput BfsOutput;
                                               //AdjacencyList[] AdjancencyList;
                                               //Node Node;
                                               //Node Neigh;
                                               //BFSState state;
                                               ////BFSOutput BfsOutput = new BFSOutput();
                                               //Output output;
                                               //Cardinal nodeSetCardinal;
                                               //Cardinal edgeSetCardinal;
                                               //Stack q;

            //BFSOutput BfsOutput = default;
            //Result = checkInput(IN);
            //if (Result == Fail) return BfsOutput;
            //else if (valid == 1) INPUT = Input;
            //int valid = checkInput(Input);
            //if (valid == 0) return BfsOutput;
            //else if (valid == 1) INPUT = Input;
            //BfsOutput = default(BFSOutput);//new BFSOutput();
            //BFSInput BfsInput = default(BFSInput);
            //ArrayList Adj = default;
            //Node Node = default;
            //Node Neigh = default;
            //BFSState state = default;
            //BFSState prev = default;
            //Output output = default;
            // output = default(Output);
            //Cardinal nodeSetCardinal = default;
            //Cardinal edgeSetCardinal = default;
            //int N = IN.N;
            //int M = IN.M;
            Stack<int> q = default;
            //int Source = default;
            //Source = IN.SOURCE;
            //AdjacencyList[] Adj = INPUT.NEIGH;
            //ArrayList[] AdjacencyList = default;
            //AdjacencyList = IN.ADJ;
            //Adj = Source.ADJ[Source];
            //nodeSetCardinal = IN.N;
            //edgeSetCardinal = IN.M;
            q = new Stack<int>();
            //state = new BFSState(IN);
            //BfsOutput = new BFSOutput(state);
            //output = new Output(BfsOutput);
            //int[] d = output.D;
            d[Source] = 0;
            q.Push(Source);
            int Node;
            int Neigh;
            //Node = (Node)q.Pop();
            //default;// 0;
            while (q.Count > 0)
            {
                Node = q.Pop();
                //Adj[Node] 
                //Adj = Node.ADJ;
                //M = Adj.Count;
                // Adj = Node.ADJ[Node];
                //ArrayList Adjs = null;
                //Adjs = (List<T>)(Input.Adj[Node.GetHashCode()]);
                //Adjs = Input.ADJ[Node.VALUE];
                //int x = 0;
                //int next_x = x + 1;
                //if (Adj[Source] == 0)
                //continue;
                //int count = Input.ADJ[Node.VALUE].Count;
                //T x = default(T);
                //int i = Adjs.Count;
                //List<T>.Enumerator enumerable;
                //enumerable = Adjs.GetEnumerator();
                //while (x < i)
                // {
                //int Neigh =(int)(Object) Adjs[x];
                //
                //Neigh = default(Node);
                //int x = 0;
                int x = default;
                int y = default;
                y = 1;
                M = Adj[Node].Capacity;
                //x = Node;
                //y = START_INDEX;
                do
                {
                    //Neigh = BfsInput.ADJ.ADJ[Node.VALUE][state.X];
                    //Neigh = INPUT.NEIGH[Input.SOURCE.VALUE].NODES[Node.VALUE];
                    Neigh = (int)Adj[Node][y];
                    //Neigh = new Node<int>(Adj[Node]);// [x];
                    //Equality
                    //Comparer

                    //Comparer<T> comparer = new EqualityComparer<T>();
                    //comparer.Compare(Neigh, Node);
                    //Comparer.
                    //int one = int.Parse(algorithm.OUTPUT.D[Neigh.VALUE]+"");
                    //Comparer<int> comparer = default(Comparer<int>);
                    //comparer = Comparer<int>.Default;
                    //if (comparer.Compare(Node.VALUE, Neigh.VALUE + 1) > 0) {
                    //if (comparer.Compare(Neigh.VALUE, Node.VALUE + 1) > 0)
                    if (((int)(d[Node]) + 1) < ((int)d[Neigh]))
                    {
                        //if (BfsOutput.D.GetValue(Neigh.VALUE) > (BfsOutput.D[Node.VALUE] + 1))
                        //{
                        //int other = int.Parse(algorithm.OUTPUT.D[Node.VALUE]+"");
                        //if (one > other + 1)
                        //{
                        //algorithm.OUTPUT.D[Neigh.VALUE] = BfsOutput.D[Node.VALUE] + 1;
                        //BfsOutput.D.SetValue(BfsOutput.D[Node.VALUE] + 1, + 1,)
                        //d[Neigh] = d[Node] + 1;
                        //q.
                        d[Neigh] = (int)d[Node] + 1;
                        //state.D.SetItem((d[Node] + 1), Neigh);
                        //algorithm.OUTPUT.D[Neigh.VALUE] = BfsOutput.D[Node.VALUE] + 1;
                        q.Push(Neigh);
                        //break;
                        //state.NEIGH = new Node(0);
                    }
                    else
                    {
                        x = y;
                        y = x + 1;
                    }
                    //}
                    //x++;
                    //continue;
                    //state = new State(state);

                    //prev = state;
                    //state = new BFSState(prev, Node, Neigh);
                    //Console.Out.WriteLine(state);
                    //next_x = x + 1;
                    //d[Neigh] = (int)((Object)d[Node] + 1);
                    //} while (state.NEIGH.VALUE < Input.N.VALUE);
                    //} while (state.NEIGH.VALUE < Input.N.VALUE);
                    //} while (x < Input.NEIGH[state.NEIGH.VALUE].NODES.Count);
                } while (y < M);

                // BfsOutput = default(BFSOutput);  
                //BfsOutput = new BFSOutput(state);
                //Console.Out.WriteLine(BfsOutput);
                //throw new Exception("Source < 0");
                //int x = default(int);
                //int y = default(int);
                //int i = default(int);
                //int j = default(int);
                //Input Input = default(Input);
                //Input = new Input(Source,Adj,N,M);
                //Node SourceNode = default(Node);
                //SourceNode = new Node(Source);

                //Cardinal nodesCardinal = default(Cardinal);
                //Cardinal edgesCardinal = default(Cardinal);
                //BFSAlgorithm algorithm = default(BFSAlgorithm); ;
                //BFSInput BfsInput = new BFSInput();
                //BFSState state = default(BFSState);
                //List<int> d = null;
                //d = new List<int>();
                //Result.D = new List<int>();
                //List<T> d = null;
                //BFSOutput<T> Result = null;
                //Result = new BFSOutput<T>();
                //return convert(d, N);
                //return convert(d, 0);
                //throw new Exception("Source < 0");
                //SourceNode = new Input()
                //AdjancencyList = new AdjacencyList(Adj);

                //BfsInput = new BFSInput(SourceNode, AdjancencyList,nodeSetCardinal,edgeSetCardinal);
                //new BFSOutput(Input);
                //nodesCardinal = new Cardinal(N);
                //edgesCardinal = new Cardinal(M);
                //Input = new Input(Source,   Adj,N,M);
                //ArrayList d = null;
                //d = new List<T>();
                //d = new ArrayList(Input.N);

                //Input = new Input(SourceNode, AdjancencyList, nodesCardinal, edgesCardinal); ;
                //state = new BFSState(Input.N);
                //BFSState init = default(BFSState);
                //algorithm = new BFSAlgorithm(BfsInput,BfsOutput,state);
                //algorithm = new BFSAlgorithm(BfsInput, BfsOutput);
                //algorithm = new BFSAlgorithm(BfsInput, BfsOutput);
                //new Output(Input.N);
                //output = new Output(Input.N); ;
                //fill(output,Input);


                //continue
                //int x = 1;
                //while (x < N + 1)
                //{
                //d.Add(int.MaxValue);
                //x++;
                //d}

                //Stack q;
                //q = new Stack();

                //q.Push(Source);
                //if (d.Count == 0)
                //{
                //return convert(d,0); ;
                //}
                //else
                //{
                //d[Source] = 0;
                //}
                //while (algorithm.STATE.Q.Count > 0)

            }
            //ArrayList copy;
            //copy = replace(int.MaxValue, -1, d, N);
            //Result = convert(copy);
            //Object obj = q.Pop();
            //if (obj == null)
            //{
            //continue;
            //} 
            //else
            //{
            //int Node = (int)obj;
            //ArrayList Adjs = Adj[Node];
            //if (Adjs == null)
            //{
            //continue;
            //} 
            //else
            //{
            //ArrayList list = new ArrayList();
            //IEnumerator enumarator;
            //enumarator = Adjs.GetEnumerator();
            //while (enumarator.MoveNext()) {
            //   list.Add(enumarator.Current);
            //}
            //int i = 0;
            //while (i < list.Count)
            //{
            //  Object neigh_Obj = list[i];
            //  int Neigh = (int)neigh_Obj;
            //  Object d_Neigh = d[Neigh];
            //  int i_d_Neigh = (int)d_Neigh;
            //  Object d_Node = d[Node];
            //  int i_d_Node = (int)d_Node;
            //  if (i_d_Node < i_d_Neigh + 1)
            //  {
            //      d[Neigh] = (i_d_Neigh + 1);
            //      q.Push(d_Neigh);
            //  }
            //  i++;
            //int Neigh = list[Index];
            //}
            //}
            //}
            //}
            //ArrayList copy = replace(int.MaxValue, -1, d, N);
            //int[] d = convert(copy, N);
            //int[] Result = convert(copy, N);
            //return Result;

            //Copy(BfsOutput,output,Input);
            //return Convert(output,Input);

            //output = new Output(BfsOutput);
            //int[] temp = convert(algorithm.OUTPUT.D, algorithm.INPUT.N);
            //return temp;
            return d;
        }
        //return BfsOutput;
        //}
        //public int check(Object Input)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Input == null)
        //    {
        //        Console.Error.WriteLine($"{Input} == null");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }

        //    return Result;
        //}
        //public BFSInput input { get; }
        public BFSInput input { get; }

        public PAGraf graf { get; }
        //public BFSOutput OUT { get; }
        //public State STATE { get; }
        //private int START_INDEX { get { return 1; } }
        ////public override string ToString() => $"({INPUT}), ({OUTPUT}, ({STATE})";
        //public override string ToString() => $"({IN})";
        //public int check(int Source)
        //{
        //    int Fail = -1;
        //    int Success = 0;
        //    int Result = Success;
        //    if (Source < 0)
        //    {
        //        Console.Error.WriteLine($"{Source} < 0");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    if (Source == 0)
        //    {
        //        Console.Error.WriteLine($"{Source} == 0");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    if (Source > 0)
        //    {
        //        Console.Out.WriteLine($"{Source} > 0");
        //        Result = Success;
        //    }
        //    return Result;
        //}

        //public int checkAdjacencyList(AdjacencyList Adj)
        //{
        //    int Fail = -1;
        //    int Success = 0;

        //    if ((Object)Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj == null");
        //        return Fail;
        //    }
        //    else if ((Object)Adj != null)
        //    {
        //        int x = default;
        //        int y = default;
        //        x = y + 1;
        //        ArrayList[] AdjacencyList = Adj.ADJ;
        //        if (AdjacencyList == null)
        //        {
        //            return Fail;
        //        }
        //        else if (AdjacencyList != null)
        //        {
        //            int N = Adj.ADJ.Length;
        //            if (N == 0)
        //            {
        //                return Fail;
        //            }
        //            else if (N > 0)
        //            {
        //                return Success;
        //            }
        //            return Success;
        //        }
        //    }
        //    return Success;
        //}

        //public BFSInput copy(BFSInput Input)
        //{
        //    BFSInput Result;// = new BFSInput();
        //    int Source;// = new Node();
        //    ArrayList[] Adj;
        //    //= new AdjacencyList();
        //    int N;
        //    int M;
        //    Source = copy(Input.SOURCE);
        //    Adj = copy(Input.ADJ,Input.N,Input.M);
        //    N = copy(Input.N);
        //    M = copy(Input.M);
        //    //Result = new BFSInput(Input.N, Input.ADJ, Input.N, Input.M);
        //    //Result = new BFSInput(surce, Adj, N, M);
        //    Result = new BFSInput(Source, Adj, N, M);
        //    return Result;
        //}

        //public ArrayList copy(ArrayList Adj_node, int M)
        //{
        //    ArrayList copy;
        //    copy = new ArrayList();
        //    int y = default;
        //    while (y < M)
        //    {
        //        copy[y] = Adj_node[y];
        //        y++;
        //    }
        //    return copy;
        //}

        //public int copy(int Node)
        //{
        //    int copy;
        //    copy = Node;
        //    return copy;
        //}
        //public ArrayList[] copy(ArrayList[] Adj, int N, int M)
        //{
        //    ArrayList[] Result;
        //    Result = new ArrayList[N];
        //    //;
        //    int x = 0;
        //    while (x < N)
        //    {
        //        Result[x] = copy(Adj[x],N);
        //        x++;
        //    }
        //    return Result;
        //}

        //public Object copy(Object Neigh)
        //{
        //    Object Result;
        //    Result = Neigh;
        //    return Result;
        //}
        //public int checkInput(BFSInput Input)
        //{
        //    int Result = 0;
        //    int Success = 0;
        //    int Fail = -1;
        //    //Result = checkNode(Input.SOURCE);
        //    if (Result == Fail)
        //    {
        //        Console.Error.WriteLine("checkSource() == -1");
        //        return Fail;
        //    }
        //    Result = checkAdjacencyList(Input.ADJ);
        //    if (Result == Fail)
        //    {
        //        Console.Error.WriteLine("checkAdjacencyList() == -1");
        //        return Fail;
        //    }
        //    Result = checkCardinal(Input.N);
        //    if (Result == Fail)
        //    {
        //        Console.Error.WriteLine("checkCardinal() == -1");
        //        return Fail;
        //    }
        //    Result = checkCardinal(Input.M);
        //    if (Result == Fail)
        //    {
        //        Console.Error.WriteLine("checkCardinal() == -1");
        //        return Fail;
        //    }
        //    Result = Success;
        //    return Result;

        //int Result = default;
        //int valid = 1;
        //int invalid = 0;
        //int Source = Input.SOURCE;
        //int N = Input.N.NUMBER;
        //if (Source < 0)
        //{
        //throw new Exception("Source < 0");
        //return Convert(output, Input
        //);
        //Console.Error.WriteLine("Source < 0");
        //Result = invalid;
        //BfsOutput = default(BFSOutput);
        //}
        //else if (Source == 0)
        //{
        // Console.Error.WriteLine("Source == 0");
        //BfsOutput = default(BFSOutput);
        // Result = invalid;
        //}
        //else if (Source > 0)
        //{
        //if (N < 0)
        //{
        //    Console.Error.WriteLine("N < 0");
        //    //BfsOutput = default(BFSOutput);
        //    Result = invalid;
        //}
        //else if (N == 0)
        //{
        //    Console.Error.WriteLine("N == 0");
        //    Result = invalid;
        //}
        //else if (N != 0)
        //{
        //    //int Source = Input.SOURCE.VALUE;
        //    //int N = Input.N.VALUE;

        //    if (N > 0)
        //    {
        //        if (Source < N)
        //        {
        //            //do nothing
        //        }
        //            //return valid;
        //        else if (Source == 0)
        //        {
        //            Console.Error.WriteLine("Source == N");
        //            Result = invalid; 
        //        }
        //        else if (Source > N)
        //        {
        //            Console.Error.WriteLine("Source > N");
        //            Result = invalid;
        //        }
        //        //return valid;
        //        //return valid;
        //    }
        //    else if (N == 0)
        //    {
        //        Console.Error.WriteLine("N == 0");
        //            Result = invalid;
        //    }
        //    else if (N < 0)
        //    {
        //        Console.Error.WriteLine("N < 0");
        //        Result = invalid;
        //    }
        //}
        //if (Input.NEIGH == null)
        //{
        //    //throw new Exception("Adj == null");
        //    //return default(BFSOutput);//return Convert(output, Input);
        //    //Node Node = new Node(int.MaxValue);
        //    Console.Error.WriteLine("Neigh == null");
        //    //BfsOutput = default(BFSOutput);
        //    Result = invalid;
        //}
        //else if (Input.NEIGH != null)
        //{
        //    Result = valid;
        //}
        //}
        //return Result;
        //if (Input.SOURCE.VALUE > 0)
        //{
        //if (Input.N.VALUE > 0)
        //{

        //}
        //}
        //return valid;
        //}
        //public int check(Cardinal N)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    //if (N == null)
        //    //{
        //    //    Console.Error.WriteLine("N == null");
        //    //    return Fail;
        //    //}
        //    //else if (N != null)
        //    //{
        //    //int number = N.NUMBER;
        //    int number = N;
        //    if (N < 0)
        //    {
        //        Console.Error.WriteLine($"{N} < 0");
        //        Result = Fail;
        //    }
        //    else if (N == 0)
        //    {
        //        Console.Error.WriteLine($"{N} == 0");
        //        Result = Fail;
        //    }
        //    else if (number > 0)
        //    {
        //        Result = Success;
        //        //return Success;
        //    }
        //    //}
        //    return Result;
        //}


        //class BFSAlgorithm<T>:Algorithm<T>
        //{
        //    internal BFSAlgorithm(BFSInput<T> Input)
        //    {

        //    }
        //    //public Output<int> Bfs(int Source, ArrayList[] Adj, int N, int M)
        //    //{

        //    //}
        //    internal BFSOutput<T> Bfs(BFSInput<Node<T>> Input)
        //    {
        //        List<T> d = null;
        //        BFSOutput<T> Result = null;
        //        Result = new BFSOutput<T>();
        //            //return convert(d, N);
        //            //return convert(d, 0);
        //        //throw new Exception("Source < 0");

        //            //ArrayList d = null;
        //        d = new List<T>();

        //        Stack<Node<T>> q = null;
        //        q = new Stack<Node<T>>();

        //        q.Push(Input.Source.Value);
        //        d[Input.Source.Value.GetHashCode()] = default(T);

        //            //continue
        //            //int x = 1;
        //            //while (x < N + 1)
        //            //{
        //            //d.Add(int.MaxValue);
        //            //x++;
        //            //d}

        //            //Stack q;
        //            //q = new Stack();

        //            //q.Push(Source);
        //            //if (d.Count == 0)
        //            //{
        //            //return convert(d,0); ;
        //            //}
        //            //else
        //            //{
        //            //d[Source] = 0;
        //            //}
        //        while (q.Count > 0)
        //        {
        //            Node<T> Node = q.Pop();
        //            List<T> Adjs = null;
        //            //Adjs = (List<T>)(Input.Adj[Node.GetHashCode()]);
        //            Adjs = (List<T>)(Input.Adj[Node.GetHashCode()]);
        //            T x = default(T);
        //            //int i = Adjs.Count;
        //            List<T>.Enumerator enumerable;
        //            enumerable = Adjs.GetEnumerator();
        //                //while (x < i)
        //                // {
        //                //int Neigh =(int)(Object) Adjs[x];
        //                //}
        //            do
        //            {
        //                T Neigh = enumerable.Current;
        //                //Equality
        //                //Comparer

        //                //Comparer<T> comparer = new EqualityComparer<T>();
        //                //comparer.Compare(Neigh, Node);
        //                if (Neigh > Node) > ((int)(Object)d[Node]) + 1)
        //                {
        //                    d[Neigh] = ((int)(Object)d[Node]) + 1;
        //                    q.Push(Neigh);
        //                }
        //                else
        //                {
        //                    x++;
        //                    continue;
        //                }
        //                x++;
        //                    //d[Neigh] = (int)((Object)d[Node] + 1);
        //            } while (x < i);
        //            ArrayList copy;
        //            copy = replace(int.MaxValue, -1, d, N);
        //            Result = convert(copy);
        //            return Result;
        //                //Object obj = q.Pop();
        //                //if (obj == null)
        //                //{
        //                //continue;
        //                //} 
        //                //else
        //                //{
        //                //int Node = (int)obj;
        //                //ArrayList Adjs = Adj[Node];
        //                //if (Adjs == null)
        //                //{
        //                //continue;
        //                //} 
        //                //else
        //                //{
        //                //ArrayList list = new ArrayList();
        //                //IEnumerator enumarator;
        //                //enumarator = Adjs.GetEnumerator();
        //                //while (enumarator.MoveNext()) {
        //                //   list.Add(enumarator.Current);
        //                //}
        //                //int i = 0;
        //                //while (i < list.Count)
        //                //{
        //                //  Object neigh_Obj = list[i];
        //                //  int Neigh = (int)neigh_Obj;
        //                //  Object d_Neigh = d[Neigh];
        //                //  int i_d_Neigh = (int)d_Neigh;
        //                //  Object d_Node = d[Node];
        //                //  int i_d_Node = (int)d_Node;
        //                //  if (i_d_Node < i_d_Neigh + 1)
        //                //  {
        //                //      d[Neigh] = (i_d_Neigh + 1);
        //                //      q.Push(d_Neigh);
        //                //  }
        //                //  i++;
        //                //int Neigh = list[Index];
        //                //}
        //                //}
        //                //}
        //                //}
        //                //ArrayList copy = replace(int.MaxValue, -1, d, N);
        //                //int[] d = convert(copy, N);
        //                //int[] Result = convert(copy, N);
        //                //return Result;
        //        }
        //        Result = convert(d);
        //        return Result;
        //    }

        //    private void do_nothing()
        //    {
        //        return;
        //    }

        //    internal Output<int> convert(ArrayList list)
        //    {
        //        BFSOutput<int> Result;
        //        Result = new BFSOutput<int>();
        //        if (list == null)
        //            ;
        //        else
        //        {
        //            int i = 1;
        //            do
        //            {
        //                Result[i] = (int)list[i];
        //                i++;
        //            } while (i < N + 1);
        //        }
        //        return Result;
        //    }
        //    /*
        //    public int[] convert(ArrayList list, int N)
        //    {
        //        int[] Result = null;
        //        Result = new int[N];
        //        if (list == null)
        //        {
        //            return Result;
        //        }
        //        else
        //        {
        //            int index = 1;
        //            while (index < (N + 1))
        //            {
        //                Object o = list[index];
        //                int i_o = (int)o;
        //                Result[index] = i_o;
        //                index++;
        //            }
        //        }
        //        return Result;
        //    }*/

        //    public ArrayList replace(int from, int with, ArrayList list, int N)
        //    {
        //        //int[] Result = null;
        //        ArrayList copy = null;
        //        copy = new ArrayList();
        //        int x = 1;
        //        while (x < (N + 1))
        //        {
        //            Object o = list[x];
        //            int i = (int)o;
        //            copy[x] = i;
        //            x++;
        //        }
        //        int y = 1;
        //        while (y < (N + 1))
        //        {
        //            Object o = list[y];
        //            int i = (int)o;
        //            if (i == from)
        //            {
        //                copy[y] = with;
        //            }
        //            else
        //            {
        //                copy[y] = list[y];
        //            }
        //            y++;
        //        }
        //        return copy;
        //    }
        //}


        /*
         * Provides Input method for the algorithm
         */


        //public ArrayList[] copy(ArrayList[] Adj, int N)
        //{
        //    int ArrayList[] copy = 

        //}

        //public int check(Input)
        //public int check(int Source)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Source < 0)
        //    {
        //        Console.WriteLine($"Source < 0");
        //        Result = Fail;
        //    }
        //    if (Source > 0)
        //    {

        //        Console.WriteLine("");
        //        Result = Success;
        //    }
        //    if (Source == 0)
        //    {
        //        Console.Error.WriteLine($"{Source} == 0");
        //        Result = Success;
        //    }
        //    return Result;
        //}

        //public int check(ArrayList[] Adj)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj == null");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}

        //Provides the algorithm.
        public Output Run()
        //q ' '
        {
            Output output = default;
            BFSAlgorithm bFSAlgorithm = default;
            BFSInput bfsInput = default;
            BFSOutput bFSOutput = default;
            PACardinal N = default;
            //N = new PACardinal(IN.N);
            //      bfsInput = new BFSInput(INPUT.SOURCE, INPUT.ADJ, INPUT.N, INPUT.M);
            //bfsInput = new BFSInput(IN.SOURCE, IN.ADJ, IN.N, IN.M);
            //bFSAlgorithm = new BFSAlgorithm(bfsInput);
            //bFSAlgorithm.Bfs(bfsInput.SOURCE, bfsInput.ADJ, bfsInput.N, bfsInput.M);
            output = new Output(bFSOutput);
            //bFSAlgorithm = new BFSAlgorithm(new BFSInput(Input.SOURCE, Input.ADJ, Input.N, Input.M));
            //output = new Output(bFSAlgorithm.OUTPUT);
            //output = new Output(new BFSAlgorithm(new BFSInput(Input.SOURCE, Input.ADJ, Input.N, Input.M)));
            //output = new Output(new BFSOutput(new BFSInput(Input.SOURCE,Input.ADJ,Input.N,Input.M)));
            //output = new Output(Bfs(new BFSInput(new Node(1), Input.ADJ,  Input.N, Input.M)));
            //return bFSAlgorithm.OUTPUT;
            return output;
        }
        //Input parameters

        // * Output Results
        //public Output OUT { get; }

        //public Output OUTPUT { get; }

        //public override string ToString() => $"({INPUT}, {OUTPUT})";

        //Provides string representation

        public override string ToString() => $"({input})";


        /*
        static void fill(Output output, Input Input)
        {
            int i = 0;
            int next_i = i + 1;
            while (i < Input.N)
            {
                output.D.Add(default(Object));
                i = next_i;
                next_i = i + 1;
            }
        }
        */
        //static void checkInput(Input Input)
        //{

        //}

        //static void nextState(BFSState state)
        //{
        //    struct BFSState out = default(BFSState);
        //    out = new BFSState();

        //}

        //static BFSState nextState(BFSState state)
        //{
        //    int x = state.X;
        //    int next_x = x + 1;
        //    //BFSState nextState = new BFSState(next_x);
        //    State newState = new State(state.Q, next_x);
        //    return newState;
        //}
        //static BFSState nextState(BFSState state)
        //{
        //int x = state.X;
        //int next_x = x + 1;
        //BFSState nextState = new BFSState(next_x);
        //BFSState newState = new BFSState(state.Q, next_x, BFSInput);
        //return newState;
        //}

        /*
        static void Copy(BFSOutput bfsOutput, Output output, Input Input)
        {
            ImmutableArray<int> from;
            from = bfsOutput.D;
            //int[] from = Bfs.D;
            //ArrayList to = output.D;
            int N = Input.N;
            int x = 0;
            int next_x = 1;
            while (x < N)
            {
                output.D[x] = from[x];
                x = next_x;
                next_x = x + 1;
            }
            return;
        }
        */
        //static int[] Convert(Output output, Input Input)
        //{
        //    //if (output == null)
        //    //dthrow new Exception("output == null");
        //    //if (list.Count < 0)
        //    //    throw new Exception("list.Count < 0");
        //    int[] Result = default(int[]);
        //    Result = new int[Input.N];
        //    //int i = deFailt(int);
        //    int i = default;
        //    int next_i = i + 1;
        //    int N = Input.N;
        //    while (i < N)
        //    {
        //        Result[i] = (int)output.D[i];
        //        i = next_i;
        //        next_i = i + 1;
        //    }
        //    //i = 1;
        //    /*
        //    do
        //    {
        //        Result[i] = int.Parse(list[i].ToString());
        //        //Result.SetValue(list[i],i);
        //        i++;
        //    } while (i < (N + 1));
        //    */
        //    return Result;
        //}
    }
}