using System;
using PA_Library;
using System.Runtime.InteropServices;
    [StructLayout(LayoutKind.Sequential)]
    // [StructLayout(LayoutKind.Sequential)]
    struct PAResource
    {
        [DllImport("pa")]
        static extern PAResource PAResourcePerformConstruct();
        [DllImport("pa")]
        static extern PAResource PAResourcePerformInit(PAResource resource, PANumber number);
        [DllImport("pa")]
        static extern int PAResourcePerformFinish(PAResource PA);
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [DllImport("pa")]
        static extern int PAResourcePerformRuin(PAResource PA);
    // public PAResource Resource;

    // [FieldOffset(0)]
        public PANumber Value;
        // public Resursa(int value)
        public PAResource(int value)
        {

        }
    }