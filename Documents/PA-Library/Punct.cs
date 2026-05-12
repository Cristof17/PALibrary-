using System.Linq.Expressions;
using PA_Library;
using System.Reflection;
using System.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequntial)]
    struct PAElement
    //public struct PANod
    {
    [DllImport("palibrary")]
    public static extern  PAElement PAElementConstruct(PAData Data, PAElement Next, PAStatus Status);
    [DllImport("palibrary")]
    public static extern int PAElementRuin(PAData Data,  PAElement Next, PAStatus Status);
    [DllImport("palibrary")]
    public static extern  PAElement PAElementInit(PAElement e);
    [DllImport("palibrary")]
    public static extern int PAElementDelete(PAElement PA);
    [DllImport("palibrary")]
    public static extern void PAElementVisit();
    [DllImport("palibrary")]
    public static extern int PADataIsVisited();
    // [DllImport("palibrary")]
    public Punct(Data index, Punct next, Stare status)
    {
        
    } 
        // Node)
        // {
        //     data = Node.data;
        //     next = Node.next;
        //     //stare = PAStare.NOT_VISITED;
        // }
        // public PANod(PAData Data)
        // {
        //     data = Data;
        //     next = default;
        // }
        // public PANod(PAData Data, PANod Next)
        // {
        //     data = Data;
        //     next = Next;
        //     //stare = PAStare.NOT_VISITED;
        // }
        // //public PANod(PA)
        // public PANod(PANod node, PANod neigh)
        // {
        //     data = node.data;
        //     next = neigh;
        // }
        //public PANod(long Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PANod(short Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PANod(ushort Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PANod(ulong Nod)
        //{
        //    data = Nod;
        //    next = Nod;
        //    stare = PAStare.NOT_VISITED;
        //}
        //public PANod(PANod Nod)
        //{
        //    data = Nod.data;
        //    next = Nod.next;
        //    stare = Nod.stare;
        //}
        //public PANod(PAData Data, PANod Next, PAStare Stare)
        //{
        //    data = Data;
        //    next = Next;
        //    stare = Stare;
        //}
        // [StructLayout(LayoutKind.Sequential)]
        private PAElement element;
        // PAData data { get; set; }
        // public PANod next { get; set; }

        //struct PAStare
        //public PAStare stare { get; }

        //public void operator ++() => data.value++;
        public static PANod operator ++(PANod a) => a.data.toPANod();//;
        public static explicit operator PAData(PANod d) => d.data;
        public static implicit operator byte(PANod d) => (byte)d.data.value;
        public static explicit operator PANod(byte b) => Copy(b);
        public static implicit operator int(PANod d) => (int)d.data.value;
        public static explicit operator PANod(int b) => Copy(b);
        public static implicit operator long(PANod d) => (long)d.data.value;
        public static explicit operator PANod(long b) => Copy(b); //new PANod(b);
        public static implicit operator short(PANod d) => (short)d.data.value;
        public static explicit operator PANod(short b) => Copy(b); //new PANod(b);
        public static implicit operator ushort(PANod d) => (ushort)d.data.value;
        public static explicit operator PANod(ushort b) => Copy(b);// new PANod(b);
        public static implicit operator ulong(PANod d) => (ulong)d.data.value;
        public static explicit operator PANod(ulong b) => Copy(b);// new PANod(b);
        public static PANod Copy(byte Data)
        {
            PAData data;
            PANod node = default;
            data.value = (int)Data;
            node = new PANod(data, node);
            return node;
        }
        public static PANod Copy(long Data)
        {
            PAData data;
            PANod node = default;
            data.value = (int)Data;
            node = new PANod(data, node);
            return node;
        }
        public static PANod Copy(int Data)
        {
            PAData data;
            PANod node = default;
            data.value = Data;
            node = new PANod(data, node);
            return node;
        }
        public static PANod Copy(short Data)
        {
            PAData data;
            PANod node = default;
            data.value = (int)Data;
            node = new PANod(data, node);
            //node = new PANod(data, node, stare);
            return node;
        }
        public static PANod Copy(ushort Data)
        {
            PAData data;
            PANod node = default;
            data.value = (int)(uint)Data;
            node = new PANod(data, node);

            //node = new PANod(data, node, stare);
            return node;
        }
        public static PANod Copy(uint Data)
        {
            PAData data;
            PANod node = default;
            data.value = (int)Data;
            node = new PANod(data, node);

            //node = new PANod(data, node, stare);
            return node;
        }
        public static PANod Copy(ulong Data)
        {
            PAData data;
            PANod node = default;
            data.value = (int)(uint) Data;
            node = new PANod(data, node);

            //node = new PANod(data, node, stare);
            return node;
        }

        public PAElement this[int index]
        {
            get
            {
                return Get(Copy(this), index);
            }
            set
            {

            }
        }
        PANod Get(PANod nod, int index)
        {
            PANod x = Copy(this);
            if (index == 1)
                x = Copy(this);
            else if (index < 0)
            {
                x = Copy(this);
            }
            else if (index > 1)
            {
                x = Get(nod.next, index - 1);
            }
            return x;
                //PANod nod;
            //return nod;
        }
    }
}