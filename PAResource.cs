using System.Runtime.InteropServices;
using PA_Library;

namespace PA_Library
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PAResource : StateMachine
    {
        public PAResource(PANumber Number)
        {
            value = PANumber.PANumberPerformConstruct();
            value = PANumber.PANumberPerformCopy(Number, value);
        }
        private PANumber value;

        [DllImport("pa")]
        internal static extern PAResource PAResourcePerformConstruct();
        [DllImport("pa")]
        internal static extern PAResource PAResourcePerformInit([MarshalAs(UnmanagedType.IUnknown)] PAResource resource, [MarshalAs(UnmanagedType.IUnknown)] PANumber number);
        [DllImport("pa")]
        internal static extern PAResource PAResourcePerformCopy([MarshalAs(UnmanagedType.IUnknown)] PAResource from, [MarshalAs(UnmanagedType.IUnknown)] PAResource to);
        [DllImport("pa")]
        internal static extern int PAResourcePerformDelete([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [DllImport("pa")]
        internal static extern int PAResourcePerformRuin([MarshalAs(UnmanagedType.IUnknown)] PAResource PA);

        public void Construct()
        {
            Initialise();
            // throw new System.NotImplementedException();
        }

        public void Initialise()
        {
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
            throw new System.NotImplementedException();
        }
    }
}