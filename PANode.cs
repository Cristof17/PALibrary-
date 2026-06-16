// using System.Linq.Expressions;
using PA_Library;
// using System.Reflection;
// using System.InteropServices;
// using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
// using System.Xml.XPath;

namespace PA_Library
{
    // [StructLayout(LayoutKind.Sequntial)]
    // struct PAElement
    public class PANode
    {
    // [DllImport("palibrary")]
    // public static extern  PAElement PAElementConstruct(PAData Data, PAElement Next, PAStatus Status);
    // [DllImport("palibrary")]
    // public static extern int PAElementRuin(PAData Data,  PAElement Next, PAStatus Status);
    // [DllImport("palibrary")]
    // public static extern PAElement PAElementInit(PAElement e);
    // [DllImport("palibrary")]
    // public static extern int PAElementDelete(PAElement PA);
    // [DllImport("palibrary")]
    // public static extern void PAElementVisit();
    // [DllImport("palibrary")]
    // public static extern int PAElementIsVisited();
    // [DllImport("palibrary")]
        public PAElement element;

        public PANode()
        {
            
        }

        public PANode(PAData index, PANode next)
        {
            
        }
    
        public PANode(PAData index, PANode next, PAStatus status)
        {

        }
        // Node)
        // {
        //     data = Node.data;
        //     next = Node.next;
        //     //stare = PAStare.NOT_VISITED;
        // }
        // public PAElement(PAData Data)
        // {
        //     data = Data;
        //     next = default;
        // }
        // public PAElement(PAData Data, PAElement Next)
        // {
        //     data = Data;
        //     next = Next;
        //     //stare = PAStare.NOT_VISITED;
        // }
        // //public PAElement(PA)
        // public PAElement(PAElement node, PAElement neigh)
        // {
        //     data = node.data;
        //     next = neigh;
        // }
        //public PAElement(long Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PAElement(short Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PAElement(ushort Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PAElement(ulong Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PAElement(PAElement Nod)
        //{
        //    data = Nod.data;
        //    next = Nod.next;
        //    stare = Nod.stare;
        //}
        //public PAElement(PAData Data, PAElement Next, PAStare Stare)
        //{
        //    data = Data;
        //    next = Next;
        //    stare = Stare;
        //}
        // [StructLayout(LayoutKind.Sequential)]
        // private PAElement element;
        // PAData data { get; set; }
        // public PAElement next { get; set; }

        //struct PAStare
        //public PAStare stare { get; }

        // public static operator ++(PANode node) => node.element.index.value.value.value++;
        // public static PAElement operator ++(PAElement a) => a.data.toPAElement();//;
        // public static explicit operator PAData(PANode d) => d.;
        // public static implicit operator byte(PAElement d) => (byte)d.data.value;
        // public static explicit operator PAElement(byte b) => Copy(b);
        // public static implicit operator int(PAElement d) => (int)d.data.value;
        // public static explicit operator PAElement(int b) => Copy(b);
        // public static implicit operator long(PAElement d) => (long)d.data.value;
        // public static explicit operator PAElement(long b) => Copy(b); //new PAElement(b);
        // public static implicit operator short(PAElement d) => (short)d.data.value;
        // public static explicit operator PAElement(short b) => Copy(b); //new PAElement(b);
        // public static implicit operator ushort(PAElement d) => (ushort)d.data.value;
        // public static explicit operator PAElement(ushort b) => Copy(b);// new PAElement(b);
        // public static implicit operator ulong(PAElement d) => (ulong)d.data.value;
        // public static explicit operator PAElement(ulong b) => Copy(b);// new PAElement(b);

        // public static PAElement operator ++(PAElement a) => a.data.toPAElement();//;
        // public static explicit operator PAData(PAElement d) => d.data;
        // public static implicit operator byte(PAElement d) => (byte)d.data.value;
        // public static explicit operator PAElement(byte b) => Copy(b);
        // public static implicit operator int(PAElement d) => (int)d.data.value;
        // public static explicit operator PAElement(int b) => Copy(b);
        // public static implicit operator long(PAElement d) => (long)d.data.value;
        // public static explicit operator PAElement(long b) => Copy(b); //new PAElement(b);
        // public static implicit operator short(PAElement d) => (short)d.data.value;
        // public static explicit operator PAElement(short b) => Copy(b); //new PAElement(b);
        // public static implicit operator ushort(PAElement d) => (ushort)d.data.value;
        // public static explicit operator PAElement(ushort b) => Copy(b);// new PAElement(b);
        // public static implicit operator ulong(PAElement d) => (ulong)d.;
        // public static explicit operator PAElement(ulong b) => Copy(b);// new PAElement(b);
        public static PAElement Copy(byte Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = (int)Data;
    //         node = new PAElement(data, node);
    //         return node;
    //     }
    //     public static PAElement Copy(long Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = (int)Data;
    //         node = new PAElement(data, node);
    //         return node;
    //     }
    //     public static PAElement Copy(int Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = Data;
    //         node = new PAElement(data, node);
    //         return node;
    //     }
    //     public static PAElement Copy(short Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = (int)Data;
    //         node = new PAElement(data, node);
    //         //node = new PAElement(data, node, stare);
    //         return node;
    //     }
    //     public static PAElement Copy(ushort Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = (int)(uint)Data;
    //         node = new PAElement(data, node);

    //         //node = new PAElement(data, node, stare);
    //         return node;
    //     }
    //     public static PAElement Copy(uint Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = (int)Data;
    //         node = new PAElement(data, node);

    //         //node = new PAElement(data, node, stare);
    //         return node;
    //     }
    //     public static PAElement Copy(ulong Data)
    //     {
    //         PAData data;
    //         PAElement node = default;
    //         data.value = (int)(uint) Data;
    //         node = new PAElement(data, node);

    //         //node = new PAElement(data, node, stare);
    //         return node;
    //     }

    //     public PAElement this[int index]
    //     {
    //         get
    //         {
    //             return Get(Copy(this), index);
    //         }
    //         set
    //         {

    //         }
    //     }
    //     PAElement Get(PAElement nod, int index)
    //     {
    //         PAElement x = Copy(this);
    //         if (index == 1)
    //             x = Copy(this);
    //         else if (index < 0)
    //         {
    //             x = Copy(this);
    //         }
    //         else if (index > 1)
    //         {
    //             x = Get(nod.next, index - 1);
    //         }
    //         return x;
    //             //PAElement nod;
    //         //return nod;
    //     }
    // }
    }
}