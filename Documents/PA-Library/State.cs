using System;
using System.Collections;
using System.Collections.Immutable;
namespace PA_Library
{
    public struct State
    {
        //struct PAStatus visited;

        //public BFSState(Stack q/*, int x*/)
        //public BFSState(Stack q, BFSInput<T> N)
        //{

        //}
        public State(BFSIntrare bfsInput)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            D = default;
            N = default;
            EDGE = default;
            Result = Check((Object)bfsInput);
            if (Result == Success)
            {
                D = new ArrayList(bfsInput.N);
                N = Copy(bfsInput.N);
                EDGE = default;
            }
            else if (Result == Fail)
            {
                Console.Error.WriteLine("bfsInput error");
            }
        }

        //public int Check(Object bfsInput)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (bfsInput == null)
        //    {
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}
        public Situatie(Edge Edge, ArrayList D, int N) : this()
        {
            EDGE = default;
            D = default;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            N = default;

            Result = Check((Object)Edge);
            if (Result == Fail)
            {
              //Console.Error.WriteLine("edge error");
                Result = Fail;
            }
            else
            {
                EDGE = Copy(Edge);
                Result = Success;
            }
            Result = Check(N);
            if (Result == Success)
            {
                Result = Success;
                N = Copy(N);
                Result = Check(D);
                if (Result == Fail)
                {
                    //Console.Error.WriteLine("error d");
                    //Result = Fail;
                }
                else
                {
                    Result = Success;
                    this.D = Copy(D, N);

                }
            }
            else
            {
                Result = Fail;
              //Console.Error.WriteLine("N error");
            }
        }

        Edge Copy(Edge edge)
        {
            Edge copy = default;
            copy = new Edge(edge.NODE, edge.NEIGH);
            return copy;
        }

        public int Copy(int N)
        {
            int copy = default;
            copy = N;
            return copy;
        }

        public ArrayList Copy(ArrayList d, int N)
        {
            //ArrayList copy;
            //copy = new ArrayList(N);
            ArrayList copy;
            copy = new ArrayList();
            int x = 0;
            while (x < N)
            {
                copy[x] = d[x];
                x++;
            }
            return copy;
        }

        //public int Check(ArrayList d, int N)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;

        //}


        //public BFSState(BFSInput Input)
        //{
        //    EDGE = default;
        //    D = default;
        //    if ((Object)Input != null)
        //    {
        //        //int N = Input.N;
        //        D = ImmutableArray.Create<int>();
        //        int x = default;
        //        int y = default;
        //        int N = Input.N;
        //        while (x < N)
        //        {
        //            D.Add(default);
        //            x++;
        //            y++;
        //        }
        //        //new ArrayList();
        //    }
        //    else if ((Object)Input == null)
        //    {
        //        Console.Error.WriteLine("Input == null");
        //        D = default;
        //    }
        //}

        public int Check(Object edge)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (edge == null)
            {
                Result = Fail;
            }
            else
            {
                Result = Success;
            }
            return Result;
        }

        //public int Check(ArrayList d, int N)
        //{

        //}
        public BFSState(Node Node, Node Neigh, ArrayList d, int N) : this()
        {
            //Q = default(Stack);
            //NODE = default;
            // N = default;
            EDGE = default;
            EDGE = new Edge(Node, Neigh);
            D = default(ArrayList);
            N = default;
            //int valid = checkInput(Node,q,d,N);
            //if (valid == 1)
            //{
            // NODE = Node;
            // Q = q;
            //ImmutableArray<int> d = default(ImmutableArray<int>);
            //if (prev == null)
            // if (d == null)
            // {
            //   Console.Error.WriteLine("d == null");
            // }
            //else if (d != null)
            //{
            //D = ImmutableArray.Create<Node>();
            if (d == null)
            {
                Console.Error.WriteLine("d == null");
                D = default;
            }
            else if (d != null)
            {
                D = Copy(d, N);
                //ImmutableArray<int>.Enumerator enumerator;
                //enumerator = d.GetEnumerator();
                //while (enumerator.MoveNext())
                //{
                //    D.Add(enumerator.Current);
                //}
            }
            //}
            //valid = checkValue(N);
            //if (valid == 1) N = N;
            //valid = checkValue(N);
            //}
            //D = InitResult(d);
            //if (((Object)N) == null)
            //{
            //Console.Error.WriteLine("N == null");
            //}
            // else if (((Object)N) != null)
            // {
            //if (N.VALUE == 0)
            //{
            //    Console.Error.WriteLine("N == 0");
            //    N = N;
            //}
            //else if (N.VALUE < 0)
            //{
            //    Console.Error.WriteLine("N < 0");

            //    N = N;
            //}
            //else if (N.VALUE > 0)
            //{
            //    N = N;
            //}
            //}
            //D = InitResult(d);
            //N = default(Cardinal);
        }

        public int Check(Node Node)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (Node.INDEX < 0)
            {
                Console.Error.WriteLine($"{Node.INDEX} < 0");
                Result = Fail;
            }
            if (Node.INDEX == 0)
            {
                Console.Error.WriteLine($"{Node.INDEX} == 0");
                Result = Fail;
            }
            if (Node.INDEX > 0)
            {
                Result = Success;
            }
            return Result;
        }
        public int Check(int N)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (N < 0)
            {
                Console.Error.WriteLine($"{N} < 0");
                Result = Fail;
            }
            if (N == 0)
            {
                Console.Error.WriteLine($"{N} == 0");
                Result = Fail;
            }
            if (N > 0)
            {
                Result = Success;
            }
            return Result;
        }
        public BFSState(BFSState prev)
        {
            EDGE = default;
            D = default;
            N = default;
            if ((Object)prev != null)
            {
                if ((Object)prev.EDGE != null)
                {
                    EDGE = new Edge(prev.EDGE.NODE, prev.EDGE.NEIGH);
                }
                else if ((Object)prev.EDGE == null)
                {
                    Console.Error.WriteLine("prev.EDGE == null");
                    EDGE = default;
                }
                if (prev.D == null)
                {
                    Console.Error.WriteLine("prev.D == null");
                    D = default;
                }
                else
                {
                    D = new ArrayList();
                    //ImmutableArray<int>.Enumerator enumarator;
                    //enumarator = prev.D.GetEnumerator();
                    //while (enumarator.MoveNext())
                    //{
                    //    D.Add(enumarator.Current);
                    //}
                }
            }
        }
        public BFSState(BFSState prev, Node Node, Node Neigh)
        {
            //NODE = default;
            //Q = default;
            ////D = default;
            //N = default;
            //NODE = default(Node);

            //int valid = checkInput(prev, Node);
            //if (valid == 1) {
            EDGE = default;
            EDGE = new Edge(Node, Neigh);
            N = default;
            D = default;
            if ((Object)prev != null)
            {
                D = new ArrayList();
                D = Copy(prev.D, prev.N);
                //ImmutableArray<int>.Enumerator enumerator;
                //enumerator = prev.D.GetEnumerator();
                //while (enumerator.MoveNext())
                //{
                //    D.Add(enumerator.Current);
                //}
            }
            else
            {
                Console.Error.WriteLine("prev.d == null");
                D = default;
            }

            //BFSState newState = new BFSState(Node, Neigh, prev.D);
            //NODE = newState.NODE;
            //Q = newState.Q;
            //D = newState.D;
            //N = newState.N;
            //NODE = Node;
        }

        //else
        //{
        //}
        //if ((Object)Node == null)
        //{
        //}
        //else if ((Object)Node != null)
        //{
        //}
        // }
        //NEIGH = new Node(prev.NEIGH.VALUE + 1);
        //NODE = default(Node);
        //    NODE = Node;
        //    D = default(ImmutableArray<int>);
        //    D = new ImmutableArray<int>();
        //    N = default(Cardinal);
        //    N = new Cardinal(prev.D.Length);



        //  else
        //{
        //  if (((Object)prev) == null)
        //{
        //  Console.Error.WriteLine("prev == null");
        // }
        //}

        // }

        private static ImmutableArray<int> InitResult(ImmutableArray<int> prev)
        {
            //else if ((Object)Node != null)
            //{
            //    if (Node.VALUE < 0)
            //    {
            //        Console.Error.WriteLine("Node.Value < 0");
            //    }
            //    else if (Node.VALUE == 0)
            //    {
            //        Console.Error.WriteLine("Node.Value == 0");
            //    }
            //    else
            //    {
            //        NODE = (Node)Node;
            //    }
            //}

            return prev;
        }

        //    if (d == null)
        //    {
        //        Console.Error.WriteLine("d === null ");
        //        D = default(ImmutableArray<int>);
        //    }
        //    else
        //    {

        //        d = new ImmutableArray<int>();

        //        D = d;
        //    }
        //    if ((Object)N == null)
        //    {
        //        Console.Error.WriteLine("N == null");
        //        N = default(Cardinal);
        //    }
        //    else if (N.VALUE < 0)
        //    {
        //        Console.Error.WriteLine("N.VALUE < 0");
        //        N = default(Cardinal);
        //    }
        //    else if (N.VALUE == 0)
        //    {
        //        Console.Error.WriteLine("N.Value == 0");
        //        N = default(Cardinal);
        //    }
        //    else if (N.VALUE > 0)
        //    {
        //        N = new Cardinal(N.VALUE);
        //    }
        //}
        //}

        public BFSState(ArrayList d, BFSInput Input, int N) : this()
        {
            D = default;
            EDGE = default;
            N = default;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = Check(d);
            if (Result == Fail)
            {
                Console.Error.WriteLine("d error");

            }
            else if (Result == Success)
            {
                Result = Check(Input);
                if (Result == Success)
                {
                    Result = Check(N);
                    if (Result == Success)
                    {
                        d = Copy(d, N); //N, d
                    }
                    else
                    {
                        Console.Error.WriteLine("N error");
                    }
                }
                else
                {
                    Console.Error.WriteLine("Input error");
                }
            }
            //if (d != null)
            //{
            //    D = ImmutableArray.Create<int>();
            //    int x = 0;
            //    int y = x + 1;
            //    int N = d.Count;
            //    while (x < N)
            //    {
            //        D.Add((Node)d[x]);
            //        x++;
            //        y++;
            //    }
            //}
            //else if (d == null)
            //{
            //    Console.Error.WriteLine("d == null");
            //    D = default;
            //}
            //NODE = default;
            //Q = default;
            //N = default;
            //D = default;
            //q = new Stack();
            //int valid = checkInput(q, Input);
            //ImmutableArray<int> d = default;
            //d = default;
            //if (valid == 1)
            //{
            //   // Q = q;
            //    //NODE = new Node<T>(Input.SOURCE);
            //    int x = default;
            //    x = Input.SOURCE;
            //    int y = default;
            //    //y = x + 1;
            //    d = ImmutableArray.Create<int>();
            //    valid = checkValue(Input.N);
            //    if (valid == 1)
            //    {
            //        //N = new Cardinal<T>(Input.N.VALUE);
            //    }
            //    Console.Error.WriteLine("N > 0");
            //    //d = default(ImmutableArray<int>);
            //    //x = default(int);
            //    //x = Input.SOURCE.VALUE;
            //    while (x < Input.N.NUMBER)
            //    {
            //        d.Add(int.MaxValue);
            //        //if (d == null)
            //        //{
            //        //    Console.Error.WriteLine("d == null");
            //        //}
            //        //else
            //        //{
            //        //}
            //        x = y;
            //        y = x + 1;
            //    }
            //    Console.WriteLine("x > 0");
            //int valid = checkInput(q, Input);
            //if (checkInput)
            //{ }
            //d = default(ImmutableArray<int>);

            //if (q == null)
            //{
            //    Console.Error.WriteLine("q == null");
            //}
            //else if (q != null)
            //{
            //    Q = q;
            //}


            //new ImmutableArray<int>();


            //}

            //}

            //if (Input.N.VALUE < 0)
            //{
            //    Console.Error.WriteLine("N < 0");
            //    d = default(ImmutableArray<int>);
            //}
            //else if (Input.N.VALUE == 0)
            //{
            //    Console.Error.WriteLine("N == 0");
            //    d = default(ImmutableArray<int>);
            //}
            //else if (Input.N.VALUE > 0)
            //{

            //i = x;
            //j = i + 1;
            //while (i < N.VALUE)
            //{
            //    d.SetItem(i, int.MaxValue);
            //    i = j;
            //    j = i + 1;
            //}
            //}
        }



        //D = initArray(Input.SOURCE.VALUE,Input.N);
        //int i = default(int);
        //i = x;
        //int j = default(int);
        //j = i + 1;

        //Console.Error.WriteLine("x > 0");
        //d = new 
        //d = new ImmutableArray<int>();

        //}
        //int y = N.VALUE;
        //initArray(x,N);
        //int x = i;
        //int y = j;
        //int i = 1;
        //int j = i + 1;
        // while (i < N.VALUE)
        // {
        // this.D.Add(int.MaxValue);
        // i = j;
        // j = i + 1;
        //}
        //Cardinal i = default(Cardinal);
        //Cardinal j = default(Cardinal);
        /*
        if (prev.Equals(default(BFSState)))
        {
            int i = 1;
            int j = i + 1;
            while (i < Input.N.VALUE)
            {
                this.D.Add(int.MaxValue);
                i = j;
                j = i + 1;
            }
            //Cardinal 
        }
        */
        /*
        else 
        { 
            N = new Cardinal(prev.N.VALUE);
            ImmutableArray<int>.Enumerator enumerator;
            enumerator = prev.D.GetEnumerator();
            while (enumerator.MoveNext())
            {
            //this.D.SetItem(enumerator.)
                this.D.Add(enumerator.Current);
            }
            enumerator = prev.D.GetEnumerator();
        }*/
        //x = default(Cardinal);
        //next_x = new Cardinal(x.VALUE + 1);
        //i = new Cardinal(1);//start from 1
        //j = new Cardinal(i.VALUE + 1);//next_value
        //while (i.VALUE < Input.N.VALUE)
        //{
        //    D.Add(int.MaxValue);
        //    i = new Cardinal(j.VALUE);
        //    j = new Cardinal(i.VALUE + 1);
        //x = new Cardinal(next_x.VALUE);
        //next_x = new Cardinal(x.VALUE + 1);
        //}
        //x = new Cardinal();
        //x = default(Cardinal);
        //next_x = default(Cardinal);
        //next_x = new Cardinal(x.VALUE + 1);
        //while(x.VALUE < i)
        /*
        //x = new Cardinal(1);
        //next_x = new Cardinal(x.VALUE + 1);
        ImmutableArray<int>.Enumerator i;
        i = D.GetEnumerator();
        while (i.MoveNext())
        {
            D.SetItem(x.VALUE, int.MaxValue);

    }
        */
        /*
        while (x.VALUE < Input.N.VALUE)
        {
            //x = next_x;
            x = new Cardinal(next_x.VALUE);
            next_x = new Cardinal(x.VALUE + 1);
         }*/
        //i = new Cardinal(1);
        //j = new Cardinal(i.VALUE + 1);
        //while (enumerator.MoveNext())
        //{
        //    this.D.SetItem(x.VALUE, enumerator.Current);
        //    x = new Cardinal(next_x.VALUE);
        //    next_x = new Cardinal(x.VALUE + 1);
        //}
        //OUTPUT = output;
        //Console.WriteLine("Numele meu este Iliuta");
        //}
        //private int checkInput(Stack q, BFSInput Input)
        //{
        //    int valid = 1;
        //    int invalid = 0;
        //    if (q == null)
        //        return invalid;
        //    else if (q != null)
        //    {
        //        if((Object)Input == null)
        //        {
        //            return invalid;
        //        } else if ((Object)Input != null)
        //        {
        //            return valid;
        //        }
        //        return valid;
        //    }
        //    return valid;
        //}

        //private vI
        private int checkInput(BFSState prev, Node Node)
        {
            int valid = 1;
            int invalid = 0;
            if (((Object)prev) != null)
            {
                return valid;
            }
            else if (((Object)prev) == null)
            {
                Console.Error.WriteLine("prev == null");
                return invalid;
            }
            if (((Object)Node) != null)
            {
                return valid;
            }
            else if (((Object)Node) == null)
            {
                Console.Error.WriteLine("Node == null");
                return invalid;
            }
            return valid;
        }

        private int checkInput(Node Node, Stack q, ImmutableArray<Node> d, Cardinal N)
        {
            int valid = 1;
            int invalid = 0;
            if ((Object)Node == null)
            {
                Console.Error.WriteLine("Node == null");
                return invalid;
                //NODE = Node;
            }
            else if ((Object)Node != null)
            {
                return valid;
                //NODE = Node;
            }
            if (q == null)
            {
                Console.Error.WriteLine("q == null");
                //Q = q;
                return invalid;
            }
            else if (q != null)
            {
                //Q = q;
                return valid;
            }
            if (d == null)
            {
                Console.Error.WriteLine("d == null");
                return invalid;
                //D = ImmutableArray.Create<int>();
            }
            else if (d != null)
            {
                return valid;
            }
            if (((Object)N) == null)
            {
                Console.Error.WriteLine("N == null");
                //N = N;
            }
            else if (((Object)N) != null)
            {
                return valid;
            }

            return valid;
        }

        //private static int checkInput(Stack q, BFSInput Input)
        //{
        //    int valid = 1;
        //    int invalid = 0;
        //    if ((Object)q == null)
        //    {
        //        Console.Error.WriteLine("q == null");
        //    }
        //    else if ((Object)q != null)
        //    {
        //        return valid;
        //    }
        //    if (((Object)Input.SOURCE) == null)
        //    {
        //        Console.Error.WriteLine("Input.Source == null");
        //    }
        //    else if (((Object)Input.SOURCE) != null)
        //    {
        //        return valid;
        //    }
        //    //int x = Input.SOURCE;
        //if (x < 0)
        //{
        ///    Console.Error.WriteLine("x < 0");
        //    return invalid;
        // }
        //else if (x == 0)
        //{
        //    Console.Error.WriteLine("x == 0");
        //    return invalid;
        //} else if (x > 0)
        //{
        //     return valid;
        // }
        //return valid;
        //}
        private int checkValue(Cardinal N)
        {
            int valid = 1;
            int invalid = 0;
            if (N.NUMBER == 0)
            {
                Console.Error.WriteLine("N == 0");
                // N = N;
                return invalid;
            }
            else if (N.NUMBER < 0)
            {
                Console.Error.WriteLine("N < 0");
                return invalid;
                // N = N;
            }
            else if (N.NUMBER > 0)
            {
                // N = N;
                return valid;
            }
            return valid;
        }
        private BFSState newState(Node Node, Node Neigh, ArrayList d)//ImmutableArray<int>
        {
            BFSState newState = default;
            newState = new BFSState(Node, Neigh, d, d.Count);

            return newState;
            //ImmutableArray<int> d = default(ImmutableArray<int>);
            //Stack q = default(Stack);
            //Cardinal N = default(Cardinal);
            //Node Node = default(Node);

            ////newState.Q = prev.Q;
            ////return;
            //if ((Object)prev == null)
            //{
            //    newState = default(BFSState);
            //}
            //else
            //{
            //    if (prev.D != null)
            //    {

            //        q = prev.Q; N = prev.N;
            //        Node = prev.NODE;
            //        newState = new BFSState()
            //    }
            //    else if (prev.D == null)
            //    {
            //        newState = default(BFSState);
            //        Console.Error.WriteLine("prev.D == null");
            //        //throw new Exception("prev == null");
            //        //newState = default(BFSState);
            //    }
            //}

        }
        //private ImmutableArray<int> initArray(int x, Cardinal N)
        //{

        //if (x >= 1)
        //{

        //    if (N.VALUE >= 0)
        //    {

        //    }
        //    else
        //    {
        //        if (N.VALUE < 0)
        //        {
        //            Console.Error.WriteLine("N < 0");
        //            return d;
        //        }
        //    }
        //}
        // }

        //else
        //{
        //    if (x < 1)
        //    {
        //        //Console.WriteLine("x == 1 not");
        //        Console.Error.WriteLine("x < 1");
        //        return d;
        //    }
        //}
        //return d;
        //}

        public int N { get; }
        public Edge EDGE { get; }
        //public Node<T> NODE { get; }
        public ArrayList D { get; }

        public static explicit operator ArrayList(BFSState state) => state.D;
        public static explicit operator BFSState(ArrayList list) => (BFSState)list;
        public static explicit operator BFSOutput(BFSState state) => new BFSOutput(state.D, state.N);
        public static explicit operator BFSState(BFSOutput output) => new BFSState(output.STATE);
        //public static explicit operator BFSState(BFSOutpu)

        public Object this[int index]
        {
            get
            {
                return D[index];
            }
            set
            {
                D[index] = value;
            }
        }
        //public Cardinal<T> N { get; }

        //public override string ToString() => $"({X})";

        //public override string ToString() => $"({Q})";
        public override string ToString() => $"({EDGE}, {D})";

    }
}
