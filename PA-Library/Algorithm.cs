//@Author Cristofor Rotsching
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

//Console.WriteLine("Hello world!");

namespace PA_Library
{
    public readonly ref struct Algorithm
    {
        [MarshalAs(UnmanagedType.IDispatch)]
        public Input input;

        public void Dispose()
        {
            
        }
        // Provides Input method for the algorithm.
    }
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
