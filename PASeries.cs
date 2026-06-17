using System.Runtime.InteropServices;
using System.Xml.Schema;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PASeries : StateMachine
    {
        public PASeries(PACount M, PAElement[] ADJ) : this()
        {
            m = PACount.PACountPerformConstruct();
            m = PACount.PACountPerformCopy(M, m);

            PACount x = PACount.PACountPerformConstruct();
            while (x < M)
            {
                PAElement aux = PAElement.PAElementPerformConstruct();
                aux = PAElement.PAElementPerformCopy(ADJ[x], aux);
                adj[x] = PAElement.PAElementPerformCopy(aux, adj[x]);
                x++;
            }

            // PASeriesPerformCopy(ADJ,adj);
            // PAList.PAListPerformCopy(ADJ,adj);
            // PASeries series;
            // PACount x = PACount.PACountPerformConstruct();
            // while (x.)
        }

        internal static PASeries copy(PASeries from, PASeries to)
        {
            PASeries copy;
            copy = PASeriesPerformConstruct();
            PACount x;
            // PACount y;
            x = PACount.PACountPerformConstruct();
            // y = PACount.PACountPerformConstruct();
            // PACount n;
            // PACount m;
            while (x < from.m)
            {
                PAElement aux = from.adj[x];
                copy.adj[x] = aux;
                x++;
            }
            x = PACount.PACountPerformDelete(x);
            x = PACount.PACountPerformRuin(x);
            x = PACount.PACountPerformConstruct();
            // x = PACountPerformConstruct();;
            while (x < from.m)
            {
                PAElement aux = copy.adj[x];
                to.adj[x] = aux;
                x++;
            }
            return to;
            // PACount fromCount = from.C
        }
        private PACount m;

        private PAElement[] adj;

        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformConstruct();
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformInit([MarshalAs(UnmanagedType.IUnknown)] PASeries Series, [MarshalAs(UnmanagedType.IUnknown)] PACount M, [MarshalAs(UnmanagedType.IUnknown)] in PAElement[] adj);
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformCopy([MarshalAs(UnmanagedType.IUnknown)] PASeries Series1, [MarshalAs(UnmanagedType.IUnknown)] PASeries Series);
        [DllImport("pa")]
        internal static extern PAResource PASeriesGet([MarshalAs(UnmanagedType.IUnknown)] PAData Data);
        [DllImport("pa")]
        internal static extern void PASeriesPerformPrint([MarshalAs(UnmanagedType.IUnknown)] PASeries Series);
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformDelete([MarshalAs(UnmanagedType.IUnknown)] PASeries PA);
        [DllImport("pa")]
        internal static extern PASeries PASeriesPerformRuin([MarshalAs(UnmanagedType.IUnknown)] PASeries PA);

        public void Construct()
        {
            Initialise();
            // throw new System.NotImplementedException();
        }

        public void Initialise()
        {
            // Finish();
            Delete();
            // throw new System.NotImplementedException();
        }

        public void Delete()
        {
            Finish();
            // throw new System.NotImplementedException();
        }

        public void Finish()
        {
            // throw new System.NotImplementedException();
        }
    }
}
// }
