// using System;
// using System.Collections;
// namespace PA_Library
// {
//     public struct SituatieSistem
//     {
//         //public BFSState(Stack q/*, int x*/)
//         public SituatieSistem(BFSState bfsState)
//         {
//             D = default;
//             EDGE = default;
//             if ((Object)bfsState != null)
//             {
//                 if (bfsState.D != null)
//                 {
//                     D = new ArrayList();
//                 }
//                 else if (bfsState.D == null)
//                 {
//                     Console.Error.WriteLine("bfsState.D == null");
//                     D = default;
//                 }
//                 if ((Object)bfsState.EDGE != null)
//                 {
//                     EDGE = new Edge(bfsState.EDGE.NODE, bfsState.EDGE.NEIGH);
//                     //EDGE.NODE = bfsState.EDGE.NODE;
//                     //EDGE.NEIGH = bfsState.EDGE.NEIGH;
//                 }
//                 else if ((Object)bfsState == null)
//                 {
//                     Console.Error.WriteLine("bfsState.EDGE == null");
//                     EDGE = default;
//                 }
//             }
//             else
//             {
//                 Console.Error.WriteLine("bfsState == null");
//                 D = default;
//             }
//         }
//         public SituatieSistem(ArrayList d, Node Node, Node Neigh)
//         {
//             //q = new Stack();
//             D = default;
//             EDGE = default;
//             D = new ArrayList();
//             int x = 0;
//             int y = x + 1;
//             if (d != null)
//             {
//                 int N = d.Count;
//                 while (x < N)
//                 {
//                     D.Add(d[x]);
//                     x++;
//                     y++;
//                 }
//             }
//             else
//             {
//                 Console.Error.WriteLine("d == null");
//                 D = default;
//             }
//             EDGE = new Edge(Node, Neigh);
//             //OUTPUT = output;
//         }

//         public ArrayList D { get; }
//         public Edge EDGE { get; }
//         //public override string ToString() => $"({X})";

//         //public override string ToString() => $"({Q})";
//         public override string ToString() => $"({D}, {EDGE})";

//     }
// }
