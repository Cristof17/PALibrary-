using System;
public readonly ref struct PAIndex
{
    public void Dispose()
    {
        
    }
    [MarshalAs(UnmanagedType.IDispatch)]
    int value;
}