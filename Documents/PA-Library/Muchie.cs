using PA_Library;
using System;
using System.Runtime.InteropServices;
namespace PA_Library
{
	public class Muchie
	//public struct PAMuchie
	{
		[DllImport("palibrary")]
        public static extern void PALinkConstruct();
		[DllImport("palibrary")]
        public static extern void PALinkInit();
		[DllImport("palibrary")]
        public static extern void PALinkRuin();
		[DllImport("palibrary")]
        public static extern void PALinkDelete();
		//public
		//{
			//Console.WriteLine("Hello world!");
			// Muchie(PAElement Node, PAElement Neigh)
			// // Muchie(PANod Node, PANod Neigh)
			// {
			// 	p = default;
			// 	//Node;
			// 	//NEIGH = default;// Neigh;

			// 	int Success = 0;
			// 	int Fail = -1;
			// 	int Result = Success;
			// 	//Result = check(Node);
			// 	if (Node == null)
			// 	{
			// 		//Console.Error.WriteLine($"{Node} == null");
			// 		Result = Fail;
			// 	}
			// 	else if (Node != null)
			// 	{
			// 		Result = Success;
			// 		if (Neigh == null)
			// 		{
			// 			//Console.Error.WriteLine($"{Neigh} == null");
			// 			Result = Fail;
			// 		}
			// 		else if (Neigh != null)
			// 		{
			// 			Result = Success;
			// 		}
			// 	}
			// 	if (Result == Fail)
			// 	{
			// 		Node = default;
			// 		neigh = default;
			// 	}
			// 	else
			// 	{
			// 		if (Neigh == null)
			// 		{
			// 			//Console.Error.WriteLine($"{Neigh} == null");
			// 			Result = Fail;
			// 		}
			// 		else
			// 		{
			// 			Result = Success;

			// 		}
			// 		//Result = check(Neigh);
			// 		if (Result == Success)
			// 		{
			// 			//Node copy = default;
			// 			node = new PANod(Node);
			// 			neigh = new PANod(Neigh);
			// 			//;
			// 			//copy = new Node(Neigh);
			// 			//NEIGH = copy;
			// 			//NEIGH = copy(Neigh);
			// 		}
			// 		else if (Result == Fail)
			// 		{
			// 			node = default;
			// 			neigh = default;
			// 		}
			// 	}
			// }

			// private PAPair p;
			// private PAPereche p;
			//public Node NODE { get; }
			//public Node NEIGH { get; }

			// int Check(PANod Node, PANod Neigh)
			// {
			// 	int Success = 0;
			// 	int Fail = 0;
			// 	int Result = Success;
			// 	if (Node == null)
			// 	{
			// 		//Console.Error.WriteLine($"{Node} == null");
			// 		Result = Fail;
			// 	}
			// 	else
			// 	{
			// 		Result = Success;
			// 		if (Neigh == null)
			// 		{
			// 			//Console.Error.WriteLine($"{Neigh} == null");
			// 			Result = Fail;
			// 		}
			// 		else
			// 		{
			// 			Result = Success;
			// 		}
			// 	}
			// 	return Result;
			// }

			// [StructLayout(LayoutKind.Sequential)]
			// private PALink link;
			// PANod node { get; }
			// PANod neigh { get; }
			// int Copy(PANod Node)
			// {
			// 	PANod copy = default;
			// 	copy = new PANod(Node);
			// 	//copy.next = Node.next;
			// 	return copy;
			// }
			// public override string ToString() => $"({node}, {neigh})";
		}
		//class YourClass
		//{
		//}

		//struct Muchie
		//{
		//    Node Node;
		//    Node Neigh;
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