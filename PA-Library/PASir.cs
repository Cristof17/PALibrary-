//@Author Cristofor Rotsching
using System;
namespace PA_Library
{
    public readonly ref struct PASir
    {
        public void Dispose()
        {
            
        }
        [MarshalAs(UnmanagedType.IDispatch)]
        public PACardinal n;
        [MarshalAs(UnmanagedType.IDispatch)]
        public PAIndex[] adj;
    }
}