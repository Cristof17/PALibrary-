using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    struct PAOutput
    //public readonly class BFSOutput
    //public readonly struct BFSOutput
    {
        [DllImport("palibrary")]
        public static extern  PAOutput PAOutputConstruct( PAResult rezultat);
        [DllImport("palibrary")]
        public static extern int PAOutputRuin( PAResult rezultat);
        [DllImport("palibrary")]
        public static extern  Output PAOutputInit( Output Out);
        [DllImport("palibrary")]
        public static extern int PAOutputDelete( Output o);

        public UnitateIesire(Rezultat Result)
        {
            
        }
        // private static extern BFSOutputInit();
        //BFSState State, ArrayList D, int N) : this()
        PAOutput(BFSRezultat Rezultat)
        {
            //STATE = default;
            //D = default;
            int Result;
            int Success = 0;
            int Fail = -1;
            Result = Success;
            Result = Check(Rezultat);
            if (Result == Success)
            {
                rezultat = Copy(Rezultat);
                //Result = Check(D);
                //if (Result == Success)
                //{
                //    Result = Check(N);
                //    if (Result == Success)
                //    {
                //        D = Copy(D, N);
                //    }
                //    else
                //    {
                //        Console.Error.WriteLine("N error");
                //    }
            }
            else if (Result == Fail)
            {
                Console.Error.WriteLine("state error");
            }
            //else
            //{
            //        Console.Error.WriteLine("d error");
            //    //}
            //}
        }
        //public BFSOutput(ArrayList D, int N) : this()
        //{
        //    int Result;
        //    int Success = -1;
        //    int Fail = 0;
        //    Result = Success;
        //    STATE = default;
        //    //new BFSState();
        //    D = default;
        //    Result = Check(D);
        //    if (Result == Fail)
        //    {
        //        //Console.Error.WriteLine("Adj == null");
        //        Result = Fail;
        //    }
        //    else
        //    {
        //        Result = Check(N);
        //        if (Result == Fail)
        //        {
        //            //Console.Error.WriteLine("N error");
        //            Result = Fail;
        //        }
        //        else
        //        {
        //            this.D = Copy(D, N);
        //            Result = Success;
        //        }
        //        //Result = Success;
        //    }
        //}

        int Check(BFSResult Rezultat)
        {
            int Success = 0;
            int Fail = -1;
            int Result = Fail;
            if (Rezultat == null)
            {
                Result = Fail;
            }
            else if (Rezultat != null)
            {
                Result = Success;
            }
            return Result;
            //if (Rezultat. < 0)
            //{
            //    Result = Fail;
            //}
            //else
            //{
            //    Result = Success;
            //}
            //if (Rezultat. == 0)
            //{
            //    Result = Fail;
            //}
            //else
            //{
            //    Result = Success;
            //}
            //if (N > 0)
            //{
            //    Result = Success;
            //}
            //return Result;
        }
        //public BFSOutput(ArrayList d, BFSState state)
        //{
        //    D = default;
        //    STATE = default;
        //    int Result = 0;
        //    int Success = 0;
        //    int Fail = -1;
        //    Result = Success;
        //    Result = check(d);
        //    if (Result == Fail)
        //    {
        //        Console.Error.WriteLine($"d error");
        //        D = default;
        //    }
        //    else
        //    {

        //        //D = copy(d);
        //    }
        //    //D = default(ArrayList);
        //    //STATE = default;
        //    //= default(BFSState);
        //    //int Result;
        //    //int Fail = -1;
        //    //int Success = 0;
        //    if (d == null)
        //    {
        //        Console.Error.WriteLine($"{d} == null");
        //        Result = Fail;

        //    }
        //    else
        //    {
        //        if ((Object)state == null)
        //        {
        //            Console.Error.WriteLine($"{state} == null");
        //            Result = Fail;
        //        }
        //        else
        //        {
        //            Result = Success;
        //            ArrayList copy = new ArrayList();
        //            int N = d.Count;
        //            int x = 1;
        //            int y = x + 1;
        //            while (x < (N + 1))
        //            {
        //                copy.Add(d[x]);
        //                x = y;
        //                y = x + 1;
        //            }
        //            D = copy;// (d,INDEX,d.Count);
        //        }
        //        Result = Success;
        //    }
        //    //

        //}

        //public ArrayList copy(ArrayList d, int N)
        //{
        //    ArrayList copy;
        //    copy = new ArrayList(N);
        //    int x = 0;
        //    int y = x + 1;
        //    while (x < (N + 1))
        //    {
        //        copy[x] = d[x];
        //        x = y;
        //        y = x + 1;
        //    }
        //    return copy;
        //}

        public int this[int index]
        {
            get {
                return (int)rezultat[index];
            }
            set
            {
                rezultat[index] = value;
            }
        }

        BFSResult Copy(BFSResult Rezultat)
        {
            BFSResult copy;
            copy = new BFSResult(Rezultat);
            return copy;
        }
        int Copy(int N)
        {
            int copy = 0;
            copy = N;
            return copy;
        }

        int Check(ArrayList Adj)
        {
            int Success = 0;
            int Faili = -1;
            int Result = Success;
            if (Adj == null)
            {
                Result = Faili;
            }
            else
            {
                Result = Success;
            }
            return Result;
        }

        //public BFSOutput(BFSState state)
        //{
        //    //STATE = new BFSState(state);
        //    //D = default;
        //    //Q = q;
        //    //X = x;
        //    //OUTPUT = output;
        //}

        //public BFSOutput(BFSInput Input)
        //{
        //    STATE = default;
        //    D = default;
        //}

        [StructLayout(StructLayout.Sequential)]
        private  PAOutput output;

        // BFSResult rezultat;
        //public BFSState STATE { get; }
        //public ArrayList D { get; }
        //private int INDEX { get { return 1; } }

        //public int X { get; }
        //public int this[int index]
        //{
        //    get
        //    {
        //        return (int)(D[index]);
        //    }

        //    set
        //    {
        //        D[index] = value;
        //    }
        //}

        public static explicit operator BFSOutput(ArrayList list) => (BFSOutput)list;
        public static explicit operator ArrayList(BFSOutput output) => output.rezultat.d.toArrayList(output.rezultat.d.head);

        public override string ToString() => $"({rezultat})";

        ArrayList Copy(ArrayList d, int index, int N)
        {
            ArrayList copy = default;
            int x = index;
            int y = x + 1;
            while (x < (N + 1))
            {
                copy[x] = d[x];
                x = y;
                y = x + 1;
            }
            return copy;
        }
        //public int check(ArrayList d)
        //{
        //    int Fail = -1;
        //    int Success = 0;
        //    int Result = Success;
        //    if (d == null)
        //    {
        //        Console.Error.WriteLine($"{d} == null");
        //        Result = Fail;

        //    }
        //    else
        //    {
        //        Result = Success;
        //    }
        //    return Result;
        //}

        int Check(BFSState state)
        {
            int Fail = -1;
            int Success = 0;
            int Result = Success;
            if ((Object)state == null)
            {
                Console.Error.WriteLine($"{state} == null");
                Result = Fail;
            }
            else
            {
                Result = Success;
            }
            return Result;
        }
        ArrayList Copy(ArrayList d, int N)
        {
            //int Result = default;
            //int Result = 
            //ImmutableArray copy = default;
            //copy
            ArrayList copy = default;
            copy = new ArrayList(N);
            int x = 0;
            //int y = 
            while (x < N)
            {
                copy[x] = d[x];
                x++;
            }
            return copy;
        }
    }
}

    //class BFSOutput<T> : Output<T>
    //{
    //    ArrayList d;

    //    private T this[int i]
    //    {
    //        get
    //        {
    //            if (i < 0)
    //                throw new Exception("i < 0");
    //            if (d == null)
    //                throw new Exception("d == null");
    //            if (i > d.Length)
    //                throw new Exception($"i > {d.Length}");
    //            return d[i];
    //        }
    //        set
    //        {
    //            if (i < 0)
    //                throw new Exception("i < 0");
    //            if (d == null)
    //                throw new Exception("d == null");
    //            if (i > d.Length)
    //                throw new Exception("d > d.Length");
    //            d[i] = value;
    //        }
    //    }
    //}