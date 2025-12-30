//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace PA_Library
//{
//    class Output<T>
//    {
//        public ArrayList Result;
//    }
//}
//using PA_Library;
using System;
using System.Collections;
using System.Collections.Immutable;

//Console.WriteLine("Hello world!");

namespace PA_Library
{
    public readonly struct Output
    {
        //readonly int[] d;
        public Output(BFSOutput bfsOutput)
        {
            //NODE = default(int);
            //int valid = default;
            //valid = checkInput(bfsOutput);
            D = default;
            int Success = 0;
            int Fail = -1;
            int Result = Success;
            Result = check((Object)bfsOutput);
            if (Result == Fail)
            {
                Console.Error.WriteLine("bfsOutput error");
            }
            else
            {
                D = copy(bfsOutput.D, bfsOutput.STATE.N);

            }
            //if ((Object)bfsOutput != null)
            //{
            //    //Console.Error.WriteLine("bfsOutput == null");
            //    //Console.Error.WriteLine("bfsOutput == null");
            //    if (bfsOutput.D == null)
            //    {
            //        Console.Error.WriteLine("bfsOutput.D == null");
            //        D = default;
            //    }
            //    else if (bfsOutput.D != null)
            //    {
            //        int N = bfsOutput.STATE.N;
            //        D = new int[N];
            //        int x = default;
            //        int y = default;
            //        while (x < N)
            //        {
            //            D[x] = ((int)bfsOutput.D[x]);
            //            x++;
            //            y++;
            //        }
            //    }
            //    //D = default;
            //}
            //else if ((Object)bfsOutput == null)
            //{
            //    Console.Error.WriteLine("bfsOutput == null");
            //    D = default;
            //}
            ////int Input = default;
            //BFSState state = default;
            //Node Node = default;
            //Stack q = default(Stack);
            //ImmutableArray<Node> d = default;
            //state = bfsOutput.STATE;
            //Node = state.EDGE.NODE;
            //q = state.Q;
            //d = state.D;
            //Input = checkValue(Node.VALUE);
            //if (!valid)
            //{

            //}
            //if ((valid == 1) && (Input == 1))
            //{
            //if (q.Count == 0)
            //{
            //D = default(int[]);
            //}
            //else if (q.Count == 1)
            //{
            //D = new int[q.Count + 2];//q.Count() + 2
            //}
            //else if (q.Count > 1)
            //{
            //D = initArray(Node,d);
            //}
            //}
            //}.VALUE < 0)
            //{
            //Console.Error.WriteLine("Node.VALUE < 0");
            //D = default(int[]);
            // }
            //else if (Node.VALUE == 0)
            //{

            //}
            //D = initArray(bfsOutput.STATE.NODE, bfsOutput.STATE.Q, bfsOutput.STATE.D);
            //}
            //{
            //    D = default(int[]);
            //}
            //else
            //{
            //    //NODE = bfsOutput.STATE.NODE.VALUE;
            //}
            //}
            //}
            //d = new ArrayList();
            //int i = defaut;
            //..int j;

        }

        public ArrayList copy(ArrayList d, int N)
        {
            //int Success = 0;
            //int Fail = -1;
            //int Result = Success;
            ArrayList copy;
            copy = new ArrayList(N);
            int x = 0;
            while (x < N)
            {
                copy[x] = (d[x]);
                x++;
            }
            return copy;
        }
        public int check(Object output)
        {
            int Result;
            int Success = 0;
            int Fail = -1;
            Result = Success;
            if (output == null)
            {
                Console.Error.WriteLine("output == null");
                Result = Fail;
            }
            else
            {
                Result = Success;
            }
            return Result;
            // Success
        }
        private static int[] initArray(Node Node, ImmutableArray<int> d)
        {
            int[] D = default(int[]);
            int N = Node.INDEX;
            int i = default(int);
            int j = default(int);
            D = new int[N + 2];
            i = 1;
            j = i + 1;
            while (i < N)
            {
                D[i] = -1;
                i = j;
                j = i + 1;
            }
            i = 1;
            j = i + 1;
            while (i < N)
            {
                D[i] = d[i];
                i = j;
                j = i + 1;
            }
            return D;
        }

        public PARezultat rezultat { get; }
        //public ArrayList D { get; }

        private static int checkValue(int Node)
        {
            int valid = 1;
            int invalid = 0;

            if (Node < 0)
            {
                Console.Error.WriteLine("Node < 0");
                valid = invalid;
            }
            else if (Node == 0)
            {
                Console.Error.WriteLine("Node == 0");
                valid = invalid;
            }
            return valid;
        }
        private static int checkInput(BFSOutput bfsOutput)
        {
            int valid = (1);
            int invalid = (0);
            Object bfsOutputObject = (Object)bfsOutput;
            if (bfsOutputObject == null)
            {
                Console.Error.WriteLine("bfsOutput == null");
                return invalid;
            }
            else if (bfsOutputObject != null)
            {
                Object outputStateObject = (Object)bfsOutput.STATE;
                if (outputStateObject == null)
                {
                    Console.Error.WriteLine("state == null");
                    return invalid;
                }
                else if (outputStateObject != null)
                {
                    ////Object stackObject = Q;
                    //if (stackObject == null)
                    //{
                    //    Console.Error.WriteLine("q == null");
                    //    return invalid;
                    //}
                    //else if (stackObject != null)
                    //{
                    //    Object nodeObject = bfsOutput.STATE.NODE;
                    //    if (nodeObject == null)
                    //    {
                    //        Console.Error.WriteLine("Node == null");
                    //        return invalid;
                    //    }
                    //    else if (nodeObject != null)
                    //    {
                    //        return valid;
                    //    }
                    //}
                }
            }
            return valid;
        }
        public override string ToString() => $"({D})";
    }
    //class YourClass
    //{
    //}

    //struct Output
    //{
    //    ArrayList d;
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