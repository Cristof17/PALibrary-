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
        static extern PAResource PAResourcePerformInit();
        [DllImport("pa")]
        static extern int PAResourcePerformFinish();
        // [DllImport("pa")]
        // static extern PAResourcePerformD();
        [DllImport("pa")]
        static extern int PAResourcePerformRuin();
    // public PAResource Resource;

    // [FieldOffset(0)]
        public PANumber Value;
        // public Resursa(int value)
        public PAResource(int value)
        {

        }
    }