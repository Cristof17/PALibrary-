using System;
using PA_Library;
using System.Runtime.InteropServices;
    [StructLayout(LayoutKind.Sequential)]
    // [StructLayout(LayoutKind.Sequential)]
    struct PAResource
    {
        [DllImport("pa")]
        static extern PAResourcePerformConstruct();
        [DllImport("pa")]
        static extern PAResourcePerformInit();
        [DllImport("pa")]
        static extern PAResourcePerformFinish();
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [DllImport("pa")]
        static extern PAResourcePerformRuin();
    // public PAResource Resource;

    // [FieldOffset(0)]
        public PANumber Value;
        // public Resursa(int value)
        public PAResource(int value)
        {

        }
    }