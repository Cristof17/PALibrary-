using System;
using System.Collections.Generic;
using System.Text;

namespace PA_Library
{
//    internal class Node<T> : Comparer<T>
//    {
//        protected internal T Value;
//        public override int Compare(T a, T b)
//        {
//            Type type = a.GetType();
//            Type typeB = b.GetType();

//            if (typeof(T) == typeof(int))
//            {
//                int t = (int)(Object)a;
//                int u = (int)(Object)b;
//                if (t == 0)
//                    return 0;
//                if (t < u)
//                    return -1;
//                if (t > u)
//                    return 1;
//            }
//            return 0;
//        }
//    }
//}
//using PA_Library;
using System;
using System.Collections;
using System.Reflection;

//Console.WriteLine("Hello world!");

namespace PA_Library
{
    //class YourClass
    //{
    //}
    // [LibraryImport("pa-library.dll")]
    // public Node(Object Index)
    // {
    //     //int invalid = 0;
    //     int Success = 0;
    //     int Fail = -1;
    //     int Result = Success;
    //     INDEX = default;
    //     ADJ = default;
    //     M = default;
    //     Result = Check(Index);
    //     //if (checkInput(o) == valid)
    //     if (Result == Success)
    //     {
    //         INDEX = (int)Index;
    //     }
    //     else if (Result == Fail)
    //     {
    //         Console.Error.WriteLine("index error ");
    //         INDEX = default;
    //     }

    // }
    // [DllImport("palibrary.pa")]
    // public static extern void PANodInit();

    [StructLayout(LayoutKind.Sequential)]
    public struct Node
    {    
        public int Check(Object O)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            if (O == null)
            {
                Console.Error.WriteLine($"{O} == null");
                Result = Fail;
            }
            else
            {
                Result = Success;
            }
            return Result;
        }
        public Node(Node Node)
        {
            INDEX = default;
            ADJ = default;
            M = default;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = Check(Node);
            if (Result == Success)
            {
                Result = Check(Node.INDEX);
                if (Result == Success)
                {
                    INDEX = Copy(Node.INDEX);
                }
                else if (Result == Fail)
                {
                    Console.Error.WriteLine("Index error");
                }
                Result = Check(Node.M);
                if (Result == Success)
                {
                    M = Copy(Node.M);
                    Result = Check(Node.ADJ);
                    if (Result == Success)
                    {
                        ADJ = Copy(Node.ADJ, Node.M);
                    }
                    else if (Result == Fail)
                    {
                        Console.Error.WriteLine("Adj error");
                    }
                }
                else if (Result == Fail)
                {
                    Console.Error.WriteLine("M error");
                    M = default;
                    ADJ = default;
                }

            }
            else if (Result == Fail)
            {
                Console.Error.WriteLine("Node error");
            }
            //ArrayList temp = default;
            ////IEnumerator enumerator = other.GetEnumerator();
            //INDEX = Node.INDEX;
            //temp = Node.ADJ;
            //int other = Node.INDEX;
            //ADJ = copy(other,temp);
            //M = Node.M;
            //if (Node != null)
            //{
            //if (other == null)
            //{
            //    NEIGH = default(AdjacencyList<Node<T>>);
            //} else if (other != null)
            //{
            //}
            //}
            //else if (Node == null)
            //{
            //    VALUE = default(T);
            //}
        }
        public Node(int Index)
        {
            //VALUE = (value == int.MaxValue) ? int.MaxValue : value;
            INDEX = default;
            ADJ = default;
            M = default;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = Check(Index);
            if (Result == Fail)
            {
                Console.Error.WriteLine("index error");
                Result = Fail;
            }
            else if (Result == Success)
            {
                INDEX = Index;
            }
            //if  (value != null)
            //{
            //    VALUE = value;
            //}
            //if (value == null)
            //{
            //    Console.Error.WriteLine("value == null");
            //    VALUE = default(T);
            //}
            //if (value == int.MaxValue)
            //    ;
            //else
            //    VALUE = value;
            //if (value > Inr32.)
            //VALUE = value;
            //OUTPUT = output;
        }



        public Node(int Index, AdjacencyList Adj, int M) : this()
        {
            INDEX = default;
            ADJ = default;
            M = default(int);
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = Check(Index);
            if (Result == Fail)
            {
                Console.Error.WriteLine("index error");
            }
            else if (Result == Success)
            {
                INDEX = Index;
            }
            Result = Check(Adj);
            if (Result == Fail)
            {
                Console.Error.WriteLine("Adj error");
            }
            else if (Result == Success)
            {
                ADJ = Copy(Adj, M);
            }
            //Result = check(index);
            //if (Result == Fail)
            //{
            //    ;
            //}
            //Result = check(Adj);
            ////else
            ////{
            //if (Result == Fail)
            //{
            //    ;
            //}
            //}
            INDEX = default;
            ADJ = default;
            M = default;
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
            else if (N == 0)
            {
                Console.Error.WriteLine($"{N} == 0");
                Result = Fail;
            }
            else if (N > 0)
            {
                Result = Success;
            }
            return Result;
        }

