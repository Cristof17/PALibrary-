using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.XPath;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    struct PASeries 
    {
        [DllImport("palibrary")]
        public static extern  PASeries PASeriesConstruct(PACount n, PAList[] adj);
        [DllImport("palibrary")]
        public static extern int PASeriesRuin(PACount n, PAList[] adj);
        [DllImport("palibrary")]
        public static extern PASeries PASeriesInit(PASeries s);
        [DllImport("palibrary")]
        public static extern void Dispose();
        [DllImport("palibrary")]
        public static extern int PASeriesDelete(PASeries PA);
        public PAList(PANod Head) 
            //: this()
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            //ADJ = default;
            //M = default;
            //N = default;
            head = default;
            Result = Check(Head);
            if (Result == Success)
            {
                head = Copy(Head);
                //Result = Check(M);
                //if (Result == Success)
                //{
                //    M = Copy(M);
                //    head = Copy(Head);
                //}
                //else if (Result == Fail)
                //{
                //    Console.Error.WriteLine("edges error");
                //}
            }
            else
            {
                Console.Error.WriteLine("Adj error");
            }
        }
        //public AdjacencyList(AdjacencyList Adj, Cardinal N)
        //{
        //    ADJ = default;
        //    ArrayList[] temp = default;
        //    if ((Object)Adj != null)
        //    {
        //        temp = Adj.ADJ;
        //        if (temp != null)
        //        {
        //            ADJ = new ArrayList[N];
        //            //int N = other.Length;
        //            int x = 0;
        //            int y = x + 1;
        //            while (x < N)
        //            {
        //                ADJ[x] = copy(Adj[x]);
        //                ADJ[x] = Adj[x];
        //                x++;
        //                y++;
        //            }
        //        }
        //        else if (temp == null)
        //        {
        //            Console.Error.WriteLine("Adj.ADJ == null");
        //            ADJ = default;
        //        }
        //    }
        //    else if ((Object)Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj == null");
        //        ADJ = default;
        //    }
        //    //while ()
        //    //ADJ = Adj;
        //}

        PANod Copy(PANod Head)
        {
            PANod copy;
            copy = new PANod(Head);
            return copy;
            //int x = 0;
            //ArrayList copy = new ArrayList(M);
            //while (x < M)
            //{
            //    copy[x] = Adj[x];
            //    x++;
            //}
            //;
            //return copy;
        }

        int Check(PANod Head)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (Head == null)
            {
                Console.Error.WriteLine($"{Head} == null");
                Result = Fail;
            }
            else if (Head != null)
            {
                Result = Success;
            }
            return Result;
        }

        int Copy(int M)
        {
            int copy;
            copy = M;
            return M;
        }

        int find(PANod nod)
        {
            int success = 0;
            int fail = -1;
            int result = fail;
            if (nod == head)
            {
                result = success;
            }
            else if (nod != head)
            {
                result = find(head.next,nod.next);
            }
            return result;
        }

        int find(PANod Source, PANod node)
        {
            int success = 0;
            int fail = -1;
            int result = fail;
            result = check(Source);
            if (result == fail)
            {
                result = fail;
            }
            else if (result == success)
            {
                result = find(Source.next, node);
            }
            return result;
        }

        int check(PANod node)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (node == null)
            {
                Result = Success;
            }
            else if (node != null)
            {
                Result = Fail;
            }
            return Result;
        }

        //public int this[int index]
        //{
        //    get
        //    {
        //        //re
        //        return 1;
        //    }
        //    set
        //    {
        //        //recursion
        //        //D[index] = value;
        //    }
        //    //}
        //    //    return (int)rezultat[index];
        //}
        //public int this[int index]
        //{
        //    int Neigh = (int) 
        //}
        //public AdjacencyList(ArrayList[] Adj, Cardinal N)
        //{
        //    ADJ = default;
        //    ArrayList[] temp = default;
        //    temp = new ArrayList[N];
        //    if (Adj != null)`
        //    {
        //        //int N = Adj.Length;
        //        int x = 0;
        //        int y = x + 1;
        //        while (x < N)
        //        {
        //            temp[x] = Adj[x];
        //            temp[x] = copy(Adj[x]);
        //            x++;
        //            y++;
        //        }
        //        ADJ = temp;
        //    }
        //    else
        //    {
        //        ADJ = default;
        //        Console.Error.WriteLine("Adj == null");
        //    }
        //    //while ()
        //    //ADJ = Adj;
        //}
        //public AdjacencyList(ArrayList[] Adj, int N)
        //{
        //    ADJ = default;
        //    ArrayList[] temp = default;
        //    temp = new ArrayList[N];
        //    if (Adj != null)
        //    {
        //        //int N = Adj.Length;
        //        int x = 0;
        //        int y = x + 1;
        //        while (x < N)
        //        {
        //            temp[x] = Adj[x];
        //            temp[x] = copy(Adj[x]);
        //            x++;
        //            y++;
        //        }
        //        ADJ = temp;
        //    }
        //    else
        //    {
        //        ADJ = default;
        //        Console.Error.WriteLine("Adj == null");
        //    }
        //    //while ()
        //    //ADJ = Adj;
        //}
        //public AdjacencyList(Node Node, Cardinal N)//,ArrayList Adj_node)
        //{
        //    //NODE = new Node<T>(Node.VALUE);
        //    //NODE = Node;
        //    ADJ = default;
        //    if (Node != null)
        //    {
        //        ADJ = new ArrayList[N];
        //        ArrayList temp = Node.ADJ;
        //        //int N = other.Count;
        //        int x = 0;
        //        int y = x + 1;
        //        while (x < N)
        //        {
        //            ADJ[Node][x] = temp[x];
        //            x++;
        //            y++;
        //        }
        //    }
        //    else if (Node == null)
        //    {
        //        ADJ = default;
        //        Console.Error.WriteLine("Node == null");
        //    }
        //}

        public int Check(int M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (M < 0)
            {
                Result = Fail;
            }
            else if (M == 0)
            {
                Result = Fail;
            }
            else if (M > 0)
            {
                Result = Success;
            }
            return Result;
        }
        //int Result = default;
        //int valid = 1;
        //int iv
        //int invalid = 0;
        //Result = valid;
        //Result - 
        //Result -
        //Result = checkAdjacencyList(Adj);
        //int i = 0;
        //int i = default;
        //int j = default;
        //int N = default;
        //Object o = default;
        // Object x , y = default(Object);
        //i = default(int);
        //j = default(int);
        //Obe
        //Object list
        //o = (Object)Adj_node;
        //if (o == null)
        //{
        //    //NODES = default(List,)
        //    //NODES = default(List<T>);
        //    Result = invalid;
        //    Console.Error.WriteLine("Adj == null");
        //    //return -1;
        //}
        //else if (o -)
        //            else if (o != null)
        //            {
        //                i = 1;
        //                j = i + 1;
        //                //M
        //                //M
        //                while (i < N)
        //                {
        //                    Object x = default;
        //                    if (x == null)
        //                    {
        //                        //Console.Err
        //                        Result = invalid;
        //                        Console.Error.WriteLine("list[" + i + "] == null");
        //                        i = j;
        //                        j = i + 1;
        //                    }
        //                    else if (x != null)
        //                    {
        //                        //NODES.Add(x);//[i]);
        //                        x = ADJ[i];//.NEIGH.VALUE;
        //                        i = j;
        //                        j = i + 1;
        //                    }
        //                        //Adj
        //                }
        //                if (Result == valid)
        //                {
        //                    ADJ = new ArrayList[1];
        //                    while (i < N)
        //                    {
        //                        //ADJ[i] = new Edge<T>(Node,new Node<T>(Adj[new Node<T>()]));
        //                        ADJ[i] = new ArrayList();
        //                        //new Node(Adj_node[i]);

        //                    }
        //                    i = j;
        //                    j = i + 1;

        ////                    NODES = new List<T>();
        ////                    i = 1;
        // //                   j = i + 1;
        // //                   N = Adj.NODES.Count;
        // //                   T x = default(T);
        //                }
        //                else if (Result == invalid)
        //                {
        //                    Console.Error.WriteLine("Cannot create AdjacencyList"); 
        //                }
        //{
        //Node Node = (Node)list[i];
        //if (np)
        //if (nd)
        //if (Node == null)
        //{
        //Console.Error.WriteLine("list["+i+"]" =
        //Console.Error.WriteLine("list[" + i + "] == null");
        //i = j;
        //j = i + 1;
        //}
        //else if (Node != null)
        //{
        //}
        //N = list.NODES.C;
        //while (i < N)
        //{
        //Object o = dfa
        //o = default(Object);
        //
        //o = list[i];
        //if (o == null)
        //{
        //Console.Error.WriteLine("Adj[" + i + "] = null");
        //return invalid;
        //}
        //else
        //{
        //i = j;
        //j = i + 1;
        //}
        //}
        //}
        //}
        //}
        //if (Result == -1)
        //{
        //NODES = Adj.NODES;
        //M
        //NODES = default(List<T>);
        //}
        //else
        //{
        //NODES = Adj.NODES;
        //}
        //if (Result == invalid)
        //{
        //NODES = default(List<T>);
        //}
        //else if (Result == valid)
        //{
        //NODES = copy(Adj[i]);
        //NODES -
        // NODES = Adj.NODES;
        //}
        //private static AdjacencyList<T> copy(AdjacencyList<T> Adj)
        //{
        //    AdjacencyList<T> Result = new AdjacencyList<T>();
        //    int x = 0;
        //    x = default(int);
        //    int y = default(int);
        //    int N = Adj.NODES.Count;
        //    while (x < N)
        //    {
        //        Result[x] = Adj[x];
        //        x = y;
        //        y = x + 1;
        //    }
        //    return Result;
        //}
        //public static explicit operator Object(AdjacencyList list) => list.ADJ; 
        //public ArrayList copy(ArrayList other)
        //{
        //    ArrayList copy = default;
        //    if (other == null)
        //    {
        //        return copy;
        //    }
        //    int N = other.Count;
        //    int x = 0;
        //    int y = x + 1;
        //    while (x < N)
        //    {
        //        copy.Add(other[x]);
        //        x++;
        //        y++;
        //    }
        //    return copy;
        //}

        private static int checkAdjacencyList(AdjacencyList list)
        {
            //int Result = default(int);
            int valid = 1;
            //int iv
            //int invalid = 0;
            //int i = default(int);
            //int j = default(int());
            //int j = default(int());
            //int i = 0;
            //int j = 0;


            //Object o = (Object)list[i];
            //N = list.Length;
            //N = list.Le
            //if (0 == null)
            //if (0 == null)
            //if (o == null)
            //{
            //    //Console.Err
            //    Console.Error.WriteLine("list == null");
            //    i = j;
            //    j = i + 1;
            //}
            //else if (o != null)
            //{
            //    //Node Node = (Node)list[i];
            //    //if (np)
            //    //if (nd)
            //    //if (Node == null)
            //    //{
            //    //Console.Error.WriteLine("list["+i+"]" =
            //    //Console.Error.WriteLine("list[" + i + "] == null");
            //    //i = j;
            //    //j = i + 1;
            //    //}
            //    //else if (Node != null)
            //    //{
            //    i = 1;
            //    j = i + 1;
            //    //}
            //    //N = list.NODES.C;
            //    //while (i < N)
            //    //{
            //    //Object o = dfa
            //    //o = default(Object);
            //    //
            //    //o = list[i];
            //    //if (o == null)
            //    //{
            //    //Console.Error.WriteLine("Adj[" + i + "] = null");
            //    //return invalid;
            //    //}
            //    //else
            //    //{
            //    //i = j;
            //    //j = i + 1;
            //    //}
            //    //}
            //}
            return valid;
        }
        //public AdjacencyList(ArrayList[] Adj)
        //public AdjacencyList(ArrayList Adj)
        ////public AdjacencyList(ArrayList[] Adj)
        //{
        //    //int x = Input;
        //    //int x = Input.N;
        //    ///int i = default(int);
        //    // = 1;
        //    //int j = default(int);
        //    //j = i + 1;
        //    ADJ = default;
        //    int valid = checkArrayList(Adj);
        //    if (valid == 1)
        //    {
        //        //ADJ = initNodes(1, Adj.Count, Adj);
        //    }
        //    else
        //    {
        //        ADJ = default;
        //    }
        //    //NODES = new List<Node>();
        //    //if (Adj != null)
        //    //{
        //    //initNodes(i, Adj.Count, Adj);
        //    //}
        //    ///else if (Adj == null)
        //    //
        //    //System.err.println("Adj == null");
        //    //Console.Error.WriteLine("Adj == null");
        //    //NODES = default();
        //    //throw new Exception("Adj == null");
        //    //}
        //    //NODES = nodes;
        //    //OUTPUT = output;
        //}
        public PANod this[int i]
        {
            get
            {
                PANod node = head;
                if (i == 1)
                {
                    node = head;
                    return head;
                }
                else if ((i != 1) && (i > 0))
                {
                    node = nodeAt(head, i - 1);
                    //return nodeAt(head, i - 1);
                }
                return node;
                //else
            }
            set
            {

            }
                //return head[i-1];
                //Node<int> x = default(Node<int>);
                //Node<int> y = default(Node<int>);
                //List<int>.Enumerator enumerator = ADJ.GetEnumerator();
                //while (enumerator.MoveNext())
                //{
                //int e = enumerator.Current;
                //if (e.CompareTo(i) == 0)
                //{
                //    Console.Out.WriteLine("(" + i.VALUE + "," + e.NODE.VALUE + ")");
                //    return e.NODE.VALUE;
                //}
                //else if (e.NODE.CompareTo(i) < 0 || e.NODE.CompareTo(i) > 0)
                //{
                //    Console.Out.WriteLine("(" + i.VALUE + "," + e.NODE.VALUE + ")");
                //}
                //}
                //return (int)ADJ[i];
                //recursion
        }


        PANod nodeAt(PANod Node, int position)
        {
            //check Node
            PANod node = Node;
            if (Node.next == null)
            {
                node = Node;
            }
            else if (Node.next != null)
            {
                PANod tmp = Node.next;
                if (position == 1)
                {
                    node = Node;
                }
                else
                {
                    node = nodeAt(Node.next, position - 1);
                }
            }
            return node;
        }

            //=> NODES[i];
            //set
            //{
            //    int Result = default;
            //    Result = checkType(value);
            //    int Success = 0;
            //    int Fail = -1;
            //    if (Result == Success)
            //    {
            //        ADJ[i] = new ArrayList();
            //        //new Node(value);
            //        ArrayList other = (ArrayList)value;
            //        int otherLength = other.Count;
            //        int x = 0;
            //        int y = x + 1;
            //        while (x < otherLength)
            //        {
            //            ADJ[i].Add(other[x]);
            //            x = x + 1;
            //            y = x + 1;
            //        }

            //    }
            //    //if (valid == 1)
            //    //{
            //    //    //T Node = (T) value;
            //    //    //ADJ[i] = value (Edge<T>) new Edge<T>();
            //    //}
            //}
        //}

        //public static int checkType(Object value)
        //    if (value is ArrayList)
        //    {
        //        return Fail;
        //    }
        //    return Success;
        //}
        //private static int checkArrayList(ArrayList list)
        //{
        //    int valid = 1;
        //    //int iv
        //    int invalid = 0;
        //    int i = default;
        //    //int j = default(int());
        //    //int j = default(int());
        //    //int i = 0;
        //    //int j = 0;
        //    int j = default;
        //    int N = default;
        //    i = default;
        //    j = default;
        //    //N = list.Length;
        //    //N = list.Le
        //    N = list.Count;
        //    i = 1;
        //    j = i + 1;
        //    while (i < N)
        //    {
        //        //Object o = dfa
        //        Object o = default;
        //        //
        //        o = list[i];
        //        if (o == null)
        //        {
        //            Console.Error.WriteLine("Adj[" + i + "] = null");
        //            return invalid;
        //        }
        //        else
        //        {
        //            i = j;
        //            j = i + 1;
        //        }
        //    }
        //    return valid;
        //}

        //private static ArrayList initNodes(int i, int j, ArrayList Adj)
        //{
        //    ArrayList nodes = default;
        //    nodes = new ArrayList();
        //    int x = default;
        //    int y = default;
        //    x = i;
        //    y = x + 1;
        //    while (x <= j)
        //    {
        //        nodes.Add(default);
        //        x = y;
        //        y = x + 1;
        //    }
        //    x = i;
        //    y = x + 1;
        //    while (x <= j)
        //    {
        //        //nodes[x] = new Node(((Node)Adj[x]).VALUE) ;
        //        nodes[x] = new Node(int.MaxValue);
        //        //new Node(((Node)Adj[x]).VALUE);
        //        x = y;
        //        y = x + 1;
        //    }
        //    return nodes;
        //}

        //private void initNode(int Node, int Neigh)
        //{
        //    NODES[Neigh].VALUE = -1;
        //}
        //public int M { get; }
        void set(PANod Source, PANod Parent,int position, PAData value)
        {
            if (Source == null)
            {

            }
            else if (Source != null)
            {
                if (position == 1)
                {
                    PAData data = new PAData();
                    data.value = value;
                    PANod nod = new PANod(data, Source.next);
                    Parent.next = nod;
                }
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        private PASeries list;

        // public PANod head { get; set; }
        //public ArrayList ADJ { get; }
        //public Output OUTPUT { get; }
        //public T NODE { get; }

        //        public override string ToString() => $"({ADJ}, {OUTPUT})";
        public override string ToString() => $"({head})";
        void adauga(PANod node)
        {
            if (head == null)
            {
                head = node;
            }
            else if (head != null)
            {
                PANod prev = head;
                while (head != null)
                {
                    head = head.next;
                    if (head == null)
                    {
                        prev.next = node;
                    }
                    else if (head != null)
                    {
                        prev = head;
                        PANod tmp = head;
                        head = tmp.next;
                    }
                }
            }
        }

        public int Count(PALista list)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Fail;
            int size = 0;
            if (list.head == null)
            {
                return Result;
            }
            else if (list.head != null)
            {
                PANod reference = head.next;
                PANod tmp = reference;
                reference = tmp.next;
                while (Result == Success)
                {
                    size++;
                    Result = Count(reference);
                    tmp = reference;
                    reference = tmp.next;
                }
            }
            return size;
        }

        int Count(PANod Node)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Fail;
            if (Node == null)
                Result = Fail;
            else if (Node != null)
                Result = Success;
            return Result;
        }

        public int Count()
        {
            PACardinal cardinal = 0;

            if (head == null)
            {
                cardinal = 0;
            }
            else if (head != null)
            {
                cardinal = 1;
                cardinal = cardinal + size(head, cardinal);
            }
            return cardinal;
        }

        public static int size(PANod Node, int Current)
        {
            //PANod current = Node;
            if (Node.next == null)
            {
                return Current;
            }
            else
            {
                return 1 + size(Node.next, Current - 1);
            }
        }

        public ArrayList toArrayList(PANod Node)
        {
            ArrayList lista = new ArrayList();
            lista.Add(Node);
            if (Node.next == null)
            {
                return lista;
            }
            else if (Node.next != null)
            {
                lista.AddRange(toArrayList(Node.next));
            }
            return lista;
        }
    }

}
