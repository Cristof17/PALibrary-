//  using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;

//namespace PA_Library
//{
//    public class Algorithm<T>
//    {
//        private Input<T> Input;
//        private Output<T> output;
//        //protected T N;
//        //protected T M;
//        //protected List<T> Adj;
//    }
//}
using PA_Library;
using System;
using System.Collections;
using System.Runtime.InteropServices;

//Console.WriteLine("Hello world!");

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Algorithm {
        
        [DllImport("palibrary")]
        public static extern Output run( Input input);
        
        // [FieldOffset(0)]
        private Input In { get; }
        // [StructLayout(LayoutKind.Sequential)]
        // public readonly struct Algorithm algorithm;

        // public Algorithm(IntrareSistem input)
        public Algorithm(Input input) : this()
        {
            
        }
    }
    // {
        //Input in
        //Output run(Input)
        // Provides Input method for the algorithm.
    // }
};
//public System.Collections.Generic.IEnumerator<Node> GetEnumerator()
//{
//    //throw new NotImplementedException();
//    yield return default(Node);
//}
//}
//class YourClass
//{
//}

//struct Algorithm
//{
//    Input Input;
//    Output output;
//}

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