        public Node(int Index, ArrayList Adj, int M) : this()
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            INDEX = default;
            M = default;
            ADJ = default;
            Result = Check(Index);
            if (Result == Fail)
            {
                Console.Error.WriteLine("index error");// INDEX = default;
            }
            else if (Result == Fail)
            {
                INDEX = Copy(Index);
            }
            Result = Check(M);
            if (Result == Fail)
            {
                Console.Error.WriteLine("M number error");
                //M = default;
            }
            else if (Result == Success)
            {
                M = Copy(M);
                //M = new Cardinal(M);
            }
            Result = Check(Adj);
            if (Result == Fail)
            {
                Console.Error.WriteLine("Adj error");
                //ADJ = default;
            }
            else if (Result == Success)
            {
                ADJ = Copy(Adj, M);
            }
        }

        public int Check(ArrayList Adj)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = Success;
            if (Adj == null)
            {
                Console.Error.WriteLine($"{Adj} == null");
                Result = Fail;
            }
            else if (Adj != null)
            {
                Result = Success;
            }
            return Result;
        }

        //public int check(int index)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    Result = Fail;
        //    if (index < 0)
        //    {
        //        Console.Error.WriteLine($"{index} < 0");
        //        Result = Fail;
        //    }
        //    else if (index > 0) {
        //    {
        //        Result = Success;
        //    }
        //    if (index == 0)
        //    {
        //        Console.Error.WriteLine($"{index} == 0");
        //        Result = Fail;
        //    }
        //    else if (index != 0)
        //    {
        //        Result = Success;
        //    }
        //    if (index > 0)
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}
        /*
        public Node(int index, AdjacencyList Adj)
        {
            INDEX = default;
            ADJ = default;
            M = default;
            INDEX = index;
            ArrayList[] temp = default;
            //int Result = checkSource(index)
            //VALUE = (value == int.MaxValue) ? int.MaxValue : value;
            temp = Adj.ADJ;// new AdjacencyList(Neigh);
            ADJ = copy(index,temp);
        }*/

        //public int check(int M)
        //{
        //    int Success = 0;
        //    int Fail = -1;
        //    int Result = Success;
        //    Result = Fail;
        //    if (M < 0)
        //    {
        //        Result = Fail;
        //        Console.Error.WriteLine($"{M} < 0");

        //    }
        //    else if (M == 0)
        //    {
        //        Result = Fail;
        //        Console.Error.WriteLine($"{M} == 0");

        //    }
        //    else if (M > 0)
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}
        public ArrayList Copy(AdjacencyList Adj, int M)
        {
            ArrayList copy = default;
            copy = new ArrayList(M);
            int x = 0;
            while (x < M)
            {
                copy[x] = Adj[x];
                x++;
            }
            return copy;
        }
        public ArrayList Copy(ArrayList Adj, int M)
        {
            ArrayList copy = default;
            copy = new ArrayList(M);
            int x = 0;
            while (x < M)
            {
                copy[x] = Adj[x];
                x++;
            }
            return copy;
        }
        public int Copy(int Index)
        {
            int copy = default;
            copy = Index;
            return copy;
        }

        //public call[int index]

        public ArrayList Copy(int Node, ArrayList Adj)
        {
            ArrayList copy = default;
            ArrayList temp = Adj;
            if (temp == null)
            {
                return copy;
            }
            int N = Adj.Count;
            int x = 0;
            int y = x + 1;
            while (x < N)
            {
                copy.Add(temp[x]);
                x++;
                y++;
            }
            return copy;
        }
        public ArrayList Copy(int Node, ArrayList[] Adj)
        {
            ArrayList copy = default;
            ArrayList temp = Adj[Node];
            if (temp == null)
            {
                return copy;
            }
            int N = Adj[Node].Count;
            int x = 0;
            int y = x + 1;
            while (x < N)
            {
                copy.Add(temp[x]);
                x++;
                y++;
            }
            return copy;
        }

        public int M;
        public int INDEX { get; }
        public ArrayList ADJ { get; }

        public static implicit operator byte(Node D) => (byte)D.INDEX;
        public static explicit operator Node(byte B) => new Node(B);
        public static implicit operator int(Node D) => (int)D.INDEX;
        public static explicit operator Node(int B) => new Node(B);
        public static implicit operator long(Node D) => (long)D.INDEX;
        public static explicit operator Node(long B) => new Node(B);
        public static implicit operator short(Node D) => (short)D.INDEX;
        public static explicit operator Node(short B) => new Node(B);
        public static implicit operator ushort(Node D) => (ushort)D.INDEX;
        public static explicit operator Node(ushort B) => new Node(B);
        public static implicit operator ulong(Node D) => (ulong)D.INDEX;
        public static explicit operator Node(ulong B) => new Node(B);
        public static Node operator -(Node A) => new Node(-A.INDEX);

        public static Node operator +(Node A, Node B)
            => new Node(A.INDEX + B.INDEX);

        public static Node operator -(Node A, Node B)
            => new Node(A.INDEX + (-B.INDEX));

        public static Node operator *(Node A, Node B)
            => new Node(A.INDEX * B.INDEX);

        public static Node operator /(Node A, Node B)
        {
            if (B.INDEX == 0)
            {
                throw new DivideByZeroException();
            }
            return new Node(A.INDEX * B.INDEX);
        }

        public override bool Equals(Object O)
        {
            return O == (Object)this;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator <(Node A, Node B)
        {
            return A.INDEX < B.INDEX;
        }
        public static bool operator >(Node A, Node B)
        {
            return A.INDEX > B.INDEX;
        }
        public static bool operator ==(Node A, Node B)
        {
            return A.INDEX == B.INDEX;
        }
        public static bool operator !=(Node A, Node B)
        {
            return A.INDEX < B.INDEX;
        }
        public static bool operator >=(Node A, Node B)
        {
            return A.INDEX >= B.INDEX;
        }
        public static bool operator <=(Node A, Node B)
        {
            return A.INDEX < B.INDEX;
        }
        //public static implicit operator bool <(Node<T> d, Node<T> b) { return true };
        //public static explicit operator Node<T>(ulong b) => new Node<T>(b);
        //public static implicit operator byte(Node<T> d) => (byte)d.VALUE;
        //public static explicit operator Node<T>(byte b) => new Node<T>(b);
        //public static explicit operator Node<T>(byte b) => new Node<T>(b);
        //public static explicit operator bool <(Node<int> i, Node<int> j) => (i.VALUE<j.VALUE);}
        //public static explicit operator bool >(byte b) => new Node<T>(b);
        //public static explicit operator bool ==(byte b) => new Node<T>(b);
        //public static explicit operator bool <=(byte b) => new Node<T>(b);
        //public static explicit operator bool >=(byte b) => new Node<T>(b);


        public override string ToString() => $"({INDEX},{ADJ})";

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Node Obj)
        {
            //int Success;
            int Result = 0;
            //int valid = check(obj);
            int lessThan = -1;
            int equal = 0;
            int greaterThan = 1;
            if (INDEX < Obj)
            {
                Result = lessThan;
            }
            else if (INDEX > Obj)
            {
                Result = greaterThan;
            }
            else if (INDEX == Obj)
            {
                Result = equal;
            }
            return Result;
            //if (checkInput(obj) == 1)
            //{
            //    if (obj is Node)
            //    {
            //        Node Node = (Node)obj;
            //        int value = Node.INDEX;
            //        return valid;

            //    }
            //    else if (!(obj is Node))
            //    {
            //        Console.Error.WriteLine("obj not Node<T>");
            //        return lessThan;
            //    }
            //}
            //else if (checkInput(obj) == 0)
            //{
            //    Console.Error.WriteLine("obj is null");
            //    return lessThan;
            //}
            //return greaterThan;
            //if (obj is int)
            //{

            //}
            //else if (obj is Int64)
            //{

            //}
            //else if (obj is Int16)
            //{

            //}
            //else if (obj is float)
            //{

            //}
            //else if (obj is double)
            //{
            //}
            //else if (checkInput(obj) == 0)
            //{
            //    return lessThan;
            //}
        }
        //private int checkInput(Object o)
        //{
        //    int valid = 0;
        //    int invalid = 1;
        //    if (o == null)
        //    {
        //        return invalid;
        //    }
        //    else
        //    {
        //        return valid;
        //    }
        //    return valid;
        //}
        private int checkInput(Object O)
        {
            int valid = 1;
            int invalid = 0;
            if (O == null)
            {
                Console.Error.WriteLine("Node.CheckInput(null)");
                return invalid;
            }
            else if (O != null)
            {
                return valid;
            }
            return valid;
        }

        private int checkSource(int Source)
        {
            int Success = 0;
            int Fail = -1;
            if (Source < 0)
            {
                Console.Error.WriteLine("Source < 0");
                return Fail;
            }
            else if (Source == 0)
            {
                Console.Error.WriteLine("Source == 0");
                return Fail;
            }
            else if (Source > 0)
            {
                return Success;
            }
            return Success;
        }
    }
    //struct Node
    //{
    //    int value;
    //    //Output output;
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
    //}
}