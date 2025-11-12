//@Author Cristofor Rotsching
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace PA_Library
{
    public readonly ref struct BFSInput
    //public readonly class BFSInput
    //public readonly class BFSInput
    //public readonly class BFSInput
    //public readonly struct
    //public readonly struct BFSInput //ș;.,l.
    {
        [MarshalAs(UnmanagedType.IDispatch)]
        public PACardinal n;
        [MarshalAs(UnmanagedType.IDispatch)]
        public PACardinal m;
        [MarshalAs(UnmanagedType.IDispatch)]
        public PALista[] adj;
        [MarshalAs(UnmanagedType.IDispatch)]
        public PANod sursa;

        public void Dispose()
        {
            
        }
        //Ț
        //Â?î?
        //mama{
        
        //Wrapper over the Input variables which provides Input validation
        BFSInput(PANod Source, PALista Adj, PACardinal N, PACardinal M)
        {
            //int valid = CheckSource(Source);
            //int Result = default;
            //Result = CheckSource(Source);
            //int valid = 1;
            //Result = valid;
            //int invalid = 0;
            //valid = 1;
            //if (Source < 0)
            //{
            this.n = default;
            this.m = default;
            this.adj = default;
            this.source = default;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = CheckSource(Source, Adj, N, M);
            if (Result == Fail)
            {
                //Source = default;
                //Console.Error.WriteLine("Source error");
            }
            else if (Result == Success)
            {
                Source = new PANod(Source,Source.next);
                //Console.Out.WriteLine($"Source {Source} ok");
            }
            Result = CheckNodeCardinal(Source, Adj, N, M);
            if (Result == Fail)
            {
                //N = default;
                //Console.Error.WriteLine($"number of nodes {N} error");
            }
            else if (Result == Success)
            {
                N = CopyNodeCardinal(Source, Adj, N, M);
                //Console.Out.WriteLine($"copy N={N} Success");
            }
            Result = CheckReferenceVector(Source, Adj, N, M);
            if (Result == Success)
            {
                adj = CopyVector(Source, Adj, N, M);//Adj;
                //Console.Out.WriteLine("check reference vector Success");
            }
            else if (Result == Fail)
            {
                ///Console.Error.WriteLine("Adj copy error");
            }
            Result = CheckEdgeCardinal(Source, Adj, N, M);
            if (Result == Success)
            {
                M = CopyEdgeCardinal(Source, Adj, N, M);
                //Console.Out.WriteLine($"copy M={M} Success");
                //M = M;
            }
            else if (Result == Fail)
            {
                //Console.Error.WriteLine($"number of edges {M} error");
            }

            ////int Success = 0;
            ////int Fail = -1;
            ////int Result = Success;
            //Result = Check(Source);
            //if (Result == Fail)
            //{
            //    Console.Error.WriteLine("Source error");
            //}
            //else
            //{
            //    Source = Copy(Source);
            //}

            //Result = Check(N);
            //if (Result == Fail)
            //{
            //    Console.Error.WriteLine("N error");
            //}
            //else
            //{
            //    Result = Check(Adj);
            //    if (Result == Fail)
            //    {
            //        Console.Error.WriteLine("Adj error");
            //    }
            //    else
            //    {
            //        ADJ = Copy(Adj, N);
            //    }
            //    N = Copy(N);
            //}
            //Result = Check(M);
            //if (Result == Fail)
            //{
            //    Console.Error.WriteLine("M error");
            //}
            //else
            //{
            //    M = Copy(M);
            //}
            //if ((Object)Adj == null)
            //{
            //    Console.Error.WriteLine($"{Adj} == null");
            //    Result = Fail;
            //}
            //else
            //{
            //    Result = Success;
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
            //    else
            //    {
            //        Result = Success;
            //        if (M < 0)
            //        {
            //            Console.Error.WriteLine($"{M} < 0");
            //            Result = Fail;
            //        }
            //        else if (M == 0)
            //        {
            //            Console.Error.WriteLine($"{M} == 0");
            //            Result = Fail;
            //        }
            //        else
            //        {
            //            Result = Success;
            //            Source = new Node(Source, Adj);
            //            ADJ = new AdjacencyList(Adj, N);
            //            N = new Cardinal(N);
            //            M = new Cardinal(M);
            //            //N = 
            //        }
            //    }
            //}
            //}
        }

        /**
         * checks the ArrayList[] vector of ArrayLists for null reference from the Input
        // */
        //public int CheckIndex(int Node, ArrayList[] Adj, int N, int M)
        //{
        //    int Result;
        //    int Fail = -1;
        //    int Success = 0;
        //    if (Node < 0)
        //    {
        //        Console.Error.WriteLine($"error {Node} > 0");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //        if (Node == 0)
        //        {
        //            Console.Error.WriteLine($"Node error {Node} < 0");
        //            Result = Fail;
        //        }
        //        else if (Node > 0)
        //        {
        //            Result = Success;
        //        }
        //        else
        //        {
        //            Console.Error.WriteLine($"Node error {Node}");
        //            Result = Fail;
        //        }
        //    }
        //    return Result;
        //}

        int CheckVector(PANod Source, PALista Adj, int N, int M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            int Node = 1;
            while (Node < N)
            {
                Result = CheckArrayList(Source, Adj, N, M);
                if (Result == Fail)
                {
                    //Console.Error.WriteLine($"Adj[{Node}] error");
                    return Result;
                }
                else if (Result == Success)
                {
                    Node++;
                }
                //if (Result == Success)
                //{
                //    //Node++;
                //    Result = Success;
                //}
                //else
                //{
                //    return Result;
                //    //Node++;
                //    //Result = Fail;
                //}
                //Node++;
            }
            return Result;
        }

        //copies the Input vector of array lissts in a newly creeated vector of array lists
        PALista CopyVector(PANod Source, PALista Adj, int N, int M)
        {
            PALista copy = new PALista(Source);
            //ArrayList[] Result;
            //ArrayList[] copy = new ArrayList[N];
            int Node = 1;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            int count = 0;
            //int Result;
            //int Success = 0;
            //int Fail = -1;
            //Result = new ArrayList[N];
            //Node = 1;
            //int M = Adj[x].Capacity;
            Result = CheckIndex(Source, Adj, N, M);
            if (Result == Success)
            {
                while (Node < N)
                {
                    Result = CheckIndex(Source, Adj, N, M);
                    if (Result == Success)
                    {
                        count = Size(Source, Adj, N, M);

                        copy[Node] = CopyArrayList(Source,Adj,N,M);
                    }
                    else if (Result == Fail)
                    {
                        //Console.Error.WriteLine($"Node {Node} error");
                    }
                    Node++;
                    //Result[x] = Copy(Adj[x], M);
                }
            }
            else if (Result == Fail)
            {
                //Console.Error.WriteLine($"Node {Node} and number of nodes {N}");
            }
            return copy;
        }
       
        //checks the reference of the vector of array lists ArrayList[]
        int CheckReferenceVector(PANod Source, PALista Adj, int N, int M)
        {
            int Result;
            int Success = 0;
            int Fail = -1;
            //int Neigh = 1;
            if (Adj == null)
            {
                //Console.Error.WriteLine($"Adj is null reference: {Adj}");
                Result = Fail;
            }
            else
            {
                Result = Success;
            }
            return Result;
        }
        //check the reference of the array list from the vector of array lists

        int CheckReferenceArrayList(PANod Source, PALista Adj, int N, int M)
        {
            int Result;
            int Success = 0;
            int Fail = -1;
            //int Neigh = 1;
            if (Adj[Source] == null)
            {
                //Console.Error.WriteLine($"Adj[{Source}] is null reference");
                Result = Fail;
            }
            else
            {
                Result = Success;
            }
            return Result;
        }

        //checks the values stored in the array list
        int CheckArrayList(PANod Source, PALista Adj, int N, int M)
        {
            int Result;
            int Success = 0;
            int Fail = -1;
            PAData data;
            data.value = 1;
            //= new PAData(1);
            PANod Neigh = new PANod(data, Source);//,PAStare.NOT_VISITED);
            Result = CheckReferenceArrayList(Source, Adj, N, M);
            if (Result == Success)
            {
                M = Size(Source, Adj, N, M);
                Result = CheckSource(Source, Adj, N, M);
                if (Result == Fail)
                {
                    //Console.Error.WriteLine($"Source {Source} error");
                    Result = Fail;
                }
                else if (Result == Success)
                {
                    while (Neigh < M)
                    {
                        Result = CheckIndex(Neigh, Adj, N, M);
                        if (Result == Success)
                        {
                            Result = CheckEdge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
                            if (Result == Fail)
                            {
                                //Console.Error.WriteLine($"Adj[{Neigh}] error");
                                return Result;
                            }
                            else if (Result == Success)
                            {
                                Neigh++;
                            }
                        }
                        else if (Result == Fail)
                        {
                            Result = Fail;
                            //Console.Error.WriteLine($"index {Neigh} error ");
                        }
                    }
                }
            }
            else if (Result == Fail)
            {
                //Console.Error.WriteLine($"Adj[{Source}] is null");
                Result = Fail;
                return Result;
            }
            return Result;
            //else if (Result == Fail)
            //{
            //    Console.Error.WriteLine("reference error");
            //}
            ////}
            //Result = Fail;
            //Neigh++;
            //Result = Success;
            //return Result;
            //return Result;
        }

        //        while (Neigh < M)
        //        {
        //            Result = CheckEdge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
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
        //            Result = CheckEdge(Source, Neigh, Adj, N, M);//(int)Adj[Neigh]);
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

        
        //returns the size of the array list specified by Source 
        int Size(PANod Source, PALista Adj, int N, int M)
        {
            int size = 0;
            size = PALista.size(Source,size);//.Capacity;
            return size;
            //int current = 0;
        }

        //public ArrayList[] CopyVector(int Source, ArrayList[] Adj, int N, int M)
        //{
        //    ArrayList[] Result = new ArrayList[N];
        //    int Node = 1;
        //    while (Node < N)
        //    {
        //        int count = Size(Node, Adj, N, M);
        //        Result[Node] = CopyArrayList(Source, Adj, N, count);
        //        Node++;
        //    }
        //    return Result;
        //}
        
        // copies the array list from the Input list of array lists specified by Source
        PANod CopyArrayList(PANod Source, PALista Adj, int N, int M)
        {
            PANod Result = new PANod(Source);
            PANod Neigh =(PANod) 1;
            int i = 1;
            while (i < M)
            {
                Result[Neigh] = CopyEdge(Source, Neigh, Adj, N, M);
                i++;
            }
            return Result;
        }

        //copies the value from the array list for the specified Node array list and Neigh value position
        PANod CopyEdge(PANod Node, PANod Neigh, PALista Adj, int N, int M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            PANod copy;
            copy = Adj[Node][Neigh];
            return copy;
        }
        //copies the array list specified by the Source
        ArrayList Copy(PANod Source, PALista Adj, PACardinal N, PACardinal M)
        {
            ArrayList Result = new ArrayList(M);
            PANod Neigh = (PANod) 1;
            while (Neigh < M)
            {
                Result[Neigh] = Copy(Source, Neigh, Adj, N, M);
                Neigh++;//Neigh = Neigh + 1 Neigh.operator+(1)
            }
            return Result;
        }
        //copies the value from the array list specified by Node and the value specified by value
        int Copy(PANod Node, PANod Neigh, PALista Adj, PACardinal N, PACardinal M)
        {
            int copy;
            copy = (int)Adj[Node][Neigh];
            return copy;
        }
        //checks the given index greater than 0 and less than N
        int CheckIndex(PANod Node,PALista Adj, PACardinal N, PACardinal M)
        {
            int Fail = -1;
            int Success = 0;
            int Result = Fail;

            if (Node < N) {
                //return Fail;
                //Console.Error.WriteLine($"{Node} < {N}");
                Result = Fail;
            }
            if (Node == 0)
            {
                Result = Fail;
                //Console.Error.WriteLine($"{N} == 0");
            }
            else if (Node < 0)
            {
                Result = Fail;
                //Console.Error.WriteLine($"{Node} < 0");
                //return Fail;
            }
            else if (Node > 0)
            {
                Result = Success;
            }
            //else
            //{
            //    return Success;
            //}
            return Result;
        }       
        //checks the Source value of the Node greater than 0 and less than N
        int CheckSource(PANod Source, PALista Adj, PACardinal N, PACardinal M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (Source == null)
            {
                return Fail;
            }
            else if (Source != null)
            {
                Result = Success;
            }
            if (Source < 0)
            {
                Result = Fail;
                //Console.Error.WriteLine($"{Source} < 0");
                //Result = Success;
                //resul
            }
            else if (Source == 0)
            {
                Result = Fail;
                //Console.Error.WriteLine($"{Source} == 0");
            }
            else if (Source > 0)
            {
                Result = Success;
                //Console.Out.WriteLine($"{Source} > 0");
            }
            if (Source < n)
            {
                Result = Success;
                //Console.Out.WriteLine($"{Source} < {N}");
            }
            else if (Source == n)
            {
                Result = Success;
                //Console.Out.WriteLine($"{Source} == {N}");
                //Console.Error.WriteLine($"Source={Source} == N={N}");
            }
            else if (Source > n)
            {
                //Result = Success;
                Result = Fail;
                //Console.Error.WriteLine($"Source={Source} > N={N}");
            }
            return Result;
        }

        //checks the value given by the Node array list and the Neigh value in the array lust
        int CheckEdge(PANod Node, int index, PALista Adj, int N, int M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            //int Neigh = (int)Adj[Node][index];
            if (Node < 0)
            {
                //Console.Error.WriteLine($"{Neigh} < 0");
                Result = Fail;
            }
            else if (Node == 0)
            {
                //Console.Error.WriteLine($"{Neigh} == 0");
                Result = Fail;
            }
            else if (Node > 0)
            {
                Result = Success;
            }
            return Result;
        }
        //checks the given vector of array lists 
        int Check(   PANod Source, PALista Adj, int N, int M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (Adj == null)
            {
                //Console.Error.WriteLine($"{Adj} is null reference");
                Result = Fail;
                return Result;
            }
            else
            {
                Result = CheckVector(Source, Adj, N, M);
            }
            return Result;
        }
        
        //checks the Node cardinal N
        int CheckNodeCardinal(PANod Source, PALista Adj, PACardinal N, PACardinal M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            //nt32 edge = (int)Adj[Node][Neigh];
            if (N < 0)
            {
                //Console.Error.WriteLine($"{N} < 0");
                Result = Fail;
            }
            else if (N == 0)
            {
                //Console.Error.WriteLine($"{N} == 0");
                Result = Fail;
            }
            else if (N > 0)
            {
                Result = Success;
            }
            return Result;
        }

        //checks the edge cardinal M
        int CheckEdgeCardinal(PANod Source, PALista Adj, int N, int M)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            //nt32 edge = (int)Adj[Node][Neigh];
            if (N < 0)
            {
                //Console.Error.WriteLine($"{N} < 0");
                Result = Fail;
            }
            else if (N == 0)
            {
                //Console.Error.WriteLine($"{N} == 0");
                Result = Fail;
            }
            else if (N > 0)
            {
                Result = Success;
            }
            return Result;
        }

        //returns a copy of the Node cardinal
        int CopyNodeCardinal(PANod Source, PALista Adj, int N, int M)
        {
            int Result = 0;
            Result = N;
            return Result;
            //int Fail = -1;
            //int Result = Success;
            ////nt32 edge = (int)Adj[Node][Neigh];
            //if (N < 0)
            //{
            //    Console.Error.WriteLine($"{N} < 0");
            //    Result = Fail;
            //}
            //else if (N == 0)
            //{
            //    Console.Error.WriteLine($"{N} == 0");
            //    Result = Fail;
            //}
            //else if (N > 0)
            //{
            //    Result = Success;
            //}
            //return Result;
        }

         //returns a copy of the edge cardinal
        int CopyEdgeCardinal(PANod Source, PALista Adj, int N, int M)
        {
            int Result = 0;
            Result = M;
            return Result;
            //int Fail = -1;
            //int Result = Success;
            ////nt32 edge = (int)Adj[Node][Neigh];
            //if (N < 0)
            //{
            //    Console.Error.WriteLine($"{N} < 0");
            //    Result = Fail;
            //}
            //else if (N == 0)
            //{
            //    Console.Error.WriteLine($"{N} == 0");
            //    Result = Fail;
            //}
            //else if (N > 0)
            //{
            //    Result = Success;
            //}
            //return Result;
        }


        //public int Check(ArrayList[] Adj)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Adj == null)
        //    {
        //        Console.Error.WriteLine($"{Adj} == null");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}

        //public int Check(int Source)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    if (Source < 0)
        //    {
        //        Console.Error.WriteLine($"{Source} < 0");
        //        Result = Fail;
        //    }
        //    else if (Source == 0)
        //    {
        //        Console.Error.WriteLine($"{Source} == 0");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Success;
        //}

        //public ArrayList[] Copy(ArrayList[] Adj, int N)
        //{
        //    ArrayList[] copy;
        //    copy = new ArrayList[N];
        //    int x = 0;
        //    while (x < N)
        //    {
        //        copy[x] = Adj[x];
        //        x++;
        //    }
        //    return copy;
        //}

        //public int Copy(int Source)
        //{
        //    int copy;
        //    copy = Source;
        //    return copy;
        //}
        //else
        //{
        //    //Result = Success;
        //    //Console.Error.WriteLine("Adj == null");
        //    //return Fail;
        //}
        //}
        ////Result = Check(Source);
        //if (Result == Success)
        //{
        //    Result = Check(Adj);
        //    if (Result == Success)
        //    {
        //        Result = Check(N);
        //        if (Result == Success)
        //        {
        //            Result = Check(M);
        //            if (Result == Success)
        //            {

        //            }
        //        }
        //        else
        //        {

        //        }
        //    }
        //    else
        //    {

        //    }
        //}
        //    else
        //    {

        //    }
        //    Source = default;
        //    N = default;
        //    ADJ = default;
        //    M = default;
        //    Source = new Node(Source,Adj);
        //    ADJ = new AdjacencyList(Adj, N);
        //    N = new Cardinal(N);
        //    M = new Cardinal(M);
        //}
        //if (Source >= 0) {
        //Source = (Source);
        // Console.Error.WriteLine("Source < 0");
        //}
        //else if (Source == 0)
        //{
        //Source = default;
        //Console.Error.WriteLine("Source == 0"()
        //Console.Error.WriteLine("Source == 0");
        //return invalid;
        //}
        //else if (Source < 0)
        //{
        //Source = default;
        //Console.Error.WriteLine("Source < 0");
        //}
        //return invalid;
        //} else if (Source > 0)
        //{
        //}
        //if (w)
        //if ((Object)Adj == null)
        //{
        //Console.Error.WriteLine("Adj == null");
        //ADJ = default(AdjacencyList);
        //return invalid;
        //}
        //else if ((Object)Adj != null)
        //else if ( Adj !-)
        //{
        //ADJ = new AdjacencyList();
        //int Source;
        //Source = 
        //int
        //int x = default;
        //int y = default;
        //int i = default(int);
        //int j = default(int);
        //x = 1;
        //y = x + 1;
        //int N = V
        //N
        //N = N.VALUE;
        //int N = Adj.Length;
        //while (x < N)
        //{
        //ArrayList 
        //if (Adj[x] == null)
        //{
        //Console.Error.WriteLine("Adj[" + o)
        //Console.Error.WriteLine("Adj[" + x + "] == null");
        //ADJ[x] = default(T);
        //ADJ[x] = default(AdjacencyList<int>);
        //ret
        //reusl
        //Result - 
        //return invalid;
        //Result = invalid;
        //}
        //else if (Adj[x] != null)
        //{
        //int valid = 1;
        //int iv
        //int invalid = 0;
        //x = y;
        //y = x + 1;
        //x = default(int);
        //int i = 1;
        //int j = i + 1;
        //int k = Adj[x].Count;
        //while (i < k)
        //{
        //Object o = dfa
        //Object o = default(Object);
        ////
        //o = Adj[x][i];
        //if (o == null)
        //{
        //    Console.Error.WriteLine("Adj[" + i + "][" + x + "] == null");
        //    //ADJ.ElementAt(x).ADJ.RemoveAt(i);
        //    //ADJ.ElementAt(x).ADJ.Insert(i, default(Node<int>));
        //    //return invalid;
        //    i = j;
        //    j = i + 1;
        //}
        //else if (o != null)
        //{
        //    i = j;
        //    j = i + 1;
        //}
        //Result = checkArrayList(Adj[i]);
        //ArrayList arrayList = Adj[i];
        //return checkAdjacencyList(Adj[i]);
        //i = j;
        //j = i + 1;
        //if (Result == invalid)
        //{
        //    //Console.Error.WriteLine("error Adj[" + i + "]");
        //}
        //else if (Result == valid)
        //{
        //i = j;
        //j = i + ;1
        //j = i + 1;
        //}
        //    }
        //}
        //if (valid == 1)
        //{
        //    ADJ = new AdjacencyList();
        //}
        //else if (valid == 0)
        //{
        //    //if (valid == 0)
        //    //{
        //    ADJ = default;
        //    //}
        //}
        ////N = check
        ////valid = chc
        //valid = checkValue(N.NUMBER);
        //if (valid == 1)
        //{
        //    N = new Cardinal(N.NUMBER);
        //}
        //else if (valid == 0)
        //{
        //    N = default;
        //}
        //valid = checkValue(M.NUMBER);
        //if (valid == 1)
        //{
        //    M = new Cardinal(M.NUMBER);
        //}
        //else if (valid == 0)
        //{
        //    M = default;
        //}
        //valid = checkAdjacencyList(Adj);
        //if (valid == 1)
        //{
        //    //NEIGH = initAdjacencyList(Adj);
        //return valid;
        //if (valid == 1)
        //{
        //Source = new Source(Source);

        //}
        //else
        //{

        //
        //valid = checkAdjacencyList(Adj);
        //}
        //} 
        //}
        //}
        //else
        //{
        //    Console.Error.WriteLine("Error: Adj");
        //}
        //NEIGH = (List<AdjacencyList<Node>) new ArrayList();
        //Source = new Source(Source);
        //}

        //        if (N< 0)
        //                {
        //                    Console.Error.WriteLine("N < 0");
        //                    //BfsOutput = default(BFSOutput);
        //                    Result = invalid;
        //                }
        //                else if (N == 0)
        //                {
        //                    Console.Error.WriteLine("N == 0");
        //                    Result = invalid;
        //                }
        //                else if (N != 0)
        //{
        //int Source = Input.Source.VALUE;
        //int N = Input.N.VALUE;
        //pu
        //private int initAdjacencyList(ArrayList[] Adj)
        //private AD initAdjacencyList(ArrayList[] Adj)
        //private List<AdjacencyList<Nio initAdjacencyList(ArrayList[] Adj)

        //private int CheckSource(Node Source)
        //{

        //}
        //private int Check(AdjacencyList Adj)
        //{
        //    int Fail = -1;
        //    int Success = 0;
        //    int Result = Success;
        //    if ((Object)Adj == null)
        //    {
        //        Console.Error.WriteLine("Adj == null");
        //        return Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //        //Console.Error.WriteLine("Adj == null");
        //        //return Fail;
        //    }
        //    return Result;
        //}

        //public int Check(Node Source)
        //{
        //    int Fail = -1;
        //    int Success = 0;
        //    int Result = Success;
        //    if (Source < 0)
        //    {
        //        Console.Error.WriteLine($"{Source} < 0");
        //        Result = Fail;
        //    }
        //    else if (Source == 0)
        //    {
        //        Console.Error.WriteLine($"{Source} == 0");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}
        //private List<AdjacencyList> initAdjacencyList(ArrayList[] Adj)

        //{
        //    //List<AdjacencyList<Node>> Adj = default(List<AdjacencyList<Node>>;// ())
        //    //List<AdjacencyList<Node>> Adj = default(List<AdjacencyList<Node>>);
        //    List<AdjacencyList> AdjacencyList = default;
        //    int valid = 1;
        //    //int invalid = 0;
        //    int N = Adj.Length;
        //    //int i = 0;
        //    int i = default;
        //    int j = default;
        //    AdjacencyList = new List<AdjacencyList>();
        //    while (i < N)
        //    {
        //        AdjacencyList[i] = new AdjacencyList();
        //        i = j;
        //        j = i + 1;
        //    }
        //    while (i < N)
        //    {
        //        //AdjacencyList(i)
        //        //AdjacencyList[i] = initAdjacencyList(Adj[i]);
        //        //int valid = default(int);
        //        valid = checkArrayList(Adj[i]);
        //        if (valid == 1)
        //        {
        //            //AdjacencyList[i] = moveElements(Adj[i]);
        //            AdjacencyList[i] = initAdjacencyList(Adj[i]);
        //        }
        //        else
        //        {
        //            //Console.Error.WriteLine("Adj["+i+"]"
        //        }
        //        //alloc
        //        //move
        //        //AdjacencyList[i]=,
        //        //moveArray(Adj[i],adk)
        //    }
        //    //while )
        //    //while (i ,)
        //    //while (i < N)
        //    //{
        //    //    ADJ
        //    //}
        //    return AdjacencyList;
        //}

        //private AdjacencyList<Node> from
        //private AdjacencyList<Node> moveElemene
        //private ArrayList moveElements(ArrayList list)
        //{
        //    ArrayList Adj = default;
        //    //int
        //    //Int32n
        //    Node i = default;
        //    int x = 1;
        //    int y = x;
        //    //i = new Node<int>(1);
        //    Node j = default;
        //    //int j = default(int);
        //    Node N = new Node();
        //    while (i < N)
        //    {
        //        Adj[i] = new ArrayList();
        //        //Adj[i] = new Node(list[i]);
        //            //new Node<T>(Adj[i]);
        //        x = y;
        //        y = x + 1;
        //    }
        //    return Adj;
        //}
        //}
        //private AdjacencyList<Node> ad
        //private AdjacencyList initAdjacencyList(ArrayList Adj)
        //{
        //    //int AdjacencyList<Node> AdjaccencyList;
        //    //int AdjacencyList<Node> AdjacencyList;
        //    //AdjacencyList<Node> AdjacencyList;
        //    AdjacencyList AdjacencyList = default;
        //    //AdjacencyList = moveElements(Adj);
        //    return AdjacencyList;
        //    //int AdjacencyList<Node> AdjacencyList;
        //    //Adjace
        //}
        //private static int checkArrayList(ArrayList list)
        //{
        //    int valid = 1;
        //    //int iv
        //    int invalid = 0;
        //    int i = default(int);
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
        //private static int checkValue(int value)
        //{
        //    int valid = 1;
        //    int invalid = 0;
        //    if (value > 0)
        //    {
        //        //if (Source < N)
        //        //{
        //        //    //do nothing
        //        //}
        //        ////return valid;
        //        //else if (Source == 0)
        //        //{
        //        //    Console.Error.WriteLine("Source == N");
        //        //    Result = invalid;
        //        //}
        //        //else if (Source > N)
        //        //{
        //        //    Console.Error.WriteLine("Source > N");
        //        //    Result = invalid;
        //        //}
        //        ////return valid;
        //        //sreturn valid;
        //        return valid;
        //    }
        //    else if (value == 0)
        //    {
        //        Console.Error.WriteLine("value == 0");
        //        //Result = invalid;
        //        return invalid;
        //    }
        //    else if (value < 0)
        //    {
        //        Console.Error.WriteLine("value < 0");
        //        //Result = invalid;
        //        return invalid;
        //    }
        //    return valid;
        //}

        // private static int checkVaklue(int value()
        // {
        //

        //public BFSInput(int Source, ArrayList<Adja>  neighbors, Cardinal N, Cardinal M)
        //public BFSInput(int Source, ArrayList<> Adj<AdjacencyList<Node>> neighbors, Cardinal N, Cardinal M)
        //{

        //}
        //public BFSInput(Node Source, AdjacencyList neighbors, Cardinal N, Cardinal M)
        //{
        //    //D = d;
        //    Source = Source;
        //    ADJ = neighbors;
        //    N = N;
        //    M = M;
        //    //M = new Cardinal(neighbors.LongLength);
        //    // X = x;
        //    //OUTPUT = output;
        //}
        //private static int checkAdjacencyList(AdjacencyList Adj)
        //{
        //int Result = default
        //int Result = default(int);
        //    int valid = 1;
        //    //int invalid = 0;

        //        return valid;
        //    //}
        //    //return valid;
        //}

        //private static int checkAdjacencyList(ArrayList[] Adj, Cardinal N)
        //{

        //return valid;
        //}
        //{
        //return valid
        //}
        //return valid;
        //}
        //public static int checkAdjacencyList(ArrayList Adj)
        //44

        // public ArrayList D { get; }
        public PACardinal n;
        public PACardinal m;
        PALista adj;
        PANod source;
        //public int Source { get; }
        //public ArrayList[] ADJ { get; }
        //public int N { get; }
        //public int M { get; }

        //public override string ToString() => $"({N})";
        //public override string ToString() => $"({N},{ADJ})";
        public override string ToString() => $"({source},{adj},{n},{m})";


        //private int checkAdjacencyList(ArrayList list)
        //{
        //    int valid = 1;
        //    int invalid = 0;
        //    //int i = 0 ;
        //    int i = default(int);
        //    int j = default(int);
        //    int N = list.Count;
        //    while (i < N)
        //    {
        //        if (list[i] == null)
        //        {
        //            Console.Error.WriteLine("list[" + i + "] == null");
        //            return invalid;
        //        }
        //        else
        //        {
        //            //i = KeyNotFoundException;
        //            i = j;
        //            j = i + 1;
        //        }
        //        //else
        //        //{

        //        //}
        //    }
        //    return valid;
        //}


        //throw new NotImplementedException();

    }



    //private static int CheckSource(int Source)
    //    {

    //    }

    //private static Intr
    /*
public static Cardinal cardinal_edges(AdjacencyList[] neighbors)
    {
        Cardinal cardinal = default(Cardinal);

    }
    */
    //class BFSInput<T> : Input<T>
    //{
    //    public Node<T> Source;
    //}
}
    